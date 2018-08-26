/*
 * File:        Run.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class Run starts the game
 * Created:     25.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RotoChips.Management;

namespace RotoChips
{
    public class Run : MonoBehaviour
    {

        public string startSceneName = "Logo";
        // Use this for initialization
        IEnumerator Start()
        {
            while (!GlobalManager.Instance.Initialized)
            {
                yield return null;
            }
            SceneManager.LoadScene(startSceneName);
        }

    }
}
