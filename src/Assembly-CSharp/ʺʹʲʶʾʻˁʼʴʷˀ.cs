﻿using System;
using StrikeCore;

public class \u02BA\u02B9\u02B2\u02B6\u02BE\u02BB\u02C1\u02BC\u02B4\u02B7\u02C0 : \u02BB\u02BE\u02BC\u02B9\u02B3\u02B2\u02B6\u02B6\u02BB\u02BE\u02B9
{
	public override string \u02BF\u02B7\u02C1\u02B5\u02BE\u02B7\u02BC\u02C1\u02BA\u02BE\u02B9
	{
		get
		{
			if (!string.IsNullOrEmpty(base.\u02BF\u02BB\u02B8\u02BB\u02B2\u02B7\u02B4\u02C1\u02C1\u02B8\u02B4))
			{
				return base.\u02BF\u02BB\u02B8\u02BB\u02B2\u02B7\u02B4\u02C1\u02C1\u02B8\u02B4;
			}
			return "Unknown Year";
		}
	}

	public \u02BA\u02B9\u02B2\u02B6\u02BE\u02BB\u02C1\u02BC\u02B4\u02B7\u02C0(string \u02B2\u02BA\u02C1\u02BD\u02C1\u02BA\u02B7\u02B5\u02BE\u02BE\u02BA, int \u02B7\u02B9\u02B2\u02B5\u02B8\u02B3\u02B6\u02B8\u02C1\u02B3\u02B3, \u02B5\u02B7\u02B7\u02B8\u02B4\u02B3\u02B3\u02B4\u02BF\u02C1\u02BC \u02B3\u02C1\u02B6\u02BA\u02B6\u02C1\u02B7\u02BD\u02C1\u02BF\u02B5)
		: base(\u02B2\u02BA\u02C1\u02BD\u02C1\u02BA\u02B7\u02B5\u02BE\u02BE\u02BA, \u02B7\u02B9\u02B2\u02B5\u02B8\u02B3\u02B6\u02B8\u02C1\u02B3\u02B3, \u02B3\u02C1\u02B6\u02BA\u02B6\u02C1\u02B7\u02BD\u02C1\u02BF\u02B5)
	{
	}

	protected override void \u02C1\u02B9\u02C0\u02BA\u02B9\u02BB\u02BE\u02B2\u02B9\u02B5\u02B3()
	{
		base.\u02BB\u02B5\u02B5\u02B8\u02B4\u02BD\u02B9\u02B2\u02B3\u02BF\u02B6 = StringUtils.StripTags(base.\u02B2\u02B7\u02B5\u02B3\u02BC\u02BE\u02C0\u02B3\u02BA\u02BA\u02B3, false);
		base.\u02BF\u02BB\u02B8\u02BB\u02B2\u02B7\u02B4\u02C1\u02C1\u02B8\u02B4 = StringUtils.ExtractYear(base.\u02BB\u02B5\u02B5\u02B8\u02B4\u02BD\u02B9\u02B2\u02B3\u02BF\u02B6);
	}
}
