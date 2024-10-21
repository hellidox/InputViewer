using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200003E RID: 62
public class LatencySpreadDisplay : MonoBehaviour
{
	// Token: 0x0600024D RID: 589 RVA: 0x0000711B File Offset: 0x0000531B
	private void \u02B8\u02BF\u02B8\u02B6\u02C0\u02C0\u02C1\u02BE\u02BC\u02B4\u02BC()
	{
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3 = new List<GameObject>();
	}

	// Token: 0x0600024E RID: 590 RVA: 0x0002486C File Offset: 0x00022A6C
	public void \u02BF\u02B7\u02BC\u02C1\u02B8\u02BD\u02BA\u02BC\u02BD\u02BD\u02BC()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	// Token: 0x0600024F RID: 591 RVA: 0x000248C8 File Offset: 0x00022AC8
	public void \u02BA\u02C1\u02BF\u02B6\u02B6\u02B4\u02B9\u02BD\u02B7\u02BF\u02C1(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 271f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	// Token: 0x06000250 RID: 592 RVA: 0x0002486C File Offset: 0x00022A6C
	public void \u02C1\u02B5\u02B5\u02B7\u02BE\u02B6\u02C0\u02B4\u02B9\u02BC\u02BA()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	// Token: 0x06000251 RID: 593 RVA: 0x0000711B File Offset: 0x0000531B
	private void Awake()
	{
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3 = new List<GameObject>();
	}

	// Token: 0x06000252 RID: 594 RVA: 0x0002486C File Offset: 0x00022A6C
	public void \u02BE\u02C1\u02B9\u02B7\u02B9\u02B2\u02B2\u02BF\u02C0\u02BC\u02B9()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00024920 File Offset: 0x00022B20
	public void \u02BC\u02BB\u02BA\u02B3\u02C1\u02BC\u02BD\u02B8\u02C0\u02B7\u02B6(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 60f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00024978 File Offset: 0x00022B78
	public void \u02BC\u02BF\u02C1\u02BA\u02BE\u02BC\u02BD\u02BE\u02B3\u02BB\u02C1(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 0f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	// Token: 0x06000255 RID: 597 RVA: 0x000249D0 File Offset: 0x00022BD0
	public void \u02B8\u02B5\u02BA\u02BE\u02BD\u02BF\u02BD\u02B6\u02B6\u02B8\u02C1(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 734f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	// Token: 0x06000256 RID: 598 RVA: 0x0002486C File Offset: 0x00022A6C
	public void \u02B7\u02B6\u02B8\u02BD\u02BD\u02BA\u02B8\u02B3\u02BB\u02B3\u02B6()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	// Token: 0x06000258 RID: 600 RVA: 0x0002486C File Offset: 0x00022A6C
	public void \u02B4\u02B2\u02B2\u02BF\u02B5\u02BE\u02B7\u02BF\u02B6\u02B3\u02BB()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	// Token: 0x06000259 RID: 601 RVA: 0x0002486C File Offset: 0x00022A6C
	public void \u02C1\u02C1\u02BA\u02BC\u02BE\u02B6\u02BB\u02B2\u02BC\u02C1\u02BD()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	// Token: 0x0600025A RID: 602 RVA: 0x0000711B File Offset: 0x0000531B
	private void \u02B5\u02BD\u02BD\u02BE\u02B9\u02BD\u02B2\u02C1\u02C1\u02B3\u02B6()
	{
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3 = new List<GameObject>();
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00024A28 File Offset: 0x00022C28
	public void \u02B4\u02BD\u02B3\u02B2\u02B8\u02B6\u02C1\u02B3\u02B4\u02BD\u02BB(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 1384f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	// Token: 0x0600025C RID: 604 RVA: 0x0002486C File Offset: 0x00022A6C
	public void \u02B5\u02B7\u02B8\u02BF\u02BD\u02B3\u02B5\u02B9\u02BA\u02B8\u02B7()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	// Token: 0x0600025D RID: 605 RVA: 0x0002486C File Offset: 0x00022A6C
	public void \u02B3\u02B5\u02BC\u02B6\u02B3\u02BB\u02C1\u02BB\u02C1\u02BF\u02BC()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00024A80 File Offset: 0x00022C80
	public void \u02BA\u02B9\u02BA\u02C1\u02B7\u02BA\u02B2\u02B4\u02B5\u02B6\u02B4(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 1396f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00024AD8 File Offset: 0x00022CD8
	public void \u02B7\u02C0\u02BB\u02B5\u02B8\u02BB\u02C0\u02BC\u02B5\u02BF\u02B4(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 875f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	// Token: 0x06000260 RID: 608 RVA: 0x0000711B File Offset: 0x0000531B
	private void \u02B9\u02BD\u02B5\u02C1\u02B6\u02B6\u02BD\u02B9\u02BC\u02C1\u02B3()
	{
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3 = new List<GameObject>();
	}

	// Token: 0x06000261 RID: 609 RVA: 0x0000711B File Offset: 0x0000531B
	private void \u02BF\u02BC\u02B9\u02BE\u02B7\u02BD\u02C1\u02BE\u02BD\u02BD\u02B5()
	{
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3 = new List<GameObject>();
	}

	// Token: 0x06000262 RID: 610 RVA: 0x0000711B File Offset: 0x0000531B
	private void \u02B3\u02B8\u02C1\u02BE\u02B7\u02C0\u02B8\u02B8\u02B3\u02B3\u02B7()
	{
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3 = new List<GameObject>();
	}

	// Token: 0x06000263 RID: 611 RVA: 0x0002486C File Offset: 0x00022A6C
	public void \u02B9\u02BD\u02B2\u02B6\u02B5\u02B2\u02C1\u02B4\u02B7\u02B5\u02B3()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	// Token: 0x04000167 RID: 359
	[SerializeField]
	private GameObject samplePrefab;

	// Token: 0x04000168 RID: 360
	[SerializeField]
	private float maxTime = 1f;

	// Token: 0x04000169 RID: 361
	private List<GameObject> \u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3;

	// Token: 0x0400016A RID: 362
	private float \u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6 = 128f;
}
