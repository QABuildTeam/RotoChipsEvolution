﻿/*
 * File:        PuzzleButtonController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class PuzzleButtonController controls any puzzle button at the Puzzle scene
 * Created:     03.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;
using RotoChips.Audio;

namespace RotoChips.Puzzle
{
    public class PuzzleButtonController : MonoBehaviour
    {
        public class PuzzleButtonArgs
        {
            public Vector2Int id;       // button id
            public float fast;          // fast factor (1 - normal speed, 0.5 - twice as fast)
        }

        MessageRegistrator registrator;
        Vector2Int buttonId;
        protected float neutralZ;
        protected float pressedZ;
        protected float releasedZ;
        protected bool animating = false;
        [SerializeField]
        protected float pressTime;
        [SerializeField]
        protected float releaseTime;
        [SerializeField]
        protected float rotateTime;
        [SerializeField]
        protected float backTime;

        protected SFXController sfxController;
        [SerializeField]
        protected float fastThreshold = 0.75f;
        [SerializeField]
        protected int fastSFXIndex;
        [SerializeField]
        protected int slowSFXIndex;

        public void Init(Vector2Int pos, float aNeutralZ, float aPressedZ, float aReleasedZ)
        {
            buttonId = pos;
            animating = false;
            neutralZ = aNeutralZ;
            pressedZ = aPressedZ;
            releasedZ = aReleasedZ;
            sfxController = GetComponent<SFXController>();
            registrator = new MessageRegistrator(
                InstantMessageType.SteadyMouseUpAsButton, (InstantMessageHandler)OnSteadyMouseUpAsButton,
                InstantMessageType.PuzzlePressButton, (InstantMessageHandler)OnPuzzlePressButton
            );
            registrator.RegisterHandlers();
        }

        void OnSteadyMouseUpAsButton(object sender, InstantMessageArgs args)
        {
            if ((GameObject)args.arg == gameObject)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleButtonPressed, this, buttonId);
            }
        }

        void OnPuzzlePressButton(object sender, InstantMessageArgs args)
        {
            PuzzleButtonArgs buttonArgs = (PuzzleButtonArgs)args.arg;
            if (buttonArgs.id == buttonId)
            {
                StartCoroutine(AnimatePress(buttonArgs.fast));
            }
        }

        protected static float MoveWithin(float delta, float start, float end)
        {
            return Mathf.Clamp(Mathf.Lerp(start, end, delta), Mathf.Min(start, end), Mathf.Max(start, end));
        }

        IEnumerator AnimatePress(float fastFactor)
        {
            if (!animating)
            {
                animating = true;
                Vector3 position = transform.position;
                float currentTime = 0;
                // press the button
                float phaseTime = pressTime * fastFactor;
                while (currentTime < phaseTime)
                {
                    yield return null;
                    currentTime += Time.deltaTime;
                    position.z = MoveWithin(currentTime / phaseTime, neutralZ, pressedZ);
                    transform.position = position;
                }
                position.z = pressedZ;
                transform.position = position;
                currentTime -= phaseTime;
                // release the button
                phaseTime = releaseTime * fastFactor;
                while (currentTime < phaseTime)
                {
                    yield return null;
                    currentTime += Time.deltaTime;
                    position.z = MoveWithin(currentTime / phaseTime, pressedZ, releasedZ);
                    transform.position = position;
                }
                position.z = releasedZ;
                transform.position = position;
                currentTime -= phaseTime;
                // emit rotation sound
                if (sfxController != null)
                {
                    if (fastFactor > fastThreshold)
                    {
                        sfxController.Play(slowSFXIndex);
                    }
                    else
                    {
                        sfxController.Play(fastSFXIndex);
                    }
                }
                // rotate the button
                phaseTime = rotateTime * fastFactor;
                float rotationAngle = 0;
                while (currentTime < phaseTime)
                {
                    yield return null;
                    currentTime += Time.deltaTime;
                    float deltaAngle = 90 * Time.deltaTime / phaseTime;
                    rotationAngle += deltaAngle;
                    transform.Rotate(Vector3.forward, deltaAngle, Space.Self);
                }
                rotationAngle -= 90;    // adjust the angle
                if (rotationAngle != 0)
                {
                    transform.Rotate(Vector3.forward, -rotationAngle, Space.Self);
                }
                currentTime -= phaseTime;
                // unpress the button
                phaseTime = backTime * fastFactor;
                while (currentTime < phaseTime)
                {
                    yield return null;
                    currentTime += Time.deltaTime;
                    position.z = MoveWithin(currentTime / phaseTime, releasedZ, neutralZ);
                    transform.position = position;
                }
                position.z = neutralZ;
                transform.position = position;
                animating = false;
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleButtonRotated, this, buttonId);
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

    }
}
