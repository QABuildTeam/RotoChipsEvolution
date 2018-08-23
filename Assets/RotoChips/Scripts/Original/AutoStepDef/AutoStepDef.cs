using UnityEngine;
using System.Collections;

public struct solutionPath
{
	public int tID, tY, tX, tA;
	public byte[] solution;
};
public struct solutionArray
{
	public int height, width;
	public solutionPath[] solutions;
};
