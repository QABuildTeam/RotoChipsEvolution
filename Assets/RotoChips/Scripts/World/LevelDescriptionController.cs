/*
 * File:        LevelDescriptionController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class LevelDescriptionController controls overall logic of a level description dialog
 * Created:     05.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;
using RotoChips.Generic;
using RotoChips.Utility;

namespace RotoChips.World
{
    public class LevelDescriptionController : FlashingObject
    {
        protected override void AwakeInit()
        {
            registrator.Add(new MessageRegistrationTuple { type = InstantMessageType.WorldShowLevelDescription, handler = OnWorldShowLevelDescription });
        }

        private void Start()
        {
            okButton.GetComponent<Button>().interactable = false;
            gameObject.SetActive(false);
        }

        // initialization
        [SerializeField]
        protected GameObject descriptionDialog;
        [SerializeField]
        protected GameObject titleText;
        [SerializeField]
        protected GameObject vDescriptionImage;
        [SerializeField]
        protected GameObject hDescriptionImage;
        [SerializeField]
        protected GameObject vDescriptionText;
        [SerializeField]
        protected GameObject hDescriptionText;
        [SerializeField]
        protected GameObject okButton;
        [SerializeField]
        protected string titlePrefix = "LevelTitle";
        [SerializeField]
        protected string descriptionPrefix = "LevelDescription";

        // this is for the super-extended horizontally iPhone X screen
        [System.Serializable]
        protected class DialogAdjustment
        {
            public float screenAspect;
            public float dialogHeight;
            public Vector2 maxHorizontalImageSize;
            public Vector2 maxVerticalImageSize;
            public int descriptionFontSize;
            public float descriptionYShift;
        }

        // higher screenAspects go first
        [SerializeField]
        protected DialogAdjustment[] dialogAdjustments;

        protected Text activeTextScript;
        void InitializeDialog(LevelDataManager.Descriptor descriptor)
        {
            // calculate dialog size
            int adjustmentIndex = -1;
            float currentScreenRatio = (float)Screen.width / (float)Screen.height;
            for (int i = 0; i < dialogAdjustments.Length; i++)
            {
                if (currentScreenRatio >= dialogAdjustments[i].screenAspect)
                {
                    adjustmentIndex = i;
                    break;
                }
            }
            if (adjustmentIndex < 0)
            {
                return;
            }
            // get level data
            string levelStr = descriptor.init.id.ToString("D3");
            titleText.GetComponent<Text>().text = GlobalManager.MLanguage.Entry(titlePrefix + levelStr);
            GameObject activeImage, inactiveImage;
            GameObject activeText, inactiveText;

            // adjust dialog height
            descriptionDialog.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, dialogAdjustments[adjustmentIndex].dialogHeight);

            bool horizontal = descriptor.init.finalXYScale >= 1f;
            // set up image dimensions and the dialog layout depending on "horizontal" or "vertical" image orientation

            float finalImageWidth;
            float finalImageHeight;
            if (horizontal)
            {
                // the maximum height of the image is fixed
                finalImageHeight = dialogAdjustments[adjustmentIndex].maxHorizontalImageSize.y;
                finalImageWidth = finalImageHeight * descriptor.init.finalXYScale;
                if (finalImageWidth > dialogAdjustments[adjustmentIndex].maxHorizontalImageSize.x)
                {
                    finalImageWidth = dialogAdjustments[adjustmentIndex].maxHorizontalImageSize.x;
                    finalImageHeight = finalImageWidth / descriptor.init.finalXYScale;
                }
                activeImage = hDescriptionImage;
                inactiveImage = vDescriptionImage;
                activeText = hDescriptionText;
                inactiveText = vDescriptionText;
                // adjust horizontal description text Y-shift
                RectTransform activeTextRectTransform = activeText.GetComponent<RectTransform>();
                Vector2 activeTextPosition = activeTextRectTransform.localPosition;
                activeTextPosition.y = dialogAdjustments[adjustmentIndex].descriptionYShift;
                activeTextRectTransform.localPosition = activeTextPosition;
            }
            else
            {
                // the maximum width of the image is fixed
                finalImageWidth = dialogAdjustments[adjustmentIndex].maxVerticalImageSize.x;
                finalImageHeight = finalImageWidth / descriptor.init.finalXYScale;
                if (finalImageHeight > dialogAdjustments[adjustmentIndex].maxVerticalImageSize.y)
                {
                    finalImageHeight = dialogAdjustments[adjustmentIndex].maxVerticalImageSize.y;
                    finalImageWidth = finalImageHeight * descriptor.init.finalXYScale;
                }
                activeImage = vDescriptionImage;
                inactiveImage = hDescriptionImage;
                activeText = vDescriptionText;
                inactiveText = hDescriptionText;
            }

            activeTextScript = activeText.GetComponent<Text>();
            activeTextScript.fontSize = dialogAdjustments[adjustmentIndex].descriptionFontSize;
            // activate active objects
            activeImage.SetActive(true);
            activeText.SetActive(true);
            // load "smooth" image
            activeImage.GetComponent<RawImage>().texture = Resources.Load<Texture>(LevelDataManager.SmoothImageResource(descriptor.init.id));
            // and set up its size
            activeImage.GetComponent<RectTransform>().localScale = new Vector3(finalImageWidth, finalImageHeight, 1.0f);
            // set text objects
            activeText.GetComponent<Text>().text = GlobalManager.MLanguage.Entry(descriptionPrefix + levelStr);
            // deactivate inactive objects
            inactiveImage.SetActive(false);
            inactiveText.SetActive(false);
            okButton.GetComponent<Button>().interactable = true;
            Visualize(flashRange.min);
            // now activate the dialog
            gameObject.SetActive(true);
            StartFlash(true);

        }

        // message handling
        void OnWorldShowLevelDescription(object sender, InstantMessageArgs args)
        {
            LevelDataManager.Descriptor descriptor = (LevelDataManager.Descriptor)args.arg;
            if (descriptor != null)
            {
                InitializeDialog(descriptor);
            }
        }

        public void OKButtonPressed()
        {
            okButton.GetComponent<Button>().interactable = false;
            StartFlash(false);
        }

        // FlashingObject overrides
        protected override bool IsValidPeriod(int periodCounter)
        {
            return periodCounter == 0;
        }

        protected override void PeriodFinished(bool up)
        {
            gameObject.SetActive(up);
            if (up)
            {
                okButton.GetComponent<Button>().interactable = true;
            }
            else
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldLevelDescriptionClosed, this);
            }
        }

        [SerializeField]
        protected FloatRange shiverScale;
        protected override void Visualize(float factor)
        {
            float newScale = shiverScale.min;
            if (factor <= 0.5f)
            {
                newScale = Mathf.Lerp(shiverScale.min, shiverScale.max, factor * 2);
            }
            else
            {
                newScale = Mathf.Lerp(shiverScale.max, shiverScale.min, 2 * factor - 1);
            }
            descriptionDialog.GetComponent<RectTransform>().localScale = new Vector3(newScale, newScale, 1);
            if (activeTextScript != null)
            {
                Color c = activeTextScript.color;
                c.a = factor;
                activeTextScript.color = c;
            }
        }

    }
}
