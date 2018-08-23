using System;
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    bool forceFirstTime = false;

	public static GameManager instance;         // the global instance of a singleton
	public decimal FirstTimeCoinBonus = 15000M; // a player is awarded with this bonus only once - after the very first application start
	public long maximumPoints = 2000000000L;    // maximum value for points/coins
    public long firstTilePoints = 100L;          // bonus points for the first assembled tile
    public long secondTilePoints = 200L;         // bonus points for the second assembled tile
    public long thirdTilePoints = 300L;          // bonus points for the third assembled tile
    public long secondRowPoints = 600L;         // bonus points for the second row assembled in the second puzzle
    public long puzzleAssembledPoints = 1000L;  // bonus points for finishing a puzzle (no matter using auto steps or not)

    private GameObject puzzleModelObject;
    private PuzzleModel puzzleModel;
    private GenericGameController genericGameController;
    public GameObject PuzzleGameObject
    {
        get
        {
            return puzzleModelObject;
        }
        set
        {
            puzzleModelObject = value;
            if (puzzleModelObject != null)
            {
                puzzleModel = puzzleModelObject.GetComponent<PuzzleModel>();
                genericGameController = puzzleModelObject.GetComponent<GenericGameController>();
            }
            else
            {
                puzzleModel = null;
                genericGameController = null;
            }
        }
    }

	public int totalTilesCount()
	{
		int tilesCount = 0;
		foreach (LevelData.Descriptor ld in new LevelData.Enumerator())
		{
			tilesCount += ld.init.width * ld.init.height - 1;
		}
		return tilesCount;
	}

	// this method calculates the number of points by which to increase a level's local points
	// when new rows are assembled
	public int fullRowFactor;                       // a factor for a complete row id (to add to the score)
	public long calculateBonusPoints(int levelId, int prevGoodId, int currentGoodId)
	{
		LevelData.Descriptor ld = LevelData.instance[levelId];
		long addPoints = 0;
		// every completed line of the puzzle brings fullRowFactor * lineNumber (base 1) points (i. e. 100, 200, 300 etc.)
		for (int i = prevGoodId + 1; i <= currentGoodId; ++i)
		{
			int row = (i + 1) / ld.init.width;
			int edgeId = row * ld.init.width - 1; // last tile in a row
			if (i == edgeId)
			{
				addPoints += row * fullRowFactor;
			}
		}
		return addPoints;
	}

	public void increasePoints(long points)
	{
        //Debug.Log("IncreasePoints by " + points.ToString());
		long CurrentPoints = (long)AppData.instance[AppData.Storage.CurrentPoints];
		if (points > 0)
		{
			if (CurrentPoints + points < maximumPoints)
			{
				CurrentPoints += points;
			}
			else
			{
				CurrentPoints = maximumPoints;
			}
			AppData.instance[AppData.Storage.CurrentPoints] = CurrentPoints;
            if (genericGameController != null)
            {
                genericGameController.UpdateScore();
            }
		}
	}

	public void decreasePoints(long points)
	{
		long CurrentPoints = (long)AppData.instance[AppData.Storage.CurrentPoints];
		if (points > 0)
		{
			if (CurrentPoints - points >= 0)
			{
				CurrentPoints -= points;

			}
			else
			{
				CurrentPoints = 0;
			}
			AppData.instance[AppData.Storage.CurrentPoints] = CurrentPoints;
            if (genericGameController != null)
            {
                genericGameController.UpdateScore();
            }
		}
	}

	public void increaseCoins(decimal coins)
	{
		decimal CurrentCoins = (decimal)AppData.instance[AppData.Storage.CurrentCoins];
        if (coins > 0)
        {
            CurrentCoins += coins;
            AppData.instance[AppData.Storage.CurrentCoins] = CurrentCoins;
            if (genericGameController != null)
            {
                genericGameController.UpdateScore();
            }
        }
	}

	public bool decreaseCoins(decimal coins)
	{
        //Debug.Log("DecreaseCoins by " + coins.ToString());
		decimal CurrentCoins = (decimal)AppData.instance[AppData.Storage.CurrentCoins];
		if (coins > 0 && coins <= CurrentCoins)
		{
			CurrentCoins -= coins;
			AppData.instance[AppData.Storage.CurrentCoins] = CurrentCoins;
            if (genericGameController != null)
            {
                genericGameController.UpdateScore();
            }
			return true;
		}
		return false;
	}

	void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}
	}

	//public HintSystemScript.QueuedHint[] startHints;
	void Start()
	{
        // force first time
        // ------------------
        if (forceFirstTime)
        {
            AppData.instance[AppData.Storage.GameStarted] = false;
            for (int i = (int)AppData.Storage.GameStarted; i < (int)AppData.Storage.BonusCoinsAdded; i++)
            {
                AppData.instance[(AppData.Storage)i] = false;
            }
            for (int i = (int)GameEvents.GameHasStarted; i < (int)GameEvents.WorldCoinsScoreTapped; i++)
            {
                resetGameFlag((GameEvents)i);
            }
            //AppData.instance[AppData.Storage.CurrentPoints] = 0l;
            AppData.instance[AppData.Storage.TotalPoints] = 0L;
            AppData.instance[AppData.Storage.CurrentCoins] = 0M;
            // this is debug value
            FirstTimeCoinBonus = totalTilesCount() * Purchases.AutoStepPrice;
        }
		// ----------------
		if ((bool)AppData.instance[AppData.Storage.GameStarted] == false)
		{
			//PlayerPrefs.SetString("GameStarted", "yes");
			AppData.instance[AppData.Storage.GameStarted] = true;
			//PlayerPrefs.SetString("LastLevelFinished", "no");
			resetGame();
			//FirstStart = true;
			//Debug.Log("CurrentPoints=" + CurrentPoints.ToString());
			AppData.instance[AppData.Storage.FirstRound] = true;
			AppData.instance[AppData.Storage.FirstStart] = true;
        }
	}

	// This method resets the level status data
	// It is used when the game is restarted
	public void resetGame()
	{
		LevelData.instance.ResetLevels();
		AppData.instance[AppData.Storage.SelectedLevel] = 0L;
		AppData.instance[AppData.Storage.GalleryLevel] = 0L;
		AppData.instance[AppData.Storage.CurrentPoints] = 0L;
		VictoryMessages.instance.Clear();   // clear the bonus queue
	}

	// This method marks a level as complete
	// and reveals all other levels in the realm if this is the main level of the realm
	// It alse sets the next level as playable
	// and updates NextPlayable and NextComplete ids
	public void setLevelComplete(int levelId)
	{
		//Debug.Log("Set level " + levelId.ToString() + " complete:");
		LevelData.Descriptor ld = LevelData.instance[levelId];        // set the level completion flag
		if (ld.init.id != -1)                           // if this is a valid level id
		{
			bool firstTime = false;
			if (!ld.status.Complete)
			{
				firstTime = true;
				//Debug.Log("first time: true");
				VictoryMessages.instance.PostMessage(LocalizationManager.instance.GetLocalizedValue("YOU HAVE COMPLETED A LEVEL!"));    // the level is completed for the first time
                if (levelId == 0)
                {
                    VictoryMessages.instance.PostMessage(LocalizationManager.instance.GetLocalizedValue("GALLERY OPENED!"));
                    if (!(bool)AppData.instance[AppData.Storage.FirstGallery])
                    {
                        HintSystemScript.instance.putNextHint(HintSystemScript.Type.GalleryOpened, HintSystemScript.Environment.World);
                        AppData.instance[AppData.Storage.FirstGallery] = true;
                    }
                }
			}
			if (!firstTime)
			{
				// simply congratulate the player
				VictoryMessages.instance.PostMessage(LocalizationManager.instance.GetLocalizedValue("WELL DONE!"));
			}
			ld.status.Complete = true;
			LevelData.instance[levelId] = ld;

			// set the next level ids in the last level of the previous realm
			// now check the current realm
			int rId = ld.init.realmId;                      // realm id
															//Debug.Log("Realm id: " + rId.ToString());
			RealmData.Init ri = RealmData.instance[rId];
			bool isMain = (levelId == ri.mainLevelId);      // is this is the main level of its realm

			if (firstTime && isMain)                        // if the main level of this realm is completed for the first time
			{
				VictoryMessages.instance.PostMessage(LocalizationManager.instance.GetLocalizedValue("A REALM IS REVEALED!"));      // completion of a realm's main level reveals its sublevels
				int prId = ri.prevRealmId;
				//Debug.Log("Previous realm id: " + prId.ToString());
				if (prId != -1)                             // if there is a real realm
				{
					RealmData.Init pri = RealmData.instance[prId];
					int prlId = pri.members.GetUpperBound(0);
					//Debug.Log("Previous realm last level id: " + prlId.ToString());
					LevelData.Descriptor pld = LevelData.instance[pri.members[prlId]];  // then update the last level of the previous realm
					pld.status.NextCompleteId = levelId;    // set its next complete level id to this level id
					LevelData.instance[pld.init.id] = pld;
				}
			}
			// now update the levels in the realm
			bool realmComplete = true;                      // an auxillary flag
			int memberCount = ri.members.GetUpperBound(0) + 1;
			//Debug.Log("Realm has " + memberCount.ToString() + " in it");
			for (int i = 0; i < memberCount; i++)
			{
				//Debug.Log("Processing member " + i.ToString() + ": level id is " + ri.members[i].ToString());
				LevelData.Descriptor nld = LevelData.instance[ri.members[i]];
				if (isMain)
				{
					nld.status.Revealed = true;             // reveal all the levels of the realm if its main level is complete
				}
				if (nld.init.id == (levelId - 1))
				{
					nld.status.NextCompleteId = levelId;    // mark this level as next complete level for the previous level
				}
				if (nld.init.id == (levelId + 1))
				{
					//Debug.Log("Revealing level " + nld.init.id.ToString());
					if (firstTime && !nld.status.Playable)
					{
						VictoryMessages.instance.PostMessage(LocalizationManager.instance.GetLocalizedValue("A NEW LEVEL BECOMES PLAYABLE!"));
					}
					nld.status.Playable = true;             // make the next level playable
					ld.status.NextPlayableId = nld.init.id; // update the NextPlayable id of the current level
															//Debug.Log("New level is " + (nld.status.Playable ? "playable" : "not playable"));
															//Debug.Log("Next playable level is " + ld.status.NextPlayableId.ToString());
					if (nld.status.Complete)
					{
						ld.status.NextCompleteId = nld.init.id; // update the NextComplete id of the current level
					}
					LevelData.instance[ld.init.id] = ld;
				}
				if (!nld.status.Complete)
				{
					realmComplete = false;                  // the realm is not complete if it contains at least one incomplete level
				}
				LevelData.instance[nld.init.id] = nld;
				//Debug.Log("New level is " + (nld.status.Playable ? "playable" : "not playable"));
				//Debug.Log("Next playable level is " + ld.status.NextPlayableId.ToString());
			}

			// now update the main level of the next realm
			if (realmComplete)
			{
				if (firstTime)
				{
					VictoryMessages.instance.PostMessage(LocalizationManager.instance.GetLocalizedValue("YOU HAVE COMPLETED A REALM!"));
				}
				rId = ri.nextRealmId;                       // the next realm id
															// if the realm complete, set the main level of the next realm revealed an playable
				if (rId != -1)
				{
					ri = RealmData.instance[rId];           // the next realm descriptor
					int mainLevel = ri.mainLevelId;         // an id of the main level of the next realm
					if (mainLevel != -1)
					{
						if (firstTime)
						{
							VictoryMessages.instance.PostMessage(LocalizationManager.instance.GetLocalizedValue("AN ENTRANCE TO A NEW REALM IS OPENED!"));
						}
						LevelData.Descriptor mld = LevelData.instance[mainLevel];   // the main level descriptor
						mld.status.Revealed = true;
						mld.status.Playable = true;
						LevelData.instance[mld.init.id] = mld;
						if (ld.status.NextPlayableId == -1)
						{
							ld.status.NextPlayableId = mainLevel;
							LevelData.instance[ld.init.id] = ld;
						}
					}
				}
				else
				{
					if (firstTime)
					{
						// the game is complete
						VictoryMessages.instance.PostMessage(LocalizationManager.instance.GetLocalizedValue("YOU HAVE COMPLETED THE GAME!"));
						HintSystemScript.instance.putNextHint(HintSystemScript.Type.GameFinishedCongratulation, HintSystemScript.Environment.World);
						AppData.instance[AppData.Storage.TotalPoints] = (long)AppData.instance[AppData.Storage.TotalPoints] + (long)AppData.instance[AppData.Storage.CurrentPoints];
						AppData.instance[AppData.Storage.GameFinished] = true;
						AppData.instance[AppData.Storage.FirstRound] = false;
					}
				}
			}
		}
	}

    public enum GameEvents
    {
        None,                                   // no event
        GameHasStarted,                         // the game has just been started
        WorldLoaded,                            // the world scene has just been loaded (at the end of Start)
        WelcomeMessagesShown,
        PuzzleStarted,                          // the puzzle has just been started and is waiting for shuffle
        PuzzleButtonBackLevelPressed,
        PuzzleButtonShowSourcePressed,
        PuzzleButtonAskForRestartPressed,
        PuzzleButtonAutoStepPressed,
        PuzzleAutoStepUsed,
        PuzzleShuffled,
        PuzzleQuartetRotated,
        PuzzleTileInPlace,
        PuzzleRowInPlace,
        PuzzleCompleted,
        PuzzleTutorialCompleted,
        FirstTileInPlace,
        SecondTileInPlace,
        ThirdTileInPlace,
        TwoRowsInPlace,
        AdShown,
        GameCompetionSceneShown,
        WorldButtonRestartGamePressed,
        WorldButtonShowFinalRollsPressed,
        PuzzlePointScoreTapped,
        PuzzleCoinsScoreTapped,
        WorldPointScoreTapped,
        WorldCoinsScoreTapped
    };

    // persistent game flags of corresponding game events
	void setGameFlag(GameEvents ge)
	{
		AppData.instance["GameEvents." + ge.ToString()] = "yes";
	}

	void resetGameFlag(GameEvents ge)
	{
		AppData.instance["GameEvents." + ge.ToString()] = "no";
	}

	bool getGameFlag(GameEvents ge) {
		return AppData.instance["GameEvents." + ge.ToString()] == "yes";
	}

	bool checkAndSetGameFlag(GameEvents ge)
	{
		bool flag = getGameFlag(ge);
		setGameFlag(ge);
		return flag;
	}

    // this method processes various game events and returns:
    // true if a special behaviour required (override)
    // false if default behaviour permitted
    public bool processGameEvent(GameEvents anEvent)
    {
        //Debug.Log("Processing game event " + anEvent.ToString());
        int SelectedLevel = (int)(long)AppData.instance[AppData.Storage.SelectedLevel];
        bool FirstRound = (bool)AppData.instance[AppData.Storage.FirstRound];
        switch (anEvent)
        {
            case GameEvents.GameHasStarted:
                break;
            case GameEvents.WorldLoaded:
                if (!checkAndSetGameFlag(anEvent))
                {
                    HintSystemScript.instance.putNextHint(HintSystemScript.Type.FirstTimeWelcome, HintSystemScript.Environment.World);
                    HintSystemScript.instance.putNextHint(HintSystemScript.Type.FirstTimeWelcome2, HintSystemScript.Environment.World);
                    return true;
                }
                break;
            case GameEvents.WelcomeMessagesShown:
                break;
            case GameEvents.PuzzleStarted:
                if (!getGameFlag(GameEvents.PuzzleTutorialCompleted))
                {
                    // if puzzle tutorial is not yet complete
                    // the shuffle the puzzle in a predefined way
                    return true;
                }
                /*else if (SelectedLevel == 1)
                {
                    return true;
                }*/
                break;
            case GameEvents.PuzzleShuffled:
                if (FirstRound)
                {
                    switch (SelectedLevel)
                    {
                        case 0:
                            HintSystemScript.instance.putNextHint(HintSystemScript.Type.PuzzleFirstShuffled, HintSystemScript.Environment.Puzzle);
                            HintSystemScript.instance.putNextHint(HintSystemScript.Type.FirstLevelChallenge, HintSystemScript.Environment.Puzzle);
                            HintSystemScript.instance.putNextHint(HintSystemScript.Type.FirstTileButtonsHint, HintSystemScript.Environment.Puzzle); ;
                            return true;
                        case 1:
                            HintSystemScript.instance.putNextHint(HintSystemScript.Type.SecondLevelChallenge, HintSystemScript.Environment.Puzzle);
                            return true;
                        case 2:
                            HintSystemScript.instance.putNextHint(HintSystemScript.Type.NoMoreBonuses, HintSystemScript.Environment.Puzzle);
                            return true;
                    }
                }
                break;
            case GameEvents.PuzzleCompleted:
            // PuzzleCompleted - the puzzle has been assembled using autocomplete feature
            case GameEvents.PuzzleQuartetRotated:
                // PuzzleQuartetRotated - any puzzle button has been pressed by the player
                // and the four of its neighbouring tiles have rotated clockwise
                /*
                if (getGameFlag(GameEvents.PuzzleShuffled) && !checkAndSetGameFlag(GameEvents.PuzzleQuartetRotated))
				{
					HintSystemScript.instance.putNextHint(HintSystemScript.Type.FirstPuzzleQuartetRotated, HintSystemScript.Environment.Puzzle);
					return true;
				}
				break;
			case GameEvents.PuzzleTileInPlace:
			*/
                return processPuzzleTileInPlace(FirstRound, SelectedLevel);
            case GameEvents.PuzzleButtonShowSourcePressed:
                if (!checkAndSetGameFlag(anEvent))
                {
                    HintSystemScript.instance.putNextHint(HintSystemScript.Type.ShowSourceButton, HintSystemScript.Environment.Puzzle);
                    return true;
                }
                break;
            case GameEvents.PuzzleButtonBackLevelPressed:
                if (!checkAndSetGameFlag(anEvent))
                {
                    HintSystemScript.instance.putNextHint(HintSystemScript.Type.BackLevelButton, HintSystemScript.Environment.Puzzle);
                    return true;
                }
                break;
            case GameEvents.PuzzleButtonAutoStepPressed:
                if (!checkAndSetGameFlag(anEvent))
                {
                    HintSystemScript.instance.putNextHint(HintSystemScript.Type.AutoStepButton, HintSystemScript.Environment.Puzzle);
                    return true;
                }
                break;
            case GameEvents.PuzzleButtonAskForRestartPressed:
                if (!checkAndSetGameFlag(anEvent))
                {
                    HintSystemScript.instance.putNextHint(HintSystemScript.Type.AskForRestartButton, HintSystemScript.Environment.Puzzle);
                    return true;
                }
                break;
            case GameEvents.PuzzleAutoStepUsed:
                break;
            case GameEvents.PuzzleCoinsScoreTapped:
                HintSystemScript.instance.putNextHint(HintSystemScript.Type.PuzzleCoinsScoreTapped, HintSystemScript.Environment.Puzzle);
                return true;
            case GameEvents.PuzzlePointScoreTapped:
                HintSystemScript.instance.putNextHint(HintSystemScript.Type.PuzzlePointScoreTapped, HintSystemScript.Environment.Puzzle);
                return true;
            case GameEvents.WorldCoinsScoreTapped:
                HintSystemScript.instance.putNextHint(HintSystemScript.Type.WorldCoinsScoreTapped, HintSystemScript.Environment.World);
                return true;
            case GameEvents.WorldPointScoreTapped:
                HintSystemScript.instance.putNextHint(HintSystemScript.Type.WorldPointScoreTapped, HintSystemScript.Environment.World);
                return true;
            case GameEvents.GameCompetionSceneShown:
                HintSystemScript.instance.putNextHint(HintSystemScript.Type.GameFinishedCongratulation, HintSystemScript.Environment.World);
                return true;
            case GameEvents.WorldButtonRestartGamePressed:
                if (!checkAndSetGameFlag(anEvent))
                {
                    HintSystemScript.instance.putNextHint(HintSystemScript.Type.GameRestartButton, HintSystemScript.Environment.World);
                    return true;
                }
                break;
            case GameEvents.WorldButtonShowFinalRollsPressed:
                if (!checkAndSetGameFlag(anEvent))
                {
                    HintSystemScript.instance.putNextHint(HintSystemScript.Type.GameRollsButton, HintSystemScript.Environment.World);
                    return true;
                }
                break;
            case GameEvents.AdShown:
                break;
        }
        return false;
    }

    // this method handles exclusively puzzle tiles
    bool processPuzzleTileInPlace(bool FirstRound, int SelectedLevel)
    {
        /*
        int SelectedLevel = (int)(long)AppData.instance[AppData.Storage.SelectedLevel];
        bool FirstRound = (bool)AppData.instance[AppData.Storage.FirstRound];
        */
        /*
        PuzzleModel pms = puzzleModelObject.GetComponent<PuzzleModel>();
        GenericGameController ggc = puzzleModelObject.GetComponent<GenericGameController>();
        */
        bool retVal = false;
        if (FirstRound)
        {
            switch (SelectedLevel)
            {
                case 0:
                    if (puzzleModel.isPuzzlePartiallyAssembled(0, 2))
                    {
                        if (!checkAndSetGameFlag(GameEvents.ThirdTileInPlace))
                        {
                            if (!checkAndSetGameFlag(GameEvents.SecondTileInPlace))
                            {
                                puzzleModel.increaseLocalPoints(secondTilePoints);
                            }
                            if (!checkAndSetGameFlag(GameEvents.FirstTileInPlace))
                            {
                                puzzleModel.increaseLocalPoints(firstTilePoints);
                            }
                            HintSystemScript.instance.putNextHint(HintSystemScript.Type.ThirdTileInPlace, HintSystemScript.Environment.Puzzle);
                            HintSystemScript.instance.putNextHint(HintSystemScript.Type.TwoRowsInPlace2, HintSystemScript.Environment.Puzzle);
                            puzzleModel.increaseLocalPoints(thirdTilePoints);
                            setGameFlag(GameEvents.PuzzleTutorialCompleted);
                            //StartCoroutine(ggc.autoSolvePuzzle());
                            retVal = true;
                        }
                    }
                    else if (puzzleModel.isPuzzlePartiallyAssembled(0, 1))
                    {
                        if (!checkAndSetGameFlag(GameEvents.SecondTileInPlace))
                        {
                            if (!checkAndSetGameFlag(GameEvents.FirstTileInPlace))
                            {
                                puzzleModel.increaseLocalPoints(firstTilePoints);
                            }
                            HintSystemScript.instance.putNextHint(HintSystemScript.Type.SecondTileInPlace, HintSystemScript.Environment.Puzzle);
                            puzzleModel.increaseLocalPoints(secondTilePoints);
                            retVal = true;
                        }
                    }
                    else if (puzzleModel.isPuzzlePartiallyAssembled(0, 0))
                    {
                        if (!checkAndSetGameFlag(GameEvents.FirstTileInPlace))
                        {
                            HintSystemScript.instance.putNextHint(HintSystemScript.Type.FirstTileInPlace, HintSystemScript.Environment.Puzzle);
                            HintSystemScript.instance.putNextHint(HintSystemScript.Type.SecondTileButtonsHint, HintSystemScript.Environment.Puzzle);
                            puzzleModel.increaseLocalPoints(firstTilePoints);
                            retVal = true;
                        }
                    }
                    else
                    {
                        if (getGameFlag(GameEvents.PuzzleShuffled) && !checkAndSetGameFlag(GameEvents.PuzzleQuartetRotated))
                        {
                            HintSystemScript.instance.putNextHint(HintSystemScript.Type.FirstPuzzleQuartetRotated, HintSystemScript.Environment.Puzzle);
                            retVal = true;
                        }

                    }
                    break;
                case 1:
                    if (puzzleModel.isPuzzlePartiallyAssembled(1, 2))
                    {
                        if (!checkAndSetGameFlag(GameEvents.TwoRowsInPlace))
                        {
                            HintSystemScript.instance.putNextHint(HintSystemScript.Type.TwoRowsInPlace, HintSystemScript.Environment.Puzzle);
                            HintSystemScript.instance.putNextHint(HintSystemScript.Type.TwoRowsInPlace2, HintSystemScript.Environment.Puzzle);
                            puzzleModel.increaseLocalPoints(secondRowPoints);
                            AppData.instance[AppData.Storage.BonusCoinsAdded] = true;
                            increaseCoins(FirstTimeCoinBonus);
                            //StartCoroutine(ggc.autoSolvePuzzle());
                            retVal = true;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        if (puzzleModel.isPuzzleAssembled())
        {
            puzzleModel.increaseLocalPoints(puzzleAssembledPoints);
            retVal = true;
        }
        return retVal;
    }
}
