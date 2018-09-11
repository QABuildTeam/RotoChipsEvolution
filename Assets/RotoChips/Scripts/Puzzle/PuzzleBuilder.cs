/*
 * File:        PuzzleBuilder.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class PuzzleBuilder creates the puzzle field
 * Created:     02.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;
using RotoChips.ImageProcessing;

namespace RotoChips.Puzzle
{
    public class PuzzleBuilder : MonoBehaviour
    {
        public static float TileSize = 2f;

        [SerializeField]
        protected GameObject buttonPrefab;
        [SerializeField]
        protected GameObject tilePrefab;

        LevelDataManager.Descriptor descriptor;
        protected class ButtonCluster
        {
            public GameObject button;
            public GameObject[] tiles;
        }
        ButtonCluster[,] buttons;
        GameObject[,] tiles;

        [SerializeField]
        protected float neutralButtonZ = 0.25f;
        [SerializeField]
        protected float pressedButtonZ = 0.55f;
        [SerializeField]
        protected float releasedButtonZ = -0.05f;
        [SerializeField]
        protected float neutralTileZ = 0f;
        [SerializeField]
        protected float tileGap = 0.1f;

        // special restoration variables
        Quaternion initialButtonRotation;
        Quaternion initialTileRotation;

        private void Awake()
        {
            descriptor = GlobalManager.MLevel.GetDescriptor(GlobalManager.MStorage.SelectedLevel);
            int width = descriptor.init.width;
            int height = descriptor.init.height;
            float puzzleRatioXY = (float)width / (float)height;

            // prepare one STRESS texture for all tiles
            string stressImage = StressImageCreator.StressedFinalImageFile(descriptor.init.id);
            Texture2D tex = new Texture2D(2, 2, TextureFormat.RGB24, false);
            tex.LoadImage(System.IO.File.ReadAllBytes(stressImage));
            // a special factor used in later calculations
            Vector2 texFactor = new Vector2
            {
                x = descriptor.init.finalXYScale > puzzleRatioXY ? puzzleRatioXY / descriptor.init.finalXYScale : 1f,
                y = puzzleRatioXY > descriptor.init.finalXYScale ? descriptor.init.finalXYScale / puzzleRatioXY : 1f
            };
            Vector2 texScale = new Vector2
            {
                x = texFactor.x / (float)width,
                y = texFactor.y / (float)height
            };
            Vector2 texOffsetStart = new Vector2
            {
                x = (1f - texFactor.x) / 2,
                y = (1f - texFactor.y) / 2 + texFactor.y * (float)(height - 1) / (float)height
            };
            Vector2 texOffsetStep = new Vector2
            {
                x = texFactor.x / (float)width,
                y = -texFactor.y / (float)height
            };
            // create buttons
            buttons = new ButtonCluster[width - 1, height - 1];
            float buttonStartX = -(width - 2) * TileSize / 2;
            Vector3 buttonPosition = new Vector3(buttonStartX, (height - 2) * TileSize / 2, neutralButtonZ);
            for (int y = 0; y < height - 1; y++)
            {
                for (int x = 0; x < width - 1; x++)
                {
                    GameObject button = (GameObject)Instantiate(buttonPrefab);
                    initialButtonRotation = button.transform.localRotation;
                    button.transform.position = buttonPosition;
                    button.GetComponent<PuzzleButtonController>().Init(new Vector2Int(x, y), neutralButtonZ, pressedButtonZ, releasedButtonZ);
                    buttons[x, y] = new ButtonCluster
                    {
                        button = button,
                        tiles = new GameObject[4]
                    };
                    buttonPosition.x += TileSize;
                }
                buttonPosition.x = buttonStartX;
                buttonPosition.y -= TileSize;
            }

            // create tiles
            tiles = new GameObject[width, height];
            Vector2 texOffset = texOffsetStart;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    GameObject tile = (GameObject)Instantiate(tilePrefab);
                    initialTileRotation = tile.transform.localRotation;
                    // downscale the tile a bit
                    Vector3 tileScale = tile.transform.localScale;
                    tileScale *= 1 - tileGap / 2;
                    tile.transform.localScale = tileScale;
                    // set up tile's texture and its parameters
                    MeshRenderer meshRenderer = tile.GetComponent<MeshRenderer>();
                    Material[] materials = meshRenderer.materials;
                    materials[0].SetTexture("_MainTex", tex);
                    materials[0].SetTextureScale("_MainTex", texScale);
                    materials[0].SetTextureOffset("_MainTex", texOffset);
                    meshRenderer.materials = materials;
                    tile.GetComponent<TileFlasher>().Init(new Vector2Int(x, y));
                    tiles[x, y] = tile;
                    texOffset.x += texOffsetStep.x;
                }
                texOffset.x = texOffsetStart.x;
                texOffset.y += texOffsetStep.y;
            }
        }

        // restore tiles' positions and angles
        public void RestoreTileStatuses(TileStatus[,] tileNeighbours)
        {
            int width = descriptor.init.width;
            int height = descriptor.init.height;
            float tileStartX = -(width - 1) * TileSize / 2;
            Vector3 tilePosition = new Vector3(tileStartX, (height - 1) * TileSize / 2, neutralTileZ);
            for (int y = 0; y < tileNeighbours.GetUpperBound(1) + 1; y++)
            {
                for (int x = 0; x < tileNeighbours.GetUpperBound(0) + 1; x++)
                {
                    TileStatus tileStatus = tileNeighbours[x, y];
                    GameObject tile = tiles[tileStatus.id.x, tileStatus.id.y];
                    tile.transform.position = tilePosition;
                    tile.transform.localRotation = initialTileRotation;
                    tile.transform.Rotate(Vector3.forward, 90f * tileStatus.angle);
                    tilePosition.x += TileSize;
                }
                tilePosition.y -= TileSize;
                tilePosition.x = tileStartX;
            }
        }

        // restore buttons' angles
        public void RestoreButtonStatuses(int[,] buttonAngles)
        {
            for (int y = 0; y < buttonAngles.GetUpperBound(1) + 1; y++)
            {
                for (int x = 0; x < buttonAngles.GetUpperBound(0) + 1; x++)
                {
                    GameObject button = buttons[x, y].button;
                    button.transform.localRotation = initialButtonRotation;
                    button.transform.Rotate(Vector3.forward, 90f * buttonAngles[x, y]);
                }
            }
        }

        public void AttachTilesToButton(Vector2Int buttonId, Vector2Int[] tileIds)
        {
            ButtonCluster button = buttons[buttonId.x, buttonId.y];
            Transform parent = button.button.transform;
            for (int i = 0; i < tileIds.Length; i++)
            {
                GameObject tile = tiles[tileIds[i].x, tileIds[i].y];
                tile.transform.SetParent(parent);
                button.tiles[i] = tile;
            }
        }

        public void DetachTilesFromButton(Vector2Int buttonId)
        {
            Transform noparent = gameObject.transform;
            GameObject[] subtiles = buttons[buttonId.x, buttonId.y].tiles;
            for (int i = 0; i < subtiles.Length; i++)
            {
                if (subtiles[i] != null)
                {
                    subtiles[i].transform.SetParent(noparent);
                    subtiles[i] = null;
                }
            }
        }

        public void RotateButtonWithTiles(PuzzleButtonController.PuzzleButtonArgs buttonArgs)
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzlePressButton, this, buttonArgs);
        }

    }
}
