using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using StrikeCore;
using UnityEngine;

// Token: 0x02000199 RID: 409
public static class \u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD
{
	// Token: 0x0600125F RID: 4703 RVA: 0x00096A04 File Offset: 0x00094C04
	private static ushort \u02C1\u02BE\u02BF\u02B2\u02BD\u02B5\u02BD\u02BB\u02B8\u02C0\u02B7(Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		switch (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
		{
		case Instrument.Guitar:
		case Instrument.Bass:
		case Instrument.Rhythm:
		case Instrument.GuitarCoop:
		case Instrument.Keys:
			return 64;
		case Instrument.GHLGuitar:
		case Instrument.GHLBass:
		case Instrument.GHLRhythm:
		case Instrument.GHLGuitarCoop:
			return 64;
		case Instrument.Drums:
		case Instrument.ProDrums:
			return 384;
		}
		return 0;
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x00096A58 File Offset: 0x00094C58
	public static void \u02BA\u02C1\u02B9\u02B5\u02B5\u02B4\u02BE\u02BD\u02B5\u02BC\u02BC(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		if (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.Drums || \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.ProDrums)
		{
			return;
		}
		foreach (Note note in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			if (note.\u02C0\u02BF\u02B6\u02B4\u02BC\u02BD\u02BD\u02B6\u02C0\u02B3\u02BF)
			{
				note.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Tap;
			}
		}
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x00096AB8 File Offset: 0x00094CB8
	public static void \u02BB\u02B8\u02B8\u02B7\u02B5\u02BE\u02BE\u02BB\u02B5\u02B5\u02B3(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		if (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.Drums || \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.ProDrums)
		{
			return;
		}
		foreach (Note note in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			note.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Strum;
		}
	}

	// Token: 0x06001262 RID: 4706 RVA: 0x00096B10 File Offset: 0x00094D10
	public static void \u02C0\u02B6\u02B3\u02B5\u02BE\u02BF\u02B9\u02BF\u02B4\u02BB\u02B3(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		if (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.Drums || \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.ProDrums)
		{
			return;
		}
		foreach (Note note in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			note.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Hopo;
		}
	}

	// Token: 0x06001263 RID: 4707 RVA: 0x00096B68 File Offset: 0x00094D68
	public static void \u02B8\u02B9\u02B9\u02B7\u02BD\u02BE\u02BA\u02BE\u02BC\u02BB\u02B6(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		if (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.Drums || \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.ProDrums)
		{
			return;
		}
		foreach (Note note in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			note.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Tap;
		}
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x00096BC0 File Offset: 0x00094DC0
	public static void \u02BF\u02BE\u02B2\u02BD\u02BB\u02B9\u02BA\u02B6\u02C0\u02B9\u02BD(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			if ((\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & 112) != 0)
			{
				Note note = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i];
				note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = (ushort)(note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF >> 3);
			}
		}
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x00096C04 File Offset: 0x00094E04
	public static void \u02B7\u02BD\u02B6\u02BD\u02C1\u02B8\u02BB\u02B5\u02B2\u02B4\u02B6(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF u02B4_u02B4_u02B6_u02B9_u02BC_u02B3_u02BD_u02B5_u02B4_u02B3_u02BF = ~(Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUMS_GHOST | Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUMS_ACCENT);
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 &= u02B4_u02B4_u02B6_u02B9_u02BC_u02B3_u02BD_u02B5_u02B4_u02B3_u02BF;
		}
	}

	// Token: 0x06001266 RID: 4710 RVA: 0x00096C3C File Offset: 0x00094E3C
	public static void \u02B8\u02BC\u02B4\u02B8\u02B7\u02BA\u02B2\u02B5\u02BB\u02B9\u02BB(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			ushort num = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
			if (num != 2)
			{
				if (num == 32)
				{
					if ((\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3 & 8) != 0 || (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3 & 64) != 0)
					{
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 16;
					}
					else
					{
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 64;
					}
				}
			}
			else if ((\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3 & 4) != 0 || (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3 & 32) != 0)
			{
				\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 1;
			}
			else
			{
				\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 4;
			}
		}
	}

	// Token: 0x06001267 RID: 4711 RVA: 0x00096CF8 File Offset: 0x00094EF8
	public static void \u02BE\u02B8\u02C1\u02B3\u02B5\u02B8\u02C1\u02BE\u02BD\u02BA\u02B3(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, bool \u02B5\u02B5\u02B3\u02B9\u02C1\u02C1\u02B6\u02B9\u02B7\u02B8\u02B7 = false)
	{
		bool flag = \u02B5\u02B5\u02B3\u02B9\u02C1\u02C1\u02B6\u02B9\u02B7\u02B8\u02B7;
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			if (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF == 512)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02BF\u02BE\u02B2\u02BD\u02BB\u02B9\u02BA\u02B6\u02C0\u02B9\u02BD(\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
			for (int j = 0; j < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; j++)
			{
				ushort num = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
				switch (num)
				{
				case 1:
					\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 1;
					break;
				case 2:
					\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 16;
					break;
				case 3:
					break;
				case 4:
					\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 4;
					break;
				default:
					if (num != 8)
					{
						if (num == 512)
						{
							if ((\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j].\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3 & 8) != 0 || (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j].\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3 & 64) != 0)
							{
								\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 4;
							}
							else
							{
								\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 8;
							}
						}
					}
					else
					{
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 64;
					}
					break;
				}
			}
		}
	}

	// Token: 0x06001268 RID: 4712 RVA: 0x00096E00 File Offset: 0x00095000
	public static void \u02BF\u02B3\u02B2\u02BB\u02B4\u02B7\u02B3\u02C0\u02B3\u02BC\u02B7(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
	{
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			if ((\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUMS_DISCO) != Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE)
			{
				ushort num = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
				if (num != 1)
				{
					if (num == 2 || num == 16)
					{
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 1;
					}
				}
				else
				{
					\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 16;
				}
			}
		}
	}

	// Token: 0x06001269 RID: 4713 RVA: 0x00096E6C File Offset: 0x0009506C
	public static void \u02B4\u02BB\u02B7\u02BD\u02BA\u02B9\u02BD\u02B2\u02B2\u02BF\u02BE(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, List<\u02B2\u02BA\u02B2\u02B4\u02B6\u02B4\u02B6\u02BB\u02BA\u02B7\u02B4> \u02B6\u02B2\u02B9\u02BD\u02BA\u02B3\u02BD\u02BA\u02B2\u02B6\u02B3)
	{
		Dictionary<int, bool> dictionary = new Dictionary<int, bool>(500);
		int num = 0;
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			if (!dictionary.ContainsKey(i) && (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUMS_FLAM) != Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE && (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & 384) == 0 && (!\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02B4\u02BD\u02C0\u02B5\u02B3\u02B8\u02B8\u02B8\u02BB\u02C0 || (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02C1\u02B7\u02B6\u02BF\u02B9\u02BB\u02B8\u02BD\u02B9\u02B8\u02B3 <= 2 && (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3 & 384) != 0)))
			{
				\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.CHORD | Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DISJOINT | Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.EXTENDED_SUSTAIN;
				Note note = new Note(\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]);
				note.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 &= ~Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.EXTENDED_SUSTAIN;
				if ((\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUM_ACTIVATION) != Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE)
				{
					\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 &= ~Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUM_ACTIVATION;
					note.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUM_ACTIVATION;
					\u02B6\u02B2\u02B9\u02BD\u02BA\u02B3\u02BD\u02BA\u02B2\u02B6\u02B3[num].\u02B9\u02BE\u02BD\u02BF\u02BB\u02BB\u02BE\u02BF\u02BC\u02B3\u02B8 = note;
					num++;
				}
				ushort num2 = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
				if (num2 <= 8)
				{
					switch (num2)
					{
					case 1:
						note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 2;
						break;
					case 2:
						note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 4;
						break;
					case 3:
						goto IL_01EC;
					case 4:
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 2;
						note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 8;
						break;
					default:
						if (num2 != 8)
						{
							goto IL_01EC;
						}
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 4;
						note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 8;
						break;
					}
				}
				else if (num2 != 16)
				{
					if (num2 != 32)
					{
						if (num2 != 64)
						{
							goto IL_01EC;
						}
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 32;
						note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 64;
					}
					else
					{
						note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 64;
					}
				}
				else
				{
					note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 32;
				}
				\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02B7\u02C1\u02BF\u02B4\u02BD\u02B7\u02BE\u02B3\u02BA\u02C0\u02B4 = note;
				note.\u02BF\u02BB\u02B7\u02BA\u02BA\u02BB\u02C0\u02BF\u02B8\u02B4\u02B3 = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i];
				\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Insert(i + 1, note);
				dictionary[i + 1] = true;
				i++;
			}
			IL_01EC:;
		}
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x00097078 File Offset: 0x00095278
	public static void \u02B8\u02B8\u02B6\u02B4\u02B2\u02B3\u02B7\u02BB\u02BF\u02B5\u02BF(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			if (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF == 256)
			{
				if (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02BB\u02B7\u02BA\u02BA\u02BB\u02C0\u02BF\u02B8\u02B4\u02B3 != null)
				{
					\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02BB\u02B7\u02BA\u02BA\u02BB\u02C0\u02BF\u02B8\u02B4\u02B3.\u02B7\u02C1\u02BF\u02B4\u02BD\u02B7\u02BE\u02B3\u02BA\u02C0\u02B4 = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02B7\u02C1\u02BF\u02B4\u02BD\u02B7\u02BE\u02B3\u02BA\u02C0\u02B4;
				}
				if (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02B7\u02C1\u02BF\u02B4\u02BD\u02B7\u02BE\u02B3\u02BA\u02C0\u02B4 != null)
				{
					\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02B7\u02C1\u02BF\u02B4\u02BD\u02B7\u02BE\u02B3\u02BA\u02C0\u02B4.\u02BF\u02BB\u02B7\u02BA\u02BA\u02BB\u02C0\u02BF\u02B8\u02B4\u02B3 = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02BB\u02B7\u02BA\u02BA\u02BB\u02C0\u02BF\u02B8\u02B4\u02B3;
				}
				\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i] = null;
			}
		}
		\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.RemoveAll(new Predicate<Note>(\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.<>c.<>9.\u02B5\u02B7\u02C1\u02BC\u02B7\u02C1\u02B7\u02B6\u02B3\u02B7\u02B7));
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x00097130 File Offset: 0x00095330
	public static void \u02B8\u02B7\u02B3\u02BC\u02B4\u02B4\u02B3\u02BA\u02B5\u02BB\u02BE(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			if (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF == 256)
			{
				\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 128;
			}
		}
		\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.RemoveAll(new Predicate<Note>(\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.<>c.<>9.\u02B2\u02BB\u02B3\u02BD\u02B8\u02BC\u02BC\u02B3\u02BF\u02B4\u02BB));
	}

	// Token: 0x0600126C RID: 4716 RVA: 0x00097198 File Offset: 0x00095398
	public static void \u02BE\u02C0\u02C1\u02B8\u02B7\u02B9\u02B5\u02B6\u02B3\u02B2\u02BC(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			Note note = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i];
			if (note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF == 128)
			{
				if (note.\u02BF\u02BB\u02B7\u02BA\u02BA\u02BB\u02C0\u02BF\u02B8\u02B4\u02B3 != null)
				{
					note.\u02BF\u02BB\u02B7\u02BA\u02BA\u02BB\u02C0\u02BF\u02B8\u02B4\u02B3.\u02B7\u02C1\u02BF\u02B4\u02BD\u02B7\u02BE\u02B3\u02BA\u02C0\u02B4 = note.\u02B7\u02C1\u02BF\u02B4\u02BD\u02B7\u02BE\u02B3\u02BA\u02C0\u02B4;
				}
				if (note.\u02B7\u02C1\u02BF\u02B4\u02BD\u02B7\u02BE\u02B3\u02BA\u02C0\u02B4 != null)
				{
					note.\u02B7\u02C1\u02BF\u02B4\u02BD\u02B7\u02BE\u02B3\u02BA\u02C0\u02B4.\u02BF\u02BB\u02B7\u02BA\u02BA\u02BB\u02C0\u02BF\u02B8\u02B4\u02B3 = note.\u02BF\u02BB\u02B7\u02BA\u02BA\u02BB\u02C0\u02BF\u02B8\u02B4\u02B3;
				}
				\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i] = null;
			}
		}
		\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.RemoveAll(new Predicate<Note>(\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.<>c.<>9.\u02BC\u02B8\u02B9\u02B4\u02B8\u02C0\u02B8\u02BF\u02BB\u02B7\u02B2));
	}

	// Token: 0x0600126D RID: 4717 RVA: 0x0009722C File Offset: 0x0009542C
	public static void \u02B9\u02C0\u02B5\u02B8\u02BF\u02C1\u02B8\u02B6\u02B4\u02C0\u02B2(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		uint num = 0U;
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			Note note = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i];
			if (num == note.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE && i != 0)
			{
				\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i] = null;
			}
			else
			{
				num = note.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE;
				if (note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF != 128)
				{
					note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 128;
				}
				if (note.\u02B7\u02C1\u02BF\u02B4\u02BD\u02B7\u02BE\u02B3\u02BA\u02C0\u02B4 != null)
				{
					note.\u02B7\u02C1\u02BF\u02B4\u02BD\u02B7\u02BE\u02B3\u02BA\u02C0\u02B4 = null;
				}
				if (note.\u02BF\u02BB\u02B7\u02BA\u02BA\u02BB\u02C0\u02BF\u02B8\u02B4\u02B3 != null)
				{
					note.\u02BF\u02BB\u02B7\u02BA\u02BA\u02BB\u02C0\u02BF\u02B8\u02B4\u02B3 = null;
				}
			}
		}
		\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.RemoveAll(new Predicate<Note>(\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.<>c.<>9.\u02B7\u02BF\u02BC\u02B4\u02B4\u02B4\u02BF\u02BC\u02BB\u02C1\u02C0));
	}

	// Token: 0x0600126E RID: 4718 RVA: 0x000972D0 File Offset: 0x000954D0
	public static void \u02BF\u02B7\u02B3\u02BB\u02C1\u02BF\u02B7\u02BA\u02C1\u02BC\u02B5(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		ushort num = \u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02C1\u02BE\u02BF\u02B2\u02BD\u02B5\u02BD\u02BB\u02B8\u02C0\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
		foreach (Note note in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = num;
			note.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Strum;
		}
	}

	// Token: 0x0600126F RID: 4719 RVA: 0x0009732C File Offset: 0x0009552C
	public static void \u02BE\u02BF\u02BA\u02B6\u02BC\u02B5\u02BD\u02BD\u02BB\u02BE\u02B9(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		int num = 0;
		string checksumString = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.checksumString;
		for (int i = 0; i < checksumString.Length; i++)
		{
			num += (int)checksumString[i];
		}
		ushort num2 = 0;
		ushort num3 = 0;
		ushort num4 = 0;
		uint num5 = 0U;
		ushort num6 = 0;
		global::UnityEngine.Random.InitState(num);
		bool flag = \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.ProDrums || \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.Drums;
		\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B9\u02BC\u02BC\u02BA\u02C1\u02C1\u02C0\u02B9\u02BC\u02BD\u02BE u02B9_u02BC_u02BC_u02BA_u02C1_u02C1_u02C0_u02B9_u02BC_u02BD_u02BE;
		u02B9_u02BC_u02BC_u02BA_u02C1_u02C1_u02C0_u02B9_u02BC_u02BD_u02BE.range = 0;
		switch (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
		{
		case Instrument.Guitar:
		case Instrument.Bass:
		case Instrument.Rhythm:
		case Instrument.GuitarCoop:
		case Instrument.Keys:
			u02B9_u02BC_u02BC_u02BA_u02C1_u02C1_u02C0_u02B9_u02BC_u02BD_u02BE.range = 5;
			break;
		case Instrument.GHLGuitar:
		case Instrument.GHLBass:
		case Instrument.GHLRhythm:
		case Instrument.GHLGuitarCoop:
			u02B9_u02BC_u02BC_u02BA_u02C1_u02C1_u02C0_u02B9_u02BC_u02BD_u02BE.range = 6;
			break;
		case Instrument.Drums:
			u02B9_u02BC_u02BC_u02BA_u02C1_u02C1_u02C0_u02B9_u02BC_u02BD_u02BE.range = 4;
			break;
		case Instrument.ProDrums:
			u02B9_u02BC_u02BC_u02BA_u02C1_u02C1_u02C0_u02B9_u02BC_u02BD_u02BE.range = 7;
			break;
		}
		ushort num7 = (ushort)((1 << u02B9_u02BC_u02BC_u02BA_u02C1_u02C1_u02C0_u02B9_u02BC_u02BD_u02BE.range) - 1);
		ushort num8 = \u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02C1\u02BE\u02BF\u02B2\u02BD\u02B5\u02BD\u02BB\u02B8\u02C0\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
		foreach (Note note in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			if ((note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & num8) == 0 && (flag || (!note.\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1 && note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF != num7)))
			{
				int num9 = __FIXME_clon_util.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF);
				ushort num10 = 0;
				ushort num11 = note.\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3 & 127;
				if (flag && num4 != 0 && num4 == num11)
				{
					int num12 = 0;
					__FIXME_clon_util.\u02C0\u02BF\u02B7\u02BA\u02B6\u02BA\u02B2\u02B4\u02B5\u02B8\u02B9 u02C0_u02BF_u02B7_u02BA_u02B6_u02BA_u02B2_u02B4_u02B5_u02B8_u02B = __FIXME_clon_util.\u02C1\u02BF\u02B8\u02B2\u02BA\u02B3\u02B4\u02B3\u02C1\u02BC\u02BE((uint)num11).\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
					while (u02C0_u02BF_u02B7_u02BA_u02B6_u02BA_u02B2_u02B4_u02B5_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
					{
						if (u02C0_u02BF_u02B7_u02BA_u02B6_u02BA_u02B2_u02B4_u02B5_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF == (uint)note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF)
						{
							num10 = __FIXME_clon_util.\u02BE\u02BB\u02B6\u02B7\u02B8\u02C0\u02BF\u02B5\u02C0\u02B6\u02B6(num2, num12);
							break;
						}
						num12++;
					}
				}
				else
				{
					do
					{
						num10 = \u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B9\u02B4\u02B3\u02BD\u02C1\u02C1\u02BD\u02B7\u02B2\u02BD\u02B8(num9, ref u02B9_u02BC_u02BC_u02BA_u02C1_u02C1_u02C0_u02B9_u02BC_u02BD_u02BE);
					}
					while ((!flag && num2 == num10) || (flag && ((num10 & \u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B9\u02BE\u02B7\u02C0\u02C0\u02BE\u02C1\u02B2\u02B2\u02B2\u02B9(num6)) != 0 || (num10 & \u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B9\u02BE\u02B7\u02C0\u02C0\u02BE\u02C1\u02B2\u02B2\u02B2\u02B9(num6)) != 0)));
				}
				if (flag)
				{
					if (num5 == note.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE)
					{
						num6 |= num10;
					}
					else
					{
						num2 = num6;
						num6 = num10;
						num4 = num3;
						num3 = num11;
					}
				}
				else
				{
					num2 = num10;
				}
				note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = num10;
				num5 = note.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE;
			}
		}
	}

	// Token: 0x06001270 RID: 4720 RVA: 0x00097568 File Offset: 0x00095768
	public static void \u02C1\u02BD\u02BD\u02BF\u02BA\u02B6\u02BF\u02B7\u02B9\u02B9\u02B2(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		switch (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
		{
		case Instrument.Guitar:
		case Instrument.Bass:
		case Instrument.Rhythm:
		case Instrument.GuitarCoop:
		case Instrument.Keys:
			break;
		case Instrument.GHLGuitar:
		case Instrument.GHLBass:
		case Instrument.GHLRhythm:
		case Instrument.GHLGuitarCoop:
		{
			using (List<Note>.Enumerator enumerator = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Note note = enumerator.Current;
					ushort num = note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
					if (num != 63)
					{
						ushort num2 = 0;
						if ((num & 8) != 0)
						{
							num2 |= 32;
						}
						if ((num & 16) != 0)
						{
							num2 |= 16;
						}
						if ((num & 32) != 0)
						{
							num2 |= 8;
						}
						if ((num & 1) != 0)
						{
							num2 |= 4;
						}
						if ((num & 2) != 0)
						{
							num2 |= 2;
						}
						if ((num & 4) != 0)
						{
							num2 |= 1;
						}
						if ((num & 64) != 0)
						{
							num2 |= 64;
						}
						note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = num2;
					}
				}
				return;
			}
			break;
		}
		case Instrument.Drums:
		case Instrument.ProDrums:
			goto IL_0160;
		case Instrument.Band:
			return;
		default:
			return;
		}
		using (List<Note>.Enumerator enumerator = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Note note2 = enumerator.Current;
				ushort num3 = note2.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
				if (num3 != 31)
				{
					ushort num4 = 0;
					if ((num3 & 1) != 0)
					{
						num4 |= 16;
					}
					if ((num3 & 2) != 0)
					{
						num4 |= 8;
					}
					if ((num3 & 4) != 0)
					{
						num4 |= 4;
					}
					if ((num3 & 8) != 0)
					{
						num4 |= 2;
					}
					if ((num3 & 16) != 0)
					{
						num4 |= 1;
					}
					if ((num3 & 64) != 0)
					{
						num4 |= 64;
					}
					note2.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = num4;
				}
			}
			return;
		}
		IL_0160:
		foreach (Note note3 in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			ushort num5 = note3.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
			if (num5 != 15)
			{
				if ((num5 & 1) != 0)
				{
					note3.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 8;
				}
				if ((num5 & 2) != 0)
				{
					note3.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 4;
				}
				if ((num5 & 4) != 0)
				{
					note3.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 2;
				}
				if ((num5 & 8) != 0)
				{
					note3.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 1;
				}
			}
		}
		foreach (Note note4 in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			ushort num6 = note4.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
			ushort num7 = note4.\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3 ^ num6;
			if (num6 != 15)
			{
				if ((num6 & 16) != 0 && (num7 & 8) == 0)
				{
					note4.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 64;
				}
				if ((num6 & 16) != 0 && (num7 & 8) != 0)
				{
					note4.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 32;
				}
				if ((num6 & 32) != 0 && (num7 & 4) == 0)
				{
					note4.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 32;
				}
				if ((num6 & 32) != 0 && (num7 & 4) != 0)
				{
					note4.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 16;
				}
				if ((num6 & 64) != 0 && (num7 & 2) == 0)
				{
					note4.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 16;
				}
				if ((num6 & 64) != 0 && (num7 & 2) != 0)
				{
					note4.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = 32;
				}
			}
		}
	}

	// Token: 0x06001271 RID: 4721 RVA: 0x00097850 File Offset: 0x00095A50
	public static void \u02B7\u02B4\u02BD\u02BE\u02B2\u02BB\u02B3\u02BA\u02B7\u02BC\u02B7(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, ControllerType controllerType)
	{
		int num = 0;
		uint num2 = 0U;
		ushort num3 = 0;
		ushort num4 = 0;
		ushort num5 = 0;
		ushort num6 = 0;
		if (controllerType == ControllerType.GHLGuitar)
		{
			num6 = 64;
		}
		else
		{
			num6 = 64;
		}
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			Note note = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i];
			note.\u02BD\u02B7\u02BA\u02C1\u02B9\u02B9\u02B9\u02B7\u02B7\u02B6\u02BD = __FIXME_clon_util.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF);
			if (note.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE != num2)
			{
				num2 = note.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE;
				int num7 = __FIXME_clon_util.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(note.\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3);
				if (num7 < 3 && note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF != num6)
				{
					if (!note.\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1)
					{
						num = i;
					}
					Note note2 = note;
					ushort num8 = note.\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3;
					if (note.\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1 && num7 <= 2)
					{
						if (note.\u02BF\u02B4\u02BD\u02C0\u02B5\u02B3\u02B8\u02B8\u02B8\u02BB\u02C0)
						{
							Note.\u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3 u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B = note.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
							while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
							{
								Note note3 = u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
								if (note2.\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD > note3.\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD)
								{
									note2 = note3;
								}
							}
						}
						num8 |= \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.\u02B3\u02BB\u02B8\u02B5\u02C1\u02B2\u02BE\u02B3\u02C1\u02BC\u02B3(note2.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE, num);
						int num9 = 0;
						int num10 = i;
						while (i > 0)
						{
							if (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[num10].\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE != note2.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE)
							{
								num9 = num10;
								break;
							}
							num10--;
						}
						if (note2.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 > 0)
						{
							foreach (Note note4 in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.\u02B2\u02B7\u02BF\u02BF\u02B6\u02C1\u02BA\u02B6\u02B3\u02B2\u02BE(note2.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE, (uint)note2.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2, num9))
							{
								num8 |= note4.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
							}
						}
					}
					ushort num11;
					if (controllerType == ControllerType.GHLGuitar)
					{
						num11 = 32;
					}
					else
					{
						num11 = 16;
					}
					ushort num12 = note2.\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3;
					ushort num13;
					bool flag;
					if ((note2.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & num11) != 0)
					{
						num13 = __FIXME_clon_util.\u02BE\u02BB\u02B6\u02B7\u02B8\u02C0\u02BF\u02B5\u02C0\u02B6\u02B6(num12, 0);
						flag = true;
					}
					else
					{
						int num14 = __FIXME_clon_util.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(num12);
						num13 = __FIXME_clon_util.\u02BE\u02BB\u02B6\u02B7\u02B8\u02C0\u02BF\u02B5\u02C0\u02B6\u02B6(num12, num14 - 1);
						flag = false;
					}
					if (num3 == num12 && !note2.\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1)
					{
						Note note5 = note2;
						note5.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF |= num5;
						if (__FIXME_clon_util.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(num4) > 1)
						{
							note2.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.CHORD;
						}
					}
					else
					{
						int num15 = 0;
						do
						{
							if (flag)
							{
								if (num13 == 1)
								{
									flag = false;
									num13 = (ushort)(num13 << 1);
								}
								else
								{
									num13 = (ushort)(num13 >> 1);
								}
							}
							else if (num13 == num11)
							{
								flag = true;
								num13 = (ushort)(num13 >> 1);
							}
							else
							{
								num13 = (ushort)(num13 << 1);
							}
							num15++;
						}
						while (((num8 & num13) != 0 || (num12 & num13) != 0 || (num3 != num12 && num4 == (num12 | num13))) && num15 < 12);
						num3 = note2.\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3;
						if (num15 < 12)
						{
							Note note6 = note2;
							note6.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF |= num13;
							note2.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.CHORD;
							num5 = num13;
						}
						num4 = note2.\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3;
					}
				}
			}
		}
	}

	// Token: 0x06001272 RID: 4722 RVA: 0x00097B2C File Offset: 0x00095D2C
	public static void \u02B8\u02BC\u02B6\u02B9\u02BD\u02BC\u02BC\u02B9\u02B3\u02B9\u02C0(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
	{
		foreach (Note note in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			ushort num = note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
			ushort num2 = 0;
			if ((num & 64) != 0)
			{
				num2 = 64;
			}
			else
			{
				if ((num & 8) != 0)
				{
					num2 |= 1;
				}
				if ((num & 16) != 0)
				{
					num2 |= 2;
				}
				if ((num & 32) != 0)
				{
					num2 |= 4;
				}
				if ((num & 1) != 0)
				{
					num2 |= 8;
				}
				if ((num & 2) != 0)
				{
					num2 |= 16;
				}
				if ((num & 4) != 0)
				{
					num2 |= 32;
				}
			}
			note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = num2;
		}
	}

	// Token: 0x06001273 RID: 4723 RVA: 0x0000F9AF File Offset: 0x0000DBAF
	[CompilerGenerated]
	internal static ushort \u02C0\u02BD\u02B9\u02B7\u02B5\u02BF\u02B2\u02B6\u02BE\u02B9\u02B5(ushort \u02C0\u02B5\u02BC\u02BC\u02B4\u02C0\u02B9\u02B8\u02B9\u02C0\u02B9)
	{
		return (ushort)((int)\u02C0\u02B5\u02BC\u02BC\u02B4\u02C0\u02B9\u02B8\u02B9\u02C0\u02B9 | (((int)\u02C0\u02B5\u02BC\u02BC\u02B4\u02C0\u02B9\u02B8\u02B9\u02C0\u02B9 << 3) & 112));
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x0000F9BA File Offset: 0x0000DBBA
	[CompilerGenerated]
	internal static ushort \u02BD\u02B9\u02B7\u02BD\u02B9\u02B2\u02B3\u02BF\u02B9\u02B2\u02B8(ushort \u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB)
	{
		return (ushort)((int)(\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB & 15) | ((\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB & 112) >> 3));
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x0000F9C8 File Offset: 0x0000DBC8
	[CompilerGenerated]
	internal static ushort \u02B9\u02BE\u02B7\u02C0\u02C0\u02BE\u02C1\u02B2\u02B2\u02B2\u02B9(ushort \u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB)
	{
		return \u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02C0\u02BD\u02B9\u02B7\u02B5\u02BF\u02B2\u02B6\u02BE\u02B9\u02B5(\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02BD\u02B9\u02B7\u02BD\u02B9\u02B2\u02B3\u02BF\u02B9\u02B2\u02B8(\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB));
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x00097BCC File Offset: 0x00095DCC
	[CompilerGenerated]
	internal static ushort \u02B9\u02B4\u02B3\u02BD\u02C1\u02C1\u02BD\u02B7\u02B2\u02BD\u02B8(int \u02B2\u02B6\u02B5\u02C1\u02B2\u02BA\u02BE\u02BE\u02C0\u02B4\u02BC, ref \u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B9\u02BC\u02BC\u02BA\u02C1\u02C1\u02C0\u02B9\u02BC\u02BD\u02BE A_1)
	{
		ushort num = 0;
		int i = 0;
		while (i < \u02B2\u02B6\u02B5\u02C1\u02B2\u02BA\u02BE\u02BE\u02C0\u02B4\u02BC)
		{
			int num2 = global::UnityEngine.Random.Range(0, A_1.range);
			ushort num3 = (ushort)(1 << num2);
			if ((num & num3) == 0)
			{
				num |= num3;
				i++;
			}
		}
		return num;
	}

	// Token: 0x0200019B RID: 411
	[CompilerGenerated]
	[StructLayout(3)]
	private struct \u02B9\u02BC\u02BC\u02BA\u02C1\u02C1\u02C0\u02B9\u02BC\u02BD\u02BE
	{
		// Token: 0x04000DD6 RID: 3542
		public int range;
	}
}
