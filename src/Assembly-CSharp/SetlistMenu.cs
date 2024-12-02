﻿using System;
using TMPro;
using UnityEngine;

public class SetlistMenu : BaseMenu
{
	public void \u02B2\u02B8\u02BC\u02BB\u02B4\u02BE\u02BD\u02C1\u02B2\u02B6\u02B9()
	{
		if (!base.isActiveAndEnabled)
		{
			this.canvasGroup.alpha = 0f;
			base.gameObject.SetActive(true);
		}
		this.\u02B7\u02BD\u02BF\u02BB\u02B6\u02BD\u02B3\u02BC\u02BD\u02C0\u02B8 = false;
		this.\u02BB\u02BA\u02C0\u02B8\u02B7\u02B2\u02B8\u02B8\u02BE\u02B7\u02B7 = 0f;
		this.fader.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0 = false;
		if (!this.fader.\u02C0\u02B9\u02BE\u02BB\u02BE\u02C0\u02C1\u02B9\u02B9\u02B5\u02B3)
		{
			this.fader.\u02C0\u02B5\u02B6\u02BF\u02B5\u02BF\u02B8\u02BE\u02B9\u02BA\u02BF(0f);
		}
	}

	private void \u02B7\u02C0\u02BA\u02B4\u02B9\u02B7\u02BC\u02B9\u02BF\u02BD\u02B8()
	{
		this.\u02B5\u02BA\u02B3\u02BD\u02BF\u02BB\u02B4\u02BD\u02B6\u02C1\u02B6 = 0.0;
		for (int i = 0; i < \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count; i++)
		{
			double num = (double)\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD[i].songLength * 0.001;
			float num2 = (float)\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC[i] * 0.01f;
			this.\u02B5\u02BA\u02B3\u02BD\u02BF\u02BB\u02B4\u02BD\u02B6\u02C1\u02B6 += num / (double)num2;
		}
	}

