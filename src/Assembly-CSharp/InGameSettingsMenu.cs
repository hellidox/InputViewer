using System;
using TMPro;
using UnityEngine;

public class InGameSettingsMenu : BaseMenu
{
	private void \u02B3\u02BC\u02BB\u02BF\u02C1\u02BE\u02B4\u02BC\u02BE\u02BF\u02B8()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("song");
	}

	public virtual void \u02BA\u02B7\u02B3\u02B3\u02B7\u02BD\u02BD\u02BA\u02C0\u02BE\u02BE()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "latestTestBuild")
		{
			base.gameObject.SetActive(true);
			this.\u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA.gameObject.SetActive(false);
			return;
		}
		if (!(text == "n != 1 ? 'other' : 'one'"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.\u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5.gameObject.SetActive(false);
	}

	public virtual void \u02C0\u02C1\u02BB\u02B8\u02BF\u02C0\u02BC\u02B8\u02BF\u02B8\u02B4()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "Show Bot Score")
		{
			base.gameObject.SetActive(false);
			this.\u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA.gameObject.SetActive(false);
			return;
		}
		if (!(text == "song"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.\u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5.gameObject.SetActive(true);
	}

	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "Volume")
		{
			base.gameObject.SetActive(false);
			this.\u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA.gameObject.SetActive(true);
			return;
		}
		if (!(text == "Calibration"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.\u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5.gameObject.SetActive(true);
	}

	public virtual void \u02B9\u02C1\u02B5\u02B5\u02B2\u02BF\u02BA\u02BB\u02BB\u02B9\u02B7()
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
		this.\u02BB\u02BA\u02B5\u02B2\u02B7\u02B6\u02BC\u02B3\u02BA\u02B4\u02B3.gameObject.SetActive(true);
		base.gameObject.SetActive(true);
	}

	private void \u02B9\u02B6\u02B3\u02B9\u02BD\u02BD\u02B6\u02C0\u02BE\u02BA\u02BB()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("WRITING CACHE...");
	}

	private void \u02BA\u02B9\u02BF\u02BC\u02C1\u02B9\u02B7\u02B4\u02C1\u02BB\u02BB()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Exclusive Fullscreen");
	}

	public virtual void \u02C0\u02BE\u02B9\u02B5\u02B6\u02C1\u02B5\u02C0\u02BE\u02B8\u02C1()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "")
		{
			base.gameObject.SetActive(true);
			this.\u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA.gameObject.SetActive(false);
			return;
		}
		if (!(text == "playTime"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.\u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5.gameObject.SetActive(true);
	}

	public virtual void \u02BC\u02BD\u02B2\u02B9\u02BB\u02C1\u02BB\u02B6\u02B4\u02BC\u02BE()
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
		this.\u02BB\u02BA\u02B5\u02B2\u02B7\u02B6\u02BC\u02B3\u02BA\u02B4\u02B3.gameObject.SetActive(false);
		base.gameObject.SetActive(true);
	}

	private new void OnEnable()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("OPTIONS");
	}

	private void \u02B9\u02BE\u02BC\u02BE\u02BC\u02B9\u02B2\u02B3\u02BF\u02B2\u02BA()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("album.jpg");
	}

	public virtual void \u02BD\u02B3\u02B9\u02BD\u02B3\u02BE\u02B4\u02B9\u02BB\u02BE\u02B9()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "Highways")
		{
			base.gameObject.SetActive(true);
			this.\u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA.gameObject.SetActive(true);
			return;
		}
		if (!(text == "genre"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.\u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5.gameObject.SetActive(false);
	}

	public virtual void \u02C0\u02BF\u02BD\u02BA\u02B8\u02BB\u02B7\u02B5\u02BA\u02BB\u02BD()
	{
		string text = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
		if (text == "No")
		{
			base.gameObject.SetActive(false);
			this.\u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA.gameObject.SetActive(true);
			return;
		}
		if (!(text == "changesearchtip"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.\u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5.gameObject.SetActive(false);
	}

	private void \u02B9\u02B7\u02C0\u02B7\u02C1\u02BA\u02BC\u02C0\u02C1\u02BD\u02B6()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("loading_phrase");
	}

	private void \u02C0\u02B7\u02B3\u02BF\u02B9\u02B3\u02BB\u02C1\u02BB\u02BA\u02BF()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("");
	}

	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
		this.\u02BB\u02BA\u02B5\u02B2\u02B7\u02B6\u02BC\u02B3\u02BA\u02B4\u02B3.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	public PauseMenu \u02BB\u02BA\u02B5\u02B2\u02B7\u02B6\u02BC\u02B3\u02BA\u02B4\u02B3;

	public VolumeMenu \u02B4\u02B5\u02BD\u02B6\u02B8\u02B4\u02C0\u02BD\u02BC\u02B8\u02BA;

	public CalibrationMenu \u02B3\u02B7\u02BF\u02BB\u02B6\u02BC\u02B3\u02B3\u02B5\u02C1\u02B5;

	[SerializeField]
	private TextMeshProUGUI pausedText;
}
