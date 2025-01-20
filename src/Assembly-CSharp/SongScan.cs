﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using StrikeCore;
using TMPro;
using UnityEngine;

public class SongScan : MonoBehaviour
{
	public void \u02BF\u02BF\u02BB\u02BC\u02C0\u02BA\u02B4\u02B2\u02B4\u02C1\u02B3()
	{
		if (this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6 != null)
		{
			this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6.Start();
		}
		if (this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7 != null)
		{
			this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7.Start();
		}
	}

	public void \u02B6\u02BF\u02C1\u02BB\u02B9\u02BE\u02BA\u02BC\u02B4\u02B8\u02B8()
	{
		if (this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6 != null)
		{
			this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6.Start();
		}
		if (this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7 != null)
		{
			this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7.Start();
		}
	}

	public Coroutine \u02BA\u02B9\u02C0\u02C1\u02BF\u02BB\u02B3\u02B9\u02BB\u02B5\u02B3(bool \u02BC\u02BE\u02BA\u02B9\u02BE\u02B7\u02BE\u02B4\u02B7\u02B6\u02B4)
	{
		Settings.Load("settings");
		GlobalVariables.instance.\u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB();
		if (!this.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
		{
			this.\u02BC\u02BD\u02BD\u02BE\u02BE\u02BD\u02BC\u02B6\u02BC\u02B2\u02B2 = base.StartCoroutine(this.\u02B3\u02BC\u02BD\u02B3\u02BC\u02B7\u02BF\u02C1\u02B8\u02BD\u02B6(\u02BC\u02BE\u02BA\u02B9\u02BE\u02B7\u02BE\u02B4\u02B7\u02B6\u02B4));
		}
		return this.\u02BC\u02BD\u02BD\u02BE\u02BE\u02BD\u02BC\u02B6\u02BC\u02B2\u02B2;
	}

	public Coroutine \u02B9\u02C1\u02BB\u02B6\u02BD\u02BA\u02B9\u02B5\u02B3\u02B5\u02B6(bool \u02BC\u02BE\u02BA\u02B9\u02BE\u02B7\u02BE\u02B4\u02B7\u02B6\u02B4)
	{
		Settings.Load("Error while loading CLI chart");
		GlobalVariables.instance.\u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB();
		if (!this.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
		{
			this.\u02BC\u02BD\u02BD\u02BE\u02BE\u02BD\u02BC\u02B6\u02BC\u02B2\u02B2 = base.StartCoroutine(this.\u02B3\u02BC\u02BD\u02B3\u02BC\u02B7\u02BF\u02C1\u02B8\u02BD\u02B6(\u02BC\u02BE\u02BA\u02B9\u02BE\u02B7\u02BE\u02B4\u02B7\u02B6\u02B4));
		}
		return this.\u02BC\u02BD\u02BD\u02BE\u02BE\u02BD\u02BC\u02B6\u02BC\u02B2\u02B2;
	}

	public Coroutine \u02BF\u02BA\u02B7\u02B6\u02B2\u02B5\u02BE\u02B8\u02BA\u02C0\u02B3(bool \u02BC\u02BE\u02BA\u02B9\u02BE\u02B7\u02BE\u02B4\u02B7\u02B6\u02B4)
	{
		Settings.Load(".chart");
		GlobalVariables.instance.\u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB();
		if (!this.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
		{
			this.\u02BC\u02BD\u02BD\u02BE\u02BE\u02BD\u02BC\u02B6\u02BC\u02B2\u02B2 = base.StartCoroutine(this.\u02B3\u02BC\u02BD\u02B3\u02BC\u02B7\u02BF\u02C1\u02B8\u02BD\u02B6(\u02BC\u02BE\u02BA\u02B9\u02BE\u02B7\u02BE\u02B4\u02B7\u02B6\u02B4));
		}
		return this.\u02BC\u02BD\u02BD\u02BE\u02BE\u02BD\u02BC\u02B6\u02BC\u02B2\u02B2;
	}

	public void \u02BB\u02BC\u02BC\u02BD\u02B4\u02B4\u02BD\u02B4\u02BE\u02B2\u02B8()
	{
		if (this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6 != null)
		{
			this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6.Start();
		}
		if (this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7 != null)
		{
			this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7.Start();
		}
	}

	private void \u02B8\u02C0\u02BE\u02BD\u02BF\u02B5\u02C1\u02BC\u02B8\u02B7\u02C0()
	{
		this.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6 = true;
		\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C0\u02B4\u02B3\u02C0\u02BC\u02C0\u02B9\u02C1\u02B2\u02BF\u02B8 = true;
		if (this.\u02B7\u02BE\u02BA\u02BB\u02C0\u02BC\u02BA\u02BC\u02B3\u02B5\u02BB != null && this.\u02B7\u02BE\u02BA\u02BB\u02C0\u02BC\u02BA\u02BC\u02B3\u02B5\u02BB.IsAlive)
		{
			this.\u02B7\u02BE\u02BA\u02BB\u02C0\u02BC\u02BA\u02BC\u02B3\u02B5\u02BB.Abort();
		}
		if (this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6 != null && this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6.IsAlive)
		{
			this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6.Abort();
		}
		if (this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7 != null && this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7.IsAlive)
		{
			this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7.Abort();
		}
	}

	public void \u02C1\u02BA\u02C1\u02BA\u02B8\u02B9\u02BC\u02BD\u02B2\u02B4\u02BA()
	{
		this.container.SetActive(false);
		this.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA = true;
	}

	public void \u02C0\u02B8\u02B9\u02BD\u02B6\u02B3\u02B8\u02B2\u02BF\u02B7\u02B8()
	{
		if (this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6 != null)
		{
			this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6.Start();
		}
		if (this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7 != null)
		{
			this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7.Start();
		}
	}

	private void \u02C0\u02B7\u02B4\u02B9\u02C1\u02C1\u02B6\u02C1\u02C0\u02BF\u02BD(\u02BA\u02C0\u02B9\u02BB\u02C0\u02BE\u02B8\u02BB\u02BE\u02BD\u02BA \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8)
	{
		string text;
		switch (\u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA)
		{
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.ReadingCache:
			text = "Highway";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.GettingPaths:
			text = "</color>";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.ScanningFolders:
			text = "connectiontimeout";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.UpdatingMetadata:
			text = "Scan Songs";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.UpdatingCharts:
			text = "{0:N0}/{1:N0}";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.WritingCache:
			text = ".ini";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.WritingBadSongs:
			text = "Guitar Coop";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.SortingMetadata:
			text = "";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.OnlineHash:
			text = "Resolution";
			break;
		default:
			text = " ";
			break;
		}
		this.mainText.text = LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(text);
		this.folderText.text = string.Format("preview_volume", \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02BE\u02B7\u02B3\u02BB\u02B8\u02BE\u02BE\u02BF\u02BE\u02B4\u02C0() - \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02B7\u02B9\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B4\u02B6\u02BF, this.\u02BF\u02BC\u02B7\u02B2\u02BD\u02B5\u02B8\u02B6\u02B7\u02C0\u02C1);
		this.countText.text = string.Format("Song Display", \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count, this.\u02B9\u02BE\u02B6\u02B8\u02B9\u02B2\u02B2\u02B6\u02B2\u02B2\u02B4);
		this.errorText.text = string.Format("Main Menu", \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02C1\u02C1\u02BD\u02B3\u02B2\u02BB\u02B6\u02B8\u02BE\u02BB\u02C1.Count, this.\u02B3\u02B9\u02C0\u02BF\u02BF\u02BF\u02BD\u02B3\u02B6\u02B3\u02B6);
		this.badSongsText.text = string.Format("Options", \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02BC\u02B6\u02B4\u02C0\u02B7\u02B2\u02BA\u02BD\u02BF\u02C0\u02B4, this.\u02B3\u02B6\u02B4\u02BD\u02BF\u02B5\u02B5\u02B5\u02BC\u02B8\u02C0);
	}

	public void \u02BD\u02BF\u02BB\u02B5\u02BE\u02BC\u02B7\u02B6\u02B9\u02BB\u02BB()
	{
		if (this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6 != null)
		{
			this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6.Start();
		}
		if (this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7 != null)
		{
			this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7.Start();
		}
	}

	private void \u02BD\u02BA\u02B8\u02BE\u02B7\u02BF\u02B8\u02BA\u02BA\u02B3\u02B7()
	{
		this.\u02B8\u02C0\u02BE\u02BD\u02BF\u02B5\u02C1\u02BC\u02B8\u02B7\u02C0();
	}

	private void OnDestroy()
	{
		this.OnApplicationQuit();
	}

	private void OnApplicationQuit()
	{
		this.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6 = false;
		\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C0\u02B4\u02B3\u02C0\u02BC\u02C0\u02B9\u02C1\u02B2\u02BF\u02B8 = false;
		if (this.\u02B7\u02BE\u02BA\u02BB\u02C0\u02BC\u02BA\u02BC\u02B3\u02B5\u02BB != null && this.\u02B7\u02BE\u02BA\u02BB\u02C0\u02BC\u02BA\u02BC\u02B3\u02B5\u02BB.IsAlive)
		{
			this.\u02B7\u02BE\u02BA\u02BB\u02C0\u02BC\u02BA\u02BC\u02B3\u02B5\u02BB.Abort();
		}
		if (this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6 != null && this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6.IsAlive)
		{
			this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6.Abort();
		}
		if (this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7 != null && this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7.IsAlive)
		{
			this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7.Abort();
		}
	}

	public void \u02B2\u02B4\u02BA\u02B6\u02BF\u02B7\u02B3\u02BD\u02B7\u02B9\u02C0()
	{
		this.container.SetActive(true);
		this.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA = false;
	}

	public void \u02C1\u02B8\u02BA\u02BA\u02B9\u02BD\u02BF\u02BE\u02BA\u02B3\u02B7()
	{
		this.container.SetActive(true);
		this.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA = false;
	}

	public Coroutine \u02C1\u02B7\u02C1\u02B6\u02C0\u02BB\u02C1\u02B4\u02BD\u02BF\u02B3(bool \u02BC\u02BE\u02BA\u02B9\u02BE\u02B7\u02BE\u02B4\u02B7\u02B6\u02B4)
	{
		Settings.Load("Vsync");
		GlobalVariables.instance.\u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB();
		if (!this.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
		{
			this.\u02BC\u02BD\u02BD\u02BE\u02BE\u02BD\u02BC\u02B6\u02BC\u02B2\u02B2 = base.StartCoroutine(this.\u02B3\u02BC\u02BD\u02B3\u02BC\u02B7\u02BF\u02C1\u02B8\u02BD\u02B6(\u02BC\u02BE\u02BA\u02B9\u02BE\u02B7\u02BE\u02B4\u02B7\u02B6\u02B4));
		}
		return this.\u02BC\u02BD\u02BD\u02BE\u02BE\u02BD\u02BC\u02B6\u02BC\u02B2\u02B2;
	}

	public Coroutine \u02B2\u02BE\u02B8\u02B2\u02B4\u02BF\u02BC\u02B7\u02B9\u02C1\u02B9(bool \u02BC\u02BE\u02BA\u02B9\u02BE\u02B7\u02BE\u02B4\u02B7\u02B6\u02B4)
	{
		Settings.Load("WRITING CACHE...");
		GlobalVariables.instance.\u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB();
		if (!this.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
		{
			this.\u02BC\u02BD\u02BD\u02BE\u02BE\u02BD\u02BC\u02B6\u02BC\u02B2\u02B2 = base.StartCoroutine(this.\u02B3\u02BC\u02BD\u02B3\u02BC\u02B7\u02BF\u02C1\u02B8\u02BD\u02B6(\u02BC\u02BE\u02BA\u02B9\u02BE\u02B7\u02BE\u02B4\u02B7\u02B6\u02B4));
		}
		return this.\u02BC\u02BD\u02BD\u02BE\u02BE\u02BD\u02BC\u02B6\u02BC\u02B2\u02B2;
	}

	public Coroutine \u02BC\u02B6\u02C1\u02B9\u02BD\u02B5\u02B6\u02BA\u02B2\u02B5\u02C0(bool \u02BC\u02BE\u02BA\u02B9\u02BE\u02B7\u02BE\u02B4\u02B7\u02B6\u02B4)
	{
		Settings.Load("TEXTURE_CUTOUT");
		GlobalVariables.instance.\u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB();
		if (!this.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
		{
			this.\u02BC\u02BD\u02BD\u02BE\u02BE\u02BD\u02BC\u02B6\u02BC\u02B2\u02B2 = base.StartCoroutine(this.\u02B3\u02BC\u02BD\u02B3\u02BC\u02B7\u02BF\u02C1\u02B8\u02BD\u02B6(\u02BC\u02BE\u02BA\u02B9\u02BE\u02B7\u02BE\u02B4\u02B7\u02B6\u02B4));
		}
		return this.\u02BC\u02BD\u02BD\u02BE\u02BE\u02BD\u02BC\u02B6\u02BC\u02B2\u02B2;
	}

	private void \u02B9\u02B2\u02C0\u02BE\u02B3\u02B7\u02C0\u02C0\u02BE\u02BE\u02BF(\u02BA\u02C0\u02B9\u02BB\u02C0\u02BE\u02B8\u02BB\u02BE\u02BD\u02BA \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8)
	{
		string text;
		switch (\u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA)
		{
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.ReadingCache:
			text = "<b>";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.GettingPaths:
			text = "Song";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.ScanningFolders:
			text = "song";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.UpdatingMetadata:
			text = "New Setlist";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.UpdatingCharts:
			text = "Guitar";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.WritingCache:
			text = "expert";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.WritingBadSongs:
			text = "";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.SortingMetadata:
			text = "addCategory";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.OnlineHash:
			text = "Versus";
			break;
		default:
			text = "Yellow Cymbal";
			break;
		}
		this.mainText.text = LanguageManager.instance.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(text);
		this.folderText.text = string.Format("song", \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02BE\u02B7\u02B3\u02BB\u02B8\u02BE\u02BE\u02BF\u02BE\u02B4\u02C0() - \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02B7\u02B9\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B4\u02B6\u02BF, this.\u02BF\u02BC\u02B7\u02B2\u02BD\u02B5\u02B8\u02B6\u02B7\u02C0\u02C1);
		this.countText.text = string.Format("eof_", \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count, this.\u02B9\u02BE\u02B6\u02B8\u02B9\u02B2\u02B2\u02B6\u02B2\u02B2\u02B4);
		this.errorText.text = string.Format("Bass", \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02C1\u02C1\u02BD\u02B3\u02B2\u02BB\u02B6\u02B8\u02BE\u02BB\u02C1.Count, this.\u02B3\u02B9\u02C0\u02BF\u02BF\u02BF\u02BD\u02B3\u02B6\u02B3\u02B6);
		this.badSongsText.text = string.Format("-", \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02BC\u02B6\u02B4\u02C0\u02B7\u02B2\u02BA\u02BD\u02BF\u02C0\u02B4, this.\u02B3\u02B6\u02B4\u02BD\u02BF\u02B5\u02B5\u02B5\u02BC\u02B8\u02C0);
	}

	public void \u02BB\u02B7\u02BC\u02C0\u02BC\u02B8\u02BB\u02B5\u02C1\u02B3\u02BE()
	{
		this.container.SetActive(true);
		this.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA = true;
	}

	private void \u02BF\u02C1\u02B7\u02B8\u02B7\u02C0\u02B4\u02B8\u02B8\u02B9\u02B2(\u02BA\u02C0\u02B9\u02BB\u02C0\u02BE\u02B8\u02BB\u02BE\u02BD\u02BA \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8)
	{
		string text;
		switch (\u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA)
		{
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.ReadingCache:
			text = "diff_bass";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.GettingPaths:
			text = "Song Speed";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.ScanningFolders:
			text = "Background Video";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.UpdatingMetadata:
			text = "No";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.UpdatingCharts:
			text = "sp_awarded";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.WritingCache:
			text = " + ";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.WritingBadSongs:
			text = "Notes Missed";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.SortingMetadata:
			text = "Successfully connected to Unity Game Services";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.OnlineHash:
			text = "Song Offset";
			break;
		default:
			text = "Input Device";
			break;
		}
		this.mainText.text = LanguageManager.instance.GetString(text);
		this.folderText.text = string.Format("Options", \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02BE\u02B7\u02B3\u02BB\u02B8\u02BE\u02BE\u02BF\u02BE\u02B4\u02C0() - \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02B7\u02B9\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B4\u02B6\u02BF, this.\u02BF\u02BC\u02B7\u02B2\u02BD\u02B5\u02B8\u02B6\u02B7\u02C0\u02C1);
		this.countText.text = string.Format("...", \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count, this.\u02B9\u02BE\u02B6\u02B8\u02B9\u02B2\u02B2\u02B6\u02B2\u02B2\u02B4);
		this.errorText.text = string.Format("Remove Mapping", \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02C1\u02C1\u02BD\u02B3\u02B2\u02BB\u02B6\u02B8\u02BE\u02BB\u02C1.Count, this.\u02B3\u02B9\u02C0\u02BF\u02BF\u02BF\u02BD\u02B3\u02B6\u02B3\u02B6);
		this.badSongsText.text = string.Format("Vocals", \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02C1\u02BE\u02BB\u02BB\u02BF\u02B7\u02C0\u02B8\u02BB\u02BB\u02BE(), this.\u02B3\u02B6\u02B4\u02BD\u02BF\u02B5\u02B5\u02B5\u02BC\u02B8\u02C0);
	}

	public void \u02BD\u02B3\u02BA\u02BA\u02BB\u02B5\u02BF\u02B9\u02BB\u02BD\u02BA()
	{
		this.container.SetActive(true);
		this.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA = false;
	}

	private void \u02B3\u02B5\u02BC\u02BC\u02BB\u02B6\u02B6\u02B7\u02B6\u02B7\u02C0(\u02BA\u02C0\u02B9\u02BB\u02C0\u02BE\u02B8\u02BB\u02BE\u02BD\u02BA \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8)
	{
		string text;
		switch (\u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA)
		{
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.ReadingCache:
			text = "READING CACHE...";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.GettingPaths:
			text = "GETTING FOLDERS...";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.ScanningFolders:
			text = "SCANNING FOLDERS...";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.UpdatingMetadata:
			text = "UPDATING METADATA...";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.UpdatingCharts:
			text = "UPDATING CHARTS...";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.WritingCache:
			text = "WRITING CACHE...";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.WritingBadSongs:
			text = "WRITING BADSONGS.TXT...";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.SortingMetadata:
			text = "SORTING METADATA...";
			break;
		case \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.OnlineHash:
			text = "CREATING ONLINE HASH...";
			break;
		default:
			text = "Ruh Roh";
			break;
		}
		this.mainText.text = LanguageManager.instance.GetString(text);
		this.folderText.text = string.Format("<color=#FFFF04FF>{0}</color> {1}", \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02BE\u02BB\u02BD\u02BF\u02BB\u02BA\u02BF\u02BD\u02B7\u02BB\u02BD - \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02B7\u02B9\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B4\u02B6\u02BF, this.\u02BF\u02BC\u02B7\u02B2\u02BD\u02B5\u02B8\u02B6\u02B7\u02C0\u02C1);
		this.countText.text = string.Format("<color=#FFFF04FF>{0}</color> {1}", \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count, this.\u02B9\u02BE\u02B6\u02B8\u02B9\u02B2\u02B2\u02B6\u02B2\u02B2\u02B4);
		this.errorText.text = string.Format("<color=#FFFF04FF>{0}</color> {1}", \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02C1\u02C1\u02BD\u02B3\u02B2\u02BB\u02B6\u02B8\u02BE\u02BB\u02C1.Count, this.\u02B3\u02B9\u02C0\u02BF\u02BF\u02BF\u02BD\u02B3\u02B6\u02B3\u02B6);
		this.badSongsText.text = string.Format("<color=#FFFF04FF>{0}</color> {1}", \u02C1\u02BE\u02C0\u02B3\u02BD\u02BA\u02B2\u02B6\u02BA\u02B8\u02B8.\u02BC\u02B6\u02B4\u02C0\u02B7\u02B2\u02BA\u02BD\u02BF\u02C0\u02B4, this.\u02B3\u02B6\u02B4\u02BD\u02BF\u02B5\u02B5\u02B5\u02BC\u02B8\u02C0);
	}

	public IEnumerator \u02B3\u02BC\u02BD\u02B3\u02BC\u02B7\u02BF\u02C1\u02B8\u02BD\u02B6(bool \u02B9\u02BD\u02B6\u02C0\u02B2\u02C0\u02B2\u02C1\u02BB\u02C0\u02B9)
	{
		if (!BassAudioManager.Instance.\u02B8\u02B8\u02B6\u02BF\u02BB\u02B9\u02B4\u02B4\u02B9\u02BA\u02BF)
		{
			yield break;
		}
		bool firstRun = true;
		\u02BA\u02C0\u02B9\u02BB\u02C0\u02BE\u02B8\u02BB\u02BE\u02BD\u02BA songCache = new \u02BA\u02C0\u02B9\u02BB\u02C0\u02BE\u02B8\u02BB\u02BE\u02BD\u02BA(this);
		if (this.mainMenu != null)
		{
			this.mainMenu.\u02B7\u02BA\u02BF\u02B2\u02BA\u02BC\u02BC\u02BB\u02B2\u02BC\u02BF.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(true);
		}
		WaitForSeconds wait30 = new WaitForSeconds(0.033f);
		this.\u02BF\u02BC\u02B7\u02B2\u02BD\u02B5\u02B8\u02B6\u02B7\u02C0\u02C1 = LanguageManager.instance.GetString("Folders");
		this.\u02B9\u02BE\u02B6\u02B8\u02B9\u02B2\u02B2\u02B6\u02B2\u02B2\u02B4 = LanguageManager.instance.GetString("Songs Scanned");
		this.\u02B3\u02B9\u02C0\u02BF\u02BF\u02BF\u02BD\u02B3\u02B6\u02B3\u02B6 = LanguageManager.instance.GetString("Errors");
		this.\u02B3\u02B6\u02B4\u02BD\u02BF\u02B5\u02B5\u02B5\u02BC\u02B8\u02C0 = LanguageManager.instance.GetString("Bad Songs");
		for (;;)
		{
			\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4 = new List<SongEntry>(500);
			\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD = new List<SongEntry>();
			\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC = new List<int>();
			\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B5\u02B5\u02BF\u02B9\u02BD\u02B9\u02BC\u02B5\u02B6\u02B8\u02B3 = new List<string>();
			if (\u02B9\u02BD\u02B6\u02C0\u02B2\u02C0\u02B2\u02C1\u02BB\u02C0\u02B9)
			{
				this.\u02B7\u02BE\u02BA\u02BB\u02C0\u02BC\u02BA\u02BC\u02B3\u02B5\u02BB = new Thread(new ThreadStart(songCache.\u02B6\u02B3\u02C0\u02B5\u02B3\u02BD\u02B7\u02BF\u02BA\u02BC\u02B4))
				{
					IsBackground = true,
					Name = "Song Scan"
				};
				this.\u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6 = new Thread(new ThreadStart(\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02BA\u02BE\u02BC\u02C1\u02BB\u02B2\u02B7\u02BC\u02BD\u02BF\u02C0))
				{
					IsBackground = true,
					Name = "FSCache Scan"
				};
				this.\u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7 = new Thread(new ThreadStart(\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02BC\u02B5\u02B9\u02BA\u02B4\u02B4\u02B2\u02BF\u02B3\u02B4\u02B5))
				{
					IsBackground = true,
					Name = "FSCache Clear Thread"
				};
			}
			else
			{
				this.\u02B7\u02BE\u02BA\u02BB\u02C0\u02BC\u02BA\u02BC\u02B3\u02B5\u02BB = new Thread(new ThreadStart(songCache.\u02C0\u02C1\u02BA\u02BB\u02B3\u02C0\u02BE\u02B9\u02C0\u02BA\u02C1))
				{
					IsBackground = true,
					Name = "Song Scan"
				};
			}
			this.\u02B7\u02BE\u02BA\u02BB\u02C0\u02BC\u02BA\u02BC\u02B3\u02B5\u02BB.Start();
			this.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6 = true;
			while (!this.\u02B7\u02BE\u02BA\u02BB\u02C0\u02BC\u02BA\u02BC\u02B3\u02B5\u02BB.IsAlive)
			{
				yield return null;
			}
			while (this.\u02B7\u02BE\u02BA\u02BB\u02C0\u02BC\u02BA\u02BC\u02B3\u02B5\u02BB.IsAlive)
			{
				this.\u02B3\u02B5\u02BC\u02BC\u02BB\u02B6\u02B6\u02B7\u02B6\u02B7\u02C0(songCache);
				yield return wait30;
			}
			if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count != 0 || (\u02B9\u02BD\u02B6\u02C0\u02B2\u02C0\u02B2\u02C1\u02BB\u02C0\u02B9 || !firstRun))
			{
				break;
			}
			\u02B9\u02BD\u02B6\u02C0\u02B2\u02C0\u02B2\u02C1\u02BB\u02C0\u02B9 = true;
			firstRun = false;
		}
		this.mainText.text = LanguageManager.instance.GetString("Loading Scores...");
		\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02B3\u02B6\u02BF\u02B3\u02BE\u02C1\u02B4\u02B8\u02B7\u02BE\u02B4();
		\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02B2\u02BC\u02B2\u02BE\u02B7\u02BA\u02C1\u02B3\u02BA\u02BD\u02BC();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B4\u02B7\u02B2\u02BC\u02B8\u02B3\u02BA\u02BB\u02BC\u02B3 = -1;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(null, false);
		if (this.songSelect != null)
		{
			this.songSelect.\u02B7\u02BE\u02B8\u02B7\u02B9\u02BA\u02B3\u02B6\u02B4\u02B7\u02B8();
		}
		this.container.SetActive(false);
		this.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA = false;
		this.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6 = false;
		if (this.mainMenu && !this.mainMenu.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE)
		{
			this.mainMenu.\u02B7\u02BA\u02BF\u02B2\u02BA\u02BC\u02BC\u02BB\u02B2\u02BC\u02BF.\u02B9\u02BF\u02B3\u02C1\u02B9\u02B2\u02B9\u02BA\u02B8\u02B5\u02B9();
		}
		yield break;
	}

	[HideInInspector]
	public bool \u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6;

	private Coroutine \u02BC\u02BD\u02BD\u02BE\u02BE\u02BD\u02BC\u02B6\u02BC\u02B2\u02B2;

	[SerializeField]
	private TextMeshProUGUI countText;

	[SerializeField]
	private TextMeshProUGUI mainText;

	[SerializeField]
	private TextMeshProUGUI folderText;

	[SerializeField]
	private TextMeshProUGUI errorText;

	[SerializeField]
	private TextMeshProUGUI badSongsText;

	[SerializeField]
	private SongSelect songSelect;

	[SerializeField]
	private MainMenu mainMenu;

	[SerializeField]
	private GameObject container;

	[HideInInspector]
	public bool \u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA;

	private Thread \u02B6\u02B2\u02B2\u02C0\u02B8\u02BA\u02BC\u02BB\u02B7\u02BE\u02B7;

	private Thread \u02BF\u02B4\u02B8\u02C0\u02BE\u02BF\u02B4\u02BC\u02C1\u02C1\u02B6;

	private Thread \u02B7\u02BE\u02BA\u02BB\u02C0\u02BC\u02BA\u02BC\u02B3\u02B5\u02BB;

	private string \u02BF\u02BC\u02B7\u02B2\u02BD\u02B5\u02B8\u02B6\u02B7\u02C0\u02C1;

	private string \u02B9\u02BE\u02B6\u02B8\u02B9\u02B2\u02B2\u02B6\u02B2\u02B2\u02B4;

	private string \u02B3\u02B9\u02C0\u02BF\u02BF\u02BF\u02BD\u02B3\u02B6\u02B3\u02B6;

	private string \u02B3\u02B6\u02B4\u02BD\u02BF\u02B5\u02B5\u02B5\u02BC\u02B8\u02C0;
}
