/*
 * File:        GenericManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class StressImageCreator processes source ("smooth") images into STRESSed images, doing this in background
 * Created:     23.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;
using RotoChips.Generic;
using RotoChips.Data;

// STRESS images creator
// Spatio-Temporal Retinex-Inspired Envelope with Stochastic Sampling
// Based on:
// Kolås, Ø., Farup, I. & Rizzi, A. (2011). Spatio-Temporal Retinex-Inspired Envelope with Stochastic Sampling: A Framework for Spatial Color Algorithms. Journal of Imaging Science and Technology, 55 (4)
// https://brage.bibsys.no/xmlui/handle/11250/142542
// Originally published at http://www.imaging.org/
// An implementation from GEGL library (http://www.gegl.org/) has also helped a lot
// Creates STRESS images from source images in background and saves them into files

namespace RotoChips.ImageProcessing
{
    public class StressImageCreator : GenericManager
    {
        // based on GEGL (Generic Graphic Library fpr GIMP) STRESS, Spatio Temporal Retinex Envelope with Stochastic Sampling
        Texture2D originalImage;
        Texture2D stressedImage;

        Dictionary<int, bool> hasStressFile;    // a dictionary of flags if stress files have already been generated

        int[,] nbradii;                     // an array of random radii in the neighbourhood of a point
        public int neighboursCount = 100;   // the size of nbradii
        public float radiusPower = 2.0f;
        public const float eps = 0.001f;    // epsilon (float zero accuracy)
        public float stressRadius = 200f;   // radius of the neighbourhood of a point
        public int samplesCount = 5;        // number of samples to get in neighbourhood for an average broghtness computation
        public int iterationsCount = 5;     // number of iterations of getting samples
        static int radiusCount = 0;         // static index of nbradii; points to the next random radius
        public int breakCycle = 1024;       // do a yield on this pixel while STRESSing the image

        // this auxillary method creates an array of random radii in the neighbourhood of a point
        void ComputeNeighbourhood()
        {
            nbradii = new int[neighboursCount, 2];
            float goldenAngle = Mathf.PI * (3.0f - Mathf.Sqrt(5.0f));   //from Wikipedia
            float rangle = 0f;
            for (int i = 0; i < neighboursCount; i++)
            {
                float rradius = stressRadius * Mathf.Pow(Random.value, radiusPower);
                nbradii[i, 0] = (int)(rradius * Mathf.Cos(rangle));     // x-component
                nbradii[i, 1] = (int)(rradius * Mathf.Sin(rangle));     // y-component
                rangle += goldenAngle;
            }
        }

        IEnumerator BgStressImage(int level)
        {
            float startTime = Time.realtimeSinceStartup;
            string sourceGraphicResource = LevelDataManager.SmoothImageResource(level);
            originalImage = Resources.Load<Texture2D>(sourceGraphicResource);
            //Debug.Log("StressImageCreator.BgStressImage: creating STRESS image from " + sourceGraphicResource + " as " + (originalImage == null ? "null" : originalImage.ToString()));
            int w = originalImage.width;
            int h = originalImage.height;
            //stressedImage = new Texture2D(w, h, originalImage.format, false);
            // only RGBA32 textures are allowed to be written into
            stressedImage = new Texture2D(w, h, TextureFormat.RGBA32, false);
            Color[] ic = originalImage.GetPixels();
            Color[] oc = new Color[w * h];
            int coffset = 0;
            Color c = new Color();
            Color cmin = c;
            Color cmax = c;
            // scan the pixels and calculate the output values
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++, coffset++)
                {
                    c = ic[coffset];
                    cmin = c;
                    cmax = c;
                    float range = 0f;
                    float brightness = 0f;
                    float[] relativeBrightness = new float[4];
                    float[] relativeRange = new float[4];
                    // compute a pixel value
                    for (int j = 0; j < iterationsCount; j++)
                    {
                        // get minimum and maximum color values from the neighbourhood
                        int smax = samplesCount;
                        for (int i = 0; i < smax;)
                        {
                            int xn = x + nbradii[radiusCount, 0];
                            int yn = y + nbradii[radiusCount, 1];
                            if (xn >= 0 && xn < w && yn >= 0 && yn < h)
                            {
                                Color cnb = ic[yn * w + xn];
                                // loop unwrap
                                cmin.r = Mathf.Min(cmin.r, cnb.r);
                                cmin.g = Mathf.Min(cmin.g, cnb.g);
                                cmin.b = Mathf.Min(cmin.b, cnb.b);
                                cmax.r = Mathf.Max(cmax.r, cnb.r);
                                cmax.g = Mathf.Max(cmax.g, cnb.g);
                                cmax.b = Mathf.Max(cmax.b, cnb.b);
                                /*
                                for (int ci = 0; ci < 3; ci++)
                                {
                                    cmin[ci] = Mathf.Min(cmin[ci], cnb[ci]);
                                    cmax[ci] = Mathf.Max(cmax[ci], cnb[ci]);
                                }
                                */
                                i++;
                            }
                            /*else
                            {
                                smax--;
                            }*/
                            radiusCount++;
                            if (radiusCount >= neighboursCount)
                            {
                                radiusCount = 0;
                            }
                        }
                        // now calculate cumulative brightness and dynamic range for every color component
                        // loop unwrap
                        range = cmax.r - cmin.r;
                        brightness = 0.5f;
                        if (range > eps)
                        {
                            brightness = (c.r - cmin.r) / range;
                        }
                        relativeBrightness[0] += brightness;
                        relativeRange[0] += range;
                        range = cmax.g - cmin.g;
                        brightness = 0.5f;
                        if (range > eps)
                        {
                            brightness = (c.g - cmin.g) / range;
                        }
                        relativeBrightness[1] += brightness;
                        relativeRange[1] += range;
                        range = cmax.b - cmin.b;
                        brightness = 0.5f;
                        if (range > eps)
                        {
                            brightness = (c.b - cmin.b) / range;
                        }
                        relativeBrightness[2] += brightness;
                        relativeRange[2] += range;
                        /*
                        for (int ci = 0; ci < 3; ci++)
                        {
                            range = cmax[ci] - cmin[ci];
                            brightness = 0.5f;
                            if (range > eps)
                            {
                                brightness = (c[ci] - cmin[ci]) / range;
                            }
                            relativeBrightness[ci] += brightness;
                            relativeRange[ci] += range;
                        }
                        */
                    }
                    // now calculate max and min envelopes
                    // loop unwrap
                    brightness = relativeBrightness[0] / iterationsCount;
                    range = relativeRange[0] / iterationsCount;
                    cmax.r = c.r + (1.0f - brightness) * range;
                    cmin.r = c.r - brightness * range;
                    brightness = relativeBrightness[1] / iterationsCount;
                    range = relativeRange[1] / iterationsCount;
                    cmax.g = c.g + (1.0f - brightness) * range;
                    cmin.g = c.g - brightness * range;
                    brightness = relativeBrightness[2] / iterationsCount;
                    range = relativeRange[2] / iterationsCount;
                    cmax.b = c.b + (1.0f - brightness) * range;
                    cmin.b = c.b - brightness * range;
                    // now calculate the final value
                    float delta = cmax.r - cmin.r;
                    if (delta > eps)
                    {
                        c.r = (c.r - cmin.r) / delta;
                    }
                    else
                    {
                        c.r = 0.5f;
                    }
                    delta = cmax.g - cmin.g;
                    if (delta > eps)
                    {
                        c.g = (c.g - cmin.g) / delta;
                    }
                    else
                    {
                        c.g = 0.5f;
                    }
                    delta = cmax.b - cmin.b;
                    if (delta > eps)
                    {
                        c.b = (c.b - cmin.b) / delta;
                    }
                    else
                    {
                        c.b = 0.5f;
                    }

                    /*
                    for (int ci = 0; ci < 3; ci++)
                    {
                        brightness = relativeBrightness[ci] / iterationsCount;
                        range = relativeRange[ci] / iterationsCount;
                        cmax[ci] = c[ci] + (1.0f - brightness) * range;
                        cmin[ci] = c[ci] - brightness * range;
                        float delta = cmax[ci] - cmin[ci];
                        if (delta > eps)
                        {
                            c[ci] = (c[ci] - cmin[ci]) / delta;
                        }
                        else
                        {
                            c[ci] = 0.5f;
                        }
                    }
                    */
                    // fill the output buffer
                    oc[coffset] = c;
                    // every n-th pixel do a break for the next frame
                    if (coffset % breakCycle == breakCycle - 1)
                    {
                        //Debug.Log("STRESS pixel " + coffset.ToString());
                        //yield return new WaitForFixedUpdate();
                        yield return null;
                    }
                }
            }
            stressedImage.SetPixels(oc);
            stressedImage.Apply();
            float endTime = Time.realtimeSinceStartup;
            Debug.Log("stress time " + level.ToString() + ": " + (endTime - startTime).ToString());
            // now try to save the stressed image into a file
            var bytes = stressedImage.EncodeToJPG();
            string imageFileName = StressedFinalImageFilename(level);
            Debug.Log("Writing data to file " + imageFileName);
            System.IO.File.WriteAllBytes(imageFileName, bytes);
            hasStressFile[level] = true;
        }

        // this method returns the name of the stress image file for a specified level
        public static string StressedFinalImageFilename(int level)
        {
            if (level < 0 || level >= LevelData.initializers.Length)
            {
                return "";
            }
            return Application.persistentDataPath + "/final" + level.ToString("D3") + ".jpg";
        }

        // this method fills the hasStressFile dictionary with appropriate flags:
        // a flag is set to true if a STRESS file for a level exists
        // and false otherwise
        void SetFileFlags()
        {
            hasStressFile = new Dictionary<int, bool>();
            foreach (LevelDataManager.Descriptor ld in GlobalManager.MLevel.LevelDescriptors())
            {
                hasStressFile[ld.init.id] = System.IO.File.Exists(StressedFinalImageFilename(ld.init.id));
            }
        }

        // this method deletes all generated stress image files
        void ClearStressFiles()
        {
            hasStressFile = new Dictionary<int, bool>();
            foreach (LevelDataManager.Descriptor ld in GlobalManager.MLevel.LevelDescriptors())
            {
                string fn = StressedFinalImageFilename(ld.init.id);
                if (System.IO.File.Exists(fn))
                {
                    System.IO.File.Delete(fn);
                }
                hasStressFile[ld.init.id] = false;
            }
        }

        // this method pre-generates stress files
        // needed for an intro story
        [SerializeField]
        // this is the list of stress images ids neede for the intro story
        // it should end with the id 0
        protected int[] pregeneratedStressImages;
        IEnumerator PreGenerateStressFiles()
        {
            foreach (int levelId in pregeneratedStressImages)
            {
                if (!HasFinalImageFile(levelId))
                {
                    StartCoroutine(BgStressImage(levelId));
                    while (!HasFinalImage(levelId))
                    {
                        yield return null;
                    }
                }
            }
        }

        // this method checks for stress image files presence
        // and starts their generation if needed
        IEnumerator GenerateStressFiles()
        {
            foreach (LevelDataManager.Descriptor ld in GlobalManager.MLevel.LevelDescriptors())
            {
                if (!HasFinalImageFile(ld.init.id))
                {
                    //Debug.Log ("Generating stress image #" + i.ToString ());
                    StartCoroutine(BgStressImage(ld.init.id));
                    while (!HasFinalImage(ld.init.id))
                    {
                        yield return null;
                    }
                }
            }
        }

        // this method tells if there is a valid stress image file
        public bool HasFinalImageFile(int levelId)
        {
            bool has = false;
            if (hasStressFile.TryGetValue(levelId, out has))
            {
                return has;
            }
            return false;
        }

        public bool HasFinalImage(int levelId)
        {
            return true;
        }

        public override void MakeInitial()
        {
            /*
            ComputeNeighbourhood();
            SetFileFlags();
            */
            base.MakeInitial();
        }

        public override void MakeLoading()
        {
            // MakeLoading only generates stress images needed for the intro
            /*
            StartCoroutine(PreGenerateStressFiles());
            */
            base.MakeLoading();
        }

        public override void MakeReady()
        {
            //StartCoroutine(CheckStressFile());
            base.MakeReady();
        }

        IEnumerator CheckStressFile()
        {
            while (!HasFinalImage(0))
            {
                yield return null;
            }
            // ok, all intro stress images are generated
            // now generate the rest
            StartCoroutine(GenerateStressFiles());
        }
    }
}
