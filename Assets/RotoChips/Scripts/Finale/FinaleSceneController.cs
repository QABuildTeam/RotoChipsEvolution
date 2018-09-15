/*
 * File:        FinaleSceneController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class FinaleSceneController controls the entire logic of the Finale scene
 * Created:     15.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RotoChips.Management;

namespace RotoChips.Finale
{
    public class FinaleSceneController : MonoBehaviour
    {

        [SerializeField]
        protected int[] finaleTextIndexes;
        int currentIndex;
        MessageRegistrator registrator;
        private void Awake()
        {
            currentIndex = 0;
            registrator = new MessageRegistrator(
                InstantMessageType.GUIFullScreenButtonPressed, (InstantMessageHandler)OnGUIFullScreenButtonPressed,
                InstantMessageType.GUIWhiteCurtainFaded, (InstantMessageHandler)OnGUIWhiteCurtainFaded,
                InstantMessageType.FinaleTextRolled, (InstantMessageHandler)OnFinaleTextRolled,
                InstantMessageType.FinaleTextPostDelayed, (InstantMessageHandler)OnFinaleTextPostDelayed
            );
            registrator.RegisterHandlers();
        }

        // Use this for initialization
        void Start()
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotationEnable, this, true);
        }

        // message handling
        void OnGUIFullScreenButtonPressed(object sender, InstantMessageArgs args)
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeOutWhiteCurtain, this);
        }

        [SerializeField]
        protected string worldScene = "World";
        void OnGUIWhiteCurtainFaded(object sender, InstantMessageArgs args)
        {
            bool up = (bool)args.arg;
            if (up)
            {
                // exit
                SceneManager.LoadScene(worldScene);
            }
            else
            {
                // start the text rolls
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.FinaleRollText, this, finaleTextIndexes[currentIndex]);
            }
        }

        void OnFinaleTextRolled(object sender, InstantMessageArgs args)
        {
            if (currentIndex < finaleTextIndexes.Length - 1)
            {
                currentIndex++;
                // start the next text rolls
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.FinaleRollText, this, finaleTextIndexes[currentIndex]);
            }
        }

        void OnFinaleTextPostDelayed(object sender, InstantMessageArgs args)
        {
            if (currentIndex >= finaleTextIndexes.Length - 1)
            {
                currentIndex = 0;
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.FinaleRollText, this, finaleTextIndexes[currentIndex]);
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
