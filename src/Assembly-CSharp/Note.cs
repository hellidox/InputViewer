﻿using System;

// Token: 0x02000149 RID: 329
public class Note : \u02B6\u02BC\u02C0\u02C1\u02B2\u02B4\u02BF\u02BE\u02B5\u02B2\u02BB
{
	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06000E8D RID: 3725 RVA: 0x0000DE89 File Offset: 0x0000C089
	public Note.\u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3 \u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2
	{
		get
		{
			return new Note.\u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3(this);
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x0000DF5D File Offset: 0x0000C15D
	// (set) Token: 0x06000E8E RID: 3726 RVA: 0x0000DE91 File Offset: 0x0000C091
	public bool \u02B6\u02B3\u02B9\u02B5\u02B6\u02B6\u02BF\u02B3\u02B9\u02BC\u02BA { get; set; }

	// Token: 0x06000E8F RID: 3727 RVA: 0x0007B394 File Offset: 0x00079594
	public Note(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5, float \u02BD\u02B9\u02B8\u02B2\u02C1\u02B4\u02B8\u02C0\u02B3\u02BB\u02BC, ushort \u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB, \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA \u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA, Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF \u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0, uint \u02C1\u02B5\u02B8\u02BC\u02BA\u02B3\u02BE\u02BD\u02BE\u02B4\u02BD, int \u02BD\u02C0\u02BA\u02BB\u02BA\u02BE\u02BD\u02B4\u02BB\u02BD\u02C0)
	{
		this.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 = \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5;
		this.\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD = \u02BD\u02B9\u02B8\u02B2\u02C1\u02B4\u02B8\u02C0\u02B3\u02BB\u02BC;
		this.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = \u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB;
		this.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA = \u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA;
		this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 = \u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0;
		this.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE = \u02C1\u02B5\u02B8\u02BC\u02BA\u02B3\u02BE\u02BD\u02BE\u02B4\u02BD;
		this.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 = \u02BD\u02C0\u02BA\u02BB\u02BA\u02BE\u02BD\u02B4\u02BB\u02BD\u02C0;
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000E90 RID: 3728 RVA: 0x0000DE9A File Offset: 0x0000C09A
	public float \u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0
	{
		get
		{
			return this.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 + this.\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD;
		}
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x0000DFC5 File Offset: 0x0000C1C5
	// (set) Token: 0x06000E91 RID: 3729 RVA: 0x0000DEA9 File Offset: 0x0000C0A9
	public float \u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 { get; set; }

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0000DEB2 File Offset: 0x0000C0B2
	public bool \u02B7\u02C0\u02BE\u02C0\u02B6\u02BF\u02BC\u02C1\u02BA\u02BF\u02BE
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.STAR_POWER) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000E93 RID: 3731 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
	// (set) Token: 0x06000E94 RID: 3732 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
	public ushort \u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF { get; set; }

	// Token: 0x06000E95 RID: 3733 RVA: 0x0000DED1 File Offset: 0x0000C0D1
	public bool \u02BC\u02BF\u02B9\u02B8\u02B4\u02BE\u02BA\u02BB\u02B9\u02BC\u02B4()
	{
		return !this.\u02BF\u02BF\u02B7\u02BE\u02B9\u02BC\u02B8\u02B7\u02C0\u02BC\u02B4 && this.\u02C1\u02BC\u02B2\u02C1\u02BC\u02B8\u02B2\u02BA\u02C1\u02B9\u02C0;
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0007B3E4 File Offset: 0x000795E4
	public int \u02C1\u02B7\u02B6\u02BF\u02B9\u02BB\u02B8\u02BD\u02B9\u02B8\u02B3
	{
		get
		{
			int num = 0;
			Note.\u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3 u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B = this.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
			while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
			{
				u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
				num++;
			}
			return num;
		}
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x0000DEE3 File Offset: 0x0000C0E3
	public bool \u02B7\u02B4\u02BC\u02BD\u02B7\u02BF\u02B9\u02BA\u02C0\u02B2\u02BC()
	{
		return (this.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & 61) > 1;
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0000DEF1 File Offset: 0x0000C0F1
	public bool \u02BC\u02BF\u02B7\u02B2\u02C0\u02C1\u02BD\u02BC\u02B9\u02B4\u02B8
	{
		get
		{
			return (this.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & 112) > 0;
		}
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x0000DED1 File Offset: 0x0000C0D1
	public bool \u02C0\u02B5\u02BE\u02B7\u02B5\u02B3\u02C0\u02BF\u02BF\u02B9\u02BC()
	{
		return !this.\u02BF\u02BF\u02B7\u02BE\u02B9\u02BC\u02B8\u02B7\u02C0\u02BC\u02B4 && this.\u02C1\u02BC\u02B2\u02C1\u02BC\u02B8\u02B2\u02BA\u02C1\u02B9\u02C0;
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x0000DEFF File Offset: 0x0000C0FF
	public bool \u02BD\u02B9\u02B7\u02C1\u02BC\u02BE\u02BC\u02B8\u02BB\u02B5\u02B7()
	{
		return this.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Strum;
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06000E9B RID: 3739 RVA: 0x0000DF0A File Offset: 0x0000C10A
	public bool \u02B5\u02BC\u02BE\u02BF\u02B6\u02B7\u02B3\u02B9\u02BF\u02B5\u02BE
	{
		get
		{
			return this.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Tap;
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0000DF15 File Offset: 0x0000C115
	public bool \u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.EXTENDED_SUSTAIN) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000E9D RID: 3741 RVA: 0x0000DF22 File Offset: 0x0000C122
	public bool \u02C0\u02B9\u02BD\u02B8\u02B4\u02BB\u02B4\u02B9\u02B9\u02B6\u02BD
	{
		get
		{
			return this.\u02C0\u02BF\u02B6\u02B4\u02BC\u02BD\u02BD\u02B6\u02C0\u02B3\u02BF || this.\u02B5\u02BC\u02BE\u02BF\u02B6\u02B7\u02B3\u02B9\u02BF\u02B5\u02BE;
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06000E9E RID: 3742 RVA: 0x0000DF34 File Offset: 0x0000C134
	public bool \u02C1\u02BC\u02B9\u02BF\u02B9\u02C1\u02B4\u02B8\u02BD\u02B8\u02B9
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.SOLO_END) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000E9F RID: 3743 RVA: 0x0000DF45 File Offset: 0x0000C145
	public bool \u02BF\u02B4\u02BD\u02C0\u02B5\u02B3\u02B8\u02B8\u02B8\u02BB\u02C0
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DISJOINT) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x0000DF52 File Offset: 0x0000C152
	public bool \u02BB\u02B2\u02B8\u02BB\u02C0\u02BC\u02BE\u02B2\u02B7\u02BA\u02BF()
	{
		return this.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Hopo;
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0000DF52 File Offset: 0x0000C152
	public bool \u02C0\u02BF\u02B6\u02B4\u02BC\u02BD\u02BD\u02B6\u02C0\u02B3\u02BF
	{
		get
		{
			return this.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Hopo;
		}
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x0000DF65 File Offset: 0x0000C165
	public bool \u02BF\u02B3\u02BC\u02BD\u02BD\u02C1\u02BE\u02BE\u02B2\u02B4\u02BD
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUMS_TOM) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0000DF76 File Offset: 0x0000C176
	public bool \u02B5\u02C0\u02B3\u02C0\u02B6\u02B5\u02B8\u02BD\u02B6\u02B4\u02B4
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.SLAVE) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x0000DF83 File Offset: 0x0000C183
	public bool \u02BF\u02BE\u02B5\u02B3\u02C1\u02C1\u02B2\u02BF\u02B5\u02BB\u02B4
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUMS_ACCENT) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x0000DF94 File Offset: 0x0000C194
	public bool \u02BC\u02B9\u02B4\u02B6\u02B5\u02BC\u02BB\u02BC\u02BB\u02B4\u02B7
	{
		get
		{
			return this.\u02BF\u02BF\u02B7\u02BE\u02B9\u02BC\u02B8\u02B7\u02C0\u02BC\u02B4 || this.\u02C1\u02BC\u02B2\u02C1\u02BC\u02B8\u02B2\u02BA\u02C1\u02B9\u02C0;
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x0000DFA6 File Offset: 0x0000C1A6
	public bool \u02BF\u02B3\u02BD\u02BF\u02BB\u02B6\u02B8\u02B5\u02B2\u02BC\u02B7
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUMS_SNARE) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x0000DFB7 File Offset: 0x0000C1B7
	public bool \u02B3\u02B7\u02BD\u02B2\u02B9\u02C1\u02B6\u02C0\u02B6\u02B4\u02B2
	{
		get
		{
			return (this.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & 15) > 0;
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0007B41C File Offset: 0x0007961C
	public ushort \u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3
	{
		get
		{
			ushort num = 0;
			Note.\u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3 u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B = this.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
			while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
			{
				Note note = u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
				num |= note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
			}
			return num;
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06000EAB RID: 3755 RVA: 0x0000DFCD File Offset: 0x0000C1CD
	public bool \u02BD\u02BA\u02C0\u02BA\u02BC\u02BA\u02B6\u02B4\u02BF\u02B3\u02B7
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUMS_CYMBAL) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0000DFDE File Offset: 0x0000C1DE
	// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x0000E053 File Offset: 0x0000C253
	public float \u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD { get; set; }

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0000DFE6 File Offset: 0x0000C1E6
	public bool \u02BD\u02BE\u02BC\u02B8\u02BC\u02B2\u02B4\u02B4\u02BA\u02BF\u02B6
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUMS_GHOST) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0000E024 File Offset: 0x0000C224
	// (set) Token: 0x06000EAE RID: 3758 RVA: 0x0000DFF7 File Offset: 0x0000C1F7
	public uint \u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE { get; set; }

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06000EAF RID: 3759 RVA: 0x0000E000 File Offset: 0x0000C200
	public bool \u02C0\u02B7\u02BD\u02B9\u02B4\u02B9\u02BF\u02BA\u02BA\u02C0\u02B2
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.CHORD) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0000E00D File Offset: 0x0000C20D
	public bool \u02B5\u02B7\u02BB\u02B7\u02BA\u02B3\u02B2\u02B7\u02C1\u02B3\u02B4
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.STAR_POWER_END) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0000E04B File Offset: 0x0000C24B
	// (set) Token: 0x06000EB1 RID: 3761 RVA: 0x0000E01B File Offset: 0x0000C21B
	public int \u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 { get; set; }

	// Token: 0x06000EB2 RID: 3762 RVA: 0x0007B458 File Offset: 0x00079658
	public Note(Note \u02B9\u02B3\u02BF\u02B9\u02B2\u02B3\u02C1\u02BE\u02BB\u02BD\u02C1)
	{
		this.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 = \u02B9\u02B3\u02BF\u02B9\u02B2\u02B3\u02C1\u02BE\u02BB\u02BD\u02C1.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1;
		this.\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD = \u02B9\u02B3\u02BF\u02B9\u02B2\u02B3\u02C1\u02BE\u02BB\u02BD\u02C1.\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD;
		this.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF = \u02B9\u02B3\u02BF\u02B9\u02B2\u02B3\u02C1\u02BE\u02BB\u02BD\u02C1.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
		this.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA = \u02B9\u02B3\u02BF\u02B9\u02B2\u02B3\u02C1\u02BE\u02BB\u02BD\u02C1.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA;
		this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 = \u02B9\u02B3\u02BF\u02B9\u02B2\u02B3\u02C1\u02BE\u02BB\u02BD\u02C1.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0;
		this.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE = \u02B9\u02B3\u02BF\u02B9\u02B2\u02B3\u02C1\u02BE\u02BB\u02BD\u02C1.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE;
		this.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 = \u02B9\u02B3\u02BF\u02B9\u02B2\u02B3\u02C1\u02BE\u02BB\u02BD\u02C1.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2;
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x0000DEFF File Offset: 0x0000C0FF
	public bool \u02B8\u02C1\u02BA\u02B2\u02BC\u02B6\u02C0\u02BD\u02BD\u02BA\u02BE
	{
		get
		{
			return this.\u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Strum;
		}
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x0000DFDE File Offset: 0x0000C1DE
	public float \u02B6\u02BA\u02BD\u02B5\u02B8\u02BC\u02B8\u02B9\u02B4\u02BD\u02C1()
	{
		return this.<\u02B2\u02BE\u02C1\u02B8\u02C1\u02BE\u02B8\u02BC\u02C1\u02B8\u02B3>k__BackingField;
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0000E02C File Offset: 0x0000C22C
	public bool \u02C1\u02BE\u02B9\u02BE\u02B9\u02B8\u02B8\u02B3\u02B7\u02B9\u02B9
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.DRUM_ACTIVATION) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0000E03D File Offset: 0x0000C23D
	public bool \u02BF\u02B5\u02C1\u02C0\u02BA\u02BD\u02BB\u02B5\u02BA\u02C1\u02C0
	{
		get
		{
			return (this.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.SOLO_BEGIN) > Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE;
		}
	}

	// Token: 0x040009F8 RID: 2552
	public int \u02BD\u02B7\u02BA\u02C1\u02B9\u02B9\u02B9\u02B7\u02B7\u02B6\u02BD = -1;

	// Token: 0x040009FF RID: 2559
	public Note \u02BF\u02BB\u02B7\u02BA\u02BA\u02BB\u02C0\u02BF\u02B8\u02B4\u02B3;

	// Token: 0x04000A00 RID: 2560
	public Note \u02B7\u02C1\u02BF\u02B4\u02BD\u02B7\u02BE\u02B3\u02BA\u02C0\u02B4;

	// Token: 0x04000A01 RID: 2561
	public bool \u02BF\u02BF\u02B7\u02BE\u02B9\u02BC\u02B8\u02B7\u02C0\u02BC\u02B4;

	// Token: 0x04000A02 RID: 2562
	public bool \u02C1\u02BC\u02B2\u02C1\u02BC\u02B8\u02B2\u02BA\u02C1\u02B9\u02C0;

	// Token: 0x04000A03 RID: 2563
	public bool \u02B9\u02B8\u02C0\u02BB\u02B5\u02B9\u02BC\u02BF\u02BD\u02BD\u02BA;

	// Token: 0x04000A04 RID: 2564
	public bool \u02C1\u02B9\u02BD\u02B6\u02B7\u02BA\u02B5\u02B7\u02BA\u02B6\u02C0;

	// Token: 0x04000A05 RID: 2565
	public bool \u02C1\u02B8\u02B6\u02B6\u02BF\u02BF\u02BD\u02BF\u02B4\u02B6\u02C0;

	// Token: 0x04000A06 RID: 2566
	public \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA \u02BA\u02C1\u02BC\u02B7\u02B7\u02B8\u02B9\u02BB\u02BD\u02BB\u02BA;

	// Token: 0x04000A07 RID: 2567
	public Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF \u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0;

	// Token: 0x0200014A RID: 330
	[Flags]
	public enum \u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF : uint
	{
		// Token: 0x04000A09 RID: 2569
		NONE = 0U,
		// Token: 0x04000A0A RID: 2570
		CHORD = 1U,
		// Token: 0x04000A0B RID: 2571
		DISJOINT = 2U,
		// Token: 0x04000A0C RID: 2572
		SLAVE = 4U,
		// Token: 0x04000A0D RID: 2573
		EXTENDED_SUSTAIN = 8U,
		// Token: 0x04000A0E RID: 2574
		STAR_POWER = 16U,
		// Token: 0x04000A0F RID: 2575
		STAR_POWER_END = 32U,
		// Token: 0x04000A10 RID: 2576
		SOLO_BEGIN = 64U,
		// Token: 0x04000A11 RID: 2577
		SOLO_END = 128U,
		// Token: 0x04000A12 RID: 2578
		DRUM_ACTIVATION = 256U,
		// Token: 0x04000A13 RID: 2579
		DRUMS_DISCO = 512U,
		// Token: 0x04000A14 RID: 2580
		DRUMS_LANE = 1024U,
		// Token: 0x04000A15 RID: 2581
		DRUMS_LANE_DOUBLE = 2048U,
		// Token: 0x04000A16 RID: 2582
		DRUMS_LANE_END = 4096U,
		// Token: 0x04000A17 RID: 2583
		DRUMS_FLAM = 8192U,
		// Token: 0x04000A18 RID: 2584
		DRUMS_GHOST = 16384U,
		// Token: 0x04000A19 RID: 2585
		DRUMS_ACCENT = 32768U,
		// Token: 0x04000A1A RID: 2586
		DRUMS_CYMBAL = 65536U,
		// Token: 0x04000A1B RID: 2587
		DRUMS_TOM = 131072U,
		// Token: 0x04000A1C RID: 2588
		DRUMS_SNARE = 262144U
	}

	// Token: 0x0200014B RID: 331
	[Flags]
	public enum \u02BE\u02BA\u02B8\u02BB\u02BC\u02B2\u02C0\u02C0\u02BD\u02B5\u02BD : ushort
	{
		// Token: 0x04000A1E RID: 2590
		None = 0,
		// Token: 0x04000A1F RID: 2591
		TomRed = 1,
		// Token: 0x04000A20 RID: 2592
		TomYellow = 2,
		// Token: 0x04000A21 RID: 2593
		TomBlue = 4,
		// Token: 0x04000A22 RID: 2594
		TomGreen = 8,
		// Token: 0x04000A23 RID: 2595
		CymbalYellow = 16,
		// Token: 0x04000A24 RID: 2596
		CymbalBlue = 32,
		// Token: 0x04000A25 RID: 2597
		CymbalGreen = 64,
		// Token: 0x04000A26 RID: 2598
		KickOrange = 128,
		// Token: 0x04000A27 RID: 2599
		DoubleKickOrange = 256,
		// Token: 0x04000A28 RID: 2600
		FiveLaneGreen = 512
	}

	// Token: 0x0200014C RID: 332
	[Flags]
	public enum \u02B2\u02B9\u02C0\u02B4\u02B4\u02B8\u02BA\u02B3\u02BC\u02C0\u02B9 : ushort
	{
		// Token: 0x04000A2A RID: 2602
		None = 0,
		// Token: 0x04000A2B RID: 2603
		B1 = 1,
		// Token: 0x04000A2C RID: 2604
		B2 = 2,
		// Token: 0x04000A2D RID: 2605
		B3 = 4,
		// Token: 0x04000A2E RID: 2606
		W1 = 8,
		// Token: 0x04000A2F RID: 2607
		W2 = 16,
		// Token: 0x04000A30 RID: 2608
		W3 = 32,
		// Token: 0x04000A31 RID: 2609
		Open = 64
	}

	// Token: 0x0200014D RID: 333
	[Flags]
	public enum \u02B5\u02B8\u02B9\u02B2\u02BC\u02BB\u02BE\u02B8\u02B5\u02C1\u02BC
	{
		// Token: 0x04000A33 RID: 2611
		Lane1 = 1,
		// Token: 0x04000A34 RID: 2612
		Lane2 = 2,
		// Token: 0x04000A35 RID: 2613
		Lane3 = 4,
		// Token: 0x04000A36 RID: 2614
		OpenLane = 8
	}

	// Token: 0x0200014E RID: 334
	public struct \u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3
	{
		// Token: 0x06000EBA RID: 3770 RVA: 0x0000E05C File Offset: 0x0000C25C
		public \u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3(Note \u02BE\u02BE\u02B6\u02B5\u02BF\u02BF\u02BA\u02BA\u02B9\u02BC\u02BD)
		{
			this.\u02BE\u02B8\u02B5\u02BC\u02B3\u02BD\u02B6\u02BE\u02BF\u02B5\u02B9 = \u02BE\u02BE\u02B6\u02B5\u02BF\u02BF\u02BA\u02BA\u02B9\u02BC\u02BD;
			this.\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4 = this.\u02BE\u02B8\u02B5\u02BC\u02B3\u02BD\u02B6\u02BE\u02BF\u02B5\u02B9;
			this.\u02B4\u02BB\u02BD\u02B4\u02BA\u02BE\u02BF\u02BE\u02BA\u02B3\u02B5 = false;
			this.\u02BD\u02B5\u02BC\u02BC\u02B6\u02C1\u02B7\u02C0\u02B2\u02BA\u02B9 = false;
			this.\u02BD\u02BB\u02BE\u02BF\u02BF\u02BE\u02BF\u02BC\u02B9\u02BD\u02BC = false;
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0000E086 File Offset: 0x0000C286
		public Note.\u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3 \u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1()
		{
			return this;
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0007B4C8 File Offset: 0x000796C8
		public bool \u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC()
		{
			if (!this.\u02B4\u02BB\u02BD\u02B4\u02BA\u02BE\u02BF\u02BE\u02BA\u02B3\u02B5 && !this.\u02BD\u02B5\u02BC\u02BC\u02B6\u02C1\u02B7\u02C0\u02B2\u02BA\u02B9 && !this.\u02BD\u02BB\u02BE\u02BF\u02BF\u02BE\u02BF\u02BC\u02B9\u02BD\u02BC)
			{
				this.\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4 = this.\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4.\u02B7\u02C1\u02BF\u02B4\u02BD\u02B7\u02BE\u02B3\u02BA\u02C0\u02B4;
				if (this.\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4 != null)
				{
					return true;
				}
				this.\u02B4\u02BB\u02BD\u02B4\u02BA\u02BE\u02BF\u02BE\u02BA\u02B3\u02B5 = true;
				this.\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4 = this.\u02BE\u02B8\u02B5\u02BC\u02B3\u02BD\u02B6\u02BE\u02BF\u02B5\u02B9;
			}
			if (!this.\u02BD\u02B5\u02BC\u02BC\u02B6\u02C1\u02B7\u02C0\u02B2\u02BA\u02B9 && this.\u02B4\u02BB\u02BD\u02B4\u02BA\u02BE\u02BF\u02BE\u02BA\u02B3\u02B5 && !this.\u02BD\u02B5\u02BC\u02BC\u02B6\u02C1\u02B7\u02C0\u02B2\u02BA\u02B9)
			{
				this.\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4 = this.\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4.\u02BF\u02BB\u02B7\u02BA\u02BA\u02BB\u02C0\u02BF\u02B8\u02B4\u02B3;
				if (this.\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4 != null)
				{
					return true;
				}
				this.\u02BD\u02B5\u02BC\u02BC\u02B6\u02C1\u02B7\u02C0\u02B2\u02BA\u02B9 = true;
				this.\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4 = this.\u02BE\u02B8\u02B5\u02BC\u02B3\u02BD\u02B6\u02BE\u02BF\u02B5\u02B9;
			}
			if (this.\u02B4\u02BB\u02BD\u02B4\u02BA\u02BE\u02BF\u02BE\u02BA\u02B3\u02B5 && this.\u02BD\u02B5\u02BC\u02BC\u02B6\u02C1\u02B7\u02C0\u02B2\u02BA\u02B9 && !this.\u02BD\u02BB\u02BE\u02BF\u02BF\u02BE\u02BF\u02BC\u02B9\u02BD\u02BC && this.\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4 != null)
			{
				this.\u02BD\u02BB\u02BE\u02BF\u02BF\u02BE\u02BF\u02BC\u02B9\u02BD\u02BC = true;
				return true;
			}
			return false;
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x0000E08E File Offset: 0x0000C28E
		public Note \u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF
		{
			get
			{
				return this.\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4;
			}
		}

		// Token: 0x04000A37 RID: 2615
		private readonly Note \u02BE\u02B8\u02B5\u02BC\u02B3\u02BD\u02B6\u02BE\u02BF\u02B5\u02B9;

		// Token: 0x04000A38 RID: 2616
		private Note \u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4;

		// Token: 0x04000A39 RID: 2617
		private bool \u02B4\u02BB\u02BD\u02B4\u02BA\u02BE\u02BF\u02BE\u02BA\u02B3\u02B5;

		// Token: 0x04000A3A RID: 2618
		private bool \u02BD\u02B5\u02BC\u02BC\u02B6\u02C1\u02B7\u02C0\u02B2\u02BA\u02B9;

		// Token: 0x04000A3B RID: 2619
		private bool \u02BD\u02BB\u02BE\u02BF\u02BF\u02BE\u02BF\u02BC\u02B9\u02BD\u02BC;
	}
}
