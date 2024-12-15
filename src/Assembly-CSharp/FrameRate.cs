using System;
using System.Linq;
using System.Runtime.InteropServices;
using Cysharp.Text;
using TMPro;
using UnityEngine;

public class FrameRate : MonoBehaviour
{
	private void \u02BC\u02BC\u02B3\u02B2\u02C0\u02B6\u02B8\u02BA\u02BD\u02B9\u02B6()
	{
		this.textDisplay = base.GetComponent<TextMeshProUGUI>();
		this.timer1 = this.const1;
	}

	private void Start()
	{
		this.targetSPF = 1f / (float)Screen.currentResolution.refreshRate;
		this.startTime = (double)Time.realtimeSinceStartup;
		BasePlayer.interval = 0.1f;
		GlobalHelper.InvalidateCache();
		GlobalHelper.renderFrameInterval = 10;
		this.startctr = 1;
		this.ofs = -1f;
		this.ticker = 2f;
		GlobalVariables.misses = 0;
		this.speedhackCheckNumber = -1;
		GC.Collect();
		bool useJudgements = GlobalHelper.useJudgements;
		this.textDisplay = base.GetComponent<TextMeshProUGUI>();
		this.timer1 = this.const1;
		this.textDisplay.fontSize *= 0.7f * GlobalHelper.fontSize;
		this.upperLeftTextBuilder = ZString.CreateStringBuilder();
		this.underHighwayTextBuilder = ZString.CreateStringBuilder();
	}

