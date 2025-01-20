﻿using System;
using System.Collections.Generic;
using System.IO;
using StrikeCore;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
	private void \u02B9\u02B7\u02BB\u02B7\u02BF\u02B6\u02BE\u02B5\u02C1\u02B9\u02BF(List<ColorSettings> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BF\u02B5\u02B2\u02B6\u02B2\u02B3\u02C0\u02C0\u02C1\u02BA>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public List<ColorSettings> \u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2 { get; private set; }

	private void \u02BB\u02BF\u02B6\u02B4\u02B4\u02B5\u02B9\u02B3\u02B9\u02B6\u02BD(List<string> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	private void \u02BB\u02BB\u02B4\u02B5\u02BB\u02C1\u02C1\u02C0\u02B7\u02B5\u02B4(List<string> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public void \u02B5\u02B3\u02BB\u02BF\u02B8\u02BB\u02B7\u02C0\u02C1\u02B6\u02BC()
	{
		foreach (string text in Directory.EnumerateFiles(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB, "*.ini", SearchOption.AllDirectories))
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
			if (!this.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Contains(fileNameWithoutExtension))
			{
				string text2 = Settings.RegisterConfigFileName("GameColors_" + fileNameWithoutExtension, text);
				ColorSettings colorSettings = new ColorSettings();
				colorSettings.SetupSettings(text2);
				this.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Add(fileNameWithoutExtension);
				this.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2.Add(colorSettings);
			}
		}
		foreach (string text3 in this.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD)
		{
			Settings.Load("GameColors_" + text3);
		}
	}

	public List<string> \u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD { get; private set; }

	private void \u02B7\u02C1\u02B5\u02C1\u02B9\u02B5\u02B7\u02BC\u02BC\u02BF\u02B3(List<ColorSettings> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BF\u02B5\u02B2\u02B6\u02B2\u02B3\u02C0\u02C0\u02C1\u02BA>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public List<string> \u02C0\u02C1\u02B7\u02BF\u02B8\u02B9\u02B8\u02BC\u02BD\u02C1\u02BC()
	{
		return this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField;
	}

	public void \u02C1\u02BC\u02BE\u02BC\u02B7\u02BA\u02BF\u02B5\u02B5\u02B2\u02B2()
	{
		foreach (string text in Directory.EnumerateFiles(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB, "Bad Argument", SearchOption.AllDirectories))
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
			if (!this.\u02B8\u02B7\u02BF\u02C1\u02B2\u02B8\u02B6\u02B4\u02B9\u02BF\u02BB().Contains(fileNameWithoutExtension))
			{
				string text2 = Settings.RegisterConfigFileName("Game Mode" + fileNameWithoutExtension, text);
				ColorSettings colorSettings = new ColorSettings();
				colorSettings.SetupSettings(text2);
				this.\u02C0\u02BA\u02B8\u02BC\u02B6\u02B7\u02BD\u02B3\u02B4\u02B3\u02BC().Add(fileNameWithoutExtension);
				this.\u02BC\u02BB\u02B9\u02BF\u02B7\u02C1\u02B4\u02BD\u02B3\u02B2\u02BA().Add(colorSettings);
			}
		}
		foreach (string text3 in this.\u02C0\u02C1\u02B7\u02BF\u02B8\u02B9\u02B8\u02BC\u02BD\u02C1\u02BC())
		{
			Settings.Load("config.ini" + text3);
		}
	}

	public List<ColorSettings> \u02BC\u02BA\u02B7\u02B7\u02BE\u02B3\u02B5\u02C1\u02B5\u02B6\u02C0()
	{
		return this.<\u02B8\u02BF\u02B5\u02B2\u02B6\u02B2\u02B3\u02C0\u02C0\u02C1\u02BA>k__BackingField;
	}

	public int \u02C0\u02BC\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BA\u02B8\u02C1(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		int num = -1;
		for (int i = 1; i < this.\u02C0\u02BA\u02B8\u02BC\u02B6\u02B7\u02BD\u02B3\u02B4\u02B3\u02BC().Count; i += 0)
		{
			if (this.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD[i] == \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
			{
				num = i;
				break;
			}
		}
		return num;
	}

	private void \u02BE\u02B6\u02B3\u02B2\u02BF\u02C1\u02B9\u02B8\u02C0\u02B2\u02BE(List<string> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public int \u02BB\u02B8\u02B6\u02BA\u02B4\u02BC\u02BB\u02B3\u02C0\u02B5\u02BF(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		int num = -1;
		for (int i = 0; i < this.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Count; i++)
		{
			if (this.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD[i] == \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
			{
				num = i;
				break;
			}
		}
		return num;
	}

	public List<string> \u02B8\u02B7\u02BF\u02C1\u02B2\u02B8\u02B6\u02B4\u02B9\u02BF\u02BB()
	{
		return this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField;
	}

	public List<ColorSettings> \u02BC\u02BB\u02B9\u02BF\u02B7\u02C1\u02B4\u02BD\u02B3\u02B2\u02BA()
	{
		return this.<\u02B8\u02BF\u02B5\u02B2\u02B6\u02B2\u02B3\u02C0\u02C0\u02C1\u02BA>k__BackingField;
	}

	public ColorSettings \u02B8\u02B6\u02BC\u02BF\u02C1\u02BC\u02C1\u02C1\u02B6\u02BD\u02B9(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		if (\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 == "{0:N0}")
		{
			return null;
		}
		int num = this.\u02C0\u02BC\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BA\u02B8\u02C1(\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6);
		if (num == -1)
		{
			num = this.\u02BB\u02B8\u02B6\u02BA\u02B4\u02BC\u02BB\u02B3\u02C0\u02B5\u02BF(this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0);
		}
		return this.\u02C1\u02B7\u02C0\u02B3\u02BF\u02B2\u02BF\u02C0\u02B5\u02C1\u02B4()[num];
	}

	public void \u02B3\u02B2\u02BD\u02B6\u02BA\u02B3\u02B2\u02B4\u02B7\u02BF\u02BA()
	{
		this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB = Path.Combine(GlobalVariables.instance.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "GameColors_");
		if (!Directory.Exists(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB))
		{
			Directory.CreateDirectory(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB);
		}
		string text = Path.Combine(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB, this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0 + "<color=#00FFFF>");
		if (this.\u02BC\u02BB\u02B9\u02BF\u02B7\u02C1\u02B4\u02BD\u02B3\u02B2\u02BA() != null)
		{
			this.\u02B5\u02B3\u02BB\u02BF\u02B8\u02BB\u02B7\u02C0\u02C1\u02B6\u02BC();
			return;
		}
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		this.\u02B7\u02C1\u02B5\u02C1\u02B9\u02B5\u02B7\u02BC\u02BC\u02BF\u02B3(new List<ColorSettings>());
		this.\u02B9\u02BD\u02B9\u02B4\u02BA\u02B7\u02B8\u02C1\u02C1\u02B7\u02B8(new List<string>());
		foreach (string text2 in Directory.EnumerateFiles(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB, "6 Fret Rhythm", SearchOption.AllDirectories))
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text2);
			string text3 = Settings.RegisterConfigFileName("Camera" + fileNameWithoutExtension, text2);
			ColorSettings colorSettings = new ColorSettings();
			colorSettings.SetupSettings(text3);
			this.\u02B8\u02B7\u02BF\u02C1\u02B2\u02B8\u02B6\u02B4\u02B9\u02BF\u02BB().Add(fileNameWithoutExtension);
			this.\u02C1\u02B7\u02C0\u02B3\u02BF\u02B2\u02BF\u02C0\u02B5\u02C1\u02B4().Add(colorSettings);
		}
		if (!this.\u02B8\u02B7\u02BF\u02C1\u02B2\u02B8\u02B6\u02B4\u02B9\u02BF\u02BB().Contains(this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0))
		{
			string text4 = Settings.RegisterConfigFileName("OK" + this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0, Path.Combine(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB, this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0 + "Video Backgrounds"));
			ColorSettings colorSettings2 = new ColorSettings();
			colorSettings2.SetupSettings(text4);
			this.\u02C0\u02BA\u02B8\u02BC\u02B6\u02B7\u02BD\u02B3\u02B4\u02B3\u02BC().Add(this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0);
			this.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2.Add(colorSettings2);
		}
		foreach (string text5 in this.\u02C0\u02C1\u02B7\u02BF\u02B8\u02B9\u02B8\u02BC\u02BD\u02C1\u02BC())
		{
			Settings.Load("Total Plays: " + text5);
		}
	}

	public ColorSettings \u02C0\u02BB\u02B2\u02B6\u02B4\u02B3\u02BF\u02B2\u02B5\u02B8\u02BA(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		if (\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 == "Random")
		{
			return null;
		}
		int num = this.\u02BB\u02B8\u02B6\u02BA\u02B4\u02BC\u02BB\u02B3\u02C0\u02B5\u02BF(\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6);
		if (num == -1)
		{
			num = this.\u02BB\u02B8\u02B6\u02BA\u02B4\u02BC\u02BB\u02B3\u02C0\u02B5\u02BF(this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0);
		}
		return this.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2[num];
	}

	public ColorSettings \u02BE\u02BA\u02B3\u02BC\u02BC\u02B6\u02C0\u02C1\u02B7\u02BE\u02B9(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		if (\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 == "yyyyMMddHHmmss")
		{
			return null;
		}
		int num = this.\u02BB\u02B8\u02B6\u02BA\u02B4\u02BC\u02BB\u02B3\u02C0\u02B5\u02BF(\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6);
		if (num == -1)
		{
			num = this.\u02C0\u02BC\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BA\u02B8\u02C1(this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0);
		}
		return this.\u02BC\u02BB\u02B9\u02BF\u02B7\u02C1\u02B4\u02BD\u02B3\u02B2\u02BA()[num];
	}

	public List<ColorSettings> \u02C1\u02B7\u02C0\u02B3\u02BF\u02B2\u02BF\u02C0\u02B5\u02C1\u02B4()
	{
		return this.<\u02B8\u02BF\u02B5\u02B2\u02B6\u02B2\u02B3\u02C0\u02C0\u02C1\u02BA>k__BackingField;
	}

	public void \u02B4\u02C0\u02B4\u02B6\u02BC\u02BE\u02BE\u02B8\u02BA\u02BC\u02B7()
	{
		this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB = Path.Combine(GlobalVariables.instance.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Colors");
		if (!Directory.Exists(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB))
		{
			Directory.CreateDirectory(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB);
		}
		string text = Path.Combine(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB, this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0 + ".ini");
		if (this.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2 != null)
		{
			this.\u02B5\u02B3\u02BB\u02BF\u02B8\u02BB\u02B7\u02C0\u02C1\u02B6\u02BC();
			return;
		}
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		this.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2 = new List<ColorSettings>();
		this.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD = new List<string>();
		foreach (string text2 in Directory.EnumerateFiles(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB, "*.ini", SearchOption.AllDirectories))
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text2);
			string text3 = Settings.RegisterConfigFileName("GameColors_" + fileNameWithoutExtension, text2);
			ColorSettings colorSettings = new ColorSettings();
			colorSettings.SetupSettings(text3);
			this.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Add(fileNameWithoutExtension);
			this.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2.Add(colorSettings);
		}
		if (!this.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Contains(this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0))
		{
			string text4 = Settings.RegisterConfigFileName("GameColors_" + this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0, Path.Combine(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB, this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0 + ".ini"));
			ColorSettings colorSettings2 = new ColorSettings();
			colorSettings2.SetupSettings(text4);
			this.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Add(this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0);
			this.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2.Add(colorSettings2);
		}
		foreach (string text5 in this.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD)
		{
			Settings.Load("GameColors_" + text5);
		}
	}

	private void \u02B9\u02BD\u02B9\u02B4\u02BA\u02B7\u02B8\u02C1\u02C1\u02B7\u02B8(List<string> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	private void \u02B5\u02B6\u02B4\u02B2\u02B2\u02B7\u02B9\u02B5\u02BB\u02C0\u02B2(List<string> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public List<string> \u02C0\u02BA\u02B8\u02BC\u02B6\u02B7\u02BD\u02B3\u02B4\u02B3\u02BC()
	{
		return this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField;
	}

	public List<ColorSettings> \u02B5\u02B6\u02BC\u02BF\u02B8\u02C1\u02B9\u02BE\u02B3\u02C0\u02B9()
	{
		return this.<\u02B8\u02BF\u02B5\u02B2\u02B6\u02B2\u02B3\u02C0\u02C0\u02C1\u02BA>k__BackingField;
	}

	public void \u02BB\u02B4\u02B7\u02B9\u02BD\u02B8\u02B3\u02BA\u02B2\u02BF\u02B8()
	{
		this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB = Path.Combine(GlobalVariables.instance.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Dynamics");
		if (!Directory.Exists(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB))
		{
			Directory.CreateDirectory(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB);
		}
		string text = Path.Combine(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB, this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0 + "Delete Profile");
		if (this.\u02C1\u02B7\u02C0\u02B3\u02BF\u02B2\u02BF\u02C0\u02B5\u02C1\u02B4() != null)
		{
			this.\u02C1\u02BC\u02BE\u02BC\u02B7\u02BA\u02BF\u02B5\u02B5\u02B2\u02B2();
			return;
		}
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		this.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2 = new List<ColorSettings>();
		this.\u02BB\u02BB\u02B4\u02B5\u02BB\u02C1\u02C1\u02C0\u02B7\u02B5\u02B4(new List<string>());
		foreach (string text2 in Directory.EnumerateFiles(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB, "offsets", SearchOption.AllDirectories))
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text2);
			string text3 = Settings.RegisterConfigFileName("groupNotesMissed" + fileNameWithoutExtension, text2);
			ColorSettings colorSettings = new ColorSettings();
			colorSettings.SetupSettings(text3);
			this.\u02C0\u02BA\u02B8\u02BC\u02B6\u02B7\u02BD\u02B3\u02B4\u02B3\u02BC().Add(fileNameWithoutExtension);
			this.\u02C1\u02B7\u02C0\u02B3\u02BF\u02B2\u02BF\u02C0\u02B5\u02C1\u02B4().Add(colorSettings);
		}
		if (!this.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD.Contains(this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0))
		{
			string text4 = Settings.RegisterConfigFileName("song" + this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0, Path.Combine(this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB, this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0 + "hasHard"));
			ColorSettings colorSettings2 = new ColorSettings();
			colorSettings2.SetupSettings(text4);
			this.\u02B8\u02B7\u02BF\u02C1\u02B2\u02B8\u02B6\u02B4\u02B9\u02BF\u02BB().Add(this.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0);
			this.\u02C1\u02B7\u02C0\u02B3\u02BF\u02B2\u02BF\u02C0\u02B5\u02C1\u02B4().Add(colorSettings2);
		}
		foreach (string text5 in this.\u02C0\u02C1\u02B7\u02BF\u02B8\u02B9\u02B8\u02BC\u02BD\u02C1\u02BC())
		{
			Settings.Load("Continue" + text5);
		}
	}

	private string \u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB;

	private ColorSettings \u02B5\u02B9\u02BD\u02C1\u02B5\u02B8\u02B5\u02BD\u02BA\u02B7\u02B3;

	public string \u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0 = "DefaultColors";
}
