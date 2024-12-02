﻿using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public readonly struct \u02B2\u02BA\u02BA\u02B8\u02B5\u02BC\u02BA\u02BE\u02BB\u02BA\u02B5
{
	[CompilerGenerated]
	internal static int \u02C1\u02B4\u02B7\u02B2\u02B4\u02BA\u02C0\u02B6\u02C0\u02B4\u02C1(ref \u02B2\u02BA\u02BA\u02B8\u02B5\u02BC\u02BA\u02BE\u02BB\u02BA\u02B5.\u02B6\u02B6\u02C1\u02B6\u02B7\u02B6\u02B4\u02B4\u02BB\u02C0\u02C0 A_0)
	{
		int num = -1;
		string text = __FIXME_clon_util.\u02BB\u02BD\u02B6\u02B4\u02BE\u02C1\u02B4\u02BD\u02B9\u02C0\u02BC(new string[]
		{
			Path.Combine(__FIXME_clon_util.\u02B4\u02B6\u02BE\u02B5\u02BB\u02BA\u02BB\u02C0\u02C1\u02C1\u02B7(), A_0.path),
			Path.Combine(__FIXME_clon_util.\u02B4\u02B6\u02BE\u02B5\u02BB\u02BA\u02BB\u02C0\u02C1\u02C1\u02B7(), "FreestyleDrums", A_0.path)
		}, BassAudioManager.\u02BE\u02BA\u02BA\u02C1\u02BE\u02BC\u02BD\u02B6\u02B6\u02B6\u02B7, 3);
		if (text != null)
		{
			num = \u02B7\u02B9\u02B9\u02BB\u02B3\u02B6\u02B6\u02B6\u02B6\u02C1\u02BF.\u02B6\u02B2\u02B4\u02BD\u02C1\u02BE\u02BF\u02B5\u02B2\u02BC\u02B6(text, 0L, 0, A_0.maxAmountOfPlays, \u02B5\u02B2\u02BA\u02BC\u02BA\u02B5\u02B5\u02B9\u02B4\u02B3\u02BA.Default);
		}
		else
		{
			Debug.LogError(string.Format("Failed to load Sound effect {0} {1}", A_0.path, \u02B7\u02B9\u02B9\u02BB\u02B3\u02B6\u02B6\u02B6\u02B6\u02C1\u02BF.\u02B2\u02BC\u02B7\u02BC\u02B6\u02B9\u02BA\u02B9\u02BE\u02B8\u02BD));
		}
		\u02B7\u02B9\u02B9\u02BB\u02B3\u02B6\u02B6\u02B6\u02B6\u02C1\u02BF.\u02B5\u02B4\u02C0\u02C1\u02B9\u02BC\u02BD\u02BD\u02B5\u02BB\u02BB(num, \u02BF\u02BD\u02B6\u02B4\u02BA\u02B4\u02C1\u02B5\u02B7\u02B3\u02B7.NoBuffer, 1f);
		return num;
	}

	public \u02B2\u02BA\u02BA\u02B8\u02B5\u02BC\u02BA\u02BE\u02BB\u02BA\u02B5(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC, float \u02B6\u02BB\u02BB\u02B2\u02BF\u02B6\u02B6\u02B2\u02B4\u02C1\u02C1, int \u02B8\u02B9\u02C1\u02B6\u02C1\u02B5\u02B5\u02B7\u02BE\u02B8\u02BE)
	{
		\u02B2\u02BA\u02BA\u02B8\u02B5\u02BC\u02BA\u02BE\u02BB\u02BA\u02B5.\u02B6\u02B6\u02C1\u02B6\u02B7\u02B6\u02B4\u02B4\u02BB\u02C0\u02C0 u02B6_u02B6_u02C1_u02B6_u02B7_u02B6_u02B4_u02B4_u02BB_u02C0_u02C;
		u02B6_u02B6_u02C1_u02B6_u02B7_u02B6_u02B4_u02B4_u02BB_u02C0_u02C.path = \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC;
		u02B6_u02B6_u02C1_u02B6_u02B7_u02B6_u02B4_u02B4_u02BB_u02C0_u02C.maxAmountOfPlays = \u02B8\u02B9\u02C1\u02B6\u02C1\u02B5\u02B5\u02B7\u02BE\u02B8\u02BE;
		this.\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC = u02B6_u02B6_u02C1_u02B6_u02B7_u02B6_u02B4_u02B4_u02BB_u02C0_u02C.path;
		this.\u02B6\u02BB\u02BB\u02B2\u02BF\u02B6\u02B6\u02B2\u02B4\u02C1\u02C1 = \u02B6\u02BB\u02BB\u02B2\u02BF\u02B6\u02B6\u02B2\u02B4\u02C1\u02C1;
		this.\u02B8\u02B9\u02C1\u02B6\u02C1\u02B5\u02B5\u02B7\u02BE\u02B8\u02BE = u02B6_u02B6_u02C1_u02B6_u02B7_u02B6_u02B4_u02B4_u02BB_u02C0_u02C.maxAmountOfPlays;
		this.\u02BE\u02BE\u02BB\u02B3\u02B4\u02B2\u02BD\u02B4\u02B8\u02B6\u02B9 = \u02B2\u02BA\u02BA\u02B8\u02B5\u02BC\u02BA\u02BE\u02BB\u02BA\u02B5.\u02C1\u02B4\u02B7\u02B2\u02B4\u02BA\u02C0\u02B6\u02C0\u02B4\u02C1(ref u02B6_u02B6_u02C1_u02B6_u02B7_u02B6_u02B4_u02B4_u02BB_u02C0_u02C);
	}

	public readonly string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC;

	public readonly float \u02B6\u02BB\u02BB\u02B2\u02BF\u02B6\u02B6\u02B2\u02B4\u02C1\u02C1;

	public readonly int \u02BE\u02BE\u02BB\u02B3\u02B4\u02B2\u02BD\u02B4\u02B8\u02B6\u02B9;

	public readonly int \u02B8\u02B9\u02C1\u02B6\u02C1\u02B5\u02B5\u02B7\u02BE\u02B8\u02BE;

	[CompilerGenerated]
	[StructLayout(3)]
	private struct \u02B6\u02B6\u02C1\u02B6\u02B7\u02B6\u02B4\u02B4\u02BB\u02C0\u02C0
	{
		public string path;

		public int maxAmountOfPlays;
	}
}
