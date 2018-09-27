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
using RotoChips.UI;

namespace RotoChips.World
{
    public class SatelliteController : MonoBehaviour
    {

        MessageRegistrator registrator;
        private void Awake()
        {
            registrator = new MessageRegistrator(
                InstantMessageType.SteadyMouseUpAsButton, (InstantMessageHandler)OnSteadyMouseUpAsButton,
                InstantMessageType.RedirectGalleryOpened, (InstantMessageHandler)OnRedirectGalleryOpened
            );
            registrator.RegisterHandlers();
        }

        private void Start()
        {
            LevelDataManager.Descriptor descriptor = GlobalManager.MLevel.GetDescriptor(0);
            gameObject.SetActive(descriptor.state.Complete);
        }

        // message handling
        // the satellite is tapped
        void OnSteadyMouseUpAsButton(object sender, InstantMessageArgs args)
        {
            if (gameObject.activeInHierarchy && (GameObject)args.arg == gameObject)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldSatellitePressed, this);
            }
        }

        // special message; it is recieved once in a game when the very first puzzle is assembled
        void OnRedirectGalleryOpened(object sender, InstantMessageArgs args)
        {
            if (gameObject.activeInHierarchy)
            {
                GlobalManager.MHint.ShowNewHint(HintType.GalleryOpened, gameObject);
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
