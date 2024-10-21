using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000056 RID: 86
public class \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4
{
	// Token: 0x1700003A RID: 58
	// (get) Token: 0x0600038D RID: 909 RVA: 0x00007D0A File Offset: 0x00005F0A
	// (set) Token: 0x0600038E RID: 910 RVA: 0x00007D11 File Offset: 0x00005F11
	public static int \u02B3\u02B3\u02C1\u02B4\u02B8\u02BA\u02B3\u02B4\u02B9\u02B2\u02B6 { get; private set; }

	// Token: 0x0600038F RID: 911 RVA: 0x00007D19 File Offset: 0x00005F19
	public static IEnumerator \u02BF\u02B4\u02C0\u02B8\u02C1\u02C0\u02B9\u02BC\u02B3\u02BC\u02BF(string \u02C0\u02BD\u02C0\u02B7\u02BA\u02B7\u02BE\u02BA\u02B9\u02BA\u02B9, \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02BB\u02B9\u02B7\u02BE\u02BD\u02BE\u02B6\u02BB\u02BB\u02BC\u02BD \u02BC\u02B5\u02B7\u02B7\u02B8\u02B4\u02BF\u02BB\u02B3\u02B2\u02B8)
	{
		using (UnityWebRequest request = UnityWebRequest.Get(\u02C0\u02BD\u02C0\u02B7\u02BA\u02B7\u02BE\u02BA\u02B9\u02BA\u02B9))
		{
			request.timeout = 5;
			\u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02B3\u02B3\u02C1\u02B4\u02B8\u02BA\u02B3\u02B4\u02B9\u02B2\u02B6++;
			yield return request.SendWebRequest();
			if (request.result == UnityWebRequest.Result.Success && request.isDone)
			{
				\u02BC\u02B5\u02B7\u02B7\u02B8\u02B4\u02BF\u02BB\u02B3\u02B2\u02B8(request.downloadHandler.text);
			}
			else
			{
				Debug.LogError(request.error);
			}
			\u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02B3\u02B3\u02C1\u02B4\u02B8\u02BA\u02B3\u02B4\u02B9\u02B2\u02B6--;
		}
		UnityWebRequest request = null;
		yield break;
		yield break;
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00007D2F File Offset: 0x00005F2F
	public static IEnumerator \u02BF\u02B4\u02C0\u02B8\u02C1\u02C0\u02B9\u02BC\u02B3\u02BC\u02BF(string \u02C0\u02BD\u02C0\u02B7\u02BA\u02B7\u02BE\u02BA\u02B9\u02BA\u02B9, \u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02B2\u02BF\u02B7\u02B7\u02BC\u02B2\u02B7\u02BB\u02BC\u02B3\u02B3 \u02BC\u02B5\u02B7\u02B7\u02B8\u02B4\u02BF\u02BB\u02B3\u02B2\u02B8)
	{
		using (UnityWebRequest request = UnityWebRequest.Get(\u02C0\u02BD\u02C0\u02B7\u02BA\u02B7\u02BE\u02BA\u02B9\u02BA\u02B9))
		{
			request.timeout = 5;
			\u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02B3\u02B3\u02C1\u02B4\u02B8\u02BA\u02B3\u02B4\u02B9\u02B2\u02B6++;
			yield return request.SendWebRequest();
			if (request.result == UnityWebRequest.Result.Success && request.isDone)
			{
				\u02BC\u02B5\u02B7\u02B7\u02B8\u02B4\u02BF\u02BB\u02B3\u02B2\u02B8(request.downloadHandler.data);
			}
			else
			{
				Debug.LogError(request.error);
			}
			\u02C1\u02BD\u02B5\u02B3\u02BA\u02BF\u02BA\u02B3\u02B2\u02B4\u02B4.\u02B3\u02B3\u02C1\u02B4\u02B8\u02BA\u02B3\u02B4\u02B9\u02B2\u02B6--;
		}
		UnityWebRequest request = null;
		yield break;
		yield break;
	}

	// Token: 0x02000057 RID: 87
	// (Invoke) Token: 0x06000392 RID: 914
	public delegate void \u02BB\u02B9\u02B7\u02BE\u02BD\u02BE\u02B6\u02BB\u02BB\u02BC\u02BD(string \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0);

	// Token: 0x02000058 RID: 88
	// (Invoke) Token: 0x06000394 RID: 916
	public delegate void \u02B2\u02BF\u02B7\u02B7\u02BC\u02B2\u02B7\u02BB\u02BC\u02B3\u02B3(byte[] \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0);
}
