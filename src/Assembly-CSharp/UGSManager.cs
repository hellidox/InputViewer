using System;
using System.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Core.Environments;
using UnityEngine;

public class UGSManager : MonoBehaviour
{
	public bool \u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 { get; private set; }

	private async Task \u02B5\u02BD\u02BD\u02BE\u02B9\u02BD\u02B2\u02C1\u02C1\u02B3\u02B6()
	{
		Debug.Log("Setting up services");
		await this.\u02B9\u02B8\u02BA\u02B4\u02B7\u02B9\u02BA\u02BB\u02B5\u02BE\u02BD();
		await \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		await \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		this.\u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 = true;
	}

	private void \u02BD\u02C0\u02BA\u02B7\u02B7\u02BC\u02BE\u02B9\u02B5\u02B3\u02B3(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public bool \u02BA\u02C0\u02B5\u02B5\u02B9\u02B5\u02BA\u02BE\u02BC\u02BC\u02B8()
	{
		return this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField;
	}

	public bool \u02B5\u02BD\u02BC\u02B4\u02BC\u02BD\u02BB\u02BD\u02B6\u02B6\u02BC()
	{
		return this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField;
	}

	private async Task Awake()
	{
		Debug.Log("Setting up services");
		await this.\u02B9\u02B8\u02BA\u02B4\u02B7\u02B9\u02BA\u02BB\u02B5\u02BE\u02BD();
		await \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		await \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		this.\u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 = true;
	}

	public bool \u02B5\u02C0\u02BB\u02B9\u02BD\u02B5\u02B4\u02BD\u02B3\u02B8\u02BA()
	{
		return this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField;
	}

	private void \u02B5\u02BC\u02BE\u02B6\u02BF\u02B3\u02BB\u02BA\u02B6\u02B3\u02B2(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	private void \u02BE\u02B9\u02BE\u02B2\u02BB\u02B6\u02B8\u02B9\u02C1\u02B9\u02BE(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	private async Task \u02B8\u02BF\u02B8\u02B6\u02C0\u02C0\u02C1\u02BE\u02BC\u02B4\u02BC()
	{
		Debug.Log("Setting up services");
		await this.\u02B9\u02B8\u02BA\u02B4\u02B7\u02B9\u02BA\u02BB\u02B5\u02BE\u02BD();
		await \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		await \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		this.\u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 = true;
	}

	private void \u02B4\u02B7\u02BD\u02BF\u02BD\u02B5\u02BE\u02B5\u02BC\u02B6\u02C0(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

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

	private async Task \u02BC\u02BC\u02B6\u02C0\u02BC\u02C1\u02B8\u02C1\u02C0\u02C1\u02BC()
	{
		Debug.Log("Setting up services");
		await this.\u02B9\u02B8\u02BA\u02B4\u02B7\u02B9\u02BA\u02BB\u02B5\u02BE\u02BD();
		await \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		await \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		this.\u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 = true;
	}

	public bool \u02C0\u02B8\u02C0\u02B6\u02C0\u02B5\u02B6\u02BC\u02BD\u02B3\u02B9()
	{
		return this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField;
	}

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

	private void \u02C0\u02BE\u02B8\u02C0\u02C1\u02B9\u02BB\u02BB\u02B2\u02BF\u02BA(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	private async Task \u02BE\u02B6\u02B9\u02B2\u02C1\u02B9\u02B8\u02B6\u02B4\u02B3\u02B3()
	{
		Debug.Log("Setting up services");
		await this.\u02B9\u02B8\u02BA\u02B4\u02B7\u02B9\u02BA\u02BB\u02B5\u02BE\u02BD();
		await \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		await \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		this.\u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 = true;
	}

	public bool \u02BE\u02BB\u02B6\u02B4\u02B8\u02BA\u02BB\u02B2\u02BC\u02BA\u02B4()
	{
		return this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField;
	}

	public bool \u02BF\u02BF\u02BF\u02B6\u02BF\u02C0\u02B8\u02C0\u02B5\u02BE\u02B3()
	{
		return this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField;
	}

	private async Task \u02BA\u02BB\u02C1\u02B2\u02BC\u02C1\u02B3\u02BB\u02C1\u02BC\u02B4()
	{
		Debug.Log("Setting up services");
		await this.\u02B9\u02B8\u02BA\u02B4\u02B7\u02B9\u02BA\u02BB\u02B5\u02BE\u02BD();
		await \u02B8\u02BC\u02BC\u02C0\u02BB\u02C1\u02BB\u02BC\u02B2\u02B7\u02C0.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		await \u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC();
		this.\u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7 = true;
	}

	private void \u02C1\u02B2\u02C1\u02B9\u02B9\u02BB\u02BF\u02B7\u02B9\u02BC\u02B6(bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B7\u02B8\u02C0\u02BE\u02C1\u02BD\u02BC\u02C0\u02C0\u02B4>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

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
