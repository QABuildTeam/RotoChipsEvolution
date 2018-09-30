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
            public Vector2[] movePosition;          // Flash loop positions
        }
        [SerializeField]
        ImageScaleParams[] imageParams;

        Vector2 sourceCanvasSize;
        protected FloatRange currentScale;
        LevelDataManager.Descriptor descriptor;
        MessageRegistrator registrator;

        bool effectFinished;
        public void Initialize()
        {
            descriptor = GlobalManager.MLevel.GetDescriptor(GlobalManager.MStorage.GalleryLevel);
            //int width = descriptor.init.width;
            //int height = descriptor.init.height;
            float finalRatioXY = descriptor.init.finalXYScale;
            float screenAspect = Camera.main.aspect;

            // load STRESS and SMOOTH textures
            string stressImage = StressImageCreator.StressedFinalImageFile(descriptor.init.id);
            Texture2D stressTex = new Texture2D(2, 2, TextureFormat.RGB24, false);
            stressTex.LoadImage(System.IO.File.ReadAllBytes(stressImage));
            imageParams[0].winImage.texture = stressTex;
            Texture2D smoothTex = Resources.Load<Texture2D>(LevelDataManager.SmoothImageResource(descriptor.init.id));
            imageParams[1].winImage.texture = smoothTex;

            // set up scaling and UV rectangles
            CanvasScaler canvasScaler = GetComponent<CanvasScaler>();
            // the size of the canvas excluding margins
            Rect sourceCanvasRect = new Rect(0, 0, canvasScaler.referenceResolution.x * (1 - marginRatio), canvasScaler.referenceResolution.y * (1 - marginRatio));
            sourceCanvasSize = new Vector2(sourceCanvasRect.width, sourceCanvasRect.height);
            for (int i = 0; i < imageParams.Length; i++)
            {
                //imageParams[i].imageTransform = imageParams[i].winImage.GetComponent<RectTransform>();
                imageParams[i].imageTransform.localPosition = imageParams[i].originalPosition;
                Rect sourceRect = imageParams[i].imageTransform.rect;
                Vector2 imageToCanvasRatio = new Vector2(
                    sourceCanvasRect.width / sourceRect.width,
                    sourceCanvasRect.height / sourceRect.height
                );
                float sourceCanvasAspect = sourceCanvasRect.width / sourceCanvasRect.height;
                imageParams[i].sourceScale = new Vector2(
                    //finalRatioXY > screenAspect ? imageToCanvasRatio.y * finalRatioXY : imageToCanvasRatio.x,
                    //finalRatioXY > screenAspect ? imageToCanvasRatio.y : imageToCanvasRatio.x / finalRatioXY
                    finalRatioXY > sourceCanvasAspect ? imageToCanvasRatio.y * finalRatioXY : imageToCanvasRatio.x,
                    finalRatioXY > sourceCanvasAspect ? imageToCanvasRatio.y : imageToCanvasRatio.x / finalRatioXY
                );
                imageParams[i].effectiveSize = Vector2.Scale(new Vector2(sourceRect.width, sourceRect.height), imageParams[i].sourceScale);
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
            GenerateNewStep(true);
            effectFinished = false;
        }

        private void Awake()
        {
            for (int i = 0; i < imageParams.Length; i++)
            {
                // transforms
                imageParams[i].imageTransform = imageParams[i].winImage.GetComponent<RectTransform>();
                // positions
                imageParams[i].originalPosition = imageParams[i].imageTransform.localPosition;
            }
            registrator = new MessageRegistrator(
                InstantMessageType.PuzzleShowWinimage, (InstantMessageHandler)OnPuzzleShowWinimage,
                InstantMessageType.PuzzleWinImageFinished, (InstantMessageHandler)OnPuzzleWinImageFinished
            );
            registrator.RegisterHandlers();
            //Initialize();
            // Debugging
            //StartFlash();
        }

        void GenerateNewStep(bool up)
        {
            int index = up ? 1 : 0;     // address corresponding scale and position parts
            float newScale = effectFinished ? 1f : scaleRange.Random;
            currentScale[index] = newScale;
            Vector2 endParts = effectFinished ? Vector2.zero : (new Vector2(Random.value, Random.value) - Vector2.one * 0.5f);
            for (int i = 0; i < imageParams.Length; i++)
            {
                Vector2 displacement = Vector2.Scale((imageParams[i].effectiveSize * newScale - sourceCanvasSize), endParts);
                Vector2 newPosition = imageParams[i].originalPosition + displacement;
                imageParams[i].movePosition[index] = newPosition;
            }
            //Debug.Log("original=" + imageParams[0].originalPosition.ToString() + "; scale: min=" + currentScale.min.ToString() + ", max=" + currentScale.max.ToString() + "; position: 0=" + imageParams[0].movePosition[0].ToString() + ", 1=" + imageParams[0].movePosition[1].ToString());
        }

        protected override void Visualize(float factor)
        {
            for (int i = 0; i < imageParams.Length; i++)
            {
                Vector2 effectiveScale = imageParams[i].sourceScale * Mathf.Lerp(currentScale.min, currentScale.max, factor);
                imageParams[i].imageTransform.localScale = effectiveScale;
                Vector2 effectivePosition = Vector2.Lerp(imageParams[i].movePosition[0], imageParams[i].movePosition[1], factor);
                imageParams[i].imageTransform.localPosition = effectivePosition;
                //Debug.Log("Scale " + effectiveScale.ToString() + ", position " + effectivePosition.ToString());
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
            if (!gameObject.activeInHierarchy)
            {
                gameObject.SetActive(true);
            }
            Initialize();
            StartFlash();
        }

        void OnPuzzleWinImageFinished(object sender, InstantMessageArgs args)
        {
            effectFinished = true;
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }

}
