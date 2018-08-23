using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudFader : MonoBehaviour {

    ParticleSystem cloud;
    public float fadeDelta;     // wait a little bit more
	// Use this for initialization
	void Start () {
        cloud = gameObject.GetComponent<ParticleSystem>();
	}

	public void fadeClouds()
    {
        StartCoroutine(fadeCloudsDown());
    }

    IEnumerator fadeCloudsDown()
    {
        float cloudDuration = cloud.main.duration + cloud.main.startLifetime.constant;
        ParticleSystem.EmissionModule em = cloud.emission;
        em.enabled = false;
        yield return new WaitForSeconds(cloudDuration);
        while (cloud.particleCount > 0)
        {
            yield return new WaitForFixedUpdate();
        }
        yield return new WaitForSeconds(fadeDelta);
        Destroy(cloud.gameObject);
    }

}
