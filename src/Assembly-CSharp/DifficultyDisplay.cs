using System;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001E2 RID: 482
public class DifficultyDisplay : MonoBehaviour
{
	// Token: 0x0600154B RID: 5451 RVA: 0x000112A9 File Offset: 0x0000F4A9
	private void \u02B2\u02BB\u02B6\u02B5\u02B9\u02B8\u02B2\u02B3\u02BF\u02C1\u02BF()
	{
		this.instrumentIcon.sprite = this.\u02BE\u02B9\u02C1\u02B7\u02C0\u02B3\u02B4\u02BA\u02BA\u02BA\u02B4();
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x000A68FC File Offset: 0x000A4AFC
	private Sprite \u02B9\u02B5\u02C1\u02BB\u02B9\u02B2\u02C0\u02B9\u02BB\u02BA\u02B3()
	{
		switch (this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
		{
		case Instrument.Guitar:
			return this.guitarIcon;
		case Instrument.Bass:
			return this.bassIcon;
		case Instrument.Rhythm:
			return this.rhythmIcon;
		case Instrument.GuitarCoop:
			return this.guitarCoopIcon;
		case Instrument.GHLGuitar:
			return this.ghlGuitarIcon;
		case Instrument.GHLBass:
			return this.ghlBassIcon;
		case Instrument.Drums:
			return this.drumsRegIcon;
		case Instrument.Keys:
			return this.keysIcon;
		case Instrument.ProDrums:
			return this.drumsIcon;
		case Instrument.GHLRhythm:
			return this.ghlRhythmIcon;
		case Instrument.GHLGuitarCoop:
			return this.ghlCoopIcon;
		}
		return this.noPartIcon;
	}

	// Token: 0x0600154D RID: 5453 RVA: 0x000A68FC File Offset: 0x000A4AFC
	private Sprite \u02B5\u02B8\u02B3\u02B8\u02B4\u02B2\u02B7\u02BD\u02B9\u02B3\u02B6()
	{
		switch (this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
		{
		case Instrument.Guitar:
			return this.guitarIcon;
		case Instrument.Bass:
			return this.bassIcon;
		case Instrument.Rhythm:
			return this.rhythmIcon;
		case Instrument.GuitarCoop:
			return this.guitarCoopIcon;
		case Instrument.GHLGuitar:
			return this.ghlGuitarIcon;
		case Instrument.GHLBass:
			return this.ghlBassIcon;
		case Instrument.Drums:
			return this.drumsRegIcon;
		case Instrument.Keys:
			return this.keysIcon;
		case Instrument.ProDrums:
			return this.drumsIcon;
		case Instrument.GHLRhythm:
			return this.ghlRhythmIcon;
		case Instrument.GHLGuitarCoop:
			return this.ghlCoopIcon;
		}
		return this.noPartIcon;
	}

	// Token: 0x0600154E RID: 5454 RVA: 0x000A68FC File Offset: 0x000A4AFC
	private Sprite \u02BE\u02B9\u02C1\u02B7\u02C0\u02B3\u02B4\u02BA\u02BA\u02BA\u02B4()
	{
		switch (this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
		{
		case Instrument.Guitar:
			return this.guitarIcon;
		case Instrument.Bass:
			return this.bassIcon;
		case Instrument.Rhythm:
			return this.rhythmIcon;
		case Instrument.GuitarCoop:
			return this.guitarCoopIcon;
		case Instrument.GHLGuitar:
			return this.ghlGuitarIcon;
		case Instrument.GHLBass:
			return this.ghlBassIcon;
		case Instrument.Drums:
			return this.drumsRegIcon;
		case Instrument.Keys:
			return this.keysIcon;
		case Instrument.ProDrums:
			return this.drumsIcon;
		case Instrument.GHLRhythm:
			return this.ghlRhythmIcon;
		case Instrument.GHLGuitarCoop:
			return this.ghlCoopIcon;
		}
		return this.noPartIcon;
	}

	// Token: 0x0600154F RID: 5455 RVA: 0x000112BC File Offset: 0x0000F4BC
	private void \u02B7\u02B8\u02BD\u02C0\u02B2\u02B4\u02B7\u02C0\u02BC\u02BE\u02B3()
	{
		this.instrumentIcon.sprite = this.\u02BD\u02B7\u02BE\u02B4\u02B8\u02B5\u02B6\u02C1\u02B9\u02B4\u02B8();
	}

	// Token: 0x06001550 RID: 5456 RVA: 0x000A699C File Offset: 0x000A4B9C
	public void \u02B3\u02BB\u02B3\u02B8\u02B2\u02B8\u02B8\u02B6\u02BA\u02B7\u02BE(int \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, bool \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2 = true, bool \u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6 = false)
	{
		if (\u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6)
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD;
		}
		else
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = (((GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE() == this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF || \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2) && !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2) ? this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD : this.\u02BF\u02B9\u02BA\u02BA\u02B8\u02B7\u02B6\u02C0\u02B4\u02B5\u02B5);
		}
		this.\u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5 = false;
		if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 0)
		{
			this.radialFill.color = Color.black;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 3)
		{
			this.radialFill.color = this.tier1Color;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA >= 1 && \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 3)
		{
			this.radialFill.color = this.tier2Color;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA >= 74 && \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= -11)
		{
			this.radialFill.color = this.tier3Color;
			this.pieMask.sprite = this.tier3mask;
			this.pieOutline.sprite = this.tier3outline;
		}
		else
		{
			this.\u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5 = false;
		}
		this.instrumentIcon.sprite = this.\u02BD\u02B7\u02BE\u02B4\u02B8\u02B5\u02B6\u02C1\u02B9\u02B4\u02B8();
		this.radialFill.fillAmount = (float)((Mathf.Min(\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, -55) - 1) % 3 + 0) / this.\u02B4\u02BA\u02BC\u02BC\u02BE\u02B4\u02B4\u02B8\u02B8\u02BC\u02B7;
		this.difficultyText.text = ((\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA == -1) ? "Practice" : \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA.ToString());
	}

	// Token: 0x06001551 RID: 5457 RVA: 0x000A6B4C File Offset: 0x000A4D4C
	public void \u02B8\u02BE\u02BA\u02B6\u02BD\u02BA\u02B5\u02B6\u02BA\u02B9\u02B8(int \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, bool \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2 = true, bool \u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6 = false)
	{
		if (\u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6)
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD;
		}
		else
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = (((GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE() == this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF || \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2) && !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2) ? this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD : this.\u02BF\u02B9\u02BA\u02BA\u02B8\u02B7\u02B6\u02C0\u02B4\u02B5\u02B5);
		}
		this.\u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5 = false;
		if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 0)
		{
			this.radialFill.color = Color.black;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 4)
		{
			this.radialFill.color = this.tier1Color;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA >= 5 && \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 10)
		{
			this.radialFill.color = this.tier2Color;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA >= 8 && \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 112)
		{
			this.radialFill.color = this.tier3Color;
			this.pieMask.sprite = this.tier3mask;
			this.pieOutline.sprite = this.tier3outline;
		}
		else
		{
			this.\u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5 = true;
		}
		this.instrumentIcon.sprite = this.\u02BC\u02BC\u02B4\u02BC\u02B6\u02B8\u02B7\u02B2\u02B2\u02B6\u02C0();
		this.radialFill.fillAmount = (float)((Mathf.Min(\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, 19) - 1) % 8 + 0) / this.\u02B4\u02BA\u02BC\u02BC\u02BE\u02B4\u02B4\u02B8\u02B8\u02BC\u02B7;
		this.difficultyText.text = ((\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA == -1) ? "Show Full Playlist" : \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA.ToString());
	}

	// Token: 0x06001552 RID: 5458 RVA: 0x000A6CFC File Offset: 0x000A4EFC
	public void \u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC(int \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, bool \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2 = true, bool \u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6 = false)
	{
		if (\u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6)
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD;
		}
		else
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = (((GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE() == this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF || \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2) && !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2) ? this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD : this.\u02BF\u02B9\u02BA\u02BA\u02B8\u02B7\u02B6\u02C0\u02B4\u02B5\u02B5);
		}
		this.\u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5 = false;
		if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 0)
		{
			this.radialFill.color = Color.black;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 6)
		{
			this.radialFill.color = this.tier1Color;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA >= 7 && \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 12)
		{
			this.radialFill.color = this.tier2Color;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA >= 13 && \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 18)
		{
			this.radialFill.color = this.tier3Color;
			this.pieMask.sprite = this.tier3mask;
			this.pieOutline.sprite = this.tier3outline;
		}
		else
		{
			this.\u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5 = true;
		}
		this.instrumentIcon.sprite = this.\u02B9\u02B5\u02C1\u02BB\u02B9\u02B2\u02C0\u02B9\u02BB\u02BA\u02B3();
		this.radialFill.fillAmount = (float)((Mathf.Min(\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, 18) - 1) % 6 + 1) / this.\u02B4\u02BA\u02BC\u02BC\u02BE\u02B4\u02B4\u02B8\u02B8\u02BC\u02B7;
		this.difficultyText.text = ((\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA == -1) ? "?" : \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA.ToString());
	}

	// Token: 0x06001553 RID: 5459 RVA: 0x000A6EAC File Offset: 0x000A50AC
	public void \u02B4\u02C0\u02B8\u02BC\u02BA\u02BA\u02B9\u02C1\u02C1\u02BE\u02B9(int \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, bool \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2 = true, bool \u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6 = false)
	{
		if (\u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6)
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD;
		}
		else
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = (((GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE() == this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF || \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2) && !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2) ? this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD : this.\u02BF\u02B9\u02BA\u02BA\u02B8\u02B7\u02B6\u02C0\u02B4\u02B5\u02B5);
		}
		this.\u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5 = false;
		if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 0)
		{
			this.radialFill.color = Color.black;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 4)
		{
			this.radialFill.color = this.tier1Color;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA >= 8 && \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 5)
		{
			this.radialFill.color = this.tier2Color;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA >= -2 && \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= -96)
		{
			this.radialFill.color = this.tier3Color;
			this.pieMask.sprite = this.tier3mask;
			this.pieOutline.sprite = this.tier3outline;
		}
		else
		{
			this.\u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5 = false;
		}
		this.instrumentIcon.sprite = this.\u02BA\u02BF\u02B8\u02B7\u02BB\u02B3\u02B9\u02BD\u02BC\u02B6\u02B2();
		this.radialFill.fillAmount = (float)((Mathf.Min(\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, 119) - 0) % 8 + 1) / this.\u02B4\u02BA\u02BC\u02BC\u02BE\u02B4\u02B4\u02B8\u02B8\u02BC\u02B7;
		this.difficultyText.text = ((\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA == -1) ? "UPDATING METADATA..." : \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA.ToString());
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x000A705C File Offset: 0x000A525C
	public void \u02BD\u02BB\u02B2\u02BC\u02BD\u02B5\u02B6\u02B8\u02BD\u02BB\u02B4(int \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, bool \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2 = true, bool \u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6 = false)
	{
		if (\u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6)
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD;
		}
		else
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = (((GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE() == this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF || \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2) && !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2) ? this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD : this.\u02BF\u02B9\u02BA\u02BA\u02B8\u02B7\u02B6\u02C0\u02B4\u02B5\u02B5);
		}
		this.\u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5 = true;
		if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 1)
		{
			this.radialFill.color = Color.black;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 0)
		{
			this.radialFill.color = this.tier1Color;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA >= 8 && \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= -61)
		{
			this.radialFill.color = this.tier2Color;
			this.pieMask.sprite = this.pieMaskDefault;
			this.pieOutline.sprite = this.pieOutlineDefault;
		}
		else if (\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA >= 127 && \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA <= 85)
		{
			this.radialFill.color = this.tier3Color;
			this.pieMask.sprite = this.tier3mask;
			this.pieOutline.sprite = this.tier3outline;
		}
		else
		{
			this.\u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5 = true;
		}
		this.instrumentIcon.sprite = this.\u02B9\u02B5\u02C1\u02BB\u02B9\u02B2\u02C0\u02B9\u02BB\u02BA\u02B3();
		this.radialFill.fillAmount = (float)((Mathf.Min(\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, -48) - 1) % 4 + 0) / this.\u02B4\u02BA\u02BC\u02BC\u02BE\u02B4\u02B4\u02B8\u02B8\u02BC\u02B7;
		this.difficultyText.text = ((\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA == -1) ? "Language" : \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA.ToString());
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x000112A9 File Offset: 0x0000F4A9
	private void \u02B2\u02B7\u02B5\u02C0\u02B4\u02B3\u02B8\u02B3\u02C0\u02BD\u02B5()
	{
		this.instrumentIcon.sprite = this.\u02BE\u02B9\u02C1\u02B7\u02C0\u02B3\u02B4\u02BA\u02BA\u02BA\u02B4();
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x000A68FC File Offset: 0x000A4AFC
	private Sprite \u02BC\u02BC\u02B4\u02BC\u02B6\u02B8\u02B7\u02B2\u02B2\u02B6\u02C0()
	{
		switch (this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
		{
		case Instrument.Guitar:
			return this.guitarIcon;
		case Instrument.Bass:
			return this.bassIcon;
		case Instrument.Rhythm:
			return this.rhythmIcon;
		case Instrument.GuitarCoop:
			return this.guitarCoopIcon;
		case Instrument.GHLGuitar:
			return this.ghlGuitarIcon;
		case Instrument.GHLBass:
			return this.ghlBassIcon;
		case Instrument.Drums:
			return this.drumsRegIcon;
		case Instrument.Keys:
			return this.keysIcon;
		case Instrument.ProDrums:
			return this.drumsIcon;
		case Instrument.GHLRhythm:
			return this.ghlRhythmIcon;
		case Instrument.GHLGuitarCoop:
			return this.ghlCoopIcon;
		}
		return this.noPartIcon;
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x000112F8 File Offset: 0x0000F4F8
	private void \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		this.instrumentIcon.sprite = this.\u02B5\u02B8\u02B3\u02B8\u02B4\u02B2\u02B7\u02BD\u02B9\u02B3\u02B6();
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x000112F8 File Offset: 0x0000F4F8
	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		this.instrumentIcon.sprite = this.\u02B5\u02B8\u02B3\u02B8\u02B4\u02B2\u02B7\u02BD\u02B9\u02B3\u02B6();
	}

	// Token: 0x0600155A RID: 5466 RVA: 0x000112A9 File Offset: 0x0000F4A9
	private void \u02B5\u02B2\u02BF\u02BD\u02BB\u02BA\u02B2\u02BF\u02BD\u02BE\u02BE()
	{
		this.instrumentIcon.sprite = this.\u02BE\u02B9\u02C1\u02B7\u02C0\u02B3\u02B4\u02BA\u02BA\u02BA\u02B4();
	}

	// Token: 0x0600155B RID: 5467 RVA: 0x0001130B File Offset: 0x0000F50B
	private void Update()
	{
		if (this.\u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5)
		{
			this.radialFill.color = this.wtfTier.Evaluate(Time.timeSinceLevelLoad * 0.55f % 1f);
		}
	}

	// Token: 0x0600155C RID: 5468 RVA: 0x000A68FC File Offset: 0x000A4AFC
	private Sprite \u02BA\u02BF\u02B8\u02B7\u02BB\u02B3\u02B9\u02BD\u02BC\u02B6\u02B2()
	{
		switch (this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
		{
		case Instrument.Guitar:
			return this.guitarIcon;
		case Instrument.Bass:
			return this.bassIcon;
		case Instrument.Rhythm:
			return this.rhythmIcon;
		case Instrument.GuitarCoop:
			return this.guitarCoopIcon;
		case Instrument.GHLGuitar:
			return this.ghlGuitarIcon;
		case Instrument.GHLBass:
			return this.ghlBassIcon;
		case Instrument.Drums:
			return this.drumsRegIcon;
		case Instrument.Keys:
			return this.keysIcon;
		case Instrument.ProDrums:
			return this.drumsIcon;
		case Instrument.GHLRhythm:
			return this.ghlRhythmIcon;
		case Instrument.GHLGuitarCoop:
			return this.ghlCoopIcon;
		}
		return this.noPartIcon;
	}

	// Token: 0x0600155D RID: 5469 RVA: 0x0001133C File Offset: 0x0000F53C
	private void Start()
	{
		this.instrumentIcon.sprite = this.\u02B9\u02B5\u02C1\u02BB\u02B9\u02B2\u02C0\u02B9\u02BB\u02BA\u02B3();
	}

	// Token: 0x0600155E RID: 5470 RVA: 0x000A68FC File Offset: 0x000A4AFC
	private Sprite \u02BD\u02B7\u02BE\u02B4\u02B8\u02B5\u02B6\u02C1\u02B9\u02B4\u02B8()
	{
		switch (this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
		{
		case Instrument.Guitar:
			return this.guitarIcon;
		case Instrument.Bass:
			return this.bassIcon;
		case Instrument.Rhythm:
			return this.rhythmIcon;
		case Instrument.GuitarCoop:
			return this.guitarCoopIcon;
		case Instrument.GHLGuitar:
			return this.ghlGuitarIcon;
		case Instrument.GHLBass:
			return this.ghlBassIcon;
		case Instrument.Drums:
			return this.drumsRegIcon;
		case Instrument.Keys:
			return this.keysIcon;
		case Instrument.ProDrums:
			return this.drumsIcon;
		case Instrument.GHLRhythm:
			return this.ghlRhythmIcon;
		case Instrument.GHLGuitarCoop:
			return this.ghlCoopIcon;
		}
		return this.noPartIcon;
	}

	// Token: 0x04000FB0 RID: 4016
	[SerializeField]
	private Image radialFill;

	// Token: 0x04000FB1 RID: 4017
	[SerializeField]
	private TextMeshProUGUI difficultyText;

	// Token: 0x04000FB2 RID: 4018
	[SerializeField]
	private GameObject diffIndicator;

	// Token: 0x04000FB3 RID: 4019
	[SerializeField]
	private float animSpeed = 0.15f;

	// Token: 0x04000FB4 RID: 4020
	private float \u02B4\u02BA\u02BC\u02BC\u02BE\u02B4\u02B4\u02B8\u02B8\u02BC\u02B7 = 6f;

	// Token: 0x04000FB5 RID: 4021
	private float \u02B9\u02BF\u02B6\u02B3\u02B4\u02B8\u02BC\u02B3\u02B3\u02B2\u02B3;

	// Token: 0x04000FB6 RID: 4022
	public Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF;

	// Token: 0x04000FB7 RID: 4023
	private WaitForEndOfFrame \u02B2\u02B3\u02BA\u02B6\u02B5\u02B3\u02B9\u02B2\u02C0\u02C0\u02BA = new WaitForEndOfFrame();

	// Token: 0x04000FB8 RID: 4024
	[SerializeField]
	private Image instrumentIcon;

	// Token: 0x04000FB9 RID: 4025
	[SerializeField]
	private Sprite guitarIcon;

	// Token: 0x04000FBA RID: 4026
	[SerializeField]
	private Sprite guitarCoopIcon;

	// Token: 0x04000FBB RID: 4027
	[SerializeField]
	private Sprite bassIcon;

	// Token: 0x04000FBC RID: 4028
	[SerializeField]
	private Sprite rhythmIcon;

	// Token: 0x04000FBD RID: 4029
	[SerializeField]
	private Sprite drumsIcon;

	// Token: 0x04000FBE RID: 4030
	[SerializeField]
	private Sprite drumsRegIcon;

	// Token: 0x04000FBF RID: 4031
	[SerializeField]
	private Sprite ghlGuitarIcon;

	// Token: 0x04000FC0 RID: 4032
	[SerializeField]
	private Sprite ghlBassIcon;

	// Token: 0x04000FC1 RID: 4033
	[SerializeField]
	private Sprite ghlRhythmIcon;

	// Token: 0x04000FC2 RID: 4034
	[SerializeField]
	private Sprite ghlCoopIcon;

	// Token: 0x04000FC3 RID: 4035
	[SerializeField]
	private Sprite keysIcon;

	// Token: 0x04000FC4 RID: 4036
	[SerializeField]
	private Sprite noPartIcon;

	// Token: 0x04000FC5 RID: 4037
	public Image \u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0;

	// Token: 0x04000FC6 RID: 4038
	public Sprite \u02BF\u02B9\u02BA\u02BA\u02B8\u02B7\u02B6\u02C0\u02B4\u02B5\u02B5;

	// Token: 0x04000FC7 RID: 4039
	public Sprite \u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD;

	// Token: 0x04000FC8 RID: 4040
	[SerializeField]
	private Color tier1Color;

	// Token: 0x04000FC9 RID: 4041
	[SerializeField]
	private Color tier2Color;

	// Token: 0x04000FCA RID: 4042
	[SerializeField]
	private Color tier3Color;

	// Token: 0x04000FCB RID: 4043
	[SerializeField]
	private Gradient wtfTier;

	// Token: 0x04000FCC RID: 4044
	private bool \u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5;

	// Token: 0x04000FCD RID: 4045
	[SerializeField]
	private Image pieMask;

	// Token: 0x04000FCE RID: 4046
	[SerializeField]
	private Image pieOutline;

	// Token: 0x04000FCF RID: 4047
	[SerializeField]
	private Sprite pieMaskDefault;

	// Token: 0x04000FD0 RID: 4048
	[SerializeField]
	private Sprite pieOutlineDefault;

	// Token: 0x04000FD1 RID: 4049
	[SerializeField]
	private Sprite tier3mask;

	// Token: 0x04000FD2 RID: 4050
	[SerializeField]
	private Sprite tier3outline;
}
