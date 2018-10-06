/*
 * File:        SerializableDecimal.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class SerializableDecimal implements a serializable decimal object which can be edited in an inspector window
 *              Based on https://answers.unity.com/questions/808352/how-to-make-decimal-variables-visible-in-inspector.html
 * Created:     05.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.Utility
{
    [System.Serializable]
    public class SerializableDecimal : ISerializationCallbackReceiver
    {
        public decimal value;
        [SerializeField]
        private string data;

        public void OnBeforeSerialize()
        {
            data = value.ToString();
        }

        public void OnAfterDeserialize()
        {
            decimal temp;
            if (data != null && decimal.TryParse(data, out temp))
            {
                value = temp;
            }
        }
    }
}
