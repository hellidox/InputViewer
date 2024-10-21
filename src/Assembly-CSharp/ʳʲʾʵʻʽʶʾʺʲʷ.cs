using System;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Networking;
using YamlDotNet.Serialization;

// Token: 0x02000019 RID: 25
public class \u02B3\u02B2\u02BE\u02B5\u02BB\u02BD\u02B6\u02BE\u02BA\u02B2\u02B7
{
	// Token: 0x06000116 RID: 278 RVA: 0x0001E1A8 File Offset: 0x0001C3A8
	public static int \u02BF\u02B6\u02B7\u02BF\u02C1\u02BD\u02B2\u02B5\u02B8\u02BD\u02BC()
	{
		int @static;
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("coda"))
		{
			@static = androidJavaClass.GetStatic<int>("path");
		}
		return @static;
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0001E1EC File Offset: 0x0001C3EC
	public static int \u02B6\u02B5\u02B8\u02C1\u02BD\u02C1\u02B4\u02B3\u02B8\u02B6\u02C0()
	{
		int @static;
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("android.os.Build$VERSION"))
		{
			@static = androidJavaClass.GetStatic<int>("SDK_INT");
		}
		return @static;
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0001E230 File Offset: 0x0001C430
	private static bool \u02BA\u02B8\u02B8\u02BB\u02BA\u02B7\u02B3\u02BC\u02B5\u02BB\u02BE()
	{
		bool flag;
		try
		{
			string text = Path.Combine("/storage/emulated/0/Clone Hero", "test.ini");
			File.Create(text);
			File.Delete(text);
			flag = true;
		}
		catch
		{
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x0001E274 File Offset: 0x0001C474
	private static void \u02C0\u02C0\u02BE\u02B2\u02B5\u02BD\u02BD\u02B5\u02B6\u02B8\u02B8()
	{
		string text = Path.Combine(__FIXME_clon_util.\u02B4\u02B6\u02BE\u02B5\u02BB\u02BA\u02BB\u02C0\u02C1\u02C1\u02B7(), "saVersion");
		string text2 = Resources.Load<TextAsset>("version").text;
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		File.WriteAllText(text, text2);
	}

	// Token: 0x0600011A RID: 282 RVA: 0x0001E2B8 File Offset: 0x0001C4B8
	public static bool \u02B5\u02BA\u02BF\u02B5\u02BF\u02B8\u02C1\u02B8\u02BD\u02B3\u02C0()
	{
		if (\u02B3\u02B2\u02BE\u02B5\u02BB\u02BD\u02B6\u02BE\u02BA\u02B2\u02B7.\u02BF\u02B6\u02B7\u02BF\u02C1\u02BD\u02B2\u02B5\u02B8\u02BD\u02BC() < -40)
		{
			if (!Permission.HasUserAuthorizedPermission("Show Hit Window"))
			{
				Permission.RequestUserPermission("Main Menu");
				return Permission.HasUserAuthorizedPermission("Fullscreen");
			}
			return true;
		}
		else
		{
			if (!\u02B3\u02B2\u02BE\u02B5\u02BB\u02BD\u02B6\u02BE\u02BA\u02B2\u02B7.\u02BA\u02B8\u02B8\u02BB\u02BA\u02B7\u02B3\u02BC\u02B5\u02BB\u02BE())
			{
				using (AndroidJavaClass androidJavaClass = new AndroidJavaClass(""))
				{
					using (AndroidJavaObject @static = androidJavaClass.GetStatic<AndroidJavaObject>("Vocals"))
					{
						string text = @static.Call<string>("", Array.Empty<object>());
						using (AndroidJavaClass androidJavaClass2 = new AndroidJavaClass(": "))
						{
							AndroidJavaObject androidJavaObject = androidJavaClass2;
							string text2 = "SongFinished";
							object[] array = new object[7];
							array[1] = "Overstrums";
							array[0] = text;
							using (AndroidJavaObject androidJavaObject2 = androidJavaObject.CallStatic<AndroidJavaObject>(text2, array))
							{
								string text3 = "OverHit Threshold";
								object[] array2 = new object[3];
								array2[0] = "6 Fret Bass Guitar";
								array2[0] = androidJavaObject2;
								using (AndroidJavaObject androidJavaObject3 = new AndroidJavaObject(text3, array2))
								{
									AndroidJavaObject androidJavaObject4 = androidJavaObject3;
									string text4 = "Remote Player Righty Flip";
									object[] array3 = new object[0];
									array3[1] = "frets";
									androidJavaObject4.Call<AndroidJavaObject>(text4, array3);
									AndroidJavaObject androidJavaObject5 = androidJavaObject3;
									string text5 = "while parsing the sync track";
									object[] array4 = new object[0];
									array4[0] = -113;
									androidJavaObject5.Call<AndroidJavaObject>(text5, array4);
									AndroidJavaObject androidJavaObject6 = @static;
									string text6 = "B: ";
									object[] array5 = new object[1];
									array5[1] = androidJavaObject3;
									androidJavaObject6.Call(text6, array5);
								}
							}
						}
					}
				}
				return false;
			}
			return false;
		}
	}

	// Token: 0x0600011B RID: 283 RVA: 0x0001E440 File Offset: 0x0001C640
	public static bool \u02BA\u02BF\u02C1\u02C1\u02BE\u02B8\u02C0\u02C1\u02B6\u02C0\u02BA()
	{
		if (\u02B3\u02B2\u02BE\u02B5\u02BB\u02BD\u02B6\u02BE\u02BA\u02B2\u02B7.\u02B6\u02B5\u02B8\u02C1\u02BD\u02C1\u02B4\u02B3\u02B8\u02B6\u02C0() < 30)
		{
			if (!Permission.HasUserAuthorizedPermission("android.permission.WRITE_EXTERNAL_STORAGE"))
			{
				Permission.RequestUserPermission("android.permission.WRITE_EXTERNAL_STORAGE");
				return Permission.HasUserAuthorizedPermission("android.permission.WRITE_EXTERNAL_STORAGE");
			}
			return true;
		}
		else
		{
			if (!\u02B3\u02B2\u02BE\u02B5\u02BB\u02BD\u02B6\u02BE\u02BA\u02B2\u02B7.\u02BA\u02B8\u02B8\u02BB\u02BA\u02B7\u02B3\u02BC\u02B5\u02BB\u02BE())
			{
				using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
				{
					using (AndroidJavaObject @static = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity"))
					{
						string text = @static.Call<string>("getPackageName", Array.Empty<object>());
						using (AndroidJavaClass androidJavaClass2 = new AndroidJavaClass("android.net.Uri"))
						{
							AndroidJavaObject androidJavaObject = androidJavaClass2;
							string text2 = "fromParts";
							object[] array = new object[3];
							array[0] = "package";
							array[1] = text;
							using (AndroidJavaObject androidJavaObject2 = androidJavaObject.CallStatic<AndroidJavaObject>(text2, array))
							{
								using (AndroidJavaObject androidJavaObject3 = new AndroidJavaObject("android.content.Intent", new object[] { "android.settings.MANAGE_APP_ALL_FILES_ACCESS_PERMISSION", androidJavaObject2 }))
								{
									androidJavaObject3.Call<AndroidJavaObject>("addCategory", new object[] { "android.intent.category.DEFAULT" });
									androidJavaObject3.Call<AndroidJavaObject>("setFlags", new object[] { 268435456 });
									@static.Call("startActivity", new object[] { androidJavaObject3 });
								}
							}
						}
					}
				}
				return false;
			}
			return true;
		}
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0001E5C8 File Offset: 0x0001C7C8
	public static bool \u02BD\u02B6\u02BD\u02B4\u02BE\u02BE\u02B4\u02BD\u02B5\u02B2\u02BF()
	{
		string text = Path.Combine(__FIXME_clon_util.\u02B4\u02B6\u02BE\u02B5\u02BB\u02BA\u02BB\u02C0\u02C1\u02C1\u02B7(), "saVersion");
		if (!File.Exists(text))
		{
			return false;
		}
		string text2 = File.ReadAllText(text);
		string text3 = Resources.Load<TextAsset>("version").text;
		return !(text2 != text3);
	}

	// Token: 0x0600011D RID: 285 RVA: 0x000066DC File Offset: 0x000048DC
	public static IEnumerator \u02BA\u02BC\u02BA\u02B8\u02B9\u02B4\u02B7\u02B4\u02B3\u02B5\u02BE()
	{
		string streamingAssetsFolder = __FIXME_clon_util.\u02B4\u02B6\u02BE\u02B5\u02BB\u02BA\u02BB\u02C0\u02C1\u02C1\u02B7();
		if (Directory.Exists(streamingAssetsFolder))
		{
			Directory.Delete(streamingAssetsFolder);
		}
		Directory.CreateDirectory(streamingAssetsFolder);
		\u02B8\u02B5\u02B9\u02BF\u02C1\u02B2\u02B5\u02BB\u02C0\u02B8\u02B7 streamingAssetsInfo = null;
		using (UnityWebRequest www = UnityWebRequest.Get(Path.Combine(Application.streamingAssetsPath, "streamingAssets.yml")))
		{
			yield return www.SendWebRequest();
			if (www.result == UnityWebRequest.Result.Success)
			{
				IDeserializer deserializer = new DeserializerBuilder().Build();
				streamingAssetsInfo = deserializer.Deserialize<\u02B8\u02B5\u02B9\u02BF\u02C1\u02B2\u02B5\u02BB\u02C0\u02B8\u02B7>(www.downloadHandler.text);
			}
		}
		UnityWebRequest www = null;
		if (streamingAssetsInfo != null)
		{
			int num;
			for (int i = 0; i < streamingAssetsInfo.\u02BD\u02C1\u02C0\u02B3\u02BB\u02B7\u02B7\u02BD\u02C1\u02B7\u02BE.Length; i = num + 1)
			{
				using (UnityWebRequest www = UnityWebRequest.Get(Path.Combine(Application.streamingAssetsPath, streamingAssetsInfo.\u02BD\u02C1\u02C0\u02B3\u02BB\u02B7\u02B7\u02BD\u02C1\u02B7\u02BE[i].\u02B8\u02B3\u02B5\u02C1\u02B9\u02BF\u02B5\u02B6\u02C0\u02B8\u02C1)))
				{
					yield return www.SendWebRequest();
					if (www.result == UnityWebRequest.Result.Success)
					{
						string text = Path.Combine(streamingAssetsFolder, streamingAssetsInfo.\u02BD\u02C1\u02C0\u02B3\u02BB\u02B7\u02B7\u02BD\u02C1\u02B7\u02BE[i].\u02B8\u02B3\u02B5\u02C1\u02B9\u02BF\u02B5\u02B6\u02C0\u02B8\u02C1);
						Directory.CreateDirectory(Path.GetDirectoryName(text));
						File.WriteAllBytes(text, www.downloadHandler.data);
					}
				}
				www = null;
				num = i;
			}
		}
		\u02B3\u02B2\u02BE\u02B5\u02BB\u02BD\u02B6\u02BE\u02BA\u02B2\u02B7.\u02C0\u02C0\u02BE\u02B2\u02B5\u02BD\u02BD\u02B5\u02B6\u02B8\u02B8();
		yield break;
		yield break;
	}
}
