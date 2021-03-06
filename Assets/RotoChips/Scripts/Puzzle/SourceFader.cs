﻿/*
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
        protected override void AwakeInit()
        {
            descriptor = GlobalManager.MLevel.GetDescriptor(GlobalManager.MStorage.SelectedLevel);
            float puzzleRatioXY = (float)descriptor.init.width / (float)descriptor.init.height;
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
            // SourceCanvas matches screen by width, so the final scaling should be multiplied by:
            float heightAdjustFactor = sourceCanvasRect.width / sourceCanvasRect.height / screenAspect;
            RectTransform sourceTransform = sourceImage.GetComponent<RectTransform>();
            // the original size of the source image (square)
            Rect sourceRect = sourceTransform.rect;
            Vector2 canvasToImageRatio = new Vector2(
                sourceCanvasRect.width / sourceRect.width,
                sourceCanvasRect.height * heightAdjustFactor / sourceRect.height
            );
            Vector3 sourceRectScale = new Vector3(
                puzzleRatioXY > screenAspect ? canvasToImageRatio.x : canvasToImageRatio.y * puzzleRatioXY,
                puzzleRatioXY > screenAspect ? canvasToImageRatio.x / puzzleRatioXY : canvasToImageRatio.y,
                1
            );
            //Debug.Log("Image sizes: canvas: " + sourceCanvasRect.ToString() + ", image: " + sourceRect.ToString() + ", image/canvas: " + canvasToImageRatio.ToString() + ", scale: " + sourceRectScale.ToString());
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
            registrator.Add(new MessageRegistrationTuple { type = InstantMessageType.PuzzleViewSourceImage, handler = OnPuzzleViewSourceImage });
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
            if (string.IsNullOrEmpty(descriptor.state.CurrentState))
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
            if (!up)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleSourceImageClosed, this);
            }
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

    }
}
