/*
 * File:        StartTextScript.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class StartTextScript controls the StartText object on the Logo scene (and its parent button) by flashing its intensity
 * Created:     24.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.Logo
{
    public class StartTextScript : FlashingObject
    {

        [SerializeField]
        protected string loadingTextId = "idLogoLoadingMessage";
        [SerializeField]
        protected string tapToStartTextId = "idLogoStartMessage";
        [SerializeField]
        protected GameObject parentButton;
        protected Text text;

        // Use this for initialization
        void Start()
        {
            text = GetComponent<Text>();
            flashRange.min = 0;
            flashRange.max = 1;
            text.text = GlobalManager.MLanguage.Entry(loadingTextId);
            parentButton.GetComponent<Button>().interactable = false;
            parentButton.SetActive(false);
        }

        bool CheckAvailability()
        {
            return GlobalManager.Instance == null || GlobalManager.MStressImage.HasFinalImage(0);
        }

        IEnumerator MakeButtonInteractable()
        {
            while (!CheckAvailability())
            {
                yield return null;
            }
            text.text = GlobalManager.MLanguage.Entry(tapToStartTextId);
            parentButton.GetComponent<Button>().interactable = true;
        }

        protected override void Visualize(float alpha)
        {
            if (text != null)
            {
                Color c = text.color;
                c.a = alpha;
                text.color = c;
            }
        }

        public override void StartFlash(bool up = true)
        {
            parentButton.SetActive(true);
            base.StartFlash(up);
            StartCoroutine(MakeButtonInteractable());
        }
    }
}
