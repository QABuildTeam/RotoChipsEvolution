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
using RotoChips.Accounting;
using RotoChips.Utility;

using UnityEngine.SceneManagement;

namespace RotoChips.Management
{
    public class GameManager : GenericManager
    {

        // GenericManager overrides
        public override void MakeInitial()
        {
            // some internal chores
            showMagicButton = false;

            base.MakeInitial();
        }

        bool CheckForLevelComplete(int levelId)
        {
            if (!GlobalManager.MStorage.BonusCoinsAdded)
            {
                LevelDataManager.Descriptor descriptor = GlobalManager.MLevel.GetDescriptor(levelId);
                if (!descriptor.state.Complete)
                {
                    GlobalManager.MHint.ResetHintFlags(levelId);
                    GlobalManager.MLevel.ResetLevel(levelId);
                    return false;
                }
            }
            return true;
        }

        // GameManager is already inherited from GenericManager so it cannot be a GenericMessageHandler
        MessageRegistrator registrator;
        public override void MakeReady()
        {
            registrator = new MessageRegistrator(
                new MessageRegistrationTuple { type = InstantMessageType.GalleryStarted, handler = OnGalleryStarted },
                new MessageRegistrationTuple { type = InstantMessageType.WorldStarted, handler = OnWorldStarted },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleStarted, handler = OnPuzzleStarted },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleComplete, handler = OnPuzzleComplete },
                new MessageRegistrationTuple { type = InstantMessageType.GUIWhiteCurtainFaded, handler = OnGUIWhiteCurtainFaded },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleSourceImageClosed, handler = OnPuzzleSourceImageClosed },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleHasShuffled, handler = OnPuzzleHasShuffled },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleTileInPlace, handler = OnPuzzleTileInPlace },
                new MessageRegistrationTuple { type = InstantMessageType.GUIHintClosed, handler = OnGUIHintClosed },
                new MessageRegistrationTuple { type = InstantMessageType.AdvertisementResult, handler = OnAdvertisementResult },
                new MessageRegistrationTuple { type = InstantMessageType.AdvertisementReady, handler = OnAdvertisementReady },
                new MessageRegistrationTuple { type = InstantMessageType.ShopPurchaseComplete, handler = OnShopPurchaseComplete },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleSetForAutostep, handler = OnPuzzleSetForAutostep },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleAutostep, handler = OnPuzzleAutostep },
                new MessageRegistrationTuple { type = InstantMessageType.ShopStarted, handler = OnShopStarted }
            );
            registrator.RegisterHandlers();

            // the application might be suddenly aborted or crashed
            // so check for the completeness of the very first two levels in the very first run
            if (GlobalManager.MStorage.FirstRound)
            {
                for (int i = 1; i >= 0; i--)
                {
                    if (CheckForLevelComplete(i))
                    {
                        break;
                    }
                }
            }

            base.MakeReady();
        }

        // points and coins configuration
        [SerializeField]
        protected long maximumPoints = 2000000000;
        [SerializeField]
        protected SerializableDecimal maximumCoins = new SerializableDecimal { value = 2000000000m };
        [SerializeField]
        protected long firstRunLevel0Row0Bonus = 100;
        [SerializeField]
        protected long firstRunLevel1Row0Bonus = 100;
        [SerializeField]
        protected long firstRunLevel1Row1Bonus = 200;
        [SerializeField]
        protected long puzzleCompleteBonus = 1000;
        [SerializeField]
        protected long puzzleAssembledRowBonusStep = 100;
        [SerializeField]
        protected SerializableDecimal autostepPrice = new SerializableDecimal { value = 1000m };
        [SerializeField]
        protected SerializableDecimal tutorialBonus = new SerializableDecimal { value = 600000m };
        [SerializeField]
        protected SerializableDecimal adBonus = new SerializableDecimal { value = 50m };

        // utility methods for clamped increasing/decreasing points/coins
        void AddPoints(ref long points, long deltaPoints)
        {
            if (deltaPoints >= 0)
            {
                if (maximumPoints - points >= deltaPoints)
                {
                    points += deltaPoints;
                }
                else
                {
                    points = maximumPoints;
                }
            }else if (deltaPoints < 0)
            {
                if (points >= -deltaPoints)
                {
                    points += deltaPoints;
                }
                else
                {
                    points = 0;
                }
            }
        }

        void AddCoins(ref decimal coins, decimal deltaCoins)
        {
            if (deltaCoins >= 0)
            {
                if (maximumCoins.value - coins >= deltaCoins)
                {
                    coins += deltaCoins;
                }
                else
                {
                    coins = maximumCoins.value;
                }
            }
            else if (deltaCoins < 0)
            {
                if (coins >= -deltaCoins)
                {
                    coins += deltaCoins;
                }
                else
                {
                    coins = 0;
                }
            }
        }

        // message handling
        // all the game logic contains here
        // first run level 0 world gui configuration
        [SerializeField]
        protected GUIConfiguration worldLevel0GUIConfiguration = new GUIConfiguration
        {
            backButton = false,
            viewButton = false,
            restartButton = false,
            magicButon = false,
            rotochipsPanel = false,
            rotocoinsPanel = false
        };
        // first run level 1 world gui configuration
        [SerializeField]
        protected GUIConfiguration worldLevel1GUIConfiguration = new GUIConfiguration
        {
            backButton = false,
            viewButton = false,
            restartButton = false,
            magicButon = false,
            rotochipsPanel = true,
            rotocoinsPanel = false
        };
        // first run world gui configuration
        [SerializeField]
        protected GUIConfiguration worldRun1GUIConfiguration = new GUIConfiguration
        {
            backButton = false,
            viewButton = false,
            restartButton = false,
            magicButon = false,
            rotochipsPanel = true,
            rotocoinsPanel = true
        };
        // second and later runs world gui configuration
        [SerializeField]
        protected GUIConfiguration worldGenericGUIConfiguration = new GUIConfiguration
        {
            backButton = false,
            viewButton = true,
            restartButton = true,
            magicButon = false,
            rotochipsPanel = true,
            rotocoinsPanel = true
        };
        // first run level 0 puzzle gui configuration
        protected GUIConfiguration puzzleLevel0GUIConfiguration = new GUIConfiguration
        {
            backButton = false,
            viewButton = false,
            restartButton = false,
            magicButon = false,
            rotochipsPanel = true,
            rotocoinsPanel = false
        };
        // first run level 1 puzzle gui configuration
        [SerializeField]
        protected GUIConfiguration puzzleLevel1GUIConfiguration = new GUIConfiguration
        {
            backButton = false,
            viewButton = true,
            restartButton = false,
            magicButon = false,
            rotochipsPanel = true,
            rotocoinsPanel = true
        };
        // generic puzzle gui configuration
        [SerializeField]
        protected GUIConfiguration puzzleGenericGUIConfiguration = new GUIConfiguration
        {
            backButton = true,
            viewButton = true,
            restartButton = true,
            magicButon = true,
            rotochipsPanel = true,
            rotocoinsPanel = true
        };
        // gallery gui configuration
        [SerializeField]
        protected GUIConfiguration galleryGUIConfiguration = new GUIConfiguration
        {
            backButton = true,
            viewButton = false,
            restartButton = false,
            magicButon = false,
            rotochipsPanel = false,
            rotocoinsPanel = false
        };
        // shop gui configuration
        [SerializeField]
        protected GUIConfiguration shopGUIConfiguration = new GUIConfiguration
        {
            backButton = true,
            viewButton = false,
            restartButton = true,
            magicButon = false,
            rotochipsPanel = false,
            rotocoinsPanel = true
        };
        protected enum SceneType
        {
            None,
            World,
            Puzzle,
            Gallery,
            Shop
        }
        protected SceneType sceneType;

        bool showMagicButton;
        void ConfigureWorldGUI()
        {
            bool firstRound = GlobalManager.MStorage.FirstRound;
            int selectedLevel = GlobalManager.MStorage.SelectedLevel;
            // configure world GUI
            GUIConfiguration worldConfiguration = worldGenericGUIConfiguration;
            if (firstRound)
            {
                switch (selectedLevel)
                {
                    case 0:
                        worldConfiguration = worldLevel0GUIConfiguration;
                        break;
                    case 1:
                        worldConfiguration = worldLevel1GUIConfiguration;
                        break;
                    default:
                        worldConfiguration = worldRun1GUIConfiguration;
                        worldConfiguration.magicButon = showMagicButton;
                        break;
                }
            }
            else
            {
                worldConfiguration.magicButon = showMagicButton;
            }
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIConfigureAppearance, this, worldConfiguration);
        }

        void OnWorldStarted(object sender, InstantMessageArgs args)
        {
            sceneType = SceneType.World;
            ConfigureWorldGUI();
        }

        void OnPuzzleStarted(object sender, InstantMessageArgs args)
        {
            sceneType = SceneType.Puzzle;
            bool firstRound = GlobalManager.MStorage.FirstRound;
            int selectedLevel = GlobalManager.MStorage.SelectedLevel;
            // configure puzzle GUI
            GUIConfiguration puzzleConfiguration = puzzleGenericGUIConfiguration;
            if (firstRound)
            {
                switch (selectedLevel)
                {
                    case 0:
                        puzzleConfiguration = puzzleLevel0GUIConfiguration;
                        break;
                    case 1:
                        puzzleConfiguration = puzzleLevel1GUIConfiguration;
                        break;
                }
            }
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIConfigureAppearance, this, puzzleConfiguration);
        }

        void OnGalleryStarted(object sender, InstantMessageArgs args)
        {
            sceneType = SceneType.Gallery;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIConfigureAppearance, this, galleryGUIConfiguration);
        }

        void OnShopStarted(object sender, InstantMessageArgs args)
        {
            sceneType = SceneType.Shop;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIConfigureAppearance, this, shopGUIConfiguration);
        }

        [SerializeField]
        protected string tutorial0ShuffleConfig = "";
        [SerializeField]
        protected string tutorial1ShuffleConfig = "";
        void OnGUIWhiteCurtainFaded(object sender, InstantMessageArgs args)
        {
            bool up = (bool)args.arg;
            if (up)
            {
                sceneType = SceneType.None;
                return;
            }
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
                                // hint FirstTimeWelcome is shown once at the very first start of the game
                                GlobalManager.MHint.ShowNewHint(HintType.FirstTimeWelcome);
                                break;
                            case 1:
                                if (!GlobalManager.MHint.IsHintShown(HintType.GalleryOpened))
                                {
                                    // hint GalleryOpened
                                    // requires the gallery satellite as an argument
                                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.RedirectGalleryOpened, this);
                                }
                                else
                                {
                                    // rotate to selected as usual
                                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotateToSelected, this);
                                }
                                break;
                            default:
                                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotateToSelected, this);
                                break;
                        }
                    }
                    else
                    {
                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotateToSelected, this);
                    }
                    break;
                case SceneType.Puzzle:
                    // now shuffle the puzzle
                    string shuffleConfig = null;
                    if (firstRound)
                    {
                        // the first two levels are shuffled specially while on the first round
                        switch (selectedLevel)
                        {
                            case 0:
                                shuffleConfig = tutorial0ShuffleConfig;
                                break;
                            case 1:
                                shuffleConfig = tutorial1ShuffleConfig;
                                break;
                        }
                    }
                    StartCoroutine(WaitAndShufflePuzzle(shuffleConfig));
                    break;
            }
        }

        bool sourceImageClosed;
        void OnPuzzleSourceImageClosed(object sender, InstantMessageArgs args)
        {
            sourceImageClosed = true;
        }

        IEnumerator WaitAndShufflePuzzle(string shuffleConfig)
        {
            // wait while source image is closed
            sourceImageClosed = false;
            while (!sourceImageClosed)
            {
                yield return null;
            }
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleShuffle, this, shuffleConfig);
        }

        void OnPuzzleHasShuffled(object sender, InstantMessageArgs args)
        {
            // this message is recieved at the Puzzle scene only
            bool firstRound = GlobalManager.MStorage.FirstRound;
            int selectedLevel = GlobalManager.MStorage.SelectedLevel;
            // the first three levels are handled in special ways while on the first round
            if (firstRound)
            {
                switch (selectedLevel)
                {
                    case 0:
                        GlobalManager.MHint.ShowNewHint(HintType.PuzzleFirstShuffled);
                        break;
                    case 1:
                        GlobalManager.MHint.ShowNewHint(HintType.SecondLevelChallenge);
                        break;
                    case 2:
                        GlobalManager.MHint.ShowNewHint(HintType.NoMoreBonuses);
                        break;
                }
            }
        }

        void AddBonusCoins()
        {
            if (!GlobalManager.MStorage.BonusCoinsAdded)
            {
                GlobalManager.MStorage.BonusCoinsAdded = true;
                decimal coins = GlobalManager.MStorage.CurrentCoins;
                AddCoins(ref coins, tutorialBonus.value);
                GlobalManager.MStorage.CurrentCoins = coins;
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIRotoCoinsChanged, this, GlobalManager.MStorage.CurrentCoins);
            }
        }

        void OnGUIHintClosed(object sender, InstantMessageArgs args)
        {
            HintRequest hintRequest = (HintRequest)args.arg;
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
                                switch (hintRequest.type)
                                {
                                    case HintType.FirstTimeWelcome:
                                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotateToSelected, this);
                                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.RedirectFirstTimeWelcome2, this);
                                        break;
                                }
                                break;
                        }
                    }
                    break;
                case SceneType.Puzzle:
                    if (firstRound)
                    {
                        switch (selectedLevel)
                        {
                            case 0:
                                switch (hintRequest.type)
                                {
                                    case HintType.PuzzleFirstShuffled:
                                        GlobalManager.MHint.ShowNewHint(HintType.FirstLevelChallenge);
                                        break;
                                    case HintType.FirstLevelChallenge:
                                        // this will actually show a FirstTileInPlace hint
                                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.RedirectFirstTileButtons, this);
                                        break;
                                    case HintType.FirstTileInPlace:
                                        // this will actually show a SecondTileButtonsHint
                                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.RedirectSecondTileButtons, this);
                                        break;
                                    case HintType.ThirdTileInPlace:
                                        // level 0 challenge complete
                                        GlobalManager.MHint.ShowNewHint(HintType.TwoRowsInPlace1);
                                        break;
                                    case HintType.TwoRowsInPlace1:
                                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleAutocomplete, this);
                                        break;
                                }
                                break;
                            case 1:
                                switch (hintRequest.type)
                                {
                                    case HintType.TwoRowsInPlace:
                                        GlobalManager.MHint.ShowNewHint(HintType.TwoRowsInPlace2);
                                        break;
                                    case HintType.TwoRowsInPlace2:
                                        AddBonusCoins();
                                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleAutocomplete, this);
                                        break;
                                }
                                break;
                        }
                    }
                    break;
            }
        }

        int TileId(Vector2Int tile, LevelDataManager.Descriptor descriptor)
        {
            return tile.y * descriptor.init.width + tile.x;
        }

        bool IsTileInPlace(Vector2Int tile, TileInPlaceReport tileInPlaceReport, LevelDataManager.Descriptor descriptor)
        {
            int tileId = TileId(tile, descriptor);
            int currentTileId = TileId(tileInPlaceReport.current, descriptor);
            return tileId <= currentTileId;
        }

        // this method adds bonus points for each assembled puzzle row
        void AddPointsBonuses(TileInPlaceReport tileInPlaceReport, LevelDataManager.Descriptor descriptor)
        {
            int startId = TileId(tileInPlaceReport.previous, descriptor) + 1;
            int endId = TileId(tileInPlaceReport.current, descriptor);
            int puzzleWidth = descriptor.init.width;
            //bool scoreChanged = false;
            for (int runId = startId; runId <= endId; runId++)
            {
                int x = runId % puzzleWidth;
                int y = runId / puzzleWidth;
                if (x == puzzleWidth - 1)
                {
                    // a row is assembled
                    long earnedPoints = descriptor.state.EarnedPoints;
                    AddPoints(ref earnedPoints, (y + 1) * puzzleAssembledRowBonusStep);
                    descriptor.state.EarnedPoints = earnedPoints;
                    //scoreChanged = true;
                }
            }
        }

        void OnPuzzleTileInPlace(object sender, InstantMessageArgs args)
        {
            bool firstRound = GlobalManager.MStorage.FirstRound;
            int selectedLevel = GlobalManager.MStorage.SelectedLevel;
            TileInPlaceReport tilesInPlace = (TileInPlaceReport)args.arg;
            LevelDataManager.Descriptor descriptor = GlobalManager.MLevel.GetDescriptor(selectedLevel);
            if (firstRound)
            {
                switch (selectedLevel)
                {
                    case 0:
                        // only (0,0), (1,0), and (2,0) tiles are counted
                        // the total points value for the completed level is recalculated in OnPuzzleComplete
                        if (IsTileInPlace(new Vector2Int(descriptor.init.width - 1, 0), tilesInPlace, descriptor))
                        {
                            // tile (2,0) is in place; first row assembled
                            descriptor.state.EarnedPoints = firstRunLevel0Row0Bonus + puzzleAssembledRowBonusStep;
                            //GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.RotoChipsChanged, this, (decimal)descriptor.state.EarnedPoints);
                            GlobalManager.MHint.ShowNewHint(HintType.ThirdTileInPlace);
                        }
                        else if (IsTileInPlace(new Vector2Int(1, 0), tilesInPlace, descriptor))
                        {
                            // tile (1,0) is in place
                            GlobalManager.MHint.ShowNewHint(HintType.SecondTileInPlace);
                        }
                        else if (IsTileInPlace(new Vector2Int(0, 0), tilesInPlace, descriptor))
                        {
                            // tile (0,0) is in place
                            GlobalManager.MHint.ShowNewHint(HintType.FirstTileInPlace);
                        }
                        return;
                    case 1:
                        // only (2,0) and (2,1) tiles are counted
                        // the total points value for the completed level is recalculated in OnPuzzleComplete
                        if (IsTileInPlace(new Vector2Int(descriptor.init.width - 1, 1), tilesInPlace, descriptor))
                        {
                            // second row assembled
                            descriptor.state.EarnedPoints = firstRunLevel1Row1Bonus + firstRunLevel1Row0Bonus + (2 + 1) * puzzleAssembledRowBonusStep;
                            GlobalManager.MHint.ShowNewHint(HintType.TwoRowsInPlace);
                        }
                        else
                        if (IsTileInPlace(new Vector2Int(descriptor.init.width - 1, 0), tilesInPlace, descriptor))
                        {
                            // first row assembled
                            descriptor.state.EarnedPoints = firstRunLevel1Row0Bonus + puzzleAssembledRowBonusStep;
                            //GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.RotoChipsChanged, this, (decimal)descriptor.state.EarnedPoints);
                            GlobalManager.MHint.ShowNewHint(HintType.FirstRowCongratulation);
                        }
                        return;
                }
            }
            // calculate points bonuses
            if (!descriptor.state.AutocompleteUsed)
            {
                AddPointsBonuses(tilesInPlace, descriptor);
                /*
                if (scoreChanged)
                {
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.RotoChipsChanged, this, (decimal)descriptor.state.EarnedPoints);
                }
                */
            }
        }

        void OnPuzzleSetForAutostep(object sender, InstantMessageArgs args)
        {
            bool available = GlobalManager.MStorage.CurrentCoins >= autostepPrice.value;
            //Debug.Log("Autostep available: " + available.ToString());
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleAutostepAvailable, this, available);
        }

        void OnPuzzleAutostep(object sender, InstantMessageArgs args)
        {
            bool firstRound = GlobalManager.MStorage.FirstRound;
            int selectedLevel = GlobalManager.MStorage.SelectedLevel;
            if (firstRound)
            {
                switch (selectedLevel)
                {
                    case 0:
                    case 1:
                        return;
                }
            }
            decimal coins = GlobalManager.MStorage.CurrentCoins;
            AddCoins(ref coins, -autostepPrice.value);
            GlobalManager.MStorage.CurrentCoins = coins;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIRotoCoinsChanged, this, GlobalManager.MStorage.CurrentCoins);
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
            bool firstRound = GlobalManager.MStorage.FirstRound;
            PuzzleCompleteStatus completeStatus = (PuzzleCompleteStatus)args.arg;
            if (completeStatus != null)
            {
                int nextLevelId = GlobalManager.MLevel.NextLevel(completeStatus.descriptor.init.id);
                int prevLevelId = GlobalManager.MLevel.PreviousLevel(completeStatus.descriptor.init.id);
                RealmData.Init realmData = RealmData.initializers[completeStatus.descriptor.init.realmId];

                // set a message queue for the Victory screen
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

                // Do the accounting chores
                long earnedPoints = completeStatus.descriptor.state.EarnedPoints;
                if (firstRound)
                {
                    switch (completeStatus.descriptor.init.id)
                    {
                        case 0:
                            completeStatus.descriptor.state.EarnedPoints =
                                ((completeStatus.descriptor.init.height + 1) * completeStatus.descriptor.init.height / 2) * puzzleAssembledRowBonusStep +
                                firstRunLevel0Row0Bonus +
                                puzzleCompleteBonus;
                            break;
                        case 1:
                            completeStatus.descriptor.state.EarnedPoints =
                                ((completeStatus.descriptor.init.height + 1) * completeStatus.descriptor.init.height / 2) * puzzleAssembledRowBonusStep +
                                firstRunLevel1Row0Bonus +
                                firstRunLevel1Row1Bonus +
                                puzzleCompleteBonus;
                            AddBonusCoins();
                            break;
                        default:
                            AddPoints(ref earnedPoints, puzzleCompleteBonus);
                            completeStatus.descriptor.state.EarnedPoints = earnedPoints;
                            break;
                    }
                }
                else
                {
                    AddPoints(ref earnedPoints, puzzleCompleteBonus);
                    completeStatus.descriptor.state.EarnedPoints = earnedPoints;
                }
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIRotoChipsChanged, this, (decimal)completeStatus.descriptor.state.EarnedPoints);
                earnedPoints = GlobalManager.MStorage.CurrentPoints;
                AddPoints(ref earnedPoints, completeStatus.descriptor.state.EarnedPoints);
                GlobalManager.MStorage.CurrentPoints = earnedPoints;
                completeStatus.descriptor.state.Complete = true;

                // set all the levels in the current realm revealed
                bool realmComplete = true;
                for (int i = 0; i < realmData.members.Length; i++)
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

                // check if the game is complete
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

        // advertisements
        void OnAdvertisementResult(object sender, InstantMessageArgs args)
        {
            AdvertisementResult result = (AdvertisementResult)args.arg;
            Debug.Log("OnAdvertisementResult: " + result.ToString());
            switch (result)
            {
                case AdvertisementResult.Successful:
                    Debug.Log("Adding coins: " + adBonus.ToString());
                    decimal coins = GlobalManager.MStorage.CurrentCoins;
                    AddCoins(ref coins, adBonus.value);
                    GlobalManager.MStorage.CurrentCoins = coins;
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIRotoCoinsChanged, this, GlobalManager.MStorage.CurrentCoins);
                    break;
            }
        }

        void OnAdvertisementReady(object sender, InstantMessageArgs args)
        {
            showMagicButton = (bool)args.arg;
            switch (sceneType)
            {
                case SceneType.World:
                    ConfigureWorldGUI();
                    break;
            }
        }

        // purchases
        void OnShopPurchaseComplete(object sender, InstantMessageArgs args)
        {
            ProductDesc product = (ProductDesc)args.arg;
            if (product != null)
            {
                decimal coins = GlobalManager.MStorage.CurrentCoins;
                AddCoins(ref coins, product.value.value);
                GlobalManager.MStorage.CurrentCoins = coins;
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIRotoCoinsChanged, this, GlobalManager.MStorage.CurrentCoins);
            }
        }

        private void OnDestroy()
        {
            //registrator.UnregisterHandlers();
        }
    }
}
