using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldLightSettings : MonoBehaviour
{

    public Color[] LightColorSettings;
    public float[] LightIntensitySettings;

    // Use this for initialization
    void Awake()
    {
        int currentRealm = LevelData.instance.LastOpenRealm();
        int settingsCount = LightColorSettings.GetUpperBound(0) + 1;
        if (currentRealm < 0)
        {
            currentRealm = 0;
        }
        else if (currentRealm >= settingsCount)
        {
            currentRealm = settingsCount - 1;
        }
        // special setting
        //currentRealm = 0;
        // end special settingg
        StartCoroutine(setLightOnStart(LightColorSettings[currentRealm], LightIntensitySettings[currentRealm]));
        //setLight(LightColorSettings[currentRealm], LightIntensitySettings[currentRealm]);
        //Debug.Log ("WorldLight: si=" + LightIntensitySettings [currentRealm].ToString () + ", di=" + gameObject.GetComponent<Light> ().intensity.ToString ());
    }

    IEnumerator setLightOnStart(Color c, float i)
    {
        yield return new WaitForFixedUpdate();
        setLight(c, i);
    }

    public void setLight(Color color, float intensity)
    {
        gameObject.GetComponent<Light>().color = color;
        gameObject.GetComponent<Light>().intensity = intensity;
        gameObject.GetComponent<Light>().renderMode = LightRenderMode.ForcePixel;
    }

    public void getLight(out Color color, out float intensity)
    {
        color = gameObject.GetComponent<Light>().color;
        intensity = gameObject.GetComponent<Light>().intensity;
    }
}
