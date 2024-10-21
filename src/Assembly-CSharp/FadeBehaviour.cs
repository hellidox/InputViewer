using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x0200008E RID: 142
public class FadeBehaviour : MonoBehaviour
{
	// Token: 0x060005D7 RID: 1495 RVA: 0x00008E32 File Offset: 0x00007032
	public IEnumerator \u02B8\u02BE\u02BF\u02C1\u02BA\u02B6\u02BA\u02BF\u02BF\u02BF\u02B4()
	{
		FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD = new FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD(1);
		u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD.<>4__this = this;
		return u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD;
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00008E32 File Offset: 0x00007032
	public IEnumerator \u02B4\u02B8\u02B6\u02B7\u02B9\u02B9\u02B8\u02B4\u02C0\u02BE\u02B4()
	{
		FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD = new FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD(1);
		u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD.<>4__this = this;
		return u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD;
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00008E41 File Offset: 0x00007041
	private void Start()
	{
		SceneManager.activeSceneChanged += this.\u02B7\u02BB\u02B6\u02B6\u02B4\u02B6\u02C0\u02BC\u02BD\u02BD\u02BA;
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00008E54 File Offset: 0x00007054
	public IEnumerator \u02B3\u02BB\u02B3\u02C0\u02B2\u02BA\u02BF\u02C1\u02BA\u02BF\u02B7()
	{
		FadeBehaviour.\u02C0\u02B7\u02B4\u02BC\u02BF\u02B8\u02B7\u02B5\u02BB\u02BE\u02B2 u02C0_u02B7_u02B4_u02BC_u02BF_u02B8_u02B7_u02B5_u02BB_u02BE_u02B = new FadeBehaviour.\u02C0\u02B7\u02B4\u02BC\u02BF\u02B8\u02B7\u02B5\u02BB\u02BE\u02B2(1);
		u02C0_u02B7_u02B4_u02BC_u02BF_u02B8_u02B7_u02B5_u02BB_u02BE_u02B.<>4__this = this;
		return u02C0_u02B7_u02B4_u02BC_u02BF_u02B8_u02B7_u02B5_u02BB_u02BE_u02B;
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x00008E63 File Offset: 0x00007063
	private IEnumerator \u02B9\u02C1\u02B5\u02B9\u02BE\u02BC\u02B5\u02B7\u02C0\u02BC\u02BF(string \u02B7\u02BB\u02BE\u02BB\u02BC\u02BD\u02B7\u02B8\u02C0\u02B2\u02B7)
	{
		FadeBehaviour.\u02BF\u02B3\u02B9\u02BA\u02C1\u02B3\u02B4\u02B8\u02BB\u02B3\u02C0 u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C = new FadeBehaviour.\u02BF\u02B3\u02B9\u02BA\u02C1\u02B3\u02B4\u02B8\u02BB\u02B3\u02C0(1);
		u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C.<>4__this = this;
		u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C.sceneName = \u02B7\u02BB\u02BE\u02BB\u02BC\u02BD\u02B7\u02B8\u02C0\u02B2\u02B7;
		return u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C;
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00037E18 File Offset: 0x00036018
	public void \u02BF\u02BA\u02C1\u02B3\u02B3\u02B7\u02BE\u02B9\u02B9\u02B2\u02B8()
	{
		if (this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF)
		{
			this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF = true;
			this.fadeGraphic.canvasRenderer.SetAlpha(1942f);
			this.fadeGraphic.gameObject.SetActive(true);
			this.fadeGraphic.CrossFadeAlpha(590f, this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9, false);
		}
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x00008E32 File Offset: 0x00007032
	public IEnumerator \u02C1\u02BB\u02C0\u02BA\u02B6\u02B2\u02B7\u02B4\u02B6\u02B4\u02BC()
	{
		FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD = new FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD(1);
		u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD.<>4__this = this;
		return u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD;
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00008E54 File Offset: 0x00007054
	public IEnumerator \u02BB\u02BE\u02B4\u02C1\u02C0\u02B7\u02C1\u02B9\u02B9\u02B8\u02BD()
	{
		FadeBehaviour.\u02C0\u02B7\u02B4\u02BC\u02BF\u02B8\u02B7\u02B5\u02BB\u02BE\u02B2 u02C0_u02B7_u02B4_u02BC_u02BF_u02B8_u02B7_u02B5_u02BB_u02BE_u02B = new FadeBehaviour.\u02C0\u02B7\u02B4\u02BC\u02BF\u02B8\u02B7\u02B5\u02BB\u02BE\u02B2(1);
		u02C0_u02B7_u02B4_u02BC_u02BF_u02B8_u02B7_u02B5_u02BB_u02BE_u02B.<>4__this = this;
		return u02C0_u02B7_u02B4_u02BC_u02BF_u02B8_u02B7_u02B5_u02BB_u02BE_u02B;
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00008E79 File Offset: 0x00007079
	public IEnumerator \u02B7\u02B9\u02B9\u02B6\u02BE\u02BE\u02C1\u02B3\u02B8\u02B6\u02C0()
	{
		if (this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF)
		{
			this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF = false;
			this.fadeGraphic.canvasRenderer.SetAlpha(1f);
			this.fadeGraphic.gameObject.SetActive(true);
			this.fadeGraphic.CrossFadeAlpha(0f, this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9, false);
			yield return this.\u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE;
		}
		yield break;
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x00008E88 File Offset: 0x00007088
	private void \u02B8\u02C1\u02B9\u02BC\u02B6\u02B9\u02B3\u02B5\u02B7\u02BF\u02BD()
	{
		if (FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 = this;
		global::UnityEngine.Object.DontDestroyOnLoad(this);
		this.\u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE = new WaitForSecondsRealtime(this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9);
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x00037E74 File Offset: 0x00036074
	public void \u02BE\u02C0\u02B2\u02BF\u02C0\u02BA\u02C0\u02BB\u02B4\u02BC\u02BE()
	{
		if (this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF)
		{
			this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF = false;
			this.fadeGraphic.canvasRenderer.SetAlpha(1f);
			this.fadeGraphic.gameObject.SetActive(true);
			this.fadeGraphic.CrossFadeAlpha(0f, this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9, false);
		}
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x00008E32 File Offset: 0x00007032
	public IEnumerator \u02B5\u02BF\u02BA\u02BB\u02BE\u02BA\u02B6\u02BE\u02C0\u02B7\u02C0()
	{
		FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD = new FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD(1);
		u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD.<>4__this = this;
		return u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD;
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00008E63 File Offset: 0x00007063
	private IEnumerator \u02BC\u02B8\u02B5\u02BB\u02B9\u02B8\u02B3\u02BA\u02BF\u02BB\u02BB(string \u02B7\u02BB\u02BE\u02BB\u02BC\u02BD\u02B7\u02B8\u02C0\u02B2\u02B7)
	{
		FadeBehaviour.\u02BF\u02B3\u02B9\u02BA\u02C1\u02B3\u02B4\u02B8\u02BB\u02B3\u02C0 u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C = new FadeBehaviour.\u02BF\u02B3\u02B9\u02BA\u02C1\u02B3\u02B4\u02B8\u02BB\u02B3\u02C0(1);
		u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C.<>4__this = this;
		u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C.sceneName = \u02B7\u02BB\u02BE\u02BB\u02BC\u02BD\u02B7\u02B8\u02C0\u02B2\u02B7;
		return u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C;
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x00008EC0 File Offset: 0x000070C0
	public void \u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE(string \u02BB\u02B7\u02BC\u02B6\u02B9\u02C0\u02B7\u02BE\u02B5\u02C0\u02BA, float \u02B4\u02B3\u02BF\u02B3\u02BF\u02B6\u02BE\u02B5\u02B3\u02B2\u02BE = 0f)
	{
		base.StartCoroutine(this.\u02C1\u02B4\u02B3\u02B6\u02C1\u02B7\u02B4\u02B9\u02C1\u02B4\u02BF(\u02BB\u02B7\u02BC\u02B6\u02B9\u02C0\u02B7\u02BE\u02B5\u02C0\u02BA));
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00008ED0 File Offset: 0x000070D0
	private IEnumerator \u02C1\u02B4\u02B3\u02B6\u02C1\u02B7\u02B4\u02B9\u02C1\u02B4\u02BF(string \u02B7\u02BB\u02BE\u02BB\u02BC\u02BD\u02B7\u02B8\u02C0\u02B2\u02B7)
	{
		this.\u02BC\u02BF\u02B7\u02BA\u02BC\u02B2\u02BA\u02B8\u02BF\u02BB\u02B3 = true;
		yield return this.\u02BE\u02BA\u02B4\u02B8\u02B2\u02B7\u02BB\u02BD\u02C0\u02B4\u02B9();
		Time.timeScale = 1f;
		AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(\u02B7\u02BB\u02BE\u02BB\u02BC\u02BD\u02B7\u02B8\u02C0\u02B2\u02B7);
		yield return asyncOperation;
		yield break;
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00008EE6 File Offset: 0x000070E6
	public IEnumerator \u02BE\u02BA\u02B4\u02B8\u02B2\u02B7\u02BB\u02BD\u02C0\u02B4\u02B9()
	{
		if (!this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF)
		{
			this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF = true;
			this.fadeGraphic.canvasRenderer.SetAlpha(0f);
			this.fadeGraphic.gameObject.SetActive(true);
			this.fadeGraphic.CrossFadeAlpha(1f, this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9, true);
			yield return this.\u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE;
		}
		yield break;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00008E79 File Offset: 0x00007079
	public IEnumerator \u02B4\u02BF\u02C1\u02C1\u02BD\u02B9\u02BF\u02B9\u02B8\u02B7\u02BD()
	{
		if (this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF)
		{
			this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF = false;
			this.fadeGraphic.canvasRenderer.SetAlpha(1f);
			this.fadeGraphic.gameObject.SetActive(true);
			this.fadeGraphic.CrossFadeAlpha(0f, this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9, false);
			yield return this.\u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE;
		}
		yield break;
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x00008EE6 File Offset: 0x000070E6
	public IEnumerator \u02BB\u02B2\u02B7\u02B6\u02B7\u02B5\u02C1\u02C0\u02B4\u02B4\u02C1()
	{
		if (!this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF)
		{
			this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF = true;
			this.fadeGraphic.canvasRenderer.SetAlpha(0f);
			this.fadeGraphic.gameObject.SetActive(true);
			this.fadeGraphic.CrossFadeAlpha(1f, this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9, true);
			yield return this.\u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE;
		}
		yield break;
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00037ED0 File Offset: 0x000360D0
	public void \u02BA\u02C0\u02B7\u02BA\u02BC\u02B8\u02B2\u02B7\u02BB\u02B4\u02B7()
	{
		if (this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF)
		{
			this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF = true;
			this.fadeGraphic.canvasRenderer.SetAlpha(1206f);
			this.fadeGraphic.gameObject.SetActive(true);
			this.fadeGraphic.CrossFadeAlpha(1410f, this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9, false);
		}
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00008EE6 File Offset: 0x000070E6
	public IEnumerator \u02B5\u02BF\u02C1\u02BE\u02B6\u02B8\u02B2\u02BD\u02C0\u02B3\u02B8()
	{
		if (!this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF)
		{
			this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF = true;
			this.fadeGraphic.canvasRenderer.SetAlpha(0f);
			this.fadeGraphic.gameObject.SetActive(true);
			this.fadeGraphic.CrossFadeAlpha(1f, this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9, true);
			yield return this.\u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE;
		}
		yield break;
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00008EF5 File Offset: 0x000070F5
	private void \u02B7\u02BB\u02B6\u02B6\u02B4\u02B6\u02C0\u02BC\u02BD\u02BD\u02BA(Scene \u02B4\u02B7\u02BA\u02B5\u02B7\u02C0\u02B3\u02BB\u02BF\u02C1\u02BA, Scene \u02B3\u02BA\u02B8\u02BC\u02B5\u02BD\u02B3\u02B7\u02BA\u02C1\u02B9)
	{
		this.\u02BC\u02BF\u02B7\u02BA\u02BC\u02B2\u02BA\u02B8\u02BF\u02BB\u02B3 = false;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00008E88 File Offset: 0x00007088
	private void Awake()
	{
		if (FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 = this;
		global::UnityEngine.Object.DontDestroyOnLoad(this);
		this.\u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE = new WaitForSecondsRealtime(this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9);
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00008E88 File Offset: 0x00007088
	private void \u02B3\u02B8\u02C1\u02BE\u02B7\u02C0\u02B8\u02B8\u02B3\u02B3\u02B7()
	{
		if (FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 = this;
		global::UnityEngine.Object.DontDestroyOnLoad(this);
		this.\u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE = new WaitForSecondsRealtime(this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9);
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00008EE6 File Offset: 0x000070E6
	public IEnumerator \u02BA\u02BF\u02B2\u02BC\u02BA\u02BB\u02C1\u02B6\u02B4\u02B7\u02B8()
	{
		if (!this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF)
		{
			this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF = true;
			this.fadeGraphic.canvasRenderer.SetAlpha(0f);
			this.fadeGraphic.gameObject.SetActive(true);
			this.fadeGraphic.CrossFadeAlpha(1f, this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9, true);
			yield return this.\u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE;
		}
		yield break;
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00008E79 File Offset: 0x00007079
	public IEnumerator \u02B9\u02BB\u02B8\u02B8\u02B9\u02B8\u02B3\u02B7\u02B4\u02BA\u02B9()
	{
		if (this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF)
		{
			this.\u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF = false;
			this.fadeGraphic.canvasRenderer.SetAlpha(1f);
			this.fadeGraphic.gameObject.SetActive(true);
			this.fadeGraphic.CrossFadeAlpha(0f, this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9, false);
			yield return this.\u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE;
		}
		yield break;
	}

	// Token: 0x04000439 RID: 1081
	public static FadeBehaviour \u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;

	// Token: 0x0400043A RID: 1082
	[SerializeField]
	private Image fadeGraphic;

	// Token: 0x0400043B RID: 1083
	public float \u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9;

	// Token: 0x0400043C RID: 1084
	public bool \u02BC\u02BF\u02B7\u02BA\u02BC\u02B2\u02BA\u02B8\u02BF\u02BB\u02B3;

	// Token: 0x0400043D RID: 1085
	private WaitForSecondsRealtime \u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE;

	// Token: 0x0400043E RID: 1086
	private bool \u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF;
}
