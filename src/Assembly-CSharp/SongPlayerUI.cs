using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

// Token: 0x0200021A RID: 538
public class SongPlayerUI : MonoBehaviour
{
	// Token: 0x17000251 RID: 593
	// (get) Token: 0x06001839 RID: 6201 RVA: 0x000128B4 File Offset: 0x00010AB4
	// (set) Token: 0x06001844 RID: 6212 RVA: 0x0001290E File Offset: 0x00010B0E
	public AudioControls \u02B3\u02B5\u02B9\u02BF\u02BC\u02C1\u02B5\u02B5\u02BC\u02B7\u02B6 { get; protected set; }

	// Token: 0x0600183A RID: 6202 RVA: 0x000B38F0 File Offset: 0x000B1AF0
	private void \u02B6\u02BB\u02BA\u02C0\u02B3\u02B4\u02B5\u02BD\u02B8\u02BD\u02B2()
	{
		Debug.Log("Playing Audio");
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1 = this.\u02B3\u02B5\u02B9\u02BF\u02BC\u02C1\u02B5\u02B5\u02BC\u02B7\u02B6.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA;
		BassAudioManager.Instance.\u02BE\u02B3\u02B8\u02B4\u02BB\u02B3\u02BE\u02B4\u02BA\u02C0\u02BA(this.\u02B3\u02B5\u02B9\u02BF\u02BC\u02C1\u02B5\u02B5\u02BC\u02B7\u02B6.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA, false, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Crowd, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.None);
		BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume);
		Debug.Log(string.Format("Audio Length: {0}", BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC));
		if (BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC > 0.0)
		{
			BassAudioManager.Instance.\u02BD\u02B7\u02B2\u02BE\u02B7\u02BD\u02C1\u02BE\u02C1\u02B9\u02B7(true);
			BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume);
			BassAudioManager.Instance.\u02B2\u02BC\u02BD\u02BF\u02B2\u02BE\u02BA\u02BA\u02B3\u02C1\u02B8(100);
			return;
		}
		Debug.LogError("ERROR: Song length is 0 ignoring playback request.");
		this.\u02B9\u02C0\u02B8\u02BC\u02BA\u02C1\u02C0\u02BF\u02B4\u02BD\u02B9 = null;
		this.\u02B3\u02B5\u02B9\u02BF\u02BC\u02C1\u02B5\u02B5\u02BC\u02B7\u02B6 = null;
	}

	// Token: 0x0600183B RID: 6203 RVA: 0x000B39C0 File Offset: 0x000B1BC0
	private void \u02B4\u02B2\u02B5\u02BA\u02B4\u02C0\u02BC\u02BB\u02C1\u02B9\u02BD()
	{
		foreach (SongEntry songEntry in this.\u02B7\u02B8\u02C1\u02B4\u02B5\u02C0\u02C0\u02BF\u02B5\u02B4\u02B7())
		{
			this.\u02B4\u02BC\u02B5\u02B2\u02B2\u02B2\u02BC\u02B3\u02BA\u02BD\u02B6(songEntry);
		}
	}

	// Token: 0x17000250 RID: 592
	// (get) Token: 0x0600183C RID: 6204 RVA: 0x000128BC File Offset: 0x00010ABC
	// (set) Token: 0x06001846 RID: 6214 RVA: 0x000128E3 File Offset: 0x00010AE3
	public AudioControls \u02B9\u02C0\u02B8\u02BC\u02BA\u02C1\u02C0\u02BF\u02B4\u02BD\u02B9 { get; protected set; }

	// Token: 0x0600183D RID: 6205 RVA: 0x000128C4 File Offset: 0x00010AC4
	public void \u02B3\u02B6\u02B8\u02C1\u02B5\u02C1\u02B3\u02B4\u02B8\u02C0\u02BA(AudioControls \u02B8\u02B7\u02B7\u02C1\u02BF\u02BF\u02B6\u02B6\u02BF\u02BF\u02BF)
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			BassAudioManager.Instance.\u02B3\u02BE\u02BF\u02BF\u02B9\u02BD\u02BA\u02B8\u02B5\u02BE\u02B8();
		}
		this.\u02B3\u02B5\u02B9\u02BF\u02BC\u02C1\u02B5\u02B5\u02BC\u02B7\u02B6 = \u02B8\u02B7\u02B7\u02C1\u02BF\u02BF\u02B6\u02B6\u02BF\u02BF\u02BF;
	}

	// Token: 0x0600183E RID: 6206 RVA: 0x000128E3 File Offset: 0x00010AE3
	protected void \u02BF\u02BE\u02BF\u02BB\u02B5\u02B6\u02BB\u02BF\u02B8\u02C1\u02B8(AudioControls \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B5\u02B4\u02B8\u02B2\u02B3\u02B9\u02B2\u02C1\u02B5\u02B6\u02B6>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x0600183F RID: 6207 RVA: 0x000128EC File Offset: 0x00010AEC
	private void Update()
	{
		if (this.\u02B3\u02B5\u02B9\u02BF\u02BC\u02C1\u02B5\u02B5\u02BC\u02B7\u02B6 != null && !BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			this.\u02B6\u02BB\u02BA\u02C0\u02B3\u02B4\u02B5\u02BD\u02B8\u02BD\u02B2();
		}
	}

	// Token: 0x06001840 RID: 6208 RVA: 0x000B3A10 File Offset: 0x000B1C10
	private void Start()
	{
		foreach (SongEntry songEntry in this.\u02B7\u02B8\u02C1\u02B4\u02B5\u02C0\u02C0\u02BF\u02B5\u02B4\u02B7())
		{
			this.\u02B4\u02C0\u02B4\u02B8\u02B5\u02B2\u02B8\u02B9\u02BF\u02B2\u02B7(songEntry);
		}
	}

	// Token: 0x06001841 RID: 6209 RVA: 0x0001290E File Offset: 0x00010B0E
	protected void \u02BF\u02B4\u02B2\u02C0\u02BE\u02B5\u02BE\u02B6\u02B5\u02BA\u02BB(AudioControls \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B8\u02BF\u02C1\u02BB\u02BD\u02B3\u02BC\u02BC\u02BE\u02BC\u02B2>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06001842 RID: 6210 RVA: 0x00012917 File Offset: 0x00010B17
	private IEnumerable<SongEntry> \u02B7\u02B8\u02C1\u02B4\u02B5\u02C0\u02C0\u02BF\u02B5\u02B4\u02B7()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(__FIXME_clon_util.\u02B4\u02B6\u02BE\u02B5\u02BB\u02BA\u02BB\u02C0\u02C1\u02C1\u02B7(), "songs"));
		Debug.Log(directoryInfo);
		foreach (FileInfo fileInfo in directoryInfo.EnumerateFiles())
		{
			Debug.Log(fileInfo.Extension);
			if (fileInfo.Extension == ".sng")
			{
				SongEntry songEntry = new SongEntry(fileInfo.FullName);
				yield return songEntry;
				songEntry.videoBackground = false;
				Debug.Log("Loaded .sng");
				songEntry.\u02B9\u02BC\u02C1\u02BC\u02B8\u02B5\u02BD\u02BE\u02B5\u02B4\u02BD();
				songEntry = null;
			}
		}
		IEnumerator<FileInfo> enumerator = null;
		yield break;
		yield break;
	}

	// Token: 0x06001843 RID: 6211 RVA: 0x000B3A10 File Offset: 0x000B1C10
	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		foreach (SongEntry songEntry in this.\u02B7\u02B8\u02C1\u02B4\u02B5\u02C0\u02C0\u02BF\u02B5\u02B4\u02B7())
		{
			this.\u02B4\u02C0\u02B4\u02B8\u02B5\u02B2\u02B8\u02B9\u02BF\u02B2\u02B7(songEntry);
		}
	}

	// Token: 0x06001845 RID: 6213 RVA: 0x00012920 File Offset: 0x00010B20
	private void \u02BE\u02BC\u02BB\u02B7\u02B3\u02B4\u02BC\u02B8\u02BD\u02C1\u02BC(SongEntry \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD)
	{
		this.listPrefab.SetActive(false);
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.listPrefab, this.parentContainer.transform);
		AudioControls component = gameObject.GetComponent<AudioControls>();
		component.\u02B8\u02C1\u02BC\u02BE\u02B4\u02B7\u02B7\u02B3\u02BC\u02B9\u02B6(\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD);
		component.\u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3 = this;
		gameObject.SetActive(true);
	}

	// Token: 0x06001847 RID: 6215 RVA: 0x000128BC File Offset: 0x00010ABC
	public AudioControls \u02B7\u02BF\u02B6\u02BF\u02B6\u02BB\u02B2\u02B5\u02BD\u02BC\u02BD()
	{
		return this.<\u02B5\u02B4\u02B8\u02B2\u02B3\u02B9\u02B2\u02C1\u02B5\u02B6\u02B6>k__BackingField;
	}

	// Token: 0x06001848 RID: 6216 RVA: 0x0001295D File Offset: 0x00010B5D
	private void \u02B9\u02BD\u02B6\u02B2\u02BF\u02BE\u02BA\u02B6\u02B3\u02BD\u02BD(SongEntry \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD)
	{
		this.listPrefab.SetActive(true);
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.listPrefab, this.parentContainer.transform);
		AudioControls component = gameObject.GetComponent<AudioControls>();
		component.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD;
		component.\u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3 = this;
		gameObject.SetActive(true);
	}

	// Token: 0x06001849 RID: 6217 RVA: 0x000128E3 File Offset: 0x00010AE3
	protected void \u02B5\u02BD\u02B9\u02B4\u02B7\u02BA\u02BF\u02BE\u02BB\u02B2\u02B5(AudioControls \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B5\u02B4\u02B8\u02B2\u02B3\u02B9\u02B2\u02C1\u02B5\u02B6\u02B6>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x0600184B RID: 6219 RVA: 0x0001299A File Offset: 0x00010B9A
	private void \u02B4\u02BC\u02B5\u02B2\u02B2\u02B2\u02BC\u02B3\u02BA\u02BD\u02B6(SongEntry \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD)
	{
		this.listPrefab.SetActive(false);
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.listPrefab, this.parentContainer.transform);
		AudioControls component = gameObject.GetComponent<AudioControls>();
		component.\u02BB\u02B8\u02BD\u02B7\u02B6\u02BF\u02B2\u02B6\u02BF\u02B7\u02BE(\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD);
		component.\u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3 = this;
		gameObject.SetActive(false);
	}

	// Token: 0x0600184C RID: 6220 RVA: 0x000129D7 File Offset: 0x00010BD7
	private void \u02B3\u02B2\u02BB\u02B3\u02B2\u02C1\u02C1\u02B3\u02B8\u02C1\u02B5()
	{
		if (this.\u02B3\u02B5\u02B9\u02BF\u02BC\u02C1\u02B5\u02B5\u02BC\u02B7\u02B6 != null && !BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			this.\u02BA\u02B5\u02C1\u02BE\u02B5\u02BE\u02BD\u02C1\u02BB\u02BF\u02BD();
		}
	}

	// Token: 0x0600184D RID: 6221 RVA: 0x000129F9 File Offset: 0x00010BF9
	public void \u02BB\u02BB\u02B8\u02B7\u02BF\u02B7\u02BB\u02B5\u02C1\u02B7\u02B9(AudioControls \u02B8\u02B7\u02B7\u02C1\u02BF\u02BF\u02B6\u02B6\u02BF\u02BF\u02BF)
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			BassAudioManager.Instance.\u02B6\u02BC\u02BC\u02B7\u02BD\u02B7\u02BA\u02BE\u02BA\u02C1\u02BB();
		}
		this.\u02B3\u02B5\u02B9\u02BF\u02BC\u02C1\u02B5\u02B5\u02BC\u02B7\u02B6 = \u02B8\u02B7\u02B7\u02C1\u02BF\u02BF\u02B6\u02B6\u02BF\u02BF\u02BF;
	}

	// Token: 0x0600184E RID: 6222 RVA: 0x000129F9 File Offset: 0x00010BF9
	public void \u02B5\u02BD\u02BC\u02BF\u02BC\u02B6\u02B6\u02BA\u02BE\u02BF\u02BE(AudioControls \u02B8\u02B7\u02B7\u02C1\u02BF\u02BF\u02B6\u02B6\u02BF\u02BF\u02BF)
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			BassAudioManager.Instance.\u02B6\u02BC\u02BC\u02B7\u02BD\u02B7\u02BA\u02BE\u02BA\u02C1\u02BB();
		}
		this.\u02B3\u02B5\u02B9\u02BF\u02BC\u02C1\u02B5\u02B5\u02BC\u02B7\u02B6 = \u02B8\u02B7\u02B7\u02C1\u02BF\u02BF\u02B6\u02B6\u02BF\u02BF\u02BF;
	}

	// Token: 0x0600184F RID: 6223 RVA: 0x00012A18 File Offset: 0x00010C18
	private void \u02B4\u02C0\u02B4\u02B8\u02B5\u02B2\u02B8\u02B9\u02BF\u02B2\u02B7(SongEntry \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD)
	{
		this.listPrefab.SetActive(false);
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.listPrefab, this.parentContainer.transform);
		AudioControls component = gameObject.GetComponent<AudioControls>();
		component.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD;
		component.\u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3 = this;
		gameObject.SetActive(true);
	}

	// Token: 0x06001850 RID: 6224 RVA: 0x000128C4 File Offset: 0x00010AC4
	public void \u02B7\u02B2\u02B6\u02B6\u02BB\u02C1\u02B2\u02B3\u02BC\u02B9\u02B6(AudioControls \u02B8\u02B7\u02B7\u02C1\u02BF\u02BF\u02B6\u02B6\u02BF\u02BF\u02BF)
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			BassAudioManager.Instance.\u02B3\u02BE\u02BF\u02BF\u02B9\u02BD\u02BA\u02B8\u02B5\u02BE\u02B8();
		}
		this.\u02B3\u02B5\u02B9\u02BF\u02BC\u02C1\u02B5\u02B5\u02BC\u02B7\u02B6 = \u02B8\u02B7\u02B7\u02C1\u02BF\u02BF\u02B6\u02B6\u02BF\u02BF\u02BF;
	}

	// Token: 0x06001851 RID: 6225 RVA: 0x000128EC File Offset: 0x00010AEC
	private void \u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0()
	{
		if (this.\u02B3\u02B5\u02B9\u02BF\u02BC\u02C1\u02B5\u02B5\u02BC\u02B7\u02B6 != null && !BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			this.\u02B6\u02BB\u02BA\u02C0\u02B3\u02B4\u02B5\u02BD\u02B8\u02BD\u02B2();
		}
	}

	// Token: 0x06001852 RID: 6226 RVA: 0x000B3A60 File Offset: 0x000B1C60
	private void \u02BA\u02B5\u02C1\u02BE\u02B5\u02BE\u02BD\u02C1\u02BB\u02BF\u02BD()
	{
		Debug.Log("Prefabs/Gameplay/Players/");
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1 = this.\u02B3\u02B5\u02B9\u02BF\u02BC\u02C1\u02B5\u02B5\u02BC\u02B7\u02B6.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA;
		BassAudioManager.Instance.\u02BE\u02B3\u02B8\u02B4\u02BB\u02B3\u02BE\u02B4\u02BA\u02C0\u02BA(this.\u02B3\u02B5\u02B9\u02BF\u02BC\u02C1\u02B5\u02B5\u02BC\u02B7\u02B6.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA, false, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Guitar, (\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE)(-11));
		BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume);
		Debug.Log(string.Format("No", BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC));
		if (BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC > 782.0)
		{
			BassAudioManager.Instance.\u02BD\u02B7\u02B2\u02BE\u02B7\u02BD\u02C1\u02BE\u02C1\u02B9\u02B7(true);
			BassAudioManager.Instance.\u02BD\u02BB\u02B3\u02B3\u02B3\u02BA\u02B6\u02B6\u02C0\u02B9\u02B3(SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF.GetCurrentVolume);
			BassAudioManager.Instance.\u02B2\u02BC\u02BD\u02BF\u02B2\u02BE\u02BA\u02BA\u02B3\u02C1\u02B8(-65);
			return;
		}
		Debug.LogError("FSCache Scan");
		this.\u02BF\u02BE\u02BF\u02BB\u02B5\u02B6\u02BB\u02BF\u02B8\u02C1\u02B8(null);
		this.\u02BF\u02B4\u02B2\u02C0\u02BE\u02B5\u02BE\u02B6\u02B5\u02BA\u02BB(null);
	}

	// Token: 0x06001853 RID: 6227 RVA: 0x000128E3 File Offset: 0x00010AE3
	protected void \u02BD\u02B9\u02B9\u02B5\u02C0\u02B9\u02B2\u02B6\u02BE\u02BE\u02BF(AudioControls \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B5\u02B4\u02B8\u02B2\u02B3\u02B9\u02B2\u02C1\u02B5\u02B6\u02B6>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x04001127 RID: 4391
	[SerializeField]
	private GameObject listPrefab;

	// Token: 0x04001128 RID: 4392
	[SerializeField]
	private GameObject parentContainer;
}
