/*
 * File:        BuilderParams.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class BuilderParams de-couples the ObjectManager parameters from the latter class, defining ObjectClass-to-prefab links
 * Created:     24.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.Management
{
    public class BuilderParams : MonoBehaviour
    {

        // prefab declarations for objects
        [SerializeField]
        public ObjectManager.ObjectPrefabDeclaration[] objectDeclarations;

    }
}
