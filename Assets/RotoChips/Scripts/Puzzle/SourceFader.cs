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
        // Use this for initialization
        void Start()
        {
            LevelDataManager.Descriptor descriptor = GlobalManager.MLevel.GetDescriptor(GlobalManager.MStorage.SelectedLevel);
            int width = descriptor.init.width;
            int height = descriptor.init.height;
            float puzzleRatioXY = (float)width / (float)height;

            // prepare STRESS texture
            string stressImage = StressImageCreator.StressedFinalImageFile(descriptor.init.id);
            Texture2D tex = new Texture2D(2, 2, TextureFormat.RGB24, false);
            tex.LoadImage(System.IO.File.ReadAllBytes(stressImage));
            Vector2 texFactor = new Vector2
            {
                x = descriptor.init.finalXYScale > puzzleRatioXY ? puzzleRatioXY / descriptor.init.finalXYScale : 1f,
                y = puzzleRatioXY > descriptor.init.finalXYScale ? descriptor.init.finalXYScale / puzzleRatioXY : 1f
            };
        }

        protected override bool IsValidPeriod(int periodCounter)
        {
            return base.IsValidPeriod(periodCounter);
        }

        protected override void Visualize(float factor)
        {
            throw new System.NotImplementedException();
        }

    }
}
