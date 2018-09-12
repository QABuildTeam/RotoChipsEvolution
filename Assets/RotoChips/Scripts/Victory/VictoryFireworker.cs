/*
 * File:        VictoryFireworker.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class VictoryFireworker emits fireworks on the Victory scene
 * Created:     12.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Utility;

namespace RotoChips.Victory
{
    public class VictoryFireworker : MonoBehaviour
    {
        [SerializeField]
        protected GameObject[] fireworkPrefabs;
        [SerializeField]
        protected FloatRange waitTime;

        int NextFireworkIndex()
        {
            return Random.Range(0, fireworkPrefabs.Length);
        }

        // Use this for initialization
        void Start()
        {
            InitFirework(NextFireworkIndex());
        }

        [SerializeField]
        protected float colorPartExpansion = 3f;
        [SerializeField]
        protected float colorPartReduction = 0.35f;
        float RandomColorPart()
        {
            return Mathf.Clamp((Mathf.Floor(Random.value * colorPartExpansion) + 1) * colorPartReduction, 0, 1);
        }

        Color GetFireworkColor()
        {
            return new Color(RandomColorPart(), RandomColorPart(), RandomColorPart(), 1f);
        }

        Vector3 GetFireworkStartCoord()
        {
            return new Vector3(Random.value - 0.5f, Random.value - 0.5f, Random.value - 0.5f);
        }

        [SerializeField]
        protected float maxAngleDelta = 12f;
        Quaternion GetFireworkStartRotation(Vector3 v)
        {
            return Quaternion.Euler(
                v.x + (Random.value - 0.5f) * maxAngleDelta,
                v.y + (Random.value - 0.5f) * maxAngleDelta,
                v.z + (Random.value - 0.5f) * maxAngleDelta
            );
        }

        float GetInitialPitch()
        {
            return Random.value - 0.5f;
        }

        IEnumerator WaitWhileFireworkPlays(ParticleSystem firework)
        {
            // wait while the firework plays
            while (firework.isPlaying)
            {
                yield return null;
            }
            Destroy(firework.gameObject);
        }

        IEnumerator WaitForNextFirework()
        {
            yield return new WaitForSeconds(waitTime.Random);
            InitFirework(NextFireworkIndex());
        }

        void InitFirework(int emitter)
        {
            GameObject firework = (GameObject)Instantiate(fireworkPrefabs[emitter]);
            firework.transform.position += GetFireworkStartCoord();
            firework.transform.rotation = GetFireworkStartRotation(firework.transform.rotation.eulerAngles);
            AudioSource audioSource = firework.GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = firework.GetComponentInChildren<AudioSource>();
            }
            if (audioSource != null)
            {
                audioSource.pitch += GetInitialPitch();
            }
            ParticleSystem particleSystem = firework.GetComponent<ParticleSystem>();
            ParticleSystem.MainModule main = particleSystem.main;
            main.startColor = GetFireworkColor();
            particleSystem.Play();
            /*
            if (audioSource != null)
            {
                audioSource.Play();
            }
            */
            StartCoroutine(WaitWhileFireworkPlays(particleSystem));
            StartCoroutine(WaitForNextFirework());
        }
    }
}
