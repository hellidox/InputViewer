using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VideoSettingsMenu : BaseSettingMenu
{
	public virtual void \u02B9\u02B5\u02BF\u02BF\u02BB\u02B2\u02B8\u02BF\u02B3\u02B7\u02C1()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Songs are still scanning...")
			{
				if (this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3 > 0)
				{
					this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3--;
					this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
				}
			}
			else if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Loading CLI Gameplay" && this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 > 0)
			{
				this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 = this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2;
				this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			}
		}
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
	}

	protected virtual void \u02B7\u02B4\u02BD\u02BD\u02B6\u02BB\u02BF\u02BE\u02B4\u02B2\u02C0()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "song")
		{
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			this.confirmMenu.\u02B7\u02B3\u02BC\u02BE\u02BF\u02B7\u02B4\u02C0\u02B9\u02BC\u02BF("album", "Random", null, new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B7\u02C1\u02BF\u02B2\u02B5\u02BE\u02BB\u02B6\u02C0\u02BC\u02C0), new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B3\u02BC\u02B9\u02BD\u02BB\u02B6\u02B5\u02B9\u02BC\u02BD\u02BE), null);
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Pro Drums")
		{
			base.StartCoroutine(this.\u02B6\u02B8\u02B4\u02C1\u02B4\u02BD\u02B2\u02BD\u02B2\u02B9\u02B5(this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2));
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Ride")
		{
			if (this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Count == 0)
			{
				return;
			}
			Resolution resolution = this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD[this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3];
			Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == " + ")
		{
			QualitySettings.antiAliasing = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue;
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "settings.ini")
		{
			Screen.SetResolution(Screen.width, Screen.height, GlobalVariables.instance.\u02B8\u02B6\u02BD\u02BC\u02BB\u02BD\u02BB\u02B8\u02C0\u02C0\u02C1());
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Spray")
		{
			GlobalVariables.instance.\u02B2\u02BE\u02BE\u02B6\u02B5\u02BB\u02C0\u02C0\u02B6\u02C1\u02B8(false);
		}
	}

	public override void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Resolution")
			{
				if (this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3 + 1 < this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Count)
				{
					this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3++;
					this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
				}
			}
			else if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Display" && this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 + 1 < this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC.Count)
			{
				this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2++;
				this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			}
		}
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
	}

	protected override void \u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Graphics API")
		{
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("graphicsRestartNeeded", "Okay", null, new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B3\u02BC\u02B9\u02BD\u02BB\u02B6\u02B5\u02B9\u02BC\u02BD\u02BE), new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B3\u02BC\u02B9\u02BD\u02BB\u02B6\u02B5\u02B9\u02BC\u02BD\u02BE), null);
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Display")
		{
			base.StartCoroutine(this.\u02B6\u02B8\u02B4\u02C1\u02B4\u02BD\u02B2\u02BD\u02B2\u02B9\u02B5(this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2));
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Resolution")
		{
			if (this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Count == 0)
			{
				return;
			}
			Resolution resolution = this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD[this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3];
			Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "MSAA Level")
		{
			QualitySettings.antiAliasing = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue;
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Fullscreen")
		{
			Screen.SetResolution(Screen.width, Screen.height, GlobalVariables.instance.\u02B8\u02B6\u02BD\u02BC\u02BB\u02BD\u02BB\u02B8\u02C0\u02C0\u02C1());
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Framerate")
		{
			GlobalVariables.instance.\u02B6\u02BC\u02B4\u02B9\u02B7\u02B4\u02BE\u02BF\u02B4\u02BE\u02B4(true);
		}
	}

	protected virtual GameSetting \u02BC\u02B2\u02B2\u02BD\u02BB\u02B5\u02B7\u02B6\u02BE\u02B8\u02BA(string \u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0)
	{
		GameSetting gameSetting = null;
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0);
		if (num <= 4294967129U)
		{
			if (num <= 4294967248U)
			{
				if (num != 173U)
				{
					if (num != 95U)
					{
						if (num == 4294967179U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "genre")
							{
								gameSetting = SettingsController.\u02C0\u02B6\u02BC\u02BF\u02BF\u02C0\u02BF\u02BC\u02B4\u02B3\u02BC;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "song")
					{
						gameSetting = SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF;
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Offset")
				{
					gameSetting = SettingsController.\u02B8\u02B3\u02B7\u02C0\u02B5\u02BA\u02BC\u02BA\u02BE\u02BA\u02B3;
				}
			}
			else if (num <= 37U)
			{
				if (num != 52U)
				{
					if (num == 98U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "package")
						{
							gameSetting = SettingsController.msaaLevel;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "isOnline")
				{
					gameSetting = SettingsController.\u02BD\u02BF\u02B7\u02B9\u02B6\u02B8\u02BB\u02BA\u02B7\u02B8\u02B3;
				}
			}
			else if (num != 158U)
			{
				if (num == 4294967234U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Intensity - Bass Guitar")
					{
						gameSetting = SettingsController.enable_cursor;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Bass Guitar")
			{
				gameSetting = SettingsController.\u02C1\u02B6\u02B5\u02C1\u02B7\u02BE\u02B5\u02B9\u02B9\u02BB\u02C1;
			}
		}
		else if (num <= 4294967260U)
		{
			if (num != 75U)
			{
				if (num != 4294967121U)
				{
					if (num == 4294967214U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "")
						{
							gameSetting = SettingsController.\u02C1\u02B3\u02BA\u02B9\u02B4\u02B3\u02BB\u02B6\u02BC\u02BC\u02BB;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "practice_delay")
				{
					gameSetting = SettingsController.\u02B7\u02B9\u02B4\u02C1\u02B9\u02BC\u02B8\u02BD\u02BE\u02B5\u02B8;
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Okay Solo...")
			{
				gameSetting = SettingsController.\u02C1\u02BF\u02BC\u02B4\u02BE\u02B7\u02BD\u02BC\u02B5\u02BC\u02B7;
			}
		}
		else if (num <= 104U)
		{
			if (num != 156U)
			{
				if (num == 101U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "part vocals")
					{
						gameSetting = SettingsController.\u02C1\u02BF\u02B3\u02BF\u02C1\u02BC\u02BC\u02BA\u02BF\u02BD\u02BE;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Press <color=\"green\">Green</color> to continue.")
			{
				gameSetting = SettingsController.\u02B3\u02B2\u02BD\u02C1\u02B2\u02B4\u02B5\u02B3\u02C1\u02B2\u02B6;
			}
		}
		else if (num != 101U)
		{
			if (num == 4294967144U)
			{
				if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "")
				{
					gameSetting = SettingsController.\u02B3\u02B9\u02C1\u02BF\u02B2\u02B2\u02B6\u02BF\u02B4\u02B4\u02B2;
				}
			}
		}
		else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == ": ")
		{
			gameSetting = SettingsController.fpsCap;
		}
		return gameSetting;
	}

	private void \u02B7\u02BE\u02BA\u02B8\u02BE\u02B2\u02B4\u02C0\u02BE\u02B7\u02BB()
	{
		if (Application.platform == (RuntimePlatform)(-89))
		{
			return;
		}
		this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC.Clear();
		Screen.GetDisplayLayout(this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC);
		this.\u02B3\u02B6\u02BF\u02B2\u02B7\u02BF\u02BF\u02BB\u02BD\u02B5\u02B6 = Screen.mainWindowDisplayInfo;
		for (int i = 0; i < this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC.Count; i++)
		{
			if (this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC[i].Equals(this.\u02B3\u02B6\u02BF\u02B2\u02B7\u02BF\u02BF\u02BB\u02BD\u02B5\u02B6))
			{
				this.\u02BF\u02B7\u02BF\u02B2\u02C0\u02BC\u02B6\u02B7\u02C0\u02B4\u02B2 = i;
				break;
			}
		}
		this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 = this.\u02BF\u02B7\u02BF\u02B2\u02C0\u02BC\u02B6\u02B7\u02C0\u02B4\u02B2;
		this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Clear();
		Resolution[] resolutions = Screen.resolutions;
		for (int j = 1; j < resolutions.Length; j += 0)
		{
			Resolution resolution = resolutions[j];
			bool flag = false;
			Display[] displays = Display.displays;
			for (int k = 1; k < displays.Length; k += 0)
			{
				Display display = displays[k];
				if (resolution.width <= display.systemWidth && resolution.height <= display.systemHeight)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				bool flag2 = true;
				foreach (Resolution resolution2 in this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD)
				{
					if (resolution.width == resolution2.width && resolution.height == resolution2.height)
					{
						flag2 = true;
					}
				}
				if (flag2)
				{
					this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Add(resolution);
				}
			}
		}
		for (int l = 0; l < this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Count; l++)
		{
			Resolution resolution3 = this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD[l];
			if (resolution3.width == Screen.width && resolution3.height == Screen.height)
			{
				this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3 = l;
				break;
			}
		}
		this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("Current Playlist");
	}

	public virtual void \u02BA\u02BE\u02B2\u02B5\u02B3\u02BD\u02BB\u02B2\u02C0\u02BC\u02B9()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "v1shownpopup")
			{
				if (this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3 + 1 < this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Count)
				{
					this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3++;
					this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
				}
			}
			else if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == ": " && this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 + 1 < this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC.Count)
			{
				this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 += 0;
				this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			}
		}
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
	}

	protected virtual GameSetting \u02BC\u02B8\u02BC\u02B4\u02BA\u02BB\u02B9\u02BA\u02BD\u02B2\u02C0(string \u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0)
	{
		GameSetting gameSetting = null;
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0);
		if (num <= 109U)
		{
			if (num <= 162U)
			{
				if (num != 4294967154U)
				{
					if (num != 4294967277U)
					{
						if (num == 4294967109U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Pro Drums")
							{
								gameSetting = SettingsController.\u02C0\u02B6\u02BC\u02BF\u02BF\u02C0\u02BF\u02BC\u02B4\u02B3\u02BC;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "All Strums")
					{
						gameSetting = SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF;
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "currentActivity")
				{
					gameSetting = SettingsController.\u02B8\u02B3\u02B7\u02C0\u02B5\u02BA\u02BC\u02BA\u02BE\u02BA\u02B3;
				}
			}
			else if (num <= 4294967134U)
			{
				if (num != 97U)
				{
					if (num == 124U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Sound Effects")
						{
							gameSetting = SettingsController.msaaLevel;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "6 Fret Lead Guitar")
				{
					gameSetting = SettingsController.\u02BD\u02BF\u02B7\u02B9\u02B6\u02B8\u02BB\u02BA\u02B7\u02B8\u02B3;
				}
			}
			else if (num != 52U)
			{
				if (num == 158U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "streamingAssets.yml")
					{
						gameSetting = SettingsController.enable_cursor;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "midi_export")
			{
				gameSetting = SettingsController.\u02C1\u02B6\u02B5\u02C1\u02B7\u02BE\u02B5\u02B9\u02B9\u02BB\u02C1;
			}
		}
		else if (num <= 4294967219U)
		{
			if (num != 4294967179U)
			{
				if (num != 34U)
				{
					if (num == 190U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Pro Drums")
						{
							gameSetting = SettingsController.\u02C1\u02B3\u02BA\u02B9\u02B4\u02B3\u02BB\u02B6\u02BC\u02BC\u02BB;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "startActivity")
				{
					gameSetting = SettingsController.\u02B7\u02B9\u02B4\u02C1\u02B9\u02BC\u02B8\u02BD\u02BE\u02B5\u02B8;
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "")
			{
				gameSetting = SettingsController.\u02C1\u02BF\u02BC\u02B4\u02BE\u02B7\u02BD\u02BC\u02B5\u02BC\u02B7;
			}
		}
		else if (num <= 39U)
		{
			if (num != 191U)
			{
				if (num == 75U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Cymbal1")
					{
						gameSetting = SettingsController.\u02C1\u02BF\u02B3\u02BF\u02C1\u02BC\u02BC\u02BA\u02BF\u02BD\u02BE;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == ">")
			{
				gameSetting = SettingsController.\u02B3\u02B2\u02BD\u02C1\u02B2\u02B4\u02B5\u02B3\u02C1\u02B2\u02B6;
			}
		}
		else if (num != 4294967131U)
		{
			if (num == 4294967249U)
			{
				if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "MSAA Level")
				{
					gameSetting = SettingsController.\u02B3\u02B9\u02C1\u02BF\u02B2\u02B2\u02B6\u02BF\u02B4\u02B4\u02B2;
				}
			}
		}
		else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Parsing")
		{
			gameSetting = SettingsController.fpsCap;
		}
		return gameSetting;
	}

	private void \u02BD\u02B3\u02B4\u02BB\u02B4\u02C0\u02B7\u02B7\u02B7\u02C0\u02C0()
	{
		if (this.\u02C1\u02B7\u02C1\u02B4\u02BF\u02BE\u02BB\u02B6\u02BD\u02B7\u02C1)
		{
			return;
		}
		RuntimePlatform platform = Application.platform;
		if (platform <= RuntimePlatform.WindowsEditor)
		{
			if (platform > RuntimePlatform.OSXPlayer && platform != RuntimePlatform.WindowsEditor)
			{
				goto IL_0167;
			}
		}
		else
		{
			if (platform == RuntimePlatform.Android)
			{
				global::UnityEngine.Object.DestroyImmediate(this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].transform.parent.parent.gameObject);
				this.menuStrings[0] = null;
				this.tipStrings[0] = null;
				global::UnityEngine.Object.DestroyImmediate(this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[5].transform.parent.parent.gameObject);
				this.menuStrings[2] = null;
				this.tipStrings[2] = null;
				global::UnityEngine.Object.DestroyImmediate(this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[2].transform.parent.parent.gameObject);
				this.menuStrings[3] = null;
				this.tipStrings[3] = null;
				global::UnityEngine.Object.DestroyImmediate(this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].transform.parent.parent.gameObject);
				this.menuStrings[1] = null;
				this.tipStrings[1] = null;
				global::UnityEngine.Object.DestroyImmediate(this.\u02B7\u02BA\u02B7\u02C0\u02B9\u02BA\u02B2\u02BF\u02B4\u02BC\u02B4[1].transform.parent.gameObject);
				this.menuStrings[5] = null;
				this.tipStrings[5] = null;
				goto IL_0167;
			}
			if (platform != RuntimePlatform.LinuxEditor)
			{
				goto IL_0167;
			}
		}
		global::UnityEngine.Object.DestroyImmediate(this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].transform.parent.parent.gameObject);
		this.menuStrings[0] = null;
		this.tipStrings[0] = null;
		IL_0167:
		this.menuStrings = this.menuStrings.Where(new Func<string, bool>(VideoSettingsMenu.<>c.<>9.\u02BD\u02BF\u02B9\u02BD\u02BE\u02B8\u02BC\u02BB\u02BC\u02B2\u02C1)).ToArray<string>();
		this.tipStrings = this.tipStrings.Where(new Func<string, bool>(VideoSettingsMenu.<>c.<>9.\u02B3\u02BD\u02C0\u02C1\u02B3\u02B3\u02B9\u02B6\u02C1\u02BC\u02BF)).ToArray<string>();
		this.textObjects = this.textObjects.Where(new Func<TextMeshProUGUI, bool>(VideoSettingsMenu.<>c.<>9.\u02B4\u02BD\u02BB\u02BF\u02B6\u02B7\u02B2\u02B9\u02C0\u02BA\u02B7)).ToArray<TextMeshProUGUI>();
		this.backgroundObjects = this.backgroundObjects.Where(new Func<Image, bool>(VideoSettingsMenu.<>c.<>9.\u02BF\u02BB\u02BD\u02C1\u02BE\u02BC\u02B8\u02B9\u02BA\u02B4\u02BE)).ToArray<Image>();
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		base.gameObject.SetActive(true);
		this.optionsContainer.GetComponent<VerticalLayoutGroup>().SetLayoutVertical();
		LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)this.optionsContainer);
		base.gameObject.SetActive(false);
		this.\u02C1\u02B7\u02C1\u02B4\u02BF\u02BE\u02BB\u02B6\u02BD\u02B7\u02C1 = true;
	}

	public virtual void \u02C0\u02BA\u02BA\u02B7\u02B5\u02B4\u02BE\u02B4\u02BD\u02B3\u02B4()
	{
		GlobalVariables instance = GlobalVariables.instance;
		instance.\u02B6\u02B3\u02B7\u02B5\u02BB\u02BD\u02B3\u02B9\u02BD\u02B2\u02B7 = (Action)Delegate.Combine(instance.\u02B6\u02B3\u02B7\u02B5\u02BB\u02BD\u02B3\u02B9\u02BD\u02B2\u02B7, new Action(this.\u02BE\u02B4\u02B9\u02C1\u02BB\u02C1\u02BC\u02BA\u02B5\u02B8\u02C1));
		this.\u02B5\u02BC\u02BE\u02B3\u02C0\u02B7\u02B5\u02B6\u02BD\u02C1\u02C1();
		this.\u02BD\u02B3\u02B4\u02BB\u02B4\u02C0\u02B7\u02B7\u02B7\u02C0\u02C0();
	}

	public virtual void \u02B3\u02C0\u02BB\u02C1\u02BD\u02C0\u02B8\u02BC\u02BA\u02BF\u02C0()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "'>")
			{
				if (this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3 + 1 < this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Count)
				{
					this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3++;
					this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
				}
			}
			else if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Crowd" && this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 + 0 < this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC.Count)
			{
				this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 += 0;
				this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			}
		}
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
	}

	protected override GameSetting GetSettingFromString(string \u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0)
	{
		GameSetting gameSetting = null;
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0);
		if (num <= 1595303295U)
		{
			if (num <= 948948777U)
			{
				if (num != 529548819U)
				{
					if (num != 546503048U)
					{
						if (num == 948948777U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Flames")
							{
								gameSetting = SettingsController.\u02C0\u02B6\u02BC\u02BF\u02BF\u02C0\u02BF\u02BC\u02B4\u02B3\u02BC;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Graphics API")
					{
						gameSetting = SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF;
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Show FPS")
				{
					gameSetting = SettingsController.\u02B8\u02B3\u02B7\u02C0\u02B5\u02BA\u02BC\u02BA\u02BE\u02BA\u02B3;
				}
			}
			else if (num <= 1093282225U)
			{
				if (num != 1026214520U)
				{
					if (num == 1093282225U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "MSAA Level")
						{
							gameSetting = SettingsController.msaaLevel;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Fullscreen")
				{
					gameSetting = SettingsController.\u02BD\u02BF\u02B7\u02B9\u02B6\u02B8\u02BB\u02BA\u02B7\u02B8\u02B3;
				}
			}
			else if (num != 1539377232U)
			{
				if (num == 1595303295U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Show Mouse Cursor")
					{
						gameSetting = SettingsController.enable_cursor;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "SP Lightning")
			{
				gameSetting = SettingsController.\u02C1\u02B6\u02B5\u02C1\u02B7\u02BE\u02B5\u02B9\u02B9\u02BB\u02C1;
			}
		}
		else if (num <= 2372057453U)
		{
			if (num != 1972880082U)
			{
				if (num != 2086318127U)
				{
					if (num == 2372057453U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Highway SP Effects")
						{
							gameSetting = SettingsController.\u02C1\u02B3\u02BA\u02B9\u02B4\u02B3\u02BB\u02B6\u02BC\u02BC\u02BB;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Menu Backgrounds")
				{
					gameSetting = SettingsController.\u02B7\u02B9\u02B4\u02C1\u02B9\u02BC\u02B8\u02BD\u02BE\u02B5\u02B8;
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "SP Colors")
			{
				gameSetting = SettingsController.\u02C1\u02BF\u02BC\u02B4\u02BE\u02B7\u02BD\u02BC\u02B5\u02BC\u02B7;
			}
		}
		else if (num <= 3134466500U)
		{
			if (num != 2897502726U)
			{
				if (num == 3134466500U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Particles")
					{
						gameSetting = SettingsController.\u02C1\u02BF\u02B3\u02BF\u02C1\u02BC\u02BC\u02BA\u02BF\u02BD\u02BE;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Vsync")
			{
				gameSetting = SettingsController.\u02B3\u02B2\u02BD\u02C1\u02B2\u02B4\u02B5\u02B3\u02C1\u02B2\u02B6;
			}
		}
		else if (num != 3200199300U)
		{
			if (num == 4135836962U)
			{
				if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Song Display")
				{
					gameSetting = SettingsController.\u02B3\u02B9\u02C1\u02BF\u02B2\u02B2\u02B6\u02BF\u02B4\u02B4\u02B2;
				}
			}
		}
		else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Framerate")
		{
			gameSetting = SettingsController.fpsCap;
		}
		return gameSetting;
	}

	protected virtual GameSetting \u02BE\u02B7\u02BC\u02B9\u02BD\u02B9\u02B8\u02BC\u02B8\u02BB\u02B8(string \u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0)
	{
		GameSetting gameSetting = null;
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0);
		if (num <= 4294967204U)
		{
			if (num <= 49U)
			{
				if (num != 4294967205U)
				{
					if (num != 154U)
					{
						if (num == 4294967143U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Bass: {0} BassFx: {1} BassMix: {2}")
							{
								gameSetting = SettingsController.\u02C0\u02B6\u02BC\u02BF\u02BF\u02C0\u02BF\u02BC\u02B4\u02B3\u02BC;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Resulting node for isolation '{0}' in language file '{1}' is a scalar node which cannot provide further resources: On path '{2}'")
					{
						gameSetting = SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF;
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Menu Music")
				{
					gameSetting = SettingsController.\u02B8\u02B3\u02B7\u02C0\u02B5\u02BA\u02BC\u02BA\u02BE\u02BA\u02B3;
				}
			}
			else if (num <= 4294967277U)
			{
				if (num != 4294967182U)
				{
					if (num == 4294967113U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Fret Ghosts")
						{
							gameSetting = SettingsController.msaaLevel;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Windowed Fullscreen")
				{
					gameSetting = SettingsController.\u02BD\u02BF\u02B7\u02B9\u02B6\u02B8\u02BB\u02BA\u02B7\u02B8\u02B3;
				}
			}
			else if (num != 148U)
			{
				if (num == 4294967158U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "[")
					{
						gameSetting = SettingsController.enable_cursor;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Join Server")
			{
				gameSetting = SettingsController.\u02C1\u02B6\u02B5\u02C1\u02B7\u02BE\u02B5\u02B9\u02B9\u02BB\u02C1;
			}
		}
		else if (num <= 3U)
		{
			if (num != 196U)
			{
				if (num != 135U)
				{
					if (num == 61U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "sounds")
						{
							gameSetting = SettingsController.\u02C1\u02B3\u02BA\u02B9\u02B4\u02B3\u02BB\u02B6\u02BC\u02BC\u02BB;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Song Speed")
				{
					gameSetting = SettingsController.\u02B7\u02B9\u02B4\u02C1\u02B9\u02BC\u02B8\u02BD\u02BE\u02B5\u02B8;
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "")
			{
				gameSetting = SettingsController.\u02C1\u02BF\u02BC\u02B4\u02BE\u02B7\u02BD\u02BC\u02B5\u02BC\u02B7;
			}
		}
		else if (num <= 12U)
		{
			if (num != 4294967156U)
			{
				if (num == 4294967245U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Highway Shake")
					{
						gameSetting = SettingsController.\u02C1\u02BF\u02B3\u02BF\u02C1\u02BC\u02BC\u02BA\u02BF\u02BD\u02BE;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "song")
			{
				gameSetting = SettingsController.\u02B3\u02B2\u02BD\u02C1\u02B2\u02B4\u02B5\u02B3\u02C1\u02B2\u02B6;
			}
		}
		else if (num != 4294967217U)
		{
			if (num == 4294967161U)
			{
				if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Show in Finder")
				{
					gameSetting = SettingsController.\u02B3\u02B9\u02C1\u02BF\u02B2\u02B2\u02B6\u02BF\u02B4\u02B4\u02B2;
				}
			}
		}
		else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Options")
		{
			gameSetting = SettingsController.fpsCap;
		}
		return gameSetting;
	}

	public override void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Resolution")
			{
				if (this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3 > 0)
				{
					this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3--;
					this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
				}
			}
			else if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Display" && this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 > 0)
			{
				this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2--;
				this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			}
		}
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
	}

	private IEnumerator \u02B2\u02C0\u02BE\u02B6\u02B4\u02BC\u02BE\u02B3\u02BE\u02C1\u02B2(int \u02B2\u02BB\u02C0\u02C0\u02BB\u02BB\u02B5\u02BE\u02BA\u02C0\u02BB)
	{
		DisplayInfo displayInfo = this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC[\u02B2\u02BB\u02C0\u02C0\u02BB\u02BB\u02B5\u02BE\u02BA\u02C0\u02BB];
		yield return Screen.MoveMainWindowTo(in displayInfo, Vector2Int.zero);
		this.\u02B2\u02B7\u02B5\u02B5\u02BD\u02BC\u02BF\u02B7\u02C1\u02B7\u02B2();
		yield break;
	}

	protected virtual void \u02B6\u02BE\u02BF\u02B5\u02B2\u02BD\u02B2\u02B5\u02C0\u02BF\u02B7()
	{
		this.\u02B7\u02BE\u02BA\u02B8\u02BE\u02B2\u02B4\u02C0\u02BE\u02B7\u02BB();
	}

	protected override void \u02BA\u02B8\u02B4\u02BA\u02BD\u02BA\u02B7\u02C1\u02B8\u02B8\u02BC()
	{
		this.\u02B2\u02B7\u02B5\u02B5\u02BD\u02BC\u02BF\u02B7\u02C1\u02B7\u02B2();
	}

	private void \u02BE\u02B4\u02B9\u02C1\u02BB\u02C1\u02BC\u02BA\u02B5\u02B8\u02C1()
	{
		this.\u02B7\u02BE\u02BA\u02B8\u02BE\u02B2\u02B4\u02C0\u02BE\u02B7\u02BB();
	}

	private IEnumerator \u02B7\u02B6\u02B6\u02BC\u02BA\u02B2\u02C0\u02B8\u02BD\u02B4\u02C1(int \u02B2\u02BB\u02C0\u02C0\u02BB\u02BB\u02B5\u02BE\u02BA\u02C0\u02BB)
	{
		DisplayInfo displayInfo = this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC[\u02B2\u02BB\u02C0\u02C0\u02BB\u02BB\u02B5\u02BE\u02BA\u02C0\u02BB];
		yield return Screen.MoveMainWindowTo(in displayInfo, Vector2Int.zero);
		this.\u02B2\u02B7\u02B5\u02B5\u02BD\u02BC\u02BF\u02B7\u02C1\u02B7\u02B2();
		yield break;
	}

	public override void \u02BA\u02BC\u02C1\u02BE\u02B6\u02B4\u02B9\u02B2\u02B3\u02BD\u02B4()
	{
		if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == null)
		{
			return;
		}
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.Reset();
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	private void \u02B2\u02B7\u02B2\u02B3\u02B5\u02B3\u02B8\u02BA\u02B3\u02BC\u02BD()
	{
		this.\u02B2\u02B7\u02B5\u02B5\u02BD\u02BC\u02BF\u02B7\u02C1\u02B7\u02B2();
	}

	private void \u02BD\u02B9\u02C1\u02BF\u02BA\u02B2\u02B8\u02B9\u02BF\u02BB\u02C0()
	{
		this.\u02C1\u02B6\u02B7\u02BC\u02B3\u02BE\u02B3\u02C1\u02B4\u02B2\u02BC.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		Helper.Restart("song");
	}

	private void \u02B3\u02BC\u02B9\u02BD\u02BB\u02B6\u02B5\u02B9\u02BC\u02BD\u02BE()
	{
		this.\u02C1\u02B6\u02B7\u02BC\u02B3\u02BE\u02B3\u02C1\u02B4\u02B2\u02BC.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		Helper.Restart("");
	}

	public virtual void \u02B3\u02BB\u02B7\u02C0\u02BF\u02B9\u02C1\u02BA\u02B9\u02B8\u02B6(string \u02B4\u02B9\u02B3\u02B9\u02BC\u02C1\u02BE\u02BF\u02B4\u02B9\u02C0 = "")
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
			if (num <= 4294967268U)
			{
				if (num <= 4294967208U)
				{
					if (num <= 165U)
					{
						if (num != 4294967139U)
						{
							if (num == 4294967129U)
							{
								if (text == "practice_sp")
								{
									if (Application.platform == (RuntimePlatform)52 || Application.platform == RuntimePlatform.WindowsWebPlayer)
									{
										this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = this.\u02BF\u02B3\u02BC\u02BB\u02C0\u02B4\u02BC\u02C0\u02C1\u02B2\u02BE[SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF.CurrentValue].\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;
									}
								}
							}
						}
						else if (text == "Difficulty")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(6, settingFromString);
						}
					}
					else if (num != 161U)
					{
						if (num == 185U)
						{
							if (text == "Disabled")
							{
								if (Application.platform != (RuntimePlatform)(-75))
								{
									if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsEditor)
									{
										if (settingFromString.CurrentValue == 0)
										{
											this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[4].text = "[ENHANCED_OPENS]";
										}
										else if (settingFromString.CurrentValue == 1)
										{
											this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[3].text = "Couldn't load that song";
										}
										else if (settingFromString.CurrentValue == 6)
										{
											this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[6].text = "offset";
										}
									}
									else if (settingFromString.CurrentValue == 0)
									{
										this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[8].text = " ";
									}
									else if (settingFromString.CurrentValue == 0)
									{
										this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = "Are you sure you want to quit?";
									}
								}
							}
						}
					}
					else if (text == "")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(5, settingFromString);
					}
				}
				else if (num <= 4294967179U)
				{
					if (num != 189U)
					{
						if (num == 4294967230U)
						{
							if (text == "Crowd")
							{
								if (Application.platform != (RuntimePlatform)(-30) && this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC != null && this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC.Count != 0 && this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 <= this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC.Count - 1)
								{
									this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[2].text = string.Format("Online", this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC[this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2].name, this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 + 1);
								}
							}
						}
					}
					else if (text == "highway.webm")
					{
						if (settingFromString.CurrentValue == 0)
						{
							this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[4].text = "Default Sort Filter";
						}
						else
						{
							this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[8].text = settingFromString.GetIntString + "Drums";
						}
					}
				}
				else if (num != 4294967258U)
				{
					if (num == 137U)
					{
						if (text == "offset")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
						}
					}
				}
				else if (text == "Year")
				{
					base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(3, settingFromString);
				}
			}
			else if (num <= 5U)
			{
				if (num <= 4294967180U)
				{
					if (num != 14U)
					{
						if (num == 61U)
						{
							if (text == "currentsong.txt")
							{
								string text2 = "streamer";
								switch (settingFromString.CurrentValue)
								{
								case 0:
									text2 = LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("video");
									break;
								case 1:
									text2 = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().GetString("<b>0</b> nps");
									break;
								case 2:
									text2 = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(": ");
									break;
								case 3:
									text2 = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("song");
									break;
								case 4:
									text2 = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().GetString("phrase_start");
									break;
								case 5:
									text2 = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().GetString("Gameplay");
									break;
								case 6:
									text2 = LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(", ");
									break;
								case 7:
									text2 = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("int");
									break;
								case 8:
									text2 = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("v1shownpopup");
									break;
								case 9:
									text2 = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Respawn");
									break;
								case 10:
									text2 = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().GetString("beat");
									break;
								case 11:
									text2 = LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("Yes");
									break;
								case 12:
									text2 = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("CSSetWhammyColumn");
									break;
								case 13:
									text2 = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("DiscordRPC: is now offline due to error");
									break;
								case 14:
									text2 = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("Rhythm Guitar");
									break;
								}
								this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = text2;
							}
						}
					}
					else if (text == "Precision Mode")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
					}
				}
				else if (num != 161U)
				{
					if (num == 104U)
					{
						if (text == "' is missing")
						{
							if (Application.platform != (RuntimePlatform)60)
							{
								base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(1, settingFromString);
							}
						}
					}
				}
				else if (text == "Pro Drums")
				{
					base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(8, settingFromString);
				}
			}
			else if (num <= 59U)
			{
				if (num != 174U)
				{
					if (num == 4294967097U)
					{
						if (text == "Resolution")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(3, settingFromString);
						}
					}
				}
				else if (text == "Track Mute")
				{
					if (Application.platform != (RuntimePlatform)(-36))
					{
						if (this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Count > 0)
						{
							this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = string.Format("Total Notes", this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD[this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3].width, this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD[this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3].height);
						}
						else
						{
							this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = "band";
						}
					}
				}
			}
			else if (num != 4294967240U)
			{
				if (num == 4294967104U)
				{
					if (text == "6 Fret Lead Guitar")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(1, settingFromString);
					}
				}
			}
			else if (text == "Press <color=\"green\">Green</color> to continue.")
			{
				base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
				if (settingFromString.CurrentValue > 116)
				{
					this.\u02C0\u02B9\u02C0\u02B2\u02B5\u02BA\u02BD\u02BF\u02B2\u02B7\u02B3[0].text = "Null";
				}
			}
		}
	}

	protected override void \u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5()
	{
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Resolution") && !(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Display") && !(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Menu Backgrounds") && !(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Framerate") && !(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "MSAA Level") && u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Show Mouse Cursor")
		{
			Cursor.visible = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetBoolValue;
		}
		this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3);
	}

	public override void SetBools()
	{
		GlobalVariables instance = GlobalVariables.instance;
		instance.\u02B6\u02B3\u02B7\u02B5\u02BB\u02BD\u02B3\u02B9\u02BD\u02B2\u02B7 = (Action)Delegate.Combine(instance.\u02B6\u02B3\u02B7\u02B5\u02BB\u02BD\u02B3\u02B9\u02BD\u02B2\u02B7, new Action(this.\u02B2\u02B7\u02B2\u02B3\u02B5\u02B3\u02B8\u02BA\u02B3\u02BC\u02BD));
		this.\u02B5\u02BC\u02BE\u02B3\u02C0\u02B7\u02B5\u02B6\u02BD\u02C1\u02C1();
		this.\u02BD\u02B3\u02B4\u02BB\u02B4\u02C0\u02B7\u02B7\u02B7\u02C0\u02C0();
	}

	private void \u02B2\u02B7\u02B5\u02B5\u02BD\u02BC\u02BF\u02B7\u02C1\u02B7\u02B2()
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			return;
		}
		this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC.Clear();
		Screen.GetDisplayLayout(this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC);
		this.\u02B3\u02B6\u02BF\u02B2\u02B7\u02BF\u02BF\u02BB\u02BD\u02B5\u02B6 = Screen.mainWindowDisplayInfo;
		for (int i = 0; i < this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC.Count; i++)
		{
			if (this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC[i].Equals(this.\u02B3\u02B6\u02BF\u02B2\u02B7\u02BF\u02BF\u02BB\u02BD\u02B5\u02B6))
			{
				this.\u02BF\u02B7\u02BF\u02B2\u02C0\u02BC\u02B6\u02B7\u02C0\u02B4\u02B2 = i;
				break;
			}
		}
		this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 = this.\u02BF\u02B7\u02BF\u02B2\u02C0\u02BC\u02B6\u02B7\u02C0\u02B4\u02B2;
		this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Clear();
		foreach (Resolution resolution in Screen.resolutions)
		{
			bool flag = false;
			foreach (Display display in Display.displays)
			{
				if (resolution.width <= display.systemWidth && resolution.height <= display.systemHeight)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				bool flag2 = true;
				foreach (Resolution resolution2 in this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD)
				{
					if (resolution.width == resolution2.width && resolution.height == resolution2.height)
					{
						flag2 = false;
					}
				}
				if (flag2)
				{
					this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Add(resolution);
				}
			}
		}
		for (int l = 0; l < this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Count; l++)
		{
			Resolution resolution3 = this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD[l];
			if (resolution3.width == Screen.width && resolution3.height == Screen.height)
			{
				this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3 = l;
				break;
			}
		}
		this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("");
	}

	public virtual void \u02C1\u02B2\u02BC\u02B9\u02B4\u02B6\u02B6\u02B5\u02B3\u02BB\u02B2(string \u02B4\u02B9\u02B3\u02B9\u02BC\u02C1\u02BE\u02BF\u02B4\u02B9\u02C0 = "")
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
			if (num <= 112U)
			{
				if (num <= 113U)
				{
					if (num <= 87U)
					{
						if (num != 4294967162U)
						{
							if (num == 4294967181U)
							{
								if (text == ".exe")
								{
									if (Application.platform == (RuntimePlatform)92 || Application.platform == (RuntimePlatform)6)
									{
										this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = this.\u02BF\u02B3\u02BC\u02BB\u02C0\u02B4\u02BC\u02C0\u02C1\u02B2\u02BE[SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF.CurrentValue].\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;
									}
								}
							}
						}
						else if (text == "Keyboard")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(8, settingFromString);
						}
					}
					else if (num != 13U)
					{
						if (num == 190U)
						{
							if (text == "")
							{
								if (Application.platform != (RuntimePlatform)(-22))
								{
									if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXDashboardPlayer)
									{
										if (settingFromString.CurrentValue == 0)
										{
											this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[8].text = "bad_note3";
										}
										else if (settingFromString.CurrentValue == 1)
										{
											this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[8].text = "notes.mid";
										}
										else if (settingFromString.CurrentValue == 0)
										{
											this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[4].text = "year";
										}
									}
									else if (settingFromString.CurrentValue == 0)
									{
										this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[3].text = "ControlMapper";
									}
									else if (settingFromString.CurrentValue == 1)
									{
										this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = "<b>{0}</b>%";
									}
								}
							}
						}
					}
					else if (text == "A: 00:00:00")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(6, settingFromString);
					}
				}
				else if (num <= 4294967282U)
				{
					if (num != 4294967158U)
					{
						if (num == 195U)
						{
							if (text == "n")
							{
								if (Application.platform != (RuntimePlatform)91 && this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC != null && this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC.Count != 0 && this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 <= this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC.Count - 0)
								{
									this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[2].text = string.Format("Kick / Open Notes", this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC[this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2].name, this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 + 1);
								}
							}
						}
					}
					else if (text == "song")
					{
						if (settingFromString.CurrentValue == 0)
						{
							this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[2].text = "Renderer: {0}";
						}
						else
						{
							this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[6].text = settingFromString.GetIntString + "Yes";
						}
					}
				}
				else if (num != 4294967219U)
				{
					if (num == 4294967145U)
					{
						if (text == "songs.json")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
						}
					}
				}
				else if (text == "No")
				{
					base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(3, settingFromString);
				}
			}
			else if (num <= 81U)
			{
				if (num <= 189U)
				{
					if (num != 87U)
					{
						if (num == 4294967118U)
						{
							if (text == "Guest")
							{
								string text2 = "song";
								switch (settingFromString.CurrentValue)
								{
								case 0:
									text2 = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("highway_shake");
									break;
								case 1:
									text2 = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("notes");
									break;
								case 2:
									text2 = LanguageManager.instance.GetString("Device in use by ");
									break;
								case 3:
									text2 = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("{0:N0}");
									break;
								case 4:
									text2 = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Double Strum Prevention");
									break;
								case 5:
									text2 = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("{0:n0}");
									break;
								case 6:
									text2 = LanguageManager.instance.GetString("analytics-opt-out");
									break;
								case 7:
									text2 = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().GetString("");
									break;
								case 8:
									text2 = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().GetString("song");
									break;
								case 9:
									text2 = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("Kick / Open Notes");
									break;
								case 10:
									text2 = LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("whammy_sfx");
									break;
								case 11:
									text2 = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("guitar6fret");
									break;
								case 12:
									text2 = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("song");
									break;
								case 13:
									text2 = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("");
									break;
								case 14:
									text2 = LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("Song");
									break;
								}
								this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[6].text = text2;
							}
						}
					}
					else if (text == "Yes")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(8, settingFromString);
					}
				}
				else if (num != 155U)
				{
					if (num == 4294967209U)
					{
						if (text == "Yes")
						{
							if (Application.platform != RuntimePlatform.WP8Player)
							{
								base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
							}
						}
					}
				}
				else if (text == "Test")
				{
					base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(4, settingFromString);
				}
			}
			else if (num <= 4U)
			{
				if (num != 4294967290U)
				{
					if (num == 137U)
					{
						if (text == "Random")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(5, settingFromString);
						}
					}
				}
				else if (text == ".sng")
				{
					if (Application.platform != RuntimePlatform.MetroPlayerX86)
					{
						if (this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Count > 0)
						{
							this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = string.Format("path", this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD[this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3].width, this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD[this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3].height);
						}
						else
						{
							this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = "Bass Guitar";
						}
					}
				}
			}
			else if (num != 4294967104U)
			{
				if (num == 4294967130U)
				{
					if (text == "Songs")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(8, settingFromString);
					}
				}
			}
			else if (text == "Lead Guitar")
			{
				base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
				if (settingFromString.CurrentValue > 164)
				{
					this.\u02C0\u02B9\u02C0\u02B2\u02B5\u02BA\u02BD\u02BF\u02B2\u02B7\u02B3[1].text = "8EDC4F";
				}
			}
		}
	}

	private void \u02B5\u02BC\u02BE\u02B3\u02C0\u02B7\u02B5\u02B6\u02BD\u02C1\u02C1()
	{
		this.\u02BF\u02B3\u02BC\u02BB\u02C0\u02B4\u02BC\u02C0\u02C1\u02B2\u02BE = new List<VideoSettingsMenu.\u02B8\u02BA\u02B2\u02B4\u02B5\u02C1\u02B2\u02BD\u02BB\u02B9\u02BF>();
		Helper.UintPair this2 = Helper.NewUintPair((uint)Helper.SupportedGraphicsAPIs()).GetThis();
		while (this2.MoreThanOneBitSet())
		{
			Helper.GraphicsAPI graphicsAPI = (Helper.GraphicsAPI)this2.xor;
			VideoSettingsMenu.\u02B8\u02BA\u02B2\u02B4\u02B5\u02C1\u02B2\u02BD\u02BB\u02B9\u02BF u02B8_u02BA_u02B2_u02B4_u02B5_u02C1_u02B2_u02BD_u02BB_u02B9_u02BF = default(VideoSettingsMenu.\u02B8\u02BA\u02B2\u02B4\u02B5\u02C1\u02B2\u02BD\u02BB\u02B9\u02BF);
			u02B8_u02BA_u02B2_u02B4_u02B5_u02C1_u02B2_u02BD_u02BB_u02B9_u02BF.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 = Helper.\u02B9\u02B6\u02C0\u02B9\u02B3\u02BA\u02B8\u02BF\u02B4\u02BE\u02BB(graphicsAPI);
			u02B8_u02BA_u02B2_u02B4_u02B5_u02C1_u02B2_u02BD_u02BB_u02B9_u02BF.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF = graphicsAPI;
			this.\u02BF\u02B3\u02BC\u02BB\u02C0\u02B4\u02BC\u02C0\u02C1\u02B2\u02BE.Add(u02B8_u02BA_u02B2_u02B4_u02B5_u02C1_u02B2_u02BD_u02BB_u02B9_u02BF);
		}
	}

	public virtual void \u02BF\u02BE\u02BB\u02C0\u02B4\u02B6\u02BA\u02B4\u02BC\u02BC\u02BB()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "profiles.ini")
			{
				if (this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3 > 0)
				{
					this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3 -= 0;
					this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
				}
			}
			else if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Hide Accents/Ghosts" && this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 > 1)
			{
				this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2--;
				this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			}
		}
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
	}

	public override void ConfirmPressed()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
			uint num = PrivateImplementationDetails.ComputeStringHash(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B);
			if (num <= 1595303295U)
			{
				if (num <= 1026214520U)
				{
					if (num <= 546503048U)
					{
						if (num != 529548819U)
						{
							if (num == 546503048U)
							{
								if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Graphics API")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF;
								}
							}
						}
						else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Show FPS")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B8\u02B3\u02B7\u02C0\u02B5\u02BA\u02BC\u02BA\u02BE\u02BA\u02B3;
						}
					}
					else if (num != 948948777U)
					{
						if (num == 1026214520U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Fullscreen")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BD\u02BF\u02B7\u02B9\u02B6\u02B8\u02BB\u02BA\u02B7\u02B8\u02B3;
								return;
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Flames")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02C0\u02B6\u02BC\u02BF\u02BF\u02C0\u02BF\u02BC\u02B4\u02B3\u02BC;
					}
				}
				else if (num <= 1510332853U)
				{
					if (num != 1093282225U)
					{
						if (num == 1510332853U)
						{
							if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Display"))
							{
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "MSAA Level")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.msaaLevel;
					}
				}
				else if (num != 1539377232U)
				{
					if (num == 1595303295U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Show Mouse Cursor")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.enable_cursor;
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "SP Lightning")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02C1\u02B6\u02B5\u02C1\u02B7\u02BE\u02B5\u02B9\u02B9\u02BB\u02C1;
				}
			}
			else if (num <= 2897502726U)
			{
				if (num <= 2086318127U)
				{
					if (num != 1972880082U)
					{
						if (num == 2086318127U)
						{
							if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Menu Backgrounds")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B7\u02B9\u02B4\u02C1\u02B9\u02BC\u02B8\u02BD\u02BE\u02B5\u02B8;
							}
						}
					}
					else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "SP Colors")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02C1\u02BF\u02BC\u02B4\u02BE\u02B7\u02BD\u02BC\u02B5\u02BC\u02B7;
					}
				}
				else if (num != 2372057453U)
				{
					if (num == 2897502726U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Vsync")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B3\u02B2\u02BD\u02C1\u02B2\u02B4\u02B5\u02B3\u02C1\u02B2\u02B6;
						}
					}
				}
				else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Highway SP Effects")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02C1\u02B3\u02BA\u02B9\u02B4\u02B3\u02BB\u02B6\u02BC\u02BC\u02BB;
				}
			}
			else if (num <= 3134466500U)
			{
				if (num != 2934446255U)
				{
					if (num == 3134466500U)
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Particles")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02C1\u02BF\u02B3\u02BF\u02C1\u02BC\u02BC\u02BA\u02BF\u02BD\u02BE;
						}
					}
				}
				else if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Resolution"))
				{
				}
			}
			else if (num != 3200199300U)
			{
				if (num == 4135836962U)
				{
					if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Song Display")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B3\u02B9\u02C1\u02BF\u02B2\u02B2\u02B6\u02BF\u02B4\u02B4\u02B2;
					}
				}
			}
			else if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Framerate")
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.fpsCap;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02B4\u02BA\u02B4\u02B2\u02B9\u02BF\u02BB\u02BE\u02B2\u02B9\u02B9;
			return;
		}
		this.\u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1();
		this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02BD\u02BD\u02B6\u02C1\u02B6\u02BD\u02BA\u02B8\u02BE\u02BF\u02B9;
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	protected virtual void \u02BC\u02C1\u02BD\u02B8\u02B9\u02BD\u02BB\u02B9\u02B5\u02B2\u02B6()
	{
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "SETLIST LENGTH") && !(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Blur Command Buffer") && !(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "setlistSongCountPlural") && !(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "notSupportedTitle") && !(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "song") && u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "New Setlist")
		{
			Cursor.visible = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetBoolValue;
		}
		this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3);
	}

	private IEnumerator \u02B6\u02B8\u02B4\u02C1\u02B4\u02BD\u02B2\u02BD\u02B2\u02B9\u02B5(int \u02B2\u02BB\u02C0\u02C0\u02BB\u02BB\u02B5\u02BE\u02BA\u02C0\u02BB)
	{
		DisplayInfo displayInfo = this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC[\u02B2\u02BB\u02C0\u02C0\u02BB\u02BB\u02B5\u02BE\u02BA\u02C0\u02BB];
		yield return Screen.MoveMainWindowTo(in displayInfo, Vector2Int.zero);
		this.\u02B2\u02B7\u02B5\u02B5\u02BD\u02BC\u02BF\u02B7\u02C1\u02B7\u02B2();
		yield break;
	}

	private void \u02B7\u02C1\u02BF\u02B2\u02B5\u02BE\u02BB\u02B6\u02C0\u02BC\u02C0()
	{
		this.\u02C1\u02B6\u02B7\u02BC\u02B3\u02BE\u02B3\u02C1\u02B4\u02B2\u02BC.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		Helper.Restart("Type the setlist name");
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
			if (num <= 1595303295U)
			{
				if (num <= 1026214520U)
				{
					if (num <= 546503048U)
					{
						if (num != 529548819U)
						{
							if (num == 546503048U)
							{
								if (text == "Graphics API")
								{
									if (Application.platform == RuntimePlatform.LinuxPlayer || Application.platform == RuntimePlatform.WindowsPlayer)
									{
										this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = this.\u02BF\u02B3\u02BC\u02BB\u02C0\u02B4\u02BC\u02C0\u02C1\u02B2\u02BE[SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF.CurrentValue].\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;
									}
								}
							}
						}
						else if (text == "Show FPS")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(7, settingFromString);
						}
					}
					else if (num != 948948777U)
					{
						if (num == 1026214520U)
						{
							if (text == "Fullscreen")
							{
								if (Application.platform != RuntimePlatform.Android)
								{
									if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer)
									{
										if (settingFromString.CurrentValue == 0)
										{
											this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[2].text = "Disabled";
										}
										else if (settingFromString.CurrentValue == 1)
										{
											this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[2].text = "Windowed Fullscreen";
										}
										else if (settingFromString.CurrentValue == 2)
										{
											this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[2].text = "Exclusive Fullscreen";
										}
									}
									else if (settingFromString.CurrentValue == 0)
									{
										this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[2].text = "Disabled";
									}
									else if (settingFromString.CurrentValue == 1)
									{
										this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[2].text = "Windowed Fullscreen";
									}
								}
							}
						}
					}
					else if (text == "Flames")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(3, settingFromString);
					}
				}
				else if (num <= 1510332853U)
				{
					if (num != 1093282225U)
					{
						if (num == 1510332853U)
						{
							if (text == "Display")
							{
								if (Application.platform != RuntimePlatform.Android && this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC != null && this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC.Count != 0 && this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 <= this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC.Count - 1)
								{
									this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[5].text = string.Format("{0} ({1})", this.\u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC[this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2].name, this.\u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 + 1);
								}
							}
						}
					}
					else if (text == "MSAA Level")
					{
						if (settingFromString.CurrentValue == 0)
						{
							this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[3].text = "Disabled";
						}
						else
						{
							this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[3].text = settingFromString.GetIntString + "x";
						}
					}
				}
				else if (num != 1539377232U)
				{
					if (num == 1595303295U)
					{
						if (text == "Show Mouse Cursor")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
						}
					}
				}
				else if (text == "SP Lightning")
				{
					base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(5, settingFromString);
				}
			}
			else if (num <= 2897502726U)
			{
				if (num <= 2086318127U)
				{
					if (num != 1972880082U)
					{
						if (num == 2086318127U)
						{
							if (text == "Menu Backgrounds")
							{
								string text2 = "";
								switch (settingFromString.CurrentValue)
								{
								case 0:
									text2 = LanguageManager.instance.GetString("Animated");
									break;
								case 1:
									text2 = LanguageManager.instance.GetString("Static");
									break;
								case 2:
									text2 = LanguageManager.instance.GetString("Surfer");
									break;
								case 3:
									text2 = LanguageManager.instance.GetString("Classic");
									break;
								case 4:
									text2 = LanguageManager.instance.GetString("Dark");
									break;
								case 5:
									text2 = LanguageManager.instance.GetString("Light");
									break;
								case 6:
									text2 = LanguageManager.instance.GetString("Autumn");
									break;
								case 7:
									text2 = LanguageManager.instance.GetString("Alien");
									break;
								case 8:
									text2 = LanguageManager.instance.GetString("Blue Rays");
									break;
								case 9:
									text2 = LanguageManager.instance.GetString("Grains");
									break;
								case 10:
									text2 = LanguageManager.instance.GetString("Groovy");
									break;
								case 11:
									text2 = LanguageManager.instance.GetString("Pastel Burst");
									break;
								case 12:
									text2 = LanguageManager.instance.GetString("Rainbow");
									break;
								case 13:
									text2 = LanguageManager.instance.GetString("Spray");
									break;
								case 14:
									text2 = LanguageManager.instance.GetString("Black");
									break;
								}
								this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[4].text = text2;
							}
						}
					}
					else if (text == "SP Colors")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(8, settingFromString);
					}
				}
				else if (num != 2372057453U)
				{
					if (num == 2897502726U)
					{
						if (text == "Vsync")
						{
							if (Application.platform != RuntimePlatform.Android)
							{
								base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(1, settingFromString);
							}
						}
					}
				}
				else if (text == "Highway SP Effects")
				{
					base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(4, settingFromString);
				}
			}
			else if (num <= 3134466500U)
			{
				if (num != 2934446255U)
				{
					if (num == 3134466500U)
					{
						if (text == "Particles")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(2, settingFromString);
						}
					}
				}
				else if (text == "Resolution")
				{
					if (Application.platform != RuntimePlatform.Android)
					{
						if (this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD.Count > 0)
						{
							this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = string.Format("{0}x{1}", this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD[this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3].width, this.\u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD[this.\u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3].height);
						}
						else
						{
							this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = "Default Resolution";
						}
					}
				}
			}
			else if (num != 3200199300U)
			{
				if (num == 4135836962U)
				{
					if (text == "Song Display")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(6, settingFromString);
					}
				}
			}
			else if (text == "Framerate")
			{
				base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(0, settingFromString);
				if (settingFromString.CurrentValue > 2000)
				{
					this.\u02C0\u02B9\u02C0\u02B2\u02B5\u02BA\u02BD\u02BF\u02B2\u02B7\u02B3[0].text = "∞";
				}
			}
		}
	}

	private List<Resolution> \u02BD\u02C1\u02B5\u02BB\u02B5\u02B5\u02C1\u02C1\u02B3\u02BA\u02BD = new List<Resolution>();

	private int \u02BA\u02B9\u02B4\u02B5\u02B7\u02BE\u02B9\u02BC\u02B5\u02B9\u02B3;

	private List<DisplayInfo> \u02B4\u02BF\u02B7\u02B9\u02B2\u02C0\u02BD\u02C0\u02BA\u02BB\u02BC = new List<DisplayInfo>();

	private DisplayInfo \u02B3\u02B6\u02BF\u02B2\u02B7\u02BF\u02BF\u02BB\u02BD\u02B5\u02B6;

	private List<VideoSettingsMenu.\u02B8\u02BA\u02B2\u02B4\u02B5\u02C1\u02B2\u02BD\u02BB\u02B9\u02BF> \u02BF\u02B3\u02BC\u02BB\u02C0\u02B4\u02BC\u02C0\u02C1\u02B2\u02BE;

	private int \u02BF\u02B7\u02BF\u02B2\u02C0\u02BC\u02B6\u02B7\u02C0\u02B4\u02B2 = -1;

	private int \u02B4\u02BD\u02B9\u02BE\u02B9\u02BF\u02C0\u02BE\u02B2\u02B7\u02B2 = -1;

	private bool \u02C1\u02B7\u02C1\u02B4\u02BF\u02BE\u02BB\u02B6\u02BD\u02B7\u02C1;

	[SerializeField]
	private Transform optionsContainer;

	[SerializeField]
	private ConfirmationMenu confirmMenu;

	private List<string> \u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1 = new List<string>();

	private struct \u02B8\u02BA\u02B2\u02B4\u02B5\u02C1\u02B2\u02BD\u02BB\u02B9\u02BF
	{
		public string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;

		public Helper.GraphicsAPI \u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF;
	}
}
