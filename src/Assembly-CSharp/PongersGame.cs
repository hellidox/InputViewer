using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PongersGame : MonoBehaviour
{
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

	private void \u02B4\u02BD\u02B8\u02BE\u02C0\u02C1\u02C0\u02C1\u02BD\u02C0\u02BF()
	{
		for (int i = 1; i < this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Count; i++)
		{
			global::UnityEngine.Object.Destroy(this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF[i]);
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Clear();
	}

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

	private void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		base.StartCoroutine(this.\u02B4\u02BB\u02B3\u02C0\u02B9\u02B5\u02BB\u02C0\u02B5\u02B4\u02BB());
		global::UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
	}

	private void \u02BF\u02C1\u02BE\u02C0\u02B3\u02BB\u02B8\u02B7\u02BE\u02BB\u02B8()
	{
		for (int i = 0; i < this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Count; i++)
		{
			global::UnityEngine.Object.Destroy(this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF[i]);
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Clear();
	}

	private void \u02BF\u02B4\u02B8\u02B9\u02BC\u02C1\u02BA\u02BC\u02BC\u02BD\u02BC()
	{
		for (int i = 0; i < this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Count; i++)
		{
			global::UnityEngine.Object.Destroy(this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF[i]);
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Clear();
	}

	private IEnumerator \u02C0\u02BE\u02B2\u02B5\u02BB\u02B3\u02BF\u02B9\u02BE\u02B4\u02BF()
	{
		this.\u02BF\u02B4\u02B8\u02B9\u02BC\u02C1\u02BA\u02BC\u02BC\u02BD\u02BC();
		this.\u02BE\u02B9\u02BE\u02B7\u02C0\u02BC\u02BC\u02B4\u02C0\u02B5\u02B4.SetActive(true);
		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene("Main Menu");
		yield break;
	}

	private void \u02B8\u02BE\u02BF\u02B7\u02B8\u02C1\u02C1\u02B9\u02B2\u02B5\u02B7()
	{
		for (int i = 1; i < this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Count; i++)
		{
			global::UnityEngine.Object.Destroy(this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF[i]);
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Clear();
	}

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

	private IEnumerator \u02C1\u02B5\u02B6\u02BE\u02B3\u02B6\u02B2\u02BF\u02B2\u02B7\u02BE()
	{
		this.\u02BF\u02B4\u02B8\u02B9\u02BC\u02C1\u02BA\u02BC\u02BC\u02BD\u02BC();
		this.\u02BE\u02B9\u02BE\u02B7\u02C0\u02BC\u02BC\u02B4\u02C0\u02B5\u02B4.SetActive(true);
		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene("Main Menu");
		yield break;
	}

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

	private void \u02BB\u02B9\u02C0\u02B4\u02BA\u02BC\u02B7\u02BB\u02B2\u02B6\u02C1()
	{
		for (int i = 0; i < this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Count; i += 0)
		{
			global::UnityEngine.Object.Destroy(this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF[i]);
		}
		this.\u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF.Clear();
	}

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

	private void Start()
	{
		base.StartCoroutine(this.\u02B4\u02BB\u02B3\u02C0\u02B9\u02B5\u02BB\u02C0\u02B5\u02B4\u02BB());
		global::UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
	}

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

	private IEnumerator \u02BD\u02B2\u02B8\u02BF\u02B4\u02BA\u02BC\u02B4\u02B9\u02B9\u02B3()
	{
		PongersGame.\u02BA\u02B6\u02BB\u02BB\u02BF\u02B6\u02B5\u02B2\u02B6\u02B4\u02BD u02BA_u02B6_u02BB_u02BB_u02BF_u02B6_u02B5_u02B2_u02B6_u02B4_u02BD = new PongersGame.\u02BA\u02B6\u02BB\u02BB\u02BF\u02B6\u02B5\u02B2\u02B6\u02B4\u02BD(1);
		u02BA_u02B6_u02BB_u02BB_u02BF_u02B6_u02B5_u02B2_u02B6_u02B4_u02BD.<>4__this = this;
		return u02BA_u02B6_u02BB_u02BB_u02BF_u02B6_u02B5_u02B2_u02B6_u02B4_u02BD;
	}

	private IEnumerator \u02BF\u02BB\u02BF\u02B8\u02B4\u02BF\u02BB\u02B2\u02B6\u02BB\u02B5()
	{
		PongersGame.\u02BA\u02B6\u02BB\u02BB\u02BF\u02B6\u02B5\u02B2\u02B6\u02B4\u02BD u02BA_u02B6_u02BB_u02BB_u02BF_u02B6_u02B5_u02B2_u02B6_u02B4_u02BD = new PongersGame.\u02BA\u02B6\u02BB\u02BB\u02BF\u02B6\u02B5\u02B2\u02B6\u02B4\u02BD(1);
		u02BA_u02B6_u02BB_u02BB_u02BF_u02B6_u02B5_u02B2_u02B6_u02B4_u02BD.<>4__this = this;
		return u02BA_u02B6_u02BB_u02BB_u02BF_u02B6_u02B5_u02B2_u02B6_u02B4_u02BD;
	}

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

	private void \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		base.StartCoroutine(this.\u02B7\u02B9\u02BF\u02B4\u02BA\u02B8\u02BB\u02B9\u02B7\u02C0\u02BE());
		global::UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
	}

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

	private IEnumerator \u02BA\u02C0\u02BC\u02B8\u02BD\u02B4\u02B4\u02B8\u02B6\u02C1\u02BC()
	{
		this.\u02BF\u02B4\u02B8\u02B9\u02BC\u02C1\u02BA\u02BC\u02BC\u02BD\u02BC();
		this.\u02BE\u02B9\u02BE\u02B7\u02C0\u02BC\u02BC\u02B4\u02C0\u02B5\u02B4.SetActive(true);
		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene("Main Menu");
		yield break;
	}

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

	public GameObject \u02B7\u02B5\u02BE\u02B5\u02B5\u02B6\u02BA\u02BD\u02B4\u02B4\u02C0;

	public TextMeshProUGUI \u02B9\u02BF\u02B2\u02BC\u02B5\u02BA\u02BD\u02B9\u02B3\u02BC\u02B7;

	public TextMeshProUGUI \u02B8\u02BD\u02B5\u02C1\u02BB\u02B5\u02BA\u02B3\u02B3\u02C1\u02B6;

	public TextMeshProUGUI \u02BF\u02BF\u02B5\u02B9\u02B6\u02BC\u02BB\u02BD\u02B4\u02B6\u02BB;

	public int \u02B2\u02BE\u02B7\u02B8\u02C1\u02C0\u02B5\u02BE\u02B2\u02C1\u02BE;

	private int \u02BD\u02B6\u02B6\u02BE\u02C0\u02B4\u02BB\u02BC\u02BC\u02B3\u02B3;

	private int \u02BF\u02C0\u02BC\u02B5\u02B4\u02BF\u02C0\u02BB\u02BA\u02B4\u02B9;

	public int \u02B8\u02BA\u02B7\u02B6\u02C0\u02B2\u02B9\u02BF\u02B8\u02B3\u02BD;

	private int \u02B9\u02B7\u02BF\u02BE\u02B7\u02BE\u02B2\u02B6\u02B5\u02C0\u02BE;

	private List<GameObject> \u02B6\u02B3\u02B5\u02BE\u02B7\u02C0\u02BC\u02BE\u02C1\u02BE\u02BF = new List<GameObject>(100);

	public GameObject \u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9;

	public GameObject \u02BE\u02B9\u02BE\u02B7\u02C0\u02BC\u02BC\u02B4\u02C0\u02B5\u02B4;
}
