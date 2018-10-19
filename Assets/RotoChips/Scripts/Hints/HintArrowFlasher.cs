/*
 * File:        HintArrowFlasher.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class HintArrowFlasher controls flashing of a hint arrow
 * Created:     13.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Generic;

namespace RotoChips.UI
{
    public class HintArrowFlasher : FlashingObject
    {
        Material arrowMaterial;
        // GenericMessageHandler overrides
        protected override void AwakeInit()
        {
            arrowMaterial = GetComponent<RawImage>().material;
        }

        // FlashingObject overrides
        protected override void Visualize(float factor)
        {
            arrowMaterial.SetFloat("_MKGlowTexStrength", factor);
        }

        private void OnEnable()
        {
            StartFlash();
        }

        private void OnDisable()
        {
            StopFlash();
        }

    }
}
