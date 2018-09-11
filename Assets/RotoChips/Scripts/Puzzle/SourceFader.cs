/*
 * File:        SourceFader.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class SourceFader controls the source image canvas of the Puzzle scene
 * Created:     05.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;
using RotoChips.ImageProcessing;
using RotoChips.Generic;

namespace RotoChips.Puzzle
{
    public class SourceFader : FlashingObject
    {
        [SerializeField]
        Image backgroundImage;
        [SerializeField]
        RawImage sourceImage;
        [SerializeField]
        Button sourceButton;
        [SerializeField]
        Text sourceText;
        [SerializeField]
        Outline sourceOutline;
        [SerializeField]
        protected float marginRatio = 0.1f;

        LevelDataManager.Descriptor descriptor;
        MessageRegistrator registrator;
        // Use this for initialization
        void Awake()
        {
            descriptor = GlobalManager.MLevel.GetDescriptor(GlobalManager.MStorage.SelectedLevel);
            int width = descriptor.init.width;
            int height = descriptor.init.height;
            float puzzleRatioXY = (float)width / (float)height;
            float screenAspect = Camera.main.aspect;

            // prepare STRESS texture
            string stressImage = StressImageCreator.StressedFinalImageFile(descriptor.init.id);
            Texture2D tex = new Texture2D(2, 2, TextureFormat.RGB24, false);
            tex.LoadImage(System.IO.File.ReadAllBytes(stressImage));
            Vector2 texFactor = new Vector2
            {
                x = descriptor.init.finalXYScale > puzzleRatioXY ? puzzleRatioXY / descriptor.init.finalXYScale : 1f,
                y = puzzleRatioXY > descriptor.init.finalXYScale ? descriptor.init.finalXYScale / puzzleRatioXY : 1f
            };
            sourceImage.texture = tex;
            CanvasScaler canvasScaler = GetComponent<CanvasScaler>();
            // the size of the canvas excluding margins
            Rect sourceCanvasRect = new Rect(0, 0, canvasScaler.referenceResolution.x * (1 - marginRatio), canvasScaler.referenceResolution.y * (1 - marginRatio));
            RectTransform sourceTransform = sourceImage.GetComponent<RectTransform>();
            // the original size of the source image (square)
            Rect sourceRect = sourceTransform.rect;
            Vector2 imageToCanvasRatio = new Vector2(sourceCanvasRect.width / sourceRect.width, sourceCanvasRect.height / sourceRect.height);
            Vector2 sourceRectScale = new Vector2(
                puzzleRatioXY > screenAspect ? imageToCanvasRatio.x : imageToCanvasRatio.y * puzzleRatioXY,
                puzzleRatioXY > screenAspect ? imageToCanvasRatio.x / puzzleRatioXY : imageToCanvasRatio.y
            );
            //Debug.Log("Image sizes: canvas: " + sourceCanvasRect.ToString() + ", image: " + sourceRect.ToString() + ", image/canvas: " + imageToCanvasRatio.ToString() + ", scale: " + sourceRectScale.ToString());
            sourceTransform.localScale = sourceRectScale;
            // UV-coordinates of the image
            Rect uvRect = new Rect(
                (1f - texFactor.x) / 2,
                (1f - texFactor.y) / 2,
                texFactor.x,
                texFactor.y
            );
            sourceImage.uvRect = uvRect;

            // button text
            sourceText.text = GlobalManager.MLanguage.Entry(GetSourceTextId());

            // message handling
            registrator = new MessageRegistrator(InstantMessageType.PuzzleViewSourceImage, (InstantMessageHandler)OnPuzzleViewSourceImage);
            registrator.RegisterHandlers();
            sourceButton.interactable = true;
        }

        [SerializeField]
        protected string newPuzzleId = "idGUIStartMessage";
        [SerializeField]
        protected string continuePuzzleId = "idGUIContinueMessage";
        [SerializeField]
        protected string completePuzzleId = "idGUIViewMessage";
        string GetSourceTextId()
        {
            if (descriptor.state.CurrentState == "")
            {
                return newPuzzleId;
            }
            else
            {
                if (descriptor.state.Complete)
                {
                    return completePuzzleId;
                }
                else
                {
                    return continuePuzzleId;
                }
            }
        }

        // overrides of virtual methods of FlashingObject
        protected override bool IsValidPeriod(int periodCounter)
        {
            return periodCounter == 0;
        }

        protected override void PeriodFinished(bool up)
        {
            sourceButton.interactable = up;
            gameObject.SetActive(up);
        }

        protected override void Visualize(float factor)
        {
            // background
            Color c = backgroundImage.color;
            c.a = factor;
            backgroundImage.color = c;
            // source image
            c = sourceImage.color;
            c.a = factor;
            sourceImage.color = c;
            // button text
            c = sourceText.color;
            c.a = factor;
            sourceText.color = c;
            // button text outline
            c = sourceOutline.effectColor;
            c.a = factor;
            sourceOutline.effectColor = c;
        }

        // message handling
        void OnPuzzleViewSourceImage(object sender, InstantMessageArgs args)
        {
            sourceText.text = GlobalManager.MLanguage.Entry(GetSourceTextId());
            sourceButton.interactable = true;
            gameObject.SetActive(true);
            StartFlash(true);
        }

        public void CloseSourceImage()
        {
            sourceButton.interactable = false;
            StartFlash(false);
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
