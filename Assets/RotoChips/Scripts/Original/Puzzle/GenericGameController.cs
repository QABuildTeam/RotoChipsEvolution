using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using RotoChips.Generic;
using RotoChips.UI;
using RotoChips.Data;

public class GenericGameController : MonoBehaviour {

    public enum PuzzleStatus
    {
        None,                   // do nothing; neutral status
        PreInit,                // some tasks for initialization
        WaitingPreInit,         // waiting for PreInit completion
        Init,                   // puzzle is initialized; do nothing but await for possible puzzleStart status
        Start,                  // do immediate action: shuffle the puzzle
        WaitingInput,           // interruptible process: wait for any user input
        FinishFlash,            // uninterruptible process
        Finished,               // state, requires immediate action
        HintProcessing,         // a hint is being displayed
        PostHintDequeuing,      // dequeue hints from the hint queue (if any) after the puzzle is assembled
        // button movements
        ButtonBeingPressed,     // interruptible process
        ButtonPressed,          // state
        ButtonBeingUnpressed,   // interruptible process
        ButtonNeutral,          // state
        ButtonBeingReleased,    // uninterruptible process
        ButtonReleased,         // state
        ButtonBackToNeutral,    // uninterruptible process
        ButtonBeingRotated,     // uninterruptible process
        ButtonRotated,          // state
        ButtonSet,              // state after neutral while autoMoving
        ButtonAutoStep,         // state autostep finished
        // dialog mode statuses
        ShowSource,
        ShowSourceFinished,
        BackLevel,
        BackLevelFinished,
        AutoStep,
        AskForRestart,
        AskForRestartFinished,
        FullAutoComplete
    };
    PuzzleStatus status;      // finite automaton status

	public enum RotationReason		// a reason for a tile quartet rotation
	{
		None,						// no rotation has been performed
		Hand,						// a button has been pressed by a player
		Shuffle,					// a quartet has been rotated during the initial shuffing sequence
		Auto,						// a quartet has been shuffled during an autostep sequence (a player pressed AutoStep button)
		Support						// a quartet has been rotated during the finishing tutorial support sequence
	};

	RotationReason rotationReason;

    TouchInput puzzleInput;
    CameraController cameraController;
    PuzzleModel puzzleModel;
    //WhiteCurtainFader fader;
    GameObject SourceImageCanvas;   // a reference to the game object which shows the source image
    GameObject ZoomCanvas;    		// a reference to the game object which shows the final (victorial) image
	GameObject ZoomButtonCanvas;
    GameObject Dialog;              // a reference to a Dialog game object

    //VibeSoundScript vss;
	GameObject FanfareAudioObject;
	GameObject AmbienceAudioObject;
    //LevelMusic lms;
    //MusicFader mf;

    PuzzleModel.AutoStepParams asp;
    //AutoStepSolutions aso;
    bool autoMove;

    public string PreviousScene;    // the name of the previous level
    public string WinnerScene;      // the name of the winner screen
	public float fanfareDelay;
	public float ambientDelay;

    // Use this for initialization
    void Start()
    {
        rotationReason = RotationReason.None;
        status = PuzzleStatus.None;
        puzzleInput = gameObject.GetComponent<TouchInput>();
        puzzleModel = gameObject.GetComponent<PuzzleModel>();
        cameraController = gameObject.GetComponent<CameraController>();
        //fader = GameObject.Find("LevelTransition").GetComponent<WhiteCurtainFader>();
        //vss = GameObject.Find("VibeAudioObject").GetComponent<VibeSoundScript>();
        FanfareAudioObject = GameObject.Find("FanfareAudioObject");
        AmbienceAudioObject = GameObject.Find("AmbienceAudioObject");
        //lms = gameObject.GetComponent<LevelMusic>();
        //mf = gameObject.GetComponent<MusicFader>();

        SourceImageCanvas = GameObject.Find("/SourceImageCanvas");  // SourceImageCanvas sould be active to be Found here
        ZoomCanvas = GameObject.Find("/ZoomCanvas");    // ZoomCanvas sould be active to be Found here
        ZoomButtonCanvas = GameObject.Find("/ZoomButtonCanvas");
        Dialog = GameObject.Find("/DialogOkCancel");                // Dialog should be active to be Found here

        ZoomCanvas.SetActive(false);                                // now set the ZoomCanvas inactive (it should only be set active when the player wins)
        ZoomButtonCanvas.SetActive(false);
        Dialog.SetActive(false);                                    // now set the Dialog inactive because we do not need it now
        status = PuzzleStatus.PreInit;                  // initialize the puzzl

        // setup the GUI: hide it if the tutorial is not complete and reveal otherwise
        //bool puzzleFirstTime = GameManager.instance.processGameEvent(GameManager.GameEvents.PuzzleStarted);
        //GameGUIScript.instance.setupLevelGUI(!puzzleFirstTime, true, !puzzleFirstTime, !puzzleFirstTime, true);
        //HintSystemScript.instance.SetListener(gameObject);
        //GameManager.instance.PuzzleGameObject = gameObject;
    }

