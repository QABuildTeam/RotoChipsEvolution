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
using RotoChips.Generic;

namespace RotoChips.Finale
{
    public class FinaleSceneController : GenericMessageHandler
    {

        [SerializeField]
        protected int[] finaleTextIndexes;

        protected override void AwakeInit()
        {
            registrator.Add(
                new MessageRegistrationTuple { type = InstantMessageType.GUIFullScreenButtonPressed, handler = OnGUIFullScreenButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIWhiteCurtainFaded, handler = OnGUIWhiteCurtainFaded },
                new MessageRegistrationTuple { type = InstantMessageType.FinaleTextRolled, handler = OnFinaleTextRolled },
                new MessageRegistrationTuple { type = InstantMessageType.FinaleTextPostDelayed, handler = OnFinaleTextPostDelayed }
            );
        }

        // Use this for initialization
        void Start()
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotationEnable, this, true);
        }

        int IndexByValue(int value)
        {
            for (int i = 0; i < finaleTextIndexes.Length; i++)
            {
                if (finaleTextIndexes[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        // message handling
        void OnGUIFullScreenButtonPressed(object sender, InstantMessageArgs args)
        {
            // the button only works after the roll has been shown at least once
            if (GlobalManager.MStorage.FinaleShown)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this);
            }
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
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.FinaleRollText, this, finaleTextIndexes[0]);
            }
        }

        void OnFinaleTextRolled(object sender, InstantMessageArgs args)
        {
            int i = IndexByValue((int)args.arg);
            if (i < finaleTextIndexes.Length - 1)
            {
                i++;
                // start the next text rolls
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.FinaleRollText, this, finaleTextIndexes[i]);
            }
        }

        void OnFinaleTextPostDelayed(object sender, InstantMessageArgs args)
        {
            int i = IndexByValue((int)args.arg);
            if (i >= finaleTextIndexes.Length - 1)
            {
                GlobalManager.MStorage.FinaleShown = true;
                // reset text positions
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.FinaleRollText, this, 0);
                // reset text index
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.FinaleRollText, this, finaleTextIndexes[0]);
            }
        }

    }
}
