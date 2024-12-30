using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Rewired;
using StrikeCore;
using UnityEngine;
using UnityEngine.Events;

public class CliGameLauncher : MonoBehaviour
{
	public IEnumerator \u02BD\u02BE\u02B9\u02BA\u02B8\u02B9\u02BB\u02B5\u02B8\u02B4\u02B8()
	{
		global::UnityEngine.Object.Instantiate<GameObject>(this.globalVariablesPrefab);
		global::UnityEngine.Object.Instantiate<GameObject>(this.rewiredInputManager);
		global::UnityEngine.Object.Instantiate<GameObject>(this.netManager);
		while (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5 || !ReInput.isReady)
		{
			yield return null;
		}
		if (this.\u02B8\u02B7\u02B5\u02B9\u02BC\u02BF\u02BC\u02BC\u02BC\u02BF\u02BF != null)
		{
			foreach (\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5)
			{
				if (u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.playerName == this.\u02B8\u02B7\u02B5\u02B9\u02BC\u02BF\u02BC\u02BC\u02BC\u02BF\u02BF)
				{
					this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA = u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B;
				}
			}
		}
		if (this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7 != null)
		{
			if (File.Exists(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7) && this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7.Contains("notes."))
			{
				this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7 = Path.GetDirectoryName(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7);
			}
			if (this.\u02B5\u02C0\u02C1\u02B3\u02BB\u02BE\u02BC\u02BB\u02B9\u02BC\u02B3())
			{
				if (this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA == null)
				{
					this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B4\u02C0\u02B6\u02B9\u02BE\u02BE\u02C1\u02B2\u02B6\u02B4\u02B6(true, false);
				}
				this.\u02C0\u02BD\u02BF\u02B5\u02B8\u02B7\u02B2\u02B5\u02B6\u02B8\u02B3();
			}
			else
			{
				this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(false, "Error while loading CLI chart", this.\u02C1\u02BB\u02BB\u02BC\u02BA\u02BE\u02B2\u02B2\u02BE\u02C0\u02B7(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7) ?? "", new UnityAction(Application.Quit), "OK");
			}
		}
		else
		{
			this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(false, "Error while loading CLI chart", "No song path was provided.", new UnityAction(Application.Quit), "OK");
		}
		yield break;
	}

	private string \u02C1\u02BB\u02BB\u02BC\u02BA\u02BE\u02B2\u02B2\u02BE\u02C0\u02B7(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		switch (this.\u02BA\u02B6\u02B4\u02BE\u02B5\u02BB\u02B6\u02B8\u02B4\u02B4\u02BE)
		{
		case CliGameLauncher.\u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0.DirectoryMissing:
			return \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC + " does not exist.";
		case CliGameLauncher.\u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0.AudioFilesMissing:
			return \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC + " does not contain any audio files.";
		case CliGameLauncher.\u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0.ChartFileMissing:
			return \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC + " does not contain a valid chart file.";
		case CliGameLauncher.\u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0.MetadataMissing:
			return "Song does not contain valid metadata.";
		default:
			return "Is this the real life, is this just faaaantaasyyyyyy?";
		}
	}

