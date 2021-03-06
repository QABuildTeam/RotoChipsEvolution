﻿/*
 * File:        GUICanvasController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class GUICanvasController controls the configuration of the GUICanvas
 * Created:     19.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.UI
{
    [System.Serializable]
    public class GUIConfiguration
    {
        public bool restartButton;
        public bool viewButton;
        public bool backButton;
        public bool magicButon;
        public bool cupButton;
        public bool rotochipsPanel;
        public bool rotocoinsPanel;
    }

    public class GUICanvasController : GenericMessageHandler
    {

        protected override void AwakeInit()
        {
            registrator.Add(new MessageRegistrationTuple { type = InstantMessageType.GUIConfigureAppearance, handler = OnGUIConfigureAppearance });
        }

        // message handling
        [SerializeField]
        protected GameObject restartButton;
        [SerializeField]
        protected GameObject viewButton;
        [SerializeField]
        protected GameObject backButton;
        [SerializeField]
        protected GameObject magicButton;
        [SerializeField]
        protected GameObject cupButton;
        [SerializeField]
        protected GameObject rotochipsPanel;
        [SerializeField]
        protected GameObject rotocoinsPanel;
        void OnGUIConfigureAppearance(object sender, InstantMessageArgs args)
        {
            GUIConfiguration configuration = (GUIConfiguration)args.arg;
            if (configuration != null)
            {
                if (restartButton != null)
                {
                    restartButton.SetActive(configuration.restartButton);
                }
                if (viewButton != null)
                {
                    viewButton.SetActive(configuration.viewButton);
                }
                if (backButton != null)
                {
                    backButton.SetActive(configuration.backButton);
                }
                if (magicButton != null)
                {
                    magicButton.SetActive(configuration.magicButon);
                }
                if (cupButton != null)
                {
                    cupButton.SetActive(configuration.cupButton);
                }
                if (rotochipsPanel != null)
                {
                    rotochipsPanel.SetActive(configuration.rotochipsPanel);
                }
                if (rotocoinsPanel != null)
                {
                    rotocoinsPanel.SetActive(configuration.rotocoinsPanel);
                }
            }
        }

    }
}
