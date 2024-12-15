using System;
using System.Collections.Generic;
using StrikeCore;
using UnityEngine;

public class AudioSettingsMenu : BaseSettingMenu
{
	protected override void \u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5()
	{
		this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3);
		this.\u02BC\u02C1\u02C1\u02BB\u02BD\u02BF\u02BA\u02C1\u02C0\u02BF\u02BE();
	}

	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02B4\u02BA\u02B4\u02B2\u02B9\u02BF\u02BB\u02BE\u02B2\u02B9\u02B9;
			string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
			uint num = PrivateImplementationDetails.ComputeStringHash(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B);
			if (num <= 2242673754U)
			{
				if (num <= 559764484U)
				{
					if (num <= 229110729U)
					{
						if (num != 28608261U)
						{
							if (num == 229110729U)
							{
								if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Audio Backend")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.audioBackend;
								}
							}
						}
						else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Whammy SFX")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.whammy_sfx;
						}
					}
					else if (num != 259185239U)
					{
						if (num == 559764484U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Preview Music")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.preview_volume;
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Vocals")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[3];
					}
				}
				else if (num <= 1279923219U)
				{
					if (num != 704539491U)
					{
						if (num == 1279923219U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Audio Latency")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.latency_mode;
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Master Volume")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.master_volume;
					}
				}
				else if (num != 1613443821U)
				{
					if (num == 2242673754U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Drums")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[6];
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Keys")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[11];
				}
			}
			else if (num <= 3022894065U)
			{
				if (num <= 2441828660U)
				{
					if (num != 2332143585U)
					{
						if (num == 2441828660U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Song")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[12];
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Drums Freestyle")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.freestyle_drums;
					}
				}
				else if (num != 2770175893U)
				{
					if (num == 3022894065U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Rhythm")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[2];
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Menu Music")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.menu_volume;
				}
			}
			else if (num <= 3411634414U)
			{
				if (num != 3132903066U)
				{
					if (num == 3411634414U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Crowd")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[13];
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Bass")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[1];
				}
			}
			else if (num != 3428315309U)
			{
				if (num != 4114373679U)
				{
					if (num == 4188053186U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Sound Effects")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.sounds;
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Guitar")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[0];
				}
			}
			else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Track Mute")
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.mute_volume;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		this.\u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1();
		this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02BD\u02BD\u02B6\u02C1\u02B6\u02BD\u02BA\u02B8\u02BE\u02BF\u02B9;
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public override void SetBools()
	{
	}

	public override void \u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(string \u02B4\u02B9\u02B3\u02B9\u02BC\u02C1\u02BE\u02BF\u02B4\u02B9\u02C0 = "")
	{
		this.\u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1.Clear();
		if (\u02B4\u02B9\u02B3\u02B9\u02BC\u02C1\u02BE\u02BF\u02B4\u02B9\u02C0 != string.Empty)
		{
			this.\u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1.Add(\u02B4\u02B9\u02B3\u02B9\u02BC\u02C1\u02BE\u02BF\u02B4\u02B9\u02C0);
		}
		else
		{
			this.\u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1.AddRange(this.menuStrings);
		}
		foreach (string text in this.\u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1)
		{
			GameSetting settingFromString = this.GetSettingFromString(text);
			uint num = PrivateImplementationDetails.ComputeStringHash(text);
			if (num <= 2242673754U)
			{
				if (num <= 559764484U)
				{
					if (num <= 229110729U)
					{
						if (num != 28608261U)
						{
							if (num == 229110729U)
							{
								if (text == "Audio Backend")
								{
									this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = BassAudioManager.\u02B9\u02B2\u02B6\u02BB\u02B4\u02B7\u02B6\u02B5\u02B7\u02B2\u02BA(settingFromString.CurrentValue).ToString();
								}
							}
						}
						else if (text == "Whammy SFX")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
						}
					}
					else if (num != 259185239U)
					{
						if (num == 559764484U)
						{
							if (text == "Preview Music")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(12, settingFromString);
							}
						}
					}
					else if (text == "Vocals")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(4, settingFromString);
					}
				}
				else if (num <= 1279923219U)
				{
					if (num != 704539491U)
					{
						if (num == 1279923219U)
						{
							if (text == "Audio Latency")
							{
								string text2;
								switch (SettingsController.latency_mode.CurrentValue)
								{
								case 0:
									text2 = "Low Latency";
									break;
								case 1:
									text2 = "Normal Latency";
									break;
								case 2:
									text2 = "High Latency";
									break;
								default:
									text2 = "Normal Latency";
									break;
								}
								this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = LanguageManager.instance.GetString(text2);
							}
						}
					}
					else if (text == "Master Volume")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(0, settingFromString);
					}
				}
				else if (num != 1613443821U)
				{
					if (num == 2242673754U)
					{
						if (text == "Drums")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(5, settingFromString);
						}
					}
				}
				else if (text == "Keys")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(6, settingFromString);
				}
			}
			else if (num <= 3022894065U)
			{
				if (num <= 2441828660U)
				{
					if (num != 2332143585U)
					{
						if (num == 2441828660U)
						{
							if (text == "Song")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(7, settingFromString);
							}
						}
					}
					else if (text == "Drums Freestyle")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(9, settingFromString);
					}
				}
				else if (num != 2770175893U)
				{
					if (num == 3022894065U)
					{
						if (text == "Rhythm")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(3, settingFromString);
						}
					}
				}
				else if (text == "Menu Music")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(11, settingFromString);
				}
			}
			else if (num <= 3411634414U)
			{
				if (num != 3132903066U)
				{
					if (num == 3411634414U)
					{
						if (text == "Crowd")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(8, settingFromString);
						}
					}
				}
				else if (text == "Bass")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(2, settingFromString);
				}
			}
			else if (num != 3428315309U)
			{
				if (num != 4114373679U)
				{
					if (num == 4188053186U)
					{
						if (text == "Sound Effects")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(10, settingFromString);
						}
					}
				}
				else if (text == "Guitar")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
				}
			}
			else if (text == "Track Mute")
			{
				base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(13, settingFromString);
			}
		}
	}

	protected override void \u02BA\u02B8\u02B4\u02BA\u02BD\u02BA\u02B7\u02C1\u02B8\u02B8\u02BC()
	{
	}

	private void \u02BC\u02C1\u02C1\u02BB\u02BD\u02BF\u02BA\u02C1\u02C0\u02BF\u02BE()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Master Volume")
		{
			BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(SettingsController.menu_volume.GetCurrentVolume);
			return;
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Menu Music")
		{
			if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue == 0)
			{
				this.menuMusic.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(false);
			}
			BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetCurrentVolume);
		}
	}

	protected override void \u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Audio Latency")
		{
			this.menuMusic.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(true);
			BassAudioManager.Instance.\u02B7\u02B9\u02B2\u02C0\u02B8\u02B6\u02BE\u02C0\u02B5\u02B4\u02B6();
			this.menuMusic.\u02B9\u02BF\u02B3\u02C1\u02B9\u02B2\u02B9\u02BA\u02B8\u02B5\u02B9();
			return;
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Audio Backend")
		{
			this.menuMusic.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(true);
			BassAudioManager.Instance.\u02B7\u02B9\u02B2\u02C0\u02B8\u02B6\u02BE\u02C0\u02B5\u02B4\u02B6();
			this.menuMusic.\u02B9\u02BF\u02B3\u02C1\u02B9\u02B2\u02B9\u02BA\u02B8\u02B5\u02B9();
		}
	}

	protected override GameSetting GetSettingFromString(string \u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0)
	{
		GameSetting gameSetting = null;
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0);
		if (num <= 2242673754U)
		{
			if (num <= 559764484U)
			{
				if (num <= 229110729U)
				{
					if (num != 28608261U)
					{
						if (num == 229110729U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Audio Backend")
							{
								gameSetting = SettingsController.audioBackend;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Whammy SFX")
					{
						gameSetting = SettingsController.whammy_sfx;
					}
				}
				else if (num != 259185239U)
				{
					if (num == 559764484U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Preview Music")
						{
							gameSetting = SettingsController.preview_volume;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Vocals")
				{
					gameSetting = SettingsController.volume_Stems[3];
				}
			}
			else if (num <= 1279923219U)
			{
				if (num != 704539491U)
				{
					if (num == 1279923219U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Audio Latency")
						{
							gameSetting = SettingsController.latency_mode;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Master Volume")
				{
					gameSetting = SettingsController.master_volume;
				}
			}
			else if (num != 1613443821U)
			{
				if (num == 2242673754U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Drums")
					{
						gameSetting = SettingsController.volume_Stems[6];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Keys")
			{
				gameSetting = SettingsController.volume_Stems[11];
			}
		}
		else if (num <= 3022894065U)
		{
			if (num <= 2441828660U)
			{
				if (num != 2332143585U)
				{
					if (num == 2441828660U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Song")
						{
							gameSetting = SettingsController.volume_Stems[12];
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Drums Freestyle")
				{
					gameSetting = SettingsController.freestyle_drums;
				}
			}
			else if (num != 2770175893U)
			{
				if (num == 3022894065U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Rhythm")
					{
						gameSetting = SettingsController.volume_Stems[2];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Menu Music")
			{
				gameSetting = SettingsController.menu_volume;
			}
		}
		else if (num <= 3411634414U)
		{
			if (num != 3132903066U)
			{
				if (num == 3411634414U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Crowd")
					{
						gameSetting = SettingsController.volume_Stems[13];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Bass")
			{
				gameSetting = SettingsController.volume_Stems[1];
			}
		}
		else if (num != 3428315309U)
		{
			if (num != 4114373679U)
			{
				if (num == 4188053186U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Sound Effects")
					{
						gameSetting = SettingsController.sounds;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Guitar")
			{
				gameSetting = SettingsController.volume_Stems[0];
			}
		}
		else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Track Mute")
		{
			gameSetting = SettingsController.mute_volume;
		}
		return gameSetting;
	}

	public virtual void \u02BB\u02BC\u02B9\u02B2\u02BD\u02B3\u02BA\u02B7\u02B7\u02C0\u02B4(string \u02B4\u02B9\u02B3\u02B9\u02BC\u02C1\u02BE\u02BF\u02B4\u02B9\u02C0 = "")
	{
		this.\u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1.Clear();
		if (\u02B4\u02B9\u02B3\u02B9\u02BC\u02C1\u02BE\u02BF\u02B4\u02B9\u02C0 != string.Empty)
		{
			this.\u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1.Add(\u02B4\u02B9\u02B3\u02B9\u02BC\u02C1\u02BE\u02BF\u02B4\u02B9\u02C0);
		}
		else
		{
			this.\u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1.AddRange(this.menuStrings);
		}
		foreach (string text in this.\u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1)
		{
			GameSetting settingFromString = this.GetSettingFromString(text);
			uint num = PrivateImplementationDetails.ComputeStringHash(text);
			if (num <= 104U)
			{
				if (num <= 194U)
				{
					if (num <= 129U)
					{
						if (num != 94U)
						{
							if (num == 126U)
							{
								if (text == "")
								{
									this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = BassAudioManager.\u02B9\u02B2\u02B6\u02BB\u02B4\u02B7\u02B6\u02B5\u02B7\u02B2\u02BA(settingFromString.CurrentValue).ToString();
								}
							}
						}
						else if (text == "Get Hardware Latency")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(1, settingFromString);
						}
					}
					else if (num != 43U)
					{
						if (num == 4294967257U)
						{
							if (text == ".jpeg")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-26, settingFromString);
							}
						}
					}
					else if (text == "Preview Music")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(6, settingFromString);
					}
				}
				else if (num <= 45U)
				{
					if (num != 4294967272U)
					{
						if (num == 4294967104U)
						{
							if (text == "{0:N0}")
							{
								string text2;
								switch (SettingsController.latency_mode.CurrentValue)
								{
								case 0:
									text2 = "8EDC4F";
									break;
								case 1:
									text2 = "diff_rhythm";
									break;
								case 2:
									text2 = "Are you sure you want to skip this song?";
									break;
								default:
									text2 = "Tom3";
									break;
								}
								this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().GetString(text2);
							}
						}
					}
					else if (text == ")")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
					}
				}
				else if (num != 192U)
				{
					if (num == 37U)
					{
						if (text == "part guitar")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(3, settingFromString);
						}
					}
				}
				else if (text == "part guitar")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(3, settingFromString);
				}
			}
			else if (num <= 151U)
			{
				if (num <= 4294967113U)
				{
					if (num != 4294967136U)
					{
						if (num == 4294967159U)
						{
							if (text == "Intensity - Keys")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
							}
						}
					}
					else if (text == "")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-28, settingFromString);
					}
				}
				else if (num != 175U)
				{
					if (num == 4294967240U)
					{
						if (text == "Main Menu")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(2, settingFromString);
						}
					}
				}
				else if (text == "song")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-82, settingFromString);
				}
			}
			else if (num <= 4294967143U)
			{
				if (num != 4294967151U)
				{
					if (num == 4294967283U)
					{
						if (text == "Resolution")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(2, settingFromString);
						}
					}
				}
				else if (text == "Ready")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
				}
			}
			else if (num != 4294967243U)
			{
				if (num != 4294967211U)
				{
					if (num == 120U)
					{
						if (text == "diff_guitarghl")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-57, settingFromString);
						}
					}
				}
				else if (text == "Main Menu")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
				}
			}
			else if (text == "download source.txt finished")
			{
				base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-84, settingFromString);
			}
		}
	}

	private void \u02BD\u02BB\u02B5\u02B4\u02BF\u02B3\u02B3\u02B6\u02B4\u02B8\u02C1()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "")
		{
			BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(SettingsController.menu_volume.GetCurrentVolume);
			return;
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "#")
		{
			if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue == 0)
			{
				this.menuMusic.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(true);
			}
			BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetCurrentVolume);
		}
	}

	public virtual void \u02B4\u02BD\u02BB\u02BC\u02B6\u02BA\u02B8\u02BA\u02B3\u02B6\u02B2(string \u02B4\u02B9\u02B3\u02B9\u02BC\u02C1\u02BE\u02BF\u02B4\u02B9\u02C0 = "")
	{
		this.\u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1.Clear();
		if (\u02B4\u02B9\u02B3\u02B9\u02BC\u02C1\u02BE\u02BF\u02B4\u02B9\u02C0 != string.Empty)
		{
			this.\u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1.Add(\u02B4\u02B9\u02B3\u02B9\u02BC\u02C1\u02BE\u02BF\u02B4\u02B9\u02C0);
		}
		else
		{
			this.\u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1.AddRange(this.menuStrings);
		}
		foreach (string text in this.\u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1)
		{
			GameSetting settingFromString = this.GetSettingFromString(text);
			uint num = PrivateImplementationDetails.ComputeStringHash(text);
			if (num <= 4294967203U)
			{
				if (num <= 4294967253U)
				{
					if (num <= 98U)
					{
						if (num != 4294967248U)
						{
							if (num == 72U)
							{
								if (text == "fullserver")
								{
									this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = BassAudioManager.\u02B9\u02B2\u02B6\u02BB\u02B4\u02B7\u02B6\u02B5\u02B7\u02B2\u02BA(settingFromString.CurrentValue).ToString();
								}
							}
						}
						else if (text == "Respawn")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
						}
					}
					else if (num != 4294967111U)
					{
						if (num == 162U)
						{
							if (text == "Keys")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-27, settingFromString);
							}
						}
					}
					else if (text == "ModChart Full")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(7, settingFromString);
					}
				}
				else if (num <= 58U)
				{
					if (num != 16U)
					{
						if (num == 52U)
						{
							if (text == "Show Mouse Cursor")
							{
								string text2;
								switch (SettingsController.latency_mode.CurrentValue)
								{
								case 0:
									text2 = "";
									break;
								case 1:
									text2 = "'";
									break;
								case 2:
									text2 = "<color=#FFFF04FF>{0}</color> {1}";
									break;
								default:
									text2 = "Current Playlist";
									break;
								}
								this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().GetString(text2);
							}
						}
					}
					else if (text == "ui_lose_multiplier")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
					}
				}
				else if (num != 4294967260U)
				{
					if (num == 173U)
					{
						if (text == "setlistSongCountSingular")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(2, settingFromString);
						}
					}
				}
				else if (text == "Drum Pad Scrolling")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(6, settingFromString);
				}
			}
			else if (num <= 186U)
			{
				if (num <= 11U)
				{
					if (num != 141U)
					{
						if (num == 24U)
						{
							if (text == "iconCache")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(2, settingFromString);
							}
						}
					}
					else if (text == "Show Bot Score")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(3, settingFromString);
					}
				}
				else if (num != 4294967235U)
				{
					if (num == 4294967232U)
					{
						if (text == "GHLBass")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(0, settingFromString);
						}
					}
				}
				else if (text == "Practice Start Delay")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(96, settingFromString);
				}
			}
			else if (num <= 4294967101U)
			{
				if (num != 4294967133U)
				{
					if (num == 173U)
					{
						if (text == "")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(8, settingFromString);
						}
					}
				}
				else if (text == "Gameplay")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(7, settingFromString);
				}
			}
			else if (num != 101U)
			{
				if (num != 68U)
				{
					if (num == 100U)
					{
						if (text == "Drums Freestyle")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-31, settingFromString);
						}
					}
				}
				else if (text == "joinasplayer")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
				}
			}
			else if (text == "DiscordRPC: is now offline due to error")
			{
				base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(12, settingFromString);
			}
		}
	}

	protected virtual void \u02BB\u02BA\u02BE\u02B3\u02BA\u02B6\u02B9\u02B7\u02BD\u02BA\u02B3()
	{
		this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3);
		this.\u02BC\u02C1\u02C1\u02BB\u02BD\u02BF\u02BA\u02C1\u02C0\u02BF\u02BE();
	}

	[SerializeField]
	private MenuMusic menuMusic;

	private List<string> \u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1 = new List<string>();
}
