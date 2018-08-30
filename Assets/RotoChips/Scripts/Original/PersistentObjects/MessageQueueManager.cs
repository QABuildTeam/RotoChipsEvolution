/*
 * File:        MessageQueueManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class MessageQueueManager implements a means for message queueing
 *              The message is put on a queue by a sender and later may be retrieved by a reciever;
 *              no registering is required
 * Created:     24.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Generic;

namespace RotoChips.Management
{
    public enum QueuedMessageType
    {
        Unknown
    }

    public class MessageQueueManager : GenericManager
    {

        Queue<string> messageQueue;

        public override void MakeInitial()
        {
            Initialized = Status.None;
            messageQueue = new Queue<string>();
            base.MakeInitial();
        }

        public void PostMessage(string message)
        {
            messageQueue.Enqueue(message);
        }

        public string RetrieveMessage()
        {
            if (messageQueue.Count > 0)
            {
                return messageQueue.Dequeue();
            }
            return "";
        }

        public void Clear()
        {
            messageQueue.Clear();
        }

    }
}
