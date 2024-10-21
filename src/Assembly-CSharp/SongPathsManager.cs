using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020001F8 RID: 504
public class SongPathsManager : MonoBehaviour
{
	// Token: 0x06001695 RID: 5781 RVA: 0x00011AD7 File Offset: 0x0000FCD7
	private void \u02B5\u02B8\u02BF\u02BB\u02B7\u02B4\u02BB\u02B4\u02B4\u02BD\u02BF()
	{
		this.\u02B7\u02BC\u02B5\u02BE\u02B8\u02C0\u02C0\u02BF\u02BB\u02B5\u02BF();
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x00011ADF File Offset: 0x0000FCDF
	private void \u02BB\u02BD\u02B8\u02B6\u02B3\u02BA\u02B4\u02BB\u02BC\u02B2\u02B3()
	{
		this.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(true);
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x00011AF2 File Offset: 0x0000FCF2
	public static bool \u02B3\u02B8\u02BF\u02B8\u02BB\u02B4\u02B6\u02B6\u02B4\u02B5\u02BD()
	{
		return SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 == null || SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA == null || SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.activeInHierarchy;
	}

	// Token: 0x06001699 RID: 5785 RVA: 0x00011B2B File Offset: 0x0000FD2B
	[CompilerGenerated]
	private void \u02BC\u02B2\u02B8\u02BD\u02BD\u02B7\u02B7\u02B6\u02BE\u02B4\u02BA()
	{
		this.\u02B8\u02B7\u02B4\u02B8\u02BF\u02C0\u02C1\u02BE\u02BF\u02C0\u02BB();
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x000AD9B8 File Offset: 0x000ABBB8
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
			gameObject.GetComponentInChildren<TextMeshProUGUI>().text = ((i > 0) ? GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9[i] : (\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Default") + " (" + GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9[i] + ")"));
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

	// Token: 0x0600169B RID: 5787 RVA: 0x000ADB00 File Offset: 0x000ABD00
	private void \u02B8\u02B7\u02B4\u02B8\u02BF\u02C0\u02C1\u02BE\u02BF\u02C0\u02BB()
	{
		\u02C0\u02BD\u02B9\u02B8\u02B6\u02BB\u02B7\u02B8\u02B7\u02B4\u02B4 u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B = new \u02B9\u02BE\u02B6\u02B2\u02BC\u02BC\u02B2\u02C0\u02B8\u02B4\u02BA();
		if (u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B == null)
		{
			return;
		}
		string text = u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B.\u02B3\u02BF\u02B9\u02BC\u02B5\u02BB\u02BD\u02BB\u02B6\u02B2\u02B6(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Select the songs folder you would like to add."));
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

	// Token: 0x0600169C RID: 5788 RVA: 0x00011B33 File Offset: 0x0000FD33
	private void OnEnable()
	{
		SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 = this;
	}

	// Token: 0x0600169D RID: 5789 RVA: 0x00011B3B File Offset: 0x0000FD3B
	public static bool \u02BF\u02B3\u02B6\u02B5\u02BB\u02B7\u02BE\u02BF\u02C1\u02BA\u02BF()
	{
		return !(SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 == null) && !(SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA == null) && SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.activeInHierarchy;
	}

	// Token: 0x0600169E RID: 5790 RVA: 0x00011B74 File Offset: 0x0000FD74
	public static void \u02BE\u02B3\u02B7\u02BD\u02BA\u02BB\u02B4\u02B7\u02B5\u02B3\u02B2()
	{
		SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B8\u02C1\u02BC\u02B5\u02BB\u02B8\u02BD\u02C0\u02B7\u02B2\u02C1();
		Cursor.visible = true;
	}

	// Token: 0x0600169F RID: 5791 RVA: 0x00011B86 File Offset: 0x0000FD86
	public static void \u02C1\u02B5\u02C0\u02B4\u02BD\u02BD\u02BD\u02BD\u02C1\u02BE\u02B2()
	{
		SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B8\u02C1\u02BC\u02B5\u02BB\u02B8\u02BD\u02C0\u02B7\u02B2\u02C1();
		Cursor.visible = false;
	}

	// Token: 0x060016A0 RID: 5792 RVA: 0x000ADB98 File Offset: 0x000ABD98
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

	// Token: 0x060016A1 RID: 5793 RVA: 0x00011B98 File Offset: 0x0000FD98
	private void OnDisable()
	{
		SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 = null;
	}

	// Token: 0x060016A2 RID: 5794 RVA: 0x00011B33 File Offset: 0x0000FD33
	private void \u02B8\u02B2\u02BB\u02BF\u02BF\u02BF\u02C0\u02BE\u02BD\u02B9\u02B8()
	{
		SongPathsManager.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 = this;
	}

	// Token: 0x060016A3 RID: 5795 RVA: 0x00011BA0 File Offset: 0x0000FDA0
	[CompilerGenerated]
	private void \u02B7\u02BA\u02BF\u02B6\u02BB\u02B4\u02BB\u02B6\u02BE\u02BF\u02BE()
	{
		this.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(false);
	}

	// Token: 0x060016A4 RID: 5796 RVA: 0x000ADC00 File Offset: 0x000ABE00
	private void \u02B7\u02BC\u02B5\u02BE\u02B8\u02C0\u02C0\u02BF\u02BB\u02B5\u02BF()
	{
		\u02C0\u02BD\u02B9\u02B8\u02B6\u02BB\u02B7\u02B8\u02B7\u02B4\u02B4 u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B = new \u02B9\u02BE\u02B6\u02B2\u02BC\u02BC\u02B2\u02C0\u02B8\u02B4\u02BA();
		if (u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B == null)
		{
			return;
		}
		string text = u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B.\u02B3\u02BF\u02B9\u02BC\u02B5\u02BB\u02BD\u02BB\u02B6\u02B2\u02B6(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(".png|.jpg|.jpeg"));
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

	// Token: 0x060016A5 RID: 5797 RVA: 0x000ADC98 File Offset: 0x000ABE98
	private void \u02C1\u02C1\u02B2\u02BD\u02BC\u02BA\u02BF\u02BD\u02B3\u02B4\u02B2()
	{
		\u02C0\u02BD\u02B9\u02B8\u02B6\u02BB\u02B7\u02B8\u02B7\u02B4\u02B4 u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B = new \u02B9\u02BE\u02B6\u02B2\u02BC\u02BC\u02B2\u02C0\u02B8\u02B4\u02BA();
		if (u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B == null)
		{
			return;
		}
		string text = u02C0_u02BD_u02B9_u02B8_u02B6_u02BB_u02B7_u02B8_u02B7_u02B4_u02B.\u02B3\u02BF\u02B9\u02BC\u02B5\u02BB\u02BD\u02BB\u02B6\u02B2\u02B6(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Measure Based Countdowns"));
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

	// Token: 0x060016A6 RID: 5798 RVA: 0x000ADD30 File Offset: 0x000ABF30
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

	// Token: 0x060016A7 RID: 5799 RVA: 0x000ADDE8 File Offset: 0x000ABFE8
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

	// Token: 0x060016A8 RID: 5800 RVA: 0x000ADEA0 File Offset: 0x000AC0A0
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

	// Token: 0x04001064 RID: 4196
	public GameObject \u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8;

	// Token: 0x04001065 RID: 4197
	public Button \u02B2\u02B7\u02C0\u02B7\u02B2\u02B9\u02BA\u02B8\u02BC\u02B4\u02BD;

	// Token: 0x04001066 RID: 4198
	public Button \u02B8\u02C0\u02B3\u02B2\u02BE\u02C0\u02B2\u02B6\u02BF\u02B5\u02BE;

	// Token: 0x04001067 RID: 4199
	public Canvas \u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA;

	// Token: 0x04001068 RID: 4200
	public Transform \u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB;

	// Token: 0x04001069 RID: 4201
	private static SongPathsManager \u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6;

	// Token: 0x0400106A RID: 4202
	private bool \u02B8\u02B2\u02BA\u02B6\u02B9\u02B8\u02BA\u02B7\u02BA\u02BE\u02BB;

	// Token: 0x020001F9 RID: 505
	[CompilerGenerated]
	private sealed class \u02BE\u02BD\u02B4\u02BB\u02C0\u02BE\u02B3\u02C0\u02B4\u02BF\u02B7
	{
		// Token: 0x060016AA RID: 5802 RVA: 0x00011BB3 File Offset: 0x0000FDB3
		internal void \u02B8\u02B2\u02BD\u02B9\u02BE\u02B7\u02BA\u02C1\u02C1\u02BD\u02B5()
		{
			this.<>4__this.\u02BB\u02BC\u02B9\u02B3\u02B6\u02BE\u02C1\u02BE\u02B3\u02BB\u02B6(this.delIndex);
		}

		// Token: 0x0400106B RID: 4203
		public int delIndex;

		// Token: 0x0400106C RID: 4204
		public SongPathsManager <>4__this;
	}
}
