﻿using System;
using UnityEngine;
using UnityEngine.UI;

public class EOSScreenshotNotification : MonoBehaviour
{
	public void \u02BA\u02C1\u02BB\u02C1\u02BC\u02B5\u02C1\u02B5\u02BD\u02B8\u02B6()
	{
		this.animator.SetBool("EndOfSong", false);
	}

	public void \u02B6\u02B7\u02BA\u02B5\u02B3\u02B7\u02B3\u02BF\u02BA\u02BD\u02BD(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(false);
		this.title.text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().GetString("Unknown");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	public void \u02B5\u02C0\u02B6\u02C0\u02B5\u02B7\u02C1\u02BF\u02B5\u02BD\u02B2(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(false);
		this.title.text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().GetString("Ready");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	public void \u02B4\u02B2\u02BD\u02B7\u02BF\u02BD\u02B2\u02B4\u02B7\u02B9\u02BC(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(true);
		this.title.text = LanguageManager.instance.GetString("Screenshot Saved");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	public void \u02B5\u02C0\u02BB\u02BD\u02B2\u02C0\u02BC\u02BD\u02B4\u02BD\u02B5(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(true);
		this.title.text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("ERROR: These folders have no notes.mid or notes.chart files!");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	public void \u02B4\u02BB\u02C0\u02BB\u02B3\u02BF\u02C1\u02B3\u02B5\u02BF\u02BE()
	{
		this.animator.SetBool("scoreDisabled", true);
	}

	public void \u02B3\u02B5\u02B4\u02C1\u02BF\u02B3\u02BE\u02B3\u02B8\u02B8\u02BD()
	{
		this.animator.SetBool("isHidden", true);
	}

	public void \u02B9\u02B7\u02BA\u02BD\u02B2\u02BB\u02C1\u02B6\u02BF\u02B2\u02B4(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(true);
		this.title.text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	public void \u02B2\u02B4\u02BE\u02C1\u02BA\u02BA\u02B8\u02BE\u02C1\u02BB\u02B8()
	{
		this.animator.SetBool("Vocals", false);
	}

	public void \u02B6\u02BC\u02B6\u02BD\u02C0\u02BD\u02BF\u02B2\u02BB\u02BC\u02B8()
	{
		this.animator.SetBool(": ", false);
	}

	public void \u02BF\u02BC\u02BF\u02BF\u02B4\u02B4\u02B9\u02BD\u02BB\u02BB\u02B2()
	{
		this.animator.SetBool("", true);
	}

	public void \u02BB\u02BA\u02BD\u02C1\u02BC\u02C0\u02B5\u02BB\u02BB\u02B5\u02BE()
	{
		this.animator.SetBool("hasBots", false);
	}

	public void \u02B9\u02BC\u02BD\u02B6\u02BA\u02BD\u02B6\u02B4\u02B8\u02C0\u02BF()
	{
		this.animator.SetBool("PracticeReset", false);
	}

	public void \u02B3\u02C0\u02BC\u02B5\u02B7\u02BC\u02B2\u02BD\u02B4\u02B6\u02BA(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(true);
		this.title.text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().GetString("ERROR: These folders have *.mid or *.chart files but are named incorrectly!");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	public void \u02B7\u02B8\u02BD\u02C1\u02B9\u02B8\u02B8\u02B7\u02BB\u02B5\u02BE()
	{
		this.animator.SetBool("Selection", false);
	}

	public void \u02BD\u02BB\u02C0\u02C1\u02B2\u02BE\u02B7\u02B9\u02BB\u02B7\u02B7()
	{
		this.animator.SetBool("song", false);
	}

	public void \u02BE\u02B4\u02BE\u02BC\u02BF\u02B6\u02B5\u02B3\u02B9\u02B2\u02B9()
	{
		this.animator.SetBool(".webm", true);
	}

	public void \u02B5\u02BF\u02BD\u02BC\u02B9\u02B6\u02BA\u02B6\u02B9\u02BC\u02BF(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(false);
		this.title.text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Medium");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	public void \u02BB\u02B5\u02B9\u02B8\u02BB\u02C0\u02C0\u02B6\u02B2\u02BC\u02B3(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		base.gameObject.SetActive(false);
		this.title.text = LanguageManager.instance.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("rhythm6fret");
		this.image.texture = \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9;
	}

	[SerializeField]
	private global::UnityEngine.Animator animator;

	[SerializeField]
	private Text title;

	[SerializeField]
	private RawImage image;
}
