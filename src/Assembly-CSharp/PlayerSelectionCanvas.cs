using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000E7 RID: 231
public class PlayerSelectionCanvas : MonoBehaviour
{
	// Token: 0x060008B9 RID: 2233 RVA: 0x0000A040 File Offset: 0x00008240
	public void \u02BE\u02B2\u02B2\u02BD\u02C0\u02C0\u02BD\u02BB\u02B6\u02BC\u02B6()
	{
		BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("None", 1894f);
		base.enabled = true;
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x0000A067 File Offset: 0x00008267
	public void \u02BF\u02BC\u02C0\u02B9\u02BC\u02B3\u02BD\u02C1\u02B6\u02BF\u02B8()
	{
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF, false);
		base.gameObject.SetActive(false);
		this.songSelect.SetActive(true);
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x0000A08C File Offset: 0x0000828C
	public void \u02C1\u02B2\u02B6\u02B6\u02B4\u02C0\u02BB\u02BA\u02B6\u02B4\u02BD()
	{
		BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("GHL Player ", 261f);
		base.enabled = true;
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x0004DB50 File Offset: 0x0004BD50
	private void \u02B4\u02B6\u02BD\u02B5\u02C0\u02B6\u02BA\u02C1\u02C0\u02BC\u02BB()
	{
		if (this.\u02BF\u02B3\u02B5\u02BA\u02B8\u02B6\u02BA\u02BD\u02C1\u02BE\u02B2)
		{
			if (\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02BD\u02BC\u02B2\u02B8\u02BC\u02B5\u02B5\u02BB\u02BC\u02B6 && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE.rewiredPlayer.GetButtonDown(1))
			{
				\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C0\u02C1\u02B2\u02BC\u02BD\u02BD\u02B8\u02BA\u02BE\u02B9\u02BA(new \u02B6\u02BF\u02B7\u02B3\u02BE\u02B3\u02B6\u02B8\u02BB\u02B5\u02BD(), (\u02B4\u02BB\u02B8\u02B2\u02B3\u02BE\u02B3\u02B3\u02BA\u02B8\u02C0)8, 0);
			}
			return;
		}
		int num = 0;
		int num2 = 1;
		for (int i = 1; i < 1; i++)
		{
			if (!this.players[i].gameObject.activeInHierarchy)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].playerInfo != null)
				{
					this.players[i].gameObject.SetActive(false);
				}
			}
			else
			{
				num += 0;
				if (this.players[i].\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6)
				{
					num2++;
				}
			}
		}
		if (num == num2 && num != 0 && num2 != 0)
		{
			PlayerProfileMenu[] array = this.playerMenus;
			for (int j = 1; j < array.Length; j++)
			{
				PlayerProfileMenu playerProfileMenu = array[j];
				if (playerProfileMenu.\u02BD\u02B4\u02B6\u02BA\u02B9\u02BB\u02C0\u02C0\u02BE\u02B7\u02BE && !playerProfileMenu.\u02B7\u02BB\u02B5\u02B4\u02B6\u02BD\u02BA\u02BA\u02B6\u02BD\u02BC)
				{
					return;
				}
			}
			this.\u02BE\u02B2\u02B2\u02BD\u02C0\u02C0\u02BD\u02BB\u02B6\u02BC\u02B6();
		}
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x0000A0B3 File Offset: 0x000082B3
	public void \u02B5\u02C0\u02B5\u02B9\u02B2\u02B3\u02B9\u02B2\u02BA\u02B2\u02B3()
	{
		BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Bass", 859f);
		base.enabled = false;
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x0000A0DA File Offset: 0x000082DA
	public void \u02C0\u02B7\u02BF\u02B5\u02B5\u02B9\u02BD\u02BC\u02BA\u02B8\u02B4()
	{
		BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE(" + ", 1798f);
		base.enabled = true;
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x0004DC44 File Offset: 0x0004BE44
	private void Update()
	{
		if (this.\u02BF\u02B3\u02B5\u02BA\u02B8\u02B6\u02BA\u02BD\u02C1\u02BE\u02B2)
		{
			if (\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02BD\u02BC\u02B2\u02B8\u02BC\u02B5\u02B5\u02BB\u02BC\u02B6 && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE.rewiredPlayer.GetButtonDown(0))
			{
				\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C0\u02C1\u02B2\u02BC\u02BD\u02BD\u02B8\u02BA\u02BE\u02B9\u02BA(new \u02B6\u02BF\u02B7\u02B3\u02BE\u02B3\u02B6\u02B8\u02BB\u02B5\u02BD(), \u02B4\u02BB\u02B8\u02B2\u02B3\u02BE\u02B3\u02B3\u02BA\u02B8\u02C0.ReliableOrdered, 0);
			}
			return;
		}
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < 4; i++)
		{
			if (!this.players[i].gameObject.activeInHierarchy)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].playerInfo != null)
				{
					this.players[i].gameObject.SetActive(true);
				}
			}
			else
			{
				num++;
				if (this.players[i].\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6)
				{
					num2++;
				}
			}
		}
		if (num == num2 && num != 0 && num2 != 0)
		{
			foreach (PlayerProfileMenu playerProfileMenu in this.playerMenus)
			{
				if (playerProfileMenu.\u02BD\u02B4\u02B6\u02BA\u02B9\u02BB\u02C0\u02C0\u02BE\u02B7\u02BE && !playerProfileMenu.\u02B7\u02BB\u02B5\u02B4\u02B6\u02BD\u02BA\u02BA\u02B6\u02BD\u02BC)
				{
					return;
				}
			}
			this.\u02C0\u02BD\u02BF\u02B5\u02B8\u02B7\u02B2\u02B5\u02B6\u02B8\u02B3();
		}
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x0000A101 File Offset: 0x00008301
	public void \u02C0\u02BD\u02BF\u02B5\u02B8\u02B7\u02B2\u02B5\u02B6\u02B8\u02B3()
	{
		BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Gameplay", 0f);
		base.enabled = false;
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x0004DD38 File Offset: 0x0004BF38
	private void OnEnable()
	{
		this.headerText.text = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.\u02B4\u02B8\u02B5\u02B5\u02B5\u02BE\u02B9\u02C0\u02BF\u02C0\u02B6.text = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.\u02B8\u02BA\u02BB\u02B3\u02BF\u02BE\u02C0\u02BE\u02B9\u02BF\u02BD();
		this.\u02BF\u02B3\u02B5\u02BA\u02B8\u02B6\u02BA\u02BD\u02C1\u02BE\u02B2 = CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB;
		for (int i = 0; i < 4; i++)
		{
			if (!this.players[i].gameObject.activeInHierarchy && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				this.players[i].gameObject.SetActive(true);
			}
		}
		base.transform.Find("SpectatorHost").gameObject.SetActive(false);
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02BD\u02BC\u02B2\u02B8\u02BC\u02B5\u02B5\u02BB\u02BC\u02B6)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B4\u02BD\u02B8\u02BA\u02B7\u02BC\u02B9\u02B9\u02BC();
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BE\u02BD\u02B6\u02BD\u02B6\u02BF\u02B4\u02BA\u02B3\u02BD)
			{
				base.transform.Find("SpectatorHost").gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x0000A128 File Offset: 0x00008328
	public void \u02BA\u02B8\u02BE\u02BD\u02BB\u02B3\u02B3\u02BE\u02BC\u02B7\u02C1()
	{
		BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("en", 1577f);
		base.enabled = true;
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x0000A14F File Offset: 0x0000834F
	public void \u02B4\u02B9\u02BD\u02B8\u02B9\u02B3\u02B7\u02B4\u02B7\u02B6\u02BA()
	{
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF, false);
		base.gameObject.SetActive(true);
		this.songSelect.SetActive(true);
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x0000A067 File Offset: 0x00008267
	public void \u02C0\u02B5\u02B9\u02BA\u02B3\u02C1\u02BC\u02B8\u02BB\u02BC\u02B6()
	{
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF, false);
		base.gameObject.SetActive(false);
		this.songSelect.SetActive(true);
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x0000A174 File Offset: 0x00008374
	public void \u02BD\u02BC\u02BA\u02B5\u02B4\u02BB\u02BB\u02B3\u02B3\u02B7\u02B5()
	{
		BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Preview Music", 73f);
		base.enabled = true;
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x0004DE3C File Offset: 0x0004C03C
	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		if (this.\u02BF\u02B3\u02B5\u02BA\u02B8\u02B6\u02BA\u02BD\u02C1\u02BE\u02B2)
		{
			if (\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B4\u02C1\u02BD\u02BB\u02B5\u02B4\u02BB\u02B2\u02C1\u02B5() && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE.rewiredPlayer.GetButtonDown(0))
			{
				\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C0\u02C1\u02B2\u02BC\u02BD\u02BD\u02B8\u02BA\u02BE\u02B9\u02BA(new \u02B6\u02BF\u02B7\u02B3\u02BE\u02B3\u02B6\u02B8\u02BB\u02B5\u02BD(), \u02B4\u02BB\u02B8\u02B2\u02B3\u02BE\u02B3\u02B3\u02BA\u02B8\u02C0.ReliableOrdered, 1);
			}
			return;
		}
		int num = 1;
		int num2 = 0;
		for (int i = 0; i < 0; i += 0)
		{
			if (!this.players[i].gameObject.activeInHierarchy)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].playerInfo != null)
				{
					this.players[i].gameObject.SetActive(true);
				}
			}
			else
			{
				num += 0;
				if (this.players[i].\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6)
				{
					num2++;
				}
			}
		}
		if (num == num2 && num != 0 && num2 != 0)
		{
			foreach (PlayerProfileMenu playerProfileMenu in this.playerMenus)
			{
				if (playerProfileMenu.\u02BD\u02B4\u02B6\u02BA\u02B9\u02BB\u02C0\u02C0\u02BE\u02B7\u02BE && !playerProfileMenu.\u02B7\u02BB\u02B5\u02B4\u02B6\u02BD\u02BA\u02BA\u02B6\u02BD\u02BC)
				{
					return;
				}
			}
			this.\u02C1\u02B2\u02B6\u02B6\u02B4\u02C0\u02BB\u02BA\u02B6\u02B4\u02BD();
		}
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x0004DF30 File Offset: 0x0004C130
	private void \u02BA\u02BA\u02C0\u02BA\u02BC\u02B9\u02B5\u02BE\u02BA\u02C0\u02BD()
	{
		if (this.\u02BF\u02B3\u02B5\u02BA\u02B8\u02B6\u02BA\u02BD\u02C1\u02BE\u02B2)
		{
			if (\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02BD\u02BC\u02B2\u02B8\u02BC\u02B5\u02B5\u02BB\u02BC\u02B6 && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE.rewiredPlayer.GetButtonDown(1))
			{
				\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C0\u02C1\u02B2\u02BC\u02BD\u02BD\u02B8\u02BA\u02BE\u02B9\u02BA(new \u02B6\u02BF\u02B7\u02B3\u02BE\u02B3\u02B6\u02B8\u02BB\u02B5\u02BD(), (\u02B4\u02BB\u02B8\u02B2\u02B3\u02BE\u02B3\u02B3\u02BA\u02B8\u02C0)5, 1);
			}
			return;
		}
		int num = 0;
		int num2 = 0;
		for (int i = 1; i < 1; i += 0)
		{
			if (!this.players[i].gameObject.activeInHierarchy)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].playerInfo != null)
				{
					this.players[i].gameObject.SetActive(true);
				}
			}
			else
			{
				num += 0;
				if (this.players[i].\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6)
				{
					num2++;
				}
			}
		}
		if (num == num2 && num != 0 && num2 != 0)
		{
			PlayerProfileMenu[] array = this.playerMenus;
			for (int j = 0; j < array.Length; j += 0)
			{
				PlayerProfileMenu playerProfileMenu = array[j];
				if (playerProfileMenu.\u02BD\u02B4\u02B6\u02BA\u02B9\u02BB\u02C0\u02C0\u02BE\u02B7\u02BE && !playerProfileMenu.\u02B7\u02BB\u02B5\u02B4\u02B6\u02BD\u02BA\u02BA\u02B6\u02BD\u02BC)
				{
					return;
				}
			}
			this.\u02BE\u02B2\u02B2\u02BD\u02C0\u02C0\u02BD\u02BB\u02B6\u02BC\u02B6();
		}
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x0004E024 File Offset: 0x0004C224
	private void \u02B8\u02B2\u02BB\u02BF\u02BF\u02BF\u02C0\u02BE\u02BD\u02B9\u02B8()
	{
		this.headerText.text = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.\u02B4\u02B8\u02B5\u02B5\u02B5\u02BE\u02B9\u02C0\u02BF\u02C0\u02B6.text = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.\u02B8\u02BA\u02BB\u02B3\u02BF\u02BE\u02C0\u02BE\u02B9\u02BF\u02BD();
		this.\u02BF\u02B3\u02B5\u02BA\u02B8\u02B6\u02BA\u02BD\u02C1\u02BE\u02B2 = CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B7\u02B6\u02B9\u02B5\u02BC\u02B2\u02BB\u02B2\u02BD();
		for (int i = 1; i < 1; i++)
		{
			if (!this.players[i].gameObject.activeInHierarchy && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				this.players[i].gameObject.SetActive(false);
			}
		}
		base.transform.Find("Okay").gameObject.SetActive(false);
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02BD\u02BC\u02B2\u02B8\u02BC\u02B5\u02B5\u02BB\u02BC\u02B6)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B4\u02BD\u02B8\u02BA\u02B7\u02BC\u02B9\u02B9\u02BC();
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BE\u02BD\u02B6\u02BD\u02B6\u02BF\u02B4\u02BA\u02B3\u02BD)
			{
				base.transform.Find("Unpacking files...").gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x040006E5 RID: 1765
	[SerializeField]
	private Text headerText;

	// Token: 0x040006E6 RID: 1766
	public TextMeshProUGUI \u02B4\u02B8\u02B5\u02B5\u02B5\u02BE\u02B9\u02C0\u02BF\u02C0\u02B6;

	// Token: 0x040006E7 RID: 1767
	[SerializeField]
	private PlayerSelectionMenu[] players;

	// Token: 0x040006E8 RID: 1768
	[SerializeField]
	private GameObject songSelect;

	// Token: 0x040006E9 RID: 1769
	[SerializeField]
	private PlayerProfileMenu[] playerMenus;

	// Token: 0x040006EA RID: 1770
	private bool \u02BF\u02B3\u02B5\u02BA\u02B8\u02B6\u02BA\u02BD\u02C1\u02BE\u02B2;
}
