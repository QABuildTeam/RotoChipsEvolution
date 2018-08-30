using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TileFlasher : MonoBehaviour {

    public Color GoodFlashColor;
    public Color BadFlashColor;
    public float flashPeriod;
    public int flashCount;

    int flashPhase;
    Color currentColor;
    Color colorDelta;
    Color whiteColor;
    int currentFlash;
    int maxFlashStep;
    int flashStep;
    SpriteRenderer spriteColor;

    GameObject flashListener;

	// Use this for initialization
	void Start () {
        flashPhase = 0;
        currentFlash = -1;
        whiteColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        currentColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        colorDelta = new Color(0f, 0f, 0f, 0f);
        maxFlashStep = 0;
        flashStep = 0;
        spriteColor = gameObject.GetComponent<SpriteRenderer>();
	}

    public void setFlashListener(GameObject aListener)
    {
        flashListener = aListener;
    }

    void initFlashing(int newFlashPhase)
    {
        currentFlash = 0;
        currentColor.r = 1.0f;
        currentColor.g = 1.0f;
        currentColor.b = 1.0f;
        currentColor.a = 1.0f;
        colorDelta.r = 0f;
        colorDelta.g = 0f;
        colorDelta.b = 0f;
        colorDelta.a = 0f;
        float deltaTime = Time.deltaTime;
        maxFlashStep = (int)(flashPeriod / deltaTime)+1;
        flashStep = 0;
        switch (newFlashPhase)
        {
            case 1:     // flash from white to good color
            case 2:     // flash from good to white color
                colorDelta.r = (1.0f - GoodFlashColor.r) / flashPeriod * deltaTime; //all color delta component values are positive
                colorDelta.g = (1.0f - GoodFlashColor.g) / flashPeriod * deltaTime;
                colorDelta.b = (1.0f - GoodFlashColor.b) / flashPeriod * deltaTime;
                colorDelta.a = (1.0f - GoodFlashColor.a) / flashPeriod * deltaTime;
                break;
            case 3:     // flash from white to bad color
            case 4:     // flash from bad to white color
                colorDelta.r = (1.0f - BadFlashColor.r) / flashPeriod * deltaTime;
                colorDelta.g = (1.0f - BadFlashColor.g) / flashPeriod * deltaTime;
                colorDelta.b = (1.0f - BadFlashColor.b) / flashPeriod * deltaTime;
                colorDelta.a = (1.0f - BadFlashColor.a) / flashPeriod * deltaTime;
                break;
        }
        //Debug.Log("deltaTime: " + deltaTime.ToString() + "; maxFlashStep: " + maxFlashStep.ToString() + ", colorDelta: " + colorDelta.ToString());
        flashPhase = newFlashPhase;
    }

    public void FlashGood()
// this method makes the tile flashing with "good" color
    {
        //Debug.Log("Flashing good.");
        initFlashing(1);
    }

    public void FlashBad()
// this method makes the tile flashing with "bad" color
    {
        //Debug.Log("Flashing bad.");
        initFlashing(3);
    }

    public void StopFlashing()
// this method prevents the tile from flashing, returning its color to the original white
    {
        //Debug.Log("Stop flashing.");
        initFlashing(0);
        spriteColor.color = whiteColor;
    }

    void FixedUpdate()
    {
        if (flashPhase == 0)
            return;
        switch (flashPhase)
        {
            case 1:
            case 3:
                currentColor = currentColor - colorDelta;
                break;
            case 2:
            case 4:
                currentColor = currentColor + colorDelta;
                break;
        }
        ++flashStep;
        if (flashStep >= maxFlashStep)
        {
            flashStep = 0;
            ++currentFlash;
            if (currentFlash >= flashCount * 2)
            {
                currentColor = whiteColor;
                flashPhase = 0;
                flashListener.SendMessage("flashStopped");
            }
            else
            {
                switch (flashPhase)
                {
                    case 1:
                        currentColor = GoodFlashColor;
                        flashPhase = 2;
                        break;
                    case 3:
                        currentColor = BadFlashColor;
                        flashPhase = 4;
                        break;
                    case 2:
                        currentColor = whiteColor;
                        flashPhase = 1;
                        break;
                    case 4:
                        currentColor = whiteColor;
                        flashPhase = 3;
                        break;
                }
            }
        }
        spriteColor.color = currentColor;
    }
}
