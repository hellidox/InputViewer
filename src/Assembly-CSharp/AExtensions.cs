using System;
using System.Collections.Generic;
using System.Linq;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
			Debug.LogWarning("Original TextMeshProUGUI is null.");
			return null;
		}
		GameObject gameObject = new GameObject(original.gameObject.name + "_Copy", new Type[] { typeof(RectTransform) });
		gameObject.transform.SetParent(original.transform.parent, false);
		TextMeshProUGUI textMeshProUGUI = gameObject.AddComponent<TextMeshProUGUI>();
		RectTransform component = original.GetComponent<RectTransform>();
		RectTransform component2 = textMeshProUGUI.GetComponent<RectTransform>();
		component2.anchorMin = component.anchorMin;
		component2.anchorMax = component.anchorMax;
		component2.pivot = component.pivot;
		component2.anchoredPosition = component.anchoredPosition;
		component2.sizeDelta = component.sizeDelta;
		component2.localRotation = component.localRotation;
		component2.localScale = component.localScale;
		textMeshProUGUI.text = original.text;
		textMeshProUGUI.font = original.font;
		textMeshProUGUI.fontSize = original.fontSize;
		textMeshProUGUI.color = original.color;
		textMeshProUGUI.alignment = original.alignment;
		textMeshProUGUI.raycastTarget = original.raycastTarget;
		textMeshProUGUI.fontMaterial = new Material(original.fontMaterial);
		textMeshProUGUI.enableAutoSizing = original.enableAutoSizing;
		textMeshProUGUI.fontSizeMin = original.fontSizeMin;
		textMeshProUGUI.fontSizeMax = original.fontSizeMax;
		textMeshProUGUI.characterSpacing = original.characterSpacing;
		textMeshProUGUI.wordSpacing = original.wordSpacing;
		textMeshProUGUI.lineSpacing = original.lineSpacing;
		textMeshProUGUI.paragraphSpacing = original.paragraphSpacing;
		textMeshProUGUI.richText = original.richText;
		textMeshProUGUI.overflowMode = original.overflowMode;
		textMeshProUGUI.enableWordWrapping = original.enableWordWrapping;
		textMeshProUGUI.horizontalMapping = original.horizontalMapping;
		textMeshProUGUI.verticalMapping = original.verticalMapping;
		textMeshProUGUI.margin = original.margin;
		CanvasRenderer component3 = original.GetComponent<CanvasRenderer>();
		textMeshProUGUI.GetComponent<CanvasRenderer>().SetColor(component3.GetColor());
		Shadow component4 = original.GetComponent<Shadow>();
		if (component4 != null)
		{
			Shadow shadow = textMeshProUGUI.gameObject.AddComponent<Shadow>();
			shadow.effectColor = component4.effectColor;
			shadow.effectDistance = component4.effectDistance;
			shadow.useGraphicAlpha = component4.useGraphicAlpha;
		}
		Outline component5 = original.GetComponent<Outline>();
		if (component5 != null)
		{
			Outline outline = textMeshProUGUI.gameObject.AddComponent<Outline>();
			outline.effectColor = component5.effectColor;
			outline.effectDistance = component5.effectDistance;
			outline.useGraphicAlpha = component5.useGraphicAlpha;
		}
		return textMeshProUGUI;
	}

	public static Color AsColor(this HexColor src)
	{
		return new Color((float)src.Red / 255f, (float)src.Green / 255f, (float)src.Blue / 255f);
	}

	public static Color Saturate(this Color color, float intensity)
	{
		if (intensity <= -1f)
		{
			color = Color.black;
		}
		else if (intensity > 0f)
		{
			float maxColorComponent = color.maxColorComponent;
			if (maxColorComponent > 0f)
			{
				color = Color.Lerp(color, color * (1f / maxColorComponent), intensity);
			}
		}
		else
		{
			color *= 1f + intensity;
		}
		color.a = 1f;
		return color;
	}

	public static string Reverse(this string text)
	{
		char[] array = text.ToCharArray();
		string text2 = string.Empty;
		for (int i = array.Length - 1; i > -1; i--)
		{
			text2 += array[i].ToString();
		}
		return text2;
	}

	public static void SetMainTexture(this Material mat, Texture tex)
	{
		mat.SetTexture("_MainTex", tex);
	}

	public static Sprite Duplicate(this Sprite original)
	{
		Texture2D texture2D = new Texture2D(original.texture.width, original.texture.height, TextureFormat.RGBA32, false);
		texture2D.SetPixels32(original.texture.GetPixels32(0));
		texture2D.Apply();
		return Sprite.Create(texture2D, original.rect, original.pivot, original.pixelsPerUnit, 0U, SpriteMeshType.FullRect, original.border);
	}

	static AExtensions()
	{
		AExtensions.judgements.Add(BasePlayer.Judgement.Marvelous, "<color=#33ffffff>Flawless!".ToCharArray());
		AExtensions.judgements.Add(BasePlayer.Judgement.Perfect, "<color=yellow>Perfect!".ToCharArray());
		AExtensions.judgements.Add(BasePlayer.Judgement.Great, "<color=#ff33ffff>Great!".ToCharArray());
		AExtensions.judgements.Add(BasePlayer.Judgement.Good, "<color=#22ff22ff>Good".ToCharArray());
		AExtensions.judgements.Add(BasePlayer.Judgement.Bad, "<color=orange>Bad".ToCharArray());
		AExtensions.judgements.Add(BasePlayer.Judgement.Early, "Early".ToCharArray());
		AExtensions.judgements.Add(BasePlayer.Judgement.Miss, "<color=#aaaaaaaa>Miss</color>".ToCharArray());
	}

	public static char[] ToCharArray(this BasePlayer.Judgement j)
	{
		return AExtensions.judgements[j];
	}

	private static Dictionary<BasePlayer.Judgement, char[]> judgements = new Dictionary<BasePlayer.Judgement, char[]>();
}
