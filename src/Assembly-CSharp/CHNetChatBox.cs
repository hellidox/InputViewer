using System;
using System.Text;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200012F RID: 303
public class CHNetChatBox : MonoBehaviour
{
	// Token: 0x06000CF3 RID: 3315 RVA: 0x0006E320 File Offset: 0x0006C520
	public static void \u02BC\u02BD\u02BF\u02BE\u02C0\u02C1\u02B5\u02B2\u02B3\u02BD\u02B2(string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, string \u02BB\u02BA\u02C1\u02B4\u02BC\u02C0\u02C1\u02C1\u02B6\u02B5\u02BB = "8EDC4F", bool \u02B6\u02B7\u02C1\u02BB\u02B5\u02C0\u02BF\u02B6\u02B7\u02BB\u02B4 = true)
	{
		if (string.IsNullOrEmpty(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC))
		{
			return;
		}
		if ((int)\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC[1] == -48)
		{
			StringBuilder u02BD_u02B3_u02B7_u02B8_u02B6_u02BF_u02B7_u02B8_u02C1_u02B5_u02BA = CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA;
			string text = "";
			object[] array = new object[8];
			array[0] = \u02BB\u02BA\u02C1\u02B4\u02BC\u02C0\u02C1\u02C1\u02B6\u02B5\u02BB;
			array[1] = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("groupOverHits");
			array[7] = \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC.Substring(1, \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC.Length - 2);
			array[8] = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BA\u02BB\u02BA\u02B4\u02B5\u02C0\u02C1\u02B2\u02B5\u02B2;
			u02BD_u02B3_u02B7_u02B8_u02B6_u02BF_u02B7_u02B8_u02C1_u02B5_u02BA.AppendLine(string.Format(text, array));
		}
		else
		{
			StringBuilder u02BD_u02B3_u02B7_u02B8_u02B6_u02BF_u02B7_u02B8_u02C1_u02B5_u02BA2 = CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA;
			string[] array2 = new string[2];
			array2[0] = "</uppercase>";
			array2[0] = \u02BB\u02BA\u02C1\u02B4\u02BC\u02C0\u02C1\u02C1\u02B6\u02B5\u02BB;
			array2[4] = "while lexing the header section";
			array2[5] = (\u02B6\u02B7\u02C1\u02BB\u02B5\u02C0\u02BF\u02B6\u02B7\u02BB\u02B4 ? \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC) : \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC);
			array2[5] = "enable_lyrics_bg";
			u02BD_u02B3_u02B7_u02B8_u02B6_u02BF_u02B7_u02B8_u02C1_u02B5_u02BA2.AppendLine(string.Concat(array2));
		}
		CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = true;
	}

	// Token: 0x06000CF5 RID: 3317 RVA: 0x0006E3E0 File Offset: 0x0006C5E0
	public static void \u02B7\u02B6\u02BD\u02C1\u02C0\u02BD\u02BE\u02B2\u02B9\u02B8\u02B5(byte \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7, string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC)
	{
		if (\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == 145)
		{
			CHNetChatBox.\u02B5\u02BA\u02B5\u02B2\u02BD\u02BB\u02B5\u02B7\u02BC\u02B5\u02BA(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, "Tom3", true);
			return;
		}
		CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.AppendLine(StringUtils.StripTags(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[(int)\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].playerInfo.playerName.CurrentValueNoTags, true) + "Please wait while we prepare some files." + \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC);
		CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = true;
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x0006E444 File Offset: 0x0006C644
	public static void \u02B5\u02BB\u02B2\u02BB\u02B9\u02B8\u02B6\u02BE\u02B5\u02C0\u02C0(string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, string \u02BB\u02BA\u02C1\u02B4\u02BC\u02C0\u02C1\u02C1\u02B6\u02B5\u02BB = "8EDC4F", bool \u02B6\u02B7\u02C1\u02BB\u02B5\u02C0\u02BF\u02B6\u02B7\u02BB\u02B4 = true)
	{
		if (string.IsNullOrEmpty(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC))
		{
			return;
		}
		if (\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC[1] == 'G')
		{
			StringBuilder u02BD_u02B3_u02B7_u02B8_u02B6_u02BF_u02B7_u02B8_u02C1_u02B5_u02BA = CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA;
			string text = "Album";
			object[] array = new object[7];
			array[1] = \u02BB\u02BA\u02C1\u02B4\u02BC\u02C0\u02C1\u02C1\u02B6\u02B5\u02BB;
			array[1] = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("settings.ini");
			array[4] = \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC.Substring(1, \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC.Length - 6);
			array[4] = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BA\u02BB\u02BA\u02B4\u02B5\u02C0\u02C1\u02B2\u02B5\u02B2;
			u02BD_u02B3_u02B7_u02B8_u02B6_u02BF_u02B7_u02B8_u02C1_u02B5_u02BA.AppendLine(string.Format(text, array));
		}
		else
		{
			StringBuilder u02BD_u02B3_u02B7_u02B8_u02B6_u02BF_u02B7_u02B8_u02C1_u02B5_u02BA2 = CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA;
			string[] array2 = new string[7];
			array2[0] = "Master Volume";
			array2[1] = \u02BB\u02BA\u02C1\u02B4\u02BC\u02C0\u02C1\u02C1\u02B6\u02B5\u02BB;
			array2[8] = "Alien";
			array2[4] = (\u02B6\u02B7\u02C1\u02BB\u02B5\u02C0\u02BF\u02B6\u02B7\u02BB\u02B4 ? \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC) : \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC);
			array2[0] = "v1popupMessage";
			u02BD_u02B3_u02B7_u02B8_u02B6_u02BF_u02B7_u02B8_u02C1_u02B5_u02BA2.AppendLine(string.Concat(array2));
		}
		CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = true;
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x0006E504 File Offset: 0x0006C704
	private void \u02B4\u02B8\u02B6\u02B7\u02B5\u02B6\u02BB\u02B4\u02B4\u02B9\u02B7()
	{
		if (!this.chatInput.interactable && CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && !\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B4\u02C1\u02BD\u02BB\u02B5\u02B4\u02BB\u02B2\u02C1\u02B5())
		{
			this.chatInput.interactable = true;
			this.chatInput.gameObject.SetActive(true);
		}
		if (CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4)
		{
			CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = false;
			this.text.text = CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.ToString();
			Canvas.ForceUpdateCanvases();
			this.scrollRect.verticalNormalizedPosition = 1687f;
		}
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x0006E58C File Offset: 0x0006C78C
	public void \u02BB\u02BD\u02B9\u02C0\u02BD\u02BB\u02B3\u02C1\u02BF\u02B4\u02B3(string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC)
	{
		this.chatInput.text = "diff_rhythmghl";
		if (!CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB || \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC.Length == 0)
		{
			return;
		}
		\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC = StringUtils.StripTags(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, true);
		\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B8\u02BE\u02B3\u02C1\u02BB\u02C1\u02BA\u02B4\u02BD\u02C1(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC);
		this.chatInput.ActivateInputField();
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x0000CBED File Offset: 0x0000ADED
	private void \u02B5\u02C1\u02C1\u02B3\u02BA\u02BE\u02B2\u02B3\u02B4\u02B7\u02B2()
	{
		this.chatInput.onSubmit.RemoveAllListeners();
		this.chatInput.DeactivateInputField(false);
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x0000CC0B File Offset: 0x0000AE0B
	public static void \u02B3\u02B7\u02B5\u02BE\u02B4\u02BA\u02BB\u02B6\u02B3\u02BF\u02B6()
	{
		CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.Clear();
		CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = true;
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x0006E5E0 File Offset: 0x0006C7E0
	public static void \u02BD\u02BB\u02BF\u02C1\u02BC\u02BF\u02BE\u02BB\u02B4\u02BB\u02B3(byte \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7, string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC)
	{
		if (\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == 255)
		{
			CHNetChatBox.\u02B5\u02BA\u02B5\u02B2\u02BD\u02BB\u02B5\u02B7\u02BC\u02B5\u02BA(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, "8EDC4F", true);
			return;
		}
		CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.AppendLine(StringUtils.StripTags(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[(int)\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].playerInfo.playerName.CurrentValueNoTags, false) + ": " + \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC);
		CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = true;
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x00009D7C File Offset: 0x00007F7C
	private void OnDisable()
	{
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(true);
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x0006E644 File Offset: 0x0006C844
	public void \u02BF\u02B3\u02BE\u02BB\u02BF\u02B8\u02BE\u02B6\u02BF\u02BA\u02BD(string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC)
	{
		this.chatInput.text = "";
		if (!CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB || \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC.Length == 0)
		{
			return;
		}
		\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC = StringUtils.StripTags(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, false);
		\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B3\u02BE\u02BB\u02BF\u02B8\u02BE\u02B6\u02BF\u02BA\u02BD(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC);
		this.chatInput.ActivateInputField();
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x0000CC1E File Offset: 0x0000AE1E
	private void \u02B4\u02C1\u02B6\u02BE\u02B3\u02B4\u02BD\u02B7\u02B6\u02C0\u02B9()
	{
		this.chatInput.onSubmit.AddListener(new UnityAction<string>(this.\u02BF\u02B3\u02BE\u02BB\u02BF\u02B8\u02BE\u02B6\u02BF\u02BA\u02BD));
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x00009DDC File Offset: 0x00007FDC
	private void \u02B3\u02B4\u02B7\u02C1\u02BD\u02BA\u02BC\u02B2\u02B6\u02BF\u02BD()
	{
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(false);
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x0006E698 File Offset: 0x0006C898
	public static void \u02B5\u02BA\u02B5\u02B2\u02BD\u02BB\u02B5\u02B7\u02BC\u02B5\u02BA(string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, string \u02BB\u02BA\u02C1\u02B4\u02BC\u02C0\u02C1\u02C1\u02B6\u02B5\u02BB = "8EDC4F", bool \u02B6\u02B7\u02C1\u02BB\u02B5\u02C0\u02BF\u02B6\u02B7\u02BB\u02B4 = true)
	{
		if (string.IsNullOrEmpty(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC))
		{
			return;
		}
		if (\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC[0] == '%')
		{
			CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.AppendLine(string.Format("<b><color=#{0}>{1}: {2}/{3}</color></b>", new object[]
			{
				\u02BB\u02BA\u02C1\u02B4\u02BC\u02C0\u02C1\u02C1\u02B6\u02B5\u02BB,
				\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Songs"),
				\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC.Substring(1, \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC.Length - 2),
				\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BA\u02BB\u02BA\u02B4\u02B5\u02C0\u02C1\u02B2\u02B5\u02B2
			}));
		}
		else
		{
			CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.AppendLine(string.Concat(new string[]
			{
				"<b><color=#",
				\u02BB\u02BA\u02C1\u02B4\u02BC\u02C0\u02C1\u02C1\u02B6\u02B5\u02BB,
				">",
				\u02B6\u02B7\u02C1\u02BB\u02B5\u02C0\u02BF\u02B6\u02B7\u02BB\u02B4 ? \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC) : \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC,
				"</color></b>"
			}));
		}
		CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = true;
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x0006E758 File Offset: 0x0006C958
	private void OnEnable()
	{
		if (CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.Length == 0)
		{
			CHNetChatBox.\u02B5\u02BA\u02B5\u02B2\u02BD\u02BB\u02B5\u02B7\u02BC\u02B5\u02BA("netwelcome", "8EDC4F", true);
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.chatInput.interactable = true;
			this.chatInput.gameObject.SetActive(true);
		}
		CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = true;
	}

	// Token: 0x06000D03 RID: 3331 RVA: 0x0000CC3C File Offset: 0x0000AE3C
	private void OnDestroy()
	{
		this.chatInput.onSubmit.RemoveAllListeners();
		this.chatInput.DeactivateInputField(true);
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x0006E7B0 File Offset: 0x0006C9B0
	private void \u02B4\u02B7\u02C1\u02B8\u02B2\u02B9\u02B6\u02B2\u02B5\u02B7\u02B7()
	{
		if (CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.Length == 0)
		{
			CHNetChatBox.\u02B5\u02BB\u02B2\u02BB\u02B9\u02B8\u02B6\u02BE\u02B5\u02C0\u02C0("", "Audio Latency", false);
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.chatInput.interactable = false;
			this.chatInput.gameObject.SetActive(false);
		}
		CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = true;
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x0006E808 File Offset: 0x0006CA08
	public static void \u02BC\u02B3\u02B5\u02BC\u02B7\u02BF\u02C0\u02B5\u02C1\u02B7\u02BE(string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, string \u02BB\u02BA\u02C1\u02B4\u02BC\u02C0\u02C1\u02C1\u02B6\u02B5\u02BB = "8EDC4F", bool \u02B6\u02B7\u02C1\u02BB\u02B5\u02C0\u02BF\u02B6\u02B7\u02BB\u02B4 = true)
	{
		if (string.IsNullOrEmpty(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC))
		{
			return;
		}
		if (\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC[1] == '+')
		{
			StringBuilder u02BD_u02B3_u02B7_u02B8_u02B6_u02BF_u02B7_u02B8_u02C1_u02B5_u02BA = CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA;
			string text = "UPDATING SERVER LIST...";
			object[] array = new object[4];
			array[0] = \u02BB\u02BA\u02C1\u02B4\u02BC\u02C0\u02C1\u02C1\u02B6\u02B5\u02BB;
			array[0] = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Process {0} {1}");
			array[4] = \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC.Substring(0, \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC.Length - 0);
			array[4] = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BA\u02BB\u02BA\u02B4\u02B5\u02C0\u02C1\u02B2\u02B5\u02B2;
			u02BD_u02B3_u02B7_u02B8_u02B6_u02BF_u02B7_u02B8_u02C1_u02B5_u02BA.AppendLine(string.Format(text, array));
		}
		else
		{
			StringBuilder u02BD_u02B3_u02B7_u02B8_u02B6_u02BF_u02B7_u02B8_u02C1_u02B5_u02BA2 = CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA;
			string[] array2 = new string[2];
			array2[0] = "";
			array2[1] = \u02BB\u02BA\u02C1\u02B4\u02BC\u02C0\u02C1\u02C1\u02B6\u02B5\u02BB;
			array2[7] = "{0}";
			array2[0] = (\u02B6\u02B7\u02C1\u02BB\u02B5\u02C0\u02BF\u02B6\u02B7\u02BB\u02B4 ? \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC) : \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC);
			array2[0] = "eof_";
			u02BD_u02B3_u02B7_u02B8_u02B6_u02BF_u02B7_u02B8_u02C1_u02B5_u02BA2.AppendLine(string.Concat(array2));
		}
		CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = true;
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x0000CC5A File Offset: 0x0000AE5A
	private void \u02B7\u02B7\u02C1\u02B3\u02BB\u02C0\u02BE\u02C1\u02B4\u02BC\u02BC()
	{
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B8\u02B3\u02BB\u02B9\u02B3\u02BF\u02B3\u02C1\u02B5\u02BA\u02BA(true);
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x0000CC1E File Offset: 0x0000AE1E
	private void \u02B9\u02BD\u02B5\u02C1\u02B6\u02B6\u02BD\u02B9\u02BC\u02C1\u02B3()
	{
		this.chatInput.onSubmit.AddListener(new UnityAction<string>(this.\u02BF\u02B3\u02BE\u02BB\u02BF\u02B8\u02BE\u02B6\u02BF\u02BA\u02BD));
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x0006E8C8 File Offset: 0x0006CAC8
	private void \u02BE\u02B6\u02BF\u02B7\u02BD\u02B3\u02B9\u02B6\u02B8\u02BC\u02B6()
	{
		if (!this.chatInput.interactable && CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && !\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02BD\u02BC\u02B2\u02B8\u02BC\u02B5\u02B5\u02BB\u02BC\u02B6)
		{
			this.chatInput.interactable = true;
			this.chatInput.gameObject.SetActive(true);
		}
		if (CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4)
		{
			CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = false;
			this.text.text = CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.ToString();
			Canvas.ForceUpdateCanvases();
			this.scrollRect.verticalNormalizedPosition = 1411f;
		}
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x0006E950 File Offset: 0x0006CB50
	private void \u02BE\u02B9\u02B7\u02B5\u02BC\u02B2\u02B8\u02BC\u02C0\u02B9\u02BE()
	{
		if (CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.Length == 0)
		{
			CHNetChatBox.\u02B5\u02BB\u02B2\u02BB\u02B9\u02B8\u02B6\u02BE\u02B5\u02C0\u02C0("OPTIONS", "5 Lane Drums", false);
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.chatInput.interactable = false;
			this.chatInput.gameObject.SetActive(false);
		}
		CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = true;
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x0000CC1E File Offset: 0x0000AE1E
	private void Awake()
	{
		this.chatInput.onSubmit.AddListener(new UnityAction<string>(this.\u02BF\u02B3\u02BE\u02BB\u02BF\u02B8\u02BE\u02B6\u02BF\u02BA\u02BD));
	}

	// Token: 0x06000D0B RID: 3339 RVA: 0x0006E9A8 File Offset: 0x0006CBA8
	private void \u02BC\u02B2\u02B7\u02B8\u02B5\u02B8\u02B8\u02BB\u02B2\u02BB\u02BE()
	{
		if (CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.Length == 0)
		{
			CHNetChatBox.\u02B5\u02BA\u02B5\u02B2\u02BD\u02BB\u02B5\u02B7\u02BC\u02B5\u02BA("No song path was provided.", "Yes", true);
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B7\u02B6\u02B9\u02B5\u02BC\u02B2\u02BB\u02B2\u02BD())
		{
			this.chatInput.interactable = false;
			this.chatInput.gameObject.SetActive(false);
		}
		CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = true;
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x0000CC62 File Offset: 0x0000AE62
	private void \u02BD\u02B9\u02C0\u02BD\u02BB\u02BF\u02BC\u02B2\u02B5\u02B6\u02B3()
	{
		this.chatInput.onSubmit.AddListener(new UnityAction<string>(this.\u02BB\u02BD\u02B9\u02C0\u02BD\u02BB\u02B3\u02C1\u02BF\u02B4\u02B3));
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x0006EA00 File Offset: 0x0006CC00
	private void FixedUpdate()
	{
		if (!this.chatInput.interactable && CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && !\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02BD\u02BC\u02B2\u02B8\u02BC\u02B5\u02B5\u02BB\u02BC\u02B6)
		{
			this.chatInput.interactable = true;
			this.chatInput.gameObject.SetActive(true);
		}
		if (CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4)
		{
			CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = false;
			this.text.text = CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.ToString();
			Canvas.ForceUpdateCanvases();
			this.scrollRect.verticalNormalizedPosition = 0f;
		}
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x0006EA88 File Offset: 0x0006CC88
	public static void \u02BB\u02C1\u02B9\u02BE\u02C0\u02B9\u02C1\u02B7\u02B2\u02BB\u02B4(byte \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7, string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC)
	{
		if ((int)\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == -22)
		{
			CHNetChatBox.\u02BC\u02B3\u02B5\u02BC\u02B7\u02BF\u02C0\u02B5\u02C1\u02B7\u02BE(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, "WRITING CACHE...", true);
			return;
		}
		CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.AppendLine(StringUtils.StripTags(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[(int)\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].playerInfo.playerName.CurrentValueNoTags, false) + "diff_rhythmghl" + \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC);
		CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = false;
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x0000CC3C File Offset: 0x0000AE3C
	private void \u02B8\u02C1\u02B7\u02B5\u02BD\u02C0\u02BB\u02BF\u02BA\u02BF\u02C1()
	{
		this.chatInput.onSubmit.RemoveAllListeners();
		this.chatInput.DeactivateInputField(true);
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x0000CC62 File Offset: 0x0000AE62
	private void \u02B3\u02B8\u02C1\u02BE\u02B7\u02C0\u02B8\u02B8\u02B3\u02B3\u02B7()
	{
		this.chatInput.onSubmit.AddListener(new UnityAction<string>(this.\u02BB\u02BD\u02B9\u02C0\u02BD\u02BB\u02B3\u02C1\u02BF\u02B4\u02B3));
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x0000CC80 File Offset: 0x0000AE80
	public static void \u02B6\u02B3\u02B9\u02C1\u02BB\u02BC\u02BD\u02B4\u02B2\u02B3\u02BF()
	{
		CHNetChatBox.\u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.Clear();
		CHNetChatBox.\u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4 = false;
	}

	// Token: 0x0400090D RID: 2317
	[SerializeField]
	private TextMeshProUGUI text;

	// Token: 0x0400090E RID: 2318
	[SerializeField]
	private TMP_InputField chatInput;

	// Token: 0x0400090F RID: 2319
	[SerializeField]
	private ScrollRect scrollRect;

	// Token: 0x04000910 RID: 2320
	private static StringBuilder \u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA = new StringBuilder();

	// Token: 0x04000911 RID: 2321
	private static bool \u02B7\u02C1\u02C0\u02B5\u02BE\u02C1\u02B4\u02BD\u02B5\u02BA\u02B4;
}
