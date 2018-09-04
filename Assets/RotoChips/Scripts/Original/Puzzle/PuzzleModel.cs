using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;
using RotoChips.ImageProcessing;
using RotoChips.Puzzle;

public class PuzzleModel : MonoBehaviour {
    private LevelDataManager.Descriptor ld;

    public GameObject TilePrefab;
    public GameObject ButtonPrefab;

    private int PuzzleWidth;                        // puzzle width in tiles
    private int PuzzleHeight;                       // puzzle height in tiles
    private int activeButtonY, activeButtonX;       // active (pressed) button
    private GameObject[] tileArray;                 // an array of references to tile game objects
    private GameObject[] buttonArray;               // an array of references to button game objects
    public struct TileID
    {
        public int globalID;
        public int angleID;
    };

    private TileID[,] tileNeighbours;               // a two-dimensional array which represents an image of the puzzle

    // tuning parameters
    public float TileSize = 2.0f;                   // == 2.0f
    public float NeutralTileZ = 0f;                 // == 0f
    public float NeutralButtonZ = 0.25f;            // neutral button z-position
    public float PressedButtonZ = 0.55f;            // pressed button z-position
    public float ReleasedButtonZ = -0.05f;          // released button z-position
    public int releaseSteps = 6;                    // number of steps to release a button
    public int rotateSteps = 16;                    // number of steps to rotate a buttons 90 degrees clockwise
    public int backToNeutralSteps = 4;              // number of steps for a button to get back to a neutral position

    public int fastMoveFactor = 2;                  // this is a factor of fast movements speed
    public int normalMoveFactor = 1;                // this is a factor of normal movements speed
    bool fastMove;                                  // if the puzzle parts are moving fast

    int internalReleaseSteps;                       // real number of steps to release a button, according to the fastMove mode
    int internalRotateSteps;                        // real number of steps to rotate a button, according to the fastMove mode
    int internalBackToNeutralSteps;                 // real of steps for a button to get back to a neutral position, according to the fastMove mode

    public GameObject puzzleListener;

    public enum restoreStatus
    {
        restoreFailed,                              // state restoration failed (no input state)
        restoreNormal,                              // restoration completed normally
        restoreComplete                             // restoration completed, puzzle finished
    };

    public struct AutoStepParams
    {
        public int id;
        public int y;
        public int x;
        public int angle;
    };

	Texture2D[,] tileTextures;
	public int TileTextureSizePx = 128;				// pixel size of one tileTexture

	// this auxillary method creates tile textures out from the "source" image texture
	// by cutting it into width x height square pieces
	void prepareTileTextures(int level, int width, int height) {
        /*
		tileTextures = new Texture2D[width, height];
		//Texture2D sourceTexture = SourceImageCreator.instance.GetSourceImage(level);
		int startY = 0;
		int dX = sourceTexture.width / width;
		int dY = sourceTexture.height / height;
		for (int y = height - 1; y >= 0; startY += dY, y--) {
			// texture y-coordinate counts top-down, puzzle y-coordinate counts bottom-up
			int startX = 0;
			for (int x = 0; x < width; startX += dX, x++) {
				// create intermediate texture
				Texture2D itex = new Texture2D (dX, dY);
				itex.SetPixels (sourceTexture.GetPixels (startX, startY, dX, dY));
				itex.Apply ();
				// now create a square tile texture
				tileTextures [x, y] = new Texture2D (TileTextureSizePx, TileTextureSizePx);
				float dc = 1f / TileTextureSizePx;
				float iy = 0f;
				for (int oy = 0; oy < TileTextureSizePx; iy += dc,oy++) {
					float ix = 0f;
					for (int ox = 0; ox < TileTextureSizePx; ix += dc,ox++) {
						tileTextures [x, y].SetPixel (ox, oy, itex.GetPixelBilinear (ix, iy));
					}
				}
				tileTextures [x, y].Apply ();
			}
		}
        */
	}

