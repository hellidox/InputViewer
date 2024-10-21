﻿using System;
using System.Collections.Generic;
using System.Linq;
using Cysharp.Text;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

// Token: 0x02000173 RID: 371
public class LyricDisplay : MonoBehaviour
{
	// Token: 0x060010D7 RID: 4311 RVA: 0x0008ADE0 File Offset: 0x00088FE0
	public void \u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC(GameManager \u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD)
	{
		this.Reset();
		this.\u02BC\u02B8\u02C0\u02B9\u02B2\u02B3\u02B4\u02BC\u02BC\u02BF\u02B4 = SettingsController.\u02B2\u02C1\u02BD\u02C1\u02B4\u02B4\u02B2\u02BA\u02B6\u02B8\u02B4;
		if (!SettingsController.\u02BD\u02B3\u02B7\u02B5\u02B5\u02BD\u02B5\u02B8\u02BD\u02C1\u02C1)
		{
			return;
		}
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = \u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD;
		this.\u02B7\u02B8\u02BC\u02C0\u02B9\u02C1\u02B3\u02C1\u02BD\u02C1\u02B9();
		this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02BC\u02B2\u02B7\u02B8\u02B4\u02B5\u02B8\u02B3\u02B8\u02B7\u02B7(this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD);
		if (this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB == null || this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count == 0)
		{
			this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD = -1;
			return;
		}
		this.\u02B4\u02B9\u02B8\u02BF\u02B5\u02BC\u02B8\u02BE\u02BB\u02B8\u02BD();
		uint[] array = this.\u02B7\u02BF\u02B4\u02B6\u02B9\u02B3\u02B7\u02B3\u02BB\u02BB\u02C0().Distinct<uint>().ToArray<uint>();
		List<TMP_FontAsset> list = new List<TMP_FontAsset>();
		foreach (Font font in this.fonts)
		{
			list.Add(this.\u02B9\u02BF\u02B4\u02B2\u02B5\u02C1\u02BC\u02B6\u02C1\u02B6\u02BD(font, array, out array));
			if (array == null)
			{
				break;
			}
		}
		this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3 = list[0];
		if (this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3.fallbackFontAssetTable == null)
		{
			this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3.fallbackFontAssetTable = new List<TMP_FontAsset>(list.Count - 1);
		}
		for (int j = 1; j < list.Count; j++)
		{
			this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3.fallbackFontAssetTable.Add(list[j]);
		}
		this.currentPhraseDisplay.font = this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3;
		this.nextPhraseDisplay.font = this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3;
		this.fadePhraseDisplay.font = this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3;
		this.currentPhraseDisplay.UpdateFontAsset();
		this.nextPhraseDisplay.UpdateFontAsset();
		this.fadePhraseDisplay.UpdateFontAsset();
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x0008AF50 File Offset: 0x00089150
	private void \u02B7\u02B8\u02BC\u02C0\u02B9\u02C1\u02B3\u02C1\u02BD\u02C1\u02B9()
	{
		if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD > 2)
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.Count; i++)
		{
			if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i] != null && this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && !this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4 && this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].playerInfo.isAccuracyDisplay)
			{
				flag = true;
				break;
			}
		}
		if (flag && this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 == GameMode.Versus)
		{
			base.gameObject.GetComponent<RectTransform>().localPosition = new Vector3(0f, 130f, 0f);
		}
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x0008B050 File Offset: 0x00089250
	public void \u02BD\u02B9\u02BF\u02BC\u02B8\u02C1\u02BA\u02BA\u02B2\u02B6\u02BB(TMP_FontAsset \u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0)
	{
		Material material = new Material(Shader.Find("Video Offset"));
		material.CopyPropertiesFromMaterial(this.fontMaterial);
		material.SetTexture(ShaderUtilities.ID_MainTex, \u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.atlasTexture);
		material.SetFloat(ShaderUtilities.ID_TextureWidth, (float)\u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.atlasWidth);
		material.SetFloat(ShaderUtilities.ID_TextureHeight, (float)\u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.atlasHeight);
		material.SetFloat(ShaderUtilities.ID_GradientScale, (float)(\u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.atlasPadding + 1));
		material.SetFloat(ShaderUtilities.ID_WeightNormal, \u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.normalStyle);
		material.SetFloat(ShaderUtilities.ID_WeightBold, \u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.boldStyle);
		\u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.material = material;
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x0008B0EC File Offset: 0x000892EC
	private TMP_FontAsset \u02BA\u02BD\u02B8\u02B5\u02BB\u02B6\u02B8\u02B8\u02B7\u02BA\u02B2(Font \u02BF\u02B2\u02C0\u02C0\u02BA\u02BF\u02B4\u02BF\u02C1\u02B9\u02B7, uint[] \u02BC\u02B9\u02B3\u02B6\u02BF\u02BA\u02BD\u02BA\u02BE\u02B2\u02B6, out uint[] \u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5)
	{
		TMP_FontAsset tmp_FontAsset = TMP_FontAsset.CreateFontAsset(\u02BF\u02B2\u02C0\u02C0\u02BA\u02BF\u02B4\u02BF\u02C1\u02B9\u02B7, 24, 29, (GlyphRenderMode)(-121), -119, 67, AtlasPopulationMode.Static, false);
		uint[] array;
		tmp_FontAsset.TryAddCharacters(\u02BC\u02B9\u02B3\u02B6\u02BF\u02BA\u02BD\u02BA\u02BE\u02B2\u02B6, out array, false);
		if (array == null && \u02BC\u02B9\u02B3\u02B6\u02BF\u02BA\u02BD\u02BA\u02BE\u02B2\u02B6.Length != tmp_FontAsset.characterTable.Count)
		{
			Debug.Log("song");
			HashSet<uint> hashSet = new HashSet<uint>();
			HashSet<uint> hashSet2 = new HashSet<uint>(\u02BC\u02B9\u02B3\u02B6\u02BF\u02BA\u02BD\u02BA\u02BE\u02B2\u02B6);
			foreach (TMP_Character tmp_Character in tmp_FontAsset.characterTable)
			{
				hashSet.Add(tmp_Character.unicode);
			}
			hashSet2.ExceptWith(hashSet);
			\u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5 = hashSet2.ToArray<uint>();
		}
		else
		{
			Debug.Log("charter");
			\u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5 = array;
		}
		if (\u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5 != null && \u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5.Length != 0)
		{
			Debug.Log("" + __FIXME_clon_util.\u02B4\u02B3\u02B9\u02B6\u02BC\u02B7\u02BC\u02BA\u02B3\u02BB\u02B6(\u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5));
		}
		this.\u02B2\u02B7\u02BB\u02B5\u02BB\u02B3\u02BF\u02B3\u02BE\u02B2\u02B9(tmp_FontAsset);
		tmp_FontAsset.atlasPopulationMode = AtlasPopulationMode.Dynamic;
		return tmp_FontAsset;
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x0008B1E8 File Offset: 0x000893E8
	private void \u02BB\u02B5\u02BA\u02BB\u02BF\u02B9\u02BE\u02B9\u02BB\u02B8\u02BF(double \u02BF\u02B4\u02B3\u02BF\u02BB\u02B4\u02B9\u02BD\u02B3\u02B9\u02B7)
	{
		for (int i = 1; i < this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count; i++)
		{
			if (this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC >= \u02BF\u02B4\u02B3\u02BF\u02BB\u02B4\u02B9\u02BD\u02B3\u02B9\u02B7)
			{
				this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 = i - 0;
				this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD = i;
				return;
			}
		}
		this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count - 0;
		this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 = this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD - 1;
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x0008B254 File Offset: 0x00089454
	private void \u02BE\u02BD\u02BC\u02B4\u02B7\u02BA\u02C0\u02C0\u02BF\u02B6\u02BF()
	{
		if (this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC || this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 == 0)
		{
			this.currentPhraseDisplay.text = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02BE\u02B9\u02BC\u02B6\u02BD\u02C0\u02B6\u02B7\u02BB\u02B4\u02B6;
			this.currentPhraseAnimator.\u02BE\u02B8\u02BD\u02B4\u02B4\u02C1\u02C0\u02BB\u02B5\u02BC\u02B7();
			this.currentPhraseAnimator.\u02C1\u02BB\u02B8\u02B6\u02B3\u02B2\u02C0\u02B8\u02BF\u02BD\u02BF(0f, 1f);
			this.currentPhraseAnimator.\u02B6\u02B5\u02B2\u02B9\u02C1\u02B6\u02B7\u02BE\u02B3\u02BA\u02B4(0.5f);
			this.currentPhraseBgFader.\u02C0\u02B9\u02BE\u02BC\u02C1\u02C1\u02C0\u02B3\u02B2\u02C0\u02BD(this.currentPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, this.currentPhraseBgFader.\u02BC\u02BC\u02BE\u02C1\u02C1\u02B9\u02BE\u02BA\u02B6\u02B7\u02B9, 0.5f);
			return;
		}
		this.currentPhraseDisplay.text = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02BE\u02B9\u02BC\u02B6\u02BD\u02C0\u02B6\u02B7\u02BB\u02B4\u02B6;
		this.currentPhraseAnimator.\u02BE\u02B8\u02BD\u02B4\u02B4\u02C1\u02C0\u02BB\u02B5\u02BC\u02B7();
		this.currentPhraseAnimator.\u02C1\u02BB\u02B8\u02B6\u02B3\u02B2\u02C0\u02B8\u02BF\u02BD\u02BF(0.5f, 1f);
		this.currentPhraseAnimator.\u02BE\u02B3\u02B9\u02B8\u02C0\u02BC\u02BC\u02C1\u02BA\u02BA\u02C1(this.\u02BC\u02BB\u02B7\u02B3\u02BE\u02BA\u02BC\u02C0\u02BF\u02B4\u02B6, this.\u02B8\u02B8\u02B9\u02B2\u02C0\u02B8\u02B9\u02BA\u02C0\u02BA\u02B3);
		this.currentPhraseAnimator.\u02BE\u02B5\u02B9\u02BE\u02BF\u02C1\u02BE\u02BF\u02C0\u02B9\u02BE(0.5f, 1f, 2f);
		this.currentPhraseAnimator.\u02B6\u02B5\u02B2\u02B9\u02C1\u02B6\u02B7\u02BE\u02B3\u02BA\u02B4(this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA * 0.7f);
		this.currentPhraseBgFader.\u02C0\u02B9\u02BE\u02BC\u02C1\u02C1\u02C0\u02B3\u02B2\u02C0\u02BD(this.currentPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, this.currentPhraseBgFader.\u02BC\u02BC\u02BE\u02C1\u02C1\u02B9\u02BE\u02BA\u02B6\u02B7\u02B9, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA * 0.7f);
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x0008B3A0 File Offset: 0x000895A0
	private void \u02B3\u02B3\u02BA\u02C0\u02BA\u02B5\u02BE\u02B8\u02B7\u02BD\u02B9()
	{
		this.\u02B5\u02BD\u02B8\u02B8\u02BF\u02BF\u02BA\u02B7\u02B2\u02B6\u02B2 = false;
		if (!this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC || this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 <= -1)
		{
			this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5++;
		}
		this.\u02B4\u02B9\u02B3\u02B7\u02BF\u02B7\u02BF\u02B5\u02BE\u02B4\u02B6 = 1;
		this.\u02C0\u02B5\u02BC\u02B5\u02BB\u02C0\u02BB\u02C0\u02B7\u02C1\u02B8();
		this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC = true;
		if (this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD < this.\u02BA\u02B6\u02BF\u02BB\u02BF\u02C0\u02C1\u02BB\u02B4\u02C0\u02BF)
		{
			this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD += 0;
			double num = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 - this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC;
			double u02B2_u02B6_u02B9_u02B8_u02BF_u02BD_u02BF_u02BA_u02B9_u02C1_u02B = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0.Count - 0].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5;
			double u02B2_u02B6_u02B9_u02B8_u02BF_u02BD_u02BF_u02BA_u02B9_u02C1_u02B2 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[1].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5;
			double num2 = (this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC - u02B2_u02B6_u02B9_u02B8_u02BF_u02BD_u02BF_u02BA_u02B9_u02C1_u02B) * 1768.0;
			double num3 = (u02B2_u02B6_u02B9_u02B8_u02BF_u02BD_u02BF_u02BA_u02B9_u02C1_u02B2 - this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5) * 946.0;
			double num4 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC - num2;
			double num5 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 + num3;
			double num6 = num5 - this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC;
			double num7 = num5 - num4;
			if (num6 >= 1445.0)
			{
				this.\u02B5\u02C0\u02B7\u02B2\u02BA\u02BB\u02BB\u02BE\u02B4\u02B9\u02B6 = 1012.0;
				this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA = 716f;
			}
			else if (num7 >= 502.0)
			{
				this.\u02B5\u02C0\u02B7\u02B2\u02BA\u02BB\u02BB\u02BE\u02B4\u02B9\u02B6 = 1318.0 - num6;
				this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA = 570f;
			}
			else if (num7 < 818.0)
			{
				this.\u02B5\u02C0\u02B7\u02B2\u02BA\u02BB\u02BB\u02BE\u02B4\u02B9\u02B6 = num2;
				this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA = (float)num7;
			}
			if (num < 855.0)
			{
				this.nextPhraseDisplay.text = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02BE\u02B9\u02BC\u02B6\u02BD\u02C0\u02B6\u02B7\u02BB\u02B4\u02B6;
				this.nextPhraseAnimator.\u02BD\u02C0\u02BF\u02BA\u02BA\u02B3\u02B5\u02BE\u02C1\u02B5\u02B6();
				this.nextPhraseAnimator.\u02C1\u02BB\u02B8\u02B6\u02B3\u02B2\u02C0\u02B8\u02BF\u02BD\u02BF(447f, 1964f);
				this.nextPhraseAnimator.\u02B6\u02B5\u02B2\u02B9\u02C1\u02B6\u02B7\u02BE\u02B3\u02BA\u02B4(this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
				this.nextPhraseBgFader.\u02C1\u02BC\u02B6\u02BC\u02BF\u02B2\u02C1\u02B2\u02B9\u02BB\u02B4(this.nextPhraseBgFader.\u02BF\u02BE\u02B2\u02B9\u02BB\u02B3\u02B8\u02B2\u02BA\u02B8\u02C0(), this.nextPhraseBgFader.\u02B6\u02C1\u02B3\u02BD\u02B7\u02BD\u02BA\u02B5\u02C1\u02C1\u02B2(), this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
			}
			else
			{
				this.nextPhraseDisplay.text = null;
				this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC = true;
				this.nextPhraseBgFader.\u02C1\u02BC\u02B6\u02BC\u02BF\u02B2\u02C1\u02B2\u02B9\u02BB\u02B4(this.nextPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, 218f, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
			}
		}
		else
		{
			this.nextPhraseDisplay.text = null;
			this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD = -1;
			this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC = false;
			this.nextPhraseBgFader.\u02BE\u02BC\u02B8\u02B4\u02BE\u02B4\u02BF\u02BD\u02B9\u02B8\u02B6(this.nextPhraseBgFader.\u02BF\u02BE\u02B2\u02B9\u02BB\u02B3\u02B8\u02B2\u02BA\u02B8\u02C0(), 1263f, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
		}
		if (this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 != -1)
		{
			this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5];
		}
		else
		{
			this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC = null;
		}
		if (this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD != -1)
		{
			this.\u02BF\u02B6\u02B5\u02B6\u02BE\u02B9\u02BC\u02B3\u02BB\u02BD\u02B2 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD];
			return;
		}
		this.\u02BF\u02B6\u02B5\u02B6\u02BE\u02B9\u02BC\u02B3\u02BB\u02BD\u02B2 = null;
		this.nextPhraseBgFader.\u02BE\u02BC\u02B8\u02B4\u02BE\u02B4\u02BF\u02BD\u02B9\u02B8\u02B6(this.nextPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, 1385f, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x0008B704 File Offset: 0x00089904
	public void Reset()
	{
		this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC = false;
		this.\u02B5\u02BD\u02B8\u02B8\u02BF\u02BF\u02BA\u02B7\u02B2\u02B6\u02B2 = false;
		this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA = 0.2f;
		this.\u02B5\u02C0\u02B7\u02B2\u02BA\u02BB\u02BB\u02BE\u02B4\u02B9\u02B6 = 0.0;
		this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 = -1;
		this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD = 0;
		this.\u02B4\u02B9\u02B3\u02B7\u02BF\u02B7\u02BF\u02B5\u02BE\u02B4\u02B6 = 0;
		this.currentPhraseDisplay.alpha = 0f;
		this.nextPhraseDisplay.alpha = 0f;
		this.currentPhraseDisplay.text = null;
		this.nextPhraseDisplay.text = null;
		this.fadePhraseDisplay.text = null;
		this.currentPhraseBgFader.\u02C1\u02BC\u02B8\u02C0\u02BA\u02B9\u02BD\u02B9\u02BB\u02BA\u02B8(0f);
		this.nextPhraseBgFader.\u02C1\u02BC\u02B8\u02C0\u02BA\u02B9\u02BD\u02B9\u02BB\u02BA\u02B8(0f);
		this.nextPhraseBgFader.\u02B9\u02BA\u02C1\u02B7\u02BC\u02B5\u02B9\u02B9\u02BC\u02B9\u02BB();
		this.currentPhraseBgFader.\u02B9\u02BA\u02C1\u02B7\u02BC\u02B5\u02B9\u02B9\u02BC\u02B9\u02BB();
		this.fadeAnimator.\u02B5\u02B8\u02B3\u02BD\u02B3\u02B5\u02BD\u02B9\u02B8\u02B5\u02BB();
		this.currentPhraseAnimator.\u02B5\u02B8\u02B3\u02BD\u02B3\u02B5\u02BD\u02B9\u02B8\u02B5\u02BB();
		this.nextPhraseAnimator.\u02B5\u02B8\u02B3\u02BD\u02B3\u02B5\u02BD\u02B9\u02B8\u02B5\u02BB();
		this.\u02BF\u02B3\u02B9\u02B9\u02BD\u02BC\u02B9\u02B7\u02C1\u02C0\u02BD = 0.35f;
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x0008B92C File Offset: 0x00089B2C
	private TMP_FontAsset \u02B9\u02BF\u02B4\u02B2\u02B5\u02C1\u02BC\u02B6\u02C1\u02B6\u02BD(Font \u02BF\u02B2\u02C0\u02C0\u02BA\u02BF\u02B4\u02BF\u02C1\u02B9\u02B7, uint[] \u02BC\u02B9\u02B3\u02B6\u02BF\u02BA\u02BD\u02BA\u02BE\u02B2\u02B6, out uint[] \u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5)
	{
		TMP_FontAsset tmp_FontAsset = TMP_FontAsset.CreateFontAsset(\u02BF\u02B2\u02C0\u02C0\u02BA\u02BF\u02B4\u02BF\u02C1\u02B9\u02B7, 90, 9, GlyphRenderMode.SDFAA, 1024, 1024, AtlasPopulationMode.Dynamic, true);
		uint[] array;
		tmp_FontAsset.TryAddCharacters(\u02BC\u02B9\u02B3\u02B6\u02BF\u02BA\u02BD\u02BA\u02BE\u02B2\u02B6, out array, false);
		if (array == null && \u02BC\u02B9\u02B3\u02B6\u02BF\u02BA\u02BD\u02BA\u02BE\u02B2\u02B6.Length != tmp_FontAsset.characterTable.Count)
		{
			Debug.Log("Returned missing glyphs are incorrect.");
			HashSet<uint> hashSet = new HashSet<uint>();
			HashSet<uint> hashSet2 = new HashSet<uint>(\u02BC\u02B9\u02B3\u02B6\u02BF\u02BA\u02BD\u02BA\u02BE\u02B2\u02B6);
			foreach (TMP_Character tmp_Character in tmp_FontAsset.characterTable)
			{
				hashSet.Add(tmp_Character.unicode);
			}
			hashSet2.ExceptWith(hashSet);
			\u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5 = hashSet2.ToArray<uint>();
		}
		else
		{
			Debug.Log("Returned missing glyphs are correct.");
			\u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5 = array;
		}
		if (\u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5 != null && \u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5.Length != 0)
		{
			Debug.Log("Characters not supported by font: " + __FIXME_clon_util.\u02B4\u02B3\u02B9\u02B6\u02BC\u02B7\u02BC\u02BA\u02B3\u02BB\u02B6(\u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5));
		}
		this.\u02B2\u02B7\u02BB\u02B5\u02BB\u02B3\u02BF\u02B3\u02BE\u02B2\u02B9(tmp_FontAsset);
		tmp_FontAsset.atlasPopulationMode = AtlasPopulationMode.Static;
		return tmp_FontAsset;
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x0008BA28 File Offset: 0x00089C28
	private void \u02BF\u02B5\u02BD\u02BB\u02C0\u02B6\u02B4\u02BD\u02C0\u02B6\u02BC()
	{
		this.fadePhraseDisplay.text = this.currentPhraseDisplay.text;
		this.currentPhraseDisplay.text = null;
		this.fadeAnimator.\u02BE\u02B8\u02BD\u02B4\u02B4\u02C1\u02C0\u02BB\u02B5\u02BC\u02B7();
		this.fadeAnimator.\u02C1\u02BB\u02B8\u02B6\u02B3\u02B2\u02C0\u02B8\u02BF\u02BD\u02BF(1f, 0f);
		this.fadeAnimator.\u02BE\u02B3\u02B9\u02B8\u02C0\u02BC\u02BC\u02C1\u02BA\u02BA\u02C1(this.\u02B8\u02B8\u02B9\u02B2\u02C0\u02B8\u02B9\u02BA\u02C0\u02BA\u02B3, this.\u02B6\u02B7\u02C1\u02C1\u02B7\u02BE\u02C0\u02BE\u02B5\u02B6\u02BB);
		this.fadeAnimator.\u02B6\u02B5\u02B2\u02B9\u02C1\u02B6\u02B7\u02BE\u02B3\u02BA\u02B4(this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA * 0.5f);
		this.currentPhraseBgFader.\u02C0\u02B9\u02BE\u02BC\u02C1\u02C1\u02C0\u02B3\u02B2\u02C0\u02BD(this.currentPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, this.currentPhraseBgFader.\u02BC\u02BC\u02BE\u02C1\u02C1\u02B9\u02BE\u02BA\u02B6\u02B7\u02B9, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA * 0.5f);
		this.nextPhraseBgFader.\u02C0\u02B9\u02BE\u02BC\u02C1\u02C1\u02C0\u02B3\u02B2\u02C0\u02BD(this.nextPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, 0f, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x0008BAF4 File Offset: 0x00089CF4
	private void Update()
	{
		if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD == null || this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count == 0)
		{
			return;
		}
		if (this.\u02BF\u02B3\u02B9\u02B9\u02BD\u02BC\u02B9\u02B7\u02C1\u02C0\u02BD > 0f)
		{
			this.\u02BF\u02B3\u02B9\u02B9\u02BD\u02BC\u02B9\u02B7\u02C1\u02C0\u02BD -= Time.deltaTime;
			return;
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 && this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 == -1)
		{
			this.\u02BC\u02BD\u02BD\u02B6\u02C0\u02B5\u02B7\u02B2\u02B9\u02BC\u02B6(this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB);
			this.\u02B5\u02B4\u02B7\u02BB\u02B4\u02BE\u02BA\u02BE\u02B9\u02BF\u02B5();
		}
		if ((this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 == -1 || this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC) && this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD != -1 && this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB >= this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 - 0.5)
		{
			this.\u02B5\u02B4\u02B7\u02BB\u02B4\u02BE\u02BA\u02BE\u02B9\u02BF\u02B5();
		}
		if (this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 >= 0 && this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 <= this.\u02BA\u02B6\u02BF\u02BB\u02BF\u02C0\u02C1\u02BB\u02B4\u02C0\u02BF && this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC != null)
		{
			if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB >= this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC.\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC - this.\u02B5\u02C0\u02B7\u02B2\u02BA\u02BB\u02BB\u02BE\u02B4\u02B9\u02B6)
			{
				if (this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC && !this.\u02B5\u02BD\u02B8\u02B8\u02BF\u02BF\u02BA\u02B7\u02B2\u02B6\u02B2)
				{
					this.currentPhraseAnimator.\u02BE\u02B8\u02BD\u02B4\u02B4\u02C1\u02C0\u02BB\u02B5\u02BC\u02B7();
					this.currentPhraseAnimator.\u02C1\u02BB\u02B8\u02B6\u02B3\u02B2\u02C0\u02B8\u02BF\u02BD\u02BF(1f, 0f);
					this.currentPhraseAnimator.\u02B6\u02B5\u02B2\u02B9\u02C1\u02B6\u02B7\u02BE\u02B3\u02BA\u02B4(0.4f);
					this.currentPhraseBgFader.\u02C0\u02B9\u02BE\u02BC\u02C1\u02C1\u02C0\u02B3\u02B2\u02C0\u02BD(this.currentPhraseBgFader.\u02BC\u02BC\u02BE\u02C1\u02C1\u02B9\u02BE\u02BA\u02B6\u02B7\u02B9, 0f, 0.4f);
					if (this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 + 1 <= this.\u02BA\u02B6\u02BF\u02BB\u02BF\u02C0\u02C1\u02BB\u02B4\u02C0\u02BF)
					{
						this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5++;
						this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5];
					}
					this.\u02B5\u02BD\u02B8\u02B8\u02BF\u02BF\u02BA\u02B7\u02B2\u02B6\u02B2 = true;
				}
				else if (this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD != -1)
				{
					this.\u02BF\u02B5\u02BD\u02BB\u02C0\u02B6\u02B4\u02BD\u02C0\u02B6\u02BC();
					this.\u02B5\u02B4\u02B7\u02BB\u02B4\u02BE\u02BA\u02BE\u02B9\u02BF\u02B5();
				}
			}
			else if (this.\u02B4\u02B9\u02B3\u02B7\u02BF\u02B7\u02BF\u02B5\u02BE\u02B4\u02B6 < this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0.Count && this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB >= this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC.\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[this.\u02B4\u02B9\u02B3\u02B7\u02BF\u02B7\u02BF\u02B5\u02BE\u02B4\u02B6].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
			{
				\u02C1\u02B5\u02B4\u02C0\u02BD\u02B7\u02B7\u02BA\u02B3\u02BD\u02C0 u02C1_u02B5_u02B4_u02C0_u02BD_u02B7_u02B7_u02BA_u02B3_u02BD_u02C = this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC.\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[this.\u02B4\u02B9\u02B3\u02B7\u02BF\u02B7\u02BF\u02B5\u02BE\u02B4\u02B6];
				using (Utf16ValueStringBuilder utf16ValueStringBuilder = ZString.CreateStringBuilder())
				{
					utf16ValueStringBuilder.Append(this.\u02C0\u02B5\u02BB\u02B6\u02BC\u02B5\u02BD\u02BA\u02B8\u02BC\u02B8);
					foreach (\u02C1\u02B5\u02B4\u02C0\u02BD\u02B7\u02B7\u02BA\u02B3\u02BD\u02C0 u02C1_u02B5_u02B4_u02C0_u02BD_u02B7_u02B7_u02BA_u02B3_u02BD_u02C2 in this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC.\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0)
					{
						utf16ValueStringBuilder.Append(u02C1_u02B5_u02B4_u02C0_u02BD_u02B7_u02B7_u02BA_u02B3_u02BD_u02C2.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF);
						if (u02C1_u02B5_u02B4_u02C0_u02BD_u02B7_u02B7_u02BA_u02B3_u02BD_u02C == u02C1_u02B5_u02B4_u02C0_u02BD_u02B7_u02B7_u02BA_u02B3_u02BD_u02C2)
						{
							utf16ValueStringBuilder.Append(this.\u02BD\u02BC\u02BB\u02B3\u02BF\u02C0\u02BF\u02B7\u02B3\u02C0\u02B7);
						}
					}
					this.currentPhraseDisplay.\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(utf16ValueStringBuilder);
				}
				this.\u02B4\u02B9\u02B3\u02B7\u02BF\u02B7\u02BF\u02B5\u02BE\u02B4\u02B6++;
			}
		}
		this.currentPhraseAnimator.\u02BF\u02B3\u02B6\u02B4\u02B4\u02BF\u02B4\u02B6\u02B8\u02B9\u02BE();
		this.nextPhraseAnimator.\u02BF\u02B3\u02B6\u02B4\u02B4\u02BF\u02B4\u02B6\u02B8\u02B9\u02BE();
		this.fadeAnimator.\u02BF\u02B3\u02B6\u02B4\u02B4\u02BF\u02B4\u02B6\u02B8\u02B9\u02BE();
		if (this.\u02BC\u02B8\u02C0\u02B9\u02B2\u02B3\u02B4\u02BC\u02BC\u02BF\u02B4)
		{
			this.currentPhraseBgFader.\u02BB\u02B6\u02B9\u02B8\u02B6\u02B3\u02BD\u02C0\u02B4\u02BE\u02B2();
			this.nextPhraseBgFader.\u02BB\u02B6\u02B9\u02B8\u02B6\u02B3\u02BD\u02C0\u02B4\u02BE\u02B2();
		}
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x0008BE18 File Offset: 0x0008A018
	private void \u02B5\u02B4\u02B7\u02BB\u02B4\u02BE\u02BA\u02BE\u02B9\u02BF\u02B5()
	{
		this.\u02B5\u02BD\u02B8\u02B8\u02BF\u02BF\u02BA\u02B7\u02B2\u02B6\u02B2 = false;
		if (!this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC || this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 <= -1)
		{
			this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5++;
		}
		this.\u02B4\u02B9\u02B3\u02B7\u02BF\u02B7\u02BF\u02B5\u02BE\u02B4\u02B6 = 0;
		this.\u02BE\u02BD\u02BC\u02B4\u02B7\u02BA\u02C0\u02C0\u02BF\u02B6\u02BF();
		this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC = false;
		if (this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD < this.\u02BA\u02B6\u02BF\u02BB\u02BF\u02C0\u02C1\u02BB\u02B4\u02C0\u02BF)
		{
			this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD++;
			double num = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 - this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC;
			double u02B2_u02B6_u02B9_u02B8_u02BF_u02BD_u02BF_u02BA_u02B9_u02C1_u02B = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0.Count - 1].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5;
			double u02B2_u02B6_u02B9_u02B8_u02BF_u02BD_u02BF_u02BA_u02B9_u02C1_u02B2 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[0].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5;
			double num2 = (this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC - u02B2_u02B6_u02B9_u02B8_u02BF_u02BD_u02BF_u02BA_u02B9_u02C1_u02B) * 0.699999988079071;
			double num3 = (u02B2_u02B6_u02B9_u02B8_u02BF_u02BD_u02BF_u02BA_u02B9_u02C1_u02B2 - this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5) * 0.8500000238418579;
			double num4 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC - num2;
			double num5 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 + num3;
			double num6 = num5 - this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC;
			double num7 = num5 - num4;
			if (num6 >= 0.4000000059604645)
			{
				this.\u02B5\u02C0\u02B7\u02B2\u02BA\u02BB\u02BB\u02BE\u02B4\u02B9\u02B6 = 0.0;
				this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA = 0.4f;
			}
			else if (num7 >= 0.4000000059604645)
			{
				this.\u02B5\u02C0\u02B7\u02B2\u02BA\u02BB\u02BB\u02BE\u02B4\u02B9\u02B6 = 0.4000000059604645 - num6;
				this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA = 0.4f;
			}
			else if (num7 < 0.4000000059604645)
			{
				this.\u02B5\u02C0\u02B7\u02B2\u02BA\u02BB\u02BB\u02BE\u02B4\u02B9\u02B6 = num2;
				this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA = (float)num7;
			}
			if (num < 2.5)
			{
				this.nextPhraseDisplay.text = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02BE\u02B9\u02BC\u02B6\u02BD\u02C0\u02B6\u02B7\u02BB\u02B4\u02B6;
				this.nextPhraseAnimator.\u02BE\u02B8\u02BD\u02B4\u02B4\u02C1\u02C0\u02BB\u02B5\u02BC\u02B7();
				this.nextPhraseAnimator.\u02C1\u02BB\u02B8\u02B6\u02B3\u02B2\u02C0\u02B8\u02BF\u02BD\u02BF(0f, 0.5f);
				this.nextPhraseAnimator.\u02B6\u02B5\u02B2\u02B9\u02C1\u02B6\u02B7\u02BE\u02B3\u02BA\u02B4(this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
				this.nextPhraseBgFader.\u02C0\u02B9\u02BE\u02BC\u02C1\u02C1\u02C0\u02B3\u02B2\u02C0\u02BD(this.nextPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, this.nextPhraseBgFader.\u02BC\u02BC\u02BE\u02C1\u02C1\u02B9\u02BE\u02BA\u02B6\u02B7\u02B9, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
			}
			else
			{
				this.nextPhraseDisplay.text = null;
				this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC = true;
				this.nextPhraseBgFader.\u02C0\u02B9\u02BE\u02BC\u02C1\u02C1\u02C0\u02B3\u02B2\u02C0\u02BD(this.nextPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, 0f, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
			}
		}
		else
		{
			this.nextPhraseDisplay.text = null;
			this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD = -1;
			this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC = true;
			this.nextPhraseBgFader.\u02C0\u02B9\u02BE\u02BC\u02C1\u02C1\u02C0\u02B3\u02B2\u02C0\u02BD(this.nextPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, 0f, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
		}
		if (this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 != -1)
		{
			this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5];
		}
		else
		{
			this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC = null;
		}
		if (this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD != -1)
		{
			this.\u02BF\u02B6\u02B5\u02B6\u02BE\u02B9\u02BC\u02B3\u02BB\u02BD\u02B2 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD];
			return;
		}
		this.\u02BF\u02B6\u02B5\u02B6\u02BE\u02B9\u02BC\u02B3\u02BB\u02BD\u02B2 = null;
		this.nextPhraseBgFader.\u02C0\u02B9\u02BE\u02BC\u02C1\u02C1\u02C0\u02B3\u02B2\u02C0\u02BD(this.nextPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, 0f, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x0008C17C File Offset: 0x0008A37C
	private void \u02B4\u02B9\u02B8\u02BF\u02B5\u02BC\u02B8\u02BE\u02BB\u02B8\u02BD()
	{
		for (int i = 0; i < this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count; i++)
		{
			using (Utf16ValueStringBuilder utf16ValueStringBuilder = ZString.CreateStringBuilder())
			{
				int num = -1;
				for (int j = 0; j < this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0.Count; j++)
				{
					string text = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[j].\u02BB\u02C0\u02C1\u02BC\u02B4\u02B4\u02B3\u02B9\u02B4\u02BD\u02BD;
					using (Utf16ValueStringBuilder utf16ValueStringBuilder2 = ZString.CreateStringBuilder())
					{
						if (text[0] != '+')
						{
							string text2 = string.Empty;
							if (num >= 0)
							{
								text2 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[num].\u02BB\u02C0\u02C1\u02BC\u02B4\u02B4\u02B3\u02B9\u02B4\u02BD\u02BD;
							}
							if (!text2.Contains("-") && !text2.EndsWith("="))
							{
								utf16ValueStringBuilder2.Append(' ');
							}
							if (text.Contains("-") || text.EndsWith("="))
							{
								num = j;
							}
							else
							{
								num = -1;
							}
						}
						else if (j > 0 && text.Length > 0 && text[0] == '+' && text.Contains("-"))
						{
							num = j;
						}
						bool flag = false;
						int num2 = 0;
						int num3 = 0;
						for (int k = 0; k < text.Length; k++)
						{
							if (flag)
							{
								string text3 = string.Empty;
								if (text[num2 + 1] == '/')
								{
									text3 = text.Substring(num2 + 2, num3 - num2 - 2);
								}
								else
								{
									text3 = text.Substring(num2 + 1, num3 - num2 - 1);
								}
								int num4 = text3.IndexOf("=");
								if (num4 > 0)
								{
									text3 = text3.Substring(0, num4);
								}
								if (this.\u02B5\u02BD\u02B6\u02BF\u02C0\u02B8\u02BC\u02BF\u02B2\u02B4\u02BE.Contains(text3))
								{
									utf16ValueStringBuilder2.Append(text.Substring(num2, num3 - num2 + 1));
									k = num3;
									flag = false;
								}
								else
								{
									k = num3;
									flag = false;
								}
							}
							else
							{
								char c = text[k];
								if (c <= '=')
								{
									switch (c)
									{
									case '#':
									case '$':
									case '%':
									case '*':
									case '+':
									case '-':
									case '/':
										goto IL_024E;
									case '&':
									case '\'':
									case '(':
									case ')':
									case ',':
									case '.':
										break;
									default:
										if (c != '<')
										{
											if (c == '=')
											{
												utf16ValueStringBuilder2.Append('-');
												goto IL_024E;
											}
										}
										else
										{
											num3 = text.IndexOf('>', k);
											if (num3 > k)
											{
												flag = true;
												num2 = k;
												goto IL_024E;
											}
											goto IL_024E;
										}
										break;
									}
								}
								else
								{
									if (c == '^')
									{
										goto IL_024E;
									}
									if (c == '_' || c == '§')
									{
										utf16ValueStringBuilder2.Append(' ');
										goto IL_024E;
									}
								}
								utf16ValueStringBuilder2.Append(text[k]);
							}
							IL_024E:;
						}
						text = utf16ValueStringBuilder2.ToString();
						this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[j].\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = text;
						utf16ValueStringBuilder.Append(text);
						this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[j].\u02BF\u02B7\u02B5\u02BA\u02BE\u02BD\u02B6\u02C1\u02BC\u02B3\u02B2 = utf16ValueStringBuilder.Length;
					}
				}
				this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02BE\u02B9\u02BC\u02B6\u02BD\u02C0\u02B6\u02B7\u02BB\u02B4\u02B6 = utf16ValueStringBuilder.ToString();
			}
		}
		this.\u02BA\u02B6\u02BF\u02BB\u02BF\u02C0\u02C1\u02BB\u02B4\u02C0\u02BF = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count - 1;
		this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 = -1;
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x0008C508 File Offset: 0x0008A708
	private void \u02C0\u02B5\u02BC\u02B5\u02BB\u02C0\u02BB\u02C0\u02B7\u02C1\u02B8()
	{
		if (this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC || this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 == 0)
		{
			this.currentPhraseDisplay.text = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02BE\u02B9\u02BC\u02B6\u02BD\u02C0\u02B6\u02B7\u02BB\u02B4\u02B6;
			this.currentPhraseAnimator.\u02BD\u02C0\u02BF\u02BA\u02BA\u02B3\u02B5\u02BE\u02C1\u02B5\u02B6();
			this.currentPhraseAnimator.\u02C1\u02BB\u02B8\u02B6\u02B3\u02B2\u02C0\u02B8\u02BF\u02BD\u02BF(1302f, 1845f);
			this.currentPhraseAnimator.\u02B6\u02B5\u02B2\u02B9\u02C1\u02B6\u02B7\u02BE\u02B3\u02BA\u02B4(1977f);
			this.currentPhraseBgFader.\u02BE\u02BC\u02B8\u02B4\u02BE\u02B4\u02BF\u02BD\u02B9\u02B8\u02B6(this.currentPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, this.currentPhraseBgFader.\u02BC\u02BC\u02BF\u02B4\u02B2\u02BE\u02BC\u02BB\u02B4\u02BE\u02B5(), 136f);
			return;
		}
		this.currentPhraseDisplay.text = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02BE\u02B9\u02BC\u02B6\u02BD\u02C0\u02B6\u02B7\u02BB\u02B4\u02B6;
		this.currentPhraseAnimator.\u02BD\u02C0\u02BF\u02BA\u02BA\u02B3\u02B5\u02BE\u02C1\u02B5\u02B6();
		this.currentPhraseAnimator.\u02C1\u02BB\u02B8\u02B6\u02B3\u02B2\u02C0\u02B8\u02BF\u02BD\u02BF(1518f, 1380f);
		this.currentPhraseAnimator.\u02BE\u02B3\u02B9\u02B8\u02C0\u02BC\u02BC\u02C1\u02BA\u02BA\u02C1(this.\u02BC\u02BB\u02B7\u02B3\u02BE\u02BA\u02BC\u02C0\u02BF\u02B4\u02B6, this.\u02B8\u02B8\u02B9\u02B2\u02C0\u02B8\u02B9\u02BA\u02C0\u02BA\u02B3);
		this.currentPhraseAnimator.\u02BE\u02B5\u02B9\u02BE\u02BF\u02C1\u02BE\u02BF\u02C0\u02B9\u02BE(318f, 1991f, 1584f);
		this.currentPhraseAnimator.\u02B6\u02B5\u02B2\u02B9\u02C1\u02B6\u02B7\u02BE\u02B3\u02BA\u02B4(this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA * 673f);
		this.currentPhraseBgFader.\u02BE\u02BC\u02B8\u02B4\u02BE\u02B4\u02BF\u02BD\u02B9\u02B8\u02B6(this.currentPhraseBgFader.\u02BF\u02BE\u02B2\u02B9\u02BB\u02B3\u02B8\u02B2\u02BA\u02B8\u02C0(), this.currentPhraseBgFader.\u02BC\u02BC\u02BE\u02C1\u02C1\u02B9\u02BE\u02BA\u02B6\u02B7\u02B9, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA * 1350f);
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x0008C654 File Offset: 0x0008A854
	private void \u02BC\u02BD\u02BD\u02B6\u02C0\u02B5\u02B7\u02B2\u02B9\u02BC\u02B6(double \u02BF\u02B4\u02B3\u02BF\u02BB\u02B4\u02B9\u02BD\u02B3\u02B9\u02B7)
	{
		for (int i = 0; i < this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count; i++)
		{
			if (this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC >= \u02BF\u02B4\u02B3\u02BF\u02BB\u02B4\u02B9\u02BD\u02B3\u02B9\u02B7)
			{
				this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 = i - 1;
				this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD = i;
				return;
			}
		}
		this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count - 1;
		this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 = this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD - 1;
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x0008C6C0 File Offset: 0x0008A8C0
	private void \u02B9\u02B8\u02B9\u02C0\u02B6\u02BC\u02C0\u02BB\u02B9\u02BF\u02B9()
	{
		this.fadePhraseDisplay.text = this.currentPhraseDisplay.text;
		this.currentPhraseDisplay.text = null;
		this.fadeAnimator.\u02BE\u02B8\u02BD\u02B4\u02B4\u02C1\u02C0\u02BB\u02B5\u02BC\u02B7();
		this.fadeAnimator.\u02C1\u02BB\u02B8\u02B6\u02B3\u02B2\u02C0\u02B8\u02BF\u02BD\u02BF(993f, 1271f);
		this.fadeAnimator.\u02BE\u02B3\u02B9\u02B8\u02C0\u02BC\u02BC\u02C1\u02BA\u02BA\u02C1(this.\u02B8\u02B8\u02B9\u02B2\u02C0\u02B8\u02B9\u02BA\u02C0\u02BA\u02B3, this.\u02B6\u02B7\u02C1\u02C1\u02B7\u02BE\u02C0\u02BE\u02B5\u02B6\u02BB);
		this.fadeAnimator.\u02B6\u02B5\u02B2\u02B9\u02C1\u02B6\u02B7\u02BE\u02B3\u02BA\u02B4(this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA * 1098f);
		this.currentPhraseBgFader.\u02BD\u02BB\u02B3\u02B4\u02B2\u02B6\u02B4\u02BB\u02C0\u02BA\u02C0(this.currentPhraseBgFader.\u02BF\u02BE\u02B2\u02B9\u02BB\u02B3\u02B8\u02B2\u02BA\u02B8\u02C0(), this.currentPhraseBgFader.\u02B6\u02C1\u02B3\u02BD\u02B7\u02BD\u02BA\u02B5\u02C1\u02C1\u02B2(), this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA * 787f);
		this.nextPhraseBgFader.\u02BD\u02BB\u02B3\u02B4\u02B2\u02B6\u02B4\u02BB\u02C0\u02BA\u02C0(this.nextPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, 1999f, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x0008C78C File Offset: 0x0008A98C
	private void \u02B8\u02B8\u02BF\u02B7\u02B4\u02C1\u02B5\u02BF\u02B5\u02BF\u02BE()
	{
		for (int i = 0; i < this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count; i += 0)
		{
			using (Utf16ValueStringBuilder utf16ValueStringBuilder = ZString.CreateStringBuilder())
			{
				int num = -1;
				for (int j = 0; j < this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0.Count; j++)
				{
					string text = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[j].\u02BB\u02C0\u02C1\u02BC\u02B4\u02B4\u02B3\u02B9\u02B4\u02BD\u02BD;
					using (Utf16ValueStringBuilder utf16ValueStringBuilder2 = ZString.CreateStringBuilder())
					{
						if ((int)text[1] != -122)
						{
							string text2 = string.Empty;
							if (num >= 0)
							{
								text2 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[num].\u02BB\u02C0\u02C1\u02BC\u02B4\u02B4\u02B3\u02B9\u02B4\u02BD\u02BD;
							}
							if (!text2.Contains("Join Server") && !text2.EndsWith("{0:N0}"))
							{
								utf16ValueStringBuilder2.Append((char)(-41));
							}
							if (text.Contains("servers") || text.EndsWith("whammy_sfx"))
							{
								num = j;
							}
							else
							{
								num = -1;
							}
						}
						else if (j > 0 && text.Length > 1 && (int)text[0] == -27 && text.Contains("PlayerData"))
						{
							num = j;
						}
						bool flag = true;
						int num2 = 1;
						int num3 = 0;
						for (int k = 0; k < text.Length; k++)
						{
							if (flag)
							{
								string text3 = string.Empty;
								if ((int)text[num2 + 0] == -52)
								{
									text3 = text.Substring(num2 + 1, num3 - num2 - 4);
								}
								else
								{
									text3 = text.Substring(num2 + 0, num3 - num2 - 0);
								}
								int num4 = text3.IndexOf("section ");
								if (num4 > 1)
								{
									text3 = text3.Substring(1, num4);
								}
								if (this.\u02B5\u02BD\u02B6\u02BF\u02C0\u02B8\u02BC\u02BF\u02B2\u02B4\u02BE.Contains(text3))
								{
									utf16ValueStringBuilder2.Append(text.Substring(num2, num3 - num2 + 0));
									k = num3;
									flag = true;
								}
								else
								{
									k = num3;
									flag = false;
								}
							}
							else
							{
								char c = text[k];
								if ((int)c <= -16)
								{
									switch (c)
									{
									case 'ﾷ':
									case 'ﾸ':
									case 'ﾹ':
									case 'ﾾ':
									case '\uffbf':
									case '\uffc1':
									case 'ￃ':
										goto IL_024E;
									case 'ﾺ':
									case 'ﾻ':
									case 'ﾼ':
									case 'ﾽ':
									case '\uffc0':
									case 'ￂ':
										break;
									default:
										if (c != '\u001a')
										{
											if (c == '\u0006')
											{
												utf16ValueStringBuilder2.Append('c');
												goto IL_024E;
											}
										}
										else
										{
											num3 = text.IndexOf('=', k);
											if (num3 > k)
											{
												flag = false;
												num2 = k;
												goto IL_024E;
											}
											goto IL_024E;
										}
										break;
									}
								}
								else
								{
									if (c == 'U')
									{
										goto IL_024E;
									}
									if (c == 'o' || (int)c == -194)
									{
										utf16ValueStringBuilder2.Append((char)(-43));
										goto IL_024E;
									}
								}
								utf16ValueStringBuilder2.Append(text[k]);
							}
							IL_024E:;
						}
						text = utf16ValueStringBuilder2.ToString();
						this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[j].\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = text;
						utf16ValueStringBuilder.Append(text);
						this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[j].\u02BF\u02B7\u02B5\u02BA\u02BE\u02BD\u02B6\u02C1\u02BC\u02B3\u02B2 = utf16ValueStringBuilder.Length;
					}
				}
				this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02BE\u02B9\u02BC\u02B6\u02BD\u02C0\u02B6\u02B7\u02BB\u02B4\u02B6 = utf16ValueStringBuilder.ToString();
			}
		}
		this.\u02BA\u02B6\u02BF\u02BB\u02BF\u02C0\u02C1\u02BB\u02B4\u02C0\u02BF = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count - 1;
		this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 = -1;
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x0008CB18 File Offset: 0x0008AD18
	private void \u02C1\u02B2\u02BF\u02B5\u02BD\u02BE\u02C1\u02BB\u02B9\u02C0\u02BF(double \u02BF\u02B4\u02B3\u02BF\u02BB\u02B4\u02B9\u02BD\u02B3\u02B9\u02B7)
	{
		for (int i = 0; i < this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count; i += 0)
		{
			if (this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC >= \u02BF\u02B4\u02B3\u02BF\u02BB\u02B4\u02B9\u02BD\u02B3\u02B9\u02B7)
			{
				this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 = i - 1;
				this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD = i;
				return;
			}
		}
		this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count - 1;
		this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 = this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD - 0;
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x0008CB84 File Offset: 0x0008AD84
	private void \u02C0\u02BB\u02B6\u02B9\u02B3\u02B4\u02B3\u02B7\u02BD\u02B8\u02C0()
	{
		if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD == null || this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count == 0)
		{
			return;
		}
		if (this.\u02BF\u02B3\u02B9\u02B9\u02BD\u02BC\u02B9\u02B7\u02C1\u02C0\u02BD > 758f)
		{
			this.\u02BF\u02B3\u02B9\u02B9\u02BD\u02BC\u02B9\u02B7\u02C1\u02C0\u02BD -= Time.deltaTime;
			return;
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 && this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 == -1)
		{
			this.\u02C1\u02B2\u02BF\u02B5\u02BD\u02BE\u02C1\u02BB\u02B9\u02C0\u02BF(this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB);
			this.\u02B3\u02B3\u02BA\u02C0\u02BA\u02B5\u02BE\u02B8\u02B7\u02BD\u02B9();
		}
		if ((this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 == -1 || this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC) && this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD != -1 && this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB >= this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 - 1463.0)
		{
			this.\u02B5\u02B4\u02B7\u02BB\u02B4\u02BE\u02BA\u02BE\u02B9\u02BF\u02B5();
		}
		if (this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 >= 0 && this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 <= this.\u02BA\u02B6\u02BF\u02BB\u02BF\u02C0\u02C1\u02BB\u02B4\u02C0\u02BF && this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC != null)
		{
			if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB >= this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC.\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC - this.\u02B5\u02C0\u02B7\u02B2\u02BA\u02BB\u02BB\u02BE\u02B4\u02B9\u02B6)
			{
				if (this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC && !this.\u02B5\u02BD\u02B8\u02B8\u02BF\u02BF\u02BA\u02B7\u02B2\u02B6\u02B2)
				{
					this.currentPhraseAnimator.\u02BD\u02C0\u02BF\u02BA\u02BA\u02B3\u02B5\u02BE\u02C1\u02B5\u02B6();
					this.currentPhraseAnimator.\u02C1\u02BB\u02B8\u02B6\u02B3\u02B2\u02C0\u02B8\u02BF\u02BD\u02BF(647f, 1749f);
					this.currentPhraseAnimator.\u02B6\u02B5\u02B2\u02B9\u02C1\u02B6\u02B7\u02BE\u02B3\u02BA\u02B4(1324f);
					this.currentPhraseBgFader.\u02BD\u02BB\u02B3\u02B4\u02B2\u02B6\u02B4\u02BB\u02C0\u02BA\u02C0(this.currentPhraseBgFader.\u02B6\u02C1\u02B3\u02BD\u02B7\u02BD\u02BA\u02B5\u02C1\u02C1\u02B2(), 650f, 1654f);
					if (this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 + 0 <= this.\u02BA\u02B6\u02BF\u02BB\u02BF\u02C0\u02C1\u02BB\u02B4\u02C0\u02BF)
					{
						this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 += 0;
						this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5];
					}
					this.\u02B5\u02BD\u02B8\u02B8\u02BF\u02BF\u02BA\u02B7\u02B2\u02B6\u02B2 = true;
				}
				else if (this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD != -1)
				{
					this.\u02B9\u02B8\u02B9\u02C0\u02B6\u02BC\u02C0\u02BB\u02B9\u02BF\u02B9();
					this.\u02B5\u02B4\u02B7\u02BB\u02B4\u02BE\u02BA\u02BE\u02B9\u02BF\u02B5();
				}
			}
			else if (this.\u02B4\u02B9\u02B3\u02B7\u02BF\u02B7\u02BF\u02B5\u02BE\u02B4\u02B6 < this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0.Count && this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB >= this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC.\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[this.\u02B4\u02B9\u02B3\u02B7\u02BF\u02B7\u02BF\u02B5\u02BE\u02B4\u02B6].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
			{
				\u02C1\u02B5\u02B4\u02C0\u02BD\u02B7\u02B7\u02BA\u02B3\u02BD\u02C0 u02C1_u02B5_u02B4_u02C0_u02BD_u02B7_u02B7_u02BA_u02B3_u02BD_u02C = this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC.\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[this.\u02B4\u02B9\u02B3\u02B7\u02BF\u02B7\u02BF\u02B5\u02BE\u02B4\u02B6];
				using (Utf16ValueStringBuilder utf16ValueStringBuilder = ZString.CreateStringBuilder())
				{
					utf16ValueStringBuilder.Append(this.\u02C0\u02B5\u02BB\u02B6\u02BC\u02B5\u02BD\u02BA\u02B8\u02BC\u02B8);
					foreach (\u02C1\u02B5\u02B4\u02C0\u02BD\u02B7\u02B7\u02BA\u02B3\u02BD\u02C0 u02C1_u02B5_u02B4_u02C0_u02BD_u02B7_u02B7_u02BA_u02B3_u02BD_u02C2 in this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC.\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0)
					{
						utf16ValueStringBuilder.Append(u02C1_u02B5_u02B4_u02C0_u02BD_u02B7_u02B7_u02BA_u02B3_u02BD_u02C2.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF);
						if (u02C1_u02B5_u02B4_u02C0_u02BD_u02B7_u02B7_u02BA_u02B3_u02BD_u02C == u02C1_u02B5_u02B4_u02C0_u02BD_u02B7_u02B7_u02BA_u02B3_u02BD_u02C2)
						{
							utf16ValueStringBuilder.Append(this.\u02BD\u02BC\u02BB\u02B3\u02BF\u02C0\u02BF\u02B7\u02B3\u02C0\u02B7);
						}
					}
					this.currentPhraseDisplay.\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(utf16ValueStringBuilder);
				}
				this.\u02B4\u02B9\u02B3\u02B7\u02BF\u02B7\u02BF\u02B5\u02BE\u02B4\u02B6 += 0;
			}
		}
		this.currentPhraseAnimator.\u02BF\u02BA\u02C1\u02BB\u02B6\u02BF\u02B2\u02B3\u02C0\u02BD\u02B5();
		this.nextPhraseAnimator.\u02BF\u02BA\u02C1\u02BB\u02B6\u02BF\u02B2\u02B3\u02C0\u02BD\u02B5();
		this.fadeAnimator.\u02BF\u02B3\u02B6\u02B4\u02B4\u02BF\u02B4\u02B6\u02B8\u02B9\u02BE();
		if (this.\u02BC\u02B8\u02C0\u02B9\u02B2\u02B3\u02B4\u02BC\u02BC\u02BF\u02B4)
		{
			this.currentPhraseBgFader.\u02BB\u02B6\u02B9\u02B8\u02B6\u02B3\u02BD\u02C0\u02B4\u02BE\u02B2();
			this.nextPhraseBgFader.\u02BE\u02C1\u02B5\u02BE\u02B6\u02B5\u02BC\u02BD\u02BB\u02BF\u02BA();
		}
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x0008CEA8 File Offset: 0x0008B0A8
	public void \u02B2\u02B7\u02BB\u02B5\u02BB\u02B3\u02BF\u02B3\u02BE\u02B2\u02B9(TMP_FontAsset \u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0)
	{
		Material material = new Material(Shader.Find("TextMeshPro/Distance Field"));
		material.CopyPropertiesFromMaterial(this.fontMaterial);
		material.SetTexture(ShaderUtilities.ID_MainTex, \u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.atlasTexture);
		material.SetFloat(ShaderUtilities.ID_TextureWidth, (float)\u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.atlasWidth);
		material.SetFloat(ShaderUtilities.ID_TextureHeight, (float)\u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.atlasHeight);
		material.SetFloat(ShaderUtilities.ID_GradientScale, (float)(\u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.atlasPadding + 1));
		material.SetFloat(ShaderUtilities.ID_WeightNormal, \u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.normalStyle);
		material.SetFloat(ShaderUtilities.ID_WeightBold, \u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.boldStyle);
		\u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.material = material;
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x0008CF44 File Offset: 0x0008B144
	private void \u02B5\u02BF\u02BE\u02B5\u02B3\u02B5\u02BD\u02BC\u02BB\u02B6\u02C0()
	{
		this.\u02B5\u02BD\u02B8\u02B8\u02BF\u02BF\u02BA\u02B7\u02B2\u02B6\u02B2 = true;
		if (!this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC || this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 <= -1)
		{
			this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 += 0;
		}
		this.\u02B4\u02B9\u02B3\u02B7\u02BF\u02B7\u02BF\u02B5\u02BE\u02B4\u02B6 = 0;
		this.\u02BE\u02BD\u02BC\u02B4\u02B7\u02BA\u02C0\u02C0\u02BF\u02B6\u02BF();
		this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC = false;
		if (this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD < this.\u02BA\u02B6\u02BF\u02BB\u02BF\u02C0\u02C1\u02BB\u02B4\u02C0\u02BF)
		{
			this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD++;
			double num = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 - this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC;
			double u02B2_u02B6_u02B9_u02B8_u02BF_u02BD_u02BF_u02BA_u02B9_u02C1_u02B = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0.Count - 1].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5;
			double u02B2_u02B6_u02B9_u02B8_u02BF_u02BD_u02BF_u02BA_u02B9_u02C1_u02B2 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[1].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5;
			double num2 = (this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC - u02B2_u02B6_u02B9_u02B8_u02BF_u02BD_u02BF_u02BA_u02B9_u02C1_u02B) * 1119.0;
			double num3 = (u02B2_u02B6_u02B9_u02B8_u02BF_u02BD_u02BF_u02BA_u02B9_u02C1_u02B2 - this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5) * 988.0;
			double num4 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC - num2;
			double num5 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 + num3;
			double num6 = num5 - this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5].\u02B8\u02B9\u02B3\u02B7\u02B3\u02B9\u02B3\u02BF\u02B5\u02BF\u02BC;
			double num7 = num5 - num4;
			if (num6 >= 271.0)
			{
				this.\u02B5\u02C0\u02B7\u02B2\u02BA\u02BB\u02BB\u02BE\u02B4\u02B9\u02B6 = 519.0;
				this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA = 1873f;
			}
			else if (num7 >= 672.0)
			{
				this.\u02B5\u02C0\u02B7\u02B2\u02BA\u02BB\u02BB\u02BE\u02B4\u02B9\u02B6 = 725.0 - num6;
				this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA = 1165f;
			}
			else if (num7 < 945.0)
			{
				this.\u02B5\u02C0\u02B7\u02B2\u02BA\u02BB\u02BB\u02BE\u02B4\u02B9\u02B6 = num2;
				this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA = (float)num7;
			}
			if (num < 1027.0)
			{
				this.nextPhraseDisplay.text = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD].\u02BE\u02B9\u02BC\u02B6\u02BD\u02C0\u02B6\u02B7\u02BB\u02B4\u02B6;
				this.nextPhraseAnimator.\u02BD\u02C0\u02BF\u02BA\u02BA\u02B3\u02B5\u02BE\u02C1\u02B5\u02B6();
				this.nextPhraseAnimator.\u02C1\u02BB\u02B8\u02B6\u02B3\u02B2\u02C0\u02B8\u02BF\u02BD\u02BF(174f, 1949f);
				this.nextPhraseAnimator.\u02B6\u02B5\u02B2\u02B9\u02C1\u02B6\u02B7\u02BE\u02B3\u02BA\u02B4(this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
				this.nextPhraseBgFader.\u02C1\u02BC\u02B6\u02BC\u02BF\u02B2\u02C1\u02B2\u02B9\u02BB\u02B4(this.nextPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, this.nextPhraseBgFader.\u02B4\u02B8\u02BC\u02BF\u02B6\u02B2\u02BE\u02BE\u02BB\u02B3\u02B4(), this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
			}
			else
			{
				this.nextPhraseDisplay.text = null;
				this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC = true;
				this.nextPhraseBgFader.\u02BD\u02BB\u02B3\u02B4\u02B2\u02B6\u02B4\u02BB\u02C0\u02BA\u02C0(this.nextPhraseBgFader.\u02BF\u02BE\u02B2\u02B9\u02BB\u02B3\u02B8\u02B2\u02BA\u02B8\u02C0(), 582f, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
			}
		}
		else
		{
			this.nextPhraseDisplay.text = null;
			this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD = -1;
			this.\u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC = true;
			this.nextPhraseBgFader.\u02C0\u02B9\u02BE\u02BC\u02C1\u02C1\u02C0\u02B3\u02B2\u02C0\u02BD(this.nextPhraseBgFader.\u02BF\u02BE\u02B2\u02B9\u02BB\u02B3\u02B8\u02B2\u02BA\u02B8\u02C0(), 421f, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
		}
		if (this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 != -1)
		{
			this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5];
		}
		else
		{
			this.\u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC = null;
		}
		if (this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD != -1)
		{
			this.\u02BF\u02B6\u02B5\u02B6\u02BE\u02B9\u02BC\u02B3\u02BB\u02BD\u02B2 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD];
			return;
		}
		this.\u02BF\u02B6\u02B5\u02B6\u02BE\u02B9\u02BC\u02B3\u02BB\u02BD\u02B2 = null;
		this.nextPhraseBgFader.\u02BE\u02BC\u02B8\u02B4\u02BE\u02B4\u02BF\u02BD\u02B9\u02B8\u02B6(this.nextPhraseBgFader.\u02B6\u02B9\u02C1\u02C0\u02B7\u02B2\u02B5\u02C1\u02C0\u02B6\u02B6, 1209f, this.\u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA);
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x0008D2A8 File Offset: 0x0008B4A8
	private void \u02BA\u02B2\u02B2\u02C0\u02C0\u02B5\u02BB\u02B3\u02C0\u02BB\u02BA()
	{
		for (int i = 1; i < this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count; i++)
		{
			using (Utf16ValueStringBuilder utf16ValueStringBuilder = ZString.CreateStringBuilder())
			{
				int num = -1;
				for (int j = 0; j < this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0.Count; j += 0)
				{
					string text = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[j].\u02BB\u02C0\u02C1\u02BC\u02B4\u02B4\u02B3\u02B9\u02B4\u02BD\u02BD;
					using (Utf16ValueStringBuilder utf16ValueStringBuilder2 = ZString.CreateStringBuilder())
					{
						if ((int)text[1] != -5)
						{
							string text2 = string.Empty;
							if (num >= 0)
							{
								text2 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[num].\u02BB\u02C0\u02C1\u02BC\u02B4\u02B4\u02B3\u02B9\u02B4\u02BD\u02BD;
							}
							if (!text2.Contains("guitarcoop6fret") && !text2.EndsWith("video_start_time"))
							{
								utf16ValueStringBuilder2.Append('N');
							}
							if (text.Contains(".") || text.EndsWith("Keys"))
							{
								num = j;
							}
							else
							{
								num = -1;
							}
						}
						else if (j > 1 && text.Length > 1 && (int)text[1] == -113 && text.Contains("----{0}----"))
						{
							num = j;
						}
						bool flag = true;
						int num2 = 1;
						int num3 = 0;
						for (int k = 0; k < text.Length; k += 0)
						{
							if (flag)
							{
								string text3 = string.Empty;
								if ((int)text[num2 + 0] == -126)
								{
									text3 = text.Substring(num2 + 0, num3 - num2 - 1);
								}
								else
								{
									text3 = text.Substring(num2 + 1, num3 - num2 - 1);
								}
								int num4 = text3.IndexOf("diff_rhythm_ghl");
								if (num4 > 1)
								{
									text3 = text3.Substring(0, num4);
								}
								if (this.\u02B5\u02BD\u02B6\u02BF\u02C0\u02B8\u02BC\u02BF\u02B2\u02B4\u02BE.Contains(text3))
								{
									utf16ValueStringBuilder2.Append(text.Substring(num2, num3 - num2 + 0));
									k = num3;
									flag = true;
								}
								else
								{
									k = num3;
									flag = true;
								}
							}
							else
							{
								char c = text[k];
								if (c <= '\'')
								{
									switch (c)
									{
									case '\u0012':
									case '\u0013':
									case '\u0014':
									case '\u0019':
									case '\u001a':
									case '\u001c':
									case '\u001e':
										goto IL_024E;
									case '\u0015':
									case '\u0016':
									case '\u0017':
									case '\u0018':
									case '\u001b':
									case '\u001d':
										break;
									default:
										if ((int)c != -50)
										{
											if ((int)c == -104)
											{
												utf16ValueStringBuilder2.Append('\0');
												goto IL_024E;
											}
										}
										else
										{
											num3 = text.IndexOf('|', k);
											if (num3 > k)
											{
												flag = true;
												num2 = k;
												goto IL_024E;
											}
											goto IL_024E;
										}
										break;
									}
								}
								else
								{
									if (c == 'x')
									{
										goto IL_024E;
									}
									if (c == 'm' || (int)c == -198)
									{
										utf16ValueStringBuilder2.Append('\u001d');
										goto IL_024E;
									}
								}
								utf16ValueStringBuilder2.Append(text[k]);
							}
							IL_024E:;
						}
						text = utf16ValueStringBuilder2.ToString();
						this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[j].\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = text;
						utf16ValueStringBuilder.Append(text);
						this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[j].\u02BF\u02B7\u02B5\u02BA\u02BE\u02BD\u02B6\u02C1\u02BC\u02B3\u02B2 = utf16ValueStringBuilder.Length;
					}
				}
				this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02BE\u02B9\u02BC\u02B6\u02BD\u02C0\u02B6\u02B7\u02BB\u02B4\u02B6 = utf16ValueStringBuilder.ToString();
			}
		}
		this.\u02BA\u02B6\u02BF\u02BB\u02BF\u02C0\u02C1\u02BB\u02B4\u02C0\u02BF = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count - 0;
		this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 = -1;
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x0008D634 File Offset: 0x0008B834
	private void \u02B7\u02B9\u02B5\u02BD\u02BB\u02BB\u02BD\u02B4\u02BF\u02BD\u02B2()
	{
		if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD > 1)
		{
			return;
		}
		bool flag = true;
		for (int i = 0; i < this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF.Count; i += 0)
		{
			if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i] != null && this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && !this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4 && this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i].playerInfo.isAccuracyDisplay)
			{
				flag = true;
				break;
			}
		}
		if (flag && this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BA\u02B3\u02BE\u02B3\u02BF\u02B6\u02B5\u02C0\u02C1\u02C0.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 == (GameMode)8)
		{
			base.gameObject.GetComponent<RectTransform>().localPosition = new Vector3(833f, 1261f, 1633f);
		}
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x0000F1FD File Offset: 0x0000D3FD
	private IEnumerable<uint> \u02B7\u02BF\u02B4\u02B6\u02B9\u02B3\u02B7\u02B3\u02BB\u02BB\u02C0()
	{
		foreach (\u02B4\u02C1\u02B2\u02B6\u02C1\u02B7\u02B4\u02C1\u02BD\u02C1\u02B6 u02B4_u02C1_u02B2_u02B6_u02C1_u02B7_u02B4_u02C1_u02BD_u02C1_u02B in this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB)
		{
			foreach (uint num in __FIXME_clon_util.\u02B4\u02BC\u02BF\u02B8\u02BD\u02C1\u02B4\u02B4\u02B2\u02C0\u02B4(u02B4_u02C1_u02B2_u02B6_u02C1_u02B7_u02B4_u02C1_u02BD_u02C1_u02B.\u02BE\u02B9\u02BC\u02B6\u02BD\u02C0\u02B6\u02B7\u02BB\u02B4\u02B6))
			{
				yield return num;
			}
			IEnumerator<uint> enumerator2 = null;
		}
		List<\u02B4\u02C1\u02B2\u02B6\u02C1\u02B7\u02B4\u02C1\u02BD\u02C1\u02B6>.Enumerator enumerator = default(List<\u02B4\u02C1\u02B2\u02B6\u02C1\u02B7\u02B4\u02C1\u02BD\u02C1\u02B6>.Enumerator);
		yield break;
		yield break;
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x0008D734 File Offset: 0x0008B934
	public void \u02B7\u02B8\u02B2\u02B6\u02BE\u02B5\u02B9\u02C0\u02B2\u02BB\u02B7(GameManager \u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD)
	{
		this.Reset();
		this.\u02BC\u02B8\u02C0\u02B9\u02B2\u02B3\u02B4\u02BC\u02BC\u02BF\u02B4 = SettingsController.\u02B2\u02C1\u02BD\u02C1\u02B4\u02B4\u02B2\u02BA\u02B6\u02B8\u02B4;
		if (!SettingsController.\u02BD\u02B3\u02B7\u02B5\u02B5\u02BD\u02B5\u02B8\u02BD\u02C1\u02C1)
		{
			return;
		}
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = \u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD;
		this.\u02B7\u02B8\u02BC\u02C0\u02B9\u02C1\u02B3\u02C1\u02BD\u02C1\u02B9();
		this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02BC\u02B2\u02B7\u02B8\u02B4\u02B5\u02B8\u02B3\u02B8\u02B7\u02B7(this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD);
		if (this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB == null || this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count == 0)
		{
			this.\u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD = -1;
			return;
		}
		this.\u02BE\u02BB\u02B6\u02B5\u02BB\u02B9\u02BB\u02B9\u02B2\u02BE\u02BD();
		uint[] array = this.\u02B7\u02BF\u02B4\u02B6\u02B9\u02B3\u02B7\u02B3\u02BB\u02BB\u02C0().Distinct<uint>().ToArray<uint>();
		List<TMP_FontAsset> list = new List<TMP_FontAsset>();
		Font[] array2 = this.fonts;
		for (int i = 1; i < array2.Length; i++)
		{
			Font font = array2[i];
			list.Add(this.\u02BA\u02BD\u02B8\u02B5\u02BB\u02B6\u02B8\u02B8\u02B7\u02BA\u02B2(font, array, out array));
			if (array == null)
			{
				break;
			}
		}
		this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3 = list[0];
		if (this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3.fallbackFontAssetTable == null)
		{
			this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3.fallbackFontAssetTable = new List<TMP_FontAsset>(list.Count - 1);
		}
		for (int j = 1; j < list.Count; j += 0)
		{
			this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3.fallbackFontAssetTable.Add(list[j]);
		}
		this.currentPhraseDisplay.font = this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3;
		this.nextPhraseDisplay.font = this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3;
		this.fadePhraseDisplay.font = this.\u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3;
		this.currentPhraseDisplay.UpdateFontAsset();
		this.nextPhraseDisplay.UpdateFontAsset();
		this.fadePhraseDisplay.UpdateFontAsset();
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x0008D8A4 File Offset: 0x0008BAA4
	public void \u02BF\u02B2\u02B3\u02BB\u02BA\u02C1\u02B5\u02B7\u02BC\u02B9\u02B7(TMP_FontAsset \u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0)
	{
		Material material = new Material(Shader.Find(""));
		material.CopyPropertiesFromMaterial(this.fontMaterial);
		material.SetTexture(ShaderUtilities.ID_MainTex, \u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.atlasTexture);
		material.SetFloat(ShaderUtilities.ID_TextureWidth, (float)\u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.atlasWidth);
		material.SetFloat(ShaderUtilities.ID_TextureHeight, (float)\u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.atlasHeight);
		material.SetFloat(ShaderUtilities.ID_GradientScale, (float)(\u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.atlasPadding + 1));
		material.SetFloat(ShaderUtilities.ID_WeightNormal, \u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.normalStyle);
		material.SetFloat(ShaderUtilities.ID_WeightBold, \u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.boldStyle);
		\u02BD\u02C0\u02BB\u02BE\u02BF\u02B4\u02BC\u02B8\u02BA\u02B9\u02C0.material = material;
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x0008D940 File Offset: 0x0008BB40
	private void \u02BE\u02BB\u02B6\u02B5\u02BB\u02B9\u02BB\u02B9\u02B2\u02BE\u02BD()
	{
		for (int i = 1; i < this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count; i += 0)
		{
			using (Utf16ValueStringBuilder utf16ValueStringBuilder = ZString.CreateStringBuilder())
			{
				int num = -1;
				for (int j = 1; j < this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0.Count; j += 0)
				{
					string text = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[j].\u02BB\u02C0\u02C1\u02BC\u02B4\u02B4\u02B3\u02B9\u02B4\u02BD\u02BD;
					using (Utf16ValueStringBuilder utf16ValueStringBuilder2 = ZString.CreateStringBuilder())
					{
						if ((int)text[1] != -32)
						{
							string text2 = string.Empty;
							if (num >= 1)
							{
								text2 = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[num].\u02BB\u02C0\u02C1\u02BC\u02B4\u02B4\u02B3\u02B9\u02B4\u02BD\u02BD;
							}
							if (!text2.Contains("Particles") && !text2.EndsWith("Total Plays: "))
							{
								utf16ValueStringBuilder2.Append((char)(-69));
							}
							if (text.Contains("<b>0</b>/<b>{0}</b>") || text.EndsWith("}"))
							{
								num = j;
							}
							else
							{
								num = -1;
							}
						}
						else if (j > 1 && text.Length > 1 && text[1] == '\u001d' && text.Contains("drumbluetip"))
						{
							num = j;
						}
						bool flag = false;
						int num2 = 1;
						int num3 = 1;
						for (int k = 0; k < text.Length; k++)
						{
							if (flag)
							{
								string text3 = string.Empty;
								if (text[num2 + 1] == '\u0005')
								{
									text3 = text.Substring(num2 + 7, num3 - num2 - 2);
								}
								else
								{
									text3 = text.Substring(num2 + 1, num3 - num2 - 1);
								}
								int num4 = text3.IndexOf("Guest");
								if (num4 > 1)
								{
									text3 = text3.Substring(0, num4);
								}
								if (this.\u02B5\u02BD\u02B6\u02BF\u02C0\u02B8\u02BC\u02BF\u02B2\u02B4\u02BE.Contains(text3))
								{
									utf16ValueStringBuilder2.Append(text.Substring(num2, num3 - num2 + 1));
									k = num3;
									flag = false;
								}
								else
								{
									k = num3;
									flag = true;
								}
							}
							else
							{
								char c = text[k];
								if ((int)c <= -61)
								{
									switch (c)
									{
									case '\0':
									case '\u0001':
									case '\u0002':
									case '\a':
									case '\b':
									case '\n':
									case '\f':
										goto IL_024E;
									case '\u0003':
									case '\u0004':
									case '\u0005':
									case '\u0006':
									case '\t':
									case '\v':
										break;
									default:
										if ((int)c != -27)
										{
											if ((int)c == -126)
											{
												utf16ValueStringBuilder2.Append((char)(-43));
												goto IL_024E;
											}
										}
										else
										{
											num3 = text.IndexOf((char)(-39), k);
											if (num3 > k)
											{
												flag = true;
												num2 = k;
												goto IL_024E;
											}
											goto IL_024E;
										}
										break;
									}
								}
								else
								{
									if ((int)c == -42)
									{
										goto IL_024E;
									}
									if ((int)c == -51 || (int)c == -98)
									{
										utf16ValueStringBuilder2.Append((char)(-33));
										goto IL_024E;
									}
								}
								utf16ValueStringBuilder2.Append(text[k]);
							}
							IL_024E:;
						}
						text = utf16ValueStringBuilder2.ToString();
						this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[j].\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = text;
						utf16ValueStringBuilder.Append(text);
						this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02C0\u02B8\u02B8\u02B8\u02B8\u02B9\u02C1\u02BE\u02BC\u02BD\u02C0[j].\u02BF\u02B7\u02B5\u02BA\u02BE\u02BD\u02B6\u02C1\u02BC\u02B3\u02B2 = utf16ValueStringBuilder.Length;
					}
				}
				this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB[i].\u02BE\u02B9\u02BC\u02B6\u02BD\u02C0\u02B6\u02B7\u02BB\u02B4\u02B6 = utf16ValueStringBuilder.ToString();
			}
		}
		this.\u02BA\u02B6\u02BF\u02BB\u02BF\u02C0\u02C1\u02BB\u02B4\u02C0\u02BF = this.\u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB.Count - 0;
		this.\u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 = -1;
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x0008DCCC File Offset: 0x0008BECC
	private TMP_FontAsset \u02BE\u02BB\u02C1\u02BF\u02C1\u02BE\u02BC\u02B9\u02B8\u02C1\u02B9(Font \u02BF\u02B2\u02C0\u02C0\u02BA\u02BF\u02B4\u02BF\u02C1\u02B9\u02B7, uint[] \u02BC\u02B9\u02B3\u02B6\u02BF\u02BA\u02BD\u02BA\u02BE\u02B2\u02B6, out uint[] \u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5)
	{
		TMP_FontAsset tmp_FontAsset = TMP_FontAsset.CreateFontAsset(\u02BF\u02B2\u02C0\u02C0\u02BA\u02BF\u02B4\u02BF\u02C1\u02B9\u02B7, -94, 10, (GlyphRenderMode)(-121), 134, -184, AtlasPopulationMode.Static, true);
		uint[] array;
		tmp_FontAsset.TryAddCharacters(\u02BC\u02B9\u02B3\u02B6\u02BF\u02BA\u02BD\u02BA\u02BE\u02B2\u02B6, out array, false);
		if (array == null && \u02BC\u02B9\u02B3\u02B6\u02BF\u02BA\u02BD\u02BA\u02BE\u02B2\u02B6.Length != tmp_FontAsset.characterTable.Count)
		{
			Debug.Log("notes.mid");
			HashSet<uint> hashSet = new HashSet<uint>();
			HashSet<uint> hashSet2 = new HashSet<uint>(\u02BC\u02B9\u02B3\u02B6\u02BF\u02BA\u02BD\u02BA\u02BE\u02B2\u02B6);
			foreach (TMP_Character tmp_Character in tmp_FontAsset.characterTable)
			{
				hashSet.Add(tmp_Character.unicode);
			}
			hashSet2.ExceptWith(hashSet);
			\u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5 = hashSet2.ToArray<uint>();
		}
		else
		{
			Debug.Log("Intensity - Pro Drums");
			\u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5 = array;
		}
		if (\u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5 != null && \u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5.Length != 0)
		{
			Debug.Log("" + __FIXME_clon_util.\u02B4\u02B3\u02B9\u02B6\u02BC\u02B7\u02BC\u02BA\u02B3\u02BB\u02B6(\u02C1\u02BB\u02BF\u02B5\u02BA\u02B9\u02B7\u02BE\u02B5\u02B3\u02B5));
		}
		this.\u02BF\u02B2\u02B3\u02BB\u02BA\u02C1\u02B5\u02B7\u02BC\u02B9\u02B7(tmp_FontAsset);
		tmp_FontAsset.atlasPopulationMode = AtlasPopulationMode.Dynamic;
		return tmp_FontAsset;
	}

	// Token: 0x04000CD7 RID: 3287
	private GameManager \u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD;

	// Token: 0x04000CD8 RID: 3288
	private int \u02B8\u02B9\u02BF\u02BB\u02B2\u02B8\u02BE\u02B8\u02B3\u02BB\u02B5 = -1;

	// Token: 0x04000CD9 RID: 3289
	private int \u02BC\u02B9\u02C0\u02BD\u02B2\u02BC\u02BD\u02B7\u02B7\u02BC\u02BD;

	// Token: 0x04000CDA RID: 3290
	private int \u02B4\u02B9\u02B3\u02B7\u02BF\u02B7\u02BF\u02B5\u02BE\u02B4\u02B6;

	// Token: 0x04000CDB RID: 3291
	[SerializeField]
	private TextMeshProUGUI currentPhraseDisplay;

	// Token: 0x04000CDC RID: 3292
	[SerializeField]
	private TextMeshProUGUI nextPhraseDisplay;

	// Token: 0x04000CDD RID: 3293
	[SerializeField]
	private TextMeshProUGUI fadePhraseDisplay;

	// Token: 0x04000CDE RID: 3294
	[SerializeField]
	private Font[] fonts;

	// Token: 0x04000CDF RID: 3295
	[SerializeField]
	private LyricAnimator currentPhraseAnimator;

	// Token: 0x04000CE0 RID: 3296
	[SerializeField]
	private LyricAnimator fadeAnimator;

	// Token: 0x04000CE1 RID: 3297
	[SerializeField]
	private LyricAnimator nextPhraseAnimator;

	// Token: 0x04000CE2 RID: 3298
	[SerializeField]
	private ImageFader currentPhraseBgFader;

	// Token: 0x04000CE3 RID: 3299
	[SerializeField]
	private ImageFader nextPhraseBgFader;

	// Token: 0x04000CE4 RID: 3300
	[SerializeField]
	private Material fontMaterial;

	// Token: 0x04000CE5 RID: 3301
	private TMP_FontAsset \u02BB\u02B6\u02B2\u02BE\u02B4\u02BB\u02B3\u02BA\u02BC\u02BE\u02B3;

	// Token: 0x04000CE6 RID: 3302
	private int \u02BA\u02B6\u02BF\u02BB\u02BF\u02C0\u02C1\u02BB\u02B4\u02C0\u02BF;

	// Token: 0x04000CE7 RID: 3303
	private string \u02BD\u02BC\u02BB\u02B3\u02BF\u02C0\u02BF\u02B7\u02B3\u02C0\u02B7 = "</color>";

	// Token: 0x04000CE8 RID: 3304
	private string \u02C0\u02B5\u02BB\u02B6\u02BC\u02B5\u02BD\u02BA\u02B8\u02BC\u02B8 = "<color=#FFA300>";

	// Token: 0x04000CE9 RID: 3305
	private Vector2 \u02BC\u02BB\u02B7\u02B3\u02BE\u02BA\u02BC\u02C0\u02BF\u02B4\u02B6 = new Vector2(0f, -191.5f);

	// Token: 0x04000CEA RID: 3306
	private Vector2 \u02B8\u02B8\u02B9\u02B2\u02C0\u02B8\u02B9\u02BA\u02C0\u02BA\u02B3 = new Vector2(0f, -135.5f);

	// Token: 0x04000CEB RID: 3307
	private Vector2 \u02B6\u02B7\u02C1\u02C1\u02B7\u02BE\u02C0\u02BE\u02B5\u02B6\u02BB = new Vector2(0f, -87f);

	// Token: 0x04000CEC RID: 3308
	private WaitForEndOfFrame \u02B2\u02B3\u02BA\u02B6\u02B5\u02B3\u02B9\u02B2\u02C0\u02C0\u02BA = new WaitForEndOfFrame();

	// Token: 0x04000CED RID: 3309
	private bool \u02B6\u02BA\u02C0\u02B9\u02B8\u02BA\u02B9\u02BD\u02BF\u02B2\u02BC;

	// Token: 0x04000CEE RID: 3310
	private bool \u02B5\u02BD\u02B8\u02B8\u02BF\u02BF\u02BA\u02B7\u02B2\u02B6\u02B2;

	// Token: 0x04000CEF RID: 3311
	private const float \u02BF\u02B7\u02B2\u02B4\u02B6\u02BD\u02B4\u02B2\u02B2\u02B7\u02B6 = 0.5f;

	// Token: 0x04000CF0 RID: 3312
	private const float \u02B4\u02B5\u02B4\u02B6\u02B8\u02BC\u02BB\u02BF\u02BF\u02B4\u02B8 = 0.1f;

	// Token: 0x04000CF1 RID: 3313
	private const float \u02BD\u02B2\u02B8\u02B5\u02BC\u02BA\u02B8\u02B6\u02B7\u02BA\u02BA = 0.4f;

	// Token: 0x04000CF2 RID: 3314
	private const float \u02BF\u02B7\u02B7\u02B3\u02B4\u02B7\u02BE\u02B6\u02B2\u02BF\u02B5 = 2.5f;

	// Token: 0x04000CF3 RID: 3315
	private float \u02BA\u02B5\u02B5\u02B8\u02BC\u02BC\u02B2\u02BB\u02B2\u02B9\u02BA = 0.2f;

	// Token: 0x04000CF4 RID: 3316
	private double \u02B5\u02C0\u02B7\u02B2\u02BA\u02BB\u02BB\u02BE\u02B4\u02B9\u02B6;

	// Token: 0x04000CF5 RID: 3317
	private const float \u02BD\u02B3\u02BB\u02B4\u02B2\u02BA\u02BD\u02BF\u02BD\u02BB\u02B8 = 0.35f;

	// Token: 0x04000CF6 RID: 3318
	private float \u02BF\u02B3\u02B9\u02B9\u02BD\u02BC\u02B9\u02B7\u02C1\u02C0\u02BD;

	// Token: 0x04000CF7 RID: 3319
	private bool \u02BC\u02B8\u02C0\u02B9\u02B2\u02B3\u02B4\u02BC\u02BC\u02BF\u02B4;

	// Token: 0x04000CF8 RID: 3320
	private List<\u02B4\u02C1\u02B2\u02B6\u02C1\u02B7\u02B4\u02C1\u02BD\u02C1\u02B6> \u02BB\u02B3\u02C1\u02BC\u02B6\u02B5\u02B2\u02B7\u02C0\u02B6\u02BB;

	// Token: 0x04000CF9 RID: 3321
	private \u02B4\u02C1\u02B2\u02B6\u02C1\u02B7\u02B4\u02C1\u02BD\u02C1\u02B6 \u02B3\u02B4\u02B9\u02B4\u02B3\u02B6\u02B6\u02C0\u02B2\u02B9\u02BC;

	// Token: 0x04000CFA RID: 3322
	private \u02B4\u02C1\u02B2\u02B6\u02C1\u02B7\u02B4\u02C1\u02BD\u02C1\u02B6 \u02BF\u02B6\u02B5\u02B6\u02BE\u02B9\u02BC\u02B3\u02BB\u02BD\u02B2;

	// Token: 0x04000CFB RID: 3323
	private HashSet<string> \u02B5\u02BD\u02B6\u02BF\u02C0\u02B8\u02BC\u02BF\u02B2\u02B4\u02BE = new HashSet<string>
	{
		"i", "b", "s", "u", "sup", "sub", "br", "voffset", "lowercase", "uppercase",
		"smallcaps", "cspace", "color", "mspace"
	};
}
