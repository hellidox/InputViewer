using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeBehaviour : MonoBehaviour
{
	public IEnumerator \u02B8\u02BE\u02BF\u02C1\u02BA\u02B6\u02BA\u02BF\u02BF\u02BF\u02B4()
	{
		FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD = new FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD(1);
		u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD.<>4__this = this;
		return u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD;
	}

	public IEnumerator \u02B4\u02B8\u02B6\u02B7\u02B9\u02B9\u02B8\u02B4\u02C0\u02BE\u02B4()
	{
		FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD = new FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD(1);
		u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD.<>4__this = this;
		return u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD;
	}

	private void Start()
	{
		SceneManager.activeSceneChanged += this.\u02B7\u02BB\u02B6\u02B6\u02B4\u02B6\u02C0\u02BC\u02BD\u02BD\u02BA;
	}

	public IEnumerator \u02B3\u02BB\u02B3\u02C0\u02B2\u02BA\u02BF\u02C1\u02BA\u02BF\u02B7()
	{
		FadeBehaviour.\u02C0\u02B7\u02B4\u02BC\u02BF\u02B8\u02B7\u02B5\u02BB\u02BE\u02B2 u02C0_u02B7_u02B4_u02BC_u02BF_u02B8_u02B7_u02B5_u02BB_u02BE_u02B = new FadeBehaviour.\u02C0\u02B7\u02B4\u02BC\u02BF\u02B8\u02B7\u02B5\u02BB\u02BE\u02B2(1);
		u02C0_u02B7_u02B4_u02BC_u02BF_u02B8_u02B7_u02B5_u02BB_u02BE_u02B.<>4__this = this;
		return u02C0_u02B7_u02B4_u02BC_u02BF_u02B8_u02B7_u02B5_u02BB_u02BE_u02B;
	}

	private IEnumerator \u02B9\u02C1\u02B5\u02B9\u02BE\u02BC\u02B5\u02B7\u02C0\u02BC\u02BF(string \u02B7\u02BB\u02BE\u02BB\u02BC\u02BD\u02B7\u02B8\u02C0\u02B2\u02B7)
	{
		FadeBehaviour.\u02BF\u02B3\u02B9\u02BA\u02C1\u02B3\u02B4\u02B8\u02BB\u02B3\u02C0 u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C = new FadeBehaviour.\u02BF\u02B3\u02B9\u02BA\u02C1\u02B3\u02B4\u02B8\u02BB\u02B3\u02C0(1);
		u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C.<>4__this = this;
		u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C.sceneName = \u02B7\u02BB\u02BE\u02BB\u02BC\u02BD\u02B7\u02B8\u02C0\u02B2\u02B7;
		return u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C;
	}

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

	public IEnumerator \u02C1\u02BB\u02C0\u02BA\u02B6\u02B2\u02B7\u02B4\u02B6\u02B4\u02BC()
	{
		FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD = new FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD(1);
		u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD.<>4__this = this;
		return u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD;
	}

	public IEnumerator \u02BB\u02BE\u02B4\u02C1\u02C0\u02B7\u02C1\u02B9\u02B9\u02B8\u02BD()
	{
		FadeBehaviour.\u02C0\u02B7\u02B4\u02BC\u02BF\u02B8\u02B7\u02B5\u02BB\u02BE\u02B2 u02C0_u02B7_u02B4_u02BC_u02BF_u02B8_u02B7_u02B5_u02BB_u02BE_u02B = new FadeBehaviour.\u02C0\u02B7\u02B4\u02BC\u02BF\u02B8\u02B7\u02B5\u02BB\u02BE\u02B2(1);
		u02C0_u02B7_u02B4_u02BC_u02BF_u02B8_u02B7_u02B5_u02BB_u02BE_u02B.<>4__this = this;
		return u02C0_u02B7_u02B4_u02BC_u02BF_u02B8_u02B7_u02B5_u02BB_u02BE_u02B;
	}

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

	private void \u02B8\u02C1\u02B9\u02BC\u02B6\u02B9\u02B3\u02B5\u02B7\u02BF\u02BD()
	{
		if (FadeBehaviour.instance != null)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		FadeBehaviour.instance = this;
		global::UnityEngine.Object.DontDestroyOnLoad(this);
		this.\u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE = new WaitForSecondsRealtime(this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9);
	}

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

	public IEnumerator \u02B5\u02BF\u02BA\u02BB\u02BE\u02BA\u02B6\u02BE\u02C0\u02B7\u02C0()
	{
		FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD = new FadeBehaviour.\u02B9\u02C0\u02B3\u02B4\u02BB\u02C1\u02B2\u02C0\u02B3\u02B6\u02BD(1);
		u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD.<>4__this = this;
		return u02B9_u02C0_u02B3_u02B4_u02BB_u02C1_u02B2_u02C0_u02B3_u02B6_u02BD;
	}

	private IEnumerator \u02BC\u02B8\u02B5\u02BB\u02B9\u02B8\u02B3\u02BA\u02BF\u02BB\u02BB(string \u02B7\u02BB\u02BE\u02BB\u02BC\u02BD\u02B7\u02B8\u02C0\u02B2\u02B7)
	{
		FadeBehaviour.\u02BF\u02B3\u02B9\u02BA\u02C1\u02B3\u02B4\u02B8\u02BB\u02B3\u02C0 u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C = new FadeBehaviour.\u02BF\u02B3\u02B9\u02BA\u02C1\u02B3\u02B4\u02B8\u02BB\u02B3\u02C0(1);
		u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C.<>4__this = this;
		u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C.sceneName = \u02B7\u02BB\u02BE\u02BB\u02BC\u02BD\u02B7\u02B8\u02C0\u02B2\u02B7;
		return u02BF_u02B3_u02B9_u02BA_u02C1_u02B3_u02B4_u02B8_u02BB_u02B3_u02C;
	}

	public void \u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE(string \u02BB\u02B7\u02BC\u02B6\u02B9\u02C0\u02B7\u02BE\u02B5\u02C0\u02BA, float \u02B4\u02B3\u02BF\u02B3\u02BF\u02B6\u02BE\u02B5\u02B3\u02B2\u02BE = 0f)
	{
		base.StartCoroutine(this.\u02C1\u02B4\u02B3\u02B6\u02C1\u02B7\u02B4\u02B9\u02C1\u02B4\u02BF(\u02BB\u02B7\u02BC\u02B6\u02B9\u02C0\u02B7\u02BE\u02B5\u02C0\u02BA));
	}

	private IEnumerator \u02C1\u02B4\u02B3\u02B6\u02C1\u02B7\u02B4\u02B9\u02C1\u02B4\u02BF(string \u02B7\u02BB\u02BE\u02BB\u02BC\u02BD\u02B7\u02B8\u02C0\u02B2\u02B7)
	{
		this.isFading = true;
		yield return this.\u02BE\u02BA\u02B4\u02B8\u02B2\u02B7\u02BB\u02BD\u02C0\u02B4\u02B9();
		Time.timeScale = 1f;
		AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(\u02B7\u02BB\u02BE\u02BB\u02BC\u02BD\u02B7\u02B8\u02C0\u02B2\u02B7);
		yield return asyncOperation;
		yield break;
	}

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

	private void \u02B7\u02BB\u02B6\u02B6\u02B4\u02B6\u02C0\u02BC\u02BD\u02BD\u02BA(Scene \u02B4\u02B7\u02BA\u02B5\u02B7\u02C0\u02B3\u02BB\u02BF\u02C1\u02BA, Scene \u02B3\u02BA\u02B8\u02BC\u02B5\u02BD\u02B3\u02B7\u02BA\u02C1\u02B9)
	{
		this.isFading = false;
	}

	private void Awake()
	{
		if (FadeBehaviour.instance != null)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		FadeBehaviour.instance = this;
		global::UnityEngine.Object.DontDestroyOnLoad(this);
		this.\u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE = new WaitForSecondsRealtime(this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9);
	}

	private void \u02B3\u02B8\u02C1\u02BE\u02B7\u02C0\u02B8\u02B8\u02B3\u02B3\u02B7()
	{
		if (FadeBehaviour.instance != null)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		FadeBehaviour.instance = this;
		global::UnityEngine.Object.DontDestroyOnLoad(this);
		this.\u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE = new WaitForSecondsRealtime(this.\u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9);
	}

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

	public static FadeBehaviour instance;

	[SerializeField]
	private Image fadeGraphic;

	public float \u02B8\u02B6\u02B9\u02BC\u02B3\u02B3\u02BC\u02B6\u02C0\u02B6\u02B9;

	public bool isFading;

	private WaitForSecondsRealtime \u02B4\u02B5\u02BD\u02BA\u02BA\u02BB\u02B5\u02B4\u02B4\u02B8\u02BE;

	private bool \u02B8\u02C0\u02B9\u02B5\u02C1\u02BA\u02BC\u02BD\u02B8\u02B7\u02BF;
}
