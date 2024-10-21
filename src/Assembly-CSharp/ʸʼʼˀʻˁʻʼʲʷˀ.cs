using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.Services.RemoteConfig;
using UnityEngine;

// Token: 0x0200012B RID: 299
public static class \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0
{
	// Token: 0x1700012C RID: 300
	// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x0000CB64 File Offset: 0x0000AD64
	private static bool \u02B6\u02B7\u02B4\u02B6\u02B8\u02BB\u02B3\u02B3\u02C1\u02BF\u02B2
	{
		[CompilerGenerated]
		set
		{
			\u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.<\u02BD\u02BE\u02B3\u02C1\u02B2\u02BE\u02B4\u02B7\u02B6\u02B6\u02BB>k__BackingField = value;
		}
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x0000CB6C File Offset: 0x0000AD6C
	private static string \u02B8\u02B6\u02B7\u02B8\u02B8\u02BD\u02BC\u02B2\u02B9\u02B4\u02C1(string \u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB, string \u02C0\u02BC\u02B3\u02B4\u02B8\u02B7\u02BD\u02BE\u02B9\u02B9\u02B3)
	{
		return RemoteConfigService.Instance.appConfig.GetString(\u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB, \u02C0\u02BC\u02B3\u02B4\u02B8\u02B7\u02BD\u02BE\u02B9\u02B9\u02B3);
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06000CEB RID: 3307 RVA: 0x0000CB7F File Offset: 0x0000AD7F
	public static string \u02BE\u02BA\u02B8\u02BC\u02B5\u02B7\u02C1\u02C1\u02BA\u02B3\u02B9
	{
		get
		{
			return \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B8\u02B6\u02B7\u02B8\u02B8\u02BD\u02BC\u02B2\u02B9\u02B4\u02C1("latestTestBuild", Application.version);
		}
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0000CB90 File Offset: 0x0000AD90
	public static string \u02B6\u02BB\u02B5\u02BB\u02B2\u02B4\u02C1\u02B4\u02BF\u02BE\u02B4
	{
		get
		{
			return \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B8\u02B6\u02B7\u02B8\u02B8\u02BD\u02BC\u02B2\u02B9\u02B4\u02C1("notSupportedTitle", "Build Not Supported");
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x06000CED RID: 3309 RVA: 0x0000CBA1 File Offset: 0x0000ADA1
	public static string \u02BC\u02BB\u02B3\u02B4\u02BE\u02B7\u02B2\u02BD\u02BC\u02B7\u02B9
	{
		get
		{
			return \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B8\u02B6\u02B7\u02B8\u02B8\u02BD\u02BC\u02B2\u02B9\u02B4\u02C1("notSupportedBody", "Build Not Supported");
		}
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0000CBB2 File Offset: 0x0000ADB2
	public static string \u02B2\u02BB\u02B9\u02B8\u02B5\u02B9\u02BF\u02B6\u02B7\u02BB\u02B5
	{
		get
		{
			return \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B8\u02B6\u02B7\u02B8\u02B8\u02BD\u02BC\u02B2\u02B9\u02B4\u02C1("testBuildRedirectUrl", "https://clonehero.net/");
		}
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x0006E1F0 File Offset: 0x0006C3F0
	public static async Task \u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC()
	{
		RemoteConfigService.Instance.SetEnvironmentID("production");
		RemoteConfigService.Instance.FetchCompleted += \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B9\u02B7\u02B6\u02BC\u02B2\u02BE\u02B2\u02BE\u02B8\u02B3\u02BA;
		await RemoteConfigService.Instance.FetchConfigsAsync<\u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B8\u02BB\u02B5\u02B4\u02B7\u02B4\u02B2\u02B8\u02B6\u02B9\u02B9, \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02BA\u02BF\u02B5\u02B7\u02C0\u02BA\u02B3\u02B2\u02B6\u02BF\u02C0>(default(\u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B8\u02BB\u02B5\u02B4\u02B7\u02B4\u02B2\u02B8\u02B6\u02B9\u02B9), default(\u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02BA\u02BF\u02B5\u02B7\u02C0\u02BA\u02B3\u02B2\u02B6\u02BF\u02C0));
		Debug.Log("Remote config ready!");
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x0000CBC3 File Offset: 0x0000ADC3
	private static void \u02B9\u02B7\u02B6\u02BC\u02B2\u02BE\u02B2\u02BE\u02B8\u02B3\u02BA(ConfigResponse \u02B9\u02B7\u02B4\u02B8\u02B7\u02BE\u02B5\u02B3\u02B4\u02BF\u02B5)
	{
		if (\u02B9\u02B7\u02B4\u02B8\u02B7\u02BE\u02B5\u02B3\u02B4\u02BF\u02B5.requestOrigin != ConfigOrigin.Default)
		{
			\u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B6\u02B7\u02B4\u02B6\u02B8\u02BB\u02B3\u02B3\u02C1\u02BF\u02B2 = true;
		}
	}

	// Token: 0x0200012C RID: 300
	public struct \u02BA\u02BF\u02B5\u02B7\u02C0\u02BA\u02B3\u02B2\u02B6\u02BF\u02C0
	{
	}

	// Token: 0x0200012D RID: 301
	public struct \u02B8\u02BB\u02B5\u02B4\u02B7\u02B4\u02B2\u02B8\u02B6\u02B9\u02B9
	{
	}
}
