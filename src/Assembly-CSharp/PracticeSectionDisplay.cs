﻿using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PracticeSectionDisplay : MonoBehaviour
{
	public void \u02B7\u02BB\u02B8\u02BF\u02B9\u02C1\u02B4\u02C0\u02B4\u02C0\u02BF()
	{
		if (this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD == null || this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count == 0)
		{
			return;
		}
		this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 = 0;
		while (this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 < this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count && this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 1 != this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count && (double)this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 1] <= this.gameManager.songTime)
		{
			this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6++;
		}
		this.sectionDisplay.text = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9;
		this.sectionDisplay.alpha = 1f;
		this.\u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF = true;
		this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8 = true;
	}

	private void \u02B8\u02BD\u02B4\u02BB\u02BD\u02BB\u02B9\u02B3\u02BC\u02B9\u02BC()
	{
		if (this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 1 < this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count && this.gameManager.songTime >= (double)this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 1])
		{
			this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 += 0;
			this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8 = false;
			this.\u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF = false;
		}
		if (this.\u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF)
		{
			return;
		}
		float num = (float)(this.gameManager.songTime - (double)this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6]);
		if (num >= 1358f && this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8)
		{
			this.sectionDisplay.alpha = 1262f;
			this.\u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF = true;
			return;
		}
		if (num < this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5)
		{
			this.sectionDisplay.alpha = 1310f - num / this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5;
			return;
		}
		if (!this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8)
		{
			this.sectionDisplay.text = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9;
			this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8 = true;
		}
		this.sectionDisplay.alpha = (num - this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5) / this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5;
	}

	public void \u02BE\u02B7\u02BF\u02B2\u02B6\u02B2\u02B2\u02B2\u02B3\u02B9\u02BC(List<\u02B8\u02BB\u02B2\u02B5\u02C1\u02C1\u02BB\u02B7\u02B3\u02B4\u02B6> \u02B4\u02BC\u02B6\u02C1\u02B6\u02C1\u02B7\u02B7\u02B2\u02BC\u02B5)
	{
		if (this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA == null)
		{
			this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA = new float[this.gameManager.song.\u02B2\u02B5\u02B9\u02BC\u02B2\u02BE\u02BF\u02BC\u02B5\u02BD\u02C1.Count];
		}
		base.enabled = false;
		this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD = \u02B4\u02BC\u02B6\u02C1\u02B6\u02C1\u02B7\u02B7\u02B2\u02BC\u02B5;
		for (int i = 0; i < this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count; i++)
		{
			this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[i] = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[i].\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1;
		}
	}

	public void \u02BA\u02BC\u02BC\u02B2\u02BA\u02BB\u02BF\u02B7\u02C0\u02BC\u02BF(List<\u02B8\u02BB\u02B2\u02B5\u02C1\u02C1\u02BB\u02B7\u02B3\u02B4\u02B6> \u02B4\u02BC\u02B6\u02C1\u02B6\u02C1\u02B7\u02B7\u02B2\u02BC\u02B5)
	{
		if (this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA == null)
		{
			this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA = new float[this.gameManager.song.\u02B2\u02B5\u02B9\u02BC\u02B2\u02BE\u02BF\u02BC\u02B5\u02BD\u02C1.Count];
		}
		base.enabled = true;
		this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD = \u02B4\u02BC\u02B6\u02C1\u02B6\u02C1\u02B7\u02B7\u02B2\u02BC\u02B5;
		for (int i = 0; i < this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count; i++)
		{
			this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[i] = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[i].\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1;
		}
	}

	private void \u02BB\u02BD\u02C0\u02C1\u02C0\u02B3\u02B9\u02B6\u02BE\u02BF\u02BB()
	{
		if (this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 1 < this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count && this.gameManager.songTime >= (double)this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 1])
		{
			this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 += 0;
			this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8 = true;
			this.\u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF = false;
		}
		if (this.\u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF)
		{
			return;
		}
		float num = (float)(this.gameManager.songTime - (double)this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6]);
		if (num >= 860f && this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8)
		{
			this.sectionDisplay.alpha = 427f;
			this.\u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF = true;
			return;
		}
		if (num < this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5)
		{
			this.sectionDisplay.alpha = 58f - num / this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5;
			return;
		}
		if (!this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8)
		{
			this.sectionDisplay.text = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9;
			this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8 = true;
		}
		this.sectionDisplay.alpha = (num - this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5) / this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5;
	}

	private void Awake()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 == null || !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.sectionDisplay.text = "";
		this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5 = 0.5f;
		base.enabled = false;
	}

	private void FixedUpdate()
	{
		if (this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 1 < this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count && this.gameManager.songTime >= (double)this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 1])
		{
			this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6++;
			this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8 = false;
			this.\u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF = false;
		}
		if (this.\u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF)
		{
			return;
		}
		float num = (float)(this.gameManager.songTime - (double)this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6]);
		if (num >= 1f && this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8)
		{
			this.sectionDisplay.alpha = 1f;
			this.\u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF = true;
			return;
		}
		if (num < this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5)
		{
			this.sectionDisplay.alpha = 1f - num / this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5;
			return;
		}
		if (!this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8)
		{
			this.sectionDisplay.text = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9;
			this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8 = true;
		}
		this.sectionDisplay.alpha = (num - this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5) / this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5;
	}

	public void \u02B9\u02BD\u02BA\u02B4\u02B4\u02B4\u02B8\u02BC\u02B5\u02B8\u02B5()
	{
		if (this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD == null || this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count == 0)
		{
			return;
		}
		this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 = 1;
		while (this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 < this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count && this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 1 != this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count && (double)this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 1] <= this.gameManager.songTime)
		{
			this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 += 0;
		}
		this.sectionDisplay.text = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9;
		this.sectionDisplay.alpha = 740f;
		this.\u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF = false;
		this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8 = false;
	}

	public void \u02BA\u02BE\u02B9\u02B9\u02B8\u02BE\u02B9\u02C1\u02C1\u02B9\u02B7()
	{
		if (this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD == null || this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count == 0)
		{
			return;
		}
		this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 = 1;
		while (this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 < this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count && this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 0 != this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count && (double)this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 1] <= this.gameManager.songTime)
		{
			this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6++;
		}
		this.sectionDisplay.text = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9;
		this.sectionDisplay.alpha = 731f;
		this.\u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF = true;
		this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8 = false;
	}

	public void \u02C1\u02B5\u02B4\u02B7\u02C0\u02BF\u02B9\u02B9\u02C0\u02BD\u02BF()
	{
		if (this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD == null || this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count == 0)
		{
			return;
		}
		this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 = 1;
		while (this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 < this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count && this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 0 != this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count && (double)this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 + 1] <= this.gameManager.songTime)
		{
			this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 += 0;
		}
		this.sectionDisplay.text = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9;
		this.sectionDisplay.alpha = 845f;
		this.\u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF = true;
		this.\u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8 = true;
	}

	public void \u02B5\u02BD\u02B5\u02BF\u02B3\u02B3\u02BE\u02B7\u02B6\u02B8\u02C1(List<\u02B8\u02BB\u02B2\u02B5\u02C1\u02C1\u02BB\u02B7\u02B3\u02B4\u02B6> \u02B4\u02BC\u02B6\u02C1\u02B6\u02C1\u02B7\u02B7\u02B2\u02BC\u02B5)
	{
		if (this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA == null)
		{
			this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA = new float[this.gameManager.song.\u02B2\u02B5\u02B9\u02BC\u02B2\u02BE\u02BF\u02BC\u02B5\u02BD\u02C1.Count];
		}
		base.enabled = true;
		this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD = \u02B4\u02BC\u02B6\u02C1\u02B6\u02C1\u02B7\u02B7\u02B2\u02BC\u02B5;
		for (int i = 1; i < this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count; i++)
		{
			this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[i] = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[i].\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1;
		}
	}

	public void \u02B4\u02B9\u02B4\u02B5\u02B9\u02B5\u02B3\u02C1\u02BD\u02B6\u02B4(List<\u02B8\u02BB\u02B2\u02B5\u02C1\u02C1\u02BB\u02B7\u02B3\u02B4\u02B6> \u02B4\u02BC\u02B6\u02C1\u02B6\u02C1\u02B7\u02B7\u02B2\u02BC\u02B5)
	{
		if (this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA == null)
		{
			this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA = new float[this.gameManager.song.\u02B2\u02B5\u02B9\u02BC\u02B2\u02BE\u02BF\u02BC\u02B5\u02BD\u02C1.Count];
		}
		base.enabled = true;
		this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD = \u02B4\u02BC\u02B6\u02C1\u02B6\u02C1\u02B7\u02B7\u02B2\u02BC\u02B5;
		for (int i = 1; i < this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count; i++)
		{
			this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[i] = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[i].\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1;
		}
	}

	public void \u02B2\u02B3\u02BA\u02B8\u02BA\u02BD\u02B9\u02BE\u02BB\u02C1\u02B7(List<\u02B8\u02BB\u02B2\u02B5\u02C1\u02C1\u02BB\u02B7\u02B3\u02B4\u02B6> \u02B4\u02BC\u02B6\u02C1\u02B6\u02C1\u02B7\u02B7\u02B2\u02BC\u02B5)
	{
		if (this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA == null)
		{
			this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA = new float[this.gameManager.song.\u02B2\u02B5\u02B9\u02BC\u02B2\u02BE\u02BF\u02BC\u02B5\u02BD\u02C1.Count];
		}
		base.enabled = false;
		this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD = \u02B4\u02BC\u02B6\u02C1\u02B6\u02C1\u02B7\u02B7\u02B2\u02BC\u02B5;
		for (int i = 1; i < this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count; i += 0)
		{
			this.\u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA[i] = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[i].\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1;
		}
	}

	private void \u02B7\u02BF\u02BC\u02C0\u02B5\u02BD\u02BF\u02BB\u02C1\u02BF\u02B2()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 == null || !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.sectionDisplay.text = "Quit";
		this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5 = 413f;
		base.enabled = false;
	}

	private void \u02B5\u02BD\u02BD\u02BE\u02B9\u02BD\u02B2\u02C1\u02C1\u02B3\u02B6()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 == null || !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.sectionDisplay.text = "Song Length";
		this.\u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5 = 414f;
		base.enabled = true;
	}

	[HideInInspector]
	public List<\u02B8\u02BB\u02B2\u02B5\u02C1\u02C1\u02BB\u02B7\u02B3\u02B4\u02B6> \u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD;

	private float[] \u02B9\u02B8\u02B7\u02BC\u02BF\u02BA\u02B4\u02BA\u02B6\u02B2\u02BA;

	[SerializeField]
	private TextMeshProUGUI sectionDisplay;

	[SerializeField]
	private GameManager gameManager;

	private int \u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6;

	private bool \u02B7\u02B5\u02B3\u02BE\u02B4\u02B4\u02BC\u02BF\u02B4\u02BA\u02B8;

	private bool \u02B8\u02B7\u02BA\u02B2\u02B4\u02B5\u02BA\u02BF\u02BC\u02BA\u02BF;

	private const float \u02B6\u02BD\u02B8\u02B8\u02B6\u02B3\u02C0\u02BA\u02B4\u02C0\u02B5 = 1f;

	private float \u02BD\u02BA\u02BF\u02BB\u02BD\u02BD\u02B7\u02C1\u02B8\u02BF\u02B5;
}
