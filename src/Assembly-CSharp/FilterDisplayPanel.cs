using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000092 RID: 146
public class FilterDisplayPanel : MonoBehaviour
{
	// Token: 0x06000603 RID: 1539 RVA: 0x00008F43 File Offset: 0x00007143
	public void \u02B8\u02B8\u02BA\u02B9\u02BE\u02BC\u02BB\u02B7\u02BE\u02B9\u02B7()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02BA\u02B9\u02C0\u02B5\u02C0\u02B7\u02B9\u02B3\u02BE\u02B6\u02C0(this.headerTransform.sizeDelta.y, this.openSize));
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00008F81 File Offset: 0x00007181
	private IEnumerator \u02C0\u02BE\u02B7\u02B9\u02BE\u02BB\u02BA\u02BA\u02BB\u02BD\u02BE(float \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2, float \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9)
	{
		FilterDisplayPanel.\u02BF\u02B9\u02BD\u02B4\u02C0\u02B5\u02B8\u02B3\u02B8\u02B4\u02B3 u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B = new FilterDisplayPanel.\u02BF\u02B9\u02BD\u02B4\u02C0\u02B5\u02B8\u02B3\u02B8\u02B4\u02B3(1);
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.<>4__this = this;
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.startPos = \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2;
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.endPos = \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9;
		return u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B;
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00008F9E File Offset: 0x0000719E
	private IEnumerator \u02C0\u02BB\u02B9\u02BF\u02B8\u02BB\u02BF\u02B3\u02B6\u02B2\u02C0(float \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2, float \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9)
	{
		this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0 = this.headerTransform.sizeDelta;
		float stateSizeDiff = \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9 - \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2;
		float time = 0f;
		while (time < this.animationTime)
		{
			time += Time.deltaTime;
			this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0.y = \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2 + stateSizeDiff * this.animationCurve.Evaluate(time / this.animationTime);
			this.headerTransform.sizeDelta = this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0;
			yield return null;
		}
		this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0.y = \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9;
		this.headerTransform.sizeDelta = this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0;
		yield break;
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00008FBB File Offset: 0x000071BB
	public void \u02C1\u02BB\u02B9\u02B5\u02BC\u02B4\u02B3\u02B2\u02C1\u02C1\u02B3()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02C0\u02BB\u02B9\u02BF\u02B8\u02BB\u02BF\u02B3\u02B6\u02B2\u02C0(this.headerTransform.sizeDelta.y, this.closedSize));
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00008F9E File Offset: 0x0000719E
	private IEnumerator \u02B8\u02B6\u02B3\u02BC\u02B9\u02BD\u02C0\u02BB\u02B2\u02B4\u02B4(float \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2, float \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9)
	{
		this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0 = this.headerTransform.sizeDelta;
		stateSizeDiff = \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9 - \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2;
		time = 0f;
		while (time < this.animationTime)
		{
			time += Time.deltaTime;
			this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0.y = \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2 + stateSizeDiff * this.animationCurve.Evaluate(time / this.animationTime);
			this.headerTransform.sizeDelta = this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0;
			yield return null;
		}
		this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0.y = \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9;
		this.headerTransform.sizeDelta = this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0;
		yield break;
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00009022 File Offset: 0x00007222
	public void \u02B8\u02BE\u02BB\u02BC\u02B3\u02B8\u02BC\u02BA\u02B8\u02B5\u02B8()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02B8\u02B6\u02B3\u02BC\u02B9\u02BD\u02C0\u02BB\u02B2\u02B4\u02B4(this.headerTransform.sizeDelta.y, this.openSize));
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00008F43 File Offset: 0x00007143
	public void \u02BE\u02B8\u02BE\u02BF\u02B3\u02C0\u02B8\u02B3\u02B4\u02BB\u02BB()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02BA\u02B9\u02C0\u02B5\u02C0\u02B7\u02B9\u02B3\u02BE\u02B6\u02C0(this.headerTransform.sizeDelta.y, this.openSize));
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00009060 File Offset: 0x00007260
	public void \u02C1\u02BB\u02BE\u02BC\u02BB\u02C0\u02B7\u02B7\u02BE\u02B9\u02BC()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02BA\u02B9\u02C0\u02B5\u02C0\u02B7\u02B9\u02B3\u02BE\u02B6\u02C0(this.headerTransform.sizeDelta.y, this.closedSize));
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x0000909E File Offset: 0x0000729E
	public void \u02B4\u02B4\u02B4\u02B8\u02B3\u02B6\u02BB\u02BD\u02B6\u02B4\u02BB()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02C0\u02BE\u02B7\u02B9\u02BE\u02BB\u02BA\u02BA\u02BB\u02BD\u02BE(this.headerTransform.sizeDelta.y, this.openSize));
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00008F81 File Offset: 0x00007181
	private IEnumerator \u02BA\u02B8\u02B7\u02C0\u02BF\u02BE\u02BF\u02B4\u02BC\u02B2\u02B9(float \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2, float \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9)
	{
		FilterDisplayPanel.\u02BF\u02B9\u02BD\u02B4\u02C0\u02B5\u02B8\u02B3\u02B8\u02B4\u02B3 u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B = new FilterDisplayPanel.\u02BF\u02B9\u02BD\u02B4\u02C0\u02B5\u02B8\u02B3\u02B8\u02B4\u02B3(1);
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.<>4__this = this;
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.startPos = \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2;
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.endPos = \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9;
		return u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B;
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x000090DC File Offset: 0x000072DC
	public void \u02B6\u02B2\u02C1\u02C0\u02C1\u02B7\u02BC\u02C1\u02BC\u02B7\u02B8()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02B8\u02B6\u02B3\u02BC\u02B9\u02BD\u02C0\u02BB\u02B2\u02B4\u02B4(this.headerTransform.sizeDelta.y, this.closedSize));
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00008F9E File Offset: 0x0000719E
	private IEnumerator \u02BA\u02B9\u02C0\u02B5\u02C0\u02B7\u02B9\u02B3\u02BE\u02B6\u02C0(float \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2, float \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9)
	{
		this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0 = this.headerTransform.sizeDelta;
		stateSizeDiff = \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9 - \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2;
		time = 0f;
		while (time < this.animationTime)
		{
			time += Time.deltaTime;
			this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0.y = \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2 + stateSizeDiff * this.animationCurve.Evaluate(time / this.animationTime);
			this.headerTransform.sizeDelta = this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0;
			yield return null;
		}
		this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0.y = \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9;
		this.headerTransform.sizeDelta = this.\u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0;
		yield break;
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00008F81 File Offset: 0x00007181
	private IEnumerator \u02BE\u02B8\u02B6\u02C1\u02BA\u02BC\u02BF\u02BA\u02B3\u02B7\u02B5(float \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2, float \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9)
	{
		FilterDisplayPanel.\u02BF\u02B9\u02BD\u02B4\u02C0\u02B5\u02B8\u02B3\u02B8\u02B4\u02B3 u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B = new FilterDisplayPanel.\u02BF\u02B9\u02BD\u02B4\u02C0\u02B5\u02B8\u02B3\u02B8\u02B4\u02B3(1);
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.<>4__this = this;
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.startPos = \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2;
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.endPos = \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9;
		return u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B;
	}

	// Token: 0x04000449 RID: 1097
	[SerializeField]
	private float openSize = 110f;

	// Token: 0x0400044A RID: 1098
	[SerializeField]
	private float closedSize = 50f;

	// Token: 0x0400044B RID: 1099
	[SerializeField]
	private float animationTime = 0.3f;

	// Token: 0x0400044C RID: 1100
	[SerializeField]
	private RectTransform headerTransform;

	// Token: 0x0400044D RID: 1101
	[SerializeField]
	private AnimationCurve animationCurve;

	// Token: 0x0400044E RID: 1102
	private Vector2 \u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0;

	// Token: 0x0400044F RID: 1103
	private Coroutine \u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF;
}
