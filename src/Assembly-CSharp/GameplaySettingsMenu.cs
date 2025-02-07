﻿using System;
using System.Collections.Generic;
using System.IO;
using Rewired;
using StrikeCore;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplaySettingsMenu : BaseSettingMenu
{
	protected override GameSetting GetSettingFromString(string \u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0)
	{
		GameSetting gameSetting = null;
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0);
		if (num <= 2125539120U)
		{
			if (num <= 972458324U)
			{
				if (num <= 537478040U)
				{
					if (num != 186896582U)
					{
						if (num != 363977971U)
						{
							if (num == 537478040U)
							{
								if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Audio Offset")
								{
									gameSetting = SettingsController.audioOffset;
								}
							}
						}
						else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Practice Start Delay")
						{
							gameSetting = SettingsController.practice_delay;
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Default Search By Current Sort")
					{
						gameSetting = SettingsController.default_search_by_current_sort;
					}
				}
				else if (num <= 580693481U)
				{
					if (num != 554341610U)
					{
						if (num == 580693481U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Practice Star Power")
							{
								gameSetting = SettingsController.practice_sp;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Highway Shake")
					{
						gameSetting = SettingsController.\u02BF\u02BF\u02BB\u02BF\u02B2\u02BE\u02B5\u02BD\u02C0\u02B4\u02B9;
					}
				}
				else if (num != 669190543U)
				{
					if (num == 972458324U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Pause on Focus Lost")
						{
							gameSetting = SettingsController.\u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Double Strum Prevention")
				{
					gameSetting = SettingsController.doubleStrumPrevention;
				}
			}
			else if (num <= 1485671700U)
			{
				if (num <= 1351274325U)
				{
					if (num != 1224852698U)
					{
						if (num == 1351274325U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Allow Duplicate Songs")
							{
								gameSetting = SettingsController.allow_duplicate_songs;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Background Video")
					{
						gameSetting = SettingsController.background_video;
					}
				}
				else if (num != 1476092947U)
				{
					if (num == 1485671700U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Controller Poll Rate")
						{
							gameSetting = SettingsController.\u02BC\u02BA\u02BE\u02B9\u02B5\u02BD\u02C1\u02B8\u02B7\u02C0\u02B8;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Show Hit Window")
				{
					gameSetting = SettingsController.show_hit_window;
				}
			}
			else if (num <= 1976894744U)
			{
				if (num != 1753283860U)
				{
					if (num == 1976894744U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Default Sort Filter")
						{
							gameSetting = SettingsController.sort_filter;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Song Highways")
				{
					gameSetting = SettingsController.\u02C1\u02BF\u02C0\u02BF\u02B8\u02B8\u02C0\u02C0\u02B3\u02B3\u02BB;
				}
			}
			else if (num != 2087995404U)
			{
				if (num == 2125539120U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Note Animation FPS")
					{
						gameSetting = SettingsController.\u02BC\u02B6\u02BD\u02B5\u02B4\u02C0\u02B2\u02B8\u02B7\u02BC\u02B6;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Mute Track on Miss")
			{
				gameSetting = SettingsController.mute_on_miss;
			}
		}
		else if (num <= 3148303310U)
		{
			if (num <= 2351279455U)
			{
				if (num != 2209223988U)
				{
					if (num != 2325855612U)
					{
						if (num == 2351279455U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Video Offset")
							{
								gameSetting = SettingsController.videoOffset;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Song Videos")
					{
						gameSetting = SettingsController.\u02BE\u02B6\u02BA\u02C0\u02B9\u02B6\u02B2\u02BB\u02B3\u02B3\u02BA;
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Star Animation FPS")
				{
					gameSetting = SettingsController.\u02B4\u02B5\u02BE\u02B6\u02BC\u02B7\u02BB\u02B5\u02B7\u02BF\u02C0;
				}
			}
			else if (num <= 2927438748U)
			{
				if (num != 2430087688U)
				{
					if (num == 2927438748U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Background Image")
						{
							gameSetting = SettingsController.background_image;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Use Song Backgrounds")
				{
					gameSetting = SettingsController.song_backgrounds;
				}
			}
			else if (num != 3140304007U)
			{
				if (num == 3148303310U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "No Fail")
					{
						gameSetting = SettingsController.\u02BB\u02C0\u02B7\u02B8\u02B3\u02BE\u02B7\u02BB\u02BA\u02B8\u02BA;
					}
				}
			}
			else if (!(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Calibration Tool"))
			{
			}
		}
		else if (num <= 3510823811U)
		{
			if (num <= 3235865788U)
			{
				if (num != 3224438732U)
				{
					if (num == 3235865788U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Show Lyrics")
						{
							gameSetting = SettingsController.enable_lyrics;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Measure Based Countdowns")
				{
					gameSetting = SettingsController.measure_countdown;
				}
			}
			else if (num != 3502736215U)
			{
				if (num == 3510823811U)
				{
					if (!(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Get Hardware Latency"))
					{
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Show Bot Score")
			{
				gameSetting = SettingsController.show_bot_score;
			}
		}
		else if (num <= 3587543207U)
		{
			if (num != 3558350423U)
			{
				if (num == 3587543207U)
				{
					if (!(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Scan Custom Images"))
					{
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Song Speed")
			{
				gameSetting = SettingsController.song_speed;
			}
		}
		else if (num != 3924729133U)
		{
			if (num == 4199460336U)
			{
				if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Show Lyrics Background")
				{
					gameSetting = SettingsController.enable_lyrics_bg;
				}
			}
		}
		else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Gem Size")
		{
			gameSetting = SettingsController.gem_size;
		}
		return gameSetting;
	}

	private void \u02C1\u02BE\u02B9\u02B8\u02B7\u02BF\u02B8\u02B9\u02BF\u02B3\u02B6()
	{
		Debug.Log("Starting calibration");
		this.menuMusic.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(true);
		SceneManager.LoadScene("CalTest");
	}

	private void \u02B6\u02B3\u02C1\u02B3\u02B4\u02C1\u02B6\u02B3\u02B7\u02BB\u02B4()
	{
		Debug.Log("Crowd");
		this.menuMusic.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(false);
		SceneManager.LoadScene(" cannot find next node called ");
	}

	public virtual void \u02B4\u02BF\u02BC\u02B9\u02BA\u02B9\u02B9\u02B4\u02B8\u02C1\u02BA()
	{
		base.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = 0;
	}

	private string \u02BF\u02B7\u02BE\u02BD\u02BC\u02BB\u02C0\u02BA\u02C0\u02BD\u02BF(int \u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2, string \u02C1\u02B6\u02B5\u02BD\u02BA\u02BF\u02B8\u02C0\u02B6\u02C1\u02BA, string[] \u02B5\u02BA\u02BC\u02B3\u02B9\u02B7\u02B8\u02B7\u02C1\u02BE\u02C1)
	{
		string text = \u02C1\u02B6\u02B5\u02BD\u02BA\u02BF\u02B8\u02C0\u02B6\u02C1\u02BA;
		bool flag = \u02B5\u02BA\u02BC\u02B3\u02B9\u02B7\u02B8\u02B7\u02C1\u02BE\u02C1 != null && \u02B5\u02BA\u02BC\u02B3\u02B9\u02B7\u02B8\u02B7\u02C1\u02BE\u02C1.Length != 0;
		if (\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2 >= 0)
		{
			text = Path.GetFileNameWithoutExtension(\u02B5\u02BA\u02BC\u02B3\u02B9\u02B7\u02B8\u02B7\u02C1\u02BE\u02C1[\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2]);
		}
		else if (\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2 == -1)
		{
			text = LanguageManager.instance.GetString("Random");
		}
		else if (\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2 == -2 && flag)
		{
			text = LanguageManager.instance.GetString("None");
		}
		return text;
	}

	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		if (this.changedSetting == null)
		{
			this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02B4\u02BA\u02B4\u02B2\u02B9\u02BF\u02BB\u02BE\u02B2\u02B9\u02B9;
			this.changedSetting = base.currentSelectionString;
			string changedSetting = this.changedSetting;
			uint num = PrivateImplementationDetails.ComputeStringHash(changedSetting);
			if (num <= 2125539120U)
			{
				if (num <= 972458324U)
				{
					if (num <= 537478040U)
					{
						if (num != 186896582U)
						{
							if (num != 363977971U)
							{
								if (num == 537478040U)
								{
									if (changedSetting == "Audio Offset")
									{
										this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.audioOffset;
									}
								}
							}
							else if (changedSetting == "Practice Start Delay")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.practice_delay;
							}
						}
						else if (changedSetting == "Default Search By Current Sort")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.default_search_by_current_sort;
						}
					}
					else if (num <= 580693481U)
					{
						if (num != 554341610U)
						{
							if (num == 580693481U)
							{
								if (changedSetting == "Practice Star Power")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.practice_sp;
								}
							}
						}
						else if (changedSetting == "Highway Shake")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BF\u02BF\u02BB\u02BF\u02B2\u02BE\u02B5\u02BD\u02C0\u02B4\u02B9;
						}
					}
					else if (num != 669190543U)
					{
						if (num == 972458324U)
						{
							if (changedSetting == "Pause on Focus Lost")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3;
							}
						}
					}
					else if (changedSetting == "Double Strum Prevention")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.doubleStrumPrevention;
					}
				}
				else if (num <= 1485671700U)
				{
					if (num <= 1351274325U)
					{
						if (num != 1224852698U)
						{
							if (num == 1351274325U)
							{
								if (changedSetting == "Allow Duplicate Songs")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.allow_duplicate_songs;
								}
							}
						}
						else if (changedSetting == "Background Video")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.background_video;
							this.\u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD.\u02C0\u02B3\u02BA\u02B7\u02B4\u02C0\u02BD\u02BD\u02BA\u02C1\u02BC(true);
							this.\u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD.\u02B3\u02C1\u02BC\u02BE\u02BD\u02BB\u02B9\u02B2\u02B4\u02B9\u02BE(this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue, true);
							if (!this.\u02C0\u02BA\u02B9\u02B7\u02B8\u02B6\u02B2\u02C1\u02BF\u02BD\u02B2)
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue = -2;
							}
						}
					}
					else if (num != 1476092947U)
					{
						if (num == 1485671700U)
						{
							if (changedSetting == "Controller Poll Rate")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02BA\u02BE\u02B9\u02B5\u02BD\u02C1\u02B8\u02B7\u02C0\u02B8;
							}
						}
					}
					else if (changedSetting == "Show Hit Window")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.show_hit_window;
					}
				}
				else if (num <= 1976894744U)
				{
					if (num != 1753283860U)
					{
						if (num == 1976894744U)
						{
							if (changedSetting == "Default Sort Filter")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.sort_filter;
							}
						}
					}
					else if (changedSetting == "Song Highways")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02C1\u02BF\u02C0\u02BF\u02B8\u02B8\u02C0\u02C0\u02B3\u02B3\u02BB;
					}
				}
				else if (num != 2087995404U)
				{
					if (num == 2125539120U)
					{
						if (changedSetting == "Note Animation FPS")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BC\u02B6\u02BD\u02B5\u02B4\u02C0\u02B2\u02B8\u02B7\u02BC\u02B6;
						}
					}
				}
				else if (changedSetting == "Mute Track on Miss")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.mute_on_miss;
				}
			}
			else if (num <= 3148303310U)
			{
				if (num <= 2351279455U)
				{
					if (num != 2209223988U)
					{
						if (num != 2325855612U)
						{
							if (num == 2351279455U)
							{
								if (changedSetting == "Video Offset")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.videoOffset;
								}
							}
						}
						else if (changedSetting == "Song Videos")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BE\u02B6\u02BA\u02C0\u02B9\u02B6\u02B2\u02BB\u02B3\u02B3\u02BA;
						}
					}
					else if (changedSetting == "Star Animation FPS")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B4\u02B5\u02BE\u02B6\u02BC\u02B7\u02BB\u02B5\u02B7\u02BF\u02C0;
					}
				}
				else if (num <= 2927438748U)
				{
					if (num != 2430087688U)
					{
						if (num == 2927438748U)
						{
							if (changedSetting == "Background Image")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.background_image;
								this.\u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD.\u02C0\u02B3\u02BA\u02B7\u02B4\u02C0\u02BD\u02BD\u02BA\u02C1\u02BC(true);
								this.\u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD.\u02B3\u02C1\u02BC\u02BE\u02BD\u02BB\u02B9\u02B2\u02B4\u02B9\u02BE(this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue, false);
								if (!this.\u02C0\u02BB\u02B6\u02B2\u02B5\u02BD\u02BC\u02B6\u02B9\u02B2\u02B9)
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue = -2;
								}
							}
						}
					}
					else if (changedSetting == "Use Song Backgrounds")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.song_backgrounds;
					}
				}
				else if (num != 3140304007U)
				{
					if (num == 3148303310U)
					{
						if (changedSetting == "No Fail")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02BB\u02C0\u02B7\u02B8\u02B3\u02BE\u02B7\u02BB\u02BA\u02B8\u02BA;
						}
					}
				}
				else if (changedSetting == "Calibration Tool")
				{
					this.\u02C1\u02BE\u02B9\u02B8\u02B7\u02BF\u02B8\u02B9\u02BF\u02B3\u02B6();
				}
			}
			else if (num <= 3510823811U)
			{
				if (num <= 3235865788U)
				{
					if (num != 3224438732U)
					{
						if (num == 3235865788U)
						{
							if (changedSetting == "Show Lyrics")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.enable_lyrics;
							}
						}
					}
					else if (changedSetting == "Measure Based Countdowns")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.measure_countdown;
					}
				}
				else if (num != 3502736215U)
				{
					if (num == 3510823811U)
					{
						if (changedSetting == "Get Hardware Latency")
						{
							SettingsController.audioOffset.CurrentValue = BassAudioManager.Instance.\u02C0\u02B6\u02B9\u02BF\u02B3\u02B3\u02BF\u02B6\u02BD\u02B3\u02BF();
							this.changedSetting = null;
							this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("");
							this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02BD\u02BD\u02B6\u02C1\u02B6\u02BD\u02BA\u02B8\u02BE\u02BF\u02B9;
							return;
						}
					}
				}
				else if (changedSetting == "Show Bot Score")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.show_bot_score;
				}
			}
			else if (num <= 3587543207U)
			{
				if (num != 3558350423U)
				{
					if (num == 3587543207U)
					{
						if (changedSetting == "Scan Custom Images")
						{
							GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02BE\u02B5\u02BC\u02B6\u02B5\u02BA\u02BD\u02B6\u02B5\u02B8(true);
							this.\u02BA\u02B8\u02B4\u02BA\u02BD\u02BA\u02B7\u02C1\u02B8\u02B8\u02BC();
							this.changedSetting = null;
							this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("Background Video");
							this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("Background Image");
							this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02BD\u02BD\u02B6\u02C1\u02B6\u02BD\u02BA\u02B8\u02BE\u02BF\u02B9;
							this.confirmMenu.Enable("contentscanned", "Okay", null, null, null, null);
							return;
						}
					}
				}
				else if (changedSetting == "Song Speed")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.song_speed;
				}
			}
			else if (num != 3924729133U)
			{
				if (num == 4199460336U)
				{
					if (changedSetting == "Show Lyrics Background")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.enable_lyrics_bg;
					}
				}
			}
			else if (changedSetting == "Gem Size")
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.gem_size;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02BD\u02BD\u02B6\u02C1\u02B6\u02BD\u02BA\u02B8\u02BE\u02BF\u02B9;
		this.\u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD.\u02C0\u02B3\u02BA\u02B7\u02B4\u02C0\u02BD\u02BD\u02BA\u02C1\u02BC(false);
		this.\u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1();
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.changedSetting = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public override void SetBools()
	{
	}

	private void \u02B7\u02BB\u02B4\u02BB\u02B8\u02B8\u02BA\u02BA\u02B4\u02C1\u02BE()
	{
		Debug.Log("Drums");
		this.menuMusic.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(false);
		SceneManager.LoadScene("Controller");
	}

	private void \u02C0\u02B8\u02BC\u02BC\u02B8\u02BB\u02BD\u02B8\u02BD\u02BD\u02B6()
	{
		Debug.Log("Input Device");
		this.menuMusic.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(false);
		SceneManager.LoadScene("album");
	}

	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		this.\u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD.\u02C0\u02B3\u02BA\u02B7\u02B4\u02C0\u02BD\u02BD\u02BA\u02C1\u02BC(false);
	}

	public virtual void \u02B8\u02B6\u02B2\u02B4\u02BD\u02BA\u02B4\u02BC\u02C1\u02B3\u02BF(string \u02B4\u02B9\u02B3\u02B9\u02BC\u02C1\u02BE\u02BF\u02B4\u02B9\u02C0 = "")
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
			if (num <= 53U)
			{
				if (num <= 4294967175U)
				{
					if (num <= 157U)
					{
						if (num != 4294967175U)
						{
							if (num != 4294967281U)
							{
								if (num == 4294967141U)
								{
									if (text == "=")
									{
										base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(3, settingFromString);
									}
								}
							}
							else if (text == "backend")
							{
								this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = BassAudioManager.\u02B9\u02B2\u02B6\u02BB\u02B4\u02B7\u02B6\u02B5\u02B7\u02B2\u02BA(settingFromString.CurrentValue).ToString();
							}
						}
						else if (text == "Spray")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(6, settingFromString);
						}
					}
					else if (num <= 4294967169U)
					{
						if (num != 33U)
						{
							if (num == 4294967157U)
							{
								if (text == "Rhythm Guitar")
								{
									base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(4, settingFromString);
								}
							}
						}
						else if (text == "song")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
						}
					}
					else if (num != 67U)
					{
						if (num == 161U)
						{
							if (text == "CPU: {0}, Count: {1}, Frequency: {2} MHz")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(5, settingFromString);
							}
						}
					}
					else if (text == "Delete Profile")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(-115, settingFromString);
					}
				}
				else if (num <= 4294967202U)
				{
					if (num <= 6U)
					{
						if (num != 4294967193U)
						{
							if (num == 93U)
							{
								if (text == "bassinitfail")
								{
									if (settingFromString == this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC)
									{
										this.\u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD.\u02C0\u02BC\u02B8\u02BA\u02BB\u02B5\u02B3\u02B8\u02BA\u02C1\u02C1(settingFromString.CurrentValue, true);
									}
									this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[4].text = this.\u02B7\u02B9\u02B6\u02B6\u02B8\u02B4\u02B7\u02C1\u02B2\u02BA\u02BC(settingFromString.CurrentValue, "Bass", GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB);
								}
							}
						}
						else if (text == "Received profile update for own peer")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(3, settingFromString);
						}
					}
					else if (num != 58U)
					{
						if (num == 113U)
						{
							if (text == "Framerate")
							{
								base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
							}
						}
					}
					else if (text == "%n")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(4, settingFromString);
					}
				}
				else if (num <= 4294967278U)
				{
					if (num != 4294967149U)
					{
						if (num == 4294967201U)
						{
							if (text == "prodrums")
							{
								base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(65, settingFromString);
							}
						}
					}
					else if (text == "{0:N0} FPS")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(0, settingFromString);
					}
				}
				else if (num != 187U)
				{
					if (num == 81U)
					{
						if (text == "GameData")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(5, settingFromString);
						}
					}
				}
				else if (text == "Game Mode")
				{
					this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B2\u02BB\u02B2\u02BD\u02BA\u02C0\u02B2\u02B5\u02BC\u02B8[settingFromString.CurrentValue]);
				}
			}
			else if (num <= 4U)
			{
				if (num <= 123U)
				{
					if (num <= 4294967101U)
					{
						if (num != 4294967226U)
						{
							if (num == 143U)
							{
								if (text == "notes.mid")
								{
									base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(6, settingFromString);
								}
							}
						}
						else if (text == "song")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(4, settingFromString);
						}
					}
					else if (num != 4294967135U)
					{
						if (num == 4294967130U)
						{
							if (text == "targetFramerate")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(0, settingFromString);
							}
						}
					}
					else if (text == "8EDC4F")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(96, settingFromString);
					}
				}
				else if (num <= 4294967281U)
				{
					if (num != 4294967251U)
					{
						if (num == 4294967181U)
						{
							if (text == "EndOfSong")
							{
								base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
							}
						}
					}
					else if (text == "GameColors_")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(-88, settingFromString);
					}
				}
				else if (num != 4294967169U)
				{
					if (num == 4294967277U)
					{
						if (text == "Test")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
						}
					}
				}
				else if (text == "8EDC4F")
				{
					if (settingFromString == this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC)
					{
						this.\u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD.\u02C0\u02BC\u02B8\u02BA\u02BB\u02B5\u02B3\u02B8\u02BA\u02C1\u02C1(settingFromString.CurrentValue, false);
					}
					this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = this.\u02BF\u02B7\u02BE\u02BD\u02BC\u02BB\u02C0\u02BA\u02C0\u02BD\u02BF(settingFromString.CurrentValue, "midi_export", GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF);
				}
			}
			else if (num <= 12U)
			{
				if (num <= 4294967183U)
				{
					if (num != 57U)
					{
						if (num == 18U)
						{
							if (text == ".ini")
							{
								base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(14, settingFromString);
							}
						}
					}
					else if (text == "Hard")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(45, settingFromString);
					}
				}
				else if (num != 4294967212U)
				{
					if (num == 197U)
					{
						if (text == "6 Fret Lead Guitar")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(6, settingFromString);
						}
					}
				}
				else if (text == "SoftMask")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(3, settingFromString);
				}
			}
			else if (num <= 163U)
			{
				if (num != 4294967257U)
				{
					if (num == 4294967188U)
					{
						if (!(text == "DirectX 11"))
						{
						}
					}
				}
				else if (!(text == "Vulkan"))
				{
				}
			}
			else if (num != 71U)
			{
				if (num == 26U)
				{
					if (text == "")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
					}
				}
			}
			else if (text == "five_lane_drums")
			{
				base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(7, settingFromString);
			}
		}
	}

	protected override void Update()
	{
		if (this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		base.Update();
	}

	private string \u02B7\u02B9\u02B6\u02B6\u02B8\u02B4\u02B7\u02C1\u02B2\u02BA\u02BC(int \u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2, string \u02C1\u02B6\u02B5\u02BD\u02BA\u02BF\u02B8\u02C0\u02B6\u02C1\u02BA, string[] \u02B5\u02BA\u02BC\u02B3\u02B9\u02B7\u02B8\u02B7\u02C1\u02BE\u02C1)
	{
		string text = \u02C1\u02B6\u02B5\u02BD\u02BA\u02BF\u02B8\u02C0\u02B6\u02C1\u02BA;
		bool flag = \u02B5\u02BA\u02BC\u02B3\u02B9\u02B7\u02B8\u02B7\u02C1\u02BE\u02C1 != null && \u02B5\u02BA\u02BC\u02B3\u02B9\u02B7\u02B8\u02B7\u02C1\u02BE\u02C1.Length != 0;
		if (\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2 >= 1)
		{
			text = Path.GetFileNameWithoutExtension(\u02B5\u02BA\u02BC\u02B3\u02B9\u02B7\u02B8\u02B7\u02C1\u02BE\u02C1[\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2]);
		}
		else if (\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2 == -1)
		{
			text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("No Fail");
		}
		else if (\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2 == -14 && flag)
		{
			text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().GetString("part guitar coop ghl");
		}
		return text;
	}

	protected override void \u02BA\u02B8\u02B4\u02BA\u02BD\u02BA\u02B7\u02C1\u02B8\u02B8\u02BC()
	{
		this.\u02C0\u02BB\u02B6\u02B2\u02B5\u02BD\u02BC\u02B6\u02B9\u02B2\u02B9 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF != null && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF.Length != 0;
		this.\u02C0\u02BA\u02B9\u02B7\u02B8\u02B6\u02B2\u02C1\u02BF\u02BD\u02B2 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB != null && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB.Length != 0;
		SettingsController.background_image.MaxValue = (this.\u02C0\u02BB\u02B6\u02B2\u02B5\u02BD\u02BC\u02B6\u02B9\u02B2\u02B9 ? (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF.Length - 1) : (-2));
		SettingsController.background_video.MaxValue = (this.\u02C0\u02BA\u02B9\u02B7\u02B8\u02B6\u02B2\u02C1\u02BF\u02BD\u02B2 ? (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB.Length - 1) : (-2));
	}

	protected virtual void \u02BB\u02B7\u02C0\u02B3\u02C1\u02BD\u02B9\u02B2\u02B4\u02BE\u02B6()
	{
		if (this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		base.Update();
	}

	protected override void \u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5()
	{
		string changedSetting = this.changedSetting;
		if (!(changedSetting == "Background Image"))
		{
			if (changedSetting == "Background Video")
			{
				this.\u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD.\u02B3\u02C1\u02BC\u02BE\u02BD\u02BB\u02B9\u02B2\u02B4\u02B9\u02BE(this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue, true);
			}
		}
		else
		{
			this.\u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD.\u02B3\u02C1\u02BC\u02BE\u02BD\u02BB\u02B9\u02B2\u02B4\u02B9\u02BE(this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue, false);
		}
		this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(this.changedSetting);
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
			if (num <= 2087995404U)
			{
				if (num <= 669190543U)
				{
					if (num <= 363977971U)
					{
						if (num != 186896582U)
						{
							if (num != 229110729U)
							{
								if (num == 363977971U)
								{
									if (text == "Practice Start Delay")
									{
										base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(7, settingFromString);
									}
								}
							}
							else if (text == "Audio Backend")
							{
								this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = BassAudioManager.\u02B9\u02B2\u02B6\u02BB\u02B4\u02B7\u02B6\u02B5\u02B7\u02B2\u02BA(settingFromString.CurrentValue).ToString();
							}
						}
						else if (text == "Default Search By Current Sort")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(3, settingFromString);
						}
					}
					else if (num <= 554341610U)
					{
						if (num != 537478040U)
						{
							if (num == 554341610U)
							{
								if (text == "Highway Shake")
								{
									base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(2, settingFromString);
								}
							}
						}
						else if (text == "Audio Offset")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(0, settingFromString);
						}
					}
					else if (num != 580693481U)
					{
						if (num == 669190543U)
						{
							if (text == "Double Strum Prevention")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(6, settingFromString);
							}
						}
					}
					else if (text == "Practice Star Power")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(12, settingFromString);
					}
				}
				else if (num <= 1476092947U)
				{
					if (num <= 1224852698U)
					{
						if (num != 972458324U)
						{
							if (num == 1224852698U)
							{
								if (text == "Background Video")
								{
									if (settingFromString == this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC)
									{
										this.\u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD.\u02B3\u02C1\u02BC\u02BE\u02BD\u02BB\u02B9\u02B2\u02B4\u02B9\u02BE(settingFromString.CurrentValue, true);
									}
									this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[2].text = this.\u02BF\u02B7\u02BE\u02BD\u02BC\u02BB\u02C0\u02BA\u02C0\u02BD\u02BF(settingFromString.CurrentValue, "No Videos!", GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB);
								}
							}
						}
						else if (text == "Pause on Focus Lost")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(5, settingFromString);
						}
					}
					else if (num != 1351274325U)
					{
						if (num == 1476092947U)
						{
							if (text == "Show Hit Window")
							{
								base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
							}
						}
					}
					else if (text == "Allow Duplicate Songs")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(4, settingFromString);
					}
				}
				else if (num <= 1753283860U)
				{
					if (num != 1485671700U)
					{
						if (num == 1753283860U)
						{
							if (text == "Song Highways")
							{
								base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(13, settingFromString);
							}
						}
					}
					else if (text == "Controller Poll Rate")
					{
						base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(5, settingFromString);
					}
				}
				else if (num != 1976894744U)
				{
					if (num == 2087995404U)
					{
						if (text == "Mute Track on Miss")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(7, settingFromString);
						}
					}
				}
				else if (text == "Default Sort Filter")
				{
					this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[0].text = LanguageManager.instance.GetString(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B2\u02BB\u02B2\u02BD\u02BA\u02C0\u02B2\u02B5\u02BC\u02B8[settingFromString.CurrentValue]);
				}
			}
			else if (num <= 3148303310U)
			{
				if (num <= 2351279455U)
				{
					if (num <= 2209223988U)
					{
						if (num != 2125539120U)
						{
							if (num == 2209223988U)
							{
								if (text == "Star Animation FPS")
								{
									base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(3, settingFromString);
								}
							}
						}
						else if (text == "Note Animation FPS")
						{
							base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(2, settingFromString);
						}
					}
					else if (num != 2325855612U)
					{
						if (num == 2351279455U)
						{
							if (text == "Video Offset")
							{
								base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(1, settingFromString);
							}
						}
					}
					else if (text == "Song Videos")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(10, settingFromString);
					}
				}
				else if (num <= 2626071342U)
				{
					if (num != 2430087688U)
					{
						if (num == 2626071342U)
						{
							if (text == "Low Latency Mode")
							{
								base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(0, settingFromString);
							}
						}
					}
					else if (text == "Use Song Backgrounds")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(11, settingFromString);
					}
				}
				else if (num != 2927438748U)
				{
					if (num == 3148303310U)
					{
						if (text == "No Fail")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(6, settingFromString);
						}
					}
				}
				else if (text == "Background Image")
				{
					if (settingFromString == this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC)
					{
						this.\u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD.\u02B3\u02C1\u02BC\u02BE\u02BD\u02BB\u02B9\u02B2\u02B4\u02B9\u02BE(settingFromString.CurrentValue, false);
					}
					this.\u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9[1].text = this.\u02BF\u02B7\u02BE\u02BD\u02BC\u02BB\u02C0\u02BA\u02C0\u02BD\u02BF(settingFromString.CurrentValue, "No Images!", GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF);
				}
			}
			else if (num <= 3502736215U)
			{
				if (num <= 3235865788U)
				{
					if (num != 3224438732U)
					{
						if (num == 3235865788U)
						{
							if (text == "Show Lyrics")
							{
								base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(9, settingFromString);
							}
						}
					}
					else if (text == "Measure Based Countdowns")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(14, settingFromString);
					}
				}
				else if (num != 3411634414U)
				{
					if (num == 3502736215U)
					{
						if (text == "Show Bot Score")
						{
							base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(8, settingFromString);
						}
					}
				}
				else if (text == "Crowd")
				{
					base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(8, settingFromString);
				}
			}
			else if (num <= 3587543207U)
			{
				if (num != 3510823811U)
				{
					if (num == 3587543207U)
					{
						if (!(text == "Scan Custom Images"))
						{
						}
					}
				}
				else if (!(text == "Get Hardware Latency"))
				{
				}
			}
			else if (num != 3924729133U)
			{
				if (num == 4199460336U)
				{
					if (text == "Show Lyrics Background")
					{
						base.\u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(1, settingFromString);
					}
				}
			}
			else if (text == "Gem Size")
			{
				base.\u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(4, settingFromString);
			}
		}
	}

	public virtual void \u02C0\u02BA\u02BF\u02B6\u02C1\u02B5\u02B9\u02B9\u02B7\u02BD\u02BB()
	{
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		this.\u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD.\u02B8\u02BD\u02B5\u02C0\u02BE\u02C0\u02B3\u02B3\u02BD\u02C0\u02C1(false);
	}

	protected override void \u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1()
	{
		string changedSetting = this.changedSetting;
		if (!(changedSetting == "Menu Music"))
		{
			if (!(changedSetting == "Controller Poll Rate"))
			{
				return;
			}
			ReInput.configuration.joystickRefreshRate = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue;
		}
		else
		{
			if (!this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetBoolValue)
			{
				this.menuMusic.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(false);
				return;
			}
			if (!this.menuMusic.\u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8)
			{
				this.menuMusic.\u02B9\u02BF\u02B3\u02C1\u02B9\u02B2\u02B9\u02BA\u02B8\u02B5\u02B9();
				return;
			}
		}
	}

	private string \u02C1\u02BA\u02C0\u02B9\u02BE\u02BA\u02B4\u02B7\u02BB\u02BB\u02B6(int \u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2, string \u02C1\u02B6\u02B5\u02BD\u02BA\u02BF\u02B8\u02C0\u02B6\u02C1\u02BA, string[] \u02B5\u02BA\u02BC\u02B3\u02B9\u02B7\u02B8\u02B7\u02C1\u02BE\u02C1)
	{
		string text = \u02C1\u02B6\u02B5\u02BD\u02BA\u02BF\u02B8\u02C0\u02B6\u02C1\u02BA;
		bool flag = \u02B5\u02BA\u02BC\u02B3\u02B9\u02B7\u02B8\u02B7\u02C1\u02BE\u02C1 != null && \u02B5\u02BA\u02BC\u02B3\u02B9\u02B7\u02B8\u02B7\u02C1\u02BE\u02C1.Length != 0;
		if (\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2 >= 0)
		{
			text = Path.GetFileNameWithoutExtension(\u02B5\u02BA\u02BC\u02B3\u02B9\u02B7\u02B8\u02B7\u02C1\u02BE\u02C1[\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2]);
		}
		else if (\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2 == -1)
		{
			text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("End Events");
		}
		else if (\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2 == 62 && flag)
		{
			text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("_uElectricityEffect");
		}
		return text;
	}

	private void \u02B3\u02B5\u02B5\u02C0\u02BA\u02BB\u02B9\u02B9\u02BB\u02B4\u02BA()
	{
		Debug.Log("Main Menu");
		this.menuMusic.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(true);
		SceneManager.LoadScene("Modifiers");
	}

	public override void \u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0()
	{
		base.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = 1;
	}

	protected virtual GameSetting \u02BC\u02B2\u02B2\u02BD\u02BB\u02B5\u02B7\u02B6\u02BE\u02B8\u02BA(string \u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0)
	{
		GameSetting gameSetting = null;
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0);
		if (num <= 136U)
		{
			if (num <= 4294967261U)
			{
				if (num <= 52U)
				{
					if (num != 15U)
					{
						if (num != 21U)
						{
							if (num == 103U)
							{
								if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "8EDC4F")
								{
									gameSetting = SettingsController.audioOffset;
								}
							}
						}
						else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "ResultRow")
						{
							gameSetting = SettingsController.practice_delay;
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "%c")
					{
						gameSetting = SettingsController.default_search_by_current_sort;
					}
				}
				else if (num <= 124U)
				{
					if (num != 4294967172U)
					{
						if (num == 4294967213U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Input Device")
							{
								gameSetting = SettingsController.practice_sp;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "{0:N0}")
					{
						gameSetting = SettingsController.\u02BF\u02BF\u02BB\u02BF\u02B2\u02BE\u02B5\u02BD\u02C0\u02B4\u02B9;
					}
				}
				else if (num != 189U)
				{
					if (num == 4294967277U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "diff_guitar")
						{
							gameSetting = SettingsController.\u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Image Backgrounds")
				{
					gameSetting = SettingsController.doubleStrumPrevention;
				}
			}
			else if (num <= 4294967141U)
			{
				if (num <= 193U)
				{
					if (num != 4294967274U)
					{
						if (num == 149U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Play Count")
							{
								gameSetting = SettingsController.allow_duplicate_songs;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Guitar")
					{
						gameSetting = SettingsController.background_video;
					}
				}
				else if (num != 4294967100U)
				{
					if (num == 4294967255U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "{0} ({1})")
						{
							gameSetting = SettingsController.\u02BC\u02BA\u02BE\u02B9\u02B5\u02BD\u02C1\u02B8\u02B7\u02C0\u02B8;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Hit Percent")
				{
					gameSetting = SettingsController.show_hit_window;
				}
			}
			else if (num <= 11U)
			{
				if (num != 63U)
				{
					if (num == 171U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "songs.txt")
						{
							gameSetting = SettingsController.sort_filter;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Deadly Dynamics")
				{
					gameSetting = SettingsController.\u02C1\u02BF\u02C0\u02BF\u02B8\u02B8\u02C0\u02C0\u02B3\u02B3\u02BB;
				}
			}
			else if (num != 4294967270U)
			{
				if (num == 4294967243U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "")
					{
						gameSetting = SettingsController.\u02BC\u02B6\u02BD\u02B5\u02B4\u02C0\u02B2\u02B8\u02B7\u02BC\u02B6;
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Gameplay")
			{
				gameSetting = SettingsController.mute_on_miss;
			}
		}
		else if (num <= 44U)
		{
			if (num <= 100U)
			{
				if (num != 4294967211U)
				{
					if (num != 4294967286U)
					{
						if (num == 4294967252U)
						{
							if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Startup Parameters:")
							{
								gameSetting = SettingsController.videoOffset;
							}
						}
					}
					else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "part keys")
					{
						gameSetting = SettingsController.\u02BE\u02B6\u02BA\u02C0\u02B9\u02B6\u02B2\u02BB\u02B3\u02B3\u02BA;
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Okay")
				{
					gameSetting = SettingsController.\u02B4\u02B5\u02BE\u02B6\u02BC\u02B7\u02BB\u02B5\u02B7\u02BF\u02C0;
				}
			}
			else if (num <= 10U)
			{
				if (num != 181U)
				{
					if (num == 88U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Show FPS")
						{
							gameSetting = SettingsController.background_image;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "No")
				{
					gameSetting = SettingsController.song_backgrounds;
				}
			}
			else if (num != 4294967253U)
			{
				if (num == 4294967228U)
				{
					if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Input Device")
					{
						gameSetting = SettingsController.\u02BB\u02C0\u02B7\u02B8\u02B3\u02BE\u02B7\u02BB\u02BA\u02B8\u02BA;
					}
				}
			}
			else if (!(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "--instrumentNames"))
			{
			}
		}
		else if (num <= 4294967151U)
		{
			if (num <= 71U)
			{
				if (num != 86U)
				{
					if (num == 179U)
					{
						if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Continue")
						{
							gameSetting = SettingsController.enable_lyrics;
						}
					}
				}
				else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Player")
				{
					gameSetting = SettingsController.measure_countdown;
				}
			}
			else if (num != 9U)
			{
				if (num == 4294967176U)
				{
					if (!(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Set B Position"))
					{
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Velocity")
			{
				gameSetting = SettingsController.show_bot_score;
			}
		}
		else if (num <= 4294967204U)
		{
			if (num != 4294967154U)
			{
				if (num == 92U)
				{
					if (!(\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "{0:N0}/{1:N0}"))
					{
					}
				}
			}
			else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "hasProDrums")
			{
				gameSetting = SettingsController.song_speed;
			}
		}
		else if (num != 4294967177U)
		{
			if (num == 32U)
			{
				if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Error reading metadata: ")
				{
					gameSetting = SettingsController.enable_lyrics_bg;
				}
			}
		}
		else if (\u02BC\u02BE\u02B6\u02B7\u02BD\u02B6\u02B3\u02B5\u02B3\u02BE\u02C0 == "Default Search By Current Sort")
		{
			gameSetting = SettingsController.gem_size;
		}
		return gameSetting;
	}

	[SerializeField]
	private MenuMusic menuMusic;

	[SerializeField]
	private ConfirmationMenu confirmMenu;

	private bool \u02C0\u02BB\u02B6\u02B2\u02B5\u02BD\u02BC\u02B6\u02B9\u02B2\u02B9;

	private bool \u02C0\u02BA\u02B9\u02B7\u02B8\u02B6\u02B2\u02C1\u02BF\u02BD\u02B2;

	public TexturePreview \u02B9\u02B3\u02B5\u02BB\u02C1\u02B5\u02B2\u02B2\u02BE\u02BA\u02BD;

	private List<string> \u02C0\u02BA\u02BF\u02B4\u02B7\u02BC\u02B8\u02B4\u02C0\u02C1\u02C1 = new List<string>();
}