    // Use this for initialization
    void Start()
    {
		// get level parameters for the puzzle initialization
		ld = GlobalManager.MLevel.GetDescriptor(GlobalManager.MStorage.SelectedLevel);		// LevelDesc data

        // puzzle dimensions
        PuzzleHeight = ld.init.height;
        PuzzleWidth = ld.init.width;

        setFastMove(false);

        // fill in button matrix buttonArray (an array of button GameObjects)
        buttonArray = new GameObject[(PuzzleHeight - 1) * (PuzzleWidth - 1)];   // it is linear because it is faster to address a one-dimensional array
                                                                                // than a two-dimensional one
        Vector3 buttonPosition = new Vector3(-(PuzzleWidth - 2) * TileSize / 2, (PuzzleHeight - 2) * TileSize / 2, NeutralButtonZ);
        int bi = 0; // button index
        for (int y = 0; y < PuzzleHeight - 1; ++y)
        {
            buttonPosition.x = -(float)(PuzzleWidth - 2) * TileSize / 2;
            for (int x = 0; x < PuzzleWidth - 1; ++x, ++bi)
            {
                //buttonArray[bi] = (GameObject)Instantiate(ButtonPrefab);
                //
                buttonArray[bi] = (GameObject)Instantiate(ButtonPrefab, gameObject.transform);
                //buttonArray[bi].transform.SetParent(gameObject.transform);
                //
                buttonArray[bi].transform.position = Vector3.zero;
                buttonArray[bi].transform.position += buttonPosition;
                buttonArray[bi].GetComponent<PuzzleButtonScript>().setNeutralListener(puzzleListener);
                buttonPosition.x += TileSize;
            }
            buttonPosition.y -= TileSize;
        }

		prepareTileTextures (ld.init.id, PuzzleWidth, PuzzleHeight);
        // fill in tile matrix tileArray (an array of tile GameObjects) and tileNeighbours (two-dimensional tile descriptions matrix)
        tileArray = new GameObject[PuzzleHeight * PuzzleWidth];
        tileNeighbours = new TileID[PuzzleHeight, PuzzleWidth];
        Vector3 tilePosition = new Vector3(-(PuzzleWidth - 1) * TileSize / 2, (PuzzleHeight - 1) * TileSize / 2, NeutralTileZ);
        int tileIndex = 0;  // tileIndex is linearly incremented through the puzzle matrix
        //Debug.Log("Resource directory is " + ld.GraphicsResource);
        for (int y = 0; y < PuzzleHeight; ++y)
        {
            tilePosition.x = -(PuzzleWidth - 1) * TileSize / 2;
            //string yStr = y.ToString("D4");
            for (int x = 0; x < PuzzleWidth; ++x, ++tileIndex)
            {
                //tileArray[tileIndex] = (GameObject)Instantiate(TilePrefab);
                //
                tileArray[tileIndex] = (GameObject)Instantiate(TilePrefab, gameObject.transform);
                //tileArray[tileIndex].transform.SetParent(gameObject.transform);
                //
				/*
                string resname = ld.GraphicsResource + "/" + yStr + "-" + x.ToString("D4");
                tileArray[tileIndex].GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(resname);
                */
				Rect r = new Rect (new Vector2 (0, 0), new Vector2 (tileTextures [x, y].width, tileTextures [x, y].height));
				tileArray [tileIndex].GetComponent<SpriteRenderer> ().sprite = Sprite.Create (tileTextures [x, y], r, new Vector2 (0.5f, 0.5f));
				//tileArray[tileIndex].transform.localScale = new Vector3(TileSize, TileSize, 1);
				/* --- */
				//tileArray[tileIndex].transform.localScale = new Vector3(TileSize, TileSize, 1);
                tileArray[tileIndex].transform.position = Vector3.zero;
                tileArray[tileIndex].transform.position += tilePosition;
                tileNeighbours[y, x].globalID = tileIndex;
                tileNeighbours[y, x].angleID = 0;
                //tileArray[tileIndex].GetComponent<TileFlasher>().setFlashListener(puzzleListener);
                tilePosition.x += TileSize;
            }
            tilePosition.y -= TileSize;
        }
        // and restore the last state
        activeButtonY = activeButtonX = -1;

        //restoreState(false);    // just restore the state, do not notify the controller
    }

    public void setFastMove(bool isFast)
    {
        // additional calculations
        fastMove = isFast;
        int fastFactor = fastMove ? fastMoveFactor : normalMoveFactor;
		internalReleaseSteps = releaseSteps / fastFactor;
		internalRotateSteps = rotateSteps / fastFactor;
		internalBackToNeutralSteps = backToNeutralSteps / fastFactor;
    }

    public int puzzleWidth()
    {
        return PuzzleWidth;
    }

