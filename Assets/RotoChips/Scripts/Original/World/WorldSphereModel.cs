using System;
using System.Collections;
using UnityEngine;

public class WorldSphereModel : MonoBehaviour {

    public float rotationDeltaAngle;
    public float selfRotationWaitTime;

	bool rotationEnabled;
    bool isRotating;
    float selfRotationStartTime;

    public GameObject cloudsPrefab;
    GameObject clouds;
    bool fadeClouds;
    public GameObject[] levelSelectSpikePrefab;
	//public Material[] levelSpikePrefabTransparentMaterial;
	public GameObject beaconPrefab;
	public GameObject ConnectLinePrefab;
    GameObject[] selectors;
    int activeSelector;

    int levelSelector;
    int gallerySelector;

    int cameraPhase;
    public float spikeSize;
    public int cameraStepsCount;

    public GameObject worldListener;

	void Awake()
	{
		// this method constructs the level selection objects on the world sphere
		// using levelSelectSpikePrefab

		fadeClouds = false;
		// now construct and set up level selectors
		disableRotation();                                      // make sure the sphere does not rotate while constructing spikes
		transform.eulerAngles = new Vector3(0, 0, 0);
		float radius = transform.localScale.x / 2f;             // all radii are aqual
		selectors = new GameObject[LevelData.instance.Count];   // an array of selector objects
		Vector3 position = new Vector3(0f, 0f, -radius);
		position += gameObject.transform.position;      // this is a point on the world sphere raight before the player's eyes
		activeSelector = -1;
		gallerySelector = -1;
		Quaternion cloudsQ = Quaternion.Euler(0, 0, 0);
		bool setClouds = false;
		int visibleSelectors = 0;
		// create a beacon
		GameObject beacon = (GameObject)Instantiate(beaconPrefab);
		// iterate through levels
		//Debug.Log("WSM.Start: creating selectors");
		int i = 0;  // a selectors index
		foreach (LevelData.Descriptor ld in new LevelData.Enumerator())
		{
			//Debug.Log("WSM.Start: processing level " + ld.init.id.ToString());
			if (ld.status.Revealed)     // the level is visible on the world map
			{
				// set initial rotation for the level button
				Quaternion r = Quaternion.Euler(ld.init.eulerX, ld.init.eulerY, ld.init.eulerZ);
				//Quaternion r = Quaternion.Euler(-ld.init.selectLongitude, -ld.init.selectLatitude, 0);
				transform.rotation = r;

				// create and set up a level selection button/spike
				int prefabId = ld.init.realmId % (levelSelectSpikePrefab.GetUpperBound(0) + 1);
				selectors[i] = (GameObject)Instantiate(levelSelectSpikePrefab[prefabId]);     // a new level selection button/spike
				LevelSelectScript s = selectors[i].GetComponent<LevelSelectScript>();
				selectors[i].transform.position = Vector3.zero;
				s.setHeight(spikeSize);                                             // set the spike height
				selectors[i].transform.position += position;                        // move it the nearest to player point
				selectors[i].transform.position += new Vector3(0, 0, ld.init.selectHeight > spikeSize ? -ld.init.selectHeight : -spikeSize);
				RealmData.Init ri = RealmData.instance[ld.init.realmId];
				// set the spike colors
				//s.setColor(ri.normalColor, ri.selectColor, ri.activeColor);         // from the realm settings
				//s.setEmission(ri.normalEmission, ri.selectEmission, ri.activeEmission);
				string IconPath = ld.GraphicsResource + (ld.status.Playable ? "/icon" : "/grayicon");
				selectors[i].GetComponentInChildren<SpriteRenderer>().sprite = Resources.Load<Sprite>(IconPath);    // set the spike icon
				s.LevelId = ld.init.id;                                             // set the spike level id
				selectors[i].SetActive(true);                                       // activate it
				selectors[i].transform.SetParent(transform);                        // link the spike to the world sphere

				// now link the beacon to the spike selector
				if (ld.status.Playable)
				{
					beacon.transform.SetParent(null);
					beacon.transform.position = Vector3.zero;
					beacon.transform.position += position;
					beacon.transform.position += new Vector3(0, 0, ld.init.selectHeight > spikeSize ? -ld.init.selectHeight : -spikeSize);
					beacon.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
					beacon.transform.SetParent(selectors[i].transform);
					beacon.transform.localScale = new Vector3(1, 1, 1);
				}
				//Debug.Log("setting beacon to " + beacon.transform.position.ToString() + " and " + beacon.transform.rotation.ToString());

				Material bm = selectors[i].GetComponent<MeshRenderer>().materials[0];
				if (ld.init.id == (int)(long)AppData.instance[AppData.Storage.SelectedLevel])     // if the spike represents the selected level
				{
					//Debug.Log("selected level: " + ld.init.id.ToString());
					activeSelector = i;
					levelSelector = i;
					//StandardShaderUtils.ChangeRenderMode(bm, StandardShaderUtils.BlendMode.Opaque);
					s.setEnabled(true);
					s.setSelected(true);   // and mark the spike as selected
				}
				else
				{
					if (ld.status.Playable)
					{
						//StandardShaderUtils.ChangeRenderMode(bm, StandardShaderUtils.BlendMode.Opaque);
						s.setEnabled(true);
						s.setSelected(false);   // mark it as unselected
					}
					else
					{
						StandardShaderUtils.ChangeRenderMode(bm, StandardShaderUtils.BlendMode.Transparent);
						s.setEnabled(false);
					}
				}
				if (ld.init.id == (int)(long)AppData.instance[AppData.Storage.GalleryLevel])
				{
					gallerySelector = i;
				}
				s.listener = worldListener;                                         // set up event listener
																					// set up the clouds
				if (ld.status.Playable && ld.init.id != ri.mainLevelId && setClouds)
				{
					// count visible (playable) selectors in the las realm (except the main selector)
					visibleSelectors++;
					//Debug.Log("visible selectors=" + visibleSelectors.ToString());
				}
				if (ld.status.Playable && ld.init.id == ri.mainLevelId)
				{
					setClouds = true;
					// save the rotation quaternion of the main level selector of the realm
					cloudsQ = r;
					visibleSelectors = 0;
				}
				// now try to connect current selector with the previous one using glowing lines
				if (ld.init.selectHeight < 1f)  // realm entrance selectors have non-zero selectHeight
				{
					if (ld.status.Playable && ld.status.Complete)   // only playable and revealed selectors are connected
					{
						// connect the current selector with the previous one
						GameObject connectorLine = (GameObject)Instantiate(ConnectLinePrefab);
						connectorLine.GetComponent<InterCubeLineFlasher>().initLine(ri.connectorColor);
						connectorLine.transform.position = selectors[i].transform.position;
						connectorLine.transform.SetParent(selectors[i].transform);

						LineRenderer lr = connectorLine.GetComponent<LineRenderer>();
						lr.SetPosition(0, Vector3.zero);
						lr.SetPosition(1, selectors[i - 1].transform.position - selectors[i].transform.position);
					}
				}
				i++;
			}
		}
		if (setClouds && visibleSelectors == 1) // if there is only one visible (playable) selector in the realm (except the main one)
		{
			fadeClouds = true;  // fade the clouds later
		}
		else if (visibleSelectors > 1)
		{
			setClouds = false;  // do not set up the clouds
		}
		if (setClouds)          // set up the clouds
		{
			transform.rotation = cloudsQ;
			clouds = (GameObject)Instantiate(cloudsPrefab);
			clouds.transform.SetParent(transform);
		}
		// set the world sphere to the initial position
		transform.rotation = Quaternion.Euler(0, 0, 0);
		enableRotation();
		//Debug.Log("WSM.Start: selectors created");
	}

