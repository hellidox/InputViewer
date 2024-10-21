using System;
using StrikeCore;
using TMPro;
using UnityEngine;

// Token: 0x0200010A RID: 266
public class VolumeMenu : BaseSettingMenu
{
	// Token: 0x06000B3A RID: 2874 RVA: 0x0000B969 File Offset: 0x00009B69
	protected override void OnEnable()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("VOLUME");
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x0000AE8C File Offset: 0x0000908C
	public override void \u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1 = "")
	{
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x0000B98B File Offset: 0x00009B8B
	protected virtual void \u02B7\u02B7\u02B2\u02BD\u02B9\u02C0\u02C0\u02B5\u02B4\u02BB\u02B2()
	{
		BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(-1);
		BassAudioManager.Instance.\u02B2\u02BC\u02BD\u02BF\u02B2\u02BE\u02BA\u02BA\u02B3\u02C1\u02B8(-1);
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x0000B98B File Offset: 0x00009B8B
	protected virtual void \u02B7\u02B4\u02BD\u02BD\u02B6\u02BB\u02BF\u02BE\u02B4\u02B2\u02C0()
	{
		BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(-1);
		BassAudioManager.Instance.\u02B2\u02BC\u02BD\u02BF\u02B2\u02BE\u02BA\u02BA\u02B3\u02C1\u02B8(-1);
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x0000B9A3 File Offset: 0x00009BA3
	protected virtual void \u02B9\u02BE\u02BC\u02BE\u02BC\u02B9\u02B2\u02B3\u02BF\u02B2\u02BA()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Keys");
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x0000B98B File Offset: 0x00009B8B
	protected virtual void \u02B7\u02BF\u02B6\u02BF\u02BD\u02B3\u02B7\u02B4\u02B6\u02BE\u02B6()
	{
		BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(-1);
		BassAudioManager.Instance.\u02B2\u02BC\u02BD\u02BF\u02B2\u02BE\u02BA\u02BA\u02B3\u02C1\u02B8(-1);
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x00064978 File Offset: 0x00062B78
	public virtual void \u02BA\u02B4\u02C0\u02B9\u02BF\u02B8\u02B7\u02B7\u02BA\u02BE\u02BB()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
			string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
			uint num = PrivateImplementationDetails.ComputeStringHash(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B);
			if (num <= 160U)
			{
				if (num <= 28U)
				{
					if (num != 4294967102U)
					{
						if (num != 89U)
						{
							if (num == 4294967273U)
							{
								if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "practice_delay")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[94];
								}
							}
						}
						else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "com.unity3d.player.UnityPlayer")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B8\u02C1\u02B8\u02BC\u02B9\u02B2\u02BB\u02BB\u02B8\u02BD\u02B5;
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Respawn")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[3];
					}
				}
				else if (num != 4294967125U)
				{
					if (num != 154U)
					{
						if (num == 4294967238U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Whammy SFX")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[21];
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "chartHash")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02C1\u02BD\u02C0\u02B7\u02B3\u02C0\u02B7\u02B2\u02BF\u02BC\u02B7;
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "MIDI Input Manager instance already present.")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[1];
				}
			}
			else if (num <= 77U)
			{
				if (num != 80U)
				{
					if (num != 9U)
					{
						if (num == 44U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "This will take a while. Are you sure?")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[-83];
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Versus")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[0];
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[7];
				}
			}
			else if (num != 4294967101U)
			{
				if (num != 4294967262U)
				{
					if (num == 136U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == ".png|.jpg|.jpeg")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02C1\u02C1\u02B3\u02BD\u02B7\u02C1\u02B9\u02BB\u02B5\u02B4\u02BB;
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Yes")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[0];
				}
			}
			else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "test.ini")
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B9\u02B3\u02BD\u02B5\u02BB\u02C1\u02BE\u02B2\u02B3\u02B3\u02BB;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		this.\u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1();
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x00064C2C File Offset: 0x00062E2C
	protected override void \u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5()
	{
		string getPercentString = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetPercentString;
		this.textObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3].text = getPercentString;
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x0000B9C5 File Offset: 0x00009BC5
	protected virtual void \u02B9\u02B7\u02C0\u02B7\u02C1\u02BA\u02BC\u02C0\u02C1\u02BD\u02B6()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("");
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x00064C58 File Offset: 0x00062E58
	protected override GameSetting \u02B9\u02B5\u02B5\u02B7\u02BE\u02BF\u02B6\u02B5\u02BB\u02B9\u02C1(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1)
	{
		GameSetting gameSetting = null;
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		uint num = PrivateImplementationDetails.ComputeStringHash(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B);
		if (num <= 2441828660U)
		{
			if (num <= 1613443821U)
			{
				if (num != 259185239U)
				{
					if (num != 704539491U)
					{
						if (num == 1613443821U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Keys")
							{
								gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[11];
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Master Volume")
					{
						gameSetting = SettingsController.\u02B8\u02C1\u02B8\u02BC\u02B9\u02B2\u02BB\u02BB\u02B8\u02BD\u02B5;
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Vocals")
				{
					gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[3];
				}
			}
			else if (num != 2242673754U)
			{
				if (num != 2332143585U)
				{
					if (num == 2441828660U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Song")
						{
							gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[12];
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Drums Freestyle")
				{
					gameSetting = SettingsController.\u02C1\u02BD\u02C0\u02B7\u02B3\u02C0\u02B7\u02B2\u02BF\u02BC\u02B7;
				}
			}
			else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Drums")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[6];
			}
		}
		else if (num <= 3411634414U)
		{
			if (num != 3022894065U)
			{
				if (num != 3132903066U)
				{
					if (num == 3411634414U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Crowd")
						{
							gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[13];
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Bass")
				{
					gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[1];
				}
			}
			else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Rhythm")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[2];
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
						gameSetting = SettingsController.\u02C1\u02C1\u02B3\u02BD\u02B7\u02C1\u02B9\u02BB\u02B5\u02B4\u02BB;
					}
				}
			}
			else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Guitar")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[0];
			}
		}
		else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Track Mute")
		{
			gameSetting = SettingsController.\u02B9\u02B3\u02BD\u02B5\u02BB\u02C1\u02BE\u02B2\u02B3\u02B3\u02BB;
		}
		return gameSetting;
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x0000B98B File Offset: 0x00009B8B
	protected virtual void \u02B2\u02C1\u02BA\u02BE\u02BA\u02B8\u02B2\u02C0\u02B4\u02B5\u02B3()
	{
		BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(-1);
		BassAudioManager.Instance.\u02B2\u02BC\u02BD\u02BF\u02B2\u02BE\u02BA\u02BA\u02B3\u02C1\u02B8(-1);
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x0000AE53 File Offset: 0x00009053
	protected virtual void \u02B7\u02BF\u02BC\u02C0\u02B5\u02BD\u02BF\u02BB\u02C1\u02BF\u02B2()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = true;
		base.Awake();
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x00005F91 File Offset: 0x00004191
	public override void \u02B4\u02BF\u02B6\u02B3\u02B7\u02BA\u02B9\u02B9\u02BD\u02BD\u02B4()
	{
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x00064C2C File Offset: 0x00062E2C
	protected virtual void \u02C0\u02BF\u02B9\u02BA\u02BA\u02B5\u02B6\u02B5\u02BE\u02B3\u02B3()
	{
		string getPercentString = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetPercentString;
		this.textObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3].text = getPercentString;
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x0000B9E7 File Offset: 0x00009BE7
	protected virtual void \u02B3\u02BC\u02BB\u02BF\u02C1\u02BE\u02B4\u02BC\u02BE\u02BF\u02B8()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("triedGraphicsSwitch");
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x00064E80 File Offset: 0x00063080
	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
			uint num = PrivateImplementationDetails.ComputeStringHash(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B);
			if (num <= 2441828660U)
			{
				if (num <= 1613443821U)
				{
					if (num != 259185239U)
					{
						if (num != 704539491U)
						{
							if (num == 1613443821U)
							{
								if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Keys")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[11];
								}
							}
						}
						else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Master Volume")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B8\u02C1\u02B8\u02BC\u02B9\u02B2\u02BB\u02BB\u02B8\u02BD\u02B5;
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Vocals")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[3];
					}
				}
				else if (num != 2242673754U)
				{
					if (num != 2332143585U)
					{
						if (num == 2441828660U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Song")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[12];
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Drums Freestyle")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02C1\u02BD\u02C0\u02B7\u02B3\u02C0\u02B7\u02B2\u02BF\u02BC\u02B7;
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Drums")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[6];
				}
			}
			else if (num <= 3411634414U)
			{
				if (num != 3022894065U)
				{
					if (num != 3132903066U)
					{
						if (num == 3411634414U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Crowd")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[13];
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Bass")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[1];
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Rhythm")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[2];
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
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02C1\u02C1\u02B3\u02BD\u02B7\u02C1\u02B9\u02BB\u02B5\u02B4\u02BB;
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Guitar")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[0];
				}
			}
			else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Track Mute")
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B9\u02B3\u02BD\u02B5\u02BB\u02C1\u02BE\u02B2\u02B3\u02B3\u02BB;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		this.\u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1();
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x0000BA09 File Offset: 0x00009C09
	protected virtual void \u02BF\u02B8\u02B8\u02B6\u02B9\u02B4\u02BB\u02B6\u02BC\u02BA\u02BF()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = false;
		base.Awake();
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x0000AE53 File Offset: 0x00009053
	protected virtual void \u02BF\u02B2\u02C1\u02C1\u02B6\u02BE\u02B3\u02BD\u02B8\u02B3\u02BE()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = true;
		base.Awake();
	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x0000B98B File Offset: 0x00009B8B
	protected override void \u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1()
	{
		BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(-1);
		BassAudioManager.Instance.\u02B2\u02BC\u02BD\u02BF\u02B2\u02BE\u02BA\u02BA\u02B3\u02C1\u02B8(-1);
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x0000AE8C File Offset: 0x0000908C
	public virtual void \u02B4\u02B8\u02BA\u02B5\u02BB\u02B2\u02C1\u02B5\u02B8\u02BC\u02B5(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1 = "")
	{
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x00005F91 File Offset: 0x00004191
	protected override void \u02BA\u02B8\u02B4\u02BA\u02BD\u02BA\u02B7\u02C1\u02B8\u02B8\u02BC()
	{
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x0000AE8C File Offset: 0x0000908C
	public virtual void \u02B4\u02BD\u02BB\u02BC\u02B6\u02BA\u02B8\u02BA\u02B3\u02B6\u02B2(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1 = "")
	{
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x0000BA18 File Offset: 0x00009C18
	protected virtual void \u02B7\u02B9\u02B6\u02BB\u02BF\u02BB\u02BF\u02BD\u02B6\u02B9\u02C1()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("\\");
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x0000AE53 File Offset: 0x00009053
	protected override void Awake()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = true;
		base.Awake();
	}

	// Token: 0x04000829 RID: 2089
	[SerializeField]
	private TextMeshProUGUI pausedText;
}
