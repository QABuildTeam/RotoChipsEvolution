/*
 * File:        WorldCameraController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WorldCameraController controls the main camera for the World scene
 * Created:     28.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.World
{
    public class WorldCameraController : MonoBehaviour
    {

        public float maxDistance;
        public float minDistance;
        public float smoothMoveDuration;
        public float scaleFactor = 0.0005f;     // a factor for finger scaling

        protected Camera controlledCamera;

        public void ManualZoom(Vector3 cameraMove)
        {
            if (cameraMove.z != 0)  // that is, a vertical movement is required
            {
                Vector3 cameraPosition = controlledCamera.transform.position;
                float dz = cameraMove.z * cameraPosition.z * scaleFactor;   // positive to zoom in, negative to zoom out
                float previousPosition = cameraPosition.z;
                cameraPosition.z = Mathf.Clamp(cameraPosition.z - dz, maxDistance, minDistance);
                if (cameraPosition.z != previousPosition)
                {
                    controlledCamera.transform.position = cameraPosition;
                    if (cameraPosition.z == maxDistance)
                    {
                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldCameraMovedDown, this);
                    }
                    else if (cameraPosition.z == minDistance)
                    {
                        GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldCameraMovedUp, this);
                    }
                }
            }
        }

        // this method performs an automatic camera movement (up or down, between cameraMaxDistance (far from the world) and cameraMinDistance (near the world))
        IEnumerator SmoothCameraMover(bool up)
        {
            Vector3 cameraPosition = controlledCamera.transform.position;
            float startPosition = cameraPosition.z;
            float currentPosition = cameraPosition.z;
            float endPosition = up ? minDistance : maxDistance;
            float currentTime = 0;
            while (currentPosition != endPosition)
            {
                yield return null;
                currentTime += Time.deltaTime;
                currentPosition = Mathf.Clamp(Mathf.Lerp(startPosition, endPosition, currentTime / smoothMoveDuration), maxDistance, minDistance);
                cameraPosition.z = currentPosition;
                controlledCamera.transform.position = cameraPosition;
            }
            GlobalManager.MInstantMessage.DeliverMessage(up ? InstantMessageType.WorldCameraMovedUp : InstantMessageType.WorldCameraMovedDown, this);
        }

        // message handling
        void OnWorldMoveCamera(object sender, InstantMessageManager.InstantMessageArgs args)
        {
            bool up = args.type == InstantMessageType.WorldMoveCameraUp;
            StartCoroutine(SmoothCameraMover(up));
        }

        void RegisterHandlers()
        {
            if (GlobalManager.Instance != null)
            {
                GlobalManager.MInstantMessage.AddListener(InstantMessageType.WorldMoveCameraUp, OnWorldMoveCamera);
                GlobalManager.MInstantMessage.AddListener(InstantMessageType.WorldMoveCameraDown, OnWorldMoveCamera);
            }
        }

        void UnregisterHandlers()
        {
            if (GlobalManager.Instance != null)
            {
                GlobalManager.MInstantMessage.RemoveListener(InstantMessageType.WorldMoveCameraUp, OnWorldMoveCamera);
                GlobalManager.MInstantMessage.RemoveListener(InstantMessageType.WorldMoveCameraDown, OnWorldMoveCamera);
            }
        }

        private void Awake()
        {
            controlledCamera = GetComponent<Camera>();
            RegisterHandlers();
        }

        private void OnDestroy()
        {
            UnregisterHandlers();
        }

    }
}