	public FrameRate()
	{
		this.const1 = 0.5f;
		this.counter1 = 60;
	}

	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		this.textDisplay = base.GetComponent<TextMeshProUGUI>();
		this.timer1 = this.const1;
	}

	private void Update()
	{
		this.vsyncTimer += Time.unscaledDeltaTime;
		if (this.startctr == -1)
		{
			if (this.speedhackCheckNumber == -1)
			{
				FrameRate.GetSystemTimePreciseAsFileTime(out this.ftStart);
				this.udtTotal = (double)(-(double)Time.unscaledDeltaTime);
				this.speedhackCheckNumber++;
			}
			this.udtTotal += (double)Time.unscaledDeltaTime;
			this.speedhackCheckNumber++;
			if (this.speedhackCheckNumber == 500)
			{
				this.speedhackCheckNumber = -1;
				FrameRate.GetSystemTimePreciseAsFileTime(out this.ftEnd);
				this.old_ftEnd = this.ftEnd;
				this.old_ftStart = this.ftStart;
				this.old_udtTotal = this.udtTotal;
				double num = (double)(this.ftEnd - this.ftStart) / 10000000.0;
				this.timeDifference = (float)(this.udtTotal / num);
			}
			if (this.vsyncTimer > this.targetSPF)
			{
				this.setRFI = false;
				this.vsyncTimer -= this.targetSPF;
				GlobalHelper.renderFrameInterval = 1;
				this.renderedFrames++;
			}
			else if (!this.setRFI)
			{
				this.setRFI = true;
				GlobalHelper.renderFrameInterval = 1000000;
			}
			this.timer4 += (((double)Time.timeScale > 0.01) ? Time.unscaledDeltaTime : 0f);
			if (this.timer4 > 1f)
			{
				this.timer4 -= 1f;
				GlobalVariables.playTime++;
			}
			this.ticker += Time.unscaledDeltaTime;
			if (this.ticker > 1f)
			{
				this.ctime = null;
				this.stime = null;
				this.ticker -= 1f;
				if (GlobalHelper.showClock)
				{
					this.ctime = DateTime.Now.ToString("hh:mm:ss tt");
				}
				if (GlobalHelper.showSessionTimer)
				{
					this.stime = TimeSpan.FromSeconds((double)((int)Time.realtimeSinceStartup) % TimeSpan.MaxValue.TotalSeconds).ToString("hh\\:mm\\:ss");
				}
			}
			if (Time.unscaledDeltaTime > this.worst)
			{
				this.worst = Time.unscaledDeltaTime;
			}
			if (Time.unscaledDeltaTime < this.best)
			{
				this.best = Time.unscaledDeltaTime;
			}
			if ((Time.frameCount & 512) > 0)
			{
				this.rr = 1f / (float)GlobalHelper.inputViewerHz;
			}
			this.ptimer -= Time.deltaTime;
			if (this.ptimer < 0f)
			{
				this.ptimer = this.rr;
				this.updateInputs = true;
			}
			else
			{
				this.updateInputs = false;
			}
			this.timer1 -= Time.unscaledDeltaTime;
			this.timer2 += 1f / Time.unscaledDeltaTime;
			this.counter1++;
			if (Input.GetKeyDown(KeyCode.RightShift))
			{
				BasePlayer.autoEnabled = !BasePlayer.autoEnabled;
			}
			if ((double)this.timer1 <= 0.0 && this.updateInputs)
			{
				this.textDisplay.enableWordWrapping = false;
				float num2 = this.timer2 / (float)this.counter1;
				this.best = 1f / this.best;
				string text;
				if (!GlobalHelper.showFPS)
				{
					text = "\n";
				}
				else
				{
					text = string.Format("{0:00000} FPS {1:0000} worst {3:00000} best {2:000} rendered {4:000.000000} game speed {5:0.0000} {6:0.0000}", new object[]
					{
						num2,
						1f / this.worst,
						Mathf.Min((float)Screen.currentResolution.refreshRate, num2),
						this.best,
						this.timeDifference * 100f,
						(double)(this.old_ftEnd - this.old_ftStart) / 1000.0 / 1000.0 / 10.0,
						this.old_udtTotal
					});
				}
				this.worst = float.NegativeInfinity;
				this.best = float.PositiveInfinity;
				this.textDisplay.text = text;
				this.orig = text;
				if (num2 < 30f)
				{
					this.textDisplay.color = Color.yellow;
				}
				else if (num2 < 10f)
				{
					this.textDisplay.color = Color.red;
				}
				else
				{
					this.textDisplay.color = Color.green;
				}
				this.timer1 = 0.36f;
				this.timer2 = 0f;
				this.rftimer = 0f;
				this.counter1 = 0;
				this.renderedFrames = 0;
				this.instance = BaseGuitarPlayer.instance;
			}
			this.timesince += Time.deltaTime;
			if (Input.GetKeyDown(KeyCode.Home))
			{
				if (Input.GetKey(KeyCode.LeftControl))
				{
					GlobalHelper.InitializeConfig(true);
				}
				GlobalHelper.InvalidateCache();
			}
			if (Input.GetKey(KeyCode.F3))
			{
				this.orig = "Keybinds\r\nF3     - Show binds\r\nF8     - Toggle rainbow flames\r\nShift+F8 - Toggle rainbow SP bar\r\nF9     - Slow down rainbow flames\r\nF10    - Speed up rainbow flames\r\nF11    - Shrink display font size\r\nF12    - Expand display font size\r\nECtrl-Del - Toggle FC mode\r\nHome   - Try to refresh the config (this won't always work just restart ur game lol)\r\nCtrl+Home - Regenerate the config";
			}
			if (Input.GetKey(KeyCode.F8))
			{
				if (Input.GetKeyDown(KeyCode.F8))
				{
					if (Input.GetKey(KeyCode.LeftShift))
					{
						GlobalHelper.rainbowSPBar = !GlobalHelper.rainbowSPBar;
					}
					else
					{
						GlobalHelper.rainbowFlames = !GlobalHelper.rainbowFlames;
					}
				}
				if (Input.GetKey(KeyCode.LeftShift))
				{
					this.orig = GlobalHelper.rainbowSPBar.ToString();
				}
				else
				{
					this.orig = GlobalHelper.rainbowFlames.ToString();
				}
			}
			if (Input.GetKey(KeyCode.F9))
			{
				GlobalHelper.rainbowFlameSpeed *= 1f - 0.35f * Time.unscaledDeltaTime;
				this.orig = GlobalHelper.rainbowFlameSpeed.ToString("F3");
			}
			if (Input.GetKey(KeyCode.F10))
			{
				GlobalHelper.rainbowFlameSpeed *= 1f + 0.35f * Time.unscaledDeltaTime;
				this.orig = GlobalHelper.rainbowFlameSpeed.ToString("F3");
			}
			if (Input.GetKeyDown(KeyCode.F11))
			{
				this.textDisplay.fontSize *= 0.95f;
				GlobalHelper.fontSize *= 0.95f;
			}
			if (Input.GetKeyDown(KeyCode.F12))
			{
				this.textDisplay.fontSize *= 1.05f;
				GlobalHelper.fontSize *= 1.05f;
			}
			if (this.instance != null && this.updateInputs)
			{
				this.combo = this.instance.combo;
				this.ghosts = this.instance.ghostCounter;
				this.os = this.instance.overstrums;
				this.misses = GlobalVariables.misses;
				if (this.combo < this.lcombo)
				{
					this.combobreaks++;
				}
				if (this.combo < this.lcombo && this.misses == this.lmisses && this.os == this.los)
				{
					this.instance.precision.Clear();
				}
				BaseGuitarPlayer.inputmap minputs = this.instance.minputs;
				this.upperLeftTextBuilder.Append("<color=#ff00ffaa>");
				this.upperLeftTextBuilder.Append(this.orig);
				this.upperLeftTextBuilder.AppendFormat<int>(" {0:000}%<color=#ffffffcc>\n", GlobalVariables.progress);
				if (GlobalHelper.showClock)
				{
					this.upperLeftTextBuilder.Append(this.ctime);
				}
				this.upperLeftTextBuilder.Append("\n");
				if (GlobalHelper.showSessionTimer)
				{
					this.upperLeftTextBuilder.Append(this.stime);
				}
				this.upperLeftTextBuilder.Append("\n");
				if (GlobalHelper.showOverstrums)
				{
					if (this.ostime > 0f)
					{
						this.upperLeftTextBuilder.Append("<color=#eeccffdd>");
					}
					if (this.os != 0)
					{
						this.upperLeftTextBuilder.Append<int>(this.os);
						this.upperLeftTextBuilder.Append(" overstrum");
						if (this.os != 1)
						{
							this.upperLeftTextBuilder.Append("s");
						}
						this.upperLeftTextBuilder.Append("\n");
					}
					else
					{
						this.upperLeftTextBuilder.Append("\n");
					}
				}
				else
				{
					this.upperLeftTextBuilder.Append("\n<color=#ffffffcc>");
				}
				if (GlobalHelper.showMissCounter)
				{
					if (this.gtime > 0f)
					{
						this.upperLeftTextBuilder.Append("<color=#eeccffdd>");
					}
					if (this.combobreaks != 0)
					{
						this.upperLeftTextBuilder.Append<int>(this.combobreaks);
						this.upperLeftTextBuilder.Append(" combo break");
						if (this.combobreaks != 1)
						{
							this.upperLeftTextBuilder.Append("s");
						}
						this.upperLeftTextBuilder.Append("\n");
					}
					else
					{
						this.upperLeftTextBuilder.Append("\n");
					}
				}
				else
				{
					this.upperLeftTextBuilder.Append("\n<color=#ffffffcc>");
				}
				if (GlobalHelper.showMissCounter)
				{
					if (this.gtime > 0f)
					{
						this.upperLeftTextBuilder.Append("<color=#eeccffdd>");
					}
					if (this.misses != 0)
					{
						this.upperLeftTextBuilder.Append<int>(this.misses);
						this.upperLeftTextBuilder.Append(" missed note");
						if (this.misses != 1)
						{
							this.upperLeftTextBuilder.Append("s");
						}
						this.upperLeftTextBuilder.Append("\n");
					}
					else
					{
						this.upperLeftTextBuilder.Append("\n");
					}
				}
				else
				{
					this.upperLeftTextBuilder.Append("\n");
				}
				if (GlobalHelper.showGhosts)
				{
					if (this.ghosts > 0)
					{
						this.upperLeftTextBuilder.Append<int>(this.ghosts);
						this.upperLeftTextBuilder.Append(" ghost");
						if (this.ghosts != 1)
						{
							this.upperLeftTextBuilder.Append("s");
						}
						this.upperLeftTextBuilder.Append("\n");
					}
					else
					{
						this.upperLeftTextBuilder.Append("\n");
					}
				}
				else
				{
					this.upperLeftTextBuilder.Append("\n");
				}
				if (GlobalHelper.useJudgements && GlobalHelper.showJudgementsUnderFretboard)
				{
					if (GlobalHelper.showAvgInaccuracy)
					{
						this.underHighwayTextBuilder.AppendFormat<float, float>("</i>{0:00.00}% - {1:00.00}ms\n", this.instance.precision.Accuracy * 100f, this.instance.precision.avgInaccuracy * 1000f);
						this.underHighwayTextBuilder.AppendFormat<float>("{0:00.00}", BasePlayer.lastOffset * 1000f);
					}
					else
					{
						this.underHighwayTextBuilder.AppendFormat<float, float>("</i>{0:00.00}%\n{1:00.00}ms\n", this.instance.precision.Accuracy * 100f, BasePlayer.lastOffset * 1000f);
					}
					switch (this.instance.precision.m_lastJudgement)
					{
					case BasePlayer.Judgement.Marvelous:
						this.underHighwayTextBuilder.Append("ms\n<color=#33ffff>Flawless!");
						break;
					case BasePlayer.Judgement.Perfect:
						this.underHighwayTextBuilder.Append("ms\n<color=yellow>Perfect!");
						break;
					case BasePlayer.Judgement.Great:
						this.underHighwayTextBuilder.Append("ms\n<color=#ff33ff>Great!");
						break;
					case BasePlayer.Judgement.Good:
						this.underHighwayTextBuilder.Append("ms\n<color=#22ff22>Good");
						break;
					case BasePlayer.Judgement.Bad:
						this.underHighwayTextBuilder.Append("ms\n<color=orange>Bad");
						break;
					case BasePlayer.Judgement.Early:
						this.underHighwayTextBuilder.Append("ms\nEarly");
						break;
					default:
						this.underHighwayTextBuilder.Append("ms\n<color=#aaaaaaaa>Miss");
						break;
					}
					this.instance.playerNameTextBox.SetCharArray(this.underHighwayTextBuilder.AsArraySegment().ToArray<char>());
					this.underHighwayTextBuilder.Clear();
				}
				if (GlobalHelper.showInputViewer)
				{
					this.upperLeftTextBuilder.AppendFormat<int>("<i><indent={0}em>", GlobalHelper.inputViewerIndent);
					if (minputs.su && minputs.sd)
					{
						this.upperLeftTextBuilder.Append("<color=#cc11cc>██");
					}
					else if (minputs.su && !minputs.sd)
					{
						this.upperLeftTextBuilder.Append("<color=#cc11cc>▀▀");
					}
					else if (!minputs.su && minputs.sd)
					{
						this.upperLeftTextBuilder.Append("<color=#cc11cc>▄▄");
					}
					else
					{
						this.upperLeftTextBuilder.Append("<color=#00000000>");
						this.upperLeftTextBuilder.Append("██");
					}
					if (minputs.g || this.lastg < minputs.gcount)
					{
						this.upperLeftTextBuilder.Append("<color=");
						this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_greenFretColor));
					}
					else
					{
						this.upperLeftTextBuilder.Append("<color=#00000000");
					}
					this.upperLeftTextBuilder.Append(">██");
					if (minputs.r || this.lastr < minputs.rcount)
					{
						this.upperLeftTextBuilder.Append("<color=");
						this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_redFretColor));
					}
					else
					{
						this.upperLeftTextBuilder.Append("<color=#00000000");
					}
					this.upperLeftTextBuilder.Append(">██");
					if (minputs.y || this.lasty < minputs.ycount)
					{
						this.upperLeftTextBuilder.Append("<color=");
						this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_yellowFretColor));
					}
					else
					{
						this.upperLeftTextBuilder.Append("<color=#00000000");
					}
					this.upperLeftTextBuilder.Append(">██");
					if (minputs.b || this.lastb < minputs.bcount)
					{
						this.upperLeftTextBuilder.Append("<color=");
						this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_blueFretColor));
					}
					else
					{
						this.upperLeftTextBuilder.Append("<color=#00000000");
					}
					this.upperLeftTextBuilder.Append(">██");
					if (minputs.o || this.lasto < minputs.ocount)
					{
						this.upperLeftTextBuilder.Append("<color=");
						this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_orangeFretColor));
					}
					else
					{
						this.upperLeftTextBuilder.Append("<color=#00000000");
					}
					this.lastg = minputs.gcount;
					this.lastr = minputs.rcount;
					this.lasty = minputs.ycount;
					this.lastb = minputs.bcount;
					this.lasto = minputs.ocount;
					this.upperLeftTextBuilder.Append(">██</i></indent>\n<color=");
					this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_greenFretColor));
					this.upperLeftTextBuilder.AppendFormat<int, float>(">{1:0.000} - {0:00000}\n<color=", minputs.gcount, minputs.gptime);
					this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_redFretColor));
					this.upperLeftTextBuilder.AppendFormat<int, float>(">{1:0.000} - {0:00000}\n<color=", minputs.rcount, minputs.rptime);
					this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_yellowFretColor));
					this.upperLeftTextBuilder.AppendFormat<int, float>(">{1:0.000} - {0:00000}\n<color=", minputs.ycount, minputs.yptime);
					this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_blueFretColor));
					this.upperLeftTextBuilder.AppendFormat<int, float>(">{1:0.000} - {0:00000}\n<color=", minputs.bcount, minputs.bptime);
					this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_orangeFretColor));
					this.upperLeftTextBuilder.AppendFormat<int, float>(">{1:0.000} - {0:00000}\n<color=", minputs.ocount, minputs.optime);
					this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_strumColor));
					this.upperLeftTextBuilder.AppendFormat<float, float>(">{0:0.000} - {1:0.000}\n", minputs.sutime, minputs.sdtime);
					this.upperLeftTextBuilder.AppendFormat<int, int>("{0:00000} - {1:00000}", minputs.sucount, minputs.sdcount);
				}
				if (GlobalVariables.FCmode)
				{
					this.upperLeftTextBuilder.Append("<color=#aaaaaa>FC mode <color=#ff2222FF>on<color=#ffffffcc>\n");
				}
				else
				{
					this.upperLeftTextBuilder.Append("\n");
				}
				this.textDisplay.SetCharArray(this.upperLeftTextBuilder.AsArraySegment().ToArray<char>());
				this.upperLeftTextBuilder.Clear();
				if (this.los == this.os)
				{
					this.ostime -= this.timesince;
				}
				else
				{
					this.ostime = 0.07f;
				}
				if (this.lmisses == this.misses && this.combobreaks == this.lcombobreaks)
				{
					this.gtime -= this.timesince;
				}
				else
				{
					this.gtime = 0.07f;
				}
				this.timesince = 0f;
			}
			if (Input.GetKeyDown(KeyCode.Delete) && Input.GetKey(KeyCode.LeftControl))
			{
				GlobalVariables.FCmode = !GlobalVariables.FCmode;
			}
			if (this.misses > 0 || this.os > 0)
			{
				if (GlobalVariables.FCmode)
				{
					GameAudioManager.PlaySound(SoundEffectsChannel.SongFail);
					if (Time.deltaTime == 1f)
					{
						GameManager.instance.\u02BE\u02BD\u02BD\u02B9\u02BD\u02BF\u02B3\u02BE\u02BD\u02BB\u02BC();
						GameManager.instance.\u02B6\u02B4\u02B8\u02B9\u02BC\u02B5\u02B8\u02B4\u02B3\u02BB\u02B6();
						GameManager.instance.\u02BF\u02B3\u02C1\u02B2\u02BA\u02B4\u02B8\u02BF\u02BD\u02C0\u02B8 = false;
					}
					else
					{
						this.instance.gameManager.EndSong();
					}
				}
				if (GlobalVariables.deafened)
				{
					GlobalVariables.deafened = false;
					GlobalHelper.ExecuteVBS("CreateObject(\"WScript.Shell\").SendKeys(\"{SCROLLLOCK}\")", "deafen");
				}
			}
			if (this.misses == 0 && this.os == 0 && this.combo > 0 && !GlobalVariables.deafened && GlobalHelper.deafenAtPercentage != -1 && GlobalVariables.progress >= GlobalHelper.deafenAtPercentage && GlobalVariables.progress != 100)
			{
				GlobalVariables.deafened = true;
				GlobalHelper.ExecuteVBS("CreateObject(\"WScript.Shell\").SendKeys(\"{SCROLLLOCK}\")", "deafen");
			}
			if (GlobalVariables.progress == 100 && GlobalVariables.deafened)
			{
				GlobalVariables.deafened = false;
				GlobalHelper.ExecuteVBS("CreateObject(\"WScript.Shell\").SendKeys(\"{SCROLLLOCK}\")", "deafen");
			}
			if (GlobalVariables.hasReset)
			{
				this.os = 0;
				this.ghosts = 0;
				this.combo = 0;
				GlobalVariables.misses = 0;
				this.misses = 0;
				this.combobreaks = 0;
				if (this._resetFlag)
				{
					GlobalVariables.hasReset = false;
					this._resetFlag = false;
				}
				this._resetFlag = true;
			}
			this.los = this.os;
			this.lghosts = this.ghosts;
			this.lcombo = this.combo;
			this.lmisses = this.misses;
			this.lcombobreaks = this.combobreaks;
			return;
		}
		if (this.startctr != 10)
		{
			int num3 = this.startctr;
			this.startctr = num3 + 1;
			Debug.Log(num3);
			return;
		}
		if (GlobalHelper.useJudgements)
		{
			BaseGuitarPlayer.instance.precision.Clear();
			BaseGuitarPlayer.instance.playerNameTextBox.fontSize *= 0.315f;
		}
		this.startctr = -1;
	}

	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		this.textDisplay = base.GetComponent<TextMeshProUGUI>();
		this.timer1 = this.const1;
	}

	public static bool checkIfSix(int a)
	{
		if (FrameRate.forceactivate)
		{
			FrameRate.forceactivate = false;
			return a == 6;
		}
		return false;
	}

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "memset")]
	private static extern IntPtr MemSet(IntPtr dest, int c, int count);

	private void OnDisable()
	{
		GlobalHelper.renderFrameInterval = 1;
	}

	private void OnDestroy()
	{
		this.OnDisable();
	}

	[DllImport("kernel32.dll")]
	public static extern void GetSystemTimePreciseAsFileTime(out long systemTimePreciseAsFileTime);

	public float const1;

	private float timer2;

	private int counter1;

	private float timer1;

	private TextMeshProUGUI textDisplay;

	private bool nine;

	private string orig;

	private float rr;

	private readonly string nl;

	private float ptimer;

	private bool updateInputs;

	private const string constwhite = "<color=white>";

	private BaseGuitarPlayer instance;

	private int misses;

	private int lastcombo;

	private int combo;

	private int os;

	private int los;

	private int ghosts;

	private int lghosts;

	private const string goodstrum = "cc11ccff";

	private const string badstrum = "ff2211ff";

	private float ostime;

	private float timesince;

	private float gtime;

	private int lmisses;

	private int lcombo;

	private float ticker;

	private string ctime;

	private string stime;

	private bool fcmode;

	public static bool forceactivate;

	public static bool enableInputs = true;

	private float worst;

	private int combobreaks;

	private int lcombobreaks;

	private TextAlignment textAlignment;

	private Vector3 textpos;

	private bool updateFaster;

	private bool _legacyBinds;

	private bool cleared;

	private Texture2D square;

	private Sprite squareSprite;

	private GUIStyle[] guiInputRenderers;

	private Color[] Textcolors;

	private Utf8ValueStringBuilder stringbuffer;

	private Utf16ValueStringBuilder upperLeftTextBuilder;

	private Utf16ValueStringBuilder underHighwayTextBuilder;

	private float ofs;

	private int startctr;

	private float timer4;

	private int cullingmask;

	private CameraClearFlags clearflags;

	private int rfi;

	private float best;

	private bool deafened;

	private int lastg;

	private int lastr;

	private int lasty;

	private int lastb;

	private int lasto;

	private bool _resetFlag;

	private double startTime;

	private TextMeshProUGUI spBarText;

	private int renderedFrames;

	private float targetSPF;

	private float vsyncTimer;

	private bool setRFI;

	private float rftimer;

	private SpriteRenderer[] squares;

	private bool checkingSpeedhack;

	private double udtTotal;

	private long ftStart;

	private long ftEnd;

	private int speedhackCheckNumber;

	private float timeDifference;

	private long old_ftEnd;

	private long old_ftStart;

	private double old_udtTotal;
}
