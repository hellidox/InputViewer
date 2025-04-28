using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Text;
using StrikeCore;
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
		this.draggableTMPS = new List<TextMeshProUGUI>();
		this.fontSizeBackups = new Dictionary<TextMeshProUGUI, float>();
		FrameRate.fr = this;
		this.trailsNeedInit = true;
		this._onInvalidate = new Action(this.__onInvalidate);
		this._onResolutionChange = new Action(this.__onResolutionChange);
		GlobalHelper.OnInvalidate.Add(this._onInvalidate);
		GlobalHelper.OnResolutionChange.Add(this._onResolutionChange);
		this.rfi = GlobalHelper.rfi_config;
		if (this.rfi > 0)
		{
			Debug.Log(string.Format("rfi asdfg {0}", GlobalHelper.rfi_config));
			this.targetSPF = 1f / (float)GlobalHelper.rfi_config;
			Debug.Log(this.targetSPF);
			this.targetFPS = true;
			GlobalVariables.ignoreFrameReset = false;
		}
		else
		{
			Debug.Log(string.Format("rfi: {0}", this.rfi));
			GlobalVariables.ignoreFrameReset = true;
			this.rfi = ((this.rfi != 0) ? (-this.rfi) : 1);
			GlobalHelper.renderFrameInterval = this.rfi;
			Debug.Log(string.Format("rfi: {0}", this.rfi));
		}
		this.startTime = (double)Time.realtimeSinceStartup;
		BasePlayer.interval = 0.1f;
		GlobalHelper.InvalidateCache();
		this.startctr = 1;
		this.ofs = -1f;
		this.ticker = 2f;
		GlobalVariables.misses = 0;
		this.speedhackCheckNumber = -1;
		GC.Collect();
		if (FrameRate.saveFCMode)
		{
			FrameRate.saveFCMode = false;
			GlobalVariables.FCmode = true;
		}
		this.activeHashes = new HashSet<TextMeshProUGUI>();
		this.heldScaleProgress = new Dictionary<TextMeshProUGUI, float>();
		this.textDisplay = base.GetComponent<TextMeshProUGUI>();
		this.timer1 = this.const1;
		this.textDisplay.fontSize = 0.7f * this.textDisplay.fontSize;
		this.upperLeftTextBuilder = ZString.CreateStringBuilder();
		this.textBuilder2 = ZString.CreateStringBuilder();
		this.useTrails = GlobalHelper.useTrails;
		this.squareGO = new GameObject();
		this.square = this.squareGO.AddComponent<SpriteRenderer>();
		Texture2D texture2D = new Texture2D(1, 1, TextureFormat.RGB24, false, false);
		texture2D.SetPixels32(new Color32[]
		{
			new Color32
			{
				r = 1,
				g = 1,
				b = 1,
				a = 1
			}
		});
		Sprite sprite = Sprite.Create(texture2D, new Rect(new Vector2(0f, 0f), new Vector2(1f, 1f)), new Vector2(0f, 0.5f), 1f, 0U, SpriteMeshType.FullRect);
		this.squareSprite = sprite;
		this.square.sprite = this.squareSprite;
		this.square.sortingOrder = 32767;
		this.square.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 5f;
		if (GlobalHelper.useJudgements)
		{
			this.judgementList = this.textDisplay.Duplicate();
			this.judgementList.name = "JudgementList";
			this.judgementList.fontSize *= 0.7f;
			this.fontSizeBackups.Add(this.judgementList, this.judgementList.fontSize);
			this.judgementList.transform.position = new Vector3((float)Screen.width * 0.75f, (float)Screen.height * 0.7f, this.judgementList.transform.position.z);
			this.draggableTMPS.Add(this.judgementList);
			this.judgementList.text = "";
			this.judgementList.alpha = 1f;
			this.judgementList.color = Color.white;
		}
	}

	public FrameRate()
	{
		this.sizeformat = "{000.00}".ToCharArray();
		this.scratch = new char[1024];
		this.const1 = 0.5f;
		this.counter1 = 60;
		this.timeFormats = new string[] { "{.0000}", "{0.000}", "{00.00}", "{000.0}", "{0000}" }.Select((string x) => x.ToCharArray()).ToArray<char[]>();
	}

	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		this.textDisplay = base.GetComponent<TextMeshProUGUI>();
		this.timer1 = this.const1;
	}

	private void Update()
	{
		if (Input.GetKey(KeyCode.F2) && Input.GetKey(KeyCode.LeftShift))
		{
			Process.Start("taskkill.exe", "/f /pid " + Process.GetCurrentProcess().Id.ToString());
		}
		if (Input.GetKey(KeyCode.RightShift))
		{
			float num = Input.GetAxisRaw("Mouse X") * -0.04f;
			float num2 = Input.GetAxisRaw("Mouse Y") * 0.04f;
			Camera.main.transform.Rotate(num2, num, 0f);
		}
		if (Input.GetKey(KeyCode.RightControl))
		{
			float num3 = Input.GetAxisRaw("Mouse X") * -1f * 0.04f;
			float num4 = Input.GetAxisRaw("Mouse Y") * -1f * 0.04f;
			float num5 = ((Input.mouseScrollDelta.y > 0f) ? 0.03f : ((Input.mouseScrollDelta.y < 0f) ? (-0.03f) : 0f));
			Camera.main.transform.position += new Vector3(num3, num4, num5);
		}
		if (Input.GetKeyDown(KeyCode.P) && Time.deltaTime == 1f)
		{
			string tempFileName = Path.GetTempFileName();
			List<string> list = new List<string>();
			list.Add("NAME,X,Y,Z,PITCH,YAW,ROLL,X,Y,Z (scale)");
			foreach (GameObject gameObject in global::UnityEngine.Object.FindObjectsOfType<GameObject>())
			{
				Transform transform = gameObject.transform;
				if (gameObject == Camera.main.gameObject)
				{
					gameObject.name = "MAINCAMERA";
				}
				string text = string.Format("{0},{1},{2},{3},", new object[]
				{
					gameObject.name,
					transform.position.x,
					transform.position.y,
					transform.position.z
				}) + string.Format("{0},{1},{2},", transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z) + string.Format("{0},{1},{2}", transform.localScale.x, transform.localScale.y, transform.localScale.z);
				list.Add(text);
			}
			File.WriteAllText(tempFileName, string.Join("\n", list.ToArray()));
			ProcessStartInfo processStartInfo = new ProcessStartInfo("notepad.exe", tempFileName);
			Process process = new Process();
			process.StartInfo = processStartInfo;
			process.Start();
			process.WaitForExit();
			list = File.ReadAllText(tempFileName).Replace("\r\n", "\n").Split('\n', StringSplitOptions.None)
				.ToList<string>();
			foreach (string text2 in list.Skip(1))
			{
				string[] array2 = text2.Split(',', StringSplitOptions.None);
				if (array2.Length == 10)
				{
					GameObject gameObject2 = GameObject.Find(array2[0]);
					if (!(gameObject2 == null))
					{
						float num6 = float.Parse(array2[1]);
						float num7 = float.Parse(array2[2]);
						float num8 = float.Parse(array2[3]);
						float num9 = float.Parse(array2[4]);
						float num10 = float.Parse(array2[5]);
						float num11 = float.Parse(array2[6]);
						float num12 = float.Parse(array2[7]);
						float num13 = float.Parse(array2[8]);
						float num14 = float.Parse(array2[9]);
						gameObject2.transform.position = new Vector3(num6, num7, num8);
						gameObject2.transform.rotation = Quaternion.Euler(num9, num10, num11);
						gameObject2.transform.localScale = new Vector3(num12, num13, num14);
					}
				}
			}
		}
		if (Input.GetKeyDown(KeyCode.Backspace))
		{
			Debug.Log("YOU ARE GETTING THE FUCKING BUTTON DUDE");
			GlobalHelper.SaveLogs(Input.GetKey(KeyCode.LeftShift));
		}
		if (this.targetFPS)
		{
			this.vsyncTimer += Time.unscaledDeltaTime;
		}
		if (this.startctr == -1)
		{
			this.UpdateDrag();
			if (this.speedhackCheckNumber == -1)
			{
				FrameRate.GetSystemTimePreciseAsFileTime(out this.ftStart);
				this.udtTotal = -(double)Time.unscaledDeltaTime;
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
				double num15 = (double)(this.ftEnd - this.ftStart) / 10000000.0;
				this.timeDifference = (float)(this.udtTotal / num15);
			}
			if (this.targetFPS)
			{
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
			this.ptimer -= Time.unscaledDeltaTime;
			if (this.ptimer < 0f)
			{
				this.ptimer = this.rr;
				this.updateInputs = true;
				if (this.pt_i > 300)
				{
					this.pt_t /= (long)this.pt_i;
					this.pt_i = 1;
				}
				FrameRate.GetSystemTimePreciseAsFileTime(out this.st);
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
			if (!this.targetFPS && GlobalHelper.willCurrentFrameRender)
			{
				this.renderedFrames++;
			}
			if ((double)this.timer1 <= 0.0 && this.updateInputs)
			{
				this.textDisplay.enableWordWrapping = false;
				float num16 = this.timer2 / (float)this.counter1;
				float num17 = (this.targetFPS ? (1f / this.targetSPF) : ((float)this.renderedFrames / 0.36f));
				this.best = 1f / this.best;
				Vector3 normalized = Camera.main.transform.forward.normalized;
				float num18 = 57.295826f;
				float num19 = Mathf.Clamp(normalized.y, -1f, 1f);
				float num20 = Mathf.Atan2(num19, Mathf.Sqrt(1f - num19 * num19)) * num18;
				float num21 = Mathf.Atan2(normalized.x, normalized.z) * num18;
				string text3;
				if (!GlobalHelper.showFPS)
				{
					text3 = "\n";
				}
				else
				{
					Debug.Log("text == " + GlobalHelper.fpsText);
					if (!this.frtext_check.GetValueOrDefault())
					{
						try
						{
							text3 = string.Format(GlobalHelper.fpsText, new object[]
							{
								num16,
								1f / this.worst,
								num17,
								this.best,
								this.timeDifference * 100f,
								(double)(this.old_ftEnd - this.old_ftStart) / 1000.0 / 1000.0 / 10.0,
								this.old_udtTotal,
								GlobalVariables.progress,
								(double)(this.pt_t / (long)this.pt_i) / 1000.0,
								num20,
								num21
							});
						}
						catch (Exception ex)
						{
							this.frtext_check = new bool?(false);
							GlobalHelper.fpsText = string.Format("Bad fpstext or other error! Error: {0}", ex);
						}
					}
					text3 = string.Format(GlobalHelper.fpsText, new object[]
					{
						num16,
						1f / this.worst,
						num17,
						this.best,
						this.timeDifference * 100f,
						(double)(this.old_ftEnd - this.old_ftStart) / 1000.0 / 1000.0 / 10.0,
						this.old_udtTotal,
						GlobalVariables.progress,
						(double)(this.pt_t / (long)this.pt_i),
						num20,
						num21
					});
				}
				this.worst = float.NegativeInfinity;
				this.best = float.PositiveInfinity;
				this.orig = text3;
				if (num16 < 30f)
				{
					this.textDisplay.color = Color.yellow;
				}
				else if (num16 < 10f)
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
				this.bgp = BaseGuitarPlayer.instance;
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
			if (this.bgp != null && this.updateInputs)
			{
				this.combo = this.bgp.combo;
				this.ghosts = this.bgp.ghostCounter;
				this.os = this.bgp.overstrums;
				this.misses = GlobalVariables.misses;
				if (this.combo < this.lcombo)
				{
					this.combobreaks++;
				}
				if (this.combo < this.lcombo && this.misses == this.lmisses && this.os == this.los)
				{
					this.bgp.precision.Clear();
				}
				BaseGuitarPlayer.inputmap minputs = this.bgp.minputs;
				this.upperLeftTextBuilder.Append("<color=#ff00ffaa>");
				this.upperLeftTextBuilder.Append(this.orig);
				this.upperLeftTextBuilder.Append("<color=#ffffffcc>\n");
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
				if (GlobalHelper.useJudgements)
				{
					this.UpdateJudgements();
				}
				if (GlobalHelper.showInputViewer)
				{
					if (!this.useTrails)
					{
						this.UpdateLights(minputs);
					}
					else
					{
						this.UpdateTrails(minputs);
					}
					this.UpdateNumbers(minputs);
				}
				if (GlobalVariables.FCmode)
				{
					this.upperLeftTextBuilder.Append("\n<color=#aaaaaa>FC mode <color=#ff2222FF>on<color=#ffffffcc>");
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
					bool fcmodeDelay = GlobalHelper.FCModeDelay;
					GameAudioManager.PlaySound(SoundEffectsChannel.SongFail);
					BassAudioManager.Instance.PauseSong();
					Task.Run(delegate
					{
						long num25 = 0L;
						for (int j = 0; j < 9; j++)
						{
							FrameRate.GetSystemTimePreciseAsFileTime(out num25);
							long num26 = 0L;
							while (num26 < num25 + 160000L)
							{
								FrameRate.GetSystemTimePreciseAsFileTime(out num26);
							}
							BassAudioManager.Instance.PlaySoundInternal(SoundEffectsChannel.FreestyleSnare, 0, 0.3f);
						}
					});
					Thread.Sleep(fcmodeDelay ? 83 : 0);
					BassAudioManager.Instance.PlaySong(false);
					if (GlobalVariables.instance.isPracticeEnabled || Input.GetKey(KeyCode.Alpha7))
					{
						GameManager.instance.ResetPractice();
						Thread.Sleep(fcmodeDelay ? 83 : 0);
					}
					else
					{
						GlobalVariables.FCmode = false;
						FrameRate.saveFCMode = true;
						this.bgp.gameManager.EndSong();
						Thread.Sleep(fcmodeDelay ? 83 : 0);
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
				if (this.bgp != null)
				{
					this.bgp.overstrums = 0;
					this.bgp.precision.Clear();
				}
			}
			this.los = this.os;
			this.lghosts = this.ghosts;
			this.lcombo = this.combo;
			this.lmisses = this.misses;
			this.lcombobreaks = this.combobreaks;
			if (this.updateInputs)
			{
				long num22;
				FrameRate.GetSystemTimePreciseAsFileTime(out num22);
				long num23 = num22 - this.st;
				if (num23 < 1000000L)
				{
					num23 /= 10L;
					this.pt_i++;
					this.pt_t += num23;
				}
			}
			return;
		}
		if (this.startctr != 10)
		{
			int num24 = this.startctr;
			this.startctr = num24 + 1;
			Debug.Log(num24);
			return;
		}
		if (GlobalHelper.useJudgements)
		{
			BaseGuitarPlayer.instance.precision.Clear();
			BaseGuitarPlayer.instance.playerNameTextBox.fontSize *= 0.315f;
			this.fontSizeBackups.Add(BaseGuitarPlayer.instance.playerNameTextBox, BaseGuitarPlayer.instance.playerNameTextBox.fontSize);
			this.draggableTMPS.Add(BaseGuitarPlayer.instance.playerNameTextBox);
		}
		else if (GlobalHelper.showJudgementsUnderFretboard)
		{
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
		GlobalHelper.OnInvalidate.Remove(this._onInvalidate);
		GlobalHelper.renderFrameInterval = 1;
	}

	private void OnDestroy()
	{
		this.OnDisable();
	}

	[DllImport("kernel32.dll")]
	public static extern void GetSystemTimePreciseAsFileTime(out long systemTimePreciseAsFileTime);

	private void UpdateLights(BaseGuitarPlayer.inputmap minputs)
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
			this.upperLeftTextBuilder.Append(">██</i></indent>\n");
			return;
		}
		this.upperLeftTextBuilder.Append("<color=#00000000>██</i></indent>\n");
	}

	private void UpdateTrails(BaseGuitarPlayer.inputmap minputs)
	{
		if (!this.trailsInitialized)
		{
			this.GetTrail(5);
			return;
		}
		float num = this.rr;
		if (num != 0f)
		{
			if (Input.GetKey(KeyCode.Alpha0))
			{
				foreach (TextMeshProUGUI textMeshProUGUI in this.trails)
				{
					this.bgp.minputs.gcount = (int)(100000f * (textMeshProUGUI.rectTransform.pivot -= new Vector2(0f, 0.0004f * num)).y);
				}
			}
			if (Input.GetKey(KeyCode.Alpha9))
			{
				foreach (TextMeshProUGUI textMeshProUGUI2 in this.trails)
				{
					this.bgp.minputs.gcount = (int)(100000f * (textMeshProUGUI2.rectTransform.pivot += new Vector2(0f, 0.0004f * num)).y);
				}
			}
		}
		if (!this.lastinputs.g && minputs.g)
		{
			this.activeHashes.Add(this.activeTrails[0] = this.GetTrail(0));
		}
		if (!this.lastinputs.r && minputs.r)
		{
			this.activeHashes.Add(this.activeTrails[1] = this.GetTrail(1));
		}
		if (!this.lastinputs.y && minputs.y)
		{
			this.activeHashes.Add(this.activeTrails[2] = this.GetTrail(2));
		}
		if (!this.lastinputs.b && minputs.b)
		{
			this.activeHashes.Add(this.activeTrails[3] = this.GetTrail(3));
		}
		if (!this.lastinputs.o && minputs.o)
		{
			this.activeHashes.Add(this.activeTrails[4] = this.GetTrail(4));
		}
		if (!this.lastinputs.su && minputs.su)
		{
			this.activeHashes.Add(this.activeTrails[5] = this.GetTrail(5));
		}
		if (!this.lastinputs.sd && minputs.sd)
		{
			this.activeHashes.Add(this.activeTrails[6] = this.GetTrail(6));
		}
		if (this.lastinputs.g && !minputs.g)
		{
			this.activeTrails[0].transform.localScale -= new Vector3(0f, 1f, 0f);
			this.activeTrails[0].transform.localPosition -= new Vector3(0f, this.releaseOffset, 0f);
			this.activeHashes.Remove(this.activeTrails[0]);
			this.activeTrails[0] = null;
		}
		if (this.lastinputs.r && !minputs.r)
		{
			this.activeTrails[1].transform.localScale -= new Vector3(0f, 1f, 0f);
			this.activeTrails[1].transform.localPosition -= new Vector3(0f, this.releaseOffset, 0f);
			this.activeHashes.Remove(this.activeTrails[1]);
			this.activeTrails[1] = null;
		}
		if (this.lastinputs.y && !minputs.y)
		{
			this.activeTrails[2].transform.localScale -= new Vector3(0f, 1f, 0f);
			this.activeTrails[2].transform.localPosition -= new Vector3(0f, this.releaseOffset, 0f);
			this.activeHashes.Remove(this.activeTrails[2]);
			this.activeTrails[2] = null;
		}
		if (this.lastinputs.b && !minputs.b)
		{
			this.activeTrails[3].transform.localScale -= new Vector3(0f, 1f, 0f);
			this.activeTrails[3].transform.localPosition -= new Vector3(0f, this.releaseOffset, 0f);
			this.activeHashes.Remove(this.activeTrails[3]);
			this.activeTrails[3] = null;
		}
		if (this.lastinputs.o && !minputs.o)
		{
			this.activeTrails[4].transform.localScale -= new Vector3(0f, 1f, 0f);
			this.activeTrails[4].transform.localPosition -= new Vector3(0f, this.releaseOffset, 0f);
			this.activeHashes.Remove(this.activeTrails[4]);
			this.activeTrails[4] = null;
		}
		if (this.lastinputs.su && !minputs.su)
		{
			this.activeTrails[5].transform.localScale -= new Vector3(0f, 1f, 0f);
			this.activeTrails[5].transform.localPosition -= new Vector3(0f, this.releaseOffset, 0f);
			this.activeHashes.Remove(this.activeTrails[5]);
			this.activeTrails[5] = null;
		}
		if (this.lastinputs.sd && !minputs.sd)
		{
			this.activeTrails[6].transform.localScale -= new Vector3(0f, 1f, 0f);
			this.activeTrails[6].transform.localPosition -= new Vector3(0f, this.releaseOffset, 0f);
			this.activeHashes.Remove(this.activeTrails[6]);
			this.activeTrails[6] = null;
		}
		TextMeshProUGUI[] array2 = this.trails;
		for (int j = 0; j < array2.Length; j++)
		{
			if (!this.activeHashes.Contains(this.trails[j]))
			{
				array2[j].transform.localPosition -= new Vector3(0f, this.scaleSpeed * num * 25f, 0f);
			}
		}
		for (int k = 0; k < this.activeTrails.Length; k++)
		{
			TextMeshProUGUI textMeshProUGUI3 = this.activeTrails[k];
			if (textMeshProUGUI3 != null)
			{
				textMeshProUGUI3.transform.localScale += new Vector3(0f, this.scaleSpeed * num, 0f);
			}
		}
		if (GlobalVariables.neededLeniency && this.lastStrum)
		{
			GlobalVariables.neededLeniency = false;
			this.lastStrum.color = Color.yellow;
		}
		if (GlobalVariables.overstrummed && this.lastStrum)
		{
			GlobalVariables.overstrummed = false;
			this.lastStrum.color = Color.red;
		}
		this.lastinputs = minputs;
		this.upperLeftTextBuilder.Append('\n');
	}

	private TextMeshProUGUI GetTrail(int trail)
	{
		if (!this.trailsInitialized)
		{
			this.InitTrails();
		}
		int num = 0;
		do
		{
			num++;
			this.currentTrail++;
			if (this.currentTrail == this.trails.Length)
			{
				this.currentTrail = 0;
			}
		}
		while (num <= 10 && (this.trails[this.currentTrail] == this.activeTrails[0] || this.trails[this.currentTrail] == this.activeTrails[1] || this.trails[this.currentTrail] == this.activeTrails[2] || this.trails[this.currentTrail] == this.activeTrails[3] || this.trails[this.currentTrail] == this.activeTrails[4] || this.trails[this.currentTrail] == this.activeTrails[5] || this.trails[this.currentTrail] == this.activeTrails[6]));
		TextMeshProUGUI textMeshProUGUI = this.trails[this.currentTrail];
		textMeshProUGUI.transform.localScale = new Vector3(1.5f, 1.01f, 1f);
		Vector2 vector = new Vector2(GlobalHelper.trailPosX * (float)Screen.width + this.sizePerChar * 0.5f, (float)Screen.height - GlobalHelper.trailPosY * (float)Screen.height);
		switch (trail)
		{
		case 0:
			vector += new Vector2(this.sizePerChar * 2f, 0f);
			break;
		case 1:
			vector += new Vector2(this.sizePerChar * 3f, 0f);
			break;
		case 2:
			vector += new Vector2(this.sizePerChar * 4f, 0f);
			break;
		case 3:
			vector += new Vector2(this.sizePerChar * 5f, 0f);
			break;
		case 4:
			vector += new Vector2(this.sizePerChar * 6f, 0f);
			break;
		case 5:
			vector += new Vector2(this.sizePerChar * 0f, 0f);
			break;
		case 6:
			vector += new Vector2(this.sizePerChar * 1f, 0f);
			break;
		}
		vector.x = (float)Math.Floor((double)vector.x);
		textMeshProUGUI.transform.position = vector;
		textMeshProUGUI.color = this.fret_colors[trail];
		this.heldScaleProgress[textMeshProUGUI] = 0f;
		if (trail == 5 || trail == 6)
		{
			this.lastStrum = textMeshProUGUI;
		}
		else if (textMeshProUGUI == this.lastStrum)
		{
			this.lastStrum = null;
		}
		return textMeshProUGUI;
	}

	[CompilerGenerated]
	private void __onInvalidate()
	{
		this.fretColors = new Color[]
		{
			HexColor.FromHexString(GlobalHelper.greenFretColor).AsColor(),
			HexColor.FromHexString(GlobalHelper.redFretColor).AsColor(),
			HexColor.FromHexString(GlobalHelper.yellowFretColor).AsColor(),
			HexColor.FromHexString(GlobalHelper.blueFretColor).AsColor(),
			HexColor.FromHexString(GlobalHelper.orangeFretColor).AsColor(),
			HexColor.FromHexString(GlobalHelper.strumColor).AsColor(),
			HexColor.FromHexString(GlobalHelper.strumColor).AsColor()
		};
		this.trailsNeedInit = true;
		this.rr = 1f / (float)GlobalHelper.inputViewerHz;
		this.rfi = GlobalHelper.rfi_config;
		if (this.rfi > 0)
		{
			Debug.Log(string.Format("rfi asdfg {0}", GlobalHelper.rfi_config));
			this.targetSPF = 1f / (float)GlobalHelper.rfi_config;
			Debug.Log(this.targetSPF);
			this.targetFPS = true;
			GlobalVariables.ignoreFrameReset = false;
		}
		else
		{
			GlobalVariables.ignoreFrameReset = true;
			this.rfi = ((this.rfi != 0) ? (-this.rfi) : 1);
			GlobalHelper.renderFrameInterval = this.rfi;
		}
		Debug.Log("fr callback");
	}

	private void InitTrails()
	{
		this.trails = new TextMeshProUGUI[GlobalHelper.maxTrails];
		for (int i = 0; i < this.trails.Length; i++)
		{
			this.trails[i] = this.textDisplay.Duplicate();
			this.trails[i].gameObject.name = string.Format("trail_{0}", i);
			this.trails[i].enableWordWrapping = false;
			this.trails[i].text = "█";
			this.trails[i].richText = true;
			Texture mainTexture = this.trails[i].mainTexture;
			this.trails[i].rectTransform.pivot = new Vector2(0.5f, 0.8185f);
			this.trails[i].mainTexture.filterMode = FilterMode.Point;
			this.trails[i].alignment = TextAlignmentOptions.Top;
			this.trails[i].transform.localScale = new Vector3(1.5f, 1.01f, 1f);
		}
		this.fretColors = new Color[]
		{
			HexColor.FromHexString(GlobalHelper.greenFretColor).AsColor(),
			HexColor.FromHexString(GlobalHelper.redFretColor).AsColor(),
			HexColor.FromHexString(GlobalHelper.yellowFretColor).AsColor(),
			HexColor.FromHexString(GlobalHelper.blueFretColor).AsColor(),
			HexColor.FromHexString(GlobalHelper.orangeFretColor).AsColor(),
			HexColor.FromHexString(GlobalHelper.strumColor).AsColor(),
			HexColor.FromHexString(GlobalHelper.strumColor).AsColor()
		}.Select((Color x) => x.Saturate(1f)).ToArray<Color>();
		Color[] array = this.fretColors;
		for (int j = 0; j < array.Length; j++)
		{
			Debug.Log(array[j]);
		}
		this.activeTrails = new TextMeshProUGUI[7];
		this.__onResolutionChange();
		this.trailsInitialized = true;
	}

	private void __onResolutionChange()
	{
		this.trails[0].fontSize = this.trails[0].fontSize;
		float num = this.trails[0].fontSize * this.trails[0].transform.localScale.x;
		Debug.Log(string.Format("width: {0} fs {1} ls {2}", num, this.trails[0].fontSize, this.trails[0].transform.localScale.x));
		Vector2 vector = new Vector2(num, 22.5f);
		float num2 = (float)Screen.width / 1080f;
		this.releaseOffset = vector.y;
		this.sizePerChar = num;
		this.scaleSpeed = 1080f / vector.y * GlobalHelper.trailSpeed;
		this.trailsNeedInit = false;
	}

	private Color[] fret_colors
	{
		get
		{
			if (this.bgp && this.bgp._spBar && this.bgp._spBar.gameColorSettings != null && GlobalHelper.rainbowEverything)
			{
				return new Color[]
				{
					this.bgp._spBar.gameColorSettings.guitarNoteGreen,
					this.bgp._spBar.gameColorSettings.guitarNoteRed,
					this.bgp._spBar.gameColorSettings.guitarNoteYellow,
					this.bgp._spBar.gameColorSettings.guitarNoteBlue,
					this.bgp._spBar.gameColorSettings.guitarNoteOrange,
					this.bgp._spBar.gameColorSettings.guitarNoteOpen,
					this.bgp._spBar.gameColorSettings.guitarNoteOpen
				};
			}
			return this.fretColors;
		}
	}

	private void UpdateJudgements()
	{
		float num = (float)GameManager.instance.songTime - GlobalVariables.lastBeat;
		float num2 = 0.083333336f;
		float num3 = 1f;
		if (num >= 0f && num <= num2)
		{
			float num4 = num / num2;
			num3 = 1.02f - 0.02f * num4;
		}
		float num5 = num3 * 18.5f - 18.5f;
		if (this.judgementList)
		{
			this.judgementList.fontSize = this.fontSizeBackups[this.judgementList] + num5;
			this.textBuilder2.Clear();
			foreach (KeyValuePair<BasePlayer.Judgement, int> keyValuePair in this.bgp.precision.hits)
			{
				if (keyValuePair.Value > 0)
				{
					this.textBuilder2.Append(new ReadOnlySpan<char>(keyValuePair.Key.ToCharArray()));
					this.textBuilder2.AppendFormat<int>("</color>: <color=#ffffff99>x</color>{0}\n", keyValuePair.Value);
				}
				else
				{
					this.textBuilder2.Append('\n');
				}
			}
			this.textBuilder2.AsArraySegment().CopyTo(this.scratch, 0);
			this.scratch[this.textBuilder2.Length] = '\0';
			this.judgementList.SetCharArray(this.scratch);
		}
		if (GlobalHelper.showJudgementsUnderFretboard)
		{
			this.textBuilder2.Clear();
			this.textBuilder2.Append(new ReadOnlySpan<char>(GlobalHelper.GetGrade(this.bgp.precision.Accuracy, false)));
			if (GlobalHelper.showAvgInaccuracy)
			{
				this.textBuilder2.AppendFormat<float, float>("\n</i>{0:00.00}% - {1:00.00}ms\n", this.bgp.precision.Accuracy * 100f, this.bgp.precision.avgInaccuracy * 1000f);
				this.textBuilder2.AppendFormat<float>("{0:00.00}", BasePlayer.lastOffset * 1000f);
			}
			else
			{
				this.textBuilder2.AppendFormat<float, float>("\n</i>{0:00.00}%\n{1:00.00}ms\n", this.bgp.precision.Accuracy * 100f, BasePlayer.lastOffset * 1000f);
			}
			switch (this.bgp.precision.m_lastJudgement)
			{
			case BasePlayer.Judgement.Marvelous:
				this.textBuilder2.Append("ms\n<color=#33ffff>Flawless!");
				break;
			case BasePlayer.Judgement.Perfect:
				this.textBuilder2.Append("ms\n<color=yellow>Perfect!");
				break;
			case BasePlayer.Judgement.Great:
				this.textBuilder2.Append("ms\n<color=#ff33ff>Great!");
				break;
			case BasePlayer.Judgement.Good:
				this.textBuilder2.Append("ms\n<color=#22ff22>Good");
				break;
			case BasePlayer.Judgement.Bad:
				this.textBuilder2.Append("ms\n<color=orange>Bad");
				break;
			case BasePlayer.Judgement.Early:
				this.textBuilder2.Append("ms\nEarly");
				break;
			default:
				this.textBuilder2.Append("ms\n<color=#aaaaaaaa>Miss");
				break;
			}
			this.textBuilder2.AsArraySegment().CopyTo(this.scratch, 0);
			this.scratch[this.textBuilder2.Length] = '\0';
			this.bgp.playerNameTextBox.SetCharArray(this.scratch);
			this.bgp.playerNameTextBox.fontSize = this.fontSizeBackups[this.bgp.playerNameTextBox] + num5 * 0.25f;
			this.textBuilder2.Clear();
		}
	}

	private void UpdateDrag()
	{
		if (Input.GetKey(KeyCode.LeftControl) && Input.GetMouseButton(0))
		{
			float num = (float)Screen.width / 1920f * 0.06f;
			float num2 = (float)Screen.height / 1080f * 0.06f;
			TextMeshProUGUI textMeshProUGUI = null;
			float num3 = (float)Screen.width / 20f;
			foreach (TextMeshProUGUI textMeshProUGUI2 in this.draggableTMPS)
			{
				if (Vector3.Distance(textMeshProUGUI2.transform.position, new Vector3(Input.mousePosition.x, Input.mousePosition.y, textMeshProUGUI2.transform.position.z)) < num3)
				{
					textMeshProUGUI = textMeshProUGUI2;
				}
				if (textMeshProUGUI)
				{
					if (textMeshProUGUI.name == "NameText")
					{
						textMeshProUGUI.transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * num, Input.GetAxisRaw("Mouse Y") * num2, 0f);
					}
					else
					{
						textMeshProUGUI.transform.position = Input.mousePosition;
					}
				}
			}
		}
	}

	private void UpdateNumbers(BaseGuitarPlayer.inputmap minputs)
	{
		this.lastg = minputs.gcount;
		this.lastr = minputs.rcount;
		this.lasty = minputs.ycount;
		this.lastb = minputs.bcount;
		this.lasto = minputs.ocount;
		this.upperLeftTextBuilder.Append("<color=");
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
		if (Input.GetKey(KeyCode.LeftControl))
		{
			this.upperLeftTextBuilder.AppendFormat<Vector3>("\n{0} mouse pos", new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
			foreach (TextMeshProUGUI textMeshProUGUI in this.draggableTMPS)
			{
				this.upperLeftTextBuilder.AppendFormat<Vector3, string>("\n{0} - {1}", textMeshProUGUI.transform.position, textMeshProUGUI.name);
				this.upperLeftTextBuilder.AppendFormat<float>(" {0:N0}", Vector3.Distance(new Vector3(textMeshProUGUI.transform.position.x, textMeshProUGUI.transform.position.y, 0f), Input.mousePosition));
			}
		}
	}

	private void OnGUI()
	{
		if (Input.GetKey(KeyCode.LeftControl))
		{
			foreach (TextMeshProUGUI textMeshProUGUI in this.draggableTMPS)
			{
				GUI.Toggle(new Rect(textMeshProUGUI.transform.position.x, (float)Screen.height - textMeshProUGUI.transform.position.y, 128f, 128f), true, new GUIContent(textMeshProUGUI.name, "test"), GUIStyle.none);
			}
		}
	}

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

	private BaseGuitarPlayer bgp;

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

	private Sprite squareSprite;

	private GUIStyle[] guiInputRenderers;

	private Color[] Textcolors;

	private Utf8ValueStringBuilder stringbuffer;

	private Utf16ValueStringBuilder upperLeftTextBuilder;

	private Utf16ValueStringBuilder textBuilder2;

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

	private TextMeshProUGUI noiseTMP;

	private static global::System.Random rnd = new global::System.Random();

	private bool useTrails;

	private TextMeshProUGUI[] trails;

	private const int GREEN = 0;

	private const int RED = 1;

	private const int YELLOW = 2;

	private const int BLUE = 3;

	private const int ORANGE = 4;

	private const int UPSTRUM = 5;

	private const int DOWNSTRUM = 6;

	private int currentTrail;

	private Color[] fretColors;

	private Action _onInvalidate;

	private bool trailsNeedInit;

	private float sizePerChar;

	private float scaleSpeed;

	private TextMeshProUGUI[] activeTrails;

	private BaseGuitarPlayer.inputmap lastinputs;

	private TextMeshProUGUI spText;

	private HashSet<TextMeshProUGUI> activeHashes;

	private float releaseOffset;

	private Dictionary<TextMeshProUGUI, float> heldScaleProgress;

	private TextMeshProUGUI lastStrum;

	private bool targetFPS;

	private bool? frtext_check;

	private bool trailsInitialized;

	private SpriteRenderer[] trailSprites;

	private SpriteRenderer square;

	private GameObject squareGO;

	private Action _onResolutionChange;

	private double last_fcmode;

	private static bool saveFCMode;

	private int pt_i;

	private long pt_t;

	private long st;

	private TextMeshProUGUI judgementList;

	private Utf16ValueStringBuilder sb3;

	private char[] scratch;

	private List<TextMeshProUGUI> draggableTMPS;

	private bool setLock;

	private Camera hudcam;

	public static FrameRate fr;

	private float lastBeat;

	private char[] sizeformat;

	[Comment("Indexed by digits to left of decimal (0, 1, 2, 3, 4)")]
	private char[][] timeFormats;

	private Dictionary<TextMeshProUGUI, float> fontSizeBackups;
}
