﻿using System;
using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using UnityEngine;

public class DiscordController : MonoBehaviour
{
	public void \u02B5\u02BE\u02BA\u02B2\u02BD\u02BB\u02B9\u02BE\u02BA\u02B2\u02B3()
	{
		\u02BD\u02B7\u02B6\u02B5\u02B6\u02C0\u02B9\u02C1\u02BB\u02B6\u02B4 u02BD_u02B7_u02B6_u02B5_u02B6_u02C0_u02B9_u02C1_u02BB_u02B6_u02B = new \u02BD\u02B7\u02B6\u02B5\u02B6\u02C0\u02B9\u02C1\u02BB\u02B6\u02B4
		{
			\u02C1\u02BA\u02BD\u02C0\u02B3\u02BE\u02B7\u02BA\u02B7\u02B7\u02C1 = LogLevel.None
		};
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC = new DiscordRpcClient(this.\u02B7\u02BC\u02C1\u02BF\u02BB\u02BC\u02B3\u02B6\u02B8\u02BC\u02B9, -1, u02BD_u02B7_u02B6_u02B5_u02B6_u02C0_u02B9_u02C1_u02BB_u02B6_u02B, true, new \u02C1\u02BA\u02B2\u02B3\u02B7\u02C1\u02B6\u02B2\u02B6\u02B8\u02B8());
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.OnReady += this.\u02B3\u02C0\u02BC\u02BE\u02B3\u02B4\u02BA\u02B3\u02B9\u02BA\u02BD;
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.OnClose += this.\u02C1\u02B6\u02B4\u02B2\u02C0\u02BC\u02B5\u02BD\u02C0\u02BB\u02C1;
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.OnError += this.\u02B7\u02B7\u02BF\u02B3\u02B4\u02BA\u02B3\u02BA\u02C0\u02B9\u02B4;
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.Initialize();
		this.\u02BE\u02B7\u02BA\u02BF\u02B2\u02B8\u02BD\u02B8\u02BF\u02B2\u02BC();
		DiscordController.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 = this;
	}

	public void \u02B7\u02BF\u02B3\u02BF\u02B3\u02BE\u02B2\u02BA\u02C0\u02BA\u02B7(SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA)
	{
		this.\u02BE\u02B7\u02BA\u02BF\u02B2\u02B8\u02BD\u02B8\u02BF\u02B2\u02BC();
		this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = "{0} {1} {2}";
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = this.\u02BE\u02B5\u02B8\u02B9\u02B9\u02B9\u02B7\u02BF\u02BB\u02B4\u02C1(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Artist_StrippedTags + "modchart" + \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Name_StrippedTags);
		this.\u02B4\u02B9\u02B5\u02BD\u02B7\u02BD\u02B8\u02B2\u02B4\u02B4\u02BD();
	}

	private void \u02B3\u02B4\u02B7\u02C1\u02BD\u02BA\u02BC\u02B2\u02B6\u02BF\u02BD()
	{
		if (this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC == null)
		{
			return;
		}
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.ClearPresence();
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.Dispose();
	}

