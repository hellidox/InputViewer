using System;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200011C RID: 284
public class SongSelectPanel : MonoBehaviour
{
	// Token: 0x06000C27 RID: 3111 RVA: 0x0000C38B File Offset: 0x0000A58B
	public void \u02C1\u02B4\u02BC\u02C1\u02BB\u02BE\u02B8\u02BD\u02BD\u02B3\u02B5()
	{
		this.starCount.enabled = true;
		this.star.enabled = true;
		this.percentText.enabled = false;
		this.FCImage.enabled = true;
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x0000C3BD File Offset: 0x0000A5BD
	public void \u02B7\u02BE\u02BF\u02B2\u02B7\u02B2\u02BE\u02B7\u02BA\u02BA\u02C0()
	{
		this.starCount.enabled = false;
		this.star.enabled = false;
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x0006AD68 File Offset: 0x00068F68
	public void \u02B2\u02BC\u02B6\u02BC\u02B5\u02BA\u02B6\u02BD\u02C0\u02BD\u02B3(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.\u02B5\u02B9\u02BF\u02BF\u02B9\u02B2\u02BF\u02B7\u02B6\u02C1\u02BB();
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9 <= 0)
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
		}
		else
		{
			this.star.enabled = true;
			this.starCount.enabled = false;
			this.starCount.text = Mathf.Min((int)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9, 0).ToString();
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02B2\u02C0\u02B6\u02BC\u02BF\u02C0\u02B7\u02B6\u02C1\u02BB)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = false;
		this.percentText.text = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.ToString() + "video_start_time";
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x0006AE3C File Offset: 0x0006903C
	public void \u02B4\u02B6\u02C0\u02BC\u02B4\u02BE\u02BE\u02BC\u02BF\u02BB\u02BB(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.\u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7();
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9 <= 0)
		{
			this.star.enabled = true;
			this.starCount.enabled = true;
		}
		else
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
			this.starCount.text = Mathf.Min((int)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9, 7).ToString();
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02B2\u02C0\u02B6\u02BC\u02BF\u02C0\u02B7\u02B6\u02C1\u02BB)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.ToString() + "notes.mid";
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x0000C3EF File Offset: 0x0000A5EF
	public void \u02BD\u02B9\u02B7\u02B8\u02B8\u02B6\u02B9\u02B8\u02B5\u02B7\u02B6()
	{
		this.starCount.enabled = false;
		this.star.enabled = true;
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x0006AF10 File Offset: 0x00069110
	public void \u02B2\u02BA\u02BE\u02B9\u02BD\u02B9\u02BE\u02B2\u02BA\u02BD\u02B2(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.\u02BD\u02BE\u02C0\u02BE\u02BB\u02B5\u02BE\u02BE\u02B3\u02BB\u02B4();
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9 <= 0)
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
		}
		else
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
			this.starCount.text = Mathf.Min((int)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9, 8).ToString();
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02B2\u02C0\u02B6\u02BC\u02BF\u02C0\u02B7\u02B6\u02C1\u02BB)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = false;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = false;
		this.percentText.text = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.ToString() + "127.0.0.1";
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x0000C421 File Offset: 0x0000A621
	public void \u02B4\u02B2\u02BF\u02B7\u02C0\u02BD\u02BE\u02C1\u02B6\u02BE\u02BD()
	{
		this.starCount.enabled = false;
		this.star.enabled = true;
		this.percentText.enabled = true;
		this.FCImage.enabled = false;
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x0006AFE4 File Offset: 0x000691E4
	public void \u02BC\u02BE\u02BD\u02BA\u02BE\u02B4\u02BA\u02B2\u02B2\u02B4\u02B5(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.\u02BD\u02B9\u02B7\u02B8\u02B8\u02B6\u02B9\u02B8\u02B5\u02B7\u02B6();
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9 <= 1)
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
		}
		else
		{
			this.star.enabled = false;
			this.starCount.enabled = true;
			this.starCount.text = Mathf.Min((int)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9, 6).ToString();
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02B2\u02C0\u02B6\u02BC\u02BF\u02C0\u02B7\u02B6\u02C1\u02BB)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = false;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = true;
		this.percentText.text = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.ToString() + "Background Image";
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x0000C3BD File Offset: 0x0000A5BD
	public void \u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7()
	{
		this.starCount.enabled = false;
		this.star.enabled = false;
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x0000C453 File Offset: 0x0000A653
	public void \u02B4\u02B8\u02C1\u02BF\u02B9\u02B3\u02B8\u02B5\u02BF\u02B7\u02B3()
	{
		this.starCount.enabled = true;
		this.star.enabled = false;
		this.percentText.enabled = true;
		this.FCImage.enabled = true;
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x0000C453 File Offset: 0x0000A653
	public void \u02B2\u02B3\u02BF\u02BD\u02B5\u02BF\u02B5\u02B6\u02B3\u02B3\u02BA()
	{
		this.starCount.enabled = true;
		this.star.enabled = false;
		this.percentText.enabled = true;
		this.FCImage.enabled = true;
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x0000C3BD File Offset: 0x0000A5BD
	public void \u02B5\u02B9\u02BF\u02BF\u02B9\u02B2\u02BF\u02B7\u02B6\u02C1\u02BB()
	{
		this.starCount.enabled = false;
		this.star.enabled = false;
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x0006B0B8 File Offset: 0x000692B8
	public void \u02B6\u02BF\u02B6\u02B3\u02BB\u02B7\u02B8\u02C1\u02B9\u02B4\u02BB(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.\u02BB\u02B8\u02BD\u02B6\u02BB\u02BA\u02B8\u02C1\u02BA\u02BC\u02BD();
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9 <= 1)
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
		}
		else
		{
			this.star.enabled = false;
			this.starCount.enabled = true;
			this.starCount.text = Mathf.Min((int)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9, 0).ToString();
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02B2\u02C0\u02B6\u02BC\u02BF\u02C0\u02B7\u02B6\u02C1\u02BB)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.ToString() + "Gamepad Mode";
	}

	// Token: 0x06000C34 RID: 3124 RVA: 0x0000C485 File Offset: 0x0000A685
	public void \u02BB\u02B8\u02BD\u02B6\u02BB\u02BA\u02B8\u02C1\u02BA\u02BC\u02BD()
	{
		this.starCount.enabled = true;
		this.star.enabled = true;
		this.percentText.enabled = true;
		this.FCImage.enabled = true;
	}

	// Token: 0x06000C35 RID: 3125 RVA: 0x0000C4B7 File Offset: 0x0000A6B7
	public void \u02BD\u02BE\u02C0\u02BE\u02BB\u02B5\u02BE\u02BE\u02B3\u02BB\u02B4()
	{
		this.starCount.enabled = true;
		this.star.enabled = true;
		this.percentText.enabled = true;
		this.FCImage.enabled = false;
	}

	// Token: 0x06000C37 RID: 3127 RVA: 0x0006B18C File Offset: 0x0006938C
	public void \u02BF\u02BC\u02B7\u02B2\u02B9\u02BA\u02BD\u02B6\u02C0\u02C0\u02BE(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.\u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7();
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9 <= 0)
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
		}
		else
		{
			this.star.enabled = true;
			this.starCount.enabled = true;
			this.starCount.text = Mathf.Min((int)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9, 7).ToString();
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02B2\u02C0\u02B6\u02BC\u02BF\u02C0\u02B7\u02B6\u02C1\u02BB)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.ToString() + "%";
	}

	// Token: 0x040008C1 RID: 2241
	[SerializeField]
	private Image star;

	// Token: 0x040008C2 RID: 2242
	[SerializeField]
	private TextMeshProUGUI percentText;

	// Token: 0x040008C3 RID: 2243
	[SerializeField]
	private TextMeshProUGUI starCount;

	// Token: 0x040008C4 RID: 2244
	[SerializeField]
	private Image FCImage;
}
