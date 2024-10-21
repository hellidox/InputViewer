using System;
using UnityEngine;

// Token: 0x020001F5 RID: 501
public class ScrollingRect : MonoBehaviour
{
	// Token: 0x06001651 RID: 5713 RVA: 0x000ACAD8 File Offset: 0x000AACD8
	private float \u02BB\u02B7\u02BA\u02B2\u02C0\u02B3\u02B3\u02C0\u02BE\u02B6\u02BF()
	{
		return this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.rect.width - 412f;
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x000ACB00 File Offset: 0x000AAD00
	private float \u02B8\u02C0\u02B7\u02BF\u02B9\u02C1\u02B4\u02B2\u02BA\u02BC\u02BC()
	{
		return this.contentRect.rect.width;
	}

	// Token: 0x06001653 RID: 5715 RVA: 0x000117C6 File Offset: 0x0000F9C6
	private void \u02BC\u02BC\u02B6\u02C0\u02BC\u02C1\u02B8\u02C1\u02C0\u02C1\u02BC()
	{
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.GetComponent<RectTransform>();
		this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1 = this.contentRect.anchoredPosition;
	}

	// Token: 0x06001654 RID: 5716 RVA: 0x000117E5 File Offset: 0x0000F9E5
	public void \u02BF\u02BD\u02C0\u02BA\u02B8\u02BF\u02BB\u02B9\u02BD\u02B5\u02B8()
	{
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 782f;
		this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2 = true;
		this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = false;
		this.\u02BA\u02BA\u02B6\u02B3\u02BA\u02BF\u02B3\u02BE\u02C1\u02B3\u02B7 = false;
		this.contentRect.anchoredPosition = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x000ACB00 File Offset: 0x000AAD00
	private float \u02BF\u02B9\u02BA\u02B4\u02BC\u02B5\u02B9\u02C1\u02C1\u02BB\u02B3()
	{
		return this.contentRect.rect.width;
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x00011818 File Offset: 0x0000FA18
	private bool \u02B2\u02BB\u02B9\u02B9\u02BD\u02BA\u02B2\u02B6\u02BA\u02BD\u02B6()
	{
		return this.\u02B6\u02C1\u02B3\u02BE\u02C1\u02BF\u02BC\u02B5\u02BD\u02BB\u02B7() > this.\u02B3\u02B6\u02BB\u02B3\u02BF\u02B9\u02BD\u02B4\u02C0\u02BE\u02BC();
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x00011837 File Offset: 0x0000FA37
	private void OnEnable()
	{
		this.Reset();
	}

	// Token: 0x17000233 RID: 563
	// (get) Token: 0x06001659 RID: 5721 RVA: 0x0001183F File Offset: 0x0000FA3F
	private bool \u02B2\u02B8\u02BC\u02B4\u02B5\u02BF\u02C1\u02B4\u02B5\u02B3\u02C1
	{
		get
		{
			return this.\u02BE\u02B9\u02B4\u02B6\u02B5\u02C0\u02B6\u02B6\u02B7\u02B8\u02B6 > this.\u02C0\u02B7\u02B2\u02BB\u02C1\u02BC\u02B8\u02B9\u02BA\u02BA\u02B3;
		}
	}

	// Token: 0x0600165A RID: 5722 RVA: 0x000117C6 File Offset: 0x0000F9C6
	private void Awake()
	{
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.GetComponent<RectTransform>();
		this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1 = this.contentRect.anchoredPosition;
	}

	// Token: 0x0600165B RID: 5723 RVA: 0x000117C6 File Offset: 0x0000F9C6
	private void \u02B8\u02BF\u02B8\u02B6\u02C0\u02C0\u02C1\u02BE\u02BC\u02B4\u02BC()
	{
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.GetComponent<RectTransform>();
		this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1 = this.contentRect.anchoredPosition;
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x000ACB20 File Offset: 0x000AAD20
	private void \u02BB\u02B7\u02C0\u02B3\u02C1\u02BD\u02B9\u02B2\u02B4\u02BE\u02B6()
	{
		if (!this.\u02B5\u02B5\u02BB\u02B9\u02BA\u02BA\u02B6\u02C1\u02BE\u02B9\u02C1())
		{
			return;
		}
		float num = (this.\u02B6\u02C1\u02B3\u02BE\u02C1\u02BF\u02BC\u02B5\u02BD\u02BB\u02B7() - this.\u02BB\u02B7\u02BA\u02B2\u02C0\u02B3\u02B3\u02C0\u02BE\u02B6\u02BF()) / 1242f;
		float num2 = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x - num;
		float num3 = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x + num;
		if (this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE)
		{
			if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 >= this.waitTime)
			{
				this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = false;
				this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 68f;
				return;
			}
			this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
			return;
		}
		else
		{
			float num4 = this.contentRect.anchoredPosition.x;
			if (this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2)
			{
				num4 += this.scrollSpeed * Time.deltaTime;
			}
			else
			{
				num4 -= this.scrollSpeed * Time.deltaTime;
			}
			this.contentRect.anchoredPosition = new Vector2(num4, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
			if (this.\u02BA\u02BA\u02B6\u02B3\u02BA\u02BF\u02B3\u02BE\u02C1\u02B3\u02B7)
			{
				if (this.contentRect.anchoredPosition.x <= this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x)
				{
					this.\u02BA\u02BA\u02B6\u02B3\u02BA\u02BF\u02B3\u02BE\u02C1\u02B3\u02B7 = false;
					this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = false;
				}
				return;
			}
			if (!this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2 && this.contentRect.anchoredPosition.x <= num2)
			{
				this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2 = false;
				this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = false;
				return;
			}
			if (this.contentRect.anchoredPosition.x >= num3)
			{
				this.\u02BA\u02BA\u02B6\u02B3\u02BA\u02BF\u02B3\u02BE\u02C1\u02B3\u02B7 = false;
				this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2 = false;
				this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = true;
			}
			return;
		}
	}

	// Token: 0x0600165D RID: 5725 RVA: 0x000117C6 File Offset: 0x0000F9C6
	private void \u02BE\u02BD\u02B8\u02B8\u02B9\u02BA\u02BA\u02BA\u02B4\u02B2\u02B4()
	{
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.GetComponent<RectTransform>();
		this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1 = this.contentRect.anchoredPosition;
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x0001184F File Offset: 0x0000FA4F
	public void Reset()
	{
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 0f;
		this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2 = false;
		this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = true;
		this.\u02BA\u02BA\u02B6\u02B3\u02BA\u02BF\u02B3\u02BE\u02C1\u02B3\u02B7 = false;
		this.contentRect.anchoredPosition = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;
	}

	// Token: 0x17000231 RID: 561
	// (get) Token: 0x0600165F RID: 5727 RVA: 0x000ACC80 File Offset: 0x000AAE80
	private float \u02C0\u02B7\u02B2\u02BB\u02C1\u02BC\u02B8\u02B9\u02BA\u02BA\u02B3
	{
		get
		{
			return this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.rect.width - 15f;
		}
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x000ACCA8 File Offset: 0x000AAEA8
	private float \u02B3\u02B6\u02BB\u02B3\u02BF\u02B9\u02BD\u02B4\u02C0\u02BE\u02BC()
	{
		return this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.rect.width - 368f;
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x000ACCD0 File Offset: 0x000AAED0
	private void \u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF()
	{
		if (!this.\u02B2\u02B8\u02BC\u02B4\u02B5\u02BF\u02C1\u02B4\u02B5\u02B3\u02C1)
		{
			return;
		}
		float num = (this.\u02BE\u02B9\u02B4\u02B6\u02B5\u02C0\u02B6\u02B6\u02B7\u02B8\u02B6 - this.\u02C0\u02B7\u02B2\u02BB\u02C1\u02BC\u02B8\u02B9\u02BA\u02BA\u02B3) / 387f;
		float num2 = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x - num;
		float num3 = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x + num;
		if (this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE)
		{
			if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 >= this.waitTime)
			{
				this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = false;
				this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 727f;
				return;
			}
			this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
			return;
		}
		else
		{
			float num4 = this.contentRect.anchoredPosition.x;
			if (this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2)
			{
				num4 += this.scrollSpeed * Time.deltaTime;
			}
			else
			{
				num4 -= this.scrollSpeed * Time.deltaTime;
			}
			this.contentRect.anchoredPosition = new Vector2(num4, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
			if (this.\u02BA\u02BA\u02B6\u02B3\u02BA\u02BF\u02B3\u02BE\u02C1\u02B3\u02B7)
			{
				if (this.contentRect.anchoredPosition.x <= this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x)
				{
					this.\u02BA\u02BA\u02B6\u02B3\u02BA\u02BF\u02B3\u02BE\u02C1\u02B3\u02B7 = false;
					this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = true;
				}
				return;
			}
			if (!this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2 && this.contentRect.anchoredPosition.x <= num2)
			{
				this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2 = true;
				this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = false;
				return;
			}
			if (this.contentRect.anchoredPosition.x >= num3)
			{
				this.\u02BA\u02BA\u02B6\u02B3\u02BA\u02BF\u02B3\u02BE\u02C1\u02B3\u02B7 = true;
				this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2 = true;
				this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = true;
			}
			return;
		}
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x00011837 File Offset: 0x0000FA37
	private void \u02B9\u02B6\u02B3\u02B9\u02BD\u02BD\u02B6\u02C0\u02BE\u02BA\u02BB()
	{
		this.Reset();
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x000ACE30 File Offset: 0x000AB030
	private void Update()
	{
		if (!this.\u02B2\u02B8\u02BC\u02B4\u02B5\u02BF\u02C1\u02B4\u02B5\u02B3\u02C1)
		{
			return;
		}
		float num = (this.\u02BE\u02B9\u02B4\u02B6\u02B5\u02C0\u02B6\u02B6\u02B7\u02B8\u02B6 - this.\u02C0\u02B7\u02B2\u02BB\u02C1\u02BC\u02B8\u02B9\u02BA\u02BA\u02B3) / 2f;
		float num2 = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x - num;
		float num3 = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x + num;
		if (this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE)
		{
			if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 >= this.waitTime)
			{
				this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = false;
				this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 0f;
				return;
			}
			this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
			return;
		}
		else
		{
			float num4 = this.contentRect.anchoredPosition.x;
			if (this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2)
			{
				num4 += this.scrollSpeed * Time.deltaTime;
			}
			else
			{
				num4 -= this.scrollSpeed * Time.deltaTime;
			}
			this.contentRect.anchoredPosition = new Vector2(num4, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
			if (this.\u02BA\u02BA\u02B6\u02B3\u02BA\u02BF\u02B3\u02BE\u02C1\u02B3\u02B7)
			{
				if (this.contentRect.anchoredPosition.x <= this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x)
				{
					this.\u02BA\u02BA\u02B6\u02B3\u02BA\u02BF\u02B3\u02BE\u02C1\u02B3\u02B7 = false;
					this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = true;
				}
				return;
			}
			if (!this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2 && this.contentRect.anchoredPosition.x <= num2)
			{
				this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2 = true;
				this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = true;
				return;
			}
			if (this.contentRect.anchoredPosition.x >= num3)
			{
				this.\u02BA\u02BA\u02B6\u02B3\u02BA\u02BF\u02B3\u02BE\u02C1\u02B3\u02B7 = true;
				this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2 = false;
				this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = true;
			}
			return;
		}
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x00011882 File Offset: 0x0000FA82
	private bool \u02B5\u02B5\u02BB\u02B9\u02BA\u02BA\u02B6\u02C1\u02BE\u02B9\u02C1()
	{
		return this.\u02B8\u02C0\u02B7\u02BF\u02B9\u02C1\u02B4\u02B2\u02BA\u02BC\u02BC() > this.\u02BB\u02B7\u02BA\u02B2\u02C0\u02B3\u02B3\u02C0\u02BE\u02B6\u02BF();
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x000ACB00 File Offset: 0x000AAD00
	private float \u02B6\u02C1\u02B3\u02BE\u02C1\u02BF\u02BC\u02B5\u02BD\u02BB\u02B7()
	{
		return this.contentRect.rect.width;
	}

	// Token: 0x17000232 RID: 562
	// (get) Token: 0x06001666 RID: 5734 RVA: 0x000ACB00 File Offset: 0x000AAD00
	private float \u02BE\u02B9\u02B4\u02B6\u02B5\u02C0\u02B6\u02B6\u02B7\u02B8\u02B6
	{
		get
		{
			return this.contentRect.rect.width;
		}
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x00011892 File Offset: 0x0000FA92
	public void \u02C0\u02B4\u02BA\u02B9\u02B2\u02BD\u02B9\u02BD\u02B4\u02B8\u02BA()
	{
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 1349f;
		this.\u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2 = false;
		this.\u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = true;
		this.\u02BA\u02BA\u02B6\u02B3\u02BA\u02BF\u02B3\u02BE\u02C1\u02B3\u02B7 = true;
		this.contentRect.anchoredPosition = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;
	}

	// Token: 0x0400104C RID: 4172
	[SerializeField]
	private float scrollSpeed;

	// Token: 0x0400104D RID: 4173
	[SerializeField]
	private float waitTime;

	// Token: 0x0400104E RID: 4174
	private Vector2 \u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;

	// Token: 0x0400104F RID: 4175
	private float \u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6;

	// Token: 0x04001050 RID: 4176
	private bool \u02C1\u02B7\u02BF\u02BD\u02C0\u02BC\u02B9\u02BF\u02B6\u02C1\u02BE = true;

	// Token: 0x04001051 RID: 4177
	private bool \u02BD\u02BA\u02B9\u02B5\u02B7\u02B9\u02C1\u02B5\u02B2\u02B5\u02B2;

	// Token: 0x04001052 RID: 4178
	private bool \u02BA\u02BA\u02B6\u02B3\u02BA\u02BF\u02B3\u02BE\u02C1\u02B3\u02B7;

	// Token: 0x04001053 RID: 4179
	private RectTransform \u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2;

	// Token: 0x04001054 RID: 4180
	[SerializeField]
	private RectTransform contentRect;
}
