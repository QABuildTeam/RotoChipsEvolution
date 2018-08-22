/*
 * File:        GlobalManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class GlobalManager is a unique entry point for all other game management systems
 * Created:     20.08.2018
 */
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.Management
{
    public class GlobalManager : MonoBehaviour
    {

        public static GlobalManager Instance
        {
            get; private set;
        }

        public GameMessageManager MMessage
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
                MMessage = (GameMessageManager)LocateManager(typeof(GameMessageManager));       // 20
                MAudio = (AudioManager)LocateManager(typeof(AudioManager));                     // 30
                MLanguage = (LocalizationManager)LocateManager(typeof(LocalizationManager));    // 70
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

        void Load()
        {
            string statusFileName = StatusFileName;
            try
            {
                if (File.Exists(statusFileName))
                {
                    using (StreamReader stream = new StreamReader(statusFileName))
                    {
                        while (!stream.EndOfStream)
                        {
                            string initLine = stream.ReadLine();
                            if (initLine != null)
                            {
                                foreach (KeyValuePair<int, List<GenericManager>> list in managers)
                                {
                                    foreach (GenericManager manager in list.Value)
                                    {
                                        if (manager.CheckSignature(initLine))
                                        {
                                            manager.Load(stream);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                Debug.Log("GlobalManager.Load failed: " + e.ToString());
                throw;
            }
        }

        public void Save()
        {
            string statusFileName = StatusFileName;
            using (StreamWriter stream = new StreamWriter(statusFileName, false, System.Text.Encoding.UTF8))
            {
                foreach (KeyValuePair<int, List<GenericManager>> list in managers)
                {
                    foreach (GenericManager manager in list.Value)
                    {
                        string signature = manager.SaveSignature();
                        if (!string.IsNullOrEmpty(signature))
                        {
                            stream.WriteLine(signature);
                            manager.Save(stream);
                        }
                    }
                }
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
