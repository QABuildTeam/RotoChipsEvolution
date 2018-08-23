/*
 * File:        ObjectPool.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class ObjectPool implements a pool of idle objects: they can be re-used in the game level multiple times (explosions, cryptocoins, etc.)
 * Created:     29.06.2018
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using RotoChips.Management;

namespace RotoChips.Management
{

    public class ObjectPool : MonoBehaviour
    {

        public class PoolStatistics
        {
            public int created;
            public int requested;
            public int reused;
            public int returned;
        }

        List<GameObject> objectPool;
        Dictionary<ObjectManager.ObjectClass, Stack<int>> idleObjectsDictionary;
        Dictionary<ObjectManager.ObjectClass, PoolStatistics> poolStatistics;

        private void Awake()
        {
            Initialize();
        }

        private static bool initialized;
        void Initialize()
        {
            if (!initialized)
            {
                initialized = true;
                objectPool = new List<GameObject>();
                idleObjectsDictionary = new Dictionary<ObjectManager.ObjectClass, Stack<int>>();
                poolStatistics = new Dictionary<ObjectManager.ObjectClass, PoolStatistics>();
                foreach (ObjectManager.ObjectClass oc in Enum.GetValues(typeof(ObjectManager.ObjectClass)))
                {
                    if (!idleObjectsDictionary.ContainsKey(oc))
                    {
                        idleObjectsDictionary.Add(oc, new Stack<int>());
                    }
                    if (!poolStatistics.ContainsKey(oc))
                    {
                        poolStatistics.Add(oc, new PoolStatistics());
                    }
                }
                Debug.Log("ObjectPool initialized");
            }
        }

        public void Clear()
        {
            if (initialized)
            {
                objectPool.Clear();
                foreach (ObjectManager.ObjectClass oc in Enum.GetValues(typeof(ObjectManager.ObjectClass)))
                {
                    if (idleObjectsDictionary.ContainsKey(oc))
                    {
                        idleObjectsDictionary[oc].Clear(); ;
                    }
                    if (poolStatistics.ContainsKey(oc))
                    {
                        poolStatistics[oc] = new PoolStatistics();
                    }
                }
                Debug.Log("ObjectPool cleared");
            }
        }

        // utility method which creates an inactive pool object of the specified class
        public GameObject Prebuild(ObjectManager.ObjectClass objectClass, bool searchFieldObjects = false)
        {
            //Initialize();
            //Debug.Log("Building pool object " + objectClass.ToString());
            ObjectManager.ObjectPrefabDeclaration decl = GlobalManager.Instance.MObject.GetPoolObjectDecl(objectClass);
            if (decl == null && searchFieldObjects)
            {
                //Debug.Log("No object in pool, building field object " + objectClass.ToString());
                decl = GlobalManager.Instance.MObject.GetFieldObjectDecl(objectClass);
            }
            if (decl != null)
            {
                //Debug.Log("Found object declaration: " + GlobalManager.Instance.MLanguage.Entry(decl.descriptionId));
                GameObject o = Instantiate(decl.prefab);
                // prebuilt objects are immediately set inactive
                o.SetActive(false);
                return o;
            }
            //Debug.Log("Could not find declaration for " + objectClass.ToString());
            return null;
        }

        // get an idle object of a class if available
        public GameObject GetIdleObject(ObjectManager.ObjectClass objectClass, bool searchFieldObjects = false, bool forceCreate = true)
        {
            //Initialize();
            poolStatistics[objectClass].requested++;
            if (idleObjectsDictionary[objectClass].Count > 0)
            {
                //Debug.Log("Popping idle object " + objectClass.ToString());
                poolStatistics[objectClass].reused++;
                GameObject o = objectPool[idleObjectsDictionary[objectClass].Pop()];
                // an object from the pool should be always set active
                o.SetActive(true);
                return o;
            }
            else if (forceCreate)
            {
                //Debug.Log("Creating idle object " + objectClass.ToString());
                poolStatistics[objectClass].created++;
                GameObject o = Prebuild(objectClass, searchFieldObjects);
                if (o != null)
                {
                    o.SetActive(true);
                    return o;
                }
            }
            return null;
        }

        // put an idle object into the object pool
        public void PutIdleObject(GameObject o)
        {
            //Initialize();
            if (o != null)
            {
                poolStatistics[ObjectManager.GetObjectClass(o.tag)].returned++;
                //Debug.Log("Putting object " + ObjectManager.GetObjectClass(o.tag).ToString() + " to the pool");
                o.SetActive(false); // for the sake of productivity
                ObjectManager.ObjectClass objectClass = ObjectManager.GetObjectClass(o.tag);
                int objectIndex = objectPool.IndexOf(o);
                if (objectIndex < 0)
                {
                    //Debug.Log("Adding object to pool");
                    objectIndex = objectPool.Count;
                    objectPool.Add(o);
                }
                else
                {
                    if (idleObjectsDictionary[objectClass].Contains(objectIndex))
                    {
                        //Debug.Log("Object is already registered in the pool");
                        return;
                    }
                }
                //Debug.Log("Object is in the pool, registering");
                idleObjectsDictionary[objectClass].Push(objectIndex);
            }
        }

        public void DumpStatistics(int levelId)
        {
            string dumpFile = Application.persistentDataPath + "/objectPool-" + levelId.ToString("D3") + ".txt";
            Debug.Log("Dumping statistics to " + dumpFile);
            using (StreamWriter sw = new StreamWriter(dumpFile))
            {
                sw.WriteLine("Object pool statisctics for level " + levelId.ToString("D3"));
                sw.WriteLine(string.Format("{0,-20}{1,-10}{2,-10}{3,-10}{4,-10}", "Class", "Requested", "Created", "Reused", "Returned"));
                foreach (ObjectManager.ObjectClass oc in Enum.GetValues(typeof(ObjectManager.ObjectClass)))
                {
                    sw.WriteLine(string.Format("{0,-20}{1,-10}{2,-10}{3,-10}{4,-10}", oc.ToString(), poolStatistics[oc].requested, poolStatistics[oc].created, poolStatistics[oc].reused, poolStatistics[oc].returned));
                }
            }
        }
    }

}
