using System;
using StrikeCore;
using UnityEngine;

// Token: 0x02000095 RID: 149
public class InstrumentSensitiveMenuTips : MonoBehaviour
{
	// Token: 0x06000629 RID: 1577 RVA: 0x000389A4 File Offset: 0x00036BA4
	private void Start()
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer)
			{
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
			}
		}
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x000389A4 File Offset: 0x00036BA4
	private void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer)
			{
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
			}
		}
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00038A38 File Offset: 0x00036C38
	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton())
			{
				controllerType = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				flag = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
				break;
			}
		}
		if (flag)
		{
			this.sortTipIcon.SetActive(false);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(true);
			this.jumpTipText.SetActive(false);
			this.songOptionsTipIcon.SetActive(false);
			this.songOptionsTipText.SetActive(false);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(false);
		}
		else
		{
			this.sortTipIcon.SetActive(true);
			this.sortTipText.SetActive(false);
			this.searchTipIcon.SetActive(false);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(false);
			this.jumpTipText.SetActive(false);
			this.songOptionsTipIcon.SetActive(false);
			this.songOptionsTipText.SetActive(true);
			this.drumOptionsTipIcon.SetActive(false);
			this.drumOptionsTipText.SetActive(false);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x00038BE4 File Offset: 0x00036DE4
	private void \u02C0\u02BB\u02B6\u02B9\u02B3\u02B4\u02B3\u02B7\u02BD\u02B8\u02C0()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton())
			{
				controllerType = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				flag = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
				break;
			}
		}
		if (flag)
		{
			this.sortTipIcon.SetActive(false);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(false);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(true);
			this.jumpTipText.SetActive(false);
			this.songOptionsTipIcon.SetActive(true);
			this.songOptionsTipText.SetActive(true);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(true);
		}
		else
		{
			this.sortTipIcon.SetActive(false);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(false);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(true);
			this.jumpTipText.SetActive(true);
			this.songOptionsTipIcon.SetActive(false);
			this.songOptionsTipText.SetActive(false);
			this.drumOptionsTipIcon.SetActive(false);
			this.drumOptionsTipText.SetActive(false);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x000389A4 File Offset: 0x00036BA4
	private void \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer)
			{
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
			}
		}
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00038D90 File Offset: 0x00036F90
	private void \u02BB\u02BC\u02BD\u02B9\u02B3\u02B3\u02BE\u02B4\u02B8\u02B2\u02B2()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton())
			{
				controllerType = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				flag = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
				break;
			}
		}
		if (flag)
		{
			this.sortTipIcon.SetActive(true);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(false);
			this.jumpTipText.SetActive(false);
			this.songOptionsTipIcon.SetActive(false);
			this.songOptionsTipText.SetActive(false);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(false);
		}
		else
		{
			this.sortTipIcon.SetActive(false);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(false);
			this.jumpTipText.SetActive(false);
			this.songOptionsTipIcon.SetActive(true);
			this.songOptionsTipText.SetActive(false);
			this.drumOptionsTipIcon.SetActive(false);
			this.drumOptionsTipText.SetActive(true);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00038F3C File Offset: 0x0003713C
	private void \u02C1\u02B8\u02B5\u02BD\u02BD\u02C0\u02BB\u02B4\u02BD\u02B8\u02B3()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton())
			{
				controllerType = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				flag = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
				break;
			}
		}
		if (flag)
		{
			this.sortTipIcon.SetActive(false);
			this.sortTipText.SetActive(false);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(true);
			this.jumpTipText.SetActive(false);
			this.songOptionsTipIcon.SetActive(false);
			this.songOptionsTipText.SetActive(false);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(false);
		}
		else
		{
			this.sortTipIcon.SetActive(false);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(false);
			this.jumpTipIcon.SetActive(true);
			this.jumpTipText.SetActive(true);
			this.songOptionsTipIcon.SetActive(false);
			this.songOptionsTipText.SetActive(true);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(true);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x000390E8 File Offset: 0x000372E8
	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton())
			{
				controllerType = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				flag = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
				break;
			}
		}
		if (flag)
		{
			this.sortTipIcon.SetActive(true);
			this.sortTipText.SetActive(false);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(false);
			this.jumpTipText.SetActive(false);
			this.songOptionsTipIcon.SetActive(true);
			this.songOptionsTipText.SetActive(true);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(true);
		}
		else
		{
			this.sortTipIcon.SetActive(true);
			this.sortTipText.SetActive(false);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(false);
			this.jumpTipIcon.SetActive(true);
			this.jumpTipText.SetActive(false);
			this.songOptionsTipIcon.SetActive(true);
			this.songOptionsTipText.SetActive(false);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(false);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x000389A4 File Offset: 0x00036BA4
	private void \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer)
			{
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
			}
		}
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x00039294 File Offset: 0x00037494
	private void \u02BB\u02B7\u02C0\u02B3\u02C1\u02BD\u02B9\u02B2\u02B4\u02BE\u02B6()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton())
			{
				controllerType = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				flag = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
				break;
			}
		}
		if (flag)
		{
			this.sortTipIcon.SetActive(true);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(false);
			this.jumpTipIcon.SetActive(true);
			this.jumpTipText.SetActive(false);
			this.songOptionsTipIcon.SetActive(false);
			this.songOptionsTipText.SetActive(true);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(false);
		}
		else
		{
			this.sortTipIcon.SetActive(true);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(false);
			this.jumpTipText.SetActive(true);
			this.songOptionsTipIcon.SetActive(false);
			this.songOptionsTipText.SetActive(true);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(false);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00039440 File Offset: 0x00037640
	private void \u02BC\u02B6\u02B8\u02BA\u02B2\u02B4\u02B7\u02B3\u02C0\u02B8\u02B7()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton())
			{
				controllerType = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				flag = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
				break;
			}
		}
		if (flag)
		{
			this.sortTipIcon.SetActive(true);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(true);
			this.jumpTipText.SetActive(true);
			this.songOptionsTipIcon.SetActive(true);
			this.songOptionsTipText.SetActive(false);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(false);
		}
		else
		{
			this.sortTipIcon.SetActive(false);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(false);
			this.jumpTipText.SetActive(true);
			this.songOptionsTipIcon.SetActive(true);
			this.songOptionsTipText.SetActive(true);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(false);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x000395EC File Offset: 0x000377EC
	private void \u02BB\u02BF\u02BA\u02BC\u02B8\u02B7\u02B4\u02B5\u02B7\u02B9\u02C1()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton())
			{
				controllerType = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				flag = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
				break;
			}
		}
		if (flag)
		{
			this.sortTipIcon.SetActive(true);
			this.sortTipText.SetActive(false);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(true);
			this.jumpTipText.SetActive(true);
			this.songOptionsTipIcon.SetActive(true);
			this.songOptionsTipText.SetActive(true);
			this.drumOptionsTipIcon.SetActive(false);
			this.drumOptionsTipText.SetActive(true);
		}
		else
		{
			this.sortTipIcon.SetActive(true);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(false);
			this.searchTipText.SetActive(false);
			this.jumpTipIcon.SetActive(true);
			this.jumpTipText.SetActive(true);
			this.songOptionsTipIcon.SetActive(true);
			this.songOptionsTipText.SetActive(false);
			this.drumOptionsTipIcon.SetActive(false);
			this.drumOptionsTipText.SetActive(false);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x000389A4 File Offset: 0x00036BA4
	private void \u02B2\u02B7\u02B5\u02C0\u02B4\u02B3\u02B8\u02B3\u02C0\u02BD\u02B5()
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer)
			{
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
			}
		}
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x000389A4 File Offset: 0x00036BA4
	private void \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer)
			{
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
			}
		}
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x00039798 File Offset: 0x00037998
	private void \u02B9\u02B5\u02B2\u02BB\u02B5\u02B3\u02B9\u02BC\u02BF\u02B5\u02BA()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton())
			{
				controllerType = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				flag = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
				break;
			}
		}
		if (flag)
		{
			this.sortTipIcon.SetActive(false);
			this.sortTipText.SetActive(false);
			this.searchTipIcon.SetActive(false);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(false);
			this.jumpTipText.SetActive(false);
			this.songOptionsTipIcon.SetActive(false);
			this.songOptionsTipText.SetActive(false);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(true);
		}
		else
		{
			this.sortTipIcon.SetActive(true);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(false);
			this.searchTipText.SetActive(false);
			this.jumpTipIcon.SetActive(false);
			this.jumpTipText.SetActive(false);
			this.songOptionsTipIcon.SetActive(true);
			this.songOptionsTipText.SetActive(false);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(true);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00039944 File Offset: 0x00037B44
	private void Update()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton())
			{
				controllerType = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				flag = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
				break;
			}
		}
		if (flag)
		{
			this.sortTipIcon.SetActive(false);
			this.sortTipText.SetActive(false);
			this.searchTipIcon.SetActive(false);
			this.searchTipText.SetActive(false);
			this.jumpTipIcon.SetActive(false);
			this.jumpTipText.SetActive(false);
			this.songOptionsTipIcon.SetActive(false);
			this.songOptionsTipText.SetActive(false);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(true);
		}
		else
		{
			this.sortTipIcon.SetActive(true);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(true);
			this.jumpTipText.SetActive(true);
			this.songOptionsTipIcon.SetActive(true);
			this.songOptionsTipText.SetActive(true);
			this.drumOptionsTipIcon.SetActive(false);
			this.drumOptionsTipText.SetActive(false);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00039AF0 File Offset: 0x00037CF0
	private void \u02B5\u02B9\u02B7\u02B7\u02B6\u02B5\u02BC\u02BA\u02B4\u02B2\u02B4()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton())
			{
				controllerType = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
				flag = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
				break;
			}
		}
		if (flag)
		{
			this.sortTipIcon.SetActive(true);
			this.sortTipText.SetActive(true);
			this.searchTipIcon.SetActive(true);
			this.searchTipText.SetActive(false);
			this.jumpTipIcon.SetActive(true);
			this.jumpTipText.SetActive(true);
			this.songOptionsTipIcon.SetActive(false);
			this.songOptionsTipText.SetActive(true);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(true);
		}
		else
		{
			this.sortTipIcon.SetActive(false);
			this.sortTipText.SetActive(false);
			this.searchTipIcon.SetActive(false);
			this.searchTipText.SetActive(true);
			this.jumpTipIcon.SetActive(false);
			this.jumpTipText.SetActive(true);
			this.songOptionsTipIcon.SetActive(false);
			this.songOptionsTipText.SetActive(false);
			this.drumOptionsTipIcon.SetActive(true);
			this.drumOptionsTipText.SetActive(false);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x0400045E RID: 1118
	[SerializeField]
	private GameObject selectTipIcon;

	// Token: 0x0400045F RID: 1119
	[SerializeField]
	private GameObject selectTipText;

	// Token: 0x04000460 RID: 1120
	[SerializeField]
	private GameObject backTipIcon;

	// Token: 0x04000461 RID: 1121
	[SerializeField]
	private GameObject backTipText;

	// Token: 0x04000462 RID: 1122
	[SerializeField]
	private GameObject sortTipIcon;

	// Token: 0x04000463 RID: 1123
	[SerializeField]
	private GameObject sortTipText;

	// Token: 0x04000464 RID: 1124
	[SerializeField]
	private GameObject searchTipIcon;

	// Token: 0x04000465 RID: 1125
	[SerializeField]
	private GameObject searchTipText;

	// Token: 0x04000466 RID: 1126
	[SerializeField]
	private GameObject jumpTipIcon;

	// Token: 0x04000467 RID: 1127
	[SerializeField]
	private GameObject jumpTipText;

	// Token: 0x04000468 RID: 1128
	[SerializeField]
	private GameObject songOptionsTipIcon;

	// Token: 0x04000469 RID: 1129
	[SerializeField]
	private GameObject songOptionsTipText;

	// Token: 0x0400046A RID: 1130
	[SerializeField]
	private GameObject drumOptionsTipIcon;

	// Token: 0x0400046B RID: 1131
	[SerializeField]
	private GameObject drumOptionsTipText;

	// Token: 0x0400046C RID: 1132
	private ControllerType \u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;

	// Token: 0x0400046D RID: 1133
	private bool \u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
}
