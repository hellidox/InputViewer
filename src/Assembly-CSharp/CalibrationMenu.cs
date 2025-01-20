﻿using System;
using StrikeCore;
using TMPro;
using UnityEngine;

public class CalibrationMenu : BaseSettingMenu
{
	protected override void OnEnable()
	{
		base.OnEnable();
		this.pausedText.text = LanguageManager.instance.GetString("CALIBRATION");
	}

	protected override void \u02BA\u02B8\u02B4\u02BA\u02BD\u02BA\u02B7\u02C1\u02B8\u02B8\u02BC()
	{
	}

	public virtual void \u02C0\u02BE\u02B9\u02B5\u02B6\u02C1\u02B5\u02C0\u02BE\u02B8\u02C1()
	{
		GlobalVariables instance = GlobalVariables.instance;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
			if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "song"))
			{
				if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Unity Game Services disconnected"))
				{
					if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "")
					{
						int currentValue = SettingsController.audioOffset.CurrentValue;
						SettingsController.audioOffset.CurrentValue = BassAudioManager.Instance.\u02C0\u02B6\u02B9\u02BF\u02B3\u02B3\u02BF\u02B6\u02BD\u02B3\u02BF();
						this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
						this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = currentValue == SettingsController.audioOffset.CurrentValue && this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8;
						return;
					}
					if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Returned missing glyphs are incorrect.")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.show_hit_window;
					}
				}
				else
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.audioOffset;
					this.calPreviousValue = SettingsController.audioOffset;
				}
			}
			else
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.videoOffset;
				this.calPreviousValue = SettingsController.videoOffset;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		if (this.pauseMenu != null && !this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8)
		{
			if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.videoOffset || this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.audioOffset)
			{
				if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue != this.calPreviousValue)
				{
					this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = true;
				}
			}
			else
			{
				this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = false;
			}
		}
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		if (!this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 && (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.videoOffset || this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.audioOffset))
		{
			this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue = this.calPreviousValue;
			this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = false;
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	protected virtual void \u02B5\u02B9\u02B5\u02B3\u02BF\u02C1\u02B7\u02BD\u02C0\u02B7\u02C0()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = true;
		base.Awake();
	}

	protected virtual GameSetting \u02BF\u02BF\u02BF\u02BB\u02C1\u02BF\u02B8\u02BC\u02BB\u02C1\u02C0(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1)
	{
		GameSetting gameSetting = null;
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == ""))
		{
			if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == " + "))
			{
				if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Overhits")
				{
					gameSetting = SettingsController.show_hit_window;
				}
			}
			else
			{
				gameSetting = SettingsController.audioOffset;
			}
		}
		else
		{
			gameSetting = SettingsController.videoOffset;
		}
		return gameSetting;
	}

	public override void ConfirmPressed()
	{
		GlobalVariables instance = GlobalVariables.instance;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
			if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Video Offset"))
			{
				if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Audio Offset"))
				{
					if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Get Hardware Latency")
					{
						int currentValue = SettingsController.audioOffset.CurrentValue;
						SettingsController.audioOffset.CurrentValue = BassAudioManager.Instance.\u02C0\u02B6\u02B9\u02BF\u02B3\u02B3\u02BF\u02B6\u02BD\u02B3\u02BF();
						this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
						this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = currentValue != SettingsController.audioOffset.CurrentValue || this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8;
						return;
					}
					if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Show Hit Window")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.show_hit_window;
					}
				}
				else
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.audioOffset;
					this.calPreviousValue = SettingsController.audioOffset;
				}
			}
			else
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.videoOffset;
				this.calPreviousValue = SettingsController.videoOffset;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		if (this.pauseMenu != null && !this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8)
		{
			if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.videoOffset || this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.audioOffset)
			{
				if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue != this.calPreviousValue)
				{
					this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = true;
				}
			}
			else
			{
				this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = true;
			}
		}
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	protected virtual GameSetting \u02BE\u02C1\u02B4\u02B8\u02B4\u02BC\u02C0\u02C1\u02BC\u02B2\u02BE(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1)
	{
		GameSetting gameSetting = null;
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "sub_playlist"))
		{
			if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Warning: These folders contain video backgrounds that wont work on all game platforms, which may be deprecated in the future."))
			{
				if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "album_track")
				{
					gameSetting = SettingsController.show_hit_window;
				}
			}
			else
			{
				gameSetting = SettingsController.audioOffset;
			}
		}
		else
		{
			gameSetting = SettingsController.videoOffset;
		}
		return gameSetting;
	}

	protected virtual void \u02B3\u02B7\u02C1\u02BD\u02B3\u02B5\u02B4\u02B6\u02BF\u02BA\u02BB()
	{
		string text = "<b>{0}</b>/<b>{1}</b>";
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Menu Music") && !(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Show Lyrics"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "A track event occuring at offset {0} is out of order. It comes after the track event at {1} which is illegal.")
			{
				text = Helper.\u02BF\u02B8\u02BD\u02BA\u02BC\u02B4\u02BE\u02B6\u02BE\u02C1\u02B2(this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetBoolValue);
			}
		}
		else
		{
			text = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetIntMSString;
		}
		this.textObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3].text = text;
	}

	protected override void \u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5()
	{
		string text = "";
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Video Offset") && !(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Audio Offset"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Show Hit Window")
			{
				text = Helper.\u02BF\u02B8\u02BD\u02BA\u02BC\u02B4\u02BE\u02B6\u02BE\u02C1\u02B2(this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetBoolValue);
			}
		}
		else
		{
			text = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetIntMSString;
		}
		this.textObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3].text = text;
	}

	protected override void \u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1()
	{
	}

	protected virtual GameSetting \u02C1\u02B9\u02B6\u02B4\u02B6\u02BF\u02B6\u02B5\u02BD\u02B7\u02B4(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1)
	{
		GameSetting gameSetting = null;
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Join as Spectator"))
		{
			if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "FSCache Scan"))
			{
				if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "GameColors_")
				{
					gameSetting = SettingsController.show_hit_window;
				}
			}
			else
			{
				gameSetting = SettingsController.audioOffset;
			}
		}
		else
		{
			gameSetting = SettingsController.videoOffset;
		}
		return gameSetting;
	}

	protected override GameSetting GetSettingFromString(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1)
	{
		GameSetting gameSetting = null;
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Video Offset"))
		{
			if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Audio Offset"))
			{
				if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Show Hit Window")
				{
					gameSetting = SettingsController.show_hit_window;
				}
			}
			else
			{
				gameSetting = SettingsController.audioOffset;
			}
		}
		else
		{
			gameSetting = SettingsController.videoOffset;
		}
		return gameSetting;
	}

	public virtual void \u02B8\u02B3\u02B9\u02BC\u02BA\u02B3\u02B3\u02BC\u02BC\u02B4\u02B7()
	{
		if (!this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 && (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.videoOffset || this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.audioOffset))
		{
			this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue = this.calPreviousValue;
			this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = true;
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	protected override void Awake()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = true;
		base.Awake();
	}

	protected virtual void \u02B9\u02BE\u02BC\u02BE\u02BC\u02B9\u02B2\u02B3\u02BF\u02B2\u02BA()
	{
		base.OnEnable();
		this.pausedText.text = LanguageManager.instance.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("End Events");
	}

	public virtual void \u02C0\u02C0\u02BA\u02B3\u02B9\u02B9\u02BA\u02B5\u02B8\u02B4\u02C0(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1 = "")
	{
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	protected virtual void \u02BF\u02BC\u02B9\u02BE\u02B7\u02BD\u02C1\u02BE\u02BD\u02BD\u02B5()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = true;
		base.Awake();
	}

	public virtual void \u02B8\u02B3\u02B9\u02BD\u02BF\u02BE\u02BE\u02B2\u02BB\u02BE\u02C0()
	{
		if (!this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 && (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.videoOffset || this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.audioOffset))
		{
			this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue = this.calPreviousValue;
			this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = false;
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	public override void \u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1 = "")
	{
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	public virtual void \u02B2\u02B2\u02BE\u02B6\u02BA\u02C0\u02C1\u02BA\u02B9\u02B3\u02BC(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1 = "")
	{
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	public override void SetBools()
	{
	}

	public virtual void \u02BD\u02B3\u02B9\u02BD\u02B3\u02BE\u02B4\u02B9\u02BB\u02BE\u02B9()
	{
		GlobalVariables instance = GlobalVariables.instance;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
			if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "{0:N0}"))
			{
				if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "\\"))
				{
					if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "No")
					{
						int currentValue = SettingsController.audioOffset.CurrentValue;
						SettingsController.audioOffset.CurrentValue = BassAudioManager.Instance.\u02C1\u02B4\u02C1\u02BD\u02BB\u02B7\u02C1\u02B8\u02C1\u02C1\u02B5();
						this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
						this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = currentValue != SettingsController.audioOffset.CurrentValue || this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8;
						return;
					}
					if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == " ")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.show_hit_window;
					}
				}
				else
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.audioOffset;
					this.calPreviousValue = SettingsController.audioOffset;
				}
			}
			else
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.videoOffset;
				this.calPreviousValue = SettingsController.videoOffset;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		if (this.pauseMenu != null && !this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8)
		{
			if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.videoOffset || this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.audioOffset)
			{
				if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue != this.calPreviousValue)
				{
					this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = true;
				}
			}
			else
			{
				this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = false;
			}
		}
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	[SerializeField]
	private PauseMenu pauseMenu;

	[SerializeField]
	private TextMeshProUGUI pausedText;

	[SerializeField]
	private int calPreviousValue;
}
