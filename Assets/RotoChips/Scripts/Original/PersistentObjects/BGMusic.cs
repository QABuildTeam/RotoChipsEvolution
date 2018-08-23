using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour {

	public static BGMusic instance;
    public string[] bgMusicList;
    public string respath = "Music/";
	// Use this for initialization

	void Awake() {
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}
	}

    public int bgmCount()
    {
        return bgMusicList.Length;
    }

    public string bgmName(int index)
    {
        if (bgmCount() <= 0)
        {
            return "";
        }
        if (index >= 0 && index < bgmCount())
        {
            return bgMusicList[index];
        }
        return "";
    }

    public AudioClip bgmClip(int index)
    {
		string bgmname = bgmName(index);
        if (bgmname != "")
        {
            return Resources.Load<AudioClip>(respath + bgmname);
        }
        return null;
    }
}
