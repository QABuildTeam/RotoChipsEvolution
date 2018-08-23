using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this class provides access to initial and current game level data
public class LevelData : MonoBehaviour
{

	public static LevelData instance;

	public struct Init                 // this is a structure of read-only data used for puzzle level initialization
	{
		public int id;
		public int realmId;
		public int height;
		public int width;
		public float srcXYScale;            // x/y ratio for 'source' image
		public float finalXYScale;          // x/y ratio for 'final' image
											/*
											public float selectLongitude;       // world longitude for level 'select' button
											public float selectLatitude;        // world latitude for level 'select' button
											*/
		public float eulerX;                // world euler rotation angle by X-axis for level 'select' button
		public float eulerY;                // world euler rotation angle by Y-axis for level 'select' button
		public float eulerZ;                // world euler rotation angle by Z-axis for level 'select' button
		public float selectHeight;          // height of level 'select' button
	};

	public struct Status               // this is a structure of modifiable data which changes wlong the course of the game
	{
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
	public struct Descriptor                 // this is a structure of current level status; modifying its components will not change the original data, though
	{
		public Init init;
		public Status status;
		public string GraphicsResource;     // a string of the level resources folder; this is a calculated value
	};

	static readonly Init[] initializers = {
		new Init { id=0, realmId=0, height=3, width=3, srcXYScale=1f, finalXYScale=1.88679245283019f, eulerX=30f, eulerY=195f, eulerZ=0f, selectHeight=1f },
		new Init { id=1, realmId=0, height=3, width=3, srcXYScale=1f, finalXYScale=1.53846153846154f, eulerX=30f, eulerY=187f, eulerZ=0f, selectHeight=0f },
		new Init { id=2, realmId=0, height=3, width=3, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=30f, eulerY=203f, eulerZ=0f, selectHeight=0f },
		new Init { id=3, realmId=0, height=3, width=3, srcXYScale=1f, finalXYScale=1.94647201946472f, eulerX=38f, eulerY=195f, eulerZ=0f, selectHeight=0f },
		new Init { id=4, realmId=0, height=4, width=3, srcXYScale=0.75f, finalXYScale=0.666666666666667f, eulerX=22f, eulerY=195f, eulerZ=0f, selectHeight=0f },
		new Init { id=5, realmId=1, height=3, width=3, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=-8f, eulerY=235f, eulerZ=-27f, selectHeight=1f },
		new Init { id=6, realmId=1, height=3, width=5, srcXYScale=1.66666666666667f, finalXYScale=2.83687943262411f, eulerX=-8f, eulerY=243f, eulerZ=-27f, selectHeight=0f },
		new Init { id=7, realmId=1, height=3, width=4, srcXYScale=1.33333333333333f, finalXYScale=1.50093808630394f, eulerX=-8f, eulerY=228f, eulerZ=-27f, selectHeight=0f },
		new Init { id=8, realmId=1, height=3, width=4, srcXYScale=1.33333333333333f, finalXYScale=1.50093808630394f, eulerX=-2f, eulerY=234.5f, eulerZ=-22f, selectHeight=0f },
		new Init { id=9, realmId=1, height=4, width=4, srcXYScale=1f, finalXYScale=1.49906191369606f, eulerX=-11f, eulerY=236f, eulerZ=-33.5f, selectHeight=0f },
		new Init { id=10, realmId=2, height=4, width=4, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=-70f, eulerY=-18f, eulerZ=10f, selectHeight=1f },
		new Init { id=11, realmId=2, height=4, width=4, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=-70f, eulerY=-10f, eulerZ=9f, selectHeight=0f },
		new Init { id=12, realmId=2, height=4, width=3, srcXYScale=0.75f, finalXYScale=1.50093808630394f, eulerX=-70f, eulerY=-25f, eulerZ=10f, selectHeight=0f },
		new Init { id=13, realmId=2, height=4, width=4, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=-76.5f, eulerY=-24.7f, eulerZ=17f, selectHeight=0f },
		new Init { id=14, realmId=2, height=4, width=5, srcXYScale=1.25f, finalXYScale=1.50093808630394f, eulerX=-63.5f, eulerY=-14.5f, eulerZ=6f, selectHeight=0f },
		new Init { id=15, realmId=3, height=4, width=4, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=-5f, eulerY=113f, eulerZ=19f, selectHeight=1f },
		new Init { id=16, realmId=3, height=3, width=5, srcXYScale=1.66666666666667f, finalXYScale=2.03562340966921f, eulerX=-5f, eulerY=106f, eulerZ=19f, selectHeight=0f },
		new Init { id=17, realmId=3, height=5, width=3, srcXYScale=0.6f, finalXYScale=1f, eulerX=-5f, eulerY=120f, eulerZ=19f, selectHeight=0f },
		new Init { id=18, realmId=3, height=4, width=5, srcXYScale=1.25f, finalXYScale=1.68161434977578f, eulerX=-1.5f, eulerY=113.2f, eulerZ=13.5f, selectHeight=0f },
		new Init { id=19, realmId=3, height=5, width=4, srcXYScale=0.8f, finalXYScale=1f, eulerX=-6.3f, eulerY=112.5f, eulerZ=26f, selectHeight=0f },
		new Init { id=20, realmId=4, height=2, width=4, srcXYScale=2f, finalXYScale=2.25352112676056f, eulerX=16.2f, eulerY=115f, eulerZ=-83.6f, selectHeight=1f },
		new Init { id=21, realmId=4, height=3, width=5, srcXYScale=1.66666666666667f, finalXYScale=1.50093808630394f, eulerX=17f, eulerY=108.5f, eulerZ=-83f, selectHeight=0f },
		new Init { id=22, realmId=4, height=4, width=5, srcXYScale=1.25f, finalXYScale=1.50093808630394f, eulerX=17.7f, eulerY=122f, eulerZ=-82.7f, selectHeight=0f },
		new Init { id=23, realmId=4, height=5, width=5, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=18f, eulerY=113f, eulerZ=-90f, selectHeight=0f },
		new Init { id=24, realmId=4, height=4, width=6, srcXYScale=1.5f, finalXYScale=1.58415841584158f, eulerX=13.8f, eulerY=116.6f, eulerZ=-77.5f, selectHeight=0f },
		new Init { id=25, realmId=5, height=5, width=5, srcXYScale=1f, finalXYScale=1f, eulerX=42f, eulerY=27f, eulerZ=16.8f, selectHeight=1f },
		new Init { id=26, realmId=5, height=5, width=5, srcXYScale=1f, finalXYScale=2.16049382716049f, eulerX=42f, eulerY=20f, eulerZ=16.4f, selectHeight=0f },
		new Init { id=27, realmId=5, height=4, width=5, srcXYScale=1.25f, finalXYScale=1.52749490835031f, eulerX=42.2f, eulerY=33.3f, eulerZ=16.3f, selectHeight=0f },
		new Init { id=28, realmId=5, height=5, width=5, srcXYScale=1f, finalXYScale=1.98863636363636f, eulerX=36f, eulerY=25.3f, eulerZ=14f, selectHeight=0f },
		new Init { id=29, realmId=5, height=6, width=6, srcXYScale=1f, finalXYScale=1.04017857142857f, eulerX=47.8f, eulerY=29.6f, eulerZ=20.4f, selectHeight=0f },
		new Init { id=30, realmId=6, height=2, width=6, srcXYScale=3f, finalXYScale=1.76767676767677f, eulerX=-3.6f, eulerY=288f, eulerZ=11.3f, selectHeight=1f },
		new Init { id=31, realmId=6, height=6, width=4, srcXYScale=0.666666666666667f, finalXYScale=0.66625f, eulerX=-2.2f, eulerY=281f, eulerZ=11.6f, selectHeight=0f },
		new Init { id=32, realmId=6, height=4, width=6, srcXYScale=1.5f, finalXYScale=1.79372197309417f, eulerX=-4.9f, eulerY=294.6f, eulerZ=10.76f, selectHeight=0f },
		new Init { id=33, realmId=6, height=6, width=5, srcXYScale=0.833333333333333f, finalXYScale=0.665f, eulerX=-5.7f, eulerY=287.3f, eulerZ=17.4f, selectHeight=0f },
		new Init { id=34, realmId=6, height=6, width=6, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=-2.2f, eulerY=288.3f, eulerZ=5.1f, selectHeight=0f }
	};

