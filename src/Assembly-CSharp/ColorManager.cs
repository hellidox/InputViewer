using System;
using System.Collections.Generic;
using System.IO;
using StrikeCore;
using UnityEngine;

// Token: 0x02000042 RID: 66
public class ColorManager : MonoBehaviour
{
	// Token: 0x06000281 RID: 641 RVA: 0x0000717B File Offset: 0x0000537B
	private void \u02B9\u02B7\u02BB\u02B7\u02BF\u02B6\u02BE\u02B5\u02C1\u02B9\u02BF(List<ColorSettings> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BF\u02B5\u02B2\u02B6\u02B2\u02B3\u02C0\u02C0\u02C1\u02BA>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000282 RID: 642 RVA: 0x00007184 File Offset: 0x00005384
	// (set) Token: 0x06000293 RID: 659 RVA: 0x0000717B File Offset: 0x0000537B
	public List<ColorSettings> \u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2 { get; private set; }

	// Token: 0x06000283 RID: 643 RVA: 0x0000718C File Offset: 0x0000538C
	private void \u02BB\u02BF\u02B6\u02B4\u02B4\u02B5\u02B9\u02B3\u02B9\u02B6\u02BD(List<string> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06000284 RID: 644 RVA: 0x0000718C File Offset: 0x0000538C
	private void \u02BB\u02BB\u02B4\u02B5\u02BB\u02C1\u02C1\u02C0\u02B7\u02B5\u02B4(List<string> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06000285 RID: 645 RVA: 0x00025D24 File Offset: 0x00023F24
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

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000286 RID: 646 RVA: 0x00007195 File Offset: 0x00005395
	// (set) Token: 0x06000296 RID: 662 RVA: 0x0000718C File Offset: 0x0000538C
	public List<string> \u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD { get; private set; }

	// Token: 0x06000287 RID: 647 RVA: 0x0000717B File Offset: 0x0000537B
	private void \u02B7\u02C1\u02B5\u02C1\u02B9\u02B5\u02B7\u02BC\u02BC\u02BF\u02B3(List<ColorSettings> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BF\u02B5\u02B2\u02B6\u02B2\u02B3\u02C0\u02C0\u02C1\u02BA>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00007195 File Offset: 0x00005395
	public List<string> \u02C0\u02C1\u02B7\u02BF\u02B8\u02B9\u02B8\u02BC\u02BD\u02C1\u02BC()
	{
		return this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField;
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00025E14 File Offset: 0x00024014
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

	// Token: 0x0600028A RID: 650 RVA: 0x00007184 File Offset: 0x00005384
	public List<ColorSettings> \u02BC\u02BA\u02B7\u02B7\u02BE\u02B3\u02B5\u02C1\u02B5\u02B6\u02C0()
	{
		return this.<\u02B8\u02BF\u02B5\u02B2\u02B6\u02B2\u02B3\u02C0\u02C0\u02C1\u02BA>k__BackingField;
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00025F04 File Offset: 0x00024104
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

	// Token: 0x0600028C RID: 652 RVA: 0x0000718C File Offset: 0x0000538C
	private void \u02BE\u02B6\u02B3\u02B2\u02BF\u02C1\u02B9\u02B8\u02C0\u02B2\u02BE(List<string> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x0600028D RID: 653 RVA: 0x00025F44 File Offset: 0x00024144
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

	// Token: 0x0600028E RID: 654 RVA: 0x00007195 File Offset: 0x00005395
	public List<string> \u02B8\u02B7\u02BF\u02C1\u02B2\u02B8\u02B6\u02B4\u02B9\u02BF\u02BB()
	{
		return this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField;
	}

	// Token: 0x0600028F RID: 655 RVA: 0x00007184 File Offset: 0x00005384
	public List<ColorSettings> \u02BC\u02BB\u02B9\u02BF\u02B7\u02C1\u02B4\u02BD\u02B3\u02B2\u02BA()
	{
		return this.<\u02B8\u02BF\u02B5\u02B2\u02B6\u02B2\u02B3\u02C0\u02C0\u02C1\u02BA>k__BackingField;
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00025F84 File Offset: 0x00024184
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

	// Token: 0x06000291 RID: 657 RVA: 0x00025FC8 File Offset: 0x000241C8
	public void \u02B3\u02B2\u02BD\u02B6\u02BA\u02B3\u02B2\u02B4\u02B7\u02BF\u02BA()
	{
		this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB = Path.Combine(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "GameColors_");
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

	// Token: 0x06000292 RID: 658 RVA: 0x000261A0 File Offset: 0x000243A0
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

	// Token: 0x06000295 RID: 661 RVA: 0x000261E4 File Offset: 0x000243E4
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

	// Token: 0x06000297 RID: 663 RVA: 0x00007184 File Offset: 0x00005384
	public List<ColorSettings> \u02C1\u02B7\u02C0\u02B3\u02BF\u02B2\u02BF\u02C0\u02B5\u02C1\u02B4()
	{
		return this.<\u02B8\u02BF\u02B5\u02B2\u02B6\u02B2\u02B3\u02C0\u02C0\u02C1\u02BA>k__BackingField;
	}

	// Token: 0x06000298 RID: 664 RVA: 0x00026228 File Offset: 0x00024428
	public void \u02B4\u02C0\u02B4\u02B6\u02BC\u02BE\u02BE\u02B8\u02BA\u02BC\u02B7()
	{
		this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB = Path.Combine(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Colors");
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

	// Token: 0x06000299 RID: 665 RVA: 0x0000718C File Offset: 0x0000538C
	private void \u02B9\u02BD\u02B9\u02B4\u02BA\u02B7\u02B8\u02C1\u02C1\u02B7\u02B8(List<string> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x0600029A RID: 666 RVA: 0x0000718C File Offset: 0x0000538C
	private void \u02B5\u02B6\u02B4\u02B2\u02B2\u02B7\u02B9\u02B5\u02BB\u02C0\u02B2(List<string> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x0600029B RID: 667 RVA: 0x00007195 File Offset: 0x00005395
	public List<string> \u02C0\u02BA\u02B8\u02BC\u02B6\u02B7\u02BD\u02B3\u02B4\u02B3\u02BC()
	{
		return this.<\u02B8\u02BD\u02B8\u02BB\u02B5\u02B7\u02B8\u02B6\u02C1\u02B7\u02B5>k__BackingField;
	}

	// Token: 0x0600029C RID: 668 RVA: 0x00007184 File Offset: 0x00005384
	public List<ColorSettings> \u02B5\u02B6\u02BC\u02BF\u02B8\u02C1\u02B9\u02BE\u02B3\u02C0\u02B9()
	{
		return this.<\u02B8\u02BF\u02B5\u02B2\u02B6\u02B2\u02B3\u02C0\u02C0\u02C1\u02BA>k__BackingField;
	}

	// Token: 0x0600029D RID: 669 RVA: 0x00026400 File Offset: 0x00024600
	public void \u02BB\u02B4\u02B7\u02B9\u02BD\u02B8\u02B3\u02BA\u02B2\u02BF\u02B8()
	{
		this.\u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB = Path.Combine(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Dynamics");
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

	// Token: 0x04000182 RID: 386
	private string \u02C0\u02BF\u02BD\u02B2\u02B5\u02BA\u02C1\u02C1\u02BD\u02C0\u02BB;

	// Token: 0x04000183 RID: 387
	private ColorSettings \u02B5\u02B9\u02BD\u02C1\u02B5\u02B8\u02B5\u02BD\u02BA\u02B7\u02B3;

	// Token: 0x04000184 RID: 388
	public string \u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0 = "DefaultColors";
}
