/*
 * File:        UIRotoChipsUpdater.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class UIRotoChipsUpdater implements current RotoChips amount indicator
 * Created:     01.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Generic;
using RotoChips.Management;

namespace RotoChips.UI
{
    public class UIRotoChipsUpdater : UIDecimalIndicatorRoller
    {
        [SerializeField]
        protected Color normalColor;

        protected override decimal SourceValue(InstantMessageArgs args)
        {
            return (decimal)args.arg;
            //return (decimal)GlobalManager.MStorage.TotalPoints;
        }

        protected override Color TargetColor(decimal value)
        {
            return normalColor;
        }
    }
}
