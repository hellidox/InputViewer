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
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public static class GlobalHelper
{
	public static bool rainbowSPBar
	{
		get
		{
			if (GlobalHelper._rainbowSPBarCache != null)
			{
				return GlobalHelper._rainbowSPBarCache.Value;
			}
			GlobalHelper._rainbowSPBarCache = new bool?(GlobalHelper.ReadBool("rainbowSPBar"));
			return GlobalHelper._rainbowSPBarCache.Value;
		}
		set
		{
			GlobalHelper._rainbowSPBarCache = new bool?(value);
			GlobalHelper.WriteKeyValue("rainbowSPBar", value, false);
		}
	}

	public static bool rainbowFlames
	{
		get
		{
			if (GlobalHelper._rainbowFlamesCache != null)
			{
				return GlobalHelper._rainbowFlamesCache.Value;
			}
			GlobalHelper._rainbowFlamesCache = new bool?(GlobalHelper.ReadBool("rainbowFlames"));
			return GlobalHelper._rainbowFlamesCache.Value;
		}
		set
		{
			GlobalHelper._rainbowFlamesCache = new bool?(value);
			GlobalHelper.WriteKeyValue("rainbowFlames", value, false);
		}
	}

	public static float rainbowFlameSpeed
	{
		get
		{
			if (GlobalHelper._rainbowFlameSpeedCache != null)
			{
				return GlobalHelper._rainbowFlameSpeedCache.Value;
			}
			GlobalHelper._rainbowFlameSpeedCache = new float?(GlobalHelper.ReadFloat("rainbowFlameSpeed"));
			return GlobalHelper._rainbowFlameSpeedCache.Value;
		}
		set
		{
			GlobalHelper._rainbowFlameSpeedCache = new float?(value);
			GlobalHelper.WriteKeyValue("rainbowFlameSpeed", value, false);
		}
	}

	public static bool showInputViewer
	{
		get
		{
			if (GlobalHelper._showInputViewerCache != null)
			{
				return GlobalHelper._showInputViewerCache.Value;
			}
			GlobalHelper._showInputViewerCache = new bool?(GlobalHelper.ReadBool("showInputViewer"));
			return GlobalHelper._showInputViewerCache.Value;
		}
		set
		{
			GlobalHelper._showInputViewerCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showInputViewer", value, false);
		}
	}

	public static int inputViewerHz
	{
		get
		{
			if (GlobalHelper._inputViewerHzCache != null)
			{
				return GlobalHelper._inputViewerHzCache.Value;
			}
			GlobalHelper._inputViewerHzCache = new int?(GlobalHelper.ReadInt("inputViewerHz"));
			return GlobalHelper._inputViewerHzCache.Value;
		}
		set
		{
			GlobalHelper._inputViewerHzCache = new int?(value);
			GlobalHelper.WriteKeyValue("inputViewerHz", value, false);
		}
	}

	public static bool strikelineFPSFix
	{
		get
		{
			if (GlobalHelper._strikelineFPSFixCache != null)
			{
				return GlobalHelper._strikelineFPSFixCache.Value;
			}
			GlobalHelper._strikelineFPSFixCache = new bool?(GlobalHelper.ReadBool("strikelineFPSFix"));
			return GlobalHelper._strikelineFPSFixCache.Value;
		}
		set
		{
			GlobalHelper._strikelineFPSFixCache = new bool?(value);
			GlobalHelper.WriteKeyValue("strikelineFPSFix", value, false);
		}
	}

	public static bool showFPS
	{
		get
		{
			if (GlobalHelper._showFPSCache != null)
			{
				return GlobalHelper._showFPSCache.Value;
			}
			GlobalHelper._showFPSCache = new bool?(GlobalHelper.ReadBool("showFPS"));
			return GlobalHelper._showFPSCache.Value;
		}
		set
		{
			GlobalHelper._showFPSCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showFPS", value, false);
		}
	}

	public static float fontSize
	{
		get
		{
			if (GlobalHelper._fontSizeCache != null)
			{
				return GlobalHelper._fontSizeCache.Value;
			}
			GlobalHelper._fontSizeCache = new float?(GlobalHelper.ReadFloat("fontSize"));
			return GlobalHelper._fontSizeCache.Value;
		}
		set
		{
			GlobalHelper._fontSizeCache = new float?(value);
			GlobalHelper.WriteKeyValue("fontSize", value.ToString("F2"), false);
		}
	}

	static GlobalHelper()
	{
		GlobalHelper.rfi_setter(1);
		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
		GlobalHelper._char_greenFretColorCache = new char[1];
		GlobalHelper._char_redFretColorCache = new char[1];
		GlobalHelper._char_yellowFretColorCache = new char[1];
		GlobalHelper._char_blueFretColorCache = new char[1];
		GlobalHelper._char_orangeFretColorCache = new char[1];
		GlobalHelper.path = Path.Combine(Application.persistentDataPath, "IVsettings.txt");
		GlobalHelper.InitializeConfig(GlobalHelper.versionid != GlobalHelper.ReadInt("versionID"));
		GlobalHelper.version = "V2.0.9";
		GlobalHelper.InvalidateCache();
		GlobalHelper.internalLogWebhook = "https://discord.com/api/webhooks/1279779072762974302/fUIkbZNB_XHGIn-faRwy-s2nhI1DSY-z72Qwb3FAG_93mAVDODAlEZBJZw8ccm7vloaT";
		GlobalHelper.courteWebhook = "https://discord.com/api/webhooks/1287279052658573324/ms8Mhb877CNbL_zQC7Z6LYW1E4dIsSnS6AyWUEuaEG8rYS2ZVv_fkeJMCEBXTAI2O2Vq";
	}

	public static string ReadKeyValue(string key)
	{
		return GlobalHelper.ReadKeyValue(key, null);
	}

	public static bool ReadBool(string key)
	{
		bool flag;
		return bool.TryParse(GlobalHelper.ReadKeyValue(key), out flag) && flag;
	}

	private static float ReadFloat(string key)
	{
		float num;
		if (float.TryParse(GlobalHelper.ReadKeyValue(key), out num))
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
			if (int.TryParse(GlobalHelper.ReadKeyValue(key).Split(".", StringSplitOptions.None)[0], out num))
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
		GlobalHelper._useColorProfileCache = null;
		GlobalHelper._perFretFlameColorsCache = null;
		GlobalHelper._colorIntensityCache = null;
		GlobalHelper._songProgressColorCache = null;
		GlobalHelper._starProgressColorCache = null;
		GlobalHelper._noteStreakColorCache = null;
		GlobalHelper._scoreColorCache = null;
		GlobalHelper._scoreHUDColorCache = null;
		GlobalHelper._starColorCache = null;
		GlobalHelper._hideHPOnFailCache = null;
		GlobalHelper._fontSizeCache = null;
		GlobalHelper._showFPSCache = null;
		GlobalHelper._inputViewerHzCache = null;
		GlobalHelper._inputViewerIndentCache = null;
		GlobalHelper._renderFrameIntervalCache = null;
		GlobalHelper._useJudgeLevelCache = null;
		GlobalHelper._rainbowFlamesCache = null;
		GlobalHelper._rainbowFlameSpeedCache = null;
		GlobalHelper._highwaySpeedCache = null;
		GlobalHelper._colorIntensityCache = null;
		GlobalHelper._rainbowSPBarCache = null;
		GlobalHelper._showInputViewerCache = null;
		GlobalHelper._showGhostsCache = null;
		GlobalHelper._strikelineFPSFixCache = null;
		GlobalHelper._strikelinePistonSpeedCache = null;
		GlobalHelper._greenFretColorCache = null;
		GlobalHelper._redFretColorCache = null;
		GlobalHelper._yellowFretColorCache = null;
		GlobalHelper._blueFretColorCache = null;
		GlobalHelper._orangeFretColorCache = null;
		GlobalHelper._strumColorCache = null;
		GlobalHelper._showOverstrumsCache = null;
		GlobalHelper._showBeatlinesCache = null;
		GlobalHelper._showHighwayCache = null;
		GlobalHelper._showHPBarCache = null;
		GlobalHelper._showFretStringsCache = null;
		GlobalHelper._showHighwaySideCache = null;
		GlobalHelper._showAvgInaccuracyCache = null;
		GlobalHelper._showMissCounterCache = null;
		GlobalHelper._showClockCache = null;
		GlobalHelper._showSessionTimerCache = null;
		GlobalHelper._scorespyNoFailCache = null;
		GlobalHelper._showJudgementsUnderFretboardCache = null;
		GlobalHelper._hitWindowDisplaySizeCache = null;
		GlobalHelper._useJudgementsCache = null;
		GlobalHelper._weightSystemCache = null;
		GlobalHelper._breakComboOnEarlyCache = null;
		GlobalHelper._maximumImprecisionCache = null;
		GlobalHelper._judgeBreakSoundVolumeCache = null;
		GlobalHelper._soundOnJudgeBreakCache = null;
		GlobalHelper._deafenAtPercentageCache = null;
		GlobalHelper._char_greenFretColorCache = new char[1];
		GlobalHelper._char_redFretColorCache = new char[1];
		GlobalHelper._char_yellowFretColorCache = new char[1];
		GlobalHelper._char_blueFretColorCache = new char[1];
		GlobalHelper._char_orangeFretColorCache = new char[1];
		GlobalHelper._char_strumColorCache = new char[1];
		GlobalHelper.InitializeConfig(false);
	}

	public static void InitializeConfig(bool force = false)
	{
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "IVSettings.cmd");
		Debug.Log("caller " + new StackFrame(1).GetMethod().Name + " force " + force.ToString());
		if (force)
		{
			File.Delete(GlobalHelper.path);
		}
		File.WriteAllText(text, "\"" + GlobalHelper.path + "\"");
		if (!File.Exists(GlobalHelper.path))
		{
			GlobalHelper.WriteComment("and # start comments.");
			GlobalHelper.WriteComment("Alpha doesn't yet work in colors.");
			GlobalHelper.WriteComment("#000000 is a magic number to make most of these invisible.");
			GlobalHelper.WriteComment("#ffffff is a magic number to use the original color.");
			GlobalHelper.WriteComment("For white, use #fffffe. For black, use #000001.");
			GlobalHelper.songProgressColor = "#7d8cd8";
			GlobalHelper.starProgressColor = "#e4b159";
			GlobalHelper.noteStreakColor = "#ffffff";
			GlobalHelper.starColor = "#ffffff";
			GlobalHelper.scoreColor = "#ffffff";
			GlobalHelper.scoreHUDColor = "#ffffff";
			GlobalHelper.greenFretColor = "#00ff00";
			GlobalHelper.redFretColor = "#ff0000";
			GlobalHelper.yellowFretColor = "#ffff00";
			GlobalHelper.blueFretColor = "#2222ff";
			GlobalHelper.orangeFretColor = "#ffa500";
			GlobalHelper.strumColor = "#cc11cc";
			GlobalHelper.showClock = false;
			GlobalHelper.showInputViewer = true;
			GlobalHelper.showGhosts = true;
			GlobalHelper.showMissCounter = true;
			GlobalHelper.showOverstrums = true;
			GlobalHelper.showSessionTimer = false;
			GlobalHelper.inputViewerHz = 60;
			GlobalHelper.inputViewerIndent = 14;
			GlobalHelper.rainbowFlames = false;
			GlobalHelper.rainbowFlameSpeed = 1.5f;
			GlobalHelper.highwaySpeed = 1f;
			GlobalHelper.strikelinePistonSpeed = 1f;
			GlobalHelper.rainbowSPBar = false;
			GlobalHelper.strikelineFPSFix = true;
			GlobalHelper.fontSize = 0.9f;
			GlobalHelper.useColorProfile = true;
			GlobalHelper.WriteComment("Uses the colors above (...FretColor) for this.");
			GlobalHelper.perFretFlameColors = true;
			GlobalHelper.WriteComment("0 is default. 1 is maximum intensity (saturation) without washing out.");
			GlobalHelper.colorIntensity = 0f;
			GlobalHelper.showFPS = true;
			GlobalHelper.scorespyNoFail = true;
			GlobalHelper.useJudgements = true;
			GlobalHelper.showJudgementsUnderFretboard = true;
			GlobalHelper.WriteComment("1 (Etterna, default):");
			GlobalHelper.WriteComment("flawless: 1.1, perfect: 0.74, great: 0.36, good: 0, bad: -0.28, miss: -1.1f, early: -0.55f");
			GlobalHelper.WriteComment("0 (Custom, original): ");
			GlobalHelper.WriteComment("flawless: 1.1, perfect: 1, great: 0.5, good: 0.5, bad: 0.25, miss: 0, early: 0.125");
			GlobalHelper.WriteComment("2 (Quaver):");
			GlobalHelper.WriteComment("flawless: 1.1, perfect: 1.081, great: 0.72, good: 0.28, bad (okay): -0.55, miss: -1.1, early: -0.7");
			GlobalHelper.weightSystem = GlobalHelper.WeightSystem.Etterna;
			GlobalHelper.WriteComment("Available values: -1 for JUSTICE, -2 for In The Groove, -3 for DDR Arcade 1,");
			GlobalHelper.WriteComment("-4 for DDR Arcade 2, and 1-9 for StepMania/Etterna Judge 1-9.");
			GlobalHelper.WriteComment("11-18 for Quaver Peaceful-Impossible.");
			GlobalHelper.WriteComment("The Quaver default is 14 (standard)");
			GlobalHelper.WriteComment("Default is Judge 6. This is the Etterna default and");
			GlobalHelper.WriteComment(string.Format("gives a {0:0.0}ms window to hit flawless judgments.", GlobalHelper.judgeTimings(GlobalHelper.JudgeLevel.Judge6)[0] * 2000f));
			GlobalHelper.WriteComment("(for reference: Festival has a 50ms perfect window)");
			GlobalHelper.useJudgeLevel = GlobalHelper.JudgeLevel.Judge4;
			GlobalHelper.WriteComment("From 0-6: Flawless, Perfect, Great, Good, Bad, Early, Miss");
			GlobalHelper.WriteComment("If you hit a note outside of this window, it will count as a combo break (overstrum).");
			GlobalHelper.WriteComment("Set to 6 (default) to disable.");
			GlobalHelper.maximumImprecision = BasePlayer.Judgement.Miss;
			GlobalHelper.WriteComment("Enable this to make early judgements count as a combo break (overstrum).");
			GlobalHelper.breakComboOnEarly = false;
			GlobalHelper.WriteComment("Play a sound when you break combo due to being too imprecise");
			GlobalHelper.soundOnJudgeBreak = false;
			GlobalHelper.judgeBreakSoundVolume = 0.15f;
			GlobalHelper.WriteComment("This changes the visual (NOT the actual) hit window size to match the window of this judgement.");
			GlobalHelper.WriteComment("If the value is miss or early it just uses the default 140ms");
			GlobalHelper.hitWindowDisplaySize = BasePlayer.Judgement.Marvelous;
			GlobalHelper.showAvgInaccuracy = true;
			GlobalHelper.WriteComment("Presses scroll lock when you get to this percentage of the song without missing.");
			GlobalHelper.WriteComment("You have to bind this to deafen in discord to do anything.");
			GlobalHelper.WriteComment("Disabled at -1");
			GlobalHelper.deafenAtPercentage = -1;
			GlobalHelper.WriteComment("For usage with OBS transparency if you want");
			GlobalHelper.showHighway = true;
			GlobalHelper.showHighwaySide = true;
			GlobalHelper.showBeatlines = true;
			GlobalHelper.showFretStrings = true;
			GlobalHelper.showHPBar = true;
			GlobalHelper.hideHPOnFail = false;
			GlobalHelper.WriteComment("Don't touch this. ");
			GlobalHelper.WriteKeyValue("versionID", GlobalHelper.versionid, false);
			Process.Start(new ProcessStartInfo
			{
				FileName = text,
				CreateNoWindow = true,
				UseShellExecute = false
			});
			return;
		}
		GlobalHelper.scoreHUDColor = GlobalHelper.scoreHUDColor;
		GlobalHelper.scoreColor = GlobalHelper.scoreColor;
		GlobalHelper.noteStreakColor = GlobalHelper.noteStreakColor;
		GlobalHelper.starColor = GlobalHelper.starColor;
		GlobalHelper.starProgressColor = GlobalHelper.starProgressColor;
		GlobalHelper.songProgressColor = GlobalHelper.songProgressColor;
		GlobalHelper.greenFretColor = GlobalHelper.greenFretColor;
		GlobalHelper.redFretColor = GlobalHelper.redFretColor;
		GlobalHelper.yellowFretColor = GlobalHelper.yellowFretColor;
		GlobalHelper.blueFretColor = GlobalHelper.blueFretColor;
		GlobalHelper.orangeFretColor = GlobalHelper.orangeFretColor;
		GlobalHelper.strumColor = GlobalHelper.strumColor;
		GlobalHelper.showClock = GlobalHelper.showClock;
		GlobalHelper.showInputViewer = GlobalHelper.showInputViewer;
		GlobalHelper.showGhosts = GlobalHelper.showGhosts;
		GlobalHelper.showMissCounter = GlobalHelper.showMissCounter;
		GlobalHelper.showOverstrums = GlobalHelper.showOverstrums;
		GlobalHelper.showSessionTimer = GlobalHelper.showSessionTimer;
		GlobalHelper.inputViewerHz = GlobalHelper.inputViewerHz;
		GlobalHelper.inputViewerIndent = GlobalHelper.inputViewerIndent;
		GlobalHelper.rainbowFlames = GlobalHelper.rainbowFlames;
		GlobalHelper.rainbowFlameSpeed = GlobalHelper.rainbowFlameSpeed;
		GlobalHelper.highwaySpeed = GlobalHelper.highwaySpeed;
		GlobalHelper.rainbowSPBar = GlobalHelper.rainbowSPBar;
		GlobalHelper.strikelineFPSFix = GlobalHelper.strikelineFPSFix;
		GlobalHelper.fontSize = GlobalHelper.fontSize;
		GlobalHelper.useColorProfile = GlobalHelper.useColorProfile;
		GlobalHelper.perFretFlameColors = GlobalHelper.perFretFlameColors;
		GlobalHelper.showFPS = GlobalHelper.showFPS;
		GlobalHelper.scorespyNoFail = GlobalHelper.scorespyNoFail;
		GlobalHelper.useJudgements = GlobalHelper.useJudgements;
		GlobalHelper.showJudgementsUnderFretboard = GlobalHelper.showJudgementsUnderFretboard;
		GlobalHelper.weightSystem = GlobalHelper.WeightSystem.Etterna;
		GlobalHelper.useJudgeLevel = GlobalHelper.useJudgeLevel;
		GlobalHelper.hitWindowDisplaySize = GlobalHelper.hitWindowDisplaySize;
		GlobalHelper.maximumImprecision = GlobalHelper.maximumImprecision;
		GlobalHelper.soundOnJudgeBreak = GlobalHelper.soundOnJudgeBreak;
		GlobalHelper.judgeBreakSoundVolume = GlobalHelper.judgeBreakSoundVolume;
		GlobalHelper.breakComboOnEarly = GlobalHelper.breakComboOnEarly;
		GlobalHelper.deafenAtPercentage = GlobalHelper.deafenAtPercentage;
		GlobalHelper.showAvgInaccuracy = GlobalHelper.showAvgInaccuracy;
		GlobalHelper.showHighway = GlobalHelper.showHighway;
		GlobalHelper.showHighwaySide = GlobalHelper.showHighwaySide;
		GlobalHelper.showBeatlines = GlobalHelper.showBeatlines;
		GlobalHelper.showFretStrings = GlobalHelper.showFretStrings;
		GlobalHelper.showHPBar = GlobalHelper.showHPBar;
		GlobalHelper.hideHPOnFail = GlobalHelper.hideHPOnFail;
	}

	public static bool showMissCounter
	{
		get
		{
			if (GlobalHelper._showMissCounterCache != null)
			{
				return GlobalHelper._showMissCounterCache.Value;
			}
			GlobalHelper._showMissCounterCache = new bool?(GlobalHelper.ReadBool("showMissCounter"));
			return GlobalHelper._showMissCounterCache.Value;
		}
		set
		{
			GlobalHelper._showMissCounterCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showMissCounter", value, false);
		}
	}

	public static bool showOverstrums
	{
		get
		{
			if (GlobalHelper._showOverstrumsCache != null)
			{
				return GlobalHelper._showOverstrumsCache.Value;
			}
			GlobalHelper._showOverstrumsCache = new bool?(GlobalHelper.ReadBool("showOverstrums"));
			return GlobalHelper._showOverstrumsCache.Value;
		}
		set
		{
			GlobalHelper._showOverstrumsCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showOverstrums", value, false);
		}
	}

	public static bool showClock
	{
		get
		{
			if (GlobalHelper._showClockCache != null)
			{
				return GlobalHelper._showClockCache.Value;
			}
			GlobalHelper._showClockCache = new bool?(GlobalHelper.ReadBool("showClock"));
			return GlobalHelper._showClockCache.Value;
		}
		set
		{
			GlobalHelper._showClockCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showClock", value, false);
		}
	}

	public static bool showSessionTimer
	{
		get
		{
			if (GlobalHelper._showSessionTimerCache != null)
			{
				return GlobalHelper._showSessionTimerCache.Value;
			}
			GlobalHelper._showSessionTimerCache = new bool?(GlobalHelper.ReadBool("showSessionTimer"));
			return GlobalHelper._showSessionTimerCache.Value;
		}
		set
		{
			GlobalHelper._showSessionTimerCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showSessionTimer", value, false);
		}
	}

	public static string greenFretColor
	{
		get
		{
			if (GlobalHelper._greenFretColorCache != null)
			{
				return GlobalHelper._greenFretColorCache;
			}
			GlobalHelper._greenFretColorCache = GlobalHelper.ReadKeyValue("greenFretColor");
			return GlobalHelper._greenFretColorCache;
		}
		set
		{
			GlobalHelper._greenFretColorCache = value;
			GlobalHelper.WriteKeyValue("greenFretColor", value, false);
		}
	}

	public static string redFretColor
	{
		get
		{
			if (GlobalHelper._redFretColorCache != null)
			{
				return GlobalHelper._redFretColorCache;
			}
			GlobalHelper._redFretColorCache = GlobalHelper.ReadKeyValue("redFretColor");
			return GlobalHelper._redFretColorCache;
		}
		set
		{
			GlobalHelper._redFretColorCache = value;
			GlobalHelper.WriteKeyValue("redFretColor", value, false);
		}
	}

	public static string yellowFretColor
	{
		get
		{
			if (GlobalHelper._yellowFretColorCache != null)
			{
				return GlobalHelper._yellowFretColorCache;
			}
			GlobalHelper._yellowFretColorCache = GlobalHelper.ReadKeyValue("yellowFretColor");
			return GlobalHelper._yellowFretColorCache;
		}
		set
		{
			GlobalHelper._yellowFretColorCache = value;
			GlobalHelper.WriteKeyValue("yellowFretColor", value, false);
		}
	}

	public static string blueFretColor
	{
		get
		{
			if (GlobalHelper._blueFretColorCache != null)
			{
				return GlobalHelper._blueFretColorCache;
			}
			GlobalHelper._blueFretColorCache = GlobalHelper.ReadKeyValue("blueFretColor");
			return GlobalHelper._blueFretColorCache;
		}
		set
		{
			GlobalHelper._blueFretColorCache = value;
			GlobalHelper.WriteKeyValue("blueFretColor", value, false);
		}
	}

	public static string orangeFretColor
	{
		get
		{
			if (GlobalHelper._orangeFretColorCache != null)
			{
				return GlobalHelper._orangeFretColorCache;
			}
			GlobalHelper._orangeFretColorCache = GlobalHelper.ReadKeyValue("orangeFretColor");
			return GlobalHelper._orangeFretColorCache;
		}
		set
		{
			GlobalHelper._orangeFretColorCache = value;
			GlobalHelper.WriteKeyValue("orangeFretColor", value, false);
		}
	}

	public static string strumColor
	{
		get
		{
			if (GlobalHelper._strumColorCache != null)
			{
				return GlobalHelper._strumColorCache;
			}
			GlobalHelper._strumColorCache = GlobalHelper.ReadKeyValue("strumColor");
			return GlobalHelper._strumColorCache;
		}
		set
		{
			GlobalHelper._strumColorCache = value;
			GlobalHelper.WriteKeyValue("strumColor", value, false);
		}
	}

	public static bool showComboBreaks
	{
		get
		{
			if (GlobalHelper._showComboBreaksCache != null)
			{
				return GlobalHelper._showComboBreaksCache.Value;
			}
			GlobalHelper._showComboBreaksCache = new bool?(GlobalHelper.ReadBool("showComboBreaks"));
			return GlobalHelper._showComboBreaksCache.Value;
		}
		set
		{
			GlobalHelper._showComboBreaksCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showComboBreaks", value, false);
		}
	}

	public static bool useColorProfile
	{
		get
		{
			if (GlobalHelper._useColorProfileCache != null)
			{
				return GlobalHelper._useColorProfileCache.Value;
			}
			GlobalHelper._useColorProfileCache = new bool?(GlobalHelper.ReadBool("useColorProfile"));
			return GlobalHelper._useColorProfileCache.Value;
		}
		set
		{
			GlobalHelper._useColorProfileCache = new bool?(value);
			GlobalHelper.WriteKeyValue("useColorProfile", value, false);
		}
	}

	public static string version
	{
		get
		{
			return GlobalHelper.ReadKeyValue("version");
		}
		set
		{
			GlobalHelper.WriteKeyValue("version", value, false);
		}
	}

	public static string lastversion
	{
		get
		{
			return GlobalHelper.ReadKeyValue("lastversion");
		}
		set
		{
			GlobalHelper.WriteKeyValue("lastversion", value, false);
		}
	}

	public static bool scorespyNoFail
	{
		get
		{
			if (GlobalHelper._scorespyNoFailCache != null)
			{
				return GlobalHelper._scorespyNoFailCache.Value;
			}
			GlobalHelper._scorespyNoFailCache = new bool?(GlobalHelper.ReadBool("scorespyNoFail"));
			return GlobalHelper._scorespyNoFailCache.Value;
		}
		set
		{
			GlobalHelper._scorespyNoFailCache = new bool?(value);
			GlobalHelper.WriteKeyValue("scorespyNoFail", value, false);
		}
	}

	public static bool useJudgements
	{
		get
		{
			if (GlobalHelper._useJudgementsCache != null)
			{
				return GlobalHelper._useJudgementsCache.Value;
			}
			GlobalHelper._useJudgementsCache = new bool?(GlobalHelper.ReadBool("useJudgements"));
			return GlobalHelper._useJudgementsCache.Value;
		}
		set
		{
			GlobalHelper._useJudgementsCache = new bool?(value);
			GlobalHelper.WriteKeyValue("useJudgements", value, false);
		}
	}

	public static bool showJudgementsUnderFretboard
	{
		get
		{
			if (GlobalHelper._showJudgementsUnderFretboardCache != null)
			{
				return GlobalHelper._showJudgementsUnderFretboardCache.Value;
			}
			GlobalHelper._showJudgementsUnderFretboardCache = new bool?(GlobalHelper.ReadBool("showJudgementsUnderFretboard"));
			return GlobalHelper._showJudgementsUnderFretboardCache.Value;
		}
		set
		{
			GlobalHelper._showJudgementsUnderFretboardCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showJudgementsUnderFretboard", value, false);
		}
	}

	public static GlobalHelper.JudgeLevel useJudgeLevel
	{
		get
		{
			if (GlobalHelper._useJudgeLevelCache != null)
			{
				return (GlobalHelper.JudgeLevel)GlobalHelper._useJudgeLevelCache.Value;
			}
			GlobalHelper._useJudgeLevelCache = new int?(GlobalHelper.ReadInt("JudgeLevel"));
			return (GlobalHelper.JudgeLevel)GlobalHelper._useJudgeLevelCache.Value;
		}
		set
		{
			GlobalHelper._useJudgeLevelCache = new int?((int)value);
			GlobalHelper.WriteKeyValue("JudgeLevel", (int)value, false);
		}
	}

	public static float[] judgeTimings(GlobalHelper.JudgeLevel judgeLevel)
	{
		switch (judgeLevel)
		{
		case GlobalHelper.JudgeLevel.DDR2:
			return new float[] { 0.017f, 0.033f, 0.067f, 0.083f, 0.133f };
		case GlobalHelper.JudgeLevel.DDR1:
			return new float[] { 0.017f, 0.033f, 0.108f, 0.158f, 0.192f };
		case GlobalHelper.JudgeLevel.ITG:
			return new float[] { 0.022f, 0.043f, 0.102f, 0.135f, 0.18f };
		case GlobalHelper.JudgeLevel.Justice:
			return new float[] { 0.004f, 0.009f, 0.018f, 0.027f, 0.036f };
		case GlobalHelper.JudgeLevel.Judge1:
			return new float[] { 0.033f, 0.068f, 0.135f, 0.203f, 0.27f };
		case GlobalHelper.JudgeLevel.Judge2:
			return new float[] { 0.029f, 0.06f, 0.12f, 0.18f, 0.239f };
		case GlobalHelper.JudgeLevel.Judge3:
			return new float[] { 0.026f, 0.052f, 0.104f, 0.157f, 0.209f };
		case GlobalHelper.JudgeLevel.Judge4:
			return new float[] { 0.022f, 0.045f, 0.09f, 0.135f, 0.18f };
		case GlobalHelper.JudgeLevel.Judge5:
			return new float[] { 0.018f, 0.038f, 0.076f, 0.113f, 0.151f };
		case GlobalHelper.JudgeLevel.Judge6:
			return new float[] { 0.015f, 0.03f, 0.059f, 0.089f, 0.119f };
		case GlobalHelper.JudgeLevel.Judge7:
			return new float[] { 0.011f, 0.022f, 0.045f, 0.067f, 0.089f };
		case GlobalHelper.JudgeLevel.Judge8:
			return new float[] { 0.007f, 0.015f, 0.03f, 0.045f, 0.059f };
		case GlobalHelper.JudgeLevel.QuaverPeaceful:
			return new float[] { 0.023f, 0.057f, 0.101f, 0.141f, 0.169f };
		case GlobalHelper.JudgeLevel.QuaverLenient:
			return new float[] { 0.021f, 0.052f, 0.091f, 0.128f, 0.153f };
		case GlobalHelper.JudgeLevel.QuaverChill:
			return new float[] { 0.019f, 0.047f, 0.083f, 0.116f, 0.139f };
		case GlobalHelper.JudgeLevel.QuaverStandard:
			return new float[] { 0.018f, 0.043f, 0.076f, 0.106f, 0.127f };
		case GlobalHelper.JudgeLevel.QuaverStrict:
			return new float[] { 0.016f, 0.039f, 0.069f, 0.096f, 0.127f };
		case GlobalHelper.JudgeLevel.QuaverTough:
			return new float[] { 0.014f, 0.035f, 0.062f, 0.087f, 0.127f };
		case GlobalHelper.JudgeLevel.QuaverExtreme:
			return new float[] { 0.013f, 0.032f, 0.057f, 0.079f, 0.127f };
		case GlobalHelper.JudgeLevel.QuaverImpossible:
			return new float[] { 0.008f, 0.02f, 0.035f, 0.049f, 0.127f };
		}
		return new float[] { 0.05f, 0.05f, 0.05f, 0.05f, 0.05f };
	}

	public static void WriteComment(string comment)
	{
		GlobalHelper.WriteKeyValue("; " + comment, null, true);
	}

	public static void WriteKeyValue(string key, object value, bool comment = false)
	{
		GlobalHelper.WriteKeyValue(key, value, comment, null);
	}

	public static float judgementHitWindowSize
	{
		get
		{
			float[] array = GlobalHelper.judgeTimings(GlobalHelper.useJudgeLevel);
			int hitWindowDisplaySize = (int)GlobalHelper.hitWindowDisplaySize;
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
			if (GlobalHelper._hitWindowDisplaySizeCache != null)
			{
				return (BasePlayer.Judgement)GlobalHelper._hitWindowDisplaySizeCache.Value;
			}
			GlobalHelper._hitWindowDisplaySizeCache = new int?(GlobalHelper.ReadInt("hitWindowDisplaySize"));
			return (BasePlayer.Judgement)GlobalHelper._hitWindowDisplaySizeCache.Value;
		}
		set
		{
			GlobalHelper._hitWindowDisplaySizeCache = new int?((int)value);
			GlobalHelper.WriteKeyValue("hitWindowDisplaySize", (int)value, false);
		}
	}

	public static float strikelinePistonSpeed
	{
		get
		{
			if (GlobalHelper._strikelinePistonSpeedCache != null)
			{
				return GlobalHelper._strikelinePistonSpeedCache.Value;
			}
			GlobalHelper._strikelinePistonSpeedCache = new float?(GlobalHelper.ReadFloat("strikelinePistonSpeed"));
			return GlobalHelper._strikelinePistonSpeedCache.Value;
		}
		set
		{
			GlobalHelper._strikelinePistonSpeedCache = new float?(value);
			GlobalHelper.WriteKeyValue("strikelinePistonSpeed", value, false);
		}
	}

	public static GlobalHelper.WeightSystem weightSystem
	{
		get
		{
			if (GlobalHelper._weightSystemCache != null)
			{
				return (GlobalHelper.WeightSystem)GlobalHelper._weightSystemCache.Value;
			}
			GlobalHelper._weightSystemCache = new int?(GlobalHelper.ReadInt("WeightSystem"));
			return (GlobalHelper.WeightSystem)GlobalHelper._weightSystemCache.Value;
		}
		set
		{
			GlobalHelper._weightSystemCache = new int?((int)value);
			GlobalHelper.WriteKeyValue("WeightSystem", (int)value, false);
		}
	}

	public static char[] char_greenFretColor
	{
		get
		{
			if (GlobalHelper._char_greenFretColorCache[0] != '\0')
			{
				return GlobalHelper._char_greenFretColorCache;
			}
			GlobalHelper._char_greenFretColorCache = GlobalHelper.ReadKeyValue("greenFretColor").ToCharArray();
			return GlobalHelper._char_greenFretColorCache;
		}
	}

	public static char[] char_redFretColor
	{
		get
		{
			if (GlobalHelper._char_redFretColorCache[0] != '\0')
			{
				return GlobalHelper._char_redFretColorCache;
			}
			GlobalHelper._char_redFretColorCache = GlobalHelper.ReadKeyValue("redFretColor").ToCharArray();
			return GlobalHelper._char_redFretColorCache;
		}
	}

	public static char[] char_yellowFretColor
	{
		get
		{
			if (GlobalHelper._char_yellowFretColorCache[0] != '\0')
			{
				return GlobalHelper._char_yellowFretColorCache;
			}
			GlobalHelper._char_yellowFretColorCache = GlobalHelper.ReadKeyValue("yellowFretColor").ToCharArray();
			return GlobalHelper._char_yellowFretColorCache;
		}
	}

	public static char[] char_blueFretColor
	{
		get
		{
			if (GlobalHelper._char_blueFretColorCache[0] != '\0')
			{
				return GlobalHelper._char_blueFretColorCache;
			}
			GlobalHelper._char_blueFretColorCache = GlobalHelper.ReadKeyValue("blueFretColor").ToCharArray();
			return GlobalHelper._char_blueFretColorCache;
		}
	}

	public static char[] char_orangeFretColor
	{
		get
		{
			if (GlobalHelper._char_orangeFretColorCache[0] != '\0')
			{
				return GlobalHelper._char_orangeFretColorCache;
			}
			GlobalHelper._char_orangeFretColorCache = GlobalHelper.ReadKeyValue("orangeFretColor").ToCharArray();
			return GlobalHelper._char_orangeFretColorCache;
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
			if (GlobalHelper._breakComboOnEarlyCache != null)
			{
				return GlobalHelper._breakComboOnEarlyCache.Value;
			}
			GlobalHelper._breakComboOnEarlyCache = new bool?(GlobalHelper.ReadBool("breakComboOnEarly"));
			return GlobalHelper._breakComboOnEarlyCache.Value;
		}
		set
		{
			GlobalHelper._breakComboOnEarlyCache = new bool?(value);
			GlobalHelper.WriteKeyValue("breakComboOnEarly", value, false);
		}
	}

	public static BasePlayer.Judgement maximumImprecision
	{
		get
		{
			if (GlobalHelper._maximumImprecisionCache != null)
			{
				return (BasePlayer.Judgement)GlobalHelper._maximumImprecisionCache.Value;
			}
			GlobalHelper._maximumImprecisionCache = new int?(GlobalHelper.ReadInt("maximumImprecision"));
			return (BasePlayer.Judgement)GlobalHelper._maximumImprecisionCache.Value;
		}
		set
		{
			GlobalHelper._maximumImprecisionCache = new int?((int)value);
			GlobalHelper.WriteKeyValue("maximumImprecision", (int)value, false);
		}
	}

	public static bool soundOnJudgeBreak
	{
		get
		{
			if (GlobalHelper._soundOnJudgeBreakCache != null)
			{
				return GlobalHelper._soundOnJudgeBreakCache.Value;
			}
			GlobalHelper._soundOnJudgeBreakCache = new bool?(GlobalHelper.ReadBool("soundOnJudgeBreak"));
			return GlobalHelper._soundOnJudgeBreakCache.Value;
		}
		set
		{
			GlobalHelper._soundOnJudgeBreakCache = new bool?(value);
			GlobalHelper.WriteKeyValue("soundOnJudgeBreak", value, false);
		}
	}

	public static float judgeBreakSoundVolume
	{
		get
		{
			if (GlobalHelper._judgeBreakSoundVolumeCache != null)
			{
				return GlobalHelper._judgeBreakSoundVolumeCache.Value;
			}
			GlobalHelper._judgeBreakSoundVolumeCache = new float?(GlobalHelper.ReadFloat("judgeBreakSoundVolume"));
			return GlobalHelper._judgeBreakSoundVolumeCache.Value;
		}
		set
		{
			GlobalHelper._judgeBreakSoundVolumeCache = new float?(value);
			GlobalHelper.WriteKeyValue("judgeBreakSoundVolume", value, false);
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
			if (GlobalHelper._deafenAtPercentageCache != null)
			{
				return GlobalHelper._deafenAtPercentageCache.Value;
			}
			GlobalHelper._deafenAtPercentageCache = new int?(GlobalHelper.ReadInt("deafenAtPercentage"));
			return GlobalHelper._deafenAtPercentageCache.Value;
		}
		set
		{
			GlobalHelper._deafenAtPercentageCache = new int?(value);
			GlobalHelper.WriteKeyValue("deafenAtPercentage", value, false);
		}
	}

	public static bool showAvgInaccuracy
	{
		get
		{
			if (GlobalHelper._showAvgInaccuracyCache != null)
			{
				return GlobalHelper._showAvgInaccuracyCache.Value;
			}
			GlobalHelper._showAvgInaccuracyCache = new bool?(GlobalHelper.ReadBool("showAvgInaccuracy"));
			return GlobalHelper._showAvgInaccuracyCache.Value;
		}
		set
		{
			GlobalHelper._showAvgInaccuracyCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showAvgInaccuracy", value, false);
		}
	}

	public static string uid
	{
		set
		{
			GlobalHelper.WriteKeyValue("uid", value, false);
		}
	}

	public static bool showGhosts
	{
		get
		{
			if (GlobalHelper._showGhostsCache != null)
			{
				return GlobalHelper._showGhostsCache.Value;
			}
			GlobalHelper._showGhostsCache = new bool?(GlobalHelper.ReadBool("showGhosts"));
			return GlobalHelper._showGhostsCache.Value;
		}
		set
		{
			GlobalHelper._showGhostsCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showGhosts", value, false);
		}
	}

	public static bool showHighway
	{
		get
		{
			if (GlobalHelper._showHighwayCache != null)
			{
				return GlobalHelper._showHighwayCache.Value;
			}
			GlobalHelper._showHighwayCache = new bool?(GlobalHelper.ReadBool("showHighway"));
			return GlobalHelper._showHighwayCache.Value;
		}
		set
		{
			GlobalHelper._showHighwayCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showHighway", value, false);
		}
	}

	public static bool showFretStrings
	{
		get
		{
			if (GlobalHelper._showFretStringsCache != null)
			{
				return GlobalHelper._showFretStringsCache.Value;
			}
			GlobalHelper._showFretStringsCache = new bool?(GlobalHelper.ReadBool("showFretStrings"));
			return GlobalHelper._showFretStringsCache.Value;
		}
		set
		{
			GlobalHelper._showFretStringsCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showFretStrings", value, false);
		}
	}

	public static bool showHighwaySide
	{
		get
		{
			if (GlobalHelper._showHighwaySideCache != null)
			{
				return GlobalHelper._showHighwaySideCache.Value;
			}
			GlobalHelper._showHighwaySideCache = new bool?(GlobalHelper.ReadBool("showHighwaySide"));
			return GlobalHelper._showHighwaySideCache.Value;
		}
		set
		{
			GlobalHelper._showHighwaySideCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showHighwaySide", value, false);
		}
	}

	public static bool showBeatlines
	{
		get
		{
			if (GlobalHelper._showBeatlinesCache != null)
			{
				return GlobalHelper._showBeatlinesCache.Value;
			}
			GlobalHelper._showBeatlinesCache = new bool?(GlobalHelper.ReadBool("showBeatlines"));
			return GlobalHelper._showBeatlinesCache.Value;
		}
		set
		{
			GlobalHelper._showBeatlinesCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showBeatlines", value, false);
		}
	}

	public static bool showHPBar
	{
		get
		{
			if (GlobalHelper._showHPBarCache != null)
			{
				return GlobalHelper._showHPBarCache.Value;
			}
			GlobalHelper._showHPBarCache = new bool?(GlobalHelper.ReadBool("showHPBar"));
			return GlobalHelper._showHPBarCache.Value;
		}
		set
		{
			GlobalHelper._showHPBarCache = new bool?(value);
			GlobalHelper.WriteKeyValue("showHPBar", value, false);
		}
	}

	public static bool hideHPOnFail
	{
		get
		{
			if (GlobalHelper._hideHPOnFailCache != null)
			{
				return GlobalHelper._hideHPOnFailCache.Value;
			}
			GlobalHelper._hideHPOnFailCache = new bool?(GlobalHelper.ReadBool("hideHPOnFail"));
			return GlobalHelper._hideHPOnFailCache.Value;
		}
		set
		{
			GlobalHelper._hideHPOnFailCache = new bool?(value);
			GlobalHelper.WriteKeyValue("hideHPOnFail", value, false);
		}
	}

	[DllImport("user32.dll")]
	private static extern uint MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

	public static void ShowMessage(string contents, string title = "", uint type = 0U)
	{
		Task.Run(delegate
		{
			GlobalHelper.MessageBox(IntPtr.Zero, contents, title, type);
		});
	}

	public static string songProgressColor
	{
		get
		{
			if (GlobalHelper._songProgressColorCache != null)
			{
				return GlobalHelper._songProgressColorCache;
			}
			GlobalHelper._songProgressColorCache = GlobalHelper.ReadKeyValue("songProgressColor");
			return GlobalHelper._songProgressColorCache;
		}
		set
		{
			GlobalHelper._songProgressColorCache = value;
			GlobalHelper.WriteKeyValue("songProgressColor", value, false);
		}
	}

	public static string starProgressColor
	{
		get
		{
			if (GlobalHelper._starProgressColorCache != null)
			{
				return GlobalHelper._starProgressColorCache;
			}
			GlobalHelper._starProgressColorCache = GlobalHelper.ReadKeyValue("starProgressColor");
			return GlobalHelper._starProgressColorCache;
		}
		set
		{
			GlobalHelper._starProgressColorCache = value;
			GlobalHelper.WriteKeyValue("starProgressColor", value, false);
		}
	}

	public static string noteStreakColor
	{
		get
		{
			if (GlobalHelper._noteStreakColorCache != null)
			{
				return GlobalHelper._noteStreakColorCache;
			}
			GlobalHelper._noteStreakColorCache = GlobalHelper.ReadKeyValue("noteStreakColor");
			return GlobalHelper._noteStreakColorCache;
		}
		set
		{
			GlobalHelper._noteStreakColorCache = value;
			GlobalHelper.WriteKeyValue("noteStreakColor", value, false);
		}
	}

	public static string scoreColor
	{
		get
		{
			if (GlobalHelper._scoreColorCache != null)
			{
				return GlobalHelper._scoreColorCache;
			}
			GlobalHelper._scoreColorCache = GlobalHelper.ReadKeyValue("scoreColor");
			return GlobalHelper._scoreColorCache;
		}
		set
		{
			GlobalHelper._scoreColorCache = value;
			GlobalHelper.WriteKeyValue("scoreColor", value, false);
		}
	}

	public static string starColor
	{
		get
		{
			if (GlobalHelper._starColorCache != null)
			{
				return GlobalHelper._starColorCache;
			}
			GlobalHelper._starColorCache = GlobalHelper.ReadKeyValue("starColor");
			return GlobalHelper._starColorCache;
		}
		set
		{
			GlobalHelper._starColorCache = value;
			GlobalHelper.WriteKeyValue("starColor", value, false);
		}
	}

	public static string scoreHUDColor
	{
		get
		{
			if (GlobalHelper._scoreHUDColorCache != null)
			{
				return GlobalHelper._scoreHUDColorCache;
			}
			GlobalHelper._scoreHUDColorCache = GlobalHelper.ReadKeyValue("scoreHUDColor");
			return GlobalHelper._scoreHUDColorCache;
		}
		set
		{
			GlobalHelper._scoreHUDColorCache = value;
			GlobalHelper.WriteKeyValue("scoreHUDColor", value, false);
		}
	}

	public static bool perFretFlameColors
	{
		get
		{
			if (GlobalHelper._perFretFlameColorsCache != null)
			{
				return GlobalHelper._perFretFlameColorsCache.Value;
			}
			GlobalHelper._perFretFlameColorsCache = new bool?(GlobalHelper.ReadBool("perFretFlameColors"));
			return GlobalHelper._perFretFlameColorsCache.Value;
		}
		set
		{
			GlobalHelper._perFretFlameColorsCache = new bool?(value);
			GlobalHelper.WriteKeyValue("perFretFlameColors", value, false);
		}
	}

	public static float colorIntensity
	{
		get
		{
			if (GlobalHelper._colorIntensityCache != null)
			{
				return GlobalHelper._colorIntensityCache.Value;
			}
			GlobalHelper._colorIntensityCache = new float?(GlobalHelper.ReadFloat("colorIntensity"));
			return GlobalHelper._colorIntensityCache.Value;
		}
		set
		{
			GlobalHelper._colorIntensityCache = new float?(value);
			GlobalHelper.WriteKeyValue("colorIntensity", value, false);
		}
	}

	public static void WriteKeyValue(string key, object value, bool comment = false, string configpath = null)
	{
		try
		{
			if (configpath == null)
			{
				configpath = GlobalHelper.path;
			}
			else
			{
				configpath = Path.Combine(Application.persistentDataPath, configpath);
			}
			if (!GlobalHelper.lockWrites)
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
			GlobalHelper.ShowMessage("Caught a weird error that I can't figure out. Restart the game.", "", 0U);
			Application.Quit(1);
		}
	}

	public static void WriteComment(string comment, string configpath = null)
	{
		GlobalHelper.WriteKeyValue("; " + comment, null, true, configpath);
	}

	public static string ReadKeyValue(string key, string configpath = null)
	{
		if (configpath == null)
		{
			configpath = GlobalHelper.path;
		}
		else
		{
			configpath = Path.Combine(Application.persistentDataPath, configpath);
		}
		if (!File.Exists(configpath))
		{
			return null;
		}
		string text = "\n";
		if (File.ReadAllText(configpath).Contains("\r\n"))
		{
			text = "\r\n";
		}
		foreach (string text2 in File.ReadAllText(configpath).Split(new string[] { text }, StringSplitOptions.RemoveEmptyEntries))
		{
			if (!text2.StartsWith("#") && !text2.StartsWith(";"))
			{
				string[] array2 = text2.Split(':', StringSplitOptions.None);
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
			if (GlobalHelper._inputViewerIndentCache != null)
			{
				return GlobalHelper._inputViewerIndentCache.Value;
			}
			GlobalHelper._inputViewerIndentCache = new int?(GlobalHelper.ReadInt("inputViewerIndent"));
			return GlobalHelper._inputViewerIndentCache.Value;
		}
		set
		{
			GlobalHelper._inputViewerIndentCache = new int?(value);
			GlobalHelper.WriteKeyValue("inputViewerIndent", value, false);
		}
	}

	public static float highwaySpeed
	{
		get
		{
			if (GlobalHelper._highwaySpeedCache != null)
			{
				return GlobalHelper._highwaySpeedCache.Value;
			}
			GlobalHelper._highwaySpeedCache = new float?(GlobalHelper.ReadFloat("highwaySpeed"));
			return GlobalHelper._highwaySpeedCache.Value;
		}
		set
		{
			GlobalHelper._highwaySpeedCache = new float?(value);
			GlobalHelper.WriteKeyValue("highwaySpeed", value, false);
		}
	}

	public static char[] char_strumColor
	{
		get
		{
			if (GlobalHelper._char_strumColorCache[0] != '\0')
			{
				return GlobalHelper._char_strumColorCache;
			}
			GlobalHelper._char_strumColorCache = GlobalHelper.ReadKeyValue("strumColor").ToCharArray();
			return GlobalHelper._char_strumColorCache;
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
			if (GlobalHelper.GetOpenFileName(intPtr))
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

	public static int renderFrameInterval
	{
		get
		{
			return GlobalHelper.m_rfi;
		}
		set
		{
			if (value < 1)
			{
				throw new ArgumentOutOfRangeException("value", value, "Render interval cannot be less than or equal to zero");
			}
			GlobalVariables.framereset = 0f;
			GlobalHelper.rfi_setter(value);
			GlobalHelper.m_rfi = value;
		}
	}

	public static bool willCurrentFrameRender
	{
		get
		{
			return Time.frameCount % GlobalHelper.renderFrameInterval == 0;
		}
	}

	public static Vector3[] FindFrustumCornersAtDistance(Camera camera, float n)
	{
		Vector3[] array = new Vector3[4];
		Vector2[] array2 = new Vector2[]
		{
			new Vector2(0f, 0f),
			new Vector2(0f, (float)Screen.height),
			new Vector2((float)Screen.width, (float)Screen.height),
			new Vector2((float)Screen.width, 0f)
		};
		for (int i = 0; i < 4; i++)
		{
			array[i] = GlobalHelper.FindWorldPositionAtDistance(camera, array2[i], n);
		}
		return array;
	}

	private static Vector3 FindWorldPositionAtDistance(Camera camera, Vector2 screenPoint, float n)
	{
		float num = camera.nearClipPlane;
		float num2 = camera.farClipPlane;
		Vector3 direction = camera.ScreenPointToRay(screenPoint).direction;
		while (num2 - num > 0.001f)
		{
			float num3 = (num + num2) / 2f;
			if (Vector3.Dot(camera.transform.position + direction * num3 - camera.transform.position, camera.transform.forward) < n)
			{
				num = num3;
			}
			else
			{
				num2 = num3;
			}
		}
		return camera.transform.position + direction * num;
	}

	public static TextMeshPro dupTMP(TextMeshPro orig)
	{
		if (orig == null)
		{
			throw new NullReferenceException("Null TextMeshPro");
		}
		GameObject gameObject = new GameObject("dup");
		gameObject.transform.SetParent(orig.transform.parent, false);
		TextMeshPro textMeshPro = gameObject.AddComponent<TextMeshPro>();
		textMeshPro.material = orig.material;
		textMeshPro.text = orig.text;
		textMeshPro.font = orig.font;
		textMeshPro.fontSize = orig.fontSize;
		textMeshPro.color = orig.color;
		textMeshPro.alignment = orig.alignment;
		textMeshPro.raycastTarget = orig.raycastTarget;
		RectTransform component = orig.GetComponent<RectTransform>();
		RectTransform component2 = textMeshPro.GetComponent<RectTransform>();
		component2.sizeDelta = component.sizeDelta;
		component2.localPosition = component.localPosition;
		component2.localScale = component.localScale;
		return textMeshPro;
	}

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

	private static Action<int> rfi_setter = FastInvoke.BuildStaticUntypedSetter<int>(typeof(OnDemandRendering).GetField("m_RenderFrameInterval", BindingFlags.Static | BindingFlags.NonPublic));

	private static int m_rfi;

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
