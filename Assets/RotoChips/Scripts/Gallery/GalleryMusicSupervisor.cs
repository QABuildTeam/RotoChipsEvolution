/*
 * File:        GalleryMusicSupervisor.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class GalleryMusicSupervisor keeps the MusicPlayer object on the Gallery scene playing until the player chooses to return back to the World scene
 * Created:     29.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.Gallery
{
    public class GalleryMusicSupervisor : MonoBehaviour
    {
        // create a Singleton
        private static bool initialised;
        MessageRegistrator registrator;
        private void Awake()
        {
            if (!initialised)
            {
                initialised = true;
                DontDestroyOnLoad(gameObject);
                registrator = new MessageRegistrator(InstantMessageType.GalleryClosed, (InstantMessageHandler)OnGalleryClosed);
                registrator.RegisterHandlers();
            }
            else
            {
                Destroy(gameObject);
            }
        }

        void OnGalleryClosed(object sender, InstantMessageArgs args)
        {
            registrator.UnregisterHandlers();
            Destroy(gameObject);
        }
    }
}
