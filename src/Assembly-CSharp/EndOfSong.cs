﻿using System;
using System.Collections;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndOfSong : MonoBehaviour
{
	private IEnumerator \u02B6\u02BA\u02C0\u02C1\u02B3\u02BA\u02B9\u02B2\u02BA\u02B5\u02BF(Image \u02BA\u02BE\u02BE\u02B3\u02BD\u02BD\u02B3\u02BA\u02B2\u02B9\u02B7, float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		float timeElapsed = 0f;
		float startAlpha = \u02BA\u02BE\u02BE\u02B3\u02BD\u02BD\u02B3\u02BA\u02B2\u02B9\u02B7.color.a;
		WaitForEndOfFrame endOfFrame = new WaitForEndOfFrame();
		\u02BA\u02BE\u02BE\u02B3\u02BD\u02BD\u02B3\u02BA\u02B2\u02B9\u02B7.gameObject.SetActive(true);
		while (timeElapsed < \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
		{
			Color color = \u02BA\u02BE\u02BE\u02B3\u02BD\u02BD\u02B3\u02BA\u02B2\u02B9\u02B7.color;
			color.a = Mathf.Lerp(startAlpha, 0f, timeElapsed / \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5);
			\u02BA\u02BE\u02BE\u02B3\u02BD\u02BD\u02B3\u02BA\u02B2\u02B9\u02B7.color = color;
			yield return endOfFrame;
			timeElapsed += Time.deltaTime;
		}
		Color color2 = \u02BA\u02BE\u02BE\u02B3\u02BD\u02BD\u02B3\u02BA\u02B2\u02B9\u02B7.color;
		color2.a = 0f;
		\u02BA\u02BE\u02BE\u02B3\u02BD\u02BD\u02B3\u02BA\u02B2\u02B9\u02B7.color = color2;
		\u02BA\u02BE\u02BE\u02B3\u02BD\u02BD\u02B3\u02BA\u02B2\u02B9\u02B7.gameObject.SetActive(false);
		color2.a = 0.5f;
		\u02BA\u02BE\u02BE\u02B3\u02BD\u02BD\u02B3\u02BA\u02B2\u02B9\u02B7.color = color2;
		yield break;
	}

	private void \u02BD\u02B3\u02B9\u02BA\u02BF\u02C0\u02B9\u02B8\u02B5\u02B4\u02BF()
	{
		\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B9\u02B2\u02C1\u02BC\u02B2\u02B8\u02BC\u02BF\u02B9\u02BE();
	}

	private void Update()
	{
		if (FadeBehaviour.instance.isFading || this.confirmMenu.isActive)
		{
			return;
		}
		if (this.drumsOptionsMenu.isActiveAndEnabled)
		{
			return;
		}
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && !chplayer.\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4)
			{
				this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8 = chplayer;
				if (chplayer.playerProfile != null && chplayer.player.GetAnyButton())
				{
					controllerType = chplayer.playerProfile.controllerType.GetControllerType;
					flag = chplayer.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
				}
				if (!chplayer.player.GetButtonDown(0))
				{
					if (chplayer.playerProfile.IsStandardDrumsController && SettingsController.drum_pad_scrolling)
					{
						if (chplayer.player.GetButtonDown(4))
						{
							this.drumsOptionsMenu.gameObject.SetActive(true);
							return;
						}
					}
					else if (chplayer.player.GetButtonDown(2))
					{
						this.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
					}
					else if (chplayer.player.GetButtonDown(3))
					{
						this.\u02B7\u02B2\u02BA\u02B8\u02B9\u02BF\u02B2\u02C0\u02BE\u02B3\u02B3();
					}
					else if (chplayer.player.GetButtonDown(4))
					{
						this.\u02B6\u02B9\u02B4\u02B2\u02B4\u02BB\u02BF\u02B7\u02BC\u02BD\u02C1();
					}
				}
				if (!this.\u02BD\u02B7\u02BA\u02C0\u02BF\u02BE\u02BB\u02B4\u02B2\u02B5\u02C0 && (chplayer.player.GetButtonDown(6) || SettingsController.auto_screenshot))
				{
					this.\u02BD\u02B7\u02BA\u02C0\u02BF\u02BE\u02BB\u02B4\u02B2\u02B5\u02C0 = true;
					this.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
				}
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
			}
		}
		if (!CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			int num = 0;
			PlayerStatsBox[] array = this.statsBoxes;
			int num2 = 0;
			while (num2 < array.Length && array[num2].\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6)
			{
				num++;
				num2++;
			}
			if (num == this.statsBoxes.Length)
			{
				this.\u02B9\u02B5\u02B5\u02BD\u02C0\u02BC\u02BA\u02BD\u02BD\u02B7\u02B9();
			}
		}
		else if (\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02BD\u02BC\u02B2\u02B8\u02BC\u02B5\u02B5\u02BB\u02BC\u02B6)
		{
			if (GlobalVariables.instance.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE.player.GetButtonDown(1))
			{
				this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("Are you sure you want to quit?", "Yes", "No", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02BA\u02BD\u02B4\u02B2\u02BC\u02B3\u02B9\u02B2\u02C0\u02B2\u02B2), null, null);
				return;
			}
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BE\u02BD\u02B6\u02BD\u02B6\u02BF\u02B4\u02BA\u02B3\u02BD && GlobalVariables.instance.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE.player.GetButtonDown(0))
			{
				\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C0\u02C1\u02B2\u02BC\u02BD\u02BD\u02B8\u02BA\u02BE\u02B9\u02BA(new \u02B6\u02BF\u02B7\u02B3\u02BE\u02B3\u02B6\u02B8\u02BB\u02B5\u02BD(), \u02B4\u02BB\u02B8\u02B2\u02B3\u02BE\u02B3\u02B3\u02BA\u02B8\u02C0.ReliableOrdered, 0);
			}
		}
		this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8 = null;
	}

	public void \u02BD\u02BC\u02BF\u02C1\u02BF\u02B6\u02C1\u02C0\u02C1\u02BE\u02C1()
	{
		if (this.\u02B7\u02B4\u02B9\u02BD\u02C0\u02BA\u02B5\u02BF\u02BA\u02B3\u02B8)
		{
			GlobalVariables.instance.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 = true;
			FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Hide Remote Highways", 1703f);
		}
	}

	public void \u02B6\u02B9\u02B4\u02B2\u02B4\u02BB\u02BF\u02B7\u02BC\u02BD\u02C1()
	{
		if (!GlobalVariables.instance.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			CHPlayer u02BE_u02BE_u02BA_u02B8_u02B2_u02B4_u02BF_u02B3_u02B3_u02BE_u02B = this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8;
			int num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BB\u02B2\u02BA\u02BE\u02BD\u02BC\u02B7\u02B8\u02BD\u02C0\u02BF(u02BE_u02BE_u02BA_u02B8_u02B2_u02B4_u02BF_u02B3_u02B3_u02BE_u02B.playerProfile.instrument, u02BE_u02BE_u02BA_u02B8_u02B2_u02B4_u02BF_u02B3_u02B3_u02BE_u02B.playerProfile.difficulty);
			GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4[num];
			FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Gameplay", 0f);
		}
	}

	public void \u02BE\u02B8\u02B5\u02B8\u02BC\u02BD\u02B6\u02BA\u02B8\u02BB\u02B8()
	{
		if (!GlobalVariables.instance.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			CHPlayer u02BE_u02BE_u02BA_u02B8_u02B2_u02B4_u02BF_u02B3_u02B3_u02BE_u02B = this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8;
			int num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BB\u02B2\u02BA\u02BE\u02BD\u02BC\u02B7\u02B8\u02BD\u02C0\u02BF(u02BE_u02BE_u02BA_u02B8_u02B2_u02B4_u02BF_u02B3_u02B3_u02BE_u02B.playerProfile.instrument, u02BE_u02BE_u02BA_u02B8_u02B2_u02B4_u02BF_u02B3_u02B3_u02BE_u02B.playerProfile.difficulty);
			GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4[num];
			FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("", 282f);
		}
	}

	private void \u02B6\u02BB\u02B6\u02B4\u02BB\u02B8\u02B4\u02BC\u02BD\u02B3\u02C1()
	{
		this.quickplay.SetActive(false);
		this.quickplayPractice.SetActive(true);
		this.setlist.SetActive(false);
		this.setlist_end.SetActive(false);
	}

	private IEnumerator \u02BB\u02B7\u02BA\u02BF\u02BE\u02BF\u02B2\u02BF\u02C0\u02BA\u02B5()
	{
		yield return new WaitForEndOfFrame();
		Texture2D screenshotTexture = this.\u02BF\u02BC\u02BF\u02B6\u02BD\u02C0\u02B6\u02B7\u02B8\u02C0\u02B5.\u02C0\u02C0\u02C0\u02B7\u02BC\u02BF\u02B9\u02BD\u02BF\u02BF\u02B8();
		yield return this.\u02B6\u02BA\u02C0\u02C1\u02B3\u02BA\u02B9\u02B2\u02BA\u02B5\u02BF(this.screenshot.GetComponent<Image>(), 0.3f);
		this.screenshotNotification.\u02B4\u02B2\u02BD\u02B7\u02BF\u02BD\u02B2\u02B4\u02B7\u02B9\u02BC(screenshotTexture);
		yield return new WaitForSeconds(1.65f);
		this.screenshotNotification.\u02B3\u02B5\u02B4\u02C1\u02BF\u02B3\u02BE\u02B3\u02B8\u02B8\u02BD();
		yield return new WaitForSeconds(0.2f);
		global::UnityEngine.Object.Destroy(screenshotTexture);
		yield break;
	}

	private void Start()
	{
		this.versionNumber.text = "Clone Hero " + GlobalVariables.instance.\u02B4\u02B3\u02B7\u02BC\u02B5\u02B3\u02B8\u02BB\u02BE\u02B5\u02B3;
		FadeBehaviour.instance.\u02BE\u02C0\u02B2\u02BF\u02C0\u02BA\u02C0\u02BB\u02B4\u02BC\u02BE();
		GlobalVariables.instance.\u02BD\u02B5\u02B4\u02B2\u02BA\u02B5\u02BD\u02BF\u02BE\u02BC\u02BB(true);
		this.\u02BF\u02BC\u02BF\u02B6\u02BD\u02C0\u02B6\u02B7\u02B8\u02C0\u02B5 = new \u02BD\u02B3\u02BF\u02C0\u02BF\u02C1\u02B5\u02B3\u02BE\u02BD\u02B6(GlobalVariables.instance.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD);
		this.\u02BF\u02BC\u02BF\u02B6\u02BD\u02C0\u02B6\u02B7\u02B8\u02C0\u02B5.\u02BC\u02BB\u02BA\u02BE\u02BB\u02B9\u02B8\u02B8\u02BA\u02C1\u02B8(GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1, SettingsController.song_speed.CurrentValue, \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B5\u02B7\u02B8\u02BB\u02BB\u02B5\u02BD\u02B4\u02B9\u02BD\u02BF, \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B8\u02BC\u02BF\u02B9\u02C0\u02C1\u02BE\u02BB\u02BE\u02B3\u02B6);
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				this.\u02BF\u02BC\u02BF\u02B6\u02BD\u02C0\u02B6\u02B7\u02B8\u02C0\u02B5.\u02B5\u02B2\u02BD\u02B6\u02B2\u02B3\u02BF\u02B8\u02C1\u02B3\u02B2(chplayer, chplayer.\u02B6\u02B2\u02B4\u02B9\u02B8\u02BD\u02B3\u02C1\u02B4\u02BE\u02BA);
			}
		}
		DiscordController.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C0\u02BC\u02BB\u02B2\u02BC\u02B7\u02B8\u02B7\u02BE\u02C0\u02C0();
		string text = GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		if (!SettingsController.song_speed.IsPresetValue)
		{
			text = text + " <b><i>(" + SettingsController.song_speed.GetPercentString + ")</i></b>";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.charterName.text = GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Charter.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.score.text = string.Format("{0:n0}", \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B5\u02B7\u02B8\u02BB\u02BB\u02B5\u02BD\u02B4\u02B9\u02BD\u02BF);
		this.\u02B7\u02B4\u02B9\u02BD\u02C0\u02BA\u02B5\u02BF\u02BA\u02B3\u02B8 = GlobalVariables.instance.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD == 1 && !GlobalVariables.instance.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6;
		this.savingText.text = LanguageManager.instance.GetString("savewarning");
		if (GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.iconName != null && GlobalVariables.instance.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3.ContainsKey(GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3[GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.iconName];
		}
		else if (GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Charter != null && GlobalVariables.instance.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3.ContainsKey(GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Charter.\u02B2\u02B7\u02B5\u02B3\u02BC\u02BE\u02C0\u02B3\u02BA\u02BA\u02B3))
		{
			this.icon.sprite = GlobalVariables.instance.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3[GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Charter.\u02B2\u02B7\u02B5\u02B3\u02BC\u02BE\u02C0\u02B3\u02BA\u02BA\u02B3];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			if (GlobalVariables.instance.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7 == \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count - 1)
			{
				this.\u02BF\u02B8\u02B5\u02BC\u02C0\u02C0\u02B7\u02BD\u02BE\u02B4\u02B7 = true;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(true);
			}
		}
		else if (this.\u02B7\u02B4\u02B9\u02BD\u02C0\u02BA\u02B5\u02BF\u02BA\u02B3\u02B8)
		{
			this.quickplayPractice.SetActive(true);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		if (GlobalVariables.instance.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 == GameMode.Versus)
		{
			this.score.text = "";
			this.savingText.text = "";
			this.botSaveWarning.text = "";
			global::UnityEngine.Object.Destroy(GameObject.Find("Stars Background"));
			for (int i = 0; i < this.starObjects.Length; i++)
			{
				global::UnityEngine.Object.Destroy(this.starObjects[i]);
			}
			this.versusTrophy.SetActive(true);
			for (int j = 0; j < 4; j++)
			{
				CHPlayer chplayer2 = GlobalVariables.instance.playerList[j];
				if (chplayer2.\u02B6\u02B2\u02B4\u02B9\u02B8\u02BD\u02B3\u02C1\u02B4\u02BE\u02BA.versusWinner)
				{
					this.winnerName.text = chplayer2.playerProfile.playerName.CurrentValue;
					break;
				}
			}
		}
		else
		{
			for (int k = 6 - \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B8\u02BC\u02BF\u02B9\u02C0\u02C1\u02BE\u02BB\u02BE\u02B3\u02B6; k >= 0; k--)
			{
				global::UnityEngine.Object.Destroy(this.starObjects[k]);
			}
			if (GlobalVariables.instance.\u02BA\u02B3\u02BE\u02B6\u02BF\u02B3\u02BB\u02C1\u02B6\u02C1\u02BF())
			{
				GlobalVariables.instance.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA = \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.Bot;
			}
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02BD\u02BC\u02B2\u02B8\u02BC\u02B5\u02B5\u02BB\u02BC\u02B6)
			{
				this.botSaveWarning.text = LanguageManager.instance.GetString("spectatornosave");
			}
			else if (GlobalVariables.instance.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA != \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.None)
			{
				switch (GlobalVariables.instance.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA)
				{
				case \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.Modifier:
					this.botSaveWarning.text = LanguageManager.instance.GetString("ScoreDisabledModifier");
					break;
				case \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.Bot:
					this.botSaveWarning.text = LanguageManager.instance.GetString("botnosave");
					break;
				case \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.Pause:
					this.botSaveWarning.text = LanguageManager.instance.GetString("ScoreDisabledPause");
					break;
				}
			}
			else
			{
				\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC u02C0_u02B5_u02B3_u02B2_u02BA_u02BD_u02B5_u02C1_u02B9_u02BA_u02BC;
				if (GlobalVariables.instance.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD == 1)
				{
					CHPlayer chplayer3 = null;
					for (int l = 0; l < 4; l++)
					{
						chplayer3 = GlobalVariables.instance.playerList[l];
						if (chplayer3.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
						{
							break;
						}
					}
					u02C0_u02B5_u02B3_u02B2_u02BA_u02BD_u02B5_u02C1_u02B9_u02BA_u02BC = new \u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC(GlobalVariables.instance.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE(), chplayer3.playerProfile.difficulty, chplayer3.\u02B6\u02B2\u02B4\u02B9\u02B8\u02BD\u02B3\u02C1\u02B4\u02BE\u02BA.Accuracy, chplayer3.\u02B6\u02B2\u02B4\u02B9\u02B8\u02BD\u02B3\u02C1\u02B4\u02BE\u02BA.IsFC, (byte)\u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B8\u02BC\u02BF\u02B9\u02C0\u02C1\u02BE\u02BB\u02BE\u02B3\u02B6, chplayer3.playerProfile.noteModifier, \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B5\u02B7\u02B8\u02BB\u02BB\u02B5\u02BD\u02B4\u02B9\u02BD\u02BF, (short)SettingsController.song_speed.CurrentValue);
				}
				else
				{
					Difficulty difficulty = Difficulty.Expert;
					foreach (CHPlayer chplayer4 in GlobalVariables.instance.playerList)
					{
						if (chplayer4.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer4.playerProfile.difficulty < difficulty)
						{
							difficulty = chplayer4.playerProfile.difficulty;
						}
					}
					u02C0_u02B5_u02B3_u02B2_u02BA_u02BD_u02B5_u02C1_u02B9_u02BA_u02BC = new \u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC(Instrument.Band, difficulty, \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B5\u02BA\u02B8\u02B2\u02BD\u02B5\u02B5\u02B2\u02BD\u02B5\u02BE(), \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02BA\u02BA\u02B5\u02B6\u02B8\u02BE\u02B4\u02B9\u02BF\u02B2\u02BC(), (byte)\u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B8\u02BC\u02BF\u02B9\u02C0\u02C1\u02BE\u02BB\u02BE\u02B3\u02B6, Modifier.Unknown, \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B5\u02B7\u02B8\u02BB\u02BB\u02B5\u02BD\u02B4\u02B9\u02BD\u02BF, (short)SettingsController.song_speed.CurrentValue);
				}
				if (GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.\u02B6\u02BB\u02BB\u02BD\u02BC\u02B2\u02B7\u02C0\u02BE\u02BD\u02B7(u02C0_u02B5_u02B3_u02B2_u02BA_u02BD_u02B5_u02C1_u02B9_u02BA_u02BC))
				{
					this.botSaveWarning.text = LanguageManager.instance.GetString("beatscore");
					this.\u02B6\u02B3\u02B7\u02B5\u02B7\u02B9\u02B2\u02B5\u02BC\u02BB\u02BD = true;
				}
				else
				{
					this.botSaveWarning.enabled = false;
				}
			}
		}
		this.savingText.enabled = false;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF, false);
		foreach (CHPlayer chplayer5 in GlobalVariables.instance.playerList)
		{
			if (chplayer5.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer5.playerProfile != null && !chplayer5.playerProfile.isRemotePlayer)
			{
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = chplayer5.playerProfile.controllerType.GetControllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = chplayer5.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
			}
		}
		this.\u02B8\u02C1\u02B9\u02C1\u02BE\u02BA\u02B4\u02B8\u02BB\u02BF\u02BD.gameObject.SetActive(CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02BD\u02BC\u02B2\u02B8\u02BC\u02B5\u02B5\u02BB\u02BC\u02B6 && CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BE\u02BD\u02B6\u02BD\u02B6\u02BF\u02B4\u02BA\u02B3\u02BD);
		if (GlobalVariables.instance.\u02B7\u02B7\u02B9\u02B6\u02B6\u02B8\u02C1\u02BA\u02BA\u02C0\u02B8)
		{
			int num = GlobalVariables.instance.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7 + 1;
			int count = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count;
			int num2 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC[num];
			SongEntry songEntry = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD[num];
			this.nextSong.gameObject.SetActive(true);
			this.nextSong.text = string.Concat(new string[]
			{
				LanguageManager.instance.GetString("Next Song"),
				": ",
				songEntry.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5,
				" - ",
				songEntry.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5,
				" ",
				(num2 != 100) ? string.Format("({0}%)", num2) : "",
				" ",
				string.Format("({0}/{1})", num + 1, count)
			});
		}
	}

	private void \u02BA\u02BD\u02B4\u02B2\u02BC\u02B3\u02B9\u02B2\u02C0\u02B2\u02B2()
	{
		\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B9\u02B2\u02C1\u02BC\u02B2\u02B8\u02BC\u02BF\u02B9\u02BE();
	}

	public void \u02BE\u02B5\u02BE\u02B9\u02B6\u02C0\u02BF\u02BB\u02C0\u02B3\u02BD()
	{
		if (!GlobalVariables.instance.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			CHPlayer u02BE_u02BE_u02BA_u02B8_u02B2_u02B4_u02BF_u02B3_u02B3_u02BE_u02B = this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8;
			int num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BB\u02B2\u02BA\u02BE\u02BD\u02BC\u02B7\u02B8\u02BD\u02C0\u02BF(u02BE_u02BE_u02BA_u02B8_u02B2_u02B4_u02BF_u02B3_u02B3_u02BE_u02B.playerProfile.instrument, u02BE_u02BE_u02BA_u02B8_u02B2_u02B4_u02BF_u02B3_u02B3_u02BE_u02B.playerProfile.difficulty);
			GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4[num];
			FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("_GlobalWhammyTexture", 1475f);
		}
	}

	private IEnumerator \u02BC\u02C1\u02B6\u02B4\u02BD\u02BA\u02B6\u02B9\u02BB\u02B7\u02B8()
	{
		yield return new WaitForEndOfFrame();
		screenshotTexture = this.\u02BF\u02BC\u02BF\u02B6\u02BD\u02C0\u02B6\u02B7\u02B8\u02C0\u02B5.\u02C0\u02C0\u02C0\u02B7\u02BC\u02BF\u02B9\u02BD\u02BF\u02BF\u02B8();
		yield return this.\u02B6\u02BA\u02C0\u02C1\u02B3\u02BA\u02B9\u02B2\u02BA\u02B5\u02BF(this.screenshot.GetComponent<Image>(), 0.3f);
		this.screenshotNotification.\u02B4\u02B2\u02BD\u02B7\u02BF\u02BD\u02B2\u02B4\u02B7\u02B9\u02BC(screenshotTexture);
		yield return new WaitForSeconds(1.65f);
		this.screenshotNotification.\u02B3\u02B5\u02B4\u02C1\u02BF\u02B3\u02BE\u02B3\u02B8\u02B8\u02BD();
		yield return new WaitForSeconds(0.2f);
		global::UnityEngine.Object.Destroy(screenshotTexture);
		yield break;
	}

	public void \u02BD\u02B7\u02BE\u02B5\u02B8\u02BC\u02BE\u02BA\u02BD\u02B8\u02BB()
	{
		if (this.\u02B8\u02BA\u02BF\u02B6\u02B7\u02BF\u02BA\u02B4\u02B7\u02B9\u02B3())
		{
			GlobalVariables.instance.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 = false;
			FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("bass", 34f);
		}
	}

	public void \u02B9\u02B5\u02B5\u02BD\u02C0\u02BC\u02BA\u02BD\u02BD\u02B7\u02B9()
	{
		if (GlobalVariables.instance.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			if (this.\u02BF\u02B8\u02B5\u02BC\u02C0\u02C0\u02B7\u02BD\u02BE\u02B4\u02B7)
			{
				GlobalVariables.instance.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = true;
				\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BF\u02BD\u02C1\u02C0\u02BC\u02B7\u02B4\u02C0\u02B4\u02C1();
				GlobalVariables.instance.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6 = false;
				GlobalVariables.instance.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7 = 0;
				SettingsController.song_speed.CurrentValue = GlobalVariables.instance.\u02B9\u02B7\u02BE\u02BF\u02B4\u02C1\u02BC\u02B2\u02BC\u02B8\u02B4;
				FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Main Menu", 0f);
			}
			else
			{
				GlobalVariables.instance.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7++;
				SettingsController.song_speed.CurrentValue = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC[GlobalVariables.instance.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7];
				GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD[GlobalVariables.instance.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7];
				FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Gameplay", 0f);
			}
		}
		else
		{
			SettingsController.song_speed.CurrentValue = GlobalVariables.instance.\u02B9\u02B7\u02BE\u02BF\u02B4\u02C1\u02BC\u02B2\u02BC\u02B8\u02B4;
			GlobalVariables.instance.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = true;
			FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Main Menu", 0f);
		}
		this.\u02BF\u02BC\u02BF\u02B6\u02BD\u02C0\u02B6\u02B7\u02B8\u02C0\u02B5.\u02BE\u02B2\u02B4\u02B2\u02B7\u02B4\u02BB\u02C1\u02C1\u02C1\u02BA();
	}

	public void \u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1()
	{
		this.drumsOptionsMenu.gameObject.SetActive(false);
		if (GlobalVariables.instance.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA == \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.None && !GlobalVariables.instance.\u02BA\u02B3\u02BE\u02B6\u02BF\u02B3\u02BB\u02C1\u02B6\u02C1\u02BF())
		{
			this.screenshot.SetActive(false);
			this.\u02B9\u02B5\u02B5\u02C1\u02B8\u02B2\u02B6\u02B5\u02BD\u02B4\u02BF();
		}
	}

	public bool \u02B7\u02B4\u02B9\u02BD\u02C0\u02BA\u02B5\u02BF\u02BA\u02B3\u02B8 { get; private set; }

	public void \u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6()
	{
		if (!GlobalVariables.instance.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Gameplay", 0f);
		}
	}

	public void \u02B7\u02B2\u02BA\u02B8\u02B9\u02BF\u02B2\u02C0\u02BE\u02B3\u02B3()
	{
		if (this.\u02B7\u02B4\u02B9\u02BD\u02C0\u02BA\u02B5\u02BF\u02BA\u02B3\u02B8)
		{
			GlobalVariables.instance.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 = true;
			FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Gameplay", 0f);
		}
	}

	public void \u02B9\u02B5\u02B5\u02C1\u02B8\u02B2\u02B6\u02B5\u02BD\u02B4\u02BF()
	{
		base.StartCoroutine(this.\u02BC\u02C1\u02B6\u02B4\u02BD\u02BA\u02B6\u02B9\u02BB\u02B7\u02B8());
	}

	private void Awake()
	{
		this.quickplay.SetActive(false);
		this.quickplayPractice.SetActive(false);
		this.setlist.SetActive(false);
		this.setlist_end.SetActive(false);
	}

	public void \u02BF\u02B7\u02B8\u02B9\u02B3\u02BE\u02BF\u02B5\u02B7\u02C1\u02B2()
	{
		GlobalVariables.instance.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = false;
		FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Vocals", 1748f);
	}

	public void \u02BA\u02B7\u02B7\u02BE\u02C0\u02BC\u02C1\u02B9\u02BC\u02BB\u02B8()
	{
		GlobalVariables.instance.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = true;
		FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Main Menu", 0f);
	}

	private IEnumerator \u02B5\u02B8\u02BC\u02B6\u02B5\u02B9\u02BD\u02B9\u02BD\u02BD\u02C1()
	{
		EndOfSong.\u02BE\u02BB\u02B2\u02C0\u02BD\u02C1\u02B8\u02B6\u02B2\u02BC\u02B2 u02BE_u02BB_u02B2_u02C0_u02BD_u02C1_u02B8_u02B6_u02B2_u02BC_u02B = new EndOfSong.\u02BE\u02BB\u02B2\u02C0\u02BD\u02C1\u02B8\u02B6\u02B2\u02BC\u02B2(1);
		u02BE_u02BB_u02B2_u02C0_u02BD_u02C1_u02B8_u02B6_u02B2_u02BC_u02B.<>4__this = this;
		return u02BE_u02BB_u02B2_u02C0_u02BD_u02C1_u02B8_u02B6_u02B2_u02BC_u02B;
	}

	public void \u02BB\u02C1\u02C1\u02B6\u02B6\u02BF\u02B7\u02BC\u02BE\u02B5\u02B5()
	{
		GlobalVariables.instance.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = false;
		FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("nomodifiers", 1321f);
	}

	public bool \u02B8\u02BA\u02BF\u02B6\u02B7\u02BF\u02BA\u02B4\u02B7\u02B9\u02B3()
	{
		return this.<\u02C0\u02B6\u02C0\u02BB\u02B4\u02BA\u02B9\u02BE\u02BF\u02B3\u02C1>k__BackingField;
	}

	public void \u02B6\u02BF\u02C1\u02BD\u02BB\u02BF\u02B2\u02B2\u02B6\u02C1\u02BC()
	{
		if (GlobalVariables.instance.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			if (this.\u02BF\u02B8\u02B5\u02BC\u02C0\u02C0\u02B7\u02BD\u02BE\u02B4\u02B7)
			{
				GlobalVariables.instance.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = true;
				\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BF\u02BD\u02C1\u02C0\u02BC\u02B7\u02B4\u02C0\u02B4\u02C1();
				GlobalVariables.instance.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6 = true;
				GlobalVariables.instance.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7 = 1;
				SettingsController.song_speed.CurrentValue = GlobalVariables.instance.\u02B9\u02B7\u02BE\u02BF\u02B4\u02C1\u02BC\u02B2\u02BC\u02B8\u02B4;
				FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("5 Fret Guitar", 553f);
			}
			else
			{
				GlobalVariables.instance.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7++;
				SettingsController.song_speed.CurrentValue = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC[GlobalVariables.instance.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7];
				GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD[GlobalVariables.instance.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7];
				FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("6 Fret Lead Guitar", 841f);
			}
		}
		else
		{
			SettingsController.song_speed.CurrentValue = GlobalVariables.instance.\u02B9\u02B7\u02BE\u02BF\u02B4\u02C1\u02BC\u02B2\u02BC\u02B8\u02B4;
			GlobalVariables.instance.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = false;
			FadeBehaviour.instance.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Lefty Flip", 1191f);
		}
		this.\u02BF\u02BC\u02BF\u02B6\u02BD\u02C0\u02B6\u02B7\u02B8\u02C0\u02B5.\u02BA\u02B8\u02B4\u02BC\u02B4\u02C1\u02B8\u02B9\u02B6\u02C1\u02B4();
	}

	public GameObject \u02BB\u02C0\u02B5\u02C1\u02BF\u02BD\u02B3\u02B6\u02BE\u02BB\u02B9;

	private float \u02C0\u02B8\u02B7\u02BE\u02BC\u02C1\u02B2\u02BF\u02BA\u02B5\u02B4;

	[SerializeField]
	private TextMeshProUGUI botSaveWarning;

	[SerializeField]
	private TextMeshProUGUI savingText;

	[SerializeField]
	private TextMeshProUGUI artistName;

	[SerializeField]
	private TextMeshProUGUI score;

	[SerializeField]
	private TextMeshProUGUI songName;

	[SerializeField]
	private TextMeshProUGUI charterName;

	[SerializeField]
	private TextMeshProUGUI versionNumber;

	[SerializeField]
	private TextMeshProUGUI nextSong;

	[SerializeField]
	private EOSScreenshotNotification screenshotNotification;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Sprite defaultAlbumArt;

	[SerializeField]
	private GameObject versusTrophy;

	[SerializeField]
	private TextMeshProUGUI winnerName;

	[SerializeField]
	private GameObject[] starObjects;

	private bool \u02BF\u02B8\u02B5\u02BC\u02C0\u02C0\u02B7\u02BD\u02BE\u02B4\u02B7;

	[SerializeField]
	private ConfirmationMenu confirmMenu;

	[SerializeField]
	private GameObject quickplay;

	[SerializeField]
	private GameObject quickplayPractice;

	[SerializeField]
	private GameObject setlist;

	[SerializeField]
	private GameObject setlist_end;

	[SerializeField]
	private GameObject screenshot;

	[SerializeField]
	private PlayerStatsBox[] statsBoxes;

	public GameObject \u02B8\u02C1\u02B9\u02C1\u02BE\u02BA\u02B4\u02B8\u02BB\u02BF\u02BD;

	private \u02BD\u02B3\u02BF\u02C0\u02BF\u02C1\u02B5\u02B3\u02BE\u02BD\u02B6 \u02BF\u02BC\u02BF\u02B6\u02BD\u02C0\u02B6\u02B7\u02B8\u02C0\u02B5;

	[SerializeField]
	private DrumEndOfSongOptionsMenu drumsOptionsMenu;

	private ControllerType \u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;

	private bool \u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;

	private CHPlayer \u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8;

	private bool \u02BD\u02B7\u02BA\u02C0\u02BF\u02BE\u02BB\u02B4\u02B2\u02B5\u02C0;

	private bool \u02B6\u02B3\u02B7\u02B5\u02B7\u02B9\u02B2\u02B5\u02BC\u02BB\u02BD;
}
