﻿using System;
using System.Collections.Generic;
using UnityEngine;

internal class SteganographyScores__0
{
	private static bool BitFromByte(byte b, int bitNumber)
	{
		return ((int)b & (1 << bitNumber)) != 0;
	}

	private static byte[] PackBitsInByteArray(bool[] bits)
	{
		List<byte> list = new List<byte>();
		byte b = 0;
		for (int i = 0; i < bits.Length; i++)
		{
			int num = i % 8;
			if (bits[i])
			{
				b |= (byte)(1 << num);
			}
			else
			{
				b &= (byte)(~(byte)(1 << num));
			}
			if (num == 7)
			{
				list.Add(b);
				b = 0;
				if (list.Count > 550)
				{
					break;
				}
			}
		}
		return list.ToArray();
	}

	private static byte GetByte(byte[] array, int accumBits)
	{
		int num = accumBits / 8;
		if (num > array.Length - 1)
		{
			return 0;
		}
		return array[num];
	}

	public static void EmbedBytes(PayloadData__0 dataPayload, ref Color32[] pixels)
	{
		byte[] array = Helper2.EncodeReedSoloman(dataPayload.BuildPayload());
		new Color32[pixels.Length];
		int num = array.Length;
		int i = 0;
		int num2 = 0;
		while (i < pixels.Length)
		{
			Color32 color = pixels[i];
			bool flag = SteganographyScores__0.BitFromByte(SteganographyScores__0.GetByte(array, num2), num2++ % 8);
			bool flag2 = SteganographyScores__0.BitFromByte(SteganographyScores__0.GetByte(array, num2), num2++ % 8);
			bool flag3 = SteganographyScores__0.BitFromByte(SteganographyScores__0.GetByte(array, num2), num2++ % 8);
			color.r = (byte)((int)color.r & -2);
			color.g = (byte)((int)color.g & -2);
			color.b = (byte)((int)color.b & -2);
			color.r |= ((flag > false) ? 1 : 0);
			color.g |= ((flag2 > false) ? 1 : 0);
			color.b |= ((flag3 > false) ? 1 : 0);
			color.a = byte.MaxValue;
			pixels[i] = color;
			i++;
		}
	}

	public static PayloadData__0 ExtractBytes(Color32[] pixels)
	{
		if (pixels.Length < 3)
		{
			throw new Exception("What are you even trying to do Matt...");
		}
		List<bool> list = new List<bool>();
		for (int i = 0; i < pixels.Length; i++)
		{
			list.AddRange(new bool[]
			{
				(pixels[i].r & 1) == 1,
				(pixels[i].g & 1) == 1,
				(pixels[i].b & 1) == 1
			});
		}
		byte[] array = Helper2.DecodeReedSoloman(SteganographyScores__0.PackBitsInByteArray(list.ToArray()));
		PayloadData__0 payloadData__ = new PayloadData__0();
		payloadData__.ReadPayload(array);
		return payloadData__;
	}
}
