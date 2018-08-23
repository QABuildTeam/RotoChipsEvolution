using UnityEngine;
using System.Collections;

public class AutoStepPart_3x5 : MonoBehaviour
{

	static readonly byte[] solution3x5_0_0_0_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_0_1_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_0_1_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_0_2_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_0_2_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_0_3_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_0_3_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_0_4_0_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_0_4_2_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_1_0_1_path =
	{
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_1_0_3_path =
	{
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_1_1_0_path =
	{
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_1_1_2_path =
	{
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_1_2_1_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_1_2_3_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_1_3_0_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_1_3_2_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_1_4_1_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_1_4_3_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_2_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_2_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_2_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_2_2_2_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_2_3_1_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_2_4_0_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_0_2_4_2_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_1_0_1_2_path =
	{
		(byte)0x00,
		(byte)0x10,
		(byte)0x11,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_1_0_2_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_0_2_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_0_3_0_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_0_3_2_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_0_4_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_0_4_3_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_1_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_1_1_1_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_1_1_3_path =
	{
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_1_2_0_path =
	{
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_1_2_2_path =
	{
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_1_3_1_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_1_3_3_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_1_4_0_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_1_4_2_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_2_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_2_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_2_1_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_2_1_2_path =
	{
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_2_2_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_2_4_1_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_1_2_4_3_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution3x5_2_0_2_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_0_3_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_0_3_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_0_4_0_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_0_4_2_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_1_0_1_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_1_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_1_1_0_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_1_1_2_path =
	{
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_1_2_1_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_1_2_3_path =
	{
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_1_3_0_path =
	{
		(byte)0x02,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_1_3_2_path =
	{
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_1_4_1_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_1_4_3_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_2_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_2_1_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_2_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_2_2_2_path =
	{
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_2_3_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_2_4_0_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_2_2_4_2_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_3_0_3_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_0_4_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_0_4_3_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x12,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_1_0_0_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_1_1_1_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_1_1_3_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_1_2_0_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_1_2_2_path =
	{
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_1_3_1_path =
	{
		(byte)0x12,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_1_3_3_path =
	{
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_1_4_0_path =
	{
		(byte)0x03,
		(byte)0x12,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_1_4_2_path =
	{
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_2_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_2_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_2_1_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_2_1_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_2_2_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_2_3_2_path =
	{
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_2_4_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_3_2_4_3_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_4_0_4_2_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_4_1_0_1_path =
	{
		(byte)0x03,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_4_1_0_3_path =
	{
		(byte)0x02,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_4_1_1_0_path =
	{
		(byte)0x02,
		(byte)0x11,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_4_1_1_2_path =
	{
		(byte)0x03,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_4_1_2_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_4_1_2_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_4_1_3_0_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_4_1_3_2_path =
	{
		(byte)0x13,
		(byte)0x03,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_4_1_4_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_4_1_4_3_path =
	{
		(byte)0x03,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_4_2_0_0_path =
	{
		(byte)0x03,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_4_2_0_2_path =
	{
		(byte)0x02,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_4_2_1_1_path =
	{
		(byte)0x03,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_4_2_1_3_path =
	{
		(byte)0x02,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_4_2_2_0_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_4_2_2_2_path =
	{
		(byte)0x03,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_4_2_3_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_4_2_3_3_path =
	{
		(byte)0x03,
		(byte)0x13,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_4_2_4_0_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x13,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution3x5_4_2_4_2_path =
	{
		(byte)0x03,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution3x5_5_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_1_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_1_1_3_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_1_2_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_1_2_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_1_3_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_1_3_3_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_1_4_0_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_1_4_2_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_2_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_2_0_3_path =
	{
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_2_1_0_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_2_1_2_path =
	{
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_2_2_1_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_2_4_1_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_5_2_4_3_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_6_1_1_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_1_2_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_1_2_3_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_1_3_0_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_1_3_2_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_1_4_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_1_4_3_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_2_0_0_path =
	{
		(byte)0x00,
		(byte)0x01,
		(byte)0x10,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution3x5_6_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x10,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_2_1_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_2_1_3_path =
	{
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_2_2_0_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_2_2_2_path =
	{
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_2_3_1_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_2_4_0_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_6_2_4_2_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_7_1_2_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x10,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_7_1_3_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_7_1_3_3_path =
	{
		(byte)0x12,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_7_1_4_0_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_7_1_4_2_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_7_2_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_7_2_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_7_2_1_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_7_2_1_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_7_2_2_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_7_2_2_3_path =
	{
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_7_2_3_0_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_7_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_7_2_4_1_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_7_2_4_3_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_8_1_3_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_8_1_4_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_8_1_4_3_path =
	{
		(byte)0x03,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_8_2_0_0_path =
	{
		(byte)0x02,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_8_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_8_2_1_1_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_8_2_1_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_8_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_8_2_2_2_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_8_2_3_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_8_2_3_3_path =
	{
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_8_2_4_0_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_8_2_4_2_path =
	{
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_9_1_4_2_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_9_2_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x13,
		(byte)0x12,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_9_2_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_9_2_1_0_path =
	{
		(byte)0x03,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_9_2_1_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_9_2_2_1_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_9_2_2_3_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_9_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_9_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x03,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_9_2_4_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_9_2_4_3_path =
	{
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_10_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x10,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x11,
		(byte)0x00,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_10_2_1_1_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x11,
		(byte)0x00,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_10_2_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x01,
		(byte)0x10,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10
	} ;
	static readonly byte[] solution3x5_10_2_2_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_10_2_2_2_path =
	{
		(byte)0x00,
		(byte)0x11,
		(byte)0x01,
		(byte)0x10,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x11,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_10_2_3_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_10_2_3_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_10_2_4_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_10_2_4_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_11_2_1_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x12,
		(byte)0x01,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_11_2_2_1_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x12,
		(byte)0x01,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_11_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x02,
		(byte)0x11,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_11_2_3_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_11_2_3_2_path =
	{
		(byte)0x01,
		(byte)0x12,
		(byte)0x02,
		(byte)0x11,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x12,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_11_2_4_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_11_2_4_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11
	} ;
	static readonly byte[] solution3x5_12_2_2_2_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x13,
		(byte)0x02,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_12_2_3_1_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x13,
		(byte)0x02,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_12_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x03,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_12_2_4_0_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x13,
		(byte)0x13,
		(byte)0x02,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_12_2_4_2_path =
	{
		(byte)0x02,
		(byte)0x13,
		(byte)0x03,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x13,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_13_2_3_2_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x13,
		(byte)0x13,
		(byte)0x03,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x13,
		(byte)0x03,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution3x5_13_2_4_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x03,
		(byte)0x12
	} ;
	static readonly byte[] solution3x5_13_2_4_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x12,
		(byte)0x03,
		(byte)0x02,
		(byte)0x13
	} ;

// Solutions for 3x5 puzzle
	public static readonly solutionPath[] solution3x5 = {
		new solutionPath { tID=0, tY = 0, tX = 0, tA = 2, solution = solution3x5_0_0_0_2_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 1, solution = solution3x5_0_0_1_1_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 3, solution = solution3x5_0_0_1_3_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 0, solution = solution3x5_0_0_2_0_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 2, solution = solution3x5_0_0_2_2_path },
		new solutionPath { tID=0, tY = 0, tX = 3, tA = 1, solution = solution3x5_0_0_3_1_path },
		new solutionPath { tID=0, tY = 0, tX = 3, tA = 3, solution = solution3x5_0_0_3_3_path },
		new solutionPath { tID=0, tY = 0, tX = 4, tA = 0, solution = solution3x5_0_0_4_0_path },
		new solutionPath { tID=0, tY = 0, tX = 4, tA = 2, solution = solution3x5_0_0_4_2_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 1, solution = solution3x5_0_1_0_1_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 3, solution = solution3x5_0_1_0_3_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 0, solution = solution3x5_0_1_1_0_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 2, solution = solution3x5_0_1_1_2_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 1, solution = solution3x5_0_1_2_1_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 3, solution = solution3x5_0_1_2_3_path },
		new solutionPath { tID=0, tY = 1, tX = 3, tA = 0, solution = solution3x5_0_1_3_0_path },
		new solutionPath { tID=0, tY = 1, tX = 3, tA = 2, solution = solution3x5_0_1_3_2_path },
		new solutionPath { tID=0, tY = 1, tX = 4, tA = 1, solution = solution3x5_0_1_4_1_path },
		new solutionPath { tID=0, tY = 1, tX = 4, tA = 3, solution = solution3x5_0_1_4_3_path },
		new solutionPath { tID=0, tY = 2, tX = 0, tA = 0, solution = solution3x5_0_2_0_0_path },
		new solutionPath { tID=0, tY = 2, tX = 0, tA = 2, solution = solution3x5_0_2_0_2_path },
		new solutionPath { tID=0, tY = 2, tX = 1, tA = 1, solution = solution3x5_0_2_1_1_path },
		new solutionPath { tID=0, tY = 2, tX = 1, tA = 3, solution = solution3x5_0_2_1_3_path },
		new solutionPath { tID=0, tY = 2, tX = 2, tA = 0, solution = solution3x5_0_2_2_0_path },
		new solutionPath { tID=0, tY = 2, tX = 2, tA = 2, solution = solution3x5_0_2_2_2_path },
		new solutionPath { tID=0, tY = 2, tX = 3, tA = 1, solution = solution3x5_0_2_3_1_path },
		new solutionPath { tID=0, tY = 2, tX = 3, tA = 3, solution = solution3x5_0_2_3_3_path },
		new solutionPath { tID=0, tY = 2, tX = 4, tA = 0, solution = solution3x5_0_2_4_0_path },
		new solutionPath { tID=0, tY = 2, tX = 4, tA = 2, solution = solution3x5_0_2_4_2_path },
		new solutionPath { tID=1, tY = 0, tX = 1, tA = 2, solution = solution3x5_1_0_1_2_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 1, solution = solution3x5_1_0_2_1_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 3, solution = solution3x5_1_0_2_3_path },
		new solutionPath { tID=1, tY = 0, tX = 3, tA = 0, solution = solution3x5_1_0_3_0_path },
		new solutionPath { tID=1, tY = 0, tX = 3, tA = 2, solution = solution3x5_1_0_3_2_path },
		new solutionPath { tID=1, tY = 0, tX = 4, tA = 1, solution = solution3x5_1_0_4_1_path },
		new solutionPath { tID=1, tY = 0, tX = 4, tA = 3, solution = solution3x5_1_0_4_3_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 0, solution = solution3x5_1_1_0_0_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 2, solution = solution3x5_1_1_0_2_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 1, solution = solution3x5_1_1_1_1_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 3, solution = solution3x5_1_1_1_3_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 0, solution = solution3x5_1_1_2_0_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 2, solution = solution3x5_1_1_2_2_path },
		new solutionPath { tID=1, tY = 1, tX = 3, tA = 1, solution = solution3x5_1_1_3_1_path },
		new solutionPath { tID=1, tY = 1, tX = 3, tA = 3, solution = solution3x5_1_1_3_3_path },
		new solutionPath { tID=1, tY = 1, tX = 4, tA = 0, solution = solution3x5_1_1_4_0_path },
		new solutionPath { tID=1, tY = 1, tX = 4, tA = 2, solution = solution3x5_1_1_4_2_path },
		new solutionPath { tID=1, tY = 2, tX = 0, tA = 1, solution = solution3x5_1_2_0_1_path },
		new solutionPath { tID=1, tY = 2, tX = 0, tA = 3, solution = solution3x5_1_2_0_3_path },
		new solutionPath { tID=1, tY = 2, tX = 1, tA = 0, solution = solution3x5_1_2_1_0_path },
		new solutionPath { tID=1, tY = 2, tX = 1, tA = 2, solution = solution3x5_1_2_1_2_path },
		new solutionPath { tID=1, tY = 2, tX = 2, tA = 1, solution = solution3x5_1_2_2_1_path },
		new solutionPath { tID=1, tY = 2, tX = 2, tA = 3, solution = solution3x5_1_2_2_3_path },
		new solutionPath { tID=1, tY = 2, tX = 3, tA = 0, solution = solution3x5_1_2_3_0_path },
		new solutionPath { tID=1, tY = 2, tX = 3, tA = 2, solution = solution3x5_1_2_3_2_path },
		new solutionPath { tID=1, tY = 2, tX = 4, tA = 1, solution = solution3x5_1_2_4_1_path },
		new solutionPath { tID=1, tY = 2, tX = 4, tA = 3, solution = solution3x5_1_2_4_3_path },
		new solutionPath { tID=2, tY = 0, tX = 2, tA = 2, solution = solution3x5_2_0_2_2_path },
		new solutionPath { tID=2, tY = 0, tX = 3, tA = 1, solution = solution3x5_2_0_3_1_path },
		new solutionPath { tID=2, tY = 0, tX = 3, tA = 3, solution = solution3x5_2_0_3_3_path },
		new solutionPath { tID=2, tY = 0, tX = 4, tA = 0, solution = solution3x5_2_0_4_0_path },
		new solutionPath { tID=2, tY = 0, tX = 4, tA = 2, solution = solution3x5_2_0_4_2_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 1, solution = solution3x5_2_1_0_1_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 3, solution = solution3x5_2_1_0_3_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 0, solution = solution3x5_2_1_1_0_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 2, solution = solution3x5_2_1_1_2_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 1, solution = solution3x5_2_1_2_1_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 3, solution = solution3x5_2_1_2_3_path },
		new solutionPath { tID=2, tY = 1, tX = 3, tA = 0, solution = solution3x5_2_1_3_0_path },
		new solutionPath { tID=2, tY = 1, tX = 3, tA = 2, solution = solution3x5_2_1_3_2_path },
		new solutionPath { tID=2, tY = 1, tX = 4, tA = 1, solution = solution3x5_2_1_4_1_path },
		new solutionPath { tID=2, tY = 1, tX = 4, tA = 3, solution = solution3x5_2_1_4_3_path },
		new solutionPath { tID=2, tY = 2, tX = 0, tA = 0, solution = solution3x5_2_2_0_0_path },
		new solutionPath { tID=2, tY = 2, tX = 0, tA = 2, solution = solution3x5_2_2_0_2_path },
		new solutionPath { tID=2, tY = 2, tX = 1, tA = 1, solution = solution3x5_2_2_1_1_path },
		new solutionPath { tID=2, tY = 2, tX = 1, tA = 3, solution = solution3x5_2_2_1_3_path },
		new solutionPath { tID=2, tY = 2, tX = 2, tA = 0, solution = solution3x5_2_2_2_0_path },
		new solutionPath { tID=2, tY = 2, tX = 2, tA = 2, solution = solution3x5_2_2_2_2_path },
		new solutionPath { tID=2, tY = 2, tX = 3, tA = 1, solution = solution3x5_2_2_3_1_path },
		new solutionPath { tID=2, tY = 2, tX = 3, tA = 3, solution = solution3x5_2_2_3_3_path },
		new solutionPath { tID=2, tY = 2, tX = 4, tA = 0, solution = solution3x5_2_2_4_0_path },
		new solutionPath { tID=2, tY = 2, tX = 4, tA = 2, solution = solution3x5_2_2_4_2_path },
		new solutionPath { tID=3, tY = 0, tX = 3, tA = 2, solution = solution3x5_3_0_3_2_path },
		new solutionPath { tID=3, tY = 0, tX = 4, tA = 1, solution = solution3x5_3_0_4_1_path },
		new solutionPath { tID=3, tY = 0, tX = 4, tA = 3, solution = solution3x5_3_0_4_3_path },
		new solutionPath { tID=3, tY = 1, tX = 0, tA = 0, solution = solution3x5_3_1_0_0_path },
		new solutionPath { tID=3, tY = 1, tX = 0, tA = 2, solution = solution3x5_3_1_0_2_path },
		new solutionPath { tID=3, tY = 1, tX = 1, tA = 1, solution = solution3x5_3_1_1_1_path },
		new solutionPath { tID=3, tY = 1, tX = 1, tA = 3, solution = solution3x5_3_1_1_3_path },
		new solutionPath { tID=3, tY = 1, tX = 2, tA = 0, solution = solution3x5_3_1_2_0_path },
		new solutionPath { tID=3, tY = 1, tX = 2, tA = 2, solution = solution3x5_3_1_2_2_path },
		new solutionPath { tID=3, tY = 1, tX = 3, tA = 1, solution = solution3x5_3_1_3_1_path },
		new solutionPath { tID=3, tY = 1, tX = 3, tA = 3, solution = solution3x5_3_1_3_3_path },
		new solutionPath { tID=3, tY = 1, tX = 4, tA = 0, solution = solution3x5_3_1_4_0_path },
		new solutionPath { tID=3, tY = 1, tX = 4, tA = 2, solution = solution3x5_3_1_4_2_path },
		new solutionPath { tID=3, tY = 2, tX = 0, tA = 1, solution = solution3x5_3_2_0_1_path },
		new solutionPath { tID=3, tY = 2, tX = 0, tA = 3, solution = solution3x5_3_2_0_3_path },
		new solutionPath { tID=3, tY = 2, tX = 1, tA = 0, solution = solution3x5_3_2_1_0_path },
		new solutionPath { tID=3, tY = 2, tX = 1, tA = 2, solution = solution3x5_3_2_1_2_path },
		new solutionPath { tID=3, tY = 2, tX = 2, tA = 1, solution = solution3x5_3_2_2_1_path },
		new solutionPath { tID=3, tY = 2, tX = 2, tA = 3, solution = solution3x5_3_2_2_3_path },
		new solutionPath { tID=3, tY = 2, tX = 3, tA = 0, solution = solution3x5_3_2_3_0_path },
		new solutionPath { tID=3, tY = 2, tX = 3, tA = 2, solution = solution3x5_3_2_3_2_path },
		new solutionPath { tID=3, tY = 2, tX = 4, tA = 1, solution = solution3x5_3_2_4_1_path },
		new solutionPath { tID=3, tY = 2, tX = 4, tA = 3, solution = solution3x5_3_2_4_3_path },
		new solutionPath { tID=4, tY = 0, tX = 4, tA = 2, solution = solution3x5_4_0_4_2_path },
		new solutionPath { tID=4, tY = 1, tX = 0, tA = 1, solution = solution3x5_4_1_0_1_path },
		new solutionPath { tID=4, tY = 1, tX = 0, tA = 3, solution = solution3x5_4_1_0_3_path },
		new solutionPath { tID=4, tY = 1, tX = 1, tA = 0, solution = solution3x5_4_1_1_0_path },
		new solutionPath { tID=4, tY = 1, tX = 1, tA = 2, solution = solution3x5_4_1_1_2_path },
		new solutionPath { tID=4, tY = 1, tX = 2, tA = 1, solution = solution3x5_4_1_2_1_path },
		new solutionPath { tID=4, tY = 1, tX = 2, tA = 3, solution = solution3x5_4_1_2_3_path },
		new solutionPath { tID=4, tY = 1, tX = 3, tA = 0, solution = solution3x5_4_1_3_0_path },
		new solutionPath { tID=4, tY = 1, tX = 3, tA = 2, solution = solution3x5_4_1_3_2_path },
		new solutionPath { tID=4, tY = 1, tX = 4, tA = 1, solution = solution3x5_4_1_4_1_path },
		new solutionPath { tID=4, tY = 1, tX = 4, tA = 3, solution = solution3x5_4_1_4_3_path },
		new solutionPath { tID=4, tY = 2, tX = 0, tA = 0, solution = solution3x5_4_2_0_0_path },
		new solutionPath { tID=4, tY = 2, tX = 0, tA = 2, solution = solution3x5_4_2_0_2_path },
		new solutionPath { tID=4, tY = 2, tX = 1, tA = 1, solution = solution3x5_4_2_1_1_path },
		new solutionPath { tID=4, tY = 2, tX = 1, tA = 3, solution = solution3x5_4_2_1_3_path },
		new solutionPath { tID=4, tY = 2, tX = 2, tA = 0, solution = solution3x5_4_2_2_0_path },
		new solutionPath { tID=4, tY = 2, tX = 2, tA = 2, solution = solution3x5_4_2_2_2_path },
		new solutionPath { tID=4, tY = 2, tX = 3, tA = 1, solution = solution3x5_4_2_3_1_path },
		new solutionPath { tID=4, tY = 2, tX = 3, tA = 3, solution = solution3x5_4_2_3_3_path },
		new solutionPath { tID=4, tY = 2, tX = 4, tA = 0, solution = solution3x5_4_2_4_0_path },
		new solutionPath { tID=4, tY = 2, tX = 4, tA = 2, solution = solution3x5_4_2_4_2_path },
		new solutionPath { tID=5, tY = 1, tX = 0, tA = 2, solution = solution3x5_5_1_0_2_path },
		new solutionPath { tID=5, tY = 1, tX = 1, tA = 1, solution = solution3x5_5_1_1_1_path },
		new solutionPath { tID=5, tY = 1, tX = 1, tA = 3, solution = solution3x5_5_1_1_3_path },
		new solutionPath { tID=5, tY = 1, tX = 2, tA = 0, solution = solution3x5_5_1_2_0_path },
		new solutionPath { tID=5, tY = 1, tX = 2, tA = 2, solution = solution3x5_5_1_2_2_path },
		new solutionPath { tID=5, tY = 1, tX = 3, tA = 1, solution = solution3x5_5_1_3_1_path },
		new solutionPath { tID=5, tY = 1, tX = 3, tA = 3, solution = solution3x5_5_1_3_3_path },
		new solutionPath { tID=5, tY = 1, tX = 4, tA = 0, solution = solution3x5_5_1_4_0_path },
		new solutionPath { tID=5, tY = 1, tX = 4, tA = 2, solution = solution3x5_5_1_4_2_path },
		new solutionPath { tID=5, tY = 2, tX = 0, tA = 1, solution = solution3x5_5_2_0_1_path },
		new solutionPath { tID=5, tY = 2, tX = 0, tA = 3, solution = solution3x5_5_2_0_3_path },
		new solutionPath { tID=5, tY = 2, tX = 1, tA = 0, solution = solution3x5_5_2_1_0_path },
		new solutionPath { tID=5, tY = 2, tX = 1, tA = 2, solution = solution3x5_5_2_1_2_path },
		new solutionPath { tID=5, tY = 2, tX = 2, tA = 1, solution = solution3x5_5_2_2_1_path },
		new solutionPath { tID=5, tY = 2, tX = 2, tA = 3, solution = solution3x5_5_2_2_3_path },
		new solutionPath { tID=5, tY = 2, tX = 3, tA = 0, solution = solution3x5_5_2_3_0_path },
		new solutionPath { tID=5, tY = 2, tX = 3, tA = 2, solution = solution3x5_5_2_3_2_path },
		new solutionPath { tID=5, tY = 2, tX = 4, tA = 1, solution = solution3x5_5_2_4_1_path },
		new solutionPath { tID=5, tY = 2, tX = 4, tA = 3, solution = solution3x5_5_2_4_3_path },
		new solutionPath { tID=6, tY = 1, tX = 1, tA = 2, solution = solution3x5_6_1_1_2_path },
		new solutionPath { tID=6, tY = 1, tX = 2, tA = 1, solution = solution3x5_6_1_2_1_path },
		new solutionPath { tID=6, tY = 1, tX = 2, tA = 3, solution = solution3x5_6_1_2_3_path },
		new solutionPath { tID=6, tY = 1, tX = 3, tA = 0, solution = solution3x5_6_1_3_0_path },
		new solutionPath { tID=6, tY = 1, tX = 3, tA = 2, solution = solution3x5_6_1_3_2_path },
		new solutionPath { tID=6, tY = 1, tX = 4, tA = 1, solution = solution3x5_6_1_4_1_path },
		new solutionPath { tID=6, tY = 1, tX = 4, tA = 3, solution = solution3x5_6_1_4_3_path },
		new solutionPath { tID=6, tY = 2, tX = 0, tA = 0, solution = solution3x5_6_2_0_0_path },
		new solutionPath { tID=6, tY = 2, tX = 0, tA = 2, solution = solution3x5_6_2_0_2_path },
		new solutionPath { tID=6, tY = 2, tX = 1, tA = 1, solution = solution3x5_6_2_1_1_path },
		new solutionPath { tID=6, tY = 2, tX = 1, tA = 3, solution = solution3x5_6_2_1_3_path },
		new solutionPath { tID=6, tY = 2, tX = 2, tA = 0, solution = solution3x5_6_2_2_0_path },
		new solutionPath { tID=6, tY = 2, tX = 2, tA = 2, solution = solution3x5_6_2_2_2_path },
		new solutionPath { tID=6, tY = 2, tX = 3, tA = 1, solution = solution3x5_6_2_3_1_path },
		new solutionPath { tID=6, tY = 2, tX = 3, tA = 3, solution = solution3x5_6_2_3_3_path },
		new solutionPath { tID=6, tY = 2, tX = 4, tA = 0, solution = solution3x5_6_2_4_0_path },
		new solutionPath { tID=6, tY = 2, tX = 4, tA = 2, solution = solution3x5_6_2_4_2_path },
		new solutionPath { tID=7, tY = 1, tX = 2, tA = 2, solution = solution3x5_7_1_2_2_path },
		new solutionPath { tID=7, tY = 1, tX = 3, tA = 1, solution = solution3x5_7_1_3_1_path },
		new solutionPath { tID=7, tY = 1, tX = 3, tA = 3, solution = solution3x5_7_1_3_3_path },
		new solutionPath { tID=7, tY = 1, tX = 4, tA = 0, solution = solution3x5_7_1_4_0_path },
		new solutionPath { tID=7, tY = 1, tX = 4, tA = 2, solution = solution3x5_7_1_4_2_path },
		new solutionPath { tID=7, tY = 2, tX = 0, tA = 1, solution = solution3x5_7_2_0_1_path },
		new solutionPath { tID=7, tY = 2, tX = 0, tA = 3, solution = solution3x5_7_2_0_3_path },
		new solutionPath { tID=7, tY = 2, tX = 1, tA = 0, solution = solution3x5_7_2_1_0_path },
		new solutionPath { tID=7, tY = 2, tX = 1, tA = 2, solution = solution3x5_7_2_1_2_path },
		new solutionPath { tID=7, tY = 2, tX = 2, tA = 1, solution = solution3x5_7_2_2_1_path },
		new solutionPath { tID=7, tY = 2, tX = 2, tA = 3, solution = solution3x5_7_2_2_3_path },
		new solutionPath { tID=7, tY = 2, tX = 3, tA = 0, solution = solution3x5_7_2_3_0_path },
		new solutionPath { tID=7, tY = 2, tX = 3, tA = 2, solution = solution3x5_7_2_3_2_path },
		new solutionPath { tID=7, tY = 2, tX = 4, tA = 1, solution = solution3x5_7_2_4_1_path },
		new solutionPath { tID=7, tY = 2, tX = 4, tA = 3, solution = solution3x5_7_2_4_3_path },
		new solutionPath { tID=8, tY = 1, tX = 3, tA = 2, solution = solution3x5_8_1_3_2_path },
		new solutionPath { tID=8, tY = 1, tX = 4, tA = 1, solution = solution3x5_8_1_4_1_path },
		new solutionPath { tID=8, tY = 1, tX = 4, tA = 3, solution = solution3x5_8_1_4_3_path },
		new solutionPath { tID=8, tY = 2, tX = 0, tA = 0, solution = solution3x5_8_2_0_0_path },
		new solutionPath { tID=8, tY = 2, tX = 0, tA = 2, solution = solution3x5_8_2_0_2_path },
		new solutionPath { tID=8, tY = 2, tX = 1, tA = 1, solution = solution3x5_8_2_1_1_path },
		new solutionPath { tID=8, tY = 2, tX = 1, tA = 3, solution = solution3x5_8_2_1_3_path },
		new solutionPath { tID=8, tY = 2, tX = 2, tA = 0, solution = solution3x5_8_2_2_0_path },
		new solutionPath { tID=8, tY = 2, tX = 2, tA = 2, solution = solution3x5_8_2_2_2_path },
		new solutionPath { tID=8, tY = 2, tX = 3, tA = 1, solution = solution3x5_8_2_3_1_path },
		new solutionPath { tID=8, tY = 2, tX = 3, tA = 3, solution = solution3x5_8_2_3_3_path },
		new solutionPath { tID=8, tY = 2, tX = 4, tA = 0, solution = solution3x5_8_2_4_0_path },
		new solutionPath { tID=8, tY = 2, tX = 4, tA = 2, solution = solution3x5_8_2_4_2_path },
		new solutionPath { tID=9, tY = 1, tX = 4, tA = 2, solution = solution3x5_9_1_4_2_path },
		new solutionPath { tID=9, tY = 2, tX = 0, tA = 1, solution = solution3x5_9_2_0_1_path },
		new solutionPath { tID=9, tY = 2, tX = 0, tA = 3, solution = solution3x5_9_2_0_3_path },
		new solutionPath { tID=9, tY = 2, tX = 1, tA = 0, solution = solution3x5_9_2_1_0_path },
		new solutionPath { tID=9, tY = 2, tX = 1, tA = 2, solution = solution3x5_9_2_1_2_path },
		new solutionPath { tID=9, tY = 2, tX = 2, tA = 1, solution = solution3x5_9_2_2_1_path },
		new solutionPath { tID=9, tY = 2, tX = 2, tA = 3, solution = solution3x5_9_2_2_3_path },
		new solutionPath { tID=9, tY = 2, tX = 3, tA = 0, solution = solution3x5_9_2_3_0_path },
		new solutionPath { tID=9, tY = 2, tX = 3, tA = 2, solution = solution3x5_9_2_3_2_path },
		new solutionPath { tID=9, tY = 2, tX = 4, tA = 1, solution = solution3x5_9_2_4_1_path },
		new solutionPath { tID=9, tY = 2, tX = 4, tA = 3, solution = solution3x5_9_2_4_3_path },
		new solutionPath { tID=10, tY = 2, tX = 0, tA = 2, solution = solution3x5_10_2_0_2_path },
		new solutionPath { tID=10, tY = 2, tX = 1, tA = 1, solution = solution3x5_10_2_1_1_path },
		new solutionPath { tID=10, tY = 2, tX = 1, tA = 3, solution = solution3x5_10_2_1_3_path },
		new solutionPath { tID=10, tY = 2, tX = 2, tA = 0, solution = solution3x5_10_2_2_0_path },
		new solutionPath { tID=10, tY = 2, tX = 2, tA = 2, solution = solution3x5_10_2_2_2_path },
		new solutionPath { tID=10, tY = 2, tX = 3, tA = 1, solution = solution3x5_10_2_3_1_path },
		new solutionPath { tID=10, tY = 2, tX = 3, tA = 3, solution = solution3x5_10_2_3_3_path },
		new solutionPath { tID=10, tY = 2, tX = 4, tA = 0, solution = solution3x5_10_2_4_0_path },
		new solutionPath { tID=10, tY = 2, tX = 4, tA = 2, solution = solution3x5_10_2_4_2_path },
		new solutionPath { tID=11, tY = 2, tX = 1, tA = 2, solution = solution3x5_11_2_1_2_path },
		new solutionPath { tID=11, tY = 2, tX = 2, tA = 1, solution = solution3x5_11_2_2_1_path },
		new solutionPath { tID=11, tY = 2, tX = 2, tA = 3, solution = solution3x5_11_2_2_3_path },
		new solutionPath { tID=11, tY = 2, tX = 3, tA = 0, solution = solution3x5_11_2_3_0_path },
		new solutionPath { tID=11, tY = 2, tX = 3, tA = 2, solution = solution3x5_11_2_3_2_path },
		new solutionPath { tID=11, tY = 2, tX = 4, tA = 1, solution = solution3x5_11_2_4_1_path },
		new solutionPath { tID=11, tY = 2, tX = 4, tA = 3, solution = solution3x5_11_2_4_3_path },
		new solutionPath { tID=12, tY = 2, tX = 2, tA = 2, solution = solution3x5_12_2_2_2_path },
		new solutionPath { tID=12, tY = 2, tX = 3, tA = 1, solution = solution3x5_12_2_3_1_path },
		new solutionPath { tID=12, tY = 2, tX = 3, tA = 3, solution = solution3x5_12_2_3_3_path },
		new solutionPath { tID=12, tY = 2, tX = 4, tA = 0, solution = solution3x5_12_2_4_0_path },
		new solutionPath { tID=12, tY = 2, tX = 4, tA = 2, solution = solution3x5_12_2_4_2_path },
		new solutionPath { tID=13, tY = 2, tX = 3, tA = 2, solution = solution3x5_13_2_3_2_path },
		new solutionPath { tID=13, tY = 2, tX = 4, tA = 1, solution = solution3x5_13_2_4_1_path },
		new solutionPath { tID=13, tY = 2, tX = 4, tA = 3, solution = solution3x5_13_2_4_3_path }
	};

}
