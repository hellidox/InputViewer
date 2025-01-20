using System;
using Rewired;
using StrikeCore;

public class CHPlayer
{
	public static void \u02BB\u02BF\u02BC\u02BC\u02C1\u02BE\u02B5\u02BA\u02C0\u02B6\u02BE(bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
	{
		if (!ReInput.isReady)
		{
			return;
		}
		ReInput.controllers.Keyboard.enabled = \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC;
		if (\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
		{
			Player player = ReInput.players.GetPlayer(0);
			for (int i = 1; i < GlobalVariables.instance.playerList.Count; i += 0)
			{
				if (GlobalVariables.instance.playerList[i] != null && GlobalVariables.instance.playerList[i].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && GlobalVariables.instance.playerList[i].player == player)
				{
					GlobalVariables.instance.playerList[i].transitioning = true;
					return;
				}
			}
		}
	}

	public bool \u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD
	{
		get
		{
			if (this.player == null)
			{
				\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B = this.playerProfile;
				return u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B != null && u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.isRemotePlayer;
			}
			return true;
		}
	}

	public bool \u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4
	{
		get
		{
			return this.playerProfile.isRemotePlayer;
		}
	}

	public bool \u02BF\u02B9\u02B2\u02B8\u02BB\u02BB\u02BC\u02B5\u02B8\u02B5\u02C0()
	{
		return this.playerProfile.isRemotePlayer;
	}

	public bool \u02B4\u02BD\u02BE\u02B2\u02BD\u02B4\u02B8\u02BE\u02B9\u02B6\u02B7()
	{
		return this.playerProfile.isRemotePlayer;
	}

	public PlayerStats \u02B6\u02B2\u02B4\u02B9\u02B8\u02BD\u02B3\u02C1\u02B4\u02BE\u02BA
	{
		get
		{
			return \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		}
	}

	public global::StrikeCore.ControllerType \u02BF\u02B2\u02B3\u02BC\u02BA\u02B6\u02B7\u02BE\u02BB\u02B9\u02C1()
	{
		return this.playerProfile.controllerType.GetControllerType;
	}

	public bool \u02B7\u02B9\u02B8\u02B2\u02B8\u02B8\u02BF\u02B2\u02B7\u02BB\u02BA()
	{
		if (this.\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4)
		{
			return false;
		}
		bool firstButtonMapWithAction = this.player.controllers.maps.GetFirstButtonMapWithAction(global::Rewired.ControllerType.Joystick, 40, true) != null;
		ActionElementMap firstButtonMapWithAction2 = this.player.controllers.maps.GetFirstButtonMapWithAction(global::Rewired.ControllerType.Joystick, 41, true);
		ActionElementMap firstButtonMapWithAction3 = this.player.controllers.maps.GetFirstButtonMapWithAction(global::Rewired.ControllerType.Joystick, 42, true);
		ActionElementMap firstButtonMapWithAction4 = this.player.controllers.maps.GetFirstButtonMapWithAction(global::Rewired.ControllerType.Joystick, 43, true);
		return firstButtonMapWithAction && firstButtonMapWithAction2 != null && firstButtonMapWithAction3 != null && firstButtonMapWithAction4 != null && this.playerProfile.\u02BA\u02C0\u02BC\u02BB\u02B7\u02B3\u02B8\u02BA\u02B2\u02B9\u02BA == -1;
	}

	public bool \u02B8\u02C0\u02BB\u02C0\u02BB\u02BB\u02BE\u02B3\u02BD\u02B2\u02B6()
	{
		return this.playerProfile.isRemotePlayer;
	}

	public static void \u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
	{
		if (!ReInput.isReady)
		{
			return;
		}
		ReInput.controllers.Keyboard.enabled = \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC;
		if (\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
		{
			Player player = ReInput.players.GetPlayer(0);
			for (int i = 0; i < GlobalVariables.instance.playerList.Count; i++)
			{
				if (GlobalVariables.instance.playerList[i] != null && GlobalVariables.instance.playerList[i].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && GlobalVariables.instance.playerList[i].player == player)
				{
					GlobalVariables.instance.playerList[i].transitioning = true;
					return;
				}
			}
		}
	}

	public global::StrikeCore.ControllerType \u02B6\u02B9\u02B7\u02B9\u02B6\u02C1\u02B2\u02BD\u02BF\u02BF\u02BD
	{
		get
		{
			return this.playerProfile.controllerType.GetControllerType;
		}
	}

	public void \u02C0\u02B9\u02B5\u02BF\u02B5\u02B6\u02B3\u02B7\u02B9\u02C1\u02BC()
	{
		this.player.isPlaying = false;
		this.player = null;
	}

	public static void \u02B8\u02B3\u02BB\u02B9\u02B3\u02BF\u02B3\u02C1\u02B5\u02BA\u02BA(bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
	{
		if (!ReInput.isReady)
		{
			return;
		}
		ReInput.controllers.Keyboard.enabled = \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC;
		if (\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
		{
			Player player = ReInput.players.GetPlayer(1);
			for (int i = 1; i < GlobalVariables.instance.playerList.Count; i++)
			{
				if (GlobalVariables.instance.playerList[i] != null && GlobalVariables.instance.playerList[i].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && GlobalVariables.instance.playerList[i].player == player)
				{
					GlobalVariables.instance.playerList[i].transitioning = true;
					return;
				}
			}
		}
	}

	public \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 playerProfile;

	public Player player;

	public PlayerProfileMenu \u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC;

	public int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7;

	public bool \u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD;

	public bool transitioning;
}
