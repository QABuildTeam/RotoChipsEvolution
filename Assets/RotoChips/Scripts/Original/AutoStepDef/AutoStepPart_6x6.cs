using UnityEngine;
using System.Collections;

public class AutoStepPart_6x6 : MonoBehaviour
{

	static readonly byte[] solution6x6_0_0_0_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_0_1_1_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_0_1_3_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_0_2_0_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_0_2_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_0_3_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_0_3_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_0_4_0_path =
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
	static readonly byte[] solution6x6_0_0_4_2_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_0_5_1_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_0_5_3_path =
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
	static readonly byte[] solution6x6_0_1_0_1_path =
	{
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_1_0_3_path =
	{
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_1_1_0_path =
	{
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_1_1_2_path =
	{
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_1_2_1_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_1_2_3_path =
	{
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_1_3_0_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_1_3_2_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_1_4_1_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_1_4_3_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_1_5_0_path =
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
	static readonly byte[] solution6x6_0_1_5_2_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_2_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_2_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_2_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_2_2_2_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_2_3_1_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_2_4_0_path =
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
	static readonly byte[] solution6x6_0_2_4_2_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_2_5_1_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_2_5_3_path =
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
	static readonly byte[] solution6x6_0_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_3_1_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_3_1_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_3_3_0_path =
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
	static readonly byte[] solution6x6_0_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_3_4_1_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_3_4_3_path =
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
	static readonly byte[] solution6x6_0_3_5_0_path =
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
	static readonly byte[] solution6x6_0_3_5_2_path =
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
	static readonly byte[] solution6x6_0_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_4_1_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_4_1_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_4_2_0_path =
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
	static readonly byte[] solution6x6_0_4_2_2_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_4_3_1_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_4_3_3_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_4_4_0_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_4_4_2_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_4_5_1_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_4_5_3_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_5_0_1_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_5_0_3_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_5_1_0_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_5_1_2_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_5_2_1_path =
	{
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_5_2_3_path =
	{
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_5_3_0_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_5_3_2_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_5_4_1_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_5_4_3_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_5_5_0_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_0_5_5_2_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_1_0_1_2_path =
	{
		(byte)0x00,
		(byte)0x10,
		(byte)0x11,
		(byte)0x00,
		(byte)0x00,
		(byte)0x00
	} ;
	static readonly byte[] solution6x6_1_0_2_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_0_2_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_0_3_0_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_0_3_2_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_0_4_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_0_4_3_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_0_5_0_path =
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
	static readonly byte[] solution6x6_1_0_5_2_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_1_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_1_1_1_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_1_1_3_path =
	{
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_1_2_0_path =
	{
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_1_2_2_path =
	{
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_1_3_1_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_1_3_3_path =
	{
		(byte)0x02,
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_1_4_0_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_1_4_2_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_1_5_1_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_1_5_3_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_2_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_2_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_2_1_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_2_1_2_path =
	{
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_2_2_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_2_4_1_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_2_4_3_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_2_5_0_path =
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
	static readonly byte[] solution6x6_1_2_5_2_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_3_1_1_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_3_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_3_2_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_3_3_1_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_3_4_0_path =
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
	static readonly byte[] solution6x6_1_3_4_2_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_3_5_3_path =
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
	static readonly byte[] solution6x6_1_4_0_1_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_4_0_3_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_4_1_0_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_4_1_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_4_2_1_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_4_2_3_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_4_3_0_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_4_3_2_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_4_4_1_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_4_4_3_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_4_5_0_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_4_5_2_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_5_0_0_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_5_0_2_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_5_1_1_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_5_1_3_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_5_2_0_path =
	{
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_5_2_2_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_5_3_1_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_5_3_3_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_5_4_0_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_5_4_2_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_5_5_1_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_1_5_5_3_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x01
	} ;
	static readonly byte[] solution6x6_2_0_2_2_path =
	{
		(byte)0x00,
		(byte)0x00,
		(byte)0x00,
		(byte)0x01,
		(byte)0x00,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_0_3_1_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_0_3_3_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_0_4_0_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_0_4_2_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x02,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_0_5_1_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_0_5_3_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_1_0_1_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_1_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_1_1_0_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_1_1_2_path =
	{
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_1_2_1_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_1_2_3_path =
	{
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_1_3_0_path =
	{
		(byte)0x02,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_1_3_2_path =
	{
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_1_4_1_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_1_4_3_path =
	{
		(byte)0x03,
		(byte)0x02,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_1_5_0_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_1_5_2_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x11,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_2_0_0_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_2_1_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_2_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_2_2_2_path =
	{
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_2_3_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_2_4_0_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_2_4_2_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_2_5_1_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_2_5_3_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_3_1_0_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_3_1_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_3_2_1_path =
	{
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_3_3_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_3_4_1_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_3_4_3_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_3_5_0_path =
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
	static readonly byte[] solution6x6_2_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_4_1_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_4_1_3_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_4_2_0_path =
	{
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_4_2_2_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_4_3_1_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_4_3_3_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_4_4_0_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_4_4_2_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_4_5_1_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_4_5_3_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_5_0_1_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_5_0_3_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_5_1_0_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_5_1_2_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_5_2_1_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_5_2_3_path =
	{
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_5_3_0_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_5_3_2_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_5_4_1_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_5_4_3_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_5_5_0_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_2_5_5_2_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_3_0_3_2_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x01,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_0_4_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_0_4_3_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x12,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_0_5_0_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_0_5_2_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x12,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_1_0_0_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_1_1_1_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_1_1_3_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_1_2_0_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_1_2_2_path =
	{
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_1_3_1_path =
	{
		(byte)0x12,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_1_3_3_path =
	{
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_1_4_0_path =
	{
		(byte)0x03,
		(byte)0x12,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_1_4_2_path =
	{
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_1_5_1_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_1_5_3_path =
	{
		(byte)0x04,
		(byte)0x03,
		(byte)0x12,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_2_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_2_0_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_2_1_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_2_1_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_2_2_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_2_3_2_path =
	{
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_2_4_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_2_4_3_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_2_5_0_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_2_5_2_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_3_0_0_path =
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
	static readonly byte[] solution6x6_3_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_3_1_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_3_1_3_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_3_2_0_path =
	{
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_3_3_1_path =
	{
		(byte)0x23,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_3_4_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_3_4_2_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_4_0_1_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_4_0_3_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_4_1_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_4_1_2_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_4_2_1_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_4_2_3_path =
	{
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_4_3_0_path =
	{
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_4_3_2_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_4_4_1_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_4_4_3_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_4_5_0_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_4_5_2_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_5_0_0_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_5_0_2_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_5_1_1_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_5_1_3_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_5_2_0_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_5_2_2_path =
	{
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_5_3_1_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_5_3_3_path =
	{
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_5_4_0_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_5_4_2_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_5_5_1_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_3_5_5_3_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_4_0_4_2_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_0_5_1_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_0_5_3_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_1_0_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_1_0_3_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_1_1_0_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_1_1_2_path =
	{
		(byte)0x10,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_1_2_1_path =
	{
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_1_2_3_path =
	{
		(byte)0x11,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_1_3_0_path =
	{
		(byte)0x12,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_1_3_2_path =
	{
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_1_4_1_path =
	{
		(byte)0x13,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_1_4_3_path =
	{
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_1_5_0_path =
	{
		(byte)0x04,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_1_5_2_path =
	{
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_2_0_0_path =
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
	static readonly byte[] solution6x6_4_2_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_2_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_2_1_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_2_2_0_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_2_2_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_2_3_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_2_4_0_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_2_4_2_path =
	{
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_2_5_1_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_2_5_3_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_3_0_3_path =
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
	static readonly byte[] solution6x6_4_3_1_0_path =
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
	static readonly byte[] solution6x6_4_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_3_2_3_path =
	{
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_3_3_0_path =
	{
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_3_4_1_path =
	{
		(byte)0x24,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_3_4_3_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_3_5_0_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_4_0_2_path =
	{
		(byte)0x30,
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
	static readonly byte[] solution6x6_4_4_1_1_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_4_1_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_4_2_0_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_4_2_2_path =
	{
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_4_3_1_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_4_3_3_path =
	{
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_4_4_0_path =
	{
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_4_4_2_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_4_5_1_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_4_5_3_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_5_0_1_path =
	{
		(byte)0x40,
		(byte)0x30,
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
	static readonly byte[] solution6x6_4_5_0_3_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_5_1_0_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_5_1_2_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_5_2_1_path =
	{
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_5_2_3_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_5_3_0_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_5_3_2_path =
	{
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_5_4_1_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_5_4_3_path =
	{
		(byte)0x44,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_5_5_0_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_4_5_5_2_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_0_5_2_path =
	{
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_1_0_0_path =
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
		(byte)0x04,
		(byte)0x03,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_1_0_2_path =
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
		(byte)0x04,
		(byte)0x03,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_1_1_1_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x04,
		(byte)0x03,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_1_1_3_path =
	{
		(byte)0x01,
		(byte)0x01,
		(byte)0x01,
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x01,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_1_2_0_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x04,
		(byte)0x03,
		(byte)0x02
	} ;
	static readonly byte[] solution6x6_5_1_2_2_path =
	{
		(byte)0x02,
		(byte)0x02,
		(byte)0x02,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03,
		(byte)0x02,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_1_3_1_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x13,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_1_3_3_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_5_1_4_0_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_5_1_4_2_path =
	{
		(byte)0x14,
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_1_5_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_5_1_5_3_path =
	{
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_2_0_1_path =
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
	static readonly byte[] solution6x6_5_2_0_3_path =
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
	static readonly byte[] solution6x6_5_2_1_0_path =
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
	static readonly byte[] solution6x6_5_2_1_2_path =
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
	static readonly byte[] solution6x6_5_2_2_1_path =
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
	static readonly byte[] solution6x6_5_2_2_3_path =
	{
		(byte)0x03,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_5_2_3_0_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_2_3_2_path =
	{
		(byte)0x04,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_2_4_1_path =
	{
		(byte)0x03,
		(byte)0x03,
		(byte)0x03,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_5_2_4_3_path =
	{
		(byte)0x04,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_2_5_0_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_2_5_2_path =
	{
		(byte)0x04,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_3_0_0_path =
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
	static readonly byte[] solution6x6_5_3_0_2_path =
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
	static readonly byte[] solution6x6_5_3_1_1_path =
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
	static readonly byte[] solution6x6_5_3_1_3_path =
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
	static readonly byte[] solution6x6_5_3_2_0_path =
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
	static readonly byte[] solution6x6_5_3_2_2_path =
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
	static readonly byte[] solution6x6_5_3_3_1_path =
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
	static readonly byte[] solution6x6_5_3_3_3_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_3_4_0_path =
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
	static readonly byte[] solution6x6_5_3_4_2_path =
	{
		(byte)0x04,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_3_5_1_path =
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
	static readonly byte[] solution6x6_5_3_5_3_path =
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
	static readonly byte[] solution6x6_5_4_0_1_path =
	{
		(byte)0x30,
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
	static readonly byte[] solution6x6_5_4_0_3_path =
	{
		(byte)0x30,
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
	static readonly byte[] solution6x6_5_4_1_0_path =
	{
		(byte)0x03,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_5_4_1_2_path =
	{
		(byte)0x04,
		(byte)0x31,
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
	static readonly byte[] solution6x6_5_4_2_1_path =
	{
		(byte)0x03,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_5_4_2_3_path =
	{
		(byte)0x04,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_4_3_0_path =
	{
		(byte)0x04,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_4_3_2_path =
	{
		(byte)0x04,
		(byte)0x04,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_4_4_1_path =
	{
		(byte)0x04,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_4_4_3_path =
	{
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_4_5_0_path =
	{
		(byte)0x04,
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_4_5_2_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_5_0_0_path =
	{
		(byte)0x40,
		(byte)0x30,
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
	static readonly byte[] solution6x6_5_5_0_2_path =
	{
		(byte)0x40,
		(byte)0x30,
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
	static readonly byte[] solution6x6_5_5_1_1_path =
	{
		(byte)0x41,
		(byte)0x04,
		(byte)0x31,
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
	static readonly byte[] solution6x6_5_5_1_3_path =
	{
		(byte)0x41,
		(byte)0x03,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_5_5_2_0_path =
	{
		(byte)0x42,
		(byte)0x03,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x03,
		(byte)0x03,
		(byte)0x04,
		(byte)0x03
	} ;
	static readonly byte[] solution6x6_5_5_2_2_path =
	{
		(byte)0x42,
		(byte)0x04,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_5_3_1_path =
	{
		(byte)0x43,
		(byte)0x04,
		(byte)0x04,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_5_3_3_path =
	{
		(byte)0x43,
		(byte)0x04,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_5_4_0_path =
	{
		(byte)0x44,
		(byte)0x04,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_5_4_2_path =
	{
		(byte)0x44,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_5_5_1_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_5_5_5_3_path =
	{
		(byte)0x04,
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x04,
		(byte)0x04,
		(byte)0x04
	} ;
	static readonly byte[] solution6x6_6_1_0_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_1_1_1_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_1_1_3_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_1_2_0_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_1_2_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_1_3_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_1_3_3_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_1_4_0_path =
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
	static readonly byte[] solution6x6_6_1_4_2_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_1_5_1_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_1_5_3_path =
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
	static readonly byte[] solution6x6_6_2_0_1_path =
	{
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_2_0_3_path =
	{
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_2_1_0_path =
	{
		(byte)0x10,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_2_1_2_path =
	{
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_2_2_1_path =
	{
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_2_2_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_2_4_1_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_2_4_3_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_2_5_0_path =
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
	static readonly byte[] solution6x6_6_2_5_2_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_3_1_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_3_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_3_2_0_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_3_3_1_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_3_4_0_path =
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
	static readonly byte[] solution6x6_6_3_4_2_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_3_5_3_path =
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
	static readonly byte[] solution6x6_6_4_0_1_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_4_0_3_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_4_1_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_4_1_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_4_2_1_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_4_2_3_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_4_3_0_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_4_3_2_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_4_4_1_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_4_4_3_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_4_5_0_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_4_5_2_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_5_0_0_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_5_0_2_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_5_1_1_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_5_1_3_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_5_2_0_path =
	{
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_5_2_2_path =
	{
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_5_3_1_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_5_3_3_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_5_4_0_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_5_4_2_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_5_5_1_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x10,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_6_5_5_3_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x10
	} ;
	static readonly byte[] solution6x6_7_1_1_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_1_2_1_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_1_2_3_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_1_3_0_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_1_3_2_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_1_4_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_1_4_3_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_1_5_0_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_1_5_2_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_2_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_2_0_2_path =
	{
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_2_1_1_path =
	{
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_2_1_3_path =
	{
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_2_2_0_path =
	{
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_2_2_2_path =
	{
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_2_3_1_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_2_3_3_path =
	{
		(byte)0x12,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_2_4_0_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_2_4_2_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_2_5_1_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_2_5_3_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_3_1_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_3_3_0_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_3_4_1_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_3_4_3_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_3_5_0_path =
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
	static readonly byte[] solution6x6_7_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_4_1_1_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_4_1_3_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_4_2_0_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_4_2_2_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_4_3_1_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_4_3_3_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_4_4_0_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_4_4_2_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_4_5_1_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_4_5_3_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_5_0_1_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_5_0_3_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_5_1_0_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_5_1_2_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_5_2_1_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_5_2_3_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_5_3_0_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_5_3_2_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_5_4_1_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_5_4_3_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_5_5_0_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_7_5_5_2_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_8_1_2_2_path =
	{
		(byte)0x10,
		(byte)0x10,
		(byte)0x10,
		(byte)0x11,
		(byte)0x10,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_1_3_1_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_1_3_3_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_1_4_0_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_1_4_2_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_1_5_1_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_1_5_3_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_2_0_1_path =
	{
		(byte)0x20,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_2_0_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_2_1_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_2_1_2_path =
	{
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_2_2_1_path =
	{
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_2_2_3_path =
	{
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_2_3_0_path =
	{
		(byte)0x12,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_2_3_2_path =
	{
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_2_4_1_path =
	{
		(byte)0x13,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_2_4_3_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_2_5_0_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_2_5_2_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x12,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_3_1_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_3_1_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_3_2_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_3_2_2_path =
	{
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_3_3_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_3_4_0_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_3_4_2_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_4_0_1_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_4_0_3_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_4_1_0_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_4_1_2_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_4_2_1_path =
	{
		(byte)0x32,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_4_2_3_path =
	{
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_4_3_0_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_4_3_2_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_4_4_1_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_4_4_3_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_4_5_0_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_4_5_2_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_5_0_0_path =
	{
		(byte)0x11,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x11,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_8_5_0_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x11,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_8_5_1_1_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_5_1_3_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_5_2_0_path =
	{
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_5_2_2_path =
	{
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_5_3_1_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_5_3_3_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_5_4_0_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_5_4_2_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_5_5_1_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_8_5_5_3_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_9_1_3_2_path =
	{
		(byte)0x11,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_1_4_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_1_4_3_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x22,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_1_5_0_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_1_5_2_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_2_0_0_path =
	{
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_2_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_2_1_1_path =
	{
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_2_1_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_2_2_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_2_2_2_path =
	{
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_2_3_1_path =
	{
		(byte)0x22,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_2_3_3_path =
	{
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_2_4_0_path =
	{
		(byte)0x13,
		(byte)0x22,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_2_4_2_path =
	{
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_2_5_1_path =
	{
		(byte)0x14,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_2_5_3_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_3_0_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_3_0_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_3_1_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_3_1_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_3_2_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_3_2_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_3_3_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_3_3_2_path =
	{
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_3_4_1_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_3_4_3_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_3_5_0_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_4_1_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_4_1_3_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_4_2_0_path =
	{
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_4_2_2_path =
	{
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_4_3_1_path =
	{
		(byte)0x33,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_4_3_3_path =
	{
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_4_4_0_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_4_4_2_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_4_5_1_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_4_5_3_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_5_0_1_path =
	{
		(byte)0x11,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x11,
		(byte)0x11,
		(byte)0x12,
		(byte)0x11
	} ;
	static readonly byte[] solution6x6_9_5_0_3_path =
	{
		(byte)0x12,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_9_5_1_0_path =
	{
		(byte)0x12,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x12,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_9_5_1_2_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_9_5_2_1_path =
	{
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_5_2_3_path =
	{
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_5_3_0_path =
	{
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_5_3_2_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_5_4_1_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_5_4_3_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_5_5_0_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_9_5_5_2_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_10_1_4_2_path =
	{
		(byte)0x12,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_1_5_1_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_1_5_3_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_2_0_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_2_0_3_path =
	{
		(byte)0x12,
		(byte)0x20,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_10_2_1_0_path =
	{
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_2_1_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_2_2_1_path =
	{
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_2_2_3_path =
	{
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_2_3_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_2_3_2_path =
	{
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_2_4_1_path =
	{
		(byte)0x23,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_2_4_3_path =
	{
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_2_5_0_path =
	{
		(byte)0x14,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_2_5_2_path =
	{
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_3_0_0_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_3_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_3_1_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_3_1_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_3_2_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_3_3_1_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_3_3_3_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_3_4_0_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_3_4_2_path =
	{
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_4_0_1_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_4_0_3_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_4_1_0_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_4_1_2_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_4_2_1_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_4_2_3_path =
	{
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_4_3_0_path =
	{
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_4_3_2_path =
	{
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_4_4_1_path =
	{
		(byte)0x34,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_4_4_3_path =
	{
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_4_5_0_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_4_5_2_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_5_0_0_path =
	{
		(byte)0x12,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_10_5_0_2_path =
	{
		(byte)0x13,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_10_5_1_1_path =
	{
		(byte)0x12,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x12,
		(byte)0x12,
		(byte)0x13,
		(byte)0x12
	} ;
	static readonly byte[] solution6x6_10_5_1_3_path =
	{
		(byte)0x13,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_10_5_2_0_path =
	{
		(byte)0x13,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x13,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_10_5_2_2_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_10_5_3_1_path =
	{
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_5_3_3_path =
	{
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_5_4_0_path =
	{
		(byte)0x44,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_5_4_2_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_5_5_1_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_10_5_5_3_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_1_5_2_path =
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
	static readonly byte[] solution6x6_11_2_0_0_path =
	{
		(byte)0x14,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_2_0_2_path =
	{
		(byte)0x13,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_11_2_1_1_path =
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
	static readonly byte[] solution6x6_11_2_1_3_path =
	{
		(byte)0x13,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_11_2_2_0_path =
	{
		(byte)0x13,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_11_2_2_2_path =
	{
		(byte)0x14,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_2_3_1_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x23,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_2_3_3_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_11_2_4_0_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_11_2_4_2_path =
	{
		(byte)0x24,
		(byte)0x14,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_2_5_1_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_11_2_5_3_path =
	{
		(byte)0x14,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_3_0_1_path =
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
	static readonly byte[] solution6x6_11_3_0_3_path =
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
	static readonly byte[] solution6x6_11_3_1_0_path =
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
	static readonly byte[] solution6x6_11_3_1_2_path =
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
	static readonly byte[] solution6x6_11_3_2_1_path =
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
	static readonly byte[] solution6x6_11_3_2_3_path =
	{
		(byte)0x13,
		(byte)0x22,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_11_3_3_0_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_3_3_2_path =
	{
		(byte)0x14,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_3_4_1_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_3_4_3_path =
	{
		(byte)0x14,
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_3_5_0_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x14,
		(byte)0x24,
		(byte)0x14,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_3_5_2_path =
	{
		(byte)0x14,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_4_0_0_path =
	{
		(byte)0x13,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_11_4_0_2_path =
	{
		(byte)0x14,
		(byte)0x30,
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
	static readonly byte[] solution6x6_11_4_1_1_path =
	{
		(byte)0x13,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_11_4_1_3_path =
	{
		(byte)0x14,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_4_2_0_path =
	{
		(byte)0x14,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_4_2_2_path =
	{
		(byte)0x13,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_11_4_3_1_path =
	{
		(byte)0x14,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_4_3_3_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_4_4_0_path =
	{
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_4_4_2_path =
	{
		(byte)0x14,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_4_5_1_path =
	{
		(byte)0x14,
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_4_5_3_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_5_1_0_path =
	{
		(byte)0x13,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_11_5_1_2_path =
	{
		(byte)0x14,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_5_2_1_path =
	{
		(byte)0x13,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x13,
		(byte)0x13,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_11_5_2_3_path =
	{
		(byte)0x14,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_5_3_0_path =
	{
		(byte)0x14,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_5_3_2_path =
	{
		(byte)0x14,
		(byte)0x14,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_5_4_1_path =
	{
		(byte)0x14,
		(byte)0x44,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_5_4_3_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x44,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_11_5_5_0_path =
	{
		(byte)0x14,
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x14
	} ;
	static readonly byte[] solution6x6_11_5_5_2_path =
	{
		(byte)0x13,
		(byte)0x13,
		(byte)0x13,
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x24,
		(byte)0x14,
		(byte)0x14,
		(byte)0x13
	} ;
	static readonly byte[] solution6x6_12_2_0_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_2_1_1_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_2_1_3_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_2_2_0_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_2_2_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_2_3_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_2_3_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_2_4_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_2_4_2_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_2_5_1_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_2_5_3_path =
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
	static readonly byte[] solution6x6_12_3_0_1_path =
	{
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_3_0_3_path =
	{
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_3_1_0_path =
	{
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_3_1_2_path =
	{
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_3_2_1_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_3_2_3_path =
	{
		(byte)0x21,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_3_3_0_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_3_4_1_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_3_4_3_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_3_5_0_path =
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
	static readonly byte[] solution6x6_12_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_4_1_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_4_1_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_4_2_0_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_4_2_2_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_4_3_1_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_4_3_3_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_4_4_0_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_4_4_2_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_4_5_1_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_4_5_3_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_5_0_1_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_5_0_3_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_5_1_0_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_5_1_2_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_5_2_1_path =
	{
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_5_2_3_path =
	{
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_5_3_0_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_5_3_2_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_5_4_1_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_5_4_3_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_5_5_0_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_12_5_5_2_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x20,
		(byte)0x20
	} ;
	static readonly byte[] solution6x6_13_2_1_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_2_2_1_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_2_2_3_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_2_3_0_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_2_3_2_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_2_4_1_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_2_4_3_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_2_5_0_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_2_5_2_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_3_0_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_3_0_2_path =
	{
		(byte)0x30,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_3_1_1_path =
	{
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_3_1_3_path =
	{
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_3_2_0_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_3_2_2_path =
	{
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_3_3_1_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_3_3_3_path =
	{
		(byte)0x22,
		(byte)0x21,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_3_4_0_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_3_4_2_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x30,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_4_0_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_4_0_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_4_1_0_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_4_1_2_path =
	{
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_4_2_1_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_4_2_3_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_4_3_0_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_4_3_2_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_4_4_1_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_4_4_3_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_4_5_0_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_4_5_2_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_5_0_0_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_5_0_2_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_5_1_1_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_5_1_3_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_5_2_0_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_5_2_2_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_5_3_1_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_5_3_3_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_5_4_0_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_5_4_2_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_5_5_1_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_13_5_5_3_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x21,
		(byte)0x21
	} ;
	static readonly byte[] solution6x6_14_2_2_2_path =
	{
		(byte)0x20,
		(byte)0x20,
		(byte)0x20,
		(byte)0x21,
		(byte)0x20,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_2_3_1_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_2_3_3_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_2_4_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_2_4_2_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_2_5_1_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_2_5_3_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_3_0_1_path =
	{
		(byte)0x30,
		(byte)0x31,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_3_0_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_3_1_0_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_3_1_2_path =
	{
		(byte)0x31,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_3_2_1_path =
	{
		(byte)0x32,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_3_2_3_path =
	{
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_3_3_0_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_3_3_2_path =
	{
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_3_4_1_path =
	{
		(byte)0x23,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_3_4_3_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_3_5_0_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x22,
		(byte)0x31,
		(byte)0x32,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_4_1_1_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_4_1_3_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_4_2_0_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_4_2_2_path =
	{
		(byte)0x32,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_4_3_1_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_4_3_3_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_4_4_0_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_4_4_2_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_4_5_1_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_4_5_3_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_5_0_1_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_5_0_3_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_5_1_0_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_5_1_2_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_5_2_1_path =
	{
		(byte)0x42,
		(byte)0x32,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_5_2_3_path =
	{
		(byte)0x42,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_5_3_0_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_5_3_2_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_5_4_1_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_5_4_3_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_5_5_0_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x32,
		(byte)0x22,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_14_5_5_2_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_15_2_3_2_path =
	{
		(byte)0x21,
		(byte)0x21,
		(byte)0x21,
		(byte)0x22,
		(byte)0x21,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_2_4_1_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_2_4_3_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x32,
		(byte)0x33,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_2_5_0_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_2_5_2_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_3_0_0_path =
	{
		(byte)0x30,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_3_0_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_3_1_1_path =
	{
		(byte)0x31,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_3_1_3_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_3_2_0_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_3_2_2_path =
	{
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_3_3_1_path =
	{
		(byte)0x33,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_3_3_3_path =
	{
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_3_4_0_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_3_4_2_path =
	{
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_3_5_1_path =
	{
		(byte)0x24,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x23,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_4_0_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_4_0_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_4_1_0_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_4_1_2_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_4_2_1_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_4_2_3_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_4_3_0_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_4_3_2_path =
	{
		(byte)0x33,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_4_4_1_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_4_4_3_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_4_5_0_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x33,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_4_5_2_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_5_0_0_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_5_0_2_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_5_1_1_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_5_1_3_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_5_2_0_path =
	{
		(byte)0x42,
		(byte)0x32,
		(byte)0x32,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_5_2_2_path =
	{
		(byte)0x42,
		(byte)0x32,
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_5_3_1_path =
	{
		(byte)0x43,
		(byte)0x33,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_5_3_3_path =
	{
		(byte)0x43,
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_5_4_0_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_5_4_2_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_5_5_1_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x33,
		(byte)0x23,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_15_5_5_3_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_16_2_4_2_path =
	{
		(byte)0x22,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_2_5_1_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_2_5_3_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_3_0_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_3_0_3_path =
	{
		(byte)0x22,
		(byte)0x30,
		(byte)0x31,
		(byte)0x22,
		(byte)0x22,
		(byte)0x23,
		(byte)0x22
	} ;
	static readonly byte[] solution6x6_16_3_1_0_path =
	{
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_3_1_2_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_3_2_1_path =
	{
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_3_2_3_path =
	{
		(byte)0x31,
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_3_3_0_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_3_3_2_path =
	{
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_3_4_1_path =
	{
		(byte)0x33,
		(byte)0x34,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_3_4_3_path =
	{
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_3_5_0_path =
	{
		(byte)0x24,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_3_5_2_path =
	{
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_4_1_1_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_4_1_3_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_4_2_0_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_4_2_2_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_4_3_1_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_4_3_3_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_4_4_0_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_4_4_2_path =
	{
		(byte)0x34,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_4_5_1_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_4_5_3_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_5_0_1_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_5_0_3_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_5_1_0_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_5_1_2_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_5_2_1_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_5_2_3_path =
	{
		(byte)0x42,
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_5_3_0_path =
	{
		(byte)0x43,
		(byte)0x33,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_5_3_2_path =
	{
		(byte)0x43,
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_5_4_1_path =
	{
		(byte)0x44,
		(byte)0x34,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_5_4_3_path =
	{
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_5_5_0_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_16_5_5_2_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x33,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_2_5_2_path =
	{
		(byte)0x24,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x34,
		(byte)0x24,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_3_0_0_path =
	{
		(byte)0x24,
		(byte)0x30,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_3_0_2_path =
	{
		(byte)0x23,
		(byte)0x30,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_17_3_1_1_path =
	{
		(byte)0x24,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_3_1_3_path =
	{
		(byte)0x23,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_17_3_2_0_path =
	{
		(byte)0x23,
		(byte)0x32,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_17_3_2_2_path =
	{
		(byte)0x24,
		(byte)0x32,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_3_3_1_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x33,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_3_3_3_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_17_3_4_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_17_3_4_2_path =
	{
		(byte)0x34,
		(byte)0x24,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_3_5_1_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_17_3_5_3_path =
	{
		(byte)0x24,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_4_0_1_path =
	{
		(byte)0x23,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_17_4_0_3_path =
	{
		(byte)0x24,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_4_1_0_path =
	{
		(byte)0x24,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_4_1_2_path =
	{
		(byte)0x23,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_17_4_2_1_path =
	{
		(byte)0x24,
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_4_2_3_path =
	{
		(byte)0x23,
		(byte)0x32,
		(byte)0x32,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_17_4_3_0_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x33,
		(byte)0x33,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_4_3_2_path =
	{
		(byte)0x24,
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_4_4_1_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_4_4_3_path =
	{
		(byte)0x24,
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_4_5_0_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x24,
		(byte)0x34,
		(byte)0x24,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_4_5_2_path =
	{
		(byte)0x24,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_5_0_0_path =
	{
		(byte)0x23,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_17_5_0_2_path =
	{
		(byte)0x24,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_5_1_1_path =
	{
		(byte)0x23,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_17_5_1_3_path =
	{
		(byte)0x24,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_5_2_0_path =
	{
		(byte)0x24,
		(byte)0x42,
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_5_2_2_path =
	{
		(byte)0x23,
		(byte)0x42,
		(byte)0x32,
		(byte)0x32,
		(byte)0x23,
		(byte)0x23,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_17_5_3_1_path =
	{
		(byte)0x24,
		(byte)0x43,
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_5_3_3_path =
	{
		(byte)0x24,
		(byte)0x24,
		(byte)0x43,
		(byte)0x33,
		(byte)0x33,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_5_4_0_path =
	{
		(byte)0x23,
		(byte)0x23,
		(byte)0x23,
		(byte)0x44,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x23
	} ;
	static readonly byte[] solution6x6_17_5_4_2_path =
	{
		(byte)0x24,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_5_5_1_path =
	{
		(byte)0x24,
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_17_5_5_3_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x24,
		(byte)0x34,
		(byte)0x24,
		(byte)0x24,
		(byte)0x24
	} ;
	static readonly byte[] solution6x6_18_3_0_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_3_1_1_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_3_1_3_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_3_2_0_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_3_2_2_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_3_3_1_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_3_3_3_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_3_4_0_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_3_4_2_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_3_5_1_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_3_5_3_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_4_0_1_path =
	{
		(byte)0x40,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_4_0_3_path =
	{
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_4_1_0_path =
	{
		(byte)0x30,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_4_1_2_path =
	{
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_4_2_1_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_4_2_3_path =
	{
		(byte)0x31,
		(byte)0x30,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_4_3_0_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_4_3_2_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_4_4_1_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_4_4_3_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_4_5_0_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_4_5_2_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_5_0_0_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_5_0_2_path =
	{
		(byte)0x40,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_5_1_1_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_5_1_3_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_5_2_0_path =
	{
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_5_2_2_path =
	{
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_5_3_1_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_5_3_3_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_5_4_0_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_5_4_2_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_5_5_1_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_18_5_5_3_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30
	} ;
	static readonly byte[] solution6x6_19_3_1_2_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_3_2_1_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_3_2_3_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x40,
		(byte)0x41,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_3_3_0_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_3_3_2_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_3_4_1_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_3_4_3_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_3_5_0_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_3_5_2_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_4_0_0_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_4_0_2_path =
	{
		(byte)0x40,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_4_1_1_path =
	{
		(byte)0x41,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_4_1_3_path =
	{
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_4_2_0_path =
	{
		(byte)0x31,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_4_2_2_path =
	{
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_4_3_1_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_4_3_3_path =
	{
		(byte)0x32,
		(byte)0x31,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_4_4_0_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_4_4_2_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x40,
		(byte)0x41,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_4_5_1_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_4_5_3_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_5_0_1_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_5_0_3_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_5_1_0_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_5_1_2_path =
	{
		(byte)0x41,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_5_2_1_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_5_2_3_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_5_3_0_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_5_3_2_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_5_4_1_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_5_4_3_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_5_5_0_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_19_5_5_2_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31
	} ;
	static readonly byte[] solution6x6_20_3_2_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x30,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_3_3_1_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_3_3_3_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x41,
		(byte)0x42,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_3_4_0_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_3_4_2_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_3_5_1_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x33,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_3_5_3_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_4_0_1_path =
	{
		(byte)0x40,
		(byte)0x41,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_4_0_3_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_4_1_0_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_4_1_2_path =
	{
		(byte)0x41,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_4_2_1_path =
	{
		(byte)0x42,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_4_2_3_path =
	{
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_4_3_0_path =
	{
		(byte)0x32,
		(byte)0x42,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_4_3_2_path =
	{
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_4_4_1_path =
	{
		(byte)0x33,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_4_4_3_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_4_5_0_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_4_5_2_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x32,
		(byte)0x41,
		(byte)0x42,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_5_0_0_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_5_0_2_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_5_1_1_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_5_1_3_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_5_2_0_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_5_2_2_path =
	{
		(byte)0x42,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_5_3_1_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_5_3_3_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_5_4_0_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_5_4_2_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_5_5_1_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_20_5_5_3_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_21_3_3_2_path =
	{
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x31,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_3_4_1_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_3_4_3_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x42,
		(byte)0x43,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_3_5_0_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x33,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_3_5_2_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x34,
		(byte)0x33,
		(byte)0x33,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_4_0_0_path =
	{
		(byte)0x40,
		(byte)0x41,
		(byte)0x42,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_4_0_2_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_4_1_1_path =
	{
		(byte)0x41,
		(byte)0x42,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_4_1_3_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x42,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_4_2_0_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_4_2_2_path =
	{
		(byte)0x42,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_4_3_1_path =
	{
		(byte)0x43,
		(byte)0x33,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_4_3_3_path =
	{
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_4_4_0_path =
	{
		(byte)0x33,
		(byte)0x43,
		(byte)0x33,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_4_4_2_path =
	{
		(byte)0x33,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_4_5_1_path =
	{
		(byte)0x34,
		(byte)0x33,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_4_5_3_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x33,
		(byte)0x33,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_5_0_1_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_5_0_3_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x42,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_5_1_0_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_5_1_2_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x42,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_5_2_1_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_5_2_3_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_5_3_0_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_5_3_2_path =
	{
		(byte)0x43,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_5_4_1_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_5_4_3_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_5_5_0_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_21_5_5_2_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_22_3_4_2_path =
	{
		(byte)0x32,
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x32,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_3_5_1_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_3_5_3_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_4_0_1_path =
	{
		(byte)0x33,
		(byte)0x40,
		(byte)0x41,
		(byte)0x42,
		(byte)0x43,
		(byte)0x33,
		(byte)0x33,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_22_4_0_3_path =
	{
		(byte)0x32,
		(byte)0x40,
		(byte)0x41,
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_22_4_1_0_path =
	{
		(byte)0x41,
		(byte)0x42,
		(byte)0x43,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_4_1_2_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_4_2_1_path =
	{
		(byte)0x42,
		(byte)0x43,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_4_2_3_path =
	{
		(byte)0x41,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_4_3_0_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_4_3_2_path =
	{
		(byte)0x43,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_4_4_1_path =
	{
		(byte)0x43,
		(byte)0x44,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_4_4_3_path =
	{
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_4_5_0_path =
	{
		(byte)0x34,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_4_5_2_path =
	{
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_5_0_0_path =
	{
		(byte)0x33,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x42,
		(byte)0x43,
		(byte)0x33,
		(byte)0x33,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_22_5_0_2_path =
	{
		(byte)0x32,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x32,
		(byte)0x32,
		(byte)0x33,
		(byte)0x32
	} ;
	static readonly byte[] solution6x6_22_5_1_1_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_5_1_3_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x43,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_5_2_0_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_5_2_2_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x43,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_5_3_1_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_5_3_3_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_5_4_0_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_5_4_2_path =
	{
		(byte)0x44,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_5_5_1_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_22_5_5_3_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_3_5_2_path =
	{
		(byte)0x34,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x44,
		(byte)0x34,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_4_0_0_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x33,
		(byte)0x32,
		(byte)0x34,
		(byte)0x33,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_4_0_2_path =
	{
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x32,
		(byte)0x33,
		(byte)0x32,
		(byte)0x31,
		(byte)0x30,
		(byte)0x34,
		(byte)0x33,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_4_1_1_path =
	{
		(byte)0x34,
		(byte)0x41,
		(byte)0x42,
		(byte)0x43,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_4_1_3_path =
	{
		(byte)0x33,
		(byte)0x41,
		(byte)0x42,
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_23_4_2_0_path =
	{
		(byte)0x33,
		(byte)0x42,
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_23_4_2_2_path =
	{
		(byte)0x34,
		(byte)0x42,
		(byte)0x43,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_4_3_1_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x43,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_4_3_3_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x34,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_23_4_4_0_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_23_4_4_2_path =
	{
		(byte)0x44,
		(byte)0x34,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_4_5_1_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_23_4_5_3_path =
	{
		(byte)0x34,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_5_0_1_path =
	{
		(byte)0x33,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x42,
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_23_5_0_3_path =
	{
		(byte)0x34,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x42,
		(byte)0x43,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_5_1_0_path =
	{
		(byte)0x34,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x43,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_5_1_2_path =
	{
		(byte)0x33,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_23_5_2_1_path =
	{
		(byte)0x34,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_5_2_3_path =
	{
		(byte)0x33,
		(byte)0x42,
		(byte)0x42,
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x33
	} ;
	static readonly byte[] solution6x6_23_5_3_0_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x43,
		(byte)0x43,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_5_3_2_path =
	{
		(byte)0x34,
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_5_4_1_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_5_4_3_path =
	{
		(byte)0x34,
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_5_5_0_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x34,
		(byte)0x44,
		(byte)0x34,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_23_5_5_2_path =
	{
		(byte)0x34,
		(byte)0x44,
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34
	} ;
	static readonly byte[] solution6x6_24_4_0_2_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_4_1_1_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_4_1_3_path =
	{
		(byte)0x40,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_4_2_0_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_4_2_2_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_4_3_1_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_4_3_3_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_4_4_0_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_4_4_2_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_4_5_1_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_4_5_3_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_5_0_1_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_5_0_3_path =
	{
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_5_1_0_path =
	{
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_5_1_2_path =
	{
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_5_2_1_path =
	{
		(byte)0x41,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_5_2_3_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_5_3_0_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_5_3_2_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_5_4_1_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_5_4_3_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_5_5_0_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_24_5_5_2_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_25_4_1_2_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_4_2_1_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_4_2_3_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_4_3_0_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_4_3_2_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_4_4_1_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_4_4_3_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_4_5_0_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_4_5_2_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_5_0_0_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_5_0_2_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x40,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_5_1_1_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_5_1_3_path =
	{
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_5_2_0_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_5_2_2_path =
	{
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_5_3_1_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_5_3_3_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_5_4_0_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_5_4_2_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_5_5_1_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_25_5_5_3_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_26_4_2_2_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x40,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_4_3_1_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_4_3_3_path =
	{
		(byte)0x42,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_4_4_0_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_4_4_2_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_4_5_1_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_4_5_3_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_5_0_1_path =
	{
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_26_5_0_3_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_26_5_1_0_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_26_5_1_2_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x41,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_5_2_1_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_26_5_2_3_path =
	{
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_5_3_0_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_5_3_2_path =
	{
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_5_4_1_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_5_4_3_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_5_5_0_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_26_5_5_2_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_27_4_3_2_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x41,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_27_4_4_1_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_27_4_4_3_path =
	{
		(byte)0x43,
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_27_4_5_0_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_27_4_5_2_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_27_5_0_0_path =
	{
		(byte)0x32,
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x32,
		(byte)0x32,
		(byte)0x32,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_27_5_0_2_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_27_5_1_1_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_27_5_1_3_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_27_5_2_0_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_27_5_2_2_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x42,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_27_5_3_1_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_27_5_3_3_path =
	{
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_27_5_4_0_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_27_5_4_2_path =
	{
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_27_5_5_1_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_27_5_5_3_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_28_4_4_2_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x42,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_28_4_5_1_path =
	{
		(byte)0x44,
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_28_4_5_3_path =
	{
		(byte)0x34,
		(byte)0x43,
		(byte)0x43,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_28_5_0_1_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x43,
		(byte)0x42,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_28_5_0_3_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_28_5_1_0_path =
	{
		(byte)0x33,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x42,
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_28_5_1_2_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_28_5_2_1_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x42,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_28_5_2_3_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x43,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_28_5_3_0_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_28_5_3_2_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_28_5_4_1_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_28_5_4_3_path =
	{
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_28_5_5_0_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_28_5_5_2_path =
	{
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_29_4_5_2_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_29_5_0_0_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x43,
		(byte)0x42,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_29_5_0_2_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_29_5_1_1_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_29_5_1_3_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_29_5_2_0_path =
	{
		(byte)0x34,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x43,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_29_5_2_2_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_29_5_3_1_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_29_5_3_3_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_29_5_4_0_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_29_5_4_2_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x34,
		(byte)0x43,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_29_5_5_1_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x44,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_29_5_5_3_path =
	{
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_30_5_0_2_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x40,
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x41,
		(byte)0x30,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_30_5_1_1_path =
	{
		(byte)0x41,
		(byte)0x40,
		(byte)0x40,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x41,
		(byte)0x30,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_30_5_1_3_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x31,
		(byte)0x40,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40
	} ;
	static readonly byte[] solution6x6_30_5_2_0_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_30_5_2_2_path =
	{
		(byte)0x30,
		(byte)0x41,
		(byte)0x31,
		(byte)0x40,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x41,
		(byte)0x30,
		(byte)0x30,
		(byte)0x30,
		(byte)0x41,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_30_5_3_1_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_30_5_3_3_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_30_5_4_0_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x42,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_30_5_4_2_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_30_5_5_1_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x42,
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x40,
		(byte)0x44,
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_30_5_5_3_path =
	{
		(byte)0x40,
		(byte)0x40,
		(byte)0x40,
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x40,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_31_5_1_2_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x41,
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x42,
		(byte)0x31,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_31_5_2_1_path =
	{
		(byte)0x42,
		(byte)0x41,
		(byte)0x41,
		(byte)0x31,
		(byte)0x31,
		(byte)0x31,
		(byte)0x42,
		(byte)0x31,
		(byte)0x42,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_31_5_2_3_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x32,
		(byte)0x41,
		(byte)0x32,
		(byte)0x32,
		(byte)0x32,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41
	} ;
	static readonly byte[] solution6x6_31_5_3_0_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_31_5_3_2_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x41,
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x42,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_31_5_4_1_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_31_5_4_3_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_31_5_5_0_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x41,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_31_5_5_2_path =
	{
		(byte)0x41,
		(byte)0x41,
		(byte)0x41,
		(byte)0x42,
		(byte)0x42,
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x41,
		(byte)0x44,
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_32_5_2_2_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x42,
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x32,
		(byte)0x32,
		(byte)0x43,
		(byte)0x32,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_32_5_3_1_path =
	{
		(byte)0x43,
		(byte)0x42,
		(byte)0x42,
		(byte)0x32,
		(byte)0x32,
		(byte)0x32,
		(byte)0x43,
		(byte)0x32,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_32_5_3_3_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x33,
		(byte)0x42,
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x43,
		(byte)0x43,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_32_5_4_0_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x42,
		(byte)0x44,
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_32_5_4_2_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x42,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_32_5_5_1_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x44,
		(byte)0x43,
		(byte)0x42,
		(byte)0x44,
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_32_5_5_3_path =
	{
		(byte)0x42,
		(byte)0x42,
		(byte)0x42,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x42
	} ;
	static readonly byte[] solution6x6_33_5_3_2_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x44,
		(byte)0x33,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_33_5_4_1_path =
	{
		(byte)0x44,
		(byte)0x43,
		(byte)0x43,
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x44,
		(byte)0x33,
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_33_5_4_3_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x34,
		(byte)0x43,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34,
		(byte)0x44,
		(byte)0x44,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_33_5_5_0_path =
	{
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x44,
		(byte)0x44,
		(byte)0x33,
		(byte)0x43,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_33_5_5_2_path =
	{
		(byte)0x33,
		(byte)0x44,
		(byte)0x34,
		(byte)0x43,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34,
		(byte)0x44,
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_34_5_4_2_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x34,
		(byte)0x44,
		(byte)0x44,
		(byte)0x34,
		(byte)0x44,
		(byte)0x34,
		(byte)0x34,
		(byte)0x34,
		(byte)0x44,
		(byte)0x34,
		(byte)0x44,
		(byte)0x44
	} ;
	static readonly byte[] solution6x6_34_5_5_1_path =
	{
		(byte)0x34,
		(byte)0x34,
		(byte)0x34,
		(byte)0x43,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x44,
		(byte)0x44,
		(byte)0x43,
		(byte)0x34,
		(byte)0x43
	} ;
	static readonly byte[] solution6x6_34_5_5_3_path =
	{
		(byte)0x33,
		(byte)0x33,
		(byte)0x33,
		(byte)0x34,
		(byte)0x43,
		(byte)0x43,
		(byte)0x43,
		(byte)0x34,
		(byte)0x34,
		(byte)0x43,
		(byte)0x34,
		(byte)0x33,
		(byte)0x44
	} ;

// Solutions for 6x6 puzzle
	public static readonly solutionPath[] solution6x6 = {
		new solutionPath { tID=0, tY = 0, tX = 0, tA = 2, solution = solution6x6_0_0_0_2_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 1, solution = solution6x6_0_0_1_1_path },
		new solutionPath { tID=0, tY = 0, tX = 1, tA = 3, solution = solution6x6_0_0_1_3_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 0, solution = solution6x6_0_0_2_0_path },
		new solutionPath { tID=0, tY = 0, tX = 2, tA = 2, solution = solution6x6_0_0_2_2_path },
		new solutionPath { tID=0, tY = 0, tX = 3, tA = 1, solution = solution6x6_0_0_3_1_path },
		new solutionPath { tID=0, tY = 0, tX = 3, tA = 3, solution = solution6x6_0_0_3_3_path },
		new solutionPath { tID=0, tY = 0, tX = 4, tA = 0, solution = solution6x6_0_0_4_0_path },
		new solutionPath { tID=0, tY = 0, tX = 4, tA = 2, solution = solution6x6_0_0_4_2_path },
		new solutionPath { tID=0, tY = 0, tX = 5, tA = 1, solution = solution6x6_0_0_5_1_path },
		new solutionPath { tID=0, tY = 0, tX = 5, tA = 3, solution = solution6x6_0_0_5_3_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 1, solution = solution6x6_0_1_0_1_path },
		new solutionPath { tID=0, tY = 1, tX = 0, tA = 3, solution = solution6x6_0_1_0_3_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 0, solution = solution6x6_0_1_1_0_path },
		new solutionPath { tID=0, tY = 1, tX = 1, tA = 2, solution = solution6x6_0_1_1_2_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 1, solution = solution6x6_0_1_2_1_path },
		new solutionPath { tID=0, tY = 1, tX = 2, tA = 3, solution = solution6x6_0_1_2_3_path },
		new solutionPath { tID=0, tY = 1, tX = 3, tA = 0, solution = solution6x6_0_1_3_0_path },
		new solutionPath { tID=0, tY = 1, tX = 3, tA = 2, solution = solution6x6_0_1_3_2_path },
		new solutionPath { tID=0, tY = 1, tX = 4, tA = 1, solution = solution6x6_0_1_4_1_path },
		new solutionPath { tID=0, tY = 1, tX = 4, tA = 3, solution = solution6x6_0_1_4_3_path },
		new solutionPath { tID=0, tY = 1, tX = 5, tA = 0, solution = solution6x6_0_1_5_0_path },
		new solutionPath { tID=0, tY = 1, tX = 5, tA = 2, solution = solution6x6_0_1_5_2_path },
		new solutionPath { tID=0, tY = 2, tX = 0, tA = 0, solution = solution6x6_0_2_0_0_path },
		new solutionPath { tID=0, tY = 2, tX = 0, tA = 2, solution = solution6x6_0_2_0_2_path },
		new solutionPath { tID=0, tY = 2, tX = 1, tA = 1, solution = solution6x6_0_2_1_1_path },
		new solutionPath { tID=0, tY = 2, tX = 1, tA = 3, solution = solution6x6_0_2_1_3_path },
		new solutionPath { tID=0, tY = 2, tX = 2, tA = 0, solution = solution6x6_0_2_2_0_path },
		new solutionPath { tID=0, tY = 2, tX = 2, tA = 2, solution = solution6x6_0_2_2_2_path },
		new solutionPath { tID=0, tY = 2, tX = 3, tA = 1, solution = solution6x6_0_2_3_1_path },
		new solutionPath { tID=0, tY = 2, tX = 3, tA = 3, solution = solution6x6_0_2_3_3_path },
		new solutionPath { tID=0, tY = 2, tX = 4, tA = 0, solution = solution6x6_0_2_4_0_path },
		new solutionPath { tID=0, tY = 2, tX = 4, tA = 2, solution = solution6x6_0_2_4_2_path },
		new solutionPath { tID=0, tY = 2, tX = 5, tA = 1, solution = solution6x6_0_2_5_1_path },
		new solutionPath { tID=0, tY = 2, tX = 5, tA = 3, solution = solution6x6_0_2_5_3_path },
		new solutionPath { tID=0, tY = 3, tX = 0, tA = 1, solution = solution6x6_0_3_0_1_path },
		new solutionPath { tID=0, tY = 3, tX = 0, tA = 3, solution = solution6x6_0_3_0_3_path },
		new solutionPath { tID=0, tY = 3, tX = 1, tA = 0, solution = solution6x6_0_3_1_0_path },
		new solutionPath { tID=0, tY = 3, tX = 1, tA = 2, solution = solution6x6_0_3_1_2_path },
		new solutionPath { tID=0, tY = 3, tX = 2, tA = 1, solution = solution6x6_0_3_2_1_path },
		new solutionPath { tID=0, tY = 3, tX = 2, tA = 3, solution = solution6x6_0_3_2_3_path },
		new solutionPath { tID=0, tY = 3, tX = 3, tA = 0, solution = solution6x6_0_3_3_0_path },
		new solutionPath { tID=0, tY = 3, tX = 3, tA = 2, solution = solution6x6_0_3_3_2_path },
		new solutionPath { tID=0, tY = 3, tX = 4, tA = 1, solution = solution6x6_0_3_4_1_path },
		new solutionPath { tID=0, tY = 3, tX = 4, tA = 3, solution = solution6x6_0_3_4_3_path },
		new solutionPath { tID=0, tY = 3, tX = 5, tA = 0, solution = solution6x6_0_3_5_0_path },
		new solutionPath { tID=0, tY = 3, tX = 5, tA = 2, solution = solution6x6_0_3_5_2_path },
		new solutionPath { tID=0, tY = 4, tX = 0, tA = 0, solution = solution6x6_0_4_0_0_path },
		new solutionPath { tID=0, tY = 4, tX = 0, tA = 2, solution = solution6x6_0_4_0_2_path },
		new solutionPath { tID=0, tY = 4, tX = 1, tA = 1, solution = solution6x6_0_4_1_1_path },
		new solutionPath { tID=0, tY = 4, tX = 1, tA = 3, solution = solution6x6_0_4_1_3_path },
		new solutionPath { tID=0, tY = 4, tX = 2, tA = 0, solution = solution6x6_0_4_2_0_path },
		new solutionPath { tID=0, tY = 4, tX = 2, tA = 2, solution = solution6x6_0_4_2_2_path },
		new solutionPath { tID=0, tY = 4, tX = 3, tA = 1, solution = solution6x6_0_4_3_1_path },
		new solutionPath { tID=0, tY = 4, tX = 3, tA = 3, solution = solution6x6_0_4_3_3_path },
		new solutionPath { tID=0, tY = 4, tX = 4, tA = 0, solution = solution6x6_0_4_4_0_path },
		new solutionPath { tID=0, tY = 4, tX = 4, tA = 2, solution = solution6x6_0_4_4_2_path },
		new solutionPath { tID=0, tY = 4, tX = 5, tA = 1, solution = solution6x6_0_4_5_1_path },
		new solutionPath { tID=0, tY = 4, tX = 5, tA = 3, solution = solution6x6_0_4_5_3_path },
		new solutionPath { tID=0, tY = 5, tX = 0, tA = 1, solution = solution6x6_0_5_0_1_path },
		new solutionPath { tID=0, tY = 5, tX = 0, tA = 3, solution = solution6x6_0_5_0_3_path },
		new solutionPath { tID=0, tY = 5, tX = 1, tA = 0, solution = solution6x6_0_5_1_0_path },
		new solutionPath { tID=0, tY = 5, tX = 1, tA = 2, solution = solution6x6_0_5_1_2_path },
		new solutionPath { tID=0, tY = 5, tX = 2, tA = 1, solution = solution6x6_0_5_2_1_path },
		new solutionPath { tID=0, tY = 5, tX = 2, tA = 3, solution = solution6x6_0_5_2_3_path },
		new solutionPath { tID=0, tY = 5, tX = 3, tA = 0, solution = solution6x6_0_5_3_0_path },
		new solutionPath { tID=0, tY = 5, tX = 3, tA = 2, solution = solution6x6_0_5_3_2_path },
		new solutionPath { tID=0, tY = 5, tX = 4, tA = 1, solution = solution6x6_0_5_4_1_path },
		new solutionPath { tID=0, tY = 5, tX = 4, tA = 3, solution = solution6x6_0_5_4_3_path },
		new solutionPath { tID=0, tY = 5, tX = 5, tA = 0, solution = solution6x6_0_5_5_0_path },
		new solutionPath { tID=0, tY = 5, tX = 5, tA = 2, solution = solution6x6_0_5_5_2_path },
		new solutionPath { tID=1, tY = 0, tX = 1, tA = 2, solution = solution6x6_1_0_1_2_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 1, solution = solution6x6_1_0_2_1_path },
		new solutionPath { tID=1, tY = 0, tX = 2, tA = 3, solution = solution6x6_1_0_2_3_path },
		new solutionPath { tID=1, tY = 0, tX = 3, tA = 0, solution = solution6x6_1_0_3_0_path },
		new solutionPath { tID=1, tY = 0, tX = 3, tA = 2, solution = solution6x6_1_0_3_2_path },
		new solutionPath { tID=1, tY = 0, tX = 4, tA = 1, solution = solution6x6_1_0_4_1_path },
		new solutionPath { tID=1, tY = 0, tX = 4, tA = 3, solution = solution6x6_1_0_4_3_path },
		new solutionPath { tID=1, tY = 0, tX = 5, tA = 0, solution = solution6x6_1_0_5_0_path },
		new solutionPath { tID=1, tY = 0, tX = 5, tA = 2, solution = solution6x6_1_0_5_2_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 0, solution = solution6x6_1_1_0_0_path },
		new solutionPath { tID=1, tY = 1, tX = 0, tA = 2, solution = solution6x6_1_1_0_2_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 1, solution = solution6x6_1_1_1_1_path },
		new solutionPath { tID=1, tY = 1, tX = 1, tA = 3, solution = solution6x6_1_1_1_3_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 0, solution = solution6x6_1_1_2_0_path },
		new solutionPath { tID=1, tY = 1, tX = 2, tA = 2, solution = solution6x6_1_1_2_2_path },
		new solutionPath { tID=1, tY = 1, tX = 3, tA = 1, solution = solution6x6_1_1_3_1_path },
		new solutionPath { tID=1, tY = 1, tX = 3, tA = 3, solution = solution6x6_1_1_3_3_path },
		new solutionPath { tID=1, tY = 1, tX = 4, tA = 0, solution = solution6x6_1_1_4_0_path },
		new solutionPath { tID=1, tY = 1, tX = 4, tA = 2, solution = solution6x6_1_1_4_2_path },
		new solutionPath { tID=1, tY = 1, tX = 5, tA = 1, solution = solution6x6_1_1_5_1_path },
		new solutionPath { tID=1, tY = 1, tX = 5, tA = 3, solution = solution6x6_1_1_5_3_path },
		new solutionPath { tID=1, tY = 2, tX = 0, tA = 1, solution = solution6x6_1_2_0_1_path },
		new solutionPath { tID=1, tY = 2, tX = 0, tA = 3, solution = solution6x6_1_2_0_3_path },
		new solutionPath { tID=1, tY = 2, tX = 1, tA = 0, solution = solution6x6_1_2_1_0_path },
		new solutionPath { tID=1, tY = 2, tX = 1, tA = 2, solution = solution6x6_1_2_1_2_path },
		new solutionPath { tID=1, tY = 2, tX = 2, tA = 1, solution = solution6x6_1_2_2_1_path },
		new solutionPath { tID=1, tY = 2, tX = 2, tA = 3, solution = solution6x6_1_2_2_3_path },
		new solutionPath { tID=1, tY = 2, tX = 3, tA = 0, solution = solution6x6_1_2_3_0_path },
		new solutionPath { tID=1, tY = 2, tX = 3, tA = 2, solution = solution6x6_1_2_3_2_path },
		new solutionPath { tID=1, tY = 2, tX = 4, tA = 1, solution = solution6x6_1_2_4_1_path },
		new solutionPath { tID=1, tY = 2, tX = 4, tA = 3, solution = solution6x6_1_2_4_3_path },
		new solutionPath { tID=1, tY = 2, tX = 5, tA = 0, solution = solution6x6_1_2_5_0_path },
		new solutionPath { tID=1, tY = 2, tX = 5, tA = 2, solution = solution6x6_1_2_5_2_path },
		new solutionPath { tID=1, tY = 3, tX = 0, tA = 0, solution = solution6x6_1_3_0_0_path },
		new solutionPath { tID=1, tY = 3, tX = 0, tA = 2, solution = solution6x6_1_3_0_2_path },
		new solutionPath { tID=1, tY = 3, tX = 1, tA = 1, solution = solution6x6_1_3_1_1_path },
		new solutionPath { tID=1, tY = 3, tX = 1, tA = 3, solution = solution6x6_1_3_1_3_path },
		new solutionPath { tID=1, tY = 3, tX = 2, tA = 0, solution = solution6x6_1_3_2_0_path },
		new solutionPath { tID=1, tY = 3, tX = 2, tA = 2, solution = solution6x6_1_3_2_2_path },
		new solutionPath { tID=1, tY = 3, tX = 3, tA = 1, solution = solution6x6_1_3_3_1_path },
		new solutionPath { tID=1, tY = 3, tX = 3, tA = 3, solution = solution6x6_1_3_3_3_path },
		new solutionPath { tID=1, tY = 3, tX = 4, tA = 0, solution = solution6x6_1_3_4_0_path },
		new solutionPath { tID=1, tY = 3, tX = 4, tA = 2, solution = solution6x6_1_3_4_2_path },
		new solutionPath { tID=1, tY = 3, tX = 5, tA = 1, solution = solution6x6_1_3_5_1_path },
		new solutionPath { tID=1, tY = 3, tX = 5, tA = 3, solution = solution6x6_1_3_5_3_path },
		new solutionPath { tID=1, tY = 4, tX = 0, tA = 1, solution = solution6x6_1_4_0_1_path },
		new solutionPath { tID=1, tY = 4, tX = 0, tA = 3, solution = solution6x6_1_4_0_3_path },
		new solutionPath { tID=1, tY = 4, tX = 1, tA = 0, solution = solution6x6_1_4_1_0_path },
		new solutionPath { tID=1, tY = 4, tX = 1, tA = 2, solution = solution6x6_1_4_1_2_path },
		new solutionPath { tID=1, tY = 4, tX = 2, tA = 1, solution = solution6x6_1_4_2_1_path },
		new solutionPath { tID=1, tY = 4, tX = 2, tA = 3, solution = solution6x6_1_4_2_3_path },
		new solutionPath { tID=1, tY = 4, tX = 3, tA = 0, solution = solution6x6_1_4_3_0_path },
		new solutionPath { tID=1, tY = 4, tX = 3, tA = 2, solution = solution6x6_1_4_3_2_path },
		new solutionPath { tID=1, tY = 4, tX = 4, tA = 1, solution = solution6x6_1_4_4_1_path },
		new solutionPath { tID=1, tY = 4, tX = 4, tA = 3, solution = solution6x6_1_4_4_3_path },
		new solutionPath { tID=1, tY = 4, tX = 5, tA = 0, solution = solution6x6_1_4_5_0_path },
		new solutionPath { tID=1, tY = 4, tX = 5, tA = 2, solution = solution6x6_1_4_5_2_path },
		new solutionPath { tID=1, tY = 5, tX = 0, tA = 0, solution = solution6x6_1_5_0_0_path },
		new solutionPath { tID=1, tY = 5, tX = 0, tA = 2, solution = solution6x6_1_5_0_2_path },
		new solutionPath { tID=1, tY = 5, tX = 1, tA = 1, solution = solution6x6_1_5_1_1_path },
		new solutionPath { tID=1, tY = 5, tX = 1, tA = 3, solution = solution6x6_1_5_1_3_path },
		new solutionPath { tID=1, tY = 5, tX = 2, tA = 0, solution = solution6x6_1_5_2_0_path },
		new solutionPath { tID=1, tY = 5, tX = 2, tA = 2, solution = solution6x6_1_5_2_2_path },
		new solutionPath { tID=1, tY = 5, tX = 3, tA = 1, solution = solution6x6_1_5_3_1_path },
		new solutionPath { tID=1, tY = 5, tX = 3, tA = 3, solution = solution6x6_1_5_3_3_path },
		new solutionPath { tID=1, tY = 5, tX = 4, tA = 0, solution = solution6x6_1_5_4_0_path },
		new solutionPath { tID=1, tY = 5, tX = 4, tA = 2, solution = solution6x6_1_5_4_2_path },
		new solutionPath { tID=1, tY = 5, tX = 5, tA = 1, solution = solution6x6_1_5_5_1_path },
		new solutionPath { tID=1, tY = 5, tX = 5, tA = 3, solution = solution6x6_1_5_5_3_path },
		new solutionPath { tID=2, tY = 0, tX = 2, tA = 2, solution = solution6x6_2_0_2_2_path },
		new solutionPath { tID=2, tY = 0, tX = 3, tA = 1, solution = solution6x6_2_0_3_1_path },
		new solutionPath { tID=2, tY = 0, tX = 3, tA = 3, solution = solution6x6_2_0_3_3_path },
		new solutionPath { tID=2, tY = 0, tX = 4, tA = 0, solution = solution6x6_2_0_4_0_path },
		new solutionPath { tID=2, tY = 0, tX = 4, tA = 2, solution = solution6x6_2_0_4_2_path },
		new solutionPath { tID=2, tY = 0, tX = 5, tA = 1, solution = solution6x6_2_0_5_1_path },
		new solutionPath { tID=2, tY = 0, tX = 5, tA = 3, solution = solution6x6_2_0_5_3_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 1, solution = solution6x6_2_1_0_1_path },
		new solutionPath { tID=2, tY = 1, tX = 0, tA = 3, solution = solution6x6_2_1_0_3_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 0, solution = solution6x6_2_1_1_0_path },
		new solutionPath { tID=2, tY = 1, tX = 1, tA = 2, solution = solution6x6_2_1_1_2_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 1, solution = solution6x6_2_1_2_1_path },
		new solutionPath { tID=2, tY = 1, tX = 2, tA = 3, solution = solution6x6_2_1_2_3_path },
		new solutionPath { tID=2, tY = 1, tX = 3, tA = 0, solution = solution6x6_2_1_3_0_path },
		new solutionPath { tID=2, tY = 1, tX = 3, tA = 2, solution = solution6x6_2_1_3_2_path },
		new solutionPath { tID=2, tY = 1, tX = 4, tA = 1, solution = solution6x6_2_1_4_1_path },
		new solutionPath { tID=2, tY = 1, tX = 4, tA = 3, solution = solution6x6_2_1_4_3_path },
		new solutionPath { tID=2, tY = 1, tX = 5, tA = 0, solution = solution6x6_2_1_5_0_path },
		new solutionPath { tID=2, tY = 1, tX = 5, tA = 2, solution = solution6x6_2_1_5_2_path },
		new solutionPath { tID=2, tY = 2, tX = 0, tA = 0, solution = solution6x6_2_2_0_0_path },
		new solutionPath { tID=2, tY = 2, tX = 0, tA = 2, solution = solution6x6_2_2_0_2_path },
		new solutionPath { tID=2, tY = 2, tX = 1, tA = 1, solution = solution6x6_2_2_1_1_path },
		new solutionPath { tID=2, tY = 2, tX = 1, tA = 3, solution = solution6x6_2_2_1_3_path },
		new solutionPath { tID=2, tY = 2, tX = 2, tA = 0, solution = solution6x6_2_2_2_0_path },
		new solutionPath { tID=2, tY = 2, tX = 2, tA = 2, solution = solution6x6_2_2_2_2_path },
		new solutionPath { tID=2, tY = 2, tX = 3, tA = 1, solution = solution6x6_2_2_3_1_path },
		new solutionPath { tID=2, tY = 2, tX = 3, tA = 3, solution = solution6x6_2_2_3_3_path },
		new solutionPath { tID=2, tY = 2, tX = 4, tA = 0, solution = solution6x6_2_2_4_0_path },
		new solutionPath { tID=2, tY = 2, tX = 4, tA = 2, solution = solution6x6_2_2_4_2_path },
		new solutionPath { tID=2, tY = 2, tX = 5, tA = 1, solution = solution6x6_2_2_5_1_path },
		new solutionPath { tID=2, tY = 2, tX = 5, tA = 3, solution = solution6x6_2_2_5_3_path },
		new solutionPath { tID=2, tY = 3, tX = 0, tA = 1, solution = solution6x6_2_3_0_1_path },
		new solutionPath { tID=2, tY = 3, tX = 0, tA = 3, solution = solution6x6_2_3_0_3_path },
		new solutionPath { tID=2, tY = 3, tX = 1, tA = 0, solution = solution6x6_2_3_1_0_path },
		new solutionPath { tID=2, tY = 3, tX = 1, tA = 2, solution = solution6x6_2_3_1_2_path },
		new solutionPath { tID=2, tY = 3, tX = 2, tA = 1, solution = solution6x6_2_3_2_1_path },
		new solutionPath { tID=2, tY = 3, tX = 2, tA = 3, solution = solution6x6_2_3_2_3_path },
		new solutionPath { tID=2, tY = 3, tX = 3, tA = 0, solution = solution6x6_2_3_3_0_path },
		new solutionPath { tID=2, tY = 3, tX = 3, tA = 2, solution = solution6x6_2_3_3_2_path },
		new solutionPath { tID=2, tY = 3, tX = 4, tA = 1, solution = solution6x6_2_3_4_1_path },
		new solutionPath { tID=2, tY = 3, tX = 4, tA = 3, solution = solution6x6_2_3_4_3_path },
		new solutionPath { tID=2, tY = 3, tX = 5, tA = 0, solution = solution6x6_2_3_5_0_path },
		new solutionPath { tID=2, tY = 3, tX = 5, tA = 2, solution = solution6x6_2_3_5_2_path },
		new solutionPath { tID=2, tY = 4, tX = 0, tA = 0, solution = solution6x6_2_4_0_0_path },
		new solutionPath { tID=2, tY = 4, tX = 0, tA = 2, solution = solution6x6_2_4_0_2_path },
		new solutionPath { tID=2, tY = 4, tX = 1, tA = 1, solution = solution6x6_2_4_1_1_path },
		new solutionPath { tID=2, tY = 4, tX = 1, tA = 3, solution = solution6x6_2_4_1_3_path },
		new solutionPath { tID=2, tY = 4, tX = 2, tA = 0, solution = solution6x6_2_4_2_0_path },
		new solutionPath { tID=2, tY = 4, tX = 2, tA = 2, solution = solution6x6_2_4_2_2_path },
		new solutionPath { tID=2, tY = 4, tX = 3, tA = 1, solution = solution6x6_2_4_3_1_path },
		new solutionPath { tID=2, tY = 4, tX = 3, tA = 3, solution = solution6x6_2_4_3_3_path },
		new solutionPath { tID=2, tY = 4, tX = 4, tA = 0, solution = solution6x6_2_4_4_0_path },
		new solutionPath { tID=2, tY = 4, tX = 4, tA = 2, solution = solution6x6_2_4_4_2_path },
		new solutionPath { tID=2, tY = 4, tX = 5, tA = 1, solution = solution6x6_2_4_5_1_path },
		new solutionPath { tID=2, tY = 4, tX = 5, tA = 3, solution = solution6x6_2_4_5_3_path },
		new solutionPath { tID=2, tY = 5, tX = 0, tA = 1, solution = solution6x6_2_5_0_1_path },
		new solutionPath { tID=2, tY = 5, tX = 0, tA = 3, solution = solution6x6_2_5_0_3_path },
		new solutionPath { tID=2, tY = 5, tX = 1, tA = 0, solution = solution6x6_2_5_1_0_path },
		new solutionPath { tID=2, tY = 5, tX = 1, tA = 2, solution = solution6x6_2_5_1_2_path },
		new solutionPath { tID=2, tY = 5, tX = 2, tA = 1, solution = solution6x6_2_5_2_1_path },
		new solutionPath { tID=2, tY = 5, tX = 2, tA = 3, solution = solution6x6_2_5_2_3_path },
		new solutionPath { tID=2, tY = 5, tX = 3, tA = 0, solution = solution6x6_2_5_3_0_path },
		new solutionPath { tID=2, tY = 5, tX = 3, tA = 2, solution = solution6x6_2_5_3_2_path },
		new solutionPath { tID=2, tY = 5, tX = 4, tA = 1, solution = solution6x6_2_5_4_1_path },
		new solutionPath { tID=2, tY = 5, tX = 4, tA = 3, solution = solution6x6_2_5_4_3_path },
		new solutionPath { tID=2, tY = 5, tX = 5, tA = 0, solution = solution6x6_2_5_5_0_path },
		new solutionPath { tID=2, tY = 5, tX = 5, tA = 2, solution = solution6x6_2_5_5_2_path },
		new solutionPath { tID=3, tY = 0, tX = 3, tA = 2, solution = solution6x6_3_0_3_2_path },
		new solutionPath { tID=3, tY = 0, tX = 4, tA = 1, solution = solution6x6_3_0_4_1_path },
		new solutionPath { tID=3, tY = 0, tX = 4, tA = 3, solution = solution6x6_3_0_4_3_path },
		new solutionPath { tID=3, tY = 0, tX = 5, tA = 0, solution = solution6x6_3_0_5_0_path },
		new solutionPath { tID=3, tY = 0, tX = 5, tA = 2, solution = solution6x6_3_0_5_2_path },
		new solutionPath { tID=3, tY = 1, tX = 0, tA = 0, solution = solution6x6_3_1_0_0_path },
		new solutionPath { tID=3, tY = 1, tX = 0, tA = 2, solution = solution6x6_3_1_0_2_path },
		new solutionPath { tID=3, tY = 1, tX = 1, tA = 1, solution = solution6x6_3_1_1_1_path },
		new solutionPath { tID=3, tY = 1, tX = 1, tA = 3, solution = solution6x6_3_1_1_3_path },
		new solutionPath { tID=3, tY = 1, tX = 2, tA = 0, solution = solution6x6_3_1_2_0_path },
		new solutionPath { tID=3, tY = 1, tX = 2, tA = 2, solution = solution6x6_3_1_2_2_path },
		new solutionPath { tID=3, tY = 1, tX = 3, tA = 1, solution = solution6x6_3_1_3_1_path },
		new solutionPath { tID=3, tY = 1, tX = 3, tA = 3, solution = solution6x6_3_1_3_3_path },
		new solutionPath { tID=3, tY = 1, tX = 4, tA = 0, solution = solution6x6_3_1_4_0_path },
		new solutionPath { tID=3, tY = 1, tX = 4, tA = 2, solution = solution6x6_3_1_4_2_path },
		new solutionPath { tID=3, tY = 1, tX = 5, tA = 1, solution = solution6x6_3_1_5_1_path },
		new solutionPath { tID=3, tY = 1, tX = 5, tA = 3, solution = solution6x6_3_1_5_3_path },
		new solutionPath { tID=3, tY = 2, tX = 0, tA = 1, solution = solution6x6_3_2_0_1_path },
		new solutionPath { tID=3, tY = 2, tX = 0, tA = 3, solution = solution6x6_3_2_0_3_path },
		new solutionPath { tID=3, tY = 2, tX = 1, tA = 0, solution = solution6x6_3_2_1_0_path },
		new solutionPath { tID=3, tY = 2, tX = 1, tA = 2, solution = solution6x6_3_2_1_2_path },
		new solutionPath { tID=3, tY = 2, tX = 2, tA = 1, solution = solution6x6_3_2_2_1_path },
		new solutionPath { tID=3, tY = 2, tX = 2, tA = 3, solution = solution6x6_3_2_2_3_path },
		new solutionPath { tID=3, tY = 2, tX = 3, tA = 0, solution = solution6x6_3_2_3_0_path },
		new solutionPath { tID=3, tY = 2, tX = 3, tA = 2, solution = solution6x6_3_2_3_2_path },
		new solutionPath { tID=3, tY = 2, tX = 4, tA = 1, solution = solution6x6_3_2_4_1_path },
		new solutionPath { tID=3, tY = 2, tX = 4, tA = 3, solution = solution6x6_3_2_4_3_path },
		new solutionPath { tID=3, tY = 2, tX = 5, tA = 0, solution = solution6x6_3_2_5_0_path },
		new solutionPath { tID=3, tY = 2, tX = 5, tA = 2, solution = solution6x6_3_2_5_2_path },
		new solutionPath { tID=3, tY = 3, tX = 0, tA = 0, solution = solution6x6_3_3_0_0_path },
		new solutionPath { tID=3, tY = 3, tX = 0, tA = 2, solution = solution6x6_3_3_0_2_path },
		new solutionPath { tID=3, tY = 3, tX = 1, tA = 1, solution = solution6x6_3_3_1_1_path },
		new solutionPath { tID=3, tY = 3, tX = 1, tA = 3, solution = solution6x6_3_3_1_3_path },
		new solutionPath { tID=3, tY = 3, tX = 2, tA = 0, solution = solution6x6_3_3_2_0_path },
		new solutionPath { tID=3, tY = 3, tX = 2, tA = 2, solution = solution6x6_3_3_2_2_path },
		new solutionPath { tID=3, tY = 3, tX = 3, tA = 1, solution = solution6x6_3_3_3_1_path },
		new solutionPath { tID=3, tY = 3, tX = 3, tA = 3, solution = solution6x6_3_3_3_3_path },
		new solutionPath { tID=3, tY = 3, tX = 4, tA = 0, solution = solution6x6_3_3_4_0_path },
		new solutionPath { tID=3, tY = 3, tX = 4, tA = 2, solution = solution6x6_3_3_4_2_path },
		new solutionPath { tID=3, tY = 3, tX = 5, tA = 1, solution = solution6x6_3_3_5_1_path },
		new solutionPath { tID=3, tY = 3, tX = 5, tA = 3, solution = solution6x6_3_3_5_3_path },
		new solutionPath { tID=3, tY = 4, tX = 0, tA = 1, solution = solution6x6_3_4_0_1_path },
		new solutionPath { tID=3, tY = 4, tX = 0, tA = 3, solution = solution6x6_3_4_0_3_path },
		new solutionPath { tID=3, tY = 4, tX = 1, tA = 0, solution = solution6x6_3_4_1_0_path },
		new solutionPath { tID=3, tY = 4, tX = 1, tA = 2, solution = solution6x6_3_4_1_2_path },
		new solutionPath { tID=3, tY = 4, tX = 2, tA = 1, solution = solution6x6_3_4_2_1_path },
		new solutionPath { tID=3, tY = 4, tX = 2, tA = 3, solution = solution6x6_3_4_2_3_path },
		new solutionPath { tID=3, tY = 4, tX = 3, tA = 0, solution = solution6x6_3_4_3_0_path },
		new solutionPath { tID=3, tY = 4, tX = 3, tA = 2, solution = solution6x6_3_4_3_2_path },
		new solutionPath { tID=3, tY = 4, tX = 4, tA = 1, solution = solution6x6_3_4_4_1_path },
		new solutionPath { tID=3, tY = 4, tX = 4, tA = 3, solution = solution6x6_3_4_4_3_path },
		new solutionPath { tID=3, tY = 4, tX = 5, tA = 0, solution = solution6x6_3_4_5_0_path },
		new solutionPath { tID=3, tY = 4, tX = 5, tA = 2, solution = solution6x6_3_4_5_2_path },
		new solutionPath { tID=3, tY = 5, tX = 0, tA = 0, solution = solution6x6_3_5_0_0_path },
		new solutionPath { tID=3, tY = 5, tX = 0, tA = 2, solution = solution6x6_3_5_0_2_path },
		new solutionPath { tID=3, tY = 5, tX = 1, tA = 1, solution = solution6x6_3_5_1_1_path },
		new solutionPath { tID=3, tY = 5, tX = 1, tA = 3, solution = solution6x6_3_5_1_3_path },
		new solutionPath { tID=3, tY = 5, tX = 2, tA = 0, solution = solution6x6_3_5_2_0_path },
		new solutionPath { tID=3, tY = 5, tX = 2, tA = 2, solution = solution6x6_3_5_2_2_path },
		new solutionPath { tID=3, tY = 5, tX = 3, tA = 1, solution = solution6x6_3_5_3_1_path },
		new solutionPath { tID=3, tY = 5, tX = 3, tA = 3, solution = solution6x6_3_5_3_3_path },
		new solutionPath { tID=3, tY = 5, tX = 4, tA = 0, solution = solution6x6_3_5_4_0_path },
		new solutionPath { tID=3, tY = 5, tX = 4, tA = 2, solution = solution6x6_3_5_4_2_path },
		new solutionPath { tID=3, tY = 5, tX = 5, tA = 1, solution = solution6x6_3_5_5_1_path },
		new solutionPath { tID=3, tY = 5, tX = 5, tA = 3, solution = solution6x6_3_5_5_3_path },
		new solutionPath { tID=4, tY = 0, tX = 4, tA = 2, solution = solution6x6_4_0_4_2_path },
		new solutionPath { tID=4, tY = 0, tX = 5, tA = 1, solution = solution6x6_4_0_5_1_path },
		new solutionPath { tID=4, tY = 0, tX = 5, tA = 3, solution = solution6x6_4_0_5_3_path },
		new solutionPath { tID=4, tY = 1, tX = 0, tA = 1, solution = solution6x6_4_1_0_1_path },
		new solutionPath { tID=4, tY = 1, tX = 0, tA = 3, solution = solution6x6_4_1_0_3_path },
		new solutionPath { tID=4, tY = 1, tX = 1, tA = 0, solution = solution6x6_4_1_1_0_path },
		new solutionPath { tID=4, tY = 1, tX = 1, tA = 2, solution = solution6x6_4_1_1_2_path },
		new solutionPath { tID=4, tY = 1, tX = 2, tA = 1, solution = solution6x6_4_1_2_1_path },
		new solutionPath { tID=4, tY = 1, tX = 2, tA = 3, solution = solution6x6_4_1_2_3_path },
		new solutionPath { tID=4, tY = 1, tX = 3, tA = 0, solution = solution6x6_4_1_3_0_path },
		new solutionPath { tID=4, tY = 1, tX = 3, tA = 2, solution = solution6x6_4_1_3_2_path },
		new solutionPath { tID=4, tY = 1, tX = 4, tA = 1, solution = solution6x6_4_1_4_1_path },
		new solutionPath { tID=4, tY = 1, tX = 4, tA = 3, solution = solution6x6_4_1_4_3_path },
		new solutionPath { tID=4, tY = 1, tX = 5, tA = 0, solution = solution6x6_4_1_5_0_path },
		new solutionPath { tID=4, tY = 1, tX = 5, tA = 2, solution = solution6x6_4_1_5_2_path },
		new solutionPath { tID=4, tY = 2, tX = 0, tA = 0, solution = solution6x6_4_2_0_0_path },
		new solutionPath { tID=4, tY = 2, tX = 0, tA = 2, solution = solution6x6_4_2_0_2_path },
		new solutionPath { tID=4, tY = 2, tX = 1, tA = 1, solution = solution6x6_4_2_1_1_path },
		new solutionPath { tID=4, tY = 2, tX = 1, tA = 3, solution = solution6x6_4_2_1_3_path },
		new solutionPath { tID=4, tY = 2, tX = 2, tA = 0, solution = solution6x6_4_2_2_0_path },
		new solutionPath { tID=4, tY = 2, tX = 2, tA = 2, solution = solution6x6_4_2_2_2_path },
		new solutionPath { tID=4, tY = 2, tX = 3, tA = 1, solution = solution6x6_4_2_3_1_path },
		new solutionPath { tID=4, tY = 2, tX = 3, tA = 3, solution = solution6x6_4_2_3_3_path },
		new solutionPath { tID=4, tY = 2, tX = 4, tA = 0, solution = solution6x6_4_2_4_0_path },
		new solutionPath { tID=4, tY = 2, tX = 4, tA = 2, solution = solution6x6_4_2_4_2_path },
		new solutionPath { tID=4, tY = 2, tX = 5, tA = 1, solution = solution6x6_4_2_5_1_path },
		new solutionPath { tID=4, tY = 2, tX = 5, tA = 3, solution = solution6x6_4_2_5_3_path },
		new solutionPath { tID=4, tY = 3, tX = 0, tA = 1, solution = solution6x6_4_3_0_1_path },
		new solutionPath { tID=4, tY = 3, tX = 0, tA = 3, solution = solution6x6_4_3_0_3_path },
		new solutionPath { tID=4, tY = 3, tX = 1, tA = 0, solution = solution6x6_4_3_1_0_path },
		new solutionPath { tID=4, tY = 3, tX = 1, tA = 2, solution = solution6x6_4_3_1_2_path },
		new solutionPath { tID=4, tY = 3, tX = 2, tA = 1, solution = solution6x6_4_3_2_1_path },
		new solutionPath { tID=4, tY = 3, tX = 2, tA = 3, solution = solution6x6_4_3_2_3_path },
		new solutionPath { tID=4, tY = 3, tX = 3, tA = 0, solution = solution6x6_4_3_3_0_path },
		new solutionPath { tID=4, tY = 3, tX = 3, tA = 2, solution = solution6x6_4_3_3_2_path },
		new solutionPath { tID=4, tY = 3, tX = 4, tA = 1, solution = solution6x6_4_3_4_1_path },
		new solutionPath { tID=4, tY = 3, tX = 4, tA = 3, solution = solution6x6_4_3_4_3_path },
		new solutionPath { tID=4, tY = 3, tX = 5, tA = 0, solution = solution6x6_4_3_5_0_path },
		new solutionPath { tID=4, tY = 3, tX = 5, tA = 2, solution = solution6x6_4_3_5_2_path },
		new solutionPath { tID=4, tY = 4, tX = 0, tA = 0, solution = solution6x6_4_4_0_0_path },
		new solutionPath { tID=4, tY = 4, tX = 0, tA = 2, solution = solution6x6_4_4_0_2_path },
		new solutionPath { tID=4, tY = 4, tX = 1, tA = 1, solution = solution6x6_4_4_1_1_path },
		new solutionPath { tID=4, tY = 4, tX = 1, tA = 3, solution = solution6x6_4_4_1_3_path },
		new solutionPath { tID=4, tY = 4, tX = 2, tA = 0, solution = solution6x6_4_4_2_0_path },
		new solutionPath { tID=4, tY = 4, tX = 2, tA = 2, solution = solution6x6_4_4_2_2_path },
		new solutionPath { tID=4, tY = 4, tX = 3, tA = 1, solution = solution6x6_4_4_3_1_path },
		new solutionPath { tID=4, tY = 4, tX = 3, tA = 3, solution = solution6x6_4_4_3_3_path },
		new solutionPath { tID=4, tY = 4, tX = 4, tA = 0, solution = solution6x6_4_4_4_0_path },
		new solutionPath { tID=4, tY = 4, tX = 4, tA = 2, solution = solution6x6_4_4_4_2_path },
		new solutionPath { tID=4, tY = 4, tX = 5, tA = 1, solution = solution6x6_4_4_5_1_path },
		new solutionPath { tID=4, tY = 4, tX = 5, tA = 3, solution = solution6x6_4_4_5_3_path },
		new solutionPath { tID=4, tY = 5, tX = 0, tA = 1, solution = solution6x6_4_5_0_1_path },
		new solutionPath { tID=4, tY = 5, tX = 0, tA = 3, solution = solution6x6_4_5_0_3_path },
		new solutionPath { tID=4, tY = 5, tX = 1, tA = 0, solution = solution6x6_4_5_1_0_path },
		new solutionPath { tID=4, tY = 5, tX = 1, tA = 2, solution = solution6x6_4_5_1_2_path },
		new solutionPath { tID=4, tY = 5, tX = 2, tA = 1, solution = solution6x6_4_5_2_1_path },
		new solutionPath { tID=4, tY = 5, tX = 2, tA = 3, solution = solution6x6_4_5_2_3_path },
		new solutionPath { tID=4, tY = 5, tX = 3, tA = 0, solution = solution6x6_4_5_3_0_path },
		new solutionPath { tID=4, tY = 5, tX = 3, tA = 2, solution = solution6x6_4_5_3_2_path },
		new solutionPath { tID=4, tY = 5, tX = 4, tA = 1, solution = solution6x6_4_5_4_1_path },
		new solutionPath { tID=4, tY = 5, tX = 4, tA = 3, solution = solution6x6_4_5_4_3_path },
		new solutionPath { tID=4, tY = 5, tX = 5, tA = 0, solution = solution6x6_4_5_5_0_path },
		new solutionPath { tID=4, tY = 5, tX = 5, tA = 2, solution = solution6x6_4_5_5_2_path },
		new solutionPath { tID=5, tY = 0, tX = 5, tA = 2, solution = solution6x6_5_0_5_2_path },
		new solutionPath { tID=5, tY = 1, tX = 0, tA = 0, solution = solution6x6_5_1_0_0_path },
		new solutionPath { tID=5, tY = 1, tX = 0, tA = 2, solution = solution6x6_5_1_0_2_path },
		new solutionPath { tID=5, tY = 1, tX = 1, tA = 1, solution = solution6x6_5_1_1_1_path },
		new solutionPath { tID=5, tY = 1, tX = 1, tA = 3, solution = solution6x6_5_1_1_3_path },
		new solutionPath { tID=5, tY = 1, tX = 2, tA = 0, solution = solution6x6_5_1_2_0_path },
		new solutionPath { tID=5, tY = 1, tX = 2, tA = 2, solution = solution6x6_5_1_2_2_path },
		new solutionPath { tID=5, tY = 1, tX = 3, tA = 1, solution = solution6x6_5_1_3_1_path },
		new solutionPath { tID=5, tY = 1, tX = 3, tA = 3, solution = solution6x6_5_1_3_3_path },
		new solutionPath { tID=5, tY = 1, tX = 4, tA = 0, solution = solution6x6_5_1_4_0_path },
		new solutionPath { tID=5, tY = 1, tX = 4, tA = 2, solution = solution6x6_5_1_4_2_path },
		new solutionPath { tID=5, tY = 1, tX = 5, tA = 1, solution = solution6x6_5_1_5_1_path },
		new solutionPath { tID=5, tY = 1, tX = 5, tA = 3, solution = solution6x6_5_1_5_3_path },
		new solutionPath { tID=5, tY = 2, tX = 0, tA = 1, solution = solution6x6_5_2_0_1_path },
		new solutionPath { tID=5, tY = 2, tX = 0, tA = 3, solution = solution6x6_5_2_0_3_path },
		new solutionPath { tID=5, tY = 2, tX = 1, tA = 0, solution = solution6x6_5_2_1_0_path },
		new solutionPath { tID=5, tY = 2, tX = 1, tA = 2, solution = solution6x6_5_2_1_2_path },
		new solutionPath { tID=5, tY = 2, tX = 2, tA = 1, solution = solution6x6_5_2_2_1_path },
		new solutionPath { tID=5, tY = 2, tX = 2, tA = 3, solution = solution6x6_5_2_2_3_path },
		new solutionPath { tID=5, tY = 2, tX = 3, tA = 0, solution = solution6x6_5_2_3_0_path },
		new solutionPath { tID=5, tY = 2, tX = 3, tA = 2, solution = solution6x6_5_2_3_2_path },
		new solutionPath { tID=5, tY = 2, tX = 4, tA = 1, solution = solution6x6_5_2_4_1_path },
		new solutionPath { tID=5, tY = 2, tX = 4, tA = 3, solution = solution6x6_5_2_4_3_path },
		new solutionPath { tID=5, tY = 2, tX = 5, tA = 0, solution = solution6x6_5_2_5_0_path },
		new solutionPath { tID=5, tY = 2, tX = 5, tA = 2, solution = solution6x6_5_2_5_2_path },
		new solutionPath { tID=5, tY = 3, tX = 0, tA = 0, solution = solution6x6_5_3_0_0_path },
		new solutionPath { tID=5, tY = 3, tX = 0, tA = 2, solution = solution6x6_5_3_0_2_path },
		new solutionPath { tID=5, tY = 3, tX = 1, tA = 1, solution = solution6x6_5_3_1_1_path },
		new solutionPath { tID=5, tY = 3, tX = 1, tA = 3, solution = solution6x6_5_3_1_3_path },
		new solutionPath { tID=5, tY = 3, tX = 2, tA = 0, solution = solution6x6_5_3_2_0_path },
		new solutionPath { tID=5, tY = 3, tX = 2, tA = 2, solution = solution6x6_5_3_2_2_path },
		new solutionPath { tID=5, tY = 3, tX = 3, tA = 1, solution = solution6x6_5_3_3_1_path },
		new solutionPath { tID=5, tY = 3, tX = 3, tA = 3, solution = solution6x6_5_3_3_3_path },
		new solutionPath { tID=5, tY = 3, tX = 4, tA = 0, solution = solution6x6_5_3_4_0_path },
		new solutionPath { tID=5, tY = 3, tX = 4, tA = 2, solution = solution6x6_5_3_4_2_path },
		new solutionPath { tID=5, tY = 3, tX = 5, tA = 1, solution = solution6x6_5_3_5_1_path },
		new solutionPath { tID=5, tY = 3, tX = 5, tA = 3, solution = solution6x6_5_3_5_3_path },
		new solutionPath { tID=5, tY = 4, tX = 0, tA = 1, solution = solution6x6_5_4_0_1_path },
		new solutionPath { tID=5, tY = 4, tX = 0, tA = 3, solution = solution6x6_5_4_0_3_path },
		new solutionPath { tID=5, tY = 4, tX = 1, tA = 0, solution = solution6x6_5_4_1_0_path },
		new solutionPath { tID=5, tY = 4, tX = 1, tA = 2, solution = solution6x6_5_4_1_2_path },
		new solutionPath { tID=5, tY = 4, tX = 2, tA = 1, solution = solution6x6_5_4_2_1_path },
		new solutionPath { tID=5, tY = 4, tX = 2, tA = 3, solution = solution6x6_5_4_2_3_path },
		new solutionPath { tID=5, tY = 4, tX = 3, tA = 0, solution = solution6x6_5_4_3_0_path },
		new solutionPath { tID=5, tY = 4, tX = 3, tA = 2, solution = solution6x6_5_4_3_2_path },
		new solutionPath { tID=5, tY = 4, tX = 4, tA = 1, solution = solution6x6_5_4_4_1_path },
		new solutionPath { tID=5, tY = 4, tX = 4, tA = 3, solution = solution6x6_5_4_4_3_path },
		new solutionPath { tID=5, tY = 4, tX = 5, tA = 0, solution = solution6x6_5_4_5_0_path },
		new solutionPath { tID=5, tY = 4, tX = 5, tA = 2, solution = solution6x6_5_4_5_2_path },
		new solutionPath { tID=5, tY = 5, tX = 0, tA = 0, solution = solution6x6_5_5_0_0_path },
		new solutionPath { tID=5, tY = 5, tX = 0, tA = 2, solution = solution6x6_5_5_0_2_path },
		new solutionPath { tID=5, tY = 5, tX = 1, tA = 1, solution = solution6x6_5_5_1_1_path },
		new solutionPath { tID=5, tY = 5, tX = 1, tA = 3, solution = solution6x6_5_5_1_3_path },
		new solutionPath { tID=5, tY = 5, tX = 2, tA = 0, solution = solution6x6_5_5_2_0_path },
		new solutionPath { tID=5, tY = 5, tX = 2, tA = 2, solution = solution6x6_5_5_2_2_path },
		new solutionPath { tID=5, tY = 5, tX = 3, tA = 1, solution = solution6x6_5_5_3_1_path },
		new solutionPath { tID=5, tY = 5, tX = 3, tA = 3, solution = solution6x6_5_5_3_3_path },
		new solutionPath { tID=5, tY = 5, tX = 4, tA = 0, solution = solution6x6_5_5_4_0_path },
		new solutionPath { tID=5, tY = 5, tX = 4, tA = 2, solution = solution6x6_5_5_4_2_path },
		new solutionPath { tID=5, tY = 5, tX = 5, tA = 1, solution = solution6x6_5_5_5_1_path },
		new solutionPath { tID=5, tY = 5, tX = 5, tA = 3, solution = solution6x6_5_5_5_3_path },
		new solutionPath { tID=6, tY = 1, tX = 0, tA = 2, solution = solution6x6_6_1_0_2_path },
		new solutionPath { tID=6, tY = 1, tX = 1, tA = 1, solution = solution6x6_6_1_1_1_path },
		new solutionPath { tID=6, tY = 1, tX = 1, tA = 3, solution = solution6x6_6_1_1_3_path },
		new solutionPath { tID=6, tY = 1, tX = 2, tA = 0, solution = solution6x6_6_1_2_0_path },
		new solutionPath { tID=6, tY = 1, tX = 2, tA = 2, solution = solution6x6_6_1_2_2_path },
		new solutionPath { tID=6, tY = 1, tX = 3, tA = 1, solution = solution6x6_6_1_3_1_path },
		new solutionPath { tID=6, tY = 1, tX = 3, tA = 3, solution = solution6x6_6_1_3_3_path },
		new solutionPath { tID=6, tY = 1, tX = 4, tA = 0, solution = solution6x6_6_1_4_0_path },
		new solutionPath { tID=6, tY = 1, tX = 4, tA = 2, solution = solution6x6_6_1_4_2_path },
		new solutionPath { tID=6, tY = 1, tX = 5, tA = 1, solution = solution6x6_6_1_5_1_path },
		new solutionPath { tID=6, tY = 1, tX = 5, tA = 3, solution = solution6x6_6_1_5_3_path },
		new solutionPath { tID=6, tY = 2, tX = 0, tA = 1, solution = solution6x6_6_2_0_1_path },
		new solutionPath { tID=6, tY = 2, tX = 0, tA = 3, solution = solution6x6_6_2_0_3_path },
		new solutionPath { tID=6, tY = 2, tX = 1, tA = 0, solution = solution6x6_6_2_1_0_path },
		new solutionPath { tID=6, tY = 2, tX = 1, tA = 2, solution = solution6x6_6_2_1_2_path },
		new solutionPath { tID=6, tY = 2, tX = 2, tA = 1, solution = solution6x6_6_2_2_1_path },
		new solutionPath { tID=6, tY = 2, tX = 2, tA = 3, solution = solution6x6_6_2_2_3_path },
		new solutionPath { tID=6, tY = 2, tX = 3, tA = 0, solution = solution6x6_6_2_3_0_path },
		new solutionPath { tID=6, tY = 2, tX = 3, tA = 2, solution = solution6x6_6_2_3_2_path },
		new solutionPath { tID=6, tY = 2, tX = 4, tA = 1, solution = solution6x6_6_2_4_1_path },
		new solutionPath { tID=6, tY = 2, tX = 4, tA = 3, solution = solution6x6_6_2_4_3_path },
		new solutionPath { tID=6, tY = 2, tX = 5, tA = 0, solution = solution6x6_6_2_5_0_path },
		new solutionPath { tID=6, tY = 2, tX = 5, tA = 2, solution = solution6x6_6_2_5_2_path },
		new solutionPath { tID=6, tY = 3, tX = 0, tA = 0, solution = solution6x6_6_3_0_0_path },
		new solutionPath { tID=6, tY = 3, tX = 0, tA = 2, solution = solution6x6_6_3_0_2_path },
		new solutionPath { tID=6, tY = 3, tX = 1, tA = 1, solution = solution6x6_6_3_1_1_path },
		new solutionPath { tID=6, tY = 3, tX = 1, tA = 3, solution = solution6x6_6_3_1_3_path },
		new solutionPath { tID=6, tY = 3, tX = 2, tA = 0, solution = solution6x6_6_3_2_0_path },
		new solutionPath { tID=6, tY = 3, tX = 2, tA = 2, solution = solution6x6_6_3_2_2_path },
		new solutionPath { tID=6, tY = 3, tX = 3, tA = 1, solution = solution6x6_6_3_3_1_path },
		new solutionPath { tID=6, tY = 3, tX = 3, tA = 3, solution = solution6x6_6_3_3_3_path },
		new solutionPath { tID=6, tY = 3, tX = 4, tA = 0, solution = solution6x6_6_3_4_0_path },
		new solutionPath { tID=6, tY = 3, tX = 4, tA = 2, solution = solution6x6_6_3_4_2_path },
		new solutionPath { tID=6, tY = 3, tX = 5, tA = 1, solution = solution6x6_6_3_5_1_path },
		new solutionPath { tID=6, tY = 3, tX = 5, tA = 3, solution = solution6x6_6_3_5_3_path },
		new solutionPath { tID=6, tY = 4, tX = 0, tA = 1, solution = solution6x6_6_4_0_1_path },
		new solutionPath { tID=6, tY = 4, tX = 0, tA = 3, solution = solution6x6_6_4_0_3_path },
		new solutionPath { tID=6, tY = 4, tX = 1, tA = 0, solution = solution6x6_6_4_1_0_path },
		new solutionPath { tID=6, tY = 4, tX = 1, tA = 2, solution = solution6x6_6_4_1_2_path },
		new solutionPath { tID=6, tY = 4, tX = 2, tA = 1, solution = solution6x6_6_4_2_1_path },
		new solutionPath { tID=6, tY = 4, tX = 2, tA = 3, solution = solution6x6_6_4_2_3_path },
		new solutionPath { tID=6, tY = 4, tX = 3, tA = 0, solution = solution6x6_6_4_3_0_path },
		new solutionPath { tID=6, tY = 4, tX = 3, tA = 2, solution = solution6x6_6_4_3_2_path },
		new solutionPath { tID=6, tY = 4, tX = 4, tA = 1, solution = solution6x6_6_4_4_1_path },
		new solutionPath { tID=6, tY = 4, tX = 4, tA = 3, solution = solution6x6_6_4_4_3_path },
		new solutionPath { tID=6, tY = 4, tX = 5, tA = 0, solution = solution6x6_6_4_5_0_path },
		new solutionPath { tID=6, tY = 4, tX = 5, tA = 2, solution = solution6x6_6_4_5_2_path },
		new solutionPath { tID=6, tY = 5, tX = 0, tA = 0, solution = solution6x6_6_5_0_0_path },
		new solutionPath { tID=6, tY = 5, tX = 0, tA = 2, solution = solution6x6_6_5_0_2_path },
		new solutionPath { tID=6, tY = 5, tX = 1, tA = 1, solution = solution6x6_6_5_1_1_path },
		new solutionPath { tID=6, tY = 5, tX = 1, tA = 3, solution = solution6x6_6_5_1_3_path },
		new solutionPath { tID=6, tY = 5, tX = 2, tA = 0, solution = solution6x6_6_5_2_0_path },
		new solutionPath { tID=6, tY = 5, tX = 2, tA = 2, solution = solution6x6_6_5_2_2_path },
		new solutionPath { tID=6, tY = 5, tX = 3, tA = 1, solution = solution6x6_6_5_3_1_path },
		new solutionPath { tID=6, tY = 5, tX = 3, tA = 3, solution = solution6x6_6_5_3_3_path },
		new solutionPath { tID=6, tY = 5, tX = 4, tA = 0, solution = solution6x6_6_5_4_0_path },
		new solutionPath { tID=6, tY = 5, tX = 4, tA = 2, solution = solution6x6_6_5_4_2_path },
		new solutionPath { tID=6, tY = 5, tX = 5, tA = 1, solution = solution6x6_6_5_5_1_path },
		new solutionPath { tID=6, tY = 5, tX = 5, tA = 3, solution = solution6x6_6_5_5_3_path },
		new solutionPath { tID=7, tY = 1, tX = 1, tA = 2, solution = solution6x6_7_1_1_2_path },
		new solutionPath { tID=7, tY = 1, tX = 2, tA = 1, solution = solution6x6_7_1_2_1_path },
		new solutionPath { tID=7, tY = 1, tX = 2, tA = 3, solution = solution6x6_7_1_2_3_path },
		new solutionPath { tID=7, tY = 1, tX = 3, tA = 0, solution = solution6x6_7_1_3_0_path },
		new solutionPath { tID=7, tY = 1, tX = 3, tA = 2, solution = solution6x6_7_1_3_2_path },
		new solutionPath { tID=7, tY = 1, tX = 4, tA = 1, solution = solution6x6_7_1_4_1_path },
		new solutionPath { tID=7, tY = 1, tX = 4, tA = 3, solution = solution6x6_7_1_4_3_path },
		new solutionPath { tID=7, tY = 1, tX = 5, tA = 0, solution = solution6x6_7_1_5_0_path },
		new solutionPath { tID=7, tY = 1, tX = 5, tA = 2, solution = solution6x6_7_1_5_2_path },
		new solutionPath { tID=7, tY = 2, tX = 0, tA = 0, solution = solution6x6_7_2_0_0_path },
		new solutionPath { tID=7, tY = 2, tX = 0, tA = 2, solution = solution6x6_7_2_0_2_path },
		new solutionPath { tID=7, tY = 2, tX = 1, tA = 1, solution = solution6x6_7_2_1_1_path },
		new solutionPath { tID=7, tY = 2, tX = 1, tA = 3, solution = solution6x6_7_2_1_3_path },
		new solutionPath { tID=7, tY = 2, tX = 2, tA = 0, solution = solution6x6_7_2_2_0_path },
		new solutionPath { tID=7, tY = 2, tX = 2, tA = 2, solution = solution6x6_7_2_2_2_path },
		new solutionPath { tID=7, tY = 2, tX = 3, tA = 1, solution = solution6x6_7_2_3_1_path },
		new solutionPath { tID=7, tY = 2, tX = 3, tA = 3, solution = solution6x6_7_2_3_3_path },
		new solutionPath { tID=7, tY = 2, tX = 4, tA = 0, solution = solution6x6_7_2_4_0_path },
		new solutionPath { tID=7, tY = 2, tX = 4, tA = 2, solution = solution6x6_7_2_4_2_path },
		new solutionPath { tID=7, tY = 2, tX = 5, tA = 1, solution = solution6x6_7_2_5_1_path },
		new solutionPath { tID=7, tY = 2, tX = 5, tA = 3, solution = solution6x6_7_2_5_3_path },
		new solutionPath { tID=7, tY = 3, tX = 0, tA = 1, solution = solution6x6_7_3_0_1_path },
		new solutionPath { tID=7, tY = 3, tX = 0, tA = 3, solution = solution6x6_7_3_0_3_path },
		new solutionPath { tID=7, tY = 3, tX = 1, tA = 0, solution = solution6x6_7_3_1_0_path },
		new solutionPath { tID=7, tY = 3, tX = 1, tA = 2, solution = solution6x6_7_3_1_2_path },
		new solutionPath { tID=7, tY = 3, tX = 2, tA = 1, solution = solution6x6_7_3_2_1_path },
		new solutionPath { tID=7, tY = 3, tX = 2, tA = 3, solution = solution6x6_7_3_2_3_path },
		new solutionPath { tID=7, tY = 3, tX = 3, tA = 0, solution = solution6x6_7_3_3_0_path },
		new solutionPath { tID=7, tY = 3, tX = 3, tA = 2, solution = solution6x6_7_3_3_2_path },
		new solutionPath { tID=7, tY = 3, tX = 4, tA = 1, solution = solution6x6_7_3_4_1_path },
		new solutionPath { tID=7, tY = 3, tX = 4, tA = 3, solution = solution6x6_7_3_4_3_path },
		new solutionPath { tID=7, tY = 3, tX = 5, tA = 0, solution = solution6x6_7_3_5_0_path },
		new solutionPath { tID=7, tY = 3, tX = 5, tA = 2, solution = solution6x6_7_3_5_2_path },
		new solutionPath { tID=7, tY = 4, tX = 0, tA = 0, solution = solution6x6_7_4_0_0_path },
		new solutionPath { tID=7, tY = 4, tX = 0, tA = 2, solution = solution6x6_7_4_0_2_path },
		new solutionPath { tID=7, tY = 4, tX = 1, tA = 1, solution = solution6x6_7_4_1_1_path },
		new solutionPath { tID=7, tY = 4, tX = 1, tA = 3, solution = solution6x6_7_4_1_3_path },
		new solutionPath { tID=7, tY = 4, tX = 2, tA = 0, solution = solution6x6_7_4_2_0_path },
		new solutionPath { tID=7, tY = 4, tX = 2, tA = 2, solution = solution6x6_7_4_2_2_path },
		new solutionPath { tID=7, tY = 4, tX = 3, tA = 1, solution = solution6x6_7_4_3_1_path },
		new solutionPath { tID=7, tY = 4, tX = 3, tA = 3, solution = solution6x6_7_4_3_3_path },
		new solutionPath { tID=7, tY = 4, tX = 4, tA = 0, solution = solution6x6_7_4_4_0_path },
		new solutionPath { tID=7, tY = 4, tX = 4, tA = 2, solution = solution6x6_7_4_4_2_path },
		new solutionPath { tID=7, tY = 4, tX = 5, tA = 1, solution = solution6x6_7_4_5_1_path },
		new solutionPath { tID=7, tY = 4, tX = 5, tA = 3, solution = solution6x6_7_4_5_3_path },
		new solutionPath { tID=7, tY = 5, tX = 0, tA = 1, solution = solution6x6_7_5_0_1_path },
		new solutionPath { tID=7, tY = 5, tX = 0, tA = 3, solution = solution6x6_7_5_0_3_path },
		new solutionPath { tID=7, tY = 5, tX = 1, tA = 0, solution = solution6x6_7_5_1_0_path },
		new solutionPath { tID=7, tY = 5, tX = 1, tA = 2, solution = solution6x6_7_5_1_2_path },
		new solutionPath { tID=7, tY = 5, tX = 2, tA = 1, solution = solution6x6_7_5_2_1_path },
		new solutionPath { tID=7, tY = 5, tX = 2, tA = 3, solution = solution6x6_7_5_2_3_path },
		new solutionPath { tID=7, tY = 5, tX = 3, tA = 0, solution = solution6x6_7_5_3_0_path },
		new solutionPath { tID=7, tY = 5, tX = 3, tA = 2, solution = solution6x6_7_5_3_2_path },
		new solutionPath { tID=7, tY = 5, tX = 4, tA = 1, solution = solution6x6_7_5_4_1_path },
		new solutionPath { tID=7, tY = 5, tX = 4, tA = 3, solution = solution6x6_7_5_4_3_path },
		new solutionPath { tID=7, tY = 5, tX = 5, tA = 0, solution = solution6x6_7_5_5_0_path },
		new solutionPath { tID=7, tY = 5, tX = 5, tA = 2, solution = solution6x6_7_5_5_2_path },
		new solutionPath { tID=8, tY = 1, tX = 2, tA = 2, solution = solution6x6_8_1_2_2_path },
		new solutionPath { tID=8, tY = 1, tX = 3, tA = 1, solution = solution6x6_8_1_3_1_path },
		new solutionPath { tID=8, tY = 1, tX = 3, tA = 3, solution = solution6x6_8_1_3_3_path },
		new solutionPath { tID=8, tY = 1, tX = 4, tA = 0, solution = solution6x6_8_1_4_0_path },
		new solutionPath { tID=8, tY = 1, tX = 4, tA = 2, solution = solution6x6_8_1_4_2_path },
		new solutionPath { tID=8, tY = 1, tX = 5, tA = 1, solution = solution6x6_8_1_5_1_path },
		new solutionPath { tID=8, tY = 1, tX = 5, tA = 3, solution = solution6x6_8_1_5_3_path },
		new solutionPath { tID=8, tY = 2, tX = 0, tA = 1, solution = solution6x6_8_2_0_1_path },
		new solutionPath { tID=8, tY = 2, tX = 0, tA = 3, solution = solution6x6_8_2_0_3_path },
		new solutionPath { tID=8, tY = 2, tX = 1, tA = 0, solution = solution6x6_8_2_1_0_path },
		new solutionPath { tID=8, tY = 2, tX = 1, tA = 2, solution = solution6x6_8_2_1_2_path },
		new solutionPath { tID=8, tY = 2, tX = 2, tA = 1, solution = solution6x6_8_2_2_1_path },
		new solutionPath { tID=8, tY = 2, tX = 2, tA = 3, solution = solution6x6_8_2_2_3_path },
		new solutionPath { tID=8, tY = 2, tX = 3, tA = 0, solution = solution6x6_8_2_3_0_path },
		new solutionPath { tID=8, tY = 2, tX = 3, tA = 2, solution = solution6x6_8_2_3_2_path },
		new solutionPath { tID=8, tY = 2, tX = 4, tA = 1, solution = solution6x6_8_2_4_1_path },
		new solutionPath { tID=8, tY = 2, tX = 4, tA = 3, solution = solution6x6_8_2_4_3_path },
		new solutionPath { tID=8, tY = 2, tX = 5, tA = 0, solution = solution6x6_8_2_5_0_path },
		new solutionPath { tID=8, tY = 2, tX = 5, tA = 2, solution = solution6x6_8_2_5_2_path },
		new solutionPath { tID=8, tY = 3, tX = 0, tA = 0, solution = solution6x6_8_3_0_0_path },
		new solutionPath { tID=8, tY = 3, tX = 0, tA = 2, solution = solution6x6_8_3_0_2_path },
		new solutionPath { tID=8, tY = 3, tX = 1, tA = 1, solution = solution6x6_8_3_1_1_path },
		new solutionPath { tID=8, tY = 3, tX = 1, tA = 3, solution = solution6x6_8_3_1_3_path },
		new solutionPath { tID=8, tY = 3, tX = 2, tA = 0, solution = solution6x6_8_3_2_0_path },
		new solutionPath { tID=8, tY = 3, tX = 2, tA = 2, solution = solution6x6_8_3_2_2_path },
		new solutionPath { tID=8, tY = 3, tX = 3, tA = 1, solution = solution6x6_8_3_3_1_path },
		new solutionPath { tID=8, tY = 3, tX = 3, tA = 3, solution = solution6x6_8_3_3_3_path },
		new solutionPath { tID=8, tY = 3, tX = 4, tA = 0, solution = solution6x6_8_3_4_0_path },
		new solutionPath { tID=8, tY = 3, tX = 4, tA = 2, solution = solution6x6_8_3_4_2_path },
		new solutionPath { tID=8, tY = 3, tX = 5, tA = 1, solution = solution6x6_8_3_5_1_path },
		new solutionPath { tID=8, tY = 3, tX = 5, tA = 3, solution = solution6x6_8_3_5_3_path },
		new solutionPath { tID=8, tY = 4, tX = 0, tA = 1, solution = solution6x6_8_4_0_1_path },
		new solutionPath { tID=8, tY = 4, tX = 0, tA = 3, solution = solution6x6_8_4_0_3_path },
		new solutionPath { tID=8, tY = 4, tX = 1, tA = 0, solution = solution6x6_8_4_1_0_path },
		new solutionPath { tID=8, tY = 4, tX = 1, tA = 2, solution = solution6x6_8_4_1_2_path },
		new solutionPath { tID=8, tY = 4, tX = 2, tA = 1, solution = solution6x6_8_4_2_1_path },
		new solutionPath { tID=8, tY = 4, tX = 2, tA = 3, solution = solution6x6_8_4_2_3_path },
		new solutionPath { tID=8, tY = 4, tX = 3, tA = 0, solution = solution6x6_8_4_3_0_path },
		new solutionPath { tID=8, tY = 4, tX = 3, tA = 2, solution = solution6x6_8_4_3_2_path },
		new solutionPath { tID=8, tY = 4, tX = 4, tA = 1, solution = solution6x6_8_4_4_1_path },
		new solutionPath { tID=8, tY = 4, tX = 4, tA = 3, solution = solution6x6_8_4_4_3_path },
		new solutionPath { tID=8, tY = 4, tX = 5, tA = 0, solution = solution6x6_8_4_5_0_path },
		new solutionPath { tID=8, tY = 4, tX = 5, tA = 2, solution = solution6x6_8_4_5_2_path },
		new solutionPath { tID=8, tY = 5, tX = 0, tA = 0, solution = solution6x6_8_5_0_0_path },
		new solutionPath { tID=8, tY = 5, tX = 0, tA = 2, solution = solution6x6_8_5_0_2_path },
		new solutionPath { tID=8, tY = 5, tX = 1, tA = 1, solution = solution6x6_8_5_1_1_path },
		new solutionPath { tID=8, tY = 5, tX = 1, tA = 3, solution = solution6x6_8_5_1_3_path },
		new solutionPath { tID=8, tY = 5, tX = 2, tA = 0, solution = solution6x6_8_5_2_0_path },
		new solutionPath { tID=8, tY = 5, tX = 2, tA = 2, solution = solution6x6_8_5_2_2_path },
		new solutionPath { tID=8, tY = 5, tX = 3, tA = 1, solution = solution6x6_8_5_3_1_path },
		new solutionPath { tID=8, tY = 5, tX = 3, tA = 3, solution = solution6x6_8_5_3_3_path },
		new solutionPath { tID=8, tY = 5, tX = 4, tA = 0, solution = solution6x6_8_5_4_0_path },
		new solutionPath { tID=8, tY = 5, tX = 4, tA = 2, solution = solution6x6_8_5_4_2_path },
		new solutionPath { tID=8, tY = 5, tX = 5, tA = 1, solution = solution6x6_8_5_5_1_path },
		new solutionPath { tID=8, tY = 5, tX = 5, tA = 3, solution = solution6x6_8_5_5_3_path },
		new solutionPath { tID=9, tY = 1, tX = 3, tA = 2, solution = solution6x6_9_1_3_2_path },
		new solutionPath { tID=9, tY = 1, tX = 4, tA = 1, solution = solution6x6_9_1_4_1_path },
		new solutionPath { tID=9, tY = 1, tX = 4, tA = 3, solution = solution6x6_9_1_4_3_path },
		new solutionPath { tID=9, tY = 1, tX = 5, tA = 0, solution = solution6x6_9_1_5_0_path },
		new solutionPath { tID=9, tY = 1, tX = 5, tA = 2, solution = solution6x6_9_1_5_2_path },
		new solutionPath { tID=9, tY = 2, tX = 0, tA = 0, solution = solution6x6_9_2_0_0_path },
		new solutionPath { tID=9, tY = 2, tX = 0, tA = 2, solution = solution6x6_9_2_0_2_path },
		new solutionPath { tID=9, tY = 2, tX = 1, tA = 1, solution = solution6x6_9_2_1_1_path },
		new solutionPath { tID=9, tY = 2, tX = 1, tA = 3, solution = solution6x6_9_2_1_3_path },
		new solutionPath { tID=9, tY = 2, tX = 2, tA = 0, solution = solution6x6_9_2_2_0_path },
		new solutionPath { tID=9, tY = 2, tX = 2, tA = 2, solution = solution6x6_9_2_2_2_path },
		new solutionPath { tID=9, tY = 2, tX = 3, tA = 1, solution = solution6x6_9_2_3_1_path },
		new solutionPath { tID=9, tY = 2, tX = 3, tA = 3, solution = solution6x6_9_2_3_3_path },
		new solutionPath { tID=9, tY = 2, tX = 4, tA = 0, solution = solution6x6_9_2_4_0_path },
		new solutionPath { tID=9, tY = 2, tX = 4, tA = 2, solution = solution6x6_9_2_4_2_path },
		new solutionPath { tID=9, tY = 2, tX = 5, tA = 1, solution = solution6x6_9_2_5_1_path },
		new solutionPath { tID=9, tY = 2, tX = 5, tA = 3, solution = solution6x6_9_2_5_3_path },
		new solutionPath { tID=9, tY = 3, tX = 0, tA = 1, solution = solution6x6_9_3_0_1_path },
		new solutionPath { tID=9, tY = 3, tX = 0, tA = 3, solution = solution6x6_9_3_0_3_path },
		new solutionPath { tID=9, tY = 3, tX = 1, tA = 0, solution = solution6x6_9_3_1_0_path },
		new solutionPath { tID=9, tY = 3, tX = 1, tA = 2, solution = solution6x6_9_3_1_2_path },
		new solutionPath { tID=9, tY = 3, tX = 2, tA = 1, solution = solution6x6_9_3_2_1_path },
		new solutionPath { tID=9, tY = 3, tX = 2, tA = 3, solution = solution6x6_9_3_2_3_path },
		new solutionPath { tID=9, tY = 3, tX = 3, tA = 0, solution = solution6x6_9_3_3_0_path },
		new solutionPath { tID=9, tY = 3, tX = 3, tA = 2, solution = solution6x6_9_3_3_2_path },
		new solutionPath { tID=9, tY = 3, tX = 4, tA = 1, solution = solution6x6_9_3_4_1_path },
		new solutionPath { tID=9, tY = 3, tX = 4, tA = 3, solution = solution6x6_9_3_4_3_path },
		new solutionPath { tID=9, tY = 3, tX = 5, tA = 0, solution = solution6x6_9_3_5_0_path },
		new solutionPath { tID=9, tY = 3, tX = 5, tA = 2, solution = solution6x6_9_3_5_2_path },
		new solutionPath { tID=9, tY = 4, tX = 0, tA = 0, solution = solution6x6_9_4_0_0_path },
		new solutionPath { tID=9, tY = 4, tX = 0, tA = 2, solution = solution6x6_9_4_0_2_path },
		new solutionPath { tID=9, tY = 4, tX = 1, tA = 1, solution = solution6x6_9_4_1_1_path },
		new solutionPath { tID=9, tY = 4, tX = 1, tA = 3, solution = solution6x6_9_4_1_3_path },
		new solutionPath { tID=9, tY = 4, tX = 2, tA = 0, solution = solution6x6_9_4_2_0_path },
		new solutionPath { tID=9, tY = 4, tX = 2, tA = 2, solution = solution6x6_9_4_2_2_path },
		new solutionPath { tID=9, tY = 4, tX = 3, tA = 1, solution = solution6x6_9_4_3_1_path },
		new solutionPath { tID=9, tY = 4, tX = 3, tA = 3, solution = solution6x6_9_4_3_3_path },
		new solutionPath { tID=9, tY = 4, tX = 4, tA = 0, solution = solution6x6_9_4_4_0_path },
		new solutionPath { tID=9, tY = 4, tX = 4, tA = 2, solution = solution6x6_9_4_4_2_path },
		new solutionPath { tID=9, tY = 4, tX = 5, tA = 1, solution = solution6x6_9_4_5_1_path },
		new solutionPath { tID=9, tY = 4, tX = 5, tA = 3, solution = solution6x6_9_4_5_3_path },
		new solutionPath { tID=9, tY = 5, tX = 0, tA = 1, solution = solution6x6_9_5_0_1_path },
		new solutionPath { tID=9, tY = 5, tX = 0, tA = 3, solution = solution6x6_9_5_0_3_path },
		new solutionPath { tID=9, tY = 5, tX = 1, tA = 0, solution = solution6x6_9_5_1_0_path },
		new solutionPath { tID=9, tY = 5, tX = 1, tA = 2, solution = solution6x6_9_5_1_2_path },
		new solutionPath { tID=9, tY = 5, tX = 2, tA = 1, solution = solution6x6_9_5_2_1_path },
		new solutionPath { tID=9, tY = 5, tX = 2, tA = 3, solution = solution6x6_9_5_2_3_path },
		new solutionPath { tID=9, tY = 5, tX = 3, tA = 0, solution = solution6x6_9_5_3_0_path },
		new solutionPath { tID=9, tY = 5, tX = 3, tA = 2, solution = solution6x6_9_5_3_2_path },
		new solutionPath { tID=9, tY = 5, tX = 4, tA = 1, solution = solution6x6_9_5_4_1_path },
		new solutionPath { tID=9, tY = 5, tX = 4, tA = 3, solution = solution6x6_9_5_4_3_path },
		new solutionPath { tID=9, tY = 5, tX = 5, tA = 0, solution = solution6x6_9_5_5_0_path },
		new solutionPath { tID=9, tY = 5, tX = 5, tA = 2, solution = solution6x6_9_5_5_2_path },
		new solutionPath { tID=10, tY = 1, tX = 4, tA = 2, solution = solution6x6_10_1_4_2_path },
		new solutionPath { tID=10, tY = 1, tX = 5, tA = 1, solution = solution6x6_10_1_5_1_path },
		new solutionPath { tID=10, tY = 1, tX = 5, tA = 3, solution = solution6x6_10_1_5_3_path },
		new solutionPath { tID=10, tY = 2, tX = 0, tA = 1, solution = solution6x6_10_2_0_1_path },
		new solutionPath { tID=10, tY = 2, tX = 0, tA = 3, solution = solution6x6_10_2_0_3_path },
		new solutionPath { tID=10, tY = 2, tX = 1, tA = 0, solution = solution6x6_10_2_1_0_path },
		new solutionPath { tID=10, tY = 2, tX = 1, tA = 2, solution = solution6x6_10_2_1_2_path },
		new solutionPath { tID=10, tY = 2, tX = 2, tA = 1, solution = solution6x6_10_2_2_1_path },
		new solutionPath { tID=10, tY = 2, tX = 2, tA = 3, solution = solution6x6_10_2_2_3_path },
		new solutionPath { tID=10, tY = 2, tX = 3, tA = 0, solution = solution6x6_10_2_3_0_path },
		new solutionPath { tID=10, tY = 2, tX = 3, tA = 2, solution = solution6x6_10_2_3_2_path },
		new solutionPath { tID=10, tY = 2, tX = 4, tA = 1, solution = solution6x6_10_2_4_1_path },
		new solutionPath { tID=10, tY = 2, tX = 4, tA = 3, solution = solution6x6_10_2_4_3_path },
		new solutionPath { tID=10, tY = 2, tX = 5, tA = 0, solution = solution6x6_10_2_5_0_path },
		new solutionPath { tID=10, tY = 2, tX = 5, tA = 2, solution = solution6x6_10_2_5_2_path },
		new solutionPath { tID=10, tY = 3, tX = 0, tA = 0, solution = solution6x6_10_3_0_0_path },
		new solutionPath { tID=10, tY = 3, tX = 0, tA = 2, solution = solution6x6_10_3_0_2_path },
		new solutionPath { tID=10, tY = 3, tX = 1, tA = 1, solution = solution6x6_10_3_1_1_path },
		new solutionPath { tID=10, tY = 3, tX = 1, tA = 3, solution = solution6x6_10_3_1_3_path },
		new solutionPath { tID=10, tY = 3, tX = 2, tA = 0, solution = solution6x6_10_3_2_0_path },
		new solutionPath { tID=10, tY = 3, tX = 2, tA = 2, solution = solution6x6_10_3_2_2_path },
		new solutionPath { tID=10, tY = 3, tX = 3, tA = 1, solution = solution6x6_10_3_3_1_path },
		new solutionPath { tID=10, tY = 3, tX = 3, tA = 3, solution = solution6x6_10_3_3_3_path },
		new solutionPath { tID=10, tY = 3, tX = 4, tA = 0, solution = solution6x6_10_3_4_0_path },
		new solutionPath { tID=10, tY = 3, tX = 4, tA = 2, solution = solution6x6_10_3_4_2_path },
		new solutionPath { tID=10, tY = 3, tX = 5, tA = 1, solution = solution6x6_10_3_5_1_path },
		new solutionPath { tID=10, tY = 3, tX = 5, tA = 3, solution = solution6x6_10_3_5_3_path },
		new solutionPath { tID=10, tY = 4, tX = 0, tA = 1, solution = solution6x6_10_4_0_1_path },
		new solutionPath { tID=10, tY = 4, tX = 0, tA = 3, solution = solution6x6_10_4_0_3_path },
		new solutionPath { tID=10, tY = 4, tX = 1, tA = 0, solution = solution6x6_10_4_1_0_path },
		new solutionPath { tID=10, tY = 4, tX = 1, tA = 2, solution = solution6x6_10_4_1_2_path },
		new solutionPath { tID=10, tY = 4, tX = 2, tA = 1, solution = solution6x6_10_4_2_1_path },
		new solutionPath { tID=10, tY = 4, tX = 2, tA = 3, solution = solution6x6_10_4_2_3_path },
		new solutionPath { tID=10, tY = 4, tX = 3, tA = 0, solution = solution6x6_10_4_3_0_path },
		new solutionPath { tID=10, tY = 4, tX = 3, tA = 2, solution = solution6x6_10_4_3_2_path },
		new solutionPath { tID=10, tY = 4, tX = 4, tA = 1, solution = solution6x6_10_4_4_1_path },
		new solutionPath { tID=10, tY = 4, tX = 4, tA = 3, solution = solution6x6_10_4_4_3_path },
		new solutionPath { tID=10, tY = 4, tX = 5, tA = 0, solution = solution6x6_10_4_5_0_path },
		new solutionPath { tID=10, tY = 4, tX = 5, tA = 2, solution = solution6x6_10_4_5_2_path },
		new solutionPath { tID=10, tY = 5, tX = 0, tA = 0, solution = solution6x6_10_5_0_0_path },
		new solutionPath { tID=10, tY = 5, tX = 0, tA = 2, solution = solution6x6_10_5_0_2_path },
		new solutionPath { tID=10, tY = 5, tX = 1, tA = 1, solution = solution6x6_10_5_1_1_path },
		new solutionPath { tID=10, tY = 5, tX = 1, tA = 3, solution = solution6x6_10_5_1_3_path },
		new solutionPath { tID=10, tY = 5, tX = 2, tA = 0, solution = solution6x6_10_5_2_0_path },
		new solutionPath { tID=10, tY = 5, tX = 2, tA = 2, solution = solution6x6_10_5_2_2_path },
		new solutionPath { tID=10, tY = 5, tX = 3, tA = 1, solution = solution6x6_10_5_3_1_path },
		new solutionPath { tID=10, tY = 5, tX = 3, tA = 3, solution = solution6x6_10_5_3_3_path },
		new solutionPath { tID=10, tY = 5, tX = 4, tA = 0, solution = solution6x6_10_5_4_0_path },
		new solutionPath { tID=10, tY = 5, tX = 4, tA = 2, solution = solution6x6_10_5_4_2_path },
		new solutionPath { tID=10, tY = 5, tX = 5, tA = 1, solution = solution6x6_10_5_5_1_path },
		new solutionPath { tID=10, tY = 5, tX = 5, tA = 3, solution = solution6x6_10_5_5_3_path },
		new solutionPath { tID=11, tY = 1, tX = 5, tA = 2, solution = solution6x6_11_1_5_2_path },
		new solutionPath { tID=11, tY = 2, tX = 0, tA = 0, solution = solution6x6_11_2_0_0_path },
		new solutionPath { tID=11, tY = 2, tX = 0, tA = 2, solution = solution6x6_11_2_0_2_path },
		new solutionPath { tID=11, tY = 2, tX = 1, tA = 1, solution = solution6x6_11_2_1_1_path },
		new solutionPath { tID=11, tY = 2, tX = 1, tA = 3, solution = solution6x6_11_2_1_3_path },
		new solutionPath { tID=11, tY = 2, tX = 2, tA = 0, solution = solution6x6_11_2_2_0_path },
		new solutionPath { tID=11, tY = 2, tX = 2, tA = 2, solution = solution6x6_11_2_2_2_path },
		new solutionPath { tID=11, tY = 2, tX = 3, tA = 1, solution = solution6x6_11_2_3_1_path },
		new solutionPath { tID=11, tY = 2, tX = 3, tA = 3, solution = solution6x6_11_2_3_3_path },
		new solutionPath { tID=11, tY = 2, tX = 4, tA = 0, solution = solution6x6_11_2_4_0_path },
		new solutionPath { tID=11, tY = 2, tX = 4, tA = 2, solution = solution6x6_11_2_4_2_path },
		new solutionPath { tID=11, tY = 2, tX = 5, tA = 1, solution = solution6x6_11_2_5_1_path },
		new solutionPath { tID=11, tY = 2, tX = 5, tA = 3, solution = solution6x6_11_2_5_3_path },
		new solutionPath { tID=11, tY = 3, tX = 0, tA = 1, solution = solution6x6_11_3_0_1_path },
		new solutionPath { tID=11, tY = 3, tX = 0, tA = 3, solution = solution6x6_11_3_0_3_path },
		new solutionPath { tID=11, tY = 3, tX = 1, tA = 0, solution = solution6x6_11_3_1_0_path },
		new solutionPath { tID=11, tY = 3, tX = 1, tA = 2, solution = solution6x6_11_3_1_2_path },
		new solutionPath { tID=11, tY = 3, tX = 2, tA = 1, solution = solution6x6_11_3_2_1_path },
		new solutionPath { tID=11, tY = 3, tX = 2, tA = 3, solution = solution6x6_11_3_2_3_path },
		new solutionPath { tID=11, tY = 3, tX = 3, tA = 0, solution = solution6x6_11_3_3_0_path },
		new solutionPath { tID=11, tY = 3, tX = 3, tA = 2, solution = solution6x6_11_3_3_2_path },
		new solutionPath { tID=11, tY = 3, tX = 4, tA = 1, solution = solution6x6_11_3_4_1_path },
		new solutionPath { tID=11, tY = 3, tX = 4, tA = 3, solution = solution6x6_11_3_4_3_path },
		new solutionPath { tID=11, tY = 3, tX = 5, tA = 0, solution = solution6x6_11_3_5_0_path },
		new solutionPath { tID=11, tY = 3, tX = 5, tA = 2, solution = solution6x6_11_3_5_2_path },
		new solutionPath { tID=11, tY = 4, tX = 0, tA = 0, solution = solution6x6_11_4_0_0_path },
		new solutionPath { tID=11, tY = 4, tX = 0, tA = 2, solution = solution6x6_11_4_0_2_path },
		new solutionPath { tID=11, tY = 4, tX = 1, tA = 1, solution = solution6x6_11_4_1_1_path },
		new solutionPath { tID=11, tY = 4, tX = 1, tA = 3, solution = solution6x6_11_4_1_3_path },
		new solutionPath { tID=11, tY = 4, tX = 2, tA = 0, solution = solution6x6_11_4_2_0_path },
		new solutionPath { tID=11, tY = 4, tX = 2, tA = 2, solution = solution6x6_11_4_2_2_path },
		new solutionPath { tID=11, tY = 4, tX = 3, tA = 1, solution = solution6x6_11_4_3_1_path },
		new solutionPath { tID=11, tY = 4, tX = 3, tA = 3, solution = solution6x6_11_4_3_3_path },
		new solutionPath { tID=11, tY = 4, tX = 4, tA = 0, solution = solution6x6_11_4_4_0_path },
		new solutionPath { tID=11, tY = 4, tX = 4, tA = 2, solution = solution6x6_11_4_4_2_path },
		new solutionPath { tID=11, tY = 4, tX = 5, tA = 1, solution = solution6x6_11_4_5_1_path },
		new solutionPath { tID=11, tY = 4, tX = 5, tA = 3, solution = solution6x6_11_4_5_3_path },
		new solutionPath { tID=11, tY = 5, tX = 1, tA = 0, solution = solution6x6_11_5_1_0_path },
		new solutionPath { tID=11, tY = 5, tX = 1, tA = 2, solution = solution6x6_11_5_1_2_path },
		new solutionPath { tID=11, tY = 5, tX = 2, tA = 1, solution = solution6x6_11_5_2_1_path },
		new solutionPath { tID=11, tY = 5, tX = 2, tA = 3, solution = solution6x6_11_5_2_3_path },
		new solutionPath { tID=11, tY = 5, tX = 3, tA = 0, solution = solution6x6_11_5_3_0_path },
		new solutionPath { tID=11, tY = 5, tX = 3, tA = 2, solution = solution6x6_11_5_3_2_path },
		new solutionPath { tID=11, tY = 5, tX = 4, tA = 1, solution = solution6x6_11_5_4_1_path },
		new solutionPath { tID=11, tY = 5, tX = 4, tA = 3, solution = solution6x6_11_5_4_3_path },
		new solutionPath { tID=11, tY = 5, tX = 5, tA = 0, solution = solution6x6_11_5_5_0_path },
		new solutionPath { tID=11, tY = 5, tX = 5, tA = 2, solution = solution6x6_11_5_5_2_path },
		new solutionPath { tID=12, tY = 2, tX = 0, tA = 2, solution = solution6x6_12_2_0_2_path },
		new solutionPath { tID=12, tY = 2, tX = 1, tA = 1, solution = solution6x6_12_2_1_1_path },
		new solutionPath { tID=12, tY = 2, tX = 1, tA = 3, solution = solution6x6_12_2_1_3_path },
		new solutionPath { tID=12, tY = 2, tX = 2, tA = 0, solution = solution6x6_12_2_2_0_path },
		new solutionPath { tID=12, tY = 2, tX = 2, tA = 2, solution = solution6x6_12_2_2_2_path },
		new solutionPath { tID=12, tY = 2, tX = 3, tA = 1, solution = solution6x6_12_2_3_1_path },
		new solutionPath { tID=12, tY = 2, tX = 3, tA = 3, solution = solution6x6_12_2_3_3_path },
		new solutionPath { tID=12, tY = 2, tX = 4, tA = 0, solution = solution6x6_12_2_4_0_path },
		new solutionPath { tID=12, tY = 2, tX = 4, tA = 2, solution = solution6x6_12_2_4_2_path },
		new solutionPath { tID=12, tY = 2, tX = 5, tA = 1, solution = solution6x6_12_2_5_1_path },
		new solutionPath { tID=12, tY = 2, tX = 5, tA = 3, solution = solution6x6_12_2_5_3_path },
		new solutionPath { tID=12, tY = 3, tX = 0, tA = 1, solution = solution6x6_12_3_0_1_path },
		new solutionPath { tID=12, tY = 3, tX = 0, tA = 3, solution = solution6x6_12_3_0_3_path },
		new solutionPath { tID=12, tY = 3, tX = 1, tA = 0, solution = solution6x6_12_3_1_0_path },
		new solutionPath { tID=12, tY = 3, tX = 1, tA = 2, solution = solution6x6_12_3_1_2_path },
		new solutionPath { tID=12, tY = 3, tX = 2, tA = 1, solution = solution6x6_12_3_2_1_path },
		new solutionPath { tID=12, tY = 3, tX = 2, tA = 3, solution = solution6x6_12_3_2_3_path },
		new solutionPath { tID=12, tY = 3, tX = 3, tA = 0, solution = solution6x6_12_3_3_0_path },
		new solutionPath { tID=12, tY = 3, tX = 3, tA = 2, solution = solution6x6_12_3_3_2_path },
		new solutionPath { tID=12, tY = 3, tX = 4, tA = 1, solution = solution6x6_12_3_4_1_path },
		new solutionPath { tID=12, tY = 3, tX = 4, tA = 3, solution = solution6x6_12_3_4_3_path },
		new solutionPath { tID=12, tY = 3, tX = 5, tA = 0, solution = solution6x6_12_3_5_0_path },
		new solutionPath { tID=12, tY = 3, tX = 5, tA = 2, solution = solution6x6_12_3_5_2_path },
		new solutionPath { tID=12, tY = 4, tX = 0, tA = 0, solution = solution6x6_12_4_0_0_path },
		new solutionPath { tID=12, tY = 4, tX = 0, tA = 2, solution = solution6x6_12_4_0_2_path },
		new solutionPath { tID=12, tY = 4, tX = 1, tA = 1, solution = solution6x6_12_4_1_1_path },
		new solutionPath { tID=12, tY = 4, tX = 1, tA = 3, solution = solution6x6_12_4_1_3_path },
		new solutionPath { tID=12, tY = 4, tX = 2, tA = 0, solution = solution6x6_12_4_2_0_path },
		new solutionPath { tID=12, tY = 4, tX = 2, tA = 2, solution = solution6x6_12_4_2_2_path },
		new solutionPath { tID=12, tY = 4, tX = 3, tA = 1, solution = solution6x6_12_4_3_1_path },
		new solutionPath { tID=12, tY = 4, tX = 3, tA = 3, solution = solution6x6_12_4_3_3_path },
		new solutionPath { tID=12, tY = 4, tX = 4, tA = 0, solution = solution6x6_12_4_4_0_path },
		new solutionPath { tID=12, tY = 4, tX = 4, tA = 2, solution = solution6x6_12_4_4_2_path },
		new solutionPath { tID=12, tY = 4, tX = 5, tA = 1, solution = solution6x6_12_4_5_1_path },
		new solutionPath { tID=12, tY = 4, tX = 5, tA = 3, solution = solution6x6_12_4_5_3_path },
		new solutionPath { tID=12, tY = 5, tX = 0, tA = 1, solution = solution6x6_12_5_0_1_path },
		new solutionPath { tID=12, tY = 5, tX = 0, tA = 3, solution = solution6x6_12_5_0_3_path },
		new solutionPath { tID=12, tY = 5, tX = 1, tA = 0, solution = solution6x6_12_5_1_0_path },
		new solutionPath { tID=12, tY = 5, tX = 1, tA = 2, solution = solution6x6_12_5_1_2_path },
		new solutionPath { tID=12, tY = 5, tX = 2, tA = 1, solution = solution6x6_12_5_2_1_path },
		new solutionPath { tID=12, tY = 5, tX = 2, tA = 3, solution = solution6x6_12_5_2_3_path },
		new solutionPath { tID=12, tY = 5, tX = 3, tA = 0, solution = solution6x6_12_5_3_0_path },
		new solutionPath { tID=12, tY = 5, tX = 3, tA = 2, solution = solution6x6_12_5_3_2_path },
		new solutionPath { tID=12, tY = 5, tX = 4, tA = 1, solution = solution6x6_12_5_4_1_path },
		new solutionPath { tID=12, tY = 5, tX = 4, tA = 3, solution = solution6x6_12_5_4_3_path },
		new solutionPath { tID=12, tY = 5, tX = 5, tA = 0, solution = solution6x6_12_5_5_0_path },
		new solutionPath { tID=12, tY = 5, tX = 5, tA = 2, solution = solution6x6_12_5_5_2_path },
		new solutionPath { tID=13, tY = 2, tX = 1, tA = 2, solution = solution6x6_13_2_1_2_path },
		new solutionPath { tID=13, tY = 2, tX = 2, tA = 1, solution = solution6x6_13_2_2_1_path },
		new solutionPath { tID=13, tY = 2, tX = 2, tA = 3, solution = solution6x6_13_2_2_3_path },
		new solutionPath { tID=13, tY = 2, tX = 3, tA = 0, solution = solution6x6_13_2_3_0_path },
		new solutionPath { tID=13, tY = 2, tX = 3, tA = 2, solution = solution6x6_13_2_3_2_path },
		new solutionPath { tID=13, tY = 2, tX = 4, tA = 1, solution = solution6x6_13_2_4_1_path },
		new solutionPath { tID=13, tY = 2, tX = 4, tA = 3, solution = solution6x6_13_2_4_3_path },
		new solutionPath { tID=13, tY = 2, tX = 5, tA = 0, solution = solution6x6_13_2_5_0_path },
		new solutionPath { tID=13, tY = 2, tX = 5, tA = 2, solution = solution6x6_13_2_5_2_path },
		new solutionPath { tID=13, tY = 3, tX = 0, tA = 0, solution = solution6x6_13_3_0_0_path },
		new solutionPath { tID=13, tY = 3, tX = 0, tA = 2, solution = solution6x6_13_3_0_2_path },
		new solutionPath { tID=13, tY = 3, tX = 1, tA = 1, solution = solution6x6_13_3_1_1_path },
		new solutionPath { tID=13, tY = 3, tX = 1, tA = 3, solution = solution6x6_13_3_1_3_path },
		new solutionPath { tID=13, tY = 3, tX = 2, tA = 0, solution = solution6x6_13_3_2_0_path },
		new solutionPath { tID=13, tY = 3, tX = 2, tA = 2, solution = solution6x6_13_3_2_2_path },
		new solutionPath { tID=13, tY = 3, tX = 3, tA = 1, solution = solution6x6_13_3_3_1_path },
		new solutionPath { tID=13, tY = 3, tX = 3, tA = 3, solution = solution6x6_13_3_3_3_path },
		new solutionPath { tID=13, tY = 3, tX = 4, tA = 0, solution = solution6x6_13_3_4_0_path },
		new solutionPath { tID=13, tY = 3, tX = 4, tA = 2, solution = solution6x6_13_3_4_2_path },
		new solutionPath { tID=13, tY = 3, tX = 5, tA = 1, solution = solution6x6_13_3_5_1_path },
		new solutionPath { tID=13, tY = 3, tX = 5, tA = 3, solution = solution6x6_13_3_5_3_path },
		new solutionPath { tID=13, tY = 4, tX = 0, tA = 1, solution = solution6x6_13_4_0_1_path },
		new solutionPath { tID=13, tY = 4, tX = 0, tA = 3, solution = solution6x6_13_4_0_3_path },
		new solutionPath { tID=13, tY = 4, tX = 1, tA = 0, solution = solution6x6_13_4_1_0_path },
		new solutionPath { tID=13, tY = 4, tX = 1, tA = 2, solution = solution6x6_13_4_1_2_path },
		new solutionPath { tID=13, tY = 4, tX = 2, tA = 1, solution = solution6x6_13_4_2_1_path },
		new solutionPath { tID=13, tY = 4, tX = 2, tA = 3, solution = solution6x6_13_4_2_3_path },
		new solutionPath { tID=13, tY = 4, tX = 3, tA = 0, solution = solution6x6_13_4_3_0_path },
		new solutionPath { tID=13, tY = 4, tX = 3, tA = 2, solution = solution6x6_13_4_3_2_path },
		new solutionPath { tID=13, tY = 4, tX = 4, tA = 1, solution = solution6x6_13_4_4_1_path },
		new solutionPath { tID=13, tY = 4, tX = 4, tA = 3, solution = solution6x6_13_4_4_3_path },
		new solutionPath { tID=13, tY = 4, tX = 5, tA = 0, solution = solution6x6_13_4_5_0_path },
		new solutionPath { tID=13, tY = 4, tX = 5, tA = 2, solution = solution6x6_13_4_5_2_path },
		new solutionPath { tID=13, tY = 5, tX = 0, tA = 0, solution = solution6x6_13_5_0_0_path },
		new solutionPath { tID=13, tY = 5, tX = 0, tA = 2, solution = solution6x6_13_5_0_2_path },
		new solutionPath { tID=13, tY = 5, tX = 1, tA = 1, solution = solution6x6_13_5_1_1_path },
		new solutionPath { tID=13, tY = 5, tX = 1, tA = 3, solution = solution6x6_13_5_1_3_path },
		new solutionPath { tID=13, tY = 5, tX = 2, tA = 0, solution = solution6x6_13_5_2_0_path },
		new solutionPath { tID=13, tY = 5, tX = 2, tA = 2, solution = solution6x6_13_5_2_2_path },
		new solutionPath { tID=13, tY = 5, tX = 3, tA = 1, solution = solution6x6_13_5_3_1_path },
		new solutionPath { tID=13, tY = 5, tX = 3, tA = 3, solution = solution6x6_13_5_3_3_path },
		new solutionPath { tID=13, tY = 5, tX = 4, tA = 0, solution = solution6x6_13_5_4_0_path },
		new solutionPath { tID=13, tY = 5, tX = 4, tA = 2, solution = solution6x6_13_5_4_2_path },
		new solutionPath { tID=13, tY = 5, tX = 5, tA = 1, solution = solution6x6_13_5_5_1_path },
		new solutionPath { tID=13, tY = 5, tX = 5, tA = 3, solution = solution6x6_13_5_5_3_path },
		new solutionPath { tID=14, tY = 2, tX = 2, tA = 2, solution = solution6x6_14_2_2_2_path },
		new solutionPath { tID=14, tY = 2, tX = 3, tA = 1, solution = solution6x6_14_2_3_1_path },
		new solutionPath { tID=14, tY = 2, tX = 3, tA = 3, solution = solution6x6_14_2_3_3_path },
		new solutionPath { tID=14, tY = 2, tX = 4, tA = 0, solution = solution6x6_14_2_4_0_path },
		new solutionPath { tID=14, tY = 2, tX = 4, tA = 2, solution = solution6x6_14_2_4_2_path },
		new solutionPath { tID=14, tY = 2, tX = 5, tA = 1, solution = solution6x6_14_2_5_1_path },
		new solutionPath { tID=14, tY = 2, tX = 5, tA = 3, solution = solution6x6_14_2_5_3_path },
		new solutionPath { tID=14, tY = 3, tX = 0, tA = 1, solution = solution6x6_14_3_0_1_path },
		new solutionPath { tID=14, tY = 3, tX = 0, tA = 3, solution = solution6x6_14_3_0_3_path },
		new solutionPath { tID=14, tY = 3, tX = 1, tA = 0, solution = solution6x6_14_3_1_0_path },
		new solutionPath { tID=14, tY = 3, tX = 1, tA = 2, solution = solution6x6_14_3_1_2_path },
		new solutionPath { tID=14, tY = 3, tX = 2, tA = 1, solution = solution6x6_14_3_2_1_path },
		new solutionPath { tID=14, tY = 3, tX = 2, tA = 3, solution = solution6x6_14_3_2_3_path },
		new solutionPath { tID=14, tY = 3, tX = 3, tA = 0, solution = solution6x6_14_3_3_0_path },
		new solutionPath { tID=14, tY = 3, tX = 3, tA = 2, solution = solution6x6_14_3_3_2_path },
		new solutionPath { tID=14, tY = 3, tX = 4, tA = 1, solution = solution6x6_14_3_4_1_path },
		new solutionPath { tID=14, tY = 3, tX = 4, tA = 3, solution = solution6x6_14_3_4_3_path },
		new solutionPath { tID=14, tY = 3, tX = 5, tA = 0, solution = solution6x6_14_3_5_0_path },
		new solutionPath { tID=14, tY = 3, tX = 5, tA = 2, solution = solution6x6_14_3_5_2_path },
		new solutionPath { tID=14, tY = 4, tX = 0, tA = 0, solution = solution6x6_14_4_0_0_path },
		new solutionPath { tID=14, tY = 4, tX = 0, tA = 2, solution = solution6x6_14_4_0_2_path },
		new solutionPath { tID=14, tY = 4, tX = 1, tA = 1, solution = solution6x6_14_4_1_1_path },
		new solutionPath { tID=14, tY = 4, tX = 1, tA = 3, solution = solution6x6_14_4_1_3_path },
		new solutionPath { tID=14, tY = 4, tX = 2, tA = 0, solution = solution6x6_14_4_2_0_path },
		new solutionPath { tID=14, tY = 4, tX = 2, tA = 2, solution = solution6x6_14_4_2_2_path },
		new solutionPath { tID=14, tY = 4, tX = 3, tA = 1, solution = solution6x6_14_4_3_1_path },
		new solutionPath { tID=14, tY = 4, tX = 3, tA = 3, solution = solution6x6_14_4_3_3_path },
		new solutionPath { tID=14, tY = 4, tX = 4, tA = 0, solution = solution6x6_14_4_4_0_path },
		new solutionPath { tID=14, tY = 4, tX = 4, tA = 2, solution = solution6x6_14_4_4_2_path },
		new solutionPath { tID=14, tY = 4, tX = 5, tA = 1, solution = solution6x6_14_4_5_1_path },
		new solutionPath { tID=14, tY = 4, tX = 5, tA = 3, solution = solution6x6_14_4_5_3_path },
		new solutionPath { tID=14, tY = 5, tX = 0, tA = 1, solution = solution6x6_14_5_0_1_path },
		new solutionPath { tID=14, tY = 5, tX = 0, tA = 3, solution = solution6x6_14_5_0_3_path },
		new solutionPath { tID=14, tY = 5, tX = 1, tA = 0, solution = solution6x6_14_5_1_0_path },
		new solutionPath { tID=14, tY = 5, tX = 1, tA = 2, solution = solution6x6_14_5_1_2_path },
		new solutionPath { tID=14, tY = 5, tX = 2, tA = 1, solution = solution6x6_14_5_2_1_path },
		new solutionPath { tID=14, tY = 5, tX = 2, tA = 3, solution = solution6x6_14_5_2_3_path },
		new solutionPath { tID=14, tY = 5, tX = 3, tA = 0, solution = solution6x6_14_5_3_0_path },
		new solutionPath { tID=14, tY = 5, tX = 3, tA = 2, solution = solution6x6_14_5_3_2_path },
		new solutionPath { tID=14, tY = 5, tX = 4, tA = 1, solution = solution6x6_14_5_4_1_path },
		new solutionPath { tID=14, tY = 5, tX = 4, tA = 3, solution = solution6x6_14_5_4_3_path },
		new solutionPath { tID=14, tY = 5, tX = 5, tA = 0, solution = solution6x6_14_5_5_0_path },
		new solutionPath { tID=14, tY = 5, tX = 5, tA = 2, solution = solution6x6_14_5_5_2_path },
		new solutionPath { tID=15, tY = 2, tX = 3, tA = 2, solution = solution6x6_15_2_3_2_path },
		new solutionPath { tID=15, tY = 2, tX = 4, tA = 1, solution = solution6x6_15_2_4_1_path },
		new solutionPath { tID=15, tY = 2, tX = 4, tA = 3, solution = solution6x6_15_2_4_3_path },
		new solutionPath { tID=15, tY = 2, tX = 5, tA = 0, solution = solution6x6_15_2_5_0_path },
		new solutionPath { tID=15, tY = 2, tX = 5, tA = 2, solution = solution6x6_15_2_5_2_path },
		new solutionPath { tID=15, tY = 3, tX = 0, tA = 0, solution = solution6x6_15_3_0_0_path },
		new solutionPath { tID=15, tY = 3, tX = 0, tA = 2, solution = solution6x6_15_3_0_2_path },
		new solutionPath { tID=15, tY = 3, tX = 1, tA = 1, solution = solution6x6_15_3_1_1_path },
		new solutionPath { tID=15, tY = 3, tX = 1, tA = 3, solution = solution6x6_15_3_1_3_path },
		new solutionPath { tID=15, tY = 3, tX = 2, tA = 0, solution = solution6x6_15_3_2_0_path },
		new solutionPath { tID=15, tY = 3, tX = 2, tA = 2, solution = solution6x6_15_3_2_2_path },
		new solutionPath { tID=15, tY = 3, tX = 3, tA = 1, solution = solution6x6_15_3_3_1_path },
		new solutionPath { tID=15, tY = 3, tX = 3, tA = 3, solution = solution6x6_15_3_3_3_path },
		new solutionPath { tID=15, tY = 3, tX = 4, tA = 0, solution = solution6x6_15_3_4_0_path },
		new solutionPath { tID=15, tY = 3, tX = 4, tA = 2, solution = solution6x6_15_3_4_2_path },
		new solutionPath { tID=15, tY = 3, tX = 5, tA = 1, solution = solution6x6_15_3_5_1_path },
		new solutionPath { tID=15, tY = 3, tX = 5, tA = 3, solution = solution6x6_15_3_5_3_path },
		new solutionPath { tID=15, tY = 4, tX = 0, tA = 1, solution = solution6x6_15_4_0_1_path },
		new solutionPath { tID=15, tY = 4, tX = 0, tA = 3, solution = solution6x6_15_4_0_3_path },
		new solutionPath { tID=15, tY = 4, tX = 1, tA = 0, solution = solution6x6_15_4_1_0_path },
		new solutionPath { tID=15, tY = 4, tX = 1, tA = 2, solution = solution6x6_15_4_1_2_path },
		new solutionPath { tID=15, tY = 4, tX = 2, tA = 1, solution = solution6x6_15_4_2_1_path },
		new solutionPath { tID=15, tY = 4, tX = 2, tA = 3, solution = solution6x6_15_4_2_3_path },
		new solutionPath { tID=15, tY = 4, tX = 3, tA = 0, solution = solution6x6_15_4_3_0_path },
		new solutionPath { tID=15, tY = 4, tX = 3, tA = 2, solution = solution6x6_15_4_3_2_path },
		new solutionPath { tID=15, tY = 4, tX = 4, tA = 1, solution = solution6x6_15_4_4_1_path },
		new solutionPath { tID=15, tY = 4, tX = 4, tA = 3, solution = solution6x6_15_4_4_3_path },
		new solutionPath { tID=15, tY = 4, tX = 5, tA = 0, solution = solution6x6_15_4_5_0_path },
		new solutionPath { tID=15, tY = 4, tX = 5, tA = 2, solution = solution6x6_15_4_5_2_path },
		new solutionPath { tID=15, tY = 5, tX = 0, tA = 0, solution = solution6x6_15_5_0_0_path },
		new solutionPath { tID=15, tY = 5, tX = 0, tA = 2, solution = solution6x6_15_5_0_2_path },
		new solutionPath { tID=15, tY = 5, tX = 1, tA = 1, solution = solution6x6_15_5_1_1_path },
		new solutionPath { tID=15, tY = 5, tX = 1, tA = 3, solution = solution6x6_15_5_1_3_path },
		new solutionPath { tID=15, tY = 5, tX = 2, tA = 0, solution = solution6x6_15_5_2_0_path },
		new solutionPath { tID=15, tY = 5, tX = 2, tA = 2, solution = solution6x6_15_5_2_2_path },
		new solutionPath { tID=15, tY = 5, tX = 3, tA = 1, solution = solution6x6_15_5_3_1_path },
		new solutionPath { tID=15, tY = 5, tX = 3, tA = 3, solution = solution6x6_15_5_3_3_path },
		new solutionPath { tID=15, tY = 5, tX = 4, tA = 0, solution = solution6x6_15_5_4_0_path },
		new solutionPath { tID=15, tY = 5, tX = 4, tA = 2, solution = solution6x6_15_5_4_2_path },
		new solutionPath { tID=15, tY = 5, tX = 5, tA = 1, solution = solution6x6_15_5_5_1_path },
		new solutionPath { tID=15, tY = 5, tX = 5, tA = 3, solution = solution6x6_15_5_5_3_path },
		new solutionPath { tID=16, tY = 2, tX = 4, tA = 2, solution = solution6x6_16_2_4_2_path },
		new solutionPath { tID=16, tY = 2, tX = 5, tA = 1, solution = solution6x6_16_2_5_1_path },
		new solutionPath { tID=16, tY = 2, tX = 5, tA = 3, solution = solution6x6_16_2_5_3_path },
		new solutionPath { tID=16, tY = 3, tX = 0, tA = 1, solution = solution6x6_16_3_0_1_path },
		new solutionPath { tID=16, tY = 3, tX = 0, tA = 3, solution = solution6x6_16_3_0_3_path },
		new solutionPath { tID=16, tY = 3, tX = 1, tA = 0, solution = solution6x6_16_3_1_0_path },
		new solutionPath { tID=16, tY = 3, tX = 1, tA = 2, solution = solution6x6_16_3_1_2_path },
		new solutionPath { tID=16, tY = 3, tX = 2, tA = 1, solution = solution6x6_16_3_2_1_path },
		new solutionPath { tID=16, tY = 3, tX = 2, tA = 3, solution = solution6x6_16_3_2_3_path },
		new solutionPath { tID=16, tY = 3, tX = 3, tA = 0, solution = solution6x6_16_3_3_0_path },
		new solutionPath { tID=16, tY = 3, tX = 3, tA = 2, solution = solution6x6_16_3_3_2_path },
		new solutionPath { tID=16, tY = 3, tX = 4, tA = 1, solution = solution6x6_16_3_4_1_path },
		new solutionPath { tID=16, tY = 3, tX = 4, tA = 3, solution = solution6x6_16_3_4_3_path },
		new solutionPath { tID=16, tY = 3, tX = 5, tA = 0, solution = solution6x6_16_3_5_0_path },
		new solutionPath { tID=16, tY = 3, tX = 5, tA = 2, solution = solution6x6_16_3_5_2_path },
		new solutionPath { tID=16, tY = 4, tX = 0, tA = 0, solution = solution6x6_16_4_0_0_path },
		new solutionPath { tID=16, tY = 4, tX = 0, tA = 2, solution = solution6x6_16_4_0_2_path },
		new solutionPath { tID=16, tY = 4, tX = 1, tA = 1, solution = solution6x6_16_4_1_1_path },
		new solutionPath { tID=16, tY = 4, tX = 1, tA = 3, solution = solution6x6_16_4_1_3_path },
		new solutionPath { tID=16, tY = 4, tX = 2, tA = 0, solution = solution6x6_16_4_2_0_path },
		new solutionPath { tID=16, tY = 4, tX = 2, tA = 2, solution = solution6x6_16_4_2_2_path },
		new solutionPath { tID=16, tY = 4, tX = 3, tA = 1, solution = solution6x6_16_4_3_1_path },
		new solutionPath { tID=16, tY = 4, tX = 3, tA = 3, solution = solution6x6_16_4_3_3_path },
		new solutionPath { tID=16, tY = 4, tX = 4, tA = 0, solution = solution6x6_16_4_4_0_path },
		new solutionPath { tID=16, tY = 4, tX = 4, tA = 2, solution = solution6x6_16_4_4_2_path },
		new solutionPath { tID=16, tY = 4, tX = 5, tA = 1, solution = solution6x6_16_4_5_1_path },
		new solutionPath { tID=16, tY = 4, tX = 5, tA = 3, solution = solution6x6_16_4_5_3_path },
		new solutionPath { tID=16, tY = 5, tX = 0, tA = 1, solution = solution6x6_16_5_0_1_path },
		new solutionPath { tID=16, tY = 5, tX = 0, tA = 3, solution = solution6x6_16_5_0_3_path },
		new solutionPath { tID=16, tY = 5, tX = 1, tA = 0, solution = solution6x6_16_5_1_0_path },
		new solutionPath { tID=16, tY = 5, tX = 1, tA = 2, solution = solution6x6_16_5_1_2_path },
		new solutionPath { tID=16, tY = 5, tX = 2, tA = 1, solution = solution6x6_16_5_2_1_path },
		new solutionPath { tID=16, tY = 5, tX = 2, tA = 3, solution = solution6x6_16_5_2_3_path },
		new solutionPath { tID=16, tY = 5, tX = 3, tA = 0, solution = solution6x6_16_5_3_0_path },
		new solutionPath { tID=16, tY = 5, tX = 3, tA = 2, solution = solution6x6_16_5_3_2_path },
		new solutionPath { tID=16, tY = 5, tX = 4, tA = 1, solution = solution6x6_16_5_4_1_path },
		new solutionPath { tID=16, tY = 5, tX = 4, tA = 3, solution = solution6x6_16_5_4_3_path },
		new solutionPath { tID=16, tY = 5, tX = 5, tA = 0, solution = solution6x6_16_5_5_0_path },
		new solutionPath { tID=16, tY = 5, tX = 5, tA = 2, solution = solution6x6_16_5_5_2_path },
		new solutionPath { tID=17, tY = 2, tX = 5, tA = 2, solution = solution6x6_17_2_5_2_path },
		new solutionPath { tID=17, tY = 3, tX = 0, tA = 0, solution = solution6x6_17_3_0_0_path },
		new solutionPath { tID=17, tY = 3, tX = 0, tA = 2, solution = solution6x6_17_3_0_2_path },
		new solutionPath { tID=17, tY = 3, tX = 1, tA = 1, solution = solution6x6_17_3_1_1_path },
		new solutionPath { tID=17, tY = 3, tX = 1, tA = 3, solution = solution6x6_17_3_1_3_path },
		new solutionPath { tID=17, tY = 3, tX = 2, tA = 0, solution = solution6x6_17_3_2_0_path },
		new solutionPath { tID=17, tY = 3, tX = 2, tA = 2, solution = solution6x6_17_3_2_2_path },
		new solutionPath { tID=17, tY = 3, tX = 3, tA = 1, solution = solution6x6_17_3_3_1_path },
		new solutionPath { tID=17, tY = 3, tX = 3, tA = 3, solution = solution6x6_17_3_3_3_path },
		new solutionPath { tID=17, tY = 3, tX = 4, tA = 0, solution = solution6x6_17_3_4_0_path },
		new solutionPath { tID=17, tY = 3, tX = 4, tA = 2, solution = solution6x6_17_3_4_2_path },
		new solutionPath { tID=17, tY = 3, tX = 5, tA = 1, solution = solution6x6_17_3_5_1_path },
		new solutionPath { tID=17, tY = 3, tX = 5, tA = 3, solution = solution6x6_17_3_5_3_path },
		new solutionPath { tID=17, tY = 4, tX = 0, tA = 1, solution = solution6x6_17_4_0_1_path },
		new solutionPath { tID=17, tY = 4, tX = 0, tA = 3, solution = solution6x6_17_4_0_3_path },
		new solutionPath { tID=17, tY = 4, tX = 1, tA = 0, solution = solution6x6_17_4_1_0_path },
		new solutionPath { tID=17, tY = 4, tX = 1, tA = 2, solution = solution6x6_17_4_1_2_path },
		new solutionPath { tID=17, tY = 4, tX = 2, tA = 1, solution = solution6x6_17_4_2_1_path },
		new solutionPath { tID=17, tY = 4, tX = 2, tA = 3, solution = solution6x6_17_4_2_3_path },
		new solutionPath { tID=17, tY = 4, tX = 3, tA = 0, solution = solution6x6_17_4_3_0_path },
		new solutionPath { tID=17, tY = 4, tX = 3, tA = 2, solution = solution6x6_17_4_3_2_path },
		new solutionPath { tID=17, tY = 4, tX = 4, tA = 1, solution = solution6x6_17_4_4_1_path },
		new solutionPath { tID=17, tY = 4, tX = 4, tA = 3, solution = solution6x6_17_4_4_3_path },
		new solutionPath { tID=17, tY = 4, tX = 5, tA = 0, solution = solution6x6_17_4_5_0_path },
		new solutionPath { tID=17, tY = 4, tX = 5, tA = 2, solution = solution6x6_17_4_5_2_path },
		new solutionPath { tID=17, tY = 5, tX = 0, tA = 0, solution = solution6x6_17_5_0_0_path },
		new solutionPath { tID=17, tY = 5, tX = 0, tA = 2, solution = solution6x6_17_5_0_2_path },
		new solutionPath { tID=17, tY = 5, tX = 1, tA = 1, solution = solution6x6_17_5_1_1_path },
		new solutionPath { tID=17, tY = 5, tX = 1, tA = 3, solution = solution6x6_17_5_1_3_path },
		new solutionPath { tID=17, tY = 5, tX = 2, tA = 0, solution = solution6x6_17_5_2_0_path },
		new solutionPath { tID=17, tY = 5, tX = 2, tA = 2, solution = solution6x6_17_5_2_2_path },
		new solutionPath { tID=17, tY = 5, tX = 3, tA = 1, solution = solution6x6_17_5_3_1_path },
		new solutionPath { tID=17, tY = 5, tX = 3, tA = 3, solution = solution6x6_17_5_3_3_path },
		new solutionPath { tID=17, tY = 5, tX = 4, tA = 0, solution = solution6x6_17_5_4_0_path },
		new solutionPath { tID=17, tY = 5, tX = 4, tA = 2, solution = solution6x6_17_5_4_2_path },
		new solutionPath { tID=17, tY = 5, tX = 5, tA = 1, solution = solution6x6_17_5_5_1_path },
		new solutionPath { tID=17, tY = 5, tX = 5, tA = 3, solution = solution6x6_17_5_5_3_path },
		new solutionPath { tID=18, tY = 3, tX = 0, tA = 2, solution = solution6x6_18_3_0_2_path },
		new solutionPath { tID=18, tY = 3, tX = 1, tA = 1, solution = solution6x6_18_3_1_1_path },
		new solutionPath { tID=18, tY = 3, tX = 1, tA = 3, solution = solution6x6_18_3_1_3_path },
		new solutionPath { tID=18, tY = 3, tX = 2, tA = 0, solution = solution6x6_18_3_2_0_path },
		new solutionPath { tID=18, tY = 3, tX = 2, tA = 2, solution = solution6x6_18_3_2_2_path },
		new solutionPath { tID=18, tY = 3, tX = 3, tA = 1, solution = solution6x6_18_3_3_1_path },
		new solutionPath { tID=18, tY = 3, tX = 3, tA = 3, solution = solution6x6_18_3_3_3_path },
		new solutionPath { tID=18, tY = 3, tX = 4, tA = 0, solution = solution6x6_18_3_4_0_path },
		new solutionPath { tID=18, tY = 3, tX = 4, tA = 2, solution = solution6x6_18_3_4_2_path },
		new solutionPath { tID=18, tY = 3, tX = 5, tA = 1, solution = solution6x6_18_3_5_1_path },
		new solutionPath { tID=18, tY = 3, tX = 5, tA = 3, solution = solution6x6_18_3_5_3_path },
		new solutionPath { tID=18, tY = 4, tX = 0, tA = 1, solution = solution6x6_18_4_0_1_path },
		new solutionPath { tID=18, tY = 4, tX = 0, tA = 3, solution = solution6x6_18_4_0_3_path },
		new solutionPath { tID=18, tY = 4, tX = 1, tA = 0, solution = solution6x6_18_4_1_0_path },
		new solutionPath { tID=18, tY = 4, tX = 1, tA = 2, solution = solution6x6_18_4_1_2_path },
		new solutionPath { tID=18, tY = 4, tX = 2, tA = 1, solution = solution6x6_18_4_2_1_path },
		new solutionPath { tID=18, tY = 4, tX = 2, tA = 3, solution = solution6x6_18_4_2_3_path },
		new solutionPath { tID=18, tY = 4, tX = 3, tA = 0, solution = solution6x6_18_4_3_0_path },
		new solutionPath { tID=18, tY = 4, tX = 3, tA = 2, solution = solution6x6_18_4_3_2_path },
		new solutionPath { tID=18, tY = 4, tX = 4, tA = 1, solution = solution6x6_18_4_4_1_path },
		new solutionPath { tID=18, tY = 4, tX = 4, tA = 3, solution = solution6x6_18_4_4_3_path },
		new solutionPath { tID=18, tY = 4, tX = 5, tA = 0, solution = solution6x6_18_4_5_0_path },
		new solutionPath { tID=18, tY = 4, tX = 5, tA = 2, solution = solution6x6_18_4_5_2_path },
		new solutionPath { tID=18, tY = 5, tX = 0, tA = 0, solution = solution6x6_18_5_0_0_path },
		new solutionPath { tID=18, tY = 5, tX = 0, tA = 2, solution = solution6x6_18_5_0_2_path },
		new solutionPath { tID=18, tY = 5, tX = 1, tA = 1, solution = solution6x6_18_5_1_1_path },
		new solutionPath { tID=18, tY = 5, tX = 1, tA = 3, solution = solution6x6_18_5_1_3_path },
		new solutionPath { tID=18, tY = 5, tX = 2, tA = 0, solution = solution6x6_18_5_2_0_path },
		new solutionPath { tID=18, tY = 5, tX = 2, tA = 2, solution = solution6x6_18_5_2_2_path },
		new solutionPath { tID=18, tY = 5, tX = 3, tA = 1, solution = solution6x6_18_5_3_1_path },
		new solutionPath { tID=18, tY = 5, tX = 3, tA = 3, solution = solution6x6_18_5_3_3_path },
		new solutionPath { tID=18, tY = 5, tX = 4, tA = 0, solution = solution6x6_18_5_4_0_path },
		new solutionPath { tID=18, tY = 5, tX = 4, tA = 2, solution = solution6x6_18_5_4_2_path },
		new solutionPath { tID=18, tY = 5, tX = 5, tA = 1, solution = solution6x6_18_5_5_1_path },
		new solutionPath { tID=18, tY = 5, tX = 5, tA = 3, solution = solution6x6_18_5_5_3_path },
		new solutionPath { tID=19, tY = 3, tX = 1, tA = 2, solution = solution6x6_19_3_1_2_path },
		new solutionPath { tID=19, tY = 3, tX = 2, tA = 1, solution = solution6x6_19_3_2_1_path },
		new solutionPath { tID=19, tY = 3, tX = 2, tA = 3, solution = solution6x6_19_3_2_3_path },
		new solutionPath { tID=19, tY = 3, tX = 3, tA = 0, solution = solution6x6_19_3_3_0_path },
		new solutionPath { tID=19, tY = 3, tX = 3, tA = 2, solution = solution6x6_19_3_3_2_path },
		new solutionPath { tID=19, tY = 3, tX = 4, tA = 1, solution = solution6x6_19_3_4_1_path },
		new solutionPath { tID=19, tY = 3, tX = 4, tA = 3, solution = solution6x6_19_3_4_3_path },
		new solutionPath { tID=19, tY = 3, tX = 5, tA = 0, solution = solution6x6_19_3_5_0_path },
		new solutionPath { tID=19, tY = 3, tX = 5, tA = 2, solution = solution6x6_19_3_5_2_path },
		new solutionPath { tID=19, tY = 4, tX = 0, tA = 0, solution = solution6x6_19_4_0_0_path },
		new solutionPath { tID=19, tY = 4, tX = 0, tA = 2, solution = solution6x6_19_4_0_2_path },
		new solutionPath { tID=19, tY = 4, tX = 1, tA = 1, solution = solution6x6_19_4_1_1_path },
		new solutionPath { tID=19, tY = 4, tX = 1, tA = 3, solution = solution6x6_19_4_1_3_path },
		new solutionPath { tID=19, tY = 4, tX = 2, tA = 0, solution = solution6x6_19_4_2_0_path },
		new solutionPath { tID=19, tY = 4, tX = 2, tA = 2, solution = solution6x6_19_4_2_2_path },
		new solutionPath { tID=19, tY = 4, tX = 3, tA = 1, solution = solution6x6_19_4_3_1_path },
		new solutionPath { tID=19, tY = 4, tX = 3, tA = 3, solution = solution6x6_19_4_3_3_path },
		new solutionPath { tID=19, tY = 4, tX = 4, tA = 0, solution = solution6x6_19_4_4_0_path },
		new solutionPath { tID=19, tY = 4, tX = 4, tA = 2, solution = solution6x6_19_4_4_2_path },
		new solutionPath { tID=19, tY = 4, tX = 5, tA = 1, solution = solution6x6_19_4_5_1_path },
		new solutionPath { tID=19, tY = 4, tX = 5, tA = 3, solution = solution6x6_19_4_5_3_path },
		new solutionPath { tID=19, tY = 5, tX = 0, tA = 1, solution = solution6x6_19_5_0_1_path },
		new solutionPath { tID=19, tY = 5, tX = 0, tA = 3, solution = solution6x6_19_5_0_3_path },
		new solutionPath { tID=19, tY = 5, tX = 1, tA = 0, solution = solution6x6_19_5_1_0_path },
		new solutionPath { tID=19, tY = 5, tX = 1, tA = 2, solution = solution6x6_19_5_1_2_path },
		new solutionPath { tID=19, tY = 5, tX = 2, tA = 1, solution = solution6x6_19_5_2_1_path },
		new solutionPath { tID=19, tY = 5, tX = 2, tA = 3, solution = solution6x6_19_5_2_3_path },
		new solutionPath { tID=19, tY = 5, tX = 3, tA = 0, solution = solution6x6_19_5_3_0_path },
		new solutionPath { tID=19, tY = 5, tX = 3, tA = 2, solution = solution6x6_19_5_3_2_path },
		new solutionPath { tID=19, tY = 5, tX = 4, tA = 1, solution = solution6x6_19_5_4_1_path },
		new solutionPath { tID=19, tY = 5, tX = 4, tA = 3, solution = solution6x6_19_5_4_3_path },
		new solutionPath { tID=19, tY = 5, tX = 5, tA = 0, solution = solution6x6_19_5_5_0_path },
		new solutionPath { tID=19, tY = 5, tX = 5, tA = 2, solution = solution6x6_19_5_5_2_path },
		new solutionPath { tID=20, tY = 3, tX = 2, tA = 2, solution = solution6x6_20_3_2_2_path },
		new solutionPath { tID=20, tY = 3, tX = 3, tA = 1, solution = solution6x6_20_3_3_1_path },
		new solutionPath { tID=20, tY = 3, tX = 3, tA = 3, solution = solution6x6_20_3_3_3_path },
		new solutionPath { tID=20, tY = 3, tX = 4, tA = 0, solution = solution6x6_20_3_4_0_path },
		new solutionPath { tID=20, tY = 3, tX = 4, tA = 2, solution = solution6x6_20_3_4_2_path },
		new solutionPath { tID=20, tY = 3, tX = 5, tA = 1, solution = solution6x6_20_3_5_1_path },
		new solutionPath { tID=20, tY = 3, tX = 5, tA = 3, solution = solution6x6_20_3_5_3_path },
		new solutionPath { tID=20, tY = 4, tX = 0, tA = 1, solution = solution6x6_20_4_0_1_path },
		new solutionPath { tID=20, tY = 4, tX = 0, tA = 3, solution = solution6x6_20_4_0_3_path },
		new solutionPath { tID=20, tY = 4, tX = 1, tA = 0, solution = solution6x6_20_4_1_0_path },
		new solutionPath { tID=20, tY = 4, tX = 1, tA = 2, solution = solution6x6_20_4_1_2_path },
		new solutionPath { tID=20, tY = 4, tX = 2, tA = 1, solution = solution6x6_20_4_2_1_path },
		new solutionPath { tID=20, tY = 4, tX = 2, tA = 3, solution = solution6x6_20_4_2_3_path },
		new solutionPath { tID=20, tY = 4, tX = 3, tA = 0, solution = solution6x6_20_4_3_0_path },
		new solutionPath { tID=20, tY = 4, tX = 3, tA = 2, solution = solution6x6_20_4_3_2_path },
		new solutionPath { tID=20, tY = 4, tX = 4, tA = 1, solution = solution6x6_20_4_4_1_path },
		new solutionPath { tID=20, tY = 4, tX = 4, tA = 3, solution = solution6x6_20_4_4_3_path },
		new solutionPath { tID=20, tY = 4, tX = 5, tA = 0, solution = solution6x6_20_4_5_0_path },
		new solutionPath { tID=20, tY = 4, tX = 5, tA = 2, solution = solution6x6_20_4_5_2_path },
		new solutionPath { tID=20, tY = 5, tX = 0, tA = 0, solution = solution6x6_20_5_0_0_path },
		new solutionPath { tID=20, tY = 5, tX = 0, tA = 2, solution = solution6x6_20_5_0_2_path },
		new solutionPath { tID=20, tY = 5, tX = 1, tA = 1, solution = solution6x6_20_5_1_1_path },
		new solutionPath { tID=20, tY = 5, tX = 1, tA = 3, solution = solution6x6_20_5_1_3_path },
		new solutionPath { tID=20, tY = 5, tX = 2, tA = 0, solution = solution6x6_20_5_2_0_path },
		new solutionPath { tID=20, tY = 5, tX = 2, tA = 2, solution = solution6x6_20_5_2_2_path },
		new solutionPath { tID=20, tY = 5, tX = 3, tA = 1, solution = solution6x6_20_5_3_1_path },
		new solutionPath { tID=20, tY = 5, tX = 3, tA = 3, solution = solution6x6_20_5_3_3_path },
		new solutionPath { tID=20, tY = 5, tX = 4, tA = 0, solution = solution6x6_20_5_4_0_path },
		new solutionPath { tID=20, tY = 5, tX = 4, tA = 2, solution = solution6x6_20_5_4_2_path },
		new solutionPath { tID=20, tY = 5, tX = 5, tA = 1, solution = solution6x6_20_5_5_1_path },
		new solutionPath { tID=20, tY = 5, tX = 5, tA = 3, solution = solution6x6_20_5_5_3_path },
		new solutionPath { tID=21, tY = 3, tX = 3, tA = 2, solution = solution6x6_21_3_3_2_path },
		new solutionPath { tID=21, tY = 3, tX = 4, tA = 1, solution = solution6x6_21_3_4_1_path },
		new solutionPath { tID=21, tY = 3, tX = 4, tA = 3, solution = solution6x6_21_3_4_3_path },
		new solutionPath { tID=21, tY = 3, tX = 5, tA = 0, solution = solution6x6_21_3_5_0_path },
		new solutionPath { tID=21, tY = 3, tX = 5, tA = 2, solution = solution6x6_21_3_5_2_path },
		new solutionPath { tID=21, tY = 4, tX = 0, tA = 0, solution = solution6x6_21_4_0_0_path },
		new solutionPath { tID=21, tY = 4, tX = 0, tA = 2, solution = solution6x6_21_4_0_2_path },
		new solutionPath { tID=21, tY = 4, tX = 1, tA = 1, solution = solution6x6_21_4_1_1_path },
		new solutionPath { tID=21, tY = 4, tX = 1, tA = 3, solution = solution6x6_21_4_1_3_path },
		new solutionPath { tID=21, tY = 4, tX = 2, tA = 0, solution = solution6x6_21_4_2_0_path },
		new solutionPath { tID=21, tY = 4, tX = 2, tA = 2, solution = solution6x6_21_4_2_2_path },
		new solutionPath { tID=21, tY = 4, tX = 3, tA = 1, solution = solution6x6_21_4_3_1_path },
		new solutionPath { tID=21, tY = 4, tX = 3, tA = 3, solution = solution6x6_21_4_3_3_path },
		new solutionPath { tID=21, tY = 4, tX = 4, tA = 0, solution = solution6x6_21_4_4_0_path },
		new solutionPath { tID=21, tY = 4, tX = 4, tA = 2, solution = solution6x6_21_4_4_2_path },
		new solutionPath { tID=21, tY = 4, tX = 5, tA = 1, solution = solution6x6_21_4_5_1_path },
		new solutionPath { tID=21, tY = 4, tX = 5, tA = 3, solution = solution6x6_21_4_5_3_path },
		new solutionPath { tID=21, tY = 5, tX = 0, tA = 1, solution = solution6x6_21_5_0_1_path },
		new solutionPath { tID=21, tY = 5, tX = 0, tA = 3, solution = solution6x6_21_5_0_3_path },
		new solutionPath { tID=21, tY = 5, tX = 1, tA = 0, solution = solution6x6_21_5_1_0_path },
		new solutionPath { tID=21, tY = 5, tX = 1, tA = 2, solution = solution6x6_21_5_1_2_path },
		new solutionPath { tID=21, tY = 5, tX = 2, tA = 1, solution = solution6x6_21_5_2_1_path },
		new solutionPath { tID=21, tY = 5, tX = 2, tA = 3, solution = solution6x6_21_5_2_3_path },
		new solutionPath { tID=21, tY = 5, tX = 3, tA = 0, solution = solution6x6_21_5_3_0_path },
		new solutionPath { tID=21, tY = 5, tX = 3, tA = 2, solution = solution6x6_21_5_3_2_path },
		new solutionPath { tID=21, tY = 5, tX = 4, tA = 1, solution = solution6x6_21_5_4_1_path },
		new solutionPath { tID=21, tY = 5, tX = 4, tA = 3, solution = solution6x6_21_5_4_3_path },
		new solutionPath { tID=21, tY = 5, tX = 5, tA = 0, solution = solution6x6_21_5_5_0_path },
		new solutionPath { tID=21, tY = 5, tX = 5, tA = 2, solution = solution6x6_21_5_5_2_path },
		new solutionPath { tID=22, tY = 3, tX = 4, tA = 2, solution = solution6x6_22_3_4_2_path },
		new solutionPath { tID=22, tY = 3, tX = 5, tA = 1, solution = solution6x6_22_3_5_1_path },
		new solutionPath { tID=22, tY = 3, tX = 5, tA = 3, solution = solution6x6_22_3_5_3_path },
		new solutionPath { tID=22, tY = 4, tX = 0, tA = 1, solution = solution6x6_22_4_0_1_path },
		new solutionPath { tID=22, tY = 4, tX = 0, tA = 3, solution = solution6x6_22_4_0_3_path },
		new solutionPath { tID=22, tY = 4, tX = 1, tA = 0, solution = solution6x6_22_4_1_0_path },
		new solutionPath { tID=22, tY = 4, tX = 1, tA = 2, solution = solution6x6_22_4_1_2_path },
		new solutionPath { tID=22, tY = 4, tX = 2, tA = 1, solution = solution6x6_22_4_2_1_path },
		new solutionPath { tID=22, tY = 4, tX = 2, tA = 3, solution = solution6x6_22_4_2_3_path },
		new solutionPath { tID=22, tY = 4, tX = 3, tA = 0, solution = solution6x6_22_4_3_0_path },
		new solutionPath { tID=22, tY = 4, tX = 3, tA = 2, solution = solution6x6_22_4_3_2_path },
		new solutionPath { tID=22, tY = 4, tX = 4, tA = 1, solution = solution6x6_22_4_4_1_path },
		new solutionPath { tID=22, tY = 4, tX = 4, tA = 3, solution = solution6x6_22_4_4_3_path },
		new solutionPath { tID=22, tY = 4, tX = 5, tA = 0, solution = solution6x6_22_4_5_0_path },
		new solutionPath { tID=22, tY = 4, tX = 5, tA = 2, solution = solution6x6_22_4_5_2_path },
		new solutionPath { tID=22, tY = 5, tX = 0, tA = 0, solution = solution6x6_22_5_0_0_path },
		new solutionPath { tID=22, tY = 5, tX = 0, tA = 2, solution = solution6x6_22_5_0_2_path },
		new solutionPath { tID=22, tY = 5, tX = 1, tA = 1, solution = solution6x6_22_5_1_1_path },
		new solutionPath { tID=22, tY = 5, tX = 1, tA = 3, solution = solution6x6_22_5_1_3_path },
		new solutionPath { tID=22, tY = 5, tX = 2, tA = 0, solution = solution6x6_22_5_2_0_path },
		new solutionPath { tID=22, tY = 5, tX = 2, tA = 2, solution = solution6x6_22_5_2_2_path },
		new solutionPath { tID=22, tY = 5, tX = 3, tA = 1, solution = solution6x6_22_5_3_1_path },
		new solutionPath { tID=22, tY = 5, tX = 3, tA = 3, solution = solution6x6_22_5_3_3_path },
		new solutionPath { tID=22, tY = 5, tX = 4, tA = 0, solution = solution6x6_22_5_4_0_path },
		new solutionPath { tID=22, tY = 5, tX = 4, tA = 2, solution = solution6x6_22_5_4_2_path },
		new solutionPath { tID=22, tY = 5, tX = 5, tA = 1, solution = solution6x6_22_5_5_1_path },
		new solutionPath { tID=22, tY = 5, tX = 5, tA = 3, solution = solution6x6_22_5_5_3_path },
		new solutionPath { tID=23, tY = 3, tX = 5, tA = 2, solution = solution6x6_23_3_5_2_path },
		new solutionPath { tID=23, tY = 4, tX = 0, tA = 0, solution = solution6x6_23_4_0_0_path },
		new solutionPath { tID=23, tY = 4, tX = 0, tA = 2, solution = solution6x6_23_4_0_2_path },
		new solutionPath { tID=23, tY = 4, tX = 1, tA = 1, solution = solution6x6_23_4_1_1_path },
		new solutionPath { tID=23, tY = 4, tX = 1, tA = 3, solution = solution6x6_23_4_1_3_path },
		new solutionPath { tID=23, tY = 4, tX = 2, tA = 0, solution = solution6x6_23_4_2_0_path },
		new solutionPath { tID=23, tY = 4, tX = 2, tA = 2, solution = solution6x6_23_4_2_2_path },
		new solutionPath { tID=23, tY = 4, tX = 3, tA = 1, solution = solution6x6_23_4_3_1_path },
		new solutionPath { tID=23, tY = 4, tX = 3, tA = 3, solution = solution6x6_23_4_3_3_path },
		new solutionPath { tID=23, tY = 4, tX = 4, tA = 0, solution = solution6x6_23_4_4_0_path },
		new solutionPath { tID=23, tY = 4, tX = 4, tA = 2, solution = solution6x6_23_4_4_2_path },
		new solutionPath { tID=23, tY = 4, tX = 5, tA = 1, solution = solution6x6_23_4_5_1_path },
		new solutionPath { tID=23, tY = 4, tX = 5, tA = 3, solution = solution6x6_23_4_5_3_path },
		new solutionPath { tID=23, tY = 5, tX = 0, tA = 1, solution = solution6x6_23_5_0_1_path },
		new solutionPath { tID=23, tY = 5, tX = 0, tA = 3, solution = solution6x6_23_5_0_3_path },
		new solutionPath { tID=23, tY = 5, tX = 1, tA = 0, solution = solution6x6_23_5_1_0_path },
		new solutionPath { tID=23, tY = 5, tX = 1, tA = 2, solution = solution6x6_23_5_1_2_path },
		new solutionPath { tID=23, tY = 5, tX = 2, tA = 1, solution = solution6x6_23_5_2_1_path },
		new solutionPath { tID=23, tY = 5, tX = 2, tA = 3, solution = solution6x6_23_5_2_3_path },
		new solutionPath { tID=23, tY = 5, tX = 3, tA = 0, solution = solution6x6_23_5_3_0_path },
		new solutionPath { tID=23, tY = 5, tX = 3, tA = 2, solution = solution6x6_23_5_3_2_path },
		new solutionPath { tID=23, tY = 5, tX = 4, tA = 1, solution = solution6x6_23_5_4_1_path },
		new solutionPath { tID=23, tY = 5, tX = 4, tA = 3, solution = solution6x6_23_5_4_3_path },
		new solutionPath { tID=23, tY = 5, tX = 5, tA = 0, solution = solution6x6_23_5_5_0_path },
		new solutionPath { tID=23, tY = 5, tX = 5, tA = 2, solution = solution6x6_23_5_5_2_path },
		new solutionPath { tID=24, tY = 4, tX = 0, tA = 2, solution = solution6x6_24_4_0_2_path },
		new solutionPath { tID=24, tY = 4, tX = 1, tA = 1, solution = solution6x6_24_4_1_1_path },
		new solutionPath { tID=24, tY = 4, tX = 1, tA = 3, solution = solution6x6_24_4_1_3_path },
		new solutionPath { tID=24, tY = 4, tX = 2, tA = 0, solution = solution6x6_24_4_2_0_path },
		new solutionPath { tID=24, tY = 4, tX = 2, tA = 2, solution = solution6x6_24_4_2_2_path },
		new solutionPath { tID=24, tY = 4, tX = 3, tA = 1, solution = solution6x6_24_4_3_1_path },
		new solutionPath { tID=24, tY = 4, tX = 3, tA = 3, solution = solution6x6_24_4_3_3_path },
		new solutionPath { tID=24, tY = 4, tX = 4, tA = 0, solution = solution6x6_24_4_4_0_path },
		new solutionPath { tID=24, tY = 4, tX = 4, tA = 2, solution = solution6x6_24_4_4_2_path },
		new solutionPath { tID=24, tY = 4, tX = 5, tA = 1, solution = solution6x6_24_4_5_1_path },
		new solutionPath { tID=24, tY = 4, tX = 5, tA = 3, solution = solution6x6_24_4_5_3_path },
		new solutionPath { tID=24, tY = 5, tX = 0, tA = 1, solution = solution6x6_24_5_0_1_path },
		new solutionPath { tID=24, tY = 5, tX = 0, tA = 3, solution = solution6x6_24_5_0_3_path },
		new solutionPath { tID=24, tY = 5, tX = 1, tA = 0, solution = solution6x6_24_5_1_0_path },
		new solutionPath { tID=24, tY = 5, tX = 1, tA = 2, solution = solution6x6_24_5_1_2_path },
		new solutionPath { tID=24, tY = 5, tX = 2, tA = 1, solution = solution6x6_24_5_2_1_path },
		new solutionPath { tID=24, tY = 5, tX = 2, tA = 3, solution = solution6x6_24_5_2_3_path },
		new solutionPath { tID=24, tY = 5, tX = 3, tA = 0, solution = solution6x6_24_5_3_0_path },
		new solutionPath { tID=24, tY = 5, tX = 3, tA = 2, solution = solution6x6_24_5_3_2_path },
		new solutionPath { tID=24, tY = 5, tX = 4, tA = 1, solution = solution6x6_24_5_4_1_path },
		new solutionPath { tID=24, tY = 5, tX = 4, tA = 3, solution = solution6x6_24_5_4_3_path },
		new solutionPath { tID=24, tY = 5, tX = 5, tA = 0, solution = solution6x6_24_5_5_0_path },
		new solutionPath { tID=24, tY = 5, tX = 5, tA = 2, solution = solution6x6_24_5_5_2_path },
		new solutionPath { tID=25, tY = 4, tX = 1, tA = 2, solution = solution6x6_25_4_1_2_path },
		new solutionPath { tID=25, tY = 4, tX = 2, tA = 1, solution = solution6x6_25_4_2_1_path },
		new solutionPath { tID=25, tY = 4, tX = 2, tA = 3, solution = solution6x6_25_4_2_3_path },
		new solutionPath { tID=25, tY = 4, tX = 3, tA = 0, solution = solution6x6_25_4_3_0_path },
		new solutionPath { tID=25, tY = 4, tX = 3, tA = 2, solution = solution6x6_25_4_3_2_path },
		new solutionPath { tID=25, tY = 4, tX = 4, tA = 1, solution = solution6x6_25_4_4_1_path },
		new solutionPath { tID=25, tY = 4, tX = 4, tA = 3, solution = solution6x6_25_4_4_3_path },
		new solutionPath { tID=25, tY = 4, tX = 5, tA = 0, solution = solution6x6_25_4_5_0_path },
		new solutionPath { tID=25, tY = 4, tX = 5, tA = 2, solution = solution6x6_25_4_5_2_path },
		new solutionPath { tID=25, tY = 5, tX = 0, tA = 0, solution = solution6x6_25_5_0_0_path },
		new solutionPath { tID=25, tY = 5, tX = 0, tA = 2, solution = solution6x6_25_5_0_2_path },
		new solutionPath { tID=25, tY = 5, tX = 1, tA = 1, solution = solution6x6_25_5_1_1_path },
		new solutionPath { tID=25, tY = 5, tX = 1, tA = 3, solution = solution6x6_25_5_1_3_path },
		new solutionPath { tID=25, tY = 5, tX = 2, tA = 0, solution = solution6x6_25_5_2_0_path },
		new solutionPath { tID=25, tY = 5, tX = 2, tA = 2, solution = solution6x6_25_5_2_2_path },
		new solutionPath { tID=25, tY = 5, tX = 3, tA = 1, solution = solution6x6_25_5_3_1_path },
		new solutionPath { tID=25, tY = 5, tX = 3, tA = 3, solution = solution6x6_25_5_3_3_path },
		new solutionPath { tID=25, tY = 5, tX = 4, tA = 0, solution = solution6x6_25_5_4_0_path },
		new solutionPath { tID=25, tY = 5, tX = 4, tA = 2, solution = solution6x6_25_5_4_2_path },
		new solutionPath { tID=25, tY = 5, tX = 5, tA = 1, solution = solution6x6_25_5_5_1_path },
		new solutionPath { tID=25, tY = 5, tX = 5, tA = 3, solution = solution6x6_25_5_5_3_path },
		new solutionPath { tID=26, tY = 4, tX = 2, tA = 2, solution = solution6x6_26_4_2_2_path },
		new solutionPath { tID=26, tY = 4, tX = 3, tA = 1, solution = solution6x6_26_4_3_1_path },
		new solutionPath { tID=26, tY = 4, tX = 3, tA = 3, solution = solution6x6_26_4_3_3_path },
		new solutionPath { tID=26, tY = 4, tX = 4, tA = 0, solution = solution6x6_26_4_4_0_path },
		new solutionPath { tID=26, tY = 4, tX = 4, tA = 2, solution = solution6x6_26_4_4_2_path },
		new solutionPath { tID=26, tY = 4, tX = 5, tA = 1, solution = solution6x6_26_4_5_1_path },
		new solutionPath { tID=26, tY = 4, tX = 5, tA = 3, solution = solution6x6_26_4_5_3_path },
		new solutionPath { tID=26, tY = 5, tX = 0, tA = 1, solution = solution6x6_26_5_0_1_path },
		new solutionPath { tID=26, tY = 5, tX = 0, tA = 3, solution = solution6x6_26_5_0_3_path },
		new solutionPath { tID=26, tY = 5, tX = 1, tA = 0, solution = solution6x6_26_5_1_0_path },
		new solutionPath { tID=26, tY = 5, tX = 1, tA = 2, solution = solution6x6_26_5_1_2_path },
		new solutionPath { tID=26, tY = 5, tX = 2, tA = 1, solution = solution6x6_26_5_2_1_path },
		new solutionPath { tID=26, tY = 5, tX = 2, tA = 3, solution = solution6x6_26_5_2_3_path },
		new solutionPath { tID=26, tY = 5, tX = 3, tA = 0, solution = solution6x6_26_5_3_0_path },
		new solutionPath { tID=26, tY = 5, tX = 3, tA = 2, solution = solution6x6_26_5_3_2_path },
		new solutionPath { tID=26, tY = 5, tX = 4, tA = 1, solution = solution6x6_26_5_4_1_path },
		new solutionPath { tID=26, tY = 5, tX = 4, tA = 3, solution = solution6x6_26_5_4_3_path },
		new solutionPath { tID=26, tY = 5, tX = 5, tA = 0, solution = solution6x6_26_5_5_0_path },
		new solutionPath { tID=26, tY = 5, tX = 5, tA = 2, solution = solution6x6_26_5_5_2_path },
		new solutionPath { tID=27, tY = 4, tX = 3, tA = 2, solution = solution6x6_27_4_3_2_path },
		new solutionPath { tID=27, tY = 4, tX = 4, tA = 1, solution = solution6x6_27_4_4_1_path },
		new solutionPath { tID=27, tY = 4, tX = 4, tA = 3, solution = solution6x6_27_4_4_3_path },
		new solutionPath { tID=27, tY = 4, tX = 5, tA = 0, solution = solution6x6_27_4_5_0_path },
		new solutionPath { tID=27, tY = 4, tX = 5, tA = 2, solution = solution6x6_27_4_5_2_path },
		new solutionPath { tID=27, tY = 5, tX = 0, tA = 0, solution = solution6x6_27_5_0_0_path },
		new solutionPath { tID=27, tY = 5, tX = 0, tA = 2, solution = solution6x6_27_5_0_2_path },
		new solutionPath { tID=27, tY = 5, tX = 1, tA = 1, solution = solution6x6_27_5_1_1_path },
		new solutionPath { tID=27, tY = 5, tX = 1, tA = 3, solution = solution6x6_27_5_1_3_path },
		new solutionPath { tID=27, tY = 5, tX = 2, tA = 0, solution = solution6x6_27_5_2_0_path },
		new solutionPath { tID=27, tY = 5, tX = 2, tA = 2, solution = solution6x6_27_5_2_2_path },
		new solutionPath { tID=27, tY = 5, tX = 3, tA = 1, solution = solution6x6_27_5_3_1_path },
		new solutionPath { tID=27, tY = 5, tX = 3, tA = 3, solution = solution6x6_27_5_3_3_path },
		new solutionPath { tID=27, tY = 5, tX = 4, tA = 0, solution = solution6x6_27_5_4_0_path },
		new solutionPath { tID=27, tY = 5, tX = 4, tA = 2, solution = solution6x6_27_5_4_2_path },
		new solutionPath { tID=27, tY = 5, tX = 5, tA = 1, solution = solution6x6_27_5_5_1_path },
		new solutionPath { tID=27, tY = 5, tX = 5, tA = 3, solution = solution6x6_27_5_5_3_path },
		new solutionPath { tID=28, tY = 4, tX = 4, tA = 2, solution = solution6x6_28_4_4_2_path },
		new solutionPath { tID=28, tY = 4, tX = 5, tA = 1, solution = solution6x6_28_4_5_1_path },
		new solutionPath { tID=28, tY = 4, tX = 5, tA = 3, solution = solution6x6_28_4_5_3_path },
		new solutionPath { tID=28, tY = 5, tX = 0, tA = 1, solution = solution6x6_28_5_0_1_path },
		new solutionPath { tID=28, tY = 5, tX = 0, tA = 3, solution = solution6x6_28_5_0_3_path },
		new solutionPath { tID=28, tY = 5, tX = 1, tA = 0, solution = solution6x6_28_5_1_0_path },
		new solutionPath { tID=28, tY = 5, tX = 1, tA = 2, solution = solution6x6_28_5_1_2_path },
		new solutionPath { tID=28, tY = 5, tX = 2, tA = 1, solution = solution6x6_28_5_2_1_path },
		new solutionPath { tID=28, tY = 5, tX = 2, tA = 3, solution = solution6x6_28_5_2_3_path },
		new solutionPath { tID=28, tY = 5, tX = 3, tA = 0, solution = solution6x6_28_5_3_0_path },
		new solutionPath { tID=28, tY = 5, tX = 3, tA = 2, solution = solution6x6_28_5_3_2_path },
		new solutionPath { tID=28, tY = 5, tX = 4, tA = 1, solution = solution6x6_28_5_4_1_path },
		new solutionPath { tID=28, tY = 5, tX = 4, tA = 3, solution = solution6x6_28_5_4_3_path },
		new solutionPath { tID=28, tY = 5, tX = 5, tA = 0, solution = solution6x6_28_5_5_0_path },
		new solutionPath { tID=28, tY = 5, tX = 5, tA = 2, solution = solution6x6_28_5_5_2_path },
		new solutionPath { tID=29, tY = 4, tX = 5, tA = 2, solution = solution6x6_29_4_5_2_path },
		new solutionPath { tID=29, tY = 5, tX = 0, tA = 0, solution = solution6x6_29_5_0_0_path },
		new solutionPath { tID=29, tY = 5, tX = 0, tA = 2, solution = solution6x6_29_5_0_2_path },
		new solutionPath { tID=29, tY = 5, tX = 1, tA = 1, solution = solution6x6_29_5_1_1_path },
		new solutionPath { tID=29, tY = 5, tX = 1, tA = 3, solution = solution6x6_29_5_1_3_path },
		new solutionPath { tID=29, tY = 5, tX = 2, tA = 0, solution = solution6x6_29_5_2_0_path },
		new solutionPath { tID=29, tY = 5, tX = 2, tA = 2, solution = solution6x6_29_5_2_2_path },
		new solutionPath { tID=29, tY = 5, tX = 3, tA = 1, solution = solution6x6_29_5_3_1_path },
		new solutionPath { tID=29, tY = 5, tX = 3, tA = 3, solution = solution6x6_29_5_3_3_path },
		new solutionPath { tID=29, tY = 5, tX = 4, tA = 0, solution = solution6x6_29_5_4_0_path },
		new solutionPath { tID=29, tY = 5, tX = 4, tA = 2, solution = solution6x6_29_5_4_2_path },
		new solutionPath { tID=29, tY = 5, tX = 5, tA = 1, solution = solution6x6_29_5_5_1_path },
		new solutionPath { tID=29, tY = 5, tX = 5, tA = 3, solution = solution6x6_29_5_5_3_path },
		new solutionPath { tID=30, tY = 5, tX = 0, tA = 2, solution = solution6x6_30_5_0_2_path },
		new solutionPath { tID=30, tY = 5, tX = 1, tA = 1, solution = solution6x6_30_5_1_1_path },
		new solutionPath { tID=30, tY = 5, tX = 1, tA = 3, solution = solution6x6_30_5_1_3_path },
		new solutionPath { tID=30, tY = 5, tX = 2, tA = 0, solution = solution6x6_30_5_2_0_path },
		new solutionPath { tID=30, tY = 5, tX = 2, tA = 2, solution = solution6x6_30_5_2_2_path },
		new solutionPath { tID=30, tY = 5, tX = 3, tA = 1, solution = solution6x6_30_5_3_1_path },
		new solutionPath { tID=30, tY = 5, tX = 3, tA = 3, solution = solution6x6_30_5_3_3_path },
		new solutionPath { tID=30, tY = 5, tX = 4, tA = 0, solution = solution6x6_30_5_4_0_path },
		new solutionPath { tID=30, tY = 5, tX = 4, tA = 2, solution = solution6x6_30_5_4_2_path },
		new solutionPath { tID=30, tY = 5, tX = 5, tA = 1, solution = solution6x6_30_5_5_1_path },
		new solutionPath { tID=30, tY = 5, tX = 5, tA = 3, solution = solution6x6_30_5_5_3_path },
		new solutionPath { tID=31, tY = 5, tX = 1, tA = 2, solution = solution6x6_31_5_1_2_path },
		new solutionPath { tID=31, tY = 5, tX = 2, tA = 1, solution = solution6x6_31_5_2_1_path },
		new solutionPath { tID=31, tY = 5, tX = 2, tA = 3, solution = solution6x6_31_5_2_3_path },
		new solutionPath { tID=31, tY = 5, tX = 3, tA = 0, solution = solution6x6_31_5_3_0_path },
		new solutionPath { tID=31, tY = 5, tX = 3, tA = 2, solution = solution6x6_31_5_3_2_path },
		new solutionPath { tID=31, tY = 5, tX = 4, tA = 1, solution = solution6x6_31_5_4_1_path },
		new solutionPath { tID=31, tY = 5, tX = 4, tA = 3, solution = solution6x6_31_5_4_3_path },
		new solutionPath { tID=31, tY = 5, tX = 5, tA = 0, solution = solution6x6_31_5_5_0_path },
		new solutionPath { tID=31, tY = 5, tX = 5, tA = 2, solution = solution6x6_31_5_5_2_path },
		new solutionPath { tID=32, tY = 5, tX = 2, tA = 2, solution = solution6x6_32_5_2_2_path },
		new solutionPath { tID=32, tY = 5, tX = 3, tA = 1, solution = solution6x6_32_5_3_1_path },
		new solutionPath { tID=32, tY = 5, tX = 3, tA = 3, solution = solution6x6_32_5_3_3_path },
		new solutionPath { tID=32, tY = 5, tX = 4, tA = 0, solution = solution6x6_32_5_4_0_path },
		new solutionPath { tID=32, tY = 5, tX = 4, tA = 2, solution = solution6x6_32_5_4_2_path },
		new solutionPath { tID=32, tY = 5, tX = 5, tA = 1, solution = solution6x6_32_5_5_1_path },
		new solutionPath { tID=32, tY = 5, tX = 5, tA = 3, solution = solution6x6_32_5_5_3_path },
		new solutionPath { tID=33, tY = 5, tX = 3, tA = 2, solution = solution6x6_33_5_3_2_path },
		new solutionPath { tID=33, tY = 5, tX = 4, tA = 1, solution = solution6x6_33_5_4_1_path },
		new solutionPath { tID=33, tY = 5, tX = 4, tA = 3, solution = solution6x6_33_5_4_3_path },
		new solutionPath { tID=33, tY = 5, tX = 5, tA = 0, solution = solution6x6_33_5_5_0_path },
		new solutionPath { tID=33, tY = 5, tX = 5, tA = 2, solution = solution6x6_33_5_5_2_path },
		new solutionPath { tID=34, tY = 5, tX = 4, tA = 2, solution = solution6x6_34_5_4_2_path },
		new solutionPath { tID=34, tY = 5, tX = 5, tA = 1, solution = solution6x6_34_5_5_1_path },
		new solutionPath { tID=34, tY = 5, tX = 5, tA = 3, solution = solution6x6_34_5_5_3_path }
	};

}
