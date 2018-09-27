﻿/*
 * File:        VictorySceneController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class VictorySceneController controls the entire UI logic of the Victory scene
 * Created:     13.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using RotoChips.Management;

namespace RotoChips.Victory
{
    public class VictorySceneController : MonoBehaviour
    {

        protected enum ExitMode
        {
            World,
            Finale
        }

        protected ExitMode exitMode;

        [SerializeField]
        protected string worldScene = "World";
        [SerializeField]
        protected string finaleScene = "Finale";
        MessageRegistrator registrator;

        private void Awake()
        {
            exitMode = GlobalManager.MStorage.GameFinished ? ExitMode.Finale : ExitMode.World;
            registrator = new MessageRegistrator(
                InstantMessageType.GUIFullScreenButtonPressed, (InstantMessageHandler)OnGUIFullScreenButtonPressed,
                InstantMessageType.GUIWhiteCurtainFaded, (InstantMessageHandler)OnGUIWhiteCurtainFaded
            );
            registrator.RegisterHandlers();
        }

        // Use this for initialization
        void Start()
        {
            SetButtonTitle();
            // start firework alone
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.VictoryStartFireworks, this, null);
        }

        void SetButtonTitle()
        {
            string title = GlobalManager.MQueue.RetrieveMessage();
            if (!string.IsNullOrEmpty(title))
            {
                // change the button's title
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleSetVictoryTitle, this, title);
            }
            else
            {
                // all messages are dequeued, fade out
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeOutWhiteCurtain, this);
            }
        }

        // message handling
        void OnGUIFullScreenButtonPressed(object sender, InstantMessageArgs args)
        {
            SetButtonTitle();
        }

        void OnGUIWhiteCurtainFaded(object sender, InstantMessageArgs args)
        {
            bool up = (bool)args.arg;
            if (up)
            {
                switch(exitMode)
                {
                    case ExitMode.World:
                        SceneManager.LoadScene(worldScene);
                        break;
                    case ExitMode.Finale:
                        SceneManager.LoadScene(finaleScene);
                        break;
                }
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

    }
}