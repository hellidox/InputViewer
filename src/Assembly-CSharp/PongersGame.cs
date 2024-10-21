using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200017E RID: 382
public class PongersGame : MonoBehaviour
{
	// Token: 0x060011A9 RID: 4521 RVA: 0x0000F500 File Offset: 0x0000D700
	private IEnumerator \u02B8\u02B7\u02B6\u02B4\u02BA\u02BD\u02B7\u02BA\u02B2\u02BC\u02BA()
	{
		float a = 0f;
		this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.SetActive(true);
		yield return new WaitForSeconds(3f);
		while (a < 2f)
		{
			this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.transform.Rotate(Vector3.forward, a * 1.5f * 360f);
			this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.transform.localScale = new Vector2(1f - a / 2f, 1f - a / 2f);
			a += Time.deltaTime;
			yield return null;
		}
		this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.SetActive(false);
		this.\u02BE\u02B4\u02B7\u02B4\u02B7\u02B7\u02B5\u02B6\u02BA\u02B2\u02BE();
		yield break;
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00093B14 File Offset: 0x00091D14
	private void \u02B4\u02BD\u02B8\u02BE\u02C0\u02C1\u02C0\u02C1\u02BD\u02C0\u02BF()
	{
		for (int i = 1; i < this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Count; i++)
		{
			global::UnityEngine.Object.Destroy(this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF[i]);
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Clear();
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x00093B54 File Offset: 0x00091D54
	private void \u02C1\u02B5\u02B7\u02BD\u02B3\u02B4\u02BE\u02B8\u02BE\u02BB\u02BB()
	{
		if (this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE >= this.\u02B8\u02BA\u02B7\u02B6\u02C0\u02B2\u02B9\u02BF\u02B8\u02B3\u02BD)
		{
			return;
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Add(global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B7\u02B5\u02BE\u02B5\u02B5\u02B6\u02BA\u02BD\u02B4\u02B4\u02C0));
		List<GameObject> u02B6_u02B3_u02B5_u02BE_u02B7_u02C0_u02BC_u02BE_u02C1_u02BE_u02BF = this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF;
		int u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE = this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE;
		this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE = u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE + 0;
		u02B6_u02B3_u02B5_u02BE_u02B7_u02C0_u02BC_u02BE_u02C1_u02BE_u02BF[u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE].GetComponent<Ball>().\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2 = this;
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x00093BB0 File Offset: 0x00091DB0
	private void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		base.StartCoroutine(this.\u02B4\u02BB\u02B3\u02C0\u02B9\u02B5\u02BB\u02C0\u02B5\u02B4\u02BB());
		global::UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x00093BE0 File Offset: 0x00091DE0
	private void \u02BF\u02C1\u02BE\u02C0\u02B3\u02BB\u02B8\u02B7\u02BE\u02BB\u02B8()
	{
		for (int i = 0; i < this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Count; i++)
		{
			global::UnityEngine.Object.Destroy(this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF[i]);
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Clear();
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x00093BE0 File Offset: 0x00091DE0
	private void \u02BF\u02B4\u02B8\u02B9\u02BC\u02C1\u02BA\u02BC\u02BC\u02BD\u02BC()
	{
		for (int i = 0; i < this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Count; i++)
		{
			global::UnityEngine.Object.Destroy(this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF[i]);
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Clear();
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x0000F50F File Offset: 0x0000D70F
	private IEnumerator \u02C0\u02BE\u02B2\u02B5\u02BB\u02B3\u02BF\u02B9\u02BE\u02B4\u02BF()
	{
		this.\u02BF\u02B4\u02B8\u02B9\u02BC\u02C1\u02BA\u02BC\u02BC\u02BD\u02BC();
		this.\u02BE\u02B9\u02BE\u02B7\u02C0\u02BC\u02BC\u02B4\u02C0\u02B5\u02B4.SetActive(true);
		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene("Main Menu");
		yield break;
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00093B14 File Offset: 0x00091D14
	private void \u02B8\u02BE\u02BF\u02B7\u02B8\u02C1\u02C1\u02B9\u02B2\u02B5\u02B7()
	{
		for (int i = 1; i < this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Count; i++)
		{
			global::UnityEngine.Object.Destroy(this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF[i]);
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Clear();
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x0000F500 File Offset: 0x0000D700
	private IEnumerator \u02B4\u02BB\u02B3\u02C0\u02B9\u02B5\u02BB\u02C0\u02B5\u02B4\u02BB()
	{
		a = 0f;
		this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.SetActive(true);
		yield return new WaitForSeconds(3f);
		while (a < 2f)
		{
			this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.transform.Rotate(Vector3.forward, a * 1.5f * 360f);
			this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.transform.localScale = new Vector2(1f - a / 2f, 1f - a / 2f);
			a += Time.deltaTime;
			yield return null;
		}
		this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.SetActive(false);
		this.\u02BE\u02B4\u02B7\u02B4\u02B7\u02B7\u02B5\u02B6\u02BA\u02B2\u02BE();
		yield break;
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x0000F50F File Offset: 0x0000D70F
	private IEnumerator \u02C1\u02B5\u02B6\u02BE\u02B3\u02B6\u02B2\u02BF\u02B2\u02B7\u02BE()
	{
		this.\u02BF\u02B4\u02B8\u02B9\u02BC\u02C1\u02BA\u02BC\u02BC\u02BD\u02BC();
		this.\u02BE\u02B9\u02BE\u02B7\u02C0\u02BC\u02BC\u02B4\u02C0\u02B5\u02B4.SetActive(true);
		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene("Main Menu");
		yield break;
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x0000F500 File Offset: 0x0000D700
	private IEnumerator \u02B3\u02B8\u02B9\u02B3\u02B8\u02B3\u02BF\u02C0\u02C1\u02B8\u02BB()
	{
		a = 0f;
		this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.SetActive(true);
		yield return new WaitForSeconds(3f);
		while (a < 2f)
		{
			this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.transform.Rotate(Vector3.forward, a * 1.5f * 360f);
			this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.transform.localScale = new Vector2(1f - a / 2f, 1f - a / 2f);
			a += Time.deltaTime;
			yield return null;
		}
		this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.SetActive(false);
		this.\u02BE\u02B4\u02B7\u02B4\u02B7\u02B7\u02B5\u02B6\u02BA\u02B2\u02BE();
		yield break;
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x00093C20 File Offset: 0x00091E20
	private void \u02BB\u02B9\u02C0\u02B4\u02BA\u02BC\u02B7\u02BB\u02B2\u02B6\u02C1()
	{
		for (int i = 0; i < this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Count; i += 0)
		{
			global::UnityEngine.Object.Destroy(this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF[i]);
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Clear();
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x00093C60 File Offset: 0x00091E60
	private void \u02B7\u02B2\u02BC\u02BA\u02B7\u02B6\u02B3\u02BC\u02B9\u02B4\u02BB()
	{
		if (this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE >= this.\u02B8\u02BA\u02B7\u02B6\u02C0\u02B2\u02B9\u02BF\u02B8\u02B3\u02BD)
		{
			return;
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Add(global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B7\u02B5\u02BE\u02B5\u02B5\u02B6\u02BA\u02BD\u02B4\u02B4\u02C0));
		List<GameObject> u02B6_u02B3_u02B5_u02BE_u02B7_u02C0_u02BC_u02BE_u02C1_u02BE_u02BF = this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF;
		int u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE = this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE;
		this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE = u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE + 1;
		u02B6_u02B3_u02B5_u02BE_u02B7_u02C0_u02BC_u02BE_u02C1_u02BE_u02BF[u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE].GetComponent<Ball>().\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2 = this;
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x00093B54 File Offset: 0x00091D54
	private void \u02B5\u02B7\u02C1\u02B9\u02BF\u02BC\u02B5\u02B7\u02B4\u02BD\u02B6()
	{
		if (this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE >= this.\u02B8\u02BA\u02B7\u02B6\u02C0\u02B2\u02B9\u02BF\u02B8\u02B3\u02BD)
		{
			return;
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Add(global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B7\u02B5\u02BE\u02B5\u02B5\u02B6\u02BA\u02BD\u02B4\u02B4\u02C0));
		List<GameObject> u02B6_u02B3_u02B5_u02BE_u02B7_u02C0_u02BC_u02BE_u02C1_u02BE_u02BF = this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF;
		int u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE = this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE;
		this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE = u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE + 0;
		u02B6_u02B3_u02B5_u02BE_u02B7_u02C0_u02BC_u02BE_u02C1_u02BE_u02BF[u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE].GetComponent<Ball>().\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2 = this;
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x00093BB0 File Offset: 0x00091DB0
	private void Start()
	{
		base.StartCoroutine(this.\u02B4\u02BB\u02B3\u02C0\u02B9\u02B5\u02BB\u02C0\u02B5\u02B4\u02BB());
		global::UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x00093C60 File Offset: 0x00091E60
	private void \u02BE\u02B4\u02B7\u02B4\u02B7\u02B7\u02B5\u02B6\u02BA\u02B2\u02BE()
	{
		if (this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE >= this.\u02B8\u02BA\u02B7\u02B6\u02C0\u02B2\u02B9\u02BF\u02B8\u02B3\u02BD)
		{
			return;
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Add(global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B7\u02B5\u02BE\u02B5\u02B5\u02B6\u02BA\u02BD\u02B4\u02B4\u02C0));
		List<GameObject> u02B6_u02B3_u02B5_u02BE_u02B7_u02C0_u02BC_u02BE_u02C1_u02BE_u02BF = this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF;
		int u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE = this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE;
		this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE = u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE + 1;
		u02B6_u02B3_u02B5_u02BE_u02B7_u02C0_u02BC_u02BE_u02C1_u02BE_u02BF[u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE].GetComponent<Ball>().\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2 = this;
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x0000F51E File Offset: 0x0000D71E
	private IEnumerator \u02BD\u02B2\u02B8\u02BF\u02B4\u02BA\u02BC\u02B4\u02B9\u02B9\u02B3()
	{
		PongersGame.\u02BA\u02B6\u02BB\u02BB\u02BF\u02B6\u02B5\u02B2\u02B6\u02B4\u02BD u02BA_u02B6_u02BB_u02BB_u02BF_u02B6_u02B5_u02B2_u02B6_u02B4_u02BD = new PongersGame.\u02BA\u02B6\u02BB\u02BB\u02BF\u02B6\u02B5\u02B2\u02B6\u02B4\u02BD(1);
		u02BA_u02B6_u02BB_u02BB_u02BF_u02B6_u02B5_u02B2_u02B6_u02B4_u02BD.<>4__this = this;
		return u02BA_u02B6_u02BB_u02BB_u02BF_u02B6_u02B5_u02B2_u02B6_u02B4_u02BD;
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x0000F51E File Offset: 0x0000D71E
	private IEnumerator \u02BF\u02BB\u02BF\u02B8\u02B4\u02BF\u02BB\u02B2\u02B6\u02BB\u02B5()
	{
		PongersGame.\u02BA\u02B6\u02BB\u02BB\u02BF\u02B6\u02B5\u02B2\u02B6\u02B4\u02BD u02BA_u02B6_u02BB_u02BB_u02BF_u02B6_u02B5_u02B2_u02B6_u02B4_u02BD = new PongersGame.\u02BA\u02B6\u02BB\u02BB\u02BF\u02B6\u02B5\u02B2\u02B6\u02B4\u02BD(1);
		u02BA_u02B6_u02BB_u02BB_u02BF_u02B6_u02B5_u02B2_u02B6_u02B4_u02BD.<>4__this = this;
		return u02BA_u02B6_u02BB_u02BB_u02BF_u02B6_u02B5_u02B2_u02B6_u02B4_u02BD;
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x00093CBC File Offset: 0x00091EBC
	public void \u02C1\u02B2\u02B4\u02BD\u02B3\u02B6\u02B3\u02BF\u02BC\u02BD\u02B8(bool \u02B2\u02C0\u02BA\u02B4\u02B2\u02BD\u02BC\u02B7\u02BD\u02BE\u02B4)
	{
		if (\u02B2\u02C0\u02BA\u02B4\u02B2\u02BD\u02BC\u02B7\u02BD\u02BE\u02B4)
		{
			this.\u02BD\u02B6\u02B6\u02BE\u02C0\u02B4\u02BB\u02BC\u02BC\u02B3\u02B3 = Mathf.Clamp(this.\u02BD\u02B6\u02B6\u02BE\u02C0\u02B4\u02BB\u02BC\u02BC\u02B3\u02B3 + 1, 0, this.\u02B2\u02BE\u02B7\u02B8\u02C1\u02C0\u02B5\u02BE\u02B2\u02C1\u02BE);
			this.\u02B9\u02BF\u02B2\u02BC\u02B5\u02BA\u02BD\u02B9\u02B3\u02BC\u02B7.text = this.\u02BD\u02B6\u02B6\u02BE\u02C0\u02B4\u02BB\u02BC\u02BC\u02B3\u02B3.ToString();
		}
		else
		{
			this.\u02BF\u02C0\u02BC\u02B5\u02B4\u02BF\u02C0\u02BB\u02BA\u02B4\u02B9 = Mathf.Clamp(this.\u02BF\u02C0\u02BC\u02B5\u02B4\u02BF\u02C0\u02BB\u02BA\u02B4\u02B9 + 0, 0, this.\u02B2\u02BE\u02B7\u02B8\u02C1\u02C0\u02B5\u02BE\u02B2\u02C1\u02BE);
			this.\u02B8\u02BD\u02B5\u02C1\u02BB\u02B5\u02BA\u02B3\u02B3\u02C1\u02B6.text = this.\u02BF\u02C0\u02BC\u02B5\u02B4\u02BF\u02C0\u02BB\u02BA\u02B4\u02B9.ToString();
		}
		bool flag = false;
		if (this.\u02BD\u02B6\u02B6\u02BE\u02C0\u02B4\u02BB\u02BC\u02BC\u02B3\u02B3 >= this.\u02B2\u02BE\u02B7\u02B8\u02C1\u02C0\u02B5\u02BE\u02B2\u02C1\u02BE)
		{
			flag = true;
			this.\u02BF\u02BF\u02B5\u02B9\u02B6\u02BC\u02BB\u02BD\u02B4\u02B6\u02BB.text = "Total Notes";
		}
		else if (this.\u02BF\u02C0\u02BC\u02B5\u02B4\u02BF\u02C0\u02BB\u02BA\u02B4\u02B9 >= this.\u02B2\u02BE\u02B7\u02B8\u02C1\u02C0\u02B5\u02BE\u02B2\u02C1\u02BE)
		{
			flag = true;
			this.\u02BF\u02BF\u02B5\u02B9\u02B6\u02BC\u02BB\u02BD\u02B4\u02B6\u02BB.text = " + ";
		}
		if (flag)
		{
			base.StartCoroutine(this.\u02BD\u02B2\u02B8\u02BF\u02B4\u02BA\u02BC\u02B4\u02B9\u02B9\u02B3());
			return;
		}
		this.\u02BD\u02BA\u02BA\u02B6\u02BB\u02B8\u02BF\u02BE\u02B7\u02BA\u02B9();
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x00093D8C File Offset: 0x00091F8C
	public void \u02BE\u02C0\u02B5\u02B7\u02B9\u02BD\u02BB\u02BA\u02BE\u02BB\u02B8(bool \u02B2\u02C0\u02BA\u02B4\u02B2\u02BD\u02BC\u02B7\u02BD\u02BE\u02B4)
	{
		if (\u02B2\u02C0\u02BA\u02B4\u02B2\u02BD\u02BC\u02B7\u02BD\u02BE\u02B4)
		{
			this.\u02BD\u02B6\u02B6\u02BE\u02C0\u02B4\u02BB\u02BC\u02BC\u02B3\u02B3 = Mathf.Clamp(this.\u02BD\u02B6\u02B6\u02BE\u02C0\u02B4\u02BB\u02BC\u02BC\u02B3\u02B3 + 1, 0, this.\u02B2\u02BE\u02B7\u02B8\u02C1\u02C0\u02B5\u02BE\u02B2\u02C1\u02BE);
			this.\u02B9\u02BF\u02B2\u02BC\u02B5\u02BA\u02BD\u02B9\u02B3\u02BC\u02B7.text = this.\u02BD\u02B6\u02B6\u02BE\u02C0\u02B4\u02BB\u02BC\u02BC\u02B3\u02B3.ToString();
		}
		else
		{
			this.\u02BF\u02C0\u02BC\u02B5\u02B4\u02BF\u02C0\u02BB\u02BA\u02B4\u02B9 = Mathf.Clamp(this.\u02BF\u02C0\u02BC\u02B5\u02B4\u02BF\u02C0\u02BB\u02BA\u02B4\u02B9 + 1, 0, this.\u02B2\u02BE\u02B7\u02B8\u02C1\u02C0\u02B5\u02BE\u02B2\u02C1\u02BE);
			this.\u02B8\u02BD\u02B5\u02C1\u02BB\u02B5\u02BA\u02B3\u02B3\u02C1\u02B6.text = this.\u02BF\u02C0\u02BC\u02B5\u02B4\u02BF\u02C0\u02BB\u02BA\u02B4\u02B9.ToString();
		}
		bool flag = false;
		if (this.\u02BD\u02B6\u02B6\u02BE\u02C0\u02B4\u02BB\u02BC\u02BC\u02B3\u02B3 >= this.\u02B2\u02BE\u02B7\u02B8\u02C1\u02C0\u02B5\u02BE\u02B2\u02C1\u02BE)
		{
			flag = true;
			this.\u02BF\u02BF\u02B5\u02B9\u02B6\u02BC\u02BB\u02BD\u02B4\u02B6\u02BB.text = "You're\nWinner !";
		}
		else if (this.\u02BF\u02C0\u02BC\u02B5\u02B4\u02BF\u02C0\u02BB\u02BA\u02B4\u02B9 >= this.\u02B2\u02BE\u02B7\u02B8\u02C1\u02C0\u02B5\u02BE\u02B2\u02C1\u02BE)
		{
			flag = true;
			this.\u02BF\u02BF\u02B5\u02B9\u02B6\u02BC\u02BB\u02BD\u02B4\u02B6\u02BB.text = "You're\nLoser !";
		}
		if (flag)
		{
			base.StartCoroutine(this.\u02C1\u02B5\u02B6\u02BE\u02B3\u02B6\u02B2\u02BF\u02B2\u02B7\u02BE());
			return;
		}
		this.\u02BE\u02B4\u02B7\u02B4\u02B7\u02B7\u02B5\u02B6\u02BA\u02B2\u02BE();
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x00093E5C File Offset: 0x0009205C
	private void \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		base.StartCoroutine(this.\u02B7\u02B9\u02BF\u02B4\u02BA\u02B8\u02BB\u02B9\u02B7\u02C0\u02BE());
		global::UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x00093B54 File Offset: 0x00091D54
	private void \u02B3\u02B4\u02BF\u02C1\u02B4\u02BC\u02BC\u02BF\u02BC\u02B5\u02B6()
	{
		if (this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE >= this.\u02B8\u02BA\u02B7\u02B6\u02C0\u02B2\u02B9\u02BF\u02B8\u02B3\u02BD)
		{
			return;
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Add(global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B7\u02B5\u02BE\u02B5\u02B5\u02B6\u02BA\u02BD\u02B4\u02B4\u02C0));
		List<GameObject> u02B6_u02B3_u02B5_u02BE_u02B7_u02C0_u02BC_u02BE_u02C1_u02BE_u02BF = this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF;
		int u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE = this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE;
		this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE = u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE + 0;
		u02B6_u02B3_u02B5_u02BE_u02B7_u02C0_u02BC_u02BE_u02C1_u02BE_u02BF[u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE].GetComponent<Ball>().\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2 = this;
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x00093C60 File Offset: 0x00091E60
	private void \u02BD\u02BA\u02BA\u02B6\u02BB\u02B8\u02BF\u02BE\u02B7\u02BA\u02B9()
	{
		if (this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE >= this.\u02B8\u02BA\u02B7\u02B6\u02C0\u02B2\u02B9\u02BF\u02B8\u02B3\u02BD)
		{
			return;
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Add(global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B7\u02B5\u02BE\u02B5\u02B5\u02B6\u02BA\u02BD\u02B4\u02B4\u02C0));
		List<GameObject> u02B6_u02B3_u02B5_u02BE_u02B7_u02C0_u02BC_u02BE_u02C1_u02BE_u02BF = this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF;
		int u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE = this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE;
		this.\u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE = u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE + 1;
		u02B6_u02B3_u02B5_u02BE_u02B7_u02C0_u02BC_u02BE_u02C1_u02BE_u02BF[u02B9_u02B7_u02BF_u02BE_u02B7_u02BE_u02B2_u02B6_u02B5_u02C0_u02BE].GetComponent<Ball>().\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2 = this;
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x0000F50F File Offset: 0x0000D70F
	private IEnumerator \u02BA\u02C0\u02BC\u02B8\u02BD\u02B4\u02B4\u02B8\u02B6\u02C1\u02BC()
	{
		this.\u02BF\u02B4\u02B8\u02B9\u02BC\u02C1\u02BA\u02BC\u02BC\u02BD\u02BC();
		this.\u02BE\u02B9\u02BE\u02B7\u02C0\u02BC\u02BC\u02B4\u02C0\u02B5\u02B4.SetActive(true);
		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene("Main Menu");
		yield break;
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x0000F500 File Offset: 0x0000D700
	private IEnumerator \u02B7\u02B9\u02BF\u02B4\u02BA\u02B8\u02BB\u02B9\u02B7\u02C0\u02BE()
	{
		a = 0f;
		this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.SetActive(true);
		yield return new WaitForSeconds(3f);
		while (a < 2f)
		{
			this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.transform.Rotate(Vector3.forward, a * 1.5f * 360f);
			this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.transform.localScale = new Vector2(1f - a / 2f, 1f - a / 2f);
			a += Time.deltaTime;
			yield return null;
		}
		this.\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9.SetActive(false);
		this.\u02BE\u02B4\u02B7\u02B4\u02B7\u02B7\u02B5\u02B6\u02BA\u02B2\u02BE();
		yield break;
	}

	// Token: 0x04000D72 RID: 3442
	public GameObject \u02B7\u02B5\u02BE\u02B5\u02B5\u02B6\u02BA\u02BD\u02B4\u02B4\u02C0;

	// Token: 0x04000D73 RID: 3443
	public TextMeshProUGUI \u02B9\u02BF\u02B2\u02BC\u02B5\u02BA\u02BD\u02B9\u02B3\u02BC\u02B7;

	// Token: 0x04000D74 RID: 3444
	public TextMeshProUGUI \u02B8\u02BD\u02B5\u02C1\u02BB\u02B5\u02BA\u02B3\u02B3\u02C1\u02B6;

	// Token: 0x04000D75 RID: 3445
	public TextMeshProUGUI \u02BF\u02BF\u02B5\u02B9\u02B6\u02BC\u02BB\u02BD\u02B4\u02B6\u02BB;

	// Token: 0x04000D76 RID: 3446
	public int \u02B2\u02BE\u02B7\u02B8\u02C1\u02C0\u02B5\u02BE\u02B2\u02C1\u02BE;

	// Token: 0x04000D77 RID: 3447
	private int \u02BD\u02B6\u02B6\u02BE\u02C0\u02B4\u02BB\u02BC\u02BC\u02B3\u02B3;

	// Token: 0x04000D78 RID: 3448
	private int \u02BF\u02C0\u02BC\u02B5\u02B4\u02BF\u02C0\u02BB\u02BA\u02B4\u02B9;

	// Token: 0x04000D79 RID: 3449
	public int \u02B8\u02BA\u02B7\u02B6\u02C0\u02B2\u02B9\u02BF\u02B8\u02B3\u02BD;

	// Token: 0x04000D7A RID: 3450
	private int \u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE;

	// Token: 0x04000D7B RID: 3451
	private List<GameObject> \u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF = new List<GameObject>(100);

	// Token: 0x04000D7C RID: 3452
	public GameObject \u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9;

	// Token: 0x04000D7D RID: 3453
	public GameObject \u02BE\u02B9\u02BE\u02B7\u02C0\u02BC\u02BC\u02B4\u02C0\u02B5\u02B4;
}
