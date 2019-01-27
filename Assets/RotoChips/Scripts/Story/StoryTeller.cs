/*
 * File:        StoryTeller.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class StoryTeller manages the Story scene logic
 * Created:     16.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using RotoChips.Generic;
using RotoChips.Management;
using RotoChips.ImageProcessing;
using RotoChips.Utility;

namespace RotoChips.Story
{
    public class StoryTeller : FlashingObject
    {

        // auxillary class
        protected class StoryImage
        {
            public RectTransform rectTransform;
            public RawImage image;
            public PictureFader fader;
            public Rect originalRect;
            public StoryImage(GameObject gameObject)
            {
                rectTransform = gameObject.GetComponent<RectTransform>();
                image = gameObject.GetComponent<RawImage>();
                fader = gameObject.GetComponent<PictureFader>();
                originalRect = rectTransform.rect;
            }
        }

        protected enum ImageFadeType
        {
            None,
            NormalOnly,
            NormalToStressed
        }

        [System.Serializable]
        protected class StoryFrame
        {
            public string messageId;
            public int pictureId;
            public float duration;
            public ImageFadeType imageFadeType;
        }

        [Header("Storyline frames")]
        [SerializeField]
        protected StoryFrame[] storyMessages;
        int frameId;
        [Header("Storyline elements")]
        [SerializeField]
        protected Text messageText;
        [SerializeField]
        protected GameObject normalImage;
        protected StoryImage normalStoryImage;
        [SerializeField]
        protected GameObject stressedImage;
        protected StoryImage stressedStoryImage;
        [Header("UI")]
        [SerializeField]
        protected Button stopButton;

        void SetImageSize(StoryImage storyImage)
        {
            float xyRatio = GlobalManager.MLevel.GetDescriptor(storyMessages[frameId].pictureId).init.finalXYScale;
            float imageWidth = storyImage.originalRect.width;
            float imageHeight = storyImage.originalRect.height;
            float originalXYRatio = imageWidth / imageHeight;
            //Debug.Log("Original rect size: " + imageWidth.ToString() + " x " + imageHeight.ToString());
            if (xyRatio < originalXYRatio)
            {
                imageWidth = imageHeight * xyRatio;
            }
            else
            {
                imageHeight = imageWidth / xyRatio;
            }
            //Debug.Log("Set " + storyImage.fader.gameObject.name + " size to " + imageWidth.ToString() + " x " + imageHeight.ToString() + " (" + xyRatio + ")");
            storyImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, imageWidth);
            storyImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, imageHeight);
            //storyImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, storyImage.originalRect.width);
            //storyImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, storyImage.originalRect.height);
        }

        void SetNormalImage()
        {
            string smoothTexResource = LevelDataManager.SmoothImageResource(storyMessages[frameId].pictureId);
            Texture2D smoothTex = Resources.Load<Texture2D>(smoothTexResource);
            normalStoryImage.image.texture = smoothTex;
            SetImageSize(normalStoryImage);
        }

        void SetStressedImage()
        {
            /*
            string stressImage = StressImageCreator.StressedFinalImageFile(storyMessages[frameId].pictureId);
            Texture2D stressTex = new Texture2D(2, 2, TextureFormat.RGB24, false);
            stressTex.LoadImage(System.IO.File.ReadAllBytes(stressImage));
            */
            string stressTexResource = LevelDataManager.StressImageResource(storyMessages[frameId].pictureId);
            Texture2D stressTex = Resources.Load<Texture2D>(stressTexResource);
            stressedStoryImage.image.texture = stressTex;
            SetImageSize(stressedStoryImage);
        }

        void SwitchMessage()
        {
            if (frameId >= 0)
            {
                normalStoryImage.fader.Turn(false);
                stressedStoryImage.fader.Turn(false);
                StartFlash(false);
            }
            frameId++;
            //Debug.Log("Switching to frame " + frameId.ToString());
            if (frameId < storyMessages.Length)
            {
                StoryFrame frame = storyMessages[frameId];
                messageText.text = GlobalManager.MLanguage.Entry(frame.messageId);
                normalStoryImage.fader.Turn(false);
                stressedStoryImage.fader.Turn(false);
                if (frame.pictureId >= 0)
                {
                    //Debug.Log("Setting normal image");
                    SetNormalImage();
                    switch (frame.imageFadeType)
                    {
                        case ImageFadeType.NormalOnly:
                            normalStoryImage.fader.FlashDuration = new FloatRange
                            {
                                min = 0,
                                max = 0
                            };
                            //Debug.Log("Normal image fades in");
                            normalStoryImage.fader.StartFlash(true);
                            break;
                        case ImageFadeType.NormalToStressed:
                            if (GlobalManager.MStressImage.HasFinalImage(frame.pictureId))
                            {
                                //Debug.Log("Setting stress image");
                                SetStressedImage();
                            }
                            normalStoryImage.fader.FlashDuration = new FloatRange
                            {
                                min = 0,
                                max = frame.duration
                            };
                            stressedStoryImage.fader.FlashDuration = new FloatRange
                            {
                                min = frame.duration,
                                max = 0
                            };
                            normalStoryImage.fader.Turn(true);
                            //Debug.Log("Normal image fades out");
                            normalStoryImage.fader.StartFlash(false);
                            //Debug.Log("Stressed image fades in");
                            stressedStoryImage.fader.StartFlash(true);
                            break;
                    }
                }
                StartFlash(true);
                StartCoroutine(WaitForFrame());
            }
        }

        IEnumerator WaitForFrame()
        {
            //Debug.Log("Frame " + frameId.ToString() + ": waiting " + storyMessages[frameId].duration.ToString() + " seconds");
            yield return new WaitForSeconds(storyMessages[frameId].duration);
            //Debug.Log("Frame " + frameId.ToString() + ": fading out");
            StartFlash(false);
        }

        protected override bool IsValidPeriod(int periodCounter)
        {
            return periodCounter == 0;
        }

        protected override void PeriodFinished(bool up)
        {
            //Debug.Log("StoryTeller.PeriodFinished: up=" + up.ToString());
            if (!up)
            {
                if (frameId == storyMessages.Length - 1)
                {
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this);
                }
                else
                {
                    StartCoroutine(SwitchMessageDelayed());
                }
            }
        }

        IEnumerator SwitchMessageDelayed()
        {
            yield return null;
            SwitchMessage();
        }

        [Header("Flashing components")]
        [SerializeField]
        protected Graphic[] uiElements;
        protected override void Visualize(float factor)
        {
            foreach (Graphic graphic in uiElements)
            {
                Color c = graphic.color;
                c.a = factor;
                graphic.color = c;
            }
        }

        protected override void AwakeInit()
        {
            //Debug.Log("StoryTeller.AwakeInit");
            registrator.Add(
                new MessageRegistrationTuple { type = InstantMessageType.GUIWhiteCurtainFaded, handler = OnGUIWhiteCurtainFaded },
                new MessageRegistrationTuple { type = InstantMessageType.GUIFullScreenButtonPressed, handler = OnGUIFullScreenButtonPressed }
            );
            normalStoryImage = new StoryImage(normalImage);
            stressedStoryImage = new StoryImage(stressedImage);
            frameId = -1;
        }

        private void Start()
        {
            // real rectangles of UI images are only calculated up to this point
            normalStoryImage.originalRect = normalStoryImage.rectTransform.rect;
            stressedStoryImage.originalRect = stressedStoryImage.rectTransform.rect;
            normalStoryImage.fader.Turn(false);
            stressedStoryImage.fader.Turn(false);
            stopButton.interactable = GlobalManager.MStorage.IntroShown;
            Visualize(flashRange.min);
        }

        // mesage handling
        [SerializeField]
        protected string worldScene = "World";
        void OnGUIWhiteCurtainFaded(object sender, InstantMessageArgs args)
        {
            bool up = (bool)args.arg;
            //Debug.Log("White cirtain faded up: " + up.ToString());
            if (up)
            {
                GlobalManager.MStorage.IntroShown = true;
                SceneManager.LoadScene(worldScene);
            }
            else
            {
                StartCoroutine(SwitchMessageDelayed());
            }
        }

        void OnGUIFullScreenButtonPressed(object sender, InstantMessageArgs args)
        {
            stopButton.interactable = false;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this, true);
        }
    }
}
