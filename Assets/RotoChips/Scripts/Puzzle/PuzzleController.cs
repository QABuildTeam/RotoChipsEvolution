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

namespace RotoChips.Puzzle
{
    [System.Serializable]
    public class TileStatus
    {
        public Vector2Int id;
        public int angle;
    }
    public class PuzzleController : MonoBehaviour
    {
        MessageRegistrator registrator;
        LevelDataManager.Descriptor descriptor;
        TileStatus[,] tileNeighbours;
        int[,] buttonAngles;

        PuzzleBuilder builder;
        bool puzzleBusy;
        bool buttonRotated;
        bool puzzleComplete;
        // Use this for initialization
        void Start()
        {
            descriptor = GlobalManager.MLevel.GetDescriptor(GlobalManager.MStorage.SelectedLevel);
            tileNeighbours = new TileStatus[descriptor.init.width, descriptor.init.height];
            buttonAngles = new int[descriptor.init.width - 1, descriptor.init.height - 1];
            builder = GetComponent<PuzzleBuilder>();
            puzzleBusy = false;
            buttonRotated = false;
            puzzleComplete = false;
            ResetTileStatuses();
            ResetButtonStatuses();
            RestoreTileStatuses();
            RestoreButtonStatuses();
            builder.RestoreTileStatuses(tileNeighbours);
            builder.RestoreButtonStatuses(buttonAngles);
            registrator = new MessageRegistrator(
                InstantMessageType.PuzzleButtonPressed, (InstantMessageHandler)OnPuzzleButtonPressed,
                InstantMessageType.PuzzleButtonRotated, (InstantMessageHandler)OnPuzzleButtonRotated,
                InstantMessageType.PuzzleTileFlashed, (InstantMessageHandler)OnPuzzleTileFlashed,
                InstantMessageType.PuzzleShuffle, (InstantMessageHandler)OnPuzzleShuffle,
                InstantMessageType.PuzzleReset, (InstantMessageHandler)OnPuzzleReset
            );
            registrator.RegisterHandlers();
        }

        // tiles and buttons statuses handling
        void ResetTileStatuses()
        {
            for (int y = 0; y < descriptor.init.height; y++)
            {
                for (int x = 0; x < descriptor.init.width; x++)
                {
                    tileNeighbours[x, y] = new TileStatus
                    {
                        id = new Vector2Int
                        {
                            x = x,
                            y = y
                        },
                        angle = 0
                    };
                }
            }
        }

        void ResetButtonStatuses()
        {
            for (int y = 0; y < descriptor.init.height - 1; y++)
            {
                for (int x = 0; x < descriptor.init.width - 1; x++)
                {
                    buttonAngles[x, y] = 0;
                }
            }
        }

        void SaveTileStatuses()
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
            descriptor.state.CurrentState = statusString;
        }

