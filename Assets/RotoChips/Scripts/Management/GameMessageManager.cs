/*
 * File:        GameMessageManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class GameMessageManager implements a communicating protocol for exchanging messages between _different_ game subsystems
 *              The message is dispatched immediately upon receival; no queueing is performed
 *              This message system should not be used within a single field object; the latter should use the capabilities of its own Consolidator component
 * Created:     18.06.2018
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.Management
{
    public class GameMessageManager : GenericManager
    {

        // basic yet important game event types
        public enum GameMessageType
        {
            MetricValueChanged,     // value of some metric has changed
            GameStart,              // level started
            TimerTick,              // timer tick happened (1s)
            GameOver,               // GameOver happened
            ObjectCreated,          // an object has been initialized in Consolidator
            ObjectHit,              // an object is hit by the player
            ObjectKilled,           // an object has been destroyed by the player
            ObjectDestroyed,        // an object has been destroyed by itself
            LanguageChanged,        // a system language has changed
            MilestoneChanged,       // a new milestone in a storyline is reached,
            ComboStarted,
            ComboExpired            // an active combo expired
        }

        // a generic class of game event arguments
        // arg field can be anything derived from System.Object
        public class GameMessageArgs : EventArgs
        {
            public GameMessageType type;
            public object arg;
        }

        protected Dictionary<GameMessageType, EventHandler<GameMessageArgs>> handlerRegistry;

        public override void MakeInitial()
        {
            Initialized = Status.None;
            InitRegistry();
            //Debug.Log("GameMessageManager initialized");
            base.MakeInitial();
        }

        void InitRegistry()
        {
            handlerRegistry = new Dictionary<GameMessageType, EventHandler<GameMessageArgs>>();
            foreach (GameMessageType type in Enum.GetValues(typeof(GameMessageType)))
            {
                handlerRegistry.Add(type, null);
            }
        }

        public void ClearRegistry()
        {
            if (handlerRegistry != null)
            {
                foreach (GameMessageType type in Enum.GetValues(typeof(GameMessageType)))
                {
                    EventHandler<GameMessageArgs> messageHandler;
                    if (handlerRegistry.TryGetValue(type, out messageHandler))
                    {
                        if (messageHandler != null)
                        {
                            foreach (EventHandler<GameMessageArgs> handler in messageHandler.GetInvocationList())
                            {
                                messageHandler -= handler;
                            }
                        }
                        handlerRegistry.Remove(type);
                    }
                }
            }
        }

        public void AddListener(GameMessageType type, EventHandler<GameMessageArgs> handler)
        {
            EventHandler<GameMessageArgs> messageHandler;
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

        public void RemoveListener(GameMessageType type, EventHandler<GameMessageArgs> handler)
        {
            EventHandler<GameMessageArgs> messageHandler;
            if (handlerRegistry.TryGetValue(type, out messageHandler))
            {
                if (messageHandler != null)
                {
                    //Debug.Log("Removing a handler for " + type.ToString() + ": " + handler.Method.Name);
                    handlerRegistry[type] -= handler;
                }
            }
        }

        public void PostMessage(GameMessageType aType, object sender, object anArg = null)
        {
            EventHandler<GameMessageArgs> messageHandler;
            if (handlerRegistry.TryGetValue(aType, out messageHandler))
            {
                if (messageHandler != null)
                {
                    messageHandler(sender, new GameMessageArgs { type = aType, arg = anArg });
                }
            }
        }

        private void OnDestroy()
        {
            ClearRegistry();
        }

    }
}
