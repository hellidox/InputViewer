﻿using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000186 RID: 390
public class RemoteIconAndSourceUpdater : MonoBehaviour
{
	// Token: 0x060011F5 RID: 4597 RVA: 0x0000F63D File Offset: 0x0000D83D
	public void \u02BB\u02B8\u02BC\u02BF\u02BB\u02BB\u02B6\u02B7\u02B2\u02B7\u02BC(bool \u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD)
	{
		base.StartCoroutine(this.\u02BD\u02BF\u02B8\u02C1\u02B4\u02C1\u02BE\u02B7\u02B3\u02C1\u02BE(\u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD));
	}

	// Token: 0x060011F7 RID: 4599 RVA: 0x0000F64D File Offset: 0x0000D84D
	private static GameIconInfoContainer \u02BD\u02B7\u02BF\u02B8\u02C0\u02B7\u02B6\u02BA\u02C0\u02B8\u02BA(string \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD)
	{
		return JsonUtility.FromJson<GameIconInfoContainer>("DiscordRPC: is now online" + \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD + "UIScrollUp");
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x0000F664 File Offset: 0x0000D864
	public IEnumerator \u02B3\u02BB\u02BD\u02B4\u02BE\u02B4\u02B8\u02B4\u02BE\u02BC\u02C1(bool \u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD)
	{
		this.\u02B2\u02BA\u02BB\u02BC\u02BF\u02BD\u02B5\u02C0\u02B5\u02C0\u02B6.SetActive(\u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD);
		this.\u02BE\u02B3\u02BC\u02BD\u02C1\u02B4\u02BC\u02BC\u02C1\u02C0\u02BE = true;
		if (this.\u02BE\u02B3\u02BC\u02BD\u02C1\u02B4\u02BC\u02BC\u02C1\u02C0\u02BE)
		{
			this.progressBody.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Please Wait.");
			this.progressTitle.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("UPDATING ICONS...");
			yield return this.\u02B5\u02BF\u02C0\u02BE\u02BE\u02BD\u02B9\u02B7\u02BA\u02BC\u02B3();
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B4\u02BB\u02C0\u02B5\u02B6\u02B6\u02B9\u02B9\u02B3\u02C0(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8);
			this.progressTitle.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("UPDATING SERVER LIST...");
			yield return RemoteIconAndSourceUpdater.\u02B3\u02BF\u02BE\u02B5\u02B6\u02B2\u02B4\u02BC\u02BC\u02C1\u02B8(new RemoteIconAndSourceUpdater.\u02B3\u02B6\u02B4\u02B3\u02B6\u02B9\u02BB\u02B4\u02B2\u02B4\u02BE(RemoteIconAndSourceUpdater.<>c.<>9.\u02BB\u02C1\u02C1\u02C0\u02B2\u02BE\u02C0\u02B2\u02BE\u02B2\u02BE));
			this.progressTitle.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("UPDATING SOURCES...");
			yield return RemoteIconAndSourceUpdater.\u02C1\u02C0\u02B8\u02B4\u02BE\u02B2\u02BD\u02B9\u02B7\u02B7\u02B2(Application.persistentDataPath);
		}
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B7\u02BB\u02B8\u02B6\u02B8\u02BA\u02B9\u02BF\u02B8\u02B3 = true;
		this.\u02B2\u02BA\u02BB\u02BC\u02BF\u02BD\u02B5\u02C0\u02B5\u02C0\u02B6.SetActive(false);
		yield break;
	}

	// Token: 0x060011F9 RID: 4601 RVA: 0x0000F67A File Offset: 0x0000D87A
	public IEnumerator \u02B2\u02BC\u02B3\u02B4\u02BA\u02B3\u02B4\u02B6\u02B8\u02C1\u02B2()
	{
		RemoteIconAndSourceUpdater.\u02B2\u02B8\u02BA\u02B6\u02BB\u02BE\u02C0\u02BF\u02B8\u02B3\u02B3 u02B2_u02B8_u02BA_u02B6_u02BB_u02BE_u02C0_u02BF_u02B8_u02B3_u02B = new RemoteIconAndSourceUpdater.\u02B2\u02B8\u02BA\u02B6\u02BB\u02BE\u02C0\u02BF\u02B8\u02B3\u02B3(1);
		u02B2_u02B8_u02BA_u02B6_u02BB_u02BE_u02C0_u02BF_u02B8_u02B3_u02B.<>4__this = this;
		return u02B2_u02B8_u02BA_u02B6_u02BB_u02BE_u02C0_u02BF_u02B8_u02B3_u02B;
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x0000F664 File Offset: 0x0000D864
	public IEnumerator \u02C0\u02B6\u02B9\u02B8\u02BE\u02BA\u02BD\u02B8\u02B2\u02BD\u02BC(bool \u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD)
	{
		this.\u02B2\u02BA\u02BB\u02BC\u02BF\u02BD\u02B5\u02C0\u02B5\u02C0\u02B6.SetActive(\u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD);
		this.\u02BE\u02B3\u02BC\u02BD\u02C1\u02B4\u02BC\u02BC\u02C1\u02C0\u02BE = true;
		if (this.\u02BE\u02B3\u02BC\u02BD\u02C1\u02B4\u02BC\u02BC\u02C1\u02C0\u02BE)
		{
			this.progressBody.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Please Wait.");
			this.progressTitle.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("UPDATING ICONS...");
			yield return this.\u02B5\u02BF\u02C0\u02BE\u02BE\u02BD\u02B9\u02B7\u02BA\u02BC\u02B3();
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B4\u02BB\u02C0\u02B5\u02B6\u02B6\u02B9\u02B9\u02B3\u02C0(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8);
			this.progressTitle.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("UPDATING SERVER LIST...");
			yield return RemoteIconAndSourceUpdater.\u02B3\u02BF\u02BE\u02B5\u02B6\u02B2\u02B4\u02BC\u02BC\u02C1\u02B8(new RemoteIconAndSourceUpdater.\u02B3\u02B6\u02B4\u02B3\u02B6\u02B9\u02BB\u02B4\u02B2\u02B4\u02BE(RemoteIconAndSourceUpdater.<>c.<>9.\u02BB\u02C1\u02C1\u02C0\u02B2\u02BE\u02C0\u02B2\u02BE\u02B2\u02BE));
			this.progressTitle.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("UPDATING SOURCES...");
			yield return RemoteIconAndSourceUpdater.\u02C1\u02C0\u02B8\u02B4\u02BE\u02B2\u02BD\u02B9\u02B7\u02B7\u02B2(Application.persistentDataPath);
		}
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B7\u02BB\u02B8\u02B6\u02B8\u02BA\u02B9\u02BF\u02B8\u02B3 = true;
		this.\u02B2\u02BA\u02BB\u02BC\u02BF\u02BD\u02B5\u02C0\u02B5\u02C0\u02B6.SetActive(false);
		yield break;
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x0000F689 File Offset: 0x0000D889
	private static GameIconInfoContainer \u02B6\u02BA\u02B2\u02BE\u02BC\u02BB\u02B9\u02B4\u02B3\u02BB\u02BE(string \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD)
	{
		return JsonUtility.FromJson<GameIconInfoContainer>("album" + \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD + "song_length");
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x0000F6A0 File Offset: 0x0000D8A0
	public static IEnumerator \u02C1\u02C0\u02B8\u02B4\u02BE\u02B2\u02BD\u02B9\u02B7\u02B7\u02B2(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		RemoteIconAndSourceUpdater.\u02BC\u02BF\u02BC\u02BC\u02BD\u02B9\u02BC\u02BA\u02BF\u02B3\u02B7 u02BC_u02BF_u02BC_u02BC_u02BD_u02B9_u02BC_u02BA_u02BF_u02B3_u02B = new RemoteIconAndSourceUpdater.\u02BC\u02BF\u02BC\u02BC\u02BD\u02B9\u02BC\u02BA\u02BF\u02B3\u02B7();
		u02BC_u02BF_u02BC_u02BC_u02BD_u02B9_u02BC_u02BA_u02BF_u02B3_u02B.sourcesCachePath = Path.Combine(\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC, "sources.txt");
		Debug.Log("download source.txt");
		yield return \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BF\u02B4\u02C0\u02B8\u02C1\u02C0\u02B9\u02BC\u02B3\u02BC\u02BF("https://sources.clonehero.net/sources.txt", new \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BB\u02B9\u02B7\u02BE\u02BD\u02BE\u02B6\u02BB\u02BB\u02BC\u02BD(u02BC_u02BF_u02BC_u02BC_u02BD_u02B9_u02BC_u02BA_u02BF_u02B3_u02B.\u02B8\u02B3\u02BA\u02B6\u02B4\u02BD\u02B5\u02B2\u02BC\u02B6\u02B3));
		Debug.Log("download source.txt finished");
		yield break;
	}

	// Token: 0x060011FD RID: 4605 RVA: 0x0000F6AF File Offset: 0x0000D8AF
	public static IEnumerator \u02B3\u02B9\u02C1\u02C1\u02B3\u02B7\u02B6\u02B8\u02BB\u02B3\u02BB(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		RemoteIconAndSourceUpdater.\u02B9\u02B8\u02C0\u02BF\u02C1\u02B3\u02B7\u02BB\u02B4\u02B2\u02B7 u02B9_u02B8_u02C0_u02BF_u02C1_u02B3_u02B7_u02BB_u02B4_u02B2_u02B = new RemoteIconAndSourceUpdater.\u02B9\u02B8\u02C0\u02BF\u02C1\u02B3\u02B7\u02BB\u02B4\u02B2\u02B7(1);
		u02B9_u02B8_u02C0_u02BF_u02C1_u02B3_u02B7_u02BB_u02B4_u02B2_u02B.path = \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC;
		return u02B9_u02B8_u02C0_u02BF_u02C1_u02B3_u02B7_u02BB_u02B4_u02B2_u02B;
	}

	// Token: 0x060011FE RID: 4606 RVA: 0x0000F6BE File Offset: 0x0000D8BE
	private static GameIconInfoContainer \u02B3\u02BB\u02BB\u02B2\u02BD\u02BC\u02BE\u02B3\u02C1\u02BC\u02BD(string \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD)
	{
		return JsonUtility.FromJson<GameIconInfoContainer>("{\"icons\":" + \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD + "}");
	}

	// Token: 0x060011FF RID: 4607 RVA: 0x0000F6AF File Offset: 0x0000D8AF
	public static IEnumerator \u02B4\u02B7\u02C0\u02BB\u02C0\u02C0\u02C1\u02B6\u02BA\u02B2\u02B7(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		RemoteIconAndSourceUpdater.\u02B9\u02B8\u02C0\u02BF\u02C1\u02B3\u02B7\u02BB\u02B4\u02B2\u02B7 u02B9_u02B8_u02C0_u02BF_u02C1_u02B3_u02B7_u02BB_u02B4_u02B2_u02B = new RemoteIconAndSourceUpdater.\u02B9\u02B8\u02C0\u02BF\u02C1\u02B3\u02B7\u02BB\u02B4\u02B2\u02B7(1);
		u02B9_u02B8_u02C0_u02BF_u02C1_u02B3_u02B7_u02BB_u02B4_u02B2_u02B.path = \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC;
		return u02B9_u02B8_u02C0_u02BF_u02C1_u02B3_u02B7_u02BB_u02B4_u02B2_u02B;
	}

	// Token: 0x06001200 RID: 4608 RVA: 0x0000F6D5 File Offset: 0x0000D8D5
	private static GameIconInfoContainer \u02B4\u02B9\u02B2\u02C1\u02C0\u02B5\u02BD\u02C1\u02B5\u02BB\u02B3(string \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD)
	{
		return JsonUtility.FromJson<GameIconInfoContainer>("Display Name" + \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD + "Song");
	}

	// Token: 0x06001201 RID: 4609 RVA: 0x0000F6EC File Offset: 0x0000D8EC
	public IEnumerator \u02BD\u02BD\u02B7\u02BC\u02C0\u02B8\u02BF\u02B8\u02C1\u02B4\u02BC()
	{
		RemoteIconAndSourceUpdater.\u02BA\u02BE\u02BB\u02B7\u02B3\u02C0\u02BE\u02BD\u02BC\u02BF\u02B3 u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B = new RemoteIconAndSourceUpdater.\u02BA\u02BE\u02BB\u02B7\u02B3\u02C0\u02BE\u02BD\u02BC\u02BF\u02B3();
		string updateCachePath = Path.Combine(Application.persistentDataPath, "icons.json");
		u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.iconCachePath = Path.Combine(Application.persistentDataPath, "iconCache");
		if (!Directory.Exists(u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.iconCachePath))
		{
			Directory.CreateDirectory(u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.iconCachePath);
		}
		u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconsInfo = null;
		GameIconInfoContainer localIconsInfo = null;
		u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconJson = "";
		yield return \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BF\u02B4\u02C0\u02B8\u02C1\u02C0\u02B9\u02BC\u02B3\u02BC\u02BF("https://sources.clonehero.net/icons.json", new \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BB\u02B9\u02B7\u02BE\u02BD\u02BE\u02B6\u02BB\u02BB\u02BC\u02BD(u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.\u02BC\u02B4\u02B6\u02B4\u02C1\u02B5\u02B8\u02B4\u02B8\u02C1\u02BD));
		if (File.Exists(updateCachePath))
		{
			try
			{
				localIconsInfo = RemoteIconAndSourceUpdater.\u02B3\u02BB\u02BB\u02B2\u02BD\u02BC\u02BE\u02B3\u02C1\u02BC\u02BD(File.ReadAllText(updateCachePath));
			}
			catch
			{
				Debug.LogError("Unable to read from local icon cache.");
			}
		}
		if (localIconsInfo == null)
		{
			localIconsInfo = RemoteIconAndSourceUpdater.\u02B3\u02BB\u02BB\u02B2\u02BD\u02BC\u02BE\u02B3\u02C1\u02BC\u02BD(Resources.Load<TextAsset>("icons").text);
		}
		if (u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconsInfo != null && localIconsInfo != null)
		{
			GameIconInfo[] array = u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconsInfo.icons;
			for (int i = 0; i < array.Length; i++)
			{
				RemoteIconAndSourceUpdater.\u02B5\u02B2\u02B8\u02C0\u02B6\u02BA\u02BA\u02C1\u02BC\u02B2\u02B7 u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B = new RemoteIconAndSourceUpdater.\u02B5\u02B2\u02B8\u02C0\u02B6\u02BA\u02BA\u02C1\u02BC\u02B2\u02B7();
				u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.CS$<>8__locals1 = u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B;
				u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon = array[i];
				bool flag = false;
				GameIconInfo[] icons = localIconsInfo.icons;
				int j = 0;
				while (j < icons.Length)
				{
					GameIconInfo gameIconInfo = icons[j];
					if (string.Equals(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.name, gameIconInfo.name, StringComparison.OrdinalIgnoreCase))
					{
						if (!string.Equals(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.sha1, gameIconInfo.sha1, StringComparison.OrdinalIgnoreCase))
						{
							flag = true;
							break;
						}
						break;
					}
					else
					{
						j++;
					}
				}
				if (!flag && Resources.Load<Texture2D>("Game Icons/" + Path.GetFileNameWithoutExtension(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.name)) == null && !File.Exists(Path.Combine(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.CS$<>8__locals1.iconCachePath, u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.name)))
				{
					flag = true;
				}
				if (flag)
				{
					while (\u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02B3\u02B3\u02C1\u02B4\u02B8\u02BA\u02B3\u02B4\u02B9\u02B2\u02B6 > 15)
					{
						yield return null;
					}
					base.StartCoroutine(\u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BF\u02B4\u02C0\u02B8\u02C1\u02C0\u02B9\u02BC\u02B3\u02BC\u02BF("https://sources.clonehero.net/icons/" + u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.name, new \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02B2\u02BF\u02B7\u02B7\u02BC\u02B2\u02B7\u02BB\u02BC\u02B3\u02B3(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.\u02BF\u02B7\u02BD\u02B5\u02B2\u02C0\u02B6\u02B2\u02BB\u02B4\u02B9)));
				}
				u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B = null;
			}
			array = null;
			File.WriteAllText(updateCachePath, u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconJson);
		}
		yield break;
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x0000F6FB File Offset: 0x0000D8FB
	public void \u02B6\u02B2\u02B2\u02BF\u02BD\u02B9\u02BD\u02BD\u02B2\u02B2\u02B2(bool \u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD)
	{
		base.StartCoroutine(this.\u02C0\u02B6\u02B9\u02B8\u02BE\u02BA\u02BD\u02B8\u02B2\u02BD\u02BC(\u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD));
	}

	// Token: 0x06001203 RID: 4611 RVA: 0x0000F6FB File Offset: 0x0000D8FB
	public void \u02B3\u02B2\u02BB\u02BF\u02C1\u02B7\u02B7\u02BC\u02C0\u02B3\u02BB(bool \u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD)
	{
		base.StartCoroutine(this.\u02C0\u02B6\u02B9\u02B8\u02BE\u02BA\u02BD\u02B8\u02B2\u02BD\u02BC(\u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD));
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x0000F70B File Offset: 0x0000D90B
	public static IEnumerator \u02B3\u02BF\u02BE\u02B5\u02B6\u02B2\u02B4\u02BC\u02BC\u02C1\u02B8(RemoteIconAndSourceUpdater.\u02B3\u02B6\u02B4\u02B3\u02B6\u02B9\u02BB\u02B4\u02B2\u02B4\u02BE \u02C1\u02BE\u02B3\u02B5\u02B4\u02B5\u02B4\u02BB\u02C0\u02B4\u02B3)
	{
		RemoteIconAndSourceUpdater.\u02C1\u02B6\u02B3\u02B7\u02BA\u02BF\u02B6\u02BE\u02B9\u02B6\u02B9 u02C1_u02B6_u02B3_u02B7_u02BA_u02BF_u02B6_u02BE_u02B9_u02B6_u02B = new RemoteIconAndSourceUpdater.\u02C1\u02B6\u02B3\u02B7\u02BA\u02BF\u02B6\u02BE\u02B9\u02B6\u02B9();
		u02C1_u02B6_u02B3_u02B7_u02BA_u02BF_u02B6_u02BE_u02B9_u02B6_u02B.Callback = \u02C1\u02BE\u02B3\u02B5\u02B4\u02B5\u02B4\u02BB\u02C0\u02B4\u02B3;
		yield return \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BF\u02B4\u02C0\u02B8\u02C1\u02C0\u02B9\u02BC\u02B3\u02BC\u02BF("https://online.clonehero.net/servers", new \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BB\u02B9\u02B7\u02BE\u02BD\u02BE\u02B6\u02BB\u02BB\u02BC\u02BD(u02C1_u02B6_u02B3_u02B7_u02BA_u02BF_u02B6_u02BE_u02B9_u02B6_u02B.\u02BA\u02C1\u02B8\u02C1\u02BC\u02C0\u02B6\u02BC\u02C0\u02B9\u02BD));
		yield break;
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x0000F664 File Offset: 0x0000D864
	public IEnumerator \u02BD\u02BF\u02B8\u02C1\u02B4\u02C1\u02BE\u02B7\u02B3\u02C1\u02BE(bool \u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD)
	{
		this.\u02B2\u02BA\u02BB\u02BC\u02BF\u02BD\u02B5\u02C0\u02B5\u02C0\u02B6.SetActive(\u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD);
		this.\u02BE\u02B3\u02BC\u02BD\u02C1\u02B4\u02BC\u02BC\u02C1\u02C0\u02BE = true;
		if (this.\u02BE\u02B3\u02BC\u02BD\u02C1\u02B4\u02BC\u02BC\u02C1\u02C0\u02BE)
		{
			this.progressBody.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Please Wait.");
			this.progressTitle.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("UPDATING ICONS...");
			yield return this.\u02B5\u02BF\u02C0\u02BE\u02BE\u02BD\u02B9\u02B7\u02BA\u02BC\u02B3();
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B4\u02BB\u02C0\u02B5\u02B6\u02B6\u02B9\u02B9\u02B3\u02C0(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8);
			this.progressTitle.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("UPDATING SERVER LIST...");
			yield return RemoteIconAndSourceUpdater.\u02B3\u02BF\u02BE\u02B5\u02B6\u02B2\u02B4\u02BC\u02BC\u02C1\u02B8(new RemoteIconAndSourceUpdater.\u02B3\u02B6\u02B4\u02B3\u02B6\u02B9\u02BB\u02B4\u02B2\u02B4\u02BE(RemoteIconAndSourceUpdater.<>c.<>9.\u02BB\u02C1\u02C1\u02C0\u02B2\u02BE\u02C0\u02B2\u02BE\u02B2\u02BE));
			this.progressTitle.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("UPDATING SOURCES...");
			yield return RemoteIconAndSourceUpdater.\u02C1\u02C0\u02B8\u02B4\u02BE\u02B2\u02BD\u02B9\u02B7\u02B7\u02B2(Application.persistentDataPath);
		}
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B7\u02BB\u02B8\u02B6\u02B8\u02BA\u02B9\u02BF\u02B8\u02B3 = true;
		this.\u02B2\u02BA\u02BB\u02BC\u02BF\u02BD\u02B5\u02C0\u02B5\u02C0\u02B6.SetActive(false);
		yield break;
	}

	// Token: 0x06001206 RID: 4614 RVA: 0x0000F6EC File Offset: 0x0000D8EC
	public IEnumerator \u02B7\u02BA\u02B2\u02B5\u02BB\u02B3\u02BE\u02BF\u02B8\u02BD\u02BE()
	{
		u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B = new RemoteIconAndSourceUpdater.\u02BA\u02BE\u02BB\u02B7\u02B3\u02C0\u02BE\u02BD\u02BC\u02BF\u02B3();
		updateCachePath = Path.Combine(Application.persistentDataPath, "icons.json");
		u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.iconCachePath = Path.Combine(Application.persistentDataPath, "iconCache");
		if (!Directory.Exists(u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.iconCachePath))
		{
			Directory.CreateDirectory(u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.iconCachePath);
		}
		u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconsInfo = null;
		localIconsInfo = null;
		u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconJson = "";
		yield return \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BF\u02B4\u02C0\u02B8\u02C1\u02C0\u02B9\u02BC\u02B3\u02BC\u02BF("https://sources.clonehero.net/icons.json", new \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BB\u02B9\u02B7\u02BE\u02BD\u02BE\u02B6\u02BB\u02BB\u02BC\u02BD(u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.\u02BC\u02B4\u02B6\u02B4\u02C1\u02B5\u02B8\u02B4\u02B8\u02C1\u02BD));
		if (File.Exists(updateCachePath))
		{
			try
			{
				localIconsInfo = RemoteIconAndSourceUpdater.\u02B3\u02BB\u02BB\u02B2\u02BD\u02BC\u02BE\u02B3\u02C1\u02BC\u02BD(File.ReadAllText(updateCachePath));
			}
			catch
			{
				Debug.LogError("Unable to read from local icon cache.");
			}
		}
		if (localIconsInfo == null)
		{
			localIconsInfo = RemoteIconAndSourceUpdater.\u02B3\u02BB\u02BB\u02B2\u02BD\u02BC\u02BE\u02B3\u02C1\u02BC\u02BD(Resources.Load<TextAsset>("icons").text);
		}
		if (u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconsInfo != null && localIconsInfo != null)
		{
			array = u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconsInfo.icons;
			for (i = 0; i < array.Length; i++)
			{
				u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B = new RemoteIconAndSourceUpdater.\u02B5\u02B2\u02B8\u02C0\u02B6\u02BA\u02BA\u02C1\u02BC\u02B2\u02B7();
				u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.CS$<>8__locals1 = u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B;
				u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon = array[i];
				bool flag = false;
				GameIconInfo[] icons = localIconsInfo.icons;
				int j = 0;
				while (j < icons.Length)
				{
					GameIconInfo gameIconInfo = icons[j];
					if (string.Equals(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.name, gameIconInfo.name, StringComparison.OrdinalIgnoreCase))
					{
						if (!string.Equals(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.sha1, gameIconInfo.sha1, StringComparison.OrdinalIgnoreCase))
						{
							flag = true;
							break;
						}
						break;
					}
					else
					{
						j++;
					}
				}
				if (!flag && Resources.Load<Texture2D>("Game Icons/" + Path.GetFileNameWithoutExtension(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.name)) == null && !File.Exists(Path.Combine(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.CS$<>8__locals1.iconCachePath, u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.name)))
				{
					flag = true;
				}
				if (flag)
				{
					while (\u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02B3\u02B3\u02C1\u02B4\u02B8\u02BA\u02B3\u02B4\u02B9\u02B2\u02B6 > 15)
					{
						yield return null;
					}
					base.StartCoroutine(\u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BF\u02B4\u02C0\u02B8\u02C1\u02C0\u02B9\u02BC\u02B3\u02BC\u02BF("https://sources.clonehero.net/icons/" + u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.name, new \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02B2\u02BF\u02B7\u02B7\u02BC\u02B2\u02B7\u02BB\u02BC\u02B3\u02B3(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.\u02BF\u02B7\u02BD\u02B5\u02B2\u02C0\u02B6\u02B2\u02BB\u02B4\u02B9)));
				}
				u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B = null;
			}
			array = null;
			File.WriteAllText(updateCachePath, u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconJson);
		}
		yield break;
	}

	// Token: 0x06001207 RID: 4615 RVA: 0x0000F71A File Offset: 0x0000D91A
	private static GameIconInfoContainer \u02B5\u02BA\u02B6\u02BC\u02BF\u02BA\u02BE\u02B7\u02BD\u02BC\u02C1(string \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD)
	{
		return JsonUtility.FromJson<GameIconInfoContainer>("SETLIST LENGTH" + \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD + "Guitar");
	}

	// Token: 0x06001208 RID: 4616 RVA: 0x0000F6EC File Offset: 0x0000D8EC
	public IEnumerator \u02B5\u02BF\u02C0\u02BE\u02BE\u02BD\u02B9\u02B7\u02BA\u02BC\u02B3()
	{
		u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B = new RemoteIconAndSourceUpdater.\u02BA\u02BE\u02BB\u02B7\u02B3\u02C0\u02BE\u02BD\u02BC\u02BF\u02B3();
		updateCachePath = Path.Combine(Application.persistentDataPath, "icons.json");
		u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.iconCachePath = Path.Combine(Application.persistentDataPath, "iconCache");
		if (!Directory.Exists(u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.iconCachePath))
		{
			Directory.CreateDirectory(u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.iconCachePath);
		}
		u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconsInfo = null;
		localIconsInfo = null;
		u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconJson = "";
		yield return \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BF\u02B4\u02C0\u02B8\u02C1\u02C0\u02B9\u02BC\u02B3\u02BC\u02BF("https://sources.clonehero.net/icons.json", new \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BB\u02B9\u02B7\u02BE\u02BD\u02BE\u02B6\u02BB\u02BB\u02BC\u02BD(u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.\u02BC\u02B4\u02B6\u02B4\u02C1\u02B5\u02B8\u02B4\u02B8\u02C1\u02BD));
		if (File.Exists(updateCachePath))
		{
			try
			{
				localIconsInfo = RemoteIconAndSourceUpdater.\u02B3\u02BB\u02BB\u02B2\u02BD\u02BC\u02BE\u02B3\u02C1\u02BC\u02BD(File.ReadAllText(updateCachePath));
			}
			catch
			{
				Debug.LogError("Unable to read from local icon cache.");
			}
		}
		if (localIconsInfo == null)
		{
			localIconsInfo = RemoteIconAndSourceUpdater.\u02B3\u02BB\u02BB\u02B2\u02BD\u02BC\u02BE\u02B3\u02C1\u02BC\u02BD(Resources.Load<TextAsset>("icons").text);
		}
		if (u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconsInfo != null && localIconsInfo != null)
		{
			array = u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconsInfo.icons;
			for (i = 0; i < array.Length; i++)
			{
				u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B = new RemoteIconAndSourceUpdater.\u02B5\u02B2\u02B8\u02C0\u02B6\u02BA\u02BA\u02C1\u02BC\u02B2\u02B7();
				u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.CS$<>8__locals1 = u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B;
				u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon = array[i];
				bool flag = false;
				GameIconInfo[] icons = localIconsInfo.icons;
				int j = 0;
				while (j < icons.Length)
				{
					GameIconInfo gameIconInfo = icons[j];
					if (string.Equals(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.name, gameIconInfo.name, StringComparison.OrdinalIgnoreCase))
					{
						if (!string.Equals(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.sha1, gameIconInfo.sha1, StringComparison.OrdinalIgnoreCase))
						{
							flag = true;
							break;
						}
						break;
					}
					else
					{
						j++;
					}
				}
				if (!flag && Resources.Load<Texture2D>("Game Icons/" + Path.GetFileNameWithoutExtension(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.name)) == null && !File.Exists(Path.Combine(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.CS$<>8__locals1.iconCachePath, u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.name)))
				{
					flag = true;
				}
				if (flag)
				{
					while (\u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02B3\u02B3\u02C1\u02B4\u02B8\u02BA\u02B3\u02B4\u02B9\u02B2\u02B6 > 15)
					{
						yield return null;
					}
					base.StartCoroutine(\u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BF\u02B4\u02C0\u02B8\u02C1\u02C0\u02B9\u02BC\u02B3\u02BC\u02BF("https://sources.clonehero.net/icons/" + u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.gameIcon.name, new \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02B2\u02BF\u02B7\u02B7\u02BC\u02B2\u02B7\u02BB\u02BC\u02B3\u02B3(u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B.\u02BF\u02B7\u02BD\u02B5\u02B2\u02C0\u02B6\u02B2\u02BB\u02B4\u02B9)));
				}
				u02B5_u02B2_u02B8_u02C0_u02B6_u02BA_u02BA_u02C1_u02BC_u02B2_u02B = null;
			}
			array = null;
			File.WriteAllText(updateCachePath, u02BA_u02BE_u02BB_u02B7_u02B3_u02C0_u02BE_u02BD_u02BC_u02BF_u02B.remoteIconJson);
		}
		yield break;
	}

	// Token: 0x06001209 RID: 4617 RVA: 0x0000F6AF File Offset: 0x0000D8AF
	public static IEnumerator \u02B6\u02BC\u02B3\u02B7\u02B4\u02B2\u02BB\u02B9\u02BD\u02B5\u02C1(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		RemoteIconAndSourceUpdater.\u02B9\u02B8\u02C0\u02BF\u02C1\u02B3\u02B7\u02BB\u02B4\u02B2\u02B7 u02B9_u02B8_u02C0_u02BF_u02C1_u02B3_u02B7_u02BB_u02B4_u02B2_u02B = new RemoteIconAndSourceUpdater.\u02B9\u02B8\u02C0\u02BF\u02C1\u02B3\u02B7\u02BB\u02B4\u02B2\u02B7(1);
		u02B9_u02B8_u02C0_u02BF_u02C1_u02B3_u02B7_u02BB_u02B4_u02B2_u02B.path = \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC;
		return u02B9_u02B8_u02C0_u02BF_u02C1_u02B3_u02B7_u02BB_u02B4_u02B2_u02B;
	}

	// Token: 0x0600120A RID: 4618 RVA: 0x0000F70B File Offset: 0x0000D90B
	public static IEnumerator \u02B8\u02B4\u02BA\u02BD\u02B9\u02B8\u02BC\u02B9\u02BF\u02B2\u02BE(RemoteIconAndSourceUpdater.\u02B3\u02B6\u02B4\u02B3\u02B6\u02B9\u02BB\u02B4\u02B2\u02B4\u02BE \u02C1\u02BE\u02B3\u02B5\u02B4\u02B5\u02B4\u02BB\u02C0\u02B4\u02B3)
	{
		RemoteIconAndSourceUpdater.\u02C1\u02B6\u02B3\u02B7\u02BA\u02BF\u02B6\u02BE\u02B9\u02B6\u02B9 u02C1_u02B6_u02B3_u02B7_u02BA_u02BF_u02B6_u02BE_u02B9_u02B6_u02B = new RemoteIconAndSourceUpdater.\u02C1\u02B6\u02B3\u02B7\u02BA\u02BF\u02B6\u02BE\u02B9\u02B6\u02B9();
		u02C1_u02B6_u02B3_u02B7_u02BA_u02BF_u02B6_u02BE_u02B9_u02B6_u02B.Callback = \u02C1\u02BE\u02B3\u02B5\u02B4\u02B5\u02B4\u02BB\u02C0\u02B4\u02B3;
		yield return \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BF\u02B4\u02C0\u02B8\u02C1\u02C0\u02B9\u02BC\u02B3\u02BC\u02BF("https://online.clonehero.net/servers", new \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BB\u02B9\u02B7\u02BE\u02BD\u02BE\u02B6\u02BB\u02BB\u02BC\u02BD(u02C1_u02B6_u02B3_u02B7_u02BA_u02BF_u02B6_u02BE_u02B9_u02B6_u02B.\u02BA\u02C1\u02B8\u02C1\u02BC\u02C0\u02B6\u02BC\u02C0\u02B9\u02BD));
		yield break;
	}

	// Token: 0x0600120B RID: 4619 RVA: 0x0000F731 File Offset: 0x0000D931
	public IEnumerator \u02B5\u02BB\u02BC\u02BE\u02B3\u02BF\u02B5\u02B6\u02B4\u02BD\u02C0(bool \u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD)
	{
		RemoteIconAndSourceUpdater.\u02B5\u02B7\u02B2\u02B3\u02B3\u02B3\u02BA\u02B4\u02BD\u02BF\u02BE u02B5_u02B7_u02B2_u02B3_u02B3_u02B3_u02BA_u02B4_u02BD_u02BF_u02BE = new RemoteIconAndSourceUpdater.\u02B5\u02B7\u02B2\u02B3\u02B3\u02B3\u02BA\u02B4\u02BD\u02BF\u02BE(1);
		u02B5_u02B7_u02B2_u02B3_u02B3_u02B3_u02BA_u02B4_u02BD_u02BF_u02BE.<>4__this = this;
		u02B5_u02B7_u02B2_u02B3_u02B3_u02B3_u02BA_u02B4_u02BD_u02BF_u02BE.showPopup = \u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD;
		return u02B5_u02B7_u02B2_u02B3_u02B3_u02B3_u02BA_u02B4_u02BD_u02BF_u02BE;
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x0000F747 File Offset: 0x0000D947
	private static GameIconInfoContainer \u02B9\u02B9\u02C1\u02C0\u02BF\u02B2\u02BE\u02B3\u02B9\u02BE\u02BC(string \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD)
	{
		return JsonUtility.FromJson<GameIconInfoContainer>("Menu Music" + \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD + "{0}");
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x0000F75E File Offset: 0x0000D95E
	private static GameIconInfoContainer \u02B7\u02B4\u02B6\u02B6\u02BC\u02B7\u02B3\u02C0\u02BF\u02B6\u02BB(string \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD)
	{
		return JsonUtility.FromJson<GameIconInfoContainer>("Songs" + \u02B5\u02BD\u02B3\u02BE\u02BC\u02B6\u02B9\u02B8\u02BC\u02B4\u02BD + "CalTest");
	}

	// Token: 0x04000D96 RID: 3478
	public const string \u02B4\u02B3\u02BF\u02B8\u02B9\u02BA\u02B9\u02BF\u02B7\u02BE\u02B3 = "https://sources.clonehero.net/icons.json";

	// Token: 0x04000D97 RID: 3479
	public const string \u02BF\u02BA\u02C0\u02B8\u02B8\u02BC\u02C1\u02BE\u02B6\u02BE\u02C0 = "https://sources.clonehero.net/sources.txt";

	// Token: 0x04000D98 RID: 3480
	public const string \u02B7\u02BB\u02BA\u02C1\u02B9\u02BA\u02B9\u02BC\u02B9\u02B6\u02B9 = "https://sources.clonehero.net/icons/";

	// Token: 0x04000D99 RID: 3481
	public const string \u02B7\u02BE\u02B3\u02C0\u02BE\u02BD\u02B7\u02B2\u02B7\u02BB\u02B7 = "https://online.clonehero.net/servers";

	// Token: 0x04000D9A RID: 3482
	public GameObject \u02B2\u02BA\u02BB\u02BC\u02BF\u02BD\u02B5\u02C0\u02B5\u02C0\u02B6;

	// Token: 0x04000D9B RID: 3483
	[SerializeField]
	private Text progressTitle;

	// Token: 0x04000D9C RID: 3484
	[SerializeField]
	private Text progressBody;

	// Token: 0x04000D9D RID: 3485
	private bool \u02BE\u02B3\u02BC\u02BD\u02C1\u02B4\u02BC\u02BC\u02C1\u02C0\u02BE;

	// Token: 0x02000187 RID: 391
	[Serializable]
	public class ServerList
	{
		// Token: 0x04000D9E RID: 3486
		public string[] servers;
	}

	// Token: 0x02000188 RID: 392
	// (Invoke) Token: 0x06001210 RID: 4624
	public delegate void \u02B3\u02B6\u02B4\u02B3\u02B6\u02B9\u02BB\u02B4\u02B2\u02B4\u02BE(string[] \u02B2\u02B8\u02B8\u02B6\u02BA\u02B2\u02B7\u02B5\u02C0\u02C0\u02B2);

	// Token: 0x0200018B RID: 395
	[CompilerGenerated]
	private sealed class \u02BA\u02BE\u02BB\u02B7\u02B3\u02C0\u02BE\u02BD\u02BC\u02BF\u02B3
	{
		// Token: 0x0600121B RID: 4635 RVA: 0x0000F7A5 File Offset: 0x0000D9A5
		internal void \u02BC\u02B4\u02B6\u02B4\u02C1\u02B5\u02B8\u02B4\u02B8\u02C1\u02BD(string text)
		{
			this.remoteIconJson = text;
			this.remoteIconsInfo = RemoteIconAndSourceUpdater.\u02B3\u02BB\u02BB\u02B2\u02BD\u02BC\u02BE\u02B3\u02C1\u02BC\u02BD(this.remoteIconJson);
		}

		// Token: 0x04000DA5 RID: 3493
		public string remoteIconJson;

		// Token: 0x04000DA6 RID: 3494
		public GameIconInfoContainer remoteIconsInfo;

		// Token: 0x04000DA7 RID: 3495
		public string iconCachePath;
	}

	// Token: 0x0200018C RID: 396
	[CompilerGenerated]
	private sealed class \u02B5\u02B2\u02B8\u02C0\u02B6\u02BA\u02BA\u02C1\u02BC\u02B2\u02B7
	{
		// Token: 0x0600121D RID: 4637 RVA: 0x0000F7BF File Offset: 0x0000D9BF
		internal void \u02BF\u02B7\u02BD\u02B5\u02B2\u02C0\u02B6\u02B2\u02BB\u02B4\u02B9(byte[] data)
		{
			File.WriteAllBytes(Path.Combine(this.CS$<>8__locals1.iconCachePath, this.gameIcon.name), data);
		}

		// Token: 0x04000DA8 RID: 3496
		public GameIconInfo gameIcon;

		// Token: 0x04000DA9 RID: 3497
		public RemoteIconAndSourceUpdater.\u02BA\u02BE\u02BB\u02B7\u02B3\u02C0\u02BE\u02BD\u02BC\u02BF\u02B3 CS$<>8__locals1;
	}

	// Token: 0x0200018E RID: 398
	[CompilerGenerated]
	private sealed class \u02C1\u02B6\u02B3\u02B7\u02BA\u02BF\u02B6\u02BE\u02B9\u02B6\u02B9
	{
		// Token: 0x06001225 RID: 4645 RVA: 0x0000F7F9 File Offset: 0x0000D9F9
		internal void \u02BA\u02C1\u02B8\u02C1\u02BC\u02C0\u02B6\u02BC\u02C0\u02B9\u02BD(string text)
		{
			this.Callback(JsonUtility.FromJson<RemoteIconAndSourceUpdater.ServerList>(text).servers);
		}

		// Token: 0x04000DB3 RID: 3507
		public RemoteIconAndSourceUpdater.\u02B3\u02B6\u02B4\u02B3\u02B6\u02B9\u02BB\u02B4\u02B2\u02B4\u02BE Callback;
	}

	// Token: 0x02000190 RID: 400
	[CompilerGenerated]
	private sealed class \u02BC\u02BF\u02BC\u02BC\u02BD\u02B9\u02BC\u02BA\u02BF\u02B3\u02B7
	{
		// Token: 0x0600122D RID: 4653 RVA: 0x0000F828 File Offset: 0x0000DA28
		internal void \u02B8\u02B3\u02BA\u02B6\u02B4\u02BD\u02B5\u02B2\u02BC\u02B6\u02B3(string text)
		{
			File.WriteAllText(this.sourcesCachePath, text);
		}

		// Token: 0x04000DB7 RID: 3511
		public string sourcesCachePath;
	}
}
