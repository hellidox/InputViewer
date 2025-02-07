﻿using System;
using StrikeCore;
using UnityEngine;

public class \u02B7\u02BF\u02C0\u02B9\u02B4\u02BB\u02B6\u02BB\u02BC\u02C1\u02C1 : IGameSetting
{
	public bool \u02BC\u02BF\u02B2\u02B6\u02B3\u02BC\u02B3\u02C1\u02B8\u02C0\u02BF
	{
		get
		{
			return !this.\u02B9\u02C1\u02B6\u02B3\u02BD\u02B6\u02B5\u02BA\u02BE\u02B4\u02B2.Equals(this.\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2);
		}
	}

	public Vector3 \u02B2\u02BC\u02B8\u02B9\u02B4\u02BA\u02B8\u02B4\u02B3\u02B3\u02BE
	{
		get
		{
			return this.\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2;
		}
		set
		{
			this.\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2 = value;
		}
	}

	public void \u02B2\u02BD\u02B4\u02BF\u02BC\u02BB\u02C1\u02BA\u02B9\u02B5\u02BD(Vector3 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2 = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public void Reset()
	{
		this.\u02B2\u02BC\u02B8\u02B9\u02B4\u02BA\u02B8\u02B4\u02B3\u02B3\u02BE = this.\u02C0\u02BC\u02B3\u02B4\u02B8\u02B7\u02BD\u02BE\u02B9\u02B9\u02B3;
	}

	public bool \u02BD\u02B5\u02BD\u02B5\u02BD\u02BF\u02BA\u02BA\u02C1\u02C0\u02B8
	{
		get
		{
			return this.\u02B2\u02BC\u02B8\u02B9\u02B4\u02BA\u02B8\u02B4\u02B3\u02B3\u02BE == this.\u02C0\u02BC\u02B3\u02B4\u02B8\u02B7\u02BD\u02BE\u02B9\u02B9\u02B3;
		}
	}

	public void WriteIni(INIParser \u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB, string \u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF)
	{
		\u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB.WriteValue(\u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, this.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 + "_x", (double)this.\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2.x);
		\u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB.WriteValue(\u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, this.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 + "_y", (double)this.\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2.y);
		\u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB.WriteValue(\u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, this.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 + "_z", (double)this.\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2.z);
		this.\u02B9\u02C1\u02B6\u02B3\u02BD\u02B6\u02B5\u02BA\u02BE\u02B4\u02B2 = this.\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2;
	}

	public bool ReadIni(INIParser \u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB, string \u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF)
	{
		float num = (float)\u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB.ReadValue(\u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, this.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 + "_x", (double)this.\u02C0\u02BC\u02B3\u02B4\u02B8\u02B7\u02BD\u02BE\u02B9\u02B9\u02B3.x);
		float num2 = (float)\u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB.ReadValue(\u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, this.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 + "_y", (double)this.\u02C0\u02BC\u02B3\u02B4\u02B8\u02B7\u02BD\u02BE\u02B9\u02B9\u02B3.y);
		float num3 = (float)\u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB.ReadValue(\u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, this.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 + "_z", (double)this.\u02C0\u02BC\u02B3\u02B4\u02B8\u02B7\u02BD\u02BE\u02B9\u02B9\u02B3.z);
		this.\u02B2\u02BC\u02B8\u02B9\u02B4\u02BA\u02B8\u02B4\u02B3\u02B3\u02BE = new Vector3(num, num2, num3);
		this.\u02B9\u02C1\u02B6\u02B3\u02BD\u02B6\u02B5\u02BA\u02BE\u02B4\u02B2 = this.\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2;
		if (!\u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB.IsKeyExists(\u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, this.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 + "_x"))
		{
			\u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB.WriteValue(\u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, this.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 + "_x", (double)this.\u02C0\u02BC\u02B3\u02B4\u02B8\u02B7\u02BD\u02BE\u02B9\u02B9\u02B3.x);
		}
		if (!\u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB.IsKeyExists(\u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, this.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 + "_y"))
		{
			\u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB.WriteValue(\u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, this.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 + "_y", (double)this.\u02C0\u02BC\u02B3\u02B4\u02B8\u02B7\u02BD\u02BE\u02B9\u02B9\u02B3.x);
		}
		if (!\u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB.IsKeyExists(\u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, this.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 + "_z"))
		{
			\u02C0\u02C1\u02C1\u02B3\u02B4\u02BE\u02B7\u02C0\u02B7\u02B8\u02BB.WriteValue(\u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, this.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 + "_z", (double)this.\u02C0\u02BC\u02B3\u02B4\u02B8\u02B7\u02BD\u02BE\u02B9\u02B9\u02B3.x);
		}
		return true;
	}

	public \u02B7\u02BF\u02C0\u02B9\u02B4\u02BB\u02B6\u02BB\u02BC\u02C1\u02C1(SectionKey \u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6, Vector3 \u02B6\u02BF\u02B4\u02B5\u02BD\u02B2\u02BB\u02B9\u02B4\u02C0\u02B3)
	{
		this.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 = \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;
		this.\u02C0\u02BC\u02B3\u02B4\u02B8\u02B7\u02BD\u02BE\u02B9\u02B9\u02B3 = \u02B6\u02BF\u02B4\u02B5\u02BD\u02B2\u02BB\u02B9\u02B4\u02C0\u02B3;
		this.\u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2 = \u02B6\u02BF\u02B4\u02B5\u02BD\u02B2\u02BB\u02B9\u02B4\u02C0\u02B3;
		Settings.RegisterSetting(\u02BF\u02B2\u02BB\u02BC\u02B2\u02BA\u02B3\u02B4\u02B2\u02BC\u02BF, this);
	}

	private string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;

	private Vector3 \u02BE\u02B6\u02B2\u02BC\u02BA\u02B3\u02B6\u02BF\u02B2\u02BB\u02B2;

	private Vector3 \u02C0\u02BC\u02B3\u02B4\u02B8\u02B7\u02BD\u02BE\u02B9\u02B9\u02B3;

	private Vector3 \u02B9\u02C1\u02B6\u02B3\u02BD\u02B6\u02B5\u02BA\u02BE\u02B4\u02B2;
}