    public int puzzleHeight()
    {
        return PuzzleHeight;
    }

    // == Button control methods ==
    // this method presses the active button
    public void pressButton()
    {
        GameObject button = activeButton();
        if (button != null)
        {
            Vector3 buttonPos = new Vector3(0, 0, button.transform.position.z);
            buttonPos.z = PressedButtonZ - buttonPos.z;
            button.transform.position += buttonPos;
            puzzleListener.SendMessage("buttonPressed");
        }
    }

    // this method unpresses the active button (returns it directly to the neutral position)
    public void unpressButton()
    {
        GameObject button = activeButton();
        if (button != null)
        {
            Vector3 buttonPos = new Vector3(0, 0, button.transform.position.z);
            buttonPos.z = NeutralButtonZ - buttonPos.z;
            button.transform.position += buttonPos;
            puzzleListener.SendMessage("buttonUnpressed");
        }
    }

    // this method releases the active button
    public void releaseButton()
    {
        if (activeButton() != null)
        {
            //resetButton();
            activeButton().GetComponent<PuzzleButtonScript>().slide(PressedButtonZ, ReleasedButtonZ, internalReleaseSteps);
        }
    }

    // this method rotates the active button
    public void rotateButton()
    {
        if (activeButton() != null)
        {
            //resetButton();
            RotateTilesOfButton(activeButtonY, activeButtonX);
            activeButton().GetComponent<PuzzleButtonScript>().rotate90DegreesCW(internalRotateSteps);
        }
    }

    // this method returns the released and rotated active button back to the neutral position
    public void backToNeutral()
    {
        if (activeButton() != null)
        {
            //resetButton();
            activeButton().GetComponent<PuzzleButtonScript>().slide(ReleasedButtonZ, NeutralButtonZ, internalBackToNeutralSteps);
        }
    }

    /* Puzzle state saving and restoration routines */
    public long getScore()
    {
        return ld.state.EarnedPoints;
		//return (long)AppData.instance[AppData.Storage.CurrentPoints];
    }

    // auxillary method for incrementing local puzzle points
    public void increaseLocalPoints(long points)
    {
        ld.state.EarnedPoints += points;
        //GameManager.instance.increasePoints(points);
        //LevelData.instance[ld.init.id] = ld;
    }

    // this method sets the score
    private void setGoodStateAndScore()
    {
        int puzzleGoodID = -1;
        int stateGoodID = -1;
        if (isPuzzleStateBetterThan(ld.state.LastGoodState, out puzzleGoodID, out stateGoodID) > 0)
        {
            //Debug.Log("New state is better than " + ld.status.LastGoodState + "; puzzleId: " + puzzleGoodID.ToString() + ", stateId: " + stateGoodID.ToString());
            if (!ld.state.AutocompleteUsed)
            {
                if (stateGoodID < 0)
                {
                    stateGoodID = 0;
                }
                /*
				long addPoints = GameManager.instance.calculateBonusPoints(ld.init.id, stateGoodID, puzzleGoodID);
                increaseLocalPoints(addPoints);
                */
				/*
            } else
            {
                //Debug.Log("Autocomplete used");
                */
            }
            //Debug.Log("goodState is saved");
            ld.state.LastGoodState = ld.state.CurrentState;
            ld.state.LastGoodButtonState = ld.state.CurrentButtonState;
        } else
        {
            //Debug.Log("New state is worse than " + ld.status.LastGoodState + "; puzzleId: " + puzzleGoodID.ToString() + ", stateId: " + stateGoodID.ToString());
        }
    }

    // this method saves the current state of the puzzle
    // and sets the good one if applicable
    public void saveState()
    {
        string state = "";
        // build a buttons rotations state string
        int bi = 0;     // button index
        for (int y = 0; y < PuzzleHeight - 1; y++)
        {
            for(int x = 0; x < PuzzleWidth - 1; x++)
            {
                state += buttonArray[bi].GetComponent<PuzzleButtonScript>().angleIndex().ToString();
                bi++;
            }
        }
        ld.state.CurrentButtonState = state;
        // build a puzzle state string
        for (int y = 0; y < PuzzleHeight; ++y)
        {
            for (int x = 0; x < PuzzleWidth; ++x)
            {
                state += "." + tileNeighbours[y, x].globalID.ToString() + "." + tileNeighbours[y, x].angleID.ToString();
            }
        }
        ld.state.CurrentState = state;
        setGoodStateAndScore();
		//LevelData.instance[ld.init.id] = ld;
    }

