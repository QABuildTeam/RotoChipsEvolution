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
        GameObject[,] buttons;
        GameObject[,] tiles;

        [SerializeField]
        protected float neutralButtonZ = 0.25f;
        [SerializeField]
        protected float pressedButtonZ = 0.55f;
        [SerializeField]
        protected float releasedButtonZ = -0.05f;
        [SerializeField]
        protected float neutralTileZ = 0f;

        private void Awake()
        {
            descriptor = GlobalManager.MLevel.GetLevelDescriptor(GlobalManager.MStorage.SelectedLevel);
            int width = descriptor.init.width;
            int height = descriptor.init.height;
            buttons = new GameObject[width - 1, height - 1];
            float buttonStartX = -(width - 2) * TileSize / 2;
            Vector3 buttonPosition = new Vector3(buttonStartX, (height - 2) * TileSize / 2, neutralButtonZ);
            for (int y = 0; y < height - 1; y++)
            {
                for (int x = 0; x < width - 1; x++)
                {
                    buttons[x, y] = (GameObject)Instantiate(buttonPrefab);
                    buttonPosition.x += TileSize;
                }
                buttonPosition.x = buttonStartX;
                buttonPosition.y += TileSize;
            }
            tiles = new GameObject[width, height];
            float tileStartX = -(width - 1) * TileSize / 2;
            Vector3 tilePosition = new Vector3(tileStartX, -(height - 1) * TileSize / 2, neutralTileZ);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    GameObject tile = (GameObject)Instantiate(tilePrefab);
                    tilePosition.x += TileSize;
                }
                tilePosition.x = tileStartX;
                tilePosition.y += TileSize;
            }
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
