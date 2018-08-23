using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WhiteCurtainFader : MonoBehaviour {

    public Image fader;
    public float fadeDuration;
    public int fadeCount;
    public string LevelToGo;
    public Color fadeColor;

    public GameObject MsgReceiver;


	// Use this for initialization
	void Start () {
        MsgReceiver = null;
        LevelToGo = "";
        //fadeColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        fader.color = fadeColor;
        FadeIn();
    }

    public void SetColor(Color c)
    {
        fadeColor = c;
        fader.color = c;
    }

    // auxillary method
    // it sets the alpha channel of the fader color
    // to prevent a momentary flash on screen
    void setAlpha(float alpha)
    {
        Color c = fader.color;
        c.a = alpha;
        fader.color = c;
    }

    // this method fades an image from opaque initial color into full transparency
    // does not notify receiver
    public void FadeIn()
    {
        LevelToGo = "";
        MsgReceiver = null;
        // this prevents a momentary flash on screen
        setAlpha(1f);
        // now turn the object on
        gameObject.SetActive(true);
        StartCoroutine(WhiteCurtainLoop(1f, 0f, -1f / fadeCount, false));
    }

    // this method fades an image from opaque initial color into full transparency
    // does not notify receiver
    public void FadeIn(GameObject receiver)
    {
        LevelToGo = "";
        MsgReceiver = receiver;
        // this prevents a momentary flash on screen
        setAlpha(1f);
        // now turn the object on
        gameObject.SetActive(true);
        StartCoroutine(WhiteCurtainLoop(1f, 0f, -1f / fadeCount, false));
    }

    // this method sets full transparency out to an opaque finishing color
    // and starts another scene if applicable
    public void FadeOut(string aLevel)
    {
        LevelToGo = aLevel;
        MsgReceiver = null;
        // this prevents a momentary flash on screen
        setAlpha(0f);
        // now turn the object on
        gameObject.SetActive(true);
		//Debug.Log("wcf activated");
        StartCoroutine(WhiteCurtainLoop(0f, 1f, 1f / fadeCount, true));
        //Debug.Log("Fading out to scene " + LevelToGo);
    }

    // this method sets full transparency out to an opaque finishing color
    // and notifies the receiver if applicable
    public void FadeOut(GameObject receiver)
    {
        LevelToGo = "";
        MsgReceiver = receiver;
        // this prevents a momentary flash on screen
        setAlpha(0f);
        // now turn the object on
        gameObject.SetActive(true);
        StartCoroutine(WhiteCurtainLoop(0f, 1f, 1f / fadeCount, true));
    }

    void GotoLevel()
    {
		if (LevelToGo != "")
		{
			//Debug.Log("loading level " + LevelToGo);
			SceneManager.LoadScene(LevelToGo);
		}
    }

    void NotifyReceiver(bool fadedOut)
    {
        if (MsgReceiver != null)
        {
			//Debug.Log ("yes, notifying receiver");
            MsgReceiver.SendMessage(fadedOut ? "FadedOut" : "FadedIn");
        }
    }

    // main fading loop
    IEnumerator WhiteCurtainLoop(float startVal, float endVal, float deltaVal, bool fadedOut)
    {
        Color imageFadeColor = fadeColor;
        imageFadeColor.a = startVal;
        gameObject.SetActive(true);
        float fadeTime = fadeDuration / fadeCount;
        yield return new WaitForFixedUpdate();
        for (int i = 0; i < fadeCount; i++)
        {
            imageFadeColor.a += deltaVal;
            fader.color = imageFadeColor;
            //yield return new WaitForFixedUpdate();
            yield return new WaitForSeconds(fadeTime);
        }
        imageFadeColor.a = endVal;
        fader.color = imageFadeColor;
        if (!fadedOut)
        {
			//Debug.Log ("set curtain inactive");
            gameObject.SetActive(false);
        }
		//Debug.Log ("notify receiver if any");
        NotifyReceiver(fadedOut);
        GotoLevel();
    }

}