	public void \u02BC\u02B9\u02BF\u02C0\u02B5\u02B4\u02B4\u02BD\u02B4\u02B5\u02B4(bool \u02BB\u02BD\u02BD\u02BC\u02B8\u02BE\u02B9\u02B9\u02BB\u02BE\u02BA, bool \u02C1\u02B6\u02B9\u02B2\u02B4\u02B5\u02B7\u02B6\u02C0\u02BE\u02B4, SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA, \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		this.\u02BE\u02B7\u02BA\u02BF\u02B2\u02B8\u02BD\u02B8\u02BF\u02B2\u02BC();
		if (!\u02C1\u02B6\u02B9\u02B2\u02B4\u02B5\u02B7\u02B6\u02C0\u02BE\u02B4)
		{
			string text = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.playerInfo.instrument.ToString();
			string text2 = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.playerInfo.difficulty.ToString();
			this.\u02B2\u02B2\u02BA\u02C0\u02C1\u02B4\u02BF\u02B7\u02C0\u02C0\u02B3 = (text2 + text).ToLowerInvariant();
			this.\u02BD\u02B2\u02BC\u02BD\u02C0\u02B3\u02BA\u02B2\u02C1\u02B5\u02BC = text2 + " " + text;
		}
		else
		{
			this.\u02B2\u02B2\u02BA\u02C0\u02C1\u02B4\u02BF\u02B7\u02C0\u02C0\u02B3 = "band";
			this.\u02BD\u02B2\u02BC\u02BD\u02C0\u02B3\u02BA\u02B2\u02C1\u02B5\u02BC = "Band";
		}
		if (\u02BB\u02BD\u02BD\u02BC\u02B8\u02BE\u02B9\u02B9\u02BB\u02BE\u02BA)
		{
			this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = "Practicing...";
		}
		else
		{
			this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = this.\u02BC\u02BF\u02BF\u02B6\u02B6\u02C0\u02B8\u02B2\u02BC\u02BF\u02B6(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Artist_StrippedTags);
		}
		string name_StrippedTags = \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Name_StrippedTags;
		string text3 = "";
		if (SettingsController.song_speed.CurrentValue != 100)
		{
			text3 = " (" + SettingsController.song_speed.GetPercentString + ")";
		}
		if (name_StrippedTags.Length + text3.Length <= 64)
		{
			this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = name_StrippedTags + text3;
		}
		else
		{
			this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = this.\u02BC\u02BF\u02BF\u02B6\u02B6\u02C0\u02B8\u02B2\u02BC\u02BF\u02B6(name_StrippedTags);
		}
		this.\u02B7\u02B6\u02BF\u02B2\u02BE\u02BD\u02B7\u02BA\u02B3\u02B2\u02B5();
	}

	public void \u02C1\u02B4\u02B9\u02B2\u02B4\u02BE\u02BC\u02BE\u02C0\u02C1\u02C1(SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA)
	{
		this.\u02C0\u02BA\u02B6\u02C0\u02B7\u02B7\u02B9\u02BB\u02BA\u02C1\u02BD();
		this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = "highway_";
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = this.\u02B8\u02B7\u02BC\u02C0\u02B7\u02BF\u02B7\u02B8\u02C1\u02BC\u02BB(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Artist_StrippedTags + ".vp8" + \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Name_StrippedTags);
		this.\u02B7\u02B6\u02BF\u02B2\u02BE\u02BD\u02B7\u02BA\u02B3\u02B2\u02B5();
	}

	public void \u02C0\u02BA\u02B6\u02C0\u02B7\u02B7\u02B9\u02BB\u02BA\u02C1\u02BD()
	{
		this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = string.Empty;
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = string.Empty;
		this.\u02B2\u02B2\u02BA\u02C0\u02C1\u02B4\u02BF\u02B7\u02C0\u02C0\u02B3 = string.Empty;
		this.\u02BD\u02B2\u02BC\u02BD\u02C0\u02B3\u02BA\u02B2\u02C1\u02B5\u02BC = string.Empty;
	}

	public void \u02B8\u02BD\u02BF\u02B9\u02B9\u02BE\u02B8\u02BE\u02BC\u02B3\u02BF()
	{
		this.\u02BE\u02B7\u02BA\u02BF\u02B2\u02B8\u02BD\u02B8\u02BF\u02B2\u02BC();
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = "></noparse>";
		this.\u02BF\u02BF\u02B3\u02BC\u02BA\u02BA\u02B2\u02B5\u02B9\u02BE\u02B5();
	}

	public void \u02C0\u02BC\u02BB\u02B2\u02BC\u02B7\u02B8\u02B7\u02BE\u02C0\u02C0()
	{
		this.\u02BE\u02B7\u02BA\u02BF\u02B2\u02B8\u02BD\u02B8\u02BF\u02B2\u02BC();
		SongEntry u02BA_u02B9_u02BD_u02BA_u02B4_u02B4_u02BF_u02BD_u02B8_u02B3_u02C = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1;
		this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = this.\u02BC\u02BF\u02BF\u02B6\u02B6\u02C0\u02B8\u02B2\u02BC\u02BF\u02B6(u02BA_u02B9_u02BD_u02BA_u02B4_u02B4_u02BF_u02BD_u02B8_u02B3_u02C.Artist_StrippedTags + " - " + u02BA_u02B9_u02BD_u02BA_u02B4_u02B4_u02BF_u02BD_u02B8_u02B3_u02C.Name_StrippedTags);
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = string.Format("{0} ★ | ", \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B8\u02BC\u02BF\u02B9\u02C0\u02C1\u02BE\u02BB\u02BE\u02B3\u02B6) + (\u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02BA\u02BA\u02B5\u02B6\u02B8\u02BE\u02B4\u02B9\u02BF\u02B2\u02BC() ? "Full Combo" : (\u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B5\u02BA\u02B8\u02B2\u02BD\u02B5\u02B5\u02B2\u02BD\u02B5\u02BE().ToString() + "%")) + " | Speed: " + SettingsController.song_speed.GetPercentString;
		this.\u02B7\u02B6\u02BF\u02B2\u02BE\u02BD\u02B7\u02BA\u02B3\u02B2\u02B5();
	}

