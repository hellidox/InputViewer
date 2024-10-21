using System;
using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000201 RID: 513
public class TextBox : MonoBehaviour
{
	// Token: 0x060016F9 RID: 5881 RVA: 0x000AF500 File Offset: 0x000AD700
	private void \u02B8\u02C1\u02C1\u02B9\u02BB\u02BB\u02B2\u02B8\u02B9\u02B2\u02B7()
	{
		this.\u02BC\u02B5\u02B4\u02B7\u02BB\u02BF\u02B7\u02B9\u02BA\u02B6\u02BA();
		if (this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length == 1)
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF[0] = (char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF;
		}
		else
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length - 0, 0);
		}
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.ToString();
	}

	// Token: 0x060016FA RID: 5882 RVA: 0x000AF57C File Offset: 0x000AD77C
	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		if (Input.GetKeyDown((KeyCode)(-30)))
		{
			this.\u02BF\u02B5\u02C1\u02C0\u02B6\u02B9\u02B4\u02B9\u02BB\u02BB\u02BA();
		}
		if (Input.GetKeyDown((KeyCode)(-171)))
		{
			this.\u02BE\u02B3\u02B3\u02BD\u02BC\u02B5\u02B7\u02C1\u02BF\u02B3\u02B5();
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			this.\u02BC\u02B3\u02B2\u02BB\u02BD\u02BF\u02C1\u02B4\u02B2\u02C1\u02B2((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		}
		foreach (char c in Input.inputString)
		{
			if (c == '\b')
			{
				this.\u02BA\u02BF\u02B3\u02B6\u02C0\u02BF\u02B7\u02BB\u02B9\u02B2\u02BB();
			}
			else
			{
				this.\u02BA\u02BB\u02BD\u02B3\u02BB\u02BA\u02B8\u02BA\u02B8\u02B9\u02BA(c);
			}
		}
	}

	// Token: 0x060016FB RID: 5883 RVA: 0x00011ECE File Offset: 0x000100CE
	private void \u02C0\u02B7\u02B3\u02BF\u02B9\u02B3\u02BB\u02C1\u02BB\u02BA\u02BF()
	{
		this.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD(null);
	}

	// Token: 0x060016FC RID: 5884 RVA: 0x00011ECE File Offset: 0x000100CE
	private void OnEnable()
	{
		this.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD(null);
	}

	// Token: 0x060016FD RID: 5885 RVA: 0x000AF5F8 File Offset: 0x000AD7F8
	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		if (Input.GetKeyDown((KeyCode)(-150)))
		{
			this.\u02BF\u02B5\u02C1\u02C0\u02B6\u02B9\u02B4\u02B9\u02BB\u02BB\u02BA();
		}
		if (Input.GetKeyDown((KeyCode)(-161)))
		{
			this.\u02BE\u02B3\u02B3\u02BD\u02BC\u02B5\u02B7\u02C1\u02BF\u02B3\u02B5();
		}
		if (Input.GetKeyDown((KeyCode)156))
		{
			this.\u02BA\u02BB\u02BD\u02B3\u02BB\u02BA\u02B8\u02BA\u02B8\u02B9\u02BA((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		}
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i++)
		{
			char c = inputString[i];
			if (c == '\u0001')
			{
				this.\u02B8\u02C1\u02C1\u02B9\u02BB\u02BB\u02B2\u02B8\u02B9\u02B2\u02B7();
			}
			else
			{
				this.\u02BA\u02BB\u02BD\u02B3\u02BB\u02BA\u02B8\u02BA\u02B8\u02B9\u02BA(c);
			}
		}
	}

	// Token: 0x060016FE RID: 5886 RVA: 0x00011ED7 File Offset: 0x000100D7
	private IEnumerator \u02B3\u02B6\u02B4\u02B3\u02B6\u02B7\u02B6\u02B3\u02B4\u02C0\u02C0()
	{
		WaitForSeconds wait = new WaitForSeconds(0.4f);
		bool show = false;
		for (;;)
		{
			if (this.\u02B6\u02BF\u02B5\u02B6\u02C1\u02BC\u02BB\u02B4\u02B6\u02B5\u02B3 || this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length > this.maxCharacterCount)
			{
				this.\u02B6\u02BF\u02B5\u02B6\u02C1\u02BC\u02BB\u02B4\u02B6\u02B5\u02B3 = false;
				show = true;
			}
			else
			{
				show = !show;
				if (show)
				{
					this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length - 1, 1);
					this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
				}
				else
				{
					this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length - 1, 1);
					this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append('_');
				}
				this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.ToString();
			}
			yield return wait;
		}
		yield break;
	}

	// Token: 0x060016FF RID: 5887 RVA: 0x000AF674 File Offset: 0x000AD874
	private void \u02BA\u02BB\u02BD\u02B3\u02BB\u02BA\u02B8\u02BA\u02B8\u02B9\u02BA(char \u02B3\u02B7\u02B5\u02B9\u02C0\u02B4\u02B4\u02B7\u02B5\u02B8\u02B9)
	{
		if (this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length >= this.maxCharacterCount)
		{
			return;
		}
		this.\u02BC\u02B5\u02B4\u02B7\u02BB\u02BF\u02B7\u02B9\u02BA\u02B6\u02BA();
		this.\u02B6\u02BF\u02B5\u02B6\u02C1\u02BC\u02BB\u02B4\u02B6\u02B5\u02B3 = true;
		if ((int)this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF[this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length - 1] == -23)
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length - 0, 0);
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append(\u02B3\u02B7\u02B5\u02B9\u02C0\u02B4\u02B4\u02B7\u02B5\u02B8\u02B9);
		}
		if (this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length < this.maxCharacterCount)
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		}
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.ToString();
	}

	// Token: 0x06001701 RID: 5889 RVA: 0x000AF724 File Offset: 0x000AD924
	private void \u02BC\u02B3\u02B2\u02BB\u02BD\u02BF\u02C1\u02B4\u02B2\u02C1\u02B2(char \u02B3\u02B7\u02B5\u02B9\u02C0\u02B4\u02B4\u02B7\u02B5\u02B8\u02B9)
	{
		if (this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length >= this.maxCharacterCount)
		{
			return;
		}
		this.\u02BC\u02B5\u02B4\u02B7\u02BB\u02BF\u02B7\u02B9\u02BA\u02B6\u02BA();
		this.\u02B6\u02BF\u02B5\u02B6\u02C1\u02BC\u02BB\u02B4\u02B6\u02B5\u02B3 = true;
		if (this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF[this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length - 1] == '_')
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length - 1, 1);
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append(\u02B3\u02B7\u02B5\u02B9\u02C0\u02B4\u02B4\u02B7\u02B5\u02B8\u02B9);
		}
		if (this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length < this.maxCharacterCount)
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		}
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.ToString();
	}

	// Token: 0x06001702 RID: 5890 RVA: 0x000AF7D4 File Offset: 0x000AD9D4
	public void \u02B4\u02BE\u02B7\u02BE\u02B3\u02BE\u02BA\u02BA\u02BB\u02BC\u02BD(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		this.\u02BC\u02B5\u02B4\u02B7\u02BB\u02BF\u02B7\u02B9\u02BA\u02B6\u02BA();
		if (this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF == null)
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF = new StringBuilder(this.maxCharacterCount);
		}
		else
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(0, this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length);
		}
		if (this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF == null)
		{
			this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = base.GetComponent<Text>();
		}
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(0, this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length);
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.ToString();
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;
	}

	// Token: 0x17000234 RID: 564
	// (get) Token: 0x06001703 RID: 5891 RVA: 0x00011EE6 File Offset: 0x000100E6
	private bool \u02B6\u02BB\u02B2\u02BB\u02B8\u02B4\u02B4\u02B6\u02B7\u02BD\u02BE
	{
		get
		{
			return this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length >= this.maxCharacterCount;
		}
	}

	// Token: 0x06001704 RID: 5892 RVA: 0x000AF87C File Offset: 0x000ADA7C
	private void \u02BF\u02B5\u02C1\u02C0\u02B6\u02B9\u02B4\u02B9\u02BB\u02BB\u02BA()
	{
		this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF--;
		int u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF = this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF;
		if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF <= -113)
		{
			if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF != 92)
			{
				if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF == -79)
				{
					this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = -61;
				}
			}
			else
			{
				this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = 19;
			}
		}
		else if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF != 87)
		{
			if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF == 105)
			{
				this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = -99;
			}
		}
		else
		{
			this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = -127;
		}
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length - 0, 0);
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.ToString();
		this.\u02B6\u02BF\u02B5\u02B6\u02C1\u02BC\u02BB\u02B4\u02B6\u02B5\u02B3 = true;
	}

	// Token: 0x06001705 RID: 5893 RVA: 0x000AF92C File Offset: 0x000ADB2C
	private void \u02BA\u02B6\u02B2\u02BB\u02BE\u02B3\u02C1\u02C1\u02BB\u02B8\u02B5()
	{
		this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF--;
		int u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF = this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF;
		if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF <= -90)
		{
			if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF != 68)
			{
				if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF == -93)
				{
					this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = -6;
				}
			}
			else
			{
				this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = -60;
			}
		}
		else if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF != -55)
		{
			if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF == -83)
			{
				this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = 6;
			}
		}
		else
		{
			this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = -76;
		}
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length - 0, 0);
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.ToString();
		this.\u02B6\u02BF\u02B5\u02B6\u02C1\u02BC\u02BB\u02B4\u02B6\u02B5\u02B3 = true;
	}

	// Token: 0x06001706 RID: 5894 RVA: 0x000AF7D4 File Offset: 0x000AD9D4
	public void \u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		this.\u02BC\u02B5\u02B4\u02B7\u02BB\u02BF\u02B7\u02B9\u02BA\u02B6\u02BA();
		if (this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF == null)
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF = new StringBuilder(this.maxCharacterCount);
		}
		else
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(0, this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length);
		}
		if (this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF == null)
		{
			this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = base.GetComponent<Text>();
		}
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(0, this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length);
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.ToString();
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;
	}

	// Token: 0x06001707 RID: 5895 RVA: 0x00011EFE File Offset: 0x000100FE
	private bool \u02C0\u02B7\u02B4\u02B6\u02B6\u02B9\u02BF\u02B9\u02B4\u02C0\u02B5()
	{
		return this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length < this.maxCharacterCount;
	}

	// Token: 0x06001708 RID: 5896 RVA: 0x000AF9DC File Offset: 0x000ADBDC
	private void \u02BE\u02B3\u02B3\u02BD\u02BC\u02B5\u02B7\u02C1\u02BF\u02B3\u02B5()
	{
		this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF++;
		int u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF = this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF;
		if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF <= 91)
		{
			if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF != 58)
			{
				if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF == 91)
				{
					this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = 97;
				}
			}
			else
			{
				this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = 65;
			}
		}
		else if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF != 96)
		{
			if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF == 123)
			{
				this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = 48;
			}
		}
		else
		{
			this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = 65;
		}
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length - 1, 1);
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.ToString();
		this.\u02B6\u02BF\u02B5\u02B6\u02C1\u02BC\u02BB\u02B4\u02B6\u02B5\u02B3 = true;
	}

	// Token: 0x06001709 RID: 5897 RVA: 0x000AFA8C File Offset: 0x000ADC8C
	private void \u02BD\u02BB\u02BE\u02B4\u02BC\u02BE\u02BB\u02B8\u02BC\u02B4\u02B9()
	{
		this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF--;
		int u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF = this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF;
		if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF <= 64)
		{
			if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF != 47)
			{
				if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF == 64)
				{
					this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = 57;
				}
			}
			else
			{
				this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = 122;
			}
		}
		else if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF != 94)
		{
			if (u02BF_u02C1_u02B3_u02BF_u02C1_u02B7_u02B8_u02B6_u02BB_u02B7_u02BF == 96)
			{
				this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = 90;
			}
		}
		else
		{
			this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = 57;
		}
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length - 1, 1);
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.ToString();
		this.\u02B6\u02BF\u02B5\u02B6\u02C1\u02BC\u02BB\u02B4\u02B6\u02B5\u02B3 = true;
	}

	// Token: 0x0600170A RID: 5898 RVA: 0x00011F16 File Offset: 0x00010116
	private void \u02B2\u02B4\u02BD\u02BB\u02BC\u02B4\u02B7\u02B2\u02BF\u02BF\u02B3()
	{
		this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = 98;
	}

	// Token: 0x0600170B RID: 5899 RVA: 0x00011F20 File Offset: 0x00010120
	private void \u02BC\u02B5\u02B4\u02B7\u02BB\u02BF\u02B7\u02B9\u02BA\u02B6\u02BA()
	{
		this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF = 95;
	}

	// Token: 0x0600170C RID: 5900 RVA: 0x00011EE6 File Offset: 0x000100E6
	private bool \u02C0\u02C1\u02BD\u02BF\u02C0\u02B7\u02B5\u02BC\u02B6\u02B4\u02B6()
	{
		return this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length >= this.maxCharacterCount;
	}

	// Token: 0x0600170D RID: 5901 RVA: 0x000AFB3C File Offset: 0x000ADD3C
	private void \u02BA\u02BF\u02B3\u02B6\u02C0\u02BF\u02B7\u02BB\u02B9\u02B2\u02BB()
	{
		this.\u02BC\u02B5\u02B4\u02B7\u02BB\u02BF\u02B7\u02B9\u02BA\u02B6\u02BA();
		if (this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length == 1)
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF[0] = (char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF;
		}
		else
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length - 1, 1);
		}
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.ToString();
	}

	// Token: 0x0600170E RID: 5902 RVA: 0x000AFBB8 File Offset: 0x000ADDB8
	public void \u02B8\u02B7\u02B7\u02B8\u02BA\u02BF\u02BE\u02BE\u02B8\u02C0\u02BD(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		this.\u02BC\u02B5\u02B4\u02B7\u02BB\u02BF\u02B7\u02B9\u02BA\u02B6\u02BA();
		if (this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF == null)
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF = new StringBuilder(this.maxCharacterCount);
		}
		else
		{
			this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(0, this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length);
		}
		if (this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF == null)
		{
			this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF = base.GetComponent<Text>();
		}
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Remove(1, this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Length);
		this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.Append((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		this.\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.text = this.\u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF.ToString();
		this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4 = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x000AFC60 File Offset: 0x000ADE60
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			this.\u02BD\u02BB\u02BE\u02B4\u02BC\u02BE\u02BB\u02B8\u02BC\u02B4\u02B9();
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			this.\u02BE\u02B3\u02B3\u02BD\u02BC\u02B5\u02B7\u02C1\u02BF\u02B3\u02B5();
		}
		if (Input.GetKeyDown(KeyCode.F1))
		{
			this.\u02BC\u02B3\u02B2\u02BB\u02BD\u02BF\u02C1\u02B4\u02B2\u02C1\u02B2((char)this.\u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF);
		}
		foreach (char c in Input.inputString)
		{
			if (c == '\b')
			{
				this.\u02BA\u02BF\u02B3\u02B6\u02C0\u02BF\u02B7\u02BB\u02B9\u02B2\u02BB();
			}
			else
			{
				this.\u02BC\u02B3\u02B2\u02BB\u02BD\u02BF\u02C1\u02B4\u02B2\u02C1\u02B2(c);
			}
		}
	}

	// Token: 0x040010A1 RID: 4257
	private Text \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF;

	// Token: 0x040010A2 RID: 4258
	private int \u02BF\u02C1\u02B3\u02BF\u02C1\u02B7\u02B8\u02B6\u02BB\u02B7\u02BF;

	// Token: 0x040010A3 RID: 4259
	private int \u02B4\u02BC\u02BE\u02B2\u02B2\u02B8\u02BA\u02B4\u02BF\u02BD\u02B5;

	// Token: 0x040010A4 RID: 4260
	[SerializeField]
	private string defaultString;

	// Token: 0x040010A5 RID: 4261
	[SerializeField]
	private int maxCharacterCount;

	// Token: 0x040010A6 RID: 4262
	[HideInInspector]
	public \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4;

	// Token: 0x040010A7 RID: 4263
	private Coroutine \u02BB\u02B2\u02B8\u02B7\u02B9\u02B7\u02BA\u02B3\u02BA\u02C1\u02B6;

	// Token: 0x040010A8 RID: 4264
	private StringBuilder \u02BB\u02BC\u02BE\u02BA\u02B2\u02B8\u02B5\u02BF\u02BA\u02B2\u02BF;

	// Token: 0x040010A9 RID: 4265
	private bool \u02B6\u02BF\u02B5\u02B6\u02C1\u02BC\u02BB\u02B4\u02B6\u02B5\u02B3;
}
