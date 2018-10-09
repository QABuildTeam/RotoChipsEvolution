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
using RotoChips.UI;

namespace RotoChips.World
{
    [System.Serializable]
    public class SelectorPrefab
    {
        public GameObject prefab;
        public Material opaqueMaterial;
        public Material transparentMaterial;
        public Material glowMaterial;
        public float maximumGlowPower;
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

        protected override void AwakeInit()
        {
            registrator.Add(
                new MessageRegistrationTuple { type = InstantMessageType.GUIObjectPressedAsButton, handler = OnGUIObjectPressedAsButton },
                new MessageRegistrationTuple { type = InstantMessageType.WorldRotateToSelected, handler = OnWorldRotateToSelected },
                new MessageRegistrationTuple { type = InstantMessageType.RedirectFirstTimeWelcome2, handler = OnRedirectFirstTimeWelcome2 }
            );
        }

        public void Init(LevelDataManager.Descriptor descriptor, SelectorPrefab prefab, bool noStatusCheck = false)
        {
            levelDescriptor = descriptor;
            meshRenderer = GetComponent<MeshRenderer>();
            lightBeacon.SetActive(false);
            if (noStatusCheck || levelDescriptor.state.Revealed)
            {
                // set up height above the world sphere
                string iconPath = LevelDataManager.GraphicsResource(levelDescriptor.init.id);
                bool glow = false;
                Material[] materials = meshRenderer.materials;
                if (noStatusCheck)
                {
                    iconPath += "/icon";
                    materials[0] = prefab.opaqueMaterial;
                }
                else
                if (levelDescriptor.state.Playable)
                {
                    iconPath += "/icon";
                    if (levelDescriptor.init.id == GlobalManager.MStorage.SelectedLevel)
                    {
                        materials[0] = prefab.glowMaterial;
                        lightBeacon.SetActive(true);
                        glow = true;
                    }
                    else
                    {
                        materials[0] = prefab.opaqueMaterial;
                    }
                }
                else
                {
                    iconPath += "/grayicon";
                    materials[0] = prefab.transparentMaterial;
                }
                meshRenderer.materials = materials;
                iconRenderer.sprite = Resources.Load<Sprite>(iconPath);
                if (glow)
                {
                    StartFlash();
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }

        // the selector is touched and released once (no moving)
        void OnGUIObjectPressedAsButton(object sender, InstantMessageArgs args)
        {
            if (gameObject.activeInHierarchy && (GameObject)args.arg == gameObject)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldSelectorPressed, this, levelDescriptor);
            }
        }

        // special message, only received at the start of the World scene
        void OnWorldRotateToSelected(object sender, InstantMessageArgs args)
        {
            if (gameObject.activeInHierarchy && GlobalManager.MStorage.SelectedLevel == levelDescriptor.init.id)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldSelectorPressed, this, levelDescriptor);
            }
        }

        // special message, only received on the cery first start of the World scene
        void OnRedirectFirstTimeWelcome2(object sender, InstantMessageArgs args)
        {
            if (gameObject.activeInHierarchy && GlobalManager.MStorage.SelectedLevel == levelDescriptor.init.id)
            {
                GlobalManager.MHint.ShowNewHint(HintType.FirstTimeWelcome2, gameObject);
            }
        }

        protected override void Visualize(float factor)
        {
            Material[] materials = meshRenderer.materials;
            //materials[0].SetFloat("_MKGlowTexStrength", factor);
            materials[0].SetFloat("_MKGlowPower", factor);
        }
    }
}
