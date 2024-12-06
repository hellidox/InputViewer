﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cysharp.Text;
using StrikeCore;
using UnityEngine;

public abstract class BaseGuitarPlayer : BasePlayer
{
	public abstract ushort \u02BC\u02B2\u02BD\u02B8\u02BF\u02BB\u02C1\u02B3\u02C0\u02B8\u02B9 { get; }

	private bool \u02BC\u02C0\u02BD\u02C1\u02B7\u02BF\u02BD\u02BB\u02B4\u02B8\u02BB
	{
		get
		{
			return this.\u02B6\u02B3\u02BE\u02B6\u02B3\u02BF\u02BC\u02BA\u02C1\u02B6\u02B3 + this.\u02BE\u02B3\u02B8\u02BD\u02B2\u02BD\u02B4\u02BF\u02C1\u02BD\u02B3 > this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
		}
	}

	public override void \u02BE\u02B4\u02B8\u02BD\u02BA\u02B5\u02B3\u02B3\u02B3\u02B4\u02BF(\u02C0\u02C1\u02B2\u02B3\u02B8\u02B7\u02B2\u02B3\u02C0\u02BF\u02BD \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA)
	{
		base.\u02BE\u02B4\u02B8\u02BD\u02BA\u02B5\u02B3\u02B3\u02B3\u02B4\u02BF(\u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA);
		if (this.\u02B9\u02B7\u02B7\u02BF\u02BB\u02C0\u02C1\u02C1\u02C0\u02B2\u02BC != \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02B9\u02B7\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B6\u02BA\u02C0)
		{
			this.\u02BB\u02B8\u02BE\u02B7\u02B2\u02BA\u02B8\u02BA\u02BF\u02C1\u02B9 = 0.25f;
		}
		this.\u02B9\u02B7\u02B7\u02BF\u02BB\u02C0\u02C1\u02C1\u02C0\u02B2\u02BC = \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02B9\u02B7\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B6\u02BA\u02C0;
	}

	public override void \u02B8\u02BF\u02C0\u02BE\u02B2\u02BA\u02C0\u02B5\u02BE\u02B7\u02BD()
	{
		GlobalVariables.hasReset = true;
		List<Note> u02BD_u02BD_u02BC_u02BC_u02BB_u02BE_u02BC_u02BE_u02B2_u02C1_u02B = this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7;
		if (u02BD_u02BD_u02BC_u02BC_u02BB_u02BE_u02BC_u02BE_u02B2_u02C1_u02B != null)
		{
			u02BD_u02BD_u02BC_u02BC_u02BB_u02BE_u02BC_u02BE_u02B2_u02C1_u02B.Clear();
		}
		List<Note> u02B6_u02C1_u02BE_u02B3_u02BC_u02BF_u02BD_u02B6_u02BA_u02BE_u02B = this.\u02B6\u02C1\u02BE\u02B3\u02BC\u02BF\u02BD\u02B6\u02BA\u02BE\u02B8;
		if (u02B6_u02C1_u02BE_u02B3_u02BC_u02BF_u02BD_u02B6_u02BA_u02BE_u02B != null)
		{
			u02B6_u02C1_u02BE_u02B3_u02BC_u02BF_u02BD_u02B6_u02BA_u02BE_u02B.Clear();
		}
		this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = 0f;
		this.\u02B8\u02BA\u02BD\u02B7\u02B2\u02C0\u02BC\u02B9\u02BA\u02C1\u02C0 = 0f;
		this.\u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF = 0;
		this._ghosts = 0;
		this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 = 0f;
		this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD = 0f;
		this.\u02BA\u02B2\u02B5\u02B2\u02B6\u02BF\u02B7\u02B6\u02BF\u02C0\u02B7 = 0.0;
		this.\u02B6\u02B3\u02BE\u02B6\u02B3\u02BF\u02BC\u02BA\u02C1\u02B6\u02B3 = double.MinValue;
		if (!this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && !this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8)
		{
			this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC;
		}
		base.\u02B8\u02BF\u02C0\u02BE\u02B2\u02BA\u02C0\u02B5\u02BE\u02B7\u02BD();
	}

	public override void \u02B5\u02B5\u02BA\u02BB\u02B7\u02BF\u02BC\u02B9\u02B5\u02BE\u02BF(\u02C0\u02C1\u02B2\u02B3\u02B8\u02B7\u02B2\u02B3\u02C0\u02BF\u02BD \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA)
	{
		base.\u02B5\u02B5\u02BA\u02BB\u02B7\u02BF\u02BC\u02B9\u02B5\u02BE\u02BF(\u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA);
		\u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02B9\u02B7\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B6\u02BA\u02C0 = this.\u02B9\u02B7\u02B7\u02BF\u02BB\u02C0\u02C1\u02C1\u02C0\u02B2\u02BC;
	}

