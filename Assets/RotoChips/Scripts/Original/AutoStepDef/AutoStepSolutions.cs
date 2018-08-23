using UnityEngine;
using System.Collections;

public class AutoStepSolutions : MonoBehaviour
{
	static readonly solutionArray[] allSolutions = {
		new solutionArray { height=2, width=3, solutions=AutoStepPart_2x3.solution2x3 },
		new solutionArray { height=2, width=4, solutions=AutoStepPart_2x4.solution2x4 },
		new solutionArray { height=2, width=5, solutions=AutoStepPart_2x5.solution2x5 },
		new solutionArray { height=2, width=6, solutions=AutoStepPart_2x6.solution2x6 },
		new solutionArray { height=3, width=2, solutions=AutoStepPart_3x2.solution3x2 },
		new solutionArray { height=3, width=3, solutions=AutoStepPart_3x3.solution3x3 },
		new solutionArray { height=3, width=4, solutions=AutoStepPart_3x4.solution3x4 },
		new solutionArray { height=3, width=5, solutions=AutoStepPart_3x5.solution3x5 },
		new solutionArray { height=3, width=6, solutions=AutoStepPart_3x6.solution3x6 },
		new solutionArray { height=4, width=2, solutions=AutoStepPart_4x2.solution4x2 },
		new solutionArray { height=4, width=3, solutions=AutoStepPart_4x3.solution4x3 },
		new solutionArray { height=4, width=4, solutions=AutoStepPart_4x4.solution4x4 },
		new solutionArray { height=4, width=5, solutions=AutoStepPart_4x5.solution4x5 },
		new solutionArray { height=4, width=6, solutions=AutoStepPart_4x6.solution4x6 },
		new solutionArray { height=5, width=2, solutions=AutoStepPart_5x2.solution5x2 },
		new solutionArray { height=5, width=3, solutions=AutoStepPart_5x3.solution5x3 },
		new solutionArray { height=5, width=4, solutions=AutoStepPart_5x4.solution5x4 },
		new solutionArray { height=5, width=5, solutions=AutoStepPart_5x5.solution5x5 },
		new solutionArray { height=5, width=6, solutions=AutoStepPart_5x6.solution5x6 },
		new solutionArray { height=6, width=2, solutions=AutoStepPart_6x2.solution6x2 },
		new solutionArray { height=6, width=3, solutions=AutoStepPart_6x3.solution6x3 },
		new solutionArray { height=6, width=4, solutions=AutoStepPart_6x4.solution6x4 },
		new solutionArray { height=6, width=5, solutions=AutoStepPart_6x5.solution6x5 },
		new solutionArray { height=6, width=6, solutions=AutoStepPart_6x6.solution6x6 }
	};

	public static AutoStepSolutions instance;
	// Use this for initialization
	void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}
		//DontDestroyOnLoad(gameObject);
	}

	public byte[] getSolution(int mHeight, int mWidth, int tID, int tY, int tX, int tA)
	{
		for (int i = 0; i < allSolutions.Length; i++)
		{
			if (allSolutions[i].height == mHeight && allSolutions[i].width == mWidth)
			{
				for (int j = 0; j < allSolutions[i].solutions.Length; j++)
				{
					if (allSolutions[i].solutions[j].tID == tID &&
					    allSolutions[i].solutions[j].tY == tY &&
					    allSolutions[i].solutions[j].tX == tX &&
					    allSolutions[i].solutions[j].tA == tA)
					{
						//Debug.Log("Found solution for tile (" + mHeight.ToString() + "x" + mWidth.ToString() + ":" + tID.ToString() + "," + tY.ToString() + "," + tX.ToString() + "," + tA.ToString() + ")");
						return allSolutions[i].solutions[j].solution;
					}
				}
			}
		}
		//Debug.Log("No solution for tile (" + mHeight.ToString() + "x" + mWidth.ToString() + ":" + tID.ToString() + "," + tY.ToString() + "," + tX.ToString() + "," + tA.ToString() + ")");
		return null;
	}
}
