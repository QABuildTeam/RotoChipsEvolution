/*
 * File:        WorldSphereController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WorldSphereController controls the world sphere rotation by the player's input on the World scene
 * Created:     31.08.2018
 */
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using RotoChips.Management;

namespace RotoChips.World
{
    public class WorldSphereController : MonoBehaviour
    {

        [SerializeField]
        protected float rotationTime;
        MessageRegistrator registrator;
        void Awake()
        {
            registrator = new MessageRegistrator(
                InstantMessageType.SteadyMouseUpAsButton, (InstantMessageHandler)OnSteadyMouseUpAsButton,
                InstantMessageType.WorldRotateToObject, (InstantMessageHandler)OnWorldRotateToObject,
                InstantMessageType.WorldRotationEnable, (InstantMessageHandler)OnWorldRotationEnable
            );
            registrator.RegisterHandlers();
        }

        void Start()
        {
            /*
            HintSystemScript.instance.SetListener(gameObject);
            // the game cannot be restarted during the first round
            // the player can watch the final rolls sequence any time after the game is finished
            bool notFirstRound = !(bool)AppData.instance[AppData.Storage.FirstRound];
            GameGUIScript.instance.setupLevelGUI(false, notFirstRound, notFirstRound, false, true);
            GameGUIScript.instance.setPointScore((long)AppData.instance[AppData.Storage.CurrentPoints]);
            GameGUIScript.instance.setCoinsBalance((decimal)AppData.instance[AppData.Storage.CurrentCoins]);
            GameManager.instance.processGameEvent(GameManager.GameEvents.WorldLoaded);
            */
        }

        // ======== Callbacks ========
        // -------- Generic callbacks --------
        // this method is a callback for Fader fadein
        // -------- GUI callbacks -------
        // this method is a callback for AskForRestart GUI button
        // it works in level select mode only
        public void AskForRestart()
        {
            /*
            if (GameManager.instance.processGameEvent(GameManager.GameEvents.WorldButtonRestartGamePressed))
            {
                status = eWorldStatus.WaitingInput;
            }
            else
            {
                status = eWorldStatus.RestartDialog;
                Dialog.GetComponent<DialogOkCancelScript>().Activate(LocalizationManager.instance.GetLocalizedValue("REALLY RESET THE GAME?"));
            }
            */
        }

        // this method is a callback for Source GUI button
        public void ShowSource()
        {
            /*
            if (GameManager.instance.processGameEvent(GameManager.GameEvents.WorldButtonShowFinalRollsPressed))
            {
                status = eWorldStatus.WaitingInput;
            }
            else
            {
                //mf.FadeOut();
                Fader.FadeOut(FinalScene);
            }
            */
        }

        // this is a callback method which is called whenever a 'pointsScore' GUI area is tapped
        public void PointsTap()
        {
            /*
            switch (status)
            {
                case eWorldStatus.WaitingInput:
                    //Debug.Log("Points tapped");
                    GameManager.instance.processGameEvent(GameManager.GameEvents.WorldPointScoreTapped);
                    break;
            }
            */
        }

        // this is a callback method which is called whenever a 'pointsScore' GUI area is tapped
        public void CoinsTap()
        {
            /*
            switch (status)
            {
                case eWorldStatus.WaitingInput:
                    GameManager.instance.processGameEvent(GameManager.GameEvents.WorldCoinsScoreTapped);
                    break;
            }
            */
        }

        // -- Dialog callbacks --
        // this is a callback method which is called whenever an OK button in the dialog is pressed
        public void OKAction()
        {
            /*
            switch (status)
            {
                case eWorldStatus.RestartDialog:
                    GameManager.instance.resetGame();           // reset the game
                    //mf.FadeOut();
                    //FaderCanvas.SetActive (true);			// make the fader active first
                    Fader.FadeOut(gameObject.scene.name);   // restart the level
                    break;
            }
            */
        }

        // this is a callback method which is called whenever a Cancel button in the dialog is pressed
        public void CancelAction()
        {
            /*
            status = eWorldStatus.WaitingInput;
            */
        }


