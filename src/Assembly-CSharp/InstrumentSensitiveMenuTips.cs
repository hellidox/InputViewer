using System;
using StrikeCore;
using UnityEngine;

public class InstrumentSensitiveMenuTips : MonoBehaviour
{
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

	[SerializeField]
	private GameObject selectTipIcon;

	[SerializeField]
	private GameObject selectTipText;

	[SerializeField]
	private GameObject backTipIcon;

	[SerializeField]
	private GameObject backTipText;

	[SerializeField]
	private GameObject sortTipIcon;

	[SerializeField]
	private GameObject sortTipText;

	[SerializeField]
	private GameObject searchTipIcon;

	[SerializeField]
	private GameObject searchTipText;

	[SerializeField]
	private GameObject jumpTipIcon;

	[SerializeField]
	private GameObject jumpTipText;

	[SerializeField]
	private GameObject songOptionsTipIcon;

	[SerializeField]
	private GameObject songOptionsTipText;

	[SerializeField]
	private GameObject drumOptionsTipIcon;

	[SerializeField]
	private GameObject drumOptionsTipText;

	private ControllerType \u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;

	private bool \u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
}
