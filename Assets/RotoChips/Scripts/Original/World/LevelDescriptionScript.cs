using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// this class iplements a layout of level description dialog
public class LevelDescriptionScript : MonoBehaviour
{

    public GameObject listener;
    public ShiveringMessage shiveringMessage;

    public GameObject DescriptionDialog;
    public GameObject TitleText;
    public GameObject VDescriptionImage;
    public GameObject HDescriptionImage;
    public GameObject VDescriptionText;
    public GameObject HDescriptionText;
    public GameObject CompletionText;

    public string TitlePrefix = "LevelTitle";
    public string DescriptionPrefix = "LevelDescription";
    public string CompletionTextIndex = "CompletionText";

    public Vector2 maxHorizontalSize;
    public Vector2 maxVerticalSize;

    //public int LevelID = 0;

    // Use this for initialization
    /*
	void Start () {
		ShowDescription(LevelID);
	}
	*/
    // Update is called once per frame
    /*
	void Update () {
		
	}
	*/

    public void ShowDescription(int level)
    {
        // get level data
        LevelData.Descriptor ld = LevelData.instance[level];
        string levelStr = level.ToString("D3");
        TitleText.GetComponent<Text>().text = LocalizationManager.instance.GetLocalizedValue(TitlePrefix + levelStr);
        GameObject activeImage, inactiveImage;
        GameObject activeText, inactiveText;

        bool horizontal = ld.init.finalXYScale >= 1f;
        // set up image dimensions and the dialog layout depending on "horizontal" or @vertical" image orientation

        float finalImageWidth;
        float finalImageHeight;
        if (horizontal) // the maximum height of the image is fixed
        {
            finalImageHeight = maxHorizontalSize.y;
            finalImageWidth = finalImageHeight * ld.init.finalXYScale;
            if (finalImageWidth > maxHorizontalSize.x)
            {
                finalImageWidth = maxHorizontalSize.x;
                finalImageHeight = finalImageWidth / ld.init.finalXYScale;
            }
            activeImage = HDescriptionImage;
            inactiveImage = VDescriptionImage;
            activeText = HDescriptionText;
            inactiveText = VDescriptionText;
        }
        else
        {
            // the maximum width of the image is fixed
            finalImageWidth = maxVerticalSize.x;
            finalImageHeight = finalImageWidth / ld.init.finalXYScale;
            if (finalImageHeight > maxVerticalSize.y)
            {
                finalImageHeight = maxVerticalSize.y;
                finalImageWidth = finalImageHeight * ld.init.finalXYScale;
            }
            activeImage = VDescriptionImage;
            inactiveImage = HDescriptionImage;
            activeText = VDescriptionText;
            inactiveText = HDescriptionText;
        }

        // activate active objects
        activeImage.SetActive(true);
        activeText.SetActive(true);
        // load "smooth" image
        activeImage.GetComponent<RawImage>().texture = Resources.Load<Texture>(ld.GraphicsResource + "/smooth");
        // and set up its size
        activeImage.GetComponent<RectTransform>().localScale = new Vector3(finalImageWidth, finalImageHeight, 1.0f);
        // set text objects
        activeText.GetComponent<Text>().text = LocalizationManager.instance.GetLocalizedValue(DescriptionPrefix + levelStr);
        // deactivate inactive objects
        inactiveImage.SetActive(false);
        inactiveText.SetActive(false);

        CompletionText.GetComponent<Text>().text = LocalizationManager.instance.GetLocalizedValue(CompletionTextIndex);
        // now activate the description dialog
        DescriptionDialog.SetActive(true);
        StartCoroutine(shiveringMessage.shiverAtStart());
    }

    // button action
    public void Action()
    {
        if (listener)
        {
            listener.SendMessage("LevelDescriptionClosed");
        }
        // now deactivate the description dialog
        DescriptionDialog.SetActive(false);
    }
}
