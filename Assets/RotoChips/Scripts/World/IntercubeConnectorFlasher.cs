/*
 * File:        IntercubeConnectorFlasher.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class IntercubeConnectorFlasher implements wave-like flashing for interselector line connectors on the world globe
 * Created:     30.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Generic;

namespace RotoChips.World
{
    public class IntercubeConnectorFlasher : FlashingObject
    {
        LineRenderer lineRenderer;

        public void Init(Color lineColor, Vector3 endPosition)
        {
            lineColor.a = 1;
            lineRenderer = GetComponent<LineRenderer>();
            lineRenderer.startColor = lineColor;
            lineRenderer.endColor = lineColor;
            lineRenderer.SetPosition(0, Vector3.zero);
            lineRenderer.SetPosition(1, endPosition);
        }

        protected override void Visualize(float factor)
        {
            Color lineColor = lineRenderer.startColor;
            lineColor.a = factor;
            lineRenderer.startColor = lineColor;
            lineRenderer.endColor = lineColor;
        }
    }
}
