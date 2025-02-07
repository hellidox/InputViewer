﻿using System;
using UnityEngine;

public class DrumsFretAnimator : Fret_Animator
{
	public override void \u02BB\u02BF\u02B2\u02B3\u02BD\u02BB\u02BE\u02BD\u02BB\u02BE\u02B3()
	{
		base.\u02BB\u02BF\u02B2\u02B3\u02BD\u02BB\u02BE\u02BD\u02BB\u02BE\u02B3();
		if (this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8.y <= this.\u02B7\u02BF\u02B4\u02BD\u02C1\u02B3\u02B4\u02C0\u02B5\u02C0\u02B9)
		{
			this.\u02BC\u02BF\u02BF\u02BC\u02B4\u02C1\u02B5\u02B5\u02BE\u02B4\u02C0(-0.013f);
		}
	}

	private void \u02BF\u02BE\u02B7\u02B3\u02C0\u02B8\u02BD\u02BE\u02BF\u02BD\u02B2(float \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8)
	{
		this.\u02BD\u02B7\u02B9\u02B2\u02BB\u02BF\u02B5\u02B3\u02B8\u02C0\u02B7 = Mathf.Sign(\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8);
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 800f;
		this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9 = this.\u02BD\u02B7\u02B9\u02B2\u02BB\u02BF\u02B5\u02B3\u02B8\u02C0\u02B7 * \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
	}

	public override void \u02C0\u02BE\u02B5\u02BF\u02B4\u02B9\u02B6\u02BD\u02BC\u02B7\u02B7()
	{
		base.\u02C0\u02BE\u02B5\u02BF\u02B4\u02B9\u02B6\u02BD\u02BC\u02B7\u02B7();
	}

	private float \u02B6\u02B9\u02B2\u02C1\u02B9\u02B6\u02B5\u02BA\u02BD\u02B2\u02B2()
	{
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9 -= this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9 * (Time.deltaTime * this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 * 8f);
		return this.\u02BD\u02B7\u02B9\u02B2\u02BB\u02BF\u02B5\u02B3\u02B8\u02C0\u02B7 * Mathf.PingPong(this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 * 0.9f, this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9);
	}

	private float \u02B4\u02B6\u02B7\u02BE\u02C1\u02C0\u02BB\u02C1\u02BA\u02B9\u02B8()
	{
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9 -= this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9 * (Time.deltaTime * this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 * 333f);
		return this.\u02BD\u02B7\u02B9\u02B2\u02BB\u02BF\u02B5\u02B3\u02B8\u02C0\u02B7 * Mathf.PingPong(this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 * 78f, this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9);
	}

	private float \u02B7\u02C1\u02C0\u02B2\u02B9\u02BA\u02BD\u02B3\u02BD\u02B7\u02BE()
	{
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9 -= this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9 * (Time.deltaTime * this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 * 1393f);
		return this.\u02BD\u02B7\u02B9\u02B2\u02BB\u02BF\u02B5\u02B3\u02B8\u02C0\u02B7 * Mathf.PingPong(this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 * 1454f, this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9);
	}

	public virtual void \u02B4\u02BA\u02B2\u02B7\u02BA\u02BA\u02B4\u02B4\u02BA\u02BA\u02BE()
	{
		Vector3 vector = this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8 + new Vector3(1673f, this.\u02B7\u02C1\u02C0\u02B2\u02B9\u02BA\u02BD\u02B3\u02BD\u02B7\u02BE(), 1539f);
		if (float.IsNaN(vector.y))
		{
			vector.y = 926f;
		}
		this.\u02C1\u02C1\u02B3\u02BA\u02B5\u02BD\u02BE\u02B2\u02B6\u02B7\u02B4.localPosition = vector;
	}

