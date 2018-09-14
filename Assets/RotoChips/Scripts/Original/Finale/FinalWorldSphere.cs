using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

public class FinalWorldSphere : MonoBehaviour {
    public GameObject[] levelSelectSpikePrefab;
    //public Material[] levelSpikePrefabTransparentMaterial;
    //GameObject[] selectors;
    List<GameObject> selectors;

    int cameraPhase;
    public float spikeSize;
    public int cameraStepsCount;

    public float rotationDeltaAngle;
    public float selfRotationWaitTime;
    bool rotationEnabled;
    bool isRotating;
    float selfRotationStartTime;

    public GameObject FinalFireworks;
	public GameObject StopButton;

    // Use this for initialization
    void Start () {
        // this method constructs the level selection objects on the world sphere
        // using levelSelectSpikePrefab

        // get the PlayerStat object
        // now construct and set up level selectors
        disableRotation();     // make sure the sphere does not rotate while constructing spikes
        transform.eulerAngles = new Vector3(0, 0, 0);
        float radius = transform.localScale.x / 2f;     // all radii are equal
        //selectors = new GameObject[LevelData.instance.Count];	// an array of selector objects
        selectors = new List<GameObject>();
        Vector3 position = new Vector3(0f, 0f, -radius);
        position += gameObject.transform.position;      // this is a point on the world sphere raight before the player's eyes
		// iterate through levels
		int i = 0;	// selectors indexs
        foreach (LevelDataManager.Descriptor ld in GlobalManager.MLevel.LevelDescriptors())
		//foreach (LevelData.Descriptor ld in new LevelData.Enumerator())
		{
			// set initial rotation for the level button
			Quaternion r = Quaternion.Euler(ld.init.eulerX, ld.init.eulerY, ld.init.eulerZ);
			transform.rotation = r;

			// create and set up a level selection button/spike
			int prefabId = ld.init.realmId % (levelSelectSpikePrefab.GetUpperBound(0) + 1);
			selectors[i] = (GameObject)Instantiate(levelSelectSpikePrefab[prefabId]);     // a new level selection button/spike
			//LevelSelectScript s = selectors[i].GetComponent<LevelSelectScript>();
			selectors[i].transform.position = Vector3.zero;
			//s.setHeight(spikeSize);                                             // set the spike height
			selectors[i].transform.position += position;                        // move it the nearest to player point
			selectors[i].transform.position += new Vector3(0, 0, ld.init.selectHeight > spikeSize ? -ld.init.selectHeight : -spikeSize);

			//string IconPath = ld.GraphicsResource + "/icon";
            string IconPath = LevelDataManager.GraphicsResource(ld.init.id) + "/icon";
            selectors[i].GetComponentInChildren<SpriteRenderer>().sprite = Resources.Load<Sprite>(IconPath);    // set the spike icon
			//s.LevelId = ld.init.id;                                             // set the spike level id
			selectors[i].SetActive(true);                                       // activate it
			selectors[i].transform.SetParent(transform);                        // link the spike to the world sphere

			//s.setEnabled(true);
			i++;
		}
        // set the world sphere to the initial position
        transform.rotation = Quaternion.Euler(0, 0, 0);
        enableRotation();
        FinalFireworks.GetComponent<FinalFireworksScript>().startFireworks(selectors);
		// if the final scene is shown right after the last level has been complete
		// then the user has to watch full text roll sequence
		// otherwise, he/she can tap the stop button at any time
		//StopButton.SetActive(!(bool)AppData.instance[AppData.Storage.GameFinished]);
		// now the GameFinished flag may be reset
		//AppData.instance[AppData.Storage.GameFinished] = false;
    }

    // this method stops the axial rotation of the world sphere
    // it wil start the rotation again itself after selfRotationWaitTime seconds
    public void stopRotation()
    {
        isRotating = false;
        selfRotationStartTime = Time.time;
    }

    public void enableRotation()
    {
        rotationEnabled = true;
        stopRotation();
    }

    public void disableRotation()
    {
        rotationEnabled = false;
    }

    // a daily rotation is performed in FixedUpdate
    // it also checks if it has been idle for selfRotationWaitTime and starts the rotation again
    void FixedUpdate()
    {
        if (rotationEnabled)
        {
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
