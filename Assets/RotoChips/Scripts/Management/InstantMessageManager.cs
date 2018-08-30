/*
 * File:        InstantMessageManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class InstantMessageManager implements a communicating protocol for exchanging messages between _different_ game subsystems
 *              The message is dispatched immediately upon receival; no queueing is performed
 * Created:     24.08.2018
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Generic;

namespace RotoChips.Management
{
    // basic yet important game event types
    public enum InstantMessageType
    {
        Unknown,

        // World scene messages
        WorldSelectStarted,             // Notification: Method Start() of the scene World has just finished its execution
        WorldSelectButtonPressed,       // Notification: Some cube-like selector above the world globe has just been pressed (either by mouse or by finger)
        WorldSelectSatellitePressed,    // Notification: Satellite object above the world globe has just been pressed (either by mouse or by finger)
        WorldSelectRotoChipsPressed,    // Notification: RotoChips indicator on the scene World has just been pressed (either by mouse or by finger)
        WorldSelectRotoCoinsPressed,    // Notification: RotoCoins indicator on the scene World has just been pressed (either by mouse or by finger)
        WorldRotationEnable,            // Command: Enable (argument = true) or disable (argument = false) the rotation of the world globe and the satellite
        WorldMoveCameraUp,              // Command: Move the camera above the world globe up (increase distance)
        WorldMoveCameraDown,            // Command: Move the camera above the world globe down (decrease distance)
        WorldCameraMovedUp,             // Notification: The camera above the world globe has just moved to the farthest position above the latter
        WorldCameraMovedDown,           // Notification: The camera above the world globe has just moved to the nearest position above the latter

        // Puzzle scene messages
        PuzzleStarted,                  // Notification: Method Start() of the scene Puzzle has just finished its execution
        PuzzleButtonPressed,            // Notification: Some puzzle button has just been pressed (either by mouse or by finger)
        PuzzleButtonRotated,            // Notification: A puzzle button and a quad of its neighbour square tiles have just rotated a quarter clockwise
        PuzzleRotoChipsPressed,         // Notification: RotoChips indicator on the scene Puzzle has just been pressed (either by mouse or by finger)
        PuzzleRotoCoinsPressed,         // Notification: RotoCoins indicator on the scene Puzzle has just been pressed (either by mouse or by finger)

        // GUI messages
        GUIBackButtonPressed,           // Notification: Back button has just been pressed
        GUIRestartButtonPressed,        // Notification: Restart button has just been pressed
        GUIViewButtonPressed,           // Notification: View button has just been pressed
        GUIMagicButtonPressed,          // Notification: Magic button has just been pressed
        GUIFadeOutWhiteCurtain,         // Command: Fade the entire screen out to white
        GUIWhiteCurtainFaded,           // Notification: The entire screen has just faded to white

        // Global
        LanguageChanged                 // System language has changed
    }

    public class InstantMessageManager : GenericManager
    {

        // a generic class of game event arguments
        // arg field can be anything derived from System.Object
        public class InstantMessageArgs : EventArgs
        {
            public InstantMessageType type;
            public object arg;
        }

        protected Dictionary<InstantMessageType, EventHandler<InstantMessageArgs>> handlerRegistry;

        public override void MakeInitial()
        {
            Initialized = Status.None;
            InitRegistry();
            base.MakeInitial();
        }

        void InitRegistry()
        {
            handlerRegistry = new Dictionary<InstantMessageType, EventHandler<InstantMessageArgs>>();
            foreach (InstantMessageType type in Enum.GetValues(typeof(InstantMessageType)))
            {
                handlerRegistry.Add(type, null);
            }
        }

        public void ClearRegistry()
        {
            if (handlerRegistry != null)
            {
                foreach (InstantMessageType type in handlerRegistry.Keys)
                {
                    EventHandler<InstantMessageArgs> messageHandler = handlerRegistry[type];
                    if (messageHandler != null)
                    {
                        foreach (EventHandler<InstantMessageArgs> handler in messageHandler.GetInvocationList())
                        {
                            messageHandler -= handler;
                        }
                    }
                    handlerRegistry.Remove(type);
                }
            }
        }

        public void AddListener(InstantMessageType type, EventHandler<InstantMessageArgs> handler)
        {
            EventHandler<InstantMessageArgs> messageHandler;
            if (handlerRegistry.TryGetValue(type, out messageHandler))
            {
                if (messageHandler == null)
                {
                    //Debug.Log("Setting new handler for " + type.ToString() + ": " + handler.Method.Name);
                    handlerRegistry[type] = handler;
                }
                else
                {
                    //Debug.Log("Adding new handler for " + type.ToString() + ": " + handler.Method.Name);
                    handlerRegistry[type] += handler;
                }
            }
        }

        public void RemoveListener(InstantMessageType type, EventHandler<InstantMessageArgs> handler)
        {
            EventHandler<InstantMessageArgs> messageHandler;
            if (handlerRegistry.TryGetValue(type, out messageHandler))
            {
                if (messageHandler != null)
                {
                    //Debug.Log("Removing a handler for " + type.ToString() + ": " + handler.Method.Name);
                    handlerRegistry[type] -= handler;
                }
            }
        }

        public void DeliverMessage(InstantMessageType aType, object sender, object anArg = null)
        {
            EventHandler<InstantMessageArgs> messageHandler;
            if (handlerRegistry.TryGetValue(aType, out messageHandler))
            {
                if (messageHandler != null)
                {
                    messageHandler(sender, new InstantMessageArgs { type = aType, arg = anArg });
                }
            }
        }

        private void OnDestroy()
        {
            //ClearRegistry();
        }

    }
}