	protected override void Start()
	{
		GlobalVariables.hasReset = true;
		if (this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8)
		{
			this.\u02B2\u02B3\u02B6\u02B9\u02B6\u02B8\u02B3\u02BE\u02BE\u02B3\u02B6 = true;
			this.\u02BF\u02BE\u02B8\u02C1\u02BE\u02C1\u02C0\u02C0\u02BB\u02BB\u02BC = 0f;
			this.hitWindow = 0.0525f;
			this.\u02B5\u02BA\u02C1\u02BC\u02C1\u02BB\u02BB\u02C0\u02B4\u02BB\u02BC = 0.066f;
			this.\u02BC\u02B4\u02C1\u02C1\u02B2\u02BF\u02C1\u02B7\u02B2\u02B9\u02BD = this.hitWindow * 2f / 3f;
			this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC = this.hitWindow * 2f / 2.5f;
			this.\u02C1\u02BE\u02B3\u02BA\u02BE\u02BD\u02B8\u02C0\u02C1\u02BE\u02B5 = this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC;
			this.trackSidebarLeft.\u02BC\u02B5\u02B4\u02BE\u02B5\u02C0\u02C1\u02BE\u02B8\u02BD\u02BF(\u02B3\u02B4\u02B2\u02B4\u02B4\u02B2\u02B8\u02BF\u02BC\u02C0\u02B6.PrecisionMode);
			this.trackSidebarRight.\u02BC\u02B5\u02B4\u02BE\u02B5\u02C0\u02C1\u02BE\u02B8\u02BD\u02BF(\u02B3\u02B4\u02B2\u02B4\u02B4\u02B2\u02B8\u02BF\u02BC\u02C0\u02B6.PrecisionMode);
		}
		else if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0)
		{
			this.trackSidebarLeft.\u02BC\u02B5\u02B4\u02BE\u02B5\u02C0\u02C1\u02BE\u02B8\u02BD\u02BF(\u02B3\u02B4\u02B2\u02B4\u02B4\u02B2\u02B8\u02BF\u02BC\u02C0\u02B6.DrunkMode);
			this.trackSidebarRight.\u02BC\u02B5\u02B4\u02BE\u02B5\u02C0\u02C1\u02BE\u02B8\u02BD\u02BF(\u02B3\u02B4\u02B2\u02B4\u02B4\u02B2\u02B8\u02BF\u02BC\u02C0\u02B6.DrunkMode);
		}
		if (this.\u02B3\u02BC\u02B4\u02B8\u02BB\u02B8\u02B2\u02C0\u02C0\u02B3\u02C0)
		{
			this.\u02B5\u02B9\u02C1\u02BC\u02C0\u02BF\u02B3\u02B8\u02BD\u02BB\u02B5 = 0;
		}
		this.\u02B2\u02B9\u02B2\u02B4\u02B2\u02BA\u02B2\u02BA\u02C1\u02BA\u02B5 = true;
		this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7 = new List<Note>(5);
		this.\u02B6\u02C1\u02BE\u02B3\u02BC\u02BF\u02BD\u02B6\u02BA\u02BE\u02B8 = new List<Note>(5);
		this.\u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA = new List<double>(5);
		base.Start();
		this.\u02B4\u02B2\u02B6\u02B5\u02BB\u02BB\u02B5\u02B3\u02B7\u02BA\u02B4 = (double)SettingsController.\u02B3\u02B6\u02BB\u02BF\u02BD\u02BF\u02C0\u02B3\u02C1\u02BB\u02B8.GetFloatSecond;
		this.\u02BE\u02B3\u02B8\u02BD\u02B2\u02BD\u02B4\u02BF\u02C1\u02BD\u02B3 = (double)SettingsController.\u02B5\u02B7\u02B2\u02BB\u02BE\u02B8\u02BC\u02BA\u02B6\u02B5\u02C1.GetFloatSecond;
		if (this.playerStuff.playerInfo.IsGamepadMode() || this.\u02BF\u02C1\u02BF\u02BE\u02C1\u02B2\u02BC\u02BE\u02B3\u02BB\u02B8)
		{
			this.\u02BE\u02B3\u02B8\u02BD\u02B2\u02BD\u02B4\u02BF\u02C1\u02BD\u02B3 = 0.0;
		}
	}

	protected void \u02B6\u02BB\u02B4\u02B2\u02B3\u02BE\u02B2\u02B4\u02B6\u02B3\u02B2()
	{
		for (int i = 0; i < this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Count; i++)
		{
			Note note = this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7[i];
			if (note.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 == 0 && note.\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD <= 0f)
			{
				this.\u02B7\u02B9\u02BA\u02BC\u02BD\u02B8\u02B2\u02BC\u02B8\u02BA\u02BF(note, i);
				i--;
			}
		}
	}

	protected void \u02B7\u02B9\u02BA\u02BC\u02BD\u02B8\u02B2\u02BC\u02B8\u02BA\u02BF(Note \u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9, int \u02C0\u02C1\u02BB\u02B9\u02B7\u02C1\u02BC\u02B4\u02BA\u02B8\u02B3)
	{
		this.neckController.\u02B8\u02BA\u02B8\u02B9\u02B7\u02B3\u02B6\u02BD\u02C1\u02BC\u02B8(\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF);
		\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9.\u02C1\u02BC\u02B2\u02C1\u02BC\u02B8\u02B2\u02BA\u02C1\u02B9\u02C0 = true;
		if (\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 > 0)
		{
			\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9.\u02C1\u02B8\u02B6\u02B6\u02BF\u02BF\u02BD\u02BF\u02B4\u02B6\u02C0 = false;
		}
		this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.RemoveAt(\u02C0\u02C1\u02BB\u02B9\u02B7\u02C1\u02BC\u02B4\u02BA\u02B8\u02B3);
		this.\u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA.RemoveAt(\u02C0\u02C1\u02BB\u02B9\u02B7\u02C1\u02BC\u02B4\u02BA\u02B8\u02B3);
		if (\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 == 0)
		{
			this.\u02B6\u02C1\u02BE\u02B3\u02BC\u02BF\u02BD\u02B6\u02BA\u02BE\u02B8.Add(\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9);
		}
		if (!\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9.\u02B6\u02B3\u02B9\u02B5\u02B6\u02B6\u02BF\u02B3\u02B9\u02BC\u02BA && this.\u02BD\u02B8\u02B6\u02B2\u02B8\u02B6\u02BD\u02C0\u02BD\u02B8\u02BB)
		{
			this.\u02B6\u02B9\u02BC\u02C0\u02B6\u02BE\u02B4\u02BA\u02BC\u02BB\u02C1(false);
		}
		if ((long)\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 > (long)((ulong)this._GameManager.\u02BB\u02B8\u02B4\u02B3\u02B9\u02BC\u02B9\u02B7\u02B2\u02B9\u02B9) && this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Count == 0)
		{
			BassAudioManager.Instance.\u02C1\u02BA\u02B3\u02B4\u02B7\u02B3\u02B4\u02B5\u02BD\u02C1\u02BF(this.playerStuff.playerInfo.\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1, false, -1f);
			this.\u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6 = true;
		}
	}

	protected void \u02B2\u02BF\u02BF\u02B2\u02C0\u02B8\u02B5\u02BD\u02B3\u02B6\u02C0()
	{
		if (this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7 == null)
		{
			return;
		}
		if (this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Count == 0)
		{
			this.\u02BB\u02B8\u02BE\u02B7\u02B2\u02BA\u02B8\u02BA\u02BF\u02C1\u02B9 = 0f;
			if (this.\u02B6\u02C1\u02BE\u02B3\u02BC\u02BF\u02BD\u02B6\u02BA\u02BE\u02B8.Count == 0)
			{
				return;
			}
		}
		bool flag = false;
		for (int i = 0; i < this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Count; i++)
		{
			Note note = this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7[i];
			if (note != null)
			{
				if (!flag)
				{
					flag = note.\u02B7\u02C0\u02BE\u02C0\u02B6\u02BF\u02BC\u02C1\u02BA\u02BF\u02BE;
				}
				if (this._GameManager.\u02BA\u02BC\u02B2\u02BE\u02B7\u02C0\u02BD\u02B7\u02B2\u02B9\u02BF > note.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE && note.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 > 0)
				{
					int num;
					if ((long)note.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 <= (long)((ulong)this._GameManager.\u02BB\u02B8\u02B4\u02B3\u02B9\u02BC\u02B9\u02B7\u02B2\u02B9\u02B9))
					{
						num = note.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2;
						note.\u02B6\u02B3\u02B9\u02B5\u02B6\u02B6\u02BF\u02B3\u02B9\u02BC\u02BA = true;
						note.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 = 0;
					}
					else
					{
						num = (int)(this._GameManager.\u02BA\u02BC\u02B2\u02BE\u02B7\u02C0\u02BD\u02B7\u02B2\u02B9\u02BF - note.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE);
						note.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 -= num;
						if (note.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 < 0)
						{
							num += note.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2;
							note.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 = 0;
						}
					}
					base.\u02BB\u02B4\u02B5\u02B9\u02B7\u02B5\u02C1\u02C0\u02B6\u02C1\u02BD(this._GameManager.\u02C0\u02C1\u02B3\u02B7\u02C1\u02BE\u02B7\u02B4\u02C1\u02BC\u02B7(ref num, note.\u02B6\u02B3\u02B9\u02B5\u02B6\u02B6\u02BF\u02B3\u02B9\u02BC\u02BA));
					if (!note.\u02B6\u02B3\u02B9\u02B5\u02B6\u02B6\u02BF\u02B3\u02B9\u02BC\u02BA)
					{
						note.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 += num;
					}
					note.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE = this._GameManager.\u02BA\u02BC\u02B2\u02BE\u02B7\u02C0\u02BD\u02B7\u02B2\u02B9\u02BF - (uint)num;
				}
				note.\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD -= this._GameManager.\u02C0\u02BE\u02C1\u02BD\u02C0\u02BC\u02BB\u02B4\u02C1\u02B3\u02B9;
				if ((!this.\u02BA\u02B7\u02B5\u02C1\u02C0\u02B4\u02BE\u02BF\u02BF\u02C0\u02BE(note) && !note.\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1) || ((note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & this.inputBits) != note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF && (note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & this.\u02BC\u02B2\u02BD\u02B8\u02BF\u02BB\u02C1\u02B3\u02C0\u02B8\u02B9) == 0))
				{
					if (this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 > this.\u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA[i] + this.\u02BE\u02B9\u02BB\u02B6\u02BC\u02B2\u02BD\u02BC\u02C0\u02C1\u02B5)
					{
						this.\u02B7\u02B9\u02BA\u02BC\u02BD\u02B8\u02B2\u02BC\u02B8\u02BA\u02BF(note, i);
						i--;
					}
				}
				else
				{
					this.\u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA[i] = this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
				}
			}
		}
		if (flag && this.\u02BB\u02B8\u02BE\u02B7\u02B2\u02BA\u02B8\u02BA\u02BF\u02C1\u02B9 > 0f && !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			this.\u02B8\u02B8\u02B3\u02BD\u02B2\u02BB\u02BF\u02B8\u02B3\u02B8\u02BD(this._GameManager.\u02BE\u02C1\u02BF\u02BD\u02BA\u02B8\u02B6\u02B5\u02B5\u02B8\u02B7(), false);
		}
	}

	protected void \u02C0\u02BB\u02BF\u02B6\u02C1\u02B8\u02B3\u02BB\u02BE\u02BE\u02B3()
	{
		for (int i = this.\u02B6\u02C1\u02BE\u02B3\u02BC\u02BF\u02BD\u02B6\u02BA\u02BE\u02B8.Count - 1; i >= 0; i--)
		{
			Note note = this.\u02B6\u02C1\u02BE\u02B3\u02BC\u02BF\u02BD\u02B6\u02BA\u02BE\u02B8[i];
			if (this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 > (double)(note.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 + this.hitWindow))
			{
				this.\u02B6\u02C1\u02BE\u02B3\u02BC\u02BF\u02BD\u02B6\u02BA\u02BE\u02B8.RemoveAt(i);
			}
		}
	}

	protected override float \u02B9\u02B9\u02B4\u02C1\u02B9\u02B6\u02B2\u02BA\u02B2\u02B2\u02BF(float \u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4)
	{
		\u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4 *= 1000f;
		return (float)(0.55238 * (double)\u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4 + 42.0) / 1000f;
	}

	public override void \u02B3\u02B6\u02C0\u02C1\u02B6\u02B6\u02BD\u02BD\u02B7\u02BC\u02BC(Note \u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2)
	{
		this.\u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF = 0;
		this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 = this.\u02B8\u02BA\u02BD\u02B7\u02B2\u02C0\u02BC\u02B9\u02BA\u02C1\u02C0;
		base.\u02B3\u02B6\u02C0\u02C1\u02B6\u02B6\u02BD\u02BD\u02B7\u02BC\u02BC(\u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2);
	}

	protected virtual bool \u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9()
	{
		return !this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB || this.\u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF > 0f || (this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB && this.combo == 0 && this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD <= 0f);
	}

	protected override void \u02BE\u02BC\u02BA\u02BB\u02C0\u02B5\u02B6\u02B8\u02B6\u02BB\u02B3(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		bool flag = false;
		Note.\u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3 u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B;
		foreach (Note note in EnumerableRanges.EnumerateRange<Note>(this.\u02B8\u02B5\u02B8\u02BF\u02BE\u02BD\u02BB\u02BD\u02BB\u02BC\u02B6, 0, this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6 - 1))
		{
			if (note.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE > \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE)
			{
				break;
			}
			u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B = note.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
			while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
			{
				Note note2 = u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
				if (note2 == \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
				{
					flag = true;
					break;
				}
				if (!note2.\u02BC\u02B9\u02B4\u02B6\u02B5\u02BC\u02BB\u02BC\u02BB\u02B4\u02B7 && note2.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE != \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE)
				{
					this.\u02B3\u02B6\u02C0\u02C1\u02B6\u02B6\u02BD\u02BD\u02B7\u02BC\u02BC(note2);
				}
			}
			if (flag)
			{
				break;
			}
		}
		this.\u02BB\u02B3\u02B2\u02C0\u02B3\u02BC\u02B3\u02B5\u02BB\u02C0\u02B6 = (float)((double)\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 - this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9);
		base.\u02B3\u02B2\u02B7\u02C1\u02BF\u02B6\u02BE\u02BA\u02BA\u02BF\u02B2();
		this.\u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF = 0;
		this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 = this.\u02B8\u02BA\u02BD\u02B7\u02B2\u02C0\u02BC\u02B9\u02BA\u02C1\u02C0;
		if (\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02C0\u02B9\u02BD\u02B8\u02B4\u02BB\u02B4\u02B9\u02B9\u02B6\u02BD && this.\u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9())
		{
			if (this.\u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA > 0f)
			{
				this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 = this.\u02BC\u02B4\u02C1\u02C1\u02B2\u02BF\u02C1\u02B7\u02B2\u02B9\u02BD;
			}
			else if (this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8)
			{
				this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 = \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 + this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF / 2f - (float)this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
			}
			else
			{
				this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 = 0.096f;
			}
			this.\u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF = this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7;
		}
		if (this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB && \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02C0\u02B9\u02BD\u02B8\u02B4\u02BB\u02B4\u02B9\u02B9\u02B6\u02BD)
		{
			this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD = this.\u02B3\u02C0\u02BA\u02BC\u02BB\u02BF\u02B4\u02B5\u02BC\u02BD\u02BC;
		}
		if (\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02B8\u02C1\u02BA\u02B2\u02BC\u02B6\u02C0\u02BD\u02BD\u02BA\u02BE || (this.\u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9() && \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02C0\u02B9\u02BD\u02B8\u02B4\u02BB\u02B4\u02B9\u02B9\u02B6\u02BD))
		{
			this.\u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA = 0f;
		}
		if (this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Count > 0 && !\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1)
		{
			foreach (Note note3 in this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7)
			{
				if ((long)note3.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 <= (long)((ulong)this._GameManager.\u02BB\u02B8\u02B4\u02B3\u02B9\u02BC\u02B9\u02B7\u02B2\u02B9\u02B9))
				{
					note3.\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD = 0f;
				}
				note3.\u02C1\u02BC\u02B2\u02C1\u02BC\u02B8\u02B2\u02BA\u02C1\u02B9\u02C0 = true;
				note3.\u02C1\u02B8\u02B6\u02B6\u02BF\u02BF\u02BD\u02BF\u02B4\u02B6\u02C0 = false;
				this.\u02B6\u02C1\u02BE\u02B3\u02BC\u02BF\u02BD\u02B6\u02BA\u02BE\u02B8.Add(note3);
			}
			this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Clear();
			this.\u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA.Clear();
			this.neckController.\u02B5\u02BD\u02BA\u02BE\u02B4\u02B9\u02BD\u02B3\u02B9\u02BC\u02BE();
		}
		u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B = \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
		{
			u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF.\u02BF\u02BF\u02B7\u02BE\u02B9\u02BC\u02B8\u02B7\u02C0\u02BC\u02B4 = true;
		}
		if (this.\u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6)
		{
			BassAudioManager.Instance.\u02C1\u02BA\u02B3\u02B4\u02B7\u02B3\u02B4\u02B5\u02BD\u02C1\u02BF(this.playerStuff.playerInfo.\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1, true, -1f);
			this.\u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6 = false;
		}
		base.\u02BE\u02BC\u02BA\u02BB\u02C0\u02B5\u02B6\u02B8\u02B6\u02BB\u02B3(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8);
		u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B = \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
		{
			Note note4 = u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
			this.\u02BB\u02B4\u02B5\u02B9\u02B7\u02B5\u02C1\u02C0\u02B6\u02C1\u02BD(note4, 50);
			if (note4.\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD > 0f)
			{
				this.\u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(note4);
			}
			this.neckController.PlayFret(note4, this.\u02C0\u02B4\u02B5\u02B8\u02B6\u02B8\u02B2\u02BE\u02B6\u02B5\u02B2, base.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9);
		}
	}

	protected virtual void \u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		for (int i = 0; i < this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Count; i++)
		{
			Note note = this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7[i];
			if ((note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF) != 0)
			{
				this.\u02B7\u02B9\u02BA\u02BC\u02BD\u02B8\u02B2\u02BC\u02B8\u02BA\u02BF(note, i);
			}
		}
		this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Add(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8);
		this.\u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA.Add(this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9);
		\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02C1\u02B8\u02B6\u02B6\u02BF\u02BF\u02BD\u02BF\u02B4\u02B6\u02C0 = true;
		float num = (float)((double)\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 - this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9);
		\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD += num;
	}

	protected override void Update()
	{
		if (!this.playerStuff.playerInfo.isRemotePlayer)
		{
			BaseGuitarPlayer.instance = this;
			this.minputs = this.Inputs;
			this.minputs.su = this.playerStuff.rewiredPlayer.GetButton(5);
			this.minputs.sd = this.playerStuff.rewiredPlayer.GetButton(14);
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			float num = 0f;
			if (!this.lastinputs.g && this.minputs.g)
			{
				this.minputs.gcount = this.minputs.gcount + 1;
				this.minputs.gptime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.g && this.minputs.g)
			{
				this.minputs.gptime = this.minputs.gptime + unscaledDeltaTime;
			}
			if (!this.lastinputs.r && this.minputs.r)
			{
				this.minputs.rcount = this.minputs.rcount + 1;
				this.minputs.rptime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.r && this.minputs.r)
			{
				this.minputs.rptime = this.minputs.rptime + unscaledDeltaTime;
			}
			if (!this.lastinputs.y && this.minputs.y)
			{
				this.minputs.ycount = this.minputs.ycount + 1;
				this.minputs.yptime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.y && this.minputs.y)
			{
				this.minputs.yptime = this.minputs.yptime + unscaledDeltaTime;
			}
			if (!this.lastinputs.b && this.minputs.b)
			{
				this.minputs.bcount = this.minputs.bcount + 1;
				this.minputs.bptime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.b && this.minputs.b)
			{
				this.minputs.bptime = this.minputs.bptime + unscaledDeltaTime;
			}
			if (!this.lastinputs.o && this.minputs.o)
			{
				this.minputs.ocount = this.minputs.ocount + 1;
				this.minputs.optime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.o && this.minputs.o)
			{
				this.minputs.optime = this.minputs.optime + unscaledDeltaTime;
			}
			if (!this.lastinputs.su && this.minputs.su)
			{
				this.minputs.sucount = this.minputs.sucount + 1;
				this.minputs.sutime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.su && this.minputs.su)
			{
				this.minputs.sutime = this.minputs.sutime + unscaledDeltaTime;
			}
			if (!this.lastinputs.sd && this.minputs.sd)
			{
				this.minputs.sdcount = this.minputs.sdcount + 1;
				this.minputs.sdtime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.sd && this.minputs.sd)
			{
				this.minputs.sdtime = this.minputs.sdtime + unscaledDeltaTime;
			}
			this.lastinputs = this.minputs;
		}
		if (!this.\u02B3\u02B3\u02BD\u02C0\u02B6\u02B7\u02C0\u02BA\u02BB\u02B9\u02B9 && this._GameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5)
		{
			this.\u02BE\u02B9\u02BB\u02B6\u02BC\u02B2\u02BD\u02BC\u02C0\u02C1\u02B5 = this.\u02B7\u02B6\u02B4\u02B8\u02BD\u02B2\u02BF\u02B6\u02B7\u02C1\u02BD;
			this.\u02B3\u02B3\u02BD\u02C0\u02B6\u02B7\u02C0\u02BA\u02BB\u02B9\u02B9 = true;
			this.\u02BA\u02B2\u02B5\u02B2\u02B6\u02BF\u02B7\u02B6\u02BF\u02C0\u02B7 = this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
		}
		if (this.\u02B3\u02B3\u02BD\u02C0\u02B6\u02B7\u02C0\u02BA\u02BB\u02B9\u02B9 && this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 >= this.\u02BE\u02B9\u02BB\u02B6\u02BC\u02B2\u02BD\u02BC\u02C0\u02C1\u02B5 + this.\u02BA\u02B2\u02B5\u02B2\u02B6\u02BF\u02B7\u02B6\u02BF\u02C0\u02B7)
		{
			this.\u02BE\u02B9\u02BB\u02B6\u02BC\u02B2\u02BD\u02BC\u02C0\u02C1\u02B5 = this.\u02B4\u02B2\u02B6\u02B5\u02BB\u02BB\u02B5\u02B3\u02B7\u02BA\u02B4;
			this.\u02B3\u02B3\u02BD\u02C0\u02B6\u02B7\u02C0\u02BA\u02BB\u02B9\u02B9 = false;
		}
		if (this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 > 0f)
		{
			this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 -= Time.deltaTime;
			if (this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 <= 0f)
			{
				this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 = 0f;
			}
		}
		if (this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 > 0f)
		{
			this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 -= Time.deltaTime;
		}
		if (this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 > 0f)
		{
			this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 -= Time.deltaTime;
			if (this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 <= 0f)
			{
				this.\u02BC\u02B8\u02B5\u02BB\u02BB\u02B7\u02C1\u02B6\u02BC\u02B4\u02BE = 0;
				this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 = 0f;
			}
		}
		if (this.\u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA > 0f)
		{
			this.\u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA -= Time.deltaTime;
			if (this.\u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA <= 0f)
			{
				this.\u02B6\u02B9\u02BC\u02C0\u02B6\u02BE\u02B4\u02BA\u02BC\u02BB\u02C1(true);
				this.\u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA = 0f;
			}
		}
		if (this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB > 0f && (this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8 || this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0))
		{
			this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB -= Time.deltaTime;
			if (this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB <= 0f)
			{
				this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = 0f;
			}
		}
		if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && this.\u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3 > 0f)
		{
			this.\u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3 -= Time.deltaTime;
			if (this.\u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3 <= 0f)
			{
				this.\u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3 = 0f;
			}
		}
		if (this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB && this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD > 0f)
		{
			this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD -= Time.deltaTime;
			if (this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD <= 0f)
			{
				this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD = 0f;
			}
		}
		if (this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB && this.\u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF > 0f)
		{
			this.\u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF -= Time.deltaTime;
			if (this.\u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF <= 0f)
			{
				this.\u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF = 0f;
			}
		}
		base.Update();
		this.\u02B6\u02BB\u02B4\u02B2\u02B3\u02BE\u02B2\u02B4\u02B6\u02B3\u02B2();
		this.\u02BF\u02B6\u02B2\u02B3\u02B2\u02B4\u02B4\u02B5\u02B4\u02B2\u02B7();
		this.\u02B2\u02BF\u02BF\u02B2\u02C0\u02B8\u02B5\u02BD\u02B3\u02B6\u02C0();
		this.\u02C0\u02BB\u02BF\u02B6\u02C1\u02B8\u02B3\u02BB\u02BE\u02BE\u02B3();
		if (this.\u02BB\u02B8\u02BE\u02B7\u02B2\u02BA\u02B8\u02BA\u02BF\u02C1\u02B9 > 0f)
		{
			this.\u02BB\u02B8\u02BE\u02B7\u02B2\u02BA\u02B8\u02BA\u02BF\u02C1\u02B9 -= Time.deltaTime;
		}
		if (!this._GameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5)
		{
			this.noteRenderer.\u02C0\u02C0\u02BA\u02B9\u02B7\u02B3\u02BB\u02B8\u02B8\u02B2\u02B3 = this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7;
		}
	}

	protected override void UpdateInputs()
	{
		float axis = this.playerStuff.rewiredPlayer.GetAxis(7);
		bool button = this.playerStuff.rewiredPlayer.GetButton(6);
		if (this._GameManager.\u02B2\u02B5\u02B8\u02C0\u02B4\u02B2\u02B2\u02BD\u02B2\u02B3\u02C1)
		{
			if (button)
			{
				this.\u02B4\u02BA\u02BA\u02B3\u02C0\u02BC\u02BD\u02BA\u02B5\u02B2\u02B8 = true;
			}
			if (this.playerStuff.playerInfo.tilt && axis >= 1f)
			{
				this.\u02B6\u02C0\u02BA\u02BF\u02B7\u02B8\u02B2\u02B2\u02B5\u02B6\u02B2 = true;
			}
		}
		else
		{
			if (!button)
			{
				this.\u02B4\u02BA\u02BA\u02B3\u02C0\u02BC\u02BD\u02BA\u02B5\u02B2\u02B8 = false;
			}
			if (axis < 0.75f)
			{
				this.\u02B6\u02C0\u02BA\u02BF\u02B7\u02B8\u02B2\u02B2\u02B5\u02B6\u02B2 = false;
			}
		}
		if (base.\u02BF\u02C0\u02BA\u02B6\u02B7\u02C0\u02B2\u02BE\u02BC\u02BA\u02B2 && ((!this.\u02B4\u02BA\u02BA\u02B3\u02C0\u02BC\u02BD\u02BA\u02B5\u02B2\u02B8 && button) || (!this.\u02B6\u02C0\u02BA\u02BF\u02B7\u02B8\u02B2\u02B2\u02B5\u02B6\u02B2 && this.playerStuff.playerInfo.tilt && axis >= 1f)))
		{
			base.\u02B9\u02BC\u02B2\u02B7\u02BD\u02B2\u02B2\u02B2\u02B2\u02BE\u02BE();
		}
		bool flag = false;
		bool flag2 = true;
		if (this.playerStuff.playerInfo.IsGamepadMode() && this.\u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA == 0f)
		{
			if (this.playerStuff.rewiredPlayer.GetButtonDown(5))
			{
				this.inputBits |= this.\u02BC\u02B2\u02BD\u02B8\u02BF\u02BB\u02C1\u02B3\u02C0\u02B8\u02B9;
			}
			if (this.playerStuff.rewiredPlayer.GetButtonDown(14))
			{
				this.inputBits |= this.\u02BC\u02B2\u02BD\u02B8\u02BF\u02BB\u02C1\u02B3\u02C0\u02B8\u02B9;
			}
			flag = this.inputBits > this.\u02BA\u02BD\u02B4\u02BB\u02B8\u02C1\u02B2\u02B3\u02B2\u02BC\u02B3;
		}
		if (!this.playerStuff.playerInfo.IsGamepadMode())
		{
			if (this.playerStuff.rewiredPlayer.GetButtonDown(5))
			{
				flag = true;
				flag2 = true;
			}
			if (this.playerStuff.rewiredPlayer.GetButtonDown(14))
			{
				flag = true;
				flag2 = false;
			}
		}
		if (this.\u02B4\u02BA\u02B4\u02BF\u02B6\u02B9\u02B5\u02BA\u02C0\u02BD\u02BB.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7)
		{
			flag = false;
		}
		this.\u02B9\u02B7\u02B7\u02BF\u02BB\u02C0\u02C1\u02C1\u02C0\u02B2\u02BC = this.playerStuff.rewiredPlayer.GetAxis(17);
		if (this.playerStuff.rewiredPlayer.GetButton(30))
		{
			this.\u02B9\u02B7\u02B7\u02BF\u02BB\u02C0\u02C1\u02C1\u02C0\u02B2\u02BC = 1f;
		}
		if (this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Count > 0 && this.\u02B2\u02BF\u02BD\u02B2\u02C0\u02BD\u02BA\u02B2\u02BC\u02B5\u02B6)
		{
			if (!this.\u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6)
			{
				float num = Mathf.Abs(this.\u02B9\u02B7\u02B7\u02BF\u02BB\u02C0\u02C1\u02C1\u02C0\u02B2\u02BC);
				BassAudioManager.Instance.\u02B2\u02B2\u02B9\u02BA\u02B2\u02B2\u02BA\u02B8\u02BC\u02B9\u02BF(this.playerStuff.playerInfo.\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1, num);
			}
		}
		else if (!this.\u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6)
		{
			BassAudioManager.Instance.\u02B2\u02B2\u02B9\u02BA\u02B2\u02B2\u02BA\u02B8\u02BC\u02B9\u02BF(this.playerStuff.playerInfo.\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1, 0f);
		}
		if (this.\u02B9\u02B7\u02B7\u02BF\u02BB\u02C0\u02C1\u02C1\u02C0\u02B2\u02BC != this.\u02BF\u02B7\u02C1\u02BF\u02B6\u02BB\u02B7\u02B2\u02B6\u02B7\u02B9)
		{
			this.\u02BB\u02B8\u02BE\u02B7\u02B2\u02BA\u02B8\u02BA\u02BF\u02C1\u02B9 = 0.25f;
		}
		if (this.playerStuff.rewiredPlayer.GetButtonDown(30))
		{
			this.\u02BB\u02B8\u02BE\u02B7\u02B2\u02BA\u02B8\u02BA\u02BF\u02C1\u02B9 = 0.75f;
		}
		this.\u02BF\u02B7\u02C1\u02BF\u02B6\u02BB\u02B7\u02B2\u02B6\u02B7\u02B9 = this.\u02B9\u02B7\u02B7\u02BF\u02BB\u02C0\u02C1\u02C1\u02C0\u02B2\u02BC;
		this.\u02BA\u02BD\u02B4\u02BB\u02B8\u02C1\u02B2\u02B3\u02B2\u02BC\u02B3 = this.inputBits;
		if (this.inputBits == 0)
		{
			this.inputBits |= this.\u02BC\u02B2\u02BD\u02B8\u02BF\u02BB\u02C1\u02B3\u02C0\u02B8\u02B9;
		}
		Note note;
		if (this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6 > 0)
		{
			note = this.\u02B8\u02B5\u02B8\u02BF\u02BE\u02BD\u02BB\u02BD\u02BB\u02BC\u02B6[0];
		}
		else
		{
			note = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.\u02B5\u02B5\u02B9\u02B6\u02BF\u02C0\u02B9\u02B8\u02B8\u02B8\u02C0(this._GameManager.\u02BA\u02BC\u02B2\u02BE\u02B7\u02C0\u02BD\u02B7\u02B2\u02B9\u02BF, this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9);
		}
		int num2 = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.\u02B2\u02B4\u02B6\u02B8\u02C0\u02C0\u02B4\u02C0\u02B2\u02BE\u02BD(note, this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9);
		if (this.inputBits != this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3)
		{
			if (note != null && num2 > 0)
			{
				ushort num3 = note.\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3;
				int num4 = (int)(this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 & this.inputBits);
				num4 = (int)this.inputBits ^ num4;
				num4 &= (int)(~(int)this.\u02BC\u02B8\u02B5\u02BB\u02BB\u02B7\u02C1\u02B6\u02BC\u02B4\u02BE);
				if (this.combo > 0 && this.inputBits != this.\u02BC\u02B2\u02BD\u02B8\u02BF\u02BB\u02C1\u02B3\u02C0\u02B8\u02B9 && this.inputBits != num3 && num4 != 0 && ((int)num3 & num4) == 0)
				{
					this.\u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF++;
					this._ghosts++;
				}
				int num5 = (int)(this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 & ~(int)this.\u02BC\u02B2\u02BD\u02B8\u02BF\u02BB\u02C1\u02B3\u02C0\u02B8\u02B9);
				int num6 = (int)(this.inputBits & ~(int)this.\u02BC\u02B2\u02BD\u02B8\u02BF\u02BB\u02C1\u02B3\u02C0\u02B8\u02B9);
				int num7 = num5 ^ num6;
				num7 &= (int)this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3;
				if (num7 != 0)
				{
					this.\u02BC\u02B8\u02B5\u02BB\u02BB\u02B7\u02C1\u02B6\u02BC\u02B4\u02BE |= (ushort)num7;
					this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 = this.\u02C0\u02BE\u02C1\u02BB\u02C0\u02BE\u02B2\u02B5\u02B8\u02BA\u02BF;
				}
				if (this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 <= 0f)
				{
					this.\u02BC\u02B8\u02B5\u02BB\u02BB\u02B7\u02C1\u02B6\u02BC\u02B4\u02BE = 0;
				}
			}
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = this.inputBits;
			if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && note != null && (note.\u02B5\u02BC\u02BE\u02BF\u02B6\u02B7\u02B3\u02B9\u02BF\u02B5\u02BE || (note.\u02C0\u02BF\u02B6\u02B4\u02BC\u02BD\u02BD\u02B6\u02C0\u02B3\u02BF && (this.combo != 0 || (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 && !this.\u02B7\u02BD\u02C1\u02B3\u02BD\u02B5\u02B6\u02B8\u02B8\u02B2\u02BF)))) && this.\u02BA\u02B7\u02B5\u02C1\u02C0\u02B4\u02BE\u02BF\u02BF\u02C0\u02BE(note) && note.\u02C0\u02B9\u02BD\u02B8\u02B4\u02BB\u02B4\u02B9\u02B9\u02B6\u02BD && !note.\u02C1\u02B9\u02BD\u02B6\u02B7\u02BA\u02B5\u02B7\u02BA\u02B6\u02C0)
			{
				note.\u02C1\u02B9\u02BD\u02B6\u02B7\u02BA\u02B5\u02B7\u02BA\u02B6\u02C0 = true;
				this.\u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3 = note.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 - (float)this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
			}
			this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC;
		}
		if (this.\u02BF\u02C1\u02BF\u02BE\u02C1\u02B2\u02BC\u02BE\u02B3\u02BB\u02B8 && ((!this.\u02B3\u02BC\u02B4\u02B8\u02BB\u02B8\u02B2\u02C0\u02C0\u02B3\u02C0 && !this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB) || ((this.\u02B3\u02BC\u02B4\u02B8\u02BB\u02B8\u02B2\u02C0\u02C0\u02B3\u02C0 || this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB) && note != null && !note.\u02C0\u02B9\u02BD\u02B8\u02B4\u02BB\u02B4\u02B9\u02B9\u02B6\u02BD) || this.combo == 0))
		{
			flag = true;
		}
		if (flag && (flag2 != this.\u02C1\u02B8\u02B7\u02BB\u02B4\u02BE\u02BB\u02B5\u02B3\u02B6\u02B2 || !this.\u02BC\u02C0\u02BD\u02C1\u02B7\u02BF\u02BD\u02BB\u02B4\u02B8\u02BB))
		{
			this.\u02B6\u02B3\u02BE\u02B6\u02B3\u02BF\u02BC\u02BA\u02C1\u02B6\u02B3 = this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
			this.\u02C1\u02B8\u02B7\u02BB\u02B4\u02BE\u02BB\u02B5\u02B3\u02B6\u02B2 = flag2;
			if (this.\u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9() && this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 > 0f)
			{
				this.\u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA = 0f;
				if (this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8)
				{
					this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 = 0f;
					return;
				}
			}
			else
			{
				if (this.\u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9() || (this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB && note.\u02B8\u02C1\u02BA\u02B2\u02BC\u02B6\u02C0\u02BD\u02BD\u02BA\u02BE))
				{
					this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = this.\u02C1\u02BE\u02B3\u02BA\u02BE\u02BD\u02B8\u02C0\u02C1\u02BE\u02B5;
				}
				if (this.\u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA > 0f)
				{
					this.\u02B6\u02B9\u02BC\u02C0\u02B6\u02BE\u02B4\u02BA\u02BC\u02BB\u02C1(true);
				}
				bool flag3 = false;
				if (note != null)
				{
					double num8 = (double)this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF;
					double num9 = (double)note.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 - this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
					float num10 = (float)(num9 - num8);
					float num11 = (float)(num9 + num8);
					if (num10 <= this.\u02BC\u02B4\u02C1\u02C1\u02B2\u02BF\u02C1\u02B7\u02B2\u02B9\u02BD)
					{
						this.\u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA = Mathf.Min(num11, this.\u02B5\u02BA\u02C1\u02BC\u02C1\u02BB\u02BB\u02C0\u02B4\u02BB\u02BC);
						flag3 = true;
					}
				}
				if (!flag3)
				{
					this.\u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA = this.\u02BC\u02B4\u02C1\u02C1\u02B2\u02BF\u02C1\u02B7\u02B2\u02B9\u02BD;
				}
			}
		}
	}

	private void \u02BF\u02B6\u02B2\u02B3\u02B2\u02B4\u02B4\u02B5\u02B4\u02B2\u02B7()
	{
		if (this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6 > 0)
		{
			this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 = 0f;
			BaseGuitarPlayer.\u02B6\u02B5\u02B9\u02B2\u02B4\u02B9\u02B7\u02BE\u02B7\u02B9\u02B2 u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B;
			u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B.hitIndex = 0;
			while (u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B.hitIndex < this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6)
			{
				Note note = this.\u02B8\u02B5\u02B8\u02BF\u02BE\u02BD\u02BB\u02BD\u02BB\u02BC\u02B6[u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B.hitIndex];
				if (!note.\u02BC\u02B9\u02B4\u02B6\u02B5\u02BC\u02BB\u02BC\u02BB\u02B4\u02B7)
				{
					bool flag = false;
					if (!this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8 && !this.\u02B3\u02BC\u02B4\u02B8\u02BB\u02B8\u02B2\u02C0\u02C0\u02B3\u02C0)
					{
						flag = true;
					}
					else if (this.\u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF <= this.\u02B5\u02B9\u02C1\u02BC\u02C0\u02BF\u02B3\u02B8\u02BD\u02BB\u02B5)
					{
						flag = true;
					}
					if (this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB > 0f && flag && ((note.\u02B5\u02BC\u02BE\u02BF\u02B6\u02B7\u02B3\u02B9\u02BF\u02B5\u02BE && (((!this.\u02B7\u02BD\u02C1\u02B3\u02BD\u02B5\u02B6\u02B8\u02B8\u02B2\u02BF) ? BaseGuitarPlayer.\u02B3\u02B9\u02B2\u02BB\u02BE\u02BF\u02B7\u02C0\u02B2\u02B7\u02BF(ref u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B) : (!this.\u02B9\u02B7\u02B5\u02BD\u02BB\u02B8\u02C0\u02B2\u02C0\u02C1\u02B9())) || BaseGuitarPlayer.\u02B3\u02B9\u02B2\u02BB\u02BE\u02BF\u02B7\u02C0\u02B2\u02B7\u02BF(ref u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B))) || (note.\u02C0\u02BF\u02B6\u02B4\u02BC\u02BD\u02BD\u02B6\u02C0\u02B3\u02BF && BaseGuitarPlayer.\u02B3\u02B9\u02B2\u02BB\u02BE\u02BF\u02B7\u02C0\u02B2\u02B7\u02BF(ref u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B) && (this.\u02B9\u02B7\u02B5\u02BD\u02BB\u02B8\u02C0\u02B2\u02C0\u02C1\u02B9() || this.\u02BA\u02BA\u02B9\u02BF\u02B8\u02B6\u02B5\u02B7\u02B9\u02C1\u02BD()))) && (this.\u02BA\u02B7\u02B5\u02C1\u02C0\u02B4\u02BE\u02BF\u02BF\u02C0\u02BE(note) || (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && this.\u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3 > 0f && note.\u02C1\u02B9\u02BD\u02B6\u02B7\u02BA\u02B5\u02B7\u02BA\u02B6\u02C0)))
					{
						this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = 0f;
						this.\u02BE\u02BC\u02BA\u02BB\u02C0\u02B5\u02B6\u02B8\u02B6\u02BB\u02B3(note);
						return;
					}
					if ((note.\u02B8\u02C1\u02BA\u02B2\u02BC\u02B6\u02C0\u02BD\u02BD\u02BA\u02BE || (note.\u02C0\u02B9\u02BD\u02B8\u02B4\u02BB\u02B4\u02B9\u02B9\u02B6\u02BD && this.\u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9())) && this.\u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA > 0f && (BaseGuitarPlayer.\u02B3\u02B9\u02B2\u02BB\u02BE\u02BF\u02B7\u02C0\u02B2\u02B7\u02BF(ref u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B) || !this.\u02B9\u02B7\u02B5\u02BD\u02BB\u02B8\u02C0\u02B2\u02C0\u02C1\u02B9()) && this.\u02BA\u02B7\u02B5\u02C1\u02C0\u02B4\u02BE\u02BF\u02BF\u02C0\u02BE(note))
					{
						this.\u02BE\u02BC\u02BA\u02BB\u02C0\u02B5\u02B6\u02B8\u02B6\u02BB\u02B3(note);
						return;
					}
				}
				int num = u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B.hitIndex + 1;
				u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B.hitIndex = num;
			}
		}
	}

	protected override void handleBotInputs()
	{
		ushort num = 0;
		foreach (Note note in this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7)
		{
			if (note.\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1)
			{
				num |= note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
			}
		}
		if (this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6 == 0)
		{
			return;
		}
		Note note2 = this.\u02B8\u02B5\u02B8\u02BF\u02BE\u02BD\u02BB\u02BD\u02BB\u02BC\u02B6[0];
		uint num2 = (uint)(note2.\u02BF\u02B4\u02BD\u02C0\u02B5\u02B3\u02B8\u02B8\u02B8\u02BB\u02C0 ? note2.\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3 : note2.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF);
		this.inputBits = num;
		__FIXME_clon_util.\u02C0\u02BF\u02B7\u02BA\u02B6\u02BA\u02B2\u02B4\u02B5\u02B8\u02B9 u02C0_u02BF_u02B7_u02BA_u02B6_u02BA_u02B2_u02B4_u02B5_u02B8_u02B = __FIXME_clon_util.\u02C1\u02BF\u02B8\u02B2\u02BA\u02B3\u02B4\u02B3\u02C1\u02BC\u02BE(num2).\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02C0_u02BF_u02B7_u02BA_u02B6_u02BA_u02B2_u02B4_u02B5_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
		{
			ushort num3 = (ushort)u02C0_u02BF_u02B7_u02BA_u02B6_u02BA_u02B2_u02B4_u02B5_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
			this.inputBits |= num3;
		}
		if (note2.\u02C0\u02B9\u02BD\u02B8\u02B4\u02BB\u02B4\u02B9\u02B9\u02B6\u02BD && this.combo > 0)
		{
			this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC;
			return;
		}
		this.\u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA = this.\u02B5\u02BA\u02C1\u02BC\u02C1\u02BB\u02BB\u02C0\u02B4\u02BB\u02BC;
	}

	protected override bool \u02BA\u02B7\u02B5\u02C1\u02C0\u02B4\u02BE\u02BF\u02BF\u02C0\u02BE(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2)
	{
		ushort num = this.inputBits;
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1)
		{
			if (this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Count > 0)
			{
				foreach (Note note in this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7)
				{
					if (note.\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1)
					{
						num &= this.m((int)(~(int)note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF));
					}
				}
				if (num == 0 && \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF == this.\u02BC\u02B2\u02BD\u02B8\u02BF\u02BB\u02C1\u02B3\u02C0\u02B8\u02B9)
				{
					return true;
				}
				if (num != this.inputBits && this.\u02B7\u02BF\u02BA\u02BF\u02C1\u02B4\u02B5\u02BD\u02C1\u02B8\u02B6(\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, num))
				{
					return true;
				}
			}
			ushort num2 = num;
			if (this.\u02B6\u02C1\u02BE\u02B3\u02BC\u02BF\u02BD\u02B6\u02BA\u02BE\u02B8.Count > 0)
			{
				foreach (Note note2 in this.\u02B6\u02C1\u02BE\u02B3\u02BC\u02BF\u02BD\u02B6\u02BA\u02BE\u02B8)
				{
					if (note2.\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1)
					{
						num2 &= this.m((int)(~(int)note2.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF));
					}
				}
				if (num2 != num && this.\u02B7\u02BF\u02BA\u02BF\u02C1\u02B4\u02B5\u02BD\u02C1\u02B8\u02B6(\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, num2))
				{
					return true;
				}
			}
		}
		return this.\u02B7\u02BF\u02BA\u02BF\u02C1\u02B4\u02B5\u02BD\u02C1\u02B8\u02B6(\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, this.inputBits);
	}

	protected override void \u02B6\u02B9\u02BC\u02C0\u02B6\u02BE\u02B4\u02BA\u02BC\u02BB\u02C1(bool \u02B8\u02BF\u02BA\u02B6\u02BD\u02B7\u02B8\u02BD\u02BB\u02B3\u02BA)
	{
		if (\u02B8\u02BF\u02BA\u02B6\u02BD\u02B7\u02B8\u02BD\u02BB\u02B3\u02BA)
		{
			if (this.\u02BF\u02C1\u02BF\u02BE\u02C1\u02B2\u02BC\u02BE\u02B3\u02BB\u02B8)
			{
				return;
			}
			if (!this.\u02C0\u02B2\u02B2\u02BA\u02B5\u02B9\u02BD\u02B6\u02BD\u02B6\u02B9 && this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Count == 0)
			{
				return;
			}
			if (this.\u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9() && this.combo > 0 && this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6 > 0 && this.\u02B8\u02B5\u02B8\u02BF\u02BE\u02BD\u02BB\u02BD\u02BB\u02BC\u02B6[0].\u02C0\u02B9\u02BD\u02B8\u02B4\u02BB\u02B4\u02B9\u02B9\u02B6\u02BD)
			{
				return;
			}
			if (this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Count > 0)
			{
				foreach (Note note in this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7)
				{
					note.\u02C1\u02BC\u02B2\u02C1\u02BC\u02B8\u02B2\u02BA\u02C1\u02B9\u02C0 = true;
					note.\u02C1\u02B8\u02B6\u02B6\u02BF\u02BF\u02BD\u02BF\u02B4\u02B6\u02C0 = false;
				}
				this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Clear();
				this.neckController.\u02B5\u02BD\u02BA\u02BE\u02B4\u02B9\u02BD\u02B3\u02B9\u02BC\u02BE();
			}
			GameAudioManager.\u02B6\u02B2\u02B3\u02BB\u02BB\u02BC\u02B9\u02BF\u02B5\u02B4\u02BB();
			this.overstrums++;
		}
		this.\u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF = 0;
		this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 = this.\u02B8\u02BA\u02BD\u02B7\u02B2\u02C0\u02BC\u02B9\u02BA\u02C1\u02C0;
		if (!this.\u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6 && this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7.Count == 0)
		{
			BassAudioManager.Instance.\u02C1\u02BA\u02B3\u02B4\u02B7\u02B3\u02B4\u02B5\u02BD\u02C1\u02BF(this.playerStuff.playerInfo.\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1, false, -1f);
			this.\u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6 = true;
		}
		base.\u02B6\u02B9\u02BC\u02C0\u02B6\u02BE\u02B4\u02BA\u02BC\u02BB\u02C1(\u02B8\u02BF\u02BA\u02B6\u02BD\u02B7\u02B8\u02BD\u02BB\u02B3\u02BA);
	}

	protected override void \u02B9\u02C0\u02B2\u02BA\u02B9\u02BF\u02BE\u02BE\u02BD\u02B4\u02B7()
	{
		base.\u02B9\u02C0\u02B2\u02BA\u02B9\u02BF\u02BE\u02BE\u02BD\u02B4\u02B7();
		if (this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7 == null)
		{
			return;
		}
		if (this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8)
		{
			this.\u02BC\u02B4\u02C1\u02C1\u02B2\u02BF\u02C1\u02B7\u02B2\u02B9\u02BD = this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF / 3f;
			this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC = this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF / 3f;
			this.\u02C1\u02BE\u02B3\u02BA\u02BE\u02BD\u02B8\u02C0\u02C1\u02BE\u02B5 = this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC;
		}
		foreach (Note note in this.\u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7)
		{
			note.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 = (float)this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
		}
	}

	protected BaseGuitarPlayer()
	{
		this.ticker = 60;
		this.\u02B5\u02BA\u02C1\u02BC\u02C1\u02BB\u02BB\u02C0\u02B4\u02BB\u02BC = 0.084f;
		this.\u02BC\u02B4\u02C1\u02C1\u02B2\u02BF\u02C1\u02B7\u02B2\u02B9\u02BD = 0.048f;
		this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC = 1f;
		this.\u02C1\u02BE\u02B3\u02BA\u02BE\u02BD\u02B8\u02C0\u02C1\u02BE\u02B5 = 1f;
		this.\u02B3\u02C0\u02BA\u02BC\u02BB\u02BF\u02B4\u02B5\u02BC\u02BD\u02BC = 0.5f;
		this.\u02B6\u02B3\u02BE\u02B6\u02B3\u02BF\u02BC\u02BA\u02C1\u02B6\u02B3 = double.MinValue;
		this.\u02B4\u02B2\u02B6\u02B5\u02BB\u02BB\u02B5\u02B3\u02B7\u02BA\u02B4 = 0.02;
		this.\u02B7\u02B6\u02B4\u02B8\u02BD\u02B2\u02BF\u02B6\u02B7\u02C1\u02BD = 0.3;
		this.\u02B5\u02B9\u02C1\u02BC\u02C0\u02BF\u02B3\u02B8\u02BD\u02BB\u02B5 = 4;
		this.\u02B8\u02BA\u02BD\u02B7\u02B2\u02C0\u02BC\u02B9\u02BA\u02C1\u02C0 = 1f;
		this.\u02C0\u02BE\u02C1\u02BB\u02C0\u02BE\u02B2\u02B5\u02B8\u02BA\u02BF = 0.025f;
		if (BaseGuitarPlayer.instance == null)
		{
			BaseGuitarPlayer.instance = this;
		}
	}

	[CompilerGenerated]
	internal static bool \u02B3\u02B9\u02B2\u02BB\u02BE\u02BF\u02B7\u02C0\u02B2\u02B7\u02BF(ref BaseGuitarPlayer.\u02B6\u02B5\u02B9\u02B2\u02B4\u02B9\u02B7\u02BE\u02B7\u02B9\u02B2 A_0)
	{
		return A_0.hitIndex == 0;
	}

	[CompilerGenerated]
	private bool \u02B9\u02B7\u02B5\u02BD\u02BB\u02B8\u02C0\u02B2\u02C0\u02C1\u02B9()
	{
		return this.combo != 0;
	}

	[CompilerGenerated]
	private bool \u02BA\u02BA\u02B9\u02BF\u02B8\u02B6\u02B5\u02B7\u02B9\u02C1\u02BD()
	{
		return GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 && !this.\u02B7\u02BD\u02C1\u02B3\u02BD\u02B5\u02B6\u02B8\u02B8\u02B2\u02BF;
	}

	public BaseGuitarPlayer.inputmap Inputs
	{
		get
		{
			ushort inputBits = this.inputBits;
			return new BaseGuitarPlayer.inputmap
			{
				g = ((inputBits & 1) > 0),
				r = ((inputBits & 2) > 0),
				y = ((inputBits & 4) > 0),
				b = ((inputBits & 8) > 0),
				o = ((inputBits & 16) > 0),
				su = this.minputs.su,
				sd = this.minputs.sd,
				sutime = this.minputs.sutime,
				sdtime = this.minputs.sdtime,
				sucount = this.minputs.sucount,
				sdcount = this.minputs.sdcount,
				gcount = this.minputs.gcount,
				gptime = this.minputs.gptime,
				rcount = this.minputs.rcount,
				rptime = this.minputs.rptime,
				ycount = this.minputs.ycount,
				yptime = this.minputs.yptime,
				bcount = this.minputs.bcount,
				bptime = this.minputs.bptime,
				ocount = this.minputs.ocount,
				optime = this.minputs.optime
			};
		}
		set
		{
			ushort num = 0;
			int num2 = 0;
			num2 = (value.g ? (num2 | 1) : ((int)num));
			num2 = (value.r ? (num2 | 2) : ((int)num));
			num2 = (value.y ? (num2 | 4) : ((int)num));
			num2 = (value.b ? (num2 | 8) : ((int)num));
			num2 = (value.o ? (num2 | 16) : ((int)num));
			num = (ushort)num2;
			this.minputs.g = value.g;
			this.minputs.r = value.r;
			this.minputs.y = value.y;
			this.minputs.b = value.b;
			this.minputs.o = value.o;
			this.inputBits = num;
		}
	}

	public ushort m(int i)
	{
		return (ushort)i;
	}

	private void OnDestroy()
	{
		BaseGuitarPlayer.instance = null;
	}

	protected float \u02BA\u02B3\u02B4\u02B6\u02B5\u02B9\u02B7\u02B9\u02B8\u02C0\u02BA;

	protected float \u02B5\u02BA\u02C1\u02BC\u02C1\u02BB\u02BB\u02C0\u02B4\u02BB\u02BC;

	protected float \u02BC\u02B4\u02C1\u02C1\u02B2\u02BF\u02C1\u02B7\u02B2\u02B9\u02BD;

	protected float \u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7;

	protected float \u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB;

	protected float \u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC;

	protected float \u02C1\u02BE\u02B3\u02BA\u02BE\u02BD\u02B8\u02C0\u02C1\u02BE\u02B5;

	protected float \u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3;

	protected float \u02B3\u02C0\u02BA\u02BC\u02BB\u02BF\u02B4\u02B5\u02BC\u02BD\u02BC;

	protected float \u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD;

	protected float \u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF;

	private double \u02B6\u02B3\u02BE\u02B6\u02B3\u02BF\u02BC\u02BA\u02C1\u02B6\u02B3;

	private double \u02BE\u02B3\u02B8\u02BD\u02B2\u02BD\u02B4\u02BF\u02C1\u02BD\u02B3;

	private bool \u02C1\u02B8\u02B7\u02BB\u02B4\u02BE\u02BB\u02B5\u02B3\u02B6\u02B2;

	private double \u02BE\u02B9\u02BB\u02B6\u02BC\u02B2\u02BD\u02BC\u02C0\u02C1\u02B5;

	private double \u02B4\u02B2\u02B6\u02B5\u02BB\u02BB\u02B5\u02B3\u02B7\u02BA\u02B4;

	private double \u02B7\u02B6\u02B4\u02B8\u02BD\u02B2\u02BF\u02B6\u02B7\u02C1\u02BD;

	private int \u02B5\u02B9\u02C1\u02BC\u02C0\u02BF\u02B3\u02B8\u02BD\u02BB\u02B5;

	private int \u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF;

	private float \u02B8\u02BA\u02BD\u02B7\u02B2\u02C0\u02BC\u02B9\u02BA\u02C1\u02C0;

	private float \u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3;

	protected ushort \u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3;

	protected ushort \u02BC\u02B8\u02B5\u02BB\u02BB\u02B7\u02C1\u02B6\u02BC\u02B4\u02BE;

	protected float \u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3;

	protected float \u02C0\u02BE\u02C1\u02BB\u02C0\u02BE\u02B2\u02B5\u02B8\u02BA\u02BF;

	public float \u02BB\u02B8\u02BE\u02B7\u02B2\u02BA\u02B8\u02BA\u02BF\u02C1\u02B9;

	protected float \u02BF\u02B7\u02C1\u02BF\u02B6\u02BB\u02B7\u02B2\u02B6\u02B7\u02B9;

	[HideInInspector]
	public float \u02B9\u02B7\u02B7\u02BF\u02BB\u02C0\u02C1\u02C1\u02C0\u02B2\u02BC;

	public List<Note> \u02BD\u02BD\u02BC\u02BC\u02BB\u02BE\u02BC\u02BE\u02B2\u02C1\u02B7;

	private List<double> \u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA;

	public List<Note> \u02B6\u02C1\u02BE\u02B3\u02BC\u02BF\u02BD\u02B6\u02BA\u02BE\u02B8;

	private bool \u02B3\u02B3\u02BD\u02C0\u02B6\u02B7\u02C0\u02BA\u02BB\u02B9\u02B9;

	private double \u02BA\u02B2\u02B5\u02B2\u02B6\u02BF\u02B7\u02B6\u02BF\u02C0\u02B7;

	protected bool \u02B4\u02BA\u02BA\u02B3\u02C0\u02BC\u02BD\u02BA\u02B5\u02B2\u02B8;

	protected bool \u02B6\u02C0\u02BA\u02BF\u02B7\u02B8\u02B2\u02B2\u02B5\u02B6\u02B2;

	public BaseGuitarPlayer.inputmap lastinputs;

	public BaseGuitarPlayer.inputmap minputs;

	public static BaseGuitarPlayer instance;

	private int ticker;

	[CompilerGenerated]
	public struct \u02B6\u02B5\u02B9\u02B2\u02B4\u02B9\u02B7\u02BE\u02B7\u02B9\u02B2
	{
		public int hitIndex;
	}

	public struct inputmap
	{
		public override string ToString()
		{
			string text = "<cspace=-0.7em>███████<color=#000000FF>█";
			string text2 = "<cspace=-0.7em>▀▀▀▀▀▀▀<color=#000000FF>█";
			string text3 = "<cspace=-0.7em>▄▄▄▄▄▄▄<color=#000000FF>█";
			string text4 = "<color=REPLACEWITHSTRUMCOLOR>";
			string text5 = "<color=#000000FF>";
			return string.Format("<i>{12}{6}{0}{7}{1}{8}{2}{9}{3}{10}{4} {12}{11}{5}</i></cspace>", new object[]
			{
				text,
				text,
				text,
				text,
				text,
				(this.su && this.sd) ? text : ((this.su && !this.sd) ? text2 : ((!this.su && this.sd) ? text3 : (text5 + text))),
				this.g ? ("<color=" + GlobalHelper.greenFretColor + ">") : text5,
				this.r ? ("<color=" + GlobalHelper.redFretColor + ">") : text5,
				this.y ? ("<color=" + GlobalHelper.yellowFretColor + ">") : text5,
				this.b ? ("<color=" + GlobalHelper.blueFretColor + ">") : text5,
				this.o ? ("<color=" + GlobalHelper.orangeFretColor + ">") : text5,
				text4,
				"                                   "
			});
		}

		public char[] ToCharArray()
		{
			char[] array;
			using (Utf16ValueStringBuilder utf16ValueStringBuilder = ZString.CreateStringBuilder())
			{
				utf16ValueStringBuilder.Append("<i>                                   <cspace=-0.7em>");
				if (this.su && this.sd)
				{
					utf16ValueStringBuilder.Append("<color=#cc11cc>███████<color=#000000FF>█");
				}
				else if (this.su && !this.sd)
				{
					utf16ValueStringBuilder.Append("<color=#cc11cc>▀▀▀▀▀▀▀<color=#000000FF>█");
				}
				else if (!this.su && this.sd)
				{
					utf16ValueStringBuilder.Append("<color=#cc11cc>▄▄▄▄▄▄▄<color=#000000FF>█");
				}
				else
				{
					utf16ValueStringBuilder.Append("<color=#000000FF>");
					utf16ValueStringBuilder.Append("████████");
				}
				if (this.g)
				{
					utf16ValueStringBuilder.Append("<color=");
					utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_greenFretColor));
				}
				else
				{
					utf16ValueStringBuilder.Append("<color=#000000FF");
				}
				utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
				if (this.r)
				{
					utf16ValueStringBuilder.Append("<color=");
					utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_redFretColor));
				}
				else
				{
					utf16ValueStringBuilder.Append("<color=#000000FF");
				}
				utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
				if (this.y)
				{
					utf16ValueStringBuilder.Append("<color=");
					utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_yellowFretColor));
				}
				else
				{
					utf16ValueStringBuilder.Append("<color=#000000FF");
				}
				utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
				if (this.b)
				{
					utf16ValueStringBuilder.Append("<color=");
					utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_blueFretColor));
				}
				else
				{
					utf16ValueStringBuilder.Append("<color=#000000FF");
				}
				utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
				if (this.o)
				{
					utf16ValueStringBuilder.Append("<color=");
					utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_orangeFretColor));
				}
				else
				{
					utf16ValueStringBuilder.Append("<color=#000000FF");
				}
				utf16ValueStringBuilder.Append(">███████<color=#000000FF>█</cspace></i>");
				array = utf16ValueStringBuilder.AsArraySegment().ToArray<char>();
				utf16ValueStringBuilder.Dispose();
			}
			return array;
		}

		public void AppendToZString(Utf16ValueStringBuilder utf16ValueStringBuilder)
		{
			if (!this.sd)
			{
				utf16ValueStringBuilder.Clear();
			}
			utf16ValueStringBuilder.Append("<i>                                   <cspace=-0.7em>");
			if (this.su && this.sd)
			{
				utf16ValueStringBuilder.Append("<color=#cc11cc>███████<color=#000000FF>█");
			}
			else if (this.su && !this.sd)
			{
				utf16ValueStringBuilder.Append("<color=#cc11cc>▀▀▀▀▀▀▀<color=#000000FF>█");
			}
			else if (!this.su && this.sd)
			{
				utf16ValueStringBuilder.Append("<color=#cc11cc>▄▄▄▄▄▄▄<color=#000000FF>█");
			}
			else
			{
				utf16ValueStringBuilder.Append("<color=#000000FF>");
				utf16ValueStringBuilder.Append("████████");
			}
			if (this.g)
			{
				utf16ValueStringBuilder.Append("<color=");
				utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_greenFretColor));
			}
			else
			{
				utf16ValueStringBuilder.Append("<color=#000000FF");
			}
			utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
			if (this.r)
			{
				utf16ValueStringBuilder.Append("<color=");
				utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_redFretColor));
			}
			else
			{
				utf16ValueStringBuilder.Append("<color=#000000FF");
			}
			utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
			if (this.y)
			{
				utf16ValueStringBuilder.Append("<color=");
				utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_yellowFretColor));
			}
			else
			{
				utf16ValueStringBuilder.Append("<color=#000000FF");
			}
			utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
			if (this.b)
			{
				utf16ValueStringBuilder.Append("<color=");
				utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_blueFretColor));
			}
			else
			{
				utf16ValueStringBuilder.Append("<color=#000000FF");
			}
			utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
			if (this.o)
			{
				utf16ValueStringBuilder.Append("<color=");
				utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_orangeFretColor));
			}
			else
			{
				utf16ValueStringBuilder.Append("<color=#000000FF");
			}
			utf16ValueStringBuilder.Append(">███████<color=#000000FF>█</cspace></i>");
		}

		public bool g;

		public bool r;

		public bool y;

		public bool b;

		public bool o;

		public int gcount;

		public int rcount;

		public int ycount;

		public int bcount;

		public int ocount;

		public bool su;

		public bool sd;

		public float gptime;

		public float rptime;

		public float yptime;

		public float bptime;

		public float optime;

		public int sucount;

		public int sdcount;

		public float sutime;

		public float sdtime;
	}

	public enum GuitarButtons
	{
		Green,
		Red,
		Yellow,
		Blue,
		Orange,
		Upstrum,
		Downstrum = 14
	}
}
