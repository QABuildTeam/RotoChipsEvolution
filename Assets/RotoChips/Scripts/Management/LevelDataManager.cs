/*
 * File:        LevelDataManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class LevelDataManager manages loading and saving immutable and modifiable data for game levels
 * Created:     27.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Generic;
using RotoChips.Data;

namespace RotoChips.Management
{
    public class LevelDataManager : GenericManager
    {
        public class State                      // this is a structure of modifiable data which changes along the course of the game
        {
            public int id;                      // level id
            public string CurrentState;         // current level state
            public string LastGoodState;        // last good level state
            public string CurrentButtonState;   // current button rotation angles;
            public string LastGoodButtonState;  // last good button rotation angles
            public bool Revealed;               // this level is visible on the world map, but cannot be selected/played
            public bool Playable;               // this level has been revealed on the world map; it can be played, bu it's not yet complete
            public bool Complete;               // this level has been completed at least once; this flag cannot be reset in the course of a single game
            public bool AutocompleteUsed;       // autocompletion feature was used while completing this level; this flag can be reset while resetting the puzzle
            public int NextPlayableId;          // an id of the next playable level
            public int NextCompleteId;          // an id of the next complete level
            public long EarnedPoints;           // an amount of points earned in the level by the player before autocomplete has been used
        };
        public class Descriptor                 // this is a structure of current level status; modifying its components will not change the original data, though
        {
            public LevelData.Init init;
            public State state;
        };

        SortedDictionary<int, int> levelInits;      // a dictionary of indexes into the LevelData.initializers
        Dictionary<int, State> levelStates;         // a dictionary of level states

        public void ResetLevels()
        {
            levelInits = new SortedDictionary<int, int>();
            levelStates = new Dictionary<int, State>();
            for (int i = 0; i < LevelData.initializers.Length; i++)
            {
                int levelId = LevelData.initializers[i].id;
                State state = new State
                {
                    id = levelId,
                    CurrentState = "",
                    LastGoodState = "",
                    CurrentButtonState = "",
                    LastGoodButtonState = "",
                    Revealed = levelId == 0,
                    Complete = false,
                    Playable = levelId == 0,
                    AutocompleteUsed = false,
                    NextCompleteId = -1,
                    NextPlayableId = -1,
                    EarnedPoints = 0
                };
                levelInits.Add(levelId, i);
                levelStates.Add(levelId, state);
            }
        }

        public override void MakeInitial()
        {
            ResetLevels();
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

        public Descriptor GetLevelDescriptor(int levelId)
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

        public IEnumerable LevelDescriptors()
        {
            foreach (int levelId in levelInits.Keys)
            {
                yield return GetLevelDescriptor(levelId);
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

    }
}
