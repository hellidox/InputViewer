using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Rewired;
using StrikeCore;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.Video;

// Token: 0x02000067 RID: 103
public class GlobalVariables : MonoBehaviour
{
	// Token: 0x06000424 RID: 1060 RVA: 0x0003010C File Offset: 0x0002E30C
	public void \u02BD\u02BB\u02BE\u02BF\u02B4\u02BE\u02B9\u02B3\u02BF\u02B8\u02B9()
	{
		this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3 = new List<HighwayData>();
		string text = Path.Combine(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Change Instrument");
		string text2 = Path.Combine(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "_y");
		TextAsset textAsset = Resources.Load<TextAsset>("Continue");
		string[] array = JsonUtility.FromJson<GlobalVariables.InternalHighwayJsonData>(textAsset.text).highways;
		for (int i = 0; i < array.Length; i = i)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(array[i]);
			HighwayData highwayData = new HighwayData();
			highwayData.isResource = true;
			highwayData.path = fileNameWithoutExtension ?? "";
			highwayData.name = fileNameWithoutExtension;
			this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Add(highwayData);
		}
		textAsset = Resources.Load<TextAsset>("Songs");
		if (textAsset != null)
		{
			foreach (string text3 in JsonUtility.FromJson<GlobalVariables.InternalHighwayJsonData>(textAsset.text).highways)
			{
				HighwayData highwayData2 = new HighwayData();
				highwayData2.isResource = true;
				highwayData2.path = text3 ?? "";
				highwayData2.name = text3;
				highwayData2.isVideoHighway = false;
				TextAsset textAsset2 = Resources.Load<TextAsset>(highwayData2.path + "coda");
				string text4 = Settings.RegisterInternalConfigFileName("<OOB PATH>" + highwayData2.name, textAsset2.text);
				VideoHighwaySettings videoHighwaySettings = new VideoHighwaySettings();
				videoHighwaySettings.InitHighwaySettings(text4);
				highwayData2.videoHighwaySettings = videoHighwaySettings;
				Settings.Load(text4);
				this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Add(highwayData2);
			}
		}
		if (__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text2))
		{
			array = Directory.GetDirectories(text2, "languageRestartNeeded", SearchOption.AllDirectories);
			for (int k = 0; k < array.Length; k = k)
			{
				string text5 = array[k];
				string text6 = Path.Combine(text5, "Kick / Open Notes");
				if (File.Exists(text6))
				{
					this.\u02B6\u02BD\u02BD\u02BC\u02C1\u02BE\u02B4\u02B9\u02BD\u02BF\u02BE.Add(text6);
					HighwayData highwayData3 = new HighwayData();
					highwayData3.isResource = true;
					highwayData3.path = text5;
					highwayData3.isVideoHighway = true;
					highwayData3.name = Path.GetFileNameWithoutExtension(text5);
					string text7 = Settings.RegisterConfigFileName("charter" + highwayData3.name, Path.Combine(text5, "ScorePauseWarning"));
					VideoHighwaySettings videoHighwaySettings2 = new VideoHighwaySettings();
					videoHighwaySettings2.InitHighwaySettings(text7);
					highwayData3.videoHighwaySettings = videoHighwaySettings2;
					Settings.Load(text7);
					this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Add(highwayData3);
				}
			}
		}
		if (__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text))
		{
			string[] array2 = __FIXME_clon_util.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(text, "Alien", SearchOption.TopDirectoryOnly);
			this.\u02B7\u02BC\u02C0\u02B5\u02BF\u02B5\u02B6\u02B6\u02BB\u02B2\u02BA.AddRange(array2);
			array = array2;
			for (int l = 1; l < array.Length; l = l)
			{
				string text8 = array[l];
				string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(text8);
				HighwayData highwayData4 = new HighwayData();
				highwayData4.isResource = true;
				highwayData4.path = text8;
				highwayData4.name = fileNameWithoutExtension2;
				this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Add(highwayData4);
			}
		}
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x000303E0 File Offset: 0x0002E5E0
	public static Texture2D \u02C0\u02C0\u02B9\u02C1\u02B6\u02C1\u02C1\u02BA\u02BA\u02B9\u02B5(byte[] \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0, bool \u02B7\u02B6\u02B4\u02B9\u02B8\u02B9\u02B2\u02BA\u02B5\u02B3\u02BC = false)
	{
		if (\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0 == null)
		{
			return null;
		}
		Texture2D texture2D;
		using (SLImage slimage = new SLImage(\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0))
		{
			if (!slimage.\u02BD\u02B2\u02B8\u02B9\u02B2\u02C1\u02BE\u02BD\u02B6\u02BA\u02B6)
			{
				texture2D = null;
			}
			else
			{
				TextureCreationFlags textureCreationFlags = (\u02B7\u02B6\u02B4\u02B9\u02B8\u02B9\u02B2\u02BA\u02B5\u02B3\u02BC ? TextureCreationFlags.MipChain : TextureCreationFlags.None);
				Texture2D texture2D2 = new Texture2D(slimage.\u02BC\u02BB\u02C0\u02C1\u02B7\u02B8\u02BC\u02C0\u02BD\u02BD\u02B6, slimage.\u02B4\u02B5\u02BA\u02B6\u02B4\u02B4\u02BB\u02B7\u02BA\u02B5\u02B2, GraphicsFormat.R8G8B8A8_SRGB, textureCreationFlags);
				NativeArray<Color32> rawTextureData = texture2D2.GetRawTextureData<Color32>();
				slimage.\u02BC\u02BF\u02BC\u02B6\u02B8\u02B4\u02B6\u02B7\u02B6\u02C0\u02B2(rawTextureData);
				texture2D2.Apply();
				texture2D = texture2D2;
			}
		}
		return texture2D;
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00030454 File Offset: 0x0002E654
	public Instrument \u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE()
	{
		byte b = 0;
		Instrument instrument = Instrument.None;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in this.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo != null)
			{
				b += 1;
				if (b > 1)
				{
					instrument = Instrument.Band;
					break;
				}
				instrument = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.instrument;
			}
		}
		return instrument;
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00008183 File Offset: 0x00006383
	public void \u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(bool \u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE = false)
	{
		base.StartCoroutine(this.\u02B3\u02B2\u02BD\u02BD\u02BD\u02BB\u02BC\u02B2\u02BB\u02BF\u02B5(\u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE));
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x000304D0 File Offset: 0x0002E6D0
	private void \u02C0\u02B5\u02B3\u02B7\u02B9\u02BC\u02B4\u02C0\u02B7\u02B2\u02BA(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		if (!__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC))
		{
			return;
		}
		foreach (string text in __FIXME_clon_util.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC, ".png|.jpg|.jpeg", SearchOption.AllDirectories))
		{
			Texture2D texture2D = GlobalVariables.\u02C0\u02B8\u02C1\u02B5\u02B4\u02B8\u02B6\u02B6\u02BB\u02BC\u02B5(text);
			if (!(texture2D == null))
			{
				Sprite sprite = GlobalVariables.\u02BA\u02B7\u02B4\u02B5\u02B2\u02BC\u02B9\u02B5\u02B9\u02BE\u02B8(texture2D);
				if (!(sprite == null))
				{
					string text2 = Path.GetFileNameWithoutExtension(text).ToLowerInvariant();
					if (!this.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3.ContainsKey(text2))
					{
						this.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3.Add(text2, sprite);
					}
				}
			}
		}
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00030554 File Offset: 0x0002E754
	public FullScreenMode \u02B8\u02B6\u02BD\u02BC\u02BB\u02BD\u02BB\u02B8\u02C0\u02C0\u02C1()
	{
		switch (SettingsController.\u02BD\u02BF\u02B7\u02B9\u02B6\u02B8\u02BB\u02BA\u02B7\u02B8\u02B3.CurrentValue)
		{
		case 0:
			return FullScreenMode.Windowed;
		case 1:
			return FullScreenMode.FullScreenWindow;
		case 2:
			return FullScreenMode.ExclusiveFullScreen;
		default:
			return FullScreenMode.Windowed;
		}
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00030588 File Offset: 0x0002E788
	public void \u02B7\u02BE\u02C0\u02B2\u02C1\u02C0\u02B6\u02BB\u02B7\u02B4\u02B3()
	{
		this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3 = new List<HighwayData>();
		string text = Path.Combine(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Highways");
		string text2 = Path.Combine(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Video Highways");
		TextAsset textAsset = Resources.Load<TextAsset>("Highways/highways");
		string[] array = JsonUtility.FromJson<GlobalVariables.InternalHighwayJsonData>(textAsset.text).highways;
		for (int i = 0; i < array.Length; i++)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(array[i]);
			HighwayData highwayData = new HighwayData();
			highwayData.isResource = true;
			highwayData.path = "Highways/" + fileNameWithoutExtension;
			highwayData.name = fileNameWithoutExtension;
			this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Add(highwayData);
		}
		textAsset = Resources.Load<TextAsset>("Highways/videoHighways");
		if (textAsset != null)
		{
			foreach (string text3 in JsonUtility.FromJson<GlobalVariables.InternalHighwayJsonData>(textAsset.text).highways)
			{
				HighwayData highwayData2 = new HighwayData();
				highwayData2.isResource = true;
				highwayData2.path = "Highways/" + text3;
				highwayData2.name = text3;
				highwayData2.isVideoHighway = true;
				TextAsset textAsset2 = Resources.Load<TextAsset>(highwayData2.path + "/config");
				string text4 = Settings.RegisterInternalConfigFileName("highway_" + highwayData2.name, textAsset2.text);
				VideoHighwaySettings videoHighwaySettings = new VideoHighwaySettings();
				videoHighwaySettings.InitHighwaySettings(text4);
				highwayData2.videoHighwaySettings = videoHighwaySettings;
				Settings.Load(text4);
				this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Add(highwayData2);
			}
		}
		if (__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text2))
		{
			foreach (string text5 in Directory.GetDirectories(text2, "*", SearchOption.AllDirectories))
			{
				string text6 = Path.Combine(text5, "highway.webm");
				if (File.Exists(text6))
				{
					this.\u02B6\u02BD\u02BD\u02BC\u02C1\u02BE\u02B4\u02B9\u02BD\u02BF\u02BE.Add(text6);
					HighwayData highwayData3 = new HighwayData();
					highwayData3.isResource = false;
					highwayData3.path = text5;
					highwayData3.isVideoHighway = true;
					highwayData3.name = Path.GetFileNameWithoutExtension(text5);
					string text7 = Settings.RegisterConfigFileName("highway_" + highwayData3.name, Path.Combine(text5, "config.ini"));
					VideoHighwaySettings videoHighwaySettings2 = new VideoHighwaySettings();
					videoHighwaySettings2.InitHighwaySettings(text7);
					highwayData3.videoHighwaySettings = videoHighwaySettings2;
					Settings.Load(text7);
					this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Add(highwayData3);
				}
			}
		}
		if (__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text))
		{
			string[] array2 = __FIXME_clon_util.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(text, ".png|.jpg|.jpeg", SearchOption.AllDirectories);
			this.\u02B7\u02BC\u02C0\u02B5\u02BF\u02B5\u02B6\u02B6\u02BB\u02B2\u02BA.AddRange(array2);
			foreach (string text8 in array2)
			{
				string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(text8);
				HighwayData highwayData4 = new HighwayData();
				highwayData4.isResource = false;
				highwayData4.path = text8;
				highwayData4.name = fileNameWithoutExtension2;
				this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Add(highwayData4);
			}
		}
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00030864 File Offset: 0x0002EA64
	public void \u02B2\u02BE\u02BE\u02B6\u02B5\u02BB\u02C0\u02C0\u02B6\u02C1\u02B8(bool \u02C1\u02BB\u02B2\u02B7\u02BD\u02B9\u02BF\u02C0\u02B6\u02C0\u02B3)
	{
		QualitySettings.vSyncCount = (SettingsController.\u02B3\u02B2\u02BD\u02C1\u02B2\u02B4\u02B5\u02B3\u02C1\u02B2\u02B6 ? 0 : 0);
		if (\u02C1\u02BB\u02B2\u02B7\u02BD\u02B9\u02BF\u02C0\u02B6\u02C0\u02B3)
		{
			Application.targetFrameRate = Screen.currentResolution.refreshRate;
			return;
		}
		if (SettingsController.fpsCap.CurrentValue > -114)
		{
			Application.targetFrameRate = -1;
			return;
		}
		Application.targetFrameRate = SettingsController.fpsCap.CurrentValue;
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x000308C4 File Offset: 0x0002EAC4
	public void \u02BC\u02B2\u02BA\u02C1\u02C0\u02BF\u02B8\u02C0\u02B6\u02BA\u02B2(bool \u02BF\u02BC\u02BE\u02B2\u02B4\u02B3\u02BC\u02BF\u02BF\u02B8\u02B8 = false)
	{
		ThumbnailCache.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02BF\u02B2\u02B6\u02B6\u02B2\u02B5\u02BF\u02BF\u02BB\u02B5();
		string text = __FIXME_clon_util.\u02BB\u02B6\u02B4\u02BC\u02B5\u02B9\u02BA\u02BD\u02B7\u02B4\u02B3();
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		foreach (string text2 in this.\u02B7\u02BC\u02C0\u02B5\u02BF\u02B5\u02B6\u02B6\u02BB\u02B2\u02BA)
		{
			string text3 = ThumbnailCache.\u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(text2);
			if (\u02BF\u02BC\u02BE\u02B2\u02B4\u02B3\u02BC\u02BF\u02BF\u02B8\u02B8 || !File.Exists(text3))
			{
				ThumbnailCache.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B9\u02B9\u02BD\u02B2\u02B8\u02B9\u02B7\u02BC\u02B4\u02B6(text2);
			}
		}
		List<string> list = new List<string>();
		foreach (string text4 in this.\u02B6\u02BD\u02BD\u02BC\u02C1\u02BE\u02B4\u02B9\u02BD\u02BF\u02BE)
		{
			string text5 = ThumbnailCache.\u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(text4);
			if (\u02BF\u02BC\u02BE\u02B2\u02B4\u02B3\u02BC\u02BF\u02BF\u02B8\u02B8 || !File.Exists(text5))
			{
				list.Add(text4);
			}
		}
		foreach (string text6 in this.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB)
		{
			string text7 = ThumbnailCache.\u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(text6);
			if (\u02BF\u02BC\u02BE\u02B2\u02B4\u02B3\u02BC\u02BF\u02BF\u02B8\u02B8 || !File.Exists(text7))
			{
				list.Add(text6);
			}
		}
		VideoClip[] array = Resources.LoadAll<VideoClip>("Highways/");
		base.StartCoroutine(ThumbnailCache.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02BF\u02B4\u02BF\u02B6\u02B6\u02BE\u02B5\u02C0\u02B4\u02B9(list.ToArray(), array));
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x00008193 File Offset: 0x00006393
	public static Texture2D \u02C0\u02B8\u02C1\u02B5\u02B4\u02B8\u02B6\u02B6\u02BB\u02BC\u02B5(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		if (!File.Exists(\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC))
		{
			return null;
		}
		return GlobalVariables.\u02C0\u02C0\u02B9\u02C1\u02B6\u02C1\u02C1\u02BA\u02BA\u02B9\u02B5(File.ReadAllBytes(\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC), false);
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x000081AB File Offset: 0x000063AB
	public void \u02B9\u02BC\u02BB\u02BC\u02C1\u02C0\u02B4\u02B9\u02BC\u02BC\u02C0(bool \u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE = false)
	{
		base.StartCoroutine(this.\u02B9\u02C1\u02BB\u02B8\u02BA\u02BC\u02BA\u02BC\u02B8\u02B5\u02B2(\u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE));
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00030A14 File Offset: 0x0002EC14
	public Texture2D \u02BC\u02B3\u02C1\u02C0\u02B6\u02B2\u02BE\u02B7\u02C1\u02BF\u02B5(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, bool \u02BE\u02C1\u02B2\u02C1\u02B7\u02BC\u02B8\u02B7\u02B5\u02B3\u02B9 = false)
	{
		HighwayData highwayData = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5];
		if (highwayData.isVideoHighway && !\u02BE\u02C1\u02B2\u02C1\u02B7\u02BC\u02B8\u02B7\u02B5\u02B3\u02B9)
		{
			return null;
		}
		if (highwayData.isResource && !highwayData.isVideoHighway)
		{
			return Resources.Load<Texture2D>(highwayData.path);
		}
		string text = highwayData.path;
		if (\u02BE\u02C1\u02B2\u02C1\u02B7\u02BC\u02B8\u02B7\u02B5\u02B3\u02B9)
		{
			if (highwayData.isVideoHighway)
			{
				if (highwayData.isResource)
				{
					text = Resources.Load<VideoClip>(highwayData.path + "/highway").originalPath;
				}
				else
				{
					text = Path.Combine(text, "highway.webm");
				}
			}
			text = ThumbnailCache.\u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(text);
		}
		if (File.Exists(text))
		{
			byte[] array = File.ReadAllBytes(text);
			Texture2D texture2D = GlobalVariables.\u02C0\u02C0\u02B9\u02C1\u02B6\u02C1\u02C1\u02BA\u02BA\u02B9\u02B5(array, true);
			if (array != null)
			{
				return texture2D;
			}
		}
		return null;
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x000081BB File Offset: 0x000063BB
	private static string \u02C1\u02BF\u02B3\u02B6\u02B9\u02BE\u02BB\u02BA\u02B3\u02B5\u02B7(string \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0)
	{
		return \u02C1\u02B2\u02B8\u02B9\u02C0\u02BC\u02B9\u02B9\u02B6\u02B2\u02B3.\u02B6\u02B3\u02BD\u02BB\u02BE\u02B7\u02BF\u02BC\u02B2\u02BE\u02B8(SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0)));
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x00030AC0 File Offset: 0x0002ECC0
	private void Update()
	{
		if ((Time.frameCount & 15) == 1)
		{
			this.\u02B6\u02BC\u02B4\u02B9\u02B7\u02B4\u02BE\u02BF\u02B4\u02BE\u02B4(false);
		}
		if (Screen.fullScreenMode != this.\u02B3\u02C0\u02BD\u02BB\u02BC\u02BF\u02B7\u02B7\u02B9\u02B4\u02BA)
		{
			this.\u02B3\u02C0\u02BD\u02BB\u02BC\u02BF\u02B7\u02B7\u02B9\u02B4\u02BA = Screen.fullScreenMode;
			int num = 0;
			if (this.\u02B3\u02C0\u02BD\u02BB\u02BC\u02BF\u02B7\u02B7\u02B9\u02B4\u02BA == FullScreenMode.FullScreenWindow)
			{
				num = 1;
			}
			else if (this.\u02B3\u02C0\u02BD\u02BB\u02BC\u02BF\u02B7\u02B7\u02B9\u02B4\u02BA == FullScreenMode.ExclusiveFullScreen)
			{
				num = 2;
			}
			if (SettingsController.\u02BD\u02BF\u02B7\u02B9\u02B6\u02B8\u02BB\u02BA\u02B7\u02B8\u02B3.CurrentValue != num)
			{
				SettingsController.\u02BD\u02BF\u02B7\u02B9\u02B6\u02B8\u02BB\u02BA\u02B7\u02B8\u02B3.CurrentValue = num;
			}
			if (this.\u02B6\u02B3\u02B7\u02B5\u02BB\u02BD\u02B3\u02B9\u02BD\u02B2\u02B7 != null)
			{
				Delegate[] invocationList = this.\u02B6\u02B3\u02B7\u02B5\u02BB\u02BD\u02B3\u02B9\u02BD\u02B2\u02B7.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					invocationList[i].DynamicInvoke(Array.Empty<object>());
				}
			}
		}
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00030B58 File Offset: 0x0002ED58
	public static Texture2D \u02B3\u02BE\u02B9\u02BE\u02B2\u02C0\u02BB\u02B8\u02B9\u02B5\u02B5(byte[] \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0, bool \u02B7\u02B6\u02B4\u02B9\u02B8\u02B9\u02B2\u02BA\u02B5\u02B3\u02BC = false)
	{
		if (\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0 == null)
		{
			return null;
		}
		Texture2D texture2D;
		using (SLImage slimage = new SLImage(\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0))
		{
			if (!slimage.\u02BD\u02B2\u02B8\u02B9\u02B2\u02C1\u02BE\u02BD\u02B6\u02BA\u02B6)
			{
				texture2D = null;
			}
			else
			{
				TextureCreationFlags textureCreationFlags = (\u02B7\u02B6\u02B4\u02B9\u02B8\u02B9\u02B2\u02BA\u02B5\u02B3\u02BC ? TextureCreationFlags.MipChain : TextureCreationFlags.MipChain);
				Texture2D texture2D2 = new Texture2D(slimage.\u02BC\u02BB\u02C0\u02C1\u02B7\u02B8\u02BC\u02C0\u02BD\u02BD\u02B6, slimage.\u02B4\u02B5\u02BA\u02B6\u02B4\u02B4\u02BB\u02B7\u02BA\u02B5\u02B2, GraphicsFormat.R8G8_SRGB, textureCreationFlags);
				NativeArray<Color32> rawTextureData = texture2D2.GetRawTextureData<Color32>();
				slimage.\u02BC\u02BF\u02BC\u02B6\u02B8\u02B4\u02B6\u02B7\u02B6\u02C0\u02B2(rawTextureData);
				texture2D2.Apply();
				texture2D = texture2D2;
			}
		}
		return texture2D;
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x00030BCC File Offset: 0x0002EDCC
	public void \u02BC\u02BE\u02B5\u02BC\u02B6\u02B5\u02BA\u02BD\u02B6\u02B5\u02B8(bool \u02BF\u02BC\u02BE\u02B2\u02B4\u02B3\u02BC\u02BF\u02BF\u02B8\u02B8 = false)
	{
		this.\u02B7\u02B4\u02BB\u02C0\u02B5\u02B6\u02B6\u02B9\u02B9\u02B3\u02C0(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8);
		if (!__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8))
		{
			SettingsController.\u02B3\u02B2\u02B9\u02C0\u02B3\u02BC\u02B4\u02BD\u02B3\u02C1\u02BC.Reset();
			SettingsController.\u02B7\u02B9\u02BF\u02BD\u02B9\u02B5\u02C0\u02BA\u02BC\u02BD\u02BE.Reset();
			return;
		}
		this.\u02BE\u02C0\u02BB\u02B6\u02B5\u02BA\u02B7\u02B3\u02B5\u02B3\u02C1();
		this.\u02B7\u02BE\u02C0\u02B2\u02C1\u02C0\u02B6\u02BB\u02B7\u02B4\u02B3();
		this.\u02BB\u02C1\u02BC\u02BE\u02B3\u02C1\u02B5\u02B3\u02BA\u02B8\u02BB();
		this.\u02BC\u02B2\u02BA\u02C1\u02C0\u02BF\u02B8\u02C0\u02B6\u02BA\u02B2(\u02BF\u02BC\u02BE\u02B2\u02B4\u02B3\u02BC\u02BF\u02BF\u02B8\u02B8);
		this.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B4\u02C0\u02B4\u02B6\u02BC\u02BE\u02BE\u02B8\u02BA\u02BC\u02B7();
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00030C2C File Offset: 0x0002EE2C
	public static Sprite \u02BA\u02B7\u02B4\u02B5\u02B2\u02BC\u02B9\u02B5\u02B9\u02BE\u02B8(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		if (\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9 == null)
		{
			return null;
		}
		\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.wrapMode = TextureWrapMode.Clamp;
		return Sprite.Create(\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9, new Rect(0f, 0f, (float)\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.width, (float)\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.height), new Vector2(0f, 0f), 100f, 0U, SpriteMeshType.FullRect);
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00030C84 File Offset: 0x0002EE84
	private void \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		this.\u02B4\u02B6\u02C1\u02BD\u02BA\u02BE\u02C1\u02B9\u02B2\u02BD\u02B9 = "{0:N0}";
		this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8 = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "whammy_sfx");
		this.\u02C0\u02BD\u02B8\u02B9\u02BA\u02B6\u02B4\u02BB\u02B2\u02B6\u02B3 = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "profiles.bin");
		__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(this.\u02C0\u02BD\u02B8\u02B9\u02BA\u02B6\u02B4\u02BB\u02B2\u02B6\u02B3);
		this.\u02B2\u02BE\u02BE\u02B6\u02B5\u02BB\u02C0\u02C0\u02B6\u02C1\u02B8(false);
		ReInput.configuration.joystickRefreshRate = SettingsController.\u02BC\u02BA\u02BE\u02B9\u02B5\u02BD\u02C1\u02B8\u02B7\u02C0\u02B8.CurrentValue;
		Cursor.visible = SettingsController.\u02BD\u02C1\u02B5\u02B3\u02BA\u02BC\u02B9\u02B8\u02B7\u02B8\u02C0;
		QualitySettings.antiAliasing = SettingsController.msaaLevel.CurrentValue;
		this.\u02BC\u02BE\u02B5\u02BC\u02B6\u02B5\u02BA\u02BD\u02B6\u02B5\u02B8(true);
		this.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA();
		this.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B6\u02B3\u02BB\u02C0\u02BC\u02BD\u02BD\u02BA\u02B4\u02BD\u02B8();
		Dictionary<string, object> dictionary = new Dictionary<string, object>
		{
			{ "Default Sort Filter", this.\u02B4\u02B3\u02B7\u02BC\u02B5\u02B3\u02B8\u02BB\u02BE\u02B5\u02B3 },
			{
				"{0:n0}",
				SettingsController.\u02B3\u02B2\u02BD\u02C1\u02B2\u02B4\u02B5\u02B3\u02C1\u02B2\u02B6.GetBoolValue
			},
			{
				"No songs were found!",
				this.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[SettingsController.\u02B7\u02B3\u02BF\u02BF\u02B4\u02B8\u02C0\u02BB\u02BB\u02BF\u02BE.CurrentValue]
			},
			{
				"song",
				SettingsController.\u02BB\u02C0\u02B7\u02B8\u02B3\u02BE\u02B7\u02BB\u02BA\u02B8\u02BA.GetBoolValue
			},
			{
				"hasExpert",
				SettingsController.\u02BF\u02BF\u02BB\u02BF\u02B2\u02BE\u02B5\u02BD\u02C0\u02B4\u02B9.GetBoolValue
			},
			{
				"Rename Setlist",
				SettingsController.fpsCap.CurrentValue
			}
		};
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02C1\u02B6\u02B3\u02C0\u02B4\u02BB\u02BF\u02BF\u02B7\u02B2\u02C0("\\", dictionary);
		if (!this.\u02BC\u02BC\u02B5\u02B3\u02BE\u02BD\u02BA\u02B7\u02BF\u02B2\u02BD)
		{
			GameObject gameObject = GameObject.Find(".sng");
			if (gameObject != null)
			{
				gameObject.GetComponent<SongScan>().\u02BA\u02B9\u02C0\u02C1\u02BF\u02BB\u02B3\u02B9\u02BB\u02B5\u02B3(true);
			}
			else
			{
				Debug.LogWarning("version");
			}
		}
		this.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5 = true;
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x00030E08 File Offset: 0x0002F008
	private void Start()
	{
		this.\u02B4\u02B6\u02C1\u02BD\u02BA\u02BE\u02C1\u02B9\u02B2\u02BD\u02B9 = ".mp4|.avi|.webm|.vp8|.ogv|.mpeg";
		this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8 = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "Custom");
		this.\u02C0\u02BD\u02B8\u02B9\u02BA\u02B6\u02B4\u02BB\u02B2\u02B6\u02B3 = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "Screenshots");
		__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(this.\u02C0\u02BD\u02B8\u02B9\u02BA\u02B6\u02B4\u02BB\u02B2\u02B6\u02B3);
		this.\u02B6\u02BC\u02B4\u02B9\u02B7\u02B4\u02BE\u02BF\u02B4\u02BE\u02B4(true);
		ReInput.configuration.joystickRefreshRate = SettingsController.\u02BC\u02BA\u02BE\u02B9\u02B5\u02BD\u02C1\u02B8\u02B7\u02C0\u02B8.CurrentValue;
		Cursor.visible = SettingsController.\u02BD\u02C1\u02B5\u02B3\u02BA\u02BC\u02B9\u02B8\u02B7\u02B8\u02C0;
		QualitySettings.antiAliasing = SettingsController.msaaLevel.CurrentValue;
		this.\u02BC\u02BE\u02B5\u02BC\u02B6\u02B5\u02BA\u02BD\u02B6\u02B5\u02B8(false);
		this.\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA();
		this.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA.\u02B8\u02B6\u02B7\u02B2\u02B6\u02B3\u02B6\u02BD\u02BC\u02B8\u02C0();
		Dictionary<string, object> dictionary = new Dictionary<string, object>
		{
			{ "gameVersion", this.\u02B4\u02B3\u02B7\u02BC\u02B5\u02B3\u02B8\u02BB\u02BE\u02B5\u02B3 },
			{
				"vsyncEnabled",
				SettingsController.\u02B3\u02B2\u02BD\u02C1\u02B2\u02B4\u02B5\u02B3\u02C1\u02B2\u02B6.GetBoolValue
			},
			{
				"language",
				this.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[SettingsController.\u02B7\u02B3\u02BF\u02BF\u02B4\u02B8\u02C0\u02BB\u02BB\u02BF\u02BE.CurrentValue]
			},
			{
				"noFailEnabled",
				SettingsController.\u02BB\u02C0\u02B7\u02B8\u02B3\u02BE\u02B7\u02BB\u02BA\u02B8\u02BA.GetBoolValue
			},
			{
				"highwayShakeEnabled",
				SettingsController.\u02BF\u02BF\u02BB\u02BF\u02B2\u02BE\u02B5\u02BD\u02C0\u02B4\u02B9.GetBoolValue
			},
			{
				"targetFramerate",
				SettingsController.fpsCap.CurrentValue
			}
		};
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02C1\u02B6\u02B3\u02C0\u02B4\u02BB\u02BF\u02BF\u02B7\u02B2\u02C0("clientInfo", dictionary);
		if (!this.\u02BC\u02BC\u02B5\u02B3\u02BE\u02BD\u02BA\u02B7\u02BF\u02B2\u02BD)
		{
			GameObject gameObject = GameObject.Find("SongScan");
			if (gameObject != null)
			{
				gameObject.GetComponent<SongScan>().\u02BA\u02B9\u02C0\u02C1\u02BF\u02BB\u02B3\u02B9\u02BB\u02B5\u02B3(false);
			}
			else
			{
				Debug.LogWarning("Failed to find \"SongScan\" game object. Startup song scanning has been disabled.");
			}
		}
		this.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5 = true;
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x000081D7 File Offset: 0x000063D7
	private IEnumerator \u02B9\u02C1\u02BB\u02B8\u02BA\u02BC\u02BA\u02BC\u02B8\u02B5\u02B2(bool \u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE = false)
	{
		GlobalVariables.\u02BD\u02BA\u02BF\u02BE\u02BD\u02B2\u02B9\u02B7\u02B6\u02B7\u02C0 u02BD_u02BA_u02BF_u02BE_u02BD_u02B2_u02B9_u02B7_u02B6_u02B7_u02C = new GlobalVariables.\u02BD\u02BA\u02BF\u02BE\u02BD\u02B2\u02B9\u02B7\u02B6\u02B7\u02C0(1);
		u02BD_u02BA_u02BF_u02BE_u02BD_u02B2_u02B9_u02B7_u02B6_u02B7_u02C.<>4__this = this;
		u02BD_u02BA_u02BF_u02BE_u02BD_u02B2_u02B9_u02B7_u02B6_u02B7_u02C.forceAll = \u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE;
		return u02BD_u02BA_u02BF_u02BE_u02BD_u02B2_u02B9_u02B7_u02B6_u02B7_u02C;
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x000081ED File Offset: 0x000063ED
	public void \u02B6\u02BC\u02B4\u02B9\u02B7\u02B4\u02BE\u02BF\u02B4\u02BE\u02B4(bool \u02C1\u02BB\u02B2\u02B7\u02BD\u02B9\u02BF\u02C0\u02B6\u02C0\u02B3)
	{
		if ((Time.frameCount & 255) == 0)
		{
			return;
		}
		Application.targetFrameRate = SettingsController.fpsCap * OnDemandRendering.renderFrameInterval;
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x00030F8C File Offset: 0x0002F18C
	private void Awake()
	{
		GlobalVariables.LoadStats();
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 = this;
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.\u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA = new \u02B7\u02BE\u02BA\u02BE\u02BA\u02B2\u02BF\u02B2\u02C0\u02B2\u02C0();
		this.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF = new \u02B5\u02B4\u02BA\u02C1\u02B5\u02BD\u02BE\u02B9\u02B8\u02B9\u02C0();
		this.\u02B4\u02B3\u02B7\u02BC\u02B5\u02B3\u02B8\u02BB\u02BE\u02B5\u02B3 = Resources.Load<TextAsset>("version").text;
		this.\u02B5\u02BF\u02BD\u02B8\u02B7\u02B3\u02BC\u02B6\u02B4\u02BB\u02B5 = GlobalVariables.\u02C1\u02BF\u02B3\u02B6\u02B9\u02BE\u02BB\u02BA\u02B3\u02B5\u02B7(this.\u02B4\u02B3\u02B7\u02BC\u02B5\u02B3\u02B8\u02BB\u02BE\u02B5\u02B3);
		Screen.sleepTimeout = -1;
		this.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF = new List<\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6>
		{
			new \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6(),
			new \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6(),
			new \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6(),
			new \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6()
		};
		base.gameObject.AddComponent<DiscordController>().\u02B5\u02BE\u02BA\u02B2\u02BD\u02BB\u02B9\u02BE\u02BA\u02B2\u02B3();
		this.\u02B5\u02B3\u02B3\u02BB\u02BA\u02BB\u02C0\u02BE\u02B2\u02B5\u02B9();
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00031054 File Offset: 0x0002F254
	private string \u02C0\u02BA\u02BA\u02C1\u02B6\u02B5\u02B4\u02BC\u02BF\u02BC\u02BA()
	{
		return StringUtils.StripTags(SettingsController.\u02BC\u02B4\u02B2\u02B2\u02B6\u02B3\u02BB\u02B8\u02B2\u02C1\u02B3.CurrentValue.Replace("%a", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5).Replace("%s", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5 + (SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.IsPresetValue ? "" : (" (" + SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.GetPercentString + ")"))).Replace("%n", Environment.NewLine)
			.Replace("%y", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Year.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("%g", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Genre.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("%p", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Playlist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("%b", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Album.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("%c", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Charter.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("%l", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.songLength.ToString()), false);
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00031184 File Offset: 0x0002F384
	public void \u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB()
	{
		this.\u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9.Clear();
		bool flag = __FIXME_clon_util.\u02B4\u02B4\u02C0\u02C1\u02BF\u02B5\u02B4\u02BD\u02B2\u02B2\u02BE();
		this.\u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9.Add(flag ? this.\u02B5\u02BB\u02B7\u02BB\u02B8\u02B5\u02B9\u02BA\u02B3\u02B8\u02BA : this.\u02B5\u02BB\u02B7\u02BB\u02B8\u02B5\u02B9\u02BA\u02B3\u02B8\u02BA.ToLowerInvariant());
		foreach (string text in SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4.CurrentValue)
		{
			if (text != null)
			{
				string text2 = text.Replace('\\', Path.DirectorySeparatorChar).Replace('/', Path.DirectorySeparatorChar);
				bool flag2 = false;
				foreach (char c in Path.GetInvalidPathChars())
				{
					if (text2.Contains(c))
					{
						flag2 = true;
					}
				}
				if (flag2)
				{
					Debug.Log("Bad char detected, Skipped " + text2);
				}
				else if (text2.Length > 0)
				{
					text2 = Path.GetFullPath(text2);
					if (text2[text2.Length - 1] == Path.DirectorySeparatorChar)
					{
						text2 = text2.Remove(text2.Length - 1, 1);
					}
					string text3 = (flag ? text2 : text2.ToLowerInvariant());
					if (!this.\u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9.Contains(text3))
					{
						this.\u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9.Add(text3);
					}
				}
			}
		}
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x000312BC File Offset: 0x0002F4BC
	public int \u02B3\u02B3\u02B4\u02B2\u02BA\u02BB\u02B8\u02C1\u02B3\u02BE\u02B5(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		if (\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 == "clientnostart")
		{
			return -1;
		}
		for (int i = 1; i < this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Count; i++)
		{
			if (this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[i].name == \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
			{
				return i;
			}
		}
		return 0;
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x0003130C File Offset: 0x0002F50C
	public static Texture2D \u02B4\u02B7\u02BF\u02BC\u02B4\u02B2\u02BF\u02B8\u02BF\u02BF\u02BE(string \u02C0\u02C1\u02BC\u02C1\u02B8\u02B2\u02BA\u02B4\u02B5\u02B6\u02B5, params string[] \u02C0\u02BF\u02BA\u02B7\u02C0\u02C0\u02B2\u02BA\u02B3\u02B7\u02BB)
	{
		foreach (string text in \u02C0\u02BF\u02BA\u02B7\u02C0\u02C0\u02B2\u02BA\u02B3\u02B7\u02BB)
		{
			string text2 = Path.Combine(\u02C0\u02C1\u02BC\u02C1\u02B8\u02B2\u02BA\u02B4\u02B5\u02B6\u02B5, text);
			if (File.Exists(text2))
			{
				Texture2D texture2D = GlobalVariables.\u02C0\u02B8\u02C1\u02B5\u02B4\u02B8\u02B6\u02B6\u02BB\u02BC\u02B5(text2);
				if (texture2D)
				{
					return texture2D;
				}
			}
		}
		return null;
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x00031354 File Offset: 0x0002F554
	private string \u02C1\u02C1\u02C1\u02B9\u02BA\u02B4\u02B9\u02B4\u02B6\u02B9\u02BA()
	{
		return StringUtils.StripTags(SettingsController.\u02BC\u02B4\u02B2\u02B2\u02B6\u02B3\u02BB\u02B8\u02B2\u02C1\u02B3.CurrentValue.Replace("Export Current Song", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5).Replace("charter", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5 + (SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.IsPresetValue ? "DoubleGuitar" : ("song" + SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.GetPercentString + "Random"))).Replace("Flames", Environment.NewLine)
			.Replace("{0}: {1}", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Year.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("offset", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Genre.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace("hasExpert", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Playlist.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace("</color>", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.\u02B6\u02B7\u02B2\u02C1\u02B9\u02B3\u02B8\u02BC\u02B4\u02BD\u02BB().\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace("Allow Clients To Remove Songs", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Charter.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("6 Fret Bass Guitar", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.songLength.ToString()), true);
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x00031484 File Offset: 0x0002F684
	public bool \u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA()
	{
		if (this.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[SettingsController.\u02B7\u02B3\u02BF\u02BF\u02B4\u02B8\u02C0\u02BB\u02BB\u02BF\u02BE.CurrentValue] == \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5)
		{
			return false;
		}
		\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B8\u02C0\u02B9\u02B9\u02B4\u02B7\u02BD\u02BE\u02B7\u02BC\u02B2(this.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[SettingsController.\u02B7\u02B3\u02BF\u02BF\u02B4\u02B8\u02C0\u02BB\u02BB\u02BF\u02BE.CurrentValue]);
		TipLanguage[] array = global::UnityEngine.Object.FindObjectsOfType<TipLanguage>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA();
		}
		TranslateTextMeshPro[] array2 = global::UnityEngine.Object.FindObjectsOfType<TranslateTextMeshPro>();
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].\u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA();
		}
		PlayerProfileMenu[] array3 = global::UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>();
		for (int i = 0; i < array3.Length; i++)
		{
			array3[i].\u02C1\u02B4\u02BD\u02BD\u02BA\u02BD\u02B5\u02BE\u02B7\u02B8\u02C0(false);
		}
		return true;
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00031528 File Offset: 0x0002F728
	public void \u02BB\u02C1\u02BC\u02BE\u02B3\u02C1\u02B5\u02B3\u02BA\u02B8\u02BB()
	{
		string text = Path.Combine(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Image Backgrounds");
		if (__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text))
		{
			this.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF = __FIXME_clon_util.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(text, ".png|.jpg|.jpeg", SearchOption.AllDirectories);
		}
		this.\u02B7\u02BC\u02C0\u02B5\u02BF\u02B5\u02B6\u02B6\u02BB\u02B2\u02BA.AddRange(this.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF);
		if (this.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF == null || this.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF.Length == 0)
		{
			SettingsController.\u02B3\u02B2\u02B9\u02C0\u02B3\u02BC\u02B4\u02BD\u02B3\u02C1\u02BC.Reset();
		}
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x0003158C File Offset: 0x0002F78C
	public void \u02BD\u02B5\u02B4\u02B2\u02BA\u02B5\u02BD\u02BF\u02BE\u02BC\u02BB(bool \u02B3\u02BC\u02B6\u02B5\u02B4\u02B9\u02B4\u02BD\u02B8\u02B9\u02B6)
	{
		if (!SettingsController.\u02BA\u02BF\u02BF\u02B7\u02B4\u02B6\u02BD\u02BC\u02BE\u02B5\u02BA)
		{
			return;
		}
		try
		{
			string text = this.\u02C0\u02BA\u02BA\u02C1\u02B6\u02B5\u02B4\u02BC\u02BF\u02BC\u02BA();
			using (Stream stream = File.Create(Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "currentsong.txt")))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					if (!\u02B3\u02BC\u02B6\u02B5\u02B4\u02B9\u02B4\u02BD\u02B8\u02B9\u02B6)
					{
						streamWriter.Write(text);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogException(ex);
		}
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00031620 File Offset: 0x0002F820
	public bool \u02B4\u02B5\u02B7\u02B4\u02B3\u02B8\u02BE\u02C0\u02B5\u02B4\u02B4()
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in this.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02C0\u02B5\u02B2\u02B2\u02BB\u02B8\u02B8\u02BD\u02B9\u02BD\u02C1())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00031684 File Offset: 0x0002F884
	public void \u02BE\u02C0\u02BB\u02B6\u02B5\u02BA\u02B7\u02B3\u02B5\u02B3\u02C1()
	{
		string text = Path.Combine(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Video Backgrounds");
		if (__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text))
		{
			this.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB = __FIXME_clon_util.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(text, this.\u02B4\u02B6\u02C1\u02BD\u02BA\u02BE\u02C1\u02B9\u02B2\u02BD\u02B9, SearchOption.AllDirectories);
		}
		if (this.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB == null || this.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB.Length == 0)
		{
			SettingsController.\u02B7\u02B9\u02BF\u02BD\u02B9\u02B5\u02C0\u02BA\u02BC\u02BD\u02BE.Reset();
		}
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x000316D8 File Offset: 0x0002F8D8
	public void \u02B8\u02B8\u02B9\u02B9\u02B2\u02B2\u02B9\u02B8\u02B5\u02C1\u02B6()
	{
		string text = Path.Combine(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "no_fail");
		if (__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text))
		{
			this.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB = __FIXME_clon_util.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(text, this.\u02B4\u02B6\u02C1\u02BD\u02BA\u02BE\u02C1\u02B9\u02B2\u02BD\u02B9, SearchOption.TopDirectoryOnly);
		}
		if (this.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB == null || this.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB.Length == 0)
		{
			SettingsController.\u02B7\u02B9\u02BF\u02BD\u02B9\u02B5\u02C0\u02BA\u02BC\u02BD\u02BE.Reset();
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000445 RID: 1093 RVA: 0x00008212 File Offset: 0x00006412
	public bool \u02B7\u02B7\u02B9\u02B6\u02B6\u02B8\u02C1\u02BA\u02BA\u02C0\u02B8
	{
		get
		{
			return this.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6 && this.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7 + 1 < \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count;
		}
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x0003172C File Offset: 0x0002F92C
	private string \u02B9\u02C0\u02BA\u02BA\u02BD\u02C0\u02C0\u02BC\u02C1\u02C0\u02B4()
	{
		return StringUtils.StripTags(SettingsController.\u02BC\u02B4\u02B2\u02B2\u02B6\u02B3\u02BB\u02B8\u02B2\u02C1\u02B3.CurrentValue.Replace("B: 00:00:00", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5).Replace("Press <color=\"green\">Green</color> to continue.", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Name.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA() + (SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.IsPresetValue ? "songs" : (" " + SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.GetPercentString + "%b"))).Replace("Language", Environment.NewLine)
			.Replace("FULL COMBO", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Year.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("fullserver", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Genre.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace("bass", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.\u02B2\u02BB\u02BF\u02B7\u02BE\u02C0\u02B5\u02BE\u02BF\u02B9\u02B4().\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace(" ", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Album.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace("...", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Charter.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace(" + ", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.songLength.ToString()), true);
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x00008232 File Offset: 0x00006432
	private IEnumerator \u02B3\u02B2\u02BD\u02BD\u02BD\u02BB\u02BC\u02B2\u02BB\u02BF\u02B5(bool \u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE = false)
	{
		GlobalVariables.\u02BB\u02B5\u02BE\u02BA\u02B2\u02B7\u02B3\u02BE\u02B3\u02B2\u02BB u02BB_u02B5_u02BE_u02BA_u02B2_u02B7_u02B3_u02BE_u02B3_u02B2_u02BB = new GlobalVariables.\u02BB\u02B5\u02BE\u02BA\u02B2\u02B7\u02B3\u02BE\u02B3\u02B2\u02BB();
		u02BB_u02B5_u02BE_u02BA_u02B2_u02B7_u02B3_u02BE_u02B3_u02B2_u02BB.forceAll = \u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE;
		GlobalVariables.\u02B3\u02B9\u02BD\u02BA\u02B7\u02B6\u02BC\u02C0\u02BC\u02B3\u02BC = true;
		GameObject gameObject = GameObject.Find("SavingText");
		if (gameObject == null)
		{
			this.\u02B2\u02B8\u02C1\u02B7\u02BB\u02BC\u02C1\u02B8\u02B5\u02B4\u02B5 = null;
		}
		else
		{
			this.\u02B2\u02B8\u02C1\u02B7\u02BB\u02BC\u02C1\u02B8\u02B5\u02B4\u02B5 = gameObject.GetComponent<Text>();
		}
		if (this.\u02B2\u02B8\u02C1\u02B7\u02BB\u02BC\u02C1\u02B8\u02B5\u02B4\u02B5 != null)
		{
			this.\u02B2\u02B8\u02C1\u02B7\u02BB\u02BC\u02C1\u02B8\u02B5\u02B4\u02B5.enabled = true;
		}
		Thread oThread = new Thread(new ThreadStart(u02BB_u02B5_u02BE_u02BA_u02B2_u02B7_u02B3_u02BE_u02B3_u02B2_u02BB.\u02B7\u02BD\u02B8\u02B6\u02C0\u02C0\u02BB\u02B2\u02B4\u02BE\u02B7))
		{
			IsBackground = true
		};
		oThread.Start();
		while (oThread.IsAlive)
		{
			yield return null;
		}
		GlobalVariables.\u02B3\u02B9\u02BD\u02BA\u02B7\u02B6\u02BC\u02C0\u02BC\u02B3\u02BC = false;
		if (this.\u02B2\u02B8\u02C1\u02B7\u02BB\u02BC\u02C1\u02B8\u02B5\u02B4\u02B5 != null)
		{
			this.\u02B2\u02B8\u02C1\u02B7\u02BB\u02BC\u02C1\u02B8\u02B5\u02B4\u02B5.enabled = false;
		}
		yield break;
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x0003185C File Offset: 0x0002FA5C
	public void \u02B7\u02B4\u02BB\u02C0\u02B5\u02B6\u02B6\u02B9\u02B9\u02B3\u02C0(string \u02B7\u02BD\u02BB\u02C0\u02BB\u02B4\u02B3\u02B6\u02B5\u02BA\u02C1)
	{
		if (this.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3 == null)
		{
			this.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3 = new Dictionary<string, Sprite>();
		}
		else
		{
			this.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3.Clear();
		}
		this.\u02C0\u02B5\u02B3\u02B7\u02B9\u02BC\u02B4\u02C0\u02B7\u02B2\u02BA(Path.Combine(Application.persistentDataPath, "iconCache"));
		foreach (Texture2D texture2D in Resources.LoadAll("Game Icons/", typeof(Texture2D)))
		{
			string text = texture2D.name.ToLowerInvariant();
			if (!this.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3.ContainsKey(text))
			{
				this.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3.Add(text, GlobalVariables.\u02BA\u02B7\u02B4\u02B5\u02B2\u02BC\u02B9\u02B5\u02B9\u02BE\u02B8(texture2D));
			}
		}
		string text2 = Path.Combine(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Game Icons");
		this.\u02C0\u02B5\u02B3\u02B7\u02B9\u02BC\u02B4\u02C0\u02B7\u02B2\u02BA(text2);
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x00031914 File Offset: 0x0002FB14
	private void \u02B5\u02B3\u02B3\u02BB\u02BA\u02BB\u02C0\u02BE\u02B2\u02B5\u02B9()
	{
		this.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6 = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B2\u02BE\u02BF\u02BD\u02BB\u02B7\u02C0\u02BD\u02B4\u02BE\u02BA.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.Keys.ToArray<string>();
		this.\u02B5\u02BB\u02B7\u02BB\u02B8\u02B5\u02B9\u02BA\u02B3\u02B8\u02BA = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "Songs");
		__FIXME_clon_util.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(this.\u02B5\u02BB\u02B7\u02BB\u02B8\u02B5\u02B9\u02BA\u02B3\u02B8\u02BA);
		this.\u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB();
		Settings.GameVersion = this.\u02B4\u02B3\u02B7\u02BC\u02B5\u02B3\u02B8\u02BB\u02BE\u02B5\u02B3;
		if (!File.Exists(SettingsController.\u02BE\u02BF\u02BE\u02BB\u02B3\u02B8\u02B9\u02BD\u02B9\u02B4\u02BC()))
		{
			Settings.Commit(false);
		}
		Screen.SetResolution(Screen.width, Screen.height, this.\u02B8\u02B6\u02BD\u02BC\u02BB\u02BD\u02BB\u02B8\u02C0\u02C0\u02C1());
		PlayerPrefs.SetInt("triedGraphicsSwitch", 0);
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00031620 File Offset: 0x0002F820
	public bool \u02BA\u02B3\u02BE\u02B6\u02BF\u02B3\u02BB\u02C1\u02B6\u02C1\u02BF()
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in this.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02C0\u02B5\u02B2\u02B2\u02BB\u02B8\u02B8\u02BD\u02B9\u02BD\u02C1())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x000319A4 File Offset: 0x0002FBA4
	public int \u02BA\u02C0\u02C1\u02B9\u02B4\u02BB\u02B9\u02B2\u02C0\u02B4\u02B5(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		if (\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 == "Random")
		{
			return -1;
		}
		for (int i = 0; i < this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Count; i++)
		{
			if (this.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[i].name == \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
			{
				return i;
			}
		}
		return 0;
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00008284 File Offset: 0x00006484
	private void OnApplicationQuit()
	{
		GlobalVariables.SaveStats();
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x0000828B File Offset: 0x0000648B
	public static void SaveStats()
	{
		PlayerPrefs.SetInt("Playtime", GlobalVariables.playTime);
		PlayerPrefs.SetString("Points", GlobalVariables.totalPoints.ToString());
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x000082B0 File Offset: 0x000064B0
	public static void LoadStats()
	{
		GlobalVariables.playTime = PlayerPrefs.GetInt("Playtime", 0);
		if (!long.TryParse(PlayerPrefs.GetString("Points", "0"), out GlobalVariables.totalPoints))
		{
			GlobalVariables.totalPoints = 0L;
		}
	}

	// Token: 0x04000321 RID: 801
	public object \u02B7\u02C1\u02BF\u02BD\u02B5\u02BE\u02C1\u02BE\u02B8\u02BF\u02B7;

	// Token: 0x04000322 RID: 802
	public SongEntry \u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1;

	// Token: 0x04000323 RID: 803
	public \u02B5\u02B4\u02BA\u02C1\u02B5\u02BD\u02BE\u02B9\u02B8\u02B9\u02C0 \u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF;

	// Token: 0x04000324 RID: 804
	public List<\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6> \u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF;

	// Token: 0x04000325 RID: 805
	public \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE;

	// Token: 0x04000326 RID: 806
	[NonSerialized]
	public string[] \u02B6\u02B8\u02B9\u02C1\u02BB\u02BE\u02B2\u02BF\u02BD\u02B4\u02BB;

	// Token: 0x04000327 RID: 807
	public GameMode \u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1;

	// Token: 0x04000328 RID: 808
	public int \u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD;

	// Token: 0x04000329 RID: 809
	public int \u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7;

	// Token: 0x0400032A RID: 810
	public int \u02B9\u02B7\u02BE\u02BF\u02B4\u02C1\u02BC\u02B2\u02BC\u02B8\u02B4;

	// Token: 0x0400032B RID: 811
	public string \u02B4\u02B3\u02B7\u02BC\u02B5\u02B3\u02B8\u02BB\u02BE\u02B5\u02B3;

	// Token: 0x0400032C RID: 812
	public string \u02B5\u02BF\u02BD\u02B8\u02B7\u02B3\u02BC\u02B6\u02B4\u02BB\u02B5;

	// Token: 0x0400032D RID: 813
	public bool \u02BE\u02B8\u02B9\u02BA\u02BB\u02C1\u02BB\u02B9\u02BE\u02C1\u02B9;

	// Token: 0x0400032E RID: 814
	public bool \u02C1\u02BA\u02BB\u02B8\u02B9\u02C0\u02BD\u02B5\u02B4\u02B6\u02B3;

	// Token: 0x0400032F RID: 815
	public bool \u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4;

	// Token: 0x04000330 RID: 816
	public bool \u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6;

	// Token: 0x04000331 RID: 817
	public bool \u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0;

	// Token: 0x04000332 RID: 818
	public bool \u02B6\u02BC\u02B3\u02BB\u02B2\u02B6\u02BA\u02BB\u02BA\u02BC\u02BD;

	// Token: 0x04000333 RID: 819
	public bool \u02BF\u02B6\u02B4\u02BB\u02BC\u02BF\u02B7\u02B9\u02BF\u02C0\u02B5;

	// Token: 0x04000334 RID: 820
	public bool \u02B6\u02B5\u02BE\u02C1\u02B9\u02B2\u02B4\u02B7\u02BA\u02C1\u02BA;

	// Token: 0x04000335 RID: 821
	public bool \u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0;

	// Token: 0x04000336 RID: 822
	public bool \u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2;

	// Token: 0x04000337 RID: 823
	public \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2 \u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA;

	// Token: 0x04000338 RID: 824
	public static bool \u02B3\u02B9\u02BD\u02BA\u02B7\u02B6\u02BC\u02C0\u02BC\u02B3\u02BC;

	// Token: 0x04000339 RID: 825
	public static GlobalVariables \u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;

	// Token: 0x0400033A RID: 826
	public static bool \u02B4\u02B8\u02BB\u02B6\u02B8\u02B6\u02BA\u02BA\u02B3\u02B3\u02B6;

	// Token: 0x0400033B RID: 827
	public string[] \u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF;

	// Token: 0x0400033C RID: 828
	public string[] \u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB;

	// Token: 0x0400033D RID: 829
	public string[] \u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6;

	// Token: 0x0400033E RID: 830
	public List<string> \u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9 = new List<string>();

	// Token: 0x0400033F RID: 831
	public string[] \u02C0\u02C0\u02B6\u02BD\u02BE\u02C1\u02B3\u02BF\u02BE\u02B3\u02C1;

	// Token: 0x04000340 RID: 832
	public string[] \u02B4\u02B6\u02BF\u02B8\u02B3\u02B5\u02BF\u02B9\u02C1\u02BC\u02B6;

	// Token: 0x04000341 RID: 833
	public string[] \u02B5\u02B7\u02B5\u02B4\u02BB\u02B4\u02B5\u02B4\u02C1\u02B6\u02BE;

	// Token: 0x04000342 RID: 834
	public bool \u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5;

	// Token: 0x04000343 RID: 835
	private Text \u02B2\u02B8\u02C1\u02B7\u02BB\u02BC\u02C1\u02B8\u02B5\u02B4\u02B5;

	// Token: 0x04000344 RID: 836
	public string \u02BB\u02BA\u02B5\u02BC\u02BD\u02C0\u02B2\u02B7\u02BC\u02B4\u02B9;

	// Token: 0x04000345 RID: 837
	public Dictionary<string, Sprite> \u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3;

	// Token: 0x04000346 RID: 838
	public List<HighwayData> \u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3;

	// Token: 0x04000347 RID: 839
	public string \u02C0\u02BD\u02B8\u02B9\u02BA\u02B6\u02B4\u02BB\u02B2\u02B6\u02B3;

	// Token: 0x04000348 RID: 840
	public string \u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8;

	// Token: 0x04000349 RID: 841
	public bool \u02BC\u02BC\u02B5\u02B3\u02BE\u02BD\u02BA\u02B7\u02BF\u02B2\u02BD;

	// Token: 0x0400034A RID: 842
	public float \u02B8\u02BE\u02BA\u02B9\u02C0\u02BD\u02B2\u02B9\u02C1\u02C0\u02B8 = 22f;

	// Token: 0x0400034B RID: 843
	public bool \u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB;

	// Token: 0x0400034C RID: 844
	public Sprite[] \u02B4\u02BC\u02B6\u02B2\u02BE\u02BB\u02B3\u02BA\u02BD\u02B6\u02B2;

	// Token: 0x0400034D RID: 845
	public Sprite[] \u02B2\u02B5\u02C0\u02B7\u02B3\u02B6\u02C0\u02BD\u02B2\u02B5\u02B6;

	// Token: 0x0400034E RID: 846
	public Sprite[] \u02B9\u02BD\u02B9\u02B8\u02B3\u02C0\u02B7\u02B4\u02BA\u02BE\u02B5;

	// Token: 0x0400034F RID: 847
	public Sprite[] \u02B8\u02BE\u02C1\u02B2\u02B6\u02C0\u02BE\u02B6\u02C0\u02C0\u02B5;

	// Token: 0x04000350 RID: 848
	public string \u02B4\u02B6\u02C1\u02BD\u02BA\u02BE\u02C1\u02B9\u02B2\u02BD\u02B9;

	// Token: 0x04000351 RID: 849
	public \u02B7\u02BE\u02BA\u02BE\u02BA\u02B2\u02BF\u02B2\u02C0\u02B2\u02C0 \u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA;

	// Token: 0x04000352 RID: 850
	public ColorManager \u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE;

	// Token: 0x04000353 RID: 851
	public bool \u02BE\u02B7\u02BB\u02B8\u02B6\u02B8\u02BA\u02B9\u02BF\u02B8\u02B3;

	// Token: 0x04000354 RID: 852
	public string \u02B5\u02BB\u02B7\u02BB\u02B8\u02B5\u02B9\u02BA\u02B3\u02B8\u02BA;

	// Token: 0x04000355 RID: 853
	private FullScreenMode \u02B3\u02C0\u02BD\u02BB\u02BC\u02BF\u02B7\u02B7\u02B9\u02B4\u02BA;

	// Token: 0x04000356 RID: 854
	public Action \u02B6\u02B3\u02B7\u02B5\u02BB\u02BD\u02B3\u02B9\u02BD\u02B2\u02B7;

	// Token: 0x04000357 RID: 855
	private List<string> \u02B7\u02BC\u02C0\u02B5\u02BF\u02B5\u02B6\u02B6\u02BB\u02B2\u02BA = new List<string>();

	// Token: 0x04000358 RID: 856
	private List<string> \u02B6\u02BD\u02BD\u02BC\u02C1\u02BE\u02B4\u02B9\u02BD\u02BF\u02BE = new List<string>();

	// Token: 0x04000359 RID: 857
	public static bool FCmode;

	// Token: 0x0400035A RID: 858
	public static bool fpslock = true;

	// Token: 0x0400035B RID: 859
	public static int misses;

	// Token: 0x0400035C RID: 860
	public static string IVVersion;

	// Token: 0x0400035D RID: 861
	public static bool disableFPSFix;

	// Token: 0x0400035E RID: 862
	public static bool SPRainbowEnabled;

	// Token: 0x0400035F RID: 863
	public static bool swr;

	// Token: 0x04000360 RID: 864
	public static int progress;

	// Token: 0x04000361 RID: 865
	public static bool deafened;

	// Token: 0x04000362 RID: 866
	public static bool hasReset;

	// Token: 0x04000363 RID: 867
	public static byte[] courte;

	// Token: 0x04000364 RID: 868
	public static int playTime;

	// Token: 0x04000365 RID: 869
	public static long totalPoints;

	// Token: 0x02000068 RID: 104
	[Serializable]
	private class InternalHighwayJsonData
	{
		// Token: 0x04000366 RID: 870
		public string[] highways;
	}

	// Token: 0x02000069 RID: 105
	[CompilerGenerated]
	private sealed class \u02BB\u02B5\u02BE\u02BA\u02B2\u02B7\u02B3\u02BE\u02B3\u02B2\u02BB
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x000082E4 File Offset: 0x000064E4
		internal void \u02B7\u02BD\u02B8\u02B6\u02C0\u02C0\u02BB\u02B2\u02B4\u02BE\u02B7()
		{
			Settings.Commit(this.forceAll);
		}

		// Token: 0x04000367 RID: 871
		public bool forceAll;
	}
}
