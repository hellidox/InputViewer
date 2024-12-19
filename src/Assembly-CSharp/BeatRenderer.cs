﻿using System;
using UnityEngine;

[RequireComponent(typeof(BasePlayer))]
public class BeatRenderer : MonoBehaviour, \u02B6\u02BB\u02BD\u02BB\u02BA\u02B6\u02B9\u02C0\u02B8\u02B4\u02BC
{
	private float \u02B9\u02B6\u02B8\u02BE\u02C1\u02B8\u02B9\u02B2\u02B7\u02C0\u02B4(\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7 \u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4)
	{
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.MEASURE)
		{
			return 1984f * this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7;
		}
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == (\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7)8)
		{
			return 759f * this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7;
		}
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.MEASURE)
		{
			return 1252f * this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7;
		}
		return 766f;
	}

	public void \u02BC\u02BC\u02BD\u02BF\u02B2\u02B6\u02C1\u02C0\u02B2\u02BE\u02B6()
	{
		int i = 0;
		while (i < this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1)
		{
			int num = this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 + i;
			if (num > this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4)
			{
				break;
			}
			double num2 = (double)this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.times[num] - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB;
			float num3 = (float)((double)this.\u02BA\u02BF\u02B4\u02B8\u02B8\u02B4\u02BA\u02C0\u02B5\u02BB\u02BD + num2 * (double)this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4) + this.\u02B9\u02BA\u02B9\u02B7\u02BC\u02BA\u02B2\u02BB\u02BC\u02C0\u02B8;
			if (num3 > this.\u02B7\u02B5\u02B5\u02C1\u02B7\u02B5\u02BE\u02BA\u02BF\u02BE\u02C0)
			{
				break;
			}
			if (num3 <= this.\u02BB\u02C0\u02BF\u02C0\u02B4\u02B9\u02B4\u02B7\u02B5\u02BF\u02BE)
			{
				this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5++;
			}
			else
			{
				this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].SetActive(true);
				this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1[i].localScale = new Vector3(this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7, this.\u02B5\u02BB\u02B2\u02BA\u02BD\u02BB\u02B8\u02B2\u02C1\u02B2\u02BA(this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num]));
				this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1[i].localPosition = new Vector3(0f, 0f, num3);
				Color color;
				if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num] == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.MEASURE)
				{
					color = this.\u02B5\u02BD\u02B6\u02BA\u02B7\u02C0\u02B5\u02B3\u02B5\u02BE\u02BD;
				}
				else if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num] == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.BEAT_WEAK)
				{
					color = this.\u02B8\u02C0\u02B4\u02BF\u02BD\u02BA\u02B8\u02BF\u02C0\u02BC\u02BE;
				}
				else
				{
					color = this.\u02BE\u02B2\u02B3\u02BD\u02C1\u02BF\u02C0\u02BA\u02B3\u02B9\u02C0;
				}
				this.\u02B3\u02B6\u02BB\u02BE\u02C1\u02BD\u02BF\u02C1\u02C1\u02BC\u02BC[i].color = color;
				i++;
			}
		}
		while (i < this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB.Length && this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].activeSelf)
		{
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].SetActive(false);
			i++;
		}
	}

	private void \u02BF\u02B3\u02C0\u02B6\u02B5\u02B9\u02C0\u02B6\u02C1\u02B9\u02B3()
	{
		this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = base.GetComponent<BasePlayer>();
		if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0 == null || this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count == 0)
		{
			this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 = -1;
			return;
		}
		float num = 208f;
		foreach (Note note in this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0)
		{
			if (note.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 > num)
			{
				num = note.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0;
			}
		}
		this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.count - 1;
		while (this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 > 1 && num <= this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.times[this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4])
		{
			this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4--;
		}
		if (this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 < this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.count - 0)
		{
			this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4++;
		}
	}

	private void \u02B3\u02BF\u02C1\u02B4\u02B3\u02B5\u02B6\u02B7\u02B4\u02B9\u02C0()
	{
		this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB = new GameObject[this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1];
		this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1 = new Transform[this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1];
		this.\u02B3\u02B6\u02BB\u02BE\u02C1\u02BD\u02BF\u02C1\u02C1\u02BC\u02BC = new SpriteRenderer[this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1];
		GameObject gameObject = Resources.Load("bad_note1") as GameObject;
		for (int i = 0; i < this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1; i += 0)
		{
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i] = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, gameObject.transform.rotation);
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].SetActive(false);
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].transform.parent = base.transform;
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].transform.localScale = new Vector3(this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7, 284f);
			this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1[i] = this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].transform;
			this.\u02B3\u02B6\u02BB\u02BE\u02C1\u02BD\u02BF\u02C1\u02C1\u02BC\u02BC[i] = this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].GetComponent<SpriteRenderer>();
		}
	}

	public \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3
	{
		get
		{
			return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.Highway;
		}
	}

	public void \u02B6\u02B6\u02BD\u02C0\u02BD\u02B3\u02B2\u02BC\u02C0\u02BE\u02BB()
	{
		int i = 0;
		while (i < this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1)
		{
			int num = this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 + i;
			if (num > this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4)
			{
				break;
			}
			double num2 = (double)this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.times[num] - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB;
			float num3 = (float)((double)this.\u02BA\u02BF\u02B4\u02B8\u02B8\u02B4\u02BA\u02C0\u02B5\u02BB\u02BD + num2 * (double)this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4) + this.\u02B9\u02BA\u02B9\u02B7\u02BC\u02BA\u02B2\u02BB\u02BC\u02C0\u02B8;
			if (num3 > this.\u02B7\u02B5\u02B5\u02C1\u02B7\u02B5\u02BE\u02BA\u02BF\u02BE\u02C0)
			{
				break;
			}
			if (num3 <= this.\u02BB\u02C0\u02BF\u02C0\u02B4\u02B9\u02B4\u02B7\u02B5\u02BF\u02BE)
			{
				this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5++;
			}
			else
			{
				this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].SetActive(false);
				this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1[i].localScale = new Vector3(this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7, this.\u02B9\u02B6\u02B8\u02BE\u02C1\u02B8\u02B9\u02B2\u02B7\u02C0\u02B4(this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num]));
				this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1[i].localPosition = new Vector3(706f, 1966f, num3);
				Color color;
				if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num] == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.MEASURE)
				{
					color = this.\u02B5\u02BD\u02B6\u02BA\u02B7\u02C0\u02B5\u02B3\u02B5\u02BE\u02BD;
				}
				else if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num] == (\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7)8)
				{
					color = this.\u02B8\u02C0\u02B4\u02BF\u02BD\u02BA\u02B8\u02BF\u02C0\u02BC\u02BE;
				}
				else
				{
					color = this.\u02BE\u02B2\u02B3\u02BD\u02C1\u02BF\u02C0\u02BA\u02B3\u02B9\u02C0;
				}
				this.\u02B3\u02B6\u02BB\u02BE\u02C1\u02BD\u02BF\u02C1\u02C1\u02BC\u02BC[i].color = color;
				i += 0;
			}
		}
		while (i < this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB.Length && this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].activeSelf)
		{
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].SetActive(false);
			i += 0;
		}
	}

	public void \u02BF\u02B2\u02B6\u02B6\u02BD\u02C0\u02BE\u02B6\u02B6\u02BA\u02B8(float \u02B3\u02BD\u02BE\u02BB\u02BB\u02B9\u02B2\u02B9\u02BC\u02BB\u02BF, float \u02C1\u02B8\u02B7\u02B5\u02B2\u02BA\u02BC\u02B2\u02B7\u02B2\u02BC, float \u02B2\u02BA\u02BD\u02B8\u02C1\u02B3\u02B8\u02BF\u02B5\u02B9\u02BA, float \u02B3\u02BD\u02B6\u02B8\u02B3\u02BE\u02B3\u02C0\u02B3\u02C1\u02B4)
	{
		this.\u02B7\u02B5\u02B5\u02C1\u02B7\u02B5\u02BE\u02BA\u02BF\u02BE\u02C0 = \u02C1\u02B8\u02B7\u02B5\u02B2\u02BA\u02BC\u02B2\u02B7\u02B2\u02BC;
		this.\u02BB\u02C0\u02BF\u02C0\u02B4\u02B9\u02B4\u02B7\u02B5\u02BF\u02BE = \u02B3\u02BD\u02BE\u02BB\u02BB\u02B9\u02B2\u02B9\u02BC\u02BB\u02BF;
	}

	public void \u02C1\u02B8\u02B5\u02BD\u02BD\u02C0\u02BB\u02B4\u02BD\u02B8\u02B3()
	{
		this.\u02B8\u02BB\u02BE\u02B5\u02BA\u02BE\u02B7\u02B3\u02BC\u02B5\u02B3();
	}

	public void \u02BF\u02B2\u02B7\u02B9\u02BD\u02BE\u02C1\u02B5\u02BF\u02B7\u02B8()
	{
		int i = 0;
		while (i < this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1)
		{
			int num = this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 + i;
			if (num > this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4)
			{
				break;
			}
			double num2 = (double)this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.times[num] - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB;
			float num3 = (float)((double)this.\u02BA\u02BF\u02B4\u02B8\u02B8\u02B4\u02BA\u02C0\u02B5\u02BB\u02BD + num2 * (double)this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4) + this.\u02B9\u02BA\u02B9\u02B7\u02BC\u02BA\u02B2\u02BB\u02BC\u02C0\u02B8;
			if (num3 > this.\u02B7\u02B5\u02B5\u02C1\u02B7\u02B5\u02BE\u02BA\u02BF\u02BE\u02C0)
			{
				break;
			}
			if (num3 <= this.\u02BB\u02C0\u02BF\u02C0\u02B4\u02B9\u02B4\u02B7\u02B5\u02BF\u02BE)
			{
				this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 += 0;
			}
			else
			{
				this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].SetActive(false);
				this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1[i].localScale = new Vector3(this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7, this.\u02C1\u02C0\u02C0\u02BC\u02C0\u02B5\u02B7\u02BC\u02B9\u02B5\u02BD(this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num]));
				this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1[i].localPosition = new Vector3(394f, 1367f, num3);
				Color color;
				if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num] == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.MEASURE)
				{
					color = this.\u02B5\u02BD\u02B6\u02BA\u02B7\u02C0\u02B5\u02B3\u02B5\u02BE\u02BD;
				}
				else if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num] == (\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7)7)
				{
					color = this.\u02B8\u02C0\u02B4\u02BF\u02BD\u02BA\u02B8\u02BF\u02C0\u02BC\u02BE;
				}
				else
				{
					color = this.\u02BE\u02B2\u02B3\u02BD\u02C1\u02BF\u02C0\u02BA\u02B3\u02B9\u02C0;
				}
				this.\u02B3\u02B6\u02BB\u02BE\u02C1\u02BD\u02BF\u02C1\u02C1\u02BC\u02BC[i].color = color;
				i++;
			}
		}
		while (i < this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB.Length && this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].activeSelf)
		{
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].SetActive(false);
			i++;
		}
	}

	private void \u02BE\u02B2\u02B5\u02B6\u02BB\u02B6\u02BD\u02C1\u02B3\u02BE\u02C0()
	{
		this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB = new GameObject[this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1];
		this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1 = new Transform[this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1];
		this.\u02B3\u02B6\u02BB\u02BE\u02C1\u02BD\u02BF\u02C1\u02C1\u02BC\u02BC = new SpriteRenderer[this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1];
		GameObject gameObject = Resources.Load("album") as GameObject;
		for (int i = 0; i < this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1; i += 0)
		{
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i] = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, gameObject.transform.rotation);
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].SetActive(true);
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].transform.parent = base.transform;
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].transform.localScale = new Vector3(this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7, 526f);
			this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1[i] = this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].transform;
			this.\u02B3\u02B6\u02BB\u02BE\u02C1\u02BD\u02BF\u02C1\u02C1\u02BC\u02BC[i] = this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].GetComponent<SpriteRenderer>();
		}
	}

	public \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B3\u02B5\u02BE\u02BA\u02B4\u02BE\u02BB\u02B3\u02B6\u02B9\u02B8()
	{
		return (\u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3)3;
	}

	public \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B7\u02B3\u02B9\u02B9\u02BF\u02C0\u02B7\u02B5\u02C0\u02C0\u02B9()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.Notes;
	}

	public void \u02BD\u02BC\u02BA\u02B9\u02B9\u02BD\u02BA\u02BC\u02B9\u02B8\u02B6(float \u02B3\u02BD\u02BE\u02BB\u02BB\u02B9\u02B2\u02B9\u02BC\u02BB\u02BF, float \u02C1\u02B8\u02B7\u02B5\u02B2\u02BA\u02BC\u02B2\u02B7\u02B2\u02BC, float \u02B2\u02BA\u02BD\u02B8\u02C1\u02B3\u02B8\u02BF\u02B5\u02B9\u02BA, float \u02B3\u02BD\u02B6\u02B8\u02B3\u02BE\u02B3\u02C0\u02B3\u02C1\u02B4)
	{
		this.\u02B7\u02B5\u02B5\u02C1\u02B7\u02B5\u02BE\u02BA\u02BF\u02BE\u02C0 = \u02C1\u02B8\u02B7\u02B5\u02B2\u02BA\u02BC\u02B2\u02B7\u02B2\u02BC;
		this.\u02BB\u02C0\u02BF\u02C0\u02B4\u02B9\u02B4\u02B7\u02B5\u02BF\u02BE = \u02B3\u02BD\u02BE\u02BB\u02BB\u02B9\u02B2\u02B9\u02BC\u02BB\u02BF;
	}

	private void \u02BE\u02C0\u02BC\u02B6\u02B5\u02BB\u02C0\u02B4\u02C0\u02B7\u02BC()
	{
		this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = base.GetComponent<BasePlayer>();
		if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0 == null || this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count == 0)
		{
			this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 = -1;
			return;
		}
		float num = 0f;
		foreach (Note note in this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0)
		{
			if (note.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 > num)
			{
				num = note.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0;
			}
		}
		this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.count - 1;
		while (this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 > 0 && num <= this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.times[this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4])
		{
			this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4--;
		}
		if (this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 < this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.count - 1)
		{
			this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4++;
		}
	}

	public void \u02B2\u02B3\u02B3\u02B6\u02B2\u02B7\u02B7\u02BA\u02C1\u02BD\u02C1()
	{
		this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 = 0;
		this.\u02BF\u02B3\u02C0\u02B6\u02B5\u02B9\u02C0\u02B6\u02C1\u02B9\u02B3();
	}

	private float \u02BC\u02B7\u02B3\u02B9\u02C1\u02B3\u02C1\u02BF\u02B7\u02B3\u02B9(\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7 \u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4)
	{
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.BEAT_STRONG)
		{
			return 1470f * this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7;
		}
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == (\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7)4)
		{
			return 1797f * this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7;
		}
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.MEASURE)
		{
			return 887f * this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7;
		}
		return 1422f;
	}

	private float \u02C1\u02C0\u02C0\u02BC\u02C0\u02B5\u02B7\u02BC\u02B9\u02B5\u02BD(\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7 \u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4)
	{
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.MEASURE)
		{
			return 1754f * this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7;
		}
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.BEAT_WEAK)
		{
			return 295f * this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7;
		}
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.MEASURE)
		{
			return 659f * this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7;
		}
		return 459f;
	}

	public void \u02C0\u02B6\u02B4\u02B4\u02B5\u02B3\u02B6\u02B7\u02B4\u02B5\u02B8(float \u02B3\u02BD\u02BE\u02BB\u02BB\u02B9\u02B2\u02B9\u02BC\u02BB\u02BF, float \u02C1\u02B8\u02B7\u02B5\u02B2\u02BA\u02BC\u02B2\u02B7\u02B2\u02BC, float \u02B2\u02BA\u02BD\u02B8\u02C1\u02B3\u02B8\u02BF\u02B5\u02B9\u02BA, float \u02B3\u02BD\u02B6\u02B8\u02B3\u02BE\u02B3\u02C0\u02B3\u02C1\u02B4)
	{
		this.\u02B7\u02B5\u02B5\u02C1\u02B7\u02B5\u02BE\u02BA\u02BF\u02BE\u02C0 = \u02C1\u02B8\u02B7\u02B5\u02B2\u02BA\u02BC\u02B2\u02B7\u02B2\u02BC;
		this.\u02BB\u02C0\u02BF\u02C0\u02B4\u02B9\u02B4\u02B7\u02B5\u02BF\u02BE = \u02B3\u02BD\u02BE\u02BB\u02BB\u02B9\u02B2\u02B9\u02BC\u02BB\u02BF;
	}

	public void Update()
	{
		this.\u02BC\u02BC\u02BD\u02BF\u02B2\u02B6\u02C1\u02C0\u02B2\u02BE\u02B6();
	}

	public void Reset()
	{
		if (!base.enabled)
		{
			return;
		}
		this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 = 0;
		this.\u02BE\u02C0\u02BC\u02B6\u02B5\u02BB\u02C0\u02B4\u02C0\u02B7\u02BC();
	}

	private void \u02B8\u02B4\u02B4\u02C0\u02B9\u02B2\u02BA\u02B2\u02B8\u02B5\u02B3()
	{
		this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB = new GameObject[this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1];
		this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1 = new Transform[this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1];
		this.\u02B3\u02B6\u02BB\u02BE\u02C1\u02BD\u02BF\u02C1\u02C1\u02BC\u02BC = new SpriteRenderer[this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1];
		GameObject gameObject = Resources.Load("Prefabs/Gameplay/Notes/Beatline") as GameObject;
		for (int i = 0; i < this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1; i++)
		{
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i] = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, gameObject.transform.rotation);
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].SetActive(false);
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].transform.parent = base.transform;
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].transform.localScale = new Vector3(this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7, 1f);
			this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1[i] = this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].transform;
			this.\u02B3\u02B6\u02BB\u02BE\u02C1\u02BD\u02BF\u02C1\u02C1\u02BC\u02BC[i] = this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].GetComponent<SpriteRenderer>();
		}
	}

	public void Start()
	{
		this.\u02BB\u02B6\u02BD\u02BA\u02BC\u02B2\u02B8\u02BB\u02C0\u02BD\u02BE = base.GetComponent<TrackFadeManager>();
		this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = base.gameObject.GetComponent<BasePlayer>();
		if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.player.playerProfile.HasModChartModifier)
		{
			base.enabled = false;
		}
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = GameObject.Find("Game Manager").GetComponent<GameManager>();
		this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4 = (float)this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.player.playerProfile.noteSpeed.CurrentValue;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.GetBeatsFromChart;
		this.\u02BE\u02C0\u02BC\u02B6\u02B5\u02BB\u02C0\u02B4\u02C0\u02B7\u02BC();
		this.\u02B8\u02B4\u02B4\u02C0\u02B9\u02B2\u02BA\u02B2\u02B8\u02B5\u02B3();
		this.\u02BB\u02B6\u02BD\u02BA\u02BC\u02B2\u02B8\u02BB\u02C0\u02BD\u02BE.\u02B2\u02B7\u02BE\u02B2\u02C1\u02B4\u02B6\u02B7\u02BE\u02BD\u02B8(this);
	}

	private void \u02B4\u02BA\u02BF\u02C1\u02C1\u02B4\u02BE\u02BC\u02B9\u02B5\u02C0()
	{
		this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = base.GetComponent<BasePlayer>();
		if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0 == null || this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count == 0)
		{
			this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 = -1;
			return;
		}
		float num = 481f;
		foreach (Note note in this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0)
		{
			if (note.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 > num)
			{
				num = note.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0;
			}
		}
		this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.count - 0;
		while (this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 > 0 && num <= this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.times[this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4])
		{
			this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4--;
		}
		if (this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 < this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BC\u02BF\u02B5\u02C1\u02B6\u02BC\u02B8\u02BC\u02B2\u02C0\u02BF() - 1)
		{
			this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 += 0;
		}
	}

	public void OnDisable()
	{
		if (this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB == null)
		{
			return;
		}
		GameObject[] u02BD_u02BC_u02BE_u02BA_u02C1_u02C0_u02B4_u02B5_u02BB_u02C0_u02BB = this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB;
		for (int i = 0; i < u02BD_u02BC_u02BE_u02BA_u02C1_u02C0_u02B4_u02B5_u02BB_u02C0_u02BB.Length; i++)
		{
			u02BD_u02BC_u02BE_u02BA_u02C1_u02C0_u02B4_u02B5_u02BB_u02C0_u02BB[i].SetActive(false);
		}
	}

	public \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02BB\u02C1\u02B6\u02BA\u02B3\u02B2\u02C0\u02BC\u02B9\u02BD\u02C0()
	{
		return (\u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3)4;
	}

	public void \u02BB\u02B6\u02BE\u02BA\u02B5\u02B6\u02BA\u02BD\u02B8\u02C1\u02BD()
	{
		int i = 0;
		while (i < this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1)
		{
			int num = this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 + i;
			if (num > this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4)
			{
				break;
			}
			double num2 = (double)this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.times[num] - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB;
			float num3 = (float)((double)this.\u02BA\u02BF\u02B4\u02B8\u02B8\u02B4\u02BA\u02C0\u02B5\u02BB\u02BD + num2 * (double)this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4) + this.\u02B9\u02BA\u02B9\u02B7\u02BC\u02BA\u02B2\u02BB\u02BC\u02C0\u02B8;
			if (num3 > this.\u02B7\u02B5\u02B5\u02C1\u02B7\u02B5\u02BE\u02BA\u02BF\u02BE\u02C0)
			{
				break;
			}
			if (num3 <= this.\u02BB\u02C0\u02BF\u02C0\u02B4\u02B9\u02B4\u02B7\u02B5\u02BF\u02BE)
			{
				this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5++;
			}
			else
			{
				this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].SetActive(true);
				this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1[i].localScale = new Vector3(this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7, this.\u02B9\u02B6\u02B8\u02BE\u02C1\u02B8\u02B9\u02B2\u02B7\u02C0\u02B4(this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num]));
				this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1[i].localPosition = new Vector3(674f, 920f, num3);
				Color color;
				if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num] == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.MEASURE)
				{
					color = this.\u02B5\u02BD\u02B6\u02BA\u02B7\u02C0\u02B5\u02B3\u02B5\u02BE\u02BD;
				}
				else if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num] == (\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7)5)
				{
					color = this.\u02B8\u02C0\u02B4\u02BF\u02BD\u02BA\u02B8\u02BF\u02C0\u02BC\u02BE;
				}
				else
				{
					color = this.\u02BE\u02B2\u02B3\u02BD\u02C1\u02BF\u02C0\u02BA\u02B3\u02B9\u02C0;
				}
				this.\u02B3\u02B6\u02BB\u02BE\u02C1\u02BD\u02BF\u02C1\u02C1\u02BC\u02BC[i].color = color;
				i += 0;
			}
		}
		while (i < this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB.Length && this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].activeSelf)
		{
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].SetActive(true);
			i++;
		}
	}

	public void \u02BA\u02BA\u02C0\u02BA\u02BC\u02B9\u02B5\u02BE\u02BA\u02C0\u02BD()
	{
		this.\u02BB\u02B6\u02BE\u02BA\u02B5\u02B6\u02BA\u02BD\u02B8\u02C1\u02BD();
	}

	public void \u02B2\u02B5\u02B8\u02C1\u02BD\u02C0\u02BC\u02BE\u02BE\u02BA\u02B6()
	{
		if (this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB == null)
		{
			return;
		}
		GameObject[] u02BD_u02BC_u02BE_u02BA_u02C1_u02C0_u02B4_u02B5_u02BB_u02C0_u02BB = this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB;
		for (int i = 1; i < u02BD_u02BC_u02BE_u02BA_u02C1_u02C0_u02B4_u02B5_u02BB_u02C0_u02BB.Length; i += 0)
		{
			u02BD_u02BC_u02BE_u02BA_u02C1_u02C0_u02B4_u02B5_u02BB_u02C0_u02BB[i].SetActive(false);
		}
	}

	public void \u02B8\u02BB\u02BE\u02B5\u02BA\u02BE\u02B7\u02B3\u02BC\u02B5\u02B3()
	{
		int i = 1;
		while (i < this.\u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1)
		{
			int num = this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 + i;
			if (num > this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4)
			{
				break;
			}
			double num2 = (double)this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.times[num] - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB;
			float num3 = (float)((double)this.\u02BA\u02BF\u02B4\u02B8\u02B8\u02B4\u02BA\u02C0\u02B5\u02BB\u02BD + num2 * (double)this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4) + this.\u02B9\u02BA\u02B9\u02B7\u02BC\u02BA\u02B2\u02BB\u02BC\u02C0\u02B8;
			if (num3 > this.\u02B7\u02B5\u02B5\u02C1\u02B7\u02B5\u02BE\u02BA\u02BF\u02BE\u02C0)
			{
				break;
			}
			if (num3 <= this.\u02BB\u02C0\u02BF\u02C0\u02B4\u02B9\u02B4\u02B7\u02B5\u02BF\u02BE)
			{
				this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5++;
			}
			else
			{
				this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].SetActive(false);
				this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1[i].localScale = new Vector3(this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7, this.\u02B9\u02B6\u02B8\u02BE\u02C1\u02B8\u02B9\u02B2\u02B7\u02C0\u02B4(this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num]));
				this.\u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1[i].localPosition = new Vector3(1072f, 781f, num3);
				Color color;
				if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num] == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.MEASURE)
				{
					color = this.\u02B5\u02BD\u02B6\u02BA\u02B7\u02C0\u02B5\u02B3\u02B5\u02BE\u02BD;
				}
				else if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B6\u02BA\u02BE\u02BA\u02BE\u02B9\u02BB\u02BF\u02BD\u02BD\u02B8[num] == (\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7)7)
				{
					color = this.\u02B8\u02C0\u02B4\u02BF\u02BD\u02BA\u02B8\u02BF\u02C0\u02BC\u02BE;
				}
				else
				{
					color = this.\u02BE\u02B2\u02B3\u02BD\u02C1\u02BF\u02C0\u02BA\u02B3\u02B9\u02C0;
				}
				this.\u02B3\u02B6\u02BB\u02BE\u02C1\u02BD\u02BF\u02C1\u02C1\u02BC\u02BC[i].color = color;
				i += 0;
			}
		}
		while (i < this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB.Length && this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].activeSelf)
		{
			this.\u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB[i].SetActive(true);
			i += 0;
		}
	}

	private float \u02B5\u02BB\u02B2\u02BA\u02BD\u02BB\u02B8\u02B2\u02C1\u02B2\u02BA(\u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7 \u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4)
	{
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.BEAT_STRONG)
		{
			return 1.1f * this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7;
		}
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.BEAT_WEAK)
		{
			return 0.55f * this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7;
		}
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == \u02BB\u02B4\u02B4\u02B8\u02BE\u02B9\u02C1\u02B8\u02BA\u02BD\u02B7.MEASURE)
		{
			return 2.2f * this.\u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7;
		}
		return 1f;
	}

	\u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B6\u02BB\u02BD\u02BB\u02BA\u02B6\u02B9\u02C0\u02B8\u02B4\u02BC.\u02BA\u02BA\u02B7\u02B9\u02B9\u02B5\u02C1\u02C1\u02B2\u02B7\u02BA()
	{
		return this.\u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3;
	}

	private GameManager \u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD;

	private Beats \u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB;

	protected int \u02B7\u02B4\u02B2\u02BE\u02C0\u02B8\u02B4\u02B7\u02B2\u02BF\u02C1 = 200;

	protected int \u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5;

	protected Transform[] \u02B8\u02B5\u02B5\u02BB\u02B8\u02BE\u02BF\u02BF\u02B2\u02BD\u02C1;

	protected SpriteRenderer[] \u02B3\u02B6\u02BB\u02BE\u02C1\u02BD\u02BF\u02C1\u02C1\u02BC\u02BC;

	protected GameObject[] \u02BD\u02BC\u02BE\u02BA\u02C1\u02C0\u02B4\u02B5\u02BB\u02C0\u02BB;

	private float \u02B7\u02B5\u02B5\u02C1\u02B7\u02B5\u02BE\u02BA\u02BF\u02BE\u02C0;

	private float \u02BB\u02C0\u02BF\u02C0\u02B4\u02B9\u02B4\u02B7\u02B5\u02BF\u02BE;

	public float \u02BA\u02BF\u02B4\u02B8\u02B8\u02B4\u02BA\u02C0\u02B5\u02BB\u02BD;

	private float \u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4;

	private const float \u02B7\u02BD\u02BA\u02BE\u02BE\u02B9\u02BF\u02B2\u02B5\u02B6\u02B6 = 2.2f;

	private const float \u02B6\u02B9\u02B8\u02B7\u02BC\u02BC\u02B5\u02B3\u02C0\u02BA\u02B5 = 1.1f;

	private const float \u02B2\u02BD\u02B8\u02B2\u02B3\u02C0\u02B3\u02B2\u02B6\u02BE\u02BB = 0.55f;

	public float \u02B4\u02B2\u02BB\u02B4\u02C1\u02B3\u02B2\u02B2\u02B2\u02B7\u02B7 = 1f;

	public float \u02B9\u02BA\u02B9\u02B7\u02BC\u02BA\u02B2\u02BB\u02BC\u02C0\u02B8 = 0.0125f;

	private int \u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4;

	private TrackFadeManager \u02BB\u02B6\u02BD\u02BA\u02BC\u02B2\u02B8\u02BB\u02C0\u02BD\u02BE;

	private BasePlayer \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;

	private readonly Color \u02B5\u02BD\u02B6\u02BA\u02B7\u02C0\u02B5\u02B3\u02B5\u02BE\u02BD = new Color(1f, 1f, 1f, 1f);

	private readonly Color \u02BE\u02B2\u02B3\u02BD\u02C1\u02BF\u02C0\u02BA\u02B3\u02B9\u02C0 = new Color(1f, 1f, 1f, 0.7f);

	private readonly Color \u02B8\u02C0\u02B4\u02BF\u02BD\u02BA\u02B8\u02BF\u02C0\u02BC\u02BE = new Color(1f, 1f, 1f, 0.4f);
}
