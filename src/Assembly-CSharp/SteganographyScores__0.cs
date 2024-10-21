using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000378 RID: 888
internal class SteganographyScores__0
{
	// Token: 0x06002042 RID: 8258 RVA: 0x00007CFD File Offset: 0x00005EFD
	private static bool BitFromByte(byte b, int bitNumber)
	{
		return ((int)b & (1 << bitNumber)) != 0;
	}

	// Token: 0x06002043 RID: 8259 RVA: 0x000D6994 File Offset: 0x000D4B94
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

	// Token: 0x06002044 RID: 8260 RVA: 0x0002BB28 File Offset: 0x00029D28
	private static byte GetByte(byte[] array, int accumBits)
	{
		int num = accumBits / 8;
		if (num > array.Length - 1)
		{
			return 0;
		}
		return array[num];
	}

	// Token: 0x06002045 RID: 8261 RVA: 0x000D83C4 File Offset: 0x000D65C4
	public static void EmbedBytes(PayloadData__0 dataPayload, ref Color32[] pixels)
	{
		byte[] array = Helper.EncodeReedSoloman(dataPayload.BuildPayload());
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

	// Token: 0x06002046 RID: 8262 RVA: 0x000D84D0 File Offset: 0x000D66D0
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
		byte[] array = Helper.DecodeReedSoloman(SteganographyScores__0.PackBitsInByteArray(list.ToArray()));
		PayloadData__0 payloadData__ = new PayloadData__0();
		payloadData__.ReadPayload(array);
		return payloadData__;
	}
}
