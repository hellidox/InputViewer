using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StrikeCore;
using TMPro;
using UnityEngine;

// Token: 0x0200015B RID: 347
public abstract class BasePlayer : MonoBehaviour
{
	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06000F34 RID: 3892 RVA: 0x0000E44E File Offset: 0x0000C64E
	public bool \u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9
	{
		get
		{
			return this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF && SettingsController.\u02C1\u02BF\u02BC\u02B4\u02BE\u02B7\u02BD\u02BC\u02B5\u02BC\u02B7;
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x06000F35 RID: 3893 RVA: 0x0000E464 File Offset: 0x0000C664
	public int \u02B9\u02B8\u02B7\u02BA\u02B6\u02BA\u02B4\u02B9\u02B6\u02BF\u02C1
	{
		get
		{
			return this.\u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7;
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x06000F36 RID: 3894 RVA: 0x0000E46C File Offset: 0x0000C66C
	public int \u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5
	{
		get
		{
			return this.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 + this.\u02C1\u02B4\u02BB\u02B3\u02B3\u02BB\u02C0\u02B4\u02C1\u02BB\u02BE;
		}
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x06000F37 RID: 3895 RVA: 0x0000E47B File Offset: 0x0000C67B
	public int ghostCounter
	{
		get
		{
			return this._ghosts;
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06000F38 RID: 3896 RVA: 0x0000E483 File Offset: 0x0000C683
	public int \u02BB\u02BD\u02B5\u02B2\u02BF\u02B8\u02C1\u02B3\u02B4\u02B3\u02B7
	{
		get
		{
			return this.\u02B2\u02C0\u02B5\u02BB\u02BF\u02B4\u02B9\u02B5\u02BF\u02BC\u02BB + this.\u02B4\u02C1\u02BF\u02B7\u02B9\u02C0\u02C0\u02B2\u02C0\u02B9\u02C0;
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06000F39 RID: 3897 RVA: 0x0000E492 File Offset: 0x0000C692
	public int \u02B4\u02BB\u02BA\u02BA\u02BB\u02B7\u02C0\u02BA\u02BF\u02B9\u02C1
	{
		get
		{
			return this.\u02B3\u02B9\u02B8\u02BF\u02C1\u02B9\u02B2\u02BC\u02B5\u02BB\u02BB + this.\u02B9\u02B2\u02BF\u02BD\u02B3\u02B7\u02BF\u02BA\u02BD\u02B9\u02B5;
		}
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x00080484 File Offset: 0x0007E684
	protected void \u02BD\u02B8\u02B2\u02BD\u02B2\u02BF\u02BB\u02C1\u02BC\u02B7\u02B6()
	{
		\u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7[] componentsInChildren = base.GetComponentsInChildren<\u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6 = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6;
		}
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x000804B8 File Offset: 0x0007E6B8
	protected virtual void Awake()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 == null)
		{
			return;
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			this.spBar.gameObject.SetActive(false);
			this.healthContainer.gameObject.SetActive(false);
			this.neckController.\u02BF\u02B9\u02B2\u02B2\u02BF\u02B2\u02BA\u02B4\u02BB\u02B5\u02C1();
			this.\u02BD\u02B2\u02B9\u02B8\u02C0\u02B4\u02BF\u02BF\u02B7\u02BF\u02B3 = 0f;
		}
		else if (!SettingsController.\u02BB\u02C0\u02B7\u02B8\u02B3\u02BE\u02B7\u02BB\u02BA\u02B8\u02BA && !CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			GameMode u02B6_u02B9_u02B5_u02BA_u02BD_u02B9_u02BD_u02BC_u02B9_u02B3_u02C = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1;
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 != GameMode.Versus || GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.transform.Find("PlayerOverlays/Versus").gameObject.SetActive(false);
		}
		this.\u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = this;
		this._GameManager = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.beatlines = base.GetComponent<BeatRenderer>();
		this.\u02B4\u02B4\u02BF\u02B5\u02B4\u02B6\u02BA\u02B7\u02B2\u02B9\u02C1 = this.\u02B2\u02BE\u02BE\u02B8\u02B6\u02BE\u02BA\u02BA\u02B5\u02B3\u02BC;
		this.\u02B8\u02B2\u02B4\u02BF\u02C0\u02B8\u02C0\u02BA\u02B9\u02B2\u02B7 = -this.\u02B2\u02BE\u02BE\u02B8\u02B6\u02BE\u02BA\u02BA\u02B5\u02B3\u02BC;
		this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF = this.\u02B2\u02BE\u02BE\u02B8\u02B6\u02BE\u02BA\u02BA\u02B5\u02B3\u02BC * 2f;
		this.\u02B3\u02BC\u02B4\u02B8\u02BB\u02B8\u02B2\u02C0\u02C0\u02B3\u02C0 = this.playerStuff.playerInfo.HasModifier(Modifier.NoFretGhosting);
		this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB = this.playerStuff.playerInfo.HasModifier(Modifier.StrumlessHopos);
		this.\u02BD\u02B8\u02B6\u02B2\u02B8\u02B6\u02BD\u02C0\u02BD\u02B8\u02BB = this.playerStuff.playerInfo.HasModifier(Modifier.DroplessSustains);
		this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8 = this.playerStuff.playerInfo.HasModifier(Modifier.PrecisionMode);
		this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 = this.playerStuff.playerInfo.HasModifier(Modifier.DrunkMode);
		this.\u02BF\u02C1\u02BF\u02BE\u02C1\u02B2\u02BC\u02BE\u02B3\u02BB\u02B8 = this.playerStuff.playerInfo.HasModifier(Modifier.AutoStrum);
		this.\u02BB\u02BD\u02C0\u02B5\u02B8\u02B3\u02BD\u02B6\u02B7\u02BB\u02B7 = this.playerStuff.playerInfo.HasModifier(Modifier.BrutalMode);
		this.\u02B5\u02C1\u02BA\u02B9\u02B6\u02B7\u02B9\u02BC\u02B7\u02BD\u02B4 = this.playerStuff.playerInfo.HasModifier(Modifier.AllOpens);
		if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 || this.\u02BF\u02C1\u02BF\u02BE\u02C1\u02B2\u02BC\u02BE\u02B3\u02BB\u02B8)
		{
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA = \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.Modifier;
		}
		else
		{
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA = \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.None;
		}
		if (this.\u02BB\u02BD\u02C0\u02B5\u02B8\u02B3\u02BD\u02B6\u02B7\u02BB\u02B7)
		{
			this.\u02BC\u02BD\u02BF\u02BA\u02B8\u02B5\u02B3\u02B8\u02BE\u02C0\u02BC.\u02BD\u02B6\u02B3\u02B3\u02BC\u02B2\u02B3\u02B3\u02BB\u02B6\u02BB();
		}
		this.\u02B8\u02B5\u02B8\u02BF\u02BE\u02BD\u02BB\u02BD\u02BB\u02BC\u02B6 = new Note[20];
		this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6 = new \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9();
		if (this.playerStuff.playerInfo.colorProfileName == "Random" && !CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.playerStuff.playerInfo.\u02B4\u02BF\u02B9\u02BF\u02B3\u02B9\u02B9\u02B6\u02B5\u02BF\u02BB();
		}
		this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.InitializeColorSettings(this.playerStuff.playerInfo.colorSettings);
		this.\u02BD\u02B8\u02B2\u02BD\u02B2\u02BF\u02BB\u02C1\u02BC\u02B7\u02B6();
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x00080744 File Offset: 0x0007E944
	protected virtual void \u02B4\u02C0\u02BF\u02BA\u02BD\u02BA\u02B3\u02B8\u02B7\u02B7\u02BA()
	{
		float num = ((GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA != \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.None) ? 0f : 1f);
		DesaturateSprite[] u02B5_u02BE_u02B5_u02B8_u02B8_u02B4_u02BF_u02BC_u02B4_u02B8_u02B = this.\u02B5\u02BE\u02B5\u02B8\u02B8\u02B4\u02BF\u02BC\u02B4\u02B8\u02B2;
		for (int i = 0; i < u02B5_u02BE_u02B5_u02B8_u02B8_u02B4_u02BF_u02BC_u02B4_u02B8_u02B.Length; i++)
		{
			u02B5_u02BE_u02B5_u02B8_u02B8_u02B4_u02BF_u02BC_u02B4_u02B8_u02B[i].\u02C0\u02B8\u02C0\u02BC\u02C0\u02B9\u02B5\u02B2\u02B4\u02B3\u02BD(num);
		}
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x00080788 File Offset: 0x0007E988
	protected virtual void Start()
	{
		this.\u02B5\u02BE\u02B5\u02B8\u02B8\u02B4\u02BF\u02BC\u02B4\u02B8\u02B2 = this.FCIndicator.GetComponentsInChildren<DesaturateSprite>();
		this.\u02B4\u02C0\u02BF\u02BA\u02BD\u02BA\u02B3\u02B8\u02B7\u02B7\u02BA();
		if (this.playerStuff.playerInfo.leftyFlip)
		{
			this.neckController.\u02BF\u02B2\u02BE\u02BE\u02BF\u02B4\u02BC\u02C0\u02B3\u02C0\u02C1();
		}
		if (this.playerStuff.playerInfo.HasModifier(Modifier.LightsOut))
		{
			this.camera.enabled = false;
			GameObject.Find("HUD").gameObject.SetActive(false);
		}
		else
		{
			if (this.playerStuff.playerInfo.HasModifier(Modifier.ModPrep))
			{
				this.neckController.\u02B2\u02BF\u02BB\u02BC\u02B8\u02B7\u02B9\u02C1\u02B8\u02BE\u02BA();
				this.neckController.HideFretStrings();
				this.highwayObjects[0].SetActive(false);
				this.highwayObjects[1].SetActive(false);
			}
			if (this.playerStuff.playerInfo.HasModifier(Modifier.ModLite))
			{
				this.neckController.HideFretStrings();
			}
			if (this.playerStuff.playerInfo.HasModifier(Modifier.ModFull))
			{
				this.neckController.HideFretStrings();
				this.highwayObjects[0].SetActive(false);
				this.highwayObjects[1].SetActive(false);
			}
		}
		this.playerNameTextBox.text = this.playerStuff.playerInfo.playerName.CurrentValueDisplay;
		if (this.playerStuff.playerInfo.displayName || cUtilityClass.showJudgementsUnderFretboard || this.playerStuff.playerInfo.isRemotePlayer)
		{
			this.playerNameTextBox.gameObject.SetActive(true);
		}
		else
		{
			this.playerNameTextBox.gameObject.SetActive(false);
		}
		if (this.\u02B7\u02B3\u02B9\u02B5\u02B7\u02BC\u02C1\u02BB\u02B7\u02B7\u02B4 != null)
		{
			if (this.playerStuff.playerInfo.isAccuracyDisplay && !this.playerStuff.\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4)
			{
				this.\u02B7\u02B3\u02B9\u02B5\u02B7\u02BC\u02C1\u02BB\u02B7\u02B7\u02B4.SetActive(true);
				if (this._GameManager.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD <= 2 && this._GameManager.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 == GameMode.Versus)
				{
					this.\u02B7\u02B3\u02B9\u02B5\u02B7\u02BC\u02C1\u02BB\u02B7\u02B7\u02B4.GetComponent<RectTransform>().localPosition = new Vector3(this.\u02B7\u02B3\u02B9\u02B5\u02B7\u02BC\u02C1\u02BB\u02B7\u02B7\u02B4.GetComponent<RectTransform>().localPosition.x, 408f, 277f);
				}
			}
			else
			{
				this.\u02B7\u02B3\u02B9\u02B5\u02B7\u02BC\u02C1\u02BB\u02B7\u02B7\u02B4.SetActive(false);
			}
		}
		this.\u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = this._GameManager;
		if (this.playerStuff.\u02C0\u02B5\u02B2\u02B2\u02BB\u02B8\u02B8\u02BD\u02B9\u02BD\u02C1())
		{
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
			{
				this.playerStuff.playerInfo.isBot.CurrentValue = 0;
			}
			else
			{
				this.\u02C0\u02BE\u02BD\u02B3\u02C0\u02B9\u02B5\u02BF\u02BC\u02BC\u02B8 = true;
				this.spBar.gameObject.SetActive(false);
				this.healthContainer.gameObject.SetActive(false);
				this.comboCounter.gameObject.SetActive(false);
			}
		}
		if (this.playerStuff.playerInfo.isRemotePlayer)
		{
			this.\u02C0\u02BE\u02BD\u02B3\u02C0\u02B9\u02B5\u02BF\u02BC\u02BC\u02B8 = true;
		}
		this.\u02B9\u02B8\u02BE\u02B7\u02B4\u02BC\u02BB\u02BE\u02B6\u02BB\u02C0();
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && this.playerStuff.\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4 && SettingsController.\u02BA\u02BE\u02B7\u02B7\u02BE\u02B4\u02BE\u02C1\u02B6\u02BD\u02B7 && !\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02BD\u02BC\u02B2\u02B8\u02BC\u02B5\u02B5\u02BB\u02BC\u02B6)
		{
			base.gameObject.SetActive(false);
		}
		if (!this.playerStuff.playerInfo.HasModChartModifier)
		{
			if (cUtilityClass.showBeatlines)
			{
				this.beatlines.enabled = true;
				this.showBeatlines = true;
			}
			else
			{
				this.beatlines.enabled = false;
				this.showBeatlines = false;
			}
			if (cUtilityClass.showHighway)
			{
				this.highway.gameObject.SetActive(true);
				this.showHighway = true;
			}
			else
			{
				this.highway.gameObject.SetActive(false);
				this.showHighway = false;
			}
			if (cUtilityClass.showHighwaySide)
			{
				this.highwayObjects[0].SetActive(true);
				this.highwayObjects[1].SetActive(true);
				this.showHighwaySide = true;
			}
			else
			{
				this.highwayObjects[0].SetActive(false);
				this.highwayObjects[1].SetActive(false);
				this.showHighwaySide = false;
			}
			if (cUtilityClass.showFretStrings)
			{
				this.showFretStrings = true;
				this.neckController.ShowFretStrings();
			}
			else
			{
				this.showFretStrings = false;
				this.neckController.HideFretStrings();
			}
			if (cUtilityClass.showHPBar)
			{
				this.healthContainer.gameObject.SetActive(true);
				return;
			}
			this.healthContainer.gameObject.SetActive(false);
		}
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x00080BCC File Offset: 0x0007EDCC
	public void \u02C1\u02B2\u02B7\u02B9\u02C0\u02B8\u02B7\u02BD\u02BD\u02B7\u02B3()
	{
		this.\u02B3\u02B9\u02B8\u02BF\u02C1\u02B9\u02B2\u02BC\u02B5\u02BB\u02BB = 0;
		this.\u02B9\u02B2\u02BF\u02BD\u02B3\u02B7\u02BF\u02BA\u02BD\u02B9\u02B5 = 0;
		foreach (Note note in this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0)
		{
			if (note.\u02BF\u02BE\u02B5\u02B3\u02C1\u02C1\u02B2\u02BF\u02B5\u02BB\u02B4)
			{
				this.\u02B9\u02B2\u02BF\u02BD\u02B3\u02B7\u02BF\u02BA\u02BD\u02B9\u02B5++;
			}
			if (note.\u02BD\u02BE\u02BC\u02B8\u02BC\u02B2\u02B4\u02B4\u02BA\u02BF\u02B6)
			{
				this.\u02B3\u02B9\u02B8\u02BF\u02C1\u02B9\u02B2\u02BC\u02B5\u02BB\u02BB++;
			}
		}
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x00080C50 File Offset: 0x0007EE50
	public virtual void \u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5()
	{
		if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			\u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B9\u02B2\u02BC\u02BA\u02B6\u02B7\u02BE\u02B6\u02BF\u02BA\u02B9 u02B9_u02B2_u02BC_u02BA_u02B6_u02B7_u02BE_u02B6_u02BF_u02BA_u02B = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B9\u02B9\u02BE\u02B4\u02B3\u02B6\u02BC\u02B5\u02B3\u02BC\u02BC(this, this._GameManager.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD, true);
			this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0 = u02B9_u02B2_u02BC_u02BA_u02B6_u02B7_u02BE_u02B6_u02BF_u02BA_u02B.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0;
			this.\u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2 = u02B9_u02B2_u02BC_u02BA_u02B6_u02B7_u02BE_u02B6_u02BF_u02BA_u02B;
			this.\u02C1\u02B2\u02B7\u02B9\u02C0\u02B8\u02B7\u02BD\u02BD\u02B7\u02B3();
			this.\u02B2\u02BB\u02B3\u02B8\u02B5\u02B2\u02C0\u02BF\u02BA\u02B4\u02BC = u02B9_u02B2_u02BC_u02BA_u02B6_u02B7_u02BE_u02B6_u02BF_u02BA_u02B.\u02B2\u02BB\u02B3\u02B8\u02B5\u02B2\u02C0\u02BF\u02BA\u02B4\u02BC;
			this.\u02B4\u02B7\u02BC\u02C1\u02B2\u02B8\u02B2\u02BD\u02BD\u02BC\u02BF = u02B9_u02B2_u02BC_u02BA_u02B6_u02B7_u02BE_u02B6_u02BF_u02BA_u02B.\u02B4\u02B7\u02BC\u02C1\u02B2\u02B8\u02B2\u02BD\u02BD\u02BC\u02BF;
			this.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2 = u02B9_u02B2_u02BC_u02BA_u02B6_u02B7_u02BE_u02B6_u02BF_u02BA_u02B.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2;
		}
		this.\u02B4\u02BA\u02B4\u02BF\u02B6\u02B9\u02B5\u02BA\u02C0\u02BD\u02BB.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = this._GameManager;
		this.\u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD.\u02C1\u02BD\u02B3\u02B7\u02BE\u02C0\u02BE\u02B4\u02BD\u02B3\u02BF(this._GameManager.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD);
	}

	// Token: 0x06000F40 RID: 3904
	protected abstract void \u02B6\u02BB\u02BB\u02B8\u02BF\u02C0\u02BD\u02C0\u02BE\u02BF\u02BB();

	// Token: 0x06000F41 RID: 3905
	protected abstract void handleBotInputs();

	// Token: 0x06000F42 RID: 3906
	protected abstract bool \u02B7\u02BF\u02BA\u02BF\u02C1\u02B4\u02B5\u02BD\u02C1\u02B8\u02B6(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, ushort \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4);

	// Token: 0x06000F43 RID: 3907 RVA: 0x00080CE0 File Offset: 0x0007EEE0
	public virtual void \u02BE\u02B4\u02B8\u02BD\u02BA\u02B5\u02B3\u02B3\u02B3\u02B4\u02BF(\u02C0\u02C1\u02B2\u02B3\u02B8\u02B7\u02B2\u02B3\u02C0\u02BF\u02BD \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA)
	{
		if (\u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02BC\u02B2\u02B9\u02B9\u02B9\u02B4\u02BB\u02BF\u02BF\u02BE\u02BE < this.combo)
		{
			this.\u02B6\u02B9\u02BC\u02C0\u02B6\u02BE\u02B4\u02BA\u02BC\u02BB\u02C1(!base.isActiveAndEnabled);
		}
		if (!this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF && \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02B3\u02BF\u02B4\u02B5\u02B4\u02BE\u02C0\u02B8\u02B3\u02B6\u02B6 < this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5)
		{
			this.\u02B9\u02BC\u02B2\u02B7\u02BD\u02B2\u02B2\u02B2\u02B2\u02BE\u02BE();
		}
		if (this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF && \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02B3\u02BF\u02B4\u02B5\u02B4\u02BE\u02C0\u02B8\u02B3\u02B6\u02B6 <= 0f)
		{
			this.\u02B9\u02BB\u02B6\u02BE\u02B6\u02B4\u02BF\u02B2\u02B7\u02C0\u02B9();
		}
		this.combo = \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02BC\u02B2\u02B9\u02B9\u02B9\u02B4\u02BB\u02BF\u02BF\u02BE\u02BE;
		this.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 = \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
		this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 = \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02B3\u02BF\u02B4\u02B5\u02B4\u02BE\u02C0\u02B8\u02B3\u02B6\u02B6;
		this.\u02C1\u02BC\u02BC\u02C1\u02B2\u02BF\u02C1\u02BE\u02BE\u02BB\u02B4 = this.combo > 0;
		this.comboCounter.\u02B3\u02BD\u02B2\u02B5\u02B9\u02BB\u02C0\u02B7\u02B8\u02B8\u02B6(this.combo);
		this.spBar.\u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC(this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5, this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF);
		this.\u02B9\u02B8\u02BE\u02B7\u02B4\u02BC\u02BB\u02BE\u02B6\u02BB\u02C0();
		if (!this.\u02C1\u02BC\u02BC\u02C1\u02B2\u02BF\u02C1\u02BE\u02BE\u02BB\u02B4)
		{
			this.inputBits = 0;
		}
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x0000E4A1 File Offset: 0x0000C6A1
	public virtual void \u02B5\u02B5\u02BA\u02BB\u02B7\u02BF\u02BC\u02B9\u02B5\u02BE\u02BF(\u02C0\u02C1\u02B2\u02B3\u02B8\u02B7\u02B2\u02B3\u02C0\u02BF\u02BD \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA)
	{
		\u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02BC\u02B2\u02B9\u02B9\u02B9\u02B4\u02BB\u02BF\u02BF\u02BE\u02BE = this.combo;
		\u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 = this.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
		\u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02B3\u02BF\u02B4\u02B5\u02B4\u02BE\u02C0\u02B8\u02B3\u02B6\u02B6 = this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5;
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x0000E4C7 File Offset: 0x0000C6C7
	public void \u02B2\u02BD\u02B2\u02C0\u02B8\u02C1\u02B4\u02C0\u02BA\u02BE\u02BE()
	{
		this.\u02B7\u02BD\u02C1\u02B3\u02BD\u02B5\u02B6\u02B8\u02B8\u02B2\u02BF = true;
		this.FCIndicator.SetActive(false);
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x00080DB4 File Offset: 0x0007EFB4
	protected float \u02C0\u02B5\u02C1\u02B4\u02BE\u02B6\u02BD\u02BA\u02BC\u02B4\u02B9(Note \u02B7\u02BF\u02BA\u02BE\u02B7\u02B7\u02B5\u02B3\u02B2\u02C0\u02BC, Note \u02B5\u02B5\u02C1\u02B6\u02BA\u02B8\u02B3\u02BE\u02B7\u02B7\u02B6, float \u02B6\u02B5\u02C0\u02B8\u02C1\u02BB\u02BF\u02BD\u02BF\u02B4\u02BE, float \u02B3\u02BD\u02B2\u02C0\u02BB\u02B4\u02B9\u02BF\u02BF\u02B6\u02B5)
	{
		float num;
		if (\u02B7\u02BF\u02BA\u02BE\u02B7\u02B7\u02B5\u02B3\u02B2\u02C0\u02BC == null || \u02B5\u02B5\u02C1\u02B6\u02BA\u02B8\u02B3\u02BE\u02B7\u02B7\u02B6 == null || \u02B7\u02BF\u02BA\u02BE\u02B7\u02B7\u02B5\u02B3\u02B2\u02C0\u02BC.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 - \u02B5\u02B5\u02C1\u02B6\u02BA\u02B8\u02B3\u02BE\u02B7\u02B7\u02B6.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 == 0f)
		{
			num = \u02B3\u02BD\u02B2\u02C0\u02BB\u02B4\u02B9\u02BF\u02BF\u02B6\u02B5;
		}
		else
		{
			num = Mathf.Clamp((\u02B5\u02B5\u02C1\u02B6\u02BA\u02B8\u02B3\u02BE\u02B7\u02B7\u02B6.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 - \u02B7\u02BF\u02BA\u02BE\u02B7\u02B7\u02B5\u02B3\u02B2\u02C0\u02BC.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1) / 2f, \u02B6\u02B5\u02C0\u02B8\u02C1\u02BB\u02BF\u02BD\u02BF\u02B4\u02BE, \u02B3\u02BD\u02B2\u02C0\u02BB\u02B4\u02B9\u02BF\u02BF\u02B6\u02B5);
		}
		return num;
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x0000E4DC File Offset: 0x0000C6DC
	protected virtual float \u02B9\u02B9\u02B4\u02C1\u02B9\u02B6\u02B2\u02BA\u02B2\u02B2\u02BF(float \u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4)
	{
		return \u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4;
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x00080E00 File Offset: 0x0007F000
	protected float \u02C0\u02BC\u02B5\u02BE\u02BE\u02C0\u02B8\u02C0\u02BD\u02C0\u02BA(Note \u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4, float \u02B6\u02B5\u02C0\u02B8\u02C1\u02BB\u02BF\u02BD\u02BF\u02B4\u02BE, float \u02B3\u02BD\u02B2\u02C0\u02BB\u02B4\u02B9\u02BF\u02BF\u02B6\u02B5)
	{
		int num = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.\u02B2\u02B4\u02B6\u02B8\u02C0\u02C0\u02B4\u02C0\u02B2\u02BE\u02BD(\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4, this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9);
		Note note = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.\u02B5\u02B5\u02B9\u02B6\u02BF\u02C0\u02B9\u02B8\u02B8\u02B8\u02C0(\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE, num);
		Note note2 = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.\u02B7\u02B9\u02B2\u02BF\u02B7\u02BF\u02B2\u02C1\u02B4\u02B7\u02B2(\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE, num, false);
		float num2 = this.\u02C0\u02B5\u02C1\u02B4\u02BE\u02B6\u02BD\u02BA\u02BC\u02B4\u02B9(\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4, note, \u02B6\u02B5\u02C0\u02B8\u02C1\u02BB\u02BF\u02BD\u02BF\u02B4\u02BE, \u02B3\u02BD\u02B2\u02C0\u02BB\u02B4\u02B9\u02BF\u02BF\u02B6\u02B5);
		float num3 = this.\u02C0\u02B5\u02C1\u02B4\u02BE\u02B6\u02BD\u02BA\u02BC\u02B4\u02B9(note2, \u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4, \u02B6\u02B5\u02C0\u02B8\u02C1\u02BB\u02BF\u02BD\u02BF\u02B4\u02BE, \u02B3\u02BD\u02B2\u02C0\u02BB\u02B4\u02B9\u02BF\u02BF\u02B6\u02B5);
		return this.\u02B9\u02B9\u02B4\u02C1\u02B9\u02B6\u02B2\u02BA\u02B2\u02B2\u02BF(num2 + num3);
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x00080E68 File Offset: 0x0007F068
	protected virtual void \u02BE\u02BC\u02BA\u02BB\u02C0\u02B5\u02B6\u02B8\u02B6\u02BB\u02B3(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		bool flag = true;
		this.\u02C0\u02B4\u02B5\u02B8\u02B6\u02B8\u02B2\u02BE\u02B6\u02B5\u02B2 = false;
		Note.\u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3 u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B = \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
		{
			if (!u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF.\u02BF\u02BF\u02B7\u02BE\u02B9\u02BC\u02B8\u02B7\u02C0\u02BC\u02B4)
			{
				flag = false;
				break;
			}
		}
		if (!this.playerStuff.playerInfo.isRemotePlayer)
		{
			this.\u02B3\u02B5\u02C1\u02B7\u02C1\u02C1\u02BA\u02B2\u02B5\u02BD\u02B7++;
			ComboColor comboColor = this.comboCounter;
			int num = this.combo + 1;
			this.combo = num;
			comboColor.\u02B3\u02BD\u02B2\u02B5\u02B9\u02BB\u02C0\u02B7\u02B8\u02B8\u02B6(num);
			this.\u02B7\u02B8\u02C1\u02BE\u02BF\u02B9\u02BF\u02BD\u02B2\u02C0\u02BE(true);
			this.\u02B9\u02B8\u02BE\u02B7\u02B4\u02BC\u02BB\u02BE\u02B6\u02BB\u02C0();
			if (this.combo > this.\u02B7\u02C0\u02BE\u02BB\u02B2\u02B2\u02B3\u02BC\u02BD\u02B4\u02BE)
			{
				this.\u02B7\u02C0\u02BE\u02BB\u02B2\u02B2\u02B3\u02BC\u02BD\u02B4\u02BE = this.combo;
			}
			if (\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02B5\u02C1\u02C0\u02BA\u02BD\u02BB\u02B5\u02BA\u02C1\u02C0 && !this.\u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD)
			{
				this.\u02BD\u02C0\u02BA\u02BA\u02BA\u02B7\u02B6\u02B8\u02B6\u02B2\u02BA();
			}
			if (this.\u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD)
			{
				this.\u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD.\u02BA\u02B9\u02B4\u02C1\u02B5\u02B2\u02BF\u02B3\u02BC\u02BF\u02B6();
				if (\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02C1\u02BC\u02B9\u02BF\u02B9\u02C1\u02B4\u02B8\u02BD\u02B8\u02B9 && flag)
				{
					this.\u02C1\u02BA\u02B8\u02BF\u02BD\u02BC\u02B8\u02B4\u02BA\u02B9\u02C1();
				}
			}
		}
		if (!this.\u02BF\u02B7\u02B6\u02B6\u02BE\u02BE\u02C0\u02C0\u02BB\u02B2\u02C1)
		{
			this.\u02BF\u02B7\u02B6\u02B6\u02BE\u02BE\u02C0\u02C0\u02BB\u02B2\u02C1 = \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02B7\u02C0\u02BE\u02C0\u02B6\u02BF\u02BC\u02C1\u02BA\u02BF\u02BE;
		}
		if (\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02B5\u02B7\u02BB\u02B7\u02BA\u02B3\u02B2\u02B7\u02C1\u02B3\u02B4 && this.\u02BF\u02B7\u02B6\u02B6\u02BE\u02BE\u02C0\u02C0\u02BB\u02B2\u02C1 && flag)
		{
			if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
			{
				\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 &= ~Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.STAR_POWER_END;
				this.\u02B8\u02B8\u02B3\u02BD\u02B2\u02BB\u02BF\u02B8\u02B3\u02B8\u02BD(0.25f, true);
				this.\u02C0\u02B4\u02B5\u02B8\u02B6\u02B8\u02B2\u02BE\u02B6\u02B5\u02B2 = true;
			}
			this.\u02BF\u02B7\u02B6\u02B6\u02BE\u02BE\u02C0\u02C0\u02BB\u02B2\u02C1 = false;
		}
		this.\u02BC\u02BD\u02BF\u02BA\u02B8\u02B5\u02B3\u02B8\u02BE\u02C0\u02BC.\u02B6\u02B4\u02BA\u02BC\u02B9\u02BE\u02C0\u02BC\u02BE\u02BA\u02B7();
	}

	// Token: 0x06000F4A RID: 3914
	protected abstract bool \u02BA\u02B7\u02B5\u02C1\u02C0\u02B4\u02BE\u02BF\u02BF\u02C0\u02BE(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2);

	// Token: 0x06000F4B RID: 3915 RVA: 0x00080FB4 File Offset: 0x0007F1B4
	protected void \u02B7\u02B8\u02C1\u02BE\u02BF\u02B9\u02BF\u02BD\u02B2\u02C0\u02BE(bool \u02BD\u02BF\u02C1\u02C1\u02B8\u02B4\u02BB\u02B9\u02B8\u02B3\u02B4)
	{
		if (this.playerStuff.playerInfo.isRemotePlayer)
		{
			return;
		}
		if (\u02BD\u02BF\u02C1\u02C1\u02B8\u02B4\u02BB\u02B9\u02B8\u02B3\u02B4)
		{
			if (this.\u02BA\u02BC\u02BB\u02B3\u02BC\u02B3\u02B2\u02C0\u02BC\u02B8\u02BA >= 1f)
			{
				return;
			}
			if (this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
			{
				this.\u02BA\u02BC\u02BB\u02B3\u02BC\u02B3\u02B2\u02C0\u02BC\u02B8\u02BA += this.\u02B5\u02B3\u02BE\u02B7\u02BA\u02BF\u02BD\u02BC\u02B9\u02C1\u02B8;
			}
			else
			{
				this.\u02BA\u02BC\u02BB\u02B3\u02BC\u02B3\u02B2\u02C0\u02BC\u02B8\u02BA += this.\u02B9\u02B3\u02C1\u02B6\u02BC\u02B4\u02C1\u02B2\u02B3\u02BC\u02C1;
			}
		}
		else
		{
			this.\u02BA\u02BC\u02BB\u02B3\u02BC\u02B3\u02B2\u02C0\u02BC\u02B8\u02BA -= this.\u02BD\u02B2\u02B9\u02B8\u02C0\u02B4\u02BF\u02BF\u02B7\u02BF\u02B3;
			if (this.\u02BA\u02BC\u02BB\u02B3\u02BC\u02B3\u02B2\u02C0\u02BC\u02B8\u02BA < 0f && !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B8\u02B9\u02BA\u02BB\u02C1\u02BB\u02B9\u02BE\u02C1\u02B9)
			{
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B8\u02B9\u02BA\u02BB\u02C1\u02BB\u02B9\u02BE\u02C1\u02B9 = true;
				GameAudioManager.PlaySound(SoundID.SongFail);
				this._GameManager.EndSong();
			}
		}
		this.healthContainer.\u02BF\u02BC\u02B7\u02B2\u02B9\u02BA\u02BD\u02B6\u02C0\u02C0\u02BE(this.\u02BA\u02BC\u02BB\u02B3\u02BC\u02B3\u02B2\u02C0\u02BC\u02B8\u02BA);
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06000F4C RID: 3916 RVA: 0x0000E4DF File Offset: 0x0000C6DF
	public bool \u02BF\u02C0\u02BA\u02B6\u02B7\u02C0\u02B2\u02BE\u02BC\u02BA\u02B2
	{
		get
		{
			return !this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF && this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 >= 0.5f;
		}
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x00081074 File Offset: 0x0007F274
	public void \u02BA\u02B6\u02C0\u02B4\u02B4\u02BC\u02B7\u02BB\u02B2\u02C0\u02BF()
	{
		if (this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0[this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9].\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1)
		{
			for (int i = this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9 - 1; i > 0; i--)
			{
				Note note = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0[i];
				if (!note.\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1 || !note.\u02B7\u02C0\u02BE\u02C0\u02B6\u02BF\u02BC\u02C1\u02BA\u02BF\u02BE)
				{
					break;
				}
				note.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 &= ~Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.STAR_POWER;
			}
		}
		foreach (Note note2 in EnumerableRanges.EnumerateRange<Note>(this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0, this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9, int.MaxValue))
		{
			if (note2.\u02B5\u02B7\u02BB\u02B7\u02BA\u02B3\u02B2\u02B7\u02C1\u02B3\u02B4)
			{
				Note.\u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3 u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B = note2.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
				while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
				{
					Note note3 = u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
					note3.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 &= ~Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.STAR_POWER;
					note3.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 &= ~Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.STAR_POWER_END;
				}
				return;
			}
			if (note2.\u02B7\u02C0\u02BE\u02C0\u02B6\u02BF\u02BC\u02C1\u02BA\u02BF\u02BE)
			{
				note2.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 &= ~Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.STAR_POWER;
			}
		}
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x00081170 File Offset: 0x0007F370
	protected void \u02BC\u02B2\u02B4\u02B2\u02C0\u02BA\u02B2\u02B8\u02BA\u02B9\u02B5(float \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8)
	{
		if (this.playerStuff.playerInfo.isRemotePlayer)
		{
			return;
		}
		this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 -= \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		if (this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 <= 0f)
		{
			this.\u02B9\u02BB\u02B6\u02BE\u02B6\u02B4\u02BF\u02B2\u02B7\u02C0\u02B9();
		}
		this.spBar.\u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC(this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5, this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF);
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x000811C8 File Offset: 0x0007F3C8
	protected virtual void \u02B8\u02B8\u02B3\u02BD\u02B2\u02BB\u02BF\u02B8\u02B3\u02B8\u02BD(float \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8, bool \u02C0\u02B5\u02BC\u02C1\u02B8\u02B5\u02BB\u02BD\u02B9\u02BB\u02C1 = false)
	{
		if (this.playerStuff.playerInfo.isRemotePlayer || this.playerStuff.\u02C0\u02B5\u02B2\u02B2\u02BB\u02B8\u02B8\u02BD\u02B9\u02BD\u02C1())
		{
			return;
		}
		bool flag = this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 < 0.5f && !this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF;
		float u02B9_u02C0_u02BC_u02B5_u02B3_u02C0_u02BB_u02BC_u02B5_u02BF_u02B = this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5;
		this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 += \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		if (\u02C0\u02B5\u02BC\u02C1\u02B8\u02B5\u02BB\u02BD\u02B9\u02BB\u02C1)
		{
			this.\u02BE\u02BB\u02B7\u02B6\u02B9\u02BB\u02B3\u02B8\u02B2\u02B6\u02B9++;
			GameAudioManager.PlaySound(SoundID.StarPowerAwarded);
		}
		else if (flag && this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 >= 0.5f)
		{
			GameAudioManager.PlaySound(SoundID.StarPowerAvailable);
		}
		if (this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 >= 1f)
		{
			this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 = 1f;
		}
		this.\u02B5\u02B5\u02B4\u02BB\u02B4\u02BE\u02B2\u02B5\u02B5\u02C0\u02B4 += this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 - u02B9_u02C0_u02BC_u02B5_u02B3_u02C0_u02BB_u02BC_u02B5_u02BF_u02B;
		this.spBar.\u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC(this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5, this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF);
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x00081298 File Offset: 0x0007F498
	protected void \u02B9\u02BC\u02B2\u02B7\u02BD\u02B2\u02B2\u02B2\u02B2\u02BE\u02BE()
	{
		this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF = true;
		this.comboCounter.\u02B4\u02B8\u02BA\u02B8\u02B9\u02BA\u02B7\u02B6\u02BE\u02BE\u02B5();
		this.neckController.\u02B6\u02B2\u02B9\u02B7\u02B5\u02B9\u02B5\u02BF\u02B8\u02B8\u02BC(true);
		this.\u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7 *= 2;
		this.\u02B8\u02BE\u02B5\u02B7\u02BF\u02B9\u02C1\u02B2\u02B8\u02B6\u02BF++;
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (!this.playerStuff.playerInfo.HasModChartModifier)
		{
			this.spNeckRenderer.\u02B5\u02B4\u02B8\u02B4\u02BF\u02B7\u02BC\u02BD\u02B4\u02B5\u02B7();
		}
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x00081308 File Offset: 0x0007F508
	protected void \u02B9\u02BB\u02B6\u02BE\u02B6\u02B4\u02BF\u02B2\u02B7\u02C0\u02B9()
	{
		this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF = false;
		this.comboCounter.\u02BF\u02C0\u02BE\u02B3\u02B8\u02B6\u02B8\u02B8\u02B9\u02B4\u02C0();
		this.neckController.\u02B6\u02B2\u02B9\u02B7\u02B5\u02B9\u02B5\u02BF\u02B8\u02B8\u02BC(false);
		this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 = 0f;
		this.\u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7 /= 2;
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		this.spNeckRenderer.\u02BE\u02BA\u02B5\u02BF\u02BF\u02B7\u02B4\u02BC\u02BB\u02B2\u02B4();
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x00081360 File Offset: 0x0007F560
	public virtual void \u02B3\u02B6\u02C0\u02C1\u02B6\u02B6\u02BD\u02BD\u02B7\u02BC\u02BC(Note \u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2)
	{
		\u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2.\u02C1\u02BC\u02B2\u02C1\u02BC\u02B8\u02B2\u02BA\u02C1\u02B9\u02C0 = true;
		if (\u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2.\u02B5\u02C0\u02B3\u02C0\u02B6\u02B5\u02B8\u02BD\u02B6\u02B4\u02B4)
		{
			return;
		}
		this.\u02BF\u02B7\u02B6\u02B6\u02BE\u02BE\u02C0\u02C0\u02BB\u02B2\u02C1 = \u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2.\u02B7\u02C0\u02BE\u02C0\u02B6\u02BF\u02BC\u02C1\u02BA\u02BF\u02BE;
		this.\u02B6\u02B9\u02BC\u02C0\u02B6\u02BE\u02B4\u02BA\u02BC\u02BB\u02C1(false);
		if (!this.playerStuff.\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4)
		{
			if (this.\u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD && \u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2.\u02C1\u02BC\u02B9\u02BF\u02B9\u02C1\u02B4\u02B8\u02BD\u02B8\u02B9)
			{
				this.\u02C1\u02BA\u02B8\u02BF\u02BD\u02BC\u02B8\u02B4\u02BA\u02B9\u02C1();
			}
			else if (\u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2.\u02BF\u02B5\u02C1\u02C0\u02BA\u02BD\u02BB\u02B5\u02BA\u02C1\u02C0)
			{
				this.\u02BD\u02C0\u02BA\u02BA\u02BA\u02B7\u02B6\u02B8\u02B6\u02B2\u02BA();
			}
		}
		this.\u02BC\u02BD\u02BF\u02BA\u02B8\u02B5\u02B3\u02B8\u02BE\u02C0\u02BC.\u02B3\u02B3\u02B6\u02B9\u02BE\u02B4\u02BB\u02B4\u02B3\u02BF\u02B8();
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x000813D0 File Offset: 0x0007F5D0
	protected virtual void \u02B6\u02B9\u02BC\u02C0\u02B6\u02BE\u02B4\u02BA\u02BC\u02BB\u02C1(bool \u02B8\u02BF\u02BA\u02B6\u02BD\u02B7\u02B8\u02BD\u02BB\u02B3\u02BA)
	{
		if (!\u02B8\u02BF\u02BA\u02B6\u02BD\u02B7\u02B8\u02BD\u02BB\u02B3\u02BA && !this.playerStuff.playerInfo.isRemotePlayer)
		{
			if (!this.missFromWindow)
			{
				this.precision.AddJudgement(BasePlayer.CalculateJudgementAndScore(-1f));
				GlobalVariables.misses++;
			}
			else
			{
				if (cUtilityClass.soundOnJudgeBreak)
				{
					BassAudioManager.Instance.PlaySoundInternal(SoundID.FreestyleSnare, 0, 116.666664f * cUtilityClass.judgeBreakSoundVolume);
				}
				this.missFromWindow = false;
			}
		}
		if (this.combo >= 10)
		{
			this.\u02C0\u02BE\u02B4\u02BF\u02C1\u02C1\u02B3\u02BF\u02BE\u02B2\u02B5.\u02C1\u02BE\u02B5\u02C0\u02B2\u02C1\u02BB\u02BC\u02BF\u02BD\u02BC(this.\u02C0\u02BE\u02B4\u02BF\u02C1\u02C1\u02B3\u02BF\u02BE\u02B2\u02B5.\u02BB\u02B2\u02C1\u02B6\u02B5\u02C0\u02BE\u02B7\u02BD\u02B6\u02B7, 0.25f);
		}
		if (this.\u02BF\u02B7\u02B6\u02B6\u02BE\u02BE\u02C0\u02C0\u02BB\u02B2\u02C1)
		{
			this.\u02BA\u02B6\u02C0\u02B4\u02B4\u02BC\u02B7\u02BB\u02B2\u02C0\u02BF();
			this.\u02BF\u02B7\u02B6\u02B6\u02BE\u02BE\u02C0\u02C0\u02BB\u02B2\u02C1 = false;
		}
		if (!this.playerStuff.\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4)
		{
			this.combo = 0;
			this.\u02B9\u02B8\u02BE\u02B7\u02B4\u02BC\u02BB\u02BE\u02B6\u02BB\u02C0();
			this.comboCounter.\u02B3\u02BD\u02B2\u02B5\u02B9\u02BB\u02C0\u02B7\u02B8\u02B8\u02B6(0);
			this.\u02B7\u02B8\u02C1\u02BE\u02BF\u02B9\u02BF\u02BD\u02B2\u02C0\u02BE(false);
			if (!this.\u02B7\u02BD\u02C1\u02B3\u02BD\u02B5\u02B6\u02B8\u02B8\u02B2\u02BF)
			{
				this.FCIndicator.SetActive(false);
				this.\u02B7\u02BD\u02C1\u02B3\u02BD\u02B5\u02B6\u02B8\u02B8\u02B2\u02BF = true;
				if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
				{
					this.\u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD.\u02B9\u02BF\u02BB\u02BD\u02B3\u02BD\u02BE\u02B2\u02B4\u02C1\u02BD.\u02B3\u02C0\u02BF\u02B7\u02C1\u02B3\u02BF\u02B9\u02B6\u02B5\u02BC();
				}
			}
		}
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x000814E4 File Offset: 0x0007F6E4
	public int \u02C1\u02BA\u02BA\u02C0\u02B7\u02BA\u02B3\u02BF\u02C1\u02B7\u02C1()
	{
		if (this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC > 0)
		{
			return this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC;
		}
		int num = 0;
		int num2 = 0;
		foreach (Note note in this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0)
		{
			int num3;
			if (note.\u02BC\u02BF\u02B7\u02B2\u02C0\u02C1\u02BD\u02BC\u02B9\u02B4\u02B8)
			{
				num3 = 15;
			}
			else
			{
				num3 = 0;
			}
			int num4;
			if (note.\u02BF\u02BE\u02B5\u02B3\u02C1\u02C1\u02B2\u02BF\u02B5\u02BB\u02B4 || note.\u02BD\u02BE\u02BC\u02B8\u02BC\u02B2\u02B4\u02B4\u02BA\u02BF\u02B6)
			{
				num4 = 2;
			}
			else
			{
				num4 = 1;
			}
			int num5 = ((note.\u02BD\u02B7\u02BA\u02C1\u02B9\u02B9\u02B9\u02B7\u02B7\u02B6\u02BD == -1) ? __FIXME_clon_util.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF) : note.\u02BD\u02B7\u02BA\u02C1\u02B9\u02B9\u02B9\u02B7\u02B7\u02B6\u02BD);
			num += num5 * (50 + num3) * num4;
			if ((float)note.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 >= Mathf.Ceil(this._GameManager.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02C0\u02B3\u02C1\u02BB\u02B5\u02BA\u02BB\u02B3\u02C1\u02B8\u02BD / 3f))
			{
				num2 += note.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2;
			}
		}
		if (this.playerStuff.playerInfo.IsDrumsInstrument)
		{
			num2 = 0;
		}
		num += Mathf.CeilToInt((float)num2 / (this._GameManager.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02C0\u02B3\u02C1\u02BB\u02B5\u02BA\u02BB\u02B3\u02C1\u02B8\u02BD / 25f));
		this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC = num;
		return this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC;
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x00081610 File Offset: 0x0007F810
	protected void \u02BB\u02B4\u02B5\u02B9\u02B7\u02B5\u02C1\u02C0\u02B6\u02C1\u02BD(int \u02BF\u02B2\u02B4\u02B8\u02BC\u02C1\u02BA\u02B3\u02BB\u02B2\u02BD)
	{
		if (this.playerStuff.playerInfo.isRemotePlayer)
		{
			return;
		}
		this.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 += \u02BF\u02B2\u02B4\u02B8\u02BC\u02C1\u02BA\u02B3\u02BB\u02B2\u02BD * this.\u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7;
		this.\u02B2\u02B2\u02C0\u02B3\u02B5\u02BD\u02BC\u02B5\u02B3\u02B7\u02B4 += \u02BF\u02B2\u02B4\u02B8\u02BC\u02C1\u02BA\u02B3\u02BB\u02B2\u02BD;
		if (this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
		{
			int num = this.\u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7 / 2;
			int num2 = \u02BF\u02B2\u02B4\u02B8\u02BC\u02C1\u02BA\u02B3\u02BB\u02B2\u02BD * num;
			int num3 = \u02BF\u02B2\u02B4\u02B8\u02BC\u02C1\u02BA\u02B3\u02BB\u02B2\u02BD * (num - 1);
			this.\u02B9\u02B7\u02B6\u02BE\u02BC\u02B2\u02C1\u02BF\u02B6\u02BA\u02BD += num3;
			this.\u02B6\u02B4\u02BB\u02BC\u02BA\u02B9\u02B8\u02B7\u02B5\u02C0\u02C1 += num2;
			GlobalVariables.totalPoints += (long)(num3 + num2);
			return;
		}
		int num4 = \u02BF\u02B2\u02B4\u02B8\u02BC\u02C1\u02BA\u02B3\u02BB\u02B2\u02BD * (this.\u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7 - 1);
		GlobalVariables.totalPoints += (long)num4;
		this.\u02B9\u02B7\u02B6\u02BE\u02BC\u02B2\u02C1\u02BF\u02B6\u02BA\u02BD += num4;
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x000816C0 File Offset: 0x0007F8C0
	protected virtual void \u02BB\u02B4\u02B5\u02B9\u02B7\u02B5\u02C1\u02C0\u02B6\u02C1\u02BD(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8, int \u02B7\u02BE\u02B2\u02B6\u02BC\u02BF\u02B4\u02B6\u02B2\u02B8\u02B3 = 50)
	{
		if (this.playerStuff.playerInfo.isRemotePlayer)
		{
			return;
		}
		int num = ((\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BD\u02B7\u02BA\u02C1\u02B9\u02B9\u02B9\u02B7\u02B7\u02B6\u02BD == -1) ? __FIXME_clon_util.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF) : \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BD\u02B7\u02BA\u02C1\u02B9\u02B9\u02B9\u02B7\u02B7\u02B6\u02BD) * \u02B7\u02BE\u02B2\u02B6\u02BC\u02BF\u02B4\u02B6\u02B2\u02B8\u02B3;
		this.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 += num * this.\u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7;
		this.\u02BD\u02BC\u02B7\u02B6\u02C1\u02B6\u02BF\u02B5\u02BA\u02BF\u02C1 += num;
		if (this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
		{
			int num2 = this.\u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7 / 2;
			int num3 = num * (num2 - 1);
			int num4 = num * num2;
			this.\u02B9\u02B7\u02B6\u02BE\u02BC\u02B2\u02C1\u02BF\u02B6\u02BA\u02BD += num3;
			this.\u02B6\u02B4\u02BB\u02BC\u02BA\u02B9\u02B8\u02B7\u02B5\u02C0\u02C1 += num4;
			GlobalVariables.totalPoints += (long)(num3 + num4);
			return;
		}
		int num5 = num * (this.\u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7 - 1);
		this.\u02B9\u02B7\u02B6\u02BE\u02BC\u02B2\u02C1\u02BF\u02B6\u02BA\u02BD += num5;
		GlobalVariables.totalPoints += (long)num5;
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x0000E4FB File Offset: 0x0000C6FB
	public void \u02B9\u02B8\u02BE\u02B7\u02B4\u02BC\u02BB\u02BE\u02B6\u02BB\u02C0()
	{
		if (this.combo > 30)
		{
			this.\u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7 = 4;
		}
		else
		{
			this.\u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7 = this.combo / 10 + 1;
		}
		if (this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
		{
			this.\u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7 *= 2;
		}
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x0000E537 File Offset: 0x0000C737
	public void \u02BD\u02C0\u02BA\u02BA\u02BA\u02B7\u02B6\u02B8\u02B6\u02B2\u02BA()
	{
		if (this.\u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD)
		{
			return;
		}
		this.\u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD.\u02BA\u02B8\u02B3\u02B7\u02B2\u02BE\u02B9\u02B5\u02BD\u02BF\u02BC();
		this.\u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD = true;
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x0000E554 File Offset: 0x0000C754
	public void \u02C1\u02BA\u02B8\u02BF\u02BD\u02BC\u02B8\u02B4\u02BA\u02B9\u02C1()
	{
		if (!this.\u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD)
		{
			return;
		}
		this.\u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD = false;
		this.\u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD.\u02C1\u02BA\u02B8\u02BF\u02BD\u02BC\u02B8\u02B4\u02BA\u02B9\u02C1();
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x00081794 File Offset: 0x0007F994
	protected void \u02B3\u02B2\u02B7\u02C1\u02BF\u02B6\u02BE\u02BA\u02BA\u02BF\u02B2()
	{
		if (!this.playerStuff.playerInfo.isRemotePlayer)
		{
			BasePlayer.lastOffset = this.\u02BB\u02B3\u02B2\u02C0\u02B3\u02BC\u02B3\u02B5\u02BB\u02C0\u02B6;
			BasePlayer.JudgementAndFloat judgementAndFloat = BasePlayer.CalculateJudgementAndScore(this.\u02BB\u02B3\u02B2\u02C0\u02B3\u02BC\u02B3\u02B5\u02BB\u02C0\u02B6);
			if (judgementAndFloat.judgement != BasePlayer.Judgement.Miss)
			{
				if (judgementAndFloat.judgement > cUtilityClass.maximumImprecision)
				{
					this.missFromWindow = true;
					this.\u02B6\u02B9\u02BC\u02C0\u02B6\u02BE\u02B4\u02BA\u02BC\u02BB\u02C1(false);
				}
				else if (judgementAndFloat.judgement == BasePlayer.Judgement.Early && cUtilityClass.breakComboOnEarly)
				{
					this.missFromWindow = true;
					this.\u02B6\u02B9\u02BC\u02C0\u02B6\u02BE\u02B4\u02BA\u02BC\u02BB\u02C1(false);
				}
			}
			this.precision.AddJudgement(judgementAndFloat);
		}
		if (this.playerStuff.playerInfo.isAccuracyDisplay)
		{
			if (this.\u02B8\u02C1\u02BF\u02C0\u02B3\u02B9\u02B6\u02B2\u02B8\u02B7\u02BE.Count >= 256)
			{
				this.\u02B8\u02C1\u02BF\u02C0\u02B3\u02B9\u02B6\u02B2\u02B8\u02B7\u02BE.RemoveAt(0);
			}
			this.\u02B8\u02C1\u02BF\u02C0\u02B3\u02B9\u02B6\u02B2\u02B8\u02B7\u02BE.Add(this.\u02BB\u02B3\u02B2\u02C0\u02B3\u02BC\u02B3\u02B5\u02BB\u02C0\u02B6);
			double num = 0.0;
			foreach (float num2 in this.\u02B8\u02C1\u02BF\u02C0\u02B3\u02B9\u02B6\u02B2\u02B8\u02B7\u02BE)
			{
				num += (double)num2;
			}
			num /= (double)this.\u02B8\u02C1\u02BF\u02C0\u02B3\u02B9\u02B6\u02B2\u02B8\u02B7\u02BE.Count;
			this.\u02BB\u02BC\u02B9\u02BF\u02C1\u02B3\u02BD\u02B7\u02BE\u02BC\u02B4.text = string.Format("Accuracy: {0:0.0} ms\nAverage: {1:0.0} ms", -this.\u02BB\u02B3\u02B2\u02C0\u02B3\u02BC\u02B3\u02B5\u02BB\u02C0\u02B6 * 1000f, -num * 1000.0);
		}
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x000818F8 File Offset: 0x0007FAF8
	protected virtual void Update()
	{
		if (GlobalVariables.hasReset)
		{
			this._ghosts = 0;
		}
		this.ticker += Time.deltaTime;
		if (this.ticker > 0.67f && !this.playerStuff.playerInfo.HasModChartModifier)
		{
			if (cUtilityClass.showBeatlines)
			{
				this.beatlines.enabled = true;
				this.showBeatlines = true;
			}
			else
			{
				this.beatlines.enabled = false;
				this.showBeatlines = false;
			}
			if (cUtilityClass.showHighway)
			{
				this.highway.gameObject.SetActive(true);
				this.showHighway = true;
			}
			else
			{
				this.highway.gameObject.SetActive(false);
				this.showHighway = false;
			}
			if (cUtilityClass.showHighwaySide)
			{
				this.highwayObjects[0].SetActive(true);
				this.highwayObjects[1].SetActive(true);
				this.showHighwaySide = true;
			}
			else
			{
				this.highwayObjects[0].SetActive(false);
				this.highwayObjects[1].SetActive(false);
				this.showHighwaySide = false;
			}
			if (cUtilityClass.showFretStrings)
			{
				this.showFretStrings = true;
				this.neckController.ShowFretStrings();
			}
			else
			{
				this.showFretStrings = false;
				this.neckController.HideFretStrings();
			}
			if (cUtilityClass.showHPBar)
			{
				if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B8\u02B9\u02BA\u02BB\u02C1\u02BB\u02B9\u02BE\u02C1\u02B9)
				{
					this.healthContainer.gameObject.SetActive(true);
				}
				else if (cUtilityClass.hideHPOnFail)
				{
					this.healthContainer.gameObject.SetActive(false);
				}
				else
				{
					this.healthContainer.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(false);
					this.healthContainer.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(false);
					this.healthContainer.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(false);
					this.healthContainer.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
					this.healthContainer.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = new Color(0.15f, 0.15f, 0.15f, 1f);
				}
			}
			else
			{
				this.healthContainer.gameObject.SetActive(false);
			}
			this.ticker = 0f;
		}
		this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6 = 0;
		if (!this._GameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5)
		{
			if (!this.playerStuff.playerInfo.isRemotePlayer && this.playerStuff.rewiredPlayer.GetButtonDown(16))
			{
				this._GameManager.\u02B7\u02BB\u02B6\u02C0\u02BE\u02B5\u02B8\u02C0\u02B3\u02C0\u02BD(this.playerStuff);
			}
		}
		else
		{
			this.\u02B4\u02C0\u02BF\u02BA\u02BD\u02BA\u02B3\u02B8\u02B7\u02B7\u02BA();
		}
		if (!this._GameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5 || CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.\u02B9\u02C0\u02B2\u02BA\u02B9\u02BF\u02BE\u02BE\u02BD\u02B4\u02B7();
		}
		if (this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
		{
			this.\u02B5\u02B3\u02B4\u02BB\u02B2\u02BB\u02B9\u02BF\u02BB\u02B3\u02B4 += this._GameManager.\u02C0\u02BE\u02C1\u02BD\u02C0\u02BC\u02BB\u02B4\u02C1\u02B3\u02B9;
			this.\u02BC\u02B2\u02B4\u02B2\u02C0\u02BA\u02B2\u02B8\u02BA\u02B9\u02B5(this._GameManager.\u02B6\u02BD\u02BF\u02B2\u02B5\u02BA\u02BC\u02BA\u02B9\u02B5\u02B2());
		}
		if (this._GameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5 && this.\u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6)
		{
			this.\u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6 = false;
		}
		if (!this.playerStuff.playerInfo.isBot && !this.\u02C1\u02BC\u02BC\u02C1\u02B2\u02BF\u02C1\u02BE\u02BE\u02BB\u02B4)
		{
			this.\u02B6\u02BB\u02BB\u02B8\u02BF\u02C0\u02BD\u02C0\u02BE\u02BF\u02BB();
		}
		else
		{
			this.handleBotInputs();
		}
		if (!this.\u02B5\u02BB\u02BA\u02B2\u02C1\u02BB\u02B6\u02B5\u02BE\u02B9\u02BF && this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 >= 0.0)
		{
			this.\u02B6\u02BC\u02BD\u02B3\u02B6\u02B3\u02BD\u02B9\u02BF\u02BA\u02B6 = BassAudioManager.Instance.\u02B6\u02B5\u02BD\u02C0\u02B6\u02BA\u02B2\u02B9\u02C1\u02BD\u02BD(this.playerStuff.playerInfo.\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1);
			this.\u02B5\u02BB\u02BA\u02B2\u02C1\u02BB\u02B6\u02B5\u02BE\u02B9\u02BF = true;
		}
		if (this.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2 != null)
		{
			this.\u02B8\u02B3\u02B5\u02B5\u02C1\u02B4\u02BA\u02BF\u02BA\u02BC\u02B3 = this.\u02B3\u02C1\u02BD\u02BF\u02B4\u02B2\u02BC\u02BF\u02BC\u02C1\u02BC;
			long num = (long)((ulong)this.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE + (ulong)((long)this.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2));
			if (this._GameManager.\u02BA\u02BC\u02B2\u02BE\u02B7\u02C0\u02BD\u02B7\u02B2\u02B9\u02BF >= this.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE && (ulong)this._GameManager.\u02BA\u02BC\u02B2\u02BE\u02B7\u02C0\u02BD\u02B7\u02B2\u02B9\u02BF < (ulong)num)
			{
				this.\u02B3\u02C1\u02BD\u02BF\u02B4\u02B2\u02BC\u02BF\u02BC\u02C1\u02BC = true;
			}
			else
			{
				this.\u02B3\u02C1\u02BD\u02BF\u02B4\u02B2\u02BC\u02BF\u02BC\u02C1\u02BC = false;
			}
		}
		this.neckController.\u02C0\u02B8\u02B5\u02B3\u02BF\u02BD\u02B2\u02BE\u02B9\u02B2\u02B4(this.inputBits);
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x00081CB4 File Offset: 0x0007FEB4
	protected virtual void \u02B9\u02C0\u02B2\u02BA\u02B9\u02BF\u02BE\u02BE\u02BD\u02B4\u02B7()
	{
		if (this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0 == null || this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count == 0)
		{
			return;
		}
		Note note = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0[this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count - 1];
		this.\u02C0\u02B2\u02B2\u02BA\u02B5\u02B9\u02BD\u02B6\u02BD\u02B6\u02B9 = !this._GameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5 && this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count > 0 && this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9 > 0 && !note.\u02BC\u02B9\u02B4\u02B6\u02B5\u02BC\u02BB\u02BC\u02BB\u02B4\u02B7;
		uint num = 0U;
		foreach (Note note2 in EnumerableRanges.EnumerateRange<Note>(this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0, this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9, int.MaxValue))
		{
			if (this.\u02B2\u02B3\u02B6\u02B9\u02B6\u02B8\u02B3\u02BE\u02BE\u02B3\u02B6)
			{
				this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF = this.\u02C0\u02BC\u02B5\u02BE\u02BE\u02C0\u02B8\u02C0\u02BD\u02C0\u02BA(note2, this.\u02BF\u02BE\u02B8\u02C1\u02BE\u02C1\u02C0\u02C0\u02BB\u02BB\u02BC, this.\u02B2\u02BE\u02BE\u02B8\u02B6\u02BE\u02BA\u02BA\u02B5\u02B3\u02BC);
				float num2 = this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF / 2f;
				this.\u02B4\u02B4\u02BF\u02B5\u02B4\u02B6\u02BA\u02B7\u02B2\u02B9\u02C1 = num2;
				this.\u02B8\u02B2\u02B4\u02BF\u02C0\u02B8\u02C0\u02BA\u02B9\u02B2\u02B7 = -num2;
			}
			if (this.\u02C0\u02BE\u02BD\u02B3\u02C0\u02B9\u02B5\u02BF\u02BC\u02BC\u02B8)
			{
				this.\u02B4\u02B4\u02BF\u02B5\u02B4\u02B6\u02BA\u02B7\u02B2\u02B9\u02C1 = 0f;
				this.\u02B8\u02B2\u02B4\u02BF\u02C0\u02B8\u02C0\u02BA\u02B9\u02B2\u02B7 = -this.\u02B2\u02BE\u02BE\u02B8\u02B6\u02BE\u02BA\u02BA\u02B5\u02B3\u02BC;
			}
			double num3 = (double)note2.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 - this._GameManager.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
			if (num3 > (double)this.\u02B4\u02B4\u02BF\u02B5\u02B4\u02B6\u02BA\u02B7\u02B2\u02B9\u02C1)
			{
				while (this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9 < this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count)
				{
					Note note3 = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0[this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9];
					bool flag = false;
					Note.\u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3 u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B = note3.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
					while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
					{
						if (!u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF.\u02BC\u02B9\u02B4\u02B6\u02B5\u02BC\u02BB\u02BC\u02BB\u02B4\u02B7)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						break;
					}
					this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9 += note3.\u02C1\u02B7\u02B6\u02BF\u02B9\u02BB\u02B8\u02BD\u02B9\u02B8\u02B3;
					this.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD = note3;
				}
				return;
			}
			if (!note2.\u02BC\u02B9\u02B4\u02B6\u02B5\u02BC\u02BB\u02BC\u02BB\u02B4\u02B7)
			{
				if (num3 < (double)this.\u02B8\u02B2\u02B4\u02BF\u02C0\u02B8\u02C0\u02BA\u02B9\u02B2\u02B7)
				{
					Note.\u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3 u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B2 = note2.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
					while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B2.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
					{
						Note note4 = u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B2.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
						if (!note4.\u02BC\u02B9\u02B4\u02B6\u02B5\u02BC\u02BB\u02BC\u02BB\u02B4\u02B7)
						{
							this.\u02B3\u02B6\u02C0\u02C1\u02B6\u02B6\u02BD\u02BD\u02B7\u02BC\u02BC(note4);
						}
					}
				}
				else
				{
					if ((note2.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE != num || note2.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE == 0U) && num3 <= (double)this.\u02B4\u02B4\u02BF\u02B5\u02B4\u02B6\u02BA\u02B7\u02B2\u02B9\u02C1 && num3 >= (double)this.\u02B8\u02B2\u02B4\u02BF\u02C0\u02B8\u02C0\u02BA\u02B9\u02B2\u02B7)
					{
						this.\u02C1\u02BA\u02BE\u02B9\u02B8\u02BB\u02B7\u02BB\u02B7\u02B3\u02B5(note2, true);
						if (this.\u02B2\u02B9\u02B2\u02B4\u02B2\u02BA\u02B2\u02BA\u02C1\u02BA\u02B5 && this.combo > 0)
						{
							break;
						}
					}
					num = note2.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE;
				}
			}
		}
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x00081EFC File Offset: 0x000800FC
	public PlayerStats \u02B5\u02B2\u02BC\u02BE\u02BE\u02B2\u02BC\u02BD\u02B6\u02B5\u02B3(List<\u02B8\u02BB\u02B2\u02B5\u02C1\u02C1\u02BB\u02B7\u02B3\u02B4\u02B6> \u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD)
	{
		SectionNotesInfo[] array = new SectionNotesInfo[\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count];
		int i = 0;
		int num = 0;
		for (int j = 0; j < \u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count; j++)
		{
			uint num2 = 0U;
			int num3 = 0;
			int num4 = 0;
			if (j < \u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count - 1)
			{
				num2 = \u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[j + 1].\u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8;
			}
			while (i < this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count)
			{
				Note note = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0[i];
				if (num2 > 0U && note.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE >= num2)
				{
					break;
				}
				if (!note.\u02BF\u02B4\u02BD\u02C0\u02B5\u02B3\u02B8\u02B8\u02B8\u02BB\u02C0 || !note.\u02B5\u02C0\u02B3\u02C0\u02B6\u02B5\u02B8\u02BD\u02B6\u02B4\u02B4)
				{
					if (note.\u02BF\u02BF\u02B7\u02BE\u02B9\u02BC\u02B8\u02B7\u02C0\u02BC\u02B4)
					{
						num3++;
					}
					num4++;
				}
				i++;
			}
			array[j].numberOfHitNotes = num3;
			array[j].numberOfTotalNotes = num4;
			num += num4;
		}
		this.\u02BD\u02BC\u02B7\u02B6\u02C1\u02B6\u02BF\u02B5\u02BA\u02BF\u02C1 -= (this.\u02B2\u02C0\u02B5\u02BB\u02BF\u02B4\u02B9\u02B5\u02BF\u02BC\u02BB + this.\u02B4\u02C1\u02BF\u02B7\u02B9\u02C0\u02C0\u02B2\u02C0\u02B9\u02C0) * 50;
		return new PlayerStats
		{
			score = this.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5,
			soloScore = this.\u02C1\u02B4\u02BB\u02B3\u02B3\u02BB\u02C0\u02B4\u02C1\u02BB\u02BE,
			combo = this.\u02B7\u02C0\u02BE\u02BB\u02B2\u02B2\u02B3\u02BC\u02BD\u02B4\u02BE,
			notesHit = this.\u02B3\u02B5\u02C1\u02B7\u02C1\u02C1\u02BA\u02B2\u02B5\u02BD\u02B7,
			totalNotes = num,
			starPowersHit = this.\u02BE\u02BB\u02B7\u02B6\u02B9\u02BB\u02B3\u02B8\u02B2\u02B6\u02B9,
			sectionNotesInfo = array,
			starPowerAccrued = (int)(this.\u02B5\u02B5\u02B4\u02BB\u02B4\u02BE\u02B2\u02B5\u02B5\u02C0\u02B4 * 100f),
			timeInSP = (int)(this.\u02B5\u02B3\u02B4\u02BB\u02B2\u02BB\u02B9\u02BF\u02BB\u02B3\u02B4 * 100f),
			overstrums = this.overstrums,
			activations = this.\u02B8\u02BE\u02B5\u02B7\u02BF\u02B9\u02C1\u02B2\u02B8\u02B6\u02BF,
			noteScore = this.\u02BD\u02BC\u02B7\u02B6\u02C1\u02B6\u02BF\u02B5\u02BA\u02BF\u02C1,
			sustainScore = this.\u02B2\u02B2\u02C0\u02B3\u02B5\u02BD\u02BC\u02B5\u02B3\u02B7\u02B4,
			starPowerScore = this.\u02B6\u02B4\u02BB\u02BC\u02BA\u02B9\u02B8\u02B7\u02B5\u02C0\u02C1,
			comboScore = this.\u02B9\u02B7\u02B6\u02BE\u02BC\u02B2\u02C1\u02BF\u02B6\u02BA\u02BD,
			fretsBetweenNotes = this._ghosts,
			ghostNotes = this.\u02B2\u02C0\u02B5\u02BB\u02BF\u02B4\u02B9\u02B5\u02BF\u02BC\u02BB,
			accentNotes = this.\u02B4\u02C1\u02BF\u02B7\u02B9\u02C0\u02C0\u02B2\u02C0\u02B9\u02C0,
			accentNotesTotal = this.\u02B9\u02B2\u02BF\u02BD\u02B3\u02B7\u02BF\u02BA\u02BD\u02B9\u02B5,
			ghostNotesTotal = this.\u02B3\u02B9\u02B8\u02BF\u02C1\u02B9\u02B2\u02BC\u02B5\u02BB\u02BB
		};
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x000820E4 File Offset: 0x000802E4
	public virtual void \u02B8\u02BF\u02C0\u02BE\u02B2\u02BA\u02C0\u02B5\u02BE\u02B7\u02BD()
	{
		this._GameManager.\u02B3\u02BC\u02B6\u02C0\u02BF\u02B5\u02C1\u02B4\u02BA\u02BA\u02C1.Reset();
		this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6 = 0;
		BassAudioManager.Instance.\u02C1\u02BA\u02B3\u02B4\u02B7\u02B3\u02B4\u02B5\u02BD\u02C1\u02BF(this.playerStuff.playerInfo.\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1, true, -1f);
		this.\u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6 = false;
		this.\u02B7\u02BD\u02C1\u02B3\u02BD\u02B5\u02B6\u02B8\u02B8\u02B2\u02BF = false;
		this.combo = (this.\u02B7\u02C0\u02BE\u02BB\u02B2\u02B2\u02B3\u02BC\u02BD\u02B4\u02BE = (this.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 = (this.\u02C1\u02B4\u02BB\u02B3\u02B3\u02BB\u02C0\u02B4\u02C1\u02BB\u02BE = (this.\u02B3\u02B5\u02C1\u02B7\u02C1\u02C1\u02BA\u02B2\u02B5\u02BD\u02B7 = 0))));
		this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9 = 0;
		this.FCIndicator.SetActive(true);
		this.\u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD.Reset();
		this.noteRenderer.Reset();
		this.beatlines.Reset();
		this.\u02B9\u02B8\u02BE\u02B7\u02B4\u02BC\u02BB\u02BE\u02B6\u02BB\u02C0();
		this.comboCounter.\u02B3\u02BD\u02B2\u02B5\u02B9\u02BB\u02C0\u02B7\u02B8\u02B8\u02B6(this.combo);
		this.\u02C0\u02B2\u02B2\u02BA\u02B5\u02B9\u02BD\u02B6\u02BD\u02B6\u02B9 = false;
		this.neckController.\u02B5\u02BD\u02BA\u02BE\u02B4\u02B9\u02BD\u02B3\u02B9\u02BC\u02BE();
		this.\u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD = false;
		if (this.playerStuff.\u02C0\u02B5\u02B2\u02B2\u02BB\u02B8\u02B8\u02BD\u02B9\u02BD\u02C1())
		{
			this.inputBits = 0;
		}
		if (this.\u02BC\u02BD\u02BF\u02BA\u02B8\u02B5\u02B3\u02B8\u02BE\u02C0\u02BC.\u02B4\u02BE\u02B6\u02B2\u02B2\u02B7\u02B4\u02B8\u02BC\u02BB\u02B6 && this.\u02B3\u02B3\u02B2\u02B4\u02B6\u02BE\u02B2\u02B3\u02B2\u02B4\u02BC)
		{
			this.\u02BC\u02BD\u02BF\u02BA\u02B8\u02B5\u02B3\u02B8\u02BE\u02C0\u02BC.\u02C1\u02B9\u02BF\u02B2\u02BE\u02B6\u02BA\u02B3\u02BF\u02B9\u02BF();
		}
		if (this.\u02BC\u02BD\u02BF\u02BA\u02B8\u02B5\u02B3\u02B8\u02BE\u02C0\u02BC.\u02B4\u02BE\u02B6\u02B2\u02B2\u02B7\u02B4\u02B8\u02BC\u02BB\u02B6)
		{
			this.\u02B3\u02B3\u02B2\u02B4\u02B6\u02BE\u02B2\u02B3\u02B2\u02B4\u02BC = true;
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06000F5F RID: 3935 RVA: 0x0000E571 File Offset: 0x0000C771
	public Note \u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3
	{
		get
		{
			if (this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9 >= this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count)
			{
				return null;
			}
			return this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0[this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9];
		}
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x00082210 File Offset: 0x00080410
	protected BasePlayer()
	{
		this.\u02B2\u02BF\u02BD\u02B2\u02C0\u02BD\u02BA\u02B2\u02BC\u02B5\u02B6 = true;
		this.\u02B2\u02BE\u02BE\u02B8\u02B6\u02BE\u02BA\u02BA\u02B5\u02B3\u02BC = 0.07f;
		this.\u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE = true;
		this.\u02BA\u02BC\u02BB\u02B3\u02BC\u02B3\u02B2\u02C0\u02BC\u02B8\u02BA = 0.5f;
		this.\u02B9\u02B3\u02C1\u02B6\u02BC\u02B4\u02C1\u02B2\u02B3\u02BC\u02C1 = 0.0069f;
		this.\u02BD\u02B2\u02B9\u02B8\u02C0\u02B4\u02BF\u02BF\u02B7\u02BF\u02B3 = 0.0277f;
		this.\u02B5\u02B3\u02BE\u02B7\u02BA\u02BF\u02BD\u02BC\u02B9\u02C1\u02B8 = 0.045f;
		this.\u02B8\u02C1\u02BF\u02C0\u02B3\u02B9\u02B6\u02B2\u02B8\u02B7\u02BE = new List<float>(128);
		this.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD = new Note(0f, 0f, 0, \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Strum, Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE, 0U, 0);
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00082294 File Offset: 0x00080494
	[CompilerGenerated]
	private void \u02C1\u02BA\u02BE\u02B9\u02B8\u02BB\u02B7\u02BB\u02B7\u02B3\u02B5(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, bool \u02B3\u02BF\u02C1\u02B5\u02C0\u02BC\u02BC\u02B4\u02B3\u02BF\u02B2)
	{
		if (\u02B3\u02BF\u02C1\u02B5\u02C0\u02BC\u02BC\u02B4\u02B3\u02BF\u02B2 && this.\u02B8\u02B5\u02B8\u02BF\u02BE\u02BD\u02BB\u02BD\u02BB\u02BC\u02B6.Length == this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6)
		{
			Array.Resize<Note>(ref this.\u02B8\u02B5\u02B8\u02BF\u02BE\u02BD\u02BB\u02BD\u02BB\u02BC\u02B6, this.\u02B8\u02B5\u02B8\u02BF\u02BE\u02BD\u02BB\u02BD\u02BB\u02BC\u02B6.Length * 2);
		}
		this.\u02B8\u02B5\u02B8\u02BF\u02BE\u02BD\u02BB\u02BD\u02BB\u02BC\u02B6[this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6] = \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2;
		this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6++;
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x0000E599 File Offset: 0x0000C799
	public int ghosts()
	{
		return this.\u02B3\u02B9\u02B8\u02BF\u02C1\u02B9\u02B2\u02BC\u02B5\u02BB\u02BB;
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x000822E8 File Offset: 0x000804E8
	public static BasePlayer.JudgementAndFloat CalculateJudgementAndScore(float inaccuracy)
	{
		float[] array = cUtilityClass.judgeTimings(cUtilityClass.useJudgeLevel);
		cUtilityClass.WeightSystem weightSystem = cUtilityClass.weightSystem;
		float[] array2;
		if (weightSystem != cUtilityClass.WeightSystem.Custom)
		{
			if (weightSystem != cUtilityClass.WeightSystem.Etterna)
			{
				array2 = new float[] { 1.1f, 1.1f, 1.081f, 0.72f, 0.28f, -0.55f, -1.1f, -0.7f };
			}
			else
			{
				array2 = new float[] { 1.1f, 1.1f, 0.74f, 0.36f, 0f, -0.28f, -0.55f, -1.1f };
			}
		}
		else
		{
			array2 = new float[] { 1.1f, 1.1f, 1f, 0.5f, 0.5f, 0.25f, 0.125f, 0f };
		}
		float[] array3 = array2;
		int num = 0;
		BasePlayer.JudgementAndFloat judgementAndFloat;
		judgementAndFloat.inacc = Mathf.Abs(inaccuracy);
		if (inaccuracy == -1f)
		{
			judgementAndFloat.inacc = 0.07f;
			judgementAndFloat.judgement = BasePlayer.Judgement.Miss;
			judgementAndFloat.val = array3[6];
			return judgementAndFloat;
		}
		if (inaccuracy <= 0.065f)
		{
			if (Mathf.Abs(inaccuracy) < array[0])
			{
				judgementAndFloat.judgement = BasePlayer.Judgement.Marvelous;
				judgementAndFloat.val = Mathf.Lerp(array3[num], array3[num + 1], inaccuracy / array3[num + 1]);
				return judgementAndFloat;
			}
			num++;
			if (Mathf.Abs(inaccuracy) < array[1])
			{
				judgementAndFloat.judgement = BasePlayer.Judgement.Perfect;
				judgementAndFloat.val = Mathf.Lerp(array3[num], array3[num + 1], inaccuracy / array3[num + 1]);
				return judgementAndFloat;
			}
			num++;
			if (Mathf.Abs(inaccuracy) < array[2])
			{
				judgementAndFloat.judgement = BasePlayer.Judgement.Great;
				judgementAndFloat.val = Mathf.Lerp(array3[num], array3[num + 1], inaccuracy / array3[num + 1]);
				return judgementAndFloat;
			}
			num++;
			if (Mathf.Abs(inaccuracy) < array[3])
			{
				judgementAndFloat.judgement = BasePlayer.Judgement.Good;
				judgementAndFloat.val = Mathf.Lerp(array3[num], array3[num + 1], inaccuracy / array3[num + 1]);
				return judgementAndFloat;
			}
			num++;
			if (Mathf.Abs(inaccuracy) < array[4])
			{
				judgementAndFloat.judgement = BasePlayer.Judgement.Bad;
				judgementAndFloat.val = Mathf.Lerp(array3[num], array3[num + 1], inaccuracy / array3[num + 1]);
				return judgementAndFloat;
			}
		}
		judgementAndFloat.judgement = BasePlayer.Judgement.Early;
		judgementAndFloat.val = array3[7];
		return judgementAndFloat;
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x0000E5A1 File Offset: 0x0000C7A1
	public ushort getInputs()
	{
		return this.inputBits;
	}

	// Token: 0x04000B7D RID: 2941
	[SerializeField]
	public BaseNoteRenderer noteRenderer;

	// Token: 0x04000B7E RID: 2942
	[NonSerialized]
	public GameManager _GameManager;

	// Token: 0x04000B7F RID: 2943
	[SerializeField]
	protected BaseNeckController neckController;

	// Token: 0x04000B80 RID: 2944
	[SerializeField]
	public Camera camera;

	// Token: 0x04000B81 RID: 2945
	[SerializeField]
	public ComboColor comboCounter;

	// Token: 0x04000B82 RID: 2946
	[SerializeField]
	protected HealthContainer healthContainer;

	// Token: 0x04000B83 RID: 2947
	[SerializeField]
	protected GameObject FCIndicator;

	// Token: 0x04000B84 RID: 2948
	protected DesaturateSprite[] \u02B5\u02BE\u02B5\u02B8\u02B8\u02B4\u02BF\u02BC\u02B4\u02B8\u02B2;

	// Token: 0x04000B85 RID: 2949
	public SoloCounter \u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD;

	// Token: 0x04000B86 RID: 2950
	public Countdown \u02B4\u02BA\u02B4\u02BF\u02B6\u02B9\u02B5\u02BA\u02C0\u02BD\u02BB;

	// Token: 0x04000B87 RID: 2951
	public TextMeshProUGUI playerNameTextBox;

	// Token: 0x04000B88 RID: 2952
	public GameObject \u02B7\u02B3\u02B9\u02B5\u02B7\u02BC\u02C1\u02BB\u02B7\u02B7\u02B4;

	// Token: 0x04000B89 RID: 2953
	public TextMeshProUGUI \u02BB\u02BC\u02B9\u02BF\u02C1\u02B3\u02BD\u02B7\u02BE\u02BC\u02B4;

	// Token: 0x04000B8A RID: 2954
	public bool \u02B2\u02BF\u02BD\u02B2\u02C0\u02BD\u02BA\u02B2\u02BC\u02B5\u02B6;

	// Token: 0x04000B8B RID: 2955
	[HideInInspector]
	public \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 playerStuff;

	// Token: 0x04000B8C RID: 2956
	[SerializeField]
	protected SPBar spBar;

	// Token: 0x04000B8D RID: 2957
	[SerializeField]
	public GameObject[] highwayObjects;

	// Token: 0x04000B8E RID: 2958
	public const int \u02BA\u02BE\u02C0\u02B4\u02B4\u02BE\u02B3\u02B3\u02BD\u02C0\u02BB = 50;

	// Token: 0x04000B8F RID: 2959
	public HighwayScroll highway;

	// Token: 0x04000B90 RID: 2960
	public CameraShake \u02C0\u02BE\u02B4\u02BF\u02C1\u02C1\u02B3\u02BF\u02BE\u02B2\u02B5;

	// Token: 0x04000B91 RID: 2961
	public \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B9\u02B2\u02BC\u02BA\u02B6\u02B7\u02BE\u02B6\u02BF\u02BA\u02B9 \u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2;

	// Token: 0x04000B92 RID: 2962
	public List<Note> \u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0;

	// Token: 0x04000B93 RID: 2963
	public List<\u02B4\u02C1\u02B5\u02BD\u02BD\u02B7\u02BA\u02BB\u02B4\u02C0\u02B8> \u02B4\u02B7\u02BC\u02C1\u02B2\u02B8\u02B2\u02BD\u02BD\u02BC\u02BF;

	// Token: 0x04000B94 RID: 2964
	public List<\u02B2\u02BA\u02B2\u02B4\u02B6\u02B4\u02B6\u02BB\u02BA\u02B7\u02B4> \u02B2\u02BB\u02B3\u02B8\u02B5\u02B2\u02C0\u02BF\u02BA\u02B4\u02BC;

	// Token: 0x04000B95 RID: 2965
	public float \u02B4\u02B4\u02BF\u02B5\u02B4\u02B6\u02BA\u02B7\u02B2\u02B9\u02C1;

	// Token: 0x04000B96 RID: 2966
	public float \u02B8\u02B2\u02B4\u02BF\u02C0\u02B8\u02C0\u02BA\u02B9\u02B2\u02B7;

	// Token: 0x04000B97 RID: 2967
	public float \u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF;

	// Token: 0x04000B98 RID: 2968
	protected float \u02B2\u02BE\u02BE\u02B8\u02B6\u02BE\u02BA\u02BA\u02B5\u02B3\u02BC;

	// Token: 0x04000B99 RID: 2969
	protected float \u02BF\u02BE\u02B8\u02C1\u02BE\u02C1\u02C0\u02C0\u02BB\u02BB\u02BC;

	// Token: 0x04000B9A RID: 2970
	protected bool \u02B2\u02B3\u02B6\u02B9\u02B6\u02B8\u02B3\u02BE\u02BE\u02B3\u02B6;

	// Token: 0x04000B9B RID: 2971
	protected bool \u02B2\u02B9\u02B2\u02B4\u02B2\u02BA\u02B2\u02BA\u02C1\u02BA\u02B5;

	// Token: 0x04000B9C RID: 2972
	public bool \u02B3\u02BC\u02B4\u02B8\u02BB\u02B8\u02B2\u02C0\u02C0\u02B3\u02C0;

	// Token: 0x04000B9D RID: 2973
	public bool \u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB;

	// Token: 0x04000B9E RID: 2974
	public bool \u02BD\u02B8\u02B6\u02B2\u02B8\u02B6\u02BD\u02C0\u02BD\u02B8\u02BB;

	// Token: 0x04000B9F RID: 2975
	public bool \u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8;

	// Token: 0x04000BA0 RID: 2976
	public bool \u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0;

	// Token: 0x04000BA1 RID: 2977
	public bool \u02BB\u02BD\u02C0\u02B5\u02B8\u02B3\u02BD\u02B6\u02B7\u02BB\u02B7;

	// Token: 0x04000BA2 RID: 2978
	public bool \u02B5\u02C1\u02BA\u02B9\u02B6\u02B7\u02B9\u02BC\u02B7\u02BD\u02B4;

	// Token: 0x04000BA3 RID: 2979
	protected ushort inputBits;

	// Token: 0x04000BA4 RID: 2980
	protected ushort \u02BA\u02BD\u02B4\u02BB\u02B8\u02C1\u02B2\u02B3\u02B2\u02BC\u02B3;

	// Token: 0x04000BA5 RID: 2981
	[HideInInspector]
	public bool \u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE;

	// Token: 0x04000BA6 RID: 2982
	[HideInInspector]
	public bool \u02C0\u02B2\u02B2\u02BA\u02B5\u02B9\u02BD\u02B6\u02BD\u02B6\u02B9;

	// Token: 0x04000BA7 RID: 2983
	[HideInInspector]
	public bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF;

	// Token: 0x04000BA8 RID: 2984
	public bool \u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6;

	// Token: 0x04000BA9 RID: 2985
	protected bool \u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD;

	// Token: 0x04000BAA RID: 2986
	protected bool \u02B7\u02BD\u02C1\u02B3\u02BD\u02B5\u02B6\u02B8\u02B8\u02B2\u02BF;

	// Token: 0x04000BAB RID: 2987
	protected bool \u02C0\u02B4\u02B5\u02B8\u02B6\u02B8\u02B2\u02BE\u02B6\u02B5\u02B2;

	// Token: 0x04000BAC RID: 2988
	protected bool \u02C1\u02BC\u02BC\u02C1\u02B2\u02BF\u02C1\u02BE\u02BE\u02BB\u02B4;

	// Token: 0x04000BAD RID: 2989
	protected bool \u02BF\u02C1\u02BF\u02BE\u02C1\u02B2\u02BC\u02BE\u02B3\u02BB\u02B8;

	// Token: 0x04000BAE RID: 2990
	protected int \u02B6\u02BC\u02BD\u02B3\u02B6\u02B3\u02BD\u02B9\u02BF\u02BA\u02B6;

	// Token: 0x04000BAF RID: 2991
	protected bool \u02B5\u02BB\u02BA\u02B2\u02C1\u02BB\u02B6\u02B5\u02BE\u02B9\u02BF;

	// Token: 0x04000BB0 RID: 2992
	[HideInInspector]
	public bool \u02BF\u02B7\u02B6\u02B6\u02BE\u02BE\u02C0\u02C0\u02BB\u02B2\u02C1;

	// Token: 0x04000BB1 RID: 2993
	protected int \u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7;

	// Token: 0x04000BB2 RID: 2994
	[HideInInspector]
	public int \u02BE\u02BB\u02B7\u02B6\u02B9\u02BB\u02B3\u02B8\u02B2\u02B6\u02B9;

	// Token: 0x04000BB3 RID: 2995
	protected int \u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9;

	// Token: 0x04000BB4 RID: 2996
	protected Note[] \u02B8\u02B5\u02B8\u02BF\u02BE\u02BD\u02BB\u02BD\u02BB\u02BC\u02B6;

	// Token: 0x04000BB5 RID: 2997
	protected float \u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5;

	// Token: 0x04000BB6 RID: 2998
	protected float \u02BA\u02BC\u02BB\u02B3\u02BC\u02B3\u02B2\u02C0\u02BC\u02B8\u02BA;

	// Token: 0x04000BB7 RID: 2999
	protected float \u02B9\u02B3\u02C1\u02B6\u02BC\u02B4\u02C1\u02B2\u02B3\u02BC\u02C1;

	// Token: 0x04000BB8 RID: 3000
	protected float \u02BD\u02B2\u02B9\u02B8\u02C0\u02B4\u02BF\u02BF\u02B7\u02BF\u02B3;

	// Token: 0x04000BB9 RID: 3001
	protected float \u02B5\u02B3\u02BE\u02B7\u02BA\u02BF\u02BD\u02BC\u02B9\u02C1\u02B8;

	// Token: 0x04000BBA RID: 3002
	private bool \u02C0\u02BE\u02BD\u02B3\u02C0\u02B9\u02B5\u02BF\u02BC\u02BC\u02B8;

	// Token: 0x04000BBB RID: 3003
	private float \u02B5\u02B5\u02B4\u02BB\u02B4\u02BE\u02B2\u02B5\u02B5\u02C0\u02B4;

	// Token: 0x04000BBC RID: 3004
	protected float \u02BB\u02B3\u02B2\u02C0\u02B3\u02BC\u02B3\u02B5\u02BB\u02C0\u02B6;

	// Token: 0x04000BBD RID: 3005
	protected List<float> \u02B8\u02C1\u02BF\u02C0\u02B3\u02B9\u02B6\u02B2\u02B8\u02B7\u02BE;

	// Token: 0x04000BBE RID: 3006
	[HideInInspector]
	public int combo;

	// Token: 0x04000BBF RID: 3007
	[HideInInspector]
	public int \u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6;

	// Token: 0x04000BC0 RID: 3008
	[HideInInspector]
	public int \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;

	// Token: 0x04000BC1 RID: 3009
	[HideInInspector]
	public int \u02B7\u02C0\u02BE\u02BB\u02B2\u02B2\u02B3\u02BC\u02BD\u02B4\u02BE;

	// Token: 0x04000BC2 RID: 3010
	[HideInInspector]
	public int \u02B3\u02B5\u02C1\u02B7\u02C1\u02C1\u02BA\u02B2\u02B5\u02BD\u02B7;

	// Token: 0x04000BC3 RID: 3011
	[HideInInspector]
	public int \u02C1\u02B4\u02BB\u02B3\u02B3\u02BB\u02C0\u02B4\u02C1\u02BB\u02BE;

	// Token: 0x04000BC4 RID: 3012
	public int overstrums;

	// Token: 0x04000BC5 RID: 3013
	private int \u02B8\u02BE\u02B5\u02B7\u02BF\u02B9\u02C1\u02B2\u02B8\u02B6\u02BF;

	// Token: 0x04000BC6 RID: 3014
	private float \u02B5\u02B3\u02B4\u02BB\u02B2\u02BB\u02B9\u02BF\u02BB\u02B3\u02B4;

	// Token: 0x04000BC7 RID: 3015
	private int \u02BD\u02BC\u02B7\u02B6\u02C1\u02B6\u02BF\u02B5\u02BA\u02BF\u02C1;

	// Token: 0x04000BC8 RID: 3016
	private int \u02B2\u02B2\u02C0\u02B3\u02B5\u02BD\u02BC\u02B5\u02B3\u02B7\u02B4;

	// Token: 0x04000BC9 RID: 3017
	private int \u02B9\u02B7\u02B6\u02BE\u02BC\u02B2\u02C1\u02BF\u02B6\u02BA\u02BD;

	// Token: 0x04000BCA RID: 3018
	private int \u02B6\u02B4\u02BB\u02BC\u02BA\u02B9\u02B8\u02B7\u02B5\u02C0\u02C1;

	// Token: 0x04000BCB RID: 3019
	protected int _ghosts;

	// Token: 0x04000BCC RID: 3020
	protected int \u02B2\u02C0\u02B5\u02BB\u02BF\u02B4\u02B9\u02B5\u02BF\u02BC\u02BB;

	// Token: 0x04000BCD RID: 3021
	protected int \u02B4\u02C1\u02BF\u02B7\u02B9\u02C0\u02C0\u02B2\u02C0\u02B9\u02C0;

	// Token: 0x04000BCE RID: 3022
	protected int \u02B3\u02B9\u02B8\u02BF\u02C1\u02B9\u02B2\u02BC\u02B5\u02BB\u02BB;

	// Token: 0x04000BCF RID: 3023
	protected int \u02B9\u02B2\u02BF\u02BD\u02B3\u02B7\u02BF\u02BA\u02BD\u02B9\u02B5;

	// Token: 0x04000BD0 RID: 3024
	[SerializeField]
	private SpNeckRenderer spNeckRenderer;

	// Token: 0x04000BD1 RID: 3025
	public BeatRenderer beatlines;

	// Token: 0x04000BD2 RID: 3026
	public BrutalFader \u02BC\u02BD\u02BF\u02BA\u02B8\u02B5\u02B3\u02B8\u02BE\u02C0\u02BC;

	// Token: 0x04000BD3 RID: 3027
	[SerializeField]
	protected TrackSidebarColoring trackSidebarLeft;

	// Token: 0x04000BD4 RID: 3028
	[SerializeField]
	protected TrackSidebarColoring trackSidebarRight;

	// Token: 0x04000BD5 RID: 3029
	private \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6;

	// Token: 0x04000BD6 RID: 3030
	public \u02BE\u02B9\u02B7\u02C0\u02BC\u02BC\u02C1\u02BD\u02BC\u02BD\u02BE \u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2;

	// Token: 0x04000BD7 RID: 3031
	protected bool \u02B3\u02C1\u02BD\u02BF\u02B4\u02B2\u02BC\u02BF\u02BC\u02C1\u02BC;

	// Token: 0x04000BD8 RID: 3032
	protected bool \u02B8\u02B3\u02B5\u02B5\u02C1\u02B4\u02BA\u02BF\u02BA\u02BC\u02B3;

	// Token: 0x04000BD9 RID: 3033
	private bool \u02B3\u02B3\u02B2\u02B4\u02B6\u02BE\u02B2\u02B3\u02B2\u02B4\u02BC;

	// Token: 0x04000BDA RID: 3034
	private int \u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC;

	// Token: 0x04000BDB RID: 3035
	public Note \u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD;

	// Token: 0x04000BDC RID: 3036
	public static float interval;

	// Token: 0x04000BDD RID: 3037
	private float elapsedtime;

	// Token: 0x04000BDE RID: 3038
	private bool lastFrame;

	// Token: 0x04000BDF RID: 3039
	public static bool autoEnabled;

	// Token: 0x04000BE0 RID: 3040
	public BasePlayer.PrecisionData precision;

	// Token: 0x04000BE1 RID: 3041
	public static float lastOffset;

	// Token: 0x04000BE2 RID: 3042
	public static float lastVal;

	// Token: 0x04000BE3 RID: 3043
	private float ticker;

	// Token: 0x04000BE4 RID: 3044
	private bool missFromWindow;

	// Token: 0x04000BE5 RID: 3045
	private bool highwayDeactivated;

	// Token: 0x04000BE6 RID: 3046
	private bool showBeatlines;

	// Token: 0x04000BE7 RID: 3047
	private bool showHighway;

	// Token: 0x04000BE8 RID: 3048
	private bool showHighwaySide;

	// Token: 0x04000BE9 RID: 3049
	private bool showFretStrings;

	// Token: 0x0200015C RID: 348
	public enum Judgement
	{
		// Token: 0x04000BEB RID: 3051
		Perfect = 1,
		// Token: 0x04000BEC RID: 3052
		Great,
		// Token: 0x04000BED RID: 3053
		Good,
		// Token: 0x04000BEE RID: 3054
		Bad,
		// Token: 0x04000BEF RID: 3055
		Early,
		// Token: 0x04000BF0 RID: 3056
		Miss,
		// Token: 0x04000BF1 RID: 3057
		Marvelous = 0
	}

	// Token: 0x0200015D RID: 349
	public struct PrecisionData
	{
		// Token: 0x06000F65 RID: 3941 RVA: 0x000824C0 File Offset: 0x000806C0
		public PrecisionData()
		{
			this.m_totalInacc = 0f;
			this.avgInaccuracyCache = 0f;
			this.m_precisionCache = 0f;
			this.m_lastJudgement = BasePlayer.Judgement.Perfect;
			this.totalJudgements = 0;
			this.m_totalPrecision = 0.0;
			this.needsToRecalculate = false;
			this.judgements = new int[6];
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00082520 File Offset: 0x00080720
		public void Clear()
		{
			this.m_totalInacc = 0f;
			this.judgements = new int[6];
			this.totalJudgements = 0;
			this.m_precisionCache = 0f;
			this.totalPrecision = 0.0;
			this.needsToRecalculate = false;
			this.avgInaccuracyCache = 0f;
			this.m_lastJudgement = BasePlayer.Judgement.Perfect;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x0000E5A9 File Offset: 0x0000C7A9
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x0000E5B1 File Offset: 0x0000C7B1
		private double totalPrecision
		{
			[CompilerGenerated]
			readonly get
			{
				return this.m_totalPrecision;
			}
			[CompilerGenerated]
			set
			{
				this.needsToRecalculate = true;
				this.m_totalPrecision = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x0000E5C1 File Offset: 0x0000C7C1
		public float Accuracy
		{
			get
			{
				if (this.needsToRecalculate)
				{
					this.m_precisionCache = (float)(this.totalPrecision / (double)this.totalJudgements);
				}
				return this.m_precisionCache;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00082580 File Offset: 0x00080780
		public string LastJudgement
		{
			get
			{
				switch (this.m_lastJudgement)
				{
				case BasePlayer.Judgement.Marvelous:
					return "<color=#33ffffff>Flawless!";
				case BasePlayer.Judgement.Perfect:
					return "<color=yellow>Perfect!";
				case BasePlayer.Judgement.Great:
					return "<color=#ff33ffff>Great!";
				case BasePlayer.Judgement.Good:
					return "<color=#22ff22ff>Good";
				case BasePlayer.Judgement.Bad:
					return "<color=orange>Bad";
				case BasePlayer.Judgement.Early:
					return "Early";
				default:
					return "<color=#aaaaaaaa>Miss";
				}
			}
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x000825E0 File Offset: 0x000807E0
		public void AddJudgement(BasePlayer.JudgementAndFloat jaf)
		{
			this.totalJudgements++;
			this.totalPrecision += (double)jaf.val;
			this.m_lastJudgement = jaf.judgement;
			this.m_totalInacc += jaf.inacc;
			BasePlayer.lastVal = jaf.val;
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0000E5E6 File Offset: 0x0000C7E6
		public float avgInaccuracy
		{
			get
			{
				if (this.needsToRecalculate)
				{
					this.avgInaccuracyCache = this.m_totalInacc / (float)this.totalJudgements;
				}
				return this.avgInaccuracyCache;
			}
		}

		// Token: 0x04000BF2 RID: 3058
		public int[] judgements;

		// Token: 0x04000BF3 RID: 3059
		public int totalJudgements;

		// Token: 0x04000BF4 RID: 3060
		private double m_totalPrecision;

		// Token: 0x04000BF5 RID: 3061
		private bool needsToRecalculate;

		// Token: 0x04000BF6 RID: 3062
		public float m_precisionCache;

		// Token: 0x04000BF7 RID: 3063
		public BasePlayer.Judgement m_lastJudgement;

		// Token: 0x04000BF8 RID: 3064
		public float m_totalInacc;

		// Token: 0x04000BF9 RID: 3065
		public float avgInaccuracyCache;
	}

	// Token: 0x0200015E RID: 350
	public struct JudgementAndFloat
	{
		// Token: 0x06000F6D RID: 3949 RVA: 0x0000E60A File Offset: 0x0000C80A
		public JudgementAndFloat()
		{
			this.judgement = BasePlayer.Judgement.Marvelous;
			this.val = 0f;
			this.inacc = 0f;
		}

		// Token: 0x04000BFA RID: 3066
		public BasePlayer.Judgement judgement;

		// Token: 0x04000BFB RID: 3067
		public float val;

		// Token: 0x04000BFC RID: 3068
		public float inacc;
	}
}
