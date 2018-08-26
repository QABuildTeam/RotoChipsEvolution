/*
 * File:        LogoBackgroundFlasher.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class LogoBackgroundFlasher controls the periodic transparency change of a logo background SpriteRenderer
 * Created:     26.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Utility;
using RotoChips.Generic;

namespace RotoChips.Logo
{
    public class LogoBackgroundFlasher : FlashingObject
    {
        SpriteRenderer sr;

        protected override void SetAlpha(float alpha)
        {
            if (sr != null)
            {
                Color c = sr.color;
                c.a = alpha;
                sr.color = c;
            }
        }

        void Start()
        {
            sr = gameObject.GetComponent<SpriteRenderer>();
            SetAlpha(alphaRange.min);
        }

    }
}
