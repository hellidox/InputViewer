using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

// Token: 0x020002E7 RID: 743
public static class cUtilityClass
{
	// Token: 0x1700041C RID: 1052
	// (get) Token: 0x06001F49 RID: 8009 RVA: 0x000179A0 File Offset: 0x00015BA0
	// (set) Token: 0x06001F4A RID: 8010 RVA: 0x000179D7 File Offset: 0x00015BD7
	public static bool rainbowSPBar
	{
		get
		{
			if (cUtilityClass._rainbowSPBarCache != null)
			{
				return cUtilityClass._rainbowSPBarCache.Value;
			}
			cUtilityClass._rainbowSPBarCache = new bool?(cUtilityClass.ReadBool("rainbowSPBar"));
			return cUtilityClass._rainbowSPBarCache.Value;
		}
		set
		{
			cUtilityClass._rainbowSPBarCache = new bool?(value);
			cUtilityClass.WriteKeyValue("rainbowSPBar", value, false);
		}
	}

	// Token: 0x1700041D RID: 1053
	// (get) Token: 0x06001F4B RID: 8011 RVA: 0x000179F5 File Offset: 0x00015BF5
	// (set) Token: 0x06001F4C RID: 8012 RVA: 0x00017A2C File Offset: 0x00015C2C
	public static bool rainbowFlames
	{
		get
		{
			if (cUtilityClass._rainbowFlamesCache != null)
			{
				return cUtilityClass._rainbowFlamesCache.Value;
			}
			cUtilityClass._rainbowFlamesCache = new bool?(cUtilityClass.ReadBool("rainbowFlames"));
			return cUtilityClass._rainbowFlamesCache.Value;
		}
		set
		{
			cUtilityClass._rainbowFlamesCache = new bool?(value);
			cUtilityClass.WriteKeyValue("rainbowFlames", value, false);
		}
	}

	// Token: 0x1700041E RID: 1054
	// (get) Token: 0x06001F4D RID: 8013 RVA: 0x00017A4A File Offset: 0x00015C4A
	// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00017A81 File Offset: 0x00015C81
	public static float rainbowFlameSpeed
	{
		get
		{
			if (cUtilityClass._rainbowFlameSpeedCache != null)
			{
				return cUtilityClass._rainbowFlameSpeedCache.Value;
			}
			cUtilityClass._rainbowFlameSpeedCache = new float?(cUtilityClass.ReadFloat("rainbowFlameSpeed"));
			return cUtilityClass._rainbowFlameSpeedCache.Value;
		}
		set
		{
			cUtilityClass._rainbowFlameSpeedCache = new float?(value);
			cUtilityClass.WriteKeyValue("rainbowFlameSpeed", value, false);
		}
	}

	// Token: 0x1700041F RID: 1055
	// (get) Token: 0x06001F4F RID: 8015 RVA: 0x00017A9F File Offset: 0x00015C9F
	// (set) Token: 0x06001F50 RID: 8016 RVA: 0x00017AD6 File Offset: 0x00015CD6
	public static bool showInputViewer
	{
		get
		{
			if (cUtilityClass._showInputViewerCache != null)
			{
				return cUtilityClass._showInputViewerCache.Value;
			}
			cUtilityClass._showInputViewerCache = new bool?(cUtilityClass.ReadBool("showInputViewer"));
			return cUtilityClass._showInputViewerCache.Value;
		}
		set
		{
			cUtilityClass._showInputViewerCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showInputViewer", value, false);
		}
	}

	// Token: 0x17000420 RID: 1056
	// (get) Token: 0x06001F51 RID: 8017 RVA: 0x00017AF4 File Offset: 0x00015CF4
	// (set) Token: 0x06001F52 RID: 8018 RVA: 0x00017B2B File Offset: 0x00015D2B
	public static int inputViewerHz
	{
		get
		{
			if (cUtilityClass._inputViewerHzCache != null)
			{
				return cUtilityClass._inputViewerHzCache.Value;
			}
			cUtilityClass._inputViewerHzCache = new int?(cUtilityClass.ReadInt("inputViewerHz"));
			return cUtilityClass._inputViewerHzCache.Value;
		}
		set
		{
			cUtilityClass._inputViewerHzCache = new int?(value);
			cUtilityClass.WriteKeyValue("inputViewerHz", value, false);
		}
	}

	// Token: 0x17000421 RID: 1057
	// (get) Token: 0x06001F53 RID: 8019 RVA: 0x00017B49 File Offset: 0x00015D49
	// (set) Token: 0x06001F54 RID: 8020 RVA: 0x00017B80 File Offset: 0x00015D80
	public static bool strikelineFPSFix
	{
		get
		{
			if (cUtilityClass._strikelineFPSFixCache != null)
			{
				return cUtilityClass._strikelineFPSFixCache.Value;
			}
			cUtilityClass._strikelineFPSFixCache = new bool?(cUtilityClass.ReadBool("strikelineFPSFix"));
			return cUtilityClass._strikelineFPSFixCache.Value;
		}
		set
		{
			cUtilityClass._strikelineFPSFixCache = new bool?(value);
			cUtilityClass.WriteKeyValue("strikelineFPSFix", value, false);
		}
	}

	// Token: 0x17000422 RID: 1058
	// (get) Token: 0x06001F55 RID: 8021 RVA: 0x00017B9E File Offset: 0x00015D9E
	// (set) Token: 0x06001F56 RID: 8022 RVA: 0x00017BD5 File Offset: 0x00015DD5
	public static bool showFPS
	{
		get
		{
			if (cUtilityClass._showFPSCache != null)
			{
				return cUtilityClass._showFPSCache.Value;
			}
			cUtilityClass._showFPSCache = new bool?(cUtilityClass.ReadBool("showFPS"));
			return cUtilityClass._showFPSCache.Value;
		}
		set
		{
			cUtilityClass._showFPSCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showFPS", value, false);
		}
	}

	// Token: 0x17000423 RID: 1059
	// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00017BF3 File Offset: 0x00015DF3
	// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00017C2A File Offset: 0x00015E2A
	public static float fontSize
	{
		get
		{
			if (cUtilityClass._fontSizeCache != null)
			{
				return cUtilityClass._fontSizeCache.Value;
			}
			cUtilityClass._fontSizeCache = new float?(cUtilityClass.ReadFloat("fontSize"));
			return cUtilityClass._fontSizeCache.Value;
		}
		set
		{
			cUtilityClass._fontSizeCache = new float?(value);
			cUtilityClass.WriteKeyValue("fontSize", value.ToString("F2"), false);
		}
	}

	// Token: 0x06001F59 RID: 8025 RVA: 0x000D5664 File Offset: 0x000D3864
	static cUtilityClass()
	{
		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
		cUtilityClass._char_greenFretColorCache = new char[1];
		cUtilityClass._char_redFretColorCache = new char[1];
		cUtilityClass._char_yellowFretColorCache = new char[1];
		cUtilityClass._char_blueFretColorCache = new char[1];
		cUtilityClass._char_orangeFretColorCache = new char[1];
		cUtilityClass.path = Path.Combine(Application.persistentDataPath, "IVsettings.txt");
		cUtilityClass.InitializeConfig(cUtilityClass.versionid != cUtilityClass.ReadInt("versionID"));
		cUtilityClass.version = "V2.0.8.1";
		cUtilityClass.InvalidateCache();
		cUtilityClass.internalLogWebhook = "https://discord.com/api/webhooks/redacted";
		cUtilityClass.courteWebhook = "https://discord.com/api/webhooks/redacted";
	}

	// Token: 0x06001F5A RID: 8026 RVA: 0x00017C4E File Offset: 0x00015E4E
	public static string ReadKeyValue(string key)
	{
		return cUtilityClass.ReadKeyValue(key, null);
	}

