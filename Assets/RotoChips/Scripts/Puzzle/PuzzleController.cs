/*
 * File:        PuzzleController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class PuzzleController implements puzzle mechanics for the Puzzle scene
 * Created:     03.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;
using RotoChips.Data;
using RotoChips.Audio;
using RotoChips.UI;
using RotoChips.Utility;

namespace RotoChips.Puzzle
{
    [System.Serializable]
    public class TileStatus
    {
        public Vector2Int id;
        public int angle;
    }

    public class PuzzleCompleteStatus
    {
        public LevelDataManager.Descriptor descriptor;
        public bool firstTime;
    }

    public class TileInPlaceReport
    {
        public Vector2Int previous;     // previous tile in place
        public Vector2Int current;      // current tile in place
    }

    public class PuzzleController : MonoBehaviour
    {
        MessageRegistrator registrator;         // standard message handlers registrator
        LevelDataManager.Descriptor descriptor; // a descriptor of a currently played level
        TileStatus[,] tileNeighbours;           // a 2-dimensional array of tile statuses
        int[,] buttonAngles;                    // a 2-dimensional array of button angle codes
                                                // (0 - 0 degrees,
                                                //  1 - 90 degrees clockwise,
                                                //  2 - 180 degrees clockwise,
                                                //  3 - 270 degrees clockwise

        PuzzleBuilder builder;                  // a reference to the PuzzleBuilder
        bool puzzleBusy;                        // private puzzle status flags
        bool buttonRotated;
        bool puzzleComplete;
        bool autostepUsed;

        bool startVictoryScreen;                // a flag to start the victory screen

        // Use this for initialization
        private void Awake()
        {
            descriptor = GlobalManager.MLevel.GetDescriptor(GlobalManager.MStorage.SelectedLevel);
            tileNeighbours = new TileStatus[descriptor.init.width, descriptor.init.height];
            buttonAngles = new int[descriptor.init.width - 1, descriptor.init.height - 1];
            builder = GetComponent<PuzzleBuilder>();
            puzzleBusy = false;
            buttonRotated = false;
            puzzleComplete = false;
            autostepUsed = false;
            startVictoryScreen = true;
            registrator = new MessageRegistrator(
                InstantMessageType.PuzzleButtonPressed, (InstantMessageHandler)OnPuzzleButtonPressed,
                InstantMessageType.PuzzleButtonRotated, (InstantMessageHandler)OnPuzzleButtonRotated,
                InstantMessageType.PuzzleTileFlashed, (InstantMessageHandler)OnPuzzleTileFlashed,
                InstantMessageType.PuzzleAutostepUsed, (InstantMessageHandler)OnPuzzleAutostepUsed,
                InstantMessageType.PuzzleShuffle, (InstantMessageHandler)OnPuzzleShuffle,
                InstantMessageType.PuzzleReset, (InstantMessageHandler)OnPuzzleReset,
                InstantMessageType.PuzzlePrepareAutostep, (InstantMessageHandler)OnPuzzlePrepareAutostep,
                InstantMessageType.PuzzleAutostep, (InstantMessageHandler)OnPuzzleAutostep,
                InstantMessageType.PuzzleAutocomplete, (InstantMessageHandler)OnPuzzleAutocomplete,
                InstantMessageType.PuzzleBusy, (InstantMessageHandler)OnPuzzleBusy,
                InstantMessageType.RedirectFirstTileButtons, (InstantMessageHandler)OnRedirectFirstTileButtons,
                InstantMessageType.RedirectSecondTileButtons, (InstantMessageHandler)OnRedirectSecondTileButtons
            );
            registrator.RegisterHandlers();
        }

        void Start()
        {
            RestoreAll();
        }

        #region Status handling
        // this method creates a status string out from the current status of tiles
        string BuildStatusString()
        {
            string statusString = "";
            for (int y = 0; y < descriptor.init.height; y++)
            {
                for (int x = 0; x < descriptor.init.width; x++)
                {
                    if (statusString != "")
                    {
                        statusString += ".";
                    }
                    TileStatus tileStatus = tileNeighbours[x, y];
                    statusString += tileStatus.id.x.ToString() + "," + tileStatus.id.y.ToString() + "," + tileStatus.angle.ToString();
                }
            }
            return statusString;
        }

        void SaveTileStatuses(bool good = false)
        {
            string statusString = BuildStatusString();
            if (good)
            {
                descriptor.state.LastGoodState = statusString;
            }
            descriptor.state.CurrentState = statusString;
        }

        void SaveButtonStatuses(bool good = false)
        {
            string statusString = "";
            for (int y = 0; y < descriptor.init.height - 1; y++)
            {
                for (int x = 0; x < descriptor.init.width - 1; x++)
                {
                    if (statusString != "")
                    {
                        statusString += ".";
                    }
                    statusString += buttonAngles[x, y].ToString();
                }
            }
            if (good)
            {
                descriptor.state.LastGoodButtonState = statusString;
            }
            descriptor.state.CurrentButtonState = statusString;
        }

        void SaveAll()
        {
            Vector2Int thisTile, otherTile;
            bool good = IsPuzzleStateBetter(descriptor.state.LastGoodState, out thisTile, out otherTile) > 0;
            Debug.Log("PuzzleController.SaveAll: new state is better - " + good.ToString());
            SaveButtonStatuses(good);
            SaveTileStatuses(good);
            if (good)
            {
                GlobalManager.MInstantMessage.DeliverMessage(
                    InstantMessageType.PuzzleTileInPlace,
                    this,
                    new TileInPlaceReport
                    {
                        previous = otherTile,
                        current = thisTile
                    }
                );
            }
        }

        // this method parses a status string and sets a TileStatus array according to it
        // it also initializes the TileStatus array if it is not yet initialized
        void ParseStatusString(string statusString, ref TileStatus[,] tiles)
        {
            string[] parts = null;
            if (!string.IsNullOrEmpty(statusString))
            {
                parts = statusString.Split('.');
            }
            int i = 0;
            for (int y = 0; y < descriptor.init.height; y++)
            {
                for (int x = 0; x < descriptor.init.width; x++, i++)
                {
                    TileStatus tileStatus = tiles[x, y];
                    if (tileStatus == null)
                    {
                        tiles[x, y] = tileStatus = new TileStatus
                        {
                            id = new Vector2Int(x, y),
                            angle = 0
                        };
                    }
                    if (parts != null && i < parts.Length)
                    {
                        string[] statusparts = parts[i].Split(',');
                        if (statusparts.Length == 3)
                        {
                            int tx, ty, angle;
                            if (int.TryParse(statusparts[0], out tx) && int.TryParse(statusparts[1], out ty) && int.TryParse(statusparts[2], out angle))
                            {
                                tileStatus.id.x = tx;
                                tileStatus.id.y = ty;
                                tileStatus.angle = angle;
                            }
                        }
                    }
                }
            }
        }

        void RestoreTileStatuses(bool good = false)
        {
            string tileStatuses = good ? descriptor.state.LastGoodState : descriptor.state.CurrentState;
            ParseStatusString(tileStatuses, ref tileNeighbours);
        }

        void RestoreButtonStatuses(bool good = false)
        {
            string buttonStatuses = good ? descriptor.state.LastGoodButtonState : descriptor.state.CurrentButtonState;
            if (!string.IsNullOrEmpty(buttonStatuses))
            {
                string[] parts = buttonStatuses.Split('.');
                int i = 0;
                for (int y = 0; y < descriptor.init.height - 1; y++)
                {
                    for (int x = 0; x < descriptor.init.width - 1; x++, i++)
                    {
                        int angle;
                        if (int.TryParse(parts[i], out angle))
                        {
                            buttonAngles[x, y] = angle;
                        }
                    }
                }
            }
        }

        void RestoreAll(bool good = false)
        {
            RestoreButtonStatuses(good);
            RestoreTileStatuses(good);
            builder.RestoreTileStatuses(tileNeighbours);
            builder.RestoreButtonStatuses(buttonAngles);
        }
        #endregion

        #region Basic button rotation
        // button rotation
        void RotateTilesWith(Vector2Int buttonId, bool saveAfterRotation = true)
        {
            // update tiles
            TileStatus temp = new TileStatus
            {
                id = new Vector2Int
                {
                    x = tileNeighbours[buttonId.x, buttonId.y].id.x,
                    y = tileNeighbours[buttonId.x, buttonId.y].id.y
                },
                angle = tileNeighbours[buttonId.x, buttonId.y].angle
            };

            tileNeighbours[buttonId.x, buttonId.y].id.x = tileNeighbours[buttonId.x, buttonId.y + 1].id.x;
            tileNeighbours[buttonId.x, buttonId.y].id.y = tileNeighbours[buttonId.x, buttonId.y + 1].id.y;
            tileNeighbours[buttonId.x, buttonId.y].angle = (tileNeighbours[buttonId.x, buttonId.y + 1].angle + 1) % 4;

            tileNeighbours[buttonId.x, buttonId.y + 1].id.x = tileNeighbours[buttonId.x + 1, buttonId.y + 1].id.x;
            tileNeighbours[buttonId.x, buttonId.y + 1].id.y = tileNeighbours[buttonId.x + 1, buttonId.y + 1].id.y;
            tileNeighbours[buttonId.x, buttonId.y + 1].angle = (tileNeighbours[buttonId.x + 1, buttonId.y + 1].angle + 1) % 4;

            tileNeighbours[buttonId.x + 1, buttonId.y + 1].id.x = tileNeighbours[buttonId.x + 1, buttonId.y].id.x;
            tileNeighbours[buttonId.x + 1, buttonId.y + 1].id.y = tileNeighbours[buttonId.x + 1, buttonId.y].id.y;
            tileNeighbours[buttonId.x + 1, buttonId.y + 1].angle = (tileNeighbours[buttonId.x + 1, buttonId.y].angle + 1) % 4;

            tileNeighbours[buttonId.x + 1, buttonId.y].id.x = temp.id.x;
            tileNeighbours[buttonId.x + 1, buttonId.y].id.y = temp.id.y;
            tileNeighbours[buttonId.x + 1, buttonId.y].angle = (temp.angle + 1) % 4;

            // update buttons
            buttonAngles[buttonId.x, buttonId.y] = (buttonAngles[buttonId.x, buttonId.y] + 1) % 4;
            // check if the puzzle is complete after this rotation
            CheckPuzzleComplete();

            if (saveAfterRotation)
            {
                // some modes do not need immediate saving (e. g. shuffle or autosteps)
                SaveAll();
            }
        }

        void RotateButton(PuzzleButtonController.PuzzleButtonArgs buttonArgs, bool saveAfterRotation = true)
        {
            // stop flashing every tile
            List<TileFlashArgs> flashList = new List<TileFlashArgs>();
            for (int y = 0; y < descriptor.init.height; y++)
            {
                for (int x = 0; x < descriptor.init.width; x++)
                {
                    TileFlashArgs flashArgs = new TileFlashArgs
                    {
                        id = new Vector2Int(x, y),
                        type = FlashType.None
                    };
                    flashList.Add(flashArgs);
                }
            }
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleFlashTile, this, flashList);

            // prepare an array of neighbour tiles
            Vector2Int buttonId = buttonArgs.id;
            Vector2Int[] tileIds = new Vector2Int[4];
            int i = 0;
            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < 2; x++, i++)
                {
                    tileIds[i] = new Vector2Int
                    {
                        x = tileNeighbours[buttonId.x + x, buttonId.y + y].id.x,
                        y = tileNeighbours[buttonId.x + x, buttonId.y + y].id.y
                    };
                }
            }

            builder.AttachTilesToButton(buttonId, tileIds);
            RotateTilesWith(buttonId, saveAfterRotation);
            buttonRotated = false;
            builder.RotateButtonWithTiles(buttonArgs);
        }
        #endregion

        #region Reset/shuffle
        // -----------------------------
        // Reset and shuffle methods
        // -----------------------------
        void ResetPuzzle()
        {
            startVictoryScreen = false;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleBusy, this, true);
            GlobalManager.MLevel.ResetLevel(descriptor.init.id);
            RestoreAll();
            StartCoroutine(ShufflePuzzle());
        }

        // initial (or after reset) puzzle shuffle
        // this method can also perform a "precomputed" shuffle using an argument string
        IEnumerator ShufflePuzzle(string shuffleString = "")
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleBusy, this, true);
            PuzzleButtonController.PuzzleButtonArgs buttonArgs = new PuzzleButtonController.PuzzleButtonArgs
            {
                id = new Vector2Int(0, 0),
                fast = 0.5f
            };
            if (string.IsNullOrEmpty(shuffleString))
            {
                // random mode shuffle
                // do not allow the assembled state after the puzzle initialization
                puzzleComplete = true;
                int width = descriptor.init.width;
                int height = descriptor.init.height;
                while (puzzleComplete)
                {
                    int rotationsCount = (int)((Random.value + 0.7f) * width * height);
                    for (int i = 0; i < rotationsCount; i++)
                    {
                        buttonArgs.id.x = (int)(Random.value * (width - 1));
                        buttonArgs.id.y = (int)(Random.value * (height - 1));
                        // do not save puzzle status while shuffling
                        RotateButton(buttonArgs, false);
                        while (!buttonRotated)
                        {
                            yield return null;
                        }
                    }
                }
            }
            else
            {
                // forced mode shuffle
                string[] parts = shuffleString.Split('.');
                int partsCount = parts.Length;
                //Debug.Log("Initial shuffle string: " + partsCount.ToString() + " parts");
                for (int i = 0; i < partsCount; i += 2)
                {
                    buttonArgs.id.x = int.Parse(parts[i]);
                    buttonArgs.id.y = int.Parse(parts[i + 1]);
                    // do not save puzzle status while shuffling
                    RotateButton(buttonArgs, false);
                    while (!buttonRotated)
                    {
                        yield return null;
                    }
                }
            }
            // ok, now it's time to save
            SaveAll();
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleHasShuffled, this);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleBusy, this, false);
            startVictoryScreen = true;
        }
        #endregion

        #region Autostep and autocomplete
        // -------------------------
        // Autostep methods
        // -------------------------
        // flash the good and the bad tiles
        public void FlashBeforeAutostep()
        {
            // restore the puzzle state to the last good state
            SaveAll();
            RestoreAll();
            Vector2Int lastGood, nextGood;
            CheckPuzzleStateComplete(false, out lastGood, out nextGood);
            List<TileFlashArgs> flashList = new List<TileFlashArgs>();
            // flash a tile to from to with the bad color
            TileStatus badTile = tileNeighbours[nextGood.x, nextGood.y];
            flashList.Add(new TileFlashArgs
            {
                id = new Vector2Int(badTile.id.x, badTile.id.y),
                type = FlashType.Bad
            });
            // flash a tile to go to with the good color
            TileStatus goodTile = tileNeighbours[badTile.id.x, badTile.id.y];
            flashList.Add(new TileFlashArgs
            {
                id = new Vector2Int(goodTile.id.x,goodTile.id.y),
                type = FlashType.Good
            });
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleFlashTile, this, flashList);
        }

        void Autostep()
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleBusy, this, true);
            autostepUsed = false;
            StartCoroutine(PerformAutoStep());
            StartCoroutine(WaitForAutostep());
        }

        // this method moves one [next] tile to its 'place' automatically
        [SerializeField]
        protected SFXPlayParams autostepJingle;
        [SerializeField]
        protected FloatRange autostepPitchRange;
        IEnumerator PerformAutoStep()
        {
            Vector2Int lastGood, nextGood;
            CheckPuzzleStateComplete(false, out lastGood, out nextGood);
            TileStatus tileStatus = tileNeighbours[nextGood.x, nextGood.y];
            byte[] solution = AutoStepSolutions.GetSolution(
                descriptor.init.height,
                descriptor.init.width,
                tileStatus.id.y * descriptor.init.width + tileStatus.id.x,
                nextGood.y,
                nextGood.x,
                tileStatus.angle
            );
            if (solution != null)
            {
                descriptor.state.AutocompleteUsed = true;
                PuzzleButtonController.PuzzleButtonArgs buttonArgs = new PuzzleButtonController.PuzzleButtonArgs
                {
                    id = new Vector2Int(0, 0),
                    fast = 0.5f
                };
                for (int i = 0; i < solution.Length; i++)
                {
                    buttonArgs.id.y = (solution[i] >> 4) & 0xf;
                    buttonArgs.id.x = solution[i] & 0xf;
                    RotateButton(buttonArgs, false);
                    while (!buttonRotated)
                    {
                        yield return null;
                    }
                }
                SaveAll();
                // tight vibe sound
                autostepJingle.pitchFactor = autostepPitchRange.Random;
                GlobalManager.MAudio.PlaySFX(autostepJingle);
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleAutostepUsed, this);
            }
        }

        IEnumerator PerformAutocomplete()
        {
            while (!puzzleComplete)
            {
                Autostep();
                while (!autostepUsed)
                {
                    yield return null;
                }
            }
        }

        void Autocomplete()
        {
            StartCoroutine(PerformAutocomplete());
        }
        #endregion

        #region Message handling
        // message handling
        void OnPuzzleAutostepUsed(object sender, InstantMessageArgs args)
        {
            autostepUsed = true;
        }

        IEnumerator WaitForAutostep()
        {
            while (!autostepUsed)
            {
                yield return null;
            }
            if (!puzzleComplete)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleBusy, this, false);
            }
        }

        void OnPuzzlePrepareAutostep(object sender, InstantMessageArgs args)
        {
            FlashBeforeAutostep();
        }

        void OnPuzzleButtonPressed(object sender, InstantMessageArgs args)
        {
            if (!puzzleBusy)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleBusy, this, true);
                Vector2Int buttonId = (Vector2Int)args.arg;
                PuzzleButtonController.PuzzleButtonArgs buttonArgs = new PuzzleButtonController.PuzzleButtonArgs
                {
                    id = buttonId,
                    fast = 1
                };
                RotateButton(buttonArgs);
                StartCoroutine(WaitForButtonPress());
            }
        }

        IEnumerator WaitForButtonPress()
        {
            while (!buttonRotated)
            {
                yield return null;
            }
            if (!puzzleComplete)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleBusy, this, false);
            }
        }

        void OnPuzzleButtonRotated(object sender, InstantMessageArgs args)
        {
            // update the points and coins indicators
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIRotoChipsChanged, this, (decimal)descriptor.state.EarnedPoints);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIRotoCoinsChanged, this, GlobalManager.MStorage.CurrentCoins);

            builder.DetachTilesFromButton((Vector2Int)args.arg);
            buttonRotated = true;
            FlashTilesInPlaces();
        }

        void OnPuzzleTileFlashed(object sender, InstantMessageArgs args)
        {
            if (puzzleComplete && startVictoryScreen)
            {
                startVictoryScreen = false;
                PuzzleCompleteStatus completeStatus = new PuzzleCompleteStatus
                {
                    descriptor = descriptor,
                    firstTime = !descriptor.state.Complete
                };
                // ok, the puzzle is complete, the player has won
                /**/
                descriptor.state.Complete = true;
                /**/
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleComplete, this, completeStatus);
            }
        }

        void OnPuzzleReset(object sender, InstantMessageArgs args)
        {
            ResetPuzzle();
        }

        void OnPuzzleShuffle(object sender, InstantMessageArgs args)
        {
            if (string.IsNullOrEmpty(descriptor.state.CurrentState))
            {
                // the puzzle has never been solved or has just been reset
                string shuffleString = (string)args.arg;
                StartCoroutine(ShufflePuzzle(shuffleString));
            }
        }

        void OnPuzzleAutostep(object sender, InstantMessageArgs args)
        {
            Autostep();
        }

        void OnPuzzleAutocomplete(object sender, InstantMessageArgs args)
        {
            Autocomplete();
        }

        void OnPuzzleBusy(object sender, InstantMessageArgs args)
        {
            puzzleBusy = (bool)args.arg;
        }

        [SerializeField]
        Vector2Int firstButtonId = new Vector2Int(0, 0);
        void OnRedirectFirstTileButtons(object sender, InstantMessageArgs args)
        {
            GlobalManager.MHint.ShowNewHint(HintType.FirstTileButtonsHint, builder.ButtonById(firstButtonId));
        }

        [SerializeField]
        Vector2Int secondButtonId = new Vector2Int(1, 0);
        void OnRedirectSecondTileButtons(object sender, InstantMessageArgs args)
        {
            GlobalManager.MHint.ShowNewHint(HintType.SecondTileButtonsHint, builder.ButtonById(secondButtonId));
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
        #endregion

        #region Logic checking
        // ---------------------
        // logic checking
        // ---------------------
        // this method performs several calculations at once:
        // 1. it checks if the puzzle is assembled, and returns true/false according to the state of completeness
        // 2. it looks for the latest tile which is already in its place, and returns its position in lastGood
        // 3. it looks for the tile which should be placed after the lastGood one, and returns its position in nextGood
        // 4. it alse flashes the already assembled tiles if needed
        bool CheckPuzzleStateComplete(bool flashTiles, out Vector2Int lastGood, out Vector2Int nextGood)
        {
            Vector2Int current = new Vector2Int(0, 0);
            Vector2Int last = new Vector2Int(-1, -1);
            Vector2Int next = new Vector2Int(0, 0);
            nextGood = next;
            bool isComplete = true;
            List<TileFlashArgs> flashList = new List<TileFlashArgs>();
            for (int y = 0; y < descriptor.init.height; y++)
            {
                for (int x = 0; x < descriptor.init.width; x++)
                {
                    TileStatus tileStatus = tileNeighbours[x, y];
                    if (tileStatus.id != current || tileStatus.angle != 0)
                    {
                        isComplete = false;
                        // set the nextGood position
                        if (tileStatus.id.x == next.x && tileStatus.id.y == next.y)
                        {
                            nextGood = new Vector2Int { x = x, y = y };
                        }
                    }
                    else
                    {
                        if (isComplete)
                        {
                            if (flashTiles)
                            {
                                // this tile is in the place, so it should flash
                                flashList.Add(new TileFlashArgs
                                {
                                    id = new Vector2Int(x, y),
                                    type = FlashType.Good
                                });
                            }
                            last = current;
                            // calculate the nextGood parameters
                            if (++next.x >= descriptor.init.width)
                            {
                                next.x = 0;
                                next.y++;
                            }
                        }
                    }
                    current.x++;
                }
                current.x = 0;
                current.y++;
            }
            lastGood = last;
            if (flashTiles)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleFlashTile, this, flashList);
            }
            return isComplete;
        }

        void FlashTilesInPlaces()
        {
            Vector2Int lastGood, nextGood;
            CheckPuzzleStateComplete(true, out lastGood, out nextGood);
        }

        bool CheckPuzzleComplete()
        {
            Vector2Int lastGood, nextGood;
            puzzleComplete = CheckPuzzleStateComplete(false, out lastGood, out nextGood);
            return puzzleComplete;
        }

        // this method checks if the current puzzle state is "better" than the one in parameters
        // this means that the current puzzle state has more first "inplace" tiles than the other
        // if current puzzle state is better than aState, then return 1
        // if current puzzle state is worse than aState, then return -1
        // otherwise, return 0
        int IsPuzzleStateBetter(string aState, out Vector2Int thisGoodTile, out Vector2Int otherGoodTile)
        {
            thisGoodTile = new Vector2Int(-1, -1);
            otherGoodTile = new Vector2Int(-1, -1);
            if (string.IsNullOrEmpty(aState))
            {
                return 1;
            }
            TileStatus[,] otherTiles = new TileStatus[descriptor.init.width, descriptor.init.height];
            ParseStatusString(aState, ref otherTiles);
            bool checkThis = true;
            bool checkOther = true;
            for (int y = 0; y < descriptor.init.height && (checkThis || checkOther); y++)
            {
                for (int x = 0; x < descriptor.init.width && (checkThis || checkOther); x++)
                {
                    if (checkThis)
                    {
                        TileStatus thisTile = tileNeighbours[x, y];
                        if (thisTile.id.x == x && thisTile.id.y == y && thisTile.angle == 0)
                        {
                            thisGoodTile.x = x;
                            thisGoodTile.y = y;
                        }
                        else
                        {
                            checkThis = false;
                        }
                    }
                    if (checkOther)
                    {
                        TileStatus otherTile = otherTiles[x, y];
                        if (otherTile.id.x == x && otherTile.id.y == y && otherTile.angle == 0)
                        {
                            otherGoodTile.x = x;
                            otherGoodTile.y = y;
                        }
                        else
                        {
                            checkOther = false;
                        }
                    }
                }
            }
            int thisId = thisGoodTile.y * descriptor.init.width + thisGoodTile.x;
            int otherId = otherGoodTile.y * descriptor.init.width + otherGoodTile.x;
            return thisId > otherId ? 1 : (thisId > otherId ? -1 : 0);
        }
        #endregion
    }
}
