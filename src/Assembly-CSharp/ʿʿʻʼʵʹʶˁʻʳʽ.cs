﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StrikeCore;
using UnityEngine;

// Token: 0x02000229 RID: 553
public class \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD : \u02BA\u02B8\u02B8\u02BD\u02BF\u02BE\u02B6\u02BD\u02BB\u02B9\u02B5
{
	// Token: 0x1700025A RID: 602
	// (get) Token: 0x06001891 RID: 6289 RVA: 0x00012BBE File Offset: 0x00010DBE
	public bool \u02BA\u02B3\u02C0\u02B9\u02BC\u02B3\u02BE\u02B3\u02B8\u02B3\u02BB
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FORCED) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FORCED;
		}
	}

	// Token: 0x17000262 RID: 610
	// (get) Token: 0x06001892 RID: 6290 RVA: 0x000B5414 File Offset: 0x000B3614
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

	// Token: 0x06001893 RID: 6291 RVA: 0x000B5448 File Offset: 0x000B3648
	public void \u02B8\u02BB\u02B2\u02BD\u02B2\u02BC\u02B5\u02BA\u02B3\u02B3\u02C0()
	{
		foreach (\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD in this.\u02BF\u02BF\u02BD\u02B3\u02B6\u02BA\u02B4\u02B5\u02C0\u02BF\u02BC())
		{
			u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 = this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0;
		}
	}

	// Token: 0x1700025F RID: 607
	// (get) Token: 0x06001894 RID: 6292 RVA: 0x000B5498 File Offset: 0x000B3698
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

	// Token: 0x17000259 RID: 601
	// (get) Token: 0x06001895 RID: 6293 RVA: 0x00012BCB File Offset: 0x00010DCB
	public bool \u02B3\u02B7\u02BD\u02B2\u02B9\u02C1\u02B6\u02C0\u02B6\u02B4\u02B2
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.TOM) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.TOM;
		}
	}

	// Token: 0x17000255 RID: 597
	// (get) Token: 0x06001896 RID: 6294 RVA: 0x00012BD8 File Offset: 0x00010DD8
	public bool \u02C0\u02BE\u02B4\u02BB\u02BC\u02B7\u02B8\u02B9\u02BE\u02B5\u02B2
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FLAM) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FLAM;
		}
	}

	// Token: 0x1700025E RID: 606
	// (get) Token: 0x06001897 RID: 6295 RVA: 0x00012BE7 File Offset: 0x00010DE7
	private bool \u02C0\u02B9\u02BD\u02B8\u02B4\u02BB\u02B4\u02B9\u02B9\u02B6\u02BD
	{
		get
		{
			return this.\u02B7\u02B2\u02B9\u02B2\u02B3\u02C1\u02BB\u02B9\u02B7\u02B8\u02BC ^ this.\u02BA\u02B3\u02C0\u02B9\u02BC\u02B3\u02BE\u02B3\u02B8\u02B3\u02BB;
		}
	}

	// Token: 0x17000258 RID: 600
	// (get) Token: 0x06001898 RID: 6296 RVA: 0x00012BF6 File Offset: 0x00010DF6
	public bool \u02BC\u02BF\u02B7\u02B2\u02C0\u02C1\u02BD\u02BC\u02B9\u02B4\u02B8
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.CYMBAL) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.CYMBAL;
		}
	}

	// Token: 0x1700025D RID: 605
	// (get) Token: 0x06001899 RID: 6297 RVA: 0x000B54F0 File Offset: 0x000B36F0
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

	// Token: 0x1700025C RID: 604
	// (get) Token: 0x0600189A RID: 6298 RVA: 0x000B5634 File Offset: 0x000B3834
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

	// Token: 0x17000256 RID: 598
	// (get) Token: 0x0600189B RID: 6299 RVA: 0x00012C0B File Offset: 0x00010E0B
	public bool \u02BD\u02BE\u02BC\u02B8\u02BC\u02B2\u02B4\u02B4\u02BA\u02BF\u02B6
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.GHOST) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.GHOST;
		}
	}

	// Token: 0x0600189C RID: 6300 RVA: 0x00012C1A File Offset: 0x00010E1A
	public IEnumerable<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD> \u02BF\u02BF\u02BD\u02B3\u02B6\u02BA\u02B4\u02B5\u02C0\u02BF\u02BC()
	{
		return this.\u02B8\u02BE\u02BE\u02B9\u02B6\u02BA\u02BF\u02BD\u02C1\u02B3\u02B6(true);
	}

	// Token: 0x0600189D RID: 6301 RVA: 0x000B56B8 File Offset: 0x000B38B8
	public static void \u02B4\u02B3\u02B3\u02BC\u02B8\u02BC\u02BB\u02B9\u02B6\u02BE\u02BD(List<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, [TupleElementNames(new string[] { "minIndex", "maxIndex" })] ValueTuple<int, int> \u02B2\u02C1\u02BA\u02BA\u02B7\u02B4\u02C0\u02B3\u02B9\u02B6\u02B5, \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC \u02B8\u02B6\u02BD\u02BC\u02B6\u02B4\u02B3\u02B4\u02C1\u02C1\u02BF)
	{
		foreach (\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD in EnumerableRanges.EnumerateRange<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD>(\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, \u02B2\u02C1\u02BA\u02BA\u02B7\u02B4\u02C0\u02B3\u02B9\u02B6\u02B5.Item1, \u02B2\u02C1\u02BA\u02BA\u02B7\u02B4\u02C0\u02B3\u02B9\u02B6\u02B5.Item2))
		{
			u02BF_u02BF_u02BB_u02BC_u02B5_u02B9_u02B6_u02C1_u02BB_u02B3_u02BD.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= \u02B8\u02B6\u02BD\u02BC\u02B6\u02B4\u02B3\u02B4\u02C1\u02C1\u02BF;
		}
	}

	// Token: 0x0600189E RID: 6302 RVA: 0x00012C23 File Offset: 0x00010E23
	public \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD(uint \u02B4\u02BC\u02B5\u02B9\u02B8\u02BB\u02B4\u02BB\u02BE\u02BC\u02BC, \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA \u02B2\u02B7\u02C1\u02B2\u02C1\u02B5\u02BC\u02BE\u02BD\u02B9\u02B7, uint \u02B9\u02C0\u02B2\u02BB\u02B6\u02BB\u02BE\u02C0\u02B2\u02BE\u02B5 = 0U, \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC \u02BA\u02BC\u02B9\u02B2\u02C1\u02BA\u02B5\u02BA\u02BE\u02C0\u02B7 = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.NONE)
		: base(\u02B4\u02BC\u02B5\u02B9\u02B8\u02BB\u02B4\u02BB\u02BE\u02BC\u02BC)
	{
		this.\u02B5\u02B9\u02C0\u02BD\u02BA\u02BC\u02C1\u02B4\u02BC\u02B5\u02BA = \u02B9\u02C0\u02B2\u02BB\u02B6\u02BB\u02BE\u02C0\u02B2\u02BE\u02B5;
		this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 = \u02BA\u02BC\u02B9\u02B2\u02C1\u02BA\u02B5\u02BA\u02BE\u02C0\u02B7;
		this.\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF = \u02B2\u02B7\u02C1\u02B2\u02C1\u02B5\u02BC\u02BE\u02BD\u02B9\u02B7;
		this.\u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC = null;
		this.\u02B8\u02BF\u02B9\u02C1\u02B4\u02C1\u02B7\u02B8\u02BC\u02BA\u02B7 = null;
	}

	// Token: 0x17000257 RID: 599
	// (get) Token: 0x0600189F RID: 6303 RVA: 0x00012C50 File Offset: 0x00010E50
	public bool \u02BF\u02BE\u02B5\u02B3\u02C1\u02C1\u02B2\u02BF\u02B5\u02BB\u02B4
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.ACCENT) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.ACCENT;
		}
	}

	// Token: 0x060018A0 RID: 6304 RVA: 0x000B5700 File Offset: 0x000B3900
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

	// Token: 0x060018A1 RID: 6305 RVA: 0x00012C5F File Offset: 0x00010E5F
	public IEnumerable<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD> \u02B2\u02BE\u02BC\u02B2\u02BF\u02B7\u02BE\u02B4\u02C0\u02BD\u02C1()
	{
		return this.\u02B8\u02BE\u02BE\u02B9\u02B6\u02BA\u02BF\u02BD\u02C1\u02B3\u02B6(false);
	}

	// Token: 0x1700025B RID: 603
	// (get) Token: 0x060018A2 RID: 6306 RVA: 0x000B57F0 File Offset: 0x000B39F0
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

	// Token: 0x17000260 RID: 608
	// (get) Token: 0x060018A3 RID: 6307 RVA: 0x000B5830 File Offset: 0x000B3A30
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

	// Token: 0x17000261 RID: 609
	// (get) Token: 0x060018A4 RID: 6308 RVA: 0x000B5880 File Offset: 0x000B3A80
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

	// Token: 0x17000254 RID: 596
	// (get) Token: 0x060018A5 RID: 6309 RVA: 0x00012C68 File Offset: 0x00010E68
	public bool \u02B4\u02BD\u02B3\u02BA\u02B6\u02C1\u02B8\u02C1\u02B4\u02B5\u02BA
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.DISCO) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.DISCO;
		}
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x00012C75 File Offset: 0x00010E75
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

	// Token: 0x04001145 RID: 4421
	public uint \u02B5\u02B9\u02C0\u02BD\u02BA\u02BC\u02C1\u02B4\u02BC\u02B5\u02BA;

	// Token: 0x04001146 RID: 4422
	public \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA \u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF;

	// Token: 0x04001147 RID: 4423
	public \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC \u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0;

	// Token: 0x04001148 RID: 4424
	public \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD \u02C1\u02C0\u02C1\u02BC\u02BD\u02B8\u02BC\u02B3\u02BE\u02B9\u02BC;

	// Token: 0x04001149 RID: 4425
	public \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD \u02B8\u02BF\u02B9\u02C1\u02B4\u02C1\u02B7\u02B8\u02BC\u02BA\u02B7;

	// Token: 0x0200022A RID: 554
	public enum \u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA
	{
		// Token: 0x0400114B RID: 4427
		GREEN,
		// Token: 0x0400114C RID: 4428
		RED,
		// Token: 0x0400114D RID: 4429
		YELLOW,
		// Token: 0x0400114E RID: 4430
		BLUE,
		// Token: 0x0400114F RID: 4431
		ORANGE,
		// Token: 0x04001150 RID: 4432
		OPEN,
		// Token: 0x04001151 RID: 4433
		W1,
		// Token: 0x04001152 RID: 4434
		W2,
		// Token: 0x04001153 RID: 4435
		W3,
		// Token: 0x04001154 RID: 4436
		B1,
		// Token: 0x04001155 RID: 4437
		B2,
		// Token: 0x04001156 RID: 4438
		B3,
		// Token: 0x04001157 RID: 4439
		TOM_RED,
		// Token: 0x04001158 RID: 4440
		TOM_YELLOW,
		// Token: 0x04001159 RID: 4441
		TOM_BLUE,
		// Token: 0x0400115A RID: 4442
		TOM_GREEN,
		// Token: 0x0400115B RID: 4443
		KICK_ORANGE,
		// Token: 0x0400115C RID: 4444
		DOUBLEKICK_ORANGE,
		// Token: 0x0400115D RID: 4445
		CYM_YELLOW,
		// Token: 0x0400115E RID: 4446
		CYM_BLUE,
		// Token: 0x0400115F RID: 4447
		CYM_GREEN,
		// Token: 0x04001160 RID: 4448
		FIVELANE_DRUM_GREEN,
		// Token: 0x04001161 RID: 4449
		NONE = -782326291
	}

	// Token: 0x0200022B RID: 555
	public enum \u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA
	{
		// Token: 0x04001163 RID: 4451
		Strum,
		// Token: 0x04001164 RID: 4452
		Hopo,
		// Token: 0x04001165 RID: 4453
		Tap,
		// Token: 0x04001166 RID: 4454
		Drum
	}

	// Token: 0x0200022C RID: 556
	[Flags]
	public enum \u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC
	{
		// Token: 0x04001168 RID: 4456
		NONE = 0,
		// Token: 0x04001169 RID: 4457
		FORCED = 1,
		// Token: 0x0400116A RID: 4458
		TAP = 2,
		// Token: 0x0400116B RID: 4459
		TOM = 4,
		// Token: 0x0400116C RID: 4460
		DISCO = 8,
		// Token: 0x0400116D RID: 4461
		FLAM = 16,
		// Token: 0x0400116E RID: 4462
		GHOST = 32,
		// Token: 0x0400116F RID: 4463
		ACCENT = 64,
		// Token: 0x04001170 RID: 4464
		CYMBAL = 128
	}
}
