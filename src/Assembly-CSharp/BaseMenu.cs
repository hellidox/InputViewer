﻿using System;
using System.Collections.Generic;
using Rewired;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BaseMenu : MonoBehaviour
{
	public virtual void \u02BC\u02B7\u02BF\u02BD\u02B4\u02BE\u02C0\u02B4\u02BE\u02B7\u02B9()
	{
	}

	protected virtual void \u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(bool \u02B6\u02B8\u02B8\u02BA\u02B6\u02BB\u02BD\u02B8\u02B9\u02B9\u02B8 = true, bool \u02BF\u02C1\u02B7\u02BA\u02C0\u02BE\u02BE\u02C1\u02BB\u02B5\u02C1 = false)
	{
		if (this.tipText)
		{
			this.tipText.enabled = false;
		}
		if (\u02B6\u02B8\u02B8\u02BA\u02B6\u02BB\u02BD\u02B8\u02B9\u02B9\u02B8)
		{
			this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
		}
		base.gameObject.SetActive(\u02BF\u02C1\u02B7\u02BA\u02C0\u02BE\u02BE\u02C1\u02BB\u02B5\u02C1);
		this.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	protected void \u02B6\u02BA\u02B5\u02BE\u02C1\u02B9\u02B9\u02B5\u02BD\u02B2\u02BD()
	{
		if (this.\u02B9\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02C0\u02B5\u02BF\u02BB && this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 >= 3)
		{
			this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = this.startScrollingBottom + 2;
			this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 + 4;
		}
		else
		{
			this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 - 1;
			this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6;
		}
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = true;
	}

	private bool \u02C0\u02B7\u02B3\u02BD\u02BB\u02B7\u02C1\u02B3\u02B6\u02BE\u02C1()
	{
		return this.startScrollingBottom <= 1 || ((this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 >= this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 || this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 < this.startScrollingBottom) && (this.\u02B9\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02C0\u02B5\u02BF\u02BB && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 >= this.startScrollingBottom && this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 >= this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 && this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 < this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 + this.startScrollingBottom - 5));
	}

	protected virtual void \u02C1\u02BB\u02BD\u02B3\u02B9\u02BC\u02BD\u02BF\u02BF\u02B3\u02B3()
	{
		if (this.textObjects.Length == 0 || this.menuStrings.Length == 0)
		{
			return;
		}
		for (int i = 0; i < this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5; i++)
		{
			Color color = this.defaultColor;
			color.a = 1f;
			Color color2 = this.highlightColor;
			color2.a = 1f;
			if (this.backgroundObjects != null && this.backgroundObjects.Length != 0)
			{
				Image[] array = this.backgroundObjects;
				if (((array != null) ? array[i] : null) != null)
				{
					this.backgroundObjects[i].color = this.highlightColor;
				}
			}
			if (this.textObjects[i] != null)
			{
				this.textObjects[i].color = color;
			}
		}
		this.\u02BA\u02B9\u02C1\u02C1\u02BF\u02C1\u02BC\u02BA\u02B3\u02BB\u02C0();
	}

	private void \u02B9\u02B3\u02B4\u02B3\u02B7\u02B5\u02C1\u02C0\u02BE\u02BC\u02B6()
	{
		Vector3 vector = new Vector3(30f, 0f, 0f) * Time.deltaTime * (float)global::UnityEngine.Random.Range(0, 200);
		Color color = new Color(global::UnityEngine.Random.Range(0f, 1f), global::UnityEngine.Random.Range(0f, 1f), global::UnityEngine.Random.Range(0f, 1f), 1f);
		foreach (TextMeshProUGUI textMeshProUGUI in this.textObjects)
		{
			textMeshProUGUI.rectTransform.Rotate(vector);
			textMeshProUGUI.color = color;
		}
	}

	public virtual void \u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, bool \u02B5\u02B8\u02BD\u02B7\u02B9\u02B5\u02BE\u02BE\u02BD\u02B3\u02BF = true)
	{
		if (\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 == -1)
		{
			\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 = 0;
		}
		if (\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 - this.startScrollingTop >= 0)
		{
			this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 - this.startScrollingTop;
			if (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 > this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6)
			{
				if (this.\u02B9\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02C0\u02B5\u02BF\u02BB)
				{
					this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 - (this.startScrollingTop + 2);
					if (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 < 0)
					{
						this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = 0;
						this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5;
					}
					else
					{
						this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 - this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
					}
				}
				else
				{
					this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6;
					this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 - this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
				}
			}
			else
			{
				this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = this.startScrollingTop;
			}
		}
		else
		{
			this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = 0;
			this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5;
		}
		if (\u02B5\u02B8\u02BD\u02B7\u02B9\u02B5\u02BE\u02BE\u02BD\u02B3\u02BF)
		{
			this.\u02B2\u02BD\u02B6\u02BE\u02B4\u02BE\u02B9\u02B6\u02BD\u02B4\u02B7();
		}
	}

	private void \u02C1\u02B4\u02B5\u02C1\u02B4\u02B3\u02BA\u02B2\u02BF\u02B6\u02BD(CHPlayer \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8 = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;
		try
		{
			this.DoInput(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7);
		}
		finally
		{
			this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8 = null;
		}
	}

	protected virtual void Update()
	{
		if (FadeBehaviour.instance.isFading)
		{
			return;
		}
		if (!this.enableSelectionWithoutProfiles)
		{
			this.\u02B4\u02B9\u02BE\u02B7\u02BE\u02BB\u02BF\u02BC\u02B3\u02B5\u02B8(GlobalVariables.instance.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02BE\u02BD\u02BE\u02B5\u02BA\u02C1\u02B7\u02BD\u02BD\u02B9\u02BC <= 0);
		}
		if (this.controllingPlayer == null)
		{
			if (GlobalVariables.instance.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE != null)
			{
				if (this.TestTransitionInputBlock(GlobalVariables.instance.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE))
				{
					this.\u02C1\u02B4\u02B5\u02C1\u02B4\u02B3\u02BA\u02B2\u02BF\u02B6\u02BD(GlobalVariables.instance.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE);
				}
			}
			else
			{
				for (int i = 0; i < 4; i++)
				{
					CHPlayer chplayer = GlobalVariables.instance.playerList[i];
					if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && (!chplayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD || this.isProfileMenu) && !this.disableControls && (chplayer.playerProfile == null || !chplayer.playerProfile.isRemotePlayer) && this.TestTransitionInputBlock(chplayer))
					{
						this.\u02C1\u02B4\u02B5\u02C1\u02B4\u02B3\u02BA\u02B2\u02BF\u02B6\u02BD(chplayer);
					}
				}
			}
		}
		else if (this.TestTransitionInputBlock(this.controllingPlayer))
		{
			this.\u02C1\u02B4\u02B5\u02C1\u02B4\u02B3\u02BA\u02B2\u02BF\u02B6\u02BD(this.controllingPlayer);
		}
		if (this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF)
		{
			this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = false;
			this.\u02B2\u02BD\u02B6\u02BE\u02B4\u02BE\u02B9\u02B6\u02BD\u02B4\u02B7();
		}
		if (BaseMenu.HAVEFUN)
		{
			this.\u02B9\u02B3\u02B4\u02B3\u02B7\u02B5\u02C1\u02C0\u02BE\u02BC\u02B6();
		}
		this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 -= Time.unscaledDeltaTime;
		this.\u02B7\u02B9\u02BF\u02B5\u02B6\u02B5\u02B9\u02B8\u02B6\u02B2\u02B4 -= Time.unscaledDeltaTime;
	}

	protected string \u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0
	{
		get
		{
			if (this.menuStrings.Length != 0)
			{
				return this.menuStrings[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 + this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7];
			}
			return null;
		}
	}

	public virtual void \u02B8\u02BF\u02B4\u02B2\u02BE\u02B5\u02BC\u02B2\u02B5\u02BD\u02B8()
	{
	}

	protected void \u02B7\u02B9\u02BE\u02B2\u02B3\u02C0\u02BF\u02BB\u02BD\u02BF\u02BC()
	{
		this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = (this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = this.menuTopStart);
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = true;
	}

	public virtual void \u02BA\u02C0\u02C1\u02B2\u02B2\u02B9\u02B2\u02BF\u02B8\u02BE\u02BC()
	{
	}

	protected void \u02BA\u02B3\u02B9\u02BF\u02BB\u02C0\u02BD\u02BC\u02B9\u02BB\u02BD()
	{
		if (!this.tipText)
		{
			return;
		}
		this.tipText.text = "groupNotesMissed";
		if (!base.gameObject.activeSelf || this.tipStrings == null || this.tipStrings.Length <= this.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC)
		{
			return;
		}
		if (this.allowMultiLanguage)
		{
			this.tipText.text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().GetString(this.tipStrings[this.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC]);
		}
		else
		{
			this.tipText.text = this.tipStrings[this.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC];
		}
		this.tipText.enabled = false;
	}

	public virtual void \u02BA\u02B4\u02BC\u02B6\u02BC\u02B7\u02BD\u02B3\u02BA\u02BE\u02C0()
	{
	}

	public int \u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC
	{
		get
		{
			return this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 + this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3;
		}
	}

	protected string \u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7()
	{
		if (this.menuStrings.Length != 0)
		{
			return this.menuStrings[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 + this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7];
		}
		return null;
	}

	public virtual void \u02C0\u02BD\u02BD\u02B4\u02B5\u02B4\u02B6\u02B8\u02BD\u02B8\u02BB()
	{
	}

	protected virtual void \u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8()
	{
		if (this.textObjects.Length == 0 || this.menuStrings.Length == 0)
		{
			if (this.backgroundObjects != null)
			{
				for (int i = 0; i < this.backgroundObjects.Length; i++)
				{
					Image[] array = this.backgroundObjects;
					if (((array != null) ? array[i] : null) != null)
					{
						this.backgroundObjects[i].color = this.highlightColor;
					}
				}
			}
			return;
		}
		int num = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
		this.\u02B9\u02BB\u02BE\u02BD\u02B3\u02C1\u02BF\u02B8\u02BD\u02B5\u02B6();
		for (int j = 0; j < this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5; j++)
		{
			string text = null;
			if (this.allowMultiLanguage)
			{
				text = LanguageManager.instance.GetString(this.menuStrings[num]);
			}
			if (text == null)
			{
				text = this.menuStrings[num];
			}
			Color color = this.defaultColor;
			color.a = 1f;
			Color color2 = this.highlightColor;
			color2.a = 1f;
			if (!this.disableControls && j == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3)
			{
				if (this.backgroundObjects != null && this.backgroundObjects.Length != 0)
				{
					Image[] array2 = this.backgroundObjects;
					if (((array2 != null) ? array2[j] : null) != null)
					{
						this.backgroundObjects[j].color = this.defaultColor;
					}
				}
				if (this.textObjects[j] != null)
				{
					this.textObjects[j].color = color2;
				}
			}
			else
			{
				if (this.backgroundObjects != null && this.backgroundObjects.Length != 0)
				{
					Image[] array3 = this.backgroundObjects;
					if (((array3 != null) ? array3[j] : null) != null)
					{
						this.backgroundObjects[j].color = this.highlightColor;
					}
				}
				if (this.textObjects[j] != null)
				{
					this.textObjects[j].color = color;
				}
			}
			if (this.textObjects[j] != null)
			{
				this.textObjects[j].text = (this.useUppercase ? text.ToUpper() : text);
			}
			num++;
		}
		for (int k = this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5; k < this.backgroundObjects.Length; k++)
		{
			if (this.backgroundObjects[k] != null)
			{
				this.backgroundObjects[k].color = this.highlightColor;
			}
		}
		this.\u02BA\u02B9\u02C1\u02C1\u02BF\u02C1\u02BC\u02BA\u02B3\u02BB\u02C0();
	}

	protected void \u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1()
	{
		if (this.controllingPlayer == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer chplayer = enumerator.Current;
					if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && (!chplayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD || this.isProfileMenu) && !this.disableControls && (chplayer.playerProfile == null || !chplayer.playerProfile.isRemotePlayer))
					{
						chplayer.transitioning = true;
					}
				}
				return;
			}
		}
		this.controllingPlayer.transitioning = true;
	}

	public void \u02B4\u02B9\u02BE\u02B7\u02BE\u02BB\u02BF\u02BC\u02B3\u02B5\u02B8(bool \u02BD\u02BB\u02BD\u02B6\u02B5\u02C1\u02B8\u02B5\u02B3\u02B2\u02B4)
	{
		if (\u02BD\u02BB\u02BD\u02B6\u02B5\u02C1\u02B8\u02B5\u02B3\u02B2\u02B4 != this.disableControls)
		{
			this.disableControls = \u02BD\u02BB\u02BD\u02B6\u02B5\u02C1\u02B8\u02B5\u02B3\u02B2\u02B4;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		}
	}

	protected void \u02B9\u02BB\u02BE\u02BD\u02B3\u02C1\u02BF\u02B8\u02BD\u02B5\u02B6()
	{
		if (!this.tipText)
		{
			return;
		}
		this.tipText.text = "";
		if (!base.gameObject.activeSelf || this.tipStrings == null || this.tipStrings.Length <= this.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC)
		{
			return;
		}
		if (this.allowMultiLanguage)
		{
			this.tipText.text = LanguageManager.instance.GetString(this.tipStrings[this.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC]);
		}
		else
		{
			this.tipText.text = this.tipStrings[this.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC];
		}
		this.tipText.enabled = true;
	}

	protected virtual void OnDisable()
	{
		if (this.wrapToTopOnEnable)
		{
			this.\u02B7\u02B9\u02BE\u02B2\u02B3\u02C0\u02BF\u02BB\u02BD\u02BF\u02BC();
		}
		this.isActive = false;
	}

	private bool \u02C0\u02B9\u02BE\u02B2\u02C1\u02B7\u02BF\u02B9\u02B8\u02BE\u02BD()
	{
		return this.startScrollingBottom > 1 && (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 >= this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 || this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 < this.startScrollingBottom) && (!this.\u02B9\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02C0\u02B5\u02BF\u02BB || this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 < this.startScrollingBottom || this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 < this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 || this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 >= this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 + this.startScrollingBottom - 1);
	}

	public virtual void \u02BA\u02BB\u02B7\u02B6\u02B2\u02B2\u02B8\u02BB\u02B2\u02BB\u02B7()
	{
	}

	public virtual void \u02BB\u02B3\u02BF\u02BC\u02C1\u02BC\u02BC\u02C1\u02C0\u02B5\u02BA()
	{
	}

	protected virtual void \u02BC\u02B9\u02BD\u02BB\u02BD\u02BB\u02B6\u02B9\u02B6\u02BD\u02B2(bool \u02BE\u02B5\u02B9\u02B4\u02C0\u02C0\u02BF\u02BB\u02C0\u02B5\u02B9 = true)
	{
		int u02B3_u02BF_u02BB_u02BB_u02B5_u02B7_u02B8_u02BE_u02B7_u02B3_u02B = this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3;
		int u02BB_u02B3_u02C0_u02BC_u02BF_u02BD_u02B9_u02B2_u02BC_u02BE_u02B = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
		if (this.scrollWholeMenu)
		{
			if (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 < this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6)
			{
				this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 += 0;
			}
		}
		else if (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 + this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 == this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 + this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 - 0)
		{
			if (!this.\u02C0\u02C1\u02B6\u02BF\u02BF\u02B2\u02B5\u02C0\u02BB\u02BA\u02C1 && this.allowWrapping)
			{
				this.\u02B7\u02B9\u02BE\u02B2\u02B3\u02C0\u02BF\u02BB\u02BD\u02BF\u02BC();
			}
		}
		else if (this.\u02C0\u02B9\u02BE\u02B2\u02C1\u02B7\u02BF\u02B9\u02B8\u02BE\u02BD())
		{
			this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7++;
		}
		else
		{
			this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3++;
		}
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = false;
		if (this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 == 0)
		{
			this.\u02BA\u02BE\u02B7\u02BE\u02B3\u02C1\u02BC\u02B8\u02B7\u02C1\u02B6 = 1;
		}
		if (this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 >= 7 && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 != u02B3_u02BF_u02BB_u02BB_u02B5_u02B7_u02B8_u02BE_u02B7_u02B3_u02B)
		{
			this.\u02BA\u02BE\u02B7\u02BE\u02B3\u02C1\u02BC\u02B8\u02B7\u02C1\u02B6 += 0;
		}
		if (\u02BE\u02B5\u02B9\u02B4\u02C0\u02C0\u02BF\u02BB\u02C0\u02B5\u02B9 && (u02B3_u02BF_u02BB_u02BB_u02B5_u02B7_u02B8_u02BE_u02B7_u02B3_u02B != this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 || u02BB_u02B3_u02C0_u02BC_u02BF_u02BD_u02B9_u02B2_u02BC_u02BE_u02B != this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7))
		{
			GameAudioManager.PlaySound((SoundEffectsChannel)117);
		}
	}

	public virtual void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		this.\u02B7\u02C0\u02BB\u02B6\u02B3\u02C0\u02B9\u02BF\u02B5\u02C0\u02B6 = true;
		this.\u02B7\u02C1\u02BA\u02BA\u02B2\u02B5\u02B7\u02BD\u02BC\u02C1\u02BE(true);
		this.\u02C0\u02C1\u02B6\u02BF\u02BF\u02B2\u02B5\u02C0\u02BB\u02BA\u02C1 = true;
	}

	protected void \u02B2\u02B2\u02BC\u02B7\u02BC\u02B8\u02BD\u02BA\u02C1\u02B7\u02BF()
	{
		if (this.scrollWholeMenu)
		{
			return;
		}
		if (this.selectionTransform)
		{
			this.\u02C1\u02B3\u02B3\u02BD\u02BE\u02BF\u02B8\u02B6\u02C0\u02B7\u02C0 = this.selectionTransform.anchoredPosition;
			return;
		}
		Transform transform = base.transform.Find("Selection");
		if (transform)
		{
			this.selectionTransform = transform.GetComponent<RectTransform>();
			this.\u02C1\u02B3\u02B3\u02BD\u02BE\u02BF\u02B8\u02B6\u02C0\u02B7\u02C0 = this.selectionTransform.anchoredPosition;
		}
	}

	public virtual void \u02B8\u02B9\u02C0\u02BA\u02C0\u02C0\u02B7\u02BE\u02B5\u02B2\u02B7(byte \u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1)
	{
		switch (\u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1)
		{
		case 0:
			this.ConfirmPressed();
			return;
		case 1:
			this.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
			return;
		case 2:
			this.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		case 3:
			this.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			return;
		default:
			return;
		}
	}

	protected virtual void OnEnable()
	{
		if (this.tipText)
		{
			this.tipText.enabled = true;
			this.\u02B9\u02BB\u02BE\u02BD\u02B3\u02C1\u02BF\u02B8\u02BD\u02B5\u02B6();
		}
		this.isActive = true;
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = true;
	}

	private bool \u02C1\u02B4\u02BE\u02B2\u02BE\u02B4\u02BA\u02B5\u02B5\u02C0\u02C1(Player \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7, int \u02BB\u02C1\u02C0\u02B5\u02B2\u02BD\u02B8\u02BE\u02B2\u02B5\u02B4)
	{
		if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.GetButtonUp(\u02BB\u02C1\u02C0\u02B5\u02B2\u02BD\u02B8\u02BE\u02B2\u02B5\u02B4))
		{
			this.\u02B7\u02B9\u02BF\u02B5\u02B6\u02B5\u02B9\u02B8\u02B6\u02B2\u02B4 = 0f;
			this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 = 0f;
			return false;
		}
		if (this.\u02B7\u02B9\u02BF\u02B5\u02B6\u02B5\u02B9\u02B8\u02B6\u02B2\u02B4 > 0f || this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 > 0f)
		{
			return false;
		}
		if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.GetButtonDown(\u02BB\u02C1\u02C0\u02B5\u02B2\u02BD\u02B8\u02BE\u02B2\u02B5\u02B4))
		{
			this.\u02B7\u02B9\u02BF\u02B5\u02B6\u02B5\u02B9\u02B8\u02B6\u02B2\u02B4 = this.\u02BA\u02C0\u02B4\u02B5\u02BA\u02BE\u02BB\u02BD\u02B9\u02B6\u02B2;
			return true;
		}
		if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.GetButton(\u02BB\u02C1\u02C0\u02B5\u02B2\u02BD\u02B8\u02BE\u02B2\u02B5\u02B4))
		{
			this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 = this.\u02BA\u02C1\u02BC\u02B9\u02BE\u02B4\u02C0\u02BE\u02B9\u02BA\u02BA;
			return true;
		}
		return false;
	}

	public virtual void GreenLongPressed()
	{
	}

	public virtual void \u02C1\u02B6\u02BD\u02BC\u02BC\u02B3\u02BF\u02BF\u02C0\u02C1\u02BC()
	{
	}

	protected void \u02BA\u02B9\u02C1\u02C1\u02BF\u02C1\u02BC\u02BA\u02B3\u02BB\u02C0()
	{
		if (this.menuStrings.Length >= this.textObjects.Length)
		{
			return;
		}
		for (int i = this.menuStrings.Length; i < this.textObjects.Length; i++)
		{
			if (this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2)
			{
				this.textObjects[i].text = "";
			}
			this.textObjects[i].color = this.defaultColor;
		}
	}

	public virtual void \u02BF\u02BB\u02BC\u02BC\u02B8\u02C1\u02B9\u02BC\u02B6\u02BA\u02B6()
	{
	}

	protected void \u02B2\u02BA\u02B2\u02BC\u02BE\u02B5\u02B4\u02C0\u02BC\u02B6\u02BD()
	{
		if (this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD == null && this.\u02BD\u02B5\u02BC\u02B8\u02B2\u02C0\u02B7\u02B8\u02B9\u02C0\u02B9 == null)
		{
			return;
		}
		this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.value = 1f - (float)this.\u02BA\u02BE\u02B7\u02BE\u02B3\u02C1\u02BC\u02B8\u02B7\u02C1\u02B6 * (1f / ((float)this.menuStrings.Length - 7f));
		this.\u02BD\u02B5\u02BC\u02B8\u02B2\u02C0\u02B7\u02B8\u02B9\u02C0\u02B9.verticalNormalizedPosition = 1f - (float)this.\u02BA\u02BE\u02B7\u02BE\u02B3\u02C1\u02BC\u02B8\u02B7\u02C1\u02B6 * (1f / ((float)this.menuStrings.Length - 7f));
		Canvas.ForceUpdateCanvases();
	}

	protected virtual void \u02B2\u02BD\u02B6\u02BE\u02B4\u02BE\u02B9\u02B6\u02BD\u02B4\u02B7()
	{
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		this.\u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2();
	}

	public virtual void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		this.\u02BC\u02B7\u02C0\u02B6\u02C1\u02B9\u02BB\u02B2\u02BD\u02B3\u02B8 = true;
		this.\u02BE\u02B4\u02BD\u02B6\u02B5\u02B7\u02BB\u02BE\u02B3\u02B5\u02B9(true);
		this.\u02B4\u02B7\u02B3\u02BF\u02B4\u02BF\u02B9\u02C1\u02B6\u02B2\u02C0 = true;
	}

	public void \u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(string \u02BC\u02B4\u02BB\u02B6\u02B2\u02BE\u02BA\u02C0\u02B8\u02BE\u02B7)
	{
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(Array.IndexOf<string>(this.menuStrings, \u02BC\u02B4\u02BB\u02B6\u02B2\u02BE\u02BA\u02C0\u02B8\u02BE\u02B7), true);
	}

	protected virtual void \u02B7\u02C1\u02BA\u02BA\u02B2\u02B5\u02B7\u02BD\u02BC\u02C1\u02BE(bool \u02BE\u02B5\u02B9\u02B4\u02C0\u02C0\u02BF\u02BB\u02C0\u02B5\u02B9 = true)
	{
		int u02B3_u02BF_u02BB_u02BB_u02B5_u02B7_u02B8_u02BE_u02B7_u02B3_u02B = this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3;
		int u02BB_u02B3_u02C0_u02BC_u02BF_u02BD_u02B9_u02B2_u02BC_u02BE_u02B = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
		if (this.scrollWholeMenu)
		{
			if (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 < this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6)
			{
				this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7++;
			}
		}
		else if (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 + this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 == this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 + this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 - 1)
		{
			if (!this.\u02C0\u02C1\u02B6\u02BF\u02BF\u02B2\u02B5\u02C0\u02BB\u02BA\u02C1 && this.allowWrapping)
			{
				this.\u02B7\u02B9\u02BE\u02B2\u02B3\u02C0\u02BF\u02BB\u02BD\u02BF\u02BC();
			}
		}
		else if (this.\u02B2\u02B5\u02B4\u02B4\u02BC\u02B3\u02BC\u02C1\u02B2\u02BE\u02B3())
		{
			this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7++;
		}
		else
		{
			this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3++;
		}
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = true;
		if (this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 == 0)
		{
			this.\u02BA\u02BE\u02B7\u02BE\u02B3\u02C1\u02BC\u02B8\u02B7\u02C1\u02B6 = 0;
		}
		if (this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 >= 7 && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 != u02B3_u02BF_u02BB_u02BB_u02B5_u02B7_u02B8_u02BE_u02B7_u02B3_u02B)
		{
			this.\u02BA\u02BE\u02B7\u02BE\u02B3\u02C1\u02BC\u02B8\u02B7\u02C1\u02B6++;
		}
		if (\u02BE\u02B5\u02B9\u02B4\u02C0\u02C0\u02BF\u02BB\u02C0\u02B5\u02B9 && (u02B3_u02BF_u02BB_u02BB_u02B5_u02B7_u02B8_u02BE_u02B7_u02B3_u02B != this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 || u02BB_u02B3_u02C0_u02BC_u02BF_u02BD_u02B9_u02B2_u02BC_u02BE_u02B != this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7))
		{
			GameAudioManager.PlaySound(SoundEffectsChannel.UIScrollDown);
		}
	}

	public virtual void ConfirmPressed()
	{
		this.\u02BD\u02B5\u02BE\u02BC\u02B4\u02B6\u02B7\u02BF\u02B4\u02BF\u02C0 = true;
		GameAudioManager.PlaySound(SoundEffectsChannel.UIConfirm);
	}

	protected bool \u02C0\u02B9\u02BE\u02BF\u02BA\u02BE\u02B9\u02B4\u02BE\u02BA\u02B5()
	{
		return this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 == this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 - 1;
	}

	public virtual void \u02B3\u02B3\u02B9\u02BC\u02B7\u02BF\u02BA\u02B5\u02BB\u02BE\u02B8()
	{
		this.\u02B4\u02B7\u02B3\u02BF\u02B4\u02BF\u02B9\u02C1\u02B6\u02B2\u02C0 = false;
	}

	public virtual void \u02BF\u02B5\u02BD\u02B6\u02C1\u02BB\u02BD\u02BE\u02B5\u02B2\u02BD()
	{
		this.\u02C0\u02C1\u02B6\u02BF\u02BF\u02B2\u02B5\u02C0\u02BB\u02BA\u02C1 = false;
	}

	private bool \u02B6\u02C0\u02BD\u02B7\u02BA\u02BA\u02BC\u02B6\u02B3\u02B2\u02C0()
	{
		return this.startScrollingTop > 0 && (this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 > 0 && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 <= this.startScrollingTop);
	}

	public virtual void \u02B5\u02BF\u02B2\u02B4\u02BB\u02B5\u02B9\u02B4\u02BC\u02BB\u02C1()
	{
	}

	public virtual void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		this.\u02BA\u02B8\u02B2\u02C1\u02BF\u02C0\u02BD\u02C0\u02B4\u02B4\u02B2 = true;
		GameAudioManager.PlaySound(SoundEffectsChannel.UICancel);
	}

	protected virtual void \u02BE\u02B4\u02BD\u02B6\u02B5\u02B7\u02BB\u02BE\u02B3\u02B5\u02B9(bool \u02BE\u02B5\u02B9\u02B4\u02C0\u02C0\u02BF\u02BB\u02C0\u02B5\u02B9 = true)
	{
		int u02B3_u02BF_u02BB_u02BB_u02B5_u02B7_u02B8_u02BE_u02B7_u02B3_u02B = this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3;
		int u02BB_u02B3_u02C0_u02BC_u02BF_u02BD_u02B9_u02B2_u02BC_u02BE_u02B = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
		if (this.scrollWholeMenu)
		{
			if (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 > 0)
			{
				this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7--;
			}
		}
		else if (this.\u02C1\u02BD\u02BD\u02BC\u02B9\u02B6\u02C0\u02B3\u02BD\u02B5\u02B4())
		{
			if (!this.\u02C0\u02BA\u02BE\u02B6\u02C1\u02B4\u02B5\u02B3\u02BC\u02B6\u02B2())
			{
				this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3--;
			}
			else if (!this.\u02B4\u02B7\u02B3\u02BF\u02B4\u02BF\u02B9\u02C1\u02B6\u02B2\u02C0 && this.allowWrapping)
			{
				this.\u02B6\u02BA\u02B5\u02BE\u02C1\u02B9\u02B9\u02B5\u02BD\u02B2\u02BD();
			}
		}
		else if (this.\u02B6\u02C0\u02BD\u02B7\u02BA\u02BA\u02BC\u02B6\u02B3\u02B2\u02C0())
		{
			this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7--;
		}
		else
		{
			this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3--;
		}
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = true;
		if (this.\u02BA\u02BE\u02B7\u02BE\u02B3\u02C1\u02BC\u02B8\u02B7\u02C1\u02B6 > 0 && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 != u02B3_u02BF_u02BB_u02BB_u02B5_u02B7_u02B8_u02BE_u02B7_u02B3_u02B)
		{
			this.\u02BA\u02BE\u02B7\u02BE\u02B3\u02C1\u02BC\u02B8\u02B7\u02C1\u02B6--;
		}
		if (\u02BE\u02B5\u02B9\u02B4\u02C0\u02C0\u02BF\u02BB\u02C0\u02B5\u02B9 && (u02B3_u02BF_u02BB_u02BB_u02B5_u02B7_u02B8_u02BE_u02B7_u02B3_u02B != this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 || u02BB_u02B3_u02C0_u02BC_u02BF_u02BD_u02B9_u02B2_u02BC_u02BE_u02B != this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7))
		{
			GameAudioManager.PlaySound(SoundEffectsChannel.UIScrollUp);
		}
	}

	protected void \u02B9\u02B3\u02BE\u02BC\u02C1\u02B8\u02C1\u02C0\u02BB\u02BB\u02B7()
	{
		if (this.\u02B9\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02C0\u02B5\u02BF\u02BB && this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 >= 4)
		{
			this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = this.startScrollingBottom + 8;
			this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 + 5;
		}
		else
		{
			this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 - 1;
			this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6;
		}
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = false;
	}

	public virtual void \u02BA\u02BC\u02C1\u02BE\u02B6\u02B4\u02B9\u02B2\u02B3\u02BD\u02B4()
	{
	}

	protected virtual void DoInput(CHPlayer player)
	{
		if (!player.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD || (player.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD && !this.isProfileMenu) || this.disableControls || (player.playerProfile != null && player.playerProfile.isRemotePlayer))
		{
			return;
		}
		if (ColorProfileEditor.\u02BF\u02B3\u02B6\u02B5\u02BB\u02B7\u02BE\u02BF\u02C1\u02BA\u02BF() || SongPathsManager.\u02BF\u02B3\u02B6\u02B5\u02BB\u02B7\u02BE\u02BF\u02C1\u02BA\u02BF())
		{
			return;
		}
		this.\u02B7\u02C0\u02BB\u02B6\u02B3\u02C0\u02B9\u02BF\u02B5\u02C0\u02B6 = (this.\u02BC\u02B7\u02C0\u02B6\u02C1\u02B9\u02BB\u02B2\u02BD\u02B3\u02B8 = false);
		if (player.player.GetButtonRepeating(32))
		{
			this.\u02BB\u02B3\u02BF\u02BC\u02C1\u02BC\u02BC\u02C1\u02C0\u02B5\u02BA();
		}
		else if (player.player.GetButtonRepeating(31))
		{
			this.\u02BD\u02B9\u02BE\u02BB\u02B9\u02BA\u02B5\u02BC\u02BE\u02C1\u02B2();
		}
		bool flag = false;
		if (player.player.GetButton(0))
		{
			flag = true;
		}
		bool flag2 = true;
		if (player.playerProfile != null)
		{
			flag2 = player.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
		}
		if (player.player.GetButtonDown(0))
		{
			this.ConfirmPressed();
		}
		else if (player.player.GetButtonTimedPressDown(0, this.longPressTime))
		{
			this.GreenLongPressed();
		}
		else if (player.player.GetButtonTimedPressDown(1, this.longPressTime))
		{
			this.\u02B8\u02B6\u02BB\u02C0\u02BA\u02B2\u02BC\u02BF\u02BF\u02BC\u02C1();
		}
		else if (player.player.GetButtonUp(0))
		{
			this.\u02C1\u02B6\u02BD\u02BC\u02BC\u02B3\u02BF\u02BF\u02C0\u02C1\u02BC();
		}
		else if (player.player.GetButtonDown(1))
		{
			this.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		}
		else if (player.player.GetButtonDown(2))
		{
			if (flag2)
			{
				this.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			}
			else
			{
				this.\u02BA\u02BC\u02C1\u02BE\u02B6\u02B4\u02B9\u02B2\u02B3\u02BD\u02B4();
			}
		}
		else if (player.player.GetButtonUp(2))
		{
			if (flag2)
			{
				this.\u02B3\u02B3\u02B9\u02BC\u02B7\u02BF\u02BA\u02B5\u02BB\u02BE\u02B8();
			}
			else
			{
				this.\u02BF\u02BB\u02BC\u02BC\u02B8\u02C1\u02B9\u02BC\u02B6\u02BA\u02B6();
			}
		}
		else if (!flag2 && player.player.GetButtonTimedPressDown(2, this.longPressTime))
		{
			this.\u02BA\u02BB\u02B7\u02B6\u02B2\u02B2\u02B8\u02BB\u02B2\u02BB\u02B7();
		}
		else if (player.player.GetButtonDown(3))
		{
			if (flag2)
			{
				this.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			}
			else
			{
				this.\u02C0\u02BD\u02BD\u02B4\u02B5\u02B4\u02B6\u02B8\u02BD\u02B8\u02BB();
			}
		}
		else if (player.player.GetButtonUp(3))
		{
			if (flag2)
			{
				this.\u02BF\u02B5\u02BD\u02B6\u02C1\u02BB\u02BD\u02BE\u02B5\u02B2\u02BD();
			}
			else
			{
				this.\u02B8\u02BF\u02B4\u02B2\u02BE\u02B5\u02BC\u02B2\u02B5\u02BD\u02B8();
			}
		}
		else if (!flag2 && player.player.GetButtonTimedPressDown(3, this.longPressTime))
		{
			this.\u02B5\u02BF\u02B2\u02B4\u02BB\u02B5\u02B9\u02B4\u02BC\u02BB\u02C1();
		}
		else if (player.player.GetButtonDown(4))
		{
			this.\u02BA\u02B4\u02BC\u02B6\u02BC\u02B7\u02BD\u02B3\u02BA\u02BE\u02C0();
		}
		else if (player.player.GetButtonUp(4))
		{
			this.\u02B6\u02BE\u02B5\u02C1\u02B6\u02B6\u02B5\u02B3\u02BE\u02B4\u02B7();
		}
		else if (player.player.GetButtonTimedPressDown(4, this.longPressTime))
		{
			this.\u02BA\u02C0\u02C1\u02B2\u02B2\u02B9\u02B2\u02BF\u02B8\u02BE\u02BC();
		}
		else if (player.player.GetButtonDown(6))
		{
			this.\u02BC\u02B7\u02BF\u02BD\u02B4\u02BE\u02C0\u02B4\u02BE\u02B7\u02B9();
		}
		else if (player.player.GetButtonDown(16))
		{
			this.\u02B7\u02B8\u02B5\u02B5\u02BF\u02C0\u02BA\u02BA\u02B3\u02BE\u02C0();
		}
		if (flag || !player.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
		{
			return;
		}
		if (player.playerProfile != null && player.playerProfile.leftyFlip && player.playerProfile.instrument != Instrument.Drums && player.playerProfile.instrument != Instrument.ProDrums)
		{
			if (this.\u02C1\u02B4\u02BE\u02B2\u02BE\u02B4\u02BA\u02B5\u02B5\u02C0\u02C1(player.player, 5))
			{
				this.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			}
			if (this.\u02C1\u02B4\u02BE\u02B2\u02BE\u02B4\u02BA\u02B5\u02B5\u02C0\u02C1(player.player, 14))
			{
				this.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			}
			if (player.player.GetButtonUp(5))
			{
				this.\u02BF\u02B5\u02BD\u02B6\u02C1\u02BB\u02BD\u02BE\u02B5\u02B2\u02BD();
			}
			if (player.player.GetButtonUp(14))
			{
				this.\u02B3\u02B3\u02B9\u02BC\u02B7\u02BF\u02BA\u02B5\u02BB\u02BE\u02B8();
				return;
			}
		}
		else
		{
			if (this.\u02C1\u02B4\u02BE\u02B2\u02BE\u02B4\u02BA\u02B5\u02B5\u02C0\u02C1(player.player, 5))
			{
				this.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			}
			if (this.\u02C1\u02B4\u02BE\u02B2\u02BE\u02B4\u02BA\u02B5\u02B5\u02C0\u02C1(player.player, 14))
			{
				this.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			}
			if (player.player.GetButtonUp(5))
			{
				this.\u02B3\u02B3\u02B9\u02BC\u02B7\u02BF\u02BA\u02B5\u02BB\u02BE\u02B8();
			}
			if (player.player.GetButtonUp(14))
			{
				this.\u02BF\u02B5\u02BD\u02B6\u02C1\u02BB\u02BD\u02BE\u02B5\u02B2\u02BD();
			}
		}
	}

	public void \u02C1\u02BB\u02B8\u02B9\u02C1\u02BD\u02BF\u02BB\u02B4\u02BF\u02BD(TextMeshProUGUI[] \u02C0\u02BE\u02B5\u02BE\u02BC\u02BC\u02BF\u02BE\u02B6\u02B6\u02BD)
	{
		this.textObjects = \u02C0\u02BE\u02B5\u02BE\u02BC\u02BC\u02BF\u02BE\u02B6\u02B6\u02BD;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
	}

	public void \u02B8\u02BE\u02BD\u02BB\u02B2\u02B6\u02B3\u02BB\u02BB\u02C0\u02B8(CHPlayer \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		this.controllingPlayer = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;
	}

	protected virtual void Start()
	{
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = true;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public virtual void \u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0()
	{
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = this.textObjects.Length;
		if (this.menuStrings.Length == 0)
		{
			this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = (this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = (this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = 0)));
			return;
		}
		if (this.menuStrings.Length > this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
		{
			this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = this.menuStrings.Length - this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5;
			return;
		}
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = this.menuStrings.Length;
		this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = 0;
	}

	public virtual void \u02BD\u02B9\u02BE\u02BB\u02B9\u02BA\u02B5\u02BC\u02BE\u02C1\u02B2()
	{
	}

	public virtual void \u02BF\u02BD\u02B6\u02B2\u02B6\u02BE\u02B5\u02BF\u02BA\u02B8\u02BD()
	{
	}

	public void \u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA()
	{
		for (int i = 0; i < this.textObjects.Length; i++)
		{
			this.textObjects[i].text = LanguageManager.instance.GetString(this.menuStrings[i]);
		}
	}

	public virtual void \u02B6\u02BE\u02B5\u02C1\u02B6\u02B6\u02B5\u02B3\u02BE\u02B4\u02B7()
	{
	}

	public virtual void \u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2()
	{
		if (!this.selectionTransform)
		{
			return;
		}
		this.selectionTransform.anchoredPosition = new Vector2(this.\u02C1\u02B3\u02B3\u02BD\u02BE\u02BF\u02B8\u02B6\u02C0\u02B7\u02C0.x, this.\u02C1\u02B3\u02B3\u02BD\u02BE\u02BF\u02B8\u02B6\u02C0\u02B7\u02C0.y + -this.textPositionDifference.y * (float)this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3);
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = false;
	}

	public virtual void \u02B8\u02B6\u02BB\u02C0\u02BA\u02B2\u02BC\u02BF\u02BF\u02BC\u02C1()
	{
	}

	public virtual void \u02B7\u02B8\u02B5\u02B5\u02BF\u02C0\u02BA\u02BA\u02B3\u02BE\u02C0()
	{
	}

	protected bool \u02B2\u02B2\u02BD\u02B2\u02B3\u02B8\u02BC\u02BB\u02C0\u02B7\u02B9()
	{
		return this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 == this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6;
	}

	protected bool \u02C0\u02BA\u02BE\u02B6\u02C1\u02B4\u02B5\u02B3\u02BC\u02B6\u02B2()
	{
		return this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 == this.menuTopStart;
	}

	protected virtual bool TestTransitionInputBlock(CHPlayer player)
	{
		if (!player.transitioning)
		{
			return true;
		}
		bool flag = false;
		foreach (int num in BaseMenu.actionButtons)
		{
			if (player.player.GetButton(num) || player.player.GetButtonUp(num) || player.player.GetButtonDown(num))
			{
				flag = true;
			}
		}
		if (flag)
		{
			return false;
		}
		player.transitioning = false;
		return true;
	}

	protected void \u02BE\u02C0\u02BE\u02B9\u02B2\u02C1\u02B4\u02BD\u02B7\u02B2\u02BA()
	{
		if (this.\u02B9\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02C0\u02B5\u02BF\u02BB && this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 >= 6)
		{
			this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = this.startScrollingBottom + 5;
			this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 + 1;
		}
		else
		{
			this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 - 0;
			this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6;
		}
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = false;
	}

	protected bool \u02C1\u02BD\u02BD\u02BC\u02B9\u02B6\u02C0\u02B3\u02BD\u02B5\u02B4()
	{
		return this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 <= this.menuTopStart;
	}

	private bool \u02B2\u02B5\u02B4\u02B4\u02BC\u02B3\u02BC\u02C1\u02B2\u02BE\u02B3()
	{
		return this.startScrollingBottom > 0 && ((this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 < this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 >= this.startScrollingBottom) || (this.\u02B9\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02C0\u02B5\u02BF\u02BB && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 >= this.startScrollingBottom && this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 >= this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 && this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 < this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 + this.startScrollingBottom - 3));
	}

	public static bool \u02B2\u02B4\u02B4\u02B2\u02C1\u02B9\u02B4\u02BE\u02BA\u02BD\u02B4;

	protected CHPlayer controllingPlayer;

	protected bool \u02BC\u02B7\u02C0\u02B6\u02C1\u02B9\u02BB\u02B2\u02BD\u02B3\u02B8;

	protected bool \u02B7\u02C0\u02BB\u02B6\u02B3\u02C0\u02B9\u02BF\u02B5\u02C0\u02B6;

	protected bool \u02BD\u02B5\u02BE\u02BC\u02B4\u02B6\u02B7\u02BF\u02B4\u02BF\u02C0;

	protected bool \u02BA\u02B8\u02B2\u02C1\u02BF\u02C0\u02BD\u02C0\u02B4\u02B4\u02B2;

	protected bool \u02B4\u02B7\u02B3\u02BF\u02B4\u02BF\u02B9\u02C1\u02B6\u02B2\u02C0;

	protected bool \u02C0\u02C1\u02B6\u02BF\u02BF\u02B2\u02B5\u02C0\u02BB\u02BA\u02C1;

	protected bool \u02B7\u02C1\u02B8\u02B8\u02B8\u02B4\u02BB\u02BF\u02BA\u02BB\u02BC;

	protected bool \u02B7\u02B9\u02B3\u02B7\u02B6\u02B7\u02B2\u02BB\u02B8\u02B7\u02B9;

	protected bool \u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF;

	public static bool HAVEFUN;

	protected string \u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;

	[HideInInspector]
	public bool isActive;

	protected int \u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;

	protected int \u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3;

	protected int \u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6;

	protected int \u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5;

	[SerializeField]
	protected int menuTopStart;

	[SerializeField]
	protected TextMeshProUGUI tipText;

	[SerializeField]
	[\u02BE\u02B2\u02B2\u02BA\u02BE\u02B7\u02BF\u02B3\u02BE\u02C1\u02BA]
	protected string[] menuStrings;

	[SerializeField]
	[\u02BE\u02B2\u02B2\u02BA\u02BE\u02B7\u02BF\u02B3\u02BE\u02C1\u02BA]
	protected string[] tipStrings;

	[SerializeField]
	protected Vector3 beginningTextPosition;

	[SerializeField]
	protected Vector3 textPositionDifference;

	[SerializeField]
	protected bool useUppercase;

	[SerializeField]
	protected TextMeshProUGUI[] textObjects;

	[SerializeField]
	protected Image[] backgroundObjects;

	[SerializeField]
	private bool allowWrapping;

	[SerializeField]
	private bool wrapToTopOnEnable;

	[SerializeField]
	private bool scrollWholeMenu;

	[SerializeField]
	protected bool disableControls;

	[SerializeField]
	private bool isProfileMenu;

	protected bool \u02B9\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02C0\u02B5\u02BF\u02BB;

	[SerializeField]
	protected bool allowMultiLanguage;

	[SerializeField]
	protected Color defaultColor;

	[SerializeField]
	protected Color highlightColor;

	[SerializeField]
	protected RectTransform selectionTransform;

	[SerializeField]
	protected bool enableSelectionWithoutProfiles;

	private Vector2 \u02C1\u02B3\u02B3\u02BD\u02BE\u02BF\u02B8\u02B6\u02C0\u02B7\u02C0;

	protected bool \u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = true;

	[SerializeField]
	private float longPressTime = 0.5f;

	[SerializeField]
	protected int startScrollingBottom;

	[SerializeField]
	protected int startScrollingTop;

	protected int \u02BA\u02BE\u02B7\u02BE\u02B3\u02C1\u02BC\u02B8\u02B7\u02C1\u02B6;

	protected Scrollbar \u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD;

	protected ScrollRect \u02BD\u02B5\u02BC\u02B8\u02B2\u02C0\u02B7\u02B8\u02B9\u02C0\u02B9;

	protected CHPlayer \u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8;

	private float \u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7;

	private float \u02B7\u02B9\u02BF\u02B5\u02B6\u02B5\u02B9\u02B8\u02B6\u02B2\u02B4;

	private float \u02BA\u02C1\u02BC\u02B9\u02BE\u02B4\u02C0\u02BE\u02B9\u02BA\u02BA = 0.026f;

	private float \u02BA\u02C0\u02B4\u02B5\u02BA\u02BE\u02BB\u02BD\u02B9\u02B6\u02B2 = 0.3f;

	private static int[] actionButtons = new int[] { 0, 1, 2, 3, 4 };
}
