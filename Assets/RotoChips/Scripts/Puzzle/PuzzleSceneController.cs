﻿/*
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

namespace RotoChips.Puzzle
{
    public class PuzzleSceneController : MonoBehaviour
    {

        protected enum DialogOKCancelMode
        {
            None,
            Back,
            Reset,
            Autostep
        }
        protected DialogOKCancelMode dialogMode;

        protected enum Exitmode
        {
            World,
            Victory
        }
        protected Exitmode exitMode;

        [SerializeField]
        protected string worldScene = "World";
        [SerializeField]
        protected string victoryScene = "Victory";

        MessageRegistrator registrator;
        bool puzzleBusy;

        private void Awake()
        {
            dialogMode = DialogOKCancelMode.None;
            exitMode = Exitmode.World;
            registrator = new MessageRegistrator(
                InstantMessageType.PuzzleBusy, (InstantMessageHandler)OnPuzzleBusy,
                InstantMessageType.PuzzleComplete, (InstantMessageHandler)OnPuzzleComplete,
                InstantMessageType.PuzzleWinImageStopped, (InstantMessageHandler)OnPuzzleWinImageStopped,
                InstantMessageType.PuzzleSourceImageClosed, (InstantMessageHandler)OnPuzzleSourceImageClosed,
                InstantMessageType.GUIBackButtonPressed, (InstantMessageHandler)OnGUIBackButtonPressed,
                InstantMessageType.GUIWhiteCurtainFaded, (InstantMessageHandler)OnGUIWhiteCurtainFaded,
                InstantMessageType.GUIViewButtonPressed, (InstantMessageHandler)OnGUIViewButtonPressed,
                InstantMessageType.GUIRestartButtonPressed, (InstantMessageHandler)OnGUIRestartButtonPressed,
                InstantMessageType.GUIMagicButtonPressed, (InstantMessageHandler)OnGUIMagicButtonPressed,
                InstantMessageType.GUIOKButtonPressed, (InstantMessageHandler)OnGUIOKButtonPressed,
                InstantMessageType.GUICancelButtonPressed, (InstantMessageHandler)OnGUICancelButtonPressed,
                InstantMessageType.MusicTrackPlayed, (InstantMessageHandler)OnMusicTrackPlayed,
                InstantMessageType.GUIRotoCoinsPressed, (InstantMessageHandler)OnGUIRotoCoinsPressed,
                InstantMessageType.GUIRotoChipsPressed, (InstantMessageHandler)OnGUIRotoChipsPressed
            );
            registrator.RegisterHandlers();
        }
        // Use this for initialization
        void Start()
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleStarted, this);
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
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIStartDialogOKCancel, this, backQuestionId);
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
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIStartDialogOKCancel, this, restartlevelQuestionId);
                }
            }
        }

        [SerializeField]
        protected string magicQuestionId = "idGUIMagicQuestion";
        void OnGUIMagicButtonPressed(object sender, InstantMessageArgs args)
        {
            if (!puzzleBusy)
            {
                if (!GlobalManager.MHint.ShowNewHint(HintType.AutoStepButton))
                {
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleBusy, this, true);
                    dialogMode = DialogOKCancelMode.Autostep;
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzlePrepareAutostep, this);
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIStartDialogOKCancel, this, magicQuestionId);
                }
            }
        }

        void OnGUIOKButtonPressed(object sender, InstantMessageArgs args)
        {
            switch (dialogMode)
            {
                case DialogOKCancelMode.Back:
                    dialogMode = DialogOKCancelMode.None;
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this);
                    break;
                case DialogOKCancelMode.Reset:
                    dialogMode = DialogOKCancelMode.None;
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleReset, this);
                    break;
                case DialogOKCancelMode.Autostep:
                    dialogMode = DialogOKCancelMode.None;
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleAutostep, this);
                    break;
            }
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
        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