	protected virtual void \u02BC\u02B6\u02BF\u02B2\u02BF\u02BD\u02BC\u02BF\u02BC\u02C1\u02BD()
	{
		this.\u02BF\u02BA\u02BD\u02BE\u02BA\u02BD\u02B5\u02BD\u02B7\u02B9\u02B5.color = base.colorInfo.\u02BE\u02BB\u02C1\u02B7\u02BA\u02B5\u02BD\u02BB\u02B6\u02BA\u02BB[this.fretIndex];
		this.\u02B6\u02B5\u02B9\u02B2\u02B7\u02BF\u02B3\u02BB\u02C0\u02B3\u02B7.color = base.colorInfo.\u02BE\u02BB\u02C1\u02B7\u02BA\u02B5\u02BD\u02BB\u02B6\u02BA\u02BB[this.fretIndex];
		this.\u02BE\u02BA\u02BB\u02B3\u02BC\u02BB\u02B9\u02C0\u02B7\u02B8\u02BD.color = base.colorInfo.\u02BE\u02BB\u02C1\u02B7\u02BA\u02B5\u02BD\u02BB\u02B6\u02BA\u02BB[this.fretIndex];
		this.fretRingTop.color = base.colorInfo.\u02B9\u02B9\u02BF\u02B7\u02B7\u02B8\u02B4\u02BF\u02BE\u02BD\u02B2[this.fretIndex];
		this.fretRingBottom.color = base.colorInfo.\u02B9\u02B9\u02BF\u02B7\u02B7\u02B8\u02B4\u02BF\u02BE\u02BD\u02B2[this.fretIndex];
		this.\u02B4\u02BA\u02B3\u02B5\u02B7\u02B3\u02BE\u02BD\u02B3\u02BC\u02B9.color = base.colorInfo.\u02BB\u02BA\u02B3\u02B7\u02B5\u02B8\u02B3\u02BF\u02C1\u02B2\u02B8[this.fretIndex];
		this.\u02B9\u02BF\u02B9\u02BB\u02BA\u02BB\u02C1\u02C0\u02BC\u02C0\u02C1.color = base.colorInfo.\u02B8\u02B7\u02BD\u02BE\u02B9\u02B8\u02B5\u02B7\u02BA\u02BE\u02BD[this.fretIndex];
	}

	protected override void \u02B7\u02B8\u02B9\u02BA\u02BC\u02B7\u02C0\u02B2\u02B6\u02BA\u02B7()
	{
		if (this.\u02BA\u02B4\u02BB\u02BD\u02C0\u02BD\u02B8\u02B7\u02B3\u02B2\u02B6)
		{
			this.\u02B4\u02BA\u02B3\u02B5\u02B7\u02B3\u02BE\u02BD\u02B3\u02BC\u02B9.enabled = true;
			this.\u02B4\u02BA\u02B3\u02B5\u02B7\u02B3\u02BE\u02BD\u02B3\u02BC\u02B9.color = base.colorInfo.\u02BE\u02B5\u02B7\u02C0\u02BD\u02B8\u02BE\u02BE\u02BB\u02BB\u02BD;
			this.\u02B9\u02BF\u02B9\u02BB\u02BA\u02BB\u02C1\u02C0\u02BC\u02C0\u02C1.color = base.colorInfo.\u02BE\u02B5\u02B7\u02C0\u02BD\u02B8\u02BE\u02BE\u02BB\u02BB\u02BD;
			return;
		}
		this.\u02B9\u02BF\u02B9\u02BB\u02BA\u02BB\u02C1\u02C0\u02BC\u02C0\u02C1.enabled = true;
		this.\u02B4\u02BA\u02B3\u02B5\u02B7\u02B3\u02BE\u02BD\u02B3\u02BC\u02B9.color = base.colorInfo.\u02BB\u02BA\u02B3\u02B7\u02B5\u02B8\u02B3\u02BF\u02C1\u02B2\u02B8[this.fretIndex];
		this.\u02B9\u02BF\u02B9\u02BB\u02BA\u02BB\u02C1\u02C0\u02BC\u02C0\u02C1.color = base.colorInfo.\u02B8\u02B7\u02BD\u02BE\u02B9\u02B8\u02B5\u02B7\u02BA\u02BE\u02BD[this.fretIndex];
	}

	private float \u02BE\u02BB\u02BA\u02C0\u02BE\u02B6\u02BD\u02BD\u02B3\u02B9\u02BE()
	{
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9 -= this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9 * (Time.deltaTime * this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 * 1559f);
		return this.\u02BD\u02B7\u02B9\u02B2\u02BB\u02BF\u02B5\u02B3\u02B8\u02C0\u02B7 * Mathf.PingPong(this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 * 1914f, this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9);
	}

