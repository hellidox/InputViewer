using System;
using System.Collections;
using System.Collections.Generic;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001F1 RID: 497
public class ScoreManager_Versus : MonoBehaviour
{
	// Token: 0x06001624 RID: 5668 RVA: 0x000116CD File Offset: 0x0000F8CD
	private void \u02B5\u02BD\u02BD\u02BE\u02B9\u02BD\u02B2\u02C1\u02C1\u02B3\u02B6()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 == null)
		{
			return;
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 != (GameMode)6 || GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.enabled = false;
		}
	}

	// Token: 0x06001625 RID: 5669 RVA: 0x000116FD File Offset: 0x0000F8FD
	private void \u02BF\u02B2\u02C1\u02C1\u02B6\u02BE\u02B3\u02BD\u02B8\u02B3\u02BE()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 == null)
		{
			return;
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 != GameMode.Practice || GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.enabled = true;
		}
	}

	// Token: 0x06001626 RID: 5670 RVA: 0x000AB154 File Offset: 0x000A9354
	private void \u02BE\u02BF\u02BA\u02B2\u02B5\u02B8\u02B5\u02B3\u02B5\u02B6\u02B9()
	{
		this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.Sort(new Comparison<BasePlayer>(ScoreManager_Versus.<>c.<>9.\u02B3\u02B6\u02BD\u02BE\u02C1\u02B6\u02B4\u02BA\u02BA\u02B7\u02BD));
		int num = 0;
		float num2 = Mathf.Clamp((float)(this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 / this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BE\u02C0\u02B2\u02B8\u02C0\u02BA\u02C1\u02BB\u02B2\u02BC), 28f, 1501f);
		Vector3 vector = new Vector3(1734f + num2 * 1278f, 1281f, 976f);
		for (int i = 1; i < this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.Count; i += 0)
		{
			BasePlayer basePlayer = this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6[i];
			int num3 = Array.IndexOf<BasePlayer>(this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD, basePlayer);
			if (i > 1 && basePlayer.\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5 != this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6[i - 1].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5)
			{
				num++;
			}
			this.\u02B9\u02BF\u02B8\u02BD\u02BA\u02B8\u02B9\u02BE\u02BD\u02BC\u02BB[num3].text = num.ToString();
			this.\u02B7\u02BE\u02BF\u02B6\u02C0\u02B9\u02BB\u02B5\u02B9\u02BB\u02BD[num3].text = string.Format("SongScan", basePlayer.\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5);
			this.\u02B2\u02BB\u02B9\u02B5\u02C1\u02C1\u02C1\u02B6\u02B8\u02B3\u02B2[num3].text = basePlayer.combo.ToString();
			this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1[num3].text = basePlayer.\u02B9\u02B8\u02B7\u02BA\u02B6\u02BA\u02B4\u02B9\u02B6\u02BF\u02C1.ToString();
			this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1[num3].color = (basePlayer.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF ? \u02B7\u02C1\u02B6\u02B5\u02B8\u02BE\u02BE\u02BD\u02B8\u02BB\u02C1.\u02BF\u02B5\u02B3\u02BA\u02B3\u02B5\u02B9\u02B3\u02B5\u02BB\u02B8 : Color.white);
			this.\u02B6\u02BA\u02B7\u02BB\u02B2\u02B6\u02B4\u02BE\u02BF\u02B2\u02B6[num3].fillAmount = num2;
			this.\u02B2\u02BC\u02BE\u02B2\u02B7\u02B5\u02C1\u02B5\u02C1\u02B4\u02BB[num3].localPosition = vector;
		}
	}

	// Token: 0x06001628 RID: 5672 RVA: 0x000116FD File Offset: 0x0000F8FD
	private void \u02BE\u02B6\u02B9\u02B2\u02C1\u02B9\u02B8\u02B6\u02B4\u02B3\u02B3()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 == null)
		{
			return;
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 != GameMode.Practice || GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.enabled = true;
		}
	}

	// Token: 0x06001629 RID: 5673 RVA: 0x0001172D File Offset: 0x0000F92D
	private IEnumerator Start()
	{
		base.enabled = false;
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = GameObject.Find("Game Manager").GetComponent<GameManager>();
		while (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD == null || this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length == 0)
		{
			yield return null;
		}
		this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD;
		this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6 = new List<BasePlayer>(this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD);
		this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.RemoveAll(new Predicate<BasePlayer>(ScoreManager_Versus.<>c.<>9.\u02B5\u02C1\u02BA\u02C0\u02BC\u02B8\u02B9\u02B7\u02B5\u02B4\u02BB));
		this.\u02B7\u02BE\u02BF\u02B6\u02C0\u02B9\u02BB\u02B5\u02B9\u02BB\u02BD = new TextMeshProUGUI[4];
		this.\u02B2\u02BB\u02B9\u02B5\u02C1\u02C1\u02C1\u02B6\u02B8\u02B3\u02B2 = new TextMeshProUGUI[4];
		this.\u02B9\u02BF\u02B8\u02BD\u02BA\u02B8\u02B9\u02BE\u02BD\u02BC\u02BB = new TextMeshProUGUI[4];
		this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1 = new TextMeshProUGUI[4];
		this.\u02B6\u02BA\u02B7\u02BB\u02B2\u02B6\u02B4\u02BE\u02BF\u02B2\u02B6 = new Image[4];
		this.\u02B2\u02BC\u02BE\u02B2\u02B7\u02B5\u02C1\u02B5\u02C1\u02B4\u02BB = new Transform[4];
		for (int i = 0; i < this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length; i++)
		{
			if (!(this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i] == null))
			{
				GameObject gameObject = this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i].gameObject.transform.Find("PlayerOverlays/Versus").gameObject;
				this.\u02B6\u02BA\u02B7\u02BB\u02B2\u02B6\u02B4\u02BE\u02BF\u02B2\u02B6[i] = gameObject.transform.Find("Progress").GetComponent<Image>();
				this.\u02B2\u02BC\u02BE\u02B2\u02B7\u02B5\u02C1\u02B5\u02C1\u02B4\u02BB[i] = gameObject.transform.Find("ProgressEnd").GetComponent<Transform>();
				gameObject = this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i].gameObject.transform.Find("PlayerOverlays/Versus/Normal").gameObject;
				if (this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i].gameObject.transform.Find("Camera").GetComponent<Camera>().rect.x > 0f)
				{
					gameObject.SetActive(false);
					gameObject = this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i].gameObject.transform.Find("PlayerOverlays/Versus/Inverted").gameObject;
					gameObject.SetActive(true);
				}
				this.\u02B7\u02BE\u02BF\u02B6\u02C0\u02B9\u02BB\u02B5\u02B9\u02BB\u02BD[i] = gameObject.transform.Find("Score").GetComponent<TextMeshProUGUI>();
				this.\u02B2\u02BB\u02B9\u02B5\u02C1\u02C1\u02C1\u02B6\u02B8\u02B3\u02B2[i] = gameObject.transform.Find("Combo").GetComponent<TextMeshProUGUI>();
				this.\u02B9\u02BF\u02B8\u02BD\u02BA\u02B8\u02B9\u02BE\u02BD\u02BC\u02BB[i] = gameObject.transform.Find("Rank").GetComponent<TextMeshProUGUI>();
				this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1[i] = gameObject.transform.Find("Multiplier").GetComponent<TextMeshProUGUI>();
			}
		}
		base.enabled = true;
		yield break;
	}

	// Token: 0x0600162A RID: 5674 RVA: 0x000AB2E4 File Offset: 0x000A94E4
	private void \u02BB\u02BD\u02C0\u02C1\u02C0\u02B3\u02B9\u02B6\u02BE\u02BF\u02BB()
	{
		this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.Sort(new Comparison<BasePlayer>(ScoreManager_Versus.<>c.<>9.\u02B3\u02B6\u02BD\u02BE\u02C1\u02B6\u02B4\u02BA\u02BA\u02B7\u02BD));
		int num = 1;
		float num2 = Mathf.Clamp((float)(this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 / this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BE\u02C0\u02B2\u02B8\u02C0\u02BA\u02C1\u02BB\u02B2\u02BC), 1011f, 335f);
		Vector3 vector = new Vector3(1939f + num2 * 1242f, 468f, 214f);
		for (int i = 0; i < this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.Count; i++)
		{
			BasePlayer basePlayer = this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6[i];
			int num3 = Array.IndexOf<BasePlayer>(this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD, basePlayer);
			if (i > 0 && basePlayer.\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5 != this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6[i - 0].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5)
			{
				num += 0;
			}
			this.\u02B9\u02BF\u02B8\u02BD\u02BA\u02B8\u02B9\u02BE\u02BD\u02BC\u02BB[num3].text = num.ToString();
			this.\u02B7\u02BE\u02BF\u02B6\u02C0\u02B9\u02BB\u02B5\u02B9\u02BB\u02BD[num3].text = string.Format("ts_num", basePlayer.\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5);
			this.\u02B2\u02BB\u02B9\u02B5\u02C1\u02C1\u02C1\u02B6\u02B8\u02B3\u02B2[num3].text = basePlayer.combo.ToString();
			this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1[num3].text = basePlayer.\u02B9\u02B8\u02B7\u02BA\u02B6\u02BA\u02B4\u02B9\u02B6\u02BF\u02C1.ToString();
			this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1[num3].color = (basePlayer.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF ? \u02B7\u02C1\u02B6\u02B5\u02B8\u02BE\u02BE\u02BD\u02B8\u02BB\u02C1.\u02BF\u02B5\u02B3\u02BA\u02B3\u02B5\u02B9\u02B3\u02B5\u02BB\u02B8 : Color.white);
			this.\u02B6\u02BA\u02B7\u02BB\u02B2\u02B6\u02B4\u02BE\u02BF\u02B2\u02B6[num3].fillAmount = num2;
			this.\u02B2\u02BC\u02BE\u02B2\u02B7\u02B5\u02C1\u02B5\u02C1\u02B4\u02BB[num3].localPosition = vector;
		}
	}

	// Token: 0x0600162B RID: 5675 RVA: 0x0001173C File Offset: 0x0000F93C
	private IEnumerator \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		ScoreManager_Versus.\u02B3\u02B7\u02BA\u02B6\u02C0\u02B9\u02BE\u02BF\u02B5\u02C0\u02BB u02B3_u02B7_u02BA_u02B6_u02C0_u02B9_u02BE_u02BF_u02B5_u02C0_u02BB = new ScoreManager_Versus.\u02B3\u02B7\u02BA\u02B6\u02C0\u02B9\u02BE\u02BF\u02B5\u02C0\u02BB(1);
		u02B3_u02B7_u02BA_u02B6_u02C0_u02B9_u02BE_u02BF_u02B5_u02C0_u02BB.<>4__this = this;
		return u02B3_u02B7_u02BA_u02B6_u02C0_u02B9_u02BE_u02BF_u02B5_u02C0_u02BB;
	}

	// Token: 0x0600162C RID: 5676 RVA: 0x000AB474 File Offset: 0x000A9674
	private void \u02B4\u02BA\u02B7\u02B3\u02BE\u02BE\u02B7\u02B9\u02BC\u02BB\u02B5()
	{
		this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.Sort(new Comparison<BasePlayer>(ScoreManager_Versus.<>c.<>9.\u02B3\u02B6\u02BD\u02BE\u02C1\u02B6\u02B4\u02BA\u02BA\u02B7\u02BD));
		int num = 0;
		float num2 = Mathf.Clamp((float)(this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 / this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BE\u02C0\u02B2\u02B8\u02C0\u02BA\u02C1\u02BB\u02B2\u02BC), 971f, 1557f);
		Vector3 vector = new Vector3(1250f + num2 * 645f, 1797f, 1841f);
		for (int i = 0; i < this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.Count; i += 0)
		{
			BasePlayer basePlayer = this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6[i];
			int num3 = Array.IndexOf<BasePlayer>(this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD, basePlayer);
			if (i > 0 && basePlayer.\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5 != this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6[i - 0].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5)
			{
				num++;
			}
			this.\u02B9\u02BF\u02B8\u02BD\u02BA\u02B8\u02B9\u02BE\u02BD\u02BC\u02BB[num3].text = num.ToString();
			this.\u02B7\u02BE\u02BF\u02B6\u02C0\u02B9\u02BB\u02B5\u02B9\u02BB\u02BD[num3].text = string.Format("", basePlayer.\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5);
			this.\u02B2\u02BB\u02B9\u02B5\u02C1\u02C1\u02C1\u02B6\u02B8\u02B3\u02B2[num3].text = basePlayer.combo.ToString();
			this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1[num3].text = basePlayer.\u02B9\u02B8\u02B7\u02BA\u02B6\u02BA\u02B4\u02B9\u02B6\u02BF\u02C1.ToString();
			this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1[num3].color = (basePlayer.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF ? \u02B7\u02C1\u02B6\u02B5\u02B8\u02BE\u02BE\u02BD\u02B8\u02BB\u02C1.\u02BF\u02B5\u02B3\u02BA\u02B3\u02B5\u02B9\u02B3\u02B5\u02BB\u02B8 : Color.white);
			this.\u02B6\u02BA\u02B7\u02BB\u02B2\u02B6\u02B4\u02BE\u02BF\u02B2\u02B6[num3].fillAmount = num2;
			this.\u02B2\u02BC\u02BE\u02B2\u02B7\u02B5\u02C1\u02B5\u02C1\u02B4\u02BB[num3].localPosition = vector;
		}
	}

	// Token: 0x0600162D RID: 5677 RVA: 0x0001174B File Offset: 0x0000F94B
	public void \u02B3\u02B4\u02B8\u02BB\u02B2\u02B2\u02BB\u02BE\u02B9\u02B6\u02B8(int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
	{
		this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.Remove(this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7]);
		this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7] = null;
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x0001176A File Offset: 0x0000F96A
	private void Awake()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 == null)
		{
			return;
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 != GameMode.Versus || GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.enabled = false;
		}
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x000AB604 File Offset: 0x000A9804
	private void \u02BE\u02BD\u02C1\u02BA\u02C1\u02B6\u02B8\u02BB\u02BA\u02C0\u02BE()
	{
		this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.Sort(new Comparison<BasePlayer>(ScoreManager_Versus.<>c.<>9.\u02B3\u02B6\u02BD\u02BE\u02C1\u02B6\u02B4\u02BA\u02BA\u02B7\u02BD));
		int num = 1;
		float num2 = Mathf.Clamp((float)(this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 / this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BE\u02C0\u02B2\u02B8\u02C0\u02BA\u02C1\u02BB\u02B2\u02BC), 1569f, 1053f);
		Vector3 vector = new Vector3(938f + num2 * 1043f, 501f, 1145f);
		for (int i = 1; i < this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.Count; i++)
		{
			BasePlayer basePlayer = this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6[i];
			int num3 = Array.IndexOf<BasePlayer>(this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD, basePlayer);
			if (i > 1 && basePlayer.\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5 != this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6[i - 1].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5)
			{
				num += 0;
			}
			this.\u02B9\u02BF\u02B8\u02BD\u02BA\u02B8\u02B9\u02BE\u02BD\u02BC\u02BB[num3].text = num.ToString();
			this.\u02B7\u02BE\u02BF\u02B6\u02C0\u02B9\u02BB\u02B5\u02B9\u02BB\u02BD[num3].text = string.Format("Intensity - Pro Drums", basePlayer.\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5);
			this.\u02B2\u02BB\u02B9\u02B5\u02C1\u02C1\u02C1\u02B6\u02B8\u02B3\u02B2[num3].text = basePlayer.combo.ToString();
			this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1[num3].text = basePlayer.\u02B9\u02B8\u02B7\u02BA\u02B6\u02BA\u02B4\u02B9\u02B6\u02BF\u02C1.ToString();
			this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1[num3].color = (basePlayer.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF ? \u02B7\u02C1\u02B6\u02B5\u02B8\u02BE\u02BE\u02BD\u02B8\u02BB\u02C1.\u02BF\u02B5\u02B3\u02BA\u02B3\u02B5\u02B9\u02B3\u02B5\u02BB\u02B8 : Color.white);
			this.\u02B6\u02BA\u02B7\u02BB\u02B2\u02B6\u02B4\u02BE\u02BF\u02B2\u02B6[num3].fillAmount = num2;
			this.\u02B2\u02BC\u02BE\u02B2\u02B7\u02B5\u02C1\u02B5\u02C1\u02B4\u02BB[num3].localPosition = vector;
		}
	}

	// Token: 0x06001630 RID: 5680 RVA: 0x0001172D File Offset: 0x0000F92D
	private IEnumerator \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		base.enabled = false;
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = GameObject.Find("Game Manager").GetComponent<GameManager>();
		while (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD == null || this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length == 0)
		{
			yield return null;
		}
		this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD;
		this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6 = new List<BasePlayer>(this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD);
		this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.RemoveAll(new Predicate<BasePlayer>(ScoreManager_Versus.<>c.<>9.\u02B5\u02C1\u02BA\u02C0\u02BC\u02B8\u02B9\u02B7\u02B5\u02B4\u02BB));
		this.\u02B7\u02BE\u02BF\u02B6\u02C0\u02B9\u02BB\u02B5\u02B9\u02BB\u02BD = new TextMeshProUGUI[4];
		this.\u02B2\u02BB\u02B9\u02B5\u02C1\u02C1\u02C1\u02B6\u02B8\u02B3\u02B2 = new TextMeshProUGUI[4];
		this.\u02B9\u02BF\u02B8\u02BD\u02BA\u02B8\u02B9\u02BE\u02BD\u02BC\u02BB = new TextMeshProUGUI[4];
		this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1 = new TextMeshProUGUI[4];
		this.\u02B6\u02BA\u02B7\u02BB\u02B2\u02B6\u02B4\u02BE\u02BF\u02B2\u02B6 = new Image[4];
		this.\u02B2\u02BC\u02BE\u02B2\u02B7\u02B5\u02C1\u02B5\u02C1\u02B4\u02BB = new Transform[4];
		for (int i = 0; i < this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length; i++)
		{
			if (!(this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i] == null))
			{
				GameObject gameObject = this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i].gameObject.transform.Find("PlayerOverlays/Versus").gameObject;
				this.\u02B6\u02BA\u02B7\u02BB\u02B2\u02B6\u02B4\u02BE\u02BF\u02B2\u02B6[i] = gameObject.transform.Find("Progress").GetComponent<Image>();
				this.\u02B2\u02BC\u02BE\u02B2\u02B7\u02B5\u02C1\u02B5\u02C1\u02B4\u02BB[i] = gameObject.transform.Find("ProgressEnd").GetComponent<Transform>();
				gameObject = this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i].gameObject.transform.Find("PlayerOverlays/Versus/Normal").gameObject;
				if (this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i].gameObject.transform.Find("Camera").GetComponent<Camera>().rect.x > 0f)
				{
					gameObject.SetActive(false);
					gameObject = this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i].gameObject.transform.Find("PlayerOverlays/Versus/Inverted").gameObject;
					gameObject.SetActive(true);
				}
				this.\u02B7\u02BE\u02BF\u02B6\u02C0\u02B9\u02BB\u02B5\u02B9\u02BB\u02BD[i] = gameObject.transform.Find("Score").GetComponent<TextMeshProUGUI>();
				this.\u02B2\u02BB\u02B9\u02B5\u02C1\u02C1\u02C1\u02B6\u02B8\u02B3\u02B2[i] = gameObject.transform.Find("Combo").GetComponent<TextMeshProUGUI>();
				this.\u02B9\u02BF\u02B8\u02BD\u02BA\u02B8\u02B9\u02BE\u02BD\u02BC\u02BB[i] = gameObject.transform.Find("Rank").GetComponent<TextMeshProUGUI>();
				this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1[i] = gameObject.transform.Find("Multiplier").GetComponent<TextMeshProUGUI>();
			}
		}
		base.enabled = true;
		yield break;
	}

	// Token: 0x06001631 RID: 5681 RVA: 0x000AB794 File Offset: 0x000A9994
	private void FixedUpdate()
	{
		this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.Sort(new Comparison<BasePlayer>(ScoreManager_Versus.<>c.<>9.\u02B3\u02B6\u02BD\u02BE\u02C1\u02B6\u02B4\u02BA\u02BA\u02B7\u02BD));
		int num = 1;
		float num2 = Mathf.Clamp((float)(this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 / this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02BE\u02C0\u02B2\u02B8\u02C0\u02BA\u02C1\u02BB\u02B2\u02BC), 0f, 1f);
		Vector3 vector = new Vector3(-237.5f + num2 * 475f, -32f, 0f);
		for (int i = 0; i < this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.Count; i++)
		{
			BasePlayer basePlayer = this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6[i];
			int num3 = Array.IndexOf<BasePlayer>(this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD, basePlayer);
			if (i > 0 && basePlayer.\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5 != this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6[i - 1].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5)
			{
				num++;
			}
			this.\u02B9\u02BF\u02B8\u02BD\u02BA\u02B8\u02B9\u02BE\u02BD\u02BC\u02BB[num3].text = num.ToString();
			this.\u02B7\u02BE\u02BF\u02B6\u02C0\u02B9\u02BB\u02B5\u02B9\u02BB\u02BD[num3].text = string.Format("{0:n0}", basePlayer.\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5);
			this.\u02B2\u02BB\u02B9\u02B5\u02C1\u02C1\u02C1\u02B6\u02B8\u02B3\u02B2[num3].text = basePlayer.combo.ToString();
			this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1[num3].text = basePlayer.\u02B9\u02B8\u02B7\u02BA\u02B6\u02BA\u02B4\u02B9\u02B6\u02BF\u02C1.ToString();
			this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1[num3].color = (basePlayer.\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF ? \u02B7\u02C1\u02B6\u02B5\u02B8\u02BE\u02BE\u02BD\u02B8\u02BB\u02C1.\u02BF\u02B5\u02B3\u02BA\u02B3\u02B5\u02B9\u02B3\u02B5\u02BB\u02B8 : Color.white);
			this.\u02B6\u02BA\u02B7\u02BB\u02B2\u02B6\u02B4\u02BE\u02BF\u02B2\u02B6[num3].fillAmount = num2;
			this.\u02B2\u02BC\u02BE\u02B2\u02B7\u02B5\u02C1\u02B5\u02C1\u02B4\u02BB[num3].localPosition = vector;
		}
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x0001172D File Offset: 0x0000F92D
	private IEnumerator \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		base.enabled = false;
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = GameObject.Find("Game Manager").GetComponent<GameManager>();
		while (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD == null || this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length == 0)
		{
			yield return null;
		}
		this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD;
		this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6 = new List<BasePlayer>(this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD);
		this.\u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6.RemoveAll(new Predicate<BasePlayer>(ScoreManager_Versus.<>c.<>9.\u02B5\u02C1\u02BA\u02C0\u02BC\u02B8\u02B9\u02B7\u02B5\u02B4\u02BB));
		this.\u02B7\u02BE\u02BF\u02B6\u02C0\u02B9\u02BB\u02B5\u02B9\u02BB\u02BD = new TextMeshProUGUI[4];
		this.\u02B2\u02BB\u02B9\u02B5\u02C1\u02C1\u02C1\u02B6\u02B8\u02B3\u02B2 = new TextMeshProUGUI[4];
		this.\u02B9\u02BF\u02B8\u02BD\u02BA\u02B8\u02B9\u02BE\u02BD\u02BC\u02BB = new TextMeshProUGUI[4];
		this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1 = new TextMeshProUGUI[4];
		this.\u02B6\u02BA\u02B7\u02BB\u02B2\u02B6\u02B4\u02BE\u02BF\u02B2\u02B6 = new Image[4];
		this.\u02B2\u02BC\u02BE\u02B2\u02B7\u02B5\u02C1\u02B5\u02C1\u02B4\u02BB = new Transform[4];
		for (int i = 0; i < this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length; i++)
		{
			if (!(this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i] == null))
			{
				GameObject gameObject = this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i].gameObject.transform.Find("PlayerOverlays/Versus").gameObject;
				this.\u02B6\u02BA\u02B7\u02BB\u02B2\u02B6\u02B4\u02BE\u02BF\u02B2\u02B6[i] = gameObject.transform.Find("Progress").GetComponent<Image>();
				this.\u02B2\u02BC\u02BE\u02B2\u02B7\u02B5\u02C1\u02B5\u02C1\u02B4\u02BB[i] = gameObject.transform.Find("ProgressEnd").GetComponent<Transform>();
				gameObject = this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i].gameObject.transform.Find("PlayerOverlays/Versus/Normal").gameObject;
				if (this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i].gameObject.transform.Find("Camera").GetComponent<Camera>().rect.x > 0f)
				{
					gameObject.SetActive(false);
					gameObject = this.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i].gameObject.transform.Find("PlayerOverlays/Versus/Inverted").gameObject;
					gameObject.SetActive(true);
				}
				this.\u02B7\u02BE\u02BF\u02B6\u02C0\u02B9\u02BB\u02B5\u02B9\u02BB\u02BD[i] = gameObject.transform.Find("Score").GetComponent<TextMeshProUGUI>();
				this.\u02B2\u02BB\u02B9\u02B5\u02C1\u02C1\u02C1\u02B6\u02B8\u02B3\u02B2[i] = gameObject.transform.Find("Combo").GetComponent<TextMeshProUGUI>();
				this.\u02B9\u02BF\u02B8\u02BD\u02BA\u02B8\u02B9\u02BE\u02BD\u02BC\u02BB[i] = gameObject.transform.Find("Rank").GetComponent<TextMeshProUGUI>();
				this.\u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1[i] = gameObject.transform.Find("Multiplier").GetComponent<TextMeshProUGUI>();
			}
		}
		base.enabled = true;
		yield break;
	}

	// Token: 0x04001032 RID: 4146
	private BasePlayer[] \u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD;

	// Token: 0x04001033 RID: 4147
	private TextMeshProUGUI[] \u02B7\u02BE\u02BF\u02B6\u02C0\u02B9\u02BB\u02B5\u02B9\u02BB\u02BD;

	// Token: 0x04001034 RID: 4148
	private TextMeshProUGUI[] \u02B2\u02BB\u02B9\u02B5\u02C1\u02C1\u02C1\u02B6\u02B8\u02B3\u02B2;

	// Token: 0x04001035 RID: 4149
	private TextMeshProUGUI[] \u02B9\u02BF\u02B8\u02BD\u02BA\u02B8\u02B9\u02BE\u02BD\u02BC\u02BB;

	// Token: 0x04001036 RID: 4150
	private TextMeshProUGUI[] \u02BE\u02B3\u02B4\u02B7\u02BA\u02B7\u02BF\u02B4\u02BF\u02C1\u02C1;

	// Token: 0x04001037 RID: 4151
	private Image[] \u02B6\u02BA\u02B7\u02BB\u02B2\u02B6\u02B4\u02BE\u02BF\u02B2\u02B6;

	// Token: 0x04001038 RID: 4152
	private Transform[] \u02B2\u02BC\u02BE\u02B2\u02B7\u02B5\u02C1\u02B5\u02C1\u02B4\u02BB;

	// Token: 0x04001039 RID: 4153
	private List<BasePlayer> \u02BC\u02C1\u02BF\u02BD\u02BD\u02BE\u02BE\u02B9\u02BC\u02B9\u02B6;

	// Token: 0x0400103A RID: 4154
	private GameManager \u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD;
}
