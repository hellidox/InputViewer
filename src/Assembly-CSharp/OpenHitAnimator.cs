using System;
using UnityEngine;

// Token: 0x02000177 RID: 375
public class OpenHitAnimator : MonoBehaviour
{
	// Token: 0x06001121 RID: 4385 RVA: 0x0000F2EB File Offset: 0x0000D4EB
	private void \u02B9\u02BD\u02B5\u02C1\u02B6\u02B6\u02BD\u02B9\u02BC\u02C1\u02B3()
	{
		this.\u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x0000F30F File Offset: 0x0000D50F
	public Color \u02B4\u02B5\u02BC\u02B5\u02B3\u02B8\u02BF\u02B4\u02B3\u02B6\u02B6()
	{
		return this.<\u02BF\u02B9\u02B9\u02B8\u02B8\u02B7\u02BE\u02B5\u02B9\u02B4\u02B6>k__BackingField;
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x0008F3A8 File Offset: 0x0008D5A8
	public void \u02B7\u02BA\u02B3\u02BF\u02BB\u02C1\u02B4\u02B3\u02B8\u02BC\u02C0(bool \u02B8\u02BE\u02B7\u02B4\u02B4\u02BF\u02BD\u02BD\u02B5\u02B8\u02BE)
	{
		this.\u02B8\u02C0\u02C0\u02BB\u02B7\u02B3\u02BF\u02B6\u02B6\u02B7\u02B9 = \u02B8\u02BE\u02B7\u02B4\u02B4\u02BF\u02BD\u02BD\u02B5\u02B8\u02BE;
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 582f;
		this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 = 0;
		if (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9)
		{
			this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.spHitColor;
		}
		else
		{
			this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.hitColor;
		}
		this.flamesTransform.localScale = this.defaultFlamesSize;
		this.ovalTransform.localScale = this.defaultOvalSize;
		this.\u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1.enabled = (this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB.enabled = true);
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x0008F434 File Offset: 0x0008D634
	private void Update()
	{
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 < 0.016f)
		{
			return;
		}
		while (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 >= 0.016f)
		{
			this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2++;
			this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 -= 0.016f;
			this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2.a = this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2.a - 0.15f;
		}
		float num = (float)this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 * 0.2f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, num);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, num);
		this.\u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1.color = (this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB.color = this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2);
		if (this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 >= 6)
		{
			if (this.\u02B8\u02C0\u02C0\u02BB\u02B7\u02B3\u02BF\u02B6\u02B6\u02B7\u02B9)
			{
				this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB.enabled = false;
				this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 = 0;
				if (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9)
				{
					this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.spHitColor;
					return;
				}
				this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.hitColor;
				return;
			}
			else
			{
				this.\u02B8\u02B3\u02BD\u02B5\u02BC\u02B6\u02B8\u02C1\u02C0\u02BC\u02B7();
			}
		}
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x0000F30F File Offset: 0x0000D50F
	public Color \u02B8\u02C1\u02B7\u02BC\u02BC\u02B3\u02B5\u02B3\u02B5\u02C1\u02B4()
	{
		return this.<\u02BF\u02B9\u02B9\u02B8\u02B8\u02B7\u02BE\u02B5\u02B9\u02B4\u02B6>k__BackingField;
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x0000F317 File Offset: 0x0000D517
	public void \u02B2\u02C1\u02C0\u02B8\u02B2\u02B5\u02C0\u02B2\u02B3\u02C1\u02B8(Color \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BF\u02B9\u02B9\u02B8\u02B8\u02B7\u02BE\u02B5\u02B9\u02B4\u02B6>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x0000F320 File Offset: 0x0000D520
	public void \u02B6\u02B8\u02BA\u02B8\u02BF\u02B9\u02B4\u02B5\u02BF\u02C1\u02BA(Color \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BD\u02C0\u02B9\u02BD\u02B9\u02BB\u02B2\u02B8\u02B7\u02B6\u02B9>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x0008F55C File Offset: 0x0008D75C
	public void \u02B4\u02BB\u02B2\u02B4\u02B8\u02BB\u02C0\u02B5\u02B7\u02BC\u02B2()
	{
		this.\u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1.enabled = (this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB.enabled = false);
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x0000F2EB File Offset: 0x0000D4EB
	private void \u02BE\u02B6\u02B9\u02B2\u02C1\u02B9\u02B8\u02B6\u02B4\u02B3\u02B3()
	{
		this.\u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x0000F320 File Offset: 0x0000D520
	public void \u02B3\u02B6\u02B8\u02B5\u02BB\u02B5\u02BA\u02B2\u02BA\u02B9\u02B6(Color \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BD\u02C0\u02B9\u02BD\u02B9\u02BB\u02B2\u02B8\u02B7\u02B6\u02B9>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06001137 RID: 4407 RVA: 0x0000F30F File Offset: 0x0000D50F
	// (set) Token: 0x0600112C RID: 4396 RVA: 0x0000F317 File Offset: 0x0000D517
	public Color spHitColor { get; set; }

	// Token: 0x0600112D RID: 4397 RVA: 0x0008F584 File Offset: 0x0008D784
	private void \u02B5\u02B9\u02B7\u02B7\u02B6\u02B5\u02BC\u02BA\u02B4\u02B2\u02B4()
	{
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 < 601f)
		{
			return;
		}
		while (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 >= 1613f)
		{
			this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 += 0;
			this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 -= 224f;
			this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2.a = this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2.a - 920f;
		}
		float num = (float)this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 * 170f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, num);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, num);
		this.\u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1.color = (this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB.color = this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2);
		if (this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 >= 1)
		{
			if (this.\u02B8\u02C0\u02C0\u02BB\u02B7\u02B3\u02BF\u02B6\u02B6\u02B7\u02B9)
			{
				this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB.enabled = true;
				this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 = 1;
				if (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9)
				{
					this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.spHitColor;
					return;
				}
				this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.hitColor;
				return;
			}
			else
			{
				this.\u02B8\u02B3\u02BD\u02B5\u02BC\u02B6\u02B8\u02C1\u02C0\u02BC\u02B7();
			}
		}
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x0000F320 File Offset: 0x0000D520
	public void \u02B5\u02BB\u02B2\u02BC\u02B4\u02BC\u02B5\u02BA\u02BF\u02B3\u02B4(Color \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BD\u02C0\u02B9\u02BD\u02B9\u02BB\u02B2\u02B8\u02B7\u02B6\u02B9>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x0000F320 File Offset: 0x0000D520
	public void \u02B7\u02B8\u02B6\u02B8\u02BA\u02B4\u02B3\u02B7\u02BC\u02B9\u02C0(Color \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BD\u02C0\u02B9\u02BD\u02B9\u02BB\u02B2\u02B8\u02B7\u02B6\u02B9>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x0008F6AC File Offset: 0x0008D8AC
	public void \u02B6\u02BF\u02B5\u02C1\u02C1\u02B9\u02B6\u02BD\u02B4\u02B8\u02BF(bool \u02B8\u02BE\u02B7\u02B4\u02B4\u02BF\u02BD\u02BD\u02B5\u02B8\u02BE)
	{
		this.\u02B8\u02C0\u02C0\u02BB\u02B7\u02B3\u02BF\u02B6\u02B6\u02B7\u02B9 = \u02B8\u02BE\u02B7\u02B4\u02B4\u02BF\u02BD\u02BD\u02B5\u02B8\u02BE;
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 726f;
		this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 = 1;
		if (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9)
		{
			this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.\u02B8\u02C1\u02B7\u02BC\u02BC\u02B3\u02B5\u02B3\u02B5\u02C1\u02B4();
		}
		else
		{
			this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.\u02B4\u02C0\u02B8\u02BC\u02B9\u02BE\u02BE\u02B3\u02BE\u02B5\u02B3();
		}
		this.flamesTransform.localScale = this.defaultFlamesSize;
		this.ovalTransform.localScale = this.defaultOvalSize;
		this.\u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1.enabled = (this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB.enabled = false);
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x0008F738 File Offset: 0x0008D938
	public void \u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(bool \u02B8\u02BE\u02B7\u02B4\u02B4\u02BF\u02BD\u02BD\u02B5\u02B8\u02BE)
	{
		this.\u02B8\u02C0\u02C0\u02BB\u02B7\u02B3\u02BF\u02B6\u02B6\u02B7\u02B9 = \u02B8\u02BE\u02B7\u02B4\u02B4\u02BF\u02BD\u02BD\u02B5\u02B8\u02BE;
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 0f;
		this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 = 0;
		if (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9)
		{
			this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.spHitColor;
		}
		else
		{
			this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.hitColor;
		}
		this.flamesTransform.localScale = this.defaultFlamesSize;
		this.ovalTransform.localScale = this.defaultOvalSize;
		this.\u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1.enabled = (this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB.enabled = true);
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x0000F317 File Offset: 0x0000D517
	public void \u02BB\u02BC\u02BD\u02B9\u02B3\u02B3\u02BB\u02BD\u02BE\u02B8\u02B6(Color \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BF\u02B9\u02B9\u02B8\u02B8\u02B7\u02BE\u02B5\u02B9\u02B4\u02B6>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x06001133 RID: 4403 RVA: 0x0000F329 File Offset: 0x0000D529
	// (set) Token: 0x0600113C RID: 4412 RVA: 0x0000F320 File Offset: 0x0000D520
	public Color hitColor { get; set; }

	// Token: 0x06001134 RID: 4404 RVA: 0x0000F2EB File Offset: 0x0000D4EB
	private void Awake()
	{
		this.\u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x0000F320 File Offset: 0x0000D520
	public void \u02B9\u02BA\u02B4\u02B4\u02B6\u02B6\u02C1\u02B9\u02BE\u02BC\u02BE(Color \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BD\u02C0\u02B9\u02BD\u02B9\u02BB\u02B2\u02B8\u02B7\u02B6\u02B9>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x0000F329 File Offset: 0x0000D529
	public Color \u02B4\u02C0\u02B8\u02BC\u02B9\u02BE\u02BE\u02B3\u02BE\u02B5\u02B3()
	{
		return this.<\u02BD\u02C0\u02B9\u02BD\u02B9\u02BB\u02B2\u02B8\u02B7\u02B6\u02B9>k__BackingField;
	}

	// Token: 0x06001138 RID: 4408 RVA: 0x0008F7C4 File Offset: 0x0008D9C4
	public void \u02B8\u02BC\u02BD\u02B5\u02B8\u02BA\u02B7\u02B3\u02C1\u02B8\u02B2(bool \u02B8\u02BE\u02B7\u02B4\u02B4\u02BF\u02BD\u02BD\u02B5\u02B8\u02BE)
	{
		this.\u02B8\u02C0\u02C0\u02BB\u02B7\u02B3\u02BF\u02B6\u02B6\u02B7\u02B9 = \u02B8\u02BE\u02B7\u02B4\u02B4\u02BF\u02BD\u02BD\u02B5\u02B8\u02BE;
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 678f;
		this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 = 1;
		if (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9)
		{
			this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.spHitColor;
		}
		else
		{
			this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.\u02B4\u02C0\u02B8\u02BC\u02B9\u02BE\u02BE\u02B3\u02BE\u02B5\u02B3();
		}
		this.flamesTransform.localScale = this.defaultFlamesSize;
		this.ovalTransform.localScale = this.defaultOvalSize;
		this.\u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1.enabled = (this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB.enabled = false);
	}

	// Token: 0x06001139 RID: 4409 RVA: 0x0000F2EB File Offset: 0x0000D4EB
	private void \u02B3\u02B8\u02C1\u02BE\u02B7\u02C0\u02B8\u02B8\u02B3\u02B3\u02B7()
	{
		this.\u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x0008F850 File Offset: 0x0008DA50
	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 < 778f)
		{
			return;
		}
		while (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 >= 949f)
		{
			this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 += 0;
			this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 -= 1176f;
			this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2.a = this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2.a - 1844f;
		}
		float num = (float)this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 * 1867f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, num);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, num);
		this.\u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1.color = (this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB.color = this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2);
		if (this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 >= 6)
		{
			if (this.\u02B8\u02C0\u02C0\u02BB\u02B7\u02B3\u02BF\u02B6\u02B6\u02B7\u02B9)
			{
				this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB.enabled = true;
				this.\u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2 = 0;
				if (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9)
				{
					this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.\u02B4\u02B5\u02BC\u02B5\u02B3\u02B8\u02BF\u02B4\u02B3\u02B6\u02B6();
					return;
				}
				this.\u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2 = this.hitColor;
				return;
			}
			else
			{
				this.\u02B8\u02B3\u02BD\u02B5\u02BC\u02B6\u02B8\u02C1\u02C0\u02BC\u02B7();
			}
		}
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x0008F55C File Offset: 0x0008D75C
	public void \u02B8\u02B3\u02BD\u02B5\u02BC\u02B6\u02B8\u02C1\u02C0\u02BC\u02B7()
	{
		this.\u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1.enabled = (this.\u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB.enabled = false);
	}

	// Token: 0x04000D16 RID: 3350
	[SerializeField]
	private BasePlayer basePlayer;

	// Token: 0x04000D17 RID: 3351
	[SerializeField]
	private Transform flamesTransform;

	// Token: 0x04000D18 RID: 3352
	[SerializeField]
	private Transform ovalTransform;

	// Token: 0x04000D19 RID: 3353
	private SpriteRenderer \u02BA\u02BB\u02BB\u02BB\u02BE\u02BC\u02BD\u02C0\u02B8\u02BD\u02C1;

	// Token: 0x04000D1A RID: 3354
	private SpriteRenderer \u02BE\u02B2\u02B3\u02C1\u02BB\u02BE\u02BF\u02B6\u02BF\u02B5\u02BB;

	// Token: 0x04000D1B RID: 3355
	private bool \u02B8\u02C0\u02C0\u02BB\u02B7\u02B3\u02BF\u02B6\u02B6\u02B7\u02B9;

	// Token: 0x04000D1C RID: 3356
	[SerializeField]
	private Vector3 defaultFlamesSize;

	// Token: 0x04000D1D RID: 3357
	[SerializeField]
	private Vector3 endFlamesSize;

	// Token: 0x04000D1E RID: 3358
	[SerializeField]
	private Vector3 defaultOvalSize;

	// Token: 0x04000D1F RID: 3359
	[SerializeField]
	private Vector3 endOvalSize;

	// Token: 0x04000D20 RID: 3360
	private float \u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6;

	// Token: 0x04000D21 RID: 3361
	private int \u02BF\u02B2\u02BB\u02BD\u02BC\u02BF\u02B6\u02B3\u02B5\u02BB\u02B2;

	// Token: 0x04000D24 RID: 3364
	private Color \u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2;
}