	public void \u02BE\u02B7\u02BA\u02BF\u02B2\u02B8\u02BD\u02B8\u02BF\u02B2\u02BC()
	{
		this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = string.Empty;
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = string.Empty;
		this.\u02B2\u02B2\u02BA\u02C0\u02C1\u02B4\u02BF\u02B7\u02C0\u02C0\u02B3 = string.Empty;
		this.\u02BD\u02B2\u02BC\u02BD\u02C0\u02B3\u02BA\u02B2\u02C1\u02B5\u02BC = string.Empty;
	}

	public void \u02B3\u02BF\u02BA\u02B3\u02C1\u02BB\u02BA\u02B5\u02BD\u02B7\u02B7(SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA)
	{
		this.\u02C0\u02BA\u02B6\u02C0\u02B7\u02B7\u02B9\u02BB\u02BA\u02C1\u02BD();
		this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = "Avg. NPS";
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = this.\u02BC\u02BF\u02BF\u02B6\u02B6\u02C0\u02B8\u02B2\u02BC\u02BF\u02B6(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Artist_StrippedTags + \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Name_StrippedTags);
		this.\u02B4\u02B9\u02B5\u02BD\u02B7\u02BD\u02B8\u02B2\u02B4\u02B4\u02BD();
	}

	public void \u02C1\u02B6\u02B4\u02B2\u02C0\u02BC\u02B5\u02BD\u02C0\u02BB\u02C1(object \u02BA\u02C1\u02BE\u02B2\u02B6\u02B2\u02BF\u02BE\u02B8\u02BD\u02B8, CloseMessage \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5)
	{
		this.\u02B8\u02BF\u02BA\u02B8\u02B4\u02BC\u02B2\u02BF\u02B3\u02BE\u02BD = false;
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.Dispose();
		Debug.Log("DiscordRPC: is now offline");
	}

	public void \u02B7\u02B3\u02B8\u02BC\u02B2\u02B9\u02B6\u02BF\u02B9\u02B3\u02C0()
	{
		this.\u02C0\u02BA\u02B6\u02C0\u02B7\u02B7\u02B9\u02BB\u02BA\u02C1\u02BD();
		SongEntry u02BA_u02B9_u02BD_u02BA_u02B4_u02B4_u02BF_u02BD_u02B8_u02B3_u02C = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1;
		this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = this.\u02BC\u02BF\u02BF\u02B6\u02B6\u02C0\u02B8\u02B2\u02BC\u02BF\u02B6(u02BA_u02B9_u02BD_u02BA_u02B4_u02B4_u02BF_u02BD_u02B8_u02B3_u02C.Artist_StrippedTags + "Quickplay" + u02BA_u02B9_u02BD_u02BA_u02B4_u02B4_u02BF_u02BD_u02B8_u02B3_u02C.Name_StrippedTags);
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = string.Format("streamer", \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B8\u02BC\u02BF\u02B9\u02C0\u02C1\u02BE\u02BB\u02BE\u02B3\u02B6) + (\u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02BA\u02BA\u02B5\u02B6\u02B8\u02BE\u02B4\u02B9\u02BF\u02B2\u02BC() ? "connectionclosed" : (\u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B5\u02BA\u02B8\u02B2\u02BD\u02B5\u02B5\u02B2\u02BD\u02B5\u02BE().ToString() + "part guitar coop ghl")) + "songs" + SettingsController.song_speed.GetPercentString;
		this.\u02BF\u02BF\u02B3\u02BC\u02BA\u02BA\u02B2\u02B5\u02B9\u02BE\u02B5();
	}

