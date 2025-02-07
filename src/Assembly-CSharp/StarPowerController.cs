﻿using System;
using UnityEngine;

public class StarPowerController : MonoBehaviour, \u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7
{
	public void \u02BA\u02B9\u02B2\u02BA\u02B8\u02B8\u02C1\u02B9\u02BA\u02B5\u02B5()
	{
		this.\u02C1\u02BC\u02B4\u02C1\u02B5\u02B8\u02C1\u02B9\u02BB\u02BE\u02B6.SetTrigger("Modifiers");
		this.\u02B4\u02C1\u02B9\u02B3\u02BE\u02B3\u02B2\u02BD\u02B5\u02BB\u02BB.SetTrigger("MIDI Profiles");
	}

	public void \u02BC\u02B4\u02BC\u02B2\u02BF\u02B8\u02B8\u02BB\u02BC\u02BF\u02C0()
	{
		this.\u02C1\u02BC\u02B4\u02C1\u02B5\u02B8\u02C1\u02B9\u02BB\u02BE\u02B6.SetTrigger("size too small");
		this.\u02B4\u02C1\u02B9\u02B3\u02BE\u02B3\u02B2\u02BD\u02B5\u02BB\u02BB.SetTrigger("ScoreDisabledModifier");
	}

	public void \u02B3\u02C1\u02BB\u02BF\u02BA\u02B8\u02B2\u02BD\u02B7\u02BC\u02B9()
	{
		this.\u02C1\u02BC\u02B4\u02C1\u02B5\u02B8\u02C1\u02B9\u02BB\u02BE\u02B6.SetTrigger("Playing Audio");
		this.\u02B4\u02C1\u02B9\u02B3\u02BE\u02B3\u02B2\u02BD\u02B5\u02BB\u02BB.SetTrigger("Caret");
	}

	public void \u02C0\u02C1\u02B5\u02B6\u02BE\u02B8\u02B7\u02B7\u02BC\u02BA\u02B9(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6 { get; set; }

	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B5\u02B8\u02BB\u02B5\u02BD\u02B2\u02B9\u02BC\u02BA\u02B8\u02BB()
	{
		return this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField;
	}

	public void \u02B2\u02B7\u02B3\u02BE\u02B5\u02BE\u02B4\u02BE\u02BF\u02B6\u02B2(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02C1\u02B6\u02BC\u02BC\u02B4\u02B2\u02BE\u02BC\u02B7\u02B2\u02BC()
	{
		return this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField;
	}

	private void Start()
	{
		Color u02B8_u02BF_u02B6_u02B4_u02B7_u02BB_u02B8_u02B6_u02B9_u02BB_u02B = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B8\u02BF\u02B6\u02B4\u02B7\u02BB\u02B8\u02B6\u02B9\u02BB\u02B4;
		u02B8_u02BF_u02B6_u02B4_u02B7_u02BB_u02B8_u02B6_u02B9_u02BB_u02B.a = 0f;
		AnimatorColorBehavior[] array = this.\u02BC\u02B3\u02BB\u02B2\u02BA\u02B8\u02BA\u02BD\u02B6\u02BE\u02B4;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].colorizeColor = u02B8_u02BF_u02B6_u02B4_u02B7_u02BB_u02B8_u02B6_u02B9_u02BB_u02B;
		}
		Color u02BC_u02B6_u02BF_u02BA_u02B6_u02B7_u02C0_u02BE_u02BA_u02BF_u02B = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02BC\u02B6\u02BF\u02BA\u02B6\u02B7\u02C0\u02BE\u02BA\u02BF\u02B5;
		u02BC_u02B6_u02BF_u02BA_u02B6_u02B7_u02C0_u02BE_u02BA_u02BF_u02B.a = 0f;
		array = this.\u02B7\u02B3\u02B8\u02BE\u02BD\u02BB\u02B8\u02BC\u02BB\u02B5\u02B8;
		for (int j = 0; j < array.Length; j++)
		{
			array[j].colorizeColor = u02BC_u02B6_u02BF_u02BA_u02B6_u02B7_u02C0_u02BE_u02BA_u02BF_u02B;
		}
		this.\u02B3\u02BE\u02B8\u02BC\u02B3\u02BD\u02BA\u02B9\u02B5\u02BB\u02B5.color = u02BC_u02B6_u02BF_u02BA_u02B6_u02B7_u02C0_u02BE_u02BA_u02BF_u02B;
		SpriteRenderer[] u02BA_u02BE_u02B8_u02B5_u02B9_u02BA_u02C0_u02C0_u02C0_u02BA_u02BC = this.\u02BA\u02BE\u02B8\u02B5\u02B9\u02BA\u02C0\u02C0\u02C0\u02BA\u02BC;
		for (int k = 0; k < u02BA_u02BE_u02B8_u02B5_u02B9_u02BA_u02C0_u02C0_u02C0_u02BA_u02BC.Length; k++)
		{
			u02BA_u02BE_u02B8_u02B5_u02B9_u02BA_u02C0_u02C0_u02C0_u02BA_u02BC[k].color = u02BC_u02B6_u02BF_u02BA_u02B6_u02B7_u02C0_u02BE_u02BA_u02BF_u02B * 0.5f;
		}
	}