    // this method retores the state of the puzzle
    // from its current or the last good record
    public restoreStatus restoreState(bool toGood)
    {
		ld = GlobalManager.MLevel.GetDescriptor(GlobalManager.MStorage.SelectedLevel);		// LevelDesc data
        string targetState = toGood ? ld.state.LastGoodState : ld.state.CurrentState;
        string buttonState = toGood ? ld.state.LastGoodButtonState : ld.state.CurrentButtonState;
        //Debug.Log("Restoring state for level " + PlayerStat.instance.CurrentLevel.ToString() + ": '" + targetState + "'");
        if (targetState == "")
        {
            //puzzleListener.SendMessage("initPuzzle");
            return restoreStatus.restoreFailed;
        }
        activeButtonX = -1;
        activeButtonY = -1;
        // turn every tile to angle 0 and detach it from its parent
        for (int y = 0; y < PuzzleHeight; ++y)
        {
            for (int x = 0; x < PuzzleWidth; ++x)
            {
                int angleID = tileNeighbours[y, x].angleID;
                int globalID = tileNeighbours[y, x].globalID;
                if (angleID > 0)
                {
                    tileArray[globalID].transform.RotateAround(tileArray[globalID].transform.localPosition, Vector3.forward, tileNeighbours[y, x].angleID * 90f);
                }
                // and detach from parent
                tileArray[globalID].transform.SetParent(gameObject.transform);
            }
        }
        // turn every button to a saved angle
        int bi = 0;     // button index
        for (int y = 0; y < PuzzleHeight - 1; y++)
        {
            for (int x = 0; x < PuzzleWidth - 1; x++)
            {
                int angleIndex = 0;
                if (buttonState.Length > 0)
                {
                    angleIndex = int.Parse(buttonState.Substring(bi,1));
                }
                buttonArray[bi].GetComponent<PuzzleButtonScript>().setAngleIndex(angleIndex);
                bi++;
            }
        }
        // turn every tile to a saved angle
        char[] delimiters = { '.' };
        string[] parts = targetState.Split(delimiters);
        int i = 1;
        Vector3 tilePosition = new Vector3(-(PuzzleWidth - 1) * TileSize / 2, (PuzzleHeight - 1) * TileSize / 2, NeutralTileZ);
        for (int y = 0; y < PuzzleHeight; ++y)
        {
            tilePosition.x = -(PuzzleWidth - 1) * TileSize / 2;
            for (int x = 0; x < PuzzleWidth; ++x)
            {
                int globalID = int.Parse(parts[i]);
                int angleID = int.Parse(parts[i + 1]);
                tileNeighbours[y, x].globalID = globalID;
                tileNeighbours[y, x].angleID = angleID;
                if (angleID > 0)
                {
                    tileArray[globalID].transform.RotateAround(tileArray[globalID].transform.localPosition, Vector3.back, 90f * angleID);
                }
                tileArray[globalID].transform.position = Vector3.zero;
                tileArray[globalID].transform.position += tilePosition;
                i += 2;
                tilePosition.x += TileSize;
            }
            tilePosition.y -= TileSize;
        }
        if (isPuzzleAssembled())
        {
            return restoreStatus.restoreComplete;
        }
        return restoreStatus.restoreNormal;
    }

	// this method sets the global gallery level id equal to the global current level id
	public void setGalleryLevel() {
        GlobalManager.MStorage.GalleryLevel = GlobalManager.MStorage.SelectedLevel;
	}

    // this method sets the next level in PlayerStat object
    public int getToNextLevel()
    {
        //int NextId = PlayerStat.instance.getNextPlayableLevel(ld.init.id);
        int NextId = ld.state.NextPlayableId;
        //Debug.Log("Current level is " + ld.init.id + ", next level is " + NextId);
        if (NextId != -1)
        {
            GlobalManager.MStorage.SelectedLevel = NextId;
        }
        return NextId;
    }

