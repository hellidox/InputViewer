using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StrikeCore;
using TMPro;
using UnityEngine;

public abstract class BasePlayer : MonoBehaviour
{
	public bool \u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9
	{
		get
		{
			return this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF && SettingsController.\u02C1\u02BF\u02BC\u02B4\u02BE\u02B7\u02BD\u02BC\u02B5\u02BC\u02B7;
		}
	}

	public int \u02B9\u02B8\u02B7\u02BA\u02B6\u02BA\u02B4\u02B9\u02B6\u02BF\u02C1
	{
		get
		{
			return this.\u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7;
		}
	}

	public int \u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5
	{
		get
		{
			return this.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 + this.\u02C1\u02B4\u02BB\u02B3\u02B3\u02BB\u02C0\u02B4\u02C1\u02BB\u02BE;
		}
	}

	public int ghostCounter
	{
		get
		{
			return this._ghosts;
		}
	}

	public int \u02BB\u02BD\u02B5\u02B2\u02BF\u02B8\u02C1\u02B3\u02B4\u02B3\u02B7
	{
		get
		{
			return this.\u02B2\u02C0\u02B5\u02BB\u02BF\u02B4\u02B9\u02B5\u02BF\u02BC\u02BB + this.\u02B4\u02C1\u02BF\u02B7\u02B9\u02C0\u02C0\u02B2\u02C0\u02B9\u02C0;
		}
	}

	public int \u02B4\u02BB\u02BA\u02BA\u02BB\u02B7\u02C0\u02BA\u02BF\u02B9\u02C1
	{
		get
		{
			return this.\u02B3\u02B9\u02B8\u02BF\u02C1\u02B9\u02B2\u02BC\u02B5\u02BB\u02BB + this.\u02B9\u02B2\u02BF\u02BD\u02B3\u02B7\u02BF\u02BA\u02BD\u02B9\u02B5;
		}
	}

