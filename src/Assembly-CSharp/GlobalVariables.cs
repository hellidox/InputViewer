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
using UnityEngine.UI;
using UnityEngine.Video;

public class GlobalVariables : MonoBehaviour
{
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
		if (Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text2))
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
		if (Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text))
		{
			string[] array2 = Helper.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(text, "Alien", SearchOption.TopDirectoryOnly);
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

	public void \u02B9\u02BB\u02BE\u02B6\u02BE\u02C0\u02B5\u02B9\u02B9\u02B8\u02B8(bool \u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE = false)
	{
		base.StartCoroutine(this.\u02B3\u02B2\u02BD\u02BD\u02BD\u02BB\u02BC\u02B2\u02BB\u02BF\u02B5(\u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE));
	}

	private void \u02C0\u02B5\u02B3\u02B7\u02B9\u02BC\u02B4\u02C0\u02B7\u02B2\u02BA(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		if (!Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC))
		{
			return;
		}
		foreach (string text in Helper.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC, ".png|.jpg|.jpeg", SearchOption.AllDirectories))
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
		if (Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text2))
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
		if (Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text))
		{
			string[] array2 = Helper.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(text, ".png|.jpg|.jpeg", SearchOption.AllDirectories);
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

	public void \u02BC\u02B2\u02BA\u02C1\u02C0\u02BF\u02B8\u02C0\u02B6\u02BA\u02B2(bool \u02BF\u02BC\u02BE\u02B2\u02B4\u02B3\u02BC\u02BF\u02BF\u02B8\u02B8 = false)
	{
		ThumbnailCache.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02BF\u02B2\u02B6\u02B6\u02B2\u02B5\u02BF\u02BF\u02BB\u02B5();
		string text = Helper.\u02BB\u02B6\u02B4\u02BC\u02B5\u02B9\u02BA\u02BD\u02B7\u02B4\u02B3();
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

	public static Texture2D \u02C0\u02B8\u02C1\u02B5\u02B4\u02B8\u02B6\u02B6\u02BB\u02BC\u02B5(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		if (!File.Exists(\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC))
		{
			return null;
		}
		return GlobalVariables.\u02C0\u02C0\u02B9\u02C1\u02B6\u02C1\u02C1\u02BA\u02BA\u02B9\u02B5(File.ReadAllBytes(\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC), false);
	}

	public void \u02B9\u02BC\u02BB\u02BC\u02C1\u02C0\u02B4\u02B9\u02BC\u02BC\u02C0(bool \u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE = false)
	{
		base.StartCoroutine(this.\u02B9\u02C1\u02BB\u02B8\u02BA\u02BC\u02BA\u02BC\u02B8\u02B5\u02B2(\u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE));
	}

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

	private static string \u02C1\u02BF\u02B3\u02B6\u02B9\u02BE\u02BB\u02BA\u02B3\u02B5\u02B7(string \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0)
	{
		return \u02C1\u02B2\u02B8\u02B9\u02C0\u02BC\u02B9\u02B9\u02B6\u02B2\u02B3.\u02B6\u02B3\u02BD\u02BB\u02BE\u02B7\u02BF\u02BC\u02B2\u02BE\u02B8(SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0)));
	}

	private void Update()
	{
		GlobalVariables.framereset += Time.unscaledDeltaTime;
		if ((double)GlobalVariables.framereset > 0.5)
		{
			GlobalHelper.renderFrameInterval = 1;
		}
		if ((Time.frameCount & 255) == 0)
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

	public void \u02BC\u02BE\u02B5\u02BC\u02B6\u02B5\u02BA\u02BD\u02B6\u02B5\u02B8(bool \u02BF\u02BC\u02BE\u02B2\u02B4\u02B3\u02BC\u02BF\u02BF\u02B8\u02B8 = false)
	{
		this.\u02B7\u02B4\u02BB\u02C0\u02B5\u02B6\u02B6\u02B9\u02B9\u02B3\u02C0(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8);
		if (!Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8))
		{
			SettingsController.background_image.Reset();
			SettingsController.background_video.Reset();
			return;
		}
		this.\u02BE\u02C0\u02BB\u02B6\u02B5\u02BA\u02B7\u02B3\u02B5\u02B3\u02C1();
		this.\u02B7\u02BE\u02C0\u02B2\u02C1\u02C0\u02B6\u02BB\u02B7\u02B4\u02B3();
		this.\u02BB\u02C1\u02BC\u02BE\u02B3\u02C1\u02B5\u02B3\u02BA\u02B8\u02BB();
		this.\u02BC\u02B2\u02BA\u02C1\u02C0\u02BF\u02B8\u02C0\u02B6\u02BA\u02B2(\u02BF\u02BC\u02BE\u02B2\u02B4\u02B3\u02BC\u02BF\u02BF\u02B8\u02B8);
		this.\u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE.\u02B4\u02C0\u02B4\u02B6\u02BC\u02BE\u02BE\u02B8\u02BA\u02BC\u02B7();
	}

	public static Sprite \u02BA\u02B7\u02B4\u02B5\u02B2\u02BC\u02B9\u02B5\u02B9\u02BE\u02B8(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		if (\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9 == null)
		{
			return null;
		}
		\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.wrapMode = TextureWrapMode.Clamp;
		return Sprite.Create(\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9, new Rect(0f, 0f, (float)\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.width, (float)\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.height), new Vector2(0f, 0f), 100f, 0U, SpriteMeshType.FullRect);
	}

	private void \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		this.\u02B4\u02B6\u02C1\u02BD\u02BA\u02BE\u02C1\u02B9\u02B2\u02BD\u02B9 = "{0:N0}";
		this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8 = Path.Combine(Helper.GetDocumentsClonFolder(), "whammy_sfx");
		this.\u02C0\u02BD\u02B8\u02B9\u02BA\u02B6\u02B4\u02BB\u02B2\u02B6\u02B3 = Path.Combine(Helper.GetDocumentsClonFolder(), "profiles.bin");
		Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(this.\u02C0\u02BD\u02B8\u02B9\u02BA\u02B6\u02B4\u02BB\u02B2\u02B6\u02B3);
		this.\u02B2\u02BE\u02BE\u02B6\u02B5\u02BB\u02C0\u02C0\u02B6\u02C1\u02B8(false);
		ReInput.configuration.joystickRefreshRate = SettingsController.\u02BC\u02BA\u02BE\u02B9\u02B5\u02BD\u02C1\u02B8\u02B7\u02C0\u02B8.CurrentValue;
		Cursor.visible = SettingsController.enable_cursor;
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
				this.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[SettingsController.language.CurrentValue]
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

	private void Start()
	{
		this.\u02B4\u02B6\u02C1\u02BD\u02BA\u02BE\u02C1\u02B9\u02B2\u02BD\u02B9 = ".mp4|.avi|.webm|.vp8|.ogv|.mpeg";
		this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8 = Path.Combine(Helper.GetDocumentsClonFolder(), "Custom");
		this.\u02C0\u02BD\u02B8\u02B9\u02BA\u02B6\u02B4\u02BB\u02B2\u02B6\u02B3 = Path.Combine(Helper.GetDocumentsClonFolder(), "Screenshots");
		Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(this.\u02C0\u02BD\u02B8\u02B9\u02BA\u02B6\u02B4\u02BB\u02B2\u02B6\u02B3);
		this.\u02B6\u02BC\u02B4\u02B9\u02B7\u02B4\u02BE\u02BF\u02B4\u02BE\u02B4(true);
		ReInput.configuration.joystickRefreshRate = SettingsController.\u02BC\u02BA\u02BE\u02B9\u02B5\u02BD\u02C1\u02B8\u02B7\u02C0\u02B8.CurrentValue;
		Cursor.visible = SettingsController.enable_cursor;
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
				this.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[SettingsController.language.CurrentValue]
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

	private IEnumerator \u02B9\u02C1\u02BB\u02B8\u02BA\u02BC\u02BA\u02BC\u02B8\u02B5\u02B2(bool \u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE = false)
	{
		GlobalVariables.\u02BD\u02BA\u02BF\u02BE\u02BD\u02B2\u02B9\u02B7\u02B6\u02B7\u02C0 u02BD_u02BA_u02BF_u02BE_u02BD_u02B2_u02B9_u02B7_u02B6_u02B7_u02C = new GlobalVariables.\u02BD\u02BA\u02BF\u02BE\u02BD\u02B2\u02B9\u02B7\u02B6\u02B7\u02C0(1);
		u02BD_u02BA_u02BF_u02BE_u02BD_u02B2_u02B9_u02B7_u02B6_u02B7_u02C.<>4__this = this;
		u02BD_u02BA_u02BF_u02BE_u02BD_u02B2_u02B9_u02B7_u02B6_u02B7_u02C.forceAll = \u02B4\u02B6\u02B9\u02B8\u02B8\u02B7\u02B8\u02BA\u02C1\u02B6\u02BE;
		return u02BD_u02BA_u02BF_u02BE_u02BD_u02B2_u02B9_u02B7_u02B6_u02B7_u02C;
	}

	public void \u02B6\u02BC\u02B4\u02B9\u02B7\u02B4\u02BE\u02BF\u02B4\u02BE\u02B4(bool \u02C1\u02BB\u02B2\u02B7\u02BD\u02B9\u02BF\u02C0\u02B6\u02C0\u02B3)
	{
		if ((Time.frameCount & 255) == 0)
		{
			return;
		}
		Application.targetFrameRate = -1;
	}

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

	private string \u02C0\u02BA\u02BA\u02C1\u02B6\u02B5\u02B4\u02BC\u02BF\u02BC\u02BA()
	{
		return StringUtils.StripTags(SettingsController.\u02BC\u02B4\u02B2\u02B2\u02B6\u02B3\u02BB\u02B8\u02B2\u02C1\u02B3.CurrentValue.Replace("%a", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5).Replace("%s", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5 + (SettingsController.song_speed.IsPresetValue ? "" : (" (" + SettingsController.song_speed.GetPercentString + ")"))).Replace("%n", Environment.NewLine)
			.Replace("%y", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Year.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("%g", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Genre.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("%p", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Playlist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("%b", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Album.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("%c", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Charter.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("%l", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.songLength.ToString()), false);
	}

	public void \u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB()
	{
		this.\u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9.Clear();
		bool flag = Helper.CaseSensitive();
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

	private string \u02C1\u02C1\u02C1\u02B9\u02BA\u02B4\u02B9\u02B4\u02B6\u02B9\u02BA()
	{
		return StringUtils.StripTags(SettingsController.\u02BC\u02B4\u02B2\u02B2\u02B6\u02B3\u02BB\u02B8\u02B2\u02C1\u02B3.CurrentValue.Replace("Export Current Song", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5).Replace("charter", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5 + (SettingsController.song_speed.IsPresetValue ? "DoubleGuitar" : ("song" + SettingsController.song_speed.GetPercentString + "Random"))).Replace("Flames", Environment.NewLine)
			.Replace("{0}: {1}", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Year.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("offset", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Genre.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace("hasExpert", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Playlist.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace("</color>", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.\u02B6\u02B7\u02B2\u02C1\u02B9\u02B3\u02B8\u02BC\u02B4\u02BD\u02BB().\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace("Allow Clients To Remove Songs", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Charter.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("6 Fret Bass Guitar", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.songLength.ToString()), true);
	}

	public bool \u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA()
	{
		if (this.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[SettingsController.language.CurrentValue] == LanguageManager.instance.\u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5)
		{
			return false;
		}
		LanguageManager.instance.\u02B8\u02C0\u02B9\u02B9\u02B4\u02B7\u02BD\u02BE\u02B7\u02BC\u02B2(this.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6[SettingsController.language.CurrentValue]);
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

	public void \u02BB\u02C1\u02BC\u02BE\u02B3\u02C1\u02B5\u02B3\u02BA\u02B8\u02BB()
	{
		string text = Path.Combine(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Image Backgrounds");
		if (Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text))
		{
			this.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF = Helper.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(text, ".png|.jpg|.jpeg", SearchOption.AllDirectories);
		}
		this.\u02B7\u02BC\u02C0\u02B5\u02BF\u02B5\u02B6\u02B6\u02BB\u02B2\u02BA.AddRange(this.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF);
		if (this.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF == null || this.\u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF.Length == 0)
		{
			SettingsController.background_image.Reset();
		}
	}

	public void \u02BD\u02B5\u02B4\u02B2\u02BA\u02B5\u02BD\u02BF\u02BE\u02BC\u02BB(bool \u02B3\u02BC\u02B6\u02B5\u02B4\u02B9\u02B4\u02BD\u02B8\u02B9\u02B6)
	{
		if (!SettingsController.\u02BA\u02BF\u02BF\u02B7\u02B4\u02B6\u02BD\u02BC\u02BE\u02B5\u02BA)
		{
			return;
		}
		try
		{
			string text = this.\u02C0\u02BA\u02BA\u02C1\u02B6\u02B5\u02B4\u02BC\u02BF\u02BC\u02BA();
			using (Stream stream = File.Create(Path.Combine(Helper.GetDocumentsClonFolder(), "currentsong.txt")))
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

	public void \u02BE\u02C0\u02BB\u02B6\u02B5\u02BA\u02B7\u02B3\u02B5\u02B3\u02C1()
	{
		string text = Path.Combine(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "Video Backgrounds");
		if (Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text))
		{
			this.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB = Helper.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(text, this.\u02B4\u02B6\u02C1\u02BD\u02BA\u02BE\u02C1\u02B9\u02B2\u02BD\u02B9, SearchOption.AllDirectories);
		}
		if (this.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB == null || this.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB.Length == 0)
		{
			SettingsController.background_video.Reset();
		}
	}

	public void \u02B8\u02B8\u02B9\u02B9\u02B2\u02B2\u02B9\u02B8\u02B5\u02C1\u02B6()
	{
		string text = Path.Combine(this.\u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8, "no_fail");
		if (Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(text))
		{
			this.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB = Helper.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(text, this.\u02B4\u02B6\u02C1\u02BD\u02BA\u02BE\u02C1\u02B9\u02B2\u02BD\u02B9, SearchOption.TopDirectoryOnly);
		}
		if (this.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB == null || this.\u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB.Length == 0)
		{
			SettingsController.background_video.Reset();
		}
	}

	public bool \u02B7\u02B7\u02B9\u02B6\u02B6\u02B8\u02C1\u02BA\u02BA\u02C0\u02B8
	{
		get
		{
			return this.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6 && this.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7 + 1 < \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count;
		}
	}

	private string \u02B9\u02C0\u02BA\u02BA\u02BD\u02C0\u02C0\u02BC\u02C1\u02C0\u02B4()
	{
		return StringUtils.StripTags(SettingsController.\u02BC\u02B4\u02B2\u02B2\u02B6\u02B3\u02BB\u02B8\u02B2\u02C1\u02B3.CurrentValue.Replace("B: 00:00:00", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5).Replace("Press <color=\"green\">Green</color> to continue.", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Name.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA() + (SettingsController.song_speed.IsPresetValue ? "songs" : (" " + SettingsController.song_speed.GetPercentString + "%b"))).Replace("Language", Environment.NewLine)
			.Replace("FULL COMBO", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Year.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5)
			.Replace("fullserver", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Genre.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace("bass", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.\u02B2\u02BB\u02BF\u02B7\u02BE\u02C0\u02B5\u02BE\u02BF\u02B9\u02B4().\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace(" ", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Album.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace("...", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.Charter.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA())
			.Replace(" + ", this.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.songLength.ToString()), true);
	}

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

	private void \u02B5\u02B3\u02B3\u02BB\u02BA\u02BB\u02C0\u02BE\u02B2\u02B5\u02B9()
	{
		this.\u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6 = LanguageManager.instance.LocalizationResourceManager.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.Keys.ToArray<string>();
		this.\u02B5\u02BB\u02B7\u02BB\u02B8\u02B5\u02B9\u02BA\u02B3\u02B8\u02BA = Path.Combine(Helper.GetDocumentsClonFolder(), "Songs");
		Helper.\u02BB\u02B9\u02BE\u02C0\u02B3\u02B4\u02B4\u02B5\u02BE\u02B9\u02B7(this.\u02B5\u02BB\u02B7\u02BB\u02B8\u02B5\u02B9\u02BA\u02B3\u02B8\u02BA);
		this.\u02B4\u02C0\u02BD\u02B5\u02B3\u02B3\u02C0\u02B7\u02B6\u02B2\u02BB();
		Settings.GameVersion = this.\u02B4\u02B3\u02B7\u02BC\u02B5\u02B3\u02B8\u02BB\u02BE\u02B5\u02B3;
		if (!File.Exists(SettingsController.\u02BE\u02BF\u02BE\u02BB\u02B3\u02B8\u02B9\u02BD\u02B9\u02B4\u02BC()))
		{
			Settings.Commit(false);
		}
		Screen.SetResolution(Screen.width, Screen.height, this.\u02B8\u02B6\u02BD\u02BC\u02BB\u02BD\u02BB\u02B8\u02C0\u02C0\u02C1());
		PlayerPrefs.SetInt("triedGraphicsSwitch", 0);
	}

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

	private void OnApplicationQuit()
	{
		GlobalVariables.SaveStats();
	}

	public static void SaveStats()
	{
		PlayerPrefs.SetInt("Playtime", GlobalVariables.playTime);
		PlayerPrefs.SetString("Points", GlobalVariables.totalPoints.ToString());
	}

	public static void LoadStats()
	{
		GlobalVariables.playTime = PlayerPrefs.GetInt("Playtime", 0);
		if (!long.TryParse(PlayerPrefs.GetString("Points", "0"), out GlobalVariables.totalPoints))
		{
			GlobalVariables.totalPoints = 0L;
		}
	}

	public object \u02B7\u02C1\u02BF\u02BD\u02B5\u02BE\u02C1\u02BE\u02B8\u02BF\u02B7;

	public SongEntry \u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1;

	public \u02B5\u02B4\u02BA\u02C1\u02B5\u02BD\u02BE\u02B9\u02B8\u02B9\u02C0 \u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF;

	public List<\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6> \u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF;

	public \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02B4\u02B8\u02BE\u02C1\u02B8\u02B7\u02B4\u02BA\u02BF\u02B7\u02BE;

	[NonSerialized]
	public string[] \u02B6\u02B8\u02B9\u02C1\u02BB\u02BE\u02B2\u02BF\u02BD\u02B4\u02BB;

	public GameMode \u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1;

	public int \u02BB\u02B4\u02BD\u02B2\u02BC\u02B7\u02C0\u02C1\u02B8\u02B4\u02BD;

	public int \u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7;

	public int \u02B9\u02B7\u02BE\u02BF\u02B4\u02C1\u02BC\u02B2\u02BC\u02B8\u02B4;

	public string \u02B4\u02B3\u02B7\u02BC\u02B5\u02B3\u02B8\u02BB\u02BE\u02B5\u02B3;

	public string \u02B5\u02BF\u02BD\u02B8\u02B7\u02B3\u02BC\u02B6\u02B4\u02BB\u02B5;

	public bool \u02BE\u02B8\u02B9\u02BA\u02BB\u02C1\u02BB\u02B9\u02BE\u02C1\u02B9;

	public bool \u02C1\u02BA\u02BB\u02B8\u02B9\u02C0\u02BD\u02B5\u02B4\u02B6\u02B3;

	public bool \u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4;

	public bool \u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6;

	public bool \u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0;

	public bool \u02B6\u02BC\u02B3\u02BB\u02B2\u02B6\u02BA\u02BB\u02BA\u02BC\u02BD;

	public bool \u02BF\u02B6\u02B4\u02BB\u02BC\u02BF\u02B7\u02B9\u02BF\u02C0\u02B5;

	public bool \u02B6\u02B5\u02BE\u02C1\u02B9\u02B2\u02B4\u02B7\u02BA\u02C1\u02BA;

	public bool \u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0;

	public bool \u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2;

	public \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2 \u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA;

	public static bool \u02B3\u02B9\u02BD\u02BA\u02B7\u02B6\u02BC\u02C0\u02BC\u02B3\u02BC;

	public static GlobalVariables \u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;

	public static bool \u02B4\u02B8\u02BB\u02B6\u02B8\u02B6\u02BA\u02BA\u02B3\u02B3\u02B6;

	public string[] \u02B9\u02BB\u02B2\u02B8\u02B3\u02B7\u02B3\u02B2\u02BD\u02B9\u02BF;

	public string[] \u02B7\u02B9\u02BD\u02BC\u02B7\u02B6\u02B2\u02B2\u02BC\u02BB\u02BB;

	public string[] \u02BC\u02C0\u02B5\u02BD\u02B2\u02BC\u02BA\u02BC\u02B9\u02B6\u02B6;

	public List<string> \u02B3\u02B4\u02B5\u02B9\u02B8\u02BC\u02BC\u02B8\u02C0\u02B5\u02B9 = new List<string>();

	public string[] \u02C0\u02C0\u02B6\u02BD\u02BE\u02C1\u02B3\u02BF\u02BE\u02B3\u02C1;

	public string[] \u02B4\u02B6\u02BF\u02B8\u02B3\u02B5\u02BF\u02B9\u02C1\u02BC\u02B6;

	public string[] \u02B5\u02B7\u02B5\u02B4\u02BB\u02B4\u02B5\u02B4\u02C1\u02B6\u02BE;

	public bool \u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5;

	private Text \u02B2\u02B8\u02C1\u02B7\u02BB\u02BC\u02C1\u02B8\u02B5\u02B4\u02B5;

	public string \u02BB\u02BA\u02B5\u02BC\u02BD\u02C0\u02B2\u02B7\u02BC\u02B4\u02B9;

	public Dictionary<string, Sprite> \u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3;

	public List<HighwayData> \u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3;

	public string \u02C0\u02BD\u02B8\u02B9\u02BA\u02B6\u02B4\u02BB\u02B2\u02B6\u02B3;

	public string \u02B5\u02B3\u02B5\u02B7\u02BD\u02B6\u02B5\u02BB\u02BF\u02B3\u02B8;

	public bool \u02BC\u02BC\u02B5\u02B3\u02BE\u02BD\u02BA\u02B7\u02BF\u02B2\u02BD;

	public float \u02B8\u02BE\u02BA\u02B9\u02C0\u02BD\u02B2\u02B9\u02C1\u02C0\u02B8 = 22f;

	public bool \u02BE\u02BE\u02C1\u02B4\u02B4\u02B6\u02BA\u02BB\u02C1\u02BE\u02BB;

	public Sprite[] \u02B4\u02BC\u02B6\u02B2\u02BE\u02BB\u02B3\u02BA\u02BD\u02B6\u02B2;

	public Sprite[] \u02B2\u02B5\u02C0\u02B7\u02B3\u02B6\u02C0\u02BD\u02B2\u02B5\u02B6;

	public Sprite[] \u02B9\u02BD\u02B9\u02B8\u02B3\u02C0\u02B7\u02B4\u02BA\u02BE\u02B5;

	public Sprite[] \u02B8\u02BE\u02C1\u02B2\u02B6\u02C0\u02BE\u02B6\u02C0\u02C0\u02B5;

	public string \u02B4\u02B6\u02C1\u02BD\u02BA\u02BE\u02C1\u02B9\u02B2\u02BD\u02B9;

	public \u02B7\u02BE\u02BA\u02BE\u02BA\u02B2\u02BF\u02B2\u02C0\u02B2\u02C0 \u02C1\u02B7\u02BD\u02B7\u02B7\u02BD\u02B6\u02B4\u02BA\u02B2\u02BA;

	public ColorManager \u02BD\u02BA\u02B2\u02BB\u02BC\u02C0\u02BA\u02B8\u02BE\u02BB\u02BE;

	public bool \u02BE\u02B7\u02BB\u02B8\u02B6\u02B8\u02BA\u02B9\u02BF\u02B8\u02B3;

	public string \u02B5\u02BB\u02B7\u02BB\u02B8\u02B5\u02B9\u02BA\u02B3\u02B8\u02BA;

	private FullScreenMode \u02B3\u02C0\u02BD\u02BB\u02BC\u02BF\u02B7\u02B7\u02B9\u02B4\u02BA;

	public Action \u02B6\u02B3\u02B7\u02B5\u02BB\u02BD\u02B3\u02B9\u02BD\u02B2\u02B7;

	private List<string> \u02B7\u02BC\u02C0\u02B5\u02BF\u02B5\u02B6\u02B6\u02BB\u02B2\u02BA = new List<string>();

	private List<string> \u02B6\u02BD\u02BD\u02BC\u02C1\u02BE\u02B4\u02B9\u02BD\u02BF\u02BE = new List<string>();

	public static bool FCmode;

	public static bool fpslock = true;

	public static int misses;

	public static string IVVersion;

	public static bool disableFPSFix;

	public static bool SPRainbowEnabled;

	public static bool swr;

	public static int progress;

	public static bool deafened;

	public static bool hasReset;

	public static byte[] courte;

	public static int playTime;

	public static long totalPoints;

	public static float framereset;

	[Serializable]
	private class InternalHighwayJsonData
	{
		public string[] highways;
	}

	[CompilerGenerated]
	private sealed class \u02BB\u02B5\u02BE\u02BA\u02B2\u02B7\u02B3\u02BE\u02B3\u02B2\u02BB
	{
		internal void \u02B7\u02BD\u02B8\u02B6\u02C0\u02C0\u02BB\u02B2\u02B4\u02BE\u02B7()
		{
			Settings.Commit(this.forceAll);
		}

		public bool forceAll;
	}
}
