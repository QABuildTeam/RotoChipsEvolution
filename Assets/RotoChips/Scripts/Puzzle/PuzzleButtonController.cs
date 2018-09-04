/*
 * File:        PuzzleButtonController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class PuzzleButtonController controls any puzzle button at the Puzzle scene
 * Created:     03.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

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

        public void Init(Vector2Int pos, float aNeutralZ, float aPressedZ, float aReleasedZ)
        {
            buttonId = pos;
            animating = false;
            neutralZ = aNeutralZ;
            pressedZ = aPressedZ;
            releasedZ = aReleasedZ;
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
                Debug.Log("PuzzleButtonController: notifying");
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
            return Mathf.Clamp(Mathf.Lerp(delta, start, end), Mathf.Min(start, end), Mathf.Max(start, end));
        }

        IEnumerator AnimatePress(float fastFactor)
        {
            if (!animating)
            {
                animating = true;
                Vector3 position = transform.position;
                float currentTime = 0;
                // press the button
                Debug.Log("Button: pressing for " + (pressTime * fastFactor).ToString() + " seconds");
                while (currentTime < pressTime * fastFactor)
                {
                    yield return null;
                    currentTime += Time.deltaTime;
                    position.z = MoveWithin(currentTime / pressTime, neutralZ, pressedZ);
                    transform.position = position;
                }
                position.z = pressedZ;
                transform.position = position;
                currentTime -= pressTime;
                // release the button
                Debug.Log("Button: releasing for " + (releaseTime * fastFactor).ToString() + " seconds");
                while (currentTime < releaseTime * fastFactor)
                {
                    yield return null;
                    currentTime += Time.deltaTime;
                    position.z = MoveWithin(currentTime / releaseTime, pressedZ, releasedZ);
                    transform.position = position;
                }
                position.z = releasedZ;
                transform.position = position;
                currentTime -= releaseTime;
                // rotate the button
                float rotationAngle = 0;
                Debug.Log("Button: rotating for " + (rotateTime * fastFactor).ToString() + " seconds");
                while (currentTime < rotateTime * fastFactor)
                {
                    yield return null;
                    currentTime += Time.deltaTime;
                    float deltaAngle = 90 * Time.deltaTime;
                    rotationAngle += deltaAngle;
                    transform.Rotate(Vector3.back, deltaAngle, Space.Self);
                }
                rotationAngle -= 90;    // adjust the angle
                if (rotationAngle != 0)
                {
                    transform.Rotate(Vector3.back, -rotationAngle, Space.Self);
                }
                currentTime -= rotateTime;
                // unpress the button
                Debug.Log("Button: unpressing for " + (backTime * fastFactor).ToString() + " seconds");
                while (currentTime < backTime * fastFactor)
                {
                    yield return null;
                    currentTime += Time.deltaTime;
                    position.z = MoveWithin(currentTime / backTime, releasedZ, neutralZ);
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
