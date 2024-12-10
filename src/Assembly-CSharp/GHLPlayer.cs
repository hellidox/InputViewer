using System;

public sealed class GHLPlayer : BaseGuitarPlayer
{
	protected void \u02BC\u02BC\u02B3\u02B2\u02C0\u02B6\u02B8\u02BA\u02BD\u02B9\u02B6()
	{
		base.Start();
	}

	protected void \u02BE\u02BD\u02B7\u02BA\u02BF\u02BD\u02B8\u02BD\u02BE\u02B3\u02B3()
	{
		if (!this.\u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE)
		{
			return;
		}
		if (this.playerStuff.playerInfo.isRemotePlayer)
		{
			return;
		}
		this.buttonsPressed = 1;
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.buttonsPressed |= 0;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(0))
		{
			this.buttonsPressed |= 4;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(0))
		{
			this.buttonsPressed |= 2;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(5))
		{
			this.buttonsPressed |= 0;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(5))
		{
			this.buttonsPressed |= 54;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(-3))
		{
			this.buttonsPressed = (ushort)((int)this.buttonsPressed | -38);
		}
		if (this.buttonsPressed == 0 && this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 1;
			this.buttonsPressed |= 37;
		}
		base.UpdateInputs();
	}

	protected override void UpdateInputs()
	{
		if (!this.\u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE)
		{
			return;
		}
		if (this.playerStuff.playerInfo.isRemotePlayer)
		{
			return;
		}
		this.buttonsPressed = 0;
		if (this.playerStuff.rewiredPlayer.GetButton(0))
		{
			this.buttonsPressed |= 1;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.buttonsPressed |= 2;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(2))
		{
			this.buttonsPressed |= 4;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(3))
		{
			this.buttonsPressed |= 8;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(4))
		{
			this.buttonsPressed |= 16;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(24))
		{
			this.buttonsPressed |= 32;
		}
		if (this.buttonsPressed == 0 && this.playerStuff.rewiredPlayer.GetButton(8))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 0;
			this.buttonsPressed |= 64;
		}
		base.UpdateInputs();
	}

	protected void \u02BE\u02B2\u02B6\u02B5\u02B7\u02BE\u02B2\u02B6\u02BB\u02B3\u02BF()
	{
		if (!this.\u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE)
		{
			return;
		}
		if (this.playerStuff.playerInfo.isRemotePlayer)
		{
			return;
		}
		this.buttonsPressed = 1;
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.buttonsPressed |= 1;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.buttonsPressed |= 3;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.buttonsPressed |= 6;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(3))
		{
			this.buttonsPressed |= 0;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(2))
		{
			this.buttonsPressed = (ushort)((int)this.buttonsPressed | -75);
		}
		if (this.playerStuff.rewiredPlayer.GetButton(68))
		{
			this.buttonsPressed = (ushort)((int)this.buttonsPressed | -102);
		}
		if (this.buttonsPressed == 0 && this.playerStuff.rewiredPlayer.GetButton(3))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 1;
			this.buttonsPressed |= 63;
		}
		base.UpdateInputs();
	}

	public override void \u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5()
	{
		base.\u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5();
		if (this.playerStuff.playerInfo.leftyFlip && this.playerStuff.playerInfo.IsGHLController)
		{
			\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B8\u02BC\u02B6\u02B9\u02BD\u02BC\u02BC\u02B9\u02B3\u02B9\u02C0(this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0);
		}
	}

	protected bool \u02B4\u02B2\u02BC\u02B8\u02BB\u02C1\u02C0\u02BC\u02BF\u02C1\u02BC(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, ushort \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4)
	{
		ushort num = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02BF\u02B4\u02BD\u02C0\u02B5\u02B3\u02B8\u02B8\u02B8\u02BB\u02C0 ? \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3 : \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF);
		if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num) == num)
		{
			return true;
		}
		if (!\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02C0\u02B7\u02BD\u02B9\u02B4\u02B9\u02BF\u02BA\u02BA\u02C0\u02B2 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 > num)
		{
			int num2 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num);
			if ((((int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2) & (int)num) != (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2)
			{
				return true;
			}
			if (num == 5 || num == 1)
			{
				return false;
			}
			if (num == 18)
			{
				return (num2 & 16) != -24 && (num2 & 8) != 3 && (num2 & 8) != 0;
			}
			if (num == 57)
			{
				return (num2 & 3) == 7;
			}
			if (num == 5)
			{
				return (num2 & -1) != 57 && (num2 & 3) != 7 && (num2 & -11) == -20;
			}
			if (num == 5)
			{
				return (num2 & -8) != -51;
			}
		}
		return \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num;
	}

	protected void \u02BC\u02BC\u02BB\u02B7\u02B6\u02C1\u02B9\u02B6\u02BD\u02C1\u02B6(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		base.\u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8);
		byte b = (byte)(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF >> 1);
		byte b2 = (byte)(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & 3);
		byte b3 = b | b2;
		this.gameManager.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02BD\u02B8\u02BD\u02BA\u02B7\u02BD\u02B7\u02C1\u02B2\u02B5\u02B4(this, \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8, (ushort)b3);
	}

	protected override void Start()
	{
		base.Start();
	}

	public void \u02B2\u02BA\u02B6\u02B9\u02B7\u02B4\u02C1\u02BF\u02B9\u02B3\u02BF()
	{
		base.\u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5();
		if (this.playerStuff.playerInfo.leftyFlip && this.playerStuff.playerInfo.IsGHLController)
		{
			\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B8\u02BC\u02B6\u02B9\u02BD\u02BC\u02BC\u02B9\u02B3\u02B9\u02C0(this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0);
		}
	}

	protected void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		base.Start();
	}

	public ushort \u02B2\u02B9\u02BB\u02BC\u02B5\u02B7\u02BB\u02B2\u02B9\u02BF\u02B8()
	{
		return 101;
	}

	protected void \u02BB\u02B8\u02B8\u02B3\u02C1\u02B2\u02B8\u02BC\u02C0\u02BB\u02B2(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		base.\u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8);
		byte b = (byte)(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF >> 6);
		byte b2 = (byte)(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & 0);
		byte b3 = b | b2;
		this.gameManager.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02C0\u02BC\u02B8\u02C0\u02B9\u02B5\u02BA\u02BD\u02B8\u02B3\u02B8(this, \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8, (ushort)b3);
	}

	protected void \u02BC\u02B9\u02B9\u02B3\u02B5\u02BF\u02B9\u02BB\u02B5\u02B5\u02B9()
	{
		if (!this.\u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE)
		{
			return;
		}
		if (this.playerStuff.playerInfo.isRemotePlayer)
		{
			return;
		}
		this.buttonsPressed = 0;
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.buttonsPressed |= 1;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(0))
		{
			this.buttonsPressed |= 3;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(2))
		{
			this.buttonsPressed |= 8;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(5))
		{
			this.buttonsPressed |= 6;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(3))
		{
			this.buttonsPressed = (ushort)((int)this.buttonsPressed | -2);
		}
		if (this.playerStuff.rewiredPlayer.GetButton(75))
		{
			this.buttonsPressed = (ushort)((int)this.buttonsPressed | -7);
		}
		if (this.buttonsPressed == 0 && this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 1;
			this.buttonsPressed = (ushort)((int)this.buttonsPressed | -50);
		}
		base.UpdateInputs();
	}

	public void \u02BF\u02BC\u02BC\u02C0\u02BC\u02C1\u02BF\u02B2\u02C0\u02BA\u02C1()
	{
		base.\u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5();
		if (this.playerStuff.playerInfo.leftyFlip && this.playerStuff.playerInfo.IsGHLController)
		{
			\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B8\u02BC\u02B6\u02B9\u02BD\u02BC\u02BC\u02B9\u02B3\u02B9\u02C0(this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0);
		}
	}

	public ushort \u02BA\u02B8\u02B5\u02BE\u02BF\u02C0\u02C1\u02B9\u02BF\u02BB\u02B9()
	{
		return (ushort)(-25);
	}

	protected override bool \u02B7\u02BF\u02BA\u02BF\u02C1\u02B4\u02B5\u02BD\u02C1\u02B8\u02B6(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, ushort \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4)
	{
		ushort num = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02BF\u02B4\u02BD\u02C0\u02B5\u02B3\u02B8\u02B8\u02B8\u02BB\u02C0 ? \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02B5\u02B9\u02B4\u02B8\u02BD\u02B7\u02BA\u02B3\u02B5\u02BF\u02B3 : \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF);
		if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 != num && (\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 & num) == num)
		{
			return true;
		}
		if (!\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02C0\u02B7\u02BD\u02B9\u02B4\u02B9\u02BF\u02BA\u02BA\u02C0\u02B2 && \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 > num)
		{
			int num2 = (int)(\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 ^ num);
			if ((((int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2) & (int)num) != (int)\u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 - num2)
			{
				return false;
			}
			if (num == 8 || num == 1)
			{
				return false;
			}
			if (num == 16)
			{
				return (num2 & 32) != 32 && (num2 & 4) != 4 && (num2 & 2) != 2;
			}
			if (num == 32)
			{
				return (num2 & 4) != 4;
			}
			if (num == 2)
			{
				return (num2 & 32) != 32 && (num2 & 4) != 4 && (num2 & 16) != 16;
			}
			if (num == 4)
			{
				return (num2 & 32) != 32;
			}
		}
		return \u02C0\u02B4\u02BA\u02B5\u02BF\u02B3\u02B8\u02B9\u02C1\u02B6\u02B4 == num;
	}

	public ushort \u02B2\u02BA\u02B6\u02BF\u02B2\u02B4\u02B8\u02B3\u02B2\u02B8\u02BB()
	{
		return 115;
	}

	public void \u02B5\u02B9\u02B8\u02B8\u02BD\u02BA\u02B2\u02B6\u02BA\u02C0\u02C0()
	{
		base.\u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5();
		if (this.playerStuff.playerInfo.leftyFlip && this.playerStuff.playerInfo.IsGHLController)
		{
			\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B8\u02BC\u02B6\u02B9\u02BD\u02BC\u02BC\u02B9\u02B3\u02B9\u02C0(this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0);
		}
	}

	protected override void \u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		base.\u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8);
		byte b = (byte)(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF >> 3);
		byte b2 = (byte)(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & 7);
		byte b3 = b | b2;
		this.gameManager.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02BD\u02B8\u02BD\u02BA\u02B7\u02BD\u02B7\u02C1\u02B2\u02B5\u02B4(this, \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8, (ushort)b3);
	}

	protected void \u02BF\u02B5\u02B5\u02B5\u02B5\u02B4\u02C1\u02BA\u02BA\u02BF\u02BF()
	{
		if (!this.\u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE)
		{
			return;
		}
		if (this.playerStuff.playerInfo.isRemotePlayer)
		{
			return;
		}
		this.buttonsPressed = 0;
		if (this.playerStuff.rewiredPlayer.GetButton(0))
		{
			this.buttonsPressed |= 1;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.buttonsPressed |= 8;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(6))
		{
			this.buttonsPressed |= 4;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(3))
		{
			this.buttonsPressed |= 7;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(4))
		{
			this.buttonsPressed |= 49;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(-22))
		{
			this.buttonsPressed |= 80;
		}
		if (this.buttonsPressed == 0 && this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 1;
			this.buttonsPressed |= 2;
		}
		base.UpdateInputs();
	}

	public void \u02B7\u02BE\u02BA\u02B7\u02B4\u02B6\u02B3\u02BF\u02B8\u02B2\u02BF()
	{
		base.\u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5();
		if (this.playerStuff.playerInfo.leftyFlip && this.playerStuff.playerInfo.IsGHLController)
		{
			\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B8\u02BC\u02B6\u02B9\u02BD\u02BC\u02BC\u02B9\u02B3\u02B9\u02C0(this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0);
		}
	}

	public override ushort OpenNote
	{
		get
		{
			return 64;
		}
	}

	public const ushort \u02B8\u02B6\u02BE\u02C1\u02C0\u02B6\u02BD\u02BA\u02B3\u02BF\u02B5 = 8;

	public const ushort \u02B7\u02B3\u02BB\u02BB\u02BF\u02BE\u02B4\u02BD\u02B2\u02BA\u02B3 = 16;

	public const ushort \u02C1\u02C0\u02BE\u02BC\u02BA\u02B9\u02BE\u02BD\u02BD\u02B6\u02C0 = 32;

	public const ushort \u02B9\u02B9\u02B3\u02BB\u02BF\u02BD\u02B9\u02B5\u02B4\u02BB\u02B8 = 1;

	public const ushort \u02BC\u02C0\u02B8\u02B2\u02BB\u02BB\u02B6\u02BC\u02C1\u02B4\u02BD = 2;

	public const ushort \u02B3\u02B6\u02BF\u02BA\u02C1\u02B2\u02C0\u02BE\u02BE\u02C0\u02B9 = 4;

	public const ushort \u02BC\u02B5\u02BC\u02BB\u02BE\u02BE\u02B5\u02C0\u02BA\u02BE\u02BF = 64;
}
