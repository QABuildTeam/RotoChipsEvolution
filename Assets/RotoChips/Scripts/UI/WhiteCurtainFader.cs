/*
 * File:        WhiteCurtainFader.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WhiteCurtainFader controls a white in/out fader which is used in interscene intervals
 * Created:     26.08.2018
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.UI
{
    public class WhiteCurtainFader : FlashingObject
    {

        protected Image fader;

        [SerializeField]
        protected Color fadeColor;
        public Color FadeColor
        {
            get
            {
                return fadeColor;
            }
            set
            {
                fadeColor = value;
                if (fader != null)
                {
                    fader.color = value;
                }
            }
        }

        // Use this for initialization
        void Start()
        {
            fader = GetComponentInChildren<Image>();
            alphaRange.min = 0;
            alphaRange.max = 1;
            FadeIn();
        }

        // auxillary method
        // it sets the alpha channel of the fader color
        // to prevent a momentary flash on screen
        protected override void SetAlpha(float alpha)
        {
            if (fader != null)
            {
                Color c = fader.color;
                c.a = alpha;
                fader.color = c;
            }
        }

        // this method fades an image from opaque initial color into full transparency
        public void FadeIn()
        {
            gameObject.SetActive(true);
            StartFlash(false);
        }

        // this method sets full transparency out to an opaque finishing color
        public void FadeOut()
        {
            gameObject.SetActive(true);
            StartFlash(true);
        }

        protected override bool IsValidPeriod(int periodIndex)
        {
            return periodIndex == 0;    // this fader progresses only one period
        }

        protected override void PeriodFinished(bool up)
        {
            gameObject.SetActive(false);
            if (GlobalManager.Instance != null)
            {
                GlobalManager.Instance.MInstantMessage.DeliverMessage(InstantMessageType.GUIWhiteCurtainFaded, gameObject, up);
            }
        }

    }
}
