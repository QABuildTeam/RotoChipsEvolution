using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalFireworksScript : MonoBehaviour {
    public GameObject[] fireworkPrefabs;
    List<GameObject> levelSelectors;
    //public GameObject WinnerFader;
    public float fireworksScale;
    public float waitTimeMin;
    public float waitTimeMax;

    int nextFireworkIndex()
    {
        return (int)(UnityEngine.Random.value * (fireworkPrefabs.GetUpperBound(0) + 1));
    }

    // Use this for initialization
	//void Start () {
    //    initFirework(nextFireworkIndex());
	//}

    Color getFwColor()
    {
        int m = (int)(UnityEngine.Random.value * 3f);
        float r = (m + 1) * 0.35f;
        if (r > 1f)
            r = 1f;
        m = (int)(UnityEngine.Random.value * 3f);
        float g = (m + 1) * 0.35f;
        if (g > 1f)
            g = 1f;
        m = (int)(UnityEngine.Random.value * 3f);
        float b = (m + 1) * 0.35f;
        if (b > 1f)
            b = 1f;
        return new Color(r, g, b, 1f);
    }

    Vector3 getFwStartCoord()
    {
        float x = (float)(UnityEngine.Random.value);
        float y = (float)(UnityEngine.Random.value);
        float z = (float)(UnityEngine.Random.value);
        return new Vector3(x - 0.5f, y - 0.5f, z - 0.5f);
    }

    Quaternion getFwStartRotation(Vector3 v)
    {
        float x = (float)(UnityEngine.Random.value) * 12f;
        float y = (float)(UnityEngine.Random.value) * 12f;
        float z = (float)(UnityEngine.Random.value) * 12f;
        return Quaternion.Euler(v.x + x - 6f, v.y + y - 6f, v.z + z - 6f);
    }

    float getInitPitch()
    {
        float deltaPitch = (float)(UnityEngine.Random.value) - 0.5f;
        return deltaPitch;
    }

    IEnumerator WaitForFinished(ParticleSystem firework)
    {
        // wait while it plays
        while (firework.isPlaying)
        {
            yield return new WaitForFixedUpdate();
        }
        GameObject.Destroy(firework.gameObject);
    }

    GameObject getNextSelector()
    {
        int selIndex = (int)(UnityEngine.Random.value * (levelSelectors.Count));
        GameObject o = levelSelectors[selIndex];
        return o;
    }

    IEnumerator WaitForNextFirework()
    {
        float waitTime = waitTimeMin + (float)(UnityEngine.Random.value) * (waitTimeMax - waitTimeMin);
        yield return new WaitForSeconds(waitTime);
        initFirework(nextFireworkIndex());
    }

    void initFirework(int emitter)
    {
        GameObject firework = (GameObject)Instantiate(fireworkPrefabs[emitter]);
        firework.transform.localScale = new Vector3(fireworksScale, fireworksScale, fireworksScale);
        firework.transform.SetParent(getNextSelector().transform);
        firework.transform.localPosition = Vector3.zero;
        //firework.transform.position += getFwStartCoord();
        firework.transform.rotation = getFwStartRotation(firework.transform.rotation.eulerAngles);
        firework.GetComponentInChildren<AudioSource>().pitch += getInitPitch();
        ParticleSystem fwps = firework.GetComponent<ParticleSystem>();
        ParticleSystem.MainModule main = fwps.main;
        main.startColor = getFwColor();
        main.gravityModifier = 0;
        fwps.Play();
        //fwps.GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFinished(fwps));
        StartCoroutine(WaitForNextFirework());
    }

    public void startFireworks(List<GameObject> aLevelSelectors)
    //public void startFireworks(GameObject[] aLevelSelectors)
    {
        levelSelectors = aLevelSelectors;
        initFirework(nextFireworkIndex());
    }

}
