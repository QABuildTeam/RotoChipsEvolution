/*
 * File:        PlatformString.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class PlatformString implements a single container for platform-specific strings (i. e. for iOS, Android, etc.)
 *              The user can set different values for different platforms and retrieve an appropriate value
 *              based on runtime platform.
 * Created:     08.02.2019
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Generic;

namespace RotoChips.Management
{
    [Serializable]
    public class DE_RuntimePlatform_string : DictionaryEntry<RuntimePlatform, string> { }

    [Serializable]
    public class PlatformString
    {
        [SerializeField]
        private string genericValue;    // this value is used when there is no appropriate platform value
        [SerializeField]
        private DE_RuntimePlatform_string[] platformVariants;   // these are strings for each (used) platform value
        private Dictionary<RuntimePlatform, string> variantDictionary;
        public string Value(RuntimePlatform platform)
        {
            if (variantDictionary == null)
            {
                variantDictionary = new DictionaryBuilder<RuntimePlatform, string>(platformVariants).Dictionary;
            }
            string result;
            if (variantDictionary == null || !variantDictionary.TryGetValue(platform, out result))
            {
                result = genericValue;
            }
            return result;
        }
    }
}