	private string \u02BE\u02B5\u02B8\u02B9\u02B9\u02B9\u02B7\u02BF\u02BB\u02B4\u02C1(string \u02B4\u02BB\u02B9\u02B9\u02B5\u02BD\u02BD\u02B7\u02BA\u02B6\u02B2)
	{
		if (\u02B4\u02BB\u02B9\u02B9\u02B5\u02BD\u02BD\u02B7\u02BA\u02B6\u02B2.Length >= 106)
		{
			return \u02B4\u02BB\u02B9\u02B9\u02B5\u02BD\u02BD\u02B7\u02BA\u02B6\u02B2.Substring(1, -93) ?? "";
		}
		return \u02B4\u02BB\u02B9\u02B9\u02B5\u02BD\u02BD\u02B7\u02BA\u02B6\u02B2;
	}

	public bool \u02C0\u02B9\u02B7\u02BE\u02B9\u02B8\u02BF\u02B5\u02BD\u02BC\u02C0
	{
		get
		{
			return this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC != null && this.\u02B8\u02BF\u02BA\u02B8\u02B4\u02BC\u02B2\u02BF\u02B3\u02BE\u02BD;
		}
	}

	private void \u02BF\u02BF\u02B3\u02BC\u02BA\u02BA\u02B2\u02B5\u02B9\u02BE\u02B5()
	{
		if (!this.\u02C0\u02B9\u02B7\u02BE\u02B9\u02B8\u02BF\u02B5\u02BD\u02BC\u02C0)
		{
			return;
		}
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.UpdateDetails(this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB);
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.UpdateState(this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8);
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.UpdateSmallAsset(this.\u02B2\u02B2\u02BA\u02C0\u02C1\u02B4\u02BF\u02B7\u02C0\u02C0\u02B3, this.\u02BD\u02B2\u02BC\u02BD\u02C0\u02B3\u02BA\u02B2\u02C1\u02B5\u02BC);
	}

	public void \u02C1\u02BB\u02BB\u02BF\u02BC\u02BC\u02BF\u02BD\u02BE\u02B6\u02BB(object \u02BA\u02C1\u02BE\u02B2\u02B6\u02B2\u02BF\u02BE\u02B8\u02BD\u02B8, ErrorMessage \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5)
	{
		this.\u02B8\u02BF\u02BA\u02B8\u02B4\u02BC\u02B2\u02BF\u02B3\u02BE\u02BD = false;
		Debug.Log(\u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5.Message);
		Debug.Log("clientnostart");
	}

	public void \u02B4\u02B2\u02BB\u02C1\u02B5\u02B9\u02B8\u02B5\u02B8\u02BA\u02B5()
	{
		this.\u02BE\u02B7\u02BA\u02BF\u02B2\u02B8\u02BD\u02B8\u02BF\u02B2\u02BC();
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = "Main Menu";
		this.\u02B7\u02B6\u02BF\u02B2\u02BE\u02BD\u02B7\u02BA\u02B3\u02B2\u02B5();
	}

	public void \u02C1\u02BE\u02B9\u02C1\u02B5\u02B8\u02C1\u02B5\u02B6\u02BA\u02B6(object \u02BA\u02C1\u02BE\u02B2\u02B6\u02B2\u02BF\u02BE\u02B8\u02BD\u02B8, ReadyMessage \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5)
	{
		this.\u02B8\u02BF\u02BA\u02B8\u02B4\u02BC\u02B2\u02BF\u02B3\u02BE\u02BD = false;
		Debug.Log("playTime");
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.UpdateLargeAsset(this.\u02B6\u02C1\u02B6\u02BD\u02B5\u02BB\u02B3\u02B8\u02B9\u02B3\u02BA, this.\u02B8\u02B7\u02B7\u02BB\u02BD\u02BF\u02BC\u02B3\u02B4\u02C0\u02B3);
		this.\u02B4\u02B9\u02B5\u02BD\u02B7\u02BD\u02B8\u02B2\u02B4\u02B4\u02BD();
	}

