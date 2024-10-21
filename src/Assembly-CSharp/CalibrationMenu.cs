using System;
using StrikeCore;
using TMPro;
using UnityEngine;

// Token: 0x020000F8 RID: 248
public class CalibrationMenu : BaseSettingMenu
{
	// Token: 0x060009F6 RID: 2550 RVA: 0x0000AE31 File Offset: 0x00009031
	protected override void OnEnable()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("CALIBRATION");
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00005F91 File Offset: 0x00004191
	protected override void \u02BA\u02B8\u02B4\u02BA\u02BD\u02BA\u02B7\u02C1\u02B8\u02B8\u02BC()
	{
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00056A28 File Offset: 0x00054C28
	public virtual void \u02C0\u02BE\u02B9\u02B5\u02B6\u02C1\u02B5\u02C0\u02BE\u02B8\u02C1()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
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
						int currentValue = SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4.CurrentValue;
						SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4.CurrentValue = BassAudioManager.Instance.\u02C0\u02B6\u02B9\u02BF\u02B3\u02B3\u02BF\u02B6\u02BD\u02B3\u02BF();
						this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
						this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = currentValue == SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4.CurrentValue && this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8;
						return;
					}
					if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Returned missing glyphs are incorrect.")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B7\u02BD\u02BC\u02BE\u02B3\u02B2\u02C0\u02BA\u02B7\u02C1\u02B2;
					}
				}
				else
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4;
					this.calPreviousValue = SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4;
				}
			}
			else
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB;
				this.calPreviousValue = SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		if (this.pauseMenu != null && !this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8)
		{
			if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB || this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4)
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

	// Token: 0x060009F9 RID: 2553 RVA: 0x00056BA4 File Offset: 0x00054DA4
	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		if (!this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 && (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB || this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4))
		{
			this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue = this.calPreviousValue;
			this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = false;
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x0000AE53 File Offset: 0x00009053
	protected virtual void \u02B5\u02B9\u02B5\u02B3\u02BF\u02C1\u02B7\u02BD\u02C0\u02B7\u02C0()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = true;
		base.Awake();
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00056BFC File Offset: 0x00054DFC
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
					gameSetting = SettingsController.\u02B7\u02BD\u02BC\u02BE\u02B3\u02B2\u02C0\u02BA\u02B7\u02C1\u02B2;
				}
			}
			else
			{
				gameSetting = SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4;
			}
		}
		else
		{
			gameSetting = SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB;
		}
		return gameSetting;
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00056C54 File Offset: 0x00054E54
	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
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
						int currentValue = SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4.CurrentValue;
						SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4.CurrentValue = BassAudioManager.Instance.\u02C0\u02B6\u02B9\u02BF\u02B3\u02B3\u02BF\u02B6\u02BD\u02B3\u02BF();
						this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
						this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = currentValue != SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4.CurrentValue || this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8;
						return;
					}
					if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Show Hit Window")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B7\u02BD\u02BC\u02BE\u02B3\u02B2\u02C0\u02BA\u02B7\u02C1\u02B2;
					}
				}
				else
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4;
					this.calPreviousValue = SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4;
				}
			}
			else
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB;
				this.calPreviousValue = SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		if (this.pauseMenu != null && !this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8)
		{
			if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB || this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4)
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

	// Token: 0x060009FD RID: 2557 RVA: 0x00056DD0 File Offset: 0x00054FD0
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
					gameSetting = SettingsController.\u02B7\u02BD\u02BC\u02BE\u02B3\u02B2\u02C0\u02BA\u02B7\u02C1\u02B2;
				}
			}
			else
			{
				gameSetting = SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4;
			}
		}
		else
		{
			gameSetting = SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB;
		}
		return gameSetting;
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00056E28 File Offset: 0x00055028
	protected virtual void \u02B3\u02B7\u02C1\u02BD\u02B3\u02B5\u02B4\u02B6\u02BF\u02BA\u02BB()
	{
		string text = "<b>{0}</b>/<b>{1}</b>";
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Menu Music") && !(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Show Lyrics"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "A track event occuring at offset {0} is out of order. It comes after the track event at {1} which is illegal.")
			{
				text = __FIXME_clon_util.\u02BF\u02B8\u02BD\u02BA\u02BC\u02B4\u02BE\u02B6\u02BE\u02C1\u02B2(this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetBoolValue);
			}
		}
		else
		{
			text = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetIntMSString;
		}
		this.textObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3].text = text;
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00056EA0 File Offset: 0x000550A0
	protected override void \u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5()
	{
		string text = "";
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Video Offset") && !(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Audio Offset"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Show Hit Window")
			{
				text = __FIXME_clon_util.\u02BF\u02B8\u02BD\u02BA\u02BC\u02B4\u02BE\u02B6\u02BE\u02C1\u02B2(this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetBoolValue);
			}
		}
		else
		{
			text = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetIntMSString;
		}
		this.textObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3].text = text;
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00005F91 File Offset: 0x00004191
	protected override void \u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1()
	{
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00056F18 File Offset: 0x00055118
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
					gameSetting = SettingsController.\u02B7\u02BD\u02BC\u02BE\u02B3\u02B2\u02C0\u02BA\u02B7\u02C1\u02B2;
				}
			}
			else
			{
				gameSetting = SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4;
			}
		}
		else
		{
			gameSetting = SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB;
		}
		return gameSetting;
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00056F70 File Offset: 0x00055170
	protected override GameSetting \u02B9\u02B5\u02B5\u02B7\u02BE\u02BF\u02B6\u02B5\u02BB\u02B9\u02C1(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1)
	{
		GameSetting gameSetting = null;
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Video Offset"))
		{
			if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Audio Offset"))
			{
				if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Show Hit Window")
				{
					gameSetting = SettingsController.\u02B7\u02BD\u02BC\u02BE\u02B3\u02B2\u02C0\u02BA\u02B7\u02C1\u02B2;
				}
			}
			else
			{
				gameSetting = SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4;
			}
		}
		else
		{
			gameSetting = SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB;
		}
		return gameSetting;
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x00056FC8 File Offset: 0x000551C8
	public virtual void \u02B8\u02B3\u02B9\u02BC\u02BA\u02B3\u02B3\u02BC\u02BC\u02B4\u02B7()
	{
		if (!this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 && (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB || this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4))
		{
			this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue = this.calPreviousValue;
			this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = true;
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x0000AE53 File Offset: 0x00009053
	protected override void Awake()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = true;
		base.Awake();
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x0000AE6A File Offset: 0x0000906A
	protected virtual void \u02B9\u02BE\u02BC\u02BE\u02BC\u02B9\u02B2\u02B3\u02BF\u02B2\u02BA()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("End Events");
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x0000AE8C File Offset: 0x0000908C
	public virtual void \u02C0\u02C0\u02BA\u02B3\u02B9\u02B9\u02BA\u02B5\u02B8\u02B4\u02C0(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1 = "")
	{
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x0000AE53 File Offset: 0x00009053
	protected virtual void \u02BF\u02BC\u02B9\u02BE\u02B7\u02BD\u02C1\u02BE\u02BD\u02BD\u02B5()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = true;
		base.Awake();
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x00056BA4 File Offset: 0x00054DA4
	public virtual void \u02B8\u02B3\u02B9\u02BD\u02BF\u02BE\u02BE\u02B2\u02BB\u02BE\u02C0()
	{
		if (!this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 && (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB || this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4))
		{
			this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue = this.calPreviousValue;
			this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = false;
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x0000AE8C File Offset: 0x0000908C
	public override void \u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1 = "")
	{
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x0000AE8C File Offset: 0x0000908C
	public virtual void \u02B2\u02B2\u02BE\u02B6\u02BA\u02C0\u02C1\u02BA\u02B9\u02B3\u02BC(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1 = "")
	{
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00005F91 File Offset: 0x00004191
	public override void \u02B4\u02BF\u02B6\u02B3\u02B7\u02BA\u02B9\u02B9\u02BD\u02BD\u02B4()
	{
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00057020 File Offset: 0x00055220
	public virtual void \u02BD\u02B3\u02B9\u02BD\u02B3\u02BE\u02B4\u02B9\u02BB\u02BE\u02B9()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
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
						int currentValue = SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4.CurrentValue;
						SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4.CurrentValue = BassAudioManager.Instance.\u02C1\u02B4\u02C1\u02BD\u02BB\u02B7\u02C1\u02B8\u02C1\u02C1\u02B5();
						this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
						this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = currentValue != SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4.CurrentValue || this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8;
						return;
					}
					if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == " ")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B7\u02BD\u02BC\u02BE\u02B3\u02B2\u02C0\u02BA\u02B7\u02C1\u02B2;
					}
				}
				else
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4;
					this.calPreviousValue = SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4;
				}
			}
			else
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB;
				this.calPreviousValue = SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		if (this.pauseMenu != null && !this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8)
		{
			if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB || this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4)
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

	// Token: 0x0400078F RID: 1935
	[SerializeField]
	private PauseMenu pauseMenu;

	// Token: 0x04000790 RID: 1936
	[SerializeField]
	private TextMeshProUGUI pausedText;

	// Token: 0x04000791 RID: 1937
	[SerializeField]
	private int calPreviousValue;
}
