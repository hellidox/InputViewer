﻿using System;
using System.Collections;
using System.Collections.Generic;
using StrikeCore;
using UnityEngine;

public class GeneralSettingsMenu : BaseSettingMenu
{
	private IEnumerator \u02B7\u02BE\u02BF\u02B6\u02BE\u02BC\u02C0\u02B6\u02B4\u02B3\u02BB(bool \u02BB\u02B8\u02B9\u02BF\u02B3\u02BB\u02B2\u02B6\u02B4\u02B4\u02B7)
	{
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4 == null || \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count == 0)
		{
			yield break;
		}
		this.exportSongList.gameObject.SetActive(true);
		if (\u02BB\u02B8\u02B9\u02BF\u02B3\u02BB\u02B2\u02B6\u02B4\u02B4\u02B7)
		{
			base.StartCoroutine(this.exportSongList.\u02BD\u02BE\u02B6\u02B9\u02C1\u02B6\u02B3\u02B8\u02BD\u02BF\u02C0());
		}
		else
		{
			base.StartCoroutine(this.exportSongList.\u02B7\u02B4\u02BB\u02B2\u02B8\u02C1\u02BA\u02B2\u02B4\u02C0\u02C1());
		}
		while (this.exportSongList.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4)
		{
			yield return null;
		}
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B4\u02B7\u02B2\u02BC\u02B8\u02B3\u02BA\u02BB\u02BC\u02B3 = -1;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(null, false);
		this.songSelect.\u02B7\u02BE\u02B8\u02B7\u02B9\u02BA\u02B3\u02B6\u02B4\u02B7\u02B8();
		this.exportSongList.gameObject.SetActive(false);
		yield break;
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
			if (num <= 2046560590U)
			{
				if (num <= 834568855U)
				{
					if (num != 139433807U)
					{
						if (num != 773019664U)
						{
							if (num == 834568855U)
							{
								if (text == "Drum Pad Scrolling")
								{
									base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
								}
							}
						}
						else if (text == "Minimum Speed")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(2, settingFromString);
						}
					}
					else if (text == "AutoSave Results Screenshot")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(2, settingFromString);
					}
				}
				else if (num <= 1190966539U)
				{
					if (num != 843734599U)
					{
						if (num == 1190966539U)
						{
							if (text == "Allow Clients To Remove Songs")
							{
								base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(4, settingFromString);
							}
						}
					}
					else if (text == "Show Remote Player Names")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(5, settingFromString);
					}
				}
				else if (num != 2000281641U)
				{
					if (num == 2046560590U)
					{
						if (text == "Online Highway Placement")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(6, settingFromString);
						}
					}
				}
				else if (text == "Server Tickrate")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
				}
			}
			else if (num <= 2451769732U)
			{
				if (num <= 2238208579U)
				{
					if (num != 2126712851U)
					{
						if (num == 2238208579U)
						{
							if (text == "Songs Per Player")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(4, settingFromString);
							}
						}
					}
					else if (text == "Highway Placement")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(0, settingFromString);
					}
				}
				else if (num != 2335906414U)
				{
					if (num == 2451769732U)
					{
						if (text == "Remote Player Righty Flip")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(8, settingFromString);
						}
					}
				}
				else if (text == "Maximum Speed")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(3, settingFromString);
				}
			}
			else if (num <= 2780239723U)
			{
				if (num != 2591284123U)
				{
					if (num == 2780239723U)
					{
						if (text == "Export Current Song")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(3, settingFromString);
						}
					}
				}
				else if (text == "Language")
				{
					this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = LanguageManager.instance.GetString(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[settingFromString.CurrentValue]);
				}
			}
			else if (num != 4185652605U)
			{
				if (num == 4281963163U)
				{
					if (text == "Hide Remote Highways")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(7, settingFromString);
					}
				}
			}
			else if (text == "Show Full Playlist")
			{
				base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(1, settingFromString);
			}
		}
	}

	protected override void \u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5()
	{
		if (this.changedSetting == null || this.songScan.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA || this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		string changedSetting = this.changedSetting;
		string changedSetting2 = this.changedSetting;
		if (!(changedSetting2 == "Language"))
		{
			if (changedSetting2 == "Show Full Playlist")
			{
				\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BC\u02B6\u02C1\u02B4\u02B6\u02BC\u02BA\u02B3\u02BE\u02B8();
			}
		}
		else
		{
			this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue];
		}
		this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(this.changedSetting);
	}

	protected override GameSetting GetSettingFromString(string \u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0)
	{
		GameSetting gameSetting = null;
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0);
		if (num <= 2000281641U)
		{
			if (num <= 834568855U)
			{
				if (num <= 747914534U)
				{
					if (num != 139433807U)
					{
						if (num == 747914534U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Open Default Songs Folder")
							{
								gameSetting = null;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "AutoSave Results Screenshot")
					{
						gameSetting = SettingsController.auto_screenshot;
					}
				}
				else if (num != 773019664U)
				{
					if (num == 834568855U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Drum Pad Scrolling")
						{
							gameSetting = SettingsController.drum_pad_scrolling;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Minimum Speed")
				{
					gameSetting = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02B9\u02C1\u02BE\u02B3\u02B5\u02B6\u02C0\u02BA\u02B9\u02B5\u02B4;
				}
			}
			else if (num <= 1190966539U)
			{
				if (num != 843734599U)
				{
					if (num == 1190966539U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Allow Clients To Remove Songs")
						{
							gameSetting = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02B3\u02BD\u02B9\u02B4\u02C0\u02B2\u02B4\u02BF\u02BD\u02B9\u02C1;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Show Remote Player Names")
				{
					gameSetting = SettingsController.showremotenames;
				}
			}
			else if (num != 1297251446U)
			{
				if (num != 1348092204U)
				{
					if (num == 2000281641U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Server Tickrate")
						{
							gameSetting = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02BC\u02BB\u02BD\u02B5\u02BD\u02B5\u02B5\u02BD\u02B9\u02BA\u02BF;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Open Logs Folder")
				{
					gameSetting = null;
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Scan Songs")
			{
				gameSetting = null;
			}
		}
		else if (num <= 2451769732U)
		{
			if (num <= 2126712851U)
			{
				if (num != 2046560590U)
				{
					if (num == 2126712851U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Highway Placement")
						{
							gameSetting = SettingsController.\u02BC\u02BA\u02BE\u02BB\u02B7\u02BE\u02BD\u02BE\u02BC\u02B2\u02B7;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Online Highway Placement")
				{
					gameSetting = SettingsController.highwayplacement;
				}
			}
			else if (num != 2238208579U)
			{
				if (num != 2335906414U)
				{
					if (num == 2451769732U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Remote Player Righty Flip")
						{
							gameSetting = SettingsController.force_remote_righty;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Maximum Speed")
				{
					gameSetting = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02BB\u02BC\u02B7\u02B9\u02BF\u02C1\u02C1\u02B6\u02B9\u02B6\u02C1;
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Songs Per Player")
			{
				gameSetting = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02B4\u02B9\u02B5\u02B7\u02BA\u02C0\u02B6\u02BE\u02BB\u02B7\u02C0;
			}
		}
		else if (num <= 2780239723U)
		{
			if (num != 2591284123U)
			{
				if (num == 2780239723U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Export Current Song")
					{
						gameSetting = SettingsController.\u02BA\u02BF\u02BF\u02B7\u02B4\u02B6\u02BD\u02BC\u02BE\u02B5\u02BA;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Language")
			{
				gameSetting = SettingsController.language;
			}
		}
		else if (num != 2970547677U)
		{
			if (num != 4185652605U)
			{
				if (num == 4281963163U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Hide Remote Highways")
					{
						gameSetting = SettingsController.only_show_local_players;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Show Full Playlist")
			{
				gameSetting = SettingsController.full_playlist;
			}
		}
		else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Analytics Privacy Dialog")
		{
			gameSetting = null;
		}
		return gameSetting;
	}

	protected override void \u02BA\u02B8\u02B4\u02BA\u02BD\u02BA\u02B7\u02C1\u02B8\u02B8\u02BC()
	{
	}

	public virtual void \u02B3\u02C1\u02B8\u02BA\u02B2\u02B8\u02B5\u02B6\u02B2\u02B5\u02BA()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (this.changedSetting == null)
		{
			this.changedSetting = base.currentSelectionString;
			string changedSetting = this.changedSetting;
			uint num = PrivateImplementationDetails.ComputeStringHash(changedSetting);
			if (num <= 119U)
			{
				if (num <= 4294967133U)
				{
					if (num <= 188U)
					{
						if (num != 170U)
						{
							if (num == 4294967100U)
							{
								if (changedSetting == "Ready")
								{
									Helper.\u02BA\u02BB\u02B7\u02B4\u02B2\u02BC\u02B4\u02B2\u02B9\u02B3\u02BD(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02BB\u02B7\u02BB\u02B8\u02B5\u02B9\u02BA\u02B3\u02B8\u02BA);
									this.changedSetting = null;
									return;
								}
							}
						}
						else if (changedSetting == "{\"icons\":")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.auto_screenshot;
						}
					}
					else if (num != 54U)
					{
						if (num != 31U)
						{
							if (num == 15U)
							{
								if (changedSetting == "album.jpg")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.showremotenames;
								}
							}
						}
						else if (changedSetting == "{0}, {1}, {2}")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.drum_pad_scrolling;
						}
					}
					else if (changedSetting == "loading_phrase")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02B9\u02C1\u02BE\u02B3\u02B5\u02B6\u02C0\u02BA\u02B9\u02B5\u02B4;
					}
				}
				else if (num <= 132U)
				{
					if (num != 16U)
					{
						if (num != 82U)
						{
							if (num == 155U)
							{
								if (changedSetting == "part drums")
								{
									Helper.\u02BA\u02BB\u02B7\u02B4\u02B2\u02BC\u02B4\u02B2\u02B9\u02B3\u02BD(GameLogManager.\u02BA\u02BF\u02B2\u02B6\u02B6\u02B5\u02BE\u02BF\u02BD\u02B4\u02BF());
									this.changedSetting = null;
									return;
								}
							}
						}
						else if (changedSetting == "Guitar Coop")
						{
							this.confirmMenu.Enable("playerCount", "Received too many song start packets!", "Classic", new ConfirmationMenu.CallFunc(this.\u02B2\u02BE\u02B8\u02B3\u02BC\u02B3\u02C1\u02B3\u02C1\u02BB\u02BE), null, null);
							this.changedSetting = null;
							return;
						}
					}
					else if (changedSetting == "Song Offset")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02B3\u02BD\u02B9\u02B4\u02C0\u02B2\u02B4\u02BF\u02BD\u02B9\u02C1;
					}
				}
				else if (num != 35U)
				{
					if (num != 4294967294U)
					{
						if (num == 61U)
						{
							if (changedSetting == "highway_")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02BA\u02BE\u02BB\u02B7\u02BE\u02BD\u02BE\u02BC\u02B2\u02B7;
							}
						}
					}
					else if (changedSetting == "Kick")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.highwayplacement;
					}
				}
				else if (changedSetting == "hasMedium")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02BC\u02BB\u02BD\u02B5\u02BD\u02B5\u02B5\u02BD\u02B9\u02BA\u02BF;
				}
			}
			else if (num <= 168U)
			{
				if (num <= 52U)
				{
					if (num != 93U)
					{
						if (num != 4294967257U)
						{
							if (num == 16U)
							{
								if (changedSetting == "t1 gems")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02BB\u02BC\u02B7\u02B9\u02BF\u02C1\u02C1\u02B6\u02B9\u02B6\u02C1;
								}
							}
						}
						else if (changedSetting == "Are you sure you want to quit?")
						{
							SongPathsManager.\u02C1\u02B5\u02C0\u02B4\u02BD\u02BD\u02BD\u02BD\u02C1\u02BE\u02B2();
							this.changedSetting = null;
							return;
						}
					}
					else if (changedSetting == "You must restart, settings were changed")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02B4\u02B9\u02B5\u02B7\u02BA\u02C0\u02B6\u02BE\u02BB\u02B7\u02C0;
					}
				}
				else if (num != 4294967257U)
				{
					if (num != 4294967190U)
					{
						if (num == 76U)
						{
							if (changedSetting == "Dynamics Threshold")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.language;
							}
						}
					}
					else if (changedSetting == "Played")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.force_remote_righty;
					}
				}
				else if (changedSetting == "song")
				{
					this.changedSetting = null;
					if (this.songScan.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
					{
						this.confirmMenu.\u02B7\u02B3\u02BC\u02BE\u02BF\u02B7\u02B4\u02C0\u02B9\u02BC\u02BF("star_deployed", ">", null, null, null, null);
						return;
					}
					base.StartCoroutine(this.\u02B9\u02B5\u02BB\u02B2\u02BC\u02B6\u02C1\u02B6\u02C0\u02B3\u02BC(false));
					return;
				}
			}
			else if (num <= 4294967156U)
			{
				if (num != 59U)
				{
					if (num != 4294967180U)
					{
						if (num == 4294967114U)
						{
							if (changedSetting == "Ball(Clone)")
							{
								this.changedSetting = null;
								this.analyticsMenu.SetActive(false);
							}
						}
					}
					else if (changedSetting == "Text resource in language file '{0}' c")
					{
						this.changedSetting = null;
						if (this.songScan.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
						{
							this.confirmMenu.Enable("song", "Show in File Explorer", null, null, null, null);
							return;
						}
						base.StartCoroutine(this.\u02B7\u02BE\u02BF\u02B6\u02BE\u02BC\u02C0\u02B6\u02B4\u02B3\u02BB(true));
						return;
					}
				}
				else if (changedSetting == "particles")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BA\u02BF\u02BF\u02B7\u02B4\u02B6\u02BD\u02BC\u02BE\u02B5\u02BA;
				}
			}
			else if (num != 4294967104U)
			{
				if (num != 4294967293U)
				{
					if (num == 4294967232U)
					{
						if (changedSetting == "More Stats")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.only_show_local_players;
						}
					}
				}
				else if (changedSetting == "")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.full_playlist;
				}
			}
			else if (changedSetting == " cannot find next node called ")
			{
				this.changedSetting = null;
				SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.Reset();
				this.confirmMenu.Enable("charter", "songs.json", null, null, null, null);
				return;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02B4\u02BA\u02B4\u02B2\u02B9\u02BF\u02BB\u02BE\u02B2\u02B9\u02B9;
			return;
		}
		this.\u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1();
		this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02BD\u02BD\u02B6\u02C1\u02B6\u02BD\u02BA\u02B8\u02BE\u02BF\u02B9;
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.changedSetting = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	protected virtual void \u02BB\u02BA\u02BE\u02B3\u02BA\u02B6\u02B9\u02B7\u02BD\u02BA\u02B3()
	{
		if (this.changedSetting == null || this.songScan.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA || this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		string changedSetting = this.changedSetting;
		string changedSetting2 = this.changedSetting;
		if (!(changedSetting2 == "menu_volume"))
		{
			if (changedSetting2 == "")
			{
				\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BC\u02B6\u02C1\u02B4\u02B6\u02BC\u02BA\u02B3\u02BE\u02B8();
			}
		}
		else
		{
			this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue];
		}
		this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(this.changedSetting);
	}

	private IEnumerator \u02B9\u02B5\u02BB\u02B2\u02BC\u02B6\u02C1\u02B6\u02C0\u02B3\u02BC(bool \u02BB\u02B8\u02B9\u02BF\u02B3\u02BB\u02B2\u02B6\u02B4\u02B4\u02B7)
	{
		GeneralSettingsMenu.\u02C1\u02B8\u02B9\u02C1\u02B7\u02B8\u02B3\u02B8\u02BA\u02B2\u02B5 u02C1_u02B8_u02B9_u02C1_u02B7_u02B8_u02B3_u02B8_u02BA_u02B2_u02B = new GeneralSettingsMenu.\u02C1\u02B8\u02B9\u02C1\u02B7\u02B8\u02B3\u02B8\u02BA\u02B2\u02B5(1);
		u02C1_u02B8_u02B9_u02C1_u02B7_u02B8_u02B3_u02B8_u02BA_u02B2_u02B.<>4__this = this;
		u02C1_u02B8_u02B9_u02C1_u02B7_u02B8_u02B3_u02B8_u02BA_u02B2_u02B.isJSON = \u02BB\u02B8\u02B9\u02BF\u02B3\u02BB\u02B2\u02B6\u02B4\u02B4\u02B7;
		return u02C1_u02B8_u02B9_u02C1_u02B7_u02B8_u02B3_u02B8_u02BA_u02B2_u02B;
	}

	public virtual void \u02B4\u02B6\u02B6\u02BF\u02B9\u02C0\u02C0\u02C0\u02C0\u02C1\u02B7(string \u02B4\u02B9\u02B3\u02B9\u02BC\u02C1\u02BE\u02BF\u02B4\u02B9\u02C0 = "")
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
			if (num <= 151U)
			{
				if (num <= 4294967189U)
				{
					if (num != 4294967259U)
					{
						if (num != 4294967145U)
						{
							if (num == 4294967246U)
							{
								if (text == "Color Profile")
								{
									base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(1, settingFromString);
								}
							}
						}
						else if (text == "songSpeed")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(7, settingFromString);
						}
					}
					else if (text == "g")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(6, settingFromString);
					}
				}
				else if (num <= 4294967259U)
				{
					if (num != 4294967242U)
					{
						if (num == 4294967114U)
						{
							if (text == " does not contain any audio files.")
							{
								base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(6, settingFromString);
							}
						}
					}
					else if (text == "{0} ({1})")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(7, settingFromString);
					}
				}
				else if (num != 4294967289U)
				{
					if (num == 112U)
					{
						if (text == "Start")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(5, settingFromString);
						}
					}
				}
				else if (text == "soloend")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
				}
			}
			else if (num <= 138U)
			{
				if (num <= 4294967195U)
				{
					if (num != 4294967121U)
					{
						if (num == 93U)
						{
							if (text == "drumsortholdtip")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(6, settingFromString);
							}
						}
					}
					else if (text == "6-fret Guitar")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
					}
				}
				else if (num != 100U)
				{
					if (num == 4294967201U)
					{
						if (text == "groupOverHits")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(8, settingFromString);
						}
					}
				}
				else if (text == ".yaml")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(3, settingFromString);
				}
			}
			else if (num <= 110U)
			{
				if (num != 127U)
				{
					if (num == 4294967203U)
					{
						if (text == "drumsorttip")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(8, settingFromString);
						}
					}
				}
				else if (text == "Set B Position")
				{
					this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[settingFromString.CurrentValue]);
				}
			}
			else if (num != 51U)
			{
				if (num == 56U)
				{
					if (text == "Hit Notes")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(8, settingFromString);
					}
				}
			}
			else if (text == "scoreDisabled")
			{
				base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
			}
		}
	}

	protected virtual void \u02BC\u02BB\u02BF\u02C1\u02BB\u02BC\u02C0\u02B2\u02BE\u02B7\u02B3()
	{
		if (this.changedSetting == null || this.songScan.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA || this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		string changedSetting = this.changedSetting;
		string changedSetting2 = this.changedSetting;
		if (!(changedSetting2 == "Dropless Sustains"))
		{
			if (changedSetting2 == "playerCount")
			{
				\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BC\u02B6\u02C1\u02B4\u02B6\u02BC\u02BA\u02B3\u02BE\u02B8();
			}
		}
		else
		{
			this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue];
		}
		this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(this.changedSetting);
	}

	private void \u02B9\u02B9\u02B9\u02BD\u02B5\u02B6\u02B8\u02B3\u02BE\u02B2\u02B3()
	{
		this.\u02C1\u02B6\u02B7\u02BC\u02B3\u02BE\u02B3\u02C1\u02B4\u02B2\u02BC.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Main Menu", 0f);
	}

	protected override void Update()
	{
		if (this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 || this.exportSongList.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 || this.songScan.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA || this.analyticsMenu.activeSelf)
		{
			return;
		}
		base.Update();
	}

	protected virtual void \u02BA\u02BC\u02C1\u02B5\u02B7\u02B9\u02BF\u02B3\u02B8\u02B4\u02B6()
	{
		if (this.changedSetting == "Drum Pad Scrolling" && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA())
		{
			(this.\u02C1\u02B6\u02B7\u02BC\u02B3\u02BE\u02B3\u02C1\u02B4\u02B2\u02BC as SettingsMenu).\u02BC\u02BD\u02BE\u02B9\u02B8\u02B2\u02BB\u02B9\u02BD\u02BD\u02B5();
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			this.confirmMenu.\u02B7\u02B3\u02BC\u02BE\u02BF\u02B7\u02B4\u02C0\u02B9\u02BC\u02BF("", "+", null, new ConfirmationMenu.CallFunc(this.\u02B9\u02B9\u02B9\u02BD\u02B5\u02B6\u02B8\u02B3\u02BE\u02B2\u02B3), new ConfirmationMenu.CallFunc(this.\u02B9\u02B9\u02B9\u02BD\u02B5\u02B6\u02B8\u02B3\u02BE\u02B2\u02B3), null);
		}
	}

	public override void SetBools()
	{
	}

	protected virtual GameSetting \u02BC\u02B2\u02B2\u02BD\u02BB\u02B5\u02B7\u02B6\u02BE\u02B8\u02BA(string \u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0)
	{
		GameSetting gameSetting = null;
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0);
		if (num <= 4294967196U)
		{
			if (num <= 4294967213U)
			{
				if (num <= 4294967125U)
				{
					if (num != 78U)
					{
						if (num == 60U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Color Profile")
							{
								gameSetting = null;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Green Cymbal")
					{
						gameSetting = SettingsController.auto_screenshot;
					}
				}
				else if (num != 174U)
				{
					if (num == 50U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "hasSixFret")
						{
							gameSetting = SettingsController.drum_pad_scrolling;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "NoteLayerFadeable")
				{
					gameSetting = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02B9\u02C1\u02BE\u02B3\u02B5\u02B6\u02C0\u02BA\u02B9\u02B5\u02B4;
				}
			}
			else if (num <= 4294967192U)
			{
				if (num != 4294967247U)
				{
					if (num == 4294967105U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "<color=#FFFF04FF>{0}</color> {1}")
						{
							gameSetting = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02B3\u02BD\u02B9\u02B4\u02C0\u02B2\u02B4\u02BF\u02BD\u02B9\u02C1;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "end_events")
				{
					gameSetting = SettingsController.showremotenames;
				}
			}
			else if (num != 4294967249U)
			{
				if (num != 4294967260U)
				{
					if (num == 4294967290U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "soloPointsText")
						{
							gameSetting = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02BC\u02BB\u02BD\u02B5\u02BD\u02B5\u02B5\u02BD\u02B9\u02BA\u02BF;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "{0}/cached-thumbs")
				{
					gameSetting = null;
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Selection")
			{
				gameSetting = null;
			}
		}
		else if (num <= 15U)
		{
			if (num <= 167U)
			{
				if (num != 4294967268U)
				{
					if (num == 4294967260U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Highway SP Effects")
						{
							gameSetting = SettingsController.\u02BC\u02BA\u02BE\u02BB\u02B7\u02BE\u02BD\u02BE\u02BC\u02B2\u02B7;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Fullscreen")
				{
					gameSetting = SettingsController.highwayplacement;
				}
			}
			else if (num != 4294967288U)
			{
				if (num != 170U)
				{
					if (num == 4294967289U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Video Start Time")
						{
							gameSetting = SettingsController.force_remote_righty;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == " ")
				{
					gameSetting = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02BB\u02BC\u02B7\u02B9\u02BF\u02C1\u02C1\u02B6\u02B9\u02B6\u02C1;
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "_x")
			{
				gameSetting = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02B4\u02B9\u02B5\u02B7\u02BA\u02C0\u02B6\u02BE\u02BB\u02B7\u02C0;
			}
		}
		else if (num <= 182U)
		{
			if (num != 25U)
			{
				if (num == 76U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "artist")
					{
						gameSetting = SettingsController.\u02BA\u02BF\u02BF\u02B7\u02B4\u02B6\u02BD\u02BC\u02BE\u02B5\u02BA;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "song")
			{
				gameSetting = SettingsController.language;
			}
		}
		else if (num != 4294967209U)
		{
			if (num != 4294967115U)
			{
				if (num == 192U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "playTime")
					{
						gameSetting = SettingsController.only_show_local_players;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "drums")
			{
				gameSetting = SettingsController.full_playlist;
			}
		}
		else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Rhythm Guitar")
		{
			gameSetting = null;
		}
		return gameSetting;
	}

	protected override void \u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1()
	{
		if (this.changedSetting == "Language" && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA())
		{
			(this.\u02C1\u02B6\u02B7\u02BC\u02B3\u02BE\u02B3\u02C1\u02B4\u02B2\u02BC as SettingsMenu).\u02B5\u02C1\u02B9\u02B8\u02C1\u02B3\u02B7\u02B8\u02B2\u02B6\u02B7();
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			this.confirmMenu.Enable("languageRestartNeeded", "Okay", null, new ConfirmationMenu.CallFunc(this.\u02B9\u02B9\u02B9\u02BD\u02B5\u02B6\u02B8\u02B3\u02BE\u02B2\u02B3), new ConfirmationMenu.CallFunc(this.\u02B9\u02B9\u02B9\u02BD\u02B5\u02B6\u02B8\u02B3\u02BE\u02B2\u02B3), null);
		}
	}

	private void \u02BA\u02C1\u02BC\u02B7\u02BB\u02B3\u02B7\u02B3\u02B5\u02B2\u02B3()
	{
		base.StartCoroutine(this.\u02BA\u02BE\u02B9\u02B7\u02B9\u02BD\u02B4\u02B8\u02C1\u02C1\u02B7());
	}

	protected virtual void \u02BE\u02C1\u02BB\u02BE\u02BE\u02B4\u02B6\u02BC\u02BB\u02BF\u02BD()
	{
		if (this.changedSetting == null || this.songScan.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA || this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		string changedSetting = this.changedSetting;
		string changedSetting2 = this.changedSetting;
		if (!(changedSetting2 == "charter"))
		{
			if (changedSetting2 == "diff_bassghl")
			{
				\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BC\u02B6\u02C1\u02B4\u02B6\u02BC\u02BA\u02B3\u02BE\u02B8();
			}
		}
		else
		{
			this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue];
		}
		this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(this.changedSetting);
	}

	private IEnumerator \u02B4\u02B7\u02B8\u02B8\u02B6\u02BA\u02BD\u02C0\u02BA\u02BC\u02B6()
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
		this.songScan.\u02BB\u02B7\u02BC\u02C0\u02BC\u02B8\u02BB\u02B5\u02C1\u02B3\u02BE();
		if (this.songScan.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
		{
			yield break;
		}
		this.songScan.\u02BA\u02B9\u02C0\u02C1\u02BF\u02BB\u02B3\u02B9\u02BB\u02B5\u02B3(true);
		yield break;
	}

	private IEnumerator \u02BA\u02BE\u02B9\u02B7\u02B9\u02BD\u02B4\u02B8\u02C1\u02C1\u02B7()
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
		this.songScan.\u02BB\u02B7\u02BC\u02C0\u02BC\u02B8\u02BB\u02B5\u02C1\u02B3\u02BE();
		if (this.songScan.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
		{
			yield break;
		}
		this.songScan.\u02BA\u02B9\u02C0\u02C1\u02BF\u02BB\u02B3\u02B9\u02BB\u02B5\u02B3(true);
		yield break;
	}

	private IEnumerator \u02B8\u02B7\u02B9\u02C0\u02C0\u02C1\u02BE\u02BF\u02BC\u02BF\u02BE(bool \u02BB\u02B8\u02B9\u02BF\u02B3\u02BB\u02B2\u02B6\u02B4\u02B4\u02B7)
	{
		GeneralSettingsMenu.\u02C1\u02B8\u02B9\u02C1\u02B7\u02B8\u02B3\u02B8\u02BA\u02B2\u02B5 u02C1_u02B8_u02B9_u02C1_u02B7_u02B8_u02B3_u02B8_u02BA_u02B2_u02B = new GeneralSettingsMenu.\u02C1\u02B8\u02B9\u02C1\u02B7\u02B8\u02B3\u02B8\u02BA\u02B2\u02B5(1);
		u02C1_u02B8_u02B9_u02C1_u02B7_u02B8_u02B3_u02B8_u02BA_u02B2_u02B.<>4__this = this;
		u02C1_u02B8_u02B9_u02C1_u02B7_u02B8_u02B3_u02B8_u02BA_u02B2_u02B.isJSON = \u02BB\u02B8\u02B9\u02BF\u02B3\u02BB\u02B2\u02B6\u02B4\u02B4\u02B7;
		return u02C1_u02B8_u02B9_u02C1_u02B7_u02B8_u02B3_u02B8_u02BA_u02B2_u02B;
	}

	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (this.changedSetting == null)
		{
			this.changedSetting = base.currentSelectionString;
			string changedSetting = this.changedSetting;
			uint num = PrivateImplementationDetails.ComputeStringHash(changedSetting);
			if (num <= 2126712851U)
			{
				if (num <= 843734599U)
				{
					if (num <= 747914534U)
					{
						if (num != 139433807U)
						{
							if (num == 747914534U)
							{
								if (changedSetting == "Open Default Songs Folder")
								{
									Helper.\u02BA\u02BB\u02B7\u02B4\u02B2\u02BC\u02B4\u02B2\u02B9\u02B3\u02BD(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02BB\u02B7\u02BB\u02B8\u02B5\u02B9\u02BA\u02B3\u02B8\u02BA);
									this.changedSetting = null;
									return;
								}
							}
						}
						else if (changedSetting == "AutoSave Results Screenshot")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.auto_screenshot;
						}
					}
					else if (num != 773019664U)
					{
						if (num != 834568855U)
						{
							if (num == 843734599U)
							{
								if (changedSetting == "Show Remote Player Names")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.showremotenames;
								}
							}
						}
						else if (changedSetting == "Drum Pad Scrolling")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.drum_pad_scrolling;
						}
					}
					else if (changedSetting == "Minimum Speed")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02B9\u02C1\u02BE\u02B3\u02B5\u02B6\u02C0\u02BA\u02B9\u02B5\u02B4;
					}
				}
				else if (num <= 1348092204U)
				{
					if (num != 1190966539U)
					{
						if (num != 1297251446U)
						{
							if (num == 1348092204U)
							{
								if (changedSetting == "Open Logs Folder")
								{
									Helper.\u02BA\u02BB\u02B7\u02B4\u02B2\u02BC\u02B4\u02B2\u02B9\u02B3\u02BD(GameLogManager.\u02BA\u02BF\u02B2\u02B6\u02B6\u02B5\u02BE\u02BF\u02BD\u02B4\u02BF());
									this.changedSetting = null;
									return;
								}
							}
						}
						else if (changedSetting == "Scan Songs")
						{
							this.confirmMenu.Enable("This will take a while. Are you sure?", "Yes", "No", new ConfirmationMenu.CallFunc(this.\u02B2\u02B7\u02BF\u02B8\u02B2\u02B3\u02B3\u02B2\u02BE\u02B5\u02BF), null, null);
							this.changedSetting = null;
							return;
						}
					}
					else if (changedSetting == "Allow Clients To Remove Songs")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02B3\u02BD\u02B9\u02B4\u02C0\u02B2\u02B4\u02BF\u02BD\u02B9\u02C1;
					}
				}
				else if (num != 2000281641U)
				{
					if (num != 2046560590U)
					{
						if (num == 2126712851U)
						{
							if (changedSetting == "Highway Placement")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02BA\u02BE\u02BB\u02B7\u02BE\u02BD\u02BE\u02BC\u02B2\u02B7;
							}
						}
					}
					else if (changedSetting == "Online Highway Placement")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.highwayplacement;
					}
				}
				else if (changedSetting == "Server Tickrate")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02BC\u02BB\u02BD\u02B5\u02BD\u02B5\u02B5\u02BD\u02B9\u02BA\u02BF;
				}
			}
			else if (num <= 2591284123U)
			{
				if (num <= 2335906414U)
				{
					if (num != 2238208579U)
					{
						if (num != 2319031723U)
						{
							if (num == 2335906414U)
							{
								if (changedSetting == "Maximum Speed")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02BB\u02BC\u02B7\u02B9\u02BF\u02C1\u02C1\u02B6\u02B9\u02B6\u02C1;
								}
							}
						}
						else if (changedSetting == "Manage Song Paths")
						{
							SongPathsManager.\u02BE\u02B3\u02B7\u02BD\u02BA\u02BB\u02B4\u02B7\u02B5\u02B3\u02B2();
							this.changedSetting = null;
							return;
						}
					}
					else if (changedSetting == "Songs Per Player")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = \u02BF\u02B3\u02B6\u02B5\u02C1\u02B5\u02B3\u02BF\u02B7\u02B4\u02B9.\u02B4\u02B9\u02B5\u02B7\u02BA\u02C0\u02B6\u02BE\u02BB\u02B7\u02C0;
					}
				}
				else if (num != 2380267857U)
				{
					if (num != 2451769732U)
					{
						if (num == 2591284123U)
						{
							if (changedSetting == "Language")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.language;
							}
						}
					}
					else if (changedSetting == "Remote Player Righty Flip")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.force_remote_righty;
					}
				}
				else if (changedSetting == "Export Song List (JSON)")
				{
					this.changedSetting = null;
					if (this.songScan.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
					{
						this.confirmMenu.Enable("Songs are still scanning...", "Okay", null, null, null, null);
						return;
					}
					base.StartCoroutine(this.\u02B7\u02BE\u02BF\u02B6\u02BE\u02BC\u02C0\u02B6\u02B4\u02B3\u02BB(true));
					return;
				}
			}
			else if (num <= 2970547677U)
			{
				if (num != 2780239723U)
				{
					if (num != 2873334376U)
					{
						if (num == 2970547677U)
						{
							if (changedSetting == "Analytics Privacy Dialog")
							{
								this.changedSetting = null;
								this.analyticsMenu.SetActive(true);
							}
						}
					}
					else if (changedSetting == "Export Song List")
					{
						this.changedSetting = null;
						if (this.songScan.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
						{
							this.confirmMenu.Enable("Songs are still scanning...", "Okay", null, null, null, null);
							return;
						}
						base.StartCoroutine(this.\u02B7\u02BE\u02BF\u02B6\u02BE\u02BC\u02C0\u02B6\u02B4\u02B3\u02BB(false));
						return;
					}
				}
				else if (changedSetting == "Export Current Song")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BA\u02BF\u02BF\u02B7\u02B4\u02B6\u02BD\u02BC\u02BE\u02B5\u02BA;
				}
			}
			else if (num != 3175409916U)
			{
				if (num != 4185652605U)
				{
					if (num == 4281963163U)
					{
						if (changedSetting == "Hide Remote Highways")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.only_show_local_players;
						}
					}
				}
				else if (changedSetting == "Show Full Playlist")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.full_playlist;
				}
			}
			else if (changedSetting == "Reset Score Box Placement")
			{
				this.changedSetting = null;
				SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.Reset();
				this.confirmMenu.Enable("scoreboxreset", "Okay", null, null, null, null);
				return;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02B4\u02BA\u02B4\u02B2\u02B9\u02BF\u02BB\u02BE\u02B2\u02B9\u02B9;
			return;
		}
		this.\u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1();
		this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02BD\u02BD\u02B6\u02C1\u02B6\u02BD\u02BA\u02B8\u02BE\u02BF\u02B9;
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.changedSetting = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	private void \u02B2\u02BE\u02B8\u02B3\u02BC\u02B3\u02C1\u02B3\u02C1\u02BB\u02BE()
	{
		base.StartCoroutine(this.\u02BA\u02BE\u02B9\u02B7\u02B9\u02BD\u02B4\u02B8\u02C1\u02C1\u02B7());
	}

	private void \u02B2\u02B7\u02BF\u02B8\u02B2\u02B3\u02B3\u02B2\u02BE\u02B5\u02BF()
	{
		base.StartCoroutine(this.\u02BA\u02BE\u02B9\u02B7\u02B9\u02BD\u02B4\u02B8\u02C1\u02C1\u02B7());
	}

	[SerializeField]
	private SongSelect songSelect;

	[SerializeField]
	private ExportSongList exportSongList;

	[SerializeField]
	private SongScan songScan;

	[SerializeField]
	private ConfirmationMenu confirmMenu;

	[SerializeField]
	private GameObject analyticsMenu;

	private List<string> \u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1 = new List<string>();
}
