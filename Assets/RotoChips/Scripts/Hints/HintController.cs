/*
 * File:        HintController.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class HintController implements general hint logic of the game
 * Created:     19.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;

namespace RotoChips.UI
{

    public class HintParams
    {

    }
    public class HintController : MonoBehaviour
    {

        MessageRegistrator registrator;
        private void Awake()
        {
            registrator = new MessageRegistrator();
            registrator.RegisterHandlers();
            gameObject.SetActive(false);
        }

        // message handling
        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