	// a dictionary of level id-index pairs (an index of a level in levelInitializers may not necessarily be equal to its id
	private Dictionary<int, int> levelDict;

	// actually, a Singleton constructor
	void Awake()
	{
		if (instance == null)
		{
			instance = this;
			levelDict = new Dictionary<int, int>();
			for (int i = 0; i < Count; i++)
			{
				levelDict.Add(initializers[i].id, i);
			}
		}
		else
		{
			if (instance != this)
			{
				Destroy(gameObject);
			}
		}
	}

	public int Count
	{
		get
		{
			return initializers.GetUpperBound(0) + 1;
		}
	}

	// indexer for LevelDesc data
	public Descriptor this[int levelId]  // levelId is not an index into levelInitializers
	{
		get
		{
			int i;
			if (levelDict.TryGetValue(levelId, out i))
			{
				Descriptor ld = new Descriptor();
				ld.init = initializers[i];
				string idStr = ld.init.id.ToString("D3");
				ld.GraphicsResource = "Textures/Levels/" + idStr;
				ld.status.CurrentState = AppData.instance["CState" + idStr];
				ld.status.LastGoodState = AppData.instance["GState" + idStr];
				ld.status.CurrentButtonState = AppData.instance["CBState" + idStr];
				ld.status.LastGoodButtonState = AppData.instance["GBState" + idStr];
				string levelStateStr = AppData.instance["LState" + idStr];
				if (levelStateStr.Length > 0)
				{
					ld.status.Revealed = levelStateStr[0] == 'T';
					ld.status.Playable = levelStateStr[1] == 'T';
					ld.status.Complete = levelStateStr[2] == 'T';
					ld.status.AutocompleteUsed = levelStateStr[3] == 'T';
				}
				else
				{
					ld.status.Revealed = false;
					ld.status.Playable = false;
					ld.status.Complete = false;
					ld.status.AutocompleteUsed = false;
				}
				ld.status.NextPlayableId = (int)(long)AppData.instance.getNumericValue("NP" + idStr, -1);
				ld.status.NextCompleteId = (int)(long)AppData.instance.getNumericValue("NC" + idStr, -1);
				long ep = AppData.instance.getNumericValue("EP" + idStr);
				if (ep >= 0)
				{
					ld.status.EarnedPoints = ep;
				}
				return ld;
			}
			return new Descriptor { init = new Init { id = -1, realmId = -1 } };
		}
		set
		{
			if (value.init.id != -1)   // no such level with id -1
			{
				string idStr = value.init.id.ToString("D3");
				AppData.instance["CState" + idStr] = value.status.CurrentState;
				AppData.instance["GState" + idStr] = value.status.LastGoodState;
				AppData.instance["CBState" + idStr] = value.status.CurrentButtonState;
				AppData.instance["GBState" + idStr] = value.status.LastGoodButtonState;
				string levelStateStr = (value.status.Revealed ? "T" : "F") + (value.status.Playable ? "T" : "F") + (value.status.Complete ? "T" : "F") + (value.status.AutocompleteUsed ? "T" : "F");
				AppData.instance["LState" + idStr] = levelStateStr;
				AppData.instance["NP" + idStr] = value.status.NextPlayableId.ToString();
				AppData.instance["NC" + idStr] = value.status.NextCompleteId.ToString();
				AppData.instance["EP" + idStr] = value.status.EarnedPoints.ToString();
			}
		}
	}

