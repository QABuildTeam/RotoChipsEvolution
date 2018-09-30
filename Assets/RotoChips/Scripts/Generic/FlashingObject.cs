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
        protected virtual bool IsValidPeriod(int periodCounter)
        {
            return true;
        }

        // this method is called upon the end of each period
        protected virtual void PeriodFinished(bool up)
        {
        }

        protected Coroutine currentFlash;
        protected IEnumerator Flash(bool up = true)
        {
            // up argument sets the initial direction of visual change:
            // true  - appearance changes from flashRange.min to flashRange.max, using flashDuration.min
            // false - appearance changes from flashRange.max to flashRange.min, using flashDuration.max
            int periodHalf = up ? 0 : 1;
            float startFlash = flashRange[periodHalf];
            float endFlash = flashRange[periodHalf + 1];
            float minFlash = Mathf.Min(startFlash, endFlash);
            float maxFlash = Mathf.Max(startFlash, endFlash);
            int periodCounter = 0;
            float currentTime = 0;
            while (IsValidPeriod(periodCounter))
            {
                Visualize(startFlash);
                float currentFlash = startFlash;
                float duration = flashDuration[periodHalf];
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
                periodHalf = up ? 0 : 1;
                periodCounter = (periodCounter + 1) % 1024; // 1024 is a trick which does not allow periodCounter to become too big
                currentTime -= duration;
                // exchange startFlash and endFlash
                float temp = startFlash;
                startFlash = endFlash;
                endFlash = temp;
            }
            currentFlash = null;
        }

        public virtual void StartFlash(bool up = true)
        {
            if (currentFlash != null)
            {
                StopCoroutine(currentFlash);
            }
            currentFlash = StartCoroutine(Flash(up));
        }

    }
}