    // Update is called once per frame
    void Update () {
		ProcessHints();
        ProcessStatus();
        if (scoreUpdated)
        {
            SetScore();
        }
	}

    // == Actions for buttons movement ==
    // -- Callbacks ---
    public void buttonSlided()
    // this is a callback for PuzzleButtonScript message with the same name
    // it is called whenever a button has finished its vertical movement in whatever direction
    {
        switch (status)
        {
            case PuzzleStatus.ButtonBeingReleased:
                //Debug.Log("Button released");
                status = PuzzleStatus.ButtonReleased;
                break;
            case PuzzleStatus.ButtonBackToNeutral:
                //Debug.Log("Button neutral");
                status = PuzzleStatus.ButtonNeutral;
                break;
        }
    }

    public void buttonRotated()
    // this is a callback for PuzzleButtonScript message with the same name
    // it is called whenever a button has finished its rotation
    {
        switch (status)
        {
            case PuzzleStatus.ButtonBeingRotated:
                //Debug.Log("Button rotated");
                status = PuzzleStatus.ButtonRotated;
                if (rotationReason != RotationReason.Shuffle)
                {
                    //GameManager.instance.processGameEvent(GameManager.GameEvents.PuzzleQuartetRotated);
                }
                if (rotationReason == RotationReason.Hand)
                {
                    // only reset rotationReason if the button has been pressed by hand
                    rotationReason = RotationReason.None;
                }
                break;
        }
    }

    public void buttonPressed()
    // this is a callback for PuzzleModel messager with the same name
    // it is called whenever s button is firmly pressed
    {
        switch (status)
        {
            case PuzzleStatus.ButtonBeingPressed:
                //Debug.Log("Button pressed");
                status = PuzzleStatus.ButtonPressed;
                break;
        }
    }

    public void buttonUnpressed()
    // this is a callback for PuzzleModel messager with the same name
    // it is called whenever s button is returned from a pressed position to the neutral position
    {
        switch (status)
        {
            case PuzzleStatus.ButtonBeingUnpressed:
                //Debug.Log("Button unpressed");
                status = PuzzleStatus.ButtonNeutral;
                break;
        }
    }

    // -- Button actions --
    // this method starts the process of pressing a button (if any hit)
    void PressButton(int bY, int bX)
    {
        puzzleModel.stopFlashingTiles();
        puzzleModel.detachTilesFromButton();    // detach tiles from a current active button
        // if bY==-1 and bX==-1 then check for a button pressed by player's finger
        // otherwise press the button with the (bY,bX) coordinates
        if ((bY != -1 && bX != -1) || puzzleModel.getHitButton(puzzleInput.TouchPoint, out bY, out bX))
        {
            //Debug.Log("Press button (" + bY.ToString() + "," + bX.ToString() + ")");
            if (puzzleModel.attachTilesToButton(bY, bX))
            {
                status = PuzzleStatus.ButtonBeingPressed;
                puzzleModel.pressButton();
            }
        }
    }

    // this is a method which releases a normally pressed button
    void ReleaseButton()
    {
        status = PuzzleStatus.ButtonBeingReleased;
        puzzleModel.releaseButton();
    }

    // this method rotates a normally released button by 90 degrees clockwise
    void RotateButton()
    {
        status = PuzzleStatus.ButtonBeingRotated;
        puzzleModel.rotateButton();
    }

    // this method returns a normally rotated button to a neutral position
    void BackToNeutral()
    {
        status = PuzzleStatus.ButtonBackToNeutral;
        puzzleModel.backToNeutral();
    }