	protected override void \u02B2\u02C1\u02B4\u02BB\u02BA\u02B4\u02BE\u02B7\u02BB\u02B4\u02BA()
	{
		this.\u02BF\u02BA\u02BD\u02BE\u02BA\u02BD\u02B5\u02BD\u02B7\u02B9\u02B5.color = base.colorInfo.\u02BE\u02BB\u02C1\u02B7\u02BA\u02B5\u02BD\u02BB\u02B6\u02BA\u02BB[this.fretIndex];
		this.\u02B6\u02B5\u02B9\u02B2\u02B7\u02BF\u02B3\u02BB\u02C0\u02B3\u02B7.color = base.colorInfo.\u02BE\u02BB\u02C1\u02B7\u02BA\u02B5\u02BD\u02BB\u02B6\u02BA\u02BB[this.fretIndex];
		this.\u02BE\u02BA\u02BB\u02B3\u02BC\u02BB\u02B9\u02C0\u02B7\u02B8\u02BD.color = base.colorInfo.\u02BE\u02BB\u02C1\u02B7\u02BA\u02B5\u02BD\u02BB\u02B6\u02BA\u02BB[this.fretIndex];
		this.fretRingTop.color = base.colorInfo.\u02B9\u02B9\u02BF\u02B7\u02B7\u02B8\u02B4\u02BF\u02BE\u02BD\u02B2[this.fretIndex];
		this.fretRingBottom.color = base.colorInfo.\u02B9\u02B9\u02BF\u02B7\u02B7\u02B8\u02B4\u02BF\u02BE\u02BD\u02B2[this.fretIndex];
		this.\u02B4\u02BA\u02B3\u02B5\u02B7\u02B3\u02BE\u02BD\u02B3\u02BC\u02B9.color = base.colorInfo.\u02BB\u02BA\u02B3\u02B7\u02B5\u02B8\u02B3\u02BF\u02C1\u02B2\u02B8[this.fretIndex];
		this.\u02B9\u02BF\u02B9\u02BB\u02BA\u02BB\u02C1\u02C0\u02BC\u02C0\u02C1.color = base.colorInfo.\u02B8\u02B7\u02BD\u02BE\u02B9\u02B8\u02B5\u02B7\u02BA\u02BE\u02BD[this.fretIndex];
	}

	public virtual void \u02B6\u02B6\u02BF\u02B2\u02B2\u02BE\u02C1\u02C0\u02B3\u02BA\u02B6()
	{
		base.\u02C0\u02BE\u02B5\u02BF\u02B4\u02B9\u02B6\u02BD\u02BC\u02B7\u02B7();
	}

	public override void \u02BA\u02B6\u02B3\u02BC\u02BD\u02B4\u02B5\u02B4\u02B7\u02B6\u02B5()
	{
		Vector3 vector = this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8 + new Vector3(0f, this.\u02B6\u02B9\u02B2\u02C1\u02B9\u02B6\u02B5\u02BA\u02BD\u02B2\u02B2(), 0f);
		if (float.IsNaN(vector.y))
		{
			vector.y = 0f;
		}
		this.\u02C1\u02C1\u02B3\u02BA\u02B5\u02BD\u02BE\u02B2\u02B6\u02B7\u02B4.localPosition = vector;
	}

