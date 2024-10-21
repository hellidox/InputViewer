using System;
using StrikeCore;
using TMPro;
using UnityEngine;

// Token: 0x020000E5 RID: 229
public class OnlineMenu : BaseMenu
{
	// Token: 0x06000868 RID: 2152 RVA: 0x0004BABC File Offset: 0x00049CBC
	public void \u02C1\u02BB\u02B2\u02BC\u02BA\u02B9\u02B4\u02B3\u02BD\u02C1\u02BA()
	{
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			if (this.menuStrings[i] == "Game Mode")
			{
				this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Game Mode") + ": " + \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6((GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 == GameMode.Quickplay) ? "Quickplay" : "Versus");
			}
		}
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00009CF2 File Offset: 0x00007EF2
	private void \u02BB\u02BA\u02B5\u02C0\u02BA\u02B5\u02BC\u02B2\u02BC\u02BB\u02BD(string[] \u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0)
	{
		this.menuStrings = \u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x0004BB38 File Offset: 0x00049D38
	public void \u02B4\u02B7\u02B5\u02B6\u02B3\u02BA\u02B8\u02BA\u02B7\u02BE\u02C1()
	{
		for (int i = 0; i < this.menuStrings.Length; i += 0)
		{
			if (this.menuStrings[i] == "song")
			{
				this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("end") + ".mid" + \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4((GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 == GameMode.Quickplay) ? "song" : "ScorePauseWarning");
			}
		}
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x00009D09 File Offset: 0x00007F09
	public virtual void \u02BC\u02B9\u02BB\u02BF\u02B3\u02B2\u02BD\u02C1\u02B8\u02BE\u02B9()
	{
		this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.serverOptions);
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00009D17 File Offset: 0x00007F17
	public void \u02BB\u02B2\u02B5\u02C1\u02B5\u02B8\u02C1\u02B7\u02C1\u02BC\u02B7(\u02C0\u02B5\u02BB\u02BD\u02BF\u02B4\u02B6\u02BF\u02BB\u02BE\u02BE \u02C0\u02B5\u02B8\u02BD\u02C0\u02BF\u02B9\u02BA\u02B4\u02B6\u02B4)
	{
		this.\u02BA\u02BD\u02B8\u02BF\u02B6\u02BE\u02BE\u02C1\u02B3\u02C0\u02BF();
		if (!CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02C1\u02B4\u02B7\u02B5\u02BF\u02BE\u02B9\u02B7\u02BE\u02C1(\u02C0\u02B5\u02B8\u02BD\u02C0\u02BF\u02B9\u02BA\u02B4\u02B6\u02B4))
		{
			CHNetChatBox.\u02B5\u02BA\u02B5\u02B2\u02BD\u02BB\u02B5\u02B7\u02BC\u02B5\u02BA("serverclientnostart", "FF0000", true);
			return;
		}
		this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.connectingOptions);
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x00009D49 File Offset: 0x00007F49
	public void \u02BE\u02B7\u02B7\u02BC\u02B7\u02BA\u02B7\u02C1\u02B6\u02BA\u02BD()
	{
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02BB\u02BF\u02BC\u02BC\u02C1\u02BE\u02B5\u02BA\u02C0\u02B6\u02BE(true);
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x00009D51 File Offset: 0x00007F51
	protected override void OnDisable()
	{
		Cursor.visible = SettingsController.\u02BD\u02C1\u02B5\u02B3\u02BA\u02BC\u02B9\u02B8\u02B7\u02B8\u02C0;
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(true);
		base.OnDisable();
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x0004BBB4 File Offset: 0x00049DB4
	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BC\u02B3\u02BB\u02B2\u02B6\u02BA\u02BB\u02BA\u02BC\u02BD = false;
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("Are you sure you want to disconnect?", "Yes", "No", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02BC\u02B5\u02B9\u02BD\u02B4\u02B7\u02BE\u02C1\u02BB\u02BB\u02B9), null, null);
			return;
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02C1\u02B4\u02B3\u02B2\u02B8\u02C0\u02B5\u02B3\u02B5\u02B4)
		{
			CHNetChatBox.\u02B5\u02BA\u02B5\u02B2\u02BD\u02BB\u02B5\u02B7\u02BC\u02B5\u02BA("Connecting", "8EDC4F", true);
		}
		else
		{
			this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(true, false);
			this.mainMenu.SetActive(true);
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00009D6E File Offset: 0x00007F6E
	protected override void \u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8()
	{
		base.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		this.\u02C1\u02BB\u02B2\u02BC\u02BA\u02B9\u02B4\u02B3\u02BD\u02C1\u02BA();
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0004BC3C File Offset: 0x00049E3C
	public void \u02B3\u02B5\u02B9\u02BF\u02B8\u02B7\u02BB\u02BC\u02BF\u02B8\u02BB(\u02C0\u02B5\u02BB\u02BD\u02BF\u02B4\u02B6\u02BF\u02BB\u02BE\u02BE \u02C0\u02B5\u02B8\u02BD\u02C0\u02BF\u02B9\u02BA\u02B4\u02B6\u02B4)
	{
		\u02C0\u02B5\u02B8\u02BD\u02C0\u02BF\u02B9\u02BA\u02B4\u02B6\u02B4.\u02BC\u02B5\u02BF\u02B7\u02BC\u02BF\u02BE\u02BE\u02B6\u02BB\u02B5 = this.\u02C0\u02B5\u02BD\u02BE\u02BE\u02C1\u02B7\u02B9\u02BA\u02B3\u02BA;
		if (!this.\u02C0\u02B5\u02BD\u02BE\u02BE\u02C1\u02B7\u02B9\u02BA\u02B3\u02BA)
		{
			this.\u02BA\u02BD\u02B8\u02BF\u02B6\u02BE\u02BE\u02C1\u02B3\u02C0\u02BF();
		}
		if (!CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02B5\u02C0\u02B2\u02BD\u02C1\u02BA\u02BE\u02B2\u02B6\u02BB(\u02C0\u02B5\u02B8\u02BD\u02C0\u02BF\u02B9\u02BA\u02B4\u02B6\u02B4))
		{
			CHNetChatBox.\u02B5\u02BA\u02B5\u02B2\u02BD\u02BB\u02B5\u02B7\u02BC\u02B5\u02BA("clientnostart", "FF0000", true);
			return;
		}
		this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.connectingOptions);
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x0004BC90 File Offset: 0x00049E90
	protected override void OnEnable()
	{
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BE\u02BD\u02B6\u02BD\u02B6\u02BF\u02B4\u02BA\u02B3\u02BD ? this.serverOptions : this.clientOptions);
		}
		else
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.unconnectedOptions);
		}
		Cursor.visible = true;
		DiscordController.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02C1\u02B9\u02B5\u02BE\u02BD\u02B5\u02B7\u02C1\u02BB\u02B3();
		base.OnEnable();
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x0004BCF0 File Offset: 0x00049EF0
	public virtual void \u02BB\u02B7\u02BE\u02B7\u02B7\u02B4\u02B2\u02BC\u02B4\u02BE\u02BB()
	{
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B7\u02B6\u02B9\u02B5\u02BC\u02B2\u02BB\u02B2\u02BD())
		{
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BC\u02B3\u02BB\u02B2\u02B6\u02BA\u02BB\u02BA\u02BC\u02BD = false;
			this.confirmMenu.\u02B5\u02B8\u02C0\u02B7\u02BF\u02B7\u02B5\u02BD\u02C1\u02B8\u02B7("Combo", "Single", "Video Start Time", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02BC\u02B5\u02B9\u02BD\u02B4\u02B7\u02BE\u02C1\u02BB\u02BB\u02B9), null, null);
			return;
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02C1\u02B4\u02B3\u02B2\u02B8\u02C0\u02B5\u02B3\u02B5\u02B4)
		{
			CHNetChatBox.\u02BC\u02BD\u02BF\u02BE\u02C0\u02C1\u02B5\u02B2\u02B3\u02BD\u02B2("note_sp_colors", "--profile", false);
		}
		else
		{
			this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(false, true);
			this.mainMenu.SetActive(false);
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x0004BD78 File Offset: 0x00049F78
	public void \u02BD\u02B9\u02B3\u02BB\u02C1\u02C0\u02B4\u02BB\u02BB\u02BB\u02B4()
	{
		for (int i = 1; i < this.menuStrings.Length; i += 0)
		{
			if (this.menuStrings[i] == " (")
			{
				this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("diff_guitar_coop") + "setlistErrorDialog" + \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4((GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 == GameMode.Quickplay) ? "Language" : "device");
			}
		}
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x0004BDF4 File Offset: 0x00049FF4
	protected override void Update()
	{
		if (this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 || this.serverDetails.isActive || this.serverBrowser.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		if (this.menuStrings == this.connectingOptions)
		{
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
			{
				this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BE\u02BD\u02B6\u02BD\u02B6\u02BF\u02B4\u02BA\u02B3\u02BD ? this.serverOptions : this.clientOptions);
			}
			else if (!CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02C1\u02B4\u02B3\u02B2\u02B8\u02C0\u02B5\u02B3\u02B5\u02B4)
			{
				this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.unconnectedOptions);
			}
		}
		if (this.menuStrings == this.clientOptions && CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02C0\u02BD\u02BE\u02B6\u02B6\u02B9\u02BA\u02B8\u02C1\u02B2)
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.unconnectedOptions);
		}
		base.Update();
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00009D7C File Offset: 0x00007F7C
	[\u02B2\u02B6\u02B4\u02B9\u02BF\u02C0\u02BA\u02BD\u02C0\u02B3\u02BD]
	public void EnablePlayerInput()
	{
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(true);
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00009D84 File Offset: 0x00007F84
	private void \u02BE\u02BF\u02BA\u02B2\u02B5\u02B8\u02B5\u02B3\u02B5\u02B6\u02B9()
	{
		this.spectatorHosting.SetActive(!CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB || \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02BC\u02B2\u02B9\u02BF\u02B2\u02B4\u02C0\u02B4\u02B8\u02B4 < 2);
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x00009DB0 File Offset: 0x00007FB0
	private void FixedUpdate()
	{
		this.spectatorHosting.SetActive(CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02BC\u02B2\u02B9\u02BF\u02B2\u02B4\u02C0\u02B4\u02B8\u02B4 >= 4);
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00009DDC File Offset: 0x00007FDC
	[\u02B2\u02B6\u02B4\u02B9\u02BF\u02C0\u02BA\u02BD\u02C0\u02B3\u02BD]
	public void DisablePlayerInput()
	{
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(false);
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x00009D09 File Offset: 0x00007F09
	public override void \u02BF\u02BD\u02B6\u02B2\u02B6\u02BE\u02B5\u02BF\u02BA\u02B8\u02BD()
	{
		this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.serverOptions);
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x00009D09 File Offset: 0x00007F09
	public virtual void \u02BB\u02BA\u02B6\u02B8\u02B2\u02C1\u02BB\u02B2\u02BB\u02B9\u02B9()
	{
		this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.serverOptions);
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x0004BEAC File Offset: 0x0004A0AC
	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		uint num = PrivateImplementationDetails.ComputeStringHash(text);
		if (num <= 2664808298U)
		{
			if (num != 1988702168U)
			{
				if (num != 2043668191U)
				{
					if (num != 2664808298U)
					{
						return;
					}
					if (!(text == "Join as Spectator"))
					{
						return;
					}
					this.\u02C0\u02B5\u02BD\u02BE\u02BE\u02C1\u02B7\u02B9\u02BA\u02B3\u02BA = true;
					this.serverBrowser.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD();
					return;
				}
				else
				{
					if (!(text == "Start Game"))
					{
						return;
					}
					\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B3\u02B7\u02BA\u02BE\u02B8\u02B4\u02B7\u02BF\u02B9\u02C0(\u02C0\u02C0\u02BD\u02B6\u02BA\u02BF\u02B3\u02BE\u02BC\u02B8\u02B4.SongList);
					base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
					return;
				}
			}
			else
			{
				if (!(text == "Join Server"))
				{
					return;
				}
				this.\u02C0\u02B5\u02BD\u02BE\u02BE\u02C1\u02B7\u02B9\u02BA\u02B3\u02BA = false;
				this.serverBrowser.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD();
				return;
			}
		}
		else if (num <= 3302109059U)
		{
			if (num != 3220526844U)
			{
				if (num != 3302109059U)
				{
					return;
				}
				if (!(text == "Connecting..."))
				{
					return;
				}
				CHNetChatBox.\u02B5\u02BA\u02B5\u02B2\u02BD\u02BB\u02B5\u02B7\u02BC\u02B5\u02BA("alreadyconnecting", "8EDC4F", true);
				return;
			}
			else
			{
				if (!(text == "Create Server"))
				{
					return;
				}
				this.serverDetails.StartCreateServer();
				return;
			}
		}
		else if (num != 3539955570U)
		{
			if (num != 4197397088U)
			{
				return;
			}
			if (!(text == "Leave"))
			{
				return;
			}
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BC\u02B3\u02BB\u02B2\u02B6\u02BA\u02BB\u02BA\u02BC\u02BD = true;
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("Are you sure you want to disconnect?", "Yes", "No", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02BC\u02B5\u02B9\u02BD\u02B4\u02B7\u02BE\u02C1\u02BB\u02BB\u02B9), null, null);
			return;
		}
		else
		{
			if (!(text == "Game Mode"))
			{
				return;
			}
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BE\u02BD\u02B6\u02BD\u02B6\u02BF\u02B4\u02BA\u02B3\u02BD)
			{
				\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BC\u02BA\u02BF\u02B6\u02BA\u02BA\u02B3\u02BE\u02B4\u02B3((GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 == GameMode.Quickplay) ? GameMode.Versus : GameMode.Quickplay);
			}
			return;
		}
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x0004C02C File Offset: 0x0004A22C
	public void \u02C1\u02BD\u02C1\u02BA\u02BE\u02C1\u02C0\u02B4\u02BD\u02BD\u02B7()
	{
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BF\u02BD\u02C1\u02C0\u02BC\u02B7\u02B4\u02C0\u02B4\u02C1();
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BA\u02BB\u02B8\u02B9\u02C0\u02BD\u02B5\u02B4\u02B6\u02B3 = true;
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 = false;
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6 = true;
		this.menuMusic.GetComponent<MenuMusic>().\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(false);
		base.gameObject.SetActive(false);
		this.songSelect.SetActive(true);
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x00009DE4 File Offset: 0x00007FE4
	public void \u02B3\u02B8\u02B9\u02B3\u02B6\u02B6\u02B5\u02BD\u02BB\u02BC\u02B7(\u02C0\u02B5\u02BB\u02BD\u02BF\u02B4\u02B6\u02BF\u02BB\u02BE\u02BE \u02C0\u02B5\u02B8\u02BD\u02C0\u02BF\u02B9\u02BA\u02B4\u02B6\u02B4)
	{
		this.\u02BA\u02BD\u02B8\u02BF\u02B6\u02BE\u02BE\u02C1\u02B3\u02C0\u02BF();
		if (!CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B2\u02B8\u02BF\u02B7\u02BB\u02B8\u02B8\u02BD\u02B4\u02C0(\u02C0\u02B5\u02B8\u02BD\u02C0\u02BF\u02B9\u02BA\u02B4\u02B6\u02B4))
		{
			CHNetChatBox.\u02B5\u02BA\u02B5\u02B2\u02BD\u02BB\u02B5\u02B7\u02BC\u02B5\u02BA("song", "Leave", false);
			return;
		}
		this.\u02BB\u02BA\u02B5\u02C0\u02BA\u02B5\u02BC\u02B2\u02BC\u02BB\u02BD(this.connectingOptions);
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x0004C088 File Offset: 0x0004A288
	protected virtual void \u02B9\u02B7\u02C0\u02B7\u02C1\u02BA\u02BC\u02C0\u02C1\u02BD\u02B6()
	{
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.\u02BB\u02BA\u02B5\u02C0\u02BA\u02B5\u02BC\u02B2\u02BC\u02BB\u02BD(CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BE\u02BD\u02B6\u02BD\u02B6\u02BF\u02B4\u02BA\u02B3\u02BD ? this.serverOptions : this.clientOptions);
		}
		else
		{
			this.\u02BB\u02BA\u02B5\u02C0\u02BA\u02B5\u02BC\u02B2\u02BC\u02BB\u02BD(this.unconnectedOptions);
		}
		Cursor.visible = true;
		DiscordController.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B4\u02BB\u02B9\u02B4\u02BE\u02B6\u02B8\u02B6\u02BD\u02B8();
		base.OnEnable();
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x0004C0E8 File Offset: 0x0004A2E8
	private void \u02BA\u02BD\u02B8\u02BF\u02B6\u02BE\u02BE\u02C1\u02B3\u02C0\u02BF()
	{
		for (int i = 0; i < GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.Count; i++)
		{
			if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].playerInfo.colorProfileName == "Random")
			{
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].playerInfo.\u02B4\u02BF\u02B9\u02BF\u02B3\u02B9\u02B9\u02B6\u02B5\u02BF\u02BB();
				return;
			}
		}
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x0004C16C File Offset: 0x0004A36C
	public void \u02BD\u02B5\u02B8\u02B8\u02B6\u02B8\u02B4\u02B8\u02BE\u02BA\u02B8()
	{
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BF\u02BD\u02C1\u02C0\u02BC\u02B7\u02B4\u02C0\u02B4\u02C1();
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BA\u02BB\u02B8\u02B9\u02C0\u02BD\u02B5\u02B4\u02B6\u02B3 = false;
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 = true;
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6 = true;
		this.menuMusic.GetComponent<MenuMusic>().\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(false);
		base.gameObject.SetActive(false);
		this.songSelect.SetActive(false);
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x0004C1C8 File Offset: 0x0004A3C8
	protected virtual void \u02C0\u02BB\u02B6\u02B9\u02B3\u02B4\u02B3\u02B7\u02BD\u02B8\u02C0()
	{
		if (this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 || this.serverDetails.isActive || this.serverBrowser.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		if (this.menuStrings == this.connectingOptions)
		{
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B7\u02B6\u02B9\u02B5\u02BC\u02B2\u02BB\u02B2\u02BD())
			{
				this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BE\u02BD\u02B6\u02BD\u02B6\u02BF\u02B4\u02BA\u02B3\u02BD ? this.serverOptions : this.clientOptions);
			}
			else if (!CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02C1\u02B4\u02B3\u02B2\u02B8\u02C0\u02B5\u02B3\u02B5\u02B4)
			{
				this.\u02BB\u02BA\u02B5\u02C0\u02BA\u02B5\u02BC\u02B2\u02BC\u02BB\u02BD(this.unconnectedOptions);
			}
		}
		if (this.menuStrings == this.clientOptions && CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02C0\u02BD\u02BE\u02B6\u02B6\u02B9\u02BA\u02B8\u02C1\u02B2)
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.unconnectedOptions);
		}
		base.Update();
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x0004C280 File Offset: 0x0004A480
	public void \u02BE\u02C1\u02BE\u02BC\u02BA\u02C1\u02B2\u02C0\u02B4\u02B2\u02BE()
	{
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BF\u02BD\u02C1\u02C0\u02BC\u02B7\u02B4\u02C0\u02B4\u02C1();
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BA\u02BB\u02B8\u02B9\u02C0\u02BD\u02B5\u02B4\u02B6\u02B3 = false;
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 = true;
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6 = true;
		this.menuMusic.GetComponent<MenuMusic>().\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(true);
		base.gameObject.SetActive(true);
		this.songSelect.SetActive(false);
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00009CF2 File Offset: 0x00007EF2
	private void \u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(string[] \u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0)
	{
		this.menuStrings = \u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00009E16 File Offset: 0x00008016
	public void \u02BB\u02B5\u02C1\u02BA\u02C0\u02BD\u02B6\u02B2\u02BD\u02BB\u02B5()
	{
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02BB\u02BF\u02BC\u02BC\u02C1\u02BE\u02B5\u02BA\u02C0\u02B6\u02BE(false);
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x00009E1E File Offset: 0x0000801E
	public void \u02BA\u02B6\u02BC\u02B2\u02BB\u02B8\u02B2\u02C0\u02BB\u02B4\u02B4(\u02C0\u02B5\u02BB\u02BD\u02BF\u02B4\u02B6\u02BF\u02BB\u02BE\u02BE \u02C0\u02B5\u02B8\u02BD\u02C0\u02BF\u02B9\u02BA\u02B4\u02B6\u02B4)
	{
		this.\u02BA\u02BD\u02B8\u02BF\u02B6\u02BE\u02BE\u02C1\u02B3\u02C0\u02BF();
		if (!CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B5\u02BE\u02B3\u02B9\u02B7\u02BE\u02BD\u02B6\u02B9\u02B6(\u02C0\u02B5\u02B8\u02BD\u02C0\u02BF\u02B9\u02BA\u02B4\u02B6\u02B4))
		{
			CHNetChatBox.\u02B5\u02BB\u02B2\u02BB\u02B9\u02B8\u02B6\u02BE\u02B5\u02C0\u02C0("Hide Accents/Ghosts", "groupNotesMissed", true);
			return;
		}
		this.\u02BB\u02BA\u02B5\u02C0\u02BA\u02B5\u02BC\u02B2\u02BC\u02BB\u02BD(this.connectingOptions);
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x0004C2DC File Offset: 0x0004A4DC
	public void \u02B6\u02BB\u02BD\u02B6\u02B2\u02BE\u02B5\u02B2\u02B4\u02BD\u02B9()
	{
		for (int i = 0; i < this.menuStrings.Length; i += 0)
		{
			if (this.menuStrings[i] == "Main Menu")
			{
				this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Ghosts Hit") + "startActivity" + \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD((GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 == GameMode.Quickplay) ? "charter" : "profile{0}");
			}
		}
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x00007534 File Offset: 0x00005734
	private void \u02BC\u02B5\u02B9\u02BD\u02B4\u02B7\u02BE\u02C1\u02BB\u02BB\u02B9()
	{
		\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B9\u02B2\u02C1\u02BC\u02B2\u02B8\u02BC\u02BF\u02B9\u02BE();
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x0004C358 File Offset: 0x0004A558
	public virtual void \u02BE\u02B5\u02B4\u02B8\u02BC\u02B3\u02BD\u02B9\u02B7\u02C0\u02B4()
	{
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B7\u02B6\u02B9\u02B5\u02BC\u02B2\u02BB\u02B2\u02BD())
		{
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BC\u02B3\u02BB\u02B2\u02B6\u02BA\u02BB\u02BA\u02BC\u02BD = true;
			this.confirmMenu.\u02B7\u02B3\u02BC\u02BE\u02BF\u02B7\u02B4\u02C0\u02B9\u02BC\u02BF("Stacktrace: ", "song", "Are you sure you want to restart?", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02BC\u02B5\u02B9\u02BD\u02B4\u02B7\u02BE\u02C1\u02BB\u02BB\u02B9), null, null);
			return;
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02C1\u02B4\u02B3\u02B2\u02B8\u02C0\u02B5\u02B3\u02B5\u02B4)
		{
			CHNetChatBox.\u02BC\u02BD\u02BF\u02BE\u02C0\u02C1\u02B5\u02B2\u02B3\u02BD\u02B2(" ", "icons", true);
		}
		else
		{
			this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(true, true);
			this.mainMenu.SetActive(true);
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	// Token: 0x040006BD RID: 1725
	[SerializeField]
	private GameObject mainMenu;

	// Token: 0x040006BE RID: 1726
	[SerializeField]
	private ConfirmationMenu confirmMenu;

	// Token: 0x040006BF RID: 1727
	[SerializeField]
	private string[] serverOptions;

	// Token: 0x040006C0 RID: 1728
	[SerializeField]
	private string[] clientOptions;

	// Token: 0x040006C1 RID: 1729
	[SerializeField]
	private string[] unconnectedOptions;

	// Token: 0x040006C2 RID: 1730
	[SerializeField]
	private string[] connectingOptions;

	// Token: 0x040006C3 RID: 1731
	[SerializeField]
	public TextMeshProUGUI latencyText;

	// Token: 0x040006C4 RID: 1732
	[SerializeField]
	private GameObject songSelect;

	// Token: 0x040006C5 RID: 1733
	[SerializeField]
	private GameObject menuMusic;

	// Token: 0x040006C6 RID: 1734
	[SerializeField]
	private ServerDetails serverDetails;

	// Token: 0x040006C7 RID: 1735
	[SerializeField]
	private ServerListMenu serverBrowser;

	// Token: 0x040006C8 RID: 1736
	[SerializeField]
	private GameObject spectatorHosting;

	// Token: 0x040006C9 RID: 1737
	private bool \u02C0\u02B5\u02BD\u02BE\u02BE\u02C1\u02B7\u02B9\u02BA\u02B3\u02BA;
}
