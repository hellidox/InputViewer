﻿using System;
using UnityEngine;

internal class \u02B2\u02B6\u02B3\u02BA\u02B2\u02B8\u02B6\u02B8\u02BF\u02B4\u02BF
{
	private static bool \u02BC\u02C0\u02B9\u02BE\u02B6\u02C0\u02BE\u02B5\u02B9\u02B9\u02BE(byte \u02B7\u02BF\u02B9\u02BB\u02BF\u02C0\u02B7\u02B2\u02B7\u02B7\u02B3, int \u02BF\u02B8\u02B7\u02B9\u02C0\u02BF\u02B6\u02BB\u02C1\u02B8\u02BD)
	{
		return ((int)\u02B7\u02BF\u02B9\u02BB\u02BF\u02C0\u02B7\u02B2\u02B7\u02B7\u02B3 & (1 << \u02BF\u02B8\u02B7\u02B9\u02C0\u02BF\u02B6\u02BB\u02C1\u02B8\u02BD)) != 0;
	}

	private static byte \u02BA\u02B7\u02C1\u02B9\u02B4\u02BC\u02BE\u02BD\u02B4\u02B4\u02C0(byte[] \u02BC\u02BD\u02B7\u02B7\u02B5\u02BF\u02BE\u02B6\u02BA\u02BB\u02B6, int \u02B9\u02B4\u02BE\u02B2\u02B7\u02B4\u02BF\u02BB\u02C1\u02B3\u02BF)
	{
		int num = \u02B9\u02B4\u02BE\u02B2\u02B7\u02B4\u02BF\u02BB\u02C1\u02B3\u02BF / 8;
		if (num > \u02BC\u02BD\u02B7\u02B7\u02B5\u02BF\u02BE\u02B6\u02BA\u02BB\u02B6.Length - 1)
		{
			return 0;
		}
		return \u02BC\u02BD\u02B7\u02B7\u02B5\u02BF\u02BE\u02B6\u02BA\u02BB\u02B6[num];
	}

	public static void \u02B6\u02BC\u02C0\u02BD\u02BE\u02C1\u02B3\u02B8\u02BF\u02B8\u02BD(\u02B2\u02BB\u02B3\u02C0\u02B8\u02B5\u02B9\u02B3\u02B8\u02B4\u02B8 \u02C0\u02C1\u02C1\u02B3\u02BE\u02B2\u02BF\u02B6\u02BB\u02C0\u02BE, ref Color32[] \u02B6\u02B7\u02B9\u02BC\u02B8\u02B6\u02B3\u02BD\u02C0\u02C0\u02B7)
	{
		byte[] array = Helper.\u02BF\u02BA\u02BD\u02BE\u02B2\u02B2\u02B2\u02B7\u02B5\u02B7\u02BE(\u02C0\u02C1\u02C1\u02B3\u02BE\u02B2\u02BF\u02B6\u02BB\u02C0\u02BE.\u02BC\u02B3\u02B5\u02B9\u02B8\u02BC\u02B7\u02B9\u02B3\u02B8\u02BF());
		new Color32[\u02B6\u02B7\u02B9\u02BC\u02B8\u02B6\u02B3\u02BD\u02C0\u02C0\u02B7.Length];
		int num = array.Length;
		int i = 0;
		int num2 = 0;
		while (i < \u02B6\u02B7\u02B9\u02BC\u02B8\u02B6\u02B3\u02BD\u02C0\u02C0\u02B7.Length)
		{
			Color32 color = \u02B6\u02B7\u02B9\u02BC\u02B8\u02B6\u02B3\u02BD\u02C0\u02C0\u02B7[i];
			bool flag = \u02B2\u02B6\u02B3\u02BA\u02B2\u02B8\u02B6\u02B8\u02BF\u02B4\u02BF.\u02BC\u02C0\u02B9\u02BE\u02B6\u02C0\u02BE\u02B5\u02B9\u02B9\u02BE(\u02B2\u02B6\u02B3\u02BA\u02B2\u02B8\u02B6\u02B8\u02BF\u02B4\u02BF.\u02BA\u02B7\u02C1\u02B9\u02B4\u02BC\u02BE\u02BD\u02B4\u02B4\u02C0(array, num2), num2++ % 8);
			bool flag2 = \u02B2\u02B6\u02B3\u02BA\u02B2\u02B8\u02B6\u02B8\u02BF\u02B4\u02BF.\u02BC\u02C0\u02B9\u02BE\u02B6\u02C0\u02BE\u02B5\u02B9\u02B9\u02BE(\u02B2\u02B6\u02B3\u02BA\u02B2\u02B8\u02B6\u02B8\u02BF\u02B4\u02BF.\u02BA\u02B7\u02C1\u02B9\u02B4\u02BC\u02BE\u02BD\u02B4\u02B4\u02C0(array, num2), num2++ % 8);
			bool flag3 = \u02B2\u02B6\u02B3\u02BA\u02B2\u02B8\u02B6\u02B8\u02BF\u02B4\u02BF.\u02BC\u02C0\u02B9\u02BE\u02B6\u02C0\u02BE\u02B5\u02B9\u02B9\u02BE(\u02B2\u02B6\u02B3\u02BA\u02B2\u02B8\u02B6\u02B8\u02BF\u02B4\u02BF.\u02BA\u02B7\u02C1\u02B9\u02B4\u02BC\u02BE\u02BD\u02B4\u02B4\u02C0(array, num2), num2++ % 8);
			color.r = (byte)((int)color.r & -2);
			color.g = (byte)((int)color.g & -2);
			color.b = (byte)((int)color.b & -2);
			color.r |= (flag ? 1 : 0);
			color.g |= (flag2 ? 1 : 0);
			color.b |= (flag3 ? 1 : 0);
			color.a = byte.MaxValue;
			\u02B6\u02B7\u02B9\u02BC\u02B8\u02B6\u02B3\u02BD\u02C0\u02C0\u02B7[i] = color;
			i++;
		}
	}
}
