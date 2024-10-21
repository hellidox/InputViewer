using System;
using System.Collections;
using StrikeCore;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000213 RID: 531
public class VersusHUD : MonoBehaviour
{
	// Token: 0x060017C2 RID: 6082 RVA: 0x000124C2 File Offset: 0x000106C2
	private void \u02B4\u02C1\u02B6\u02BE\u02B3\u02B4\u02BD\u02B7\u02B6\u02C0\u02B9()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 != GameMode.Versus || GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 || GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD != 0)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x060017C3 RID: 6083 RVA: 0x000124F6 File Offset: 0x000106F6
	private IEnumerator \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		VersusHUD.\u02B6\u02BF\u02B8\u02C1\u02C0\u02BC\u02C1\u02B9\u02BF\u02B7\u02B7 u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B = new VersusHUD.\u02B6\u02BF\u02B8\u02C1\u02C0\u02BC\u02C1\u02B9\u02BF\u02B7\u02B7(1);
		u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B.<>4__this = this;
		return u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B;
	}

	// Token: 0x060017C4 RID: 6084 RVA: 0x00012505 File Offset: 0x00010705
	private IEnumerator \u02B2\u02BB\u02B6\u02B5\u02B9\u02B8\u02B2\u02B3\u02BF\u02C1\u02BF()
	{
		GameManager manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
		while (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD == null || manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length == 0)
		{
			yield return null;
		}
		this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF = new BasePlayer[2];
		int num = 0;
		for (int i = 0; i < manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length; i++)
		{
			if (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i] != null)
			{
				this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[num++] = manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i];
			}
		}
		yield break;
	}

	// Token: 0x060017C5 RID: 6085 RVA: 0x00012505 File Offset: 0x00010705
	private IEnumerator \u02B8\u02B4\u02B9\u02B6\u02BA\u02C0\u02B8\u02C0\u02C0\u02B2\u02B4()
	{
		manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
		while (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD == null || manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length == 0)
		{
			yield return null;
		}
		this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF = new BasePlayer[2];
		int num = 0;
		for (int i = 0; i < manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length; i++)
		{
			if (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i] != null)
			{
				this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[num++] = manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i];
			}
		}
		yield break;
	}

	// Token: 0x060017C6 RID: 6086 RVA: 0x00012505 File Offset: 0x00010705
	private IEnumerator \u02B2\u02BB\u02B6\u02B4\u02BE\u02B8\u02B9\u02B2\u02B3\u02B6\u02C1()
	{
		manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
		while (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD == null || manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length == 0)
		{
			yield return null;
		}
		this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF = new BasePlayer[2];
		int num = 0;
		for (int i = 0; i < manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length; i++)
		{
			if (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i] != null)
			{
				this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[num++] = manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i];
			}
		}
		yield break;
	}

	// Token: 0x060017C7 RID: 6087 RVA: 0x000B17C8 File Offset: 0x000AF9C8
	private void \u02BB\u02BA\u02B9\u02B9\u02B2\u02B9\u02B2\u02B9\u02BE\u02BA\u02B2()
	{
		float num = Mathf.Clamp((float)Mathf.Abs(this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[0].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5 - this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[0].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5) / (float)this.\u02B3\u02BC\u02B7\u02B7\u02B9\u02BF\u02BD\u02B7\u02BF\u02BF\u02B5, 745f, 1967f);
		this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z = this.\u02C1\u02B5\u02B9\u02BD\u02B4\u02B4\u02B2\u02B9\u02BF\u02B6\u02BB * num;
		if (this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[1].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5 > this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[1].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5)
		{
			this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z = this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z * 1415f;
		}
		this.\u02BF\u02C1\u02BF\u02BF\u02B7\u02BC\u02C1\u02C0\u02B3\u02B6\u02B7.transform.rotation = Quaternion.Euler(1552f, 1376f, this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z);
	}

	// Token: 0x060017C9 RID: 6089 RVA: 0x000B187C File Offset: 0x000AFA7C
	private void \u02B4\u02B4\u02BE\u02C1\u02B8\u02B7\u02B7\u02BD\u02B5\u02B7\u02BB()
	{
		float num = Mathf.Clamp((float)Mathf.Abs(this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[1].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5 - this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[1].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5) / (float)this.\u02B3\u02BC\u02B7\u02B7\u02B9\u02BF\u02BD\u02B7\u02BF\u02BF\u02B5, 470f, 559f);
		this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z = this.\u02C1\u02B5\u02B9\u02BD\u02B4\u02B4\u02B2\u02B9\u02BF\u02B6\u02BB * num;
		if (this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[1].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5 > this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[0].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5)
		{
			this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z = this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z * 855f;
		}
		this.\u02BF\u02C1\u02BF\u02BF\u02B7\u02BC\u02C1\u02C0\u02B3\u02B6\u02B7.transform.rotation = Quaternion.Euler(1495f, 372f, this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z);
	}

	// Token: 0x060017CA RID: 6090 RVA: 0x00012505 File Offset: 0x00010705
	private IEnumerator \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
		while (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD == null || manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length == 0)
		{
			yield return null;
		}
		this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF = new BasePlayer[2];
		int num = 0;
		for (int i = 0; i < manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length; i++)
		{
			if (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i] != null)
			{
				this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[num++] = manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i];
			}
		}
		yield break;
	}

	// Token: 0x060017CB RID: 6091 RVA: 0x00012527 File Offset: 0x00010727
	private void Awake()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 != GameMode.Versus || GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 || GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD != 2)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x060017CC RID: 6092 RVA: 0x000124F6 File Offset: 0x000106F6
	private IEnumerator \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		VersusHUD.\u02B6\u02BF\u02B8\u02C1\u02C0\u02BC\u02C1\u02B9\u02BF\u02B7\u02B7 u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B = new VersusHUD.\u02B6\u02BF\u02B8\u02C1\u02C0\u02BC\u02C1\u02B9\u02BF\u02B7\u02B7(1);
		u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B.<>4__this = this;
		return u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B;
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x000B1930 File Offset: 0x000AFB30
	private void FixedUpdate()
	{
		float num = Mathf.Clamp((float)Mathf.Abs(this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[0].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5 - this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[1].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5) / (float)this.\u02B3\u02BC\u02B7\u02B7\u02B9\u02BF\u02BD\u02B7\u02BF\u02BF\u02B5, 0f, 1f);
		this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z = this.\u02C1\u02B5\u02B9\u02BD\u02B4\u02B4\u02B2\u02B9\u02BF\u02B6\u02BB * num;
		if (this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[1].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5 > this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[0].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5)
		{
			this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z = this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z * -1f;
		}
		this.\u02BF\u02C1\u02BF\u02BF\u02B7\u02BC\u02C1\u02C0\u02B3\u02B6\u02B7.transform.rotation = Quaternion.Euler(0f, 0f, this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z);
	}

	// Token: 0x060017CE RID: 6094 RVA: 0x0001255B File Offset: 0x0001075B
	private void \u02BF\u02BC\u02B9\u02BE\u02B7\u02BD\u02C1\u02BE\u02BD\u02BD\u02B5()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 != (GameMode)5 || GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 || GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD != 7)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x00012505 File Offset: 0x00010705
	private IEnumerator \u02B4\u02BC\u02BE\u02BF\u02B4\u02B5\u02BF\u02B7\u02BA\u02BA\u02BB()
	{
		manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
		while (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD == null || manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length == 0)
		{
			yield return null;
		}
		this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF = new BasePlayer[2];
		int num = 0;
		for (int i = 0; i < manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length; i++)
		{
			if (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i] != null)
			{
				this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[num++] = manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i];
			}
		}
		yield break;
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x00012505 File Offset: 0x00010705
	private IEnumerator \u02B7\u02B8\u02BD\u02C0\u02B2\u02B4\u02B7\u02C0\u02BC\u02BE\u02B3()
	{
		manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
		while (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD == null || manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length == 0)
		{
			yield return null;
		}
		this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF = new BasePlayer[2];
		int num = 0;
		for (int i = 0; i < manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length; i++)
		{
			if (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i] != null)
			{
				this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[num++] = manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i];
			}
		}
		yield break;
	}

	// Token: 0x060017D1 RID: 6097 RVA: 0x000B19E4 File Offset: 0x000AFBE4
	private void \u02B4\u02B8\u02B6\u02B7\u02B5\u02B6\u02BB\u02B4\u02B4\u02B9\u02B7()
	{
		float num = Mathf.Clamp((float)Mathf.Abs(this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[0].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5 - this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[1].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5) / (float)this.\u02B3\u02BC\u02B7\u02B7\u02B9\u02BF\u02BD\u02B7\u02BF\u02BF\u02B5, 372f, 995f);
		this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z = this.\u02C1\u02B5\u02B9\u02BD\u02B4\u02B4\u02B2\u02B9\u02BF\u02B6\u02BB * num;
		if (this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[0].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5 > this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[1].\u02B2\u02B2\u02BA\u02B8\u02B9\u02B7\u02B7\u02B5\u02BA\u02B4\u02B5)
		{
			this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z = this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z * 1922f;
		}
		this.\u02BF\u02C1\u02BF\u02BF\u02B7\u02BC\u02C1\u02C0\u02B3\u02B6\u02B7.transform.rotation = Quaternion.Euler(425f, 990f, this.\u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE.z);
	}

	// Token: 0x060017D2 RID: 6098 RVA: 0x00012505 File Offset: 0x00010705
	private IEnumerator \u02B2\u02B7\u02B5\u02C0\u02B4\u02B3\u02B8\u02B3\u02C0\u02BD\u02B5()
	{
		manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
		while (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD == null || manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length == 0)
		{
			yield return null;
		}
		this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF = new BasePlayer[2];
		int num = 0;
		for (int i = 0; i < manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length; i++)
		{
			if (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i] != null)
			{
				this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[num++] = manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i];
			}
		}
		yield break;
	}

	// Token: 0x060017D3 RID: 6099 RVA: 0x00012505 File Offset: 0x00010705
	private IEnumerator \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
		while (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD == null || manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length == 0)
		{
			yield return null;
		}
		this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF = new BasePlayer[2];
		int num = 0;
		for (int i = 0; i < manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length; i++)
		{
			if (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i] != null)
			{
				this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[num++] = manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i];
			}
		}
		yield break;
	}

	// Token: 0x060017D4 RID: 6100 RVA: 0x000124F6 File Offset: 0x000106F6
	private IEnumerator \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		VersusHUD.\u02B6\u02BF\u02B8\u02C1\u02C0\u02BC\u02C1\u02B9\u02BF\u02B7\u02B7 u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B = new VersusHUD.\u02B6\u02BF\u02B8\u02C1\u02C0\u02BC\u02C1\u02B9\u02BF\u02B7\u02B7(1);
		u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B.<>4__this = this;
		return u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B;
	}

	// Token: 0x060017D5 RID: 6101 RVA: 0x00012505 File Offset: 0x00010705
	private IEnumerator Start()
	{
		manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
		while (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD == null || manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length == 0)
		{
			yield return null;
		}
		this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF = new BasePlayer[2];
		int num = 0;
		for (int i = 0; i < manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length; i++)
		{
			if (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i] != null)
			{
				this.\u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF[num++] = manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD[i];
			}
		}
		yield break;
	}

	// Token: 0x060017D6 RID: 6102 RVA: 0x000124F6 File Offset: 0x000106F6
	private IEnumerator \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		VersusHUD.\u02B6\u02BF\u02B8\u02C1\u02C0\u02BC\u02C1\u02B9\u02BF\u02B7\u02B7 u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B = new VersusHUD.\u02B6\u02BF\u02B8\u02C1\u02C0\u02BC\u02C1\u02B9\u02BF\u02B7\u02B7(1);
		u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B.<>4__this = this;
		return u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B;
	}

	// Token: 0x060017D7 RID: 6103 RVA: 0x0001258F File Offset: 0x0001078F
	private void \u02B6\u02BB\u02B6\u02B4\u02BB\u02B8\u02B4\u02BC\u02BD\u02B3\u02C1()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 != GameMode.Practice || GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 || GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD != 7)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x060017D8 RID: 6104 RVA: 0x000124F6 File Offset: 0x000106F6
	private IEnumerator \u02C0\u02BC\u02BC\u02BD\u02B8\u02BD\u02BE\u02B6\u02BE\u02BB\u02BB()
	{
		VersusHUD.\u02B6\u02BF\u02B8\u02C1\u02C0\u02BC\u02C1\u02B9\u02BF\u02B7\u02B7 u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B = new VersusHUD.\u02B6\u02BF\u02B8\u02C1\u02C0\u02BC\u02C1\u02B9\u02BF\u02B7\u02B7(1);
		u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B.<>4__this = this;
		return u02B6_u02BF_u02B8_u02C1_u02C0_u02BC_u02C1_u02B9_u02BF_u02B7_u02B;
	}

	// Token: 0x040010FC RID: 4348
	private BasePlayer[] \u02B8\u02B9\u02B6\u02B7\u02C0\u02B2\u02B9\u02BF\u02C1\u02B5\u02BF;

	// Token: 0x040010FD RID: 4349
	public Image \u02BF\u02C1\u02BF\u02BF\u02B7\u02BC\u02C1\u02C0\u02B3\u02B6\u02B7;

	// Token: 0x040010FE RID: 4350
	public float \u02C1\u02B5\u02B9\u02BD\u02B4\u02B4\u02B2\u02B9\u02BF\u02B6\u02BB;

	// Token: 0x040010FF RID: 4351
	public int \u02B3\u02BC\u02B7\u02B7\u02B9\u02BF\u02BD\u02B7\u02BF\u02BF\u02B5 = 20000;

	// Token: 0x04001100 RID: 4352
	private Vector3 \u02B5\u02B7\u02BF\u02BF\u02B9\u02BB\u02BE\u02BF\u02B3\u02BA\u02BE;
}
