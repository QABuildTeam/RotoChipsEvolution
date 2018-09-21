﻿/*
 * File:        UIButtonController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class UIButtonController implements a UI button control method
 * Created:     01.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.UI
{
    public class UIButtonController : MonoBehaviour
    {
        [SerializeField]
        protected InstantMessageType messageType;

        public void ButtonClick()
        {
            if (gameObject.activeInHierarchy)
            {
                GlobalManager.MInstantMessage.DeliverMessage(messageType, this);
            }
        }

    }
}
