/*
 * File:        BlurScreenShotManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class BlurScreenShotManager manages taking and storing blurry screenshots of a current scene
 * Created:     08.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.ImageProcessing
{
    public class BlurScreenShotManager : GenericManager
    {

        [SerializeField]
        protected Texture2D blurTexture;
        public Texture2D BlurTexture
        {
            get
            {
                return blurTexture;
            }
        }

        public void TakeShot()
        {
            blurTexture = new Texture2D(Screen.width, Screen.height);
            //blurTexture = new Texture2D(512, 256, TextureFormat.ARGB32, false);
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.ShopTakeBlurryScreenshot, this, blurTexture);
        }

    }
}
