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
using RotoChips.UI;

namespace RotoChips.Management
{
    public class GameManager : GenericManager
    {

        MessageRegistrator registrator;
        public override void MakeReady()
        {
            registrator = new MessageRegistrator(
                InstantMessageType.WorldStarted, (InstantMessageHandler)OnWorldStarted,
                InstantMessageType.PuzzleStarted, (InstantMessageHandler)OnPuzzleStarted,
                InstantMessageType.PuzzleComplete, (InstantMessageHandler)OnPuzzleComplete,
                InstantMessageType.GUIWhiteCurtainFaded, (InstantMessageHandler)OnGUIWhiteCurtainFaded
            );
            registrator.RegisterHandlers();
            base.MakeReady();
        }

        // message handling
        protected enum SceneType
        {
            World,
            Puzzle
        }
        protected SceneType sceneType;
        void OnWorldStarted(object sender, InstantMessageArgs args)
        {
            sceneType = SceneType.World;
            bool firstRound = GlobalManager.MStorage.FirstRound;
            int selectedLevel = GlobalManager.MStorage.SelectedLevel;
            if (firstRound)
            {
            }
        }

        void OnPuzzleStarted(object sender, InstantMessageArgs args)
        {
            sceneType = SceneType.Puzzle;
        }

        void OnGUIWhiteCurtainFaded(object sender, InstantMessageArgs args)
        {
            bool firstRound = GlobalManager.MStorage.FirstRound;
            int selectedLevel = GlobalManager.MStorage.SelectedLevel;
            switch (sceneType)
            {
                case SceneType.World:
                    if (firstRound)
                    {
                        switch (selectedLevel)
                        {
                            case 0:
                                GlobalManager.MHint.ShowNewHint(HintType.FirstTimeWelcome);
                                break;
                            case 1:
                                //GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.rota)
                                GlobalManager.MHint.ShowNewHint(HintType.GalleryOpened);
                                break;
                        }
                    }
                    break;
                case SceneType.Puzzle:
                    if (firstRound)
                    {
                        switch (selectedLevel)
                        {
                        }
                    }
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleShuffle, this);
                    break;
            }
        }

        [SerializeField]
        protected string levelCompletedId = "idLevelCompleted";
        [SerializeField]
        protected string galleryOpenedId = "idGalleryOpened";
        [SerializeField]
        protected string levelCompletedOnceAgainId = "idLevelCompletedOnceAgain";
        [SerializeField]
        protected string realmRevealedId = "idRealmRevealed";
        [SerializeField]
        protected string newLevelPlayableId = "idNewLevelPlayable";
        [SerializeField]
        protected string realmCompletedId = "idRealmCompleted";
        [SerializeField]
        protected string realmOpenedId = "idRealmOpened";
        [SerializeField]
        protected string gameCompletedId = "idGameCompleted";
        void OnPuzzleComplete(object sender, InstantMessageArgs args)
        {
            PuzzleCompleteStatus completeStatus = (PuzzleCompleteStatus)args.arg;
            if (completeStatus != null)
            {
                int nextLevelId = GlobalManager.MLevel.NextLevel(completeStatus.descriptor.init.id);
                int prevLevelId = GlobalManager.MLevel.PreviousLevel(completeStatus.descriptor.init.id);
                RealmData.Init realmData = RealmData.initializers[completeStatus.descriptor.init.realmId];
                if (completeStatus.firstTime)   // a puzzle is assembled for the first time
                {
                    GlobalManager.MQueue.PostMessage(levelCompletedId);
                    if (completeStatus.descriptor.init.id == 0) // this is the very first puzzle in the game
                    {
                        GlobalManager.MStorage.GalleryLevel = completeStatus.descriptor.init.id;    // set the gallery level to the newly completed one
                        GlobalManager.MStorage.FirstGallery = true;                                 // gallery message should be shown
                        GlobalManager.MQueue.PostMessage(galleryOpenedId);                          // post a message about the gallery
                    }
                    if (completeStatus.descriptor.init.realmId >= 0)    // this should always be true, yet...
                    {
                        if (realmData.mainLevelId == completeStatus.descriptor.init.id)
                        {
                            // main (first) level of the realm has been complete
                            GlobalManager.MQueue.PostMessage(realmRevealedId);
                        }
                    }
                    if (nextLevelId >= 0)
                    {
                        // there is another level to play at
                        GlobalManager.MQueue.PostMessage(newLevelPlayableId);
                    }
                }
                else
                {
                    GlobalManager.MQueue.PostMessage(levelCompletedOnceAgainId);
                }
                completeStatus.descriptor.state.Complete = true;
                // set all the levels in the current realm revealed
                bool realmComplete = true;
                for(int i = 0; i < realmData.members.Length; i++)
                {
                    LevelDataManager.Descriptor descriptor = GlobalManager.MLevel.GetDescriptor(realmData.members[i]);
                    if (!descriptor.state.Revealed)
                    {
                        descriptor.state.Revealed = true;
                    }
                    // check if all the levels in the realm are complete
                    if (!descriptor.state.Complete)
                    {
                        realmComplete = false;
                    }
                }
                if (nextLevelId >= 0)
                {
                    // make next level revealed and playable
                    LevelDataManager.Descriptor descriptor = GlobalManager.MLevel.GetDescriptor(nextLevelId);
                    descriptor.state.Revealed = true;
                    descriptor.state.Playable = true;
                    completeStatus.descriptor.state.NextPlayableId = nextLevelId;
                    GlobalManager.MStorage.SelectedLevel = nextLevelId;
                }
                if (prevLevelId >= 0)
                {
                    // link previously completed level to the newly completed one
                    LevelDataManager.Descriptor descriptor = GlobalManager.MLevel.GetDescriptor(prevLevelId);
                    descriptor.state.NextCompleteId = completeStatus.descriptor.init.id;
                }
                if (realmComplete)
                {
                    GlobalManager.MQueue.PostMessage(realmCompletedId);
                    if (nextLevelId < 0)    // no more new levels
                    {
                        // the game is complete
                        GlobalManager.MStorage.GameFinished = true;
                        GlobalManager.MStorage.FirstRound = false;
                        GlobalManager.MQueue.PostMessage(gameCompletedId);
                    }
                    else
                    {
                        GlobalManager.MQueue.PostMessage(realmOpenedId);
                    }
                }
            }
        }

        private void OnDestroy()
        {
            //registrator.UnregisterHandlers();
        }
    }
}
