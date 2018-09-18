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
                InstantMessageType.GUIWhiteCurtainFaded, (InstantMessageHandler)OnGUIWhiteCurtainFaded,
                InstantMessageType.PuzzleWinImageStopped, (InstantMessageHandler)OnPuzzleWinImageStopped,
                InstantMessageType.GUIBackButtonPressed, (InstantMessageHandler)OnGUIBackButtonPressed
            );
            registrator.RegisterHandlers();
        }

        // Use this for initialization
        void Start()
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleShowWinimage, this, string.Empty);
        }

        // message handling
        [SerializeField]
        protected string worldScene = "World";
        void OnGUIWhiteCurtainFaded(object sender, InstantMessageArgs args)
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
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                        break;
                    case ExitMode.World:
                        SceneManager.LoadScene(worldScene);
                        break;
                }
            }
            else
            {

            }
        }

        void OnPuzzleWinImageStopped(object sender, InstantMessageArgs args)
        {
            exitMode = ExitMode.Gallery;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeOutWhiteCurtain, this);
        }

        void OnGUIBackButtonPressed(object sender, InstantMessageArgs args)
        {
            exitMode = ExitMode.World;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeOutWhiteCurtain, this);
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
