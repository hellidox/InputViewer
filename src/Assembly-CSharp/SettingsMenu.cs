using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000104 RID: 260
public class SettingsMenu : BaseMenu
{
	// Token: 0x06000AD7 RID: 2775 RVA: 0x0005FA34 File Offset: 0x0005DC34
	protected virtual void \u02BE\u02B9\u02B7\u02B5\u02BC\u02B2\u02B8\u02BC\u02C0\u02B9\u02BE()
	{
		this.\u02BE\u02BB\u02B3\u02B6\u02B6\u02C0\u02C0\u02B7\u02B2\u02B4\u02BA = string.Empty;
		(this.generalMenu as GeneralSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("Highway Placement");
		(this.audioMenu as AudioSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("_z");
		(this.videoMenu as VideoSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(": ");
		(this.gameplayMenu as GameplaySettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("enable_cursor");
		this.generalMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.audioMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.videoMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.gameplayMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		base.OnEnable();
		this.\u02B7\u02B5\u02C1\u02B2\u02BC\u02BE\u02B3\u02BC\u02B2\u02C1\u02B4();
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x0005FAD8 File Offset: 0x0005DCD8
	private void \u02BC\u02BB\u02BC\u02BE\u02B9\u02BA\u02BA\u02B2\u02B7\u02B5\u02B7()
	{
		this.generalMenu.gameObject.SetActive(true);
		this.audioMenu.gameObject.SetActive(false);
		this.videoMenu.gameObject.SetActive(false);
		this.gameplayMenu.gameObject.SetActive(true);
		this.generalMenu.enabled = true;
		this.audioMenu.enabled = true;
		this.videoMenu.enabled = false;
		this.gameplayMenu.enabled = false;
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x0005FB5C File Offset: 0x0005DD5C
	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "General")
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.generalMenu.gameObject.SetActive(true);
				this.generalMenu.enabled = true;
				(this.generalMenu as GeneralSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02B7\u02B6\u02B2\u02BF\u02C1\u02B5\u02B2\u02C0\u02B6\u02B7\u02B4;
				base.enabled = false;
				return;
			}
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Audio")
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.audioMenu.gameObject.SetActive(true);
				this.audioMenu.enabled = true;
				(this.audioMenu as AudioSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02B7\u02B6\u02B2\u02BF\u02C1\u02B5\u02B2\u02C0\u02B6\u02B7\u02B4;
				base.enabled = false;
				return;
			}
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Video")
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.videoMenu.gameObject.SetActive(true);
				this.videoMenu.enabled = true;
				(this.videoMenu as VideoSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02B7\u02B6\u02B2\u02BF\u02C1\u02B5\u02B2\u02C0\u02B6\u02B7\u02B4;
				base.enabled = false;
				return;
			}
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Gameplay")
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.gameplayMenu.gameObject.SetActive(true);
				this.gameplayMenu.enabled = true;
				(this.gameplayMenu as GameplaySettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02B7\u02B6\u02B2\u02BF\u02C1\u02B5\u02B2\u02C0\u02B6\u02B7\u02B4;
				base.enabled = false;
				return;
			}
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Credits")
			{
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
				SceneManager.LoadScene("Credits");
				return;
			}
			if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Back"))
			{
				return;
			}
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			this.mainMenu.SetActive(true);
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x0000B745 File Offset: 0x00009945
	public void \u02BC\u02BD\u02BE\u02B9\u02B8\u02B2\u02BB\u02B9\u02BD\u02BD\u02B5()
	{
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x0005FD38 File Offset: 0x0005DF38
	private void \u02BB\u02BB\u02B4\u02B2\u02BA\u02BF\u02BE\u02BE\u02B6\u02BA\u02B6()
	{
		this.generalMenu.gameObject.SetActive(false);
		this.audioMenu.gameObject.SetActive(false);
		this.videoMenu.gameObject.SetActive(false);
		this.gameplayMenu.gameObject.SetActive(false);
		this.generalMenu.enabled = false;
		this.audioMenu.enabled = false;
		this.videoMenu.enabled = false;
		this.gameplayMenu.enabled = false;
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x0005FDBC File Offset: 0x0005DFBC
	private void \u02BE\u02B3\u02BA\u02BD\u02B7\u02BD\u02BF\u02B7\u02BF\u02BD\u02C1()
	{
		this.generalMenu.gameObject.SetActive(true);
		this.audioMenu.gameObject.SetActive(false);
		this.videoMenu.gameObject.SetActive(false);
		this.gameplayMenu.gameObject.SetActive(false);
		this.generalMenu.enabled = true;
		this.audioMenu.enabled = true;
		this.videoMenu.enabled = true;
		this.gameplayMenu.enabled = false;
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x0005FE40 File Offset: 0x0005E040
	private void \u02BE\u02BB\u02BA\u02B8\u02BC\u02BB\u02B7\u02C1\u02BB\u02BF\u02C1()
	{
		this.generalMenu.gameObject.SetActive(true);
		this.audioMenu.gameObject.SetActive(false);
		this.videoMenu.gameObject.SetActive(false);
		this.gameplayMenu.gameObject.SetActive(false);
		this.generalMenu.enabled = false;
		this.audioMenu.enabled = true;
		this.videoMenu.enabled = false;
		this.gameplayMenu.enabled = false;
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x0005FEC4 File Offset: 0x0005E0C4
	protected override void Update()
	{
		if (this.\u02BE\u02BB\u02B3\u02B6\u02B6\u02C0\u02C0\u02B7\u02B2\u02B4\u02BA != base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0)
		{
			this.\u02BE\u02BB\u02B3\u02B6\u02B6\u02C0\u02C0\u02B7\u02B2\u02B4\u02BA = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			this.\u02BB\u02BB\u02B4\u02B2\u02BA\u02BF\u02BE\u02BE\u02B6\u02BA\u02B6();
			string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			if (!(text == "General"))
			{
				if (!(text == "Audio"))
				{
					if (!(text == "Video"))
					{
						if (!(text == "Gameplay"))
						{
							if (text == "Back")
							{
								this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
							}
						}
						else
						{
							this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
							this.gameplayMenu.gameObject.SetActive(true);
							(this.gameplayMenu as GameplaySettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02BA\u02C0\u02B7\u02C1\u02BE\u02B7\u02C1\u02B2\u02C0\u02B8\u02BC;
						}
					}
					else
					{
						this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
						this.videoMenu.gameObject.SetActive(true);
						(this.videoMenu as VideoSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02BA\u02C0\u02B7\u02C1\u02BE\u02B7\u02C1\u02B2\u02C0\u02B8\u02BC;
					}
				}
				else
				{
					this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
					this.audioMenu.gameObject.SetActive(true);
					(this.audioMenu as AudioSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02BA\u02C0\u02B7\u02C1\u02BE\u02B7\u02C1\u02B2\u02C0\u02B8\u02BC;
				}
			}
			else
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.generalMenu.gameObject.SetActive(true);
				(this.generalMenu as GeneralSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02BA\u02C0\u02B7\u02C1\u02BE\u02B7\u02C1\u02B2\u02C0\u02B8\u02BC;
			}
		}
		base.Update();
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x00060034 File Offset: 0x0005E234
	protected virtual void \u02B3\u02C1\u02B9\u02B7\u02B4\u02BF\u02BD\u02B9\u02BB\u02BE\u02B6()
	{
		this.\u02BE\u02BB\u02B3\u02B6\u02B6\u02C0\u02C0\u02B7\u02B2\u02B4\u02BA = string.Empty;
		(this.generalMenu as GeneralSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("Star Animation FPS");
		(this.audioMenu as AudioSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("guitar");
		(this.videoMenu as VideoSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("while lexing the header section");
		(this.gameplayMenu as GameplaySettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("isOnline");
		this.generalMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.audioMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.videoMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.gameplayMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		base.OnEnable();
		this.\u02BE\u02BB\u02BA\u02B8\u02BC\u02BB\u02B7\u02C1\u02BB\u02BF\u02C1();
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x000600D8 File Offset: 0x0005E2D8
	protected virtual void \u02B4\u02B6\u02BD\u02B5\u02C0\u02B6\u02BA\u02C1\u02C0\u02BC\u02BB()
	{
		if (this.\u02BE\u02BB\u02B3\u02B6\u02B6\u02C0\u02C0\u02B7\u02B2\u02B4\u02BA != base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7())
		{
			this.\u02BE\u02BB\u02B3\u02B6\u02B6\u02C0\u02C0\u02B7\u02B2\u02B4\u02BA = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			this.\u02BC\u02BB\u02BC\u02BE\u02B9\u02BA\u02BA\u02B2\u02B7\u02B5\u02B7();
			string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			if (!(text == "Easy"))
			{
				if (!(text == "drum_pad_scrolling"))
				{
					if (!(text == "<color=#00FFFF>"))
					{
						if (!(text == "Are you sure you want to delete this song?"))
						{
							if (text == "Video Offset")
							{
								this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
							}
						}
						else
						{
							this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
							this.gameplayMenu.gameObject.SetActive(false);
							(this.gameplayMenu as GameplaySettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02BA\u02C0\u02B7\u02C1\u02BE\u02B7\u02C1\u02B2\u02C0\u02B8\u02BC;
						}
					}
					else
					{
						this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
						this.videoMenu.gameObject.SetActive(true);
						(this.videoMenu as VideoSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02BA\u02C0\u02B7\u02C1\u02BE\u02B7\u02C1\u02B2\u02C0\u02B8\u02BC;
					}
				}
				else
				{
					this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
					this.audioMenu.gameObject.SetActive(true);
					(this.audioMenu as AudioSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02BA\u02C0\u02B7\u02C1\u02BE\u02B7\u02C1\u02B2\u02C0\u02B8\u02BC;
				}
			}
			else
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.generalMenu.gameObject.SetActive(false);
				(this.generalMenu as GeneralSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02BA\u02C0\u02B7\u02C1\u02BE\u02B7\u02C1\u02B2\u02C0\u02B8\u02BC;
			}
		}
		base.Update();
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x00060248 File Offset: 0x0005E448
	private void Awake()
	{
		(this.videoMenu as VideoSettingsMenu).\u02B4\u02BF\u02B6\u02B3\u02B7\u02BA\u02B9\u02B9\u02BD\u02BD\u02B4();
		(this.generalMenu as GeneralSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("");
		(this.audioMenu as AudioSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("");
		(this.videoMenu as VideoSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("");
		(this.gameplayMenu as GameplaySettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("");
		this.generalMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.audioMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.videoMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.gameplayMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x000602E8 File Offset: 0x0005E4E8
	protected override void OnEnable()
	{
		this.\u02BE\u02BB\u02B3\u02B6\u02B6\u02C0\u02C0\u02B7\u02B2\u02B4\u02BA = string.Empty;
		(this.generalMenu as GeneralSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("");
		(this.audioMenu as AudioSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("");
		(this.videoMenu as VideoSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("");
		(this.gameplayMenu as GameplaySettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("");
		this.generalMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.audioMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.videoMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.gameplayMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		base.OnEnable();
		this.\u02BB\u02BB\u02B4\u02B2\u02BA\u02BF\u02BE\u02BE\u02B6\u02BA\u02B6();
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x0006038C File Offset: 0x0005E58C
	private void \u02B7\u02B5\u02C1\u02B2\u02BC\u02BE\u02B3\u02BC\u02B2\u02C1\u02B4()
	{
		this.generalMenu.gameObject.SetActive(true);
		this.audioMenu.gameObject.SetActive(false);
		this.videoMenu.gameObject.SetActive(false);
		this.gameplayMenu.gameObject.SetActive(false);
		this.generalMenu.enabled = false;
		this.audioMenu.enabled = false;
		this.videoMenu.enabled = false;
		this.gameplayMenu.enabled = false;
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x0000B74D File Offset: 0x0000994D
	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(true, false);
		this.mainMenu.SetActive(true);
		this.\u02B2\u02BD\u02B6\u02BE\u02B4\u02BE\u02B9\u02B6\u02BD\u02B4\u02B7();
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00060410 File Offset: 0x0005E610
	protected virtual void \u02C0\u02B4\u02BF\u02B7\u02BD\u02B7\u02B6\u02BA\u02B6\u02BD\u02B3()
	{
		this.\u02BE\u02BB\u02B3\u02B6\u02B6\u02C0\u02C0\u02B7\u02B2\u02B4\u02BA = string.Empty;
		(this.generalMenu as GeneralSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("Leave");
		(this.audioMenu as AudioSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("8EDC4F");
		(this.videoMenu as VideoSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("_y");
		(this.gameplayMenu as GameplaySettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("android.permission.WRITE_EXTERNAL_STORAGE");
		this.generalMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.audioMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.videoMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.gameplayMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		base.OnEnable();
		this.\u02B7\u02B5\u02C1\u02B2\u02BC\u02BE\u02B3\u02BC\u02B2\u02C1\u02B4();
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x0000B77A File Offset: 0x0000997A
	public virtual void \u02BF\u02C0\u02C1\u02BD\u02B4\u02B7\u02BD\u02B3\u02B3\u02BD\u02C0()
	{
		this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(false, false);
		this.mainMenu.SetActive(false);
		this.\u02B2\u02BD\u02B6\u02BE\u02B4\u02BE\u02B9\u02B6\u02BD\u02B4\u02B7();
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x000604B4 File Offset: 0x0005E6B4
	protected virtual void \u02B3\u02BC\u02BB\u02BF\u02C1\u02BE\u02B4\u02BC\u02BE\u02BF\u02B8()
	{
		this.\u02BE\u02BB\u02B3\u02B6\u02B6\u02C0\u02C0\u02B7\u02B2\u02B4\u02BA = string.Empty;
		(this.generalMenu as GeneralSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("Continue");
		(this.audioMenu as AudioSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("groupFcCount");
		(this.videoMenu as VideoSettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("Solid Solo!");
		(this.gameplayMenu as GameplaySettingsMenu).\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("Drunk Mode");
		this.generalMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.audioMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.videoMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		this.gameplayMenu.\u02BE\u02B2\u02B9\u02BF\u02B3\u02C0\u02B2\u02B4\u02B5\u02B7\u02BA();
		base.OnEnable();
		this.\u02BC\u02BB\u02BC\u02BE\u02B9\u02BA\u02BA\u02B2\u02B7\u02B5\u02B7();
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x0000B745 File Offset: 0x00009945
	public void \u02B5\u02C1\u02B9\u02B8\u02C1\u02B3\u02B7\u02B8\u02B2\u02B6\u02B7()
	{
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x00060558 File Offset: 0x0005E758
	public virtual void \u02BD\u02B3\u02B9\u02BD\u02B3\u02BE\u02B4\u02B9\u02BB\u02BE\u02B9()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "")
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.generalMenu.gameObject.SetActive(true);
				this.generalMenu.enabled = true;
				(this.generalMenu as GeneralSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02B7\u02B6\u02B2\u02BF\u02C1\u02B5\u02B2\u02C0\u02B6\u02B7\u02B4;
				base.enabled = true;
				return;
			}
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "guitarcoop")
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.audioMenu.gameObject.SetActive(false);
				this.audioMenu.enabled = true;
				(this.audioMenu as AudioSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02B7\u02B6\u02B2\u02BF\u02C1\u02B5\u02B2\u02C0\u02B6\u02B7\u02B4;
				base.enabled = false;
				return;
			}
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Language: '")
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.videoMenu.gameObject.SetActive(true);
				this.videoMenu.enabled = true;
				(this.videoMenu as VideoSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02B7\u02B6\u02B2\u02BF\u02C1\u02B5\u02B2\u02C0\u02B6\u02B7\u02B4;
				base.enabled = true;
				return;
			}
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "highway_sp")
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.gameplayMenu.gameObject.SetActive(true);
				this.gameplayMenu.enabled = true;
				(this.gameplayMenu as GameplaySettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02B7\u02B6\u02B2\u02BF\u02C1\u02B5\u02B2\u02C0\u02B6\u02B7\u02B4;
				base.enabled = false;
				return;
			}
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "song")
			{
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(false);
				SceneManager.LoadScene("songName");
				return;
			}
			if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "ModChart Prep"))
			{
				return;
			}
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			this.mainMenu.SetActive(false);
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x00060734 File Offset: 0x0005E934
	public virtual void \u02B2\u02BA\u02B2\u02BC\u02B6\u02B4\u02BB\u02B6\u02B8\u02BE\u02B3()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Audio Backend")
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.generalMenu.gameObject.SetActive(false);
				this.generalMenu.enabled = false;
				(this.generalMenu as GeneralSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02B7\u02B6\u02B2\u02BF\u02C1\u02B5\u02B2\u02C0\u02B6\u02B7\u02B4;
				base.enabled = true;
				return;
			}
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "ERROR: These folders contain charts that another song has (duplicate charts)!")
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.audioMenu.gameObject.SetActive(false);
				this.audioMenu.enabled = false;
				(this.audioMenu as AudioSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02B7\u02B6\u02B2\u02BF\u02C1\u02B5\u02B2\u02C0\u02B6\u02B7\u02B4;
				base.enabled = true;
				return;
			}
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "6-fret Rhythm")
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.videoMenu.gameObject.SetActive(false);
				this.videoMenu.enabled = false;
				(this.videoMenu as VideoSettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02B7\u02B6\u02B2\u02BF\u02C1\u02B5\u02B2\u02C0\u02B6\u02B7\u02B4;
				base.enabled = true;
				return;
			}
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "part drum")
			{
				this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
				this.gameplayMenu.gameObject.SetActive(false);
				this.gameplayMenu.enabled = false;
				(this.gameplayMenu as GameplaySettingsMenu).\u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA.sprite = this.\u02B7\u02B6\u02B2\u02BF\u02C1\u02B5\u02B2\u02C0\u02B6\u02B7\u02B4;
				base.enabled = true;
				return;
			}
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Online Highway Placement")
			{
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BC\u02BB\u02BC\u02C1\u02C0\u02B4\u02B9\u02BC\u02BC\u02C0(true);
				SceneManager.LoadScene("Pastel Burst");
				return;
			}
			if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "connectionclosed"))
			{
				return;
			}
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			this.mainMenu.SetActive(true);
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x00060910 File Offset: 0x0005EB10
	private void \u02BD\u02B2\u02B9\u02B7\u02B9\u02BE\u02B6\u02BE\u02B9\u02C1\u02B4()
	{
		this.generalMenu.gameObject.SetActive(false);
		this.audioMenu.gameObject.SetActive(true);
		this.videoMenu.gameObject.SetActive(true);
		this.gameplayMenu.gameObject.SetActive(false);
		this.generalMenu.enabled = false;
		this.audioMenu.enabled = false;
		this.videoMenu.enabled = true;
		this.gameplayMenu.enabled = false;
	}

	// Token: 0x04000802 RID: 2050
	[SerializeField]
	private GameObject mainMenu;

	// Token: 0x04000803 RID: 2051
	[SerializeField]
	private BaseMenu generalMenu;

	// Token: 0x04000804 RID: 2052
	[SerializeField]
	private BaseMenu audioMenu;

	// Token: 0x04000805 RID: 2053
	[SerializeField]
	private BaseMenu videoMenu;

	// Token: 0x04000806 RID: 2054
	[SerializeField]
	private BaseMenu gameplayMenu;

	// Token: 0x04000807 RID: 2055
	private string \u02B7\u02BE\u02BF\u02BB\u02BA\u02BD\u02B7\u02BA\u02BE\u02BD\u02B7;

	// Token: 0x04000808 RID: 2056
	private int \u02BE\u02BC\u02B8\u02BC\u02B3\u02B5\u02B7\u02BD\u02B8\u02B7\u02B8;

	// Token: 0x04000809 RID: 2057
	private List<string> \u02BA\u02C1\u02C0\u02BE\u02B3\u02BA\u02B2\u02BF\u02BD\u02B8\u02C0;

	// Token: 0x0400080A RID: 2058
	public Sprite \u02BA\u02C0\u02B7\u02C1\u02BE\u02B7\u02C1\u02B2\u02C0\u02B8\u02BC;

	// Token: 0x0400080B RID: 2059
	public Sprite \u02B7\u02B6\u02B2\u02BF\u02C1\u02B5\u02B2\u02C0\u02B6\u02B7\u02B4;

	// Token: 0x0400080C RID: 2060
	private string \u02BE\u02BB\u02B3\u02B6\u02B6\u02C0\u02C0\u02B7\u02B2\u02B4\u02BA = string.Empty;
}
