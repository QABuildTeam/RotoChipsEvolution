using UnityEngine;
using System.Collections;

public class SatelliteScript : MonoBehaviour {

    //Vector3 globalAxis;
    public GameObject listener;

    public float rotationDeltaAngle;
    public float selfRotationWaitTime;
    bool isRotating;
    float selfRotationStartTime;

    // Use this for initialization
    void Start () {
        //globalAxis = new Vector3();
        //globalAxis = Vector3.up + Vector3.right;
        stopRotation();
    }

    public void stopRotation()
    {
        isRotating = false;
        selfRotationStartTime = Time.time;
    }

    IEnumerator flashSelected()
    {
        yield return new WaitForFixedUpdate();
        listener.SendMessage("satelliteFlashed");
    }

    public void flashSelector()
    {
        StartCoroutine(flashSelected());
    }

    void FixedUpdate()
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
