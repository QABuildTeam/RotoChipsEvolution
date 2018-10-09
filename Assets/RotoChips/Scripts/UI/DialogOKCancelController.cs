/*
 * File:        DialogOKCancelController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class DialogOKCancelController controls overall logic of a standard Ok/Cancel dialog
 * Created:     05.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.UI
{
    public class DialogOKCancelController : GenericMessageHandler
    {

        [SerializeField]
        Text dialogText;

        protected override void AwakeInit()
        {
            registrator.Add(new MessageRegistrationTuple { type = InstantMessageType.GUIStartDialogOKCancel, handler = OnGUIStartDialogOKCancel });
            gameObject.SetActive(false);
        }

        // message handling
        void OnGUIStartDialogOKCancel(object sender, InstantMessageArgs args)
        {
            //string messageTextId = (string)args.arg;
            //dialogText.text = GlobalManager.MLanguage.Entry(messageTextId);
            string messageText = (string)args.arg;
            dialogText.text = messageText;
            gameObject.SetActive(true);
        }

        [SerializeField]
        protected SFXPlayParams okButtonClickSFX;
        [SerializeField]
        protected SFXPlayParams cancelButtonClickSFX;
        public void OKButtonPressed()
        {
            GlobalManager.MAudio.PlaySFX(okButtonClickSFX);
            gameObject.SetActive(false);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIOKButtonPressed, this);
        }

        public void CancelButtonPressed()
        {
            GlobalManager.MAudio.PlaySFX(cancelButtonClickSFX);
            gameObject.SetActive(false);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUICancelButtonPressed, this);
        }
    }

}
