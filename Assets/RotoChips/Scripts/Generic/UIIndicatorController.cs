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
using RotoChips.Generic;

namespace RotoChips.Generic
{
    public abstract class UIIndicatorController : GenericMessageHandler
    {
        [SerializeField]
        protected InstantMessageType messageType;

        protected override void AwakeInit()
        {
            registrator.Add(new MessageRegistrationTuple { type = messageType, handler = OnMessageUpdate });
        }

        protected abstract void UpdateIndicator(object sender, InstantMessageArgs args);

        // message handling
        void OnMessageUpdate(object sender, InstantMessageArgs args)
        {
            UpdateIndicator(sender, args);
        }

    }
}
