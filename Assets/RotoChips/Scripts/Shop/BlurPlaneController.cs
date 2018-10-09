/*
 * File:        BlurPlaneController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class BlurPlaneController controls the BlurPlane appearance at the Shop scene
 * Created:     06.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.Shop
{
    public class BlurPlaneController : MonoBehaviour
    {

        [SerializeField]
        protected Texture2D texture;
        [SerializeField]
        protected Vector2 textureDimensions;

        private void Awake()
        {
            texture = GlobalManager.MScreenshot.BlurTexture;
            textureDimensions = new Vector2(texture.width, texture.height);

            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            Material[] materials = meshRenderer.materials;
            materials[0].mainTexture = texture;
            meshRenderer.materials = materials;

            BoxCollider boxCollider = GetComponent<BoxCollider>();
            Vector3 planeSize = boxCollider.bounds.size;
            Debug.Log("Plane size is " + planeSize.ToString());

            Camera mainCamera = Camera.main;
            Vector3 cameraDistance = transform.position - mainCamera.transform.position;
            float screenHeight = Screen.height;
            float screenAspect = mainCamera.aspect;
            float fov = mainCamera.fieldOfView;

            float textureHeight = textureDimensions.y;
            float textureAspect = textureDimensions.x / textureDimensions.y;

            Vector3 localScale = Vector3.one;
            float halfPlaneHeight = Mathf.Abs(cameraDistance.z) * Mathf.Tan(Mathf.Deg2Rad * fov / 2);
            float halfPlaneWidth = halfPlaneHeight * textureAspect;
            localScale.z = 2 * halfPlaneHeight / transform.localScale.z / planeSize.y;
            localScale.x = 2 * halfPlaneWidth / transform.localScale.x / planeSize.x;
            Debug.Log("localScale is " + localScale.ToString());
            transform.localScale = localScale;
        }

    }
}
