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
