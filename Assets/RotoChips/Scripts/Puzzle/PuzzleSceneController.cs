/*
 * File:        PuzzleSceneController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class PuzzleSceneController controls the entire UI logic of the Puzzle scene
 * Created:     06.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RotoChips.Management;
using RotoChips.Audio;
using RotoChips.UI;
using RotoChips.Generic;

namespace RotoChips.Puzzle
{
    public class PuzzleSceneController : GenericMessageHandler
    {

        protected enum DialogOKCancelMode
        {
            None,
            Back,
            Reset,
            Autostep,
            Shopping
        }
        protected DialogOKCancelMode dialogMode;

        protected enum Exitmode
        {
            World,
            Victory,
            Shop
        }
        protected Exitmode exitMode;

        [SerializeField]
        protected string worldScene = "World";
        [SerializeField]
        protected string victoryScene = "Victory";
        [SerializeField]
        protected string shopScene = "Shop";

        bool puzzleBusy;

        protected override void AwakeInit()
        {
            dialogMode = DialogOKCancelMode.None;
            exitMode = Exitmode.World;
            registrator.Add(
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleBusy, handler = OnPuzzleBusy },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleComplete, handler = OnPuzzleComplete },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleWinImageStopped, handler = OnPuzzleWinImageStopped },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleSourceImageClosed, handler = OnPuzzleSourceImageClosed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIBackButtonPressed, handler = OnGUIBackButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIWhiteCurtainFaded, handler = OnGUIWhiteCurtainFaded },
                new MessageRegistrationTuple { type = InstantMessageType.GUIViewButtonPressed, handler = OnGUIViewButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIRestartButtonPressed, handler = OnGUIRestartButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIMagicButtonPressed, handler = OnGUIMagicButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIOKButtonPressed, handler = OnGUIOKButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUICancelButtonPressed, handler = OnGUICancelButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.MusicTrackPlayed, handler = OnMusicTrackPlayed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIRotoCoinsPressed, handler = OnGUIRotoCoinsPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIRotoChipsPressed, handler = OnGUIRotoChipsPressed },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleAutostepAvailable, handler = OnPuzzleAutostepAvailable },
                new MessageRegistrationTuple { type = InstantMessageType.ShopBlurryScreenshotTaken, handler = OnShopBlurryScreenshotTaken }
            );
        }

        // Use this for initialization
        void Start()
        {
            // notify that the Puzzle scene has just been started
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleStarted, this);
            // update RotoChips and RotoCoins indicators
            LevelDataManager.Descriptor descriptor = GlobalManager.MLevel.GetDescriptor(GlobalManager.MStorage.SelectedLevel);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIRotoChipsChanged, this, (decimal)descriptor.state.EarnedPoints);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIRotoCoinsChanged, this, GlobalManager.MStorage.CurrentCoins);
        }

        // message handling
        [SerializeField]
        protected string backQuestionId = "idGUIBackQuestion";
        void OnGUIBackButtonPressed(object sender, InstantMessageArgs args)
        {
            if (!puzzleBusy)
            {
                if (!GlobalManager.MHint.ShowNewHint(HintType.BackLevelButton))
                {
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleBusy, this, true);
                    dialogMode = DialogOKCancelMode.Back;
                    GlobalManager.MInstantMessage.DeliverMessage(
                        InstantMessageType.GUIStartDialogOKCancel, 
                        this, 
                        GlobalManager.MLanguage.Entry(backQuestionId)
                    );
                }
            }
        }

        void OnGUIViewButtonPressed(object sender, InstantMessageArgs args)
        {
            if (!puzzleBusy)
            {
                if (!GlobalManager.MHint.ShowNewHint(HintType.ShowSourceButton))
                {
                    // no need to set the puzzle busy because the SourceImage overlaps all the puzzle controls
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleViewSourceImage, this);
                }
            }
        }

        [SerializeField]
        protected string restartlevelQuestionId = "idGUIRestartLevelQuestion";
        void OnGUIRestartButtonPressed(object sender, InstantMessageArgs args)
        {
            if (!puzzleBusy)
            {
                if (!GlobalManager.MHint.ShowNewHint(HintType.AskForRestartButton))
                {
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleBusy, this, true);
                    dialogMode = DialogOKCancelMode.Reset;
                    GlobalManager.MInstantMessage.DeliverMessage(
                        InstantMessageType.GUIStartDialogOKCancel,
                        this,
                        GlobalManager.MLanguage.Entry(restartlevelQuestionId)
                    );
                }
            }
        }

        void OnGUIMagicButtonPressed(object sender, InstantMessageArgs args)
        {
            if (!puzzleBusy)
            {
                if (!GlobalManager.MHint.ShowNewHint(HintType.AutoStepButton))
                {
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleSetForAutostep, this);
                }
            }
        }

        [SerializeField]
        protected string magicQuestionId = "idGUIMagicQuestion";
        [SerializeField]
        protected string shopQuestionId = "idShopQuestion";
        void OnPuzzleAutostepAvailable(object sender, InstantMessageArgs args)
        {
            bool available = (bool)args.arg;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleBusy, this, true);
            if (available)
            {
                Debug.Log("Autostep available, running DialogOkCancel");
                dialogMode = DialogOKCancelMode.Autostep;
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzlePrepareAutostep, this);
                GlobalManager.MInstantMessage.DeliverMessage(
                    InstantMessageType.GUIStartDialogOKCancel,
                    this,
                    GlobalManager.MLanguage.Entry(magicQuestionId)
                );
            }
            else
            {
                dialogMode = DialogOKCancelMode.Shopping;
                GlobalManager.MInstantMessage.DeliverMessage(
                    InstantMessageType.GUIStartDialogOKCancel,
                    this,
                    GlobalManager.MLanguage.Entry(shopQuestionId)
                );
            }
        }

        void OnGUIOKButtonPressed(object sender, InstantMessageArgs args)
        {
            DialogOKCancelMode mode = dialogMode;
            dialogMode = DialogOKCancelMode.None;
            switch (mode)
            {
                case DialogOKCancelMode.Back:
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this);
                    break;
                case DialogOKCancelMode.Reset:
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleReset, this);
                    break;
                case DialogOKCancelMode.Autostep:
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleAutostep, this);
                    break;
                case DialogOKCancelMode.Shopping:
                    GlobalManager.MScreenshot.TakeShot();
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleReadyToShop, this);
                    break;
            }
        }

        void OnShopBlurryScreenshotTaken(object sender, InstantMessageArgs args)
        {
            exitMode = Exitmode.Shop;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this);
        }

        void OnGUICancelButtonPressed(object sender, InstantMessageArgs args)
        {
            dialogMode = DialogOKCancelMode.None;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleBusy, this, false);
        }

        void OnGUIWhiteCurtainFaded(object sender, InstantMessageArgs args)
        {
            bool up = (bool)args.arg;
            if (up)
            {
                // faded out, end the scene
                switch (exitMode)
                {
                    case Exitmode.World:
                        SceneManager.LoadScene(worldScene);
                        break;
                    case Exitmode.Victory:
                        GlobalManager.MAudio.PlayMusicTrack(AudioTrackEnum.Unknown);
                        SceneManager.LoadScene(victoryScene);
                        break;
                    case Exitmode.Shop:
                        SceneManager.LoadScene(shopScene);
                        break;
                }
            }
        }

        void OnPuzzleSourceImageClosed(object sender, InstantMessageArgs args)
        {
            // faded in, shuffle the puzzle if necessary
            //GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleShuffle, this, string.Empty);
        }

        void OnPuzzleBusy(object sender, InstantMessageArgs args)
        {
            puzzleBusy = (bool)args.arg;
        }

        [SerializeField]
        protected string victoryId = "idVictory";
        [SerializeField]
        protected string levelCompletedOnceAgainId = "idLevelCompletedOnceAgain";
        [SerializeField]
        protected AudioTrackEnum victoryMusicId = AudioTrackEnum.VictoryTheme;
        void OnPuzzleComplete(object sender, InstantMessageArgs args)
        {
            exitMode = Exitmode.Victory;
            PuzzleCompleteStatus completeStatus = (PuzzleCompleteStatus)args.arg;
            GlobalManager.MStorage.GalleryLevel = completeStatus.descriptor.init.id;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleBusy, this, true);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.BackgroundMusic, this, BackGroundMusicMode.Off);
            GlobalManager.MAudio.PlayMusicTrack(victoryMusicId, false);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleShowWinimage, this, completeStatus.firstTime ? victoryId : levelCompletedOnceAgainId);
        }

        void OnPuzzleWinImageStopped(object sender, InstantMessageArgs args)
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this);
        }

        [SerializeField]
        protected AudioTrackEnum ambienceTrackId = AudioTrackEnum.GalleryAmbience;
        void OnMusicTrackPlayed(object sender, InstantMessageArgs args)
        {
            if ((AudioTrackEnum)args.arg == victoryMusicId)
            {
                GlobalManager.MAudio.PlayMusicTrack(ambienceTrackId, true);
            }
        }

        void OnGUIRotoCoinsPressed(object sender, InstantMessageArgs args)
        {
            // this hint is shown every time the RotoCoins panel is tapped
            GlobalManager.MInstantMessage.DeliverMessage(
                InstantMessageType.GUIShowHint,
                this,
                new HintRequest
                {
                    type = HintType.PuzzleCoinsScoreTapped,
                    target = null
                }
            );
        }

        void OnGUIRotoChipsPressed(object sender, InstantMessageArgs args)
        {
            // this hint is shown every time the RotoChips panel is tapped
            GlobalManager.MInstantMessage.DeliverMessage(
                InstantMessageType.GUIShowHint,
                this,
                new HintRequest
                {
                    type = HintType.PuzzlePointScoreTapped,
                    target = null
                }
            );
        }
    }
}
