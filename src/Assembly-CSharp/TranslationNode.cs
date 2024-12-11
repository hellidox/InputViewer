﻿using System;
using System.Collections.Generic;

public class TranslationNode
{
	public Dictionary<\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC, Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string>> \u02B5\u02B8\u02BB\u02BC\u02B4\u02B2\u02B8\u02B8\u02B8\u02B6\u02BB()
	{
		if (this.\u02BF\u02C0\u02BA\u02B4\u02B4\u02B6\u02B2\u02BE\u02B6\u02B8\u02C1 == null)
		{
			this.\u02BF\u02C0\u02BA\u02B4\u02B4\u02B6\u02B2\u02BE\u02B6\u02B8\u02C1 = new Dictionary<\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC, Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string>>();
		}
		return this.\u02BF\u02C0\u02BA\u02B4\u02B4\u02B6\u02B2\u02BE\u02B6\u02B8\u02C1;
	}

	public Dictionary<\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC, Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string>> Resources
	{
		get
		{
			if (this.\u02BF\u02C0\u02BA\u02B4\u02B4\u02B6\u02B2\u02BE\u02B6\u02B8\u02C1 == null)
			{
				this.\u02BF\u02C0\u02BA\u02B4\u02B4\u02B6\u02B2\u02BE\u02B6\u02B8\u02C1 = new Dictionary<\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC, Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string>>();
			}
			return this.\u02BF\u02C0\u02BA\u02B4\u02B4\u02B6\u02B2\u02BE\u02B6\u02B8\u02C1;
		}
		set
		{
			this.\u02BF\u02C0\u02BA\u02B4\u02B4\u02B6\u02B2\u02BE\u02B6\u02B8\u02C1 = value;
		}
	}

	public Dictionary<\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC, TranslationNode> \u02B4\u02B4\u02B9\u02BC\u02BE\u02BB\u02BB\u02B9\u02B9\u02B9\u02BE
	{
		get
		{
			if (this.\u02BD\u02BA\u02B6\u02BA\u02B6\u02B4\u02BE\u02C0\u02C1\u02BC\u02BF == null)
			{
				this.\u02BD\u02BA\u02B6\u02BA\u02B6\u02B4\u02BE\u02C0\u02C1\u02BC\u02BF = new Dictionary<\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC, TranslationNode>();
			}
			return this.\u02BD\u02BA\u02B6\u02BA\u02B6\u02B4\u02BE\u02C0\u02C1\u02BC\u02BF;
		}
	}

	private Dictionary<\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC, TranslationNode> \u02BD\u02BA\u02B6\u02BA\u02B6\u02B4\u02BE\u02C0\u02C1\u02BC\u02BF;

	private Dictionary<\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC, Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string>> \u02BF\u02C0\u02BA\u02B4\u02B4\u02B6\u02B2\u02BE\u02B6\u02B8\u02C1;
}
