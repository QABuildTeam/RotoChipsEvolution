using UnityEngine;
using System.Collections;

public class CameraRotationScript : MonoBehaviour {

    public float rotationDeltaAngle;
    Vector3 rotationAxis;

    private void Start()
    {
        rotationAxis = Vector3.left + Vector3.back;
    }

    void FixedUpdate()
    {
        transform.Rotate(rotationAxis, rotationDeltaAngle, Space.Self);
    }

}