	// Token: 0x06001F5B RID: 8027 RVA: 0x000D5708 File Offset: 0x000D3908
	public static bool ReadBool(string key)
	{
		bool flag;
		return bool.TryParse(cUtilityClass.ReadKeyValue(key), out flag) && flag;
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x000D5724 File Offset: 0x000D3924
	private static float ReadFloat(string key)
	{
		float num;
		if (float.TryParse(cUtilityClass.ReadKeyValue(key), out num))
		{
			return num;
		}
		return 0f;
	}

	// Token: 0x06001F5D RID: 8029 RVA: 0x000D5748 File Offset: 0x000D3948
	public static int ReadInt(string key)
	{
		try
		{
			int num;
			if (int.TryParse(cUtilityClass.ReadKeyValue(key).Split(".", StringSplitOptions.None)[0], out num))
			{
				return num;
			}
		}
		catch (Exception ex)
		{
			Debug.Log(ex);
		}
		return 0;
	}

	// Token: 0x06001F5E RID: 8030 RVA: 0x000D5794 File Offset: 0x000D3994
	public static void InvalidateCache()
	{
		cUtilityClass._useColorProfileCache = null;
		cUtilityClass._perFretFlameColorsCache = null;
		cUtilityClass._colorIntensityCache = null;
		cUtilityClass._songProgressColorCache = null;
		cUtilityClass._starProgressColorCache = null;
		cUtilityClass._noteStreakColorCache = null;
		cUtilityClass._scoreColorCache = null;
		cUtilityClass._scoreHUDColorCache = null;
		cUtilityClass._starColorCache = null;
		cUtilityClass._hideHPOnFailCache = null;
		cUtilityClass._fontSizeCache = null;
		cUtilityClass._showFPSCache = null;
		cUtilityClass._inputViewerHzCache = null;
		cUtilityClass._inputViewerIndentCache = null;
		cUtilityClass._renderFrameIntervalCache = null;
		cUtilityClass._useJudgeLevelCache = null;
		cUtilityClass._rainbowFlamesCache = null;
		cUtilityClass._rainbowFlameSpeedCache = null;
		cUtilityClass._highwaySpeedCache = null;
		cUtilityClass._colorIntensityCache = null;
		cUtilityClass._rainbowSPBarCache = null;
		cUtilityClass._showInputViewerCache = null;
		cUtilityClass._showGhostsCache = null;
		cUtilityClass._strikelineFPSFixCache = null;
		cUtilityClass._strikelinePistonSpeedCache = null;
		cUtilityClass._greenFretColorCache = null;
		cUtilityClass._redFretColorCache = null;
		cUtilityClass._yellowFretColorCache = null;
		cUtilityClass._blueFretColorCache = null;
		cUtilityClass._orangeFretColorCache = null;
		cUtilityClass._strumColorCache = null;
		cUtilityClass._showOverstrumsCache = null;
		cUtilityClass._showBeatlinesCache = null;
		cUtilityClass._showHighwayCache = null;
		cUtilityClass._showHPBarCache = null;
		cUtilityClass._showFretStringsCache = null;
		cUtilityClass._showHighwaySideCache = null;
		cUtilityClass._showAvgInaccuracyCache = null;
		cUtilityClass._showMissCounterCache = null;
		cUtilityClass._showClockCache = null;
		cUtilityClass._showSessionTimerCache = null;
		cUtilityClass._scorespyNoFailCache = null;
		cUtilityClass._showJudgementsUnderFretboardCache = null;
		cUtilityClass._hitWindowDisplaySizeCache = null;
		cUtilityClass._useJudgementsCache = null;
		cUtilityClass._weightSystemCache = null;
		cUtilityClass._breakComboOnEarlyCache = null;
		cUtilityClass._maximumImprecisionCache = null;
		cUtilityClass._judgeBreakSoundVolumeCache = null;
		cUtilityClass._soundOnJudgeBreakCache = null;
		cUtilityClass._deafenAtPercentageCache = null;
		cUtilityClass._char_greenFretColorCache = new char[1];
		cUtilityClass._char_redFretColorCache = new char[1];
		cUtilityClass._char_yellowFretColorCache = new char[1];
		cUtilityClass._char_blueFretColorCache = new char[1];
		cUtilityClass._char_orangeFretColorCache = new char[1];
		cUtilityClass._char_strumColorCache = new char[1];
		cUtilityClass.InitializeConfig(false);
	}

	// Token: 0x06001F5F RID: 8031 RVA: 0x000D59E0 File Offset: 0x000D3BE0
	public static void InitializeConfig(bool force = false)
	{
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "IVSettings.cmd");
		Debug.Log("caller " + new StackFrame(1).GetMethod().Name + " force " + force.ToString());
		if (force)
		{
			File.Delete(cUtilityClass.path);
		}
		File.WriteAllText(text, "\"" + cUtilityClass.path + "\"");
		if (!File.Exists(cUtilityClass.path))
		{
			cUtilityClass.WriteComment("and # start comments.");
			cUtilityClass.WriteComment("Alpha doesn't yet work in colors.");
			cUtilityClass.WriteComment("#000000 is a magic number to make most of these invisible.");
			cUtilityClass.WriteComment("#ffffff is a magic number to use the original color.");
			cUtilityClass.WriteComment("For white, use #fffffe. For black, use #000001.");
			cUtilityClass.songProgressColor = "#7d8cd8";
			cUtilityClass.starProgressColor = "#e4b159";
			cUtilityClass.noteStreakColor = "#ffffff";
			cUtilityClass.starColor = "#ffffff";
			cUtilityClass.scoreColor = "#ffffff";
			cUtilityClass.scoreHUDColor = "#ffffff";
			cUtilityClass.greenFretColor = "#00ff00";
			cUtilityClass.redFretColor = "#ff0000";
			cUtilityClass.yellowFretColor = "#ffff00";
			cUtilityClass.blueFretColor = "#2222ff";
			cUtilityClass.orangeFretColor = "#ffa500";
			cUtilityClass.strumColor = "#cc11cc";
			cUtilityClass.showClock = false;
			cUtilityClass.showInputViewer = true;
			cUtilityClass.showGhosts = true;
			cUtilityClass.showMissCounter = true;
			cUtilityClass.showOverstrums = true;
			cUtilityClass.showSessionTimer = false;
			cUtilityClass.inputViewerHz = 60;
			cUtilityClass.inputViewerIndent = 14;
			cUtilityClass.rainbowFlames = false;
			cUtilityClass.rainbowFlameSpeed = 1.5f;
			cUtilityClass.highwaySpeed = 1f;
			cUtilityClass.strikelinePistonSpeed = 1f;
			cUtilityClass.rainbowSPBar = false;
			cUtilityClass.strikelineFPSFix = true;
			cUtilityClass.fontSize = 0.9f;
			cUtilityClass.useColorProfile = true;
			cUtilityClass.WriteComment("Uses the colors above (...FretColor) for this.");
			cUtilityClass.perFretFlameColors = true;
			cUtilityClass.WriteComment("0 is default. 1 is maximum intensity (saturation) without washing out.");
			cUtilityClass.colorIntensity = 0f;
			cUtilityClass.showFPS = true;
			cUtilityClass.scorespyNoFail = true;
			cUtilityClass.useJudgements = true;
			cUtilityClass.showJudgementsUnderFretboard = true;
			cUtilityClass.WriteComment("1 (Etterna, default):");
			cUtilityClass.WriteComment("flawless: 1.1, perfect: 0.74, great: 0.36, good: 0, bad: -0.28, miss: -1.1f, early: -0.55f");
			cUtilityClass.WriteComment("0 (Custom, original): ");
			cUtilityClass.WriteComment("flawless: 1.1, perfect: 1, great: 0.5, good: 0.5, bad: 0.25, miss: 0, early: 0.125");
			cUtilityClass.WriteComment("2 (Quaver):");
			cUtilityClass.WriteComment("flawless: 1.1, perfect: 1.081, great: 0.72, good: 0.28, bad (okay): -0.55, miss: -1.1, early: -0.7");
			cUtilityClass.weightSystem = cUtilityClass.WeightSystem.Etterna;
			cUtilityClass.WriteComment("Available values: -1 for JUSTICE, -2 for In The Groove, -3 for DDR Arcade 1,");
			cUtilityClass.WriteComment("-4 for DDR Arcade 2, and 1-9 for StepMania/Etterna Judge 1-9.");
			cUtilityClass.WriteComment("11-18 for Quaver Peaceful-Impossible.");
			cUtilityClass.WriteComment("The Quaver default is 14 (standard)");
			cUtilityClass.WriteComment("Default is Judge 6. This is the Etterna default and");
			cUtilityClass.WriteComment(string.Format("gives a {0:0.0}ms window to hit flawless judgments.", cUtilityClass.judgeTimings(cUtilityClass.JudgeLevel.Judge6)[0] * 2000f));
			cUtilityClass.WriteComment("(for reference: Festival has a 50ms perfect window)");
			cUtilityClass.useJudgeLevel = cUtilityClass.JudgeLevel.Judge4;
			cUtilityClass.WriteComment("From 0-6: Flawless, Perfect, Great, Good, Bad, Early, Miss");
			cUtilityClass.WriteComment("If you hit a note outside of this window, it will count as a combo break (overstrum).");
			cUtilityClass.WriteComment("Set to 6 (default) to disable.");
			cUtilityClass.maximumImprecision = BasePlayer.Judgement.Miss;
			cUtilityClass.WriteComment("Enable this to make early judgements count as a combo break (overstrum).");
			cUtilityClass.breakComboOnEarly = false;
			cUtilityClass.WriteComment("Play a sound when you break combo due to being too imprecise");
			cUtilityClass.soundOnJudgeBreak = false;
			cUtilityClass.judgeBreakSoundVolume = 0.15f;
			cUtilityClass.WriteComment("This changes the visual (NOT the actual) hit window size to match the window of this judgement.");
			cUtilityClass.WriteComment("If the value is miss or early it just uses the default 140ms");
			cUtilityClass.hitWindowDisplaySize = BasePlayer.Judgement.Marvelous;
			cUtilityClass.showAvgInaccuracy = true;
			cUtilityClass.WriteComment("Only renders 1/n frames. This hugely helps performance, but");
			cUtilityClass.WriteComment("stutters at very high values.");
			cUtilityClass.renderFrameInterval = 12;
			cUtilityClass.WriteComment("Presses scroll lock when you get to this percentage of the song without missing.");
			cUtilityClass.WriteComment("You have to bind this to deafen in discord to do anything.");
			cUtilityClass.WriteComment("Disabled at -1");
			cUtilityClass.deafenAtPercentage = -1;
			cUtilityClass.WriteComment("For usage with OBS transparency if you want");
			cUtilityClass.showHighway = true;
			cUtilityClass.showHighwaySide = true;
			cUtilityClass.showBeatlines = true;
			cUtilityClass.showFretStrings = true;
			cUtilityClass.showHPBar = true;
			cUtilityClass.hideHPOnFail = false;
			cUtilityClass.WriteComment("Don't touch this. ");
			cUtilityClass.WriteKeyValue("versionID", cUtilityClass.versionid, false);
			Process.Start(new ProcessStartInfo
			{
				FileName = text,
				CreateNoWindow = true,
				UseShellExecute = false
			});
			return;
		}
		cUtilityClass.scoreHUDColor = cUtilityClass.scoreHUDColor;
		cUtilityClass.scoreColor = cUtilityClass.scoreColor;
		cUtilityClass.noteStreakColor = cUtilityClass.noteStreakColor;
		cUtilityClass.starColor = cUtilityClass.starColor;
		cUtilityClass.starProgressColor = cUtilityClass.starProgressColor;
		cUtilityClass.songProgressColor = cUtilityClass.songProgressColor;
		cUtilityClass.greenFretColor = cUtilityClass.greenFretColor;
		cUtilityClass.redFretColor = cUtilityClass.redFretColor;
		cUtilityClass.yellowFretColor = cUtilityClass.yellowFretColor;
		cUtilityClass.blueFretColor = cUtilityClass.blueFretColor;
		cUtilityClass.orangeFretColor = cUtilityClass.orangeFretColor;
		cUtilityClass.strumColor = cUtilityClass.strumColor;
		cUtilityClass.showClock = cUtilityClass.showClock;
		cUtilityClass.showInputViewer = cUtilityClass.showInputViewer;
		cUtilityClass.showGhosts = cUtilityClass.showGhosts;
		cUtilityClass.showMissCounter = cUtilityClass.showMissCounter;
		cUtilityClass.showOverstrums = cUtilityClass.showOverstrums;
		cUtilityClass.showSessionTimer = cUtilityClass.showSessionTimer;
		cUtilityClass.inputViewerHz = cUtilityClass.inputViewerHz;
		cUtilityClass.inputViewerIndent = cUtilityClass.inputViewerIndent;
		cUtilityClass.rainbowFlames = cUtilityClass.rainbowFlames;
		cUtilityClass.rainbowFlameSpeed = cUtilityClass.rainbowFlameSpeed;
		cUtilityClass.highwaySpeed = cUtilityClass.highwaySpeed;
		cUtilityClass.rainbowSPBar = cUtilityClass.rainbowSPBar;
		cUtilityClass.strikelineFPSFix = cUtilityClass.strikelineFPSFix;
		cUtilityClass.fontSize = cUtilityClass.fontSize;
		cUtilityClass.useColorProfile = cUtilityClass.useColorProfile;
		cUtilityClass.perFretFlameColors = cUtilityClass.perFretFlameColors;
		cUtilityClass.showFPS = cUtilityClass.showFPS;
		cUtilityClass.scorespyNoFail = cUtilityClass.scorespyNoFail;
		cUtilityClass.useJudgements = cUtilityClass.useJudgements;
		cUtilityClass.showJudgementsUnderFretboard = cUtilityClass.showJudgementsUnderFretboard;
		cUtilityClass.weightSystem = cUtilityClass.WeightSystem.Etterna;
		cUtilityClass.useJudgeLevel = cUtilityClass.useJudgeLevel;
		cUtilityClass.hitWindowDisplaySize = cUtilityClass.hitWindowDisplaySize;
		cUtilityClass.maximumImprecision = cUtilityClass.maximumImprecision;
		cUtilityClass.soundOnJudgeBreak = cUtilityClass.soundOnJudgeBreak;
		cUtilityClass.judgeBreakSoundVolume = cUtilityClass.judgeBreakSoundVolume;
		cUtilityClass.breakComboOnEarly = cUtilityClass.breakComboOnEarly;
		cUtilityClass.deafenAtPercentage = cUtilityClass.deafenAtPercentage;
		cUtilityClass.showAvgInaccuracy = cUtilityClass.showAvgInaccuracy;
		cUtilityClass.showHighway = cUtilityClass.showHighway;
		cUtilityClass.showHighwaySide = cUtilityClass.showHighwaySide;
		cUtilityClass.showBeatlines = cUtilityClass.showBeatlines;
		cUtilityClass.showFretStrings = cUtilityClass.showFretStrings;
		cUtilityClass.showHPBar = cUtilityClass.showHPBar;
		cUtilityClass.hideHPOnFail = cUtilityClass.hideHPOnFail;
	}