	public void \u02B7\u02BC\u02B8\u02BC\u02C0\u02B7\u02BE\u02B6\u02B9\u02B3\u02C1()
	{
		this.\u02B7\u02C0\u02BA\u02B4\u02B9\u02B7\u02BC\u02B9\u02BF\u02BD\u02B8();
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public void \u02BA\u02B4\u02B2\u02BB\u02B9\u02BC\u02B9\u02B8\u02C1\u02B5\u02BE(SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA, int \u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE = 100, string \u02B4\u02B7\u02B2\u02B2\u02BA\u02C1\u02B6\u02BF\u02B9\u02BE\u02BF = "")
	{
		if (!base.isActiveAndEnabled)
		{
			this.\u02BC\u02BF\u02B3\u02BB\u02B4\u02BD\u02BF\u02B3\u02B4\u02B8\u02B8();
			base.gameObject.SetActive(true);
			this.\u02B8\u02BA\u02B8\u02B4\u02B9\u02B5\u02B5\u02C1\u02B6\u02B7\u02B5(false);
		}
		this.tipSwitcher.\u02BD\u02BF\u02C1\u02B3\u02BB\u02B5\u02B9\u02C1\u02B6\u02BD\u02BF();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Add(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA);
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC.Add(\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE);
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B5\u02B5\u02BF\u02B9\u02BD\u02B9\u02BC\u02B5\u02B6\u02B8\u02B3.Add(\u02B4\u02B7\u02B2\u02B2\u02BA\u02C1\u02B6\u02BF\u02B9\u02BE\u02BF);
		this.\u02B7\u02BF\u02B8\u02BF\u02B8\u02BF\u02B4\u02B2\u02BC\u02B4\u02BE();
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public void \u02B8\u02BE\u02B3\u02B7\u02B2\u02B2\u02B5\u02B7\u02BB\u02BF\u02B3()
	{
		base.gameObject.SetActive(false);
		this.tipSwitcher.\u02BE\u02BC\u02BE\u02BB\u02BD\u02B2\u02B6\u02B9\u02C0\u02BD\u02BA();
		this.\u02BE\u02BC\u02BA\u02BB\u02B6\u02B2\u02B5\u02BF\u02BA\u02B2\u02B2();
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B5\u02BA\u02B3\u02BD\u02BF\u02BB\u02B4\u02BD\u02B6\u02C1\u02B6 = 139.0;
		this.\u02C1\u02B2\u02BE\u02B8\u02B5\u02B4\u02C0\u02C1\u02C1\u02B4\u02B2();
		this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	protected override void Update()
	{
		if (this.\u02B7\u02BD\u02BF\u02BB\u02B6\u02BD\u02B3\u02BC\u02BD\u02C0\u02B8)
		{
			this.\u02BB\u02BA\u02C0\u02B8\u02B7\u02B2\u02B8\u02B8\u02BE\u02B7\u02B7 += Time.deltaTime;
			if (this.\u02BB\u02BA\u02C0\u02B8\u02B7\u02B2\u02B8\u02B8\u02BE\u02B7\u02B7 > 2f)
			{
				this.\u02B2\u02B8\u02BC\u02BB\u02B4\u02BE\u02BD\u02C1\u02B2\u02B6\u02B9();
			}
		}
	}

	protected virtual void \u02BD\u02B8\u02BD\u02B5\u02B6\u02B3\u02BF\u02B3\u02C1\u02B8\u02C1()
	{
		if (this.\u02B7\u02BD\u02BF\u02BB\u02B6\u02BD\u02B3\u02BC\u02BD\u02C0\u02B8)
		{
			this.\u02BB\u02BA\u02C0\u02B8\u02B7\u02B2\u02B8\u02B8\u02BE\u02B7\u02B7 += Time.deltaTime;
			if (this.\u02BB\u02BA\u02C0\u02B8\u02B7\u02B2\u02B8\u02B8\u02BE\u02B7\u02B7 > 1418f)
			{
				this.\u02C1\u02BD\u02BE\u02C0\u02B9\u02B6\u02B2\u02B4\u02BE\u02B9\u02BD();
			}
		}
	}

	public void \u02BC\u02B2\u02BD\u02B7\u02BA\u02BF\u02C0\u02BE\u02B4\u02BE\u02B9(bool \u02B5\u02BC\u02BE\u02B6\u02B6\u02B7\u02B9\u02B8\u02B8\u02B4\u02BC = false)
	{
		this.\u02B7\u02BD\u02BF\u02BB\u02B6\u02BD\u02B3\u02BC\u02BD\u02C0\u02B8 = true;
		this.\u02BB\u02BA\u02C0\u02B8\u02B7\u02B2\u02B8\u02B8\u02BE\u02B7\u02B7 = 0f;
		if (\u02B5\u02BC\u02BE\u02B6\u02B6\u02B7\u02B9\u02B8\u02B8\u02B4\u02BC)
		{
			this.fader.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0 = true;
		}
		if (!this.fader.\u02BF\u02B9\u02B6\u02BE\u02B5\u02B9\u02B7\u02B3\u02BB\u02B5\u02B8 && this.fader.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB)
		{
			this.fader.\u02B8\u02BE\u02B8\u02BB\u02C1\u02BF\u02BF\u02B4\u02BC\u02BA\u02BC(0f);
		}
	}

	public void \u02BB\u02B2\u02BD\u02BE\u02B9\u02B2\u02B9\u02B5\u02BF\u02BA\u02B3()
	{
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count == 0 || this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 == 0)
		{
			this.\u02B8\u02BA\u02B8\u02B4\u02B9\u02B5\u02B5\u02C1\u02B6\u02B7\u02B5(!CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB);
			return;
		}
		this.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.RemoveAt(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count - 1);
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC.RemoveAt(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC.Count - 1);
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B5\u02B5\u02BF\u02B9\u02BD\u02B9\u02BC\u02B5\u02B6\u02B8\u02B3.RemoveAt(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B5\u02B5\u02BF\u02B9\u02BD\u02B9\u02BC\u02B5\u02B6\u02B8\u02B3.Count - 1);
		this.\u02B7\u02BF\u02B8\u02BF\u02B8\u02BF\u02B4\u02B2\u02BC\u02B4\u02BE();
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public void \u02B7\u02BF\u02B8\u02BF\u02B8\u02BF\u02B4\u02B2\u02BC\u02B4\u02BE()
	{
		this.\u02B7\u02C0\u02BA\u02B4\u02B9\u02B7\u02BC\u02B9\u02BF\u02BD\u02B8();
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public void \u02B8\u02B7\u02B7\u02B5\u02B8\u02C1\u02BB\u02C0\u02C0\u02B5\u02BD()
	{
		this.\u02C1\u02B2\u02BE\u02B8\u02B5\u02B4\u02C0\u02C1\u02C1\u02B4\u02B2();
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	protected override void Start()
	{
	}

	public void \u02C1\u02BD\u02BE\u02C0\u02B9\u02B6\u02B2\u02B4\u02BE\u02B9\u02BD()
	{
		if (!base.isActiveAndEnabled)
		{
			this.canvasGroup.alpha = 1297f;
			base.gameObject.SetActive(true);
		}
		this.\u02B7\u02BD\u02BF\u02BB\u02B6\u02BD\u02B3\u02BC\u02BD\u02C0\u02B8 = false;
		this.\u02BB\u02BA\u02C0\u02B8\u02B7\u02B2\u02B8\u02B8\u02BE\u02B7\u02B7 = 552f;
		this.fader.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0 = true;
		if (!this.fader.\u02C0\u02B9\u02BE\u02BB\u02BE\u02C0\u02C1\u02B9\u02B9\u02B5\u02B3)
		{
			this.fader.\u02B9\u02BA\u02BF\u02B5\u02B4\u02BD\u02BF\u02BF\u02BA\u02BC\u02BA(444f);
		}
	}

	public void \u02B5\u02B9\u02BE\u02C1\u02C1\u02C0\u02B7\u02BB\u02B2\u02C1\u02BF(SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA, int \u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE = 100, string \u02B4\u02B7\u02B2\u02B2\u02BA\u02C1\u02B6\u02BF\u02B9\u02BE\u02BF = "")
	{
		if (!base.isActiveAndEnabled)
		{
			this.\u02BE\u02BC\u02BA\u02BB\u02B6\u02B2\u02B5\u02BF\u02BA\u02B2\u02B2();
			base.gameObject.SetActive(true);
			this.\u02B8\u02BA\u02B8\u02B4\u02B9\u02B5\u02B5\u02C1\u02B6\u02B7\u02B5(false);
		}
		this.tipSwitcher.\u02B7\u02C0\u02BB\u02BE\u02B4\u02BF\u02BA\u02B8\u02B6\u02C0\u02B7();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Add(\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA);
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC.Add(\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE);
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B5\u02B5\u02BF\u02B9\u02BD\u02B9\u02BC\u02B5\u02B6\u02B8\u02B3.Add(\u02B4\u02B7\u02B2\u02B2\u02BA\u02C1\u02B6\u02BF\u02B9\u02BE\u02BF);
		this.\u02B7\u02BF\u02B8\u02BF\u02B8\u02BF\u02B4\u02B2\u02BC\u02B4\u02BE();
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public void \u02B8\u02BA\u02B8\u02B4\u02B9\u02B5\u02B5\u02C1\u02B6\u02B7\u02B5(bool \u02BB\u02BF\u02BD\u02B7\u02BD\u02B5\u02BC\u02BF\u02B2\u02B3\u02C1 = true)
	{
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BF\u02BD\u02C1\u02C0\u02BC\u02B7\u02B4\u02C0\u02B4\u02C1();
		\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7 = null;
		this.\u02B5\u02BA\u02B3\u02BD\u02BF\u02BB\u02B4\u02BD\u02B6\u02C1\u02B6 = 0.0;
		this.\u02B5\u02BA\u02B3\u02BD\u02BF\u02BB\u02B4\u02BD\u02B6\u02C1\u02B6 = (double)(this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = 0);
		if (\u02BB\u02BF\u02BD\u02B7\u02BD\u02B5\u02BC\u02BF\u02B2\u02B3\u02C1)
		{
			this.tipSwitcher.\u02BC\u02B3\u02B9\u02BA\u02B5\u02BB\u02B3\u02B8\u02B5\u02B3\u02B4();
			this.\u02BC\u02B2\u02BD\u02B7\u02BA\u02BF\u02C0\u02BE\u02B4\u02BE\u02B9(true);
			return;
		}
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public void \u02BE\u02BC\u02BA\u02BB\u02B6\u02B2\u02B5\u02BF\u02BA\u02B2\u02B2()
	{
		this.titleText.text = \u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7;
		this.\u02C1\u02BD\u02BE\u02C0\u02B9\u02B6\u02B2\u02B4\u02BE\u02B9\u02BD();
	}

	public void \u02BF\u02BC\u02C1\u02BC\u02B4\u02C0\u02B5\u02BE\u02BD\u02B9\u02B6()
	{
		base.gameObject.SetActive(true);
		this.tipSwitcher.\u02BD\u02BF\u02C1\u02B3\u02BB\u02B5\u02B9\u02C1\u02B6\u02BD\u02BF();
		this.\u02BC\u02BF\u02B3\u02BB\u02B4\u02BD\u02BF\u02B3\u02B4\u02B8\u02B8();
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B5\u02BA\u02B3\u02BD\u02BF\u02BB\u02B4\u02BD\u02B6\u02C1\u02B6 = 0.0;
		this.\u02B7\u02C0\u02BA\u02B4\u02B9\u02B7\u02BC\u02B9\u02BF\u02BD\u02B8();
		this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	protected virtual void \u02BF\u02BC\u02B2\u02BF\u02BC\u02B3\u02B6\u02C0\u02B6\u02B9\u02BF()
	{
		int num = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
		bool flag = true;
		for (int i = 1; i < this.textObjects.Length; i++)
		{
			if (i >= this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
			{
				this.textObjects[i].text = "Total Notes";
				this.placeTexts[i].text = "diff_guitar_coop_ghl";
				this.listObjects[i].SetActive(false);
			}
			else
			{
				this.textObjects[i].text = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD[num].Name.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA() + ((\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC[num] != -41) ? ("%c" + \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC[num].ToString() + "No") : "playerCount") + ((\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B5\u02B5\u02BF\u02B9\u02BD\u02B9\u02BC\u02B5\u02B6\u02B8\u02B3[num] != "No") ? ("startActivity" + \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B5\u02B5\u02BF\u02B9\u02BD\u02B9\u02BC\u02B5\u02B6\u02B8\u02B3[num]) : "MSAA Level");
				this.placeTexts[i].text = (num + 0).ToString() + "Accents Hit";
				this.listObjects[i].SetActive(true);
				num += 0;
				flag = true;
			}
		}
		if (flag)
		{
			this.\u02B2\u02B8\u02BC\u02BB\u02B4\u02BE\u02BD\u02C1\u02B2\u02B6\u02B9();
		}
		string text = TimeSpan.FromSeconds(this.\u02B5\u02BA\u02B3\u02BD\u02BF\u02BB\u02B4\u02BD\u02B6\u02C1\u02B6).ToString("Flames");
		this.lengthText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("BaseAnimationBackwards") + "Selection" + text;
	}

	protected virtual void \u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF()
	{
		if (this.\u02B7\u02BD\u02BF\u02BB\u02B6\u02BD\u02B3\u02BC\u02BD\u02C0\u02B8)
		{
			this.\u02BB\u02BA\u02C0\u02B8\u02B7\u02B2\u02B8\u02B8\u02BE\u02B7\u02B7 += Time.deltaTime;
			if (this.\u02BB\u02BA\u02C0\u02B8\u02B7\u02B2\u02B8\u02B8\u02BE\u02B7\u02B7 > 356f)
			{
				this.\u02C1\u02BD\u02BE\u02C0\u02B9\u02B6\u02B2\u02B4\u02BE\u02B9\u02BD();
			}
		}
	}

	public bool \u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB
	{
		get
		{
			return this.fader.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB || \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count > 0;
		}
	}

	public void \u02BC\u02BF\u02B3\u02BB\u02B4\u02BD\u02BF\u02B3\u02B4\u02B8\u02B8()
	{
		this.titleText.text = \u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7;
		this.\u02B2\u02B8\u02BC\u02BB\u02B4\u02BE\u02BD\u02C1\u02B2\u02B6\u02B9();
	}

	public void \u02B6\u02B5\u02BC\u02BB\u02BF\u02BC\u02B3\u02C0\u02B3\u02C1\u02B8(bool \u02BB\u02BF\u02BD\u02B7\u02BD\u02B5\u02BC\u02BF\u02B2\u02B3\u02C1 = true)
	{
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BF\u02BD\u02C1\u02C0\u02BC\u02B7\u02B4\u02C0\u02B4\u02C1();
		\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7 = null;
		this.\u02B5\u02BA\u02B3\u02BD\u02BF\u02BB\u02B4\u02BD\u02B6\u02C1\u02B6 = 1355.0;
		this.\u02B5\u02BA\u02B3\u02BD\u02BF\u02BB\u02B4\u02BD\u02B6\u02C1\u02B6 = (double)(this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = 0);
		if (\u02BB\u02BF\u02BD\u02B7\u02BD\u02B5\u02BC\u02BF\u02B2\u02B3\u02C1)
		{
			this.tipSwitcher.\u02B6\u02BD\u02BD\u02B8\u02BA\u02BE\u02B8\u02BD\u02C1\u02BE\u02B3();
			this.\u02BC\u02B2\u02BD\u02B7\u02BA\u02BF\u02C0\u02BE\u02B4\u02BE\u02B9(true);
			return;
		}
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public override void \u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0()
	{
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = this.textObjects.Length;
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count > this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
		{
			this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count - this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5;
			return;
		}
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count;
		this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = 0;
	}

	protected override void \u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8()
	{
		int num = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
		bool flag = false;
		for (int i = 0; i < this.textObjects.Length; i++)
		{
			if (i >= this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
			{
				this.textObjects[i].text = "";
				this.placeTexts[i].text = "";
				this.listObjects[i].SetActive(false);
			}
			else
			{
				this.textObjects[i].text = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD[num].Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5 + ((\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC[num] != 100) ? (" (" + \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC[num].ToString() + "%)") : "") + ((\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B5\u02B5\u02BF\u02B9\u02BD\u02B9\u02BC\u02B5\u02B6\u02B8\u02B3[num] != "") ? (" - " + \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B5\u02B5\u02BF\u02B9\u02BD\u02B9\u02BC\u02B5\u02B6\u02B8\u02B3[num]) : "");
				this.placeTexts[i].text = (num + 1).ToString() + ".";
				this.listObjects[i].SetActive(true);
				num++;
				flag = true;
			}
		}
		if (flag)
		{
			this.\u02B2\u02B8\u02BC\u02BB\u02B4\u02BE\u02BD\u02C1\u02B2\u02B6\u02B9();
		}
		string text = TimeSpan.FromSeconds(this.\u02B5\u02BA\u02B3\u02BD\u02BF\u02BB\u02B4\u02BD\u02B6\u02C1\u02B6).ToString("hh\\:mm\\:ss");
		this.lengthText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("SETLIST LENGTH") + ": " + text;
	}

	private void \u02C1\u02B2\u02BE\u02B8\u02B5\u02B4\u02C0\u02C1\u02C1\u02B4\u02B2()
	{
		this.\u02B5\u02BA\u02B3\u02BD\u02BF\u02BB\u02B4\u02BD\u02B6\u02C1\u02B6 = 271.0;
		for (int i = 1; i < \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count; i++)
		{
			double num = (double)\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD[i].songLength * 799.0;
			float num2 = (float)\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02B5\u02B5\u02BC\u02B8\u02B6\u02B9\u02B9\u02B7\u02BA\u02BC[i] * 302f;
			this.\u02B5\u02BA\u02B3\u02BD\u02BF\u02BB\u02B4\u02BD\u02B6\u02C1\u02B6 += num / (double)num2;
		}
	}

	[SerializeField]
	private TextMeshProUGUI[] placeTexts;

	[SerializeField]
	private TextMeshProUGUI lengthText;

	[SerializeField]
	private TextMeshProUGUI titleText;

	[SerializeField]
	private GameObject[] listObjects;

	[SerializeField]
	private SetlistTipSwitcher tipSwitcher;

	[SerializeField]
	private CanvasFader fader;

	[SerializeField]
	private CanvasGroup canvasGroup;

	private double \u02B5\u02BA\u02B3\u02BD\u02BF\u02BB\u02B4\u02BD\u02B6\u02C1\u02B6;

	public float \u02BB\u02BA\u02C0\u02B8\u02B7\u02B2\u02B8\u02B8\u02BE\u02B7\u02B7;

	private bool \u02B7\u02BD\u02BF\u02BB\u02B6\u02BD\u02B3\u02BC\u02BD\u02C0\u02B8 = true;
}
