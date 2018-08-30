/*
 * File:        AudioManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class AudioManager defines a manager class for sound tracks of the game
 * Created:     18.06.2018
 */
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using RotoChips.Generic;

namespace RotoChips.Management
{

    public class AudioManager : GenericManager
    {
        public AudioManagerParams Parameters
        {
            get; private set;
        }

        public class AudioPlayer
        {
            public AudioSource actualPlayer;        // a reference to an actual AudioSource
            public Coroutine playerCouroutine;      // SubclipPlayer coroutine
            public bool fading;                     // "FadeTrack coroutine is in progress" flag
            public int track;                       // current AudioTrackControl id (-1 if no tracks)
            public int subclip;                     // current subclip id (-1 if no subclips)
            public int order;                       // current subclip order
            public float startTime;                 // start time of the currently played subclip (used for pausing the play)
            public float endTime;                   // end time of the currently played subclip (used for pausing the play)
        }

        AudioPlayer[] musicPlayers;
        int currentTrack;
        int currentMusicPlayer;

        // maximum volume is initially set in Parameters but can be controlld from AudioManager
        public float MaxMusicVolume
        {
            get
            {
                return Parameters == null ? 0 : Parameters.MaxMusicVolume;
            }
            set
            {
                if (Parameters != null)
                {
                    Parameters.MaxMusicVolume = Mathf.Clamp(value, 0, 1);
                    if (musicPlayers.Length > 0 && currentMusicPlayer >= 0)
                    {
                        for (int i = 0; i < musicPlayers.Length; i++)
                        {
                            if (!musicPlayers[i].fading && musicPlayers[i].actualPlayer.isPlaying)
                            {
                                musicPlayers[i].actualPlayer.volume = Parameters.MaxMusicVolume;
                            }
                        }
                    }
                }
            }
        }

        public override void MakeInitial()
        {
            // public instance flag; it is false on start
            Initialized = Status.None;
            Parameters = GetComponentInChildren<AudioManagerParams>();
            if (Parameters != null)
            {
                musicPlayers = new AudioPlayer[2]
                {
                        new AudioPlayer
                        {
                            actualPlayer=gameObject.AddComponent<AudioSource>(),
                            track=-1,
                            subclip=-1,
                            order=-1
                        },
                        new AudioPlayer
                        {
                            actualPlayer=gameObject.AddComponent<AudioSource>(),
                            track=-1,
                            subclip=-1,
                            order=-1
                        }
                };
                for (int i = 0; i < musicPlayers.GetUpperBound(0) + 1; i++)
                {
                    musicPlayers[i].actualPlayer.playOnAwake = false;
                    musicPlayers[i].actualPlayer.volume = 0;
                }
                currentTrack = -1;
                currentMusicPlayer = -1;
                base.MakeInitial();
            }
            else
            {
                Debug.LogError("No AudioManagerParams component found in children!");
            }
        }

        // this method plays subclips of the currentTrack with currentPlayer using specified subclip order
        // if no subclips or their order defined it plays the full track from its beginning to the end
        // the underlying AudioSource is already playing
        IEnumerator SubclipPlayer()
        {
            if (Parameters.Tracks.Count > 0)
            {
                int playerId = currentMusicPlayer;
                AudioPlayer currentPlayer = musicPlayers[playerId];
                AudioSource actualPlayer = currentPlayer.actualPlayer;
                AudioTrackControl track = Parameters.Tracks[currentPlayer.track];
                do
                {
                    // prepare subclip play parameters
                    float startTime = currentPlayer.startTime;
                    float waitTime = currentPlayer.endTime - startTime;
                    Debug.Log("Playing subclip " + currentPlayer.subclip.ToString() + " from " + startTime.ToString() + ", waiting for " + waitTime.ToString());
                    // do the actual play
                    actualPlayer.time = startTime;
                    // ensure that actual player is reaLLy playing
                    actualPlayer.Play();
                    yield return new WaitForSeconds(waitTime);

                    // move to the next subclip
                    PromoteToNextSubclip(currentPlayer, track);
                    Debug.Log("Subclip order " + currentPlayer.order.ToString() + ", total order length: " + track.subclipOrder.Length.ToString());
                }
                while (track.loop || currentPlayer.order < track.subclipOrder.Length);
            }
        }

        void ResetPlayer(AudioPlayer currentPlayer, AudioTrackControl track)
        {
            currentPlayer.order = -1;
            currentPlayer.subclip = -1;
            PromoteToNextSubclip(currentPlayer, track);
        }

        void PromoteToNextSubclip(AudioPlayer currentPlayer, AudioTrackControl track)
        {
            if (track.subclips.Length > 0)
            {
                if (track.subclipOrder.Length > 0)
                {
                    currentPlayer.order = (currentPlayer.order + 1) % track.subclipOrder.Length;
                    currentPlayer.subclip = track.subclipOrder[currentPlayer.order];
                }
                else
                {
                    currentPlayer.subclip = 0;
                }
                currentPlayer.startTime = track.subclips[currentPlayer.subclip].min;
                currentPlayer.endTime = track.subclips[currentPlayer.subclip].max;
            }
            else
            {
                currentPlayer.startTime = 0;
                currentPlayer.endTime = track.clip.length;
            }
        }

