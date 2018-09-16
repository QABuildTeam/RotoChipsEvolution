/*
 * File:        SFXController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class SFXController controls playing audio clips attached to objects
 * Created:     16.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.Audio
{
    public class SFXController : MonoBehaviour
    {

        [SerializeField]
        protected AudioClip[] clips;
        protected AudioSource audioSource;

        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public void Play(int clipId, float pitch = 1, float volume = 1)
        {
            if (audioSource != null && clipId >= 0 && clipId < clips.Length)
            {
                audioSource.Stop();
                audioSource.clip = clips[clipId];
                audioSource.pitch *= pitch;
                audioSource.volume *= volume;
                audioSource.Play();
            }
        }
    }
}