	// == GUI actions callbacks ==
	// this is a callback method which is called when a `BackLevel' GUI button is pressed
	public void BackLevel()
	{
		//Debug.Log("BackLevel called with status " + PuzzleStatus.ToString());
		switch (status)
		{
			case PuzzleStatus.WaitingInput:
				status = PuzzleStatus.BackLevel;
				break;
			case PuzzleStatus.Finished:
				status = PuzzleStatus.BackLevelFinished;
				break;
			default:
				return;
		}
        /*
		if (GameManager.instance.processGameEvent(GameManager.GameEvents.PuzzleButtonBackLevelPressed))
		{
			status = PuzzleStatus.WaitingInput;
		}
		else
		{
			Dialog.GetComponent<DialogOkCancelScript>().Activate(LocalizationManager.instance.GetLocalizedValue("BACK TO LEVEL SELECTION?"));
		}
        */
	}

	// this is a callback method which is called when a `ShowSource' GUI button is pressed
	public void ShowSource()
	{
        //PuzzleStatus prevStatus = status;
		//Debug.Log("ShowSource called with status " + PuzzleStatus.ToString());
		switch (status)
		{
			case PuzzleStatus.WaitingInput:
				status = PuzzleStatus.ShowSource;
				break;
			case PuzzleStatus.Finished:
				// do not change the status, just show the source image
				break;
			default:
				return;
		}
        /*
		if (GameManager.instance.processGameEvent(GameManager.GameEvents.PuzzleButtonShowSourcePressed))
		{
			status = prevStatus;
		}
		else
		{
			SourceImageCanvas.GetComponent<SourceImageFader>().ShowSourceImage(LocalizationManager.instance.GetLocalizedValue("TAP TO CONTINUE"));
		}
        */
	}

	// this is a callback method which is called when an `AskForRestart' GUI button is pressed
	public void AskForRestart()
	{
        //PuzzleStatus prevStatus = status;
		//Debug.Log("AskForRestart called with status " + PuzzleStatus.ToString());
		switch (status)
		{
			case PuzzleStatus.WaitingInput:
				status = PuzzleStatus.AskForRestart;
				break;
			case PuzzleStatus.Finished:
				status = PuzzleStatus.AskForRestartFinished;
				break;
			default:
				return;
		}
        /*
		if (GameManager.instance.processGameEvent(GameManager.GameEvents.PuzzleButtonAskForRestartPressed))
		{
            status = prevStatus;
		}
		else
		{
			Dialog.GetComponent<DialogOkCancelScript>().Activate(LocalizationManager.instance.GetLocalizedValue("RESTART THE LEVEL?"));
		}
        */
	}

	// this is a callback method which is called when an `AutoStep' GUI button is pressed
	public void AutoStep()
	{
		//Debug.Log("AutoStep called with status " + PuzzleStatus.ToString());
		switch (status)
		{
			case PuzzleStatus.WaitingInput:
                /*
				if (!GameManager.instance.processGameEvent(GameManager.GameEvents.PuzzleButtonAutoStepPressed))
				{
					if (puzzleModel.getAutoStepParams(out asp))
					{
						status = PuzzleStatus.AutoStep;
						puzzleModel.flashNextTile(asp.id);
						Dialog.GetComponent<DialogOkCancelScript>().Activate(LocalizationManager.instance.GetLocalizedValue("MOVE THE TILE TO ITS PLACE?"));
					}
				}
                */
				break;
		}
	}

	// this is a callback method which is called whenever a 'pointsScore' GUI area is tapped
	public void PointsTap()
	{
		switch (status)
		{
			case PuzzleStatus.WaitingInput:
            case PuzzleStatus.Finished:
				//GameManager.instance.processGameEvent(GameManager.GameEvents.PuzzlePointScoreTapped);
				break;
		}
	}

	// this is a callback method which is called whenever a 'coinsBalance' GUI area is tapped
	public void CoinsTap()
	{
		switch (status)
		{
			case PuzzleStatus.WaitingInput:
            case PuzzleStatus.Finished:
				//GameManager.instance.processGameEvent(GameManager.GameEvents.PuzzleCoinsScoreTapped);
				break;
		}
	}

