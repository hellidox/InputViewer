﻿using System;
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

public static class __FIXME_clon_util
{
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

	public static float \u02B4\u02BD\u02B2\u02B2\u02B5\u02B4\u02BB\u02B8\u02B6\u02BE\u02BB(float \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5, int \u02BE\u02BF\u02B5\u02B3\u02B5\u02BD\u02B4\u02B8\u02C1\u02B9\u02B6)
	{
		float num = (float)Math.Pow(10.0, (double)\u02BE\u02BF\u02B5\u02B3\u02B5\u02BD\u02B4\u02B8\u02C1\u02B9\u02B6);
		return (float)((long)(\u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5 * num)) / num;
	}

	public static __FIXME_clon_util.\u02C0\u02BF\u02B7\u02BA\u02B6\u02BA\u02B2\u02B4\u02B5\u02B8\u02B9 \u02C1\u02BF\u02B8\u02B2\u02BA\u02B3\u02B4\u02B3\u02C1\u02BC\u02BE(uint \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8)
	{
		return new __FIXME_clon_util.\u02C0\u02BF\u02B7\u02BA\u02B6\u02BA\u02B2\u02B4\u02B5\u02B8\u02B9(\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8);
	}

	public static __FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA \u02B8\u02C0\u02BA\u02BB\u02B6\u02BA\u02BA\u02C0\u02B4\u02C1\u02B9(ushort \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8)
	{
		return new __FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA(\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8);
	}

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

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint \u02B4\u02BD\u02B8\u02BF\u02BC\u02B8\u02C1\u02B7\u02BF\u02B9\u02B8(uint \u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF)
	{
		return \u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF & ~(\u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF - 1U);
	}

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

	public static string \u02BD\u02C1\u02C0\u02BA\u02B6\u02B4\u02BF\u02B9\u02B3\u02BD\u02C0()
	{
		return Path.Combine(Path.Combine(Application.dataPath, "Plugins"), "x86_64");
	}

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

	public static void \u02BA\u02BB\u02B7\u02B4\u02B2\u02BC\u02B4\u02B2\u02B9\u02B3\u02BD(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		string text = "explorer.exe";
		if (text != null)
		{
			Process.Start(text, "\"" + \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC + "\"");
		}
	}

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

	public static void \u02B3\u02BC\u02B9\u02BD\u02BB\u02B6\u02B5\u02B9\u02BC\u02BD\u02BE(string \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5)
	{
		Process.Start(Path.Combine(Directory.GetParent(Application.dataPath).FullName, Process.GetCurrentProcess().ProcessName + ".exe"), \u02B9\u02BE\u02BF\u02B9\u02BF\u02BA\u02B9\u02BD\u02B7\u02BB\u02B5);
		Application.Quit();
	}

	public static string GetDocumentsClonFolder()
	{
		if (GlobalVariables.\u02B4\u02B8\u02BB\u02B6\u02B8\u02B6\u02BA\u02BA\u02B3\u02B3\u02B6)
		{
			return Path.Combine(Directory.GetParent(Application.dataPath).FullName, "PlayerData");
		}
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Clone Hero");
	}

	public static string \u02B3\u02B8\u02BF\u02B8\u02BF\u02BB\u02B7\u02B4\u02B7\u02BB\u02BD()
	{
		if (GlobalVariables.\u02B4\u02B8\u02BB\u02B6\u02B8\u02B6\u02BA\u02BA\u02B3\u02B3\u02B6)
		{
			return Path.Combine(Directory.GetParent(Application.dataPath).FullName, "GameData");
		}
		return Application.persistentDataPath;
	}

	public static float \u02B5\u02B9\u02C1\u02BB\u02B6\u02B3\u02BA\u02BE\u02B9\u02B5\u02BF(double \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5, double \u02B9\u02BD\u02C1\u02C0\u02BA\u02C0\u02C0\u02B6\u02B5\u02B6\u02C1, float \u02BB\u02BE\u02B6\u02B5\u02BD\u02BF\u02C1\u02B9\u02B4\u02B3\u02B9, float \u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4)
	{
		double num = \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 - \u02B9\u02BD\u02C1\u02C0\u02BA\u02C0\u02C0\u02B6\u02B5\u02B6\u02C1;
		return (float)((double)\u02BB\u02BE\u02B6\u02B5\u02BD\u02BF\u02C1\u02B9\u02B4\u02B3\u02B9 + num * (double)\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4);
	}

