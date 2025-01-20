using System;
using System.Collections.Generic;
using System.IO;
using StrikeCore;
using StrikeCore.Logging;
using UnityEngine;

[Serializable]
public class SongEntry
{
	public sbyte GuitarCoopIntensity
	{
		get
		{
			return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.GuitarCoop);
		}
	}

	public sbyte GHLRhythmIntensity
	{
		get
		{
			return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.GHLRhythm);
		}
	}

	public bool HasValidName
	{
		get
		{
			return !string.IsNullOrWhiteSpace(SongEntry.metadataCache[0]);
		}
	}

	public bool \u02BF\u02B3\u02B4\u02BE\u02BD\u02BB\u02B4\u02BD\u02BF\u02B5\u02BD(string \u02B8\u02BA\u02BB\u02B4\u02B5\u02B4\u02B6\u02B6\u02C0\u02B9\u02BF)
	{
		try
		{
			GlobalVariables.instance.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B3\u02B7\u02B5\u02BE\u02B4\u02BA\u02BB\u02B6\u02B3\u02BF\u02B6();
			this.isTypeCached = false;
			using (Stream stream = File.Open(\u02B8\u02BA\u02BB\u02B4\u02B5\u02B4\u02B6\u02B6\u02C0\u02B9\u02BF, FileMode.Open))
			{
				using (StreamReader streamReader = new StreamReader(stream))
				{
					while (!streamReader.EndOfStream)
					{
						string[] array = streamReader.ReadLine().Trim().Split('=', StringSplitOptions.None);
						if (array[0] == "}")
						{
							break;
						}
						if (array.Length > 1)
						{
							string text = array[1].Replace("\"", string.Empty).Trim();
							if (string.IsNullOrWhiteSpace(text))
							{
								text = string.Empty;
							}
							string text2 = array[0].ToLowerInvariant().Trim();
							uint num = PrivateImplementationDetails.ComputeStringHash(text2);
							if (num <= 1387596744U)
							{
								if (num != 348705738U)
								{
									if (num != 572804318U)
									{
										if (num == 1387596744U)
										{
											if (text2 == "charter")
											{
												SongEntry.metadataCache[5] = text;
											}
										}
									}
									else if (text2 == "artist")
									{
										SongEntry.metadataCache[1] = text;
									}
								}
								else if (text2 == "offset")
								{
									GlobalVariables.instance.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC = (int)Math.Ceiling((double)(float.Parse(text) * 1000f));
								}
							}
							else if (num <= 1986820544U)
							{
								if (num != 1694181484U)
								{
									if (num == 1986820544U)
									{
										if (text2 == "genre")
										{
											SongEntry.metadataCache[3] = text;
										}
									}
								}
								else if (text2 == "album")
								{
									SongEntry.metadataCache[2] = text;
								}
							}
							else if (num != 2369371622U)
							{
								if (num == 2927578396U)
								{
									if (text2 == "year")
									{
										SongEntry.metadataCache[4] = text.Replace(", ", string.Empty);
									}
								}
							}
							else if (text2 == "name")
							{
								if (text == "TEMPO TRACK" || text == string.Empty || text == "midi_export")
								{
									return false;
								}
								SongEntry.metadataCache[0] = text;
							}
						}
					}
				}
			}
			for (int i = 0; i < this.intensities.Length; i++)
			{
				this.intensities[i] = -1;
			}
		}
		catch
		{
			return false;
		}
		return SongEntry.metadataCache[0] != null;
	}

	public \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9 \u02B6\u02B7\u02B2\u02C1\u02B9\u02B3\u02B8\u02BC\u02B4\u02BD\u02BB()
	{
		return this.\u02C0\u02C0\u02B3\u02BC\u02BC\u02BB\u02C0\u02B4\u02BC\u02BB\u02BF(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Name);
	}

	public string Artist_StrippedTags
	{
		get
		{
			return StringUtils.StripTags(this.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5, false);
		}
	}

	public \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9 Year
	{
		get
		{
			return this.\u02C0\u02C0\u02B3\u02BC\u02BC\u02BB\u02C0\u02B4\u02BC\u02BB\u02BF(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Year);
		}
	}

	public \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9 Genre
	{
		get
		{
			return this.\u02C0\u02C0\u02B3\u02BC\u02BC\u02BB\u02C0\u02B4\u02BC\u02BB\u02BF(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Genre);
		}
	}

	public sbyte \u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		if (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			return -1;
		}
		if (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.ProDrums && this.intensities[(int)\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF] == -1)
		{
			return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.Drums);
		}
		return this.intensities[(int)\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF];
	}

	public string iniPath
	{
		get
		{
			if (!this.isEnc)
			{
				return Path.Combine(this.folderPath, "song.ini");
			}
			return this.folderPath;
		}
	}

	public bool isMIDIChart
	{
		get
		{
			if (!this.isTypeCached)
			{
				this.isMidiChartCache = Path.GetExtension(this.chartName).Equals(".mid", StringComparison.OrdinalIgnoreCase);
				this.isTypeCached = true;
			}
			return this.isMidiChartCache;
		}
	}

	public sbyte GHLGuitarCoopIntensity
	{
		get
		{
			return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.GHLGuitarCoop);
		}
	}

	public bool \u02BC\u02B7\u02B6\u02B4\u02C1\u02BC\u02BA\u02B9\u02BF\u02BD\u02B9(\u02BD\u02BC\u02B2\u02B4\u02B2\u02C0\u02B8\u02BB\u02B8\u02B2\u02B9 \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0)
	{
		this.chartName = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B3\u02C0\u02C1\u02B3\u02BB\u02BE\u02C1\u02B7\u02BB\u02B6\u02BF;
		SongEntry.metadataCache[0] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD;
		SongEntry.metadataCache[1] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02C1\u02B5\u02B3\u02B9\u02C1\u02B4\u02C0\u02C0\u02BD\u02B6\u02BC;
		SongEntry.metadataCache[2] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B9\u02BA\u02BA\u02B2\u02B3\u02B8\u02BA\u02B6\u02BD\u02C1\u02B4;
		SongEntry.metadataCache[3] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B4\u02C0\u02B2\u02BD\u02B3\u02BE\u02BA\u02B6\u02B4\u02B6\u02B3;
		SongEntry.metadataCache[4] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B4\u02C1\u02BC\u02B2\u02BC\u02BB\u02BA\u02B8\u02BC\u02BD\u02C1;
		SongEntry.metadataCache[5] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02BF\u02C1\u02B3\u02BF\u02B7\u02C1\u02B7\u02BC\u02B3\u02BB\u02BB;
		this.intensities[8] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02C1\u02B3\u02C0\u02B9\u02BC\u02B7\u02B9\u02B7\u02B9\u02B5\u02B5;
		this.intensities[0] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02C1\u02B3\u02BD\u02BF\u02C0\u02B2\u02BD\u02B5\u02BE\u02B9\u02B4;
		this.intensities[3] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B9\u02BA\u02C1\u02B5\u02B7\u02BB\u02B4\u02BC\u02B4\u02C0\u02B7;
		this.intensities[2] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02BB\u02B3\u02B2\u02C0\u02B9\u02B6\u02B8\u02C0\u02BD\u02B7\u02BC;
		this.intensities[1] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B3\u02C1\u02BD\u02BC\u02C0\u02B6\u02B4\u02BB\u02B2\u02B3\u02B8;
		this.intensities[6] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02BD\u02BC\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02C1\u02BE\u02C1;
		this.intensities[9] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B2\u02B6\u02B9\u02BE\u02C0\u02B3\u02C0\u02B5\u02B4\u02B2\u02B8;
		this.intensities[7] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02BF\u02BF\u02B2\u02B5\u02BE\u02B4\u02C1\u02BD\u02B9\u02B8\u02BB;
		this.intensities[4] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B3\u02C0\u02BF\u02B6\u02B3\u02B7\u02BB\u02B6\u02BC\u02BA\u02B7;
		this.intensities[5] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02BF\u02B9\u02BC\u02BA\u02C0\u02B7\u02B8\u02C1\u02B6\u02BE\u02BD;
		this.intensities[10] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B4\u02B6\u02C1\u02BE\u02BD\u02C0\u02BA\u02BE\u02BF\u02BB\u02BD;
		this.intensities[11] = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B4\u02BE\u02B5\u02BB\u02B9\u02B7\u02B6\u02BE\u02B5\u02B7\u02B2;
		this.previewStart = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B5\u02B5\u02B2\u02BB\u02B8\u02BE\u02BB\u02BF\u02C1\u02BC\u02C0;
		this.iconName = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02BF\u02B3\u02B4\u02B4\u02B2\u02B8\u02C0\u02C1\u02B5\u02BC\u02BC;
		this.playlistTrack = (short)\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B5\u02B8\u02BB\u02B8\u02B6\u02BD\u02BF\u02B4\u02B6\u02B8\u02BF;
		this.modchart = false;
		this.songLength = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B7\u02BE\u02C0\u02B2\u02B8\u02C0\u02BA\u02C1\u02BB\u02B2\u02BC;
		this.albumTrack = (short)\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02BA\u02BF\u02BE\u02C1\u02BA\u02BC\u02B8\u02B9\u02C0\u02BC\u02C1;
		this.\u02BA\u02BE\u02BE\u02B6\u02B3\u02BA\u02B4\u02C0\u02BC\u02BD\u02BE(\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B8\u02B4\u02B7\u02B5\u02B5\u02B4\u02BB\u02B9\u02C0\u02BC\u02C1);
		Debug.Log(\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD);
		return true;
	}

	public sbyte KeysIntensity
	{
		get
		{
			return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.Keys);
		}
	}

	public string Genre_StrippedTags
	{
		get
		{
			return StringUtils.StripTags(this.Genre.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5, false);
		}
	}

	public \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9 Album
	{
		get
		{
			return this.\u02C0\u02C0\u02B3\u02BC\u02BC\u02BB\u02C0\u02B4\u02BC\u02BB\u02BF(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Album);
		}
	}

	public SongEntry(string \u02BF\u02BB\u02B4\u02B3\u02B6\u02B5\u02BE\u02B8\u02B6\u02BB\u02B9)
	{
		FileAttributes attributes = File.GetAttributes(\u02BF\u02BB\u02B4\u02B3\u02B6\u02B5\u02BE\u02B8\u02B6\u02BB\u02B9);
		this.isEnc = !attributes.HasFlag(FileAttributes.Directory) && \u02BF\u02BB\u02B4\u02B3\u02B6\u02B5\u02BE\u02B8\u02B6\u02BB\u02B9.EndsWith(".sng");
		this.\u02B2\u02BF\u02B7\u02BA\u02B5\u02BB\u02BA\u02C1\u02B3\u02BD\u02C0();
		Array.Clear(SongEntry.metadataCache, 0, SongEntry.metadataCache.Length);
		string text = Path.Combine(\u02BF\u02BB\u02B4\u02B3\u02B6\u02B5\u02BE\u02B8\u02B6\u02BB\u02B9, "song.ini");
		string text2 = Path.Combine(\u02BF\u02BB\u02B4\u02B3\u02B6\u02B5\u02BE\u02B8\u02B6\u02BB\u02B9, "notes.chart");
		this.folderPath = \u02BF\u02BB\u02B4\u02B3\u02B6\u02B5\u02BE\u02B8\u02B6\u02BB\u02B9;
		if (this.isEnc)
		{
			this.\u02C1\u02BF\u02B9\u02B6\u02BD\u02B2\u02BA\u02BB\u02C1\u02BC\u02B8();
			return;
		}
		if (!this.\u02BF\u02C1\u02B6\u02B5\u02B6\u02B2\u02BD\u02B5\u02B2\u02C0\u02BA(text))
		{
			if (this.\u02BF\u02B3\u02B4\u02BE\u02BD\u02BB\u02B4\u02BD\u02BF\u02B5\u02BD(text2))
			{
				this.metadataLoaded = true;
				return;
			}
		}
		else
		{
			this.metadataLoaded = true;
		}
	}

	public override string ToString()
	{
		return string.Concat(new string[]
		{
			this.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5,
			" - ",
			this.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5,
			" - ",
			this.folderPath
		});
	}

	public \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9 Playlist
	{
		get
		{
			return this.\u02C0\u02C0\u02B3\u02BC\u02BC\u02BB\u02C0\u02B4\u02BC\u02BB\u02BF(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Playlist);
		}
	}

	public SongEntry(BinaryReader \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8, string \u02BF\u02BB\u02B4\u02B3\u02B6\u02B5\u02BE\u02B8\u02B6\u02BB\u02B9)
	{
		this.metadata = new \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9[7];
		this.\u02B2\u02BF\u02B7\u02BA\u02B5\u02BB\u02BA\u02C1\u02B3\u02BD\u02C0();
		this.\u02BE\u02BB\u02B9\u02B6\u02C1\u02BA\u02B7\u02B8\u02B2\u02C0\u02C0(\u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8);
		this.folderPath = \u02BF\u02BB\u02B4\u02B3\u02B6\u02B5\u02BE\u02B8\u02B6\u02BB\u02B9;
		if (this.isEnc)
		{
			this.\u02C1\u02BF\u02B9\u02B6\u02BD\u02B2\u02BA\u02BB\u02C1\u02BC\u02B8();
		}
	}

	public string Year_Stripped
	{
		get
		{
			return this.Year.\u02BF\u02B7\u02C1\u02B5\u02BE\u02B7\u02BC\u02C1\u02BA\u02BE\u02B9;
		}
	}

	public void \u02C1\u02BF\u02B9\u02B6\u02BD\u02B2\u02BA\u02BB\u02C1\u02BC\u02B8()
	{
		\u02B7\u02B8\u02BE\u02B3\u02C1\u02C0\u02B3\u02B5\u02BB\u02BA\u02BE u02B7_u02B8_u02BE_u02B3_u02C1_u02C0_u02B3_u02B5_u02BB_u02BA_u02BE;
		if (SongEntry.containers.TryGetValue(this.folderPath, out u02B7_u02B8_u02BE_u02B3_u02C1_u02C0_u02B3_u02B5_u02BB_u02BA_u02BE))
		{
			u02B7_u02B8_u02BE_u02B3_u02C1_u02C0_u02B3_u02B5_u02BB_u02BA_u02BE.Dispose();
			SongEntry.containers.Remove(this.folderPath);
		}
		this.songEnc = new \u02B7\u02B8\u02BE\u02B3\u02C1\u02C0\u02B3\u02B5\u02BB\u02BA\u02BE(this.folderPath);
		SongEntry.containers.Add(this.folderPath, this.songEnc);
		if (!this.metadataLoaded)
		{
			this.\u02BC\u02B7\u02B6\u02B4\u02C1\u02BC\u02BA\u02B9\u02BF\u02BD\u02B9(this.songEnc.\u02BF\u02C0\u02BA\u02B7\u02BC\u02BE\u02B3\u02C0\u02B9\u02B3\u02C1);
			this.metadataLoaded = true;
		}
	}

	public string checksumString
	{
		get
		{
			if (this.checksumStringCached == null)
			{
				this.checksumStringCached = this.checksum.ToString();
			}
			return this.checksumStringCached;
		}
	}

	public void \u02B7\u02B2\u02BF\u02BE\u02B7\u02BF\u02BD\u02BD\u02B7\u02B4\u02B7(bool \u02B4\u02BF\u02BB\u02C1\u02BA\u02BC\u02BD\u02BE\u02BA\u02B8\u02BA)
	{
		INIParser iniparser = new INIParser();
		iniparser.Open(this.iniPath);
		iniparser.WriteValue("song", "name", this.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
		iniparser.WriteValue("song", "artist", this.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
		iniparser.WriteValue("song", "album", this.Album.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
		iniparser.WriteValue("song", "genre", this.Genre.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
		iniparser.WriteValue("song", "year", this.Year.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
		iniparser.WriteValue("song", "diff_band", (int)this.BandIntensity);
		iniparser.WriteValue("song", "diff_guitar", (int)this.GuitarIntensity);
		iniparser.WriteValue("song", "diff_rhythm", (int)this.RhythmIntensity);
		iniparser.WriteValue("song", "diff_bass", (int)this.BassIntensity);
		iniparser.WriteValue("song", "diff_drums", (int)this.DrumsIntensity);
		iniparser.WriteValue("song", "diff_drums_real", (int)this.ProDrumsIntensity);
		iniparser.WriteValue("song", "diff_keys", (int)this.KeysIntensity);
		iniparser.WriteValue("song", "diff_guitarghl", (int)this.GHLGuitarIntensity);
		iniparser.WriteValue("song", "diff_bassghl", (int)this.GHLBassIntensity);
		iniparser.WriteValue("song", "diff_rhythm_ghl", (int)this.GHLRhythmIntensity);
		iniparser.WriteValue("song", "diff_guitar_coop_ghl", (int)this.GHLRhythmIntensity);
		iniparser.WriteValue("song", "diff_bassghl", (int)this.GHLBassIntensity);
		iniparser.WriteValue("song", "diff_guitar_coop", (int)this.GuitarCoopIntensity);
		iniparser.WriteValue("song", "preview_start_time", this.previewStart);
		iniparser.WriteValue("song", "pro_drums", this.forceProDrums);
		iniparser.WriteValue("song", "five_lane_drums", this.forceFiveLane);
		iniparser.WriteValue("song", "icon", this.iconName);
		iniparser.WriteValue("song", "album_track", (int)this.albumTrack);
		iniparser.WriteValue("song", "playlist_track", (int)this.playlistTrack);
		iniparser.WriteValue("song", "charter", this.Charter.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
		iniparser.WriteValue("song", "modchart", this.modchart);
		iniparser.WriteValue("song", "song_length", (this.songLength > 0) ? this.songLength : ((int)(BassAudioManager.Instance.\u02B2\u02BF\u02B2\u02B9\u02B4\u02BC\u02BB\u02B4\u02B2\u02C1\u02BD * 1000.0)));
		iniparser.WriteValue("song", "end_events", GlobalVariables.instance.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BC\u02B4\u02BA\u02B8\u02B9\u02B4\u02BD\u02BE\u02C0\u02C0\u02BA);
		if (iniparser.IsKeyExists("song", "diff_coop"))
		{
			int num = iniparser.ReadValue("song", "diff_coop", -2);
			iniparser.KeyDelete("song", "diff_coop");
			if (num >= 0)
			{
				iniparser.WriteValue("song", "diff_guitar_coop", num);
			}
		}
		if (iniparser.IsKeyExists("song", "diff_coopghl"))
		{
			int num2 = iniparser.ReadValue("song", "diff_coopghl", -2);
			iniparser.KeyDelete("song", "diff_coopghl");
			if (num2 >= 0)
			{
				iniparser.WriteValue("song", "diff_guitar_coop_ghl", num2);
			}
		}
		if (iniparser.IsKeyExists("song", "diff_rhythmghl"))
		{
			int num3 = iniparser.ReadValue("song", "diff_rhythmghl", -2);
			iniparser.KeyDelete("song", "diff_rhythmghl");
			if (num3 >= 0)
			{
				iniparser.WriteValue("song", "diff_rhythm_ghl", num3);
			}
		}
		if (\u02B4\u02BF\u02BB\u02C1\u02BA\u02BC\u02BD\u02BE\u02BA\u02B8\u02BA)
		{
			iniparser.WriteValue("song", "delay", GlobalVariables.instance.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC);
			iniparser.WriteValue("song", "video_start_time", GlobalVariables.instance.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B4\u02B5\u02BF\u02B2\u02B9\u02B8\u02C1\u02B7\u02BF\u02B3\u02B7);
		}
		try
		{
			iniparser.Close();
		}
		catch (Exception)
		{
			Log.LogError("Error flushing ini file to disk skipping write back.", "WriteMetadata", "E:\\development\\2guitargame\\Assets\\Scripts\\Song\\SongEntry.cs", 588);
		}
		\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02BC\u02BE\u02BA\u02BB\u02B4\u02BB\u02BE\u02BA\u02B3\u02BD\u02C0(this.iniPath);
	}

	public \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 \u02BF\u02B2\u02B7\u02B9\u02BF\u02B3\u02BE\u02B3\u02B7\u02C0\u02BE(bool \u02BB\u02C0\u02BD\u02BF\u02BC\u02B9\u02B3\u02BC\u02B5\u02C1\u02C1)
	{
		this.isTypeCached = false;
		if (this.isEnc)
		{
			if (this.isMIDIChart)
			{
				return \u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BB\u02B5\u02C0\u02B8\u02B2\u02B6\u02C0\u02C1\u02B2\u02B5\u02C1(this.songEnc.\u02B6\u02C1\u02BE\u02B2\u02B9\u02B3\u02B8\u02BB\u02BD\u02B6\u02BA, \u02BB\u02C0\u02BD\u02BF\u02BC\u02B9\u02B3\u02BC\u02B5\u02C1\u02C1);
			}
			return new \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6(this.songEnc.\u02B6\u02C1\u02BE\u02B2\u02B9\u02B3\u02B8\u02BB\u02BD\u02B6\u02BA, false);
		}
		else
		{
			if (this.isMIDIChart)
			{
				return \u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BB\u02B5\u02C0\u02B8\u02B2\u02B6\u02C0\u02C1\u02B2\u02B5\u02C1(this.folderPath, \u02BB\u02C0\u02BD\u02BF\u02BC\u02B9\u02B3\u02BC\u02B5\u02C1\u02C1);
			}
			return new \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6(this.folderPath, false);
		}
	}

	public void \u02C1\u02B3\u02BD\u02B4\u02BC\u02B4\u02BD\u02B9\u02B4\u02B2\u02BC(byte[] \u02B5\u02B2\u02BE\u02B9\u02B9\u02C1\u02BF\u02B5\u02BA\u02C0\u02B8)
	{
		SongHash songHash = this.checksum;
		this.checksum.ComputeHash(\u02B5\u02B2\u02BE\u02B9\u02B9\u02C1\u02BF\u02B5\u02BA\u02C0\u02B8);
		this.scores.\u02B7\u02C1\u02BF\u02B4\u02B8\u02B6\u02B3\u02B8\u02B2\u02BB\u02B2 = this.checksum;
	}

	public sbyte GHLGuitarIntensity
	{
		get
		{
			return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.GHLGuitar);
		}
	}

	private void \u02B2\u02BF\u02B7\u02BA\u02B5\u02BB\u02BA\u02C1\u02B3\u02BD\u02C0()
	{
		this.intensities = new sbyte[12];
		for (int i = 0; i < this.intensities.Length; i++)
		{
			this.intensities[i] = -1;
		}
	}

	public void \u02BF\u02B8\u02B4\u02BB\u02B8\u02C1\u02BE\u02C1\u02BB\u02BB\u02B8()
	{
		this.checksumStringCached = null;
	}

	public bool \u02B6\u02BB\u02BB\u02BD\u02BC\u02B2\u02B7\u02C0\u02BE\u02BD\u02B7(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C0\u02B8\u02C0\u02BB\u02C0\u02BF\u02BE\u02B5\u02B8)
	{
		\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC u02C0_u02B5_u02B3_u02B2_u02BA_u02BD_u02B5_u02C1_u02B9_u02BA_u02BC = this.scores.\u02BC\u02BB\u02B9\u02B5\u02B5\u02BB\u02B8\u02B9\u02B9\u02BC\u02BC(\u02BC\u02BC\u02C0\u02B8\u02C0\u02BB\u02C0\u02BF\u02BE\u02B5\u02B8.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
		this.scores.\u02BA\u02BB\u02C0\u02C1\u02B8\u02C0\u02B8\u02BB\u02C0\u02B8\u02B2(\u02BC\u02BC\u02C0\u02B8\u02C0\u02BB\u02C0\u02BF\u02BE\u02B5\u02B8);
		\u02BF\u02B2\u02BD\u02BF\u02B6\u02BE\u02BB\u02BE\u02BA\u02B8\u02BD.\u02B8\u02BE\u02B6\u02C1\u02B2\u02B2\u02B9\u02BC\u02BB\u02BA\u02B6();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B5\u02B2\u02B9\u02B3\u02B9\u02B7\u02BD\u02BD\u02BE\u02C0();
		return \u02BC\u02BC\u02C0\u02B8\u02C0\u02BB\u02C0\u02BF\u02BE\u02B5\u02B8.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 > u02C0_u02B5_u02B3_u02B2_u02BA_u02BD_u02B5_u02C1_u02B9_u02BA_u02BC.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
	}

	public string \u02B8\u02BA\u02BB\u02B3\u02BF\u02BE\u02C0\u02BE\u02B9\u02BF\u02BD()
	{
		if (this.isEnc)
		{
			return this.songEnc.\u02BF\u02C0\u02BA\u02B7\u02BC\u02BE\u02B3\u02C0\u02B9\u02B3\u02C1.\u02C0\u02B3\u02B4\u02BA\u02B5\u02B5\u02B8\u02B5\u02BD\u02C1\u02BC;
		}
		if (File.Exists(this.iniPath))
		{
			INIParser iniparser = new INIParser();
			iniparser.Open(this.iniPath);
			return iniparser.ReadValue("song", "loading_phrase", "");
		}
		return "";
	}

	public \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9 Name
	{
		get
		{
			return this.\u02C0\u02C0\u02B3\u02BC\u02BC\u02BB\u02C0\u02B4\u02BC\u02BB\u02BF(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Name);
		}
	}

	public \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 \u02BF\u02B2\u02B7\u02B9\u02BF\u02B3\u02BE\u02B3\u02B7\u02C0\u02BE()
	{
		this.isTypeCached = false;
		byte[] array;
		if (!this.isEnc)
		{
			SongHash songHash = default(SongHash);
			try
			{
				array = File.ReadAllBytes(this.chartPath);
				songHash.ComputeHash(array);
			}
			catch (Exception ex)
			{
				Debug.Log("Error loading chart! Exception: " + ex.Message);
				return null;
			}
			if (!songHash.Equals(this.checksum))
			{
				GlobalVariables.instance.\u02B6\u02B5\u02BE\u02C1\u02B9\u02B2\u02B4\u02B7\u02BA\u02C1\u02BA = true;
				Debug.Log(GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5 + " needs to be rescanned!");
			}
			goto IL_0092;
		}
		array = this.songEnc.\u02B6\u02C1\u02BE\u02B2\u02B9\u02B3\u02B8\u02BB\u02BD\u02B6\u02BA;
		IL_0092:
		if (this.isMIDIChart)
		{
			return \u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BB\u02B5\u02C0\u02B8\u02B2\u02B6\u02C0\u02C1\u02B2\u02B5\u02C1(array, false);
		}
		return new \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6(array, false);
	}

	public \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9 Artist
	{
		get
		{
			return this.\u02C0\u02C0\u02B3\u02BC\u02BC\u02BB\u02C0\u02B4\u02BC\u02BB\u02BF(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Artist);
		}
	}

	public bool \u02BF\u02C1\u02B6\u02B5\u02B6\u02B2\u02BD\u02B5\u02B2\u02C0\u02BA(string \u02B8\u02BD\u02B6\u02B5\u02C1\u02B3\u02B6\u02B2\u02BD\u02B5\u02B7)
	{
		bool flag;
		try
		{
			INIParser iniparser = new INIParser();
			using (MemoryStream memoryStream = new MemoryStream(\u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C1\u02B9\u02B7\u02BC\u02B4\u02BF\u02B6\u02B4\u02B9\u02BD\u02BD(\u02B8\u02BD\u02B6\u02B5\u02C1\u02B3\u02B6\u02B2\u02BD\u02B5\u02B7)))
			{
				using (StreamReader streamReader = new StreamReader(memoryStream))
				{
					iniparser.OpenFromString(streamReader.ReadToEnd());
				}
			}
			this.isTypeCached = false;
			if (iniparser.IsSectionExists("song"))
			{
				SongEntry.metadataCache[0] = iniparser.ReadValue("song", "name", "");
				SongEntry.metadataCache[1] = iniparser.ReadValue("song", "artist", "");
				SongEntry.metadataCache[2] = iniparser.ReadValue("song", "album", "");
				SongEntry.metadataCache[3] = iniparser.ReadValue("song", "genre", "");
				SongEntry.metadataCache[4] = iniparser.ReadValue("song", "year", "");
				this.intensities[8] = (sbyte)iniparser.ReadValue("song", "diff_band", -1);
				this.intensities[0] = (sbyte)iniparser.ReadValue("song", "diff_guitar", -1);
				this.intensities[2] = (sbyte)iniparser.ReadValue("song", "diff_rhythm", -1);
				this.intensities[3] = (sbyte)iniparser.ReadValue("song", "diff_guitar_coop", -1);
				this.intensities[1] = (sbyte)iniparser.ReadValue("song", "diff_bass", -1);
				this.intensities[6] = (sbyte)iniparser.ReadValue("song", "diff_drums", -1);
				this.intensities[9] = (sbyte)iniparser.ReadValue("song", "diff_drums_real", -1);
				this.intensities[7] = (sbyte)iniparser.ReadValue("song", "diff_keys", -1);
				this.intensities[4] = (sbyte)iniparser.ReadValue("song", "diff_guitarghl", -1);
				this.intensities[5] = (sbyte)iniparser.ReadValue("song", "diff_bassghl", -1);
				this.intensities[11] = (sbyte)iniparser.ReadValue("song", "diff_guitar_coop_ghl", -1);
				this.intensities[10] = (sbyte)iniparser.ReadValue("song", "diff_rhythm_ghl", -1);
				this.previewStart = iniparser.ReadValue("song", "preview_start_time", -1);
				this.iconName = iniparser.ReadValue("song", "icon", "").ToLowerInvariant();
				this.playlistTrack = (short)iniparser.ReadValue("song", "playlist_track", 16000);
				this.modchart = iniparser.ReadValue("song", "modchart", false);
				this.songLength = iniparser.ReadValue("song", "song_length", 0);
				this.forceProDrums = iniparser.ReadValue("song", "pro_drums", false);
				this.forceFiveLane = iniparser.ReadValue("song", "five_lane_drums", false);
				this.topLevelPlaylist = iniparser.ReadValue("song", "playlist", "").ToLowerInvariant();
				this.subPlaylist = iniparser.ReadValue("song", "sub_playlist", "").ToLowerInvariant();
				if (iniparser.IsKeyExists("song", "album_track"))
				{
					this.albumTrack = (short)iniparser.ReadValue("song", "album_track", 16000);
				}
				else
				{
					this.albumTrack = (short)iniparser.ReadValue("song", "track", 16000);
				}
				SongEntry.metadataCache[5] = iniparser.ReadValue("song", iniparser.IsKeyExists("song", "charter") ? "charter" : "frets", "");
				flag = true;
			}
			else
			{
				flag = false;
			}
		}
		catch
		{
			flag = false;
		}
		return flag;
	}

	public \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9 Charter
	{
		get
		{
			return this.\u02C0\u02C0\u02B3\u02BC\u02BC\u02BB\u02C0\u02B4\u02BC\u02BB\u02BF(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Charter);
		}
	}

	public sbyte GuitarIntensity
	{
		get
		{
			return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.Guitar);
		}
	}

	public \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9 \u02C0\u02C0\u02B3\u02BC\u02BC\u02BB\u02C0\u02B4\u02BC\u02BB\u02BF(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5)
	{
		return this.metadata[(int)\u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5];
	}

	public sbyte \u02BD\u02B6\u02BB\u02B4\u02BF\u02B5\u02B7\u02B4\u02B6\u02BF\u02BF()
	{
		return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.Guitar);
	}

	public string Charter_StrippedTags
	{
		get
		{
			return StringUtils.StripTags(this.Charter.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5, false);
		}
	}

	public void \u02C0\u02B3\u02B2\u02C1\u02B7\u02BB\u02BA\u02BF\u02B8\u02B5\u02B3(BinaryWriter \u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC)
	{
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.chartName);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.isEnc);
		foreach (\u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9 u02BB_u02BE_u02BC_u02B9_u02B3_u02B2_u02B6_u02B6_u02BB_u02BE_u02B in this.metadata)
		{
			\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(u02BB_u02BE_u02BC_u02B9_u02B3_u02B2_u02B6_u02B6_u02BB_u02BE_u02B.\u02BE\u02BF\u02BD\u02B2\u02C1\u02B6\u02B9\u02BB\u02B9\u02B4\u02C1);
		}
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.charts.\u02B2\u02C1\u02BC\u02C0\u02BA\u02B8\u02B2\u02B7\u02B2\u02B3\u02BB);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.lyrics);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.BandIntensity);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.GuitarIntensity);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.RhythmIntensity);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.GuitarCoopIntensity);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.BassIntensity);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.DrumsIntensity);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.ProDrumsIntensity);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.KeysIntensity);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.GHLGuitarIntensity);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.GHLBassIntensity);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.GHLGuitarCoopIntensity);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.GHLRhythmIntensity);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.previewStart);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.iconName);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.albumTrack);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.playlistTrack);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.modchart);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.videoBackground);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.forceProDrums);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.forceFiveLane);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.songLength);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.dateAdded.ToBinary());
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.topLevelPlaylist);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.subPlaylist);
		\u02BA\u02BB\u02C0\u02C0\u02BF\u02BE\u02B2\u02B3\u02B7\u02BB\u02BC.Write(this.checksum.ToArray());
	}

	public string Name_StrippedTags
	{
		get
		{
			return StringUtils.StripTags(this.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5, false);
		}
	}

	public sbyte GHLBassIntensity
	{
		get
		{
			return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.GHLBass);
		}
	}

	public \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9 \u02B9\u02BA\u02BE\u02BC\u02BB\u02B2\u02B2\u02B8\u02B8\u02BA\u02BB()
	{
		return this.\u02C0\u02C0\u02B3\u02BC\u02BC\u02BB\u02C0\u02B4\u02BC\u02BB\u02BF(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Artist);
	}

	public sbyte BassIntensity
	{
		get
		{
			return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.Bass);
		}
	}

	public void \u02BE\u02BB\u02B9\u02B6\u02C1\u02BA\u02B7\u02B8\u02B2\u02C0\u02C0(BinaryReader \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8)
	{
		this.chartName = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadString();
		this.isEnc = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadBoolean();
		this.metadata[0] = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B7\u02BD\u02B4\u02C1\u02B3\u02BC\u02BA\u02B4\u02B3\u02C1(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Name, \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt32());
		this.metadata[1] = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B7\u02BD\u02B4\u02C1\u02B3\u02BC\u02BA\u02B4\u02B3\u02C1(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Artist, \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt32());
		this.metadata[2] = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B7\u02BD\u02B4\u02C1\u02B3\u02BC\u02BA\u02B4\u02B3\u02C1(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Album, \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt32());
		this.metadata[3] = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B7\u02BD\u02B4\u02C1\u02B3\u02BC\u02BA\u02B4\u02B3\u02C1(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Genre, \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt32());
		this.metadata[4] = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B7\u02BD\u02B4\u02C1\u02B3\u02BC\u02BA\u02B4\u02B3\u02C1(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Year, \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt32());
		this.metadata[5] = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B7\u02BD\u02B4\u02C1\u02B3\u02BC\u02BA\u02B4\u02B3\u02C1(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Charter, \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt32());
		this.metadata[6] = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B7\u02BD\u02B4\u02C1\u02B3\u02BC\u02BA\u02B4\u02B3\u02C1(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Playlist, \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt32());
		this.charts.\u02B2\u02C1\u02BC\u02C0\u02BA\u02B8\u02B2\u02B7\u02B2\u02B3\u02BB = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt64();
		this.lyrics = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadBoolean();
		this.intensities[8] = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadSByte();
		this.intensities[0] = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadSByte();
		this.intensities[2] = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadSByte();
		this.intensities[3] = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadSByte();
		this.intensities[1] = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadSByte();
		this.intensities[6] = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadSByte();
		this.intensities[9] = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadSByte();
		this.intensities[7] = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadSByte();
		this.intensities[4] = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadSByte();
		this.intensities[5] = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadSByte();
		this.intensities[11] = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadSByte();
		this.intensities[10] = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadSByte();
		this.previewStart = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt32();
		this.iconName = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadString();
		this.albumTrack = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt16();
		this.playlistTrack = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt16();
		this.modchart = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadBoolean();
		this.videoBackground = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadBoolean();
		this.forceProDrums = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadBoolean();
		this.forceFiveLane = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadBoolean();
		this.songLength = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt32();
		this.dateAdded = DateTime.FromBinary(\u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadInt64());
		this.topLevelPlaylist = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadString();
		this.subPlaylist = \u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadString();
		this.\u02BA\u02BE\u02BE\u02B6\u02B3\u02BA\u02B4\u02C0\u02BC\u02BD\u02BE(\u02C0\u02B8\u02B4\u02BF\u02BB\u02B9\u02BC\u02B7\u02B2\u02C0\u02B8.ReadBytes(16));
	}

	public sbyte BandIntensity
	{
		get
		{
			return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.Band);
		}
	}

	public sbyte ProDrumsIntensity
	{
		get
		{
			return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.ProDrums);
		}
	}

	public ushort \u02C0\u02B5\u02B6\u02BC\u02B2\u02B7\u02B3\u02BB\u02C1\u02BB\u02B3()
	{
		return this.scores.\u02B9\u02B2\u02B7\u02B5\u02B2\u02BF\u02B4\u02B2\u02BF\u02BF\u02BD;
	}

	public string chartPath
	{
		get
		{
			if (!this.isEnc)
			{
				return Path.Combine(this.folderPath, this.chartName);
			}
			return this.folderPath;
		}
	}

	public void \u02B9\u02BC\u02C1\u02BC\u02B8\u02B5\u02BD\u02BE\u02B5\u02B4\u02BD()
	{
		this.metadata = new \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9[7];
		if (this.topLevelPlaylist == "")
		{
			this.\u02B7\u02BE\u02C1\u02BC\u02B2\u02BF\u02BE\u02BB\u02B4\u02B9\u02C0();
			string text = SongEntry.metadataCache[6];
			if (text != null)
			{
				if (text.IndexOf("\\") == -1)
				{
					this.topLevelPlaylist = text;
				}
				else
				{
					this.topLevelPlaylist = text.Substring(0, text.IndexOf("\\"));
				}
			}
			this.subPlaylist = "";
		}
		else
		{
			SongEntry.metadataCache[6] = this.topLevelPlaylist + ((this.subPlaylist != "") ? ("\\" + this.subPlaylist) : "");
		}
		for (int i = 0; i < 7; i++)
		{
			this.metadata[i] = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B7\u02BD\u02B4\u02C1\u02B3\u02BC\u02BA\u02B4\u02B3\u02C1((\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC)i, SongEntry.metadataCache[i]);
		}
	}

	public void \u02BA\u02BE\u02BE\u02B6\u02B3\u02BA\u02B4\u02C0\u02BC\u02BD\u02BE(byte[] \u02B7\u02C1\u02BF\u02B4\u02B8\u02B6\u02B3\u02B8\u02B2\u02BB\u02B2)
	{
		SongHash songHash = this.checksum;
		this.checksum.SetData(\u02B7\u02C1\u02BF\u02B4\u02B8\u02B6\u02B3\u02B8\u02B2\u02BB\u02B2);
		this.scores.\u02B7\u02C1\u02BF\u02B4\u02B8\u02B6\u02B3\u02B8\u02B2\u02BB\u02B2 = this.checksum;
	}

	public ushort playCount
	{
		get
		{
			return this.scores.\u02B9\u02B2\u02B7\u02B5\u02B2\u02BF\u02B4\u02B2\u02BF\u02BF\u02BD;
		}
	}

	private void \u02B7\u02BE\u02C1\u02BC\u02B2\u02BF\u02BE\u02BB\u02B4\u02B9\u02C0()
	{
		SongEntry.metadataCache[6] = null;
		if (this.isEnc)
		{
			SongEntry.metadataCache[6] = "Clone Hero";
			return;
		}
		foreach (string text in GlobalVariables.instance.\u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9)
		{
			if (this.folderPath.StartsWith(text))
			{
				string text2 = this.folderPath;
				if (text2[text2.Length - 1] == Path.DirectorySeparatorChar)
				{
					text2 = text2.Remove(text2.Length - 1, 1);
				}
				text2 = text2.Remove(0, text.Length);
				int num = -1;
				if (text2.Length > 0)
				{
					text2 = text2.Remove(0, 1);
					num = text2.LastIndexOf(Path.DirectorySeparatorChar);
				}
				SongEntry.metadataCache[6] = ((num == -1) ? string.Empty : text2.Remove(num));
				break;
			}
		}
	}

	public sbyte DrumsIntensity
	{
		get
		{
			return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.Drums);
		}
	}

	public \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9 \u02B2\u02BB\u02BF\u02B7\u02BE\u02C0\u02B5\u02BE\u02BF\u02B9\u02B4()
	{
		return this.\u02C0\u02C0\u02B3\u02BC\u02BC\u02BB\u02C0\u02B4\u02BC\u02BB\u02BF(\u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC.Name);
	}

	public sbyte RhythmIntensity
	{
		get
		{
			return this.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(Instrument.Rhythm);
		}
	}

	[NonSerialized]
	public \u02B7\u02B8\u02BE\u02B3\u02C1\u02C0\u02B3\u02B5\u02BB\u02BA\u02BE songEnc;

	[NonSerialized]
	public \u02B5\u02B4\u02BD\u02BE\u02B5\u02BA\u02BA\u02B5\u02B2\u02B9\u02B3 charts;

	[NonSerialized]
	public string iconName = "";

	[NonSerialized]
	public string folderPath;

	[NonSerialized]
	public SongHash checksum;

	private string checksumStringCached;

	private static Dictionary<string, \u02B7\u02B8\u02BE\u02B3\u02C1\u02C0\u02B3\u02B5\u02BB\u02BA\u02BE> containers = new Dictionary<string, \u02B7\u02B8\u02BE\u02B3\u02C1\u02C0\u02B3\u02B5\u02BB\u02BA\u02BE>();

	[NonSerialized]
	public short playlistTrack;

	[NonSerialized]
	public short albumTrack;

	[NonSerialized]
	public int previewStart;

	private bool isMidiChartCache;

	private bool isTypeCached;

	[NonSerialized]
	public \u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0 scores = new \u02BD\u02B5\u02B3\u02B2\u02BA\u02C0\u02C0\u02B7\u02B5\u02B8\u02C0();

	[NonSerialized]
	public DateTime dateAdded;

	[NonSerialized]
	public bool videoBackground;

	[NonSerialized]
	public bool isAvailableOnline = true;

	public string chartName;

	public int songLength;

	private \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9[] metadata;

	private static string[] metadataCache = new string[7];

	public bool lyrics;

	public bool modchart;

	public bool forceProDrums;

	public bool forceFiveLane;

	public string topLevelPlaylist = "";

	public string subPlaylist = "";

	private sbyte[] intensities;

	private const int INTENSITY_COUNT = 12;

	[NonSerialized]
	public bool metadataLoaded;

	public bool filtered;

	public bool isEnc;
}
