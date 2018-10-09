/*
 * File:        PriceEntryController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class PriceEntryController controls a price entry at the Shop scene and the purchasing of the corresponding goods
 * Created:     04.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using RotoChips.Management;
using RotoChips.Accounting;
using RotoChips.Generic;

namespace RotoChips.Shop
{
    public class PriceEntryController : GenericMessageHandler
    {
        [SerializeField]
        protected Text entryNameText;
        [SerializeField]
        protected Text entryValueText;
        [SerializeField]
        protected string entryId;

        bool dialogMode;

        protected override void AwakeInit()
        {
            dialogMode = false;
            ProductDesc product = GlobalManager.MPurchase.ProductById(entryId);
            if (product != null)
            {
                entryNameText.text = product.localizedDescription;
                entryValueText.text = product.localizedPrice;
            }
            registrator.Add(
                new MessageRegistrationTuple { type = InstantMessageType.GUIOKButtonPressed, handler = OnGUIOKButtonPressed },
                new MessageRegistrationTuple { type = InstantMessageType.GUICancelButtonPressed, handler = OnGUICancelButtonPressed }
            );
        }

        // message handling
        [SerializeField]
        protected string purchaseConfirmationId = "idPurchaseConfirmation";
        public void PriceEntryButtonPressed()
        {
            // ask for the confirmation of an entry purchase
            string dialogMessage = string.Format(GlobalManager.MLanguage.Entry(purchaseConfirmationId), entryNameText.text, entryValueText.text);
            dialogMode = true;
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIStartDialogOKCancel, this, dialogMessage);
        }

        void OnGUIOKButtonPressed(object sender, InstantMessageArgs args)
        {
            if (dialogMode)
            {
                dialogMode = false;
                GlobalManager.MPurchase.BuyProduct(entryId);
            }
        }

        void OnGUICancelButtonPressed(object sender, InstantMessageArgs args)
        {
            dialogMode = false;
        }

    }
}
