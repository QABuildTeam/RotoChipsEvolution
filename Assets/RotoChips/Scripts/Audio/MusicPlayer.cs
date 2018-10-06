/*
 * File:        MusicPlayer.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class MusicPlayer controls music themes which are played at a particular scene
 * Created:     17.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.Audio
{

    public enum BackGroundMusicMode
    {
        Off,    // do not play anything
        One,    // repeat playing one track from the playlist
        All     // play all tracks from playlist in a random order
    }
    public class MusicPlayer : MonoBehaviour
    {

        [SerializeField]
        protected List<AudioTrackEnum> playList;
        protected List<AudioTrackEnum> allPlayList;
        AudioTrackEnum currentTrack;
        [SerializeField]
        protected BackGroundMusicMode musicMode;

        MessageRegistrator registrator;
        private void Awake()
        {
            currentTrack = AudioTrackEnum.Unknown;
            registrator = new MessageRegistrator(
                InstantMessageType.PlayMusicTrack, (InstantMessageHandler)OnPlayMusicTrack,
                InstantMessageType.BackgroundMusic, (InstantMessageHandler)OnBackgroundMusic,
                InstantMessageType.MusicTrackPlayed, (InstantMessageHandler)OnMusicTrackPlayed
            );
            registrator.RegisterHandlers();
        }

        // Use this for initialization
        void Start()
        {
            PlayNextTrack();
        }

        void PlayNextTrack()
        {
            if (playList.Count > 0)
            {
                switch (musicMode)
                {
                    case BackGroundMusicMode.Off:
                        currentTrack = AudioTrackEnum.Unknown;
                        GlobalManager.MAudio.PlayMusicTrack(currentTrack, false);   // just stop playing
                        break;
                    case BackGroundMusicMode.One:
                        if (currentTrack == AudioTrackEnum.Unknown)
                        {
                            currentTrack = playList[Random.Range(0, playList.Count)];
                        }
                        GlobalManager.MAudio.PlayMusicTrack(currentTrack, false);   // play the same track over and over again
                        break;
                    case BackGroundMusicMode.All:
                        // shuffle the original playlist but make sure each track is only played once
                        if (allPlayList == null)
                        {
                            allPlayList = new List<AudioTrackEnum>();
                        }
                        if (allPlayList.Count == 0)
                        {
                            foreach (AudioTrackEnum track in playList)
                            {
                                allPlayList.Add(track);
                            }
                        }
                        int trackIndex = Random.Range(0, allPlayList.Count);
                        currentTrack = allPlayList[trackIndex];
                        // remove the currently playing entry from the playlist
                        allPlayList.RemoveAt(trackIndex);
                        GlobalManager.MAudio.PlayMusicTrack(currentTrack, false);   // play a random track from the playlist
                        break;
                }
            }
        }

        // message handling
        // this method implements a PlayMusicTrack command handling
        void OnPlayMusicTrack(object sender, InstantMessageArgs args)
        {
            PlayNextTrack();
        }

        void OnBackgroundMusic(object sender, InstantMessageArgs args)
        {
            musicMode = (BackGroundMusicMode)args.arg;
            PlayNextTrack();
        }

        void OnMusicTrackPlayed(object sender, InstantMessageArgs args)
        {
            if (musicMode != BackGroundMusicMode.Off)
            {
                AudioTrackEnum trackId = (AudioTrackEnum)args.arg;
                if (trackId == currentTrack && currentTrack != AudioTrackEnum.Unknown)
                {
                    PlayNextTrack();
                }
            }
        }

        private void OnDestroy()
        {
            Debug.Log("MusicPlayer: unregistering handlers");
            registrator.UnregisterHandlers();
        }
    }
}
