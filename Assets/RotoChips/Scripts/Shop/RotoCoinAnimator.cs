/*
 * File:        RotoCoinAnimator.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class RotoCoinAnimator animates RotoCoin icons at the Shop scene
 * Created:     04.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.Shop
{
    public class RotoCoinAnimator : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            StartCoroutine(Animate());
        }

        [Header("Lifting parameters")]
        [SerializeField]
        protected Vector3 liftingAxis=new Vector3(0,-1,0);
        [SerializeField]
        protected float lAmplitude = 0.4f;
        [SerializeField]
        protected float lStartPhase = Mathf.PI / 4;
        [SerializeField]
        protected float lFrequency = 0.5f;
        [Header("Waving parameters")]
        [SerializeField]
        protected Vector3 wavingAxis;
        [SerializeField]
        protected float wAmplitude = 0.2f;
        [SerializeField]
        protected float wStartPhase = 0;
        [SerializeField]
        protected float wFrequency = 0.5f;

        const float TwoPi = Mathf.PI * 2;
        IEnumerator Animate()
        {
            Vector3 zeroPoint = transform.position;
            float lPhase = lStartPhase;
            float wPhase = wStartPhase;
            while (true)
            {
                transform.position = zeroPoint + liftingAxis * Mathf.Cos(lPhase) * lAmplitude;
                transform.Rotate(wavingAxis, Mathf.Cos(wPhase) * wAmplitude, Space.Self);
                yield return null;
                lPhase += Time.deltaTime * lFrequency;
                wPhase += Time.deltaTime * wFrequency;
                if (lPhase > TwoPi)
                {
                    lPhase -= TwoPi;
                }
                if (wPhase >= TwoPi)
                {
                    lPhase -= TwoPi;
                }
            }
        }
    }
}
