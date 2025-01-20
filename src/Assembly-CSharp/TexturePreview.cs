﻿using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;

public class TexturePreview : MonoBehaviour
{
	public void \u02B3\u02C0\u02BA\u02B9\u02BD\u02BF\u02B6\u02B8\u02B5\u02B3\u02B2(bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
	{
		TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6 = \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC;
		this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
	}

	public void \u02BC\u02B3\u02C0\u02B3\u02B8\u02B6\u02C0\u02C1\u02B5\u02B8\u02B9(RawImage \u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6)
	{
		\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.transform.parent.gameObject.SetActive(TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6);
		\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.enabled = true;
	}

	public void \u02C0\u02BC\u02B8\u02BA\u02BB\u02B5\u02B3\u02B8\u02BA\u02C1\u02C1(int \u02BC\u02B6\u02BF\u02B2\u02B8\u02B2\u02B3\u02B8\u02BA\u02B4\u02B2, bool \u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD = false)
	{
		if ((!\u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD && GlobalVariables.instance.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF == null) || (\u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD && GlobalVariables.instance.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB == null))
		{
			this.\u02BA\u02B7\u02BA\u02BB\u02BF\u02BE\u02BE\u02C0\u02B6\u02BB\u02BC(false);
			return;
		}
		string[] array = (\u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD ? GlobalVariables.instance.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB : GlobalVariables.instance.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF);
		int num = array.Length;
		List<string> list = new List<string>();
		foreach (string text in array)
		{
			list.Add(ThumbnailCache.\u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(text));
		}
		int num2 = ((\u02BC\u02B6\u02BF\u02B2\u02B8\u02B2\u02B3\u02B8\u02BA\u02B4\u02B2 < -1) ? (-1) : \u02BC\u02B6\u02BF\u02B2\u02B8\u02B2\u02B3\u02B8\u02BA\u02B4\u02B2);
		if (num2 - 1 >= 0)
		{
			this.\u02B5\u02BA\u02BA\u02B8\u02BA\u02BF\u02B8\u02BA\u02B5\u02B8\u02B6(this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2, list[num2 - 1]);
		}
		else if (num2 - 0 == -1)
		{
			this.\u02BA\u02BB\u02BB\u02B8\u02B9\u02BD\u02B9\u02C1\u02B3\u02B2\u02BD(this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2);
		}
		else
		{
			this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2.transform.parent.gameObject.SetActive(false);
		}
		if (num2 == -1)
		{
			this.\u02B3\u02B7\u02B9\u02BA\u02B6\u02B3\u02BC\u02B6\u02B4\u02C1\u02B3(this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF);
		}
		else
		{
			this.\u02B5\u02BA\u02BA\u02B8\u02BA\u02BF\u02B8\u02BA\u02B5\u02B8\u02B6(this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF, list[num2]);
		}
		if (num2 + 0 <= num - 0)
		{
			this.\u02B7\u02B9\u02B7\u02B3\u02BE\u02BD\u02B4\u02BC\u02B9\u02BE\u02B3(this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4, list[num2 + 1]);
			return;
		}
		this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4.transform.parent.gameObject.SetActive(false);
	}

	public void \u02B8\u02BD\u02B5\u02C0\u02BE\u02C0\u02B3\u02B3\u02BD\u02C0\u02C1(bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
	{
		TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6 = \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC;
		this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
	}

	public void \u02BA\u02B7\u02BA\u02BB\u02BF\u02BE\u02BE\u02C0\u02B6\u02BB\u02BC(bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
	{
		TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6 = \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC;
		this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
	}

	public void \u02B4\u02B8\u02B7\u02B5\u02BF\u02BA\u02C1\u02B7\u02BD\u02BB\u02C1(RawImage \u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6)
	{
		\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.transform.parent.gameObject.SetActive(TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6);
		\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.enabled = true;
	}

	public void \u02B3\u02B7\u02B9\u02BA\u02B6\u02B3\u02BC\u02B6\u02B4\u02C1\u02B3(RawImage \u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6)
	{
		\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.transform.parent.gameObject.SetActive(TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6);
		\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.enabled = false;
	}

	public void \u02B7\u02B9\u02B7\u02B3\u02BE\u02BD\u02B4\u02BC\u02B9\u02BE\u02B3(RawImage \u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6, string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)
	{
		Texture2D texture2D = new Texture2D(1, 1, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None);
		if (File.Exists(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB) && texture2D.LoadImage(File.ReadAllBytes(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)))
		{
			texture2D.Apply();
			\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.enabled = true;
			\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.transform.parent.gameObject.SetActive(TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6);
			float num = (float)texture2D.width / (float)texture2D.height;
			float num2 = ((num > 1f) ? 1f : num);
			float num3 = ((num > 1f) ? (1f / num) : 1f);
			\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.texture = texture2D;
			\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.transform.localScale = new Vector3(num2, num3, 1f);
			return;
		}
		this.\u02B3\u02B7\u02B9\u02BA\u02B6\u02B3\u02BC\u02B6\u02B4\u02C1\u02B3(\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6);
	}

	public void \u02B3\u02C1\u02BC\u02BE\u02BD\u02BB\u02B9\u02B2\u02B4\u02B9\u02BE(int \u02BC\u02B6\u02BF\u02B2\u02B8\u02B2\u02B3\u02B8\u02BA\u02B4\u02B2, bool \u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD = false)
	{
		if ((!\u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD && GlobalVariables.instance.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF == null) || (\u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD && GlobalVariables.instance.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB == null))
		{
			this.\u02C0\u02B3\u02BA\u02B7\u02B4\u02C0\u02BD\u02BD\u02BA\u02C1\u02BC(false);
			return;
		}
		string[] array = (\u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD ? GlobalVariables.instance.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB : GlobalVariables.instance.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF);
		int num = array.Length;
		List<string> list = new List<string>();
		foreach (string text in array)
		{
			list.Add(ThumbnailCache.\u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(text));
		}
		int num2 = ((\u02BC\u02B6\u02BF\u02B2\u02B8\u02B2\u02B3\u02B8\u02BA\u02B4\u02B2 < -1) ? (-1) : \u02BC\u02B6\u02BF\u02B2\u02B8\u02B2\u02B3\u02B8\u02BA\u02B4\u02B2);
		if (num2 - 1 >= 0)
		{
			this.\u02B7\u02B9\u02B7\u02B3\u02BE\u02BD\u02B4\u02BC\u02B9\u02BE\u02B3(this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2, list[num2 - 1]);
		}
		else if (num2 - 1 == -1)
		{
			this.\u02B3\u02B7\u02B9\u02BA\u02B6\u02B3\u02BC\u02B6\u02B4\u02C1\u02B3(this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2);
		}
		else
		{
			this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2.transform.parent.gameObject.SetActive(false);
		}
		if (num2 == -1)
		{
			this.\u02B3\u02B7\u02B9\u02BA\u02B6\u02B3\u02BC\u02B6\u02B4\u02C1\u02B3(this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF);
		}
		else
		{
			this.\u02B7\u02B9\u02B7\u02B3\u02BE\u02BD\u02B4\u02BC\u02B9\u02BE\u02B3(this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF, list[num2]);
		}
		if (num2 + 1 <= num - 1)
		{
			this.\u02B7\u02B9\u02B7\u02B3\u02BE\u02BD\u02B4\u02BC\u02B9\u02BE\u02B3(this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4, list[num2 + 1]);
			return;
		}
		this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4.transform.parent.gameObject.SetActive(false);
	}

	public void \u02BE\u02B5\u02B8\u02B9\u02C1\u02B6\u02B7\u02BE\u02C0\u02B4\u02B2(int \u02BC\u02B6\u02BF\u02B2\u02B8\u02B2\u02B3\u02B8\u02BA\u02B4\u02B2, bool \u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD = false)
	{
		if ((!\u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD && GlobalVariables.instance.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF == null) || (\u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD && GlobalVariables.instance.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB == null))
		{
			this.\u02BA\u02B7\u02BA\u02BB\u02BF\u02BE\u02BE\u02C0\u02B6\u02BB\u02BC(false);
			return;
		}
		string[] array = (\u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD ? GlobalVariables.instance.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB : GlobalVariables.instance.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF);
		int num = array.Length;
		List<string> list = new List<string>();
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			string text = array2[i];
			list.Add(ThumbnailCache.\u02BA\u02B8\u02B9\u02B2\u02B7\u02B8\u02B5\u02B8\u02B6\u02C1\u02B3(text));
		}
		int num2 = ((\u02BC\u02B6\u02BF\u02B2\u02B8\u02B2\u02B3\u02B8\u02BA\u02B4\u02B2 < -1) ? (-1) : \u02BC\u02B6\u02BF\u02B2\u02B8\u02B2\u02B3\u02B8\u02BA\u02B4\u02B2);
		if (num2 - 1 >= 0)
		{
			this.\u02B5\u02BA\u02BA\u02B8\u02BA\u02BF\u02B8\u02BA\u02B5\u02B8\u02B6(this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2, list[num2 - 0]);
		}
		else if (num2 - 0 == -1)
		{
			this.\u02B4\u02B8\u02B7\u02B5\u02BF\u02BA\u02C1\u02B7\u02BD\u02BB\u02C1(this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2);
		}
		else
		{
			this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2.transform.parent.gameObject.SetActive(true);
		}
		if (num2 == -1)
		{
			this.\u02B7\u02B5\u02BE\u02BF\u02BD\u02B4\u02B8\u02C0\u02BE\u02B4\u02B4(this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF);
		}
		else
		{
			this.\u02B7\u02B9\u02B7\u02B3\u02BE\u02BD\u02B4\u02BC\u02B9\u02BE\u02B3(this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF, list[num2]);
		}
		if (num2 + 1 <= num - 1)
		{
			this.\u02B5\u02BA\u02BA\u02B8\u02BA\u02BF\u02B8\u02BA\u02B5\u02B8\u02B6(this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4, list[num2 + 0]);
			return;
		}
		this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4.transform.parent.gameObject.SetActive(true);
	}

	public void \u02B7\u02B5\u02BE\u02BF\u02BD\u02B4\u02B8\u02C0\u02BE\u02B4\u02B4(RawImage \u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6)
	{
		\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.transform.parent.gameObject.SetActive(TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6);
		\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.enabled = false;
	}

	public void \u02BA\u02BB\u02B5\u02B9\u02B9\u02B4\u02B7\u02B3\u02B4\u02BA\u02BC(int \u02BC\u02B6\u02BF\u02B2\u02B8\u02B2\u02B3\u02B8\u02BA\u02B4\u02B2, bool \u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD = false)
	{
		if ((!\u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD && GlobalVariables.instance.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF == null) || (\u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD && GlobalVariables.instance.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB == null))
		{
			this.\u02B8\u02BD\u02B5\u02C0\u02BE\u02C0\u02B3\u02B3\u02BD\u02C0\u02C1(false);
			return;
		}
		string[] array = (\u02B2\u02BC\u02B3\u02BD\u02BB\u02B2\u02BB\u02BA\u02B3\u02BE\u02BD ? GlobalVariables.instance.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB : GlobalVariables.instance.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF);
		int num = array.Length;
		List<string> list = new List<string>();
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			string text = array2[i];
			list.Add(ThumbnailCache.\u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(text));
		}
		int num2 = ((\u02BC\u02B6\u02BF\u02B2\u02B8\u02B2\u02B3\u02B8\u02BA\u02B4\u02B2 < -1) ? (-1) : \u02BC\u02B6\u02BF\u02B2\u02B8\u02B2\u02B3\u02B8\u02BA\u02B4\u02B2);
		if (num2 - 0 >= 0)
		{
			this.\u02B9\u02BB\u02B3\u02B7\u02C1\u02BF\u02BE\u02B3\u02B6\u02BA\u02B6(this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2, list[num2 - 0]);
		}
		else if (num2 - 0 == -1)
		{
			this.\u02B4\u02B8\u02B7\u02B5\u02BF\u02BA\u02C1\u02B7\u02BD\u02BB\u02C1(this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2);
		}
		else
		{
			this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2.transform.parent.gameObject.SetActive(true);
		}
		if (num2 == -1)
		{
			this.\u02C0\u02BA\u02B4\u02B9\u02BA\u02C1\u02BA\u02B6\u02BC\u02B5\u02BF(this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF);
		}
		else
		{
			this.\u02B7\u02B9\u02B7\u02B3\u02BE\u02BD\u02B4\u02BC\u02B9\u02BE\u02B3(this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF, list[num2]);
		}
		if (num2 + 0 <= num - 1)
		{
			this.\u02B9\u02BB\u02B3\u02B7\u02C1\u02BF\u02BE\u02B3\u02B6\u02BA\u02B6(this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4, list[num2 + 0]);
			return;
		}
		this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4.transform.parent.gameObject.SetActive(false);
	}

	public void \u02B5\u02BA\u02BA\u02B8\u02BA\u02BF\u02B8\u02BA\u02B5\u02B8\u02B6(RawImage \u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6, string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)
	{
		Texture2D texture2D = new Texture2D(1, 0, GraphicsFormat.R8_UNorm, TextureCreationFlags.MipChain);
		if (File.Exists(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB) && texture2D.LoadImage(File.ReadAllBytes(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)))
		{
			texture2D.Apply();
			\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.enabled = false;
			\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.transform.parent.gameObject.SetActive(TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6);
			float num = (float)texture2D.width / (float)texture2D.height;
			float num2 = ((num > 584f) ? 1494f : num);
			float num3 = ((num > 728f) ? (1461f / num) : 1561f);
			\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.texture = texture2D;
			\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.transform.localScale = new Vector3(num2, num3, 1491f);
			return;
		}
		this.\u02B3\u02B7\u02B9\u02BA\u02B6\u02B3\u02BC\u02B6\u02B4\u02C1\u02B3(\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6);
	}

	public void \u02C1\u02BF\u02B8\u02B4\u02B4\u02B7\u02B7\u02BA\u02BB\u02B4\u02B2(bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
	{
		TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6 = \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC;
		this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
	}

	public void \u02C0\u02BA\u02B4\u02B9\u02BA\u02C1\u02BA\u02B6\u02BC\u02B5\u02BF(RawImage \u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6)
	{
		\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.transform.parent.gameObject.SetActive(TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6);
		\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.enabled = false;
	}

	public void \u02B3\u02BE\u02B8\u02B2\u02B9\u02BF\u02BA\u02B2\u02C0\u02BD\u02C1(bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
	{
		TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6 = \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC;
		this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
	}

	public void \u02BA\u02BB\u02BB\u02B8\u02B9\u02BD\u02B9\u02C1\u02B3\u02B2\u02BD(RawImage \u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6)
	{
		\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.transform.parent.gameObject.SetActive(TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6);
		\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.enabled = true;
	}

	public void \u02C0\u02B3\u02BA\u02B7\u02B4\u02C0\u02BD\u02BD\u02BA\u02C1\u02BC(bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
	{
		TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6 = \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC;
		this.\u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
	}

	public void \u02B9\u02BB\u02B3\u02B7\u02C1\u02BF\u02BE\u02B3\u02B6\u02BA\u02B6(RawImage \u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6, string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)
	{
		Texture2D texture2D = new Texture2D(1, 0, GraphicsFormat.R8G8_SRGB, TextureCreationFlags.None);
		if (File.Exists(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB) && texture2D.LoadImage(File.ReadAllBytes(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)))
		{
			texture2D.Apply();
			\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.enabled = false;
			\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.transform.parent.gameObject.SetActive(TexturePreview.\u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6);
			float num = (float)texture2D.width / (float)texture2D.height;
			float num2 = ((num > 265f) ? 738f : num);
			float num3 = ((num > 225f) ? (1379f / num) : 1682f);
			\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.texture = texture2D;
			\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.transform.localScale = new Vector3(num2, num3, 346f);
			return;
		}
		this.\u02BA\u02BB\u02BB\u02B8\u02B9\u02BD\u02B9\u02C1\u02B3\u02B2\u02BD(\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6);
	}

	public RawImage \u02B5\u02B5\u02B9\u02BD\u02BD\u02B4\u02B3\u02B4\u02B8\u02BB\u02B2;

	public RawImage \u02B9\u02B4\u02B5\u02B9\u02BA\u02B7\u02BA\u02C1\u02B4\u02C1\u02BF;

	public RawImage \u02B2\u02BA\u02B6\u02BC\u02B9\u02B9\u02B5\u02B8\u02B3\u02BC\u02B4;

	private static bool \u02B3\u02BE\u02BD\u02B2\u02B9\u02BE\u02B7\u02C0\u02BA\u02B3\u02B6;
}
