using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.Services.Analytics;
using UnityEngine;

// Token: 0x02000017 RID: 23
public static class \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA
{
	// Token: 0x0600010F RID: 271 RVA: 0x0001E01C File Offset: 0x0001C21C
	public static async Task \u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC()
	{
		try
		{
			TaskAwaiter<List<string>> taskAwaiter = AnalyticsService.Instance.CheckForRequiredConsents().GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<List<string>> taskAwaiter2;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<List<string>>);
			}
			\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B6\u02BF\u02B7\u02B3\u02B5\u02B8\u02B9\u02C0\u02B5\u02BE\u02B3 = taskAwaiter.GetResult();
			if (\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B6\u02BF\u02B7\u02B3\u02B5\u02B8\u02B9\u02C0\u02B5\u02BE\u02B3.Count > 0)
			{
				\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B6\u02B4\u02BA\u02B7\u02BC\u02B3\u02BB\u02BA\u02B9\u02BA\u02B2 = \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B6\u02BF\u02B7\u02B3\u02B5\u02B8\u02B9\u02C0\u02B5\u02BE\u02B3[0];
				\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BF\u02BB\u02B4\u02B5\u02B9\u02B4\u02B5\u02C1\u02B4\u02BC\u02B6 = \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B6\u02B4\u02BA\u02B7\u02BC\u02B3\u02BB\u02BA\u02B9\u02BA\u02B2 == "pipl";
			}
		}
		catch (ConsentCheckException)
		{
		}
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0000669B File Offset: 0x0000489B
	public static void \u02BA\u02B4\u02B6\u02C1\u02BC\u02BF\u02BE\u02BD\u02BD\u02B7\u02C0()
	{
		if (\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BF\u02BB\u02B4\u02B5\u02B9\u02B4\u02B5\u02C1\u02B4\u02BC\u02B6)
		{
			AnalyticsService.Instance.ProvideOptInConsent(\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B6\u02B4\u02BA\u02B7\u02BC\u02B3\u02BB\u02BA\u02B9\u02BA\u02B2, true);
		}
	}

	// Token: 0x06000111 RID: 273 RVA: 0x0001E058 File Offset: 0x0001C258
	public static void \u02BE\u02BF\u02B4\u02B3\u02B5\u02B8\u02BA\u02BC\u02B2\u02B7\u02C0()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B5\u02BC\u02B4\u02B3\u02C0\u02C1\u02BB\u02BE\u02B2\u02BF = PlayerPrefs.GetInt("analytics-opt-out") == 1;
		if (\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B5\u02BC\u02B4\u02B3\u02C0\u02C1\u02BB\u02BE\u02B2\u02BF)
		{
			return;
		}
		PlayerPrefs.SetInt("analytics-opt-out", 1);
		if (\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BF\u02BB\u02B4\u02B5\u02B9\u02B4\u02B5\u02C1\u02B4\u02BC\u02B6)
		{
			AnalyticsService.Instance.ProvideOptInConsent(\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B6\u02B4\u02BA\u02B7\u02BC\u02B3\u02BB\u02BA\u02B9\u02BA\u02B2, false);
			return;
		}
		AnalyticsService.Instance.OptOut();
	}

	// Token: 0x06000112 RID: 274 RVA: 0x000066B4 File Offset: 0x000048B4
	public static string \u02B5\u02B4\u02B9\u02B3\u02BB\u02C0\u02B9\u02B5\u02BF\u02BC\u02BA()
	{
		return AnalyticsService.Instance.PrivacyUrl;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x000066C0 File Offset: 0x000048C0
	public static void \u02C1\u02B6\u02B3\u02C0\u02B4\u02BB\u02BF\u02BF\u02B7\u02B2\u02C0(string \u02BF\u02BE\u02B7\u02B8\u02B4\u02BE\u02BE\u02BB\u02B5\u02B5\u02B2, Dictionary<string, object> \u02B2\u02B2\u02BA\u02B3\u02B5\u02BD\u02B2\u02B5\u02B5\u02BE\u02BE)
	{
		AnalyticsService.Instance.CustomData(\u02BF\u02BE\u02B7\u02B8\u02B4\u02BE\u02BE\u02BB\u02B5\u02B5\u02B2, \u02B2\u02B2\u02BA\u02B3\u02B5\u02BD\u02B2\u02B5\u02B5\u02BE\u02BE);
	}

	// Token: 0x04000062 RID: 98
	public static bool \u02BF\u02BB\u02B4\u02B5\u02B9\u02B4\u02B5\u02C1\u02B4\u02BC\u02B6;

	// Token: 0x04000063 RID: 99
	public static bool \u02BA\u02B5\u02BC\u02B4\u02B3\u02C0\u02C1\u02BB\u02BE\u02B2\u02BF;

	// Token: 0x04000064 RID: 100
	private static string \u02B6\u02B4\u02BA\u02B7\u02BC\u02B3\u02BB\u02BA\u02B9\u02BA\u02B2;

	// Token: 0x04000065 RID: 101
	private static List<string> \u02B6\u02BF\u02B7\u02B3\u02B5\u02B8\u02B9\u02C0\u02B5\u02BE\u02B3;
}