    public bool cloudsFading()
    {
        return fadeClouds;
    }

    public void fadeCloudsDown()
    {
        fadeClouds = false;
        clouds.GetComponent<CloudFader>().fadeClouds();
    }

    public int iActiveSelector()
    {
        return activeSelector;
    }

    public int iGallerySelector()
    {
        return gallerySelector;
    }

    public int iLevelSelector()
    {
        return levelSelector;
    }

	public GameObject activeSelectorObject() {
		//Debug.Log("active selector object (" + activeSelector.ToString() + ") is " + selectors[activeSelector].ToString());
		return selectors [activeSelector];
	}

    // this method starts rotation of the world sphere to place a selected selector before the player's eyes
    public void rotateToSelected()
    {
        if (activeSelector >= 0 && activeSelector < selectors.GetUpperBound(0) + 1)
        {
            StartCoroutine(rotateToSphereZero(selectors[activeSelector]));
        }
    }

	// this method starts rotation of the world sphere to place an object right before the player's eyes
	public void rotateToObject(GameObject o) {
		StartCoroutine (rotateToSphereZero (o));
	}

    // and this method performs such a rotation
    IEnumerator rotateToSphereZero(GameObject rotateTarget)
    {
        // this method rotates the world sphere so that the selected spike would stop right before the player's eyes
        Vector3 pos = rotateTarget.transform.position;  // a vector that points to rotateTarget
        Vector3 viewer = Vector3.back;                  // a vector that points to the player
        float angle = Vector3.Angle(pos, viewer);       // a flat angle between start (pos) and end (viewer) vectors
        if (Math.Abs(angle) > 0.5f)                     // the angle is too small, do not rotate
        {
            Vector3 cross = Vector3.Cross(pos, viewer); // cross product of pos and viewer
            float deltaAngle = angle / cameraStepsCount;
            yield return new WaitForFixedUpdate();
            for (int i = 0; i < cameraStepsCount; ++i)
            {
                //transform.Rotate(cross, Space.World);
                transform.Rotate(cross, deltaAngle, Space.World);
                yield return new WaitForFixedUpdate();
            }
        }
        //Debug.Log("Rotated to: " + gameObject.transform.rotation.eulerAngles.ToString());
        worldListener.SendMessage("sphereZeroRotated");
    }

