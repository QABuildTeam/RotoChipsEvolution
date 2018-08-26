/*
 * File:        FlashingObject.cs
 * Author:      Igor Spiridonov
 * Descrpition: Abstract class FlashingObject implements a generic GameObject which can flash (periodically change its transparency)
 * Created:     26.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Utility;

namespace RotoChips.Generic
{
    public abstract class FlashingObject : MonoBehaviour
    {
        [SerializeField]
        protected FloatRange alphaRange;    // minimum & maximum values for alpha
        public FloatRange AlphaRange
        {
            get
            {
                return alphaRange;
            }
            set
            {
                alphaRange = value;
            }
        }

        [SerializeField]
        protected FloatRange flashDuration; // up (minimum) & down (maximum) flashing periods
        public FloatRange FlashDuration
        {
            get
            {
                return flashDuration;
            }
            set
            {
                flashDuration = value;
            }
        }

        protected abstract void SetAlpha(float alpha);      // sets the transparency of the gameObject or its component(s)

        // this method defines which flashing period is valid
        protected virtual bool IsValidPeriod(int periodIndex)
        {
            return true;
        }

        // this method is called upon the end of each period
        protected virtual void PeriodFinished(bool up)
        {
        }

        protected IEnumerator Flash(bool up = true)
        {
            // up argument sets the initial direction of transparency change:
            // true  - transparency changes from alphaRange.min to alphaRange.max, using flashDuration.min
            // false - transparency changes from alphaRange.max to alphaRange.min, using flashDuration.max
            int periodIndex = up ? 0 : 1;
            float startAlpha = alphaRange[periodIndex];
            float endAlpha = alphaRange[periodIndex + 1];
            float minAlpha = Mathf.Min(startAlpha, endAlpha);
            float maxAlpha = Mathf.Max(startAlpha, endAlpha);
            while (IsValidPeriod(periodIndex))
            {
                SetAlpha(startAlpha);
                float alpha = startAlpha;
                float currentTime = 0;
                float duration = flashDuration[periodIndex];
                while (currentTime < duration)
                {
                    yield return null;
                    currentTime += Time.deltaTime;
                    alpha = Mathf.Clamp(Mathf.Lerp(startAlpha, endAlpha, currentTime / duration), minAlpha, maxAlpha);
                    SetAlpha(alpha);
                }
                SetAlpha(endAlpha);
                PeriodFinished(up);
                up = !up;
                periodIndex = (periodIndex + 1) % 1024; // 1024 is a trick which does not allow periodIndex to become too big
                // exchange startAlpha and endAlpha
                float temp = startAlpha;
                startAlpha = endAlpha;
                endAlpha = temp;
            }

        }

        public virtual void StartFlash(bool up = true)
        {
            StartCoroutine(Flash(up));
        }
    }
}
