using System;
using StrikeCore;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTipIcons : MonoBehaviour
{
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

	private void Update()
	{
		this.\u02BC\u02BC\u02B9\u02B6\u02C1\u02B9\u02BC\u02BD\u02B6\u02B2\u02B3(false);
	}

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

	private void \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
		this.\u02C0\u02B3\u02B6\u02B4\u02B9\u02B6\u02B2\u02BB\u02B4\u02BE\u02BA(true);
		this.\u02BC\u02B7\u02BD\u02B2\u02B8\u02C1\u02BF\u02C0\u02B7\u02BB\u02C0();
	}

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

	private void \u02B5\u02B9\u02B7\u02B7\u02B6\u02B5\u02BC\u02BA\u02B4\u02B2\u02B4()
	{
		this.\u02B8\u02BD\u02C1\u02B6\u02C1\u02B2\u02C0\u02B2\u02B7\u02BC\u02B6(true);
	}

	private void Start()
	{
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
		this.\u02BC\u02BC\u02B9\u02B6\u02C1\u02B9\u02BC\u02BD\u02B6\u02B2\u02B3(true);
		this.\u02B9\u02B4\u02B2\u02B2\u02B8\u02B2\u02B3\u02BF\u02BE\u02B6\u02B9();
	}

	private void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
		this.\u02BC\u02C1\u02BC\u02BD\u02BC\u02C1\u02BF\u02B3\u02BF\u02BC\u02BB(true);
		this.\u02BF\u02B7\u02B3\u02BF\u02B9\u02BD\u02B7\u02BA\u02B8\u02B8\u02B3();
	}

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

	private ControllerType \u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;

	private Image \u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6;

	[SerializeField]
	private ButtonTipIcons.\u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9 buttonType;

	private enum \u02C0\u02B8\u02B4\u02B7\u02C1\u02B7\u02B3\u02B4\u02B6\u02C1\u02B9
	{
		Green,
		Red,
		Yellow,
		Blue,
		Orange,
		W3,
		Start = 11,
		Select,
		Spacebar,
		Esc
	}
}
