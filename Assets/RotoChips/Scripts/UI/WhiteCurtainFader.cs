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
        protected bool fadeIn = true;
        [SerializeField]
        protected bool fadeOut = true;

        MessageRegistrator registrator;
        private void Awake()
        {
            registrator = new MessageRegistrator(InstantMessageType.GUIFadeOutWhiteCurtain, (InstantMessageHandler)OnFadeOutWhiteCurtain);
            fader = GetComponentInChildren<Image>();
            flashRange.min = 0;
            flashRange.max = 1;
            registrator.RegisterHandlers();
        }
        void Start()
        {
            if (fadeIn)
            {
                Fade(false);
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
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIWhiteCurtainFaded, gameObject, up);
        }

        // this method starts fading transparency in or out
        protected void Fade(bool fadeOut)
        {
            Visualize(fadeOut ? flashRange.min : flashRange.max);
            gameObject.SetActive(true);
            StartFlash(fadeOut);
        }

        // these methods are overridden from FlashingObject
        protected override bool IsValidPeriod(int periodCounter)
        {
            return periodCounter == 0;    // this fader progresses for only one period
        }

        public void OnFadeOutWhiteCurtain(object sender, InstantMessageArgs args)
        {
            if (fadeOut)
            {
                Fade(true);
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
