/*
 * File:        ShopSceneController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class ShopSceneController controls the entire logic of the Shop scene
 * Created:     09.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RotoChips.Generic;
using RotoChips.Management;
using RotoChips.UI;

namespace RotoChips.Shop
{
    public class ShopSceneController : GenericMessageHandler
    {

        protected override void AwakeInit()
        {
            registrator.Add(
                new MessageRegistrationTuple { type = InstantMessageType.GUIBackButtonPressed, handler = OnGUIBackButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIRestartButtonPressed, handler = OnGUIRestartButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIRotoCoinsPressed, handler = OnGUIRotoCoinsPressed },
                new MessageRegistrationTuple { type = InstantMessageType.ShopPurchaseComplete, handler = OnShopPurchaseComplete },
                new MessageRegistrationTuple { type = InstantMessageType.GUIWhiteCurtainFaded, handler = OnGUIWhiteCurtainFaded }
            );
        }
        // Use this for initialization
        void Start()
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.ShopStarted, this);
        }

        // message handling
        [SerializeField]
        protected string puzzleScene = "Puzzle";
        void OnGUIBackButtonPressed(object sender, InstantMessageArgs args)
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this);
        }

        void OnGUIWhiteCurtainFaded(object sender, InstantMessageArgs args)
        {
            bool up = (bool)args.arg;
            if (up)
            {
                SceneManager.LoadScene(puzzleScene);
            }
        }

        void OnGUIRestartButtonPressed(object sender, InstantMessageArgs args)
        {
            if (!GlobalManager.MHint.ShowNewHint(HintType.RestorePurchases))
            {
                GlobalManager.MPurchase.RestorePurchases();
            }
        }

        void OnGUIRotoCoinsPressed(object sender, InstantMessageArgs args)
        {
            GlobalManager.MInstantMessage.DeliverMessage(
                InstantMessageType.GUIShowHint,
                this,
                new HintRequest
                {
                    type = HintType.WorldCoinsScoreTapped,
                    target = null
                }
            );
        }

        [SerializeField]
        protected SFXPlayParams purchaseCompleteSFX;
        void OnShopPurchaseComplete(object sender, InstantMessageArgs args)
        {
            GlobalManager.MAudio.PlaySFX(purchaseCompleteSFX);
        }

    }
}
