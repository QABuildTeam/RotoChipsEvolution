/*
 * File:        DictionaryBuilder.cs
 * Author:      Igor Spiridonov
 * Descrpition: Generic class DictionaryEntry implements a single tuple-style entry for a dictionary which can be serialized and set up
 *              in Unity inspector.
 *              Generic class DictionaryBuilder is a utility class which can be used to easily build a dictionary from a list of
 *              DictionaryEntries, like this:
 *              public class DE_int_string : DictionaryEntry<int, string> {}
 *              [SerializeField]
 *              List<DE_int_string> list;
 *              DictionaryBuilder<int, string> dict = new DictionaryBuilder<int, string>(list);
 *              if (dict.Dictionary.Contains(someKey))
 *              {
 *                  ...
 *              }
 * Created:     07.02.2019
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.Generic
{
    [Serializable]
    public class DictionaryEntry<TKey, TValue>
    {
        [SerializeField]
        public TKey key;
        [SerializeField]
        public TValue value;
    }

    public class DictionaryBuilder<TKey, TValue>
    {
        public Dictionary<TKey, TValue> Dictionary { get; private set; }
        public DictionaryBuilder(DictionaryEntry<TKey, TValue>[] array)
        {
            Dictionary = new Dictionary<TKey, TValue>();
            if (array != null)
            {
                foreach (DictionaryEntry<TKey, TValue> entry in array)
                {
                    if (!Dictionary.ContainsKey(entry.key))
                    {
                        Dictionary.Add(entry.key, entry.value);
                    }
                }
            }
        }
        public DictionaryBuilder(List<DictionaryEntry<TKey, TValue>> list) : this(list.ToArray()) { }
    }
}