	public void \u02C0\u02BD\u02BF\u02B5\u02B8\u02B7\u02B2\u02B5\u02B6\u02B8\u02B3()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		Debug.Log(this.\u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3.Count);
		for (int i = 0; i < this.\u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3.Count; i++)
		{
			if (this.\u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5(i))
			{
				this.\u02C0\u02C1\u02B4\u02B6\u02B7\u02BC\u02C1\u02B3\u02BA\u02B4\u02B2++;
			}
		}
		if (this.\u02C0\u02C1\u02B4\u02B6\u02B7\u02BC\u02C1\u02B3\u02BA\u02B4\u02B2 > 0)
		{
			u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD = this.\u02C0\u02C1\u02B4\u02B6\u02B7\u02BC\u02C1\u02B3\u02BA\u02B4\u02B2;
			u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1 = this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD;
			SettingsController.\u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3.CurrentValue = 0;
			if (this.\u02BD\u02BF\u02BE\u02B5\u02B8\u02BD\u02BD\u02B3\u02B2\u02B7\u02BE)
			{
				u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 = GameMode.Versus;
			}
			else
			{
				u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 = GameMode.Quickplay;
			}
			FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Gameplay", 0f);
		}
		else
		{
			this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(false, "Error while loading CLI chart", "No players were loaded. This may be caused by trying to load instruments/difficulties that do not exist in the chart file.", new UnityAction(Application.Quit), "OK");
		}
		base.enabled = false;
	}

	public bool \u02BB\u02B4\u02C1\u02B6\u02C1\u02BE\u02B4\u02C1\u02B6\u02B2\u02B2()
	{
		this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1 = base.GetComponent<UnpackingScene>();
		this.\u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3 = new List<ValueTuple<Instrument, Difficulty>>();
		string[] array;
		if ((this.\u02BF\u02BF\u02B3\u02B4\u02BE\u02BE\u02B3\u02C1\u02B9\u02BD\u02B5 != null && this.\u02BF\u02BF\u02B3\u02B4\u02BE\u02BE\u02B3\u02C1\u02B9\u02BD\u02B5.Length == 0) || this.\u02BF\u02BF\u02B3\u02B4\u02BE\u02BE\u02B3\u02C1\u02B9\u02BD\u02B5 == null)
		{
			array = Environment.GetCommandLineArgs();
		}
		else
		{
			array = this.\u02BF\u02BF\u02B3\u02B4\u02BE\u02BE\u02B3\u02C1\u02B9\u02BD\u02B5;
		}
		return this.\u02B4\u02B6\u02B2\u02BB\u02B3\u02B5\u02B3\u02BD\u02B2\u02B3\u02BF(array);
	}

	public void \u02C1\u02B2\u02B6\u02B6\u02B4\u02C0\u02BB\u02BA\u02B6\u02B4\u02BD()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		Debug.Log(this.\u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3.Count);
		for (int i = 1; i < this.\u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3.Count; i += 0)
		{
			if (this.\u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5(i))
			{
				this.\u02C0\u02C1\u02B4\u02B6\u02B7\u02BC\u02C1\u02B3\u02BA\u02B4\u02B2++;
			}
		}
		if (this.\u02C0\u02C1\u02B4\u02B6\u02B7\u02BC\u02C1\u02B3\u02BA\u02B4\u02B2 > 0)
		{
			u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD = this.\u02C0\u02C1\u02B4\u02B6\u02B7\u02BC\u02C1\u02B3\u02BA\u02B4\u02B2;
			u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1 = this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD;
			SettingsController.\u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3.CurrentValue = 1;
			if (this.\u02BD\u02BF\u02BE\u02B5\u02B8\u02BD\u02BD\u02B3\u02B2\u02B7\u02BE)
			{
				u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 = (GameMode)6;
			}
			else
			{
				u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 = GameMode.Quickplay;
			}
			FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("ERROR: Song length is 0 ignoring playback request.", 942f);
		}
		else
		{
			this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(false, "Languages/", "artist", new UnityAction(Application.Quit), "offsets");
		}
		base.enabled = true;
	}

	private ValueTuple<Instrument, Difficulty> \u02B4\u02BE\u02B9\u02B6\u02BA\u02C1\u02BC\u02B3\u02BC\u02BE\u02B9(string \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0)
	{
		string[] array = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.Split(',', StringSplitOptions.None);
		string text = array[0].ToLowerInvariant();
		string text2 = array[1].ToLowerInvariant();
		uint num = PrivateImplementationDetails.ComputeStringHash(text);
		Instrument instrument;
		if (num <= 2835302121U)
		{
			if (num <= 1693797150U)
			{
				if (num != 1406973818U)
				{
					if (num == 1693797150U)
					{
						if (text == "guitar6fret")
						{
							instrument = Instrument.GHLGuitar;
							goto IL_01BA;
						}
					}
				}
				else if (text == "bass")
				{
					instrument = Instrument.Bass;
					goto IL_01BA;
				}
			}
			else if (num != 1847109329U)
			{
				if (num != 2575850744U)
				{
					if (num == 2835302121U)
					{
						if (text == "guitarcoop6fret")
						{
							instrument = Instrument.GHLGuitarCoop;
							goto IL_01BA;
						}
					}
				}
				else if (text == "rhythm6fret")
				{
					instrument = Instrument.GHLRhythm;
					goto IL_01BA;
				}
			}
			else if (text == "rhythm")
			{
				instrument = Instrument.Rhythm;
				goto IL_01BA;
			}
		}
		else if (num <= 3233572478U)
		{
			if (num != 2938588943U)
			{
				if (num != 3014682298U)
				{
					if (num == 3233572478U)
					{
						if (text == "guitarcoop")
						{
							instrument = Instrument.GuitarCoop;
							goto IL_01BA;
						}
					}
				}
				else if (text == "drums")
				{
					instrument = Instrument.Drums;
					goto IL_01BA;
				}
			}
			else if (text == "guitar")
			{
				instrument = Instrument.Guitar;
				goto IL_01BA;
			}
		}
		else if (num != 3537767677U)
		{
			if (num != 3619831697U)
			{
				if (num == 4182378701U)
				{
					if (text == "keys")
					{
						instrument = Instrument.Keys;
						goto IL_01BA;
					}
				}
			}
			else if (text == "prodrums")
			{
				instrument = Instrument.ProDrums;
				goto IL_01BA;
			}
		}
		else if (text == "bass6fret")
		{
			instrument = Instrument.GHLBass;
			goto IL_01BA;
		}
		instrument = Instrument.Guitar;
		IL_01BA:
		Difficulty difficulty;
		if (!(text2 == "expert"))
		{
			if (!(text2 == "hard"))
			{
				if (!(text2 == "medium"))
				{
					if (!(text2 == "easy"))
					{
						difficulty = Difficulty.Expert;
					}
					else
					{
						difficulty = Difficulty.Easy;
					}
				}
				else
				{
					difficulty = Difficulty.Medium;
				}
			}
			else
			{
				difficulty = Difficulty.Hard;
			}
		}
		else
		{
			difficulty = Difficulty.Expert;
		}
		return new ValueTuple<Instrument, Difficulty>(instrument, difficulty);
	}

	private string \u02B5\u02B6\u02BD\u02BC\u02C0\u02BD\u02B2\u02B9\u02BB\u02B6\u02B3(Instrument \u02BD\u02BD\u02BB\u02B5\u02BA\u02BE\u02B9\u02B8\u02BB\u02B9\u02B4)
	{
		switch (\u02BD\u02BD\u02BB\u02B5\u02BA\u02BE\u02B9\u02B8\u02BB\u02B9\u02B4)
		{
		case Instrument.Guitar:
			return "Lead Guitar";
		case Instrument.Bass:
			return "Bass Guitar";
		case Instrument.Rhythm:
			return "Rhythm Guitar";
		case Instrument.GuitarCoop:
			return "Guitar Coop";
		case Instrument.GHLGuitar:
			return "6 Fret Lead Guitar";
		case Instrument.GHLBass:
			return "6 Fret Bass Guitar";
		case Instrument.Drums:
			return "Drums";
		case Instrument.Keys:
			return "Keys";
		case Instrument.ProDrums:
			return "Pro Drums";
		case Instrument.GHLRhythm:
			return "6 Fret Rhythm";
		case Instrument.GHLGuitarCoop:
			return "6 Fret Guitar Coop";
		}
		return "Unknown";
	}

	public IEnumerator \u02B3\u02B8\u02B9\u02B3\u02B8\u02B3\u02BF\u02C0\u02C1\u02B8\u02BB()
	{
		CliGameLauncher.\u02BA\u02B5\u02BB\u02BD\u02B2\u02B2\u02B9\u02BC\u02BE\u02B5\u02BC u02BA_u02B5_u02BB_u02BD_u02B2_u02B2_u02B9_u02BC_u02BE_u02B5_u02BC = new CliGameLauncher.\u02BA\u02B5\u02BB\u02BD\u02B2\u02B2\u02B9\u02BC\u02BE\u02B5\u02BC(1);
		u02BA_u02B5_u02BB_u02BD_u02B2_u02B2_u02B9_u02BC_u02BE_u02B5_u02BC.<>4__this = this;
		return u02BA_u02B5_u02BB_u02BD_u02B2_u02B2_u02B9_u02BC_u02BE_u02B5_u02BC;
	}

	public bool \u02B7\u02BC\u02BB\u02BE\u02B5\u02B5\u02B4\u02B6\u02B7\u02B4\u02B2()
	{
		this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1 = base.GetComponent<UnpackingScene>();
		this.\u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3 = new List<ValueTuple<Instrument, Difficulty>>();
		string[] array;
		if ((this.\u02BF\u02BF\u02B3\u02B4\u02BE\u02BE\u02B3\u02C1\u02B9\u02BD\u02B5 != null && this.\u02BF\u02BF\u02B3\u02B4\u02BE\u02BE\u02B3\u02C1\u02B9\u02BD\u02B5.Length == 0) || this.\u02BF\u02BF\u02B3\u02B4\u02BE\u02BE\u02B3\u02C1\u02B9\u02BD\u02B5 == null)
		{
			array = Environment.GetCommandLineArgs();
		}
		else
		{
			array = this.\u02BF\u02BF\u02B3\u02B4\u02BE\u02BE\u02B3\u02C1\u02B9\u02BD\u02B5;
		}
		return !this.\u02B4\u02B6\u02B2\u02BB\u02B3\u02B5\u02B3\u02BD\u02B2\u02B3\u02BF(array) || true;
	}

	public bool \u02B8\u02B4\u02BE\u02B7\u02B3\u02B3\u02BC\u02BF\u02BE\u02B6\u02B4()
	{
		this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1 = base.GetComponent<UnpackingScene>();
		this.\u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3 = new List<ValueTuple<Instrument, Difficulty>>();
		string[] array;
		if ((this.\u02BF\u02BF\u02B3\u02B4\u02BE\u02BE\u02B3\u02C1\u02B9\u02BD\u02B5 != null && this.\u02BF\u02BF\u02B3\u02B4\u02BE\u02BE\u02B3\u02C1\u02B9\u02BD\u02B5.Length == 0) || this.\u02BF\u02BF\u02B3\u02B4\u02BE\u02BE\u02B3\u02C1\u02B9\u02BD\u02B5 == null)
		{
			array = Environment.GetCommandLineArgs();
		}
		else
		{
			array = this.\u02BF\u02BF\u02B3\u02B4\u02BE\u02BE\u02B3\u02C1\u02B9\u02BD\u02B5;
		}
		return this.\u02B4\u02B6\u02B2\u02BB\u02B3\u02B5\u02B3\u02BD\u02B2\u02B3\u02BF(array);
	}

	public bool \u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
	{
		ValueTuple<Instrument, Difficulty> valueTuple = this.\u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5];
		Instrument item = valueTuple.Item1;
		Difficulty item2 = valueTuple.Item2;
		\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B7\u02C0\u02BD\u02B5\u02BF\u02C1\u02BF\u02BC\u02BA\u02B7\u02BD(item2);
		\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE u02BC_u02C0_u02BC_u02B3_u02B4_u02C1_u02B3_u02BE_u02B2_u02C1_u02BE = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02C1\u02B8\u02B6\u02B9\u02B6\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9(item);
		if (u02BC_u02C0_u02BC_u02B3_u02B4_u02C1_u02B3_u02BE_u02B2_u02C1_u02BE == \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.ProDrums)
		{
			u02BC_u02C0_u02BC_u02B3_u02B4_u02C1_u02B3_u02BE_u02B2_u02C1_u02BE = \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Drums;
		}
		if (this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BF\u02B2\u02B7\u02B9\u02BF\u02B3\u02BE\u02B3\u02B7\u02C0\u02BE() == null)
		{
			this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(false, "Error while loading CLI chart", "Unable to load chart file " + this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.chartPath + ".", new UnityAction(Application.Quit), "OK");
			return false;
		}
		if (!this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BF\u02B2\u02B7\u02B9\u02BF\u02B3\u02BE\u02B3\u02B7\u02C0\u02BE().\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(u02BC_u02C0_u02BC_u02B3_u02B4_u02C1_u02B3_u02BE_u02B2_u02C1_u02BE, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B))
		{
			return false;
		}
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5];
		u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 = \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5;
		u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer = ReInput.players.GetSystemPlayer();
		\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B = this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA.\u02BD\u02B2\u02BE\u02B8\u02BF\u02B7\u02B2\u02B6\u02B2\u02BB\u02C1();
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.isBot.CurrentValue = 1;
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.displayName.CurrentValue = 0;
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.playerName.CurrentValue = "";
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.colorSettings = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02C0\u02BB\u02B2\u02B6\u02B4\u02B3\u02BF\u02B2\u02B5\u02B8\u02BA(u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.colorProfileName);
		if (this.\u02B2\u02C1\u02B5\u02BF\u02BD\u02B3\u02B9\u02B2\u02BD\u02BC\u02BC)
		{
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.playerName.CurrentValue = this.\u02B5\u02B6\u02BD\u02BC\u02C0\u02BD\u02B2\u02B9\u02BB\u02B6\u02B3(item);
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.displayName.CurrentValue = 1;
		}
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.instrument = item;
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.difficulty = item2;
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.moonInstrument = u02BC_u02C0_u02BC_u02B3_u02B4_u02C1_u02B3_u02BE_u02B2_u02C1_u02BE;
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.\u02C1\u02BD\u02BA\u02B2\u02B5\u02BC\u02C1\u02BF\u02B6\u02BB\u02BD = u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B;
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.noteModifier = Modifier.None;
		if (item == Instrument.Drums || item == Instrument.ProDrums)
		{
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.controllerType.CurrentValue = 2;
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.noteModifier = Modifier.AllStrums;
		}
		else if (item == Instrument.GHLGuitar || item == Instrument.GHLBass || item == Instrument.GHLGuitarCoop || item == Instrument.GHLRhythm)
		{
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.controllerType.CurrentValue = 1;
		}
		else
		{
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.controllerType.CurrentValue = 0;
		}
		u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerProfile = u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B;
		return true;
	}

	public IEnumerator \u02B2\u02B6\u02B9\u02BE\u02B6\u02BC\u02BA\u02B2\u02BF\u02BC\u02B5()
	{
		global::UnityEngine.Object.Instantiate<GameObject>(this.globalVariablesPrefab);
		global::UnityEngine.Object.Instantiate<GameObject>(this.rewiredInputManager);
		global::UnityEngine.Object.Instantiate<GameObject>(this.netManager);
		while (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5 || !ReInput.isReady)
		{
			yield return null;
		}
		if (this.\u02B8\u02B7\u02B5\u02B9\u02BC\u02BF\u02BC\u02BC\u02BC\u02BF\u02BF != null)
		{
			foreach (\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5)
			{
				if (u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.playerName == this.\u02B8\u02B7\u02B5\u02B9\u02BC\u02BF\u02BC\u02BC\u02BC\u02BF\u02BF)
				{
					this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA = u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B;
				}
			}
		}
		if (this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7 != null)
		{
			if (File.Exists(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7) && this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7.Contains("notes."))
			{
				this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7 = Path.GetDirectoryName(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7);
			}
			if (this.\u02B5\u02C0\u02C1\u02B3\u02BB\u02BE\u02BC\u02BB\u02B9\u02BC\u02B3())
			{
				if (this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA == null)
				{
					this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B4\u02C0\u02B6\u02B9\u02BE\u02BE\u02C1\u02B2\u02B6\u02B4\u02B6(true, false);
				}
				this.\u02C0\u02BD\u02BF\u02B5\u02B8\u02B7\u02B2\u02B5\u02B6\u02B8\u02B3();
			}
			else
			{
				this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(false, "Error while loading CLI chart", this.\u02C1\u02BB\u02BB\u02BC\u02BA\u02BE\u02B2\u02B2\u02BE\u02C0\u02B7(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7) ?? "", new UnityAction(Application.Quit), "OK");
			}
		}
		else
		{
			this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(false, "Error while loading CLI chart", "No song path was provided.", new UnityAction(Application.Quit), "OK");
		}
		yield break;
	}

	private bool \u02B4\u02B6\u02B2\u02BB\u02B3\u02B5\u02B3\u02BD\u02B2\u02B3\u02BF(string[] \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5)
	{
		bool flag = false;
		int i = 0;
		while (i < \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5.Length)
		{
			string text = \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5[i];
			uint num = PrivateImplementationDetails.ComputeStringHash(text);
			if (num <= 1556970371U)
			{
				if (num <= 1456304657U)
				{
					if (num != 1405971800U)
					{
						if (num == 1456304657U)
						{
							if (text == "-s")
							{
								goto IL_0183;
							}
						}
					}
					else if (text == "-p")
					{
						goto IL_0152;
					}
				}
				else if (num != 1506637514U)
				{
					if (num == 1556970371U)
					{
						if (text == "-i")
						{
							goto IL_0199;
						}
					}
				}
				else if (text == "-v")
				{
					goto IL_01A4;
				}
			}
			else if (num <= 2065667360U)
			{
				if (num != 1980383214U)
				{
					if (num == 2065667360U)
					{
						if (text == "--profile")
						{
							i++;
							this.\u02B8\u02B7\u02B5\u02B9\u02BC\u02BF\u02BC\u02BC\u02BC\u02BF\u02BF = \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5[i].Trim();
							flag = true;
						}
					}
				}
				else if (text == "--player")
				{
					goto IL_0152;
				}
			}
			else if (num != 2724663661U)
			{
				if (num != 2920447102U)
				{
					if (num == 4280849006U)
					{
						if (text == "--song")
						{
							goto IL_0183;
						}
					}
				}
				else if (text == "--instrumentNames")
				{
					goto IL_0199;
				}
			}
			else if (text == "--versus")
			{
				goto IL_01A4;
			}
			IL_01C3:
			i++;
			continue;
			IL_0152:
			i++;
			string text2 = \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5[i].Trim();
			if (this.\u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3.Count <= 4)
			{
				this.\u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3.Add(this.\u02B4\u02BE\u02B9\u02B6\u02BA\u02C1\u02BC\u02B3\u02BC\u02BE\u02B9(text2));
			}
			flag = true;
			goto IL_01C3;
			IL_0183:
			i++;
			this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7 = \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5[i].Trim();
			flag = true;
			goto IL_01C3;
			IL_0199:
			this.\u02B2\u02C1\u02B5\u02BF\u02BD\u02B3\u02B9\u02B2\u02BD\u02BC\u02BC = true;
			flag = true;
			goto IL_01C3;
			IL_01A4:
			this.\u02BD\u02BF\u02BE\u02B5\u02B8\u02BD\u02BD\u02B3\u02B2\u02B7\u02BE = true;
			flag = true;
			goto IL_01C3;
		}
		return flag;
	}

	private ValueTuple<Instrument, Difficulty> \u02BA\u02BA\u02BC\u02BF\u02B3\u02C1\u02BE\u02B7\u02C1\u02B2\u02B7(string \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0)
	{
		string[] array = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.Split('$', StringSplitOptions.RemoveEmptyEntries);
		string text = array[1].ToLowerInvariant();
		string text2 = array[0].ToLowerInvariant();
		uint num = PrivateImplementationDetails.ComputeStringHash(text);
		Instrument instrument;
		if (num <= 4294967239U)
		{
			if (num <= 19U)
			{
				if (num != 4294967220U)
				{
					if (num == 4294967250U)
					{
						if (text == "while lexing the header section")
						{
							instrument = Instrument.GuitarCoop;
							goto IL_01BA;
						}
					}
				}
				else if (text == "Events")
				{
					instrument = Instrument.Guitar;
					goto IL_01BA;
				}
			}
			else if (num != 4294967288U)
			{
				if (num != 4294967255U)
				{
					if (num == 93U)
					{
						if (text == "Start typing...")
						{
							instrument = (Instrument)52;
							goto IL_01BA;
						}
					}
				}
				else if (text == "_OutputSaturation")
				{
					instrument = Instrument.ProDrums;
					goto IL_01BA;
				}
			}
			else if (text == "Replay")
			{
				instrument = Instrument.Keys;
				goto IL_01BA;
			}
		}
		else if (num <= 141U)
		{
			if (num != 4294967245U)
			{
				if (num != 146U)
				{
					if (num == 53U)
					{
						if (text == "Credits")
						{
							instrument = Instrument.Guitar;
							goto IL_01BA;
						}
					}
				}
				else if (text == "{0} Exception Encountered in \"{1}\" on line {2}{3}.{4}")
				{
					instrument = Instrument.GHLBass;
					goto IL_01BA;
				}
			}
			else if (text == "Save Setlist")
			{
				instrument = Instrument.Bass;
				goto IL_01BA;
			}
		}
		else if (num != 4294967139U)
		{
			if (num != 4294967173U)
			{
				if (num == 4294967197U)
				{
					if (text == "star_deployed")
					{
						instrument = Instrument.GuitarCoop;
						goto IL_01BA;
					}
				}
			}
			else if (text == ")")
			{
				instrument = (Instrument)115;
				goto IL_01BA;
			}
		}
		else if (text == "Warning: These folders contain lyrics that do not have matching vocal note events, and have fallen back to non validated parsing.")
		{
			instrument = Instrument.Bass;
			goto IL_01BA;
		}
		instrument = Instrument.Bass;
		IL_01BA:
		Difficulty difficulty;
		if (!(text2 == "frets"))
		{
			if (!(text2 == "buildUpdateText"))
			{
				if (!(text2 == "ModChart Prep"))
				{
					if (!(text2 == "Gameplay"))
					{
						difficulty = Difficulty.Easy;
					}
					else
					{
						difficulty = Difficulty.Easy;
					}
				}
				else
				{
					difficulty = Difficulty.Easy;
				}
			}
			else
			{
				difficulty = Difficulty.Easy;
			}
		}
		else
		{
			difficulty = Difficulty.Easy;
		}
		return new ValueTuple<Instrument, Difficulty>(instrument, difficulty);
	}

	public bool \u02B6\u02BF\u02B9\u02BA\u02BA\u02B7\u02BF\u02BA\u02B9\u02B7\u02B4(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
	{
		ValueTuple<Instrument, Difficulty> valueTuple = this.\u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5];
		Instrument item = valueTuple.Item1;
		Difficulty item2 = valueTuple.Item2;
		\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B7\u02C0\u02BD\u02B5\u02BF\u02C1\u02BF\u02BC\u02BA\u02B7\u02BD(item2);
		\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE u02BC_u02C0_u02BC_u02B3_u02B4_u02C1_u02B3_u02BE_u02B2_u02C1_u02BE = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02C1\u02B8\u02B6\u02B9\u02B6\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9(item);
		if (u02BC_u02C0_u02BC_u02B3_u02B4_u02C1_u02B3_u02BE_u02B2_u02C1_u02BE == (\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE)(-71))
		{
			u02BC_u02C0_u02BC_u02B3_u02B4_u02C1_u02B3_u02BE_u02B2_u02C1_u02BE = \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Crowd;
		}
		if (this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BF\u02B2\u02B7\u02B9\u02BF\u02B3\u02BE\u02B3\u02B7\u02C0\u02BE() == null)
		{
			this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1.\u02B7\u02C1\u02BD\u02BF\u02BF\u02B8\u02BB\u02B8\u02BE\u02B3\u02B2(false, "6 Fret Lead Guitar", "End Events" + this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.chartPath + "Player {0} Score: {1} isWinner: {2}", new UnityAction(Application.Quit), "Warning: These folders contain video backgrounds that wont work on all game platforms, which may be deprecated in the future.");
			return true;
		}
		if (!this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BF\u02B2\u02B7\u02B9\u02BF\u02B3\u02BE\u02B3\u02B7\u02C0\u02BE().\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(u02BC_u02C0_u02BC_u02B3_u02B4_u02C1_u02B3_u02BE_u02B2_u02C1_u02BE, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B))
		{
			return true;
		}
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5];
		u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 = \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5;
		u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer = ReInput.players.GetSystemPlayer();
		\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B = this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA.\u02BD\u02B2\u02BE\u02B8\u02BF\u02B7\u02B2\u02B6\u02B2\u02BB\u02C1();
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.isBot.CurrentValue = 0;
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.displayName.CurrentValue = 1;
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.playerName.CurrentValue = "8EDC4F";
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.colorSettings = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02C0\u02BB\u02B2\u02B6\u02B4\u02B3\u02BF\u02B2\u02B5\u02B8\u02BA(u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.colorProfileName);
		if (this.\u02B2\u02C1\u02B5\u02BF\u02BD\u02B3\u02B9\u02B2\u02BD\u02BC\u02BC)
		{
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.playerName.CurrentValue = this.\u02B2\u02B4\u02B4\u02C1\u02BE\u02BC\u02C0\u02B8\u02B9\u02BD\u02BC(item);
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.displayName.CurrentValue = 0;
		}
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.instrument = item;
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.difficulty = item2;
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.moonInstrument = u02BC_u02C0_u02BC_u02B3_u02B4_u02C1_u02B3_u02BE_u02B2_u02C1_u02BE;
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.\u02C1\u02BD\u02BA\u02B2\u02B5\u02BC\u02C1\u02BF\u02B6\u02BB\u02BD = u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B;
		u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.noteModifier = Modifier.Unknown;
		if (item == Instrument.Band || item == (Instrument)46)
		{
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.controllerType.CurrentValue = 3;
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.noteModifier = Modifier.Unknown;
		}
		else if (item == Instrument.Drums || item == Instrument.Guitar || item == (Instrument)(-39) || item == (Instrument)56)
		{
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.controllerType.CurrentValue = 0;
		}
		else
		{
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.controllerType.CurrentValue = 0;
		}
		u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerProfile = u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B;
		return true;
	}

	public void \u02B5\u02C0\u02B5\u02B9\u02B2\u02B3\u02B9\u02B2\u02BA\u02B2\u02B3()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		Debug.Log(this.\u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3.Count);
		for (int i = 1; i < this.\u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3.Count; i += 0)
		{
			if (this.\u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5(i))
			{
				this.\u02C0\u02C1\u02B4\u02B6\u02B7\u02BC\u02C1\u02B3\u02BA\u02B4\u02B2++;
			}
		}
		if (this.\u02C0\u02C1\u02B4\u02B6\u02B7\u02BC\u02C1\u02B3\u02BA\u02B4\u02B2 > 1)
		{
			u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD = this.\u02C0\u02C1\u02B4\u02B6\u02B7\u02BC\u02C1\u02B3\u02BA\u02B4\u02B2;
			u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1 = this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD;
			SettingsController.\u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3.CurrentValue = 1;
			if (this.\u02BD\u02BF\u02BE\u02B5\u02B8\u02BD\u02BD\u02B3\u02B2\u02B7\u02BE)
			{
				u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 = (GameMode)6;
			}
			else
			{
				u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 = GameMode.Quickplay;
			}
			FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("targetFramerate", 1156f);
		}
		else
		{
			this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(true, "Keys", "", new UnityAction(Application.Quit), "song_length");
		}
		base.enabled = false;
	}

	private string \u02B3\u02B6\u02B5\u02B7\u02C0\u02B3\u02B3\u02B4\u02B4\u02B7\u02BD(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		switch (this.\u02BA\u02B6\u02B4\u02BE\u02B5\u02BB\u02B6\u02B8\u02B4\u02B4\u02BE)
		{
		case CliGameLauncher.\u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0.None:
			return \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC + "Show Remote Player Names";
		case CliGameLauncher.\u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0.DirectoryMissing:
			return \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC + "--force-vulkan";
		case CliGameLauncher.\u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0.AudioFilesMissing:
			return \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC + "beginsongsync";
		case CliGameLauncher.\u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0.ChartFileMissing:
			return "Artist - Album";
		default:
			return "You're\nLoser !";
		}
	}

	private bool \u02B5\u02C0\u02C1\u02B3\u02BB\u02BE\u02BC\u02BB\u02B9\u02BC\u02B3()
	{
		if (!Directory.Exists(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7))
		{
			this.\u02BA\u02B6\u02B4\u02BE\u02B5\u02BB\u02B6\u02B8\u02B4\u02B4\u02BE = CliGameLauncher.\u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0.DirectoryMissing;
			return false;
		}
		string text = Path.Combine(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7, "notes.mid");
		string text2 = Path.Combine(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7, "notes.chart");
		string[] array = Helper.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7, ".wav|.mp3|.ogg|.opus", SearchOption.TopDirectoryOnly);
		this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD = new SongEntry(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7);
		if (File.Exists(text))
		{
			this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.chartName = text;
		}
		else
		{
			if (!File.Exists(text2))
			{
				this.\u02BA\u02B6\u02B4\u02BE\u02B5\u02BB\u02B6\u02B8\u02B4\u02B4\u02BE = CliGameLauncher.\u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0.ChartFileMissing;
				return false;
			}
			this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.chartName = text2;
		}
		if (array == null || array.Length == 0)
		{
			this.\u02BA\u02B6\u02B4\u02BE\u02B5\u02BB\u02B6\u02B8\u02B4\u02B4\u02BE = CliGameLauncher.\u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0.AudioFilesMissing;
			return false;
		}
		if (this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.metadataLoaded)
		{
			this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02C1\u02B3\u02BD\u02B4\u02BC\u02B4\u02BD\u02B9\u02B4\u02B2\u02BC(File.ReadAllBytes(this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.chartPath));
			this.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B9\u02BC\u02C1\u02BC\u02B8\u02B5\u02BD\u02BE\u02B5\u02B4\u02BD();
			return true;
		}
		this.\u02BA\u02B6\u02B4\u02BE\u02B5\u02BB\u02B6\u02B8\u02B4\u02B4\u02BE = CliGameLauncher.\u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0.MetadataMissing;
		return false;
	}

	private string \u02B2\u02B4\u02B4\u02C1\u02BE\u02BC\u02C0\u02B8\u02B9\u02BD\u02BC(Instrument \u02BD\u02BD\u02BB\u02B5\u02BA\u02BE\u02B9\u02B8\u02BB\u02B9\u02B4)
	{
		switch (\u02BD\u02BD\u02BB\u02B5\u02BA\u02BE\u02B9\u02B8\u02BB\u02B9\u02B4)
		{
		case Instrument.Guitar:
			return "targetFramerate";
		case Instrument.Bass:
			return " <b><i>(";
		case Instrument.Rhythm:
			return "Rhythm Guitar";
		case Instrument.GuitarCoop:
			return "ms";
		case Instrument.GHLGuitar:
			return "</b></color>";
		case Instrument.GHLBass:
			return "s_Logger";
		case Instrument.Drums:
			return "[{0}]";
		case Instrument.Keys:
			return "SoftMask";
		case Instrument.ProDrums:
			return "Are you sure you want to practice?";
		case Instrument.GHLRhythm:
			return "mix";
		case Instrument.GHLGuitarCoop:
			return "explorer.exe";
		}
		return "Quit";
	}

	public IEnumerator \u02B4\u02BB\u02B3\u02C0\u02B9\u02B5\u02BB\u02C0\u02B5\u02B4\u02BB()
	{
		global::UnityEngine.Object.Instantiate<GameObject>(this.globalVariablesPrefab);
		global::UnityEngine.Object.Instantiate<GameObject>(this.rewiredInputManager);
		global::UnityEngine.Object.Instantiate<GameObject>(this.netManager);
		while (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5 || !ReInput.isReady)
		{
			yield return null;
		}
		if (this.\u02B8\u02B7\u02B5\u02B9\u02BC\u02BF\u02BC\u02BC\u02BC\u02BF\u02BF != null)
		{
			foreach (\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5)
			{
				if (u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.playerName == this.\u02B8\u02B7\u02B5\u02B9\u02BC\u02BF\u02BC\u02BC\u02BC\u02BF\u02BF)
				{
					this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA = u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B;
				}
			}
		}
		if (this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7 != null)
		{
			if (File.Exists(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7) && this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7.Contains("notes."))
			{
				this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7 = Path.GetDirectoryName(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7);
			}
			if (this.\u02B5\u02C0\u02C1\u02B3\u02BB\u02BE\u02BC\u02BB\u02B9\u02BC\u02B3())
			{
				if (this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA == null)
				{
					this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B4\u02C0\u02B6\u02B9\u02BE\u02BE\u02C1\u02B2\u02B6\u02B4\u02B6(true, false);
				}
				this.\u02C0\u02BD\u02BF\u02B5\u02B8\u02B7\u02B2\u02B5\u02B6\u02B8\u02B3();
			}
			else
			{
				this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(false, "Error while loading CLI chart", this.\u02C1\u02BB\u02BB\u02BC\u02BA\u02BE\u02B2\u02B2\u02BE\u02C0\u02B7(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7) ?? "", new UnityAction(Application.Quit), "OK");
			}
		}
		else
		{
			this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(false, "Error while loading CLI chart", "No song path was provided.", new UnityAction(Application.Quit), "OK");
		}
		yield break;
	}

	private string \u02BD\u02B6\u02B7\u02B3\u02BF\u02BD\u02B5\u02B2\u02BA\u02C1\u02BF(Instrument \u02BD\u02BD\u02BB\u02B5\u02BA\u02BE\u02B9\u02B8\u02BB\u02B9\u02B4)
	{
		switch (\u02BD\u02BD\u02BB\u02B5\u02BA\u02BE\u02B9\u02B8\u02BB\u02B9\u02B4)
		{
		case Instrument.Guitar:
			return "song";
		case Instrument.Bass:
			return " ";
		case Instrument.Rhythm:
			return "song";
		case Instrument.GuitarCoop:
			return "Yes";
		case Instrument.GHLGuitar:
			return "Video Backgrounds";
		case Instrument.GHLBass:
			return "Inappropriate method call. String resource '";
		case Instrument.Drums:
			return "/storage/emulated/0/Clone Hero";
		case Instrument.Keys:
			return "Unity Game Services session could not be refreshed and expired.";
		case Instrument.ProDrums:
			return "songs";
		case Instrument.GHLRhythm:
			return "Selection";
		case Instrument.GHLGuitarCoop:
			return "wrongserverversion";
		}
		return "This warning is primarily aimed at charters and users of those platforms. This doesn't necessarily result in any problems at this time.";
	}

	public IEnumerator \u02B8\u02B7\u02B6\u02B4\u02BA\u02BD\u02B7\u02BA\u02B2\u02BC\u02BA()
	{
		global::UnityEngine.Object.Instantiate<GameObject>(this.globalVariablesPrefab);
		global::UnityEngine.Object.Instantiate<GameObject>(this.rewiredInputManager);
		global::UnityEngine.Object.Instantiate<GameObject>(this.netManager);
		while (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5 || !ReInput.isReady)
		{
			yield return null;
		}
		if (this.\u02B8\u02B7\u02B5\u02B9\u02BC\u02BF\u02BC\u02BC\u02BC\u02BF\u02BF != null)
		{
			foreach (\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5)
			{
				if (u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.playerName == this.\u02B8\u02B7\u02B5\u02B9\u02BC\u02BF\u02BC\u02BC\u02BC\u02BF\u02BF)
				{
					this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA = u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B;
				}
			}
		}
		if (this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7 != null)
		{
			if (File.Exists(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7) && this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7.Contains("notes."))
			{
				this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7 = Path.GetDirectoryName(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7);
			}
			if (this.\u02B5\u02C0\u02C1\u02B3\u02BB\u02BE\u02BC\u02BB\u02B9\u02BC\u02B3())
			{
				if (this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA == null)
				{
					this.\u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B4\u02C0\u02B6\u02B9\u02BE\u02BE\u02C1\u02B2\u02B6\u02B4\u02B6(true, false);
				}
				this.\u02C0\u02BD\u02BF\u02B5\u02B8\u02B7\u02B2\u02B5\u02B6\u02B8\u02B3();
			}
			else
			{
				this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(false, "Error while loading CLI chart", this.\u02C1\u02BB\u02BB\u02BC\u02BA\u02BE\u02B2\u02B2\u02BE\u02C0\u02B7(this.\u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7) ?? "", new UnityAction(Application.Quit), "OK");
			}
		}
		else
		{
			this.\u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(false, "Error while loading CLI chart", "No song path was provided.", new UnityAction(Application.Quit), "OK");
		}
		yield break;
	}

	private List<ValueTuple<Instrument, Difficulty>> \u02BA\u02B5\u02BE\u02C1\u02BA\u02B6\u02B2\u02B4\u02B8\u02B3\u02B3;

	private string \u02B6\u02BB\u02BB\u02BC\u02C0\u02B5\u02BA\u02B6\u02B3\u02C0\u02B7;

	private string \u02B8\u02B7\u02B5\u02B9\u02BC\u02BF\u02BC\u02BC\u02BC\u02BF\u02BF;

	private \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 \u02C0\u02B6\u02C1\u02BB\u02B7\u02C1\u02BB\u02BA\u02B4\u02B8\u02BA;

	private SongEntry \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD;

	private bool \u02B2\u02C1\u02B5\u02BF\u02BD\u02B3\u02B9\u02B2\u02BD\u02BC\u02BC;

	private bool \u02BD\u02BF\u02BE\u02B5\u02B8\u02BD\u02BD\u02B3\u02B2\u02B7\u02BE;

	public string[] \u02BF\u02BF\u02B3\u02B4\u02BE\u02BE\u02B3\u02C1\u02B9\u02BD\u02B5;

	private int \u02C0\u02C1\u02B4\u02B6\u02B7\u02BC\u02C1\u02B3\u02BA\u02B4\u02B2;

	[SerializeField]
	private GameObject globalVariablesPrefab;

	[SerializeField]
	private GameObject rewiredInputManager;

	[SerializeField]
	private GameObject netManager;

	private UnpackingScene \u02BB\u02B9\u02BE\u02B5\u02C0\u02BD\u02C0\u02B5\u02B3\u02B2\u02C1;

	private CliGameLauncher.\u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0 \u02BA\u02B6\u02B4\u02BE\u02B5\u02BB\u02B6\u02B8\u02B4\u02B4\u02BE;

	private enum \u02B8\u02BA\u02BD\u02B9\u02BF\u02B2\u02B4\u02B5\u02B9\u02C1\u02C0
	{
		None,
		DirectoryMissing,
		AudioFilesMissing,
		ChartFileMissing,
		MetadataMissing
	}
}
