/*
 * File:        HintController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class HintController implements general hint logic of the game
 * Created:     19.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.UI
{

    public class HintRequest
    {
        public HintType type;
        public GameObject target;
    }

    public class HintController : GenericMessageHandler
    {

        [SerializeField]
        protected Text hintText;
        [SerializeField]
        protected GameObject hintMessage;
        [SerializeField]
        protected GameObject hintArrow;

        protected override void AwakeInit()
        {
            registrator.Add(new MessageRegistrationTuple { type = InstantMessageType.GUIShowHint, handler = OnGUIShowHint });
        }

        private void Start()
        {
            gameObject.SetActive(false);
        }

        HintParams hintParams;
        void SetArrow()
        {
            if (hintParams.arrowOn)
            {
                RectTransform arrowTransform = hintArrow.GetComponent<RectTransform>();
                Vector3 arrowRotation = arrowTransform.localEulerAngles;
                arrowRotation.z = hintParams.arrowAngle;
                arrowTransform.localEulerAngles = arrowRotation;
                //arrowTransform.localRotation = Quaternion.Euler(arrowRotation);
            }
            hintArrow.SetActive(hintParams.arrowOn);
        }

        void SetMessage()
        {
            hintText.text = GlobalManager.MLanguage.Entry(hintParams.hintMsgId);
            RectTransform messageTransform = hintMessage.GetComponent<RectTransform>();
            // reset the message position to the center
            messageTransform.pivot = messageTransform.anchorMin = messageTransform.anchorMax = new Vector2(0.5f, 0.5f);
            messageTransform.localPosition = Vector3.zero;
            // now set new pivot and anchors
            switch (hintParams.layout)
            {
                case HintLayout.HintRightTop:
                    messageTransform.pivot = messageTransform.anchorMin = messageTransform.anchorMax = new Vector2(1f, 1f);
                    break;
                case HintLayout.HintBottom:
                    messageTransform.pivot = messageTransform.anchorMin = messageTransform.anchorMax = new Vector2(1f, 0f);
                    break;
                case HintLayout.HintLeft:
                    messageTransform.pivot = messageTransform.anchorMin = messageTransform.anchorMax = new Vector2(0f, 0.5f);
                    break;
                case HintLayout.HintLeftBottom:
                    messageTransform.pivot = messageTransform.anchorMin = messageTransform.anchorMax = new Vector2(0f, 0f);
                    break;
                case HintLayout.HintLeftTop:
                    messageTransform.pivot = messageTransform.anchorMin = messageTransform.anchorMax = new Vector2(0f, 1f);
                    break;
                case HintLayout.HintRight:
                    messageTransform.pivot = messageTransform.anchorMin = messageTransform.anchorMax = new Vector2(1f, 0.5f);
                    break;
                case HintLayout.HintRightBottom:
                    messageTransform.pivot = messageTransform.anchorMin = messageTransform.anchorMax = new Vector2(1f, 0f);
                    break;
                case HintLayout.HintTop:
                    messageTransform.pivot = messageTransform.anchorMin = messageTransform.anchorMax = new Vector2(0.5f, 1f);
                    break;
                default:
                    messageTransform.pivot = messageTransform.anchorMin = messageTransform.anchorMax = new Vector2(0.5f, 0.5f);
                    break;
            }
            messageTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, hintParams.width);
            messageTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, hintParams.height);
            messageTransform.Translate(new Vector3(hintParams.xGap, hintParams.yGap, 0), Space.Self);
            messageTransform.ForceUpdateRectTransforms();
        }

        void SetHintLayout()
        {
            SetMessage();
            SetArrow();
            gameObject.SetActive(true);
        }

        private void Update()
        {
            if (gameObject.activeInHierarchy)
            {
                if (hintParams.arrowOn)
                {
                    Vector2 pivotScreenPoint = Camera.main.WorldToScreenPoint(hintParams.target.transform.position);
                    hintArrow.GetComponent<RectTransform>().position = pivotScreenPoint;
                }
            }
        }

        // message handling
        void OnGUIShowHint(object sender, InstantMessageArgs args)
        {
            if (!gameObject.activeInHierarchy)
            {
                HintRequest hintRequest = (HintRequest)args.arg;
                if (hintRequest != null)
                {
                    hintParams = GlobalManager.MHint.Hints[hintRequest.type];
                    hintParams.target = hintRequest.target;
                    SetHintLayout();
                }
                else
                {
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIHintClosed, this, hintRequest);
                }
            }
        }

        public void BackgroundButtonPressed()
        {
            gameObject.SetActive(false);
            GlobalManager.MInstantMessage.DeliverMessage(
                InstantMessageType.GUIHintClosed,
                this,
                new HintRequest
                {
                    type = hintParams.type,
                    target = hintParams.target
                }
            );
        }

        public void ArrowSpotPressed()
        {
            gameObject.SetActive(false);
            // now enable world rotation
            GlobalManager.MInstantMessage.DeliverMessage(
                InstantMessageType.GUIHintClosed, 
                this,
                new HintRequest
                {
                    type = hintParams.type,
                    target = hintParams.target
                }
            );
            //Debug.Log("ArrowSpotPressed, sending " + hintParams.arrowMessage.ToString());
            GlobalManager.MInstantMessage.DeliverMessage(hintParams.arrowMessage, this, hintParams.target);
        }
    }
}
