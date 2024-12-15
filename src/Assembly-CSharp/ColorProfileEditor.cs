using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ColorProfileEditor : MonoBehaviour
{
	private void \u02B2\u02B9\u02BB\u02BD\u02B6\u02B4\u02BC\u02B3\u02B6\u02BC\u02B3(ColorGameSetting \u02BC\u02BB\u02B2\u02B2\u02BA\u02BD\u02B6\u02BF\u02B6\u02BB\u02B6, Image \u02BF\u02C1\u02BD\u02B7\u02B5\u02B6\u02BC\u02B3\u02BE\u02B3\u02B7, Image \u02B2\u02B3\u02B3\u02BD\u02B8\u02C0\u02B6\u02B3\u02C1\u02B9\u02B5, TMP_InputField \u02B5\u02BA\u02B6\u02BD\u02BF\u02B8\u02BD\u02C1\u02B4\u02BD\u02B6)
	{
		ColorProfileEditor.\u02B3\u02BB\u02BF\u02BC\u02C0\u02BB\u02C1\u02C1\u02B2\u02B5\u02BF u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF = new ColorProfileEditor.\u02B3\u02BB\u02BF\u02BC\u02C0\u02BB\u02C1\u02C1\u02B2\u02B5\u02BF();
		u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.<>4__this = this;
		u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.colorGameSetting = \u02BC\u02BB\u02B2\u02B2\u02BA\u02BD\u02B6\u02BF\u02B6\u02BB\u02B6;
		u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.inputButtonImage = \u02BF\u02C1\u02BD\u02B7\u02B5\u02B6\u02BC\u02B3\u02BE\u02B3\u02B7;
		u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.inputButtonIcon = \u02B2\u02B3\u02B3\u02BD\u02B8\u02C0\u02B6\u02B3\u02C1\u02B9\u02B5;
		u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.inputText = \u02B5\u02BA\u02B6\u02BD\u02BF\u02B8\u02BD\u02C1\u02B4\u02BD\u02B6;
		if (this.\u02BB\u02B5\u02C0\u02B9\u02C1\u02B8\u02BE\u02B9\u02BE\u02BC\u02B9.activeInHierarchy)
		{
			return;
		}
		this.\u02BB\u02B5\u02C0\u02B9\u02C1\u02B8\u02BE\u02B9\u02BE\u02BC\u02B9.SetActive(true);
		this.\u02BB\u02C0\u02BE\u02B2\u02BE\u02BC\u02B2\u02B9\u02B9\u02BC\u02BC.text = u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.colorGameSetting.Name;
		this.\u02B3\u02B7\u02B5\u02BA\u02B2\u02B3\u02BD\u02BC\u02BF\u02C0\u02BB.color = Helper.HexColorToColor(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.colorGameSetting.CurrentValue, 1f);
		this.\u02B5\u02BB\u02C0\u02B8\u02B6\u02C1\u02BD\u02B5\u02C0\u02BA\u02B6.color = Helper.HexColorToColor(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.colorGameSetting.DefaultValue, 1f);
		this.\u02B5\u02BF\u02BD\u02BA\u02B2\u02B6\u02BA\u02C1\u02B2\u02B7\u02B5.color = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(this.\u02B5\u02BB\u02C0\u02B8\u02B6\u02C1\u02BD\u02B5\u02C0\u02BA\u02B6.color);
		string text = HexColor.ToHexString(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.colorGameSetting.CurrentValue, false);
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.text = text;
		this.\u02B8\u02BB\u02C0\u02BF\u02BE\u02B4\u02BF\u02BF\u02C1\u02B2\u02BE(false);
		(this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.placeholder as TextMeshProUGUI).text = this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.text;
		(this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.placeholder as TextMeshProUGUI).text = this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.text;
		(this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.placeholder as TextMeshProUGUI).text = this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.text;
		(this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.placeholder as TextMeshProUGUI).text = this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.text;
		this.\u02BE\u02B7\u02B5\u02BC\u02BF\u02B8\u02B5\u02BA\u02BC\u02B6\u02BB.onClick.RemoveAllListeners();
		this.\u02BE\u02B7\u02B5\u02BC\u02BF\u02B8\u02B5\u02BA\u02BC\u02B6\u02BB.onClick.AddListener(new UnityAction(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BA\u02BB\u02B7\u02B8\u02B4\u02B8\u02BB\u02BA\u02C1\u02B5\u02B2));
		this.\u02B7\u02B8\u02B6\u02B5\u02C1\u02BD\u02B4\u02BE\u02B9\u02BA\u02B4.onClick.RemoveAllListeners();
		this.\u02B7\u02B8\u02B6\u02B5\u02C1\u02BD\u02B4\u02BE\u02B9\u02BA\u02B4.onClick.AddListener(new UnityAction(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BC\u02BD\u02B8\u02B2\u02C0\u02BA\u02C1\u02C0\u02BA\u02B3\u02BF));
		this.\u02BD\u02B6\u02BB\u02BD\u02B6\u02BA\u02B7\u02BD\u02B9\u02B2\u02B3.onClick.RemoveAllListeners();
		this.\u02BD\u02B6\u02BB\u02BD\u02B6\u02BA\u02B7\u02BD\u02B9\u02B2\u02B3.onClick.AddListener(new UnityAction(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02B5\u02B7\u02B5\u02B6\u02B9\u02B2\u02C1\u02B7\u02BE\u02BB\u02B5));
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.onDeselect.RemoveAllListeners();
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.onDeselect.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BB\u02BC\u02BE\u02B4\u02B7\u02B4\u02BB\u02B6\u02C1\u02C0\u02C1));
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.onSubmit.RemoveAllListeners();
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.onSubmit.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BC\u02C0\u02B2\u02C0\u02BA\u02C1\u02B5\u02B9\u02B4\u02BB\u02B4));
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.onValueChanged.RemoveAllListeners();
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.onValueChanged.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BB\u02C1\u02BE\u02B8\u02B6\u02BB\u02B9\u02BD\u02BA\u02BA\u02BC));
		this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.onDeselect.RemoveAllListeners();
		this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.onDeselect.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02B6\u02BE\u02B8\u02B9\u02C1\u02BA\u02BB\u02BB\u02BE\u02B3\u02BC));
		this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.onSubmit.RemoveAllListeners();
		this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.onSubmit.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BF\u02B8\u02B9\u02C1\u02BA\u02B6\u02BB\u02B3\u02BE\u02B2\u02C1));
		this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.onDeselect.RemoveAllListeners();
		this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.onDeselect.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02B3\u02B9\u02BE\u02B4\u02B2\u02B2\u02BB\u02B8\u02B9\u02B8\u02BF));
		this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.onSubmit.RemoveAllListeners();
		this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.onSubmit.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BA\u02C0\u02BB\u02C0\u02B8\u02B9\u02B7\u02B6\u02B2\u02BC\u02B5));
		this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.onDeselect.RemoveAllListeners();
		this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.onDeselect.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BC\u02B3\u02B5\u02B8\u02C1\u02B6\u02B5\u02C0\u02BE\u02B6\u02B3));
		this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.onSubmit.RemoveAllListeners();
		this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.onSubmit.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02B2\u02BE\u02BB\u02B4\u02B6\u02B9\u02BB\u02C0\u02BB\u02C1\u02B6));
		this.\u02B8\u02C1\u02B5\u02BD\u02BD\u02BE\u02B9\u02B9\u02B9\u02B2\u02BB.onValueChanged.RemoveAllListeners();
		this.\u02B8\u02C1\u02B5\u02BD\u02BD\u02BE\u02B9\u02B9\u02B9\u02B2\u02BB.onValueChanged.AddListener(new UnityAction<float>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02B3\u02BC\u02BE\u02C0\u02B7\u02B7\u02B8\u02BE\u02B9\u02B6\u02BC));
		this.\u02BF\u02B6\u02C1\u02B4\u02B3\u02B2\u02B5\u02B3\u02B3\u02B9\u02C0.onValueChanged.RemoveAllListeners();
		this.\u02BF\u02B6\u02C1\u02B4\u02B3\u02B2\u02B5\u02B3\u02B3\u02B9\u02C0.onValueChanged.AddListener(new UnityAction<float>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02B6\u02B9\u02B8\u02B4\u02BB\u02B4\u02C0\u02B6\u02C0\u02B8\u02B6));
		this.\u02BD\u02BB\u02C1\u02B6\u02BE\u02C0\u02BD\u02B5\u02B4\u02B9\u02B8.onValueChanged.RemoveAllListeners();
		this.\u02BD\u02BB\u02C1\u02B6\u02BE\u02C0\u02BD\u02B5\u02B4\u02B9\u02B8.onValueChanged.AddListener(new UnityAction<float>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BD\u02BA\u02C0\u02B3\u02B3\u02B6\u02B7\u02BF\u02B5\u02B6\u02C0));
	}

	[CompilerGenerated]
	private void \u02B9\u02B7\u02BC\u02B6\u02B9\u02B4\u02B7\u02B7\u02C0\u02B9\u02BA()
	{
		this.\u02B6\u02B6\u02B7\u02B8\u02B7\u02C1\u02C0\u02B4\u02B6\u02BE\u02B2(this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options[this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.value].text);
	}

	public static bool \u02BF\u02B3\u02B6\u02B5\u02BB\u02B7\u02BE\u02BF\u02C1\u02BA\u02BF()
	{
		return !(ColorProfileEditor.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 == null) && !(ColorProfileEditor.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA == null) && ColorProfileEditor.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.activeInHierarchy;
	}

	[CompilerGenerated]
	private void \u02B6\u02BC\u02BB\u02C0\u02B2\u02BC\u02BC\u02B7\u02B6\u02B4\u02B4(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		this.\u02BA\u02BB\u02B4\u02B7\u02BB\u02B4\u02B3\u02B2\u02BB\u02C0\u02B7(\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6);
	}

	private void \u02B4\u02BF\u02B2\u02B9\u02B5\u02BE\u02BE\u02BA\u02C0\u02C1\u02BA()
	{
		ColorProfileEditor.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 = null;
	}

	private void \u02B7\u02C0\u02B6\u02BC\u02C0\u02BB\u02B8\u02B2\u02B2\u02C1\u02BD(bool \u02B2\u02B5\u02BD\u02B8\u02B6\u02B4\u02BE\u02B5\u02B8\u02B9\u02B8)
	{
		Color color = Color.white;
		if (\u02B2\u02B5\u02BD\u02B8\u02B6\u02B4\u02BE\u02B5\u02B8\u02B9\u02B8)
		{
			color = Color.HSVToRGB(this.\u02B8\u02C1\u02B5\u02BD\u02BD\u02BE\u02B9\u02B9\u02B9\u02B2\u02BB.value / 1362f, this.\u02BF\u02B6\u02C1\u02B4\u02B3\u02B2\u02B5\u02B3\u02B3\u02B9\u02C0.value / 546f, this.\u02BD\u02BB\u02C1\u02B6\u02BE\u02C0\u02BD\u02B5\u02B4\u02B9\u02B8.value / 1895f);
		}
		else
		{
			ColorUtility.TryParseHtmlString("framerate" + this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.text, out color);
		}
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.text = ColorUtility.ToHtmlStringRGB(color);
		this.\u02B6\u02B4\u02BB\u02B8\u02BF\u02B5\u02BE\u02B5\u02B7\u02B5\u02B3.color = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(color);
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.textComponent.color = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(color);
		float num;
		float num2;
		float num3;
		Color.RGBToHSV(color, out num, out num2, out num3);
		this.\u02BB\u02B7\u02C0\u02B2\u02B9\u02BC\u02C1\u02BC\u02BC\u02B5\u02B5.color = color;
		if (!\u02B2\u02B5\u02BD\u02B8\u02B6\u02B4\u02BE\u02B5\u02B8\u02B9\u02B8)
		{
			this.\u02B8\u02C1\u02B5\u02BD\u02BD\u02BE\u02B9\u02B9\u02B9\u02B2\u02BB.value = num * 1263f;
			this.\u02BF\u02B6\u02C1\u02B4\u02B3\u02B2\u02B5\u02B3\u02B3\u02B9\u02C0.value = num2 * 1175f;
			this.\u02BD\u02BB\u02C1\u02B6\u02BE\u02C0\u02BD\u02B5\u02B4\u02B9\u02B8.value = num3 * 782f;
		}
		this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.text = this.\u02B8\u02C1\u02B5\u02BD\u02BD\u02BE\u02B9\u02B9\u02B9\u02B2\u02BB.value.ToString();
		this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.text = this.\u02BF\u02B6\u02C1\u02B4\u02B3\u02B2\u02B5\u02B3\u02B3\u02B9\u02C0.value.ToString();
		this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.text = this.\u02BD\u02BB\u02C1\u02B6\u02BE\u02C0\u02BD\u02B5\u02B4\u02B9\u02B8.value.ToString();
	}

	private void OnEnable()
	{
		ColorProfileEditor.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 = this;
	}

	[CompilerGenerated]
	private void \u02BA\u02BF\u02B7\u02B7\u02BD\u02C0\u02B6\u02B7\u02BB\u02B7\u02BE()
	{
		this.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(false);
		string text = this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options[this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.value].text;
		this.\u02B2\u02BC\u02BD\u02BA\u02BF\u02B9\u02BD\u02BB\u02B5\u02BA\u02B6.colorProfileName.CurrentValue = text;
		this.\u02B2\u02BC\u02BD\u02BA\u02BF\u02B9\u02BD\u02BB\u02B5\u02BA\u02B6.colorSettings = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02C0\u02BB\u02B2\u02B6\u02B4\u02B3\u02BF\u02B2\u02B5\u02B8\u02BA(text);
		Cursor.visible = SettingsController.enable_cursor;
	}

	private void \u02C1\u02BD\u02BE\u02BD\u02C0\u02BF\u02BD\u02B5\u02B6\u02B6\u02C0()
	{
		this.\u02B2\u02C1\u02BB\u02B6\u02B2\u02B5\u02B5\u02B7\u02B4\u02B8\u02B8(this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options[this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.value].text);
	}

	private void \u02BA\u02BB\u02B4\u02B7\u02BB\u02B4\u02B3\u02B2\u02BB\u02C0\u02B7(string \u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0)
	{
		if (string.IsNullOrWhiteSpace(\u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0))
		{
			return;
		}
		string text = Path.Combine(Path.Combine(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Colors"), \u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0 + ".ini");
		if (!File.Exists(text))
		{
			ColorManager u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE;
			string text2 = Settings.RegisterConfigFileName("GameColors_" + \u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0, text);
			ColorSettings colorSettings = new ColorSettings();
			colorSettings.SetupSettings(text2);
			u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Add(\u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0);
			u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2.Add(colorSettings);
			u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B5\u02B3\u02BB\u02BF\u02B8\u02BB\u02B7\u02C0\u02C1\u02B6\u02BC();
			this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Select(new Func<string, TMP_Dropdown.OptionData>(ColorProfileEditor.<>c.<>9.\u02BF\u02BF\u02B5\u02B6\u02C0\u02C1\u02B9\u02BC\u02BB\u02B3\u02BE)).ToList<TMP_Dropdown.OptionData>();
			this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.value = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.IndexOf(\u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0);
			this.\u02BB\u02B4\u02BC\u02B7\u02C1\u02C0\u02BE\u02C1\u02C1\u02BD\u02BE.text = string.Empty;
		}
	}

	private void \u02BC\u02B4\u02B5\u02BA\u02BD\u02C0\u02B9\u02B5\u02C1\u02B9\u02B3(string \u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0)
	{
		if (string.IsNullOrWhiteSpace(\u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0))
		{
			return;
		}
		string text = Path.Combine(Path.Combine(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Error while loading CLI chart"), \u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0 + "_TextureScaleOffset");
		if (!File.Exists(text))
		{
			ColorManager u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE;
			string text2 = Settings.RegisterConfigFileName("Online Highway Placement" + \u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0, text);
			ColorSettings colorSettings = new ColorSettings();
			colorSettings.SetupSettings(text2);
			u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C0\u02BA\u02B8\u02BC\u02B6\u02B7\u02BD\u02B3\u02B4\u02B3\u02BC().Add(\u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0);
			u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C1\u02B7\u02C0\u02B3\u02BF\u02B2\u02BF\u02C0\u02B5\u02C1\u02B4().Add(colorSettings);
			u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C1\u02BC\u02BE\u02BC\u02B7\u02BA\u02BF\u02B5\u02B5\u02B2\u02B2();
			this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Select(new Func<string, TMP_Dropdown.OptionData>(ColorProfileEditor.<>c.<>9.\u02BF\u02BF\u02B5\u02B6\u02C0\u02C1\u02B9\u02BC\u02BB\u02B3\u02BE)).ToList<TMP_Dropdown.OptionData>();
			this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.value = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C0\u02C1\u02B7\u02BF\u02B8\u02B9\u02B8\u02BC\u02BD\u02C1\u02BC().IndexOf(\u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0);
			this.\u02BB\u02B4\u02BC\u02B7\u02C1\u02C0\u02BE\u02C1\u02C1\u02BD\u02BE.text = string.Empty;
		}
	}

	private bool \u02B3\u02B3\u02B2\u02BE\u02B7\u02B8\u02B2\u02BA\u02B9\u02B8\u02B9(TMP_InputField \u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE, string \u02B3\u02BE\u02BA\u02B5\u02B2\u02BB\u02C1\u02B7\u02B5\u02B8\u02B8, bool \u02C0\u02C0\u02B2\u02B8\u02B9\u02C0\u02BB\u02B5\u02B4\u02BF\u02BF = true, ColorGameSetting \u02BC\u02BB\u02B2\u02B2\u02BA\u02BD\u02B6\u02BF\u02B6\u02BB\u02B6 = null)
	{
		TextMeshProUGUI textMeshProUGUI = \u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE.placeholder as TextMeshProUGUI;
		bool flag = false;
		Match match = Regex.Match(\u02B3\u02BE\u02BA\u02B5\u02B2\u02BB\u02C1\u02B7\u02B5\u02B8\u02B8.ToUpperInvariant(), "^[0123456789ABCDEF]{6}$");
		if (!match.Success || match.Value.Length != \u02B3\u02BE\u02BA\u02B5\u02B2\u02BB\u02C1\u02B7\u02B5\u02B8\u02B8.Length)
		{
			if (\u02C0\u02C0\u02B2\u02B8\u02B9\u02C0\u02BB\u02B5\u02B4\u02BF\u02BF)
			{
				\u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE.text = textMeshProUGUI.text;
				flag = true;
			}
		}
		else
		{
			\u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE.text = \u02B3\u02BE\u02BA\u02B5\u02B2\u02BB\u02C1\u02B7\u02B5\u02B8\u02B8.ToUpperInvariant();
			textMeshProUGUI.text = \u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE.text;
			flag = true;
		}
		\u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE.textComponent.rectTransform.offsetMin = Vector2.zero;
		\u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE.textComponent.rectTransform.offsetMax = Vector2.zero;
		RectTransform rectTransform = \u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE.transform.GetChild(0).Find("Caret") as RectTransform;
		if (rectTransform != null)
		{
			rectTransform.offsetMin = Vector2.zero;
			rectTransform.offsetMax = Vector2.zero;
		}
		if (\u02BC\u02BB\u02B2\u02B2\u02BA\u02BD\u02B6\u02BF\u02B6\u02BB\u02B6 != null)
		{
			if (flag)
			{
				\u02BC\u02BB\u02B2\u02B2\u02BA\u02BD\u02B6\u02BF\u02B6\u02BB\u02B6.CurrentValue = HexColor.FromHexString("#" + \u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE.text);
				Settings.Commit(true);
				return true;
			}
		}
		else if (flag)
		{
			this.\u02B8\u02BB\u02C0\u02BF\u02BE\u02B4\u02BF\u02BF\u02C1\u02B2\u02BE(false);
		}
		return false;
	}

	private Color \u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(Color \u02BB\u02BD\u02B4\u02B4\u02BF\u02C0\u02B2\u02BF\u02B4\u02BC\u02BD)
	{
		if ((double)\u02BB\u02BD\u02B4\u02B4\u02BF\u02C0\u02B2\u02BF\u02B4\u02BC\u02BD.r * 0.299 + (double)\u02BB\u02BD\u02B4\u02B4\u02BF\u02C0\u02B2\u02BF\u02B4\u02BC\u02BD.g * 0.587 + (double)\u02BB\u02BD\u02B4\u02B4\u02BF\u02C0\u02B2\u02BF\u02B4\u02BC\u02BD.b * 0.114 <= 0.7294)
		{
			return Color.white;
		}
		return Color.black;
	}

	private void \u02C1\u02B4\u02B3\u02B2\u02B9\u02C1\u02BF\u02B7\u02B7\u02BA\u02B9()
	{
		this.\u02C0\u02BA\u02B3\u02B4\u02B3\u02B7\u02B7\u02B6\u02B7\u02BF\u02BE(this.\u02BB\u02B4\u02BC\u02B7\u02C1\u02C0\u02BE\u02C1\u02C1\u02BD\u02BE.text);
	}

	private void \u02B5\u02C1\u02B9\u02BF\u02BA\u02BB\u02B2\u02BD\u02B7\u02C1\u02B4(TMP_InputField \u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE, Slider \u02B9\u02B3\u02B4\u02BF\u02B6\u02B3\u02B3\u02B6\u02BF\u02BF\u02B6, string \u02B8\u02C0\u02B8\u02B9\u02BC\u02BC\u02C0\u02B2\u02B3\u02B4\u02B3, bool \u02C0\u02C0\u02B2\u02B8\u02B9\u02C0\u02BB\u02B5\u02B4\u02BF\u02BF = true)
	{
		bool flag = false;
		int num;
		if (int.TryParse(\u02B8\u02C0\u02B8\u02B9\u02BC\u02BC\u02C0\u02B2\u02B3\u02B4\u02B3, out num))
		{
			TextMeshProUGUI textMeshProUGUI = \u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE.placeholder as TextMeshProUGUI;
			if (num < 0 || num > 255)
			{
				if (\u02C0\u02C0\u02B2\u02B8\u02B9\u02C0\u02BB\u02B5\u02B4\u02BF\u02BF)
				{
					\u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE.text = textMeshProUGUI.text;
					flag = true;
				}
			}
			else
			{
				\u02B9\u02B3\u02B4\u02BF\u02B6\u02B3\u02B3\u02B6\u02BF\u02BF\u02B6.value = (float)num;
				textMeshProUGUI.text = num.ToString();
				flag = true;
			}
		}
		if (flag)
		{
			this.\u02B8\u02BB\u02C0\u02BF\u02BE\u02B4\u02BF\u02BF\u02C1\u02B2\u02BE(true);
		}
		\u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE.textComponent.rectTransform.offsetMin = Vector2.zero;
		\u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE.textComponent.rectTransform.offsetMax = Vector2.zero;
		RectTransform rectTransform = \u02C1\u02BA\u02C0\u02BA\u02B2\u02BF\u02BC\u02C0\u02BF\u02BF\u02BE.transform.GetChild(0).Find("Caret") as RectTransform;
		if (rectTransform != null)
		{
			rectTransform.offsetMin = Vector2.zero;
			rectTransform.offsetMax = Vector2.zero;
		}
	}

	private void Start()
	{
		this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Select(new Func<string, TMP_Dropdown.OptionData>(ColorProfileEditor.<>c.<>9.\u02BF\u02B2\u02B4\u02B5\u02B7\u02BF\u02C0\u02B7\u02B7\u02B8\u02C1)).ToList<TMP_Dropdown.OptionData>();
		this.\u02B8\u02C0\u02B3\u02B2\u02BE\u02C0\u02B2\u02B6\u02BF\u02B5\u02BE.onClick.RemoveAllListeners();
		this.\u02B8\u02C0\u02B3\u02B2\u02BE\u02C0\u02B2\u02B6\u02BF\u02B5\u02BE.onClick.AddListener(new UnityAction(this.\u02BA\u02BF\u02B7\u02B7\u02BD\u02C0\u02B6\u02B7\u02BB\u02B7\u02BE));
		this.\u02B7\u02BE\u02BE\u02B8\u02B7\u02BF\u02B8\u02BE\u02B4\u02BA\u02B2.onClick.RemoveAllListeners();
		this.\u02B7\u02BE\u02BE\u02B8\u02B7\u02BF\u02B8\u02BE\u02B4\u02BA\u02B2.onClick.AddListener(new UnityAction(this.\u02B8\u02BF\u02BD\u02B8\u02B3\u02BC\u02C1\u02BD\u02B4\u02B7\u02B3));
		this.\u02BC\u02C1\u02BC\u02BA\u02BF\u02C1\u02B9\u02BD\u02BD\u02B5\u02B6.onClick.RemoveAllListeners();
		this.\u02BC\u02C1\u02BC\u02BA\u02BF\u02C1\u02B9\u02BD\u02BD\u02B5\u02B6.onClick.AddListener(new UnityAction(this.\u02B9\u02B7\u02BC\u02B6\u02B9\u02B4\u02B7\u02B7\u02C0\u02B9\u02BA));
		this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.onValueChanged.RemoveAllListeners();
		this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.onValueChanged.AddListener(new UnityAction<int>(this.\u02B7\u02B2\u02C1\u02B9\u02BA\u02B4\u02B8\u02B2\u02B8\u02BA\u02B9));
		this.\u02BB\u02B4\u02BC\u02B7\u02C1\u02C0\u02BE\u02C1\u02C1\u02BD\u02BE.onSubmit.RemoveAllListeners();
		this.\u02BB\u02B4\u02BC\u02B7\u02C1\u02C0\u02BE\u02C1\u02C1\u02BD\u02BE.onSubmit.AddListener(new UnityAction<string>(this.\u02B6\u02BC\u02BB\u02C0\u02B2\u02BC\u02BC\u02B7\u02B6\u02B4\u02B4));
		this.\u02BE\u02B2\u02BE\u02C1\u02B8\u02BD\u02BA\u02BE\u02B7\u02BC\u02BE(0);
	}

	private void \u02B3\u02BC\u02B6\u02BA\u02B4\u02BF\u02B7\u02B9\u02B9\u02BF\u02BF(ColorGameSetting \u02BC\u02BB\u02B2\u02B2\u02BA\u02BD\u02B6\u02BF\u02B6\u02BB\u02B6, Image \u02BF\u02C1\u02BD\u02B7\u02B5\u02B6\u02BC\u02B3\u02BE\u02B3\u02B7, Image \u02B2\u02B3\u02B3\u02BD\u02B8\u02C0\u02B6\u02B3\u02C1\u02B9\u02B5, TMP_InputField \u02B5\u02BA\u02B6\u02BD\u02BF\u02B8\u02BD\u02C1\u02B4\u02BD\u02B6)
	{
		ColorProfileEditor.\u02B3\u02BB\u02BF\u02BC\u02C0\u02BB\u02C1\u02C1\u02B2\u02B5\u02BF u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF = new ColorProfileEditor.\u02B3\u02BB\u02BF\u02BC\u02C0\u02BB\u02C1\u02C1\u02B2\u02B5\u02BF();
		u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.<>4__this = this;
		u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.colorGameSetting = \u02BC\u02BB\u02B2\u02B2\u02BA\u02BD\u02B6\u02BF\u02B6\u02BB\u02B6;
		u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.inputButtonImage = \u02BF\u02C1\u02BD\u02B7\u02B5\u02B6\u02BC\u02B3\u02BE\u02B3\u02B7;
		u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.inputButtonIcon = \u02B2\u02B3\u02B3\u02BD\u02B8\u02C0\u02B6\u02B3\u02C1\u02B9\u02B5;
		u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.inputText = \u02B5\u02BA\u02B6\u02BD\u02BF\u02B8\u02BD\u02C1\u02B4\u02BD\u02B6;
		if (this.\u02BB\u02B5\u02C0\u02B9\u02C1\u02B8\u02BE\u02B9\u02BE\u02BC\u02B9.activeInHierarchy)
		{
			return;
		}
		this.\u02BB\u02B5\u02C0\u02B9\u02C1\u02B8\u02BE\u02B9\u02BE\u02BC\u02B9.SetActive(true);
		this.\u02BB\u02C0\u02BE\u02B2\u02BE\u02BC\u02B2\u02B9\u02B9\u02BC\u02BC.text = u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.colorGameSetting.Name;
		this.\u02B3\u02B7\u02B5\u02BA\u02B2\u02B3\u02BD\u02BC\u02BF\u02C0\u02BB.color = Helper.HexColorToColor(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.colorGameSetting.CurrentValue, 681f);
		this.\u02B5\u02BB\u02C0\u02B8\u02B6\u02C1\u02BD\u02B5\u02C0\u02BA\u02B6.color = Helper.HexColorToColor(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.colorGameSetting.DefaultValue, 1506f);
		this.\u02B5\u02BF\u02BD\u02BA\u02B2\u02B6\u02BA\u02C1\u02B2\u02B7\u02B5.color = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(this.\u02B5\u02BB\u02C0\u02B8\u02B6\u02C1\u02BD\u02B5\u02C0\u02BA\u02B6.color);
		string text = HexColor.ToHexString(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.colorGameSetting.CurrentValue, false);
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.text = text;
		this.\u02B8\u02BB\u02C0\u02BF\u02BE\u02B4\u02BF\u02BF\u02C1\u02B2\u02BE(false);
		(this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.placeholder as TextMeshProUGUI).text = this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.text;
		(this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.placeholder as TextMeshProUGUI).text = this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.text;
		(this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.placeholder as TextMeshProUGUI).text = this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.text;
		(this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.placeholder as TextMeshProUGUI).text = this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.text;
		this.\u02BE\u02B7\u02B5\u02BC\u02BF\u02B8\u02B5\u02BA\u02BC\u02B6\u02BB.onClick.RemoveAllListeners();
		this.\u02BE\u02B7\u02B5\u02BC\u02BF\u02B8\u02B5\u02BA\u02BC\u02B6\u02BB.onClick.AddListener(new UnityAction(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BA\u02BB\u02B7\u02B8\u02B4\u02B8\u02BB\u02BA\u02C1\u02B5\u02B2));
		this.\u02B7\u02B8\u02B6\u02B5\u02C1\u02BD\u02B4\u02BE\u02B9\u02BA\u02B4.onClick.RemoveAllListeners();
		this.\u02B7\u02B8\u02B6\u02B5\u02C1\u02BD\u02B4\u02BE\u02B9\u02BA\u02B4.onClick.AddListener(new UnityAction(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BC\u02BD\u02B8\u02B2\u02C0\u02BA\u02C1\u02C0\u02BA\u02B3\u02BF));
		this.\u02BD\u02B6\u02BB\u02BD\u02B6\u02BA\u02B7\u02BD\u02B9\u02B2\u02B3.onClick.RemoveAllListeners();
		this.\u02BD\u02B6\u02BB\u02BD\u02B6\u02BA\u02B7\u02BD\u02B9\u02B2\u02B3.onClick.AddListener(new UnityAction(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02B5\u02B7\u02B5\u02B6\u02B9\u02B2\u02C1\u02B7\u02BE\u02BB\u02B5));
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.onDeselect.RemoveAllListeners();
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.onDeselect.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BB\u02BC\u02BE\u02B4\u02B7\u02B4\u02BB\u02B6\u02C1\u02C0\u02C1));
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.onSubmit.RemoveAllListeners();
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.onSubmit.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BC\u02C0\u02B2\u02C0\u02BA\u02C1\u02B5\u02B9\u02B4\u02BB\u02B4));
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.onValueChanged.RemoveAllListeners();
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.onValueChanged.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BB\u02C1\u02BE\u02B8\u02B6\u02BB\u02B9\u02BD\u02BA\u02BA\u02BC));
		this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.onDeselect.RemoveAllListeners();
		this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.onDeselect.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02B6\u02BE\u02B8\u02B9\u02C1\u02BA\u02BB\u02BB\u02BE\u02B3\u02BC));
		this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.onSubmit.RemoveAllListeners();
		this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.onSubmit.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BF\u02B8\u02B9\u02C1\u02BA\u02B6\u02BB\u02B3\u02BE\u02B2\u02C1));
		this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.onDeselect.RemoveAllListeners();
		this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.onDeselect.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02B3\u02B9\u02BE\u02B4\u02B2\u02B2\u02BB\u02B8\u02B9\u02B8\u02BF));
		this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.onSubmit.RemoveAllListeners();
		this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.onSubmit.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BA\u02C0\u02BB\u02C0\u02B8\u02B9\u02B7\u02B6\u02B2\u02BC\u02B5));
		this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.onDeselect.RemoveAllListeners();
		this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.onDeselect.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BC\u02B3\u02B5\u02B8\u02C1\u02B6\u02B5\u02C0\u02BE\u02B6\u02B3));
		this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.onSubmit.RemoveAllListeners();
		this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.onSubmit.AddListener(new UnityAction<string>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02B2\u02BE\u02BB\u02B4\u02B6\u02B9\u02BB\u02C0\u02BB\u02C1\u02B6));
		this.\u02B8\u02C1\u02B5\u02BD\u02BD\u02BE\u02B9\u02B9\u02B9\u02B2\u02BB.onValueChanged.RemoveAllListeners();
		this.\u02B8\u02C1\u02B5\u02BD\u02BD\u02BE\u02B9\u02B9\u02B9\u02B2\u02BB.onValueChanged.AddListener(new UnityAction<float>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02B3\u02BC\u02BE\u02C0\u02B7\u02B7\u02B8\u02BE\u02B9\u02B6\u02BC));
		this.\u02BF\u02B6\u02C1\u02B4\u02B3\u02B2\u02B5\u02B3\u02B3\u02B9\u02C0.onValueChanged.RemoveAllListeners();
		this.\u02BF\u02B6\u02C1\u02B4\u02B3\u02B2\u02B5\u02B3\u02B3\u02B9\u02C0.onValueChanged.AddListener(new UnityAction<float>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02B6\u02B9\u02B8\u02B4\u02BB\u02B4\u02C0\u02B6\u02C0\u02B8\u02B6));
		this.\u02BD\u02BB\u02C1\u02B6\u02BE\u02C0\u02BD\u02B5\u02B4\u02B9\u02B8.onValueChanged.RemoveAllListeners();
		this.\u02BD\u02BB\u02C1\u02B6\u02BE\u02C0\u02BD\u02B5\u02B4\u02B9\u02B8.onValueChanged.AddListener(new UnityAction<float>(u02B3_u02BB_u02BF_u02BC_u02C0_u02BB_u02C1_u02C1_u02B2_u02B5_u02BF.\u02BD\u02BA\u02C0\u02B3\u02B3\u02B6\u02B7\u02BF\u02B5\u02B6\u02C0));
	}

	[CompilerGenerated]
	private void \u02B7\u02B2\u02C1\u02B9\u02BA\u02B4\u02B8\u02B2\u02B8\u02BA\u02B9(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
	{
		this.\u02BE\u02B2\u02BE\u02C1\u02B8\u02BD\u02BA\u02BE\u02B7\u02BC\u02BE((\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 < GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2.Count) ? \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 : 0);
	}

	private void \u02BD\u02C0\u02B2\u02BD\u02B8\u02BE\u02B9\u02B9\u02BF\u02BC\u02BC(string \u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0)
	{
		if (string.IsNullOrWhiteSpace(\u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0))
		{
			return;
		}
		string text = Path.Combine(Path.Combine(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Quickplay"), \u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0 + "diff_rhythm_ghl");
		if (!File.Exists(text))
		{
			ColorManager u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE;
			string text2 = Settings.RegisterConfigFileName("" + \u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0, text);
			ColorSettings colorSettings = new ColorSettings();
			colorSettings.SetupSettings(text2);
			u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C0\u02BA\u02B8\u02BC\u02B6\u02B7\u02BD\u02B3\u02B4\u02B3\u02BC().Add(\u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0);
			u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02BC\u02BB\u02B9\u02BF\u02B7\u02C1\u02B4\u02BD\u02B3\u02B2\u02BA().Add(colorSettings);
			u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B5\u02B3\u02BB\u02BF\u02B8\u02BB\u02B7\u02C0\u02C1\u02B6\u02BC();
			this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C0\u02C1\u02B7\u02BF\u02B8\u02B9\u02B8\u02BC\u02BD\u02C1\u02BC().Select(new Func<string, TMP_Dropdown.OptionData>(ColorProfileEditor.<>c.<>9.\u02BF\u02BF\u02B5\u02B6\u02C0\u02C1\u02B9\u02BC\u02BB\u02B3\u02BE)).ToList<TMP_Dropdown.OptionData>();
			this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.value = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C0\u02BA\u02B8\u02BC\u02B6\u02B7\u02BD\u02B3\u02B4\u02B3\u02BC().IndexOf(\u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0);
			this.\u02BB\u02B4\u02BC\u02B7\u02C1\u02C0\u02BE\u02C1\u02C1\u02BD\u02BE.text = string.Empty;
		}
	}

	private void \u02C0\u02BA\u02B3\u02B4\u02B3\u02B7\u02B7\u02B6\u02B7\u02BF\u02BE(string \u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0)
	{
		if (string.IsNullOrWhiteSpace(\u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0))
		{
			return;
		}
		string text = Path.Combine(Path.Combine(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, ""), \u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0 + "Custom");
		if (!File.Exists(text))
		{
			ColorManager u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE;
			string text2 = Settings.RegisterConfigFileName("No" + \u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0, text);
			ColorSettings colorSettings = new ColorSettings();
			colorSettings.SetupSettings(text2);
			u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C0\u02BA\u02B8\u02BC\u02B6\u02B7\u02BD\u02B3\u02B4\u02B3\u02BC().Add(\u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0);
			u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2.Add(colorSettings);
			u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C1\u02BC\u02BE\u02BC\u02B7\u02BA\u02BF\u02B5\u02B5\u02B2\u02B2();
			this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C0\u02C1\u02B7\u02BF\u02B8\u02B9\u02B8\u02BC\u02BD\u02C1\u02BC().Select(new Func<string, TMP_Dropdown.OptionData>(ColorProfileEditor.<>c.<>9.\u02BF\u02BF\u02B5\u02B6\u02C0\u02C1\u02B9\u02BC\u02BB\u02B3\u02BE)).ToList<TMP_Dropdown.OptionData>();
			this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.value = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C0\u02BA\u02B8\u02BC\u02B6\u02B7\u02BD\u02B3\u02B4\u02B3\u02BC().IndexOf(\u02C0\u02BB\u02B5\u02BA\u02BB\u02BF\u02B5\u02B5\u02B8\u02B3\u02C0);
			this.\u02BB\u02B4\u02BC\u02B7\u02C1\u02C0\u02BE\u02C1\u02C1\u02BD\u02BE.text = string.Empty;
		}
	}

	private void \u02B8\u02BB\u02C0\u02BF\u02BE\u02B4\u02BF\u02BF\u02C1\u02B2\u02BE(bool \u02B2\u02B5\u02BD\u02B8\u02B6\u02B4\u02BE\u02B5\u02B8\u02B9\u02B8)
	{
		Color color = Color.white;
		if (\u02B2\u02B5\u02BD\u02B8\u02B6\u02B4\u02BE\u02B5\u02B8\u02B9\u02B8)
		{
			color = Color.HSVToRGB(this.\u02B8\u02C1\u02B5\u02BD\u02BD\u02BE\u02B9\u02B9\u02B9\u02B2\u02BB.value / 255f, this.\u02BF\u02B6\u02C1\u02B4\u02B3\u02B2\u02B5\u02B3\u02B3\u02B9\u02C0.value / 255f, this.\u02BD\u02BB\u02C1\u02B6\u02BE\u02C0\u02BD\u02B5\u02B4\u02B9\u02B8.value / 255f);
		}
		else
		{
			ColorUtility.TryParseHtmlString("#" + this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.text, out color);
		}
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.text = ColorUtility.ToHtmlStringRGB(color);
		this.\u02B6\u02B4\u02BB\u02B8\u02BF\u02B5\u02BE\u02B5\u02B7\u02B5\u02B3.color = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(color);
		this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.textComponent.color = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(color);
		float num;
		float num2;
		float num3;
		Color.RGBToHSV(color, out num, out num2, out num3);
		this.\u02BB\u02B7\u02C0\u02B2\u02B9\u02BC\u02C1\u02BC\u02BC\u02B5\u02B5.color = color;
		if (!\u02B2\u02B5\u02BD\u02B8\u02B6\u02B4\u02BE\u02B5\u02B8\u02B9\u02B8)
		{
			this.\u02B8\u02C1\u02B5\u02BD\u02BD\u02BE\u02B9\u02B9\u02B9\u02B2\u02BB.value = num * 255f;
			this.\u02BF\u02B6\u02C1\u02B4\u02B3\u02B2\u02B5\u02B3\u02B3\u02B9\u02C0.value = num2 * 255f;
			this.\u02BD\u02BB\u02C1\u02B6\u02BE\u02C0\u02BD\u02B5\u02B4\u02B9\u02B8.value = num3 * 255f;
		}
		this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9.text = this.\u02B8\u02C1\u02B5\u02BD\u02BD\u02BE\u02B9\u02B9\u02B9\u02B2\u02BB.value.ToString();
		this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA.text = this.\u02BF\u02B6\u02C1\u02B4\u02B3\u02B2\u02B5\u02B3\u02B3\u02B9\u02C0.value.ToString();
		this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2.text = this.\u02BD\u02BB\u02C1\u02B6\u02BE\u02C0\u02BD\u02B5\u02B4\u02B9\u02B8.value.ToString();
	}

	private void \u02B8\u02BE\u02B2\u02B7\u02BE\u02B4\u02B7\u02BF\u02BB\u02B7\u02B4(List<string> \u02C1\u02BC\u02B8\u02C0\u02BD\u02B5\u02B8\u02C0\u02C0\u02C1\u02BB, List<Button> \u02BB\u02BA\u02BA\u02B6\u02BB\u02B6\u02BD\u02BC\u02C0\u02BC\u02BB, string \u02BE\u02B4\u02B6\u02B7\u02BF\u02B5\u02BC\u02BC\u02B4\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.\u02BE\u02BA\u02B8\u02C1\u02C0\u02C1\u02BA\u02B9\u02B8\u02B8\u02B7, this.\u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB);
		gameObject.GetComponentsInChildren<TextMeshProUGUI>()[0].text = new string(' ', \u02C1\u02BC\u02B8\u02C0\u02BD\u02B5\u02B8\u02C0\u02C0\u02C1\u02BB.Count * 5) + LanguageManager.instance.GetString(\u02BE\u02B4\u02B6\u02B7\u02BF\u02B5\u02BC\u02BC\u02B4\u02C1\u02B5);
		\u02C1\u02BC\u02B8\u02C0\u02BD\u02B5\u02B8\u02C0\u02C0\u02C1\u02BB.Add(\u02BE\u02B4\u02B6\u02B7\u02BF\u02B5\u02BC\u02BC\u02B4\u02C1\u02B5);
		\u02BB\u02BA\u02BA\u02B6\u02BB\u02B6\u02BD\u02BC\u02C0\u02BC\u02BB.Add(gameObject.GetComponent<Button>());
	}

	public static bool \u02BF\u02BE\u02B9\u02BB\u02B2\u02BC\u02B7\u02BD\u02B2\u02B6\u02B6()
	{
		return ColorProfileEditor.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 == null || (!(ColorProfileEditor.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA == null) && ColorProfileEditor.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.activeInHierarchy);
	}

	private void \u02B6\u02B6\u02B7\u02B8\u02B7\u02C1\u02C0\u02B4\u02B6\u02BE\u02B2(string \u02B4\u02B7\u02BB\u02C1\u02C0\u02B3\u02B2\u02BC\u02B6\u02BF\u02B3)
	{
		ColorManager u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE;
		if (\u02B4\u02B7\u02BB\u02C1\u02C0\u02B3\u02B2\u02BC\u02B6\u02BF\u02B3 == u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0)
		{
			return;
		}
		Settings.DeleteFile("GameColors_" + \u02B4\u02B7\u02BB\u02C1\u02C0\u02B3\u02B2\u02BC\u02B6\u02BF\u02B3);
		ColorSettings colorSettings = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C0\u02BB\u02B2\u02B6\u02B4\u02B3\u02BF\u02B2\u02B5\u02B8\u02BA(\u02B4\u02B7\u02BB\u02C1\u02C0\u02B3\u02B2\u02BC\u02B6\u02BF\u02B3);
		u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Remove(\u02B4\u02B7\u02BB\u02C1\u02C0\u02B3\u02B2\u02BC\u02B6\u02BF\u02B3);
		u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2.Remove(colorSettings);
		u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B5\u02B3\u02BB\u02BF\u02B8\u02BB\u02B7\u02C0\u02C1\u02B6\u02BC();
		Settings.DeleteFullFileCache("GameColors_" + \u02B4\u02B7\u02BB\u02C1\u02C0\u02B3\u02B2\u02BC\u02B6\u02BF\u02B3);
		this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.value = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.IndexOf("DefaultColors");
		this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Select(new Func<string, TMP_Dropdown.OptionData>(ColorProfileEditor.<>c.<>9.\u02B7\u02BE\u02B4\u02BA\u02BB\u02B7\u02B7\u02B5\u02BF\u02BD\u02BB)).ToList<TMP_Dropdown.OptionData>();
		this.\u02BE\u02B2\u02BE\u02C1\u02B8\u02BD\u02BA\u02BE\u02B7\u02BC\u02BE(this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.value);
	}

	private void \u02B2\u02C1\u02BB\u02B6\u02B2\u02B5\u02B5\u02B7\u02B4\u02B8\u02B8(string \u02B4\u02B7\u02BB\u02C1\u02C0\u02B3\u02B2\u02BC\u02B6\u02BF\u02B3)
	{
		ColorManager u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE;
		if (\u02B4\u02B7\u02BB\u02C1\u02C0\u02B3\u02B2\u02BC\u02B6\u02BF\u02B3 == u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0)
		{
			return;
		}
		Settings.DeleteFile("Camera" + \u02B4\u02B7\u02BB\u02C1\u02C0\u02B3\u02B2\u02BC\u02B6\u02BF\u02B3);
		ColorSettings colorSettings = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C0\u02BB\u02B2\u02B6\u02B4\u02B3\u02BF\u02B2\u02B5\u02B8\u02BA(\u02B4\u02B7\u02BB\u02C1\u02C0\u02B3\u02B2\u02BC\u02B6\u02BF\u02B3);
		u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C0\u02BA\u02B8\u02BC\u02B6\u02B7\u02BD\u02B3\u02B4\u02B3\u02BC().Remove(\u02B4\u02B7\u02BB\u02C1\u02C0\u02B3\u02B2\u02BC\u02B6\u02BF\u02B3);
		u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02BC\u02BB\u02B9\u02BF\u02B7\u02C1\u02B4\u02BD\u02B3\u02B2\u02BA().Remove(colorSettings);
		u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02C1\u02BC\u02BE\u02BC\u02B7\u02BA\u02BF\u02B5\u02B5\u02B2\u02B2();
		Settings.DeleteFullFileCache("Start" + \u02B4\u02B7\u02BB\u02C1\u02C0\u02B3\u02B2\u02BC\u02B6\u02BF\u02B3);
		this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.value = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B8\u02B7\u02BF\u02C1\u02B2\u02B8\u02B6\u02B4\u02B9\u02BF\u02BB().IndexOf("Album");
		this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options = u02BD_u02BA_u02B2_u02BB_u02BC_u02C0_u02BA_u02B8_u02BE_u02BB_u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Select(new Func<string, TMP_Dropdown.OptionData>(ColorProfileEditor.<>c.<>9.\u02B7\u02BE\u02B4\u02BA\u02BB\u02B7\u02B7\u02B5\u02BF\u02BD\u02BB)).ToList<TMP_Dropdown.OptionData>();
		this.\u02BB\u02B5\u02B4\u02BB\u02BD\u02B7\u02B4\u02BF\u02C1\u02C1\u02B7(this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.value);
	}

	private void \u02BE\u02B2\u02BE\u02C1\u02B8\u02BD\u02BA\u02BE\u02B7\u02BC\u02BE(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
	{
		ColorProfileEditor.\u02BB\u02BB\u02B5\u02B8\u02B8\u02B6\u02B9\u02B8\u02B5\u02B7\u02C1 u02BB_u02BB_u02B5_u02B8_u02B8_u02B6_u02B9_u02B8_u02B5_u02B7_u02C = new ColorProfileEditor.\u02BB\u02BB\u02B5\u02B8\u02B8\u02B6\u02B9\u02B8\u02B5\u02B7\u02C1();
		u02BB_u02BB_u02B5_u02B8_u02B8_u02B6_u02B9_u02B8_u02B5_u02B7_u02C.<>4__this = this;
		this.\u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8.SetActive(true);
		this.\u02BE\u02BA\u02B8\u02C1\u02C0\u02C1\u02BA\u02B9\u02B8\u02B8\u02B7.SetActive(true);
		foreach (object obj in this.\u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB)
		{
			global::UnityEngine.Object.Destroy(((Transform)obj).gameObject);
		}
		float num = 0f;
		VerticalLayoutGroup component = this.\u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB.gameObject.GetComponent<VerticalLayoutGroup>();
		float num2 = (this.\u02BE\u02BA\u02B8\u02C1\u02C0\u02C1\u02BA\u02B9\u02B8\u02B8\u02B7.transform as RectTransform).sizeDelta.y + component.spacing;
		float num3 = (this.\u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8.transform as RectTransform).sizeDelta.y + component.spacing;
		List<string> list = new List<string>(ColorProfileEditor.\u02B8\u02BF\u02B7\u02B2\u02B9\u02B7\u02B6\u02C0\u02BB\u02B9\u02B7);
		u02BB_u02BB_u02B5_u02B8_u02B8_u02B6_u02B9_u02B8_u02B5_u02B7_u02C.colorSettings = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02C0\u02BB\u02B2\u02B6\u02B4\u02B3\u02BF\u02B2\u02B5\u02B8\u02BA(this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].text);
		Color color = new Color(1f, 1f, 1f, 0.2f);
		List<ColorGameSetting> list2 = u02BB_u02BB_u02B5_u02B8_u02B8_u02B6_u02B9_u02B8_u02B5_u02B7_u02C.colorSettings.GetType().GetFields().Where(new Func<FieldInfo, bool>(ColorProfileEditor.<>c.<>9.\u02B4\u02C1\u02BD\u02B2\u02B8\u02C0\u02B8\u02BF\u02BC\u02BA\u02BC))
			.Select(new Func<FieldInfo, ColorGameSetting>(u02BB_u02BB_u02B5_u02B8_u02B8_u02B6_u02B9_u02B8_u02B5_u02B7_u02C.\u02BA\u02BB\u02C1\u02B5\u02BF\u02C0\u02BB\u02C1\u02BC\u02BC\u02BD))
			.ToList<ColorGameSetting>();
		List<Button> list3 = new List<Button>();
		List<string> list4 = new List<string>();
		bool flag = this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].text == GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0;
		for (int i = 0; i < list.Count; i += 2)
		{
			ColorProfileEditor.\u02B2\u02BA\u02B6\u02B6\u02BA\u02B8\u02B3\u02C1\u02BF\u02BE\u02B6 u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B = new ColorProfileEditor.\u02B2\u02BA\u02B6\u02B6\u02BA\u02B8\u02B3\u02C1\u02BF\u02BE\u02B6();
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.CS$<>8__locals1 = u02BB_u02BB_u02B5_u02B8_u02B8_u02B6_u02B9_u02B8_u02B5_u02B7_u02C;
			string text = list[i];
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString = text.Split('/', StringSplitOptions.None).ToList<string>();
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.colorSetting = list2.FirstOrDefault(new Func<ColorGameSetting, bool>(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.\u02B6\u02B8\u02BE\u02BC\u02BD\u02B5\u02B5\u02B5\u02BC\u02C0\u02B8));
			if (u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString.Count > 0)
			{
				for (int j = 0; j < u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString.Count - 1; j++)
				{
					if (list4.Count < j + 1)
					{
						this.\u02B8\u02BE\u02B2\u02B7\u02BE\u02B4\u02B7\u02BF\u02BB\u02B7\u02B4(list4, list3, u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString[j]);
						num += num2;
					}
					else if (list4[j] != u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString[j])
					{
						list3 = list3.Take(j).ToList<Button>();
						list4 = list4.Take(j).ToList<string>();
						this.\u02B8\u02BE\u02B2\u02B7\u02BE\u02B4\u02B7\u02BF\u02BB\u02B7\u02B4(list4, list3, u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString[j]);
						num += num2;
					}
				}
			}
			Color color2 = Helper.HexColorToColor(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.colorSetting.CurrentValue, 1f);
			Color color3 = Helper.HexColorToColor(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.colorSetting.DefaultValue, 1f);
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8, this.\u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB);
			gameObject.GetComponent<HorizontalLayoutGroup>().padding.left = (u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString.Count - 1) * 50;
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField = gameObject.GetComponentInChildren<TMP_InputField>();
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.text = HexColor.ToHexString(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.colorSetting.CurrentValue, false);
			(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.placeholder as TextMeshProUGUI).text = HexColor.ToHexString(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.colorSetting.CurrentValue, false);
			Color color4 = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(color2);
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects = gameObject.GetComponentsInChildren<TextMeshProUGUI>();
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects[0].text = (string.IsNullOrEmpty(list[i + 1]) ? u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.colorSetting.Name : LanguageManager.instance.GetString(list[i + 1]));
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects[1].color = (u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects[2].color = (u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects[3].color = color4));
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects = gameObject.GetComponentsInChildren<Image>();
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[1].color = (u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[2].color = color2);
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[3].color = color4;
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[4].color = color3;
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[5].color = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(color3);
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.onDeselect.AddListener(new UnityAction<string>(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.\u02BF\u02B4\u02B9\u02BF\u02BB\u02B4\u02BD\u02B6\u02B2\u02BE\u02B3));
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.onSubmit.AddListener(new UnityAction<string>(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.\u02B3\u02B4\u02BB\u02B9\u02BA\u02BF\u02BA\u02BC\u02B3\u02BB\u02B3));
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.onValueChanged.AddListener(new UnityAction<string>(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.\u02BC\u02B9\u02BE\u02B4\u02B8\u02BF\u02B2\u02BE\u02C0\u02B6\u02BE));
			Button[] componentsInChildren = gameObject.GetComponentsInChildren<Button>();
			componentsInChildren[0].onClick.AddListener(new UnityAction(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.\u02BA\u02BD\u02B5\u02B2\u02B9\u02BE\u02BF\u02BE\u02B2\u02BD\u02BD));
			componentsInChildren[1].onClick.AddListener(new UnityAction(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.\u02BA\u02B6\u02C0\u02B4\u02BD\u02B9\u02BB\u02B4\u02B4\u02B5\u02BC));
			if (flag)
			{
				u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects[0].color *= color;
				u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects[1].color *= color;
				u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[3].color = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(color3) * color;
				u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[5].color = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(color3) * color;
				Button[] componentsInChildren2 = gameObject.GetComponentsInChildren<Button>();
				for (int k = 0; k < componentsInChildren2.Length; k++)
				{
					componentsInChildren2[k].interactable = false;
				}
				u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.interactable = false;
				u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.textComponent.color *= color;
			}
			num += num3;
		}
		(this.\u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB as RectTransform).sizeDelta = new Vector2((this.\u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB as RectTransform).sizeDelta.x, num);
		this.\u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8.SetActive(false);
		this.\u02BE\u02BA\u02B8\u02C1\u02C0\u02C1\u02BA\u02B9\u02B8\u02B8\u02B7.SetActive(false);
	}

	public static void \u02BE\u02B3\u02B7\u02BD\u02BA\u02BB\u02B4\u02B7\u02B5\u02B3\u02B2(\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 \u02C1\u02B8\u02B9\u02B7\u02BF\u02B5\u02BD\u02BD\u02BF\u02B3\u02BA)
	{
		ColorProfileEditor.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B2\u02BC\u02BD\u02BA\u02BF\u02B9\u02BD\u02BB\u02B5\u02BA\u02B6 = \u02C1\u02B8\u02B9\u02B7\u02BF\u02B5\u02BD\u02BD\u02BF\u02B3\u02BA;
		ColorProfileEditor.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.value = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.IndexOf(\u02C1\u02B8\u02B9\u02B7\u02BF\u02B5\u02BD\u02BD\u02BF\u02B3\u02BA.colorProfileName.CurrentValue);
		ColorProfileEditor.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA.gameObject.SetActive(true);
		Cursor.visible = true;
	}

	private void \u02BB\u02B5\u02B4\u02BB\u02BD\u02B7\u02B4\u02BF\u02C1\u02C1\u02B7(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
	{
		ColorProfileEditor.\u02BB\u02BB\u02B5\u02B8\u02B8\u02B6\u02B9\u02B8\u02B5\u02B7\u02C1 u02BB_u02BB_u02B5_u02B8_u02B8_u02B6_u02B9_u02B8_u02B5_u02B7_u02C = new ColorProfileEditor.\u02BB\u02BB\u02B5\u02B8\u02B8\u02B6\u02B9\u02B8\u02B5\u02B7\u02C1();
		u02BB_u02BB_u02B5_u02B8_u02B8_u02B6_u02B9_u02B8_u02B5_u02B7_u02C.<>4__this = this;
		this.\u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8.SetActive(false);
		this.\u02BE\u02BA\u02B8\u02C1\u02C0\u02C1\u02BA\u02B9\u02B8\u02B8\u02B7.SetActive(true);
		foreach (object obj in this.\u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB)
		{
			global::UnityEngine.Object.Destroy(((Transform)obj).gameObject);
		}
		float num = 1037f;
		VerticalLayoutGroup component = this.\u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB.gameObject.GetComponent<VerticalLayoutGroup>();
		float num2 = (this.\u02BE\u02BA\u02B8\u02C1\u02C0\u02C1\u02BA\u02B9\u02B8\u02B8\u02B7.transform as RectTransform).sizeDelta.y + component.spacing;
		float num3 = (this.\u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8.transform as RectTransform).sizeDelta.y + component.spacing;
		List<string> list = new List<string>(ColorProfileEditor.\u02B8\u02BF\u02B7\u02B2\u02B9\u02B7\u02B6\u02C0\u02BB\u02B9\u02B7);
		u02BB_u02BB_u02B5_u02B8_u02B8_u02B6_u02B9_u02B8_u02B5_u02B7_u02C.colorSettings = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B8\u02B6\u02BC\u02BF\u02C1\u02BC\u02C1\u02C1\u02B6\u02BD\u02B9(this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].text);
		Color color = new Color(171f, 1025f, 371f, 1560f);
		List<ColorGameSetting> list2 = u02BB_u02BB_u02B5_u02B8_u02B8_u02B6_u02B9_u02B8_u02B5_u02B7_u02C.colorSettings.GetType().GetFields().Where(new Func<FieldInfo, bool>(ColorProfileEditor.<>c.<>9.\u02B4\u02C1\u02BD\u02B2\u02B8\u02C0\u02B8\u02BF\u02BC\u02BA\u02BC))
			.Select(new Func<FieldInfo, ColorGameSetting>(u02BB_u02BB_u02B5_u02B8_u02B8_u02B6_u02B9_u02B8_u02B5_u02B7_u02C.\u02BA\u02BB\u02C1\u02B5\u02BF\u02C0\u02BB\u02C1\u02BC\u02BC\u02BD))
			.ToList<ColorGameSetting>();
		List<Button> list3 = new List<Button>();
		List<string> list4 = new List<string>();
		bool flag = this.\u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4.options[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].text == GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0;
		for (int i = 0; i < list.Count; i += 7)
		{
			ColorProfileEditor.\u02B2\u02BA\u02B6\u02B6\u02BA\u02B8\u02B3\u02C1\u02BF\u02BE\u02B6 u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B = new ColorProfileEditor.\u02B2\u02BA\u02B6\u02B6\u02BA\u02B8\u02B3\u02C1\u02BF\u02BE\u02B6();
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.CS$<>8__locals1 = u02BB_u02BB_u02B5_u02B8_u02B8_u02B6_u02B9_u02B8_u02B5_u02B7_u02C;
			string text = list[i];
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString = text.Split('I', StringSplitOptions.RemoveEmptyEntries).ToList<string>();
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.colorSetting = list2.FirstOrDefault(new Func<ColorGameSetting, bool>(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.\u02B6\u02B8\u02BE\u02BC\u02BD\u02B5\u02B5\u02B5\u02BC\u02C0\u02B8));
			if (u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString.Count > 1)
			{
				for (int j = 0; j < u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString.Count - 1; j++)
				{
					if (list4.Count < j + 1)
					{
						this.\u02B8\u02BE\u02B2\u02B7\u02BE\u02B4\u02B7\u02BF\u02BB\u02B7\u02B4(list4, list3, u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString[j]);
						num += num2;
					}
					else if (list4[j] != u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString[j])
					{
						list3 = list3.Take(j).ToList<Button>();
						list4 = list4.Take(j).ToList<string>();
						this.\u02B8\u02BE\u02B2\u02B7\u02BE\u02B4\u02B7\u02BF\u02BB\u02B7\u02B4(list4, list3, u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString[j]);
						num += num2;
					}
				}
			}
			Color color2 = Helper.HexColorToColor(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.colorSetting.CurrentValue, 729f);
			Color color3 = Helper.HexColorToColor(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.colorSetting.DefaultValue, 1611f);
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8, this.\u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB);
			gameObject.GetComponent<HorizontalLayoutGroup>().padding.left = (u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.splitString.Count - 1) * 17;
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField = gameObject.GetComponentInChildren<TMP_InputField>();
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.text = HexColor.ToHexString(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.colorSetting.CurrentValue, false);
			(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.placeholder as TextMeshProUGUI).text = HexColor.ToHexString(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.colorSetting.CurrentValue, true);
			Color color4 = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(color2);
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects = gameObject.GetComponentsInChildren<TextMeshProUGUI>();
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects[0].text = (string.IsNullOrEmpty(list[i + 0]) ? u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.colorSetting.Name : LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().GetString(list[i + 1]));
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects[1].color = (u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects[6].color = (u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects[7].color = color4));
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects = gameObject.GetComponentsInChildren<Image>();
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[0].color = (u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[6].color = color2);
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[5].color = color4;
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[3].color = color3;
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[4].color = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(color3);
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.onDeselect.AddListener(new UnityAction<string>(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.\u02BF\u02B4\u02B9\u02BF\u02BB\u02B4\u02BD\u02B6\u02B2\u02BE\u02B3));
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.onSubmit.AddListener(new UnityAction<string>(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.\u02B3\u02B4\u02BB\u02B9\u02BA\u02BF\u02BA\u02BC\u02B3\u02BB\u02B3));
			u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.onValueChanged.AddListener(new UnityAction<string>(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.\u02BC\u02B9\u02BE\u02B4\u02B8\u02BF\u02B2\u02BE\u02C0\u02B6\u02BE));
			Button[] componentsInChildren = gameObject.GetComponentsInChildren<Button>();
			componentsInChildren[0].onClick.AddListener(new UnityAction(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.\u02BA\u02BD\u02B5\u02B2\u02B9\u02BE\u02BF\u02BE\u02B2\u02BD\u02BD));
			componentsInChildren[1].onClick.AddListener(new UnityAction(u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.\u02BA\u02B6\u02C0\u02B4\u02BD\u02B9\u02BB\u02B4\u02B4\u02B5\u02BC));
			if (flag)
			{
				u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects[0].color *= color;
				u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.textObjects[0].color *= color;
				u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[6].color = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(color3) * color;
				u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.imageObjects[4].color = this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(color3) * color;
				Button[] componentsInChildren2 = gameObject.GetComponentsInChildren<Button>();
				for (int k = 0; k < componentsInChildren2.Length; k += 0)
				{
					componentsInChildren2[k].interactable = true;
				}
				u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.interactable = false;
				u02B2_u02BA_u02B6_u02B6_u02BA_u02B8_u02B3_u02C1_u02BF_u02BE_u02B.inputField.textComponent.color *= color;
			}
			num += num3;
		}
		(this.\u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB as RectTransform).sizeDelta = new Vector2((this.\u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB as RectTransform).sizeDelta.x, num);
		this.\u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8.SetActive(false);
		this.\u02BE\u02BA\u02B8\u02C1\u02C0\u02C1\u02BA\u02B9\u02B8\u02B8\u02B7.SetActive(true);
	}

	private void OnDisable()
	{
		ColorProfileEditor.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6 = null;
	}

	[CompilerGenerated]
	private void \u02B8\u02BF\u02BD\u02B8\u02B3\u02BC\u02C1\u02BD\u02B4\u02B7\u02B3()
	{
		this.\u02BA\u02BB\u02B4\u02B7\u02BB\u02B4\u02B3\u02B2\u02BB\u02C0\u02B7(this.\u02BB\u02B4\u02BC\u02B7\u02C1\u02C0\u02BE\u02C1\u02C1\u02BD\u02BE.text);
	}

	private void \u02BF\u02B9\u02B9\u02C0\u02BE\u02B6\u02C0\u02B2\u02B5\u02B8\u02BF(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		this.\u02BC\u02B4\u02B5\u02BA\u02BD\u02C0\u02B9\u02B5\u02C1\u02B9\u02B3(\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6);
	}

	public GameObject \u02BE\u02BA\u02B8\u02C1\u02C0\u02C1\u02BA\u02B9\u02B8\u02B8\u02B7;

	public GameObject \u02B8\u02B9\u02BD\u02BC\u02BB\u02BA\u02B5\u02B8\u02B7\u02B7\u02B8;

	public TMP_Dropdown \u02BC\u02BD\u02B8\u02B4\u02BA\u02B9\u02B6\u02B9\u02BE\u02B6\u02B4;

	public TMP_InputField \u02BB\u02B4\u02BC\u02B7\u02C1\u02C0\u02BE\u02C1\u02C1\u02BD\u02BE;

	public Button \u02B7\u02BE\u02BE\u02B8\u02B7\u02BF\u02B8\u02BE\u02B4\u02BA\u02B2;

	public Button \u02BC\u02C1\u02BC\u02BA\u02BF\u02C1\u02B9\u02BD\u02BD\u02B5\u02B6;

	public GameObject \u02BB\u02B5\u02C0\u02B9\u02C1\u02B8\u02BE\u02B9\u02BE\u02BC\u02B9;

	public Button \u02BD\u02B6\u02BB\u02BD\u02B6\u02BA\u02B7\u02BD\u02B9\u02B2\u02B3;

	public Button \u02B7\u02B8\u02B6\u02B5\u02C1\u02BD\u02B4\u02BE\u02B9\u02BA\u02B4;

	public Button \u02BE\u02B7\u02B5\u02BC\u02BF\u02B8\u02B5\u02BA\u02BC\u02B6\u02BB;

	public TMP_InputField \u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9;

	public TMP_InputField \u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA;

	public TMP_InputField \u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2;

	public TMP_InputField \u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9;

	public Slider \u02B8\u02C1\u02B5\u02BD\u02BD\u02BE\u02B9\u02B9\u02B9\u02B2\u02BB;

	public Slider \u02BF\u02B6\u02C1\u02B4\u02B3\u02B2\u02B5\u02B3\u02B3\u02B9\u02C0;

	public Slider \u02BD\u02BB\u02C1\u02B6\u02BE\u02C0\u02BD\u02B5\u02B4\u02B9\u02B8;

	public Image \u02B3\u02B7\u02B5\u02BA\u02B2\u02B3\u02BD\u02BC\u02BF\u02C0\u02BB;

	public Image \u02B5\u02BB\u02C0\u02B8\u02B6\u02C1\u02BD\u02B5\u02C0\u02BA\u02B6;

	public Image \u02BE\u02B2\u02B9\u02B8\u02B9\u02B6\u02B6\u02B8\u02C0\u02B8\u02BF;

	public Image \u02BB\u02B7\u02C0\u02B2\u02B9\u02BC\u02C1\u02BC\u02BC\u02B5\u02B5;

	public Image \u02B5\u02BF\u02BD\u02BA\u02B2\u02B6\u02BA\u02C1\u02B2\u02B7\u02B5;

	public TextMeshProUGUI \u02B6\u02B4\u02BB\u02B8\u02BF\u02B5\u02BE\u02B5\u02B7\u02B5\u02B3;

	public TextMeshProUGUI \u02BB\u02C0\u02BE\u02B2\u02BE\u02BC\u02B2\u02B9\u02B9\u02BC\u02BC;

	public Button \u02B8\u02C0\u02B3\u02B2\u02BE\u02C0\u02B2\u02B6\u02BF\u02B5\u02BE;

	public Canvas \u02BA\u02B8\u02BC\u02BE\u02B6\u02B5\u02B3\u02B2\u02BD\u02B6\u02BA;

	public Transform \u02B6\u02B7\u02C0\u02BC\u02B7\u02BB\u02B6\u02B4\u02B6\u02B7\u02BB;

	private static ColorProfileEditor \u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6;

	private \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 \u02B2\u02BC\u02BD\u02BA\u02BF\u02B9\u02BD\u02BB\u02B5\u02BA\u02B6;

	private static readonly string[] \u02B8\u02BF\u02B7\u02B2\u02B9\u02B7\u02B6\u02C0\u02BB\u02B9\u02B7 = new string[]
	{
		"Guitar/Notes/note_green", "Green Note", "Guitar/Notes/note_red", "Red Note", "Guitar/Notes/note_yellow", "Yellow Note", "Guitar/Notes/note_blue", "Blue Note", "Guitar/Notes/note_orange", "Orange Note",
		"Guitar/Notes/note_open", "Open Note", "Guitar/Notes/note_anim_green", "Green Note Animation", "Guitar/Notes/note_anim_red", "Red Note Animation", "Guitar/Notes/note_anim_yellow", "Yellow Note Animation", "Guitar/Notes/note_anim_blue", "Blue Note Animation",
		"Guitar/Notes/note_anim_orange", "Orange Note Animation", "Guitar/Notes/note_anim_open", "Open Note Animation", "Guitar/Notes/StarPower/note_sp_phrase", "Note Starpower Phrase", "Guitar/Notes/StarPower/note_sp_phrase_active", "Note Starpower Active Phrase", "Guitar/Notes/StarPower/note_sp_active", "Note Starpower Active",
		"Guitar/Notes/StarPower/note_anim_sp_phrase", "Animation Starpower Phrase", "Guitar/Notes/StarPower/note_anim_sp_phrase_active", "Animation Starpower Active Phrase", "Guitar/Notes/StarPower/note_anim_sp_active", "Animation Starpower Active", "Guitar/Sustains/sustain_green", "Green Sustain", "Guitar/Sustains/sustain_red", "Red Sustain",
		"Guitar/Sustains/sustain_yellow", "Yellow Sustain", "Guitar/Sustains/sustain_blue", "Blue Sustain", "Guitar/Sustains/sustain_orange", "Orange Sustain", "Guitar/Sustains/sustain_open", "Open Sustain", "Guitar/Sustains/StarPower/sustain_sp_phrase", "Sustain Starpower Phrase",
		"Guitar/Sustains/StarPower/sustain_sp_phrase_active", "Sustain Starpower Active Phrase", "Guitar/Sustains/StarPower/sustain_sp_active", "Sustain Starpower Active", "Guitar/StrikeLine/striker_base_green", "StrikeLine Base Green", "Guitar/StrikeLine/striker_base_red", "StrikeLine Base Red", "Guitar/StrikeLine/striker_base_yellow", "StrikeLine Base Yellow",
		"Guitar/StrikeLine/striker_base_blue", "StrikeLine Base Blue", "Guitar/StrikeLine/striker_base_orange", "StrikeLine Base Orange", "Guitar/StrikeLine/striker_head_light_green", "StrikeLine Top Light Green", "Guitar/StrikeLine/striker_head_light_red", "StrikeLine Top Light Red", "Guitar/StrikeLine/striker_head_light_yellow", "StrikeLine Top Light Yellow",
		"Guitar/StrikeLine/striker_head_light_blue", "StrikeLine Top Light Blue", "Guitar/StrikeLine/striker_head_light_orange", "StrikeLine Top Light Orange", "Guitar/StrikeLine/striker_head_light_open", "StrikeLine Top Light Open", "Guitar/StrikeLine/striker_head_cover_green", "StrikeLine Head Cover Green", "Guitar/StrikeLine/striker_head_cover_red", "StrikeLine Head Cover Red",
		"Guitar/StrikeLine/striker_head_cover_yellow", "StrikeLine Head Cover Yellow", "Guitar/StrikeLine/striker_head_cover_blue", "StrikeLine Head Cover Blue", "Guitar/StrikeLine/striker_head_cover_orange", "StrikeLine Head Cover Orange", "Guitar/StrikeLine/striker_cover_green", "StrikeLine Cover Green", "Guitar/StrikeLine/striker_cover_red", "StrikeLine Cover Red",
		"Guitar/StrikeLine/striker_cover_yellow", "StrikeLine Cover Yellow", "Guitar/StrikeLine/striker_cover_blue", "StrikeLine Cover Blue", "Guitar/StrikeLine/striker_cover_orange", "StrikeLine Cover Orange", "Drums/Notes/note_kick", "Kick Note", "Drums/Notes/note_anim_kick", "Kick Note Animation",
		"Drums/Notes/StarPower/note_kick_sp_phrase", "Kick Starpower Phrase", "Drums/Notes/StarPower/note_kick_sp_phrase_active", "Kick Starpower Active Phrase", "Drums/Notes/StarPower/note_kick_sp_active", "Kick Starpower Active", "Drums/Notes/StarPower/note_anim_kick_sp_phrase", "Kick Note Animation Starpower Phrase", "Drums/Notes/StarPower/note_anim_kick_sp_phrase_active", "Kick Note Animation Starpower Active Phrase",
		"Drums/Notes/StarPower/note_anim_kick_sp_active", "Kick Note Animation Starpower Active", "Drums/Notes/StarPower/note_overlay_kick_sp_phrase", "Kick Note Overlay Starpower Phrase", "Drums/Notes/Cymbals/cym_red", "Red Cymbal", "Drums/Notes/Cymbals/cym_yellow", "Yellow Cymbal", "Drums/Notes/Cymbals/cym_blue", "Blue Cymbal",
		"Drums/Notes/Cymbals/cym_green", "Green Cymbal", "Drums/Notes/Cymbals/cym_anim_red", "Red Cymbal Animation", "Drums/Notes/Cymbals/cym_anim_yellow", "Yellow Cymbal Animation", "Drums/Notes/Cymbals/cym_anim_blue", "Blue Cymbal Animation", "Drums/Notes/Cymbals/cym_anim_green", "Green Cymbal Animation",
		"Drums/Notes/Cymbals/StarPower/cym_sp_phrase", "Cymbal Starpower Phrase", "Drums/Notes/Cymbals/StarPower/cym_sp_phrase_active", "Cymbal Starpower Active Phrase", "Drums/Notes/Cymbals/StarPower/cym_sp_active", "Cymbal Starpower Active", "Drums/Notes/Cymbals/StarPower/cym_anim_sp_phrase", "Cymbal Animation Starpower Phrase", "Drums/Notes/Cymbals/StarPower/cym_anim_sp_phrase_active", "Cymbal Animation Starpower Active Phrase",
		"Drums/Notes/Cymbals/StarPower/cym_anim_sp_active", "Cymbal Animation Starpower Active", "Drums/Notes/Toms/tom_red", "Red Tom", "Drums/Notes/Toms/tom_yellow", "Yellow Tom", "Drums/Notes/Toms/tom_blue", "Blue Tom", "Drums/Notes/Toms/tom_green", "Green Tom",
		"Drums/Notes/Toms/tom_anim_red", "Red Tom Animation", "Drums/Notes/Toms/tom_anim_yellow", "Yellow Tom Animation", "Drums/Notes/Toms/tom_anim_blue", "Blue Tom Animation", "Drums/Notes/Toms/tom_anim_green", "Green Tom Animation", "Drums/Notes/Toms/StarPower/tom_sp_phrase", "Tom Starpower Phrase",
		"Drums/Notes/Toms/StarPower/tom_sp_phrase_active", "Tom Starpower Active Phrase", "Drums/Notes/Toms/StarPower/tom_sp_active", "Tom Starpower Active", "Drums/Notes/Toms/StarPower/tom_anim_sp_phrase", "Tom Animation Starpower Phrase", "Drums/Notes/Toms/StarPower/tom_anim_sp_phrase_active", "Tom Animation Starpower Active Phrase", "Drums/Notes/Toms/StarPower/tom_anim_sp_active", "Tom Animation Starpower Active",
		"Drums/StrikeLine/drums_striker_base_red", "StrikeLine Base Red ", "Drums/StrikeLine/drums_striker_base_yellow", "StrikeLine Base Yellow", "Drums/StrikeLine/drums_striker_base_blue", "StrikeLine Base Blue", "Drums/StrikeLine/drums_striker_base_green", "StrikeLine Base Green", "Drums/StrikeLine/drums_striker_head_light_kick", "StrikeLine Top Light Kick",
		"Drums/StrikeLine/drums_striker_head_light_red", "StrikeLine Top Light Red", "Drums/StrikeLine/drums_striker_head_light_yellow", "StrikeLine Top Light Yellow", "Drums/StrikeLine/drums_striker_head_light_blue", "StrikeLine Top Light Blue", "Drums/StrikeLine/drums_striker_head_light_green", "StrikeLine Top Light Green", "Drums/StrikeLine/drums_striker_head_cover_red", "StrikeLine Top Cover Red",
		"Drums/StrikeLine/drums_striker_head_cover_yellow", "StrikeLine Top Cover Yellow", "Drums/StrikeLine/drums_striker_head_cover_blue", "StrikeLine Top Cover Blue", "Drums/StrikeLine/drums_striker_head_cover_green", "StrikeLine Top Cover Green", "Drums/StrikeLine/drums_striker_cover_red", "StrikeLine Cover Red", "Drums/StrikeLine/drums_striker_cover_yellow", "StrikeLine Cover Yellow",
		"Drums/StrikeLine/drums_striker_cover_blue", "StrikeLine Cover Blue", "Drums/StrikeLine/drums_striker_cover_green", "StrikeLine Cover Green", "SixFret/Notes/sf_note_black_left", "Left Black Note", "SixFret/Notes/sf_note_black_mid", "Middle Black Note", "SixFret/Notes/sf_note_black_right", "Right Black Note",
		"SixFret/Notes/sf_note_white_left", "Left White Note", "SixFret/Notes/sf_note_white_mid", "Middle White Note", "SixFret/Notes/sf_note_white_right", "Right White Note", "SixFret/Notes/sf_note_open", "Open Note", "SixFret/Notes/sf_note_hopo", "HOPO Note",
		"SixFret/Notes/StarPower/sf_note_sp_phrase", "Starpower Phrase", "SixFret/Notes/StarPower/sf_note_sp_phrase_active", "Starpower Active Phrase", "SixFret/Notes/StarPower/sf_note_sp_active", "Starpower Active", "SixFret/Notes/Taps/sf_note_tap_black_left", "Left Black Tap Note", "SixFret/Notes/Taps/sf_note_tap_black_mid", "Middle Black Tap Note",
		"SixFret/Notes/Taps/sf_note_tap_black_right", "Right Black Tap Note", "SixFret/Notes/Taps/sf_note_tap_white_left", "Left White Tap Note", "SixFret/Notes/Taps/sf_note_tap_white_mid", "Middle White Tap Note", "SixFret/Notes/Taps/sf_note_tap_white_right", "Right White Tap Note", "SixFret/Notes/Taps/sf_note_tap_open", "Open Tap Note",
		"SixFret/Sustains/sf_sustain_left", "Left Sustain", "SixFret/Sustains/sf_sustain_mid", "Middle Sustain", "SixFret/Sustains/sf_sustain_right", "Right Sustain", "SixFret/Sustains/sf_sustain_open", "Open Sustain", "SixFret/Sustains/StarPower/sf_sustain_sp_phrase", "Sustain Starpower Phrase",
		"SixFret/Sustains/StarPower/sf_sustain_sp_phrase_active", "Sustain Starpower Active Phrase", "SixFret/Sustains/StarPower/sf_sustain_sp_active", "Sustain Starpower Active", "SixFret/StrikeLine/sf_striker_base_black_left", "StrikeLine Base Left Black", "SixFret/StrikeLine/sf_striker_base_black_mid", "StrikeLine Base Middle Black", "SixFret/StrikeLine/sf_striker_base_black_right", "StrikeLine Base Right Black",
		"SixFret/StrikeLine/sf_striker_base_white_left", "StrikeLine Base Left White", "SixFret/StrikeLine/sf_striker_base_white_mid", "StrikeLine Base Middle White", "SixFret/StrikeLine/sf_striker_base_white_right", "StrikeLine Base Right White", "Other/ComboBar/combo_one", "Combo 1x", "Other/ComboBar/combo_two", "Combo 2x",
		"Other/ComboBar/combo_two_glow", "Combo 2x Glow", "Other/ComboBar/combo_three", "Combo 3x", "Other/ComboBar/combo_three_glow", "Combo 3x Glow", "Other/ComboBar/combo_four", "Combo 4x", "Other/ComboBar/combo_four_glow", "Combo 4x Glow",
		"Other/ComboBar/combo_sp_active", "Combo Starpower Active", "Other/ComboBar/combo_sp_active_glow", "Combo Starpower Active Glow", "Other/Effects/striker_hit_particles", "StrikeLine Hit Particles", "Other/Effects/striker_hit_particles_sp_active", "StrikeLine Hit Particles Starpower Active", "Other/Effects/striker_hit_flame", "StrikeLine Hit Flame",
		"Other/Effects/striker_hit_flame_sp_active", "StrikeLine Hit Flame Starpower Active", "Other/Effects/striker_hit_flame_kick", "StrikeLine Kick Flame", "Other/Effects/striker_hit_flame_open", "StrikeLine Open Flame", "Other/Effects/striker_hold_spark", "StrikeLine Hold Spark", "Other/Effects/striker_hold_spark_sp_active", "StrikeLine Hold Spark Starpower Active",
		"Other/Effects/general_sp", "General Starpower", "Other/Effects/general_sp_active", "General Starpower Active", "Other/Effects/sp_bar_color", "Starpower Bar Color", "Other/Effects/sp_bar_elec", "Starpower Electricity Color", "Other/Effects/sp_bar_arrow", "Starpower Bar Indicator",
		"Other/Effects/sp_act_flash", "Starpower Action Flash", "Other/Effects/sp_act_animation", "Starpower Action Animation"
	};

	[CompilerGenerated]
	private sealed class \u02B3\u02BB\u02BF\u02BC\u02C0\u02BB\u02C1\u02C1\u02B2\u02B5\u02BF
	{
		internal void \u02BA\u02BB\u02B7\u02B8\u02B4\u02B8\u02BB\u02BA\u02C1\u02B5\u02B2()
		{
			this.<>4__this.\u02BB\u02B5\u02C0\u02B9\u02C1\u02B8\u02BE\u02B9\u02BE\u02BC\u02B9.SetActive(false);
		}

		internal void \u02BC\u02BD\u02B8\u02B2\u02C0\u02BA\u02C1\u02C0\u02BA\u02B3\u02BF()
		{
			this.colorGameSetting.CurrentValue = HexColor.FromHexString("#" + this.<>4__this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.text);
			Settings.Commit(true);
			this.inputButtonImage.color = Helper.HexColorToColor(this.colorGameSetting.CurrentValue, 1f);
			this.inputButtonIcon.color = this.<>4__this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(this.inputButtonImage.color);
			this.inputText.gameObject.GetComponent<Image>().color = this.inputButtonImage.color;
			this.inputText.text = this.<>4__this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.text;
			(this.inputText.placeholder as TextMeshProUGUI).text = this.<>4__this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.text;
			this.inputText.textComponent.color = this.<>4__this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(this.inputButtonImage.color);
			(this.inputText.placeholder as TextMeshProUGUI).color = this.inputText.textComponent.color;
			this.<>4__this.\u02BB\u02B5\u02C0\u02B9\u02C1\u02B8\u02BE\u02B9\u02BE\u02BC\u02B9.SetActive(false);
		}

		internal void \u02B5\u02B7\u02B5\u02B6\u02B9\u02B2\u02C1\u02B7\u02BE\u02BB\u02B5()
		{
			string text = HexColor.ToHexString(this.colorGameSetting.DefaultValue, false);
			(this.<>4__this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.placeholder as TextMeshProUGUI).text = text;
			this.<>4__this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9.text = text;
			this.<>4__this.\u02B8\u02BB\u02C0\u02BF\u02BE\u02B4\u02BF\u02BF\u02C1\u02B2\u02BE(false);
		}

		internal void \u02BB\u02BC\u02BE\u02B4\u02B7\u02B4\u02BB\u02B6\u02C1\u02C0\u02C1(string value)
		{
			this.<>4__this.\u02B3\u02B3\u02B2\u02BE\u02B7\u02B8\u02B2\u02BA\u02B9\u02B8\u02B9(this.<>4__this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9, value, true, null);
		}

		internal void \u02BC\u02C0\u02B2\u02C0\u02BA\u02C1\u02B5\u02B9\u02B4\u02BB\u02B4(string value)
		{
			this.<>4__this.\u02B3\u02B3\u02B2\u02BE\u02B7\u02B8\u02B2\u02BA\u02B9\u02B8\u02B9(this.<>4__this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9, value, true, null);
		}

		internal void \u02BB\u02C1\u02BE\u02B8\u02B6\u02BB\u02B9\u02BD\u02BA\u02BA\u02BC(string value)
		{
			this.<>4__this.\u02B3\u02B3\u02B2\u02BE\u02B7\u02B8\u02B2\u02BA\u02B9\u02B8\u02B9(this.<>4__this.\u02BE\u02BA\u02B8\u02B4\u02BD\u02BF\u02B2\u02B8\u02B6\u02B9\u02B9, value, false, null);
		}

		internal void \u02B6\u02BE\u02B8\u02B9\u02C1\u02BA\u02BB\u02BB\u02BE\u02B3\u02BC(string numString)
		{
			this.<>4__this.\u02B5\u02C1\u02B9\u02BF\u02BA\u02BB\u02B2\u02BD\u02B7\u02C1\u02B4(this.<>4__this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9, this.<>4__this.\u02B8\u02C1\u02B5\u02BD\u02BD\u02BE\u02B9\u02B9\u02B9\u02B2\u02BB, numString, true);
		}

		internal void \u02BF\u02B8\u02B9\u02C1\u02BA\u02B6\u02BB\u02B3\u02BE\u02B2\u02C1(string numString)
		{
			this.<>4__this.\u02B5\u02C1\u02B9\u02BF\u02BA\u02BB\u02B2\u02BD\u02B7\u02C1\u02B4(this.<>4__this.\u02BE\u02C1\u02B4\u02B6\u02B9\u02BF\u02BF\u02BE\u02B8\u02BD\u02B9, this.<>4__this.\u02B8\u02C1\u02B5\u02BD\u02BD\u02BE\u02B9\u02B9\u02B9\u02B2\u02BB, numString, true);
		}

		internal void \u02B3\u02B9\u02BE\u02B4\u02B2\u02B2\u02BB\u02B8\u02B9\u02B8\u02BF(string numString)
		{
			this.<>4__this.\u02B5\u02C1\u02B9\u02BF\u02BA\u02BB\u02B2\u02BD\u02B7\u02C1\u02B4(this.<>4__this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA, this.<>4__this.\u02BF\u02B6\u02C1\u02B4\u02B3\u02B2\u02B5\u02B3\u02B3\u02B9\u02C0, numString, true);
		}

		internal void \u02BA\u02C0\u02BB\u02C0\u02B8\u02B9\u02B7\u02B6\u02B2\u02BC\u02B5(string numString)
		{
			this.<>4__this.\u02B5\u02C1\u02B9\u02BF\u02BA\u02BB\u02B2\u02BD\u02B7\u02C1\u02B4(this.<>4__this.\u02B3\u02B8\u02B7\u02BC\u02C1\u02B6\u02C1\u02BA\u02B5\u02B8\u02BA, this.<>4__this.\u02BF\u02B6\u02C1\u02B4\u02B3\u02B2\u02B5\u02B3\u02B3\u02B9\u02C0, numString, true);
		}

		internal void \u02BC\u02B3\u02B5\u02B8\u02C1\u02B6\u02B5\u02C0\u02BE\u02B6\u02B3(string numString)
		{
			this.<>4__this.\u02B5\u02C1\u02B9\u02BF\u02BA\u02BB\u02B2\u02BD\u02B7\u02C1\u02B4(this.<>4__this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2, this.<>4__this.\u02BD\u02BB\u02C1\u02B6\u02BE\u02C0\u02BD\u02B5\u02B4\u02B9\u02B8, numString, true);
		}

		internal void \u02B2\u02BE\u02BB\u02B4\u02B6\u02B9\u02BB\u02C0\u02BB\u02C1\u02B6(string numString)
		{
			this.<>4__this.\u02B5\u02C1\u02B9\u02BF\u02BA\u02BB\u02B2\u02BD\u02B7\u02C1\u02B4(this.<>4__this.\u02B4\u02B3\u02B7\u02B9\u02C1\u02BA\u02B7\u02BD\u02BF\u02B9\u02B2, this.<>4__this.\u02BD\u02BB\u02C1\u02B6\u02BE\u02C0\u02BD\u02B5\u02B4\u02B9\u02B8, numString, true);
		}

		internal void \u02B3\u02BC\u02BE\u02C0\u02B7\u02B7\u02B8\u02BE\u02B9\u02B6\u02BC(float value)
		{
			this.<>4__this.\u02B8\u02BB\u02C0\u02BF\u02BE\u02B4\u02BF\u02BF\u02C1\u02B2\u02BE(true);
		}

		internal void \u02B6\u02B9\u02B8\u02B4\u02BB\u02B4\u02C0\u02B6\u02C0\u02B8\u02B6(float value)
		{
			this.<>4__this.\u02B8\u02BB\u02C0\u02BF\u02BE\u02B4\u02BF\u02BF\u02C1\u02B2\u02BE(true);
		}

		internal void \u02BD\u02BA\u02C0\u02B3\u02B3\u02B6\u02B7\u02BF\u02B5\u02B6\u02C0(float value)
		{
			this.<>4__this.\u02B8\u02BB\u02C0\u02BF\u02BE\u02B4\u02BF\u02BF\u02C1\u02B2\u02BE(true);
		}

		public ColorProfileEditor <>4__this;

		public ColorGameSetting colorGameSetting;

		public Image inputButtonImage;

		public Image inputButtonIcon;

		public TMP_InputField inputText;
	}

	[CompilerGenerated]
	private sealed class \u02BB\u02BB\u02B5\u02B8\u02B8\u02B6\u02B9\u02B8\u02B5\u02B7\u02C1
	{
		internal ColorGameSetting \u02BA\u02BB\u02C1\u02B5\u02BF\u02C0\u02BB\u02C1\u02BC\u02BC\u02BD(FieldInfo Item)
		{
			return Item.GetValue(this.colorSettings) as ColorGameSetting;
		}

		public ColorSettings colorSettings;

		public ColorProfileEditor <>4__this;
	}

	[CompilerGenerated]
	private sealed class \u02B2\u02BA\u02B6\u02B6\u02BA\u02B8\u02B3\u02C1\u02BF\u02BE\u02B6
	{
		internal bool \u02B6\u02B8\u02BE\u02BC\u02BD\u02B5\u02B5\u02B5\u02BC\u02C0\u02B8(ColorGameSetting Setting)
		{
			return Setting.Name == this.splitString.Last<string>();
		}

		internal void \u02BF\u02B4\u02B9\u02BF\u02BB\u02B4\u02BD\u02B6\u02B2\u02BE\u02B3(string value)
		{
			if (this.CS$<>8__locals1.<>4__this.\u02B3\u02B3\u02B2\u02BE\u02B7\u02B8\u02B2\u02BA\u02B9\u02B8\u02B9(this.inputField, value, true, this.colorSetting))
			{
				Color color = this.CS$<>8__locals1.<>4__this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(Helper.HexColorToColor(this.colorSetting.CurrentValue, 1f));
				this.imageObjects[1].color = (this.imageObjects[2].color = Helper.HexColorToColor(this.colorSetting.CurrentValue, 1f));
				this.textObjects[1].color = (this.textObjects[2].color = (this.textObjects[3].color = (this.imageObjects[3].color = color)));
			}
		}

		internal void \u02B3\u02B4\u02BB\u02B9\u02BA\u02BF\u02BA\u02BC\u02B3\u02BB\u02B3(string value)
		{
			if (this.CS$<>8__locals1.<>4__this.\u02B3\u02B3\u02B2\u02BE\u02B7\u02B8\u02B2\u02BA\u02B9\u02B8\u02B9(this.inputField, value, true, this.colorSetting))
			{
				Color color = this.CS$<>8__locals1.<>4__this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(Helper.HexColorToColor(this.colorSetting.CurrentValue, 1f));
				this.imageObjects[1].color = (this.imageObjects[2].color = Helper.HexColorToColor(this.colorSetting.CurrentValue, 1f));
				this.textObjects[1].color = (this.textObjects[2].color = (this.textObjects[3].color = (this.imageObjects[3].color = color)));
			}
		}

		internal void \u02BC\u02B9\u02BE\u02B4\u02B8\u02BF\u02B2\u02BE\u02C0\u02B6\u02BE(string value)
		{
			if (this.CS$<>8__locals1.<>4__this.\u02B3\u02B3\u02B2\u02BE\u02B7\u02B8\u02B2\u02BA\u02B9\u02B8\u02B9(this.inputField, value, false, this.colorSetting))
			{
				Color color = this.CS$<>8__locals1.<>4__this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(Helper.HexColorToColor(this.colorSetting.CurrentValue, 1f));
				this.imageObjects[1].color = (this.imageObjects[2].color = Helper.HexColorToColor(this.colorSetting.CurrentValue, 1f));
				this.textObjects[1].color = (this.textObjects[2].color = (this.textObjects[3].color = (this.imageObjects[3].color = color)));
			}
		}

		internal void \u02BA\u02BD\u02B5\u02B2\u02B9\u02BE\u02BF\u02BE\u02B2\u02BD\u02BD()
		{
			this.CS$<>8__locals1.<>4__this.\u02B2\u02B9\u02BB\u02BD\u02B6\u02B4\u02BC\u02B3\u02B6\u02BC\u02B3(this.colorSetting, this.imageObjects[2], this.imageObjects[3], this.inputField);
		}

		internal void \u02BA\u02B6\u02C0\u02B4\u02BD\u02B9\u02BB\u02B4\u02B4\u02B5\u02BC()
		{
			this.colorSetting.CurrentValue = this.colorSetting.DefaultValue;
			Settings.Commit(true);
			this.imageObjects[1].color = Helper.HexColorToColor(this.colorSetting.CurrentValue, 1f);
			Color color = this.CS$<>8__locals1.<>4__this.\u02BF\u02C0\u02BA\u02B8\u02B6\u02BF\u02BF\u02B4\u02BB\u02BF\u02C1(this.imageObjects[1].color);
			this.textObjects[1].color = color;
			this.textObjects[2].color = color;
			this.textObjects[3].color = color;
			this.inputField.text = HexColor.ToHexString(this.colorSetting.CurrentValue, false);
			(this.inputField.placeholder as TextMeshProUGUI).text = this.inputField.text;
		}

		public List<string> splitString;

		public TMP_InputField inputField;

		public ColorGameSetting colorSetting;

		public Image[] imageObjects;

		public TextMeshProUGUI[] textObjects;

		public ColorProfileEditor.\u02BB\u02BB\u02B5\u02B8\u02B8\u02B6\u02B9\u02B8\u02B5\u02B7\u02C1 CS$<>8__locals1;
	}
}