        // this method fades the volume of a player with playerId in (start == true) or out (start == false)
        // it also starts playing a track with currentTrack id if start == true
        // and stops playing a current track otherwise
        IEnumerator FadeTrack(int playerId, bool up = true)
        {
            AudioPlayer currentPlayer = musicPlayers[playerId];
            currentPlayer.fading = true;
            currentPlayer.track = currentTrack;
            AudioSource actualPlayer = currentPlayer.actualPlayer;
            AudioTrackControl track = Parameters.Tracks[currentTrack];
            if (up)
            {
                if (currentPlayer.playerCouroutine != null)
                {
                    StopCoroutine(currentPlayer.playerCouroutine);
                }
                if (actualPlayer.isPlaying)
                {
                    actualPlayer.Stop();
                }
            }
            if (up)
            {
                ResetPlayer(currentPlayer, track);
                // set the track and play
                actualPlayer.clip = track.clip;
                actualPlayer.Play();
                currentPlayer.playerCouroutine = StartCoroutine(SubclipPlayer());
            }
            // now fade the volume
            float currentVolume = actualPlayer.volume;
            float endVolume = up ? MaxMusicVolume : 0;
            float volumeDelta = (endVolume - currentVolume) / Parameters.MusicCrossFadeSteps;
            float timeDelta = Parameters.MusicCrossFadeTime / Parameters.MusicCrossFadeSteps;
            WaitForSeconds delayStep = new WaitForSeconds(timeDelta);
            for (int i = 0; i < Parameters.MusicCrossFadeSteps; i++)
            {
                currentVolume += volumeDelta;
                actualPlayer.volume = currentVolume;
                yield return delayStep;
            }
            currentVolume = endVolume;
            actualPlayer.volume = currentVolume;
            if (!up)
            {
                if (currentPlayer.playerCouroutine != null)
                {
                    StopCoroutine(currentPlayer.playerCouroutine);
                }
                currentPlayer.playerCouroutine = null;
                actualPlayer.Stop();
            }
            currentPlayer.fading = false;
        }

        // play a track w/crossfade
        public void PlayTrack(int trackNo)
        {
            if (Parameters.Tracks.Count > 0)
            {
                Debug.Log("Playing track " + trackNo.ToString());
                trackNo = Mathf.Clamp(trackNo, 0, Parameters.Tracks.Count - 1);
                if (trackNo != currentTrack)
                {
                    if (currentMusicPlayer >= 0 && currentTrack >= 0)
                    {
                        StartCoroutine(FadeTrack(currentMusicPlayer, false));
                    }
                    currentMusicPlayer = (currentMusicPlayer + 1) % musicPlayers.Length;
                    currentTrack = trackNo;
                    StartCoroutine(FadeTrack(currentMusicPlayer, true));
                }
            }
        }

        // play a next track from the tracklist
        public void PlayNext()
        {
            if (Parameters.Tracks.Count > 0)
            {
                int newTrack = (currentTrack + 1) % Parameters.Tracks.Count;
                PlayTrack(newTrack);
            }
        }

        public void Pause()
        {
            if (currentTrack >= 0 && currentMusicPlayer >= 0)
            {
                AudioPlayer currentPlayer = musicPlayers[currentMusicPlayer];
                AudioSource actualPlayer = currentPlayer.actualPlayer;
                if (actualPlayer.isPlaying && currentPlayer.playerCouroutine != null)
                {
                    StopCoroutine(currentPlayer.playerCouroutine);
                    currentPlayer.playerCouroutine = null;
                    currentPlayer.startTime = actualPlayer.time;
                    actualPlayer.Stop();
                }
            }
        }

        public void Unpause()
        {
            if (currentTrack >= 0 && currentMusicPlayer >= 0)
            {
                AudioPlayer currentPlayer = musicPlayers[currentMusicPlayer];
                AudioSource actualPlayer = currentPlayer.actualPlayer;
                if (currentPlayer.playerCouroutine == null)
                {
                    currentPlayer.playerCouroutine = StartCoroutine(SubclipPlayer());
                    actualPlayer.Play();
                }
            }
        }

        public void Stop()
        {
            if (currentTrack >= 0 && currentMusicPlayer >= 0)
            {
                AudioPlayer currentPlayer = musicPlayers[currentMusicPlayer];
                AudioSource actualPlayer = currentPlayer.actualPlayer;
                if (actualPlayer.isPlaying && currentPlayer.playerCouroutine != null)
                {
                    StopCoroutine(currentPlayer.playerCouroutine);
                    currentPlayer.playerCouroutine = null;
                    actualPlayer.Stop();
                    ResetPlayer(currentPlayer, Parameters.Tracks[currentTrack]);
                }
            }
        }

        public int AddTrackControl(AudioTrackControl control)
        {
            if (control != null)
            {
                Parameters.Tracks.Add(control);
                return Parameters.Tracks.Count - 1;
            }
            return -1;
        }

        private void OnEnable()
        {
            if (Initialized == Status.Ready)
            {
                Debug.Log("Enabling audio");
                Unpause();
            }
        }

        private void OnDisable()
        {
            if (Initialized == Status.Ready)
            {
                Debug.Log("Disabling audio");
                Pause();
            }
        }

    }

}
