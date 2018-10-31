/*
 * File:        TouchInput.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class TouchInput processes touch input from the player
 * Created:     24.08.2018
 */
using UnityEngine;
using System.Collections;
using RotoChips.Generic;

namespace RotoChips.Management
{
    public class TouchInput : GenericManager
    {

        public enum InputStatus
        {
            None,
            SinglePress,
            SingleMove,
            SingleRelease,
            DoublePress,
            DoubleMove,
            DoubleRelese,
            Undefined
        };

        readonly float jitterDistance = 1f;  // need to obtain the value experimentally

        bool singleTouchPressed;
        float initialTwoTouchDistance;
        Vector2 startAngleVector;

        public Vector2 TouchPoint
        {
            get; private set;
        }

        public Vector3 MoveDelta
        {
            get; private set;
        }

        public float AngleDelta
        {
            get; private set;
        }

        protected class InputData
        {
            public TouchPhase phase;
            public Vector2 position;
            public Vector2 delta;
        }

        InputData[] input;
        int touchesDetected;

        public override void MakeInitial()
        {
            input = new InputData[2]
            {
                new InputData(),
                new InputData()
            };
            touchesDetected = 0;
            singleTouchPressed = false;
            TouchPoint = Vector2.zero;
            MoveDelta = Vector3.zero;
            AngleDelta = 0f;
            initialTwoTouchDistance = 0;
            startAngleVector = Vector2.zero;
            base.MakeInitial();
        }

        // this method checks user's input
        protected InputStatus ProcessInput()
        {
            touchesDetected = 0;
            if (Input.mousePresent)
            {
                Vector2 position = Input.mousePosition;
                if (Input.GetMouseButtonDown(1))        // right mouse button pressed
                {
                    input[1].phase = TouchPhase.Began;
                    input[1].position = position;
                    input[0].position = -position;
                    input[1].delta = input[0].delta = Vector2.zero;
                    touchesDetected = 2;
                }
                else if (Input.GetMouseButtonUp(1))    // right mouse button released
                {
                    input[1].phase = TouchPhase.Ended;
                    input[1].delta = position - input[1].delta;
                    input[1].position = position;
                    touchesDetected = 2;
                }
                else if (Input.GetMouseButton(1))      // right mouse button being held
                {
                    if (position != input[1].position)
                    {
                        input[1].phase = TouchPhase.Moved;
                        input[1].delta = position - input[1].delta;
                        input[1].position = position;
                    }
                    touchesDetected = 2;
                }
                else if (Input.GetMouseButtonDown(0))   // left mouse button pressed
                {
                    input[0].phase = TouchPhase.Began;
                    input[1].phase = TouchPhase.Canceled;
                    input[0].position = position;
                    input[0].delta = Vector2.zero;
                    touchesDetected = 1;
                }
                else if (Input.GetMouseButtonUp(0))     // left mouse button released
                {
                    input[0].phase = TouchPhase.Ended;
                    input[1].phase = TouchPhase.Canceled;
                    input[0].delta = position - input[0].position;
                    input[0].position = position;
                    touchesDetected = 1;
                }
                else if (Input.GetMouseButton(0))      // left mouse button being held
                {
                    if (position != input[0].position)
                    {
                        input[0].phase = TouchPhase.Moved;
                        input[0].delta = position - input[0].position;
                        input[0].position = position;
                    }
                    touchesDetected = 1;
                }
            }
            else
            {
                touchesDetected = Input.touchCount;
                for (int i = 0; i < touchesDetected; i++)
                {
                    input[i].phase = Input.GetTouch(i).phase;
                    input[i].position = Input.GetTouch(i).position;
                    input[i].delta = Input.GetTouch(i).deltaPosition;
                }
            }
            switch (touchesDetected)
            {
                case 0:
                    if (singleTouchPressed)
                    {
                        singleTouchPressed = false;
                        return InputStatus.SingleRelease;
                    }
                    break;

                case 1:
                    switch (input[0].phase)
                    {
                        case TouchPhase.Began:
                            if (!singleTouchPressed)
                            {
                                singleTouchPressed = true;
                                TouchPoint = input[0].position;
                                return InputStatus.SinglePress;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (singleTouchPressed)
                            {
                                // try to work around the 3D-touch bug
                                Vector2 newTouchPoint = input[0].position;
                                if (Vector2.Distance(newTouchPoint, TouchPoint) >= jitterDistance)
                                {
                                    TouchPoint = newTouchPoint;
                                    MoveDelta = new Vector3(-input[0].delta.x, -input[0].delta.y, 0);
                                    return InputStatus.SingleMove;
                                }
                            }
                            break;

                        case TouchPhase.Ended:
                            if (singleTouchPressed)
                            {
                                singleTouchPressed = false;
                                return InputStatus.SingleRelease;
                            }
                            break;
                    }
                    break;

                default:
                    // only two touches are processed
                    if (input[1].phase == TouchPhase.Began)
                    {
                        initialTwoTouchDistance = Vector2.Distance(input[0].position, input[1].position);
                        startAngleVector = input[1].position - input[0].position;
                        return InputStatus.DoublePress;
                    }
                    else if (input[1].phase == TouchPhase.Moved || input[0].phase == TouchPhase.Moved)
                    {
                        // either finger is moved
                        float dist = (Vector2.Distance(input[0].position, input[1].position) - initialTwoTouchDistance);
                        MoveDelta = new Vector3(0f, 0f, dist);
                        Vector2 endAngleVector = input[1].position - input[0].position;
                        AngleDelta = Vector2.Angle(endAngleVector, startAngleVector) * Mathf.Sign(Vector3.Cross(startAngleVector, endAngleVector).z);
                        startAngleVector = endAngleVector;
                        return InputStatus.DoubleMove;
                    }
                    break;
            }
            return InputStatus.None;

        }

        InputStatus inputStatus = InputStatus.None;
        private void Update()
        {
            if (Initialized != Status.None)
            {
                inputStatus = ProcessInput();
            }
        }

        public InputStatus CheckInput()
        {
            return inputStatus;
        }
    }
}
