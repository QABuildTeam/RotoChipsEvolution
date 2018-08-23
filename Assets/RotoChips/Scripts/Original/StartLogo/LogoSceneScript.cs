using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoSceneScript : MonoBehaviour {

	public GameObject LogoStart;
	public GameObject Pad;
    public GameObject CubeLL;
    public GameObject CubeLR;
    public GameObject CubeUL;
    public GameObject CubeUR;
    public GameObject Coin;
    //public Light LogoLight;
    public GameObject LogoText;
	public ParticleSystem LogoFire;
    public GameObject StartButton;
    public GameObject StartText;
	//public GameObject LogoGraphics;
    public GameObject TransitionImage;
	public GameObject BGSprite1;
	public GameObject BGSprite2;
	public GameObject BGSprite3;

    public float deltay;
    public float PadWaitSeconds = 1f;
    public float PadY0 = -0.5f;
    public float CubeLLWaitSeconds = 1f;
    public float CubeY0 = 0f;
    public float CubeLRWaitSeconds = 1f;
    public float CubeULWaitSeconds = 1f;
    public float CubeURWaitSeconds = 1f;
    public float CoinWaitSeconds = 1f;
    public float CoinY0 = 0.2f;
    public float LogoWaitSeconds = 1f;
    public Vector3 deltaCamera;
    public float deltaCameraSeconds;
    public int deltaCameraSteps;

	// Use this for initialization
	void Start () {
        //Physics.gravity = new Vector3(0, -1f, 0);
        LogoText.SetActive(false);
        StartButton.SetActive(false);
        //StartText.SetActive(false);
        StartCoroutine(logoAnimation());
	}

    IEnumerator fallDown(GameObject o, float y0)
    {
		LogoStart.GetComponent<AudioSource> ().Play ();
        Vector3 v = o.transform.position;
        while (v.y > y0)
        {
            yield return new WaitForFixedUpdate();
            v.y -= deltay;
            o.transform.position = v;
        }
        v.y = y0;
        o.transform.position = v;
        yield return new WaitForFixedUpdate();
		o.GetComponent<AudioSource> ().Play ();
    }
	
    IEnumerator logoAnimation()
    {
        yield return new WaitForFixedUpdate();
        // assemble logo parts
        yield return new WaitForSeconds(PadWaitSeconds);
        StartCoroutine(fallDown(Pad, PadY0));
        yield return new WaitForSeconds(CubeLLWaitSeconds);
        StartCoroutine(fallDown(CubeLL, CubeY0));
        yield return new WaitForSeconds(CubeLRWaitSeconds);
        StartCoroutine(fallDown(CubeLR, CubeY0));
        yield return new WaitForSeconds(CubeULWaitSeconds);
        StartCoroutine(fallDown(CubeUL, CubeY0));
        yield return new WaitForSeconds(CubeURWaitSeconds);
        StartCoroutine(fallDown(CubeUR, CubeY0));
        yield return new WaitForSeconds(CoinWaitSeconds);
        StartCoroutine(fallDown(Coin, CoinY0));
        // move camera far from logo
        // the logo itself is moved left and a little up
        yield return new WaitForSeconds(LogoWaitSeconds);
        for (int i = 0; i < deltaCameraSteps; i++)
        {
            Camera.main.transform.position += deltaCamera;
            yield return new WaitForSeconds(deltaCameraSeconds);
        }
		LogoFire.Play ();
		//LogoGraphics.SetActive(true);
        // activate next letters
        LogoText.SetActive(true);
		gameObject.GetComponent<AudioSource> ().Play ();
		// start flashing background
		BGSprite1.GetComponent<LogoBackgroundFlasher>().startFlash();
		BGSprite2.GetComponent<LogoBackgroundFlasher>().startFlash();
		BGSprite3.GetComponent<LogoBackgroundFlasher>().startFlash();
        yield return new WaitForSeconds(LogoWaitSeconds);
        // activate a "Tap to start" button
        // it will also wait for the very first STRESS image to be ready
        //StartButton.SetActive(true);
        StartText.GetComponent<StartTextScript>().runActiveText();
    }
}
