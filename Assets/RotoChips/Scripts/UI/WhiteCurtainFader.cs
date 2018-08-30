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

        [SerializeField]
        bool fadeIn = true;
        [SerializeField]
        bool fadeOut = true;

        // Use this for initialization
        void Start()
        {
            fader = GetComponentInChildren<Image>();
            flashRange.min = 0;
            flashRange.max = 1;
            if (fadeOut)
            {
                RegisterHandlers();
            }
            if (fadeIn)
            {
                FadeIn();
            }
            else
            {
                Visualize(flashRange.min);
                gameObject.SetActive(false);
            }
        }

        // it sets the alpha channel of the fader color
        protected override void Visualize(float alpha)
        {
            if (fader != null)
            {
                Color c = fader.color;
                c.a = alpha;
                fader.color = c;
            }
        }

        // this method is called on each period end
        protected override void PeriodFinished(bool up)
        {
            gameObject.SetActive(up);
            if (GlobalManager.Instance != null)
            {
                UnregisterHandlers();
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIWhiteCurtainFaded, gameObject, up);
            }
        }

        // this method fades an image from opaque initial color into full transparency
        protected void FadeIn()
        {
            Visualize(flashRange.max);
            gameObject.SetActive(true);
            StartFlash(false);
        }

        // this method sets full transparency out to an opaque finishing color
        protected void FadeOut()
        {
            Visualize(flashRange.min);
            gameObject.SetActive(true);
            StartFlash(true);
        }

        protected override bool IsValidPeriod(int periodIndex)
        {
            return periodIndex == 0;    // this fader progresses only one period
        }

        public void OnFadeOutWhiteCurtain(object sender, InstantMessageManager.InstantMessageArgs args)
        {
            FadeOut();
        }

        void RegisterHandlers()
        {
            if (GlobalManager.Instance != null)
            {
                GlobalManager.MInstantMessage.AddListener(InstantMessageType.GUIFadeOutWhiteCurtain, OnFadeOutWhiteCurtain);
            }
        }

        void UnregisterHandlers()
        {
            if (GlobalManager.Instance != null)
            {
                GlobalManager.MInstantMessage.RemoveListener(InstantMessageType.GUIFadeOutWhiteCurtain, OnFadeOutWhiteCurtain);
            }
        }

    }
}
