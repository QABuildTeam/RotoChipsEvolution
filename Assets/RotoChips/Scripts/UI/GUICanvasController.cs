/*
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

namespace RotoChips.UI
{
    public class GUIConfiguration
    {
        public bool RestartButton;
        public bool ViewButton;
        public bool BackButton;
        public bool MagicButon;
        public bool RotochipsPanel;
        public bool RotocoinsPanel;
    }

    public class GUICanvasController : MonoBehaviour
    {

        MessageRegistrator registrator;
        private void Awake()
        {
            registrator = new MessageRegistrator(InstantMessageType.GUIConfigureAppearance, (InstantMessageHandler)OnGUIConfigureAppearance);
            registrator.RegisterHandlers();
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
                    restartButton.SetActive(configuration.RestartButton);
                }
                if (viewButton != null)
                {
                    viewButton.SetActive(configuration.ViewButton);
                }
                if (backButton != null)
                {
                    backButton.SetActive(configuration.BackButton);
                }
                if (magicButton != null)
                {
                    magicButton.SetActive(configuration.MagicButon);
                }
                if (rotochipsPanel != null)
                {
                    rotochipsPanel.SetActive(configuration.RotochipsPanel);
                }
                if (rotocoinsPanel != null)
                {
                    rotocoinsPanel.SetActive(configuration.RotocoinsPanel);
                }
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
