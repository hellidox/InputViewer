using System;
using System.IO;
using StrikeCore;
using UnityEngine;

public class \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 : BasePlayerProfile
{
	public Difficulty \u02BF\u02B8\u02BD\u02BA\u02BE\u02BD\u02B4\u02BB\u02BC\u02B2\u02BE
	{
		set
		{
			this.\u02C1\u02BD\u02BA\u02B2\u02B5\u02BC\u02C1\u02BF\u02B6\u02BB\u02BD = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B7\u02C0\u02BD\u02B5\u02BF\u02C1\u02BF\u02BC\u02BA\u02B7\u02BD(value);
			this.difficulty = value;
		}
	}

	public bool \u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3
	{
		get
		{
			return base.IsAnyDrumsController && SettingsController.drum_pad_scrolling.GetBoolValue;
		}
	}

	public static string \u02B4\u02C0\u02BF\u02B6\u02BC\u02BE\u02B6\u02C1\u02B4\u02BD\u02B7(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		string text = "PlayerID: ";
		switch (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA)
		{
		case Difficulty.Easy:
			text += LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("<b>0</b>%");
			break;
		case Difficulty.Medium:
			text += LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("song");
			break;
		case Difficulty.Hard:
			text += LanguageManager.instance.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(".");
			break;
		case Difficulty.Expert:
			text += LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("Continue");
			break;
		}
		text += "profiles";
		switch (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
		{
		case Instrument.Guitar:
			text += LanguageManager.instance.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Prefabs/Gameplay/Notes/Sustain");
			break;
		case Instrument.Bass:
			text += LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("song");
			break;
		case Instrument.Rhythm:
			text += LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("Whammy Texture");
			break;
		case Instrument.GuitarCoop:
			text += LanguageManager.instance.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("{0}%");
			break;
		case Instrument.GHLGuitar:
			text += LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Audio Offset");
			break;
		case Instrument.GHLBass:
			text += LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("diff_guitar_coop");
			break;
		case Instrument.Drums:
			text += LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("Expert");
			break;
		case Instrument.Keys:
			text += LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().GetString("FSCache Clear Thread");
			break;
		case Instrument.Band:
			text += LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("song");
			break;
		case Instrument.ProDrums:
			text += LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(" ");
			break;
		case Instrument.GHLRhythm:
			text += LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Restart");
			break;
		case Instrument.GHLGuitarCoop:
			text += LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("Gameplay");
			break;
		}
		return text;
	}

	public void \u02B4\u02BF\u02B9\u02BF\u02B3\u02B9\u02B9\u02B6\u02B5\u02BF\u02BB()
	{
		int num = global::UnityEngine.Random.Range(0, GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Count);
		this.colorSettings = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02C0\u02BB\u02B2\u02B6\u02B4\u02B3\u02BF\u02B2\u02B5\u02B8\u02BA(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD[num]);
	}

	public static string \u02C1\u02B6\u02BD\u02B6\u02BE\u02BB\u02BC\u02B8\u02BF\u02B7\u02BF(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		string text = "";
		switch (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA)
		{
		case Difficulty.Easy:
			text += LanguageManager.instance.GetString("Easy");
			break;
		case Difficulty.Medium:
			text += LanguageManager.instance.GetString("Medium");
			break;
		case Difficulty.Hard:
			text += LanguageManager.instance.GetString("Hard");
			break;
		case Difficulty.Expert:
			text += LanguageManager.instance.GetString("Expert");
			break;
		}
		text += " ";
		switch (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
		{
		case Instrument.Guitar:
			text += LanguageManager.instance.GetString("Lead Guitar");
			break;
		case Instrument.Bass:
			text += LanguageManager.instance.GetString("Bass Guitar");
			break;
		case Instrument.Rhythm:
			text += LanguageManager.instance.GetString("Rhythm Guitar");
			break;
		case Instrument.GuitarCoop:
			text += LanguageManager.instance.GetString("Guitar Coop");
			break;
		case Instrument.GHLGuitar:
			text += LanguageManager.instance.GetString("6 Fret Lead Guitar");
			break;
		case Instrument.GHLBass:
			text += LanguageManager.instance.GetString("6 Fret Bass Guitar");
			break;
		case Instrument.Drums:
			text += LanguageManager.instance.GetString("Drums");
			break;
		case Instrument.Keys:
			text += LanguageManager.instance.GetString("Keys");
			break;
		case Instrument.Band:
			text += LanguageManager.instance.GetString("Band");
			break;
		case Instrument.ProDrums:
			text += LanguageManager.instance.GetString("Pro Drums");
			break;
		case Instrument.GHLRhythm:
			text += LanguageManager.instance.GetString("6 Fret Rhythm");
			break;
		case Instrument.GHLGuitarCoop:
			text += LanguageManager.instance.GetString("6 Fret Guitar Coop");
			break;
		}
		return text;
	}

	public void \u02BA\u02BD\u02BF\u02C1\u02B3\u02B9\u02B6\u02B7\u02BD\u02C1\u02BC(Instrument \u02BD\u02C0\u02B9\u02BC\u02B9\u02B3\u02BE\u02B2\u02C0\u02B9\u02B7, Difficulty \u02BE\u02B6\u02BE\u02BB\u02BD\u02BC\u02BF\u02BF\u02B7\u02B6\u02C1)
	{
		this.\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1 = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02C1\u02B8\u02B6\u02B9\u02B6\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9(\u02BD\u02C0\u02B9\u02BC\u02B9\u02B3\u02BE\u02B2\u02C0\u02B9\u02B7);
		this.\u02C1\u02BD\u02BA\u02B2\u02B5\u02BC\u02C1\u02BF\u02B6\u02BB\u02BD = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B7\u02C0\u02BD\u02B5\u02BF\u02C1\u02BF\u02BC\u02BA\u02B7\u02BD(\u02BE\u02B6\u02BE\u02BB\u02BD\u02BC\u02BF\u02BF\u02B7\u02B6\u02C1);
		this.instrument = \u02BD\u02C0\u02B9\u02BC\u02B9\u02B3\u02BE\u02B2\u02C0\u02B9\u02B7;
		this.difficulty = \u02BE\u02B6\u02BE\u02BB\u02BD\u02BC\u02BF\u02BF\u02B7\u02B6\u02C1;
	}

	public static string \u02B5\u02BE\u02BE\u02B7\u02BB\u02BC\u02B3\u02B4\u02BA\u02B3\u02B2(Modifier \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		string text = "";
		int num = 0;
		if (\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE == Modifier.Unknown)
		{
			return LanguageManager.instance.GetString("Unknown Modifiers");
		}
		if (\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE == Modifier.None)
		{
			return LanguageManager.instance.GetString("nomodifiers");
		}
		if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.DrunkMode) == Modifier.DrunkMode)
		{
			text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("Drunk Mode");
		}
		if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.PrecisionMode) == Modifier.PrecisionMode)
		{
			text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("Precision Mode");
		}
		if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.BrutalMode) == Modifier.BrutalMode)
		{
			text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("Brutal Mode");
		}
		if (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.Drums || \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.ProDrums)
		{
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.AllStrums) == Modifier.AllStrums)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("2x Kick");
			}
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.AllHOPOs) == Modifier.AllHOPOs)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("No Kick");
			}
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.AllTaps) == Modifier.AllTaps)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("Kick Only");
			}
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.AllOpens) == Modifier.AllOpens)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("Deadly Dynamics");
			}
		}
		else
		{
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.StrumlessHopos) == Modifier.StrumlessHopos)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("Strumless HOPOs");
			}
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.DroplessSustains) == Modifier.DroplessSustains)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("Dropless Sustains");
			}
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.DoubleNotes) == Modifier.DoubleNotes)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("Double Notes");
			}
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.NoFretGhosting) == Modifier.NoFretGhosting)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("No Fret Ghosting");
			}
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.AllHOPOs) == Modifier.AllHOPOs)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("All HOPO's");
			}
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.AllOpens) == Modifier.AllOpens)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("All Opens");
			}
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.AllStrums) == Modifier.AllStrums)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("All Strums");
			}
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.AllTaps) == Modifier.AllTaps)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("All Taps");
			}
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.HOPOsToTaps) == Modifier.HOPOsToTaps)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("HOPO's to Taps");
			}
			if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.AutoStrum) == Modifier.AutoStrum)
			{
				text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("Auto Strum");
			}
		}
		if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.MirrorMode) == Modifier.MirrorMode)
		{
			text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("Mirror Mode");
		}
		if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.Shuffle) == Modifier.Shuffle)
		{
			text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("Note Shuffle");
		}
		if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.LightsOut) == Modifier.LightsOut)
		{
			text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("Lights Out");
		}
		if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.ModFull) == Modifier.ModFull)
		{
			text = text + ((++num > 1) ? " + " : "") + LanguageManager.instance.GetString("ModChart Full");
		}
		if ((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & Modifier.ModLite) == Modifier.ModLite)
		{
			text = text + ((num + 1 > 1) ? " + " : "") + LanguageManager.instance.GetString("ModChart Lite");
		}
		return text;
	}

	public void \u02BE\u02BB\u02C1\u02B6\u02B8\u02BF\u02B4\u02C0\u02B6\u02BE\u02B8(BinaryReader \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8)
	{
		this.playerName.ReadBinary(\u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8);
		\u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.BaseStream.Position += (long)(15 - this.playerName.CurrentValue.Length);
		this.noteSpeed.CurrentValue = (int)\u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadByte();
		this.tilt.CurrentValue = (int)\u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadByte();
		this.leftyFlip.CurrentValue = (int)\u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadByte();
		this.gamepadMode.CurrentValue = (int)\u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadByte();
		this.displayName.CurrentValue = (int)\u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadByte();
		this.isBot.CurrentValue = (int)\u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadByte();
		this.controllerType.CurrentValue = (int)\u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadByte();
		this.highwayIndex.MaxValue = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Count - 1;
		\u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt16();
	}

	public Instrument \u02B9\u02BC\u02BA\u02BD\u02B7\u02B9\u02B9\u02BE\u02B6\u02C1\u02B9
	{
		set
		{
			this.\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1 = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02C1\u02B8\u02B6\u02B9\u02B6\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9(value);
			this.instrument = value;
		}
	}

	public void \u02BE\u02B5\u02BD\u02B3\u02B3\u02C1\u02BC\u02BC\u02BE\u02B6\u02B7(Instrument \u02BD\u02C0\u02B9\u02BC\u02B9\u02B3\u02BE\u02B2\u02C0\u02B9\u02B7, Difficulty \u02BE\u02B6\u02BE\u02BB\u02BD\u02BC\u02BF\u02BF\u02B7\u02B6\u02C1)
	{
		this.\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1 = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02C1\u02B8\u02B6\u02B9\u02B6\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9(\u02BD\u02C0\u02B9\u02BC\u02B9\u02B3\u02BE\u02B2\u02C0\u02B9\u02B7);
		this.\u02C1\u02BD\u02BA\u02B2\u02B5\u02BC\u02C1\u02BF\u02B6\u02BB\u02BD = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B7\u02C0\u02BD\u02B5\u02BF\u02C1\u02BF\u02BC\u02BA\u02B7\u02BD(\u02BE\u02B6\u02BE\u02BB\u02BD\u02BC\u02BF\u02BF\u02B7\u02B6\u02C1);
		this.instrument = \u02BD\u02C0\u02B9\u02BC\u02B9\u02B3\u02BE\u02B2\u02C0\u02B9\u02B7;
		this.difficulty = \u02BE\u02B6\u02BE\u02BB\u02BD\u02BC\u02BF\u02BF\u02B7\u02B6\u02C1;
	}

	public void \u02B3\u02B9\u02C1\u02B5\u02BC\u02C1\u02C0\u02BA\u02B9\u02B4\u02B2(CHPlayer \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		this.instrument = \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02B2\u02B8\u02B3\u02BC\u02B7\u02B8\u02C1\u02B6\u02BE\u02B2\u02B7(this.controllerType.GetControllerType);
		if ((this.instrument == Instrument.Drums || this.instrument == Instrument.ProDrums) && MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
		{
			MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B2\u02BE\u02BF\u02BB\u02C0\u02BE\u02BD\u02B9\u02BC\u02BB(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7, this.\u02BA\u02C0\u02BC\u02BB\u02B7\u02B3\u02B8\u02BA\u02B2\u02B9\u02BA.CurrentValue);
		}
		this.colorSettings = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02C0\u02BB\u02B2\u02B6\u02B4\u02B3\u02BF\u02B2\u02B5\u02B8\u02BA(this.colorProfileName);
	}

	public \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8(int \u02B2\u02B9\u02BC\u02BD\u02BF\u02BE\u02B5\u02B6\u02B9\u02BF\u02BC, string \u02BB\u02B2\u02C0\u02BB\u02B3\u02C0\u02B6\u02BB\u02BF\u02B7\u02BD)
		: base(\u02B2\u02B9\u02BC\u02BD\u02BF\u02BE\u02B5\u02B6\u02B9\u02BF\u02BC, GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Count, GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Count, \u02BB\u02B2\u02C0\u02BB\u02B3\u02C0\u02B6\u02BB\u02BF\u02B7\u02BD)
	{
		string text = string.Format("profile{0}", \u02B2\u02B9\u02BC\u02BD\u02BF\u02BE\u02B5\u02B6\u02B9\u02BF\u02BC);
		base.Section = Settings.RegisterSection(\u02BB\u02B2\u02C0\u02BB\u02B3\u02C0\u02B6\u02BB\u02BF\u02B7\u02BD, text);
		this.\u02BA\u02C0\u02BC\u02BB\u02B7\u02B3\u02B8\u02BA\u02B2\u02B9\u02BA = new GameSetting(base.Section, "midi_device_id", -1, -1, 0, 1);
		this.\u02C1\u02BA\u02BA\u02B7\u02BB\u02BC\u02B7\u02BE\u02BD\u02B4\u02BC = new GameSetting(base.Section, "dynamics_threshold", 100, 1, 127, 1);
	}

	public void \u02B6\u02C0\u02BE\u02BE\u02BE\u02C0\u02B2\u02BA\u02BC\u02BF\u02BD(Instrument \u02BD\u02C0\u02B9\u02BC\u02B9\u02B3\u02BE\u02B2\u02C0\u02B9\u02B7, Difficulty \u02BE\u02B6\u02BE\u02BB\u02BD\u02BC\u02BF\u02BF\u02B7\u02B6\u02C1)
	{
		this.\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1 = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02C1\u02B8\u02B6\u02B9\u02B6\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9(\u02BD\u02C0\u02B9\u02BC\u02B9\u02B3\u02BE\u02B2\u02C0\u02B9\u02B7);
		this.\u02C1\u02BD\u02BA\u02B2\u02B5\u02BC\u02C1\u02BF\u02B6\u02BB\u02BD = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B7\u02C0\u02BD\u02B5\u02BF\u02C1\u02BF\u02BC\u02BA\u02B7\u02BD(\u02BE\u02B6\u02BE\u02BB\u02BD\u02BC\u02BF\u02BF\u02B7\u02B6\u02C1);
		this.instrument = \u02BD\u02C0\u02B9\u02BC\u02B9\u02B3\u02BE\u02B2\u02C0\u02B9\u02B7;
		this.difficulty = \u02BE\u02B6\u02BE\u02BB\u02BD\u02BC\u02BF\u02BF\u02B7\u02B6\u02C1;
	}

	public static Instrument \u02B2\u02BE\u02B4\u02BC\u02B4\u02B5\u02BE\u02B6\u02B8\u02B9\u02B2(ControllerType \u02BA\u02BE\u02B7\u02C1\u02B5\u02B3\u02BC\u02BC\u02BF\u02C1\u02B7)
	{
		switch (\u02BA\u02BE\u02B7\u02C1\u02B5\u02B3\u02BC\u02BC\u02BF\u02C1\u02B7)
		{
		case ControllerType.Guitar:
			return Instrument.Guitar;
		case ControllerType.GHLGuitar:
			return Instrument.GHLBass;
		case ControllerType.Drums:
		case ControllerType.FiveLaneDrums:
			return Instrument.Band;
		default:
			return Instrument.Guitar;
		}
	}

	public \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 \u02BD\u02B2\u02BE\u02B8\u02BF\u02B7\u02B2\u02B6\u02B2\u02BB\u02C1()
	{
		return new \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8(-1, "")
		{
			difficulty = this.difficulty,
			\u02C1\u02BD\u02BA\u02B2\u02B5\u02BC\u02C1\u02BF\u02B6\u02BB\u02BD = this.\u02C1\u02BD\u02BA\u02B2\u02B5\u02BC\u02C1\u02BF\u02B6\u02BB\u02BD,
			instrument = this.instrument,
			\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1 = this.\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1,
			isBot = 
			{
				CurrentValue = this.isBot.CurrentValue
			},
			controllerType = 
			{
				CurrentValue = this.controllerType.CurrentValue
			},
			noteModifier = this.noteModifier,
			playerName = 
			{
				CurrentValue = this.playerName.CurrentValue
			},
			noteSpeed = 
			{
				CurrentValue = this.noteSpeed.CurrentValue
			},
			highwayLength = 
			{
				CurrentValue = this.highwayLength.CurrentValue
			},
			highwayName = 
			{
				CurrentValue = this.highwayName.CurrentValue
			},
			colorProfileName = 
			{
				CurrentValue = this.colorProfileName.CurrentValue
			},
			drumDynamicsHidden = 
			{
				CurrentValue = this.drumDynamicsHidden.CurrentValue
			},
			squareTomNotes = 
			{
				CurrentValue = this.squareTomNotes.CurrentValue
			},
			altTaps = 
			{
				CurrentValue = this.altTaps.CurrentValue
			},
			leftyFlip = 
			{
				CurrentValue = this.leftyFlip.CurrentValue
			}
		};
	}

	public static Instrument \u02B2\u02B8\u02B3\u02BC\u02B7\u02B8\u02C1\u02B6\u02BE\u02B2\u02B7(ControllerType \u02BA\u02BE\u02B7\u02C1\u02B5\u02B3\u02BC\u02BC\u02BF\u02C1\u02B7)
	{
		switch (\u02BA\u02BE\u02B7\u02C1\u02B5\u02B3\u02BC\u02BC\u02BF\u02C1\u02B7)
		{
		case ControllerType.Guitar:
			return Instrument.Guitar;
		case ControllerType.GHLGuitar:
			return Instrument.GHLGuitar;
		case ControllerType.Drums:
		case ControllerType.FiveLaneDrums:
			return Instrument.ProDrums;
		default:
			return Instrument.Guitar;
		}
	}

	public \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE \u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1;

	public \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 \u02C1\u02BD\u02BA\u02B2\u02B5\u02BC\u02C1\u02BF\u02B6\u02BB\u02BD;

	public GameSetting \u02BA\u02C0\u02BC\u02BB\u02B7\u02B3\u02B8\u02BA\u02B2\u02B9\u02BA;

	public GameSetting \u02C1\u02BA\u02BA\u02B7\u02BB\u02BC\u02B7\u02BE\u02BD\u02B4\u02BC;

	public bool \u02BE\u02B6\u02C1\u02B9\u02B7\u02BB\u02B6\u02B7\u02BC\u02BF\u02B2;
}
