﻿using System;
using System.IO;
using UnityEngine;

public class LanguageManager
{
	public bool \u02B3\u02B8\u02BF\u02C0\u02C0\u02BC\u02BD\u02B5\u02B5\u02B6\u02B5()
	{
		return this.\u02BE\u02BF\u02B8\u02B3\u02B8\u02B3\u02B7\u02B9\u02B7\u02B5\u02BA.\u02B7\u02BD\u02B9\u02BF\u02B5\u02B2\u02BA\u02B7\u02BF\u02BE\u02BE();
	}

	public string \u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5 { get; private set; }

	public static LanguageManager \u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2()
	{
		if (LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9 == null)
		{
			LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9 = new LanguageManager();
		}
		return LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9;
	}

	public static LanguageManager \u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9()
	{
		if (LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9 == null)
		{
			LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9 = new LanguageManager();
		}
		return LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9;
	}

	public string \u02B7\u02C1\u02BB\u02BF\u02BB\u02B2\u02C1\u02B8\u02BD\u02B5\u02C0()
	{
		return this.<\u02BD\u02BA\u02B9\u02B5\u02B2\u02B3\u02BD\u02BE\u02B2\u02B5\u02B6>k__BackingField;
	}

	public bool \u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6
	{
		get
		{
			return this.\u02BE\u02BF\u02B8\u02B3\u02B8\u02B3\u02B7\u02B9\u02B7\u02B5\u02BA.\u02BF\u02BF\u02B3\u02B5\u02BE\u02BD\u02BE\u02B5\u02C0\u02B4\u02B3;
		}
	}

	public string \u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(string \u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB)
	{
		return this.LocalizationResourceManager.\u02B2\u02B5\u02C1\u02B4\u02C0\u02B4\u02BE\u02BE\u02B6\u02BE\u02B7(\u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB, null);
	}

	public string \u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(string \u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB)
	{
		return this.\u02B3\u02B8\u02B4\u02B2\u02B3\u02C1\u02B5\u02B5\u02B8\u02B8\u02B5().\u02B2\u02B5\u02C1\u02B4\u02C0\u02B4\u02BE\u02BE\u02B6\u02BE\u02B7(\u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB, null);
	}

	public bool \u02BC\u02BD\u02C1\u02B9\u02C0\u02BB\u02B8\u02BA\u02BD\u02B2\u02BD()
	{
		return this.\u02BE\u02BF\u02B8\u02B3\u02B8\u02B3\u02B7\u02B9\u02B7\u02B5\u02BA.\u02B6\u02BE\u02C0\u02B3\u02C1\u02B8\u02BE\u02B9\u02BD\u02BE\u02BF();
	}

	public LocalizationResourceManager LocalizationResourceManager
	{
		get
		{
			if (this.\u02BE\u02BF\u02B8\u02B3\u02B8\u02B3\u02B7\u02B9\u02B7\u02B5\u02BA == null)
			{
				this.\u02BE\u02BF\u02B8\u02B3\u02B8\u02B3\u02B7\u02B9\u02B7\u02B5\u02BA = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
			}
			return this.\u02BE\u02BF\u02B8\u02B3\u02B8\u02B3\u02B7\u02B9\u02B7\u02B5\u02BA;
		}
	}

	public string \u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(string \u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB)
	{
		return this.LocalizationResourceManager.GetResource(\u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB, null);
	}

	public static LanguageManager \u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8()
	{
		if (LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9 == null)
		{
			LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9 = new LanguageManager();
		}
		return LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9;
	}

	public void \u02B8\u02C0\u02B9\u02B9\u02B4\u02B7\u02BD\u02BE\u02B7\u02BC\u02B2(string \u02B7\u02C1\u02BB\u02C0\u02B6\u02C0\u02B2\u02C1\u02C0\u02B9\u02C0)
	{
		string text;
		if (!this.LocalizationResourceManager.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.TryGetValue(\u02B7\u02C1\u02BB\u02C0\u02B6\u02C0\u02B2\u02C1\u02C0\u02B9\u02C0, out text))
		{
			text = "en";
		}
		this.\u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5 = \u02B7\u02C1\u02BB\u02C0\u02B6\u02C0\u02B2\u02C1\u02C0\u02B9\u02C0;
		string text2 = Path.Combine(Application.persistentDataPath, "languages", text + ".yaml");
		this.LocalizationResourceManager.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text2, text, text, null, false);
	}

	public string \u02BD\u02C0\u02B2\u02BD\u02B8\u02B6\u02B3\u02C1\u02BE\u02B8\u02BF()
	{
		return this.<\u02BD\u02BA\u02B9\u02B5\u02B2\u02B3\u02BD\u02BE\u02B2\u02B5\u02B6>k__BackingField;
	}

	public LocalizationResourceManager \u02B3\u02B8\u02B4\u02B2\u02B3\u02C1\u02B5\u02B5\u02B8\u02B8\u02B5()
	{
		if (this.\u02BE\u02BF\u02B8\u02B3\u02B8\u02B3\u02B7\u02B9\u02B7\u02B5\u02BA == null)
		{
			this.\u02BE\u02BF\u02B8\u02B3\u02B8\u02B3\u02B7\u02B9\u02B7\u02B5\u02BA = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		}
		return this.\u02BE\u02BF\u02B8\u02B3\u02B8\u02B3\u02B7\u02B9\u02B7\u02B5\u02BA;
	}

	public static LanguageManager instance
	{
		get
		{
			if (LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9 == null)
			{
				LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9 = new LanguageManager();
			}
			return LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9;
		}
	}

	public string GetString(string \u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB)
	{
		return this.LocalizationResourceManager.GetResource(\u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB, null);
	}

	public static LanguageManager \u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE()
	{
		if (LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9 == null)
		{
			LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9 = new LanguageManager();
		}
		return LanguageManager.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9;
	}

	private static LanguageManager \u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9;

	private readonly string \u02B2\u02BE\u02BC\u02B5\u02BB\u02B8\u02B2\u02B7\u02BB\u02B5\u02B9 = "Languages/";

	private LocalizationResourceManager \u02BE\u02BF\u02B8\u02B3\u02B8\u02B3\u02B7\u02B9\u02B7\u02B5\u02BA;
}
