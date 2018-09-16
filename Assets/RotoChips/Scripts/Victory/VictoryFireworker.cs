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
using RotoChips.Management;

namespace RotoChips.Victory
{
    public class VictoryFireworker : MonoBehaviour
    {
        [SerializeField]
        protected GameObject[] fireworkPrefabs;
        [SerializeField]
        protected FloatRange waitTime;
        [SerializeField]
        protected float localScale;
        [SerializeField]
        protected int maxSimultaneousFireworks;
        int currentFireworksCount;

        List<GameObject> selectors;     // selector objects on the Finale scene; only work on this scene

        MessageRegistrator registrator;
        private void Awake()
        {
            currentFireworksCount = 0;
            registrator = new MessageRegistrator(InstantMessageType.VictoryStartFireworks, (InstantMessageHandler)OnVictoryStartFireworks);
            registrator.RegisterHandlers();
        }

        int NextFireworkIndex()
        {
            return Random.Range(0, fireworkPrefabs.Length);
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
            currentFireworksCount--;
        }

        IEnumerator WaitForNextFirework()
        {
            yield return new WaitForSeconds(waitTime.Random);
            InitFirework(NextFireworkIndex());
        }

        void InitFirework(int emitter)
        {
            if (maxSimultaneousFireworks > 0 && currentFireworksCount < maxSimultaneousFireworks)
            {
                currentFireworksCount++;
                GameObject firework = (GameObject)Instantiate(fireworkPrefabs[emitter]);
                ParticleSystem particleSystem = firework.GetComponent<ParticleSystem>();
                ParticleSystem.MainModule main = particleSystem.main;
                firework.transform.localScale = new Vector3(localScale, localScale, localScale);
                if (selectors != null)
                {
                    // special repositioning for the Finale scene
                    firework.transform.SetParent(selectors[Random.Range(0, selectors.Count)].transform);
                    firework.transform.localPosition = Vector3.zero;
                    main.gravityModifier = 0;
                }
                else
                {
                    // normal repositioning for the Victory scene
                    firework.transform.position += GetFireworkStartCoord();
                }
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
                main.startColor = GetFireworkColor();
                particleSystem.Play();
                StartCoroutine(WaitWhileFireworkPlays(particleSystem));
                StartCoroutine(WaitForNextFirework());
            }
        }

        // message handling
        // special message for the Finale scene
        void OnVictoryStartFireworks(object sender, InstantMessageArgs args)
        {
            selectors = (List<GameObject>)args.arg;
            InitFirework(NextFireworkIndex());
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
