using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class PuzzleButtonScript : MonoBehaviour {

    public AudioClip[] crunchSounds;
    public float pitchLimit;

    GameObject neutralListener;          // an object which listens for the neutral position of a button
    GameObject[] neighbourTiles;        // an array of references to the 4 neighbour tiles of a button
    AudioSource ausrc;
    int AngleIndex;

    // Use this for initialization
    void Start () {
        // initialize the array of references to neighbours
        neighbourTiles = new GameObject[4];
        AngleIndex = 0;
    }

    public int angleIndex()
    {
        return AngleIndex;
    }

    public void setNeutralListener( GameObject aNeutralListener)
    {
        neutralListener = aNeutralListener;
        ausrc = gameObject.GetComponent<AudioSource>();
    }

    public void setNeightbourTiles(GameObject parentObject, GameObject ulTile, GameObject urTile, GameObject lrTile, GameObject llTile)
    {
        unsetNeighbourTiles(parentObject);
        neighbourTiles[0] = ulTile;
        neighbourTiles[1] = urTile;
        neighbourTiles[2] = lrTile;
        neighbourTiles[3] = llTile;
        for (int i = 0; i < 4; i++)
        {
            neighbourTiles[i].transform.SetParent(gameObject.transform);
        }
    }

    public void unsetNeighbourTiles(GameObject parentObject)
    {
        for (int i = 0; i < 4; i++)
        {
            if (neighbourTiles[i] != null)
            {
                neighbourTiles[i].transform.parent = parentObject.transform;
                neighbourTiles[i] = null;
            }
        }
    }

    // this method rotates the button around z-axis according the angleIndex value
    // don't bother about children tiles - they are detached from the button
    // while restoring the state
    public void setAngleIndex(int anAngleIndex)
    {
        int normalizedAngleIndex = anAngleIndex % 4;
        float rotationAngle = (normalizedAngleIndex - AngleIndex) * 90f;
        if (rotationAngle != 0)
        {
            transform.RotateAround(gameObject.transform.position, Vector3.back, rotationAngle);
        }
        AngleIndex = normalizedAngleIndex;
    }

    // --------------- Movement and rotation methods -----------------

    IEnumerator buttonZSlide(float startZ, float endZ, int steps)
    {
        Vector3 deltaZ = new Vector3(0, 0, (endZ - startZ) / steps);    // calculate delta
        Vector3 cp = transform.position;
        // check if the button is inside [startZ;endZ] coordinates
        if ( !((deltaZ.z > 0 && cp.z >= startZ && cp.z <= endZ) || (deltaZ.z < 0 && cp.z <= startZ && cp.z >= endZ)))
        {
            cp.z = startZ;
            // if not set the button into the startZ position
            transform.position = cp;
            yield return new WaitForFixedUpdate();
        }
        for (int i = 0; i < steps; i++)
        {
            // now slide the button along z-axis by deltaZ.z increments
            transform.position += deltaZ;
            yield return new WaitForFixedUpdate();
        }
        if (transform.position.z != endZ)
        {
            cp.z = endZ;
            transform.position = cp;
            yield return new WaitForFixedUpdate();
        }
        //Debug.Log("Button slided");
        neutralListener.SendMessage("buttonSlided");
    }

    // this method rotates a button 90 degree clockwise and notifies neutralListener when finished
    IEnumerator buttonRotate(int rSteps)
    {
        // play the sound
        int si = (int)(UnityEngine.Random.value * (crunchSounds.GetUpperBound(0) + 1));
        float pitch = (float)(UnityEngine.Random.value * pitchLimit);
        ausrc.clip = crunchSounds[si];
        ausrc.pitch += pitch;
        ausrc.Play();
        // and rotate the button
        float rotationAngle = 0;
//        Vector3 point = gameObject.transform.localPosition;
        Vector3 point = gameObject.transform.position;
        if (rSteps > 0)
        {
            float angleDelta = 90f / rSteps;
            //Vector3 point = gameObject.transform.position;
            for (int i = 0; i < rSteps; i++)
            {
                yield return new WaitForFixedUpdate();
                //if (currentState != PuzzleButtonState.pbs_Rotates)
                //    break;
                transform.RotateAround(point, Vector3.back, angleDelta);
                rotationAngle += angleDelta;
            }
        }
        if (rotationAngle != 90f)
        {
            transform.RotateAround(point, Vector3.back, 90f - rotationAngle);
        }
        AngleIndex = (AngleIndex + 1) % 4;
        yield return new WaitForFixedUpdate();
        //Debug.Log("Button rotated");
        neutralListener.SendMessage("buttonRotated");
    }

    // this method starts the button slide
    public void slide(float startZ, float endZ, int stepsCount)
    {
        StartCoroutine(buttonZSlide(startZ, endZ, stepsCount));
    }

    // this method starts the button rotation
    public void rotate90DegreesCW(int stepsCount)
    {
        StartCoroutine(buttonRotate(stepsCount));
    }

}
