using System;
using System.Collections;
using UnityEngine;

public class FilterDisplayPanel : MonoBehaviour
{
	public void \u02B8\u02B8\u02BA\u02B9\u02BE\u02BC\u02BB\u02B7\u02BE\u02B9\u02B7()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02BA\u02B9\u02C0\u02B5\u02C0\u02B7\u02B9\u02B3\u02BE\u02B6\u02C0(this.headerTransform.sizeDelta.y, this.openSize));
	}

	private IEnumerator \u02C0\u02BE\u02B7\u02B9\u02BE\u02BB\u02BA\u02BA\u02BB\u02BD\u02BE(float \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2, float \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9)
	{
		FilterDisplayPanel.\u02BF\u02B9\u02BD\u02B4\u02C0\u02B5\u02B8\u02B3\u02B8\u02B4\u02B3 u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B = new FilterDisplayPanel.\u02BF\u02B9\u02BD\u02B4\u02C0\u02B5\u02B8\u02B3\u02B8\u02B4\u02B3(1);
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.<>4__this = this;
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.startPos = \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2;
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.endPos = \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9;
		return u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B;
	}

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

	public void \u02C1\u02BB\u02B9\u02B5\u02BC\u02B4\u02B3\u02B2\u02C1\u02C1\u02B3()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02C0\u02BB\u02B9\u02BF\u02B8\u02BB\u02BF\u02B3\u02B6\u02B2\u02C0(this.headerTransform.sizeDelta.y, this.closedSize));
	}

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

	public void \u02B8\u02BE\u02BB\u02BC\u02B3\u02B8\u02BC\u02BA\u02B8\u02B5\u02B8()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02B8\u02B6\u02B3\u02BC\u02B9\u02BD\u02C0\u02BB\u02B2\u02B4\u02B4(this.headerTransform.sizeDelta.y, this.openSize));
	}

	public void \u02BE\u02B8\u02BE\u02BF\u02B3\u02C0\u02B8\u02B3\u02B4\u02BB\u02BB()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02BA\u02B9\u02C0\u02B5\u02C0\u02B7\u02B9\u02B3\u02BE\u02B6\u02C0(this.headerTransform.sizeDelta.y, this.openSize));
	}

	public void \u02C1\u02BB\u02BE\u02BC\u02BB\u02C0\u02B7\u02B7\u02BE\u02B9\u02BC()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02BA\u02B9\u02C0\u02B5\u02C0\u02B7\u02B9\u02B3\u02BE\u02B6\u02C0(this.headerTransform.sizeDelta.y, this.closedSize));
	}

	public void \u02B4\u02B4\u02B4\u02B8\u02B3\u02B6\u02BB\u02BD\u02B6\u02B4\u02BB()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02C0\u02BE\u02B7\u02B9\u02BE\u02BB\u02BA\u02BA\u02BB\u02BD\u02BE(this.headerTransform.sizeDelta.y, this.openSize));
	}

	private IEnumerator \u02BA\u02B8\u02B7\u02C0\u02BF\u02BE\u02BF\u02B4\u02BC\u02B2\u02B9(float \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2, float \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9)
	{
		FilterDisplayPanel.\u02BF\u02B9\u02BD\u02B4\u02C0\u02B5\u02B8\u02B3\u02B8\u02B4\u02B3 u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B = new FilterDisplayPanel.\u02BF\u02B9\u02BD\u02B4\u02C0\u02B5\u02B8\u02B3\u02B8\u02B4\u02B3(1);
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.<>4__this = this;
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.startPos = \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2;
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.endPos = \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9;
		return u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B;
	}

	public void \u02B6\u02B2\u02C1\u02C0\u02C1\u02B7\u02BC\u02C1\u02BC\u02B7\u02B8()
	{
		if (this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF != null)
		{
			base.StopCoroutine(this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF);
		}
		this.\u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF = base.StartCoroutine(this.\u02B8\u02B6\u02B3\u02BC\u02B9\u02BD\u02C0\u02BB\u02B2\u02B4\u02B4(this.headerTransform.sizeDelta.y, this.closedSize));
	}

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

	private IEnumerator \u02BE\u02B8\u02B6\u02C1\u02BA\u02BC\u02BF\u02BA\u02B3\u02B7\u02B5(float \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2, float \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9)
	{
		FilterDisplayPanel.\u02BF\u02B9\u02BD\u02B4\u02C0\u02B5\u02B8\u02B3\u02B8\u02B4\u02B3 u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B = new FilterDisplayPanel.\u02BF\u02B9\u02BD\u02B4\u02C0\u02B5\u02B8\u02B3\u02B8\u02B4\u02B3(1);
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.<>4__this = this;
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.startPos = \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2;
		u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B.endPos = \u02C1\u02C1\u02B7\u02BD\u02B4\u02BD\u02B4\u02C1\u02BF\u02B3\u02B9;
		return u02BF_u02B9_u02BD_u02B4_u02C0_u02B5_u02B8_u02B3_u02B8_u02B4_u02B;
	}

	[SerializeField]
	private float openSize = 110f;

	[SerializeField]
	private float closedSize = 50f;

	[SerializeField]
	private float animationTime = 0.3f;

	[SerializeField]
	private RectTransform headerTransform;

	[SerializeField]
	private AnimationCurve animationCurve;

	private Vector2 \u02B6\u02BF\u02C1\u02B4\u02B5\u02BB\u02B9\u02C0\u02C1\u02C1\u02C0;

	private Coroutine \u02BB\u02C0\u02BD\u02BB\u02BE\u02B8\u02B9\u02B2\u02B5\u02B9\u02BF;
}
