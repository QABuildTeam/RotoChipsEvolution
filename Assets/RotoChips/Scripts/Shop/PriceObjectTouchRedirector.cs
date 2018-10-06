﻿/*
 * File:        PriceObjectTouchRedirector.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class PriceObjectTouchRedirector redirects a button-like touch upon the current object to another PriceEntryController
 * Created:     06.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.Shop
{
    public class PriceObjectTouchRedirector : MonoBehaviour
    {

        MessageRegistrator registrator;
        private void Awake()
        {
            registrator = new MessageRegistrator(InstantMessageType.GUIObjectPressedAsButton, (InstantMessageHandler)OnGUIObjectPressedAsButton);
            registrator.RegisterHandlers();
        }

        // message handling
        [SerializeField]
        protected PriceEntryController entryController;
        void OnGUIObjectPressedAsButton(object sender, InstantMessageArgs args)
        {
            if ((GameObject)args.arg == gameObject)
            {
                // just redirect the press onto some PriceEntryController
                if (entryController != null)
                {
                    entryController.PriceEntryButtonPressed();
                }
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
