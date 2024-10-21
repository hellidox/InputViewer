using System;

// Token: 0x0200016E RID: 366
public sealed class GHLPlayer : BaseGuitarPlayer
{
	// Token: 0x06001068 RID: 4200 RVA: 0x0000EDEE File Offset: 0x0000CFEE
	protected void \u02BC\u02BC\u02B3\u02B2\u02C0\u02B6\u02B8\u02BA\u02BD\u02B9\u02B6()
	{
		base.Start();
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x000887E4 File Offset: 0x000869E4
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
		this.inputBits = 1;
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.inputBits |= 0;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(0))
		{
			this.inputBits |= 4;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(0))
		{
			this.inputBits |= 2;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(5))
		{
			this.inputBits |= 0;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(5))
		{
			this.inputBits |= 54;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(-3))
		{
			this.inputBits = (ushort)((int)this.inputBits | -38);
		}
		if (this.inputBits == 0 && this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 1;
			this.inputBits |= 37;
		}
		base.\u02B6\u02BB\u02BB\u02B8\u02BF\u02C0\u02BD\u02C0\u02BE\u02BF\u02BB();
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x0008891C File Offset: 0x00086B1C
	protected override void \u02B6\u02BB\u02BB\u02B8\u02BF\u02C0\u02BD\u02C0\u02BE\u02BF\u02BB()
	{
		if (!this.\u02BE\u02BC\u02C1\u02BA\u02B9\u02C0\u02BE\u02B4\u02B8\u02B2\u02BE)
		{
			return;
		}
		if (this.playerStuff.playerInfo.isRemotePlayer)
		{
			return;
		}
		this.inputBits = 0;
		if (this.playerStuff.rewiredPlayer.GetButton(0))
		{
			this.inputBits |= 1;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.inputBits |= 2;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(2))
		{
			this.inputBits |= 4;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(3))
		{
			this.inputBits |= 8;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(4))
		{
			this.inputBits |= 16;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(24))
		{
			this.inputBits |= 32;
		}
		if (this.inputBits == 0 && this.playerStuff.rewiredPlayer.GetButton(8))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 0;
			this.inputBits |= 64;
		}
		base.\u02B6\u02BB\u02BB\u02B8\u02BF\u02C0\u02BD\u02C0\u02BE\u02BF\u02BB();
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x00088A54 File Offset: 0x00086C54
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
		this.inputBits = 1;
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.inputBits |= 1;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.inputBits |= 3;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.inputBits |= 6;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(3))
		{
			this.inputBits |= 0;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(2))
		{
			this.inputBits = (ushort)((int)this.inputBits | -75);
		}
		if (this.playerStuff.rewiredPlayer.GetButton(68))
		{
			this.inputBits = (ushort)((int)this.inputBits | -102);
		}
		if (this.inputBits == 0 && this.playerStuff.rewiredPlayer.GetButton(3))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 1;
			this.inputBits |= 63;
		}
		base.\u02B6\u02BB\u02BB\u02B8\u02BF\u02C0\u02BD\u02C0\u02BE\u02BF\u02BB();
	}

	// Token: 0x0600106C RID: 4204 RVA: 0x0000EDF6 File Offset: 0x0000CFF6
	public override void \u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5()
	{
		base.\u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5();
		if (this.playerStuff.playerInfo.leftyFlip && this.playerStuff.playerInfo.IsGHLController)
		{
			\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B8\u02BC\u02B6\u02B9\u02BD\u02BC\u02BC\u02B9\u02B3\u02B9\u02C0(this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0);
		}
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x00088B8C File Offset: 0x00086D8C
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

	// Token: 0x0600106E RID: 4206 RVA: 0x00088C4C File Offset: 0x00086E4C
	protected void \u02BC\u02BC\u02BB\u02B7\u02B6\u02C1\u02B9\u02B6\u02BD\u02C1\u02B6(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		base.\u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8);
		byte b = (byte)(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF >> 1);
		byte b2 = (byte)(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & 3);
		byte b3 = b | b2;
		this._GameManager.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02BD\u02B8\u02BD\u02BA\u02B7\u02BD\u02B7\u02C1\u02B2\u02B5\u02B4(this, \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8, (ushort)b3);
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x0000EDEE File Offset: 0x0000CFEE
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x0000EDF6 File Offset: 0x0000CFF6
	public void \u02B2\u02BA\u02B6\u02B9\u02B7\u02B4\u02C1\u02BF\u02B9\u02B3\u02BF()
	{
		base.\u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5();
		if (this.playerStuff.playerInfo.leftyFlip && this.playerStuff.playerInfo.IsGHLController)
		{
			\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B8\u02BC\u02B6\u02B9\u02BD\u02BC\u02BC\u02B9\u02B3\u02B9\u02C0(this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0);
		}
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x0000EDEE File Offset: 0x0000CFEE
	protected void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		base.Start();
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x0000EE32 File Offset: 0x0000D032
	public ushort \u02B2\u02B9\u02BB\u02BC\u02B5\u02B7\u02BB\u02B2\u02B9\u02BF\u02B8()
	{
		return 101;
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x00088C8C File Offset: 0x00086E8C
	protected void \u02BB\u02B8\u02B8\u02B3\u02C1\u02B2\u02B8\u02BC\u02C0\u02BB\u02B2(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		base.\u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8);
		byte b = (byte)(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF >> 6);
		byte b2 = (byte)(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & 0);
		byte b3 = b | b2;
		this._GameManager.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02C0\u02BC\u02B8\u02C0\u02B9\u02B5\u02BA\u02BD\u02B8\u02B3\u02B8(this, \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8, (ushort)b3);
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x00088CCC File Offset: 0x00086ECC
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
		this.inputBits = 0;
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.inputBits |= 1;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(0))
		{
			this.inputBits |= 3;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(2))
		{
			this.inputBits |= 8;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(5))
		{
			this.inputBits |= 6;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(3))
		{
			this.inputBits = (ushort)((int)this.inputBits | -2);
		}
		if (this.playerStuff.rewiredPlayer.GetButton(75))
		{
			this.inputBits = (ushort)((int)this.inputBits | -7);
		}
		if (this.inputBits == 0 && this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 1;
			this.inputBits = (ushort)((int)this.inputBits | -50);
		}
		base.\u02B6\u02BB\u02BB\u02B8\u02BF\u02C0\u02BD\u02C0\u02BE\u02BF\u02BB();
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x0000EDF6 File Offset: 0x0000CFF6
	public void \u02BF\u02BC\u02BC\u02C0\u02BC\u02C1\u02BF\u02B2\u02C0\u02BA\u02C1()
	{
		base.\u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5();
		if (this.playerStuff.playerInfo.leftyFlip && this.playerStuff.playerInfo.IsGHLController)
		{
			\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B8\u02BC\u02B6\u02B9\u02BD\u02BC\u02BC\u02B9\u02B3\u02B9\u02C0(this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0);
		}
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x0000EE3E File Offset: 0x0000D03E
	public ushort \u02BA\u02B8\u02B5\u02BE\u02BF\u02C0\u02C1\u02B9\u02BF\u02BB\u02B9()
	{
		return (ushort)(-25);
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x00088E04 File Offset: 0x00087004
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

	// Token: 0x06001079 RID: 4217 RVA: 0x0000EE42 File Offset: 0x0000D042
	public ushort \u02B2\u02BA\u02B6\u02BF\u02B2\u02B4\u02B8\u02B3\u02B2\u02B8\u02BB()
	{
		return 115;
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x0000EDF6 File Offset: 0x0000CFF6
	public void \u02B5\u02B9\u02B8\u02B8\u02BD\u02BA\u02B2\u02B6\u02BA\u02C0\u02C0()
	{
		base.\u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5();
		if (this.playerStuff.playerInfo.leftyFlip && this.playerStuff.playerInfo.IsGHLController)
		{
			\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B8\u02BC\u02B6\u02B9\u02BD\u02BC\u02BC\u02B9\u02B3\u02B9\u02C0(this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0);
		}
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x00088EC4 File Offset: 0x000870C4
	protected override void \u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		base.\u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8);
		byte b = (byte)(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF >> 3);
		byte b2 = (byte)(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & 7);
		byte b3 = b | b2;
		this._GameManager.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02BD\u02B8\u02BD\u02BA\u02B7\u02BD\u02B7\u02C1\u02B2\u02B5\u02B4(this, \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8, (ushort)b3);
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00088F04 File Offset: 0x00087104
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
		this.inputBits = 0;
		if (this.playerStuff.rewiredPlayer.GetButton(0))
		{
			this.inputBits |= 1;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.inputBits |= 8;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(6))
		{
			this.inputBits |= 4;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(3))
		{
			this.inputBits |= 7;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(4))
		{
			this.inputBits |= 49;
		}
		if (this.playerStuff.rewiredPlayer.GetButton(-22))
		{
			this.inputBits |= 80;
		}
		if (this.inputBits == 0 && this.playerStuff.rewiredPlayer.GetButton(1))
		{
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = 1;
			this.inputBits |= 2;
		}
		base.\u02B6\u02BB\u02BB\u02B8\u02BF\u02C0\u02BD\u02C0\u02BE\u02BF\u02BB();
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x0000EDF6 File Offset: 0x0000CFF6
	public void \u02B7\u02BE\u02BA\u02B7\u02B4\u02B6\u02B3\u02BF\u02B8\u02B2\u02BF()
	{
		base.\u02B6\u02B7\u02B6\u02B2\u02BD\u02BC\u02BC\u02BE\u02BF\u02B5\u02B5();
		if (this.playerStuff.playerInfo.leftyFlip && this.playerStuff.playerInfo.IsGHLController)
		{
			\u02B6\u02BA\u02B9\u02BB\u02BD\u02B7\u02BF\u02B7\u02B8\u02B6\u02BD.\u02B8\u02BC\u02B6\u02B9\u02BD\u02BC\u02BC\u02B9\u02B3\u02B9\u02C0(this.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0);
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x0600107E RID: 4222 RVA: 0x0000EE46 File Offset: 0x0000D046
	public override ushort \u02BC\u02B2\u02BD\u02B8\u02BF\u02BB\u02C1\u02B3\u02C0\u02B8\u02B9
	{
		get
		{
			return 64;
		}
	}

	// Token: 0x04000C9D RID: 3229
	public const ushort \u02B8\u02B6\u02BE\u02C1\u02C0\u02B6\u02BD\u02BA\u02B3\u02BF\u02B5 = 8;

	// Token: 0x04000C9E RID: 3230
	public const ushort \u02B7\u02B3\u02BB\u02BB\u02BF\u02BE\u02B4\u02BD\u02B2\u02BA\u02B3 = 16;

	// Token: 0x04000C9F RID: 3231
	public const ushort \u02C1\u02C0\u02BE\u02BC\u02BA\u02B9\u02BE\u02BD\u02BD\u02B6\u02C0 = 32;

	// Token: 0x04000CA0 RID: 3232
	public const ushort \u02B9\u02B9\u02B3\u02BB\u02BF\u02BD\u02B9\u02B5\u02B4\u02BB\u02B8 = 1;

	// Token: 0x04000CA1 RID: 3233
	public const ushort \u02BC\u02C0\u02B8\u02B2\u02BB\u02BB\u02B6\u02BC\u02C1\u02B4\u02BD = 2;

	// Token: 0x04000CA2 RID: 3234
	public const ushort \u02B3\u02B6\u02BF\u02BA\u02C1\u02B2\u02C0\u02BE\u02BE\u02C0\u02B9 = 4;

	// Token: 0x04000CA3 RID: 3235
	public const ushort \u02BC\u02B5\u02BC\u02BB\u02BE\u02BE\u02B5\u02C0\u02BA\u02BE\u02BF = 64;
}
