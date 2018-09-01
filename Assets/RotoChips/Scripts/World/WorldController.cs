/*
 * File:        WorldController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WorldController implements general game logic of the World scene
 * Created:     31.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RotoChips.Management;

namespace RotoChips.World
{
    public class WorldController : MonoBehaviour
    {

        bool worldRotated;
        bool cameraZoomed;
        bool curtainFaded;
        WorldCameraController cameraController;
        MessageRegistrator registrator;
        private void Awake()
        {
            worldRotated = false;
            cameraZoomed = false;
            curtainFaded = false;
            cameraController = Camera.main.GetComponent<WorldCameraController>();
            registrator = new MessageRegistrator(
                InstantMessageType.WorldCameraZoomedAtMin, (InstantMessageHandler)OnWorldCameraZoomedAtMin,
                InstantMessageType.WorldGlobePressed, (InstantMessageHandler)OnWorldGlobePressed,
                InstantMessageType.WorldSelectorPressed, (InstantMessageHandler)OnWorldSelectorPressed,
                InstantMessageType.WorldRotatedToObject, (InstantMessageHandler)OnWorldRotatedToObject,
                InstantMessageType.WorldRotoChipsPressed, (InstantMessageHandler)OnWorldRotoChipsPressed,
                InstantMessageType.WorldRotoCoinsPressed, (InstantMessageHandler)OnWorldRotoCoinsPressed,
                InstantMessageType.WorldSatellitePressed, (InstantMessageHandler)OnWorldSatellitePressed,
                InstantMessageType.GUIWhiteCurtainFaded, (InstantMessageHandler)OnGUIWhiteCurtainFaded
            );
            registrator.RegisterHandlers();
        }

        void Start()
        {
            // notify that the World scene has just been started
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldStarted, this);
            // update RotoChips and RotoCoins indicators
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.RotoChipsChanged, this);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.RotoCoinsChanged, this);
        }

        // message handling
        void OnWorldCameraZoomedAtMin(object sender, InstantMessageArgs args)
        {
            cameraZoomed = true;
        }

        void OnWorldRotatedToObject(object sender, InstantMessageArgs args)
        {
            worldRotated = true;
        }

        void OnGUIWhiteCurtainFaded(object sender, InstantMessageArgs args)
        {
            curtainFaded = true;
        }

        void OnWorldGlobePressed(object sender, InstantMessageArgs args)
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldAutoZoomCamera, this);
        }

        [SerializeField]
        protected string puzzleScene = "Puzzle";
        void OnWorldSelectorPressed(object sender, InstantMessageArgs args)
        {
            GameObject targetObject = ((Component)sender).gameObject;
            if (cameraController.Zoom != WorldCameraController.ZoomStatus.ZoomAtMin)
            {
                worldRotated = false;
                cameraZoomed = false;
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldZoomCameraAtMin, this);
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotateToObject, this, targetObject);
            }
            else
            {
                LevelDataManager.Descriptor descriptor = (LevelDataManager.Descriptor)args.arg;
                if (!descriptor.state.Complete)
                {
                    GlobalManager.MStorage.SelectedLevel = descriptor.init.id;
                    StartCoroutine(YieldToScene(targetObject, puzzleScene));
                }
            }
        }

        void OnWorldRotoChipsPressed(object sender, InstantMessageArgs args)
        {

        }

        void OnWorldRotoCoinsPressed(object sender, InstantMessageArgs args)
        {

        }

        [SerializeField]
        protected string galleryScene = "Gallery";
        void OnWorldSatellitePressed(object sender, InstantMessageArgs args)
        {
            GameObject targetObject = ((Component)sender).gameObject;
            StartCoroutine(YieldToScene(targetObject, galleryScene));
        }

        IEnumerator YieldToScene(GameObject initiator, string sceneName)
        {
            worldRotated = false;
            cameraZoomed = false;
            curtainFaded = false;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldZoomCameraAtMin, this);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotateToObject, this, initiator);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeOutWhiteCurtain, this);
            while (!curtainFaded)
            {
                yield return null;
            }
            if (!string.IsNullOrEmpty(sceneName))
            {
                SceneManager.LoadScene(sceneName);
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

    }
}
