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
using RotoChips.Generic;

namespace RotoChips.World
{
    public class SatelliteController : GenericMessageHandler
    {

        protected override void AwakeInit()
        {
            registrator.Add(
                new MessageRegistrationTuple { type = InstantMessageType.GUIObjectPressedAsButton, handler = OnGUIObjectPressedAsButton },
                new MessageRegistrationTuple { type = InstantMessageType.RedirectGalleryOpened, handler = OnRedirectGalleryOpened }
            );
        }

        private void Start()
        {
            LevelDataManager.Descriptor descriptor = GlobalManager.MLevel.GetDescriptor(0);
            gameObject.SetActive(descriptor.state.Complete);
        }

        // message handling
        // the satellite is tapped
        void OnGUIObjectPressedAsButton(object sender, InstantMessageArgs args)
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
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotationEnable, this, false);
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotateToObject, this, gameObject);
                GlobalManager.MHint.ShowNewHint(HintType.GalleryOpened, gameObject);
            }
        }

    }
}
