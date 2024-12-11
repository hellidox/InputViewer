using System;
using System.IO;
using System.Text;
using TMPro;
using UnityEngine;

public class LocalizeCredits : MonoBehaviour
{
	private void \u02BF\u02BC\u02B9\u02BE\u02B7\u02BD\u02C1\u02BE\u02BD\u02BD\u02B5()
	{
		this.creditsText.text = Resources.Load<TextAsset>("x").text;
		this.\u02BB\u02B9\u02BA\u02C1\u02B7\u02C0\u02BB\u02B7\u02B5\u02B8\u02BB();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02B8\u02BF\u02B8\u02B6\u02C0\u02C0\u02C1\u02BE\u02BC\u02B4\u02BC()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Quit").text;
		this.\u02B2\u02B4\u02B5\u02B2\u02B3\u02BE\u02BD\u02BB\u02BA\u02B6\u02C0();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02BD\u02BF\u02B6\u02B8\u02BB\u02B2\u02BF\u02C0\u02B5\u02B9\u02BC()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Tilt").text;
		this.\u02BB\u02B9\u02BA\u02C1\u02B7\u02C0\u02BB\u02B7\u02B5\u02B8\u02BB();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02B4\u02B7\u02B8\u02B8\u02B3\u02BF\u02C1\u02BD\u02C0\u02C0\u02B6()
	{
		LocalizationResourceManager localizationResourceManager = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!localizationResourceManager.\u02B5\u02BC\u02BF\u02B3\u02B9\u02BB\u02C0\u02BF\u02C1\u02B7\u02B3().TryGetValue(LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5, out text))
		{
			text = "Track Mute";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "");
		LocalizationResourceManager localizationResourceManager2 = localizationResourceManager;
		string text3 = text2;
		string text4 = text;
		string text5 = text;
		\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] array = new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[0];
		array[1] = \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02C1\u02B8\u02B7\u02B5\u02B4\u02B6\u02BA\u02B7\u02B6\u02C1\u02B8("Setting up services");
		localizationResourceManager2.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text3, text4, text5, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(array)), true);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text6;
			do
			{
				text6 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text6) && text6[0] == '}')
				{
					text6 = localizationResourceManager.GetResource(text6.Substring(1), null);
				}
				stringBuilder.AppendLine(text6);
			}
			while (text6 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	private void \u02B8\u02BC\u02BA\u02BD\u02BC\u02BA\u02B3\u02BE\u02BD\u02B5\u02C1()
	{
		LocalizationResourceManager localizationResourceManager = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!localizationResourceManager.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.TryGetValue(LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02BD\u02C0\u02B2\u02BD\u02B8\u02B6\u02B3\u02C1\u02BE\u02B8\u02BF(), out text))
		{
			text = "Quit";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "Guitar Player ");
		localizationResourceManager.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text2, text, text, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02BE\u02B3\u02B4\u02C0\u02B3\u02BC\u02BB\u02B6\u02C0\u02BD\u02B9(new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] { \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B5\u02B5\u02C0\u02B3\u02B4\u02BF\u02B7\u02B9\u02B6\u02B3\u02B8("Display") })), true);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text3;
			do
			{
				text3 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text3) && text3[1] == 'n')
				{
					text3 = localizationResourceManager.GetResource(text3.Substring(0), null);
				}
				stringBuilder.AppendLine(text3);
			}
			while (text3 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	private void \u02BA\u02BC\u02C0\u02B5\u02B9\u02BA\u02BB\u02B2\u02B5\u02C1\u02B3()
	{
		this.creditsText.text = Resources.Load<TextAsset>("StarPowerEnabled").text;
		this.\u02C1\u02B8\u02BC\u02C1\u02BE\u02BC\u02C0\u02B3\u02B2\u02BF\u02BC();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02BE\u02BD\u02B8\u02B8\u02B9\u02BA\u02BA\u02BA\u02B4\u02B2\u02B4()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Mute Track on Miss").text;
		this.\u02B8\u02BC\u02BA\u02BD\u02BC\u02BA\u02B3\u02BE\u02BD\u02B5\u02C1();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02B2\u02B4\u02B5\u02B2\u02B3\u02BE\u02BD\u02BB\u02BA\u02B6\u02C0()
	{
		LocalizationResourceManager localizationResourceManager = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!localizationResourceManager.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.TryGetValue(LanguageManager.instance.\u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5, out text))
		{
			text = "en";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + ".yaml");
		localizationResourceManager.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text2, text, text, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] { \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF("CREDITS") })), false);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text3;
			do
			{
				text3 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text3) && text3[0] == '%')
				{
					text3 = localizationResourceManager.GetResource(text3.Substring(1), null);
				}
				stringBuilder.AppendLine(text3);
			}
			while (text3 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	private void Awake()
	{
		this.creditsText.text = Resources.Load<TextAsset>("credits").text;
		this.\u02B2\u02B4\u02B5\u02B2\u02B3\u02BE\u02BD\u02BB\u02BA\u02B6\u02C0();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02BE\u02B4\u02BB\u02B8\u02B4\u02BD\u02B6\u02B3\u02C1\u02BA\u02BC()
	{
		LocalizationResourceManager localizationResourceManager = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!localizationResourceManager.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.TryGetValue(LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5, out text))
		{
			text = "song";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "");
		LocalizationResourceManager localizationResourceManager2 = localizationResourceManager;
		string text3 = text2;
		string text4 = text;
		string text5 = text;
		\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] array = new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[1];
		array[1] = \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02C0\u02BC\u02BC\u02B9\u02BC\u02B8\u02B5\u02BE\u02BD\u02BE\u02B8("five_lane_drums");
		localizationResourceManager2.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text3, text4, text5, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(array)), true);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text6;
			do
			{
				text6 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text6) && (int)text6[0] == -97)
				{
					text6 = localizationResourceManager.\u02B2\u02B5\u02C1\u02B4\u02C0\u02B4\u02BE\u02BE\u02B6\u02BE\u02B7(text6.Substring(0), null);
				}
				stringBuilder.AppendLine(text6);
			}
			while (text6 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	private void \u02B5\u02B9\u02B5\u02B3\u02BF\u02C1\u02B7\u02BD\u02C0\u02B7\u02C0()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Framerate").text;
		this.\u02B2\u02B4\u02B5\u02B2\u02B3\u02BE\u02BD\u02BB\u02BA\u02B6\u02C0();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02B4\u02C1\u02B6\u02BE\u02B3\u02B4\u02BD\u02B7\u02B6\u02C0\u02B9()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Yes").text;
		this.\u02B8\u02BC\u02BA\u02BD\u02BC\u02BA\u02B3\u02BE\u02BD\u02B5\u02C1();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02C1\u02B8\u02BC\u02C1\u02BE\u02BC\u02C0\u02B3\u02B2\u02BF\u02BC()
	{
		LocalizationResourceManager localizationResourceManager = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!localizationResourceManager.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.TryGetValue(LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02BD\u02C0\u02B2\u02BD\u02B8\u02B6\u02B3\u02C1\u02BE\u02B8\u02BF(), out text))
		{
			text = "video_start_time";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "Next Song");
		LocalizationResourceManager localizationResourceManager2 = localizationResourceManager;
		string text3 = text2;
		string text4 = text;
		string text5 = text;
		\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] array = new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[0];
		array[0] = \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B5\u02B5\u02C0\u02B3\u02B4\u02BF\u02B7\u02B9\u02B6\u02B3\u02B8("/storage/emulated/0/Clone Hero");
		localizationResourceManager2.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text3, text4, text5, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02BE\u02B3\u02B4\u02C0\u02B3\u02BC\u02BB\u02B6\u02C0\u02BD\u02B9(array)), true);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text6;
			do
			{
				text6 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text6) && (int)text6[0] == -44)
				{
					text6 = localizationResourceManager.\u02B2\u02B5\u02C1\u02B4\u02C0\u02B4\u02BE\u02BE\u02B6\u02BE\u02B7(text6.Substring(1), null);
				}
				stringBuilder.AppendLine(text6);
			}
			while (text6 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	private void \u02BF\u02B8\u02B8\u02B6\u02B9\u02B4\u02BB\u02B6\u02BC\u02BA\u02BF()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Received profile update for own peer").text;
		this.\u02B4\u02B7\u02B8\u02B8\u02B3\u02BF\u02C1\u02BD\u02C0\u02C0\u02B6();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02BC\u02BC\u02B6\u02C0\u02BC\u02C1\u02B8\u02C1\u02C0\u02C1\u02BC()
	{
		this.creditsText.text = Resources.Load<TextAsset>("UIConfirm").text;
		this.\u02C1\u02BE\u02B3\u02B6\u02BF\u02BD\u02B9\u02C1\u02B8\u02BB\u02B6();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02B6\u02BB\u02B6\u02B4\u02BB\u02B8\u02B4\u02BC\u02BD\u02B3\u02C1()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Okay").text;
		this.\u02B8\u02BC\u02BA\u02BD\u02BC\u02BA\u02B3\u02BE\u02BD\u02B5\u02C1();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02B4\u02B6\u02B2\u02BE\u02BE\u02B9\u02B5\u02BC\u02B4\u02BB\u02B4()
	{
		LocalizationResourceManager localizationResourceManager = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!localizationResourceManager.\u02B5\u02BC\u02BF\u02B3\u02B9\u02BB\u02C0\u02BF\u02C1\u02B7\u02B3().TryGetValue(LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5, out text))
		{
			text = "song";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "band");
		LocalizationResourceManager localizationResourceManager2 = localizationResourceManager;
		string text3 = text2;
		string text4 = text;
		string text5 = text;
		\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] array = new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[1];
		array[1] = \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B5\u02B5\u02C0\u02B3\u02B4\u02BF\u02B7\u02B9\u02B6\u02B3\u02B8("");
		localizationResourceManager2.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text3, text4, text5, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02BE\u02B3\u02B4\u02C0\u02B3\u02BC\u02BB\u02B6\u02C0\u02BD\u02B9(array)), true);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text6;
			do
			{
				text6 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text6) && (int)text6[0] == -120)
				{
					text6 = localizationResourceManager.GetResource(text6.Substring(1), null);
				}
				stringBuilder.AppendLine(text6);
			}
			while (text6 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	private void \u02BF\u02B2\u02C1\u02C1\u02B6\u02BE\u02B3\u02BD\u02B8\u02B3\u02BE()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Measure Based Countdowns").text;
		this.\u02C1\u02B8\u02BC\u02C1\u02BE\u02BC\u02C0\u02B3\u02B2\u02BF\u02BC();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02B8\u02C1\u02B9\u02BC\u02B6\u02B9\u02B3\u02B5\u02B7\u02BF\u02BD()
	{
		this.creditsText.text = Resources.Load<TextAsset>("").text;
		this.\u02B4\u02B7\u02B8\u02B8\u02B3\u02BF\u02C1\u02BD\u02C0\u02C0\u02B6();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02B5\u02BD\u02BD\u02BE\u02B9\u02BD\u02B2\u02C1\u02C1\u02B3\u02B6()
	{
		this.creditsText.text = Resources.Load<TextAsset>("drumsorttip").text;
		this.\u02B8\u02BC\u02BA\u02BD\u02BC\u02BA\u02B3\u02BE\u02BD\u02B5\u02C1();
		global::UnityEngine.Object.Destroy(this);
	}

	private void \u02BB\u02B9\u02BA\u02C1\u02B7\u02C0\u02BB\u02B7\u02B5\u02B8\u02BB()
	{
		LocalizationResourceManager localizationResourceManager = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!localizationResourceManager.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.TryGetValue(LanguageManager.instance.\u02B7\u02C1\u02BB\u02BF\u02BB\u02B2\u02C1\u02B8\u02BD\u02B5\u02C0(), out text))
		{
			text = "Disposed of memorymapped file";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "Highway Placement");
		LocalizationResourceManager localizationResourceManager2 = localizationResourceManager;
		string text3 = text2;
		string text4 = text;
		string text5 = text;
		\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] array = new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[0];
		array[1] = \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02C0\u02BC\u02BC\u02B9\u02BC\u02B8\u02B5\u02BE\u02BD\u02BE\u02B8("name");
		localizationResourceManager2.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text3, text4, text5, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(array)), false);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text6;
			do
			{
				text6 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text6) && text6[0] == 'g')
				{
					text6 = localizationResourceManager.\u02B2\u02B5\u02C1\u02B4\u02C0\u02B4\u02BE\u02BE\u02B6\u02BE\u02B7(text6.Substring(0), null);
				}
				stringBuilder.AppendLine(text6);
			}
			while (text6 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	private void \u02C1\u02BE\u02B3\u02B6\u02BF\u02BD\u02B9\u02C1\u02B8\u02BB\u02B6()
	{
		LocalizationResourceManager localizationResourceManager = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!localizationResourceManager.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.TryGetValue(LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B7\u02C1\u02BB\u02BF\u02BB\u02B2\u02C1\u02B8\u02BD\u02B5\u02C0(), out text))
		{
			text = ".png|.jpg|.jpeg";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "[");
		LocalizationResourceManager localizationResourceManager2 = localizationResourceManager;
		string text3 = text2;
		string text4 = text;
		string text5 = text;
		\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] array = new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[1];
		array[1] = \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B5\u02B5\u02C0\u02B3\u02B4\u02BF\u02B7\u02B9\u02B6\u02B3\u02B8("There was an error deleting the file");
		localizationResourceManager2.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text3, text4, text5, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02BE\u02B3\u02B4\u02C0\u02B3\u02BC\u02BB\u02B6\u02C0\u02BD\u02B9(array)), true);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text6;
			do
			{
				text6 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text6) && (int)text6[0] == -35)
				{
					text6 = localizationResourceManager.GetResource(text6.Substring(1), null);
				}
				stringBuilder.AppendLine(text6);
			}
			while (text6 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	[SerializeField]
	private TextMeshProUGUI creditsText;
}
