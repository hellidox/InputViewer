﻿using System;
using System.Collections.Generic;
using System.Text;

public static class \u02B9\u02B5\u02C1\u02BE\u02B8\u02C0\u02BB\u02BE\u02C1\u02BC\u02B7
{
	public static string \u02BE\u02B2\u02B6\u02C1\u02B9\u02B5\u02B6\u02B7\u02B7\u02BF\u02BE(char \u02BD\u02BC\u02B4\u02C0\u02B6\u02C1\u02BC\u02B3\u02B3\u02B5\u02B9, string \u02BB\u02C1\u02B5\u02BE\u02B3\u02BB\u02BD\u02B9\u02B6\u02BF\u02BA = null)
	{
		return \u02B9\u02B5\u02C1\u02BE\u02B8\u02C0\u02BB\u02BE\u02C1\u02BC\u02B7.\u02BE\u02B2\u02B6\u02C1\u02B9\u02B5\u02B6\u02B7\u02B7\u02BF\u02BE(new string[] { \u02BD\u02BC\u02B4\u02C0\u02B6\u02C1\u02BC\u02B3\u02B3\u02B5\u02B9.ToString() }, \u02BB\u02C1\u02B5\u02BE\u02B3\u02BB\u02BD\u02B9\u02B6\u02BF\u02BA);
	}

	public static string \u02BE\u02B2\u02B6\u02C1\u02B9\u02B5\u02B6\u02B7\u02B7\u02BF\u02BE(string \u02BD\u02BC\u02B4\u02C0\u02B6\u02C1\u02BC\u02B3\u02B3\u02B5\u02B9, string \u02BB\u02C1\u02B5\u02BE\u02B3\u02BB\u02BD\u02B9\u02B6\u02BF\u02BA = null)
	{
		return \u02B9\u02B5\u02C1\u02BE\u02B8\u02C0\u02BB\u02BE\u02C1\u02BC\u02B7.\u02BE\u02B2\u02B6\u02C1\u02B9\u02B5\u02B6\u02B7\u02B7\u02BF\u02BE(new string[] { \u02BD\u02BC\u02B4\u02C0\u02B6\u02C1\u02BC\u02B3\u02B3\u02B5\u02B9 }, \u02BB\u02C1\u02B5\u02BE\u02B3\u02BB\u02BD\u02B9\u02B6\u02BF\u02BA);
	}

	public static string \u02BE\u02B2\u02B6\u02C1\u02B9\u02B5\u02B6\u02B7\u02B7\u02BF\u02BE(IEnumerable<object> \u02B5\u02BC\u02C0\u02BC\u02BE\u02B3\u02BB\u02BA\u02BE\u02B7\u02C1, string \u02BB\u02C1\u02B5\u02BE\u02B3\u02BB\u02BD\u02B9\u02B6\u02BF\u02BA = null)
	{
		return new StringBuilder().\u02BB\u02BD\u02B8\u02B9\u02B4\u02BA\u02BC\u02BE\u02BB\u02B6\u02BF(\u02B5\u02BC\u02C0\u02BC\u02BE\u02B3\u02BB\u02BA\u02BE\u02B7\u02C1, \u02BB\u02C1\u02B5\u02BE\u02B3\u02BB\u02BD\u02B9\u02B6\u02BF\u02BA).ToString();
	}

	public static StringBuilder \u02BB\u02BD\u02B8\u02B9\u02B4\u02BA\u02BC\u02BE\u02BB\u02B6\u02BF(this StringBuilder \u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6, IEnumerable<object> \u02B5\u02BC\u02C0\u02BC\u02BE\u02B3\u02BB\u02BA\u02BE\u02B7\u02C1, string \u02BB\u02C1\u02B5\u02BE\u02B3\u02BB\u02BD\u02B9\u02B6\u02BF\u02BA = null)
	{
		\u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6 = \u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6 ?? new StringBuilder();
		IEnumerator<object> enumerator = \u02B5\u02BC\u02C0\u02BC\u02BE\u02B3\u02BB\u02BA\u02BE\u02B7\u02C1.GetEnumerator();
		\u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6.Append('(');
		if (\u02BB\u02C1\u02B5\u02BE\u02B3\u02BB\u02BD\u02B9\u02B6\u02BF\u02BA != null)
		{
			\u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6.Append("?<").Append(\u02BB\u02C1\u02B5\u02BE\u02B3\u02BB\u02BD\u02B9\u02B6\u02BF\u02BA).Append('>');
		}
		if (enumerator.MoveNext())
		{
			\u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6.Append(enumerator.Current.ToString());
		}
		while (enumerator.MoveNext())
		{
			\u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6.Append('|');
			\u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6.Append(enumerator.Current.ToString());
		}
		\u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6.Append(')');
		return \u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6;
	}
}
