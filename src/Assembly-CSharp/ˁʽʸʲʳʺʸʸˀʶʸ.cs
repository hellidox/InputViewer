﻿using System;
using System.Collections.Generic;
using System.IO;

public class \u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8
{
	public void \u02B9\u02BD\u02B9\u02BE\u02BD\u02C1\u02BC\u02BA\u02B7\u02B7\u02B7()
	{
		if (SettingsController.full_playlist)
		{
			return;
		}
		int num = this.\u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD.LastIndexOf(Path.DirectorySeparatorChar);
		if (num != -1)
		{
			this.\u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD = this.\u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD.Remove(0, num + 1);
		}
	}

	public string \u02B8\u02BD\u02B5\u02BB\u02BC\u02B7\u02BE\u02C0\u02BD\u02BA\u02B5()
	{
		return this.<\u02BA\u02BA\u02B2\u02B9\u02B6\u02B9\u02BC\u02B6\u02B9\u02BB\u02BE>k__BackingField;
	}

	public \u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		this.\u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD = \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;
		this.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5 = new List<SongEntry>();
	}

	public string \u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD { get; set; }

	public int \u02BB\u02BD\u02B2\u02BE\u02B2\u02B8\u02B2\u02B4\u02B4\u02B3\u02C1
	{
		get
		{
			return this.\u02B7\u02BD\u02B4\u02C0\u02B9\u02B3\u02BA\u02B7\u02B2\u02BE\u02B3 + (this.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE ? 0 : this.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count);
		}
	}

	public int \u02B8\u02BB\u02B2\u02BA\u02B9\u02B4\u02B6\u02B6\u02B6\u02B2\u02B6()
	{
		this.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE = !this.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE;
		if (!this.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE)
		{
			return this.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count;
		}
		return -this.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count;
	}

	public List<SongEntry> \u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5;

	public bool \u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE;

	public int \u02B7\u02BD\u02B4\u02C0\u02B9\u02B3\u02BA\u02B7\u02B2\u02BE\u02B3;
}
