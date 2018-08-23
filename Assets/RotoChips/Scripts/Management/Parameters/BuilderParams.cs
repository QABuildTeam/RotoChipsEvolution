/*
 * File:        BuilderParams.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class BuilderParams de-couples the ObjectManager parameters from the latter class, defining ObjectClass-to-prefab links
 * Created:     29.06.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.Management
{
    public class BuilderParams : MonoBehaviour
    {

        // field objects prefabs declarations
        [SerializeField]
        public ObjectManager.ObjectPrefabDeclaration[] fieldObjectDeclarations;

        // prefab declarations for objects from the object pool
        [SerializeField]
        public ObjectManager.ObjectPrefabDeclaration[] poolObjectDeclarations;

    }
}