	protected override void \u02B7\u02BE\u02B6\u02BF\u02C1\u02B9\u02B8\u02B5\u02B2\u02B2\u02B9()
	{
		this.\u02BF\u02BA\u02BD\u02BE\u02BA\u02BD\u02B5\u02BD\u02B7\u02B9\u02B5.color = base.colorInfo.\u02BE\u02BB\u02C1\u02B7\u02BA\u02B5\u02BD\u02BB\u02B6\u02BA\u02BB[this.fretIndex];
		this.\u02B6\u02B5\u02B9\u02B2\u02B7\u02BF\u02B3\u02BB\u02C0\u02B3\u02B7.color = base.colorInfo.\u02BE\u02BB\u02C1\u02B7\u02BA\u02B5\u02BD\u02BB\u02B6\u02BA\u02BB[this.fretIndex];
		this.\u02BE\u02BA\u02BB\u02B3\u02BC\u02BB\u02B9\u02C0\u02B7\u02B8\u02BD.color = base.colorInfo.\u02BE\u02BB\u02C1\u02B7\u02BA\u02B5\u02BD\u02BB\u02B6\u02BA\u02BB[this.fretIndex];
		this.fretRingTop.color = base.colorInfo.\u02B9\u02B9\u02BF\u02B7\u02B7\u02B8\u02B4\u02BF\u02BE\u02BD\u02B2[this.fretIndex];
		this.fretRingBottom.color = base.colorInfo.\u02B9\u02B9\u02BF\u02B7\u02B7\u02B8\u02B4\u02BF\u02BE\u02BD\u02B2[this.fretIndex];
		this.\u02B4\u02BA\u02B3\u02B5\u02B7\u02B3\u02BE\u02BD\u02B3\u02BC\u02B9.color = base.colorInfo.\u02BB\u02BA\u02B3\u02B7\u02B5\u02B8\u02B3\u02BF\u02C1\u02B2\u02B8[this.fretIndex];
		this.\u02B9\u02BF\u02B9\u02BB\u02BA\u02BB\u02C1\u02C0\u02BC\u02C0\u02C1.color = base.colorInfo.\u02B8\u02B7\u02BD\u02BE\u02B9\u02B8\u02B5\u02B7\u02BA\u02BE\u02BD[this.fretIndex];
	}

	public virtual void \u02C1\u02BE\u02B9\u02BA\u02B5\u02B9\u02BB\u02BA\u02BC\u02B3\u02BA()
	{
		base.\u02BD\u02B5\u02BB\u02B3\u02C0\u02BC\u02B4\u02BD\u02B4\u02BE\u02BB();
		if (this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8.y <= this.\u02B7\u02BF\u02B4\u02BD\u02C1\u02B3\u02B4\u02C0\u02B5\u02C0\u02B9)
		{
			this.\u02BC\u02BF\u02BF\u02BC\u02B4\u02C1\u02B5\u02B5\u02BE\u02B4\u02C0(1166f);
		}
	}

	public virtual void \u02BC\u02B6\u02B7\u02B5\u02B8\u02B8\u02C1\u02BC\u02BA\u02BE\u02C1()
	{
		base.\u02C0\u02BE\u02B5\u02BF\u02B4\u02B9\u02B6\u02BD\u02BC\u02B7\u02B7();
	}

	public virtual void \u02B6\u02BF\u02B5\u02C1\u02C1\u02B9\u02B6\u02BD\u02B4\u02B8\u02BF(bool \u02B5\u02C1\u02BD\u02B8\u02BB\u02B2\u02B8\u02B9\u02B8\u02B4\u02BA, bool \u02B9\u02B9\u02B8\u02C0\u02B3\u02BE\u02B4\u02BA\u02BA\u02BB\u02B8)
	{
		base.Play(this.isSustaining, \u02B9\u02B9\u02B8\u02C0\u02B3\u02BE\u02B4\u02BA\u02BA\u02BB\u02B8);
		this.\u02BF\u02BE\u02B7\u02B3\u02C0\u02B8\u02BD\u02BE\u02BF\u02BD\u02B2(905f);
	}

