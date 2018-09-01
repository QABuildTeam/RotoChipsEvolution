/*
 * File:        WorldSphereBuilder.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WorldSphereBuilder builds level selectors and clouds above the world globe
 *              It also controls daily rotation of the world globe
 * Created:     30.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.World
{
    public class DailyRotator : MonoBehaviour
    {

        public float rotationDeltaAngle;
        public float selfRotationWaitTime;

        bool rotationEnabled;
        bool isRotating;
        float selfRotationStartTime;

        MessageRegistrator registrator;
        void Awake()
        {
            registrator = new MessageRegistrator(InstantMessageType.WorldRotationEnable, (InstantMessageHandler)OnWorldRotationEnable);
            registrator.RegisterHandlers();
            EnableRotation(true);
        }

        // -----------------------------
        // next methods perform the daily rotation
        //------------------------------

        // a daily rotation is performed in FixedUpdate
        // it also checks if it has been idle for selfRotationWaitTime and starts the rotation again
        void FixedUpdate()
        {
            if (rotationEnabled)
            {
                if (!isRotating)
                {
                    if (Time.time - selfRotationStartTime > selfRotationWaitTime)
                    {
                        isRotating = true;
                    }
                }
                if (isRotating)
                    transform.Rotate(Vector3.up, rotationDeltaAngle, Space.Self);
            }
        }

        void EnableRotation(bool on)
        {
            rotationEnabled = on;
            if (!rotationEnabled)
            {
                isRotating = false;
                selfRotationStartTime = Time.time;
            }
        }

        // message handling
        void OnWorldRotationEnable(object sender, InstantMessageArgs args)
        {
            EnableRotation((bool)args.arg);
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

    }
}
