using UnityEngine;
using System.Collections;

public class AutoStepPart_4x4 : MonoBehaviour
{

	static readonly byte[] solution4x4_0_0_0_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_0_1_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_0_1_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_0_2_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_0_2_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_0_3_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_0_3_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_1_0_1_path =
	{
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_1_0_3_path =
	{
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_1_1_0_path =
	{
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_1_1_2_path =
	{
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_1_2_1_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_1_2_3_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_1_3_0_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_1_3_2_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_2_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_2_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_2_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_2_2_2_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_2_3_1_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_3_1_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_3_1_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_0_3_3_0_path =
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
	static readonly byte[] solution4x4_0_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution4x4_1_0_1_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_0_2_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_0_2_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_0_3_0_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_0_3_2_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_1_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_1_1_1_path =
	{
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_1_1_3_path =
	{
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_1_2_0_path =
	{
		(byte)0x01,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_1_2_2_path =
	{
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_1_3_1_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_1_3_3_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_2_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_2_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_2_1_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_2_1_2_path =
	{
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_2_2_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_3_1_1_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_3_1_3_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_3_2_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_3_3_1_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_1_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_2_0_2_2_path =
	{
		(byte)0x01,
		(byte)0x11,
		(byte)0x12,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_2_0_3_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_0_3_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_1_0_1_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_1_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_1_1_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_1_1_2_path =
	{
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_1_2_1_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_1_2_3_path =
	{
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_1_3_0_path =
	{
		(byte)0x02,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_1_3_2_path =
	{
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_2_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_2_1_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_2_1_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_2_2_2_path =
	{
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_2_3_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_3_0_1_path =
	{
		(byte)0x01,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_2_3_0_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_2_3_1_0_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_3_2_1_path =
	{
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_3_3_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_2_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_0_3_2_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x11,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_1_0_0_path =
	{
		(byte)0x01,
		(byte)0x10,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_3_1_0_2_path =
	{
		(byte)0x02,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_1_1_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x11,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_1_1_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_3_1_2_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_3_1_2_2_path =
	{
		(byte)0x12,
		(byte)0x02,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_1_3_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_3_1_3_3_path =
	{
		(byte)0x02,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_2_0_1_path =
	{
		(byte)0x02,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_2_0_3_path =
	{
		(byte)0x01,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_3_2_1_0_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_2_1_2_path =
	{
		(byte)0x02,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_2_2_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_3_2_2_3_path =
	{
		(byte)0x02,
		(byte)0x12,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_2_3_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x12,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_3_2_3_2_path =
	{
		(byte)0x02,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_3_0_0_path =
	{
		(byte)0x02,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_3_0_2_path =
	{
		(byte)0x01,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_3_3_1_1_path =
	{
		(byte)0x02,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_3_1_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_3_2_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_3_3_2_2_path =
	{
		(byte)0x02,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_3_3_1_path =
	{
		(byte)0x02,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution4x4_3_3_3_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02,
		(byte)0x02,
		(byte)0x01
	} ;
	static readonly byte[] solution4x4_4_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_1_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_1_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_1_2_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_1_2_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_1_3_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_1_3_3_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_2_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_2_0_3_path =
	{
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_2_1_0_path =
	{
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_2_1_2_path =
	{
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_2_2_1_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_3_1_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_3_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_3_2_0_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_3_3_1_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_4_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_5_1_1_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_1_2_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_1_2_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_1_3_0_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_1_3_2_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_2_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_2_0_2_path =
	{
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_2_1_1_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_2_1_3_path =
	{
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_2_2_2_path =
	{
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_2_3_1_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_3_1_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_3_3_0_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_5_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_6_1_2_2_path =
	{
		(byte)0x11,
		(byte)0x21,
		(byte)0x22,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_6_1_3_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_1_3_3_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_2_0_1_path =
	{
		(byte)0x20,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_2_0_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_2_1_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_2_1_2_path =
	{
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_2_2_1_path =
	{
		(byte)0x21,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_2_2_3_path =
	{
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_3_1_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_3_1_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_3_2_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_3_2_2_path =
	{
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_3_3_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_6_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_7_1_3_2_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_7_2_0_0_path =
	{
		(byte)0x11,
		(byte)0x20,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_7_2_0_2_path =
	{
		(byte)0x12,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_7_2_1_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_7_2_1_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_7_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_7_2_2_2_path =
	{
		(byte)0x22,
		(byte)0x12,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_7_2_3_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_7_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_7_3_0_1_path =
	{
		(byte)0x12,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_7_3_0_3_path =
	{
		(byte)0x11,
		(byte)0x20,
		(byte)0x20,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_7_3_1_0_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_7_3_1_2_path =
	{
		(byte)0x12,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_7_3_2_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_7_3_2_3_path =
	{
		(byte)0x12,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_7_3_3_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x11
	} ;
	static readonly byte[] solution4x4_7_3_3_2_path =
	{
		(byte)0x12,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution4x4_8_2_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_2_1_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_2_1_3_path =
	{
		(byte)0x20,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_2_2_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_2_2_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_2_3_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_2_3_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_3_0_3_path =
	{
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_3_1_0_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_3_1_2_path =
	{
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_3_3_0_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_8_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_9_2_1_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_9_2_2_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_9_2_2_3_path =
	{
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_9_2_3_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_9_2_3_2_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_9_3_0_0_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x20,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution4x4_9_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_9_3_1_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_9_3_1_3_path =
	{
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_9_3_2_0_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_9_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_9_3_3_1_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_9_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_10_2_2_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20,
		(byte)0x22
	} ;
	static readonly byte[] solution4x4_10_2_3_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x4_10_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_10_3_0_1_path =
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
	static readonly byte[] solution4x4_10_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_10_3_1_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_10_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x22
	} ;
	static readonly byte[] solution4x4_10_3_2_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_10_3_2_3_path =
	{
		(byte)0x22
	} ;
	static readonly byte[] solution4x4_10_3_3_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x22
	} ;
	static readonly byte[] solution4x4_10_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x4_11_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x22
	} ;
	static readonly byte[] solution4x4_11_3_0_0_path =
	{
		(byte)0x12,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_11_3_0_2_path =
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
	static readonly byte[] solution4x4_11_3_1_1_path =
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
	static readonly byte[] solution4x4_11_3_1_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_11_3_2_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_11_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x12,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_11_3_3_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_11_3_3_3_path =
	{
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_12_3_0_2_path =
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
	static readonly byte[] solution4x4_12_3_1_1_path =
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
	static readonly byte[] solution4x4_12_3_1_3_path =
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
	static readonly byte[] solution4x4_12_3_2_0_path =
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
	static readonly byte[] solution4x4_12_3_2_2_path =
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
	static readonly byte[] solution4x4_12_3_3_1_path =
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
	static readonly byte[] solution4x4_12_3_3_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20
	} ;
	static readonly byte[] solution4x4_13_3_1_2_path =
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
	static readonly byte[] solution4x4_13_3_2_1_path =
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
	static readonly byte[] solution4x4_13_3_2_3_path =
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
	static readonly byte[] solution4x4_13_3_3_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x22,
		(byte)0x22,
		(byte)0x11,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_13_3_3_2_path =
	{
		(byte)0x11,
		(byte)0x22,
		(byte)0x12,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x22,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x4_14_3_2_2_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x22,
		(byte)0x12,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution4x4_14_3_3_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x12,
		(byte)0x21
	} ;
	static readonly byte[] solution4x4_14_3_3_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12,
		(byte)0x21,
		(byte)0x12,
		(byte)0x11,
		(byte)0x22
	} ;

// Solutions for 4x4 puzzle
	public static readonly solutionPath[] solution4x4 = {
		new solutionPath { tID=0, tY = 0, tX = 0, tA = 2, solution = solution4x4_0_0_0_2_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 1, solution = solution4x4_0_0_1_1_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 3, solution = solution4x4_0_0_1_3_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 0, solution = solution4x4_0_0_2_0_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 2, solution = solution4x4_0_0_2_2_path },
		new solutionPath { tID=0, tY = 0, tX = 3, tA = 1, solution = solution4x4_0_0_3_1_path },
		new solutionPath { tID=0, tY = 0, tX = 3, tA = 3, solution = solution4x4_0_0_3_3_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 1, solution = solution4x4_0_1_0_1_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 3, solution = solution4x4_0_1_0_3_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 0, solution = solution4x4_0_1_1_0_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 2, solution = solution4x4_0_1_1_2_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 1, solution = solution4x4_0_1_2_1_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 3, solution = solution4x4_0_1_2_3_path },
		new solutionPath { tID=0, tY = 1, tX = 3, tA = 0, solution = solution4x4_0_1_3_0_path },
		new solutionPath { tID=0, tY = 1, tX = 3, tA = 2, solution = solution4x4_0_1_3_2_path },
		new solutionPath { tID=0, tY = 2, tX = 0, tA = 0, solution = solution4x4_0_2_0_0_path },
		new solutionPath { tID=0, tY = 2, tX = 0, tA = 2, solution = solution4x4_0_2_0_2_path },
		new solutionPath { tID=0, tY = 2, tX = 1, tA = 1, solution = solution4x4_0_2_1_1_path },
		new solutionPath { tID=0, tY = 2, tX = 1, tA = 3, solution = solution4x4_0_2_1_3_path },
		new solutionPath { tID=0, tY = 2, tX = 2, tA = 0, solution = solution4x4_0_2_2_0_path },
		new solutionPath { tID=0, tY = 2, tX = 2, tA = 2, solution = solution4x4_0_2_2_2_path },
		new solutionPath { tID=0, tY = 2, tX = 3, tA = 1, solution = solution4x4_0_2_3_1_path },
		new solutionPath { tID=0, tY = 2, tX = 3, tA = 3, solution = solution4x4_0_2_3_3_path },
		new solutionPath { tID=0, tY = 3, tX = 0, tA = 1, solution = solution4x4_0_3_0_1_path },
		new solutionPath { tID=0, tY = 3, tX = 0, tA = 3, solution = solution4x4_0_3_0_3_path },
		new solutionPath { tID=0, tY = 3, tX = 1, tA = 0, solution = solution4x4_0_3_1_0_path },
		new solutionPath { tID=0, tY = 3, tX = 1, tA = 2, solution = solution4x4_0_3_1_2_path },
		new solutionPath { tID=0, tY = 3, tX = 2, tA = 1, solution = solution4x4_0_3_2_1_path },
		new solutionPath { tID=0, tY = 3, tX = 2, tA = 3, solution = solution4x4_0_3_2_3_path },
		new solutionPath { tID=0, tY = 3, tX = 3, tA = 0, solution = solution4x4_0_3_3_0_path },
		new solutionPath { tID=0, tY = 3, tX = 3, tA = 2, solution = solution4x4_0_3_3_2_path },
		new solutionPath { tID=1, tY = 0, tX = 1, tA = 2, solution = solution4x4_1_0_1_2_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 1, solution = solution4x4_1_0_2_1_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 3, solution = solution4x4_1_0_2_3_path },
		new solutionPath { tID=1, tY = 0, tX = 3, tA = 0, solution = solution4x4_1_0_3_0_path },
		new solutionPath { tID=1, tY = 0, tX = 3, tA = 2, solution = solution4x4_1_0_3_2_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 0, solution = solution4x4_1_1_0_0_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 2, solution = solution4x4_1_1_0_2_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 1, solution = solution4x4_1_1_1_1_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 3, solution = solution4x4_1_1_1_3_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 0, solution = solution4x4_1_1_2_0_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 2, solution = solution4x4_1_1_2_2_path },
		new solutionPath { tID=1, tY = 1, tX = 3, tA = 1, solution = solution4x4_1_1_3_1_path },
		new solutionPath { tID=1, tY = 1, tX = 3, tA = 3, solution = solution4x4_1_1_3_3_path },
		new solutionPath { tID=1, tY = 2, tX = 0, tA = 1, solution = solution4x4_1_2_0_1_path },
		new solutionPath { tID=1, tY = 2, tX = 0, tA = 3, solution = solution4x4_1_2_0_3_path },
		new solutionPath { tID=1, tY = 2, tX = 1, tA = 0, solution = solution4x4_1_2_1_0_path },
		new solutionPath { tID=1, tY = 2, tX = 1, tA = 2, solution = solution4x4_1_2_1_2_path },
		new solutionPath { tID=1, tY = 2, tX = 2, tA = 1, solution = solution4x4_1_2_2_1_path },
		new solutionPath { tID=1, tY = 2, tX = 2, tA = 3, solution = solution4x4_1_2_2_3_path },
		new solutionPath { tID=1, tY = 2, tX = 3, tA = 0, solution = solution4x4_1_2_3_0_path },
		new solutionPath { tID=1, tY = 2, tX = 3, tA = 2, solution = solution4x4_1_2_3_2_path },
		new solutionPath { tID=1, tY = 3, tX = 0, tA = 0, solution = solution4x4_1_3_0_0_path },
		new solutionPath { tID=1, tY = 3, tX = 0, tA = 2, solution = solution4x4_1_3_0_2_path },
		new solutionPath { tID=1, tY = 3, tX = 1, tA = 1, solution = solution4x4_1_3_1_1_path },
		new solutionPath { tID=1, tY = 3, tX = 1, tA = 3, solution = solution4x4_1_3_1_3_path },
		new solutionPath { tID=1, tY = 3, tX = 2, tA = 0, solution = solution4x4_1_3_2_0_path },
		new solutionPath { tID=1, tY = 3, tX = 2, tA = 2, solution = solution4x4_1_3_2_2_path },
		new solutionPath { tID=1, tY = 3, tX = 3, tA = 1, solution = solution4x4_1_3_3_1_path },
		new solutionPath { tID=1, tY = 3, tX = 3, tA = 3, solution = solution4x4_1_3_3_3_path },
		new solutionPath { tID=2, tY = 0, tX = 2, tA = 2, solution = solution4x4_2_0_2_2_path },
		new solutionPath { tID=2, tY = 0, tX = 3, tA = 1, solution = solution4x4_2_0_3_1_path },
		new solutionPath { tID=2, tY = 0, tX = 3, tA = 3, solution = solution4x4_2_0_3_3_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 1, solution = solution4x4_2_1_0_1_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 3, solution = solution4x4_2_1_0_3_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 0, solution = solution4x4_2_1_1_0_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 2, solution = solution4x4_2_1_1_2_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 1, solution = solution4x4_2_1_2_1_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 3, solution = solution4x4_2_1_2_3_path },
		new solutionPath { tID=2, tY = 1, tX = 3, tA = 0, solution = solution4x4_2_1_3_0_path },
		new solutionPath { tID=2, tY = 1, tX = 3, tA = 2, solution = solution4x4_2_1_3_2_path },
		new solutionPath { tID=2, tY = 2, tX = 0, tA = 0, solution = solution4x4_2_2_0_0_path },
		new solutionPath { tID=2, tY = 2, tX = 0, tA = 2, solution = solution4x4_2_2_0_2_path },
		new solutionPath { tID=2, tY = 2, tX = 1, tA = 1, solution = solution4x4_2_2_1_1_path },
		new solutionPath { tID=2, tY = 2, tX = 1, tA = 3, solution = solution4x4_2_2_1_3_path },
		new solutionPath { tID=2, tY = 2, tX = 2, tA = 0, solution = solution4x4_2_2_2_0_path },
		new solutionPath { tID=2, tY = 2, tX = 2, tA = 2, solution = solution4x4_2_2_2_2_path },
		new solutionPath { tID=2, tY = 2, tX = 3, tA = 1, solution = solution4x4_2_2_3_1_path },
		new solutionPath { tID=2, tY = 2, tX = 3, tA = 3, solution = solution4x4_2_2_3_3_path },
		new solutionPath { tID=2, tY = 3, tX = 0, tA = 1, solution = solution4x4_2_3_0_1_path },
		new solutionPath { tID=2, tY = 3, tX = 0, tA = 3, solution = solution4x4_2_3_0_3_path },
		new solutionPath { tID=2, tY = 3, tX = 1, tA = 0, solution = solution4x4_2_3_1_0_path },
		new solutionPath { tID=2, tY = 3, tX = 1, tA = 2, solution = solution4x4_2_3_1_2_path },
		new solutionPath { tID=2, tY = 3, tX = 2, tA = 1, solution = solution4x4_2_3_2_1_path },
		new solutionPath { tID=2, tY = 3, tX = 2, tA = 3, solution = solution4x4_2_3_2_3_path },
		new solutionPath { tID=2, tY = 3, tX = 3, tA = 0, solution = solution4x4_2_3_3_0_path },
		new solutionPath { tID=2, tY = 3, tX = 3, tA = 2, solution = solution4x4_2_3_3_2_path },
		new solutionPath { tID=3, tY = 0, tX = 3, tA = 2, solution = solution4x4_3_0_3_2_path },
		new solutionPath { tID=3, tY = 1, tX = 0, tA = 0, solution = solution4x4_3_1_0_0_path },
		new solutionPath { tID=3, tY = 1, tX = 0, tA = 2, solution = solution4x4_3_1_0_2_path },
		new solutionPath { tID=3, tY = 1, tX = 1, tA = 1, solution = solution4x4_3_1_1_1_path },
		new solutionPath { tID=3, tY = 1, tX = 1, tA = 3, solution = solution4x4_3_1_1_3_path },
		new solutionPath { tID=3, tY = 1, tX = 2, tA = 0, solution = solution4x4_3_1_2_0_path },
		new solutionPath { tID=3, tY = 1, tX = 2, tA = 2, solution = solution4x4_3_1_2_2_path },
		new solutionPath { tID=3, tY = 1, tX = 3, tA = 1, solution = solution4x4_3_1_3_1_path },
		new solutionPath { tID=3, tY = 1, tX = 3, tA = 3, solution = solution4x4_3_1_3_3_path },
		new solutionPath { tID=3, tY = 2, tX = 0, tA = 1, solution = solution4x4_3_2_0_1_path },
		new solutionPath { tID=3, tY = 2, tX = 0, tA = 3, solution = solution4x4_3_2_0_3_path },
		new solutionPath { tID=3, tY = 2, tX = 1, tA = 0, solution = solution4x4_3_2_1_0_path },
		new solutionPath { tID=3, tY = 2, tX = 1, tA = 2, solution = solution4x4_3_2_1_2_path },
		new solutionPath { tID=3, tY = 2, tX = 2, tA = 1, solution = solution4x4_3_2_2_1_path },
		new solutionPath { tID=3, tY = 2, tX = 2, tA = 3, solution = solution4x4_3_2_2_3_path },
		new solutionPath { tID=3, tY = 2, tX = 3, tA = 0, solution = solution4x4_3_2_3_0_path },
		new solutionPath { tID=3, tY = 2, tX = 3, tA = 2, solution = solution4x4_3_2_3_2_path },
		new solutionPath { tID=3, tY = 3, tX = 0, tA = 0, solution = solution4x4_3_3_0_0_path },
		new solutionPath { tID=3, tY = 3, tX = 0, tA = 2, solution = solution4x4_3_3_0_2_path },
		new solutionPath { tID=3, tY = 3, tX = 1, tA = 1, solution = solution4x4_3_3_1_1_path },
		new solutionPath { tID=3, tY = 3, tX = 1, tA = 3, solution = solution4x4_3_3_1_3_path },
		new solutionPath { tID=3, tY = 3, tX = 2, tA = 0, solution = solution4x4_3_3_2_0_path },
		new solutionPath { tID=3, tY = 3, tX = 2, tA = 2, solution = solution4x4_3_3_2_2_path },
		new solutionPath { tID=3, tY = 3, tX = 3, tA = 1, solution = solution4x4_3_3_3_1_path },
		new solutionPath { tID=3, tY = 3, tX = 3, tA = 3, solution = solution4x4_3_3_3_3_path },
		new solutionPath { tID=4, tY = 1, tX = 0, tA = 2, solution = solution4x4_4_1_0_2_path },
		new solutionPath { tID=4, tY = 1, tX = 1, tA = 1, solution = solution4x4_4_1_1_1_path },
		new solutionPath { tID=4, tY = 1, tX = 1, tA = 3, solution = solution4x4_4_1_1_3_path },
		new solutionPath { tID=4, tY = 1, tX = 2, tA = 0, solution = solution4x4_4_1_2_0_path },
		new solutionPath { tID=4, tY = 1, tX = 2, tA = 2, solution = solution4x4_4_1_2_2_path },
		new solutionPath { tID=4, tY = 1, tX = 3, tA = 1, solution = solution4x4_4_1_3_1_path },
		new solutionPath { tID=4, tY = 1, tX = 3, tA = 3, solution = solution4x4_4_1_3_3_path },
		new solutionPath { tID=4, tY = 2, tX = 0, tA = 1, solution = solution4x4_4_2_0_1_path },
		new solutionPath { tID=4, tY = 2, tX = 0, tA = 3, solution = solution4x4_4_2_0_3_path },
		new solutionPath { tID=4, tY = 2, tX = 1, tA = 0, solution = solution4x4_4_2_1_0_path },
		new solutionPath { tID=4, tY = 2, tX = 1, tA = 2, solution = solution4x4_4_2_1_2_path },
		new solutionPath { tID=4, tY = 2, tX = 2, tA = 1, solution = solution4x4_4_2_2_1_path },
		new solutionPath { tID=4, tY = 2, tX = 2, tA = 3, solution = solution4x4_4_2_2_3_path },
		new solutionPath { tID=4, tY = 2, tX = 3, tA = 0, solution = solution4x4_4_2_3_0_path },
		new solutionPath { tID=4, tY = 2, tX = 3, tA = 2, solution = solution4x4_4_2_3_2_path },
		new solutionPath { tID=4, tY = 3, tX = 0, tA = 0, solution = solution4x4_4_3_0_0_path },
		new solutionPath { tID=4, tY = 3, tX = 0, tA = 2, solution = solution4x4_4_3_0_2_path },
		new solutionPath { tID=4, tY = 3, tX = 1, tA = 1, solution = solution4x4_4_3_1_1_path },
		new solutionPath { tID=4, tY = 3, tX = 1, tA = 3, solution = solution4x4_4_3_1_3_path },
		new solutionPath { tID=4, tY = 3, tX = 2, tA = 0, solution = solution4x4_4_3_2_0_path },
		new solutionPath { tID=4, tY = 3, tX = 2, tA = 2, solution = solution4x4_4_3_2_2_path },
		new solutionPath { tID=4, tY = 3, tX = 3, tA = 1, solution = solution4x4_4_3_3_1_path },
		new solutionPath { tID=4, tY = 3, tX = 3, tA = 3, solution = solution4x4_4_3_3_3_path },
		new solutionPath { tID=5, tY = 1, tX = 1, tA = 2, solution = solution4x4_5_1_1_2_path },
		new solutionPath { tID=5, tY = 1, tX = 2, tA = 1, solution = solution4x4_5_1_2_1_path },
		new solutionPath { tID=5, tY = 1, tX = 2, tA = 3, solution = solution4x4_5_1_2_3_path },
		new solutionPath { tID=5, tY = 1, tX = 3, tA = 0, solution = solution4x4_5_1_3_0_path },
		new solutionPath { tID=5, tY = 1, tX = 3, tA = 2, solution = solution4x4_5_1_3_2_path },
		new solutionPath { tID=5, tY = 2, tX = 0, tA = 0, solution = solution4x4_5_2_0_0_path },
		new solutionPath { tID=5, tY = 2, tX = 0, tA = 2, solution = solution4x4_5_2_0_2_path },
		new solutionPath { tID=5, tY = 2, tX = 1, tA = 1, solution = solution4x4_5_2_1_1_path },
		new solutionPath { tID=5, tY = 2, tX = 1, tA = 3, solution = solution4x4_5_2_1_3_path },
		new solutionPath { tID=5, tY = 2, tX = 2, tA = 0, solution = solution4x4_5_2_2_0_path },
		new solutionPath { tID=5, tY = 2, tX = 2, tA = 2, solution = solution4x4_5_2_2_2_path },
		new solutionPath { tID=5, tY = 2, tX = 3, tA = 1, solution = solution4x4_5_2_3_1_path },
		new solutionPath { tID=5, tY = 2, tX = 3, tA = 3, solution = solution4x4_5_2_3_3_path },
		new solutionPath { tID=5, tY = 3, tX = 0, tA = 1, solution = solution4x4_5_3_0_1_path },
		new solutionPath { tID=5, tY = 3, tX = 0, tA = 3, solution = solution4x4_5_3_0_3_path },
		new solutionPath { tID=5, tY = 3, tX = 1, tA = 0, solution = solution4x4_5_3_1_0_path },
		new solutionPath { tID=5, tY = 3, tX = 1, tA = 2, solution = solution4x4_5_3_1_2_path },
		new solutionPath { tID=5, tY = 3, tX = 2, tA = 1, solution = solution4x4_5_3_2_1_path },
		new solutionPath { tID=5, tY = 3, tX = 2, tA = 3, solution = solution4x4_5_3_2_3_path },
		new solutionPath { tID=5, tY = 3, tX = 3, tA = 0, solution = solution4x4_5_3_3_0_path },
		new solutionPath { tID=5, tY = 3, tX = 3, tA = 2, solution = solution4x4_5_3_3_2_path },
		new solutionPath { tID=6, tY = 1, tX = 2, tA = 2, solution = solution4x4_6_1_2_2_path },
		new solutionPath { tID=6, tY = 1, tX = 3, tA = 1, solution = solution4x4_6_1_3_1_path },
		new solutionPath { tID=6, tY = 1, tX = 3, tA = 3, solution = solution4x4_6_1_3_3_path },
		new solutionPath { tID=6, tY = 2, tX = 0, tA = 1, solution = solution4x4_6_2_0_1_path },
		new solutionPath { tID=6, tY = 2, tX = 0, tA = 3, solution = solution4x4_6_2_0_3_path },
		new solutionPath { tID=6, tY = 2, tX = 1, tA = 0, solution = solution4x4_6_2_1_0_path },
		new solutionPath { tID=6, tY = 2, tX = 1, tA = 2, solution = solution4x4_6_2_1_2_path },
		new solutionPath { tID=6, tY = 2, tX = 2, tA = 1, solution = solution4x4_6_2_2_1_path },
		new solutionPath { tID=6, tY = 2, tX = 2, tA = 3, solution = solution4x4_6_2_2_3_path },
		new solutionPath { tID=6, tY = 2, tX = 3, tA = 0, solution = solution4x4_6_2_3_0_path },
		new solutionPath { tID=6, tY = 2, tX = 3, tA = 2, solution = solution4x4_6_2_3_2_path },
		new solutionPath { tID=6, tY = 3, tX = 0, tA = 0, solution = solution4x4_6_3_0_0_path },
		new solutionPath { tID=6, tY = 3, tX = 0, tA = 2, solution = solution4x4_6_3_0_2_path },
		new solutionPath { tID=6, tY = 3, tX = 1, tA = 1, solution = solution4x4_6_3_1_1_path },
		new solutionPath { tID=6, tY = 3, tX = 1, tA = 3, solution = solution4x4_6_3_1_3_path },
		new solutionPath { tID=6, tY = 3, tX = 2, tA = 0, solution = solution4x4_6_3_2_0_path },
		new solutionPath { tID=6, tY = 3, tX = 2, tA = 2, solution = solution4x4_6_3_2_2_path },
		new solutionPath { tID=6, tY = 3, tX = 3, tA = 1, solution = solution4x4_6_3_3_1_path },
		new solutionPath { tID=6, tY = 3, tX = 3, tA = 3, solution = solution4x4_6_3_3_3_path },
		new solutionPath { tID=7, tY = 1, tX = 3, tA = 2, solution = solution4x4_7_1_3_2_path },
		new solutionPath { tID=7, tY = 2, tX = 0, tA = 0, solution = solution4x4_7_2_0_0_path },
		new solutionPath { tID=7, tY = 2, tX = 0, tA = 2, solution = solution4x4_7_2_0_2_path },
		new solutionPath { tID=7, tY = 2, tX = 1, tA = 1, solution = solution4x4_7_2_1_1_path },
		new solutionPath { tID=7, tY = 2, tX = 1, tA = 3, solution = solution4x4_7_2_1_3_path },
		new solutionPath { tID=7, tY = 2, tX = 2, tA = 0, solution = solution4x4_7_2_2_0_path },
		new solutionPath { tID=7, tY = 2, tX = 2, tA = 2, solution = solution4x4_7_2_2_2_path },
		new solutionPath { tID=7, tY = 2, tX = 3, tA = 1, solution = solution4x4_7_2_3_1_path },
		new solutionPath { tID=7, tY = 2, tX = 3, tA = 3, solution = solution4x4_7_2_3_3_path },
		new solutionPath { tID=7, tY = 3, tX = 0, tA = 1, solution = solution4x4_7_3_0_1_path },
		new solutionPath { tID=7, tY = 3, tX = 0, tA = 3, solution = solution4x4_7_3_0_3_path },
		new solutionPath { tID=7, tY = 3, tX = 1, tA = 0, solution = solution4x4_7_3_1_0_path },
		new solutionPath { tID=7, tY = 3, tX = 1, tA = 2, solution = solution4x4_7_3_1_2_path },
		new solutionPath { tID=7, tY = 3, tX = 2, tA = 1, solution = solution4x4_7_3_2_1_path },
		new solutionPath { tID=7, tY = 3, tX = 2, tA = 3, solution = solution4x4_7_3_2_3_path },
		new solutionPath { tID=7, tY = 3, tX = 3, tA = 0, solution = solution4x4_7_3_3_0_path },
		new solutionPath { tID=7, tY = 3, tX = 3, tA = 2, solution = solution4x4_7_3_3_2_path },
		new solutionPath { tID=8, tY = 2, tX = 0, tA = 2, solution = solution4x4_8_2_0_2_path },
		new solutionPath { tID=8, tY = 2, tX = 1, tA = 1, solution = solution4x4_8_2_1_1_path },
		new solutionPath { tID=8, tY = 2, tX = 1, tA = 3, solution = solution4x4_8_2_1_3_path },
		new solutionPath { tID=8, tY = 2, tX = 2, tA = 0, solution = solution4x4_8_2_2_0_path },
		new solutionPath { tID=8, tY = 2, tX = 2, tA = 2, solution = solution4x4_8_2_2_2_path },
		new solutionPath { tID=8, tY = 2, tX = 3, tA = 1, solution = solution4x4_8_2_3_1_path },
		new solutionPath { tID=8, tY = 2, tX = 3, tA = 3, solution = solution4x4_8_2_3_3_path },
		new solutionPath { tID=8, tY = 3, tX = 0, tA = 1, solution = solution4x4_8_3_0_1_path },
		new solutionPath { tID=8, tY = 3, tX = 0, tA = 3, solution = solution4x4_8_3_0_3_path },
		new solutionPath { tID=8, tY = 3, tX = 1, tA = 0, solution = solution4x4_8_3_1_0_path },
		new solutionPath { tID=8, tY = 3, tX = 1, tA = 2, solution = solution4x4_8_3_1_2_path },
		new solutionPath { tID=8, tY = 3, tX = 2, tA = 1, solution = solution4x4_8_3_2_1_path },
		new solutionPath { tID=8, tY = 3, tX = 2, tA = 3, solution = solution4x4_8_3_2_3_path },
		new solutionPath { tID=8, tY = 3, tX = 3, tA = 0, solution = solution4x4_8_3_3_0_path },
		new solutionPath { tID=8, tY = 3, tX = 3, tA = 2, solution = solution4x4_8_3_3_2_path },
		new solutionPath { tID=9, tY = 2, tX = 1, tA = 2, solution = solution4x4_9_2_1_2_path },
		new solutionPath { tID=9, tY = 2, tX = 2, tA = 1, solution = solution4x4_9_2_2_1_path },
		new solutionPath { tID=9, tY = 2, tX = 2, tA = 3, solution = solution4x4_9_2_2_3_path },
		new solutionPath { tID=9, tY = 2, tX = 3, tA = 0, solution = solution4x4_9_2_3_0_path },
		new solutionPath { tID=9, tY = 2, tX = 3, tA = 2, solution = solution4x4_9_2_3_2_path },
		new solutionPath { tID=9, tY = 3, tX = 0, tA = 0, solution = solution4x4_9_3_0_0_path },
		new solutionPath { tID=9, tY = 3, tX = 0, tA = 2, solution = solution4x4_9_3_0_2_path },
		new solutionPath { tID=9, tY = 3, tX = 1, tA = 1, solution = solution4x4_9_3_1_1_path },
		new solutionPath { tID=9, tY = 3, tX = 1, tA = 3, solution = solution4x4_9_3_1_3_path },
		new solutionPath { tID=9, tY = 3, tX = 2, tA = 0, solution = solution4x4_9_3_2_0_path },
		new solutionPath { tID=9, tY = 3, tX = 2, tA = 2, solution = solution4x4_9_3_2_2_path },
		new solutionPath { tID=9, tY = 3, tX = 3, tA = 1, solution = solution4x4_9_3_3_1_path },
		new solutionPath { tID=9, tY = 3, tX = 3, tA = 3, solution = solution4x4_9_3_3_3_path },
		new solutionPath { tID=10, tY = 2, tX = 2, tA = 2, solution = solution4x4_10_2_2_2_path },
		new solutionPath { tID=10, tY = 2, tX = 3, tA = 1, solution = solution4x4_10_2_3_1_path },
		new solutionPath { tID=10, tY = 2, tX = 3, tA = 3, solution = solution4x4_10_2_3_3_path },
		new solutionPath { tID=10, tY = 3, tX = 0, tA = 1, solution = solution4x4_10_3_0_1_path },
		new solutionPath { tID=10, tY = 3, tX = 0, tA = 3, solution = solution4x4_10_3_0_3_path },
		new solutionPath { tID=10, tY = 3, tX = 1, tA = 0, solution = solution4x4_10_3_1_0_path },
		new solutionPath { tID=10, tY = 3, tX = 1, tA = 2, solution = solution4x4_10_3_1_2_path },
		new solutionPath { tID=10, tY = 3, tX = 2, tA = 1, solution = solution4x4_10_3_2_1_path },
		new solutionPath { tID=10, tY = 3, tX = 2, tA = 3, solution = solution4x4_10_3_2_3_path },
		new solutionPath { tID=10, tY = 3, tX = 3, tA = 0, solution = solution4x4_10_3_3_0_path },
		new solutionPath { tID=10, tY = 3, tX = 3, tA = 2, solution = solution4x4_10_3_3_2_path },
		new solutionPath { tID=11, tY = 2, tX = 3, tA = 2, solution = solution4x4_11_2_3_2_path },
		new solutionPath { tID=11, tY = 3, tX = 0, tA = 0, solution = solution4x4_11_3_0_0_path },
		new solutionPath { tID=11, tY = 3, tX = 0, tA = 2, solution = solution4x4_11_3_0_2_path },
		new solutionPath { tID=11, tY = 3, tX = 1, tA = 1, solution = solution4x4_11_3_1_1_path },
		new solutionPath { tID=11, tY = 3, tX = 1, tA = 3, solution = solution4x4_11_3_1_3_path },
		new solutionPath { tID=11, tY = 3, tX = 2, tA = 0, solution = solution4x4_11_3_2_0_path },
		new solutionPath { tID=11, tY = 3, tX = 2, tA = 2, solution = solution4x4_11_3_2_2_path },
		new solutionPath { tID=11, tY = 3, tX = 3, tA = 1, solution = solution4x4_11_3_3_1_path },
		new solutionPath { tID=11, tY = 3, tX = 3, tA = 3, solution = solution4x4_11_3_3_3_path },
		new solutionPath { tID=12, tY = 3, tX = 0, tA = 2, solution = solution4x4_12_3_0_2_path },
		new solutionPath { tID=12, tY = 3, tX = 1, tA = 1, solution = solution4x4_12_3_1_1_path },
		new solutionPath { tID=12, tY = 3, tX = 1, tA = 3, solution = solution4x4_12_3_1_3_path },
		new solutionPath { tID=12, tY = 3, tX = 2, tA = 0, solution = solution4x4_12_3_2_0_path },
		new solutionPath { tID=12, tY = 3, tX = 2, tA = 2, solution = solution4x4_12_3_2_2_path },
		new solutionPath { tID=12, tY = 3, tX = 3, tA = 1, solution = solution4x4_12_3_3_1_path },
		new solutionPath { tID=12, tY = 3, tX = 3, tA = 3, solution = solution4x4_12_3_3_3_path },
		new solutionPath { tID=13, tY = 3, tX = 1, tA = 2, solution = solution4x4_13_3_1_2_path },
		new solutionPath { tID=13, tY = 3, tX = 2, tA = 1, solution = solution4x4_13_3_2_1_path },
		new solutionPath { tID=13, tY = 3, tX = 2, tA = 3, solution = solution4x4_13_3_2_3_path },
		new solutionPath { tID=13, tY = 3, tX = 3, tA = 0, solution = solution4x4_13_3_3_0_path },
		new solutionPath { tID=13, tY = 3, tX = 3, tA = 2, solution = solution4x4_13_3_3_2_path },
		new solutionPath { tID=14, tY = 3, tX = 2, tA = 2, solution = solution4x4_14_3_2_2_path },
		new solutionPath { tID=14, tY = 3, tX = 3, tA = 1, solution = solution4x4_14_3_3_1_path },
		new solutionPath { tID=14, tY = 3, tX = 3, tA = 3, solution = solution4x4_14_3_3_3_path }
	};

}
