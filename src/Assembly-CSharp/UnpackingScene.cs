using System;
using System.Collections;
using System.IO;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000123 RID: 291
public class UnpackingScene : MonoBehaviour
{
	// Token: 0x06000C83 RID: 3203 RVA: 0x0000C6EC File Offset: 0x0000A8EC
	private IEnumerator Start()
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			this.\u02B8\u02B6\u02B7\u02C0\u02B5\u02B5\u02BD\u02B8\u02B9\u02B5\u02BE();
			while (this.\u02B8\u02B9\u02BA\u02C0\u02B6\u02B4\u02B7\u02B2\u02BF\u02BB\u02B2)
			{
				yield return null;
			}
			GameLogManager.\u02BD\u02B2\u02BC\u02BF\u02BA\u02BC\u02BC\u02B5\u02BA\u02C0\u02BF();
			if (!\u02B3\u02B2\u02BE\u02B5\u02BB\u02BD\u02B6\u02BE\u02BA\u02B2\u02B7.\u02BD\u02B6\u02BD\u02B4\u02BE\u02BE\u02B4\u02BD\u02B5\u02B2\u02BF())
			{
				this.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(true, "Unpacking files...", "Please wait while we prepare some files.", null, null);
				yield return base.StartCoroutine(\u02B3\u02B2\u02BE\u02B5\u02BB\u02BD\u02B6\u02BE\u02BA\u02B2\u02B7.\u02BA\u02BC\u02BA\u02B8\u02B9\u02B4\u02B7\u02B4\u02B3\u02B5\u02BE());
			}
		}
		GameLogManager.\u02BD\u02B2\u02BC\u02BF\u02BA\u02BC\u02BC\u02B5\u02BA\u02C0\u02BF();
		if (this.cliGameLauncher.\u02B8\u02B4\u02BE\u02B7\u02B3\u02B3\u02BC\u02BF\u02BE\u02B6\u02B4())
		{
			this.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(true, "Loading CLI Gameplay", "Please wait while the song is loaded.", null, null);
			base.StartCoroutine(this.cliGameLauncher.\u02B4\u02BB\u02B3\u02C0\u02B9\u02B5\u02BB\u02C0\u02B5\u02B4\u02BB());
			yield break;
		}
		while (!this.ugsManager.\u02C0\u02B3\u02B3\u02BC\u02B5\u02BE\u02B4\u02BD\u02B3\u02B4\u02B7)
		{
			yield return null;
		}
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Main Menu", 0f);
		yield break;
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x0000C6FB File Offset: 0x0000A8FB
	private void \u02B8\u02B6\u02B7\u02C0\u02B5\u02B5\u02BD\u02B8\u02B9\u02B5\u02BE()
	{
		this.\u02B8\u02B9\u02BA\u02C0\u02B6\u02B4\u02B7\u02B2\u02BF\u02BB\u02B2 = true;
		if (!\u02B3\u02B2\u02BE\u02B5\u02BB\u02BD\u02B6\u02BE\u02BA\u02B2\u02B7.\u02BA\u02BF\u02C1\u02C1\u02BE\u02B8\u02C0\u02C1\u02B6\u02C0\u02BA())
		{
			this.\u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(false, "Missing Permissions", "Game needs storage permissions to boot.", new UnityAction(this.\u02B8\u02B6\u02B7\u02C0\u02B5\u02B5\u02BD\u02B8\u02B9\u02B5\u02BE), "Retry");
			return;
		}
		this.\u02B8\u02B9\u02BA\u02C0\u02B6\u02B4\u02B7\u02B2\u02BF\u02BB\u02B2 = false;
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x0006C6F8 File Offset: 0x0006A8F8
	public void \u02B7\u02C1\u02BD\u02BF\u02BF\u02B8\u02BB\u02B8\u02BE\u02B3\u02B2(bool \u02C1\u02B2\u02BB\u02C0\u02BA\u02BE\u02B6\u02B4\u02B9\u02B3\u02C0, string \u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9, string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, UnityAction \u02B7\u02BC\u02BC\u02B3\u02B6\u02BA\u02C1\u02BE\u02BA\u02B5\u02BF = null, string \u02BA\u02B5\u02BB\u02BC\u02B5\u02C0\u02B9\u02C0\u02B9\u02B4\u02B4 = null)
	{
		this.messageBox.SetActive(true);
		this.messageBoxSpinner.SetActive(\u02C1\u02B2\u02BB\u02C0\u02BA\u02BE\u02B6\u02B4\u02B9\u02B3\u02C0);
		this.messageBoxTitle.text = \u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9;
		this.messageBoxMessage.text = \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC;
		if (\u02B7\u02BC\u02BC\u02B3\u02B6\u02BA\u02C1\u02BE\u02BA\u02B5\u02BF != null)
		{
			this.messageButton.gameObject.SetActive(false);
			this.messageButton.onClick.AddListener(\u02B7\u02BC\u02BC\u02B3\u02B6\u02BA\u02C1\u02BE\u02BA\u02B5\u02BF);
			this.messageButton.GetComponentInChildren<TextMeshProUGUI>().text = \u02BA\u02B5\u02BB\u02BC\u02B5\u02C0\u02B9\u02C0\u02B9\u02B4\u02B4;
			return;
		}
		this.messageButton.gameObject.SetActive(false);
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x0006C780 File Offset: 0x0006A980
	public static void \u02BC\u02B6\u02B9\u02B4\u02B4\u02BC\u02B7\u02BE\u02B9\u02BB\u02BE(__FIXME_clon_util.GraphicsAPI \u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF)
	{
		int @int = PlayerPrefs.GetInt("triedGraphicsSwitch", 0);
		if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF != __FIXME_clon_util.GraphicsAPI.None && SystemInfo.graphicsDeviceType != __FIXME_clon_util.\u02BA\u02B5\u02BD\u02BF\u02B3\u02B3\u02B6\u02BC\u02BF\u02C0\u02B8(\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF) && @int == 0)
		{
			PlayerPrefs.SetInt("triedGraphicsSwitch", 1);
			__FIXME_clon_util.\u02B3\u02BC\u02B9\u02BD\u02BB\u02B6\u02B5\u02B9\u02BC\u02BD\u02BE(__FIXME_clon_util.\u02BF\u02BD\u02B3\u02B2\u02B2\u02BA\u02B6\u02B2\u02C1\u02B4\u02C1(\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF) + " " + __FIXME_clon_util.\u02BF\u02B9\u02B9\u02C1\u02B7\u02B6\u02B6\u02B5\u02B3\u02B3\u02B8());
		}
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x0006C7D4 File Offset: 0x0006A9D4
	public static void \u02B9\u02BE\u02B5\u02B6\u02C0\u02BD\u02BC\u02C0\u02C1\u02C1\u02BB(__FIXME_clon_util.GraphicsAPI \u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF)
	{
		int @int = PlayerPrefs.GetInt("Color Profile", 1);
		if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF != __FIXME_clon_util.GraphicsAPI.None && SystemInfo.graphicsDeviceType != __FIXME_clon_util.\u02BA\u02B5\u02BD\u02BF\u02B3\u02B3\u02B6\u02BC\u02BF\u02C0\u02B8(\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF) && @int == 0)
		{
			PlayerPrefs.SetInt(" + ", 0);
			__FIXME_clon_util.\u02B3\u02BC\u02B9\u02BD\u02BB\u02B6\u02B5\u02B9\u02BC\u02BD\u02BE(__FIXME_clon_util.\u02BF\u02BD\u02B3\u02B2\u02B2\u02BA\u02B6\u02B2\u02C1\u02B4\u02C1(\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF) + "Use Song Backgrounds" + __FIXME_clon_util.\u02BF\u02B9\u02B9\u02C1\u02B7\u02B6\u02B6\u02B5\u02B3\u02B3\u02B8());
		}
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x0000C735 File Offset: 0x0000A935
	private void \u02B2\u02B3\u02BE\u02B7\u02B6\u02B3\u02B5\u02B4\u02B7\u02B6\u02C1()
	{
		this.\u02B8\u02B9\u02BA\u02C0\u02B6\u02B4\u02B7\u02B2\u02BF\u02BB\u02B2 = true;
		if (!\u02B3\u02B2\u02BE\u02B5\u02BB\u02BD\u02B6\u02BE\u02BA\u02B2\u02B7.\u02B5\u02BA\u02BF\u02B5\u02BF\u02B8\u02C1\u02B8\u02BD\u02B3\u02C0())
		{
			this.\u02BD\u02B8\u02B7\u02B4\u02B6\u02B3\u02B4\u02B7\u02C0\u02BA\u02BB(true, " ", "Drums Freestyle", new UnityAction(this.\u02B2\u02B3\u02BE\u02B7\u02B6\u02B3\u02B5\u02B4\u02B7\u02B6\u02C1), "groupScore");
			return;
		}
		this.\u02B8\u02B9\u02BA\u02C0\u02B6\u02B4\u02B7\u02B2\u02BF\u02BB\u02B2 = true;
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x0000C76F File Offset: 0x0000A96F
	public static void \u02B5\u02B3\u02B3\u02BB\u02BA\u02BB\u02C0\u02BE\u02B2\u02B5\u02B9()
	{
		Settings.InitSettings();
		Settings.Load("settings");
		SettingsController.\u02BB\u02B7\u02BA\u02BC\u02B2\u02B8\u02B9\u02BC\u02C0\u02B5\u02B6 = true;
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x0006C6F8 File Offset: 0x0006A8F8
	public void \u02BD\u02B8\u02B7\u02B4\u02B6\u02B3\u02B4\u02B7\u02C0\u02BA\u02BB(bool \u02C1\u02B2\u02BB\u02C0\u02BA\u02BE\u02B6\u02B4\u02B9\u02B3\u02C0, string \u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9, string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, UnityAction \u02B7\u02BC\u02BC\u02B3\u02B6\u02BA\u02C1\u02BE\u02BA\u02B5\u02BF = null, string \u02BA\u02B5\u02BB\u02BC\u02B5\u02C0\u02B9\u02C0\u02B9\u02B4\u02B4 = null)
	{
		this.messageBox.SetActive(true);
		this.messageBoxSpinner.SetActive(\u02C1\u02B2\u02BB\u02C0\u02BA\u02BE\u02B6\u02B4\u02B9\u02B3\u02C0);
		this.messageBoxTitle.text = \u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9;
		this.messageBoxMessage.text = \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC;
		if (\u02B7\u02BC\u02BC\u02B3\u02B6\u02BA\u02C1\u02BE\u02BA\u02B5\u02BF != null)
		{
			this.messageButton.gameObject.SetActive(false);
			this.messageButton.onClick.AddListener(\u02B7\u02BC\u02BC\u02B3\u02B6\u02BA\u02C1\u02BE\u02BA\u02B5\u02BF);
			this.messageButton.GetComponentInChildren<TextMeshProUGUI>().text = \u02BA\u02B5\u02BB\u02BC\u02B5\u02C0\u02B9\u02C0\u02B9\u02B4\u02B4;
			return;
		}
		this.messageButton.gameObject.SetActive(false);
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x0000C786 File Offset: 0x0000A986
	private void Awake()
	{
		this.cliGameLauncher = base.GetComponent<CliGameLauncher>();
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x0006C828 File Offset: 0x0006AA28
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
	public static void PreUnityInit()
	{
		if (Application.platform == RuntimePlatform.WindowsPlayer)
		{
			UnpackingScene.\u02B2\u02BE\u02B7\u02BD\u02B9\u02BD\u02B2\u02B8\u02BB\u02B7\u02B8();
		}
		__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(__FIXME_clon_util.GetDocumentsClonFolder());
		__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(__FIXME_clon_util.\u02B3\u02B8\u02BF\u02B8\u02BF\u02BB\u02B7\u02B4\u02B7\u02BB\u02BD());
		if (!File.Exists(Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "settings.ini")))
		{
			string text = Path.Combine(Application.persistentDataPath, "settings.ini");
			if (File.Exists(text))
			{
				File.Copy(text, Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "settings.ini"));
			}
		}
		UnpackingScene.\u02B5\u02B3\u02B3\u02BB\u02BA\u02BB\u02C0\u02BE\u02B2\u02B5\u02B9();
		if (Application.platform == RuntimePlatform.Android)
		{
			return;
		}
		UnpackingScene.\u02BC\u02B6\u02B9\u02B4\u02B4\u02BC\u02B7\u02BE\u02B9\u02BB\u02BE((__FIXME_clon_util.GraphicsAPI)((SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF.CurrentValue == 0) ? 0 : __FIXME_clon_util.\u02BE\u02BB\u02B6\u02B7\u02B8\u02C0\u02BF\u02B5\u02C0\u02B6\u02B6((ushort)__FIXME_clon_util.SupportedGraphicsAPIs(), SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF.CurrentValue)));
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x0006C8D4 File Offset: 0x0006AAD4
	public static void \u02BC\u02BD\u02B9\u02B6\u02BB\u02B7\u02B4\u02B6\u02B4\u02C1\u02B6()
	{
		if (Application.platform == RuntimePlatform.IPhonePlayer)
		{
			UnpackingScene.\u02B2\u02BE\u02B7\u02BD\u02B9\u02BD\u02B2\u02B8\u02BB\u02B7\u02B8();
		}
		__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(__FIXME_clon_util.GetDocumentsClonFolder());
		__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(__FIXME_clon_util.\u02B3\u02B8\u02BF\u02B8\u02BF\u02BB\u02B7\u02B4\u02B7\u02BB\u02BD());
		if (!File.Exists(Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "Prefabs/Gameplay/Notes/Sustain")))
		{
			string text = Path.Combine(Application.persistentDataPath, "]");
			if (File.Exists(text))
			{
				File.Copy(text, Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "Solo Move"));
			}
		}
		UnpackingScene.\u02BD\u02B4\u02C0\u02B5\u02BA\u02B9\u02B6\u02B4\u02B2\u02B7\u02B5();
		if (Application.platform == RuntimePlatform.WindowsServer)
		{
			return;
		}
		UnpackingScene.\u02B9\u02BE\u02B5\u02B6\u02C0\u02BD\u02BC\u02C0\u02C1\u02C1\u02BB((__FIXME_clon_util.GraphicsAPI)((SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF.CurrentValue == 0) ? 1 : __FIXME_clon_util.\u02BE\u02BB\u02B6\u02B7\u02B8\u02C0\u02BF\u02B5\u02C0\u02B6\u02B6((ushort)__FIXME_clon_util.SupportedGraphicsAPIs(), SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF.CurrentValue)));
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x0000C794 File Offset: 0x0000A994
	public static void \u02BD\u02B4\u02C0\u02B5\u02BA\u02B9\u02B6\u02B4\u02B2\u02B7\u02B5()
	{
		Settings.InitSettings();
		Settings.Load("song");
		SettingsController.\u02BB\u02B7\u02BA\u02BC\u02B2\u02B8\u02B9\u02BC\u02C0\u02B5\u02B6 = true;
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x0000C7AB File Offset: 0x0000A9AB
	private IEnumerator \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		UnpackingScene.\u02B2\u02BA\u02BB\u02B3\u02BF\u02B4\u02B8\u02BC\u02BE\u02B3\u02B3 u02B2_u02BA_u02BB_u02B3_u02BF_u02B4_u02B8_u02BC_u02BE_u02B3_u02B = new UnpackingScene.\u02B2\u02BA\u02BB\u02B3\u02BF\u02B4\u02B8\u02BC\u02BE\u02B3\u02B3(1);
		u02B2_u02BA_u02BB_u02B3_u02BF_u02B4_u02B8_u02BC_u02BE_u02B3_u02B.<>4__this = this;
		return u02B2_u02BA_u02BB_u02B3_u02BF_u02B4_u02B8_u02BC_u02BE_u02B3_u02B;
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x0000C7BA File Offset: 0x0000A9BA
	public static void \u02BE\u02B2\u02B7\u02BE\u02BA\u02BB\u02BF\u02B9\u02C1\u02C0\u02B9()
	{
		Settings.InitSettings();
		Settings.Load("Bot");
		SettingsController.\u02BB\u02B7\u02BA\u02BC\u02B2\u02B8\u02B9\u02BC\u02C0\u02B5\u02B6 = false;
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x0000C786 File Offset: 0x0000A986
	private void \u02B8\u02BF\u02B8\u02B6\u02C0\u02C0\u02C1\u02BE\u02BC\u02B4\u02BC()
	{
		this.cliGameLauncher = base.GetComponent<CliGameLauncher>();
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x0006C980 File Offset: 0x0006AB80
	public void \u02B8\u02BC\u02B9\u02BE\u02B5\u02BD\u02BA\u02BD\u02B4\u02BF\u02B9(bool \u02C1\u02B2\u02BB\u02C0\u02BA\u02BE\u02B6\u02B4\u02B9\u02B3\u02C0, string \u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9, string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, UnityAction \u02B7\u02BC\u02BC\u02B3\u02B6\u02BA\u02C1\u02BE\u02BA\u02B5\u02BF = null, string \u02BA\u02B5\u02BB\u02BC\u02B5\u02C0\u02B9\u02C0\u02B9\u02B4\u02B4 = null)
	{
		this.messageBox.SetActive(true);
		this.messageBoxSpinner.SetActive(\u02C1\u02B2\u02BB\u02C0\u02BA\u02BE\u02B6\u02B4\u02B9\u02B3\u02C0);
		this.messageBoxTitle.text = \u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9;
		this.messageBoxMessage.text = \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC;
		if (\u02B7\u02BC\u02BC\u02B3\u02B6\u02BA\u02C1\u02BE\u02BA\u02B5\u02BF != null)
		{
			this.messageButton.gameObject.SetActive(true);
			this.messageButton.onClick.AddListener(\u02B7\u02BC\u02BC\u02B3\u02B6\u02BA\u02C1\u02BE\u02BA\u02B5\u02BF);
			this.messageButton.GetComponentInChildren<TextMeshProUGUI>().text = \u02BA\u02B5\u02BB\u02BC\u02B5\u02C0\u02B9\u02C0\u02B9\u02B4\u02B4;
			return;
		}
		this.messageButton.gameObject.SetActive(false);
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x0000C7D1 File Offset: 0x0000A9D1
	private static void \u02B2\u02BE\u02B7\u02BD\u02B9\u02BD\u02B2\u02B8\u02BB\u02B7\u02B8()
	{
		GlobalVariables.\u02B4\u02B8\u02BB\u02B6\u02B8\u02B6\u02BA\u02BA\u02B3\u02B3\u02B6 = !File.Exists(Path.Combine(Directory.GetParent(Application.dataPath).FullName, ".fullInstall"));
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x0006C980 File Offset: 0x0006AB80
	public void \u02BA\u02B7\u02BD\u02B6\u02C1\u02B8\u02B9\u02BE\u02B7\u02BA\u02BA(bool \u02C1\u02B2\u02BB\u02C0\u02BA\u02BE\u02B6\u02B4\u02B9\u02B3\u02C0, string \u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9, string \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC, UnityAction \u02B7\u02BC\u02BC\u02B3\u02B6\u02BA\u02C1\u02BE\u02BA\u02B5\u02BF = null, string \u02BA\u02B5\u02BB\u02BC\u02B5\u02C0\u02B9\u02C0\u02B9\u02B4\u02B4 = null)
	{
		this.messageBox.SetActive(true);
		this.messageBoxSpinner.SetActive(\u02C1\u02B2\u02BB\u02C0\u02BA\u02BE\u02B6\u02B4\u02B9\u02B3\u02C0);
		this.messageBoxTitle.text = \u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9;
		this.messageBoxMessage.text = \u02BB\u02B3\u02B2\u02B2\u02B3\u02BF\u02B6\u02B9\u02BD\u02B5\u02BC;
		if (\u02B7\u02BC\u02BC\u02B3\u02B6\u02BA\u02C1\u02BE\u02BA\u02B5\u02BF != null)
		{
			this.messageButton.gameObject.SetActive(true);
			this.messageButton.onClick.AddListener(\u02B7\u02BC\u02BC\u02B3\u02B6\u02BA\u02C1\u02BE\u02BA\u02B5\u02BF);
			this.messageButton.GetComponentInChildren<TextMeshProUGUI>().text = \u02BA\u02B5\u02BB\u02BC\u02B5\u02C0\u02B9\u02C0\u02B9\u02B4\u02B4;
			return;
		}
		this.messageButton.gameObject.SetActive(false);
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x0000C786 File Offset: 0x0000A986
	private void \u02BD\u02BF\u02B6\u02B8\u02BB\u02B2\u02BF\u02C0\u02B5\u02B9\u02BC()
	{
		this.cliGameLauncher = base.GetComponent<CliGameLauncher>();
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x0000C7F9 File Offset: 0x0000A9F9
	public void \u02B2\u02B8\u02BD\u02BC\u02B9\u02B6\u02BA\u02BE\u02C0\u02B8\u02B7()
	{
		this.messageBox.SetActive(false);
	}

	// Token: 0x040008DC RID: 2268
	[SerializeField]
	private TextMeshProUGUI progressText;

	// Token: 0x040008DD RID: 2269
	[SerializeField]
	private CliGameLauncher cliGameLauncher;

	// Token: 0x040008DE RID: 2270
	[SerializeField]
	private GameObject messageBox;

	// Token: 0x040008DF RID: 2271
	[SerializeField]
	private TextMeshProUGUI messageBoxTitle;

	// Token: 0x040008E0 RID: 2272
	[SerializeField]
	private TextMeshProUGUI messageBoxMessage;

	// Token: 0x040008E1 RID: 2273
	[SerializeField]
	private GameObject messageBoxSpinner;

	// Token: 0x040008E2 RID: 2274
	[SerializeField]
	private UGSManager ugsManager;

	// Token: 0x040008E3 RID: 2275
	[SerializeField]
	private Button messageButton;

	// Token: 0x040008E4 RID: 2276
	private bool \u02B8\u02B9\u02BA\u02C0\u02B6\u02B4\u02B7\u02B2\u02BF\u02BB\u02B2;
}
