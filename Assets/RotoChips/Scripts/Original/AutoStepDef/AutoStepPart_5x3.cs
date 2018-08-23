using UnityEngine;
using System.Collections;

public class AutoStepPart_5x3 : MonoBehaviour
{

	static readonly byte[] solution5x3_0_0_0_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_0_1_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_0_1_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_0_2_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_0_2_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_1_0_1_path =
	{
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_1_0_3_path =
	{
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_1_1_0_path =
	{
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_1_1_2_path =
	{
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_1_2_1_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_1_2_3_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_2_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_2_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_2_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_2_2_2_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_3_1_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_3_1_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_4_1_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_4_1_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_4_2_0_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_0_4_2_2_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_1_0_1_2_path =
	{
		(byte)0x00,
		(byte)0x10,
		(byte)0x11,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_1_0_2_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_0_2_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_1_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_1_1_1_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_1_1_3_path =
	{
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_1_2_0_path =
	{
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_1_2_2_path =
	{
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_2_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_2_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_2_1_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_2_1_2_path =
	{
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_2_2_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_3_1_1_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_3_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_3_2_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_4_0_1_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_4_0_3_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_4_1_0_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_4_1_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_4_2_1_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_1_4_2_3_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_0_2_2_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_1_0_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x10,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_1_0_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_2_1_1_0_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_2_1_1_2_path =
	{
		(byte)0x11,
		(byte)0x01,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_1_2_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_2_1_2_3_path =
	{
		(byte)0x01,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_2_0_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_2_0_2_path =
	{
		(byte)0x01,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_2_1_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_2_2_1_3_path =
	{
		(byte)0x01,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_2_2_0_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_2_2_2_2_path =
	{
		(byte)0x01,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_3_0_1_path =
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
	static readonly byte[] solution5x3_2_3_0_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_3_1_0_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_2_3_1_2_path =
	{
		(byte)0x01,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_3_2_1_path =
	{
		(byte)0x01,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_3_2_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_2_4_0_0_path =
	{
		(byte)0x01,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_4_0_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_4_1_1_path =
	{
		(byte)0x01,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_4_1_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_2_4_2_0_path =
	{
		(byte)0x01,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution5x3_2_4_2_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01,
		(byte)0x01,
		(byte)0x00
	} ;
	static readonly byte[] solution5x3_3_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_1_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_1_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_1_2_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_1_2_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_2_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_2_0_3_path =
	{
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_2_1_0_path =
	{
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_2_1_2_path =
	{
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_2_2_1_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_3_1_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_3_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_3_2_0_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_4_0_1_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_4_0_3_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_4_1_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_4_1_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_4_2_1_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_3_4_2_3_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_4_1_1_2_path =
	{
		(byte)0x10,
		(byte)0x20,
		(byte)0x21,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_4_1_2_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_1_2_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_2_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_2_0_2_path =
	{
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_2_1_1_path =
	{
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_2_1_3_path =
	{
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_2_2_2_path =
	{
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_3_1_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_4_1_1_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_4_1_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_4_2_0_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_4_4_2_2_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_5_1_2_2_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x10,
		(byte)0x20,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_5_2_0_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x20,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_5_2_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_5_2_1_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_5_2_1_2_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_5_2_2_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_5_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_5_3_0_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x20,
		(byte)0x20,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_5_3_0_2_path =
	{
		(byte)0x11,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_5_3_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_5_3_1_3_path =
	{
		(byte)0x11,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_5_3_2_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_5_3_2_2_path =
	{
		(byte)0x11,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_5_4_0_1_path =
	{
		(byte)0x11,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_5_4_0_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_5_4_1_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_5_4_1_2_path =
	{
		(byte)0x11,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_5_4_2_1_path =
	{
		(byte)0x11,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution5x3_5_4_2_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10
	} ;
	static readonly byte[] solution5x3_6_2_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_2_1_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_2_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_2_2_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_2_2_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_3_0_1_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_3_0_3_path =
	{
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_3_1_0_path =
	{
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_3_1_2_path =
	{
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_4_1_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_4_1_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_4_2_0_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_6_4_2_2_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_7_2_1_2_path =
	{
		(byte)0x20,
		(byte)0x30,
		(byte)0x31,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_7_2_2_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_7_2_2_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x30,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_7_3_0_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_7_3_0_2_path =
	{
		(byte)0x30,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_7_3_1_1_path =
	{
		(byte)0x30,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_7_3_1_3_path =
	{
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_7_3_2_0_path =
	{
		(byte)0x21,
		(byte)0x30,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_7_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_7_4_0_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_7_4_0_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_7_4_1_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_7_4_1_2_path =
	{
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_7_4_2_1_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_7_4_2_3_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_8_2_2_2_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20,
		(byte)0x30,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_8_3_0_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x30,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_8_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_8_3_1_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_8_3_1_2_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_8_3_2_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_8_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_8_4_0_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x30,
		(byte)0x30,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_8_4_0_2_path =
	{
		(byte)0x21,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_8_4_1_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_8_4_1_3_path =
	{
		(byte)0x21,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_8_4_2_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_8_4_2_2_path =
	{
		(byte)0x21,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_9_3_0_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_9_3_1_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_9_3_1_3_path =
	{
		(byte)0x30,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_9_3_2_0_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_9_3_2_2_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_9_4_0_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_9_4_0_3_path =
	{
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_9_4_1_0_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_9_4_1_2_path =
	{
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_9_4_2_1_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_9_4_2_3_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_10_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x30,
		(byte)0x31
	} ;
	static readonly byte[] solution5x3_10_3_2_1_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution5x3_10_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x30,
		(byte)0x30,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_10_4_0_0_path =
	{
		(byte)0x20,
		(byte)0x21,
		(byte)0x30,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution5x3_10_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x30,
		(byte)0x31
	} ;
	static readonly byte[] solution5x3_10_4_1_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x21,
		(byte)0x30,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution5x3_10_4_1_3_path =
	{
		(byte)0x31
	} ;
	static readonly byte[] solution5x3_10_4_2_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x31
	} ;
	static readonly byte[] solution5x3_10_4_2_2_path =
	{
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution5x3_11_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x31
	} ;
	static readonly byte[] solution5x3_11_4_0_1_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution5x3_11_4_0_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_11_4_1_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_11_4_1_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x21,
		(byte)0x30,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_11_4_2_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_11_4_2_3_path =
	{
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_12_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x30,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x31,
		(byte)0x20,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_12_4_1_1_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x31,
		(byte)0x20,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution5x3_12_4_1_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x21,
		(byte)0x30,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_12_4_2_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x31,
		(byte)0x31,
		(byte)0x20,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_12_4_2_2_path =
	{
		(byte)0x20,
		(byte)0x31,
		(byte)0x21,
		(byte)0x30,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x31,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution5x3_13_4_1_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x31,
		(byte)0x21,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution5x3_13_4_2_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x21,
		(byte)0x30
	} ;
	static readonly byte[] solution5x3_13_4_2_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x21,
		(byte)0x21,
		(byte)0x30,
		(byte)0x21,
		(byte)0x20,
		(byte)0x31
	} ;

// Solutions for 5x3 puzzle
	public static readonly solutionPath[] solution5x3 = {
		new solutionPath { tID=0, tY = 0, tX = 0, tA = 2, solution = solution5x3_0_0_0_2_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 1, solution = solution5x3_0_0_1_1_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 3, solution = solution5x3_0_0_1_3_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 0, solution = solution5x3_0_0_2_0_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 2, solution = solution5x3_0_0_2_2_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 1, solution = solution5x3_0_1_0_1_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 3, solution = solution5x3_0_1_0_3_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 0, solution = solution5x3_0_1_1_0_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 2, solution = solution5x3_0_1_1_2_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 1, solution = solution5x3_0_1_2_1_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 3, solution = solution5x3_0_1_2_3_path },
		new solutionPath { tID=0, tY = 2, tX = 0, tA = 0, solution = solution5x3_0_2_0_0_path },
		new solutionPath { tID=0, tY = 2, tX = 0, tA = 2, solution = solution5x3_0_2_0_2_path },
		new solutionPath { tID=0, tY = 2, tX = 1, tA = 1, solution = solution5x3_0_2_1_1_path },
		new solutionPath { tID=0, tY = 2, tX = 1, tA = 3, solution = solution5x3_0_2_1_3_path },
		new solutionPath { tID=0, tY = 2, tX = 2, tA = 0, solution = solution5x3_0_2_2_0_path },
		new solutionPath { tID=0, tY = 2, tX = 2, tA = 2, solution = solution5x3_0_2_2_2_path },
		new solutionPath { tID=0, tY = 3, tX = 0, tA = 1, solution = solution5x3_0_3_0_1_path },
		new solutionPath { tID=0, tY = 3, tX = 0, tA = 3, solution = solution5x3_0_3_0_3_path },
		new solutionPath { tID=0, tY = 3, tX = 1, tA = 0, solution = solution5x3_0_3_1_0_path },
		new solutionPath { tID=0, tY = 3, tX = 1, tA = 2, solution = solution5x3_0_3_1_2_path },
		new solutionPath { tID=0, tY = 3, tX = 2, tA = 1, solution = solution5x3_0_3_2_1_path },
		new solutionPath { tID=0, tY = 3, tX = 2, tA = 3, solution = solution5x3_0_3_2_3_path },
		new solutionPath { tID=0, tY = 4, tX = 0, tA = 0, solution = solution5x3_0_4_0_0_path },
		new solutionPath { tID=0, tY = 4, tX = 0, tA = 2, solution = solution5x3_0_4_0_2_path },
		new solutionPath { tID=0, tY = 4, tX = 1, tA = 1, solution = solution5x3_0_4_1_1_path },
		new solutionPath { tID=0, tY = 4, tX = 1, tA = 3, solution = solution5x3_0_4_1_3_path },
		new solutionPath { tID=0, tY = 4, tX = 2, tA = 0, solution = solution5x3_0_4_2_0_path },
		new solutionPath { tID=0, tY = 4, tX = 2, tA = 2, solution = solution5x3_0_4_2_2_path },
		new solutionPath { tID=1, tY = 0, tX = 1, tA = 2, solution = solution5x3_1_0_1_2_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 1, solution = solution5x3_1_0_2_1_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 3, solution = solution5x3_1_0_2_3_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 0, solution = solution5x3_1_1_0_0_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 2, solution = solution5x3_1_1_0_2_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 1, solution = solution5x3_1_1_1_1_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 3, solution = solution5x3_1_1_1_3_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 0, solution = solution5x3_1_1_2_0_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 2, solution = solution5x3_1_1_2_2_path },
		new solutionPath { tID=1, tY = 2, tX = 0, tA = 1, solution = solution5x3_1_2_0_1_path },
		new solutionPath { tID=1, tY = 2, tX = 0, tA = 3, solution = solution5x3_1_2_0_3_path },
		new solutionPath { tID=1, tY = 2, tX = 1, tA = 0, solution = solution5x3_1_2_1_0_path },
		new solutionPath { tID=1, tY = 2, tX = 1, tA = 2, solution = solution5x3_1_2_1_2_path },
		new solutionPath { tID=1, tY = 2, tX = 2, tA = 1, solution = solution5x3_1_2_2_1_path },
		new solutionPath { tID=1, tY = 2, tX = 2, tA = 3, solution = solution5x3_1_2_2_3_path },
		new solutionPath { tID=1, tY = 3, tX = 0, tA = 0, solution = solution5x3_1_3_0_0_path },
		new solutionPath { tID=1, tY = 3, tX = 0, tA = 2, solution = solution5x3_1_3_0_2_path },
		new solutionPath { tID=1, tY = 3, tX = 1, tA = 1, solution = solution5x3_1_3_1_1_path },
		new solutionPath { tID=1, tY = 3, tX = 1, tA = 3, solution = solution5x3_1_3_1_3_path },
		new solutionPath { tID=1, tY = 3, tX = 2, tA = 0, solution = solution5x3_1_3_2_0_path },
		new solutionPath { tID=1, tY = 3, tX = 2, tA = 2, solution = solution5x3_1_3_2_2_path },
		new solutionPath { tID=1, tY = 4, tX = 0, tA = 1, solution = solution5x3_1_4_0_1_path },
		new solutionPath { tID=1, tY = 4, tX = 0, tA = 3, solution = solution5x3_1_4_0_3_path },
		new solutionPath { tID=1, tY = 4, tX = 1, tA = 0, solution = solution5x3_1_4_1_0_path },
		new solutionPath { tID=1, tY = 4, tX = 1, tA = 2, solution = solution5x3_1_4_1_2_path },
		new solutionPath { tID=1, tY = 4, tX = 2, tA = 1, solution = solution5x3_1_4_2_1_path },
		new solutionPath { tID=1, tY = 4, tX = 2, tA = 3, solution = solution5x3_1_4_2_3_path },
		new solutionPath { tID=2, tY = 0, tX = 2, tA = 2, solution = solution5x3_2_0_2_2_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 1, solution = solution5x3_2_1_0_1_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 3, solution = solution5x3_2_1_0_3_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 0, solution = solution5x3_2_1_1_0_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 2, solution = solution5x3_2_1_1_2_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 1, solution = solution5x3_2_1_2_1_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 3, solution = solution5x3_2_1_2_3_path },
		new solutionPath { tID=2, tY = 2, tX = 0, tA = 0, solution = solution5x3_2_2_0_0_path },
		new solutionPath { tID=2, tY = 2, tX = 0, tA = 2, solution = solution5x3_2_2_0_2_path },
		new solutionPath { tID=2, tY = 2, tX = 1, tA = 1, solution = solution5x3_2_2_1_1_path },
		new solutionPath { tID=2, tY = 2, tX = 1, tA = 3, solution = solution5x3_2_2_1_3_path },
		new solutionPath { tID=2, tY = 2, tX = 2, tA = 0, solution = solution5x3_2_2_2_0_path },
		new solutionPath { tID=2, tY = 2, tX = 2, tA = 2, solution = solution5x3_2_2_2_2_path },
		new solutionPath { tID=2, tY = 3, tX = 0, tA = 1, solution = solution5x3_2_3_0_1_path },
		new solutionPath { tID=2, tY = 3, tX = 0, tA = 3, solution = solution5x3_2_3_0_3_path },
		new solutionPath { tID=2, tY = 3, tX = 1, tA = 0, solution = solution5x3_2_3_1_0_path },
		new solutionPath { tID=2, tY = 3, tX = 1, tA = 2, solution = solution5x3_2_3_1_2_path },
		new solutionPath { tID=2, tY = 3, tX = 2, tA = 1, solution = solution5x3_2_3_2_1_path },
		new solutionPath { tID=2, tY = 3, tX = 2, tA = 3, solution = solution5x3_2_3_2_3_path },
		new solutionPath { tID=2, tY = 4, tX = 0, tA = 0, solution = solution5x3_2_4_0_0_path },
		new solutionPath { tID=2, tY = 4, tX = 0, tA = 2, solution = solution5x3_2_4_0_2_path },
		new solutionPath { tID=2, tY = 4, tX = 1, tA = 1, solution = solution5x3_2_4_1_1_path },
		new solutionPath { tID=2, tY = 4, tX = 1, tA = 3, solution = solution5x3_2_4_1_3_path },
		new solutionPath { tID=2, tY = 4, tX = 2, tA = 0, solution = solution5x3_2_4_2_0_path },
		new solutionPath { tID=2, tY = 4, tX = 2, tA = 2, solution = solution5x3_2_4_2_2_path },
		new solutionPath { tID=3, tY = 1, tX = 0, tA = 2, solution = solution5x3_3_1_0_2_path },
		new solutionPath { tID=3, tY = 1, tX = 1, tA = 1, solution = solution5x3_3_1_1_1_path },
		new solutionPath { tID=3, tY = 1, tX = 1, tA = 3, solution = solution5x3_3_1_1_3_path },
		new solutionPath { tID=3, tY = 1, tX = 2, tA = 0, solution = solution5x3_3_1_2_0_path },
		new solutionPath { tID=3, tY = 1, tX = 2, tA = 2, solution = solution5x3_3_1_2_2_path },
		new solutionPath { tID=3, tY = 2, tX = 0, tA = 1, solution = solution5x3_3_2_0_1_path },
		new solutionPath { tID=3, tY = 2, tX = 0, tA = 3, solution = solution5x3_3_2_0_3_path },
		new solutionPath { tID=3, tY = 2, tX = 1, tA = 0, solution = solution5x3_3_2_1_0_path },
		new solutionPath { tID=3, tY = 2, tX = 1, tA = 2, solution = solution5x3_3_2_1_2_path },
		new solutionPath { tID=3, tY = 2, tX = 2, tA = 1, solution = solution5x3_3_2_2_1_path },
		new solutionPath { tID=3, tY = 2, tX = 2, tA = 3, solution = solution5x3_3_2_2_3_path },
		new solutionPath { tID=3, tY = 3, tX = 0, tA = 0, solution = solution5x3_3_3_0_0_path },
		new solutionPath { tID=3, tY = 3, tX = 0, tA = 2, solution = solution5x3_3_3_0_2_path },
		new solutionPath { tID=3, tY = 3, tX = 1, tA = 1, solution = solution5x3_3_3_1_1_path },
		new solutionPath { tID=3, tY = 3, tX = 1, tA = 3, solution = solution5x3_3_3_1_3_path },
		new solutionPath { tID=3, tY = 3, tX = 2, tA = 0, solution = solution5x3_3_3_2_0_path },
		new solutionPath { tID=3, tY = 3, tX = 2, tA = 2, solution = solution5x3_3_3_2_2_path },
		new solutionPath { tID=3, tY = 4, tX = 0, tA = 1, solution = solution5x3_3_4_0_1_path },
		new solutionPath { tID=3, tY = 4, tX = 0, tA = 3, solution = solution5x3_3_4_0_3_path },
		new solutionPath { tID=3, tY = 4, tX = 1, tA = 0, solution = solution5x3_3_4_1_0_path },
		new solutionPath { tID=3, tY = 4, tX = 1, tA = 2, solution = solution5x3_3_4_1_2_path },
		new solutionPath { tID=3, tY = 4, tX = 2, tA = 1, solution = solution5x3_3_4_2_1_path },
		new solutionPath { tID=3, tY = 4, tX = 2, tA = 3, solution = solution5x3_3_4_2_3_path },
		new solutionPath { tID=4, tY = 1, tX = 1, tA = 2, solution = solution5x3_4_1_1_2_path },
		new solutionPath { tID=4, tY = 1, tX = 2, tA = 1, solution = solution5x3_4_1_2_1_path },
		new solutionPath { tID=4, tY = 1, tX = 2, tA = 3, solution = solution5x3_4_1_2_3_path },
		new solutionPath { tID=4, tY = 2, tX = 0, tA = 0, solution = solution5x3_4_2_0_0_path },
		new solutionPath { tID=4, tY = 2, tX = 0, tA = 2, solution = solution5x3_4_2_0_2_path },
		new solutionPath { tID=4, tY = 2, tX = 1, tA = 1, solution = solution5x3_4_2_1_1_path },
		new solutionPath { tID=4, tY = 2, tX = 1, tA = 3, solution = solution5x3_4_2_1_3_path },
		new solutionPath { tID=4, tY = 2, tX = 2, tA = 0, solution = solution5x3_4_2_2_0_path },
		new solutionPath { tID=4, tY = 2, tX = 2, tA = 2, solution = solution5x3_4_2_2_2_path },
		new solutionPath { tID=4, tY = 3, tX = 0, tA = 1, solution = solution5x3_4_3_0_1_path },
		new solutionPath { tID=4, tY = 3, tX = 0, tA = 3, solution = solution5x3_4_3_0_3_path },
		new solutionPath { tID=4, tY = 3, tX = 1, tA = 0, solution = solution5x3_4_3_1_0_path },
		new solutionPath { tID=4, tY = 3, tX = 1, tA = 2, solution = solution5x3_4_3_1_2_path },
		new solutionPath { tID=4, tY = 3, tX = 2, tA = 1, solution = solution5x3_4_3_2_1_path },
		new solutionPath { tID=4, tY = 3, tX = 2, tA = 3, solution = solution5x3_4_3_2_3_path },
		new solutionPath { tID=4, tY = 4, tX = 0, tA = 0, solution = solution5x3_4_4_0_0_path },
		new solutionPath { tID=4, tY = 4, tX = 0, tA = 2, solution = solution5x3_4_4_0_2_path },
		new solutionPath { tID=4, tY = 4, tX = 1, tA = 1, solution = solution5x3_4_4_1_1_path },
		new solutionPath { tID=4, tY = 4, tX = 1, tA = 3, solution = solution5x3_4_4_1_3_path },
		new solutionPath { tID=4, tY = 4, tX = 2, tA = 0, solution = solution5x3_4_4_2_0_path },
		new solutionPath { tID=4, tY = 4, tX = 2, tA = 2, solution = solution5x3_4_4_2_2_path },
		new solutionPath { tID=5, tY = 1, tX = 2, tA = 2, solution = solution5x3_5_1_2_2_path },
		new solutionPath { tID=5, tY = 2, tX = 0, tA = 1, solution = solution5x3_5_2_0_1_path },
		new solutionPath { tID=5, tY = 2, tX = 0, tA = 3, solution = solution5x3_5_2_0_3_path },
		new solutionPath { tID=5, tY = 2, tX = 1, tA = 0, solution = solution5x3_5_2_1_0_path },
		new solutionPath { tID=5, tY = 2, tX = 1, tA = 2, solution = solution5x3_5_2_1_2_path },
		new solutionPath { tID=5, tY = 2, tX = 2, tA = 1, solution = solution5x3_5_2_2_1_path },
		new solutionPath { tID=5, tY = 2, tX = 2, tA = 3, solution = solution5x3_5_2_2_3_path },
		new solutionPath { tID=5, tY = 3, tX = 0, tA = 0, solution = solution5x3_5_3_0_0_path },
		new solutionPath { tID=5, tY = 3, tX = 0, tA = 2, solution = solution5x3_5_3_0_2_path },
		new solutionPath { tID=5, tY = 3, tX = 1, tA = 1, solution = solution5x3_5_3_1_1_path },
		new solutionPath { tID=5, tY = 3, tX = 1, tA = 3, solution = solution5x3_5_3_1_3_path },
		new solutionPath { tID=5, tY = 3, tX = 2, tA = 0, solution = solution5x3_5_3_2_0_path },
		new solutionPath { tID=5, tY = 3, tX = 2, tA = 2, solution = solution5x3_5_3_2_2_path },
		new solutionPath { tID=5, tY = 4, tX = 0, tA = 1, solution = solution5x3_5_4_0_1_path },
		new solutionPath { tID=5, tY = 4, tX = 0, tA = 3, solution = solution5x3_5_4_0_3_path },
		new solutionPath { tID=5, tY = 4, tX = 1, tA = 0, solution = solution5x3_5_4_1_0_path },
		new solutionPath { tID=5, tY = 4, tX = 1, tA = 2, solution = solution5x3_5_4_1_2_path },
		new solutionPath { tID=5, tY = 4, tX = 2, tA = 1, solution = solution5x3_5_4_2_1_path },
		new solutionPath { tID=5, tY = 4, tX = 2, tA = 3, solution = solution5x3_5_4_2_3_path },
		new solutionPath { tID=6, tY = 2, tX = 0, tA = 2, solution = solution5x3_6_2_0_2_path },
		new solutionPath { tID=6, tY = 2, tX = 1, tA = 1, solution = solution5x3_6_2_1_1_path },
		new solutionPath { tID=6, tY = 2, tX = 1, tA = 3, solution = solution5x3_6_2_1_3_path },
		new solutionPath { tID=6, tY = 2, tX = 2, tA = 0, solution = solution5x3_6_2_2_0_path },
		new solutionPath { tID=6, tY = 2, tX = 2, tA = 2, solution = solution5x3_6_2_2_2_path },
		new solutionPath { tID=6, tY = 3, tX = 0, tA = 1, solution = solution5x3_6_3_0_1_path },
		new solutionPath { tID=6, tY = 3, tX = 0, tA = 3, solution = solution5x3_6_3_0_3_path },
		new solutionPath { tID=6, tY = 3, tX = 1, tA = 0, solution = solution5x3_6_3_1_0_path },
		new solutionPath { tID=6, tY = 3, tX = 1, tA = 2, solution = solution5x3_6_3_1_2_path },
		new solutionPath { tID=6, tY = 3, tX = 2, tA = 1, solution = solution5x3_6_3_2_1_path },
		new solutionPath { tID=6, tY = 3, tX = 2, tA = 3, solution = solution5x3_6_3_2_3_path },
		new solutionPath { tID=6, tY = 4, tX = 0, tA = 0, solution = solution5x3_6_4_0_0_path },
		new solutionPath { tID=6, tY = 4, tX = 0, tA = 2, solution = solution5x3_6_4_0_2_path },
		new solutionPath { tID=6, tY = 4, tX = 1, tA = 1, solution = solution5x3_6_4_1_1_path },
		new solutionPath { tID=6, tY = 4, tX = 1, tA = 3, solution = solution5x3_6_4_1_3_path },
		new solutionPath { tID=6, tY = 4, tX = 2, tA = 0, solution = solution5x3_6_4_2_0_path },
		new solutionPath { tID=6, tY = 4, tX = 2, tA = 2, solution = solution5x3_6_4_2_2_path },
		new solutionPath { tID=7, tY = 2, tX = 1, tA = 2, solution = solution5x3_7_2_1_2_path },
		new solutionPath { tID=7, tY = 2, tX = 2, tA = 1, solution = solution5x3_7_2_2_1_path },
		new solutionPath { tID=7, tY = 2, tX = 2, tA = 3, solution = solution5x3_7_2_2_3_path },
		new solutionPath { tID=7, tY = 3, tX = 0, tA = 0, solution = solution5x3_7_3_0_0_path },
		new solutionPath { tID=7, tY = 3, tX = 0, tA = 2, solution = solution5x3_7_3_0_2_path },
		new solutionPath { tID=7, tY = 3, tX = 1, tA = 1, solution = solution5x3_7_3_1_1_path },
		new solutionPath { tID=7, tY = 3, tX = 1, tA = 3, solution = solution5x3_7_3_1_3_path },
		new solutionPath { tID=7, tY = 3, tX = 2, tA = 0, solution = solution5x3_7_3_2_0_path },
		new solutionPath { tID=7, tY = 3, tX = 2, tA = 2, solution = solution5x3_7_3_2_2_path },
		new solutionPath { tID=7, tY = 4, tX = 0, tA = 1, solution = solution5x3_7_4_0_1_path },
		new solutionPath { tID=7, tY = 4, tX = 0, tA = 3, solution = solution5x3_7_4_0_3_path },
		new solutionPath { tID=7, tY = 4, tX = 1, tA = 0, solution = solution5x3_7_4_1_0_path },
		new solutionPath { tID=7, tY = 4, tX = 1, tA = 2, solution = solution5x3_7_4_1_2_path },
		new solutionPath { tID=7, tY = 4, tX = 2, tA = 1, solution = solution5x3_7_4_2_1_path },
		new solutionPath { tID=7, tY = 4, tX = 2, tA = 3, solution = solution5x3_7_4_2_3_path },
		new solutionPath { tID=8, tY = 2, tX = 2, tA = 2, solution = solution5x3_8_2_2_2_path },
		new solutionPath { tID=8, tY = 3, tX = 0, tA = 1, solution = solution5x3_8_3_0_1_path },
		new solutionPath { tID=8, tY = 3, tX = 0, tA = 3, solution = solution5x3_8_3_0_3_path },
		new solutionPath { tID=8, tY = 3, tX = 1, tA = 0, solution = solution5x3_8_3_1_0_path },
		new solutionPath { tID=8, tY = 3, tX = 1, tA = 2, solution = solution5x3_8_3_1_2_path },
		new solutionPath { tID=8, tY = 3, tX = 2, tA = 1, solution = solution5x3_8_3_2_1_path },
		new solutionPath { tID=8, tY = 3, tX = 2, tA = 3, solution = solution5x3_8_3_2_3_path },
		new solutionPath { tID=8, tY = 4, tX = 0, tA = 0, solution = solution5x3_8_4_0_0_path },
		new solutionPath { tID=8, tY = 4, tX = 0, tA = 2, solution = solution5x3_8_4_0_2_path },
		new solutionPath { tID=8, tY = 4, tX = 1, tA = 1, solution = solution5x3_8_4_1_1_path },
		new solutionPath { tID=8, tY = 4, tX = 1, tA = 3, solution = solution5x3_8_4_1_3_path },
		new solutionPath { tID=8, tY = 4, tX = 2, tA = 0, solution = solution5x3_8_4_2_0_path },
		new solutionPath { tID=8, tY = 4, tX = 2, tA = 2, solution = solution5x3_8_4_2_2_path },
		new solutionPath { tID=9, tY = 3, tX = 0, tA = 2, solution = solution5x3_9_3_0_2_path },
		new solutionPath { tID=9, tY = 3, tX = 1, tA = 1, solution = solution5x3_9_3_1_1_path },
		new solutionPath { tID=9, tY = 3, tX = 1, tA = 3, solution = solution5x3_9_3_1_3_path },
		new solutionPath { tID=9, tY = 3, tX = 2, tA = 0, solution = solution5x3_9_3_2_0_path },
		new solutionPath { tID=9, tY = 3, tX = 2, tA = 2, solution = solution5x3_9_3_2_2_path },
		new solutionPath { tID=9, tY = 4, tX = 0, tA = 1, solution = solution5x3_9_4_0_1_path },
		new solutionPath { tID=9, tY = 4, tX = 0, tA = 3, solution = solution5x3_9_4_0_3_path },
		new solutionPath { tID=9, tY = 4, tX = 1, tA = 0, solution = solution5x3_9_4_1_0_path },
		new solutionPath { tID=9, tY = 4, tX = 1, tA = 2, solution = solution5x3_9_4_1_2_path },
		new solutionPath { tID=9, tY = 4, tX = 2, tA = 1, solution = solution5x3_9_4_2_1_path },
		new solutionPath { tID=9, tY = 4, tX = 2, tA = 3, solution = solution5x3_9_4_2_3_path },
		new solutionPath { tID=10, tY = 3, tX = 1, tA = 2, solution = solution5x3_10_3_1_2_path },
		new solutionPath { tID=10, tY = 3, tX = 2, tA = 1, solution = solution5x3_10_3_2_1_path },
		new solutionPath { tID=10, tY = 3, tX = 2, tA = 3, solution = solution5x3_10_3_2_3_path },
		new solutionPath { tID=10, tY = 4, tX = 0, tA = 0, solution = solution5x3_10_4_0_0_path },
		new solutionPath { tID=10, tY = 4, tX = 0, tA = 2, solution = solution5x3_10_4_0_2_path },
		new solutionPath { tID=10, tY = 4, tX = 1, tA = 1, solution = solution5x3_10_4_1_1_path },
		new solutionPath { tID=10, tY = 4, tX = 1, tA = 3, solution = solution5x3_10_4_1_3_path },
		new solutionPath { tID=10, tY = 4, tX = 2, tA = 0, solution = solution5x3_10_4_2_0_path },
		new solutionPath { tID=10, tY = 4, tX = 2, tA = 2, solution = solution5x3_10_4_2_2_path },
		new solutionPath { tID=11, tY = 3, tX = 2, tA = 2, solution = solution5x3_11_3_2_2_path },
		new solutionPath { tID=11, tY = 4, tX = 0, tA = 1, solution = solution5x3_11_4_0_1_path },
		new solutionPath { tID=11, tY = 4, tX = 0, tA = 3, solution = solution5x3_11_4_0_3_path },
		new solutionPath { tID=11, tY = 4, tX = 1, tA = 0, solution = solution5x3_11_4_1_0_path },
		new solutionPath { tID=11, tY = 4, tX = 1, tA = 2, solution = solution5x3_11_4_1_2_path },
		new solutionPath { tID=11, tY = 4, tX = 2, tA = 1, solution = solution5x3_11_4_2_1_path },
		new solutionPath { tID=11, tY = 4, tX = 2, tA = 3, solution = solution5x3_11_4_2_3_path },
		new solutionPath { tID=12, tY = 4, tX = 0, tA = 2, solution = solution5x3_12_4_0_2_path },
		new solutionPath { tID=12, tY = 4, tX = 1, tA = 1, solution = solution5x3_12_4_1_1_path },
		new solutionPath { tID=12, tY = 4, tX = 1, tA = 3, solution = solution5x3_12_4_1_3_path },
		new solutionPath { tID=12, tY = 4, tX = 2, tA = 0, solution = solution5x3_12_4_2_0_path },
		new solutionPath { tID=12, tY = 4, tX = 2, tA = 2, solution = solution5x3_12_4_2_2_path },
		new solutionPath { tID=13, tY = 4, tX = 1, tA = 2, solution = solution5x3_13_4_1_2_path },
		new solutionPath { tID=13, tY = 4, tX = 2, tA = 1, solution = solution5x3_13_4_2_1_path },
		new solutionPath { tID=13, tY = 4, tX = 2, tA = 3, solution = solution5x3_13_4_2_3_path }
	};

}
