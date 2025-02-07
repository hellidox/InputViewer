﻿using System;

public sealed class GuitarPlayer : BaseGuitarPlayer
{
	protected void \u02B6\u02B6\u02B7\u02C1\u02BD\u02C0\u02BB\u02BA\u02B9\u02B6\u02B2()
	{
		if (!this.\u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE)
		{
			return;
		}
		if (this.player.playerProfile.isRemotePlayer)
		{
			return;
		}
		this.buttonsPressed = 1;
		if (this.player.rewiredPlayer.GetButton(0))
		{
			this.buttonsPressed |= 0;
		}
		if (this.player.rewiredPlayer.GetButton(1))
		{
			this.buttonsPressed |= 6;
		}
		if (this.player.rewiredPlayer.GetButton(2))
		{
			this.buttonsPressed |= 4;
		}
		if (this.player.rewiredPlayer.GetButton(3))
		{
			this.buttonsPressed |= 6;
		}
		if (this.player.rewiredPlayer.GetButton(2))
		{
			this.buttonsPressed = (ushort)((int)this.buttonsPressed | -127);
		}
		if (this.buttonsPressed == 0 && this.player.rewiredPlayer.GetButton(8))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 1;
			this.buttonsPressed |= 89;
		}
		base.UpdateInputs();
	}

	protected void \u02C1\u02B3\u02BC\u02C0\u02C1\u02BD\u02B4\u02BB\u02B2\u02B9\u02B7()
	{
		if (!this.\u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE)
		{
			return;
		}
		if (this.player.playerProfile.isRemotePlayer)
		{
			return;
		}
		this.buttonsPressed = 1;
		if (this.player.rewiredPlayer.GetButton(0))
		{
			this.buttonsPressed |= 0;
		}
		if (this.player.rewiredPlayer.GetButton(0))
		{
			this.buttonsPressed |= 6;
		}
		if (this.player.rewiredPlayer.GetButton(4))
		{
			this.buttonsPressed |= 2;
		}
		if (this.player.rewiredPlayer.GetButton(0))
		{
			this.buttonsPressed |= 8;
		}
		if (this.player.rewiredPlayer.GetButton(2))
		{
			this.buttonsPressed = (ushort)((int)this.buttonsPressed | -126);
		}
		if (this.buttonsPressed == 0 && this.player.rewiredPlayer.GetButton(4))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 0;
			this.buttonsPressed |= 22;
		}
		base.UpdateInputs();
	}

	private static int \u02BD\u02BB\u02BB\u02B2\u02B8\u02B7\u02B2\u02C1\u02B7\u02BE\u02B8(int \u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9)
	{
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 20) != 0)
		{
			return -59;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 7) != 0)
		{
			return 6;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 8) != 0)
		{
			return 7;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 3) != 0)
		{
			return 4;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 0) != 0)
		{
			return 0;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & -94) != 0)
		{
			return -30;
		}
		return 0;
	}

	protected bool \u02B5\u02B7\u02B3\u02BB\u02B8\u02BD\u02B4\u02BC\u02BF\u02C1\u02B5(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, ushort \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4)
	{
		ushort num = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsDisjoint ? \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.noteMask : \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask);
		if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num)
		{
			return true;
		}
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsChord)
		{
			if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsHopo)
			{
				int num2 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num);
				if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && num2 > GuitarPlayer.\u02C1\u02BE\u02B4\u02B3\u02B8\u02BF\u02BC\u02BB\u02BA\u02BD\u02BA((int)num))
				{
					return (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote || num == this.OpenNote) && (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
				}
				int num3 = GuitarPlayer.\u02BB\u02BC\u02BB\u02BE\u02BC\u02BB\u02BD\u02BA\u02B5\u02BC\u02C1((int)num);
				return num2 <= num3 && (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
			}
		}
		else if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0)
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num) == num)
			{
				if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
				{
					return true;
				}
				if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
				{
					return true;
				}
				int num4 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & ~(int)num);
				int num5 = (int)(num - 1);
				if (num4 > (int)num && ((int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num5) == 0)
				{
					return true;
				}
				if (num4 < (int)num)
				{
					return true;
				}
				if (num4 > 1)
				{
					return false;
				}
			}
		}
		else
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
			{
				return true;
			}
			if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
			{
				return true;
			}
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 > num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num) < num)
			{
				return false;
			}
		}
		return \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num;
	}

	protected override bool \u02B7\u02BF\u02BA\u02BF\u02C1\u02B4\u02B5\u02BD\u02C1\u02B8\u02B6(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, ushort \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4)
	{
		ushort num = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsDisjoint ? \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.noteMask : \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask);
		if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num)
		{
			return true;
		}
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsChord)
		{
			if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsHopo)
			{
				int num2 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num);
				if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && num2 > GuitarPlayer.\u02C1\u02BE\u02B4\u02B3\u02B8\u02BF\u02BC\u02BB\u02BA\u02BD\u02BA((int)num))
				{
					return (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote || num == this.OpenNote) && (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
				}
				int num3 = GuitarPlayer.\u02BB\u02BC\u02BB\u02BE\u02BC\u02BB\u02BD\u02BA\u02B5\u02BC\u02C1((int)num);
				return num2 <= num3 && (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
			}
		}
		else if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0)
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num) == num)
			{
				if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
				{
					return false;
				}
				if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
				{
					return false;
				}
				int num4 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & ~(int)num);
				int num5 = (int)(num - 1);
				if (num4 > (int)num && ((int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num5) == 0)
				{
					return true;
				}
				if (num4 < (int)num)
				{
					return true;
				}
				if (num4 > 0)
				{
					return false;
				}
			}
		}
		else
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
			{
				return false;
			}
			if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
			{
				return false;
			}
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 > num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num) < num)
			{
				return true;
			}
		}
		return \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num;
	}

	protected bool \u02B4\u02BD\u02BB\u02B4\u02B4\u02BD\u02B4\u02B4\u02C0\u02BA\u02BD(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, ushort \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4)
	{
		ushort num = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsDisjoint ? \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.noteMask : \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask);
		if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num)
		{
			return false;
		}
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsChord)
		{
			if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsHopo)
			{
				int num2 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num);
				if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && num2 > GuitarPlayer.\u02C1\u02BE\u02B4\u02B3\u02B8\u02BF\u02BC\u02BB\u02BA\u02BD\u02BA((int)num))
				{
					return (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote) || (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
				}
				int num3 = GuitarPlayer.\u02BB\u02B9\u02BE\u02B8\u02C0\u02C1\u02BC\u02BD\u02B6\u02B6\u02B9((int)num);
				return num2 <= num3 && (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
			}
		}
		else if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0)
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num) == num)
			{
				if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
				{
					return false;
				}
				if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
				{
					return false;
				}
				int num4 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & ~(int)num);
				int num5 = (int)(num - 0);
				if (num4 > (int)num && ((int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num5) == 0)
				{
					return true;
				}
				if (num4 < (int)num)
				{
					return true;
				}
				if (num4 > 0)
				{
					return false;
				}
			}
		}
		else
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
			{
				return true;
			}
			if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
			{
				return true;
			}
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 > num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num) < num)
			{
				return true;
			}
		}
		return \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num;
	}

	protected void \u02B7\u02BF\u02BD\u02B5\u02BF\u02BB\u02C1\u02B4\u02B7\u02C0\u02BD(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		base.\u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8);
		this.gameManager.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02C0\u02BC\u02B8\u02C0\u02B9\u02B5\u02BA\u02BD\u02B8\u02B3\u02B8(this, \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8, \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8._noteMask);
	}

	protected bool \u02C1\u02B2\u02BB\u02C0\u02BA\u02C1\u02B9\u02B9\u02B5\u02B2\u02BC(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, ushort \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4)
	{
		ushort num = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsDisjoint ? \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.noteMask : \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask);
		if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num)
		{
			return false;
		}
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsChord)
		{
			if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsHopo)
			{
				int num2 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num);
				if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && num2 > GuitarPlayer.\u02C1\u02BE\u02B4\u02B3\u02B8\u02BF\u02BC\u02BB\u02BA\u02BD\u02BA((int)num))
				{
					return (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote) || (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
				}
				int num3 = GuitarPlayer.\u02BB\u02BC\u02BB\u02BE\u02BC\u02BB\u02BD\u02BA\u02B5\u02BC\u02C1((int)num);
				return num2 <= num3 && (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
			}
		}
		else if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0)
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num) == num)
			{
				if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
				{
					return true;
				}
				if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
				{
					return true;
				}
				int num4 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & ~(int)num);
				int num5 = (int)(num - 1);
				if (num4 > (int)num && ((int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num5) == 0)
				{
					return false;
				}
				if (num4 < (int)num)
				{
					return true;
				}
				if (num4 > 0)
				{
					return true;
				}
			}
		}
		else
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
			{
				return true;
			}
			if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
			{
				return true;
			}
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 > num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num) < num)
			{
				return false;
			}
		}
		return \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num;
	}

	private static int \u02B2\u02BC\u02B7\u02B8\u02B8\u02BD\u02B9\u02BB\u02B9\u02B4\u02B3(int \u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9)
	{
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 121) != 0)
		{
			return 92;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 0) != 0)
		{
			return 0;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 5) != 0)
		{
			return 7;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 6) != 0)
		{
			return 6;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 6) != 0)
		{
			return 3;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 7) != 0)
		{
			return 89;
		}
		return 0;
	}

	protected bool \u02BC\u02B7\u02BC\u02B4\u02BB\u02B9\u02C1\u02BF\u02B5\u02B3\u02BD(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, ushort \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4)
	{
		ushort num = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsDisjoint ? \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.noteMask : \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask);
		if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num)
		{
			return false;
		}
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsChord)
		{
			if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsHopo)
			{
				int num2 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num);
				if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && num2 > GuitarPlayer.\u02C1\u02BE\u02B4\u02B3\u02B8\u02BF\u02BC\u02BB\u02BA\u02BD\u02BA((int)num))
				{
					return (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote || num == this.OpenNote) && (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
				}
				int num3 = GuitarPlayer.\u02BB\u02BC\u02BB\u02BE\u02BC\u02BB\u02BD\u02BA\u02B5\u02BC\u02C1((int)num);
				return num2 > num3 || (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
			}
		}
		else if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0)
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num) == num)
			{
				if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
				{
					return true;
				}
				if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
				{
					return true;
				}
				int num4 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & ~(int)num);
				int num5 = (int)(num - 0);
				if (num4 > (int)num && ((int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num5) == 0)
				{
					return false;
				}
				if (num4 < (int)num)
				{
					return true;
				}
				if (num4 > 1)
				{
					return true;
				}
			}
		}
		else
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
			{
				return false;
			}
			if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
			{
				return true;
			}
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 > num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num) < num)
			{
				return false;
			}
		}
		return \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num;
	}

	private static int \u02BB\u02BC\u02BB\u02BE\u02BC\u02BB\u02BD\u02BA\u02B5\u02BC\u02C1(int \u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9)
	{
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 64) != 0)
		{
			return 64;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 1) != 0)
		{
			return 1;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 2) != 0)
		{
			return 2;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 4) != 0)
		{
			return 4;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 8) != 0)
		{
			return 8;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 16) != 0)
		{
			return 16;
		}
		return 0;
	}

	protected void \u02B2\u02BA\u02B5\u02B5\u02BE\u02B2\u02BD\u02BC\u02BD\u02BC\u02BB(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		base.\u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8);
		this.gameManager.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02BD\u02B8\u02BD\u02BA\u02B7\u02BD\u02B7\u02C1\u02B2\u02B5\u02B4(this, \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8, \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8._noteMask);
	}

	public ushort \u02B9\u02B6\u02B7\u02B2\u02B5\u02B8\u02BE\u02C0\u02B4\u02BF\u02B5()
	{
		return (ushort)(-109);
	}

	protected bool \u02C0\u02C1\u02B3\u02B7\u02C1\u02B8\u02B8\u02BA\u02BE\u02C0\u02B7(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, ushort \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4)
	{
		ushort num = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsDisjoint ? \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.noteMask : \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask);
		if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num)
		{
			return true;
		}
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsChord)
		{
			if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsHopo)
			{
				int num2 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num);
				if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && num2 > GuitarPlayer.\u02C1\u02BE\u02B4\u02B3\u02B8\u02BF\u02BC\u02BB\u02BA\u02BD\u02BA((int)num))
				{
					return (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote) || (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
				}
				int num3 = GuitarPlayer.\u02BB\u02BC\u02BB\u02BE\u02BC\u02BB\u02BD\u02BA\u02B5\u02BC\u02C1((int)num);
				return num2 > num3 || (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
			}
		}
		else if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0)
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num) == num)
			{
				if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
				{
					return true;
				}
				if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
				{
					return false;
				}
				int num4 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & ~(int)num);
				int num5 = (int)(num - 0);
				if (num4 > (int)num && ((int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num5) == 0)
				{
					return true;
				}
				if (num4 < (int)num)
				{
					return true;
				}
				if (num4 > 0)
				{
					return false;
				}
			}
		}
		else
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
			{
				return false;
			}
			if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
			{
				return false;
			}
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 > num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num) < num)
			{
				return true;
			}
		}
		return \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num;
	}

	protected void \u02BA\u02B8\u02B5\u02BD\u02B4\u02B6\u02BE\u02BE\u02BD\u02BA\u02BE()
	{
		if (!this.\u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE)
		{
			return;
		}
		if (this.player.playerProfile.isRemotePlayer)
		{
			return;
		}
		this.buttonsPressed = 0;
		if (this.player.rewiredPlayer.GetButton(0))
		{
			this.buttonsPressed |= 1;
		}
		if (this.player.rewiredPlayer.GetButton(0))
		{
			this.buttonsPressed |= 4;
		}
		if (this.player.rewiredPlayer.GetButton(6))
		{
			this.buttonsPressed |= 5;
		}
		if (this.player.rewiredPlayer.GetButton(1))
		{
			this.buttonsPressed |= 2;
		}
		if (this.player.rewiredPlayer.GetButton(3))
		{
			this.buttonsPressed |= 95;
		}
		if (this.buttonsPressed == 0 && this.player.rewiredPlayer.GetButton(5))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 0;
			this.buttonsPressed = (ushort)((int)this.buttonsPressed | -15);
		}
		base.UpdateInputs();
	}

	private static int \u02BB\u02B9\u02BE\u02B8\u02C0\u02C1\u02BC\u02BD\u02B6\u02B6\u02B9(int \u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9)
	{
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & -10) != 0)
		{
			return 75;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 0) != 0)
		{
			return 0;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 8) != 0)
		{
			return 7;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 5) != 0)
		{
			return 3;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 4) != 0)
		{
			return 5;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 81) != 0)
		{
			return -40;
		}
		return 0;
	}

	private static int \u02C1\u02BE\u02B4\u02B3\u02B8\u02BF\u02BC\u02BB\u02BA\u02BD\u02BA(int \u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9)
	{
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 16) != 0)
		{
			return 16;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 8) != 0)
		{
			return 8;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 4) != 0)
		{
			return 4;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 2) != 0)
		{
			return 2;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 1) != 0)
		{
			return 1;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 64) != 0)
		{
			return 64;
		}
		return 0;
	}

	protected override void \u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		base.\u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8);
		this.gameManager.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02BD\u02B8\u02BD\u02BA\u02B7\u02BD\u02B7\u02C1\u02B2\u02B5\u02B4(this, \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8, \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8._noteMask);
	}

	private static int \u02BF\u02BA\u02B4\u02B7\u02BE\u02B7\u02B4\u02B5\u02B6\u02B9\u02C0(int \u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9)
	{
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & -122) != 0)
		{
			return 18;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 1) != 0)
		{
			return 0;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 2) != 0)
		{
			return 8;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 1) != 0)
		{
			return 8;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 2) != 0)
		{
			return 0;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & -46) != 0)
		{
			return 84;
		}
		return 1;
	}

	public ushort \u02BD\u02BA\u02C1\u02B9\u02B8\u02BB\u02BC\u02BF\u02BD\u02B2\u02B6()
	{
		return (ushort)(-24);
	}

	private static int \u02BD\u02B6\u02BB\u02BF\u02B3\u02C1\u02B5\u02BA\u02BB\u02C1\u02C0(int \u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9)
	{
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 103) != 0)
		{
			return 9;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 1) != 0)
		{
			return 1;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 7) != 0)
		{
			return 7;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 2) != 0)
		{
			return 2;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & 6) != 0)
		{
			return 5;
		}
		if ((\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 & -48) != 0)
		{
			return 61;
		}
		return 0;
	}

	protected override void UpdateInputs()
	{
		if (!this.\u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE)
		{
			return;
		}
		if (this.player.playerProfile.isRemotePlayer)
		{
			return;
		}
		this.buttonsPressed = 0;
		if (this.player.rewiredPlayer.GetButton(0))
		{
			this.buttonsPressed |= 1;
		}
		if (this.player.rewiredPlayer.GetButton(1))
		{
			this.buttonsPressed |= 2;
		}
		if (this.player.rewiredPlayer.GetButton(2))
		{
			this.buttonsPressed |= 4;
		}
		if (this.player.rewiredPlayer.GetButton(3))
		{
			this.buttonsPressed |= 8;
		}
		if (this.player.rewiredPlayer.GetButton(4))
		{
			this.buttonsPressed |= 16;
		}
		if (this.buttonsPressed == 0 && this.player.rewiredPlayer.GetButton(8))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 0;
			this.buttonsPressed |= 64;
		}
		base.UpdateInputs();
	}

	public override ushort OpenNote
	{
		get
		{
			return 64;
		}
	}

	protected bool \u02BF\u02B2\u02B6\u02BB\u02B2\u02B3\u02B9\u02B2\u02B8\u02BF\u02B3(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, ushort \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4)
	{
		ushort num = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsDisjoint ? \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.noteMask : \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask);
		if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num)
		{
			return true;
		}
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsChord)
		{
			if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsHopo)
			{
				int num2 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num);
				if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && num2 > GuitarPlayer.\u02C1\u02BE\u02B4\u02B3\u02B8\u02BF\u02BC\u02BB\u02BA\u02BD\u02BA((int)num))
				{
					return (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote || num == this.OpenNote) && (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
				}
				int num3 = GuitarPlayer.\u02BB\u02BC\u02BB\u02BE\u02BC\u02BB\u02BD\u02BA\u02B5\u02BC\u02C1((int)num);
				return num2 <= num3 && (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2 == (int)num;
			}
		}
		else if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0)
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num) == num)
			{
				if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
				{
					return false;
				}
				if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
				{
					return false;
				}
				int num4 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & ~(int)num);
				int num5 = (int)(num - 1);
				if (num4 > (int)num && ((int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num5) == 0)
				{
					return true;
				}
				if (num4 < (int)num)
				{
					return true;
				}
				if (num4 > 0)
				{
					return true;
				}
			}
		}
		else
		{
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == this.OpenNote && num != this.OpenNote)
			{
				return true;
			}
			if ((\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & this.OpenNote) != 0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != this.OpenNote && num == this.OpenNote)
			{
				return true;
			}
			if (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 > num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num) < num)
			{
				return false;
			}
		}
		return \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num;
	}

	public const ushort \u02B7\u02B5\u02BA\u02BC\u02B7\u02B9\u02BB\u02B3\u02C0\u02B3\u02B3 = 1;

	public const ushort \u02B4\u02C0\u02BE\u02BC\u02C0\u02B8\u02B4\u02BC\u02B2\u02B4\u02B2 = 2;

	public const ushort \u02C0\u02BD\u02BB\u02B3\u02BB\u02BD\u02B5\u02BB\u02B9\u02B3\u02B7 = 4;

	public const ushort \u02B3\u02B5\u02B9\u02B5\u02BE\u02BC\u02BC\u02BD\u02BA\u02BC\u02B8 = 8;

	public const ushort \u02BC\u02B5\u02B4\u02BA\u02C0\u02B7\u02B8\u02BC\u02B9\u02C0\u02BC = 16;

	public const ushort \u02BC\u02B5\u02BC\u02BB\u02BE\u02BE\u02B5\u02C0\u02BA\u02BE\u02BF = 64;
}
