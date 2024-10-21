using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Text;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000043 RID: 67
public class FrameRate : MonoBehaviour
{
	// Token: 0x0600029E RID: 670 RVA: 0x000071B0 File Offset: 0x000053B0
	private void \u02BC\u02BC\u02B3\u02B2\u02C0\u02B6\u02B8\u02BA\u02BD\u02B9\u02B6()
	{
		this.textDisplay = base.GetComponent<TextMeshProUGUI>();
		this.timer1 = this.const1;
	}

	// Token: 0x0600029F RID: 671 RVA: 0x000265D8 File Offset: 0x000247D8
	private void Start()
	{
		this.startTime = (double)Time.realtimeSinceStartup;
		BasePlayer.interval = 0.1f;
		cUtilityClass.InvalidateCache();
		this.rfi = cUtilityClass.renderFrameInterval;
		typeof(OnDemandRendering).GetField("m_RenderFrameInterval", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, this.rfi);
		this.cullingmask = Camera.main.cullingMask;
		this.clearflags = Camera.main.clearFlags;
		this.startctr = 1;
		this.ofs = -1f;
		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
		this.ticker = 2f;
		GlobalVariables.misses = 0;
		GC.Collect();
		bool useJudgements = cUtilityClass.useJudgements;
		this.textDisplay = base.GetComponent<TextMeshProUGUI>();
		this.timer1 = this.const1;
		this.textDisplay.fontSize *= 0.7f * cUtilityClass.fontSize;
		this.upperLeftTextBuilder = ZString.CreateStringBuilder();
		this.underHighwayTextBuilder = ZString.CreateStringBuilder();
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x000071CA File Offset: 0x000053CA
	public FrameRate()
	{
		this.const1 = 0.5f;
		this.counter1 = 60;
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x000071B0 File Offset: 0x000053B0
	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		this.textDisplay = base.GetComponent<TextMeshProUGUI>();
		this.timer1 = this.const1;
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x000266DC File Offset: 0x000248DC
	private void Update()
	{
		if (this.startctr == -1)
		{
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
				if (cUtilityClass.showClock)
				{
					this.ctime = DateTime.Now.ToString("hh:mm:ss tt");
				}
				if (cUtilityClass.showSessionTimer)
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
			if ((Time.frameCount & 255) > 0)
			{
				this.rr = 1f / (float)cUtilityClass.inputViewerHz;
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
			this.timer2 += 1f / Time.smoothDeltaTime;
			this.counter1++;
			if (Input.GetKeyDown(KeyCode.RightShift))
			{
				BasePlayer.autoEnabled = !BasePlayer.autoEnabled;
			}
			if ((double)this.timer1 <= 0.0 && this.updateInputs)
			{
				this.textDisplay.enableWordWrapping = false;
				float num = this.timer2 / (float)this.counter1;
				this.best = 1f / this.best;
				string text;
				if (!cUtilityClass.showFPS)
				{
					text = "\n";
				}
				else
				{
					text = string.Format("{0:00000} FPS {1:0000} worst {3:00000} best {2:000} rendered", new object[]
					{
						num,
						1f / this.worst,
						num / (float)this.rfi,
						this.best
					});
				}
				this.worst = float.NegativeInfinity;
				this.best = float.PositiveInfinity;
				this.textDisplay.text = text;
				this.orig = text;
				if (num < 30f)
				{
					this.textDisplay.color = Color.yellow;
				}
				else if (num < 10f)
				{
					this.textDisplay.color = Color.red;
				}
				else
				{
					this.textDisplay.color = Color.green;
				}
				this.timer1 = 0.36f;
				this.timer2 = 0f;
				this.counter1 = 0;
				this.instance = BaseGuitarPlayer.instance;
			}
			this.timesince += Time.deltaTime;
			if (Input.GetKeyDown(KeyCode.Home))
			{
				if (Input.GetKey(KeyCode.LeftControl))
				{
					cUtilityClass.InitializeConfig(true);
				}
				cUtilityClass.InvalidateCache();
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
						cUtilityClass.rainbowSPBar = !cUtilityClass.rainbowSPBar;
					}
					else
					{
						cUtilityClass.rainbowFlames = !cUtilityClass.rainbowFlames;
					}
				}
				if (Input.GetKey(KeyCode.LeftShift))
				{
					this.orig = cUtilityClass.rainbowSPBar.ToString();
				}
				else
				{
					this.orig = cUtilityClass.rainbowFlames.ToString();
				}
			}
			if (Input.GetKey(KeyCode.F9))
			{
				cUtilityClass.rainbowFlameSpeed *= 1f - 0.35f * Time.unscaledDeltaTime;
				this.orig = cUtilityClass.rainbowFlameSpeed.ToString("F3");
			}
			if (Input.GetKey(KeyCode.F10))
			{
				cUtilityClass.rainbowFlameSpeed *= 1f + 0.35f * Time.unscaledDeltaTime;
				this.orig = cUtilityClass.rainbowFlameSpeed.ToString("F3");
			}
			if (Input.GetKeyDown(KeyCode.F11))
			{
				this.textDisplay.fontSize *= 0.95f;
				cUtilityClass.fontSize *= 0.95f;
			}
			if (Input.GetKeyDown(KeyCode.F12))
			{
				this.textDisplay.fontSize *= 1.05f;
				cUtilityClass.fontSize *= 1.05f;
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
				if (this._legacyBinds)
				{
					foreach (float num2 in cUtilityClass.judgeTimings(cUtilityClass.useJudgeLevel))
					{
						this.upperLeftTextBuilder.AppendFormat<float>("{0}ms\n", Mathf.Round(num2 * 2000f));
					}
				}
				if (cUtilityClass.showClock)
				{
					this.upperLeftTextBuilder.Append(this.ctime);
				}
				this.upperLeftTextBuilder.Append("\n");
				if (cUtilityClass.showSessionTimer)
				{
					this.upperLeftTextBuilder.Append(this.stime);
				}
				this.upperLeftTextBuilder.Append("\n");
				if (cUtilityClass.showOverstrums)
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
				if (cUtilityClass.showMissCounter)
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
				if (cUtilityClass.showMissCounter)
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
				if (cUtilityClass.showGhosts)
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
				if (cUtilityClass.useJudgements && cUtilityClass.showJudgementsUnderFretboard)
				{
					if (cUtilityClass.showAvgInaccuracy)
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
				if (cUtilityClass.showInputViewer)
				{
					this.upperLeftTextBuilder.AppendFormat<int>("<i><indent={0}em>", cUtilityClass.inputViewerIndent);
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
						this.upperLeftTextBuilder.Append("<color=#000000>");
						this.upperLeftTextBuilder.Append("██");
					}
					if (minputs.g || this.lastg < minputs.gcount)
					{
						this.upperLeftTextBuilder.Append("<color=");
						this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(cUtilityClass.char_greenFretColor));
					}
					else
					{
						this.upperLeftTextBuilder.Append("<color=#000000");
					}
					this.upperLeftTextBuilder.Append(">██");
					if (minputs.r || this.lastr < minputs.rcount)
					{
						this.upperLeftTextBuilder.Append("<color=");
						this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(cUtilityClass.char_redFretColor));
					}
					else
					{
						this.upperLeftTextBuilder.Append("<color=#000000");
					}
					this.upperLeftTextBuilder.Append(">██");
					if (minputs.y || this.lasty < minputs.ycount)
					{
						this.upperLeftTextBuilder.Append("<color=");
						this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(cUtilityClass.char_yellowFretColor));
					}
					else
					{
						this.upperLeftTextBuilder.Append("<color=#000000");
					}
					this.upperLeftTextBuilder.Append(">██");
					if (minputs.b || this.lastb < minputs.bcount)
					{
						this.upperLeftTextBuilder.Append("<color=");
						this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(cUtilityClass.char_blueFretColor));
					}
					else
					{
						this.upperLeftTextBuilder.Append("<color=#000000");
					}
					this.upperLeftTextBuilder.Append(">██");
					if (minputs.o || this.lasto < minputs.ocount)
					{
						this.upperLeftTextBuilder.Append("<color=");
						this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(cUtilityClass.char_orangeFretColor));
					}
					else
					{
						this.upperLeftTextBuilder.Append("<color=#000000");
					}
					this.lastg = minputs.gcount;
					this.lastr = minputs.rcount;
					this.lasty = minputs.ycount;
					this.lastb = minputs.bcount;
					this.lasto = minputs.ocount;
					this.upperLeftTextBuilder.Append(">██</i></indent>\n<color=");
					this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(cUtilityClass.char_greenFretColor));
					this.upperLeftTextBuilder.AppendFormat<int, float>(">{1:0.000} - {0:00000}\n<color=", minputs.gcount, minputs.gptime);
					this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(cUtilityClass.char_redFretColor));
					this.upperLeftTextBuilder.AppendFormat<int, float>(">{1:0.000} - {0:00000}\n<color=", minputs.rcount, minputs.rptime);
					this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(cUtilityClass.char_yellowFretColor));
					this.upperLeftTextBuilder.AppendFormat<int, float>(">{1:0.000} - {0:00000}\n<color=", minputs.ycount, minputs.yptime);
					this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(cUtilityClass.char_blueFretColor));
					this.upperLeftTextBuilder.AppendFormat<int, float>(">{1:0.000} - {0:00000}\n<color=", minputs.bcount, minputs.bptime);
					this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(cUtilityClass.char_orangeFretColor));
					this.upperLeftTextBuilder.AppendFormat<int, float>(">{1:0.000} - {0:00000}\n<color=", minputs.ocount, minputs.optime);
					this.upperLeftTextBuilder.Append(new ReadOnlySpan<char>(cUtilityClass.char_strumColor));
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
					GameAudioManager.PlaySound(SoundID.SongFail);
					if (Time.deltaTime == 1f)
					{
						GameManager.instance.\u02BE\u02BD\u02BD\u02B9\u02BD\u02BF\u02B3\u02BE\u02BD\u02BB\u02BC();
						GameManager.instance.\u02B6\u02B4\u02B8\u02B9\u02BC\u02B5\u02B8\u02B4\u02B3\u02BB\u02B6();
						GameManager.instance.\u02BF\u02B3\u02C1\u02B2\u02BA\u02B4\u02B8\u02BF\u02BD\u02C0\u02B8 = false;
					}
					else
					{
						this.instance._GameManager.EndSong();
					}
				}
				if (GlobalVariables.deafened)
				{
					GlobalVariables.deafened = false;
					cUtilityClass.ExecuteVBS("CreateObject(\"WScript.Shell\").SendKeys(\"{SCROLLLOCK}\")", "deafen");
				}
			}
			if (this.misses == 0 && this.os == 0 && this.combo > 0 && !GlobalVariables.deafened && cUtilityClass.deafenAtPercentage != -1 && GlobalVariables.progress >= cUtilityClass.deafenAtPercentage && GlobalVariables.progress != 100)
			{
				GlobalVariables.deafened = true;
				cUtilityClass.ExecuteVBS("CreateObject(\"WScript.Shell\").SendKeys(\"{SCROLLLOCK}\")", "deafen");
			}
			if (GlobalVariables.progress == 100 && GlobalVariables.deafened)
			{
				GlobalVariables.deafened = false;
				cUtilityClass.ExecuteVBS("CreateObject(\"WScript.Shell\").SendKeys(\"{SCROLLLOCK}\")", "deafen");
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
		if (cUtilityClass.useJudgements)
		{
			BaseGuitarPlayer.instance.precision.Clear();
			BaseGuitarPlayer.instance.playerNameTextBox.fontSize *= 0.315f;
		}
		this.startctr = -1;
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x000071B0 File Offset: 0x000053B0
	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		this.textDisplay = base.GetComponent<TextMeshProUGUI>();
		this.timer1 = this.const1;
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x000071E5 File Offset: 0x000053E5
	public static bool checkIfSix(int a)
	{
		if (FrameRate.forceactivate)
		{
			FrameRate.forceactivate = false;
			return a == 6;
		}
		return false;
	}

	// Token: 0x060002A6 RID: 678
	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "memset")]
	private static extern IntPtr MemSet(IntPtr dest, int c, int count);

	// Token: 0x04000187 RID: 391
	public float const1;

	// Token: 0x04000188 RID: 392
	private float timer2;

	// Token: 0x04000189 RID: 393
	private int counter1;

	// Token: 0x0400018A RID: 394
	private float timer1;

	// Token: 0x0400018B RID: 395
	private TextMeshProUGUI textDisplay;

	// Token: 0x0400018C RID: 396
	private bool nine;

	// Token: 0x0400018D RID: 397
	private string orig;

	// Token: 0x0400018E RID: 398
	private float rr;

	// Token: 0x0400018F RID: 399
	private readonly string nl;

	// Token: 0x04000190 RID: 400
	private float ptimer;

	// Token: 0x04000191 RID: 401
	private bool updateInputs;

	// Token: 0x04000192 RID: 402
	private const string constwhite = "<color=white>";

	// Token: 0x04000193 RID: 403
	private BaseGuitarPlayer instance;

	// Token: 0x04000194 RID: 404
	private int misses;

	// Token: 0x04000195 RID: 405
	private int lastcombo;

	// Token: 0x04000196 RID: 406
	private int combo;

	// Token: 0x04000197 RID: 407
	private int os;

	// Token: 0x04000198 RID: 408
	private int los;

	// Token: 0x04000199 RID: 409
	private int ghosts;

	// Token: 0x0400019A RID: 410
	private int lghosts;

	// Token: 0x0400019B RID: 411
	private const string goodstrum = "cc11ccff";

	// Token: 0x0400019C RID: 412
	private const string badstrum = "ff2211ff";

	// Token: 0x0400019D RID: 413
	private float ostime;

	// Token: 0x0400019E RID: 414
	private float timesince;

	// Token: 0x0400019F RID: 415
	private float gtime;

	// Token: 0x040001A0 RID: 416
	private int lmisses;

	// Token: 0x040001A1 RID: 417
	private int lcombo;

	// Token: 0x040001A2 RID: 418
	private float ticker;

	// Token: 0x040001A3 RID: 419
	private string ctime;

	// Token: 0x040001A4 RID: 420
	private string stime;

	// Token: 0x040001A5 RID: 421
	private bool fcmode;

	// Token: 0x040001A6 RID: 422
	public static bool forceactivate;

	// Token: 0x040001A7 RID: 423
	public static bool enableInputs = true;

	// Token: 0x040001A8 RID: 424
	private float worst;

	// Token: 0x040001A9 RID: 425
	private int combobreaks;

	// Token: 0x040001AA RID: 426
	private int lcombobreaks;

	// Token: 0x040001AB RID: 427
	private TextAlignment textAlignment;

	// Token: 0x040001AC RID: 428
	private Vector3 textpos;

	// Token: 0x040001AD RID: 429
	private bool updateFaster;

	// Token: 0x040001AE RID: 430
	private bool _legacyBinds;

	// Token: 0x040001AF RID: 431
	private bool cleared;

	// Token: 0x040001B0 RID: 432
	private Texture2D square;

	// Token: 0x040001B1 RID: 433
	private Sprite squareSprite;

	// Token: 0x040001B2 RID: 434
	private GUIStyle[] guiInputRenderers;

	// Token: 0x040001B3 RID: 435
	private Color[] Textcolors;

	// Token: 0x040001B4 RID: 436
	private Utf8ValueStringBuilder stringbuffer;

	// Token: 0x040001B5 RID: 437
	private Utf16ValueStringBuilder upperLeftTextBuilder;

	// Token: 0x040001B6 RID: 438
	private Utf16ValueStringBuilder underHighwayTextBuilder;

	// Token: 0x040001B7 RID: 439
	private float ofs;

	// Token: 0x040001B8 RID: 440
	private int startctr;

	// Token: 0x040001B9 RID: 441
	private float timer4;

	// Token: 0x040001BA RID: 442
	private int cullingmask;

	// Token: 0x040001BB RID: 443
	private CameraClearFlags clearflags;

	// Token: 0x040001BC RID: 444
	private int rfi;

	// Token: 0x040001BD RID: 445
	private float best;

	// Token: 0x040001BE RID: 446
	private bool deafened;

	// Token: 0x040001BF RID: 447
	private int lastg;

	// Token: 0x040001C0 RID: 448
	private int lastr;

	// Token: 0x040001C1 RID: 449
	private int lasty;

	// Token: 0x040001C2 RID: 450
	private int lastb;

	// Token: 0x040001C3 RID: 451
	private int lasto;

	// Token: 0x040001C4 RID: 452
	private bool _resetFlag;

	// Token: 0x040001C5 RID: 453
	private double startTime;

	// Token: 0x040001C6 RID: 454
	private TextMeshProUGUI spBarText;
}
