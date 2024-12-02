using System;
using System.Collections.Generic;
using StrikeCore;
using UnityEngine;

public class AudioSettingsMenu : BaseSettingMenu
{
	protected virtual GameSetting \u02BF\u02BF\u02BF\u02BB\u02C1\u02BF\u02B8\u02BC\u02BB\u02C1\u02C0(string \u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0)
	{
		GameSetting gameSetting = null;
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0);
		if (num <= 143U)
		{
			if (num <= 51U)
			{
				if (num <= 4294967295U)
				{
					if (num != 4294967134U)
					{
						if (num == 4294967208U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Enable")
							{
								gameSetting = SettingsController.\u02BE\u02BE\u02C0\u02BA\u02B8\u02B3\u02B4\u02C0\u02BD\u02B7\u02B8;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Test Velocity")
					{
						gameSetting = SettingsController.\u02BF\u02BD\u02B2\u02BE\u02BC\u02B5\u02B6\u02B5\u02B6\u02B9\u02BD;
					}
				}
				else if (num != 4294967165U)
				{
					if (num == 113U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Tom3")
						{
							gameSetting = SettingsController.\u02B8\u02B7\u02BF\u02B4\u02B3\u02BB\u02B6\u02BB\u02B7\u02B2\u02BD;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "8EDC4F")
				{
					gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[2];
				}
			}
			else if (num <= 58U)
			{
				if (num != 4294967106U)
				{
					if (num == 109U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Audio Offset")
						{
							gameSetting = SettingsController.\u02BD\u02BA\u02B3\u02B7\u02C0\u02C1\u02BB\u02B4\u02B9\u02BB\u02B3;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "diff_guitar_coop_ghl")
				{
					gameSetting = SettingsController.\u02B8\u02C1\u02B8\u02BC\u02B9\u02B2\u02BB\u02BB\u02B8\u02BD\u02B5;
				}
			}
			else if (num != 4294967119U)
			{
				if (num == 142U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "songs.txt")
					{
						gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[4];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "isSpectator")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[36];
			}
		}
		else if (num <= 4294967182U)
		{
			if (num <= 31U)
			{
				if (num != 138U)
				{
					if (num == 4294967230U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == " + ")
						{
							gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[50];
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == ": ")
				{
					gameSetting = SettingsController.\u02C1\u02BD\u02C0\u02B7\u02B3\u02C0\u02B7\u02B2\u02BF\u02BC\u02B7;
				}
			}
			else if (num != 148U)
			{
				if (num == 193U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "GHLBass")
					{
						gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[6];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "diff_guitar_coop")
			{
				gameSetting = SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF;
			}
		}
		else if (num <= 162U)
		{
			if (num != 4294967120U)
			{
				if (num == 4294967166U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == ".png")
					{
						gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[-10];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Dropless Sustains")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[0];
			}
		}
		else if (num != 4294967112U)
		{
			if (num != 4294967104U)
			{
				if (num == 4294967133U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "particles")
					{
						gameSetting = SettingsController.\u02C1\u02C1\u02B3\u02BD\u02B7\u02C1\u02B9\u02BB\u02B5\u02B4\u02BB;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "offsets")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[1];
			}
		}
		else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Yo dawg, I heard you like lanes so this activates lanes!")
		{
			gameSetting = SettingsController.\u02B9\u02B3\u02BD\u02B5\u02BB\u02C1\u02BE\u02B2\u02B3\u02B3\u02BB;
		}
		return gameSetting;
	}

	private void \u02B3\u02B7\u02BC\u02B7\u02B5\u02C1\u02C1\u02BC\u02BD\u02BB\u02C1()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Game Icons/")
		{
			BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume);
			return;
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Grains")
		{
			if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue == 0)
			{
				this.menuMusic.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(true);
			}
			BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetCurrentVolume);
		}
	}

	protected virtual GameSetting \u02C1\u02B6\u02BF\u02B8\u02C0\u02BB\u02B6\u02C0\u02B9\u02B5\u02B9(string \u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0)
	{
		GameSetting gameSetting = null;
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0);
		if (num <= 4294967288U)
		{
			if (num <= 4294967125U)
			{
				if (num <= 4294967148U)
				{
					if (num != 4294967210U)
					{
						if (num == 4294967255U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Game Mode")
							{
								gameSetting = SettingsController.\u02BE\u02BE\u02C0\u02BA\u02B8\u02B3\u02B4\u02C0\u02BD\u02B7\u02B8;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "song")
					{
						gameSetting = SettingsController.\u02BF\u02BD\u02B2\u02BE\u02BC\u02B5\u02B6\u02B5\u02B6\u02B9\u02BD;
					}
				}
				else if (num != 184U)
				{
					if (num == 199U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "stars")
						{
							gameSetting = SettingsController.\u02B8\u02B7\u02BF\u02B4\u02B3\u02BB\u02B6\u02BB\u02B7\u02B2\u02BD;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "")
				{
					gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[0];
				}
			}
			else if (num <= 4294967234U)
			{
				if (num != 72U)
				{
					if (num == 4294967173U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "-")
						{
							gameSetting = SettingsController.\u02BD\u02BA\u02B3\u02B7\u02C0\u02C1\u02BB\u02B4\u02B9\u02BB\u02B3;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "chartHash")
				{
					gameSetting = SettingsController.\u02B8\u02C1\u02B8\u02BC\u02B9\u02B2\u02BB\u02BB\u02B8\u02BD\u02B5;
				}
			}
			else if (num != 77U)
			{
				if (num == 8U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "isEOL")
					{
						gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[4];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "_y")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[-101];
			}
		}
		else if (num <= 4294967185U)
		{
			if (num <= 4294967241U)
			{
				if (num != 12U)
				{
					if (num == 48U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "")
						{
							gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[48];
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Keys")
				{
					gameSetting = SettingsController.\u02C1\u02BD\u02C0\u02B7\u02B3\u02C0\u02B7\u02B2\u02BF\u02BC\u02B7;
				}
			}
			else if (num != 99U)
			{
				if (num == 4294967294U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "song")
					{
						gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[1];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "https://online.clonehero.net/servers")
			{
				gameSetting = SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF;
			}
		}
		else if (num <= 4294967144U)
		{
			if (num != 197U)
			{
				if (num == 4294967290U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Hihat")
					{
						gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[82];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "songs")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[1];
			}
		}
		else if (num != 4294967142U)
		{
			if (num != 30U)
			{
				if (num == 4294967205U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Guitar Coop")
					{
						gameSetting = SettingsController.\u02C1\u02C1\u02B3\u02BD\u02B7\u02C1\u02B9\u02BB\u02B5\u02B4\u02BB;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "year")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[1];
			}
		}
		else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "{0}/{1}")
		{
			gameSetting = SettingsController.\u02B9\u02B3\u02BD\u02B5\u02BB\u02C1\u02BE\u02B2\u02B3\u02B3\u02BB;
		}
		return gameSetting;
	}

	protected virtual void \u02BD\u02BF\u02BA\u02B6\u02BE\u02C0\u02B7\u02C0\u02C1\u02BD\u02B9()
	{
		this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3);
		this.\u02B3\u02BC\u02B2\u02BB\u02B9\u02B3\u02B2\u02B4\u02C0\u02BF\u02B3();
	}

	protected override void \u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5()
	{
		this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3);
		this.\u02BC\u02C1\u02C1\u02BB\u02BD\u02BF\u02BA\u02C1\u02C0\u02BF\u02BE();
	}

	public virtual void \u02C0\u02C1\u02BB\u02B8\u02BF\u02C0\u02BC\u02B8\u02BF\u02B8\u02B4()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02B4\u02BA\u02B4\u02B2\u02B9\u02BF\u02BB\u02BE\u02B2\u02B9\u02B9;
			string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
			uint num = PrivateImplementationDetails.ComputeStringHash(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B);
			if (num <= 4294967172U)
			{
				if (num <= 175U)
				{
					if (num <= 152U)
					{
						if (num != 191U)
						{
							if (num == 41U)
							{
								if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BE\u02BE\u02C0\u02BA\u02B8\u02B3\u02B4\u02C0\u02BD\u02B7\u02B8;
								}
							}
						}
						else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Main Menu")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BF\u02BD\u02B2\u02BE\u02BC\u02B5\u02B6\u02B5\u02B6\u02B9\u02BD;
						}
					}
					else if (num != 159U)
					{
						if (num == 4294967251U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "SongPath ")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B8\u02B7\u02BF\u02B4\u02B3\u02BB\u02B6\u02BB\u02B7\u02B2\u02BD;
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "------------")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[2];
					}
				}
				else if (num <= 118U)
				{
					if (num != 4294967195U)
					{
						if (num == 161U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "BaseAnimationBackwards")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BD\u02BA\u02B3\u02B7\u02C0\u02C1\u02BB\u02B4\u02B9\u02BB\u02B3;
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Song Highways")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B8\u02C1\u02B8\u02BC\u02B9\u02B2\u02BB\u02BB\u02B8\u02BD\u02B5;
					}
				}
				else if (num != 4294967271U)
				{
					if (num == 4294967256U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Error while loading CLI chart")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[7];
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "All Strums")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[-58];
				}
			}
			else if (num <= 62U)
			{
				if (num <= 4294967177U)
				{
					if (num != 4294967109U)
					{
						if (num == 4294967244U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Main Menu")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[-49];
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Background Image")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02C1\u02BD\u02C0\u02B7\u02B3\u02C0\u02B7\u02B2\u02BF\u02BC\u02B7;
					}
				}
				else if (num != 152U)
				{
					if (num == 78U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Drums Freestyle")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[3];
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF;
				}
			}
			else if (num <= 4294967138U)
			{
				if (num != 37U)
				{
					if (num == 4294967233U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "PRESS START")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[48];
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "modchart")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[1];
				}
			}
			else if (num != 24U)
			{
				if (num != 4294967272U)
				{
					if (num == 114U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Ghost Notes")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02C1\u02C1\u02B3\u02BD\u02B7\u02C1\u02B9\u02BB\u02B5\u02B4\u02BB;
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "{}")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[0];
				}
			}
			else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "notes_ripple_up_01")
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B9\u02B3\u02BD\u02B5\u02BB\u02C1\u02BE\u02B2\u02B3\u02B3\u02BB;
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
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BE\u02BE\u02C0\u02BA\u02B8\u02B3\u02B4\u02C0\u02BD\u02B7\u02B8;
								}
							}
						}
						else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Whammy SFX")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BF\u02BD\u02B2\u02BE\u02BC\u02B5\u02B6\u02B5\u02B6\u02B9\u02BD;
						}
					}
					else if (num != 259185239U)
					{
						if (num == 559764484U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Preview Music")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B8\u02B7\u02BF\u02B4\u02B3\u02BB\u02B6\u02BB\u02B7\u02B2\u02BD;
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Vocals")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[3];
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
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BD\u02BA\u02B3\u02B7\u02C0\u02C1\u02BB\u02B4\u02B9\u02BB\u02B3;
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Master Volume")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B8\u02C1\u02B8\u02BC\u02B9\u02B2\u02BB\u02BB\u02B8\u02BD\u02B5;
					}
				}
				else if (num != 1613443821U)
				{
					if (num == 2242673754U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Drums")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[6];
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Keys")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[11];
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
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[12];
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Drums Freestyle")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02C1\u02BD\u02C0\u02B7\u02B3\u02C0\u02B7\u02B2\u02BF\u02BC\u02B7;
					}
				}
				else if (num != 2770175893U)
				{
					if (num == 3022894065U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Rhythm")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[2];
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Menu Music")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF;
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
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[13];
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Bass")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[1];
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
		this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02BD\u02BD\u02B6\u02C1\u02B6\u02BD\u02BA\u02B8\u02BE\u02BF\u02B9;
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public override void \u02B4\u02BF\u02B6\u02B3\u02B7\u02BA\u02B9\u02B9\u02BD\u02BD\u02B4()
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
			GameSetting gameSetting = this.\u02B9\u02B5\u02B5\u02B7\u02BE\u02BF\u02B6\u02B5\u02BB\u02B9\u02C1(text);
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
									this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = BassAudioManager.\u02B9\u02B2\u02B6\u02BB\u02B4\u02B7\u02B6\u02B5\u02B7\u02B2\u02BA(gameSetting.CurrentValue).ToString();
								}
							}
						}
						else if (text == "Whammy SFX")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, gameSetting);
						}
					}
					else if (num != 259185239U)
					{
						if (num == 559764484U)
						{
							if (text == "Preview Music")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(12, gameSetting);
							}
						}
					}
					else if (text == "Vocals")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(4, gameSetting);
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
								switch (SettingsController.\u02BD\u02BA\u02B3\u02B7\u02C0\u02C1\u02BB\u02B4\u02B9\u02BB\u02B3.CurrentValue)
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
								this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(text2);
							}
						}
					}
					else if (text == "Master Volume")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(0, gameSetting);
					}
				}
				else if (num != 1613443821U)
				{
					if (num == 2242673754U)
					{
						if (text == "Drums")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(5, gameSetting);
						}
					}
				}
				else if (text == "Keys")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(6, gameSetting);
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
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(7, gameSetting);
							}
						}
					}
					else if (text == "Drums Freestyle")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(9, gameSetting);
					}
				}
				else if (num != 2770175893U)
				{
					if (num == 3022894065U)
					{
						if (text == "Rhythm")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(3, gameSetting);
						}
					}
				}
				else if (text == "Menu Music")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(11, gameSetting);
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
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(8, gameSetting);
						}
					}
				}
				else if (text == "Bass")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(2, gameSetting);
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
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(10, gameSetting);
						}
					}
				}
				else if (text == "Guitar")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, gameSetting);
				}
			}
			else if (text == "Track Mute")
			{
				base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(13, gameSetting);
			}
		}
	}

	private void \u02B3\u02BC\u02B2\u02BB\u02B9\u02B3\u02B2\u02B4\u02C0\u02BF\u02B3()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "mute_on_miss")
		{
			BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume);
			return;
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Game Icons/")
		{
			if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue == 0)
			{
				this.menuMusic.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(true);
			}
			BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetCurrentVolume);
		}
	}

	protected override void \u02BA\u02B8\u02B4\u02BA\u02BD\u02BA\u02B7\u02C1\u02B8\u02B8\u02BC()
	{
	}

	private void \u02BC\u02C1\u02C1\u02BB\u02BD\u02BF\u02BA\u02C1\u02C0\u02BF\u02BE()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Master Volume")
		{
			BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume);
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

	protected virtual GameSetting \u02B5\u02B6\u02B5\u02B5\u02B2\u02B6\u02BD\u02BB\u02BA\u02B9\u02C0(string \u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0)
	{
		GameSetting gameSetting = null;
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0);
		if (num <= 131U)
		{
			if (num <= 99U)
			{
				if (num <= 4294967273U)
				{
					if (num != 58U)
					{
						if (num == 4294967259U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "sources.txt")
							{
								gameSetting = SettingsController.\u02BE\u02BE\u02C0\u02BA\u02B8\u02B3\u02B4\u02C0\u02BD\u02B7\u02B8;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "changesearchtip")
					{
						gameSetting = SettingsController.\u02BF\u02BD\u02B2\u02BE\u02BC\u02B5\u02B6\u02B5\u02B6\u02B9\u02BD;
					}
				}
				else if (num != 4294967242U)
				{
					if (num == 4294967294U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "drumsonglistGreenHoldTip")
						{
							gameSetting = SettingsController.\u02B8\u02B7\u02BF\u02B4\u02B3\u02BB\u02B6\u02BB\u02B7\u02B2\u02BD;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "coda")
				{
					gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[6];
				}
			}
			else if (num <= 143U)
			{
				if (num != 4294967271U)
				{
					if (num == 4294967172U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "")
						{
							gameSetting = SettingsController.\u02BD\u02BA\u02B3\u02B7\u02C0\u02C1\u02BB\u02B4\u02B9\u02BB\u02B3;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "GETTING FOLDERS...")
				{
					gameSetting = SettingsController.\u02B8\u02C1\u02B8\u02BC\u02B9\u02B2\u02BB\u02BB\u02B8\u02BD\u02B5;
				}
			}
			else if (num != 44U)
			{
				if (num == 4294967190U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "songBuiltIn")
					{
						gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[1];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Whammy SFX")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[54];
			}
		}
		else if (num <= 4294967156U)
		{
			if (num <= 4294967284U)
			{
				if (num != 4294967201U)
				{
					if (num == 65U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == " ")
						{
							gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[-96];
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "flames")
				{
					gameSetting = SettingsController.\u02C1\u02BD\u02C0\u02B7\u02B3\u02C0\u02B7\u02B2\u02BF\u02BC\u02B7;
				}
			}
			else if (num != 152U)
			{
				if (num == 174U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Cymbal2")
					{
						gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[1];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "")
			{
				gameSetting = SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF;
			}
		}
		else if (num <= 4294967273U)
		{
			if (num != 152U)
			{
				if (num == 27U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Modchart")
					{
						gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[111];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == " ")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[1];
			}
		}
		else if (num != 99U)
		{
			if (num != 4294967173U)
			{
				if (num == 99U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Are you sure?")
					{
						gameSetting = SettingsController.\u02C1\u02C1\u02B3\u02BD\u02B7\u02C1\u02B9\u02BB\u02B5\u02B4\u02BB;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "6 Fret Lead Guitar")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[0];
			}
		}
		else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Framerate")
		{
			gameSetting = SettingsController.\u02B9\u02B3\u02BD\u02B5\u02BB\u02C1\u02BE\u02B2\u02B3\u02B3\u02BB;
		}
		return gameSetting;
	}

	protected override GameSetting \u02B9\u02B5\u02B5\u02B7\u02BE\u02BF\u02B6\u02B5\u02BB\u02B9\u02C1(string \u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0)
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
								gameSetting = SettingsController.\u02BE\u02BE\u02C0\u02BA\u02B8\u02B3\u02B4\u02C0\u02BD\u02B7\u02B8;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Whammy SFX")
					{
						gameSetting = SettingsController.\u02BF\u02BD\u02B2\u02BE\u02BC\u02B5\u02B6\u02B5\u02B6\u02B9\u02BD;
					}
				}
				else if (num != 259185239U)
				{
					if (num == 559764484U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Preview Music")
						{
							gameSetting = SettingsController.\u02B8\u02B7\u02BF\u02B4\u02B3\u02BB\u02B6\u02BB\u02B7\u02B2\u02BD;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Vocals")
				{
					gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[3];
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
							gameSetting = SettingsController.\u02BD\u02BA\u02B3\u02B7\u02C0\u02C1\u02BB\u02B4\u02B9\u02BB\u02B3;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Master Volume")
				{
					gameSetting = SettingsController.\u02B8\u02C1\u02B8\u02BC\u02B9\u02B2\u02BB\u02BB\u02B8\u02BD\u02B5;
				}
			}
			else if (num != 1613443821U)
			{
				if (num == 2242673754U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Drums")
					{
						gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[6];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Keys")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[11];
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
							gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[12];
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Drums Freestyle")
				{
					gameSetting = SettingsController.\u02C1\u02BD\u02C0\u02B7\u02B3\u02C0\u02B7\u02B2\u02BF\u02BC\u02B7;
				}
			}
			else if (num != 2770175893U)
			{
				if (num == 3022894065U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Rhythm")
					{
						gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[2];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Menu Music")
			{
				gameSetting = SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF;
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
						gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[13];
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Bass")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[1];
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
						gameSetting = SettingsController.\u02C1\u02C1\u02B3\u02BD\u02B7\u02C1\u02B9\u02BB\u02B5\u02B4\u02BB;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Guitar")
			{
				gameSetting = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[0];
			}
		}
		else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Track Mute")
		{
			gameSetting = SettingsController.\u02B9\u02B3\u02BD\u02B5\u02BB\u02C1\u02BE\u02B2\u02B3\u02B3\u02BB;
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
			GameSetting gameSetting = this.\u02B9\u02B5\u02B5\u02B7\u02BE\u02BF\u02B6\u02B5\u02BB\u02B9\u02C1(text);
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
									this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = BassAudioManager.\u02B9\u02B2\u02B6\u02BB\u02B4\u02B7\u02B6\u02B5\u02B7\u02B2\u02BA(gameSetting.CurrentValue).ToString();
								}
							}
						}
						else if (text == "Get Hardware Latency")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(1, gameSetting);
						}
					}
					else if (num != 43U)
					{
						if (num == 4294967257U)
						{
							if (text == ".jpeg")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-26, gameSetting);
							}
						}
					}
					else if (text == "Preview Music")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(6, gameSetting);
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
								switch (SettingsController.\u02BD\u02BA\u02B3\u02B7\u02C0\u02C1\u02BB\u02B4\u02B9\u02BB\u02B3.CurrentValue)
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
								this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(text2);
							}
						}
					}
					else if (text == ")")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, gameSetting);
					}
				}
				else if (num != 192U)
				{
					if (num == 37U)
					{
						if (text == "part guitar")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(3, gameSetting);
						}
					}
				}
				else if (text == "part guitar")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(3, gameSetting);
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
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, gameSetting);
							}
						}
					}
					else if (text == "")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-28, gameSetting);
					}
				}
				else if (num != 175U)
				{
					if (num == 4294967240U)
					{
						if (text == "Main Menu")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(2, gameSetting);
						}
					}
				}
				else if (text == "song")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-82, gameSetting);
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
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(2, gameSetting);
						}
					}
				}
				else if (text == "Ready")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, gameSetting);
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
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-57, gameSetting);
						}
					}
				}
				else if (text == "Main Menu")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, gameSetting);
				}
			}
			else if (text == "download source.txt finished")
			{
				base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-84, gameSetting);
			}
		}
	}

	private void \u02BD\u02BB\u02B5\u02B4\u02BF\u02B3\u02B3\u02B6\u02B4\u02B8\u02C1()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "")
		{
			BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume);
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
			GameSetting gameSetting = this.\u02B9\u02B5\u02B5\u02B7\u02BE\u02BF\u02B6\u02B5\u02BB\u02B9\u02C1(text);
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
									this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = BassAudioManager.\u02B9\u02B2\u02B6\u02BB\u02B4\u02B7\u02B6\u02B5\u02B7\u02B2\u02BA(gameSetting.CurrentValue).ToString();
								}
							}
						}
						else if (text == "Respawn")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, gameSetting);
						}
					}
					else if (num != 4294967111U)
					{
						if (num == 162U)
						{
							if (text == "Keys")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-27, gameSetting);
							}
						}
					}
					else if (text == "ModChart Full")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(7, gameSetting);
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
								switch (SettingsController.\u02BD\u02BA\u02B3\u02B7\u02C0\u02C1\u02BB\u02B4\u02B9\u02BB\u02B3.CurrentValue)
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
								this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(text2);
							}
						}
					}
					else if (text == "ui_lose_multiplier")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, gameSetting);
					}
				}
				else if (num != 4294967260U)
				{
					if (num == 173U)
					{
						if (text == "setlistSongCountSingular")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(2, gameSetting);
						}
					}
				}
				else if (text == "Drum Pad Scrolling")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(6, gameSetting);
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
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(2, gameSetting);
							}
						}
					}
					else if (text == "Show Bot Score")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(3, gameSetting);
					}
				}
				else if (num != 4294967235U)
				{
					if (num == 4294967232U)
					{
						if (text == "GHLBass")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(0, gameSetting);
						}
					}
				}
				else if (text == "Practice Start Delay")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(96, gameSetting);
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
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(8, gameSetting);
						}
					}
				}
				else if (text == "Gameplay")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(7, gameSetting);
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
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(-31, gameSetting);
						}
					}
				}
				else if (text == "joinasplayer")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, gameSetting);
				}
			}
			else if (text == "DiscordRPC: is now offline due to error")
			{
				base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(12, gameSetting);
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
