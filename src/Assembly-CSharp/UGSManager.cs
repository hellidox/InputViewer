using System;
using System.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Core.Environments;
using UnityEngine;

// Token: 0x020001D0 RID: 464
public class UGSManager : MonoBehaviour
{
	// Token: 0x17000220 RID: 544
	// (get) Token: 0x06001487 RID: 5255 RVA: 0x00010CFB File Offset: 0x0000EEFB
	// (set) Token: 0x06001489 RID: 5257 RVA: 0x00010D03 File Offset: 0x0000EF03
	public bool \u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 { get; private set; }

	// Token: 0x06001488 RID: 5256 RVA: 0x000A21D4 File Offset: 0x000A03D4
	private async Task \u02B5\u02BD\u02BD\u02BE\u02B9\u02BD\u02B2\u02C1\u02C1\u02B3\u02B6()
	{
		Debug.Log("Setting up services");
		await this.\u02B9\u02B8\u02BA\u02B4\u02B7\u02B9\u02BA\u02BB\u02B5\u02BE\u02BD();
		await \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		await \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		this.\u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 = true;
	}

	// Token: 0x0600148A RID: 5258 RVA: 0x00010D03 File Offset: 0x0000EF03
	private void \u02BD\u02C0\u02BA\u02B7\u02B7\u02BC\u02BE\u02B9\u02B5\u02B3\u02B3(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x0600148B RID: 5259 RVA: 0x00010CFB File Offset: 0x0000EEFB
	public bool \u02BA\u02C0\u02B5\u02B5\u02B9\u02B5\u02BA\u02BE\u02BC\u02BC\u02B8()
	{
		return this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField;
	}

	// Token: 0x0600148C RID: 5260 RVA: 0x00010CFB File Offset: 0x0000EEFB
	public bool \u02B5\u02BD\u02BC\u02B4\u02BC\u02BD\u02BB\u02BD\u02B6\u02B6\u02BC()
	{
		return this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField;
	}

	// Token: 0x0600148D RID: 5261 RVA: 0x000A21D4 File Offset: 0x000A03D4
	private async Task Awake()
	{
		Debug.Log("Setting up services");
		await this.\u02B9\u02B8\u02BA\u02B4\u02B7\u02B9\u02BA\u02BB\u02B5\u02BE\u02BD();
		await \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		await \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		this.\u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 = true;
	}

	// Token: 0x0600148E RID: 5262 RVA: 0x00010CFB File Offset: 0x0000EEFB
	public bool \u02B5\u02C0\u02BB\u02B9\u02BD\u02B5\u02B4\u02BD\u02B3\u02B8\u02BA()
	{
		return this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField;
	}

	// Token: 0x0600148F RID: 5263 RVA: 0x00010D03 File Offset: 0x0000EF03
	private void \u02B5\u02BC\u02BE\u02B6\u02BF\u02B3\u02BB\u02BA\u02B6\u02B3\u02B2(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x00010D03 File Offset: 0x0000EF03
	private void \u02BE\u02B9\u02BE\u02B2\u02BB\u02B6\u02B8\u02B9\u02C1\u02B9\u02BE(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x000A21D4 File Offset: 0x000A03D4
	private async Task \u02B8\u02BF\u02B8\u02B6\u02C0\u02C0\u02C1\u02BE\u02BC\u02B4\u02BC()
	{
		Debug.Log("Setting up services");
		await this.\u02B9\u02B8\u02BA\u02B4\u02B7\u02B9\u02BA\u02BB\u02B5\u02BE\u02BD();
		await \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		await \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		this.\u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 = true;
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x00010D03 File Offset: 0x0000EF03
	private void \u02B4\u02B7\u02BD\u02BF\u02BD\u02B5\u02BE\u02B5\u02BC\u02B6\u02C0(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x000A2218 File Offset: 0x000A0418
	private async Task \u02BB\u02BD\u02BB\u02B5\u02BC\u02B3\u02B7\u02B4\u02B7\u02BB\u02BD()
	{
		InitializationOptions initializationOptions = new InitializationOptions();
		initializationOptions.SetEnvironmentName("production");
		await UnityServices.InitializeAsync(initializationOptions);
		if (!AuthenticationService.Instance.IsSignedIn)
		{
			try
			{
				await AuthenticationService.Instance.SignInAnonymouslyAsync(null);
				Debug.Log("Logged into USG");
				Debug.Log("PlayerID: " + AuthenticationService.Instance.PlayerId);
			}
			catch (AuthenticationException ex)
			{
				Debug.LogException(ex);
			}
			catch (RequestFailedException ex2)
			{
				Debug.LogException(ex2);
			}
		}
		AuthenticationService.Instance.SignedIn += UGSManager.<>c.<>9.\u02B8\u02B8\u02B4\u02B9\u02B8\u02C1\u02BF\u02B6\u02B7\u02BB\u02B5;
		AuthenticationService.Instance.SignInFailed += UGSManager.<>c.<>9.\u02B8\u02BA\u02B4\u02B9\u02C1\u02B4\u02B7\u02B7\u02C1\u02B6\u02BB;
		AuthenticationService.Instance.SignedOut += UGSManager.<>c.<>9.\u02C0\u02B3\u02BF\u02BB\u02B2\u02B5\u02B6\u02B4\u02B6\u02B8\u02B9;
		AuthenticationService.Instance.Expired += UGSManager.<>c.<>9.\u02C1\u02BC\u02B4\u02C0\u02B2\u02BE\u02BA\u02BC\u02B9\u02BF\u02C1;
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x000A21D4 File Offset: 0x000A03D4
	private async Task \u02BC\u02BC\u02B6\u02C0\u02BC\u02C1\u02B8\u02C1\u02C0\u02C1\u02BC()
	{
		Debug.Log("Setting up services");
		await this.\u02B9\u02B8\u02BA\u02B4\u02B7\u02B9\u02BA\u02BB\u02B5\u02BE\u02BD();
		await \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		await \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		this.\u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 = true;
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x00010CFB File Offset: 0x0000EEFB
	public bool \u02C0\u02B8\u02C0\u02B6\u02C0\u02B5\u02B6\u02BC\u02BD\u02B3\u02B9()
	{
		return this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField;
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x000A2218 File Offset: 0x000A0418
	private async Task \u02B9\u02B8\u02BA\u02B4\u02B7\u02B9\u02BA\u02BB\u02B5\u02BE\u02BD()
	{
		InitializationOptions initializationOptions = new InitializationOptions();
		initializationOptions.SetEnvironmentName("production");
		await UnityServices.InitializeAsync(initializationOptions);
		if (!AuthenticationService.Instance.IsSignedIn)
		{
			try
			{
				await AuthenticationService.Instance.SignInAnonymouslyAsync(null);
				Debug.Log("Logged into USG");
				Debug.Log("PlayerID: " + AuthenticationService.Instance.PlayerId);
			}
			catch (AuthenticationException ex)
			{
				Debug.LogException(ex);
			}
			catch (RequestFailedException ex2)
			{
				Debug.LogException(ex2);
			}
		}
		AuthenticationService.Instance.SignedIn += UGSManager.<>c.<>9.\u02B8\u02B8\u02B4\u02B9\u02B8\u02C1\u02BF\u02B6\u02B7\u02BB\u02B5;
		AuthenticationService.Instance.SignInFailed += UGSManager.<>c.<>9.\u02B8\u02BA\u02B4\u02B9\u02C1\u02B4\u02B7\u02B7\u02C1\u02B6\u02BB;
		AuthenticationService.Instance.SignedOut += UGSManager.<>c.<>9.\u02C0\u02B3\u02BF\u02BB\u02B2\u02B5\u02B6\u02B4\u02B6\u02B8\u02B9;
		AuthenticationService.Instance.Expired += UGSManager.<>c.<>9.\u02C1\u02BC\u02B4\u02C0\u02B2\u02BE\u02BA\u02BC\u02B9\u02BF\u02C1;
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x00010D03 File Offset: 0x0000EF03
	private void \u02C0\u02BE\u02B8\u02C0\u02C1\u02B9\u02BB\u02BB\u02B2\u02BF\u02BA(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x000A21D4 File Offset: 0x000A03D4
	private async Task \u02BE\u02B6\u02B9\u02B2\u02C1\u02B9\u02B8\u02B6\u02B4\u02B3\u02B3()
	{
		Debug.Log("Setting up services");
		await this.\u02B9\u02B8\u02BA\u02B4\u02B7\u02B9\u02BA\u02BB\u02B5\u02BE\u02BD();
		await \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		await \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		this.\u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 = true;
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x00010CFB File Offset: 0x0000EEFB
	public bool \u02BE\u02BB\u02B6\u02B4\u02B8\u02BA\u02BB\u02B2\u02BC\u02BA\u02B4()
	{
		return this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField;
	}

	// Token: 0x0600149A RID: 5274 RVA: 0x00010CFB File Offset: 0x0000EEFB
	public bool \u02BF\u02BF\u02BF\u02B6\u02BF\u02C0\u02B8\u02C0\u02B5\u02BE\u02B3()
	{
		return this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField;
	}

	// Token: 0x0600149C RID: 5276 RVA: 0x000A21D4 File Offset: 0x000A03D4
	private async Task \u02BA\u02BB\u02C1\u02B2\u02BC\u02C1\u02B3\u02BB\u02C1\u02BC\u02B4()
	{
		Debug.Log("Setting up services");
		await this.\u02B9\u02B8\u02BA\u02B4\u02B7\u02B9\u02BA\u02BB\u02B5\u02BE\u02BD();
		await \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		await \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		this.\u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 = true;
	}

	// Token: 0x0600149D RID: 5277 RVA: 0x00010D03 File Offset: 0x0000EF03
	private void \u02C1\u02B2\u02C1\u02B9\u02B9\u02BB\u02BF\u02B7\u02B9\u02BC\u02B6(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x0600149E RID: 5278 RVA: 0x000A2218 File Offset: 0x000A0418
	private async Task \u02B5\u02BF\u02B8\u02B8\u02B7\u02BC\u02BC\u02B4\u02C0\u02B2\u02B9()
	{
		InitializationOptions initializationOptions = new InitializationOptions();
		initializationOptions.SetEnvironmentName("production");
		await UnityServices.InitializeAsync(initializationOptions);
		if (!AuthenticationService.Instance.IsSignedIn)
		{
			try
			{
				await AuthenticationService.Instance.SignInAnonymouslyAsync(null);
				Debug.Log("Logged into USG");
				Debug.Log("PlayerID: " + AuthenticationService.Instance.PlayerId);
			}
			catch (AuthenticationException ex)
			{
				Debug.LogException(ex);
			}
			catch (RequestFailedException ex2)
			{
				Debug.LogException(ex2);
			}
		}
		AuthenticationService.Instance.SignedIn += UGSManager.<>c.<>9.\u02B8\u02B8\u02B4\u02B9\u02B8\u02C1\u02BF\u02B6\u02B7\u02BB\u02B5;
		AuthenticationService.Instance.SignInFailed += UGSManager.<>c.<>9.\u02B8\u02BA\u02B4\u02B9\u02C1\u02B4\u02B7\u02B7\u02C1\u02B6\u02BB;
		AuthenticationService.Instance.SignedOut += UGSManager.<>c.<>9.\u02C0\u02B3\u02BF\u02BB\u02B2\u02B5\u02B6\u02B4\u02B6\u02B8\u02B9;
		AuthenticationService.Instance.Expired += UGSManager.<>c.<>9.\u02C1\u02BC\u02B4\u02C0\u02B2\u02BE\u02BA\u02BC\u02B9\u02BF\u02C1;
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x000A2218 File Offset: 0x000A0418
	private async Task \u02B2\u02BB\u02B4\u02B3\u02B9\u02B2\u02BF\u02B6\u02BF\u02C1\u02BD()
	{
		InitializationOptions initializationOptions = new InitializationOptions();
		initializationOptions.SetEnvironmentName("production");
		await UnityServices.InitializeAsync(initializationOptions);
		if (!AuthenticationService.Instance.IsSignedIn)
		{
			try
			{
				await AuthenticationService.Instance.SignInAnonymouslyAsync(null);
				Debug.Log("Logged into USG");
				Debug.Log("PlayerID: " + AuthenticationService.Instance.PlayerId);
			}
			catch (AuthenticationException ex)
			{
				Debug.LogException(ex);
			}
			catch (RequestFailedException ex2)
			{
				Debug.LogException(ex2);
			}
		}
		AuthenticationService.Instance.SignedIn += UGSManager.<>c.<>9.\u02B8\u02B8\u02B4\u02B9\u02B8\u02C1\u02BF\u02B6\u02B7\u02BB\u02B5;
		AuthenticationService.Instance.SignInFailed += UGSManager.<>c.<>9.\u02B8\u02BA\u02B4\u02B9\u02C1\u02B4\u02B7\u02B7\u02C1\u02B6\u02BB;
		AuthenticationService.Instance.SignedOut += UGSManager.<>c.<>9.\u02C0\u02B3\u02BF\u02BB\u02B2\u02B5\u02B6\u02B4\u02B6\u02B8\u02B9;
		AuthenticationService.Instance.Expired += UGSManager.<>c.<>9.\u02C1\u02BC\u02B4\u02C0\u02B2\u02BE\u02BA\u02BC\u02B9\u02BF\u02C1;
	}
}
