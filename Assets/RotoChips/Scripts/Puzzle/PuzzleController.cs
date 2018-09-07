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
        // Use this for initialization
        void Start()
        {
            descriptor = GlobalManager.MLevel.GetDescriptor(GlobalManager.MStorage.SelectedLevel);
            tileNeighbours = new TileStatus[descriptor.init.width, descriptor.init.height];
            buttonAngles = new int[descriptor.init.width - 1, descriptor.init.height - 1];
            builder = GetComponent<PuzzleBuilder>();
            puzzleBusy = false;
            buttonRotated = false;
            ResetTileStatuses();
            ResetButtonStatuses();
            RestoreTileStatuses();
            RestoreButtonStatuses();
            builder.RestoreTileStatuses(tileNeighbours);
            builder.RestoreButtonStatuses(buttonAngles);
            registrator = new MessageRegistrator(
                InstantMessageType.PuzzleButtonPressed, (InstantMessageHandler)OnPuzzleButtonPressed,
                InstantMessageType.PuzzleButtonRotated, (InstantMessageHandler)OnPuzzleButtonRotated,
                InstantMessageType.PuzzleTileFlashed,
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
            if (tileStatuses != "")
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
            if (buttonStatuses != "")
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
        void RotateTilesWith(Vector2Int buttonId)
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

            SaveTileStatuses();
            SaveButtonStatuses();
        }

        void RotateButton(PuzzleButtonController.PuzzleButtonArgs buttonArgs)
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
            RotateTilesWith(buttonId);
            buttonRotated = false;
            builder.RotateButtonWithTiles(buttonArgs);
        }

        void ResetPuzzle()
        {
            descriptor.state.CurrentState = "";
            descriptor.state.CurrentButtonState = "";
            descriptor.state.LastGoodState = "";
            descriptor.state.LastGoodButtonState = "";
            descriptor.state.AutocompleteUsed = false;
            descriptor.state.EarnedPoints = 0;
            ResetTileStatuses();
            ResetButtonStatuses();
            RestoreTileStatuses();
            RestoreButtonStatuses();
            builder.RestoreTileStatuses(tileNeighbours);
            builder.RestoreButtonStatuses(buttonAngles);
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

        }

        void OnPuzzleReset(object sender, InstantMessageArgs args)
        {
            if (!puzzleBusy)
            {
                ResetPuzzle();
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

        // logic checking
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
    }
}
