using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x020001AF RID: 431
public class \u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8
{
	// Token: 0x06001333 RID: 4915 RVA: 0x0009C2F8 File Offset: 0x0009A4F8
	public void \u02B9\u02BD\u02B9\u02BE\u02BD\u02C1\u02BC\u02BA\u02B7\u02B7\u02B7()
	{
		if (SettingsController.\u02BE\u02B7\u02B8\u02B7\u02B3\u02B5\u02BF\u02BD\u02B6\u02B2\u02B5)
		{
			return;
		}
		int num = this.\u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD.LastIndexOf(Path.DirectorySeparatorChar);
		if (num != -1)
		{
			this.\u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD = this.\u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD.Remove(0, num + 1);
		}
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x0001009D File Offset: 0x0000E29D
	public string \u02B8\u02BD\u02B5\u02BB\u02BC\u02B7\u02BE\u02C0\u02BD\u02BA\u02B5()
	{
		return this.<\u02BA\u02BA\u02B2\u02B9\u02B6\u02B9\u02BC\u02B6\u02B9\u02BB\u02BE>k__BackingField;
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x000100A5 File Offset: 0x0000E2A5
	public \u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		this.\u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD = \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;
		this.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5 = new List<SongEntry>();
	}

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x06001336 RID: 4918 RVA: 0x0001009D File Offset: 0x0000E29D
	// (set) Token: 0x06001337 RID: 4919 RVA: 0x000100BF File Offset: 0x0000E2BF
	public string \u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD { get; set; }

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x06001338 RID: 4920 RVA: 0x000100C8 File Offset: 0x0000E2C8
	public int \u02BB\u02BD\u02B2\u02BE\u02B2\u02B8\u02B2\u02B4\u02B4\u02B3\u02C1
	{
		get
		{
			return this.\u02B7\u02BD\u02B4\u02C0\u02B9\u02B3\u02BA\u02B7\u02B2\u02BE\u02B3 + (this.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE ? 0 : this.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count);
		}
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x000100E7 File Offset: 0x0000E2E7
	public int \u02B8\u02BB\u02B2\u02BA\u02B9\u02B4\u02B6\u02B6\u02B6\u02B2\u02B6()
	{
		this.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE = !this.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE;
		if (!this.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE)
		{
			return this.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count;
		}
		return -this.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count;
	}

	// Token: 0x04000E5A RID: 3674
	public List<SongEntry> \u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5;

	// Token: 0x04000E5B RID: 3675
	public bool \u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE;

	// Token: 0x04000E5C RID: 3676
	public int \u02B7\u02BD\u02B4\u02C0\u02B9\u02B3\u02BA\u02B7\u02B2\u02BE\u02B3;
}
