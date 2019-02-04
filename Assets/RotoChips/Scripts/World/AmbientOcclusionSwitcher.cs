/*
 * File:        AmbientOcclusionSwitcher.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class AmbientOcclusionSwitcher turns off the ambient occlusion camera effect for low-end devices
 * Created:     28.08.2018
 */
#if PLATFORM_IOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;
using UnityEngine.PostProcessing;

namespace RotoChips.World
{
    public class AmbientOcclusionSwitcher : MonoBehaviour
    {
        static readonly List<DeviceGeneration> lowProducts = new List<DeviceGeneration>
    {
        DeviceGeneration.iPhone,
        DeviceGeneration.iPhone3G,
        DeviceGeneration.iPhone3GS,
        DeviceGeneration.iPhone4,
        DeviceGeneration.iPhone4S,
        DeviceGeneration.iPhone5,
        DeviceGeneration.iPhone5C,
        DeviceGeneration.iPhone5S,
        DeviceGeneration.iPad1Gen,
        DeviceGeneration.iPad2Gen,
        DeviceGeneration.iPad3Gen,
        DeviceGeneration.iPad4Gen,
        DeviceGeneration.iPadAir1,
        DeviceGeneration.iPadMini1Gen,
        DeviceGeneration.iPodTouch1Gen,
        DeviceGeneration.iPodTouch2Gen,
        DeviceGeneration.iPodTouch3Gen,
        DeviceGeneration.iPodTouch4Gen,
        DeviceGeneration.iPodTouch5Gen
    };

        // Use this for initialization
        void Awake()
        {
            if (lowProducts.Contains(Device.generation))
            {
                GetComponent<PostProcessingBehaviour>().enabled = false;
            }
        }

    }
}
#endif
#if UNITY_ANDROID
using UnityEngine;
using UnityEngine.PostProcessing;

namespace RotoChips.World
{
    public class AmbientOcclusionSwitcher : MonoBehaviour
    {
        void Awake()
        {
            GetComponent<PostProcessingBehaviour>().enabled = false;
        }

    }
}
#endif
