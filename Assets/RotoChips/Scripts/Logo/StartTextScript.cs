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
        protected string loadingTextKey = "idLogoLoadingMessage";
        [SerializeField]
        protected string tapToStartTextKey = "idLogoStartMessage";
        [SerializeField]
        protected GameObject parentButton;
        protected Text text;

        // Use this for initialization
        void Start()
        {
            text = GetComponent<Text>();
            alphaRange.min = 0;
            alphaRange.max = 1;
            text.text = GlobalManager.Instance.MLanguage.Entry(loadingTextKey);
            parentButton.GetComponent<Button>().interactable = false;
            parentButton.SetActive(false);
        }

        bool CheckAvailability()
        {
            return GlobalManager.Instance == null || GlobalManager.Instance.MImage.HasFinalImage(0);
        }

        IEnumerator MakeButtonInteractable()
        {
            while (!CheckAvailability())
            {
                yield return null;
            }
            text.text = GlobalManager.Instance.MLanguage.Entry(tapToStartTextKey);
            parentButton.GetComponent<Button>().interactable = true;
        }

        protected override void SetAlpha(float alpha)
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
