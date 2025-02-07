﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using StrikeCore;
using UnityEngine;

public static class \u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD
{
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

	public static void \u02BA\u02C1\u02B9\u02B5\u02B5\u02B4\u02BE\u02BD\u02B5\u02BC\u02BC(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		if (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.Drums || \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.ProDrums)
		{
			return;
		}
		foreach (Note note in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			if (note.IsPureHopo)
			{
				note.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Tap;
			}
		}
	}

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

	public static void \u02BF\u02BE\u02B2\u02BD\u02BB\u02B9\u02BA\u02B6\u02C0\u02B9\u02BD(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			if ((\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask & 112) != 0)
			{
				Note note = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i];
				note._noteMask = (ushort)(note._noteMask >> 3);
			}
		}
	}

	public static void \u02B7\u02BD\u02B6\u02BD\u02C1\u02B8\u02BB\u02B5\u02B2\u02B4\u02B6(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF u02B4_u02B4_u02B6_u02B9_u02BC_u02B3_u02BD_u02B5_u02B4_u02B3_u02BF = ~(Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUMS_GHOST | Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUMS_ACCENT);
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 &= u02B4_u02B4_u02B6_u02B9_u02BC_u02B3_u02BD_u02B5_u02B4_u02B3_u02BF;
		}
	}

	public static void \u02B8\u02BC\u02B4\u02B8\u02B7\u02BA\u02B2\u02B5\u02BB\u02B9\u02BB(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			ushort num = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask;
			if (num != 2)
			{
				if (num == 32)
				{
					if ((\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].noteMask & 8) != 0 || (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].noteMask & 64) != 0)
					{
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask = 16;
					}
					else
					{
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask = 64;
					}
				}
			}
			else if ((\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].noteMask & 4) != 0 || (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].noteMask & 32) != 0)
			{
				\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask = 1;
			}
			else
			{
				\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask = 4;
			}
		}
	}

	public static void \u02BE\u02B8\u02C1\u02B3\u02B5\u02B8\u02C1\u02BE\u02BD\u02BA\u02B3(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, bool \u02B5\u02B5\u02B3\u02B9\u02C1\u02C1\u02B6\u02B9\u02B7\u02B8\u02B7 = false)
	{
		bool flag = \u02B5\u02B5\u02B3\u02B9\u02C1\u02C1\u02B6\u02B9\u02B7\u02B8\u02B7;
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			if (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask == 512)
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
				ushort num = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j]._noteMask;
				switch (num)
				{
				case 1:
					\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j]._noteMask = 1;
					break;
				case 2:
					\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j]._noteMask = 16;
					break;
				case 3:
					break;
				case 4:
					\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j]._noteMask = 4;
					break;
				default:
					if (num != 8)
					{
						if (num == 512)
						{
							if ((\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j].noteMask & 8) != 0 || (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j].noteMask & 64) != 0)
							{
								\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j]._noteMask = 4;
							}
							else
							{
								\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j]._noteMask = 8;
							}
						}
					}
					else
					{
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[j]._noteMask = 64;
					}
					break;
				}
			}
		}
	}

	public static void \u02BF\u02B3\u02B2\u02BB\u02B4\u02B7\u02B3\u02C0\u02B3\u02BC\u02B7(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
	{
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			if ((\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUMS_DISCO) != Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE)
			{
				ushort num = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask;
				if (num != 1)
				{
					if (num == 2 || num == 16)
					{
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask = 1;
					}
				}
				else
				{
					\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask = 16;
				}
			}
		}
	}

	public static void \u02B4\u02BB\u02B7\u02BD\u02BA\u02B9\u02BD\u02B2\u02B2\u02BF\u02BE(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, List<\u02B2\u02BA\u02B2\u02B4\u02B6\u02B4\u02B6\u02BB\u02BA\u02B7\u02B4> \u02B6\u02B2\u02B9\u02BD\u02BA\u02B3\u02BD\u02BA\u02B2\u02B6\u02B3)
	{
		Dictionary<int, bool> dictionary = new Dictionary<int, bool>(500);
		int num = 0;
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			if (!dictionary.ContainsKey(i) && (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUMS_FLAM) != Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE && (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask & 384) == 0 && (!\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].IsDisjoint || (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].\u02C1\u02B7\u02B6\u02BF\u02B9\u02BB\u02B8\u02BD\u02B9\u02B8\u02B3 <= 2 && (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i].noteMask & 384) != 0)))
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
				ushort num2 = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask;
				if (num2 <= 8)
				{
					switch (num2)
					{
					case 1:
						note._noteMask = 2;
						break;
					case 2:
						note._noteMask = 4;
						break;
					case 3:
						goto IL_01EC;
					case 4:
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask = 2;
						note._noteMask = 8;
						break;
					default:
						if (num2 != 8)
						{
							goto IL_01EC;
						}
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask = 4;
						note._noteMask = 8;
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
						\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask = 32;
						note._noteMask = 64;
					}
					else
					{
						note._noteMask = 64;
					}
				}
				else
				{
					note._noteMask = 32;
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

	public static void \u02B8\u02B8\u02B6\u02B4\u02B2\u02B3\u02B7\u02BB\u02BF\u02B5\u02BF(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			if (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask == 256)
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

	public static void \u02B8\u02B7\u02B3\u02BC\u02B4\u02B4\u02B3\u02BA\u02B5\u02BB\u02BE(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			if (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask == 256)
			{
				\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i]._noteMask = 128;
			}
		}
		\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.RemoveAll(new Predicate<Note>(\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.<>c.<>9.\u02B2\u02BB\u02B3\u02BD\u02B8\u02BC\u02BC\u02B3\u02BF\u02B4\u02BB));
	}

	public static void \u02BE\u02C0\u02C1\u02B8\u02B7\u02B9\u02B5\u02B6\u02B3\u02B2\u02BC(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			Note note = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i];
			if (note._noteMask == 128)
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

	public static void \u02B9\u02C0\u02B5\u02B8\u02BF\u02C1\u02B8\u02B6\u02B4\u02C0\u02B2(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		uint num = 0U;
		for (int i = 0; i < \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count; i++)
		{
			Note note = \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i];
			if (num == note.tickPosition && i != 0)
			{
				\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[i] = null;
			}
			else
			{
				num = note.tickPosition;
				if (note._noteMask != 128)
				{
					note._noteMask = 128;
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

	public static void \u02BF\u02B7\u02B3\u02BB\u02C1\u02BF\u02B7\u02BA\u02C1\u02BC\u02B5(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		ushort num = \u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02C1\u02BE\u02BF\u02B2\u02BD\u02B5\u02BD\u02BB\u02B8\u02C0\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
		foreach (Note note in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			note._noteMask = num;
			note.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Strum;
		}
	}

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
			if ((note._noteMask & num8) == 0 && (flag || (!note.IsExtendedSustain && note._noteMask != num7)))
			{
				int num9 = Helper.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(note._noteMask);
				ushort num10 = 0;
				ushort num11 = note.noteMask & 127;
				if (flag && num4 != 0 && num4 == num11)
				{
					int num12 = 0;
					Helper.UintPair @this = Helper.NewUintPair((uint)num11).GetThis();
					while (@this.MoreThanOneBitSet())
					{
						if (@this.xor == (uint)note._noteMask)
						{
							num10 = Helper.\u02BE\u02BB\u02B6\u02B7\u02B8\u02C0\u02BF\u02B5\u02C0\u02B6\u02B6(num2, num12);
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
					if (num5 == note.tickPosition)
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
				note._noteMask = num10;
				num5 = note.tickPosition;
			}
		}
	}

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
					ushort num = note._noteMask;
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
						note._noteMask = num2;
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
				ushort num3 = note2._noteMask;
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
					note2._noteMask = num4;
				}
			}
			return;
		}
		IL_0160:
		foreach (Note note3 in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			ushort num5 = note3._noteMask;
			if (num5 != 15)
			{
				if ((num5 & 1) != 0)
				{
					note3._noteMask = 8;
				}
				if ((num5 & 2) != 0)
				{
					note3._noteMask = 4;
				}
				if ((num5 & 4) != 0)
				{
					note3._noteMask = 2;
				}
				if ((num5 & 8) != 0)
				{
					note3._noteMask = 1;
				}
			}
		}
		foreach (Note note4 in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			ushort num6 = note4._noteMask;
			ushort num7 = note4.noteMask ^ num6;
			if (num6 != 15)
			{
				if ((num6 & 16) != 0 && (num7 & 8) == 0)
				{
					note4._noteMask = 64;
				}
				if ((num6 & 16) != 0 && (num7 & 8) != 0)
				{
					note4._noteMask = 32;
				}
				if ((num6 & 32) != 0 && (num7 & 4) == 0)
				{
					note4._noteMask = 32;
				}
				if ((num6 & 32) != 0 && (num7 & 4) != 0)
				{
					note4._noteMask = 16;
				}
				if ((num6 & 64) != 0 && (num7 & 2) == 0)
				{
					note4._noteMask = 16;
				}
				if ((num6 & 64) != 0 && (num7 & 2) != 0)
				{
					note4._noteMask = 32;
				}
			}
		}
	}

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
			note.\u02BD\u02B7\u02BA\u02C1\u02B9\u02B9\u02B9\u02B7\u02B7\u02B6\u02BD = Helper.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(note._noteMask);
			if (note.tickPosition != num2)
			{
				num2 = note.tickPosition;
				int num7 = Helper.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(note.noteMask);
				if (num7 < 3 && note._noteMask != num6)
				{
					if (!note.IsExtendedSustain)
					{
						num = i;
					}
					Note note2 = note;
					ushort num8 = note.noteMask;
					if (note.IsExtendedSustain && num7 <= 2)
					{
						if (note.IsDisjoint)
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
						num8 |= \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.\u02B3\u02BB\u02B8\u02B5\u02C1\u02B2\u02BE\u02B3\u02C1\u02BC\u02B3(note2.tickPosition, num);
						int num9 = 0;
						int num10 = i;
						while (i > 0)
						{
							if (\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[num10].tickPosition != note2.tickPosition)
							{
								num9 = num10;
								break;
							}
							num10--;
						}
						if (note2.tickLength > 0)
						{
							foreach (Note note4 in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.\u02B2\u02B7\u02BF\u02BF\u02B6\u02C1\u02BA\u02B6\u02B3\u02B2\u02BE(note2.tickPosition, (uint)note2.tickLength, num9))
							{
								num8 |= note4._noteMask;
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
					ushort num12 = note2.noteMask;
					ushort num13;
					bool flag;
					if ((note2._noteMask & num11) != 0)
					{
						num13 = Helper.\u02BE\u02BB\u02B6\u02B7\u02B8\u02C0\u02BF\u02B5\u02C0\u02B6\u02B6(num12, 0);
						flag = true;
					}
					else
					{
						int num14 = Helper.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(num12);
						num13 = Helper.\u02BE\u02BB\u02B6\u02B7\u02B8\u02C0\u02BF\u02B5\u02C0\u02B6\u02B6(num12, num14 - 1);
						flag = false;
					}
					if (num3 == num12 && !note2.IsExtendedSustain)
					{
						Note note5 = note2;
						note5._noteMask |= num5;
						if (Helper.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(num4) > 1)
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
						num3 = note2.noteMask;
						if (num15 < 12)
						{
							Note note6 = note2;
							note6._noteMask |= num13;
							note2.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.CHORD;
							num5 = num13;
						}
						num4 = note2.noteMask;
					}
				}
			}
		}
	}

	public static void \u02B8\u02BC\u02B6\u02B9\u02BD\u02BC\u02BC\u02B9\u02B3\u02B9\u02C0(List<Note> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
	{
		foreach (Note note in \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8)
		{
			ushort num = note._noteMask;
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
			note._noteMask = num2;
		}
	}

	[CompilerGenerated]
	internal static ushort \u02C0\u02BD\u02B9\u02B7\u02B5\u02BF\u02B2\u02B6\u02BE\u02B9\u02B5(ushort \u02C0\u02B5\u02BC\u02BC\u02B4\u02C0\u02B9\u02B8\u02B9\u02C0\u02B9)
	{
		return (ushort)((int)\u02C0\u02B5\u02BC\u02BC\u02B4\u02C0\u02B9\u02B8\u02B9\u02C0\u02B9 | (((int)\u02C0\u02B5\u02BC\u02BC\u02B4\u02C0\u02B9\u02B8\u02B9\u02C0\u02B9 << 3) & 112));
	}

	[CompilerGenerated]
	internal static ushort \u02BD\u02B9\u02B7\u02BD\u02B9\u02B2\u02B3\u02BF\u02B9\u02B2\u02B8(ushort \u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB)
	{
		return (ushort)((int)(\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB & 15) | ((\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB & 112) >> 3));
	}

	[CompilerGenerated]
	internal static ushort \u02B9\u02BE\u02B7\u02C0\u02C0\u02BE\u02C1\u02B2\u02B2\u02B2\u02B9(ushort \u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB)
	{
		return \u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02C0\u02BD\u02B9\u02B7\u02B5\u02BF\u02B2\u02B6\u02BE\u02B9\u02B5(\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02BD\u02B9\u02B7\u02BD\u02B9\u02B2\u02B3\u02BF\u02B9\u02B2\u02B8(\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB));
	}

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

	[CompilerGenerated]
	[StructLayout(3)]
	private struct \u02B9\u02BC\u02BC\u02BA\u02C1\u02C1\u02C0\u02B9\u02BC\u02BD\u02BE
	{
		public int range;
	}
}
