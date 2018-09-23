/*
 * File:        HintManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class HintManager simply reports the parameters of a hint of specified type
 * Created:     22.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Generic;
using RotoChips.Data;
using RotoChips.UI;

namespace RotoChips.Management
{
    [System.Serializable]
    public enum HintLayout
    {
        Default,            // no arrow, a hint message is in the center of the screen
        HintLeftTop,        // a hint message is at the left top corner of the screen
        HintTop,            // a hint message is at the top side of the screen
        HintRightTop,        // a hint message is at the right top corner of the screen
        HintRight,          // a hint message is at the right side of the screen
        HintRightBottom,    // a hint message is at the right bottom corner of the screen
        HintBottom,         // a hint message is at the bottom side of the screen
        HintLeftBottom,     // a hint message is at the left bottom corner of the screen
        HintLeft            // a hint message is at the left side of the screen
    }

    [System.Serializable]
    public class HintParams
    {
        public HintType type;       // a type of the hint
        public string hintMsgId;    // a localization key to the hint message
        public HintLayout layout;   // a type of the hint layout
        public float width;         // a width of a hint message
        public float height;        // a height of a hint message
        public float xGap;          // a distance between a vertical side of a hint message and the nearest screen side
        public float yGap;          // a distance between a horizontal side of a hint message and the nearest screen side
        public bool arrowOn;        // is arrow present
        [HideInInspector]
        public GameObject target;   // a target object of a hint arrow
        public float arrowAngle;    // a rotation angle of a hint arrow around its pivot point
        public InstantMessageType arrowMessage; // a message to be sent when the player taps the arrow sensitive spot
    }

    public class HintManager : GenericManager
    {
        public Dictionary<HintType, HintParams> Hints
        {
            get; private set;
        }

        [SerializeField]
        protected Dictionary<HintType, bool> hintShown;

        public override void MakeInitial()
        {
            Hints = new Dictionary<HintType, HintParams>();
            HintData hintData = GetComponentInChildren<HintData>();
            if (hintData != null)
            {
                foreach (HintParams hintParams in hintData.hintParameters)
                {
                    if (!Hints.ContainsKey(hintParams.type))
                    {
                        Hints.Add(hintParams.type, hintParams);
                    }
                }
            }
            hintShown = new Dictionary<HintType, bool>();
            foreach(HintType type in System.Enum.GetValues(typeof(HintType)))
            {
                hintShown.Add(type, false);
            }
            base.MakeInitial();
        }

        static readonly string signature = ".hints.";
        public override bool CheckSignature(string initLine)
        {
            return !string.IsNullOrEmpty(initLine) && initLine == signature;
        }

        public override string SaveSignature()
        {
            return signature;
        }
        public override object Save()
        {
            return hintShown;
        }

        public override void Load(object prototype)
        {
            hintShown = (Dictionary<HintType, bool>)prototype;
        }

        public bool IsHintShown(HintType hintType)
        {
            bool isShown;
            if (hintShown.TryGetValue(hintType,out isShown))
            {
                return isShown;
            }
            return false;
        }

        public void SetHintShown(HintType hintType)
        {
            bool isShown;
            if (hintShown.TryGetValue(hintType, out isShown)&&!isShown)
            {
                hintShown[hintType] = true;
                GlobalManager.Instance.Save();
            }
            else
            {
                hintShown.Add(hintType, true);
                GlobalManager.Instance.Save();
            }
        }

        public bool ShowNewHint(HintType hintType, GameObject hintTarget=null)
        {
            if (!IsHintShown(hintType))
            {
                SetHintShown(hintType);
                GlobalManager.MInstantMessage.DeliverMessage(
                    InstantMessageType.GUIShowHint,
                    this,
                    new HintRequest
                    {
                        type = hintType,
                        target = hintTarget
                    }
                );
                return true;
            }
            return false;
        }
    }
}