	public static float \u02C1\u02BA\u02B7\u02C1\u02BB\u02B9\u02B9\u02BB\u02BC\u02B9\u02B8(float \u02BC\u02B6\u02B7\u02B5\u02C0\u02B8\u02BF\u02B8\u02B9\u02BA\u02BB, double \u02B9\u02BD\u02C1\u02C0\u02BA\u02C0\u02C0\u02B6\u02B5\u02B6\u02C1, float \u02BB\u02BE\u02B6\u02B5\u02BD\u02BF\u02C1\u02B9\u02B4\u02B3\u02B9, float \u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4)
	{
		return (float)(\u02B9\u02BD\u02C1\u02C0\u02BA\u02C0\u02C0\u02B6\u02B5\u02B6\u02C1 + (double)((\u02BC\u02B6\u02B7\u02B5\u02C0\u02B8\u02BF\u02B8\u02B9\u02BA\u02BB - \u02BB\u02BE\u02B6\u02B5\u02BD\u02BF\u02C1\u02B9\u02B4\u02B3\u02B9) / \u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4));
	}

	public static IEnumerable<uint> \u02B4\u02BC\u02BF\u02B8\u02BD\u02C1\u02B4\u02B4\u02B2\u02C0\u02B4(string \u02BF\u02B3\u02BC\u02C1\u02C1\u02BC\u02B6\u02B5\u02B8\u02C1\u02BA)
	{
		TextElementEnumerator tee = StringInfo.GetTextElementEnumerator(\u02BF\u02B3\u02BC\u02C1\u02C1\u02BC\u02B6\u02B5\u02B8\u02C1\u02BA);
		while (tee.MoveNext())
		{
			yield return (uint)char.ConvertToUtf32(\u02BF\u02B3\u02BC\u02C1\u02C1\u02BC\u02B6\u02B5\u02B8\u02C1\u02BA, tee.ElementIndex);
		}
		yield break;
	}

	public static string \u02B4\u02B3\u02B9\u02B6\u02BC\u02B7\u02BC\u02BA\u02B3\u02BB\u02B6(uint[] \u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4)
	{
		string[] array = new string[\u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4.Length];
		for (int i = 0; i < \u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4.Length; i++)
		{
			array[i] = char.ConvertFromUtf32((int)\u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4[i]);
		}
		return string.Concat(array);
	}

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

