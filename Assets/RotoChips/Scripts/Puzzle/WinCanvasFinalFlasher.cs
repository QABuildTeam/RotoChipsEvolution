/*
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
        MessageRegistrator registrator;
        private void Awake()
        {
            registrator = new MessageRegistrator(InstantMessageType.PuzzleWinImageFinished, (InstantMessageHandler)OnPuzzleWinImageFinished);
            registrator.RegisterHandlers();
            Visualize(1);
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
        void OnPuzzleWinImageFinished(object sender, InstantMessageArgs args)
        {
            StartFlash(false);
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
