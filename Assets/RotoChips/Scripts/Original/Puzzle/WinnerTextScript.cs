using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerTextScript : MonoBehaviour
{
	public bool isLastLevel = false;
	public GameObject winnerTextObject;
	Text winnerText;
	//WhiteCurtainFader wcf;
	public GameObject WinnerFader;
	public string WorldSelectLevel;
	public string FinalSceneLevel;

	// Use this for initialization
	void Start()
	{
		//wcf = WinnerFader.GetComponent<WhiteCurtainFader>();
		winnerText = winnerTextObject.GetComponent<Text>();
		setBanner();
	}

	void setText(string aText)
	{
		winnerText.text = aText;
	}

	void clearText()
	{
		winnerText.text = "";
	}

	public void setBanner()
	{
        /*
		string vm = VictoryMessages.instance.RetrieveMessage();
		if (vm != "")
		{
			setText(vm);
		}
		else
		{
			clearText();
			if ((bool)AppData.instance[AppData.Storage.GameFinished])
			{
				wcf.FadeOut(FinalSceneLevel);
			}
			else
			{
				wcf.FadeOut(WorldSelectLevel);
			}
		}
        */
	}
}
