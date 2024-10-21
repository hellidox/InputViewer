using System;
using Rewired;
using StrikeCore;

// Token: 0x02000161 RID: 353
public class \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6
{
	// Token: 0x06000F94 RID: 3988 RVA: 0x00082BD8 File Offset: 0x00080DD8
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
			for (int i = 1; i < GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.Count; i += 0)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i] != null && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].rewiredPlayer == player)
				{
					GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BD\u02B8\u02BD\u02B6\u02B4\u02B6\u02C1\u02B9\u02BD\u02BC\u02B4 = true;
					return;
				}
			}
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0000E932 File Offset: 0x0000CB32
	public bool \u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD
	{
		get
		{
			if (this.rewiredPlayer == null)
			{
				\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B = this.playerInfo;
				return u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B != null && u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.isRemotePlayer;
			}
			return true;
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000F96 RID: 3990 RVA: 0x0000E94F File Offset: 0x0000CB4F
	public bool \u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4
	{
		get
		{
			return this.playerInfo.isRemotePlayer;
		}
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x0000E94F File Offset: 0x0000CB4F
	public bool \u02BF\u02B9\u02B2\u02B8\u02BB\u02BB\u02BC\u02B5\u02B8\u02B5\u02C0()
	{
		return this.playerInfo.isRemotePlayer;
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x0000E94F File Offset: 0x0000CB4F
	public bool \u02B4\u02BD\u02BE\u02B2\u02BD\u02B4\u02B8\u02BE\u02B9\u02B6\u02B7()
	{
		return this.playerInfo.isRemotePlayer;
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06000F99 RID: 3993 RVA: 0x0000E95C File Offset: 0x0000CB5C
	public PlayerStats \u02B6\u02B2\u02B4\u02B9\u02B8\u02BD\u02B3\u02C1\u02B4\u02BE\u02BA
	{
		get
		{
			return \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		}
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x0000E96A File Offset: 0x0000CB6A
	public global::StrikeCore.ControllerType \u02BF\u02B2\u02B3\u02BC\u02BA\u02B6\u02B7\u02BE\u02BB\u02B9\u02C1()
	{
		return this.playerInfo.controllerType.GetControllerType;
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x00082C80 File Offset: 0x00080E80
	public bool \u02B7\u02B9\u02B8\u02B2\u02B8\u02B8\u02BF\u02B2\u02B7\u02BB\u02BA()
	{
		if (this.\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4)
		{
			return false;
		}
		bool firstButtonMapWithAction = this.rewiredPlayer.controllers.maps.GetFirstButtonMapWithAction(global::Rewired.ControllerType.Joystick, 40, true) != null;
		ActionElementMap firstButtonMapWithAction2 = this.rewiredPlayer.controllers.maps.GetFirstButtonMapWithAction(global::Rewired.ControllerType.Joystick, 41, true);
		ActionElementMap firstButtonMapWithAction3 = this.rewiredPlayer.controllers.maps.GetFirstButtonMapWithAction(global::Rewired.ControllerType.Joystick, 42, true);
		ActionElementMap firstButtonMapWithAction4 = this.rewiredPlayer.controllers.maps.GetFirstButtonMapWithAction(global::Rewired.ControllerType.Joystick, 43, true);
		return firstButtonMapWithAction && firstButtonMapWithAction2 != null && firstButtonMapWithAction3 != null && firstButtonMapWithAction4 != null && this.playerInfo.\u02BA\u02C0\u02BC\u02BB\u02B7\u02B3\u02B8\u02BA\u02B2\u02B9\u02BA == -1;
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x0000E94F File Offset: 0x0000CB4F
	public bool \u02B8\u02C0\u02BB\u02C0\u02BB\u02BB\u02BE\u02B3\u02BD\u02B2\u02B6()
	{
		return this.playerInfo.isRemotePlayer;
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x00082D20 File Offset: 0x00080F20
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
			for (int i = 0; i < GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.Count; i++)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i] != null && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].rewiredPlayer == player)
				{
					GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BD\u02B8\u02BD\u02B6\u02B4\u02B6\u02C1\u02B9\u02BD\u02BC\u02B4 = true;
					return;
				}
			}
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06000F9E RID: 3998 RVA: 0x0000E96A File Offset: 0x0000CB6A
	public global::StrikeCore.ControllerType \u02B6\u02B9\u02B7\u02B9\u02B6\u02C1\u02B2\u02BD\u02BF\u02BF\u02BD
	{
		get
		{
			return this.playerInfo.controllerType.GetControllerType;
		}
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x0000E97C File Offset: 0x0000CB7C
	public void \u02C0\u02B9\u02B5\u02BF\u02B5\u02B6\u02B3\u02B7\u02B9\u02C1\u02BC()
	{
		this.rewiredPlayer.isPlaying = false;
		this.rewiredPlayer = null;
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x00082DC8 File Offset: 0x00080FC8
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
			for (int i = 1; i < GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.Count; i++)
			{
				if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i] != null && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].rewiredPlayer == player)
				{
					GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BD\u02B8\u02BD\u02B6\u02B4\u02B6\u02C1\u02B9\u02BD\u02BC\u02B4 = true;
					return;
				}
			}
		}
	}

	// Token: 0x04000C13 RID: 3091
	public \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 playerInfo;

	// Token: 0x04000C14 RID: 3092
	public Player rewiredPlayer;

	// Token: 0x04000C15 RID: 3093
	public PlayerProfileMenu \u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC;

	// Token: 0x04000C16 RID: 3094
	public int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7;

	// Token: 0x04000C17 RID: 3095
	public bool \u02BB\u02B6\u02BD\u02B9\u02C0\u02BE\u02BC\u02B4\u02C1\u02C1\u02BD;

	// Token: 0x04000C18 RID: 3096
	public bool \u02BD\u02B8\u02BD\u02B6\u02B4\u02B6\u02C1\u02B9\u02BD\u02BC\u02B4;
}
