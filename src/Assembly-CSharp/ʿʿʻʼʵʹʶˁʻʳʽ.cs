﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StrikeCore;
using UnityEngine;

public class \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD : \u02BA\u02B8\u02B8\u02BD\u02BF\u02BE\u02B6\u02BD\u02BB\u02B9\u02B5
{
	public bool \u02BA\u02B3\u02C0\u02B9\u02BC\u02B3\u02BE\u02B3\u02B8\u02B3\u02BB
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FORCED) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FORCED;
		}
	}

	public bool \u02B7\u02B3\u02BC\u02B3\u02BD\u02B5\u02BD\u02BE\u02C0\u02B4\u02B7
	{
		get
		{
			\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD = this.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC;
			while (u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD != null && u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8 == this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8)
			{
				u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD = u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC;
			}
			return u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD == null;
		}
	}

	public void \u02B8\u02BB\u02B2\u02BD\u02B2\u02BC\u02B5\u02BA\u02B3\u02B3\u02C0()
	{
		foreach (\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD in this.\u02BF\u02BF\u02BD\u02B3\u02B6\u02BA\u02B4\u02B5\u02C0\u02BF\u02BC())
		{
			u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 = this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0;
		}
	}

	public int \u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF
	{
		get
		{
			int num = 0;
			foreach (\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD in this.\u02B2\u02BE\u02BC\u02B2\u02BF\u02B7\u02BE\u02B4\u02C0\u02BD\u02C1())
			{
				num |= 1 << (int)u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF;
			}
			return num;
		}
	}

	public bool \u02B3\u02B7\u02BD\u02B2\u02B9\u02C1\u02B6\u02C0\u02B6\u02B4\u02B2
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.TOM) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.TOM;
		}
	}

	public bool \u02C0\u02BE\u02B4\u02BB\u02BC\u02B7\u02B8\u02B9\u02BE\u02B5\u02B2
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FLAM) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FLAM;
		}
	}

	private bool \u02C0\u02B9\u02BD\u02B8\u02B4\u02BB\u02B4\u02B9\u02B9\u02B6\u02BD
	{
		get
		{
			return this.\u02B7\u02B2\u02B9\u02B2\u02B3\u02C1\u02BB\u02B9\u02B7\u02B8\u02BC ^ this.\u02BA\u02B3\u02C0\u02B9\u02BC\u02B3\u02BE\u02B3\u02B8\u02B3\u02BB;
		}
	}

	public bool \u02BC\u02BF\u02B7\u02B2\u02C0\u02C1\u02BD\u02BC\u02B9\u02B4\u02B8
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.CYMBAL) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.CYMBAL;
		}
	}

	public bool \u02B7\u02B2\u02B9\u02B2\u02B3\u02C1\u02BB\u02B9\u02B7\u02B8\u02BC
	{
		get
		{
			bool flag = false;
			if (!this.\u02C0\u02B7\u02BD\u02B9\u02B4\u02B9\u02BF\u02BA\u02BA\u02C0\u02B2 && this.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC != null)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.isMIDIChart && this.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC.\u02C0\u02B7\u02BD\u02B9\u02B4\u02B9\u02BF\u02BA\u02BA\u02C0\u02B2 && (this.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & this.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF) == this.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF)
				{
					return false;
				}
				if (this.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC.\u02C0\u02B7\u02BD\u02B9\u02B4\u02B9\u02BF\u02BA\u02BA\u02C0\u02B2 || (!this.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC.\u02C0\u02B7\u02BD\u02B9\u02B4\u02B9\u02BF\u02BA\u02BA\u02C0\u02B2 && this.\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF != this.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC.\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF))
				{
					int num;
					if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B2\u02BB\u02C1\u02C0\u02B4\u02BA\u02B9\u02C1\u02B3\u02B7\u02B5 > 0)
					{
						num = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B2\u02BB\u02C1\u02C0\u02B4\u02BA\u02B9\u02C1\u02B3\u02B7\u02B5;
					}
					else if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BF\u02BF\u02BC\u02B2\u02B4\u02B6\u02B2\u02B3\u02BF\u02B9\u02C0)
					{
						num = Mathf.CeilToInt(this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02C0\u02B3\u02C1\u02BB\u02B5\u02BA\u02BB\u02B3\u02C1\u02B8\u02BD / 2f) + 1;
					}
					else if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.isMIDIChart)
					{
						num = Mathf.CeilToInt(this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02C0\u02B3\u02C1\u02BB\u02B5\u02BA\u02BB\u02B3\u02C1\u02B8\u02BD / 3f) + 1;
					}
					else
					{
						num = (int)(65f * this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02C0\u02B3\u02C1\u02BB\u02B5\u02BA\u02BB\u02B3\u02C1\u02B8\u02BD / \u02B5\u02B7\u02BD\u02B4\u02B9\u02BD\u02B3\u02B9\u02B7\u02B4\u02B7.\u02C0\u02C0\u02BD\u02B5\u02B6\u02B8\u02B8\u02BF\u02B7\u02BE\u02B2);
					}
					if ((ulong)(this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8 - this.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8) <= (ulong)((long)num))
					{
						flag = true;
					}
				}
			}
			return flag;
		}
	}

	public bool \u02C0\u02B7\u02BD\u02B9\u02B4\u02B9\u02BF\u02BA\u02BA\u02C0\u02B2
	{
		get
		{
			\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD u02C1_u02C0_u02C1_u02BC_u02BD_u02B8_u02BC_u02B3_u02BE_u02B9_u02BC = this.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC;
			uint? num = ((u02C1_u02C0_u02C1_u02BC_u02BD_u02B8_u02BC_u02B3_u02BE_u02B9_u02BC != null) ? new uint?(u02C1_u02C0_u02C1_u02BC_u02BD_u02B8_u02BC_u02B3_u02BE_u02B9_u02BC.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8) : null);
			uint num2 = this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8;
			if (!((num.GetValueOrDefault() == num2) & (num != null)))
			{
				\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD u02B8_u02BF_u02B9_u02C1_u02B4_u02C1_u02B7_u02B8_u02BC_u02BA_u02B = this.\u02B8\u02BF\u02B9\u02C1\u02B4\u02C1\u02B7\u02B8\u02BC\u02BA\u02B7;
				num = ((u02B8_u02BF_u02B9_u02C1_u02B4_u02C1_u02B7_u02B8_u02BC_u02BA_u02B != null) ? new uint?(u02B8_u02BF_u02B9_u02C1_u02B4_u02C1_u02B7_u02B8_u02BC_u02BA_u02B.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8) : null);
				num2 = this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8;
				return (num.GetValueOrDefault() == num2) & (num != null);
			}
			return true;
		}
	}

	public bool \u02BD\u02BE\u02BC\u02B8\u02BC\u02B2\u02B4\u02B4\u02BA\u02BF\u02B6
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.GHOST) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.GHOST;
		}
	}

	public IEnumerable<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD> \u02BF\u02BF\u02BD\u02B3\u02B6\u02BA\u02B4\u02B5\u02C0\u02BF\u02BC()
	{
		return this.\u02B8\u02BE\u02BE\u02B9\u02B6\u02BA\u02BF\u02BD\u02C1\u02B3\u02B6(true);
	}

	public static void \u02B4\u02B3\u02B3\u02BC\u02B8\u02BC\u02BB\u02B9\u02B6\u02BE\u02BD(List<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, [TupleElementNames(new string[] { "minIndex", "maxIndex" })] ValueTuple<int, int> \u02B2\u02C1\u02BA\u02BA\u02B7\u02B4\u02C0\u02B3\u02B9\u02B6\u02B5, \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC \u02B8\u02B6\u02BD\u02BC\u02B6\u02B4\u02B3\u02B4\u02C1\u02C1\u02BF)
	{
		foreach (\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD in EnumerableRanges.EnumerateRange<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD>(\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, \u02B2\u02C1\u02BA\u02BA\u02B7\u02B4\u02C0\u02B3\u02B9\u02B6\u02B5.Item1, \u02B2\u02C1\u02BA\u02BA\u02B7\u02B4\u02C0\u02B3\u02B9\u02B6\u02B5.Item2))
		{
			u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= \u02B8\u02B6\u02BD\u02BC\u02B6\u02B4\u02B3\u02B4\u02C1\u02C1\u02BF;
		}
	}

	public \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD(uint \u02B4\u02BC\u02B5\u02B9\u02B8\u02BB\u02B4\u02BB\u02BE\u02BC\u02BC, \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA \u02B2\u02B7\u02C1\u02B2\u02C1\u02B5\u02BC\u02BE\u02BD\u02B9\u02B7, uint \u02B9\u02C0\u02B2\u02BB\u02B6\u02BB\u02BE\u02C0\u02B2\u02BE\u02B5 = 0U, \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC \u02BA\u02BC\u02B9\u02B2\u02C1\u02BA\u02B5\u02BA\u02BE\u02C0\u02B7 = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.NONE)
		: base(\u02B4\u02BC\u02B5\u02B9\u02B8\u02BB\u02B4\u02BB\u02BE\u02BC\u02BC)
	{
		this.\u02B5\u02B9\u02C0\u02BD\u02BA\u02BC\u02C1\u02B4\u02BC\u02B5\u02BA = \u02B9\u02C0\u02B2\u02BB\u02B6\u02BB\u02BE\u02C0\u02B2\u02BE\u02B5;
		this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 = \u02BA\u02BC\u02B9\u02B2\u02C1\u02BA\u02B5\u02BA\u02BE\u02C0\u02B7;
		this.\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF = \u02B2\u02B7\u02C1\u02B2\u02C1\u02B5\u02BC\u02BE\u02BD\u02B9\u02B7;
		this.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC = null;
		this.\u02B8\u02BF\u02B9\u02C1\u02B4\u02C1\u02B7\u02B8\u02BC\u02BA\u02B7 = null;
	}

	public bool \u02BF\u02BE\u02B5\u02B3\u02C1\u02C1\u02B2\u02BF\u02B5\u02BB\u02B4
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.ACCENT) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.ACCENT;
		}
	}

	public void \u02B7\u02B2\u02B5\u02BB\u02B9\u02C1\u02BA\u02B4\u02B3\u02C0\u02C0(\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5)
	{
		this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.NONE;
		switch (\u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5)
		{
		case \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Strum:
			if (this.\u02C0\u02B7\u02BD\u02B9\u02B4\u02B9\u02BF\u02BA\u02BA\u02C0\u02B2)
			{
				this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 &= ~\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FORCED;
			}
			else if (this.\u02B7\u02B2\u02B9\u02B2\u02B3\u02C1\u02BB\u02B9\u02B7\u02B8\u02BC)
			{
				this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FORCED;
			}
			else
			{
				this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 &= ~\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FORCED;
			}
			break;
		case \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Hopo:
			if (!this.\u02B7\u02B3\u02BC\u02B3\u02BD\u02B5\u02BD\u02BE\u02C0\u02B4\u02B7)
			{
				if (this.\u02C0\u02B7\u02BD\u02B9\u02B4\u02B9\u02BF\u02BA\u02BA\u02C0\u02B2)
				{
					this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FORCED;
				}
				else if (!this.\u02B7\u02B2\u02B9\u02B2\u02B3\u02C1\u02BB\u02B9\u02B7\u02B8\u02BC)
				{
					this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FORCED;
				}
				else
				{
					this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 &= ~\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FORCED;
				}
			}
			break;
		case \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Tap:
			if (this.\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF != \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.OPEN)
			{
				this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.TAP;
			}
			break;
		case \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Drum:
			this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.TOM;
			break;
		}
		this.\u02B8\u02BB\u02B2\u02BD\u02B2\u02BC\u02B5\u02BA\u02B3\u02B3\u02C0();
	}

	public IEnumerable<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD> \u02B2\u02BE\u02BC\u02B2\u02BF\u02B7\u02BE\u02B4\u02C0\u02BD\u02C1()
	{
		return this.\u02B8\u02BE\u02BE\u02B9\u02B6\u02BA\u02BF\u02BD\u02C1\u02B3\u02B6(false);
	}

	public \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD \u02B5\u02BA\u02B6\u02BA\u02B6\u02BC\u02B9\u02C1\u02B7\u02B8\u02B3
	{
		get
		{
			if (this.\u02BF\u02B4\u02BD\u02C0\u02B5\u02B3\u02B8\u02B8\u02B8\u02BB\u02C0)
			{
				return this;
			}
			\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD = this;
			while (u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC != null && u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8 == this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8)
			{
				u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD = u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC;
			}
			return u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD;
		}
	}

	public \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5
	{
		get
		{
			if (this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Drums || this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.ProDrums)
			{
				return \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Drum;
			}
			if (this.\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF != \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.OPEN && (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.TAP) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.TAP)
			{
				return \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Tap;
			}
			if (!this.\u02C0\u02B9\u02BD\u02B8\u02B4\u02BB\u02B4\u02B9\u02B9\u02B6\u02BD)
			{
				return \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Strum;
			}
			return \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Hopo;
		}
	}

	public bool \u02BF\u02B4\u02BD\u02C0\u02B5\u02B3\u02B8\u02B8\u02B8\u02BB\u02C0
	{
		get
		{
			\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD = this.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC;
			for (;;)
			{
				uint u02B3_u02BF_u02B9_u02BA_u02B5_u02B9_u02B7_u02BC_u02BC_u02B8_u02B = this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8;
				uint? num = ((u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD != null) ? new uint?(u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8) : null);
				if (!((u02B3_u02BF_u02B9_u02BA_u02B5_u02B9_u02B7_u02BC_u02BC_u02B8_u02B == num.GetValueOrDefault()) & (num != null)))
				{
					goto Block_4;
				}
				if (this.\u02B5\u02B9\u02C0\u02BD\u02BA\u02BC\u02C1\u02B4\u02BC\u02B5\u02BA != u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02B5\u02B9\u02C0\u02BD\u02BA\u02BC\u02C1\u02B4\u02BC\u02B5\u02BA || this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Drums || this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.ProDrums)
				{
					break;
				}
				u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD = u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC;
			}
			return true;
			Block_4:
			\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD2 = this.\u02B8\u02BF\u02B9\u02C1\u02B4\u02C1\u02B7\u02B8\u02BC\u02BA\u02B7;
			for (;;)
			{
				uint u02B3_u02BF_u02B9_u02BA_u02B5_u02B9_u02B7_u02BC_u02BC_u02B8_u02B2 = this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8;
				uint? num = ((u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD2 != null) ? new uint?(u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD2.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8) : null);
				if (!((u02B3_u02BF_u02B9_u02BA_u02B5_u02B9_u02B7_u02BC_u02BC_u02B8_u02B2 == num.GetValueOrDefault()) & (num != null)))
				{
					return false;
				}
				if (this.\u02B5\u02B9\u02C0\u02BD\u02BA\u02BC\u02C1\u02B4\u02BC\u02B5\u02BA != u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD2.\u02B5\u02B9\u02C0\u02BD\u02BA\u02BC\u02C1\u02B4\u02BC\u02B5\u02BA || this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Drums || this.\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.ProDrums)
				{
					break;
				}
				u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD2 = u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD2.\u02B8\u02BF\u02B9\u02C1\u02B4\u02C1\u02B7\u02B8\u02BC\u02BA\u02B7;
			}
			return true;
		}
	}

	public bool \u02B4\u02BD\u02B3\u02BA\u02B6\u02C1\u02B8\u02C1\u02B4\u02B5\u02BA
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.DISCO) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.DISCO;
		}
	}

	private IEnumerable<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD> \u02B8\u02BE\u02BE\u02B9\u02B6\u02BA\u02BF\u02BD\u02C1\u02B3\u02B6(bool \u02B9\u02B3\u02B9\u02BB\u02B3\u02B4\u02BA\u02B3\u02BD\u02BA\u02B6)
	{
		if (!\u02B9\u02B3\u02B9\u02BB\u02B3\u02B4\u02BA\u02B3\u02BD\u02BA\u02B6 && this.\u02BF\u02B4\u02BD\u02C0\u02B5\u02B3\u02B8\u02B8\u02B8\u02BB\u02C0)
		{
			yield return this;
		}
		else
		{
			yield return this;
			\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD previousNote = this.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC;
			for (;;)
			{
				uint u02B3_u02BF_u02B9_u02BA_u02B5_u02B9_u02B7_u02BC_u02BC_u02B8_u02B = this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8;
				\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD = previousNote;
				uint? num = ((u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD != null) ? new uint?(u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8) : null);
				if (!((u02B3_u02BF_u02B9_u02BA_u02B5_u02B9_u02B7_u02BC_u02BC_u02B8_u02B == num.GetValueOrDefault()) & (num != null)))
				{
					break;
				}
				yield return previousNote;
				previousNote = previousNote.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC;
			}
			previousNote = null;
			previousNote = this.\u02B8\u02BF\u02B9\u02C1\u02B4\u02C1\u02B7\u02B8\u02BC\u02BA\u02B7;
			for (;;)
			{
				uint u02B3_u02BF_u02B9_u02BA_u02B5_u02B9_u02B7_u02BC_u02BC_u02B8_u02B2 = this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8;
				\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD2 = previousNote;
				uint? num = ((u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD2 != null) ? new uint?(u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD2.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8) : null);
				if (!((u02B3_u02BF_u02B9_u02BA_u02B5_u02B9_u02B7_u02BC_u02BC_u02B8_u02B2 == num.GetValueOrDefault()) & (num != null)))
				{
					break;
				}
				yield return previousNote;
				previousNote = previousNote.\u02B8\u02BF\u02B9\u02C1\u02B4\u02C1\u02B7\u02B8\u02BC\u02BA\u02B7;
			}
			previousNote = null;
		}
		yield break;
	}

	public uint \u02B5\u02B9\u02C0\u02BD\u02BA\u02BC\u02C1\u02B4\u02BC\u02B5\u02BA;

	public \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA \u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF;

	public \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC \u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0;

	public \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD \u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC;

	public \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD \u02B8\u02BF\u02B9\u02C1\u02B4\u02C1\u02B7\u02B8\u02BC\u02BA\u02B7;

	public enum \u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA
	{
		GREEN,
		RED,
		YELLOW,
		BLUE,
		ORANGE,
		OPEN,
		W1,
		W2,
		W3,
		B1,
		B2,
		B3,
		TOM_RED,
		TOM_YELLOW,
		TOM_BLUE,
		TOM_GREEN,
		KICK_ORANGE,
		DOUBLEKICK_ORANGE,
		CYM_YELLOW,
		CYM_BLUE,
		CYM_GREEN,
		FIVELANE_DRUM_GREEN,
		NONE = -782326291
	}

	public enum \u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA
	{
		Strum,
		Hopo,
		Tap,
		Drum
	}

	[Flags]
	public enum \u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC
	{
		NONE = 0,
		FORCED = 1,
		TAP = 2,
		TOM = 4,
		DISCO = 8,
		FLAM = 16,
		GHOST = 32,
		ACCENT = 64,
		CYMBAL = 128
	}
}
