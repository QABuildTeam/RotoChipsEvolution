using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this class provides an application-wise interface to the PlayerPref persistent storage
public class AppData : MonoBehaviour
{
	public static AppData instance;			// unique Singleton instance

	// an enumeration of internal gameplay data
	public enum Storage                     // storage cells for application data
	{
		// numeric data
		SelectedLevel,                      // currently selected level id on the world map
		GalleryLevel,                       // currently selected level id in the gallery
		CurrentPoints,                      // current amount of points earned by the player in the current game round
		TotalPoints,                        // total earned points (from the very first start of the game)
											// boolean flags
		CurrentCoins,						// current amount of RotoCoins
		GameStarted,						// the game has already started for at least once
											// set when the game is started for the very first time,
											// and never reset
		FirstRound,                         // the game has not been beaten before;
											// set when the game is started for the very first time,
											// reset when the game is first finished
		FirstGallery,                       // the gallery has just been opened;
											// set after the first level in the first round is finished for the very first time,
											// reset after the gallery hint is displayed
		GameFinished,                       // a game round has just been finished;
											// set when the game has just been finished,
											// reset after the closing sequence is displayedd
		FirstPuzzleRun,                     // the first puzzle level is run for the very first time
											// button hints should be shown in this case
											// reset after hints are shown
		FirstTimeFinished,					// the game has been finished for the very first time,
											// but not yet restarted
											// reset after all the hints are displayed
		FirstStart,							// the game is started for the first time
											// set simultaneously with the GameStarted flag
											// reset after all the first welcome messages have been displayed
        BonusCoinsAdded                     // the player has already received bonus coins
                                            // set after adding the bonus coins to the player's balance and bever reset
	};

	// gameplay data may have different storage types
	public enum Type                        // a type of storage cells
	{
		Boolean,                            // bool
		Numeric,                            // long int
		Decimal,							// decimal
		String                              // string
	};

	[System.Serializable]
	public struct DataDef
	{
		public Storage storage;
		public Type type;
	};
	// this is a user manageable array of Storage Types accordances
	public DataDef[] initDefinitions;

	// this is a Dictionary set up from initDefinitions for faster Storage Type searches
	Dictionary<Storage, Type> definitions;

	// an auxilliary method which gets a Storage Type from definitions Dictionary
	Type getStorageType(Storage s)
	{
		Type v = Type.String;
		if (definitions.TryGetValue(s, out v))
		{
			return v;
		}
		return Type.String;
	}

	// an indexer for Storage index
	// usage examples:
	// bool isGaneStarted = AppData.instance[AppData.Storage.GameStarted];
	// AppData.instance[AppData.Storage.CurrentPoints] = (long)(currentPoints + 100);
	public object this[Storage s]
	{
		get
		{
			Type t = getStorageType(s);
			//Debug.Log("AppData.this[" + t.ToString() + " " + s.ToString() + "].get");
			switch (t)
			{
				case Type.Boolean:
					return (object)(PlayerPrefs.GetString(s.ToString()) == "yes");
				case Type.Numeric:
					long l;
					if (!long.TryParse(PlayerPrefs.GetString(s.ToString()), out l))
					{
						l = 0;
					}
					return (object)l;
				case Type.Decimal:
					decimal d;
					if (!decimal.TryParse(PlayerPrefs.GetString(s.ToString()), out d))
					{
						d = 0M;
					}
					return (object)d;
				case Type.String:
					return (object)PlayerPrefs.GetString(s.ToString());
			}
			return (object)null;
		}
		set
		{
			Type t = getStorageType(s);
			//Debug.Log("AppData.this[" + t.ToString() + " " + s.ToString() + "].set=" + value.ToString());
			switch (t)
			{
				case Type.Boolean:
					PlayerPrefs.SetString(s.ToString(), (bool)value ? "yes" : "no");
					break;
				case Type.Numeric:
				case Type.Decimal:
					PlayerPrefs.SetString(s.ToString(), value.ToString());
					break;
				case Type.String:
					PlayerPrefs.SetString(s.ToString(), (string)value);
					break;
			}
		}
	}

	// an indexer for a generic string index
	// mostly used for storing and retrieving level data (state, statuses, etc.)
	public string this[string s]
	{
		get
		{
			//Debug.Log("AppData.this[\"" + s + "\"].get");
			return PlayerPrefs.GetString(s);
		}
		set
		{
			//Debug.Log("AppData.this[\"" + s + "\"].set=\"" + value + "\"");
			PlayerPrefs.SetString(s, value);
		}
	}

	// utility method for retrieving numeric data
	public long getNumericValue(string s, long defaultValue = 0)
	{
		string v = instance[s];
		long result = defaultValue;
		if (v != "")
		{
			result = long.Parse(v);
			if (result == 0)
				result = defaultValue;
		}
		return result;
	}

	// utility method for retrieving decimal data
	public decimal getDecimalValue(string s, decimal defaultValue = 0M)
	{
		string v = instance[s];
		decimal result = defaultValue;
		if (v != "")
		{
			result = decimal.Parse(v);
			if (result == 0)
				result = defaultValue;
		}
		return result;
	}

	// actually, a Singleton constructor
	void Awake()
	{
		if (instance == null)
		{
			instance = this;
			// fill in the definitions Dictionary from initDefinitions array
			definitions = new Dictionary<Storage, Type>();
			foreach (DataDef dd in initDefinitions)
			{
				//Debug.Log("Adding app data: " + dd.storage.ToString() + "," + dd.type.ToString());
				definitions.Add(dd.storage, dd.type);
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

}
