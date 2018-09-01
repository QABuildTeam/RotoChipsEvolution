/*
 * File:        WorldSelectorController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WorldSelectorController builds and controls a single level selector above the world globe
 * Created:     30.08.2018
 */
using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.World
{
    [System.Serializable]
    public class SelectorPrefab
    {
        public GameObject prefab;
        public Material opaqueMaterial;
        public Material transparentMaterial;
        public Material glowMaterial;
        public float maximumGlowStrength;
    }

    public class WorldSelectorController : FlashingObject
    {
        protected LevelDataManager.Descriptor levelDescriptor;
        public LevelDataManager.Descriptor LevelDescriptor
        {
            get
            {
                return levelDescriptor;
            }
        }

        [SerializeField]
        protected SpriteRenderer iconRenderer;
        [SerializeField]
        protected GameObject lightBeacon;
        protected MeshRenderer meshRenderer;
        MessageRegistrator registrator;

        public void Init(LevelDataManager.Descriptor descriptor, SelectorPrefab prefab)
        {
            registrator = new MessageRegistrator(InstantMessageType.SteadyMouseUpAsButton, (InstantMessageHandler)OnSteadyMouseUpAsButton);
            registrator.RegisterHandlers();
            levelDescriptor = descriptor;
            meshRenderer = GetComponent<MeshRenderer>();
            if (!levelDescriptor.state.Revealed)
            {
                gameObject.SetActive(false);
            }
            else
            {
                // set up height above the world sphere
                string iconPath = LevelDataManager.GraphicsResource(levelDescriptor.init.id);
                bool glow = false;
                Material[] materials = meshRenderer.materials;
                if (levelDescriptor.state.Playable)
                {
                    iconPath += "/icon";
                    if (levelDescriptor.init.id == GlobalManager.MStorage.SelectedLevel)
                    //if (true)
                    {
                        materials[0] = prefab.glowMaterial;
                        lightBeacon.SetActive(true);
                        glow = true;
                    }
                    else
                    {
                        materials[0] = prefab.opaqueMaterial;
                        lightBeacon.SetActive(false);
                    }
                }
                else
                {
                    materials[0] = prefab.transparentMaterial;
                    iconPath += "/grayicon";
                }
                meshRenderer.materials = materials;
                iconRenderer.sprite = Resources.Load<Sprite>(iconPath);
                //Debug.Log("WSC.Init: loaded #" + levelDescriptor.init.id.ToString() + " sprite from " + iconPath + " as " + (iconRenderer.sprite == null ? "null" : iconRenderer.sprite.ToString()));
                if (glow)
                {
                    StartCoroutine(Flash());
                }
            }
        }

        void OnSteadyMouseUpAsButton(object sender, InstantMessageArgs args)
        {
            if ((GameObject)args.arg == gameObject)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldSelectorPressed, this, levelDescriptor);
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

        protected override void Visualize(float factor)
        {
            Material[] materials = meshRenderer.materials;
            materials[0].SetFloat("_MKGlowTexStrength", factor);
        }
    }
}
