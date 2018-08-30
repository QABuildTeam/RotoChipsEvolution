/*
 * File:        WorldSphereBuilder.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WorldSphereBuilder builds level selectors and clouds above the world globe
 *              It also controls daily rotation of the world globe
 * Created:     30.08.2018
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;
using RotoChips.Data;
using RotoChips.Utility;

namespace RotoChips.World
{
    public class WorldSphereBuilder : MonoBehaviour
    {

        public float rotationDeltaAngle;
        public float selfRotationWaitTime;

        bool rotationEnabled;
        bool isRotating;
        float selfRotationStartTime;

        GameObject clouds;
        bool fadeClouds;

        // prefabs
        [SerializeField]
        protected GameObject cloudsPrefab;
        [SerializeField]
        protected SelectorPrefab[] selectorPrefabs;
        List<GameObject> selectors;
        [SerializeField]
        protected FloatRange selectorHeight;

        public GameObject ConnectLinePrefab;


        int activeSelector;
        int levelSelector;
        int gallerySelector;

        int cameraPhase;
        public int cameraStepsCount;

        public GameObject worldListener;

        // this method constructs the level selection objects on the world sphere
        void Awake()
        {
            RegisterHandlers();
            fadeClouds = false;
            EnableRotation(false);                                  // make sure the sphere does not rotate while constructing spikes

            // now construct and set up level selectors
            transform.eulerAngles = new Vector3(0, 0, 0);
            float radius = transform.localScale.x / 2f;             // all radii are aqual
            selectors = new List<GameObject>();                     // a list of selector objects
            Vector3 position = transform.position;
            position.z = -radius;
            Vector3 previousPosition = position;

            activeSelector = -1;
            gallerySelector = -1;
            Quaternion cloudsRotation = Quaternion.Euler(0, 0, 0);
            bool setClouds = false;
            int visibleSelectors = 0;

            int i = 0;  // a selectors index
            foreach (LevelDataManager.Descriptor descriptor in GlobalManager.MLevel.LevelDescriptors())
            {
                //if (descriptor.state.Revealed)     // the level is visible on the world map
                {
                    // set initial rotation for the level button
                    Quaternion rotation = Quaternion.Euler(descriptor.init.eulerX, descriptor.init.eulerY, descriptor.init.eulerZ);
                    transform.rotation = rotation;

                    // create and set up a level selector
                    int prefabId = descriptor.init.realmId % selectorPrefabs.Length;
                    SelectorPrefab prefab = selectorPrefabs[prefabId];
                    GameObject selector = (GameObject)Instantiate(prefab.prefab);
                    selectors.Add(selector);
                    RealmData.Init ri = RealmData.initializers[descriptor.init.realmId];
                    Vector3 newPosition = position + new Vector3(0, 0, (descriptor.init.id == ri.mainLevelId ? -selectorHeight.max : -selectorHeight.min));
                    selector.transform.position = newPosition;
                    WorldSelectorController wss = selector.GetComponent<WorldSelectorController>();
                    wss.Init(descriptor, prefab);
                    selector.transform.SetParent(transform);

                    // check for clouds effect
                    if (descriptor.state.Playable)
                    {
                        if (descriptor.init.id == ri.mainLevelId)
                        {
                            setClouds = true;
                            cloudsRotation = rotation;
                            visibleSelectors = 0;
                        }
                        else
                        {
                            if (setClouds)
                            {
                                visibleSelectors++;
                            }
                        }
                    }

                    // now try to connect current selector with the previous one using glowing lines
                    if (descriptor.state.Playable && descriptor.state.Complete && descriptor.init.id != ri.mainLevelId)
                    {
                        GameObject connectorLine = (GameObject)Instantiate(ConnectLinePrefab);
                        connectorLine.transform.position = newPosition;
                        connectorLine.transform.SetParent(selector.transform);
                        connectorLine.GetComponent<IntercubeConnectorFlasher>().Init(ri.connectorColor, previousPosition - newPosition);
                    }
                    previousPosition = newPosition;
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
                transform.rotation = cloudsRotation;
                clouds = (GameObject)Instantiate(cloudsPrefab);
                clouds.transform.SetParent(transform);
            }
            // set the world sphere to the initial position
            transform.rotation = Quaternion.Euler(0, 0, 0);
            // let the rotation go
            EnableRotation(true);
        }

        public bool cloudsFading()
        {
            return fadeClouds;
        }

        public void fadeCloudsDown()
        {
            fadeClouds = false;
            clouds.GetComponent<CloudFader>().FadeOut();
        }

        // this method starts rotation of the world sphere to place a selected selector before the player's eyes
        public void rotateToSelected()
        {
            if (activeSelector >= 0 && activeSelector < selectors.Count)
            {
                StartCoroutine(RotateToSphereZero(selectors[activeSelector]));
            }
        }

        // this method starts rotation of the world sphere to place an object right before the player's eyes
        public void rotateToObject(GameObject o)
        {
            StartCoroutine(RotateToSphereZero(o));
        }

        // and this method performs such a rotation
        IEnumerator RotateToSphereZero(GameObject rotateTarget)
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
        public void StopRotation()
        {
            isRotating = false;
            selfRotationStartTime = Time.time;
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
                LevelDataManager.Descriptor ld = GlobalManager.MLevel.GetLevelDescriptor(levelId);
                Playable = ld.state.Playable;
                Complete = ld.state.Complete;
            }
        }

        // returns the level id assigned to a selector
        public int getSelectorLevel(int selector)
        {
            if (selector >= 0 && selector < selectors.Count)
            {
                //return selectors[selector].GetComponent<WorldSelectorController>().LevelId;
            }
            return -1;
        }

        // this auxillary method sets or resets selection status
        void setLevelSelection(int selector, bool on)
        {
            WorldSelectorController lss = selectors[selector].GetComponent<WorldSelectorController>();
            //lss.setSelected(on);
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
            if (selector >= 0 && selector < selectors.Count)
            {
                if (selector != activeSelector)
                {
                    if (activeSelector >= 0 && activeSelector < selectors.Count)
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

        // this method looks for a spike hit by a finger touch
        public bool getHitSelector(GameObject hitObject, out int selector)
        {
            selector = -1;
            int totalLevels = selectors.Count;
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

        void EnableRotation(bool on)
        {
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.WorldRotationEnable, this, on);
        }

        // message handling
        void OnWorldRotationEnable(object sender, InstantMessageManager.InstantMessageArgs args)
        {
            rotationEnabled = (bool)args.arg;
            if (!rotationEnabled)
            {
                StopRotation();
            }
        }

        void RegisterHandlers()
        {
            GlobalManager.MInstantMessage.AddListener(InstantMessageType.WorldRotationEnable, OnWorldRotationEnable);
        }

        void UnregisterHandlers()
        {
            GlobalManager.MInstantMessage.RemoveListener(InstantMessageType.WorldRotationEnable, OnWorldRotationEnable);
        }

        private void OnDestroy()
        {
            UnregisterHandlers();
        }
    }
}
