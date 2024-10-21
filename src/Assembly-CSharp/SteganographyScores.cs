using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000365 RID: 869
internal class SteganographyScores
{
	// Token: 0x06001FDE RID: 8158 RVA: 0x00007CFD File Offset: 0x00005EFD
	private static bool BitFromByte(byte b, int bitNumber)
	{
		return ((int)b & (1 << bitNumber)) != 0;
	}

	// Token: 0x06001FDF RID: 8159 RVA: 0x000D6994 File Offset: 0x000D4B94
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

	// Token: 0x06001FE0 RID: 8160 RVA: 0x0002BB28 File Offset: 0x00029D28
	private static byte GetByte(byte[] array, int accumBits)
	{
		int num = accumBits / 8;
		if (num > array.Length - 1)
		{
			return 0;
		}
		return array[num];
	}

	// Token: 0x06001FE1 RID: 8161 RVA: 0x000D69FC File Offset: 0x000D4BFC
	public static void EmbedBytes(PayloadData dataPayload, ref Color32[] pixels)
	{
		byte[] array = Helper.EncodeReedSoloman(dataPayload.BuildPayload());
		new Color32[pixels.Length];
		int num = array.Length;
		int i = 0;
		int num2 = 0;
		while (i < pixels.Length)
		{
			Color32 color = pixels[i];
			bool flag = SteganographyScores.BitFromByte(SteganographyScores.GetByte(array, num2), num2++ % 8);
			bool flag2 = SteganographyScores.BitFromByte(SteganographyScores.GetByte(array, num2), num2++ % 8);
			bool flag3 = SteganographyScores.BitFromByte(SteganographyScores.GetByte(array, num2), num2++ % 8);
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

	// Token: 0x06001FE2 RID: 8162 RVA: 0x000D6B08 File Offset: 0x000D4D08
	public static PayloadData ExtractBytes(Color32[] pixels)
	{
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
		byte[] array = Helper.DecodeReedSoloman(SteganographyScores.PackBitsInByteArray(list.ToArray()));
		PayloadData payloadData = new PayloadData();
		payloadData.ReadPayload(array);
		return payloadData;
	}
}
