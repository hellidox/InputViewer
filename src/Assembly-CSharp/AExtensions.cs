﻿using System;
using System.Linq;
using StrikeCore;
using TMPro;
using UnityEngine;

public static class AExtensions
{
	public static byte[] ToByteArray(this char[] src)
	{
		return src.Select((char x) => (byte)x).ToArray<byte>();
	}

	public static byte[] ToByteArray(this string src)
	{
		return (from x in src.ToCharArray()
			select (byte)x).ToArray<byte>();
	}

	public static TextMeshProUGUI Duplicate(this TextMeshProUGUI original)
	{
		if (original == null)
		{
			return null;
		}
		GameObject gameObject = new GameObject("copy");
		gameObject.transform.SetParent(original.transform.parent, false);
		TextMeshProUGUI textMeshProUGUI = gameObject.AddComponent<TextMeshProUGUI>();
		textMeshProUGUI.text = original.text;
		textMeshProUGUI.font = original.font;
		textMeshProUGUI.fontSize = original.fontSize;
		textMeshProUGUI.color = original.color;
		textMeshProUGUI.alignment = original.alignment;
		textMeshProUGUI.raycastTarget = original.raycastTarget;
		RectTransform component = original.GetComponent<RectTransform>();
		RectTransform component2 = textMeshProUGUI.GetComponent<RectTransform>();
		component2.sizeDelta = component.sizeDelta;
		component2.localPosition = component.localPosition;
		component2.localScale = component.localScale;
		return textMeshProUGUI;
	}

	public static Color Color(this HexColor src)
	{
		return new Color((float)src.Red / 255f, (float)src.Green / 255f, (float)src.Blue / 255f);
	}
}
