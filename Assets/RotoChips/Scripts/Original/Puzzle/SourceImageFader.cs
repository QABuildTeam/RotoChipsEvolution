using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using RotoChips.Management;
using RotoChips.ImageProcessing;

public class SourceImageFader : MonoBehaviour {

    public float srcSizeFactor;                         // = 7.5f
    public float originalScreenAspectRatio = 4f / 3f;

    public float fadeDuration;
    public int fadeCount;
    public GameObject GameControllerObject;
    Image SourceImage;
    Text SourceText;
	Outline SourceTextOutline;
    Image SourceImageBackground;
    Color imageFadeColor;
    Color textFadeColor;
	Color outlineFadeColor;
    float screenAspectRatio;
    float sourceImageWidth;
    float sourceImageHeight;

	// Use this for initialization
	void Start () {
		LevelDataManager.Descriptor ld = GlobalManager.MLevel.GetLevelDescriptor(GlobalManager.MStorage.SelectedLevel);
        screenAspectRatio = (float)(Screen.width) / (float)(Screen.height);
        float sizeFactor = srcSizeFactor * originalScreenAspectRatio / screenAspectRatio;
        if (screenAspectRatio > ld.init.srcXYScale)
        {
            sourceImageHeight = sizeFactor;
            sourceImageWidth = sourceImageHeight * ld.init.srcXYScale;
        }
        else
        {
            sourceImageWidth = sizeFactor * screenAspectRatio;
            sourceImageHeight = sourceImageWidth / ld.init.srcXYScale;
        }
        GameObject SourceImageSprite = GameObject.Find("SourceImageSprite");
        SourceImage = SourceImageSprite.GetComponent<Image>();
        SourceText = GameObject.Find("SourceImageText").GetComponent<Text>();
		SourceTextOutline = GameObject.Find ("SourceImageText").GetComponent<Outline> ();
        SourceImageBackground = GameObject.Find("SourceImageBackground").GetComponentInChildren<Image>();
        //SourceImage.sprite = Resources.Load<Sprite>(ld.GraphicsResource + "/source");
		// create "source" image from the "final" image on the fly
		Texture2D tex = SourceImageCreator.instance.GetSourceImage (ld.init.id);
		Rect r = new Rect (new Vector2 (0, 0), new Vector2 (tex.width, tex.height));
		SourceImage.sprite = Sprite.Create (tex, r, Vector2.zero);
        SourceImageSprite.GetComponent<RectTransform>().localScale = new Vector3(sourceImageWidth, sourceImageHeight, 1.0f);

        // the source image is shown in full just after the start
        imageFadeColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        textFadeColor = SourceText.color;
		outlineFadeColor = SourceTextOutline.effectColor;
        textFadeColor.a = 1f;
		outlineFadeColor.a = 1f;
        SourceImage.color = imageFadeColor;
        SourceText.color = textFadeColor;
		SourceTextOutline.effectColor = outlineFadeColor;
        imageFadeColor.a = 1.0f;
        SourceImageBackground.color = imageFadeColor;
        // but its text will be set according the result of the puzzle state restoration
        //ShowSourceImage("TAP TO START");
    }

    IEnumerator SourceImageLoop(float startVal, float endVal, float deltaVal, bool closeAfter)
    {
        imageFadeColor.a = startVal;
        textFadeColor.a = startVal;
		outlineFadeColor.a = startVal;
        gameObject.SetActive(true);
        float fadeTime = fadeDuration / fadeCount;
        yield return new WaitForFixedUpdate();
        for (int i = 0; i < fadeCount; i++)
        {
            imageFadeColor.a += deltaVal;
            textFadeColor.a += deltaVal;
			outlineFadeColor.a += deltaVal;
            SourceImage.color = imageFadeColor;
            SourceText.color = textFadeColor;
			SourceTextOutline.effectColor = outlineFadeColor;
            SourceImageBackground.color = imageFadeColor;
            yield return new WaitForSeconds(fadeTime);
        }
        imageFadeColor.a = endVal;
        textFadeColor.a = endVal;
		outlineFadeColor.a = endVal;
        SourceImage.color = imageFadeColor;
        SourceText.color = textFadeColor;
		SourceTextOutline.effectColor = outlineFadeColor;
        SourceImageBackground.color = imageFadeColor;
        if (closeAfter)
        {
            gameObject.SetActive(false);
            GameControllerObject.SendMessage("SourceImageClosed");
        }
    }

    public void ShowSourceImage(string textToShow)
    {
        SourceText.text = textToShow;
        gameObject.SetActive(true);
        StartCoroutine(SourceImageLoop(0f, 1f, 1f / fadeCount, false));
    }

    public void HideSourceImage()
    {
        StartCoroutine(SourceImageLoop(1f, 0f, -1f / fadeCount, true));
    }

    public void setInitialText(string textToShow)
    {
        SourceText.text = textToShow;
    }

}
