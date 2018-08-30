/*
 * File:        GenericManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class GenericManager is an abstract base for generic game managers
 * Created:     24.07.2018
 */
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_ANDROID
using UnityEngine.Networking;
#endif

namespace RotoChips.Generic
{
    public abstract class GenericManager : MonoBehaviour
    {

        // no Singleton can be used

        // ---------------------------------
        // status fields and methods
        // ---------------------------------
        public enum Status
        {
            None,
            Initial,
            Loading,
            Ready
        }
        public virtual Status Initialized
        {
            get; protected set;
        }

        [SerializeField]
        protected int initOrder;
        public int InitOrder
        {
            get
            {
                return initOrder;
            }
        }

        // ---------------------------------
        // status switching methods
        // ---------------------------------
        // switch to Status.Initial
        public virtual void MakeInitial()
        {
            Initialized = Status.Initial;
            Debug.Log(GetType().ToString() + ".Initialized = " + Initialized.ToString());
        }

        // switch to Status.Loading
        public virtual void MakeLoading()
        {
            Initialized = Status.Loading;
            Debug.Log(GetType().ToString() + ".Initialized = " + Initialized.ToString());
        }

        // switch to Status.Ready
        public virtual void MakeReady()
        {
            Initialized = Status.Ready;
            Debug.Log(GetType().ToString() + ".Initialized = " + Initialized.ToString());
        }

        public void Make(Status status)
        {
            switch (status)
            {
                case Status.Initial:
                    MakeInitial();
                    break;
                case Status.Loading:
                    MakeLoading();
                    break;
                case Status.Ready:
                    MakeReady();
                    break;
            }
        }

        // ---------------------------------
        // streamable loading/saving methods
        // ---------------------------------
        // this method checks if an object being loaded has a signature which matches the current class signature
        public virtual bool CheckSignature(string initLine)
        {
            return false;
        }

        // this method creates a class signature string for an object being saved
        public virtual string SaveSignature()
        {
            return string.Empty;
        }

        // this method restores a current object's state from a loaded object
        public virtual void Load(object prototype)
        {
            // nothing is loaded
        }

        // this method creates an object with the current object's state for saving
        public virtual object Save()
        {
            // nothing to save
            return null;
        }

        // auxillary JSON loading/saving methods
        public static T LoadJSONObject<T>(StreamReader stream) where T : class
        {
            string src = stream.ReadLine();
            if (src != null)
            {
                return JsonUtility.FromJson<T>(src);
            }
            else
            {
                Debug.Log("No data read while LoadObject<" + typeof(T).Name + "> from stream " + stream.ToString());
            }
            return null;
        }

        public static T ParseJSONSignature<T>(string line) where T : class
        {
            if (!string.IsNullOrEmpty(line))
            {
                return JsonUtility.FromJson<T>(line);
            }
            return null;
        }

        public static void SaveJSONObject<T>(StreamWriter stream, T obj) where T : class
        {
            if (obj != null)
            {
                stream.WriteLine(JsonUtility.ToJson(obj));
            }
            else
            {
                Debug.Log("No data saved to " + stream.ToString() + " because of null object " + typeof(T).Name);
            }
        }

        public static string SetJSONSignature<T>(T obj) where T : class
        {
            if (obj != null)
            {
                return JsonUtility.ToJson(obj);
            }
            return string.Empty;
        }

        // ---------------------------------
        // assistant methods for StreamableAssets
        // ---------------------------------
        public delegate void ProcessAssetExistence(string name, bool exists);       // this is a delegate type which performs an action based on existence of a given StreamableAsset
        public delegate void ProcessLoadedStream(StreamReader stream, bool exists); // this is a delegate type which loads a StreamableAsset from the stream if the latter exists
        public bool IsLoaded                                                        // StreamableAsset loaded/processed
        {
            get; protected set;
        }

        // this method just checks if a StreamableAsset with an assetName exists
        protected IEnumerator CheckStreamableAsset(string assetName, ProcessAssetExistence assetProcessor)
        {
            IsLoaded = false;
            Debug.Log("GenericManager.CheckStreamableAsset: running assetProcessor for " + assetName + "...");
#if !UNITY_ANDROID
            if (IsLoaded)
            {
                yield return null;
            }
            assetProcessor(assetName, File.Exists(assetName));
#else
            using (UnityWebRequest get = UnityWebRequest.Get(assetName))
            {
                yield return get.SendWebRequest();
                assetProcessor(assetName, get.downloadHandler.data != null && get.downloadHandler.data.Length > 0);
            }
#endif
            Debug.Log("GenericManager.CheckStreamableAsset: ...done");
            IsLoaded = true;
        }

        // this method tries to load a StreamableAsset with an assetName
        protected IEnumerator LoadStreamableAsset(string assetName, ProcessLoadedStream streamProcessor)
        {
            IsLoaded = false;
#if UNITY_ANDROID
            using (UnityWebRequest get = UnityWebRequest.Get(assetName))
            {
                yield return get.SendWebRequest();

                if (get.downloadHandler.data == null || get.downloadHandler.data.Length == 0)
                {
#else
                if (!File.Exists(assetName))
                {
#endif
                    streamProcessor(null, false);
                    IsLoaded = true;
                    yield break;
                }
#if UNITY_ANDROID
                using (StreamReader stream = new StreamReader(new MemoryStream(get.downloadHandler.data)))
#else
                using (StreamReader stream = new StreamReader(File.OpenRead(assetName)))
#endif
                {
                    streamProcessor(stream, true);
                }
#if UNITY_ANDROID
            }
#endif
            IsLoaded = true;
        }
    }
}
