using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000007 RID: 7
public class EOSScreenshotNotification : MonoBehaviour
{
	// Token: 0x0600003E RID: 62 RVA: 0x00005FA2 File Offset: 0x000041A2
	public void \u02BA\u02C1\u02BB\u02C1\u02BC\u02B5\u02C1\u02B5\u02BD\u02B8\u02B6()
	{
		this.animator.SetBool("EndOfSong", false);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00005FB5 File Offset: 0x000041B5
	public void \u02B6\u02B7\u02BA\u02B5\u02B3\u02B7\u02B3\u02BF\u02BA\u02BD\u02BD(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(false);
		this.title.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Unknown");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00005FE9 File Offset: 0x000041E9
	public void \u02B5\u02C0\u02B6\u02C0\u02B5\u02B7\u02C1\u02BF\u02B5\u02BD\u02B2(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(false);
		this.title.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Ready");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	// Token: 0x06000041 RID: 65 RVA: 0x0000601D File Offset: 0x0000421D
	public void \u02B4\u02B2\u02BD\u02B7\u02BF\u02BD\u02B2\u02B4\u02B7\u02B9\u02BC(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(true);
		this.title.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Screenshot Saved");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00006051 File Offset: 0x00004251
	public void \u02B5\u02C0\u02BB\u02BD\u02B2\u02C0\u02BC\u02BD\u02B4\u02BD\u02B5(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(true);
		this.title.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("ERROR: These folders have no notes.mid or notes.chart files!");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00006085 File Offset: 0x00004285
	public void \u02B4\u02BB\u02C0\u02BB\u02B3\u02BF\u02C1\u02B3\u02B5\u02BF\u02BE()
	{
		this.animator.SetBool("scoreDisabled", true);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00006098 File Offset: 0x00004298
	public void \u02B3\u02B5\u02B4\u02C1\u02BF\u02B3\u02BE\u02B3\u02B8\u02B8\u02BD()
	{
		this.animator.SetBool("isHidden", true);
	}

	// Token: 0x06000045 RID: 69 RVA: 0x000060AB File Offset: 0x000042AB
	public void \u02B9\u02B7\u02BA\u02BD\u02B2\u02BB\u02C1\u02B6\u02BF\u02B2\u02B4(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(true);
		this.title.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x000060DF File Offset: 0x000042DF
	public void \u02B2\u02B4\u02BE\u02C1\u02BA\u02BA\u02B8\u02BE\u02C1\u02BB\u02B8()
	{
		this.animator.SetBool("Vocals", false);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x000060F2 File Offset: 0x000042F2
	public void \u02B6\u02BC\u02B6\u02BD\u02C0\u02BD\u02BF\u02B2\u02BB\u02BC\u02B8()
	{
		this.animator.SetBool(": ", false);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00006105 File Offset: 0x00004305
	public void \u02BF\u02BC\u02BF\u02BF\u02B4\u02B4\u02B9\u02BD\u02BB\u02BB\u02B2()
	{
		this.animator.SetBool("", true);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00006118 File Offset: 0x00004318
	public void \u02BB\u02BA\u02BD\u02C1\u02BC\u02C0\u02B5\u02BB\u02BB\u02B5\u02BE()
	{
		this.animator.SetBool("hasBots", false);
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0000612B File Offset: 0x0000432B
	public void \u02B9\u02BC\u02BD\u02B6\u02BA\u02BD\u02B6\u02B4\u02B8\u02C0\u02BF()
	{
		this.animator.SetBool("PracticeReset", false);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0000613E File Offset: 0x0000433E
	public void \u02B3\u02C0\u02BC\u02B5\u02B7\u02BC\u02B2\u02BD\u02B4\u02B6\u02BA(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(true);
		this.title.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("ERROR: These folders have *.mid or *.chart files but are named incorrectly!");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00006172 File Offset: 0x00004372
	public void \u02B7\u02B8\u02BD\u02C1\u02B9\u02B8\u02B8\u02B7\u02BB\u02B5\u02BE()
	{
		this.animator.SetBool("Selection", false);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00006185 File Offset: 0x00004385
	public void \u02BD\u02BB\u02C0\u02C1\u02B2\u02BE\u02B7\u02B9\u02BB\u02B7\u02B7()
	{
		this.animator.SetBool("song", false);
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00006198 File Offset: 0x00004398
	public void \u02BE\u02B4\u02BE\u02BC\u02BF\u02B6\u02B5\u02B3\u02B9\u02B2\u02B9()
	{
		this.animator.SetBool(".webm", true);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x000061AB File Offset: 0x000043AB
	public void \u02B5\u02BF\u02BD\u02BC\u02B9\u02B6\u02BA\u02B6\u02B9\u02BC\u02BF(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(false);
		this.title.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Medium");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x000061DF File Offset: 0x000043DF
	public void \u02BB\u02B5\u02B9\u02B8\u02BB\u02C0\u02C0\u02B6\u02B2\u02BC\u02B3(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(false);
		this.title.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("rhythm6fret");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	// Token: 0x04000010 RID: 16
	[SerializeField]
	private global::UnityEngine.Animator animator;

	// Token: 0x04000011 RID: 17
	[SerializeField]
	private Text title;

	// Token: 0x04000012 RID: 18
	[SerializeField]
	private RawImage image;
}
