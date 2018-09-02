/*
 * File:        PuzzleCameraController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class PuzzleCameraController controls the in-game camera implements general game logic of the World scene
 * Created:     02.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;
using RotoChips.Data;
using RotoChips.Utility;

namespace RotoChips.Puzzle
{
    public class PuzzleCameraController : MonoBehaviour
    {
        // this class controls the puzzle scene camera
        const float eps = 0.001f;                       // floating-point zero

        Camera controlledCamera;
        Camera ControlledCamera
        {
            get
            {
                if (controlledCamera == null)
                {
                    controlledCamera = Camera.main;
                }
                return controlledCamera;
            }
        }
        Vector2 fieldSize;

        //public float TileSize = 2.0f;                   // == 2.0f
        public float moveFactor = (float)-0.0007;       // a factor for finger moving
        public float scaleFactor = (float)0.01;         // a factor for finger scaling

        public float screenMarginPart = 0.1f;           // a part of clear margin between puzzle border and screen border
        LevelDataManager.Descriptor descriptor;

        // Use this for initialization

        FloatRange CameraDistance()
        {
            float aspect = controlledCamera.aspect;
            float fov = controlledCamera.fieldOfView;
            FloatRange distance = new FloatRange
            {
                // minimum (nearest) vertical camera distance from the tile array; negative
                min = -(PuzzleBuilder.TileSize * (1 + screenMarginPart)) / (2 * controlledCamera.aspect),
                // maximum (farthest) vertical camera distance from the tile array; negative
                max = -(Mathf.Max(PuzzleBuilder.TileSize * descriptor.init.height * (1 + screenMarginPart), PuzzleBuilder.TileSize * descriptor.init.width / aspect * (1 + screenMarginPart))) / (2 * fov)
            };  // actually, max is less than min becasuse they are both negative
            return distance;
        }

        void Awake()
        {
            descriptor = GlobalManager.MLevel.GetLevelDescriptor(GlobalManager.MStorage.SelectedLevel); // load player state for current level
            fieldSize = new Vector2(descriptor.init.width * PuzzleBuilder.TileSize, descriptor.init.height * PuzzleBuilder.TileSize);

            controlledCamera.transform.position = new Vector3(0, 0, CameraDistance().max);

        }

        // this method updates the camera position so that the game field is always inside the camera field of view
        void NormalizeCameraField(ref Vector3 cameraPosition)
        {
            float aspect = controlledCamera.aspect;
            float fov = controlledCamera.fieldOfView;
            FloatRange distance = CameraDistance();
            cameraPosition.z = Mathf.Clamp(cameraPosition.z, distance.max, distance.min);

            Vector2 position = cameraPosition;
            float fovTangentY = Mathf.Abs(cameraPosition.z) * Mathf.Tan(Mathf.Deg2Rad * fov / 2);
            Vector2 screenBordersDistance = (Vector2)fieldSize / 2 + new Vector2(fovTangentY * aspect, fovTangentY) * (1 + screenMarginPart);
            Vector2 llCorner = position - screenBordersDistance;
            Vector2 urCorner = position + screenBordersDistance;
            cameraPosition.x = Mathf.Clamp(cameraPosition.x, llCorner.x, urCorner.x);
            cameraPosition.y = Mathf.Clamp(cameraPosition.y, llCorner.y, urCorner.y);
        }

        private void Update()
        {
            Vector3 cameraPosition = controlledCamera.transform.position;
            switch (GlobalManager.MInput.CheckInput())
            {
                case TouchInput.InputStatus.SingleMove:
                case TouchInput.InputStatus.DoubleMove:
                    cameraPosition += GlobalManager.MInput.MoveDelta * moveFactor;
                    NormalizeCameraField(ref cameraPosition);
                    controlledCamera.transform.position = cameraPosition;
                    break;
            }
        }


    }
}
