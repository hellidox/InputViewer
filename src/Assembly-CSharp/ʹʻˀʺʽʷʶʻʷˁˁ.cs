﻿using System;
using UnityEngine;

internal class \u02B9\u02BB\u02C0\u02BA\u02BD\u02B7\u02B6\u02BB\u02B7\u02C1\u02C1 : \u02BC\u02BB\u02BE\u02BC\u02C1\u02B5\u02C1\u02C1\u02B5\u02B6\u02BB
{
	protected override void \u02BE\u02BE\u02BC\u02BA\u02BE\u02BA\u02B6\u02C1\u02BD\u02B4\u02B7()
	{
		this.\u02B8\u02B4\u02BC\u02B8\u02BA\u02BD\u02B8\u02B3\u02B4\u02B6\u02BC.\u02BE\u02C1\u02B5\u02B8\u02C1\u02B5\u02B9\u02BA\u02B6\u02C0\u02BF(\u02C0\u02B7\u02B5\u02C0\u02B9\u02BE\u02B4\u02C0\u02C0\u02BF\u02BF.MenuMovement, new \u02BF\u02BE\u02B7\u02B4\u02B8\u02B4\u02BD\u02BC\u02B7\u02C0\u02BA(this.\u02B5\u02B7\u02B9\u02B7\u02BE\u02BF\u02BD\u02B9\u02BA\u02BE\u02B6));
	}