    // -- Dialog callbacks --
    // this is a callback method which is called whenever an OK button in the dialog is pressed
    public void OKAction()
    {
        switch (status)
        {
		case PuzzleStatus.BackLevel:
		case PuzzleStatus.BackLevelFinished:
                // fade out the background music
                //Debug.Log("Trying to fade music out...");
				//mf.FadeOut ();
                // go back to the level selection scene
                //fader.FadeOut(PreviousScene);
                break;

		case PuzzleStatus.AutoStep:
                // autostep confirmed
				puzzleModel.stopFlashingTiles ();
                /*
                if (Purchases.PurchaseAutoStep(asp))
                {
                    StartCoroutine(PerformAutoStep());
                }
                else
                {
                    status = PuzzleStatus.ButtonNeutral;
                }
                */
                break;

            case PuzzleStatus.AskForRestart:
            case PuzzleStatus.AskForRestartFinished:
                // restart the puzzle
                RestartLevel();
                break;
        }
    }

    // this is a callback method which is called whenever a Cancel button in the dialog is pressed
    public void CancelAction()
    {
        puzzleModel.stopFlashingTiles();
        switch (status)
        {
            case PuzzleStatus.BackLevel:
            case PuzzleStatus.AutoStep:
            case PuzzleStatus.AskForRestart:
                status = PuzzleStatus.WaitingInput;
                break;
            case PuzzleStatus.BackLevelFinished:
            case PuzzleStatus.AskForRestartFinished:
                status = PuzzleStatus.Finished;
                break;
        }
    }

    // == External messages callbacks ==
    // this is a callback method which is called when the source image is closed
    public void SourceImageClosed()
    {
        switch (status)
        {
            case PuzzleStatus.Init:
                SetScore();
                status = XltRestoreStatus(puzzleModel.restoreState(false));
                break;
            case PuzzleStatus.ShowSourceFinished:
                status = PuzzleStatus.Finished;
                break;
            case PuzzleStatus.ShowSource:
                status = PuzzleStatus.WaitingInput;
                break;
        }
    }

    // a callback method which is called when the final image is closed
    //public void FinalImageClosed()
	public void PainterTapped()
    {
        puzzleModel.getToNextLevel();   // promote to the next level
        /*
        mf.FadeOut();
		FanfareAudioObject.GetComponent<MusicFader> ().FadeOut ();
		AmbienceAudioObject.GetComponent<MusicFader> ().FadeOut ();
        fader.FadeOut(WinnerScene);
        */
    }

	// empty callback
	public void ScalerFinished() {
	}

    // this is a callback method called whenever a flashing tile has stopped flashing
    // it is only really used when the puzzle is assembled
    public void flashStopped()
    {
        switch (status)
        {
            case PuzzleStatus.PostHintDequeuing:
                status = PuzzleStatus.FinishFlash;
                break;
        }
    }

    // == Internal methods ==
    // this method translates puzzle restoration status into finite automaton status
    PuzzleStatus XltRestoreStatus(PuzzleModel.restoreStatus aStatus)
    {
        switch (aStatus)
        {
            case PuzzleModel.restoreStatus.restoreFailed:
                return PuzzleStatus.Start;
            case PuzzleModel.restoreStatus.restoreComplete:
                return PuzzleStatus.Finished;
        }
        return PuzzleStatus.WaitingInput;
    }

    // this method translates puzzle restoration status into SourceImageCanvas messages
    string XltRestoreStatusToStr(PuzzleModel.restoreStatus aStatus)
    {
        /*
        switch (aStatus)
        {
            case PuzzleModel.restoreStatus.restoreFailed:
                return LocalizationManager.instance.GetLocalizedValue("TAP TO START");
            case PuzzleModel.restoreStatus.restoreComplete:
                return LocalizationManager.instance.GetLocalizedValue("TAP TO VIEW COMPLETE PUZZLE");
        }
        return LocalizationManager.instance.GetLocalizedValue("TAP TO CONTINUE");
        */
        return string.Empty;
    }
    
    // this method restarts the puzzle
    void RestartLevel()
    {
        puzzleModel.resetPuzzle();                  // reset puzzle state
        puzzleModel.restoreState(false);            // now restore the puzzle from it
        status = PuzzleStatus.Start;    // force puzzle shuffling
		rotationReason = RotationReason.None;
    }

