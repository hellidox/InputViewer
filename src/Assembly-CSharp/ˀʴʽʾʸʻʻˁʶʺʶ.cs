﻿using System;

public static class \u02C0\u02B4\u02BD\u02BE\u02B8\u02BB\u02BB\u02C1\u02B6\u02BA\u02B6
{
	static \u02C0\u02B4\u02BD\u02BE\u02B8\u02BB\u02BB\u02C1\u02B6\u02BA\u02B6()
	{
		if (\u02C0\u02B4\u02BD\u02BE\u02B8\u02BB\u02BB\u02C1\u02B6\u02BA\u02B6.\u02BF\u02B8\u02B4\u02B2\u02BF\u02B8\u02B9\u02C1\u02B7\u02B9\u02B9 == 0UL)
		{
			if (\u02C0\u02B4\u02BD\u02BE\u02B8\u02BB\u02BB\u02C1\u02B6\u02BA\u02B6.\u02B9\u02BC\u02BC\u02C0\u02B7\u02BD\u02B5\u02B9\u02B6\u02B6\u02BC == null)
			{
				\u02C0\u02B4\u02BD\u02BE\u02B8\u02BB\u02BB\u02C1\u02B6\u02BA\u02B6.\u02B9\u02BC\u02BC\u02C0\u02B7\u02BD\u02B5\u02B9\u02B6\u02B6\u02BC = new \u02C0\u02B8\u02BC\u02BB\u02BD\u02BA\u02B9\u02C1\u02BF\u02BC\u02B5();
			}
			\u02C0\u02B4\u02BD\u02BE\u02B8\u02BB\u02BB\u02C1\u02B6\u02BA\u02B6.\u02BF\u02B8\u02B4\u02B2\u02BF\u02B8\u02B9\u02C1\u02B7\u02B9\u02B9 = \u02C0\u02B4\u02BD\u02BE\u02B8\u02BB\u02BB\u02C1\u02B6\u02BA\u02B6.\u02B9\u02BC\u02BC\u02C0\u02B7\u02BD\u02B5\u02B9\u02B6\u02B6\u02BC.\u02B2\u02BF\u02BF\u02BF\u02B3\u02B9\u02B4\u02BA\u02BC\u02B7\u02C1() & 137438953471UL;
		}
	}

	public static ulong \u02B7\u02B9\u02B4\u02B3\u02BE\u02B9\u02B3\u02BC\u02C1\u02B4\u02B5(ulong \u02BF\u02B6\u02BD\u02BC\u02C0\u02BD\u02B6\u02BC\u02B2\u02B7\u02B5, ulong \u02B9\u02BC\u02BC\u02C0\u02B7\u02BD\u02B5\u02B9\u02B6\u02B6\u02BC)
	{
		\u02B9\u02BC\u02BC\u02C0\u02B7\u02BD\u02B5\u02B9\u02B6\u02B6\u02BC &= 137438953471UL;
		ulong num = (\u02BF\u02B6\u02BD\u02BC\u02C0\u02BD\u02B6\u02BC\u02B2\u02B7\u02B5 ^ \u02B9\u02BC\u02BC\u02C0\u02B7\u02BD\u02B5\u02B9\u02B6\u02B6\u02BC) * 50912195UL % 137438953472UL;
		ulong num2 = (num ^ (num >> 7)) & 5570645UL;
		return (num ^ num2 ^ (num2 << 7)) - 1UL;
	}

	private static ulong \u02BF\u02B8\u02B4\u02B2\u02BF\u02B8\u02B9\u02C1\u02B7\u02B9\u02B9;

	private static \u02C0\u02B8\u02BC\u02BB\u02BD\u02BA\u02B9\u02C1\u02BF\u02BC\u02B5 \u02B9\u02BC\u02BC\u02C0\u02B7\u02BD\u02B5\u02B9\u02B6\u02B6\u02BC;
}
