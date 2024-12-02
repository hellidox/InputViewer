using System;
using UnityEngine;

internal class \u02B5\u02C1\u02B6\u02BD\u02B5\u02B9\u02B2\u02B4\u02B3\u02B5\u02C0 : \u02BC\u02BB\u02BE\u02BC\u02C1\u02B5\u02C1\u02C1\u02B5\u02B6\u02BB
{
	public override void \u02BF\u02BD\u02B6\u02B2\u02B6\u02BE\u02B5\u02BF\u02BA\u02B8\u02BD()
	{
	}

	public override bool \u02BE\u02BB\u02BF\u02B7\u02C0\u02BE\u02B3\u02BD\u02B3\u02C0\u02B4(\u02C0\u02C0\u02BD\u02B6\u02BA\u02BF\u02B3\u02BE\u02BC\u02B8\u02B4 \u02BB\u02B7\u02BC\u02B6\u02B9\u02C0\u02B7\u02BE\u02B5\u02C0\u02BA)
	{
		if (\u02BB\u02B7\u02BC\u02B6\u02B9\u02C0\u02B7\u02BE\u02B5\u02C0\u02BA == \u02C0\u02C0\u02BD\u02B6\u02BA\u02BF\u02B3\u02BE\u02BC\u02B8\u02B4.Gameplay)
		{
			global::UnityEngine.Object.FindObjectOfType<PlayerSelectionCanvas>().\u02C0\u02BD\u02BF\u02B5\u02B8\u02B7\u02B2\u02B5\u02B6\u02B8\u02B3();
			return true;
		}
		if (\u02BB\u02B7\u02BC\u02B6\u02B9\u02C0\u02B7\u02BE\u02B5\u02C0\u02BA == \u02C0\u02C0\u02BD\u02B6\u02BA\u02BF\u02B3\u02BE\u02BC\u02B8\u02B4.SongList)
		{
			global::UnityEngine.Object.FindObjectOfType<PlayerSelectionCanvas>().\u02C0\u02B5\u02B9\u02BA\u02B3\u02C1\u02BC\u02B8\u02BB\u02BC\u02B6();
			return true;
		}
		return false;
	}

	public override void \u02B4\u02B5\u02BE\u02C0\u02BE\u02BA\u02C0\u02C1\u02BD\u02B5\u02B9()
	{
	}

	private void \u02B5\u02B7\u02B9\u02B7\u02BE\u02BF\u02BD\u02B9\u02BA\u02BE\u02B6()
	{
		this.\u02BC\u02B3\u02B2\u02B9\u02B8\u02B8\u02B2\u02BD\u02BB\u02BF\u02B7.\u02BF\u02C0\u02B8\u02B5\u02BE\u02BB\u02BA\u02B5\u02B3\u02B5\u02BA<\u02B5\u02B7\u02B3\u02B9\u02B6\u02BE\u02B3\u02B4\u02BA\u02B6\u02C0>(this.\u02BA\u02C0\u02B4\u02BD\u02B5\u02BD\u02B4\u02BC\u02B5\u02B6\u02BC);
		foreach (PlayerSelectionMenu playerSelectionMenu in this.\u02B6\u02B5\u02BA\u02BD\u02B3\u02B7\u02B7\u02C1\u02B5\u02BC\u02B8)
		{
			if (playerSelectionMenu.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == (int)this.\u02BA\u02C0\u02B4\u02BD\u02B5\u02BD\u02B4\u02BC\u02B5\u02B6\u02BC.\u02C1\u02BA\u02BB\u02BC\u02BF\u02B6\u02C0\u02B6\u02C1\u02C1\u02BE)
			{
				playerSelectionMenu.\u02B8\u02B9\u02C0\u02BA\u02C0\u02C0\u02B7\u02BE\u02B5\u02B2\u02B7(this.\u02BA\u02C0\u02B4\u02BD\u02B5\u02BD\u02B4\u02BC\u02B5\u02B6\u02BC.\u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1);
			}
		}
	}

	public override void \u02B8\u02BA\u02B9\u02B7\u02C0\u02B6\u02BF\u02BF\u02B5\u02C0\u02B5()
	{
		this.\u02B6\u02B5\u02BA\u02BD\u02B3\u02B7\u02B7\u02C1\u02B5\u02BC\u02B8 = global::UnityEngine.Object.FindObjectsOfType<PlayerSelectionMenu>();
	}

	protected override void \u02BE\u02BE\u02BC\u02BA\u02BE\u02BA\u02B6\u02C1\u02BD\u02B4\u02B7()
	{
		this.\u02B8\u02B4\u02BC\u02B8\u02BA\u02BD\u02B8\u02B3\u02B4\u02B6\u02BC.\u02BE\u02C1\u02B5\u02B8\u02C1\u02B5\u02B9\u02BA\u02B6\u02C0\u02BF(\u02C0\u02B7\u02B5\u02C0\u02B9\u02BE\u02B4\u02C0\u02C0\u02BF\u02BF.MenuMovement, new \u02BF\u02BE\u02B7\u02B4\u02B8\u02B4\u02BD\u02BC\u02B7\u02C0\u02BA(this.\u02B5\u02B7\u02B9\u02B7\u02BE\u02BF\u02BD\u02B9\u02BA\u02BE\u02B6));
	}

	public override void \u02BA\u02B4\u02B3\u02B7\u02C0\u02B8\u02B5\u02B5\u02BE\u02C1\u02B5(\u02BD\u02C1\u02B2\u02BD\u02B5\u02B8\u02B6\u02BD\u02B9\u02C1\u02B6 \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC)
	{
		foreach (PlayerSelectionMenu playerSelectionMenu in this.\u02B6\u02B5\u02BA\u02BD\u02B3\u02B7\u02B7\u02C1\u02B5\u02BC\u02B8)
		{
			if (playerSelectionMenu.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == (int)\u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
			{
				playerSelectionMenu.\u02BA\u02BD\u02BD\u02C1\u02BC\u02B4\u02B2\u02BE\u02B6\u02BD\u02B5();
			}
		}
	}

	public override void \u02BD\u02B5\u02C1\u02B8\u02BE\u02BE\u02BB\u02B4\u02BA\u02B4\u02B4(int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
	{
		PlayerProfileMenu.\u02B7\u02B8\u02B4\u02BC\u02B6\u02C0\u02BB\u02BE\u02BD\u02C1\u02B7(\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7, string.Empty);
	}

	private PlayerSelectionMenu[] \u02B6\u02B5\u02BA\u02BD\u02B3\u02B7\u02B7\u02C1\u02B5\u02BC\u02B8;

	private \u02B5\u02B7\u02B3\u02B9\u02B6\u02BE\u02B3\u02B4\u02BA\u02B6\u02C0 \u02BA\u02C0\u02B4\u02BD\u02B5\u02BD\u02B4\u02BC\u02B5\u02B6\u02BC = new \u02B5\u02B7\u02B3\u02B9\u02B6\u02BE\u02B3\u02B4\u02BA\u02B6\u02C0();
}
