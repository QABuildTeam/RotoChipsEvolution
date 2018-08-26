using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RotoChips.Management;
using RotoChips.UI;

namespace RotoChips.Logo
{
    public class LogoSceneScript : MonoBehaviour
    {

        public GameObject LogoStart;
        public GameObject Pad;
        public GameObject CubeLL;
        public GameObject CubeLR;
        public GameObject CubeUL;
        public GameObject CubeUR;
        public GameObject Coin;
        //public Light LogoLight;
        public GameObject LogoText;
        public ParticleSystem LogoFire;
        public GameObject StartButton;
        public GameObject StartText;
        //public GameObject LogoGraphics;
        public WhiteCurtainFader SceneTransition;
        public GameObject BGSprite1;
        public GameObject BGSprite2;
        public GameObject BGSprite3;

        public float deltay;
        public float PadWaitSeconds = 1f;
        public float PadY0 = -0.5f;
        public float CubeLLWaitSeconds = 1f;
        public float CubeY0 = 0f;
        public float CubeLRWaitSeconds = 1f;
        public float CubeULWaitSeconds = 1f;
        public float CubeURWaitSeconds = 1f;
        public float CoinWaitSeconds = 1f;
        public float CoinY0 = 0.2f;
        public float LogoWaitSeconds = 1f;
        public Vector3 deltaCamera;
        public float deltaCameraSeconds;
        public int deltaCameraSteps;

        public string NextScene;

        // Use this for initialization
        void Start()
        {
            //Physics.gravity = new Vector3(0, -1f, 0);
            LogoText.SetActive(false);
            StartButton.SetActive(false);
            //StartText.SetActive(false);
            RegisterHandlers();
            StartCoroutine(LogoAnimation());
        }

        IEnumerator FallDown(GameObject o, float y0)
        {
            LogoStart.GetComponent<AudioSource>().Play();
            Vector3 v = o.transform.position;
            while (v.y > y0)
            {
                yield return new WaitForFixedUpdate();
                v.y -= deltay;
                o.transform.position = v;
            }
            v.y = y0;
            o.transform.position = v;
            yield return new WaitForFixedUpdate();
            o.GetComponent<AudioSource>().Play();
        }

        IEnumerator LogoAnimation()
        {
            yield return new WaitForFixedUpdate();
            // assemble logo parts
            yield return new WaitForSeconds(PadWaitSeconds);
            StartCoroutine(FallDown(Pad, PadY0));
            yield return new WaitForSeconds(CubeLLWaitSeconds);
            StartCoroutine(FallDown(CubeLL, CubeY0));
            yield return new WaitForSeconds(CubeLRWaitSeconds);
            StartCoroutine(FallDown(CubeLR, CubeY0));
            yield return new WaitForSeconds(CubeULWaitSeconds);
            StartCoroutine(FallDown(CubeUL, CubeY0));
            yield return new WaitForSeconds(CubeURWaitSeconds);
            StartCoroutine(FallDown(CubeUR, CubeY0));
            yield return new WaitForSeconds(CoinWaitSeconds);
            StartCoroutine(FallDown(Coin, CoinY0));
            // move camera far from logo
            // the logo itself is moved left and a little up
            yield return new WaitForSeconds(LogoWaitSeconds);
            Camera mainCamera = Camera.main;
            for (int i = 0; i < deltaCameraSteps; i++)
            {
                mainCamera.transform.position += deltaCamera;
                yield return new WaitForSeconds(deltaCameraSeconds);
            }
            LogoFire.Play();
            //LogoGraphics.SetActive(true);
            // activate next letters
            LogoText.SetActive(true);
            gameObject.GetComponent<AudioSource>().Play();
            // start flashing background
            BGSprite1.GetComponent<LogoBackgroundFlasher>().StartFlash();
            BGSprite2.GetComponent<LogoBackgroundFlasher>().StartFlash();
            BGSprite3.GetComponent<LogoBackgroundFlasher>().StartFlash();
            yield return new WaitForSeconds(LogoWaitSeconds);
            // activate a "Tap to start" button
            // it will also wait for the very first STRESS image to be ready
            //StartButton.SetActive(true);
            StartText.GetComponent<StartTextScript>().StartFlash();
        }

        void RegisterHandlers()
        {
            if (GlobalManager.Instance != null)
            {
                GlobalManager.Instance.MInstantMessage.AddListener(InstantMessageType.GUIWhiteCurtainFaded, OnWhiteCurtainFaded);
            }
        }

        void UnregisterHandlers()
        {
            if (GlobalManager.Instance != null)
            {
                GlobalManager.Instance.MInstantMessage.RemoveListener(InstantMessageType.GUIWhiteCurtainFaded, OnWhiteCurtainFaded);
            }
        }

        // InstantMessage handler
        void OnWhiteCurtainFaded(object sender, InstantMessageManager.InstantMessageArgs args)
        {
            bool up = (bool)args.arg;
            if (up)
            {
                UnregisterHandlers();
                if (!string.IsNullOrEmpty(NextScene))
                {
                    SceneManager.LoadScene(NextScene);
                }
            }
        }

        // Button handler
        public void StartButtonPressed()
        {
            if (SceneTransition != null)
            {
                SceneTransition.FadeOut();
            }
        }
    }
}
