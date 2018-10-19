/*
 * File:        HintArrowBouncer.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class HintArrowBouncer controls bouncing of a hint arrow
 * Created:     13.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Generic;

namespace RotoChips.UI
{
    public class HintArrowBouncer : FlashingObject
    {
        [SerializeField]
        protected float bouncingDistance = 10f;
        [SerializeField]
        protected int bouncingTimes = 2;
        [SerializeField]
        protected float pauseTime = 2f;

        RectTransform rectTransform;
        // GenericMessageHandler overrides
        protected override void AwakeInit()
        {
            rectTransform = GetComponent<RectTransform>();
        }

        // FlashingObject overrides
        protected override void Visualize(float factor)
        {
            Vector3 eulerAngles = rectTransform.localRotation.eulerAngles;
            float rotationAngle = Mathf.Deg2Rad * eulerAngles.z;
            Vector3 originalPosition = rectTransform.position;
            float currentBouncingDistance = bouncingDistance * factor;
            Vector3 bounceDelta = new Vector3(Mathf.Sin(rotationAngle), Mathf.Cos(rotationAngle), 0) * currentBouncingDistance;
            rectTransform.position = originalPosition + bounceDelta;
        }

        Coroutine pauseCoroutine = null;
        protected override bool IsValidPeriod(int periodCounter)
        {
            if (periodCounter < bouncingTimes * 2)
            {
                return true;
            }
            else
            {
                pauseCoroutine = StartCoroutine(PauseBetweenBounces());
                return false;
            }
        }

        IEnumerator PauseBetweenBounces()
        {
            yield return new WaitForSeconds(pauseTime);
            StartFlash();
            pauseCoroutine = null;
        }

        private void OnEnable()
        {
            StartFlash();
        }

        private void OnDisable()
        {
            StopFlash();
            if (pauseCoroutine != null)
            {
                StopCoroutine(pauseCoroutine);
            }
        }
    }
}
