/*
 * File:        UIDecimalIndicatorRoller.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class UIDecimalIndicatorRoller implements rolling digital indicator
 * Created:     01.09.2018
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;

namespace RotoChips.Generic
{
    public abstract class UIDecimalIndicatorRoller : UIIndicatorController
    {
        Text controlledText;
        Text ControlledText
        {
            get
            {
                if (controlledText == null)
                {
                    controlledText = GetComponent<Text>();
                }
                return controlledText;
            }
        }

        protected abstract decimal SourceValue(InstantMessageArgs args);    // gets the source value and converts it into a decimal
        protected abstract Color TargetColor(decimal value);                // gets a color for the value

        protected override void UpdateIndicator(object sender, InstantMessageArgs args)
        {
            SetScoreText(SourceValue(args));
        }

        public int rollSteps = 10;
        public float rollTime = 1f;

        decimal previousScore = 0m;
        Queue<decimal> scoreQueue = new Queue<decimal>();
        bool isRolling = false;

        // these are public methods for setting a new score
        protected void SetScoreText(decimal score)
        {
            if (gameObject.activeInHierarchy)
            {
                scoreQueue.Enqueue(score);
                if (!isRolling)
                {
                    isRolling = true;
                    StartCoroutine(RollDigits());
                }
            }
            else
            {
                previousScore = score;
            }
        }

        IEnumerator RollDigits()
        {
            while (scoreQueue.Count > 0)
            {
                decimal newScore = scoreQueue.Dequeue();
                //Debug.Log("Set new score " + newScore.ToString());
                // do not roll digits if the score has not been changed
                if (newScore != previousScore)
                {
                    decimal deltaScore = (newScore - previousScore) / rollSteps;
                    float deltaTime = rollTime / rollSteps;
                    for (int i = 0; i < rollSteps; i++)
                    {
                        //Debug.Log("delta score = " + deltaScore.ToString() + ", decimal score:" + previousScore.ToString());
                        decimal currentScore = previousScore;
                        ControlledText.text = Decimal.Round(currentScore, 0).ToString();
                        previousScore += deltaScore;
                        yield return new WaitForSeconds(deltaTime);
                    }
                    ControlledText.text = Decimal.Round(newScore, 0).ToString();
                    ControlledText.color = TargetColor(newScore);
                    previousScore = newScore;
                }
            }
            isRolling = false;
        }

    }
}
