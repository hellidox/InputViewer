﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000011 RID: 17
public class Transition : MonoBehaviour
{
	// Token: 0x060000B5 RID: 181 RVA: 0x000063CE File Offset: 0x000045CE
	private IEnumerator \u02B6\u02C1\u02B2\u02BC\u02C1\u02B8\u02B6\u02B4\u02B2\u02BF\u02BD(float \u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3, Transform \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7, Vector3 \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4, float \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
	{
		CanvasRenderer[] canvasRenderers = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7.GetComponentsInChildren<CanvasRenderer>();
		CanvasRenderer[] array = canvasRenderers;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetAlpha(1f);
		}
		RectTransform rT = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7 as RectTransform;
		if (\u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6 > 0f)
		{
			yield return new WaitForSecondsRealtime(\u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3);
			for (float t = 1f; t >= 0f; t -= Time.deltaTime * \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
			{
				rT.anchoredPosition3D = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4 + Vector3.Lerp(this.\u02B3\u02BE\u02B8\u02BC\u02BA\u02BB\u02B8\u02B4\u02BA\u02B4\u02C1, this.\u02B5\u02B2\u02C0\u02BF\u02BE\u02B7\u02BB\u02B2\u02BF\u02C1\u02BC, this.\u02BD\u02BA\u02B6\u02B6\u02B9\u02BE\u02B8\u02B3\u02B7\u02B8\u02BD.Evaluate(t));
				foreach (CanvasRenderer canvasRenderer in canvasRenderers)
				{
					float num = this.\u02B2\u02BF\u02C1\u02BA\u02BE\u02C0\u02BC\u02BE\u02B2\u02C0\u02B7.Evaluate(t);
					canvasRenderer.SetAlpha(num);
				}
				yield return new WaitForEndOfFrame();
			}
		}
		rT.anchoredPosition3D = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4 + this.\u02B3\u02BE\u02B8\u02BC\u02BA\u02BB\u02B8\u02B4\u02BA\u02B4\u02C1;
		array = canvasRenderers;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetAlpha(0f);
		}
		yield return null;
		yield break;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x000063CE File Offset: 0x000045CE
	private IEnumerator \u02B7\u02BF\u02B3\u02BF\u02B8\u02C1\u02BC\u02B5\u02BC\u02C1\u02BB(float \u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3, Transform \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7, Vector3 \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4, float \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
	{
		canvasRenderers = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7.GetComponentsInChildren<CanvasRenderer>();
		CanvasRenderer[] array = canvasRenderers;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetAlpha(1f);
		}
		rT = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7 as RectTransform;
		if (\u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6 > 0f)
		{
			yield return new WaitForSecondsRealtime(\u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3);
			for (t = 1f; t >= 0f; t -= Time.deltaTime * \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
			{
				rT.anchoredPosition3D = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4 + Vector3.Lerp(this.\u02B3\u02BE\u02B8\u02BC\u02BA\u02BB\u02B8\u02B4\u02BA\u02B4\u02C1, this.\u02B5\u02B2\u02C0\u02BF\u02BE\u02B7\u02BB\u02B2\u02BF\u02C1\u02BC, this.\u02BD\u02BA\u02B6\u02B6\u02B9\u02BE\u02B8\u02B3\u02B7\u02B8\u02BD.Evaluate(t));
				foreach (CanvasRenderer canvasRenderer in canvasRenderers)
				{
					float num = this.\u02B2\u02BF\u02C1\u02BA\u02BE\u02C0\u02BC\u02BE\u02B2\u02C0\u02B7.Evaluate(t);
					canvasRenderer.SetAlpha(num);
				}
				yield return new WaitForEndOfFrame();
			}
		}
		rT.anchoredPosition3D = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4 + this.\u02B3\u02BE\u02B8\u02BC\u02BA\u02BB\u02B8\u02B4\u02BA\u02B4\u02C1;
		array = canvasRenderers;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetAlpha(0f);
		}
		yield return null;
		yield break;
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x000063FA File Offset: 0x000045FA
	private IEnumerator \u02C0\u02B2\u02B2\u02B9\u02C0\u02BF\u02BA\u02BE\u02BC\u02B3\u02B3(float \u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3, Transform \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7, Vector3 \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4, float \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
	{
		CanvasRenderer[] canvasRenderers = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7.GetComponentsInChildren<CanvasRenderer>();
		CanvasRenderer[] array = canvasRenderers;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetAlpha(0f);
		}
		RectTransform rT = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7 as RectTransform;
		if (\u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6 > 0f)
		{
			yield return new WaitForSecondsRealtime(\u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3);
			for (float t = 0f; t <= 1f; t += Time.deltaTime * \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
			{
				rT.anchoredPosition3D = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4 + Vector3.Lerp(this.\u02B3\u02BE\u02B8\u02BC\u02BA\u02BB\u02B8\u02B4\u02BA\u02B4\u02C1, this.\u02B5\u02B2\u02C0\u02BF\u02BE\u02B7\u02BB\u02B2\u02BF\u02C1\u02BC, this.\u02BD\u02BA\u02B6\u02B6\u02B9\u02BE\u02B8\u02B3\u02B7\u02B8\u02BD.Evaluate(t));
				foreach (CanvasRenderer canvasRenderer in canvasRenderers)
				{
					float num = this.\u02B2\u02BF\u02C1\u02BA\u02BE\u02C0\u02BC\u02BE\u02B2\u02C0\u02B7.Evaluate(t);
					canvasRenderer.SetAlpha(num);
				}
				yield return new WaitForEndOfFrame();
			}
		}
		rT.anchoredPosition3D = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4 + this.\u02B5\u02B2\u02C0\u02BF\u02BE\u02B7\u02BB\u02B2\u02BF\u02C1\u02BC;
		array = canvasRenderers;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetAlpha(1f);
		}
		yield return null;
		yield break;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x0001B38C File Offset: 0x0001958C
	public void \u02C1\u02BA\u02BD\u02B4\u02BD\u02B2\u02C0\u02B6\u02B5\u02BE\u02BD(bool \u02C1\u02C1\u02B2\u02B2\u02B6\u02B5\u02B7\u02B6\u02B9\u02BC\u02B5 = true, float \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC = 0f)
	{
		if (this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1 == null)
		{
			this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1 = new List<Coroutine>();
			for (int i = 1; i < this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3.Count; i += 0)
			{
				this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1.Add(null);
			}
		}
		for (int j = 1; j < this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3.Count; j++)
		{
			Transform transform = this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3[j];
			Vector3 vector = this.\u02B7\u02C0\u02BD\u02B7\u02B2\u02B8\u02C1\u02BA\u02BA\u02B5\u02B2[j];
			if (this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1[j] != null)
			{
				base.StopCoroutine(this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1[j]);
			}
			if (\u02C1\u02C1\u02B2\u02B2\u02B6\u02B5\u02B7\u02B6\u02B9\u02BC\u02B5)
			{
				this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1[j] = base.StartCoroutine(this.\u02B6\u02BE\u02BA\u02B4\u02BB\u02B8\u02B6\u02B3\u02BD\u02B8\u02BF(this.\u02C1\u02B5\u02BD\u02B9\u02BC\u02B2\u02B8\u02C0\u02B5\u02BF\u02C1 * (float)j + \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC, transform, vector, this.\u02B6\u02C1\u02C0\u02C0\u02BC\u02BA\u02BF\u02BA\u02B2\u02B7\u02BB));
			}
			else
			{
				this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1[j] = base.StartCoroutine(this.\u02B7\u02BF\u02B3\u02BF\u02B8\u02C1\u02BC\u02B5\u02BC\u02C1\u02BB(this.\u02C1\u02B5\u02BD\u02B9\u02BC\u02B2\u02B8\u02C0\u02B5\u02BF\u02C1 * (float)(this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3.Count - 0 - j) + \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC, transform, vector, this.\u02B6\u02C1\u02C0\u02C0\u02BC\u02BA\u02BF\u02BA\u02B2\u02B7\u02BB));
			}
		}
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x0001B490 File Offset: 0x00019690
	public void \u02BA\u02C0\u02B9\u02BA\u02B8\u02B4\u02BA\u02B3\u02B3\u02B3\u02C0(bool \u02C1\u02C1\u02B2\u02B2\u02B6\u02B5\u02B7\u02B6\u02B9\u02BC\u02B5 = true, float \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC = 0f)
	{
		if (this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1 == null)
		{
			this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1 = new List<Coroutine>();
			for (int i = 0; i < this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3.Count; i++)
			{
				this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1.Add(null);
			}
		}
		for (int j = 0; j < this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3.Count; j++)
		{
			Transform transform = this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3[j];
			Vector3 vector = this.\u02B7\u02C0\u02BD\u02B7\u02B2\u02B8\u02C1\u02BA\u02BA\u02B5\u02B2[j];
			if (this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1[j] != null)
			{
				base.StopCoroutine(this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1[j]);
			}
			if (\u02C1\u02C1\u02B2\u02B2\u02B6\u02B5\u02B7\u02B6\u02B9\u02BC\u02B5)
			{
				this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1[j] = base.StartCoroutine(this.\u02B6\u02BE\u02BA\u02B4\u02BB\u02B8\u02B6\u02B3\u02BD\u02B8\u02BF(this.\u02C1\u02B5\u02BD\u02B9\u02BC\u02B2\u02B8\u02C0\u02B5\u02BF\u02C1 * (float)j + \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC, transform, vector, this.\u02B6\u02C1\u02C0\u02C0\u02BC\u02BA\u02BF\u02BA\u02B2\u02B7\u02BB));
			}
			else
			{
				this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1[j] = base.StartCoroutine(this.\u02B6\u02C1\u02B2\u02BC\u02C1\u02B8\u02B6\u02B4\u02B2\u02BF\u02BD(this.\u02C1\u02B5\u02BD\u02B9\u02BC\u02B2\u02B8\u02C0\u02B5\u02BF\u02C1 * (float)(this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3.Count - 1 - j) + \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC, transform, vector, this.\u02B6\u02C1\u02C0\u02C0\u02BC\u02BA\u02BF\u02BA\u02B2\u02B7\u02BB));
			}
		}
	}

	// Token: 0x060000BA RID: 186 RVA: 0x000063FA File Offset: 0x000045FA
	private IEnumerator \u02B3\u02BC\u02B4\u02B6\u02B5\u02BC\u02BC\u02BB\u02B6\u02BA\u02C1(float \u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3, Transform \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7, Vector3 \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4, float \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
	{
		canvasRenderers = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7.GetComponentsInChildren<CanvasRenderer>();
		CanvasRenderer[] array = canvasRenderers;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetAlpha(0f);
		}
		rT = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7 as RectTransform;
		if (\u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6 > 0f)
		{
			yield return new WaitForSecondsRealtime(\u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3);
			for (t = 0f; t <= 1f; t += Time.deltaTime * \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
			{
				rT.anchoredPosition3D = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4 + Vector3.Lerp(this.\u02B3\u02BE\u02B8\u02BC\u02BA\u02BB\u02B8\u02B4\u02BA\u02B4\u02C1, this.\u02B5\u02B2\u02C0\u02BF\u02BE\u02B7\u02BB\u02B2\u02BF\u02C1\u02BC, this.\u02BD\u02BA\u02B6\u02B6\u02B9\u02BE\u02B8\u02B3\u02B7\u02B8\u02BD.Evaluate(t));
				foreach (CanvasRenderer canvasRenderer in canvasRenderers)
				{
					float num = this.\u02B2\u02BF\u02C1\u02BA\u02BE\u02C0\u02BC\u02BE\u02B2\u02C0\u02B7.Evaluate(t);
					canvasRenderer.SetAlpha(num);
				}
				yield return new WaitForEndOfFrame();
			}
		}
		rT.anchoredPosition3D = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4 + this.\u02B5\u02B2\u02C0\u02BF\u02BE\u02B7\u02BB\u02B2\u02BF\u02C1\u02BC;
		array = canvasRenderers;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetAlpha(1f);
		}
		yield return null;
		yield break;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x0001B594 File Offset: 0x00019794
	public void \u02B8\u02BB\u02BD\u02B3\u02BF\u02BF\u02BE\u02BF\u02BA\u02BC\u02BE(bool \u02C1\u02C1\u02B2\u02B2\u02B6\u02B5\u02B7\u02B6\u02B9\u02BC\u02B5 = true, float \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC = 0f)
	{
		if (this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1 == null)
		{
			this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1 = new List<Coroutine>();
			for (int i = 0; i < this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3.Count; i++)
			{
				this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1.Add(null);
			}
		}
		for (int j = 0; j < this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3.Count; j++)
		{
			Transform transform = this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3[j];
			Vector3 vector = this.\u02B7\u02C0\u02BD\u02B7\u02B2\u02B8\u02C1\u02BA\u02BA\u02B5\u02B2[j];
			if (this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1[j] != null)
			{
				base.StopCoroutine(this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1[j]);
			}
			if (\u02C1\u02C1\u02B2\u02B2\u02B6\u02B5\u02B7\u02B6\u02B9\u02BC\u02B5)
			{
				this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1[j] = base.StartCoroutine(this.\u02B3\u02BC\u02B4\u02B6\u02B5\u02BC\u02BC\u02BB\u02B6\u02BA\u02C1(this.\u02C1\u02B5\u02BD\u02B9\u02BC\u02B2\u02B8\u02C0\u02B5\u02BF\u02C1 * (float)j + \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC, transform, vector, this.\u02B6\u02C1\u02C0\u02C0\u02BC\u02BA\u02BF\u02BA\u02B2\u02B7\u02BB));
			}
			else
			{
				this.\u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1[j] = base.StartCoroutine(this.\u02B5\u02BE\u02BD\u02B3\u02BA\u02B6\u02B4\u02BE\u02B5\u02BA\u02B6(this.\u02C1\u02B5\u02BD\u02B9\u02BC\u02B2\u02B8\u02C0\u02B5\u02BF\u02C1 * (float)(this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3.Count - 1 - j) + \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC, transform, vector, this.\u02B6\u02C1\u02C0\u02C0\u02BC\u02BA\u02BF\u02BA\u02B2\u02B7\u02BB));
			}
		}
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00006444 File Offset: 0x00004644
	private IEnumerator \u02B5\u02BE\u02BD\u02B3\u02BA\u02B6\u02B4\u02BE\u02B5\u02BA\u02B6(float \u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3, Transform \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7, Vector3 \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4, float \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
	{
		Transition.\u02B2\u02BF\u02B5\u02BA\u02BA\u02BB\u02B3\u02B7\u02BE\u02B6\u02BC u02B2_u02BF_u02B5_u02BA_u02BA_u02BB_u02B3_u02B7_u02BE_u02B6_u02BC = new Transition.\u02B2\u02BF\u02B5\u02BA\u02BA\u02BB\u02B3\u02B7\u02BE\u02B6\u02BC(1);
		u02B2_u02BF_u02B5_u02BA_u02BA_u02BB_u02B3_u02B7_u02BE_u02B6_u02BC.<>4__this = this;
		u02B2_u02BF_u02B5_u02BA_u02BA_u02BB_u02B3_u02B7_u02BE_u02B6_u02BC._offset = \u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3;
		u02B2_u02BF_u02B5_u02BA_u02BA_u02BB_u02B3_u02B7_u02BE_u02B6_u02BC.animatedComponent = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7;
		u02B2_u02BF_u02B5_u02BA_u02BA_u02BB_u02B3_u02B7_u02BE_u02B6_u02BC.originalPosition = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4;
		u02B2_u02BF_u02B5_u02BA_u02BA_u02BB_u02B3_u02B7_u02BE_u02B6_u02BC._speed = \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6;
		return u02B2_u02BF_u02B5_u02BA_u02BA_u02BB_u02B3_u02B7_u02BE_u02B6_u02BC;
	}

	// Token: 0x060000BE RID: 190 RVA: 0x0001B698 File Offset: 0x00019898
	private void \u02BA\u02B9\u02BF\u02BC\u02C1\u02B9\u02B7\u02B4\u02C1\u02BB\u02BB()
	{
		this.\u02B7\u02C0\u02BD\u02B7\u02B2\u02B8\u02C1\u02BA\u02BA\u02B5\u02B2 = new List<Vector3>();
		foreach (Transform transform in this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3)
		{
			this.\u02B7\u02C0\u02BD\u02B7\u02B2\u02B8\u02C1\u02BA\u02BA\u02B5\u02B2.Add((transform.transform as RectTransform).anchoredPosition3D);
		}
	}

	// Token: 0x060000BF RID: 191 RVA: 0x0001B698 File Offset: 0x00019898
	private void OnEnable()
	{
		this.\u02B7\u02C0\u02BD\u02B7\u02B2\u02B8\u02C1\u02BA\u02BA\u02B5\u02B2 = new List<Vector3>();
		foreach (Transform transform in this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3)
		{
			this.\u02B7\u02C0\u02BD\u02B7\u02B2\u02B8\u02C1\u02BA\u02BA\u02B5\u02B2.Add((transform.transform as RectTransform).anchoredPosition3D);
		}
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x000063FA File Offset: 0x000045FA
	private IEnumerator \u02B4\u02B8\u02BE\u02B5\u02B7\u02B3\u02BB\u02B7\u02B5\u02BE\u02B2(float \u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3, Transform \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7, Vector3 \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4, float \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
	{
		canvasRenderers = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7.GetComponentsInChildren<CanvasRenderer>();
		CanvasRenderer[] array = canvasRenderers;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetAlpha(0f);
		}
		rT = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7 as RectTransform;
		if (\u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6 > 0f)
		{
			yield return new WaitForSecondsRealtime(\u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3);
			for (t = 0f; t <= 1f; t += Time.deltaTime * \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
			{
				rT.anchoredPosition3D = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4 + Vector3.Lerp(this.\u02B3\u02BE\u02B8\u02BC\u02BA\u02BB\u02B8\u02B4\u02BA\u02B4\u02C1, this.\u02B5\u02B2\u02C0\u02BF\u02BE\u02B7\u02BB\u02B2\u02BF\u02C1\u02BC, this.\u02BD\u02BA\u02B6\u02B6\u02B9\u02BE\u02B8\u02B3\u02B7\u02B8\u02BD.Evaluate(t));
				foreach (CanvasRenderer canvasRenderer in canvasRenderers)
				{
					float num = this.\u02B2\u02BF\u02C1\u02BA\u02BE\u02C0\u02BC\u02BE\u02B2\u02C0\u02B7.Evaluate(t);
					canvasRenderer.SetAlpha(num);
				}
				yield return new WaitForEndOfFrame();
			}
		}
		rT.anchoredPosition3D = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4 + this.\u02B5\u02B2\u02C0\u02BF\u02BE\u02B7\u02BB\u02B2\u02BF\u02C1\u02BC;
		array = canvasRenderers;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetAlpha(1f);
		}
		yield return null;
		yield break;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x0001B698 File Offset: 0x00019898
	private void \u02C0\u02B4\u02BF\u02B7\u02BD\u02B7\u02B6\u02BA\u02B6\u02BD\u02B3()
	{
		this.\u02B7\u02C0\u02BD\u02B7\u02B2\u02B8\u02C1\u02BA\u02BA\u02B5\u02B2 = new List<Vector3>();
		foreach (Transform transform in this.\u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3)
		{
			this.\u02B7\u02C0\u02BD\u02B7\u02B2\u02B8\u02C1\u02BA\u02BA\u02B5\u02B2.Add((transform.transform as RectTransform).anchoredPosition3D);
		}
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00006470 File Offset: 0x00004670
	private IEnumerator \u02B9\u02B9\u02B7\u02BC\u02B8\u02B6\u02BC\u02C0\u02BF\u02BE\u02B7(float \u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3, Transform \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7, Vector3 \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4, float \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
	{
		Transition.\u02BA\u02B8\u02B8\u02BB\u02B8\u02B2\u02BD\u02B5\u02BC\u02C0\u02B7 u02BA_u02B8_u02B8_u02BB_u02B8_u02B2_u02BD_u02B5_u02BC_u02C0_u02B = new Transition.\u02BA\u02B8\u02B8\u02BB\u02B8\u02B2\u02BD\u02B5\u02BC\u02C0\u02B7(1);
		u02BA_u02B8_u02B8_u02BB_u02B8_u02B2_u02BD_u02B5_u02BC_u02C0_u02B.<>4__this = this;
		u02BA_u02B8_u02B8_u02BB_u02B8_u02B2_u02BD_u02B5_u02BC_u02C0_u02B._offset = \u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3;
		u02BA_u02B8_u02B8_u02BB_u02B8_u02B2_u02BD_u02B5_u02BC_u02C0_u02B.animatedComponent = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7;
		u02BA_u02B8_u02B8_u02BB_u02B8_u02B2_u02BD_u02B5_u02BC_u02C0_u02B.originalPosition = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4;
		u02BA_u02B8_u02B8_u02BB_u02B8_u02B2_u02BD_u02B5_u02BC_u02C0_u02B._speed = \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6;
		return u02BA_u02B8_u02B8_u02BB_u02B8_u02B2_u02BD_u02B5_u02BC_u02C0_u02B;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x000063FA File Offset: 0x000045FA
	private IEnumerator \u02B6\u02BE\u02BA\u02B4\u02BB\u02B8\u02B6\u02B3\u02BD\u02B8\u02BF(float \u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3, Transform \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7, Vector3 \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4, float \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
	{
		canvasRenderers = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7.GetComponentsInChildren<CanvasRenderer>();
		CanvasRenderer[] array = canvasRenderers;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetAlpha(0f);
		}
		rT = \u02BE\u02B6\u02BC\u02BF\u02B8\u02B5\u02C1\u02B9\u02BC\u02B9\u02B7 as RectTransform;
		if (\u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6 > 0f)
		{
			yield return new WaitForSecondsRealtime(\u02BE\u02B4\u02BF\u02BD\u02BD\u02C1\u02BC\u02BD\u02BC\u02BD\u02B3);
			for (t = 0f; t <= 1f; t += Time.deltaTime * \u02BC\u02C0\u02BA\u02B4\u02B8\u02B4\u02B5\u02BF\u02BA\u02B5\u02B6)
			{
				rT.anchoredPosition3D = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4 + Vector3.Lerp(this.\u02B3\u02BE\u02B8\u02BC\u02BA\u02BB\u02B8\u02B4\u02BA\u02B4\u02C1, this.\u02B5\u02B2\u02C0\u02BF\u02BE\u02B7\u02BB\u02B2\u02BF\u02C1\u02BC, this.\u02BD\u02BA\u02B6\u02B6\u02B9\u02BE\u02B8\u02B3\u02B7\u02B8\u02BD.Evaluate(t));
				foreach (CanvasRenderer canvasRenderer in canvasRenderers)
				{
					float num = this.\u02B2\u02BF\u02C1\u02BA\u02BE\u02C0\u02BC\u02BE\u02B2\u02C0\u02B7.Evaluate(t);
					canvasRenderer.SetAlpha(num);
				}
				yield return new WaitForEndOfFrame();
			}
		}
		rT.anchoredPosition3D = \u02B8\u02B2\u02B9\u02BE\u02B5\u02B2\u02BD\u02B6\u02B9\u02BB\u02B4 + this.\u02B5\u02B2\u02C0\u02BF\u02BE\u02B7\u02BB\u02B2\u02BF\u02C1\u02BC;
		array = canvasRenderers;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetAlpha(1f);
		}
		yield return null;
		yield break;
	}

	// Token: 0x04000038 RID: 56
	public float \u02B6\u02C1\u02C0\u02C0\u02BC\u02BA\u02BF\u02BA\u02B2\u02B7\u02BB = 1f;

	// Token: 0x04000039 RID: 57
	public float \u02C1\u02B5\u02BD\u02B9\u02BC\u02B2\u02B8\u02C0\u02B5\u02BF\u02C1 = 0.25f;

	// Token: 0x0400003A RID: 58
	public Vector3 \u02B5\u02B2\u02C0\u02BF\u02BE\u02B7\u02BB\u02B2\u02BF\u02C1\u02BC;

	// Token: 0x0400003B RID: 59
	public Vector3 \u02B3\u02BE\u02B8\u02BC\u02BA\u02BB\u02B8\u02B4\u02BA\u02B4\u02C1;

	// Token: 0x0400003C RID: 60
	public AnimationCurve \u02BD\u02BA\u02B6\u02B6\u02B9\u02BE\u02B8\u02B3\u02B7\u02B8\u02BD;

	// Token: 0x0400003D RID: 61
	public AnimationCurve \u02B2\u02BF\u02C1\u02BA\u02BE\u02C0\u02BC\u02BE\u02B2\u02C0\u02B7;

	// Token: 0x0400003E RID: 62
	public List<Transform> \u02BD\u02B9\u02BB\u02BB\u02BF\u02B3\u02BB\u02B7\u02C1\u02B5\u02B3;

	// Token: 0x0400003F RID: 63
	private List<Vector3> \u02B7\u02C0\u02BD\u02B7\u02B2\u02B8\u02C1\u02BA\u02BA\u02B5\u02B2;

	// Token: 0x04000040 RID: 64
	private List<Coroutine> \u02BA\u02B5\u02B5\u02B7\u02B6\u02B5\u02C1\u02B4\u02BE\u02B2\u02C1;
}
