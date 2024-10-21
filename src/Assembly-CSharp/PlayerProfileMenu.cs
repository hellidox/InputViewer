using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Rewired;
using Rewired.UI.ControlMapper;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000FF RID: 255
public class PlayerProfileMenu : BaseMenu
{
	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0000B4D6 File Offset: 0x000096D6
	public bool \u02B6\u02BA\u02B9\u02C0\u02B5\u02B5\u02BF\u02BF\u02B8\u02BA\u02B6
	{
		get
		{
			return this.\u02BE\u02B5\u02B7\u02C1\u02B2\u02B3\u02B3\u02BD\u02C0\u02B3\u02B6;
		}
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x0005C950 File Offset: 0x0005AB50
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
			this.\u02C0\u02B5\u02B2\u02BD\u02BA\u02B5\u02C1\u02B7\u02B5\u02C0\u02BF.texture = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B3\u02C1\u02C0\u02B6\u02B2\u02BE\u02B7\u02C1\u02BF\u02B5(\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, true);
			this.\u02BE\u02BD\u02B8\u02BE\u02C1\u02BA\u02B4\u02B8\u02BD\u02BF\u02B8 = \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5;
		}
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x0005C9C0 File Offset: 0x0005ABC0
	private void \u02C0\u02BC\u02B6\u02BA\u02B3\u02B3\u02C1\u02BE\u02BB\u02B2\u02B3()
	{
		this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Choose a Profile");
		this.\u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF.CrossFadeColor(this.\u02BF\u02B7\u02BB\u02BB\u02BF\u02B9\u02B9\u02BF\u02C1\u02B2\u02BC, 1f, true, false);
		this.menuStrings = new string[GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B9\u02BA\u02B2\u02B9\u02B8\u02B2\u02B4\u02B5\u02C0\u02BF\u02B9 + 2];
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		int num = 0;
		foreach (\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02C1\u02B3\u02B4\u02B2\u02B6\u02BA\u02C0\u02B8\u02B8\u02B6\u02B8())
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

	// Token: 0x06000A8E RID: 2702 RVA: 0x0005CAF0 File Offset: 0x0005ACF0
	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 == null)
		{
			return;
		}
		if (!this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
		{
			return;
		}
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo != null && this.\u02BA\u02BD\u02BF\u02B4\u02BB\u02B8\u02B4\u02BB\u02C1\u02B8\u02BA)
		{
			return;
		}
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo == null)
		{
			this.\u02BF\u02BD\u02BA\u02B9\u02BB\u02BB\u02BD\u02BF\u02BC\u02BF\u02B4(false);
			return;
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			this.\u02B8\u02B3\u02B4\u02B9\u02BC\u02C1\u02B6\u02B7\u02B4\u02B9\u02B8(false);
			this.menuStrings = (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.IsAnyGuitarController ? this.guitarOptions : this.drumsOptions);
			this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
			base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3);
			this.instIcons.SetActive(false);
			if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.\u02BA\u02C0\u02BC\u02BB\u02B7\u02B3\u02B8\u02BA\u02B2\u02B9\u02BA == this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC && MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
			{
				MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B2\u02BE\u02BF\u02BB\u02C0\u02BE\u02BD\u02B9\u02BC\u02BB(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4, this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue);
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

	// Token: 0x06000A8F RID: 2703 RVA: 0x0005CC30 File Offset: 0x0005AE30
	protected override void Update()
	{
		base.Update();
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 == null || this.\u02BF\u02B4\u02BE\u02B3\u02C1\u02BE\u02BE\u02B2\u02B8\u02B2\u02BC.isOpen || FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02BF\u02B7\u02BA\u02BC\u02B2\u02BA\u02B8\u02BF\u02BB\u02B3 || this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.rewiredPlayer == null || (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && !this.\u02BE\u02B5\u02B7\u02C1\u02B2\u02B3\u02B3\u02BD\u02C0\u02B3\u02B6 && this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BD\u02B8\u02BD\u02B6\u02B4\u02B6\u02C1\u02B9\u02BD\u02BC\u02B4))
		{
			return;
		}
		if (!this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
		{
			if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.rewiredPlayer.GetButtonDown(16))
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

	// Token: 0x06000A90 RID: 2704 RVA: 0x0005CCCC File Offset: 0x0005AECC
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

	// Token: 0x06000A91 RID: 2705 RVA: 0x0005CD28 File Offset: 0x0005AF28
	private void \u02B3\u02B2\u02B7\u02BB\u02B4\u02B8\u02B4\u02BD\u02BE\u02BB\u02BB()
	{
		foreach (PlayerProfileMenu playerProfileMenu in global::UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>())
		{
			if (!(playerProfileMenu == this) && playerProfileMenu.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 != null && playerProfileMenu.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo == null && !playerProfileMenu.\u02BE\u02B5\u02B7\u02C1\u02B2\u02B3\u02B3\u02BD\u02C0\u02B3\u02B6)
			{
				playerProfileMenu.\u02C0\u02BC\u02B6\u02BA\u02B3\u02B3\u02C1\u02BE\u02BB\u02B2\u02B3();
			}
		}
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x0005CD7C File Offset: 0x0005AF7C
	private void \u02B5\u02BE\u02BC\u02B2\u02BF\u02B9\u02BA\u02B4\u02B4\u02B9\u02B3()
	{
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = true;
		if (this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1)
		{
			this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = true;
			Settings.Commit(true);
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
			{
				\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BB\u02B6\u02B7\u02BF\u02B5\u02B2\u02B6\u02C0\u02BA\u02BB(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo);
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

	// Token: 0x06000A93 RID: 2707 RVA: 0x0005CE24 File Offset: 0x0005B024
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

	// Token: 0x06000A94 RID: 2708 RVA: 0x0005CE84 File Offset: 0x0005B084
	private void \u02BE\u02C0\u02BC\u02BF\u02C1\u02BE\u02B8\u02B5\u02B7\u02B3\u02BF(Player \u02BA\u02BB\u02BF\u02C1\u02BA\u02B7\u02B2\u02B5\u02B5\u02BF\u02C1)
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD++;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = this;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.rewiredPlayer = \u02BA\u02BB\u02BF\u02C1\u02BA\u02B7\u02B2\u02B5\u02B5\u02BF\u02C1;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 = this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7;
		\u02BA\u02BB\u02BF\u02C1\u02BA\u02B7\u02B2\u02B5\u02B5\u02BF\u02C1.isPlaying = false;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = true;
		if (this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE != null)
		{
			base.StopCoroutine(this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE);
		}
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = true;
		this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE = base.StartCoroutine(this.\u02BD\u02B2\u02C1\u02B2\u02BC\u02BC\u02B6\u02BE\u02BF\u02BC\u02B6(true));
		this.\u02C0\u02BC\u02B6\u02BA\u02B3\u02B3\u02C1\u02BE\u02BB\u02B2\u02B3();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(1, true);
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x0005CF38 File Offset: 0x0005B138
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
							text = ((num == 0) ? \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("6 Fret Lead Guitar") : ((num == 1) ? \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("name") : GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD[num - 8]));
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
					text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("");
				}
				else
				{
					flag = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[num - 1].isResource;
					text = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[num - 1].name;
				}
			}
			if (this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD == (PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5)8)
			{
				text += "song";
			}
			this.textObjects[i].text = "_uFillHeight" + (flag ? \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(text) : text) + "highway_shake";
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

	// Token: 0x06000A96 RID: 2710 RVA: 0x0005D20C File Offset: 0x0005B40C
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

	// Token: 0x06000A97 RID: 2711 RVA: 0x0000B4DE File Offset: 0x000096DE
	private IEnumerator \u02B6\u02B3\u02C1\u02B7\u02B3\u02B5\u02B7\u02BA\u02B8\u02C0\u02BD()
	{
		yield return null;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
		yield break;
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x0005D270 File Offset: 0x0005B470
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
					string text = ((num == -1) ? "Random" : GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[num].name);
					this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.highwayName.CurrentValue = text;
					return;
				}
				if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Controller"))
				{
					return;
				}
				if (this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 != this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.controllerType.CurrentValue)
				{
					this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.controllerType.CurrentValue = this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3;
					this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.noteModifier = Modifier.None;
					this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.instrument = \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02B2\u02B8\u02B3\u02BC\u02B7\u02B8\u02C1\u02B6\u02BE\u02B2\u02B7(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.controllerType.GetControllerType);
					if (MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
					{
						MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02C0\u02B5\u02BE\u02BB\u02B3\u02B2\u02B8\u02B6\u02B8\u02BF(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4);
					}
				}
			}
			else
			{
				string text2 = ((num == -1) ? "Random" : ((num == 0) ? "Editor" : GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD[num - 1]));
				if (text2 == "Editor")
				{
					ColorProfileEditor.\u02BE\u02B3\u02B7\u02BD\u02BA\u02BB\u02B4\u02B7\u02B5\u02B3\u02B2(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo);
					return;
				}
				this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.colorProfileName.CurrentValue = text2;
				if (num != -1)
				{
					this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.colorSettings = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02C0\u02BB\u02B2\u02B6\u02B4\u02B3\u02BF\u02B2\u02B5\u02B8\u02BA(text2);
					return;
				}
				if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
				{
					this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.\u02B4\u02BF\u02B9\u02BF\u02B3\u02B9\u02B9\u02B6\u02B5\u02BF\u02BB();
					this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = true;
					return;
				}
			}
		}
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x0000B4ED File Offset: 0x000096ED
	public virtual void \u02BC\u02C0\u02B9\u02BF\u02C1\u02C0\u02B5\u02B7\u02BD\u02BD\u02B6()
	{
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 == null)
		{
			return;
		}
		if (!this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
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

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0000B528 File Offset: 0x00009728
	public bool \u02B7\u02BB\u02B5\u02B4\u02B6\u02BD\u02BA\u02BA\u02B6\u02BD\u02BC
	{
		get
		{
			return this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo != null;
		}
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x0005D484 File Offset: 0x0005B684
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
				this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.playerName.CurrentValue = this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text;
			}
			else
			{
				\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B4\u02C0\u02B6\u02B9\u02BE\u02BE\u02C1\u02B2\u02B6\u02B4\u02B6(false, false);
				u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.playerName.CurrentValue = this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text.Trim();
				Settings.Commit(false);
				this.\u02BA\u02B5\u02BC\u02C0\u02BE\u02BB\u02B3\u02C0\u02BD\u02BB\u02B8(u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B);
			}
			this.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(false);
		}
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x0005D550 File Offset: 0x0005B750
	protected override void Start()
	{
		this.\u02BF\u02B4\u02BE\u02B3\u02C1\u02BE\u02BE\u02B2\u02B8\u02B2\u02BC = GameObject.Find("ControlMapper").GetComponent<ControlMapper>();
		if (this.parentTransform == null)
		{
			this.parentTransform = base.GetComponent<RectTransform>();
		}
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer == null)
			{
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
				{
					this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].playerInfo.playerName.CurrentValueDisplay;
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
				this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = this;
			}
		}
		else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer == null)
		{
			base.StartCoroutine(this.\u02BC\u02B2\u02B2\u02B3\u02B6\u02C1\u02BD\u02BC\u02B8\u02C1\u02B6());
		}
		else
		{
			this.\u02BB\u02C0\u02BC\u02B3\u02B2\u02B5\u02B5\u02B6\u02B6\u02B7\u02BD();
			this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = this;
		}
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = true;
		this.instIcons.SetActive(false);
		base.Start();
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x0000B538 File Offset: 0x00009738
	public virtual void \u02BF\u02BE\u02BB\u02C0\u02B4\u02B6\u02BA\u02B4\u02BC\u02BC\u02BB()
	{
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 == null)
		{
			return;
		}
		if (!this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
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

	// Token: 0x06000A9E RID: 2718 RVA: 0x0005D668 File Offset: 0x0005B868
	public int \u02BB\u02B4\u02C0\u02B3\u02B2\u02BB\u02C1\u02BE\u02B5\u02BD\u02C0()
	{
		\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 playerInfo = this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo;
		int num = ((playerInfo.colorProfileName == "Random") ? 0 : (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02BB\u02B8\u02B6\u02BA\u02B4\u02BC\u02BB\u02B3\u02C0\u02B5\u02BF(playerInfo.colorProfileName) + 2));
		if (num == -1)
		{
			num = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02BB\u02B8\u02B6\u02BA\u02B4\u02BC\u02BB\u02B3\u02C0\u02B5\u02BF(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0) + 1;
		}
		return num;
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x0000B4DE File Offset: 0x000096DE
	private IEnumerator \u02B2\u02C0\u02BA\u02BC\u02B4\u02BB\u02B7\u02C1\u02B3\u02B7\u02C0()
	{
		yield return null;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
		yield break;
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x0005D6E0 File Offset: 0x0005B8E0
	private void \u02B2\u02BC\u02B3\u02B2\u02C0\u02B9\u02BB\u02B2\u02C0\u02C0\u02B3()
	{
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = false;
		if (this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1)
		{
			this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = false;
			Settings.Commit(false);
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
			{
				\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BB\u02B6\u02B7\u02BF\u02B5\u02B2\u02B6\u02C0\u02BA\u02BB(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo);
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

	// Token: 0x06000AA1 RID: 2721 RVA: 0x0005D788 File Offset: 0x0005B988
	private void FixedUpdate()
	{
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		this.instrumentImage.enabled = false;
		this.hostImage.enabled = false;
		this.\u02C0\u02B2\u02B2\u02B5\u02B7\u02B8\u02BA\u02BD\u02BB\u02BD\u02B2.SetActive(false);
		if (!u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo == null)
		{
			return;
		}
		this.instrumentImage.enabled = true;
		this.instrumentImage.sprite = this.instrumentIcons[(int)u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType];
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

	// Token: 0x06000AA2 RID: 2722 RVA: 0x0005D8B0 File Offset: 0x0005BAB0
	public void \u02B8\u02BA\u02B7\u02BB\u02BC\u02B9\u02C1\u02B3\u02BB\u02B5\u02B6(bool \u02B7\u02B8\u02B8\u02B6\u02C1\u02B3\u02BC\u02BC\u02BD\u02B4\u02C0)
	{
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 == null)
		{
			return;
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B7\u02B6\u02B9\u02B5\u02BC\u02B2\u02BB\u02B2\u02BD())
		{
			this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = true;
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B9\u02B2\u02C1\u02BC\u02B2\u02B8\u02BC\u02BF\u02B9\u02BE();
			return;
		}
		if (this.onlineMenu.isActiveAndEnabled)
		{
			return;
		}
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo != null)
		{
			if (\u02B7\u02B8\u02B8\u02B6\u02C1\u02B3\u02BC\u02BC\u02BD\u02B4\u02C0)
			{
				this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo = null;
			}
			else
			{
				if (this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1)
				{
					this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = false;
					Settings.Commit(true);
				}
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02BA\u02B4\u02BE\u02BE\u02B6\u02B4\u02B5\u02B9\u02B4\u02BE\u02B7(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo);
				this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo = null;
				this.\u02B3\u02B2\u02B7\u02BB\u02B4\u02B8\u02B4\u02BD\u02BE\u02BB\u02BB();
			}
		}
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02C0\u02B9\u02B5\u02BF\u02B5\u02B6\u02B3\u02B7\u02B9\u02C1\u02BC();
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD--;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = null;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 = null;
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

	// Token: 0x06000AA3 RID: 2723 RVA: 0x0000B573 File Offset: 0x00009773
	private void \u02B9\u02C1\u02C1\u02C1\u02B2\u02BE\u02B3\u02BD\u02C0\u02BD\u02B4()
	{
		this.menuStrings = this.profileOptions;
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x0005D9F8 File Offset: 0x0005BBF8
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
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("PRESS START");
			this.\u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF.CrossFadeColor(this.\u02B3\u02B9\u02B4\u02C1\u02BB\u02B6\u02C1\u02BE\u02C0\u02C1\u02B2, 1f, true, false);
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.color = Color.white;
			return;
		}
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.isBot)
		{
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.playerName.CurrentValueNoTags;
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.color = Color.cyan;
		}
		else
		{
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.isGuestProfile ? this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.playerName.CurrentValue : this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.playerName.CurrentValueDisplay);
			this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.color = (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.isGuestProfile ? this.guestColor : this.defaultColor);
		}
		this.\u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF.CrossFadeColor(this.\u02BF\u02B7\u02BB\u02BB\u02BF\u02B9\u02B9\u02BF\u02C1\u02B2\u02BC, 1f, true, false);
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x0005DB58 File Offset: 0x0005BD58
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

	// Token: 0x06000AA6 RID: 2726 RVA: 0x0000B596 File Offset: 0x00009796
	private IEnumerator \u02BC\u02B2\u02B2\u02B3\u02B6\u02C1\u02BD\u02BC\u02B8\u02C1\u02B6()
	{
		this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("PRESS START");
		this.\u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF.CrossFadeColor(this.\u02B3\u02B9\u02B4\u02C1\u02BB\u02B6\u02C1\u02BE\u02C0\u02C1\u02B2, 1f, true, false);
		this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.color = Color.white;
		while (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 == null)
		{
			if (!this.\u02BF\u02B4\u02BE\u02B3\u02C1\u02BE\u02BE\u02B2\u02B8\u02B2\u02BC.isOpen && !this.songSelectSearch.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 && !CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && !this.onlineMenu.isActiveAndEnabled)
			{
				int num = 0;
				for (int i = 0; i < GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.Count; i++)
				{
					if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].rewiredPlayer == null)
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

	// Token: 0x06000AA7 RID: 2727 RVA: 0x0000B5A5 File Offset: 0x000097A5
	public void \u02BE\u02B6\u02BE\u02B2\u02B2\u02BF\u02B3\u02B7\u02BC\u02BC\u02BE(short \u02B7\u02BB\u02BF\u02BE\u02C1\u02B9\u02B2\u02B2\u02BF\u02B7\u02B4)
	{
		Debug.Log(string.Format("' plural '", \u02B7\u02BB\u02BF\u02BE\u02C1\u02B9\u02B2\u02B2\u02BF\u02B7\u02B4, this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text));
		this.latencyValue.text = string.Format("profiles", \u02B7\u02BB\u02BF\u02BE\u02C1\u02B9\u02B2\u02B2\u02BF\u02B7\u02B4);
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x0005DCBC File Offset: 0x0005BEBC
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
			this.\u02C0\u02B5\u02B2\u02BD\u02BA\u02B5\u02C1\u02B7\u02B5\u02C0\u02BF.texture = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B3\u02C1\u02C0\u02B6\u02B2\u02BE\u02B7\u02C1\u02BF\u02B5(\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, false);
			this.\u02BE\u02BD\u02B8\u02BE\u02C1\u02BA\u02B4\u02B8\u02BD\u02BF\u02B8 = \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5;
		}
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x0005DD2C File Offset: 0x0005BF2C
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
				this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B4\u02C0\u02B6\u02B9\u02BE\u02BE\u02C1\u02B2\u02B6\u02B4\u02B6(true, false);
				this.\u02B2\u02B8\u02B6\u02BA\u02B9\u02B2\u02B6\u02BA\u02B3\u02B2\u02BA();
			}
			else
			{
				this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02C0\u02BA\u02BA\u02B3\u02BE\u02BE\u02B8\u02BE\u02C1\u02B5\u02BF(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
				this.\u02B2\u02B8\u02B6\u02BA\u02B9\u02B2\u02B6\u02BA\u02B3\u02B2\u02BA();
			}
		}
		else
		{
			this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo = \u02B3\u02B8\u02B9\u02B7\u02B8\u02BD\u02B4\u02C0\u02C0\u02B3\u02B9;
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
			this.\u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3();
		}
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x0000B5FC File Offset: 0x000097FC
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

	// Token: 0x06000AAC RID: 2732 RVA: 0x0005DE54 File Offset: 0x0005C054
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

	// Token: 0x06000AAD RID: 2733 RVA: 0x0005DE8C File Offset: 0x0005C08C
	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 == null)
		{
			return;
		}
		if (!this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
		{
			return;
		}
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo == null)
		{
			this.\u02BA\u02B5\u02BC\u02C0\u02BE\u02BB\u02B3\u02C0\u02BD\u02BB\u02B8(null);
			base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
			return;
		}
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 playerInfo = this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo;
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
									this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerInfo.leftyFlip;
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
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerInfo.highwayLength;
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
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerInfo.squareTomNotes;
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
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerInfo.noteSpeed;
								this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Int;
							}
						}
					}
					else if (text == "Gamepad Mode")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerInfo.gamepadMode;
						this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Bool;
					}
				}
				else if (text == "Show Accuracy")
				{
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerInfo.isAccuracyDisplay;
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
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerInfo.colorIndex;
								int num2 = this.\u02BB\u02B4\u02C0\u02B3\u02B2\u02BB\u02C1\u02BE\u02B5\u02BD\u02C0();
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue = num2;
								this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.String;
								this.\u02BF\u02B8\u02BC\u02B4\u02BA\u02C1\u02C0\u02B9\u02BA\u02B4\u02B7 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02BB\u02BF\u02BE\u02B8\u02B2\u02B7\u02BB\u02C0\u02BE\u02B2\u02B2.Count + 2;
								this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = num2;
							}
						}
					}
					else if (text == "Controller")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerInfo.controllerType;
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
								GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B9\u02BA\u02B5\u02BF\u02B9\u02BA\u02BC\u02B2\u02C1\u02B8\u02B4(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo);
								this.\u02BF\u02BD\u02BA\u02B9\u02BB\u02BB\u02BD\u02BF\u02BC\u02BF\u02B4(true);
								this.\u02B5\u02B7\u02B5\u02B6\u02B3\u02B4\u02B7\u02BB\u02BE\u02B6\u02B5 = false;
								return;
							}
						}
					}
					else if (text == "Alternate Tap Texture")
					{
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerInfo.altTaps;
						this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Bool;
					}
				}
				else if (text == "Highway")
				{
					this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.String;
					this.\u02BF\u02B8\u02BC\u02B4\u02BA\u02C1\u02C0\u02B9\u02BA\u02B4\u02B7 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Count + 1;
					this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02C0\u02C1\u02B9\u02B4\u02BB\u02B9\u02B2\u02C0\u02B4\u02B5(playerInfo.highwayName.CurrentValue) + 1;
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
								this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerInfo.drumDynamicsHidden;
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
					this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerInfo.displayName;
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
							this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerInfo.tilt;
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
					this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Are you sure?");
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
				this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = playerInfo.isBot;
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
		this.menuStrings = (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.IsAnyGuitarController ? this.guitarOptions : this.drumsOptions);
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3);
		this.instIcons.SetActive(false);
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.\u02BA\u02C0\u02BC\u02BB\u02B7\u02B3\u02B8\u02BA\u02B2\u02B9\u02BA == this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC && MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
		{
			MIDIInputManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B2\u02BE\u02BF\u02BB\u02C0\u02BE\u02BD\u02B9\u02BC\u02BB(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4, this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.CurrentValue);
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

	// Token: 0x06000AAE RID: 2734 RVA: 0x0000B5FC File Offset: 0x000097FC
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

	// Token: 0x06000AAF RID: 2735 RVA: 0x0000B612 File Offset: 0x00009812
	public void \u02B6\u02B7\u02B5\u02C1\u02B8\u02BB\u02BC\u02B8\u02BF\u02BA\u02B7(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text = \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x0005E72C File Offset: 0x0005C92C
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

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0000B620 File Offset: 0x00009820
	public bool \u02BD\u02B4\u02B6\u02BA\u02B9\u02BB\u02C0\u02C0\u02BE\u02B7\u02BE
	{
		get
		{
			return this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 != null;
		}
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x0005E764 File Offset: 0x0005C964
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

	// Token: 0x06000AB3 RID: 2739 RVA: 0x0005E8C8 File Offset: 0x0005CAC8
	public void \u02BF\u02BD\u02BA\u02B9\u02BB\u02BB\u02BD\u02BF\u02BC\u02BF\u02B4(bool \u02B7\u02B8\u02B8\u02B6\u02C1\u02B3\u02BC\u02BC\u02BD\u02B4\u02C0)
	{
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 == null)
		{
			return;
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B9\u02B2\u02C1\u02BC\u02B2\u02B8\u02BC\u02BF\u02B9\u02BE();
			return;
		}
		if (this.onlineMenu.isActiveAndEnabled)
		{
			return;
		}
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo != null)
		{
			if (\u02B7\u02B8\u02B8\u02B6\u02C1\u02B3\u02BC\u02BC\u02BD\u02B4\u02C0)
			{
				this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo = null;
			}
			else
			{
				if (this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1)
				{
					this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = false;
					Settings.Commit(false);
				}
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02BE\u02BC\u02BA\u02B7\u02BA\u02BB\u02B7\u02BD\u02B7\u02B3\u02B3(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo);
				this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo = null;
				this.\u02B3\u02B2\u02B7\u02BB\u02B4\u02B8\u02B4\u02BD\u02BE\u02BB\u02BB();
			}
		}
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02C0\u02B9\u02B5\u02BF\u02B5\u02B6\u02B3\u02B7\u02B9\u02C1\u02BC();
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD--;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = null;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 = null;
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

	// Token: 0x06000AB4 RID: 2740 RVA: 0x0000B62B File Offset: 0x0000982B
	private void \u02B2\u02B8\u02B6\u02BA\u02B9\u02B2\u02B6\u02BA\u02B3\u02B2\u02BA()
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B7\u02B7\u02B9\u02B6\u02B4\u02BC\u02BF\u02B9\u02BF\u02B5\u02B8(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo);
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.\u02B3\u02B9\u02C1\u02B5\u02BC\u02C1\u02C0\u02BA\u02B9\u02B4\u02B2(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4);
		this.\u02BA\u02BD\u02BF\u02B4\u02BB\u02B8\u02B4\u02BB\u02C1\u02B8\u02BA = false;
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x0000B538 File Offset: 0x00009738
	public override void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 == null)
		{
			return;
		}
		if (!this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
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

	// Token: 0x06000AB6 RID: 2742 RVA: 0x0005EA10 File Offset: 0x0005CC10
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
		this.textObjects[0].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Type the profile name");
		this.textObjects[0].color = Color.white;
		this.textObjects[1].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Press Enter to confirm");
		this.textObjects[1].color = Color.green;
		this.textObjects[2].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Press Escape to cancel");
		this.textObjects[2].color = Color.red;
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x0005EB34 File Offset: 0x0005CD34
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
							text = ((num == 0) ? \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Random") : ((num == 1) ? \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Editor") : GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B8\u02B7\u02B3\u02BA\u02BB\u02BC\u02B3\u02B9\u02BF\u02BF\u02BD[num - 2]));
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
					text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Random");
				}
				else
				{
					flag = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[num - 1].isResource;
					text = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[num - 1].name;
				}
			}
			if (this.\u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD == PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.Percent)
			{
				text += "%";
			}
			this.textObjects[i].text = "<noparse>" + (flag ? \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(text) : text) + "</noparse>";
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

	// Token: 0x06000AB8 RID: 2744 RVA: 0x0005EE08 File Offset: 0x0005D008
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
		this.menuStrings = (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.IsAnyGuitarController ? this.guitarOptions : this.drumsOptions);
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = true;
		if (this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE != null)
		{
			base.StopCoroutine(this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE);
		}
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = true;
		this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE = base.StartCoroutine(this.\u02B3\u02B9\u02B4\u02C1\u02B7\u02B3\u02BF\u02BE\u02BA\u02BF\u02C1(true));
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x0005EEC8 File Offset: 0x0005D0C8
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

	// Token: 0x06000ABA RID: 2746 RVA: 0x0005EF04 File Offset: 0x0005D104
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
		this.midiSetupMenu.\u02BC\u02B4\u02C0\u02BF\u02BF\u02B2\u02C1\u02BD\u02B6\u02BE\u02B3(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4);
		this.midiSetupMenu.enabled = true;
		this.\u02BD\u02BE\u02C0\u02B6\u02B8\u02B5\u02B2\u02B7\u02BD\u02B7\u02BF = false;
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x0005EF6C File Offset: 0x0005D16C
	private void \u02B8\u02B3\u02B4\u02B9\u02BC\u02C1\u02B6\u02B7\u02B4\u02B9\u02B8(bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
	{
		this.\u02C0\u02B5\u02B2\u02BD\u02BA\u02B5\u02C1\u02B7\u02B5\u02C0\u02BF.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		this.\u02B6\u02BB\u02BD\u02C0\u02B2\u02BD\u02BB\u02BF\u02B7\u02BF\u02B8.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 > 0);
		this.\u02B4\u02B9\u02C0\u02B4\u02BD\u02BD\u02B2\u02BB\u02B3\u02B6\u02B7.transform.parent.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 < this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5);
		if (\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
		{
			int num = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02C0\u02C1\u02B9\u02B4\u02BB\u02B9\u02B2\u02C0\u02B4\u02B5(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.highwayName);
			this.\u02BB\u02B5\u02BA\u02BE\u02BD\u02B8\u02B9\u02B9\u02C1\u02B8\u02BB(num);
		}
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x0005F018 File Offset: 0x0005D218
	private void \u02B8\u02B8\u02B7\u02BE\u02B2\u02BE\u02B9\u02B8\u02BD\u02B9\u02B6(Player \u02BA\u02BB\u02BF\u02C1\u02BA\u02B7\u02B2\u02B5\u02B5\u02BF\u02C1)
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD++;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = this;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.rewiredPlayer = \u02BA\u02BB\u02BF\u02C1\u02BA\u02B7\u02B2\u02B5\u02B5\u02BF\u02C1;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 = this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7;
		\u02BA\u02BB\u02BF\u02C1\u02BA\u02B7\u02B2\u02B5\u02B5\u02BF\u02C1.isPlaying = true;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = true;
		if (this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE != null)
		{
			base.StopCoroutine(this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE);
		}
		this.\u02B4\u02B2\u02B8\u02BE\u02B3\u02BE\u02BB\u02BD\u02C0\u02B8\u02B2 = true;
		this.\u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE = base.StartCoroutine(this.\u02B3\u02B9\u02B4\u02C1\u02B7\u02B3\u02BF\u02BE\u02BA\u02BF\u02C1(true));
		this.\u02C0\u02BC\u02B6\u02BA\u02B3\u02B3\u02C1\u02BE\u02BB\u02B2\u02B3();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x0005F0CC File Offset: 0x0005D2CC
	private void \u02BB\u02B5\u02BA\u02BE\u02BD\u02B8\u02B9\u02B9\u02C1\u02B8\u02BB(RawImage \u02BA\u02C0\u02B7\u02B3\u02B2\u02BA\u02B7\u02BD\u02B4\u02B9\u02B6, int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
	{
		if (\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 < -1 || \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5 > GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Count - 1)
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
		\u02BA\u02C0\u02B7\u02B3\u02B2\u02BA\u02B7\u02BD\u02B4\u02B9\u02B6.texture = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B3\u02C1\u02C0\u02B6\u02B2\u02BE\u02B7\u02C1\u02BF\u02B5(\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, true);
	}

	// Token: 0x06000ABE RID: 2750 RVA: 0x0000B664 File Offset: 0x00009864
	private void \u02BB\u02C0\u02BC\u02B3\u02B2\u02B5\u02B5\u02B6\u02B6\u02B7\u02BD()
	{
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		this.\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(false);
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x0000B688 File Offset: 0x00009888
	public override void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 == null)
		{
			return;
		}
		if (!this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD)
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

	// Token: 0x06000AC0 RID: 2752 RVA: 0x0005F144 File Offset: 0x0005D344
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

	// Token: 0x06000AC1 RID: 2753 RVA: 0x0005F1A4 File Offset: 0x0005D3A4
	public int \u02B4\u02BE\u02B9\u02B7\u02C0\u02BB\u02B2\u02C1\u02B4\u02BC\u02BB()
	{
		\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 playerInfo = this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo;
		int num = ((playerInfo.colorProfileName == "Deadly Dynamics") ? 1 : (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02BB\u02B8\u02B6\u02BA\u02B4\u02BC\u02BB\u02B3\u02C0\u02B5\u02BF(playerInfo.colorProfileName) + 3));
		if (num == -1)
		{
			num = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02BB\u02B8\u02B6\u02BA\u02B4\u02BC\u02BB\u02B3\u02C0\u02B5\u02BF(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B3\u02B3\u02B2\u02B5\u02BB\u02B3\u02BF\u02C0\u02C1\u02BF\u02C0) + 0;
		}
		return num;
	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x0000B6C3 File Offset: 0x000098C3
	public void \u02BC\u02C1\u02BC\u02B6\u02BB\u02BA\u02B5\u02BB\u02B2\u02C1\u02BE(short \u02B7\u02BB\u02BF\u02BE\u02C1\u02B9\u02B2\u02B2\u02BF\u02B7\u02B4)
	{
		Debug.Log(string.Format("Updated latency {0} for {1}", \u02B7\u02BB\u02BF\u02BE\u02C1\u02B9\u02B2\u02B2\u02BF\u02B7\u02B4, this.\u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB.text));
		this.latencyValue.text = string.Format("{0}", \u02B7\u02BB\u02BF\u02BE\u02C1\u02B9\u02B2\u02B2\u02BF\u02B7\u02B4);
	}

	// Token: 0x06000AC3 RID: 2755 RVA: 0x0005F21C File Offset: 0x0005D41C
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
						this.textObjects[j].text = "<" + \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.textObjects[j].text) + ">";
					}
					else
					{
						if (num >= this.menuStrings.Length - 2)
						{
							this.textObjects[j].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.textObjects[j].text);
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
					\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 playerInfo = this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo;
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
										gameSetting = playerInfo.squareTomNotes;
									}
								}
							}
							else if (text == "Lefty Flip")
							{
								gameSetting = playerInfo.leftyFlip;
							}
						}
						else if (num2 != 1891779025U)
						{
							if (num2 == 2464313451U)
							{
								if (text == "Gamepad Mode")
								{
									gameSetting = playerInfo.gamepadMode;
								}
							}
						}
						else if (text == "Show Accuracy")
						{
							gameSetting = playerInfo.isAccuracyDisplay;
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
									gameSetting = playerInfo.displayName;
								}
							}
						}
						else if (text == "Alternate Tap Texture")
						{
							gameSetting = playerInfo.altTaps;
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
									gameSetting = playerInfo.tilt;
								}
							}
						}
						else if (text == "Bot")
						{
							gameSetting = playerInfo.isBot;
						}
					}
					else if (text == "Hide Accents/Ghosts")
					{
						gameSetting = playerInfo.drumDynamicsHidden;
					}
					this.optionChecks[k].enabled = gameSetting != null && gameSetting.GetBoolValue;
					this.optionChecks[k].color = ((k == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3) ? Color.black : Color.white);
				}
			}
		}
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x0005F564 File Offset: 0x0005D764
	public void \u02BB\u02B7\u02BB\u02BA\u02BC\u02B8\u02B5\u02B9\u02C0\u02B5\u02BA(bool \u02B7\u02B8\u02B8\u02B6\u02C1\u02B3\u02BC\u02BC\u02BD\u02B4\u02C0)
	{
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 == null)
		{
			return;
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B9\u02B2\u02C1\u02BC\u02B2\u02B8\u02BC\u02BF\u02B9\u02BE();
			return;
		}
		if (this.onlineMenu.isActiveAndEnabled)
		{
			return;
		}
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo != null)
		{
			if (\u02B7\u02B8\u02B8\u02B6\u02C1\u02B3\u02BC\u02BC\u02BD\u02B4\u02C0)
			{
				this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo = null;
			}
			else
			{
				if (this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1)
				{
					this.\u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1 = false;
					Settings.Commit(true);
				}
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02BA\u02B4\u02BE\u02BE\u02B6\u02B4\u02B5\u02B9\u02B4\u02BE\u02B7(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo);
				this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo = null;
				this.\u02B3\u02B2\u02B7\u02BB\u02B4\u02B8\u02B4\u02BD\u02BE\u02BB\u02BB();
			}
		}
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02C0\u02B9\u02B5\u02BF\u02B5\u02B6\u02B3\u02B7\u02B9\u02C1\u02BC();
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD -= 0;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC = null;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD = false;
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 = null;
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

	// Token: 0x040007CA RID: 1994
	public TextMeshProUGUI \u02C1\u02BB\u02B5\u02BE\u02B6\u02B8\u02C1\u02C0\u02B4\u02B9\u02BB;

	// Token: 0x040007CB RID: 1995
	public int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7;

	// Token: 0x040007CC RID: 1996
	private ControlMapper \u02BF\u02B4\u02BE\u02B3\u02C1\u02BE\u02BE\u02B2\u02B8\u02B2\u02BC;

	// Token: 0x040007CD RID: 1997
	private GameSetting \u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC;

	// Token: 0x040007CE RID: 1998
	[SerializeField]
	private SongSelectSearch songSelectSearch;

	// Token: 0x040007CF RID: 1999
	[SerializeField]
	private string[] settingsOptions;

	// Token: 0x040007D0 RID: 2000
	[SerializeField]
	private string[] profileOptions;

	// Token: 0x040007D1 RID: 2001
	[SerializeField]
	private string[] guitarOptions;

	// Token: 0x040007D2 RID: 2002
	[SerializeField]
	private string[] drumsOptions;

	// Token: 0x040007D3 RID: 2003
	[SerializeField]
	private GameObject instIcons;

	// Token: 0x040007D4 RID: 2004
	[SerializeField]
	private RectTransform parentTransform;

	// Token: 0x040007D5 RID: 2005
	private Coroutine \u02BA\u02BA\u02B8\u02B5\u02BC\u02B6\u02B3\u02BD\u02C0\u02B6\u02BE;

	// Token: 0x040007D6 RID: 2006
	public Image \u02BD\u02C1\u02BC\u02BE\u02B4\u02BA\u02B4\u02BC\u02BB\u02B4\u02BF;

	// Token: 0x040007D7 RID: 2007
	public Color \u02BF\u02B7\u02BB\u02BB\u02BF\u02B9\u02B9\u02BF\u02C1\u02B2\u02BC;

	// Token: 0x040007D8 RID: 2008
	public Color \u02B3\u02B9\u02B4\u02C1\u02BB\u02B6\u02C1\u02BE\u02C0\u02C1\u02B2;

	// Token: 0x040007D9 RID: 2009
	public RawImage \u02C0\u02B5\u02B2\u02BD\u02BA\u02B5\u02C1\u02B7\u02B5\u02C0\u02BF;

	// Token: 0x040007DA RID: 2010
	public RawImage \u02B6\u02BB\u02BD\u02C0\u02B2\u02BD\u02BB\u02BF\u02B7\u02BF\u02B8;

	// Token: 0x040007DB RID: 2011
	public RawImage \u02B4\u02B9\u02C0\u02B4\u02BD\u02BD\u02B2\u02BB\u02B3\u02B6\u02B7;

	// Token: 0x040007DC RID: 2012
	public Texture2D \u02BE\u02BA\u02BD\u02BF\u02BB\u02C0\u02BB\u02B8\u02BA\u02BE\u02C1;

	// Token: 0x040007DD RID: 2013
	public Texture2D \u02B3\u02B9\u02B9\u02BD\u02B6\u02B2\u02C1\u02BE\u02B3\u02BF\u02B7;

	// Token: 0x040007DE RID: 2014
	[SerializeField]
	private Image instrumentImage;

	// Token: 0x040007DF RID: 2015
	[SerializeField]
	private Image hostImage;

	// Token: 0x040007E0 RID: 2016
	[SerializeField]
	private Sprite[] instrumentIcons;

	// Token: 0x040007E1 RID: 2017
	[SerializeField]
	private Image[] optionChecks;

	// Token: 0x040007E2 RID: 2018
	[SerializeField]
	private OnlineMenu onlineMenu;

	// Token: 0x040007E3 RID: 2019
	[SerializeField]
	private MIDISetupMenu midiSetupMenu;

	// Token: 0x040007E4 RID: 2020
	public GameObject \u02C0\u02B2\u02B2\u02B5\u02B7\u02B8\u02BA\u02BD\u02BB\u02BD\u02B2;

	// Token: 0x040007E5 RID: 2021
	[SerializeField]
	private TextMeshProUGUI latencyValue;

	// Token: 0x040007E6 RID: 2022
	private PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5 \u02B8\u02BE\u02B9\u02B7\u02B8\u02B9\u02B5\u02BA\u02BF\u02C1\u02BD = PlayerProfileMenu.\u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5.None;

	// Token: 0x040007E7 RID: 2023
	private int \u02BF\u02B8\u02BC\u02B4\u02BA\u02C1\u02C0\u02B9\u02BA\u02B4\u02B7;

	// Token: 0x040007E8 RID: 2024
	private bool \u02BE\u02B5\u02B7\u02C1\u02B2\u02B3\u02B3\u02BD\u02C0\u02B3\u02B6;

	// Token: 0x040007E9 RID: 2025
	private bool \u02C1\u02B7\u02BA\u02B7\u02BB\u02BE\u02B8\u02B5\u02BB\u02B8\u02B8;

	// Token: 0x040007EA RID: 2026
	private bool \u02B5\u02B7\u02B5\u02B6\u02B3\u02B4\u02B7\u02BB\u02BE\u02B6\u02B5;

	// Token: 0x040007EB RID: 2027
	private bool \u02BA\u02B9\u02BB\u02BB\u02C0\u02C0\u02B6\u02C1\u02B6\u02BD\u02BD;

	// Token: 0x040007EC RID: 2028
	[SerializeField]
	private Color guestColor;

	// Token: 0x040007ED RID: 2029
	private int \u02BE\u02BD\u02B8\u02BE\u02C1\u02BA\u02B4\u02B8\u02BD\u02BF\u02B8 = -10000;

	// Token: 0x040007EE RID: 2030
	private bool \u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1;

	// Token: 0x040007EF RID: 2031
	private bool \u02BA\u02BD\u02BF\u02B4\u02BB\u02B8\u02B4\u02BB\u02C1\u02B8\u02BA;

	// Token: 0x02000100 RID: 256
	private enum \u02B2\u02B9\u02C1\u02B6\u02BD\u02BD\u02B4\u02BF\u02B7\u02B6\u02B5
	{
		// Token: 0x040007F1 RID: 2033
		None = -1,
		// Token: 0x040007F2 RID: 2034
		String,
		// Token: 0x040007F3 RID: 2035
		Int,
		// Token: 0x040007F4 RID: 2036
		Percent,
		// Token: 0x040007F5 RID: 2037
		Bool
	}
}
