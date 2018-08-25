using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;

namespace RotoChips.ImageProcessing
{
    // this class implements a "mover/scaler" effect of the assembled image
    // which is shown after the puzzle has been completed
    // it is also used in the gallery
    public class ImageScaler : MonoBehaviour
    {
        public float sizeRatio = 4; // this is a ration between the maximum and minimum size factors
                                    //public int LevelId;

        float screenAspectRatio;
        float finalXYScale;
        float minSizeFactor, maxSizeFactor;
        float xScale, yScale;

        public float fadeDuration;
        public int fadeCount;
        public int effectSteps;
        public GameObject FinalImageCanvas;     // a parent canvas
        public GameObject[] FinalRawImage;      // some (two) RawImage objects, one above another
        public GameObject listener;             // a listener GameObject, receiving message "ScalerFinished"
        public float AfterWait = 5f;            // time in seconds to wait after all is done

        int imgCount;                           // the number of FinalRawImages
                                                //Image[] FinalImage;
        RawImage[] FinalImage;                  // RawImages themselves (their textures are affected)
        RectTransform[] rt;                     // RectTransforms of FinalRawImages
        float canvasWidth, canvasHeight;
        bool stopScaling;
        bool painterFinished;

        // this method does all the preparation staff for image scaling
        // it is an IEnumerator type because it may enter a wait cycle for a "final" (STRESSed) image
        // after preparation is complete it yields into the FinalImageLoop
        IEnumerator preloadImages()
        {
            painterFinished = false;
            stopScaling = true;
            int currentGalleryLevel = (int)(long)AppData.instance[AppData.Storage.GalleryLevel];
            LevelData.Descriptor ld = LevelData.instance[currentGalleryLevel];

            // calculate x and y scaling factors of both images (they are the same)
            finalXYScale = ld.init.finalXYScale;
            screenAspectRatio = (float)(Screen.width) / (float)(Screen.height);
            float pic2screenRatio = (finalXYScale >= screenAspectRatio) ? (finalXYScale / screenAspectRatio) : (screenAspectRatio / finalXYScale);
            xScale = (finalXYScale >= screenAspectRatio) ? pic2screenRatio : 1f;
            yScale = (finalXYScale >= screenAspectRatio) ? 1f : pic2screenRatio;
            minSizeFactor = 1f;
            maxSizeFactor = minSizeFactor * sizeRatio;
            imgCount = FinalRawImage.GetUpperBound(0) + 1;

            // force the size of the canvas to be the size of the screen
            canvasWidth = (float)(Screen.width);
            canvasHeight = (float)(Screen.height);
            Vector2 canvasResolution = new Vector2(canvasWidth, canvasHeight);
            FinalImageCanvas.GetComponent<CanvasScaler>().referenceResolution = canvasResolution;

            FinalImage = new RawImage[imgCount];
            rt = new RectTransform[imgCount];
            //string TileImgPath = ld.GraphicsResource;
            for (int i = 0; i < imgCount; i++)
            {
                FinalImage[i] = FinalRawImage[i].GetComponent<RawImage>();
                // ---- force full opacity of the image ----
                Color c = FinalImage[i].color;
                c.a = 0f;
                FinalImage[i].color = c;
                // -----------------------------------------
                string imgName = (i == 0 ? "/final" : "/smooth");
                if (i == 0)
                {
                    // upper (STRESSed) image
                    string finalImageName = GlobalManager.Instance.MImage.StressedFinalImageFile(currentGalleryLevel);
                    // the image may be not ready yet, so wait for the image generatorß
                    while (!GlobalManager.Instance.MImage.HasFinalImage(currentGalleryLevel))
                    {
                        yield return new WaitForFixedUpdate();
                    }
                    Texture2D tex = new Texture2D(2, 2, TextureFormat.RGBA32, false);
                    tex.LoadImage(System.IO.File.ReadAllBytes(finalImageName));
                    FinalImage[i].texture = tex;
                }
                else
                {
                    // lower (normal) image
                    FinalImage[i].texture = Resources.Load<Texture>(ld.GraphicsResource + imgName);
                }

                rt[i] = FinalRawImage[i].GetComponent<RectTransform>();
                rt[i].SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, canvasWidth);
                rt[i].SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, canvasHeight);
                rt[i].localScale = new Vector3(xScale, yScale, 1f);
                rt[i].localPosition = Vector2.zero;
            }

