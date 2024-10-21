using System;
using UnityEngine;

// Token: 0x02000087 RID: 135
public class DrumEndOfSongOptionsMenu : BaseMenu
{
	// Token: 0x0600058D RID: 1421 RVA: 0x000366A4 File Offset: 0x000348A4
	protected override void Start()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.menuStrings = this.setlistStrings;
		}
		else if (this.endOfSong.\u02B7\u02B4\u02B9\u02BD\u02C0\u02BA\u02B5\u02BF\u02BA\u02B3\u02B8)
		{
			this.menuStrings = this.practiceStrings;
		}
		else
		{
			this.menuStrings = this.quickplayStrings;
		}
		base.Start();
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x000366F8 File Offset: 0x000348F8
	public virtual void \u02B3\u02B5\u02B3\u02BA\u02C1\u02BC\u02B4\u02BA\u02B8\u02BB\u02BD()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "GameColors_")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "%")
		{
			this.endOfSong.\u02BD\u02B7\u02BE\u02B5\u02B8\u02BC\u02BE\u02BA\u02BD\u02B8\u02BB();
			return;
		}
		if (text == "Drunk Mode")
		{
			this.endOfSong.\u02BE\u02B8\u02B5\u02B8\u02BC\u02BD\u02B6\u02BA\u02B8\u02BB\u02B8();
			return;
		}
		if (!(text == "midi_export"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00036770 File Offset: 0x00034970
	public virtual void \u02B3\u02C1\u02B8\u02BA\u02B2\u02B8\u02B5\u02B6\u02B2\u02B5\u02BA()
	{
		string text = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
		if (text == "ENHANCED_OPENS")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "Precision Mode")
		{
			this.endOfSong.\u02B7\u02B2\u02BA\u02B8\u02B9\u02BF\u02B2\u02C0\u02BE\u02B3\u02B3();
			return;
		}
		if (text == "Surfer")
		{
			this.endOfSong.\u02BE\u02B5\u02BE\u02B9\u02B6\u02C0\u02BF\u02BB\u02C0\u02B3\u02BD();
			return;
		}
		if (!(text == "Kick / Open Notes"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x000367E8 File Offset: 0x000349E8
	protected virtual void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.menuStrings = this.setlistStrings;
		}
		else if (this.endOfSong.\u02B8\u02BA\u02BF\u02B6\u02B7\u02BF\u02BA\u02B4\u02B7\u02B9\u02B3())
		{
			this.menuStrings = this.practiceStrings;
		}
		else
		{
			this.menuStrings = this.quickplayStrings;
		}
		base.Start();
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x00008D18 File Offset: 0x00006F18
	public void \u02BF\u02B9\u02B2\u02B3\u02B9\u02BA\u02BB\u02B2\u02BE\u02B9\u02BD()
	{
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x000366A4 File Offset: 0x000348A4
	protected virtual void \u02B7\u02B8\u02BD\u02C0\u02B2\u02B4\u02B7\u02C0\u02BC\u02BE\u02B3()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.menuStrings = this.setlistStrings;
		}
		else if (this.endOfSong.\u02B7\u02B4\u02B9\u02BD\u02C0\u02BA\u02B5\u02BF\u02BA\u02B3\u02B8)
		{
			this.menuStrings = this.practiceStrings;
		}
		else
		{
			this.menuStrings = this.quickplayStrings;
		}
		base.Start();
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0003683C File Offset: 0x00034A3C
	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "Replay")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "Practice")
		{
			this.endOfSong.\u02B7\u02B2\u02BA\u02B8\u02B9\u02BF\u02B2\u02C0\u02BE\u02B3\u02B3();
			return;
		}
		if (text == "Random Song")
		{
			this.endOfSong.\u02B6\u02B9\u02B4\u02B2\u02B4\u02BB\u02BF\u02B7\u02BC\u02BD\u02C1();
			return;
		}
		if (!(text == "Save Screenshot"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x000368B4 File Offset: 0x00034AB4
	public virtual void \u02B2\u02BA\u02B2\u02BC\u02B6\u02B4\u02BB\u02B6\u02B8\u02BE\u02B3()
	{
		string text = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
		if (text == "Bad Argument")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "Accents Hit")
		{
			this.endOfSong.\u02BD\u02BC\u02BF\u02C1\u02BF\u02B6\u02C1\u02C0\u02C1\u02BE\u02C1();
			return;
		}
		if (text == "Background Video")
		{
			this.endOfSong.\u02B6\u02B9\u02B4\u02B2\u02B4\u02BB\u02BF\u02B7\u02BC\u02BD\u02C1();
			return;
		}
		if (!(text == "measure_countdown"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x00008D2E File Offset: 0x00006F2E
	public void \u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD()
	{
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x000367E8 File Offset: 0x000349E8
	protected virtual void \u02B2\u02BB\u02B6\u02B5\u02B9\u02B8\u02B2\u02B3\u02BF\u02C1\u02BF()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.menuStrings = this.setlistStrings;
		}
		else if (this.endOfSong.\u02B8\u02BA\u02BF\u02B6\u02B7\u02BF\u02BA\u02B4\u02B7\u02B9\u02B3())
		{
			this.menuStrings = this.practiceStrings;
		}
		else
		{
			this.menuStrings = this.quickplayStrings;
		}
		base.Start();
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x000366A4 File Offset: 0x000348A4
	protected virtual void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.menuStrings = this.setlistStrings;
		}
		else if (this.endOfSong.\u02B7\u02B4\u02B9\u02BD\u02C0\u02BA\u02B5\u02BF\u02BA\u02B3\u02B8)
		{
			this.menuStrings = this.practiceStrings;
		}
		else
		{
			this.menuStrings = this.quickplayStrings;
		}
		base.Start();
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x0003692C File Offset: 0x00034B2C
	public virtual void \u02C0\u02BF\u02BD\u02BA\u02B8\u02BB\u02B7\u02B5\u02BA\u02BB\u02BD()
	{
		string text = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
		if (text == " (")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "Show Bot Score")
		{
			this.endOfSong.\u02BD\u02BC\u02BF\u02C1\u02BF\u02B6\u02C1\u02C0\u02C1\u02BE\u02C1();
			return;
		}
		if (text == "")
		{
			this.endOfSong.\u02B6\u02B9\u02B4\u02B2\u02B4\u02BB\u02BF\u02B7\u02BC\u02BD\u02C1();
			return;
		}
		if (!(text == "Intensity - Lead Guitar"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x000369A4 File Offset: 0x00034BA4
	public virtual void \u02B6\u02B6\u02B6\u02BC\u02B7\u02B9\u02B7\u02BC\u02B4\u02B6\u02B3()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "{0} {1} {2}")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "hh\\:mm\\:ss")
		{
			this.endOfSong.\u02BD\u02B7\u02BE\u02B5\u02B8\u02BC\u02BE\u02BA\u02BD\u02B8\u02BB();
			return;
		}
		if (text == "GameColors_")
		{
			this.endOfSong.\u02B6\u02B9\u02B4\u02B2\u02B4\u02BB\u02BF\u02B7\u02BC\u02BD\u02C1();
			return;
		}
		if (!(text == "Languages/"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x00036A1C File Offset: 0x00034C1C
	public virtual void \u02BA\u02B7\u02B3\u02B3\u02B7\u02BD\u02BD\u02BA\u02C0\u02BE\u02BE()
	{
		string text = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
		if (text == "songBuiltIn")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "Color Profile")
		{
			this.endOfSong.\u02BD\u02BC\u02BF\u02C1\u02BF\u02B6\u02C1\u02C0\u02C1\u02BE\u02C1();
			return;
		}
		if (text == "Text resource in language file '{0}' c")
		{
			this.endOfSong.\u02B6\u02B9\u02B4\u02B2\u02B4\u02BB\u02BF\u02B7\u02BC\u02BD\u02C1();
			return;
		}
		if (!(text == ""))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00008D44 File Offset: 0x00006F44
	public virtual void \u02BA\u02C1\u02C1\u02B5\u02B4\u02B2\u02C1\u02C1\u02BB\u02B6\u02BF()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x000366A4 File Offset: 0x000348A4
	protected virtual void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.menuStrings = this.setlistStrings;
		}
		else if (this.endOfSong.\u02B7\u02B4\u02B9\u02BD\u02C0\u02BA\u02B5\u02BF\u02BA\u02B3\u02B8)
		{
			this.menuStrings = this.practiceStrings;
		}
		else
		{
			this.menuStrings = this.quickplayStrings;
		}
		base.Start();
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x00008D44 File Offset: 0x00006F44
	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x00036A94 File Offset: 0x00034C94
	public virtual void \u02C0\u02BE\u02B9\u02B5\u02B6\u02C1\u02B5\u02C0\u02BE\u02B8\u02C1()
	{
		string text = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
		if (text == "ERROR: Song length is 0 ignoring playback request.")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "<b>{0}</b>")
		{
			this.endOfSong.\u02B7\u02B2\u02BA\u02B8\u02B9\u02BF\u02B2\u02C0\u02BE\u02B3\u02B3();
			return;
		}
		if (text == "settings")
		{
			this.endOfSong.\u02BE\u02B5\u02BE\u02B9\u02B6\u02C0\u02BF\u02BB\u02C0\u02B3\u02BD();
			return;
		}
		if (!(text == "VOLUME"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x00008D52 File Offset: 0x00006F52
	public virtual void \u02B8\u02B3\u02B9\u02BD\u02BF\u02BE\u02BE\u02B2\u02BB\u02BE\u02C0()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x04000410 RID: 1040
	[SerializeField]
	private EndOfSong endOfSong;

	// Token: 0x04000411 RID: 1041
	[SerializeField]
	private string[] quickplayStrings;

	// Token: 0x04000412 RID: 1042
	[SerializeField]
	private string[] practiceStrings;

	// Token: 0x04000413 RID: 1043
	[SerializeField]
	private string[] setlistStrings;

	// Token: 0x04000414 RID: 1044
	[SerializeField]
	private string[] setlistEndStrings;
}
