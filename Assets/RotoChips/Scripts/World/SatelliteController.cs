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
        private void Awake()
        {
            registrator = new MessageRegistrator(InstantMessageType.SteadyMouseUpAsButton, (InstantMessageHandler)OnSteadyMouseUpAsButton);
            registrator.RegisterHandlers();
        }

        private void Start()
        {
            LevelDataManager.Descriptor descriptor = GlobalManager.MLevel.GetDescriptor(0);
            gameObject.SetActive(descriptor.state.Complete);
        }

        // message handling
        void OnSteadyMouseUpAsButton(object sender, InstantMessageArgs args)
        {
            if (gameObject.activeInHierarchy && (GameObject)args.arg == gameObject)
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
