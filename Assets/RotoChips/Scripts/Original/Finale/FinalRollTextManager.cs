using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalRollTextManager : MonoBehaviour {

	public FinalRollTextScript[] textObjects;
	public GameObject StopButton;
	int rolledIndex;	// this index increments after a text has stopped rolling
	int delayedIndex;	// this index increments after a text postdelay expired

	// Use this for initialization
	void Start () {
		rolledIndex = 0;
		delayedIndex = 0;
		StartCoroutine (startTextRolling ());
	}

	IEnumerator startTextRolling() {
		yield return new WaitForFixedUpdate ();
		TextRolled ();
	}

	public void TextRolled() {
		if (rolledIndex > textObjects.GetUpperBound(0))
		{
			if (StopButton != null)
			{
				//Debug.Log("activating StopButton");
				StopButton.SetActive(true);
			}
		}
		else
		{
			StartCoroutine(textObjects[rolledIndex].rollText());
			rolledIndex++;
			//Debug.Log("delayedIndex=" + delayedIndex.ToString());
		}
	}

	public void TextRollDelayed()
	{
		if (delayedIndex == textObjects.GetUpperBound(0))
		{
			//Debug.Log("resetting roll texts");
			for (int i = 0; i <= textObjects.GetUpperBound(0); i++)
			{
				textObjects[i].resetPosition();
			}
			rolledIndex = 0;
			delayedIndex = 0;
			StartCoroutine(startTextRolling());
		}
		else
		{
			delayedIndex++;
			//Debug.Log("delayedIndex=" + rolledIndex.ToString());
		}
	}
		
}
