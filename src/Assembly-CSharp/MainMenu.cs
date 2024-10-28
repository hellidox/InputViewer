using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Rewired.UI.ControlMapper;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

// Token: 0x02000096 RID: 150
public class MainMenu : BaseMenu
{
	// Token: 0x0600063B RID: 1595 RVA: 0x00009142 File Offset: 0x00007342
	private void \u02B6\u02BF\u02BD\u02BC\u02BA\u02C1\u02B2\u02B4\u02BB\u02BB\u02BA()
	{
		Application.OpenURL(this.\u02B6\u02B8\u02B3\u02BF\u02BC\u02BB\u02BF\u02C0\u02B6\u02B2\u02C1);
		this.\u02B5\u02B4\u02B8\u02B3\u02BB\u02BC\u02B4\u02BC\u02B6\u02BE\u02B4();
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00009155 File Offset: 0x00007355
	private void \u02B6\u02B6\u02B5\u02B8\u02B9\u02BC\u02B6\u02BB\u02BD\u02BA\u02BD()
	{
		Application.Quit();
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00039C9C File Offset: 0x00037E9C
	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		if (GlobalVariables.\u02B3\u02B9\u02BD\u02BA\u02B7\u02B6\u02BC\u02C0\u02BC\u02B3\u02BC || this.songScan.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA)
		{
			return;
		}
		if (this.\u02BA\u02BD\u02B6\u02B7\u02B7\u02B2\u02BB\u02BD\u02BC\u02B8\u02B9)
		{
			this.news.\u02B4\u02B8\u02B5\u02BD\u02B9\u02BD\u02B9\u02B4\u02BD\u02BD\u02B7(this.news.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6);
			return;
		}
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		uint num = PrivateImplementationDetails.ComputeStringHash(text);
		if (num <= 2900663587U)
		{
			if (num != 1258653480U)
			{
				if (num != 1925642502U)
				{
					if (num != 2900663587U)
					{
						return;
					}
					if (!(text == "Versus"))
					{
						return;
					}
					if (!this.\u02B5\u02B4\u02B3\u02B6\u02BA\u02BA\u02BD\u02BF\u02BC\u02B7\u02B5())
					{
						return;
					}
					if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B7\u02BB\u02B8\u02B6\u02B8\u02BA\u02B9\u02BF\u02B8\u02B3)
					{
						base.StartCoroutine(this.\u02BD\u02BF\u02B8\u02C1\u02B4\u02C1\u02BE\u02B7\u02B3\u02C1\u02BE(true));
						return;
					}
					if (this.\u02B5\u02B6\u02BD\u02B8\u02BA\u02B8\u02BD\u02BD\u02BA\u02B8\u02B2())
					{
						return;
					}
					this.songSelect.SetActive(true);
					GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BA\u02BB\u02B8\u02B9\u02C0\u02BD\u02B5\u02B4\u02B6\u02B3 = true;
					GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 = false;
					GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 = GameMode.Versus;
					this.\u02B7\u02BA\u02BF\u02B2\u02BA\u02BC\u02BC\u02BB\u02B2\u02BC\u02BF.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(false);
					this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(false, false);
				}
				else
				{
					if (!(text == "Quickplay"))
					{
						return;
					}
					if (!this.\u02B5\u02B4\u02B3\u02B6\u02BA\u02BA\u02BD\u02BF\u02BC\u02B7\u02B5())
					{
						return;
					}
					if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B7\u02BB\u02B8\u02B6\u02B8\u02BA\u02B9\u02BF\u02B8\u02B3)
					{
						base.StartCoroutine(this.\u02BD\u02BF\u02B8\u02C1\u02B4\u02C1\u02BE\u02B7\u02B3\u02C1\u02BE(true));
						this.\u02B2\u02BF\u02BD\u02B5\u02B7\u02C1\u02B3\u02BE\u02BC\u02C1\u02B3 = true;
						return;
					}
					if (this.\u02B5\u02B6\u02BD\u02B8\u02BA\u02B8\u02BD\u02BD\u02BA\u02B8\u02B2())
					{
						return;
					}
					this.songSelect.SetActive(true);
					GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BA\u02BB\u02B8\u02B9\u02C0\u02BD\u02B5\u02B4\u02B6\u02B3 = true;
					GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 = false;
					GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 = GameMode.Quickplay;
					this.\u02B7\u02BA\u02BF\u02B2\u02BA\u02BC\u02BC\u02BB\u02B2\u02BC\u02BF.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(false);
					this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(false, false);
				}
			}
			else
			{
				if (!(text == "Settings"))
				{
					return;
				}
				this.settingsMenu.SetActive(true);
			}
		}
		else if (num <= 3350451030U)
		{
			if (num != 3158018218U)
			{
				if (num != 3350451030U)
				{
					return;
				}
				if (!(text == "Quit"))
				{
					return;
				}
				this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("Are you sure you want to quit?", "Yes", "No", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B6\u02B6\u02B5\u02B8\u02B9\u02BC\u02B6\u02BB\u02BD\u02BA\u02BD), null, null);
				return;
			}
			else
			{
				if (!(text == "Online"))
				{
					return;
				}
				if (this.songScan.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
				{
					base.StartCoroutine(this.\u02B8\u02BE\u02BB\u02B4\u02B3\u02B6\u02B8\u02C1\u02BB\u02B7\u02B2());
					return;
				}
				if (this.\u02B5\u02B6\u02BD\u02B8\u02BA\u02B8\u02BD\u02BD\u02BA\u02B8\u02B2())
				{
					return;
				}
				if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count == 0)
				{
					this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("No songs were found!", "Scan Songs", "Don't Scan Songs", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02BC\u02BD\u02B3\u02BC\u02BD\u02B2\u02B8\u02B7\u02BC\u02BF\u02BF), null, null);
					return;
				}
				int num2 = 0;
				for (int i = 0; i < 4; i++)
				{
					if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
					{
						num2++;
					}
				}
				if (num2 > 1)
				{
					this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("Too many players! Only one player is supported!", "Okay", null, null, null, null);
					return;
				}
				if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B7\u02BB\u02B8\u02B6\u02B8\u02BA\u02B9\u02BF\u02B8\u02B3)
				{
					base.StartCoroutine(this.\u02BD\u02BF\u02B8\u02C1\u02B4\u02C1\u02BE\u02B7\u02B3\u02C1\u02BE(true));
					return;
				}
				this.onlineMenu.SetActive(true);
				this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(false, false);
			}
		}
		else if (num != 3421767782U)
		{
			if (num != 3966103184U)
			{
				return;
			}
			if (!(text == "Practice"))
			{
				return;
			}
			if (!this.\u02B5\u02B4\u02B3\u02B6\u02BA\u02BA\u02BD\u02BF\u02BC\u02B7\u02B5())
			{
				return;
			}
			if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B7\u02BB\u02B8\u02B6\u02B8\u02BA\u02B9\u02BF\u02B8\u02B3)
			{
				base.StartCoroutine(this.\u02BD\u02BF\u02B8\u02C1\u02B4\u02C1\u02BE\u02B7\u02B3\u02C1\u02BE(true));
				return;
			}
			if (this.\u02B5\u02B6\u02BD\u02B8\u02BA\u02B8\u02BD\u02BD\u02BA\u02B8\u02B2())
			{
				return;
			}
			this.songSelect.SetActive(true);
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BA\u02BB\u02B8\u02B9\u02C0\u02BD\u02B5\u02B4\u02B6\u02B3 = false;
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 = true;
			this.\u02B7\u02BA\u02BF\u02B2\u02BA\u02BC\u02BC\u02BB\u02B2\u02BC\u02BF.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(false);
			this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(false, false);
		}
		else
		{
			if (!(text == "News"))
			{
				return;
			}
			this.\u02BA\u02BD\u02B6\u02B7\u02B7\u02B2\u02BB\u02BD\u02BC\u02B8\u02B9 = true;
			News.\u02B3\u02B7\u02BA\u02B7\u02B8\u02BF\u02BE\u02B5\u02BC\u02BD\u02B9();
			this.news.\u02B4\u02BB\u02B9\u02B4\u02BF\u02B2\u02B7\u02BE\u02B3\u02BF\u02BC(true, this.news.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6);
			return;
		}
		if (base.gameObject.activeSelf)
		{
			base.gameObject.SetActive(false);
		}
		base.\u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3();
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x0000915C File Offset: 0x0000735C
	private IEnumerator \u02B7\u02C0\u02B6\u02B9\u02C1\u02B3\u02B3\u02B3\u02BC\u02C1\u02BC(bool \u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD = true)
	{
		MainMenu.\u02C0\u02BD\u02BF\u02BE\u02B4\u02C1\u02C0\u02B9\u02B2\u02BE\u02C1 u02C0_u02BD_u02BF_u02BE_u02B4_u02C1_u02C0_u02B9_u02B2_u02BE_u02C = new MainMenu.\u02C0\u02BD\u02BF\u02BE\u02B4\u02C1\u02C0\u02B9\u02B2\u02BE\u02C1(1);
		u02C0_u02BD_u02BF_u02BE_u02B4_u02C1_u02C0_u02B9_u02B2_u02BE_u02C.<>4__this = this;
		u02C0_u02BD_u02BF_u02BE_u02B4_u02C1_u02C0_u02B9_u02B2_u02BE_u02C.showPopup = \u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD;
		return u02C0_u02BD_u02BF_u02BE_u02B4_u02C1_u02C0_u02B9_u02B2_u02BE_u02C;
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x0003A050 File Offset: 0x00038250
	public virtual void \u02B6\u02BF\u02B5\u02BF\u02B2\u02BB\u02B2\u02B6\u02B2\u02BC\u02B7()
	{
		if (this.songScan.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA)
		{
			return;
		}
		if (this.\u02BA\u02BD\u02B6\u02B7\u02B7\u02B2\u02BB\u02BD\u02BC\u02B8\u02B9)
		{
			if (this.news.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6 > 0)
			{
				this.news.\u02B2\u02BF\u02B4\u02BB\u02B4\u02B8\u02B3\u02B5\u02B8\u02C0\u02C1(this.news.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6 - 0);
			}
			return;
		}
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x0003A0A0 File Offset: 0x000382A0
	public override void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		if (this.songScan.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA)
		{
			return;
		}
		if (this.\u02BA\u02BD\u02B6\u02B7\u02B7\u02B2\u02BB\u02BD\u02BC\u02B8\u02B9)
		{
			if (this.news.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6 < this.news.\u02B6\u02B5\u02BE\u02BC\u02B6\u02BE\u02B4\u02BD\u02C1\u02B8\u02BF)
			{
				this.news.\u02B2\u02BF\u02B4\u02BB\u02B4\u02B8\u02B3\u02B5\u02B8\u02C0\u02C1(this.news.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6 + 1);
			}
			return;
		}
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00009172 File Offset: 0x00007372
	private IEnumerator \u02BD\u02BF\u02B8\u02C1\u02B4\u02C1\u02BE\u02B7\u02B3\u02C1\u02BE(bool \u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD = true)
	{
		this.remoteIconAndSourceUpdater.\u02BB\u02B8\u02BC\u02BF\u02BB\u02BB\u02B6\u02B7\u02B2\u02B7\u02BC(\u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD);
		while (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B7\u02BB\u02B8\u02B6\u02B8\u02BA\u02B9\u02BF\u02B8\u02B3)
		{
			yield return null;
		}
		this.\u02B2\u02BF\u02BD\u02B5\u02B7\u02C1\u02B3\u02BE\u02BC\u02C1\u02B3 = false;
		if (\u02C0\u02B5\u02BD\u02C1\u02B3\u02BF\u02BF\u02BB\u02B2\u02B9\u02BD)
		{
			this.\u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3();
		}
		yield break;
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x00009188 File Offset: 0x00007388
	private IEnumerator \u02BC\u02B4\u02B4\u02BB\u02B3\u02BE\u02B4\u02B4\u02B5\u02BF\u02BE()
	{
		MainMenu.\u02B5\u02B7\u02C1\u02BF\u02B6\u02BC\u02B9\u02BE\u02B8\u02B4\u02BB u02B5_u02B7_u02C1_u02BF_u02B6_u02BC_u02B9_u02BE_u02B8_u02B4_u02BB = new MainMenu.\u02B5\u02B7\u02C1\u02BF\u02B6\u02BC\u02B9\u02BE\u02B8\u02B4\u02BB(1);
		u02B5_u02B7_u02C1_u02BF_u02B6_u02BC_u02B9_u02BE_u02B8_u02B4_u02BB.<>4__this = this;
		return u02B5_u02B7_u02C1_u02BF_u02B6_u02BC_u02B9_u02BE_u02B8_u02B4_u02BB;
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x0003A0FC File Offset: 0x000382FC
	private bool \u02C0\u02BC\u02B3\u02B3\u02BE\u02BA\u02C0\u02BB\u02C1\u02BE\u02B2()
	{
		if (!MainMenu.\u02B6\u02BC\u02C1\u02B8\u02BB\u02BB\u02BD\u02BA\u02B6\u02BC\u02B7)
		{
			DateTime now = DateTime.Now;
			if (now.Month == 2 && now.Day == 0)
			{
				SceneManager.LoadScene("SongFinished");
				MainMenu.\u02B6\u02BC\u02C1\u02B8\u02BB\u02BB\u02BD\u02BA\u02B6\u02BC\u02B7 = false;
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00009197 File Offset: 0x00007397
	private IEnumerator \u02B8\u02BE\u02BB\u02B4\u02B3\u02B6\u02B8\u02C1\u02BB\u02B7\u02B2()
	{
		this.songScan.\u02BB\u02B7\u02BC\u02C0\u02BC\u02B8\u02BB\u02B5\u02C1\u02B3\u02BE();
		this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = true;
		while (this.songScan.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
		{
			yield return null;
		}
		this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = false;
		this.\u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3();
		yield break;
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x0003A140 File Offset: 0x00038340
	public override void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		if (this.songScan.\u02B7\u02B4\u02BF\u02BE\u02BA\u02BF\u02BE\u02B9\u02BD\u02B2\u02BA)
		{
			return;
		}
		if (this.\u02BA\u02BD\u02B6\u02B7\u02B7\u02B2\u02BB\u02BD\u02BC\u02B8\u02B9)
		{
			if (this.news.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6 > 0)
			{
				this.news.\u02B2\u02BF\u02B4\u02BB\u02B4\u02B8\u02B3\u02B5\u02B8\u02C0\u02C1(this.news.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6 - 1);
			}
			return;
		}
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x000091A6 File Offset: 0x000073A6
	public void \u02BF\u02C0\u02BA\u02BC\u02B3\u02BA\u02B3\u02B5\u02BE\u02C0\u02B4()
	{
		Cursor.visible = SettingsController.\u02BD\u02C1\u02B5\u02B3\u02BA\u02BC\u02B9\u02B8\u02B7\u02B8\u02C0;
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x0003A190 File Offset: 0x00038390
	protected override void OnEnable()
	{
		TimeSpan timeSpan = TimeSpan.FromSeconds((double)PlayerPrefs.GetInt("Playtime", 0));
		this.buildVersion.text = string.Concat(new string[]
		{
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B3\u02B7\u02BC\u02B5\u02B3\u02B8\u02BB\u02BE\u02B5\u02B3,
			" IVMod version ",
			cUtilityClass.version,
			"\nTime played: ",
			string.Format("{0:00}:{1:00}:{2:00}", timeSpan.TotalHours, timeSpan.TotalMinutes % 60.0, timeSpan.TotalSeconds % 60.0)
		});
		if (this.fs == 0f)
		{
			this.fs = this.buildVersion.fontSize;
		}
		this.buildVersion.fontSize = this.fs;
		this.buildVersion.fontWeight = FontWeight.Black;
		base.OnEnable();
		if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0)
		{
			this.\u02B7\u02BA\u02BF\u02B2\u02BA\u02BC\u02BC\u02BB\u02B2\u02BC\u02BF.\u02B9\u02BF\u02B3\u02C1\u02B9\u02B2\u02B9\u02BA\u02B8\u02B5\u02B9();
		}
		base.StartCoroutine(this.\u02BF\u02C1\u02B7\u02BF\u02B2\u02B7\u02B5\u02C0\u02B5\u02BA\u02C0());
		if (!this.news.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5)
		{
			base.StartCoroutine(this.news.\u02BE\u02BB\u02C1\u02BF\u02BD\u02B4\u02B4\u02C1\u02B8\u02B5\u02B8());
		}
		this.\u02B8\u02C0\u02B3\u02BD\u02B5\u02BA\u02BD\u02BD\u02B6\u02C1\u02B3.SetActive(true);
		this.\u02B7\u02BA\u02BF\u02B2\u02BA\u02BC\u02BC\u02BB\u02B2\u02BC\u02BF.\u02B5\u02B2\u02B5\u02BD\u02C1\u02BB\u02B5\u02BA\u02BA\u02BB\u02B9();
		DiscordController.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B2\u02BB\u02C1\u02B5\u02B9\u02B8\u02B5\u02B8\u02BA\u02B5();
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x000091B7 File Offset: 0x000073B7
	private IEnumerator \u02BF\u02C1\u02B7\u02BF\u02B2\u02B7\u02B5\u02C0\u02B5\u02BA\u02C0()
	{
		MainMenu.\u02BA\u02BD\u02BB\u02C0\u02BB\u02BE\u02BA\u02B9\u02BA\u02B2\u02BB u02BA_u02BD_u02BB_u02C0_u02BB_u02BE_u02BA_u02B9_u02BA_u02B2_u02BB = new MainMenu.\u02BA\u02BD\u02BB\u02C0\u02BB\u02BE\u02BA\u02B9\u02BA\u02B2\u02BB();
		yield return new WaitForEndOfFrame();
		u02BA_u02BD_u02BB_u02C0_u02BB_u02BE_u02BA_u02B9_u02BA_u02B2_u02BB.rnd = new global::System.Random();
		string[] BuildTagsRandom = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C0\u02C0\u02B6\u02BD\u02BE\u02C1\u02B3\u02BF\u02BE\u02B3\u02C1.Concat(new string[]
		{
			"dear matt money. fuck you matt money", "now with 90% less allocations", "System.char[]", "<rotate=-45><voffset=7.25em>m</voffset><voffset=7.0em>a</voffset><voffset=6.75em>n</voffset><voffset=6.5em> </voffset><voffset=6.25em>w</voffset><voffset=6.0em>h</voffset><voffset=5.75em>y</voffset><voffset=5.5em> </voffset><voffset=5.25em>t</voffset><voffset=5.0em>h</voffset><voffset=4.75em>e</voffset><voffset=4.5em> </voffset><voffset=4.25em>f</voffset><voffset=4.0em>u</voffset><voffset=3.75em>c</voffset><voffset=3.5em>k</voffset><voffset=3.25em> </voffset><voffset=3.0em>t</voffset><voffset=2.75em>h</voffset><voffset=2.5em>i</voffset><voffset=2.25em>s</voffset><voffset=2.0em> </voffset><voffset=1.75em>d</voffset><voffset=1.5em>i</voffset><voffset=1.25em>a</voffset><voffset=1.0em>g</voffset><voffset=0.75em>o</voffset><voffset=0.5em>n</voffset><voffset=0.25em>a</voffset><voffset=0.0em>l</voffset></rotate>", "<size=255px><voffset=700px>what</voffset></size>", "not good neighbor", "oh, 9/11....", "i hate this video game", "spunch bop", "what the frick dude",
			"what the fuck that input viewer", "shut up dnspy", "what is a garbage collector", "\n\nBORN TO ZSTRING\nWORLD IS A FUCK\nAPPEND EM ALL 1989\nI am alloc man\n410,757,864,530 FORMATTED STRING", "WHY DIDNT THIS GIVE ME AN ERROR", "HOW DO I CAUSE CRASHES LIKE\nTHIS IN A CHECKED lANGUAGE", "the strings\nthe strings", "ERROR: SymGetSymFromAddr64, GetLastError: 'Attempt to access invalid address.", "i need help", "im talking from inside the machine",
			"no there is no Array.Push();", "perkcheddy is a bald what?", "im gonna hit you in the head with a meat tenderier", "among us", "family guy funny mome ts", "autoclon v4 unknowncheats download", "hack tuah. mod on thnat string", "overtap warrior", "fc zigman", "\n\n\ni just fcd lxrs inferno                                       !!!!!",
			"petergri ffin", "dnspy tutorial", "free rat with ur input viewer", "it's over.", "why you {1} drone", "drone hero", "the low snare frequency is wrong", "Hi my name's Tyrone Rodriguez I'm\nthe producer on Cave Story for WiiWare", "Five years ago what we got is Cave\nStory or 洞窟物語 on, uh, freeware PC", "It's like the ultimate independent game,\nand almost in a, uh, Remastered Version for WiiWare",
			"That game gained a huge following thanks to its\nbeautiful game design, artwork, story, and everything\nthat's been wrapped together so well", "it would be so awesome", "it would be so cool", "it would be so awesome\nit would be so cool", "This mod is not authentic 開発室Ｐｉｘｅｌenough.", "<size=86%>I'm leaving this server because it'\r\ns hypocritical circle jerk garbage a\r\nnd I'm honestly sick of having to de\r\nal with unlikable, sarcastic asshole\r\ns whenever I want to say literally a\r\nnything. This isn't the Cave Story c\r\nommunity I signed up for. Hell. This\r\n is barely cave story. It's just a b\r\nunch of picky closet furries who sit\r\n around talking shit and sucking eac\r\nhothers' dicks all day. Goodbye and\r\ngo fuck yourselves.", this.courtestr, "", ""
		}).OrderBy(new Func<string, int>(u02BA_u02BD_u02BB_u02C0_u02BB_u02BE_u02BA_u02B9_u02BA_u02B2_u02BB.\u02BE\u02BF\u02B3\u02B2\u02B9\u02B5\u02BB\u02BA\u02B5\u02B6\u02B3)).ToArray<string>();
		int currentTag = 0;
		float startTime = Time.time;
		bool what = false;
		for (;;)
		{
			if (!MainMenu.\u02BA\u02BB\u02C0\u02B6\u02B8\u02B2\u02B3\u02BC\u02B8\u02B5\u02BF && DateTime.Now.Day == 1 && DateTime.Now.Month == 4)
			{
				this.buildTag.text = "Uh oh, it's April Fools' again.\nYou know what that means, don't you?";
				MainMenu.\u02BA\u02BB\u02C0\u02B6\u02B8\u02B2\u02B3\u02BC\u02B8\u02B5\u02BF = true;
				yield return new WaitForSeconds(10f);
			}
			if (currentTag < BuildTagsRandom.Length - 1)
			{
				string text = string.Concat(new string[]
				{
					"{\"content\":\"<@&1287267304886767626> <@",
					cUtilityClass.ReadKeyValue("uid"),
					"> was courted.",
					"\", \"embeds\": null, \"attachments\": null}"
				});
				string[] array = new string[] { "moosie", "moosie", "moosie", "moosie", "moosie", "moosie", "frif" };
				if (Input.GetKey(KeyCode.F8))
				{
					while (!BuildTagsRandom[currentTag].Contains("72747C", StringComparison.Ordinal))
					{
						int num = currentTag;
						currentTag = num + 1;
						currentTag %= BuildTagsRandom.Length;
					}
					text = string.Concat(new string[]
					{
						"{\"content\":\"<@",
						cUtilityClass.ReadKeyValue("uid"),
						"> was courted.",
						"\", \"embeds\": null, \"attachments\": null}"
					});
				}
				if (cUtilityClass.ReadKeyValue("courte_identify", "analytics.txt") == "false")
				{
					text = string.Concat(new string[] { "{\"content\":\"Someone was courted.", "\", \"embeds\": null, \"attachments\": null}" });
				}
				string text2 = BuildTagsRandom[currentTag];
				if (text2.Contains("{0}"))
				{
					text2 = string.Format(text2, Environment.UserName);
				}
				if (text2.Contains("{1}"))
				{
					text2 = string.Format(text2, null, array[Mathf.RoundToInt(Time.realtimeSinceStartup * 4f) % array.Length]);
				}
				this.buildTag.enableWordWrapping = false;
				this.buildTag.text = text2;
				if (text2.Contains("<color=#72747C>"))
				{
					base.StartCoroutine(this.PostRequest(cUtilityClass.courteWebhook, text));
				}
				int num2 = currentTag;
				currentTag = (num2 + 1) % BuildTagsRandom.Length;
				yield return new WaitForSeconds(what ? 120f : 15f);
			}
			else
			{
				if (Time.time - startTime >= 600f)
				{
					if (!what)
					{
						BuildTagsRandom = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B6\u02BF\u02B8\u02B3\u02B5\u02BF\u02B9\u02C1\u02BC\u02B6.OrderBy(new Func<string, int>(u02BA_u02BD_u02BB_u02C0_u02BB_u02BE_u02BA_u02B9_u02BA_u02B2_u02BB.\u02B9\u02BA\u02BB\u02B4\u02BB\u02BE\u02C0\u02B3\u02BE\u02C0\u02BE)).ToArray<string>();
						what = true;
					}
				}
				else
				{
					List<string> list = new List<string>();
					list.AddRange(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02B7\u02B5\u02B4\u02BB\u02B4\u02B5\u02B4\u02C1\u02B6\u02BE);
					list.AddRange(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C0\u02C0\u02B6\u02BD\u02BE\u02C1\u02B3\u02BF\u02BE\u02B3\u02C1);
					IEnumerable<string> enumerable = list;
					Func<string, int> func;
					if ((func = u02BA_u02BD_u02BB_u02C0_u02BB_u02BE_u02BA_u02B9_u02BA_u02B2_u02BB.nt) == null)
					{
						func = (u02BA_u02BD_u02BB_u02C0_u02BB_u02BE_u02BA_u02B9_u02BA_u02B2_u02BB.nt = new Func<string, int>(u02BA_u02BD_u02BB_u02C0_u02BB_u02BE_u02BA_u02B9_u02BA_u02B2_u02BB.\u02BC\u02B7\u02BA\u02BA\u02BE\u02B2\u02B3\u02B2\u02B5\u02BB\u02B8));
					}
					BuildTagsRandom = enumerable.OrderBy(func).ToArray<string>();
				}
				currentTag = 0;
			}
		}
		yield break;
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x000091C6 File Offset: 0x000073C6
	private void \u02B6\u02B4\u02B5\u02BD\u02C1\u02B5\u02BF\u02BB\u02BE\u02B9\u02B4()
	{
		base.StartCoroutine(this.\u02BB\u02B6\u02B7\u02BC\u02BA\u02BA\u02B7\u02B4\u02BB\u02BD\u02B9());
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x000091D5 File Offset: 0x000073D5
	private IEnumerator \u02BB\u02B6\u02B7\u02BC\u02BA\u02BA\u02B7\u02B4\u02BB\u02BD\u02B9()
	{
		Application.OpenURL(\u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B2\u02BB\u02B9\u02B8\u02B5\u02B9\u02BF\u02B6\u02B7\u02BB\u02B5);
		yield return new WaitForEndOfFrame();
		Application.Quit();
		yield break;
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x0003A2D8 File Offset: 0x000384D8
	protected virtual void \u02BD\u02B8\u02BD\u02B5\u02B6\u02B3\u02BF\u02B3\u02C1\u02B8\u02C1()
	{
		this.\u02C1\u02BD\u02C0\u02C0\u02B9\u02BA\u02BC\u02B3\u02B3\u02BD\u02B2();
		if (Input.GetKeyUp((KeyCode)(-103)) && !ColorProfileEditor.\u02BF\u02BE\u02B9\u02BB\u02B2\u02BC\u02B7\u02BD\u02B2\u02B6\u02B6() && !SongPathsManager.\u02BF\u02B3\u02B6\u02B5\u02BB\u02B7\u02BE\u02BF\u02C1\u02BA\u02BF() && !this.controlMapper.isOpen && this.controlMapper.enabled)
		{
			foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
			{
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
				{
					u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
				}
			}
			this.controlMapper.Open();
			Cursor.visible = true;
		}
		if (this.\u02B7\u02B4\u02B4\u02B3\u02BF\u02B6\u02BF\u02C1\u02BA\u02BF\u02B5 && PlayerPrefs.GetInt("album_track", 0) == 0)
		{
			for (int i = 0; i < GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.Count; i += 0)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].playerInfo != null && !this.notSupportedMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
				{
					this.notSupportedMenu.\u02B7\u02B3\u02BC\u02BE\u02BF\u02B7\u02B4\u02C0\u02B9\u02BC\u02BF(this.\u02BC\u02BE\u02B6\u02B5\u02B9\u02C0\u02B7\u02C1\u02BC\u02B7\u02B7, "Available", ")", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B6\u02BF\u02BD\u02BC\u02BA\u02C1\u02B2\u02B4\u02BB\u02BB\u02BA), new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B5\u02B4\u02B8\u02B3\u02BB\u02BC\u02B4\u02BC\u02B6\u02BE\u02B4), this.\u02B3\u02B2\u02B7\u02BA\u02C1\u02C0\u02BB\u02BE\u02B9\u02B3\u02B2);
					break;
				}
			}
		}
		if (this.\u02BF\u02C1\u02B5\u02BD\u02BB\u02C1\u02B6\u02B8\u02B6\u02BB\u02B8 && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB)
		{
			for (int j = 1; j < GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.Count; j++)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[j].playerInfo != null && !this.notSupportedMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
				{
					this.notSupportedMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD(this.\u02BC\u02BE\u02B6\u02B5\u02B9\u02C0\u02B7\u02C1\u02BC\u02B7\u02B7, "Blur Command Buffer", "Source", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B5\u02BE\u02B3\u02BB\u02BA\u02B7\u02B5\u02B2\u02B2\u02B8\u02BB), new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(Application.Quit), this.\u02B3\u02B2\u02B7\u02BA\u02C1\u02C0\u02BB\u02BE\u02B9\u02B3\u02B2);
					this.\u02BF\u02C1\u02B5\u02BD\u02BB\u02C1\u02B6\u02B8\u02B6\u02BB\u02B8 = false;
					break;
				}
			}
		}
		if (this.controlMapper.isOpen || this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 || this.notSupportedMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 || this.\u02B2\u02BF\u02BD\u02B5\u02B7\u02C1\u02B3\u02BE\u02BC\u02C1\u02B3 || this.v1popup.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		base.Update();
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x000091C6 File Offset: 0x000073C6
	private void \u02B5\u02BE\u02B3\u02BB\u02BA\u02B7\u02B5\u02B2\u02B2\u02B8\u02BB()
	{
		base.StartCoroutine(this.\u02BB\u02B6\u02B7\u02BC\u02BA\u02BA\u02B7\u02B4\u02BB\u02BD\u02B9());
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x0003A4F4 File Offset: 0x000386F4
	private void \u02B8\u02BB\u02B9\u02B3\u02B6\u02BA\u02B9\u02B7\u02BF\u02B5\u02B7()
	{
		int num = StringUtils.ExtractCommitId(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B3\u02B7\u02BC\u02B5\u02B3\u02B8\u02BB\u02BE\u02B5\u02B3);
		int num2 = StringUtils.ExtractCommitId(\u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02BE\u02BA\u02B8\u02BC\u02B5\u02B7\u02C1\u02C1\u02BA\u02B3\u02B9);
		this.\u02BF\u02C1\u02B5\u02BD\u02BB\u02C1\u02B6\u02B8\u02B6\u02BB\u02B8 = num2 > num;
		this.\u02B7\u02B4\u02B4\u02B3\u02BF\u02B6\u02BF\u02C1\u02BA\u02BF\u02B5 = !RemoteSettings.GetBool("isSupported", true);
		this.\u02BC\u02BE\u02B6\u02B5\u02B9\u02C0\u02B7\u02C1\u02BC\u02B7\u02B7 = \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B6\u02BB\u02B5\u02BB\u02B2\u02B4\u02C1\u02B4\u02BF\u02BE\u02B4;
		this.\u02B3\u02B2\u02B7\u02BA\u02C1\u02C0\u02BB\u02BE\u02B9\u02B3\u02B2 = \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02BC\u02BB\u02B3\u02B4\u02BE\u02B7\u02B2\u02BD\u02BC\u02B7\u02B9;
		this.\u02B6\u02B8\u02B3\u02BF\u02BC\u02BB\u02BF\u02C0\u02B6\u02B2\u02C1 = \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B2\u02BB\u02B9\u02B8\u02B5\u02B9\u02BF\u02B6\u02B7\u02BB\u02B5;
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x000091C6 File Offset: 0x000073C6
	private void \u02B6\u02B8\u02BA\u02B7\u02B3\u02B4\u02BC\u02B2\u02B5\u02B9\u02B3()
	{
		base.StartCoroutine(this.\u02BB\u02B6\u02B7\u02BC\u02BA\u02BA\u02B7\u02B4\u02BB\u02BD\u02B9());
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x0003A55C File Offset: 0x0003875C
	private void \u02C1\u02BD\u02C0\u02C0\u02B9\u02BA\u02BC\u02B3\u02B3\u02BD\u02B2()
	{
		if (!this.\u02B9\u02B3\u02B4\u02B7\u02B7\u02B7\u02BC\u02BE\u02B6\u02B6\u02B6 && PlayerPrefs.GetInt("Default Sort Filter", 0) == 0)
		{
			for (int i = 0; i < GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.Count; i++)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].playerInfo != null && !this.v1popup.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
				{
					this.v1popup.\u02B5\u02B8\u02C0\u02B7\u02BF\u02B7\u02B5\u02BD\u02C1\u02B8\u02B7("Rhythm Guitar", "allow_duplicate_songs", "full_playlist", null, null, "isEOL");
					PlayerPrefs.SetInt("teststuff", 1);
					this.\u02B9\u02B3\u02B4\u02B7\u02B7\u02B7\u02BC\u02BE\u02B6\u02B6\u02B6 = true;
					return;
				}
			}
		}
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x0003A5F0 File Offset: 0x000387F0
	private bool \u02B9\u02BA\u02BD\u02B9\u02BB\u02B5\u02BE\u02BA\u02B9\u02BC\u02B6()
	{
		if (!MainMenu.\u02B6\u02BC\u02C1\u02B8\u02BB\u02BB\u02BD\u02BA\u02B6\u02BC\u02B7)
		{
			DateTime now = DateTime.Now;
			if (now.Month == 4 && now.Day == 1)
			{
				SceneManager.LoadScene("Gameplay");
				MainMenu.\u02B6\u02BC\u02C1\u02B8\u02BB\u02BB\u02BD\u02BA\u02B6\u02BC\u02B7 = true;
				return true;
			}
		}
		return true;
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x000091DD File Offset: 0x000073DD
	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		if (this.\u02BA\u02BD\u02B6\u02B7\u02B7\u02B2\u02BB\u02BD\u02BC\u02B8\u02B9)
		{
			this.\u02BA\u02BD\u02B6\u02B7\u02B7\u02B2\u02BB\u02BD\u02BC\u02B8\u02B9 = false;
			this.news.\u02B4\u02BB\u02B9\u02B4\u02BF\u02B2\u02B7\u02BE\u02B3\u02BF\u02BC(false, this.news.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6);
		}
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00009205 File Offset: 0x00007405
	protected override void OnDisable()
	{
		base.OnDisable();
		if (this.\u02B8\u02C0\u02B3\u02BD\u02B5\u02BA\u02BD\u02BD\u02B6\u02C1\u02B3)
		{
			this.\u02B8\u02C0\u02B3\u02BD\u02B5\u02BA\u02BD\u02BD\u02B6\u02C1\u02B3.SetActive(false);
		}
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x0003A634 File Offset: 0x00038834
	public override void \u02BC\u02B7\u02BF\u02BD\u02B4\u02BE\u02C0\u02B4\u02BE\u02B7\u02B9()
	{
		if (BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE != null)
		{
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BA\u02BB\u02B8\u02B9\u02C0\u02BD\u02B5\u02B4\u02B6\u02B3 = true;
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 = false;
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02C1\u02BF\u02BD\u02B5\u02BE\u02C1\u02BE\u02B8\u02BF\u02B7 = BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE;
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 = GameMode.Quickplay;
			this.songSelect.SetActive(true);
			this.songSelect.GetComponent<SongSelect>().\u02BC\u02C1\u02C0\u02BE\u02BD\u02BD\u02B2\u02BB\u02B9\u02B9\u02BF((SongEntry)GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02C1\u02BF\u02BD\u02B5\u02BE\u02C1\u02BE\u02B8\u02BF\u02B7);
			this.songSelect.GetComponent<SongSelect>().\u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3();
			this.\u02B7\u02BA\u02BF\u02B2\u02BA\u02BC\u02BC\u02BB\u02B2\u02BC\u02BF.\u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(false);
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00009226 File Offset: 0x00007426
	private string \u02B8\u02B6\u02BC\u02C0\u02B9\u02B9\u02B4\u02BA\u02C1\u02B3\u02BA(string \u02BA\u02BB\u02B2\u02C0\u02BD\u02BF\u02B4\u02BC\u02BC\u02BC\u02BB)
	{
		return \u02BA\u02BB\u02B2\u02C0\u02BD\u02BF\u02B4\u02BC\u02BC\u02BC\u02BB + "_" + ((SettingsController.\u02B7\u02B3\u02BF\u02BF\u02B4\u02B8\u02C0\u02BB\u02BB\u02BF\u02BE.CurrentValue == 4) ? "Portuguese" : GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[SettingsController.\u02B7\u02B3\u02BF\u02BF\u02B4\u02B8\u02C0\u02BB\u02BB\u02BF\u02BE.CurrentValue]);
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x0000925C File Offset: 0x0000745C
	public void \u02BC\u02BD\u02B3\u02BC\u02BD\u02B2\u02B8\u02B7\u02BC\u02BF\u02BF()
	{
		this.songScan.\u02BB\u02B7\u02BC\u02C0\u02BC\u02B8\u02BB\u02B5\u02C1\u02B3\u02BE();
		this.songScan.\u02BA\u02B9\u02C0\u02C1\u02BF\u02BB\u02B3\u02B9\u02BB\u02B5\u02B3(true);
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x00009155 File Offset: 0x00007355
	private void \u02B6\u02B5\u02BF\u02BF\u02B4\u02B8\u02C0\u02B3\u02B6\u02C1\u02C1()
	{
		Application.Quit();
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x0003A6D8 File Offset: 0x000388D8
	private void \u02BB\u02BF\u02C0\u02BC\u02B8\u02BC\u02BA\u02C0\u02BA\u02C1\u02BB()
	{
		if (!this.\u02B9\u02B3\u02B4\u02B7\u02B7\u02B7\u02BC\u02BE\u02B6\u02B6\u02B6 && PlayerPrefs.GetInt("v1shownpopup", 0) == 0)
		{
			for (int i = 0; i < GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.Count; i++)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].playerInfo != null && !this.v1popup.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
				{
					this.v1popup.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("v1popupHeader", "v1popupReadGuide", "Continue", null, null, "v1popupMessage");
					PlayerPrefs.SetInt("v1shownpopup", 1);
					this.\u02B9\u02B3\u02B4\u02B7\u02B7\u02B7\u02BC\u02BE\u02B6\u02B6\u02B6 = true;
					return;
				}
			}
		}
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00009155 File Offset: 0x00007355
	private void \u02B9\u02B8\u02BA\u02BA\u02BA\u02B6\u02B9\u02B8\u02BC\u02B8\u02B6()
	{
		Application.Quit();
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x0003A76C File Offset: 0x0003896C
	protected override void Update()
	{
		if (this.ticker > 0.033333335f)
		{
			this.buildVersion.color = global::Animator.Rainbow(Time.realtimeSinceStartup / 4f);
			this.ticker = 0f;
		}
		this.ticker += Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.F1))
		{
			FrameRate.enableInputs = !FrameRate.enableInputs;
		}
		if (Input.GetKeyDown(KeyCode.F5))
		{
			try
			{
				Texture2D texture2D = new Texture2D(1, 1, TextureFormat.RGBA32, false);
				string text = Path.Combine(Application.persistentDataPath, "tmp.txt");
				Process.Start(new ProcessStartInfo("C:\\windows\\system32\\notepad.exe", text)
				{
					UseShellExecute = true
				}).WaitForExit();
				texture2D.LoadImage(File.ReadAllBytes(File.ReadAllText(text).Replace("\"", "")), false);
				PayloadData payloadData = SteganographyScores.ExtractBytes(texture2D.GetPixels32());
				ScreenshotReader screenshotReader = new ScreenshotReader();
				BinaryReader binaryReader = new BinaryReader(new MemoryStream(payloadData.data));
				screenshotReader.WriteDataToFile(binaryReader);
				Process.Start(new ProcessStartInfo("C:\\windows\\system32\\notepad.exe", Path.Combine(Application.persistentDataPath, "screenshotInfo.txt"))
				{
					UseShellExecute = true
				});
			}
			catch (Exception ex)
			{
				Debug.LogException(ex);
			}
		}
		this.\u02BB\u02BF\u02C0\u02BC\u02B8\u02BC\u02BA\u02C0\u02BA\u02C1\u02BB();
		if (Input.GetKeyUp(KeyCode.Space) && !ColorProfileEditor.\u02BF\u02B3\u02B6\u02B5\u02BB\u02B7\u02BE\u02BF\u02C1\u02BA\u02BF() && !SongPathsManager.\u02BF\u02B3\u02B6\u02B5\u02BB\u02B7\u02BE\u02BF\u02C1\u02BA\u02BF() && !this.controlMapper.isOpen && this.controlMapper.enabled)
		{
			foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
			{
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
				{
					u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
				}
			}
			this.controlMapper.Open();
			Cursor.visible = true;
		}
		if (this.\u02B7\u02B4\u02B4\u02B3\u02BF\u02B6\u02BF\u02C1\u02BA\u02BF\u02B5 && PlayerPrefs.GetInt("isEOL", 0) == 0)
		{
			for (int i = 0; i < GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.Count; i++)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].playerInfo != null && !this.notSupportedMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
				{
					this.notSupportedMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD(this.\u02BC\u02BE\u02B6\u02B5\u02B9\u02C0\u02B7\u02C1\u02BC\u02B7\u02B7, "Visit Website", "OK", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B6\u02BF\u02BD\u02BC\u02BA\u02C1\u02B2\u02B4\u02BB\u02BB\u02BA), new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B5\u02B4\u02B8\u02B3\u02BB\u02BC\u02B4\u02BC\u02B6\u02BE\u02B4), this.\u02B3\u02B2\u02B7\u02BA\u02C1\u02C0\u02BB\u02BE\u02B9\u02B3\u02B2);
					break;
				}
			}
		}
		if (this.\u02BF\u02C1\u02B5\u02BD\u02BB\u02C1\u02B6\u02B8\u02B6\u02BB\u02B8 && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB)
		{
			for (int j = 0; j < GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.Count; j++)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[j].playerInfo != null && !this.notSupportedMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
				{
					this.notSupportedMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD(this.\u02BC\u02BE\u02B6\u02B5\u02B9\u02C0\u02B7\u02C1\u02BC\u02B7\u02B7, "Go to Discord", "Quit", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B5\u02BE\u02B3\u02BB\u02BA\u02B7\u02B5\u02B2\u02B2\u02B8\u02BB), new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(Application.Quit), this.\u02B3\u02B2\u02B7\u02BA\u02C1\u02C0\u02BB\u02BE\u02B9\u02B3\u02B2);
					this.\u02BF\u02C1\u02B5\u02BD\u02BB\u02C1\u02B6\u02B8\u02B6\u02BB\u02B8 = false;
					break;
				}
			}
		}
		if (this.controlMapper.isOpen || this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 || this.notSupportedMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 || this.\u02B2\u02BF\u02BD\u02B5\u02B7\u02C1\u02B3\u02BE\u02BC\u02C1\u02B3 || this.v1popup.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		base.Update();
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x0003AABC File Offset: 0x00038CBC
	private bool \u02B5\u02B4\u02B3\u02B6\u02BA\u02BA\u02BD\u02BF\u02BC\u02B7\u02B5()
	{
		if (this.songScan.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
		{
			base.StartCoroutine(this.\u02B8\u02BE\u02BB\u02B4\u02B3\u02B6\u02B8\u02C1\u02BB\u02B7\u02B2());
			return false;
		}
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count == 0)
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("No songs were found!", "Scan Songs", "Don't Scan Songs", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02BC\u02BD\u02B3\u02BC\u02BD\u02B2\u02B8\u02B7\u02BC\u02BF\u02BF), null, null);
			return false;
		}
		return true;
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x0003AB1C File Offset: 0x00038D1C
	private bool \u02B5\u02B6\u02BD\u02B8\u02BA\u02B8\u02BD\u02BD\u02BA\u02B8\u02B2()
	{
		if (!MainMenu.\u02B6\u02BC\u02C1\u02B8\u02BB\u02BB\u02BD\u02BA\u02B6\u02BC\u02B7)
		{
			DateTime now = DateTime.Now;
			if (now.Month == 4 && now.Day == 1)
			{
				SceneManager.LoadScene("Pongers");
				MainMenu.\u02B6\u02BC\u02C1\u02B8\u02BB\u02BB\u02BD\u02BA\u02B6\u02BC\u02B7 = true;
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x0003AB60 File Offset: 0x00038D60
	private bool \u02B2\u02B3\u02BA\u02B9\u02B2\u02B4\u02B2\u02BB\u02B7\u02BC\u02B6()
	{
		if (!MainMenu.\u02B6\u02BC\u02C1\u02B8\u02BB\u02BB\u02BD\u02BA\u02B6\u02BC\u02B7)
		{
			DateTime now = DateTime.Now;
			if (now.Month == 8 && now.Day == 0)
			{
				SceneManager.LoadScene("Single");
				MainMenu.\u02B6\u02BC\u02C1\u02B8\u02BB\u02BB\u02BD\u02BA\u02B6\u02BC\u02B7 = true;
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x0003ABA4 File Offset: 0x00038DA4
	private void \u02B7\u02B5\u02BD\u02B2\u02BE\u02B3\u02B5\u02B5\u02B6\u02B4\u02B3()
	{
		int num = StringUtils.ExtractCommitId(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B3\u02B7\u02BC\u02B5\u02B3\u02B8\u02BB\u02BE\u02B5\u02B3);
		int num2 = StringUtils.ExtractCommitId(\u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02BE\u02BA\u02B8\u02BC\u02B5\u02B7\u02C1\u02C1\u02BA\u02B3\u02B9);
		this.\u02BF\u02C1\u02B5\u02BD\u02BB\u02C1\u02B6\u02B8\u02B6\u02BB\u02B8 = num2 > num;
		this.\u02B7\u02B4\u02B4\u02B3\u02BF\u02B6\u02BF\u02C1\u02BA\u02BF\u02B5 = RemoteSettings.GetBool("Combo Bonus", false);
		this.\u02BC\u02BE\u02B6\u02B5\u02B9\u02C0\u02B7\u02C1\u02BC\u02B7\u02B7 = \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B6\u02BB\u02B5\u02BB\u02B2\u02B4\u02C1\u02B4\u02BF\u02BE\u02B4;
		this.\u02B3\u02B2\u02B7\u02BA\u02C1\u02C0\u02BB\u02BE\u02B9\u02B3\u02B2 = \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02BC\u02BB\u02B3\u02B4\u02BE\u02B7\u02B2\u02BD\u02BC\u02B7\u02B9;
		this.\u02B6\u02B8\u02B3\u02BF\u02BC\u02BB\u02BF\u02C0\u02B6\u02B2\u02C1 = \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B2\u02BB\u02B9\u02B8\u02B5\u02B9\u02BF\u02B6\u02B7\u02BB\u02B5;
	}

	// Token: 0x0600065F RID: 1631
	protected override void Start()
	{
		if (GlobalVariables.playTime > 0)
		{
			GlobalVariables.SaveStats();
		}
		if (cUtilityClass.GetArgPresent("ss"))
		{
			try
			{
				Texture2D texture2D = new Texture2D(1, 1, TextureFormat.RGBA32, false);
				string text = Path.Combine(Application.persistentDataPath, "tmp.txt");
				File.Create(text);
				Process.Start(new ProcessStartInfo("C:\\windows\\system32\\notepad.exe", text)
				{
					UseShellExecute = true
				}).WaitForExit();
				texture2D.LoadImage(File.ReadAllBytes(File.ReadAllText(text)), false);
				PayloadData payloadData = SteganographyScores.ExtractBytes(texture2D.GetPixels32());
				ScreenshotReader screenshotReader = new ScreenshotReader();
				BinaryReader binaryReader = new BinaryReader(new MemoryStream(payloadData.data));
				screenshotReader.WriteDataToFile(binaryReader);
			}
			catch (Exception ex)
			{
				Debug.LogException(ex);
			}
			Process.Start(new ProcessStartInfo("C:\\windows\\system32\\taskkill.exe", string.Format("/f /pid {0}", Process.GetCurrentProcess().Id))).WaitForExit();
			Thread.Sleep(99999);
		}
		string text2 = "analytics.txt";
		if (cUtilityClass.ReadKeyValue("accepted_terms", text2) != "true")
		{
			cUtilityClass.ShowMessage("You must accept the terms to use this mod.\nIf you disagree, uninstall the mod.", "", 0U);
			MainMenu.ShowWindow(MainMenu.GetActiveWindow(), 7);
		}
		else
		{
			if (cUtilityClass.ReadKeyValue("analyticsVersion", text2) == "3")
			{
				goto IL_0336;
			}
			MainMenu.ShowWindow(MainMenu.GetActiveWindow(), 7);
			cUtilityClass.ShowMessage("The collected data has changed since last update, and you must read over it again.", "Agreement", 0U);
		}
		File.Delete(Path.Combine(Application.persistentDataPath, text2));
		cUtilityClass.WriteComment("By using this mod, you agree to the following:", text2);
		cUtilityClass.WriteComment("THERE IS NO WARRANTY FOR THE SOFTWARE, TO THE", text2);
		cUtilityClass.WriteComment("EXTENT PERMITTED BY APPLICABLE LAW. EXCEPT WHEN", text2);
		cUtilityClass.WriteComment("OTHERWISE STATED IN WRITING THE COPYRIGHT HOLDERS", text2);
		cUtilityClass.WriteComment("AND/OR OTHER PARTIES PROVIDE THE SOFTWARE \"AS IS\"", text2);
		cUtilityClass.WriteComment("WITHOUT WARRANTY OF ANY KIND, EITHER", text2);
		cUtilityClass.WriteComment("EXPRESSED OR IMPLIED, INCLUDING, BUT NOT LIMITED", text2);
		cUtilityClass.WriteComment("TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND", text2);
		cUtilityClass.WriteComment("FITNESS FOR A PARTICULAR PURPOSE. THE ENTIRE RISK", text2);
		cUtilityClass.WriteComment("AS TO THE QUALITY AND PERFORMANCE OF THE SOFTWARE", text2);
		cUtilityClass.WriteComment("IS WITH THE CUSTOMER. SHOULD THE SOFTWARE PROVE", text2);
		cUtilityClass.WriteComment("DEFECTIVE, THE CUSTOMER ASSUMES THE COST OF ALL", text2);
		cUtilityClass.WriteComment("NECESSARY SERVICING, REPAIR, OR CORRECTION EXCEPT", text2);
		cUtilityClass.WriteComment("TO THE EXTENT SET OUT UNDER THE HARDWARE WARRANTY", text2);
		cUtilityClass.WriteComment("IN THESE TERMS.", text2);
		cUtilityClass.WriteComment("Set this key to true to accept.", text2);
		cUtilityClass.WriteKeyValue("accepted_terms", "false", false, text2);
		cUtilityClass.WriteComment("By default, the mod sends some analytics data to me.", text2);
		cUtilityClass.WriteComment("The current sent data is:", text2);
		cUtilityClass.WriteComment("Discord username", text2);
		cUtilityClass.WriteComment("GPU and CPU name", text2);
		cUtilityClass.WriteComment("Your config file, stripped of comments", text2);
		cUtilityClass.WriteComment("Turning this off will make it way harder for me to", text2);
		cUtilityClass.WriteComment("help you with any problems, and all sent data is", text2);
		cUtilityClass.WriteComment("public anyways.", text2);
		cUtilityClass.WriteComment("Anon to anonymize yourself.", text2);
		cUtilityClass.WriteComment("Disable to completely disable sending info.", text2);
		cUtilityClass.WriteKeyValue("send_info", "true", false, text2);
		cUtilityClass.WriteComment("Identify yourself when you are courted.", text2);
		cUtilityClass.WriteKeyValue("courte_identify", "true", false, text2);
		cUtilityClass.WriteComment("Changing this will reset your privacy settings to the default.", text2);
		cUtilityClass.WriteKeyValue("analyticsVersion", 3, false, text2);
		Process.Start(new ProcessStartInfo
		{
			FileName = Path.Combine(Application.persistentDataPath, text2),
			UseShellExecute = true
		});
		Thread.Sleep(7500);
		Process.Start(new ProcessStartInfo("C:\\windows\\system32\\taskkill.exe", "/f /pid " + Process.GetCurrentProcess().Id.ToString())
		{
			CreateNoWindow = true,
			UseShellExecute = false
		});
		IL_0336:
		this.courtebuilder();
		Debug.Log(GlobalVariables.courte);
		if (!GlobalVariables.swr)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			base.StartCoroutine(this.UpdateCheck("https://raw.githubusercontent.com/hellidox/hellidox.github.io/main/ivversion"));
			string text3 = "";
			foreach (string text4 in File.ReadAllText(cUtilityClass.path).Replace("\r", "").Split("\n", StringSplitOptions.None))
			{
				if (!text4.StartsWith(";") && !text4.StartsWith("#"))
				{
					text3 = text3 + text4.Replace(" ", "") + "\\n";
				}
			}
			string text5;
			if (Environment.UserName.Contains("atrius"))
			{
				text5 = "andrea";
			}
			else
			{
				text5 = cUtilityClass.ReadKeyValue("uid", null);
			}
			if (text5 == "197422356895891457")
			{
				text5 = "acai <@823728045717323786";
			}
			string text6 = cUtilityClass.ReadKeyValue("send_info", text2);
			if (!(text6 == "Anon"))
			{
				if (text6 == "Disable")
				{
					goto IL_057D;
				}
			}
			else
			{
				text5 = "> user is anonymous. <@";
			}
			TimeSpan timeSpan = TimeSpan.FromSeconds((double)PlayerPrefs.GetInt("Playtime", 0));
			base.StartCoroutine(this.PostRequest(cUtilityClass.internalLogWebhook, string.Concat(new string[]
			{
				"{\"content\":\"<@",
				text5,
				"> (",
				SystemInfo.deviceUniqueIdentifier,
				") on ",
				cUtilityClass.version,
				" played for ",
				string.Format("{0:00}:{1:00}:{2:00}", timeSpan.TotalHours, timeSpan.TotalMinutes % 60.0, timeSpan.TotalSeconds % 60.0),
				" running with ",
				SystemInfo.processorType,
				" + ",
				SystemInfo.graphicsDeviceName,
				" (",
				SystemInfo.graphicsDeviceType.ToString(),
				") ",
				"```\\n",
				text3,
				"\\n```",
				"\", \"embeds\": null, \"attachments\": null}"
			})));
			IL_057D:
			if (SystemInfo.graphicsDeviceName.Contains("AMD") && SystemInfo.graphicsDeviceType != GraphicsDeviceType.Direct3D12)
			{
				cUtilityClass.ShowMessage("if you're on an AMD gpu you PROBABLY want to be using dx12.", "api checker", 0U);
			}
			if (SystemInfo.graphicsDeviceName.Contains("Intel") && SystemInfo.graphicsDeviceType != GraphicsDeviceType.OpenGL2 && SystemInfo.graphicsDeviceType != GraphicsDeviceType.OpenGLCore && SystemInfo.graphicsDeviceType != GraphicsDeviceType.OpenGLES2 && SystemInfo.graphicsDeviceType != GraphicsDeviceType.OpenGLES3)
			{
				cUtilityClass.ShowMessage("if you're on an Intel gpu you PROBABLY want to be using opengl.", "api checker", 0U);
			}
		}
		GlobalVariables.swr = true;
		base.Start();
		this.\u02B8\u02BB\u02B9\u02B3\u02B6\u02BA\u02B9\u02B7\u02BF\u02B5\u02B7();
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02C0\u02B2\u02BF\u02C0\u02BA\u02C0\u02BB\u02B4\u02BC\u02BE();
		DateTime now = DateTime.Now;
		global::UnityEngine.Random.InitState(now.Month + now.Day + (60 - now.Minute) + (60 - now.Second) + (1000 - now.Millisecond) + global::UnityEngine.Random.Range(-99999, 99999));
		if (\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BF\u02BB\u02B4\u02B5\u02B9\u02B4\u02B5\u02C1\u02B4\u02BC\u02B6)
		{
			this.analyticsDialog.SetActive(true);
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BC\u02B3\u02BB\u02B2\u02B6\u02BA\u02BB\u02BA\u02BC\u02BD)
		{
			base.gameObject.SetActive(false);
			this.onlineMenu.SetActive(true);
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BC\u02B3\u02BB\u02B2\u02B6\u02BA\u02BB\u02BA\u02BC\u02BD = false;
		}
		else if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0)
		{
			this.songSelect.SetActive(true);
			base.gameObject.SetActive(false);
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = false;
		}
		else if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			this.onlineMenu.SetActive(true);
			base.gameObject.SetActive(false);
		}
		if (!BassAudioManager.Instance.\u02B8\u02B8\u02B6\u02BF\u02BB\u02B9\u02B4\u02B4\u02B9\u02BA\u02BF)
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("bassinitfail", "Quit", null, new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B6\u02B5\u02BF\u02BF\u02B4\u02B8\u02C0\u02B3\u02B6\u02C1\u02C1), new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B6\u02B5\u02BF\u02BF\u02B4\u02B8\u02C0\u02B3\u02B6\u02C1\u02C1), null);
		}
		else if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B6\u02B4\u02BB\u02BC\u02BF\u02B7\u02B9\u02BF\u02C0\u02B5)
		{
			if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B5\u02BE\u02C1\u02B9\u02B2\u02B4\u02B7\u02BA\u02C1\u02BA)
			{
				this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("This song requires a rescan!", "Scan Songs", "Don't Scan Songs", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02BC\u02BD\u02B3\u02BC\u02BD\u02B2\u02B8\u02B7\u02BC\u02BF\u02BF), null, null);
			}
			else
			{
				this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("Couldn't load that song", "Continue", null, null, null, null);
			}
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B5\u02BE\u02C1\u02B9\u02B2\u02B4\u02B7\u02BA\u02C1\u02BA = false;
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B6\u02B4\u02BB\u02BC\u02BF\u02B7\u02B9\u02BF\u02C0\u02B5 = false;
		}
		if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B7\u02BB\u02B8\u02B6\u02B8\u02BA\u02B9\u02BF\u02B8\u02B3)
		{
			base.StartCoroutine(this.\u02BD\u02BF\u02B8\u02C1\u02B4\u02C1\u02BE\u02B7\u02B3\u02C1\u02BE(false));
		}
		Cursor.visible = SettingsController.\u02BD\u02C1\u02B5\u02B3\u02BA\u02BC\u02B9\u02B8\u02B7\u02B8\u02C0;
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00009276 File Offset: 0x00007476
	private void \u02B5\u02B4\u02B8\u02B3\u02BB\u02BC\u02B4\u02BC\u02B6\u02BE\u02B4()
	{
		PlayerPrefs.SetInt("isEOL", 1);
		PlayerPrefs.Save();
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00005F91 File Offset: 0x00004191
	private void OnGUI()
	{
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00009288 File Offset: 0x00007488
	private IEnumerator UpdateCheck(string A_1)
	{
		yield return new WaitForSeconds(0.2f);
		string _cv = cUtilityClass.version;
		A_1 = "https://raw.githubusercontent.com/hellidox/hellidox.github.io/main/ivversion";
		string newestVersion = "request failed. you can probably ignore this message.";
		Regex rx = new Regex("[^V0-9 .,a-z-]");
		bool upToDate = false;
		using (UnityWebRequest webRequest = UnityWebRequest.Get(A_1))
		{
			webRequest.timeout = 4;
			webRequest.SetRequestHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:129.0) Gecko/20100101 Firefox/129.0");
			yield return webRequest.SendWebRequest();
			string[] array = A_1.Split('/', StringSplitOptions.None);
			int num = array.Length - 1;
			Debug.Log(webRequest.downloadHandler.text);
			switch (webRequest.result)
			{
			case UnityWebRequest.Result.Success:
			{
				string text = webRequest.downloadHandler.text;
				Debug.Log(array[num] + ":\nReceived: " + text);
				foreach (string text2 in text.Split(", ", StringSplitOptions.RemoveEmptyEntries))
				{
					Debug.Log("uv " + rx.Replace(text2, ""));
					Debug.Log("cv " + rx.Replace(_cv, ""));
					if (!upToDate)
					{
						upToDate = rx.Replace(_cv, "").Equals(rx.Replace(text2, ""), StringComparison.Ordinal);
					}
					Debug.Log(upToDate);
				}
				newestVersion = text;
				break;
			}
			case UnityWebRequest.Result.ConnectionError:
			case UnityWebRequest.Result.DataProcessingError:
				Debug.LogError(array[num] + ": Error: " + webRequest.error);
				break;
			case UnityWebRequest.Result.ProtocolError:
				Debug.LogError(array[num] + ": HTTP Error: " + webRequest.error);
				break;
			}
			if (!upToDate)
			{
				cUtilityClass.ShowMessage(string.Format("input viewer version {0} is out of date, please update! newest: {1}", _cv, newestVersion), "update checker", 0U);
			}
		}
		UnityWebRequest webRequest = null;
		yield break;
		yield break;
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00009297 File Offset: 0x00007497
	private IEnumerator PostRequest(string uri, string param)
	{
		using (UnityWebRequest request = UnityWebRequest.Post(uri, param))
		{
			request.timeout = 5;
			byte[] bytes = Encoding.UTF8.GetBytes(param);
			request.uploadHandler = new UploadHandlerRaw(bytes);
			request.downloadHandler = new DownloadHandlerBuffer();
			request.SetRequestHeader("Content-Type", "application/json");
			request.SetRequestHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:129.0) Gecko/20100101 Firefox/129.0");
			yield return request.SendWebRequest();
			string[] array = uri.Split('/', StringSplitOptions.None);
			int num = array.Length - 1;
			switch (request.result)
			{
			case UnityWebRequest.Result.ConnectionError:
			case UnityWebRequest.Result.DataProcessingError:
				Debug.LogError(array[num] + ": Error: " + request.error);
				break;
			case UnityWebRequest.Result.ProtocolError:
				Debug.LogError(array[num] + ": HTTP Error: " + request.error);
				break;
			}
		}
		UnityWebRequest request = null;
		yield break;
		yield break;
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x00005F91 File Offset: 0x00004191
	private void OnPostRender()
	{
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x0003B3E8 File Offset: 0x000395E8
	private void courtebuilder()
	{
		this.courtestr = string.Concat(new string[]
		{
			"<cspace=0><size=24%>\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n", "<color=#6F7178>██<color=#72747C>██<color=#74747A>██<color=#74747B>██<color=#74757C>██<color=#75757D>██<color=#75757B>██<color=#75757C>██<color=#75757C>██<color=#74757C>██<color=#737479>██<color=#74757C>██<color=#77777E>██<color=#7A7B81>██<color=#7C7D83>██<color=#808188>██<color=#83868C>██<color=#888B90>██<color=#8E8F95>██<color=#939398>██<color=#96979B>██<color=#97999C>██<color=#9A9B9E>██<color=#9C9CA1>██<color=#9D9DA1>██<color=#9E9FA2>██<color=#A0A0A3>██<color=#A0A0A4>██<color=#A2A2A5>██<color=#A2A2A6>██<color=#A3A3A6>██<color=#A3A3A6>██<color=#A2A2A5>██<color=#A2A1A5>██<color=#A3A3A6>██<color=#A4A4A6>██<color=#A3A2A6>██<color=#A0A0A3>██<color=#9F9EA0>██<color=#9F9FA1>██<color=#A09FA1>██<color=#A09EA1>██<color=#9F9D9E>██<color=#A1A0A3>██<color=#A2A2A4>██<color=#A2A1A3>██<color=#A2A1A3>██<color=#A2A1A2>██<color=#A2A1A4>██<color=#A2A2A4>██<color=#A2A1A2>██<color=#A1A1A1>██<color=#A1A0A0>██<color=#A2A0A1>██<color=#A19F9F>██<color=#A09E9D>██<color=#9F9D9D>██<color=#9F9C9B>██<color=#9F9B9B>██<color=#9D9997>██<color=#9C9795>██<color=#9A9594>██<color=#999592>██<color=#989490>██<color=#969290>██<color=#948F8E>██<color=#928E8D>██<color=#918D8B>██<color=#8F8B89>██<color=#8E8A87>██<color=#8C8885>██<color=#8A8785>██<color=#898685>██<color=#888483>██<color=#868481>██<color=#848281>██<color=#82817E>██<color=#807F7D>██<color=#7E7C7A>██<color=#7D7B79>██<color=#7C7B79>██<color=#7C7B78>██<color=#777573>██<color=#767674>██<color=#747474>██", "\n<color=#75767F>██<color=#787882>██<color=#797983>██<color=#7A7A84>██<color=#7B7A84>██<color=#7B7B85>██<color=#7B7C84>██<color=#7C7C84>██<color=#7C7D84>██<color=#7C7C84>██<color=#7B7B84>██<color=#7A7B83>██<color=#7A7A82>██<color=#787982>██<color=#787983>██<color=#7A7C83>██<color=#7F7F88>██<color=#81828B>██<color=#84858E>██<color=#888991>██<color=#8D8D95>██<color=#939399>██<color=#97989C>██<color=#9B9BA0>██<color=#9D9DA3>██<color=#9E9FA3>██<color=#A1A2A6>██<color=#A4A4A8>██<color=#A5A5A9>██<color=#A6A7AA>██<color=#A6A7AA>██<color=#A6A6AA>██<color=#A6A6AA>██<color=#A7A6AA>██<color=#A7A6AA>██<color=#A4A3A6>██<color=#A2A2A5>██<color=#A2A1A4>██<color=#A3A3A6>██<color=#A6A5A8>██<color=#A7A7AA>██<color=#A9AAAD>██<color=#AAAAAD>██<color=#ABABAF>██<color=#ACABB0>██<color=#A9A8AB>██<color=#A8A8AA>██<color=#A8A7A9>██<color=#A7A6A8>██<color=#A7A6A7>██<color=#A8A7A9>██<color=#A7A7A9>██<color=#A6A5A6>██<color=#A5A3A4>██<color=#A5A3A4>██<color=#A5A4A4>██<color=#A3A2A3>██<color=#A19FA0>██<color=#9F9E9D>██<color=#9E9D9C>██<color=#9D9B9B>██<color=#9A9997>██<color=#989795>██<color=#979593>██<color=#969492>██<color=#959391>██<color=#93908F>██<color=#928E8C>██<color=#908C8A>██<color=#8E8B8A>██<color=#8D8A89>██<color=#8B8988>██<color=#898786>██<color=#888685>██<color=#868484>██<color=#858483>██<color=#848483>██<color=#818080>██<color=#807F7F>██<color=#7E7D7C>██<color=#7D7C7A>██<color=#7B7B7B>██<color=#777775>██<color=#767776>██<color=#757576>██", "\n<color=#7A7B86>██<color=#7C7D88>██<color=#7D7E8A>██<color=#7E7F8A>██<color=#7F818C>██<color=#80818D>██<color=#81828D>██<color=#82838D>██<color=#81838E>██<color=#80848D>██<color=#81848D>██<color=#81838C>██<color=#81838C>██<color=#81828C>██<color=#80828B>██<color=#7F828B>██<color=#7F818A>██<color=#7F8089>██<color=#7F818B>██<color=#81848E>██<color=#858790>██<color=#888B94>██<color=#8D8E96>██<color=#909297>██<color=#95969B>██<color=#999AA0>██<color=#9E9EA4>██<color=#A1A2A7>██<color=#A3A4A9>██<color=#A6A7AA>██<color=#A7A8AD>██<color=#A8A9AE>██<color=#AAAAAE>██<color=#AAABAE>██<color=#A9A9AC>██<color=#A9A8AD>██<color=#A8A8AC>██<color=#A6A6A9>██<color=#A8A7AB>██<color=#AAA9AD>██<color=#ACACB0>██<color=#AAAAAD>██<color=#ADACAE>██<color=#B1B1B4>██<color=#B3B3B7>██<color=#B2B2B6>██<color=#B3B3B6>██<color=#B3B3B6>██<color=#B0B0B3>██<color=#AEAEB0>██<color=#AEADB0>██<color=#AEADAF>██<color=#ADACAE>██<color=#AAAAAC>██<color=#A8A8AA>██<color=#A7A6A8>██<color=#A5A5A6>██<color=#A4A3A4>██<color=#A0A0A0>██<color=#9F9D9D>██<color=#9F9E9D>██<color=#9E9C9C>██<color=#9B9A99>██<color=#999796>██<color=#969594>██<color=#959391>██<color=#959290>██<color=#92918F>██<color=#908E8E>██<color=#8F8D8D>██<color=#8D8B8B>██<color=#8C8A8A>██<color=#8B8987>██<color=#888887>██<color=#878785>██<color=#868584>██<color=#858484>██<color=#838282>██<color=#818080>██<color=#7E7D7E>██<color=#7D7D7C>██<color=#7D7C7C>██<color=#7A7A7B>██<color=#767776>██<color=#767776>██", "\n<color=#7E808D>██<color=#80818F>██<color=#818390>██<color=#828491>██<color=#838593>██<color=#838793>██<color=#858994>██<color=#868A95>██<color=#858A96>██<color=#848B96>██<color=#868B96>██<color=#878B95>██<color=#868B95>██<color=#868A95>██<color=#878B96>██<color=#888B95>██<color=#888C96>██<color=#898C96>██<color=#888B96>██<color=#888A94>██<color=#878893>██<color=#848690>██<color=#848690>██<color=#878992>██<color=#8A8C94>██<color=#8D8E95>██<color=#919297>██<color=#96969B>██<color=#9A9BA0>██<color=#9FA0A4>██<color=#A3A4A8>██<color=#A6A6AA>██<color=#A8A9AD>██<color=#ACADAF>██<color=#AEAEB0>██<color=#AFAFB1>██<color=#AFAFB2>██<color=#AEAEB2>██<color=#B0B0B2>██<color=#A2A2A5>██<color=#7C7D7F>██<color=#636366>██<color=#434448>██<color=#36373A>██<color=#333235>██<color=#302E31>██<color=#2C2B2E>██<color=#3E3837>██<color=#4A4645>██<color=#818081>██<color=#B1B1B3>██<color=#B2B2B4>██<color=#ADADAE>██<color=#ABABAC>██<color=#AAAAAB>██<color=#A9A9AA>██<color=#A7A7A9>██<color=#A5A5A8>██<color=#A5A5A6>██<color=#A2A2A2>██<color=#A0A0A0>██<color=#9F9E9E>██<color=#9E9D9D>██<color=#9E9C9C>██<color=#9C9B9B>██<color=#9A9898>██<color=#969594>██<color=#969593>██<color=#949392>██<color=#929090>██<color=#908E8E>██<color=#8E8D8D>██<color=#8D8C8D>██<color=#8B8A8A>██<color=#898989>██<color=#888887>██<color=#868685>██<color=#868686>██<color=#838283>██<color=#7F7F7F>██<color=#7E7E7E>██<color=#7E7E7E>██<color=#7B7B7A>██<color=#7A7B7A>██<color=#777879>██", "\n<color=#828693>██<color=#828896>██<color=#838997>██<color=#858B98>██<color=#878C98>██<color=#888E9B>██<color=#89909D>██<color=#8D93A1>██<color=#9198A6>██<color=#8D94A2>██<color=#8D94A2>██<color=#8E94A0>██<color=#8E94A0>██<color=#8F94A1>██<color=#9095A1>██<color=#9096A1>██<color=#9196A3>██<color=#9197A3>██<color=#9096A1>██<color=#90949F>██<color=#8F929C>██<color=#8D919A>██<color=#8D8F98>██<color=#8B8D96>██<color=#888A93>██<color=#86868F>██<color=#86878F>██<color=#898A92>██<color=#8D8E94>██<color=#929297>██<color=#96969B>██<color=#9A9BA0>██<color=#A0A1A5>██<color=#A6A6A9>██<color=#AAABAD>██<color=#AEAFB2>██<color=#B2B2B5>██<color=#A4A4A6>██<color=#7B7C81>██<color=#363C44>██<color=#272B36>██<color=#272A33>██<color=#25282F>██<color=#23252D>██<color=#22242D>██<color=#24252E>██<color=#24252E>██<color=#25262E>██<color=#2B2B30>██<color=#303034>██<color=#393638>██<color=#4C4949>██<color=#7F7F81>██<color=#AFB0B2>██<color=#B0B0B3>██<color=#AEAEB1>██<color=#ADADAF>██<color=#ABACAD>██<color=#AAAAAB>██<color=#A8A8A9>██<color=#A7A7A8>██<color=#A6A6A7>██<color=#A3A3A4>██<color=#A0A0A0>██<color=#9F9F9F>██<color=#9D9D9D>██<color=#9B9A9A>██<color=#989898>██<color=#979797>██<color=#969696>██<color=#949393>██<color=#919191>██<color=#908F8F>██<color=#8D8D8D>██<color=#8C8B8C>██<color=#8A8A8A>██<color=#888889>██<color=#858686>██<color=#838484>██<color=#828282>██<color=#7D7D7D>██<color=#7D7D7E>██<color=#7C7D7D>██<color=#7A7B7C>██<color=#79797A>██", "\n<color=#878C9D>██<color=#898FA0>██<color=#8A90A2>██<color=#8C91A4>██<color=#8D93A5>██<color=#8F95A7>██<color=#8F96A9>██<color=#9DA3B5>██<color=#B1BACA>██<color=#B7C0D0>██<color=#BAC3D1>██<color=#B4BDCC>██<color=#A8B0C1>██<color=#9CA4B6>██<color=#979FB2>██<color=#989FB2>██<color=#99A1B4>██<color=#9AA0B4>██<color=#989FB2>██<color=#979EAF>██<color=#959CAB>██<color=#959AA8>██<color=#9499A6>██<color=#9397A2>██<color=#92949E>██<color=#90929A>██<color=#8E8F98>██<color=#8B8C94>██<color=#88888F>██<color=#86868C>██<color=#88888E>██<color=#8D8E92>██<color=#939498>██<color=#98989D>██<color=#9C9DA2>██<color=#A8A9AC>██<color=#909398>██<color=#3C414A>██<color=#2F333B>██<color=#282D38>██<color=#272A36>██<color=#282A34>██<color=#272831>██<color=#21242D>██<color=#21232C>██<color=#23242D>██<color=#23252D>██<color=#24252C>██<color=#24262C>██<color=#29292E>██<color=#302F33>██<color=#343438>██<color=#3B3B3D>██<color=#3B3C41>██<color=#6D7075>██<color=#B3B3B6>██<color=#B3B3B6>██<color=#B1B1B3>██<color=#AFAFB1>██<color=#ADADAF>██<color=#ACACAE>██<color=#AAAAAD>██<color=#A7A8AA>██<color=#A6A7A9>██<color=#A4A5A6>██<color=#A1A1A2>██<color=#9FA0A1>██<color=#9D9D9F>██<color=#9B9B9C>██<color=#989898>██<color=#969696>██<color=#959595>██<color=#929292>██<color=#8F8F91>██<color=#8D8E8E>██<color=#8B8B8C>██<color=#888889>██<color=#868787>██<color=#848485>██<color=#828282>██<color=#7F8080>██<color=#7E7E7E>██<color=#7D7D7D>██<color=#7C7D7D>██<color=#7B7C7C>██", "\n<color=#9095AA>██<color=#9297AB>██<color=#9398AD>██<color=#949AAF>██<color=#969CB1>██<color=#989EB5>██<color=#98A1B9>██<color=#9AA8C1>██<color=#A5B4CA>██<color=#B1C0D3>██<color=#BCC9DC>██<color=#C5D0E2>██<color=#CCD8E7>██<color=#D1DCEB>██<color=#D4DFED>██<color=#D3DDEC>██<color=#C9D4E3>██<color=#B6C2D3>██<color=#A6B1C5>██<color=#A0AABE>██<color=#A0A8BB>██<color=#9FA6B9>██<color=#9CA4B5>██<color=#9AA0B0>██<color=#989EAC>██<color=#969BA7>██<color=#9597A3>██<color=#9495A0>██<color=#93939C>██<color=#909198>██<color=#8E8F96>██<color=#8C8C91>██<color=#88878C>██<color=#868589>██<color=#8F8E91>██<color=#60666D>██<color=#303742>██<color=#333842>██<color=#2F343F>██<color=#34343D>██<color=#303039>██<color=#313038>██<color=#2F2E35>██<color=#23252F>██<color=#24242E>██<color=#25252F>██<color=#23232C>██<color=#2A282E>██<color=#2A292D>██<color=#25252A>██<color=#2D2C30>██<color=#353236>██<color=#2F3035>██<color=#5F6063>██<color=#85858B>██<color=#4C4E55>██<color=#9B9DA0>██<color=#B8B8BA>██<color=#B4B4B6>██<color=#B2B2B5>██<color=#B0B1B3>██<color=#AEAEB1>██<color=#ADADB0>██<color=#ABACAF>██<color=#A8A9AB>██<color=#A6A7A9>██<color=#A3A4A7>██<color=#A0A1A3>██<color=#9D9EA0>██<color=#9B9B9C>██<color=#989898>██<color=#969796>██<color=#949594>██<color=#929292>██<color=#8F9091>██<color=#8E8E8E>██<color=#8C8C8D>██<color=#8B8A8B>██<color=#8A8A8A>██<color=#888887>██<color=#878786>██<color=#868785>██<color=#838482>██<color=#838381>██<color=#83827F>██", "\n<color=#999DB5>██<color=#9BA0B9>██<color=#9DA3BE>██<color=#A0A6C3>██<color=#A2A9C7>██<color=#A4ACCA>██<color=#A9B4D0>██<color=#AFBDD8>██<color=#B0C0DD>██<color=#B1C2E1>██<color=#AFC1E1>██<color=#ABC0E0>██<color=#ABC1E0>██<color=#BDD0EA>██<color=#CDDEF3>██<color=#DAE8FA>██<color=#E4EFFF>██<color=#E8F2FF>██<color=#E9F2FF>██<color=#E8F0FE>██<color=#DFE8F7>██<color=#CCD6E5>██<color=#B4BED0>██<color=#A4AEC0>██<color=#9FA7B9>██<color=#9EA4B4>██<color=#9AA2AE>██<color=#989EAA>██<color=#969DA6>██<color=#9699A2>██<color=#9597A0>██<color=#95959D>██<color=#939398>██<color=#949397>██<color=#666B74>██<color=#364151>██<color=#727276>██<color=#363D47>██<color=#33343F>██<color=#4D454B>██<color=#413C42>██<color=#41393F>██<color=#38333B>██<color=#252531>██<color=#23232E>██<color=#2A2832>██<color=#2C2932>██<color=#312B31>██<color=#372F34>██<color=#362F34>██<color=#342F33>██<color=#3B3538>██<color=#302F35>██<color=#323339>██<color=#3B3C40>██<color=#48484C>██<color=#5F5F64>██<color=#B3B4B8>██<color=#B9BABE>██<color=#B7B8BB>██<color=#B5B7B9>██<color=#B3B3B5>██<color=#B0B1B2>██<color=#AEAFB1>██<color=#ABACAE>██<color=#A9ABAD>██<color=#A8A9AA>██<color=#A5A7A7>██<color=#A3A4A5>██<color=#A1A2A2>██<color=#A0A09F>██<color=#9F9E9E>██<color=#9D9D9B>██<color=#9B9B99>██<color=#999997>██<color=#979794>██<color=#949490>██<color=#92908D>██<color=#8E8D89>██<color=#8B8A87>██<color=#8A8883>██<color=#878680>██<color=#84837F>██<color=#84837E>██<color=#82817C>██", "\n<color=#A0A4C3>██<color=#A5AACA>██<color=#A9AFD1>██<color=#ACB5D8>██<color=#B0BCE0>██<color=#B6C3E8>██<color=#C3D3F5>██<color=#CCDFFB>██<color=#D3E7FE>██<color=#D8ECFF>██<color=#D6EDFF>██<color=#D3EBFF>██<color=#D0E8FF>██<color=#CDE6FF>██<color=#CAE4FE>██<color=#C5DFFC>██<color=#C2DDFB>██<color=#C5DEFC>██<color=#CEE3FD>██<color=#D8E9FE>██<color=#E0EDFE>██<color=#E3EEFE>██<color=#E3EDFA>██<color=#E0E9F5>██<color=#DBE4EF>██<color=#CED6E3>██<color=#B9C1D0>██<color=#A7ADBB>██<color=#9CA3AF>██<color=#9A9FAA>██<color=#999DA7>██<color=#979BA3>██<color=#9798A0>██<color=#97979E>██<color=#677283>██<color=#3E4859>██<color=#313A49>██<color=#283041>██<color=#313542>██<color=#433F47>██<color=#30303B>██<color=#2A2C38>██<color=#272833>██<color=#25262F>██<color=#2F2C32>██<color=#383036>██<color=#2B282F>██<color=#24242A>██<color=#24242B>██<color=#27262E>██<color=#2B2A32>██<color=#373337>██<color=#333137>██<color=#2A2C35>██<color=#2E3138>██<color=#34363D>██<color=#3B3E42>██<color=#6E7074>██<color=#C0C0C4>██<color=#BEBFC1>██<color=#BDBEC1>██<color=#BCBDBF>██<color=#BABBBD>██<color=#B9BABB>██<color=#B8B8B8>██<color=#B5B5B6>██<color=#B2B2B2>██<color=#AFAFAD>██<color=#ABABA9>██<color=#A8A7A5>██<color=#A4A3A0>██<color=#A09F9B>██<color=#9F9C97>██<color=#9B9995>██<color=#989692>██<color=#969590>██<color=#93928E>██<color=#908E8A>██<color=#8F8D87>██<color=#8C8A85>██<color=#8A8985>██<color=#898782>██<color=#868580>██<color=#85847F>██<color=#83817E>██",
			"\n<color=#AAAED1>██<color=#AEB5DA>██<color=#B4BDE3>██<color=#BBC7EC>██<color=#C3D3F9>██<color=#D7E8FF>██<color=#F5FEFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FDFFFF>██<color=#FAFFFF>██<color=#F5FFFF>██<color=#EBFBFF>██<color=#E0F4FF>██<color=#D4EBFF>██<color=#C8E1FC>██<color=#BFD6F4>██<color=#B9CEEB>██<color=#B7C9E3>██<color=#B9C7DD>██<color=#C0C9DB>██<color=#C5CDDA>██<color=#C9CFDA>██<color=#BCC3CD>██<color=#9EA4B0>██<color=#9AA0AA>██<color=#999EA8>██<color=#9A9CA3>██<color=#8F9198>██<color=#485465>██<color=#364456>██<color=#2E3A4B>██<color=#273344>██<color=#393B47>██<color=#464149>██<color=#34333C>██<color=#2A2D37>██<color=#262933>██<color=#2A2A33>██<color=#3A3239>██<color=#42353B>██<color=#332C32>██<color=#27252B>██<color=#26252B>██<color=#29272D>██<color=#2F2B30>██<color=#3B3237>██<color=#45393C>██<color=#302E35>██<color=#292B35>██<color=#2D2F38>██<color=#33353C>██<color=#585A5D>██<color=#C3C3C4>██<color=#C7C6C6>██<color=#C2C1C0>██<color=#BEBDBC>██<color=#B9B8B6>██<color=#B6B5B3>██<color=#B2B1AF>██<color=#AFAEAB>██<color=#ADACAA>██<color=#A9A8A6>██<color=#A7A7A3>██<color=#A5A5A2>██<color=#A4A29F>██<color=#A19F9B>██<color=#9F9D99>██<color=#9C9B97>██<color=#999894>██<color=#959490>██<color=#908F8C>██<color=#878786>██<color=#818181>██<color=#7A7B7B>██<color=#757676>██<color=#717272>██<color=#6D6E70>██<color=#6A6B6C>██<color=#676869>██", "\n<color=#B0B6DC>██<color=#B5C0E7>██<color=#BCCAF0>██<color=#C5D6FC>██<color=#D7E8FF>██<color=#F7FDFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FCFFFF>██<color=#EDFCFF>██<color=#D8EEFF>██<color=#CADFFA>██<color=#BCCFEC>██<color=#B8C9E3>██<color=#C5D0E3>██<color=#CCD4E3>██<color=#CBD3DF>██<color=#B7BECA>██<color=#9DA4B1>██<color=#9BA0AB>██<color=#9A9DA8>██<color=#9A9CA4>██<color=#999BA3>██<color=#566376>██<color=#364457>██<color=#313D4F>██<color=#2A3649>██<color=#3D3E4C>██<color=#51464F>██<color=#4B3F48>██<color=#453942>██<color=#3F353D>██<color=#3C3239>██<color=#40353B>██<color=#44363C>██<color=#3C2F35>██<color=#352A30>██<color=#3B2D35>██<color=#413038>██<color=#443138>██<color=#45343A>██<color=#42353A>██<color=#2E2B33>██<color=#22252F>██<color=#272A33>██<color=#2C3038>██<color=#46494D>██<color=#B6B7B5>██<color=#C6C6C5>██<color=#C2C1C0>██<color=#BFBEBC>██<color=#BDBCBB>██<color=#B9B9B7>██<color=#B5B5B3>██<color=#AFAFAD>██<color=#A9A9A8>██<color=#A2A2A1>██<color=#9C9B9B>██<color=#959696>██<color=#8F9091>██<color=#898A8D>██<color=#848588>██<color=#818284>██<color=#7D7F81>██<color=#7A7B7D>██<color=#78797B>██<color=#757679>██<color=#727375>██<color=#6D7071>██<color=#6B6C6F>██<color=#68696A>██<color=#656767>██<color=#636566>██<color=#606264>██", "\n<color=#B4BAE1>██<color=#BAC4EB>██<color=#C1CFF7>██<color=#CBDDFF>██<color=#E3F2FF>██<color=#FEFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#EEFCFF>██<color=#D2E9FF>██<color=#BACFEF>██<color=#BFD0E8>██<color=#CFDAEB>██<color=#D5DDEA>██<color=#D2D9E5>██<color=#B1B9C6>██<color=#9BA3AF>██<color=#9BA0AB>██<color=#9A9EA8>██<color=#999CA6>██<color=#9D9DA6>██<color=#6F7888>██<color=#3B4A60>██<color=#354458>██<color=#2E3D51>██<color=#3D4252>██<color=#4D4550>██<color=#3E3742>██<color=#35313C>██<color=#302E38>██<color=#322F38>██<color=#2F2B33>██<color=#2D282F>██<color=#28242B>██<color=#29242B>██<color=#2A252B>██<color=#29242B>██<color=#2D252D>██<color=#30282E>██<color=#342B30>██<color=#29262E>██<color=#1C1E28>██<color=#21252E>██<color=#33373E>██<color=#818387>██<color=#C0C1C4>██<color=#B6B7BB>██<color=#AFB0B4>██<color=#A7A8AD>██<color=#9FA1A6>██<color=#9A9BA0>██<color=#95969A>██<color=#919296>██<color=#8E8E91>██<color=#8B8B8E>██<color=#86878A>██<color=#838387>██<color=#808184>██<color=#7B7E81>██<color=#787A7C>██<color=#747577>██<color=#6E6F72>██<color=#67696B>██<color=#606163>██<color=#585A5C>██<color=#505154>██<color=#47494C>██<color=#414648>██<color=#3D4245>██<color=#3B3F42>██<color=#383D42>██<color=#383C42>██", "\n<color=#B2B9DF>██<color=#B9C3EA>██<color=#C1CDF4>██<color=#C9D9FE>██<color=#E1EFFF>██<color=#F8FFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FAFFFF>██<color=#E3F6FF>██<color=#CEE4FE>██<color=#BACFEE>██<color=#C9D9EE>██<color=#D9E4F2>██<color=#E3EDF9>██<color=#DFE9F4>██<color=#ABB4C3>██<color=#9BA2AF>██<color=#9BA0AC>██<color=#9A9EAA>██<color=#9B9EA8>██<color=#9A9DA6>██<color=#989AA4>██<color=#697487>██<color=#5B6A83>██<color=#53647C>██<color=#535E71>██<color=#525361>██<color=#3E3D49>██<color=#343440>██<color=#31313B>██<color=#2D2C36>██<color=#2B2830>██<color=#28242C>██<color=#272229>██<color=#262128>██<color=#242127>██<color=#252227>██<color=#282328>██<color=#2A2428>██<color=#2D252A>██<color=#464446>██<color=#6A696A>██<color=#4D4F54>██<color=#757679>██<color=#828285>██<color=#86868A>██<color=#87888B>██<color=#85868B>██<color=#818286>██<color=#7B7B7F>██<color=#737376>██<color=#6A6A6E>██<color=#5E5E62>██<color=#525255>██<color=#48484B>██<color=#3F3F41>██<color=#38383A>██<color=#353537>██<color=#353538>██<color=#343539>██<color=#343539>██<color=#343639>██<color=#333439>██<color=#333539>██<color=#333538>██<color=#323438>██<color=#323438>██<color=#323338>██<color=#313235>██<color=#303135>██<color=#2F3134>██<color=#313135>██", "\n<color=#B0B8DF>██<color=#B7C3EA>██<color=#BFCEF5>██<color=#CEDFFE>██<color=#EEF9FF>██<color=#FEFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FEFFFF>██<color=#E7F8FF>██<color=#D3E8FF>██<color=#C5D9F5>██<color=#C0D3ED>██<color=#D3E1F2>██<color=#E4EDFA>██<color=#EDF5FF>██<color=#DFEAF9>██<color=#A4AEBE>██<color=#9CA3B1>██<color=#9BA0AC>██<color=#9B9EAA>██<color=#9A9DA8>██<color=#9B9DA7>██<color=#9B9EA7>██<color=#A1A6B1>██<color=#E7EAEF>██<color=#FFFFFF>██<color=#F9FCFF>██<color=#ABAFBD>██<color=#4C4C5C>██<color=#3E3E49>██<color=#393741>██<color=#36333B>██<color=#2D2C33>██<color=#27252C>██<color=#27242A>██<color=#28242A>██<color=#2B2428>██<color=#312729>██<color=#2B2326>██<color=#282024>██<color=#292729>██<color=#5A595A>██<color=#555252>██<color=#414145>██<color=#363639>██<color=#333336>██<color=#302F33>██<color=#2D2D31>██<color=#2B2B2F>██<color=#2A292D>██<color=#28272B>██<color=#27272B>██<color=#28282A>██<color=#282829>██<color=#272728>██<color=#262628>██<color=#252526>██<color=#242425>██<color=#242325>██<color=#232325>██<color=#232324>██<color=#232324>██<color=#232325>██<color=#232325>██<color=#242326>██<color=#242426>██<color=#252527>██<color=#262628>██<color=#262728>██<color=#262729>██<color=#272729>██<color=#27272A>██<color=#27272A>██", "\n<color=#B0BAE0>██<color=#B6C4EB>██<color=#BECFF5>██<color=#D4E6FF>██<color=#F3FCFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#EFF9FF>██<color=#D0E6FE>██<color=#C9DCF5>██<color=#BBCEE8>██<color=#C3D2E9>██<color=#DAE5F2>██<color=#E9F2FC>██<color=#F1FBFF>██<color=#D7E1EF>██<color=#9FA7B9>██<color=#9CA4B3>██<color=#9AA1AE>██<color=#9A9FAB>██<color=#9A9EA9>██<color=#9B9DA8>██<color=#9B9EA8>██<color=#A5ABB5>██<color=#F1F2F5>██<color=#FFFFFF>██<color=#ADAFBA>██<color=#646270>██<color=#58525B>██<color=#5D5053>██<color=#574A4B>██<color=#534949>██<color=#574642>██<color=#553C35>██<color=#513A33>██<color=#44322D>██<color=#43312B>██<color=#3B2B27>██<color=#372521>██<color=#342521>██<color=#2E2524>██<color=#181921>██<color=#14161E>██<color=#15161F>██<color=#181920>██<color=#212227>██<color=#32343B>██<color=#29292C>██<color=#29292B>██<color=#29282B>██<color=#262528>██<color=#232325>██<color=#1F1F21>██<color=#1D1D1E>██<color=#1C1C1C>██<color=#1B1B1C>██<color=#1B1B1C>██<color=#1A1A1C>██<color=#1B1A1B>██<color=#1A1A1B>██<color=#1A1B1B>██<color=#1A1B1B>██<color=#1B1B1C>██<color=#1B1C1C>██<color=#1C1D1D>██<color=#1C1E1E>██<color=#1D1E1F>██<color=#1E1F1F>██<color=#1E1F20>██<color=#1E1F21>██<color=#1E1F1F>██<color=#1E1F20>██<color=#1E2020>██", "\n<color=#AEB8DE>██<color=#B3C2E8>██<color=#BCCDF3>██<color=#D3E6FF>██<color=#E7F7FF>██<color=#FDFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#DBECFD>██<color=#C8DBF4>██<color=#C1D1E9>██<color=#B5C5DE>██<color=#CAD6E9>██<color=#DEE7F3>██<color=#EAF2FE>██<color=#F0F8FF>██<color=#C8D1E1>██<color=#9DA4B7>██<color=#9DA3B4>██<color=#9AA1AF>██<color=#9A9FAB>██<color=#9A9EA9>██<color=#999DA7>██<color=#999CA6>██<color=#A6A9B1>██<color=#DEE2E9>██<color=#8890A1>██<color=#605D6A>██<color=#484855>██<color=#44414A>██<color=#4D4145>██<color=#493F43>██<color=#3E363A>██<color=#322D32>██<color=#312A2D>██<color=#392C2A>██<color=#352826>██<color=#352826>██<color=#292121>██<color=#251D1E>██<color=#251D1E>██<color=#2B1E1F>██<color=#342321>██<color=#241F22>██<color=#1D1C20>██<color=#18181D>██<color=#17171C>██<color=#13141A>██<color=#121317>██<color=#17171B>██<color=#242326>██<color=#2A2929>██<color=#292728>██<color=#232223>██<color=#1D1C1E>██<color=#19191A>██<color=#181818>██<color=#171717>██<color=#151617>██<color=#151515>██<color=#151515>██<color=#151616>██<color=#161616>██<color=#161616>██<color=#171818>██<color=#181919>██<color=#191A1A>██<color=#1A1B1B>██<color=#1A1B1B>██<color=#1B1B1C>██<color=#1B1C1B>██<color=#1B1D1D>██<color=#1C1D1E>██<color=#1C1E1D>██", "\n<color=#ACB6DB>██<color=#B1BEE4>██<color=#C0D0F3>██<color=#D1E4FF>██<color=#E1F2FF>██<color=#FBFEFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FAFEFF>██<color=#CDDFF6>██<color=#C3D3EA>██<color=#BCCAE0>██<color=#B6C4DA>██<color=#D4DFED>██<color=#E6EEF9>██<color=#F1FAFF>██<color=#F1FAFF>██<color=#B6C0D1>██<color=#9AA0B0>██<color=#9AA0AD>██<color=#9AA0AC>██<color=#969CAA>██<color=#8793A6>██<color=#6C7689>██<color=#656C7E>██<color=#696F80>██<color=#6D6D79>██<color=#58555F>██<color=#4C4A54>██<color=#3F3E48>██<color=#373641>██<color=#37343C>██<color=#302E36>██<color=#2B2B32>██<color=#29282D>██<color=#2B282C>██<color=#262225>██<color=#211F21>██<color=#211D1F>██<color=#1C191C>██<color=#201A1D>██<color=#261D1E>██<color=#1E191B>██<color=#221A1C>██<color=#2B1F1D>██<color=#1B1819>██<color=#0F1216>██<color=#121317>██<color=#121317>██<color=#161619>██<color=#1D1C1D>██<color=#1C1C1C>██<color=#1C1B1C>██<color=#1D1D1D>██<color=#1B1B1C>██<color=#201F20>██<color=#252323>██<color=#222121>██<color=#191919>██<color=#141515>██<color=#141515>██<color=#141414>██<color=#151515>██<color=#171716>██<color=#181919>██<color=#191A1A>██<color=#1A1B1B>██<color=#1B1C1C>██<color=#1C1C1C>██<color=#1C1D1D>██<color=#1D1E1E>██<color=#1D1E1E>██<color=#1F1F1F>██<color=#1F2020>██<color=#202020>██", "\n<color=#A9B3D7>██<color=#B0BDE2>██<color=#C4D7F6>██<color=#D1E5FF>██<color=#EBF7FF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#F8FBFF>██<color=#C0D4F1>██<color=#A0B6DD>██<color=#93A5C9>██<color=#8E9EC0>██<color=#8C9BBB>██<color=#8F9AB8>██<color=#929AB6>██<color=#979DB5>██<color=#AAADC0>██<color=#C9CEDA>██<color=#DEE7F1>██<color=#A0ABBB>██<color=#8595AD>██<color=#6C7C94>██<color=#5E6D85>██<color=#57647C>██<color=#556076>██<color=#606474>██<color=#696670>██<color=#59555F>██<color=#4B4A57>██<color=#424250>██<color=#3C3D48>██<color=#383741>██<color=#2E2E38>██<color=#292931>██<color=#25252D>██<color=#22222A>██<color=#212126>██<color=#1F1E22>██<color=#1D1B1F>██<color=#1F1B1D>██<color=#1E1A1C>██<color=#1C1719>██<color=#20191B>██<color=#181617>██<color=#1B1718>██<color=#1E1719>██<color=#131417>██<color=#111317>██<color=#151618>██<color=#141517>██<color=#161718>██<color=#19191A>██<color=#181719>██<color=#171719>██<color=#161718>██<color=#181819>██<color=#141516>██<color=#161617>██<color=#181818>██<color=#161616>██<color=#1B1B1B>██<color=#201F1F>██<color=#171717>██<color=#131413>██<color=#151515>██<color=#171816>██<color=#191918>██<color=#1A1A1A>██<color=#1B1B1B>██<color=#1C1C1B>██<color=#1C1D1C>██<color=#1D1D1D>██<color=#1E1E1D>██<color=#1D1E1E>██<color=#1E1F1E>██<color=#1F211F>██<color=#1F211F>██", "\n<color=#A6B1D1>██<color=#B2C0E1>██<color=#C8DAF6>██<color=#DBEDFF>██<color=#FBFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FCFEFF>██<color=#CBDEF4>██<color=#9FBBE1>██<color=#95ACD2>██<color=#8EA2C5>██<color=#8598B9>██<color=#8293B4>██<color=#8090AF>██<color=#7F8EAA>██<color=#7E8CA7>██<color=#7C89A2>██<color=#7A849D>██<color=#7A8096>██<color=#767B90>██<color=#707489>██<color=#747589>██<color=#797687>██<color=#7A7581>██<color=#6B6977>██<color=#5E5E6D>██<color=#585867>██<color=#505060>██<color=#494B59>██<color=#454553>██<color=#3F3F4C>██<color=#363844>██<color=#32333E>██<color=#30303A>██<color=#2A2A32>██<color=#25252E>██<color=#202028>██<color=#1C1C23>██<color=#201E22>██<color=#1E1B1E>██<color=#1B1A1D>██<color=#18171A>██<color=#191718>██<color=#1B1819>██<color=#1D1819>██<color=#1A1719>██<color=#131418>██<color=#121417>██<color=#121416>██<color=#121417>██<color=#131516>██<color=#121415>██<color=#151517>██<color=#161618>██<color=#151517>██<color=#141517>██<color=#131416>██<color=#161617>██<color=#131414>██<color=#101214>██<color=#131515>██<color=#121314>██<color=#141516>██<color=#141515>██<color=#1B1B1B>██<color=#1A1A1A>██<color=#161615>██<color=#171818>██<color=#191919>██<color=#1A1A19>██<color=#131615>██<color=#111415>██<color=#161818>██<color=#1D1D1D>██<color=#1C1D1C>██<color=#1D1E1D>██<color=#1E1E1E>██<color=#1E1F1E>██<color=#1E1F1F>██",
			"\n<color=#A2ABC8>██<color=#A9B8D8>██<color=#C9DBF5>██<color=#E6F3FF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#FFFFFF>██<color=#CEE2F3>██<color=#9DB9DB>██<color=#93AACC>██<color=#8DA0C2>██<color=#8798B9>██<color=#8191AF>██<color=#7C8BA6>██<color=#7687A2>██<color=#73839D>██<color=#74829C>██<color=#728099>██<color=#707C96>██<color=#6B768F>██<color=#666F88>██<color=#626A82>██<color=#60677D>██<color=#5E6378>██<color=#5D5F74>██<color=#5D5E70>██<color=#5E5D6B>██<color=#565563>██<color=#474A59>██<color=#3F4353>██<color=#3E3F4C>██<color=#383946>██<color=#303340>██<color=#2E2F3C>██<color=#2D2C37>██<color=#2A2932>██<color=#272730>██<color=#25252A>██<color=#232226>██<color=#242124>██<color=#1D1C1E>██<color=#18171C>██<color=#17171A>██<color=#181719>██<color=#131417>██<color=#121417>██<color=#111317>██<color=#111216>██<color=#101216>██<color=#111215>██<color=#111315>██<color=#121414>██<color=#121416>██<color=#121314>██<color=#131315>██<color=#151516>██<color=#151515>██<color=#141415>██<color=#111313>██<color=#131415>██<color=#111213>██<color=#0E0F11>██<color=#101213>██<color=#101212>██<color=#0F1212>██<color=#111314>██<color=#131515>██<color=#171718>██<color=#141616>██<color=#1A1A1A>██<color=#101111>██<color=#121313>██<color=#131415>██<color=#131515>██<color=#131514>██<color=#171918>██<color=#161718>██<color=#151717>██<color=#151817>██<color=#191B1A>██<color=#1E1F1E>██", "\n<color=#A4ABC3>██<color=#BFCDE5>██<color=#C8D8EE>██<color=#D9E6F7>██<color=#E9F1FC>██<color=#EDF4FC>██<color=#F0F6FD>██<color=#F3F8FE>██<color=#F5F9FF>██<color=#E9EEF6>██<color=#A8BBD6>██<color=#8CA1C1>██<color=#8699B8>██<color=#8092B0>██<color=#7C8DA9>██<color=#7789A2>██<color=#72839B>██<color=#6F7E98>██<color=#6E7C95>██<color=#6D7992>██<color=#69758D>██<color=#647189>██<color=#606B85>██<color=#5E677F>██<color=#5B637B>██<color=#5A6176>██<color=#585E73>██<color=#555A6E>██<color=#515566>██<color=#4D5160>██<color=#4B4D5B>██<color=#484857>██<color=#454451>██<color=#403F4B>██<color=#383845>██<color=#323340>██<color=#262D3C>██<color=#212837>██<color=#1F2631>██<color=#1E232E>██<color=#1C202B>██<color=#191D27>██<color=#131822>██<color=#28292E>██<color=#2A2627>██<color=#1B1819>██<color=#1D191B>██<color=#1B1819>██<color=#111417>██<color=#101419>██<color=#101418>██<color=#101417>██<color=#111316>██<color=#111316>██<color=#111215>██<color=#121315>██<color=#121415>██<color=#111214>██<color=#121313>██<color=#141414>██<color=#141415>██<color=#131414>██<color=#121313>██<color=#121314>██<color=#121312>██<color=#0C0E10>██<color=#0D0F11>██<color=#0F1011>██<color=#0E1011>██<color=#0D1011>██<color=#0E1112>██<color=#131416>██<color=#141515>██<color=#101212>██<color=#161817>██<color=#1A1A1A>██<color=#171817>██<color=#171917>██<color=#171918>██<color=#191B1A>██<color=#1B1C1B>██<color=#1B1C1B>██<color=#1B1D1C>██<color=#1C1E1D>██<color=#1E1E1D>██", "\n<color=#9097AC>██<color=#A0A8BE>██<color=#ACB7CB>██<color=#BBC6D9>██<color=#C0CBDE>██<color=#BECCDE>██<color=#A4B4CA>██<color=#7F94B0>██<color=#778DA9>██<color=#7D8EA8>██<color=#7B8CA4>██<color=#7788A1>██<color=#74839C>██<color=#717F97>██<color=#6D7A93>██<color=#68758D>██<color=#627089>██<color=#616C86>██<color=#616A83>██<color=#5F6880>██<color=#60677E>██<color=#60667C>██<color=#5E6479>██<color=#595F74>██<color=#565C70>██<color=#51586C>██<color=#4C5265>██<color=#434B5E>██<color=#404657>██<color=#3F4250>██<color=#3E3F4D>██<color=#3C3C49>██<color=#383745>██<color=#343441>██<color=#34333E>██<color=#35313A>██<color=#262933>██<color=#1E2430>██<color=#1B212B>██<color=#191E27>██<color=#161B23>██<color=#151A21>██<color=#12181F>██<color=#0D141B>██<color=#0F141B>██<color=#12151C>██<color=#11151A>██<color=#0C1013>██<color=#0E1115>██<color=#111419>██<color=#111318>██<color=#111417>██<color=#111317>██<color=#111215>██<color=#121315>██<color=#111314>██<color=#111313>██<color=#0F1111>██<color=#101211>██<color=#111313>██<color=#121313>██<color=#111212>██<color=#101211>██<color=#111313>██<color=#111313>██<color=#0C0D0D>██<color=#0C0E0F>██<color=#0E1010>██<color=#0C0E0E>██<color=#0B0E0E>██<color=#0B0E0E>██<color=#0F1111>██<color=#141514>██<color=#111313>██<color=#101213>██<color=#121514>██<color=#181A18>██<color=#181916>██<color=#181A19>██<color=#1A1A1A>██<color=#1A1A1A>██<color=#1B1B19>██<color=#1A1B1B>██<color=#1A1C1C>██<color=#1B1D1C>██", "\n<color=#A8B0C4>██<color=#B5BFD0>██<color=#B6BFD0>██<color=#B8C1D2>██<color=#ACB7C8>██<color=#72849D>██<color=#637893>██<color=#647893>██<color=#6C7B95>██<color=#6C7992>██<color=#6B778F>██<color=#68728B>██<color=#656E85>██<color=#636B81>██<color=#626A7F>██<color=#61677B>██<color=#5D6478>██<color=#585F73>██<color=#545B6F>██<color=#52586C>██<color=#51586C>██<color=#52596C>██<color=#51576C>██<color=#4F5669>██<color=#4D5364>██<color=#494D5C>██<color=#414756>██<color=#3C4351>██<color=#3A3F4D>██<color=#393C48>██<color=#363743>██<color=#323340>██<color=#30303C>██<color=#2F2E38>██<color=#272833>██<color=#1F232E>██<color=#1B212C>██<color=#191E28>██<color=#171C26>██<color=#151B22>██<color=#12181E>██<color=#11151D>██<color=#0F131A>██<color=#0C1016>██<color=#0D1115>██<color=#0D1015>██<color=#0D1014>██<color=#0A0E12>██<color=#0C0F12>██<color=#0E1215>██<color=#0E1114>██<color=#0E1113>██<color=#0E1112>██<color=#0F1113>██<color=#0E1011>██<color=#0C0F0F>██<color=#0F1112>██<color=#0E1010>██<color=#0E100F>██<color=#101211>██<color=#111212>██<color=#111213>██<color=#0F1111>██<color=#0F1111>██<color=#111313>██<color=#0C0E0F>██<color=#090D0D>██<color=#0B0F0F>██<color=#0C0E0E>██<color=#0A0D0E>██<color=#0B0E0E>██<color=#0D1010>██<color=#0F1211>██<color=#111312>██<color=#101212>██<color=#0F1211>██<color=#101312>██<color=#161818>██<color=#191918>██<color=#181917>██<color=#191917>██<color=#191A1A>██<color=#191A1A>██<color=#1A1B19>██<color=#1A1B19>██", "\n<color=#AFB6C7>██<color=#AEB5C5>██<color=#AFB6C5>██<color=#7A879B>██<color=#556781>██<color=#536680>██<color=#556780>██<color=#606C82>██<color=#5C6980>██<color=#5B687F>██<color=#5C667B>██<color=#5B6277>██<color=#585F74>██<color=#565C71>██<color=#535A6E>██<color=#52586B>██<color=#525668>██<color=#535565>██<color=#535363>██<color=#515362>██<color=#4F5361>██<color=#4F515F>██<color=#484B5A>██<color=#414654>██<color=#3D4252>██<color=#3A3F4F>██<color=#383C4A>██<color=#393A47>██<color=#383945>██<color=#363641>██<color=#32323C>██<color=#2F2E37>██<color=#2A2A33>██<color=#1E232E>██<color=#171F29>██<color=#161D26>██<color=#151B24>██<color=#131920>██<color=#12171F>██<color=#11151D>██<color=#0F1419>██<color=#0F1317>██<color=#0D1115>██<color=#0B0E13>██<color=#0B0F12>██<color=#0D0F12>██<color=#0C0F11>██<color=#0A0D0F>██<color=#0B0E10>██<color=#0C0F11>██<color=#0D1013>██<color=#0E1113>██<color=#0D1013>██<color=#0D1112>██<color=#0E1012>██<color=#0F1112>██<color=#0E1111>██<color=#0E1111>██<color=#0D0F10>██<color=#101212>██<color=#101212>██<color=#111312>██<color=#0F1212>██<color=#0F1111>██<color=#0F1212>██<color=#0D0F0E>██<color=#0A0D0D>██<color=#0B0E0F>██<color=#0D0F10>██<color=#090D0E>██<color=#090D0F>██<color=#0C0F10>██<color=#0E1110>██<color=#0F1211>██<color=#0F1111>██<color=#101213>██<color=#0F1214>██<color=#0F1313>██<color=#131514>██<color=#181A1A>██<color=#0F1821>██<color=#0D141A>██<color=#0D1620>██<color=#11243F>██<color=#101F37>██", "\n"
		});
	}

	// Token: 0x06000666 RID: 1638
	[DllImport("user32.dll", EntryPoint = "SetWindowLongA")]
	private static extern int SetWindowLong(int hwnd, int nIndex, long dwNewLong);

	// Token: 0x06000667 RID: 1639
	[DllImport("user32.dll")]
	private static extern bool ShowWindowAsync(int hWnd, int nCmdShow);

	// Token: 0x06000668 RID: 1640
	[DllImport("user32.dll")]
	private static extern int SetLayeredWindowAttributes(int hwnd, int crKey, byte bAlpha, int dwFlags);

	// Token: 0x06000669 RID: 1641
	[DllImport("user32.dll")]
	private static extern int GetActiveWindow();

	// Token: 0x0600066A RID: 1642
	[DllImport("user32.dll")]
	private static extern long GetWindowLong(int hwnd, int nIndex);

	// Token: 0x0600066B RID: 1643
	[DllImport("user32.dll")]
	private static extern int SetWindowPos(int hwnd, int hwndInsertAfter, int x, int y, int cx, int cy, int uFlags);

	// Token: 0x0600066C RID: 1644
	[DllImport("user32.dll")]
	private static extern bool ShowWindow(int hWnd, int nCmdShow);

	// Token: 0x0400046E RID: 1134
	[SerializeField]
	private GameObject songSelect;

	// Token: 0x0400046F RID: 1135
	[SerializeField]
	private GameObject settingsMenu;

	// Token: 0x04000470 RID: 1136
	[SerializeField]
	private GameObject onlineMenu;

	// Token: 0x04000471 RID: 1137
	[SerializeField]
	private SongScan songScan;

	// Token: 0x04000472 RID: 1138
	[SerializeField]
	private ControlMapper controlMapper;

	// Token: 0x04000473 RID: 1139
	[SerializeField]
	private ConfirmationMenu confirmMenu;

	// Token: 0x04000474 RID: 1140
	[SerializeField]
	private ConfirmationMenu notSupportedMenu;

	// Token: 0x04000475 RID: 1141
	[SerializeField]
	private TextMeshProUGUI buildVersion;

	// Token: 0x04000476 RID: 1142
	[SerializeField]
	private TextMeshProUGUI buildTag;

	// Token: 0x04000477 RID: 1143
	[SerializeField]
	private RemoteIconAndSourceUpdater remoteIconAndSourceUpdater;

	// Token: 0x04000478 RID: 1144
	[HideInInspector]
	public bool \u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE;

	// Token: 0x04000479 RID: 1145
	[SerializeField]
	private News news;

	// Token: 0x0400047A RID: 1146
	[SerializeField]
	private GameObject analyticsDialog;

	// Token: 0x0400047B RID: 1147
	private bool \u02B9\u02B3\u02B4\u02B7\u02B7\u02B7\u02BC\u02BE\u02B6\u02B6\u02B6;

	// Token: 0x0400047C RID: 1148
	public MenuMusic \u02B7\u02BA\u02BF\u02B2\u02BA\u02BC\u02BC\u02BB\u02B2\u02BC\u02BF;

	// Token: 0x0400047D RID: 1149
	private bool \u02B7\u02B4\u02B4\u02B3\u02BF\u02B6\u02BF\u02C1\u02BA\u02BF\u02B5;

	// Token: 0x0400047E RID: 1150
	private bool \u02BF\u02C1\u02B5\u02BD\u02BB\u02C1\u02B6\u02B8\u02B6\u02BB\u02B8;

	// Token: 0x0400047F RID: 1151
	private string \u02B3\u02B2\u02B7\u02BA\u02C1\u02C0\u02BB\u02BE\u02B9\u02B3\u02B2;

	// Token: 0x04000480 RID: 1152
	private string \u02BC\u02BE\u02B6\u02B5\u02B9\u02C0\u02B7\u02C1\u02BC\u02B7\u02B7;

	// Token: 0x04000481 RID: 1153
	private string \u02B6\u02B8\u02B3\u02BF\u02BC\u02BB\u02BF\u02C0\u02B6\u02B2\u02C1;

	// Token: 0x04000482 RID: 1154
	private bool \u02B2\u02BF\u02BD\u02B5\u02B7\u02C1\u02B3\u02BE\u02BC\u02C1\u02B3;

	// Token: 0x04000483 RID: 1155
	public GameObject \u02B8\u02C0\u02B3\u02BD\u02B5\u02BA\u02BD\u02BD\u02B6\u02C1\u02B3;

	// Token: 0x04000484 RID: 1156
	private static bool \u02B6\u02BC\u02C1\u02B8\u02BB\u02BB\u02BD\u02BA\u02B6\u02BC\u02B7;

	// Token: 0x04000485 RID: 1157
	[SerializeField]
	private ConfirmationMenu v1popup;

	// Token: 0x04000486 RID: 1158
	private bool \u02BA\u02BD\u02B6\u02B7\u02B7\u02B2\u02BB\u02BD\u02BC\u02B8\u02B9;

	// Token: 0x04000487 RID: 1159
	private static bool \u02BA\u02BB\u02C0\u02B6\u02B8\u02B2\u02B3\u02BC\u02B8\u02B5\u02BF;

	// Token: 0x04000488 RID: 1160
	private float ticker;

	// Token: 0x04000489 RID: 1161
	private float fs;

	// Token: 0x0400048A RID: 1162
	private int zalgoctr;

	// Token: 0x0400048B RID: 1163
	private string[] zalgo;

	// Token: 0x0400048C RID: 1164
	private byte[] courte;

	// Token: 0x0400048D RID: 1165
	private Texture2D courteTex;

	// Token: 0x0400048E RID: 1166
	private string courtestr;

	// Token: 0x0200009A RID: 154
	[CompilerGenerated]
	private sealed class \u02BA\u02BD\u02BB\u02C0\u02BB\u02BE\u02BA\u02B9\u02BA\u02B2\u02BB
	{
		// Token: 0x06000680 RID: 1664 RVA: 0x000092F2 File Offset: 0x000074F2
		internal int \u02BE\u02BF\u02B3\u02B2\u02B9\u02B5\u02BB\u02BA\u02B5\u02B6\u02B3(string x)
		{
			return this.rnd.Next();
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x000092F2 File Offset: 0x000074F2
		internal int \u02B9\u02BA\u02BB\u02B4\u02BB\u02BE\u02C0\u02B3\u02BE\u02C0\u02BE(string x)
		{
			return this.rnd.Next();
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x000092F2 File Offset: 0x000074F2
		internal int \u02BC\u02B7\u02BA\u02BA\u02BE\u02B2\u02B3\u02B2\u02B5\u02BB\u02B8(string x)
		{
			return this.rnd.Next();
		}

		// Token: 0x04000498 RID: 1176
		public global::System.Random rnd;

		// Token: 0x04000499 RID: 1177
		public Func<string, int> nt;
	}
}
