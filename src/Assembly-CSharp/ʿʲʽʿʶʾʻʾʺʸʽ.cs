﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020001A9 RID: 425
internal class \u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD
{
	// Token: 0x060012DD RID: 4829 RVA: 0x0009A318 File Offset: 0x00098518
	public static bool \u02BB\u02BF\u02B7\u02BA\u02BA\u02B9\u02B8\u02B5\u02B3\u02B7\u02B5(List<\u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0> \u02B6\u02BD\u02B8\u02B8\u02BF\u02BB\u02B3\u02B2\u02BF\u02BC\u02B5)
	{
		bool flag = false;
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)))
		{
			if (binaryReader.BaseStream.Length < 4L)
			{
				flag = true;
			}
			else if (\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BA\u02C0\u02BB\u02B9\u02B8\u02BD\u02B2\u02C0\u02B7\u02C0\u02BC(binaryReader.ReadInt32()))
			{
				flag = true;
			}
			else
			{
				int num = binaryReader.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					\u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0 u02BD_u02B5_u02B3_u02B2_u02BA_u02C0_u02C0_u02B7_u02B5_u02B8_u02C = new \u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0();
					u02BD_u02B5_u02B3_u02B2_u02BA_u02C0_u02C0_u02B7_u02B5_u02B8_u02C.\u02BD\u02BD\u02C1\u02BD\u02C0\u02B8\u02B4\u02BF\u02C0\u02B9\u02BB(binaryReader);
					\u02B6\u02BD\u02B8\u02B8\u02BF\u02BB\u02B3\u02B2\u02BF\u02BC\u02B5.Add(u02BD_u02B5_u02B3_u02B2_u02BA_u02C0_u02C0_u02B7_u02B5_u02B8_u02C);
				}
			}
		}
		if (flag)
		{
			\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BF\u02BA\u02BC\u02BE\u02B4\u02C1\u02BF\u02C0\u02B5\u02BC\u02B5();
			return false;
		}
		return true;
	}

	// Token: 0x060012DE RID: 4830 RVA: 0x0009A3B0 File Offset: 0x000985B0
	public static void \u02B2\u02BC\u02B2\u02BE\u02B7\u02BA\u02C1\u02B3\u02BA\u02BD\u02BC()
	{
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count == 0)
		{
			return;
		}
		List<\u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0> list = new List<\u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0>();
		if (GlobalVariables.\u02B4\u02B8\u02BB\u02B6\u02B8\u02B6\u02BA\u02BA\u02B3\u02B3\u02B6)
		{
			string text = Path.Combine(Application.persistentDataPath, "scoredata.bin");
			string text2 = Path.Combine(Application.persistentDataPath, "score.bin");
			if (!File.Exists(\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB))
			{
				if (File.Exists(text))
				{
					File.Copy(text, \u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB);
				}
				if (File.Exists(text2))
				{
					File.Copy(text2, \u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB);
				}
			}
		}
		if (!File.Exists(\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB) || !\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BB\u02BF\u02B7\u02BA\u02BA\u02B9\u02B8\u02B5\u02B3\u02B7\u02B5(list))
		{
			if (!File.Exists(\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02C0\u02B4\u02BB\u02BC\u02BC\u02C0\u02B4\u02BB\u02B4\u02B6\u02B7))
			{
				return;
			}
			\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02B5\u02BB\u02B2\u02B8\u02B2\u02B9\u02BD\u02C1\u02BF\u02BF\u02BE(list);
			\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02B7\u02B5\u02C1\u02B6\u02B5\u02B5\u02B8\u02BA\u02B3\u02B4\u02BE(list);
		}
		\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BC\u02B7\u02B4\u02B6\u02B6\u02BE\u02BF\u02BB\u02B3\u02C1\u02BC.Clear();
		using (List<\u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BB\u02BF\u02BC\u02B7\u02BB\u02BC\u02B6\u02B7\u02B7\u02BB\u02BA u02BB_u02BF_u02BC_u02B7_u02BB_u02BC_u02B6_u02B7_u02B7_u02BB_u02BA = new \u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BB\u02BF\u02BC\u02B7\u02BB\u02BC\u02B6\u02B7\u02B7\u02BB\u02BA();
				u02BB_u02BF_u02BC_u02B7_u02BB_u02BC_u02B6_u02B7_u02B7_u02BB_u02BA.scores = enumerator.Current;
				List<SongEntry> list2 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.FindAll(new Predicate<SongEntry>(u02BB_u02BF_u02BC_u02B7_u02BB_u02BC_u02B6_u02B7_u02B7_u02BB_u02BA.\u02BB\u02C0\u02BD\u02B6\u02BF\u02B2\u02BE\u02BA\u02B8\u02C1\u02BE));
				if (list2.Count == 0)
				{
					\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BC\u02B7\u02B4\u02B6\u02B6\u02BE\u02BF\u02BB\u02B3\u02C1\u02BC.Add(u02BB_u02BF_u02BC_u02B7_u02BB_u02BC_u02B6_u02B7_u02B7_u02BB_u02BA.scores);
				}
				else
				{
					foreach (SongEntry songEntry in list2)
					{
						songEntry.scores = u02BB_u02BF_u02BC_u02B7_u02BB_u02BC_u02B6_u02B7_u02B7_u02BB_u02BA.scores;
					}
				}
			}
		}
	}

	// Token: 0x060012DF RID: 4831 RVA: 0x0000FD03 File Offset: 0x0000DF03
	private static bool \u02BA\u02C0\u02BB\u02B9\u02B8\u02BD\u02B2\u02C0\u02B7\u02C0\u02BC(int \u02BC\u02B5\u02B7\u02BA\u02C0\u02BD\u02B4\u02B6\u02B2\u02C0\u02B4)
	{
		if (\u02BC\u02B5\u02B7\u02BA\u02C0\u02BD\u02B4\u02B6\u02B2\u02C0\u02B4 != 20211009)
		{
			Debug.LogError(string.Format("Unexpected score version number {0} expected: {1}", \u02BC\u02B5\u02B7\u02BA\u02C0\u02BD\u02B4\u02B6\u02B2\u02C0\u02B4, 20211009));
			return true;
		}
		return false;
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x0009A528 File Offset: 0x00098728
	private static void \u02BF\u02BA\u02BC\u02BE\u02B4\u02C1\u02BF\u02C0\u02B5\u02BC\u02B5()
	{
		string text = \u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02B6\u02B2\u02BB\u02B9\u02B9\u02B9\u02B9\u02BA\u02BF\u02B5\u02B8;
		Debug.LogError("Moving bad score file to " + text);
		File.Move(\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB, text);
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x0009A558 File Offset: 0x00098758
	public static void \u02B7\u02B5\u02C1\u02B6\u02B5\u02B5\u02B8\u02BA\u02B3\u02B4\u02BE(List<\u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0> \u02B6\u02BD\u02B8\u02B8\u02BF\u02BB\u02B3\u02B2\u02BF\u02BC\u02B5)
	{
		using (BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)))
		{
			binaryWriter.Write(20211009);
			binaryWriter.Write(\u02B6\u02BD\u02B8\u02B8\u02BF\u02BB\u02B3\u02B2\u02BF\u02BC\u02B5.Count);
			foreach (\u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0 u02BD_u02B5_u02B3_u02B2_u02BA_u02C0_u02C0_u02B7_u02B5_u02B8_u02C in \u02B6\u02BD\u02B8\u02B8\u02BF\u02BB\u02B3\u02B2\u02BF\u02BC\u02B5)
			{
				u02BD_u02B5_u02B3_u02B2_u02BA_u02C0_u02C0_u02B7_u02B5_u02B8_u02C.\u02BE\u02BF\u02B3\u02BD\u02B3\u02B4\u02B4\u02C1\u02BD\u02B8\u02BD(binaryWriter);
			}
		}
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x0009A5E4 File Offset: 0x000987E4
	public static void \u02B8\u02BE\u02B6\u02C1\u02B2\u02B2\u02B9\u02BC\u02BB\u02BA\u02B6()
	{
		try
		{
			foreach (SongEntry songEntry in \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4)
			{
				songEntry.scores.\u02B4\u02B7\u02BB\u02B3\u02B7\u02BF\u02BB\u02BF\u02B9\u02B2\u02B5 = false;
			}
			List<\u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0> list = new List<\u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0>();
			list.AddRange(\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BC\u02B7\u02B4\u02B6\u02B6\u02BE\u02BF\u02BB\u02B3\u02C1\u02BC);
			foreach (SongEntry songEntry2 in \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4)
			{
				if (!songEntry2.scores.\u02B4\u02B7\u02BB\u02B3\u02B7\u02BF\u02BB\u02BF\u02B9\u02B2\u02B5 && songEntry2.scores.\u02B4\u02C0\u02B2\u02BD\u02BF\u02B7\u02BC\u02BF\u02B8\u02BA\u02B5)
				{
					songEntry2.scores.\u02B4\u02B7\u02BB\u02B3\u02B7\u02BF\u02BB\u02BF\u02B9\u02B2\u02B5 = true;
					list.Add(songEntry2.scores);
				}
			}
			\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02B7\u02B5\u02C1\u02B6\u02B5\u02B5\u02B8\u02BA\u02B3\u02B4\u02BE(list);
		}
		catch (Exception ex)
		{
			Debug.Log("Problem reading score file: " + ex.Message);
		}
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x0009A6E4 File Offset: 0x000988E4
	public static void \u02B5\u02BB\u02B2\u02B8\u02B2\u02B9\u02BD\u02C1\u02BF\u02BF\u02BE(List<\u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0> \u02B6\u02BD\u02B8\u02B8\u02BF\u02BB\u02B3\u02B2\u02BF\u02BC\u02B5)
	{
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02C0\u02B4\u02BB\u02BC\u02BC\u02C0\u02B4\u02BB\u02B4\u02B6\u02B7)))
		{
			if (binaryReader.BaseStream.Length >= 4L)
			{
				if (binaryReader.ReadInt32() == 20180220)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i++)
					{
						\u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0 u02BD_u02B5_u02B3_u02B2_u02BA_u02C0_u02C0_u02B7_u02B5_u02B8_u02C = new \u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0();
						if (u02BD_u02B5_u02B3_u02B2_u02BA_u02C0_u02C0_u02B7_u02B5_u02B8_u02C.\u02C1\u02BD\u02BC\u02BF\u02B3\u02B4\u02B5\u02C0\u02B6\u02B2\u02BE(binaryReader) > 0)
						{
							\u02B6\u02BD\u02B8\u02B8\u02BF\u02BB\u02B3\u02B2\u02BF\u02BC\u02B5.Add(u02BD_u02B5_u02B3_u02B2_u02BA_u02C0_u02C0_u02B7_u02B5_u02B8_u02C);
						}
					}
				}
			}
		}
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x0000FD47 File Offset: 0x0000DF47
	public static void \u02B3\u02B6\u02BF\u02B3\u02BE\u02C1\u02B4\u02B8\u02B7\u02BE\u02B4()
	{
		\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB = Path.Combine(__FIXME_clon_util.\u02B3\u02B8\u02BF\u02B8\u02BF\u02BB\u02B7\u02B4\u02B7\u02BB\u02BD(), "scoredata.bin");
		\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02C0\u02B4\u02BB\u02BC\u02BC\u02C0\u02B4\u02BB\u02B4\u02B6\u02B7 = Path.Combine(__FIXME_clon_util.\u02B3\u02B8\u02BF\u02B8\u02BF\u02BB\u02B7\u02B4\u02B7\u02BB\u02BD(), "scores.bin");
		\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02B9\u02C0\u02B6\u02B6\u02B6\u02BE\u02BA\u02B7\u02B4\u02BB\u02B2 = Path.Combine(__FIXME_clon_util.\u02B3\u02B8\u02BF\u02B8\u02BF\u02BB\u02B7\u02B4\u02B7\u02BB\u02BD(), "scoredata_backup.bin");
	}

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x060012E6 RID: 4838 RVA: 0x0009A768 File Offset: 0x00098968
	public static string \u02B6\u02B2\u02BB\u02B9\u02B9\u02B9\u02B9\u02BA\u02BF\u02B5\u02B8
	{
		get
		{
			return Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), string.Format("scoredata_corrupted_{0}.bin", DateTime.Now.ToLocalTime().ToString("yyyyMMddHHmmss")));
		}
	}

	// Token: 0x04000E24 RID: 3620
	public static string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB;

	// Token: 0x04000E25 RID: 3621
	public static string \u02C0\u02B4\u02BB\u02BC\u02BC\u02C0\u02B4\u02BB\u02B4\u02B6\u02B7;

	// Token: 0x04000E26 RID: 3622
	public static string \u02B9\u02C0\u02B6\u02B6\u02B6\u02BE\u02BA\u02B7\u02B4\u02BB\u02B2;

	// Token: 0x04000E27 RID: 3623
	public static bool \u02B7\u02C0\u02B8\u02BC\u02B2\u02C1\u02B3\u02B8\u02B4\u02B7\u02BF = false;

	// Token: 0x04000E28 RID: 3624
	public static bool \u02B3\u02BB\u02BF\u02BD\u02B6\u02B8\u02C1\u02B6\u02B7\u02B3\u02B3 = false;

	// Token: 0x04000E29 RID: 3625
	public static List<\u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0> \u02BC\u02B7\u02B4\u02B6\u02B6\u02BE\u02BF\u02BB\u02B3\u02C1\u02BC = new List<\u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0>();

	// Token: 0x020001AA RID: 426
	[CompilerGenerated]
	private sealed class \u02BB\u02BF\u02BC\u02B7\u02BB\u02BC\u02B6\u02B7\u02B7\u02BB\u02BA
	{
		// Token: 0x060012E8 RID: 4840 RVA: 0x0000FD85 File Offset: 0x0000DF85
		internal bool \u02BB\u02C0\u02BD\u02B6\u02BF\u02B2\u02BE\u02BA\u02B8\u02C1\u02BE(SongEntry songEntry)
		{
			return songEntry.checksum == this.scores.\u02B7\u02C1\u02BF\u02B4\u02B8\u02B6\u02B3\u02B8\u02B2\u02BB\u02B2;
		}

		// Token: 0x04000E2A RID: 3626
		public \u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0 scores;
	}
}
