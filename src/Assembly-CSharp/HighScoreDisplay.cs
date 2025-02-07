﻿using System;
using TMPro;
using UnityEngine;

public class HighScoreDisplay : MonoBehaviour
{
	private void \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.displayText.text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Highway");
		this.objects.SetActive(true);
	}

	private void Start()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.displayText.text = LanguageManager.instance.GetString("New Personal Best!");
		this.objects.SetActive(false);
	}

	public void \u02B3\u02BC\u02B4\u02B5\u02BD\u02C0\u02B8\u02BD\u02B7\u02B5\u02BF(bool \u02BD\u02B9\u02C1\u02B4\u02BB\u02B5\u02BB\u02B8\u02C1\u02B6\u02B2 = false)
	{
		this.objects.SetActive(true);
		this.animator.Play((!\u02BD\u02B9\u02C1\u02B4\u02BB\u02B5\u02BB\u02B8\u02C1\u02B6\u02B2) ? "BaseAnimation" : "BaseAnimationBackwards");
	}

	public void \u02B4\u02B6\u02B8\u02B8\u02B9\u02BA\u02BA\u02B7\u02B8\u02BD\u02B4(bool \u02BD\u02B9\u02C1\u02B4\u02BB\u02B5\u02BB\u02B8\u02C1\u02B6\u02B2 = false)
	{
		this.objects.SetActive(true);
		this.animator.Play((!\u02BD\u02B9\u02C1\u02B4\u02BB\u02B5\u02BB\u02B8\u02C1\u02B6\u02B2) ? "" : "Video Highways");
	}

	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.displayText.text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Stars Earned");
		this.objects.SetActive(false);
	}

	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.displayText.text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Highway Placement");
		this.objects.SetActive(false);
	}

	public void \u02BE\u02C0\u02B5\u02B5\u02B3\u02B7\u02C1\u02B3\u02BA\u02B5\u02B7(bool \u02BD\u02B9\u02C1\u02B4\u02BB\u02B5\u02BB\u02B8\u02C1\u02B6\u02B2 = false)
	{
		this.objects.SetActive(true);
		this.animator.Play((!\u02BD\u02B9\u02C1\u02B4\u02BB\u02B5\u02BB\u02B8\u02C1\u02B6\u02B2) ? "Tom1" : "Metal");
	}

	[SerializeField]
	private global::UnityEngine.Animator animator;

	[SerializeField]
	private TextMeshProUGUI displayText;

	[SerializeField]
	private GameObject objects;
}
