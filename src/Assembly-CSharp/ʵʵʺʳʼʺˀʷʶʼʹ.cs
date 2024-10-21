﻿using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

// Token: 0x020001AB RID: 427
public static class \u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9
{
	// Token: 0x060012E9 RID: 4841 RVA: 0x0009A7A4 File Offset: 0x000989A4
	public static bool \u02C1\u02BC\u02B7\u02B8\u02B9\u02B4\u02BC\u02B9\u02B5\u02B8\u02B7(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		if (\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BC\u02B5\u02BF\u02B9\u02C1\u02BF\u02B2\u02B8\u02B2\u02B5())
		{
			string[] files = Directory.GetFiles(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B2\u02C0\u02B9\u02C0\u02BA\u02C0\u02BA\u02BE\u02B6\u02B4\u02BD);
			string[] array = new string[files.Length];
			for (int i = 0; i < files.Length; i++)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			for (int j = 0; j < array.Length; j++)
			{
				if (Path.GetFileNameWithoutExtension(array[j]) == \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x0000FD9D File Offset: 0x0000DF9D
	public static void \u02B4\u02B4\u02C0\u02BD\u02BB\u02BB\u02C0\u02B5\u02B9\u02B5\u02B5(string \u02C1\u02B6\u02B8\u02BD\u02B9\u02C0\u02C0\u02B6\u02BE\u02BC\u02B2)
	{
		if (\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B5\u02BC\u02B8\u02B9\u02B3\u02B6\u02C1\u02BA\u02C0\u02B9\u02BA != null)
		{
			\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BE\u02B8\u02BA\u02C0\u02B5\u02C0\u02BE\u02BF\u02BC\u02BA(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B5\u02BC\u02B8\u02B9\u02B3\u02B6\u02C1\u02BA\u02C0\u02B9\u02BA);
		}
		if (\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B7\u02BA\u02B6\u02C1\u02BD\u02B2\u02B5\u02B7\u02B5\u02B2\u02B8)
		{
			\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B5\u02BC\u02B8\u02B9\u02B3\u02B6\u02C1\u02BA\u02C0\u02B9\u02BA = \u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7;
		}
		\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7 = \u02C1\u02B6\u02B8\u02BD\u02B9\u02C0\u02C0\u02B6\u02BE\u02BC\u02B2;
	}

	// Token: 0x060012EB RID: 4843 RVA: 0x0009A808 File Offset: 0x00098A08
	public static string[] \u02B3\u02B7\u02BE\u02B8\u02C1\u02BA\u02B5\u02B8\u02B2\u02B5\u02C0()
	{
		if (\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BC\u02B5\u02BF\u02B9\u02C1\u02BF\u02B2\u02B8\u02B2\u02B5())
		{
			string[] files = Directory.GetFiles(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B2\u02C0\u02B9\u02C0\u02BA\u02C0\u02BA\u02BE\u02B6\u02B4\u02BD, "*.setlist");
			string[] array = new string[files.Length];
			for (int i = 0; i < files.Length; i++)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			return array;
		}
		return null;
	}

	// Token: 0x060012EC RID: 4844 RVA: 0x0009A854 File Offset: 0x00098A54
	public static bool \u02BC\u02BE\u02B8\u02BA\u02C0\u02B5\u02C0\u02BE\u02BF\u02BC\u02BA(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		try
		{
			File.Delete(Path.Combine(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B2\u02C0\u02B9\u02C0\u02BA\u02C0\u02BA\u02BE\u02B6\u02B4\u02BD, \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6) + ".setlist");
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
			return false;
		}
		return true;
	}

	// Token: 0x060012ED RID: 4845 RVA: 0x0009A8A0 File Offset: 0x00098AA0
	private static bool \u02BC\u02BC\u02B5\u02BF\u02B9\u02C1\u02BF\u02B2\u02B8\u02B2\u02B5()
	{
		if (!Directory.Exists(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B2\u02C0\u02B9\u02C0\u02BA\u02C0\u02BA\u02BE\u02B6\u02B4\u02BD))
		{
			try
			{
				Directory.CreateDirectory(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B2\u02C0\u02B9\u02C0\u02BA\u02C0\u02BA\u02BE\u02B6\u02B4\u02BD);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				return false;
			}
			return true;
		}
		return true;
	}

	// Token: 0x060012EE RID: 4846 RVA: 0x0009A8E8 File Offset: 0x00098AE8
	public static bool \u02B3\u02B5\u02C0\u02B2\u02BB\u02BD\u02BE\u02BB\u02BA\u02B7\u02B7(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		if (\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 == null || \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6.Length == 0)
		{
			return false;
		}
		string text = Path.Combine(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B2\u02C0\u02B9\u02C0\u02BA\u02C0\u02BA\u02BE\u02B6\u02B4\u02BD, \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6) + ".setlist";
		\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B7\u02BA\u02B6\u02C1\u02BD\u02B2\u02B5\u02B7\u02B5\u02B2\u02B8 = true;
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text, FileMode.Create)))
			{
				binaryWriter.Write(20180202);
				binaryWriter.Write(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count);
				for (int i = 0; i < \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count; i++)
				{
					binaryWriter.Write(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD[i].checksumString);
					binaryWriter.Write((short)\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC[i]);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
			return false;
		}
		if (\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B5\u02BC\u02B8\u02B9\u02B3\u02B6\u02C1\u02BA\u02C0\u02B9\u02BA != null)
		{
			\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BE\u02B8\u02BA\u02C0\u02B5\u02C0\u02BE\u02BF\u02BC\u02BA(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B5\u02BC\u02B8\u02B9\u02B3\u02B6\u02C1\u02BA\u02C0\u02B9\u02BA);
			\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B5\u02BC\u02B8\u02B9\u02B3\u02B6\u02C1\u02BA\u02C0\u02B9\u02BA = null;
		}
		return true;
	}

	// Token: 0x060012EF RID: 4847 RVA: 0x0009A9D8 File Offset: 0x00098BD8
	public static bool \u02BA\u02B9\u02B8\u02B9\u02BD\u02B8\u02B4\u02B9\u02B8\u02BE\u02B7(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		if (\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 == null || \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6.Length == 0)
		{
			return false;
		}
		string text = Path.Combine(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B2\u02C0\u02B9\u02C0\u02BA\u02C0\u02BA\u02BE\u02B6\u02B4\u02BD, \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6) + ".setlist";
		bool flag = false;
		\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B7\u02BA\u02B6\u02C1\u02BD\u02B2\u02B5\u02B7\u02B5\u02B2\u02B8 = true;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC = new List<int>();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD = new List<SongEntry>();
		\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7 = \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;
		\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B5\u02BC\u02B8\u02B9\u02B3\u02B6\u02C1\u02BA\u02C0\u02B9\u02BA = null;
		try
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(text, FileMode.Open)))
			{
				if (binaryReader.ReadInt32() == 20180202)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i++)
					{
						string text2 = binaryReader.ReadString();
						int num2 = (int)binaryReader.ReadInt16();
						for (int j = 0; j < \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count; j++)
						{
							if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4[j].checksumString == text2)
							{
								\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Add(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4[j]);
								\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC.Add(num2);
								\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B5\u02B5\u02BF\u02B9\u02BD\u02B9\u02BC\u02B5\u02B6\u02B8\u02B3.Add("");
								break;
							}
						}
					}
				}
				else
				{
					flag = true;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogException(ex);
			return false;
		}
		if (flag)
		{
			File.Delete(text);
		}
		return \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count != 0 && !flag;
	}

	// Token: 0x04000E2B RID: 3627
	private static string \u02B2\u02C0\u02B9\u02C0\u02BA\u02C0\u02BA\u02BE\u02B6\u02B4\u02BD = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "Setlists");

	// Token: 0x04000E2C RID: 3628
	public static string \u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7;

	// Token: 0x04000E2D RID: 3629
	public static string \u02B5\u02BC\u02B8\u02B9\u02B3\u02B6\u02C1\u02BA\u02C0\u02B9\u02BA;

	// Token: 0x04000E2E RID: 3630
	public static bool \u02B7\u02BA\u02B6\u02C1\u02BD\u02B2\u02B5\u02B7\u02B5\u02B2\u02B8;
}
