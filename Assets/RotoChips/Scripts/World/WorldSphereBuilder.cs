/*
 * File:        WorldSphereBuilder.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class WorldSphereBuilder builds level selectors and clouds above the world globe on the World scene
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
using RotoChips.Generic;

namespace RotoChips.World
{
    public class WorldSphereBuilder : GenericMessageHandler
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
        [SerializeField]
        protected bool noStatusCheck = false;

        GameObject clouds;
        bool fadeClouds;

        protected override void AwakeInit()
        {
            registrator.Add(new MessageRegistrationTuple { type = InstantMessageType.GUIWhiteCurtainFaded, handler = OnGUIWhiteCurtainFaded });

            fadeClouds = false;

            //EnableRotation(false);                                  // make sure the sphere does not rotate while constructing spikes

            // now construct and set up level selectors
            transform.eulerAngles = new Vector3(0, 0, 0);
            float radius = transform.localScale.x / 2f;             // all radii are aqual
            selectors = new List<GameObject>();                     // a list of selector objects
            Vector3 position = transform.position;
            position.z = -radius;
            GameObject previousSelector = null;     // this one is needed to draw the intercube connector

            Quaternion cloudsRotation = Quaternion.Euler(0, 0, 0);
            bool setClouds = false;
            int visibleSelectors = 0;

            foreach (LevelDataManager.Descriptor descriptor in GlobalManager.MLevel.LevelDescriptors())
            {
                if (noStatusCheck || descriptor.state.Revealed)     // the level is visible on the world map
                {
                    // set initial rotation for the level button
                    Quaternion rotation = Quaternion.Euler(descriptor.init.eulerX, descriptor.init.eulerY, descriptor.init.eulerZ);
                    transform.rotation = rotation;

                    // create and set up a level selector
                    int prefabId = descriptor.init.realmId % selectorPrefabs.Length;
                    SelectorPrefab prefab = selectorPrefabs[prefabId];
                    GameObject selector = (GameObject)Instantiate(prefab.prefab);
                    selectors.Add(selector);
                    RealmData.Init realmData = RealmData.initializers[descriptor.init.realmId];
                    Vector3 newPosition = position + new Vector3(0, 0, (descriptor.init.id == realmData.mainLevelId ? -selectorHeight.max : -selectorHeight.min));
                    selector.transform.position = newPosition;
                    WorldSelectorController wsc = selector.GetComponent<WorldSelectorController>();
                    wsc.Init(descriptor, prefab, noStatusCheck);
                    selector.transform.SetParent(transform);

                    // check for clouds effect
                    if (noStatusCheck || descriptor.state.Playable)
                    {
                        if (descriptor.init.id == realmData.mainLevelId)
                        {
                            setClouds = !noStatusCheck; // if status is not checked, then the clouds are not instatiated at all
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
                    if (descriptor.init.id != realmData.mainLevelId && (noStatusCheck || (descriptor.state.Playable && descriptor.state.Complete)))
                    {
                        if (previousSelector != null)
                        {
                            GameObject connectorLine = (GameObject)Instantiate(ConnectLinePrefab);
                            connectorLine.transform.position = newPosition;
                            connectorLine.transform.SetParent(selector.transform);
                            connectorLine.GetComponent<IntercubeConnectorFlasher>().Init(realmData.connectorColor, previousSelector.transform.position - newPosition);
                        }
                    }
                    Debug.Log("Creating selector " + descriptor.init.id.ToString() + ": revealed=" + descriptor.state.Revealed.ToString() + ", complete=" + descriptor.state.Complete.ToString());
                    previousSelector = selector;
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
        }

        private void Start()
        {
            // special command for the Finale scene
            // if there are no fireworks, the command yields to nothing
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.VictoryStartFireworks, this, selectors);
        }

        // message handling
        void OnGUIWhiteCurtainFaded(object sender, InstantMessageArgs args)
        {
            bool up = (bool)args.arg;
            // fade the clouds if necessary
            if (!up && clouds != null && fadeClouds)
            {
                fadeClouds = false;
                clouds.GetComponent<CloudFader>().FadeOut();
            }
        }

    }
}