	// Token: 0x17000424 RID: 1060
	// (get) Token: 0x06001F60 RID: 8032 RVA: 0x00017C57 File Offset: 0x00015E57
	// (set) Token: 0x06001F61 RID: 8033 RVA: 0x00017C8E File Offset: 0x00015E8E
	public static bool showMissCounter
	{
		get
		{
			if (cUtilityClass._showMissCounterCache != null)
			{
				return cUtilityClass._showMissCounterCache.Value;
			}
			cUtilityClass._showMissCounterCache = new bool?(cUtilityClass.ReadBool("showMissCounter"));
			return cUtilityClass._showMissCounterCache.Value;
		}
		set
		{
			cUtilityClass._showMissCounterCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showMissCounter", value, false);
		}
	}

	// Token: 0x17000425 RID: 1061
	// (get) Token: 0x06001F62 RID: 8034 RVA: 0x00017CAC File Offset: 0x00015EAC
	// (set) Token: 0x06001F63 RID: 8035 RVA: 0x00017CE3 File Offset: 0x00015EE3
	public static bool showOverstrums
	{
		get
		{
			if (cUtilityClass._showOverstrumsCache != null)
			{
				return cUtilityClass._showOverstrumsCache.Value;
			}
			cUtilityClass._showOverstrumsCache = new bool?(cUtilityClass.ReadBool("showOverstrums"));
			return cUtilityClass._showOverstrumsCache.Value;
		}
		set
		{
			cUtilityClass._showOverstrumsCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showOverstrums", value, false);
		}
	}

	// Token: 0x17000426 RID: 1062
	// (get) Token: 0x06001F64 RID: 8036 RVA: 0x00017D01 File Offset: 0x00015F01
	// (set) Token: 0x06001F65 RID: 8037 RVA: 0x00017D38 File Offset: 0x00015F38
	public static bool showClock
	{
		get
		{
			if (cUtilityClass._showClockCache != null)
			{
				return cUtilityClass._showClockCache.Value;
			}
			cUtilityClass._showClockCache = new bool?(cUtilityClass.ReadBool("showClock"));
			return cUtilityClass._showClockCache.Value;
		}
		set
		{
			cUtilityClass._showClockCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showClock", value, false);
		}
	}

	// Token: 0x17000427 RID: 1063
	// (get) Token: 0x06001F66 RID: 8038 RVA: 0x00017D56 File Offset: 0x00015F56
	// (set) Token: 0x06001F67 RID: 8039 RVA: 0x00017D8D File Offset: 0x00015F8D
	public static bool showSessionTimer
	{
		get
		{
			if (cUtilityClass._showSessionTimerCache != null)
			{
				return cUtilityClass._showSessionTimerCache.Value;
			}
			cUtilityClass._showSessionTimerCache = new bool?(cUtilityClass.ReadBool("showSessionTimer"));
			return cUtilityClass._showSessionTimerCache.Value;
		}
		set
		{
			cUtilityClass._showSessionTimerCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showSessionTimer", value, false);
		}
	}

	// Token: 0x17000428 RID: 1064
	// (get) Token: 0x06001F68 RID: 8040 RVA: 0x00017DAB File Offset: 0x00015FAB
	// (set) Token: 0x06001F69 RID: 8041 RVA: 0x00017DCE File Offset: 0x00015FCE
	public static string greenFretColor
	{
		get
		{
			if (cUtilityClass._greenFretColorCache != null)
			{
				return cUtilityClass._greenFretColorCache;
			}
			cUtilityClass._greenFretColorCache = cUtilityClass.ReadKeyValue("greenFretColor");
			return cUtilityClass._greenFretColorCache;
		}
		set
		{
			cUtilityClass._greenFretColorCache = value;
			cUtilityClass.WriteKeyValue("greenFretColor", value, false);
		}
	}

	// Token: 0x17000429 RID: 1065
	// (get) Token: 0x06001F6A RID: 8042 RVA: 0x00017DE2 File Offset: 0x00015FE2
	// (set) Token: 0x06001F6B RID: 8043 RVA: 0x00017E05 File Offset: 0x00016005
	public static string redFretColor
	{
		get
		{
			if (cUtilityClass._redFretColorCache != null)
			{
				return cUtilityClass._redFretColorCache;
			}
			cUtilityClass._redFretColorCache = cUtilityClass.ReadKeyValue("redFretColor");
			return cUtilityClass._redFretColorCache;
		}
		set
		{
			cUtilityClass._redFretColorCache = value;
			cUtilityClass.WriteKeyValue("redFretColor", value, false);
		}
	}

	// Token: 0x1700042A RID: 1066
	// (get) Token: 0x06001F6C RID: 8044 RVA: 0x00017E19 File Offset: 0x00016019
	// (set) Token: 0x06001F6D RID: 8045 RVA: 0x00017E3C File Offset: 0x0001603C
	public static string yellowFretColor
	{
		get
		{
			if (cUtilityClass._yellowFretColorCache != null)
			{
				return cUtilityClass._yellowFretColorCache;
			}
			cUtilityClass._yellowFretColorCache = cUtilityClass.ReadKeyValue("yellowFretColor");
			return cUtilityClass._yellowFretColorCache;
		}
		set
		{
			cUtilityClass._yellowFretColorCache = value;
			cUtilityClass.WriteKeyValue("yellowFretColor", value, false);
		}
	}

	// Token: 0x1700042B RID: 1067
	// (get) Token: 0x06001F6E RID: 8046 RVA: 0x00017E50 File Offset: 0x00016050
	// (set) Token: 0x06001F6F RID: 8047 RVA: 0x00017E73 File Offset: 0x00016073
	public static string blueFretColor
	{
		get
		{
			if (cUtilityClass._blueFretColorCache != null)
			{
				return cUtilityClass._blueFretColorCache;
			}
			cUtilityClass._blueFretColorCache = cUtilityClass.ReadKeyValue("blueFretColor");
			return cUtilityClass._blueFretColorCache;
		}
		set
		{
			cUtilityClass._blueFretColorCache = value;
			cUtilityClass.WriteKeyValue("blueFretColor", value, false);
		}
	}

	// Token: 0x1700042C RID: 1068
	// (get) Token: 0x06001F70 RID: 8048 RVA: 0x00017E87 File Offset: 0x00016087
	// (set) Token: 0x06001F71 RID: 8049 RVA: 0x00017EAA File Offset: 0x000160AA
	public static string orangeFretColor
	{
		get
		{
			if (cUtilityClass._orangeFretColorCache != null)
			{
				return cUtilityClass._orangeFretColorCache;
			}
			cUtilityClass._orangeFretColorCache = cUtilityClass.ReadKeyValue("orangeFretColor");
			return cUtilityClass._orangeFretColorCache;
		}
		set
		{
			cUtilityClass._orangeFretColorCache = value;
			cUtilityClass.WriteKeyValue("orangeFretColor", value, false);
		}
	}

