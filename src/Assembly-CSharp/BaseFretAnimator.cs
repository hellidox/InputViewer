using System;
using UnityEngine;

// Token: 0x02000155 RID: 341
public abstract class BaseFretAnimator : MonoBehaviour, \u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7
{
	// Token: 0x17000188 RID: 392
	// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0000E2F7 File Offset: 0x0000C4F7
	// (set) Token: 0x06000EFE RID: 3838 RVA: 0x0000E2FF File Offset: 0x0000C4FF
	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 colorInfo { get; set; }

	// Token: 0x06000EFF RID: 3839
	public abstract void \u02C0\u02BE\u02B5\u02BF\u02B4\u02B9\u02B6\u02BD\u02BC\u02B7\u02B7();

	// Token: 0x06000F00 RID: 3840
	public abstract void \u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(bool \u02B5\u02C1\u02BD\u02B8\u02BB\u02B2\u02B8\u02B9\u02B8\u02B4\u02BA, bool \u02B9\u02B9\u02B8\u02C0\u02B3\u02BE\u02B4\u02BA\u02BA\u02BB\u02B8);

	// Token: 0x06000F01 RID: 3841
	public abstract void \u02BB\u02BF\u02B2\u02B3\u02BD\u02BB\u02BE\u02BD\u02BB\u02BE\u02B3();

	// Token: 0x04000B2D RID: 2861
	public bool \u02B6\u02BF\u02B2\u02BF\u02B9\u02BC\u02BD\u02B6\u02B5\u02B4\u02BE;

	// Token: 0x04000B2E RID: 2862
	public bool \u02C1\u02B8\u02B6\u02B6\u02BF\u02BF\u02BD\u02BF\u02B4\u02B6\u02C0;

	// Token: 0x04000B30 RID: 2864
	public int fretIndex;
}
