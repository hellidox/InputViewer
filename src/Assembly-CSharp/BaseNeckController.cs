using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200015A RID: 346
public abstract class BaseNeckController : MonoBehaviour, \u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7
{
	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06000F24 RID: 3876 RVA: 0x0000E421 File Offset: 0x0000C621
	// (set) Token: 0x06000F25 RID: 3877 RVA: 0x0000E429 File Offset: 0x0000C629
	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 gameColorSettings { get; set; }

	// Token: 0x06000F26 RID: 3878
	public abstract void \u02BF\u02B2\u02BE\u02BE\u02BF\u02B4\u02BC\u02C0\u02B3\u02C0\u02C1();

	// Token: 0x06000F27 RID: 3879
	public abstract void \u02B4\u02B7\u02B5\u02BC\u02B6\u02B2\u02BA\u02BF\u02B2\u02BA\u02BA(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, bool \u02B3\u02B2\u02BC\u02B2\u02BD\u02BF\u02B6\u02BD\u02BF\u02C0\u02BE, bool \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);

	// Token: 0x06000F28 RID: 3880
	public abstract void \u02C0\u02B8\u02B5\u02B3\u02BF\u02BD\u02B2\u02BE\u02B9\u02B2\u02B4(ushort \u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6);

	// Token: 0x06000F29 RID: 3881
	public abstract void \u02B8\u02BA\u02B8\u02B9\u02B7\u02B3\u02B6\u02BD\u02C1\u02BC\u02B8(ushort \u02B3\u02BF\u02B5\u02B7\u02C0\u02BB\u02BA\u02B4\u02B8\u02C0\u02B7);

	// Token: 0x06000F2A RID: 3882
	public abstract void \u02B5\u02BD\u02BA\u02BE\u02B4\u02B9\u02BD\u02B3\u02B9\u02BC\u02BE();

	// Token: 0x06000F2B RID: 3883
	protected abstract IEnumerator \u02B5\u02BD\u02BE\u02BF\u02B3\u02B8\u02BC\u02B5\u02B2\u02B4\u02B6();

	// Token: 0x06000F2C RID: 3884 RVA: 0x0008038C File Offset: 0x0007E58C
	public virtual void \u02B7\u02BC\u02BC\u02C0\u02BA\u02BF\u02BE\u02C0\u02BA\u02BA\u02B8()
	{
		base.StartCoroutine(this.\u02B5\u02BD\u02BE\u02BF\u02B3\u02B8\u02BC\u02B5\u02B2\u02B4\u02B6());
		if (base.gameObject.GetComponent<BasePlayer>().playerStuff.playerInfo.isBot || !SettingsController.\u02C1\u02B6\u02B5\u02C1\u02B7\u02BE\u02B5\u02B9\u02B9\u02BB\u02C1)
		{
			this.\u02BF\u02B9\u02B2\u02B2\u02BF\u02B2\u02BA\u02B4\u02BB\u02B5\u02C1();
		}
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x000803DC File Offset: 0x0007E5DC
	public virtual void \u02BF\u02B9\u02B2\u02B2\u02BF\u02B2\u02BA\u02B4\u02BB\u02B5\u02C1()
	{
		global::Animator[] u02B6_u02C0_u02C1_u02BA_u02B4_u02B7_u02B7_u02C1_u02BE_u02B3_u02BC = this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC;
		for (int i = 0; i < u02B6_u02C0_u02C1_u02BA_u02B4_u02B7_u02B7_u02C1_u02BE_u02B3_u02BC.Length; i++)
		{
			u02B6_u02C0_u02C1_u02BA_u02B4_u02B7_u02B7_u02C1_u02BE_u02B3_u02BC[i].GetComponent<SpriteRenderer>().enabled = false;
		}
	}

	// Token: 0x06000F2E RID: 3886
	public abstract void \u02B2\u02BF\u02BB\u02BC\u02B8\u02B7\u02B9\u02C1\u02B8\u02BE\u02BA();

	// Token: 0x06000F2F RID: 3887
	public abstract void \u02B6\u02B2\u02B9\u02B7\u02B5\u02B9\u02B5\u02BF\u02B8\u02B8\u02BC(bool \u02BB\u02B9\u02BB\u02B7\u02BB\u02B9\u02BA\u02B2\u02C1\u02B5\u02BA);

	// Token: 0x06000F30 RID: 3888 RVA: 0x0008040C File Offset: 0x0007E60C
	public virtual void HideFretStrings()
	{
		if (this.hidden)
		{
			return;
		}
		this.hidden = true;
		GameObject[] u02B8_u02BF_u02BD_u02B4_u02BA_u02B5_u02C1_u02C1_u02B5_u02BD_u02B = this.\u02B8\u02BF\u02BD\u02B4\u02BA\u02B5\u02C1\u02C1\u02B5\u02BD\u02B4;
		for (int i = 0; i < u02B8_u02BF_u02BD_u02B4_u02BA_u02B5_u02C1_u02C1_u02B5_u02BD_u02B.Length; i++)
		{
			u02B8_u02BF_u02BD_u02B4_u02BA_u02B5_u02C1_u02C1_u02B5_u02BD_u02B[i].SetActive(false);
		}
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x00080448 File Offset: 0x0007E648
	public virtual void ShowFretStrings()
	{
		if (!this.hidden)
		{
			return;
		}
		this.hidden = false;
		GameObject[] u02B8_u02BF_u02BD_u02B4_u02BA_u02B5_u02C1_u02C1_u02B5_u02BD_u02B = this.\u02B8\u02BF\u02BD\u02B4\u02BA\u02B5\u02C1\u02C1\u02B5\u02BD\u02B4;
		for (int i = 0; i < u02B8_u02BF_u02BD_u02B4_u02BA_u02B5_u02C1_u02C1_u02B5_u02BD_u02B.Length; i++)
		{
			u02B8_u02BF_u02BD_u02B4_u02BA_u02B5_u02C1_u02C1_u02B5_u02BD_u02B[i].SetActive(true);
		}
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x0000E445 File Offset: 0x0000C645
	void \u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7.\u02B8\u02B9\u02C0\u02B7\u02C0\u02B6\u02C1\u02BA\u02BF\u02B8\u02B8(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.gameColorSettings = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x04000B76 RID: 2934
	public BaseFretAnimator[] \u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9;

	// Token: 0x04000B77 RID: 2935
	public global::Animator[] \u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC;

	// Token: 0x04000B78 RID: 2936
	public global::Animator[] flameAnimators;

	// Token: 0x04000B79 RID: 2937
	public GameObject[] \u02B8\u02BF\u02BD\u02B4\u02BA\u02B5\u02C1\u02C1\u02B5\u02BD\u02B4;

	// Token: 0x04000B7A RID: 2938
	protected ushort \u02B7\u02C0\u02BB\u02BF\u02B9\u02C0\u02BD\u02BA\u02B7\u02B8\u02BB = 128;

	// Token: 0x04000B7C RID: 2940
	private bool hidden;
}
