/*
 * File:        UIIndicatorController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class UIIndicatorController is a base class for indicator elements which updates its contents
 * Created:     01.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.Generic
{
    public abstract class UIIndicatorController : MonoBehaviour
    {
        [SerializeField]
        protected InstantMessageType messageType;
        MessageRegistrator registrator;
        private void Start()
        {
            registrator = new MessageRegistrator(messageType, (InstantMessageHandler)OnMessageUpdate);
            registrator.RegisterHandlers();
        }

        protected abstract void UpdateIndicator(object sender, InstantMessageArgs args);

        // message handling
        void OnMessageUpdate(object sender, InstantMessageArgs args)
        {
            UpdateIndicator(sender, args);
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

    }
}
