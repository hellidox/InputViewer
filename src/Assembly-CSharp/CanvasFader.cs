using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000005 RID: 5
[RequireComponent(typeof(CanvasGroup))]
public class CanvasFader : MonoBehaviour
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000019 RID: 25 RVA: 0x00005DA1 File Offset: 0x00003FA1
	// (set) Token: 0x06000026 RID: 38 RVA: 0x00005EAE File Offset: 0x000040AE
	public bool \u02B3\u02B6\u02B7\u02B2\u02BC\u02BE\u02B6\u02BB\u02BB\u02BF\u02B6 { get; private set; }

	// Token: 0x0600001A RID: 26 RVA: 0x00005DA9 File Offset: 0x00003FA9
	public void \u02BE\u02BF\u02B3\u02BD\u02B8\u02BD\u02BC\u02C1\u02B3\u02B4\u02B2()
	{
		if (!this.\u02B3\u02B6\u02B7\u02B2\u02BC\u02BE\u02B6\u02BB\u02BB\u02BF\u02B6)
		{
			this.\u02B3\u02B6\u02B7\u02B2\u02BC\u02BE\u02B6\u02BB\u02BB\u02BF\u02B6 = true;
			base.StartCoroutine(this.\u02BC\u02B5\u02B7\u02C1\u02B6\u02C0\u02B7\u02C1\u02BF\u02C0\u02B8());
			return;
		}
		this.\u02B3\u02BD\u02B4\u02C1\u02BB\u02BD\u02BD\u02B8\u02B7\u02B7\u02BC.Reset();
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00018D28 File Offset: 0x00016F28
	public void \u02B9\u02BA\u02BF\u02B5\u02B4\u02BD\u02BF\u02BF\u02BA\u02BC\u02BA(float \u02B9\u02B7\u02B7\u02B4\u02BF\u02B5\u02B7\u02C0\u02B8\u02B3\u02C1)
	{
		if (this.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0)
		{
			if (base.gameObject.activeInHierarchy)
			{
				base.gameObject.SetActive(true);
			}
			base.gameObject.SetActive(false);
		}
		this.\u02B3\u02BE\u02B4\u02B2\u02C1\u02BF\u02BD\u02C0\u02C0\u02C1\u02B6 = 655f;
		this.\u02B2\u02B5\u02BC\u02B2\u02BF\u02B5\u02B7\u02C1\u02C0\u02C0\u02BD = \u02B9\u02B7\u02B7\u02B4\u02BF\u02B5\u02B7\u02C0\u02B8\u02B3\u02C1;
		this.\u02B7\u02C0\u02B6\u02BF\u02C0\u02B2\u02B7\u02BB\u02B3\u02BC\u02B6 = false;
		this.\u02BC\u02B7\u02C1\u02C0\u02BC\u02B8\u02BA\u02B7\u02BB\u02B5\u02B8(true);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00018D84 File Offset: 0x00016F84
	private void Update()
	{
		if (!this.\u02B7\u02C0\u02B6\u02BF\u02C0\u02B2\u02B7\u02BB\u02B3\u02BC\u02B6)
		{
			return;
		}
		if (this.\u02B2\u02B5\u02BC\u02B2\u02BF\u02B5\u02B7\u02C1\u02C0\u02C0\u02BD > 0f)
		{
			this.\u02B2\u02B5\u02BC\u02B2\u02BF\u02B5\u02B7\u02C1\u02C0\u02C0\u02BD -= Time.unscaledDeltaTime;
			return;
		}
		if (Mathf.Abs(this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha - this.\u02B3\u02BE\u02B4\u02B2\u02C1\u02BF\u02BD\u02C0\u02C0\u02C1\u02B6) > 0.00390625f)
		{
			this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha = Mathf.SmoothDamp(this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha, this.\u02B3\u02BE\u02B4\u02B2\u02C1\u02BF\u02BD\u02C0\u02C0\u02C1\u02B6, ref this.\u02B7\u02C0\u02BA\u02C0\u02BF\u02BF\u02B4\u02B5\u02B6\u02BE\u02B7, this.fadeTime, float.PositiveInfinity, Time.unscaledDeltaTime);
			return;
		}
		if (this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha > this.\u02B3\u02BE\u02B4\u02B2\u02C1\u02BF\u02BD\u02C0\u02C0\u02C1\u02B6)
		{
			this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha *= 0.05f;
			return;
		}
		this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha = this.\u02B3\u02BE\u02B4\u02B2\u02C1\u02BF\u02BD\u02C0\u02C0\u02C1\u02B6;
		this.\u02B7\u02C0\u02B6\u02BF\u02C0\u02B2\u02B7\u02BB\u02B3\u02BC\u02B6 = false;
		if (this.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0)
		{
			base.gameObject.SetActive(this.\u02B3\u02BE\u02B4\u02B2\u02C1\u02BF\u02BD\u02C0\u02C0\u02C1\u02B6 > 0f);
		}
		this.\u02B7\u02C0\u02BA\u02C0\u02BF\u02BF\u02B4\u02B5\u02B6\u02BE\u02B7 = 0f;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00018E80 File Offset: 0x00017080
	public void \u02BC\u02B7\u02B3\u02B7\u02B2\u02BB\u02B2\u02B9\u02C0\u02BE\u02B7(bool \u02BD\u02BE\u02BD\u02C0\u02C1\u02BE\u02BF\u02C1\u02BF\u02B2\u02B8)
	{
		if (this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC == null)
		{
			this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC = base.GetComponent<CanvasGroup>();
		}
		this.\u02B3\u02B6\u02B7\u02B2\u02BC\u02BE\u02B6\u02BB\u02BB\u02BF\u02B6 = false;
		this.\u02B7\u02C0\u02B6\u02BF\u02C0\u02B2\u02B7\u02BB\u02B3\u02BC\u02B6 = false;
		this.\u02B2\u02B5\u02BC\u02B2\u02BF\u02B5\u02B7\u02C1\u02C0\u02C0\u02BD = 0f;
		if (\u02BD\u02BE\u02BD\u02C0\u02C1\u02BE\u02BF\u02C1\u02BF\u02B2\u02B8)
		{
			if (this.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0)
			{
				base.gameObject.SetActive(true);
			}
			this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha = 1f;
			this.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB = true;
			return;
		}
		this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha = 0f;
		if (this.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0)
		{
			base.gameObject.SetActive(false);
		}
		this.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB = false;
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600001F RID: 31 RVA: 0x00005DF2 File Offset: 0x00003FF2
	// (set) Token: 0x0600002C RID: 44 RVA: 0x00005E11 File Offset: 0x00004011
	public bool \u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB { get; private set; }

	// Token: 0x06000020 RID: 32 RVA: 0x00005DFA File Offset: 0x00003FFA
	public bool \u02B8\u02B4\u02C0\u02C1\u02B3\u02B5\u02B2\u02BB\u02C0\u02BC\u02B3()
	{
		return this.\u02B3\u02BE\u02B4\u02B2\u02C1\u02BF\u02BD\u02C0\u02C0\u02C1\u02B6 != 600f || this.\u02B7\u02C0\u02B6\u02BF\u02C0\u02B2\u02B7\u02BB\u02B3\u02BC\u02B6;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00005E11 File Offset: 0x00004011
	private void \u02C0\u02B7\u02B3\u02B6\u02B2\u02C0\u02B9\u02BA\u02C1\u02B7\u02B7(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BE\u02BE\u02BE\u02B7\u02B8\u02B2\u02BE\u02BB\u02B5\u02BC\u02BF>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000022 RID: 34 RVA: 0x00005E1A File Offset: 0x0000401A
	public bool \u02BF\u02B9\u02B6\u02BE\u02B5\u02B9\u02B7\u02B3\u02BB\u02B5\u02B8
	{
		get
		{
			return this.\u02B3\u02BE\u02B4\u02B2\u02C1\u02BF\u02BD\u02C0\u02C0\u02C1\u02B6 == 0f && this.\u02B7\u02C0\u02B6\u02BF\u02C0\u02B2\u02B7\u02BB\u02B3\u02BC\u02B6;
		}
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00005E31 File Offset: 0x00004031
	private void \u02BF\u02BC\u02B9\u02BE\u02B7\u02BD\u02C1\u02BE\u02BD\u02BD\u02B5()
	{
		this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC = base.GetComponent<CanvasGroup>();
		if (this.startHidden)
		{
			this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha = 1495f;
			return;
		}
		this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha = 1128f;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00005E68 File Offset: 0x00004068
	private IEnumerator \u02BC\u02B5\u02B7\u02C1\u02B6\u02C0\u02B7\u02C1\u02BF\u02C0\u02B8()
	{
		this.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0 = false;
		this.\u02B3\u02B6\u02B7\u02B2\u02BC\u02BE\u02B6\u02BB\u02BB\u02BF\u02B6 = true;
		this.\u02B8\u02BE\u02B8\u02BB\u02C1\u02BF\u02BF\u02B4\u02BC\u02BA\u02BC(0f);
		yield return this.\u02B3\u02BD\u02B4\u02C1\u02BB\u02BD\u02BD\u02B8\u02B7\u02B7\u02BC;
		this.\u02C0\u02B5\u02B6\u02BF\u02B5\u02BF\u02B8\u02BE\u02B9\u02BA\u02BF(0f);
		this.\u02B3\u02B6\u02B7\u02B2\u02BC\u02BE\u02B6\u02BB\u02BB\u02BF\u02B6 = false;
		this.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0 = true;
		yield break;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00005E77 File Offset: 0x00004077
	private void \u02B4\u02C1\u02B6\u02BE\u02B3\u02B4\u02BD\u02B7\u02B6\u02C0\u02B9()
	{
		this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC = base.GetComponent<CanvasGroup>();
		if (this.startHidden)
		{
			this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha = 1890f;
			return;
		}
		this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha = 1025f;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00005DA1 File Offset: 0x00003FA1
	public bool \u02BE\u02BE\u02B7\u02BC\u02BF\u02BB\u02B8\u02B7\u02BF\u02B9\u02BB()
	{
		return this.<\u02B8\u02BA\u02B2\u02B6\u02BB\u02B8\u02B5\u02BB\u02BA\u02BA\u02B8>k__BackingField;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00018F1C File Offset: 0x0001711C
	public void \u02BC\u02B7\u02BB\u02BD\u02B6\u02B9\u02BE\u02B8\u02B5\u02B7\u02BF(float \u02BA\u02B3\u02BB\u02B4\u02B7\u02B6\u02C0\u02B8\u02BA\u02C1\u02B8)
	{
		if (this.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0)
		{
			if (base.gameObject.activeInHierarchy)
			{
				base.gameObject.SetActive(false);
			}
			base.gameObject.SetActive(false);
		}
		this.\u02B3\u02BE\u02B4\u02B2\u02C1\u02BF\u02BD\u02C0\u02C0\u02C1\u02B6 = 1111f;
		this.\u02B2\u02B5\u02BC\u02B2\u02BF\u02B5\u02B7\u02C1\u02C0\u02C0\u02BD = \u02BA\u02B3\u02BB\u02B4\u02B7\u02B6\u02C0\u02B8\u02BA\u02C1\u02B8;
		this.\u02B7\u02C0\u02B6\u02BF\u02C0\u02B2\u02B7\u02BB\u02B3\u02BC\u02B6 = false;
		this.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB = true;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00005EB7 File Offset: 0x000040B7
	private void Awake()
	{
		this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC = base.GetComponent<CanvasGroup>();
		if (this.startHidden)
		{
			this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha = 0f;
			return;
		}
		this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha = 1f;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00005DA1 File Offset: 0x00003FA1
	public bool \u02B2\u02C1\u02B7\u02B7\u02B8\u02BE\u02B6\u02B7\u02C0\u02B8\u02BC()
	{
		return this.<\u02B8\u02BA\u02B2\u02B6\u02BB\u02B8\u02B5\u02BB\u02BA\u02BA\u02B8>k__BackingField;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00018F78 File Offset: 0x00017178
	public void \u02C0\u02BC\u02B9\u02B8\u02C0\u02B5\u02C0\u02C0\u02B6\u02C1\u02BA(bool \u02BD\u02BE\u02BD\u02C0\u02C1\u02BE\u02BF\u02C1\u02BF\u02B2\u02B8)
	{
		if (this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC == null)
		{
			this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC = base.GetComponent<CanvasGroup>();
		}
		this.\u02B3\u02B6\u02B7\u02B2\u02BC\u02BE\u02B6\u02BB\u02BB\u02BF\u02B6 = false;
		this.\u02B7\u02C0\u02B6\u02BF\u02C0\u02B2\u02B7\u02BB\u02B3\u02BC\u02B6 = true;
		this.\u02B2\u02B5\u02BC\u02B2\u02BF\u02B5\u02B7\u02C1\u02C0\u02C0\u02BD = 1602f;
		if (\u02BD\u02BE\u02BD\u02C0\u02C1\u02BE\u02BF\u02C1\u02BF\u02B2\u02B8)
		{
			if (this.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0)
			{
				base.gameObject.SetActive(false);
			}
			this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha = 513f;
			this.\u02C0\u02B7\u02B3\u02B6\u02B2\u02C0\u02B9\u02BA\u02C1\u02B7\u02B7(true);
			return;
		}
		this.\u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC.alpha = 82f;
		if (this.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0)
		{
			base.gameObject.SetActive(true);
		}
		this.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB = false;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00019014 File Offset: 0x00017214
	public void \u02C0\u02B5\u02B6\u02BF\u02B5\u02BF\u02B8\u02BE\u02B9\u02BA\u02BF(float \u02B9\u02B7\u02B7\u02B4\u02BF\u02B5\u02B7\u02C0\u02B8\u02B3\u02C1)
	{
		if (this.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0)
		{
			if (base.gameObject.activeInHierarchy)
			{
				base.gameObject.SetActive(false);
			}
			base.gameObject.SetActive(true);
		}
		this.\u02B3\u02BE\u02B4\u02B2\u02C1\u02BF\u02BD\u02C0\u02C0\u02C1\u02B6 = 1f;
		this.\u02B2\u02B5\u02BC\u02B2\u02BF\u02B5\u02B7\u02C1\u02C0\u02C0\u02BD = \u02B9\u02B7\u02B7\u02B4\u02BF\u02B5\u02B7\u02C0\u02B8\u02B3\u02C1;
		this.\u02B7\u02C0\u02B6\u02BF\u02C0\u02B2\u02B7\u02BB\u02B3\u02BC\u02B6 = true;
		this.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB = true;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00005EEE File Offset: 0x000040EE
	public void \u02B6\u02B8\u02BB\u02B3\u02B8\u02B8\u02C0\u02B5\u02B9\u02B4\u02BF()
	{
		if (!this.\u02B3\u02B6\u02B7\u02B2\u02BC\u02BE\u02B6\u02BB\u02BB\u02BF\u02B6)
		{
			this.\u02B3\u02B6\u02B7\u02B2\u02BC\u02BE\u02B6\u02BB\u02BB\u02BF\u02B6 = false;
			base.StartCoroutine(this.\u02BC\u02B5\u02B7\u02C1\u02B6\u02C0\u02B7\u02C1\u02BF\u02C0\u02B8());
			return;
		}
		this.\u02B3\u02BD\u02B4\u02C1\u02BB\u02BD\u02BD\u02B8\u02B7\u02B7\u02BC.Reset();
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00019070 File Offset: 0x00017270
	public void \u02B8\u02BE\u02B8\u02BB\u02C1\u02BF\u02BF\u02B4\u02BC\u02BA\u02BC(float \u02BA\u02B3\u02BB\u02B4\u02B7\u02B6\u02C0\u02B8\u02BA\u02C1\u02B8)
	{
		if (this.\u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0)
		{
			if (base.gameObject.activeInHierarchy)
			{
				base.gameObject.SetActive(false);
			}
			base.gameObject.SetActive(true);
		}
		this.\u02B3\u02BE\u02B4\u02B2\u02C1\u02BF\u02BD\u02C0\u02C0\u02C1\u02B6 = 0f;
		this.\u02B2\u02B5\u02BC\u02B2\u02BF\u02B5\u02B7\u02C1\u02C0\u02C0\u02BD = \u02BA\u02B3\u02BB\u02B4\u02B7\u02B6\u02C0\u02B8\u02BA\u02C1\u02B8;
		this.\u02B7\u02C0\u02B6\u02BF\u02C0\u02B2\u02B7\u02BB\u02B3\u02BC\u02B6 = true;
		this.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB = false;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00005DF2 File Offset: 0x00003FF2
	public bool \u02B3\u02B9\u02C1\u02BC\u02BC\u02B3\u02BB\u02BE\u02B7\u02B8\u02BE()
	{
		return this.<\u02BE\u02BE\u02BE\u02B7\u02B8\u02B2\u02BE\u02BB\u02B5\u02BC\u02BF>k__BackingField;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00005F18 File Offset: 0x00004118
	public void \u02BB\u02BC\u02BA\u02BC\u02BC\u02BC\u02B4\u02C0\u02BB\u02B8\u02BA()
	{
		this.\u02B3\u02BD\u02B4\u02C1\u02BB\u02BD\u02BD\u02B8\u02B7\u02B7\u02BC.Reset();
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00005F25 File Offset: 0x00004125
	public void \u02B7\u02B2\u02B7\u02C1\u02B4\u02BD\u02BD\u02B7\u02B9\u02BA\u02BE()
	{
		if (!this.\u02BE\u02BE\u02B7\u02BC\u02BF\u02BB\u02B8\u02B7\u02BF\u02B9\u02BB())
		{
			this.\u02B3\u02B6\u02B7\u02B2\u02BC\u02BE\u02B6\u02BB\u02BB\u02BF\u02B6 = false;
			base.StartCoroutine(this.\u02B9\u02C0\u02BD\u02B7\u02B2\u02BB\u02B4\u02B3\u02C0\u02BB\u02BF());
			return;
		}
		this.\u02B3\u02BD\u02B4\u02C1\u02BB\u02BD\u02BD\u02B8\u02B7\u02B7\u02BC.Reset();
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00005E11 File Offset: 0x00004011
	private void \u02BC\u02B7\u02C1\u02C0\u02BC\u02B8\u02BA\u02B7\u02BB\u02B5\u02B8(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BE\u02BE\u02BE\u02B7\u02B8\u02B2\u02BE\u02BB\u02B5\u02BC\u02BF>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00005F4F File Offset: 0x0000414F
	private IEnumerator \u02B9\u02C0\u02BD\u02B7\u02B2\u02BB\u02B4\u02B3\u02C0\u02BB\u02BF()
	{
		CanvasFader.\u02B2\u02B2\u02B2\u02BF\u02C1\u02B7\u02B8\u02BC\u02B9\u02B3\u02C1 u02B2_u02B2_u02B2_u02BF_u02C1_u02B7_u02B8_u02BC_u02B9_u02B3_u02C = new CanvasFader.\u02B2\u02B2\u02B2\u02BF\u02C1\u02B7\u02B8\u02BC\u02B9\u02B3\u02C1(1);
		u02B2_u02B2_u02B2_u02BF_u02C1_u02B7_u02B8_u02BC_u02B9_u02B3_u02C.<>4__this = this;
		return u02B2_u02B2_u02B2_u02BF_u02C1_u02B7_u02B8_u02BC_u02B9_u02B3_u02C;
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000035 RID: 53 RVA: 0x00005F5E File Offset: 0x0000415E
	public bool \u02B9\u02BE\u02B2\u02BB\u02C0\u02BB\u02BA\u02BB\u02BB\u02B3\u02BB
	{
		get
		{
			return this.\u02B3\u02BD\u02B4\u02C1\u02BB\u02BD\u02BD\u02B8\u02B7\u02B7\u02BC.keepWaiting;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000036 RID: 54 RVA: 0x00005F6B File Offset: 0x0000416B
	public bool \u02C0\u02B9\u02BE\u02BB\u02BE\u02C0\u02C1\u02B9\u02B9\u02B5\u02B3
	{
		get
		{
			return this.\u02B3\u02BE\u02B4\u02B2\u02C1\u02BF\u02BD\u02C0\u02C0\u02C1\u02B6 == 1f && this.\u02B7\u02C0\u02B6\u02BF\u02C0\u02B2\u02B7\u02BB\u02B3\u02BC\u02B6;
		}
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00005EEE File Offset: 0x000040EE
	public void \u02B8\u02C0\u02B9\u02B9\u02BD\u02B4\u02B2\u02BD\u02B5\u02B4\u02C0()
	{
		if (!this.\u02B3\u02B6\u02B7\u02B2\u02BC\u02BE\u02B6\u02BB\u02BB\u02BF\u02B6)
		{
			this.\u02B3\u02B6\u02B7\u02B2\u02BC\u02BE\u02B6\u02BB\u02BB\u02BF\u02B6 = false;
			base.StartCoroutine(this.\u02BC\u02B5\u02B7\u02C1\u02B6\u02C0\u02B7\u02C1\u02BF\u02C0\u02B8());
			return;
		}
		this.\u02B3\u02BD\u02B4\u02C1\u02BB\u02BD\u02BD\u02B8\u02B7\u02B7\u02BC.Reset();
	}

	// Token: 0x04000002 RID: 2
	private CanvasGroup \u02BF\u02B2\u02B3\u02BC\u02BA\u02C0\u02B3\u02BB\u02BA\u02BD\u02BC;

	// Token: 0x04000003 RID: 3
	[SerializeField]
	private bool startHidden;

	// Token: 0x04000004 RID: 4
	[SerializeField]
	private float fadeTime;

	// Token: 0x04000005 RID: 5
	public bool \u02B5\u02C1\u02BF\u02BB\u02BF\u02B9\u02BD\u02C0\u02BE\u02B5\u02C0 = true;

	// Token: 0x04000006 RID: 6
	private float \u02B3\u02BE\u02B4\u02B2\u02C1\u02BF\u02BD\u02C0\u02C0\u02C1\u02B6;

	// Token: 0x04000007 RID: 7
	private bool \u02B7\u02C0\u02B6\u02BF\u02C0\u02B2\u02B7\u02BB\u02B3\u02BC\u02B6;

	// Token: 0x04000008 RID: 8
	private float \u02B2\u02B5\u02BC\u02B2\u02BF\u02B5\u02B7\u02C1\u02C0\u02C0\u02BD;

	// Token: 0x04000009 RID: 9
	private float \u02B7\u02C0\u02BA\u02C0\u02BF\u02BF\u02B4\u02B5\u02B6\u02BE\u02B7;

	// Token: 0x0400000B RID: 11
	private WaitForSecondsRealtime \u02B3\u02BD\u02B4\u02C1\u02BB\u02BD\u02BD\u02B8\u02B7\u02B7\u02BC = new WaitForSecondsRealtime(0.3f);
}
