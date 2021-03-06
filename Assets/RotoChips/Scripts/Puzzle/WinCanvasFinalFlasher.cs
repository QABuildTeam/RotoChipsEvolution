﻿/*
 * File:        WinCanvasFinalFlasher.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WinCanvasFinalFlasher fades the stress image out in the end of the exhibition
 * Created:     11.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Generic;
using RotoChips.Management;

namespace RotoChips.Puzzle
{
    public class WinCanvasFinalFlasher : FlashingObject
    {
        [SerializeField]
        protected RawImage stressImage;

        protected override void AwakeInit()
        {
            registrator.Add(
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleWinImageFinished, handler = OnPuzzleWinImageFinished },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleShowWinimage, handler = OnPuzzleShowWinimage }
            );
            Visualize(flashRange.max);
        }

        // FlashingObject overrides
        protected override bool IsValidPeriod(int periodCounter)
        {
            return periodCounter == 0;
        }

        protected override void Visualize(float factor)
        {
            Color c = stressImage.color;
            c.a = factor;
            stressImage.color = c;
        }

        // message handling
        void OnPuzzleShowWinimage(object sender, InstantMessageArgs args)
        {
            string title = (string)args.arg;
            Visualize(title == null ? flashRange.min : flashRange.max);
        }

        void OnPuzzleWinImageFinished(object sender, InstantMessageArgs args)
        {
            StartFlash(false);
        }

    }
}
