using UnityEngine;
using System.Collections;

public class AutoStepPart_5x2 : MonoBehaviour
{

	static readonly byte[] solution5x2_0_0_0_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_0_1_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_0_1_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_1_0_1_path =
	{
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_1_0_3_path =
	{
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_1_1_0_path =
	{
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_1_1_2_path =
	{
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_2_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_2_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_2_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_3_1_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_3_1_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_4_0_0_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00,
		(byte)0x30
	} ;
	static readonly byte[] solution5x2_0_4_0_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x10,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x2_0_4_1_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_0_4_1_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_0_1_2_path =
	{
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_1_0_0_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_1_1_1_path =
	{
		(byte)0x10,
		(byte)0x00,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_1_1_3_path =
	{
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_2_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_2_0_3_path =
	{
		(byte)0x00,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_2_1_0_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_2_1_2_path =
	{
		(byte)0x00,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_3_0_2_path =
	{
		(byte)0x00,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_3_1_1_path =
	{
		(byte)0x00,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_3_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_4_0_1_path =
	{
		(byte)0x00,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_4_0_3_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_4_1_0_path =
	{
		(byte)0x00,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_1_4_1_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x2_2_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_1_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_1_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_2_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_2_0_3_path =
	{
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_2_1_0_path =
	{
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_2_1_2_path =
	{
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_3_1_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_3_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_4_0_1_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_4_0_3_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_4_1_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_2_4_1_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_3_1_1_2_path =
	{
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_3_2_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_3_2_0_2_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_3_2_1_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_3_2_1_3_path =
	{
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_3_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_3_3_0_3_path =
	{
		(byte)0x10,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_3_3_1_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_3_3_1_2_path =
	{
		(byte)0x10,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_3_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_3_4_0_2_path =
	{
		(byte)0x10,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_3_4_1_1_path =
	{
		(byte)0x10,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_3_4_1_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x2_4_2_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_4_2_1_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_4_2_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_4_3_0_1_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_4_3_0_3_path =
	{
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_4_3_1_0_path =
	{
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_4_3_1_2_path =
	{
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_4_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_4_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_4_4_1_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_4_4_1_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_5_2_1_2_path =
	{
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_5_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_5_3_0_2_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_5_3_1_1_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_5_3_1_3_path =
	{
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_5_4_0_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_5_4_0_3_path =
	{
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_5_4_1_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_5_4_1_2_path =
	{
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_6_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30
	} ;
	static readonly byte[] solution5x2_6_3_1_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x2_6_3_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_6_4_0_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_6_4_0_3_path =
	{
		(byte)0x30
	} ;
	static readonly byte[] solution5x2_6_4_1_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_6_4_1_2_path =
	{
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x2_7_3_1_2_path =
	{
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x2_7_4_0_0_path =
	{
		(byte)0x10,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30
	} ;
	static readonly byte[] solution5x2_7_4_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_7_4_1_1_path =
	{
		(byte)0x10,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_7_4_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x2_8_4_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x2_8_4_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x2_8_4_1_3_path =
	{
		(byte)0x10,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x20,
		(byte)0x30
	} ;

// Solutions for 5x2 puzzle
	public static readonly solutionPath[] solution5x2 = {
		new solutionPath { tID=0, tY = 0, tX = 0, tA = 2, solution = solution5x2_0_0_0_2_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 1, solution = solution5x2_0_0_1_1_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 3, solution = solution5x2_0_0_1_3_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 1, solution = solution5x2_0_1_0_1_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 3, solution = solution5x2_0_1_0_3_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 0, solution = solution5x2_0_1_1_0_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 2, solution = solution5x2_0_1_1_2_path },
		new solutionPath { tID=0, tY = 2, tX = 0, tA = 0, solution = solution5x2_0_2_0_0_path },
		new solutionPath { tID=0, tY = 2, tX = 0, tA = 2, solution = solution5x2_0_2_0_2_path },
		new solutionPath { tID=0, tY = 2, tX = 1, tA = 1, solution = solution5x2_0_2_1_1_path },
		new solutionPath { tID=0, tY = 2, tX = 1, tA = 3, solution = solution5x2_0_2_1_3_path },
		new solutionPath { tID=0, tY = 3, tX = 0, tA = 1, solution = solution5x2_0_3_0_1_path },
		new solutionPath { tID=0, tY = 3, tX = 0, tA = 3, solution = solution5x2_0_3_0_3_path },
		new solutionPath { tID=0, tY = 3, tX = 1, tA = 0, solution = solution5x2_0_3_1_0_path },
		new solutionPath { tID=0, tY = 3, tX = 1, tA = 2, solution = solution5x2_0_3_1_2_path },
		new solutionPath { tID=0, tY = 4, tX = 0, tA = 0, solution = solution5x2_0_4_0_0_path },
		new solutionPath { tID=0, tY = 4, tX = 0, tA = 2, solution = solution5x2_0_4_0_2_path },
		new solutionPath { tID=0, tY = 4, tX = 1, tA = 1, solution = solution5x2_0_4_1_1_path },
		new solutionPath { tID=0, tY = 4, tX = 1, tA = 3, solution = solution5x2_0_4_1_3_path },
		new solutionPath { tID=1, tY = 0, tX = 1, tA = 2, solution = solution5x2_1_0_1_2_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 0, solution = solution5x2_1_1_0_0_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 2, solution = solution5x2_1_1_0_2_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 1, solution = solution5x2_1_1_1_1_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 3, solution = solution5x2_1_1_1_3_path },
		new solutionPath { tID=1, tY = 2, tX = 0, tA = 1, solution = solution5x2_1_2_0_1_path },
		new solutionPath { tID=1, tY = 2, tX = 0, tA = 3, solution = solution5x2_1_2_0_3_path },
		new solutionPath { tID=1, tY = 2, tX = 1, tA = 0, solution = solution5x2_1_2_1_0_path },
		new solutionPath { tID=1, tY = 2, tX = 1, tA = 2, solution = solution5x2_1_2_1_2_path },
		new solutionPath { tID=1, tY = 3, tX = 0, tA = 0, solution = solution5x2_1_3_0_0_path },
		new solutionPath { tID=1, tY = 3, tX = 0, tA = 2, solution = solution5x2_1_3_0_2_path },
		new solutionPath { tID=1, tY = 3, tX = 1, tA = 1, solution = solution5x2_1_3_1_1_path },
		new solutionPath { tID=1, tY = 3, tX = 1, tA = 3, solution = solution5x2_1_3_1_3_path },
		new solutionPath { tID=1, tY = 4, tX = 0, tA = 1, solution = solution5x2_1_4_0_1_path },
		new solutionPath { tID=1, tY = 4, tX = 0, tA = 3, solution = solution5x2_1_4_0_3_path },
		new solutionPath { tID=1, tY = 4, tX = 1, tA = 0, solution = solution5x2_1_4_1_0_path },
		new solutionPath { tID=1, tY = 4, tX = 1, tA = 2, solution = solution5x2_1_4_1_2_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 2, solution = solution5x2_2_1_0_2_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 1, solution = solution5x2_2_1_1_1_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 3, solution = solution5x2_2_1_1_3_path },
		new solutionPath { tID=2, tY = 2, tX = 0, tA = 1, solution = solution5x2_2_2_0_1_path },
		new solutionPath { tID=2, tY = 2, tX = 0, tA = 3, solution = solution5x2_2_2_0_3_path },
		new solutionPath { tID=2, tY = 2, tX = 1, tA = 0, solution = solution5x2_2_2_1_0_path },
		new solutionPath { tID=2, tY = 2, tX = 1, tA = 2, solution = solution5x2_2_2_1_2_path },
		new solutionPath { tID=2, tY = 3, tX = 0, tA = 0, solution = solution5x2_2_3_0_0_path },
		new solutionPath { tID=2, tY = 3, tX = 0, tA = 2, solution = solution5x2_2_3_0_2_path },
		new solutionPath { tID=2, tY = 3, tX = 1, tA = 1, solution = solution5x2_2_3_1_1_path },
		new solutionPath { tID=2, tY = 3, tX = 1, tA = 3, solution = solution5x2_2_3_1_3_path },
		new solutionPath { tID=2, tY = 4, tX = 0, tA = 1, solution = solution5x2_2_4_0_1_path },
		new solutionPath { tID=2, tY = 4, tX = 0, tA = 3, solution = solution5x2_2_4_0_3_path },
		new solutionPath { tID=2, tY = 4, tX = 1, tA = 0, solution = solution5x2_2_4_1_0_path },
		new solutionPath { tID=2, tY = 4, tX = 1, tA = 2, solution = solution5x2_2_4_1_2_path },
		new solutionPath { tID=3, tY = 1, tX = 1, tA = 2, solution = solution5x2_3_1_1_2_path },
		new solutionPath { tID=3, tY = 2, tX = 0, tA = 0, solution = solution5x2_3_2_0_0_path },
		new solutionPath { tID=3, tY = 2, tX = 0, tA = 2, solution = solution5x2_3_2_0_2_path },
		new solutionPath { tID=3, tY = 2, tX = 1, tA = 1, solution = solution5x2_3_2_1_1_path },
		new solutionPath { tID=3, tY = 2, tX = 1, tA = 3, solution = solution5x2_3_2_1_3_path },
		new solutionPath { tID=3, tY = 3, tX = 0, tA = 1, solution = solution5x2_3_3_0_1_path },
		new solutionPath { tID=3, tY = 3, tX = 0, tA = 3, solution = solution5x2_3_3_0_3_path },
		new solutionPath { tID=3, tY = 3, tX = 1, tA = 0, solution = solution5x2_3_3_1_0_path },
		new solutionPath { tID=3, tY = 3, tX = 1, tA = 2, solution = solution5x2_3_3_1_2_path },
		new solutionPath { tID=3, tY = 4, tX = 0, tA = 0, solution = solution5x2_3_4_0_0_path },
		new solutionPath { tID=3, tY = 4, tX = 0, tA = 2, solution = solution5x2_3_4_0_2_path },
		new solutionPath { tID=3, tY = 4, tX = 1, tA = 1, solution = solution5x2_3_4_1_1_path },
		new solutionPath { tID=3, tY = 4, tX = 1, tA = 3, solution = solution5x2_3_4_1_3_path },
		new solutionPath { tID=4, tY = 2, tX = 0, tA = 2, solution = solution5x2_4_2_0_2_path },
		new solutionPath { tID=4, tY = 2, tX = 1, tA = 1, solution = solution5x2_4_2_1_1_path },
		new solutionPath { tID=4, tY = 2, tX = 1, tA = 3, solution = solution5x2_4_2_1_3_path },
		new solutionPath { tID=4, tY = 3, tX = 0, tA = 1, solution = solution5x2_4_3_0_1_path },
		new solutionPath { tID=4, tY = 3, tX = 0, tA = 3, solution = solution5x2_4_3_0_3_path },
		new solutionPath { tID=4, tY = 3, tX = 1, tA = 0, solution = solution5x2_4_3_1_0_path },
		new solutionPath { tID=4, tY = 3, tX = 1, tA = 2, solution = solution5x2_4_3_1_2_path },
		new solutionPath { tID=4, tY = 4, tX = 0, tA = 0, solution = solution5x2_4_4_0_0_path },
		new solutionPath { tID=4, tY = 4, tX = 0, tA = 2, solution = solution5x2_4_4_0_2_path },
		new solutionPath { tID=4, tY = 4, tX = 1, tA = 1, solution = solution5x2_4_4_1_1_path },
		new solutionPath { tID=4, tY = 4, tX = 1, tA = 3, solution = solution5x2_4_4_1_3_path },
		new solutionPath { tID=5, tY = 2, tX = 1, tA = 2, solution = solution5x2_5_2_1_2_path },
		new solutionPath { tID=5, tY = 3, tX = 0, tA = 0, solution = solution5x2_5_3_0_0_path },
		new solutionPath { tID=5, tY = 3, tX = 0, tA = 2, solution = solution5x2_5_3_0_2_path },
		new solutionPath { tID=5, tY = 3, tX = 1, tA = 1, solution = solution5x2_5_3_1_1_path },
		new solutionPath { tID=5, tY = 3, tX = 1, tA = 3, solution = solution5x2_5_3_1_3_path },
		new solutionPath { tID=5, tY = 4, tX = 0, tA = 1, solution = solution5x2_5_4_0_1_path },
		new solutionPath { tID=5, tY = 4, tX = 0, tA = 3, solution = solution5x2_5_4_0_3_path },
		new solutionPath { tID=5, tY = 4, tX = 1, tA = 0, solution = solution5x2_5_4_1_0_path },
		new solutionPath { tID=5, tY = 4, tX = 1, tA = 2, solution = solution5x2_5_4_1_2_path },
		new solutionPath { tID=6, tY = 3, tX = 0, tA = 2, solution = solution5x2_6_3_0_2_path },
		new solutionPath { tID=6, tY = 3, tX = 1, tA = 1, solution = solution5x2_6_3_1_1_path },
		new solutionPath { tID=6, tY = 3, tX = 1, tA = 3, solution = solution5x2_6_3_1_3_path },
		new solutionPath { tID=6, tY = 4, tX = 0, tA = 1, solution = solution5x2_6_4_0_1_path },
		new solutionPath { tID=6, tY = 4, tX = 0, tA = 3, solution = solution5x2_6_4_0_3_path },
		new solutionPath { tID=6, tY = 4, tX = 1, tA = 0, solution = solution5x2_6_4_1_0_path },
		new solutionPath { tID=6, tY = 4, tX = 1, tA = 2, solution = solution5x2_6_4_1_2_path },
		new solutionPath { tID=7, tY = 3, tX = 1, tA = 2, solution = solution5x2_7_3_1_2_path },
		new solutionPath { tID=7, tY = 4, tX = 0, tA = 0, solution = solution5x2_7_4_0_0_path },
		new solutionPath { tID=7, tY = 4, tX = 0, tA = 2, solution = solution5x2_7_4_0_2_path },
		new solutionPath { tID=7, tY = 4, tX = 1, tA = 1, solution = solution5x2_7_4_1_1_path },
		new solutionPath { tID=7, tY = 4, tX = 1, tA = 3, solution = solution5x2_7_4_1_3_path },
		new solutionPath { tID=8, tY = 4, tX = 0, tA = 2, solution = solution5x2_8_4_0_2_path },
		new solutionPath { tID=8, tY = 4, tX = 1, tA = 1, solution = solution5x2_8_4_1_1_path },
		new solutionPath { tID=8, tY = 4, tX = 1, tA = 3, solution = solution5x2_8_4_1_3_path }
	};

}
