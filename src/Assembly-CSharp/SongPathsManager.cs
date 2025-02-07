﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SongPathsManager : MonoBehaviour
{
	private void \u02B5\u02B8\u02BF\u02BB\u02B7\u02B4\u02BB\u02B4\u02B4\u02BD\u02BF()
	{
		this.\u02B7\u02BC\u02B5\u02BE\u02B8\u02C0\u02C0\u02BF\u02BB\u02B5\u02BF();
	}

	private void \u02BB\u02BD\u02B8\u02B6\u02B3\u02BA\u02B4\u02BB\u02BC\u02B2\u02B3()
	{
		this.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(true);
	}

	public static bool \u02B3\u02B8\u02BF\u02B8\u02BB\u02B4\u02B6\u02B6\u02B4\u02B5\u02BD()
	{
		return SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 == null || SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA == null || SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.activeInHierarchy;
	}

	[CompilerGenerated]
	private void \u02BC\u02B2\u02B8\u02BD\u02BD\u02B7\u02B7\u02B6\u02BE\u02B4\u02BA()
	{
		this.\u02B8\u02B7\u02B4\u02B8\u02BF\u02C0\u02C1\u02BE\u02BF\u02C0\u02BB();
	}

	private void \u02C0\u02B5\u02C0\u02C1\u02B8\u02B8\u02B3\u02BE\u02BB\u02C1\u02BE()
	{
		this.\u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8.SetActive(true);
		foreach (object obj in this.\u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB)
		{
			global::UnityEngine.Object.Destroy(((Transform)obj).gameObject);
		}
		for (int i = 0; i < GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9.Count; i++)
		{
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8, this.\u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB);
			gameObject.GetComponentInChildren<TextMeshProUGUI>().text = ((i > 0) ? GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9[i] : (LanguageManager.instance.GetString("Default") + " (" + GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9[i] + ")"));
			Button componentInChildren = gameObject.GetComponentInChildren<Button>();
			if (!(componentInChildren == null))
			{
				if (i > 0)
				{
					SongPathsManager.\u02BE\u02BD\u02B4\u02BB\u02C0\u02BE\u02B3\u02C0\u02B4\u02BF\u02B7 u02BE_u02BD_u02B4_u02BB_u02C0_u02BE_u02B3_u02C0_u02B4_u02BF_u02B = new SongPathsManager.\u02BE\u02BD\u02B4\u02BB\u02C0\u02BE\u02B3\u02C0\u02B4\u02BF\u02B7();
					u02BE_u02BD_u02B4_u02BB_u02C0_u02BE_u02B3_u02C0_u02B4_u02BF_u02B.<>4__this = this;
					u02BE_u02BD_u02B4_u02BB_u02C0_u02BE_u02B3_u02C0_u02B4_u02BF_u02B.delIndex = i - 1;
					componentInChildren.onClick.AddListener(new UnityAction(u02BE_u02BD_u02B4_u02BB_u02C0_u02BE_u02B3_u02C0_u02B4_u02BF_u02B.\u02B8\u02B2\u02BD\u02B9\u02BE\u02B7\u02BA\u02C1\u02C1\u02BD\u02B5));
				}
				else
				{
					componentInChildren.gameObject.SetActive(false);
				}
			}
		}
		this.\u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8.SetActive(false);
	}

	private void \u02B8\u02B7\u02B4\u02B8\u02BF\u02C0\u02C1\u02BE\u02BF\u02C0\u02BB()
	{
		\u02C0\u02BD\u02B9\u02B8\u02B6\u02BB\u02B7\u02B8\u02B7\u02B4\u02B4 u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B = new \u02B9\u02BE\u02B6\u02B2\u02BC\u02BC\u02B2\u02C0\u02B8\u02B4\u02BA();
		if (u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B == null)
		{
			return;
		}
		string text = u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B.\u02B3\u02BF\u02B9\u02BC\u02B5\u02BB\u02BD\u02BB\u02B6\u02B2\u02B6(LanguageManager.instance.GetString("Select the songs folder you would like to add."));
		if (string.IsNullOrEmpty(text) || !Directory.Exists(text))
		{
			return;
		}
		if (SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.Count == 1 && string.IsNullOrEmpty(SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.CurrentValue[0]))
		{
			SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.CurrentValue[0] = text;
		}
		else
		{
			SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.AddValue(text);
		}
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(true);
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB();
		this.\u02C0\u02B5\u02C0\u02C1\u02B8\u02B8\u02B3\u02BE\u02BB\u02C1\u02BE();
	}

	private void OnEnable()
	{
		SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 = this;
	}

	public static bool \u02BF\u02B3\u02B6\u02B5\u02BB\u02B7\u02BE\u02BF\u02C1\u02BA\u02BF()
	{
		return !(SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 == null) && !(SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA == null) && SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.activeInHierarchy;
	}

	public static void \u02BE\u02B3\u02B7\u02BD\u02BA\u02BB\u02B4\u02B7\u02B5\u02B3\u02B2()
	{
		SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B8\u02C1\u02BC\u02B5\u02BB\u02B8\u02BD\u02C0\u02B7\u02B2\u02C1();
		Cursor.visible = true;
	}

	public static void \u02C1\u02B5\u02C0\u02B4\u02BD\u02BD\u02BD\u02BD\u02C1\u02BE\u02B2()
	{
		SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B8\u02C1\u02BC\u02B5\u02BB\u02B8\u02BD\u02C0\u02B7\u02B2\u02C1();
		Cursor.visible = false;
	}

	private void \u02BB\u02BC\u02B9\u02B3\u02B6\u02BE\u02C1\u02BE\u02B3\u02BB\u02B6(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
	{
		Debug.Log(\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5);
		List<string> list = SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.CurrentValue.ToList<string>();
		if (\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 == 0)
		{
			list[0] = null;
		}
		else
		{
			list.RemoveAt(\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5);
		}
		SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.CurrentValue = list.ToArray();
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(true);
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB();
		this.\u02C0\u02B5\u02C0\u02C1\u02B8\u02B8\u02B3\u02BE\u02BB\u02C1\u02BE();
	}

	private void OnDisable()
	{
		SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 = null;
	}

	private void \u02B8\u02B2\u02BB\u02BF\u02BF\u02BF\u02C0\u02BE\u02BD\u02B9\u02B8()
	{
		SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 = this;
	}

	[CompilerGenerated]
	private void \u02B7\u02BA\u02BF\u02B6\u02BB\u02B4\u02BB\u02B6\u02BE\u02BF\u02BE()
	{
		this.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(false);
	}

	private void \u02B7\u02BC\u02B5\u02BE\u02B8\u02C0\u02C0\u02BF\u02BB\u02B5\u02BF()
	{
		\u02C0\u02BD\u02B9\u02B8\u02B6\u02BB\u02B7\u02B8\u02B7\u02B4\u02B4 u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B = new \u02B9\u02BE\u02B6\u02B2\u02BC\u02BC\u02B2\u02C0\u02B8\u02B4\u02BA();
		if (u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B == null)
		{
			return;
		}
		string text = u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B.\u02B3\u02BF\u02B9\u02BC\u02B5\u02BB\u02BD\u02BB\u02B6\u02B2\u02B6(LanguageManager.instance.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(".png|.jpg|.jpeg"));
		if (string.IsNullOrEmpty(text) || !Directory.Exists(text))
		{
			return;
		}
		if (SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.Count == 0 && string.IsNullOrEmpty(SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.CurrentValue[1]))
		{
			SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.CurrentValue[1] = text;
		}
		else
		{
			SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.AddValue(text);
		}
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB();
		this.\u02C0\u02B5\u02C0\u02C1\u02B8\u02B8\u02B3\u02BE\u02BB\u02C1\u02BE();
	}

	private void \u02C1\u02C1\u02B2\u02BD\u02BC\u02BA\u02BF\u02BD\u02B3\u02B4\u02B2()
	{
		\u02C0\u02BD\u02B9\u02B8\u02B6\u02BB\u02B7\u02B8\u02B7\u02B4\u02B4 u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B = new \u02B9\u02BE\u02B6\u02B2\u02BC\u02BC\u02B2\u02C0\u02B8\u02B4\u02BA();
		if (u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B == null)
		{
			return;
		}
		string text = u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B.\u02B3\u02BF\u02B9\u02BC\u02B5\u02BB\u02BD\u02BB\u02B6\u02B2\u02B6(LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Measure Based Countdowns"));
		if (string.IsNullOrEmpty(text) || !Directory.Exists(text))
		{
			return;
		}
		if (SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.Count == 1 && string.IsNullOrEmpty(SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.CurrentValue[1]))
		{
			SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.CurrentValue[0] = text;
		}
		else
		{
			SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.AddValue(text);
		}
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB();
		this.\u02C0\u02B5\u02C0\u02C1\u02B8\u02B8\u02B3\u02BE\u02BB\u02C1\u02BE();
	}

	private void \u02B2\u02BF\u02BA\u02BE\u02BA\u02C0\u02B7\u02BD\u02B2\u02B9\u02BD()
	{
		if (!this.\u02B8\u02B2\u02BA\u02B6\u02B9\u02B8\u02BA\u02B7\u02BA\u02BE\u02BB)
		{
			this.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(false);
			Canvas.ForceUpdateCanvases();
			this.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(false);
			this.\u02B8\u02B2\u02BA\u02B6\u02B9\u02B8\u02BA\u02B7\u02BA\u02BE\u02BB = true;
		}
		SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(true);
		this.\u02B8\u02C0\u02B3\u02B2\u02BE\u02C0\u02B2\u02B6\u02BF\u02B5\u02BE.onClick.RemoveAllListeners();
		this.\u02B8\u02C0\u02B3\u02B2\u02BE\u02C0\u02B2\u02B6\u02BF\u02B5\u02BE.onClick.AddListener(new UnityAction(this.\u02BB\u02BD\u02B8\u02B6\u02B3\u02BA\u02B4\u02BB\u02BC\u02B2\u02B3));
		this.\u02B2\u02B7\u02C0\u02B7\u02B2\u02B9\u02BA\u02B8\u02BC\u02B4\u02BD.onClick.RemoveAllListeners();
		this.\u02B2\u02B7\u02C0\u02B7\u02B2\u02B9\u02BA\u02B8\u02BC\u02B4\u02BD.onClick.AddListener(new UnityAction(this.\u02B5\u02B8\u02BF\u02BB\u02B7\u02B4\u02BB\u02B4\u02B4\u02BD\u02BF));
		this.\u02C0\u02B5\u02C0\u02C1\u02B8\u02B8\u02B3\u02BE\u02BB\u02C1\u02BE();
	}

	private void \u02B8\u02C1\u02BC\u02B5\u02BB\u02B8\u02BD\u02C0\u02B7\u02B2\u02C1()
	{
		if (!this.\u02B8\u02B2\u02BA\u02B6\u02B9\u02B8\u02BA\u02B7\u02BA\u02BE\u02BB)
		{
			this.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(true);
			Canvas.ForceUpdateCanvases();
			this.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(false);
			this.\u02B8\u02B2\u02BA\u02B6\u02B9\u02B8\u02BA\u02B7\u02BA\u02BE\u02BB = true;
		}
		SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(true);
		this.\u02B8\u02C0\u02B3\u02B2\u02BE\u02C0\u02B2\u02B6\u02BF\u02B5\u02BE.onClick.RemoveAllListeners();
		this.\u02B8\u02C0\u02B3\u02B2\u02BE\u02C0\u02B2\u02B6\u02BF\u02B5\u02BE.onClick.AddListener(new UnityAction(this.\u02B7\u02BA\u02BF\u02B6\u02BB\u02B4\u02BB\u02B6\u02BE\u02BF\u02BE));
		this.\u02B2\u02B7\u02C0\u02B7\u02B2\u02B9\u02BA\u02B8\u02BC\u02B4\u02BD.onClick.RemoveAllListeners();
		this.\u02B2\u02B7\u02C0\u02B7\u02B2\u02B9\u02BA\u02B8\u02BC\u02B4\u02BD.onClick.AddListener(new UnityAction(this.\u02BC\u02B2\u02B8\u02BD\u02BD\u02B7\u02B7\u02B6\u02BE\u02B4\u02BA));
		this.\u02C0\u02B5\u02C0\u02C1\u02B8\u02B8\u02B3\u02BE\u02BB\u02C1\u02BE();
	}

	private void \u02BA\u02BC\u02BF\u02BC\u02BF\u02B9\u02B8\u02C1\u02B5\u02B2\u02B2()
	{
		if (!this.\u02B8\u02B2\u02BA\u02B6\u02B9\u02B8\u02BA\u02B7\u02BA\u02BE\u02BB)
		{
			this.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(true);
			Canvas.ForceUpdateCanvases();
			this.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(true);
			this.\u02B8\u02B2\u02BA\u02B6\u02B9\u02B8\u02BA\u02B7\u02BA\u02BE\u02BB = true;
		}
		SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(true);
		this.\u02B8\u02C0\u02B3\u02B2\u02BE\u02C0\u02B2\u02B6\u02BF\u02B5\u02BE.onClick.RemoveAllListeners();
		this.\u02B8\u02C0\u02B3\u02B2\u02BE\u02C0\u02B2\u02B6\u02BF\u02B5\u02BE.onClick.AddListener(new UnityAction(this.\u02B7\u02BA\u02BF\u02B6\u02BB\u02B4\u02BB\u02B6\u02BE\u02BF\u02BE));
		this.\u02B2\u02B7\u02C0\u02B7\u02B2\u02B9\u02BA\u02B8\u02BC\u02B4\u02BD.onClick.RemoveAllListeners();
		this.\u02B2\u02B7\u02C0\u02B7\u02B2\u02B9\u02BA\u02B8\u02BC\u02B4\u02BD.onClick.AddListener(new UnityAction(this.\u02B5\u02B8\u02BF\u02BB\u02B7\u02B4\u02BB\u02B4\u02B4\u02BD\u02BF));
		this.\u02C0\u02B5\u02C0\u02C1\u02B8\u02B8\u02B3\u02BE\u02BB\u02C1\u02BE();
	}

	public GameObject \u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8;

	public Button \u02B2\u02B7\u02C0\u02B7\u02B2\u02B9\u02BA\u02B8\u02BC\u02B4\u02BD;

	public Button \u02B8\u02C0\u02B3\u02B2\u02BE\u02C0\u02B2\u02B6\u02BF\u02B5\u02BE;

	public Canvas \u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA;

	public Transform \u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB;

	private static SongPathsManager \u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6;

	private bool \u02B8\u02B2\u02BA\u02B6\u02B9\u02B8\u02BA\u02B7\u02BA\u02BE\u02BB;

	[CompilerGenerated]
	private sealed class \u02BE\u02BD\u02B4\u02BB\u02C0\u02BE\u02B3\u02C0\u02B4\u02BF\u02B7
	{
		internal void \u02B8\u02B2\u02BD\u02B9\u02BE\u02B7\u02BA\u02C1\u02C1\u02BD\u02B5()
		{
			this.<>4__this.\u02BB\u02BC\u02B9\u02B3\u02B6\u02BE\u02C1\u02BE\u02B3\u02BB\u02B6(this.delIndex);
		}

		public int delIndex;

		public SongPathsManager <>4__this;
	}
}
