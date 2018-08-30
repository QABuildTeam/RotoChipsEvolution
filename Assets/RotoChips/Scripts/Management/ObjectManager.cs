/*
 * File:        ObjectManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class ObjectManager defines types of game objects and provides means for their generation via a child object's component ObjectPool
 *              ObjectManager should be used along with BuilderParams component within another child object
 * Created:     24.08.2018
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Generic;

namespace RotoChips.Management
{
    public class ObjectManager : GenericManager
    {

        public override void MakeInitial()
        {
            Initialized = Status.None;
            InitObjectClassNames();
            base.MakeInitial();
        }

        public override void MakeReady()
        {
            if (Pool == null)
            {
                Debug.Log("No ObjectPool found");
            }
            base.MakeReady();
        }

        #region Object classes
        public enum ObjectClass
        {
            Unknown,
            Globe,
            WorldSelectCube,
            WorldSelectLine,
            WorldSelectSatellite,
            PuzzleTile,
            PuzzleButton
        }

        protected static Dictionary<string, ObjectClass> objectClassNames;
        protected static void InitObjectClassNames()
        {
            if (objectClassNames == null)
            {
                objectClassNames = new Dictionary<string, ObjectClass>();
                foreach (ObjectClass c in Enum.GetValues(typeof(ObjectClass)))
                {
                    string key = c.ToString();
                    if (!objectClassNames.ContainsKey(key))
                    {
                        objectClassNames.Add(key, c);
                    }
                }
            }
        }

        public static ObjectClass GetObjectClass(string name)
        {
            InitObjectClassNames();
            ObjectClass c;
            if (objectClassNames.TryGetValue(name, out c))
            {
                return c;
            }
            return ObjectClass.Unknown;
        }
        #endregion

        #region Field object templates and definitions

        #region Data structures
        [Serializable]
        public class ObjectPrefabDeclaration
        {
            public ObjectClass objectClass;
            public GameObject prefab;
            public string descriptionId;
        }
        #endregion
        #region External facilities
        protected BuilderParams parameters;
        public BuilderParams Parameters
        {
            get
            {
                if (parameters == null)
                {
                    parameters = GetComponentInChildren<BuilderParams>();
                }
                return parameters;
            }
        }
        // an object pool is not used inside ObjectManager
        protected ObjectPool pool;
        public ObjectPool Pool
        {
            get
            {
                if (pool == null)
                {
                    pool = GetComponentInChildren<ObjectPool>();
                }
                return pool;
            }
        }
        #endregion
        #region Fetching object declarations
        public ObjectPrefabDeclaration GetObjectDecl(ObjectClass objectClass)
        {
            if (Parameters != null)
            {
                foreach (ObjectPrefabDeclaration decl in Parameters.objectDeclarations)
                {
                    if (objectClass == ObjectClass.Unknown || decl.objectClass == objectClass)
                    {
                        return decl;
                    }
                }
            }
            return null;
        }
        #endregion

        #endregion
    }
}
