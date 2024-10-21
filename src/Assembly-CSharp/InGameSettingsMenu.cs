using System;
using TMPro;
using UnityEngine;

// Token: 0x020000FD RID: 253
public class InGameSettingsMenu : BaseMenu
{
	// Token: 0x06000A4B RID: 2635 RVA: 0x0000B096 File Offset: 0x00009296
	private void \u02B3\u02BC\u02BB\u02BF\u02C1\u02BE\u02B4\u02BC\u02BE\u02BF\u02B8()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("song");
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x0005B354 File Offset: 0x00059554
	public virtual void \u02BA\u02B7\u02B3\u02B3\u02B7\u02BD\u02BD\u02BA\u02C0\u02BE\u02BE()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "latestTestBuild")
		{
			base.gameObject.SetActive(true);
			this.\u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA.gameObject.SetActive(false);
			return;
		}
		if (!(text == "n != 1 ? 'other' : 'one'"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.\u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5.gameObject.SetActive(false);
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x0005B3C0 File Offset: 0x000595C0
	public virtual void \u02C0\u02C1\u02BB\u02B8\u02BF\u02C0\u02BC\u02B8\u02BF\u02B8\u02B4()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "Show Bot Score")
		{
			base.gameObject.SetActive(false);
			this.\u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA.gameObject.SetActive(false);
			return;
		}
		if (!(text == "song"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.\u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5.gameObject.SetActive(true);
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x0005B42C File Offset: 0x0005962C
	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "Volume")
		{
			base.gameObject.SetActive(false);
			this.\u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA.gameObject.SetActive(true);
			return;
		}
		if (!(text == "Calibration"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.\u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5.gameObject.SetActive(true);
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x0000B0B8 File Offset: 0x000092B8
	public virtual void \u02B9\u02C1\u02B5\u02B5\u02B2\u02BF\u02BA\u02BB\u02BB\u02B9\u02B7()
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
		this.\u02BB\u02BA\u02B5\u02B2\u02B7\u02B6\u02BC\u02B3\u02BA\u02B4\u02B3.gameObject.SetActive(true);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x0000B0E2 File Offset: 0x000092E2
	private void \u02B9\u02B6\u02B3\u02B9\u02BD\u02BD\u02B6\u02C0\u02BE\u02BA\u02BB()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("WRITING CACHE...");
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x0000B104 File Offset: 0x00009304
	private void \u02BA\u02B9\u02BF\u02BC\u02C1\u02B9\u02B7\u02B4\u02C1\u02BB\u02BB()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Exclusive Fullscreen");
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x0005B498 File Offset: 0x00059698
	public virtual void \u02C0\u02BE\u02B9\u02B5\u02B6\u02C1\u02B5\u02C0\u02BE\u02B8\u02C1()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "")
		{
			base.gameObject.SetActive(true);
			this.\u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA.gameObject.SetActive(false);
			return;
		}
		if (!(text == "playTime"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.\u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5.gameObject.SetActive(true);
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x0000B126 File Offset: 0x00009326
	public virtual void \u02BC\u02BD\u02B2\u02B9\u02BB\u02C1\u02BB\u02B6\u02B4\u02BC\u02BE()
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
		this.\u02BB\u02BA\u02B5\u02B2\u02B7\u02B6\u02BC\u02B3\u02BA\u02B4\u02B3.gameObject.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x0000B150 File Offset: 0x00009350
	private new void OnEnable()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("OPTIONS");
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x0000B172 File Offset: 0x00009372
	private void \u02B9\u02BE\u02BC\u02BE\u02BC\u02B9\u02B2\u02B3\u02BF\u02B2\u02BA()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("album.jpg");
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x0005B504 File Offset: 0x00059704
	public virtual void \u02BD\u02B3\u02B9\u02BD\u02B3\u02BE\u02B4\u02B9\u02BB\u02BE\u02B9()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "Highways")
		{
			base.gameObject.SetActive(true);
			this.\u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA.gameObject.SetActive(true);
			return;
		}
		if (!(text == "genre"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.\u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5.gameObject.SetActive(false);
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x0005B570 File Offset: 0x00059770
	public virtual void \u02C0\u02BF\u02BD\u02BA\u02B8\u02BB\u02B7\u02B5\u02BA\u02BB\u02BD()
	{
		string text = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
		if (text == "No")
		{
			base.gameObject.SetActive(false);
			this.\u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA.gameObject.SetActive(true);
			return;
		}
		if (!(text == "changesearchtip"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.\u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5.gameObject.SetActive(false);
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x0000B194 File Offset: 0x00009394
	private void \u02B9\u02B7\u02C0\u02B7\u02C1\u02BA\u02BC\u02C0\u02C1\u02BD\u02B6()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("loading_phrase");
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x0000B1B6 File Offset: 0x000093B6
	private void \u02C0\u02B7\u02B3\u02BF\u02B9\u02B3\u02BB\u02C1\u02BB\u02BA\u02BF()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("");
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x0000B1D8 File Offset: 0x000093D8
	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
		this.\u02BB\u02BA\u02B5\u02B2\u02B7\u02B6\u02BC\u02B3\u02BA\u02B4\u02B3.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x040007A5 RID: 1957
	public PauseMenu \u02BB\u02BA\u02B5\u02B2\u02B7\u02B6\u02BC\u02B3\u02BA\u02B4\u02B3;

	// Token: 0x040007A6 RID: 1958
	public VolumeMenu \u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA;

	// Token: 0x040007A7 RID: 1959
	public CalibrationMenu \u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5;

	// Token: 0x040007A8 RID: 1960
	[SerializeField]
	private TextMeshProUGUI pausedText;
}
