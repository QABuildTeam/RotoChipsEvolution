/*
 * File:        PictureFader.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class PictureFader fades the picture screen at the Story scene
 * Created:     26.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.Story
{
    public class PictureFader : FlashingObject
    {

        RawImage image;

        protected override void AwakeInit()
        {
            image = GetComponent<RawImage>();
        }

        protected override bool IsValidPeriod(int periodCounter)
        {
            return periodCounter == 0;
        }

        protected override void Visualize(float factor)
        {
            Color c = image.color;
            c.a = factor;
            image.color = c;
        }

        public void Turn(bool on)
        {
            float factor = on ? FlashRange.max : FlashRange.min;
            Visualize(factor);
        }

    }
}
