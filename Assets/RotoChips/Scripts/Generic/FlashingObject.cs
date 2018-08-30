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
        protected FloatRange flashRange;    // minimum & maximum values for visual change
        public FloatRange FlashRange
        {
            get
            {
                return flashRange;
            }
            set
            {
                flashRange = value;
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

        protected abstract void Visualize(float factor);      // sets the visuals of the gameObject or its component(s)

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
            // up argument sets the initial direction of visual change:
            // true  - appearance changes from flashRange.min to flashRange.max, using flashDuration.min
            // false - appearance changes from flashRange.max to flashRange.min, using flashDuration.max
            int periodIndex = up ? 0 : 1;
            float startFlash = flashRange[periodIndex];
            float endFlash = flashRange[periodIndex + 1];
            float minFlash = Mathf.Min(startFlash, endFlash);
            float maxFlash = Mathf.Max(startFlash, endFlash);
            float currentTime = 0;
            while (IsValidPeriod(periodIndex))
            {
                Visualize(startFlash);
                float currentFlash = startFlash;
                float duration = flashDuration[periodIndex];
                while (currentTime < duration)
                {
                    yield return null;
                    currentTime += Time.deltaTime;
                    currentFlash = Mathf.Clamp(Mathf.Lerp(startFlash, endFlash, currentTime / duration), minFlash, maxFlash);
                    Visualize(currentFlash);
                }
                Visualize(endFlash);
                PeriodFinished(up);
                up = !up;
                periodIndex = (periodIndex + 1) % 1024; // 1024 is a trick which does not allow periodIndex to become too big
                currentTime -= duration;
                // exchange startFlash and endFlash
                float temp = startFlash;
                startFlash = endFlash;
                endFlash = temp;
            }

        }

        public virtual void StartFlash(bool up = true)
        {
            StartCoroutine(Flash(up));
        }
    }
}
