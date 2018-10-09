/*
 * File:        BlurCameraController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class BlurCameraController controls a special camera at the Puzzle scene which takes blurry screenshots for the Shop scene
 * Created:     08.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Generic;
using RotoChips.Management;

namespace RotoChips.Puzzle
{
    public class BlurCameraController : GenericMessageHandler
    {

        protected Camera controlledCamera;
        protected override void AwakeInit()
        {
            controlledCamera = GetComponent<Camera>();
            registrator.Add(new Management.MessageRegistrationTuple { type = InstantMessageType.ShopTakeBlurryScreenshot, handler = OnShopTakeBlurryScreenshot });
        }

        void OnShopTakeBlurryScreenshot(object sender, InstantMessageArgs args)
        {
            Texture2D texture = (Texture2D)args.arg;
            gameObject.SetActive(true);
            StartCoroutine(TakeScreenshot(texture));
        }

        IEnumerator TakeScreenshot(Texture2D texture)
        {
            // wait while the screen clears of dialogs and similar objects
            yield return null;
            Camera mainCamera = Camera.main;
            controlledCamera.transform.position = mainCamera.transform.position;
            controlledCamera.transform.localRotation = mainCamera.transform.localRotation;
            RenderTexture renderTexture = new RenderTexture(texture.width, texture.height, 24, RenderTextureFormat.ARGB32);
            RenderTexture currentActiveRenderTexture = RenderTexture.active;
            RenderTexture.active = renderTexture;
            controlledCamera.targetTexture = renderTexture;
            controlledCamera.Render();
            texture.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
            texture.Apply();
            RenderTexture.active = currentActiveRenderTexture;
            gameObject.SetActive(false);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.ShopBlurryScreenshotTaken, this);
        }
    }
}
