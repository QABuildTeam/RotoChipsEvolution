/*
 * File:        ScreenBlocker.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class ScreenBlocker blocks the World screen input while showing an ad video
 * Created:     05.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.World
{
    public class ScreenBlocker : MonoBehaviour
    {

        MessageRegistrator registrator;

        private void Awake()
        {
            registrator = new MessageRegistrator(InstantMessageType.WorldBlockScreen, (InstantMessageHandler)OnWorldBlockScreen);
            registrator.RegisterHandlers();
        }

        private void Start()
        {
            gameObject.SetActive(false);
        }

        // message handling
        void OnWorldBlockScreen(object sender, InstantMessageArgs args)
        {
            bool on = (bool)args.arg;
            gameObject.SetActive(on);
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
