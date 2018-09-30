/*
 * File:        SteadyTouch.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class SteadyTouch is a utility class which replaces standard unity event OnMouseUpAsButton
 *              It only responds to touches/mouse presses which are followed by pointer releases with a still pointer
 * Created:     01.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using RotoChips.Management;

namespace RotoChips.Utility
{
    public class SteadyTouch : EventTrigger
    {
        bool pointerSteady = false;
        public override void OnPointerDown(PointerEventData eventData)
        {
            pointerSteady = true;
        }

        public override void OnDrag(PointerEventData eventData)
        {
            Vector2 delta = eventData.delta;
            if (delta.x != 0 || delta.y != 0)
            {
                pointerSteady = false;
            }
        }

        public override void OnPointerUp(PointerEventData eventData)
        {
            if (pointerSteady)
            {
                pointerSteady = false;
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIObjectPressedAsButton, this, gameObject);
            }
        }
    }
}
