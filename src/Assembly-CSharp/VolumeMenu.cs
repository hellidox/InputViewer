using System;
using StrikeCore;
using TMPro;
using UnityEngine;

public class VolumeMenu : BaseSettingMenu
{
	protected override void OnEnable()
	{
		base.OnEnable();
		this.pausedText.text = LanguageManager.instance.GetString("VOLUME");
	}

	public override void \u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1 = "")
	{
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	protected virtual void \u02B7\u02B7\u02B2\u02BD\u02B9\u02C0\u02C0\u02B5\u02B4\u02BB\u02B2()
	{
		BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(-1);
		BassAudioManager.Instance.\u02B2\u02BC\u02BD\u02BF\u02B2\u02BE\u02BA\u02BA\u02B3\u02C1\u02B8(-1);
	}

	protected virtual void \u02B7\u02B4\u02BD\u02BD\u02B6\u02BB\u02BF\u02BE\u02B4\u02B2\u02C0()
	{
		BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(-1);
		BassAudioManager.Instance.\u02B2\u02BC\u02BD\u02BF\u02B2\u02BE\u02BA\u02BA\u02B3\u02C1\u02B8(-1);
	}

	protected virtual void \u02B9\u02BE\u02BC\u02BE\u02BC\u02B9\u02B2\u02B3\u02BF\u02B2\u02BA()
	{
		base.OnEnable();
		this.pausedText.text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().GetString("Keys");
	}

	protected virtual void \u02B7\u02BF\u02B6\u02BF\u02BD\u02B3\u02B7\u02B4\u02B6\u02BE\u02B6()
	{
		BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(-1);
		BassAudioManager.Instance.\u02B2\u02BC\u02BD\u02BF\u02B2\u02BE\u02BA\u02BA\u02B3\u02C1\u02B8(-1);
	}

	public virtual void \u02BA\u02B4\u02C0\u02B9\u02BF\u02B8\u02B7\u02B7\u02BA\u02BE\u02BB()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (this.changedSetting == null)
		{
			this.changedSetting = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
			string changedSetting = this.changedSetting;
			uint num = PrivateImplementationDetails.ComputeStringHash(changedSetting);
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
								if (changedSetting == "practice_delay")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[94];
								}
							}
						}
						else if (changedSetting == "com.unity3d.player.UnityPlayer")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.master_volume;
						}
					}
					else if (changedSetting == "Respawn")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[3];
					}
				}
				else if (num != 4294967125U)
				{
					if (num != 154U)
					{
						if (num == 4294967238U)
						{
							if (changedSetting == "Whammy SFX")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[21];
							}
						}
					}
					else if (changedSetting == "chartHash")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.freestyle_drums;
					}
				}
				else if (changedSetting == "MIDI Input Manager instance already present.")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[1];
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
							if (changedSetting == "This will take a while. Are you sure?")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[-83];
							}
						}
					}
					else if (changedSetting == "Versus")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[0];
					}
				}
				else if (changedSetting == "")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[7];
				}
			}
			else if (num != 4294967101U)
			{
				if (num != 4294967262U)
				{
					if (num == 136U)
					{
						if (changedSetting == ".png|.jpg|.jpeg")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.sounds;
						}
					}
				}
				else if (changedSetting == "Yes")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[0];
				}
			}
			else if (changedSetting == "test.ini")
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.mute_volume;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		this.\u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1();
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.changedSetting = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	protected override void \u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5()
	{
		string getPercentString = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetPercentString;
		this.textObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3].text = getPercentString;
	}

	protected virtual void \u02B9\u02B7\u02C0\u02B7\u02C1\u02BA\u02BC\u02C0\u02C1\u02BD\u02B6()
	{
		base.OnEnable();
		this.pausedText.text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().GetString("");
	}

	protected override GameSetting GetSettingFromString(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1)
	{
		GameSetting gameSetting = null;
		string changedSetting = this.changedSetting;
		uint num = PrivateImplementationDetails.ComputeStringHash(changedSetting);
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
							if (changedSetting == "Keys")
							{
								gameSetting = SettingsController.volume_Stems[11];
							}
						}
					}
					else if (changedSetting == "Master Volume")
					{
						gameSetting = SettingsController.master_volume;
					}
				}
				else if (changedSetting == "Vocals")
				{
					gameSetting = SettingsController.volume_Stems[3];
				}
			}
			else if (num != 2242673754U)
			{
				if (num != 2332143585U)
				{
					if (num == 2441828660U)
					{
						if (changedSetting == "Song")
						{
							gameSetting = SettingsController.volume_Stems[12];
						}
					}
				}
				else if (changedSetting == "Drums Freestyle")
				{
					gameSetting = SettingsController.freestyle_drums;
				}
			}
			else if (changedSetting == "Drums")
			{
				gameSetting = SettingsController.volume_Stems[6];
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
						if (changedSetting == "Crowd")
						{
							gameSetting = SettingsController.volume_Stems[13];
						}
					}
				}
				else if (changedSetting == "Bass")
				{
					gameSetting = SettingsController.volume_Stems[1];
				}
			}
			else if (changedSetting == "Rhythm")
			{
				gameSetting = SettingsController.volume_Stems[2];
			}
		}
		else if (num != 3428315309U)
		{
			if (num != 4114373679U)
			{
				if (num == 4188053186U)
				{
					if (changedSetting == "Sound Effects")
					{
						gameSetting = SettingsController.sounds;
					}
				}
			}
			else if (changedSetting == "Guitar")
			{
				gameSetting = SettingsController.volume_Stems[0];
			}
		}
		else if (changedSetting == "Track Mute")
		{
			gameSetting = SettingsController.mute_volume;
		}
		return gameSetting;
	}

	protected virtual void \u02B2\u02C1\u02BA\u02BE\u02BA\u02B8\u02B2\u02C0\u02B4\u02B5\u02B3()
	{
		BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(-1);
		BassAudioManager.Instance.\u02B2\u02BC\u02BD\u02BF\u02B2\u02BE\u02BA\u02BA\u02B3\u02C1\u02B8(-1);
	}

	protected virtual void \u02B7\u02BF\u02BC\u02C0\u02B5\u02BD\u02BF\u02BB\u02C1\u02BF\u02B2()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = true;
		base.Awake();
	}

	public override void SetBools()
	{
	}

	protected virtual void \u02C0\u02BF\u02B9\u02BA\u02BA\u02B5\u02B6\u02B5\u02BE\u02B3\u02B3()
	{
		string getPercentString = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetPercentString;
		this.textObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3].text = getPercentString;
	}

	protected virtual void \u02B3\u02BC\u02BB\u02BF\u02C1\u02BE\u02B4\u02BC\u02BE\u02BF\u02B8()
	{
		base.OnEnable();
		this.pausedText.text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("triedGraphicsSwitch");
	}

	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (this.changedSetting == null)
		{
			this.changedSetting = base.currentSelectionString;
			string changedSetting = this.changedSetting;
			uint num = PrivateImplementationDetails.ComputeStringHash(changedSetting);
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
								if (changedSetting == "Keys")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[11];
								}
							}
						}
						else if (changedSetting == "Master Volume")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.master_volume;
						}
					}
					else if (changedSetting == "Vocals")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[3];
					}
				}
				else if (num != 2242673754U)
				{
					if (num != 2332143585U)
					{
						if (num == 2441828660U)
						{
							if (changedSetting == "Song")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[12];
							}
						}
					}
					else if (changedSetting == "Drums Freestyle")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.freestyle_drums;
					}
				}
				else if (changedSetting == "Drums")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[6];
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
							if (changedSetting == "Crowd")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[13];
							}
						}
					}
					else if (changedSetting == "Bass")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[1];
					}
				}
				else if (changedSetting == "Rhythm")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[2];
				}
			}
			else if (num != 3428315309U)
			{
				if (num != 4114373679U)
				{
					if (num == 4188053186U)
					{
						if (changedSetting == "Sound Effects")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.sounds;
						}
					}
				}
				else if (changedSetting == "Guitar")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.volume_Stems[0];
				}
			}
			else if (changedSetting == "Track Mute")
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.mute_volume;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		this.\u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1();
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.changedSetting = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	protected virtual void \u02BF\u02B8\u02B8\u02B6\u02B9\u02B4\u02BB\u02B6\u02BC\u02BA\u02BF()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = false;
		base.Awake();
	}

	protected virtual void \u02BF\u02B2\u02C1\u02C1\u02B6\u02BE\u02B3\u02BD\u02B8\u02B3\u02BE()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = true;
		base.Awake();
	}

	protected override void \u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1()
	{
		BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(-1);
		BassAudioManager.Instance.\u02B2\u02BC\u02BD\u02BF\u02B2\u02BE\u02BA\u02BA\u02B3\u02C1\u02B8(-1);
	}

	public virtual void \u02B4\u02B8\u02BA\u02B5\u02BB\u02B2\u02C1\u02B5\u02B8\u02BC\u02B5(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1 = "")
	{
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	protected override void \u02BA\u02B8\u02B4\u02BA\u02BD\u02BA\u02B7\u02C1\u02B8\u02B8\u02BC()
	{
	}

	public virtual void \u02B4\u02BD\u02BB\u02BC\u02B6\u02BA\u02B8\u02BA\u02B3\u02B6\u02B2(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1 = "")
	{
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	protected virtual void \u02B7\u02B9\u02B6\u02BB\u02BF\u02BB\u02BF\u02BD\u02B6\u02B9\u02C1()
	{
		base.OnEnable();
		this.pausedText.text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("\\");
	}

	protected override void Awake()
	{
		this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0 = true;
		base.Awake();
	}

	[SerializeField]
	private TextMeshProUGUI pausedText;
}