	protected virtual void \u02B9\u02B3\u02BD\u02B9\u02BC\u02B9\u02BA\u02B2\u02B8\u02C1\u02BB()
	{
		if (this.\u02BA\u02B4\u02BB\u02BD\u02C0\u02BD\u02B8\u02B7\u02B3\u02B2\u02B6)
		{
			this.\u02B4\u02BA\u02B3\u02B5\u02B7\u02B3\u02BE\u02BD\u02B3\u02BC\u02B9.enabled = true;
			this.\u02B4\u02BA\u02B3\u02B5\u02B7\u02B3\u02BE\u02BD\u02B3\u02BC\u02B9.color = base.colorInfo.\u02BE\u02B5\u02B7\u02C0\u02BD\u02B8\u02BE\u02BE\u02BB\u02BB\u02BD;
			this.\u02B9\u02BF\u02B9\u02BB\u02BA\u02BB\u02C1\u02C0\u02BC\u02C0\u02C1.color = base.colorInfo.\u02BE\u02B5\u02B7\u02C0\u02BD\u02B8\u02BE\u02BE\u02BB\u02BB\u02BD;
			return;
		}
		this.\u02B9\u02BF\u02B9\u02BB\u02BA\u02BB\u02C1\u02C0\u02BC\u02C0\u02C1.enabled = false;
		this.\u02B4\u02BA\u02B3\u02B5\u02B7\u02B3\u02BE\u02BD\u02B3\u02BC\u02B9.color = base.colorInfo.\u02BB\u02BA\u02B3\u02B7\u02B5\u02B8\u02B3\u02BF\u02C1\u02B2\u02B8[this.fretIndex];
		this.\u02B9\u02BF\u02B9\u02BB\u02BA\u02BB\u02C1\u02C0\u02BC\u02C0\u02C1.color = base.colorInfo.\u02B8\u02B7\u02BD\u02BE\u02B9\u02B8\u02B5\u02B7\u02BA\u02BE\u02BD[this.fretIndex];
	}

	public virtual void \u02B8\u02BB\u02BC\u02B2\u02B8\u02B5\u02B9\u02B4\u02B5\u02BA\u02B8()
	{
		base.\u02C0\u02BE\u02B5\u02BF\u02B4\u02B9\u02B6\u02BD\u02BC\u02B7\u02B7();
	}

	public virtual void \u02B4\u02BB\u02BD\u02BD\u02BB\u02BE\u02B9\u02B3\u02C0\u02C0\u02BA()
	{
		base.\u02BB\u02BF\u02B2\u02B3\u02BD\u02BB\u02BE\u02BD\u02BB\u02BE\u02B3();
		if (this.\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8.y <= this.\u02B7\u02BF\u02B4\u02BD\u02C1\u02B3\u02B4\u02C0\u02B5\u02C0\u02B9)
		{
			this.\u02BC\u02BF\u02BF\u02BC\u02B4\u02C1\u02B5\u02B5\u02BE\u02B4\u02C0(787f);
		}
	}

	private float \u02C0\u02BD\u02C0\u02B4\u02B3\u02BC\u02B9\u02B5\u02C1\u02B6\u02BF()
	{
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9 -= this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9 * (Time.deltaTime * this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 * 1349f);
		return this.\u02BD\u02B7\u02B9\u02B2\u02BB\u02BF\u02B5\u02B3\u02B8\u02C0\u02B7 * Mathf.PingPong(this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 * 540f, this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9);
	}

	private void \u02BC\u02BF\u02BF\u02BC\u02B4\u02C1\u02B5\u02B5\u02BE\u02B4\u02C0(float \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8)
	{
		this.\u02BD\u02B7\u02B9\u02B2\u02BB\u02BF\u02B5\u02B3\u02B8\u02C0\u02B7 = Mathf.Sign(\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8);
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 0f;
		this.\u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9 = this.\u02BD\u02B7\u02B9\u02B2\u02BB\u02BF\u02B5\u02B3\u02B8\u02C0\u02B7 * \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
	}

	public override void Play(bool \u02B5\u02C1\u02BD\u02B8\u02BB\u02B2\u02B8\u02B9\u02B8\u02B4\u02BA, bool \u02B9\u02B9\u02B8\u02C0\u02B3\u02BE\u02B4\u02BA\u02BA\u02BB\u02B8)
	{
		base.Play(this.isSustaining, \u02B9\u02B9\u02B8\u02C0\u02B3\u02BE\u02B4\u02BA\u02BA\u02BB\u02B8);
		this.\u02BC\u02BF\u02BF\u02BC\u02B4\u02C1\u02B5\u02B5\u02BE\u02B4\u02C0(0.015f);
	}

	private float \u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6;

	private float \u02B7\u02B4\u02B3\u02BB\u02B9\u02BA\u02C1\u02C1\u02BD\u02BE\u02B9 = 0.032f;

	private float \u02BD\u02B7\u02B9\u02B2\u02BB\u02BF\u02B5\u02B3\u02B8\u02C0\u02B7;
}
