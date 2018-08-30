/*
 * File:        ObjectPool.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class ObjectPool implements a pool of idle objects: they can be re-used in the game level multiple times
 * Created:     24.08.2018
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.Management
{

    public class ObjectPool : MonoBehaviour
    {

        List<GameObject> objectPool;
        Dictionary<ObjectManager.ObjectClass, Stack<int>> idleObjectsDictionary;

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
                foreach (ObjectManager.ObjectClass oc in Enum.GetValues(typeof(ObjectManager.ObjectClass)))
                {
                    if (!idleObjectsDictionary.ContainsKey(oc))
                    {
                        idleObjectsDictionary.Add(oc, new Stack<int>());
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
                }
                Debug.Log("ObjectPool cleared");
            }
        }

        // utility method which creates an inactive pool object of the specified class
        public GameObject Prebuild(ObjectManager.ObjectClass objectClass)
        {
            //Initialize();
            //Debug.Log("Building pool object " + objectClass.ToString());
            ObjectManager.ObjectPrefabDeclaration decl = GlobalManager.MObject.GetObjectDecl(objectClass);
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
        public GameObject GetIdleObject(ObjectManager.ObjectClass objectClass, bool forceCreate = true)
        {
            //Initialize();
            if (idleObjectsDictionary[objectClass].Count > 0)
            {
                //Debug.Log("Popping idle object " + objectClass.ToString());
                GameObject o = objectPool[idleObjectsDictionary[objectClass].Pop()];
                // an object from the pool should be always set active
                o.SetActive(true);
                return o;
            }
            else if (forceCreate)
            {
                //Debug.Log("Creating idle object " + objectClass.ToString());
                GameObject o = Prebuild(objectClass);
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

    }

}