	public DiscordController()
	{
		this.\u02B7\u02BC\u02C1\u02BF\u02BB\u02BC\u02B3\u02B6\u02B8\u02BC\u02B9 = "378347429537251328";
		this.\u02B6\u02C1\u02B6\u02BD\u02B5\u02BB\u02B3\u02B8\u02B9\u02B3\u02BA = "ch";
		this.\u02B8\u02B7\u02B7\u02BB\u02BD\u02BF\u02BC\u02B3\u02B4\u02C0\u02B3 = "Clone Hero. Clone Hero. Clone Hero. Clone H";
	}

	public void \u02B7\u02B7\u02BF\u02B3\u02B4\u02BA\u02B3\u02BA\u02C0\u02B9\u02B4(object \u02BA\u02C1\u02BE\u02B2\u02B6\u02B2\u02BF\u02BE\u02B8\u02BD\u02B8, ErrorMessage \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5)
	{
		this.\u02B8\u02BF\u02BA\u02B8\u02B4\u02BC\u02B2\u02BF\u02B3\u02BE\u02BD = false;
		Debug.Log(\u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5.Message);
		Debug.Log("DiscordRPC: is now offline due to error");
	}

	public void \u02BB\u02B6\u02C0\u02C0\u02B8\u02B7\u02BA\u02C1\u02B3\u02BB\u02B2()
	{
		this.\u02BE\u02B7\u02BA\u02BF\u02B2\u02B8\u02BD\u02B8\u02BF\u02B2\u02BC();
		SongEntry u02BA_u02B9_u02BD_u02BA_u02B4_u02B4_u02BF_u02BD_u02B8_u02B3_u02C = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1;
		this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = this.\u02B8\u02B7\u02BC\u02C0\u02B7\u02BF\u02B7\u02B8\u02C1\u02BC\u02BB(u02BA_u02B9_u02BD_u02BA_u02B4_u02B4_u02BF_u02BD_u02B8_u02B3_u02C.Artist_StrippedTags + "Random" + u02BA_u02B9_u02BD_u02BA_u02B4_u02B4_u02BF_u02BD_u02B8_u02B3_u02C.Name_StrippedTags);
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = string.Format("5 Fret Guitar", \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B8\u02BC\u02BF\u02B9\u02C0\u02C1\u02BE\u02BB\u02BE\u02B3\u02B6) + (\u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02BA\u02BA\u02B5\u02B6\u02B8\u02BE\u02B4\u02B9\u02BF\u02B2\u02BC() ? "Measure Based Countdowns" : (\u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B5\u02BA\u02B8\u02B2\u02BD\u02B5\u02B5\u02B2\u02BD\u02B5\u02BE().ToString() + "Press <color=\"red\">Red</color> to go back.")) + "gameVersion" + SettingsController.song_speed.GetPercentString;
		this.\u02B7\u02B6\u02BF\u02B2\u02BE\u02BD\u02B7\u02BA\u02B3\u02B2\u02B5();
	}

