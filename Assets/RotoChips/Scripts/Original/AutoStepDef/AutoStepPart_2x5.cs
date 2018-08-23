using UnityEngine;
using System.Collections;

public class AutoStepPart_2x5 : MonoBehaviour
{

	static readonly byte[] solution2x5_0_0_0_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_0_1_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_0_1_3_path =
	{
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_0_2_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_0_2_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_0_3_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_0_3_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_0_4_0_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_0_4_2_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_1_0_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_1_0_3_path =
	{
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_1_1_0_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_1_1_2_path =
	{
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_1_2_1_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_1_2_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_1_3_0_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_1_3_2_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_1_4_1_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_0_1_4_3_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_1_0_1_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_0_2_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_0_2_3_path =
	{
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_0_3_0_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_0_3_2_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_0_4_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_0_4_3_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_1_0_0_path =
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
	static readonly byte[] solution2x5_1_1_0_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_1_1_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_1_1_3_path =
	{
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_1_2_0_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_1_2_2_path =
	{
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_1_3_1_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_1_3_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_1_4_0_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_1_1_4_2_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_2_0_2_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_2_0_3_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_2_0_3_3_path =
	{
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_2_0_4_0_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_2_0_4_2_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_2_1_0_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_2_1_0_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_2_1_1_0_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_2_1_1_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_2_1_2_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_2_1_2_3_path =
	{
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_2_1_3_0_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_2_1_3_2_path =
	{
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_2_1_4_1_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_2_1_4_3_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_3_0_3_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_3_0_4_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_3_0_4_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_3_1_0_0_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution2x5_3_1_0_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_3_1_1_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_3_1_1_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_3_1_2_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_3_1_2_2_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_3_1_3_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_3_1_3_3_path =
	{
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_3_1_4_0_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_3_1_4_2_path =
	{
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_4_0_4_2_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_4_1_0_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_4_1_0_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_4_1_1_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_4_1_1_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_4_1_2_1_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_4_1_2_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_4_1_3_0_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_4_1_3_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_4_1_4_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_4_1_4_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_5_1_0_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_5_1_1_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_5_1_1_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_5_1_2_0_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_5_1_2_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_5_1_3_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_5_1_3_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_5_1_4_0_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_5_1_4_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_6_1_1_2_path =
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
	static readonly byte[] solution2x5_6_1_2_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_6_1_2_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_6_1_3_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_6_1_3_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_6_1_4_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_6_1_4_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_7_1_2_2_path =
	{
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_7_1_3_1_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution2x5_7_1_3_3_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_7_1_4_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution2x5_7_1_4_2_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_8_1_3_2_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_8_1_4_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution2x5_8_1_4_3_path =
	{
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03
	} ;

// Solutions for 2x5 puzzle
	public static readonly solutionPath[] solution2x5 = {
		new solutionPath { tID=0, tY = 0, tX = 0, tA = 2, solution = solution2x5_0_0_0_2_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 1, solution = solution2x5_0_0_1_1_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 3, solution = solution2x5_0_0_1_3_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 0, solution = solution2x5_0_0_2_0_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 2, solution = solution2x5_0_0_2_2_path },
		new solutionPath { tID=0, tY = 0, tX = 3, tA = 1, solution = solution2x5_0_0_3_1_path },
		new solutionPath { tID=0, tY = 0, tX = 3, tA = 3, solution = solution2x5_0_0_3_3_path },
		new solutionPath { tID=0, tY = 0, tX = 4, tA = 0, solution = solution2x5_0_0_4_0_path },
		new solutionPath { tID=0, tY = 0, tX = 4, tA = 2, solution = solution2x5_0_0_4_2_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 1, solution = solution2x5_0_1_0_1_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 3, solution = solution2x5_0_1_0_3_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 0, solution = solution2x5_0_1_1_0_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 2, solution = solution2x5_0_1_1_2_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 1, solution = solution2x5_0_1_2_1_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 3, solution = solution2x5_0_1_2_3_path },
		new solutionPath { tID=0, tY = 1, tX = 3, tA = 0, solution = solution2x5_0_1_3_0_path },
		new solutionPath { tID=0, tY = 1, tX = 3, tA = 2, solution = solution2x5_0_1_3_2_path },
		new solutionPath { tID=0, tY = 1, tX = 4, tA = 1, solution = solution2x5_0_1_4_1_path },
		new solutionPath { tID=0, tY = 1, tX = 4, tA = 3, solution = solution2x5_0_1_4_3_path },
		new solutionPath { tID=1, tY = 0, tX = 1, tA = 2, solution = solution2x5_1_0_1_2_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 1, solution = solution2x5_1_0_2_1_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 3, solution = solution2x5_1_0_2_3_path },
		new solutionPath { tID=1, tY = 0, tX = 3, tA = 0, solution = solution2x5_1_0_3_0_path },
		new solutionPath { tID=1, tY = 0, tX = 3, tA = 2, solution = solution2x5_1_0_3_2_path },
		new solutionPath { tID=1, tY = 0, tX = 4, tA = 1, solution = solution2x5_1_0_4_1_path },
		new solutionPath { tID=1, tY = 0, tX = 4, tA = 3, solution = solution2x5_1_0_4_3_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 0, solution = solution2x5_1_1_0_0_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 2, solution = solution2x5_1_1_0_2_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 1, solution = solution2x5_1_1_1_1_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 3, solution = solution2x5_1_1_1_3_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 0, solution = solution2x5_1_1_2_0_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 2, solution = solution2x5_1_1_2_2_path },
		new solutionPath { tID=1, tY = 1, tX = 3, tA = 1, solution = solution2x5_1_1_3_1_path },
		new solutionPath { tID=1, tY = 1, tX = 3, tA = 3, solution = solution2x5_1_1_3_3_path },
		new solutionPath { tID=1, tY = 1, tX = 4, tA = 0, solution = solution2x5_1_1_4_0_path },
		new solutionPath { tID=1, tY = 1, tX = 4, tA = 2, solution = solution2x5_1_1_4_2_path },
		new solutionPath { tID=2, tY = 0, tX = 2, tA = 2, solution = solution2x5_2_0_2_2_path },
		new solutionPath { tID=2, tY = 0, tX = 3, tA = 1, solution = solution2x5_2_0_3_1_path },
		new solutionPath { tID=2, tY = 0, tX = 3, tA = 3, solution = solution2x5_2_0_3_3_path },
		new solutionPath { tID=2, tY = 0, tX = 4, tA = 0, solution = solution2x5_2_0_4_0_path },
		new solutionPath { tID=2, tY = 0, tX = 4, tA = 2, solution = solution2x5_2_0_4_2_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 1, solution = solution2x5_2_1_0_1_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 3, solution = solution2x5_2_1_0_3_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 0, solution = solution2x5_2_1_1_0_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 2, solution = solution2x5_2_1_1_2_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 1, solution = solution2x5_2_1_2_1_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 3, solution = solution2x5_2_1_2_3_path },
		new solutionPath { tID=2, tY = 1, tX = 3, tA = 0, solution = solution2x5_2_1_3_0_path },
		new solutionPath { tID=2, tY = 1, tX = 3, tA = 2, solution = solution2x5_2_1_3_2_path },
		new solutionPath { tID=2, tY = 1, tX = 4, tA = 1, solution = solution2x5_2_1_4_1_path },
		new solutionPath { tID=2, tY = 1, tX = 4, tA = 3, solution = solution2x5_2_1_4_3_path },
		new solutionPath { tID=3, tY = 0, tX = 3, tA = 2, solution = solution2x5_3_0_3_2_path },
		new solutionPath { tID=3, tY = 0, tX = 4, tA = 1, solution = solution2x5_3_0_4_1_path },
		new solutionPath { tID=3, tY = 0, tX = 4, tA = 3, solution = solution2x5_3_0_4_3_path },
		new solutionPath { tID=3, tY = 1, tX = 0, tA = 0, solution = solution2x5_3_1_0_0_path },
		new solutionPath { tID=3, tY = 1, tX = 0, tA = 2, solution = solution2x5_3_1_0_2_path },
		new solutionPath { tID=3, tY = 1, tX = 1, tA = 1, solution = solution2x5_3_1_1_1_path },
		new solutionPath { tID=3, tY = 1, tX = 1, tA = 3, solution = solution2x5_3_1_1_3_path },
		new solutionPath { tID=3, tY = 1, tX = 2, tA = 0, solution = solution2x5_3_1_2_0_path },
		new solutionPath { tID=3, tY = 1, tX = 2, tA = 2, solution = solution2x5_3_1_2_2_path },
		new solutionPath { tID=3, tY = 1, tX = 3, tA = 1, solution = solution2x5_3_1_3_1_path },
		new solutionPath { tID=3, tY = 1, tX = 3, tA = 3, solution = solution2x5_3_1_3_3_path },
		new solutionPath { tID=3, tY = 1, tX = 4, tA = 0, solution = solution2x5_3_1_4_0_path },
		new solutionPath { tID=3, tY = 1, tX = 4, tA = 2, solution = solution2x5_3_1_4_2_path },
		new solutionPath { tID=4, tY = 0, tX = 4, tA = 2, solution = solution2x5_4_0_4_2_path },
		new solutionPath { tID=4, tY = 1, tX = 0, tA = 1, solution = solution2x5_4_1_0_1_path },
		new solutionPath { tID=4, tY = 1, tX = 0, tA = 3, solution = solution2x5_4_1_0_3_path },
		new solutionPath { tID=4, tY = 1, tX = 1, tA = 0, solution = solution2x5_4_1_1_0_path },
		new solutionPath { tID=4, tY = 1, tX = 1, tA = 2, solution = solution2x5_4_1_1_2_path },
		new solutionPath { tID=4, tY = 1, tX = 2, tA = 1, solution = solution2x5_4_1_2_1_path },
		new solutionPath { tID=4, tY = 1, tX = 2, tA = 3, solution = solution2x5_4_1_2_3_path },
		new solutionPath { tID=4, tY = 1, tX = 3, tA = 0, solution = solution2x5_4_1_3_0_path },
		new solutionPath { tID=4, tY = 1, tX = 3, tA = 2, solution = solution2x5_4_1_3_2_path },
		new solutionPath { tID=4, tY = 1, tX = 4, tA = 1, solution = solution2x5_4_1_4_1_path },
		new solutionPath { tID=4, tY = 1, tX = 4, tA = 3, solution = solution2x5_4_1_4_3_path },
		new solutionPath { tID=5, tY = 1, tX = 0, tA = 2, solution = solution2x5_5_1_0_2_path },
		new solutionPath { tID=5, tY = 1, tX = 1, tA = 1, solution = solution2x5_5_1_1_1_path },
		new solutionPath { tID=5, tY = 1, tX = 1, tA = 3, solution = solution2x5_5_1_1_3_path },
		new solutionPath { tID=5, tY = 1, tX = 2, tA = 0, solution = solution2x5_5_1_2_0_path },
		new solutionPath { tID=5, tY = 1, tX = 2, tA = 2, solution = solution2x5_5_1_2_2_path },
		new solutionPath { tID=5, tY = 1, tX = 3, tA = 1, solution = solution2x5_5_1_3_1_path },
		new solutionPath { tID=5, tY = 1, tX = 3, tA = 3, solution = solution2x5_5_1_3_3_path },
		new solutionPath { tID=5, tY = 1, tX = 4, tA = 0, solution = solution2x5_5_1_4_0_path },
		new solutionPath { tID=5, tY = 1, tX = 4, tA = 2, solution = solution2x5_5_1_4_2_path },
		new solutionPath { tID=6, tY = 1, tX = 1, tA = 2, solution = solution2x5_6_1_1_2_path },
		new solutionPath { tID=6, tY = 1, tX = 2, tA = 1, solution = solution2x5_6_1_2_1_path },
		new solutionPath { tID=6, tY = 1, tX = 2, tA = 3, solution = solution2x5_6_1_2_3_path },
		new solutionPath { tID=6, tY = 1, tX = 3, tA = 0, solution = solution2x5_6_1_3_0_path },
		new solutionPath { tID=6, tY = 1, tX = 3, tA = 2, solution = solution2x5_6_1_3_2_path },
		new solutionPath { tID=6, tY = 1, tX = 4, tA = 1, solution = solution2x5_6_1_4_1_path },
		new solutionPath { tID=6, tY = 1, tX = 4, tA = 3, solution = solution2x5_6_1_4_3_path },
		new solutionPath { tID=7, tY = 1, tX = 2, tA = 2, solution = solution2x5_7_1_2_2_path },
		new solutionPath { tID=7, tY = 1, tX = 3, tA = 1, solution = solution2x5_7_1_3_1_path },
		new solutionPath { tID=7, tY = 1, tX = 3, tA = 3, solution = solution2x5_7_1_3_3_path },
		new solutionPath { tID=7, tY = 1, tX = 4, tA = 0, solution = solution2x5_7_1_4_0_path },
		new solutionPath { tID=7, tY = 1, tX = 4, tA = 2, solution = solution2x5_7_1_4_2_path },
		new solutionPath { tID=8, tY = 1, tX = 3, tA = 2, solution = solution2x5_8_1_3_2_path },
		new solutionPath { tID=8, tY = 1, tX = 4, tA = 1, solution = solution2x5_8_1_4_1_path },
		new solutionPath { tID=8, tY = 1, tX = 4, tA = 3, solution = solution2x5_8_1_4_3_path }
	};

}
