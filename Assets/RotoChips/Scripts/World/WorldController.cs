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
using RotoChips.Accounting;
using RotoChips.Management;
using RotoChips.UI;
using RotoChips.Generic;

namespace RotoChips.World
{
    public class WorldController : GenericMessageHandler
    {

        bool worldRotated;
        bool cameraZoomed;
        bool curtainFaded;
        WorldCameraController cameraController;

        protected override void AwakeInit()
        {
            worldRotated = false;
            cameraZoomed = false;
            curtainFaded = false;
            dialogMode = false;
            cameraController = Camera.main.GetComponent<WorldCameraController>();
            registrator.Add(
                new MessageRegistrationTuple { type = InstantMessageType.WorldCameraZoomedAtMin, handler = OnWorldCameraZoomedAtMin },
                new MessageRegistrationTuple { type = InstantMessageType.WorldGlobePressed, handler = OnWorldGlobePressed },
                new MessageRegistrationTuple { type = InstantMessageType.WorldSelectorPressed, handler = OnWorldSelectorPressed },
                new MessageRegistrationTuple { type = InstantMessageType.WorldRotatedToObject, handler = OnWorldRotatedToObject },
                new MessageRegistrationTuple { type = InstantMessageType.GUIRotoChipsPressed, handler = OnGUIRotoChipsPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIRotoCoinsPressed, handler = OnGUIRotoCoinsPressed },
                new MessageRegistrationTuple { type = InstantMessageType.WorldSatellitePressed, handler = OnWorldSatellitePressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIWhiteCurtainFaded, handler = OnGUIWhiteCurtainFaded },
                new MessageRegistrationTuple { type = InstantMessageType.GUIRestartButtonPressed, handler = OnGUIRestartButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIViewButtonPressed, handler = OnGUIViewButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUIMagicButtonPressed, handler = OnGUIMagicButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.WorldLevelDescriptionClosed, handler = OnWorldLevelDescriptionClosed },
                new MessageRegistrationTuple { type = InstantMessageType.AdvertisementResult, handler = OnAdvertisementResult },
                new MessageRegistrationTuple { type = InstantMessageType.GUIOKButtonPressed, handler = OnGUIOKButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUICancelButtonPressed, handler = OnGUICancelButtonPressed }
            );
        }

        void Start()
        {
            // notify that the World scene has just been started
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldStarted, this);
            // update RotoChips and RotoCoins indicators
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIRotoChipsChanged, this, (decimal)GlobalManager.MStorage.CurrentPoints);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIRotoCoinsChanged, this, GlobalManager.MStorage.CurrentCoins);
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
        [SerializeField]
        protected string galleryScene = "Gallery";
        [SerializeField]
        protected string finaleScene = "Finale";
        [SerializeField]
        protected string restartGameQuestion = "idGUIRestartGameQuestion";
        [SerializeField]
        protected SFXPlayParams levelDescriptionSFX;
        [SerializeField]
        protected SFXPlayParams noLevelSFX;
        [SerializeField]
        protected SFXPlayParams startLevelSFX;
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
                        GlobalManager.MAudio.PlaySFX(levelDescriptionSFX);
                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotationEnable, this, false);
                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldShowLevelDescription, this, descriptor);
                    }
                    else
                    {
                        // start level
                        GlobalManager.MAudio.PlaySFX(startLevelSFX);
                        GlobalManager.MStorage.SelectedLevel = descriptor.init.id;
                        GlobalManager.MStorage.GalleryLevel = descriptor.init.id;
                        StartCoroutine(YieldToScene(targetObject, puzzleScene));
                    }
                }
                else
                {
                    // show hint message
                    GlobalManager.MAudio.PlaySFX(noLevelSFX);
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

        void OnWorldSatellitePressed(object sender, InstantMessageArgs args)
        {
            GameObject targetObject = ((Component)sender).gameObject;
            StartCoroutine(YieldToScene(targetObject, galleryScene));
        }

        bool dialogMode;
        void OnGUIRestartButtonPressed(object sender, InstantMessageArgs args)
        {
            if (!GlobalManager.MHint.ShowNewHint(HintType.GameRestartButton))
            {
                if (!GlobalManager.MHint.ShowNewHint(HintType.GameRestartButton))
                {
                    dialogMode = true;
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotationEnable, this, false);
                    GlobalManager.MInstantMessage.DeliverMessage(
                        InstantMessageType.GUIStartDialogOKCancel,
                        this,
                        GlobalManager.MLanguage.Entry(restartGameQuestion)
                    );
                }
            }
        }

        void OnGUIOKButtonPressed(object sender, InstantMessageArgs args)
        {
            if (dialogMode)
            {
                // clear level states
                GlobalManager.MLevel.InitializeLevels();
                // restart the scene
                YieldToScene(null, SceneManager.GetActiveScene().name);
            }
        }

        void OnGUICancelButtonPressed(object sender, InstantMessageArgs args)
        {
            if (dialogMode)
            {
                dialogMode = false;
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotationEnable, this, true);
            }
        }

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
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this);
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

        // advertisements
        void OnGUIMagicButtonPressed(object sender, InstantMessageArgs args)
        {
            if (!GlobalManager.MHint.ShowNewHint(HintType.ShowAdHint))
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldBlockScreen, this, true);
                if (!GlobalManager.MAds.ShowAd())
                {
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldBlockScreen, this, false);
                }
            }
        }

        void OnAdvertisementResult(object sender, InstantMessageArgs args)
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldBlockScreen, this, false);
        }

    }
}