    // this method resets the puzzle state to initial (which equals to the finished one)
    // resets the "AutocompleteUsed" flag
    // and saves the level status
    public void resetPuzzle()
    {
        // create initial state
        string state = "";
        int cId = 0;
        for (int y = 0; y < PuzzleHeight; ++y)
        {
            for (int x = 0; x < PuzzleWidth; ++x, ++cId)
            {
                state += "." + cId.ToString() + ".0";
            }
        }
        ld.state.CurrentState = state;
        ld.state.LastGoodState = "";
        ld.state.CurrentButtonState = "";
        ld.state.LastGoodButtonState = "";
		// if the puzzle is not assembled, cut off the earned points
		if (!isPuzzleAssembled()) {
			//GameManager.instance.decreasePoints(ld.state.EarnedPoints);
		}
        ld.state.EarnedPoints = 0;
        //ld.state.Complete = false;
        ld.state.AutocompleteUsed = false;
		//LevelData.instance[ld.init.id] = ld;
    }

    public void setAutocompleteUsed()
    {
        ld.state.AutocompleteUsed = true;
		//LevelData.instance[ld.init.id] = ld;
    }

    public void setComplete()
    {
        /*
        GameManager.instance.setLevelComplete(ld.init.id);
		ld = LevelData.instance[ld.init.id];	// LevelDesc data is changed after level completion, so reload it
        */
    }

    // === Auxiliary methods for buttons/tiles movement
    public GameObject activeButton()
    {
        return buttonAt(activeButtonY, activeButtonX);
    }

    public GameObject buttonAt(int y, int x)
    {
        if (y < 0 || y >= PuzzleHeight || x < 0 || x >= PuzzleWidth)
            return null;
        return buttonArray[y * (PuzzleWidth - 1) + x];
    }

    // this method looks for a button hit with a finger touch
    public bool getHitButton(Vector2 touchPoint, out int bY, out int bX)
    {
        bY = -1;
        bX = -1;
        RaycastHit hit = new RaycastHit();
        Ray r = Camera.main.ScreenPointToRay(touchPoint);
        if (Physics.Raycast(r, out hit))
        {
            GameObject hitObject = hit.transform.gameObject;
            int bi = 0; // button index
            for (int y = 0; y < PuzzleHeight - 1; ++y)
            {
                for (int x = 0; x < PuzzleWidth - 1; ++x, ++bi)
                {
                    if (hitObject == buttonArray[bi])
                    {
                        bY = y;
                        bX = x;
                        return true;
                    }
                }
            }
        }
        return false;
    }

    // this method makes the active button a parent to its four neighbour tiles
    public bool attachTilesToButton(int bY, int bX)
    {
        if (bY < 0 || bY >= PuzzleHeight || bX < 0 || bX >= PuzzleWidth)
            return false;
        /*
                the tile map of a button:
                [ 0, 0]   ->   [ 0,+1]
                   ^   (button)   v
                [+1, 0]  <-    [+1,+1]
        */
        // connect tiles to the button
        activeButtonY = bY;
        activeButtonX = bX;
        activeButton().GetComponent<PuzzleButtonScript>().setNeightbourTiles(
            gameObject,
            tileArray[tileNeighbours[activeButtonY, activeButtonX].globalID],
            tileArray[tileNeighbours[activeButtonY + 1, activeButtonX].globalID],
            tileArray[tileNeighbours[activeButtonY + 1, activeButtonX + 1].globalID],
            tileArray[tileNeighbours[activeButtonY, activeButtonX + 1].globalID]
        );
        return true;
    }

    // this method detaches four neighbour tiles from the active button
    public bool detachTilesFromButton()
    {
        if (activeButtonY < 0 || activeButtonY >= PuzzleHeight || activeButtonX < 0 || activeButtonX >= PuzzleWidth)
            return false;
        activeButton().GetComponent<PuzzleButtonScript>().unsetNeighbourTiles(gameObject);
        activeButtonY = activeButtonX = -1;
        return true;
    }

