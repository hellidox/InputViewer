using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x0200007E RID: 126
public class BuildCheck : MonoBehaviour
{
	// Token: 0x06000519 RID: 1305 RVA: 0x0000884D File Offset: 0x00006A4D
	private void \u02B2\u02BB\u02B6\u02B5\u02B9\u02B8\u02B2\u02B3\u02BF\u02C1\u02BF()
	{
		if (this.\u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.\u02B2\u02B8\u02B7\u02BE\u02BA\u02BD\u02B6\u02B9\u02C1\u02B7\u02BC());
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x0000886C File Offset: 0x00006A6C
	private void \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		if (this.\u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB)
		{
			base.enabled = true;
			return;
		}
		base.StartCoroutine(this.\u02B6\u02BF\u02BD\u02B6\u02B9\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF());
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x0000888B File Offset: 0x00006A8B
	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		if (this.\u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB)
		{
			base.enabled = true;
			return;
		}
		base.StartCoroutine(this.\u02B7\u02BD\u02B4\u02BB\u02BD\u02B5\u02B4\u02B9\u02B4\u02BE\u02BA());
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x000088AA File Offset: 0x00006AAA
	private IEnumerator \u02BD\u02BD\u02B4\u02BF\u02B7\u02BE\u02C0\u02B8\u02B6\u02B8\u02BD()
	{
		BuildCheck.\u02B3\u02BB\u02BB\u02B2\u02B9\u02B2\u02B2\u02B4\u02B4\u02BE\u02B2 u02B3_u02BB_u02BB_u02B2_u02B9_u02B2_u02B2_u02B4_u02B4_u02BE_u02B = new BuildCheck.\u02B3\u02BB\u02BB\u02B2\u02B9\u02B2\u02B2\u02B4\u02B4\u02BE\u02B2(1);
		u02B3_u02BB_u02BB_u02B2_u02B9_u02B2_u02B2_u02B4_u02B4_u02BE_u02B.<>4__this = this;
		return u02B3_u02BB_u02BB_u02B2_u02B9_u02B2_u02B2_u02B4_u02B4_u02BE_u02B;
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x000088B9 File Offset: 0x00006AB9
	private void Start()
	{
		if (this.\u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.\u02BA\u02B6\u02BA\u02B6\u02BE\u02C1\u02B9\u02B8\u02BB\u02B3\u02BE());
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x000088D8 File Offset: 0x00006AD8
	private IEnumerator \u02B5\u02B8\u02B9\u02BB\u02BE\u02C0\u02B6\u02BC\u02C0\u02B6\u02BB()
	{
		UnityWebRequest www = UnityWebRequest.Get(this.\u02C0\u02BC\u02B6\u02B9\u02B7\u02BC\u02B8\u02B2\u02BB\u02C1\u02B4);
		yield return www.SendWebRequest();
		if (!www.isNetworkError)
		{
			try
			{
				this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2 = JsonUtility.FromJson<BuildVersion>(www.downloadHandler.text);
			}
			catch (ArgumentException ex)
			{
				MonoBehaviour.print(ex.Message);
			}
			if (this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2 != null)
			{
				yield return null;
				if (this.\u02B4\u02B8\u02B9\u02BB\u02B9\u02BB\u02BB\u02BD\u02BD\u02B4\u02C0 <= this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1())
				{
					if (this.\u02BB\u02B7\u02B9\u02C1\u02BD\u02BB\u02BB\u02BB\u02B2\u02B7\u02B9 <= this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2())
					{
						if (this.\u02BE\u02BE\u02BE\u02BB\u02BF\u02B3\u02B9\u02B6\u02BD\u02B8\u02BC < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B2\u02BA\u02C1\u02BE\u02B5\u02BE\u02B4\u02BB\u02C1\u02BA\u02B4())
						{
							this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
						}
						if (this.\u02BB\u02B7\u02B9\u02C1\u02BD\u02BB\u02BB\u02BB\u02B2\u02B7\u02B9 < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2())
						{
							this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
						}
					}
					if (this.\u02B4\u02B8\u02B9\u02BB\u02B9\u02BB\u02BB\u02BD\u02BD\u02B4\u02C0 < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1())
					{
						this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
					}
				}
				if (this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6)
				{
					this.\u02BB\u02BD\u02B4\u02C0\u02BE\u02B4\u02BD\u02BD\u02B4\u02BD\u02BB = this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.download;
				}
			}
		}
		yield break;
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x000088D8 File Offset: 0x00006AD8
	private IEnumerator \u02BA\u02B6\u02BA\u02B6\u02BE\u02C1\u02B9\u02B8\u02BB\u02B3\u02BE()
	{
		www = UnityWebRequest.Get(this.\u02C0\u02BC\u02B6\u02B9\u02B7\u02BC\u02B8\u02B2\u02BB\u02C1\u02B4);
		yield return www.SendWebRequest();
		if (!www.isNetworkError)
		{
			try
			{
				this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2 = JsonUtility.FromJson<BuildVersion>(www.downloadHandler.text);
			}
			catch (ArgumentException ex)
			{
				MonoBehaviour.print(ex.Message);
			}
			if (this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2 != null)
			{
				yield return null;
				if (this.\u02B4\u02B8\u02B9\u02BB\u02B9\u02BB\u02BB\u02BD\u02BD\u02B4\u02C0 <= this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1())
				{
					if (this.\u02BB\u02B7\u02B9\u02C1\u02BD\u02BB\u02BB\u02BB\u02B2\u02B7\u02B9 <= this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2())
					{
						if (this.\u02BE\u02BE\u02BE\u02BB\u02BF\u02B3\u02B9\u02B6\u02BD\u02B8\u02BC < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B2\u02BA\u02C1\u02BE\u02B5\u02BE\u02B4\u02BB\u02C1\u02BA\u02B4())
						{
							this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
						}
						if (this.\u02BB\u02B7\u02B9\u02C1\u02BD\u02BB\u02BB\u02BB\u02B2\u02B7\u02B9 < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2())
						{
							this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
						}
					}
					if (this.\u02B4\u02B8\u02B9\u02BB\u02B9\u02BB\u02BB\u02BD\u02BD\u02B4\u02C0 < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1())
					{
						this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
					}
				}
				if (this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6)
				{
					this.\u02BB\u02BD\u02B4\u02C0\u02BE\u02B4\u02BD\u02BD\u02B4\u02BD\u02BB = this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.download;
				}
			}
		}
		yield break;
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x000088D8 File Offset: 0x00006AD8
	private IEnumerator \u02B7\u02BD\u02B4\u02BB\u02BD\u02B5\u02B4\u02B9\u02B4\u02BE\u02BA()
	{
		www = UnityWebRequest.Get(this.\u02C0\u02BC\u02B6\u02B9\u02B7\u02BC\u02B8\u02B2\u02BB\u02C1\u02B4);
		yield return www.SendWebRequest();
		if (!www.isNetworkError)
		{
			try
			{
				this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2 = JsonUtility.FromJson<BuildVersion>(www.downloadHandler.text);
			}
			catch (ArgumentException ex)
			{
				MonoBehaviour.print(ex.Message);
			}
			if (this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2 != null)
			{
				yield return null;
				if (this.\u02B4\u02B8\u02B9\u02BB\u02B9\u02BB\u02BB\u02BD\u02BD\u02B4\u02C0 <= this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1())
				{
					if (this.\u02BB\u02B7\u02B9\u02C1\u02BD\u02BB\u02BB\u02BB\u02B2\u02B7\u02B9 <= this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2())
					{
						if (this.\u02BE\u02BE\u02BE\u02BB\u02BF\u02B3\u02B9\u02B6\u02BD\u02B8\u02BC < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B2\u02BA\u02C1\u02BE\u02B5\u02BE\u02B4\u02BB\u02C1\u02BA\u02B4())
						{
							this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
						}
						if (this.\u02BB\u02B7\u02B9\u02C1\u02BD\u02BB\u02BB\u02BB\u02B2\u02B7\u02B9 < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2())
						{
							this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
						}
					}
					if (this.\u02B4\u02B8\u02B9\u02BB\u02B9\u02BB\u02BB\u02BD\u02BD\u02B4\u02C0 < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1())
					{
						this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
					}
				}
				if (this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6)
				{
					this.\u02BB\u02BD\u02B4\u02C0\u02BE\u02B4\u02BD\u02BD\u02B4\u02BD\u02BB = this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.download;
				}
			}
		}
		yield break;
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x000088AA File Offset: 0x00006AAA
	private IEnumerator \u02B2\u02C0\u02B5\u02BC\u02B9\u02B7\u02B3\u02BE\u02BD\u02BC\u02BB()
	{
		BuildCheck.\u02B3\u02BB\u02BB\u02B2\u02B9\u02B2\u02B2\u02B4\u02B4\u02BE\u02B2 u02B3_u02BB_u02BB_u02B2_u02B9_u02B2_u02B2_u02B4_u02B4_u02BE_u02B = new BuildCheck.\u02B3\u02BB\u02BB\u02B2\u02B9\u02B2\u02B2\u02B4\u02B4\u02BE\u02B2(1);
		u02B3_u02BB_u02BB_u02B2_u02B9_u02B2_u02B2_u02B4_u02B4_u02BE_u02B.<>4__this = this;
		return u02B3_u02BB_u02BB_u02B2_u02B9_u02B2_u02B2_u02B4_u02B4_u02BE_u02B;
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x0000888B File Offset: 0x00006A8B
	private void \u02B2\u02B7\u02B5\u02C0\u02B4\u02B3\u02B8\u02B3\u02C0\u02BD\u02B5()
	{
		if (this.\u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB)
		{
			base.enabled = true;
			return;
		}
		base.StartCoroutine(this.\u02B7\u02BD\u02B4\u02BB\u02BD\u02B5\u02B4\u02B9\u02B4\u02BE\u02BA());
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x000088D8 File Offset: 0x00006AD8
	private IEnumerator \u02B2\u02B8\u02BD\u02B2\u02B9\u02BB\u02C0\u02B3\u02BB\u02BB\u02BB()
	{
		www = UnityWebRequest.Get(this.\u02C0\u02BC\u02B6\u02B9\u02B7\u02BC\u02B8\u02B2\u02BB\u02C1\u02B4);
		yield return www.SendWebRequest();
		if (!www.isNetworkError)
		{
			try
			{
				this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2 = JsonUtility.FromJson<BuildVersion>(www.downloadHandler.text);
			}
			catch (ArgumentException ex)
			{
				MonoBehaviour.print(ex.Message);
			}
			if (this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2 != null)
			{
				yield return null;
				if (this.\u02B4\u02B8\u02B9\u02BB\u02B9\u02BB\u02BB\u02BD\u02BD\u02B4\u02C0 <= this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1())
				{
					if (this.\u02BB\u02B7\u02B9\u02C1\u02BD\u02BB\u02BB\u02BB\u02B2\u02B7\u02B9 <= this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2())
					{
						if (this.\u02BE\u02BE\u02BE\u02BB\u02BF\u02B3\u02B9\u02B6\u02BD\u02B8\u02BC < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B2\u02BA\u02C1\u02BE\u02B5\u02BE\u02B4\u02BB\u02C1\u02BA\u02B4())
						{
							this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
						}
						if (this.\u02BB\u02B7\u02B9\u02C1\u02BD\u02BB\u02BB\u02BB\u02B2\u02B7\u02B9 < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2())
						{
							this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
						}
					}
					if (this.\u02B4\u02B8\u02B9\u02BB\u02B9\u02BB\u02BB\u02BD\u02BD\u02B4\u02C0 < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1())
					{
						this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
					}
				}
				if (this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6)
				{
					this.\u02BB\u02BD\u02B4\u02C0\u02BE\u02B4\u02BD\u02BD\u02B4\u02BD\u02BB = this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.download;
				}
			}
		}
		yield break;
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x000088D8 File Offset: 0x00006AD8
	private IEnumerator \u02B2\u02B8\u02B7\u02BE\u02BA\u02BD\u02B6\u02B9\u02C1\u02B7\u02BC()
	{
		www = UnityWebRequest.Get(this.\u02C0\u02BC\u02B6\u02B9\u02B7\u02BC\u02B8\u02B2\u02BB\u02C1\u02B4);
		yield return www.SendWebRequest();
		if (!www.isNetworkError)
		{
			try
			{
				this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2 = JsonUtility.FromJson<BuildVersion>(www.downloadHandler.text);
			}
			catch (ArgumentException ex)
			{
				MonoBehaviour.print(ex.Message);
			}
			if (this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2 != null)
			{
				yield return null;
				if (this.\u02B4\u02B8\u02B9\u02BB\u02B9\u02BB\u02BB\u02BD\u02BD\u02B4\u02C0 <= this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1())
				{
					if (this.\u02BB\u02B7\u02B9\u02C1\u02BD\u02BB\u02BB\u02BB\u02B2\u02B7\u02B9 <= this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2())
					{
						if (this.\u02BE\u02BE\u02BE\u02BB\u02BF\u02B3\u02B9\u02B6\u02BD\u02B8\u02BC < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B2\u02BA\u02C1\u02BE\u02B5\u02BE\u02B4\u02BB\u02C1\u02BA\u02B4())
						{
							this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
						}
						if (this.\u02BB\u02B7\u02B9\u02C1\u02BD\u02BB\u02BB\u02BB\u02B2\u02B7\u02B9 < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2())
						{
							this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
						}
					}
					if (this.\u02B4\u02B8\u02B9\u02BB\u02B9\u02BB\u02BB\u02BD\u02BD\u02B4\u02C0 < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1())
					{
						this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
					}
				}
				if (this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6)
				{
					this.\u02BB\u02BD\u02B4\u02C0\u02BE\u02B4\u02BD\u02BD\u02B4\u02BD\u02BB = this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.download;
				}
			}
		}
		yield break;
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x000088D8 File Offset: 0x00006AD8
	private IEnumerator \u02BE\u02BE\u02BE\u02BA\u02C0\u02B5\u02B3\u02BC\u02BA\u02C0\u02B5()
	{
		www = UnityWebRequest.Get(this.\u02C0\u02BC\u02B6\u02B9\u02B7\u02BC\u02B8\u02B2\u02BB\u02C1\u02B4);
		yield return www.SendWebRequest();
		if (!www.isNetworkError)
		{
			try
			{
				this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2 = JsonUtility.FromJson<BuildVersion>(www.downloadHandler.text);
			}
			catch (ArgumentException ex)
			{
				MonoBehaviour.print(ex.Message);
			}
			if (this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2 != null)
			{
				yield return null;
				if (this.\u02B4\u02B8\u02B9\u02BB\u02B9\u02BB\u02BB\u02BD\u02BD\u02B4\u02C0 <= this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1())
				{
					if (this.\u02BB\u02B7\u02B9\u02C1\u02BD\u02BB\u02BB\u02BB\u02B2\u02B7\u02B9 <= this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2())
					{
						if (this.\u02BE\u02BE\u02BE\u02BB\u02BF\u02B3\u02B9\u02B6\u02BD\u02B8\u02BC < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B2\u02BA\u02C1\u02BE\u02B5\u02BE\u02B4\u02BB\u02C1\u02BA\u02B4())
						{
							this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
						}
						if (this.\u02BB\u02B7\u02B9\u02C1\u02BD\u02BB\u02BB\u02BB\u02B2\u02B7\u02B9 < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2())
						{
							this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
						}
					}
					if (this.\u02B4\u02B8\u02B9\u02BB\u02B9\u02BB\u02BB\u02BD\u02BD\u02B4\u02C0 < this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1())
					{
						this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6 = true;
					}
				}
				if (this.\u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6)
				{
					this.\u02BB\u02BD\u02B4\u02C0\u02BE\u02B4\u02BD\u02BD\u02B4\u02BD\u02BB = this.\u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2.download;
				}
			}
		}
		yield break;
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x000088AA File Offset: 0x00006AAA
	private IEnumerator \u02B6\u02BF\u02BD\u02B6\u02B9\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF()
	{
		BuildCheck.\u02B3\u02BB\u02BB\u02B2\u02B9\u02B2\u02B2\u02B4\u02B4\u02BE\u02B2 u02B3_u02BB_u02BB_u02B2_u02B9_u02B2_u02B2_u02B4_u02B4_u02BE_u02B = new BuildCheck.\u02B3\u02BB\u02BB\u02B2\u02B9\u02B2\u02B2\u02B4\u02B4\u02BE\u02B2(1);
		u02B3_u02BB_u02BB_u02B2_u02B9_u02B2_u02B2_u02B4_u02B4_u02BE_u02B.<>4__this = this;
		return u02B3_u02BB_u02BB_u02B2_u02B9_u02B2_u02B2_u02B4_u02B4_u02BE_u02B;
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x000088E7 File Offset: 0x00006AE7
	private void \u02B4\u02B2\u02B5\u02BA\u02B4\u02C0\u02BC\u02BB\u02C1\u02B9\u02BD()
	{
		if (this.\u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB)
		{
			base.enabled = true;
			return;
		}
		base.StartCoroutine(this.\u02B2\u02C0\u02B5\u02BC\u02B9\u02B7\u02B3\u02BE\u02BD\u02BC\u02BB());
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x00008906 File Offset: 0x00006B06
	private void \u02C0\u02BC\u02BC\u02BD\u02B8\u02BD\u02BE\u02B6\u02BE\u02BB\u02BB()
	{
		if (this.\u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB)
		{
			base.enabled = true;
			return;
		}
		base.StartCoroutine(this.\u02B5\u02B8\u02B9\u02BB\u02BE\u02C0\u02B6\u02BC\u02C0\u02B6\u02BB());
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x000088AA File Offset: 0x00006AAA
	private IEnumerator \u02C0\u02C1\u02C1\u02B3\u02BF\u02BE\u02BC\u02B6\u02BC\u02C1\u02B7()
	{
		BuildCheck.\u02B3\u02BB\u02BB\u02B2\u02B9\u02B2\u02B2\u02B4\u02B4\u02BE\u02B2 u02B3_u02BB_u02BB_u02B2_u02B9_u02B2_u02B2_u02B4_u02B4_u02BE_u02B = new BuildCheck.\u02B3\u02BB\u02BB\u02B2\u02B9\u02B2\u02B2\u02B4\u02B4\u02BE\u02B2(1);
		u02B3_u02BB_u02BB_u02B2_u02B9_u02B2_u02B2_u02B4_u02B4_u02BE_u02B.<>4__this = this;
		return u02B3_u02BB_u02BB_u02B2_u02B9_u02B2_u02B2_u02B4_u02B4_u02BE_u02B;
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x00008935 File Offset: 0x00006B35
	private void \u02B5\u02B2\u02BF\u02BD\u02BB\u02BA\u02B2\u02BF\u02BD\u02BE\u02BE()
	{
		if (this.\u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.\u02BE\u02BE\u02BE\u02BA\u02C0\u02B5\u02B3\u02BC\u02BA\u02C0\u02B5());
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x00008954 File Offset: 0x00006B54
	private void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		if (this.\u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.\u02B5\u02B8\u02B9\u02BB\u02BE\u02C0\u02B6\u02BC\u02C0\u02B6\u02BB());
	}

	// Token: 0x040003E7 RID: 999
	public string \u02C0\u02BC\u02B6\u02B9\u02B7\u02BC\u02B8\u02B2\u02BB\u02C1\u02B4;

	// Token: 0x040003E8 RID: 1000
	[HideInInspector]
	public string \u02BB\u02BD\u02B4\u02C0\u02BE\u02B4\u02BD\u02BD\u02B4\u02BD\u02BB;

	// Token: 0x040003E9 RID: 1001
	public int \u02B4\u02B8\u02B9\u02BB\u02B9\u02BB\u02BB\u02BD\u02BD\u02B4\u02C0;

	// Token: 0x040003EA RID: 1002
	public int \u02BB\u02B7\u02B9\u02C1\u02BD\u02BB\u02BB\u02BB\u02B2\u02B7\u02B9 = 22;

	// Token: 0x040003EB RID: 1003
	public int \u02BE\u02BE\u02BE\u02BB\u02BF\u02B3\u02B9\u02B6\u02BD\u02B8\u02BC;

	// Token: 0x040003EC RID: 1004
	public bool \u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB;

	// Token: 0x040003ED RID: 1005
	[NonSerialized]
	public BuildVersion \u02BD\u02C1\u02C0\u02C0\u02B2\u02BB\u02B3\u02B3\u02BD\u02B2\u02B2;

	// Token: 0x040003EE RID: 1006
	[HideInInspector]
	public bool \u02C1\u02BD\u02BA\u02B2\u02B9\u02BE\u02B4\u02B4\u02B4\u02B2\u02B6;
}
