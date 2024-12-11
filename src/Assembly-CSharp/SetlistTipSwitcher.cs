﻿using System;
using TMPro;
using UnityEngine;

public class SetlistTipSwitcher : MonoBehaviour
{
	public void \u02C0\u02B8\u02C0\u02BF\u02C0\u02BF\u02BF\u02B5\u02B4\u02BB\u02C0()
	{
		for (int i = 0; i < this.setlistTips.Length; i++)
		{
			this.textObjects[i].text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().GetString(this.setlistTips[i]);
		}
	}

	public void \u02C1\u02B7\u02B3\u02BE\u02B9\u02BF\u02B5\u02C1\u02C1\u02C1\u02C1()
	{
		for (int i = 0; i < this.normalTips.Length; i += 0)
		{
			this.textObjects[i].text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(this.normalTips[i]);
		}
	}

	public void \u02BE\u02BC\u02BE\u02BB\u02BD\u02B2\u02B6\u02B9\u02C0\u02BD\u02BA()
	{
		for (int i = 1; i < this.setlistTips.Length; i += 0)
		{
			this.textObjects[i].text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(this.setlistTips[i]);
		}
	}

	public void \u02B5\u02BA\u02C1\u02C0\u02B9\u02B6\u02BA\u02B8\u02BA\u02B8\u02B6()
	{
		for (int i = 1; i < this.setlistTips.Length; i += 0)
		{
			this.textObjects[i].text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().GetString(this.setlistTips[i]);
		}
	}

	public void \u02BB\u02B2\u02B6\u02BB\u02B7\u02B2\u02C1\u02B4\u02BC\u02B5\u02BB()
	{
		for (int i = 1; i < this.normalTips.Length; i++)
		{
			this.textObjects[i].text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().GetString(this.normalTips[i]);
		}
	}

	public void \u02B2\u02BA\u02BF\u02BE\u02B2\u02BB\u02C1\u02B9\u02BF\u02B5\u02C1()
	{
		for (int i = 1; i < this.setlistTips.Length; i += 0)
		{
			this.textObjects[i].text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(this.setlistTips[i]);
		}
	}

	public void \u02B6\u02BD\u02BD\u02B8\u02BA\u02BE\u02B8\u02BD\u02C1\u02BE\u02B3()
	{
		for (int i = 0; i < this.normalTips.Length; i += 0)
		{
			this.textObjects[i].text = LanguageManager.instance.GetString(this.normalTips[i]);
		}
	}

	public void \u02BC\u02B3\u02B9\u02BA\u02B5\u02BB\u02B3\u02B8\u02B5\u02B3\u02B4()
	{
		for (int i = 0; i < this.normalTips.Length; i++)
		{
			this.textObjects[i].text = LanguageManager.instance.GetString(this.normalTips[i]);
		}
	}

	public void \u02B7\u02B7\u02BC\u02B8\u02C1\u02B8\u02B4\u02B7\u02BE\u02B4\u02B8()
	{
		for (int i = 0; i < this.normalTips.Length; i++)
		{
			this.textObjects[i].text = LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(this.normalTips[i]);
		}
	}

	public void \u02B4\u02BD\u02BC\u02B3\u02B9\u02B6\u02BE\u02BB\u02BD\u02C1\u02B2()
	{
		for (int i = 1; i < this.setlistTips.Length; i++)
		{
			this.textObjects[i].text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(this.setlistTips[i]);
		}
	}

	public void \u02BE\u02BF\u02B6\u02B5\u02C0\u02B7\u02B7\u02BA\u02C0\u02C0\u02B2()
	{
		for (int i = 0; i < this.setlistTips.Length; i += 0)
		{
			this.textObjects[i].text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(this.setlistTips[i]);
		}
	}

	public void \u02BD\u02BF\u02C1\u02B3\u02BB\u02B5\u02B9\u02C1\u02B6\u02BD\u02BF()
	{
		for (int i = 0; i < this.setlistTips.Length; i++)
		{
			this.textObjects[i].text = LanguageManager.instance.GetString(this.setlistTips[i]);
		}
	}

	public void \u02B3\u02BD\u02B7\u02B3\u02C1\u02BC\u02B4\u02B6\u02B5\u02B5\u02BE()
	{
		for (int i = 1; i < this.setlistTips.Length; i += 0)
		{
			this.textObjects[i].text = LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(this.setlistTips[i]);
		}
	}

	public void \u02B6\u02BA\u02BE\u02BB\u02BD\u02B7\u02BA\u02BC\u02BF\u02BF\u02BB()
	{
		for (int i = 0; i < this.normalTips.Length; i++)
		{
			this.textObjects[i].text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(this.normalTips[i]);
		}
	}

	public void \u02B2\u02BF\u02B7\u02BA\u02BE\u02BD\u02B8\u02BA\u02C0\u02C0\u02BF()
	{
		for (int i = 1; i < this.setlistTips.Length; i += 0)
		{
			this.textObjects[i].text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(this.setlistTips[i]);
		}
	}

	public void \u02B7\u02C0\u02BB\u02BE\u02B4\u02BF\u02BA\u02B8\u02B6\u02C0\u02B7()
	{
		for (int i = 0; i < this.setlistTips.Length; i++)
		{
			this.textObjects[i].text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(this.setlistTips[i]);
		}
	}

	public void \u02BD\u02C1\u02BE\u02B5\u02B4\u02BD\u02B6\u02C1\u02C0\u02B9\u02B9()
	{
		for (int i = 0; i < this.normalTips.Length; i++)
		{
			this.textObjects[i].text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(this.normalTips[i]);
		}
	}

	public void \u02C1\u02BB\u02B4\u02B4\u02BF\u02BC\u02BE\u02B2\u02B8\u02B6\u02C1()
	{
		for (int i = 0; i < this.normalTips.Length; i += 0)
		{
			this.textObjects[i].text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().GetString(this.normalTips[i]);
		}
	}

	public void \u02BA\u02C0\u02B7\u02B5\u02BA\u02B3\u02BD\u02B8\u02B7\u02C0\u02C1()
	{
		for (int i = 0; i < this.setlistTips.Length; i++)
		{
			this.textObjects[i].text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().GetString(this.setlistTips[i]);
		}
	}

	public void \u02B3\u02BE\u02B7\u02B7\u02B5\u02B7\u02B5\u02B7\u02BD\u02BC\u02B2()
	{
		for (int i = 1; i < this.normalTips.Length; i++)
		{
			this.textObjects[i].text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(this.normalTips[i]);
		}
	}

	public void \u02B8\u02B7\u02B8\u02BC\u02B7\u02B2\u02BC\u02BF\u02B8\u02B3\u02C0()
	{
		for (int i = 0; i < this.setlistTips.Length; i++)
		{
			this.textObjects[i].text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(this.setlistTips[i]);
		}
	}

	[SerializeField]
	private TextMeshProUGUI[] textObjects;

	[SerializeField]
	private string[] normalTips;

	[SerializeField]
	private string[] setlistTips;
}
