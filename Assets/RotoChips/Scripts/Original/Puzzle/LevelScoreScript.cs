using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// this class implements a self-rolling score text (level score, total score, and total RotoCoins)
// all three types are implemented by decimal numbers
public class LevelScoreScript : MonoBehaviour
{

    public Color normalColor;
    public Color purchaseColor;
    public int rollSteps = 10;
    public float rollTime = 1f;
    public bool CheckAgainstAutoStepPrice = false;
    decimal previousScore;

    Queue<decimal> scoreQueue;

    bool isRolling;

    void Awake()
    {
        scoreQueue = new Queue<decimal>();
        previousScore = 0M;
        isRolling = false;
    }

    // these are public methods for setting a new score
    public void setScoreText(decimal score)
    {
        if (gameObject.activeInHierarchy)
        {
            scoreQueue.Enqueue(score);
            if (!isRolling)
            {
                isRolling = true;
                StartCoroutine(rollDigits());
            }
        }
    }

    public void setScoreText(long score)
    {
        setScoreText((decimal)score);
    }

    IEnumerator rollDigits()
    {
        while (scoreQueue.Count > 0)
        {
            decimal newScore = scoreQueue.Dequeue();
            //Debug.Log("Set new score " + newScore.ToString());
            // do not roll digits if the score has not been changed
            if (newScore != previousScore)
            {
                Text t = GetComponent<Text>();
                decimal deltaScore = (newScore - previousScore) / rollSteps;
                float deltaTime = rollTime / rollSteps;
                for (int i = 0; i < rollSteps; i++)
                {
                    //Debug.Log("delta score = " + deltaScore.ToString() + ", decimal score:" + previousScoreDecimal.ToString());
                    decimal currentScore = previousScore;
                    t.text = Decimal.Round(currentScore, 0).ToString();
                    previousScore += deltaScore;
                    yield return new WaitForSeconds(deltaTime);
                }
                t.text = Decimal.Round(newScore, 0).ToString();
                t.color = normalColor;
                if (CheckAgainstAutoStepPrice)
                {
                    /*
                    if (newScore >= Purchases.AutoStepPrice)
                    {
                        t.color = purchaseColor;
                    }
                    */
                }
                previousScore = newScore;
            }
        }
        isRolling = false;
    }
}
