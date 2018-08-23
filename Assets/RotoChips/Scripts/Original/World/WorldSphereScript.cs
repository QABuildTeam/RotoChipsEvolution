using UnityEngine;
using System.Collections;
//using System;
//using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WorldSphereScript : MonoBehaviour
{

	bool selectMode;                // view mode in whatever mode (level selection or gallery): false - view mode, true - select mode

	int activeSelector;             // selected level for playing
	int gallerySelector;
	int levelSelector;
	//MusicFader mf;

	public float HintArrowDistance = 20f;   // a temporary solution

	// ----- color debug -----
	Vector2 colorTuningStart;
	Color colorTuning;
	float intensityTuning;
	public GameObject WorldLight;
	public GameObject LightValueText;
	public GameObject LightIntensityText;
	// -----------------------

	public enum eWorldStatus
	{
		Init,                       // start up status
		HintProcessing,				// hint is active
		FirstWelcomeHint,           // welcome message
		FirstWelcomeHint2,
		GalleryOpenedHint,          // gallery opened
		GameFinishedHint,			// the game has just been finished but not yet restarted
		RestartGameHint,			// a hint for game restart button
		GameRollsHint,				// a hint for game rolls button
		GameFinishedInit,           // game finished
									// ---- debug modes ----
		ColorTuning,
		IntensityTuning,
		// ---------------------
		WaitingInput,               // waiting for user input in whatever mode
		UserTap,                    // player's just tapped the screen
		UserRelease,                // player's just finished the tap
		WorldRotating,              // the world sphere is rotating to the "zero point"
		SelectorFlash,              // a selector object (a spike or the satellite) is flashing before running an action
		FadeToWorld,                // fading from white/black screen to a world view
		FadeFromWorld,              // fading from a world view to white/black screen
		RunAction,                  // an external action is performed (a level or a gallery start)
		RestartDialog,				// dialog started
		HintActive,					// non-specific hint is being displyed
		DescriptionActive			// a completed level description is being displayed
	};
	eWorldStatus status;

	public string GalleryScene;
	public string FinalScene;
	public string LevelScene;
	public float worldRotateFactor;  // = 0.01

	GameObject CenterRotator;       // an empty GameObject which rotates the satellite around the world sphere
	GameObject GallerySatellite;    // satellite
	bool GallerySatelliteActive;    // satellite is only visible after level 0 completion
									//GameObject LevelGUI;            // gallery GUI link
	//GameObject LevelGUIAskForRestartButton;
	//GameObject LevelGUISourceButton;
	//GameObject LevelGUIAutoStepButton;
	GameObject Dialog;
	WhiteCurtainFader Fader;        // fader
	//GameObject FaderCanvas;		// fader canvas

	LevelSelectScript lss;      // a LevelSelectScript of a selected level button
	WorldSphereModel wsm;       // a link to the WorldSphereModel script
	WorldCameraController wcc;  // a link to the WorldCameraController script
	SatelliteScript ss;         // a link to the SatelliteScript
	PuzzleInput puzzleInput;    // a link to the PuzzleInput script
	LevelDescriptionScript lds;	// a link to the LevelDescriptionScript

	bool sphereToZero;          // coroutine flag
	bool cameraMoved;           // coroutine flag

	void Awake()
	{
		status = eWorldStatus.Init;
		wsm = gameObject.GetComponent<WorldSphereModel>();
		puzzleInput = gameObject.GetComponent<PuzzleInput>();
		wcc = gameObject.GetComponent<WorldCameraController>();
		CenterRotator = GameObject.Find("CenterRotator");
		GallerySatellite = GameObject.Find("GallerySatellite");
		// set gallery satellite visibility
		LevelData.Descriptor ld = LevelData.instance[0];
		// the satellite is visible if level 0 is complete
		GallerySatelliteActive = ld.status.Complete;
		GallerySatellite.SetActive(GallerySatelliteActive);
		ss = CenterRotator.GetComponent<SatelliteScript>();
		//mf = gameObject.GetComponent<MusicFader>();
		lds = GameObject.Find("DescriptionCanvas").GetComponent<LevelDescriptionScript>();

		// set up the dialog links
		Dialog = GameObject.Find("DialogOkCancel");
		Dialog.SetActive(false);

		// setup the scene fader
		//FaderCanvas = GameObject.Find("LevelTransition");
		Fader = GameObject.Find("LevelTransition").GetComponent<WhiteCurtainFader>();
		Fader.SetColor(Color.white);

		selectMode = false;

		sphereToZero = false;
		cameraMoved = false;

	}

	void Start()
	{
        HintSystemScript.instance.SetListener(gameObject);
		// the game cannot be restarted during the first round
		// the player can watch the final rolls sequence any time after the game is finished
		bool notFirstRound = !(bool)AppData.instance[AppData.Storage.FirstRound];
		GameGUIScript.instance.setupLevelGUI(false, notFirstRound, notFirstRound, false, true);
		GameGUIScript.instance.setPointScore((long)AppData.instance[AppData.Storage.CurrentPoints]);
		GameGUIScript.instance.setCoinsBalance((decimal)AppData.instance[AppData.Storage.CurrentCoins]);
		GameManager.instance.processGameEvent(GameManager.GameEvents.WorldLoaded);
	}

	// ======== Callbacks ========
	// -------- Generic callbacks --------
	// this method is a callback for Fader fadein
	public void FadedIn()
	{
		/*
        switch (status)
        {
            case eWorldStatus.FadeToWorld:
                //Debug.Log("Faded to world");
                status = eWorldStatus.WaitingInput;         // level select or gallery mode; either way, go for player's input
        */
		//Debug.Log("deactivating fader");
		//FaderCanvas.SetActive(false);
		/*
                break;
            default:
                break;
        }
        */
	}

	// -------- GUI callbacks -------
	// this method is a callback for AskForRestart GUI button
	// it works in level select mode only
	public void AskForRestart()
	{
		if (GameManager.instance.processGameEvent(GameManager.GameEvents.WorldButtonRestartGamePressed))
		{
			status = eWorldStatus.WaitingInput;
		}
		else
		{
			status = eWorldStatus.RestartDialog;
			Dialog.GetComponent<DialogOkCancelScript>().Activate(LocalizationManager.instance.GetLocalizedValue("REALLY RESET THE GAME?"));
		}
	}

	// this method is a callback for Source GUI button
	public void ShowSource()
	{
		if (GameManager.instance.processGameEvent(GameManager.GameEvents.WorldButtonShowFinalRollsPressed))
		{
			status = eWorldStatus.WaitingInput;
		}
		else
		{
			//mf.FadeOut();
			Fader.FadeOut(FinalScene);
		}
	}

	// this is a callback method which is called whenever a 'pointsScore' GUI area is tapped
	public void PointsTap()
	{
		switch (status)
		{
			case eWorldStatus.WaitingInput:
				//Debug.Log("Points tapped");
				GameManager.instance.processGameEvent(GameManager.GameEvents.WorldPointScoreTapped);
				break;
		}
	}

	// this is a callback method which is called whenever a 'pointsScore' GUI area is tapped
	public void CoinsTap()
	{
		switch (status)
		{
			case eWorldStatus.WaitingInput:
				GameManager.instance.processGameEvent(GameManager.GameEvents.WorldCoinsScoreTapped);
				break;
		}
	}

	// ----- debug callbacks ---------
	// ColorTuning
	public void AutoStep()
	{
		/*
		if (status != eWorldStatus.ColorTuning)
		{
			status = eWorldStatus.ColorTuning;
			Debug.Log("tuning light color");
		}
		else
		{
			status = eWorldStatus.WaitingInput;
		}
		*/
		//SceneManager.LoadScene("MobileTouchInput");
	}

	// Intensity tuning
	public void BackLevel()
	{
		if (status != eWorldStatus.IntensityTuning)
		{
			status = eWorldStatus.IntensityTuning;
			//Debug.Log("tuning light intensity");
		}
		else
		{
			status = eWorldStatus.WaitingInput;
		}
	}
	// -------------------------------

	// -- Dialog callbacks --
	// this is a callback method which is called whenever an OK button in the dialog is pressed
	public void OKAction()
	{
		switch (status)
		{
			case eWorldStatus.RestartDialog:
				GameManager.instance.resetGame();           // reset the game
				//mf.FadeOut();
				//FaderCanvas.SetActive (true);			// make the fader active first
				Fader.FadeOut(gameObject.scene.name);   // restart the level
				break;
		}
	}

	// this is a callback method which is called whenever a Cancel button in the dialog is pressed
	public void CancelAction()
	{
		status = eWorldStatus.WaitingInput;
	}


	// --------- Rotation callbacks -------------
	// this method is a callback for wsm.rotateToSelected method
	// it just sets the corresponding flag
	public void sphereZeroRotated()
	{
		sphereToZero = true;
		if (wsm.cloudsFading()) // fade the clouds if needed
		{
			//Debug.Log("fading clouds");
			wsm.fadeCloudsDown();
		}
	}

	// -------- Camera callbacks -------------
	// this method is just a callback for wcc.pMoveCamera
	// it just sets the corresponding flag
	public void cameraMovedDown()
	{
		cameraMoved = true;
		selectMode = false; // and set camera mode mode to view mode
	}

	// this method is just a callback for wcc.pMoveCamera
	// it just sets the corresponding flag
	public void cameraMovedUp()
	{
		cameraMoved = true;
		selectMode = true; // and set camera mode mode to select mode
	}

	// --------- Selector callbacks -------------
	// this method is a callback called after satellite has flashed (run from switchToGallery)
	// it then starts the gallery scene
	/*
    public void satelliteFlashed()
    {
        status = eWorldStatus.FadeFromWorld;
        ss.stopRotation();
		//FaderCanvas.SetActive (true);
        Fader.SetColor(Color.black);
        Fader.FadeOut(gameObject);
        // do nothing, because a gallery scene is going to be loaded
    }
	*/

	// this method is a callback called after selector has flashed
	public void selectorFlashed()
	{
		// do nothing, because a level or a gallery scene is going to be loaded
	}

	// this method is a callback called after a hint is removed
	public void HintRemoved()
	{
		switch (status)
		{
			/*
			case eWorldStatus.FirstWelcomeHint:
				// display second welcome message
				status = eWorldStatus.FirstWelcomeHint2;
				//Debug.Log("displaying hint 2");
				focusWorld(true);
				HintSystemScript.instance.DisplayHint(HintSystemScript.HintType.FirstTimeWelcome2, obj: wsm.activeSelectorObject());
				break;
				*/
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
			case eWorldStatus.GameFinishedHint:
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
				AppData.instance[AppData.Storage.FirstTimeFinished] = false;
				status = eWorldStatus.Init;
				break;
			default:
				wsm.enableRotation();
				status = eWorldStatus.WaitingInput;
				break;
		}
	}

	// this method is a callback called after an arrow is tapped and a hint is removed
	public void HintArrowRemoved()
	{
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
	}

	// -------- LevelDescriptionScript callback -------
	public void LevelDescriptionClosed()
	{
		wsm.enableRotation();
		status = eWorldStatus.WaitingInput;
	}

	// ======== Hint system handling ==========
	void ProcessHints()
	{
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
                    /*
				case HintSystemScript.Type.LevelNotYetPlayable:
					status = eWorldStatus.HintActive;
					wsm.disableRotation();
					HintSystemScript.instance.DisplayHint(HintSystemScript.Type.LevelNotYetPlayable);
					break;
					*/
				default:
                    //Debug.Log("Displaying hint " + hint.type.ToString());
					status = eWorldStatus.HintActive;
					wsm.disableRotation();
					HintSystemScript.instance.DisplayHint(hint.type);
					break;
			}
		}
	}

	// =============== Auxillary coroutines ===============
	// this is an auxillary method
	// it waits when both sphere-to-aero rotation and camera movement are finished
	// actually, it is a callback after the focusWorld action is finished
	IEnumerator waitForFocus(bool keepStatus)
	{
		while (!(sphereToZero && cameraMoved))
		{
			yield return new WaitForFixedUpdate();
		}
		if (!keepStatus)
		{
			status = eWorldStatus.WaitingInput;
		}
	}

	// this is an auxillary method
	// it waits when camera movement is finished
	IEnumerator waitForZoom(bool keepStatus)
	{
		while (!cameraMoved)
		{
			yield return new WaitForFixedUpdate();
		}
		if (!keepStatus)
		{
			status = eWorldStatus.WaitingInput;
		}
	}

	// ========== Commands ===========
	// this method focuses camera on a elected selector
	void focusWorld(bool keepStatus = false)
	{
		sphereToZero = false;
		cameraMoved = false;
		wsm.rotateToSelected();
		wcc.pMoveCamera(true);
		StartCoroutine(waitForFocus(keepStatus));
	}

	// this method just rotates the world sphere when the player slides his finger on screen 
	void rotateWorld()
	{
		float cameraDistance = Camera.main.transform.position.z;
		Vector3 delta = new Vector3();
		delta = puzzleInput.moveDelta();
		delta.z = delta.x;
		delta.x = delta.y * cameraDistance * worldRotateFactor;
		delta.y = -delta.z * cameraDistance * worldRotateFactor;
		delta.z = 0;
		//Vector3 delta = new Vector3(-Input.GetTouch(0).deltaPosition.y * cameraDistance / 100, Input.GetTouch(0).deltaPosition.x * cameraDistance / 100, 0f);
		wsm.rotateByAngle(delta);
	}

	// this method rotates the world sphere around the z-axis when the player rotates its two-finger touch
	void rotateWorldByZ()
	{
		wsm.rotateZByAngle(puzzleInput.angleDelta());
	}

	// this method just stops world and camera rotation
	void stopRotation()
	{
		// this method stops the rotation of both the world sphere and the gallery satellite
		wsm.stopRotation();
		ss.stopRotation();
	}

	// this method zooms the camera in and out
	void zoomCamera(bool keepStatus = false)
	{
		// if the world is in select mode (selectMode==true), the camera should be moved down (up==false)
		// if the world is in view mode (selectMode==view), the camera should be moved up (up==true)
		cameraMoved = false;
		wcc.pMoveCamera(!selectMode);
		StartCoroutine(waitForZoom(keepStatus));
	}

	/*
    // this method forces sattelite flashing
    void switchToGallery()
    {
        status = eWorldStatus.SelectorFlash;
        wsm.rotateToSelected();
        ss.flashSelector();
    }
	*/

	// this method runs a puzzle using the level id of the active selector
	void runPuzzle()
	{
		status = eWorldStatus.FadeFromWorld;
		// set current level id
		AppData.instance[AppData.Storage.SelectedLevel] = wsm.getSelectorLevel(wsm.iActiveSelector());
		wsm.rotateToSelected();
		wsm.flashActiveSelector();
		//mf.FadeOut();
		//FaderCanvas.SetActive (true);
		Fader.SetColor(Color.white);
		Fader.FadeOut(LevelScene);
		// do nothing, because a level scene is going to be loaded
	}

	// this method runs the gallery using the level id of the active selector
	void runGallery()
	{
		//Debug.Log("Running gallery");
		status = eWorldStatus.FadeFromWorld;
		// save current level id
		//PlayerStat.instance.GalleryLevel = wsm.getSelectorLevel(wsm.iActiveSelector());
		//PlayerStat.instance.saveCurrentLevel();
		wsm.rotateToSelected();
		wsm.flashActiveSelector();
		//mf.FadeOut();
		//FaderCanvas.SetActive (true);
		Fader.SetColor(Color.white);
		Fader.FadeOut(GalleryScene);
		// do nothing, because a level scene is going to be loaded
	}

	void tuneLight()
	{
		switch (puzzleInput.checkInput())
		{
			case PuzzleInput.inputStatus.inputSinglePress:
				WorldLight.GetComponent<WorldLightSettings>().getLight(out colorTuning, out intensityTuning);
				break;
			case PuzzleInput.inputStatus.inputSingleMove:
				Vector2 pos = puzzleInput.touchPoint();
				Vector2 delta = puzzleInput.moveDelta();
				float x = (float)(Screen.width);
				float y = (float)(Screen.height);
				//Debug.Log ("delta=" + delta.ToString () + ", pos=" + pos.ToString () + ", x=" + x.ToString () + ", y=" + y.ToString ());
				if (status == eWorldStatus.ColorTuning)
				{
					if (pos.x < x / 3)
					{
						colorTuning.r += delta.y / y;
						if (colorTuning.r < 0)
						{
							colorTuning.r = 0;
						}
						if (colorTuning.r > 1f)
						{
							colorTuning.r = 1f;
						}
					}
					else if (pos.x >= x / 3 && pos.x < 2 * x / 3)
					{
						colorTuning.g += delta.y / y;
						if (colorTuning.g < 0)
						{
							colorTuning.g = 0;
						}
						if (colorTuning.g > 1f)
						{
							colorTuning.g = 1f;
						}
					}
					else if (pos.x >= 2 * x / 3)
					{
						colorTuning.b += delta.y / y;
						if (colorTuning.b < 0)
						{
							colorTuning.b = 0;
						}
						if (colorTuning.b > 1f)
						{
							colorTuning.b = 1f;
						}
					}
					colorTuning.a = 1f;
				}
				else if (status == eWorldStatus.IntensityTuning)
				{
					intensityTuning += delta.y / y;
				}
				WorldLight.GetComponent<WorldLightSettings>().setLight(colorTuning, intensityTuning);
				Color32 c32 = (Color32)colorTuning;
				LightValueText.GetComponent<Text>().text = "#" + c32.r.ToString("X2") + c32.g.ToString("X2") + c32.b.ToString("X2") + c32.a.ToString("X2");
				LightIntensityText.GetComponent<Text>().text = intensityTuning.ToString();
				break;
		}
	}

	// main status processor
	void processStatus()
	{
		switch (status)
		{
			case eWorldStatus.ColorTuning:
			case eWorldStatus.IntensityTuning:
				tuneLight();
				break;
			case eWorldStatus.Init:
				stopRotation();
				/*
				if (!ProcessHints())
				{
				*/
					if (wsm.iActiveSelector() >= 0) // if there is an active selector in the world
					{
						status = eWorldStatus.WorldRotating;    // after initialization focus the world on the selected level button
						focusWorld(false);
					}
					else
					{
						status = eWorldStatus.WaitingInput;     // no, just go for player's input
					}
				/*
				}
				*/
				break;
			case eWorldStatus.WaitingInput:             // waiting for player's input
                if (GameGUIScript.instance.IsPointerInGUI())    // do not process touches in the GUI area
                    break;
				switch (puzzleInput.checkInput())       // any mode
				{
					case PuzzleInput.inputStatus.inputSinglePress:
						stopRotation();
						status = eWorldStatus.UserTap;
						break;
					case PuzzleInput.inputStatus.inputSingleMove:
						stopRotation();
						rotateWorld();
						status = eWorldStatus.WaitingInput;
						break;
					case PuzzleInput.inputStatus.inputDoubleMove:
						stopRotation();
						wcc.manualZoom(puzzleInput.moveDelta());
						rotateWorldByZ();
						status = eWorldStatus.WaitingInput;
						break;
					case PuzzleInput.inputStatus.inputNone:
						break;
					default:
						stopRotation();
						break;
				}
				break;
			case eWorldStatus.UserTap:
				stopRotation();                     // the world rotation should not be started while the player taps the screen
				switch (puzzleInput.checkInput())
				{
					case PuzzleInput.inputStatus.inputSingleRelease:
						RaycastHit hit = new RaycastHit();
						Ray r = Camera.main.ScreenPointToRay(puzzleInput.touchPoint());
						if (Physics.Raycast(r, out hit))
						{
							GameObject o = hit.transform.gameObject;
							if (o == GallerySatellite)      // satellite has been tapped while in level selection mode
							{
								runGallery();
								break;
							}
							//int activeSelector = -1;
							if (wsm.getHitSelector(o, out activeSelector))
							{
								bool Playable = false;
								bool Complete = false;
								wsm.getSelectorStatus(activeSelector, out Playable, out Complete);
								if (Playable)
								{
									wsm.setSelectedSelector(activeSelector);    // activate the tapped selector
								}
								if (selectMode)
								{
									if (Complete)
									{
										status = eWorldStatus.DescriptionActive;
										wsm.disableRotation();
										lds.ShowDescription(wsm.getSelectorLevel(wsm.iActiveSelector()));
									}
									else
									if (Playable)
									{
										runPuzzle();
									}
									else
									{
										//status = eWorldStatus.HintActive;
										HintSystemScript.instance.putNextHint(HintSystemScript.Type.LevelNotYetPlayable, HintSystemScript.Environment.World);
										//Debug.Log("Hint for not playable level is placed");
										status = eWorldStatus.WaitingInput;
									}
									break;
								}
								else
								{
									focusWorld(false);
								}
							}
							if (o == gameObject)
							{
								zoomCamera();
								break;
							}
						}
						status = eWorldStatus.WaitingInput;
						break;
					case PuzzleInput.inputStatus.inputSingleMove:
						rotateWorld();
						status = eWorldStatus.WaitingInput;
						break;
					case PuzzleInput.inputStatus.inputNone:
						break;
					default:
						status = eWorldStatus.WaitingInput;
						break;
				}
				break;
		}
	}

	// Update is called once per frame
	void Update()
	{
		ProcessHints();
		processStatus();
	}

}
