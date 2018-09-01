/*
 * File:        SatelliteController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class SatelliteController implements reaction for a satellite touch
 * Created:     01.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.World
{
    public class SatelliteController : MonoBehaviour
    {

        MessageRegistrator registrator;
        private void Start()
        {
            registrator = new MessageRegistrator(InstantMessageType.SteadyMouseUpAsButton, (InstantMessageHandler)OnSteadyMouseUpAsButton);
            registrator.RegisterHandlers();
        }

        // message handling
        void OnSteadyMouseUpAsButton(object sender, InstantMessageArgs args)
        {
            if((GameObject)args.arg == gameObject)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldSatellitePressed, this);
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
