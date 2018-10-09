/*
 * File:        VictoryTitleFlasher.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class VictoryTitleFlasher sets and flashes a title of the fullscreen button at the Victory scene
 * Created:     13.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.Victory
{
    public class VictoryTitleFlasher : FlashingObject
    {

        protected string newTitle;
        [SerializeField]
        protected Text victoryText;
        [SerializeField]
        protected Outline victoryOutline;

        protected override void AwakeInit()
        {
            newTitle = string.Empty;
            victoryText.text = newTitle;
            Visualize(flashRange.max);
            registrator.Add(new MessageRegistrationTuple { type = InstantMessageType.PuzzleSetVictoryTitle, handler = OnPuzzleSetVictoryTitle });
        }

        // FlashingObject overrides
        protected override bool IsValidPeriod(int periodCounter)
        {
            if (periodCounter == 1)
            {
                if (!string.IsNullOrEmpty(newTitle))
                {
                    victoryText.text = GlobalManager.MLanguage.Entry(newTitle);
                }
            }
            return periodCounter < 2;
        }

        protected override void Visualize(float factor)
        {
            Color c = victoryText.color;
            c.a = factor;
            victoryText.color = c;
            c = victoryOutline.effectColor;
            c.a = factor;
            victoryOutline.effectColor = c;
        }

        // message handling
        void OnPuzzleSetVictoryTitle(object sender, InstantMessageArgs args)
        {
            newTitle = (string)args.arg;
            StartFlash(false);
        }

    }
}
