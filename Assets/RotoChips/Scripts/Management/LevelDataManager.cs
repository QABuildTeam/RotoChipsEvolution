/*
 * File:        LevelDataManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class LevelDataManager manages loading and saving immutable and modifiable data for game levels
 * Created:     27.08.2018
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Generic;
using RotoChips.Data;

namespace RotoChips.Management
{
    public class LevelDataManager : GenericManager
    {
        [Serializable]
        public class State                          // this is a structure of modifiable data which changes along the course of the game
        {

            [HideInInspector]
            protected int id;                       // level id
            public int Id
            {
                get
                {
                    return id;
                }
                set
                {
                    if (id != value)
                    {
                        id = value;
                        GlobalManager.Instance.Save();
                    }
                }
            }

            [HideInInspector]
            protected string currentState;          // current level state
            public string CurrentState
            {
                get
                {
                    return currentState;
                }
                set
                {
                    if (currentState != value)
                    {
                        currentState = value;
                        GlobalManager.Instance.Save();
                    }
                }
            }

            [HideInInspector]
            protected string lastGoodState;         // last good level state
            public string LastGoodState
            {
                get
                {
                    return lastGoodState;
                }
                set
                {
                    if (lastGoodState != value)
                    {
                        lastGoodState = value;
                        GlobalManager.Instance.Save();
                    }
                }
            }

            [HideInInspector]
            protected string currentButtonState;    // current button rotation angles;
            public string CurrentButtonState
            {
                get
                {
                    return currentButtonState;
                }
                set
                {
                    if (currentButtonState != value)
                    {
                        currentButtonState = value;
                        GlobalManager.Instance.Save();
                    }
                }
            }

            [HideInInspector]
            protected string lastGoodButtonState;   // last good button rotation angles
            public string LastGoodButtonState
            {
                get
                {
                    return lastGoodButtonState;
                }
                set
                {
                    if (lastGoodButtonState != value)
                    {
                        lastGoodButtonState = value;
                        GlobalManager.Instance.Save();
                    }
                }
            }

            [HideInInspector]
            protected bool revealed;                // this level is visible on the world map, but cannot be selected/played
            public bool Revealed
            {
                get
                {
                    return revealed;
                }
                set
                {
                    if (revealed != value)
                    {
                        revealed = value;
                    }
                }
            }

            [HideInInspector]
            protected bool playable;                // this level has been revealed on the world map; it can be played, but it's not yet complete
            public bool Playable
            {
                get
                {
                    return playable;
                }
                set
                {
                    if (playable != value)
                    {
                        playable = value;
                        GlobalManager.Instance.Save();
                    }
                }
            }

            [HideInInspector]
            protected bool complete;                // this level has been completed at least once; this flag cannot be reset in the course of a single game
            public bool Complete
            {
                get
                {
                    return complete;
                }
                set
                {
                    if (complete != value)
                    {
                        complete = value;
                        GlobalManager.Instance.Save();
                    }
                }
            }

            [HideInInspector]
            protected bool autocompleteUsed;        // autocompletion feature was used while completing this level; this flag can be reset while resetting the puzzle
            public bool AutocompleteUsed
            {
                get
                {
                    return autocompleteUsed;
                }
                set
                {
                    if (autocompleteUsed != value)
                    {
                        autocompleteUsed = value;
                        GlobalManager.Instance.Save();
                    }
                }
            }

            [HideInInspector]
            protected int nextPlayableId;           // an id of the next playable level
            public int NextPlayableId
            {
                get
                {
                    return nextPlayableId;
                }
                set
                {
                    if (nextPlayableId != value)
                    {
                        nextPlayableId = value;
                        GlobalManager.Instance.Save();
                    }
                }
            }

            [HideInInspector]
            protected int nextCompleteId;           // an id of the next complete level
            public int NextCompleteId
            {
                get
                {
                    return nextCompleteId;
                }
                set
                {
                    if (nextCompleteId != value)
                    {
                        nextCompleteId = value;
                        GlobalManager.Instance.Save();
                    }
                }
            }

            [HideInInspector]
            protected long earnedPoints;            // an amount of points earned in the level by the player before autocomplete has been used
            public long EarnedPoints
            {
                get
                {
                    return earnedPoints;
                }
                set
                {
                    if (earnedPoints != value)
                    {
                        earnedPoints = value;
                        GlobalManager.Instance.Save();
                    }
                }
            }
            public State(int anId)
            {
                id = anId;
                currentState = "";
                lastGoodState = "";
                currentButtonState = "";
                lastGoodButtonState = "";
                revealed = anId == 0;
                //revealed = true;
                complete = false;
                playable = anId == 0;
                //playable = true;
                autocompleteUsed = false;
                nextCompleteId = -1;
                nextPlayableId = -1;
                earnedPoints = 0;
            }
        };

        public class Descriptor                 // this is a structure of current level status; modifying its components will not change the original data, though
        {
            public LevelData.Init init;
            public State state;
        };

        SortedDictionary<int, int> levelInits;      // a dictionary of indexes into the LevelData.initializers
        Dictionary<int, State> levelStates;         // a dictionary of level states

        // this method resets all the levels into their initial state
        // used while initializing or resetting the game
        public void InitializeLevels()
        {
            levelInits = new SortedDictionary<int, int>();
            levelStates = new Dictionary<int, State>();
            for (int i = 0; i < LevelData.initializers.Length; i++)
            {
                int levelId = LevelData.initializers[i].id;
                State state = new State(levelId);
                levelInits.Add(levelId, i);
                levelStates.Add(levelId, state);
                ResetLevel(levelId);
            }
        }

        // GenericManager overrides
        public override void MakeInitial()
        {
            InitializeLevels();
            base.MakeInitial();
        }

        const string signature = ".levelstatus.";
        public override bool CheckSignature(string initLine)
        {
            return initLine == signature;
        }
        public override string SaveSignature()
        {
            return signature;
        }

        public override void Load(object prototype)
        {
            levelStates = (Dictionary<int, State>)prototype;
        }

        public override object Save()
        {
            return levelStates;
        }

        // this method returns a new descriptor with the access to init and state parts of the level description
        public Descriptor GetDescriptor(int levelId)
        {
            int initializersId;
            if (levelInits != null && levelInits.TryGetValue(levelId, out initializersId))
            {
                State state;
                if (levelStates != null && levelStates.TryGetValue(levelId, out state))
                {
                    Descriptor d = new Descriptor
                    {
                        init = LevelData.initializers[initializersId],
                        state = state
                    };
                    return d;
                }
            }
            return null;
        }

        public static string GraphicsResource(int levelId)
        {
            return "Textures/Levels/" + levelId.ToString("D3");
        }

        public static string SmoothImageResource(int levelId)
        {
            return GraphicsResource(levelId) + "/smooth";
        }

        public IEnumerable LevelDescriptors()
        {
            foreach (int levelId in levelInits.Keys)
            {
                yield return GetDescriptor(levelId);
            }
        }

        public int LastOpenRealm()
        {
            int openLevel = 0;
            int openRealm = 0;
            foreach (Descriptor ld in LevelDescriptors())
            {
                if (ld.state.Playable && ld.init.id > openLevel)
                {
                    openLevel = ld.init.id;
                    openRealm = ld.init.realmId;
                }
            }
            return openRealm;
        }

        public int NextLevel(int levelId)
        {
            bool thisLevel = false;
            foreach (LevelData.Init levelInit in LevelData.initializers)
            {
                if (levelInit.id == levelId)
                {
                    thisLevel = true;
                }
                else if (thisLevel)
                {
                    return levelInit.id;
                }
            }
            return -1;
        }

        public int PreviousLevel(int levelId)
        {
            int previousLevel = -1;
            foreach (LevelData.Init levelInit in LevelData.initializers)
            {
                if (levelInit.id == levelId)
                {
                    return previousLevel;
                }
                else
                {
                    previousLevel = levelInit.id;
                }
            }
            return -1;
        }

        public void ResetLevel(int levelId, bool keepPlayable = false)
        {
            State state = levelStates[levelId];
            state.Complete = false;
            state.AutocompleteUsed = false;
            state.CurrentButtonState = string.Empty;
            state.CurrentState = string.Empty;
            state.LastGoodButtonState = string.Empty;
            state.LastGoodState = string.Empty;
            state.NextCompleteId = -1;
            state.NextPlayableId = -1;
            if (!keepPlayable)
            {
                state.Playable = levelId == 0;
                state.Revealed = levelId == 0;
            }
            state.EarnedPoints = 0;
        }

    }
}
