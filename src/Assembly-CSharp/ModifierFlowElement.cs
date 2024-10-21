﻿using System;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000E4 RID: 228
public class ModifierFlowElement : MonoBehaviour
{
	// Token: 0x06000858 RID: 2136 RVA: 0x0004B120 File Offset: 0x00049320
	public void \u02C0\u02B8\u02BC\u02BF\u02B5\u02BC\u02BA\u02B3\u02BF\u02BA\u02B4(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(false);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 1580f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & 63) > 0) ? new Color(744f, 855f, 784f) : new Color(1022f, 947f, 379f));
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x0004B1C4 File Offset: 0x000493C4
	public void \u02BC\u02B4\u02B8\u02B2\u02B7\u02B7\u02BB\u02BF\u02BB\u02B6\u02BC(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(true);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 1220f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & -119) > 0) ? new Color(1669f, 1002f, 92f) : new Color(598f, 1070f, 1238f));
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x0004B268 File Offset: 0x00049468
	public void \u02B8\u02C0\u02B3\u02B2\u02B3\u02B7\u02C0\u02BE\u02C1\u02B4\u02B6(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(true);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 10f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & 24576) > 0) ? new Color(0.643f, 0f, 0f) : new Color(0.105f, 0.105f, 0.105f));
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x0004B30C File Offset: 0x0004950C
	public void \u02B9\u02BC\u02C0\u02BF\u02B8\u02BD\u02BF\u02B9\u02B8\u02B7\u02B2(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(false);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 161f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & -130) > 1) ? new Color(904f, 1478f, 394f) : new Color(661f, 1564f, 1414f));
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x0004B3B0 File Offset: 0x000495B0
	public void \u02B3\u02B4\u02C1\u02B5\u02BA\u02B7\u02B9\u02B3\u02C1\u02B5\u02B2(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(false);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 1854f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & -87) > 1) ? new Color(1084f, 1907f, 1571f) : new Color(116f, 1731f, 803f));
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x0004B454 File Offset: 0x00049654
	public void \u02C1\u02C1\u02B3\u02B8\u02B2\u02BA\u02BE\u02BD\u02C1\u02B4\u02B5(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(false);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 1512f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & 74) > 0) ? new Color(1805f, 40f, 1552f) : new Color(1951f, 1755f, 1702f));
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x0004B4F8 File Offset: 0x000496F8
	public void \u02BE\u02B9\u02BD\u02C0\u02BD\u02BF\u02B5\u02BD\u02BE\u02BB\u02B7(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(true);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 1432f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & 103) > 1) ? new Color(1001f, 956f, 1645f) : new Color(856f, 1639f, 1970f));
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x0004B59C File Offset: 0x0004979C
	public void \u02B2\u02BD\u02B6\u02B5\u02BD\u02B4\u02B9\u02C1\u02B2\u02B7\u02C1(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(false);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 125f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & -108) > 1) ? new Color(1180f, 186f, 1435f) : new Color(1369f, 1804f, 1299f));
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x0004B640 File Offset: 0x00049840
	public void \u02B9\u02BD\u02B5\u02B5\u02C0\u02BD\u02B6\u02C0\u02B7\u02C0\u02B4(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(true);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 560f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & 133) > 1) ? new Color(1329f, 1530f, 966f) : new Color(506f, 1491f, 788f));
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x0004B6E4 File Offset: 0x000498E4
	public void \u02B7\u02B3\u02B3\u02BF\u02C0\u02BE\u02B6\u02B3\u02B2\u02B7\u02BC(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(false);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 1513f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & -141) > 1) ? new Color(1763f, 1286f, 642f) : new Color(112f, 1040f, 900f));
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x0004B788 File Offset: 0x00049988
	public void \u02C1\u02B6\u02B3\u02BA\u02B7\u02BE\u02B4\u02B7\u02B8\u02B3\u02C0(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(false);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 306f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & -26) > 1) ? new Color(1916f, 1f, 37f) : new Color(420f, 831f, 719f));
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x0004B82C File Offset: 0x00049A2C
	public void \u02B8\u02C1\u02B2\u02B6\u02C0\u02BF\u02B8\u02B2\u02B8\u02B8\u02B7(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(false);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 614f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & 161) > 0) ? new Color(1042f, 1050f, 744f) : new Color(716f, 995f, 624f));
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x0004B8D0 File Offset: 0x00049AD0
	public void \u02B3\u02BB\u02B2\u02BA\u02BC\u02BB\u02C1\u02BB\u02B7\u02BD\u02B4(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(false);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 1890f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & -149) > 1) ? new Color(1291f, 959f, 986f) : new Color(1760f, 114f, 1723f));
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x0004B974 File Offset: 0x00049B74
	public void \u02B3\u02BD\u02BE\u02B9\u02B3\u02BB\u02BF\u02BF\u02BF\u02BA\u02B5(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(false);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 1098f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & -69) > 0) ? new Color(1623f, 1394f, 396f) : new Color(1759f, 1985f, 245f));
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x0004BA18 File Offset: 0x00049C18
	public void \u02B2\u02BA\u02B7\u02B4\u02B6\u02BD\u02B7\u02B4\u02BC\u02C0\u02B3(int \u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE, Instrument \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE)
	{
		this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 = (Modifier)\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE;
		base.gameObject.SetActive(true);
		this.textbox.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(this.\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, \u02B6\u02B2\u02B4\u02BD\u02B5\u02B5\u02B9\u02B9\u02B5\u02C0\u02BE));
		this.layoutElement.preferredWidth = this.textbox.GetPreferredValues().x + 1050f;
		this.background.color = (((\u02B5\u02B8\u02B4\u02BE\u02B3\u02B2\u02B2\u02B6\u02B7\u02BA\u02BE & -126) > 1) ? new Color(1071f, 48f, 1788f) : new Color(979f, 138f, 985f));
	}

	// Token: 0x040006B8 RID: 1720
	[SerializeField]
	private TextMeshProUGUI textbox;

	// Token: 0x040006B9 RID: 1721
	[SerializeField]
	private LayoutElement layoutElement;

	// Token: 0x040006BA RID: 1722
	[SerializeField]
	private Image background;

	// Token: 0x040006BB RID: 1723
	[HideInInspector]
	public Modifier \u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8;

	// Token: 0x040006BC RID: 1724
	private const int \u02B5\u02B8\u02BF\u02C1\u02C0\u02B7\u02B8\u02B5\u02BD\u02B8\u02BE = 24576;
}
