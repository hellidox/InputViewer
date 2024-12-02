﻿using System;
using System.Collections.Generic;
using System.IO;
using StrikeCore;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

internal class \u02BD\u02B3\u02BF\u02C0\u02BF\u02C1\u02B5\u02B3\u02BE\u02BD\u02B6
{
	public Texture2D \u02C0\u02C0\u02C0\u02B7\u02BC\u02BF\u02B9\u02BD\u02BF\u02BF\u02B8()
	{
		int num = 1920;
		int num2 = 1080;
		Camera main = Camera.main;
		RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 24);
		Texture2D texture2D = new Texture2D(num, num2, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None);
		main.targetTexture = temporary;
		main.ResetAspect();
		ScaleWorldSpaceCanvas[] array = global::UnityEngine.Object.FindObjectsOfType<ScaleWorldSpaceCanvas>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].\u02BC\u02B4\u02C0\u02BC\u02B6\u02C0\u02BB\u02B2\u02B3\u02BF\u02BE();
		}
		Canvas.ForceUpdateCanvases();
		main.Render();
		RenderTexture.active = temporary;
		texture2D.ReadPixels(new Rect(0f, 0f, (float)num, (float)num2), 0, 0);
		RenderTexture.active = (main.targetTexture = null);
		main.ResetAspect();
		RenderTexture.ReleaseTemporary(temporary);
		Color32[] pixels = texture2D.GetPixels32();
		\u02B2\u02B6\u02B3\u02BA\u02B2\u02B8\u02B6\u02B8\u02BF\u02B4\u02BF.\u02B6\u02BC\u02C0\u02BD\u02BE\u02C1\u02B3\u02B8\u02BF\u02B8\u02BD(new \u02B2\u02BB\u02B3\u02C0\u02B8\u02B5\u02B9\u02B3\u02B8\u02B4\u02B8(this.\u02B5\u02B5\u02B5\u02BF\u02BE\u02BF\u02BF\u02B7\u02B3\u02BF\u02C0()), ref pixels);
		texture2D.SetPixels32(pixels);
		texture2D.Apply();
		byte[] array2 = texture2D.EncodeToPNG();
		string text = this.scoreTimestamp.ToLocalTime().ToString("yyyyMMddHHmmss");
		string text2 = string.Concat(new string[] { "clonehero-", this.\u02B3\u02B3\u02B2\u02C0\u02B4\u02B7\u02BA\u02B8\u02B7\u02BE\u02B8, "-", text, ".png" });
		string text3 = __FIXME_clon_util.\u02BB\u02B4\u02B7\u02BB\u02BB\u02BD\u02C1\u02BD\u02BC\u02B9\u02BE(text2).Replace(" ", "-");
		text2 = Path.Combine(this.\u02B3\u02BA\u02BE\u02B3\u02C0\u02B9\u02B5\u02B9\u02C1\u02BA\u02B3, text3);
		this.\u02B3\u02B2\u02BB\u02BB\u02BB\u02BB\u02B3\u02BF\u02C0\u02BA\u02C1 = text2;
		File.WriteAllBytes(text2, array2);
		return texture2D;
	}

	public void \u02B5\u02B2\u02BD\u02B6\u02B2\u02B3\u02BF\u02B8\u02C1\u02B3\u02B2(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7, PlayerStats \u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5)
	{
		\u02B9\u02B5\u02BD\u02C1\u02BC\u02BA\u02B7\u02BF\u02B7\u02B2\u02BB u02B9_u02B5_u02BD_u02C1_u02BC_u02BA_u02B7_u02BF_u02B7_u02B2_u02BB = new \u02B9\u02B5\u02BD\u02C1\u02BC\u02BA\u02B7\u02BF\u02B7\u02B2\u02BB();
		u02B9_u02B5_u02BD_u02C1_u02BC_u02BA_u02B7_u02BF_u02B7_u02B2_u02BB.\u02BA\u02B3\u02BE\u02BA\u02B9\u02B6\u02B5\u02B2\u02BE\u02B2\u02BF(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7, \u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5);
		this.\u02B5\u02B7\u02B6\u02BE\u02BB\u02C0\u02BF\u02BD\u02B7\u02B3\u02B7.Add(u02B9_u02B5_u02BD_u02C1_u02BC_u02BA_u02B7_u02BF_u02B7_u02B2_u02BB);
	}

	public void \u02BA\u02B8\u02B4\u02BC\u02B4\u02C1\u02B8\u02B9\u02B6\u02C1\u02B4()
	{
		this.\u02B5\u02B7\u02B6\u02BE\u02BB\u02C0\u02BF\u02BD\u02B7\u02B3\u02B7.Clear();
	}

	public void \u02BC\u02BB\u02BA\u02BE\u02BB\u02B9\u02B8\u02B8\u02BA\u02C1\u02B8(SongEntry \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD, int \u02B4\u02B4\u02BF\u02B4\u02B2\u02B5\u02BC\u02BB\u02C1\u02B4\u02BE, int \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5, int \u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9)
	{
		this.\u02B2\u02B3\u02BF\u02C0\u02C0\u02B3\u02B5\u02C1\u02BD\u02B2\u02BB = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B3\u02B7\u02BC\u02B5\u02B3\u02B8\u02BB\u02BE\u02B5\u02B3;
		this.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 = (\u02BB\u02B3\u02BD\u02B3\u02B5\u02B4\u02BA\u02B9\u02C0\u02B4\u02C1)GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1;
		this.\u02BD\u02B8\u02B9\u02B6\u02BE\u02B6\u02B6\u02B5\u02BA\u02BA\u02B4 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.checksumString;
		this.\u02B3\u02B3\u02B2\u02C0\u02B4\u02B7\u02BA\u02B8\u02B7\u02BE\u02B8 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.\u02B2\u02C1\u02BD\u02BB\u02BB\u02B6\u02BB\u02BD\u02BA\u02B7\u02B7 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.\u02B4\u02C0\u02C1\u02B8\u02B6\u02C0\u02C0\u02B7\u02B8\u02C1\u02C0 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.Charter.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE = \u02B4\u02B4\u02BF\u02B4\u02B2\u02B5\u02BC\u02BB\u02C1\u02B4\u02BE;
		this.\u02BF\u02BF\u02BB\u02BB\u02C0\u02BA\u02BB\u02B8\u02B8\u02B5\u02BD = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
		this.\u02BB\u02C0\u02B9\u02B9\u02C1\u02B6\u02B5\u02BF\u02B9\u02B8\u02C0 = \u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9;
		this.scoreTimestamp = DateTime.Now.ToUniversalTime();
	}

	public byte[] \u02B5\u02B5\u02B5\u02BF\u02BE\u02BF\u02BF\u02B7\u02B3\u02BF\u02C0()
	{
		byte[] array;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
			{
				this.\u02BF\u02BB\u02B5\u02B8\u02B8\u02B3\u02B8\u02B5\u02B5\u02B6\u02B3(binaryWriter);
			}
			array = memoryStream.ToArray();
		}
		return array;
	}

	public \u02BD\u02B3\u02BF\u02C0\u02BF\u02C1\u02B5\u02B3\u02BE\u02BD\u02B6(int \u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD)
	{
		this.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD = \u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD;
		this.\u02B5\u02B7\u02B6\u02BE\u02BB\u02C0\u02BF\u02BD\u02B7\u02B3\u02B7 = new List<\u02B9\u02B5\u02BD\u02C1\u02BC\u02BA\u02B7\u02BF\u02B7\u02B2\u02BB>(\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD);
		this.\u02B3\u02BA\u02BE\u02B3\u02C0\u02B9\u02B5\u02B9\u02C1\u02BA\u02B3 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C0\u02BD\u02B8\u02B9\u02BA\u02B6\u02B4\u02BB\u02B2\u02B6\u02B3;
	}

	public void \u02BF\u02BB\u02B5\u02B8\u02B8\u02B3\u02B8\u02B5\u02B5\u02B6\u02B3(BinaryWriter \u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC)
	{
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.\u02BF\u02BC\u02BD\u02B2\u02C1\u02BB\u02B5\u02BD\u02B5\u02B3\u02BC);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.\u02B2\u02B3\u02BF\u02C0\u02C0\u02B3\u02B5\u02C1\u02BD\u02B2\u02BB);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.\u02BD\u02B8\u02B9\u02B6\u02BE\u02B6\u02B6\u02B5\u02BA\u02BA\u02B4);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.\u02B3\u02B3\u02B2\u02C0\u02B4\u02B7\u02BA\u02B8\u02B7\u02BE\u02B8);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.\u02B2\u02C1\u02BD\u02BB\u02BB\u02B6\u02BB\u02BD\u02BA\u02B7\u02B7);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.\u02B4\u02C0\u02C1\u02B8\u02B6\u02C0\u02C0\u02B7\u02B8\u02C1\u02C0);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write((int)this.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.scoreTimestamp.ToBinary());
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.\u02BF\u02BF\u02BB\u02BB\u02C0\u02BA\u02BB\u02B8\u02B8\u02B5\u02BD);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.\u02BB\u02C0\u02B9\u02B9\u02C1\u02B6\u02B5\u02BF\u02B9\u02B8\u02C0);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD);
		foreach (\u02B9\u02B5\u02BD\u02C1\u02BC\u02BA\u02B7\u02BF\u02B7\u02B2\u02BB u02B9_u02B5_u02BD_u02C1_u02BC_u02BA_u02B7_u02BF_u02B7_u02B2_u02BB in this.\u02B5\u02B7\u02B6\u02BE\u02BB\u02C0\u02BF\u02BD\u02B7\u02B3\u02B7)
		{
			u02B9_u02B5_u02BD_u02C1_u02BC_u02BA_u02B7_u02BF_u02B7_u02B2_u02BB.\u02BF\u02BB\u02B5\u02B8\u02B8\u02B3\u02B8\u02B5\u02B5\u02B6\u02B3(\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC);
		}
	}

	public void \u02BE\u02B2\u02B4\u02B2\u02B7\u02B4\u02BB\u02C1\u02C1\u02C1\u02BA()
	{
		this.\u02B5\u02B7\u02B6\u02BE\u02BB\u02C0\u02BF\u02BD\u02B7\u02B3\u02B7.Clear();
	}

	private int \u02BF\u02BC\u02BD\u02B2\u02C1\u02BB\u02B5\u02BD\u02B5\u02B3\u02BC = 6;

	private string \u02B2\u02B3\u02BF\u02C0\u02C0\u02B3\u02B5\u02C1\u02BD\u02B2\u02BB;

	private string \u02BD\u02B8\u02B9\u02B6\u02BE\u02B6\u02B6\u02B5\u02BA\u02BA\u02B4;

	private string \u02B3\u02B3\u02B2\u02C0\u02B4\u02B7\u02BA\u02B8\u02B7\u02BE\u02B8;

	private string \u02B2\u02C1\u02BD\u02BB\u02BB\u02B6\u02BB\u02BD\u02BA\u02B7\u02B7;

	private string \u02B4\u02C0\u02C1\u02B8\u02B6\u02C0\u02C0\u02B7\u02B8\u02C1\u02C0;

	private int \u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE;

	private \u02BB\u02B3\u02BD\u02B3\u02B5\u02B4\u02BA\u02B9\u02C0\u02B4\u02C1 \u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1;

	private DateTime scoreTimestamp;

	private int \u02BF\u02BF\u02BB\u02BB\u02C0\u02BA\u02BB\u02B8\u02B8\u02B5\u02BD;

	private int \u02BB\u02C0\u02B9\u02B9\u02C1\u02B6\u02B5\u02BF\u02B9\u02B8\u02C0;

	private int \u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD;

	private List<\u02B9\u02B5\u02BD\u02C1\u02BC\u02BA\u02B7\u02BF\u02B7\u02B2\u02BB> \u02B5\u02B7\u02B6\u02BE\u02BB\u02C0\u02BF\u02BD\u02B7\u02B3\u02B7;

	private string \u02B3\u02BA\u02BE\u02B3\u02C0\u02B9\u02B5\u02B9\u02C1\u02BA\u02B3;

	public string \u02B3\u02B2\u02BB\u02BB\u02BB\u02BB\u02B3\u02BF\u02C0\u02BA\u02C1;
}
