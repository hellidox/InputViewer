using System;
using UnityEngine;

public class v1Popup : ConfirmationMenu
{
	public virtual void \u02BB\u02C1\u02B3\u02BF\u02BB\u02BB\u02B4\u02BA\u02B7\u02B4\u02BD()
	{
		if (base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC == 0)
		{
			Application.OpenURL(this.postURL);
		}
		base.\u02C0\u02B8\u02BD\u02B8\u02BB\u02BC\u02BE\u02B2\u02B2\u02B3\u02B5();
	}

	public override void \u02B8\u02C1\u02B2\u02C0\u02B8\u02B6\u02C1\u02B4\u02B9\u02B8\u02BF()
	{
		if (base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC == 0)
		{
			Application.OpenURL(this.postURL);
		}
		base.ConfirmPressed();
	}

	public override void \u02B5\u02B4\u02BE\u02B6\u02BC\u02BC\u02C0\u02BC\u02B5\u02BC\u02BF()
	{
	}

	public override void \u02BC\u02BD\u02B2\u02B9\u02BB\u02C1\u02BB\u02B6\u02B4\u02BC\u02BE()
	{
	}

	public virtual void \u02C0\u02BF\u02BD\u02BA\u02B8\u02BB\u02B7\u02B5\u02BA\u02BB\u02BD()
	{
		if (base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC == 0)
		{
			Application.OpenURL(this.postURL);
		}
		base.\u02B3\u02C1\u02B8\u02BA\u02B2\u02B8\u02B5\u02B6\u02B2\u02B5\u02BA();
	}

	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
	}

	public override void ConfirmPressed()
	{
		if (base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC == 0)
		{
			Application.OpenURL(this.postURL);
		}
		base.ConfirmPressed();
	}

	public override void \u02C0\u02B8\u02BD\u02B8\u02BB\u02BC\u02BE\u02B2\u02B2\u02B3\u02B5()
	{
		if (base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC == 0)
		{
			Application.OpenURL(this.postURL);
		}
		base.\u02B8\u02C1\u02B2\u02C0\u02B8\u02B6\u02C1\u02B4\u02B9\u02B8\u02BF();
	}

	public virtual void \u02BD\u02B3\u02B9\u02BD\u02B3\u02BE\u02B4\u02B9\u02BB\u02BE\u02B9()
	{
		if (base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC == 0)
		{
			Application.OpenURL(this.postURL);
		}
		base.ConfirmPressed();
	}

	public override void \u02B3\u02C1\u02B8\u02BA\u02B2\u02B8\u02B5\u02B6\u02B2\u02B5\u02BA()
	{
		if (base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC == 0)
		{
			Application.OpenURL(this.postURL);
		}
		base.\u02B8\u02C1\u02B2\u02C0\u02B8\u02B6\u02C1\u02B4\u02B9\u02B8\u02BF();
	}

	public override void \u02C0\u02BE\u02B9\u02B5\u02B6\u02C1\u02B5\u02C0\u02BE\u02B8\u02C1()
	{
		if (base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC == 0)
		{
			Application.OpenURL(this.postURL);
		}
		base.ConfirmPressed();
	}

	[SerializeField]
	private string postURL = "https://clonehero.net/2022/11/29/v23-to-v1-migration-instructions.html";
}
