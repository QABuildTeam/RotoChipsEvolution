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
using UnityEngine.EventSystems;
using RotoChips.Management;
using RotoChips.Data;
using RotoChips.Utility;

namespace RotoChips.World
{
    public class WorldSphereBuilder : MonoBehaviour
    {

        // prefabs
        [SerializeField]
        protected GameObject cloudsPrefab;
        [SerializeField]
        protected SelectorPrefab[] selectorPrefabs;
        List<GameObject> selectors;
        [SerializeField]
        protected FloatRange selectorHeight;
        [SerializeField]
        protected GameObject ConnectLinePrefab;

        // this method constructs the level selection objects on the world sphere
        void Awake()
        {
            GameObject clouds;
            bool fadeClouds = false;

            //EnableRotation(false);                                  // make sure the sphere does not rotate while constructing spikes

            // now construct and set up level selectors
            transform.eulerAngles = new Vector3(0, 0, 0);
            float radius = transform.localScale.x / 2f;             // all radii are aqual
            selectors = new List<GameObject>();                     // a list of selector objects
            Vector3 position = transform.position;
            position.z = -radius;
            Vector3 previousPosition = position;

            Quaternion cloudsRotation = Quaternion.Euler(0, 0, 0);
            bool setClouds = false;
            int visibleSelectors = 0;

            foreach (LevelDataManager.Descriptor descriptor in GlobalManager.MLevel.LevelDescriptors())
            {
                //if (descriptor.state.Revealed)     // the level is visible on the world map
                {
                    //Debug.Log("WSB.Start: Creating selector #" + descriptor.init.id.ToString());
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
                if (fadeClouds)
                {
                    clouds.GetComponent<CloudFader>().FadeOut();
                }
            }
            // set the world sphere to the initial position
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

    }
}
