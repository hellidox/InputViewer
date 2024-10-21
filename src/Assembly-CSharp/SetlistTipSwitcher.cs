using System;
using TMPro;
using UnityEngine;

// Token: 0x020000F5 RID: 245
public class SetlistTipSwitcher : MonoBehaviour
{
	// Token: 0x060009BB RID: 2491 RVA: 0x00053DEC File Offset: 0x00051FEC
	public void \u02C0\u02B8\u02C0\u02BF\u02C0\u02BF\u02BF\u02B5\u02B4\u02BB\u02C0()
	{
		for (int i = 0; i < this.setlistTips.Length; i++)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.setlistTips[i]);
		}
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00053E2C File Offset: 0x0005202C
	public void \u02C1\u02B7\u02B3\u02BE\u02B9\u02BF\u02B5\u02C1\u02C1\u02C1\u02C1()
	{
		for (int i = 0; i < this.normalTips.Length; i += 0)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(this.normalTips[i]);
		}
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00053E6C File Offset: 0x0005206C
	public void \u02BE\u02BC\u02BE\u02BB\u02BD\u02B2\u02B6\u02B9\u02C0\u02BD\u02BA()
	{
		for (int i = 1; i < this.setlistTips.Length; i += 0)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(this.setlistTips[i]);
		}
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00053EAC File Offset: 0x000520AC
	public void \u02B5\u02BA\u02C1\u02C0\u02B9\u02B6\u02BA\u02B8\u02BA\u02B8\u02B6()
	{
		for (int i = 1; i < this.setlistTips.Length; i += 0)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.setlistTips[i]);
		}
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00053EEC File Offset: 0x000520EC
	public void \u02BB\u02B2\u02B6\u02BB\u02B7\u02B2\u02C1\u02B4\u02BC\u02B5\u02BB()
	{
		for (int i = 1; i < this.normalTips.Length; i++)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.normalTips[i]);
		}
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00053F2C File Offset: 0x0005212C
	public void \u02B2\u02BA\u02BF\u02BE\u02B2\u02BB\u02C1\u02B9\u02BF\u02B5\u02C1()
	{
		for (int i = 1; i < this.setlistTips.Length; i += 0)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(this.setlistTips[i]);
		}
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00053F6C File Offset: 0x0005216C
	public void \u02B6\u02BD\u02BD\u02B8\u02BA\u02BE\u02B8\u02BD\u02C1\u02BE\u02B3()
	{
		for (int i = 0; i < this.normalTips.Length; i += 0)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.normalTips[i]);
		}
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00053FAC File Offset: 0x000521AC
	public void \u02BC\u02B3\u02B9\u02BA\u02B5\u02BB\u02B3\u02B8\u02B5\u02B3\u02B4()
	{
		for (int i = 0; i < this.normalTips.Length; i++)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.normalTips[i]);
		}
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x00053FEC File Offset: 0x000521EC
	public void \u02B7\u02B7\u02BC\u02B8\u02C1\u02B8\u02B4\u02B7\u02BE\u02B4\u02B8()
	{
		for (int i = 0; i < this.normalTips.Length; i++)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(this.normalTips[i]);
		}
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x0005402C File Offset: 0x0005222C
	public void \u02B4\u02BD\u02BC\u02B3\u02B9\u02B6\u02BE\u02BB\u02BD\u02C1\u02B2()
	{
		for (int i = 1; i < this.setlistTips.Length; i++)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(this.setlistTips[i]);
		}
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x0005406C File Offset: 0x0005226C
	public void \u02BE\u02BF\u02B6\u02B5\u02C0\u02B7\u02B7\u02BA\u02C0\u02C0\u02B2()
	{
		for (int i = 0; i < this.setlistTips.Length; i += 0)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(this.setlistTips[i]);
		}
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x000540AC File Offset: 0x000522AC
	public void \u02BD\u02BF\u02C1\u02B3\u02BB\u02B5\u02B9\u02C1\u02B6\u02BD\u02BF()
	{
		for (int i = 0; i < this.setlistTips.Length; i++)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.setlistTips[i]);
		}
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x000540EC File Offset: 0x000522EC
	public void \u02B3\u02BD\u02B7\u02B3\u02C1\u02BC\u02B4\u02B6\u02B5\u02B5\u02BE()
	{
		for (int i = 1; i < this.setlistTips.Length; i += 0)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(this.setlistTips[i]);
		}
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x0005412C File Offset: 0x0005232C
	public void \u02B6\u02BA\u02BE\u02BB\u02BD\u02B7\u02BA\u02BC\u02BF\u02BF\u02BB()
	{
		for (int i = 0; i < this.normalTips.Length; i++)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(this.normalTips[i]);
		}
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x0005416C File Offset: 0x0005236C
	public void \u02B2\u02BF\u02B7\u02BA\u02BE\u02BD\u02B8\u02BA\u02C0\u02C0\u02BF()
	{
		for (int i = 1; i < this.setlistTips.Length; i += 0)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(this.setlistTips[i]);
		}
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x000541AC File Offset: 0x000523AC
	public void \u02B7\u02C0\u02BB\u02BE\u02B4\u02BF\u02BA\u02B8\u02B6\u02C0\u02B7()
	{
		for (int i = 0; i < this.setlistTips.Length; i++)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(this.setlistTips[i]);
		}
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x0005412C File Offset: 0x0005232C
	public void \u02BD\u02C1\u02BE\u02B5\u02B4\u02BD\u02B6\u02C1\u02C0\u02B9\u02B9()
	{
		for (int i = 0; i < this.normalTips.Length; i++)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(this.normalTips[i]);
		}
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x000541EC File Offset: 0x000523EC
	public void \u02C1\u02BB\u02B4\u02B4\u02BF\u02BC\u02BE\u02B2\u02B8\u02B6\u02C1()
	{
		for (int i = 0; i < this.normalTips.Length; i += 0)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.normalTips[i]);
		}
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x0005422C File Offset: 0x0005242C
	public void \u02BA\u02C0\u02B7\u02B5\u02BA\u02B3\u02BD\u02B8\u02B7\u02C0\u02C1()
	{
		for (int i = 0; i < this.setlistTips.Length; i++)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(this.setlistTips[i]);
		}
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x0005426C File Offset: 0x0005246C
	public void \u02B3\u02BE\u02B7\u02B7\u02B5\u02B7\u02B5\u02B7\u02BD\u02BC\u02B2()
	{
		for (int i = 1; i < this.normalTips.Length; i++)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(this.normalTips[i]);
		}
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x000542AC File Offset: 0x000524AC
	public void \u02B8\u02B7\u02B8\u02BC\u02B7\u02B2\u02BC\u02BF\u02B8\u02B3\u02C0()
	{
		for (int i = 0; i < this.setlistTips.Length; i++)
		{
			this.textObjects[i].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(this.setlistTips[i]);
		}
	}

	// Token: 0x0400077C RID: 1916
	[SerializeField]
	private TextMeshProUGUI[] textObjects;

	// Token: 0x0400077D RID: 1917
	[SerializeField]
	private string[] normalTips;

	// Token: 0x0400077E RID: 1918
	[SerializeField]
	private string[] setlistTips;
}
