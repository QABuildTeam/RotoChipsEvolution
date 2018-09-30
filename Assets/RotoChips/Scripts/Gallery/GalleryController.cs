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

namespace RotoChips.Gallery
{
    public class GalleryController : MonoBehaviour
    {

        protected enum ExitMode
        {
            Gallery,
            World
        }
        ExitMode exitMode;
        MessageRegistrator registrator;
        private void Awake()
        {
            exitMode = ExitMode.Gallery;
            registrator = new MessageRegistrator(
                InstantMessageType.GUIWhiteCurtainFaded, (InstantMessageHandler)OnGUIFadeWhiteCurtain,
                InstantMessageType.PuzzleWinImageStopped, (InstantMessageHandler)OnPuzzleWinImageStopped,
                InstantMessageType.PuzzleWinImageFinished, (InstantMessageHandler)OnPuzzleWinImageFinished,
                InstantMessageType.GUIBackButtonPressed, (InstantMessageHandler)OnGUIBackButtonPressed
            );
            registrator.RegisterHandlers();
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
                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleShowWinimage, this);
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
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this);
        }

        [SerializeField]
        protected float fullImageDelay = 2f;
        IEnumerator ShowNextImage()
        {
            yield return new WaitForSeconds(fullImageDelay);
            exitMode = ExitMode.Gallery;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this);
        }

        void OnPuzzleWinImageFinished(object sender, InstantMessageArgs args)
        {
            StartCoroutine(ShowNextImage());
        }

        void OnGUIBackButtonPressed(object sender, InstantMessageArgs args)
        {
            exitMode = ExitMode.World;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this);
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
