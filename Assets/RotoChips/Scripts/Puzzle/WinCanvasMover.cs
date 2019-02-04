/*
 * File:        WinCanvasMover.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WinCanvasMover controls the WinCanvas images and text movement/scaling
 * Created:     10.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Generic;
using RotoChips.Management;
using RotoChips.ImageProcessing;
using RotoChips.Utility;

namespace RotoChips.Puzzle
{
    public class WinCanvasMover : FlashingObject
    {
        [SerializeField]
        protected float marginRatio = -0.1f;
        [SerializeField]
        protected FloatRange scaleRange = new FloatRange
        {
            min = 1,
            max = 4
        };

        [System.Serializable]
        public class ImageScaleParams
        {
            [SerializeField]
            public RawImage winImage;               // an image to be moved and scaled
            [HideInInspector]
            public RectTransform imageTransform;    // image's RectTransform
            [HideInInspector]
            public Vector2 sourceScale;             // 2D scale factor which scales original image rectangle up to the enclosing canvas size
            [HideInInspector]
            public Vector2 effectiveSize;           // image's rectangle effective size after such scaling
            [HideInInspector]
            public Vector2 originalPosition;        // original image position (usually should be (0,0))
            [HideInInspector]
            public Rect originalRect;               // original image size (usually should be (0,0,100,100))
            [HideInInspector]
            public Vector2[] movePosition;          // Flash loop positions
        }
        [SerializeField]
        ImageScaleParams[] imageParams;

        Vector2 sourceCanvasSize;
        Vector2 screenSize;
        protected FloatRange currentScale;
        LevelDataManager.Descriptor descriptor;

        bool effectFinished;
        public void Initialize()
        {
            descriptor = GlobalManager.MLevel.GetDescriptor(GlobalManager.MStorage.GalleryLevel);
            //int width = descriptor.init.width;
            //int height = descriptor.init.height;
            float finalRatioXY = descriptor.init.finalXYScale;
            float screenAspect = Camera.main.aspect;

            // load STRESS and SMOOTH textures
            /*
            string stressImage = StressImageCreator.StressedFinalImageFile(descriptor.init.id);
            Texture2D stressTex = new Texture2D(2, 2, TextureFormat.RGB24, false);
            stressTex.LoadImage(System.IO.File.ReadAllBytes(stressImage));
            */
            Texture2D stressTex = Resources.Load<Texture2D>(LevelDataManager.StressImageResource(descriptor.init.id));
            imageParams[0].winImage.texture = stressTex;
            Texture2D smoothTex = Resources.Load<Texture2D>(LevelDataManager.SmoothImageResource(descriptor.init.id));
            imageParams[1].winImage.texture = smoothTex;

            // set up scaling and UV rectangles
            CanvasScaler canvasScaler = GetComponent<CanvasScaler>();
            // the size of the canvas excluding margins
            Rect sourceCanvasRect = new Rect(0, 0, canvasScaler.referenceResolution.x * (1 - marginRatio), canvasScaler.referenceResolution.y * (1 - marginRatio));
            sourceCanvasSize = new Vector2(sourceCanvasRect.width, sourceCanvasRect.height);
            screenSize = new Vector2(Screen.width, Screen.height);
            // SourceCanvas matches screen by width, so the final height scaling should be adjusted by:
            float heightAdjustFactor = sourceCanvasRect.width / sourceCanvasRect.height / screenAspect;
            for (int i = 0; i < imageParams.Length; i++)
            {
                imageParams[i].imageTransform.localPosition = imageParams[i].originalPosition;
                Vector2 canvasToImageRatio = new Vector2(
                    sourceCanvasRect.width / imageParams[i].originalRect.width,
                    sourceCanvasRect.height * heightAdjustFactor / imageParams[i].originalRect.height
                );
                imageParams[i].sourceScale = new Vector2(
                    finalRatioXY > screenAspect ? canvasToImageRatio.y * finalRatioXY : canvasToImageRatio.x,
                    finalRatioXY > screenAspect ? canvasToImageRatio.y : canvasToImageRatio.x / finalRatioXY
                );
                imageParams[i].effectiveSize = Vector2.Scale(new Vector2(imageParams[i].originalRect.width, imageParams[i].originalRect.height), imageParams[i].sourceScale);
                imageParams[i].imageTransform.localScale = imageParams[i].sourceScale;
                currentScale = new FloatRange
                {
                    min = scaleRange.min,
                    max = scaleRange.min
                };
                // UV-coordinates of the image
                imageParams[i].winImage.uvRect = new Rect(0, 0, 1, 1);
                // positions
                //imageParams[i].originalPosition = imageParams[i].imageTransform.localPosition;
                imageParams[i].movePosition = new Vector2[2]
                {
                    imageParams[i].originalPosition,
                    imageParams[i].originalPosition
                };
            }
            effectFinished = false;
            GenerateNewStep(true);
        }

        protected override void AwakeInit()
        {
            for (int i = 0; i < imageParams.Length; i++)
            {
                // transforms
                imageParams[i].imageTransform = imageParams[i].winImage.GetComponent<RectTransform>();
                // positions
                imageParams[i].originalPosition = imageParams[i].imageTransform.localPosition;
                // sizes
                imageParams[i].originalRect = imageParams[i].imageTransform.rect;
            }
            registrator.Add(
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleShowWinimage, handler = OnPuzzleShowWinimage },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleWinImageFinished, handler = OnPuzzleWinImageFinished }
            );
        }

        int lowIndex = 0;
        int hiIndex = 1;
        void GenerateNewStep(bool up)
        {
            lowIndex = up ? 0 : 1;     // address corresponding to scale and position start parts
            hiIndex = up ? 1 : 0;       // address corresponding to scale and position end parts
            float newScale = effectFinished ? 1f : scaleRange.Random;
            currentScale[hiIndex] = newScale;
            Vector2 endParts = effectFinished ? Vector2.zero : (new Vector2(Random.value, Random.value) - Vector2.one * 0.5f);
            for (int i = 0; i < imageParams.Length; i++)
            {
                //Vector2 displacement = Vector2.Scale((imageParams[i].effectiveSize * newScale - sourceCanvasSize), endParts);
                Vector2 displacement = Vector2.Scale((imageParams[i].effectiveSize * newScale - sourceCanvasSize), endParts) / 2;
                Vector2 newPosition = imageParams[i].originalPosition + displacement;
                imageParams[i].movePosition[hiIndex] = newPosition;
            }
            //Debug.Log("New step: from " + lowIndex.ToString() + " (scale=" + currentScale[lowIndex].ToString() + ",position=" + imageParams[0].movePosition[lowIndex].ToString() + ") to " + hiIndex.ToString() + " (scale=" + currentScale[hiIndex].ToString() + ",position=" + imageParams[0].movePosition[hiIndex].ToString() + ")");
            //Debug.Log("New rect bounds: (" + (imageParams[0].movePosition[hiIndex] - imageParams[0].effectiveSize * newScale / 2).ToString() + "," + (imageParams[0].movePosition[hiIndex] + imageParams[0].effectiveSize * newScale / 2) + ")");
            //Debug.Log("original=" + imageParams[0].originalPosition.ToString() + "; scale: min=" + currentScale.min.ToString() + ", max=" + currentScale.max.ToString() + "; position: 0=" + imageParams[0].movePosition[0].ToString() + ", 1=" + imageParams[0].movePosition[1].ToString());
        }

        protected override void Visualize(float factor)
        {
            for (int i = 0; i < imageParams.Length; i++)
            {
                Vector2 effectiveScale = imageParams[i].sourceScale * Mathf.Lerp(currentScale[0], currentScale[1], factor);
                imageParams[i].imageTransform.localScale = effectiveScale;
                Vector2 effectivePosition = Vector2.Lerp(imageParams[i].movePosition[0], imageParams[i].movePosition[1], factor);
                imageParams[i].imageTransform.localPosition = effectivePosition;
                /*
                if (i == 0)
                {
                    Debug.Log("Factor " + factor.ToString() + ", scale " + effectiveScale.ToString() + ", position " + effectivePosition.ToString());
                }
                */
            }
        }

        protected override void PeriodFinished(bool up)
        {
            // generate next (not current!) step, so the flag up has to be inversed
            GenerateNewStep(!up);
        }

        // message handling
        void OnPuzzleShowWinimage(object sender, InstantMessageArgs args)
        {
            string title = (string)args.arg;
            if (title == null)
            {
                gameObject.SetActive(false);
            }
            else
            {
                gameObject.SetActive(true);
                StopFlash();
                Initialize();
                StartFlash();
            }
        }

        void OnPuzzleWinImageFinished(object sender, InstantMessageArgs args)
        {
            effectFinished = true;
        }

    }

}