	public void \u02BE\u02BA\u02BE\u02B8\u02BB\u02BB\u02B7\u02BE\u02B4\u02BC\u02BC(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public void \u02B7\u02B6\u02B6\u02BA\u02B7\u02C0\u02BA\u02B6\u02B8\u02B9\u02B9(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public void \u02C1\u02BD\u02B2\u02B2\u02C0\u02BF\u02B4\u02B4\u02B9\u02B3\u02BC(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public void \u02B6\u02C1\u02B9\u02B7\u02B5\u02BE\u02B8\u02BC\u02BC\u02C1\u02BB(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public void \u02BF\u02BC\u02B3\u02B7\u02BB\u02BF\u02BD\u02C1\u02B9\u02BF\u02BB()
	{
		this.\u02C1\u02BC\u02B4\u02C1\u02B5\u02B8\u02C1\u02B9\u02BB\u02BE\u02B6.SetTrigger("StarPowerEnabled");
		this.\u02B4\u02C1\u02B9\u02B3\u02BE\u02B3\u02B2\u02BD\u02B5\u02BB\u02BB.SetTrigger("StarPowerEnabled");
	}

	private void Update()
	{
	}

	void \u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7.\u02B8\u02B9\u02C0\u02B7\u02C0\u02B6\u02C1\u02BA\u02BF\u02B8\u02B8(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6 = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public global::UnityEngine.Animator \u02C1\u02BC\u02B4\u02C1\u02B5\u02B8\u02C1\u02B9\u02BB\u02BE\u02B6;

	public global::UnityEngine.Animator \u02B4\u02C1\u02B9\u02B3\u02BE\u02B3\u02B2\u02BD\u02B5\u02BB\u02BB;

	public AnimatorColorBehavior[] \u02BC\u02B3\u02BB\u02B2\u02BA\u02B8\u02BA\u02BD\u02B6\u02BE\u02B4;

	public AnimatorColorBehavior[] \u02B7\u02B3\u02B8\u02BE\u02BD\u02BB\u02B8\u02BC\u02BB\u02B5\u02B8;

	public SpriteRenderer \u02B3\u02BE\u02B8\u02BC\u02B3\u02BD\u02BA\u02B9\u02B5\u02BB\u02B5;

	public SpriteRenderer[] \u02BA\u02BE\u02B8\u02B5\u02B9\u02BA\u02C0\u02C0\u02C0\u02BA\u02BC;

	public SpriteRenderer[] breathingRenderers;

	private float ticker;

	private bool wasEnabledLastFrame;
}
