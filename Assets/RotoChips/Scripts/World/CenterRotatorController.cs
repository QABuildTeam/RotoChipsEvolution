/*
 * File:        CenterRotatorController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class CenterRotatorController initializes the gallery satellite subsystem
 * Created:     31.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using RotoChips.Management;

namespace RotoChips.World
{
    public class CenterRotatorController : MonoBehaviour
    {

        // Use this for initialization
        void Awake()
        {
            bool active = GlobalManager.MLevel.GetDescriptor(0).state.Complete;
            gameObject.SetActive(true);
        }

    }
}
