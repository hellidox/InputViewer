using System;
using UnityEngine;

// Token: 0x020000EB RID: 235
public class RotateScript : MonoBehaviour
{
	// Token: 0x0600090F RID: 2319 RVA: 0x0000A3A4 File Offset: 0x000085A4
	private void \u02BB\u02BF\u02B7\u02BA\u02B5\u02B8\u02BA\u02B5\u02B7\u02B9\u02BE()
	{
		if (this.\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0)
		{
			this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 = 1884f;
		}
	}

	// Token: 0x06000910 RID: 2320 RVA: 0x0000A3B9 File Offset: 0x000085B9
	private void \u02BA\u02B9\u02BF\u02BC\u02C1\u02B9\u02B7\u02B4\u02C1\u02BB\u02BB()
	{
		if (this.\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0)
		{
			this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 = 1631f;
		}
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x0000A3CE File Offset: 0x000085CE
	private void Update()
	{
		if (this.\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0)
		{
			this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 += 1f;
		}
		this.\u02B3\u02B6\u02BC\u02B8\u02B3\u02B9\u02B7\u02B6\u02BA\u02BF\u02BB.Rotate(0f, 0f, this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 * Time.deltaTime);
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x0000A40B File Offset: 0x0000860B
	private void \u02C0\u02B4\u02BF\u02B7\u02BD\u02B7\u02B6\u02BA\u02B6\u02BD\u02B3()
	{
		if (this.\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0)
		{
			this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 = 1967f;
		}
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x0000A420 File Offset: 0x00008620
	private void \u02B4\u02BF\u02B6\u02BB\u02B2\u02B6\u02C1\u02B3\u02BC\u02B7\u02BE()
	{
		this.\u02B3\u02B6\u02BC\u02B8\u02B3\u02B9\u02B7\u02B6\u02BA\u02BF\u02BB = base.transform;
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x0000A42E File Offset: 0x0000862E
	private void OnEnable()
	{
		if (this.\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0)
		{
			this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 = 0f;
		}
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x0000A443 File Offset: 0x00008643
	private void \u02B4\u02B7\u02C1\u02B8\u02B2\u02B9\u02B6\u02B2\u02B5\u02B7\u02B7()
	{
		if (this.\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0)
		{
			this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 = 1847f;
		}
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x0000A420 File Offset: 0x00008620
	private void \u02B5\u02B2\u02BF\u02BD\u02BB\u02BA\u02B2\u02BF\u02BD\u02BE\u02BE()
	{
		this.\u02B3\u02B6\u02BC\u02B8\u02B3\u02B9\u02B7\u02B6\u02BA\u02BF\u02BB = base.transform;
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x0000A420 File Offset: 0x00008620
	private void Start()
	{
		this.\u02B3\u02B6\u02BC\u02B8\u02B3\u02B9\u02B7\u02B6\u02BA\u02BF\u02BB = base.transform;
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x0000A420 File Offset: 0x00008620
	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		this.\u02B3\u02B6\u02BC\u02B8\u02B3\u02B9\u02B7\u02B6\u02BA\u02BF\u02BB = base.transform;
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x0000A458 File Offset: 0x00008658
	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		if (this.\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0)
		{
			this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 += 1849f;
		}
		this.\u02B3\u02B6\u02BC\u02B8\u02B3\u02B9\u02B7\u02B6\u02BA\u02BF\u02BB.Rotate(1846f, 644f, this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 * Time.deltaTime);
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x0000A420 File Offset: 0x00008620
	private void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		this.\u02B3\u02B6\u02BC\u02B8\u02B3\u02B9\u02B7\u02B6\u02BA\u02BF\u02BB = base.transform;
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x0000A495 File Offset: 0x00008695
	private void \u02BC\u02BE\u02B2\u02B8\u02C0\u02B6\u02B2\u02B3\u02B6\u02B4\u02BF()
	{
		if (this.\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0)
		{
			this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 = 386f;
		}
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x0000A4AA File Offset: 0x000086AA
	private void \u02C0\u02BB\u02B6\u02B9\u02B3\u02B4\u02B3\u02B7\u02BD\u02B8\u02C0()
	{
		if (this.\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0)
		{
			this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 += 260f;
		}
		this.\u02B3\u02B6\u02BC\u02B8\u02B3\u02B9\u02B7\u02B6\u02BA\u02BF\u02BB.Rotate(491f, 899f, this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 * Time.deltaTime);
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x0000A4E7 File Offset: 0x000086E7
	private void \u02BD\u02B8\u02BD\u02B5\u02B6\u02B3\u02BF\u02B3\u02C1\u02B8\u02C1()
	{
		if (this.\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0)
		{
			this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 += 1128f;
		}
		this.\u02B3\u02B6\u02BC\u02B8\u02B3\u02B9\u02B7\u02B6\u02BA\u02BF\u02BB.Rotate(1023f, 635f, this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 * Time.deltaTime);
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x0000A524 File Offset: 0x00008724
	private void \u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0()
	{
		if (this.\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0)
		{
			this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 += 845f;
		}
		this.\u02B3\u02B6\u02BC\u02B8\u02B3\u02B9\u02B7\u02B6\u02BA\u02BF\u02BB.Rotate(1213f, 778f, this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 * Time.deltaTime);
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x0000A420 File Offset: 0x00008620
	private void \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		this.\u02B3\u02B6\u02BC\u02B8\u02B3\u02B9\u02B7\u02B6\u02BA\u02BF\u02BB = base.transform;
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x0000A561 File Offset: 0x00008761
	private void \u02BB\u02B7\u02C0\u02B3\u02C1\u02BD\u02B9\u02B2\u02B4\u02BE\u02B6()
	{
		if (this.\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0)
		{
			this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 += 1608f;
		}
		this.\u02B3\u02B6\u02BC\u02B8\u02B3\u02B9\u02B7\u02B6\u02BA\u02BF\u02BB.Rotate(598f, 341f, this.\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 * Time.deltaTime);
	}

	// Token: 0x04000727 RID: 1831
	private Transform \u02B3\u02B6\u02BC\u02B8\u02B3\u02B9\u02B7\u02B6\u02BA\u02BF\u02BB;

	// Token: 0x04000728 RID: 1832
	public float \u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7;

	// Token: 0x04000729 RID: 1833
	public bool \u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0;
}