        // this method is a callback called after a hint is removed
        public void HintRemoved()
        {
            /*
            switch (status)
            {
                case eWorldStatus.FirstWelcomeHint:
                    // display second welcome message
                    status = eWorldStatus.FirstWelcomeHint2;
                    //Debug.Log("displaying hint 2");
                    focusWorld(true);
                    HintSystemScript.instance.DisplayHint(HintSystemScript.HintType.FirstTimeWelcome2, obj: wsm.activeSelectorObject());
                    break;
                    */
            /*
        case eWorldStatus.FirstWelcomeHint2:
            AppData.instance[AppData.Storage.FirstStart] = false;
            wsm.enableRotation();
            status = eWorldStatus.Init;
            break;
        case eWorldStatus.GalleryOpenedHint:
            AppData.instance[AppData.Storage.FirstGallery] = false;
            wsm.enableRotation();
            //status = eWorldStatus.WaitingInput;
            status = eWorldStatus.Init;
            break;
            */
            //case eWorldStatus.GameFinishedHint:
            /*
            status = eWorldStatus.RestartGameHint;
            HintSystemScript.instance.DisplayHint(HintSystemScript.HintType.GameRestartButton, point: LevelGUIAskForRestartButton.transform.position);
            break;
            /*
        case eWorldStatus.RestartGameHint:
            status = eWorldStatus.GameRollsHint;
            HintSystemScript.instance.DisplayHint(HintSystemScript.HintType.GameRollsButton, point: LevelGUISourceButton.transform.position);
            break;
        case eWorldStatus.GameRollsHint:
        */
            /*
				AppData.instance[AppData.Storage.FirstTimeFinished] = false;
				status = eWorldStatus.Init;
				break;
			default:
				wsm.enableRotation();
				status = eWorldStatus.WaitingInput;
				break;
		}
        */
        }

        // this method is a callback called after an arrow is tapped and a hint is removed
        public void HintArrowRemoved()
        {
            /*
            //Debug.Log("Hint arrow removed with status " + status.ToString());
            switch (status)
            {
                case eWorldStatus.FirstWelcomeHint2:
                    AppData.instance[AppData.Storage.FirstStart] = false;
                    runPuzzle();
                    break;
                case eWorldStatus.GalleryOpenedHint:
                    //Debug.Log("Gallery hint arrow removed on world");
                    AppData.instance[AppData.Storage.FirstGallery] = false;
                    runGallery();
                    break;
                case eWorldStatus.RestartGameHint:
                    status = eWorldStatus.GameRollsHint;
                    HintSystemScript.instance.DisplayHint(HintSystemScript.Type.GameRollsButton, point: GameGUIScript.instance.SourceButtonObject.transform.position);
                    break;
                case eWorldStatus.GameRollsHint:
                    AppData.instance[AppData.Storage.FirstTimeFinished] = false;
                    status = eWorldStatus.Init;
                    break;
                default:
                    wsm.enableRotation();
                    status = eWorldStatus.WaitingInput;
                    break;
            }
            */
        }

        // ======== Hint system handling ==========
        void ProcessHints()
        {
            /*
            if (status != eWorldStatus.WaitingInput)
            {
                return;
            }
            if (HintSystemScript.instance.checkNextHint(HintSystemScript.Environment.World))
            {
                HintSystemScript.QueuedHint hint = HintSystemScript.instance.getNextHint();
                switch (hint.type)
                {
                    case HintSystemScript.Type.FirstTimeWelcome:
                        status = eWorldStatus.FirstWelcomeHint;
                        wsm.disableRotation();
                        // display welcome message
                        //Debug.Log("displaying welcome hint 1");
                        HintSystemScript.instance.DisplayHint(HintSystemScript.Type.FirstTimeWelcome);
                        break;
                    case HintSystemScript.Type.FirstTimeWelcome2:
                        // display second welcome message
                        status = eWorldStatus.FirstWelcomeHint2;
                        //Debug.Log("displaying welcome hint 2");
                        wsm.disableRotation();
                        focusWorld(true);
                        HintSystemScript.instance.DisplayHint(HintSystemScript.Type.FirstTimeWelcome2, obj: wsm.activeSelectorObject());
                        break;
                    case HintSystemScript.Type.GalleryOpened:
                        status = eWorldStatus.GalleryOpenedHint;
                        //Debug.Log("Displaying hint GalleryOpened");
                        wsm.disableRotation();
                        // display message about the gallery satellite
                        HintSystemScript.instance.DisplayHint(HintSystemScript.Type.GalleryOpened, obj: GallerySatellite);
                        // unzoom the world
                        zoomCamera(true);
                        // and rotate the world sphere to show the satellite
                        wsm.rotateToObject(GallerySatellite);
                        break;
                    case HintSystemScript.Type.GameFinishedCongratulation:
                        status = eWorldStatus.GameFinishedHint;
                        //Debug.Log("Displaying hint for GameFinishedCongratulation");
                        HintSystemScript.instance.DisplayHint(HintSystemScript.Type.GameFinishedCongratulation);
                        break;
                        */
            /*
        case HintSystemScript.Type.LevelNotYetPlayable:
            status = eWorldStatus.HintActive;
            wsm.disableRotation();
            HintSystemScript.instance.DisplayHint(HintSystemScript.Type.LevelNotYetPlayable);
            break;
            */
            /*
        default:
            //Debug.Log("Displaying hint " + hint.type.ToString());
            status = eWorldStatus.HintActive;
            wsm.disableRotation();
            HintSystemScript.instance.DisplayHint(hint.type);
            break;
    }
}
*/
        }


