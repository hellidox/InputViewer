﻿using System;
using UnityEngine;

public class SPBar : MonoBehaviour, \u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7
{
	public void \u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC(float \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5, bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
	{
		if (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 == this.\u02BE\u02C1\u02BE\u02B9\u02B7\u02BD\u02BB\u02B5\u02BC\u02B6\u02BC)
		{
			return;
		}
		this.\u02BE\u02C1\u02BE\u02B9\u02B7\u02BD\u02BB\u02B5\u02BC\u02B6\u02BC = \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5;
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetFloat("_uFillHeight", \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5);
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetFloat("_uElectricityEffect", \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF ? 1f : ((\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 >= 0.5f) ? 1f : 0f));
		if (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 <= 0f)
		{
			this.bottomArrow.SetActive(false);
			this.topArrow.SetActive(false);
			return;
		}
		this.topArrow.SetActive(\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF || \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 >= 0.5f);
		this.bottomArrow.SetActive(\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 > 0f);
		this.topArrow.transform.localPosition = ((\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 <= 0.5f) ? Vector3.Lerp(this.\u02B7\u02C1\u02BF\u02BA\u02BB\u02B3\u02B6\u02B5\u02B8\u02B3\u02BA, this.\u02C1\u02B4\u02B5\u02BA\u02BC\u02BC\u02C1\u02B8\u02C1\u02B2\u02B9, \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 * 2f) : Vector3.Lerp(this.\u02C1\u02B4\u02B5\u02BA\u02BC\u02BC\u02C1\u02B8\u02C1\u02B2\u02B9, this.\u02B6\u02B5\u02B9\u02C1\u02C0\u02C0\u02BC\u02B8\u02C1\u02B3\u02C1, (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 - 0.5f) * 2f));
	}

	public void \u02B3\u02BB\u02B3\u02B8\u02B2\u02B8\u02B8\u02B6\u02BA\u02B7\u02BE(float \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5, bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
	{
		if (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 == this.\u02BE\u02C1\u02BE\u02B9\u02B7\u02BD\u02BB\u02B5\u02BC\u02B6\u02BC)
		{
			return;
		}
		this.\u02BE\u02C1\u02BE\u02B9\u02B7\u02BD\u02BB\u02B5\u02BC\u02B6\u02BC = \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5;
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetFloat("track", \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5);
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetFloat(" + ", \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF ? 1827f : ((\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 >= 82f) ? 1019f : 540f));
		if (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 <= 958f)
		{
			this.bottomArrow.SetActive(false);
			this.topArrow.SetActive(false);
			return;
		}
		this.topArrow.SetActive(!\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF && \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 < 1536f);
		this.bottomArrow.SetActive(\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 > 16f);
		this.topArrow.transform.localPosition = ((\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 <= 1763f) ? Vector3.Lerp(this.\u02B7\u02C1\u02BF\u02BA\u02BB\u02B3\u02B6\u02B5\u02B8\u02B3\u02BA, this.\u02C1\u02B4\u02B5\u02BA\u02BC\u02BC\u02C1\u02B8\u02C1\u02B2\u02B9, \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 * 152f) : Vector3.Lerp(this.\u02C1\u02B4\u02B5\u02BA\u02BC\u02BC\u02C1\u02B8\u02C1\u02B2\u02B9, this.\u02B6\u02B5\u02B9\u02C1\u02C0\u02C0\u02BC\u02B8\u02C1\u02B3\u02C1, (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 - 1537f) * 221f));
	}

	private void Start()
	{
		SPBar.pos = Camera.main.WorldToScreenPoint(this.bottomArrow.GetComponent<SpriteRenderer>().transform.position);
		this.\u02B3\u02C1\u02B6\u02C1\u02B3\u02BE\u02B4\u02B8\u02BE\u02B4\u02BD = this.bottomArrow.GetComponent<SpriteRenderer>();
		this.\u02B5\u02B6\u02BD\u02B4\u02B7\u02B8\u02C1\u02C0\u02BA\u02BB\u02B5 = this.topArrow.GetComponent<SpriteRenderer>();
		this.\u02B5\u02B6\u02BD\u02B4\u02B7\u02B8\u02C1\u02C0\u02BA\u02BB\u02B5.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02BD\u02BB\u02BE\u02BA\u02C0\u02BC\u02BC\u02B7\u02B6\u02BA\u02BE;
		this.\u02B3\u02C1\u02B6\u02C1\u02B3\u02BE\u02B4\u02B8\u02BE\u02B4\u02BD.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02BD\u02BB\u02BE\u02BA\u02C0\u02BC\u02BC\u02B7\u02B6\u02BA\u02BE;
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetColor("_uBarColor", this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02BE\u02B4\u02B8\u02C1\u02BE\u02C1\u02BB\u02BE\u02BE\u02BD\u02B5);
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetColor("_uElectricityColor", this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B9\u02BB\u02B5\u02B8\u02C1\u02BC\u02B2\u02B2\u02B7\u02B9\u02B4);
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetVector("_uUVProperties", new Vector4(this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.sprite.uv[0].x, this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.sprite.uv[0].y, this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.sprite.uv[3].x, this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.sprite.uv[3].y));
		this.bottomArrow.SetActive(false);
		this.\u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC(0f, false);
	}

	public void \u02BF\u02BF\u02B7\u02B3\u02BF\u02BD\u02BE\u02B6\u02B4\u02BB\u02B4(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public void \u02BE\u02B2\u02B5\u02B4\u02BE\u02B6\u02B4\u02B6\u02B5\u02C1\u02B7(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6 { get; set; }

	public void \u02B8\u02B9\u02BD\u02BE\u02B3\u02B8\u02B8\u02B6\u02B2\u02BE\u02C1(float \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5, bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
	{
		if (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 == this.\u02BE\u02C1\u02BE\u02B9\u02B7\u02BD\u02BB\u02B5\u02BC\u02B6\u02BC)
		{
			return;
		}
		this.\u02BE\u02C1\u02BE\u02B9\u02B7\u02BD\u02BB\u02B5\u02BC\u02B6\u02BC = \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5;
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetFloat("", \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5);
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetFloat("No", \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF ? 1574f : ((\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 >= 682f) ? 1590f : 1086f));
		if (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 <= 1832f)
		{
			this.bottomArrow.SetActive(true);
			this.topArrow.SetActive(false);
			return;
		}
		this.topArrow.SetActive(!\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF && \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 < 836f);
		this.bottomArrow.SetActive(\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 > 288f);
		this.topArrow.transform.localPosition = ((\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 <= 1964f) ? Vector3.Lerp(this.\u02B7\u02C1\u02BF\u02BA\u02BB\u02B3\u02B6\u02B5\u02B8\u02B3\u02BA, this.\u02C1\u02B4\u02B5\u02BA\u02BC\u02BC\u02C1\u02B8\u02C1\u02B2\u02B9, \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 * 1752f) : Vector3.Lerp(this.\u02C1\u02B4\u02B5\u02BA\u02BC\u02BC\u02C1\u02B8\u02C1\u02B2\u02B9, this.\u02B6\u02B5\u02B9\u02C1\u02C0\u02C0\u02BC\u02B8\u02C1\u02B3\u02C1, (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 - 12f) * 892f));
	}

	public void \u02BF\u02BA\u02BE\u02C1\u02BA\u02BB\u02B5\u02BA\u02BA\u02BF\u02B5(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public void \u02B3\u02C1\u02C1\u02BB\u02C1\u02BE\u02B4\u02BC\u02B8\u02B4\u02B2(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	private void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		this.\u02B3\u02C1\u02B6\u02C1\u02B3\u02BE\u02B4\u02B8\u02BE\u02B4\u02BD = this.bottomArrow.GetComponent<SpriteRenderer>();
		this.\u02B5\u02B6\u02BD\u02B4\u02B7\u02B8\u02C1\u02C0\u02BA\u02BB\u02B5 = this.topArrow.GetComponent<SpriteRenderer>();
		this.\u02B5\u02B6\u02BD\u02B4\u02B7\u02B8\u02C1\u02C0\u02BA\u02BB\u02B5.color = this.\u02B2\u02B8\u02BB\u02B8\u02C0\u02BA\u02B8\u02B8\u02B4\u02BD\u02B9().\u02BD\u02BB\u02BE\u02BA\u02C0\u02BC\u02BC\u02B7\u02B6\u02BA\u02BE;
		this.\u02B3\u02C1\u02B6\u02C1\u02B3\u02BE\u02B4\u02B8\u02BE\u02B4\u02BD.color = this.\u02B2\u02B8\u02BB\u02B8\u02C0\u02BA\u02B8\u02B8\u02B4\u02BD\u02B9().\u02BD\u02BB\u02BE\u02BA\u02C0\u02BC\u02BC\u02B7\u02B6\u02BA\u02BE;
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetColor("Notes", this.\u02BB\u02B8\u02B3\u02B3\u02BE\u02B2\u02BD\u02BD\u02BC\u02B6\u02B6().\u02BE\u02B4\u02B8\u02C1\u02BE\u02C1\u02BB\u02BE\u02BE\u02BD\u02B5);
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetColor("Note Number: ", this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B9\u02BB\u02B5\u02B8\u02C1\u02BC\u02B2\u02B2\u02B7\u02B9\u02B4);
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetVector(" ", new Vector4(this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.sprite.uv[0].x, this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.sprite.uv[0].y, this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.sprite.uv[2].x, this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.sprite.uv[3].y));
		this.bottomArrow.SetActive(true);
		this.\u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC(1779f, true);
	}

	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02C1\u02B6\u02BC\u02BC\u02B4\u02B2\u02BE\u02BC\u02B7\u02B2\u02BC()
	{
		return this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField;
	}

	public void \u02BE\u02BD\u02B6\u02B8\u02B5\u02BC\u02B7\u02BE\u02C0\u02B2\u02B6(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	private void \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		this.\u02B3\u02C1\u02B6\u02C1\u02B3\u02BE\u02B4\u02B8\u02BE\u02B4\u02BD = this.bottomArrow.GetComponent<SpriteRenderer>();
		this.\u02B5\u02B6\u02BD\u02B4\u02B7\u02B8\u02C1\u02C0\u02BA\u02BB\u02B5 = this.topArrow.GetComponent<SpriteRenderer>();
		this.\u02B5\u02B6\u02BD\u02B4\u02B7\u02B8\u02C1\u02C0\u02BA\u02BB\u02B5.color = this.\u02C1\u02B6\u02BC\u02BC\u02B4\u02B2\u02BE\u02BC\u02B7\u02B2\u02BC().\u02BD\u02BB\u02BE\u02BA\u02C0\u02BC\u02BC\u02B7\u02B6\u02BA\u02BE;
		this.\u02B3\u02C1\u02B6\u02C1\u02B3\u02BE\u02B4\u02B8\u02BE\u02B4\u02BD.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02BD\u02BB\u02BE\u02BA\u02C0\u02BC\u02BC\u02B7\u02B6\u02BA\u02BE;
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetColor("Settings", this.\u02B8\u02BD\u02B8\u02B6\u02BF\u02BB\u02BA\u02B8\u02B2\u02BB\u02B2().\u02BE\u02B4\u02B8\u02C1\u02BE\u02C1\u02BB\u02BE\u02BE\u02BD\u02B5);
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetColor("%p", this.\u02C1\u02B6\u02BC\u02BC\u02B4\u02B2\u02BE\u02BC\u02B7\u02B2\u02BC().\u02B9\u02BB\u02B5\u02B8\u02C1\u02BC\u02B2\u02B2\u02B7\u02B9\u02B4);
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetVector(" does not contain a valid chart file.", new Vector4(this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.sprite.uv[0].x, this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.sprite.uv[1].y, this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.sprite.uv[6].x, this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.sprite.uv[3].y));
		this.bottomArrow.SetActive(true);
		this.\u02BB\u02B7\u02BD\u02B8\u02B2\u02BE\u02B2\u02B5\u02BE\u02B5\u02C1(951f, false);
	}

	public void \u02BB\u02B7\u02BD\u02B8\u02B2\u02BE\u02B2\u02B5\u02BE\u02B5\u02C1(float \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5, bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
	{
		if (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 == this.\u02BE\u02C1\u02BE\u02B9\u02B7\u02BD\u02BB\u02B5\u02BC\u02B6\u02BC)
		{
			return;
		}
		this.\u02BE\u02C1\u02BE\u02B9\u02B7\u02BD\u02BB\u02B5\u02BC\u02B6\u02BC = \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5;
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetFloat("v1popupReadGuide", \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5);
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetFloat("diff_drums_real", \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF ? 1239f : ((\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 >= 178f) ? 1744f : 185f));
		if (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 <= 46f)
		{
			this.bottomArrow.SetActive(true);
			this.topArrow.SetActive(false);
			return;
		}
		this.topArrow.SetActive(!\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF && \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 >= 1702f);
		this.bottomArrow.SetActive(\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 > 1690f);
		this.topArrow.transform.localPosition = ((\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 <= 1803f) ? Vector3.Lerp(this.\u02B7\u02C1\u02BF\u02BA\u02BB\u02B3\u02B6\u02B5\u02B8\u02B3\u02BA, this.\u02C1\u02B4\u02B5\u02BA\u02BC\u02BC\u02C1\u02B8\u02C1\u02B2\u02B9, \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 * 256f) : Vector3.Lerp(this.\u02C1\u02B4\u02B5\u02BA\u02BC\u02BC\u02C1\u02B8\u02C1\u02B2\u02B9, this.\u02B6\u02B5\u02B9\u02C1\u02C0\u02C0\u02BC\u02B8\u02C1\u02B3\u02C1, (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 - 755f) * 1355f));
	}

	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B2\u02B8\u02BB\u02B8\u02C0\u02BA\u02B8\u02B8\u02B4\u02BD\u02B9()
	{
		return this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField;
	}

	public void \u02C0\u02B3\u02B9\u02B4\u02B7\u02BE\u02BE\u02BC\u02B4\u02BD\u02BF(float \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5, bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
	{
		if (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 == this.\u02BE\u02C1\u02BE\u02B9\u02B7\u02BD\u02BB\u02B5\u02BC\u02B6\u02BC)
		{
			return;
		}
		this.\u02BE\u02C1\u02BE\u02B9\u02B7\u02BD\u02BB\u02B5\u02BC\u02B6\u02BC = \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5;
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetFloat("Unpacking files...", \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5);
		this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetFloat("notes.mid", \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF ? 1628f : ((\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 >= 1127f) ? 722f : 730f));
		if (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 <= 744f)
		{
			this.bottomArrow.SetActive(false);
			this.topArrow.SetActive(true);
			return;
		}
		this.topArrow.SetActive(!\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF && \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 >= 451f);
		this.bottomArrow.SetActive(\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 > 947f);
		this.topArrow.transform.localPosition = ((\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 <= 1243f) ? Vector3.Lerp(this.\u02B7\u02C1\u02BF\u02BA\u02BB\u02B3\u02B6\u02B5\u02B8\u02B3\u02BA, this.\u02C1\u02B4\u02B5\u02BA\u02BC\u02BC\u02C1\u02B8\u02C1\u02B2\u02B9, \u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 * 585f) : Vector3.Lerp(this.\u02C1\u02B4\u02B5\u02BA\u02BC\u02BC\u02C1\u02B8\u02C1\u02B2\u02B9, this.\u02B6\u02B5\u02B9\u02C1\u02C0\u02C0\u02BC\u02B8\u02C1\u02B3\u02C1, (\u02BE\u02BB\u02B8\u02B2\u02BE\u02BF\u02C1\u02BA\u02B4\u02C1\u02B5 - 1433f) * 1854f));
	}

	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B8\u02BD\u02B8\u02B6\u02BF\u02BB\u02BA\u02B8\u02B2\u02BB\u02B2()
	{
		return this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField;
	}

	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02BB\u02B8\u02B3\u02B3\u02BE\u02B2\u02BD\u02BD\u02BC\u02B6\u02B6()
	{
		return this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField;
	}

	private void Update()
	{
		this.ticker += Time.deltaTime;
		if (this.ticker > 0.033333335f)
		{
			if (GlobalHelper.rainbowSPBar)
			{
				this.wasEnabledLastFrame = true;
				float num = Time.realtimeSinceStartup / 15f;
				this.ticker -= 0.033333335f;
				Color color = global::Animator.Rainbow(num) * 0.85f;
				this.\u02B5\u02B6\u02BD\u02B4\u02B7\u02B8\u02C1\u02C0\u02BA\u02BB\u02B5.color = color;
				this.\u02B3\u02C1\u02B6\u02C1\u02B3\u02BE\u02B4\u02B8\u02BE\u02B4\u02BD.color = color;
				this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetColor("_uBarColor", color);
				this.\u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9.material.SetColor("_uElectricityColor", color);
				return;
			}
			if (this.wasEnabledLastFrame)
			{
				this.wasEnabledLastFrame = false;
				this.\u02B5\u02B6\u02BD\u02B4\u02B7\u02B8\u02C1\u02C0\u02BA\u02BB\u02B5.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02BD\u02BB\u02BE\u02BA\u02C0\u02BC\u02BC\u02B7\u02B6\u02BA\u02BE;
				this.\u02B3\u02C1\u02B6\u02C1\u02B3\u02BE\u02B4\u02B8\u02BE\u02B4\u02BD.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02BD\u02BB\u02BE\u02BA\u02C0\u02BC\u02BC\u02B7\u02B6\u02BA\u02BE;
			}
		}
	}

	void \u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7.\u02B8\u02B9\u02C0\u02B7\u02C0\u02B6\u02C1\u02BA\u02BF\u02B8\u02B8(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6 = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public SpriteRenderer \u02B6\u02BF\u02BD\u02BE\u02B5\u02B7\u02BD\u02B8\u02BA\u02BA\u02B9;

	public Vector3 \u02B6\u02B5\u02B9\u02C1\u02C0\u02C0\u02BC\u02B8\u02C1\u02B3\u02C1;

	public Vector3 \u02C1\u02B4\u02B5\u02BA\u02BC\u02BC\u02C1\u02B8\u02C1\u02B2\u02B9;

	public Vector3 \u02B7\u02C1\u02BF\u02BA\u02BB\u02B3\u02B6\u02B5\u02B8\u02B3\u02BA;

	[SerializeField]
	private GameObject topArrow;

	[SerializeField]
	private GameObject bottomArrow;

	private float \u02BE\u02C1\u02BE\u02B9\u02B7\u02BD\u02BB\u02B5\u02BC\u02B6\u02BC = -1f;

	private SpriteRenderer \u02B3\u02C1\u02B6\u02C1\u02B3\u02BE\u02B4\u02B8\u02BE\u02B4\u02BD;

	private SpriteRenderer \u02B5\u02B6\u02BD\u02B4\u02B7\u02B8\u02C1\u02C0\u02BA\u02BB\u02B5;

	private float ticker;

	private bool wasEnabledLastFrame;

	public static Vector2 pos;
}
