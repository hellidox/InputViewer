﻿using System;
using System.Security.Cryptography;

public static class \u02C1\u02B2\u02B8\u02B9\u02C0\u02BC\u02B9\u02B9\u02B6\u02B2\u02B3
{
	public static string \u02B6\u02B3\u02BD\u02BB\u02BE\u02B7\u02BF\u02BC\u02B2\u02BE\u02B8(byte[] \u02B7\u02C1\u02BF\u02B4\u02B8\u02B6\u02B3\u02B8\u02B2\u02BB\u02B2)
	{
		string text = "";
		foreach (byte b in \u02B7\u02C1\u02BF\u02B4\u02B8\u02B6\u02B3\u02B8\u02B2\u02BB\u02B2)
		{
			text += string.Format("{0:X2}", b);
		}
		return text;
	}

	private static SHA512 \u02BA\u02BE\u02BB\u02BF\u02C0\u02BE\u02B2\u02B4\u02C1\u02B5\u02BE = SHA512.Create();
}
