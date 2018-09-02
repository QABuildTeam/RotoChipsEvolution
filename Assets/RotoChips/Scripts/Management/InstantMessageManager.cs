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
        WorldStarted,                   // Notification: Method Start() of the scene World has just finished its execution
        WorldSelectorPressed,           // Notification: Some cube-like selector above the world globe has just been pressed (either by mouse or by finger)
        WorldSatellitePressed,          // Notification: Satellite object above the world globe has just been pressed (either by mouse or by finger)
        WorldRotoChipsPressed,          // Notification: RotoChips indicator on the scene World has just been pressed (either by mouse or by finger)
        WorldRotoCoinsPressed,          // Notification: RotoCoins indicator on the scene World has just been pressed (either by mouse or by finger)
        WorldGlobePressed,              // Notification: world globe has just been pressed
        WorldRotationEnable,            // Command: Enable (argument = true) or disable (argument = false) the rotation of the world globe and the satellite
        WorldRotateToObject,            // Command: Rotate the world globe so that the particular object is set just before the player's view
        WorldRotatedToObject,           // Notification: The world globe has just rotated to the particular object
        WorldZoomCameraAtMin,           // Command: Move the camera above the world globe down (decrease distance)
        WorldZoomCameraAtMax,           // Command: Move the camera above the world globe up (increase distance)
        WorldAutoZoomCamera,            // Command: zoom the camera in or out
        WorldCameraZoomedAtMin,         // Notification: The camera above the world globe has just moved to the nearest position above the latter
        WorldCameraZoomedAtMax,         // Notification: The camera above the world globe has just moved to the farthest position above the latter

        // Puzzle scene messages
        PuzzleStarted,                  // Notification: Method Start() of the scene Puzzle has just finished its execution
        PuzzleButtonPressed,            // Notification: Some puzzle button has just been pressed (either by mouse or by finger)
        PuzzleButtonRotated,            // Notification: A puzzle button and a quad of its neighbour square tiles have just rotated a quarter clockwise
        PuzzleRotoChipsPressed,         // Notification: RotoChips indicator on the scene Puzzle has just been pressed (either by mouse or by finger)
        PuzzleRotoCoinsPressed,         // Notification: RotoCoins indicator on the scene Puzzle has just been pressed (either by mouse or by finger)
        PuzzleFlashTile,                // Command: Flash the tiles which are in their places
        PuzzleTileFlashed,              // Notification: tiles flashed

        // GUI messages
        GUIBackButtonPressed,           // Notification: Back button has just been pressed
        GUIRestartButtonPressed,        // Notification: Restart button has just been pressed
        GUIViewButtonPressed,           // Notification: View button has just been pressed
        GUIMagicButtonPressed,          // Notification: Magic button has just been pressed
        GUIFadeOutWhiteCurtain,         // Command: Fade the entire screen out to white
        GUIWhiteCurtainFaded,           // Notification: The entire screen has just faded to white

        // General
        LanguageChanged,                // Notification: System language has changed
        SteadyMouseUpAsButton,          // Notification: A pointer (mouse/touch) has been pressed and released on an object without moving
        RotoChipsChanged,               // Notification: Per puzzle/total amount of RotoChips has changed
        RotoCoinsChanged                // Notification: Amout of RotoCoins has changed
    }

    // a generic class of game event arguments
    // arg field can be anything derived from System.Object
    public class InstantMessageArgs : EventArgs
    {
        public InstantMessageType type;
        public object arg;
    }
    public delegate void InstantMessageHandler(object sender, InstantMessageArgs args);

    public class InstantMessageManager : GenericManager
    {

        protected Dictionary<InstantMessageType, InstantMessageHandler> handlerRegistry;

        public override void MakeInitial()
        {
            Initialized = Status.None;
            InitRegistry();
            base.MakeInitial();
        }

        void InitRegistry()
        {
            handlerRegistry = new Dictionary<InstantMessageType, InstantMessageHandler>();
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
                    InstantMessageHandler messageHandler = handlerRegistry[type];
                    if (messageHandler != null)
                    {
                        foreach (InstantMessageHandler handler in messageHandler.GetInvocationList())
                        {
                            messageHandler -= handler;
                        }
                    }
                    handlerRegistry.Remove(type);
                }
            }
        }

        public void AddListener(InstantMessageType type, InstantMessageHandler handler)
        {
            InstantMessageHandler messageHandler;
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

        public void RemoveListener(InstantMessageType type, InstantMessageHandler handler)
        {
            InstantMessageHandler messageHandler;
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
            InstantMessageHandler messageHandler;
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

    // utility class for registering and unregistering message handlers in classes
    public class MessageRegistrator
    {
        protected class RegistrationTuple
        {
            public InstantMessageType type;
            public InstantMessageHandler handler;
        }

        List<RegistrationTuple> registry;

        public MessageRegistrator(params object[] regparams)
        {
            registry = new List<RegistrationTuple>();
            for (int i = 0; i < regparams.Length; i += 2)
            {
                InstantMessageType regtype = (InstantMessageType)regparams[i];
                if (i + 1 < regparams.Length)
                {
                    InstantMessageHandler reghandler = (InstantMessageHandler)regparams[i + 1];
                    if (reghandler != null)
                    {
                        registry.Add(new RegistrationTuple
                        {
                            type = regtype,
                            handler = reghandler
                        });
                    }
                }
                else
                {
                    break;
                }
            }

        }

        public void RegisterHandlers()
        {
            foreach (RegistrationTuple reg in registry)
            {
                GlobalManager.MInstantMessage.AddListener(reg.type, reg.handler);
            }
        }

        public void UnregisterHandlers()
        {
            foreach (RegistrationTuple reg in registry)
            {
                GlobalManager.MInstantMessage.RemoveListener(reg.type, reg.handler);
            }
        }
    }

}
