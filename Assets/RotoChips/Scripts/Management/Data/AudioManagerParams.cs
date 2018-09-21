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
        public AudioTrackEnum id;
        public AudioClip clip;
        public float volume;
        // a track may be partitioned into several subclips which in turn may be played in a specific order
        public FloatRange[] subclips;   // every subclip has its beginning (subclips[i].min) and its end (subclips[i].max) in seconds
        public int[] subclipOrder;      // this is an array of indexes into the subclips array
    }

    [System.Serializable]
    public class SFXControl
    {
        public SFXEnum id;
        public AudioClip clip;
        public bool loop;
        public float pitch;
        public float volume;
    }

    public class AudioManagerParams : MonoBehaviour
    {

        [SerializeField]
        protected int maxAudioPlayers = 2;
        public int MaxAudioPlayers
        {
            get
            {
                return maxAudioPlayers;
            }
        }

        [SerializeField]
        protected int maxSFXPlayers = 5;
        public int MaxSFXPlayers
        {
            get
            {
                return maxSFXPlayers;
            }
        }

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
        protected float musicCrossFadeTime = 0.5f;
        public float MusicCrossFadeTime
        {
            get
            {
                return musicCrossFadeTime;
            }
        }
        [SerializeField]
        protected int musicCrossFadeSteps = 32;
        public int MusicCrossFadeSteps
        {
            get
            {
                return musicCrossFadeSteps;
            }
        }

        [SerializeField]
        protected List<AudioTrackControl> tracks;   // a list of tracks to be played
        public List<AudioTrackControl> Tracks
        {
            get
            {
                return tracks;
            }
        }

        [SerializeField]
        protected List<SFXControl> sfx;             // a list of SFX to be played
        public List<SFXControl> SFX
        {
            get
            {
                return sfx;
            }
        }

    }
}