/*
 * File:        UnityAdsManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class UnityAdsManager handles ads
 * Created:     02.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.Accounting
{
    public enum AdvertisementResult
    {
        Successful,
        Failed,
        Skipped
    }

    public class UnityAdsManager : GenericManager
    {

        [SerializeField]
        protected PlatformString gameIdsList;
        /*
            { RuntimePlatform.Android, "2828762" },
            { RuntimePlatform.IPhonePlayer, "2828764" }
        */
        [SerializeField]
        protected string rewardedVideo = "rewardedVideo";
        // Use this for initialization
        public override void MakeInitial()
        {
            string platformGameId = gameIdsList.Value(Application.platform);
            Advertisement.Initialize(platformGameId);
            base.MakeInitial();
        }

        public override void MakeReady()
        {
            isShowing = false;
            StartCoroutine(CheckVideoAvailability());
            base.MakeReady();
        }

        bool isShowing;
        public bool ShowAd()
        {
            ShowOptions showOptions = new ShowOptions
            {
                resultCallback = CheckAdResult
            };
            if (Advertisement.IsReady(rewardedVideo))
            {
                if (!isShowing)
                {
                    isShowing = true;
                    Advertisement.Show(rewardedVideo, showOptions);
                }
                return true;
            }
            else
            {
                Debug.Log("Ad video is not ready");
                return false;
            }
        }

        public void CheckAdResult(ShowResult result)
        {
            isShowing = false;
            AdvertisementResult adResult = AdvertisementResult.Failed;
            switch (result)
            {
                case ShowResult.Finished:
                    adResult = AdvertisementResult.Successful;
                    break;
                case ShowResult.Skipped:
                    adResult = AdvertisementResult.Skipped;
                    break;
            }
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.AdvertisementResult, this, adResult);
        }

        // this method checks for the rewarded video availability once in checkDelay seconds
        // and notifies of its status
        [SerializeField]
        protected float checkDelay = 30f;
        IEnumerator CheckVideoAvailability()
        {
            while (true)
            {
                yield return new WaitForSeconds(checkDelay);
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.AdvertisementReady, this, Advertisement.IsReady(rewardedVideo));
            }
        }
    }
}