        // message handling
        void OnSteadyMouseUpAsButton(object sender, InstantMessageArgs args)
        {
            if ((GameObject)args.arg == gameObject)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldGlobePressed, this);
            }
        }

        // this method rotates the globe such that a particular object on it is placed right before the player's view
        IEnumerator RotateToSphereZero(GameObject rotateTarget)
        {
            // this method rotates the world sphere so that the selected spike would stop right before the player's eyes
            Vector3 pos = rotateTarget.transform.position;  // a vector that points to rotateTarget
            Vector3 viewer = Vector3.back;                  // a vector that points to the player
            float angle = Vector3.Angle(pos, viewer);       // a flat angle between start (pos) and end (viewer) vectors
            if (Math.Abs(angle) > 0.5f)                     // do not rotate if the angle is too small
            {
                Vector3 cross = Vector3.Cross(pos, viewer); // cross product of pos and viewer
                float currentTime = 0;
                float currentAngle = 0;
                while (currentTime < rotationTime)
                {
                    yield return null;
                    currentTime += Time.deltaTime;
                    float deltaAngle = angle * Time.deltaTime;
                    currentAngle += deltaAngle;
                    transform.Rotate(cross, deltaAngle, Space.World);
                }
                currentAngle -= angle;
                if (currentAngle != 0)
                {
                    transform.Rotate(cross, -currentAngle, Space.World);
                }
            }
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotatedToObject, this, rotateTarget);
        }

        // message handling
        void OnWorldRotateToObject(object sender, InstantMessageArgs args)
        {
            GameObject rotateTarget = (GameObject)args.arg;
            if (rotateTarget != null)
            {
                StartCoroutine(RotateToSphereZero(rotateTarget));
            }
        }

        void OnWorldRotationEnable(object sender, InstantMessageArgs args)
        {
            rotationEnabled = (bool)args.arg;
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

        [SerializeField]
        protected float worldRotateFactor;
        bool rotationEnabled;
        void EnableRotation(bool on)
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotationEnable, this, on);
        }

        void ProcessInput()
        {
            switch (GlobalManager.MInput.CheckInput())
            {
                case TouchInput.InputStatus.SinglePress:
                case TouchInput.InputStatus.DoublePress:
                    if (rotationEnabled)
                    {
                        EnableRotation(false);
                        EnableRotation(true);
                    }
                    break;

                case TouchInput.InputStatus.SingleMove:
                    if (rotationEnabled)
                    {
                        // rotate the world to the direction of a finger/mouse move
                        EnableRotation(false);
                        Vector3 moveDelta = GlobalManager.MInput.MoveDelta;
                        float cameraDistance = Camera.main.transform.position.z;
                        Vector3 rotateDelta = new Vector3(moveDelta.y, -moveDelta.x, 0) * cameraDistance * worldRotateFactor;
                        transform.Rotate(rotateDelta, Space.World);
                        EnableRotation(true);
                    }
                    break;

                case TouchInput.InputStatus.DoubleMove:
                    if (rotationEnabled)
                    {
                        // rotate the world around z-axis
                        EnableRotation(false);
                        transform.Rotate(new Vector3(0, 0, GlobalManager.MInput.AngleDelta), Space.World);
                        EnableRotation(true);
                    }
                    break;

            }
        }
        // Update is called once per frame
        void Update()
        {
            ProcessInput();
        }

    }
}
