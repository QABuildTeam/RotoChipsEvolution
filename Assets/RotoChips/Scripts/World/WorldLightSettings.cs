/*
 * File:        WorldLightSettings.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WorldLightSettings controls color and intensity of the main directional light on the World scene
 * Created:     28.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;
using RotoChips.Data;

namespace RotoChips.World
{
    public class WorldLightSettings : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            int currentRealm = GlobalManager.MLevel.LastOpenRealm();
            Color lihgtColor = RealmData.initializers[currentRealm].worldLightColor;
            float lightIntensity = RealmData.initializers[currentRealm].worldLightIntensity;
            Light worldLight = GetComponent<Light>();
            worldLight.color = lihgtColor;
            worldLight.intensity = lightIntensity;
            worldLight.renderMode = LightRenderMode.ForcePixel;
        }

    }
}
