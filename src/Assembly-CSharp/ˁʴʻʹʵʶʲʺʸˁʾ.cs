﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public static class \u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE
{
	public static void \u02BA\u02C0\u02B2\u02C1\u02BD\u02B7\u02BC\u02BF\u02BB\u02B2\u02B7(List<string> \u02B4\u02BB\u02B4\u02BA\u02BA\u02B7\u02BD\u02BC\u02BC\u02BD\u02B4, string[] \u02C1\u02BC\u02BE\u02BC\u02B5\u02BD\u02C0\u02BC\u02BC\u02B9\u02BA)
	{
		\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C1\u02BC\u02BE\u02BC\u02B5\u02BD\u02C0\u02BC\u02BC\u02B9\u02BA = \u02C1\u02BC\u02BE\u02BC\u02B5\u02BD\u02C0\u02BC\u02BC\u02B9\u02BA;
		\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02B4\u02BB\u02B4\u02BA\u02BA\u02B7\u02BD\u02BC\u02BC\u02BD\u02B4 = \u02B4\u02BB\u02B4\u02BA\u02BA\u02B7\u02BD\u02BC\u02BC\u02BD\u02B4;
	}

	public static void \u02BA\u02BE\u02BC\u02C1\u02BB\u02B2\u02B7\u02BC\u02BD\u02BF\u02C0()
	{
		for (int i = 0; i < \u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02B4\u02BB\u02B4\u02BA\u02BA\u02B7\u02BD\u02BC\u02BC\u02BD\u02B4.Count; i++)
		{
			string text = \u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02B4\u02BB\u02B4\u02BA\u02BA\u02B7\u02BD\u02BC\u02BC\u02BD\u02B4[i];
			foreach (string text2 in \u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C1\u02BC\u02BE\u02BC\u02B5\u02BD\u02C0\u02BC\u02BC\u02B9\u02BA)
			{
				string text3 = Path.Combine(text, text2);
				if (File.Exists(text3) && !\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02B6\u02BB\u02C1\u02BD\u02B3\u02BB\u02B9\u02C0\u02B6\u02B7\u02C1(text3) && i + 100 < \u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02B4\u02BB\u02B4\u02BA\u02BA\u02B7\u02BD\u02BC\u02BC\u02BD\u02B4.Count)
				{
					i += 100;
					break;
				}
			}
		}
	}

	public static void \u02BC\u02B5\u02B9\u02BA\u02B4\u02B4\u02B2\u02BF\u02B3\u02B4\u02B5()
	{
		\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C0\u02B4\u02B3\u02C0\u02BC\u02C0\u02B9\u02C1\u02B2\u02BF\u02B8 = true;
		while (\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C0\u02B4\u02B3\u02C0\u02BC\u02C0\u02B9\u02C1\u02B2\u02BF\u02B8)
		{
			while (!\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02BD\u02C0\u02B7\u02B2\u02B6\u02B5\u02B7\u02B8\u02C1\u02B5\u02BC.IsEmpty)
			{
				\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C1\u02BF\u02BB\u02B3\u02B6\u02BC\u02C0\u02B7\u02BF\u02B6\u02B6();
			}
			Thread.Sleep(10);
		}
	}

	public static bool \u02B6\u02BB\u02C1\u02BD\u02B3\u02BB\u02B9\u02C0\u02B6\u02B7\u02C1(string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)
	{
		if (!\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02B4\u02BC\u02B5\u02B5\u02C1\u02C0\u02BD\u02B4\u02C0\u02BC\u02BA.ContainsKey(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB))
		{
			byte[] array = File.ReadAllBytes(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB);
			return \u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02B4\u02BC\u02B5\u02B5\u02C1\u02C0\u02BD\u02B4\u02C0\u02BC\u02BA.TryAdd(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB, array);
		}
		return false;
	}

	public static void \u02C1\u02BF\u02BB\u02B3\u02B6\u02BC\u02C0\u02B7\u02BF\u02B6\u02B6()
	{
		while (!\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02BD\u02C0\u02B7\u02B2\u02B6\u02B5\u02B7\u02B8\u02C1\u02B5\u02BC.IsEmpty)
		{
			string text;
			\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02BD\u02C0\u02B7\u02B2\u02B6\u02B5\u02B7\u02B8\u02C1\u02B5\u02BC.TryDequeue(out text);
			\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02BC\u02BE\u02BA\u02BB\u02B4\u02BB\u02BE\u02BA\u02B3\u02BD\u02C0(text);
		}
	}

	public static void \u02C1\u02BB\u02B3\u02BA\u02BB\u02C0\u02B4\u02BB\u02BB\u02B4\u02B6(string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)
	{
		\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02BD\u02C0\u02B7\u02B2\u02B6\u02B5\u02B7\u02B8\u02C1\u02B5\u02BC.Enqueue(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB);
	}

	public static void \u02BC\u02BE\u02BA\u02BB\u02B4\u02BB\u02BE\u02BA\u02B3\u02BD\u02C0(string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)
	{
		byte[] array;
		\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02B4\u02BC\u02B5\u02B5\u02C1\u02C0\u02BD\u02B4\u02C0\u02BC\u02BA.TryRemove(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB, out array);
	}

	public static byte[] \u02C1\u02B9\u02B7\u02BC\u02B4\u02BF\u02B6\u02B4\u02B9\u02BD\u02BD(string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)
	{
		if (!\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02B4\u02BC\u02B5\u02B5\u02C1\u02C0\u02BD\u02B4\u02C0\u02BC\u02BA.ContainsKey(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB))
		{
			byte[] array = File.ReadAllBytes(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB);
			\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02B4\u02BC\u02B5\u02B5\u02C1\u02C0\u02BD\u02B4\u02C0\u02BC\u02BA.TryAdd(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB, array);
			return array;
		}
		byte[] array2;
		\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02B4\u02BC\u02B5\u02B5\u02C1\u02C0\u02BD\u02B4\u02C0\u02BC\u02BA.TryGetValue(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB, out array2);
		return array2;
	}

	private static ConcurrentDictionary<string, byte[]> \u02B4\u02BC\u02B5\u02B5\u02C1\u02C0\u02BD\u02B4\u02C0\u02BC\u02BA = new ConcurrentDictionary<string, byte[]>();

	private static ConcurrentQueue<string> \u02BD\u02C0\u02B7\u02B2\u02B6\u02B5\u02B7\u02B8\u02C1\u02B5\u02BC = new ConcurrentQueue<string>();

	private static List<string> \u02B4\u02BB\u02B4\u02BA\u02BA\u02B7\u02BD\u02BC\u02BC\u02BD\u02B4;

	private static string[] \u02C1\u02BC\u02BE\u02BC\u02B5\u02BD\u02C0\u02BC\u02BC\u02B9\u02BA;

	public static bool \u02C0\u02B4\u02B3\u02C0\u02BC\u02C0\u02B9\u02C1\u02B2\u02BF\u02B8 = false;
}
