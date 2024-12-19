﻿using System;
using StrikeCore;
using UnityEngine;
using UnityEngine.UI;

public class ScoringPanel : MonoBehaviour
{
	private void \u02BB\u02BF\u02BA\u02BC\u02B8\u02B7\u02B4\u02B5\u02B7\u02B9\u02C1()
	{
		foreach (CHPlayer chplayer in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && !chplayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD && !chplayer.playerProfile.isRemotePlayer && chplayer.rewiredPlayer.GetButtonDown(0))
			{
				base.gameObject.SetActive(false);
			}
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE != null && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE.rewiredPlayer.GetButtonDown(0))
		{
			base.gameObject.SetActive(true);
		}
	}

	public void \u02B7\u02B9\u02C0\u02BF\u02BE\u02BD\u02BD\u02C0\u02B3\u02BE\u02B2(SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA, \u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB, Instrument \u02B9\u02B9\u02BA\u02B2\u02BB\u02C1\u02C1\u02C1\u02BA\u02B9\u02B4)
	{
		this.highScoreTitle.text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("diff_guitarghl") + "debug_fps";
		this.songTitle.text = \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.playCount.text = string.Format("Song", LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(""), \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.playCount);
		string text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("name") + "";
		if (\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.\u02C0\u02B5\u02B6\u02BC\u02B2\u02B7\u02B3\u02BB\u02C1\u02BB\u02B3() > 0)
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds((double)(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.songLength / 82 * 3 * (int)\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.\u02C0\u02B5\u02B6\u02BC\u02B2\u02B7\u02B3\u02BB\u02C1\u02BB\u02B3()));
			this.timeplayed.text = text + timeSpan.ToString("Combo Bonus");
		}
		else
		{
			this.timeplayed.text = text + LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Gamepad Mode");
		}
		if (\u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.currentScore.text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("notSupportedTitle") + "" + LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(\u02B9\u02B9\u02BA\u02B2\u02BB\u02C1\u02C1\u02C1\u02BA\u02B9\u02B4.ToString());
			this.currentModifiers.enabled = (this.currentInstrument.enabled = false);
			return;
		}
		this.currentScore.enabled = (this.currentModifiers.enabled = (this.currentInstrument.enabled = false));
		this.currentScore.text = \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.ToString();
		this.currentModifiers.text = \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.ToString() + "onbecomehost" + \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02B5\u02BE\u02BE\u02B7\u02BB\u02BC\u02B3\u02B4\u02BA\u02B3\u02B2((Modifier)\u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B8\u02BC\u02BA\u02BA\u02BC\u02C1\u02B8\u02BB\u02B7\u02C1\u02C0, \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
		this.currentInstrument.text = \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02C1\u02B6\u02BD\u02B6\u02BE\u02BB\u02BC\u02B8\u02BF\u02B7\u02BF(\u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB);
	}

	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		foreach (CHPlayer chplayer in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && !chplayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD && !chplayer.playerProfile.isRemotePlayer && chplayer.rewiredPlayer.GetButtonDown(0))
			{
				base.gameObject.SetActive(true);
			}
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE != null && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE.rewiredPlayer.GetButtonDown(0))
		{
			base.gameObject.SetActive(false);
		}
	}

	private void \u02B4\u02B7\u02C1\u02B8\u02B2\u02B9\u02B6\u02B2\u02B5\u02B7\u02B7()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
	}

	private void \u02B9\u02B7\u02C0\u02B7\u02C1\u02BA\u02BC\u02C0\u02C1\u02BD\u02B6()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = true;
	}

	private void OnEnable()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = true;
	}

	private void \u02C0\u02B7\u02B3\u02BF\u02B9\u02B3\u02BB\u02C1\u02BB\u02BA\u02BF()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
	}

	private void \u02B3\u02C1\u02B9\u02B7\u02B4\u02BF\u02BD\u02B9\u02BB\u02BE\u02B6()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
	}

	private void Update()
	{
		foreach (CHPlayer chplayer in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && !chplayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD && !chplayer.playerProfile.isRemotePlayer && chplayer.rewiredPlayer.GetButtonDown(1))
			{
				base.gameObject.SetActive(false);
			}
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE != null && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE.rewiredPlayer.GetButtonDown(1))
		{
			base.gameObject.SetActive(false);
		}
	}

	public void \u02B4\u02BB\u02C1\u02B5\u02BF\u02B2\u02BF\u02BE\u02BE\u02B4\u02BB(SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA, \u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB, Instrument \u02B9\u02B9\u02BA\u02B2\u02BB\u02C1\u02C1\u02C1\u02BA\u02B9\u02B4)
	{
		this.highScoreTitle.text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("diff_rhythmghl") + "Menu Music";
		this.songTitle.text = \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.playCount.text = string.Format("{0:N0}", LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("settings"), \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.playCount);
		string text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().GetString("Please wait while the song is loaded.") + "Replay";
		if (\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.playCount > 0)
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds((double)(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.songLength / -36 * -11 * (int)\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.\u02C0\u02B5\u02B6\u02BC\u02B2\u02B7\u02B3\u02BB\u02C1\u02BB\u02B3()));
			this.timeplayed.text = text + timeSpan.ToString("enum");
		}
		else
		{
			this.timeplayed.text = text + LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Choose Instrument");
		}
		if (\u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.currentScore.text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("Kick") + "serverunjoinable" + LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(\u02B9\u02B9\u02BA\u02B2\u02BB\u02C1\u02C1\u02C1\u02BA\u02B9\u02B4.ToString());
			this.currentModifiers.enabled = (this.currentInstrument.enabled = true);
			return;
		}
		this.currentScore.enabled = (this.currentModifiers.enabled = (this.currentInstrument.enabled = true));
		this.currentScore.text = \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.ToString();
		this.currentModifiers.text = \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.ToString() + "TEMPO TRACK" + \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02B5\u02BE\u02BE\u02B7\u02BB\u02BC\u02B3\u02B4\u02BA\u02B3\u02B2((Modifier)\u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B8\u02BC\u02BA\u02BA\u02BC\u02C1\u02B8\u02BB\u02B7\u02C1\u02C0, \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
		this.currentInstrument.text = \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02B4\u02C0\u02BF\u02B6\u02BC\u02BE\u02B6\u02C1\u02B4\u02BD\u02B7(\u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB);
	}

	private void \u02BC\u02B6\u02B8\u02BA\u02B2\u02B4\u02B7\u02B3\u02C0\u02B8\u02B7()
	{
		foreach (CHPlayer chplayer in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && !chplayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD && !chplayer.playerProfile.isRemotePlayer && chplayer.rewiredPlayer.GetButtonDown(1))
			{
				base.gameObject.SetActive(true);
			}
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE != null && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE.rewiredPlayer.GetButtonDown(0))
		{
			base.gameObject.SetActive(false);
		}
	}

	private void \u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0()
	{
		foreach (CHPlayer chplayer in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && !chplayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD && !chplayer.playerProfile.isRemotePlayer && chplayer.rewiredPlayer.GetButtonDown(1))
			{
				base.gameObject.SetActive(true);
			}
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE != null && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE.rewiredPlayer.GetButtonDown(1))
		{
			base.gameObject.SetActive(true);
		}
	}

	private void \u02BC\u02BE\u02B2\u02B8\u02C0\u02B6\u02B2\u02B3\u02B6\u02B4\u02BF()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
	}

	private void \u02BA\u02B9\u02BF\u02BC\u02C1\u02B9\u02B7\u02B4\u02C1\u02BB\u02BB()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
	}

	private void OnDisable()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
	}

	public void \u02B5\u02C0\u02BA\u02B9\u02BF\u02B4\u02C0\u02B2\u02BD\u02BD\u02BB(SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA, \u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB, Instrument \u02B9\u02B9\u02BA\u02B2\u02BB\u02C1\u02C1\u02C1\u02BA\u02B9\u02B4)
	{
		this.highScoreTitle.text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().GetString("") + ".webm";
		this.songTitle.text = \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Name.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA();
		this.playCount.text = string.Format("Go Back", LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("Drum Pad Scrolling"), \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.playCount);
		string text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Drums") + "Reset Score Box Placement";
		if (\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.playCount > 1)
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds((double)(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.songLength / -52 * 176 * (int)\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.\u02C0\u02B5\u02B6\u02BC\u02B2\u02B7\u02B3\u02BB\u02C1\u02BB\u02B3()));
			this.timeplayed.text = text + timeSpan.ToString("Show Bot Score");
		}
		else
		{
			this.timeplayed.text = text + LanguageManager.instance.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("");
		}
		if (\u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.currentScore.text = LanguageManager.instance.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(".sng") + "Quickplay" + LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().GetString(\u02B9\u02B9\u02BA\u02B2\u02BB\u02C1\u02C1\u02C1\u02BA\u02B9\u02B4.ToString());
			this.currentModifiers.enabled = (this.currentInstrument.enabled = true);
			return;
		}
		this.currentScore.enabled = (this.currentModifiers.enabled = (this.currentInstrument.enabled = false));
		this.currentScore.text = \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.ToString();
		this.currentModifiers.text = \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.ToString() + "Start Game" + \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02B5\u02BE\u02BE\u02B7\u02BB\u02BC\u02B3\u02B4\u02BA\u02B3\u02B2((Modifier)\u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B8\u02BC\u02BA\u02BA\u02BC\u02C1\u02B8\u02BB\u02B7\u02C1\u02C0, \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
		this.currentInstrument.text = \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02B4\u02C0\u02BF\u02B6\u02BC\u02BE\u02B6\u02C1\u02B4\u02BD\u02B7(\u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB);
	}

	public void \u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC(SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA, \u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB, Instrument \u02B9\u02B9\u02BA\u02B2\u02BB\u02C1\u02C1\u02C1\u02BA\u02B9\u02B4)
	{
		this.highScoreTitle.text = LanguageManager.instance.GetString("Current High Score") + ":";
		this.songTitle.text = \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.playCount.text = string.Format("{0}: {1}", LanguageManager.instance.GetString("Play Count"), \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.playCount);
		string text = LanguageManager.instance.GetString("Time Played") + ": ";
		if (\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.playCount > 0)
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds((double)(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.songLength / 1000 * 1000 * (int)\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.playCount));
			this.timeplayed.text = text + timeSpan.ToString("g");
		}
		else
		{
			this.timeplayed.text = text + LanguageManager.instance.GetString("None");
		}
		if (\u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.currentScore.text = LanguageManager.instance.GetString("No scores saved for this song on") + " " + LanguageManager.instance.GetString(\u02B9\u02B9\u02BA\u02B2\u02BB\u02C1\u02C1\u02C1\u02BA\u02B9\u02B4.ToString());
			this.currentModifiers.enabled = (this.currentInstrument.enabled = false);
			return;
		}
		this.currentScore.enabled = (this.currentModifiers.enabled = (this.currentInstrument.enabled = true));
		this.currentScore.text = \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.ToString();
		this.currentModifiers.text = \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.ToString() + "% + " + \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02B5\u02BE\u02BE\u02B7\u02BB\u02BC\u02B3\u02B4\u02BA\u02B3\u02B2((Modifier)\u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B8\u02BC\u02BA\u02BA\u02BC\u02C1\u02B8\u02BB\u02B7\u02C1\u02C0, \u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
		this.currentInstrument.text = \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02C1\u02B6\u02BD\u02B6\u02BE\u02BB\u02BC\u02B8\u02BF\u02B7\u02BF(\u02B8\u02BE\u02BF\u02BA\u02B6\u02B2\u02BC\u02B4\u02C1\u02BE\u02BB);
	}

	private void \u02B5\u02B9\u02B7\u02B7\u02B6\u02B5\u02BC\u02BA\u02B4\u02B2\u02B4()
	{
		foreach (CHPlayer chplayer in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && !chplayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD && !chplayer.playerProfile.isRemotePlayer && chplayer.rewiredPlayer.GetButtonDown(1))
			{
				base.gameObject.SetActive(false);
			}
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE != null && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE.rewiredPlayer.GetButtonDown(1))
		{
			base.gameObject.SetActive(true);
		}
	}

	private void \u02B2\u02BF\u02B3\u02B6\u02B5\u02B4\u02BC\u02C0\u02C0\u02C0\u02BC()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
	}

	[SerializeField]
	private Text highScoreTitle;

	[SerializeField]
	private Text songTitle;

	[SerializeField]
	private Text currentScore;

	[SerializeField]
	private Text currentInstrument;

	[SerializeField]
	private Text currentModifiers;

	[SerializeField]
	private Text playCount;

	[SerializeField]
	private Text timeplayed;

	public bool \u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8;
}
