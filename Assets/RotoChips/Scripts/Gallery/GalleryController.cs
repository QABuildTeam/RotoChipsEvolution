/*
 * File:        GalleryController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class GalleryController controls the entire logic for the Gallery scene
 * Created:     17.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.Gallery
{
    public class GalleryController : GenericMessageHandler
    {

        protected enum ExitMode
        {
            Gallery,
            World
        }
        ExitMode exitMode;

        protected override void AwakeInit()
        {
            exitMode = ExitMode.Gallery;
            registrator.Add(
                new MessageRegistrationTuple { type = InstantMessageType.GUIWhiteCurtainFaded, handler = OnGUIFadeWhiteCurtain },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleWinImageStopped, handler = OnPuzzleWinImageStopped },
                new MessageRegistrationTuple { type = InstantMessageType.PuzzleWinImageFinished, handler = OnPuzzleWinImageFinished },
                new MessageRegistrationTuple { type = InstantMessageType.GUIBackButtonPressed, handler = OnGUIBackButtonPressed }
            );
        }

        // Use this for initialization
        void Start()
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GalleryStarted, this);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleShowWinimage, this, string.Empty);
        }

        // message handling
        [SerializeField]
        protected string worldScene = "World";
        void OnGUIFadeWhiteCurtain(object sender, InstantMessageArgs args)
        {
            bool up = (bool)args.arg;
            if (up)
            {
                switch (exitMode)
                {
                    case ExitMode.Gallery:
                        int galleryLevel = GlobalManager.MStorage.GalleryLevel;
                        LevelDataManager.Descriptor descriptor = GlobalManager.MLevel.GetDescriptor(galleryLevel);
                        int nextGalleryLevel = descriptor.state.NextCompleteId;
                        if (nextGalleryLevel < 0)
                        {
                            nextGalleryLevel = 0;
                        }
                        GlobalManager.MStorage.GalleryLevel = nextGalleryLevel;
                        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleShowWinimage, this, string.Empty);
                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this, false);
                        break;
                    case ExitMode.World:
                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GalleryClosed, this);
                        SceneManager.LoadScene(worldScene);
                        break;
                }
            }
        }

        void OnPuzzleWinImageStopped(object sender, InstantMessageArgs args)
        {
            exitMode = ExitMode.Gallery;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this, true);
        }

        [SerializeField]
        protected float fullImageDelay = 2f;
        IEnumerator ShowNextImage()
        {
            yield return new WaitForSeconds(fullImageDelay);
            exitMode = ExitMode.Gallery;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this, true);
        }

        void OnPuzzleWinImageFinished(object sender, InstantMessageArgs args)
        {
            StartCoroutine(ShowNextImage());
        }

        void OnGUIBackButtonPressed(object sender, InstantMessageArgs args)
        {
            exitMode = ExitMode.World;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this, true);
        }

    }
}
