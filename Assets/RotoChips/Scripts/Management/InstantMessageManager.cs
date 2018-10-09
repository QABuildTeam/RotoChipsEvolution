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

    // main configuration parameter for message handling - a pair of message type and its corresponding handler
    public class MessageRegistrationTuple
    {
        public InstantMessageType type;
        public InstantMessageHandler handler;
    }

    // utility class for registering and unregistering message handlers in classes
    public class MessageRegistrator
    {
        List<MessageRegistrationTuple> registry;

        public MessageRegistrator(params MessageRegistrationTuple[] regparams)
        {
            registry = new List<MessageRegistrationTuple>();
            Add(regparams);
        }

        public void Add(params MessageRegistrationTuple[] regtuples)
        {
            for(int i = 0; i < regtuples.Length; i++)
            {
                MessageRegistrationTuple regtuple = regtuples[i];
                if (regtuple != null && regtuple.handler != null)
                {
                    registry.Add(regtuple);
                }
            }
        }

        public void RegisterHandlers()
        {
            foreach (MessageRegistrationTuple reg in registry)
            {
                GlobalManager.MInstantMessage.AddListener(reg.type, reg.handler);
            }
        }

        public void UnregisterHandlers()
        {
            foreach (MessageRegistrationTuple reg in registry)
            {
                GlobalManager.MInstantMessage.RemoveListener(reg.type, reg.handler);
            }
        }
    }

}
