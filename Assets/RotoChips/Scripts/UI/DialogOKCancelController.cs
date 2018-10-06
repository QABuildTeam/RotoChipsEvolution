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

namespace RotoChips.UI
{
    public class DialogOKCancelController : MonoBehaviour
    {

        [SerializeField]
        Text dialogText;

        MessageRegistrator registrator;
        // Use this for initialization
        void Awake()
        {
            registrator = new MessageRegistrator(InstantMessageType.GUIStartDialogOKCancel, (InstantMessageHandler)OnGUIStartDialogOKCancel);
            registrator.RegisterHandlers();
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

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

        public void OKButtonPressed()
        {
            gameObject.SetActive(false);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIOKButtonPressed, this);
        }

        public void CancelButtonPressed()
        {
            gameObject.SetActive(false);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUICancelButtonPressed, this);
        }
    }

}
