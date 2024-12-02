﻿using System;
using System.Collections.Generic;
using System.IO;
using IniParser;
using IniParser.Model;
using UnityEngine;

public class \u02BB\u02BE\u02C0\u02BE\u02BB\u02BB\u02BA\u02B4\u02B3\u02BC\u02BF : \u02BE\u02B6\u02BA\u02B3\u02BB\u02B9\u02B3\u02B2\u02B4\u02C1\u02B4
{
	private bool \u02BC\u02B8\u02C1\u02BD\u02B5\u02B3\u02BB\u02C0\u02B4\u02B5\u02B9(Stream \u02C1\u02BB\u02BE\u02B6\u02BA\u02BC\u02B9\u02B2\u02B3\u02B5\u02B2, out IDictionary<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7> \u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC)
	{
		bool flag2;
		using (StreamReader streamReader = new StreamReader(\u02C1\u02BB\u02BE\u02B6\u02BA\u02BC\u02B9\u02B2\u02B3\u02B5\u02B2))
		{
			bool flag = false;
			Dictionary<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7> dictionary = new Dictionary<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7>();
			foreach (SectionData sectionData in new FileIniDataParser().ReadData(streamReader).Sections)
			{
				KeyDataCollection keys = sectionData.Keys;
				Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
				foreach (KeyData keyData in keys)
				{
					dictionary2.Add(keyData.KeyName, keyData.Value);
				}
				dictionary.Add(sectionData.SectionName, new \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7
				{
					\u02BB\u02BA\u02BF\u02B9\u02B9\u02BA\u02B7\u02B5\u02B6\u02BD\u02BF = sectionData.SectionName,
					\u02C1\u02B6\u02B3\u02BD\u02B4\u02BC\u02BA\u02B3\u02B5\u02B5\u02C0 = dictionary2
				});
			}
			\u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC = dictionary;
			flag2 = flag;
		}
		return flag2;
	}

	public bool \u02BC\u02B8\u02C1\u02BD\u02B5\u02B3\u02BB\u02C0\u02B4\u02B5\u02B9(out IDictionary<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7> \u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC)
	{
		if (File.Exists(this.\u02B7\u02B2\u02B2\u02BB\u02BB\u02B4\u02B6\u02B3\u02C1\u02BF\u02BC))
		{
			using (FileStream fileStream = File.OpenRead(this.\u02B7\u02B2\u02B2\u02BB\u02BB\u02B4\u02B6\u02B3\u02C1\u02BF\u02BC))
			{
				return this.\u02BC\u02B8\u02C1\u02BD\u02B5\u02B3\u02BB\u02C0\u02B4\u02B5\u02B9(fileStream, out \u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC);
			}
		}
		TextAsset textAsset = Resources.Load<TextAsset>(this.\u02BF\u02BC\u02B8\u02BB\u02B9\u02BA\u02BB\u02B5\u02BE\u02B9\u02B3);
		return this.\u02BC\u02B8\u02C1\u02BD\u02B5\u02B3\u02BB\u02C0\u02B4\u02B5\u02B9(textAsset.text, out \u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC);
	}

	public string \u02BF\u02BC\u02B8\u02BB\u02B9\u02BA\u02BB\u02B5\u02BE\u02B9\u02B3
	{
		get
		{
			return this.\u02C0\u02C0\u02C0\u02BE\u02B3\u02B7\u02B9\u02BA\u02C0\u02B6\u02B6;
		}
	}

	public string \u02B7\u02B2\u02B2\u02BB\u02BB\u02B4\u02B6\u02B3\u02C1\u02BF\u02BC
	{
		get
		{
			return this.\u02C0\u02B7\u02B7\u02B4\u02BD\u02B2\u02BD\u02B3\u02BF\u02B4\u02B7;
		}
	}

	public \u02BB\u02BE\u02C0\u02BE\u02BB\u02BB\u02BA\u02B4\u02B3\u02BC\u02BF(string \u02C0\u02B7\u02B4\u02BA\u02B9\u02C1\u02B6\u02B9\u02BA\u02B7\u02BE, string \u02B7\u02BF\u02C0\u02B9\u02B4\u02B6\u02BE\u02B5\u02B2\u02BE\u02B3)
	{
		this.\u02C0\u02C0\u02C0\u02BE\u02B3\u02B7\u02B9\u02BA\u02C0\u02B6\u02B6 = \u02B7\u02BF\u02C0\u02B9\u02B4\u02B6\u02BE\u02B5\u02B2\u02BE\u02B3;
		this.\u02C0\u02B7\u02B7\u02B4\u02BD\u02B2\u02BD\u02B3\u02BF\u02B4\u02B7 = \u02C0\u02B7\u02B4\u02BA\u02B9\u02C1\u02B6\u02B9\u02BA\u02B7\u02BE;
	}

	private bool \u02BC\u02B8\u02C1\u02BD\u02B5\u02B3\u02BB\u02C0\u02B4\u02B5\u02B9(string \u02C0\u02BB\u02BE\u02BE\u02C0\u02B4\u02B3\u02BB\u02B6\u02BA\u02BF, out IDictionary<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7> \u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC)
	{
		bool flag;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (StreamWriter streamWriter = new StreamWriter(memoryStream))
			{
				streamWriter.Write(\u02C0\u02BB\u02BE\u02BE\u02C0\u02B4\u02B3\u02BB\u02B6\u02BA\u02BF);
				streamWriter.Flush();
				memoryStream.Position = 0L;
				flag = this.\u02BC\u02B8\u02C1\u02BD\u02B5\u02B3\u02BB\u02C0\u02B4\u02B5\u02B9(memoryStream, out \u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC);
			}
		}
		return flag;
	}

	private string \u02C0\u02B7\u02B7\u02B4\u02BD\u02B2\u02BD\u02B3\u02BF\u02B4\u02B7;

	private string \u02C0\u02C0\u02C0\u02BE\u02B3\u02B7\u02B9\u02BA\u02C0\u02B6\u02B6;
}
