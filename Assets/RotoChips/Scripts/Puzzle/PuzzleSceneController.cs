﻿/*
 * File:        PuzzleSceneController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class PuzzleSceneController controls the entire logic of the Puzzle scene
 * Created:     06.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RotoChips.Management;

namespace RotoChips.Puzzle
{
    public class PuzzleSceneController : MonoBehaviour
    {

        protected enum DialogOKCancelMode
        {
            None,
            Back
        }
        protected DialogOKCancelMode dialogMode;

        [SerializeField]
        protected string worldScene = "World";
        MessageRegistrator registrator;
        // Use this for initialization
        void Start()
        {
            dialogMode = DialogOKCancelMode.None;
            registrator = new MessageRegistrator(
                InstantMessageType.GUIBackButtonPressed, (InstantMessageHandler)OnGUIBackButtonPressed,
                InstantMessageType.GUIWhiteCurtainFaded, (InstantMessageHandler)OnGUIWhiteCurtainFaded,
                InstantMessageType.GUIViewButtonPressed, (InstantMessageHandler)OnGUIViewButtonPressed,
                InstantMessageType.GUIOKButtonPressed, (InstantMessageHandler)OnGUIOKButtonPressed
            );
            registrator.RegisterHandlers();
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleStarted, this);
        }

        // message handling
        [SerializeField]
        protected string backQuestionId = "idGUIBackQuestion";
        void OnGUIBackButtonPressed(object sender, InstantMessageArgs args)
        {
            dialogMode = DialogOKCancelMode.Back;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIStartDialogOKCancel, this, backQuestionId);
        }

        void OnGUIOKButtonPressed(object sender, InstantMessageArgs args)
        {
            switch (dialogMode)
            {
                case DialogOKCancelMode.Back:
                    dialogMode = DialogOKCancelMode.None;
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeOutWhiteCurtain, this);
                    break;
            }
        }

        void OnGUIWhiteCurtainFaded(object sender, InstantMessageArgs args)
        {
            bool up = (bool)args.arg;
            if (up)
            {
                SceneManager.LoadScene(worldScene);

            }
        }

        void OnGUIViewButtonPressed(object sender, InstantMessageArgs args)
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleViewSourceImage, this);
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}