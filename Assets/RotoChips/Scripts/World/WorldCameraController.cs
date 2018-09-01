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

        public enum ZoomStatus
        {
            ZoomAtMax,      // camera at max distance
            ZoomAtMin,      // camera at min distance
            Middle          // camera is in between
        }
        public ZoomStatus Zoom
        {
            get; private set;
        }

        protected void SetZoomStatus(float zCoord)
        {
            if (zCoord == minDistance)
            {
                Zoom = ZoomStatus.ZoomAtMin;
            }
            else if (zCoord == maxDistance)
            {
                Zoom = ZoomStatus.ZoomAtMax;
            }
            else
            {
                Zoom = ZoomStatus.Middle;
            }
        }

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
                    SetZoomStatus(cameraPosition.z);
                    switch (Zoom)
                    {
                        case ZoomStatus.ZoomAtMin:
                            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldCameraZoomedAtMin, this);
                            break;
                        case ZoomStatus.ZoomAtMax:
                            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldCameraZoomedAtMax, this);
                            break;
                    }
                }
            }
        }

        // this method performs an automatic camera movement (up or down, between cameraMaxDistance (far from the world) and cameraMinDistance (near the world))
        IEnumerator SmoothCameraMover(ZoomStatus zoomStatus)
        {
            Vector3 cameraPosition = controlledCamera.transform.position;
            float startPosition = cameraPosition.z;
            float currentPosition = cameraPosition.z;
            float endPosition = zoomStatus == ZoomStatus.ZoomAtMin ? minDistance : maxDistance;
            float currentTime = 0;
            while (currentPosition != endPosition)
            {
                yield return null;
                currentTime += Time.deltaTime;
                currentPosition = Mathf.Clamp(Mathf.Lerp(startPosition, endPosition, currentTime / smoothMoveDuration), maxDistance, minDistance);
                cameraPosition.z = currentPosition;
                controlledCamera.transform.position = cameraPosition;
                SetZoomStatus(cameraPosition.z);
            }
            GlobalManager.MInstantMessage.DeliverMessage(zoomStatus == ZoomStatus.ZoomAtMin ? InstantMessageType.WorldCameraZoomedAtMin : InstantMessageType.WorldCameraZoomedAtMax, this);
        }

        // message handling
        void OnWorldZoomCamera(object sender, InstantMessageArgs args)
        {
            ZoomStatus zoomStatus = args.type == InstantMessageType.WorldZoomCameraAtMin ? ZoomStatus.ZoomAtMin : ZoomStatus.ZoomAtMax;
            StartCoroutine(SmoothCameraMover(zoomStatus));
        }

        void OnWorldAutoZoomCamera(object sender, InstantMessageArgs args)
        {
            ZoomStatus zoomStatus = Zoom == ZoomStatus.ZoomAtMin ? ZoomStatus.ZoomAtMax : ZoomStatus.ZoomAtMin;
            StartCoroutine(SmoothCameraMover(zoomStatus));
        }

        MessageRegistrator registrator;
        private void Awake()
        {
            controlledCamera = GetComponent<Camera>();
            Vector3 position = controlledCamera.transform.position;
            position.z = Mathf.Clamp(position.z, maxDistance, minDistance);
            controlledCamera.transform.position = position;
            SetZoomStatus(position.z);
            registrator = new MessageRegistrator(
                InstantMessageType.WorldZoomCameraAtMin, (InstantMessageHandler)OnWorldZoomCamera,
                InstantMessageType.WorldZoomCameraAtMax, (InstantMessageHandler)OnWorldZoomCamera,
                InstantMessageType.WorldAutoZoomCamera, (InstantMessageHandler)OnWorldAutoZoomCamera
            );
            registrator.RegisterHandlers();
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

        void ProcessInput()
        {
            switch (GlobalManager.MInput.CheckInput())
            {
                case TouchInput.InputStatus.DoubleMove:
                    ManualZoom(GlobalManager.MInput.MoveDelta);
                    break;
            }
        }

        private void Update()
        {
            ProcessInput();
        }
    }
}
