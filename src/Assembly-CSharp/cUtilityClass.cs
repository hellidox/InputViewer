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

public static class cUtilityClass
{
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
		cUtilityClass.version = "V2.0.8.2";
		cUtilityClass.InvalidateCache();
		cUtilityClass.internalLogWebhook = "https://discord.com/api/webhooks/1279779072762974302/fUIkbZNB_XHGIn-faRwy-s2nhI1DSY-z72Qwb3FAG_93mAVDODAlEZBJZw8ccm7vloaT";
		cUtilityClass.courteWebhook = "https://discord.com/api/webhooks/1287279052658573324/ms8Mhb877CNbL_zQC7Z6LYW1E4dIsSnS6AyWUEuaEG8rYS2ZVv_fkeJMCEBXTAI2O2Vq";
	}

	public static string ReadKeyValue(string key)
	{
		return cUtilityClass.ReadKeyValue(key, null);
	}

	public static bool ReadBool(string key)
	{
		bool flag;
		return bool.TryParse(cUtilityClass.ReadKeyValue(key), out flag) && flag;
	}

	private static float ReadFloat(string key)
	{
		float num;
		if (float.TryParse(cUtilityClass.ReadKeyValue(key), out num))
		{
			return num;
		}
		return 0f;
	}

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

	public static void WriteComment(string comment)
	{
		cUtilityClass.WriteKeyValue("; " + comment, null, true);
	}

	public static void WriteKeyValue(string key, object value, bool comment = false)
	{
		cUtilityClass.WriteKeyValue(key, value, comment, null);
	}

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

	public static int versionid
	{
		get
		{
			return Math.Abs(BitConverter.ToInt32(MD5.Create().ComputeHash(File.ReadAllBytes(Assembly.GetExecutingAssembly().Location)), 0));
		}
	}

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

	public static string uid
	{
		set
		{
			cUtilityClass.WriteKeyValue("uid", value, false);
		}
	}

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

	[DllImport("user32.dll")]
	private static extern uint MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

	public static void ShowMessage(string contents, string title = "", uint type = 0U)
	{
		Task.Run(delegate
		{
			cUtilityClass.MessageBox(IntPtr.Zero, contents, title, type);
		});
	}

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

	public static void WriteComment(string comment, string configpath = null)
	{
		cUtilityClass.WriteKeyValue("; " + comment, null, true, configpath);
	}

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

	[DllImport("comdlg32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool GetOpenFileName(IntPtr ofn);

	private static bool? _rainbowSPBarCache;

	private static bool? _rainbowFlamesCache;

	private static float? _rainbowFlameSpeedCache;

	private static bool? _showInputViewerCache;

	private static int? _inputViewerHzCache;

	private static bool? _strikelineFPSFixCache;

	private static bool? _showFPSCache;

	private static float? _fontSizeCache;

	public static string path;

	private static bool? _showMissCounterCache;

	private static bool? _showOverstrumsCache;

	private static bool? _showClockCache;

	private static bool? _showSessionTimerCache;

	private static string _greenFretColorCache;

	private static string _redFretColorCache;

	private static string _yellowFretColorCache;

	private static string _blueFretColorCache;

	private static string _orangeFretColorCache;

	private static string _strumColorCache;

	private static bool? _showComboBreaksCache;

	private static bool? _useColorProfileCache;

	public static bool lockWrites;

	private static bool? _scorespyNoFailCache;

	private static bool? _useJudgementsCache;

	private static bool? _showJudgementsUnderFretboardCache;

	private static int? _hitWindowDisplaySizeCache;

	private static float? _strikelinePistonSpeedCache;

	private static int? _useJudgeLevelCache;

	private static int? _weightSystemCache;

	private static char[] _char_greenFretColorCache;

	private static char[] _char_redFretColorCache;

	private static char[] _char_yellowFretColorCache;

	private static char[] _char_blueFretColorCache;

	private static char[] _char_orangeFretColorCache;

	private static int? _maximumImprecisionCache;

	private static bool? _breakComboOnEarlyCache;

	private static bool? _soundOnJudgeBreakCache;

	private static float? _judgeBreakSoundVolumeCache;

	private static int? _deafenAtPercentageCache;

	private static bool? _showAvgInaccuracyCache;

	private static int? _renderFrameIntervalCache;

	private static bool? _showGhostsCache;

	private static bool? _showHighwayCache;

	private static bool? _showFretStringsCache;

	private static bool? _showHighwaySideCache;

	private static bool? _showBeatlinesCache;

	private static bool? _showHPBarCache;

	private static bool? _hideHPOnFailCache;

	private static string _songProgressColorCache;

	private static string _starProgressColorCache;

	private static string _noteStreakColorCache;

	private static string _scoreColorCache;

	private static string _starColorCache;

	private static string _scoreHUDColorCache;

	private static bool? _perFretFlameColorsCache;

	private static float? _colorIntensityCache;

	private static int? _inputViewerIndentCache;

	private static float? _highwaySpeedCache;

	public static string internalLogWebhook;

	public static string courteWebhook;

	private static char[] _char_strumColorCache;

	public enum JudgeLevel
	{
		Judge1 = 1,
		Judge2,
		Judge3,
		Judge4,
		Judge5,
		Judge6,
		Judge7,
		Judge8,
		Justice = -1,
		ITG = -2,
		DDR1 = -3,
		DDR2 = -4,
		Judge9 = 9,
		QuaverPeaceful = 11,
		QuaverLenient,
		QuaverChill,
		QuaverStandard,
		QuaverStrict,
		QuaverTough,
		QuaverExtreme,
		QuaverImpossible
	}

	public enum WeightSystem
	{
		Quaver = 2,
		Custom = 0,
		Etterna
	}
}