    // this method shuffles the puzzle
    IEnumerator ShuffleTileTable(string shuffleString = "")
    {
		rotationReason = RotationReason.Shuffle;
        autoMove = true;
        puzzleModel.setFastMove(true);
		if (shuffleString == "")
		{
			// random mode shuffle
			// do not allow the assembled state after the puzzle initialization
			while (puzzleModel.isPuzzleAssembled())
			{
				int rCount = (int)((UnityEngine.Random.value + 0.7f) * puzzleModel.puzzleWidth() * puzzleModel.puzzleHeight());
				for (int c = 0; c < rCount; c++)
				{
					int x = (int)(UnityEngine.Random.value * (puzzleModel.puzzleWidth() - 1));
					int y = (int)(UnityEngine.Random.value * (puzzleModel.puzzleHeight() - 1));
					PressButton(y, x);
					do
					{
						yield return new WaitForFixedUpdate();
					} while (status != PuzzleStatus.ButtonPressed);
					ReleaseButton();
					do
					{
						yield return new WaitForFixedUpdate();
					} while (status != PuzzleStatus.ButtonSet);
				}
			}
		}
		else
		{
			// forced mode shuffle
			char[] delimiters = { '.' };
			string[] parts = shuffleString.Split(delimiters);
			int partsCount = parts.Length;
            //Debug.Log("Initial shuffle string: " + partsCount.ToString() + " parts");
			for (int i = 0; i < partsCount; i += 2)
			{
				int y = int.Parse(parts[i]);
				int x = int.Parse(parts[i + 1]);
				PressButton(y, x);
				do
				{
					yield return new WaitForFixedUpdate();
				} while (status != PuzzleStatus.ButtonPressed);
				ReleaseButton();
				do
				{
					yield return new WaitForFixedUpdate();
				} while (status != PuzzleStatus.ButtonSet);
			}
		}
        puzzleModel.saveState();
        puzzleModel.setFastMove(false);
        autoMove = false;
        // tight vibe sound
        //vss.playSound();
        // now processStatus() should handle an isPuzzleAssembled() situation if there is one
        autoMove = false;
        status = PuzzleStatus.ButtonNeutral;
		rotationReason = RotationReason.None;
		//GameManager.instance.processGameEvent(GameManager.GameEvents.PuzzleShuffled);
    }

    // this method moves one [next] tile to its 'place' automatically
    IEnumerator PerformAutoStep()
    {
		byte[] solution = AutoStepSolutions.GetSolution(puzzleModel.puzzleHeight(), puzzleModel.puzzleWidth(), asp.id, asp.y, asp.x, asp.angle);
        if (solution != null)
        {
			rotationReason = RotationReason.Auto;
            autoMove = true;
            puzzleModel.setFastMove(true);
            puzzleModel.setAutocompleteUsed();
            for (int i = 0; i < solution.Length; i++)
            {
                int y = (solution[i] >> 4) & 0xf;
                int x = solution[i] & 0xf;
                PressButton(y, x);
                do
                {
                    yield return new WaitForFixedUpdate();
                } while (status != PuzzleStatus.ButtonPressed);
                ReleaseButton();
                do
                {
                    yield return new WaitForFixedUpdate();
                } while (status != PuzzleStatus.ButtonSet);
            }
            puzzleModel.saveState();
            puzzleModel.setFastMove(false);
            // tight vibe sound
            //Debug.Log("Playing vibe sound");
            //vss.playSound();
            // now processStatus() should handle an isPuzzleAssembled() situation if there is one
            autoMove = false;
            status = PuzzleStatus.ButtonNeutral;
			rotationReason = RotationReason.None;
			//GameManager.instance.processGameEvent(GameManager.GameEvents.PuzzleAutoStepUsed);
        }
    }

    // this method solves the rest of the puzzle
    // only used in the 1st and 2nd level of the very first run (as a bonus for a tutorial)
    public IEnumerator AutoSolvePuzzle()
    {
        while (!puzzleModel.isPuzzleAssembled())
        {
            //PuzzleModel.TilePosition lastPos = puzzleModel.lastAssembledTile();
            //Debug.Log("Assembling tile " + lastPos.ToString());
            if (puzzleModel.getAutoStepParams(out asp))
            {
                rotationReason = RotationReason.Auto;
                StartCoroutine(PerformAutoStep());
                while (rotationReason != RotationReason.None)
                {
                    yield return null;
                }
                //yield return new WaitForFixedUpdate();
            }
        }
    }

    // this is a flag to forcibly update the score
    private bool scoreUpdated;
    public void UpdateScore()
    {
        scoreUpdated = true;
    }

