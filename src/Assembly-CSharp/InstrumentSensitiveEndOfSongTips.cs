using System;
using StrikeCore;
using UnityEngine;

public class InstrumentSensitiveEndOfSongTips : MonoBehaviour
{
	private void \u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer.playerProfile != null && !chplayer.playerProfile.isRemotePlayer && chplayer.player.GetAnyButton())
			{
				controllerType = chplayer.playerProfile.controllerType.GetControllerType;
				flag = chplayer.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
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

	private void Start()
	{
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer.playerProfile != null && !chplayer.playerProfile.isRemotePlayer)
			{
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = chplayer.playerProfile.controllerType.GetControllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = chplayer.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
			}
		}
	}

	private static void \u02B7\u02BB\u02BE\u02C1\u02B2\u02B3\u02BC\u02BA\u02B7\u02BC\u02BF(GameObject \u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1, bool \u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4)
	{
		if (\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1)
		{
			\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1.SetActive(\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4);
		}
	}

	private void \u02BA\u02BA\u02C0\u02BA\u02BC\u02B9\u02B5\u02BE\u02BA\u02C0\u02BD()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer.playerProfile != null && !chplayer.playerProfile.isRemotePlayer && chplayer.player.GetAnyButton())
			{
				controllerType = chplayer.playerProfile.controllerType.GetControllerType;
				flag = chplayer.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
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

	private void \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer.playerProfile != null && !chplayer.playerProfile.isRemotePlayer)
			{
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = chplayer.playerProfile.controllerType.GetControllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = chplayer.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
			}
		}
	}

	private static void \u02C1\u02B7\u02BB\u02B5\u02B7\u02BB\u02B4\u02B7\u02B3\u02BA\u02B7(GameObject \u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1, bool \u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4)
	{
		if (\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1)
		{
			\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1.SetActive(\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4);
		}
	}

	private static void \u02BE\u02B3\u02BE\u02B9\u02C0\u02B2\u02B9\u02B8\u02BF\u02BF\u02B2(GameObject \u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1, bool \u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4)
	{
		if (\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1)
		{
			\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1.SetActive(\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4);
		}
	}

	private void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer.playerProfile != null && !chplayer.playerProfile.isRemotePlayer)
			{
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = chplayer.playerProfile.controllerType.GetControllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = chplayer.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
			}
		}
	}

	private static void \u02B6\u02B5\u02C0\u02BD\u02BF\u02BC\u02B2\u02BF\u02BD\u02BF\u02BE(GameObject \u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1, bool \u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4)
	{
		if (\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1)
		{
			\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1.SetActive(\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4);
		}
	}

	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer.playerProfile != null && !chplayer.playerProfile.isRemotePlayer)
			{
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = chplayer.playerProfile.controllerType.GetControllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = chplayer.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
			}
		}
	}

	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer.playerProfile != null && !chplayer.playerProfile.isRemotePlayer && chplayer.player.GetAnyButton())
			{
				controllerType = chplayer.playerProfile.controllerType.GetControllerType;
				flag = chplayer.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
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

	private void Update()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer.playerProfile != null && !chplayer.playerProfile.isRemotePlayer && chplayer.player.GetAnyButton())
			{
				controllerType = chplayer.playerProfile.controllerType.GetControllerType;
				flag = chplayer.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
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

	private void \u02B9\u02B5\u02B2\u02BB\u02B5\u02B3\u02B9\u02BC\u02BF\u02B5\u02BA()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer.playerProfile != null && !chplayer.playerProfile.isRemotePlayer && chplayer.player.GetAnyButton())
			{
				controllerType = chplayer.playerProfile.controllerType.GetControllerType;
				flag = chplayer.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
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

	private void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer.playerProfile != null && !chplayer.playerProfile.isRemotePlayer)
			{
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = chplayer.playerProfile.controllerType.GetControllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = chplayer.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
			}
		}
	}

	private static void \u02B3\u02B8\u02B6\u02B9\u02B2\u02B2\u02B7\u02B4\u02BF\u02B9\u02B4(GameObject \u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1, bool \u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4)
	{
		if (\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1)
		{
			\u02B3\u02B5\u02BF\u02BA\u02C0\u02B9\u02B6\u02BF\u02BE\u02B6\u02C1.SetActive(\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4);
		}
	}

	private void \u02C0\u02BB\u02B6\u02B9\u02B3\u02B4\u02B3\u02B7\u02BD\u02B8\u02C0()
	{
		ControllerType controllerType = this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;
		bool flag = this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer.playerProfile != null && !chplayer.playerProfile.isRemotePlayer && chplayer.player.GetAnyButton())
			{
				controllerType = chplayer.playerProfile.controllerType.GetControllerType;
				flag = chplayer.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
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

	private void \u02B4\u02B2\u02B5\u02BA\u02B4\u02C0\u02BC\u02BB\u02C1\u02B9\u02BD()
	{
		foreach (CHPlayer chplayer in GlobalVariables.instance.playerList)
		{
			if (chplayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && chplayer.playerProfile != null && !chplayer.playerProfile.isRemotePlayer)
			{
				this.\u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0 = chplayer.playerProfile.controllerType.GetControllerType;
				this.\u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6 = chplayer.playerProfile.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3;
			}
		}
	}

	[SerializeField]
	private GameObject yellowTip;

	[SerializeField]
	private GameObject blueTip;

	[SerializeField]
	private GameObject orangeTip;

	[SerializeField]
	private GameObject selectTip;

	[SerializeField]
	private GameObject drumOrangeTip;

	private ControllerType \u02B8\u02BD\u02C1\u02B9\u02BC\u02B7\u02B8\u02B7\u02B9\u02BA\u02C0;

	private bool \u02B6\u02BB\u02BE\u02C0\u02BB\u02BB\u02B3\u02BC\u02B8\u02B9\u02B6;
}
