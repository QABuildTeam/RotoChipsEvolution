using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoBackgroundFlasher : MonoBehaviour {
	SpriteRenderer sr;
	public float LowAlpha;	// minimum sprite transparency value
	public float HighAlpha;	// maximum sprite transparency value
	public int UpSteps;		// number of steps to increase alpha
	public int DownSteps;   // number of steps to decrease alpha
							// Use this for initialization
	void setAlpha(float alpha)
	{
		Color c = sr.color;
		c.a = alpha;
		sr.color = c;
	}
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer>();
		setAlpha(LowAlpha);
	}

	IEnumerator flashSprite()
	{
		float upDelta = (HighAlpha - LowAlpha) / UpSteps;
		float downDelta = (LowAlpha - HighAlpha) / DownSteps;
		while (true)
		{
			float alpha = LowAlpha;
			setAlpha(alpha);
			yield return new WaitForFixedUpdate();
			for (int i = 0; i < UpSteps; i++)
			{
				alpha += upDelta;
				setAlpha(alpha);
				yield return new WaitForFixedUpdate();
			}
			alpha = HighAlpha;
			setAlpha(alpha);
			yield return new WaitForFixedUpdate();
			for (int i = 0; i < DownSteps; i++)
			{
				alpha += downDelta;
				setAlpha(alpha);
				yield return new WaitForFixedUpdate();
			}
		}
	}

	public void startFlash()
	{
		StartCoroutine(flashSprite());
	}
}
