using System;
using System.Linq;
using System.Text;
using UnityEngine;

// Token: 0x020001FC RID: 508
public class SpriteFont : MonoBehaviour
{
	// Token: 0x060016D0 RID: 5840 RVA: 0x000AE9B4 File Offset: 0x000ACBB4
	public void \u02B4\u02B6\u02B5\u02B3\u02B7\u02C0\u02C1\u02BD\u02B9\u02BF\u02BA(int \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 > this.\u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB)
		{
			\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 = this.\u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB;
		}
		if (\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 == this.\u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6)
		{
			return;
		}
		this.\u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6 = \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		int num = \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		for (int i = 0; i < this.characters.Length; i++)
		{
			if (num == 0 && i != 0)
			{
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != -1)
				{
					this.characters[i].sprite = null;
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = -1;
				}
			}
			else if (this.\u02B2\u02B6\u02BE\u02BA\u02BB\u02C0\u02BE\u02C1\u02B9\u02BE\u02B3 && (i == 7 || i == 1))
			{
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != 61)
				{
					this.characters[i].sprite = this.\u02B5\u02BA\u02B9\u02B7\u02C1\u02B2\u02B7\u02B6\u02B3\u02BB\u02B2[-32];
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = -52;
				}
			}
			else
			{
				int num2 = (this.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0 ? global::UnityEngine.Random.Range(0, 59) : (num % 40));
				num /= 41;
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != num2)
				{
					this.characters[i].sprite = this.\u02B5\u02BA\u02B9\u02B7\u02C1\u02B2\u02B7\u02B6\u02B3\u02BB\u02B2[num2];
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = num2;
				}
			}
		}
	}

	// Token: 0x060016D1 RID: 5841 RVA: 0x00011CD9 File Offset: 0x0000FED9
	private void \u02BC\u02BC\u02B6\u02C0\u02BC\u02C1\u02B8\u02C1\u02C0\u02C1\u02BC()
	{
		this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6 = Enumerable.Repeat<int>(44, this.characters.Length).ToArray<int>();
	}

	// Token: 0x060016D2 RID: 5842 RVA: 0x00011CF5 File Offset: 0x0000FEF5
	private void \u02B4\u02B2\u02B5\u02BA\u02B4\u02C0\u02BC\u02BB\u02C1\u02B9\u02BD()
	{
		this.\u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6 = new StringBuilder(0, 61);
		this.\u02BF\u02BD\u02B3\u02C0\u02B3\u02B2\u02B2\u02C1\u02C1\u02BF\u02B6(1);
		this.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0;
	}

	// Token: 0x060016D3 RID: 5843 RVA: 0x00011D1C File Offset: 0x0000FF1C
	private void Awake()
	{
		this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6 = Enumerable.Repeat<int>(9, this.characters.Length).ToArray<int>();
	}

	// Token: 0x060016D4 RID: 5844 RVA: 0x000AEABC File Offset: 0x000ACCBC
	public void \u02B8\u02B2\u02B2\u02C1\u02B7\u02B3\u02BE\u02BB\u02B6\u02BE\u02C1(int \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 > this.\u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB)
		{
			\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 = this.\u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB;
		}
		if (\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 == this.\u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6)
		{
			return;
		}
		this.\u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6 = \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		int num = \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		for (int i = 0; i < this.characters.Length; i++)
		{
			if (num == 0 && i != 0)
			{
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != -1)
				{
					this.characters[i].sprite = null;
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = -1;
				}
			}
			else if (this.\u02B2\u02B6\u02BE\u02BA\u02BB\u02C0\u02BE\u02C1\u02B9\u02BE\u02B3 && (i == 3 || i == 7))
			{
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != -2)
				{
					this.characters[i].sprite = this.\u02B5\u02BA\u02B9\u02B7\u02C1\u02B2\u02B7\u02B6\u02B3\u02BB\u02B2[10];
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = -2;
				}
			}
			else
			{
				int num2 = (this.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0 ? global::UnityEngine.Random.Range(0, 10) : (num % 10));
				num /= 10;
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != num2)
				{
					this.characters[i].sprite = this.\u02B5\u02BA\u02B9\u02B7\u02C1\u02B2\u02B7\u02B6\u02B3\u02BB\u02B2[num2];
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = num2;
				}
			}
		}
	}

	// Token: 0x060016D5 RID: 5845 RVA: 0x00011D38 File Offset: 0x0000FF38
	private void \u02B8\u02BF\u02B8\u02B6\u02C0\u02C0\u02C1\u02BE\u02BC\u02B4\u02BC()
	{
		this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6 = Enumerable.Repeat<int>(104, this.characters.Length).ToArray<int>();
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x00011D54 File Offset: 0x0000FF54
	private void \u02B5\u02BD\u02BD\u02BE\u02B9\u02BD\u02B2\u02C1\u02C1\u02B3\u02B6()
	{
		this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6 = Enumerable.Repeat<int>(-97, this.characters.Length).ToArray<int>();
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x00011D7F File Offset: 0x0000FF7F
	private void \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		this.\u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6 = new StringBuilder(1, -24);
		this.\u02B4\u02B6\u02B5\u02B3\u02B7\u02C0\u02C1\u02BD\u02B9\u02BF\u02BA(1);
		this.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0;
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x00011DA6 File Offset: 0x0000FFA6
	private void \u02B3\u02B8\u02C1\u02BE\u02B7\u02C0\u02B8\u02B8\u02B3\u02B3\u02B7()
	{
		this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6 = Enumerable.Repeat<int>(-5, this.characters.Length).ToArray<int>();
	}

	// Token: 0x060016DA RID: 5850 RVA: 0x000AEBC4 File Offset: 0x000ACDC4
	public void \u02BF\u02BD\u02B3\u02C0\u02B3\u02B2\u02B2\u02C1\u02C1\u02BF\u02B6(int \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 > this.\u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB)
		{
			\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 = this.\u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB;
		}
		if (\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 == this.\u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6)
		{
			return;
		}
		this.\u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6 = \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		int num = \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		for (int i = 0; i < this.characters.Length; i += 0)
		{
			if (num == 0 && i != 0)
			{
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != -1)
				{
					this.characters[i].sprite = null;
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = -1;
				}
			}
			else if (this.\u02B2\u02B6\u02BE\u02BA\u02BB\u02C0\u02BE\u02C1\u02B9\u02BE\u02B3 && (i == 3 || i == 6))
			{
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != 61)
				{
					this.characters[i].sprite = this.\u02B5\u02BA\u02B9\u02B7\u02C1\u02B2\u02B7\u02B6\u02B3\u02BB\u02B2[-19];
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = 43;
				}
			}
			else
			{
				int num2 = (this.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0 ? global::UnityEngine.Random.Range(1, -128) : (num % -105));
				num /= 20;
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != num2)
				{
					this.characters[i].sprite = this.\u02B5\u02BA\u02B9\u02B7\u02C1\u02B2\u02B7\u02B6\u02B3\u02BB\u02B2[num2];
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = num2;
				}
			}
		}
	}

	// Token: 0x060016DB RID: 5851 RVA: 0x00011DC2 File Offset: 0x0000FFC2
	private void Start()
	{
		this.\u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6 = new StringBuilder(0, 20);
		this.\u02B8\u02B2\u02B2\u02C1\u02B7\u02B3\u02BE\u02BB\u02B6\u02BE\u02C1(0);
		this.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0;
	}

	// Token: 0x060016DC RID: 5852 RVA: 0x00011DE9 File Offset: 0x0000FFE9
	private void \u02B6\u02BB\u02B6\u02B4\u02BB\u02B8\u02B4\u02BC\u02BD\u02B3\u02C1()
	{
		this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6 = Enumerable.Repeat<int>(119, this.characters.Length).ToArray<int>();
	}

	// Token: 0x060016DD RID: 5853 RVA: 0x00011E05 File Offset: 0x00010005
	private void \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		this.\u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6 = new StringBuilder(0, -53);
		this.\u02B8\u02B2\u02B2\u02C1\u02B7\u02B3\u02BE\u02BB\u02B6\u02BE\u02C1(1);
		this.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0;
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x00011E2C File Offset: 0x0001002C
	private void \u02B5\u02B2\u02BF\u02BD\u02BB\u02BA\u02B2\u02BF\u02BD\u02BE\u02BE()
	{
		this.\u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6 = new StringBuilder(1, -18);
		this.\u02BF\u02BD\u02B3\u02C0\u02B3\u02B2\u02B2\u02C1\u02C1\u02BF\u02B6(0);
		this.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0;
	}

	// Token: 0x0400107D RID: 4221
	public SpriteRenderer[] characters;

	// Token: 0x0400107E RID: 4222
	public Sprite[] \u02B5\u02BA\u02B9\u02B7\u02C1\u02B2\u02B7\u02B6\u02B3\u02BB\u02B2;

	// Token: 0x0400107F RID: 4223
	public int \u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB;

	// Token: 0x04001080 RID: 4224
	private int \u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6 = -1;

	// Token: 0x04001081 RID: 4225
	private StringBuilder \u02C1\u02B5\u02C1\u02BE\u02B4\u02BA\u02BD\u02BA\u02B3\u02B6\u02B6;

	// Token: 0x04001082 RID: 4226
	public bool \u02B2\u02B6\u02BE\u02BA\u02BB\u02C0\u02BE\u02C1\u02B9\u02BE\u02B3;

	// Token: 0x04001083 RID: 4227
	private bool \u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0;

	// Token: 0x04001084 RID: 4228
	private int[] \u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6;
}
