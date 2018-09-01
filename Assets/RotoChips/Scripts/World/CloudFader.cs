/*
 * File:        CloudFader.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class CloudFader implements fading the clouds around the single main level selector out
 * Created:     30.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.World
{
    public class CloudFader : MonoBehaviour
    {

        ParticleSystem clouds;
        public float fadeDelta;     // wait a little bit more

        public void FadeOut()
        {
            clouds = GetComponent<ParticleSystem>();
            StartCoroutine(FadeCloudsOut());
        }

        IEnumerator FadeCloudsOut()
        {
            ParticleSystem.EmissionModule em = clouds.emission;
            em.enabled = false;
            while (clouds.particleCount > 0)
            {
                yield return null;
            }
            yield return new WaitForSeconds(fadeDelta);
            Destroy(gameObject);
        }

    }
}