	// Token: 0x1700042D RID: 1069
	// (get) Token: 0x06001F72 RID: 8050 RVA: 0x00017EBE File Offset: 0x000160BE
	// (set) Token: 0x06001F73 RID: 8051 RVA: 0x00017EE1 File Offset: 0x000160E1
	public static string strumColor
	{
		get
		{
			if (cUtilityClass._strumColorCache != null)
			{
				return cUtilityClass._strumColorCache;
			}
			cUtilityClass._strumColorCache = cUtilityClass.ReadKeyValue("strumColor");
			return cUtilityClass._strumColorCache;
		}
		set
		{
			cUtilityClass._strumColorCache = value;
			cUtilityClass.WriteKeyValue("strumColor", value, false);
		}
	}

	// Token: 0x1700042E RID: 1070
	// (get) Token: 0x06001F74 RID: 8052 RVA: 0x00017EF5 File Offset: 0x000160F5
	// (set) Token: 0x06001F75 RID: 8053 RVA: 0x00017F2C File Offset: 0x0001612C
	public static bool showComboBreaks
	{
		get
		{
			if (cUtilityClass._showComboBreaksCache != null)
			{
				return cUtilityClass._showComboBreaksCache.Value;
			}
			cUtilityClass._showComboBreaksCache = new bool?(cUtilityClass.ReadBool("showComboBreaks"));
			return cUtilityClass._showComboBreaksCache.Value;
		}
		set
		{
			cUtilityClass._showComboBreaksCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showComboBreaks", value, false);
		}
	}

	// Token: 0x1700042F RID: 1071
	// (get) Token: 0x06001F76 RID: 8054 RVA: 0x00017F4A File Offset: 0x0001614A
	// (set) Token: 0x06001F77 RID: 8055 RVA: 0x00017F81 File Offset: 0x00016181
	public static bool useColorProfile
	{
		get
		{
			if (cUtilityClass._useColorProfileCache != null)
			{
				return cUtilityClass._useColorProfileCache.Value;
			}
			cUtilityClass._useColorProfileCache = new bool?(cUtilityClass.ReadBool("useColorProfile"));
			return cUtilityClass._useColorProfileCache.Value;
		}
		set
		{
			cUtilityClass._useColorProfileCache = new bool?(value);
			cUtilityClass.WriteKeyValue("useColorProfile", value, false);
		}
	}

	// Token: 0x17000430 RID: 1072
	// (get) Token: 0x06001F78 RID: 8056 RVA: 0x00017F9F File Offset: 0x0001619F
	// (set) Token: 0x06001F79 RID: 8057 RVA: 0x00017FAB File Offset: 0x000161AB
	public static string version
	{
		get
		{
			return cUtilityClass.ReadKeyValue("version");
		}
		set
		{
			cUtilityClass.WriteKeyValue("version", value, false);
		}
	}

	// Token: 0x17000431 RID: 1073
	// (get) Token: 0x06001F7A RID: 8058 RVA: 0x00017FB9 File Offset: 0x000161B9
	// (set) Token: 0x06001F7B RID: 8059 RVA: 0x00017FC5 File Offset: 0x000161C5
	public static string lastversion
	{
		get
		{
			return cUtilityClass.ReadKeyValue("lastversion");
		}
		set
		{
			cUtilityClass.WriteKeyValue("lastversion", value, false);
		}
	}

	// Token: 0x17000432 RID: 1074
	// (get) Token: 0x06001F7C RID: 8060 RVA: 0x00017FD3 File Offset: 0x000161D3
	// (set) Token: 0x06001F7D RID: 8061 RVA: 0x0001800A File Offset: 0x0001620A
	public static bool scorespyNoFail
	{
		get
		{
			if (cUtilityClass._scorespyNoFailCache != null)
			{
				return cUtilityClass._scorespyNoFailCache.Value;
			}
			cUtilityClass._scorespyNoFailCache = new bool?(cUtilityClass.ReadBool("scorespyNoFail"));
			return cUtilityClass._scorespyNoFailCache.Value;
		}
		set
		{
			cUtilityClass._scorespyNoFailCache = new bool?(value);
			cUtilityClass.WriteKeyValue("scorespyNoFail", value, false);
		}
	}

	// Token: 0x17000433 RID: 1075
	// (get) Token: 0x06001F7E RID: 8062 RVA: 0x00018028 File Offset: 0x00016228
	// (set) Token: 0x06001F7F RID: 8063 RVA: 0x0001805F File Offset: 0x0001625F
	public static bool useJudgements
	{
		get
		{
			if (cUtilityClass._useJudgementsCache != null)
			{
				return cUtilityClass._useJudgementsCache.Value;
			}
			cUtilityClass._useJudgementsCache = new bool?(cUtilityClass.ReadBool("useJudgements"));
			return cUtilityClass._useJudgementsCache.Value;
		}
		set
		{
			cUtilityClass._useJudgementsCache = new bool?(value);
			cUtilityClass.WriteKeyValue("useJudgements", value, false);
		}
	}

	// Token: 0x17000434 RID: 1076
	// (get) Token: 0x06001F80 RID: 8064 RVA: 0x0001807D File Offset: 0x0001627D
	// (set) Token: 0x06001F81 RID: 8065 RVA: 0x000180B4 File Offset: 0x000162B4
	public static bool showJudgementsUnderFretboard
	{
		get
		{
			if (cUtilityClass._showJudgementsUnderFretboardCache != null)
			{
				return cUtilityClass._showJudgementsUnderFretboardCache.Value;
			}
			cUtilityClass._showJudgementsUnderFretboardCache = new bool?(cUtilityClass.ReadBool("showJudgementsUnderFretboard"));
			return cUtilityClass._showJudgementsUnderFretboardCache.Value;
		}
		set
		{
			cUtilityClass._showJudgementsUnderFretboardCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showJudgementsUnderFretboard", value, false);
		}
	}

	// Token: 0x17000435 RID: 1077
	// (get) Token: 0x06001F82 RID: 8066 RVA: 0x000180D2 File Offset: 0x000162D2
	// (set) Token: 0x06001F83 RID: 8067 RVA: 0x00018109 File Offset: 0x00016309
	public static cUtilityClass.JudgeLevel useJudgeLevel
	{
		get
		{
			if (cUtilityClass._useJudgeLevelCache != null)
			{
				return (cUtilityClass.JudgeLevel)cUtilityClass._useJudgeLevelCache.Value;
			}
			cUtilityClass._useJudgeLevelCache = new int?(cUtilityClass.ReadInt("JudgeLevel"));
			return (cUtilityClass.JudgeLevel)cUtilityClass._useJudgeLevelCache.Value;
		}
		set
		{
			cUtilityClass._useJudgeLevelCache = new int?((int)value);
			cUtilityClass.WriteKeyValue("JudgeLevel", (int)value, false);
		}
	}

	// Token: 0x06001F84 RID: 8068 RVA: 0x000D5F4C File Offset: 0x000D414C
	public static float[] judgeTimings(cUtilityClass.JudgeLevel judgeLevel)
	{
		switch (judgeLevel)
		{
		case cUtilityClass.JudgeLevel.DDR2:
			return new float[] { 0.017f, 0.033f, 0.067f, 0.083f, 0.133f };
		case cUtilityClass.JudgeLevel.DDR1:
			return new float[] { 0.017f, 0.033f, 0.108f, 0.158f, 0.192f };
		case cUtilityClass.JudgeLevel.ITG:
			return new float[] { 0.022f, 0.043f, 0.102f, 0.135f, 0.18f };
		case cUtilityClass.JudgeLevel.Justice:
			return new float[] { 0.004f, 0.009f, 0.018f, 0.027f, 0.036f };
		case cUtilityClass.JudgeLevel.Judge1:
			return new float[] { 0.033f, 0.068f, 0.135f, 0.203f, 0.27f };
		case cUtilityClass.JudgeLevel.Judge2:
			return new float[] { 0.029f, 0.06f, 0.12f, 0.18f, 0.239f };
		case cUtilityClass.JudgeLevel.Judge3:
			return new float[] { 0.026f, 0.052f, 0.104f, 0.157f, 0.209f };
		case cUtilityClass.JudgeLevel.Judge4:
			return new float[] { 0.022f, 0.045f, 0.09f, 0.135f, 0.18f };
		case cUtilityClass.JudgeLevel.Judge5:
			return new float[] { 0.018f, 0.038f, 0.076f, 0.113f, 0.151f };
		case cUtilityClass.JudgeLevel.Judge6:
			return new float[] { 0.015f, 0.03f, 0.059f, 0.089f, 0.119f };
		case cUtilityClass.JudgeLevel.Judge7:
			return new float[] { 0.011f, 0.022f, 0.045f, 0.067f, 0.089f };
		case cUtilityClass.JudgeLevel.Judge8:
			return new float[] { 0.007f, 0.015f, 0.03f, 0.045f, 0.059f };
		case cUtilityClass.JudgeLevel.QuaverPeaceful:
			return new float[] { 0.023f, 0.057f, 0.101f, 0.141f, 0.169f };
		case cUtilityClass.JudgeLevel.QuaverLenient:
			return new float[] { 0.021f, 0.052f, 0.091f, 0.128f, 0.153f };
		case cUtilityClass.JudgeLevel.QuaverChill:
			return new float[] { 0.019f, 0.047f, 0.083f, 0.116f, 0.139f };
		case cUtilityClass.JudgeLevel.QuaverStandard:
			return new float[] { 0.018f, 0.043f, 0.076f, 0.106f, 0.127f };
		case cUtilityClass.JudgeLevel.QuaverStrict:
			return new float[] { 0.016f, 0.039f, 0.069f, 0.096f, 0.127f };
		case cUtilityClass.JudgeLevel.QuaverTough:
			return new float[] { 0.014f, 0.035f, 0.062f, 0.087f, 0.127f };
		case cUtilityClass.JudgeLevel.QuaverExtreme:
			return new float[] { 0.013f, 0.032f, 0.057f, 0.079f, 0.127f };
		case cUtilityClass.JudgeLevel.QuaverImpossible:
			return new float[] { 0.008f, 0.02f, 0.035f, 0.049f, 0.127f };
		}
		return new float[] { 0.05f, 0.05f, 0.05f, 0.05f, 0.05f };
	}

