using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLightScript : MonoBehaviour {

    public Color[] LightColorSettings;
    public float[] LightIntensitySettings;
    public int stepsCount;

    int currentLight;
    int nextLight;
    int totalColors;
    int currentStep;
    // Use this for initialization
    void Start()
    {
        totalColors = LightColorSettings.GetUpperBound(0) + 1;
        currentLight = 0;
        nextLight = currentLight + 1;
        if (nextLight >= totalColors)
        {
            nextLight = 0;
        }
        currentStep = 0;
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

    private void FixedUpdate()
    {
        float t = (float)currentStep / (float)stepsCount;
        Color c = Color.Lerp(LightColorSettings[currentLight], LightColorSettings[nextLight], t);
        float intensity = Mathf.Lerp(LightIntensitySettings[currentLight], LightIntensitySettings[nextLight], t);
        //float intensity = 1.0f;
        setLight(c, intensity);
        currentStep++;
        if (currentStep > stepsCount)
        {
            currentStep = 0;
            currentLight++;
            if (currentLight >= totalColors)
            {
                currentLight = 0;
            }
            nextLight = currentLight + 1;
            if (nextLight >= totalColors)
            {
                nextLight = 0;
            }
        }
    }
}
