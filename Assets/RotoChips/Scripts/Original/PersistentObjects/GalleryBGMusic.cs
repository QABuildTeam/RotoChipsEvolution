using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryBGMusic : MonoBehaviour
{

	public static GalleryBGMusic instance;
	public AudioSource musipClip;
	public MusicFader mf;
	float originalVolume;

	bool isPlaying;

	// Use this for initialization
	void Awake()
	{
		if (instance == null)
		{
			instance = this;
			isPlaying = false;
			originalVolume = musipClip.volume;
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}
	}

	public void play() {
		if (!isPlaying)
		{
			//Debug.Log("GalleryBGMusic: start playing");
			musipClip.volume = originalVolume;
			musipClip.Play();
			isPlaying = true;
		}
		else
		{
			//Debug.Log("GalleryBGMusic: already playing");
		}

	}

	public void stop() {
		//Debug.Log("GalleryBGMusic: stop playing");
		isPlaying = false;
		mf.FadeOut();
	}
}
