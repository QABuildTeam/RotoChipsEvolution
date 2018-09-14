using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;

public class FinalRollTextScript : MonoBehaviour {

	// as soon as parent's position and dimensions may vary from screen to screen,
	// a relative aligned text positioning is used instead of absolute
	public enum parentMove {
		BottomToTop,	
		TopToBottom,
		LeftToRight,
		RightToLeft,
		InPlace
	};

	public long stepsCounter;			// number of FixedUpdates to roll
	//public float stepTime;
	public float preDelaySeconds;		// delay in seconds before rolling starts
	public float postDelaySeconds;      // delay in seconds after rolling stops (message is sent before this delay!)
	public Vector2 startOffset;		// relative start position using parent alignment
	public parentMove startMove;        // a type of start parent alignment
	public Vector2 endOffset;			// relative end position using parent alignment
	public parentMove endMove;		// a type of end parent alignment
	public string localizationTextKey;	// a key to localization database
	public GameObject listener;         // a gameObject to recieve a stop message

	Vector2 originalPosition;			// this one is used as a base for further reltional calculations

	Vector2 calculateLocalPosition(Vector2 relativePosition, parentMove pmove) {
		Rect r = gameObject.transform.parent.GetComponent<RectTransform>().rect;
		Vector2 p = originalPosition;
		switch (pmove)
		{
			case parentMove.BottomToTop:
				p.y += r.height;
				break;
			case parentMove.TopToBottom:
				p.y -= r.height;
				break;
			case parentMove.LeftToRight:
				p.x += r.width;
				break;
			case parentMove.RightToLeft:
				p.x -= r.width;
				break;
		}
		return p + relativePosition;
	}

	// Use this for initialization
	void Start () {
        //string FinalText = LocalizationManager.instance.GetLocalizedValue(localizationTextKey);
        string FinalText=GlobalManager.MLanguage.Entry(localizationTextKey);
        // "\n" sequences may be used in the FinalText; they are replaced with the real newlines
        //gameObject.GetComponent<Text>().text = FinalText.Replace("\\n", "\n");
        gameObject.GetComponent<Text>().text = FinalText;
		originalPosition = transform.localPosition;
		//Debug.Log ("Current text is: " + gameObject.GetComponent<Text>().text);
		//Debug.Log("Original position: " + originalPosition.ToString());
		resetPosition();
		//Debug.Log ("Parent dimensions: " + gameObject.transform.parent.GetComponent<RectTransform> ().rect.width + "x" + gameObject.transform.parent.GetComponent<RectTransform> ().rect.height);
    }

	public void resetPosition()
	{
		gameObject.transform.localPosition = calculateLocalPosition(startOffset, startMove);
	}

	public IEnumerator rollText() {
		yield return new WaitForSeconds (preDelaySeconds);
		Vector2 localStartPos = calculateLocalPosition(startOffset, startMove);
		Vector2 localEndPos = calculateLocalPosition(endOffset, endMove);
		gameObject.transform.localPosition = localStartPos;
		Vector3 delta = (Vector3)((localEndPos - localStartPos) / stepsCounter);
		//Debug.Log ("Current text is: " + gameObject.GetComponent<Text>().text);
		//Debug.Log("Start pos: " + localStartPos.ToString() + ", end pos: " + localEndPos.ToString() + ", delta: " + delta.ToString());
		for (int i = 0; i < stepsCounter; i++) {
			gameObject.transform.localPosition += delta;
			//Debug.Log ("Pos:" + gameObject.transform.localPosition.ToString ());
			yield return new WaitForFixedUpdate ();
		}
		gameObject.transform.localPosition = localEndPos;
		if (listener != null) {
			listener.SendMessage ("TextRolled");
		}
		yield return new WaitForSeconds (postDelaySeconds);
		if (listener != null)
		{
			listener.SendMessage("TextRollDelayed");
		}
	}
}
