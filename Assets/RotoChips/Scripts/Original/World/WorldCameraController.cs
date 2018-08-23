using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCameraController : MonoBehaviour {

    public float cameraMaxDistance;
    public float cameraMinDistance;
    public int cameraStepsCount;
    public float scaleFactor = (float)0.01;         // a factor for finger scaling
    public GameObject listener;

    void Awake()
    {
        // do nothing
    }

    public void manualZoom(Vector3 cameraMove)
    {
		if (cameraMove.z != 0)  // that is, a vertical movement is required
        {
            Vector3 cameraPosition = Camera.main.transform.position;
            string notifierMessage = "";
			float dz = cameraMove.z * cameraPosition.z * scaleFactor;   // positive to zoom in, negative to zoom out
            bool isAtMin = (cameraPosition.z == cameraMinDistance);
            if (dz > 0 && cameraPosition.z > cameraMaxDistance)
            {
                cameraPosition.z -= dz;
            } else if (dz < 0 && cameraPosition.z < cameraMinDistance)
            {
                cameraPosition.z -= dz;
            }
            else
            {
                return;
            }
            if (cameraPosition.z < cameraMaxDistance)
            {
                cameraPosition.z = cameraMaxDistance;
                notifierMessage = "cameraMovedDown";
            }
            else if (cameraPosition.z > cameraMinDistance)
            {
                cameraPosition.z = cameraMinDistance;
                notifierMessage = "cameraMovedUp";
            }
            if (isAtMin && cameraPosition.z < cameraMinDistance)
            {
                notifierMessage = "cameraMovedDown";
            }
            // camera should be moved by += operator, not simply position.Set method
            Camera.main.transform.position += (cameraPosition - Camera.main.transform.position);
            if (notifierMessage != "")
            {
                listener.SendMessage(notifierMessage);
            }
        }
    }
    // this method performs the camera movement (up or doen, between cameraMaxDistance (far from the world) and cameraMinDistance (near the world))
    IEnumerator moveCamera(bool up)
    {
        Vector3 cameraPosition = Camera.main.transform.position;
        float delta = (cameraMaxDistance - cameraMinDistance) / cameraStepsCount;
        if (up)
        {
            delta = -delta;
        }
        int stepsCount = (int)((cameraPosition.z - cameraMinDistance) / (cameraMaxDistance - cameraMinDistance) * (float)cameraStepsCount);
        if (stepsCount == 0 && !up)
        {
            stepsCount = cameraStepsCount;
        }
        for(int i = 0; i < stepsCount; i++)
        {
            yield return new WaitForFixedUpdate();
            cameraPosition.z += delta;
            Camera.main.transform.position = cameraPosition;
        }
        cameraPosition.z = up ? cameraMinDistance : cameraMaxDistance;
        yield return new WaitForFixedUpdate();
        Camera.main.transform.position = cameraPosition;
        listener.SendMessage(up ? "cameraMovedUp" : "cameraMovedDown");
    }

    // this method starts the camera movement
    public void pMoveCamera(bool up)
    {
        StartCoroutine(moveCamera(up));
    }
}
