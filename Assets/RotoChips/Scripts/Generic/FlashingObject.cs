/*
 * File:        FlashingObject.cs
 * Author:      Igor Spiridonov
 * Descrpition: Abstract class FlashingObject implements a generic GameObject which can flash (periodically change its transparency)
 *              It also inherits a message handling capability from its base class, GenericMessageHandler
 * Created:     26.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Utility;

namespace RotoChips.Generic
{
    public abstract class FlashingObject : GenericMessageHandler
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
            float startFlashFactor = flashRange[periodHalf];
            float endFlashFactor = flashRange[periodHalf + 1];
            float minFlashFactor = Mathf.Min(startFlashFactor, endFlashFactor);
            float maxFlashFactor = Mathf.Max(startFlashFactor, endFlashFactor);
            int periodCounter = 0;
            float currentTime = 0;
            while (IsValidPeriod(periodCounter))
            {
                Visualize(startFlashFactor);
                float currentFlashFactor = startFlashFactor;
                float duration = flashDuration[periodHalf];
                while (currentTime < duration)
                {
                    yield return null;
                    currentTime += Time.deltaTime;
                    currentFlashFactor = Mathf.Clamp(Mathf.Lerp(startFlashFactor, endFlashFactor, currentTime / duration), minFlashFactor, maxFlashFactor);
                    Visualize(currentFlashFactor);
                }
                Visualize(endFlashFactor);
                PeriodFinished(up);
                up = !up;
                periodHalf = up ? 0 : 1;
                periodCounter = (periodCounter + 1) % 1024; // 1024 is a trick which does not allow periodCounter to become too big
                currentTime -= duration;
                // exchange startFlash and endFlash
                float temp = startFlashFactor;
                startFlashFactor = endFlashFactor;
                endFlashFactor = temp;
            }
            currentFlash = null;
        }

        public virtual void StopFlash()
        {
            if (currentFlash != null)
            {
                StopCoroutine(currentFlash);
                currentFlash = null;
            }
        }

        public virtual void StartFlash(bool up = true)
        {
            StopFlash();
            currentFlash = StartCoroutine(Flash(up));
        }

    }
}
