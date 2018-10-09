/*
 * File:        WorldSphereController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WorldSphereController controls the world sphere rotation by the player's input on the World scene
 * Created:     31.08.2018
 */
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.World
{
    public class WorldSphereController : GenericMessageHandler
    {

        [SerializeField]
        protected float rotationTime;

        protected override void AwakeInit()
        {
            registrator.Add(
                new MessageRegistrationTuple { type = InstantMessageType.GUIObjectPressedAsButton, handler = OnGUIObjectPressedAsButton },
                new MessageRegistrationTuple { type = InstantMessageType.WorldRotateToObject, handler = OnWorldRotateToObject },
                new MessageRegistrationTuple { type = InstantMessageType.WorldRotationEnable, handler = OnWorldRotationEnable }
            );
        }

        void Start()
        {
        }


        // message handling
        void OnGUIObjectPressedAsButton(object sender, InstantMessageArgs args)
        {
            if ((GameObject)args.arg == gameObject)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldGlobePressed, this);
            }
        }

        // this method rotates the globe such that a particular object on it is placed right before the player's view
        IEnumerator RotateToSphereZero(GameObject rotateTarget)
        {
            // this method rotates the world sphere so that the selected spike would stop right before the player's eyes
            Vector3 pos = rotateTarget.transform.position;  // a vector that points to rotateTarget
            Vector3 viewer = Vector3.back;                  // a vector that points to the player
            float angle = Vector3.Angle(pos, viewer);       // a flat angle between start (pos) and end (viewer) vectors
            if (Math.Abs(angle) > 0.5f)                     // do not rotate if the angle is too small
            {
                Vector3 cross = Vector3.Cross(pos, viewer); // cross product of pos and viewer
                float currentTime = 0;
                float currentAngle = 0;
                while (currentTime < rotationTime)
                {
                    yield return null;
                    currentTime += Time.deltaTime;
                    float deltaAngle = angle * Time.deltaTime;
                    currentAngle += deltaAngle;
                    transform.Rotate(cross, deltaAngle, Space.World);
                    Debug.DrawRay(viewer, rotateTarget.transform.position, Color.red);
                }
                currentAngle -= angle;
                if (currentAngle != 0)
                {
                    transform.Rotate(cross, -currentAngle, Space.World);
                }
            }
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotatedToObject, this, rotateTarget);
        }

        // message handling
        void OnWorldRotateToObject(object sender, InstantMessageArgs args)
        {
            GameObject rotateTarget = (GameObject)args.arg;
            if (rotateTarget != null)
            {
                StartCoroutine(RotateToSphereZero(rotateTarget));
            }
        }

        void OnWorldRotationEnable(object sender, InstantMessageArgs args)
        {
            rotationEnabled = (bool)args.arg;
        }

        [SerializeField]
        protected float worldRotateFactor;
        bool rotationEnabled;
        void EnableRotation(bool on)
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotationEnable, this, on);
        }

        void ProcessInput()
        {
            switch (GlobalManager.MInput.CheckInput())
            {
                case TouchInput.InputStatus.SinglePress:
                case TouchInput.InputStatus.DoublePress:
                    if (rotationEnabled)
                    {
                        EnableRotation(false);
                        EnableRotation(true);
                    }
                    break;

                case TouchInput.InputStatus.SingleMove:
                    if (rotationEnabled)
                    {
                        // rotate the world to the direction of a finger/mouse move
                        EnableRotation(false);
                        Vector3 moveDelta = GlobalManager.MInput.MoveDelta;
                        float cameraDistance = Camera.main.transform.position.z;
                        Vector3 rotateDelta = new Vector3(moveDelta.y, -moveDelta.x, 0) * cameraDistance * worldRotateFactor;
                        transform.Rotate(rotateDelta, Space.World);
                        EnableRotation(true);
                    }
                    break;

                case TouchInput.InputStatus.DoubleMove:
                    if (rotationEnabled)
                    {
                        // rotate the world around z-axis
                        EnableRotation(false);
                        transform.Rotate(new Vector3(0, 0, GlobalManager.MInput.AngleDelta), Space.World);
                        EnableRotation(true);
                    }
                    break;

            }
        }
        // Update is called once per frame
        void Update()
        {
            ProcessInput();
        }

    }
}
