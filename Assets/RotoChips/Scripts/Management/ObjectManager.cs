/*
 * File:        ObjectManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class ObjectManager defines types of field objects and provides means for their generation via a child object's component ObjectPool
 *              ObjectManager should be used along with BuilderParams component within another child object
 * Created:     29.06.2018
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Player,
            Border,
            Block,
            Emergency,
            Cash,
            Powerhouse,
            Datacenter,
            News,
            Youtube,
            Government,
            Bank,
            Exchange,
            Cryptocoin,
            Combo2,
            Combo3,
            Combo4,
            Combo5,
            Combo6,
            Combo7,
            Combo8,
            Combo9,
            ComboExplosion,
            Deathline,
            Cryptocoin1,
            Cryptocoin2,
            Cryptocoin3,
            Cryptocoin4,
            Cryptocoin5,
            Combo2Explosion,
            Combo3Explosion,
            Combo4Explosion,
            Combo5Explosion,
            Combo6Explosion,
            Combo7Explosion,
            Combo8Explosion,
            Combo9Explosion,
            DeathInTime,
            DatacenterAfterlife,
            CryptocoinPin,
            BankCom,
            BankGov,
            Last
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
        public class ObjectClassParams
        {
            public ObjectClass objectClass;
        }
        [Serializable]
        public class ObjectPrefabDeclaration
        {
            public ObjectClassParams classParams;
            public char mapper;
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
        // enumerators for object declaration collections
        public IEnumerable<ObjectPrefabDeclaration> FieldObjectsCollection()
        {
            return Parameters != null ? Parameters.fieldObjectDeclarations : null;
        }

        public IEnumerable<ObjectPrefabDeclaration> PoolObjectsCollection()
        {
            return Parameters != null ? Parameters.poolObjectDeclarations : null;
        }

        public IEnumerable<ObjectPrefabDeclaration> ObjectsCollection()
        {
            if (Parameters != null)
            {
                foreach (ObjectPrefabDeclaration decl in FieldObjectsCollection())
                {
                    yield return decl;
                }
                foreach (ObjectPrefabDeclaration decl in PoolObjectsCollection())
                {
                    yield return decl;
                }
            }
            else
            {
                yield return null;
            }
        }

        // generic search method
        protected ObjectPrefabDeclaration FindDeclaration(IEnumerable<ObjectPrefabDeclaration> whereToSearch, char mapper = (char)0, int configOption = -1, ObjectClass objectClass = ObjectClass.Unknown)
        {
            foreach (ObjectPrefabDeclaration decl in whereToSearch)
            {
                if ((mapper == (char)0 || decl.mapper == mapper) &&
                    //(configOption == -1 || decl.classParams.configOption == configOption) &&
                    (objectClass == ObjectClass.Unknown || decl.classParams.objectClass == objectClass))
                {
                    return decl;
                }
            }
            return null;
        }

        // find a field object declaration by its mapper character and a config option value
        public ObjectPrefabDeclaration GetFieldObjectDecl(char mapper, int configOption)
        {
            return FindDeclaration(FieldObjectsCollection(), mapper, configOption);
        }

        // find a field object declaration by its object class and a config option value
        public ObjectPrefabDeclaration GetFieldObjectDecl(ObjectClass objectClass, char mapper = (char)0, int configOption = -1)
        {
            return FindDeclaration(FieldObjectsCollection(), mapper, configOption, objectClass);
        }

        // find a pool object declaration by its object class and a config option value
        public ObjectPrefabDeclaration GetPoolObjectDecl(ObjectClass objectClass, int configOption = -1)
        {
            return FindDeclaration(PoolObjectsCollection(), configOption: configOption, objectClass: objectClass);
        }

        // universal search method
        public ObjectPrefabDeclaration GetObjectDecl(ObjectClass objectClass, int configOption = -1)
        {
            return FindDeclaration(ObjectsCollection(), objectClass: objectClass, configOption: configOption);
        }
        #endregion

        #endregion
    }
}
