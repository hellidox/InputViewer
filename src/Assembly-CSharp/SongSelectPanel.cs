using System;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SongSelectPanel : MonoBehaviour
{
	public void \u02C1\u02B4\u02BC\u02C1\u02BB\u02BE\u02B8\u02BD\u02BD\u02B3\u02B5()
	{
		this.starCount.enabled = true;
		this.star.enabled = true;
		this.percentText.enabled = false;
		this.FCImage.enabled = true;
	}

	public void \u02B7\u02BE\u02BF\u02B2\u02B7\u02B2\u02BE\u02B7\u02BA\u02BA\u02C0()
	{
		this.starCount.enabled = false;
		this.star.enabled = false;
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	public void \u02B2\u02BC\u02B6\u02BC\u02B5\u02BA\u02B6\u02BD\u02C0\u02BD\u02B3(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.\u02B5\u02B9\u02BF\u02BF\u02B9\u02B2\u02BF\u02B7\u02B6\u02C1\u02BB();
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9 <= 0)
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
		}
		else
		{
			this.star.enabled = true;
			this.starCount.enabled = false;
			this.starCount.text = Mathf.Min((int)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9, 0).ToString();
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02B2\u02C0\u02B6\u02BC\u02BF\u02C0\u02B7\u02B6\u02C1\u02BB)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = false;
		this.percentText.text = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.ToString() + "video_start_time";
	}

	public void \u02B4\u02B6\u02C0\u02BC\u02B4\u02BE\u02BE\u02BC\u02BF\u02BB\u02BB(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.\u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7();
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9 <= 0)
		{
			this.star.enabled = true;
			this.starCount.enabled = true;
		}
		else
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
			this.starCount.text = Mathf.Min((int)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9, 7).ToString();
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02B2\u02C0\u02B6\u02BC\u02BF\u02C0\u02B7\u02B6\u02C1\u02BB)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.ToString() + "notes.mid";
	}

	public void \u02BD\u02B9\u02B7\u02B8\u02B8\u02B6\u02B9\u02B8\u02B5\u02B7\u02B6()
	{
		this.starCount.enabled = false;
		this.star.enabled = true;
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	public void \u02B2\u02BA\u02BE\u02B9\u02BD\u02B9\u02BE\u02B2\u02BA\u02BD\u02B2(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.\u02BD\u02BE\u02C0\u02BE\u02BB\u02B5\u02BE\u02BE\u02B3\u02BB\u02B4();
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9 <= 0)
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
		}
		else
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
			this.starCount.text = Mathf.Min((int)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9, 8).ToString();
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02B2\u02C0\u02B6\u02BC\u02BF\u02C0\u02B7\u02B6\u02C1\u02BB)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = false;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = false;
		this.percentText.text = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.ToString() + "127.0.0.1";
	}

	public void \u02B4\u02B2\u02BF\u02B7\u02C0\u02BD\u02BE\u02C1\u02B6\u02BE\u02BD()
	{
		this.starCount.enabled = false;
		this.star.enabled = true;
		this.percentText.enabled = true;
		this.FCImage.enabled = false;
	}

	public void \u02BC\u02BE\u02BD\u02BA\u02BE\u02B4\u02BA\u02B2\u02B2\u02B4\u02B5(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.\u02BD\u02B9\u02B7\u02B8\u02B8\u02B6\u02B9\u02B8\u02B5\u02B7\u02B6();
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9 <= 1)
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
		}
		else
		{
			this.star.enabled = false;
			this.starCount.enabled = true;
			this.starCount.text = Mathf.Min((int)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9, 6).ToString();
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02B2\u02C0\u02B6\u02BC\u02BF\u02C0\u02B7\u02B6\u02C1\u02BB)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = false;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = true;
		this.percentText.text = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.ToString() + "Background Image";
	}

	public void \u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7()
	{
		this.starCount.enabled = false;
		this.star.enabled = false;
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	public void \u02B4\u02B8\u02C1\u02BF\u02B9\u02B3\u02B8\u02B5\u02BF\u02B7\u02B3()
	{
		this.starCount.enabled = true;
		this.star.enabled = false;
		this.percentText.enabled = true;
		this.FCImage.enabled = true;
	}

	public void \u02B2\u02B3\u02BF\u02BD\u02B5\u02BF\u02B5\u02B6\u02B3\u02B3\u02BA()
	{
		this.starCount.enabled = true;
		this.star.enabled = false;
		this.percentText.enabled = true;
		this.FCImage.enabled = true;
	}

	public void \u02B5\u02B9\u02BF\u02BF\u02B9\u02B2\u02BF\u02B7\u02B6\u02C1\u02BB()
	{
		this.starCount.enabled = false;
		this.star.enabled = false;
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	public void \u02B6\u02BF\u02B6\u02B3\u02BB\u02B7\u02B8\u02C1\u02B9\u02B4\u02BB(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.\u02BB\u02B8\u02BD\u02B6\u02BB\u02BA\u02B8\u02C1\u02BA\u02BC\u02BD();
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9 <= 1)
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
		}
		else
		{
			this.star.enabled = false;
			this.starCount.enabled = true;
			this.starCount.text = Mathf.Min((int)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9, 0).ToString();
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02B2\u02C0\u02B6\u02BC\u02BF\u02C0\u02B7\u02B6\u02C1\u02BB)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.ToString() + "Gamepad Mode";
	}

	public void \u02BB\u02B8\u02BD\u02B6\u02BB\u02BA\u02B8\u02C1\u02BA\u02BC\u02BD()
	{
		this.starCount.enabled = true;
		this.star.enabled = true;
		this.percentText.enabled = true;
		this.FCImage.enabled = true;
	}

	public void \u02BD\u02BE\u02C0\u02BE\u02BB\u02B5\u02BE\u02BE\u02B3\u02BB\u02B4()
	{
		this.starCount.enabled = true;
		this.star.enabled = true;
		this.percentText.enabled = true;
		this.FCImage.enabled = false;
	}

	public void \u02BF\u02BC\u02B7\u02B2\u02B9\u02BA\u02BD\u02B6\u02C0\u02C0\u02BE(\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.\u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7();
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9 <= 0)
		{
			this.star.enabled = false;
			this.starCount.enabled = false;
		}
		else
		{
			this.star.enabled = true;
			this.starCount.enabled = true;
			this.starCount.text = Mathf.Min((int)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9, 7).ToString();
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02B4\u02B2\u02C0\u02B6\u02BC\u02BF\u02C0\u02B7\u02B6\u02C1\u02BB)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.ToString() + "%";
	}

	[SerializeField]
	private Image star;

	[SerializeField]
	private TextMeshProUGUI percentText;

	[SerializeField]
	private TextMeshProUGUI starCount;

	[SerializeField]
	private Image FCImage;
}
