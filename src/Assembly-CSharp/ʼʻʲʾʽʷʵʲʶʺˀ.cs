﻿using System;
using UnityEngine;

public class \u02BC\u02BB\u02B2\u02BE\u02BD\u02B7\u02B5\u02B2\u02B6\u02BA\u02C0 : \u02BC\u02BB\u02BE\u02BC\u02C1\u02B5\u02C1\u02C1\u02B5\u02B6\u02BB
{
	public override void \u02BF\u02BD\u02B6\u02B2\u02B6\u02BE\u02B5\u02BF\u02BA\u02B8\u02BD()
	{
		global::UnityEngine.Object.FindObjectOfType<OnlineMenu>().\u02BF\u02BD\u02B6\u02B2\u02B6\u02BE\u02B5\u02BF\u02BA\u02B8\u02BD();
	}

	public override void \u02BD\u02B5\u02C1\u02B8\u02BE\u02BE\u02BB\u02B4\u02BA\u02B4\u02B4(int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
	{
		PlayerProfileMenu.\u02B7\u02B8\u02B4\u02BC\u02B6\u02C0\u02BB\u02BE\u02BD\u02C1\u02B7(\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7, string.Empty);
	}

	protected override void \u02BE\u02BE\u02BC\u02BA\u02BE\u02BA\u02B6\u02C1\u02BD\u02B4\u02B7()
	{
	}

	public override void \u02B4\u02B5\u02BE\u02C0\u02BE\u02BA\u02C0\u02C1\u02BD\u02B5\u02B9()
	{
		\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BA\u02BE\u02B4\u02B3\u02B7\u02C1\u02B3\u02B3\u02C1\u02B4.\u02B4\u02B5\u02BE\u02C0\u02BE\u02BA\u02C0\u02C1\u02BD\u02B5\u02B9();
	}

	public override bool \u02BE\u02BB\u02BF\u02B7\u02C0\u02BE\u02B3\u02BD\u02B3\u02C0\u02B4(\u02C0\u02C0\u02BD\u02B6\u02BA\u02BF\u02B3\u02BE\u02BC\u02B8\u02B4 \u02BB\u02B7\u02BC\u02B6\u02B9\u02C0\u02B7\u02BE\u02B5\u02C0\u02BA)
	{
		if (\u02BB\u02B7\u02BC\u02B6\u02B9\u02C0\u02B7\u02BE\u02B5\u02C0\u02BA != \u02C0\u02C0\u02BD\u02B6\u02BA\u02BF\u02B3\u02BE\u02BC\u02B8\u02B4.SongList)
		{
			return false;
		}
		global::UnityEngine.Object.FindObjectOfType<OnlineMenu>().\u02C1\u02BD\u02C1\u02BA\u02BE\u02C1\u02C0\u02B4\u02BD\u02BD\u02B7();
		return true;
	}

	public override void \u02B8\u02BA\u02B9\u02B7\u02C0\u02B6\u02BF\u02BF\u02B5\u02C0\u02B5()
	{
	}

	public override void \u02BA\u02B4\u02B3\u02B7\u02C0\u02B8\u02B5\u02B5\u02BE\u02C1\u02B5(\u02BD\u02C1\u02B2\u02BD\u02B5\u02B8\u02B6\u02BD\u02B9\u02C1\u02B6 \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC)
	{
	}
}
