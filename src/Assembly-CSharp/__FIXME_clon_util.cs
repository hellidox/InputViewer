using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Cysharp.Text;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200004C RID: 76
public static class __FIXME_clon_util
{
	// Token: 0x0600032B RID: 811 RVA: 0x0002AF4C File Offset: 0x0002914C
	public static ushort \u02BE\u02BB\u02B6\u02B7\u02B8\u02C0\u02BF\u02B5\u02C0\u02B6\u02B6(ushort \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8, int \u02B6\u02BE\u02B8\u02BB\u02B3\u02B4\u02B7\u02B4\u02B6\u02B7\u02BB)
	{
		int num = 0;
		while (\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 != 0)
		{
			if (num == \u02B6\u02BE\u02B8\u02BB\u02B3\u02B4\u02B7\u02B4\u02B6\u02B7\u02BB)
			{
				return \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 & ~(\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 - 1);
			}
			\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 &= \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 - 1;
			num++;
		}
		return 0;
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0002AF7C File Offset: 0x0002917C
	public static int \u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(ushort \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8)
	{
		int num = 0;
		while (\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 != 0)
		{
			num++;
			\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 &= \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 - 1;
		}
		return num;
	}

	// Token: 0x0600032D RID: 813 RVA: 0x0002AFA0 File Offset: 0x000291A0
	public static float \u02B4\u02BD\u02B2\u02B2\u02B5\u02B4\u02BB\u02B8\u02B6\u02BE\u02BB(float \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5, int \u02BE\u02BF\u02B5\u02B3\u02B5\u02BD\u02B4\u02B8\u02C1\u02B9\u02B6)
	{
		float num = (float)Math.Pow(10.0, (double)\u02BE\u02BF\u02B5\u02B3\u02B5\u02BD\u02B4\u02B8\u02C1\u02B9\u02B6);
		return (float)((long)(\u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5 * num)) / num;
	}

	// Token: 0x0600032E RID: 814 RVA: 0x0000786E File Offset: 0x00005A6E
	public static __FIXME_clon_util.\u02C0\u02BF\u02B7\u02BA\u02B6\u02BA\u02B2\u02B4\u02B5\u02B8\u02B9 \u02C1\u02BF\u02B8\u02B2\u02BA\u02B3\u02B4\u02B3\u02C1\u02BC\u02BE(uint \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8)
	{
		return new __FIXME_clon_util.\u02C0\u02BF\u02B7\u02BA\u02B6\u02BA\u02B2\u02B4\u02B5\u02B8\u02B9(\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8);
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00007876 File Offset: 0x00005A76
	public static __FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA \u02B8\u02C0\u02BA\u02BB\u02B6\u02BA\u02BA\u02C0\u02B4\u02C1\u02B9(ushort \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8)
	{
		return new __FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA(\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8);
	}

	// Token: 0x06000330 RID: 816 RVA: 0x0002AFC8 File Offset: 0x000291C8
	public static string[] \u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(string \u02BF\u02B2\u02BE\u02C1\u02B3\u02B5\u02BD\u02B9\u02B9\u02C0\u02BC, string \u02B7\u02C1\u02BA\u02B9\u02BB\u02B7\u02B2\u02B6\u02C0\u02B6\u02BA, SearchOption \u02BE\u02C1\u02B8\u02C0\u02BF\u02BC\u02B8\u02B9\u02BC\u02BD\u02BB)
	{
		string[] array = \u02B7\u02C1\u02BA\u02B9\u02BB\u02B7\u02B2\u02B6\u02C0\u02B6\u02BA.Split('|', StringSplitOptions.None);
		IEnumerable<string> enumerable;
		if (\u02BE\u02C1\u02B8\u02C0\u02BF\u02BC\u02B8\u02B9\u02BC\u02BD\u02BB == SearchOption.TopDirectoryOnly)
		{
			enumerable = Directory.EnumerateFiles(\u02BF\u02B2\u02BE\u02C1\u02B3\u02B5\u02BD\u02B9\u02B9\u02C0\u02BC);
		}
		else
		{
			enumerable = Directory.EnumerateFiles(\u02BF\u02B2\u02BE\u02C1\u02B3\u02B5\u02BD\u02B9\u02B9\u02C0\u02BC, "*", \u02BE\u02C1\u02B8\u02C0\u02BF\u02BC\u02B8\u02B9\u02BC\u02BD\u02BB);
		}
		if (__FIXME_clon_util.\u02BB\u02B6\u02C1\u02B3\u02B5\u02BA\u02BE\u02B2\u02B7\u02B6\u02BD == null)
		{
			__FIXME_clon_util.\u02BB\u02B6\u02C1\u02B3\u02B5\u02BA\u02BE\u02B2\u02B7\u02B6\u02BD = new List<string>();
		}
		else
		{
			__FIXME_clon_util.\u02BB\u02B6\u02C1\u02B3\u02B5\u02BA\u02BE\u02B2\u02B7\u02B6\u02BD.Clear();
		}
		foreach (string text in enumerable)
		{
			string extension = Path.GetExtension(text);
			foreach (string text2 in array)
			{
				if (extension.Equals(text2, StringComparison.OrdinalIgnoreCase))
				{
					__FIXME_clon_util.\u02BB\u02B6\u02C1\u02B3\u02B5\u02BA\u02BE\u02B2\u02B7\u02B6\u02BD.Add(text);
					break;
				}
			}
		}
		return __FIXME_clon_util.\u02BB\u02B6\u02C1\u02B3\u02B5\u02BA\u02BE\u02B2\u02B7\u02B6\u02BD.ToArray();
	}

	// Token: 0x06000331 RID: 817 RVA: 0x0002B094 File Offset: 0x00029294
	public static string \u02BB\u02BD\u02B6\u02B4\u02BE\u02C1\u02B4\u02BD\u02B9\u02C0\u02BC(string \u02BB\u02C0\u02BF\u02B2\u02B8\u02BF\u02B8\u02B5\u02C0\u02BA\u02C1, string[] \u02C1\u02B9\u02B8\u02B2\u02BD\u02C1\u02B4\u02B3\u02B6\u02B6\u02B2, int \u02B7\u02BB\u02BB\u02BC\u02C1\u02BC\u02B8\u02B4\u02B2\u02BC\u02B2)
	{
		for (int i = ((\u02B7\u02BB\u02BB\u02BC\u02C1\u02BC\u02B8\u02B4\u02B2\u02BC\u02B2 == -1) ? 0 : \u02B7\u02BB\u02BB\u02BC\u02C1\u02BC\u02B8\u02B4\u02B2\u02BC\u02B2); i < \u02C1\u02B9\u02B8\u02B2\u02BD\u02C1\u02B4\u02B3\u02B6\u02B6\u02B2.Length; i++)
		{
			string text = \u02BB\u02C0\u02BF\u02B2\u02B8\u02BF\u02B8\u02B5\u02C0\u02BA\u02C1 + \u02C1\u02B9\u02B8\u02B2\u02BD\u02C1\u02B4\u02B3\u02B6\u02B6\u02B2[i];
			if (File.Exists(text))
			{
				return text;
			}
			if (\u02B7\u02BB\u02BB\u02BC\u02C1\u02BC\u02B8\u02B4\u02B2\u02BC\u02B2 != -1)
			{
				break;
			}
		}
		return null;
	}

	// Token: 0x06000332 RID: 818 RVA: 0x0000787E File Offset: 0x00005A7E
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint \u02B4\u02BD\u02B8\u02BF\u02BC\u02B8\u02C1\u02B7\u02BF\u02B9\u02B8(uint \u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF)
	{
		return \u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF & ~(\u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF - 1U);
	}

	// Token: 0x06000333 RID: 819 RVA: 0x00007886 File Offset: 0x00005A86
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint \u02B7\u02B9\u02BE\u02C1\u02B3\u02B8\u02B2\u02BE\u02B4\u02BE\u02BF(uint \u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF)
	{
		\u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF |= \u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF >> 1;
		\u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF |= \u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF >> 2;
		\u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF |= \u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF >> 4;
		\u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF |= \u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF >> 8;
		\u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF |= \u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF >> 16;
		return \u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF & ~(\u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF >> 1);
	}

	// Token: 0x06000334 RID: 820 RVA: 0x0002B0D4 File Offset: 0x000292D4
	public static string \u02BB\u02BD\u02B6\u02B4\u02BE\u02C1\u02B4\u02BD\u02B9\u02C0\u02BC(string[] \u02C1\u02BC\u02BE\u02BC\u02B5\u02BD\u02C0\u02BC\u02BC\u02B9\u02BA, string[] \u02C1\u02B9\u02B8\u02B2\u02BD\u02C1\u02B4\u02B3\u02B6\u02B6\u02B2, int \u02B7\u02BB\u02BB\u02BC\u02C1\u02BC\u02B8\u02B4\u02B2\u02BC\u02B2)
	{
		for (int i = 0; i < \u02C1\u02BC\u02BE\u02BC\u02B5\u02BD\u02C0\u02BC\u02BC\u02B9\u02BA.Length; i++)
		{
			if (__FIXME_clon_util.\u02BB\u02BD\u02B6\u02B4\u02BE\u02C1\u02B4\u02BD\u02B9\u02C0\u02BC(\u02C1\u02BC\u02BE\u02BC\u02B5\u02BD\u02C0\u02BC\u02BC\u02B9\u02BA[i], \u02C1\u02B9\u02B8\u02B2\u02BD\u02C1\u02B4\u02B3\u02B6\u02B6\u02B2, \u02B7\u02BB\u02BB\u02BC\u02C1\u02BC\u02B8\u02B4\u02B2\u02BC\u02B2) != null)
			{
				return __FIXME_clon_util.\u02BB\u02BD\u02B6\u02B4\u02BE\u02C1\u02B4\u02BD\u02B9\u02C0\u02BC(\u02C1\u02BC\u02BE\u02BC\u02B5\u02BD\u02C0\u02BC\u02BC\u02B9\u02BA[i], \u02C1\u02B9\u02B8\u02B2\u02BD\u02C1\u02B4\u02B3\u02B6\u02B6\u02B2, \u02B7\u02BB\u02BB\u02BC\u02C1\u02BC\u02B8\u02B4\u02B2\u02BC\u02B2);
			}
		}
		return null;
	}

	// Token: 0x06000335 RID: 821 RVA: 0x000078B2 File Offset: 0x00005AB2
	public static string \u02BD\u02C1\u02C0\u02BA\u02B6\u02B4\u02BF\u02B9\u02B3\u02BD\u02C0()
	{
		return Path.Combine(Path.Combine(Application.dataPath, "Plugins"), "x86_64");
	}

	// Token: 0x06000336 RID: 822 RVA: 0x0002B108 File Offset: 0x00029308
	public static bool \u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		bool flag = Directory.Exists(\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC);
		if (!flag)
		{
			try
			{
				Directory.CreateDirectory(\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC);
			}
			catch (Exception ex)
			{
				Debug.LogException(ex);
			}
		}
		return flag;
	}

	// Token: 0x06000337 RID: 823 RVA: 0x0002B140 File Offset: 0x00029340
	public static void \u02BA\u02BB\u02B7\u02B4\u02B2\u02BC\u02B4\u02B2\u02B9\u02B3\u02BD(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		string text = "explorer.exe";
		if (text != null)
		{
			Process.Start(text, "\"" + \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC + "\"");
		}
	}

	// Token: 0x06000338 RID: 824 RVA: 0x0002B170 File Offset: 0x00029370
	public static string \u02BF\u02B9\u02B9\u02C1\u02B7\u02B6\u02B6\u02B5\u02B3\u02B3\u02B8()
	{
		string text = "";
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		if (commandLineArgs != null && commandLineArgs.Length > 1)
		{
			for (int i = 1; i < commandLineArgs.Length; i++)
			{
				text = text + commandLineArgs[i] + " ";
			}
		}
		return text;
	}

	// Token: 0x06000339 RID: 825 RVA: 0x0002B1B0 File Offset: 0x000293B0
	public static byte[] \u02BF\u02BA\u02BD\u02BE\u02B2\u02B2\u02B2\u02B7\u02B5\u02B7\u02BE(byte[] \u02B3\u02BC\u02B7\u02BF\u02B6\u02BD\u02C1\u02BD\u02C0\u02B4\u02BC)
	{
		MemoryStream memoryStream = new MemoryStream();
		\u02BA\u02C0\u02BF\u02B7\u02BC\u02BB\u02BA\u02B4\u02BB\u02B2\u02C0 u02BA_u02C0_u02BF_u02B7_u02BC_u02BB_u02BA_u02B4_u02BB_u02B2_u02C = new \u02BA\u02C0\u02BF\u02B7\u02BC\u02BB\u02BA\u02B4\u02BB\u02B2\u02C0(256, 239, 16, 285);
		using (\u02BD\u02B5\u02C1\u02B5\u02B2\u02C1\u02BD\u02B8\u02B7\u02B8\u02C0 u02BD_u02B5_u02C1_u02B5_u02B2_u02C1_u02BD_u02B8_u02B7_u02B8_u02C = new \u02BD\u02B5\u02C1\u02B5\u02B2\u02C1\u02BD\u02B8\u02B7\u02B8\u02C0(memoryStream, u02BA_u02C0_u02BF_u02B7_u02BC_u02BB_u02BA_u02B4_u02BB_u02B2_u02C))
		{
			using (\u02BD\u02B5\u02B9\u02B5\u02B5\u02B3\u02B4\u02BD\u02B4\u02C0\u02BE u02BD_u02B5_u02B9_u02B5_u02B5_u02B3_u02B4_u02BD_u02B4_u02C0_u02BE = new \u02BD\u02B5\u02B9\u02B5\u02B5\u02B3\u02B4\u02BD\u02B4\u02C0\u02BE(u02BD_u02B5_u02C1_u02B5_u02B2_u02C1_u02BD_u02B8_u02B7_u02B8_u02C, u02BA_u02C0_u02BF_u02B7_u02BC_u02BB_u02BA_u02B4_u02BB_u02B2_u02C.\u02B3\u02C0\u02B2\u02C0\u02BA\u02BF\u02B6\u02BA\u02B6\u02B8\u02BD))
			{
				u02BD_u02B5_u02B9_u02B5_u02B5_u02B3_u02B4_u02BD_u02B4_u02C0_u02BE.Write(\u02B3\u02BC\u02B7\u02BF\u02B6\u02BD\u02C1\u02BD\u02C0\u02B4\u02BC, 0, \u02B3\u02BC\u02B7\u02BF\u02B6\u02BD\u02C1\u02BD\u02C0\u02B4\u02BC.Length);
				u02BD_u02B5_u02B9_u02B5_u02B5_u02B3_u02B4_u02BD_u02B4_u02C0_u02BE.Flush();
			}
		}
		return memoryStream.ToArray();
	}

	// Token: 0x0600033A RID: 826 RVA: 0x000078CD File Offset: 0x00005ACD
	public static void \u02B3\u02BC\u02B9\u02BD\u02BB\u02B6\u02B5\u02B9\u02BC\u02BD\u02BE(string \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5)
	{
		Process.Start(Path.Combine(Directory.GetParent(Application.dataPath).FullName, Process.GetCurrentProcess().ProcessName + ".exe"), \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5);
		Application.Quit();
	}

	// Token: 0x0600033B RID: 827 RVA: 0x00007903 File Offset: 0x00005B03
	public static string GetDocumentsClonFolder()
	{
		if (GlobalVariables.\u02B4\u02B8\u02BB\u02B6\u02B8\u02B6\u02BA\u02BA\u02B3\u02B3\u02B6)
		{
			return Path.Combine(Directory.GetParent(Application.dataPath).FullName, "PlayerData");
		}
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Clone Hero");
	}

	// Token: 0x0600033C RID: 828 RVA: 0x00007936 File Offset: 0x00005B36
	public static string \u02B3\u02B8\u02BF\u02B8\u02BF\u02BB\u02B7\u02B4\u02B7\u02BB\u02BD()
	{
		if (GlobalVariables.\u02B4\u02B8\u02BB\u02B6\u02B8\u02B6\u02BA\u02BA\u02B3\u02B3\u02B6)
		{
			return Path.Combine(Directory.GetParent(Application.dataPath).FullName, "GameData");
		}
		return Application.persistentDataPath;
	}

	// Token: 0x0600033D RID: 829 RVA: 0x0002B238 File Offset: 0x00029438
	public static float \u02B5\u02B9\u02C1\u02BB\u02B6\u02B3\u02BA\u02BE\u02B9\u02B5\u02BF(double \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5, double \u02B9\u02BD\u02C1\u02C0\u02BA\u02C0\u02C0\u02B6\u02B5\u02B6\u02C1, float \u02BB\u02BE\u02B6\u02B5\u02BD\u02BF\u02C1\u02B9\u02B4\u02B3\u02B9, float \u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4)
	{
		double num = \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 - \u02B9\u02BD\u02C1\u02C0\u02BA\u02C0\u02C0\u02B6\u02B5\u02B6\u02C1;
		return (float)((double)\u02BB\u02BE\u02B6\u02B5\u02BD\u02BF\u02C1\u02B9\u02B4\u02B3\u02B9 + num * (double)\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4);
	}

	// Token: 0x0600033E RID: 830 RVA: 0x0000795E File Offset: 0x00005B5E
	public static float \u02C1\u02BA\u02B7\u02C1\u02BB\u02B9\u02B9\u02BB\u02BC\u02B9\u02B8(float \u02BC\u02B6\u02B7\u02B5\u02C0\u02B8\u02BF\u02B8\u02B9\u02BA\u02BB, double \u02B9\u02BD\u02C1\u02C0\u02BA\u02C0\u02C0\u02B6\u02B5\u02B6\u02C1, float \u02BB\u02BE\u02B6\u02B5\u02BD\u02BF\u02C1\u02B9\u02B4\u02B3\u02B9, float \u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4)
	{
		return (float)(\u02B9\u02BD\u02C1\u02C0\u02BA\u02C0\u02C0\u02B6\u02B5\u02B6\u02C1 + (double)((\u02BC\u02B6\u02B7\u02B5\u02C0\u02B8\u02BF\u02B8\u02B9\u02BA\u02BB - \u02BB\u02BE\u02B6\u02B5\u02BD\u02BF\u02C1\u02B9\u02B4\u02B3\u02B9) / \u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4));
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00007969 File Offset: 0x00005B69
	public static IEnumerable<uint> \u02B4\u02BC\u02BF\u02B8\u02BD\u02C1\u02B4\u02B4\u02B2\u02C0\u02B4(string \u02BF\u02B3\u02BC\u02C1\u02C1\u02BC\u02B6\u02B5\u02B8\u02C1\u02BA)
	{
		TextElementEnumerator tee = StringInfo.GetTextElementEnumerator(\u02BF\u02B3\u02BC\u02C1\u02C1\u02BC\u02B6\u02B5\u02B8\u02C1\u02BA);
		while (tee.MoveNext())
		{
			yield return (uint)char.ConvertToUtf32(\u02BF\u02B3\u02BC\u02C1\u02C1\u02BC\u02B6\u02B5\u02B8\u02C1\u02BA, tee.ElementIndex);
		}
		yield break;
	}

	// Token: 0x06000340 RID: 832 RVA: 0x0002B254 File Offset: 0x00029454
	public static string \u02B4\u02B3\u02B9\u02B6\u02BC\u02B7\u02BC\u02BA\u02B3\u02BB\u02B6(uint[] \u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4)
	{
		string[] array = new string[\u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4.Length];
		for (int i = 0; i < \u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4.Length; i++)
		{
			array[i] = char.ConvertFromUtf32((int)\u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4[i]);
		}
		return string.Concat(array);
	}

	// Token: 0x06000341 RID: 833 RVA: 0x0002B28C File Offset: 0x0002948C
	public static __FIXME_clon_util.GraphicsAPI SupportedGraphicsAPIs()
	{
		RuntimePlatform platform = Application.platform;
		if (platform <= RuntimePlatform.WindowsPlayer)
		{
			if (platform <= RuntimePlatform.OSXPlayer)
			{
				return __FIXME_clon_util.GraphicsAPI.Metal;
			}
			if (platform != RuntimePlatform.WindowsPlayer)
			{
				return __FIXME_clon_util.GraphicsAPI.DX11;
			}
		}
		else if (platform != RuntimePlatform.WindowsEditor)
		{
			if (platform == RuntimePlatform.LinuxPlayer || platform == RuntimePlatform.LinuxEditor)
			{
				return __FIXME_clon_util.GraphicsAPI.OpenGL | __FIXME_clon_util.GraphicsAPI.Vulkan;
			}
			return __FIXME_clon_util.GraphicsAPI.DX11;
		}
		return __FIXME_clon_util.GraphicsAPI.DX11 | __FIXME_clon_util.GraphicsAPI.DX12 | __FIXME_clon_util.GraphicsAPI.OpenGL | __FIXME_clon_util.GraphicsAPI.Vulkan;
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00007979 File Offset: 0x00005B79
	public static GraphicsDeviceType \u02BA\u02B5\u02BD\u02BF\u02B3\u02B3\u02B6\u02BC\u02BF\u02C0\u02B8(__FIXME_clon_util.GraphicsAPI \u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF)
	{
		if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF <= __FIXME_clon_util.GraphicsAPI.DX12)
		{
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.DX11)
			{
				return GraphicsDeviceType.Direct3D11;
			}
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.DX12)
			{
				return GraphicsDeviceType.Direct3D12;
			}
		}
		else
		{
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.Metal)
			{
				return GraphicsDeviceType.Metal;
			}
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.OpenGL)
			{
				return GraphicsDeviceType.OpenGLCore;
			}
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.Vulkan)
			{
				return GraphicsDeviceType.Vulkan;
			}
		}
		return GraphicsDeviceType.Null;
	}

	// Token: 0x06000343 RID: 835 RVA: 0x000079A8 File Offset: 0x00005BA8
	public static string \u02BF\u02BD\u02B3\u02B2\u02B2\u02BA\u02B6\u02B2\u02C1\u02B4\u02C1(__FIXME_clon_util.GraphicsAPI \u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF)
	{
		if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF <= __FIXME_clon_util.GraphicsAPI.DX12)
		{
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.DX11)
			{
				return "-force-d3d11";
			}
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.DX12)
			{
				return "-force-d3d12";
			}
		}
		else
		{
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.Metal)
			{
				return "-force-metal";
			}
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.OpenGL)
			{
				return "-force-glcore";
			}
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.Vulkan)
			{
				return "--force-vulkan";
			}
		}
		return null;
	}

	// Token: 0x06000344 RID: 836 RVA: 0x000079E7 File Offset: 0x00005BE7
	public static string \u02B9\u02B6\u02C0\u02B9\u02B3\u02BA\u02B8\u02BF\u02B4\u02BE\u02BB(__FIXME_clon_util.GraphicsAPI \u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF)
	{
		if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF <= __FIXME_clon_util.GraphicsAPI.DX12)
		{
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.DX11)
			{
				return "DirectX 11";
			}
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.DX12)
			{
				return "DirectX 12 (Experimental)";
			}
		}
		else
		{
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.Metal)
			{
				return "Metal";
			}
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.OpenGL)
			{
				return "OpenGL";
			}
			if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF == __FIXME_clon_util.GraphicsAPI.Vulkan)
			{
				return "Vulkan";
			}
		}
		return null;
	}

	// Token: 0x06000345 RID: 837 RVA: 0x0002B2C4 File Offset: 0x000294C4
	public static bool \u02B4\u02B4\u02C0\u02C1\u02BF\u02B5\u02B4\u02BD\u02B2\u02B2\u02BE()
	{
		string text = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString().ToLowerInvariant());
		File.CreateText(text).Close();
		bool flag = File.Exists(text.ToUpperInvariant());
		File.Delete(text);
		return !flag;
	}

	// Token: 0x06000346 RID: 838 RVA: 0x0002B314 File Offset: 0x00029514
	public unsafe static string \u02BB\u02B4\u02B7\u02BB\u02BB\u02BD\u02C1\u02BD\u02BC\u02B9\u02BE(string \u02BB\u02C0\u02BF\u02B2\u02B8\u02BF\u02B8\u02B5\u02C0\u02BA\u02C1)
	{
		int num = \u02BB\u02C0\u02BF\u02B2\u02B8\u02BF\u02B8\u02B5\u02C0\u02BA\u02C1.IndexOfAny(__FIXME_clon_util.\u02C1\u02C0\u02B8\u02C1\u02C0\u02BC\u02B3\u02B5\u02B7\u02B4\u02BD);
		if (num == -1)
		{
			return \u02BB\u02C0\u02BF\u02B2\u02B8\u02BF\u02B8\u02B5\u02C0\u02BA\u02C1;
		}
		int length = \u02BB\u02C0\u02BF\u02B2\u02B8\u02BF\u02B8\u02B5\u02C0\u02BA\u02C1.Length;
		Span<char> span;
		ReadOnlySpan<char> readOnlySpan;
		ReadOnlySpan<char> readOnlySpan2;
		int num2;
		Span<char> span2;
		checked
		{
			span = new Span<char>(stackalloc byte[unchecked((UIntPtr)length) * 2], length);
			readOnlySpan = __FIXME_clon_util.\u02C1\u02C0\u02B8\u02C1\u02C0\u02BC\u02B3\u02B5\u02B7\u02B4\u02BD;
			readOnlySpan2 = \u02BB\u02C0\u02BF\u02B2\u02B8\u02BF\u02B8\u02B5\u02C0\u02BA\u02C1;
			num2 = 0;
			span2 = span;
		}
		do
		{
			num2++;
			if (num > 0)
			{
				readOnlySpan2.Slice(0, num).CopyTo(span2);
			}
			if (num == readOnlySpan2.Length - 1)
			{
				break;
			}
			span2 = span2.Slice(num);
			readOnlySpan2 = readOnlySpan2.Slice(num + 1);
			num = readOnlySpan2.IndexOfAny(readOnlySpan);
			if (num == -1)
			{
				readOnlySpan2.CopyTo(span2);
			}
		}
		while (num != -1);
		return new string(span.Slice(0, span.Length - num2));
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00007A26 File Offset: 0x00005C26
	public static string \u02B4\u02B6\u02BE\u02B5\u02BB\u02BA\u02BB\u02C0\u02C1\u02C1\u02B7()
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			return Path.Combine(Application.persistentDataPath, "streamingAssets");
		}
		return Application.streamingAssetsPath;
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00007A46 File Offset: 0x00005C46
	public static string \u02BF\u02B8\u02BD\u02BA\u02BC\u02B4\u02BE\u02B6\u02BE\u02C1\u02B2(bool \u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA)
	{
		return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(\u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA ? "Enabled" : "Disabled");
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00007A61 File Offset: 0x00005C61
	internal static string \u02BB\u02B6\u02B4\u02BC\u02B5\u02B9\u02BA\u02BD\u02B7\u02B4\u02B3()
	{
		return string.Format("{0}/cached-thumbs", Application.persistentDataPath);
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00007A72 File Offset: 0x00005C72
	public static Color HexColorToColor(HexColor \u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2, float \u02B6\u02B8\u02BD\u02BF\u02BE\u02B8\u02B9\u02BB\u02C1\u02C1\u02C0 = 1f)
	{
		return new Color((float)\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2.Red / 255f, (float)\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2.Green / 255f, (float)\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2.Blue / 255f, \u02B6\u02B8\u02BD\u02BF\u02BE\u02B8\u02B9\u02BB\u02C1\u02C1\u02C0);
	}

	// Token: 0x0600034B RID: 843 RVA: 0x0002B3D8 File Offset: 0x000295D8
	public static void \u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(this TMP_Text \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF, Utf16ValueStringBuilder \u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA)
	{
		ArraySegment<char> arraySegment = \u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.AsArraySegment();
		\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.SetCharArray(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
	}

	// Token: 0x0400023F RID: 575
	[ThreadStatic]
	private static List<string> \u02BB\u02B6\u02C1\u02B3\u02B5\u02BA\u02BE\u02B2\u02B7\u02B6\u02BD = new List<string>();

	// Token: 0x04000240 RID: 576
	private static char[] \u02C1\u02C0\u02B8\u02C1\u02C0\u02BC\u02B3\u02B5\u02B7\u02B4\u02BD = Path.GetInvalidFileNameChars();

	// Token: 0x0200004D RID: 77
	public struct \u02C0\u02BF\u02B7\u02BA\u02B6\u02BA\u02B2\u02B4\u02B5\u02B8\u02B9
	{
		// Token: 0x0600034D RID: 845 RVA: 0x00007AB7 File Offset: 0x00005CB7
		public bool \u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC()
		{
			this.\u02BE\u02BC\u02C0\u02C0\u02BE\u02BB\u02BE\u02B3\u02B7\u02BB\u02B3 = this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8;
			this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 &= this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 - 1U;
			return this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 != 0U || this.\u02BE\u02BC\u02C0\u02C0\u02BE\u02BB\u02BE\u02B3\u02B7\u02BB\u02B3 != 0U;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00007AED File Offset: 0x00005CED
		public uint \u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF
		{
			get
			{
				return this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 ^ this.\u02BE\u02BC\u02C0\u02C0\u02BE\u02BB\u02BE\u02B3\u02B7\u02BB\u02B3;
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00007AFC File Offset: 0x00005CFC
		public \u02C0\u02BF\u02B7\u02BA\u02B6\u02BA\u02B2\u02B4\u02B5\u02B8\u02B9(uint \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8)
		{
			this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 = \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8;
			this.\u02BE\u02BC\u02C0\u02C0\u02BE\u02BB\u02BE\u02B3\u02B7\u02BB\u02B3 = \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00007B0C File Offset: 0x00005D0C
		public __FIXME_clon_util.\u02C0\u02BF\u02B7\u02BA\u02B6\u02BA\u02B2\u02B4\u02B5\u02B8\u02B9 \u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1()
		{
			return this;
		}

		// Token: 0x04000241 RID: 577
		private uint \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8;

		// Token: 0x04000242 RID: 578
		private uint \u02BE\u02BC\u02C0\u02C0\u02BE\u02BB\u02BE\u02B3\u02B7\u02BB\u02B3;
	}

	// Token: 0x0200004E RID: 78
	public struct \u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA
	{
		// Token: 0x06000351 RID: 849 RVA: 0x00007B14 File Offset: 0x00005D14
		public int \u02B6\u02B8\u02BE\u02B6\u02BA\u02B2\u02B7\u02B5\u02B8\u02BA\u02B5()
		{
			return this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00007B1C File Offset: 0x00005D1C
		public \u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA(ushort \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8)
		{
			this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 = \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8;
			this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 = ushort.MaxValue;
			this.\u02B7\u02B9\u02B4\u02BE\u02BE\u02B5\u02BC\u02B8\u02B9\u02BC\u02BC = 32768U;
			this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC = 1U;
			this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2 = 0;
			this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA = true;
			this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF = 0;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00007B14 File Offset: 0x00005D14
		public int \u02BA\u02B7\u02BD\u02BD\u02B6\u02C0\u02BE\u02B2\u02B8\u02BF\u02BF()
		{
			return this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00007B14 File Offset: 0x00005D14
		public int \u02B3\u02BF\u02BD\u02B5\u02B7\u02BB\u02BB\u02BF\u02B3\u02B4\u02B8()
		{
			return this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0002B408 File Offset: 0x00029608
		public bool \u02BC\u02B7\u02C0\u02B8\u02BF\u02BC\u02C1\u02BB\u02B6\u02BD\u02BC()
		{
			for (;;)
			{
				if (this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA)
				{
					this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA = true;
				}
				else
				{
					this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC <<= 0;
					this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 = (ushort)(this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 << 1);
				}
				if (this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC > this.\u02B7\u02B9\u02B4\u02BE\u02BE\u02B5\u02BC\u02B8\u02B9\u02BC\u02BC || (this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 & this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6) == 0)
				{
					return false;
				}
				if ((this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC & (uint)this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8) == this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC)
				{
					break;
				}
				this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF += 0;
			}
			this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2 = this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF;
			this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF++;
			return true;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00007B57 File Offset: 0x00005D57
		public __FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA \u02B3\u02B7\u02B6\u02B5\u02C1\u02C1\u02BB\u02B3\u02B3\u02BA\u02B5()
		{
			return this;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00007B57 File Offset: 0x00005D57
		public __FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA \u02BE\u02C0\u02BA\u02B2\u02BD\u02C1\u02B5\u02B8\u02BC\u02B9\u02BB()
		{
			return this;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00007B14 File Offset: 0x00005D14
		public int \u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF
		{
			get
			{
				return this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0002B4A8 File Offset: 0x000296A8
		public bool \u02B7\u02C0\u02B9\u02B7\u02B8\u02BD\u02B8\u02B9\u02B8\u02C0\u02B8()
		{
			for (;;)
			{
				if (this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA)
				{
					this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA = true;
				}
				else
				{
					this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC <<= 1;
					this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 = (ushort)(this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 << 1);
				}
				if (this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC > this.\u02B7\u02B9\u02B4\u02BE\u02BE\u02B5\u02BC\u02B8\u02B9\u02BC\u02BC || (this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 & this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6) == 0)
				{
					return false;
				}
				if ((this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC & (uint)this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8) == this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC)
				{
					break;
				}
				this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF++;
			}
			this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2 = this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF;
			this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF += 0;
			return false;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0002B548 File Offset: 0x00029748
		public bool \u02C1\u02B3\u02BB\u02BF\u02B2\u02B6\u02BE\u02BC\u02C1\u02BE\u02B6()
		{
			for (;;)
			{
				if (this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA)
				{
					this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA = true;
				}
				else
				{
					this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC <<= 0;
					this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 = (ushort)(this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 << 0);
				}
				if (this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC > this.\u02B7\u02B9\u02B4\u02BE\u02BE\u02B5\u02BC\u02B8\u02B9\u02BC\u02BC || (this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 & this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6) == 0)
				{
					return true;
				}
				if ((this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC & (uint)this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8) == this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC)
				{
					break;
				}
				this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF += 0;
			}
			this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2 = this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF;
			this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF += 0;
			return false;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0002B5E8 File Offset: 0x000297E8
		public bool \u02C0\u02BD\u02BA\u02B4\u02BB\u02B6\u02BA\u02BB\u02BB\u02BE\u02C1()
		{
			for (;;)
			{
				if (this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA)
				{
					this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA = true;
				}
				else
				{
					this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC <<= 0;
					this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 = (ushort)(this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 << 1);
				}
				if (this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC > this.\u02B7\u02B9\u02B4\u02BE\u02BE\u02B5\u02BC\u02B8\u02B9\u02BC\u02BC || (this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 & this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6) == 0)
				{
					return true;
				}
				if ((this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC & (uint)this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8) == this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC)
				{
					break;
				}
				this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF++;
			}
			this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2 = this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF;
			this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF += 0;
			return false;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00007B14 File Offset: 0x00005D14
		public int \u02B7\u02B8\u02BD\u02BA\u02BB\u02B7\u02BF\u02B8\u02B3\u02BF\u02BF()
		{
			return this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0002B688 File Offset: 0x00029888
		public bool \u02B4\u02B9\u02B3\u02B8\u02BE\u02B6\u02BA\u02BF\u02BB\u02C1\u02C1()
		{
			for (;;)
			{
				if (this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA)
				{
					this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA = false;
				}
				else
				{
					this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC <<= 1;
					this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 = (ushort)(this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 << 0);
				}
				if (this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC > this.\u02B7\u02B9\u02B4\u02BE\u02BE\u02B5\u02BC\u02B8\u02B9\u02BC\u02BC || (this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 & this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6) == 0)
				{
					return true;
				}
				if ((this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC & (uint)this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8) == this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC)
				{
					break;
				}
				this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF++;
			}
			this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2 = this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF;
			this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF += 0;
			return false;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00007B57 File Offset: 0x00005D57
		public __FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA \u02B3\u02BF\u02B6\u02B4\u02B4\u02BC\u02C0\u02C0\u02B5\u02B2\u02C0()
		{
			return this;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00007B57 File Offset: 0x00005D57
		public __FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA \u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1()
		{
			return this;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0002B728 File Offset: 0x00029928
		public bool \u02B3\u02B6\u02BF\u02B8\u02C0\u02B4\u02BD\u02B5\u02B4\u02B6\u02B4()
		{
			for (;;)
			{
				if (this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA)
				{
					this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA = true;
				}
				else
				{
					this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC <<= 1;
					this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 = (ushort)(this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 << 1);
				}
				if (this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC > this.\u02B7\u02B9\u02B4\u02BE\u02BE\u02B5\u02BC\u02B8\u02B9\u02BC\u02BC || (this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 & this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6) == 0)
				{
					return false;
				}
				if ((this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC & (uint)this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8) == this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC)
				{
					break;
				}
				this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF += 0;
			}
			this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2 = this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF;
			this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF += 0;
			return false;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0002B7C8 File Offset: 0x000299C8
		public bool \u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC()
		{
			for (;;)
			{
				if (this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA)
				{
					this.\u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA = false;
				}
				else
				{
					this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC <<= 1;
					this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 = (ushort)(this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6 << 1);
				}
				if (this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC > this.\u02B7\u02B9\u02B4\u02BE\u02BE\u02B5\u02BC\u02B8\u02B9\u02BC\u02BC || (this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 & this.\u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6) == 0)
				{
					return false;
				}
				if ((this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC & (uint)this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8) == this.\u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC)
				{
					break;
				}
				this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF++;
			}
			this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2 = this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF;
			this.\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF++;
			return true;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00007B14 File Offset: 0x00005D14
		public int \u02BE\u02B8\u02B2\u02B9\u02BB\u02B3\u02B2\u02BC\u02B9\u02B8\u02B2()
		{
			return this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
		}

		// Token: 0x04000243 RID: 579
		private ushort \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8;

		// Token: 0x04000244 RID: 580
		private ushort \u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6;

		// Token: 0x04000245 RID: 581
		private uint \u02B7\u02B9\u02B4\u02BE\u02BE\u02B5\u02BC\u02B8\u02B9\u02BC\u02BC;

		// Token: 0x04000246 RID: 582
		private uint \u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC;

		// Token: 0x04000247 RID: 583
		private bool \u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA;

		// Token: 0x04000248 RID: 584
		private int \u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF;

		// Token: 0x04000249 RID: 585
		private int \u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
	}

	// Token: 0x0200004F RID: 79
	[Flags]
	public enum GraphicsAPI
	{
		// Token: 0x0400024B RID: 587
		None = 0,
		// Token: 0x0400024C RID: 588
		DX11 = 2,
		// Token: 0x0400024D RID: 589
		DX12 = 4,
		// Token: 0x0400024E RID: 590
		Metal = 8,
		// Token: 0x0400024F RID: 591
		OpenGL = 16,
		// Token: 0x04000250 RID: 592
		Vulkan = 32
	}
}
