/*
 * File:        FinalLightFlasher.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class FinalLightFlasher controls flahing color and intensity of the main directional light on the Finale scene
 * Created:     15.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Generic;
using RotoChips.Data;

namespace RotoChips.Finale
{
    public class FinalLightFlasher : FlashingObject
    {

        int start, end, realmIndex;
        Light worldLight;

        protected override void AwakeInit()
        {
            worldLight = GetComponent<Light>();
            start = 0;
            end = 1;
            realmIndex = 0;
        }

        private void Start()
        {
            StartFlash(true);
        }

        protected override void PeriodFinished(bool up)
        {
            if (++realmIndex >= RealmData.initializers.Length)
            {
                realmIndex = 0;
            }
            if (up)
            {
                start = realmIndex;
            }
            else
            {
                end = realmIndex;
            }
        }

        protected override void Visualize(float factor)
        {
            RealmData.Init startData = RealmData.initializers[start];
            RealmData.Init endData = RealmData.initializers[end];
            worldLight.color = Color.Lerp(startData.worldLightColor, endData.worldLightColor, factor);
            worldLight.intensity = Mathf.Lerp(startData.worldLightIntensity, endData.worldLightIntensity, factor);
            worldLight.renderMode = LightRenderMode.ForcePixel;
        }
    }
}
