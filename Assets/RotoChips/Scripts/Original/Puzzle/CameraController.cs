using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;
using RotoChips.Data;

public class CameraController : MonoBehaviour {
	// this class controls the puzzle scene camera
	const float eps = 0.001f;						// floating-point zero
    int PuzzleWidth;                                // puzzle width in tiles
    int PuzzleHeight;                               // puzzle height in tiles

    public float TileSize = 2.0f;                   // == 2.0f
    public float moveFactor = (float)-0.0007;       // a factor for finger moving
    public float scaleFactor = (float)0.01;         // a factor for finger scaling

    public float screenMargin = 0.25f;              // a clear margin between puzzle border and screen border
    float minCameraDistance;                        // minimum (farthest) vertical camera distance from the tile array
    float maxCameraDistance;                        // maximum (nearest) vertical camera distance from the tile array
    float screenAspectRatio;                        // screen aspect ratio: width/height
    float fovFactor;                                // = Mathf.Tan(Camera.main.fieldOfView * Mathf.PI / (180 * 2))
    private Vector3 llc,                            // lower left corner of the game field and its screen version
                    urc;                            // upper right corner of the game field and its screen version

    // Use this for initialization
    void Start () {
		LevelDataManager.Descriptor ld = GlobalManager.MLevel.GetLevelDescriptor(GlobalManager.MStorage.SelectedLevel);	// load player state for current level
        PuzzleHeight = ld.init.height;
        PuzzleWidth = ld.init.width;

		//set up PuzzleCamera
        screenAspectRatio = (float)(Screen.width) / (float)(Screen.height);
        fovFactor = Mathf.Tan(Camera.main.fieldOfView * Mathf.PI / (180 * 2));
        // as soon as all distances are negative:
        // maxCameraDistance is the nearest point of the camera to the puzzle
        maxCameraDistance = -(TileSize + screenMargin) / (2 * fovFactor);
        // minCameraDistance is the farthest point of the camera to the puzzle
        minCameraDistance = -(Mathf.Max(TileSize * PuzzleHeight + screenMargin, TileSize * PuzzleWidth / screenAspectRatio + screenMargin)) / (2 * fovFactor);
        // simple "position.Set" doesn't work for unknown reason
        Camera.main.transform.position.Set(0f, 0f, 0f);
        Camera.main.transform.position += new Vector3(0f, 0f, minCameraDistance);
        // now calculate the corners of the game field
        llc = new Vector3(-PuzzleWidth * TileSize / 2 + screenMargin, -PuzzleHeight * TileSize / 2 + screenMargin, 0);
        urc = new Vector3(PuzzleWidth * TileSize / 2 - screenMargin, PuzzleHeight * TileSize / 2 - screenMargin, 0);

    }

	// this method moves the main camera in 3d-space, keeping the puzzle in its field of view
	public void KeepSoftBoundaries(Vector3 moveCamera)
	{
		Vector3 cameraPosition = Camera.main.transform.position;
		if (Mathf.Abs(moveCamera.z) > eps)  // that is, a vertical movement is required
		{
			cameraPosition.z += moveCamera.z * Mathf.Abs(cameraPosition.z) * scaleFactor;
			if (cameraPosition.z > maxCameraDistance)
			{
				cameraPosition.z = maxCameraDistance;
			}
			else if (cameraPosition.z < minCameraDistance)
			{
				cameraPosition.z = minCameraDistance;
				cameraPosition.x = cameraPosition.y = 0f;
				// camera should be moved by += operator, not simply position.Set method
				Camera.main.transform.position += (cameraPosition - Camera.main.transform.position);
				// this is the topmost position, so no further calculations are needed
				return;
			}
		}
		// camera should be moved in a direction which is opposite to finger dragging, i. e. be a negative of the latter value
		// but since its z-component is already negative, the finger dragging should be added to the current horizontal camera position raher than subtracted from it
		float zMove = cameraPosition.z * moveFactor;
		cameraPosition.x += moveCamera.x * zMove;
		cameraPosition.y += moveCamera.y * zMove;
		float zyDelta = cameraPosition.z * fovFactor; // this one is negative
		float zxDelta = zyDelta * screenAspectRatio;
		float upperBorder = -zyDelta + cameraPosition.y;
		float lowerBorder = zyDelta + cameraPosition.y;
		float rightBorder = -zxDelta + cameraPosition.x;
		float leftBorder = zxDelta + cameraPosition.x;
		// -2 * zMove is screen height

		//Debug.Log("zxDelta=" + zxDelta.ToString() + ",zyDelta=" + zyDelta.ToString() + ",urc=" + urc.ToString() + ",llc=" + llc.ToString());
		//float dy = -2 * zyDelta - (urc.y - llc.y);
		//float dx = -2 * zxDelta - (urc.x - llc.x);
		//Debug.Log("dx=" + dx.ToString() + ",dy=" + dy.ToString());

		if ((-2 * zyDelta) >= urc.y - llc.y)
		{
			cameraPosition.y = 0;
		}
		else
		{
			if (upperBorder > urc.y)
			{
				cameraPosition.y = urc.y + zyDelta;
			}
			if (lowerBorder < llc.y)
			{
				cameraPosition.y = llc.y - zyDelta;
			}
		}
		if (-2 * zxDelta >= urc.x - llc.x)
		{
			cameraPosition.x = 0;
		}
		else
		{
			if (rightBorder > urc.x)
			{
				cameraPosition.x = urc.x + zxDelta;
			}
			if (leftBorder < llc.x)
			{
				cameraPosition.x = llc.x - zxDelta;
			}
		}
		Camera.main.transform.position += (cameraPosition - Camera.main.transform.position);
	}
}
