/*
 * File:        PurchasingManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class PurchasingManager manages IAP in the application stores
 * Created:     04.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using RotoChips.Management;
using RotoChips.Generic;
using RotoChips.Data;
using RotoChips.Utility;

namespace RotoChips.Accounting
{
    [System.Serializable]
    public class ProductDesc
    {
        public string id;
        public SerializableDecimal price;
        public SerializableDecimal value;
        [HideInInspector]
        public string localizedDescription;
        public string descriptionId;
        [HideInInspector]
        public string localizedPrice;
        public ProductType type;
    }

    public class PurchasingManager : GenericManager, IStoreListener
    {
        protected PurchasingManagerData data;

        [SerializeField]
        protected string postfixAppStore = "_apple";
        [SerializeField]
        protected string postfixGooglePlay = "_google";

        private static IStoreController storeController;
        private static IExtensionProvider extensionProvider;

        // GenericManager overrides
        public override void MakeInitial()
        {
            data = GetComponentInChildren<PurchasingManagerData>();
            // debug
            foreach(ProductDesc product in data.products)
            {
                Debug.Log("Product " + product.id + " price: " + product.price.value.ToString() + ", value: " + product.value.value.ToString());
            }
            InitializePurchasing();
            base.MakeInitial();
        }

        // purchase processing
        bool IsPurchasingInitialized()
        {
            // Only report we are initialized if both the Purchasing regerences are set.
            return storeController != null && extensionProvider != null;
        }

        void InitializePurchasing()
        {
            if (!IsPurchasingInitialized())
            {
                ConfigurationBuilder configurationBuilder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
                foreach (ProductDesc product in data.products)
                {
                    configurationBuilder.AddProduct(
                        product.id,
                        product.type,
                        new IDs
                        {
                            { product.id + postfixAppStore, AppleAppStore.Name },
                            { product.id + postfixGooglePlay, GooglePlay.Name }
                        }
                    );
                }
                UnityPurchasing.Initialize(this, configurationBuilder);
            }
        }

        public void BuyProduct(string productId)
        {
            if (IsPurchasingInitialized())
            {
                Product product = storeController.products.WithID(productId);
                if (product != null && product.availableToPurchase)
                {
                    Debug.Log(string.Format("Purchasing product asynchronously: '{0}'", product.definition.id));
                    storeController.InitiatePurchase(product);
                }
                else
                {
                    Debug.Log("BuyProduct(" + productId + ") FAILED: Not purchasing product, either it is not found or not available for purchase");
                }
            }
            else
            {
                Debug.Log("BuyProduct(" + productId + ") FAILED: Purchasing no initialized");
            }
        }

        public ProductDesc ProductById(string productId)
        {
            foreach (ProductDesc product in data.products)
            {
                if (productId == product.id)
                {
                    // provide localized description and price strings in case there are no metadata onfo in the app store
                    product.localizedDescription = GlobalManager.MLanguage.Entry(product.descriptionId);
                    product.localizedPrice = string.Format("{0:C}", product.price.value);
                    if (IsPurchasingInitialized())
                    {
                        Product storeProduct = storeController.products.WithID(productId);
                        if (storeProduct != null)
                        {
                            product.localizedDescription = storeProduct.metadata.localizedTitle;
                            product.localizedPrice = storeProduct.metadata.localizedPriceString;
                        }
                    }
                    return product;
                }
            }
            return null;
        }

        // Restore purchases made by this customer. Some platforms automatically restore purchases. like Google.
        // Apple currently requires explicit purchase restoration for IAP, conditionally displaying a password prompt.
        public void RestorePurchases()
        {
            if (IsPurchasingInitialized())
            {
                if (Application.platform == RuntimePlatform.IPhonePlayer)
                {
                    Debug.Log("RestorePurchases STARTED");
                    IAppleExtensions appleExtensions = extensionProvider.GetExtension<IAppleExtensions>();
                    // Begin the asynchronous process of restoring purchases. Expect a confirmation response in the Action below,
                    // and ProcessPurchase if there are previously purchased products to restore.
                    appleExtensions.RestoreTransactions(
                        (result) =>
                        {
                            // The first phase of restoration. If no more responses are recieved on ProcessPurchase
                            // then no purchases are available to be restored.
                            Debug.Log("RestorePurchases CONTINUED: " + result + ". If no further messages, no more purchases are available to restore");
                        }
                    );
                }
                else
                {
                    // We are not running on an Apple device. No work is necessary to restore purchases.
                    Debug.Log("RestorePurchases FAILED: Not supported on this platform (" + Application.platform + ")");
                }
            }
            else
            {
                Debug.Log("RestorePurchases FAILSED: Not initialized");
            }
        }

        // IStoreListener methods implementation
        public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
        {
            // Purchasing has succeeded initializing. Collect our Purchasing references
            Debug.Log("OnInitialized: PASS");

            storeController = controller;
            extensionProvider = extensions;
        }

        public void OnInitializeFailed(InitializationFailureReason error)
        {
            // Purchasing set-up has not succeeded. Check error for reason. Consider sharing this reason with the user
            Debug.Log("OnInitializedFailed InitializationFailureReason: " + error);
        }

        public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
        {
            // A consumable product has been purchased by this user.
            foreach (ProductDesc product in data.products)
            {
                if (string.Equals(args.purchasedProduct.definition.id, product.id, System.StringComparison.Ordinal))
                {
                    Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.ShopPurchaseComplete, this, product);
                    return PurchaseProcessingResult.Complete;
                }
            }

            Debug.Log(string.Format("ProcessPurchase: FAILED. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));
            return PurchaseProcessingResult.Complete;
        }

        public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
        {
            // A product purchase attempt did not succeed. Check failureReason for more detail.
            // Consider sharing this failureReason with the user to guide their troubleshooting actions.
            Debug.Log(string.Format("OnPurchaseFailed: FAILED. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
        }

    }
}
