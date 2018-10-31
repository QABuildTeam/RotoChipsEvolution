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
using RotoChips.Generic;

namespace RotoChips.Management
{
    public class StorageManager : GenericManager
    {
        [System.Serializable]
        public class Storage
        {
            public bool gameStarted;            // the game has already started for at least once
                                                // set when the game is started for the very first time,
                                                // and never reset
            public int selectedLevel;           // currently selected level id on the world map
            public int galleryLevel;            // currently selected level id in the gallery
            public long currentPoints;          // current amount of points earned by the player in the current game round
            public long totalPoints;            // total earned points (from the very first start of the game)
                                                // boolean flags
            public decimal currentCoins;        // current amount of RotoCoins
            public bool firstRound;             // the game has not been beaten before;
                                                // set when the game is started for the very first time,
                                                // reset when the game is first finished
            public bool firstGallery;           // the gallery has just been opened;
                                                // set after the first level in the first round is finished for the very first time,
                                                // reset after the gallery hint is displayed
            public bool gameFinished;           // a game round has just been finished;
                                                // set when the game has just been finished,
                                                // reset after the closing sequence is displayedd
            public bool firstPuzzleRun;         // the first puzzle level is run for the very first time
                                                // button hints should be shown in this case
                                                // reset after hints are shown
            public bool firstTimeFinished;      // the game has been finished for the very first time,
                                                // but not yet restarted
                                                // reset after all the hints are displayed
            public bool firstStart;             // the game is started for the first time
                                                // set simultaneously with the GameStarted flag
                                                // reset after all the first welcome messages have been displayed
            public bool bonusCoinsAdded;        // the player has already received bonus coins
                                                // set after adding the bonus coins to the player's balance and never reset
            public bool introShown;             // the Story scene has been shown
                                                // set after the Story scene has been shown and is never reset
            public bool finaleShown;            // the Finale scene has been shown
                                                // set after the Finale scene has been shown and is never reset
        }

        // real storage
        protected Storage storage;

        // storage accessors
        public bool GameStarted
        {
            get
            {
                return storage.gameStarted;
            }
            set
            {
                if (storage.gameStarted != value)
                {
                    storage.gameStarted = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public int SelectedLevel
        {
            get
            {
                return storage.selectedLevel;
            }
            set
            {
                if (storage.selectedLevel != value)
                {
                    storage.selectedLevel = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public int GalleryLevel
        {
            get
            {
                return storage.galleryLevel;
            }
            set
            {
                if (storage.galleryLevel != value)
                {
                    storage.galleryLevel = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public long CurrentPoints
        {
            get
            {
                return storage.currentPoints;
            }
            set
            {
                if (storage.currentPoints != value)
                {
                    storage.currentPoints = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public long TotalPoints
        {
            get
            {
                return storage.totalPoints;
            }
            set
            {
                if (storage.totalPoints != value)
                {
                    storage.totalPoints = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public decimal CurrentCoins
        {
            get
            {
                return storage.currentCoins;
            }
            set
            {
                if (storage.currentCoins != value)
                {
                    storage.currentCoins = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public bool FirstRound
        {
            get
            {
                return storage.firstRound;
            }
            set
            {
                if (storage.firstRound != value)
                {
                    storage.firstRound = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public bool FirstGallery
        {
            get
            {
                return storage.firstGallery;
            }
            set
            {
                if (storage.firstGallery != value)
                {
                    storage.firstGallery = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public bool GameFinished
        {
            get
            {
                return storage.gameFinished;
            }
            set
            {
                if (storage.gameFinished != value)
                {
                    storage.gameFinished = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public bool FirstPuzzleRun
        {
            get
            {
                return storage.firstPuzzleRun;
            }
            set
            {
                if (storage.firstPuzzleRun != value)
                {
                    storage.firstPuzzleRun = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public bool FirstTimeFinished
        {
            get
            {
                return storage.firstTimeFinished;
            }
            set
            {
                if (storage.firstTimeFinished != value)
                {
                    storage.firstTimeFinished = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public bool FirstStart
        {
            get
            {
                return storage.firstStart;
            }
            set
            {
                if (storage.firstStart != value)
                {
                    storage.firstStart = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public bool BonusCoinsAdded
        {
            get
            {
                return storage.bonusCoinsAdded;
            }
            set
            {
                if (storage.bonusCoinsAdded != value)
                {
                    storage.bonusCoinsAdded = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public bool IntroShown
        {
            get
            {
                return storage.introShown;
            }
            set
            {
                if (storage.introShown != value)
                {
                    storage.introShown = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        public bool FinaleShown
        {
            get
            {
                return storage.finaleShown;
            }
            set
            {
                if (storage.finaleShown != value)
                {
                    storage.finaleShown = value;
                    GlobalManager.Instance.Save();
                }
            }
        }

        protected virtual Storage InitialStorage()
        {
            Storage tempStorage = new Storage
            {
                gameStarted = false,
                selectedLevel = 0,
                galleryLevel = -1,
                currentPoints = 0,
                totalPoints = 0,
                currentCoins = 0m,
                firstRound = true,
                firstGallery = false,
                gameFinished = false,
                firstPuzzleRun = true,
                firstTimeFinished = false,
                firstStart = true,
                bonusCoinsAdded = false,
                introShown = false,
                finaleShown = false
            };
            return tempStorage;
        }

        public override void MakeInitial()
        {
            storage = InitialStorage();
            base.MakeInitial();
        }

        // streaming methods
        const string signature = ".storage.";
        public override bool CheckSignature(string initLine)
        {
            return initLine == signature;
        }

        public override void Load(object prototype)
        {
            Storage tempStorage = prototype as Storage;
            if (tempStorage != null)
            {
                storage = tempStorage;
            }
        }

        public override string SaveSignature()
        {
            return signature;
        }

        public override object Save()
        {
            return storage;
        }

        public override void MakeReady()
        {
            bool saveNow = !storage.gameStarted;
            storage.gameStarted = true;
            base.MakeReady();
            // special case of saving
            if (saveNow)
            {
                StartCoroutine(SaveNow());
            }
        }

        IEnumerator SaveNow()
        {
            while (!GlobalManager.Instance.Initialized)
            {
                yield return null;
            }
            GlobalManager.Instance.Save();
        }
    }
}
