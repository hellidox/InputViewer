using System;
using StrikeCore;
using UnityEngine;

// Token: 0x02000094 RID: 148
public class InstrumentSensitiveEndOfSongTips : MonoBehaviour
{
	// Token: 0x06000617 RID: 1559 RVA: 0x000381D8 File Offset: 0x000363D8
	private void \u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF()
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
			InstrumentSensitiveEndOfSongTips.\u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(this.yellowTip, false);
			InstrumentSensitiveEndOfSongTips.\u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(this.blueTip, true);
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.orangeTip, false);
			InstrumentSensitiveEndOfSongTips.\u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(this.selectTip, false);
			InstrumentSensitiveEndOfSongTips.\u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(this.drumOrangeTip, true);
		}
		else
		{
			InstrumentSensitiveEndOfSongTips.\u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(this.yellowTip, true);
			InstrumentSensitiveEndOfSongTips.\u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(this.blueTip, false);
			InstrumentSensitiveEndOfSongTips.\u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(this.orangeTip, true);
			InstrumentSensitiveEndOfSongTips.\u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(this.selectTip, false);
			InstrumentSensitiveEndOfSongTips.\u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(this.drumOrangeTip, true);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x0003830C File Offset: 0x0003650C
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

	// Token: 0x06000619 RID: 1561 RVA: 0x00009131 File Offset: 0x00007331
	private static void \u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(GameObject \u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1, bool \u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4)
	{
		if (\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1)
		{
			\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1.SetActive(\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4);
		}
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x000383A0 File Offset: 0x000365A0
	private void \u02BA\u02BA\u02C0\u02BA\u02BC\u02B9\u02B5\u02BE\u02BA\u02C0\u02BD()
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
			InstrumentSensitiveEndOfSongTips.\u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(this.yellowTip, true);
			InstrumentSensitiveEndOfSongTips.\u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(this.blueTip, false);
			InstrumentSensitiveEndOfSongTips.\u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(this.orangeTip, true);
			InstrumentSensitiveEndOfSongTips.\u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(this.selectTip, true);
			InstrumentSensitiveEndOfSongTips.\u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(this.drumOrangeTip, false);
		}
		else
		{
			InstrumentSensitiveEndOfSongTips.\u02B3\u02B8\u02B6\u02B9\u02B2\u02B2\u02B7\u02B4\u02BF\u02B9\u02B4(this.yellowTip, false);
			InstrumentSensitiveEndOfSongTips.\u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(this.blueTip, true);
			InstrumentSensitiveEndOfSongTips.\u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(this.orangeTip, true);
			InstrumentSensitiveEndOfSongTips.\u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(this.selectTip, false);
			InstrumentSensitiveEndOfSongTips.\u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(this.drumOrangeTip, true);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x0003830C File Offset: 0x0003650C
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

	// Token: 0x0600061D RID: 1565 RVA: 0x00009131 File Offset: 0x00007331
	private static void \u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(GameObject \u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1, bool \u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4)
	{
		if (\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1)
		{
			\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1.SetActive(\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4);
		}
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x00009131 File Offset: 0x00007331
	private static void \u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(GameObject \u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1, bool \u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4)
	{
		if (\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1)
		{
			\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1.SetActive(\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4);
		}
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x0003830C File Offset: 0x0003650C
	private void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
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

	// Token: 0x06000620 RID: 1568 RVA: 0x00009131 File Offset: 0x00007331
	private static void \u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(GameObject \u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1, bool \u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4)
	{
		if (\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1)
		{
			\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1.SetActive(\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4);
		}
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x0003830C File Offset: 0x0003650C
	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
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

	// Token: 0x06000622 RID: 1570 RVA: 0x000384D4 File Offset: 0x000366D4
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
			InstrumentSensitiveEndOfSongTips.\u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(this.yellowTip, true);
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.blueTip, true);
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.orangeTip, false);
			InstrumentSensitiveEndOfSongTips.\u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(this.selectTip, false);
			InstrumentSensitiveEndOfSongTips.\u02B3\u02B8\u02B6\u02B9\u02B2\u02B2\u02B7\u02B4\u02BF\u02B9\u02B4(this.drumOrangeTip, false);
		}
		else
		{
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.yellowTip, true);
			InstrumentSensitiveEndOfSongTips.\u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(this.blueTip, false);
			InstrumentSensitiveEndOfSongTips.\u02B3\u02B8\u02B6\u02B9\u02B2\u02B2\u02B7\u02B4\u02BF\u02B9\u02B4(this.orangeTip, true);
			InstrumentSensitiveEndOfSongTips.\u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(this.selectTip, false);
			InstrumentSensitiveEndOfSongTips.\u02B3\u02B8\u02B6\u02B9\u02B2\u02B2\u02B7\u02B4\u02BF\u02B9\u02B4(this.drumOrangeTip, false);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00038608 File Offset: 0x00036808
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
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.yellowTip, false);
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.blueTip, false);
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.orangeTip, false);
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.selectTip, false);
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.drumOrangeTip, true);
		}
		else
		{
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.yellowTip, true);
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.blueTip, true);
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.orangeTip, true);
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.selectTip, true);
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.drumOrangeTip, false);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x0003873C File Offset: 0x0003693C
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
			InstrumentSensitiveEndOfSongTips.\u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(this.yellowTip, true);
			InstrumentSensitiveEndOfSongTips.\u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(this.blueTip, true);
			InstrumentSensitiveEndOfSongTips.\u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(this.orangeTip, true);
			InstrumentSensitiveEndOfSongTips.\u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(this.selectTip, false);
			InstrumentSensitiveEndOfSongTips.\u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(this.drumOrangeTip, true);
		}
		else
		{
			InstrumentSensitiveEndOfSongTips.\u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(this.yellowTip, false);
			InstrumentSensitiveEndOfSongTips.\u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(this.blueTip, false);
			InstrumentSensitiveEndOfSongTips.\u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(this.orangeTip, true);
			InstrumentSensitiveEndOfSongTips.\u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(this.selectTip, true);
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.drumOrangeTip, false);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x0003830C File Offset: 0x0003650C
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

	// Token: 0x06000626 RID: 1574 RVA: 0x00009131 File Offset: 0x00007331
	private static void \u02B3\u02B8\u02B6\u02B9\u02B2\u02B2\u02B7\u02B4\u02BF\u02B9\u02B4(GameObject \u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1, bool \u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4)
	{
		if (\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1)
		{
			\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1.SetActive(\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4);
		}
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00038870 File Offset: 0x00036A70
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
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.yellowTip, true);
			InstrumentSensitiveEndOfSongTips.\u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(this.blueTip, false);
			InstrumentSensitiveEndOfSongTips.\u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(this.orangeTip, false);
			InstrumentSensitiveEndOfSongTips.\u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(this.selectTip, false);
			InstrumentSensitiveEndOfSongTips.\u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(this.drumOrangeTip, false);
		}
		else
		{
			InstrumentSensitiveEndOfSongTips.\u02B3\u02B8\u02B6\u02B9\u02B2\u02B2\u02B7\u02B4\u02BF\u02B9\u02B4(this.yellowTip, true);
			InstrumentSensitiveEndOfSongTips.\u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(this.blueTip, true);
			InstrumentSensitiveEndOfSongTips.\u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(this.orangeTip, false);
			InstrumentSensitiveEndOfSongTips.\u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(this.selectTip, false);
			InstrumentSensitiveEndOfSongTips.\u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(this.drumOrangeTip, false);
		}
		this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = controllerType;
		this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = flag;
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x0003830C File Offset: 0x0003650C
	private void \u02B4\u02B2\u02B5\u02BA\u02B4\u02C0\u02BC\u02BB\u02C1\u02B9\u02BD()
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

	// Token: 0x04000457 RID: 1111
	[SerializeField]
	private GameObject yellowTip;

	// Token: 0x04000458 RID: 1112
	[SerializeField]
	private GameObject blueTip;

	// Token: 0x04000459 RID: 1113
	[SerializeField]
	private GameObject orangeTip;

	// Token: 0x0400045A RID: 1114
	[SerializeField]
	private GameObject selectTip;

	// Token: 0x0400045B RID: 1115
	[SerializeField]
	private GameObject drumOrangeTip;

	// Token: 0x0400045C RID: 1116
	private ControllerType \u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;

	// Token: 0x0400045D RID: 1117
	private bool \u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
}
