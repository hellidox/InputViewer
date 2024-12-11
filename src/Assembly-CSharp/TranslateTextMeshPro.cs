﻿using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TranslateTextMeshPro : MonoBehaviour
{
	private IEnumerator \u02B6\u02BD\u02BB\u02B2\u02B7\u02B4\u02B4\u02B9\u02BB\u02C1\u02BC()
	{
		TranslateTextMeshPro.\u02B7\u02BC\u02B2\u02B4\u02BB\u02BF\u02C1\u02C0\u02BD\u02BF\u02BD u02B7_u02BC_u02B2_u02B4_u02BB_u02BF_u02C1_u02C0_u02BD_u02BF_u02BD = new TranslateTextMeshPro.\u02B7\u02BC\u02B2\u02B4\u02BB\u02BF\u02C1\u02C0\u02BD\u02BF\u02BD(1);
		u02B7_u02BC_u02B2_u02B4_u02BB_u02BF_u02C1_u02C0_u02BD_u02BF_u02BD.<>4__this = this;
		return u02B7_u02BC_u02B2_u02B4_u02BB_u02BF_u02C1_u02C0_u02BD_u02BF_u02BD;
	}

	private IEnumerator \u02B3\u02B6\u02BA\u02BD\u02BF\u02C1\u02BD\u02BF\u02B7\u02B3\u02B7()
	{
		yield return TranslateTextMeshPro.\u02BC\u02BE\u02BF\u02B4\u02BF\u02B3\u02B6\u02C0\u02C1\u02C0\u02B7;
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = LanguageManager.instance.GetString(this.\u02BB\u02BF\u02B6\u02B3\u02BC\u02BE\u02BD\u02B5\u02BB\u02B4\u02B6);
		yield break;
	}

	private void \u02B9\u02B7\u02C0\u02B7\u02C1\u02BA\u02BC\u02C0\u02C1\u02BD\u02B6()
	{
		this.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA();
	}

	public void \u02BE\u02B8\u02BE\u02BD\u02BE\u02B5\u02B6\u02BF\u02B3\u02C0\u02BD()
	{
		if (LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2() != null && LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B3\u02B8\u02BF\u02C0\u02C0\u02BC\u02BD\u02B5\u02B5\u02B6\u02B5())
		{
			this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(this.\u02BB\u02BF\u02B6\u02B3\u02BC\u02BE\u02BD\u02B5\u02BB\u02B4\u02B6);
			return;
		}
		base.StartCoroutine(this.\u02B3\u02B6\u02BA\u02BD\u02BF\u02C1\u02BD\u02BF\u02B7\u02B3\u02B7());
	}

	private void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		this.\u02BE\u02B8\u02BE\u02BD\u02BE\u02B5\u02B6\u02BF\u02B3\u02C0\u02BD();
	}

	private void \u02B3\u02C1\u02B9\u02B7\u02B4\u02BF\u02BD\u02B9\u02BB\u02BE\u02B6()
	{
		this.\u02B8\u02B9\u02B5\u02B4\u02BF\u02C1\u02B5\u02B5\u02B7\u02B6\u02B7();
	}

	private void \u02BD\u02BF\u02B6\u02B8\u02BB\u02B2\u02BF\u02C0\u02B5\u02B9\u02BC()
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = base.GetComponent<TMP_Text>();
		this.\u02BE\u02C0\u02B7\u02B7\u02BC\u02BA\u02B8\u02BA\u02BB\u02BF\u02BD = base.GetComponentInParent<VerticalLayoutGroup>();
	}

	private void OnEnable()
	{
		this.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA();
	}

	private void \u02B7\u02BF\u02BC\u02C0\u02B5\u02BD\u02BF\u02BB\u02C1\u02BF\u02B2()
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = base.GetComponent<TMP_Text>();
		this.\u02BE\u02C0\u02B7\u02B7\u02BC\u02BA\u02B8\u02BA\u02BB\u02BF\u02BD = base.GetComponentInParent<VerticalLayoutGroup>();
	}

	private void Start()
	{
		this.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA();
	}

	public void \u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA()
	{
		if (LanguageManager.instance != null && LanguageManager.instance.\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6)
		{
			this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = LanguageManager.instance.GetString(this.\u02BB\u02BF\u02B6\u02B3\u02BC\u02BE\u02BD\u02B5\u02BB\u02B4\u02B6);
			return;
		}
		base.StartCoroutine(this.\u02B8\u02B9\u02C1\u02C1\u02BF\u02B9\u02B5\u02B2\u02BA\u02B3\u02B5());
	}

	private void \u02BE\u02B9\u02B7\u02B5\u02BC\u02B2\u02B8\u02BC\u02C0\u02B9\u02BE()
	{
		this.\u02BE\u02B8\u02BE\u02BD\u02BE\u02B5\u02B6\u02BF\u02B3\u02C0\u02BD();
	}

	private void Awake()
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = base.GetComponent<TMP_Text>();
		this.\u02BE\u02C0\u02B7\u02B7\u02BC\u02BA\u02B8\u02BA\u02BB\u02BF\u02BD = base.GetComponentInParent<VerticalLayoutGroup>();
	}

	public void \u02BA\u02B4\u02B3\u02BC\u02BC\u02BB\u02B4\u02BF\u02B9\u02BE\u02BD()
	{
		if (LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9() != null && LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B3\u02B8\u02BF\u02C0\u02C0\u02BC\u02BD\u02B5\u02B5\u02B6\u02B5())
		{
			this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(this.\u02BB\u02BF\u02B6\u02B3\u02BC\u02BE\u02BD\u02B5\u02BB\u02B4\u02B6);
			return;
		}
		base.StartCoroutine(this.\u02B3\u02BD\u02BE\u02B4\u02BD\u02BC\u02B9\u02BA\u02B2\u02BB\u02B6());
	}

	private IEnumerator \u02B8\u02B9\u02C1\u02C1\u02BF\u02B9\u02B5\u02B2\u02BA\u02B3\u02B5()
	{
		yield return TranslateTextMeshPro.\u02BC\u02BE\u02BF\u02B4\u02BF\u02B3\u02B6\u02C0\u02C1\u02C0\u02B7;
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = LanguageManager.instance.GetString(this.\u02BB\u02BF\u02B6\u02B3\u02BC\u02BE\u02BD\u02B5\u02BB\u02B4\u02B6);
		yield break;
	}

	public void \u02B8\u02B9\u02B5\u02B4\u02BF\u02C1\u02B5\u02B5\u02B7\u02B6\u02B7()
	{
		if (LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9() != null && LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B3\u02B8\u02BF\u02C0\u02C0\u02BC\u02BD\u02B5\u02B5\u02B6\u02B5())
		{
			this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(this.\u02BB\u02BF\u02B6\u02B3\u02BC\u02BE\u02BD\u02B5\u02BB\u02B4\u02B6);
			return;
		}
		base.StartCoroutine(this.\u02B3\u02BD\u02BE\u02B4\u02BD\u02BC\u02B9\u02BA\u02B2\u02BB\u02B6());
	}

	private void \u02B5\u02B9\u02B5\u02B3\u02BF\u02C1\u02B7\u02BD\u02C0\u02B7\u02C0()
	{
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = base.GetComponent<TMP_Text>();
		this.\u02BE\u02C0\u02B7\u02B7\u02BC\u02BA\u02B8\u02BA\u02BB\u02BF\u02BD = base.GetComponentInParent<VerticalLayoutGroup>();
	}

	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		this.\u02B8\u02B9\u02B5\u02B4\u02BF\u02C1\u02B5\u02B5\u02B7\u02B6\u02B7();
	}

	private IEnumerator \u02B3\u02BD\u02BE\u02B4\u02BD\u02BC\u02B9\u02BA\u02B2\u02BB\u02B6()
	{
		TranslateTextMeshPro.\u02B7\u02BC\u02B2\u02B4\u02BB\u02BF\u02C1\u02C0\u02BD\u02BF\u02BD u02B7_u02BC_u02B2_u02B4_u02BB_u02BF_u02C1_u02C0_u02BD_u02BF_u02BD = new TranslateTextMeshPro.\u02B7\u02BC\u02B2\u02B4\u02BB\u02BF\u02C1\u02C0\u02BD\u02BF\u02BD(1);
		u02B7_u02BC_u02B2_u02B4_u02BB_u02BF_u02C1_u02C0_u02BD_u02BF_u02BD.<>4__this = this;
		return u02B7_u02BC_u02B2_u02B4_u02BB_u02BF_u02C1_u02C0_u02BD_u02BF_u02BD;
	}

	private void \u02B4\u02B7\u02C1\u02B8\u02B2\u02B9\u02B6\u02B2\u02B5\u02B7\u02B7()
	{
		this.\u02B8\u02B9\u02B5\u02B4\u02BF\u02C1\u02B5\u02B5\u02B7\u02B6\u02B7();
	}

	[\u02BE\u02B2\u02B2\u02BA\u02BE\u02B7\u02BF\u02B3\u02BE\u02C1\u02BA]
	public string \u02BB\u02BF\u02B6\u02B3\u02BC\u02BE\u02BD\u02B5\u02BB\u02B4\u02B6;

	private TMP_Text \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF;

	private static WaitUntil \u02BC\u02BE\u02BF\u02B4\u02BF\u02B3\u02B6\u02C0\u02C1\u02C0\u02B7 = new WaitUntil(new Func<bool>(TranslateTextMeshPro.<>c.<>9.\u02BB\u02BF\u02B7\u02B4\u02BE\u02B7\u02BC\u02BA\u02BB\u02B3\u02BF));

	private VerticalLayoutGroup \u02BE\u02C0\u02B7\u02B7\u02BC\u02BA\u02B8\u02BA\u02BB\u02BF\u02BD;
}
