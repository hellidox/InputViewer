using System;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyDisplay : MonoBehaviour
{
	private void \u02B2\u02BB\u02B6\u02B5\u02B9\u02B8\u02B2\u02B3\u02BF\u02C1\u02BF()
	{
		this.instrumentIcon.sprite = this.\u02BE\u02B9\u02C1\u02B7\u02C0\u02B3\u02B4\u02BA\u02BA\u02BA\u02B4();
	}

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

	private void \u02B7\u02B8\u02BD\u02C0\u02B2\u02B4\u02B7\u02C0\u02BC\u02BE\u02B3()
	{
		this.instrumentIcon.sprite = this.\u02BD\u02B7\u02BE\u02B4\u02B8\u02B5\u02B6\u02C1\u02B9\u02B4\u02B8();
	}

	public void \u02B3\u02BB\u02B3\u02B8\u02B2\u02B8\u02B8\u02B6\u02BA\u02B7\u02BE(int \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, bool \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2 = true, bool \u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6 = false)
	{
		if (\u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6)
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD;
		}
		else
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = (((GlobalVariables.instance.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE() == this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF || \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2) && !GlobalVariables.instance.\u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2) ? this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD : this.\u02BF\u02B9\u02BA\u02BA\u02B8\u02B7\u02B6\u02C0\u02B4\u02B5\u02B5);
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

	public void \u02B8\u02BE\u02BA\u02B6\u02BD\u02BA\u02B5\u02B6\u02BA\u02B9\u02B8(int \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, bool \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2 = true, bool \u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6 = false)
	{
		if (\u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6)
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD;
		}
		else
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = (((GlobalVariables.instance.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE() == this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF || \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2) && !GlobalVariables.instance.\u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2) ? this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD : this.\u02BF\u02B9\u02BA\u02BA\u02B8\u02B7\u02B6\u02C0\u02B4\u02B5\u02B5);
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

	public void \u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC(int \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, bool \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2 = true, bool \u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6 = false)
	{
		if (\u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6)
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD;
		}
		else
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = (((GlobalVariables.instance.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE() == this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF || \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2) && !GlobalVariables.instance.\u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2) ? this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD : this.\u02BF\u02B9\u02BA\u02BA\u02B8\u02B7\u02B6\u02C0\u02B4\u02B5\u02B5);
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

	public void \u02B4\u02C0\u02B8\u02BC\u02BA\u02BA\u02B9\u02C1\u02C1\u02BE\u02B9(int \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, bool \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2 = true, bool \u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6 = false)
	{
		if (\u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6)
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD;
		}
		else
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = (((GlobalVariables.instance.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE() == this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF || \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2) && !GlobalVariables.instance.\u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2) ? this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD : this.\u02BF\u02B9\u02BA\u02BA\u02B8\u02B7\u02B6\u02C0\u02B4\u02B5\u02B5);
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

	public void \u02BD\u02BB\u02B2\u02BC\u02BD\u02B5\u02B6\u02B8\u02BD\u02BB\u02B4(int \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, bool \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2 = true, bool \u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6 = false)
	{
		if (\u02B8\u02C1\u02BB\u02BE\u02B5\u02B5\u02B5\u02B2\u02BC\u02B5\u02B6)
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD;
		}
		else
		{
			this.\u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0.sprite = (((GlobalVariables.instance.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE() == this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF || \u02B2\u02C1\u02BF\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02B3\u02B2) && !GlobalVariables.instance.\u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2) ? this.\u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD : this.\u02BF\u02B9\u02BA\u02BA\u02B8\u02B7\u02B6\u02C0\u02B4\u02B5\u02B5);
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

	private void \u02B2\u02B7\u02B5\u02C0\u02B4\u02B3\u02B8\u02B3\u02C0\u02BD\u02B5()
	{
		this.instrumentIcon.sprite = this.\u02BE\u02B9\u02C1\u02B7\u02C0\u02B3\u02B4\u02BA\u02BA\u02BA\u02B4();
	}

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

	private void \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		this.instrumentIcon.sprite = this.\u02B5\u02B8\u02B3\u02B8\u02B4\u02B2\u02B7\u02BD\u02B9\u02B3\u02B6();
	}

	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		this.instrumentIcon.sprite = this.\u02B5\u02B8\u02B3\u02B8\u02B4\u02B2\u02B7\u02BD\u02B9\u02B3\u02B6();
	}

	private void \u02B5\u02B2\u02BF\u02BD\u02BB\u02BA\u02B2\u02BF\u02BD\u02BE\u02BE()
	{
		this.instrumentIcon.sprite = this.\u02BE\u02B9\u02C1\u02B7\u02C0\u02B3\u02B4\u02BA\u02BA\u02BA\u02B4();
	}

	private void Update()
	{
		if (this.\u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5)
		{
			this.radialFill.color = this.wtfTier.Evaluate(Time.timeSinceLevelLoad * 0.55f % 1f);
		}
	}

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

	private void Start()
	{
		this.instrumentIcon.sprite = this.\u02B9\u02B5\u02C1\u02BB\u02B9\u02B2\u02C0\u02B9\u02BB\u02BA\u02B3();
	}

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

	[SerializeField]
	private Image radialFill;

	[SerializeField]
	private TextMeshProUGUI difficultyText;

	[SerializeField]
	private GameObject diffIndicator;

	[SerializeField]
	private float animSpeed = 0.15f;

	private float \u02B4\u02BA\u02BC\u02BC\u02BE\u02B4\u02B4\u02B8\u02B8\u02BC\u02B7 = 6f;

	private float \u02B9\u02BF\u02B6\u02B3\u02B4\u02B8\u02BC\u02B3\u02B3\u02B2\u02B3;

	public Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF;

	private WaitForEndOfFrame \u02B2\u02B3\u02BA\u02B6\u02B5\u02B3\u02B9\u02B2\u02C0\u02C0\u02BA = new WaitForEndOfFrame();

	[SerializeField]
	private Image instrumentIcon;

	[SerializeField]
	private Sprite guitarIcon;

	[SerializeField]
	private Sprite guitarCoopIcon;

	[SerializeField]
	private Sprite bassIcon;

	[SerializeField]
	private Sprite rhythmIcon;

	[SerializeField]
	private Sprite drumsIcon;

	[SerializeField]
	private Sprite drumsRegIcon;

	[SerializeField]
	private Sprite ghlGuitarIcon;

	[SerializeField]
	private Sprite ghlBassIcon;

	[SerializeField]
	private Sprite ghlRhythmIcon;

	[SerializeField]
	private Sprite ghlCoopIcon;

	[SerializeField]
	private Sprite keysIcon;

	[SerializeField]
	private Sprite noPartIcon;

	public Image \u02B4\u02B4\u02BC\u02B2\u02B6\u02BD\u02BF\u02B5\u02B3\u02B2\u02C0;

	public Sprite \u02BF\u02B9\u02BA\u02BA\u02B8\u02B7\u02B6\u02C0\u02B4\u02B5\u02B5;

	public Sprite \u02B9\u02C1\u02BB\u02B9\u02B9\u02B2\u02BF\u02BC\u02BD\u02B2\u02BD;

	[SerializeField]
	private Color tier1Color;

	[SerializeField]
	private Color tier2Color;

	[SerializeField]
	private Color tier3Color;

	[SerializeField]
	private Gradient wtfTier;

	private bool \u02B2\u02B2\u02B9\u02B6\u02B8\u02B7\u02BE\u02B8\u02BD\u02C0\u02B5;

	[SerializeField]
	private Image pieMask;

	[SerializeField]
	private Image pieOutline;

	[SerializeField]
	private Sprite pieMaskDefault;

	[SerializeField]
	private Sprite pieOutlineDefault;

	[SerializeField]
	private Sprite tier3mask;

	[SerializeField]
	private Sprite tier3outline;
}
