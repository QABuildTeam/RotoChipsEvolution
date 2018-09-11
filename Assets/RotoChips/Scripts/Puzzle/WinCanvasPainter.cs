/*
 * File:        WinCanvasPainter.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WinCanvasPainter fades the stressImage of the WinCanvas step by step
 * Created:     11.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;

namespace RotoChips.Puzzle
{
    public class WinCanvasPainter : MonoBehaviour
    {

        [SerializeField]
        protected RawImage stressImage;
        [SerializeField]
        protected Texture2D brushTexture;   // source texture for brush (non-volatile, it paints on the upper image texture)

        Texture2D painterTexture;
        Color[] brushPixels;                // color array for the brush texture

        int startX, startY;                 // a starting point for the "water brush"
        int deltaX, deltaY;                 // x- and y-offsets for the brush on each step

        int xSteps, ySteps;                 // number of steps on x- and y- coordinates, respectively

        MessageRegistrator registrator;
        // Use this for initialization
        void Start()
        {
            // make the stress image texture modifiable
            Texture2D upperTexture = (Texture2D)(stressImage.texture);
            painterTexture = new Texture2D(upperTexture.width, upperTexture.height, TextureFormat.RGBA32, false);
            painterTexture.SetPixels32(upperTexture.GetPixels32());
            painterTexture.Apply();
            stressImage.texture = painterTexture;

            brushPixels = brushTexture.GetPixels(0, 0, brushTexture.width, brushTexture.height);

            deltaX = brushTexture.width / 2 - 4;    // painting steps are a bit less than the brush dimensions
            deltaY = brushTexture.height / 2 - 4;   // so that brush traces overlap
            startX = 4;
            startY = 4;
            xSteps = (painterTexture.width - startX / 2) / deltaX - 3;
            ySteps = (painterTexture.height - startY / 2) / deltaY - 3;

            registrator = new MessageRegistrator(InstantMessageType.PuzzleShowWinimage, (InstantMessageHandler)OnPuzzleShowWinimage);
            registrator.RegisterHandlers();
            gameObject.SetActive(false);
            // Debug
            //StartCoroutine(Painter());
        }

        // this is the main painter loop
        IEnumerator Painter()
        {
            int cX = startX;
            int cY = startY;

            for (int y = 0; y < ySteps; y++)
            {
                cY += deltaY;
                if (y % 2 == 0)
                {
                    cX -= deltaX;
                }
                else
                {
                    cX += deltaX;
                }
                for (int x = 0; x < xSteps; x++)
                {
                    if (y % 2 == 0)
                    {
                        cX += deltaX;
                    }
                    else
                    {
                        cX -= deltaX;
                    }
                    yield return null;
                    // get a part of source texture for upper image into a small buffer sized by brushTexture dimensions
                    Color[] pixelBuffer = painterTexture.GetPixels(cX, cY, brushTexture.width, brushTexture.height);
                    int bufferSize = pixelBuffer.Length;  // optimization
                    for (int i = 0; i < bufferSize; i++)
                    {
                        pixelBuffer[i].a *= brushPixels[i].a;           // multiply buffer pixels' opacity with brush opacity values
                    }
                    // put buffer pixels back to the modifiable upper image texture
                    painterTexture.SetPixels(cX, cY, brushTexture.width, brushTexture.height, pixelBuffer);
                    painterTexture.Apply();
                }
            }
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleWinImageFinished, this);

        }

        // message handling
        void OnPuzzleShowWinimage(object sender, InstantMessageArgs args)
        {
            gameObject.SetActive(true);
            StartCoroutine(Painter());
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
