using System;
using System.Collections;
using System.IO;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UnpackingScene : MonoBehaviour
{
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

	public static void \u02BC\u02B6\u02B9\u02B4\u02B4\u02BC\u02B7\u02BE\u02B9\u02BB\u02BE(Helper.GraphicsAPI \u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF)
	{
		int @int = PlayerPrefs.GetInt("triedGraphicsSwitch", 0);
		if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF != Helper.GraphicsAPI.None && SystemInfo.graphicsDeviceType != Helper.\u02BA\u02B5\u02BD\u02BF\u02B3\u02B3\u02B6\u02BC\u02BF\u02C0\u02B8(\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF) && @int == 0)
		{
			PlayerPrefs.SetInt("triedGraphicsSwitch", 1);
			Helper.Restart(Helper.\u02BF\u02BD\u02B3\u02B2\u02B2\u02BA\u02B6\u02B2\u02C1\u02B4\u02C1(\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF) + " " + Helper.\u02BF\u02B9\u02B9\u02C1\u02B7\u02B6\u02B6\u02B5\u02B3\u02B3\u02B8());
		}
	}

	public static void \u02B9\u02BE\u02B5\u02B6\u02C0\u02BD\u02BC\u02C0\u02C1\u02C1\u02BB(Helper.GraphicsAPI \u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF)
	{
		int @int = PlayerPrefs.GetInt("Color Profile", 1);
		if (\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF != Helper.GraphicsAPI.None && SystemInfo.graphicsDeviceType != Helper.\u02BA\u02B5\u02BD\u02BF\u02B3\u02B3\u02B6\u02BC\u02BF\u02C0\u02B8(\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF) && @int == 0)
		{
			PlayerPrefs.SetInt(" + ", 0);
			Helper.Restart(Helper.\u02BF\u02BD\u02B3\u02B2\u02B2\u02BA\u02B6\u02B2\u02C1\u02B4\u02C1(\u02B8\u02C0\u02BA\u02B8\u02B5\u02B2\u02B5\u02BF\u02C0\u02BC\u02BF) + "Use Song Backgrounds" + Helper.\u02BF\u02B9\u02B9\u02C1\u02B7\u02B6\u02B6\u02B5\u02B3\u02B3\u02B8());
		}
	}

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

	public static void \u02B5\u02B3\u02B3\u02BB\u02BA\u02BB\u02C0\u02BE\u02B2\u02B5\u02B9()
	{
		Settings.InitSettings();
		Settings.Load("settings");
		SettingsController.\u02BB\u02B7\u02BA\u02BC\u02B2\u02B8\u02B9\u02BC\u02C0\u02B5\u02B6 = true;
	}

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

	private void Awake()
	{
		this.cliGameLauncher = base.GetComponent<CliGameLauncher>();
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
	public static void PreUnityInit()
	{
		if (Application.platform == RuntimePlatform.WindowsPlayer)
		{
			UnpackingScene.\u02B2\u02BE\u02B7\u02BD\u02B9\u02BD\u02B2\u02B8\u02BB\u02B7\u02B8();
		}
		Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(Helper.GetDocumentsClonFolder());
		Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(Helper.\u02B3\u02B8\u02BF\u02B8\u02BF\u02BB\u02B7\u02B4\u02B7\u02BB\u02BD());
		if (!File.Exists(Path.Combine(Helper.GetDocumentsClonFolder(), "settings.ini")))
		{
			string text = Path.Combine(Application.persistentDataPath, "settings.ini");
			if (File.Exists(text))
			{
				File.Copy(text, Path.Combine(Helper.GetDocumentsClonFolder(), "settings.ini"));
			}
		}
		UnpackingScene.\u02B5\u02B3\u02B3\u02BB\u02BA\u02BB\u02C0\u02BE\u02B2\u02B5\u02B9();
		if (Application.platform == RuntimePlatform.Android)
		{
			return;
		}
		UnpackingScene.\u02BC\u02B6\u02B9\u02B4\u02B4\u02BC\u02B7\u02BE\u02B9\u02BB\u02BE((Helper.GraphicsAPI)((SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF.CurrentValue == 0) ? 0 : Helper.\u02BE\u02BB\u02B6\u02B7\u02B8\u02C0\u02BF\u02B5\u02C0\u02B6\u02B6((ushort)Helper.SupportedGraphicsAPIs(), SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF.CurrentValue)));
	}

	public static void \u02BC\u02BD\u02B9\u02B6\u02BB\u02B7\u02B4\u02B6\u02B4\u02C1\u02B6()
	{
		if (Application.platform == RuntimePlatform.IPhonePlayer)
		{
			UnpackingScene.\u02B2\u02BE\u02B7\u02BD\u02B9\u02BD\u02B2\u02B8\u02BB\u02B7\u02B8();
		}
		Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(Helper.GetDocumentsClonFolder());
		Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(Helper.\u02B3\u02B8\u02BF\u02B8\u02BF\u02BB\u02B7\u02B4\u02B7\u02BB\u02BD());
		if (!File.Exists(Path.Combine(Helper.GetDocumentsClonFolder(), "Prefabs/Gameplay/Notes/Sustain")))
		{
			string text = Path.Combine(Application.persistentDataPath, "]");
			if (File.Exists(text))
			{
				File.Copy(text, Path.Combine(Helper.GetDocumentsClonFolder(), "Solo Move"));
			}
		}
		UnpackingScene.\u02BD\u02B4\u02C0\u02B5\u02BA\u02B9\u02B6\u02B4\u02B2\u02B7\u02B5();
		if (Application.platform == RuntimePlatform.WindowsServer)
		{
			return;
		}
		UnpackingScene.\u02B9\u02BE\u02B5\u02B6\u02C0\u02BD\u02BC\u02C0\u02C1\u02C1\u02BB((Helper.GraphicsAPI)((SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF.CurrentValue == 0) ? 1 : Helper.\u02BE\u02BB\u02B6\u02B7\u02B8\u02C0\u02BF\u02B5\u02C0\u02B6\u02B6((ushort)Helper.SupportedGraphicsAPIs(), SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF.CurrentValue)));
	}

	public static void \u02BD\u02B4\u02C0\u02B5\u02BA\u02B9\u02B6\u02B4\u02B2\u02B7\u02B5()
	{
		Settings.InitSettings();
		Settings.Load("song");
		SettingsController.\u02BB\u02B7\u02BA\u02BC\u02B2\u02B8\u02B9\u02BC\u02C0\u02B5\u02B6 = true;
	}

	private IEnumerator \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		UnpackingScene.\u02B2\u02BA\u02BB\u02B3\u02BF\u02B4\u02B8\u02BC\u02BE\u02B3\u02B3 u02B2_u02BA_u02BB_u02B3_u02BF_u02B4_u02B8_u02BC_u02BE_u02B3_u02B = new UnpackingScene.\u02B2\u02BA\u02BB\u02B3\u02BF\u02B4\u02B8\u02BC\u02BE\u02B3\u02B3(1);
		u02B2_u02BA_u02BB_u02B3_u02BF_u02B4_u02B8_u02BC_u02BE_u02B3_u02B.<>4__this = this;
		return u02B2_u02BA_u02BB_u02B3_u02BF_u02B4_u02B8_u02BC_u02BE_u02B3_u02B;
	}

	public static void \u02BE\u02B2\u02B7\u02BE\u02BA\u02BB\u02BF\u02B9\u02C1\u02C0\u02B9()
	{
		Settings.InitSettings();
		Settings.Load("Bot");
		SettingsController.\u02BB\u02B7\u02BA\u02BC\u02B2\u02B8\u02B9\u02BC\u02C0\u02B5\u02B6 = false;
	}

	private void \u02B8\u02BF\u02B8\u02B6\u02C0\u02C0\u02C1\u02BE\u02BC\u02B4\u02BC()
	{
		this.cliGameLauncher = base.GetComponent<CliGameLauncher>();
	}

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

	private static void \u02B2\u02BE\u02B7\u02BD\u02B9\u02BD\u02B2\u02B8\u02BB\u02B7\u02B8()
	{
		GlobalVariables.\u02B4\u02B8\u02BB\u02B6\u02B8\u02B6\u02BA\u02BA\u02B3\u02B3\u02B6 = !File.Exists(Path.Combine(Directory.GetParent(Application.dataPath).FullName, ".fullInstall"));
	}

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

	private void \u02BD\u02BF\u02B6\u02B8\u02BB\u02B2\u02BF\u02C0\u02B5\u02B9\u02BC()
	{
		this.cliGameLauncher = base.GetComponent<CliGameLauncher>();
	}

	public void \u02B2\u02B8\u02BD\u02BC\u02B9\u02B6\u02BA\u02BE\u02C0\u02B8\u02B7()
	{
		this.messageBox.SetActive(false);
	}

	[SerializeField]
	private TextMeshProUGUI progressText;

	[SerializeField]
	private CliGameLauncher cliGameLauncher;

	[SerializeField]
	private GameObject messageBox;

	[SerializeField]
	private TextMeshProUGUI messageBoxTitle;

	[SerializeField]
	private TextMeshProUGUI messageBoxMessage;

	[SerializeField]
	private GameObject messageBoxSpinner;

	[SerializeField]
	private UGSManager ugsManager;

	[SerializeField]
	private Button messageButton;

	private bool \u02B8\u02B9\u02BA\u02C0\u02B6\u02B4\u02B7\u02B2\u02BF\u02BB\u02B2;
}