            stopScaling = false;
            StartCoroutine(finalImageLoop());
        }

        // this method calculates the ending scale factor
        float getScale2()
        {
            return minSizeFactor + UnityEngine.Random.value * (maxSizeFactor - minSizeFactor);
        }

        // this method calculates the destination point of an image center
        Vector3 getPos2(float newScale)
        {
            float newX = (0.5f - UnityEngine.Random.value) * canvasWidth * (1 - newScale * xScale);
            float newY = (0.5f - UnityEngine.Random.value) * canvasHeight * (1 - newScale * yScale);
            return new Vector3(newX, newY, 0f);
        }

        // this method changes image(s) opacity (final effect, when the "wet brush painter" has finished)
        IEnumerator imageOpacity(float aStart, float aEnd, int lImgCount)
        {
            Color[] imageFadeColor = new Color[lImgCount];
            for (int j = 0; j < lImgCount; j++)
            {
                imageFadeColor[j] = FinalImage[j].color;
                imageFadeColor[j].a = aStart;
            }

            float deltaVal = (aEnd - aStart) / fadeCount;
            float fadeTime = fadeDuration / fadeCount;
            yield return new WaitForFixedUpdate();
            stopScaling = false;
            for (int i = 0; i < fadeCount && !stopScaling; i++)
            {
                for (int j = 0; j < lImgCount; j++)
                {
                    imageFadeColor[j].a += deltaVal;
                    FinalImage[j].color = imageFadeColor[j];
                }
                yield return new WaitForSeconds(fadeTime);
            }
            for (int j = 0; j < lImgCount; j++)
            {
                imageFadeColor[j].a = aEnd;
                FinalImage[j].color = imageFadeColor[j];
            }
        }

        // callback method; called when the texture painter paints all the upper image
        public void PainterFinished()
        {
            painterFinished = true;
        }

        // this is the main loop of images scaling
        IEnumerator finalImageLoop()
        {
            // make images non-transparent
            StartCoroutine(imageOpacity(0f, 1f, imgCount));

            // now move and scale the 'final' image randomly
            float sizeFactor0 = minSizeFactor;                              // start scaling
            float sizeFactor1 = getScale2();                                // end scaling
            float deltaSize = (sizeFactor1 - sizeFactor0) / effectSteps;    // scaling step
            float sizeFactor = sizeFactor0;                                 // current scaling
            Vector3 imgPos0 = rt[0].localPosition;                          // start position
            Vector3 imgPos1 = getPos2(sizeFactor1);                         // end position
            Vector3 deltaPos = (imgPos1 - imgPos0) / effectSteps;           // position step
            Vector3 imgPos = imgPos0;                                       // current position
                                                                            //Debug.Log ("sizeFactor0=" + sizeFactor0.ToString () + ", sizeFactor1=" + sizeFactor1.ToString () + ", imgPos0=" + imgPos0.ToString () + ", imgPos1=" + imgPos1.ToString ());

            bool stopAfterLoop = false;     // last loop flag
            int c = effectSteps;            // loop counter

            while (!stopScaling)
            {
                //yield return new WaitForFixedUpdate ();
                //continue;
                for (int j = 0; j < imgCount; j++)
                {
                    rt[j].localScale = new Vector3(xScale * sizeFactor, yScale * sizeFactor, 1.0f);
                    rt[j].localPosition = imgPos;
                }
                yield return new WaitForFixedUpdate();
                sizeFactor += deltaSize;
                imgPos += deltaPos;
                c--;
                if (c == 0)
                {
                    //Debug.Log ("bX: " + imgPos.x.ToString () + "-" + (canvasWidth / 2).ToString () + "=" + (imgPos.x - canvasWidth / 2).ToString () + " (" + (-rt [0].rect.width / 2).ToString () + "); " + imgPos.y.ToString () + "+" + (canvasWidth / 2).ToString () + "=" + (imgPos.x + canvasWidth / 2).ToString () + " (" + (rt [0].rect.width / 2).ToString () + ");");
                    // stop scaling on stopAfterLoop flag
                    if (stopAfterLoop)
                    {
                        break;
                    }
                    // set new scaling and position
                    sizeFactor0 = sizeFactor1;
                    imgPos0 = imgPos1;
                    if (painterFinished)
                    {
                        sizeFactor1 = minSizeFactor;
                        imgPos1 = Vector2.zero;
                        painterFinished = false;
                        stopAfterLoop = true;
                        // make upper image transparent
                        StartCoroutine(imageOpacity(1f, 0f, 1));
                    }
                    else
                    {
                        sizeFactor1 = getScale2();
                        imgPos1 = getPos2(sizeFactor1);
                    }
                    deltaSize = (sizeFactor1 - sizeFactor0) / effectSteps;
                    sizeFactor = sizeFactor0;
                    deltaPos = (imgPos1 - imgPos0) / effectSteps;
                    imgPos = imgPos0;
                    c = effectSteps;
                    //Debug.Log ("sizeFactor0=" + sizeFactor0.ToString () + ", sizeFactor1=" + sizeFactor1.ToString () + ", imgPos0=" + imgPos0.ToString () + ", imgPos1=" + imgPos1.ToString ());
                }
            }
            if (AfterWait > 0)
            {
                yield return new WaitForSeconds(AfterWait);
            }
            if (listener != null)
            {
                listener.SendMessage("ScalerFinished");
            }
        }

        public void ShowFinalImage()
        {
            StartCoroutine(preloadImages());
        }

        public void StopFinalImage()
        {
            stopScaling = true;
        }

    }
}