	protected void \u02BD\u02B8\u02B2\u02BD\u02B2\u02BF\u02BB\u02C1\u02BC\u02B7\u02B6()
	{
		\u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7[] componentsInChildren = base.GetComponentsInChildren<\u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6 = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6;
		}
	}

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
			this.healthGain = 0f;
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
		this.gameManager = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.beatlines = base.GetComponent<BeatRenderer>();
		this.\u02B4\u02B4\u02BF\u02B5\u02B4\u02B6\u02BA\u02B7\u02B2\u02B9\u02C1 = this.hitWindow;
		this.\u02B8\u02B2\u02B4\u02BF\u02C0\u02B8\u02C0\u02BA\u02B9\u02B2\u02B7 = -this.hitWindow;
		this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF = this.hitWindow * 2f;
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
		this.hittableNotes = new Note[20];
		this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6 = new \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9();
		if (this.playerStuff.playerInfo.colorProfileName == "Random" && !CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.playerStuff.playerInfo.\u02B4\u02BF\u02B9\u02BF\u02B3\u02B9\u02B9\u02B6\u02B5\u02BF\u02BB();
		}
		this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.InitializeColorSettings(this.playerStuff.playerInfo.colorSettings);
		this.\u02BD\u02B8\u02B2\u02BD\u02B2\u02BF\u02BB\u02C1\u02BC\u02B7\u02B6();
	}

	protected virtual void \u02B4\u02C0\u02BF\u02BA\u02BD\u02BA\u02B3\u02B8\u02B7\u02B7\u02BA()
	{
		float num = ((GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA != \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.None) ? 0f : 1f);
		DesaturateSprite[] u02B5_u02BE_u02B5_u02B8_u02B8_u02B4_u02BF_u02BC_u02B4_u02B8_u02B = this.\u02B5\u02BE\u02B5\u02B8\u02B8\u02B4\u02BF\u02BC\u02B4\u02B8\u02B2;
		for (int i = 0; i < u02B5_u02BE_u02B5_u02B8_u02B8_u02B4_u02BF_u02BC_u02B4_u02B8_u02B.Length; i++)
		{
			u02B5_u02BE_u02B5_u02B8_u02B8_u02B4_u02BF_u02BC_u02B4_u02B8_u02B[i].\u02C0\u02B8\u02C0\u02BC\u02C0\u02B9\u02B5\u02B2\u02B4\u02B3\u02BD(num);
		}
	}

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
		if (this.playerStuff.playerInfo.displayName || GlobalHelper.showJudgementsUnderFretboard || this.playerStuff.playerInfo.isRemotePlayer)
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
				if (this.gameManager.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD <= 2 && this.gameManager.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 == GameMode.Versus)
				{
					this.\u02B7\u02B3\u02B9\u02B5\u02B7\u02BC\u02C1\u02BB\u02B7\u02B7\u02B4.GetComponent<RectTransform>().localPosition = new Vector3(this.\u02B7\u02B3\u02B9\u02B5\u02B7\u02BC\u02C1\u02BB\u02B7\u02B7\u02B4.GetComponent<RectTransform>().localPosition.x, 408f, 277f);
				}
			}
			else
			{
				this.\u02B7\u02B3\u02B9\u02B5\u02B7\u02BC\u02C1\u02BB\u02B7\u02B7\u02B4.SetActive(false);
			}
		}
		this.\u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = this.gameManager;
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
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && this.playerStuff.\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4 && SettingsController.only_show_local_players && !\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02BD\u02BC\u02B2\u02B8\u02BC\u02B5\u02B5\u02BB\u02BC\u02B6)
		{
			base.gameObject.SetActive(false);
		}
		if (!this.playerStuff.playerInfo.HasModChartModifier)
		{
			if (GlobalHelper.showBeatlines)
			{
				this.beatlines.enabled = true;
				this.showBeatlines = true;
			}
			else
			{
				this.beatlines.enabled = false;
				this.showBeatlines = false;
			}
			if (GlobalHelper.showHighway)
			{
				this.highway.gameObject.SetActive(true);
				this.showHighway = true;
			}
			else
			{
				this.highway.gameObject.SetActive(false);
				this.showHighway = false;
			}
			if (GlobalHelper.showHighwaySide)
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
			if (GlobalHelper.showFretStrings)
			{
				this.showFretStrings = true;
				this.neckController.ShowFretStrings();
			}
			else
			{
				this.showFretStrings = false;
				this.neckController.HideFretStrings();
			}
			if (GlobalHelper.showHPBar)
			{
				this.healthContainer.gameObject.SetActive(true);
				return;
			}
			this.healthContainer.gameObject.SetActive(false);
		}
	}

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

	public virtual void \u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5()
	{
		if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			\u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B9\u02B2\u02BC\u02BA\u02B6\u02B7\u02BE\u02B6\u02BF\u02BA\u02B9 u02B9_u02B2_u02BC_u02BA_u02B6_u02B7_u02BE_u02B6_u02BF_u02BA_u02B = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B9\u02B9\u02BE\u02B4\u02B3\u02B6\u02BC\u02B5\u02B3\u02BC\u02BC(this, this.gameManager.song, true);
			this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0 = u02B9_u02B2_u02BC_u02BA_u02B6_u02B7_u02BE_u02B6_u02BF_u02BA_u02B.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0;
			this.\u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2 = u02B9_u02B2_u02BC_u02BA_u02B6_u02B7_u02BE_u02B6_u02BF_u02BA_u02B;
			this.\u02C1\u02B2\u02B7\u02B9\u02C0\u02B8\u02B7\u02BD\u02BD\u02B7\u02B3();
			this.\u02B2\u02BB\u02B3\u02B8\u02B5\u02B2\u02C0\u02BF\u02BA\u02B4\u02BC = u02B9_u02B2_u02BC_u02BA_u02B6_u02B7_u02BE_u02B6_u02BF_u02BA_u02B.\u02B2\u02BB\u02B3\u02B8\u02B5\u02B2\u02C0\u02BF\u02BA\u02B4\u02BC;
			this.\u02B4\u02B7\u02BC\u02C1\u02B2\u02B8\u02B2\u02BD\u02BD\u02BC\u02BF = u02B9_u02B2_u02BC_u02BA_u02B6_u02B7_u02BE_u02B6_u02BF_u02BA_u02B.\u02B4\u02B7\u02BC\u02C1\u02B2\u02B8\u02B2\u02BD\u02BD\u02BC\u02BF;
			this.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2 = u02B9_u02B2_u02BC_u02BA_u02B6_u02B7_u02BE_u02B6_u02BF_u02BA_u02B.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2;
		}
		this.\u02B4\u02BA\u02B4\u02BF\u02B6\u02B9\u02B5\u02BA\u02C0\u02BD\u02BB.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = this.gameManager;
		this.\u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD.\u02C1\u02BD\u02B3\u02B7\u02BE\u02C0\u02BE\u02B4\u02BD\u02B3\u02BF(this.gameManager.song);
	}

	protected abstract void UpdateInputs();

	protected abstract void UpdateAI();

	protected abstract bool \u02B7\u02BF\u02BA\u02BF\u02C1\u02B4\u02B5\u02BD\u02C1\u02B8\u02B6(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, ushort \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4);

	public virtual void UpdateRemotePlayer(\u02C0\u02C1\u02B2\u02B3\u02B8\u02B7\u02B2\u02B3\u02C0\u02BF\u02BD \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA)
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
			this.buttonsPressed = 0;
		}
	}

	public virtual void \u02B5\u02B5\u02BA\u02BB\u02B7\u02BF\u02BC\u02B9\u02B5\u02BE\u02BF(\u02C0\u02C1\u02B2\u02B3\u02B8\u02B7\u02B2\u02B3\u02C0\u02BF\u02BD \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA)
	{
		\u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02BC\u02B2\u02B9\u02B9\u02B9\u02B4\u02BB\u02BF\u02BF\u02BE\u02BE = this.combo;
		\u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5 = this.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
		\u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02B3\u02BF\u02B4\u02B5\u02B4\u02BE\u02C0\u02B8\u02B3\u02B6\u02B6 = this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5;
	}

	public void \u02B2\u02BD\u02B2\u02C0\u02B8\u02C1\u02B4\u02C0\u02BA\u02BE\u02BE()
	{
		this.\u02B7\u02BD\u02C1\u02B3\u02BD\u02B5\u02B6\u02B8\u02B8\u02B2\u02BF = true;
		this.FCIndicator.SetActive(false);
	}

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

	protected virtual float \u02B9\u02B9\u02B4\u02C1\u02B9\u02B6\u02B2\u02BA\u02B2\u02B2\u02BF(float \u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4)
	{
		return \u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4;
	}

	protected float \u02C0\u02BC\u02B5\u02BE\u02BE\u02C0\u02B8\u02C0\u02BD\u02C0\u02BA(Note \u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4, float \u02B6\u02B5\u02C0\u02B8\u02C1\u02BB\u02BF\u02BD\u02BF\u02B4\u02BE, float \u02B3\u02BD\u02B2\u02C0\u02BB\u02B4\u02B9\u02BF\u02BF\u02B6\u02B5)
	{
		int num = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.\u02B2\u02B4\u02B6\u02B8\u02C0\u02C0\u02B4\u02C0\u02B2\u02BE\u02BD(\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4, this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9);
		Note note = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.\u02B5\u02B5\u02B9\u02B6\u02BF\u02C0\u02B9\u02B8\u02B8\u02B8\u02C0(\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4.tickPosition, num);
		Note note2 = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.\u02B7\u02B9\u02B2\u02BF\u02B7\u02BF\u02B2\u02C1\u02B4\u02B7\u02B2(\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4.tickPosition, num, false);
		float num2 = this.\u02C0\u02B5\u02C1\u02B4\u02BE\u02B6\u02BD\u02BA\u02BC\u02B4\u02B9(\u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4, note, \u02B6\u02B5\u02C0\u02B8\u02C1\u02BB\u02BF\u02BD\u02BF\u02B4\u02BE, \u02B3\u02BD\u02B2\u02C0\u02BB\u02B4\u02B9\u02BF\u02BF\u02B6\u02B5);
		float num3 = this.\u02C0\u02B5\u02C1\u02B4\u02BE\u02B6\u02BD\u02BA\u02BC\u02B4\u02B9(note2, \u02B9\u02BF\u02B3\u02BB\u02BC\u02B3\u02B9\u02BE\u02BF\u02C0\u02B4, \u02B6\u02B5\u02C0\u02B8\u02C1\u02BB\u02BF\u02BD\u02BF\u02B4\u02BE, \u02B3\u02BD\u02B2\u02C0\u02BB\u02B4\u02B9\u02BF\u02BF\u02B6\u02B5);
		return this.\u02B9\u02B9\u02B4\u02C1\u02B9\u02B6\u02B2\u02BA\u02B2\u02B2\u02BF(num2 + num3);
	}

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
			this.\u02BF\u02B7\u02B6\u02B6\u02BE\u02BE\u02C0\u02C0\u02BB\u02B2\u02C1 = \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.isStarPower;
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

	protected abstract bool \u02BA\u02B7\u02B5\u02C1\u02C0\u02B4\u02BE\u02BF\u02BF\u02C0\u02BE(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2);

	protected void \u02B7\u02B8\u02C1\u02BE\u02BF\u02B9\u02BF\u02BD\u02B2\u02C0\u02BE(bool \u02BD\u02BF\u02C1\u02C1\u02B8\u02B4\u02BB\u02B9\u02B8\u02B3\u02B4)
	{
		if (this.playerStuff.playerInfo.isRemotePlayer)
		{
			return;
		}
		if (\u02BD\u02BF\u02C1\u02C1\u02B8\u02B4\u02BB\u02B9\u02B8\u02B3\u02B4)
		{
			if (this.health >= 1f)
			{
				return;
			}
			if (this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
			{
				this.health += this.healthGainSP;
			}
			else
			{
				this.health += this.healthDrain;
			}
		}
		else
		{
			this.health -= this.healthGain;
			if (this.health < 0f && !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B8\u02B9\u02BA\u02BB\u02C1\u02BB\u02B9\u02BE\u02C1\u02B9)
			{
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B8\u02B9\u02BA\u02BB\u02C1\u02BB\u02B9\u02BE\u02C1\u02B9 = true;
				GameAudioManager.PlaySound(SoundEffectsChannel.SongFail);
				this.gameManager.EndSong();
			}
		}
		this.healthContainer.\u02BF\u02BC\u02B7\u02B2\u02B9\u02BA\u02BD\u02B6\u02C0\u02C0\u02BE(this.health);
	}

	public bool \u02BF\u02C0\u02BA\u02B6\u02B7\u02C0\u02B2\u02BE\u02BC\u02BA\u02B2
	{
		get
		{
			return !this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF && this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 >= 0.5f;
		}
	}

	public void \u02BA\u02B6\u02C0\u02B4\u02B4\u02BC\u02B7\u02BB\u02B2\u02C0\u02BF()
	{
		if (this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0[this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9].\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1)
		{
			for (int i = this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9 - 1; i > 0; i--)
			{
				Note note = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0[i];
				if (!note.\u02B3\u02B7\u02B2\u02B3\u02BB\u02B2\u02C0\u02BC\u02BD\u02BF\u02C1 || !note.isStarPower)
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
			if (note2.isStarPower)
			{
				note2.\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 &= ~Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.STAR_POWER;
			}
		}
	}

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
			GameAudioManager.PlaySound(SoundEffectsChannel.StarPowerAwarded);
		}
		else if (flag && this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 >= 0.5f)
		{
			GameAudioManager.PlaySound(SoundEffectsChannel.StarPowerAvailable);
		}
		if (this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 >= 1f)
		{
			this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 = 1f;
		}
		this.\u02B5\u02B5\u02B4\u02BB\u02B4\u02BE\u02B2\u02B5\u02B5\u02C0\u02B4 += this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5 - u02B9_u02C0_u02BC_u02B5_u02B3_u02C0_u02BB_u02BC_u02B5_u02BF_u02B;
		this.spBar.\u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC(this.\u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5, this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF);
	}

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

	public virtual void \u02B3\u02B6\u02C0\u02C1\u02B6\u02B6\u02BD\u02BD\u02B7\u02BC\u02BC(Note \u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2)
	{
		\u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2.\u02C1\u02BC\u02B2\u02C1\u02BC\u02B8\u02B2\u02BA\u02C1\u02B9\u02C0 = true;
		if (\u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2.\u02B5\u02C0\u02B3\u02C0\u02B6\u02B5\u02B8\u02BD\u02B6\u02B4\u02B4)
		{
			return;
		}
		this.\u02BF\u02B7\u02B6\u02B6\u02BE\u02BE\u02C0\u02C0\u02BB\u02B2\u02C1 = \u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2.isStarPower;
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
				if (GlobalHelper.soundOnJudgeBreak)
				{
					BassAudioManager.Instance.PlaySoundInternal(SoundEffectsChannel.FreestyleSnare, 0, 116.666664f * GlobalHelper.judgeBreakSoundVolume);
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
			int num5 = ((note.\u02BD\u02B7\u02BA\u02C1\u02B9\u02B9\u02B9\u02B7\u02B7\u02B6\u02BD == -1) ? Helper.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF) : note.\u02BD\u02B7\u02BA\u02C1\u02B9\u02B9\u02B9\u02B7\u02B7\u02B6\u02BD);
			num += num5 * (50 + num3) * num4;
			if ((float)note.tickLength >= Mathf.Ceil(this.gameManager.song.\u02C0\u02B3\u02C1\u02BB\u02B5\u02BA\u02BB\u02B3\u02C1\u02B8\u02BD / 3f))
			{
				num2 += note.tickLength;
			}
		}
		if (this.playerStuff.playerInfo.IsDrumsInstrument)
		{
			num2 = 0;
		}
		num += Mathf.CeilToInt((float)num2 / (this.gameManager.song.\u02C0\u02B3\u02C1\u02BB\u02B5\u02BA\u02BB\u02B3\u02C1\u02B8\u02BD / 25f));
		this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC = num;
		return this.\u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC;
	}

	protected void AddScore(int \u02BF\u02B2\u02B4\u02B8\u02BC\u02C1\u02BA\u02B3\u02BB\u02B2\u02BD)
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

	protected virtual void \u02BB\u02B4\u02B5\u02B9\u02B7\u02B5\u02C1\u02C0\u02B6\u02C1\u02BD(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8, int \u02B7\u02BE\u02B2\u02B6\u02BC\u02BF\u02B4\u02B6\u02B2\u02B8\u02B3 = 50)
	{
		if (this.playerStuff.playerInfo.isRemotePlayer)
		{
			return;
		}
		int num = ((\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BD\u02B7\u02BA\u02C1\u02B9\u02B9\u02B9\u02B7\u02B7\u02B6\u02BD == -1) ? Helper.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF) : \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BD\u02B7\u02BA\u02C1\u02B9\u02B9\u02B9\u02B7\u02B7\u02B6\u02BD) * \u02B7\u02BE\u02B2\u02B6\u02BC\u02BF\u02B4\u02B6\u02B2\u02B8\u02B3;
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

	public void \u02BD\u02C0\u02BA\u02BA\u02BA\u02B7\u02B6\u02B8\u02B6\u02B2\u02BA()
	{
		if (this.\u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD)
		{
			return;
		}
		this.\u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD.\u02BA\u02B8\u02B3\u02B7\u02B2\u02BE\u02B9\u02B5\u02BD\u02BF\u02BC();
		this.\u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD = true;
	}

	public void \u02C1\u02BA\u02B8\u02BF\u02BD\u02BC\u02B8\u02B4\u02BA\u02B9\u02C1()
	{
		if (!this.\u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD)
		{
			return;
		}
		this.\u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD = false;
		this.\u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD.\u02C1\u02BA\u02B8\u02BF\u02BD\u02BC\u02B8\u02B4\u02BA\u02B9\u02C1();
	}

	protected void \u02B3\u02B2\u02B7\u02C1\u02BF\u02B6\u02BE\u02BA\u02BA\u02BF\u02B2()
	{
		if (!this.playerStuff.playerInfo.isRemotePlayer)
		{
			BasePlayer.lastOffset = this.\u02BB\u02B3\u02B2\u02C0\u02B3\u02BC\u02B3\u02B5\u02BB\u02C0\u02B6;
			BasePlayer.JudgementAndFloat judgementAndFloat = BasePlayer.CalculateJudgementAndScore(this.\u02BB\u02B3\u02B2\u02C0\u02B3\u02BC\u02B3\u02B5\u02BB\u02C0\u02B6);
			if (judgementAndFloat.judgement != BasePlayer.Judgement.Miss)
			{
				if (judgementAndFloat.judgement > GlobalHelper.maximumImprecision)
				{
					this.missFromWindow = true;
					this.\u02B6\u02B9\u02BC\u02C0\u02B6\u02BE\u02B4\u02BA\u02BC\u02BB\u02C1(false);
				}
				else if (judgementAndFloat.judgement == BasePlayer.Judgement.Early && GlobalHelper.breakComboOnEarly)
				{
					this.missFromWindow = true;
					this.\u02B6\u02B9\u02BC\u02C0\u02B6\u02BE\u02B4\u02BA\u02BC\u02BB\u02C1(false);
				}
			}
			this.precision.AddJudgement(judgementAndFloat);
		}
		if (this.playerStuff.playerInfo.isAccuracyDisplay)
		{
			if (this.accuracyHistory.Count >= 256)
			{
				this.accuracyHistory.RemoveAt(0);
			}
			this.accuracyHistory.Add(this.\u02BB\u02B3\u02B2\u02C0\u02B3\u02BC\u02B3\u02B5\u02BB\u02C0\u02B6);
			double num = 0.0;
			foreach (float num2 in this.accuracyHistory)
			{
				num += (double)num2;
			}
			num /= (double)this.accuracyHistory.Count;
			this.\u02BB\u02BC\u02B9\u02BF\u02C1\u02B3\u02BD\u02B7\u02BE\u02BC\u02B4.text = string.Format("Accuracy: {0:0.0} ms\nAverage: {1:0.0} ms", -this.\u02BB\u02B3\u02B2\u02C0\u02B3\u02BC\u02B3\u02B5\u02BB\u02C0\u02B6 * 1000f, -num * 1000.0);
		}
	}

	protected virtual void Update()
	{
		if (GlobalVariables.hasReset)
		{
			this._ghosts = 0;
		}
		this.ticker += Time.deltaTime;
		if (this.ticker > 0.05f && !this.playerStuff.playerInfo.HasModChartModifier)
		{
			if (GlobalHelper.showBeatlines)
			{
				this.beatlines.enabled = true;
				this.showBeatlines = true;
			}
			else
			{
				this.beatlines.enabled = false;
				this.showBeatlines = false;
			}
			if (GlobalHelper.showHighway)
			{
				this.highway.gameObject.SetActive(true);
				this.showHighway = true;
			}
			else
			{
				this.highway.gameObject.SetActive(false);
				this.showHighway = false;
			}
			if (GlobalHelper.showHighwaySide)
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
			if (GlobalHelper.showFretStrings)
			{
				this.showFretStrings = true;
				this.neckController.ShowFretStrings();
			}
			else
			{
				this.showFretStrings = false;
				this.neckController.HideFretStrings();
			}
			if (GlobalHelper.showHPBar)
			{
				if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B8\u02B9\u02BA\u02BB\u02C1\u02BB\u02B9\u02BE\u02C1\u02B9)
				{
					this.healthContainer.gameObject.SetActive(true);
				}
				else if (GlobalHelper.hideHPOnFail)
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
		if (!this.gameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5)
		{
			if (!this.playerStuff.playerInfo.isRemotePlayer && this.playerStuff.rewiredPlayer.GetButtonDown(16))
			{
				this.gameManager.\u02B7\u02BB\u02B6\u02C0\u02BE\u02B5\u02B8\u02C0\u02B3\u02C0\u02BD(this.playerStuff);
			}
		}
		else
		{
			this.\u02B4\u02C0\u02BF\u02BA\u02BD\u02BA\u02B3\u02B8\u02B7\u02B7\u02BA();
		}
		if (!this.gameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5 || CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.\u02B9\u02C0\u02B2\u02BA\u02B9\u02BF\u02BE\u02BE\u02BD\u02B4\u02B7();
		}
		if (this.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
		{
			this.\u02B5\u02B3\u02B4\u02BB\u02B2\u02BB\u02B9\u02BF\u02BB\u02B3\u02B4 += this.gameManager.\u02C0\u02BE\u02C1\u02BD\u02C0\u02BC\u02BB\u02B4\u02C1\u02B3\u02B9;
			this.\u02BC\u02B2\u02B4\u02B2\u02C0\u02BA\u02B2\u02B8\u02BA\u02B9\u02B5(this.gameManager.\u02B6\u02BD\u02BF\u02B2\u02B5\u02BA\u02BC\u02BA\u02B9\u02B5\u02B2());
		}
		if (this.gameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5 && this.\u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6)
		{
			this.\u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6 = false;
		}
		if (!this.playerStuff.playerInfo.isBot && !this.\u02C1\u02BC\u02BC\u02C1\u02B2\u02BF\u02C1\u02BE\u02BE\u02BB\u02B4)
		{
			this.UpdateInputs();
		}
		else
		{
			this.UpdateAI();
		}
		if (!this.\u02B5\u02BB\u02BA\u02B2\u02C1\u02BB\u02B6\u02B5\u02BE\u02B9\u02BF && this.gameManager.songTime >= 0.0)
		{
			this.\u02B6\u02BC\u02BD\u02B3\u02B6\u02B3\u02BD\u02B9\u02BF\u02BA\u02B6 = BassAudioManager.Instance.\u02B6\u02B5\u02BD\u02C0\u02B6\u02BA\u02B2\u02B9\u02C1\u02BD\u02BD(this.playerStuff.playerInfo.\u02BA\u02BD\u02BC\u02BC\u02B4\u02BD\u02B4\u02BE\u02B2\u02B7\u02C1);
			this.\u02B5\u02BB\u02BA\u02B2\u02C1\u02BB\u02B6\u02B5\u02BE\u02B9\u02BF = true;
		}
		if (this.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2 != null)
		{
			this.\u02B8\u02B3\u02B5\u02B5\u02C1\u02B4\u02BA\u02BF\u02BA\u02BC\u02B3 = this.\u02B3\u02C1\u02BD\u02BF\u02B4\u02B2\u02BC\u02BF\u02BC\u02C1\u02BC;
			long num = (long)((ulong)this.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE + (ulong)((long)this.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2.\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2));
			if (this.gameManager.currentTick >= this.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2.\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE && (ulong)this.gameManager.currentTick < (ulong)num)
			{
				this.\u02B3\u02C1\u02BD\u02BF\u02B4\u02B2\u02BC\u02BF\u02BC\u02C1\u02BC = true;
			}
			else
			{
				this.\u02B3\u02C1\u02BD\u02BF\u02B4\u02B2\u02BC\u02BF\u02BC\u02C1\u02BC = false;
			}
		}
		this.neckController.\u02C0\u02B8\u02B5\u02B3\u02BF\u02BD\u02B2\u02BE\u02B9\u02B2\u02B4(this.buttonsPressed);
	}

	protected virtual void \u02B9\u02C0\u02B2\u02BA\u02B9\u02BF\u02BE\u02BE\u02BD\u02B4\u02B7()
	{
		if (this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0 == null || this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count == 0)
		{
			return;
		}
		Note note = this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0[this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count - 1];
		this.\u02C0\u02B2\u02B2\u02BA\u02B5\u02B9\u02BD\u02B6\u02BD\u02B6\u02B9 = !this.gameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5 && this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count > 0 && this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9 > 0 && !note.\u02BC\u02B9\u02B4\u02B6\u02B5\u02BC\u02BB\u02BC\u02BB\u02B4\u02B7;
		uint num = 0U;
		foreach (Note note2 in EnumerableRanges.EnumerateRange<Note>(this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0, this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9, int.MaxValue))
		{
			if (this.\u02B2\u02B3\u02B6\u02B9\u02B6\u02B8\u02B3\u02BE\u02BE\u02B3\u02B6)
			{
				this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF = this.\u02C0\u02BC\u02B5\u02BE\u02BE\u02C0\u02B8\u02C0\u02BD\u02C0\u02BA(note2, this.\u02BF\u02BE\u02B8\u02C1\u02BE\u02C1\u02C0\u02C0\u02BB\u02BB\u02BC, this.hitWindow);
				float num2 = this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF / 2f;
				this.\u02B4\u02B4\u02BF\u02B5\u02B4\u02B6\u02BA\u02B7\u02B2\u02B9\u02C1 = num2;
				this.\u02B8\u02B2\u02B4\u02BF\u02C0\u02B8\u02C0\u02BA\u02B9\u02B2\u02B7 = -num2;
			}
			if (this.\u02C0\u02BE\u02BD\u02B3\u02C0\u02B9\u02B5\u02BF\u02BC\u02BC\u02B8)
			{
				this.\u02B4\u02B4\u02BF\u02B5\u02B4\u02B6\u02BA\u02B7\u02B2\u02B9\u02C1 = 0f;
				this.\u02B8\u02B2\u02B4\u02BF\u02C0\u02B8\u02C0\u02BA\u02B9\u02B2\u02B7 = -this.hitWindow;
			}
			double num3 = (double)note2.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 - this.gameManager.songTime;
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
					if ((note2.tickPosition != num || note2.tickPosition == 0U) && num3 <= (double)this.\u02B4\u02B4\u02BF\u02B5\u02B4\u02B6\u02BA\u02B7\u02B2\u02B9\u02C1 && num3 >= (double)this.\u02B8\u02B2\u02B4\u02BF\u02C0\u02B8\u02C0\u02BA\u02B9\u02B2\u02B7)
					{
						this.\u02C1\u02BA\u02BE\u02B9\u02B8\u02BB\u02B7\u02BB\u02B7\u02B3\u02B5(note2, true);
						if (this.\u02B2\u02B9\u02B2\u02B4\u02B2\u02BA\u02B2\u02BA\u02C1\u02BA\u02B5 && this.combo > 0)
						{
							break;
						}
					}
					num = note2.tickPosition;
				}
			}
		}
	}

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
				if (num2 > 0U && note.tickPosition >= num2)
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

	public virtual void \u02B8\u02BF\u02C0\u02BE\u02B2\u02BA\u02C0\u02B5\u02BE\u02B7\u02BD()
	{
		this.gameManager.\u02B3\u02BC\u02B6\u02C0\u02BF\u02B5\u02C1\u02B4\u02BA\u02BA\u02C1.Reset();
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
			this.buttonsPressed = 0;
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

	protected BasePlayer()
	{
		this.\u02B2\u02BF\u02BD\u02B2\u02C0\u02BD\u02BA\u02B2\u02BC\u02B5\u02B6 = true;
		this.hitWindow = 0.07f;
		this.\u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE = true;
		this.health = 0.5f;
		this.healthDrain = 0.0069f;
		this.healthGain = 0.0277f;
		this.healthGainSP = 0.045f;
		this.accuracyHistory = new List<float>(128);
		this.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD = new Note(0f, 0f, 0, \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Strum, Note.\u02B4\u02B4\u02B6\u02B9\u02BC\u02B3\u02BD\u02B5\u02B4\u02B3\u02BF.NONE, 0U, 0);
	}

	[CompilerGenerated]
	private void \u02C1\u02BA\u02BE\u02B9\u02B8\u02BB\u02B7\u02BB\u02B7\u02B3\u02B5(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, bool \u02B3\u02BF\u02C1\u02B5\u02C0\u02BC\u02BC\u02B4\u02B3\u02BF\u02B2)
	{
		if (\u02B3\u02BF\u02C1\u02B5\u02C0\u02BC\u02BC\u02B4\u02B3\u02BF\u02B2 && this.hittableNotes.Length == this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6)
		{
			Array.Resize<Note>(ref this.hittableNotes, this.hittableNotes.Length * 2);
		}
		this.hittableNotes[this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6] = \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2;
		this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6++;
	}

	public int ghosts()
	{
		return this.\u02B3\u02B9\u02B8\u02BF\u02C1\u02B9\u02B2\u02BC\u02B5\u02BB\u02BB;
	}

	public static BasePlayer.JudgementAndFloat CalculateJudgementAndScore(float inaccuracy)
	{
		float[] array = GlobalHelper.judgeTimings(GlobalHelper.useJudgeLevel);
		GlobalHelper.WeightSystem weightSystem = GlobalHelper.weightSystem;
		float[] array2;
		if (weightSystem != GlobalHelper.WeightSystem.Custom)
		{
			if (weightSystem != GlobalHelper.WeightSystem.Etterna)
			{
				array2 = new float[] { 1f, 1f, 0.983f, 0.655f, 0.255f, -0.5f, -1f, -0.636f };
			}
			else
			{
				array2 = new float[] { 1f, 1f, 0.673f, 0.327f, 0f, -0.255f, -0.5f, -1f };
			}
		}
		else
		{
			array2 = new float[] { 1f, 1f, 0.909f, 0.455f, 0.455f, 0.227f, 0.114f, 0f };
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

	public ushort getInputs()
	{
		return this.buttonsPressed;
	}

	[SerializeField]
	public BaseNoteRenderer noteRenderer;

	[NonSerialized]
	public GameManager gameManager;

	[SerializeField]
	protected BaseNeckController neckController;

	[SerializeField]
	public Camera camera;

	[SerializeField]
	public ComboColor comboCounter;

	[SerializeField]
	protected HealthContainer healthContainer;

	[SerializeField]
	protected GameObject FCIndicator;

	protected DesaturateSprite[] \u02B5\u02BE\u02B5\u02B8\u02B8\u02B4\u02BF\u02BC\u02B4\u02B8\u02B2;

	public SoloCounter \u02B9\u02BB\u02BD\u02C1\u02B5\u02BE\u02B4\u02B8\u02BF\u02BA\u02BD;

	public Countdown \u02B4\u02BA\u02B4\u02BF\u02B6\u02B9\u02B5\u02BA\u02C0\u02BD\u02BB;

	public TextMeshProUGUI playerNameTextBox;

	public GameObject \u02B7\u02B3\u02B9\u02B5\u02B7\u02BC\u02C1\u02BB\u02B7\u02B7\u02B4;

	public TextMeshProUGUI \u02BB\u02BC\u02B9\u02BF\u02C1\u02B3\u02BD\u02B7\u02BE\u02BC\u02B4;

	public bool \u02B2\u02BF\u02BD\u02B2\u02C0\u02BD\u02BA\u02B2\u02BC\u02B5\u02B6;

	[HideInInspector]
	public \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 playerStuff;

	[SerializeField]
	protected SPBar spBar;

	[SerializeField]
	public GameObject[] highwayObjects;

	public const int \u02BA\u02BE\u02C0\u02B4\u02B4\u02BE\u02B3\u02B3\u02BD\u02C0\u02BB = 50;

	public HighwayScroll highway;

	public CameraShake \u02C0\u02BE\u02B4\u02BF\u02C1\u02C1\u02B3\u02BF\u02BE\u02B2\u02B5;

	public \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B9\u02B2\u02BC\u02BA\u02B6\u02B7\u02BE\u02B6\u02BF\u02BA\u02B9 \u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2;

	public List<Note> \u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0;

	public List<\u02B4\u02C1\u02B5\u02BD\u02BD\u02B7\u02BA\u02BB\u02B4\u02C0\u02B8> \u02B4\u02B7\u02BC\u02C1\u02B2\u02B8\u02B2\u02BD\u02BD\u02BC\u02BF;

	public List<\u02B2\u02BA\u02B2\u02B4\u02B6\u02B4\u02B6\u02BB\u02BA\u02B7\u02B4> \u02B2\u02BB\u02B3\u02B8\u02B5\u02B2\u02C0\u02BF\u02BA\u02B4\u02BC;

	public float \u02B4\u02B4\u02BF\u02B5\u02B4\u02B6\u02BA\u02B7\u02B2\u02B9\u02C1;

	public float \u02B8\u02B2\u02B4\u02BF\u02C0\u02B8\u02C0\u02BA\u02B9\u02B2\u02B7;

	public float \u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF;

	protected float hitWindow;

	protected float \u02BF\u02BE\u02B8\u02C1\u02BE\u02C1\u02C0\u02C0\u02BB\u02BB\u02BC;

	protected bool \u02B2\u02B3\u02B6\u02B9\u02B6\u02B8\u02B3\u02BE\u02BE\u02B3\u02B6;

	protected bool \u02B2\u02B9\u02B2\u02B4\u02B2\u02BA\u02B2\u02BA\u02C1\u02BA\u02B5;

	public bool \u02B3\u02BC\u02B4\u02B8\u02BB\u02B8\u02B2\u02C0\u02C0\u02B3\u02C0;

	public bool \u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB;

	public bool \u02BD\u02B8\u02B6\u02B2\u02B8\u02B6\u02BD\u02C0\u02BD\u02B8\u02BB;

	public bool \u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8;

	public bool \u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0;

	public bool \u02BB\u02BD\u02C0\u02B5\u02B8\u02B3\u02BD\u02B6\u02B7\u02BB\u02B7;

	public bool \u02B5\u02C1\u02BA\u02B9\u02B6\u02B7\u02B9\u02BC\u02B7\u02BD\u02B4;

	protected ushort buttonsPressed;

	protected ushort \u02BA\u02BD\u02B4\u02BB\u02B8\u02C1\u02B2\u02B3\u02B2\u02BC\u02B3;

	[HideInInspector]
	public bool \u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE;

	[HideInInspector]
	public bool \u02C0\u02B2\u02B2\u02BA\u02B5\u02B9\u02BD\u02B6\u02BD\u02B6\u02B9;

	[HideInInspector]
	public bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF;

	public bool \u02B9\u02C0\u02BD\u02BF\u02BD\u02B9\u02B2\u02B6\u02BA\u02B3\u02B6;

	protected bool \u02B4\u02BE\u02B2\u02BB\u02B5\u02B5\u02B3\u02B4\u02B8\u02BF\u02BD;

	protected bool \u02B7\u02BD\u02C1\u02B3\u02BD\u02B5\u02B6\u02B8\u02B8\u02B2\u02BF;

	protected bool \u02C0\u02B4\u02B5\u02B8\u02B6\u02B8\u02B2\u02BE\u02B6\u02B5\u02B2;

	protected bool \u02C1\u02BC\u02BC\u02C1\u02B2\u02BF\u02C1\u02BE\u02BE\u02BB\u02B4;

	protected bool \u02BF\u02C1\u02BF\u02BE\u02C1\u02B2\u02BC\u02BE\u02B3\u02BB\u02B8;

	protected int \u02B6\u02BC\u02BD\u02B3\u02B6\u02B3\u02BD\u02B9\u02BF\u02BA\u02B6;

	protected bool \u02B5\u02BB\u02BA\u02B2\u02C1\u02BB\u02B6\u02B5\u02BE\u02B9\u02BF;

	[HideInInspector]
	public bool \u02BF\u02B7\u02B6\u02B6\u02BE\u02BE\u02C0\u02C0\u02BB\u02B2\u02C1;

	protected int \u02BD\u02B7\u02BF\u02B4\u02C1\u02C1\u02BA\u02BB\u02BD\u02B4\u02B7;

	[HideInInspector]
	public int \u02BE\u02BB\u02B7\u02B6\u02B9\u02BB\u02B3\u02B8\u02B2\u02B6\u02B9;

	protected int \u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9;

	protected Note[] hittableNotes;

	protected float \u02B9\u02C0\u02BC\u02B5\u02B3\u02C0\u02BB\u02BC\u02B5\u02BF\u02B5;

	protected float health;

	protected float healthDrain;

	protected float healthGain;

	protected float healthGainSP;

	private bool \u02C0\u02BE\u02BD\u02B3\u02C0\u02B9\u02B5\u02BF\u02BC\u02BC\u02B8;

	private float \u02B5\u02B5\u02B4\u02BB\u02B4\u02BE\u02B2\u02B5\u02B5\u02C0\u02B4;

	protected float \u02BB\u02B3\u02B2\u02C0\u02B3\u02BC\u02B3\u02B5\u02BB\u02C0\u02B6;

	protected List<float> accuracyHistory;

	[HideInInspector]
	public int combo;

	[HideInInspector]
	public int \u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6;

	[HideInInspector]
	public int \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;

	[HideInInspector]
	public int \u02B7\u02C0\u02BE\u02BB\u02B2\u02B2\u02B3\u02BC\u02BD\u02B4\u02BE;

	[HideInInspector]
	public int \u02B3\u02B5\u02C1\u02B7\u02C1\u02C1\u02BA\u02B2\u02B5\u02BD\u02B7;

	[HideInInspector]
	public int \u02C1\u02B4\u02BB\u02B3\u02B3\u02BB\u02C0\u02B4\u02C1\u02BB\u02BE;

	public int overstrums;

	private int \u02B8\u02BE\u02B5\u02B7\u02BF\u02B9\u02C1\u02B2\u02B8\u02B6\u02BF;

	private float \u02B5\u02B3\u02B4\u02BB\u02B2\u02BB\u02B9\u02BF\u02BB\u02B3\u02B4;

	private int \u02BD\u02BC\u02B7\u02B6\u02C1\u02B6\u02BF\u02B5\u02BA\u02BF\u02C1;

	private int \u02B2\u02B2\u02C0\u02B3\u02B5\u02BD\u02BC\u02B5\u02B3\u02B7\u02B4;

	private int \u02B9\u02B7\u02B6\u02BE\u02BC\u02B2\u02C1\u02BF\u02B6\u02BA\u02BD;

	private int \u02B6\u02B4\u02BB\u02BC\u02BA\u02B9\u02B8\u02B7\u02B5\u02C0\u02C1;

	protected int _ghosts;

	protected int \u02B2\u02C0\u02B5\u02BB\u02BF\u02B4\u02B9\u02B5\u02BF\u02BC\u02BB;

	protected int \u02B4\u02C1\u02BF\u02B7\u02B9\u02C0\u02C0\u02B2\u02C0\u02B9\u02C0;

	protected int \u02B3\u02B9\u02B8\u02BF\u02C1\u02B9\u02B2\u02BC\u02B5\u02BB\u02BB;

	protected int \u02B9\u02B2\u02BF\u02BD\u02B3\u02B7\u02BF\u02BA\u02BD\u02B9\u02B5;

	[SerializeField]
	private SpNeckRenderer spNeckRenderer;

	public BeatRenderer beatlines;

	public BrutalFader \u02BC\u02BD\u02BF\u02BA\u02B8\u02B5\u02B3\u02B8\u02BE\u02C0\u02BC;

	[SerializeField]
	protected TrackSidebarColoring trackSidebarLeft;

	[SerializeField]
	protected TrackSidebarColoring trackSidebarRight;

	private \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6;

	public \u02BE\u02B9\u02B7\u02C0\u02BC\u02BC\u02C1\u02BD\u02BC\u02BD\u02BE \u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2;

	protected bool \u02B3\u02C1\u02BD\u02BF\u02B4\u02B2\u02BC\u02BF\u02BC\u02C1\u02BC;

	protected bool \u02B8\u02B3\u02B5\u02B5\u02C1\u02B4\u02BA\u02BF\u02BA\u02BC\u02B3;

	private bool \u02B3\u02B3\u02B2\u02B4\u02B6\u02BE\u02B2\u02B3\u02B2\u02B4\u02BC;

	private int \u02B8\u02B3\u02B3\u02B2\u02B7\u02B2\u02C0\u02B6\u02BA\u02BE\u02BC;

	public Note \u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD;

	public static float interval;

	private float elapsedtime;

	private bool lastFrame;

	public static bool autoEnabled;

	public BasePlayer.PrecisionData precision;

	public static float lastOffset;

	public static float lastVal;

	private float ticker;

	private bool missFromWindow;

	private bool highwayDeactivated;

	private bool showBeatlines;

	private bool showHighway;

	private bool showHighwaySide;

	private bool showFretStrings;

	public enum Judgement
	{
		Perfect = 1,
		Great,
		Good,
		Bad,
		Early,
		Miss,
		Marvelous = 0
	}

	public struct PrecisionData
	{
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

		public void AddJudgement(BasePlayer.JudgementAndFloat jaf)
		{
			this.totalJudgements++;
			this.totalPrecision += (double)jaf.val;
			this.m_lastJudgement = jaf.judgement;
			this.m_totalInacc += jaf.inacc;
			BasePlayer.lastVal = jaf.val;
		}

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

		public int[] judgements;

		public int totalJudgements;

		private double m_totalPrecision;

		private bool needsToRecalculate;

		public float m_precisionCache;

		public BasePlayer.Judgement m_lastJudgement;

		public float m_totalInacc;

		public float avgInaccuracyCache;
	}

	public struct JudgementAndFloat
	{
		public JudgementAndFloat()
		{
			this.judgement = BasePlayer.Judgement.Marvelous;
			this.val = 0f;
			this.inacc = 0f;
		}

		public BasePlayer.Judgement judgement;

		public float val;

		public float inacc;
	}
}
