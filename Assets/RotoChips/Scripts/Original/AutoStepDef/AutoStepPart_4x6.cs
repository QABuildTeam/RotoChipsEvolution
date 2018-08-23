using UnityEngine;
using System.Collections;

public class AutoStepPart_4x6 : MonoBehaviour
{

	static readonly byte[] solution4x6_0_0_0_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_0_1_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_0_1_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_0_2_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_0_2_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_0_3_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_0_3_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_0_4_0_path =
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
	static readonly byte[] solution4x6_0_0_4_2_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_0_5_1_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_0_5_3_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_1_0_1_path =
	{
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_1_0_3_path =
	{
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_1_1_0_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_1_1_2_path =
	{
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_1_2_1_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_1_2_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_1_3_0_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_1_3_2_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_1_4_1_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_1_4_3_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_1_5_0_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_1_5_2_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_2_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_2_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_2_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_2_2_2_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_2_3_1_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_2_4_0_path =
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
	static readonly byte[] solution4x6_0_2_4_2_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_2_5_1_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_2_5_3_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_3_1_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_3_1_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_3_3_0_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_3_4_1_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_3_4_3_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_3_5_0_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_0_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x6_1_0_1_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_0_2_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_0_2_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_0_3_0_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_0_3_2_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_0_4_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_0_4_3_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_0_5_0_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_0_5_2_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_1_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_1_1_1_path =
	{
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_1_1_3_path =
	{
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_1_2_0_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_1_2_2_path =
	{
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_1_3_1_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_1_3_3_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_1_4_0_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_1_4_2_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_1_5_1_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_1_5_3_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_2_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_2_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_2_1_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_2_1_2_path =
	{
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_2_2_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_2_4_1_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_2_4_3_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_2_5_0_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_2_5_2_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_3_1_1_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_3_1_3_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_3_2_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_3_3_1_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_3_4_0_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_3_4_2_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_1_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x6_2_0_2_2_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_0_3_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_0_3_3_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_0_4_0_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_0_4_2_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_0_5_1_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_0_5_3_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_1_0_1_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_1_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_1_1_0_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_1_1_2_path =
	{
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_1_2_1_path =
	{
		(byte)0x12,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_1_2_3_path =
	{
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_1_3_0_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_1_3_2_path =
	{
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_1_4_1_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_1_4_3_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_1_5_0_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_1_5_2_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_2_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_2_1_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_2_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_2_2_0_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_2_2_2_path =
	{
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_2_3_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_2_4_0_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_2_4_2_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_2_5_1_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_2_5_3_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_3_1_0_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_3_1_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_3_2_1_path =
	{
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_3_2_3_path =
	{
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_3_3_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_3_4_1_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_3_4_3_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_3_5_0_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_2_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_3_0_3_2_path =
	{
		(byte)0x02,
		(byte)0x12,
		(byte)0x13,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_3_0_4_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_0_4_3_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_0_5_0_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_0_5_2_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_1_0_0_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_1_1_1_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_1_1_3_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_1_2_0_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_1_2_2_path =
	{
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_1_3_1_path =
	{
		(byte)0x13,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_1_3_3_path =
	{
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_1_4_0_path =
	{
		(byte)0x03,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_1_4_2_path =
	{
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_1_5_1_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_1_5_3_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_2_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_2_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_2_1_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_2_1_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_2_2_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_2_3_0_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_2_3_2_path =
	{
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_2_4_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_2_4_3_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_2_5_0_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_2_5_2_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_3_1_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_3_1_3_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_3_2_0_path =
	{
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_3_3_1_path =
	{
		(byte)0x23,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_3_3_3_path =
	{
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_3_4_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_3_4_2_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_3_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_4_0_4_2_path =
	{
		(byte)0x03,
		(byte)0x13,
		(byte)0x14,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_4_0_5_1_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_0_5_3_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_1_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_1_0_3_path =
	{
		(byte)0x02,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution4x6_4_1_1_0_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_1_1_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_1_2_1_path =
	{
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_1_2_3_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_1_3_0_path =
	{
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_1_3_2_path =
	{
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_1_4_1_path =
	{
		(byte)0x14,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_1_4_3_path =
	{
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_1_5_0_path =
	{
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_1_5_2_path =
	{
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_2_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_2_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_2_1_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_2_2_0_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_2_2_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_2_3_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_2_4_0_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_2_4_2_path =
	{
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_2_5_1_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_2_5_3_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_3_1_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_3_2_3_path =
	{
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_3_3_0_path =
	{
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_3_4_1_path =
	{
		(byte)0x24,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_3_4_3_path =
	{
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_3_5_0_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_4_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_0_5_2_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03,
		(byte)0x13,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_1_0_0_path =
	{
		(byte)0x04,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_1_0_2_path =
	{
		(byte)0x03,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_1_1_1_path =
	{
		(byte)0x04,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_1_1_3_path =
	{
		(byte)0x03,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_1_2_0_path =
	{
		(byte)0x03,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_1_2_2_path =
	{
		(byte)0x04,
		(byte)0x12,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_1_3_1_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x13,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_1_3_3_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_1_4_0_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_1_4_2_path =
	{
		(byte)0x14,
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_1_5_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_1_5_3_path =
	{
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_2_0_1_path =
	{
		(byte)0x03,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_2_0_3_path =
	{
		(byte)0x04,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_2_1_0_path =
	{
		(byte)0x04,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_2_1_2_path =
	{
		(byte)0x03,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_2_2_1_path =
	{
		(byte)0x04,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_2_2_3_path =
	{
		(byte)0x03,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_2_3_0_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_2_3_2_path =
	{
		(byte)0x04,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_2_4_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_2_4_3_path =
	{
		(byte)0x04,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_2_5_0_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_2_5_2_path =
	{
		(byte)0x04,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_3_0_0_path =
	{
		(byte)0x03,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_3_0_2_path =
	{
		(byte)0x04,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_3_1_1_path =
	{
		(byte)0x03,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_3_1_3_path =
	{
		(byte)0x04,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_3_2_0_path =
	{
		(byte)0x04,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_3_2_2_path =
	{
		(byte)0x03,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_3_3_1_path =
	{
		(byte)0x04,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_3_3_3_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_3_4_0_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x24,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution4x6_5_3_4_2_path =
	{
		(byte)0x04,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_3_5_1_path =
	{
		(byte)0x04,
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_5_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution4x6_6_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_1_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_1_1_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_1_2_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_1_2_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_1_3_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_1_3_3_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_1_4_0_path =
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
	static readonly byte[] solution4x6_6_1_4_2_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_1_5_1_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_1_5_3_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_2_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_2_0_3_path =
	{
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_2_1_0_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_2_1_2_path =
	{
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_2_2_1_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_2_4_1_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_2_4_3_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_2_5_0_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_2_5_2_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_3_1_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_3_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_3_2_0_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_3_3_1_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_3_4_0_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_3_4_2_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_6_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x6_7_1_1_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_1_2_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_1_2_3_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_1_3_0_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_1_3_2_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_1_4_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_1_4_3_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_1_5_0_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_1_5_2_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_2_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_2_0_2_path =
	{
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_2_1_1_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_2_1_3_path =
	{
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_2_2_2_path =
	{
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_2_3_1_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_2_4_0_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_2_4_2_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_2_5_1_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_2_5_3_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_3_1_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_3_3_0_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_3_4_1_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_3_4_3_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_3_5_0_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_7_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution4x6_8_1_2_2_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_1_3_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_1_3_3_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_1_4_0_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_1_4_2_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_1_5_1_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_1_5_3_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_2_0_1_path =
	{
		(byte)0x20,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_2_0_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_2_1_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_2_1_2_path =
	{
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_2_2_1_path =
	{
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_2_2_3_path =
	{
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_2_4_1_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_2_4_3_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_2_5_0_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_2_5_2_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_3_1_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_3_1_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_3_2_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_3_2_2_path =
	{
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_3_3_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_3_4_0_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_3_4_2_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_8_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_9_1_3_2_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_1_4_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_1_4_3_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_1_5_0_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_1_5_2_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_2_0_0_path =
	{
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_2_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_2_1_1_path =
	{
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_2_1_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_2_2_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_2_2_2_path =
	{
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_2_3_1_path =
	{
		(byte)0x23,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_2_3_3_path =
	{
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_2_4_0_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_2_4_2_path =
	{
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_2_5_1_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_2_5_3_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_3_1_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_3_2_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_3_2_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_3_3_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_3_3_2_path =
	{
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_3_4_1_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_3_4_3_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_3_5_0_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_9_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_10_1_4_2_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_1_5_1_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_1_5_3_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_2_0_1_path =
	{
		(byte)0x13,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_10_2_0_3_path =
	{
		(byte)0x12,
		(byte)0x20,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_10_2_1_0_path =
	{
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_2_1_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_2_2_1_path =
	{
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_2_2_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_2_3_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_2_3_2_path =
	{
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_2_4_1_path =
	{
		(byte)0x24,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_2_4_3_path =
	{
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_2_5_0_path =
	{
		(byte)0x14,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_2_5_2_path =
	{
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_3_0_0_path =
	{
		(byte)0x13,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_10_3_0_2_path =
	{
		(byte)0x12,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12
	} ;
	static readonly byte[] solution4x6_10_3_1_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_3_1_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_3_2_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_3_2_2_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_3_3_1_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_3_4_0_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_3_4_2_path =
	{
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_10_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_1_5_2_path =
	{
		(byte)0x14,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x24,
		(byte)0x14,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_2_0_0_path =
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
		(byte)0x14,
		(byte)0x13,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_2_0_2_path =
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
		(byte)0x14,
		(byte)0x13,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_2_1_1_path =
	{
		(byte)0x14,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_2_1_3_path =
	{
		(byte)0x13,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_11_2_2_0_path =
	{
		(byte)0x13,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_11_2_2_2_path =
	{
		(byte)0x14,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_2_3_1_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x23,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_2_3_3_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_11_2_4_0_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_11_2_4_2_path =
	{
		(byte)0x24,
		(byte)0x14,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_2_5_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_11_2_5_3_path =
	{
		(byte)0x14,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_3_0_1_path =
	{
		(byte)0x13,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_11_3_0_3_path =
	{
		(byte)0x14,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_3_1_0_path =
	{
		(byte)0x14,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_3_1_2_path =
	{
		(byte)0x13,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_11_3_2_1_path =
	{
		(byte)0x14,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_3_2_3_path =
	{
		(byte)0x13,
		(byte)0x22,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_11_3_3_0_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_3_3_2_path =
	{
		(byte)0x14,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_3_4_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_11_3_4_3_path =
	{
		(byte)0x14,
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_11_3_5_0_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution4x6_11_3_5_2_path =
	{
		(byte)0x14,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution4x6_12_2_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_2_1_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_2_1_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_2_2_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_2_2_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_2_3_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_2_3_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_2_4_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_2_4_2_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_2_5_1_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_2_5_3_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_3_0_3_path =
	{
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_3_1_0_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_3_1_2_path =
	{
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_3_3_0_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_3_4_1_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_3_4_3_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_3_5_0_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_12_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_13_2_1_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_2_2_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_2_2_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_2_3_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_2_3_2_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_2_4_1_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_2_4_3_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_2_5_0_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_2_5_2_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_3_1_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_3_1_3_path =
	{
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_3_2_0_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_3_3_1_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_3_4_0_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_3_4_2_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_13_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_14_2_2_2_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_2_3_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_2_3_3_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_2_4_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_2_4_2_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_2_5_1_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_2_5_3_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_3_0_1_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_14_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_14_3_1_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_14_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_3_2_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_3_2_3_path =
	{
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_3_3_0_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_3_4_1_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_3_4_3_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_3_5_0_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_14_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_15_2_3_2_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_15_2_4_1_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_15_2_4_3_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_15_2_5_0_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_15_2_5_2_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_15_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_15_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_15_3_1_1_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_15_3_1_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_15_3_2_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_15_3_2_2_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_15_3_3_1_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_15_3_3_3_path =
	{
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_15_3_4_0_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_15_3_4_2_path =
	{
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_15_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_15_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_16_2_4_2_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_16_2_5_1_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_16_2_5_3_path =
	{
		(byte)0x14,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_16_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x23,
		(byte)0x22,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_16_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_16_3_1_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_16_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_16_3_2_1_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_16_3_2_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_16_3_3_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_16_3_3_2_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_16_3_4_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_16_3_4_3_path =
	{
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_16_3_5_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_16_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_17_2_5_2_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_17_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x23,
		(byte)0x22,
		(byte)0x24,
		(byte)0x23,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_17_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x24,
		(byte)0x23,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_17_3_1_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x24,
		(byte)0x23,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_17_3_1_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_17_3_2_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_17_3_2_2_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_17_3_3_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_17_3_3_3_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_17_3_4_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_17_3_4_2_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x14,
		(byte)0x23,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_17_3_5_1_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_17_3_5_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_18_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x21,
		(byte)0x10,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_18_3_1_1_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x21,
		(byte)0x10,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_18_3_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x11,
		(byte)0x20,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20
	} ;
	static readonly byte[] solution4x6_18_3_2_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_18_3_2_2_path =
	{
		(byte)0x10,
		(byte)0x21,
		(byte)0x11,
		(byte)0x20,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x21,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_18_3_3_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_18_3_3_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_18_3_4_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x22,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_18_3_4_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_18_3_5_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_18_3_5_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_19_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x22,
		(byte)0x11,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_19_3_2_1_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x22,
		(byte)0x11,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_19_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x12,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21
	} ;
	static readonly byte[] solution4x6_19_3_3_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_19_3_3_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_19_3_4_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_19_3_4_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_19_3_5_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_19_3_5_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_20_3_2_2_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x23,
		(byte)0x12,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_20_3_3_1_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x23,
		(byte)0x12,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_20_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x13,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_20_3_4_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_20_3_4_2_path =
	{
		(byte)0x12,
		(byte)0x23,
		(byte)0x13,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x23,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_20_3_5_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_20_3_5_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22
	} ;
	static readonly byte[] solution4x6_21_3_3_2_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x24,
		(byte)0x13,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_21_3_4_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x24,
		(byte)0x13,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_21_3_4_3_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x14,
		(byte)0x23,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_21_3_5_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x24,
		(byte)0x24,
		(byte)0x13,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_21_3_5_2_path =
	{
		(byte)0x13,
		(byte)0x24,
		(byte)0x14,
		(byte)0x23,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x24,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution4x6_22_3_4_2_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_22_3_5_1_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x14,
		(byte)0x23
	} ;
	static readonly byte[] solution4x6_22_3_5_3_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14,
		(byte)0x14,
		(byte)0x23,
		(byte)0x14,
		(byte)0x13,
		(byte)0x24
	} ;

// Solutions for 4x6 puzzle
	public static readonly solutionPath[] solution4x6 = {
		new solutionPath { tID=0, tY = 0, tX = 0, tA = 2, solution = solution4x6_0_0_0_2_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 1, solution = solution4x6_0_0_1_1_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 3, solution = solution4x6_0_0_1_3_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 0, solution = solution4x6_0_0_2_0_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 2, solution = solution4x6_0_0_2_2_path },
		new solutionPath { tID=0, tY = 0, tX = 3, tA = 1, solution = solution4x6_0_0_3_1_path },
		new solutionPath { tID=0, tY = 0, tX = 3, tA = 3, solution = solution4x6_0_0_3_3_path },
		new solutionPath { tID=0, tY = 0, tX = 4, tA = 0, solution = solution4x6_0_0_4_0_path },
		new solutionPath { tID=0, tY = 0, tX = 4, tA = 2, solution = solution4x6_0_0_4_2_path },
		new solutionPath { tID=0, tY = 0, tX = 5, tA = 1, solution = solution4x6_0_0_5_1_path },
		new solutionPath { tID=0, tY = 0, tX = 5, tA = 3, solution = solution4x6_0_0_5_3_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 1, solution = solution4x6_0_1_0_1_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 3, solution = solution4x6_0_1_0_3_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 0, solution = solution4x6_0_1_1_0_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 2, solution = solution4x6_0_1_1_2_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 1, solution = solution4x6_0_1_2_1_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 3, solution = solution4x6_0_1_2_3_path },
		new solutionPath { tID=0, tY = 1, tX = 3, tA = 0, solution = solution4x6_0_1_3_0_path },
		new solutionPath { tID=0, tY = 1, tX = 3, tA = 2, solution = solution4x6_0_1_3_2_path },
		new solutionPath { tID=0, tY = 1, tX = 4, tA = 1, solution = solution4x6_0_1_4_1_path },
		new solutionPath { tID=0, tY = 1, tX = 4, tA = 3, solution = solution4x6_0_1_4_3_path },
		new solutionPath { tID=0, tY = 1, tX = 5, tA = 0, solution = solution4x6_0_1_5_0_path },
		new solutionPath { tID=0, tY = 1, tX = 5, tA = 2, solution = solution4x6_0_1_5_2_path },
		new solutionPath { tID=0, tY = 2, tX = 0, tA = 0, solution = solution4x6_0_2_0_0_path },
		new solutionPath { tID=0, tY = 2, tX = 0, tA = 2, solution = solution4x6_0_2_0_2_path },
		new solutionPath { tID=0, tY = 2, tX = 1, tA = 1, solution = solution4x6_0_2_1_1_path },
		new solutionPath { tID=0, tY = 2, tX = 1, tA = 3, solution = solution4x6_0_2_1_3_path },
		new solutionPath { tID=0, tY = 2, tX = 2, tA = 0, solution = solution4x6_0_2_2_0_path },
		new solutionPath { tID=0, tY = 2, tX = 2, tA = 2, solution = solution4x6_0_2_2_2_path },
		new solutionPath { tID=0, tY = 2, tX = 3, tA = 1, solution = solution4x6_0_2_3_1_path },
		new solutionPath { tID=0, tY = 2, tX = 3, tA = 3, solution = solution4x6_0_2_3_3_path },
		new solutionPath { tID=0, tY = 2, tX = 4, tA = 0, solution = solution4x6_0_2_4_0_path },
		new solutionPath { tID=0, tY = 2, tX = 4, tA = 2, solution = solution4x6_0_2_4_2_path },
		new solutionPath { tID=0, tY = 2, tX = 5, tA = 1, solution = solution4x6_0_2_5_1_path },
		new solutionPath { tID=0, tY = 2, tX = 5, tA = 3, solution = solution4x6_0_2_5_3_path },
		new solutionPath { tID=0, tY = 3, tX = 0, tA = 1, solution = solution4x6_0_3_0_1_path },
		new solutionPath { tID=0, tY = 3, tX = 0, tA = 3, solution = solution4x6_0_3_0_3_path },
		new solutionPath { tID=0, tY = 3, tX = 1, tA = 0, solution = solution4x6_0_3_1_0_path },
		new solutionPath { tID=0, tY = 3, tX = 1, tA = 2, solution = solution4x6_0_3_1_2_path },
		new solutionPath { tID=0, tY = 3, tX = 2, tA = 1, solution = solution4x6_0_3_2_1_path },
		new solutionPath { tID=0, tY = 3, tX = 2, tA = 3, solution = solution4x6_0_3_2_3_path },
		new solutionPath { tID=0, tY = 3, tX = 3, tA = 0, solution = solution4x6_0_3_3_0_path },
		new solutionPath { tID=0, tY = 3, tX = 3, tA = 2, solution = solution4x6_0_3_3_2_path },
		new solutionPath { tID=0, tY = 3, tX = 4, tA = 1, solution = solution4x6_0_3_4_1_path },
		new solutionPath { tID=0, tY = 3, tX = 4, tA = 3, solution = solution4x6_0_3_4_3_path },
		new solutionPath { tID=0, tY = 3, tX = 5, tA = 0, solution = solution4x6_0_3_5_0_path },
		new solutionPath { tID=0, tY = 3, tX = 5, tA = 2, solution = solution4x6_0_3_5_2_path },
		new solutionPath { tID=1, tY = 0, tX = 1, tA = 2, solution = solution4x6_1_0_1_2_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 1, solution = solution4x6_1_0_2_1_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 3, solution = solution4x6_1_0_2_3_path },
		new solutionPath { tID=1, tY = 0, tX = 3, tA = 0, solution = solution4x6_1_0_3_0_path },
		new solutionPath { tID=1, tY = 0, tX = 3, tA = 2, solution = solution4x6_1_0_3_2_path },
		new solutionPath { tID=1, tY = 0, tX = 4, tA = 1, solution = solution4x6_1_0_4_1_path },
		new solutionPath { tID=1, tY = 0, tX = 4, tA = 3, solution = solution4x6_1_0_4_3_path },
		new solutionPath { tID=1, tY = 0, tX = 5, tA = 0, solution = solution4x6_1_0_5_0_path },
		new solutionPath { tID=1, tY = 0, tX = 5, tA = 2, solution = solution4x6_1_0_5_2_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 0, solution = solution4x6_1_1_0_0_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 2, solution = solution4x6_1_1_0_2_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 1, solution = solution4x6_1_1_1_1_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 3, solution = solution4x6_1_1_1_3_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 0, solution = solution4x6_1_1_2_0_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 2, solution = solution4x6_1_1_2_2_path },
		new solutionPath { tID=1, tY = 1, tX = 3, tA = 1, solution = solution4x6_1_1_3_1_path },
		new solutionPath { tID=1, tY = 1, tX = 3, tA = 3, solution = solution4x6_1_1_3_3_path },
		new solutionPath { tID=1, tY = 1, tX = 4, tA = 0, solution = solution4x6_1_1_4_0_path },
		new solutionPath { tID=1, tY = 1, tX = 4, tA = 2, solution = solution4x6_1_1_4_2_path },
		new solutionPath { tID=1, tY = 1, tX = 5, tA = 1, solution = solution4x6_1_1_5_1_path },
		new solutionPath { tID=1, tY = 1, tX = 5, tA = 3, solution = solution4x6_1_1_5_3_path },
		new solutionPath { tID=1, tY = 2, tX = 0, tA = 1, solution = solution4x6_1_2_0_1_path },
		new solutionPath { tID=1, tY = 2, tX = 0, tA = 3, solution = solution4x6_1_2_0_3_path },
		new solutionPath { tID=1, tY = 2, tX = 1, tA = 0, solution = solution4x6_1_2_1_0_path },
		new solutionPath { tID=1, tY = 2, tX = 1, tA = 2, solution = solution4x6_1_2_1_2_path },
		new solutionPath { tID=1, tY = 2, tX = 2, tA = 1, solution = solution4x6_1_2_2_1_path },
		new solutionPath { tID=1, tY = 2, tX = 2, tA = 3, solution = solution4x6_1_2_2_3_path },
		new solutionPath { tID=1, tY = 2, tX = 3, tA = 0, solution = solution4x6_1_2_3_0_path },
		new solutionPath { tID=1, tY = 2, tX = 3, tA = 2, solution = solution4x6_1_2_3_2_path },
		new solutionPath { tID=1, tY = 2, tX = 4, tA = 1, solution = solution4x6_1_2_4_1_path },
		new solutionPath { tID=1, tY = 2, tX = 4, tA = 3, solution = solution4x6_1_2_4_3_path },
		new solutionPath { tID=1, tY = 2, tX = 5, tA = 0, solution = solution4x6_1_2_5_0_path },
		new solutionPath { tID=1, tY = 2, tX = 5, tA = 2, solution = solution4x6_1_2_5_2_path },
		new solutionPath { tID=1, tY = 3, tX = 0, tA = 0, solution = solution4x6_1_3_0_0_path },
		new solutionPath { tID=1, tY = 3, tX = 0, tA = 2, solution = solution4x6_1_3_0_2_path },
		new solutionPath { tID=1, tY = 3, tX = 1, tA = 1, solution = solution4x6_1_3_1_1_path },
		new solutionPath { tID=1, tY = 3, tX = 1, tA = 3, solution = solution4x6_1_3_1_3_path },
		new solutionPath { tID=1, tY = 3, tX = 2, tA = 0, solution = solution4x6_1_3_2_0_path },
		new solutionPath { tID=1, tY = 3, tX = 2, tA = 2, solution = solution4x6_1_3_2_2_path },
		new solutionPath { tID=1, tY = 3, tX = 3, tA = 1, solution = solution4x6_1_3_3_1_path },
		new solutionPath { tID=1, tY = 3, tX = 3, tA = 3, solution = solution4x6_1_3_3_3_path },
		new solutionPath { tID=1, tY = 3, tX = 4, tA = 0, solution = solution4x6_1_3_4_0_path },
		new solutionPath { tID=1, tY = 3, tX = 4, tA = 2, solution = solution4x6_1_3_4_2_path },
		new solutionPath { tID=1, tY = 3, tX = 5, tA = 1, solution = solution4x6_1_3_5_1_path },
		new solutionPath { tID=1, tY = 3, tX = 5, tA = 3, solution = solution4x6_1_3_5_3_path },
		new solutionPath { tID=2, tY = 0, tX = 2, tA = 2, solution = solution4x6_2_0_2_2_path },
		new solutionPath { tID=2, tY = 0, tX = 3, tA = 1, solution = solution4x6_2_0_3_1_path },
		new solutionPath { tID=2, tY = 0, tX = 3, tA = 3, solution = solution4x6_2_0_3_3_path },
		new solutionPath { tID=2, tY = 0, tX = 4, tA = 0, solution = solution4x6_2_0_4_0_path },
		new solutionPath { tID=2, tY = 0, tX = 4, tA = 2, solution = solution4x6_2_0_4_2_path },
		new solutionPath { tID=2, tY = 0, tX = 5, tA = 1, solution = solution4x6_2_0_5_1_path },
		new solutionPath { tID=2, tY = 0, tX = 5, tA = 3, solution = solution4x6_2_0_5_3_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 1, solution = solution4x6_2_1_0_1_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 3, solution = solution4x6_2_1_0_3_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 0, solution = solution4x6_2_1_1_0_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 2, solution = solution4x6_2_1_1_2_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 1, solution = solution4x6_2_1_2_1_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 3, solution = solution4x6_2_1_2_3_path },
		new solutionPath { tID=2, tY = 1, tX = 3, tA = 0, solution = solution4x6_2_1_3_0_path },
		new solutionPath { tID=2, tY = 1, tX = 3, tA = 2, solution = solution4x6_2_1_3_2_path },
		new solutionPath { tID=2, tY = 1, tX = 4, tA = 1, solution = solution4x6_2_1_4_1_path },
		new solutionPath { tID=2, tY = 1, tX = 4, tA = 3, solution = solution4x6_2_1_4_3_path },
		new solutionPath { tID=2, tY = 1, tX = 5, tA = 0, solution = solution4x6_2_1_5_0_path },
		new solutionPath { tID=2, tY = 1, tX = 5, tA = 2, solution = solution4x6_2_1_5_2_path },
		new solutionPath { tID=2, tY = 2, tX = 0, tA = 0, solution = solution4x6_2_2_0_0_path },
		new solutionPath { tID=2, tY = 2, tX = 0, tA = 2, solution = solution4x6_2_2_0_2_path },
		new solutionPath { tID=2, tY = 2, tX = 1, tA = 1, solution = solution4x6_2_2_1_1_path },
		new solutionPath { tID=2, tY = 2, tX = 1, tA = 3, solution = solution4x6_2_2_1_3_path },
		new solutionPath { tID=2, tY = 2, tX = 2, tA = 0, solution = solution4x6_2_2_2_0_path },
		new solutionPath { tID=2, tY = 2, tX = 2, tA = 2, solution = solution4x6_2_2_2_2_path },
		new solutionPath { tID=2, tY = 2, tX = 3, tA = 1, solution = solution4x6_2_2_3_1_path },
		new solutionPath { tID=2, tY = 2, tX = 3, tA = 3, solution = solution4x6_2_2_3_3_path },
		new solutionPath { tID=2, tY = 2, tX = 4, tA = 0, solution = solution4x6_2_2_4_0_path },
		new solutionPath { tID=2, tY = 2, tX = 4, tA = 2, solution = solution4x6_2_2_4_2_path },
		new solutionPath { tID=2, tY = 2, tX = 5, tA = 1, solution = solution4x6_2_2_5_1_path },
		new solutionPath { tID=2, tY = 2, tX = 5, tA = 3, solution = solution4x6_2_2_5_3_path },
		new solutionPath { tID=2, tY = 3, tX = 0, tA = 1, solution = solution4x6_2_3_0_1_path },
		new solutionPath { tID=2, tY = 3, tX = 0, tA = 3, solution = solution4x6_2_3_0_3_path },
		new solutionPath { tID=2, tY = 3, tX = 1, tA = 0, solution = solution4x6_2_3_1_0_path },
		new solutionPath { tID=2, tY = 3, tX = 1, tA = 2, solution = solution4x6_2_3_1_2_path },
		new solutionPath { tID=2, tY = 3, tX = 2, tA = 1, solution = solution4x6_2_3_2_1_path },
		new solutionPath { tID=2, tY = 3, tX = 2, tA = 3, solution = solution4x6_2_3_2_3_path },
		new solutionPath { tID=2, tY = 3, tX = 3, tA = 0, solution = solution4x6_2_3_3_0_path },
		new solutionPath { tID=2, tY = 3, tX = 3, tA = 2, solution = solution4x6_2_3_3_2_path },
		new solutionPath { tID=2, tY = 3, tX = 4, tA = 1, solution = solution4x6_2_3_4_1_path },
		new solutionPath { tID=2, tY = 3, tX = 4, tA = 3, solution = solution4x6_2_3_4_3_path },
		new solutionPath { tID=2, tY = 3, tX = 5, tA = 0, solution = solution4x6_2_3_5_0_path },
		new solutionPath { tID=2, tY = 3, tX = 5, tA = 2, solution = solution4x6_2_3_5_2_path },
		new solutionPath { tID=3, tY = 0, tX = 3, tA = 2, solution = solution4x6_3_0_3_2_path },
		new solutionPath { tID=3, tY = 0, tX = 4, tA = 1, solution = solution4x6_3_0_4_1_path },
		new solutionPath { tID=3, tY = 0, tX = 4, tA = 3, solution = solution4x6_3_0_4_3_path },
		new solutionPath { tID=3, tY = 0, tX = 5, tA = 0, solution = solution4x6_3_0_5_0_path },
		new solutionPath { tID=3, tY = 0, tX = 5, tA = 2, solution = solution4x6_3_0_5_2_path },
		new solutionPath { tID=3, tY = 1, tX = 0, tA = 0, solution = solution4x6_3_1_0_0_path },
		new solutionPath { tID=3, tY = 1, tX = 0, tA = 2, solution = solution4x6_3_1_0_2_path },
		new solutionPath { tID=3, tY = 1, tX = 1, tA = 1, solution = solution4x6_3_1_1_1_path },
		new solutionPath { tID=3, tY = 1, tX = 1, tA = 3, solution = solution4x6_3_1_1_3_path },
		new solutionPath { tID=3, tY = 1, tX = 2, tA = 0, solution = solution4x6_3_1_2_0_path },
		new solutionPath { tID=3, tY = 1, tX = 2, tA = 2, solution = solution4x6_3_1_2_2_path },
		new solutionPath { tID=3, tY = 1, tX = 3, tA = 1, solution = solution4x6_3_1_3_1_path },
		new solutionPath { tID=3, tY = 1, tX = 3, tA = 3, solution = solution4x6_3_1_3_3_path },
		new solutionPath { tID=3, tY = 1, tX = 4, tA = 0, solution = solution4x6_3_1_4_0_path },
		new solutionPath { tID=3, tY = 1, tX = 4, tA = 2, solution = solution4x6_3_1_4_2_path },
		new solutionPath { tID=3, tY = 1, tX = 5, tA = 1, solution = solution4x6_3_1_5_1_path },
		new solutionPath { tID=3, tY = 1, tX = 5, tA = 3, solution = solution4x6_3_1_5_3_path },
		new solutionPath { tID=3, tY = 2, tX = 0, tA = 1, solution = solution4x6_3_2_0_1_path },
		new solutionPath { tID=3, tY = 2, tX = 0, tA = 3, solution = solution4x6_3_2_0_3_path },
		new solutionPath { tID=3, tY = 2, tX = 1, tA = 0, solution = solution4x6_3_2_1_0_path },
		new solutionPath { tID=3, tY = 2, tX = 1, tA = 2, solution = solution4x6_3_2_1_2_path },
		new solutionPath { tID=3, tY = 2, tX = 2, tA = 1, solution = solution4x6_3_2_2_1_path },
		new solutionPath { tID=3, tY = 2, tX = 2, tA = 3, solution = solution4x6_3_2_2_3_path },
		new solutionPath { tID=3, tY = 2, tX = 3, tA = 0, solution = solution4x6_3_2_3_0_path },
		new solutionPath { tID=3, tY = 2, tX = 3, tA = 2, solution = solution4x6_3_2_3_2_path },
		new solutionPath { tID=3, tY = 2, tX = 4, tA = 1, solution = solution4x6_3_2_4_1_path },
		new solutionPath { tID=3, tY = 2, tX = 4, tA = 3, solution = solution4x6_3_2_4_3_path },
		new solutionPath { tID=3, tY = 2, tX = 5, tA = 0, solution = solution4x6_3_2_5_0_path },
		new solutionPath { tID=3, tY = 2, tX = 5, tA = 2, solution = solution4x6_3_2_5_2_path },
		new solutionPath { tID=3, tY = 3, tX = 0, tA = 0, solution = solution4x6_3_3_0_0_path },
		new solutionPath { tID=3, tY = 3, tX = 0, tA = 2, solution = solution4x6_3_3_0_2_path },
		new solutionPath { tID=3, tY = 3, tX = 1, tA = 1, solution = solution4x6_3_3_1_1_path },
		new solutionPath { tID=3, tY = 3, tX = 1, tA = 3, solution = solution4x6_3_3_1_3_path },
		new solutionPath { tID=3, tY = 3, tX = 2, tA = 0, solution = solution4x6_3_3_2_0_path },
		new solutionPath { tID=3, tY = 3, tX = 2, tA = 2, solution = solution4x6_3_3_2_2_path },
		new solutionPath { tID=3, tY = 3, tX = 3, tA = 1, solution = solution4x6_3_3_3_1_path },
		new solutionPath { tID=3, tY = 3, tX = 3, tA = 3, solution = solution4x6_3_3_3_3_path },
		new solutionPath { tID=3, tY = 3, tX = 4, tA = 0, solution = solution4x6_3_3_4_0_path },
		new solutionPath { tID=3, tY = 3, tX = 4, tA = 2, solution = solution4x6_3_3_4_2_path },
		new solutionPath { tID=3, tY = 3, tX = 5, tA = 1, solution = solution4x6_3_3_5_1_path },
		new solutionPath { tID=3, tY = 3, tX = 5, tA = 3, solution = solution4x6_3_3_5_3_path },
		new solutionPath { tID=4, tY = 0, tX = 4, tA = 2, solution = solution4x6_4_0_4_2_path },
		new solutionPath { tID=4, tY = 0, tX = 5, tA = 1, solution = solution4x6_4_0_5_1_path },
		new solutionPath { tID=4, tY = 0, tX = 5, tA = 3, solution = solution4x6_4_0_5_3_path },
		new solutionPath { tID=4, tY = 1, tX = 0, tA = 1, solution = solution4x6_4_1_0_1_path },
		new solutionPath { tID=4, tY = 1, tX = 0, tA = 3, solution = solution4x6_4_1_0_3_path },
		new solutionPath { tID=4, tY = 1, tX = 1, tA = 0, solution = solution4x6_4_1_1_0_path },
		new solutionPath { tID=4, tY = 1, tX = 1, tA = 2, solution = solution4x6_4_1_1_2_path },
		new solutionPath { tID=4, tY = 1, tX = 2, tA = 1, solution = solution4x6_4_1_2_1_path },
		new solutionPath { tID=4, tY = 1, tX = 2, tA = 3, solution = solution4x6_4_1_2_3_path },
		new solutionPath { tID=4, tY = 1, tX = 3, tA = 0, solution = solution4x6_4_1_3_0_path },
		new solutionPath { tID=4, tY = 1, tX = 3, tA = 2, solution = solution4x6_4_1_3_2_path },
		new solutionPath { tID=4, tY = 1, tX = 4, tA = 1, solution = solution4x6_4_1_4_1_path },
		new solutionPath { tID=4, tY = 1, tX = 4, tA = 3, solution = solution4x6_4_1_4_3_path },
		new solutionPath { tID=4, tY = 1, tX = 5, tA = 0, solution = solution4x6_4_1_5_0_path },
		new solutionPath { tID=4, tY = 1, tX = 5, tA = 2, solution = solution4x6_4_1_5_2_path },
		new solutionPath { tID=4, tY = 2, tX = 0, tA = 0, solution = solution4x6_4_2_0_0_path },
		new solutionPath { tID=4, tY = 2, tX = 0, tA = 2, solution = solution4x6_4_2_0_2_path },
		new solutionPath { tID=4, tY = 2, tX = 1, tA = 1, solution = solution4x6_4_2_1_1_path },
		new solutionPath { tID=4, tY = 2, tX = 1, tA = 3, solution = solution4x6_4_2_1_3_path },
		new solutionPath { tID=4, tY = 2, tX = 2, tA = 0, solution = solution4x6_4_2_2_0_path },
		new solutionPath { tID=4, tY = 2, tX = 2, tA = 2, solution = solution4x6_4_2_2_2_path },
		new solutionPath { tID=4, tY = 2, tX = 3, tA = 1, solution = solution4x6_4_2_3_1_path },
		new solutionPath { tID=4, tY = 2, tX = 3, tA = 3, solution = solution4x6_4_2_3_3_path },
		new solutionPath { tID=4, tY = 2, tX = 4, tA = 0, solution = solution4x6_4_2_4_0_path },
		new solutionPath { tID=4, tY = 2, tX = 4, tA = 2, solution = solution4x6_4_2_4_2_path },
		new solutionPath { tID=4, tY = 2, tX = 5, tA = 1, solution = solution4x6_4_2_5_1_path },
		new solutionPath { tID=4, tY = 2, tX = 5, tA = 3, solution = solution4x6_4_2_5_3_path },
		new solutionPath { tID=4, tY = 3, tX = 0, tA = 1, solution = solution4x6_4_3_0_1_path },
		new solutionPath { tID=4, tY = 3, tX = 0, tA = 3, solution = solution4x6_4_3_0_3_path },
		new solutionPath { tID=4, tY = 3, tX = 1, tA = 0, solution = solution4x6_4_3_1_0_path },
		new solutionPath { tID=4, tY = 3, tX = 1, tA = 2, solution = solution4x6_4_3_1_2_path },
		new solutionPath { tID=4, tY = 3, tX = 2, tA = 1, solution = solution4x6_4_3_2_1_path },
		new solutionPath { tID=4, tY = 3, tX = 2, tA = 3, solution = solution4x6_4_3_2_3_path },
		new solutionPath { tID=4, tY = 3, tX = 3, tA = 0, solution = solution4x6_4_3_3_0_path },
		new solutionPath { tID=4, tY = 3, tX = 3, tA = 2, solution = solution4x6_4_3_3_2_path },
		new solutionPath { tID=4, tY = 3, tX = 4, tA = 1, solution = solution4x6_4_3_4_1_path },
		new solutionPath { tID=4, tY = 3, tX = 4, tA = 3, solution = solution4x6_4_3_4_3_path },
		new solutionPath { tID=4, tY = 3, tX = 5, tA = 0, solution = solution4x6_4_3_5_0_path },
		new solutionPath { tID=4, tY = 3, tX = 5, tA = 2, solution = solution4x6_4_3_5_2_path },
		new solutionPath { tID=5, tY = 0, tX = 5, tA = 2, solution = solution4x6_5_0_5_2_path },
		new solutionPath { tID=5, tY = 1, tX = 0, tA = 0, solution = solution4x6_5_1_0_0_path },
		new solutionPath { tID=5, tY = 1, tX = 0, tA = 2, solution = solution4x6_5_1_0_2_path },
		new solutionPath { tID=5, tY = 1, tX = 1, tA = 1, solution = solution4x6_5_1_1_1_path },
		new solutionPath { tID=5, tY = 1, tX = 1, tA = 3, solution = solution4x6_5_1_1_3_path },
		new solutionPath { tID=5, tY = 1, tX = 2, tA = 0, solution = solution4x6_5_1_2_0_path },
		new solutionPath { tID=5, tY = 1, tX = 2, tA = 2, solution = solution4x6_5_1_2_2_path },
		new solutionPath { tID=5, tY = 1, tX = 3, tA = 1, solution = solution4x6_5_1_3_1_path },
		new solutionPath { tID=5, tY = 1, tX = 3, tA = 3, solution = solution4x6_5_1_3_3_path },
		new solutionPath { tID=5, tY = 1, tX = 4, tA = 0, solution = solution4x6_5_1_4_0_path },
		new solutionPath { tID=5, tY = 1, tX = 4, tA = 2, solution = solution4x6_5_1_4_2_path },
		new solutionPath { tID=5, tY = 1, tX = 5, tA = 1, solution = solution4x6_5_1_5_1_path },
		new solutionPath { tID=5, tY = 1, tX = 5, tA = 3, solution = solution4x6_5_1_5_3_path },
		new solutionPath { tID=5, tY = 2, tX = 0, tA = 1, solution = solution4x6_5_2_0_1_path },
		new solutionPath { tID=5, tY = 2, tX = 0, tA = 3, solution = solution4x6_5_2_0_3_path },
		new solutionPath { tID=5, tY = 2, tX = 1, tA = 0, solution = solution4x6_5_2_1_0_path },
		new solutionPath { tID=5, tY = 2, tX = 1, tA = 2, solution = solution4x6_5_2_1_2_path },
		new solutionPath { tID=5, tY = 2, tX = 2, tA = 1, solution = solution4x6_5_2_2_1_path },
		new solutionPath { tID=5, tY = 2, tX = 2, tA = 3, solution = solution4x6_5_2_2_3_path },
		new solutionPath { tID=5, tY = 2, tX = 3, tA = 0, solution = solution4x6_5_2_3_0_path },
		new solutionPath { tID=5, tY = 2, tX = 3, tA = 2, solution = solution4x6_5_2_3_2_path },
		new solutionPath { tID=5, tY = 2, tX = 4, tA = 1, solution = solution4x6_5_2_4_1_path },
		new solutionPath { tID=5, tY = 2, tX = 4, tA = 3, solution = solution4x6_5_2_4_3_path },
		new solutionPath { tID=5, tY = 2, tX = 5, tA = 0, solution = solution4x6_5_2_5_0_path },
		new solutionPath { tID=5, tY = 2, tX = 5, tA = 2, solution = solution4x6_5_2_5_2_path },
		new solutionPath { tID=5, tY = 3, tX = 0, tA = 0, solution = solution4x6_5_3_0_0_path },
		new solutionPath { tID=5, tY = 3, tX = 0, tA = 2, solution = solution4x6_5_3_0_2_path },
		new solutionPath { tID=5, tY = 3, tX = 1, tA = 1, solution = solution4x6_5_3_1_1_path },
		new solutionPath { tID=5, tY = 3, tX = 1, tA = 3, solution = solution4x6_5_3_1_3_path },
		new solutionPath { tID=5, tY = 3, tX = 2, tA = 0, solution = solution4x6_5_3_2_0_path },
		new solutionPath { tID=5, tY = 3, tX = 2, tA = 2, solution = solution4x6_5_3_2_2_path },
		new solutionPath { tID=5, tY = 3, tX = 3, tA = 1, solution = solution4x6_5_3_3_1_path },
		new solutionPath { tID=5, tY = 3, tX = 3, tA = 3, solution = solution4x6_5_3_3_3_path },
		new solutionPath { tID=5, tY = 3, tX = 4, tA = 0, solution = solution4x6_5_3_4_0_path },
		new solutionPath { tID=5, tY = 3, tX = 4, tA = 2, solution = solution4x6_5_3_4_2_path },
		new solutionPath { tID=5, tY = 3, tX = 5, tA = 1, solution = solution4x6_5_3_5_1_path },
		new solutionPath { tID=5, tY = 3, tX = 5, tA = 3, solution = solution4x6_5_3_5_3_path },
		new solutionPath { tID=6, tY = 1, tX = 0, tA = 2, solution = solution4x6_6_1_0_2_path },
		new solutionPath { tID=6, tY = 1, tX = 1, tA = 1, solution = solution4x6_6_1_1_1_path },
		new solutionPath { tID=6, tY = 1, tX = 1, tA = 3, solution = solution4x6_6_1_1_3_path },
		new solutionPath { tID=6, tY = 1, tX = 2, tA = 0, solution = solution4x6_6_1_2_0_path },
		new solutionPath { tID=6, tY = 1, tX = 2, tA = 2, solution = solution4x6_6_1_2_2_path },
		new solutionPath { tID=6, tY = 1, tX = 3, tA = 1, solution = solution4x6_6_1_3_1_path },
		new solutionPath { tID=6, tY = 1, tX = 3, tA = 3, solution = solution4x6_6_1_3_3_path },
		new solutionPath { tID=6, tY = 1, tX = 4, tA = 0, solution = solution4x6_6_1_4_0_path },
		new solutionPath { tID=6, tY = 1, tX = 4, tA = 2, solution = solution4x6_6_1_4_2_path },
		new solutionPath { tID=6, tY = 1, tX = 5, tA = 1, solution = solution4x6_6_1_5_1_path },
		new solutionPath { tID=6, tY = 1, tX = 5, tA = 3, solution = solution4x6_6_1_5_3_path },
		new solutionPath { tID=6, tY = 2, tX = 0, tA = 1, solution = solution4x6_6_2_0_1_path },
		new solutionPath { tID=6, tY = 2, tX = 0, tA = 3, solution = solution4x6_6_2_0_3_path },
		new solutionPath { tID=6, tY = 2, tX = 1, tA = 0, solution = solution4x6_6_2_1_0_path },
		new solutionPath { tID=6, tY = 2, tX = 1, tA = 2, solution = solution4x6_6_2_1_2_path },
		new solutionPath { tID=6, tY = 2, tX = 2, tA = 1, solution = solution4x6_6_2_2_1_path },
		new solutionPath { tID=6, tY = 2, tX = 2, tA = 3, solution = solution4x6_6_2_2_3_path },
		new solutionPath { tID=6, tY = 2, tX = 3, tA = 0, solution = solution4x6_6_2_3_0_path },
		new solutionPath { tID=6, tY = 2, tX = 3, tA = 2, solution = solution4x6_6_2_3_2_path },
		new solutionPath { tID=6, tY = 2, tX = 4, tA = 1, solution = solution4x6_6_2_4_1_path },
		new solutionPath { tID=6, tY = 2, tX = 4, tA = 3, solution = solution4x6_6_2_4_3_path },
		new solutionPath { tID=6, tY = 2, tX = 5, tA = 0, solution = solution4x6_6_2_5_0_path },
		new solutionPath { tID=6, tY = 2, tX = 5, tA = 2, solution = solution4x6_6_2_5_2_path },
		new solutionPath { tID=6, tY = 3, tX = 0, tA = 0, solution = solution4x6_6_3_0_0_path },
		new solutionPath { tID=6, tY = 3, tX = 0, tA = 2, solution = solution4x6_6_3_0_2_path },
		new solutionPath { tID=6, tY = 3, tX = 1, tA = 1, solution = solution4x6_6_3_1_1_path },
		new solutionPath { tID=6, tY = 3, tX = 1, tA = 3, solution = solution4x6_6_3_1_3_path },
		new solutionPath { tID=6, tY = 3, tX = 2, tA = 0, solution = solution4x6_6_3_2_0_path },
		new solutionPath { tID=6, tY = 3, tX = 2, tA = 2, solution = solution4x6_6_3_2_2_path },
		new solutionPath { tID=6, tY = 3, tX = 3, tA = 1, solution = solution4x6_6_3_3_1_path },
		new solutionPath { tID=6, tY = 3, tX = 3, tA = 3, solution = solution4x6_6_3_3_3_path },
		new solutionPath { tID=6, tY = 3, tX = 4, tA = 0, solution = solution4x6_6_3_4_0_path },
		new solutionPath { tID=6, tY = 3, tX = 4, tA = 2, solution = solution4x6_6_3_4_2_path },
		new solutionPath { tID=6, tY = 3, tX = 5, tA = 1, solution = solution4x6_6_3_5_1_path },
		new solutionPath { tID=6, tY = 3, tX = 5, tA = 3, solution = solution4x6_6_3_5_3_path },
		new solutionPath { tID=7, tY = 1, tX = 1, tA = 2, solution = solution4x6_7_1_1_2_path },
		new solutionPath { tID=7, tY = 1, tX = 2, tA = 1, solution = solution4x6_7_1_2_1_path },
		new solutionPath { tID=7, tY = 1, tX = 2, tA = 3, solution = solution4x6_7_1_2_3_path },
		new solutionPath { tID=7, tY = 1, tX = 3, tA = 0, solution = solution4x6_7_1_3_0_path },
		new solutionPath { tID=7, tY = 1, tX = 3, tA = 2, solution = solution4x6_7_1_3_2_path },
		new solutionPath { tID=7, tY = 1, tX = 4, tA = 1, solution = solution4x6_7_1_4_1_path },
		new solutionPath { tID=7, tY = 1, tX = 4, tA = 3, solution = solution4x6_7_1_4_3_path },
		new solutionPath { tID=7, tY = 1, tX = 5, tA = 0, solution = solution4x6_7_1_5_0_path },
		new solutionPath { tID=7, tY = 1, tX = 5, tA = 2, solution = solution4x6_7_1_5_2_path },
		new solutionPath { tID=7, tY = 2, tX = 0, tA = 0, solution = solution4x6_7_2_0_0_path },
		new solutionPath { tID=7, tY = 2, tX = 0, tA = 2, solution = solution4x6_7_2_0_2_path },
		new solutionPath { tID=7, tY = 2, tX = 1, tA = 1, solution = solution4x6_7_2_1_1_path },
		new solutionPath { tID=7, tY = 2, tX = 1, tA = 3, solution = solution4x6_7_2_1_3_path },
		new solutionPath { tID=7, tY = 2, tX = 2, tA = 0, solution = solution4x6_7_2_2_0_path },
		new solutionPath { tID=7, tY = 2, tX = 2, tA = 2, solution = solution4x6_7_2_2_2_path },
		new solutionPath { tID=7, tY = 2, tX = 3, tA = 1, solution = solution4x6_7_2_3_1_path },
		new solutionPath { tID=7, tY = 2, tX = 3, tA = 3, solution = solution4x6_7_2_3_3_path },
		new solutionPath { tID=7, tY = 2, tX = 4, tA = 0, solution = solution4x6_7_2_4_0_path },
		new solutionPath { tID=7, tY = 2, tX = 4, tA = 2, solution = solution4x6_7_2_4_2_path },
		new solutionPath { tID=7, tY = 2, tX = 5, tA = 1, solution = solution4x6_7_2_5_1_path },
		new solutionPath { tID=7, tY = 2, tX = 5, tA = 3, solution = solution4x6_7_2_5_3_path },
		new solutionPath { tID=7, tY = 3, tX = 0, tA = 1, solution = solution4x6_7_3_0_1_path },
		new solutionPath { tID=7, tY = 3, tX = 0, tA = 3, solution = solution4x6_7_3_0_3_path },
		new solutionPath { tID=7, tY = 3, tX = 1, tA = 0, solution = solution4x6_7_3_1_0_path },
		new solutionPath { tID=7, tY = 3, tX = 1, tA = 2, solution = solution4x6_7_3_1_2_path },
		new solutionPath { tID=7, tY = 3, tX = 2, tA = 1, solution = solution4x6_7_3_2_1_path },
		new solutionPath { tID=7, tY = 3, tX = 2, tA = 3, solution = solution4x6_7_3_2_3_path },
		new solutionPath { tID=7, tY = 3, tX = 3, tA = 0, solution = solution4x6_7_3_3_0_path },
		new solutionPath { tID=7, tY = 3, tX = 3, tA = 2, solution = solution4x6_7_3_3_2_path },
		new solutionPath { tID=7, tY = 3, tX = 4, tA = 1, solution = solution4x6_7_3_4_1_path },
		new solutionPath { tID=7, tY = 3, tX = 4, tA = 3, solution = solution4x6_7_3_4_3_path },
		new solutionPath { tID=7, tY = 3, tX = 5, tA = 0, solution = solution4x6_7_3_5_0_path },
		new solutionPath { tID=7, tY = 3, tX = 5, tA = 2, solution = solution4x6_7_3_5_2_path },
		new solutionPath { tID=8, tY = 1, tX = 2, tA = 2, solution = solution4x6_8_1_2_2_path },
		new solutionPath { tID=8, tY = 1, tX = 3, tA = 1, solution = solution4x6_8_1_3_1_path },
		new solutionPath { tID=8, tY = 1, tX = 3, tA = 3, solution = solution4x6_8_1_3_3_path },
		new solutionPath { tID=8, tY = 1, tX = 4, tA = 0, solution = solution4x6_8_1_4_0_path },
		new solutionPath { tID=8, tY = 1, tX = 4, tA = 2, solution = solution4x6_8_1_4_2_path },
		new solutionPath { tID=8, tY = 1, tX = 5, tA = 1, solution = solution4x6_8_1_5_1_path },
		new solutionPath { tID=8, tY = 1, tX = 5, tA = 3, solution = solution4x6_8_1_5_3_path },
		new solutionPath { tID=8, tY = 2, tX = 0, tA = 1, solution = solution4x6_8_2_0_1_path },
		new solutionPath { tID=8, tY = 2, tX = 0, tA = 3, solution = solution4x6_8_2_0_3_path },
		new solutionPath { tID=8, tY = 2, tX = 1, tA = 0, solution = solution4x6_8_2_1_0_path },
		new solutionPath { tID=8, tY = 2, tX = 1, tA = 2, solution = solution4x6_8_2_1_2_path },
		new solutionPath { tID=8, tY = 2, tX = 2, tA = 1, solution = solution4x6_8_2_2_1_path },
		new solutionPath { tID=8, tY = 2, tX = 2, tA = 3, solution = solution4x6_8_2_2_3_path },
		new solutionPath { tID=8, tY = 2, tX = 3, tA = 0, solution = solution4x6_8_2_3_0_path },
		new solutionPath { tID=8, tY = 2, tX = 3, tA = 2, solution = solution4x6_8_2_3_2_path },
		new solutionPath { tID=8, tY = 2, tX = 4, tA = 1, solution = solution4x6_8_2_4_1_path },
		new solutionPath { tID=8, tY = 2, tX = 4, tA = 3, solution = solution4x6_8_2_4_3_path },
		new solutionPath { tID=8, tY = 2, tX = 5, tA = 0, solution = solution4x6_8_2_5_0_path },
		new solutionPath { tID=8, tY = 2, tX = 5, tA = 2, solution = solution4x6_8_2_5_2_path },
		new solutionPath { tID=8, tY = 3, tX = 0, tA = 0, solution = solution4x6_8_3_0_0_path },
		new solutionPath { tID=8, tY = 3, tX = 0, tA = 2, solution = solution4x6_8_3_0_2_path },
		new solutionPath { tID=8, tY = 3, tX = 1, tA = 1, solution = solution4x6_8_3_1_1_path },
		new solutionPath { tID=8, tY = 3, tX = 1, tA = 3, solution = solution4x6_8_3_1_3_path },
		new solutionPath { tID=8, tY = 3, tX = 2, tA = 0, solution = solution4x6_8_3_2_0_path },
		new solutionPath { tID=8, tY = 3, tX = 2, tA = 2, solution = solution4x6_8_3_2_2_path },
		new solutionPath { tID=8, tY = 3, tX = 3, tA = 1, solution = solution4x6_8_3_3_1_path },
		new solutionPath { tID=8, tY = 3, tX = 3, tA = 3, solution = solution4x6_8_3_3_3_path },
		new solutionPath { tID=8, tY = 3, tX = 4, tA = 0, solution = solution4x6_8_3_4_0_path },
		new solutionPath { tID=8, tY = 3, tX = 4, tA = 2, solution = solution4x6_8_3_4_2_path },
		new solutionPath { tID=8, tY = 3, tX = 5, tA = 1, solution = solution4x6_8_3_5_1_path },
		new solutionPath { tID=8, tY = 3, tX = 5, tA = 3, solution = solution4x6_8_3_5_3_path },
		new solutionPath { tID=9, tY = 1, tX = 3, tA = 2, solution = solution4x6_9_1_3_2_path },
		new solutionPath { tID=9, tY = 1, tX = 4, tA = 1, solution = solution4x6_9_1_4_1_path },
		new solutionPath { tID=9, tY = 1, tX = 4, tA = 3, solution = solution4x6_9_1_4_3_path },
		new solutionPath { tID=9, tY = 1, tX = 5, tA = 0, solution = solution4x6_9_1_5_0_path },
		new solutionPath { tID=9, tY = 1, tX = 5, tA = 2, solution = solution4x6_9_1_5_2_path },
		new solutionPath { tID=9, tY = 2, tX = 0, tA = 0, solution = solution4x6_9_2_0_0_path },
		new solutionPath { tID=9, tY = 2, tX = 0, tA = 2, solution = solution4x6_9_2_0_2_path },
		new solutionPath { tID=9, tY = 2, tX = 1, tA = 1, solution = solution4x6_9_2_1_1_path },
		new solutionPath { tID=9, tY = 2, tX = 1, tA = 3, solution = solution4x6_9_2_1_3_path },
		new solutionPath { tID=9, tY = 2, tX = 2, tA = 0, solution = solution4x6_9_2_2_0_path },
		new solutionPath { tID=9, tY = 2, tX = 2, tA = 2, solution = solution4x6_9_2_2_2_path },
		new solutionPath { tID=9, tY = 2, tX = 3, tA = 1, solution = solution4x6_9_2_3_1_path },
		new solutionPath { tID=9, tY = 2, tX = 3, tA = 3, solution = solution4x6_9_2_3_3_path },
		new solutionPath { tID=9, tY = 2, tX = 4, tA = 0, solution = solution4x6_9_2_4_0_path },
		new solutionPath { tID=9, tY = 2, tX = 4, tA = 2, solution = solution4x6_9_2_4_2_path },
		new solutionPath { tID=9, tY = 2, tX = 5, tA = 1, solution = solution4x6_9_2_5_1_path },
		new solutionPath { tID=9, tY = 2, tX = 5, tA = 3, solution = solution4x6_9_2_5_3_path },
		new solutionPath { tID=9, tY = 3, tX = 0, tA = 1, solution = solution4x6_9_3_0_1_path },
		new solutionPath { tID=9, tY = 3, tX = 0, tA = 3, solution = solution4x6_9_3_0_3_path },
		new solutionPath { tID=9, tY = 3, tX = 1, tA = 0, solution = solution4x6_9_3_1_0_path },
		new solutionPath { tID=9, tY = 3, tX = 1, tA = 2, solution = solution4x6_9_3_1_2_path },
		new solutionPath { tID=9, tY = 3, tX = 2, tA = 1, solution = solution4x6_9_3_2_1_path },
		new solutionPath { tID=9, tY = 3, tX = 2, tA = 3, solution = solution4x6_9_3_2_3_path },
		new solutionPath { tID=9, tY = 3, tX = 3, tA = 0, solution = solution4x6_9_3_3_0_path },
		new solutionPath { tID=9, tY = 3, tX = 3, tA = 2, solution = solution4x6_9_3_3_2_path },
		new solutionPath { tID=9, tY = 3, tX = 4, tA = 1, solution = solution4x6_9_3_4_1_path },
		new solutionPath { tID=9, tY = 3, tX = 4, tA = 3, solution = solution4x6_9_3_4_3_path },
		new solutionPath { tID=9, tY = 3, tX = 5, tA = 0, solution = solution4x6_9_3_5_0_path },
		new solutionPath { tID=9, tY = 3, tX = 5, tA = 2, solution = solution4x6_9_3_5_2_path },
		new solutionPath { tID=10, tY = 1, tX = 4, tA = 2, solution = solution4x6_10_1_4_2_path },
		new solutionPath { tID=10, tY = 1, tX = 5, tA = 1, solution = solution4x6_10_1_5_1_path },
		new solutionPath { tID=10, tY = 1, tX = 5, tA = 3, solution = solution4x6_10_1_5_3_path },
		new solutionPath { tID=10, tY = 2, tX = 0, tA = 1, solution = solution4x6_10_2_0_1_path },
		new solutionPath { tID=10, tY = 2, tX = 0, tA = 3, solution = solution4x6_10_2_0_3_path },
		new solutionPath { tID=10, tY = 2, tX = 1, tA = 0, solution = solution4x6_10_2_1_0_path },
		new solutionPath { tID=10, tY = 2, tX = 1, tA = 2, solution = solution4x6_10_2_1_2_path },
		new solutionPath { tID=10, tY = 2, tX = 2, tA = 1, solution = solution4x6_10_2_2_1_path },
		new solutionPath { tID=10, tY = 2, tX = 2, tA = 3, solution = solution4x6_10_2_2_3_path },
		new solutionPath { tID=10, tY = 2, tX = 3, tA = 0, solution = solution4x6_10_2_3_0_path },
		new solutionPath { tID=10, tY = 2, tX = 3, tA = 2, solution = solution4x6_10_2_3_2_path },
		new solutionPath { tID=10, tY = 2, tX = 4, tA = 1, solution = solution4x6_10_2_4_1_path },
		new solutionPath { tID=10, tY = 2, tX = 4, tA = 3, solution = solution4x6_10_2_4_3_path },
		new solutionPath { tID=10, tY = 2, tX = 5, tA = 0, solution = solution4x6_10_2_5_0_path },
		new solutionPath { tID=10, tY = 2, tX = 5, tA = 2, solution = solution4x6_10_2_5_2_path },
		new solutionPath { tID=10, tY = 3, tX = 0, tA = 0, solution = solution4x6_10_3_0_0_path },
		new solutionPath { tID=10, tY = 3, tX = 0, tA = 2, solution = solution4x6_10_3_0_2_path },
		new solutionPath { tID=10, tY = 3, tX = 1, tA = 1, solution = solution4x6_10_3_1_1_path },
		new solutionPath { tID=10, tY = 3, tX = 1, tA = 3, solution = solution4x6_10_3_1_3_path },
		new solutionPath { tID=10, tY = 3, tX = 2, tA = 0, solution = solution4x6_10_3_2_0_path },
		new solutionPath { tID=10, tY = 3, tX = 2, tA = 2, solution = solution4x6_10_3_2_2_path },
		new solutionPath { tID=10, tY = 3, tX = 3, tA = 1, solution = solution4x6_10_3_3_1_path },
		new solutionPath { tID=10, tY = 3, tX = 3, tA = 3, solution = solution4x6_10_3_3_3_path },
		new solutionPath { tID=10, tY = 3, tX = 4, tA = 0, solution = solution4x6_10_3_4_0_path },
		new solutionPath { tID=10, tY = 3, tX = 4, tA = 2, solution = solution4x6_10_3_4_2_path },
		new solutionPath { tID=10, tY = 3, tX = 5, tA = 1, solution = solution4x6_10_3_5_1_path },
		new solutionPath { tID=10, tY = 3, tX = 5, tA = 3, solution = solution4x6_10_3_5_3_path },
		new solutionPath { tID=11, tY = 1, tX = 5, tA = 2, solution = solution4x6_11_1_5_2_path },
		new solutionPath { tID=11, tY = 2, tX = 0, tA = 0, solution = solution4x6_11_2_0_0_path },
		new solutionPath { tID=11, tY = 2, tX = 0, tA = 2, solution = solution4x6_11_2_0_2_path },
		new solutionPath { tID=11, tY = 2, tX = 1, tA = 1, solution = solution4x6_11_2_1_1_path },
		new solutionPath { tID=11, tY = 2, tX = 1, tA = 3, solution = solution4x6_11_2_1_3_path },
		new solutionPath { tID=11, tY = 2, tX = 2, tA = 0, solution = solution4x6_11_2_2_0_path },
		new solutionPath { tID=11, tY = 2, tX = 2, tA = 2, solution = solution4x6_11_2_2_2_path },
		new solutionPath { tID=11, tY = 2, tX = 3, tA = 1, solution = solution4x6_11_2_3_1_path },
		new solutionPath { tID=11, tY = 2, tX = 3, tA = 3, solution = solution4x6_11_2_3_3_path },
		new solutionPath { tID=11, tY = 2, tX = 4, tA = 0, solution = solution4x6_11_2_4_0_path },
		new solutionPath { tID=11, tY = 2, tX = 4, tA = 2, solution = solution4x6_11_2_4_2_path },
		new solutionPath { tID=11, tY = 2, tX = 5, tA = 1, solution = solution4x6_11_2_5_1_path },
		new solutionPath { tID=11, tY = 2, tX = 5, tA = 3, solution = solution4x6_11_2_5_3_path },
		new solutionPath { tID=11, tY = 3, tX = 0, tA = 1, solution = solution4x6_11_3_0_1_path },
		new solutionPath { tID=11, tY = 3, tX = 0, tA = 3, solution = solution4x6_11_3_0_3_path },
		new solutionPath { tID=11, tY = 3, tX = 1, tA = 0, solution = solution4x6_11_3_1_0_path },
		new solutionPath { tID=11, tY = 3, tX = 1, tA = 2, solution = solution4x6_11_3_1_2_path },
		new solutionPath { tID=11, tY = 3, tX = 2, tA = 1, solution = solution4x6_11_3_2_1_path },
		new solutionPath { tID=11, tY = 3, tX = 2, tA = 3, solution = solution4x6_11_3_2_3_path },
		new solutionPath { tID=11, tY = 3, tX = 3, tA = 0, solution = solution4x6_11_3_3_0_path },
		new solutionPath { tID=11, tY = 3, tX = 3, tA = 2, solution = solution4x6_11_3_3_2_path },
		new solutionPath { tID=11, tY = 3, tX = 4, tA = 1, solution = solution4x6_11_3_4_1_path },
		new solutionPath { tID=11, tY = 3, tX = 4, tA = 3, solution = solution4x6_11_3_4_3_path },
		new solutionPath { tID=11, tY = 3, tX = 5, tA = 0, solution = solution4x6_11_3_5_0_path },
		new solutionPath { tID=11, tY = 3, tX = 5, tA = 2, solution = solution4x6_11_3_5_2_path },
		new solutionPath { tID=12, tY = 2, tX = 0, tA = 2, solution = solution4x6_12_2_0_2_path },
		new solutionPath { tID=12, tY = 2, tX = 1, tA = 1, solution = solution4x6_12_2_1_1_path },
		new solutionPath { tID=12, tY = 2, tX = 1, tA = 3, solution = solution4x6_12_2_1_3_path },
		new solutionPath { tID=12, tY = 2, tX = 2, tA = 0, solution = solution4x6_12_2_2_0_path },
		new solutionPath { tID=12, tY = 2, tX = 2, tA = 2, solution = solution4x6_12_2_2_2_path },
		new solutionPath { tID=12, tY = 2, tX = 3, tA = 1, solution = solution4x6_12_2_3_1_path },
		new solutionPath { tID=12, tY = 2, tX = 3, tA = 3, solution = solution4x6_12_2_3_3_path },
		new solutionPath { tID=12, tY = 2, tX = 4, tA = 0, solution = solution4x6_12_2_4_0_path },
		new solutionPath { tID=12, tY = 2, tX = 4, tA = 2, solution = solution4x6_12_2_4_2_path },
		new solutionPath { tID=12, tY = 2, tX = 5, tA = 1, solution = solution4x6_12_2_5_1_path },
		new solutionPath { tID=12, tY = 2, tX = 5, tA = 3, solution = solution4x6_12_2_5_3_path },
		new solutionPath { tID=12, tY = 3, tX = 0, tA = 1, solution = solution4x6_12_3_0_1_path },
		new solutionPath { tID=12, tY = 3, tX = 0, tA = 3, solution = solution4x6_12_3_0_3_path },
		new solutionPath { tID=12, tY = 3, tX = 1, tA = 0, solution = solution4x6_12_3_1_0_path },
		new solutionPath { tID=12, tY = 3, tX = 1, tA = 2, solution = solution4x6_12_3_1_2_path },
		new solutionPath { tID=12, tY = 3, tX = 2, tA = 1, solution = solution4x6_12_3_2_1_path },
		new solutionPath { tID=12, tY = 3, tX = 2, tA = 3, solution = solution4x6_12_3_2_3_path },
		new solutionPath { tID=12, tY = 3, tX = 3, tA = 0, solution = solution4x6_12_3_3_0_path },
		new solutionPath { tID=12, tY = 3, tX = 3, tA = 2, solution = solution4x6_12_3_3_2_path },
		new solutionPath { tID=12, tY = 3, tX = 4, tA = 1, solution = solution4x6_12_3_4_1_path },
		new solutionPath { tID=12, tY = 3, tX = 4, tA = 3, solution = solution4x6_12_3_4_3_path },
		new solutionPath { tID=12, tY = 3, tX = 5, tA = 0, solution = solution4x6_12_3_5_0_path },
		new solutionPath { tID=12, tY = 3, tX = 5, tA = 2, solution = solution4x6_12_3_5_2_path },
		new solutionPath { tID=13, tY = 2, tX = 1, tA = 2, solution = solution4x6_13_2_1_2_path },
		new solutionPath { tID=13, tY = 2, tX = 2, tA = 1, solution = solution4x6_13_2_2_1_path },
		new solutionPath { tID=13, tY = 2, tX = 2, tA = 3, solution = solution4x6_13_2_2_3_path },
		new solutionPath { tID=13, tY = 2, tX = 3, tA = 0, solution = solution4x6_13_2_3_0_path },
		new solutionPath { tID=13, tY = 2, tX = 3, tA = 2, solution = solution4x6_13_2_3_2_path },
		new solutionPath { tID=13, tY = 2, tX = 4, tA = 1, solution = solution4x6_13_2_4_1_path },
		new solutionPath { tID=13, tY = 2, tX = 4, tA = 3, solution = solution4x6_13_2_4_3_path },
		new solutionPath { tID=13, tY = 2, tX = 5, tA = 0, solution = solution4x6_13_2_5_0_path },
		new solutionPath { tID=13, tY = 2, tX = 5, tA = 2, solution = solution4x6_13_2_5_2_path },
		new solutionPath { tID=13, tY = 3, tX = 0, tA = 0, solution = solution4x6_13_3_0_0_path },
		new solutionPath { tID=13, tY = 3, tX = 0, tA = 2, solution = solution4x6_13_3_0_2_path },
		new solutionPath { tID=13, tY = 3, tX = 1, tA = 1, solution = solution4x6_13_3_1_1_path },
		new solutionPath { tID=13, tY = 3, tX = 1, tA = 3, solution = solution4x6_13_3_1_3_path },
		new solutionPath { tID=13, tY = 3, tX = 2, tA = 0, solution = solution4x6_13_3_2_0_path },
		new solutionPath { tID=13, tY = 3, tX = 2, tA = 2, solution = solution4x6_13_3_2_2_path },
		new solutionPath { tID=13, tY = 3, tX = 3, tA = 1, solution = solution4x6_13_3_3_1_path },
		new solutionPath { tID=13, tY = 3, tX = 3, tA = 3, solution = solution4x6_13_3_3_3_path },
		new solutionPath { tID=13, tY = 3, tX = 4, tA = 0, solution = solution4x6_13_3_4_0_path },
		new solutionPath { tID=13, tY = 3, tX = 4, tA = 2, solution = solution4x6_13_3_4_2_path },
		new solutionPath { tID=13, tY = 3, tX = 5, tA = 1, solution = solution4x6_13_3_5_1_path },
		new solutionPath { tID=13, tY = 3, tX = 5, tA = 3, solution = solution4x6_13_3_5_3_path },
		new solutionPath { tID=14, tY = 2, tX = 2, tA = 2, solution = solution4x6_14_2_2_2_path },
		new solutionPath { tID=14, tY = 2, tX = 3, tA = 1, solution = solution4x6_14_2_3_1_path },
		new solutionPath { tID=14, tY = 2, tX = 3, tA = 3, solution = solution4x6_14_2_3_3_path },
		new solutionPath { tID=14, tY = 2, tX = 4, tA = 0, solution = solution4x6_14_2_4_0_path },
		new solutionPath { tID=14, tY = 2, tX = 4, tA = 2, solution = solution4x6_14_2_4_2_path },
		new solutionPath { tID=14, tY = 2, tX = 5, tA = 1, solution = solution4x6_14_2_5_1_path },
		new solutionPath { tID=14, tY = 2, tX = 5, tA = 3, solution = solution4x6_14_2_5_3_path },
		new solutionPath { tID=14, tY = 3, tX = 0, tA = 1, solution = solution4x6_14_3_0_1_path },
		new solutionPath { tID=14, tY = 3, tX = 0, tA = 3, solution = solution4x6_14_3_0_3_path },
		new solutionPath { tID=14, tY = 3, tX = 1, tA = 0, solution = solution4x6_14_3_1_0_path },
		new solutionPath { tID=14, tY = 3, tX = 1, tA = 2, solution = solution4x6_14_3_1_2_path },
		new solutionPath { tID=14, tY = 3, tX = 2, tA = 1, solution = solution4x6_14_3_2_1_path },
		new solutionPath { tID=14, tY = 3, tX = 2, tA = 3, solution = solution4x6_14_3_2_3_path },
		new solutionPath { tID=14, tY = 3, tX = 3, tA = 0, solution = solution4x6_14_3_3_0_path },
		new solutionPath { tID=14, tY = 3, tX = 3, tA = 2, solution = solution4x6_14_3_3_2_path },
		new solutionPath { tID=14, tY = 3, tX = 4, tA = 1, solution = solution4x6_14_3_4_1_path },
		new solutionPath { tID=14, tY = 3, tX = 4, tA = 3, solution = solution4x6_14_3_4_3_path },
		new solutionPath { tID=14, tY = 3, tX = 5, tA = 0, solution = solution4x6_14_3_5_0_path },
		new solutionPath { tID=14, tY = 3, tX = 5, tA = 2, solution = solution4x6_14_3_5_2_path },
		new solutionPath { tID=15, tY = 2, tX = 3, tA = 2, solution = solution4x6_15_2_3_2_path },
		new solutionPath { tID=15, tY = 2, tX = 4, tA = 1, solution = solution4x6_15_2_4_1_path },
		new solutionPath { tID=15, tY = 2, tX = 4, tA = 3, solution = solution4x6_15_2_4_3_path },
		new solutionPath { tID=15, tY = 2, tX = 5, tA = 0, solution = solution4x6_15_2_5_0_path },
		new solutionPath { tID=15, tY = 2, tX = 5, tA = 2, solution = solution4x6_15_2_5_2_path },
		new solutionPath { tID=15, tY = 3, tX = 0, tA = 0, solution = solution4x6_15_3_0_0_path },
		new solutionPath { tID=15, tY = 3, tX = 0, tA = 2, solution = solution4x6_15_3_0_2_path },
		new solutionPath { tID=15, tY = 3, tX = 1, tA = 1, solution = solution4x6_15_3_1_1_path },
		new solutionPath { tID=15, tY = 3, tX = 1, tA = 3, solution = solution4x6_15_3_1_3_path },
		new solutionPath { tID=15, tY = 3, tX = 2, tA = 0, solution = solution4x6_15_3_2_0_path },
		new solutionPath { tID=15, tY = 3, tX = 2, tA = 2, solution = solution4x6_15_3_2_2_path },
		new solutionPath { tID=15, tY = 3, tX = 3, tA = 1, solution = solution4x6_15_3_3_1_path },
		new solutionPath { tID=15, tY = 3, tX = 3, tA = 3, solution = solution4x6_15_3_3_3_path },
		new solutionPath { tID=15, tY = 3, tX = 4, tA = 0, solution = solution4x6_15_3_4_0_path },
		new solutionPath { tID=15, tY = 3, tX = 4, tA = 2, solution = solution4x6_15_3_4_2_path },
		new solutionPath { tID=15, tY = 3, tX = 5, tA = 1, solution = solution4x6_15_3_5_1_path },
		new solutionPath { tID=15, tY = 3, tX = 5, tA = 3, solution = solution4x6_15_3_5_3_path },
		new solutionPath { tID=16, tY = 2, tX = 4, tA = 2, solution = solution4x6_16_2_4_2_path },
		new solutionPath { tID=16, tY = 2, tX = 5, tA = 1, solution = solution4x6_16_2_5_1_path },
		new solutionPath { tID=16, tY = 2, tX = 5, tA = 3, solution = solution4x6_16_2_5_3_path },
		new solutionPath { tID=16, tY = 3, tX = 0, tA = 1, solution = solution4x6_16_3_0_1_path },
		new solutionPath { tID=16, tY = 3, tX = 0, tA = 3, solution = solution4x6_16_3_0_3_path },
		new solutionPath { tID=16, tY = 3, tX = 1, tA = 0, solution = solution4x6_16_3_1_0_path },
		new solutionPath { tID=16, tY = 3, tX = 1, tA = 2, solution = solution4x6_16_3_1_2_path },
		new solutionPath { tID=16, tY = 3, tX = 2, tA = 1, solution = solution4x6_16_3_2_1_path },
		new solutionPath { tID=16, tY = 3, tX = 2, tA = 3, solution = solution4x6_16_3_2_3_path },
		new solutionPath { tID=16, tY = 3, tX = 3, tA = 0, solution = solution4x6_16_3_3_0_path },
		new solutionPath { tID=16, tY = 3, tX = 3, tA = 2, solution = solution4x6_16_3_3_2_path },
		new solutionPath { tID=16, tY = 3, tX = 4, tA = 1, solution = solution4x6_16_3_4_1_path },
		new solutionPath { tID=16, tY = 3, tX = 4, tA = 3, solution = solution4x6_16_3_4_3_path },
		new solutionPath { tID=16, tY = 3, tX = 5, tA = 0, solution = solution4x6_16_3_5_0_path },
		new solutionPath { tID=16, tY = 3, tX = 5, tA = 2, solution = solution4x6_16_3_5_2_path },
		new solutionPath { tID=17, tY = 2, tX = 5, tA = 2, solution = solution4x6_17_2_5_2_path },
		new solutionPath { tID=17, tY = 3, tX = 0, tA = 0, solution = solution4x6_17_3_0_0_path },
		new solutionPath { tID=17, tY = 3, tX = 0, tA = 2, solution = solution4x6_17_3_0_2_path },
		new solutionPath { tID=17, tY = 3, tX = 1, tA = 1, solution = solution4x6_17_3_1_1_path },
		new solutionPath { tID=17, tY = 3, tX = 1, tA = 3, solution = solution4x6_17_3_1_3_path },
		new solutionPath { tID=17, tY = 3, tX = 2, tA = 0, solution = solution4x6_17_3_2_0_path },
		new solutionPath { tID=17, tY = 3, tX = 2, tA = 2, solution = solution4x6_17_3_2_2_path },
		new solutionPath { tID=17, tY = 3, tX = 3, tA = 1, solution = solution4x6_17_3_3_1_path },
		new solutionPath { tID=17, tY = 3, tX = 3, tA = 3, solution = solution4x6_17_3_3_3_path },
		new solutionPath { tID=17, tY = 3, tX = 4, tA = 0, solution = solution4x6_17_3_4_0_path },
		new solutionPath { tID=17, tY = 3, tX = 4, tA = 2, solution = solution4x6_17_3_4_2_path },
		new solutionPath { tID=17, tY = 3, tX = 5, tA = 1, solution = solution4x6_17_3_5_1_path },
		new solutionPath { tID=17, tY = 3, tX = 5, tA = 3, solution = solution4x6_17_3_5_3_path },
		new solutionPath { tID=18, tY = 3, tX = 0, tA = 2, solution = solution4x6_18_3_0_2_path },
		new solutionPath { tID=18, tY = 3, tX = 1, tA = 1, solution = solution4x6_18_3_1_1_path },
		new solutionPath { tID=18, tY = 3, tX = 1, tA = 3, solution = solution4x6_18_3_1_3_path },
		new solutionPath { tID=18, tY = 3, tX = 2, tA = 0, solution = solution4x6_18_3_2_0_path },
		new solutionPath { tID=18, tY = 3, tX = 2, tA = 2, solution = solution4x6_18_3_2_2_path },
		new solutionPath { tID=18, tY = 3, tX = 3, tA = 1, solution = solution4x6_18_3_3_1_path },
		new solutionPath { tID=18, tY = 3, tX = 3, tA = 3, solution = solution4x6_18_3_3_3_path },
		new solutionPath { tID=18, tY = 3, tX = 4, tA = 0, solution = solution4x6_18_3_4_0_path },
		new solutionPath { tID=18, tY = 3, tX = 4, tA = 2, solution = solution4x6_18_3_4_2_path },
		new solutionPath { tID=18, tY = 3, tX = 5, tA = 1, solution = solution4x6_18_3_5_1_path },
		new solutionPath { tID=18, tY = 3, tX = 5, tA = 3, solution = solution4x6_18_3_5_3_path },
		new solutionPath { tID=19, tY = 3, tX = 1, tA = 2, solution = solution4x6_19_3_1_2_path },
		new solutionPath { tID=19, tY = 3, tX = 2, tA = 1, solution = solution4x6_19_3_2_1_path },
		new solutionPath { tID=19, tY = 3, tX = 2, tA = 3, solution = solution4x6_19_3_2_3_path },
		new solutionPath { tID=19, tY = 3, tX = 3, tA = 0, solution = solution4x6_19_3_3_0_path },
		new solutionPath { tID=19, tY = 3, tX = 3, tA = 2, solution = solution4x6_19_3_3_2_path },
		new solutionPath { tID=19, tY = 3, tX = 4, tA = 1, solution = solution4x6_19_3_4_1_path },
		new solutionPath { tID=19, tY = 3, tX = 4, tA = 3, solution = solution4x6_19_3_4_3_path },
		new solutionPath { tID=19, tY = 3, tX = 5, tA = 0, solution = solution4x6_19_3_5_0_path },
		new solutionPath { tID=19, tY = 3, tX = 5, tA = 2, solution = solution4x6_19_3_5_2_path },
		new solutionPath { tID=20, tY = 3, tX = 2, tA = 2, solution = solution4x6_20_3_2_2_path },
		new solutionPath { tID=20, tY = 3, tX = 3, tA = 1, solution = solution4x6_20_3_3_1_path },
		new solutionPath { tID=20, tY = 3, tX = 3, tA = 3, solution = solution4x6_20_3_3_3_path },
		new solutionPath { tID=20, tY = 3, tX = 4, tA = 0, solution = solution4x6_20_3_4_0_path },
		new solutionPath { tID=20, tY = 3, tX = 4, tA = 2, solution = solution4x6_20_3_4_2_path },
		new solutionPath { tID=20, tY = 3, tX = 5, tA = 1, solution = solution4x6_20_3_5_1_path },
		new solutionPath { tID=20, tY = 3, tX = 5, tA = 3, solution = solution4x6_20_3_5_3_path },
		new solutionPath { tID=21, tY = 3, tX = 3, tA = 2, solution = solution4x6_21_3_3_2_path },
		new solutionPath { tID=21, tY = 3, tX = 4, tA = 1, solution = solution4x6_21_3_4_1_path },
		new solutionPath { tID=21, tY = 3, tX = 4, tA = 3, solution = solution4x6_21_3_4_3_path },
		new solutionPath { tID=21, tY = 3, tX = 5, tA = 0, solution = solution4x6_21_3_5_0_path },
		new solutionPath { tID=21, tY = 3, tX = 5, tA = 2, solution = solution4x6_21_3_5_2_path },
		new solutionPath { tID=22, tY = 3, tX = 4, tA = 2, solution = solution4x6_22_3_4_2_path },
		new solutionPath { tID=22, tY = 3, tX = 5, tA = 1, solution = solution4x6_22_3_5_1_path },
		new solutionPath { tID=22, tY = 3, tX = 5, tA = 3, solution = solution4x6_22_3_5_3_path }
	};

}
