/*
 * File:        GameManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class GameManager handles all of the specific game logic
 * Created:     13.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Generic;
using RotoChips.Puzzle;
using RotoChips.Data;

namespace RotoChips.Management
{
    public class GameManager : GenericManager
    {

        MessageRegistrator registrator;
        public override void MakeReady()
        {
            registrator = new MessageRegistrator(InstantMessageType.PuzzleComplete, (InstantMessageHandler)OnPuzzleComplete);
            registrator.RegisterHandlers();
            base.MakeReady();
        }

        // message handling
        [SerializeField]
        protected string levelCompletedId = "idLevelCompleted";
        [SerializeField]
        protected string galleryOpenedId = "idGalleryOpened";
        [SerializeField]
        protected string levelCompletedOnceAgainId = "idLevelCompletedOnceAgain";
        [SerializeField]
        protected string realmRevealedId = "idRealmRevealed";
        void OnPuzzleComplete(object sender, InstantMessageArgs args)
        {
            PuzzleCompleteStatus completeStatus = (PuzzleCompleteStatus)args.arg;
            if (completeStatus != null)
            {
                if (completeStatus.firstTime)
                {
                    GlobalManager.MQueue.PostMessage(levelCompletedId);
                    if (completeStatus.descriptor.init.id == 0)
                    {
                        GlobalManager.MStorage.GalleryLevel = completeStatus.descriptor.init.id;
                        GlobalManager.MQueue.PostMessage(galleryOpenedId);
                    }
                    if (completeStatus.descriptor.init.realmId >= 0)
                    {
                        RealmData.Init realmData = RealmData.initializers[completeStatus.descriptor.init.realmId];
                        if (realmData.mainLevelId == completeStatus.descriptor.init.id)
                        {
                            GlobalManager.MQueue.PostMessage(realmRevealedId);
                        }
                    }
                }
                else
                {
                    GlobalManager.MQueue.PostMessage(levelCompletedOnceAgainId);
                }
            }
        }

        private void OnDestroy()
        {
            //registrator.UnregisterHandlers();
        }
    }
}
