/*
 * File:        GlobalManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class GlobalManager is a unique entry point for all other game management systems
 * Created:     20.08.2018
 */
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using UnityEngine;
using RotoChips.ImageProcessing;

namespace RotoChips.Management
{
    public class GlobalManager : MonoBehaviour
    {

        public static GlobalManager Instance
        {
            get; private set;
        }

        public InstantMessageManager MInstantMessage
        {
            get; private set;
        }
        public ObjectManager MObject
        {
            get; private set;
        }
        public AudioManager MAudio
        {
            get; private set;
        }
        public LocalizationManager MLanguage
        {
            get; private set;
        }
        public StressImageCreator MImage
        {
            get; private set;
        }

        public bool Initialized
        {
            get; private set;
        }

        protected SortedDictionary<int, List<GenericManager>> managers;
        GenericManager LocateManager(System.Type managerType)
        {
            GenericManager manager = (GenericManager)GetComponentInChildren(managerType);
            if (manager != null)
            {
                int initOrder = manager.InitOrder;
                List<GenericManager> list;
                if (!managers.TryGetValue(initOrder, out list))
                {
                    list = new List<GenericManager>();
                    managers.Add(initOrder, list);
                }
                list.Add(manager);
            }
            return manager;
        }

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                //Debug.Log("Global Manager instatiated");
                Initialized = false;

                managers = new SortedDictionary<int, List<GenericManager>>();
                // all the component managers are already here, they only need to be initialized (within Awake call)
                MInstantMessage = (InstantMessageManager)LocateManager(typeof(InstantMessageManager));       // 20
                MAudio = (AudioManager)LocateManager(typeof(AudioManager));                     // 30
                MLanguage = (LocalizationManager)LocateManager(typeof(LocalizationManager));    // 70
                MObject = (ObjectManager)LocateManager(typeof(ObjectManager));                  // 10
                MImage = (StressImageCreator)LocateManager(typeof(StressImageCreator));
                //Debug.Log("Submanagers are linked");

                // make myself immortal
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private IEnumerator Start()
        {
            // make all submanagers Initial
            SwitchManagersStatus(GenericManager.Status.Initial);
            // wait while they're switching
            while (!CheckManagersStatus(GenericManager.Status.Initial))
            {
                yield return null;
            }
            // make all submanagers Loading
            SwitchManagersStatus(GenericManager.Status.Loading);
            // make them load all their persistent data
            Load();
            // notify submanagers of configuration stream end
            SwitchManagersStatus(GenericManager.Status.Ready);
            // wait while they're becoming ready
            while (!CheckManagersStatus(GenericManager.Status.Ready))
            {
                yield return null;
            }
            Initialized = true;
        }

        void SwitchManagersStatus(GenericManager.Status status)
        {
            foreach (KeyValuePair<int, List<GenericManager>> list in managers)
            {
                foreach (GenericManager manager in list.Value)
                {
                    //Debug.Log("Switching manager " + list.Key.ToString() + " to status " + status.ToString());
                    manager.Make(status);
                }
            }
        }

        bool CheckManagersStatus(GenericManager.Status status)
        {
            foreach (KeyValuePair<int, List<GenericManager>> list in managers)
            {
                foreach (GenericManager manager in list.Value)
                {
                    //Debug.Log("Checking manager " + list.Key.ToString() + " status to be " + status.ToString());
                    if (manager.Initialized != status)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // reading and storing current status
        [SerializeField]
        protected string statusFile = "statusfile.json";

        protected string StatusFileName
        {
            get
            {
                return Path.Combine(Application.persistentDataPath, statusFile);
            }
        }

        protected class StatusChunk
        {
            public string signature;
            public object prototype;
        }

        protected class StatusSaver
        {
            public List<StatusChunk> statusList;
        }

        protected StatusSaver LoadStatusBinary(string statusFileName)
        {
            StatusSaver statusSaver = null;
            using (FileStream fs = new FileStream(statusFileName, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                statusSaver = (StatusSaver)bf.Deserialize(fs);
            }
            return statusSaver;
        }

        protected StatusSaver LoadStatusJSON(string statusFileName)
        {
            StatusSaver statusSaver = null;
            using (StreamReader stream = new StreamReader(statusFileName))
            {
                string filedata = stream.ReadToEnd();
                if (filedata != null)
                {
                    statusSaver = JsonUtility.FromJson<StatusSaver>(filedata);
                }
            }
            return statusSaver;
        }

        protected StatusSaver LoadStatus()
        {
            string statusFileName = StatusFileName;
            StatusSaver statusSaver = null;
            try
            {
                if (File.Exists(statusFileName))
                {
                    //choose either loading procedure
                    statusSaver = LoadStatusBinary(statusFileName);
                    //statusSaver = LoadStatusJSON(statusFileName);
                }
            }
            catch (System.Exception e)
            {
                Debug.Log("GlobalManager.Load failed: " + e.ToString());
                throw;
            }
            return statusSaver;
        }

        void Load()
        {
            StatusSaver status = LoadStatus();
            if (status != null)
            {
                foreach (StatusChunk chunk in status.statusList)
                {
                    foreach (KeyValuePair<int, List<GenericManager>> list in managers)
                    {
                        foreach (GenericManager manager in list.Value)
                        {
                            if (manager.CheckSignature(chunk.signature))
                            {
                                manager.Load(chunk.prototype);
                                break;
                            }
                        }
                    }
                }
            }
        }

        protected void SaveStatusBinary(string statusFileName, StatusSaver statusSaver)
        {
            using (FileStream fs = new FileStream(statusFileName, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, statusSaver);
            }
        }

        protected void SaveStatusJSON(string statusFileName, StatusSaver statusSaver)
        {
            using (StreamWriter stream = new StreamWriter(statusFileName))
            {
                stream.Write(JsonUtility.ToJson(statusSaver));
            }
        }

        public void Save()
        {
            string statusFileName = StatusFileName;
            try
            {
                StatusSaver status = new StatusSaver();
                foreach (KeyValuePair<int, List<GenericManager>> list in managers)
                {
                    foreach (GenericManager manager in list.Value)
                    {
                        string signature = manager.SaveSignature();
                        if (!string.IsNullOrEmpty(signature))
                        {
                            object prototype = manager.Save();
                            if (prototype != null)
                            {
                                status.statusList.Add(new StatusChunk { signature = signature, prototype = prototype });
                            }
                        }
                    }
                }
                if (status.statusList.Count > 0)
                {
                    // choose either save procedure
                    SaveStatusBinary(statusFileName, status);
                    //SaveStatusJSON(statusFileName, status);
                }
            }
            catch (System.Exception e)
            {
                Debug.Log("GlobalManager.Save failed: " + e.ToString());
                throw;
            }
        }

        private void OnDisable()
        {
            Save();
        }

        /*
        private void OnDestroy()
        {
            Save();
        }
        */

    }
}
