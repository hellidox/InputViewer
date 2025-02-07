﻿using System;
using StrikeCore;

public struct \u02B5\u02B4\u02BD\u02BE\u02B5\u02BA\u02BA\u02B5\u02B2\u02B9\u02B3
{
	public long \u02B2\u02C1\u02BC\u02C0\u02BA\u02B8\u02B2\u02B7\u02B2\u02B3\u02BB
	{
		get
		{
			return this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5;
		}
		set
		{
			this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5 |= value;
		}
	}

	public bool \u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, Difficulty \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA)
	{
		long num = this.\u02B3\u02BA\u02C0\u02BC\u02B8\u02BD\u02C1\u02B6\u02C0\u02B9\u02BF(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA);
		return (this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5 & num) == num;
	}

	public bool \u02BF\u02BB\u02C0\u02BB\u02B2\u02B6\u02B5\u02B8\u02B8\u02B2\u02BB(Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		long num = 15L << (int)(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF * Instrument.GHLGuitar);
		return (this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5 & num) != 0L;
	}

	public bool \u02B9\u02BB\u02C1\u02BF\u02BA\u02BB\u02B8\u02BA\u02B5\u02B5\u02B9(Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		long num = -72L << (int)((\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF * Instrument.GHLBass) & (Instrument)86);
		return (this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5 & num) != 0L;
	}

	private long \u02B3\u02BA\u02C0\u02BC\u02B8\u02BD\u02C1\u02B6\u02C0\u02B9\u02BF(Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, Difficulty \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA)
	{
		return 1L << (int)(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF * Instrument.GHLGuitar + (sbyte)\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA);
	}

	public void \u02BB\u02BE\u02B4\u02B8\u02BA\u02B8\u02B5\u02B4\u02C1\u02B5\u02B2(Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, Difficulty \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA)
	{
		long num = this.\u02B3\u02BA\u02C0\u02BC\u02B8\u02BD\u02C1\u02B6\u02C0\u02B9\u02BF(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA);
		if ((this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5 & num) == num)
		{
			return;
		}
		this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5 |= num;
	}

	public void \u02BC\u02B4\u02B5\u02B8\u02B3\u02B2\u02C0\u02BA\u02B8\u02BE\u02C1()
	{
		this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5 = 0L;
	}

	private long \u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5;

	private const byte \u02B5\u02B4\u02C1\u02BA\u02B2\u02B5\u02B3\u02B6\u02BE\u02BB\u02B9 = 4;
}
