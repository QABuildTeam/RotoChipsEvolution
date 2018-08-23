#if PLATFORM_IOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;
using UnityEngine.PostProcessing;

public class AmbientOcclusionSwitcher : MonoBehaviour
{

	static DeviceGeneration[] lowProducts ={
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
		foreach (DeviceGeneration devgen in lowProducts)
		{
			if (Device.generation == devgen)
			{
				GetComponent<PostProcessingBehaviour>().enabled = false;
				break;
			}
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}
#endif