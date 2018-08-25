using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;

namespace RotoChips.Logo
{
    public class StartTextScript : MonoBehaviour
    {

        public int flashSteps = 5;
        public float flashPeriod = 0.5f;
        public string loadingTextKey = "Loading";
        public string tapToStartTextKey = "Tap to start";
        public GameObject parentButton;

        // Use this for initialization
        void Start()
        {
            GetComponent<Text>().text = GlobalManager.Instance.MLanguage.Entry(loadingTextKey);
            parentButton.GetComponent<Button>().interactable = false;
            parentButton.SetActive(false);
            //gameObject.SetActive(false);
        }

        IEnumerator runFlashing()
        {
            Text t = GetComponent<Text>();
            Color c = t.color;
            float deltaTime = flashPeriod / flashSteps;
            float deltaColor = 1.0f / flashSteps;
            c.a = 0;
            t.color = c;
            while (true)
            {
                for (int i = 0; i < flashSteps; i++)
                {
                    c.a += deltaColor;
                    t.color = c;
                    yield return new WaitForSeconds(deltaTime);
                }
                c.a = 1.0f;
                t.color = c;
                yield return new WaitForSeconds(deltaTime);
                for (int i = 0; i < flashSteps; i++)
                {
                    c.a -= deltaColor;
                    t.color = c;
                    yield return new WaitForSeconds(deltaTime);
                }
                c.a = 0f;
                t.color = c;
                yield return new WaitForSeconds(deltaTime);
            }
        }

        IEnumerator makeButtonInteractable()
        {
            while (!GlobalManager.Instance.MImage.HasFinalImage(0))
            {
                yield return null;
            }
            GetComponent<Text>().text = GlobalManager.Instance.MLanguage.Entry(tapToStartTextKey);
            parentButton.GetComponent<Button>().interactable = true;
        }

        public void runActiveText()
        {
            parentButton.SetActive(true);
            StartCoroutine(runFlashing());
            StartCoroutine(makeButtonInteractable());
        }

    }
}