        void SaveButtonStatuses()
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
            descriptor.state.CurrentButtonState = statusString;
        }

        void RestoreTileStatuses()
        {
            string tileStatuses = descriptor.state.CurrentState;
            if (!string.IsNullOrEmpty(tileStatuses))
            {
                string[] parts = tileStatuses.Split('.');
                int i = 0;
                for (int y = 0; y < descriptor.init.height; y++)
                {
                    for (int x = 0; x < descriptor.init.width; x++, i++)
                    {
                        string[] statusparts = parts[i].Split(',');
                        if (statusparts.Length == 3)
                        {
                            TileStatus tileStatus = tileNeighbours[x, y];
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

        void RestoreButtonStatuses()
        {
            string buttonStatuses = descriptor.state.CurrentButtonState;
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

        // button rotation
        void RotateTilesWith(Vector2Int buttonId, bool saveAfterRotation=true)
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
                SaveTileStatuses();
                SaveButtonStatuses();
            }
        }

        void RotateButton(PuzzleButtonController.PuzzleButtonArgs buttonArgs, bool saveAfterRotation = true)
        {
            // stop flashing
            TileFlashArgs flashArgs = new TileFlashArgs
            {
                maxId = new Vector2Int
                {
                    x = descriptor.init.width,
                    y = descriptor.init.height
                },
                type = FlashType.None
            };
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleFlashTile, this, flashArgs);

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
                    Debug.Log("Attaching tile " + tileIds[i].ToString());
                }
            }

            builder.AttachTilesToButton(buttonId, tileIds);
            RotateTilesWith(buttonId, saveAfterRotation);
            buttonRotated = false;
            builder.RotateButtonWithTiles(buttonArgs);
        }

        void ResetPuzzle()
        {
            descriptor.state.CurrentState = string.Empty;
            descriptor.state.CurrentButtonState = string.Empty;
            descriptor.state.LastGoodState = string.Empty;
            descriptor.state.LastGoodButtonState = string.Empty;
            descriptor.state.AutocompleteUsed = false;
            descriptor.state.EarnedPoints = 0;
            ResetTileStatuses();
            ResetButtonStatuses();
            RestoreTileStatuses();
            RestoreButtonStatuses();
            builder.RestoreTileStatuses(tileNeighbours);
            builder.RestoreButtonStatuses(buttonAngles);
            StartCoroutine(ShufflePuzzle());
        }

        // initial (or after reset) puzzle shuffle
        // this method can also perform a "precomputed" shuffle using an argument string
        IEnumerator ShufflePuzzle(string shuffleString = "")
        {
            puzzleBusy = true;
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
                char[] delimiters = { '.' };
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
            SaveTileStatuses();
            SaveButtonStatuses();
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleHasShuffled, this);
            puzzleBusy = false;
        }

        // message handling
        void OnPuzzleButtonPressed(object sender, InstantMessageArgs args)
        {
            if (!puzzleBusy)
            {
                puzzleBusy = true;
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
            puzzleBusy = false;
        }

        void OnPuzzleButtonRotated(object sender, InstantMessageArgs args)
        {
            builder.DetachTilesFromButton((Vector2Int)args.arg);
            buttonRotated = true;
            CheckTilesInPlaces();
        }

        void OnPuzzleTileFlashed(object sender, InstantMessageArgs args)
        {
            if (puzzleComplete)
            {
                // ok, the puzzle is complete, the player has won
            }
        }

        void OnPuzzleReset(object sender, InstantMessageArgs args)
        {
            if (!puzzleBusy)
            {
                ResetPuzzle();
            }
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

        void OnGUIWhiteCurtainFaded(object sender, InstantMessageArgs args)
        {
            bool up = (bool)args.arg;
            if (!up)
            {
                if (descriptor.state.CurrentState == "")
                {
                    // the puzzle has never been solved or has just been reset
                    StartCoroutine(ShufflePuzzle());
                }
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

        // ---------------------
        // logic checking
        // ---------------------
        void CheckTilesInPlaces()
        {
            Vector2Int proper = new Vector2Int(0, 0);
            bool idOk = true;
            for (int y = 0; y < descriptor.init.height; y++)
            {
                for (int x = 0; x < descriptor.init.width; x++)
                {
                    TileStatus tileStatus = tileNeighbours[x, y];
                    if (tileStatus.id != proper || tileStatus.angle != 0)
                    {
                        idOk = false;
                        break;
                    }
                    proper.x++;
                }
                if (!idOk)
                {
                    break;
                }
                proper.x = 0;
                proper.y++;
            }
            // all tiles before the proper should flash good color
            TileFlashArgs flashArgs = new TileFlashArgs
            {
                maxId = proper,
                type = FlashType.Good
            };
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleFlashTile, this, flashArgs);
        }

        void CheckPuzzleComplete()
        {
            for (int y = 0; y < descriptor.init.height; y++)
            {
                for (int x = 0; x < descriptor.init.width; x++)
                {
                    TileStatus tile = tileNeighbours[x, y];
                    if (tile.id.x != x || tile.id.y != y || tile.angle != 0)
                    {
                        puzzleComplete = false;
                        return;
                    }
                }
            }
            puzzleComplete = true;
        }

    }
}
