/*
 * File:        HintData.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class HintData contains all the configuration data for all types of hints
 * Created:     22.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.Data
{

    public class HintData : MonoBehaviour
    {
        [SerializeField]
        public List<HintParams> hintParameters;
    }

}
