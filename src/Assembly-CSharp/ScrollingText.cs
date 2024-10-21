﻿using System;
using TMPro;
using UnityEngine;

// Token: 0x020001F6 RID: 502
[RequireComponent(typeof(TextMeshProUGUI))]
public class ScrollingText : MonoBehaviour
{
	// Token: 0x06001668 RID: 5736 RVA: 0x000ACF90 File Offset: 0x000AB190
	private void \u02C0\u02BB\u02B6\u02B9\u02B3\u02B4\u02B3\u02B7\u02BD\u02B8\u02C0()
	{
		if (!this.\u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8)
		{
			return;
		}
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		if (this.\u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE)
		{
			if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 >= this.waitTime)
			{
				this.Reset();
			}
			return;
		}
		if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 < this.waitTime)
		{
			return;
		}
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = new Vector2(this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition.x - this.scrollSpeed * Time.deltaTime, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
		if (this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition.x <= this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE)
		{
			this.\u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE = false;
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = new Vector2(this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
			this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 345f;
		}
	}

	// Token: 0x06001669 RID: 5737 RVA: 0x000AD068 File Offset: 0x000AB268
	private void Update()
	{
		if (!this.\u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8)
		{
			return;
		}
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		if (this.\u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE)
		{
			if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 >= this.waitTime)
			{
				this.Reset();
			}
			return;
		}
		if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 < this.waitTime)
		{
			return;
		}
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = new Vector2(this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition.x - this.scrollSpeed * Time.deltaTime, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
		if (this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition.x <= this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE)
		{
			this.\u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE = true;
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = new Vector2(this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
			this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 0f;
		}
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x000118C5 File Offset: 0x0000FAC5
	public void \u02B7\u02BF\u02B4\u02B4\u02C1\u02BE\u02BF\u02B5\u02B4\u02BB\u02BE(string \u02BA\u02B2\u02C0\u02B9\u02B7\u02B4\u02BA\u02B7\u02B2\u02B7\u02B6, Color \u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2, bool \u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8 = true)
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.color = \u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2;
		this.\u02BA\u02BC\u02BD\u02B4\u02B3\u02B9\u02B2\u02B4\u02C0\u02B5\u02B5(\u02BA\u02B2\u02C0\u02B9\u02B7\u02B4\u02BA\u02B7\u02B2\u02B7\u02B6, \u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8);
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x000AD140 File Offset: 0x000AB340
	private void \u02B7\u02BF\u02BC\u02C0\u02B5\u02BD\u02BF\u02BB\u02C1\u02BF\u02B2()
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = base.GetComponent<TextMeshProUGUI>();
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.GetComponent<RectTransform>();
		this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1 = this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition;
		if (!this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x000118DB File Offset: 0x0000FADB
	private void \u02B7\u02B9\u02B6\u02BB\u02BF\u02BB\u02BF\u02BD\u02B6\u02B9\u02C1()
	{
		this.Reset();
		if (this.autoScroll)
		{
			this.\u02C0\u02C1\u02BE\u02BB\u02BF\u02BB\u02B4\u02B6\u02B4\u02B8\u02B5();
		}
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x000AD190 File Offset: 0x000AB390
	private void \u02B3\u02B8\u02C1\u02BE\u02B7\u02C0\u02B8\u02B8\u02B3\u02B3\u02B7()
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = base.GetComponent<TextMeshProUGUI>();
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.GetComponent<RectTransform>();
		this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1 = this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition;
		if (!this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x000118F1 File Offset: 0x0000FAF1
	public void \u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(string \u02BA\u02B2\u02C0\u02B9\u02B7\u02B4\u02BA\u02B7\u02B2\u02B7\u02B6, Color \u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2, bool \u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8 = true)
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.color = \u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2;
		this.\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(\u02BA\u02B2\u02C0\u02B9\u02B7\u02B4\u02BA\u02B7\u02B2\u02B7\u02B6, \u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8);
	}

	// Token: 0x0600166F RID: 5743 RVA: 0x000AD1E0 File Offset: 0x000AB3E0
	private void \u02BB\u02B7\u02C0\u02B3\u02C1\u02BD\u02B9\u02B2\u02B4\u02BE\u02B6()
	{
		if (!this.\u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8)
		{
			return;
		}
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		if (this.\u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE)
		{
			if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 >= this.waitTime)
			{
				this.Reset();
			}
			return;
		}
		if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 < this.waitTime)
		{
			return;
		}
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = new Vector2(this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition.x - this.scrollSpeed * Time.deltaTime, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
		if (this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition.x <= this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE)
		{
			this.\u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE = false;
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = new Vector2(this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
			this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 1944f;
		}
	}

	// Token: 0x06001671 RID: 5745 RVA: 0x00011907 File Offset: 0x0000FB07
	private void OnEnable()
	{
		this.Reset();
		if (this.autoScroll)
		{
			this.\u02B6\u02B6\u02B3\u02B6\u02BE\u02BD\u02B7\u02B7\u02BB\u02B5\u02B4();
		}
	}

	// Token: 0x06001672 RID: 5746 RVA: 0x0001191D File Offset: 0x0000FB1D
	public void \u02BA\u02BC\u02BD\u02B4\u02B3\u02B9\u02B2\u02B4\u02C0\u02B5\u02B5(string \u02BA\u02B2\u02C0\u02B9\u02B7\u02B4\u02BA\u02B7\u02B2\u02B7\u02B6, bool \u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8 = true)
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = \u02BA\u02B2\u02C0\u02B9\u02B7\u02B4\u02BA\u02B7\u02B2\u02B7\u02B6;
		this.\u02C0\u02C1\u02BE\u02BB\u02BF\u02BB\u02B4\u02B6\u02B4\u02B8\u02B5();
		this.Reset();
		if (this.\u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8)
		{
			this.\u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8 = \u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8;
		}
	}

	// Token: 0x06001673 RID: 5747 RVA: 0x000AD2B8 File Offset: 0x000AB4B8
	private void \u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0()
	{
		if (!this.\u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8)
		{
			return;
		}
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		if (this.\u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE)
		{
			if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 >= this.waitTime)
			{
				this.Reset();
			}
			return;
		}
		if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 < this.waitTime)
		{
			return;
		}
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = new Vector2(this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition.x - this.scrollSpeed * Time.deltaTime, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
		if (this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition.x <= this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE)
		{
			this.\u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE = true;
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = new Vector2(this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
			this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 1173f;
		}
	}

	// Token: 0x06001674 RID: 5748 RVA: 0x000AD390 File Offset: 0x000AB590
	private void \u02B6\u02B6\u02B3\u02B6\u02BE\u02BD\u02B7\u02B7\u02BB\u02B5\u02B4()
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.ForceMeshUpdate(false, false);
		this.\u02BE\u02C0\u02BC\u02BE\u02B8\u02B8\u02B9\u02B9\u02C0\u02BE\u02C0 = this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.GetRenderedValues(false).x - 40f;
		this.\u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8 = this.\u02BE\u02C0\u02BC\u02BE\u02B8\u02B8\u02B9\u02B9\u02C0\u02BE\u02C0 > this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.rect.width;
		if (this.alignToRight)
		{
			this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x + (this.\u02BE\u02C0\u02BC\u02BE\u02B8\u02B8\u02B9\u02B9\u02C0\u02BE\u02C0 - this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.rect.width) - this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x - (this.\u02BE\u02C0\u02BC\u02BE\u02B8\u02B8\u02B9\u02B9\u02C0\u02BE\u02C0 - this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.rect.width);
			return;
		}
		this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x - (this.\u02BE\u02C0\u02BC\u02BE\u02B8\u02B8\u02B9\u02B9\u02C0\u02BE\u02C0 - this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.rect.width);
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x000AD470 File Offset: 0x000AB670
	private void Reset()
	{
		if (!this.\u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8)
		{
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;
			return;
		}
		if (this.alignToRight)
		{
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = new Vector2(this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x + (this.\u02BE\u02C0\u02BC\u02BE\u02B8\u02B8\u02B9\u02B9\u02C0\u02BE\u02C0 - this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.rect.width), this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
		}
		else
		{
			this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.rectTransform.anchoredPosition = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;
		}
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 0f;
		this.\u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE = false;
	}

	// Token: 0x06001676 RID: 5750 RVA: 0x000AD50C File Offset: 0x000AB70C
	private void \u02BA\u02BA\u02C0\u02BA\u02BC\u02B9\u02B5\u02BE\u02BA\u02C0\u02BD()
	{
		if (!this.\u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8)
		{
			return;
		}
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		if (this.\u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE)
		{
			if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 >= this.waitTime)
			{
				this.Reset();
			}
			return;
		}
		if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 < this.waitTime)
		{
			return;
		}
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = new Vector2(this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition.x - this.scrollSpeed * Time.deltaTime, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
		if (this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition.x <= this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE)
		{
			this.\u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE = true;
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = new Vector2(this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
			this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 1901f;
		}
	}

	// Token: 0x06001677 RID: 5751 RVA: 0x000AD5E4 File Offset: 0x000AB7E4
	private void \u02C0\u02C1\u02BE\u02BB\u02BF\u02BB\u02B4\u02B6\u02B4\u02B8\u02B5()
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.ForceMeshUpdate(true, false);
		this.\u02BE\u02C0\u02BC\u02BE\u02B8\u02B8\u02B9\u02B9\u02C0\u02BE\u02C0 = this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.GetRenderedValues(false).x - 652f;
		this.\u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8 = this.\u02BE\u02C0\u02BC\u02BE\u02B8\u02B8\u02B9\u02B9\u02C0\u02BE\u02C0 > this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.rect.width;
		if (this.alignToRight)
		{
			this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x + (this.\u02BE\u02C0\u02BC\u02BE\u02B8\u02B8\u02B9\u02B9\u02C0\u02BE\u02C0 - this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.rect.width) - this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x - (this.\u02BE\u02C0\u02BC\u02BE\u02B8\u02B8\u02B9\u02B9\u02C0\u02BE\u02C0 - this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.rect.width);
			return;
		}
		this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.x - (this.\u02BE\u02C0\u02BC\u02BE\u02B8\u02B8\u02B9\u02B9\u02C0\u02BE\u02C0 - this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.rect.width);
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x000AD140 File Offset: 0x000AB340
	private void \u02B8\u02BF\u02B8\u02B6\u02C0\u02C0\u02C1\u02BE\u02BC\u02B4\u02BC()
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = base.GetComponent<TextMeshProUGUI>();
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.GetComponent<RectTransform>();
		this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1 = this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition;
		if (!this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x00011946 File Offset: 0x0000FB46
	public void \u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(string \u02BA\u02B2\u02C0\u02B9\u02B7\u02B4\u02BA\u02B7\u02B2\u02B7\u02B6, bool \u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8 = true)
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = \u02BA\u02B2\u02C0\u02B9\u02B7\u02B4\u02BA\u02B7\u02B2\u02B7\u02B6;
		this.\u02B6\u02B6\u02B3\u02B6\u02BE\u02BD\u02B7\u02B7\u02BB\u02B5\u02B4();
		this.Reset();
		if (this.\u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8)
		{
			this.\u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8 = \u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8;
		}
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x000AD6C4 File Offset: 0x000AB8C4
	private void \u02C1\u02B8\u02B5\u02BD\u02BD\u02C0\u02BB\u02B4\u02BD\u02B8\u02B3()
	{
		if (!this.\u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8)
		{
			return;
		}
		this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 += Time.deltaTime;
		if (this.\u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE)
		{
			if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 >= this.waitTime)
			{
				this.Reset();
			}
			return;
		}
		if (this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 < this.waitTime)
		{
			return;
		}
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = new Vector2(this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition.x - this.scrollSpeed * Time.deltaTime, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
		if (this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition.x <= this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE)
		{
			this.\u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE = false;
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition = new Vector2(this.\u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE, this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1.y);
			this.\u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6 = 34f;
		}
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x000AD190 File Offset: 0x000AB390
	private void Awake()
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = base.GetComponent<TextMeshProUGUI>();
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.GetComponent<RectTransform>();
		this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1 = this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.anchoredPosition;
		if (!this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x000118C5 File Offset: 0x0000FAC5
	public void \u02B8\u02BD\u02BC\u02B7\u02C0\u02BB\u02B3\u02B4\u02BA\u02BF\u02BB(string \u02BA\u02B2\u02C0\u02B9\u02B7\u02B4\u02BA\u02B7\u02B2\u02B7\u02B6, Color \u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2, bool \u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8 = true)
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.color = \u02BC\u02BC\u02C1\u02C1\u02BE\u02B7\u02BE\u02BC\u02BB\u02B3\u02B2;
		this.\u02BA\u02BC\u02BD\u02B4\u02B3\u02B9\u02B2\u02B4\u02C0\u02B5\u02B5(\u02BA\u02B2\u02C0\u02B9\u02B7\u02B4\u02BA\u02B7\u02B2\u02B7\u02B6, \u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8);
	}

	// Token: 0x04001055 RID: 4181
	[SerializeField]
	private float scrollSpeed;

	// Token: 0x04001056 RID: 4182
	[SerializeField]
	private float waitTime;

	// Token: 0x04001057 RID: 4183
	[SerializeField]
	private bool alignToRight;

	// Token: 0x04001058 RID: 4184
	[SerializeField]
	private bool autoScroll;

	// Token: 0x04001059 RID: 4185
	private TextMeshProUGUI \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF;

	// Token: 0x0400105A RID: 4186
	private Vector2 \u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;

	// Token: 0x0400105B RID: 4187
	private float \u02BF\u02BC\u02B6\u02B5\u02C0\u02BB\u02BA\u02BD\u02B6\u02B3\u02BE;

	// Token: 0x0400105C RID: 4188
	private float \u02B9\u02B6\u02C0\u02C0\u02B7\u02B4\u02B7\u02BC\u02BA\u02BF\u02B6;

	// Token: 0x0400105D RID: 4189
	private float \u02BE\u02C0\u02BC\u02BE\u02B8\u02B8\u02B9\u02B9\u02C0\u02BE\u02C0;

	// Token: 0x0400105E RID: 4190
	private bool \u02B3\u02B6\u02BC\u02BE\u02B2\u02BE\u02BC\u02B5\u02BB\u02BF\u02B8;

	// Token: 0x0400105F RID: 4191
	private bool \u02B2\u02BD\u02BB\u02C1\u02B7\u02B3\u02C0\u02B4\u02BE\u02BE\u02BE;

	// Token: 0x04001060 RID: 4192
	private RectTransform \u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2;
}
