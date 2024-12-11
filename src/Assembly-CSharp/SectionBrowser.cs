﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SectionBrowser : BaseMenu
{
	public virtual void \u02B9\u02BC\u02B7\u02B4\u02B5\u02C0\u02B7\u02C0\u02B5\u02BA\u02B5()
	{
		if (!\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02BD\u02C1\u02C0\u02B4\u02B7\u02BE\u02BF\u02BD\u02B7\u02B7 && !this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6 && !this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB && !this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9)
		{
			return;
		}
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
	}

	public override void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		if (!\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02BD\u02C1\u02C0\u02B4\u02B7\u02BE\u02BF\u02BD\u02B7\u02B7 && !this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6 && !this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB && !this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9)
		{
			return;
		}
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
	}

	public void \u02C0\u02B4\u02BC\u02C0\u02B3\u02B4\u02BB\u02B8\u02BD\u02B4\u02B7()
	{
		this.\u02C0\u02B4\u02B7\u02BC\u02B8\u02B3\u02BB\u02B4\u02B7\u02C1\u02B9();
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		base.gameObject.SetActive(false);
	}

	public void \u02B2\u02B6\u02C1\u02BE\u02BD\u02B2\u02C1\u02BA\u02BC\u02BB\u02B8(bool \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5)
	{
		this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6 = true;
		this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB = false;
		this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9 = true;
		this.\u02BF\u02BA\u02B8\u02B7\u02C1\u02B9\u02B9\u02B7\u02C1\u02B8\u02BA = \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5;
		this.menuStrings = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B2\u02BB\u02B2\u02BD\u02BA\u02C0\u02B2\u02B5\u02BC\u02B8;
		this.allowMultiLanguage = false;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF);
		this.\u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
	}

	public void \u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, bool \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5)
	{
		this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6 = false;
		this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB = false;
		this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9 = false;
		this.\u02BF\u02BA\u02B8\u02B7\u02C1\u02B9\u02B9\u02B7\u02C1\u02B8\u02BA = \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5;
		this.allowMultiLanguage = false;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, true);
		this.\u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
	}

	public virtual void \u02BA\u02BE\u02B2\u02B5\u02B3\u02BD\u02BB\u02B2\u02C0\u02BC\u02B9()
	{
		if (!\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02BD\u02C1\u02C0\u02B4\u02B7\u02BE\u02BF\u02BD\u02B7\u02B7 && !this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6 && !this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB && !this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9)
		{
			return;
		}
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
	}

	public override void \u02C1\u02B6\u02BD\u02BC\u02BC\u02B3\u02BF\u02BF\u02C0\u02C1\u02BC()
	{
		if (this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6)
		{
			if (base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC == 0)
			{
				this.\u02BF\u02BB\u02B6\u02C0\u02B8\u02BE\u02B9\u02B4\u02C1\u02B5\u02BD(this.\u02BF\u02BA\u02B8\u02B7\u02C1\u02B9\u02B9\u02B7\u02C1\u02B8\u02BA);
				return;
			}
			this.\u02B7\u02C0\u02B7\u02B2\u02C0\u02BA\u02BC\u02BE\u02B9\u02B6\u02C1(this.\u02BF\u02BA\u02B8\u02B7\u02C1\u02B9\u02B9\u02B7\u02C1\u02B8\u02BA);
			return;
		}
		else
		{
			if (this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB)
			{
				this.\u02B3\u02B4\u02B2\u02BF\u02B7\u02BF\u02C1\u02B9\u02BF\u02B9\u02BD();
				return;
			}
			if (!this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9)
			{
				this.\u02BC\u02B4\u02B6\u02C1\u02BC\u02B8\u02C0\u02B4\u02B9\u02B4\u02BB();
				return;
			}
			if (base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC == 0)
			{
				this.songSelect.\u02BF\u02B5\u02BE\u02BD\u02B8\u02BF\u02B4\u02B6\u02BB\u02B6\u02BD();
				return;
			}
			if (base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC == 1)
			{
				this.songSelect.\u02B8\u02B5\u02BE\u02B7\u02B2\u02BF\u02B3\u02B3\u02BA\u02BF\u02BC();
				return;
			}
			this.\u02B2\u02B8\u02C0\u02BE\u02BE\u02B9\u02BA\u02BA\u02BE\u02BF\u02BA();
			return;
		}
	}

	private void \u02C1\u02BF\u02B7\u02BC\u02B4\u02C1\u02BF\u02B5\u02B5\u02BC\u02C1()
	{
		this.songSelect.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0);
		base.gameObject.SetActive(true);
	}

	private void \u02BC\u02B4\u02B6\u02C1\u02BC\u02B8\u02C0\u02B4\u02B9\u02B4\u02BB()
	{
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02BD\u02C1\u02C0\u02B4\u02B7\u02BE\u02BF\u02BD\u02B7\u02B7)
		{
			\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8 u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC];
			this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE ? u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B7\u02BD\u02B4\u02C0\u02B9\u02B3\u02BA\u02B7\u02B2\u02BE\u02B3 : (u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B7\u02BD\u02B4\u02C0\u02B9\u02B3\u02BA\u02B7\u02B2\u02BE\u02B3 + 1), true);
		}
		base.gameObject.SetActive(false);
	}

	public void \u02BF\u02B9\u02B2\u02B3\u02B9\u02BA\u02BB\u02B2\u02BE\u02B9\u02BD(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, bool \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5)
	{
		this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6 = false;
		this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB = true;
		this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9 = true;
		this.\u02BF\u02BA\u02B8\u02B7\u02C1\u02B9\u02B9\u02B7\u02C1\u02B8\u02BA = \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5;
		this.allowMultiLanguage = true;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, true);
		this.\u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
	}

	public void \u02B7\u02C0\u02B7\u02B2\u02C0\u02BA\u02BC\u02BE\u02B9\u02B6\u02C1(bool \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5)
	{
		this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6 = false;
		this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9 = true;
		this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB = false;
		this.\u02BF\u02BA\u02B8\u02B7\u02C1\u02B9\u02B9\u02B7\u02C1\u02B8\u02BA = \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5;
		this.\u02B3\u02B4\u02BC\u02B6\u02B8\u02C1\u02B5\u02B6\u02B4\u02B6\u02B5();
		this.allowMultiLanguage = false;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
		this.\u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
	}

	public virtual void \u02BF\u02BC\u02B2\u02BD\u02BC\u02B8\u02B9\u02B5\u02B5\u02BA\u02B3()
	{
		if (!this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB || this.\u02BF\u02BA\u02B8\u02B7\u02C1\u02B9\u02B9\u02B7\u02C1\u02B8\u02BA)
		{
			return;
		}
		this.\u02C1\u02BF\u02B7\u02BC\u02B4\u02C1\u02BF\u02B5\u02B5\u02BC\u02C1();
	}

	public override void \u02BF\u02BB\u02BC\u02BC\u02B8\u02C1\u02B9\u02BC\u02B6\u02BA\u02B6()
	{
		if (!this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB || this.\u02BF\u02BA\u02B8\u02B7\u02C1\u02B9\u02B9\u02B7\u02C1\u02B8\u02BA)
		{
			return;
		}
		this.\u02B3\u02B4\u02B2\u02BF\u02B7\u02BF\u02C1\u02B9\u02BF\u02B9\u02BD();
	}

	public override void \u02B6\u02BE\u02B5\u02C1\u02B6\u02B6\u02B5\u02B3\u02BE\u02B4\u02B7()
	{
		if (this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB || this.\u02BF\u02BA\u02B8\u02B7\u02C1\u02B9\u02B9\u02B7\u02C1\u02B8\u02BA)
		{
			return;
		}
		this.\u02BC\u02B4\u02B6\u02C1\u02BC\u02B8\u02C0\u02B4\u02B9\u02B4\u02BB();
	}

	public void \u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD(bool \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5)
	{
		this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6 = true;
		this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB = false;
		this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9 = false;
		this.\u02BF\u02BA\u02B8\u02B7\u02C1\u02B9\u02B9\u02B7\u02C1\u02B8\u02BA = \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5;
		this.menuStrings = SectionBrowser.\u02BA\u02B3\u02B5\u02C0\u02BA\u02B9\u02B2\u02BE\u02B2\u02B3\u02B3;
		this.allowMultiLanguage = true;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
		this.\u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
	}

	private void \u02C1\u02B3\u02B8\u02BF\u02B2\u02BC\u02B2\u02B7\u02B6\u02BB\u02B2()
	{
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02BB\u02B8\u02BF\u02B2\u02B7\u02B2\u02B2\u02B8\u02B4\u02B2(base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7()))
		{
			this.songSelect.\u02B3\u02BE\u02B6\u02BC\u02B7\u02BD\u02BC\u02C1\u02BB\u02B4\u02B7(base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0);
		}
		else
		{
			this.songSelect.\u02B7\u02C1\u02BA\u02B9\u02BB\u02B7\u02B2\u02B6\u02C0\u02B6\u02BA(base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7());
		}
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	private void \u02BF\u02B4\u02B5\u02BA\u02BE\u02B4\u02B6\u02BB\u02B9\u02B7\u02B2()
	{
		this.songSelect.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7());
		base.gameObject.SetActive(false);
	}

	public override void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		if (!\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02BD\u02C1\u02C0\u02B4\u02B7\u02BE\u02BF\u02BD\u02B7\u02B7 && !this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6 && !this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB && !this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9)
		{
			return;
		}
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
	}

	private void \u02BC\u02B7\u02B6\u02B7\u02BE\u02BB\u02BF\u02B6\u02BF\u02B2\u02C0()
	{
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02BD\u02C1\u02C0\u02B4\u02B7\u02BE\u02BF\u02BD\u02B7\u02B7)
		{
			\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8 u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC];
			this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE ? u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B7\u02BD\u02B4\u02C0\u02B9\u02B3\u02BA\u02B7\u02B2\u02BE\u02B3 : (u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B7\u02BD\u02B4\u02C0\u02B9\u02B3\u02BA\u02B7\u02B2\u02BE\u02B3 + 1), true);
		}
		base.gameObject.SetActive(true);
	}

	private void \u02B3\u02B4\u02B2\u02BF\u02B7\u02BF\u02C1\u02B9\u02BF\u02B9\u02BD()
	{
		this.songSelect.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0);
		base.gameObject.SetActive(false);
	}

	private void \u02B7\u02BD\u02B7\u02B3\u02BA\u02B4\u02B7\u02BD\u02B6\u02C1\u02B8()
	{
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02BD\u02C1\u02C0\u02B4\u02B7\u02BE\u02BF\u02BD\u02B7\u02B7)
		{
			\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8 u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC];
			this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE ? u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B7\u02BD\u02B4\u02C0\u02B9\u02B3\u02BA\u02B7\u02B2\u02BE\u02B3 : (u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B7\u02BD\u02B4\u02C0\u02B9\u02B3\u02BA\u02B7\u02B2\u02BE\u02B3 + 1), false);
		}
		base.gameObject.SetActive(true);
	}

	public void \u02BF\u02BB\u02B6\u02C0\u02B8\u02BE\u02B9\u02B4\u02C1\u02B5\u02BD(bool \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5)
	{
		this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6 = false;
		this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB = true;
		this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9 = false;
		this.\u02BF\u02BA\u02B8\u02B7\u02C1\u02B9\u02B9\u02B7\u02C1\u02B8\u02BA = \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5;
		this.menuStrings = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B2\u02BB\u02B2\u02BD\u02BA\u02C0\u02B2\u02B5\u02BC\u02B8;
		this.allowMultiLanguage = true;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF);
		this.\u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
	}

	public override void \u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0()
	{
		if (this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB || this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9 || this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6)
		{
			base.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
			return;
		}
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = this.textObjects.Length;
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6.Count > this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
		{
			this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6.Count - this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5;
			return;
		}
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6.Count;
		this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = 0;
	}

	public void \u02B7\u02BF\u02B8\u02BF\u02B8\u02BF\u02B4\u02B2\u02BC\u02B4\u02BE()
	{
		this.\u02B3\u02B4\u02BC\u02B6\u02B8\u02C1\u02B5\u02B6\u02B4\u02B6\u02B5();
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public virtual void \u02B7\u02C1\u02BD\u02B4\u02B8\u02B4\u02B9\u02BC\u02B8\u02B8\u02B7()
	{
		if (!\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02BD\u02C1\u02C0\u02B4\u02B7\u02BE\u02BF\u02BD\u02B7\u02B7 && !this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6 && !this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB && !this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9)
		{
			return;
		}
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
	}

	public virtual void \u02B7\u02B6\u02B8\u02BA\u02BC\u02BD\u02B9\u02B4\u02B2\u02B8\u02BB()
	{
		base.gameObject.SetActive(true);
	}

	public void \u02B3\u02B4\u02BC\u02B6\u02B8\u02C1\u02B5\u02B6\u02B4\u02B6\u02B5()
	{
		List<string> list = new List<string>(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B5\u02BE\u02B2\u02B6\u02B4\u02BD\u02BC\u02BE\u02B2\u02B4);
		int num = 2;
		foreach (string text in \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BA\u02B5\u02C0\u02BE\u02BC\u02B5\u02BA\u02B2\u02B7\u02C0\u02B3)
		{
			if (!list.Contains(text))
			{
				list.Insert(num, text);
				num++;
			}
		}
		this.menuStrings = list.ToArray();
	}

	public void \u02C0\u02B4\u02B7\u02BC\u02B8\u02B3\u02BB\u02B4\u02B7\u02C1\u02B9()
	{
		List<string> list = new List<string>(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B5\u02BE\u02B2\u02B6\u02B4\u02BD\u02BC\u02BE\u02B2\u02B4);
		int num = 0;
		foreach (string text in \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BA\u02B5\u02C0\u02BE\u02BC\u02B5\u02BA\u02B2\u02B7\u02C0\u02B3)
		{
			if (!list.Contains(text))
			{
				list.Insert(num, text);
				num += 0;
			}
		}
		this.menuStrings = list.ToArray();
	}

	protected virtual void \u02B6\u02BC\u02B5\u02BD\u02B3\u02BC\u02C1\u02B4\u02BD\u02BC\u02B2()
	{
		if (this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB || this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6)
		{
			base.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			for (int i = 0; i < this.backgroundObjects.Length; i++)
			{
				this.backgroundObjects[i].enabled = false;
			}
			for (int j = 1; j < this.textObjects.Length; j++)
			{
				if (this.textObjects[j].text == "song")
				{
					this.textObjects[j].text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Video Start Time") + "highway.webm" + LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("");
				}
			}
			return;
		}
		if (this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9)
		{
			base.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			for (int k = 1; k < this.backgroundObjects.Length; k++)
			{
				this.backgroundObjects[k].enabled = true;
			}
			for (int l = 0; l < this.textObjects.Length; l++)
			{
				if (this.textObjects[l] != null && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B9\u02BC\u02B6\u02B8\u02B2\u02B3\u02BD\u02BC\u02BF\u02B3\u02BD.Contains(this.textObjects[l].text))
				{
					this.textObjects[l].text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().GetString(this.textObjects[l].text);
				}
				if (l != this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 && this.textObjects[l] != null && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02BB\u02B8\u02BF\u02B2\u02B7\u02B2\u02B2\u02B8\u02B4\u02B2(this.textObjects[l].text))
				{
					Color highlightColor = this.highlightColor;
					highlightColor.a = 1683f;
					this.backgroundObjects[l].enabled = true;
					this.backgroundObjects[l].color = highlightColor;
				}
			}
			return;
		}
		for (int m = 1; m < this.textObjects.Length; m++)
		{
			if (m >= this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
			{
				this.textObjects[m].text = "master_volume";
				this.backgroundObjects[m].enabled = true;
			}
			else
			{
				this.textObjects[m].text = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6[m + this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7].\u02B8\u02BD\u02B5\u02BB\u02BC\u02B7\u02BE\u02C0\u02BD\u02BA\u02B5().ToUpperInvariant();
				this.backgroundObjects[m].enabled = false;
				Color defaultColor = this.defaultColor;
				defaultColor.a = 165f;
				Color highlightColor2 = this.highlightColor;
				highlightColor2.a = 611f;
				if (m == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3)
				{
					if (this.backgroundObjects != null && this.backgroundObjects.Length != 0)
					{
						Image[] backgroundObjects = this.backgroundObjects;
						if (((backgroundObjects != null) ? backgroundObjects[m] : null) != null)
						{
							this.backgroundObjects[m].color = this.defaultColor;
						}
					}
					if (this.textObjects[m] != null)
					{
						this.textObjects[m].color = highlightColor2;
					}
				}
				else
				{
					if (this.backgroundObjects != null && this.backgroundObjects.Length != 0)
					{
						Image[] backgroundObjects2 = this.backgroundObjects;
						if (((backgroundObjects2 != null) ? backgroundObjects2[m] : null) != null)
						{
							this.backgroundObjects[m].color = this.highlightColor;
						}
					}
					if (this.textObjects[m] != null)
					{
						this.textObjects[m].color = defaultColor;
					}
				}
			}
		}
	}

	public virtual void \u02B4\u02B4\u02B8\u02BF\u02B3\u02BC\u02BD\u02BC\u02B9\u02BB\u02BD()
	{
		if (this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB || this.\u02BF\u02BA\u02B8\u02B7\u02C1\u02B9\u02B9\u02B7\u02C1\u02B8\u02BA)
		{
			return;
		}
		this.\u02B7\u02BD\u02B7\u02B3\u02BA\u02B4\u02B7\u02BD\u02B6\u02C1\u02B8();
	}

	protected override void \u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8()
	{
		if (this.\u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB || this.\u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6)
		{
			base.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			for (int i = 0; i < this.backgroundObjects.Length; i++)
			{
				this.backgroundObjects[i].enabled = true;
			}
			for (int j = 0; j < this.textObjects.Length; j++)
			{
				if (this.textObjects[j].text == "Artist - Album")
				{
					this.textObjects[j].text = LanguageManager.instance.GetString("Artist") + " - " + LanguageManager.instance.GetString("Album");
				}
			}
			return;
		}
		if (this.\u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9)
		{
			base.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			for (int k = 0; k < this.backgroundObjects.Length; k++)
			{
				this.backgroundObjects[k].enabled = true;
			}
			for (int l = 0; l < this.textObjects.Length; l++)
			{
				if (this.textObjects[l] != null && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B9\u02BC\u02B6\u02B8\u02B2\u02B3\u02BD\u02BC\u02BF\u02B3\u02BD.Contains(this.textObjects[l].text))
				{
					this.textObjects[l].text = LanguageManager.instance.GetString(this.textObjects[l].text);
				}
				if (l != this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 && this.textObjects[l] != null && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02BB\u02B8\u02BF\u02B2\u02B7\u02B2\u02B2\u02B8\u02B4\u02B2(this.textObjects[l].text))
				{
					Color highlightColor = this.highlightColor;
					highlightColor.a = 0.75f;
					this.backgroundObjects[l].enabled = true;
					this.backgroundObjects[l].color = highlightColor;
				}
			}
			return;
		}
		for (int m = 0; m < this.textObjects.Length; m++)
		{
			if (m >= this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
			{
				this.textObjects[m].text = "";
				this.backgroundObjects[m].enabled = false;
			}
			else
			{
				this.textObjects[m].text = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6[m + this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7].\u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD.ToUpperInvariant();
				this.backgroundObjects[m].enabled = true;
				Color defaultColor = this.defaultColor;
				defaultColor.a = 1f;
				Color highlightColor2 = this.highlightColor;
				highlightColor2.a = 1f;
				if (m == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3)
				{
					if (this.backgroundObjects != null && this.backgroundObjects.Length != 0)
					{
						Image[] backgroundObjects = this.backgroundObjects;
						if (((backgroundObjects != null) ? backgroundObjects[m] : null) != null)
						{
							this.backgroundObjects[m].color = this.defaultColor;
						}
					}
					if (this.textObjects[m] != null)
					{
						this.textObjects[m].color = highlightColor2;
					}
				}
				else
				{
					if (this.backgroundObjects != null && this.backgroundObjects.Length != 0)
					{
						Image[] backgroundObjects2 = this.backgroundObjects;
						if (((backgroundObjects2 != null) ? backgroundObjects2[m] : null) != null)
						{
							this.backgroundObjects[m].color = this.highlightColor;
						}
					}
					if (this.textObjects[m] != null)
					{
						this.textObjects[m].color = defaultColor;
					}
				}
			}
		}
	}

	private void \u02B2\u02B8\u02C0\u02BE\u02BE\u02B9\u02BA\u02BA\u02BE\u02BF\u02BA()
	{
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02BB\u02B8\u02BF\u02B2\u02B7\u02B2\u02B2\u02B8\u02B4\u02B2(base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0))
		{
			this.songSelect.\u02B6\u02BD\u02C1\u02B8\u02C1\u02B6\u02B6\u02BA\u02B3\u02BE\u02B8(base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0);
		}
		else
		{
			this.songSelect.\u02B7\u02C1\u02BA\u02B9\u02BB\u02B7\u02B2\u02B6\u02C0\u02B6\u02BA(base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0);
		}
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	[SerializeField]
	private SongSelect songSelect;

	private static string[] \u02BA\u02B3\u02B5\u02C0\u02BA\u02B9\u02B2\u02BE\u02B2\u02B3\u02B3 = new string[] { "Sort Options", "Filter Options" };

	private bool \u02B8\u02BE\u02BC\u02BC\u02B4\u02BD\u02B7\u02B7\u02B8\u02B3\u02BB;

	private bool \u02B5\u02B3\u02B5\u02B2\u02B9\u02B4\u02C0\u02BA\u02B6\u02B2\u02B9;

	private bool \u02C1\u02BF\u02BC\u02BD\u02B5\u02B7\u02BE\u02BB\u02B7\u02BD\u02B6;

	private bool \u02BF\u02BA\u02B8\u02B7\u02C1\u02B9\u02B9\u02B7\u02C1\u02B8\u02BA;
}