	public static bool \u02B4\u02B4\u02C0\u02C1\u02BF\u02B5\u02B4\u02BD\u02B2\u02B2\u02BE()
	{
		string text = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString().ToLowerInvariant());
		File.CreateText(text).Close();
		bool flag = File.Exists(text.ToUpperInvariant());
		File.Delete(text);
		return !flag;
	}

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

	public static string \u02B4\u02B6\u02BE\u02B5\u02BB\u02BA\u02BB\u02C0\u02C1\u02C1\u02B7()
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			return Path.Combine(Application.persistentDataPath, "streamingAssets");
		}
		return Application.streamingAssetsPath;
	}

	public static string \u02BF\u02B8\u02BD\u02BA\u02BC\u02B4\u02BE\u02B6\u02BE\u02C1\u02B2(bool \u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA)
	{
		return \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(\u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA ? "Enabled" : "Disabled");
	}

	internal static string \u02BB\u02B6\u02B4\u02BC\u02B5\u02B9\u02BA\u02BD\u02B7\u02B4\u02B3()
	{
		return string.Format("{0}/cached-thumbs", Application.persistentDataPath);
	}

	public static Color HexColorToColor(HexColor \u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2, float \u02B6\u02B8\u02BD\u02BF\u02BE\u02B8\u02B9\u02BB\u02C1\u02C1\u02C0 = 1f)
	{
		return new Color((float)\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2.Red / 255f, (float)\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2.Green / 255f, (float)\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2.Blue / 255f, \u02B6\u02B8\u02BD\u02BF\u02BE\u02B8\u02B9\u02BB\u02C1\u02C1\u02C0);
	}

	public static void \u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(this TMP_Text \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF, Utf16ValueStringBuilder \u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA)
	{
		ArraySegment<char> arraySegment = \u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.AsArraySegment();
		\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.SetCharArray(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
	}

	[ThreadStatic]
	private static List<string> \u02BB\u02B6\u02C1\u02B3\u02B5\u02BA\u02BE\u02B2\u02B7\u02B6\u02BD = new List<string>();

	private static char[] \u02C1\u02C0\u02B8\u02C1\u02C0\u02BC\u02B3\u02B5\u02B7\u02B4\u02BD = Path.GetInvalidFileNameChars();

	public struct \u02C0\u02BF\u02B7\u02BA\u02B6\u02BA\u02B2\u02B4\u02B5\u02B8\u02B9
	{
		public bool \u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC()
		{
			this.\u02BE\u02BC\u02C0\u02C0\u02BE\u02BB\u02BE\u02B3\u02B7\u02BB\u02B3 = this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8;
			this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 &= this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 - 1U;
			return this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 != 0U || this.\u02BE\u02BC\u02C0\u02C0\u02BE\u02BB\u02BE\u02B3\u02B7\u02BB\u02B3 != 0U;
		}

		public uint \u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF
		{
			get
			{
				return this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 ^ this.\u02BE\u02BC\u02C0\u02C0\u02BE\u02BB\u02BE\u02B3\u02B7\u02BB\u02B3;
			}
		}

		public \u02C0\u02BF\u02B7\u02BA\u02B6\u02BA\u02B2\u02B4\u02B5\u02B8\u02B9(uint \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8)
		{
			this.\u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8 = \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8;
			this.\u02BE\u02BC\u02C0\u02C0\u02BE\u02BB\u02BE\u02B3\u02B7\u02BB\u02B3 = \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8;
		}

		public __FIXME_clon_util.\u02C0\u02BF\u02B7\u02BA\u02B6\u02BA\u02B2\u02B4\u02B5\u02B8\u02B9 \u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1()
		{
			return this;
		}

		private uint \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8;

		private uint \u02BE\u02BC\u02C0\u02C0\u02BE\u02BB\u02BE\u02B3\u02B7\u02BB\u02B3;
	}

	public struct \u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA
	{
		public int \u02B6\u02B8\u02BE\u02B6\u02BA\u02B2\u02B7\u02B5\u02B8\u02BA\u02B5()
		{
			return this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
		}

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

		public int \u02BA\u02B7\u02BD\u02BD\u02B6\u02C0\u02BE\u02B2\u02B8\u02BF\u02BF()
		{
			return this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
		}

		public int \u02B3\u02BF\u02BD\u02B5\u02B7\u02BB\u02BB\u02BF\u02B3\u02B4\u02B8()
		{
			return this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
		}

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

		public __FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA \u02B3\u02B7\u02B6\u02B5\u02C1\u02C1\u02BB\u02B3\u02B3\u02BA\u02B5()
		{
			return this;
		}

		public __FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA \u02BE\u02C0\u02BA\u02B2\u02BD\u02C1\u02B5\u02B8\u02BC\u02B9\u02BB()
		{
			return this;
		}

		public int \u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF
		{
			get
			{
				return this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
			}
		}

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

		public int \u02B7\u02B8\u02BD\u02BA\u02BB\u02B7\u02BF\u02B8\u02B3\u02BF\u02BF()
		{
			return this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
		}

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

		public __FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA \u02B3\u02BF\u02B6\u02B4\u02B4\u02BC\u02C0\u02C0\u02B5\u02B2\u02C0()
		{
			return this;
		}

		public __FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA \u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1()
		{
			return this;
		}

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

		public int \u02BE\u02B8\u02B2\u02B9\u02BB\u02B3\u02B2\u02BC\u02B9\u02B8\u02B2()
		{
			return this.\u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
		}

		private ushort \u02B6\u02B2\u02BF\u02BC\u02C1\u02BA\u02B9\u02B2\u02BD\u02BE\u02B8;

		private ushort \u02BA\u02B6\u02C1\u02B3\u02B7\u02B8\u02B2\u02C1\u02B4\u02C1\u02B6;

		private uint \u02B7\u02B9\u02B4\u02BE\u02BE\u02B5\u02BC\u02B8\u02B9\u02BC\u02BC;

		private uint \u02BB\u02BF\u02BD\u02B7\u02B5\u02BE\u02C1\u02B5\u02B2\u02BE\u02BC;

		private bool \u02B5\u02B9\u02B9\u02B4\u02B7\u02BD\u02B8\u02C0\u02B2\u02B5\u02BA;

		private int \u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF;

		private int \u02B6\u02BD\u02B3\u02BA\u02B7\u02B6\u02C1\u02B8\u02BB\u02B5\u02B2;
	}

	[Flags]
	public enum GraphicsAPI
	{
		None = 0,
		DX11 = 2,
		DX12 = 4,
		Metal = 8,
		OpenGL = 16,
		Vulkan = 32
	}
}