    void RotateTilesOfButton(int buttonYId, int buttonXId)
    {
        if (buttonYId < 0 || buttonYId >= PuzzleHeight || buttonXId < 0 || buttonXId >= PuzzleWidth)
            return;

        // save left bottom
        TileID saveLastNeighbour = tileNeighbours[buttonYId, buttonXId];
        // left top <- left bottom
        tileNeighbours[buttonYId, buttonXId].globalID = tileNeighbours[buttonYId + 1, buttonXId].globalID;
        tileNeighbours[buttonYId, buttonXId].angleID = (tileNeighbours[buttonYId + 1, buttonXId].angleID + 1) % 4;
        // left bottom <- right bottom
        tileNeighbours[buttonYId + 1, buttonXId].globalID = tileNeighbours[buttonYId + 1, buttonXId + 1].globalID;
        tileNeighbours[buttonYId + 1, buttonXId].angleID = (tileNeighbours[buttonYId + 1, buttonXId + 1].angleID + 1) % 4;
        // right bottom <- right top
        tileNeighbours[buttonYId + 1, buttonXId + 1].globalID = tileNeighbours[buttonYId, buttonXId + 1].globalID;
        tileNeighbours[buttonYId + 1, buttonXId + 1].angleID = (tileNeighbours[buttonYId, buttonXId + 1].angleID + 1) % 4;
        // right top <- left top
        tileNeighbours[buttonYId, buttonXId + 1].globalID = saveLastNeighbour.globalID;
        tileNeighbours[buttonYId, buttonXId + 1].angleID = (saveLastNeighbour.angleID + 1) % 4;

    }

    // --- Tile flashing control methods ---
    // this mnethod flashes first "inplace" tiles green
    public void flashAssembledTiles()
    {
        bool idOk = true;
        for (int y = 0; y < PuzzleHeight; ++y)
        {
            for (int x = 0; x < PuzzleWidth; ++x)
            {
                int initId = y * PuzzleWidth + x;
                int currentId = tileNeighbours[y, x].globalID;
                int angle = tileNeighbours[y, x].angleID;
                if (idOk)   // all previous tiles are in their places
                {
                    if (initId == currentId && angle == 0)  // current tile is in its place
                    {
                        //tileArray[y * PuzzleWidth + x].GetComponent<TileFlasher>().FlashGood();
                    }
                    else
                    {
                        idOk = false;                       // current tile is not in its place, so all subsequent tiles are not in their places too
                        //tileArray[y * PuzzleWidth + x].GetComponent<TileFlasher>().StopFlashing();
                    }
                }
                else
                {
                    // some of previous tiles are not in their places
                    //tileArray[y * PuzzleWidth + x].GetComponent<TileFlasher>().StopFlashing();
                }
            }
        }
    }

    // this method stops tile flashing forcedly
    public void stopFlashingTiles()
    {
        for (int y = 0; y < PuzzleHeight; ++y)
        {
            for (int x = 0; x < PuzzleWidth; ++x)
            {
                //tileArray[y * PuzzleWidth + x].GetComponent<TileFlasher>().StopFlashing();
            }
        }
    }

    // this method flashes first non-"inplace" tile red
    public void flashNextTile(int id)
    {
        if (id >= 0 && id < PuzzleHeight * PuzzleWidth)
        {
            //tileArray[id].GetComponent<TileFlasher>().FlashBad();
        }
    }

    // --- Puzzle state calculation methods ---
    // this method checks if the puzzle is fully assembled
    // 08.01.2017: FINAL
    public bool isPuzzleAssembled()
    {
		return isPuzzlePartiallyAssembled(PuzzleHeight * PuzzleWidth - 1);
    }

	// this method checks if the puzzle is partially assembled up to a tile at (y,x) socket
	public bool isPuzzlePartiallyAssembled(int lastY, int lastX)
	{
		return isPuzzlePartiallyAssembled(lastY * PuzzleWidth + lastX);
	}

	// this method checks if the puzzle is partially assembled up to a tile with a specified id
	public bool isPuzzlePartiallyAssembled(int anId)
	{
		if (anId < 0)
			return false;
		int id = 0;
		for (int y = 0; y < PuzzleHeight; y++)
		{
			for (int x = 0; x < PuzzleWidth && id <= anId; x++, id++)
			{
				if (tileNeighbours[y, x].globalID != id || tileNeighbours[y, x].angleID != 0)
				{
					return false;
				}
			}
		}
		return true;
	}

	// this method checks if the puzzle is partially assembled up to a specified row
	public bool isPuzzlePartiallyAssembledToRow(int row)
	{
		return isPuzzlePartiallyAssembled((row + 1) * PuzzleWidth - 1);
	}

	// this method returns last fully assembled row
	public int lastAssembledRow()
	{
        return lastAssembledTile().y;
	}

    public struct TilePosition
    {
        public int y;
        public int x;
    };

