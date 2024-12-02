﻿using System;
using System.Linq;
using StrikeCore;
using UnityEngine;

public class StarProgress : MonoBehaviour
{
	public void \u02B5\u02BB\u02B9\u02B7\u02B9\u02BA\u02BD\u02BF\u02B6\u02B4\u02BE()
	{
		this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 = 0;
		this.\u02B5\u02B4\u02BA\u02BC\u02B3\u02C1\u02B8\u02B3\u02BB\u02BB\u02C1 = 1;
		this.\u02BD\u02B7\u02B3\u02C0\u02BC\u02BC\u02B7\u02B3\u02BE\u02BD\u02B2 = 0;
		this.\u02B8\u02B3\u02C1\u02B7\u02BA\u02B9\u02BA\u02BA\u02BA\u02B2\u02C1.sprite = (this.\u02B7\u02C0\u02BA\u02BF\u02BB\u02C1\u02C0\u02BD\u02B7\u02BB\u02B3.sprite = null);
	}

	public void \u02BD\u02B2\u02BA\u02C1\u02BD\u02B2\u02C0\u02B6\u02B7\u02BF\u02B5(int \u02B3\u02C0\u02BB\u02B3\u02B7\u02BB\u02BE\u02B8\u02B6\u02B6\u02B8)
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			return;
		}
		this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC += \u02B3\u02C0\u02BB\u02B3\u02B7\u02BB\u02BE\u02B8\u02B6\u02B6\u02B8;
		this.Reset();
		for (int i = 1; i < this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2.Length; i++)
		{
			this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2[i] = Mathf.CeilToInt((float)this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC * StarProgress.\u02B3\u02B3\u02B5\u02B7\u02BA\u02B3\u02BD\u02C0\u02BD\u02B8\u02C1[i]);
		}
	}

	public void \u02C0\u02B4\u02BA\u02B9\u02B2\u02BD\u02B9\u02BD\u02B4\u02B8\u02BA()
	{
		this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 = 1;
		this.\u02B5\u02B4\u02BA\u02BC\u02B3\u02C1\u02B8\u02B3\u02BB\u02BB\u02C1 = 0;
		this.\u02BD\u02B7\u02B3\u02C0\u02BC\u02BC\u02B7\u02B3\u02BE\u02BD\u02B2 = 0;
		this.\u02B8\u02B3\u02C1\u02B7\u02BA\u02B9\u02BA\u02BA\u02BA\u02B2\u02C1.sprite = (this.\u02B7\u02C0\u02BA\u02BF\u02BB\u02C1\u02C0\u02BD\u02B7\u02BB\u02B3.sprite = null);
	}

	public void \u02BE\u02B7\u02B4\u02BC\u02C1\u02B3\u02BB\u02B2\u02B4\u02BF\u02B2()
	{
		this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 = 0;
		this.\u02B5\u02B4\u02BA\u02BC\u02B3\u02C1\u02B8\u02B3\u02BB\u02BB\u02C1 = 1;
		this.\u02BD\u02B7\u02B3\u02C0\u02BC\u02BC\u02B7\u02B3\u02BE\u02BD\u02B2 = 1;
		this.\u02B8\u02B3\u02C1\u02B7\u02BA\u02B9\u02BA\u02BA\u02BA\u02B2\u02C1.sprite = (this.\u02B7\u02C0\u02BA\u02BF\u02BB\u02C1\u02C0\u02BD\u02B7\u02BB\u02B3.sprite = null);
	}

	public void \u02B5\u02C0\u02BD\u02B3\u02BA\u02C0\u02BB\u02BA\u02BE\u02B9\u02BE()
	{
		this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 = 0;
		this.\u02B5\u02B4\u02BA\u02BC\u02B3\u02C1\u02B8\u02B3\u02BB\u02BB\u02C1 = 0;
		this.\u02BD\u02B7\u02B3\u02C0\u02BC\u02BC\u02B7\u02B3\u02BE\u02BD\u02B2 = 0;
		this.\u02B8\u02B3\u02C1\u02B7\u02BA\u02B9\u02BA\u02BA\u02BA\u02B2\u02C1.sprite = (this.\u02B7\u02C0\u02BA\u02BF\u02BB\u02C1\u02C0\u02BD\u02B7\u02BB\u02B3.sprite = null);
	}

	public void \u02B4\u02BC\u02BA\u02B2\u02B2\u02B4\u02BC\u02C0\u02BC\u02B2\u02BD(int \u02B3\u02C0\u02BB\u02B3\u02B7\u02BB\u02BE\u02B8\u02B6\u02B6\u02B8)
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			return;
		}
		this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC += \u02B3\u02C0\u02BB\u02B3\u02B7\u02BB\u02BE\u02B8\u02B6\u02B6\u02B8;
		this.\u02C0\u02B4\u02BA\u02B9\u02B2\u02BD\u02B9\u02BD\u02B4\u02B8\u02BA();
		for (int i = 1; i < this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2.Length; i += 0)
		{
			this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2[i] = Mathf.CeilToInt((float)this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC * StarProgress.\u02B3\u02B3\u02B5\u02B7\u02BA\u02B3\u02BD\u02C0\u02BD\u02B8\u02C1[i]);
		}
	}

	public void Start()
	{
		this.sr = this.\u02B8\u02BB\u02B2\u02BE\u02B2\u02BA\u02BE\u02B9\u02C1\u02B3\u02B2.gameObject.GetComponent<SpriteRenderer>();
		Debug.Log(this.sr.color.ToString() + " starprogress");
		this.origColor = this.sr.color;
		this.\u02B8\u02B3\u02C1\u02B7\u02BA\u02B9\u02BA\u02BA\u02BA\u02B2\u02C1.sprite = (this.\u02B7\u02C0\u02BA\u02BF\u02BB\u02C1\u02C0\u02BD\u02B7\u02BB\u02B3.sprite = null);
		this.\u02B7\u02B2\u02B3\u02B2\u02BD\u02BC\u02BD\u02B4\u02B6\u02BE\u02BD -= this.\u02B7\u02B4\u02C1\u02C1\u02BC\u02B2\u02BC\u02BD\u02B8\u02BF\u02BC;
		this.\u02C0\u02B7\u02B2\u02BE\u02B9\u02BF\u02C0\u02BB\u02C0\u02BA\u02BA = this.\u02C1\u02BE\u02B8\u02B3\u02B3\u02BD\u02B6\u02BB\u02BA\u02BD\u02B6.localPosition.y;
		if (!SettingsController.\u02C1\u02BF\u02B3\u02BF\u02C1\u02BC\u02BC\u02BA\u02BF\u02BD\u02BE)
		{
			this.v = this.starParticles.emission;
			this.v.enabled = false;
		}
	}

	public void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		this.\u02B8\u02B3\u02C1\u02B7\u02BA\u02B9\u02BA\u02BA\u02BA\u02B2\u02C1.sprite = (this.\u02B7\u02C0\u02BA\u02BF\u02BB\u02C1\u02C0\u02BD\u02B7\u02BB\u02B3.sprite = null);
		this.\u02B7\u02B2\u02B3\u02B2\u02BD\u02BC\u02BD\u02B4\u02B6\u02BE\u02BD -= this.\u02B7\u02B4\u02C1\u02C1\u02BC\u02B2\u02BC\u02BD\u02B8\u02BF\u02BC;
		this.\u02C0\u02B7\u02B2\u02BE\u02B9\u02BF\u02C0\u02BB\u02C0\u02BA\u02BA = this.\u02C1\u02BE\u02B8\u02B3\u02B3\u02BD\u02B6\u02BB\u02BA\u02BD\u02B6.localPosition.y;
		if (!SettingsController.\u02C1\u02BF\u02B3\u02BF\u02C1\u02BC\u02BC\u02BA\u02BF\u02BD\u02BE)
		{
			this.starParticles.emission.enabled = false;
		}
	}

	public void Reset()
	{
		this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 = 0;
		this.\u02B5\u02B4\u02BA\u02BC\u02B3\u02C1\u02B8\u02B3\u02BB\u02BB\u02C1 = 0;
		this.\u02BD\u02B7\u02B3\u02C0\u02BC\u02BC\u02B7\u02B3\u02BE\u02BD\u02B2 = 0;
		this.\u02B8\u02B3\u02C1\u02B7\u02BA\u02B9\u02BA\u02BA\u02BA\u02B2\u02C1.sprite = (this.\u02B7\u02C0\u02BA\u02BF\u02BB\u02C1\u02C0\u02BD\u02B7\u02BB\u02B3.sprite = null);
	}

	public void \u02BD\u02BA\u02B5\u02B9\u02C1\u02BE\u02BA\u02BF\u02B9\u02B7\u02B8(int \u02B3\u02C0\u02BB\u02B3\u02B7\u02BB\u02BE\u02B8\u02B6\u02B6\u02B8)
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			return;
		}
		this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC += \u02B3\u02C0\u02BB\u02B3\u02B7\u02BB\u02BE\u02B8\u02B6\u02B6\u02B8;
		this.Reset();
		for (int i = 0; i < this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2.Length; i++)
		{
			this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2[i] = Mathf.CeilToInt((float)this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC * StarProgress.\u02B3\u02B3\u02B5\u02B7\u02BA\u02B3\u02BD\u02C0\u02BD\u02B8\u02C1[i]);
		}
	}

	public void \u02BA\u02BD\u02B8\u02BA\u02BE\u02C0\u02B2\u02BE\u02B9\u02B2\u02BB(int \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		this.ticker += Time.deltaTime;
		if (this.ticker > 0.3f)
		{
			this.ticker -= 0.3f;
			HexColor hexColor = HexColor.FromHexString(GlobalHelper.starProgressColor);
			Color col = new Color((float)hexColor.Red / 255f, (float)hexColor.Green / 255f, (float)hexColor.Blue / 255f, 1f);
			if (col == new Color(1f, 1f, 1f, 1f))
			{
				col = this.origColor;
			}
			if (col == Color.black)
			{
				col = Color.clear;
			}
			this.sr.color = col;
		}
		if (this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2 == null)
		{
			return;
		}
		if (this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 == this.\u02BF\u02B3\u02B6\u02BF\u02B9\u02B4\u02B9\u02BF\u02C0\u02BE\u02C1)
		{
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 == this.\u02BF\u02BD\u02BF\u02B7\u02B3\u02B3\u02BB\u02B3\u02B7\u02BF\u02BB)
		{
			return;
		}
		int num = this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2[this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3];
		this.\u02BF\u02BD\u02BF\u02B7\u02B3\u02B3\u02BB\u02B3\u02B7\u02BF\u02BB = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
		while (this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 < this.\u02BF\u02B3\u02B6\u02BF\u02B9\u02B4\u02B9\u02BF\u02C0\u02BE\u02C1 && \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 >= num)
		{
			this.\u02BD\u02B7\u02B3\u02C0\u02BC\u02BC\u02B7\u02B3\u02BE\u02BD\u02B2 = num;
			int[] u02BE_u02B2_u02BA_u02B3_u02BD_u02BD_u02BF_u02BA_u02B7_u02B4_u02B = this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2;
			int num2 = this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 + 1;
			this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 = num2;
			num = u02BE_u02B2_u02BA_u02B3_u02BD_u02BD_u02BF_u02BA_u02B7_u02B4_u02B[num2];
			this.\u02B8\u02B3\u02C1\u02B7\u02BA\u02B9\u02BA\u02BA\u02BA\u02B2\u02C1.sprite = (this.\u02B7\u02C0\u02BA\u02BF\u02BB\u02C1\u02C0\u02BD\u02B7\u02BB\u02B3.sprite = this.\u02BC\u02BA\u02B3\u02B8\u02BD\u02B6\u02BB\u02BC\u02B6\u02B9\u02B7[this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3]);
			this.starParticles.Play();
			if (this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 == this.\u02BF\u02B3\u02B6\u02BF\u02B9\u02B4\u02B9\u02BF\u02C0\u02BE\u02C1)
			{
				this.\u02B8\u02BB\u02B2\u02BE\u02B2\u02BA\u02BE\u02B9\u02C1\u02B3\u02B2.localScale = new Vector3(this.\u02BE\u02B4\u02BB\u02BE\u02BC\u02C0\u02B3\u02BB\u02B7\u02B5\u02B4, 0.15f, 1f);
				this.\u02C1\u02BE\u02B8\u02B3\u02B3\u02BD\u02B6\u02BB\u02BA\u02BD\u02B6.localPosition = new Vector3(this.\u02B7\u02B4\u02C1\u02C1\u02BC\u02B2\u02BC\u02BD\u02B8\u02BF\u02BC + this.\u02B7\u02B2\u02B3\u02B2\u02BD\u02BC\u02BD\u02B4\u02B6\u02BE\u02BD, this.\u02C0\u02B7\u02B2\u02BE\u02B9\u02BF\u02C0\u02BB\u02C0\u02BA\u02BA, 0f);
				return;
			}
			this.\u02B5\u02B4\u02BA\u02BC\u02B3\u02C1\u02B8\u02B3\u02BB\u02BB\u02C1 = num - this.\u02BD\u02B7\u02B3\u02C0\u02BC\u02BC\u02B7\u02B3\u02BE\u02BD\u02B2;
		}
		this.\u02C1\u02C1\u02B2\u02B8\u02B4\u02B3\u02B2\u02B9\u02B4\u02BD\u02C1 = this.\u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD;
		if (this.\u02B5\u02B4\u02BA\u02BC\u02B3\u02C1\u02B8\u02B3\u02BB\u02BB\u02C1 > 0)
		{
			this.\u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD = ((float)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 - (float)this.\u02BD\u02B7\u02B3\u02C0\u02BC\u02BC\u02B7\u02B3\u02BE\u02BD\u02B2) / (float)this.\u02B5\u02B4\u02BA\u02BC\u02B3\u02C1\u02B8\u02B3\u02BB\u02BB\u02C1;
		}
		else
		{
			this.\u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD = (float)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 / (float)num;
		}
		if (this.\u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD != this.\u02C1\u02C1\u02B2\u02B8\u02B4\u02B3\u02B2\u02B9\u02B4\u02BD\u02C1)
		{
			this.\u02B8\u02BB\u02B2\u02BE\u02B2\u02BA\u02BE\u02B9\u02C1\u02B3\u02B2.localScale = new Vector3(this.\u02BE\u02B4\u02BB\u02BE\u02BC\u02C0\u02B3\u02BB\u02B7\u02B5\u02B4 * this.\u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD, 0.15f, 1f);
			this.\u02C1\u02BE\u02B8\u02B3\u02B3\u02BD\u02B6\u02BB\u02BA\u02BD\u02B6.localPosition = new Vector3(this.\u02B7\u02B4\u02C1\u02C1\u02BC\u02B2\u02BC\u02BD\u02B8\u02BF\u02BC + this.\u02B7\u02B2\u02B3\u02B2\u02BD\u02BC\u02BD\u02B4\u02B6\u02BE\u02BD * this.\u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD, this.\u02C0\u02B7\u02B2\u02BE\u02B9\u02BF\u02C0\u02BB\u02C0\u02BA\u02BA, 0f);
		}
	}

	public void \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		this.\u02B8\u02B3\u02C1\u02B7\u02BA\u02B9\u02BA\u02BA\u02BA\u02B2\u02C1.sprite = (this.\u02B7\u02C0\u02BA\u02BF\u02BB\u02C1\u02C0\u02BD\u02B7\u02BB\u02B3.sprite = null);
		this.\u02B7\u02B2\u02B3\u02B2\u02BD\u02BC\u02BD\u02B4\u02B6\u02BE\u02BD -= this.\u02B7\u02B4\u02C1\u02C1\u02BC\u02B2\u02BC\u02BD\u02B8\u02BF\u02BC;
		this.\u02C0\u02B7\u02B2\u02BE\u02B9\u02BF\u02C0\u02BB\u02C0\u02BA\u02BA = this.\u02C1\u02BE\u02B8\u02B3\u02B3\u02BD\u02B6\u02BB\u02BA\u02BD\u02B6.localPosition.y;
		if (!SettingsController.\u02C1\u02BF\u02B3\u02BF\u02C1\u02BC\u02BC\u02BA\u02BF\u02BD\u02BE)
		{
			this.starParticles.emission.enabled = false;
		}
	}

	public void \u02B6\u02BE\u02B4\u02BD\u02B5\u02B9\u02BF\u02B5\u02BE\u02BA\u02BA()
	{
		this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 = 0;
		this.\u02B5\u02B4\u02BA\u02BC\u02B3\u02C1\u02B8\u02B3\u02BB\u02BB\u02C1 = 1;
		this.\u02BD\u02B7\u02B3\u02C0\u02BC\u02BC\u02B7\u02B3\u02BE\u02BD\u02B2 = 1;
		this.\u02B8\u02B3\u02C1\u02B7\u02BA\u02B9\u02BA\u02BA\u02BA\u02B2\u02C1.sprite = (this.\u02B7\u02C0\u02BA\u02BF\u02BB\u02C1\u02C0\u02BD\u02B7\u02BB\u02B3.sprite = null);
	}

	public void \u02BE\u02BF\u02BA\u02B7\u02BA\u02BF\u02B8\u02BB\u02BC\u02BF\u02C0(int \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5)
	{
		if (this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2 == null)
		{
			return;
		}
		if (this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 == this.\u02BF\u02B3\u02B6\u02BF\u02B9\u02B4\u02B9\u02BF\u02C0\u02BE\u02C1)
		{
			return;
		}
		if (\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 == this.\u02BF\u02BD\u02BF\u02B7\u02B3\u02B3\u02BB\u02B3\u02B7\u02BF\u02BB)
		{
			return;
		}
		int num = this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2[this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3];
		this.\u02BF\u02BD\u02BF\u02B7\u02B3\u02B3\u02BB\u02B3\u02B7\u02BF\u02BB = \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
		while (this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 < this.\u02BF\u02B3\u02B6\u02BF\u02B9\u02B4\u02B9\u02BF\u02C0\u02BE\u02C1 && \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 >= num)
		{
			this.\u02BD\u02B7\u02B3\u02C0\u02BC\u02BC\u02B7\u02B3\u02BE\u02BD\u02B2 = num;
			int[] u02BE_u02B2_u02BA_u02B3_u02BD_u02BD_u02BF_u02BA_u02B7_u02B4_u02B = this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2;
			int num2 = this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 + 1;
			this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 = num2;
			num = u02BE_u02B2_u02BA_u02B3_u02BD_u02BD_u02BF_u02BA_u02B7_u02B4_u02B[num2];
			this.\u02B8\u02B3\u02C1\u02B7\u02BA\u02B9\u02BA\u02BA\u02BA\u02B2\u02C1.sprite = (this.\u02B7\u02C0\u02BA\u02BF\u02BB\u02C1\u02C0\u02BD\u02B7\u02BB\u02B3.sprite = this.\u02BC\u02BA\u02B3\u02B8\u02BD\u02B6\u02BB\u02BC\u02B6\u02B9\u02B7[this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3]);
			this.starParticles.Play();
			if (this.\u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3 == this.\u02BF\u02B3\u02B6\u02BF\u02B9\u02B4\u02B9\u02BF\u02C0\u02BE\u02C1)
			{
				this.\u02B8\u02BB\u02B2\u02BE\u02B2\u02BA\u02BE\u02B9\u02C1\u02B3\u02B2.localScale = new Vector3(this.\u02BE\u02B4\u02BB\u02BE\u02BC\u02C0\u02B3\u02BB\u02B7\u02B5\u02B4, 1870f, 1613f);
				this.\u02C1\u02BE\u02B8\u02B3\u02B3\u02BD\u02B6\u02BB\u02BA\u02BD\u02B6.localPosition = new Vector3(this.\u02B7\u02B4\u02C1\u02C1\u02BC\u02B2\u02BC\u02BD\u02B8\u02BF\u02BC + this.\u02B7\u02B2\u02B3\u02B2\u02BD\u02BC\u02BD\u02B4\u02B6\u02BE\u02BD, this.\u02C0\u02B7\u02B2\u02BE\u02B9\u02BF\u02C0\u02BB\u02C0\u02BA\u02BA, 1335f);
				return;
			}
			this.\u02B5\u02B4\u02BA\u02BC\u02B3\u02C1\u02B8\u02B3\u02BB\u02BB\u02C1 = num - this.\u02BD\u02B7\u02B3\u02C0\u02BC\u02BC\u02B7\u02B3\u02BE\u02BD\u02B2;
		}
		this.\u02C1\u02C1\u02B2\u02B8\u02B4\u02B3\u02B2\u02B9\u02B4\u02BD\u02C1 = this.\u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD;
		if (this.\u02B5\u02B4\u02BA\u02BC\u02B3\u02C1\u02B8\u02B3\u02BB\u02BB\u02C1 > 0)
		{
			this.\u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD = ((float)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 - (float)this.\u02BD\u02B7\u02B3\u02C0\u02BC\u02BC\u02B7\u02B3\u02BE\u02BD\u02B2) / (float)this.\u02B5\u02B4\u02BA\u02BC\u02B3\u02C1\u02B8\u02B3\u02BB\u02BB\u02C1;
		}
		else
		{
			this.\u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD = (float)\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 / (float)num;
		}
		if (this.\u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD != this.\u02C1\u02C1\u02B2\u02B8\u02B4\u02B3\u02B2\u02B9\u02B4\u02BD\u02C1)
		{
			this.\u02B8\u02BB\u02B2\u02BE\u02B2\u02BA\u02BE\u02B9\u02C1\u02B3\u02B2.localScale = new Vector3(this.\u02BE\u02B4\u02BB\u02BE\u02BC\u02C0\u02B3\u02BB\u02B7\u02B5\u02B4 * this.\u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD, 1568f, 415f);
			this.\u02C1\u02BE\u02B8\u02B3\u02B3\u02BD\u02B6\u02BB\u02BA\u02BD\u02B6.localPosition = new Vector3(this.\u02B7\u02B4\u02C1\u02C1\u02BC\u02B2\u02BC\u02BD\u02B8\u02BF\u02BC + this.\u02B7\u02B2\u02B3\u02B2\u02BD\u02BC\u02BD\u02B4\u02B6\u02BE\u02BD * this.\u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD, this.\u02C0\u02B7\u02B2\u02BE\u02B9\u02BF\u02C0\u02BB\u02C0\u02BA\u02BA, 1198f);
		}
	}

	public StarProgress()
	{
		this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2 = new int[9];
		this.\u02BF\u02B3\u02B6\u02BF\u02B9\u02B4\u02B9\u02BF\u02C0\u02BE\u02C1 = 8;
		this.\u02BE\u02B4\u02BB\u02BE\u02BC\u02C0\u02B3\u02BB\u02B7\u02B5\u02B4 = 3.51f;
		this.\u02B7\u02B4\u02C1\u02C1\u02BC\u02B2\u02BC\u02BD\u02B8\u02BF\u02BC = 1.07f;
		this.\u02B7\u02B2\u02B3\u02B2\u02BD\u02BC\u02BD\u02B4\u02B6\u02BE\u02BD = 1.63f;
		this.\u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD = -1f;
		this.\u02BF\u02BD\u02BF\u02B7\u02B3\u02B3\u02BB\u02B3\u02B7\u02BF\u02BB = -1;
	}

	public void \u02B8\u02B2\u02C1\u02B8\u02BB\u02BA\u02B7\u02B7\u02BD\u02C1\u02BC(int \u02B3\u02C0\u02BB\u02B3\u02B7\u02BB\u02BE\u02B8\u02B6\u02B6\u02B8)
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			return;
		}
		this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC += \u02B3\u02C0\u02BB\u02B3\u02B7\u02BB\u02BE\u02B8\u02B6\u02B6\u02B8;
		this.\u02BE\u02B7\u02B4\u02BC\u02C1\u02B3\u02BB\u02B2\u02B4\u02BF\u02B2();
		for (int i = 1; i < this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2.Length; i += 0)
		{
			this.\u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2[i] = Mathf.CeilToInt((float)this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC * StarProgress.\u02B3\u02B3\u02B5\u02B7\u02BA\u02B3\u02BD\u02C0\u02BD\u02B8\u02C1[i]);
		}
	}

	public Transform \u02B8\u02BB\u02B2\u02BE\u02B2\u02BA\u02BE\u02B9\u02C1\u02B3\u02B2;

	public Transform \u02C1\u02BE\u02B8\u02B3\u02B3\u02BD\u02B6\u02BB\u02BA\u02BD\u02B6;

	public SpriteRenderer \u02B8\u02B3\u02C1\u02B7\u02BA\u02B9\u02BA\u02BA\u02BA\u02B2\u02C1;

	public SpriteRenderer \u02B7\u02C0\u02BA\u02BF\u02BB\u02C1\u02C0\u02BD\u02B7\u02BB\u02B3;

	public Sprite[] \u02BC\u02BA\u02B3\u02B8\u02BD\u02B6\u02BB\u02BC\u02B6\u02B9\u02B7;

	[SerializeField]
	private ParticleSystem starParticles;

	private int[] \u02BE\u02B2\u02BA\u02B3\u02BD\u02BD\u02BF\u02BA\u02B7\u02B4\u02B2;

	private int \u02B7\u02BE\u02B3\u02C1\u02BE\u02B9\u02B9\u02BF\u02BE\u02BA\u02B3;

	private int \u02BF\u02B3\u02B6\u02BF\u02B9\u02B4\u02B9\u02BF\u02C0\u02BE\u02C1;

	private int \u02BD\u02B7\u02B3\u02C0\u02BC\u02BC\u02B7\u02B3\u02BE\u02BD\u02B2;

	private int \u02B5\u02B4\u02BA\u02BC\u02B3\u02C1\u02B8\u02B3\u02BB\u02BB\u02C1;

	private int \u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC;

	private float \u02BE\u02B4\u02BB\u02BE\u02BC\u02C0\u02B3\u02BB\u02B7\u02B5\u02B4;

	private float \u02B7\u02B4\u02C1\u02C1\u02BC\u02B2\u02BC\u02BD\u02B8\u02BF\u02BC;

	private float \u02B7\u02B2\u02B3\u02B2\u02BD\u02BC\u02BD\u02B4\u02B6\u02BE\u02BD;

	private float \u02C0\u02B7\u02B2\u02BE\u02B9\u02BF\u02C0\u02BB\u02C0\u02BA\u02BA;

	private float \u02C1\u02C1\u02B2\u02B8\u02B4\u02B3\u02B2\u02B9\u02B4\u02BD\u02C1;

	private float \u02BA\u02B4\u02B5\u02BE\u02B8\u02BD\u02B3\u02C1\u02B5\u02B2\u02BD;

	private int \u02BF\u02BD\u02BF\u02B7\u02B3\u02B3\u02BB\u02B3\u02B7\u02BF\u02BB;

	public static readonly float[] \u02B3\u02B3\u02B5\u02B7\u02BA\u02B3\u02BD\u02C0\u02BD\u02B8\u02C1 = new float[] { 0.1f, 0.5f, 1f, 2f, 2.8f, 3.6f, 4.4f, 5.2f, 6f }.Select((float x) => x *= 1f).ToArray<float>();

	private ParticleSystem.EmissionModule v;

	private SpriteRenderer sr;

	private float ticker;

	private string lastColor;

	private Color origColor;
}
