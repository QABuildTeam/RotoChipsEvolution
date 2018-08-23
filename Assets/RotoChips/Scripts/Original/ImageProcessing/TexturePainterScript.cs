using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// this class implements a "wet brush painter" effect on an image
// it uses already preloaded images
public class TexturePainterScript : MonoBehaviour {

    public RawImage upperRawImage;		// upper image
	public Texture2D brushTexture;		// source texture for brush (non-volatile, it paints on the upper image texture)
	public GameObject listener;			// a listener GameObject, receiving message "PainterFinished" (actually an ImageScaler class)

	Color[] brushPixels;                // color array for the brush texture
    int startX, startY;					// a starting point for the "water brush"
    int deltaX, deltaY;					// x- and y-offsets for the brush on each step

	int xSteps, ySteps;                 // number of steps on x- and y- coordinates, respectively
    Texture2D painterUpperTexture;		// modifiable texture for the image
	public bool stopPainting;


	// this is the main painter trigger
    public void PaintTexture()
    {
		stopPainting = false;
		Texture2D upperTexture = (Texture2D)(upperRawImage.texture);
		//Debug.Log ("upperTexture: width=" + upperTexture.width.ToString () + ", height=" + upperTexture.height.ToString () + ", format=" + upperTexture.format.ToString ());
		painterUpperTexture = new Texture2D (upperTexture.width, upperTexture.height, TextureFormat.RGBA32, false);
		painterUpperTexture.SetPixels32 (upperTexture.GetPixels32 ());
        //painterUpperTexture.LoadRawTextureData(upperTexture.GetRawTextureData());
		//painterUpperTexture.LoadImage(upperTexture.GetRawTextureData());
		//painterUpperTexture.Resize (upperTexture.width, upperTexture.height, TextureFormat.RGBA32, false);
        painterUpperTexture.Apply();
		//Debug.Log ("painterUpperTexture.format=" + painterUpperTexture.format.ToString ());
        upperRawImage.texture = painterUpperTexture;

		brushPixels = brushTexture.GetPixels(0, 0, brushTexture.width, brushTexture.height);

		deltaX = brushTexture.width / 2 - 4;	// painting steps are a bit less than the brush dimensions
		deltaY = brushTexture.height / 2 - 4;	// so that brush traces overlap
		startX = 4;
		startY = 4;
		xSteps = (painterUpperTexture.width - startX / 2) / deltaX - 3;
		ySteps = (painterUpperTexture.height - startY / 2) / deltaY - 3;
		StartCoroutine (painter ());
    }

	// this is the main painter loop
	IEnumerator painter() {
		int cX = startX;
		int cY = startY;

		for (int y = 0; y < ySteps && !stopPainting; y++) {
			cY += deltaY;
			if (y % 2 == 0) {
				cX -= deltaX;
			} else {
				cX += deltaX;
			}
			for (int x = 0; x < xSteps && !stopPainting; x++) {
				if (y % 2 == 0) {
					cX += deltaX;
				} else {
					cX -= deltaX;
				}
				yield return new WaitForFixedUpdate ();
				// get a part of source texture for upper image into a small buffer sized by brushTexture dimensions
				Color[] pixelBuffer = painterUpperTexture.GetPixels(cX, cY, brushTexture.width, brushTexture.height);
				int bufferSize = pixelBuffer.GetUpperBound(0) + 1;	// optimization
				for (int i = 0; i < bufferSize; i++)
				{
					pixelBuffer[i].a *= brushPixels[i].a;			// multiply buffer pixels' opacity with brush opacity values
				}
				// put buffer pixels back to the modifiable upper image texture
				painterUpperTexture.SetPixels(cX, cY, brushTexture.width, brushTexture.height, pixelBuffer);
				painterUpperTexture.Apply();
			}
		}
		if (listener != null) {
			listener.SendMessage ("PainterFinished");
		}

	}

	public void StopPainter() {
		stopPainting = true;
	}

}
