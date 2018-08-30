using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.ImageProcessing
{
    // this class creates a "source" image out from the STRESS ("final") image
    public class SourceImageCreator : MonoBehaviour
    {

        public static SourceImageCreator instance;
        public int TileSizePx = 128;
        bool sourceGenerated;
        Texture2D sourceTexture;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
                sourceGenerated = false;
                sourceTexture = new Texture2D(2, 2);
            }
            else if (instance != this)
            {
                Destroy(gameObject);
            }
            sourceGenerated = false;
        }

        public Texture2D GetSourceImage(int level)
        {
            if (!sourceGenerated)
            {
                if (GlobalManager.MStressImage.HasFinalImage(level))
                {
                    // get level parameters
                    LevelDataManager.Descriptor ld = GlobalManager.MLevel.GetLevelDescriptor(level);
                    // load STRESS ("final") image as is
                    string stressImage = StressImageCreator.StressedFinalImageFile(level);
                    //Debug.Log ("Loading stress image from file " + stressImage);
                    Texture2D tex = new Texture2D(2, 2, TextureFormat.RGB24, false);
                    tex.LoadImage(System.IO.File.ReadAllBytes(stressImage));

                    // these are the original "source" image dimensions
                    int xSize = ld.init.width * TileSizePx;
                    int ySize = ld.init.height * TileSizePx;
                    // this is a "source" image aspect ratio
                    float sFactor = (float)xSize / (float)ySize;
                    int sxSize = tex.width;
                    int sySize = tex.height;
                    //Debug.Log ("Final image size: " + sxSize.ToString () + "x" + sySize.ToString ());
                    // this is a "final" image aspect ratio
                    float fFactor = (float)sxSize / (float)sySize;

                    // these factors create an image with proper proportions
                    float sxFactor = (ld.init.finalXYScale > fFactor) ? (ld.init.finalXYScale / fFactor) : 1f;
                    float syFactor = (ld.init.finalXYScale < fFactor) ? (fFactor / ld.init.finalXYScale) : 1f;

                    // these are the dimensions of the resulting "source" image

                    int rxSize = (sFactor > ld.init.finalXYScale) ? sxSize : (int)((float)sySize * syFactor * sFactor / sxFactor);
                    int rySize = (sFactor < ld.init.finalXYScale) ? sySize : (int)((float)sxSize * sxFactor / sFactor / syFactor);

                    // now create a texture with the "source" image dimensions
                    sourceTexture = new Texture2D(rxSize, rySize);
                    //Debug.Log ("New texture size: " + sourceTexture.width.ToString () + "x" + sourceTexture.height.ToString ());

                    // and copy the appropriate pixels of "final" image into it
                    sourceTexture.SetPixels(tex.GetPixels((tex.width - rxSize) / 2, (tex.height - rySize) / 2, rxSize, rySize));
                    sourceTexture.Apply();
                    sourceGenerated = true;
                    //} else {
                    //Debug.Log ("No final image for level " + level.ToString ());
                }
            }
            return sourceTexture;
        }
    }
}
