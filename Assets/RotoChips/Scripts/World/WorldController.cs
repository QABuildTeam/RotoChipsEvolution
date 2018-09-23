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
using RotoChips.UI;

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
                InstantMessageType.GUIRotoChipsPressed, (InstantMessageHandler)OnGUIRotoChipsPressed,
                InstantMessageType.GUIRotoCoinsPressed, (InstantMessageHandler)OnGUIRotoCoinsPressed,
                InstantMessageType.WorldSatellitePressed, (InstantMessageHandler)OnWorldSatellitePressed,
                InstantMessageType.GUIWhiteCurtainFaded, (InstantMessageHandler)OnGUIWhiteCurtainFaded,
                InstantMessageType.GUIRestartButtonPressed, (InstantMessageHandler)OnGUIRestartButtonPressed,
                InstantMessageType.GUIViewButtonPressed, (InstantMessageHandler)OnGUIViewButtonPressed,
                InstantMessageType.WorldLevelDescriptionClosed, (InstantMessageHandler)OnWorldLevelDescriptionClosed,
                InstantMessageType.GUIMagicButtonPressed, (InstantMessageHandler)OnGUIMagicButtonPressed
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
            // rotate the world to the currently active level selector
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotateToSelected, this);
        }

        void RotateWorldToZero(GameObject targetObject)
        {
            worldRotated = false;
            cameraZoomed = false;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotationEnable, this, false);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldZoomCameraAtMin, this);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotateToObject, this, targetObject);
        }

        // message handling
        void OnWorldCameraZoomedAtMin(object sender, InstantMessageArgs args)
        {
            cameraZoomed = true;
        }

        void OnWorldRotatedToObject(object sender, InstantMessageArgs args)
        {
            worldRotated = true;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotationEnable, this, true);
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
                RotateWorldToZero(targetObject);
            }
            else
            {
                LevelDataManager.Descriptor descriptor = (LevelDataManager.Descriptor)args.arg;
                if (descriptor.state.Playable)
                {
                    if (descriptor.state.Complete)
                    {
                        // show a description of the complete level
                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotationEnable, this, false);
                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldShowLevelDescription, this, descriptor);
                    }
                    else
                    {
                        // start level
                        GlobalManager.MStorage.SelectedLevel = descriptor.init.id;
                        GlobalManager.MStorage.GalleryLevel = descriptor.init.id;
                        StartCoroutine(YieldToScene(targetObject, puzzleScene));
                    }
                }
                else
                {
                    // show hint message
                    GlobalManager.MInstantMessage.DeliverMessage(
                        InstantMessageType.GUIShowHint,
                        this,
                        new HintRequest
                        {
                            type = HintType.LevelNotYetPlayable,
                            target = null
                        }
                    );
                }
            }
        }

        void OnGUIRotoChipsPressed(object sender, InstantMessageArgs args)
        {
            GlobalManager.MInstantMessage.DeliverMessage(
                InstantMessageType.GUIShowHint,
                this,
                new HintRequest
                {
                    type = HintType.WorldPointScoreTapped,
                    target = null
                }
            );
        }

        void OnGUIRotoCoinsPressed(object sender, InstantMessageArgs args)
        {
            GlobalManager.MInstantMessage.DeliverMessage(
                InstantMessageType.GUIShowHint,
                this,
                new HintRequest
                {
                    type = HintType.WorldCoinsScoreTapped,
                    target = null
                }
            );
        }

        [SerializeField]
        protected string galleryScene = "Gallery";
        void OnWorldSatellitePressed(object sender, InstantMessageArgs args)
        {
            GameObject targetObject = ((Component)sender).gameObject;
            StartCoroutine(YieldToScene(targetObject, galleryScene));
        }

        void OnGUIRestartButtonPressed(object sender, InstantMessageArgs args)
        {
            if (!GlobalManager.MHint.ShowNewHint(HintType.GameRestartButton))
            {

            }
        }

        [SerializeField]
        protected string finaleScene = "Finale";
        void OnGUIViewButtonPressed(object sender, InstantMessageArgs args)
        {
            if (!GlobalManager.MHint.ShowNewHint(HintType.GameRollsButton))
            {
                StartCoroutine(YieldToScene(null, finaleScene));
            }
        }

        IEnumerator YieldToScene(GameObject initiator, string sceneName)
        {
            if (initiator != null)
            {
                RotateWorldToZero(initiator);
            }
            curtainFaded = false;
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

        void OnWorldLevelDescriptionClosed(object sender, InstantMessageArgs args)
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotationEnable, this, true);
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

        // special debug messaging
        HintType currentHint = HintType.None;
        void OnGUIMagicButtonPressed(object sender, InstantMessageArgs args)
        {
            do
            {
                HintType newHint = currentHint;
                foreach (HintType hintType in System.Enum.GetValues(typeof(HintType)))
                {
                    if (hintType > newHint)
                    {
                        newHint = hintType;
                        break;
                    }
                }
                if (newHint == currentHint)
                {
                    currentHint = HintType.None + 1;
                }
                else
                {
                    currentHint = newHint;
                }
            } while (!GlobalManager.MHint.Hints.ContainsKey(currentHint));
            GlobalManager.MInstantMessage.DeliverMessage(
                InstantMessageType.GUIShowHint,
                this,
                new HintRequest
                {
                    type = currentHint,
                    target = gameObject
                }
            );
        }

    }
}
