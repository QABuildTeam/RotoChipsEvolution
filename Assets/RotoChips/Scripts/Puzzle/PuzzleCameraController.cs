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
            float aspect = ControlledCamera.aspect;
            float fov = ControlledCamera.fieldOfView;
            float fovFactor = Mathf.Tan(fov * Mathf.PI / (180 * 2));
            FloatRange distance = new FloatRange
            {
                // minimum (nearest) vertical camera distance from the tile array; negative
                min = -(PuzzleBuilder.TileSize * (1 + screenMarginPart)) / (2 * fovFactor),
                // maximum (farthest) vertical camera distance from the tile array; negative
                max = -(Mathf.Max(PuzzleBuilder.TileSize * descriptor.init.height * (1 + screenMarginPart), PuzzleBuilder.TileSize * descriptor.init.width / aspect * (1 + screenMarginPart))) / (2 * fovFactor)
            };  // actually, max is less than min becasuse they are both negative
            return distance;
        }

        void Awake()
        {
            descriptor = GlobalManager.MLevel.GetDescriptor(GlobalManager.MStorage.SelectedLevel); // load player state for current level
            fieldSize = new Vector2(descriptor.init.width * PuzzleBuilder.TileSize, descriptor.init.height * PuzzleBuilder.TileSize);

            ControlledCamera.transform.position = new Vector3(0, 0, CameraDistance().max);

        }

        // this method updates the camera position so that the game field is always inside the camera field of view
        void NormalizeCameraField(ref Vector3 cameraPosition)
        {
            float aspect = ControlledCamera.aspect;
            float fov = ControlledCamera.fieldOfView;
            FloatRange distance = CameraDistance();
            cameraPosition.z = Mathf.Clamp(cameraPosition.z, distance.max, distance.min);

            // puzzle field is centered at (0,0)
            float fovTangentY = Mathf.Abs(cameraPosition.z) * Mathf.Tan(Mathf.Deg2Rad * fov / 2);
            Vector2 screenBordersDistance = new Vector2(fovTangentY * aspect, fovTangentY);
            Vector2 halfFieldSize = (Vector2)fieldSize * (1 + screenMarginPart) / 2;
            Vector2 llCorner = -halfFieldSize + screenBordersDistance;
            Vector2 urCorner = halfFieldSize - screenBordersDistance;
            cameraPosition.x = Mathf.Clamp(cameraPosition.x, Mathf.Min(0, llCorner.x), Mathf.Max(0, urCorner.x));
            cameraPosition.y = Mathf.Clamp(cameraPosition.y, Mathf.Min(0, llCorner.y), Mathf.Max(0, urCorner.y));
        }

        private void Update()
        {
            Vector3 cameraPosition = controlledCamera.transform.position;
            switch (GlobalManager.MInput.CheckInput())
            {
                case TouchInput.InputStatus.SingleMove:
                    cameraPosition -= GlobalManager.MInput.MoveDelta * moveFactor;
                    NormalizeCameraField(ref cameraPosition);
                    ControlledCamera.transform.position = cameraPosition;
                    break;
                case TouchInput.InputStatus.DoubleMove:
                    cameraPosition -= GlobalManager.MInput.MoveDelta * scaleFactor;
                    NormalizeCameraField(ref cameraPosition);
                    ControlledCamera.transform.position = cameraPosition;
                    break;
            }
        }


    }
}
