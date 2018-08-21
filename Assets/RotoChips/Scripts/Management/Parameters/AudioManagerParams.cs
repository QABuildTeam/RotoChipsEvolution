/*
 * File:        AudioManagerParams.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class AudioManagerParams contains initial parameters for the AudioManager
 * Created:     29.06.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Utility;

namespace RotoChips.Management
{

    [System.Serializable]
    public class AudioTrackControl
    {
        public AudioClip clip;
        public bool loop;
        public FloatRange[] subclips;
        public int[] subclipOrder;
    }

    public class AudioManagerParams : MonoBehaviour
    {

        [SerializeField]
        [Range(0, 1)]
        float maxMusicVolume = 1f;
        public float MaxMusicVolume
        {
            get
            {
                return maxMusicVolume;
            }
            set
            {
                maxMusicVolume = value;
            }
        }
        [SerializeField]
        float musicCrossFadeTime = 0.5f;
        public float MusicCrossFadeTime
        {
            get
            {
                return musicCrossFadeTime;
            }
        }
        [SerializeField]
        int musicCrossFadeSteps = 32;
        public int MusicCrossFadeSteps
        {
            get
            {
                return musicCrossFadeSteps;
            }
        }

        [SerializeField]
        List<AudioTrackControl> tracks;     // a list of tracks to be played
        public List<AudioTrackControl> Tracks
        {
            get
            {
                return tracks;
            }
        }

    }
}