    void SetScore()
    {
        /*
        long points = puzzleModel.getScore();
        decimal coins = (decimal)AppData.instance[AppData.Storage.CurrentCoins];
        //Debug.Log("Running SetScore: points=" + points.ToString() + ", coins=" + coins.ToString());
        //GameGUIScript.instance.setPointScore(points);
        //GameGUIScript.instance.setCoinsBalance(coins);
        scoreUpdated = false;
        */
    }

    void PreInit()
    {
        //SourceImageCanvas.GetComponent<SourceImageFader>().ShowSourceImage(xltRestoreStatusToStr(puzzleModel.restoreState(false)));
        // restore the puzzle state and set the source image canvas text according to the restoration result
        SourceImageCanvas.GetComponent<SourceImageFader>().setInitialText(XltRestoreStatusToStr(puzzleModel.restoreState(false)));
        // alse set the score
        SetScore();
    }

	public string[] predefinedShuffle;

    void ProcessStatus()
    {
		switch (status)
		{
			case PuzzleStatus.None:   // do nothing
				break;
			case PuzzleStatus.PreInit:    // pre-initialization chores
				status = PuzzleStatus.WaitingPreInit;
				PreInit();
				status = PuzzleStatus.Init;
				break;
			case PuzzleStatus.Init:   // restore puzzle state during initialization
				break;
			case PuzzleStatus.Start:  // the puzzle has to be shuffled
				status = PuzzleStatus.None;
                /*
				if (GameManager.instance.processGameEvent(GameManager.GameEvents.PuzzleStarted))
				{
					StartCoroutine(ShuffleTileTable(predefinedShuffle[(int)(long)AppData.instance[AppData.Storage.SelectedLevel]]));
				}
				else
				{
					StartCoroutine(ShuffleTileTable());
				}
                */
				break;

			case PuzzleStatus.ButtonNeutral:  // a button with its attached tiles has returned to the neutral position
                //Debug.Log("Button returned to Neutral");
				puzzleModel.detachTilesFromButton();
                SetScore();
                puzzleModel.flashAssembledTiles();
				if (autoMove)   // special case
				{
					status = PuzzleStatus.ButtonSet;
				}
                else {
                    puzzleModel.saveState();
                    if (puzzleModel.isPuzzleAssembled()) // if puzzle has been assembled
                    {
                        status = PuzzleStatus.PostHintDequeuing;
                        DequeueHints();
                    }
                    else
                    {   // other
                        status = PuzzleStatus.WaitingInput;
                    }
                }
                break;

			case PuzzleStatus.WaitingInput:                   // waiting for player's input
                /*
                if (GameGUIScript.instance.IsPointerInGUI())        // do not process touches in the GUI area
                    break;
				switch (puzzleInput.checkInput())                   // check player's input if any
				{
					case TouchInput.inputStatus.inputSinglePress:  // a single tap detected
						PressButton(-1, -1);                        // start pressing button if applicable, do nothing otherwise
						break;

					case TouchInput.inputStatus.inputSingleMove:   // both of these input statuses allow for moving or scaling the puzzle
					case TouchInput.inputStatus.inputDoubleMove:
						//Debug.Log("Move camera");
						cameraController.KeepSoftBoundaries(puzzleInput.moveDelta());  // so perform moving/scaling
						status = PuzzleStatus.WaitingInput;
						break;

				}
                */
				break;

			case PuzzleStatus.ButtonPressed:
				if (autoMove)   // don't process the input while autoMoving
					break;
				switch (puzzleInput.CheckInput())
				{
					case TouchInput.InputStatus.SinglePress:
						PressButton(-1, -1);
						break;

					case TouchInput.InputStatus.SingleRelease:
						rotationReason = RotationReason.Hand;
						ReleaseButton();
						break;

					case TouchInput.InputStatus.SingleMove:   // both of these input statuses allow to move or scale the puzzle
                        cameraController.KeepSoftBoundaries(puzzleInput.MoveDelta);  // just move, do not unpress
                        break;
					case TouchInput.InputStatus.DoubleMove:   // scale the puzzle
						puzzleModel.unpressButton();
						cameraController.KeepSoftBoundaries(puzzleInput.MoveDelta);  // perform moving/scaling
						status = PuzzleStatus.ButtonNeutral; // and unpress the button
						break;

				}
				break;

			case PuzzleStatus.ButtonReleased:
				RotateButton();
				break;

			case PuzzleStatus.ButtonRotated:
				BackToNeutral();
				break;

		}
    }

