using System;
using System.IO;
using System.Text;
using TMPro;
using UnityEngine;

// Token: 0x02000086 RID: 134
public class LocalizeCredits : MonoBehaviour
{
	// Token: 0x06000576 RID: 1398 RVA: 0x00008AE8 File Offset: 0x00006CE8
	private void \u02BF\u02BC\u02B9\u02BE\u02B7\u02BD\u02C1\u02BE\u02BD\u02BD\u02B5()
	{
		this.creditsText.text = Resources.Load<TextAsset>("x").text;
		this.\u02BB\u02B9\u02BA\u02C1\u02B7\u02C0\u02BB\u02B7\u02B5\u02B8\u02BB();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x00008B10 File Offset: 0x00006D10
	private void \u02B8\u02BF\u02B8\u02B6\u02C0\u02C0\u02C1\u02BE\u02BC\u02B4\u02BC()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Quit").text;
		this.\u02B2\u02B4\u02B5\u02B2\u02B3\u02BE\u02BD\u02BB\u02BA\u02B6\u02C0();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00008B38 File Offset: 0x00006D38
	private void \u02BD\u02BF\u02B6\u02B8\u02BB\u02B2\u02BF\u02C0\u02B5\u02B9\u02BC()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Tilt").text;
		this.\u02BB\u02B9\u02BA\u02C1\u02B7\u02C0\u02BB\u02B7\u02B5\u02B8\u02BB();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00035EE4 File Offset: 0x000340E4
	private void \u02B4\u02B7\u02B8\u02B8\u02B3\u02BF\u02C1\u02BD\u02C0\u02C0\u02B6()
	{
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02B5\u02BC\u02BF\u02B3\u02B9\u02BB\u02C0\u02BF\u02C1\u02B7\u02B3().TryGetValue(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5, out text))
		{
			text = "Track Mute";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "");
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B2 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B;
		string text3 = text2;
		string text4 = text;
		string text5 = text;
		\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] array = new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[0];
		array[1] = \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02C1\u02B8\u02B7\u02B5\u02B4\u02B6\u02BA\u02B7\u02B6\u02C1\u02B8("Setting up services");
		u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B2.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text3, text4, text5, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(array)), true);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text6;
			do
			{
				text6 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text6) && text6[0] == '}')
				{
					text6 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02C0\u02B5\u02BE\u02C0\u02C0\u02BD\u02BD\u02B4\u02BF\u02B5\u02B9(text6.Substring(1), null);
				}
				stringBuilder.AppendLine(text6);
			}
			while (text6 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00035FDC File Offset: 0x000341DC
	private void \u02B8\u02BC\u02BA\u02BD\u02BC\u02BA\u02B3\u02BE\u02BD\u02B5\u02C1()
	{
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.TryGetValue(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02BD\u02C0\u02B2\u02BD\u02B8\u02B6\u02B3\u02C1\u02BE\u02B8\u02BF(), out text))
		{
			text = "Quit";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "Guitar Player ");
		u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text2, text, text, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02BE\u02B3\u02B4\u02C0\u02B3\u02BC\u02BB\u02B6\u02C0\u02BD\u02B9(new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] { \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B5\u02B5\u02C0\u02B3\u02B4\u02BF\u02B7\u02B9\u02B6\u02B3\u02B8("Display") })), true);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text3;
			do
			{
				text3 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text3) && text3[1] == 'n')
				{
					text3 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02C0\u02B5\u02BE\u02C0\u02C0\u02BD\u02BD\u02B4\u02BF\u02B5\u02B9(text3.Substring(0), null);
				}
				stringBuilder.AppendLine(text3);
			}
			while (text3 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00008B60 File Offset: 0x00006D60
	private void \u02BA\u02BC\u02C0\u02B5\u02B9\u02BA\u02BB\u02B2\u02B5\u02C1\u02B3()
	{
		this.creditsText.text = Resources.Load<TextAsset>("StarPowerEnabled").text;
		this.\u02C1\u02B8\u02BC\u02C1\u02BE\u02BC\u02C0\u02B3\u02B2\u02BF\u02BC();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00008B88 File Offset: 0x00006D88
	private void \u02BE\u02BD\u02B8\u02B8\u02B9\u02BA\u02BA\u02BA\u02B4\u02B2\u02B4()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Mute Track on Miss").text;
		this.\u02B8\u02BC\u02BA\u02BD\u02BC\u02BA\u02B3\u02BE\u02BD\u02B5\u02C1();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x000360D4 File Offset: 0x000342D4
	private void \u02B2\u02B4\u02B5\u02B2\u02B3\u02BE\u02BD\u02BB\u02BA\u02B6\u02C0()
	{
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.TryGetValue(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5, out text))
		{
			text = "en";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + ".yaml");
		u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text2, text, text, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] { \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF("CREDITS") })), false);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text3;
			do
			{
				text3 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text3) && text3[0] == '%')
				{
					text3 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02C0\u02B5\u02BE\u02C0\u02C0\u02BD\u02BD\u02B4\u02BF\u02B5\u02B9(text3.Substring(1), null);
				}
				stringBuilder.AppendLine(text3);
			}
			while (text3 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00008BB0 File Offset: 0x00006DB0
	private void Awake()
	{
		this.creditsText.text = Resources.Load<TextAsset>("credits").text;
		this.\u02B2\u02B4\u02B5\u02B2\u02B3\u02BE\u02BD\u02BB\u02BA\u02B6\u02C0();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x000361CC File Offset: 0x000343CC
	private void \u02BE\u02B4\u02BB\u02B8\u02B4\u02BD\u02B6\u02B3\u02C1\u02BA\u02BC()
	{
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.TryGetValue(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5, out text))
		{
			text = "song";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "");
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B2 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B;
		string text3 = text2;
		string text4 = text;
		string text5 = text;
		\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] array = new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[1];
		array[1] = \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02C0\u02BC\u02BC\u02B9\u02BC\u02B8\u02B5\u02BE\u02BD\u02BE\u02B8("five_lane_drums");
		u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B2.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text3, text4, text5, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(array)), true);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text6;
			do
			{
				text6 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text6) && (int)text6[0] == -97)
				{
					text6 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02B2\u02B5\u02C1\u02B4\u02C0\u02B4\u02BE\u02BE\u02B6\u02BE\u02B7(text6.Substring(0), null);
				}
				stringBuilder.AppendLine(text6);
			}
			while (text6 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x00008BD8 File Offset: 0x00006DD8
	private void \u02B5\u02B9\u02B5\u02B3\u02BF\u02C1\u02B7\u02BD\u02C0\u02B7\u02C0()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Framerate").text;
		this.\u02B2\u02B4\u02B5\u02B2\u02B3\u02BE\u02BD\u02BB\u02BA\u02B6\u02C0();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00008C00 File Offset: 0x00006E00
	private void \u02B4\u02C1\u02B6\u02BE\u02B3\u02B4\u02BD\u02B7\u02B6\u02C0\u02B9()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Yes").text;
		this.\u02B8\u02BC\u02BA\u02BD\u02BC\u02BA\u02B3\u02BE\u02BD\u02B5\u02C1();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x000362C4 File Offset: 0x000344C4
	private void \u02C1\u02B8\u02BC\u02C1\u02BE\u02BC\u02C0\u02B3\u02B2\u02BF\u02BC()
	{
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.TryGetValue(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02BD\u02C0\u02B2\u02BD\u02B8\u02B6\u02B3\u02C1\u02BE\u02B8\u02BF(), out text))
		{
			text = "video_start_time";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "Next Song");
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B2 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B;
		string text3 = text2;
		string text4 = text;
		string text5 = text;
		\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] array = new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[0];
		array[0] = \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B5\u02B5\u02C0\u02B3\u02B4\u02BF\u02B7\u02B9\u02B6\u02B3\u02B8("/storage/emulated/0/Clone Hero");
		u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B2.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text3, text4, text5, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02BE\u02B3\u02B4\u02C0\u02B3\u02BC\u02BB\u02B6\u02C0\u02BD\u02B9(array)), true);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text6;
			do
			{
				text6 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text6) && (int)text6[0] == -44)
				{
					text6 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02B2\u02B5\u02C1\u02B4\u02C0\u02B4\u02BE\u02BE\u02B6\u02BE\u02B7(text6.Substring(1), null);
				}
				stringBuilder.AppendLine(text6);
			}
			while (text6 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x00008C28 File Offset: 0x00006E28
	private void \u02BF\u02B8\u02B8\u02B6\u02B9\u02B4\u02BB\u02B6\u02BC\u02BA\u02BF()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Received profile update for own peer").text;
		this.\u02B4\u02B7\u02B8\u02B8\u02B3\u02BF\u02C1\u02BD\u02C0\u02C0\u02B6();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00008C50 File Offset: 0x00006E50
	private void \u02BC\u02BC\u02B6\u02C0\u02BC\u02C1\u02B8\u02C1\u02C0\u02C1\u02BC()
	{
		this.creditsText.text = Resources.Load<TextAsset>("UIConfirm").text;
		this.\u02C1\u02BE\u02B3\u02B6\u02BF\u02BD\u02B9\u02C1\u02B8\u02BB\u02B6();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x00008C78 File Offset: 0x00006E78
	private void \u02B6\u02BB\u02B6\u02B4\u02BB\u02B8\u02B4\u02BC\u02BD\u02B3\u02C1()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Okay").text;
		this.\u02B8\u02BC\u02BA\u02BD\u02BC\u02BA\u02B3\u02BE\u02BD\u02B5\u02C1();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x000363BC File Offset: 0x000345BC
	private void \u02B4\u02B6\u02B2\u02BE\u02BE\u02B9\u02B5\u02BC\u02B4\u02BB\u02B4()
	{
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02B5\u02BC\u02BF\u02B3\u02B9\u02BB\u02C0\u02BF\u02C1\u02B7\u02B3().TryGetValue(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5, out text))
		{
			text = "song";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "band");
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B2 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B;
		string text3 = text2;
		string text4 = text;
		string text5 = text;
		\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] array = new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[1];
		array[1] = \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B5\u02B5\u02C0\u02B3\u02B4\u02BF\u02B7\u02B9\u02B6\u02B3\u02B8("");
		u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B2.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text3, text4, text5, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02BE\u02B3\u02B4\u02C0\u02B3\u02BC\u02BB\u02B6\u02C0\u02BD\u02B9(array)), true);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text6;
			do
			{
				text6 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text6) && (int)text6[0] == -120)
				{
					text6 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02C0\u02B5\u02BE\u02C0\u02C0\u02BD\u02BD\u02B4\u02BF\u02B5\u02B9(text6.Substring(1), null);
				}
				stringBuilder.AppendLine(text6);
			}
			while (text6 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x00008CA0 File Offset: 0x00006EA0
	private void \u02BF\u02B2\u02C1\u02C1\u02B6\u02BE\u02B3\u02BD\u02B8\u02B3\u02BE()
	{
		this.creditsText.text = Resources.Load<TextAsset>("Measure Based Countdowns").text;
		this.\u02C1\u02B8\u02BC\u02C1\u02BE\u02BC\u02C0\u02B3\u02B2\u02BF\u02BC();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00008CC8 File Offset: 0x00006EC8
	private void \u02B8\u02C1\u02B9\u02BC\u02B6\u02B9\u02B3\u02B5\u02B7\u02BF\u02BD()
	{
		this.creditsText.text = Resources.Load<TextAsset>("").text;
		this.\u02B4\u02B7\u02B8\u02B8\u02B3\u02BF\u02C1\u02BD\u02C0\u02C0\u02B6();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x00008CF0 File Offset: 0x00006EF0
	private void \u02B5\u02BD\u02BD\u02BE\u02B9\u02BD\u02B2\u02C1\u02C1\u02B3\u02B6()
	{
		this.creditsText.text = Resources.Load<TextAsset>("drumsorttip").text;
		this.\u02B8\u02BC\u02BA\u02BD\u02BC\u02BA\u02B3\u02BE\u02BD\u02B5\u02C1();
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x000364B4 File Offset: 0x000346B4
	private void \u02BB\u02B9\u02BA\u02C1\u02B7\u02C0\u02BB\u02B7\u02B5\u02B8\u02BB()
	{
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.TryGetValue(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B7\u02C1\u02BB\u02BF\u02BB\u02B2\u02C1\u02B8\u02BD\u02B5\u02C0(), out text))
		{
			text = "Disposed of memorymapped file";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "Highway Placement");
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B2 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B;
		string text3 = text2;
		string text4 = text;
		string text5 = text;
		\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] array = new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[0];
		array[1] = \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02C0\u02BC\u02BC\u02B9\u02BC\u02B8\u02B5\u02BE\u02BD\u02BE\u02B8("name");
		u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B2.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text3, text4, text5, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(array)), false);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text6;
			do
			{
				text6 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text6) && text6[0] == 'g')
				{
					text6 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02B2\u02B5\u02C1\u02B4\u02C0\u02B4\u02BE\u02BE\u02B6\u02BE\u02B7(text6.Substring(0), null);
				}
				stringBuilder.AppendLine(text6);
			}
			while (text6 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x000365AC File Offset: 0x000347AC
	private void \u02C1\u02BE\u02B3\u02B6\u02BF\u02BD\u02B9\u02C1\u02B8\u02BB\u02B6()
	{
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B = \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF.\u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5();
		string text;
		if (!u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.TryGetValue(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B7\u02C1\u02BB\u02BF\u02BB\u02B2\u02C1\u02B8\u02BD\u02B5\u02C0(), out text))
		{
			text = ".png|.jpg|.jpeg";
		}
		string text2 = Path.Combine(Application.persistentDataPath, text + "[");
		\u02B7\u02BF\u02BE\u02BB\u02BA\u02BB\u02B9\u02BC\u02B7\u02BC\u02B3 u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B2 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B;
		string text3 = text2;
		string text4 = text;
		string text5 = text;
		\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[] array = new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC[1];
		array[1] = \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B5\u02B5\u02C0\u02B3\u02B4\u02BF\u02B7\u02B9\u02B6\u02B3\u02B8("There was an error deleting the file");
		u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B2.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE>(text3, text4, text5, new \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA?(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02BE\u02B3\u02B4\u02C0\u02B3\u02BC\u02BB\u02B6\u02C0\u02BD\u02B9(array)), true);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringReader stringReader = new StringReader(this.creditsText.text))
		{
			string text6;
			do
			{
				text6 = stringReader.ReadLine();
				if (!string.IsNullOrEmpty(text6) && (int)text6[0] == -35)
				{
					text6 = u02B7_u02BF_u02BE_u02BB_u02BA_u02BB_u02B9_u02BC_u02B7_u02BC_u02B.\u02C0\u02B5\u02BE\u02C0\u02C0\u02BD\u02BD\u02B4\u02BF\u02B5\u02B9(text6.Substring(1), null);
				}
				stringBuilder.AppendLine(text6);
			}
			while (text6 != null);
		}
		this.creditsText.text = stringBuilder.ToString();
	}

	// Token: 0x0400040F RID: 1039
	[SerializeField]
	private TextMeshProUGUI creditsText;
}
