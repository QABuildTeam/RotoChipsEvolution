/*
 * File:        WinCanvasFlasher.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WinCanvasFlasher controls the initial WinCanvas fading in
 * Created:     11.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.Puzzle
{
    public class WinCanvasFlasher : FlashingObject
    {
        [SerializeField]
        protected RawImage originalImage;
        [SerializeField]
        protected RawImage stressImage;
        [SerializeField]
        protected Button winButton;
        [SerializeField]
        protected Text winText;
        [SerializeField]
        protected Outline winOutline;

        MessageRegistrator registrator;
        private void Awake()
        {
            winButton.interactable = false;
            registrator = new MessageRegistrator(InstantMessageType.PuzzleShowWinimage, (InstantMessageHandler)OnPuzzleShowWinimage);
            registrator.RegisterHandlers();
            Visualize(flashRange.min);
            // Debug
            //StartCoroutine(Flash(true));
        }

        protected override bool IsValidPeriod(int periodCounter)
        {
            return periodCounter == 0;
        }

        protected override void Visualize(float factor)
        {
            Color c = originalImage.color;
            c.a = factor;
            originalImage.color = c;
            c = stressImage.color;
            c.a = factor;
            stressImage.color = c;
            c = winText.color;
            c.a = factor;
            winText.color = c;
            c = winOutline.effectColor;
            c.a = factor;
            winOutline.effectColor = c;
        }

        // message handling
        int runCounter = 0;
        void OnPuzzleShowWinimage(object sender, InstantMessageArgs args)
        {
            string winTextId = (string)args.arg;
            if (!string.IsNullOrEmpty(winTextId))
            {
                winText.text = GlobalManager.MLanguage.Entry(winTextId);
            }
            else
            {
                winText.text = string.Empty;
            }
            winButton.interactable = true;
            if (!gameObject.activeInHierarchy)
            {
                gameObject.SetActive(true);
            }
            StartFlash(true);
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

        public void WinButtonPressed()
        {
            winButton.interactable = false;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleWinImageStopped, this);
        }
    }
}