    void DequeueHints()
    {
        /*
        if (HintSystemScript.instance.checkNextHint(HintSystemScript.Environment.Puzzle))
        {
            ProcessHints();
        }
        else
        {
            StartCoroutine(WaitForFinalFlashing());
        }
        */
    }

    IEnumerator WaitForFinalFlashing()
    {
        while (status != PuzzleStatus.FinishFlash)
        {
            yield return new WaitForFixedUpdate();
        }
        PuzzleFinished();
    }

    void PuzzleFinished(){
        //case puzzleStatus.puzzleFinished:
        //Debug.Log("Puzzle finished, flashing stopped");
        status = PuzzleStatus.Finished;
        puzzleModel.setComplete();
        // fade out the background music
        //mf.FadeOut();
        puzzleModel.setGalleryLevel();
        /*
        ZoomButtonCanvas.SetActive(true);
        ZoomCanvas.GetComponent<ZoomPainterTrigger>().SetText(LocalizationManager.instance.GetLocalizedValue("YOU WON!"));
        ZoomCanvas.SetActive(true);
        ZoomCanvas.GetComponent<ZoomPainterTrigger>().StartPainter();
        */
        FanfareAudioObject.GetComponent<AudioSource>().PlayDelayed(fanfareDelay);
        AmbienceAudioObject.GetComponent<AudioSource>().PlayDelayed(ambientDelay);
    }

    // ===== Hint system processing ====
    bool hintActive;    // special flag
    void ProcessHints()
    {
        // hints are only processed while no other action is performed
        // or the puzzle is already assembled
        // or the puzzle has just been finished (post-puzzle chores are performed)
        if (hintActive)
            return;
        if (!(
            status == PuzzleStatus.WaitingInput ||
            status == PuzzleStatus.Finished ||
            status == PuzzleStatus.PostHintDequeuing ||
            status == PuzzleStatus.FinishFlash))
        {
            return;
        }
        /*
        if (HintSystemScript.instance.checkNextHint(HintSystemScript.Environment.Puzzle))
        {
            HintSystemScript.QueuedHint hint = HintSystemScript.instance.getNextHint();
            //Debug.Log("Processing hints at status " + status.ToString());
            //Debug.Log("Processing hint " + hint.type.ToString());
            hintActive = true;
            switch (hint.type)
            {
                case HintSystemScript.Type.FirstTileButtonsHint:
                    HintSystemScript.instance.DisplayHint(hint.type, obj: puzzleModel.buttonAt(0, 0));
                    break;
                case HintSystemScript.Type.SecondTileButtonsHint:
                    HintSystemScript.instance.DisplayHint(hint.type, obj: puzzleModel.buttonAt(0, 1));
                    break;
                //case HintSystemScript.Type.ThirdTileInPlace:
                //case HintSystemScript.Type.TwoRowsInPlace:
                case HintSystemScript.Type.TwoRowsInPlace2:
                    // the hint TwoRowsInPlace2 triggers the autocempletion process
                    if (status == PuzzleStatus.WaitingInput)
                        status = PuzzleStatus.FullAutoComplete;
                    HintSystemScript.instance.DisplayHint(hint.type);
                    break;
                default:
                    HintSystemScript.instance.DisplayHint(hint.type);
                    break;

            }
            // the current status is only changed within the puzzle
            if (status == PuzzleStatus.WaitingInput)
            {
                status = PuzzleStatus.HintProcessing;
            }
        }
        */
    }

    public void HintRemoved()
    {
        hintActive = false;
        switch (status)
        {
            case PuzzleStatus.FullAutoComplete:
                StartCoroutine(AutoSolvePuzzle());
                break;
            case PuzzleStatus.PostHintDequeuing:
            case PuzzleStatus.FinishFlash:
                DequeueHints();
                break;
            default:
                if (status == PuzzleStatus.HintProcessing)
                {
                    status = PuzzleStatus.WaitingInput;
                }
                break;
        }
    }

	public void HintArrowRemoved()
	{
        hintActive = false;
        if (status == PuzzleStatus.HintProcessing)
        {
            status = PuzzleStatus.WaitingInput;
        }
	}

}
