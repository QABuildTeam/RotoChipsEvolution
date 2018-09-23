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

    [System.Serializable]
    public class SFXPlayParams
    {
        public SFXEnum id;
        public float pitchFactor;
        public float volumeFactor;
    }

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
        }

        public class MusicPlayer : AudioPlayer
        {
            public bool fading;                     // "FadeTrack coroutine is in progress" flag
            public AudioTrackEnum trackId;          // current AudioTrackControl id (-1 if no tracks)
            public bool loop;
            public int subclip;                     // current subclip id (-1 if no subclips)
            public int order;                       // current subclip order
            public float startTime;                 // start time of the currently played subclip (used for pausing the play)
            public float endTime;                   // end time of the currently played subclip (used for pausing the play)
        }

        public class SFXPlayer : AudioPlayer
        {
            public SFXEnum clipId;
        }

        MusicPlayer[] musicPlayers;
        SFXPlayer[] sfxPlayers;
        AudioTrackEnum currentTrack;
        int currentMusicPlayerId;
        int currentSFXPlayerId;

        Dictionary<AudioTrackEnum, AudioTrackControl> musicTracks;
        public Dictionary<AudioTrackEnum, AudioTrackControl> MusicTracks
        {
            get
            {
                if (musicTracks == null)
                {
                    musicTracks = new Dictionary<AudioTrackEnum, AudioTrackControl>();
                    if (Parameters != null)
                    {
                        foreach(AudioTrackControl track in Parameters.Tracks)
                        {
                            musicTracks.Add(track.id, track);
                        }
                    }
                }
                return musicTracks;
            }
        }

        Dictionary<SFXEnum, SFXControl> sfxClips;
        public Dictionary<SFXEnum, SFXControl> SFXClips
        {
            get
            {
                if (sfxClips == null)
                {
                    sfxClips = new Dictionary<SFXEnum, SFXControl>();
                    if (Parameters != null)
                    {
                        foreach (SFXControl sfx in Parameters.SFX)
                        {
                            sfxClips.Add(sfx.id, sfx);
                        }
                    }
                }
                return sfxClips;
            }
        }

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
                    if (musicPlayers.Length > 0 && currentMusicPlayerId >= 0)
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
                // set up music players
                musicPlayers = new MusicPlayer[Parameters.MaxAudioPlayers];
                for (int i = 0; i < musicPlayers.Length; i++)
                {
                    musicPlayers[i] = new MusicPlayer
                    {
                        actualPlayer = gameObject.AddComponent<AudioSource>(),
                        trackId = AudioTrackEnum.Unknown,
                        subclip = -1,
                        order = -1
                    };
                    musicPlayers[i].actualPlayer.playOnAwake = false;
                    musicPlayers[i].actualPlayer.volume = 0;
                }
                currentTrack = AudioTrackEnum.Unknown;
                currentMusicPlayerId = -1;

                // set up SFX players
                sfxPlayers = new SFXPlayer[Parameters.MaxSFXPlayers];
                for (int i = 0; i < sfxPlayers.Length; i++)
                {
                    sfxPlayers[i] = new SFXPlayer
                    {
                        actualPlayer = gameObject.AddComponent<AudioSource>(),
                        clipId = SFXEnum.Unknown
                    };
                    sfxPlayers[i].actualPlayer.playOnAwake = false;
                    sfxPlayers[i].actualPlayer.volume = 0;
                }

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
        IEnumerator SubclipMusicPlayer()
        {
            if (Parameters.Tracks.Count > 0)
            {
                int startPlayerId = currentMusicPlayerId;
                MusicPlayer currentMusicPlayer = musicPlayers[currentMusicPlayerId];
                AudioSource actualPlayer = currentMusicPlayer.actualPlayer;
                AudioTrackControl track = MusicTracks[currentTrack];
                do
                {
                    // prepare subclip play parameters
                    float startTime = currentMusicPlayer.startTime;
                    float waitTime = currentMusicPlayer.endTime - startTime;
                    //Debug.Log("Playing subclip " + currentMusicPlayer.subclip.ToString() + " from " + startTime.ToString() + ", waiting for " + waitTime.ToString());
                    // do the actual play
                    actualPlayer.time = startTime;
                    // ensure that actual player is really playing
                    if (!actualPlayer.isPlaying)
                    {
                        actualPlayer.Play();
                    }
                    yield return new WaitForSeconds(waitTime);

                    // move to the next subclip
                    PromoteToNextMusicSubclip(currentMusicPlayer, track);
                    //Debug.Log("Subclip order " + currentMusicPlayer.order.ToString() + "/" + track.subclipOrder.Length.ToString());
                }
                while (currentMusicPlayer.loop || currentMusicPlayer.order < track.subclipOrder.Length);
                // forcibly stop playing
                actualPlayer.Stop();
                if (startPlayerId == currentMusicPlayerId)
                {
                    currentMusicPlayerId = -1;
                }
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.MusicTrackPlayed, this, track.id);
            }
        }

        void ResetMusicMusicPlayer(MusicPlayer currentMusicPlayer, AudioTrackControl track)
        {
            currentMusicPlayer.order = -1;
            currentMusicPlayer.subclip = -1;
            PromoteToNextMusicSubclip(currentMusicPlayer, track);
        }

        void PromoteToNextMusicSubclip(MusicPlayer currentMusicPlayer, AudioTrackControl track)
        {
            if (track.subclips.Length > 0)
            {
                if (track.subclipOrder.Length > 0)
                {
                    currentMusicPlayer.order = (currentMusicPlayer.order + 1) % track.subclipOrder.Length;
                    currentMusicPlayer.subclip = track.subclipOrder[currentMusicPlayer.order];
                }
                else
                {
                    currentMusicPlayer.order = 0;
                    currentMusicPlayer.subclip = 0;
                }
                currentMusicPlayer.startTime = track.subclips[currentMusicPlayer.subclip].min;
                currentMusicPlayer.endTime = track.subclips[currentMusicPlayer.subclip].max;
            }
            else
            {
                currentMusicPlayer.order = 0;
                currentMusicPlayer.startTime = 0;
                currentMusicPlayer.endTime = track.clip.length;
            }
        }

        // this method fades the volume of a player with playerId in (start == true) or out (start == false)
        // it also starts playing a track with currentTrack id if start == true
        // and stops playing a current track otherwise
        IEnumerator FadeMusicTrack(int playerId, bool up, bool loop = false)
        {
            MusicPlayer currentPlayer = musicPlayers[playerId];
            currentPlayer.fading = true;
            currentPlayer.trackId = currentTrack;
            AudioSource actualPlayer = currentPlayer.actualPlayer;
            if (up || currentPlayer.trackId != AudioTrackEnum.Unknown)
            {
                AudioTrackControl track = MusicTracks[currentTrack];
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
                    ResetMusicMusicPlayer(currentPlayer, track);
                    // set the track and play
                    currentPlayer.loop = loop;
                    actualPlayer.clip = track.clip;
                    actualPlayer.Play();
                    currentPlayer.playerCouroutine = StartCoroutine(SubclipMusicPlayer());
                }
                // now fade the volume
                float startVolume = actualPlayer.volume;
                float endVolume = up ? track.volume * MaxMusicVolume : 0;
                float currentTime = 0;
                while (currentTime < Parameters.MusicCrossFadeTime)
                {
                    currentTime += Time.deltaTime;
                    actualPlayer.volume = Mathf.Lerp(startVolume, endVolume, currentTime / Parameters.MusicCrossFadeTime);
                    yield return null;
                }
                actualPlayer.volume = endVolume;
                if (!up)
                {
                    if (currentPlayer.playerCouroutine != null)
                    {
                        StopCoroutine(currentPlayer.playerCouroutine);
                    }
                    currentPlayer.playerCouroutine = null;
                    actualPlayer.Stop();
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.MusicTrackPlayed, this, currentPlayer.trackId);
                }
                currentPlayer.fading = false;
            }
        }

        // play a track w/crossfade
        public void PlayMusicTrack(AudioTrackEnum trackId, bool loop = false)
        {
            if (Parameters.Tracks.Count > 0)
            {
                if (currentMusicPlayerId >= 0)
                {
                    AudioSource actualPlayer = musicPlayers[currentMusicPlayerId].actualPlayer;
                    if (actualPlayer.isPlaying)
                    {
                        Debug.Log("Stopping track " + currentTrack.ToString());
                        // stop the currently playing track
                        StartCoroutine(FadeMusicTrack(currentMusicPlayerId, false));
                    }
                }
                Debug.Log("Playing track " + trackId.ToString());
                if (MusicTracks.ContainsKey(trackId))
                {
                    currentMusicPlayerId = (currentMusicPlayerId + 1) % musicPlayers.Length;
                    currentTrack = trackId;
                    StartCoroutine(FadeMusicTrack(currentMusicPlayerId, true, loop));
                }
                else
                {
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.MusicTrackPlayed, this, trackId);
                }
            }
            else
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.MusicTrackPlayed, this, trackId);
            }
        }

        public void Pause()
        {
            if (currentMusicPlayerId >= 0)
            {
                MusicPlayer currentPlayer = musicPlayers[currentMusicPlayerId];
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
            if (currentMusicPlayerId >= 0)
            {
                MusicPlayer currentPlayer = musicPlayers[currentMusicPlayerId];
                AudioSource actualPlayer = currentPlayer.actualPlayer;
                if (currentPlayer.playerCouroutine == null)
                {
                    currentPlayer.playerCouroutine = StartCoroutine(SubclipMusicPlayer());
                    actualPlayer.Play();
                }
            }
        }

        public void Stop()
        {
            if (currentMusicPlayerId >= 0)
            {
                MusicPlayer currentPlayer = musicPlayers[currentMusicPlayerId];
                AudioSource actualPlayer = currentPlayer.actualPlayer;
                if (actualPlayer.isPlaying && currentPlayer.playerCouroutine != null)
                {
                    StopCoroutine(currentPlayer.playerCouroutine);
                    currentPlayer.playerCouroutine = null;
                    actualPlayer.Stop();
                    ResetMusicMusicPlayer(currentPlayer, MusicTracks[currentTrack]);
                }
            }
        }

        public void PlaySFX(SFXPlayParams sfxParams)
        {
            if (sfxParams != null && SFXClips.ContainsKey(sfxParams.id) && sfxPlayers.Length > 0)
            {
                currentSFXPlayerId = (currentSFXPlayerId + 1) % sfxPlayers.Length;
                SFXPlayer sfxPlayer = sfxPlayers[currentSFXPlayerId];
                sfxPlayer.actualPlayer.Stop();
                SFXControl sfxControl = SFXClips[sfxParams.id];
                sfxPlayer.actualPlayer.clip = sfxControl.clip;
                sfxPlayer.actualPlayer.loop = sfxControl.loop;
                sfxPlayer.actualPlayer.pitch = sfxControl.pitch * sfxParams.pitchFactor;
                sfxPlayer.actualPlayer.volume = sfxControl.volume * sfxParams.volumeFactor;
                sfxPlayer.actualPlayer.Play();
            }
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
