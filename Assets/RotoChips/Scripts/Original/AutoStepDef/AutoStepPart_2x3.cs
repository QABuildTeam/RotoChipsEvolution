using UnityEngine;
using System.Collections;

public class AutoStepPart_2x3 : MonoBehaviour
{

	static readonly byte[] solution2x3_0_0_0_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_0_0_1_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_0_0_1_3_path =
	{
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_0_0_2_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_0_0_2_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_0_1_0_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_0_1_0_3_path =
	{
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_0_1_1_0_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_0_1_1_2_path =
	{
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_0_1_2_1_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_0_1_2_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_1_0_1_2_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01
	} ;
	static readonly byte[] solution2x3_1_0_2_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x3_1_0_2_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01
	} ;
	static readonly byte[] solution2x3_1_1_0_0_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x3_1_1_0_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01
	} ;
	static readonly byte[] solution2x3_1_1_1_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x3_1_1_1_3_path =
	{
		(byte)0x01
	} ;
	static readonly byte[] solution2x3_1_1_2_0_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01
	} ;
	static readonly byte[] solution2x3_1_1_2_2_path =
	{
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x3_2_0_2_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01
	} ;
	static readonly byte[] solution2x3_2_1_0_1_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x3_2_1_0_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_2_1_1_0_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_2_1_1_2_path =
	{
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01
	} ;
	static readonly byte[] solution2x3_2_1_2_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_2_1_2_3_path =
	{
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_3_1_0_2_path =
	{
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution2x3_4_1_1_2_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00
	} ;

// Solutions for 2x3 puzzle
	public static readonly solutionPath[] solution2x3 = {
		new solutionPath { tID=0, tY = 0, tX = 0, tA = 2, solution = solution2x3_0_0_0_2_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 1, solution = solution2x3_0_0_1_1_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 3, solution = solution2x3_0_0_1_3_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 0, solution = solution2x3_0_0_2_0_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 2, solution = solution2x3_0_0_2_2_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 1, solution = solution2x3_0_1_0_1_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 3, solution = solution2x3_0_1_0_3_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 0, solution = solution2x3_0_1_1_0_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 2, solution = solution2x3_0_1_1_2_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 1, solution = solution2x3_0_1_2_1_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 3, solution = solution2x3_0_1_2_3_path },
		new solutionPath { tID=1, tY = 0, tX = 1, tA = 2, solution = solution2x3_1_0_1_2_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 1, solution = solution2x3_1_0_2_1_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 3, solution = solution2x3_1_0_2_3_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 0, solution = solution2x3_1_1_0_0_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 2, solution = solution2x3_1_1_0_2_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 1, solution = solution2x3_1_1_1_1_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 3, solution = solution2x3_1_1_1_3_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 0, solution = solution2x3_1_1_2_0_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 2, solution = solution2x3_1_1_2_2_path },
		new solutionPath { tID=2, tY = 0, tX = 2, tA = 2, solution = solution2x3_2_0_2_2_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 1, solution = solution2x3_2_1_0_1_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 3, solution = solution2x3_2_1_0_3_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 0, solution = solution2x3_2_1_1_0_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 2, solution = solution2x3_2_1_1_2_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 1, solution = solution2x3_2_1_2_1_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 3, solution = solution2x3_2_1_2_3_path },
		new solutionPath { tID=3, tY = 1, tX = 0, tA = 2, solution = solution2x3_3_1_0_2_path },
		new solutionPath { tID=4, tY = 1, tX = 1, tA = 2, solution = solution2x3_4_1_1_2_path }
	};

}
