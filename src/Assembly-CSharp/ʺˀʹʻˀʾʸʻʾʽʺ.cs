using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using StrikeCore;
using UnityEngine;

// Token: 0x020001A0 RID: 416
public class \u02BA\u02C0\u02B9\u02BB\u02C0\u02BE\u02B8\u02BB\u02BE\u02BD\u02BA
{
	// Token: 0x06001299 RID: 4761 RVA: 0x0000FA9F File Offset: 0x0000DC9F
	private bool \u02BC\u02BE\u02BF\u02B2\u02BE\u02BD\u02B7\u02B6\u02C0\u02B7\u02B9(SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA)
	{
		if (!File.Exists(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.chartPath))
		{
			return false;
		}
		\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.\u02C1\u02B3\u02BD\u02B4\u02BC\u02B4\u02BD\u02B9\u02B4\u02B2\u02BC(\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C1\u02B9\u02B7\u02BC\u02B4\u02BF\u02B6\u02B4\u02B9\u02BD\u02BD(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.chartPath));
		\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.\u02BF\u02B8\u02B4\u02BB\u02B8\u02C1\u02BE\u02C1\u02BB\u02BB\u02B8();
		SongHash checksum = \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.checksum;
		return !this.\u02B3\u02B2\u02BA\u02B8\u02B6\u02B3\u02BF\u02C1\u02B5\u02BD\u02C1(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA);
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x00098374 File Offset: 0x00096574
	public int \u02C1\u02BE\u02BB\u02BB\u02BF\u02B7\u02C0\u02B8\u02BB\u02BB\u02BE()
	{
		return 0 + this.\u02BC\u02B5\u02B4\u02B8\u02B7\u02B5\u02BB\u02B2\u02B6\u02B8\u02B9.Count + this.\u02B2\u02B5\u02BA\u02B9\u02B4\u02B2\u02B9\u02B3\u02B7\u02B2\u02BC.Count + this.\u02BA\u02BA\u02B6\u02B4\u02B6\u02B8\u02B2\u02B5\u02B2\u02BD\u02BF.Count + this.\u02B8\u02B2\u02B8\u02C0\u02BA\u02B7\u02C0\u02B5\u02B2\u02B5\u02BD.Count + this.\u02C1\u02B4\u02C0\u02B2\u02B7\u02BA\u02BB\u02B2\u02B7\u02C0\u02BF.Count + this.\u02B5\u02B5\u02C0\u02BE\u02B7\u02B6\u02B2\u02B9\u02BC\u02B4\u02B5.Count + this.\u02B5\u02BB\u02B3\u02B3\u02BB\u02BE\u02B9\u02B6\u02C0\u02B3\u02BD.Count;
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x000983D8 File Offset: 0x000965D8
	private bool \u02B3\u02B9\u02BA\u02B6\u02B2\u02BE\u02BE\u02B3\u02BD\u02B9\u02BC(SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA)
	{
		if (\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.songLength > 0)
		{
			return true;
		}
		int songLength = \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.songLength;
		BassAudioManager.Instance.\u02BE\u02B3\u02B8\u02B4\u02BB\u02B3\u02BE\u02B4\u02BA\u02C0\u02BA(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA, false, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Crowd, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.None);
		\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.songLength = (int)Math.Ceiling(BassAudioManager.Instance.\u02B2\u02BF\u02B2\u02B9\u02B4\u02BC\u02BB\u02B4\u02B2\u02C1\u02BD * 1000.0);
		BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
		if (\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.songLength > 0)
		{
			this.\u02B2\u02B4\u02BC\u02BC\u02B2\u02BE\u02BE\u02BE\u02BF\u02B3\u02B3 = songLength != \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.songLength;
			return true;
		}
		return false;
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x00098450 File Offset: 0x00096650
	private void \u02B9\u02BA\u02C0\u02B8\u02BA\u02B6\u02B3\u02BA\u02B3\u02B6\u02B5()
	{
		byte[] array = new byte[\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count * 16];
		for (int i = 0; i < \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count; i++)
		{
			\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4[i].checksum.CopyTo(array, i * 16);
		}
		\u02C0\u02BC\u02B6\u02BB\u02BA\u02BD\u02B5\u02BE\u02BD\u02B7\u02B9.\u02B7\u02BA\u02BB\u02B7\u02BB\u02B9\u02B4\u02B7\u02B5\u02BE\u02B4.ComputeHash(array);
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x000984AC File Offset: 0x000966AC
	private void \u02B5\u02BE\u02C1\u02B3\u02BB\u02BA\u02BE\u02B6\u02B8\u02B9\u02B5(bool \u02B9\u02BD\u02B6\u02C0\u02B2\u02C0\u02B2\u02C1\u02BB\u02C0\u02B9)
	{
		if (!File.Exists(this.\u02BA\u02C1\u02BA\u02B3\u02B9\u02B6\u02BA\u02B6\u02BF\u02B3\u02BE))
		{
			return;
		}
		this.\u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA = \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.ReadingCache;
		this.\u02B8\u02B6\u02BB\u02BD\u02B9\u02B8\u02B8\u02BE\u02B4\u02BB\u02B4 = new List<SongEntry>();
		this.\u02BB\u02BE\u02BE\u02B2\u02BB\u02B9\u02B5\u02B2\u02BE\u02BF\u02B6 = new List<SongEntry>();
		try
		{
			using (Stream stream = File.OpenRead(this.\u02BA\u02C1\u02BA\u02B3\u02B9\u02B6\u02BA\u02B6\u02BF\u02B3\u02BE))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt32() != 20221120)
					{
						throw new Exception("Cache version is wrong!");
					}
					\u02C0\u02BC\u02B6\u02BB\u02BA\u02BD\u02B5\u02BE\u02BD\u02B7\u02B9.\u02B7\u02BA\u02BB\u02B7\u02BB\u02B9\u02B4\u02B7\u02B5\u02BE\u02B4.SetData(binaryReader.ReadBytes(16));
					\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B9\u02B5\u02BF\u02B3\u02B6\u02BE\u02C1\u02B6\u02B8\u02B7\u02B5(binaryReader);
					int num = binaryReader.ReadInt32();
					int i = 0;
					while (i < num)
					{
						string text = binaryReader.ReadString();
						text = (this.\u02B2\u02B7\u02B7\u02BD\u02BA\u02B6\u02BC\u02BC\u02BA\u02B7\u02B2 ? text : text.ToLowerInvariant());
						long num2 = binaryReader.ReadInt64();
						long num3 = binaryReader.ReadInt64();
						SongEntry songEntry = new SongEntry(binaryReader, text);
						if (!\u02B9\u02BD\u02B6\u02C0\u02B2\u02C0\u02B2\u02C1\u02BB\u02C0\u02B9)
						{
							goto IL_0234;
						}
						bool flag = false;
						bool flag2 = false;
						if (songEntry.isEnc)
						{
							if (!File.Exists(songEntry.folderPath))
							{
								goto IL_029F;
							}
							flag = (flag2 = new FileInfo(songEntry.folderPath).LastWriteTime.ToBinary() != num2);
						}
						else
						{
							DirectoryInfo directoryInfo = new DirectoryInfo(songEntry.folderPath);
							if (!directoryInfo.Exists)
							{
								goto IL_029F;
							}
							FileInfo fileInfo = new FileInfo(songEntry.iniPath);
							FileInfo fileInfo2 = new FileInfo(songEntry.chartPath);
							if (!fileInfo.Exists || !fileInfo2.Exists)
							{
								goto IL_029F;
							}
							flag = fileInfo.LastWriteTime.ToBinary() != num2;
							flag2 = fileInfo2.LastWriteTime.ToBinary() != num3;
							bool flag3 = false;
							foreach (FileInfo fileInfo3 in directoryInfo.EnumerateFiles())
							{
								if (Path.GetFileNameWithoutExtension(fileInfo3.Name).Equals("video", StringComparison.OrdinalIgnoreCase) && this.\u02B7\u02BA\u02BC\u02B6\u02BC\u02B2\u02B7\u02BA\u02B4\u02BF\u02BA.Contains(fileInfo3.Extension, StringComparer.OrdinalIgnoreCase))
								{
									flag3 = true;
								}
							}
							if (flag3 != songEntry.videoBackground)
							{
								songEntry.videoBackground = flag3;
								this.\u02BB\u02BE\u02BE\u02B2\u02BB\u02B9\u02B5\u02B2\u02BE\u02BF\u02B6.Add(songEntry);
							}
						}
						if (flag)
						{
							this.\u02BB\u02BE\u02BE\u02B2\u02BB\u02B9\u02B5\u02B2\u02BE\u02BF\u02B6.Add(songEntry);
							this.\u02B8\u02B6\u02BB\u02BD\u02B9\u02B8\u02B8\u02BE\u02B4\u02BB\u02B4.Add(songEntry);
						}
						if (flag2)
						{
							this.\u02B8\u02B6\u02BB\u02BD\u02B9\u02B8\u02B8\u02BE\u02B4\u02BB\u02B4.Add(songEntry);
							goto IL_0234;
						}
						goto IL_0234;
						IL_029F:
						i++;
						continue;
						IL_0234:
						bool flag4 = false;
						if (\u02B9\u02BD\u02B6\u02C0\u02B2\u02C0\u02B2\u02C1\u02BB\u02C0\u02B9)
						{
							using (List<string>.Enumerator enumerator2 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									string text2 = enumerator2.Current;
									if (text.Contains(text2))
									{
										flag4 = true;
										break;
									}
								}
								goto IL_0282;
							}
							goto IL_027F;
						}
						goto IL_027F;
						IL_0282:
						if (flag4)
						{
							\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Add(songEntry);
						}
						if (this.\u02BC\u02BC\u02B2\u02B6\u02B2\u02BE\u02B3\u02B9\u02B4\u02B4\u02C1.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
						{
							goto IL_029F;
						}
						break;
						IL_027F:
						flag4 = true;
						goto IL_0282;
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.\u02BD\u02B3\u02BE\u02B4\u02B7\u02C1\u02B5\u02BC\u02BE\u02B5\u02B8 = ex;
			Debug.LogError(ex);
			\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Clear();
		}
	}

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x0600129E RID: 4766 RVA: 0x00098374 File Offset: 0x00096574
	public int \u02BC\u02B6\u02B4\u02C0\u02B7\u02B2\u02BA\u02BD\u02BF\u02C0\u02B4
	{
		get
		{
			return 0 + this.\u02BC\u02B5\u02B4\u02B8\u02B7\u02B5\u02BB\u02B2\u02B6\u02B8\u02B9.Count + this.\u02B2\u02B5\u02BA\u02B9\u02B4\u02B2\u02B9\u02B3\u02B7\u02B2\u02BC.Count + this.\u02BA\u02BA\u02B6\u02B4\u02B6\u02B8\u02B2\u02B5\u02B2\u02BD\u02BF.Count + this.\u02B8\u02B2\u02B8\u02C0\u02BA\u02B7\u02C0\u02B5\u02B2\u02B5\u02BD.Count + this.\u02C1\u02B4\u02C0\u02B2\u02B7\u02BA\u02BB\u02B2\u02B7\u02C0\u02BF.Count + this.\u02B5\u02B5\u02C0\u02BE\u02B7\u02B6\u02B2\u02B9\u02BC\u02B4\u02B5.Count + this.\u02B5\u02BB\u02B3\u02B3\u02BB\u02BE\u02B9\u02B6\u02C0\u02B3\u02BD.Count;
		}
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x00098824 File Offset: 0x00096A24
	private void \u02BE\u02B2\u02B4\u02B4\u02BF\u02B3\u02C0\u02BE\u02B3\u02B2\u02BC()
	{
		if (!this.\u02BC\u02BC\u02B2\u02B6\u02B2\u02BE\u02B3\u02B9\u02B4\u02B4\u02C1.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
		{
			return;
		}
		if (this.\u02BC\u02B6\u02B4\u02C0\u02B7\u02B2\u02BA\u02BD\u02BF\u02C0\u02B4 == 0)
		{
			try
			{
				if (File.Exists(this.\u02B7\u02B5\u02BD\u02B3\u02C0\u02B5\u02BA\u02B3\u02B7\u02BA\u02BC))
				{
					File.Delete(this.\u02B7\u02B5\u02BD\u02B3\u02C0\u02B5\u02BA\u02B3\u02B7\u02BA\u02BC);
				}
			}
			catch
			{
			}
			return;
		}
		this.\u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA = \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.WritingBadSongs;
		try
		{
			using (Stream stream = File.Create(this.\u02B7\u02B5\u02BD\u02B3\u02C0\u02B5\u02BA\u02B3\u02B7\u02BA\u02BC))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					if (this.\u02BE\u02BD\u02B5\u02BF\u02BA\u02B4\u02B7\u02BE\u02B9\u02BB\u02C1.Count > 0)
					{
						streamWriter.WriteLine("Warning: These folders contain lyrics that are not valid UTF-8, and may display missing or incorrect characters in-game.");
						foreach (string text in this.\u02BE\u02BD\u02B5\u02BF\u02BA\u02B4\u02B7\u02BE\u02B9\u02BB\u02C1)
						{
							streamWriter.WriteLine(text);
						}
						streamWriter.WriteLine();
					}
					if (this.\u02BF\u02BD\u02C0\u02B2\u02B9\u02B6\u02B9\u02B6\u02B4\u02B7\u02BE.Count > 0)
					{
						streamWriter.WriteLine("Warning: These folders contain notes after the end event. End events will be disabled for these folders.");
						foreach (string text2 in this.\u02BF\u02BD\u02C0\u02B2\u02B9\u02B6\u02B9\u02B6\u02B4\u02B7\u02BE)
						{
							streamWriter.WriteLine(text2);
						}
						streamWriter.WriteLine();
					}
					if (this.\u02B2\u02B2\u02BF\u02C0\u02BE\u02BB\u02BB\u02BA\u02BE\u02B6\u02C1.Count > 0)
					{
						streamWriter.WriteLine("Warning: These folders contain lyrics that do not have matching vocal note events, and have fallen back to non validated parsing.");
						streamWriter.WriteLine("This warning has no effect on charts currently, but they will not work properly in the future when/if vocals support is pursued.");
						foreach (string text3 in this.\u02B2\u02B2\u02BF\u02C0\u02BE\u02BB\u02BB\u02BA\u02BE\u02B6\u02C1)
						{
							streamWriter.WriteLine(text3);
						}
						streamWriter.WriteLine();
					}
					if (this.\u02BF\u02BC\u02B3\u02C1\u02BA\u02BC\u02BD\u02BB\u02B6\u02BD\u02B6.Count > 0)
					{
						streamWriter.WriteLine("Warning: These folders contain video backgrounds that wont work on all game platforms, which may be deprecated in the future.");
						streamWriter.WriteLine("This warning is primarily aimed at charters and users of those platforms. This doesn't necessarily result in any problems at this time.");
						foreach (string text4 in this.\u02BF\u02BC\u02B3\u02C1\u02BA\u02BC\u02BD\u02BB\u02B6\u02BD\u02B6)
						{
							streamWriter.WriteLine(text4);
						}
						streamWriter.WriteLine();
					}
					if (this.\u02B8\u02B2\u02B8\u02C0\u02BA\u02B7\u02C0\u02B5\u02B2\u02B5\u02BD.Count > 0)
					{
						streamWriter.WriteLine("ERROR: These folders either have no valid metadata file (song.ini), or the metadata does not include a valid song name!");
						foreach (string text5 in this.\u02B8\u02B2\u02B8\u02C0\u02BA\u02B7\u02C0\u02B5\u02B2\u02B5\u02BD)
						{
							streamWriter.WriteLine(text5);
						}
						streamWriter.WriteLine();
					}
					if (this.\u02B2\u02B5\u02BA\u02B9\u02B4\u02B2\u02B9\u02B3\u02B7\u02B2\u02BC.Count > 0)
					{
						streamWriter.WriteLine("ERROR: These folders have no notes.mid or notes.chart files!");
						foreach (string text6 in this.\u02B2\u02B5\u02BA\u02B9\u02B4\u02B2\u02B9\u02B3\u02B7\u02B2\u02BC)
						{
							streamWriter.WriteLine(text6);
						}
						streamWriter.WriteLine();
					}
					if (this.\u02BA\u02BA\u02B6\u02B4\u02B6\u02B8\u02B2\u02B5\u02B2\u02BD\u02BF.Count > 0)
					{
						streamWriter.WriteLine("ERROR: These folders have *.mid or *.chart files but are named incorrectly!");
						foreach (string text7 in this.\u02BA\u02BA\u02B6\u02B4\u02B6\u02B8\u02B2\u02B5\u02B2\u02BD\u02BF)
						{
							streamWriter.WriteLine(text7);
						}
						streamWriter.WriteLine();
					}
					if (this.\u02BC\u02B5\u02B4\u02B8\u02B7\u02B5\u02BB\u02B2\u02B6\u02B8\u02B9.Count > 0)
					{
						streamWriter.WriteLine("ERROR: These folders have corrupt (or broken) notes.mid or notes.chart files!");
						foreach (string text8 in this.\u02BC\u02B5\u02B4\u02B8\u02B7\u02B5\u02BB\u02B2\u02B6\u02B8\u02B9)
						{
							streamWriter.WriteLine(text8);
						}
						streamWriter.WriteLine();
					}
					if (this.\u02C1\u02B4\u02C0\u02B2\u02B7\u02BA\u02BB\u02B2\u02B7\u02C0\u02BF.Count > 0)
					{
						streamWriter.WriteLine("ERROR: These folders either have no audio files, the audio files are named incorrectly or the audio files are in the wrong format!");
						foreach (string text9 in this.\u02C1\u02B4\u02C0\u02B2\u02B7\u02BA\u02BB\u02B2\u02B7\u02C0\u02BF)
						{
							streamWriter.WriteLine(text9);
						}
						streamWriter.WriteLine();
					}
					if (this.\u02B5\u02B5\u02C0\u02BE\u02B7\u02B6\u02B2\u02B9\u02BC\u02B4\u02B5.Count > 0)
					{
						streamWriter.WriteLine("ERROR: These folders contain charts that another song has (duplicate charts)!");
						foreach (string text10 in this.\u02B5\u02B5\u02C0\u02BE\u02B7\u02B6\u02B2\u02B9\u02BC\u02B4\u02B5)
						{
							streamWriter.WriteLine(text10);
						}
						streamWriter.WriteLine();
					}
					if (this.\u02B5\u02BB\u02B3\u02B3\u02BB\u02BE\u02B9\u02B6\u02C0\u02B3\u02BD.Count > 0)
					{
						streamWriter.WriteLine("ERROR: These folders contain charts that don't have any supported instruments charted!");
						foreach (string text11 in this.\u02B5\u02BB\u02B3\u02B3\u02BB\u02BE\u02B9\u02B6\u02C0\u02B3\u02BD)
						{
							streamWriter.WriteLine(text11);
						}
					}
				}
			}
		}
		catch
		{
			Debug.Log("Couldn't write badsongs.txt");
		}
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x00098DE0 File Offset: 0x00096FE0
	public \u02BA\u02C0\u02B9\u02BB\u02C0\u02BE\u02B8\u02BB\u02BE\u02BD\u02BA(SongScan \u02BC\u02BC\u02B2\u02B6\u02B2\u02BE\u02B3\u02B9\u02B4\u02B4\u02C1)
	{
		this.\u02BC\u02BC\u02B2\u02B6\u02B2\u02BE\u02B3\u02B9\u02B4\u02B4\u02C1 = \u02BC\u02BC\u02B2\u02B6\u02B2\u02BE\u02B3\u02B9\u02B4\u02B4\u02C1;
		this.\u02B7\u02BA\u02BC\u02B6\u02BC\u02B2\u02B7\u02BA\u02B4\u02BF\u02BA = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B6\u02C1\u02BD\u02BA\u02BE\u02C1\u02B9\u02B2\u02BD\u02B9.Split('|', StringSplitOptions.None);
		\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02BA\u02C0\u02B2\u02C1\u02BD\u02B7\u02BC\u02BF\u02BB\u02B2\u02B7(this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA, new string[] { "song.ini", "notes.mid", "notes.chart" });
		this.\u02BA\u02C1\u02BA\u02B3\u02B9\u02B6\u02BA\u02B6\u02BF\u02B3\u02BE = Path.Combine(Application.persistentDataPath, SettingsController.\u02B8\u02BB\u02B9\u02B5\u02B3\u02B7\u02B9\u02BE\u02BC\u02BA\u02B9.CurrentValue);
		this.\u02B7\u02B5\u02BD\u02B3\u02C0\u02B5\u02BA\u02B3\u02B7\u02BA\u02BC = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "badsongs.txt");
		this.\u02B2\u02B7\u02B7\u02BD\u02BA\u02B6\u02BC\u02BC\u02BA\u02B7\u02B2 = __FIXME_clon_util.\u02B4\u02B4\u02C0\u02C1\u02BF\u02B5\u02B4\u02BD\u02B2\u02B2\u02BE();
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x00098F10 File Offset: 0x00097110
	private bool \u02B4\u02BD\u02B8\u02C1\u02BA\u02BA\u02BB\u02C0\u02B3\u02C0\u02B8(SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA)
	{
		\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B = \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.\u02BF\u02B2\u02B7\u02B9\u02BF\u02B3\u02BE\u02B3\u02B7\u02C0\u02BE(true);
		if (u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B == null || !u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B.\u02BF\u02B9\u02B6\u02B2\u02B3\u02C1\u02C1\u02B9\u02BC\u02BB\u02B8)
		{
			this.\u02BC\u02B5\u02B4\u02B8\u02B7\u02B5\u02BB\u02B2\u02B6\u02B8\u02B9.Add(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.folderPath);
			\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C1\u02BB\u02B3\u02BA\u02BB\u02C0\u02B4\u02BB\u02BB\u02B4\u02B6(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.iniPath);
			\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C1\u02BB\u02B3\u02BA\u02BB\u02C0\u02B4\u02BB\u02BB\u02B4\u02B6(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.chartPath);
			return false;
		}
		if (u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B.\u02B6\u02BB\u02B5\u02B3\u02B7\u02BA\u02BD\u02B7\u02B3\u02B6\u02BA)
		{
			this.\u02B2\u02B2\u02BF\u02C0\u02BE\u02BB\u02BB\u02BA\u02BE\u02B6\u02C1.Add(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.folderPath);
		}
		if (u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B.\u02C0\u02BE\u02B8\u02B2\u02B6\u02BA\u02BA\u02BE\u02B4\u02B4\u02B7())
		{
			this.\u02BF\u02BD\u02C0\u02B2\u02B9\u02B6\u02B9\u02B6\u02B4\u02B7\u02BE.Add(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.folderPath);
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BC\u02B4\u02BA\u02B8\u02B9\u02B4\u02BD\u02BE\u02C0\u02C0\u02BA = false;
			this.\u02B2\u02B4\u02BC\u02BC\u02B2\u02BE\u02BE\u02BE\u02BF\u02B3\u02B3 = true;
		}
		\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02BC\u02B4\u02B5\u02B8\u02B3\u02B2\u02C0\u02BA\u02B8\u02BE\u02C1();
		Array values = Enum.GetValues(typeof(Difficulty));
		foreach (object obj in Enum.GetValues(typeof(Instrument)))
		{
			Instrument instrument = (Instrument)obj;
			if (instrument != Instrument.Band && instrument != Instrument.None)
			{
				\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE u02BC_u02C0_u02BC_u02B3_u02B4_u02C1_u02B3_u02BE_u02B2_u02C1_u02BE = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02C1\u02B8\u02B6\u02B9\u02B6\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9(instrument);
				foreach (object obj2 in values)
				{
					Difficulty difficulty = (Difficulty)obj2;
					\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B7\u02C0\u02BD\u02B5\u02BF\u02C1\u02BF\u02BC\u02BA\u02B7\u02BD(difficulty);
					if (instrument == Instrument.Drums)
					{
						\u02C0\u02BA\u02B7\u02BA\u02B5\u02BE\u02BC\u02BF\u02B9\u02BC\u02B8 u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B = u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(u02BC_u02C0_u02BC_u02B3_u02B4_u02C1_u02B3_u02BE_u02B2_u02C1_u02BE, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B);
						if (u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8.Count != 0)
						{
							if (u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02BC\u02C1\u02B6\u02BB\u02B8\u02B5\u02BC\u02B9\u02B8\u02BF\u02BA || u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02BD\u02BB\u02C0\u02B8\u02BF\u02B6\u02B2\u02B7\u02BE\u02C0\u02B4 || \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.forceProDrums || \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.forceFiveLane)
							{
								\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02BB\u02BE\u02B4\u02B8\u02BA\u02B8\u02B5\u02B4\u02C1\u02B5\u02B2(Instrument.ProDrums, difficulty);
							}
							\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02BB\u02BE\u02B4\u02B8\u02BA\u02B8\u02B5\u02B4\u02C1\u02B5\u02B2(Instrument.Drums, difficulty);
						}
					}
					else if (u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(u02BC_u02C0_u02BC_u02B3_u02B4_u02C1_u02B3_u02BE_u02B2_u02C1_u02BE, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B))
					{
						\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02BB\u02BE\u02B4\u02B8\u02BA\u02B8\u02B5\u02B4\u02C1\u02B5\u02B2(instrument, difficulty);
					}
				}
			}
		}
		\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.lyrics = u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B.\u02BF\u02B8\u02BE\u02BE\u02BA\u02B8\u02B6\u02B2\u02B4\u02B7\u02B5.Count > 0;
		if (\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.lyrics)
		{
			using (List<\u02BD\u02B5\u02B3\u02BB\u02B4\u02B8\u02BF\u02B9\u02B3\u02BC\u02B5>.Enumerator enumerator3 = u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B.\u02BF\u02B8\u02BE\u02BE\u02BA\u02B8\u02B6\u02B2\u02B4\u02B7\u02B5.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					if (enumerator3.Current.\u02C0\u02C0\u02BB\u02B3\u02BE\u02B5\u02BB\u02B7\u02B7\u02BA\u02B8.Contains("\ufffd"))
					{
						this.\u02BE\u02BD\u02B5\u02BF\u02BA\u02B4\u02B7\u02BE\u02B9\u02BB\u02C1.Add(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.folderPath);
						break;
					}
				}
			}
		}
		if (\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02B2\u02C1\u02BC\u02C0\u02BA\u02B8\u02B2\u02B7\u02B2\u02B3\u02BB == 0L)
		{
			this.\u02B5\u02BB\u02B3\u02B3\u02BB\u02BE\u02B9\u02B6\u02C0\u02B3\u02BD.Add(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.folderPath);
			return false;
		}
		bool flag = \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.isEnc || this.\u02BC\u02BE\u02BF\u02B2\u02BE\u02BD\u02B7\u02B6\u02C0\u02B7\u02B9(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA);
		\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C1\u02BB\u02B3\u02BA\u02BB\u02C0\u02B4\u02BB\u02BB\u02B4\u02B6(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.iniPath);
		\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C1\u02BB\u02B3\u02BA\u02BB\u02C0\u02B4\u02BB\u02BB\u02B4\u02B6(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.chartPath);
		return flag;
	}

	// Token: 0x060012A2 RID: 4770 RVA: 0x000991BC File Offset: 0x000973BC
	private void \u02B6\u02BE\u02BA\u02BB\u02B7\u02B9\u02B5\u02C0\u02B8\u02BD\u02BD()
	{
		if (this.\u02BB\u02BE\u02BE\u02B2\u02BB\u02B9\u02B5\u02B2\u02BE\u02BF\u02B6 == null)
		{
			return;
		}
		this.\u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA = \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.UpdatingMetadata;
		foreach (SongEntry songEntry in this.\u02BB\u02BE\u02BE\u02B2\u02BB\u02B9\u02B5\u02B2\u02BE\u02BF\u02B6)
		{
			if (!this.\u02BC\u02BC\u02B2\u02B6\u02B2\u02BE\u02B3\u02B9\u02B4\u02B4\u02C1.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
			{
				break;
			}
			this.\u02B2\u02B4\u02BC\u02BC\u02B2\u02BE\u02BE\u02BE\u02BF\u02B3\u02B3 = false;
			if (!songEntry.isEnc)
			{
				if (songEntry.\u02BF\u02C1\u02B6\u02B5\u02B6\u02B2\u02BD\u02B5\u02B2\u02C0\u02BA(songEntry.iniPath))
				{
					if (this.\u02B3\u02B9\u02BA\u02B6\u02B2\u02BE\u02BE\u02B3\u02BD\u02B9\u02BC(songEntry))
					{
						songEntry.\u02B9\u02BC\u02C1\u02BC\u02B8\u02B5\u02BD\u02BE\u02B5\u02B4\u02BD();
						if (this.\u02B2\u02B4\u02BC\u02BC\u02B2\u02BE\u02BE\u02BE\u02BF\u02B3\u02B3)
						{
							songEntry.\u02B7\u02B2\u02BF\u02BE\u02B7\u02BF\u02BD\u02BD\u02B7\u02B4\u02B7(false);
						}
					}
					else
					{
						\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Remove(songEntry);
						this.\u02C1\u02B4\u02C0\u02B2\u02B7\u02BA\u02BB\u02B2\u02B7\u02C0\u02BF.Add(songEntry.folderPath);
					}
				}
				else
				{
					\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Remove(songEntry);
					this.\u02B8\u02B2\u02B8\u02C0\u02BA\u02B7\u02C0\u02B5\u02B2\u02B5\u02BD.Add(songEntry.folderPath);
				}
			}
		}
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x000992AC File Offset: 0x000974AC
	private void \u02B5\u02BD\u02BA\u02B6\u02C0\u02B7\u02B4\u02BD\u02B9\u02B5\u02B2()
	{
		Stack<string> stack = new Stack<string>();
		this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA.Clear();
		foreach (string text in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9)
		{
			try
			{
				if (!Directory.Exists(text))
				{
					Debug.LogWarning("SongPath " + text + " does not exist, or cannot be accessed.");
				}
				else
				{
					stack.Push(text);
				}
			}
			catch (Exception ex)
			{
				this.\u02C1\u02C1\u02BD\u02B3\u02B2\u02BB\u02B6\u02B8\u02BE\u02BB\u02C1.Add(ex);
				Debug.Log(ex.Message);
			}
		}
		using (IEnumerator<FileInfo> enumerator2 = new DirectoryInfo(Path.Combine(__FIXME_clon_util.\u02B4\u02B6\u02BE\u02B5\u02BB\u02BA\u02BB\u02C0\u02C1\u02C1\u02B7(), "songs")).EnumerateFiles().GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				FileInfo fileInfo = enumerator2.Current;
				if (fileInfo.Extension == ".sng")
				{
					this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA.Add(this.\u02B2\u02B7\u02B7\u02BD\u02BA\u02B6\u02BC\u02BC\u02BA\u02B7\u02B2 ? fileInfo.FullName : fileInfo.FullName.ToLowerInvariant());
				}
			}
			goto IL_01AE;
		}
		IL_0106:
		try
		{
			string text2 = stack.Pop();
			bool flag = false;
			foreach (string text3 in Directory.EnumerateDirectories(text2))
			{
				string fileName = Path.GetFileName(text3);
				if (!fileName.StartsWith("eof_") && !(fileName == "song_upgrades"))
				{
					stack.Push(text3);
					flag = true;
				}
			}
			if (!flag)
			{
				this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA.Add(this.\u02B2\u02B7\u02B7\u02BD\u02BA\u02B6\u02BC\u02BC\u02BA\u02B7\u02B2 ? text2 : text2.ToLowerInvariant());
			}
		}
		catch (Exception ex2)
		{
			this.\u02C1\u02C1\u02BD\u02B3\u02B2\u02BB\u02B6\u02B8\u02BE\u02BB\u02C1.Add(ex2);
			Debug.LogException(ex2);
		}
		IL_01AE:
		if (stack.Count <= 0)
		{
			return;
		}
		goto IL_0106;
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x0000FAD8 File Offset: 0x0000DCD8
	public int \u02BE\u02B7\u02B3\u02BB\u02B8\u02BE\u02BE\u02BF\u02BE\u02B4\u02C0()
	{
		return this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA.Count;
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x000994B4 File Offset: 0x000976B4
	private void \u02B7\u02BC\u02C0\u02B5\u02B8\u02BF\u02BE\u02BD\u02BD\u02BC\u02B2()
	{
		this.\u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA = \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.GettingPaths;
		this.\u02B5\u02BD\u02BA\u02B6\u02C0\u02B7\u02B4\u02BD\u02B9\u02B5\u02B2();
		Debug.Log(string.Format("Cache log before: {0} songs, {1} paths", \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count, this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA.Count));
		for (int i = 0; i < \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count; i++)
		{
			if (this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA.Contains(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4[i].folderPath))
			{
				this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA.Remove(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4[i].folderPath);
			}
			else
			{
				\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4[i] = null;
			}
		}
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.RemoveAll(new Predicate<SongEntry>(\u02BA\u02C0\u02B9\u02BB\u02C0\u02BE\u02B8\u02BB\u02BE\u02BD\u02BA.<>c.<>9.\u02BA\u02BF\u02B5\u02BC\u02BE\u02B2\u02B2\u02BF\u02B5\u02BE\u02BA));
		this.\u02BC\u02BC\u02B2\u02B6\u02B2\u02BE\u02B3\u02B9\u02B4\u02B4\u02C1.\u02BF\u02BF\u02BB\u02BC\u02C0\u02BA\u02B4\u02B2\u02B4\u02C1\u02B3();
		this.\u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA = \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.ScanningFolders;
		foreach (string text in this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA)
		{
			this.\u02B7\u02B9\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B4\u02B6\u02BF++;
			try
			{
				if (text.EndsWith(".sng"))
				{
					SongEntry songEntry = new SongEntry(text);
					if (this.\u02B4\u02BD\u02B8\u02C1\u02BA\u02BA\u02BB\u02C0\u02B3\u02C0\u02B8(songEntry))
					{
						songEntry.\u02B9\u02BC\u02C1\u02BC\u02B8\u02B5\u02BD\u02BE\u02B5\u02B4\u02BD();
						songEntry.dateAdded = File.GetLastWriteTime(songEntry.folderPath).Date;
						\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Add(songEntry);
					}
					songEntry.videoBackground = false;
				}
				else if (Directory.Exists(text))
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(text);
					bool flag = false;
					bool flag2 = false;
					bool flag3 = false;
					bool flag4 = false;
					string text2 = null;
					foreach (FileInfo fileInfo in directoryInfo.GetFiles())
					{
						string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileInfo.Name);
						string extension = fileInfo.Extension;
						if (fileNameWithoutExtension.Equals("notes", StringComparison.OrdinalIgnoreCase))
						{
							if (extension.Equals(".mid", StringComparison.OrdinalIgnoreCase))
							{
								flag = true;
								text2 = fileInfo.Name;
							}
							else if (extension.Equals(".chart", StringComparison.OrdinalIgnoreCase))
							{
								flag2 = true;
								text2 = fileInfo.Name;
							}
						}
						else if (fileNameWithoutExtension.Equals("song", StringComparison.OrdinalIgnoreCase) && extension.Equals(".ini", StringComparison.OrdinalIgnoreCase))
						{
							flag3 = true;
						}
						else if (fileNameWithoutExtension.Equals("video", StringComparison.OrdinalIgnoreCase) && this.\u02B7\u02BA\u02BC\u02B6\u02BC\u02B2\u02B7\u02BA\u02B4\u02BF\u02BA.Contains(extension, StringComparer.OrdinalIgnoreCase))
						{
							if (!extension.Equals(".webm", StringComparison.OrdinalIgnoreCase) && !extension.Equals(".vp8", StringComparison.OrdinalIgnoreCase) && !extension.Equals(".ogv", StringComparison.OrdinalIgnoreCase))
							{
								this.\u02BF\u02BC\u02B3\u02C1\u02BA\u02BC\u02BD\u02BB\u02B6\u02BD\u02B6.Add(text);
							}
							flag4 = true;
						}
					}
					bool flag5 = text2 == null && !flag && !flag2;
					if (!flag5 || flag3)
					{
						if (flag5)
						{
							this.\u02B2\u02B5\u02BA\u02B9\u02B4\u02B2\u02B9\u02B3\u02B7\u02B2\u02BC.Add(text);
						}
						else
						{
							SongEntry songEntry2 = new SongEntry(text);
							if (!songEntry2.HasValidName)
							{
								this.\u02B8\u02B2\u02B8\u02C0\u02BA\u02B7\u02C0\u02B5\u02B2\u02B5\u02BD.Add(text);
							}
							else
							{
								int num = (flag ? 2 : (flag2 ? 1 : 0));
								songEntry2.videoBackground = flag4;
								songEntry2.chartName = text2;
								if (songEntry2.metadataLoaded)
								{
									this.\u02B2\u02B4\u02BC\u02BC\u02B2\u02BE\u02BE\u02BE\u02BF\u02B3\u02B3 = false;
									if (this.\u02B3\u02B9\u02BA\u02B6\u02B2\u02BE\u02BE\u02B3\u02BD\u02B9\u02BC(songEntry2))
									{
										if (num > 0 && this.\u02B4\u02BD\u02B8\u02C1\u02BA\u02BA\u02BB\u02C0\u02B3\u02C0\u02B8(songEntry2))
										{
											songEntry2.\u02B9\u02BC\u02C1\u02BC\u02B8\u02B5\u02BD\u02BE\u02B5\u02B4\u02BD();
											songEntry2.dateAdded = DateTime.Now.Date;
											\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Add(songEntry2);
											if (this.\u02B2\u02B4\u02BC\u02BC\u02B2\u02BE\u02BE\u02BE\u02BF\u02B3\u02B3 || (num == 1 && !flag3))
											{
												songEntry2.\u02B7\u02B2\u02BF\u02BE\u02B7\u02BF\u02BD\u02BD\u02B7\u02B4\u02B7(num == 1 && !flag3);
											}
										}
									}
									else
									{
										this.\u02C1\u02B4\u02C0\u02B2\u02B7\u02BA\u02BB\u02B2\u02B7\u02C0\u02BF.Add(text);
									}
								}
								else
								{
									this.\u02B8\u02B2\u02B8\u02C0\u02BA\u02B7\u02C0\u02B5\u02B2\u02B5\u02BD.Add(text);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				string text3;
				if (this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA == null)
				{
					text3 = "<NULL PATH>";
				}
				else if (this.\u02B7\u02B9\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B4\u02B6\u02BF > this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA.Count)
				{
					text3 = "<OOB PATH>";
				}
				else
				{
					text3 = text;
				}
				string text4 = string.Format("Encountered exception while attempting to load {0}", text3);
				this.\u02C1\u02C1\u02BD\u02B3\u02B2\u02BB\u02B6\u02B8\u02BE\u02BB\u02C1.Add(new \u02BA\u02C0\u02B9\u02BB\u02C0\u02BE\u02B8\u02BB\u02BE\u02BD\u02BA.\u02BF\u02C1\u02BA\u02B6\u02B9\u02BA\u02BB\u02B6\u02B2\u02B8\u02BC(text4, ex));
				Debug.LogException(ex);
			}
		}
		this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA.Clear();
		this.\u02B7\u02B9\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B4\u02B6\u02BF = 0;
	}

	// Token: 0x170001CC RID: 460
	// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0000FAD8 File Offset: 0x0000DCD8
	public int \u02BE\u02BB\u02BD\u02BF\u02BB\u02BA\u02BF\u02BD\u02B7\u02BB\u02BD
	{
		get
		{
			return this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA.Count;
		}
	}

	// Token: 0x060012A7 RID: 4775 RVA: 0x00099914 File Offset: 0x00097B14
	public void \u02B6\u02B3\u02C0\u02B5\u02B3\u02BD\u02B7\u02BF\u02BA\u02BC\u02B4()
	{
		this.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.Start();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02BF\u02BA\u02C1\u02B5\u02BB\u02C0\u02BA\u02BB\u02B6\u02BF();
		this.\u02B5\u02BE\u02C1\u02B3\u02BB\u02BA\u02BE\u02B6\u02B8\u02B9\u02B5(true);
		this.\u02B7\u02BC\u02C0\u02B5\u02B8\u02BF\u02BE\u02BD\u02BD\u02BC\u02B2();
		this.\u02B6\u02BE\u02BA\u02BB\u02B7\u02B9\u02B5\u02C0\u02B8\u02BD\u02BD();
		this.\u02BD\u02B7\u02BA\u02B6\u02BE\u02BC\u02B5\u02BF\u02B4\u02BF\u02B2();
		this.\u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA = \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.SortingMetadata;
		this.\u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA = \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.OnlineHash;
		this.\u02B9\u02BA\u02C0\u02B8\u02BA\u02B6\u02B3\u02BA\u02B3\u02B6\u02B5();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B9\u02B5\u02C0\u02B2\u02B6\u02B7\u02BD\u02B6\u02BB\u02B5();
		this.\u02B6\u02B6\u02B5\u02B9\u02BA\u02B4\u02C1\u02C0\u02BC\u02B7\u02B6();
		this.\u02BE\u02B2\u02B4\u02B4\u02BF\u02B3\u02C0\u02BE\u02B3\u02B2\u02BC();
		if (this.\u02C1\u02C1\u02BD\u02B3\u02B2\u02BB\u02B6\u02B8\u02BE\u02BB\u02C1.Count > 0)
		{
			using (Stream stream = File.Create(Path.Combine(Directory.GetParent(this.\u02BA\u02C1\u02BA\u02B3\u02B9\u02B6\u02BA\u02B6\u02BF\u02B3\u02BE).FullName, "errors.txt")))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					foreach (Exception ex in this.\u02C1\u02C1\u02BD\u02B3\u02B2\u02BB\u02B6\u02B8\u02BE\u02BB\u02C1)
					{
						streamWriter.WriteLine(ex.ToString());
					}
				}
			}
		}
		this.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.Stop();
		Debug.Log("Full Scan Elapsed Time: " + this.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.Elapsed.TotalSeconds.ToString());
		\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C0\u02B4\u02B3\u02C0\u02BC\u02C0\u02B9\u02C1\u02B2\u02BF\u02B8 = false;
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x00099A58 File Offset: 0x00097C58
	private void \u02B6\u02B6\u02B5\u02B9\u02BA\u02B4\u02C1\u02C0\u02BC\u02B7\u02B6()
	{
		this.\u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA = \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.WritingCache;
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count == 0)
		{
			return;
		}
		if (!this.\u02BC\u02BC\u02B2\u02B6\u02B2\u02BE\u02B3\u02B9\u02B4\u02B4\u02C1.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
		{
			return;
		}
		using (Stream stream = File.Create(this.\u02BA\u02C1\u02BA\u02B3\u02B9\u02B6\u02BA\u02B6\u02BF\u02B3\u02BE))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				binaryWriter.Write(20221120);
				binaryWriter.Write(\u02C0\u02BC\u02B6\u02BB\u02BA\u02BD\u02B5\u02BE\u02BD\u02B7\u02B9.\u02B7\u02BA\u02BB\u02B7\u02BB\u02B9\u02B4\u02B7\u02B5\u02BE\u02B4.ToArray());
				\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02BC\u02B6\u02B6\u02B5\u02BA\u02BE\u02B5\u02B3\u02BF\u02C1(binaryWriter);
				binaryWriter.Write(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count);
				foreach (SongEntry songEntry in \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4)
				{
					FileInfo fileInfo = new FileInfo(songEntry.iniPath);
					FileInfo fileInfo2 = new FileInfo(songEntry.chartPath);
					if (fileInfo.Exists && fileInfo2.Exists)
					{
						binaryWriter.Write(songEntry.folderPath);
						binaryWriter.Write(fileInfo.LastWriteTime.ToBinary());
						binaryWriter.Write(fileInfo2.LastWriteTime.ToBinary());
						songEntry.\u02C0\u02B3\u02B2\u02C1\u02B7\u02BB\u02BA\u02BF\u02B8\u02B5\u02B3(binaryWriter);
					}
				}
			}
		}
	}

	// Token: 0x060012A9 RID: 4777 RVA: 0x0000FAE5 File Offset: 0x0000DCE5
	public void \u02C0\u02C1\u02BA\u02BB\u02B3\u02C0\u02BE\u02B9\u02C0\u02BA\u02C1()
	{
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02BF\u02BA\u02C1\u02B5\u02BB\u02C0\u02BA\u02BB\u02B6\u02BF();
		this.\u02B5\u02BE\u02C1\u02B3\u02BB\u02BA\u02BE\u02B6\u02B8\u02B9\u02B5(false);
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B9\u02B5\u02C0\u02B2\u02B6\u02B7\u02BD\u02B6\u02BB\u02B5();
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x00099BA0 File Offset: 0x00097DA0
	private bool \u02B3\u02B2\u02BA\u02B8\u02B6\u02B3\u02BF\u02C1\u02B5\u02BD\u02C1(SongEntry \u02B4\u02C1\u02B2\u02BD\u02B4\u02B4\u02BC\u02B6\u02B4\u02B3\u02B3)
	{
		if (SettingsController.\u02BF\u02C0\u02B4\u02B3\u02BB\u02B8\u02BA\u02BE\u02B3\u02B5\u02B2)
		{
			return false;
		}
		foreach (SongEntry songEntry in \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4)
		{
			if (songEntry.checksum == \u02B4\u02C1\u02B2\u02BD\u02B4\u02B4\u02BC\u02B6\u02B4\u02B3\u02B3.checksum && songEntry != \u02B4\u02C1\u02B2\u02BD\u02B4\u02B4\u02BC\u02B6\u02B4\u02B3\u02B3)
			{
				this.\u02B5\u02B5\u02C0\u02BE\u02B7\u02B6\u02B2\u02B9\u02BC\u02B4\u02B5.Add(songEntry.folderPath + " (" + \u02B4\u02C1\u02B2\u02BD\u02B4\u02B4\u02BC\u02B6\u02B4\u02B3\u02B3.folderPath + ")");
				return true;
			}
		}
		return false;
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x00099C40 File Offset: 0x00097E40
	private void \u02BD\u02B7\u02BA\u02B6\u02BE\u02BC\u02B5\u02BF\u02B4\u02BF\u02B2()
	{
		if (this.\u02B8\u02B6\u02BB\u02BD\u02B9\u02B8\u02B8\u02BE\u02B4\u02BB\u02B4 == null)
		{
			return;
		}
		this.\u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA = \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8.UpdatingCharts;
		foreach (SongEntry songEntry in this.\u02B8\u02B6\u02BB\u02BD\u02B9\u02B8\u02B8\u02BE\u02B4\u02BB\u02B4)
		{
			if (!this.\u02BC\u02BC\u02B2\u02B6\u02B2\u02BE\u02B3\u02B9\u02B4\u02B4\u02C1.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
			{
				break;
			}
			this.\u02B2\u02B4\u02BC\u02BC\u02B2\u02BE\u02BE\u02BE\u02BF\u02B3\u02B3 = false;
			if (!songEntry.isEnc)
			{
				try
				{
					if (this.\u02B4\u02BD\u02B8\u02C1\u02BA\u02BA\u02BB\u02C0\u02B3\u02C0\u02B8(songEntry))
					{
						if (this.\u02B2\u02B4\u02BC\u02BC\u02B2\u02BE\u02BE\u02BE\u02BF\u02B3\u02B3)
						{
							songEntry.\u02B7\u02B2\u02BF\u02BE\u02B7\u02BF\u02BD\u02BD\u02B7\u02B4\u02B7(false);
						}
					}
					else
					{
						\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Remove(songEntry);
					}
				}
				catch (Exception ex)
				{
					this.\u02C1\u02C1\u02BD\u02B3\u02B2\u02BB\u02B6\u02B8\u02BE\u02BB\u02C1.Add(ex);
				}
			}
		}
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x00099D00 File Offset: 0x00097F00
	public void asyncthing(string text)
	{
		this.\u02B7\u02B9\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B4\u02B6\u02BF++;
		try
		{
			if (text.EndsWith(".sng"))
			{
				SongEntry songEntry = new SongEntry(text);
				if (this.\u02B4\u02BD\u02B8\u02C1\u02BA\u02BA\u02BB\u02C0\u02B3\u02C0\u02B8(songEntry))
				{
					songEntry.\u02B9\u02BC\u02C1\u02BC\u02B8\u02B5\u02BD\u02BE\u02B5\u02B4\u02BD();
					songEntry.dateAdded = File.GetLastWriteTime(songEntry.folderPath).Date;
					\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Add(songEntry);
				}
				songEntry.videoBackground = false;
			}
			else if (Directory.Exists(text))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(text);
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				string text2 = null;
				foreach (FileInfo fileInfo in directoryInfo.GetFiles())
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileInfo.Name);
					string extension = fileInfo.Extension;
					if (fileNameWithoutExtension.Equals("notes", StringComparison.OrdinalIgnoreCase))
					{
						if (extension.Equals(".mid", StringComparison.OrdinalIgnoreCase))
						{
							flag = true;
							text2 = fileInfo.Name;
						}
						else if (extension.Equals(".chart", StringComparison.OrdinalIgnoreCase))
						{
							flag2 = true;
							text2 = fileInfo.Name;
						}
					}
					else if (fileNameWithoutExtension.Equals("song", StringComparison.OrdinalIgnoreCase) && extension.Equals(".ini", StringComparison.OrdinalIgnoreCase))
					{
						flag3 = true;
					}
					else if (fileNameWithoutExtension.Equals("video", StringComparison.OrdinalIgnoreCase) && this.\u02B7\u02BA\u02BC\u02B6\u02BC\u02B2\u02B7\u02BA\u02B4\u02BF\u02BA.Contains(extension, StringComparer.OrdinalIgnoreCase))
					{
						if (!extension.Equals(".webm", StringComparison.OrdinalIgnoreCase) && !extension.Equals(".vp8", StringComparison.OrdinalIgnoreCase) && !extension.Equals(".ogv", StringComparison.OrdinalIgnoreCase))
						{
							this.\u02BF\u02BC\u02B3\u02C1\u02BA\u02BC\u02BD\u02BB\u02B6\u02BD\u02B6.Add(text);
						}
						flag4 = true;
					}
				}
				bool flag5 = text2 == null && !flag && !flag2;
				if (!flag5 || flag3)
				{
					if (flag5)
					{
						this.\u02B2\u02B5\u02BA\u02B9\u02B4\u02B2\u02B9\u02B3\u02B7\u02B2\u02BC.Add(text);
					}
					else
					{
						SongEntry songEntry2 = new SongEntry(text);
						if (!songEntry2.HasValidName)
						{
							this.\u02B8\u02B2\u02B8\u02C0\u02BA\u02B7\u02C0\u02B5\u02B2\u02B5\u02BD.Add(text);
						}
						else
						{
							int num = (flag ? 2 : ((flag2 > false) ? 1 : 0));
							songEntry2.videoBackground = flag4;
							songEntry2.chartName = text2;
							if (songEntry2.metadataLoaded)
							{
								this.\u02B2\u02B4\u02BC\u02BC\u02B2\u02BE\u02BE\u02BE\u02BF\u02B3\u02B3 = false;
								if (this.\u02B3\u02B9\u02BA\u02B6\u02B2\u02BE\u02BE\u02B3\u02BD\u02B9\u02BC(songEntry2))
								{
									if (num > 0 && this.\u02B4\u02BD\u02B8\u02C1\u02BA\u02BA\u02BB\u02C0\u02B3\u02C0\u02B8(songEntry2))
									{
										songEntry2.\u02B9\u02BC\u02C1\u02BC\u02B8\u02B5\u02BD\u02BE\u02B5\u02B4\u02BD();
										songEntry2.dateAdded = DateTime.Now.Date;
										\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Add(songEntry2);
										if (this.\u02B2\u02B4\u02BC\u02BC\u02B2\u02BE\u02BE\u02BE\u02BF\u02B3\u02B3 || (num == 1 && !flag3))
										{
											songEntry2.\u02B7\u02B2\u02BF\u02BE\u02B7\u02BF\u02BD\u02BD\u02B7\u02B4\u02B7(num == 1 && !flag3);
										}
									}
								}
								else
								{
									this.\u02C1\u02B4\u02C0\u02B2\u02B7\u02BA\u02BB\u02B2\u02B7\u02C0\u02BF.Add(text);
								}
							}
							else
							{
								this.\u02B8\u02B2\u02B8\u02C0\u02BA\u02B7\u02C0\u02B5\u02B2\u02B5\u02BD.Add(text);
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			string text3;
			if (this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA == null)
			{
				text3 = "<NULL PATH>";
			}
			else if (this.\u02B7\u02B9\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B4\u02B6\u02BF > this.\u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA.Count)
			{
				text3 = "<OOB PATH>";
			}
			else
			{
				text3 = text;
			}
			string text4 = string.Format("Encountered exception while attempting to load {0}", text3);
			this.\u02C1\u02C1\u02BD\u02B3\u02B2\u02BB\u02B6\u02B8\u02BE\u02BB\u02C1.Add(new \u02BA\u02C0\u02B9\u02BB\u02C0\u02BE\u02B8\u02BB\u02BE\u02BD\u02BA.\u02BF\u02C1\u02BA\u02B6\u02B9\u02BA\u02BB\u02B6\u02B2\u02B8\u02BC(text4, ex));
			Debug.LogException(ex);
		}
	}

	// Token: 0x04000DFB RID: 3579
	private List<SongEntry> \u02B8\u02B6\u02BB\u02BD\u02B9\u02B8\u02B8\u02BE\u02B4\u02BB\u02B4;

	// Token: 0x04000DFC RID: 3580
	private List<SongEntry> \u02BB\u02BE\u02BE\u02B2\u02BB\u02B9\u02B5\u02B2\u02BE\u02BF\u02B6;

	// Token: 0x04000DFD RID: 3581
	public List<Exception> \u02C1\u02C1\u02BD\u02B3\u02B2\u02BB\u02B6\u02B8\u02BE\u02BB\u02C1 = new List<Exception>();

	// Token: 0x04000DFE RID: 3582
	public List<string> \u02BF\u02BC\u02B3\u02C1\u02BA\u02BC\u02BD\u02BB\u02B6\u02BD\u02B6 = new List<string>();

	// Token: 0x04000DFF RID: 3583
	public List<string> \u02BE\u02BD\u02B5\u02BF\u02BA\u02B4\u02B7\u02BE\u02B9\u02BB\u02C1 = new List<string>();

	// Token: 0x04000E00 RID: 3584
	public List<string> \u02B2\u02B2\u02BF\u02C0\u02BE\u02BB\u02BB\u02BA\u02BE\u02B6\u02C1 = new List<string>();

	// Token: 0x04000E01 RID: 3585
	public List<string> \u02C1\u02B4\u02C0\u02B2\u02B7\u02BA\u02BB\u02B2\u02B7\u02C0\u02BF = new List<string>();

	// Token: 0x04000E02 RID: 3586
	public List<string> \u02BC\u02B5\u02B4\u02B8\u02B7\u02B5\u02BB\u02B2\u02B6\u02B8\u02B9 = new List<string>();

	// Token: 0x04000E03 RID: 3587
	public List<string> \u02B2\u02B5\u02BA\u02B9\u02B4\u02B2\u02B9\u02B3\u02B7\u02B2\u02BC = new List<string>();

	// Token: 0x04000E04 RID: 3588
	public List<string> \u02BA\u02BA\u02B6\u02B4\u02B6\u02B8\u02B2\u02B5\u02B2\u02BD\u02BF = new List<string>();

	// Token: 0x04000E05 RID: 3589
	public List<string> \u02B8\u02B2\u02B8\u02C0\u02BA\u02B7\u02C0\u02B5\u02B2\u02B5\u02BD = new List<string>();

	// Token: 0x04000E06 RID: 3590
	public List<string> \u02B5\u02B5\u02C0\u02BE\u02B7\u02B6\u02B2\u02B9\u02BC\u02B4\u02B5 = new List<string>();

	// Token: 0x04000E07 RID: 3591
	public List<string> \u02B5\u02BB\u02B3\u02B3\u02BB\u02BE\u02B9\u02B6\u02C0\u02B3\u02BD = new List<string>();

	// Token: 0x04000E08 RID: 3592
	public List<string> \u02BF\u02BD\u02C0\u02B2\u02B9\u02B6\u02B9\u02B6\u02B4\u02B7\u02BE = new List<string>();

	// Token: 0x04000E09 RID: 3593
	private Stopwatch \u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD = new Stopwatch();

	// Token: 0x04000E0A RID: 3594
	private string \u02BA\u02C1\u02BA\u02B3\u02B9\u02B6\u02BA\u02B6\u02BF\u02B3\u02BE;

	// Token: 0x04000E0B RID: 3595
	private bool \u02B2\u02B4\u02BC\u02BC\u02B2\u02BE\u02BE\u02BE\u02BF\u02B3\u02B3;

	// Token: 0x04000E0C RID: 3596
	private List<string> \u02B8\u02B2\u02B3\u02B7\u02C1\u02B2\u02BF\u02B8\u02BA\u02BE\u02BA = new List<string>();

	// Token: 0x04000E0D RID: 3597
	public int \u02B7\u02B9\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B4\u02B6\u02BF;

	// Token: 0x04000E0E RID: 3598
	public \u02B6\u02BB\u02B3\u02BD\u02B9\u02B3\u02BB\u02B4\u02BB\u02B8\u02B8 \u02C0\u02BF\u02B2\u02BC\u02C0\u02B4\u02B7\u02B5\u02C1\u02B8\u02BA;

	// Token: 0x04000E0F RID: 3599
	private readonly string \u02B7\u02B5\u02BD\u02B3\u02C0\u02B5\u02BA\u02B3\u02B7\u02BA\u02BC;

	// Token: 0x04000E10 RID: 3600
	private readonly SongScan \u02BC\u02BC\u02B2\u02B6\u02B2\u02BE\u02B3\u02B9\u02B4\u02B4\u02C1;

	// Token: 0x04000E11 RID: 3601
	public Exception \u02BD\u02B3\u02BE\u02B4\u02B7\u02C1\u02B5\u02BC\u02BE\u02B5\u02B8;

	// Token: 0x04000E12 RID: 3602
	private string[] \u02B7\u02BA\u02BC\u02B6\u02BC\u02B2\u02B7\u02BA\u02B4\u02BF\u02BA;

	// Token: 0x04000E13 RID: 3603
	private bool \u02B2\u02B7\u02B7\u02BD\u02BA\u02B6\u02BC\u02BC\u02BA\u02B7\u02B2;

	// Token: 0x020001A1 RID: 417
	private class \u02BF\u02C1\u02BA\u02B6\u02B9\u02BA\u02BB\u02B6\u02B2\u02B8\u02BC : Exception
	{
		// Token: 0x060012AD RID: 4781 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		public \u02BF\u02C1\u02BA\u02B6\u02B9\u02BA\u02BB\u02B6\u02B2\u02B8\u02BC(string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, Exception \u02B8\u02B5\u02C1\u02B5\u02B8\u02BF\u02B9\u02B7\u02B8\u02BD\u02B5)
			: base(\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, \u02B8\u02B5\u02C1\u02B5\u02B8\u02BF\u02B9\u02B7\u02B8\u02BD\u02B5)
		{
		}
	}
}