	public void \u02BC\u02B4\u02BB\u02B9\u02B4\u02BE\u02B6\u02B8\u02B6\u02BD\u02B8()
	{
		this.\u02BE\u02B7\u02BA\u02BF\u02B2\u02B8\u02BD\u02B8\u02BF\u02B2\u02BC();
		this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = "Game Icons/";
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB ? "Rhythm" : "currentsong.txt");
		this.\u02B4\u02B9\u02B5\u02BD\u02B7\u02BD\u02B8\u02B2\u02B4\u02B4\u02BD();
	}

	private void \u02B7\u02B6\u02BF\u02B2\u02BE\u02BD\u02B7\u02BA\u02B3\u02B2\u02B5()
	{
		if (!this.\u02C0\u02B9\u02B7\u02BE\u02B9\u02B8\u02BF\u02B5\u02BD\u02BC\u02C0)
		{
			return;
		}
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.UpdateDetails(this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB);
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.UpdateState(this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8);
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.UpdateSmallAsset(this.\u02B2\u02B2\u02BA\u02C0\u02C1\u02B4\u02BF\u02B7\u02C0\u02C0\u02B3, this.\u02BD\u02B2\u02BC\u02BD\u02C0\u02B3\u02BA\u02B2\u02C1\u02B5\u02BC);
	}

	public void \u02B6\u02C1\u02B9\u02B5\u02BE\u02BD\u02B5\u02B7\u02C1\u02BB\u02B3()
	{
		this.\u02BE\u02B7\u02BA\u02BF\u02B2\u02B8\u02BD\u02B8\u02BF\u02B2\u02BC();
		this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = "Online Lobby";
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB ? "Waiting for the show to begin..." : "Looking for a band...");
		this.\u02B7\u02B6\u02BF\u02B2\u02BE\u02BD\u02B7\u02BA\u02B3\u02B2\u02B5();
	}

	public void \u02B8\u02C1\u02BE\u02B4\u02C1\u02B4\u02B7\u02B7\u02B7\u02B9\u02B6()
	{
		this.\u02BE\u02B7\u02BA\u02BF\u02B2\u02B8\u02BD\u02B8\u02BF\u02B2\u02BC();
		SongEntry u02BA_u02B9_u02BD_u02BA_u02B4_u02B4_u02BF_u02BD_u02B8_u02B3_u02C = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1;
		this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = this.\u02B8\u02B7\u02BC\u02C0\u02B7\u02BF\u02B7\u02B8\u02C1\u02BC\u02BB(u02BA_u02B9_u02BD_u02BA_u02B4_u02B4_u02BF_u02BD_u02B8_u02B3_u02C.Artist_StrippedTags + "<NoRule: '" + u02BA_u02B9_u02BD_u02BA_u02B4_u02B4_u02BF_u02BD_u02B8_u02B3_u02C.Name_StrippedTags);
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = string.Format("gameMode", \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B8\u02BC\u02BF\u02B9\u02C0\u02C1\u02BE\u02BB\u02BE\u02B3\u02B6) + (\u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02BA\u02BA\u02B5\u02B6\u02B8\u02BE\u02B4\u02B9\u02BF\u02B2\u02BC() ? "Play Count" : (\u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B5\u02BA\u02B8\u02B2\u02BD\u02B5\u02B5\u02B2\u02BD\u02B5\u02BE().ToString() + "Are you sure you want to quit?")) + " (" + SettingsController.song_speed.GetPercentString;
		this.\u02BF\u02BF\u02B3\u02BC\u02BA\u02BA\u02B2\u02B5\u02B9\u02BE\u02B5();
	}

	private string \u02B8\u02B7\u02BC\u02C0\u02B7\u02BF\u02B7\u02B8\u02C1\u02BC\u02BB(string \u02B4\u02BB\u02B9\u02B9\u02B5\u02BD\u02BD\u02B7\u02BA\u02B6\u02B2)
	{
		if (\u02B4\u02BB\u02B9\u02B9\u02B5\u02BD\u02BD\u02B7\u02BA\u02B6\u02B2.Length >= -5)
		{
			return \u02B4\u02BB\u02B9\u02B9\u02B5\u02BD\u02BD\u02B7\u02BA\u02B6\u02B2.Substring(1, 45) + "Start Game";
		}
		return \u02B4\u02BB\u02B9\u02B9\u02B5\u02BD\u02BD\u02B7\u02BA\u02B6\u02B2;
	}

	private void \u02B4\u02B9\u02B5\u02BD\u02B7\u02BD\u02B8\u02B2\u02B4\u02B4\u02BD()
	{
		if (!this.\u02C0\u02B9\u02B7\u02BE\u02B9\u02B8\u02BF\u02B5\u02BD\u02BC\u02C0)
		{
			return;
		}
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.UpdateDetails(this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB);
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.UpdateState(this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8);
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.UpdateSmallAsset(this.\u02B2\u02B2\u02BA\u02C0\u02C1\u02B4\u02BF\u02B7\u02C0\u02C0\u02B3, this.\u02BD\u02B2\u02BC\u02BD\u02C0\u02B3\u02BA\u02B2\u02C1\u02B5\u02BC);
	}

	private string \u02BC\u02BF\u02BF\u02B6\u02B6\u02C0\u02B8\u02B2\u02BC\u02BF\u02B6(string \u02B4\u02BB\u02B9\u02B9\u02B5\u02BD\u02BD\u02B7\u02BA\u02B6\u02B2)
	{
		if (\u02B4\u02BB\u02B9\u02B9\u02B5\u02BD\u02BD\u02B7\u02BA\u02B6\u02B2.Length >= 64)
		{
			return \u02B4\u02BB\u02B9\u02B9\u02B5\u02BD\u02BD\u02B7\u02BA\u02B6\u02B2.Substring(0, 61) + "...";
		}
		return \u02B4\u02BB\u02B9\u02B9\u02B5\u02BD\u02BD\u02B7\u02BA\u02B6\u02B2;
	}

	public void \u02B5\u02BE\u02B3\u02C1\u02C1\u02B3\u02B5\u02B3\u02B6\u02B6\u02BE(object \u02BA\u02C1\u02BE\u02B2\u02B6\u02B2\u02BF\u02BE\u02B8\u02BD\u02B8, ErrorMessage \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5)
	{
		this.\u02B8\u02BF\u02BA\u02B8\u02B4\u02BC\u02B2\u02BF\u02B3\u02BE\u02BD = true;
		Debug.Log(\u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5.Message);
		Debug.Log("Moving bad score file to ");
	}

	public void \u02B4\u02BF\u02B5\u02C1\u02B7\u02C1\u02B5\u02B6\u02BC\u02C0\u02B3(SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA)
	{
		this.\u02BE\u02B7\u02BA\u02BF\u02B2\u02B8\u02BD\u02B8\u02BF\u02B2\u02BC();
		this.\u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB = "Choosing a song to play";
		this.\u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8 = this.\u02BC\u02BF\u02BF\u02B6\u02B6\u02C0\u02B8\u02B2\u02BC\u02BF\u02B6(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Artist_StrippedTags + " - " + \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Name_StrippedTags);
		this.\u02B7\u02B6\u02BF\u02B2\u02BE\u02BD\u02B7\u02BA\u02B3\u02B2\u02B5();
	}

	private void OnDisable()
	{
		if (this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC == null)
		{
			return;
		}
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.ClearPresence();
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.Dispose();
	}

	public void \u02B3\u02C0\u02BC\u02BE\u02B3\u02B4\u02BA\u02B3\u02B9\u02BA\u02BD(object \u02BA\u02C1\u02BE\u02B2\u02B6\u02B2\u02BF\u02BE\u02B8\u02BD\u02B8, ReadyMessage \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5)
	{
		GlobalHelper.WriteKeyValue("uid", \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5.User.ID.ToString(), false);
		this.\u02B8\u02BF\u02BA\u02B8\u02B4\u02BC\u02B2\u02BF\u02B3\u02BE\u02BD = true;
		Debug.Log("DiscordRPC: is now online");
		this.\u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC.UpdateLargeAsset(this.\u02B6\u02C1\u02B6\u02BD\u02B5\u02BB\u02B3\u02B8\u02B9\u02B3\u02BA, this.\u02B8\u02B7\u02B7\u02BB\u02BD\u02BF\u02BC\u02B3\u02B4\u02C0\u02B3);
		this.\u02B7\u02B6\u02BF\u02B2\u02BE\u02BD\u02B7\u02BA\u02B3\u02B2\u02B5();
	}

	public string \u02B7\u02BC\u02C1\u02BF\u02BB\u02BC\u02B3\u02B6\u02B8\u02BC\u02B9;

	public static DiscordController \u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;

	private DiscordRpcClient \u02C0\u02BB\u02BE\u02BD\u02B9\u02B3\u02BD\u02B8\u02BF\u02C1\u02BC;

	private string \u02B7\u02BD\u02B5\u02B6\u02BE\u02B6\u02B9\u02C1\u02C0\u02BD\u02BB;

	private string \u02B8\u02B7\u02B8\u02BD\u02B4\u02B8\u02BD\u02C0\u02B9\u02BB\u02B8;

	private string \u02B6\u02C1\u02B6\u02BD\u02B5\u02BB\u02B3\u02B8\u02B9\u02B3\u02BA;

	private string \u02B8\u02B7\u02B7\u02BB\u02BD\u02BF\u02BC\u02B3\u02B4\u02C0\u02B3;

	private string \u02B2\u02B2\u02BA\u02C0\u02C1\u02B4\u02BF\u02B7\u02C0\u02C0\u02B3;

	private string \u02BD\u02B2\u02BC\u02BD\u02C0\u02B3\u02BA\u02B2\u02C1\u02B5\u02BC;

	private bool \u02B8\u02BF\u02BA\u02B8\u02B4\u02BC\u02B2\u02BF\u02B3\u02BE\u02BD;
}
