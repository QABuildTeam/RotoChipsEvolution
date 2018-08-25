/*
 * File:        StorageManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class LocalizationManager serves as a means for storing and retrieving various global game data
 *              It is used as a replacement for PlayerPrefs
 * Created:     05.07.2018
 */
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace RotoChips.Management
{
    public class StorageManager : GenericManager
    {
        public class Storage
        {
            public int SelectedLevel;           // currently selected level id on the world map
            public int GalleryLevel;            // currently selected level id in the gallery
            public long CurrentPoints;          // current amount of points earned by the player in the current game round
            public long TotalPoints;            // total earned points (from the very first start of the game)
                                                // boolean flags
            public decimal CurrentCoins;        // current amount of RotoCoins
            public bool GameStarted;            // the game has already started for at least once
                                                // set when the game is started for the very first time,
                                                // and never reset
            public bool FirstRound;             // the game has not been beaten before;
                                                // set when the game is started for the very first time,
                                                // reset when the game is first finished
            public bool FirstGallery;           // the gallery has just been opened;
                                                // set after the first level in the first round is finished for the very first time,
                                                // reset after the gallery hint is displayed
            public bool GameFinished;           // a game round has just been finished;
                                                // set when the game has just been finished,
                                                // reset after the closing sequence is displayedd
            public bool FirstPuzzleRun;         // the first puzzle level is run for the very first time
                                                // button hints should be shown in this case
                                                // reset after hints are shown
            public bool FirstTimeFinished;      // the game has been finished for the very first time,
                                                // but not yet restarted
                                                // reset after all the hints are displayed
            public bool FirstStart;             // the game is started for the first time
                                                // set simultaneously with the GameStarted flag
                                                // reset after all the first welcome messages have been displayed
            public bool BonusCoinsAdded;        // the player has already received bonus coins
                                                // set after adding the bonus coins to the player's balance and bever reset
        }

        public override void MakeInitial()
        {
            base.MakeInitial();
        }

        // streaming methods
        public override bool CheckSignature(string initLine)
        {
            return base.CheckSignature(initLine);
        }

        public override void Load(StreamReader stream)
        {
            base.Load(stream);
        }

        public override string SaveSignature()
        {
            return base.SaveSignature();
        }

        public override void Save(StreamWriter stream)
        {
            base.Save(stream);
        }

        public override void MakeReady()
        {
            base.MakeReady();
        }
    }
}
