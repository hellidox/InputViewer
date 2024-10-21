using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000052 RID: 82
public class \u02B2\u02B3\u02B5\u02BD\u02B9\u02B2\u02BA\u02B3\u02B6\u02B8\u02C0
{
	// Token: 0x17000035 RID: 53
	// (get) Token: 0x0600036E RID: 878 RVA: 0x00007BC2 File Offset: 0x00005DC2
	public bool \u02C0\u02BE\u02C1\u02C0\u02B3\u02BC\u02BE\u02B5\u02BE\u02B5\u02B5
	{
		get
		{
			return this.\u02BE\u02B2\u02B4\u02B8\u02BB\u02BD\u02C1\u02BD\u02BC\u02BA\u02BE.Count <= 0;
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x0600036F RID: 879 RVA: 0x00007BD5 File Offset: 0x00005DD5
	public Dictionary<string, string> \u02BE\u02B2\u02B4\u02B8\u02BB\u02BD\u02C1\u02BD\u02BC\u02BA\u02BE
	{
		get
		{
			if (this.\u02BF\u02BD\u02C1\u02BB\u02B7\u02BF\u02BF\u02BB\u02B9\u02B8\u02B4 == null)
			{
				this.\u02BF\u02BD\u02C1\u02BB\u02B7\u02BF\u02BF\u02BB\u02B9\u02B8\u02B4 = new Dictionary<string, string>();
			}
			return this.\u02BF\u02BD\u02C1\u02BB\u02B7\u02BF\u02BF\u02BB\u02B9\u02B8\u02B4;
		}
	}

	// Token: 0x06000370 RID: 880 RVA: 0x0002B920 File Offset: 0x00029B20
	public void \u02B6\u02C1\u02B5\u02B5\u02B7\u02BB\u02B7\u02C0\u02C1\u02B5\u02B9(string \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF)
	{
		this.\u02BE\u02B2\u02B4\u02B8\u02BB\u02BD\u02C1\u02BD\u02BC\u02BA\u02BE.Clear();
		if (\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF == null || \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.Length == 0)
		{
			return;
		}
		string[] array = \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.Split('\n', StringSplitOptions.None);
		string[] array2 = new string[] { "'='" };
		try
		{
			string[] array3 = array;
			for (int i = 0; i < array3.Length; i++)
			{
				string[] array4 = array3[i].Split(array2, StringSplitOptions.None);
				if (array4 != null && array4.Length >= 2)
				{
					this.\u02BE\u02B2\u02B4\u02B8\u02BB\u02BD\u02C1\u02BD\u02BC\u02BA\u02BE.Add(array4[0].Trim(), array4[1].Replace(" %n ", "\n").Trim());
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
		}
	}

	// Token: 0x06000371 RID: 881 RVA: 0x00007BF0 File Offset: 0x00005DF0
	public bool \u02B9\u02BD\u02BA\u02BC\u02B9\u02B7\u02B3\u02B3\u02B6\u02BC\u02C0(string \u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB)
	{
		return this.\u02BE\u02B2\u02B4\u02B8\u02BB\u02BD\u02C1\u02BD\u02BC\u02BA\u02BE.ContainsKey(\u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB);
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00007BFE File Offset: 0x00005DFE
	public string \u02B3\u02C1\u02BE\u02BC\u02BC\u02B7\u02B8\u02B3\u02B2\u02C0\u02BB(string \u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB)
	{
		if (\u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB == "" || this.\u02C0\u02BE\u02C1\u02C0\u02B3\u02BC\u02BE\u02B5\u02BE\u02B5\u02B5)
		{
			return "";
		}
		if (!this.\u02BE\u02B2\u02B4\u02B8\u02BB\u02BD\u02C1\u02BD\u02BC\u02BA\u02BE.ContainsKey(\u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB))
		{
			return \u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB;
		}
		return this.\u02BE\u02B2\u02B4\u02B8\u02BB\u02BD\u02C1\u02BD\u02BC\u02BA\u02BE[\u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB];
	}

	// Token: 0x04000259 RID: 601
	private Dictionary<string, string> \u02BF\u02BD\u02C1\u02BB\u02B7\u02BF\u02BF\u02BB\u02B9\u02B8\u02B4 = new Dictionary<string, string>();
}
