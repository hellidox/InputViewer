using System;
using System.Collections.Generic;
using Rewired;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200007C RID: 124
public class BaseMenu : MonoBehaviour
{
	// Token: 0x060004C2 RID: 1218 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02BC\u02B7\u02BF\u02BD\u02B4\u02BE\u02C0\u02B4\u02BE\u02B7\u02B9()
	{
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x000085AF File Offset: 0x000067AF
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

	// Token: 0x060004C4 RID: 1220 RVA: 0x00032A14 File Offset: 0x00030C14
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

	// Token: 0x060004C5 RID: 1221 RVA: 0x00032A74 File Offset: 0x00030C74
	private bool \u02C0\u02B7\u02B3\u02BD\u02BB\u02B7\u02C1\u02B3\u02B6\u02BE\u02C1()
	{
		return this.startScrollingBottom <= 1 || ((this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 >= this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 || this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 < this.startScrollingBottom) && (this.\u02B9\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02C0\u02B5\u02BF\u02BB && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 >= this.startScrollingBottom && this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 >= this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 && this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 < this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 + this.startScrollingBottom - 5));
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00032AE8 File Offset: 0x00030CE8
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

	// Token: 0x060004C7 RID: 1223 RVA: 0x00032BA4 File Offset: 0x00030DA4
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

	// Token: 0x060004C8 RID: 1224 RVA: 0x000085E7 File Offset: 0x000067E7
	public virtual void \u02BF\u02B6\u02BB\u02B4\u02B9\u02BD\u02B9\u02BE\u02BE\u02BE\u02B4(byte \u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1)
	{
		switch (\u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1)
		{
		case 0:
			this.\u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3();
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

	// Token: 0x060004C9 RID: 1225 RVA: 0x00032C44 File Offset: 0x00030E44
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

	// Token: 0x060004CA RID: 1226 RVA: 0x00032D04 File Offset: 0x00030F04
	private void \u02C1\u02B4\u02B5\u02C1\u02B4\u02B3\u02BA\u02B2\u02BF\u02B6\u02BD(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8 = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;
		try
		{
			this.\u02B3\u02BA\u02BF\u02BB\u02BE\u02BE\u02B4\u02B7\u02BA\u02BB\u02B6(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7);
		}
		finally
		{
			this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8 = null;
		}
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x00032D3C File Offset: 0x00030F3C
	protected virtual void Update()
	{
		if (FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02BF\u02B7\u02BA\u02BC\u02B2\u02BA\u02B8\u02BF\u02BB\u02B3)
		{
			return;
		}
		if (!this.enableSelectionWithoutProfiles)
		{
			this.\u02B4\u02B9\u02BE\u02B7\u02BE\u02BB\u02BF\u02BC\u02B3\u02B5\u02B8(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02BE\u02BD\u02BE\u02B5\u02BA\u02C1\u02B7\u02BD\u02BD\u02B9\u02BC <= 0);
		}
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 == null)
		{
			if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE != null)
			{
				if (this.\u02B4\u02B5\u02BA\u02C0\u02C1\u02B7\u02BD\u02BD\u02B6\u02B7\u02C1(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE))
				{
					this.\u02C1\u02B4\u02B5\u02C1\u02B4\u02B3\u02BA\u02B2\u02BF\u02B6\u02BD(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE);
				}
			}
			else
			{
				for (int i = 0; i < 4; i++)
				{
					\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i];
					if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && (!u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD || this.isProfileMenu) && !this.disableControls && (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo == null || !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer) && this.\u02B4\u02B5\u02BA\u02C0\u02C1\u02B7\u02BD\u02BD\u02B6\u02B7\u02C1(u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B))
					{
						this.\u02C1\u02B4\u02B5\u02C1\u02B4\u02B3\u02BA\u02B2\u02BF\u02B6\u02BD(u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B);
					}
				}
			}
		}
		else if (this.\u02B4\u02B5\u02BA\u02C0\u02C1\u02B7\u02BD\u02BD\u02B6\u02B7\u02C1(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4))
		{
			this.\u02C1\u02B4\u02B5\u02C1\u02B4\u02B3\u02BA\u02B2\u02BF\u02B6\u02BD(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4);
		}
		if (this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF)
		{
			this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = false;
			this.\u02B2\u02BD\u02B6\u02BE\u02B4\u02BE\u02B9\u02B6\u02BD\u02B4\u02B7();
		}
		if (BaseMenu.\u02B6\u02B7\u02BD\u02BE\u02BB\u02BE\u02C0\u02C1\u02B7\u02B4\u02C0)
		{
			this.\u02B9\u02B3\u02B4\u02B3\u02B7\u02B5\u02C1\u02C0\u02BE\u02BC\u02B6();
		}
		this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 -= Time.unscaledDeltaTime;
		this.\u02B7\u02B9\u02BF\u02B5\u02B6\u02B5\u02B9\u02B8\u02B6\u02B2\u02B4 -= Time.unscaledDeltaTime;
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060004CC RID: 1228 RVA: 0x0000861B File Offset: 0x0000681B
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

	// Token: 0x060004CE RID: 1230 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02B8\u02BF\u02B4\u02B2\u02BE\u02B5\u02BC\u02B2\u02B5\u02BD\u02B8()
	{
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00032E7C File Offset: 0x0003107C
	protected void \u02B7\u02B9\u02BE\u02B2\u02B3\u02C0\u02BF\u02BB\u02BD\u02BF\u02BC()
	{
		this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = (this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = this.menuTopStart);
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = true;
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02BA\u02C0\u02C1\u02B2\u02B2\u02B9\u02B2\u02BF\u02B8\u02BE\u02BC()
	{
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00032EA8 File Offset: 0x000310A8
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
			this.tipText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.tipStrings[this.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC]);
		}
		else
		{
			this.tipText.text = this.tipStrings[this.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC];
		}
		this.tipText.enabled = false;
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02BA\u02B4\u02BC\u02B6\u02BC\u02B7\u02BD\u02B3\u02BA\u02BE\u02C0()
	{
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00008654 File Offset: 0x00006854
	public int \u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC
	{
		get
		{
			return this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 + this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3;
		}
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x0000861B File Offset: 0x0000681B
	protected string \u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7()
	{
		if (this.menuStrings.Length != 0)
		{
			return this.menuStrings[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 + this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7];
		}
		return null;
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02C0\u02BD\u02BD\u02B4\u02B5\u02B4\u02B6\u02B8\u02BD\u02B8\u02BB()
	{
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x00032F4C File Offset: 0x0003114C
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
				text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.menuStrings[num]);
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

	// Token: 0x060004D7 RID: 1239 RVA: 0x00033168 File Offset: 0x00031368
	protected void \u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1()
	{
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 == null)
		{
			using (List<\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6>.Enumerator enumerator = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = enumerator.Current;
					if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && (!u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD || this.isProfileMenu) && !this.disableControls && (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo == null || !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer))
					{
						u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BD\u02B8\u02BD\u02B6\u02B4\u02B6\u02C1\u02B9\u02BD\u02BC\u02B4 = true;
					}
				}
				return;
			}
		}
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BD\u02B8\u02BD\u02B6\u02B4\u02B6\u02C1\u02B9\u02BD\u02BC\u02B4 = true;
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x00008663 File Offset: 0x00006863
	public void \u02B4\u02B9\u02BE\u02B7\u02BE\u02BB\u02BF\u02BC\u02B3\u02B5\u02B8(bool \u02BD\u02BB\u02BD\u02B6\u02B5\u02C1\u02B8\u02B5\u02B3\u02B2\u02B4)
	{
		if (\u02BD\u02BB\u02BD\u02B6\u02B5\u02C1\u02B8\u02B5\u02B3\u02B2\u02B4 != this.disableControls)
		{
			this.disableControls = \u02BD\u02BB\u02BD\u02B6\u02B5\u02C1\u02B8\u02B5\u02B3\u02B2\u02B4;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		}
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x00033208 File Offset: 0x00031408
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
			this.tipText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.tipStrings[this.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC]);
		}
		else
		{
			this.tipText.text = this.tipStrings[this.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC];
		}
		this.tipText.enabled = true;
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x0000867B File Offset: 0x0000687B
	protected virtual void OnDisable()
	{
		if (this.wrapToTopOnEnable)
		{
			this.\u02B7\u02B9\u02BE\u02B2\u02B3\u02C0\u02BF\u02BB\u02BD\u02BF\u02BC();
		}
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x000332AC File Offset: 0x000314AC
	private bool \u02C0\u02B9\u02BE\u02B2\u02C1\u02B7\u02BF\u02B9\u02B8\u02BE\u02BD()
	{
		return this.startScrollingBottom > 1 && (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 >= this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 || this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 < this.startScrollingBottom) && (!this.\u02B9\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02C0\u02B5\u02BF\u02BB || this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 < this.startScrollingBottom || this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 < this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 || this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 >= this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 + this.startScrollingBottom - 1);
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02BA\u02BB\u02B7\u02B6\u02B2\u02B2\u02B8\u02BB\u02B2\u02BB\u02B7()
	{
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02BB\u02B3\u02BF\u02BC\u02C1\u02BC\u02BC\u02C1\u02C0\u02B5\u02BA()
	{
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x00033320 File Offset: 0x00031520
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
			GameAudioManager.PlaySound((SoundID)117);
		}
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x00008692 File Offset: 0x00006892
	public virtual void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		this.\u02B7\u02C0\u02BB\u02B6\u02B3\u02C0\u02B9\u02BF\u02B5\u02C0\u02B6 = true;
		this.\u02B7\u02C1\u02BA\u02BA\u02B2\u02B5\u02B7\u02BD\u02BC\u02C1\u02BE(true);
		this.\u02C0\u02C1\u02B6\u02BF\u02BF\u02B2\u02B5\u02C0\u02BB\u02BA\u02C1 = true;
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x00033410 File Offset: 0x00031610
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

	// Token: 0x060004E1 RID: 1249 RVA: 0x000085E7 File Offset: 0x000067E7
	public virtual void \u02B8\u02B9\u02C0\u02BA\u02C0\u02C0\u02B7\u02BE\u02B5\u02B2\u02B7(byte \u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1)
	{
		switch (\u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1)
		{
		case 0:
			this.\u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3();
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

	// Token: 0x060004E2 RID: 1250 RVA: 0x000086A9 File Offset: 0x000068A9
	protected virtual void OnEnable()
	{
		if (this.tipText)
		{
			this.tipText.enabled = true;
			this.\u02B9\u02BB\u02BE\u02BD\u02B3\u02C1\u02BF\u02B8\u02BD\u02B5\u02B6();
		}
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = true;
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = true;
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x0003347C File Offset: 0x0003167C
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

	// Token: 0x060004E4 RID: 1252 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02B2\u02B2\u02B9\u02B2\u02B8\u02BB\u02B7\u02B6\u02B3\u02C1\u02B5()
	{
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02C1\u02B6\u02BD\u02BC\u02BC\u02B3\u02BF\u02BF\u02C0\u02C1\u02BC()
	{
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x000334F8 File Offset: 0x000316F8
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

	// Token: 0x060004E7 RID: 1255 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02BF\u02BB\u02BC\u02BC\u02B8\u02C1\u02B9\u02BC\u02B6\u02BA\u02B6()
	{
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00033560 File Offset: 0x00031760
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

	// Token: 0x060004E9 RID: 1257 RVA: 0x000086D8 File Offset: 0x000068D8
	protected virtual void \u02B2\u02BD\u02B6\u02BE\u02B4\u02BE\u02B9\u02B6\u02BD\u02B4\u02B7()
	{
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		this.\u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2();
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x000086E6 File Offset: 0x000068E6
	public virtual void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		this.\u02BC\u02B7\u02C0\u02B6\u02C1\u02B9\u02BB\u02B2\u02BD\u02B3\u02B8 = true;
		this.\u02BE\u02B4\u02BD\u02B6\u02B5\u02B7\u02BB\u02BE\u02B3\u02B5\u02B9(true);
		this.\u02B4\u02B7\u02B3\u02BF\u02B4\u02BF\u02B9\u02C1\u02B6\u02B2\u02C0 = true;
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x000086FD File Offset: 0x000068FD
	public void \u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(string \u02BC\u02B4\u02BB\u02B6\u02B2\u02BE\u02BA\u02C0\u02B8\u02BE\u02B7)
	{
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(Array.IndexOf<string>(this.menuStrings, \u02BC\u02B4\u02BB\u02B6\u02B2\u02BE\u02BA\u02C0\u02B8\u02BE\u02B7), true);
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x000335EC File Offset: 0x000317EC
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
			GameAudioManager.PlaySound(SoundID.UIScrollDown);
		}
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x00008742 File Offset: 0x00006942
	public virtual void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		this.\u02BD\u02B5\u02BE\u02BC\u02B4\u02B6\u02B7\u02BF\u02B4\u02BF\u02C0 = true;
		GameAudioManager.PlaySound(SoundID.UIConfirm);
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x00008752 File Offset: 0x00006952
	protected bool \u02C0\u02B9\u02BE\u02BF\u02BA\u02BE\u02B9\u02B4\u02BE\u02BA\u02B5()
	{
		return this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 == this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 - 1;
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x00008764 File Offset: 0x00006964
	public virtual void \u02B3\u02B3\u02B9\u02BC\u02B7\u02BF\u02BA\u02B5\u02BB\u02BE\u02B8()
	{
		this.\u02B4\u02B7\u02B3\u02BF\u02B4\u02BF\u02B9\u02C1\u02B6\u02B2\u02C0 = false;
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x0000876D File Offset: 0x0000696D
	public virtual void \u02BF\u02B5\u02BD\u02B6\u02C1\u02BB\u02BD\u02BE\u02B5\u02B2\u02BD()
	{
		this.\u02C0\u02C1\u02B6\u02BF\u02BF\u02B2\u02B5\u02C0\u02BB\u02BA\u02C1 = false;
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00008776 File Offset: 0x00006976
	private bool \u02B6\u02C0\u02BD\u02B7\u02BA\u02BA\u02BC\u02B6\u02B3\u02B2\u02C0()
	{
		return this.startScrollingTop > 0 && (this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 > 0 && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 <= this.startScrollingTop);
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02B5\u02BF\u02B2\u02B4\u02BB\u02B5\u02B9\u02B4\u02BC\u02BB\u02C1()
	{
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x0000879D File Offset: 0x0000699D
	public virtual void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		this.\u02BA\u02B8\u02B2\u02C1\u02BF\u02C0\u02BD\u02C0\u02B4\u02B4\u02B2 = true;
		GameAudioManager.PlaySound(SoundID.UICancel);
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x000336DC File Offset: 0x000318DC
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
			GameAudioManager.PlaySound(SoundID.UIScrollUp);
		}
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x000337BC File Offset: 0x000319BC
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

	// Token: 0x060004F7 RID: 1271 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02BA\u02BC\u02C1\u02BE\u02B6\u02B4\u02B9\u02B2\u02B3\u02BD\u02B4()
	{
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x0003381C File Offset: 0x00031A1C
	protected virtual void \u02B3\u02BA\u02BF\u02BB\u02BE\u02BE\u02B4\u02B7\u02BA\u02BB\u02B6(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		if (!\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD || (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD && !this.isProfileMenu) || this.disableControls || (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.playerInfo != null && \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.playerInfo.isRemotePlayer))
		{
			return;
		}
		if (ColorProfileEditor.\u02BF\u02B3\u02B6\u02B5\u02BB\u02B7\u02BE\u02BF\u02C1\u02BA\u02BF() || SongPathsManager.\u02BF\u02B3\u02B6\u02B5\u02BB\u02B7\u02BE\u02BF\u02C1\u02BA\u02BF())
		{
			return;
		}
		this.\u02B7\u02C0\u02BB\u02B6\u02B3\u02C0\u02B9\u02BF\u02B5\u02C0\u02B6 = (this.\u02BC\u02B7\u02C0\u02B6\u02C1\u02B9\u02BB\u02B2\u02BD\u02B3\u02B8 = false);
		if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonRepeating(32))
		{
			this.\u02BB\u02B3\u02BF\u02BC\u02C1\u02BC\u02BC\u02C1\u02C0\u02B5\u02BA();
		}
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonRepeating(31))
		{
			this.\u02BD\u02B9\u02BE\u02BB\u02B9\u02BA\u02B5\u02BC\u02BE\u02C1\u02B2();
		}
		bool flag = false;
		if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButton(0))
		{
			flag = true;
		}
		bool flag2 = true;
		if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.playerInfo != null)
		{
			flag2 = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
		}
		if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonDown(0))
		{
			this.\u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3();
		}
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonTimedPressDown(0, this.longPressTime))
		{
			this.\u02B2\u02B2\u02B9\u02B2\u02B8\u02BB\u02B7\u02B6\u02B3\u02C1\u02B5();
		}
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonTimedPressDown(1, this.longPressTime))
		{
			this.\u02B8\u02B6\u02BB\u02C0\u02BA\u02B2\u02BC\u02BF\u02BF\u02BC\u02C1();
		}
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonUp(0))
		{
			this.\u02C1\u02B6\u02BD\u02BC\u02BC\u02B3\u02BF\u02BF\u02C0\u02C1\u02BC();
		}
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonDown(1))
		{
			this.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		}
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonDown(2))
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
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonUp(2))
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
		else if (!flag2 && \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonTimedPressDown(2, this.longPressTime))
		{
			this.\u02BA\u02BB\u02B7\u02B6\u02B2\u02B2\u02B8\u02BB\u02B2\u02BB\u02B7();
		}
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonDown(3))
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
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonUp(3))
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
		else if (!flag2 && \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonTimedPressDown(3, this.longPressTime))
		{
			this.\u02B5\u02BF\u02B2\u02B4\u02BB\u02B5\u02B9\u02B4\u02BC\u02BB\u02C1();
		}
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonDown(4))
		{
			this.\u02BA\u02B4\u02BC\u02B6\u02BC\u02B7\u02BD\u02B3\u02BA\u02BE\u02C0();
		}
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonUp(4))
		{
			this.\u02B6\u02BE\u02B5\u02C1\u02B6\u02B6\u02B5\u02B3\u02BE\u02B4\u02B7();
		}
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonTimedPressDown(4, this.longPressTime))
		{
			this.\u02BA\u02C0\u02C1\u02B2\u02B2\u02B9\u02B2\u02BF\u02B8\u02BE\u02BC();
		}
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonDown(6))
		{
			this.\u02BC\u02B7\u02BF\u02BD\u02B4\u02BE\u02C0\u02B4\u02BE\u02B7\u02B9();
		}
		else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonDown(16))
		{
			this.\u02B7\u02B8\u02B5\u02B5\u02BF\u02C0\u02BA\u02BA\u02B3\u02BE\u02C0();
		}
		if (flag || !\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
		{
			return;
		}
		if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.playerInfo != null && \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.playerInfo.leftyFlip && \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.playerInfo.instrument != Instrument.Drums && \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.playerInfo.instrument != Instrument.ProDrums)
		{
			if (this.\u02C1\u02B4\u02BE\u02B2\u02BE\u02B4\u02BA\u02B5\u02B5\u02C0\u02C1(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer, 5))
			{
				this.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			}
			if (this.\u02C1\u02B4\u02BE\u02B2\u02BE\u02B4\u02BA\u02B5\u02B5\u02C0\u02C1(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer, 14))
			{
				this.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			}
			if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonUp(5))
			{
				this.\u02BF\u02B5\u02BD\u02B6\u02C1\u02BB\u02BD\u02BE\u02B5\u02B2\u02BD();
			}
			if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonUp(14))
			{
				this.\u02B3\u02B3\u02B9\u02BC\u02B7\u02BF\u02BA\u02B5\u02BB\u02BE\u02B8();
				return;
			}
		}
		else
		{
			if (this.\u02C1\u02B4\u02BE\u02B2\u02BE\u02B4\u02BA\u02B5\u02B5\u02C0\u02C1(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer, 5))
			{
				this.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			}
			if (this.\u02C1\u02B4\u02BE\u02B2\u02BE\u02B4\u02BA\u02B5\u02B5\u02C0\u02C1(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer, 14))
			{
				this.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			}
			if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonUp(5))
			{
				this.\u02B3\u02B3\u02B9\u02BC\u02B7\u02BF\u02BA\u02B5\u02BB\u02BE\u02B8();
			}
			if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonUp(14))
			{
				this.\u02BF\u02B5\u02BD\u02B6\u02C1\u02BB\u02BD\u02BE\u02B5\u02B2\u02BD();
			}
		}
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x000087AD File Offset: 0x000069AD
	public void \u02C1\u02BB\u02B8\u02B9\u02C1\u02BD\u02BF\u02BB\u02B4\u02BF\u02BD(TextMeshProUGUI[] \u02C0\u02BE\u02B5\u02BE\u02BC\u02BC\u02BF\u02BE\u02B6\u02B6\u02BD)
	{
		this.textObjects = \u02C0\u02BE\u02B5\u02BE\u02BC\u02BC\u02BF\u02BE\u02B6\u02B6\u02BD;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x000087BC File Offset: 0x000069BC
	public void \u02B8\u02BE\u02BD\u02BB\u02B2\u02B6\u02B3\u02BB\u02BB\u02C0\u02B8(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x000087C5 File Offset: 0x000069C5
	protected virtual void Start()
	{
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = true;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00033B9C File Offset: 0x00031D9C
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

	// Token: 0x060004FD RID: 1277 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02BD\u02B9\u02BE\u02BB\u02B9\u02BA\u02B5\u02BC\u02BE\u02C1\u02B2()
	{
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02BF\u02BD\u02B6\u02B2\u02B6\u02BE\u02B5\u02BF\u02BA\u02B8\u02BD()
	{
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x00033C20 File Offset: 0x00031E20
	public void \u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA()
	{
		for (int i = 0; i < this.textObjects.Length; i++)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.menuStrings[i]);
		}
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02B6\u02BE\u02B5\u02C1\u02B6\u02B6\u02B5\u02B3\u02BE\u02B4\u02B7()
	{
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x00033C60 File Offset: 0x00031E60
	public virtual void \u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2()
	{
		if (!this.selectionTransform)
		{
			return;
		}
		this.selectionTransform.anchoredPosition = new Vector2(this.\u02C1\u02B3\u02B3\u02BD\u02BE\u02BF\u02B8\u02B6\u02C0\u02B7\u02C0.x, this.\u02C1\u02B3\u02B3\u02BD\u02BE\u02BF\u02B8\u02B6\u02C0\u02B7\u02C0.y + -this.textPositionDifference.y * (float)this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3);
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = false;
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02B8\u02B6\u02BB\u02C0\u02BA\u02B2\u02BC\u02BF\u02BF\u02BC\u02C1()
	{
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x00005F91 File Offset: 0x00004191
	public virtual void \u02B7\u02B8\u02B5\u02B5\u02BF\u02C0\u02BA\u02BA\u02B3\u02BE\u02C0()
	{
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x000087DA File Offset: 0x000069DA
	protected bool \u02B2\u02B2\u02BD\u02B2\u02B3\u02B8\u02BC\u02BB\u02C0\u02B7\u02B9()
	{
		return this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 == this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6;
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x000087EA File Offset: 0x000069EA
	protected bool \u02C0\u02BA\u02BE\u02B6\u02C1\u02B4\u02B5\u02B3\u02BC\u02B6\u02B2()
	{
		return this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 == this.menuTopStart;
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x00033CC0 File Offset: 0x00031EC0
	protected virtual bool \u02B4\u02B5\u02BA\u02C0\u02C1\u02B7\u02BD\u02BD\u02B6\u02B7\u02C1(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		if (!\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02BD\u02B8\u02BD\u02B6\u02B4\u02B6\u02C1\u02B9\u02BD\u02BC\u02B4)
		{
			return true;
		}
		bool flag = false;
		foreach (int num in BaseMenu.\u02BD\u02B6\u02BA\u02B3\u02B4\u02BB\u02B7\u02B3\u02BA\u02B5\u02B9)
		{
			if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButton(num) || \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonUp(num) || \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonDown(num))
			{
				flag = true;
			}
		}
		if (flag)
		{
			return false;
		}
		\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02BD\u02B8\u02BD\u02B6\u02B4\u02B6\u02C1\u02B9\u02BD\u02BC\u02B4 = false;
		return true;
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x00033D2C File Offset: 0x00031F2C
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

	// Token: 0x06000508 RID: 1288 RVA: 0x000087FA File Offset: 0x000069FA
	protected bool \u02C1\u02BD\u02BD\u02BC\u02B9\u02B6\u02C0\u02B3\u02BD\u02B5\u02B4()
	{
		return this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 <= this.menuTopStart;
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x00033D8C File Offset: 0x00031F8C
	private bool \u02B2\u02B5\u02B4\u02B4\u02BC\u02B3\u02BC\u02C1\u02B2\u02BE\u02B3()
	{
		return this.startScrollingBottom > 0 && ((this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 < this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 >= this.startScrollingBottom) || (this.\u02B9\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02C0\u02B5\u02BF\u02BB && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 >= this.startScrollingBottom && this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 >= this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 && this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 < this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 + this.startScrollingBottom - 3));
	}

	// Token: 0x040003AF RID: 943
	public static bool \u02B2\u02B4\u02B4\u02B2\u02C1\u02B9\u02B4\u02BE\u02BA\u02BD\u02B4;

	// Token: 0x040003B0 RID: 944
	protected \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4;

	// Token: 0x040003B1 RID: 945
	protected bool \u02BC\u02B7\u02C0\u02B6\u02C1\u02B9\u02BB\u02B2\u02BD\u02B3\u02B8;

	// Token: 0x040003B2 RID: 946
	protected bool \u02B7\u02C0\u02BB\u02B6\u02B3\u02C0\u02B9\u02BF\u02B5\u02C0\u02B6;

	// Token: 0x040003B3 RID: 947
	protected bool \u02BD\u02B5\u02BE\u02BC\u02B4\u02B6\u02B7\u02BF\u02B4\u02BF\u02C0;

	// Token: 0x040003B4 RID: 948
	protected bool \u02BA\u02B8\u02B2\u02C1\u02BF\u02C0\u02BD\u02C0\u02B4\u02B4\u02B2;

	// Token: 0x040003B5 RID: 949
	protected bool \u02B4\u02B7\u02B3\u02BF\u02B4\u02BF\u02B9\u02C1\u02B6\u02B2\u02C0;

	// Token: 0x040003B6 RID: 950
	protected bool \u02C0\u02C1\u02B6\u02BF\u02BF\u02B2\u02B5\u02C0\u02BB\u02BA\u02C1;

	// Token: 0x040003B7 RID: 951
	protected bool \u02B7\u02C1\u02B8\u02B8\u02B8\u02B4\u02BB\u02BF\u02BA\u02BB\u02BC;

	// Token: 0x040003B8 RID: 952
	protected bool \u02B7\u02B9\u02B3\u02B7\u02B6\u02B7\u02B2\u02BB\u02B8\u02B7\u02B9;

	// Token: 0x040003B9 RID: 953
	protected bool \u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF;

	// Token: 0x040003BA RID: 954
	public static bool \u02B6\u02B7\u02BD\u02BE\u02BB\u02BE\u02C0\u02C1\u02B7\u02B4\u02C0;

	// Token: 0x040003BB RID: 955
	protected string \u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;

	// Token: 0x040003BC RID: 956
	[HideInInspector]
	public bool \u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8;

	// Token: 0x040003BD RID: 957
	protected int \u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;

	// Token: 0x040003BE RID: 958
	protected int \u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3;

	// Token: 0x040003BF RID: 959
	protected int \u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6;

	// Token: 0x040003C0 RID: 960
	protected int \u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5;

	// Token: 0x040003C1 RID: 961
	[SerializeField]
	protected int menuTopStart;

	// Token: 0x040003C2 RID: 962
	[SerializeField]
	protected TextMeshProUGUI tipText;

	// Token: 0x040003C3 RID: 963
	[SerializeField]
	[\u02BE\u02B2\u02B2\u02BA\u02BE\u02B7\u02BF\u02B3\u02BE\u02C1\u02BA]
	protected string[] menuStrings;

	// Token: 0x040003C4 RID: 964
	[SerializeField]
	[\u02BE\u02B2\u02B2\u02BA\u02BE\u02B7\u02BF\u02B3\u02BE\u02C1\u02BA]
	protected string[] tipStrings;

	// Token: 0x040003C5 RID: 965
	[SerializeField]
	protected Vector3 beginningTextPosition;

	// Token: 0x040003C6 RID: 966
	[SerializeField]
	protected Vector3 textPositionDifference;

	// Token: 0x040003C7 RID: 967
	[SerializeField]
	protected bool useUppercase;

	// Token: 0x040003C8 RID: 968
	[SerializeField]
	protected TextMeshProUGUI[] textObjects;

	// Token: 0x040003C9 RID: 969
	[SerializeField]
	protected Image[] backgroundObjects;

	// Token: 0x040003CA RID: 970
	[SerializeField]
	private bool allowWrapping;

	// Token: 0x040003CB RID: 971
	[SerializeField]
	private bool wrapToTopOnEnable;

	// Token: 0x040003CC RID: 972
	[SerializeField]
	private bool scrollWholeMenu;

	// Token: 0x040003CD RID: 973
	[SerializeField]
	protected bool disableControls;

	// Token: 0x040003CE RID: 974
	[SerializeField]
	private bool isProfileMenu;

	// Token: 0x040003CF RID: 975
	protected bool \u02B9\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02C0\u02B5\u02BF\u02BB;

	// Token: 0x040003D0 RID: 976
	[SerializeField]
	protected bool allowMultiLanguage;

	// Token: 0x040003D1 RID: 977
	[SerializeField]
	protected Color defaultColor;

	// Token: 0x040003D2 RID: 978
	[SerializeField]
	protected Color highlightColor;

	// Token: 0x040003D3 RID: 979
	[SerializeField]
	protected RectTransform selectionTransform;

	// Token: 0x040003D4 RID: 980
	[SerializeField]
	protected bool enableSelectionWithoutProfiles;

	// Token: 0x040003D5 RID: 981
	private Vector2 \u02C1\u02B3\u02B3\u02BD\u02BE\u02BF\u02B8\u02B6\u02C0\u02B7\u02C0;

	// Token: 0x040003D6 RID: 982
	protected bool \u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = true;

	// Token: 0x040003D7 RID: 983
	[SerializeField]
	private float longPressTime = 0.5f;

	// Token: 0x040003D8 RID: 984
	[SerializeField]
	protected int startScrollingBottom;

	// Token: 0x040003D9 RID: 985
	[SerializeField]
	protected int startScrollingTop;

	// Token: 0x040003DA RID: 986
	protected int \u02BA\u02BE\u02B7\u02BE\u02B3\u02C1\u02BC\u02B8\u02B7\u02C1\u02B6;

	// Token: 0x040003DB RID: 987
	protected Scrollbar \u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD;

	// Token: 0x040003DC RID: 988
	protected ScrollRect \u02BD\u02B5\u02BC\u02B8\u02B2\u02C0\u02B7\u02B8\u02B9\u02C0\u02B9;

	// Token: 0x040003DD RID: 989
	protected \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8;

	// Token: 0x040003DE RID: 990
	private float \u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7;

	// Token: 0x040003DF RID: 991
	private float \u02B7\u02B9\u02BF\u02B5\u02B6\u02B5\u02B9\u02B8\u02B6\u02B2\u02B4;

	// Token: 0x040003E0 RID: 992
	private float \u02BA\u02C1\u02BC\u02B9\u02BE\u02B4\u02C0\u02BE\u02B9\u02BA\u02BA = 0.026f;

	// Token: 0x040003E1 RID: 993
	private float \u02BA\u02C0\u02B4\u02B5\u02BA\u02BE\u02BB\u02BD\u02B9\u02B6\u02B2 = 0.3f;

	// Token: 0x040003E2 RID: 994
	private static int[] \u02BD\u02B6\u02BA\u02B3\u02B4\u02BB\u02B7\u02B3\u02BA\u02B5\u02B9 = new int[] { 0, 1, 2, 3, 4 };
}
