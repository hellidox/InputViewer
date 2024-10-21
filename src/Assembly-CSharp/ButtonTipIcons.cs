using System;
using StrikeCore;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000081 RID: 129
public class ButtonTipIcons : MonoBehaviour
{
	// Token: 0x06000548 RID: 1352 RVA: 0x000348EC File Offset: 0x00032AEC
	private void \u02BC\u02BC\u02B9\u02B6\u02C1\u02B9\u02BC\u02BD\u02B6\u02B2\u02B3(bool \u02B6\u02C0\u02BB\u02C1\u02BA\u02BF\u02BC\u02BA\u02BF\u02B7\u02B5 = false)
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer)
			{
				if (\u02B6\u02C0\u02BB\u02C1\u02BA\u02BF\u02BC\u02BA\u02BF\u02B7\u02B5)
				{
					this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
					break;
				}
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton() && this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 != u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType)
				{
					this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
					this.\u02B9\u02B4\u02B2\u02B2\u02B8\u02B2\u02B3\u02BF\u02BE\u02B6\u02B9();
				}
			}
		}
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x000349BC File Offset: 0x00032BBC
	private void \u02BF\u02B7\u02B3\u02BF\u02B9\u02BD\u02B7\u02BA\u02B8\u02B8\u02B3()
	{
		if (this.buttonType >= (ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9)(-5))
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BD\u02B9\u02B8\u02B3\u02C0\u02B7\u02B4\u02BA\u02BE\u02B5[this.buttonType - (ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9)40];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.Guitar)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BC\u02B6\u02B2\u02BE\u02BB\u02B3\u02BA\u02BD\u02B6\u02B2[(int)this.buttonType];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.GHLGuitar)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B2\u02B5\u02C0\u02B7\u02B3\u02B6\u02C0\u02BD\u02B2\u02B5\u02B6[(int)this.buttonType];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.FiveLaneDrums || this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.Drums)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BE\u02C1\u02B2\u02B6\u02C0\u02BE\u02B6\u02C0\u02C0\u02B5[(int)this.buttonType];
			return;
		}
		throw new NotImplementedException();
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00034A78 File Offset: 0x00032C78
	private void \u02B9\u02B4\u02B2\u02B2\u02B8\u02B2\u02B3\u02BF\u02BE\u02B6\u02B9()
	{
		if (this.buttonType >= ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9.Start)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BD\u02B9\u02B8\u02B3\u02C0\u02B7\u02B4\u02BA\u02BE\u02B5[this.buttonType - ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9.Start];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.Guitar)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BC\u02B6\u02B2\u02BE\u02BB\u02B3\u02BA\u02BD\u02B6\u02B2[(int)this.buttonType];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.GHLGuitar)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B2\u02B5\u02C0\u02B7\u02B3\u02B6\u02C0\u02BD\u02B2\u02B5\u02B6[(int)this.buttonType];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.Drums || this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.FiveLaneDrums)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BE\u02C1\u02B2\u02B6\u02C0\u02BE\u02B6\u02C0\u02C0\u02B5[(int)this.buttonType];
			return;
		}
		throw new NotImplementedException();
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00034B34 File Offset: 0x00032D34
	private void \u02BC\u02B7\u02BD\u02B2\u02B8\u02C1\u02BF\u02C0\u02B7\u02BB\u02C0()
	{
		if (this.buttonType >= (ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9)112)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BD\u02B9\u02B8\u02B3\u02C0\u02B7\u02B4\u02BA\u02BE\u02B5[this.buttonType - ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9.Esc];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.Guitar)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BC\u02B6\u02B2\u02BE\u02BB\u02B3\u02BA\u02BD\u02B6\u02B2[(int)this.buttonType];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.GHLGuitar)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B2\u02B5\u02C0\u02B7\u02B3\u02B6\u02C0\u02BD\u02B2\u02B5\u02B6[(int)this.buttonType];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == (ControllerType)4 || this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.Drums)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BE\u02C1\u02B2\u02B6\u02C0\u02BE\u02B6\u02C0\u02C0\u02B5[(int)this.buttonType];
			return;
		}
		throw new NotImplementedException();
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x000089A4 File Offset: 0x00006BA4
	private void Update()
	{
		this.\u02BC\u02BC\u02B9\u02B6\u02C1\u02B9\u02BC\u02BD\u02B6\u02B2\u02B3(false);
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00034BF0 File Offset: 0x00032DF0
	private void \u02B6\u02B6\u02BA\u02BB\u02B7\u02B4\u02C0\u02BC\u02BE\u02B5\u02B9()
	{
		if (this.buttonType >= (ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9)(-103))
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BD\u02B9\u02B8\u02B3\u02C0\u02B7\u02B4\u02BA\u02BE\u02B5[this.buttonType - (ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9)46];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.Guitar)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BC\u02B6\u02B2\u02BE\u02BB\u02B3\u02BA\u02BD\u02B6\u02B2[(int)this.buttonType];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.GHLGuitar)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B2\u02B5\u02C0\u02B7\u02B3\u02B6\u02C0\u02BD\u02B2\u02B5\u02B6[(int)this.buttonType];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == (ControllerType)7 || this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == (ControllerType)7)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BE\u02C1\u02B2\u02B6\u02C0\u02BE\u02B6\u02C0\u02C0\u02B5[(int)this.buttonType];
			return;
		}
		throw new NotImplementedException();
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00034CAC File Offset: 0x00032EAC
	private void \u02B8\u02BD\u02C1\u02B6\u02C1\u02B2\u02C0\u02B2\u02B7\u02BC\u02B6(bool \u02B6\u02C0\u02BB\u02C1\u02BA\u02BF\u02BC\u02BA\u02BF\u02B7\u02B5 = false)
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer)
			{
				if (\u02B6\u02C0\u02BB\u02C1\u02BA\u02BF\u02BC\u02BA\u02BF\u02B7\u02B5)
				{
					this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
					break;
				}
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton() && this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 != u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType)
				{
					this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
					this.\u02B6\u02B6\u02BA\u02BB\u02B7\u02B4\u02C0\u02BC\u02BE\u02B5\u02B9();
				}
			}
		}
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x000089AD File Offset: 0x00006BAD
	private void \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
		this.\u02C0\u02B3\u02B6\u02B4\u02B9\u02B6\u02B2\u02BB\u02B4\u02BE\u02BA(true);
		this.\u02BC\u02B7\u02BD\u02B2\u02B8\u02C1\u02BF\u02C0\u02B7\u02BB\u02C0();
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x00034CAC File Offset: 0x00032EAC
	private void \u02B5\u02BE\u02B5\u02B3\u02BE\u02BE\u02B2\u02C0\u02B7\u02BA\u02B3(bool \u02B6\u02C0\u02BB\u02C1\u02BA\u02BF\u02BC\u02BA\u02BF\u02B7\u02B5 = false)
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer)
			{
				if (\u02B6\u02C0\u02BB\u02C1\u02BA\u02BF\u02BC\u02BA\u02BF\u02B7\u02B5)
				{
					this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
					break;
				}
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton() && this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 != u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType)
				{
					this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
					this.\u02B6\u02B6\u02BA\u02BB\u02B7\u02B4\u02C0\u02BC\u02BE\u02B5\u02B9();
				}
			}
		}
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x000089C8 File Offset: 0x00006BC8
	private void \u02B5\u02B9\u02B7\u02B7\u02B6\u02B5\u02BC\u02BA\u02B4\u02B2\u02B4()
	{
		this.\u02B8\u02BD\u02C1\u02B6\u02C1\u02B2\u02C0\u02B2\u02B7\u02BC\u02B6(true);
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x000089D1 File Offset: 0x00006BD1
	private void Start()
	{
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
		this.\u02BC\u02BC\u02B9\u02B6\u02C1\u02B9\u02BC\u02BD\u02B6\u02B2\u02B3(true);
		this.\u02B9\u02B4\u02B2\u02B2\u02B8\u02B2\u02B3\u02BF\u02BE\u02B6\u02B9();
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x000089EC File Offset: 0x00006BEC
	private void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
		this.\u02BC\u02C1\u02BC\u02BD\u02BC\u02C1\u02BF\u02B3\u02BF\u02BC\u02BB(true);
		this.\u02BF\u02B7\u02B3\u02BF\u02B9\u02BD\u02B7\u02BA\u02B8\u02B8\u02B3();
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x00034D7C File Offset: 0x00032F7C
	private void \u02C0\u02B3\u02B6\u02B4\u02B9\u02B6\u02B2\u02BB\u02B4\u02BE\u02BA(bool \u02B6\u02C0\u02BB\u02C1\u02BA\u02BF\u02BC\u02BA\u02BF\u02B7\u02B5 = false)
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer)
			{
				if (\u02B6\u02C0\u02BB\u02C1\u02BA\u02BF\u02BC\u02BA\u02BF\u02B7\u02B5)
				{
					this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
					break;
				}
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton() && this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 != u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType)
				{
					this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
					this.\u02BC\u02BF\u02B2\u02C1\u02B5\u02B2\u02B2\u02B6\u02B9\u02BA\u02B2();
				}
			}
		}
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x000348EC File Offset: 0x00032AEC
	private void \u02BD\u02B2\u02C0\u02BE\u02B8\u02B2\u02BD\u02B3\u02B6\u02BC\u02BE(bool \u02B6\u02C0\u02BB\u02C1\u02BA\u02BF\u02BC\u02BA\u02BF\u02B7\u02B5 = false)
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer)
			{
				if (\u02B6\u02C0\u02BB\u02C1\u02BA\u02BF\u02BC\u02BA\u02BF\u02B7\u02B5)
				{
					this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
					break;
				}
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton() && this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 != u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType)
				{
					this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
					this.\u02B9\u02B4\u02B2\u02B2\u02B8\u02B2\u02B3\u02BF\u02BE\u02B6\u02B9();
				}
			}
		}
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x00034E4C File Offset: 0x0003304C
	private void \u02BA\u02B2\u02B6\u02BB\u02C0\u02BD\u02B3\u02BD\u02BF\u02B9\u02B4()
	{
		if (this.buttonType >= (ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9)127)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BD\u02B9\u02B8\u02B3\u02C0\u02B7\u02B4\u02BA\u02BE\u02B5[this.buttonType - (ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9)90];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.Guitar)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BC\u02B6\u02B2\u02BE\u02BB\u02B3\u02BA\u02BD\u02B6\u02B2[(int)this.buttonType];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.GHLGuitar)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B2\u02B5\u02C0\u02B7\u02B3\u02B6\u02C0\u02BD\u02B2\u02B5\u02B6[(int)this.buttonType];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == (ControllerType)8 || this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == (ControllerType)5)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BE\u02C1\u02B2\u02B6\u02C0\u02BE\u02B6\u02C0\u02C0\u02B5[(int)this.buttonType];
			return;
		}
		throw new NotImplementedException();
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x000348EC File Offset: 0x00032AEC
	private void \u02BC\u02C1\u02BC\u02BD\u02BC\u02C1\u02BF\u02B3\u02BF\u02BC\u02BB(bool \u02B6\u02C0\u02BB\u02C1\u02BA\u02BF\u02BC\u02BA\u02BF\u02B7\u02B5 = false)
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer)
			{
				if (\u02B6\u02C0\u02BB\u02C1\u02BA\u02BF\u02BC\u02BA\u02BF\u02B7\u02B5)
				{
					this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
					break;
				}
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetAnyButton() && this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 != u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType)
				{
					this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.controllerType.GetControllerType;
					this.\u02B9\u02B4\u02B2\u02B2\u02B8\u02B2\u02B3\u02BF\u02BE\u02B6\u02B9();
				}
			}
		}
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x00034F08 File Offset: 0x00033108
	private void \u02BC\u02BF\u02B2\u02C1\u02B5\u02B2\u02B2\u02B6\u02B9\u02BA\u02B2()
	{
		if (this.buttonType >= (ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9)(-127))
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02BD\u02B9\u02B8\u02B3\u02C0\u02B7\u02B4\u02BA\u02BE\u02B5[this.buttonType - ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9.Yellow];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.Guitar)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BC\u02B6\u02B2\u02BE\u02BB\u02B3\u02BA\u02BD\u02B6\u02B2[(int)this.buttonType];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.GHLGuitar)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B2\u02B5\u02C0\u02B7\u02B3\u02B6\u02C0\u02BD\u02B2\u02B5\u02B6[(int)this.buttonType];
			return;
		}
		if (this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == (ControllerType)5 || this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 == ControllerType.Drums)
		{
			this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BE\u02C1\u02B2\u02B6\u02C0\u02BE\u02B6\u02C0\u02C0\u02B5[(int)this.buttonType];
			return;
		}
		throw new NotImplementedException();
	}

	// Token: 0x040003F6 RID: 1014
	private ControllerType \u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;

	// Token: 0x040003F7 RID: 1015
	private Image \u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6;

	// Token: 0x040003F8 RID: 1016
	[SerializeField]
	private ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9 buttonType;

	// Token: 0x02000082 RID: 130
	private enum \u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9
	{
		// Token: 0x040003FA RID: 1018
		Green,
		// Token: 0x040003FB RID: 1019
		Red,
		// Token: 0x040003FC RID: 1020
		Yellow,
		// Token: 0x040003FD RID: 1021
		Blue,
		// Token: 0x040003FE RID: 1022
		Orange,
		// Token: 0x040003FF RID: 1023
		W3,
		// Token: 0x04000400 RID: 1024
		Start = 11,
		// Token: 0x04000401 RID: 1025
		Select,
		// Token: 0x04000402 RID: 1026
		Spacebar,
		// Token: 0x04000403 RID: 1027
		Esc
	}
}
