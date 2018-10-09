/*
 * File:        LogoSceneScript.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class LogoSceneScript controls the animation sequence on the Logo scene
 * Created:     24.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RotoChips.Management;
using RotoChips.UI;
using RotoChips.Generic;

namespace RotoChips.Logo
{
    public class LogoSceneScript : GenericMessageHandler
    {

        [SerializeField]
        protected GameObject logoStart;
        [SerializeField]
        protected GameObject pad;
        [SerializeField]
        protected GameObject cubeLL;
        [SerializeField]
        protected GameObject cubeLR;
        [SerializeField]
        protected GameObject cubeUL;
        [SerializeField]
        protected GameObject cubeUR;
        [SerializeField]
        protected GameObject coin;
        [SerializeField]
        protected GameObject logoText;
        [SerializeField]
        protected ParticleSystem logoFire;
        [SerializeField]
        protected GameObject startButton;
        [SerializeField]
        protected GameObject startText;
        [SerializeField]
        protected WhiteCurtainFader sceneTransition;
        [SerializeField]
        protected GameObject bgSprite1;
        [SerializeField]
        protected GameObject bgSprite2;
        [SerializeField]
        protected GameObject bgSprite3;

        [SerializeField]
        protected float deltay;
        [SerializeField]
        protected float padWaitSeconds = 1f;
        [SerializeField]
        protected float padY0 = -0.5f;
        [SerializeField]
        protected float cubeLLWaitSeconds = 1f;
        [SerializeField]
        protected float cubeY0 = 0f;
        [SerializeField]
        protected float cubeLRWaitSeconds = 1f;
        [SerializeField]
        protected float cubeULWaitSeconds = 1f;
        [SerializeField]
        protected float cubeURWaitSeconds = 1f;
        [SerializeField]
        protected float coinWaitSeconds = 1f;
        [SerializeField]
        protected float coinY0 = 0.2f;
        [SerializeField]
        protected float logoWaitSeconds = 1f;
        [SerializeField]
        protected Vector3 deltaCamera;
        [SerializeField]
        protected float deltaCameraSeconds;
        [SerializeField]
        protected int deltaCameraSteps;

        [SerializeField]
        protected SFXPlayParams logoStartSFX;
        [SerializeField]
        protected SFXPlayParams padSFX;
        [SerializeField]
        protected SFXPlayParams cubeLLSFX;
        [SerializeField]
        protected SFXPlayParams cubeLRSFX;
        [SerializeField]
        protected SFXPlayParams cubeULSFX;
        [SerializeField]
        protected SFXPlayParams cubeURSFX;
        [SerializeField]
        protected SFXPlayParams coinSFX;
        [SerializeField]
        protected SFXPlayParams fallingSFX;
        [SerializeField]
        protected string NextScene;

        // Use this for initialization
        protected override void AwakeInit()
        {
            registrator.Add(new MessageRegistrationTuple { type = InstantMessageType.GUIWhiteCurtainFaded, handler = OnWhiteCurtainFaded });
        }

        void Start()
        {
            logoText.SetActive(false);
            StartCoroutine(LogoAnimation());
        }

        IEnumerator FallDown(GameObject o, float y0, SFXPlayParams sfx)
        {
            //logoStart.GetComponent<AudioSource>().Play();
            GlobalManager.MAudio.PlaySFX(fallingSFX);
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
            //o.GetComponent<AudioSource>().Play();
            GlobalManager.MAudio.PlaySFX(sfx);
        }

        IEnumerator LogoAnimation()
        {
            yield return new WaitForFixedUpdate();
            // assemble logo parts
            yield return new WaitForSeconds(padWaitSeconds);
            StartCoroutine(FallDown(pad, padY0,padSFX));
            yield return new WaitForSeconds(cubeLLWaitSeconds);
            StartCoroutine(FallDown(cubeLL, cubeY0,cubeLLSFX));
            yield return new WaitForSeconds(cubeLRWaitSeconds);
            StartCoroutine(FallDown(cubeLR, cubeY0,cubeLRSFX));
            yield return new WaitForSeconds(cubeULWaitSeconds);
            StartCoroutine(FallDown(cubeUL, cubeY0,cubeULSFX));
            yield return new WaitForSeconds(cubeURWaitSeconds);
            StartCoroutine(FallDown(cubeUR, cubeY0,cubeURSFX));
            yield return new WaitForSeconds(coinWaitSeconds);
            StartCoroutine(FallDown(coin, coinY0,coinSFX));
            // move camera far from logo
            // the logo itself is moved left and a little up
            yield return new WaitForSeconds(logoWaitSeconds);
            Camera mainCamera = Camera.main;
            for (int i = 0; i < deltaCameraSteps; i++)
            {
                mainCamera.transform.position += deltaCamera;
                yield return new WaitForSeconds(deltaCameraSeconds);
            }
            logoFire.Play();
            //LogoGraphics.SetActive(true);
            // activate next letters
            logoText.SetActive(true);
            GlobalManager.MAudio.PlaySFX(logoStartSFX);
            //gameObject.GetComponent<AudioSource>().Play();
            // start flashing background
            bgSprite1.GetComponent<LogoBackgroundFlasher>().StartFlash();
            bgSprite2.GetComponent<LogoBackgroundFlasher>().StartFlash();
            bgSprite3.GetComponent<LogoBackgroundFlasher>().StartFlash();
            yield return new WaitForSeconds(logoWaitSeconds);
            // activate a "Tap to start" button
            // it will also wait for the very first STRESS image to be ready
            startText.GetComponent<StartTextScript>().StartFlash();
        }

        // InstantMessage handler
        void OnWhiteCurtainFaded(object sender, InstantMessageArgs args)
        {
            bool up = (bool)args.arg;
            if (up)
            {
                if (!string.IsNullOrEmpty(NextScene))
                {
                    SceneManager.LoadScene(NextScene);
                }
            }
        }

        // Button handler
        public void StartButtonPressed()
        {
            if (GlobalManager.Instance != null)
            {
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.GUIFadeWhiteCurtain, this);
            }
        }
    }
}
