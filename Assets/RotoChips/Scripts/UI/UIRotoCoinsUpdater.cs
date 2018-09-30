/*
 * File:        UIRotoCoinsUpdater.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class UIRotoCoinsUpdater implements current RotoCoins amount indicator
 * Created:     01.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Generic;
using RotoChips.Management;

namespace RotoChips.UI
{
    public class UIRotoCoinsUpdater : UIDecimalIndicatorRoller
    {
        [SerializeField]
        protected Color normalColor;
        [SerializeField]
        protected Color purchaseColor;
        [SerializeField]
        protected bool CheckAgainstAutoStepPrice = false;

        protected override decimal SourceValue(InstantMessageArgs args)
        {
            return (decimal)args.arg;
            //return GlobalManager.MStorage.CurrentCoins;
        }

        protected override Color TargetColor(decimal value)
        {
            if (CheckAgainstAutoStepPrice)
            {
                return purchaseColor;
                /*
                if (newScore >= Purchases.AutoStepPrice)
                {
                    t.color = purchaseColor;
                }
                */
            }
            return normalColor;
        }
    }
}
