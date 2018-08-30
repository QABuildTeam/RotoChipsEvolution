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
using RotoChips.Generic;
using RotoChips.ImageProcessing;

namespace RotoChips.Management
{
    public class GlobalManager : MonoBehaviour
    {

        public static GlobalManager Instance
        {
            get; private set;
        }

        protected InstantMessageManager mInstantMessage;
        public static InstantMessageManager MInstantMessage
        {
            get
            {
                return Instance.mInstantMessage;
            }
            private set
            {
                Instance.mInstantMessage = value;
            }
        }

        protected ObjectManager mObject;
        public static ObjectManager MObject
        {
            get
            {
                return Instance.mObject;
            }
            private set
            {
                Instance.mObject = value;
            }
        }

        protected AudioManager mAudio;
        public static AudioManager MAudio
        {
            get
            {
                return Instance.mAudio;
            }
            private set
            {
                Instance.mAudio = value;
            }
        }

        protected LocalizationManager mLanguage;
        public static LocalizationManager MLanguage
        {
            get
            {
                return Instance.mLanguage;
            }
            private set
            {
                Instance.mLanguage = value;
            }
        }

        protected LevelDataManager mLevel;
        public static LevelDataManager MLevel
        {
            get
            {
                return Instance.mLevel;
            }
            private set
            {
                Instance.mLevel = value;
            }
        }

        protected StressImageCreator mStressImage;
        public static StressImageCreator MStressImage
        {
            get
            {
                return Instance.mStressImage;
            }
            private set
            {
                Instance.mStressImage = value;
            }
        }

        protected StorageManager mStorage;
        public static StorageManager MStorage
        {
            get
            {
                return Instance.mStorage;
            }
            private set
            {
                Instance.mStorage = value;
            }
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
                MInstantMessage = (InstantMessageManager)LocateManager(typeof(InstantMessageManager));
                MAudio = (AudioManager)LocateManager(typeof(AudioManager));
                MLanguage = (LocalizationManager)LocateManager(typeof(LocalizationManager));
                MObject = (ObjectManager)LocateManager(typeof(ObjectManager));
                MLevel = (LevelDataManager)LocateManager(typeof(LevelDataManager));
                MStressImage = (StressImageCreator)LocateManager(typeof(StressImageCreator));
                MStorage = (StorageManager)LocateManager(typeof(StorageManager));

                Debug.Log("Submanagers are linked");

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
            Debug.Log("Submanagers switched to Initial");
            // make all submanagers Loading
            SwitchManagersStatus(GenericManager.Status.Loading);
            // make them load all their persistent data
            Debug.Log("Submanagers switched to Loading");
            Load();
            // notify submanagers of configuration stream end
            SwitchManagersStatus(GenericManager.Status.Ready);
            // wait while they're becoming ready
            while (!CheckManagersStatus(GenericManager.Status.Ready))
            {
                yield return null;
            }
            Debug.Log("Submanagers switched to Ready");
            Initialized = true;
        }

        void SwitchManagersStatus(GenericManager.Status status)
        {
            foreach (KeyValuePair<int, List<GenericManager>> list in managers)
            {
                foreach (GenericManager manager in list.Value)
                {
                    Debug.Log("Switching manager " + manager.ToString() + " to status " + status.ToString());
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
                    Debug.Log("Checking manager " + manager.ToString() + " status to be " + status.ToString());
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

        [System.Serializable]
        protected class StatusChunk
        {
            public string signature;
            public object prototype;
        }

        [System.Serializable]
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
                    Debug.Log("Loading managers status from " + statusFileName);
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

        // special save flag
        protected enum SaveStatus
        {
            Unchanged,
            Requested,
            Pending
        }
        protected SaveStatus saveStatus = SaveStatus.Unchanged;

        // suspended save procedure
        public void Save()
        {
            saveStatus = SaveStatus.Requested;  // do not really save, just set a flag
        }

        private void LateUpdate()
        {
            switch (saveStatus)
            {
                case SaveStatus.Requested:
                    saveStatus = SaveStatus.Pending;    // there has been an active save requested
                    break;
                case SaveStatus.Pending:                // no active save requests, ok to save
                    RealSave();
                    break;
            }
        }

        // real save procedure
        protected void RealSave()
        {
            string statusFileName = StatusFileName;
            try
            {
                StatusSaver status = new StatusSaver
                {
                    statusList = new List<StatusChunk>()
                };
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
                    Debug.Log("Saving managers status to " + statusFileName);
                    SaveStatusBinary(statusFileName, status);
                    //SaveStatusJSON(statusFileName, status);
                }
            }
            catch (System.Exception e)
            {
                Debug.Log("GlobalManager.Save failed: " + e.ToString());
                throw;
            }
            saveStatus = SaveStatus.Unchanged;
        }

        /*
        private void OnDisable()
        {
            Save();
        }
        */
        /*
        private void OnDestroy()
        {
            Save();
        }
        */

    }
}