	public override void \u02BA\u02B4\u02B3\u02B7\u02C0\u02B8\u02B5\u02B5\u02BE\u02C1\u02B5(\u02BD\u02C1\u02B2\u02BD\u02B5\u02B8\u02B6\u02BD\u02B9\u02C1\u02B6 \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC)
	{
		foreach (PlayerStatsBox playerStatsBox in this.\u02C1\u02BC\u02BB\u02C0\u02B2\u02BA\u02BA\u02BF\u02BC\u02BF\u02B3)
		{
			if (playerStatsBox.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == (int)\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
			{
				playerStatsBox.\u02B6\u02C0\u02C1\u02BB\u02B8\u02B7\u02B9\u02C1\u02B2\u02BC\u02B6("Ready");
			}
		}
	}

	public override bool \u02BE\u02BB\u02BF\u02B7\u02C0\u02BE\u02B3\u02BD\u02B3\u02C0\u02B4(\u02C0\u02C0\u02BD\u02B6\u02BA\u02BF\u02B3\u02BE\u02BC\u02B8\u02B4 \u02BB\u02B7\u02BC\u02B6\u02B9\u02C0\u02B7\u02BE\u02B5\u02C0\u02BA)
	{
		if (\u02BB\u02B7\u02BC\u02B6\u02B9\u02C0\u02B7\u02BE\u02B5\u02C0\u02BA == \u02C0\u02C0\u02BD\u02B6\u02BA\u02BF\u02B3\u02BE\u02BC\u02B8\u02B4.Lobby)
		{
			global::UnityEngine.Object.FindObjectOfType<EndOfSong>().\u02BA\u02B7\u02B7\u02BE\u02C0\u02BC\u02C1\u02B9\u02BC\u02BB\u02B8();
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = false;
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BC\u02B3\u02BB\u02B2\u02B6\u02BA\u02BB\u02BA\u02BC\u02BD = true;
			return true;
		}
		if (\u02BB\u02B7\u02BC\u02B6\u02B9\u02C0\u02B7\u02BE\u02B5\u02C0\u02BA == \u02C0\u02C0\u02BD\u02B6\u02BA\u02BF\u02B3\u02BE\u02BC\u02B8\u02B4.SongList)
		{
			global::UnityEngine.Object.FindObjectOfType<EndOfSong>().\u02BA\u02B7\u02B7\u02BE\u02C0\u02BC\u02C1\u02B9\u02BC\u02BB\u02B8();
			\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BF\u02BD\u02C1\u02C0\u02BC\u02B7\u02B4\u02C0\u02B4\u02C1();
			this.\u02C1\u02BC\u02BB\u02C0\u02B2\u02BA\u02BA\u02BF\u02BC\u02BF\u02B3 = null;
			return true;
		}
		if (\u02BB\u02B7\u02BC\u02B6\u02B9\u02C0\u02B7\u02BE\u02B5\u02C0\u02BA == \u02C0\u02C0\u02BD\u02B6\u02BA\u02BF\u02B3\u02BE\u02BC\u02B8\u02B4.Gameplay)
		{
			global::UnityEngine.Object.FindObjectOfType<EndOfSong>().\u02B9\u02B5\u02B5\u02BD\u02C0\u02BC\u02BA\u02BD\u02BD\u02B7\u02B9();
			this.\u02C1\u02BC\u02BB\u02C0\u02B2\u02BA\u02BA\u02BF\u02BC\u02BF\u02B3 = null;
			return true;
		}
		return false;
	}

	public override void \u02BD\u02B5\u02C1\u02B8\u02BE\u02BE\u02BB\u02B4\u02BA\u02B4\u02B4(int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
	{
		foreach (PlayerStatsBox playerStatsBox in this.\u02C1\u02BC\u02BB\u02C0\u02B2\u02BA\u02BA\u02BF\u02BC\u02BF\u02B3)
		{
			if (playerStatsBox.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
			{
				playerStatsBox.\u02B6\u02C0\u02C1\u02BB\u02B8\u02B7\u02B9\u02C1\u02B2\u02BC\u02B6("netQuit");
			}
		}
	}

	private void \u02B5\u02B7\u02B9\u02B7\u02BE\u02BF\u02BD\u02B9\u02BA\u02BE\u02B6()
	{
		this.\u02BC\u02B3\u02B2\u02B9\u02B8\u02B8\u02B2\u02BD\u02BB\u02BF\u02B7.\u02BF\u02C0\u02B8\u02B5\u02BE\u02BB\u02BA\u02B5\u02B3\u02B5\u02BA<\u02B5\u02B7\u02B3\u02B9\u02B6\u02BE\u02B3\u02B4\u02BA\u02B6\u02C0>(this.\u02B4\u02BB\u02B4\u02C0\u02C0\u02B9\u02BC\u02C1\u02B7\u02B3\u02C1);
		foreach (PlayerStatsBox playerStatsBox in this.\u02C1\u02BC\u02BB\u02C0\u02B2\u02BA\u02BA\u02BF\u02BC\u02BF\u02B3)
		{
			if (playerStatsBox.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == (int)this.\u02B4\u02BB\u02B4\u02C0\u02C0\u02B9\u02BC\u02C1\u02B7\u02B3\u02C1.\u02C1\u02BA\u02BB\u02BC\u02BF\u02B6\u02C0\u02B6\u02C1\u02C1\u02BE)
			{
				playerStatsBox.\u02B8\u02B9\u02C0\u02BA\u02C0\u02C0\u02B7\u02BE\u02B5\u02B2\u02B7(this.\u02B4\u02BB\u02B4\u02C0\u02C0\u02B9\u02BC\u02C1\u02B7\u02B3\u02C1.\u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1);
			}
		}
	}

	public override void \u02B4\u02B5\u02BE\u02C0\u02BE\u02BA\u02C0\u02C1\u02BD\u02B5\u02B9()
	{
		if (this.\u02C1\u02BC\u02BB\u02C0\u02B2\u02BA\u02BA\u02BF\u02BC\u02BF\u02B3 == null || this.\u02C1\u02BC\u02BB\u02C0\u02B2\u02BA\u02BA\u02BF\u02BC\u02BF\u02B3.Length == 0)
		{
			this.\u02C1\u02BC\u02BB\u02C0\u02B2\u02BA\u02BA\u02BF\u02BC\u02BF\u02B3 = global::UnityEngine.Object.FindObjectsOfType<PlayerStatsBox>();
			return;
		}
		if (\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02BD\u02BC\u02B2\u02B8\u02BC\u02B5\u02B5\u02BB\u02BC\u02B6 && !this.\u02B3\u02BC\u02B5\u02BA\u02BA\u02B4\u02BD\u02BF\u02BD\u02C1\u02B7)
		{
			this.\u02B3\u02BC\u02B5\u02BA\u02BA\u02B4\u02BD\u02BF\u02BD\u02C1\u02B7 = true;
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B4\u02BD\u02B8\u02BA\u02B7\u02BC\u02B9\u02B9\u02BC();
		}
	}

	public override void \u02B8\u02BA\u02B9\u02B7\u02C0\u02B6\u02BF\u02BF\u02B5\u02C0\u02B5()
	{
		this.\u02B3\u02BC\u02B5\u02BA\u02BA\u02B4\u02BD\u02BF\u02BD\u02C1\u02B7 = false;
	}

	public override void \u02BF\u02BD\u02B6\u02B2\u02B6\u02BE\u02B5\u02BF\u02BA\u02B8\u02BD()
	{
	}

	private \u02B5\u02B7\u02B3\u02B9\u02B6\u02BE\u02B3\u02B4\u02BA\u02B6\u02C0 \u02B4\u02BB\u02B4\u02C0\u02C0\u02B9\u02BC\u02C1\u02B7\u02B3\u02C1 = new \u02B5\u02B7\u02B3\u02B9\u02B6\u02BE\u02B3\u02B4\u02BA\u02B6\u02C0();

	private PlayerStatsBox[] \u02C1\u02BC\u02BB\u02C0\u02B2\u02BA\u02BA\u02BF\u02BC\u02BF\u02B3;

	private bool \u02B3\u02BC\u02B5\u02BA\u02BA\u02B4\u02BD\u02BF\u02BD\u02C1\u02B7;
}