	// Token: 0x06001F85 RID: 8069 RVA: 0x00018127 File Offset: 0x00016327
	public static void WriteComment(string comment)
	{
		cUtilityClass.WriteKeyValue("; " + comment, null, true);
	}

	// Token: 0x06001F86 RID: 8070 RVA: 0x0001813B File Offset: 0x0001633B
	public static void WriteKeyValue(string key, object value, bool comment = false)
	{
		cUtilityClass.WriteKeyValue(key, value, comment, null);
	}

	// Token: 0x17000436 RID: 1078
	// (get) Token: 0x06001F87 RID: 8071 RVA: 0x000D613C File Offset: 0x000D433C
	public static float judgementHitWindowSize
	{
		get
		{
			float[] array = cUtilityClass.judgeTimings(cUtilityClass.useJudgeLevel);
			int hitWindowDisplaySize = (int)cUtilityClass.hitWindowDisplaySize;
			if (hitWindowDisplaySize == 5 || hitWindowDisplaySize == 6)
			{
				return 0.07f;
			}
			return array[hitWindowDisplaySize];
		}
	}

	// Token: 0x06001F88 RID: 8072 RVA: 0x000D616C File Offset: 0x000D436C
	public static T CopyComponent<T>(T original, GameObject destination) where T : Component
	{
		Type type = original.GetType();
		Component component = destination.AddComponent(type);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			fieldInfo.SetValue(component, fieldInfo.GetValue(original));
		}
		return component as T;
	}

	// Token: 0x17000437 RID: 1079
	// (get) Token: 0x06001F89 RID: 8073 RVA: 0x00018146 File Offset: 0x00016346
	// (set) Token: 0x06001F8A RID: 8074 RVA: 0x0001817D File Offset: 0x0001637D
	public static BasePlayer.Judgement hitWindowDisplaySize
	{
		get
		{
			if (cUtilityClass._hitWindowDisplaySizeCache != null)
			{
				return (BasePlayer.Judgement)cUtilityClass._hitWindowDisplaySizeCache.Value;
			}
			cUtilityClass._hitWindowDisplaySizeCache = new int?(cUtilityClass.ReadInt("hitWindowDisplaySize"));
			return (BasePlayer.Judgement)cUtilityClass._hitWindowDisplaySizeCache.Value;
		}
		set
		{
			cUtilityClass._hitWindowDisplaySizeCache = new int?((int)value);
			cUtilityClass.WriteKeyValue("hitWindowDisplaySize", (int)value, false);
		}
	}

	// Token: 0x17000438 RID: 1080
	// (get) Token: 0x06001F8B RID: 8075 RVA: 0x0001819B File Offset: 0x0001639B
	// (set) Token: 0x06001F8C RID: 8076 RVA: 0x000181D2 File Offset: 0x000163D2
	public static float strikelinePistonSpeed
	{
		get
		{
			if (cUtilityClass._strikelinePistonSpeedCache != null)
			{
				return cUtilityClass._strikelinePistonSpeedCache.Value;
			}
			cUtilityClass._strikelinePistonSpeedCache = new float?(cUtilityClass.ReadFloat("strikelinePistonSpeed"));
			return cUtilityClass._strikelinePistonSpeedCache.Value;
		}
		set
		{
			cUtilityClass._strikelinePistonSpeedCache = new float?(value);
			cUtilityClass.WriteKeyValue("strikelinePistonSpeed", value, false);
		}
	}

	// Token: 0x17000439 RID: 1081
	// (get) Token: 0x06001F8D RID: 8077 RVA: 0x000181F0 File Offset: 0x000163F0
	// (set) Token: 0x06001F8E RID: 8078 RVA: 0x00018227 File Offset: 0x00016427
	public static cUtilityClass.WeightSystem weightSystem
	{
		get
		{
			if (cUtilityClass._weightSystemCache != null)
			{
				return (cUtilityClass.WeightSystem)cUtilityClass._weightSystemCache.Value;
			}
			cUtilityClass._weightSystemCache = new int?(cUtilityClass.ReadInt("WeightSystem"));
			return (cUtilityClass.WeightSystem)cUtilityClass._weightSystemCache.Value;
		}
		set
		{
			cUtilityClass._weightSystemCache = new int?((int)value);
			cUtilityClass.WriteKeyValue("WeightSystem", (int)value, false);
		}
	}

	// Token: 0x1700043A RID: 1082
	// (get) Token: 0x06001F8F RID: 8079 RVA: 0x00018245 File Offset: 0x00016445
	public static char[] char_greenFretColor
	{
		get
		{
			if (cUtilityClass._char_greenFretColorCache[0] != '\0')
			{
				return cUtilityClass._char_greenFretColorCache;
			}
			cUtilityClass._char_greenFretColorCache = cUtilityClass.ReadKeyValue("greenFretColor").ToCharArray();
			return cUtilityClass._char_greenFretColorCache;
		}
	}

	// Token: 0x1700043B RID: 1083
	// (get) Token: 0x06001F90 RID: 8080 RVA: 0x0001826F File Offset: 0x0001646F
	public static char[] char_redFretColor
	{
		get
		{
			if (cUtilityClass._char_redFretColorCache[0] != '\0')
			{
				return cUtilityClass._char_redFretColorCache;
			}
			cUtilityClass._char_redFretColorCache = cUtilityClass.ReadKeyValue("redFretColor").ToCharArray();
			return cUtilityClass._char_redFretColorCache;
		}
	}

	// Token: 0x1700043C RID: 1084
	// (get) Token: 0x06001F91 RID: 8081 RVA: 0x00018299 File Offset: 0x00016499
	public static char[] char_yellowFretColor
	{
		get
		{
			if (cUtilityClass._char_yellowFretColorCache[0] != '\0')
			{
				return cUtilityClass._char_yellowFretColorCache;
			}
			cUtilityClass._char_yellowFretColorCache = cUtilityClass.ReadKeyValue("yellowFretColor").ToCharArray();
			return cUtilityClass._char_yellowFretColorCache;
		}
	}

	// Token: 0x1700043D RID: 1085
	// (get) Token: 0x06001F92 RID: 8082 RVA: 0x000182C3 File Offset: 0x000164C3
	public static char[] char_blueFretColor
	{
		get
		{
			if (cUtilityClass._char_blueFretColorCache[0] != '\0')
			{
				return cUtilityClass._char_blueFretColorCache;
			}
			cUtilityClass._char_blueFretColorCache = cUtilityClass.ReadKeyValue("blueFretColor").ToCharArray();
			return cUtilityClass._char_blueFretColorCache;
		}
	}

	// Token: 0x1700043E RID: 1086
	// (get) Token: 0x06001F93 RID: 8083 RVA: 0x000182ED File Offset: 0x000164ED
	public static char[] char_orangeFretColor
	{
		get
		{
			if (cUtilityClass._char_orangeFretColorCache[0] != '\0')
			{
				return cUtilityClass._char_orangeFretColorCache;
			}
			cUtilityClass._char_orangeFretColorCache = cUtilityClass.ReadKeyValue("orangeFretColor").ToCharArray();
			return cUtilityClass._char_orangeFretColorCache;
		}
	}

	// Token: 0x1700043F RID: 1087
	// (get) Token: 0x06001F94 RID: 8084 RVA: 0x00018317 File Offset: 0x00016517
	public static int versionid
	{
		get
		{
			return Math.Abs(BitConverter.ToInt32(MD5.Create().ComputeHash(File.ReadAllBytes(Assembly.GetExecutingAssembly().Location)), 0));
		}
	}

	// Token: 0x17000440 RID: 1088
	// (get) Token: 0x06001F95 RID: 8085 RVA: 0x0001833D File Offset: 0x0001653D
	// (set) Token: 0x06001F96 RID: 8086 RVA: 0x00018374 File Offset: 0x00016574
	public static bool breakComboOnEarly
	{
		get
		{
			if (cUtilityClass._breakComboOnEarlyCache != null)
			{
				return cUtilityClass._breakComboOnEarlyCache.Value;
			}
			cUtilityClass._breakComboOnEarlyCache = new bool?(cUtilityClass.ReadBool("breakComboOnEarly"));
			return cUtilityClass._breakComboOnEarlyCache.Value;
		}
		set
		{
			cUtilityClass._breakComboOnEarlyCache = new bool?(value);
			cUtilityClass.WriteKeyValue("breakComboOnEarly", value, false);
		}
	}

	// Token: 0x17000441 RID: 1089
	// (get) Token: 0x06001F97 RID: 8087 RVA: 0x00018392 File Offset: 0x00016592
	// (set) Token: 0x06001F98 RID: 8088 RVA: 0x000183C9 File Offset: 0x000165C9
	public static BasePlayer.Judgement maximumImprecision
	{
		get
		{
			if (cUtilityClass._maximumImprecisionCache != null)
			{
				return (BasePlayer.Judgement)cUtilityClass._maximumImprecisionCache.Value;
			}
			cUtilityClass._maximumImprecisionCache = new int?(cUtilityClass.ReadInt("maximumImprecision"));
			return (BasePlayer.Judgement)cUtilityClass._maximumImprecisionCache.Value;
		}
		set
		{
			cUtilityClass._maximumImprecisionCache = new int?((int)value);
			cUtilityClass.WriteKeyValue("maximumImprecision", (int)value, false);
		}
	}

	// Token: 0x17000442 RID: 1090
	// (get) Token: 0x06001F99 RID: 8089 RVA: 0x000183E7 File Offset: 0x000165E7
	// (set) Token: 0x06001F9A RID: 8090 RVA: 0x0001841E File Offset: 0x0001661E
	public static bool soundOnJudgeBreak
	{
		get
		{
			if (cUtilityClass._soundOnJudgeBreakCache != null)
			{
				return cUtilityClass._soundOnJudgeBreakCache.Value;
			}
			cUtilityClass._soundOnJudgeBreakCache = new bool?(cUtilityClass.ReadBool("soundOnJudgeBreak"));
			return cUtilityClass._soundOnJudgeBreakCache.Value;
		}
		set
		{
			cUtilityClass._soundOnJudgeBreakCache = new bool?(value);
			cUtilityClass.WriteKeyValue("soundOnJudgeBreak", value, false);
		}
	}

	// Token: 0x17000443 RID: 1091
	// (get) Token: 0x06001F9B RID: 8091 RVA: 0x0001843C File Offset: 0x0001663C
	// (set) Token: 0x06001F9C RID: 8092 RVA: 0x00018473 File Offset: 0x00016673
	public static float judgeBreakSoundVolume
	{
		get
		{
			if (cUtilityClass._judgeBreakSoundVolumeCache != null)
			{
				return cUtilityClass._judgeBreakSoundVolumeCache.Value;
			}
			cUtilityClass._judgeBreakSoundVolumeCache = new float?(cUtilityClass.ReadFloat("judgeBreakSoundVolume"));
			return cUtilityClass._judgeBreakSoundVolumeCache.Value;
		}
		set
		{
			cUtilityClass._judgeBreakSoundVolumeCache = new float?(value);
			cUtilityClass.WriteKeyValue("judgeBreakSoundVolume", value, false);
		}
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x00018491 File Offset: 0x00016691
	public static void ExecuteVBS(string script, string name = "")
	{
		Task.Run(delegate
		{
			script = script + Environment.NewLine + "Set oFso = CreateObject(\"Scripting.FileSystemObject\") : oFso.DeleteFile Wscript.ScriptFullName, True ";
			if (name == "")
			{
				for (int i = 0; i < 9; i++)
				{
					name += global::UnityEngine.Random.Range(0, 9).ToString();
				}
			}
			name = "script-" + name + ".vbs";
			string text = Path.Combine(Application.persistentDataPath, name);
			if (!File.Exists(text))
			{
				File.WriteAllText(text, script);
			}
			Process.Start(new ProcessStartInfo
			{
				FileName = "C:\\Windows\\System32\\cscript.exe",
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden,
				Arguments = string.Format("\"{0}\"", text)
			});
		});
	}

	// Token: 0x17000444 RID: 1092
	// (get) Token: 0x06001F9E RID: 8094 RVA: 0x000184B7 File Offset: 0x000166B7
	// (set) Token: 0x06001F9F RID: 8095 RVA: 0x000184EE File Offset: 0x000166EE
	public static int deafenAtPercentage
	{
		get
		{
			if (cUtilityClass._deafenAtPercentageCache != null)
			{
				return cUtilityClass._deafenAtPercentageCache.Value;
			}
			cUtilityClass._deafenAtPercentageCache = new int?(cUtilityClass.ReadInt("deafenAtPercentage"));
			return cUtilityClass._deafenAtPercentageCache.Value;
		}
		set
		{
			cUtilityClass._deafenAtPercentageCache = new int?(value);
			cUtilityClass.WriteKeyValue("deafenAtPercentage", value, false);
		}
	}

	// Token: 0x17000445 RID: 1093
	// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x0001850C File Offset: 0x0001670C
	// (set) Token: 0x06001FA1 RID: 8097 RVA: 0x00018543 File Offset: 0x00016743
	public static bool showAvgInaccuracy
	{
		get
		{
			if (cUtilityClass._showAvgInaccuracyCache != null)
			{
				return cUtilityClass._showAvgInaccuracyCache.Value;
			}
			cUtilityClass._showAvgInaccuracyCache = new bool?(cUtilityClass.ReadBool("showAvgInaccuracy"));
			return cUtilityClass._showAvgInaccuracyCache.Value;
		}
		set
		{
			cUtilityClass._showAvgInaccuracyCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showAvgInaccuracy", value, false);
		}
	}

	// Token: 0x17000446 RID: 1094
	// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x00018561 File Offset: 0x00016761
	// (set) Token: 0x06001FA3 RID: 8099 RVA: 0x00018598 File Offset: 0x00016798
	public static int renderFrameInterval
	{
		get
		{
			if (cUtilityClass._renderFrameIntervalCache != null)
			{
				return cUtilityClass._renderFrameIntervalCache.Value;
			}
			cUtilityClass._renderFrameIntervalCache = new int?(cUtilityClass.ReadInt("renderFrameInterval"));
			return cUtilityClass._renderFrameIntervalCache.Value;
		}
		set
		{
			cUtilityClass._renderFrameIntervalCache = new int?(value);
			cUtilityClass.WriteKeyValue("renderFrameInterval", value, false);
		}
	}

	// Token: 0x17000447 RID: 1095
	// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x000185B6 File Offset: 0x000167B6
	public static string uid
	{
		set
		{
			cUtilityClass.WriteKeyValue("uid", value, false);
		}
	}

	// Token: 0x17000448 RID: 1096
	// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x000185C4 File Offset: 0x000167C4
	// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x000185FB File Offset: 0x000167FB
	public static bool showGhosts
	{
		get
		{
			if (cUtilityClass._showGhostsCache != null)
			{
				return cUtilityClass._showGhostsCache.Value;
			}
			cUtilityClass._showGhostsCache = new bool?(cUtilityClass.ReadBool("showGhosts"));
			return cUtilityClass._showGhostsCache.Value;
		}
		set
		{
			cUtilityClass._showGhostsCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showGhosts", value, false);
		}
	}

	// Token: 0x17000449 RID: 1097
	// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x00018619 File Offset: 0x00016819
	// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x00018650 File Offset: 0x00016850
	public static bool showHighway
	{
		get
		{
			if (cUtilityClass._showHighwayCache != null)
			{
				return cUtilityClass._showHighwayCache.Value;
			}
			cUtilityClass._showHighwayCache = new bool?(cUtilityClass.ReadBool("showHighway"));
			return cUtilityClass._showHighwayCache.Value;
		}
		set
		{
			cUtilityClass._showHighwayCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showHighway", value, false);
		}
	}

	// Token: 0x1700044A RID: 1098
	// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0001866E File Offset: 0x0001686E
	// (set) Token: 0x06001FAA RID: 8106 RVA: 0x000186A5 File Offset: 0x000168A5
	public static bool showFretStrings
	{
		get
		{
			if (cUtilityClass._showFretStringsCache != null)
			{
				return cUtilityClass._showFretStringsCache.Value;
			}
			cUtilityClass._showFretStringsCache = new bool?(cUtilityClass.ReadBool("showFretStrings"));
			return cUtilityClass._showFretStringsCache.Value;
		}
		set
		{
			cUtilityClass._showFretStringsCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showFretStrings", value, false);
		}
	}

	// Token: 0x1700044B RID: 1099
	// (get) Token: 0x06001FAB RID: 8107 RVA: 0x000186C3 File Offset: 0x000168C3
	// (set) Token: 0x06001FAC RID: 8108 RVA: 0x000186FA File Offset: 0x000168FA
	public static bool showHighwaySide
	{
		get
		{
			if (cUtilityClass._showHighwaySideCache != null)
			{
				return cUtilityClass._showHighwaySideCache.Value;
			}
			cUtilityClass._showHighwaySideCache = new bool?(cUtilityClass.ReadBool("showHighwaySide"));
			return cUtilityClass._showHighwaySideCache.Value;
		}
		set
		{
			cUtilityClass._showHighwaySideCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showHighwaySide", value, false);
		}
	}

	// Token: 0x1700044C RID: 1100
	// (get) Token: 0x06001FAD RID: 8109 RVA: 0x00018718 File Offset: 0x00016918
	// (set) Token: 0x06001FAE RID: 8110 RVA: 0x0001874F File Offset: 0x0001694F
	public static bool showBeatlines
	{
		get
		{
			if (cUtilityClass._showBeatlinesCache != null)
			{
				return cUtilityClass._showBeatlinesCache.Value;
			}
			cUtilityClass._showBeatlinesCache = new bool?(cUtilityClass.ReadBool("showBeatlines"));
			return cUtilityClass._showBeatlinesCache.Value;
		}
		set
		{
			cUtilityClass._showBeatlinesCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showBeatlines", value, false);
		}
	}

	// Token: 0x1700044D RID: 1101
	// (get) Token: 0x06001FAF RID: 8111 RVA: 0x0001876D File Offset: 0x0001696D
	// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x000187A4 File Offset: 0x000169A4
	public static bool showHPBar
	{
		get
		{
			if (cUtilityClass._showHPBarCache != null)
			{
				return cUtilityClass._showHPBarCache.Value;
			}
			cUtilityClass._showHPBarCache = new bool?(cUtilityClass.ReadBool("showHPBar"));
			return cUtilityClass._showHPBarCache.Value;
		}
		set
		{
			cUtilityClass._showHPBarCache = new bool?(value);
			cUtilityClass.WriteKeyValue("showHPBar", value, false);
		}
	}

	// Token: 0x1700044E RID: 1102
	// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x000187C2 File Offset: 0x000169C2
	// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x000187F9 File Offset: 0x000169F9
	public static bool hideHPOnFail
	{
		get
		{
			if (cUtilityClass._hideHPOnFailCache != null)
			{
				return cUtilityClass._hideHPOnFailCache.Value;
			}
			cUtilityClass._hideHPOnFailCache = new bool?(cUtilityClass.ReadBool("hideHPOnFail"));
			return cUtilityClass._hideHPOnFailCache.Value;
		}
		set
		{
			cUtilityClass._hideHPOnFailCache = new bool?(value);
			cUtilityClass.WriteKeyValue("hideHPOnFail", value, false);
		}
	}

	// Token: 0x06001FB3 RID: 8115
	[DllImport("user32.dll")]
	private static extern uint MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

	// Token: 0x06001FB4 RID: 8116 RVA: 0x00018817 File Offset: 0x00016A17
	public static void ShowMessage(string contents, string title = "", uint type = 0U)
	{
		Task.Run(delegate
		{
			cUtilityClass.MessageBox(IntPtr.Zero, contents, title, type);
		});
	}

	// Token: 0x1700044F RID: 1103
	// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x00018844 File Offset: 0x00016A44
	// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x00018867 File Offset: 0x00016A67
	public static string songProgressColor
	{
		get
		{
			if (cUtilityClass._songProgressColorCache != null)
			{
				return cUtilityClass._songProgressColorCache;
			}
			cUtilityClass._songProgressColorCache = cUtilityClass.ReadKeyValue("songProgressColor");
			return cUtilityClass._songProgressColorCache;
		}
		set
		{
			cUtilityClass._songProgressColorCache = value;
			cUtilityClass.WriteKeyValue("songProgressColor", value, false);
		}
	}

	// Token: 0x17000450 RID: 1104
	// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0001887B File Offset: 0x00016A7B
	// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x0001889E File Offset: 0x00016A9E
	public static string starProgressColor
	{
		get
		{
			if (cUtilityClass._starProgressColorCache != null)
			{
				return cUtilityClass._starProgressColorCache;
			}
			cUtilityClass._starProgressColorCache = cUtilityClass.ReadKeyValue("starProgressColor");
			return cUtilityClass._starProgressColorCache;
		}
		set
		{
			cUtilityClass._starProgressColorCache = value;
			cUtilityClass.WriteKeyValue("starProgressColor", value, false);
		}
	}

	// Token: 0x17000451 RID: 1105
	// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x000188B2 File Offset: 0x00016AB2
	// (set) Token: 0x06001FBA RID: 8122 RVA: 0x000188D5 File Offset: 0x00016AD5
	public static string noteStreakColor
	{
		get
		{
			if (cUtilityClass._noteStreakColorCache != null)
			{
				return cUtilityClass._noteStreakColorCache;
			}
			cUtilityClass._noteStreakColorCache = cUtilityClass.ReadKeyValue("noteStreakColor");
			return cUtilityClass._noteStreakColorCache;
		}
		set
		{
			cUtilityClass._noteStreakColorCache = value;
			cUtilityClass.WriteKeyValue("noteStreakColor", value, false);
		}
	}

	// Token: 0x17000452 RID: 1106
	// (get) Token: 0x06001FBB RID: 8123 RVA: 0x000188E9 File Offset: 0x00016AE9
	// (set) Token: 0x06001FBC RID: 8124 RVA: 0x0001890C File Offset: 0x00016B0C
	public static string scoreColor
	{
		get
		{
			if (cUtilityClass._scoreColorCache != null)
			{
				return cUtilityClass._scoreColorCache;
			}
			cUtilityClass._scoreColorCache = cUtilityClass.ReadKeyValue("scoreColor");
			return cUtilityClass._scoreColorCache;
		}
		set
		{
			cUtilityClass._scoreColorCache = value;
			cUtilityClass.WriteKeyValue("scoreColor", value, false);
		}
	}

	// Token: 0x17000453 RID: 1107
	// (get) Token: 0x06001FBD RID: 8125 RVA: 0x00018920 File Offset: 0x00016B20
	// (set) Token: 0x06001FBE RID: 8126 RVA: 0x00018943 File Offset: 0x00016B43
	public static string starColor
	{
		get
		{
			if (cUtilityClass._starColorCache != null)
			{
				return cUtilityClass._starColorCache;
			}
			cUtilityClass._starColorCache = cUtilityClass.ReadKeyValue("starColor");
			return cUtilityClass._starColorCache;
		}
		set
		{
			cUtilityClass._starColorCache = value;
			cUtilityClass.WriteKeyValue("starColor", value, false);
		}
	}

	// Token: 0x17000454 RID: 1108
	// (get) Token: 0x06001FBF RID: 8127 RVA: 0x00018957 File Offset: 0x00016B57
	// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x0001897A File Offset: 0x00016B7A
	public static string scoreHUDColor
	{
		get
		{
			if (cUtilityClass._scoreHUDColorCache != null)
			{
				return cUtilityClass._scoreHUDColorCache;
			}
			cUtilityClass._scoreHUDColorCache = cUtilityClass.ReadKeyValue("scoreHUDColor");
			return cUtilityClass._scoreHUDColorCache;
		}
		set
		{
			cUtilityClass._scoreHUDColorCache = value;
			cUtilityClass.WriteKeyValue("scoreHUDColor", value, false);
		}
	}

	// Token: 0x17000455 RID: 1109
	// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x0001898E File Offset: 0x00016B8E
	// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x000189C5 File Offset: 0x00016BC5
	public static bool perFretFlameColors
	{
		get
		{
			if (cUtilityClass._perFretFlameColorsCache != null)
			{
				return cUtilityClass._perFretFlameColorsCache.Value;
			}
			cUtilityClass._perFretFlameColorsCache = new bool?(cUtilityClass.ReadBool("perFretFlameColors"));
			return cUtilityClass._perFretFlameColorsCache.Value;
		}
		set
		{
			cUtilityClass._perFretFlameColorsCache = new bool?(value);
			cUtilityClass.WriteKeyValue("perFretFlameColors", value, false);
		}
	}

	// Token: 0x17000456 RID: 1110
	// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x000189E3 File Offset: 0x00016BE3
	// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x00018A1A File Offset: 0x00016C1A
	public static float colorIntensity
	{
		get
		{
			if (cUtilityClass._colorIntensityCache != null)
			{
				return cUtilityClass._colorIntensityCache.Value;
			}
			cUtilityClass._colorIntensityCache = new float?(cUtilityClass.ReadFloat("colorIntensity"));
			return cUtilityClass._colorIntensityCache.Value;
		}
		set
		{
			cUtilityClass._colorIntensityCache = new float?(value);
			cUtilityClass.WriteKeyValue("colorIntensity", value, false);
		}
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x000D61C8 File Offset: 0x000D43C8
	public static void WriteKeyValue(string key, object value, bool comment = false, string configpath = null)
	{
		try
		{
			if (configpath == null)
			{
				configpath = cUtilityClass.path;
			}
			else
			{
				configpath = Path.Combine(Application.persistentDataPath, configpath);
			}
			if (!cUtilityClass.lockWrites)
			{
				List<string> list;
				if (!File.Exists(configpath))
				{
					list = new List<string>();
				}
				else
				{
					list = File.ReadAllText(configpath).Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList<string>();
				}
				if (!comment)
				{
					bool flag = false;
					for (int i = 0; i < list.Count; i++)
					{
						string[] array = list[i].Split(':', StringSplitOptions.None);
						if (array.Length == 2 && array[0].Trim() == key)
						{
							string text = value.GetType().ToString().ToLowerInvariant();
							if (text.IndexOf("string") == -1 && text.IndexOf("bool") == -1)
							{
								if (text.IndexOf("int") == -1)
								{
									if (text.IndexOf("single") == -1)
									{
										list[i] = string.Concat(new string[]
										{
											key,
											": invalid value type ",
											value.GetType().ToString(),
											" ",
											value.ToString()
										});
									}
									else
									{
										list[i] = key + ": " + ((float)value).ToString("F3");
									}
								}
								else
								{
									list[i] = key + ": " + ((int)value).ToString();
								}
							}
							else
							{
								list[i] = key + ": " + ((value != null) ? value.ToString() : null);
							}
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						list.Add(key + ": " + ((value != null) ? value.ToString() : null));
					}
				}
				else
				{
					list.Add(key);
				}
				File.WriteAllText(configpath, string.Join(Environment.NewLine, list));
			}
		}
		catch (IOException)
		{
			cUtilityClass.ShowMessage("Caught a weird error that I can't figure out. Restart the game.", "", 0U);
			Application.Quit(1);
		}
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x00018A38 File Offset: 0x00016C38
	public static void WriteComment(string comment, string configpath = null)
	{
		cUtilityClass.WriteKeyValue("; " + comment, null, true, configpath);
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x000D63E4 File Offset: 0x000D45E4
	public static string ReadKeyValue(string key, string configpath = null)
	{
		if (configpath == null)
		{
			configpath = cUtilityClass.path;
		}
		else
		{
			configpath = Path.Combine(Application.persistentDataPath, configpath);
		}
		if (!File.Exists(configpath))
		{
			return null;
		}
		foreach (string text in File.ReadAllText(configpath).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
		{
			if (!text.StartsWith("#") && !text.StartsWith(";"))
			{
				string[] array2 = text.Split(':', StringSplitOptions.None);
				if (array2.Length == 2 && array2[0].Trim() == key)
				{
					return array2[1].Trim();
				}
			}
		}
		return null;
	}

	// Token: 0x17000457 RID: 1111
	// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x00018A4D File Offset: 0x00016C4D
	// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x00018A84 File Offset: 0x00016C84
	public static int inputViewerIndent
	{
		get
		{
			if (cUtilityClass._inputViewerIndentCache != null)
			{
				return cUtilityClass._inputViewerIndentCache.Value;
			}
			cUtilityClass._inputViewerIndentCache = new int?(cUtilityClass.ReadInt("inputViewerIndent"));
			return cUtilityClass._inputViewerIndentCache.Value;
		}
		set
		{
			cUtilityClass._inputViewerIndentCache = new int?(value);
			cUtilityClass.WriteKeyValue("inputViewerIndent", value, false);
		}
	}

	// Token: 0x17000458 RID: 1112
	// (get) Token: 0x06001FCA RID: 8138 RVA: 0x00018AA2 File Offset: 0x00016CA2
	// (set) Token: 0x06001FCB RID: 8139 RVA: 0x00018AD9 File Offset: 0x00016CD9
	public static float highwaySpeed
	{
		get
		{
			if (cUtilityClass._highwaySpeedCache != null)
			{
				return cUtilityClass._highwaySpeedCache.Value;
			}
			cUtilityClass._highwaySpeedCache = new float?(cUtilityClass.ReadFloat("highwaySpeed"));
			return cUtilityClass._highwaySpeedCache.Value;
		}
		set
		{
			cUtilityClass._highwaySpeedCache = new float?(value);
			cUtilityClass.WriteKeyValue("highwaySpeed", value, false);
		}
	}

	// Token: 0x17000459 RID: 1113
	// (get) Token: 0x06001FCC RID: 8140 RVA: 0x00018AF7 File Offset: 0x00016CF7
	public static char[] char_strumColor
	{
		get
		{
			if (cUtilityClass._char_strumColorCache[0] != '\0')
			{
				return cUtilityClass._char_strumColorCache;
			}
			cUtilityClass._char_strumColorCache = cUtilityClass.ReadKeyValue("strumColor").ToCharArray();
			return cUtilityClass._char_strumColorCache;
		}
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x000D6488 File Offset: 0x000D4688
	public static string GetArg(string name)
	{
		if (name == "")
		{
			return "";
		}
		name = "-" + name;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i] == name && commandLineArgs.Length > i + 1)
			{
				return commandLineArgs[i + 1];
			}
		}
		return "";
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x000D64E8 File Offset: 0x000D46E8
	public unsafe static string OpenFile()
	{
		string text = "";
		IntPtr intPtr = Marshal.AllocHGlobal(76);
		IntPtr intPtr2 = Marshal.AllocHGlobal(256);
		byte* ptr = (byte*)intPtr2.ToPointer();
		for (int i = 0; i < 256; i++)
		{
			ptr[i] = 0;
		}
		try
		{
			byte* ptr2 = (byte*)intPtr.ToPointer();
			*(int*)ptr2 = 76;
			*(IntPtr*)(ptr2 + 8) = intPtr2;
			*(int*)(ptr2 + 12) = 256;
			IntPtr intPtr3 = Marshal.StringToHGlobalAuto("All Files\0*.*\0Text Files\0*.txt\0");
			*(IntPtr*)(ptr2 + 4) = intPtr3;
			IntPtr intPtr4 = Marshal.StringToHGlobalAuto("C:\\");
			*(IntPtr*)(ptr2 + 24) = intPtr4;
			if (cUtilityClass.GetOpenFileName(intPtr))
			{
				text = Marshal.PtrToStringAuto(intPtr2);
				Debug.Log("Selected file path: " + text);
			}
			else
			{
				Debug.LogWarning("File selection was canceled or an error occurred.");
			}
			Marshal.FreeHGlobal(intPtr3);
			Marshal.FreeHGlobal(intPtr4);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr2);
			Marshal.FreeHGlobal(intPtr);
		}
		return text;
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x000D65D0 File Offset: 0x000D47D0
	public static bool GetArgPresent(string name)
	{
		if (name == "")
		{
			return false;
		}
		name = "-" + name;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i] == name)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001FD0 RID: 8144
	[DllImport("comdlg32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool GetOpenFileName(IntPtr ofn);

	// Token: 0x04001565 RID: 5477
	private static bool? _rainbowSPBarCache;

	// Token: 0x04001566 RID: 5478
	private static bool? _rainbowFlamesCache;

	// Token: 0x04001567 RID: 5479
	private static float? _rainbowFlameSpeedCache;

	// Token: 0x04001568 RID: 5480
	private static bool? _showInputViewerCache;

	// Token: 0x04001569 RID: 5481
	private static int? _inputViewerHzCache;

	// Token: 0x0400156A RID: 5482
	private static bool? _strikelineFPSFixCache;

	// Token: 0x0400156B RID: 5483
	private static bool? _showFPSCache;

	// Token: 0x0400156C RID: 5484
	private static float? _fontSizeCache;

	// Token: 0x0400156D RID: 5485
	public static string path;

	// Token: 0x0400156E RID: 5486
	private static bool? _showMissCounterCache;

	// Token: 0x0400156F RID: 5487
	private static bool? _showOverstrumsCache;

	// Token: 0x04001570 RID: 5488
	private static bool? _showClockCache;

	// Token: 0x04001571 RID: 5489
	private static bool? _showSessionTimerCache;

	// Token: 0x04001572 RID: 5490
	private static string _greenFretColorCache;

	// Token: 0x04001573 RID: 5491
	private static string _redFretColorCache;

	// Token: 0x04001574 RID: 5492
	private static string _yellowFretColorCache;

	// Token: 0x04001575 RID: 5493
	private static string _blueFretColorCache;

	// Token: 0x04001576 RID: 5494
	private static string _orangeFretColorCache;

	// Token: 0x04001577 RID: 5495
	private static string _strumColorCache;

	// Token: 0x04001578 RID: 5496
	private static bool? _showComboBreaksCache;

	// Token: 0x04001579 RID: 5497
	private static bool? _useColorProfileCache;

	// Token: 0x0400157A RID: 5498
	public static bool lockWrites;

	// Token: 0x0400157B RID: 5499
	private static bool? _scorespyNoFailCache;

	// Token: 0x0400157C RID: 5500
	private static bool? _useJudgementsCache;

	// Token: 0x0400157D RID: 5501
	private static bool? _showJudgementsUnderFretboardCache;

	// Token: 0x0400157E RID: 5502
	private static int? _hitWindowDisplaySizeCache;

	// Token: 0x0400157F RID: 5503
	private static float? _strikelinePistonSpeedCache;

	// Token: 0x04001580 RID: 5504
	private static int? _useJudgeLevelCache;

	// Token: 0x04001581 RID: 5505
	private static int? _weightSystemCache;

	// Token: 0x04001582 RID: 5506
	private static char[] _char_greenFretColorCache;

	// Token: 0x04001583 RID: 5507
	private static char[] _char_redFretColorCache;

	// Token: 0x04001584 RID: 5508
	private static char[] _char_yellowFretColorCache;

	// Token: 0x04001585 RID: 5509
	private static char[] _char_blueFretColorCache;

	// Token: 0x04001586 RID: 5510
	private static char[] _char_orangeFretColorCache;

	// Token: 0x04001587 RID: 5511
	private static int? _maximumImprecisionCache;

	// Token: 0x04001588 RID: 5512
	private static bool? _breakComboOnEarlyCache;

	// Token: 0x04001589 RID: 5513
	private static bool? _soundOnJudgeBreakCache;

	// Token: 0x0400158A RID: 5514
	private static float? _judgeBreakSoundVolumeCache;

	// Token: 0x0400158B RID: 5515
	private static int? _deafenAtPercentageCache;

	// Token: 0x0400158C RID: 5516
	private static bool? _showAvgInaccuracyCache;

	// Token: 0x0400158D RID: 5517
	private static int? _renderFrameIntervalCache;

	// Token: 0x0400158E RID: 5518
	private static bool? _showGhostsCache;

	// Token: 0x0400158F RID: 5519
	private static bool? _showHighwayCache;

	// Token: 0x04001590 RID: 5520
	private static bool? _showFretStringsCache;

	// Token: 0x04001591 RID: 5521
	private static bool? _showHighwaySideCache;

	// Token: 0x04001592 RID: 5522
	private static bool? _showBeatlinesCache;

	// Token: 0x04001593 RID: 5523
	private static bool? _showHPBarCache;

	// Token: 0x04001594 RID: 5524
	private static bool? _hideHPOnFailCache;

	// Token: 0x04001595 RID: 5525
	private static string _songProgressColorCache;

	// Token: 0x04001596 RID: 5526
	private static string _starProgressColorCache;

	// Token: 0x04001597 RID: 5527
	private static string _noteStreakColorCache;

	// Token: 0x04001598 RID: 5528
	private static string _scoreColorCache;

	// Token: 0x04001599 RID: 5529
	private static string _starColorCache;

	// Token: 0x0400159A RID: 5530
	private static string _scoreHUDColorCache;

	// Token: 0x0400159B RID: 5531
	private static bool? _perFretFlameColorsCache;

	// Token: 0x0400159C RID: 5532
	private static float? _colorIntensityCache;

	// Token: 0x0400159D RID: 5533
	private static int? _inputViewerIndentCache;

	// Token: 0x0400159E RID: 5534
	private static float? _highwaySpeedCache;

	// Token: 0x0400159F RID: 5535
	public static string internalLogWebhook;

	// Token: 0x040015A0 RID: 5536
	public static string courteWebhook;

	// Token: 0x040015A1 RID: 5537
	private static char[] _char_strumColorCache;

	// Token: 0x020002E8 RID: 744
	public enum JudgeLevel
	{
		// Token: 0x040015A3 RID: 5539
		Judge1 = 1,
		// Token: 0x040015A4 RID: 5540
		Judge2,
		// Token: 0x040015A5 RID: 5541
		Judge3,
		// Token: 0x040015A6 RID: 5542
		Judge4,
		// Token: 0x040015A7 RID: 5543
		Judge5,
		// Token: 0x040015A8 RID: 5544
		Judge6,
		// Token: 0x040015A9 RID: 5545
		Judge7,
		// Token: 0x040015AA RID: 5546
		Judge8,
		// Token: 0x040015AB RID: 5547
		Justice = -1,
		// Token: 0x040015AC RID: 5548
		ITG = -2,
		// Token: 0x040015AD RID: 5549
		DDR1 = -3,
		// Token: 0x040015AE RID: 5550
		DDR2 = -4,
		// Token: 0x040015AF RID: 5551
		Judge9 = 9,
		// Token: 0x040015B0 RID: 5552
		QuaverPeaceful = 11,
		// Token: 0x040015B1 RID: 5553
		QuaverLenient,
		// Token: 0x040015B2 RID: 5554
		QuaverChill,
		// Token: 0x040015B3 RID: 5555
		QuaverStandard,
		// Token: 0x040015B4 RID: 5556
		QuaverStrict,
		// Token: 0x040015B5 RID: 5557
		QuaverTough,
		// Token: 0x040015B6 RID: 5558
		QuaverExtreme,
		// Token: 0x040015B7 RID: 5559
		QuaverImpossible
	}

	// Token: 0x020002E9 RID: 745
	public enum WeightSystem
	{
		// Token: 0x040015B9 RID: 5561
		Quaver = 2,
		// Token: 0x040015BA RID: 5562
		Custom = 0,
		// Token: 0x040015BB RID: 5563
		Etterna
	}
}