    // this method returns the last tile in place
    public TilePosition lastAssembledTile()
    {
        TilePosition pos = new TilePosition { y = -1, x = -1 };
        int id = 0;
        for (int y = 0; y < PuzzleHeight; y++)
        {
            for (int x = 0; x < PuzzleWidth; x++, id++)
            {
                if (tileNeighbours[y, x].globalID != id || tileNeighbours[y, x].angleID != 0)
                {
                    return pos;
                }
                pos.x++;
            }
            pos.y++;
        }
        return pos;
    }

    // this method checks if the current puzzle state is "better" than the one in parameters
    // this means that the current puzzle state has more first "inplace" tiles than the other
    // if current puzzle state is better than aState, then return 1
    // if current puzzle state is worse than aState, then return -1
    // otherwise, return 0
    // 08.01.2017: FINAL
    public int isPuzzleStateBetterThan(string aState, out int puzzleGoodID, out int stateGoodID)
    {
        puzzleGoodID = -1;  // the id of the last "inplace" tile in the current puzzle state
        stateGoodID = -1;   // the id of the last "inplace" tile in the parameter state aState
        if (aState == "")
        {
            //Debug.Log("aState is empty");
            return 1;
        }
        char[] delimiters = { '.' };
        string[] parts = aState.Split(delimiters);
        int i = 1;
        int goodPosition = 0;
        bool cmpPuzzle = true;
        bool cmpState = true;
        for (int y = 0; y < PuzzleHeight; ++y)
        {
            for (int x = 0; x < PuzzleWidth; ++x)
            {
                int globalID = int.Parse(parts[i]);
                int angleID = int.Parse(parts[i + 1]);
                //Debug.Log("CmpStates at " + goodPosition.ToString() + ": cState("+puzzleGoodID.ToString()+"):[" + tileNeighbours[y, x].globalID.ToString() + "," + tileNeighbours[y, x].angleID.ToString() + "], aState("+stateGoodID.ToString()+"):[" + globalID.ToString() + "," + angleID.ToString() + "]");
                if (cmpPuzzle)
                {
                    if (tileNeighbours[y, x].angleID == 0 && tileNeighbours[y, x].globalID == goodPosition) // real tile is in good state
                    {
                        puzzleGoodID = goodPosition;
                        //Debug.Log("cState(" + goodPosition.ToString() + "): good");
                    }
                    else
                    {
                        cmpPuzzle = false;
                    }
                }
                if (cmpState)
                {
                    if (globalID == goodPosition && angleID == 0)   // another state tile is in good state
                    {
                        stateGoodID = goodPosition;
                        //Debug.Log("aState(" + goodPosition.ToString() + "): good");
                    }
                    else
                    {
                        cmpState = false;
                    }
                }
                if (!cmpPuzzle && !cmpState)
                {
                    break;
                }
                goodPosition++;
                i += 2;
            }
        }
        //Debug.Log("++cState==aState");
        return puzzleGoodID > stateGoodID ? 1 : (puzzleGoodID < stateGoodID ? -1 : 0);
    }

    // this method gets the parameters of the first non-"inplace" tile
    // 08.01.2017: FINAL
    public bool getAutoStepParams(out AutoStepParams asp)
    {
        // check for last best tile "in place"
        saveState();        // save current state
        restoreState(true); // restore the puzzle state to the last good one before performing actual autostep
        asp.id = asp.y = asp.x = asp.angle = -1;
        int nextBestId = 0;
        bool idOk = true;
        int initId = 0;
        for (int y = 0; y < PuzzleHeight; y++)
        {
            for (int x = 0; x < PuzzleWidth; x++, initId++)
            {
                int currentId = tileNeighbours[y, x].globalID;
                int angle = tileNeighbours[y, x].angleID;
                if (idOk)
                {
                    if (initId == currentId && angle == 0)
                    {
                        ++nextBestId;
                    }
                    else
                    {
                        idOk = false;
                    }
                }
                if (!idOk)
                {
                    if (currentId == nextBestId)
                    {
                        asp.id = nextBestId;
                        asp.y = y;
                        asp.x = x;
                        asp.angle = angle;
                        return true;
                    }
                }
            }
        }
        restoreState(false);    // restore the current state since no autostep has been performed
        Debug.Log("No tile found for autostep. Last nextBestId: " + nextBestId.ToString());   // this situation should never arise
        return false;
    }

}