    // this method stops the axial rotation of the world sphere
    // it wil start the rotation again itself after selfRotationWaitTime seconds
    public void stopRotation()
    {
        isRotating = false;
        selfRotationStartTime = Time.time;
    }

	public void enableRotation() {
		//Debug.Log("World sphere rotation enabled");
		rotationEnabled = true;
		stopRotation ();
	}

	public void disableRotation() {
		//Debug.Log("World sphere rotation disabled");
		rotationEnabled = false;
	}

    // this method just rotates the world sphere by an angle specified in delta
    // it is used when the player slides his finger on the screen
    public void rotateByAngle(Vector3 delta)
    {
        gameObject.transform.Rotate(delta, Space.World);
    }

    // this method rotates the world sphere around the z-axis
    // by an angle specified in delta
    // it is used when the player rotates his two-finger touch
    public void rotateZByAngle(float delta)
    {
        gameObject.transform.Rotate(new Vector3(0, 0, delta), Space.World);
    }

    // this method returns the level status of the selector
    public void getSelectorStatus(int selector, out bool Playable, out bool Complete)
    {
        int levelId = getSelectorLevel(selector);
        Playable = false;
		Complete = false;
        if (levelId != -1)
        {
			LevelData.Descriptor ld = LevelData.instance[levelId];
            Playable = ld.status.Playable;
			Complete = ld.status.Complete;
        }
    }

	// returns the level id assigned to a selector
	public int getSelectorLevel(int selector)
	{
		if (selector >= 0 && selector < selectors.GetUpperBound(0) + 1)
		{
			return selectors[selector].GetComponent<LevelSelectScript>().LevelId;
		}
		return -1;
	}

    // this auxillary method sets or resets selection status
    void setLevelSelection(int selector, bool on)
    {
        LevelSelectScript lss = selectors[selector].GetComponent<LevelSelectScript>();
        lss.setSelected(on);
        //int levelId = lss.LevelId;
        /*
        if (on) // if selection is set on
        {
            PlayerStat.instance.SelectedLevel = levelId;
        }
        */
        /*
		PlayerStat.LevelDesc ld = PlayerStat.instance.loadPlayerState(levelId);
        ld.status.Playable = on;
		PlayerStat.instance.saveLevelStatus(ld);
        */
    }

    // this method unselects activeSelector and makes a selector selected
    public bool setSelectedSelector(int selector)
    {
        if (selector >= 0 && selector < selectors.GetUpperBound(0) + 1)
        {
            if (selector != activeSelector)
            {
                if (activeSelector >= 0 && activeSelector < selectors.GetUpperBound(0) + 1)
                {
                    setLevelSelection(activeSelector, false);
                }
            }
            activeSelector = selector;
            setLevelSelection(activeSelector, true);
            // selected is selected successfully
            return true;
        }
        // invalid selector specified
        return false;
    }

    // this method makes activeSelector flash (once)
    public bool flashActiveSelector()
    {
        if (activeSelector >= 0 && activeSelector < selectors.GetUpperBound(0) + 1)
        {
            selectors[activeSelector].GetComponent<LevelSelectScript>().flashActive();
            return true;
        }
        return false;
    }

    // this method looks for a spike hit by a finger touch
    public bool getHitSelector(GameObject hitObject, out int selector)
    {
        selector = -1;
        int totalLevels = selectors.GetUpperBound(0) + 1;
        for (int i = 0; i < totalLevels; ++i)
        {
            if (hitObject == selectors[i])
            {
                selector = i;
                return true;
            }
        }
        return false;
    }

    // a daily rotation is performed in FixedUpdate
    // it also checks if it has been idle for selfRotationWaitTime and starts the rotation again
    void FixedUpdate()
    {
		if (rotationEnabled) {
			if (!isRotating)
			{
				if (Time.time - selfRotationStartTime > selfRotationWaitTime)
				{
					isRotating = true;
				}
			}
			if (isRotating)
				transform.Rotate(Vector3.up, rotationDeltaAngle, Space.Self);
		}
    }
}
