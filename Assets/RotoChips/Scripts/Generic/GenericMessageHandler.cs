/*
 * File:        GenericMessageHandler.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class GenericMessageHandler is an abstract base for GameObjects capable of handling instant messages from InstantMessageManager
 * Created:     07.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.Generic
{
    public abstract class GenericMessageHandler : MonoBehaviour
    {

        protected MessageRegistrator registrator;

        // this method is called from within Awake right between creation of registrator and registering its handlers
        protected abstract void AwakeInit();

        private void Awake()
        {
            //Debug.Log("Registering handlers of " + gameObject.name + "." + GetType().ToString());
            registrator = new MessageRegistrator();
            AwakeInit();
            registrator.RegisterHandlers();
        }

        private void OnDestroy()
        {
            //Debug.Log("Unregistering handlers of " + gameObject.name + "." + GetType().ToString());
            registrator.UnregisterHandlers();
        }
    }
}
