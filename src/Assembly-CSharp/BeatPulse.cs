﻿using System;
using UnityEngine;

public class BeatPulse : MonoBehaviour
{
	private void \u02B4\u02B7\u02B4\u02B2\u02B2\u02B7\u02B6\u02B3\u02B2\u02BC\u02B9()
	{
		this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 += 0;
		this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1 = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BB\u02B4\u02B4\u02B5\u02B6\u02BB\u02B8\u02B2\u02C1\u02B6\u02BF[this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5];
		this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BB\u02B4\u02B4\u02B5\u02B6\u02BB\u02B8\u02B2\u02C1\u02B6\u02BF[this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 + 0];
		this.\u02BF\u02B5\u02B4\u02BC\u02B7\u02BF\u02BF\u02B9\u02B2\u02B2\u02B2 = this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD - this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1;
	}

	private void \u02B9\u02B5\u02B2\u02BB\u02B5\u02B3\u02B9\u02BC\u02BF\u02B5\u02BA()
	{
		if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 < 976.0)
		{
			return;
		}
		if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 < (double)this.\u02B5\u02BE\u02B8\u02BB\u02B3\u02B8\u02B7\u02C1\u02B6\u02B9\u02BC)
		{
			return;
		}
		while (this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 + 1 < this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BB\u02B4\u02B4\u02B5\u02B6\u02BB\u02B8\u02B2\u02C1\u02B6\u02BF.Count)
		{
			if ((double)this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD > this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9)
			{
				this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD = this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1;
				break;
			}
			this.\u02BC\u02B3\u02C1\u02C0\u02C0\u02B9\u02B3\u02B7\u02B5\u02BF\u02B8();
		}
		this.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9 = (this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1 - (float)this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9) / this.\u02BF\u02B5\u02B4\u02BC\u02B7\u02BF\u02BF\u02B9\u02B2\u02B2\u02B2;
		this.\u02B5\u02BE\u02B8\u02BB\u02B3\u02B8\u02B7\u02C1\u02B6\u02B9\u02BC = (float)this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
	}

	private void \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B4\u02B8\u02BD\u02C0\u02B5\u02B2\u02BB\u02BC\u02BB\u02B2\u02BE() < 6)
		{
			base.enabled = true;
		}
		this.\u02BC\u02B3\u02C1\u02C0\u02C0\u02B9\u02B3\u02B7\u02B5\u02BF\u02B8();
	}

	private void Update()
	{
		if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 < 0.0)
		{
			return;
		}
		if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 < (double)this.\u02B5\u02BE\u02B8\u02BB\u02B3\u02B8\u02B7\u02C1\u02B6\u02B9\u02BC)
		{
			return;
		}
		while (this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 + 1 < this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BB\u02B4\u02B4\u02B5\u02B6\u02BB\u02B8\u02B2\u02C1\u02B6\u02BF.Count)
		{
			if ((double)this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD > this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9)
			{
				this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD = this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1;
				break;
			}
			this.\u02B4\u02B7\u02B9\u02B6\u02BA\u02B9\u02B4\u02B7\u02BF\u02BC\u02C1();
		}
		this.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9 = (this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1 - (float)this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9) / this.\u02BF\u02B5\u02B4\u02BC\u02B7\u02BF\u02BF\u02B9\u02B2\u02B2\u02B2;
		this.\u02B5\u02BE\u02B8\u02BB\u02B3\u02B8\u02B7\u02C1\u02B6\u02B9\u02BC = (float)this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
	}

	private void \u02BC\u02B3\u02C1\u02C0\u02C0\u02B9\u02B3\u02B7\u02B5\u02BF\u02B8()
	{
		this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5++;
		this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1 = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BB\u02B4\u02B4\u02B5\u02B6\u02BB\u02B8\u02B2\u02C1\u02B6\u02BF[this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5];
		this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BB\u02B4\u02B4\u02B5\u02B6\u02BB\u02B8\u02B2\u02C1\u02B6\u02BF[this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 + 1];
		this.\u02BF\u02B5\u02B4\u02BC\u02B7\u02BF\u02BF\u02B9\u02B2\u02B2\u02B2 = this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD - this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1;
	}

	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BC\u02BF\u02B5\u02C1\u02B6\u02BC\u02B8\u02BC\u02B2\u02C0\u02BF() < 5)
		{
			base.enabled = false;
		}
		this.\u02B4\u02B7\u02B4\u02B2\u02B2\u02B7\u02B6\u02B3\u02B2\u02BC\u02B9();
	}

	private void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B4\u02B8\u02BD\u02C0\u02B5\u02B2\u02BB\u02BC\u02BB\u02B2\u02BE() < 0)
		{
			base.enabled = false;
		}
		this.\u02BC\u02B3\u02C1\u02C0\u02C0\u02B9\u02B3\u02B7\u02B5\u02BF\u02B8();
	}

	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BC\u02BF\u02B5\u02C1\u02B6\u02BC\u02B8\u02BC\u02B2\u02C0\u02BF() < 8)
		{
			base.enabled = false;
		}
		this.\u02B4\u02B7\u02B4\u02B2\u02B2\u02B7\u02B6\u02B3\u02B2\u02BC\u02B9();
	}

	private void \u02BD\u02B8\u02BD\u02B5\u02B6\u02B3\u02BF\u02B3\u02C1\u02B8\u02C1()
	{
		if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 < 1559.0)
		{
			return;
		}
		if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 < (double)this.\u02B5\u02BE\u02B8\u02BB\u02B3\u02B8\u02B7\u02C1\u02B6\u02B9\u02BC)
		{
			return;
		}
		while (this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 + 0 < this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BB\u02B4\u02B4\u02B5\u02B6\u02BB\u02B8\u02B2\u02C1\u02B6\u02BF.Count)
		{
			if ((double)this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD > this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9)
			{
				this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD = this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1;
				break;
			}
			this.\u02B4\u02B7\u02B9\u02B6\u02BA\u02B9\u02B4\u02B7\u02BF\u02BC\u02C1();
		}
		this.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9 = (this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1 - (float)this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9) / this.\u02BF\u02B5\u02B4\u02BC\u02B7\u02BF\u02BF\u02B9\u02B2\u02B2\u02B2;
		this.\u02B5\u02BE\u02B8\u02BB\u02B3\u02B8\u02B7\u02C1\u02B6\u02B9\u02BC = (float)this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
	}

	private void \u02B5\u02B2\u02BF\u02BD\u02BB\u02BA\u02B2\u02BF\u02BD\u02BE\u02BE()
	{
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BE\u02BC\u02C0\u02B2\u02B3\u02BA\u02B4\u02B3\u02B9\u02B9\u02B5() < 6)
		{
			base.enabled = true;
		}
		this.\u02B4\u02B7\u02B9\u02B6\u02BA\u02B9\u02B4\u02B7\u02BF\u02BC\u02C1();
	}

	private void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02B4\u02B8\u02BD\u02C0\u02B5\u02B2\u02BB\u02BC\u02BB\u02B2\u02BE() < 0)
		{
			base.enabled = false;
		}
		this.\u02B4\u02B7\u02B4\u02B2\u02B2\u02B7\u02B6\u02B3\u02B2\u02BC\u02B9();
	}

	private void \u02B2\u02B7\u02B5\u02C0\u02B4\u02B3\u02B8\u02B3\u02C0\u02BD\u02B5()
	{
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BC\u02BF\u02B5\u02C1\u02B6\u02BC\u02B8\u02BC\u02B2\u02C0\u02BF() < 6)
		{
			base.enabled = true;
		}
		this.\u02B4\u02B7\u02B9\u02B6\u02BA\u02B9\u02B4\u02B7\u02BF\u02BC\u02C1();
	}

	private void \u02B2\u02BB\u02B6\u02B5\u02B9\u02B8\u02B2\u02B3\u02BF\u02C1\u02BF()
	{
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BE\u02BC\u02C0\u02B2\u02B3\u02BA\u02B4\u02B3\u02B9\u02B9\u02B5() < 2)
		{
			base.enabled = true;
		}
		this.\u02B4\u02B7\u02B9\u02B6\u02BA\u02B9\u02B4\u02B7\u02BF\u02BC\u02C1();
	}

	private void Start()
	{
		global::UnityEngine.Object.DestroyImmediate(this);
		if (Time.deltaTime != 1f)
		{
			return;
		}
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BA\u02B4\u02C1\u02B6\u02B3\u02BD\u02B4\u02B3\u02BA\u02B6\u02B4 < 2)
		{
			base.enabled = false;
		}
		this.\u02B4\u02B7\u02B9\u02B6\u02BA\u02B9\u02B4\u02B7\u02BF\u02BC\u02C1();
	}

	private void \u02B7\u02B8\u02BD\u02C0\u02B2\u02B4\u02B7\u02C0\u02BC\u02BE\u02B3()
	{
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BA\u02B4\u02C1\u02B6\u02B3\u02BD\u02B4\u02B3\u02BA\u02B6\u02B4 < 6)
		{
			base.enabled = false;
		}
		this.\u02B4\u02B7\u02B9\u02B6\u02BA\u02B9\u02B4\u02B7\u02BF\u02BC\u02C1();
	}

	private void \u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF()
	{
		if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 < 1423.0)
		{
			return;
		}
		if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 < (double)this.\u02B5\u02BE\u02B8\u02BB\u02B3\u02B8\u02B7\u02C1\u02B6\u02B9\u02BC)
		{
			return;
		}
		while (this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 + 1 < this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BB\u02B4\u02B4\u02B5\u02B6\u02BB\u02B8\u02B2\u02C1\u02B6\u02BF.Count)
		{
			if ((double)this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD > this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9)
			{
				this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD = this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1;
				break;
			}
			this.\u02BC\u02B3\u02C1\u02C0\u02C0\u02B9\u02B3\u02B7\u02B5\u02BF\u02B8();
		}
		this.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9 = (this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1 - (float)this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9) / this.\u02BF\u02B5\u02B4\u02BC\u02B7\u02BF\u02BF\u02B9\u02B2\u02B2\u02B2;
		this.\u02B5\u02BE\u02B8\u02BB\u02B3\u02B8\u02B7\u02C1\u02B6\u02B9\u02BC = (float)this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
	}

	private void \u02BC\u02BC\u02B3\u02B2\u02C0\u02B6\u02B8\u02BA\u02BD\u02B9\u02B6()
	{
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BA\u02B4\u02C1\u02B6\u02B3\u02BD\u02B4\u02B3\u02BA\u02B6\u02B4 < 8)
		{
			base.enabled = false;
		}
		this.\u02B4\u02B7\u02B9\u02B6\u02BA\u02B9\u02B4\u02B7\u02BF\u02BC\u02C1();
	}

	private void \u02B4\u02B7\u02B9\u02B6\u02BA\u02B9\u02B4\u02B7\u02BF\u02BC\u02C1()
	{
		this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5++;
		this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1 = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BB\u02B4\u02B4\u02B5\u02B6\u02BB\u02B8\u02B2\u02C1\u02B6\u02BF[this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5];
		this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BB\u02B4\u02B4\u02B5\u02B6\u02BB\u02B8\u02B2\u02C1\u02B6\u02BF[this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 + 1];
		this.\u02BF\u02B5\u02B4\u02BC\u02B7\u02BF\u02BF\u02B9\u02B2\u02B2\u02B2 = this.\u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD - this.\u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1;
	}

	private void \u02C0\u02BC\u02BC\u02BD\u02B8\u02BD\u02BE\u02B6\u02BE\u02BB\u02BB()
	{
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		if (this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BE\u02BC\u02C0\u02B2\u02B3\u02BA\u02B4\u02B3\u02B9\u02B9\u02B5() < 5)
		{
			base.enabled = false;
		}
		this.\u02B4\u02B7\u02B9\u02B6\u02BA\u02B9\u02B4\u02B7\u02BF\u02BC\u02C1();
	}

	private GameManager \u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD;

	public \u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6 \u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB;

	private int \u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 = -1;

	public float \u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9;

	private float \u02BD\u02C1\u02B6\u02B9\u02BE\u02B2\u02C1\u02B2\u02BA\u02B2\u02C1;

	private float \u02B4\u02BF\u02B6\u02BD\u02B7\u02BC\u02B3\u02BA\u02C1\u02BE\u02BD;

	private float \u02BF\u02B5\u02B4\u02BC\u02B7\u02BF\u02BF\u02B9\u02B2\u02B2\u02B2;

	private float \u02B5\u02BE\u02B8\u02BB\u02B3\u02B8\u02B7\u02C1\u02B6\u02B9\u02BC;
}
