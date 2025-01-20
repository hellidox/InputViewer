﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Rewired;
using Rewired.UI.ControlMapper;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProfileMenu : BaseMenu
{
	public bool \u02B6\u02BA\u02B9\u02C0\u02B5\u02B5\u02BF\u02BF\u02B8\u02BA\u02B6
	{
		get
		{
			return this.\u02BE\u02B5\u02B7\u02C1\u02B2\u02B3\u02B3\u02BD\u02C0\u02B3\u02B6;
		}
	}

	private void \u02BB\u02B5\u02BA\u02BE\u02BD\u02B8\u02B9\u02B9\u02C1\u02B8\u02BB(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
	{
		if (\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 != this.\u02BE\u02BD\u02B8\u02BE\u02C1\u02BA\u02B4\u02B8\u02BD\u02BF\u02B8)
		{
			this.\u02BB\u02B5\u02BA\u02BE\u02BD\u02B8\u02B9\u02B9\u02C1\u02B8\u02BB(this.\u02B6\u02BB\u02BD\u02C0\u02B2\u02BD\u02BB\u02BF\u02B7\u02BF\u02B8, \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 - 1);
			this.\u02BB\u02B5\u02BA\u02BE\u02BD\u02B8\u02B9\u02B9\u02C1\u02B8\u02BB(this.\u02B4\u02B9\u02C0\u02B4\u02BD\u02BD\u02B2\u02BB\u02B3\u02B6\u02B7, \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 + 1);
			if (\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 == -1)
			{
				this.\u02C0\u02B5\u02B2\u02BD\u02BA\u02B5\u02C1\u02B7\u02B5\u02C0\u02BF.texture = this.\u02B3\u02B9\u02B9\u02BD\u02B6\u02B2\u02C1\u02BE\u02B3\u02BF\u02B7;
				this.\u02BE\u02BD\u02B8\u02BE\u02C1\u02BA\u02B4\u02B8\u02BD\u02BF\u02B8 = -1;
				return;
			}
			this.\u02C0\u02B5\u02B2\u02BD\u02BA\u02B5\u02C1\u02B7\u02B5\u02C0\u02BF.texture = GlobalVariables.instance.\u02BC\u02B3\u02C1\u02C0\u02B6\u02B2\u02BE\u02B7\u02C1\u02BF\u02B5(\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, true);
			this.\u02BE\u02BD\u02B8\u02BE\u02C1\u02BA\u02B4\u02B8\u02BD\u02BF\u02B8 = \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5;
		}
	}

	private void \u02C0\u02BC\u02B6\u02BA\u02B3\u02B3\u02C1\u02BE\u02BB\u02B2\u02B3()
	{
		this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = LanguageManager.instance.GetString("Choose a Profile");
		this.\u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF.CrossFadeColor(this.\u02BF\u02B7\u02BB\u02BB\u02BF\u02B9\u02B9\u02BF\u02C1\u02B2\u02BC, 1f, true, false);
		this.menuStrings = new string[GlobalVariables.instance.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B9\u02BA\u02B2\u02B9\u02B8\u02B2\u02B4\u02B5\u02C0\u02BF\u02B9 + 2];
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		int num = 0;
		foreach (\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B in GlobalVariables.instance.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02C1\u02B3\u02B4\u02B2\u02B6\u02BA\u02C0\u02B8\u02B8\u02B6\u02B8())
		{
			if (u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.isBot)
			{
				this.menuStrings[num] = "<color=#00FFFF>" + u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.playerName.CurrentValueNoTags + "</color>";
			}
			else
			{
				this.menuStrings[num] = u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.playerName.CurrentValueDisplay;
			}
			num++;
		}
		this.menuStrings[this.menuStrings.Length - 2] = "Guest";
		this.menuStrings[this.menuStrings.Length - 1] = "Create Profile";
		this.allowMultiLanguage = false;
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		if (this.controllingPlayer == null)
		{
			return;
		}
		if (!this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
		{
			return;
		}
		if (this.controllingPlayer.playerProfile != null && this.\u02BA\u02BD\u02BF\u02B4\u02BB\u02B8\u02B4\u02BB\u02C1\u02B8\u02BA)
		{
			return;
		}
		if (this.controllingPlayer.playerProfile == null)
		{
			this.\u02BF\u02BD\u02BA\u02B9\u02BB\u02BB\u02BD\u02BF\u02BC\u02BF\u02B4(false);
			return;
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			this.\u02B8\u02B3\u02B4\u02B9\u02BC\u02C1\u02B6\u02B7\u02B4\u02B9\u02B8(false);
			this.menuStrings = (this.controllingPlayer.playerProfile.IsAnyGuitarController ? this.guitarOptions : this.drumsOptions);
			this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
			base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3);
			this.instIcons.SetActive(false);
			if (this.controllingPlayer.playerProfile.\u02BA\u02C0\u02BC\u02BB\u02B7\u02B3\u02B8\u02BA\u02B2\u02B9\u02BA == this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC && MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
			{
				MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B2\u02BE\u02BF\u02BB\u02C0\u02BE\u02BD\u02B9\u02BC\u02BB(this.controllingPlayer, this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue);
			}
			this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			return;
		}
		if (this.\u02B5\u02B7\u02B5\u02B6\u02B3\u02B4\u02B7\u02BB\u02BE\u02B6\u02B5)
		{
			this.\u02B5\u02B7\u02B5\u02B6\u02B3\u02B4\u02B7\u02BB\u02BE\u02B6\u02B5 = false;
			this.\u02B9\u02C1\u02C1\u02C1\u02B2\u02BE\u02B3\u02BD\u02C0\u02BD\u02B4();
			this.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(false);
			base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0("Delete Profile");
			return;
		}
		if (this.menuStrings == this.profileOptions)
		{
			this.\u02BC\u02BE\u02BE\u02B7\u02B9\u02BC\u02C1\u02BD\u02C1\u02BF\u02BD();
			base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0("Options");
			return;
		}
		this.\u02B2\u02BC\u02B3\u02B2\u02C0\u02B9\u02BB\u02B2\u02C0\u02C0\u02B3();
	}

	protected override void Update()
	{
		base.Update();
		if (this.controllingPlayer == null || this.\u02BF\u02B4\u02BE\u02B3\u02C1\u02BE\u02BE\u02B2\u02B8\u02B2\u02BC.isOpen || FadeBehaviour.instance.isFading || this.controllingPlayer.player == null || (this.controllingPlayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && !this.\u02BE\u02B5\u02B7\u02C1\u02B2\u02B3\u02B3\u02BD\u02C0\u02B3\u02B6 && this.controllingPlayer.transitioning))
		{
			return;
		}
		if (!this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
		{
			if (this.controllingPlayer.player.GetButtonDown(16))
			{
				this.\u02BC\u02BE\u02BE\u02B7\u02B9\u02BC\u02C1\u02BD\u02C1\u02BF\u02BD();
			}
			return;
		}
		if (this.\u02BE\u02B5\u02B7\u02C1\u02B2\u02B3\u02B3\u02BD\u02C0\u02B3\u02B6)
		{
			this.\u02B7\u02C0\u02BF\u02BD\u02B3\u02B4\u02B8\u02BB\u02B9\u02B8\u02BE();
			return;
		}
	}

	private void \u02B2\u02B7\u02B4\u02BA\u02BF\u02B8\u02BF\u02C0\u02B5\u02B3\u02B8(string \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF, int \u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8)
	{
		int num = 0;
		string[] array = new string[this.menuStrings.Length + 1];
		for (int i = 0; i < array.Length; i++)
		{
			if (i == \u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8)
			{
				array[i] = \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF;
			}
			else
			{
				array[i] = this.menuStrings[num];
				num++;
			}
		}
		this.menuStrings = array;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	private void \u02B3\u02B2\u02B7\u02BB\u02B4\u02B8\u02B4\u02BD\u02BE\u02BB\u02BB()
	{
		foreach (PlayerProfileMenu playerProfileMenu in global::UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>())
		{
			if (!(playerProfileMenu == this) && playerProfileMenu.controllingPlayer != null && playerProfileMenu.controllingPlayer.playerProfile == null && !playerProfileMenu.\u02BE\u02B5\u02B7\u02C1\u02B2\u02B3\u02B3\u02BD\u02C0\u02B3\u02B6)
			{
				playerProfileMenu.\u02C0\u02BC\u02B6\u02BA\u02B3\u02B3\u02C1\u02BE\u02BB\u02B2\u02B3();
			}
		}
	}

	private void \u02B5\u02BE\u02BC\u02B2\u02BF\u02B9\u02BA\u02B4\u02B4\u02B9\u02B3()
	{
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = true;
		if (this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1)
		{
			this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = true;
			Settings.Commit(true);
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
			{
				\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BB\u02B6\u02B7\u02BF\u02B5\u02B2\u02B6\u02C0\u02BA\u02BB(this.controllingPlayer.playerProfile);
			}
		}
		if (this.midiSetupMenu.enabled)
		{
			this.midiSetupMenu.enabled = true;
			base.enabled = false;
		}
		base.StartCoroutine(this.\u02B6\u02B3\u02C1\u02B7\u02B3\u02B5\u02B7\u02BA\u02B8\u02C0\u02BD());
		if (this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE != null)
		{
			base.StopCoroutine(this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE);
		}
		this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE = base.StartCoroutine(this.\u02B3\u02B9\u02B4\u02C1\u02B7\u02B3\u02BF\u02BE\u02BA\u02BF\u02C1(false));
		this.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(true);
	}

	private void \u02BE\u02BA\u02B5\u02C0\u02B9\u02BF\u02BB\u02B4\u02B2\u02BB\u02B5()
	{
		ReInput.controllers.Keyboard.enabled = true;
		this.\u02BE\u02B5\u02B7\u02C1\u02B2\u02B3\u02B3\u02BD\u02C0\u02B3\u02B6 = false;
		this.\u02BF\u02B4\u02BE\u02B3\u02C1\u02BE\u02BE\u02B2\u02B8\u02B2\u02BC.enabled = true;
		if (this.\u02C1\u02B7\u02BA\u02B7\u02BB\u02BE\u02B8\u02B5\u02BB\u02B8\u02B8)
		{
			this.\u02C1\u02B7\u02BA\u02B7\u02BB\u02BE\u02B8\u02B5\u02BB\u02B8\u02B8 = false;
			this.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(false);
			this.\u02B9\u02C1\u02C1\u02C1\u02B2\u02BE\u02B3\u02BD\u02C0\u02BD\u02B4();
			return;
		}
		this.\u02C0\u02BC\u02B6\u02BA\u02B3\u02B3\u02C1\u02BE\u02BB\u02B2\u02B3();
		base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0("Create Profile");
	}

	private void \u02BE\u02C0\u02BC\u02BF\u02C1\u02BE\u02B8\u02B5\u02B7\u02B3\u02BF(Player \u02BA\u02BB\u02BF\u02C1\u02BA\u02B7\u02B2\u02B5\u02B5\u02BF\u02C1)
	{
		GlobalVariables.instance.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD++;
		this.controllingPlayer = GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		this.controllingPlayer.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = this;
		this.controllingPlayer.player = \u02BA\u02BB\u02BF\u02C1\u02BA\u02B7\u02B2\u02B5\u02B5\u02BF\u02C1;
		this.controllingPlayer.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 = this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7;
		\u02BA\u02BB\u02BF\u02C1\u02BA\u02B7\u02B2\u02B5\u02B5\u02BF\u02C1.isPlaying = false;
		this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = true;
		if (this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE != null)
		{
			base.StopCoroutine(this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE);
		}
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = true;
		this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE = base.StartCoroutine(this.\u02BD\u02B2\u02C1\u02B2\u02BC\u02BC\u02B6\u02BE\u02BF\u02BC\u02B6(true));
		this.\u02C0\u02BC\u02B6\u02BA\u02B3\u02B3\u02C1\u02BE\u02BB\u02B2\u02B3();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(1, true);
	}

	private void \u02B2\u02BC\u02B8\u02B7\u02C0\u02B8\u02B3\u02BE\u02B3\u02BB\u02B7()
	{
		if (this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD == PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.None)
		{
			return;
		}
		int i = 1;
		int num = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
		bool flag = true;
		Color highlightColor = this.highlightColor;
		highlightColor.a = 1807f;
		Color defaultColor = this.defaultColor;
		defaultColor.a = 1514f;
		int num2 = this.\u02BB\u02B4\u02C0\u02B3\u02B2\u02BB\u02C1\u02BE\u02B5\u02BD\u02C0();
		while (i < this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
		{
			string text = string.Empty;
			this.backgroundObjects[i].color = ((this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 == i) ? this.defaultColor : this.highlightColor);
			this.textObjects[i].color = ((this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 == i) ? highlightColor : defaultColor);
			PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5 u02B8_u02BE_u02B9_u02B7_u02B8_u02B9_u02B5_u02BA_u02BF_u02C1_u02BD = this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD;
			if (u02B8_u02BE_u02B9_u02B7_u02B8_u02B9_u02B5_u02BA_u02BF_u02C1_u02BD != PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.String)
			{
				if (u02B8_u02BE_u02B9_u02B7_u02B8_u02B9_u02B5_u02BA_u02BF_u02C1_u02BD - PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Int == 0)
				{
					text = (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.MaxValue - num * this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.IncrementAmount).ToString();
				}
			}
			else
			{
				string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
				if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Choose Instrument"))
				{
					if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == ""))
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "All Strums")
						{
							text = ((num == 0) ? LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().GetString("6 Fret Lead Guitar") : ((num == 1) ? LanguageManager.instance.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("name") : GlobalVariables.instance.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD[num - 8]));
							this.optionChecks[i].enabled = i == num2;
							this.optionChecks[i].color = ((i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3) ? Color.black : Color.white);
						}
					}
					else
					{
						flag = false;
						switch (i)
						{
						case 0:
							text = "Bass";
							break;
						case 1:
							text = "{0:N3}x";
							break;
						case 2:
							text = "Display Name";
							break;
						case 3:
							text = "Song";
							break;
						}
					}
				}
				else if (num == 0)
				{
					text = LanguageManager.instance.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("");
				}
				else
				{
					flag = GlobalVariables.instance.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[num - 1].isResource;
					text = GlobalVariables.instance.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[num - 1].name;
				}
			}
			if (this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD == (PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5)8)
			{
				text += "song";
			}
			this.textObjects[i].text = "_uFillHeight" + (flag ? LanguageManager.instance.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(text) : text) + "highway_shake";
			num++;
			i++;
		}
		while (i < this.textObjects.Length)
		{
			this.textObjects[i].text = "CREDITS";
			this.backgroundObjects[i].color = this.highlightColor;
			i += 0;
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Alternate Tap Texture")
		{
			this.\u02BB\u02B5\u02BA\u02BE\u02BD\u02B8\u02B9\u02B9\u02C1\u02B8\u02BB(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC - 0);
		}
	}

	private void \u02BA\u02B9\u02BB\u02BC\u02B4\u02B5\u02B7\u02B3\u02B3\u02BB\u02B5(string \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF)
	{
		int num = 0;
		string[] array = new string[this.menuStrings.Length - 1];
		for (int i = 0; i < array.Length; i++)
		{
			if (this.menuStrings[i] == \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF)
			{
				num++;
			}
			array[i] = this.menuStrings[num];
			num++;
		}
		this.menuStrings = array;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	private IEnumerator \u02B6\u02B3\u02C1\u02B7\u02B3\u02B5\u02B7\u02BA\u02B8\u02C0\u02BD()
	{
		yield return null;
		this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
		yield break;
	}

	private void \u02BC\u02BC\u02BF\u02BB\u02B4\u02C1\u02BC\u02B2\u02B3\u02B2\u02BD()
	{
		int num = base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC - 1;
		PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5 u02B8_u02BE_u02B9_u02B7_u02B8_u02B9_u02B5_u02BA_u02BF_u02C1_u02BD = this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD;
		if (u02B8_u02BE_u02B9_u02B7_u02B8_u02B9_u02B5_u02BA_u02BF_u02C1_u02BD != PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.String)
		{
			if (u02B8_u02BE_u02B9_u02B7_u02B8_u02B9_u02B5_u02BA_u02BF_u02C1_u02BD - PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Int <= 1)
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.MinValue + (this.\u02BF\u02B8\u02BC\u02B4\u02BA\u02C1\u02C0\u02B9\u02BA\u02B4\u02B7 - base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC) * this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.IncrementAmount - this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.IncrementAmount;
				return;
			}
		}
		else
		{
			string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
			if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Color Profile"))
			{
				if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Highway")
				{
					string text = ((num == -1) ? "Random" : GlobalVariables.instance.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[num].name);
					this.controllingPlayer.playerProfile.highwayName.CurrentValue = text;
					return;
				}
				if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Controller"))
				{
					return;
				}
				if (this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 != this.controllingPlayer.playerProfile.controllerType.CurrentValue)
				{
					this.controllingPlayer.playerProfile.controllerType.CurrentValue = this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3;
					this.controllingPlayer.playerProfile.noteModifier = Modifier.None;
					this.controllingPlayer.playerProfile.instrument = \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02B2\u02B8\u02B3\u02BC\u02B7\u02B8\u02C1\u02B6\u02BE\u02B2\u02B7(this.controllingPlayer.playerProfile.controllerType.GetControllerType);
					if (MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
					{
						MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02C0\u02B5\u02BE\u02BB\u02B3\u02B2\u02B8\u02B6\u02B8\u02BF(this.controllingPlayer);
					}
				}
			}
			else
			{
				string text2 = ((num == -1) ? "Random" : ((num == 0) ? "Editor" : GlobalVariables.instance.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD[num - 1]));
				if (text2 == "Editor")
				{
					ColorProfileEditor.\u02BE\u02B3\u02B7\u02BD\u02BA\u02BB\u02B4\u02B7\u02B5\u02B3\u02B2(this.controllingPlayer.playerProfile);
					return;
				}
				this.controllingPlayer.playerProfile.colorProfileName.CurrentValue = text2;
				if (num != -1)
				{
					this.controllingPlayer.playerProfile.colorSettings = GlobalVariables.instance.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02C0\u02BB\u02B2\u02B6\u02B4\u02B3\u02BF\u02B2\u02B5\u02B8\u02BA(text2);
					return;
				}
				if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
				{
					this.controllingPlayer.playerProfile.\u02B4\u02BF\u02B9\u02BF\u02B3\u02B9\u02B9\u02B6\u02B5\u02BF\u02BB();
					this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = true;
					return;
				}
			}
		}
	}

	public virtual void \u02BC\u02C0\u02B9\u02BF\u02C1\u02C0\u02B5\u02B7\u02BD\u02BD\u02B6()
	{
		if (this.controllingPlayer == null)
		{
			return;
		}
		if (!this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
		{
			return;
		}
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = true;
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = true;
		}
	}

	public bool \u02B7\u02BB\u02B5\u02B4\u02B6\u02BD\u02BA\u02BA\u02B6\u02BD\u02BC
	{
		get
		{
			return this.controllingPlayer.playerProfile != null;
		}
	}

	private void \u02B6\u02BA\u02BD\u02BE\u02B6\u02B3\u02BF\u02C1\u02B5\u02B2\u02BC()
	{
		if (this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text.Trim().Length > 0)
		{
			ReInput.controllers.Keyboard.enabled = true;
			this.\u02BE\u02B5\u02B7\u02C1\u02B2\u02B3\u02B3\u02BD\u02C0\u02B3\u02B6 = false;
			this.\u02BF\u02B4\u02BE\u02B3\u02C1\u02BE\u02BE\u02B2\u02B8\u02B2\u02BC.enabled = true;
			if (this.\u02C1\u02B7\u02BA\u02B7\u02BB\u02BE\u02B8\u02B5\u02BB\u02B8\u02B8)
			{
				this.\u02C1\u02B7\u02BA\u02B7\u02BB\u02BE\u02B8\u02B5\u02BB\u02B8\u02B8 = false;
				this.\u02B9\u02C1\u02C1\u02C1\u02B2\u02BE\u02B3\u02BD\u02C0\u02BD\u02B4();
				this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = true;
				this.controllingPlayer.playerProfile.playerName.CurrentValue = this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text;
			}
			else
			{
				\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B = GlobalVariables.instance.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B4\u02C0\u02B6\u02B9\u02BE\u02BE\u02C1\u02B2\u02B6\u02B4\u02B6(false, false);
				u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.playerName.CurrentValue = this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text.Trim();
				Settings.Commit(false);
				this.\u02BA\u02B5\u02BC\u02C0\u02BE\u02BB\u02B3\u02C0\u02BD\u02BB\u02B8(u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B);
			}
			this.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(false);
		}
	}

	protected override void Start()
	{
		this.\u02BF\u02B4\u02BE\u02B3\u02C1\u02BE\u02BE\u02B2\u02B8\u02B2\u02BC = GameObject.Find("ControlMapper").GetComponent<ControlMapper>();
		if (this.parentTransform == null)
		{
			this.parentTransform = base.GetComponent<RectTransform>();
		}
		CHPlayer chplayer = GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			if (chplayer.player == null)
			{
				if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
				{
					this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].playerProfile.playerName.CurrentValueDisplay;
					this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.color = Color.green;
				}
				else
				{
					this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = "";
				}
			}
			else
			{
				this.\u02BB\u02C0\u02BC\u02B3\u02B2\u02B5\u02B5\u02B6\u02B6\u02B7\u02BD();
				this.controllingPlayer.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = this;
			}
		}
		else if (chplayer.player == null)
		{
			base.StartCoroutine(this.\u02BC\u02B2\u02B2\u02B3\u02B6\u02C1\u02BD\u02BC\u02B8\u02C1\u02B6());
		}
		else
		{
			this.\u02BB\u02C0\u02BC\u02B3\u02B2\u02B5\u02B5\u02B6\u02B6\u02B7\u02BD();
			this.controllingPlayer.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = this;
		}
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = true;
		this.instIcons.SetActive(false);
		base.Start();
	}

	public virtual void \u02BF\u02BE\u02BB\u02C0\u02B4\u02B6\u02BA\u02B4\u02BC\u02BC\u02BB()
	{
		if (this.controllingPlayer == null)
		{
			return;
		}
		if (!this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
		{
			return;
		}
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = true;
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = false;
		}
	}

	public int \u02BB\u02B4\u02C0\u02B3\u02B2\u02BB\u02C1\u02BE\u02B5\u02BD\u02C0()
	{
		\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 playerProfile = this.controllingPlayer.playerProfile;
		int num = ((playerProfile.colorProfileName == "Random") ? 0 : (GlobalVariables.instance.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02BB\u02B8\u02B6\u02BA\u02B4\u02BC\u02BB\u02B3\u02C0\u02B5\u02BF(playerProfile.colorProfileName) + 2));
		if (num == -1)
		{
			num = GlobalVariables.instance.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02BB\u02B8\u02B6\u02BA\u02B4\u02BC\u02BB\u02B3\u02C0\u02B5\u02BF(GlobalVariables.instance.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0) + 1;
		}
		return num;
	}

	private IEnumerator \u02B2\u02C0\u02BA\u02BC\u02B4\u02BB\u02B7\u02C1\u02B3\u02B7\u02C0()
	{
		yield return null;
		this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
		yield break;
	}

	private void \u02B2\u02BC\u02B3\u02B2\u02C0\u02B9\u02BB\u02B2\u02C0\u02C0\u02B3()
	{
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = false;
		if (this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1)
		{
			this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = false;
			Settings.Commit(false);
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
			{
				\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BB\u02B6\u02B7\u02BF\u02B5\u02B2\u02B6\u02C0\u02BA\u02BB(this.controllingPlayer.playerProfile);
			}
		}
		if (this.midiSetupMenu.enabled)
		{
			this.midiSetupMenu.enabled = false;
			base.enabled = true;
		}
		base.StartCoroutine(this.\u02B6\u02B3\u02C1\u02B7\u02B3\u02B5\u02B7\u02BA\u02B8\u02C0\u02BD());
		if (this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE != null)
		{
			base.StopCoroutine(this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE);
		}
		this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE = base.StartCoroutine(this.\u02B3\u02B9\u02B4\u02C1\u02B7\u02B3\u02BF\u02BE\u02BA\u02BF\u02C1(false));
		this.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(false);
	}

	private void FixedUpdate()
	{
		CHPlayer chplayer = GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		this.instrumentImage.enabled = false;
		this.hostImage.enabled = false;
		this.\u02C0\u02B2\u02B2\u02B5\u02B7\u02B8\u02BA\u02BD\u02BB\u02BD\u02B2.SetActive(false);
		if (!chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD || chplayer.playerProfile == null)
		{
			return;
		}
		this.instrumentImage.enabled = true;
		this.instrumentImage.sprite = this.instrumentIcons[(int)chplayer.playerProfile.controllerType.GetControllerType];
		this.hostImage.enabled = CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02BC\u02B2\u02B9\u02BF\u02B2\u02B4\u02C0\u02B4\u02B8\u02B4 == this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7;
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.\u02C0\u02B2\u02B2\u02B5\u02B7\u02B8\u02BA\u02BD\u02BB\u02BD\u02B2.SetActive(true);
			this.latencyValue.text = string.Format("{0}", \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B7\u02BE\u02B3\u02B8\u02BF\u02BC\u02BC\u02BE\u02B3\u02B2[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7]);
		}
		if (!this.\u02BA\u02B9\u02BB\u02BB\u02C0\u02C0\u02B6\u02C1\u02B6\u02BD\u02BD && CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && this.menuStrings.Length != 0)
		{
			this.\u02B2\u02B7\u02B4\u02BA\u02BF\u02B8\u02BF\u02C0\u02B5\u02B3\u02B8("Leave Server", 1);
			this.\u02BA\u02B9\u02BB\u02BB\u02C0\u02C0\u02B6\u02C1\u02B6\u02BD\u02BD = true;
		}
	}

	public void \u02B8\u02BA\u02B7\u02BB\u02BC\u02B9\u02C1\u02B3\u02BB\u02B5\u02B6(bool \u02B7\u02B8\u02B8\u02B6\u02C1\u02B3\u02BC\u02BC\u02BD\u02B4\u02C0)
	{
		if (this.controllingPlayer == null)
		{
			return;
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B7\u02B6\u02B9\u02B5\u02BC\u02B2\u02BB\u02B2\u02BD())
		{
			this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = true;
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B9\u02B2\u02C1\u02BC\u02B2\u02B8\u02BC\u02BF\u02B9\u02BE();
			return;
		}
		if (this.onlineMenu.isActiveAndEnabled)
		{
			return;
		}
		if (this.controllingPlayer.playerProfile != null)
		{
			if (\u02B7\u02B8\u02B8\u02B6\u02C1\u02B3\u02BC\u02BC\u02BD\u02B4\u02C0)
			{
				this.controllingPlayer.playerProfile = null;
			}
			else
			{
				if (this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1)
				{
					this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = false;
					Settings.Commit(true);
				}
				GlobalVariables.instance.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02BA\u02B4\u02BE\u02BE\u02B6\u02B4\u02B5\u02B9\u02B4\u02BE\u02B7(this.controllingPlayer.playerProfile);
				this.controllingPlayer.playerProfile = null;
				this.\u02B3\u02B2\u02B7\u02BB\u02B4\u02B8\u02B4\u02BD\u02BE\u02BB\u02BB();
			}
		}
		GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02C0\u02B9\u02B5\u02BF\u02B5\u02B6\u02B3\u02B7\u02B9\u02C1\u02BC();
		GlobalVariables.instance.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD--;
		this.controllingPlayer.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = null;
		this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
		this.controllingPlayer = null;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.menuStrings = new string[1];
		base.\u02BA\u02B9\u02C1\u02C1\u02BF\u02C1\u02BC\u02BA\u02B3\u02BB\u02C0();
		if (this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE != null)
		{
			base.StopCoroutine(this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE);
		}
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = true;
		this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE = base.StartCoroutine(this.\u02B3\u02B9\u02B4\u02C1\u02B7\u02B3\u02BF\u02BE\u02BA\u02BF\u02C1(false));
		base.StartCoroutine(this.\u02BC\u02B2\u02B2\u02B3\u02B6\u02C1\u02BD\u02BC\u02B8\u02C1\u02B6());
	}

	private void \u02B9\u02C1\u02C1\u02C1\u02B2\u02BE\u02B3\u02BD\u02C0\u02BD\u02B4()
	{
		this.menuStrings = this.profileOptions;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
	}

	public void \u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(bool \u02B3\u02B9\u02BE\u02BC\u02B3\u02B6\u02B6\u02B6\u02C1\u02BB\u02C1 = false)
	{
		if (\u02B3\u02B9\u02BE\u02BC\u02B3\u02B6\u02B6\u02B6\u02C1\u02BB\u02C1)
		{
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = "";
			this.\u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF.CrossFadeColor(this.\u02B3\u02B9\u02B4\u02C1\u02BB\u02B6\u02C1\u02BE\u02C0\u02C1\u02B2, 1f, true, false);
			base.\u02B8\u02BE\u02BD\u02BB\u02B2\u02B6\u02B3\u02BB\u02BB\u02C0\u02B8(null);
			return;
		}
		if (!this.\u02BD\u02B4\u02B6\u02BA\u02B9\u02BB\u02C0\u02C0\u02BE\u02B7\u02BE)
		{
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = LanguageManager.instance.GetString("PRESS START");
			this.\u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF.CrossFadeColor(this.\u02B3\u02B9\u02B4\u02C1\u02BB\u02B6\u02C1\u02BE\u02C0\u02C1\u02B2, 1f, true, false);
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.color = Color.white;
			return;
		}
		if (this.controllingPlayer.playerProfile.isBot)
		{
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = this.controllingPlayer.playerProfile.playerName.CurrentValueNoTags;
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.color = Color.cyan;
		}
		else
		{
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = (this.controllingPlayer.playerProfile.isGuestProfile ? this.controllingPlayer.playerProfile.playerName.CurrentValue : this.controllingPlayer.playerProfile.playerName.CurrentValueDisplay);
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.color = (this.controllingPlayer.playerProfile.isGuestProfile ? this.guestColor : this.defaultColor);
		}
		this.\u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF.CrossFadeColor(this.\u02BF\u02B7\u02BB\u02BB\u02BF\u02B9\u02B9\u02BF\u02C1\u02B2\u02BC, 1f, true, false);
	}

	private void \u02B7\u02C0\u02BF\u02BD\u02B3\u02B4\u02B8\u02BB\u02B9\u02B8\u02BE()
	{
		this.\u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF.CrossFadeColor(this.\u02BF\u02B7\u02BB\u02BB\u02BF\u02B9\u02B9\u02BF\u02C1\u02B2\u02BC, 1f, true, false);
		foreach (char c in Input.inputString)
		{
			if (c == '\b')
			{
				if (this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text.Length > 0)
				{
					this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text.Substring(0, this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text.Length - 1);
				}
			}
			else
			{
				if (c == '\n' || c == '\r')
				{
					this.\u02B6\u02BA\u02BD\u02BE\u02B6\u02B3\u02BF\u02C1\u02B5\u02B2\u02BC();
					return;
				}
				if ((this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text.Length != 0 || c != ' ') && this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text.Length != 15)
				{
					TextMeshProUGUI u02C1_u02BB_u02B5_u02BE_u02B6_u02B8_u02C1_u02C0_u02B4_u02B9_u02BB = this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB;
					u02C1_u02BB_u02B5_u02BE_u02B6_u02B8_u02C1_u02C0_u02B4_u02B9_u02BB.text += c.ToString();
					this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = Regex.Replace(this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text, "[^\\u0020-\\u007E]", string.Empty);
					if (string.IsNullOrEmpty(this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text))
					{
						this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = "";
					}
				}
			}
		}
		if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
		{
			this.\u02B6\u02BA\u02BD\u02BE\u02B6\u02B3\u02BF\u02C1\u02B5\u02B2\u02BC();
			return;
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			this.\u02BE\u02BA\u02B5\u02C0\u02B9\u02BF\u02BB\u02B4\u02B2\u02BB\u02B5();
		}
	}

	private IEnumerator \u02BC\u02B2\u02B2\u02B3\u02B6\u02C1\u02BD\u02BC\u02B8\u02C1\u02B6()
	{
		this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = LanguageManager.instance.GetString("PRESS START");
		this.\u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF.CrossFadeColor(this.\u02B3\u02B9\u02B4\u02C1\u02BB\u02B6\u02C1\u02BE\u02C0\u02C1\u02B2, 1f, true, false);
		this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.color = Color.white;
		while (this.controllingPlayer == null)
		{
			if (!this.\u02BF\u02B4\u02BE\u02B3\u02C1\u02BE\u02BE\u02B2\u02B8\u02B2\u02BC.isOpen && !this.songSelectSearch.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 && !CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && !this.onlineMenu.isActiveAndEnabled)
			{
				int num = 0;
				for (int i = 0; i < GlobalVariables.instance.playerList.Count; i++)
				{
					if (GlobalVariables.instance.playerList[i].player == null)
					{
						num = i;
						break;
					}
				}
				if (num == this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
				{
					IList<Player> players = ReInput.players.Players;
					for (int j = 0; j < players.Count; j++)
					{
						Player player = players[j];
						if (!player.isPlaying && player.GetButtonDown("Start") && !ColorProfileEditor.\u02BF\u02B3\u02B6\u02B5\u02BB\u02B7\u02BE\u02BF\u02C1\u02BA\u02BF() && !SongPathsManager.\u02BF\u02B3\u02B6\u02B5\u02BB\u02B7\u02BE\u02BF\u02C1\u02BA\u02BF())
						{
							this.\u02B8\u02B8\u02B7\u02BE\u02B2\u02BE\u02B9\u02B8\u02BD\u02B9\u02B6(player);
							break;
						}
					}
				}
			}
			yield return null;
		}
		yield break;
	}

	public void \u02BE\u02B6\u02BE\u02B2\u02B2\u02BF\u02B3\u02B7\u02BC\u02BC\u02BE(short \u02B7\u02BB\u02BF\u02BE\u02C1\u02B9\u02B2\u02B2\u02BF\u02B7\u02B4)
	{
		Debug.Log(string.Format("' plural '", \u02B7\u02BB\u02BF\u02BE\u02C1\u02B9\u02B2\u02B2\u02BF\u02B7\u02B4, this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text));
		this.latencyValue.text = string.Format("profiles", \u02B7\u02BB\u02BF\u02BE\u02C1\u02B9\u02B2\u02B2\u02BF\u02B7\u02B4);
	}

	private void \u02B8\u02BA\u02BF\u02B3\u02BB\u02B6\u02C0\u02BA\u02BE\u02BF\u02BE(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
	{
		if (\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 != this.\u02BE\u02BD\u02B8\u02BE\u02C1\u02BA\u02B4\u02B8\u02BD\u02BF\u02B8)
		{
			this.\u02BB\u02B5\u02BA\u02BE\u02BD\u02B8\u02B9\u02B9\u02C1\u02B8\u02BB(this.\u02B6\u02BB\u02BD\u02C0\u02B2\u02BD\u02BB\u02BF\u02B7\u02BF\u02B8, \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 - 1);
			this.\u02BB\u02B5\u02BA\u02BE\u02BD\u02B8\u02B9\u02B9\u02C1\u02B8\u02BB(this.\u02B4\u02B9\u02C0\u02B4\u02BD\u02BD\u02B2\u02BB\u02B3\u02B6\u02B7, \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 + 1);
			if (\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 == -1)
			{
				this.\u02C0\u02B5\u02B2\u02BD\u02BA\u02B5\u02C1\u02B7\u02B5\u02C0\u02BF.texture = this.\u02B3\u02B9\u02B9\u02BD\u02B6\u02B2\u02C1\u02BE\u02B3\u02BF\u02B7;
				this.\u02BE\u02BD\u02B8\u02BE\u02C1\u02BA\u02B4\u02B8\u02BD\u02BF\u02B8 = -1;
				return;
			}
			this.\u02C0\u02B5\u02B2\u02BD\u02BA\u02B5\u02C1\u02B7\u02B5\u02C0\u02BF.texture = GlobalVariables.instance.\u02BC\u02B3\u02C1\u02C0\u02B6\u02B2\u02BE\u02B7\u02C1\u02BF\u02B5(\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, false);
			this.\u02BE\u02BD\u02B8\u02BE\u02C1\u02BA\u02B4\u02B8\u02BD\u02BF\u02B8 = \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5;
		}
	}

	private void \u02BA\u02B5\u02BC\u02C0\u02BE\u02BB\u02B3\u02C0\u02BD\u02BB\u02B8(\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 \u02B3\u02B8\u02B9\u02B7\u02B8\u02BD\u02B4\u02C0\u02C0\u02B3\u02B9)
	{
		if (base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0 == "Create Profile")
		{
			this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = 0);
			this.\u02B9\u02BF\u02BF\u02BE\u02B5\u02B2\u02B5\u02B5\u02B3\u02B8\u02C0(false);
			return;
		}
		if (\u02B3\u02B8\u02B9\u02B7\u02B8\u02BD\u02B4\u02C0\u02C0\u02B3\u02B9 == null)
		{
			if (base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0 == "Guest")
			{
				this.controllingPlayer.playerProfile = GlobalVariables.instance.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B4\u02C0\u02B6\u02B9\u02BE\u02BE\u02C1\u02B2\u02B6\u02B4\u02B6(true, false);
				this.\u02B2\u02B8\u02B6\u02BA\u02B9\u02B2\u02B6\u02BA\u02B3\u02B2\u02BA();
			}
			else
			{
				this.controllingPlayer.playerProfile = GlobalVariables.instance.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02C0\u02BA\u02BA\u02B3\u02BE\u02BE\u02B8\u02BE\u02C1\u02B5\u02BF(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
				this.\u02B2\u02B8\u02B6\u02BA\u02B9\u02B2\u02B6\u02BA\u02B3\u02B2\u02BA();
			}
		}
		else
		{
			this.controllingPlayer.playerProfile = \u02B3\u02B8\u02B9\u02B7\u02B8\u02BD\u02B4\u02C0\u02C0\u02B3\u02B9;
		}
		if (this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE != null)
		{
			base.StopCoroutine(this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE);
		}
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = false;
		if (\u02B3\u02B8\u02B9\u02B7\u02B8\u02BD\u02B4\u02C0\u02C0\u02B3\u02B9 != null)
		{
			this.menuStrings = new string[0];
			this.\u02BA\u02BD\u02BF\u02B4\u02BB\u02B8\u02B4\u02BB\u02C1\u02B8\u02BA = true;
		}
		else
		{
			this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE = base.StartCoroutine(this.\u02B3\u02B9\u02B4\u02C1\u02B7\u02B3\u02BF\u02BE\u02BA\u02BF\u02C1(false));
			base.StartCoroutine(this.\u02B6\u02B3\u02C1\u02B7\u02B3\u02B5\u02B7\u02BA\u02B8\u02C0\u02BD());
		}
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
		this.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(false);
		this.\u02B3\u02B2\u02B7\u02BB\u02B4\u02B8\u02B4\u02BD\u02BE\u02BB\u02BB();
		this.allowMultiLanguage = true;
		if (this.\u02BA\u02BD\u02BF\u02B4\u02BB\u02B8\u02B4\u02BB\u02C1\u02B8\u02BA)
		{
			this.\u02BC\u02BE\u02BE\u02B7\u02B9\u02BC\u02C1\u02BD\u02C1\u02BF\u02BD();
			this.ConfirmPressed();
		}
	}

	private IEnumerator \u02BD\u02B2\u02C1\u02B2\u02BC\u02BC\u02B6\u02BE\u02BF\u02BC\u02B6(bool \u02C1\u02BC\u02B2\u02BF\u02BF\u02C1\u02BD\u02B4\u02BA\u02B4\u02B6)
	{
		Vector3 endPosition;
		if (\u02C1\u02BC\u02B2\u02BF\u02BF\u02C1\u02BD\u02B4\u02BA\u02B4\u02B6)
		{
			endPosition = new Vector3(this.parentTransform.anchoredPosition.x, 0f, 0f);
		}
		else
		{
			endPosition = new Vector3(this.parentTransform.anchoredPosition.x, -310f, 0f);
			this.menuStrings = new string[0];
			Image[] backgroundObjects = this.optionChecks;
			for (int i = 0; i < backgroundObjects.Length; i++)
			{
				backgroundObjects[i].enabled = false;
			}
			TextMeshProUGUI[] textObjects = this.textObjects;
			for (int i = 0; i < textObjects.Length; i++)
			{
				textObjects[i].text = "";
			}
			backgroundObjects = this.backgroundObjects;
			for (int i = 0; i < backgroundObjects.Length; i++)
			{
				backgroundObjects[i].color = this.highlightColor;
			}
		}
		float startTime = Time.time;
		while (this.parentTransform.anchoredPosition.y < endPosition.y || this.parentTransform.anchoredPosition.y > endPosition.y)
		{
			this.parentTransform.anchoredPosition = Vector3.Lerp(this.parentTransform.anchoredPosition, endPosition, Mathf.SmoothStep(0f, 1f, Time.time - startTime));
			yield return new WaitForSeconds(0.016f);
		}
		this.parentTransform.anchoredPosition = endPosition;
		yield break;
	}

	public static void \u02B7\u02BD\u02BB\u02B2\u02B5\u02B9\u02B9\u02BE\u02BD\u02B2\u02B6(int \u02B4\u02B9\u02B9\u02C1\u02B2\u02B4\u02BD\u02BD\u02B8\u02BD\u02BC)
	{
		PlayerProfileMenu[] array = global::UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>();
		for (int i = 1; i < array.Length; i += 0)
		{
			PlayerProfileMenu playerProfileMenu = array[i];
			if (playerProfileMenu.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 != \u02B4\u02B9\u02B9\u02C1\u02B2\u02B4\u02BD\u02BD\u02B8\u02BD\u02BC)
			{
				playerProfileMenu.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(true);
			}
		}
	}

	public override void ConfirmPressed()
	{
		if (this.controllingPlayer == null)
		{
			return;
		}
		if (!this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
		{
			return;
		}
		if (this.controllingPlayer.playerProfile == null)
		{
			this.\u02BA\u02B5\u02BC\u02C0\u02BE\u02BB\u02B3\u02C0\u02BD\u02BB\u02B8(null);
			base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
			return;
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 playerProfile = this.controllingPlayer.playerProfile;
			this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.None;
			string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			uint num = PrivateImplementationDetails.ComputeStringHash(text);
			if (num <= 2503720658U)
			{
				if (num <= 1642511898U)
				{
					if (num <= 892887250U)
					{
						if (num != 565687656U)
						{
							if (num == 892887250U)
							{
								if (text == "Lefty Flip")
								{
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerProfile.leftyFlip;
									this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Bool;
								}
							}
						}
						else if (text == "Drop Out")
						{
							this.\u02BF\u02BD\u02BA\u02B9\u02BB\u02BB\u02BD\u02BF\u02BC\u02BF\u02B4(false);
							this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
							return;
						}
					}
					else if (num != 893259077U)
					{
						if (num != 1313209304U)
						{
							if (num == 1642511898U)
							{
								if (text == "No")
								{
									this.\u02B9\u02C1\u02C1\u02C1\u02B2\u02BE\u02B3\u02BD\u02C0\u02BD\u02B4();
									this.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(false);
									base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0("Delete Profile");
									this.\u02B5\u02B7\u02B5\u02B6\u02B3\u02B4\u02B7\u02BB\u02BE\u02B6\u02B5 = false;
									return;
								}
							}
						}
						else if (text == "Highway Length")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerProfile.highwayLength;
							this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Percent;
						}
					}
					else if (text == "Options")
					{
						this.\u02B9\u02C1\u02C1\u02C1\u02B2\u02BE\u02B3\u02BD\u02C0\u02BD\u02B4();
						return;
					}
				}
				else if (num <= 1798595441U)
				{
					if (num != 1670365771U)
					{
						if (num != 1764869839U)
						{
							if (num == 1798595441U)
							{
								if (text == "MIDI Settings")
								{
									this.\u02B5\u02C1\u02BD\u02BE\u02B7\u02BF\u02C0\u02B2\u02BC\u02B5\u02BE();
									this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
									return;
								}
							}
						}
						else if (text == "Square Tom Notes")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerProfile.squareTomNotes;
							this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Bool;
						}
					}
					else if (text == "Leave Server")
					{
						this.\u02B2\u02BC\u02B3\u02B2\u02C0\u02B9\u02BB\u02B2\u02C0\u02C0\u02B3();
						\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B9\u02B2\u02C1\u02BC\u02B2\u02B8\u02BC\u02BF\u02B9\u02BE();
						return;
					}
				}
				else if (num != 1891779025U)
				{
					if (num != 2464313451U)
					{
						if (num == 2503720658U)
						{
							if (text == "Note Speed")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerProfile.noteSpeed;
								this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Int;
							}
						}
					}
					else if (text == "Gamepad Mode")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerProfile.gamepadMode;
						this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Bool;
					}
				}
				else if (text == "Show Accuracy")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerProfile.isAccuracyDisplay;
					this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Bool;
				}
			}
			else if (num <= 3013883440U)
			{
				if (num <= 2778101613U)
				{
					if (num != 2707328673U)
					{
						if (num == 2778101613U)
						{
							if (text == "Color Profile")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerProfile.colorIndex;
								int num2 = this.\u02BB\u02B4\u02C0\u02B3\u02B2\u02BB\u02C1\u02BE\u02B5\u02BD\u02C0();
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue = num2;
								this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.String;
								this.\u02BF\u02B8\u02BC\u02B4\u02BA\u02C1\u02C0\u02B9\u02BA\u02B4\u02B7 = GlobalVariables.instance.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2.Count + 2;
								this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = num2;
							}
						}
					}
					else if (text == "Controller")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerProfile.controllerType;
						this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.String;
						this.instIcons.SetActive(true);
						this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue;
						this.\u02BF\u02B8\u02BC\u02B4\u02BA\u02C1\u02C0\u02B9\u02BA\u02B4\u02B7 = 4;
					}
				}
				else if (num != 2874894780U)
				{
					if (num != 2970654147U)
					{
						if (num == 3013883440U)
						{
							if (text == "Yes")
							{
								GlobalVariables.instance.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B9\u02BA\u02B5\u02BF\u02B9\u02BA\u02BC\u02B2\u02C1\u02B8\u02B4(this.controllingPlayer.playerProfile);
								this.\u02BF\u02BD\u02BA\u02B9\u02BB\u02BB\u02BD\u02BF\u02BC\u02BF\u02B4(true);
								this.\u02B5\u02B7\u02B5\u02B6\u02B3\u02B4\u02B7\u02BB\u02BE\u02B6\u02B5 = false;
								return;
							}
						}
					}
					else if (text == "Alternate Tap Texture")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerProfile.altTaps;
						this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Bool;
					}
				}
				else if (text == "Highway")
				{
					this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.String;
					this.\u02BF\u02B8\u02BC\u02B4\u02BA\u02C1\u02C0\u02B9\u02BA\u02B4\u02B7 = GlobalVariables.instance.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Count + 1;
					this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = GlobalVariables.instance.\u02BA\u02C0\u02C1\u02B9\u02B4\u02BB\u02B9\u02B2\u02C0\u02B4\u02B5(playerProfile.highwayName.CurrentValue) + 1;
					this.\u02B8\u02B3\u02B4\u02B9\u02BC\u02C1\u02B6\u02B7\u02B4\u02B9\u02B8(true);
				}
			}
			else if (num <= 3628891427U)
			{
				if (num != 3460482988U)
				{
					if (num != 3607655226U)
					{
						if (num == 3628891427U)
						{
							if (text == "Hide Accents/Ghosts")
							{
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerProfile.drumDynamicsHidden;
								this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Bool;
							}
						}
					}
					else if (text == "Rename Profile")
					{
						this.\u02B9\u02BF\u02BF\u02BE\u02B5\u02B2\u02B5\u02B5\u02B3\u02B8\u02C0(true);
						return;
					}
				}
				else if (text == "Display Name")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerProfile.displayName;
					this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Bool;
				}
			}
			else if (num != 3653993758U)
			{
				if (num != 3804515427U)
				{
					if (num == 3806402342U)
					{
						if (text == "Tilt")
						{
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerProfile.tilt;
							this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Bool;
						}
					}
				}
				else if (text == "Delete Profile")
				{
					if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB || this.onlineMenu.isActiveAndEnabled)
					{
						return;
					}
					this.\u02B5\u02B7\u02B5\u02B6\u02B3\u02B4\u02B7\u02BB\u02BE\u02B6\u02B5 = true;
					this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = LanguageManager.instance.GetString("Are you sure?");
					this.\u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF.CrossFadeColor(this.\u02BF\u02B7\u02BB\u02BB\u02BF\u02B9\u02B9\u02BF\u02C1\u02B2\u02BC, 1f, true, false);
					this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.color = Color.white;
					this.menuStrings = new string[] { "Yes", "No" };
					this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
					this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
					base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0("No");
					return;
				}
			}
			else if (text == "Bot")
			{
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerProfile.isBot;
				this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Bool;
			}
			PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5 u02B8_u02BE_u02B9_u02B7_u02B8_u02B9_u02B5_u02BA_u02BF_u02C1_u02BD = this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD;
			if (u02B8_u02BE_u02B9_u02B7_u02B8_u02B9_u02B5_u02BA_u02BF_u02C1_u02BD - PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Int > 1)
			{
				if (u02B8_u02BE_u02B9_u02B7_u02B8_u02B9_u02B5_u02BA_u02BF_u02C1_u02BD == PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Bool)
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue = (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC ? 0 : 1);
					this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = true;
					this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
					if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Bot")
					{
						this.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(false);
					}
					this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
					return;
				}
			}
			else
			{
				this.\u02BF\u02B8\u02BC\u02B4\u02BA\u02C1\u02C0\u02B9\u02BA\u02B4\u02B7 = (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.MaxValue - this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.MinValue) / this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.IncrementAmount + 1;
				this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = this.\u02BF\u02B8\u02BC\u02B4\u02BA\u02C1\u02C0\u02B9\u02BA\u02B4\u02B7 - (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue - this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.MinValue) / this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.IncrementAmount - 1;
			}
			int num3 = this.\u02BF\u02B8\u02BC\u02B4\u02BA\u02C1\u02C0\u02B9\u02BA\u02B4\u02B7 - this.textObjects.Length;
			this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = ((num3 > 0) ? this.textObjects.Length : this.\u02BF\u02B8\u02BC\u02B4\u02BA\u02C1\u02C0\u02B9\u02BA\u02B4\u02B7);
			this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = Mathf.Clamp(num3, 0, int.MaxValue);
			this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3, false);
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			for (int i = 0; i < this.optionChecks.Length; i++)
			{
				this.optionChecks[i].enabled = false;
			}
			return;
		}
		this.\u02B8\u02B3\u02B4\u02B9\u02BC\u02C1\u02B6\u02B7\u02B4\u02B9\u02B8(false);
		this.\u02BC\u02BC\u02BF\u02BB\u02B4\u02C1\u02BC\u02B2\u02B3\u02B2\u02BD();
		this.menuStrings = (this.controllingPlayer.playerProfile.IsAnyGuitarController ? this.guitarOptions : this.drumsOptions);
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3);
		this.instIcons.SetActive(false);
		if (this.controllingPlayer.playerProfile.\u02BA\u02C0\u02BC\u02BB\u02B7\u02B3\u02B8\u02BA\u02B2\u02B9\u02BA == this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC && MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
		{
			MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B2\u02BE\u02BF\u02BB\u02C0\u02BE\u02BD\u02B9\u02BC\u02BB(this.controllingPlayer, this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue);
		}
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = true;
		if (this.\u02BA\u02BD\u02BF\u02B4\u02BB\u02B8\u02B4\u02BB\u02C1\u02B8\u02BA)
		{
			this.\u02B2\u02B8\u02B6\u02BA\u02B9\u02B2\u02B6\u02BA\u02B3\u02B2\u02BA();
			this.\u02B2\u02BC\u02B3\u02B2\u02C0\u02B9\u02BB\u02B2\u02C0\u02C0\u02B3();
			base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
		}
	}

	private IEnumerator \u02B3\u02B9\u02B4\u02C1\u02B7\u02B3\u02BF\u02BE\u02BA\u02BF\u02C1(bool \u02C1\u02BC\u02B2\u02BF\u02BF\u02C1\u02BD\u02B4\u02BA\u02B4\u02B6)
	{
		if (\u02C1\u02BC\u02B2\u02BF\u02BF\u02C1\u02BD\u02B4\u02BA\u02B4\u02B6)
		{
			endPosition = new Vector3(this.parentTransform.anchoredPosition.x, 0f, 0f);
		}
		else
		{
			endPosition = new Vector3(this.parentTransform.anchoredPosition.x, -310f, 0f);
			this.menuStrings = new string[0];
			Image[] backgroundObjects = this.optionChecks;
			for (int i = 0; i < backgroundObjects.Length; i++)
			{
				backgroundObjects[i].enabled = false;
			}
			TextMeshProUGUI[] textObjects = this.textObjects;
			for (int i = 0; i < textObjects.Length; i++)
			{
				textObjects[i].text = "";
			}
			backgroundObjects = this.backgroundObjects;
			for (int i = 0; i < backgroundObjects.Length; i++)
			{
				backgroundObjects[i].color = this.highlightColor;
			}
		}
		startTime = Time.time;
		while (this.parentTransform.anchoredPosition.y < endPosition.y || this.parentTransform.anchoredPosition.y > endPosition.y)
		{
			this.parentTransform.anchoredPosition = Vector3.Lerp(this.parentTransform.anchoredPosition, endPosition, Mathf.SmoothStep(0f, 1f, Time.time - startTime));
			yield return new WaitForSeconds(0.016f);
		}
		this.parentTransform.anchoredPosition = endPosition;
		yield break;
	}

	public void \u02B6\u02B7\u02B5\u02C1\u02B8\u02BB\u02BC\u02B8\u02BF\u02BA\u02B7(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;
	}

	public static void \u02BB\u02BE\u02B8\u02BF\u02BF\u02B2\u02C0\u02B8\u02B6\u02BB\u02BD(int \u02B4\u02B9\u02B9\u02C1\u02B2\u02B4\u02BD\u02BD\u02B8\u02BD\u02BC)
	{
		foreach (PlayerProfileMenu playerProfileMenu in global::UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>())
		{
			if (playerProfileMenu.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 != \u02B4\u02B9\u02B9\u02C1\u02B2\u02B4\u02BD\u02BD\u02B8\u02BD\u02BC)
			{
				playerProfileMenu.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(true);
			}
		}
	}

	public bool \u02BD\u02B4\u02B6\u02BA\u02B9\u02BB\u02C0\u02C0\u02BE\u02B7\u02BE
	{
		get
		{
			return this.controllingPlayer != null;
		}
	}

	private void \u02BB\u02BD\u02B3\u02B4\u02BB\u02C0\u02BB\u02BC\u02B4\u02BD\u02BF()
	{
		this.\u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF.CrossFadeColor(this.\u02BF\u02B7\u02BB\u02BB\u02BF\u02B9\u02B9\u02BF\u02C1\u02B2\u02BC, 133f, true, true);
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\u0003')
			{
				if (this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text.Length > 0)
				{
					this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text.Substring(0, this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text.Length - 0);
				}
			}
			else
			{
				if (c == '\u0003' || (int)c == -102)
				{
					this.\u02B6\u02BA\u02BD\u02BE\u02B6\u02B3\u02BF\u02C1\u02B5\u02B2\u02BC();
					return;
				}
				if ((this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text.Length != 0 || (int)c != -63) && this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text.Length != 98)
				{
					TextMeshProUGUI u02C1_u02BB_u02B5_u02BE_u02B6_u02B8_u02C1_u02C0_u02B4_u02B9_u02BB = this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB;
					u02C1_u02BB_u02B5_u02BE_u02B6_u02B8_u02C1_u02C0_u02B4_u02B9_u02BB.text += c.ToString();
					this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = Regex.Replace(this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text, "default", string.Empty);
					if (string.IsNullOrEmpty(this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text))
					{
						this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = "Rainbow";
					}
				}
			}
		}
		if (Input.GetKeyDown((KeyCode)2) || Input.GetKeyDown((KeyCode)187))
		{
			this.\u02B6\u02BA\u02BD\u02BE\u02B6\u02B3\u02BF\u02C1\u02B5\u02B2\u02BC();
			return;
		}
		if (Input.GetKeyDown((KeyCode)(-31)))
		{
			this.\u02B8\u02B3\u02C1\u02B6\u02BB\u02C0\u02B8\u02BA\u02BF\u02BD\u02BF();
		}
	}

	public void \u02BF\u02BD\u02BA\u02B9\u02BB\u02BB\u02BD\u02BF\u02BC\u02BF\u02B4(bool \u02B7\u02B8\u02B8\u02B6\u02C1\u02B3\u02BC\u02BC\u02BD\u02B4\u02C0)
	{
		if (this.controllingPlayer == null)
		{
			return;
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B9\u02B2\u02C1\u02BC\u02B2\u02B8\u02BC\u02BF\u02B9\u02BE();
			return;
		}
		if (this.onlineMenu.isActiveAndEnabled)
		{
			return;
		}
		if (this.controllingPlayer.playerProfile != null)
		{
			if (\u02B7\u02B8\u02B8\u02B6\u02C1\u02B3\u02BC\u02BC\u02BD\u02B4\u02C0)
			{
				this.controllingPlayer.playerProfile = null;
			}
			else
			{
				if (this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1)
				{
					this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = false;
					Settings.Commit(false);
				}
				GlobalVariables.instance.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02BE\u02BC\u02BA\u02B7\u02BA\u02BB\u02B7\u02BD\u02B7\u02B3\u02B3(this.controllingPlayer.playerProfile);
				this.controllingPlayer.playerProfile = null;
				this.\u02B3\u02B2\u02B7\u02BB\u02B4\u02B8\u02B4\u02BD\u02BE\u02BB\u02BB();
			}
		}
		GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02C0\u02B9\u02B5\u02BF\u02B5\u02B6\u02B3\u02B7\u02B9\u02C1\u02BC();
		GlobalVariables.instance.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD--;
		this.controllingPlayer.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = null;
		this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
		this.controllingPlayer = null;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.menuStrings = new string[0];
		base.\u02BA\u02B9\u02C1\u02C1\u02BF\u02C1\u02BC\u02BA\u02B3\u02BB\u02C0();
		if (this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE != null)
		{
			base.StopCoroutine(this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE);
		}
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = false;
		this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE = base.StartCoroutine(this.\u02B3\u02B9\u02B4\u02C1\u02B7\u02B3\u02BF\u02BE\u02BA\u02BF\u02C1(false));
		base.StartCoroutine(this.\u02BC\u02B2\u02B2\u02B3\u02B6\u02C1\u02BD\u02BC\u02B8\u02C1\u02B6());
	}

	private void \u02B2\u02B8\u02B6\u02BA\u02B9\u02B2\u02B6\u02BA\u02B3\u02B2\u02BA()
	{
		GlobalVariables.instance.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B7\u02B7\u02B9\u02B6\u02B4\u02BC\u02BF\u02B9\u02BF\u02B5\u02B8(this.controllingPlayer.playerProfile);
		this.controllingPlayer.playerProfile.\u02B3\u02B9\u02C1\u02B5\u02BC\u02C1\u02C0\u02BA\u02B9\u02B4\u02B2(this.controllingPlayer);
		this.\u02BA\u02BD\u02BF\u02B4\u02BB\u02B8\u02B4\u02BB\u02C1\u02B8\u02BA = false;
	}

	public override void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		if (this.controllingPlayer == null)
		{
			return;
		}
		if (!this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
		{
			return;
		}
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = true;
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = false;
		}
	}

	private void \u02B9\u02BF\u02BF\u02BE\u02B5\u02B2\u02B5\u02B5\u02B3\u02B8\u02C0(bool \u02BF\u02C1\u02C1\u02B2\u02BC\u02B6\u02B4\u02B6\u02B5\u02BA\u02C1)
	{
		ReInput.controllers.Keyboard.enabled = false;
		this.\u02BF\u02B4\u02BE\u02B3\u02C1\u02BE\u02BE\u02B2\u02B8\u02B2\u02BC.enabled = false;
		this.\u02BE\u02B5\u02B7\u02C1\u02B2\u02B3\u02B3\u02BD\u02C0\u02B3\u02B6 = true;
		this.menuStrings = new string[2];
		base.\u02BA\u02B9\u02C1\u02C1\u02BF\u02C1\u02BC\u02BA\u02B3\u02BB\u02C0();
		Image[] backgroundObjects = this.backgroundObjects;
		for (int i = 0; i < backgroundObjects.Length; i++)
		{
			backgroundObjects[i].color = this.highlightColor;
		}
		if (!\u02BF\u02C1\u02C1\u02B2\u02BC\u02B6\u02B4\u02B6\u02B5\u02BA\u02C1)
		{
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = "";
			this.\u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF.CrossFadeColor(this.\u02BF\u02B7\u02BB\u02BB\u02BF\u02B9\u02B9\u02BF\u02C1\u02B2\u02BC, 1f, true, false);
		}
		else
		{
			this.\u02C1\u02B7\u02BA\u02B7\u02BB\u02BE\u02B8\u02B5\u02BB\u02B8\u02B8 = true;
		}
		this.textObjects[0].text = LanguageManager.instance.GetString("Type the profile name");
		this.textObjects[0].color = Color.white;
		this.textObjects[1].text = LanguageManager.instance.GetString("Press Enter to confirm");
		this.textObjects[1].color = Color.green;
		this.textObjects[2].text = LanguageManager.instance.GetString("Press Escape to cancel");
		this.textObjects[2].color = Color.red;
	}

	private void \u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5()
	{
		if (this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD == PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.None)
		{
			return;
		}
		int i = 0;
		int num = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
		bool flag = false;
		Color highlightColor = this.highlightColor;
		highlightColor.a = 1f;
		Color defaultColor = this.defaultColor;
		defaultColor.a = 1f;
		int num2 = this.\u02BB\u02B4\u02C0\u02B3\u02B2\u02BB\u02C1\u02BE\u02B5\u02BD\u02C0();
		while (i < this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
		{
			string text = string.Empty;
			this.backgroundObjects[i].color = ((this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 == i) ? this.defaultColor : this.highlightColor);
			this.textObjects[i].color = ((this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 == i) ? highlightColor : defaultColor);
			PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5 u02B8_u02BE_u02B9_u02B7_u02B8_u02B9_u02B5_u02BA_u02BF_u02C1_u02BD = this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD;
			if (u02B8_u02BE_u02B9_u02B7_u02B8_u02B9_u02B5_u02BA_u02BF_u02C1_u02BD != PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.String)
			{
				if (u02B8_u02BE_u02B9_u02B7_u02B8_u02B9_u02B5_u02BA_u02BF_u02C1_u02BD - PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Int <= 1)
				{
					text = (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.MaxValue - num * this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.IncrementAmount).ToString();
				}
			}
			else
			{
				string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
				if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Highway"))
				{
					if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Controller"))
					{
						if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Color Profile")
						{
							text = ((num == 0) ? LanguageManager.instance.GetString("Random") : ((num == 1) ? LanguageManager.instance.GetString("Editor") : GlobalVariables.instance.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD[num - 2]));
							this.optionChecks[i].enabled = i == num2;
							this.optionChecks[i].color = ((i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3) ? Color.black : Color.white);
						}
					}
					else
					{
						flag = true;
						switch (i)
						{
						case 0:
							text = "5 Fret Guitar";
							break;
						case 1:
							text = "6 Fret Guitar";
							break;
						case 2:
							text = "Drums";
							break;
						case 3:
							text = "5 Lane Drums";
							break;
						}
					}
				}
				else if (num == 0)
				{
					text = LanguageManager.instance.GetString("Random");
				}
				else
				{
					flag = GlobalVariables.instance.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[num - 1].isResource;
					text = GlobalVariables.instance.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[num - 1].name;
				}
			}
			if (this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD == PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Percent)
			{
				text += "%";
			}
			this.textObjects[i].text = "<noparse>" + (flag ? LanguageManager.instance.GetString(text) : text) + "</noparse>";
			num++;
			i++;
		}
		while (i < this.textObjects.Length)
		{
			this.textObjects[i].text = "";
			this.backgroundObjects[i].color = this.highlightColor;
			i++;
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Highway")
		{
			this.\u02BB\u02B5\u02BA\u02BE\u02BD\u02B8\u02B9\u02B9\u02C1\u02B8\u02BB(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC - 1);
		}
	}

	public void \u02BC\u02BE\u02BE\u02B7\u02B9\u02BC\u02C1\u02BD\u02C1\u02BF\u02BD()
	{
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			foreach (PlayerSelectionMenu playerSelectionMenu in global::UnityEngine.Object.FindObjectsOfType<PlayerSelectionMenu>())
			{
				if (playerSelectionMenu.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B3\u02B2\u02BA\u02BD\u02B6\u02BF\u02BA\u02C1\u02BA\u02B9 && playerSelectionMenu.\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6)
				{
					return;
				}
			}
		}
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
		this.menuStrings = (this.controllingPlayer.playerProfile.IsAnyGuitarController ? this.guitarOptions : this.drumsOptions);
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = true;
		if (this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE != null)
		{
			base.StopCoroutine(this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE);
		}
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = true;
		this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE = base.StartCoroutine(this.\u02B3\u02B9\u02B4\u02C1\u02B7\u02B3\u02BF\u02BE\u02BA\u02BF\u02C1(true));
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public static void \u02B7\u02B8\u02B4\u02BC\u02B6\u02C0\u02BB\u02BE\u02BD\u02C1\u02B7(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, string \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF)
	{
		foreach (PlayerProfileMenu playerProfileMenu in global::UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>())
		{
			if (playerProfileMenu.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
			{
				playerProfileMenu.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF;
			}
		}
	}

	private void \u02B5\u02C1\u02BD\u02BE\u02B7\u02BF\u02C0\u02B2\u02BC\u02B5\u02BE()
	{
		if (MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 == null)
		{
			return;
		}
		for (int i = 0; i < this.optionChecks.Length; i++)
		{
			this.optionChecks[i].enabled = false;
		}
		base.enabled = false;
		this.midiSetupMenu.\u02BC\u02B4\u02C0\u02BF\u02BF\u02B2\u02C1\u02BD\u02B6\u02BE\u02B3(this.controllingPlayer);
		this.midiSetupMenu.enabled = true;
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = false;
	}

	private void \u02B8\u02B3\u02B4\u02B9\u02BC\u02C1\u02B6\u02B7\u02B4\u02B9\u02B8(bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
	{
		this.\u02C0\u02B5\u02B2\u02BD\u02BA\u02B5\u02C1\u02B7\u02B5\u02C0\u02BF.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B6\u02BB\u02BD\u02C0\u02B2\u02BD\u02BB\u02BF\u02B7\u02BF\u02B8.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 > 0);
		this.\u02B4\u02B9\u02C0\u02B4\u02BD\u02BD\u02B2\u02BB\u02B3\u02B6\u02B7.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 < this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5);
		if (\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
		{
			int num = GlobalVariables.instance.\u02BA\u02C0\u02C1\u02B9\u02B4\u02BB\u02B9\u02B2\u02C0\u02B4\u02B5(this.controllingPlayer.playerProfile.highwayName);
			this.\u02BB\u02B5\u02BA\u02BE\u02BD\u02B8\u02B9\u02B9\u02C1\u02B8\u02BB(num);
		}
	}

	private void \u02B8\u02B8\u02B7\u02BE\u02B2\u02BE\u02B9\u02B8\u02BD\u02B9\u02B6(Player \u02BA\u02BB\u02BF\u02C1\u02BA\u02B7\u02B2\u02B5\u02B5\u02BF\u02C1)
	{
		GlobalVariables.instance.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD++;
		this.controllingPlayer = GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		this.controllingPlayer.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = this;
		this.controllingPlayer.player = \u02BA\u02BB\u02BF\u02C1\u02BA\u02B7\u02B2\u02B5\u02B5\u02BF\u02C1;
		this.controllingPlayer.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 = this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7;
		\u02BA\u02BB\u02BF\u02C1\u02BA\u02B7\u02B2\u02B5\u02B5\u02BF\u02C1.isPlaying = true;
		this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = true;
		if (this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE != null)
		{
			base.StopCoroutine(this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE);
		}
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = true;
		this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE = base.StartCoroutine(this.\u02B3\u02B9\u02B4\u02C1\u02B7\u02B3\u02BF\u02BE\u02BA\u02BF\u02C1(true));
		this.\u02C0\u02BC\u02B6\u02BA\u02B3\u02B3\u02C1\u02BE\u02BB\u02B2\u02B3();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
	}

	private void \u02BB\u02B5\u02BA\u02BE\u02BD\u02B8\u02B9\u02B9\u02C1\u02B8\u02BB(RawImage \u02BA\u02C0\u02B7\u02B3\u02B2\u02BA\u02B7\u02BD\u02B4\u02B9\u02B6, int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
	{
		if (\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 < -1 || \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 > GlobalVariables.instance.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Count - 1)
		{
			\u02BA\u02C0\u02B7\u02B3\u02B2\u02BA\u02B7\u02BD\u02B4\u02B9\u02B6.transform.parent.gameObject.SetActive(false);
			return;
		}
		\u02BA\u02C0\u02B7\u02B3\u02B2\u02BA\u02B7\u02BD\u02B4\u02B9\u02B6.transform.parent.gameObject.SetActive(true);
		if (\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 == -1)
		{
			\u02BA\u02C0\u02B7\u02B3\u02B2\u02BA\u02B7\u02BD\u02B4\u02B9\u02B6.texture = this.\u02B3\u02B9\u02B9\u02BD\u02B6\u02B2\u02C1\u02BE\u02B3\u02BF\u02B7;
			return;
		}
		\u02BA\u02C0\u02B7\u02B3\u02B2\u02BA\u02B7\u02BD\u02B4\u02B9\u02B6.texture = GlobalVariables.instance.\u02BC\u02B3\u02C1\u02C0\u02B6\u02B2\u02BE\u02B7\u02C1\u02BF\u02B5(\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, true);
	}

	private void \u02BB\u02C0\u02BC\u02B3\u02B2\u02B5\u02B5\u02B6\u02B6\u02B7\u02BD()
	{
		this.controllingPlayer = GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		this.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(false);
	}

	public override void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		if (this.controllingPlayer == null)
		{
			return;
		}
		if (!this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
		{
			return;
		}
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = true;
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = false;
		}
	}

	private void \u02B8\u02B3\u02C1\u02B6\u02BB\u02C0\u02B8\u02BA\u02BF\u02BD\u02BF()
	{
		ReInput.controllers.Keyboard.enabled = true;
		this.\u02BE\u02B5\u02B7\u02C1\u02B2\u02B3\u02B3\u02BD\u02C0\u02B3\u02B6 = true;
		this.\u02BF\u02B4\u02BE\u02B3\u02C1\u02BE\u02BE\u02B2\u02B8\u02B2\u02BC.enabled = true;
		if (this.\u02C1\u02B7\u02BA\u02B7\u02BB\u02BE\u02B8\u02B5\u02BB\u02B8\u02B8)
		{
			this.\u02C1\u02B7\u02BA\u02B7\u02BB\u02BE\u02B8\u02B5\u02BB\u02B8\u02B8 = true;
			this.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(true);
			this.\u02B9\u02C1\u02C1\u02C1\u02B2\u02BE\u02B3\u02BD\u02C0\u02BD\u02B4();
			return;
		}
		this.\u02C0\u02BC\u02B6\u02BA\u02B3\u02B3\u02C1\u02BE\u02BB\u02B2\u02B3();
		base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0("year");
	}

	public int \u02B4\u02BE\u02B9\u02B7\u02C0\u02BB\u02B2\u02C1\u02B4\u02BC\u02BB()
	{
		\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 playerProfile = this.controllingPlayer.playerProfile;
		int num = ((playerProfile.colorProfileName == "Deadly Dynamics") ? 1 : (GlobalVariables.instance.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02BB\u02B8\u02B6\u02BA\u02B4\u02BC\u02BB\u02B3\u02C0\u02B5\u02BF(playerProfile.colorProfileName) + 3));
		if (num == -1)
		{
			num = GlobalVariables.instance.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02BB\u02B8\u02B6\u02BA\u02B4\u02BC\u02BB\u02B3\u02C0\u02B5\u02BF(GlobalVariables.instance.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0) + 0;
		}
		return num;
	}

	public void \u02BC\u02C1\u02BC\u02B6\u02BB\u02BA\u02B5\u02BB\u02B2\u02C1\u02BE(short \u02B7\u02BB\u02BF\u02BE\u02C1\u02B9\u02B2\u02B2\u02BF\u02B7\u02B4)
	{
		Debug.Log(string.Format("Updated latency {0} for {1}", \u02B7\u02BB\u02BF\u02BE\u02C1\u02B9\u02B2\u02B2\u02BF\u02B7\u02B4, this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text));
		this.latencyValue.text = string.Format("{0}", \u02B7\u02BB\u02BF\u02BE\u02C1\u02B9\u02B2\u02B2\u02BF\u02B7\u02B4);
	}

	protected override void \u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8()
	{
		base.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		for (int i = 0; i < this.optionChecks.Length; i++)
		{
			this.optionChecks[i].enabled = false;
		}
		if (this.\u02BD\u02B4\u02B6\u02BA\u02B9\u02BB\u02C0\u02C0\u02BE\u02B7\u02BE)
		{
			if (!this.\u02B7\u02BB\u02B5\u02B4\u02B6\u02BD\u02BA\u02BA\u02B6\u02BD\u02BC)
			{
				int num = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
				int j = 0;
				while (j < this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
				{
					if (num >= this.menuStrings.Length - 1)
					{
						this.textObjects[j].text = "<" + LanguageManager.instance.GetString(this.textObjects[j].text) + ">";
					}
					else
					{
						if (num >= this.menuStrings.Length - 2)
						{
							this.textObjects[j].text = LanguageManager.instance.GetString(this.textObjects[j].text);
						}
						if (j != this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3)
						{
							this.textObjects[j].color = Color.white;
							if (num == this.menuStrings.Length - 2)
							{
								this.textObjects[j].color = this.guestColor;
							}
						}
					}
					j++;
					num++;
				}
				return;
			}
			if (this.menuStrings.Length > 2)
			{
				for (int k = 0; k < this.textObjects.Length; k++)
				{
					\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 playerProfile = this.controllingPlayer.playerProfile;
					GameSetting gameSetting = null;
					string text = this.menuStrings[k + this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7];
					uint num2 = PrivateImplementationDetails.ComputeStringHash(text);
					if (num2 <= 2464313451U)
					{
						if (num2 <= 1764869839U)
						{
							if (num2 != 892887250U)
							{
								if (num2 == 1764869839U)
								{
									if (text == "Square Tom Notes")
									{
										gameSetting = playerProfile.squareTomNotes;
									}
								}
							}
							else if (text == "Lefty Flip")
							{
								gameSetting = playerProfile.leftyFlip;
							}
						}
						else if (num2 != 1891779025U)
						{
							if (num2 == 2464313451U)
							{
								if (text == "Gamepad Mode")
								{
									gameSetting = playerProfile.gamepadMode;
								}
							}
						}
						else if (text == "Show Accuracy")
						{
							gameSetting = playerProfile.isAccuracyDisplay;
						}
					}
					else if (num2 <= 3460482988U)
					{
						if (num2 != 2970654147U)
						{
							if (num2 == 3460482988U)
							{
								if (text == "Display Name")
								{
									gameSetting = playerProfile.displayName;
								}
							}
						}
						else if (text == "Alternate Tap Texture")
						{
							gameSetting = playerProfile.altTaps;
						}
					}
					else if (num2 != 3628891427U)
					{
						if (num2 != 3653993758U)
						{
							if (num2 == 3806402342U)
							{
								if (text == "Tilt")
								{
									gameSetting = playerProfile.tilt;
								}
							}
						}
						else if (text == "Bot")
						{
							gameSetting = playerProfile.isBot;
						}
					}
					else if (text == "Hide Accents/Ghosts")
					{
						gameSetting = playerProfile.drumDynamicsHidden;
					}
					this.optionChecks[k].enabled = gameSetting != null && gameSetting.GetBoolValue;
					this.optionChecks[k].color = ((k == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3) ? Color.black : Color.white);
				}
			}
		}
	}

	public void \u02BB\u02B7\u02BB\u02BA\u02BC\u02B8\u02B5\u02B9\u02C0\u02B5\u02BA(bool \u02B7\u02B8\u02B8\u02B6\u02C1\u02B3\u02BC\u02BC\u02BD\u02B4\u02C0)
	{
		if (this.controllingPlayer == null)
		{
			return;
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B9\u02B2\u02C1\u02BC\u02B2\u02B8\u02BC\u02BF\u02B9\u02BE();
			return;
		}
		if (this.onlineMenu.isActiveAndEnabled)
		{
			return;
		}
		if (this.controllingPlayer.playerProfile != null)
		{
			if (\u02B7\u02B8\u02B8\u02B6\u02C1\u02B3\u02BC\u02BC\u02BD\u02B4\u02C0)
			{
				this.controllingPlayer.playerProfile = null;
			}
			else
			{
				if (this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1)
				{
					this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = false;
					Settings.Commit(true);
				}
				GlobalVariables.instance.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02BA\u02B4\u02BE\u02BE\u02B6\u02B4\u02B5\u02B9\u02B4\u02BE\u02B7(this.controllingPlayer.playerProfile);
				this.controllingPlayer.playerProfile = null;
				this.\u02B3\u02B2\u02B7\u02BB\u02B4\u02B8\u02B4\u02BD\u02BE\u02BB\u02BB();
			}
		}
		GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02C0\u02B9\u02B5\u02BF\u02B5\u02B6\u02B3\u02B7\u02B9\u02C1\u02BC();
		GlobalVariables.instance.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD -= 0;
		this.controllingPlayer.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = null;
		this.controllingPlayer.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
		this.controllingPlayer = null;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.menuStrings = new string[0];
		base.\u02BA\u02B9\u02C1\u02C1\u02BF\u02C1\u02BC\u02BA\u02B3\u02BB\u02C0();
		if (this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE != null)
		{
			base.StopCoroutine(this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE);
		}
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = false;
		this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE = base.StartCoroutine(this.\u02B3\u02B9\u02B4\u02C1\u02B7\u02B3\u02BF\u02BE\u02BA\u02BF\u02C1(false));
		base.StartCoroutine(this.\u02BC\u02B2\u02B2\u02B3\u02B6\u02C1\u02BD\u02BC\u02B8\u02C1\u02B6());
	}

	public TextMeshProUGUI \u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB;

	public int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7;

	private ControlMapper \u02BF\u02B4\u02BE\u02B3\u02C1\u02BE\u02BE\u02B2\u02B8\u02B2\u02BC;

	private GameSetting \u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC;

	[SerializeField]
	private SongSelectSearch songSelectSearch;

	[SerializeField]
	private string[] settingsOptions;

	[SerializeField]
	private string[] profileOptions;

	[SerializeField]
	private string[] guitarOptions;

	[SerializeField]
	private string[] drumsOptions;

	[SerializeField]
	private GameObject instIcons;

	[SerializeField]
	private RectTransform parentTransform;

	private Coroutine \u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE;

	public Image \u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF;

	public Color \u02BF\u02B7\u02BB\u02BB\u02BF\u02B9\u02B9\u02BF\u02C1\u02B2\u02BC;

	public Color \u02B3\u02B9\u02B4\u02C1\u02BB\u02B6\u02C1\u02BE\u02C0\u02C1\u02B2;

	public RawImage \u02C0\u02B5\u02B2\u02BD\u02BA\u02B5\u02C1\u02B7\u02B5\u02C0\u02BF;

	public RawImage \u02B6\u02BB\u02BD\u02C0\u02B2\u02BD\u02BB\u02BF\u02B7\u02BF\u02B8;

	public RawImage \u02B4\u02B9\u02C0\u02B4\u02BD\u02BD\u02B2\u02BB\u02B3\u02B6\u02B7;

	public Texture2D \u02BE\u02BA\u02BD\u02BF\u02BB\u02C0\u02BB\u02B8\u02BA\u02BE\u02C1;

	public Texture2D \u02B3\u02B9\u02B9\u02BD\u02B6\u02B2\u02C1\u02BE\u02B3\u02BF\u02B7;

	[SerializeField]
	private Image instrumentImage;

	[SerializeField]
	private Image hostImage;

	[SerializeField]
	private Sprite[] instrumentIcons;

	[SerializeField]
	private Image[] optionChecks;

	[SerializeField]
	private OnlineMenu onlineMenu;

	[SerializeField]
	private MIDISetupMenu midiSetupMenu;

	public GameObject \u02C0\u02B2\u02B2\u02B5\u02B7\u02B8\u02BA\u02BD\u02BB\u02BD\u02B2;

	[SerializeField]
	private TextMeshProUGUI latencyValue;

	private PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5 \u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.None;

	private int \u02BF\u02B8\u02BC\u02B4\u02BA\u02C1\u02C0\u02B9\u02BA\u02B4\u02B7;

	private bool \u02BE\u02B5\u02B7\u02C1\u02B2\u02B3\u02B3\u02BD\u02C0\u02B3\u02B6;

	private bool \u02C1\u02B7\u02BA\u02B7\u02BB\u02BE\u02B8\u02B5\u02BB\u02B8\u02B8;

	private bool \u02B5\u02B7\u02B5\u02B6\u02B3\u02B4\u02B7\u02BB\u02BE\u02B6\u02B5;

	private bool \u02BA\u02B9\u02BB\u02BB\u02C0\u02C0\u02B6\u02C1\u02B6\u02BD\u02BD;

	[SerializeField]
	private Color guestColor;

	private int \u02BE\u02BD\u02B8\u02BE\u02C1\u02BA\u02B4\u02B8\u02BD\u02BF\u02B8 = -10000;

	private bool \u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1;

	private bool \u02BA\u02BD\u02BF\u02B4\u02BB\u02B8\u02B4\u02BB\u02C1\u02B8\u02BA;

	private enum \u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5
	{
		None = -1,
		String,
		Int,
		Percent,
		Bool
	}
}