	public int LastOpenRealm()
	{
		int openLevel = 0;
		int openRealm = 0;
		for (int i = 0; i < Count; i++)
		{
			Descriptor ld = instance[i];
			if (ld.status.Playable && ld.init.id > openLevel)
			{
				openLevel = ld.init.id;
				openRealm = ld.init.realmId;
			}
		}
		return openRealm;
	}

	// this method resets all level statuses before a new game
	public void ResetLevels()
	{
		Descriptor ld = new Descriptor();
		Status ls = new Status();
		ls.CurrentState = "";
		ls.LastGoodState = "";
		ls.CurrentButtonState = "";
		ls.LastGoodButtonState = "";
		ls.Revealed = false;
		ls.Complete = false;
		ls.Playable = false;
		ls.AutocompleteUsed = false;
		ls.NextCompleteId = -1;
		ls.NextPlayableId = -1;
		ls.EarnedPoints = 0;
		for (int i = 1; i < Count; i++)
		{
			ld = instance[initializers[i].id];
			ld.status = ls;
			instance[initializers[i].id] = ld;
		}
		ld = instance[0];
		ls.Revealed = true;     // level 0 is always revealed
		ls.Playable = true;      // level 0 can always be played
		ld.status = ls;
		instance[0] = ld;
	}

	// ----- IEnumerator and IEnumerable interface methods implementation -----
	// this class is used to ensure a unique IEnumerator position within a specific enumeration process
	// usage example:
	// foreach (LevelData.LevelDesc ld in new LevelData.LevelEnumerator()) { }
	public class Enumerator : IEnumerator, IEnumerable
	{
		// Methods required by IEnumerator
		public IEnumerator GetEnumerator()
		{
			return this;
		}

		// Methods required by IEnumerable
		int position = -1;  // IEnumerable position index

		// constructor
		public Enumerator()
		{
			position = -1;
		}
		public bool MoveNext()
		{
			position++;
			return position < instance.Count;
		}

		public void Reset()
		{
			position = 0;
		}

		public object Current
		{
			get
			{
				return instance[position];
			}
		}
	}
}
