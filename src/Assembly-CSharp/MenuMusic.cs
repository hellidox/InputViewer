using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MenuMusic : MonoBehaviour
{
	private IEnumerator \u02C1\u02B6\u02B5\u02C0\u02B7\u02B2\u02B2\u02B9\u02B2\u02BE\u02B9()
	{
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4 == null || \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count == 0)
		{
			yield break;
		}
		for (;;)
		{
			if ((SettingsController.\u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3 && !Application.isFocused) || !base.gameObject.activeInHierarchy || this.songScan.\u02B8\u02B3\u02BA\u02B6\u02BA\u02BF\u02B3\u02B5\u02B7\u02B8\u02B6)
			{
				yield return null;
			}
			else
			{
				double num = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0();
				if (!BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8 || num >= BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC || num < 0.0)
				{
					SongEntry songEntry = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C0\u02B3\u02B2\u02BA\u02BE\u02BF\u02BA\u02B5\u02BA\u02BB\u02BF(false);
					BassAudioManager.Instance.\u02BE\u02B3\u02B8\u02B4\u02BB\u02B3\u02BE\u02B4\u02BA\u02C0\u02BA(songEntry, false, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Crowd, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.None);
					BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume);
					if (BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC > 0.0)
					{
						BassAudioManager.Instance.\u02BD\u02B7\u02B2\u02BE\u02B7\u02BD\u02C1\u02BE\u02C1\u02B9\u02B7(true);
						BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume);
						BassAudioManager.Instance.\u02B2\u02BC\u02BD\u02BF\u02B2\u02BE\u02BA\u02BA\u02B3\u02C1\u02B8(100);
						BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE = songEntry;
						this.\u02B5\u02B2\u02B5\u02BD\u02C1\u02BB\u02B5\u02BA\u02BA\u02BB\u02B9();
					}
				}
				yield return null;
			}
		}
		yield break;
	}

	public void \u02B2\u02B3\u02B5\u02BC\u02BB\u02B3\u02BF\u02BA\u02B6\u02B5\u02B9()
	{
		if (BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE == null || BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE.folderPath == null || BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE.folderPath == string.Empty || !this.\u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8)
		{
			this.\u02BE\u02BD\u02B6\u02B5\u02B3\u02BF\u02B4\u02BC\u02B6\u02B6\u02B3.SetActive(false);
			return;
		}
		SongEntry u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE = BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE;
		this.\u02BE\u02BD\u02B6\u02B5\u02B3\u02BF\u02B4\u02BC\u02B6\u02B6\u02B3.SetActive(false);
		this.nameText.\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5, false);
		this.artistText.\u02BA\u02BC\u02BD\u02B4\u02B3\u02B9\u02B2\u02B4\u02C0\u02B5\u02B5(u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.\u02B9\u02BA\u02BE\u02BC\u02BB\u02B2\u02B2\u02B8\u02B8\u02BA\u02BB().\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA(), false);
		this.yearText.\u02BA\u02BC\u02BD\u02B4\u02B3\u02B9\u02B2\u02B4\u02C0\u02B5\u02B5(u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.Year.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA(), true);
		if (u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.isEnc && u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.songEnc.\u02B6\u02BD\u02B6\u02BE\u02BB\u02BE\u02B3\u02BD\u02B2\u02BB\u02B4((\u02BC\u02C0\u02BC\u02BC\u02BD\u02B3\u02C0\u02B6\u02BA\u02B5\u02C0)8))
		{
			this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3.texture = u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.songEnc.\u02B3\u02B4\u02BB\u02BD\u02BD\u02BE\u02B6\u02B2\u02B6\u02B7\u02B3((\u02BC\u02C0\u02BC\u02BC\u02BD\u02B3\u02C0\u02B6\u02BA\u02B5\u02C0)4);
		}
		else
		{
			RawImage u02BC_u02C0_u02B7_u02B7_u02B5_u02B9_u02B9_u02C1_u02BB_u02B5_u02B = this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3;
			string folderPath = u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.folderPath;
			string[] array = new string[6];
			array[1] = "Practice";
			array[0] = "Modchart";
			array[8] = "Charter";
			u02BC_u02C0_u02B7_u02B7_u02B5_u02B9_u02B9_u02C1_u02BB_u02B5_u02B.texture = GlobalVariables.\u02B4\u02B7\u02BF\u02BC\u02B4\u02B2\u02BF\u02B8\u02BF\u02BF\u02BE(folderPath, array);
		}
		if (this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3.texture == null)
		{
			this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3.texture = this.defaultAlbumArt;
		}
	}

	private IEnumerator \u02B9\u02B5\u02B3\u02B8\u02B7\u02B3\u02B2\u02B6\u02B7\u02B6\u02B6()
	{
		MenuMusic.\u02B6\u02B7\u02BA\u02B5\u02B4\u02B9\u02B7\u02BD\u02B5\u02B3\u02B2 u02B6_u02B7_u02BA_u02B5_u02B4_u02B9_u02B7_u02BD_u02B5_u02B3_u02B = new MenuMusic.\u02B6\u02B7\u02BA\u02B5\u02B4\u02B9\u02B7\u02BD\u02B5\u02B3\u02B2(1);
		u02B6_u02B7_u02BA_u02B5_u02B4_u02B9_u02B7_u02BD_u02B5_u02B3_u02B.<>4__this = this;
		return u02B6_u02B7_u02BA_u02B5_u02B4_u02B9_u02B7_u02BD_u02B5_u02B3_u02B;
	}

	public void \u02B9\u02BF\u02B3\u02C1\u02B9\u02B2\u02B9\u02BA\u02B8\u02B5\u02B9()
	{
		if (this.\u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8)
		{
			return;
		}
		if (SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume > 0)
		{
			this.\u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8 = true;
			this.\u02B6\u02C0\u02BE\u02B6\u02BB\u02B9\u02BC\u02B5\u02BE\u02B2\u02B7 = base.StartCoroutine(this.\u02C1\u02B6\u02B5\u02C0\u02B7\u02B2\u02B2\u02B9\u02B2\u02BE\u02B9());
		}
	}

	public void \u02C0\u02BC\u02B5\u02B7\u02B4\u02B4\u02B6\u02BF\u02BF\u02B6\u02C1()
	{
		if (BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE == null || BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE.folderPath == null || BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE.folderPath == string.Empty || !this.\u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8)
		{
			this.\u02BE\u02BD\u02B6\u02B5\u02B3\u02BF\u02B4\u02BC\u02B6\u02B6\u02B3.SetActive(true);
			return;
		}
		SongEntry u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE = BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE;
		this.\u02BE\u02BD\u02B6\u02B5\u02B3\u02BF\u02B4\u02BC\u02B6\u02B6\u02B3.SetActive(true);
		this.nameText.\u02BA\u02BC\u02BD\u02B4\u02B3\u02B9\u02B2\u02B4\u02C0\u02B5\u02B5(u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5, true);
		this.artistText.\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5, false);
		this.yearText.\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.Year.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5, true);
		if (u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.isEnc && u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.songEnc.\u02B9\u02BD\u02BC\u02B7\u02B9\u02B9\u02C0\u02BA\u02B9\u02B9\u02BB((\u02BC\u02C0\u02BC\u02BC\u02BD\u02B3\u02C0\u02B6\u02BA\u02B5\u02C0)4))
		{
			this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3.texture = u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.songEnc.\u02B5\u02BC\u02B4\u02C0\u02BE\u02C0\u02BC\u02BF\u02B2\u02B6\u02B4(\u02BC\u02C0\u02BC\u02BC\u02BD\u02B3\u02C0\u02B6\u02BA\u02B5\u02C0.NONE);
		}
		else
		{
			RawImage u02BC_u02C0_u02B7_u02B7_u02B5_u02B9_u02B9_u02C1_u02BB_u02B5_u02B = this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3;
			string folderPath = u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.folderPath;
			string[] array = new string[1];
			array[1] = "<color=#00FFFF>";
			array[1] = "";
			array[8] = "vocals";
			u02BC_u02C0_u02B7_u02B7_u02B5_u02B9_u02B9_u02C1_u02BB_u02B5_u02B.texture = GlobalVariables.\u02B4\u02B7\u02BF\u02BC\u02B4\u02B2\u02BF\u02B8\u02BF\u02BF\u02BE(folderPath, array);
		}
		if (this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3.texture == null)
		{
			this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3.texture = this.defaultAlbumArt;
		}
	}

	private IEnumerator \u02B7\u02C1\u02BC\u02B6\u02BC\u02BA\u02BA\u02B6\u02B5\u02B4\u02C1()
	{
		MenuMusic.\u02B6\u02B7\u02BA\u02B5\u02B4\u02B9\u02B7\u02BD\u02B5\u02B3\u02B2 u02B6_u02B7_u02BA_u02B5_u02B4_u02B9_u02B7_u02BD_u02B5_u02B3_u02B = new MenuMusic.\u02B6\u02B7\u02BA\u02B5\u02B4\u02B9\u02B7\u02BD\u02B5\u02B3\u02B2(1);
		u02B6_u02B7_u02BA_u02B5_u02B4_u02B9_u02B7_u02BD_u02B5_u02B3_u02B.<>4__this = this;
		return u02B6_u02B7_u02BA_u02B5_u02B4_u02B9_u02B7_u02BD_u02B5_u02B3_u02B;
	}

	private void OnApplicationFocus(bool \u02BE\u02BE\u02B5\u02C0\u02B7\u02B3\u02B5\u02B7\u02BF\u02B8\u02BA)
	{
		if (SettingsController.\u02BB\u02B7\u02BA\u02BC\u02B2\u02B8\u02B9\u02BC\u02C0\u02B5\u02B6 && SettingsController.\u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3 && this.\u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8)
		{
			if (\u02BE\u02BE\u02B5\u02C0\u02B7\u02B3\u02B5\u02B7\u02BF\u02B8\u02BA)
			{
				BassAudioManager.Instance.\u02BD\u02B7\u02B2\u02BE\u02B7\u02BD\u02C1\u02BE\u02C1\u02B9\u02B7(false);
				return;
			}
			BassAudioManager.Instance.\u02B7\u02BB\u02B6\u02C0\u02BE\u02B5\u02B8\u02C0\u02B3\u02C0\u02BD();
		}
	}

	private void \u02B2\u02B2\u02BC\u02B2\u02C1\u02BD\u02B8\u02B3\u02B4\u02B2\u02BC(bool \u02BE\u02BE\u02B5\u02C0\u02B7\u02B3\u02B5\u02B7\u02BF\u02B8\u02BA)
	{
		if (SettingsController.\u02BB\u02B7\u02BA\u02BC\u02B2\u02B8\u02B9\u02BC\u02C0\u02B5\u02B6 && SettingsController.\u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3 && this.\u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8)
		{
			if (\u02BE\u02BE\u02B5\u02C0\u02B7\u02B3\u02B5\u02B7\u02BF\u02B8\u02BA)
			{
				BassAudioManager.Instance.\u02BB\u02BC\u02BF\u02B8\u02BC\u02B6\u02BC\u02B3\u02B9\u02BC\u02B6(false);
				return;
			}
			BassAudioManager.Instance.\u02B7\u02BB\u02B6\u02C0\u02BE\u02B5\u02B8\u02C0\u02B3\u02C0\u02BD();
		}
	}

	public void OnEnable()
	{
		if (SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume > 0 && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4 != null && BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE == null)
		{
			BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C0\u02B3\u02B2\u02BA\u02BE\u02BF\u02BA\u02B5\u02BA\u02BB\u02BF(false);
		}
		base.Invoke("ʵʲʵʽˁʻʵʺʺʻʹ", 0.001f);
	}

	public void \u02B3\u02BE\u02B8\u02B5\u02C0\u02B8\u02BF\u02C0\u02B3\u02B7\u02B7(bool \u02C1\u02BA\u02BD\u02B6\u02B7\u02B4\u02B3\u02C0\u02B2\u02B2\u02B4)
	{
		if (\u02C1\u02BA\u02BD\u02B6\u02B7\u02B4\u02B3\u02C0\u02B2\u02B2\u02B4)
		{
			BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
		}
		else
		{
			BassAudioManager.Instance.\u02B6\u02BC\u02BC\u02B7\u02BD\u02B7\u02BA\u02BE\u02BA\u02C1\u02BB();
		}
		if (this.\u02B6\u02C0\u02BE\u02B6\u02BB\u02B9\u02BC\u02B5\u02BE\u02B2\u02B7 != null)
		{
			base.StopCoroutine(this.\u02B6\u02C0\u02BE\u02B6\u02BB\u02B9\u02BC\u02B5\u02BE\u02B2\u02B7);
		}
		this.\u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8 = false;
		this.\u02BE\u02BD\u02B6\u02B5\u02B3\u02BF\u02B4\u02BC\u02B6\u02B6\u02B3.SetActive(false);
		BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE = null;
	}

	public void \u02C0\u02B7\u02B3\u02BF\u02B9\u02B3\u02BB\u02C1\u02BB\u02BA\u02BF()
	{
		if (SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume > 1 && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4 != null && BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE == null)
		{
			BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C0\u02B3\u02B2\u02BA\u02BE\u02BF\u02BA\u02B5\u02BA\u02BB\u02BF(true);
		}
		base.Invoke("Export Current Song", 851f);
	}

	private void \u02B6\u02B9\u02BB\u02C1\u02B2\u02BE\u02BE\u02BB\u02B9\u02BB\u02BC(bool \u02BE\u02BE\u02B5\u02C0\u02B7\u02B3\u02B5\u02B7\u02BF\u02B8\u02BA)
	{
		if (SettingsController.\u02BB\u02B7\u02BA\u02BC\u02B2\u02B8\u02B9\u02BC\u02C0\u02B5\u02B6 && SettingsController.\u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3 && this.\u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8)
		{
			if (\u02BE\u02BE\u02B5\u02C0\u02B7\u02B3\u02B5\u02B7\u02BF\u02B8\u02BA)
			{
				BassAudioManager.Instance.\u02BB\u02BC\u02BF\u02B8\u02BC\u02B6\u02BC\u02B3\u02B9\u02BC\u02B6(true);
				return;
			}
			BassAudioManager.Instance.\u02B7\u02BB\u02B6\u02C0\u02BE\u02B5\u02B8\u02C0\u02B3\u02C0\u02BD();
		}
	}

	public void \u02BA\u02B9\u02BF\u02B2\u02B6\u02C1\u02B8\u02BF\u02C0\u02B9\u02B7()
	{
		if (this.\u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8)
		{
			return;
		}
		if (SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume > 1)
		{
			this.\u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8 = true;
			this.\u02B6\u02C0\u02BE\u02B6\u02BB\u02B9\u02BC\u02B5\u02BE\u02B2\u02B7 = base.StartCoroutine(this.\u02B7\u02C1\u02BC\u02B6\u02BC\u02BA\u02BA\u02B6\u02B5\u02B4\u02C1());
		}
	}

	private void \u02B2\u02BE\u02B8\u02B9\u02C1\u02BE\u02BA\u02B8\u02B9\u02B2\u02B8(bool \u02BE\u02BE\u02B5\u02C0\u02B7\u02B3\u02B5\u02B7\u02BF\u02B8\u02BA)
	{
		if (SettingsController.\u02BB\u02B7\u02BA\u02BC\u02B2\u02B8\u02B9\u02BC\u02C0\u02B5\u02B6 && SettingsController.\u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3 && this.\u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8)
		{
			if (\u02BE\u02BE\u02B5\u02C0\u02B7\u02B3\u02B5\u02B7\u02BF\u02B8\u02BA)
			{
				BassAudioManager.Instance.\u02BD\u02B7\u02B2\u02BE\u02B7\u02BD\u02C1\u02BE\u02C1\u02B9\u02B7(true);
				return;
			}
			BassAudioManager.Instance.\u02B7\u02BB\u02B6\u02C0\u02BE\u02B5\u02B8\u02C0\u02B3\u02C0\u02BD();
		}
	}

	private IEnumerator \u02BF\u02B2\u02BB\u02B4\u02BD\u02C1\u02B3\u02B4\u02B9\u02B2\u02B6()
	{
		MenuMusic.\u02B6\u02B7\u02BA\u02B5\u02B4\u02B9\u02B7\u02BD\u02B5\u02B3\u02B2 u02B6_u02B7_u02BA_u02B5_u02B4_u02B9_u02B7_u02BD_u02B5_u02B3_u02B = new MenuMusic.\u02B6\u02B7\u02BA\u02B5\u02B4\u02B9\u02B7\u02BD\u02B5\u02B3\u02B2(1);
		u02B6_u02B7_u02BA_u02B5_u02B4_u02B9_u02B7_u02BD_u02B5_u02B3_u02B.<>4__this = this;
		return u02B6_u02B7_u02BA_u02B5_u02B4_u02B9_u02B7_u02BD_u02B5_u02B3_u02B;
	}

	public void \u02B5\u02B2\u02B5\u02BD\u02C1\u02BB\u02B5\u02BA\u02BA\u02BB\u02B9()
	{
		if (BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE == null || BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE.folderPath == null || BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE.folderPath == string.Empty || !this.\u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8)
		{
			this.\u02BE\u02BD\u02B6\u02B5\u02B3\u02BF\u02B4\u02BC\u02B6\u02B6\u02B3.SetActive(false);
			return;
		}
		SongEntry u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE = BassAudioManager.Instance.\u02C1\u02B2\u02C1\u02BA\u02BA\u02C1\u02BA\u02B4\u02BD\u02C0\u02BE;
		this.\u02BE\u02BD\u02B6\u02B5\u02B3\u02BF\u02B4\u02BC\u02B6\u02B6\u02B3.SetActive(true);
		this.nameText.\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5, true);
		this.artistText.\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5, true);
		this.yearText.\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.Year.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5, true);
		if (u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.isEnc && u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.songEnc.\u02B4\u02B2\u02BC\u02B9\u02B4\u02B6\u02B7\u02BE\u02BA\u02B4\u02B9(\u02BC\u02C0\u02BC\u02BC\u02BD\u02B3\u02C0\u02B6\u02BA\u02B5\u02C0.ALBUM_ART))
		{
			this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3.texture = u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.songEnc.\u02B5\u02BC\u02B4\u02C0\u02BE\u02C0\u02BC\u02BF\u02B2\u02B6\u02B4(\u02BC\u02C0\u02BC\u02BC\u02BD\u02B3\u02C0\u02B6\u02BA\u02B5\u02C0.ALBUM_ART);
		}
		else
		{
			this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3.texture = GlobalVariables.\u02B4\u02B7\u02BF\u02BC\u02B4\u02B2\u02BF\u02B8\u02BF\u02BF\u02BE(u02C1_u02B2_u02C1_u02BA_u02BA_u02C1_u02BA_u02B4_u02BD_u02C0_u02BE.folderPath, new string[] { "album.png", "album.jpg", "album.jpeg" });
		}
		if (this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3.texture == null)
		{
			this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3.texture = this.defaultAlbumArt;
		}
	}

	public bool \u02B4\u02B2\u02BA\u02B6\u02BC\u02BE\u02BB\u02B5\u02B2\u02BE\u02B8;

	private Coroutine \u02B6\u02C0\u02BE\u02B6\u02BB\u02B9\u02BC\u02B5\u02BE\u02B2\u02B7;

	public GameObject \u02BE\u02BD\u02B6\u02B5\u02B3\u02BF\u02B4\u02BC\u02B6\u02B6\u02B3;

	public RawImage \u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3;

	[SerializeField]
	private ScrollingText nameText;

	[SerializeField]
	private ScrollingText artistText;

	[SerializeField]
	private ScrollingText yearText;

	[SerializeField]
	private SongScan songScan;

	[SerializeField]
	private Texture defaultAlbumArt;
}
