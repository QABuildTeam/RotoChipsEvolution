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

namespace RotoChips.Management
{
    // basic yet important game event types
    public enum InstantMessageType
    {
        Unknown,
        WorldSelectStarted,
        WorldSelectButtonPressed,
        WorldSelectSatellitePressed,
        WorldSelectRotoChipsPressed,
        WorldSelectRotoCoinsPressed,
        PuzzleStarted,
        PuzzleButtonPressed,
        PuzzleButtonRotated,
        PuzzleRotoChipsPressed,
        PuzzleRotoCoinsPressed,
        GUIBackButtonPressed,
        GUIRestartButtonPressed,
        GUIViewButtonPressed,
        GUIMagicButtonPressed,
        GUIWhiteCurtainFaded,
        LanguageChanged
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
            //Debug.Log("GameMessageManager initialized");
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
                foreach (InstantMessageType type in Enum.GetValues(typeof(InstantMessageType)))
                {
                    EventHandler<InstantMessageArgs> messageHandler;
                    if (handlerRegistry.TryGetValue(type, out messageHandler))
                    {
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
            ClearRegistry();
        }

    }
}
