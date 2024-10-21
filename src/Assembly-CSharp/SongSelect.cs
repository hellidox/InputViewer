using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using StrikeCore;
using TMPro;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;

// Token: 0x02000113 RID: 275
public class SongSelect : BaseMenu
{
	// Token: 0x06000BC7 RID: 3015 RVA: 0x0000C03F File Offset: 0x0000A23F
	public void \u02BB\u02BF\u02BF\u02C1\u02B6\u02BF\u02B3\u02BD\u02B7\u02BA\u02C1(bool \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5)
	{
		this.sectionBrowser.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD(\u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5);
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x00068FFC File Offset: 0x000671FC
	protected override void OnDisable()
	{
		base.OnDisable();
		if (this.scorePanel)
		{
			this.scorePanel.gameObject.SetActive(false);
		}
		if (this.songOptions)
		{
			this.songOptions.gameObject.SetActive(false);
		}
		if (this.sectionBrowser)
		{
			this.sectionBrowser.gameObject.SetActive(false);
		}
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x0006906C File Offset: 0x0006726C
	private string \u02BF\u02B3\u02BE\u02B5\u02B2\u02BA\u02B9\u02B9\u02C1\u02B7\u02BB(int \u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF)
	{
		string text;
		if (\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF == 1)
		{
			text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("setlistSongCountSingular");
		}
		else
		{
			text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("setlistSongCountPlural");
		}
		if (text == "setlistSongCountPlural" || text == "setlistSongCountSingular")
		{
			return string.Format("{0} {1}", \u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF, \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Songs")).ToUpper();
		}
		return text.Replace("%count%", string.Format("{0}", \u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF)).ToUpper();
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x0000C04D File Offset: 0x0000A24D
	public void \u02C0\u02B7\u02BC\u02B4\u02B7\u02C1\u02BF\u02B3\u02B5\u02B4\u02C1()
	{
		this.songSelectSearch.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3 = true;
		this.songSelectSearch.gameObject.SetActive(true);
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x0000C06C File Offset: 0x0000A26C
	private IEnumerator \u02C1\u02BE\u02B7\u02B8\u02B9\u02B2\u02B7\u02BA\u02BC\u02BC\u02BF()
	{
		double u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC = BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC;
		double num = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0();
		double audioEnd = ((num + 30.0 < u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC) ? (num + 28.0) : ((u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC > 2.0) ? (u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC - 2.0) : u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC));
		for (;;)
		{
			if (BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0() >= audioEnd)
			{
				BassAudioManager.Instance.\u02C1\u02B3\u02B2\u02BB\u02B7\u02B8\u02BD\u02BC\u02BF\u02BC\u02C0(null);
				yield return new WaitForSeconds(2f);
				while (SettingsController.\u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3 && !Application.isFocused)
				{
					yield return new WaitForSeconds(1f);
				}
				BassAudioManager.Instance.\u02B2\u02B9\u02BA\u02BA\u02B3\u02B8\u02B4\u02B5\u02BE\u02B7\u02BB(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD);
			}
			else
			{
				yield return null;
			}
		}
		yield break;
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x0000C03F File Offset: 0x0000A23F
	public void \u02B2\u02B3\u02BF\u02C1\u02B9\u02B6\u02BC\u02BF\u02B7\u02BD\u02B7(bool \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5)
	{
		this.sectionBrowser.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD(\u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5);
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x0000C07B File Offset: 0x0000A27B
	public void \u02B3\u02C1\u02C0\u02B2\u02B9\u02BB\u02B6\u02B6\u02B4\u02C0\u02BB()
	{
		this.speedText.text = string.Format("{0}: {1}%", \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Song Speed"), SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.CurrentValue);
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x0000C0B0 File Offset: 0x0000A2B0
	public void \u02BA\u02C1\u02B4\u02BB\u02BC\u02BF\u02BF\u02C1\u02B3\u02C0\u02B3(bool \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5)
	{
		this.sectionBrowser.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02BC\u02BF\u02B6\u02B5\u02BF\u02B6\u02B2\u02B6\u02BE\u02B4(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC, 0), \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5);
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x00069104 File Offset: 0x00067304
	public void \u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(string \u02BE\u02BA\u02BD\u02BB\u02B8\u02BE\u02B4\u02BB\u02C1\u02BD\u02B2)
	{
		object obj = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BE\u02BF\u02B3\u02C1\u02B3\u02BF\u02BE\u02B3\u02B7(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(\u02BE\u02BA\u02BD\u02BB\u02B8\u02BE\u02B4\u02BB\u02C1\u02BD\u02B2, false);
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		SongEntry songEntry = obj as SongEntry;
		if (songEntry != null)
		{
			this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02B5\u02B4\u02BD\u02B7\u02B4\u02B9\u02B8\u02B8\u02B5\u02BF(songEntry), true);
		}
		else
		{
			this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
		}
		this.\u02B7\u02C0\u02BB\u02B6\u02B3\u02C0\u02B9\u02BF\u02B5\u02C0\u02B6 = (this.\u02C0\u02C1\u02B6\u02BF\u02BF\u02B2\u02B5\u02C0\u02BB\u02BA\u02C1 = false);
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x0006915C File Offset: 0x0006735C
	private string \u02B7\u02B7\u02BB\u02BB\u02B4\u02B7\u02B5\u02B5\u02BF\u02B9\u02B9()
	{
		string text = Path.Combine(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.folderPath, "album.jpg");
		string text2 = Path.Combine(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.folderPath, "album.jpeg");
		string text3 = Path.Combine(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.folderPath, "album.png");
		if (File.Exists(text3))
		{
			return text3;
		}
		if (File.Exists(text))
		{
			return text;
		}
		if (File.Exists(text2))
		{
			return text2;
		}
		return null;
	}

	// Token: 0x06000BD1 RID: 3025 RVA: 0x000691CC File Offset: 0x000673CC
	public void \u02BA\u02B9\u02B3\u02B4\u02B4\u02BC\u02C0\u02C1\u02B6\u02BC\u02B6(Func<SongEntry, bool> \u02C0\u02BF\u02B5\u02B2\u02BB\u02BE\u02B3\u02B8\u02B2\u02BD\u02B8, string \u02C1\u02BC\u02C0\u02B7\u02BE\u02B7\u02BF\u02BA\u02BD\u02BD\u02B7)
	{
		SongSelect.\u02B2\u02B6\u02BF\u02C0\u02BC\u02C0\u02B6\u02B4\u02B8\u02BA\u02BF u02B2_u02B6_u02BF_u02C0_u02BC_u02C0_u02B6_u02B4_u02B8_u02BA_u02BF = new SongSelect.\u02B2\u02B6\u02BF\u02C0\u02BC\u02C0\u02B6\u02B4\u02B8\u02BA\u02BF();
		u02B2_u02B6_u02BF_u02C0_u02BC_u02C0_u02B6_u02B4_u02B8_u02BA_u02BF.filterFunc = \u02C0\u02BF\u02B5\u02B2\u02BB\u02BE\u02B3\u02B8\u02B2\u02BD\u02B8;
		u02B2_u02B6_u02BF_u02C0_u02BC_u02C0_u02B6_u02B4_u02B8_u02BA_u02BF.tag = \u02C1\u02BC\u02C0\u02B7\u02BE\u02B7\u02BF\u02BA\u02BD\u02BD\u02B7;
		this.\u02B2\u02B8\u02B6\u02BF\u02C0\u02C1\u02B3\u02B8\u02C0\u02B5\u02BB(new Action(u02B2_u02B6_u02BF_u02C0_u02BC_u02C0_u02B6_u02B4_u02B8_u02BA_u02BF.\u02BD\u02C1\u02B5\u02B7\u02C0\u02BB\u02BB\u02B7\u02BD\u02BD\u02BE));
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x0000C0CA File Offset: 0x0000A2CA
	public void \u02C0\u02B6\u02BC\u02B2\u02B6\u02BF\u02B6\u02BA\u02B6\u02B8\u02BC(SongEntry \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD)
	{
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02B5\u02B4\u02BD\u02B7\u02B4\u02B9\u02B8\u02B8\u02B5\u02BF(\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD), true);
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x0000C04D File Offset: 0x0000A24D
	public void \u02BC\u02B3\u02C0\u02BA\u02B3\u02B3\u02B5\u02BA\u02BE\u02B5\u02BE()
	{
		this.songSelectSearch.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3 = true;
		this.songSelectSearch.gameObject.SetActive(true);
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x0000C0D9 File Offset: 0x0000A2D9
	public void \u02B7\u02BD\u02BD\u02B9\u02B5\u02C0\u02B8\u02BA\u02C0\u02C1\u02B6(SongEntry \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD)
	{
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02B5\u02B4\u02BD\u02B7\u02B4\u02B9\u02B8\u02B8\u02B5\u02BF(\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD), false);
	}

	// Token: 0x06000BD5 RID: 3029 RVA: 0x0000C0E8 File Offset: 0x0000A2E8
	private IEnumerator \u02B9\u02B8\u02B6\u02B9\u02BD\u02B7\u02BB\u02BE\u02B6\u02BA\u02C0()
	{
		BassAudioManager.Instance.\u02C1\u02B3\u02B2\u02BB\u02B7\u02B8\u02BD\u02BC\u02BF\u02BC\u02C0(null);
		if (this.\u02B5\u02C0\u02B4\u02B7\u02BB\u02BB\u02BD\u02B2\u02B4\u02BF\u02BE != null)
		{
			base.StopCoroutine(this.\u02B5\u02C0\u02B4\u02B7\u02BB\u02BB\u02BD\u02B2\u02B4\u02BF\u02BE);
		}
		DiscordController.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BF\u02B5\u02C1\u02B7\u02C1\u02B5\u02B6\u02BC\u02C0\u02B3(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD);
		yield return new WaitForSecondsRealtime(0.5f);
		if (SettingsController.\u02B8\u02B7\u02BF\u02B4\u02B3\u02BB\u02B6\u02BB\u02B7\u02B2\u02BD.GetCurrentVolume > 0)
		{
			BassAudioManager.Instance.\u02B2\u02B9\u02BA\u02BA\u02B3\u02B8\u02B4\u02B5\u02BE\u02B7\u02BB(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD);
			this.\u02B5\u02C0\u02B4\u02B7\u02BB\u02BB\u02BD\u02B2\u02B4\u02BF\u02BE = base.StartCoroutine(this.\u02C1\u02BE\u02B7\u02B8\u02B9\u02B2\u02B7\u02BA\u02BC\u02BC\u02BF());
		}
		yield return null;
		yield break;
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x00069200 File Offset: 0x00067400
	public override void \u02C1\u02B6\u02BD\u02BC\u02BC\u02B3\u02BF\u02BF\u02C0\u02C1\u02BC()
	{
		if (this.\u02C1\u02B5\u02B9\u02B4\u02B9\u02B5\u02BC\u02B3\u02B4\u02C0\u02BF)
		{
			this.\u02C1\u02B5\u02B9\u02B4\u02B9\u02B5\u02BC\u02B3\u02B4\u02C0\u02BF = false;
			return;
		}
		object obj = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BE\u02BF\u02B3\u02C1\u02B3\u02BF\u02BE\u02B3\u02B7(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		if (obj is \u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8)
		{
			int num = base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC;
			\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BC\u02C0\u02B5\u02BC\u02B9\u02BA\u02BC\u02BD\u02B7((\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8)obj);
			this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
			this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(num, true);
			return;
		}
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			(\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B7\u02B3\u02B2\u02BD\u02B4\u02BC\u02C1\u02B8\u02C0\u02BA as \u02B8\u02B4\u02B4\u02BE\u02B5\u02B6\u02B7\u02B7\u02BC\u02B5\u02B7).\u02C0\u02BD\u02BB\u02B6\u02B9\u02BB\u02BB\u02B8\u02BB\u02BE\u02BB((SongEntry)obj);
			return;
		}
		if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 && this.setlistMenu.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB)
		{
			this.setlistMenu.\u02BA\u02B4\u02B2\u02BB\u02B9\u02BC\u02B9\u02B8\u02C1\u02B5\u02BE((SongEntry)obj, SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.CurrentValue, "");
			return;
		}
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02BD\u02C1\u02C0\u02B4\u02B7\u02BE\u02BF\u02BD\u02B7\u02B7)
		{
			this.\u02BD\u02B7\u02B2\u02BE\u02B7\u02BD\u02C1\u02BE\u02C1\u02B9\u02B7();
		}
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x000692C0 File Offset: 0x000674C0
	public virtual void \u02BD\u02B9\u02B2\u02B5\u02B8\u02B2\u02B4\u02BE\u02C1\u02BF\u02B7()
	{
		int num = 1;
		while (num < this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2.Length && this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[num].enabled)
		{
			if (!(this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[num].color == (BlackMenu.\u02B3\u02B4\u02B7\u02B2\u02B4\u02B8\u02B7\u02B3\u02B7\u02B3\u02B4() ? this.\u02B9\u02B9\u02C1\u02BA\u02BD\u02B7\u02B2\u02B4\u02B4\u02BB\u02BA : this.\u02BA\u02B5\u02BA\u02B2\u02B5\u02B4\u02B3\u02B9\u02BB\u02B7\u02BE)) || num == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3)
			{
				if (num == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3)
				{
					object obj = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BE\u02BF\u02B3\u02C1\u02B3\u02BF\u02BE\u02B3\u02B7(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
					if (obj is SongEntry)
					{
						this.\u02BC\u02BA\u02BD\u02B2\u02BD\u02BA\u02BE\u02C1\u02C0\u02B5\u02C1[num].color = this.\u02C0\u02BA\u02BA\u02BC\u02B6\u02B3\u02B5\u02BB\u02B2\u02BE\u02B4;
						this.textObjects[num].color = this.\u02C0\u02BA\u02BA\u02BC\u02B6\u02B3\u02B5\u02BB\u02B2\u02BE\u02B4;
						this.\u02B7\u02B7\u02B7\u02B4\u02BD\u02B6\u02C0\u02B2\u02B8\u02B3\u02B4[num].color = this.\u02C0\u02BA\u02BA\u02BC\u02B6\u02B3\u02B5\u02BB\u02B2\u02BE\u02B4;
						this.\u02B9\u02BB\u02B3\u02C1\u02B2\u02C1\u02B9\u02C0\u02BF\u02BD\u02C0[num].color = this.\u02C0\u02BA\u02BA\u02BC\u02B6\u02B3\u02B5\u02BB\u02B2\u02BE\u02B4;
						this.\u02BA\u02B4\u02BD\u02B7\u02B2\u02B9\u02BF\u02B9\u02B4\u02BE\u02BF[num].color = this.\u02C0\u02BA\u02BA\u02BC\u02B6\u02B3\u02B5\u02BB\u02B2\u02BE\u02B4;
						if ((obj as SongEntry).isAvailableOnline)
						{
							this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[num].color = this.\u02BC\u02B7\u02BB\u02B3\u02BB\u02BE\u02B5\u02B2\u02B2\u02B4\u02B5;
						}
						else
						{
							this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[num].color = Color.gray;
						}
					}
					else
					{
						this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[num].color = this.\u02B3\u02B4\u02C1\u02B4\u02BF\u02B7\u02B4\u02B9\u02B3\u02B4\u02BA;
						this.\u02BC\u02BA\u02BD\u02B2\u02BD\u02BA\u02BE\u02C1\u02C0\u02B5\u02C1[num].color = Color.white;
						this.textObjects[num].color = Color.white;
					}
				}
				else
				{
					this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[num].color = this.\u02B5\u02BB\u02C0\u02B8\u02C0\u02B8\u02BF\u02B8\u02B3\u02B9\u02C0;
					this.\u02B7\u02B7\u02B7\u02B4\u02BD\u02B6\u02C0\u02B2\u02B8\u02B3\u02B4[num].color = Color.white;
					this.\u02B9\u02BB\u02B3\u02C1\u02B2\u02C1\u02B9\u02C0\u02BF\u02BD\u02C0[num].color = Color.white;
					this.\u02BA\u02B4\u02BD\u02B7\u02B2\u02B9\u02BF\u02B9\u02B4\u02BE\u02BF[num].color = Color.white;
				}
			}
			num++;
		}
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x0006949C File Offset: 0x0006769C
	public void \u02B3\u02BE\u02B6\u02BC\u02B7\u02BD\u02BC\u02C1\u02BB\u02B4\u02B7(string \u02C1\u02BC\u02C0\u02B7\u02BE\u02B7\u02BF\u02BA\u02BD\u02BD\u02B7)
	{
		SongSelect.\u02B4\u02C0\u02C1\u02C1\u02B5\u02BA\u02C1\u02B9\u02BE\u02B5\u02BA u02B4_u02C0_u02C1_u02C1_u02B5_u02BA_u02C1_u02B9_u02BE_u02B5_u02BA = new SongSelect.\u02B4\u02C0\u02C1\u02C1\u02B5\u02BA\u02C1\u02B9\u02BE\u02B5\u02BA();
		u02B4_u02C0_u02C1_u02C1_u02B5_u02BA_u02C1_u02B9_u02BE_u02B5_u02BA.tag = \u02C1\u02BC\u02C0\u02B7\u02BE\u02B7\u02BF\u02BA\u02BD\u02BD\u02B7;
		this.\u02B2\u02B8\u02B6\u02BF\u02C0\u02C1\u02B3\u02B8\u02C0\u02B5\u02BB(new Action(u02B4_u02C0_u02C1_u02C1_u02B5_u02BA_u02C1_u02B9_u02BE_u02B5_u02BA.\u02B5\u02BA\u02B4\u02BB\u02BC\u02B3\u02BB\u02B2\u02B6\u02B5\u02B3));
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x0000C0F7 File Offset: 0x0000A2F7
	public void \u02B5\u02B6\u02BF\u02C1\u02B5\u02BD\u02BB\u02B6\u02C1\u02B7\u02C1(TextMeshProUGUI[] \u02BC\u02BA\u02BD\u02B2\u02BD\u02BA\u02BE\u02C1\u02C0\u02B5\u02C1, TextMeshProUGUI[] \u02B9\u02BB\u02B3\u02C1\u02B2\u02C1\u02B9\u02C0\u02BF\u02BD\u02C0, ScrollingText[] \u02B6\u02BD\u02BB\u02B5\u02B4\u02B4\u02B3\u02BF\u02BF\u02BC\u02BE, ScrollingText[] \u02BF\u02B4\u02BA\u02BE\u02B3\u02BE\u02BB\u02BA\u02B3\u02C0\u02B3, Image[] \u02B7\u02B7\u02B7\u02B4\u02BD\u02B6\u02C0\u02B2\u02B8\u02B3\u02B4, TextMeshProUGUI[] \u02BA\u02B4\u02BD\u02B7\u02B2\u02B9\u02BF\u02B9\u02B4\u02BE\u02BF, Image[] \u02BD\u02BD\u02C0\u02BE\u02B3\u02C0\u02B7\u02BE\u02BB\u02BF\u02BB)
	{
		this.\u02BC\u02BA\u02BD\u02B2\u02BD\u02BA\u02BE\u02C1\u02C0\u02B5\u02C1 = \u02BC\u02BA\u02BD\u02B2\u02BD\u02BA\u02BE\u02C1\u02C0\u02B5\u02C1;
		this.\u02B9\u02BB\u02B3\u02C1\u02B2\u02C1\u02B9\u02C0\u02BF\u02BD\u02C0 = \u02B9\u02BB\u02B3\u02C1\u02B2\u02C1\u02B9\u02C0\u02BF\u02BD\u02C0;
		this.\u02B7\u02B7\u02B7\u02B4\u02BD\u02B6\u02C0\u02B2\u02B8\u02B3\u02B4 = \u02B7\u02B7\u02B7\u02B4\u02BD\u02B6\u02C0\u02B2\u02B8\u02B3\u02B4;
		this.\u02BA\u02B4\u02BD\u02B7\u02B2\u02B9\u02BF\u02B9\u02B4\u02BE\u02BF = \u02BA\u02B4\u02BD\u02B7\u02B2\u02B9\u02BF\u02B9\u02B4\u02BE\u02BF;
		this.\u02B6\u02BD\u02BB\u02B5\u02B4\u02B4\u02B3\u02BF\u02BF\u02BC\u02BE = \u02B6\u02BD\u02BB\u02B5\u02B4\u02B4\u02B3\u02BF\u02BF\u02BC\u02BE;
		this.\u02BF\u02B4\u02BA\u02BE\u02B3\u02BE\u02BB\u02BA\u02B3\u02C0\u02B3 = \u02BF\u02B4\u02BA\u02BE\u02B3\u02BE\u02BB\u02BA\u02B3\u02C0\u02B3;
		this.\u02BD\u02BD\u02C0\u02BE\u02B3\u02C0\u02B7\u02BE\u02BB\u02BF\u02BB = \u02BD\u02BD\u02C0\u02BE\u02B3\u02C0\u02B7\u02BE\u02BB\u02BF\u02BB;
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x0000C0CA File Offset: 0x0000A2CA
	public void \u02BC\u02C1\u02C0\u02BE\u02BD\u02BD\u02B2\u02BB\u02B9\u02B9\u02BF(SongEntry \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD)
	{
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02B5\u02B4\u02BD\u02B7\u02B4\u02B9\u02B8\u02B8\u02B5\u02BF(\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD), true);
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x000694C8 File Offset: 0x000676C8
	private void \u02C0\u02BA\u02B4\u02C1\u02B5\u02B9\u02B6\u02C0\u02B8\u02B9\u02B9()
	{
		this.difficultyScroll.\u02C0\u02B4\u02BA\u02B9\u02B2\u02BD\u02B9\u02BD\u02B4\u02B8\u02BA();
		for (int i = 1; i < this.difficultyIcons.Length; i++)
		{
			this.difficultyIcons[i].gameObject.SetActive(true);
			int num = (int)this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(this.difficultyIcons[i].\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
			if (this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.charts.\u02B9\u02BB\u02C1\u02BF\u02BA\u02BB\u02B8\u02BA\u02B5\u02B5\u02B9(this.difficultyIcons[i].\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF))
			{
				this.difficultyIcons[i].gameObject.SetActive(true);
				Instrument u02B7_u02BB_u02BA_u02BC_u02B4_u02B6_u02B4_u02B3_u02BD_u02BA_u02BF = this.difficultyIcons[i].\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF;
				Instrument? instrument = this.\u02C0\u02BE\u02B5\u02B2\u02B7\u02B7\u02C0\u02BD\u02BA\u02B3\u02BB;
				if ((u02B7_u02BB_u02BA_u02BC_u02B4_u02B6_u02B4_u02B3_u02BD_u02BA_u02BF == instrument.GetValueOrDefault()) & (instrument != null))
				{
					this.difficultyIcons[i].\u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC(num, false, false);
				}
				else
				{
					this.difficultyIcons[i].\u02B3\u02BB\u02B3\u02B8\u02B2\u02B8\u02B8\u02B6\u02BA\u02B7\u02BE(num, false, false);
				}
			}
		}
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x0000C134 File Offset: 0x0000A334
	public void \u02BD\u02B6\u02C0\u02BC\u02BA\u02BA\u02B4\u02BE\u02C1\u02B8\u02BB()
	{
		this.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(null);
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x0000C13D File Offset: 0x0000A33D
	public override void \u02BF\u02BB\u02BC\u02BC\u02B8\u02C1\u02B9\u02BC\u02B6\u02BA\u02B6()
	{
		if (this.\u02B9\u02B4\u02BE\u02B3\u02B5\u02BD\u02BB\u02BD\u02BC\u02B2\u02C0)
		{
			this.\u02B9\u02B4\u02BE\u02B3\u02B5\u02BD\u02BB\u02BD\u02BC\u02B2\u02C0 = false;
			return;
		}
		this.\u02BD\u02B6\u02C0\u02BC\u02BA\u02BA\u02B4\u02BE\u02C1\u02B8\u02BB();
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x000695A0 File Offset: 0x000677A0
	public override void \u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2()
	{
		int num = 0;
		while (num < this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2.Length && this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[num].enabled)
		{
			if (!(this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[num].color == (BlackMenu.\u02C1\u02B5\u02C0\u02B2\u02BD\u02B6\u02BF\u02B2\u02BA\u02B4\u02BE() ? this.\u02B9\u02B9\u02C1\u02BA\u02BD\u02B7\u02B2\u02B4\u02B4\u02BB\u02BA : this.\u02BA\u02B5\u02BA\u02B2\u02B5\u02B4\u02B3\u02B9\u02BB\u02B7\u02BE)) || num == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3)
			{
				if (num == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3)
				{
					object obj = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BE\u02BF\u02B3\u02C1\u02B3\u02BF\u02BE\u02B3\u02B7(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
					if (obj is SongEntry)
					{
						this.\u02BC\u02BA\u02BD\u02B2\u02BD\u02BA\u02BE\u02C1\u02C0\u02B5\u02C1[num].color = this.\u02C0\u02BA\u02BA\u02BC\u02B6\u02B3\u02B5\u02BB\u02B2\u02BE\u02B4;
						this.textObjects[num].color = this.\u02C0\u02BA\u02BA\u02BC\u02B6\u02B3\u02B5\u02BB\u02B2\u02BE\u02B4;
						this.\u02B7\u02B7\u02B7\u02B4\u02BD\u02B6\u02C0\u02B2\u02B8\u02B3\u02B4[num].color = this.\u02C0\u02BA\u02BA\u02BC\u02B6\u02B3\u02B5\u02BB\u02B2\u02BE\u02B4;
						this.\u02B9\u02BB\u02B3\u02C1\u02B2\u02C1\u02B9\u02C0\u02BF\u02BD\u02C0[num].color = this.\u02C0\u02BA\u02BA\u02BC\u02B6\u02B3\u02B5\u02BB\u02B2\u02BE\u02B4;
						this.\u02BA\u02B4\u02BD\u02B7\u02B2\u02B9\u02BF\u02B9\u02B4\u02BE\u02BF[num].color = this.\u02C0\u02BA\u02BA\u02BC\u02B6\u02B3\u02B5\u02BB\u02B2\u02BE\u02B4;
						if ((obj as SongEntry).isAvailableOnline)
						{
							this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[num].color = this.\u02BC\u02B7\u02BB\u02B3\u02BB\u02BE\u02B5\u02B2\u02B2\u02B4\u02B5;
						}
						else
						{
							this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[num].color = Color.gray;
						}
					}
					else
					{
						this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[num].color = this.\u02B3\u02B4\u02C1\u02B4\u02BF\u02B7\u02B4\u02B9\u02B3\u02B4\u02BA;
						this.\u02BC\u02BA\u02BD\u02B2\u02BD\u02BA\u02BE\u02C1\u02C0\u02B5\u02C1[num].color = Color.white;
						this.textObjects[num].color = Color.white;
					}
				}
				else
				{
					this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[num].color = this.\u02B5\u02BB\u02C0\u02B8\u02C0\u02B8\u02BF\u02B8\u02B3\u02B9\u02C0;
					this.\u02B7\u02B7\u02B7\u02B4\u02BD\u02B6\u02C0\u02B2\u02B8\u02B3\u02B4[num].color = Color.white;
					this.\u02B9\u02BB\u02B3\u02C1\u02B2\u02C1\u02B9\u02C0\u02BF\u02BD\u02C0[num].color = Color.white;
					this.\u02BA\u02B4\u02BD\u02B7\u02B2\u02B9\u02BF\u02B9\u02B4\u02BE\u02BF[num].color = Color.white;
				}
			}
			num++;
		}
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x0006977C File Offset: 0x0006797C
	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			(\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B7\u02B3\u02B2\u02BD\u02B4\u02BC\u02C1\u02B8\u02C0\u02BA as \u02B8\u02B4\u02B4\u02BE\u02B5\u02B6\u02B7\u02B7\u02BC\u02B5\u02B7).\u02C1\u02B5\u02BB\u02B9\u02B3\u02BE\u02B4\u02B7\u02B9\u02B8\u02BE(false);
			return;
		}
		if (this.setlistMenu.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB)
		{
			this.setlistMenu.\u02BB\u02B2\u02BD\u02BE\u02B9\u02B2\u02B9\u02B5\u02BF\u02BA\u02B3();
		}
		else
		{
			DiscordController.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02B2\u02BB\u02C1\u02B5\u02B9\u02B8\u02B5\u02B8\u02BA\u02B5();
			BassAudioManager.Instance.\u02B6\u02BC\u02BC\u02B7\u02BD\u02B7\u02BA\u02BE\u02BA\u02C1\u02BB();
			this.mainMenu.SetActive(true);
			base.gameObject.SetActive(false);
			this.setlistMenu.\u02BC\u02B2\u02BD\u02B7\u02BA\u02BF\u02C0\u02BE\u02B4\u02BE\u02B9(true);
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02C1\u02BF\u02BD\u02B5\u02BE\u02C1\u02BE\u02B8\u02BF\u02B7 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BE\u02BF\u02B3\u02C1\u02B3\u02BF\u02BE\u02B3\u02B7(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x0000C155 File Offset: 0x0000A355
	private void Awake()
	{
		this.\u02B9\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02C0\u02B5\u02BF\u02BB = true;
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x0000C15E File Offset: 0x0000A35E
	public void \u02B6\u02B3\u02B4\u02B6\u02C1\u02B4\u02C0\u02BA\u02BA\u02C1\u02C0(bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
	{
		this.sectionBrowser.gameObject.SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x0000C171 File Offset: 0x0000A371
	public override void \u02BA\u02C0\u02C1\u02B2\u02B2\u02B9\u02B2\u02BF\u02B8\u02BE\u02BC()
	{
		this.\u02BA\u02C1\u02B4\u02BB\u02BC\u02BF\u02BF\u02C1\u02B3\u02C0\u02B3(false);
	}

	// Token: 0x06000BE3 RID: 3043 RVA: 0x0000C17A File Offset: 0x0000A37A
	public override void \u02BC\u02B7\u02BF\u02BD\u02B4\u02BE\u02C0\u02B4\u02BE\u02B7\u02B9()
	{
		this.songOptions.gameObject.SetActive(true);
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x0006949C File Offset: 0x0006769C
	public void \u02B6\u02BD\u02C1\u02B8\u02C1\u02B6\u02B6\u02BA\u02B3\u02BE\u02B8(string \u02C1\u02BC\u02C0\u02B7\u02BE\u02B7\u02BF\u02BA\u02BD\u02BD\u02B7)
	{
		SongSelect.\u02B4\u02C0\u02C1\u02C1\u02B5\u02BA\u02C1\u02B9\u02BE\u02B5\u02BA u02B4_u02C0_u02C1_u02C1_u02B5_u02BA_u02C1_u02B9_u02BE_u02B5_u02BA = new SongSelect.\u02B4\u02C0\u02C1\u02C1\u02B5\u02BA\u02C1\u02B9\u02BE\u02B5\u02BA();
		u02B4_u02C0_u02C1_u02C1_u02B5_u02BA_u02C1_u02B9_u02BE_u02B5_u02BA.tag = \u02C1\u02BC\u02C0\u02B7\u02BE\u02B7\u02BF\u02BA\u02BD\u02BD\u02B7;
		this.\u02B2\u02B8\u02B6\u02BF\u02C0\u02C1\u02B3\u02B8\u02C0\u02B5\u02BB(new Action(u02B4_u02C0_u02C1_u02C1_u02B5_u02BA_u02C1_u02B9_u02BE_u02B5_u02BA.\u02B5\u02BA\u02B4\u02BB\u02BC\u02B3\u02BB\u02B2\u02B6\u02B5\u02B3));
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x0000C193 File Offset: 0x0000A393
	private IEnumerator \u02C1\u02BC\u02B8\u02BA\u02B4\u02C1\u02B3\u02C1\u02B6\u02B4\u02B7()
	{
		SongSelect.\u02B2\u02B4\u02B5\u02BD\u02BA\u02B6\u02BE\u02B2\u02B2\u02BE\u02B9 u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B = new SongSelect.\u02B2\u02B4\u02B5\u02BD\u02BA\u02B6\u02BE\u02B2\u02B2\u02BE\u02B9();
		u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.<>4__this = this;
		this.loadImage.gameObject.SetActive(false);
		if (this.\u02BB\u02B6\u02B8\u02BA\u02BB\u02BB\u02B3\u02B9\u02BE\u02C0\u02C1 == null)
		{
			this.\u02BB\u02B6\u02B8\u02BA\u02BB\u02BB\u02B3\u02B9\u02BE\u02C0\u02C1 = new Texture2D(512, 512, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None);
			this.\u02BB\u02B6\u02B8\u02BA\u02BB\u02BB\u02B3\u02B9\u02BE\u02C0\u02C1.wrapMode = TextureWrapMode.Clamp;
		}
		SongEntry song = this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD;
		u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.albumArt = this.\u02B7\u02B7\u02BB\u02BB\u02B4\u02B7\u02B5\u02B5\u02BF\u02B9\u02B9();
		if ((u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.albumArt == null && !this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.isEnc) || (this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.isEnc && !this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.songEnc.\u02B4\u02B2\u02BC\u02B9\u02B4\u02B6\u02B7\u02BE\u02BA\u02B4\u02B9(\u02BC\u02C0\u02BC\u02BC\u02BD\u02B3\u02C0\u02B6\u02BA\u02B5\u02C0.ALBUM_ART)))
		{
			this.albumImage.texture = this.defaultAlbumArt.texture;
			this.albumImage.enabled = true;
			yield break;
		}
		while (!SongSelect.\u02BA\u02BE\u02BF\u02BE\u02BC\u02BF\u02BB\u02BE\u02B9\u02BA\u02B4(this.\u02B3\u02B3\u02B6\u02B4\u02BE\u02BA\u02BC\u02B6\u02BC\u02BC\u02BD))
		{
			yield return null;
		}
		if (song != this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD)
		{
			yield break;
		}
		u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.nativeTextureData = this.\u02BB\u02B6\u02B8\u02BA\u02BB\u02BB\u02B3\u02B9\u02BE\u02C0\u02C1.GetRawTextureData<Color32>();
		u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.state = SongSelect.\u02B4\u02B5\u02BA\u02C0\u02BA\u02B3\u02B9\u02C1\u02B8\u02BE\u02BE.Loading;
		this.\u02B3\u02B3\u02B6\u02B4\u02BE\u02BA\u02BC\u02B6\u02BC\u02BC\u02BD = Task.Run(new Action(u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.\u02B9\u02BD\u02BB\u02BA\u02BA\u02C0\u02B4\u02C0\u02BF\u02B8\u02B2));
		while (u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.state == SongSelect.\u02B4\u02B5\u02BA\u02C0\u02BA\u02B3\u02B9\u02C1\u02B8\u02BE\u02BE.Loading)
		{
			yield return null;
		}
		if (u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.state == SongSelect.\u02B4\u02B5\u02BA\u02C0\u02BA\u02B3\u02B9\u02C1\u02B8\u02BE\u02BE.Loaded)
		{
			if (song != this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD)
			{
				yield break;
			}
			this.\u02BB\u02B6\u02B8\u02BA\u02BB\u02BB\u02B3\u02B9\u02BE\u02C0\u02C1.Apply();
			this.albumImage.texture = this.\u02BB\u02B6\u02B8\u02BA\u02BB\u02BB\u02B3\u02B9\u02BE\u02C0\u02C1;
			this.albumImage.enabled = true;
		}
		else
		{
			this.albumImage.texture = this.defaultAlbumArt.texture;
			this.albumImage.enabled = true;
		}
		while (!this.\u02B3\u02B3\u02B6\u02B4\u02BE\u02BA\u02BC\u02B6\u02BC\u02BC\u02BD.Wait(0))
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x00069818 File Offset: 0x00067A18
	private void \u02BA\u02B7\u02B9\u02B9\u02BD\u02BD\u02BE\u02B9\u02BF\u02BC\u02C0()
	{
		this.difficultyScroll.Reset();
		for (int i = 0; i < this.difficultyIcons.Length; i++)
		{
			this.difficultyIcons[i].gameObject.SetActive(false);
			int num = (int)this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(this.difficultyIcons[i].\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
			if (this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.charts.\u02BF\u02BB\u02C0\u02BB\u02B2\u02B6\u02B5\u02B8\u02B8\u02B2\u02BB(this.difficultyIcons[i].\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF))
			{
				this.difficultyIcons[i].gameObject.SetActive(true);
				Instrument u02B7_u02BB_u02BA_u02BC_u02B4_u02B6_u02B4_u02B3_u02BD_u02BA_u02BF = this.difficultyIcons[i].\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF;
				Instrument? instrument = this.\u02C0\u02BE\u02B5\u02B2\u02B7\u02B7\u02C0\u02BD\u02BA\u02B3\u02BB;
				if ((u02B7_u02BB_u02BA_u02BC_u02B4_u02B6_u02B4_u02B3_u02BD_u02BA_u02BF == instrument.GetValueOrDefault()) & (instrument != null))
				{
					this.difficultyIcons[i].\u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC(num, false, true);
				}
				else
				{
					this.difficultyIcons[i].\u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC(num, false, false);
				}
			}
		}
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x0000C1A2 File Offset: 0x0000A3A2
	public void \u02BD\u02BA\u02B2\u02C0\u02BC\u02B9\u02B7\u02B9\u02B9\u02B5\u02BF()
	{
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BA\u02B5\u02B6\u02B8\u02BD\u02BF\u02B7\u02B4\u02BF\u02B2\u02BB(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC), true);
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x000698F0 File Offset: 0x00067AF0
	[CompilerGenerated]
	internal static bool \u02BA\u02BE\u02BF\u02BE\u02BC\u02BF\u02BB\u02BE\u02B9\u02BA\u02B4(Task \u02C1\u02C1\u02B2\u02BA\u02BF\u02B6\u02BB\u02BE\u02B6\u02BC\u02B5)
	{
		try
		{
			return \u02C1\u02C1\u02B2\u02BA\u02BF\u02B6\u02BB\u02BE\u02B6\u02BC\u02B5.Wait(0);
		}
		catch
		{
		}
		return true;
	}

	// Token: 0x06000BE9 RID: 3049 RVA: 0x0000C1B6 File Offset: 0x0000A3B6
	public override void \u02B5\u02BF\u02B2\u02B4\u02BB\u02B5\u02B9\u02B4\u02BC\u02BB\u02C1()
	{
		this.\u02BF\u02BA\u02BE\u02BC\u02B4\u02C0\u02B3\u02BC\u02B6\u02B3\u02C0();
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x0000C04D File Offset: 0x0000A24D
	public void \u02B8\u02B5\u02BE\u02B7\u02B2\u02BF\u02B3\u02B3\u02BA\u02BF\u02BC()
	{
		this.songSelectSearch.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3 = true;
		this.songSelectSearch.gameObject.SetActive(true);
	}

	// Token: 0x06000BEB RID: 3051 RVA: 0x00069920 File Offset: 0x00067B20
	protected override void OnEnable()
	{
		this.songCountText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Songs") + ": ";
		this.\u02B3\u02C1\u02C0\u02B2\u02B9\u02BB\u02B6\u02B6\u02B4\u02C0\u02BB();
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			TextMeshProUGUI textMeshProUGUI = this.songCountText;
			textMeshProUGUI.text += string.Format("{0}/{1}", \u02C0\u02BC\u02B6\u02BB\u02BA\u02BD\u02B5\u02BE\u02BD\u02B7\u02B9.\u02BF\u02B8\u02B6\u02BC\u02BB\u02B8\u02BF\u02BA\u02C0\u02B4\u02B7, \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BA\u02BB\u02BA\u02B4\u02B5\u02C0\u02C1\u02B2\u02B5\u02B2);
			if (!\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02BB\u02B8\u02BF\u02B2\u02B7\u02B2\u02B2\u02B8\u02B4\u02B2("Available"))
			{
				this.\u02B7\u02C1\u02BA\u02B9\u02BB\u02B7\u02B2\u02B6\u02C0\u02B6\u02BA("Available");
			}
		}
		else
		{
			TextMeshProUGUI textMeshProUGUI2 = this.songCountText;
			textMeshProUGUI2.text += string.Format("{0}", \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BA\u02BB\u02BA\u02B4\u02B5\u02C0\u02C1\u02B2\u02B5\u02B2);
		}
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.setlistMenu.\u02B2\u02B8\u02BC\u02BB\u02B4\u02BE\u02BD\u02C1\u02B2\u02B6\u02B9();
			this.setlistMenu.\u02B7\u02BF\u02B8\u02BF\u02B8\u02BF\u02B4\u02B2\u02BC\u02B4\u02BE();
		}
		this.\u02B6\u02B5\u02B7\u02BD\u02B4\u02BA\u02B6\u02B9\u02B2\u02B3\u02B4 = -1;
		if (this.\u02B4\u02C1\u02B6\u02B5\u02B4\u02B7\u02BC\u02BE\u02C1\u02B6\u02B6)
		{
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			return;
		}
		this.\u02BE\u02C0\u02BF\u02B7\u02B3\u02BC\u02C1\u02B6\u02B7\u02B4\u02B4.\u02B7\u02C0\u02B7\u02B8\u02C0\u02B5\u02C0\u02C0\u02C1\u02BD\u02B3();
		this.\u02BE\u02C0\u02BF\u02B7\u02B3\u02BC\u02C1\u02B6\u02B7\u02B4\u02B4.\u02BA\u02B5\u02B3\u02BD\u02C1\u02BA\u02C1\u02B8\u02BB\u02B3\u02BD();
		base.OnEnable();
		this.\u02B4\u02C1\u02B6\u02B5\u02B4\u02B7\u02BC\u02BE\u02C1\u02B6\u02B6 = true;
	}

	// Token: 0x06000BEC RID: 3052 RVA: 0x0000C0E8 File Offset: 0x0000A2E8
	private IEnumerator \u02BF\u02B7\u02B6\u02B8\u02BF\u02BE\u02B7\u02B5\u02BF\u02BE\u02BA()
	{
		BassAudioManager.Instance.\u02C1\u02B3\u02B2\u02BB\u02B7\u02B8\u02BD\u02BC\u02BF\u02BC\u02C0(null);
		if (this.\u02B5\u02C0\u02B4\u02B7\u02BB\u02BB\u02BD\u02B2\u02B4\u02BF\u02BE != null)
		{
			base.StopCoroutine(this.\u02B5\u02C0\u02B4\u02B7\u02BB\u02BB\u02BD\u02B2\u02B4\u02BF\u02BE);
		}
		DiscordController.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BF\u02B5\u02C1\u02B7\u02C1\u02B5\u02B6\u02BC\u02C0\u02B3(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD);
		yield return new WaitForSecondsRealtime(0.5f);
		if (SettingsController.\u02B8\u02B7\u02BF\u02B4\u02B3\u02BB\u02B6\u02BB\u02B7\u02B2\u02BD.GetCurrentVolume > 0)
		{
			BassAudioManager.Instance.\u02B2\u02B9\u02BA\u02BA\u02B3\u02B8\u02B4\u02B5\u02BE\u02B7\u02BB(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD);
			this.\u02B5\u02C0\u02B4\u02B7\u02BB\u02BB\u02BD\u02B2\u02B4\u02BF\u02BE = base.StartCoroutine(this.\u02C1\u02BE\u02B7\u02B8\u02B9\u02B2\u02B7\u02BA\u02BC\u02BC\u02BF());
		}
		yield return null;
		yield break;
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x00069A38 File Offset: 0x00067C38
	protected virtual void \u02B7\u02B8\u02BD\u02C0\u02B2\u02B4\u02B7\u02C0\u02BC\u02BE\u02B3()
	{
		int num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BB\u02B3\u02B7\u02BB\u02B3\u02C1\u02B9\u02BF\u02C0\u02BF(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02C1\u02BF\u02BD\u02B5\u02BE\u02C1\u02BE\u02B8\u02BF\u02B7);
		this.\u02BE\u02C0\u02BF\u02B7\u02B3\u02BC\u02C1\u02B6\u02B7\u02B4\u02B4.\u02C1\u02BD\u02B6\u02B7\u02BA\u02BF\u02B5\u02BD\u02BD\u02B4\u02B7();
		if (num == 0)
		{
			base.Start();
		}
		else
		{
			this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(num, true);
		}
		DiscordController.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B4\u02B9\u02B2\u02B4\u02BE\u02BC\u02BE\u02C0\u02C1\u02C1(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD);
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x0000C1BE File Offset: 0x0000A3BE
	public override void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		if (!\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02BD\u02C1\u02C0\u02B4\u02B7\u02BE\u02BF\u02BD\u02B7\u02B7)
		{
			return;
		}
		this.\u02B7\u02B6\u02B2\u02BD\u02C0\u02B4\u02B2\u02B4\u02BC\u02C1\u02BF();
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
	public void \u02B7\u02BE\u02B8\u02B7\u02B9\u02BA\u02B3\u02B6\u02B4\u02B7\u02B8()
	{
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count == 0)
		{
			return;
		}
		this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = 0;
		this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = 1;
		this.\u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2();
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x0000C1FD File Offset: 0x0000A3FD
	private void \u02B7\u02B6\u02B2\u02BD\u02C0\u02B4\u02B2\u02B4\u02BC\u02C1\u02BF()
	{
		if (this.setlistMenu.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB)
		{
			this.setlistMenu.\u02BC\u02B2\u02BD\u02B7\u02BA\u02BF\u02C0\u02BE\u02B4\u02BE\u02B9(false);
		}
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x0000C218 File Offset: 0x0000A418
	public void \u02BF\u02B5\u02BE\u02BD\u02B8\u02BF\u02B4\u02B6\u02BB\u02B6\u02BD()
	{
		this.\u02B2\u02B8\u02B6\u02BF\u02C0\u02C1\u02B3\u02B8\u02C0\u02B5\u02BB(new Action(SongSelect.<>c.<>9.\u02BB\u02BF\u02BB\u02C1\u02B8\u02B8\u02BB\u02C0\u02BE\u02B9\u02BE));
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x0000C23F File Offset: 0x0000A43F
	public void \u02C0\u02C0\u02BA\u02BD\u02B8\u02B7\u02B8\u02B5\u02C1\u02B2\u02B9(bool \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5)
	{
		this.sectionBrowser.\u02BF\u02BB\u02B6\u02C0\u02B8\u02BE\u02B9\u02B4\u02C1\u02B5\u02BD(\u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5);
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x00069B58 File Offset: 0x00067D58
	public void \u02BD\u02B7\u02B2\u02BE\u02B7\u02BD\u02C1\u02BE\u02C1\u02B9\u02B7()
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02B7\u02BE\u02BF\u02B4\u02C1\u02BC\u02B2\u02BC\u02B8\u02B4 = SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.CurrentValue;
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02C1\u02BF\u02BD\u02B5\u02BE\u02C1\u02BE\u02B8\u02BF\u02B7 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BE\u02BF\u02B3\u02C1\u02B3\u02BF\u02BE\u02B3\u02B7(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		if (this.setlistMenu.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB)
		{
			this.setlistMenu.gameObject.SetActive(false);
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD[0];
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6 = true;
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7 = 0;
		}
		else
		{
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6 = false;
			GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1 = (SongEntry)GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02C1\u02BF\u02BD\u02B5\u02BE\u02C1\u02BE\u02B8\u02BF\u02B7;
		}
		BassAudioManager.Instance.\u02B6\u02BC\u02BC\u02B7\u02BD\u02B7\u02BA\u02BE\u02BA\u02C1\u02BB();
		this.playerSelection.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x0000C193 File Offset: 0x0000A393
	private IEnumerator \u02B2\u02C1\u02BD\u02B2\u02BE\u02B9\u02B7\u02B2\u02BA\u02C0\u02B5()
	{
		u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B = new SongSelect.\u02B2\u02B4\u02B5\u02BD\u02BA\u02B6\u02BE\u02B2\u02B2\u02BE\u02B9();
		u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.<>4__this = this;
		this.loadImage.gameObject.SetActive(false);
		if (this.\u02BB\u02B6\u02B8\u02BA\u02BB\u02BB\u02B3\u02B9\u02BE\u02C0\u02C1 == null)
		{
			this.\u02BB\u02B6\u02B8\u02BA\u02BB\u02BB\u02B3\u02B9\u02BE\u02C0\u02C1 = new Texture2D(512, 512, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None);
			this.\u02BB\u02B6\u02B8\u02BA\u02BB\u02BB\u02B3\u02B9\u02BE\u02C0\u02C1.wrapMode = TextureWrapMode.Clamp;
		}
		song = this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD;
		u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.albumArt = this.\u02B7\u02B7\u02BB\u02BB\u02B4\u02B7\u02B5\u02B5\u02BF\u02B9\u02B9();
		if ((u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.albumArt == null && !this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.isEnc) || (this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.isEnc && !this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.songEnc.\u02B4\u02B2\u02BC\u02B9\u02B4\u02B6\u02B7\u02BE\u02BA\u02B4\u02B9(\u02BC\u02C0\u02BC\u02BC\u02BD\u02B3\u02C0\u02B6\u02BA\u02B5\u02C0.ALBUM_ART)))
		{
			this.albumImage.texture = this.defaultAlbumArt.texture;
			this.albumImage.enabled = true;
			yield break;
		}
		while (!SongSelect.\u02BA\u02BE\u02BF\u02BE\u02BC\u02BF\u02BB\u02BE\u02B9\u02BA\u02B4(this.\u02B3\u02B3\u02B6\u02B4\u02BE\u02BA\u02BC\u02B6\u02BC\u02BC\u02BD))
		{
			yield return null;
		}
		if (song != this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD)
		{
			yield break;
		}
		u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.nativeTextureData = this.\u02BB\u02B6\u02B8\u02BA\u02BB\u02BB\u02B3\u02B9\u02BE\u02C0\u02C1.GetRawTextureData<Color32>();
		u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.state = SongSelect.\u02B4\u02B5\u02BA\u02C0\u02BA\u02B3\u02B9\u02C1\u02B8\u02BE\u02BE.Loading;
		this.\u02B3\u02B3\u02B6\u02B4\u02BE\u02BA\u02BC\u02B6\u02BC\u02BC\u02BD = Task.Run(new Action(u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.\u02B9\u02BD\u02BB\u02BA\u02BA\u02C0\u02B4\u02C0\u02BF\u02B8\u02B2));
		while (u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.state == SongSelect.\u02B4\u02B5\u02BA\u02C0\u02BA\u02B3\u02B9\u02C1\u02B8\u02BE\u02BE.Loading)
		{
			yield return null;
		}
		if (u02B2_u02B4_u02B5_u02BD_u02BA_u02B6_u02BE_u02B2_u02B2_u02BE_u02B.state == SongSelect.\u02B4\u02B5\u02BA\u02C0\u02BA\u02B3\u02B9\u02C1\u02B8\u02BE\u02BE.Loaded)
		{
			if (song != this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD)
			{
				yield break;
			}
			this.\u02BB\u02B6\u02B8\u02BA\u02BB\u02BB\u02B3\u02B9\u02BE\u02C0\u02C1.Apply();
			this.albumImage.texture = this.\u02BB\u02B6\u02B8\u02BA\u02BB\u02BB\u02B3\u02B9\u02BE\u02C0\u02C1;
			this.albumImage.enabled = true;
		}
		else
		{
			this.albumImage.texture = this.defaultAlbumArt.texture;
			this.albumImage.enabled = true;
		}
		while (!this.\u02B3\u02B3\u02B6\u02B4\u02BE\u02BA\u02BC\u02B6\u02BC\u02BC\u02BD.Wait(0))
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x0000C24D File Offset: 0x0000A44D
	public override void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		if (!\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02BD\u02C1\u02C0\u02B4\u02B7\u02BE\u02BF\u02BD\u02B7\u02B7)
		{
			return;
		}
		this.\u02B7\u02B6\u02B2\u02BD\u02C0\u02B4\u02B2\u02B4\u02BC\u02C1\u02BF();
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x06000BFE RID: 3070 RVA: 0x0000C29F File Offset: 0x0000A49F
	// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x0000C263 File Offset: 0x0000A463
	public Instrument? \u02C0\u02BE\u02B5\u02B2\u02B7\u02B7\u02C0\u02BD\u02BA\u02B3\u02BB
	{
		get
		{
			return this.\u02BD\u02B6\u02B8\u02C1\u02B3\u02BE\u02B7\u02BA\u02B4\u02BF\u02C0;
		}
		set
		{
			this.\u02BD\u02B6\u02B8\u02C1\u02B3\u02BE\u02B7\u02BA\u02B4\u02BF\u02C0 = value;
			this.\u02B6\u02B5\u02B7\u02BD\u02B4\u02BA\u02B6\u02B9\u02B2\u02B3\u02B4 = -1;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		}
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x00069C20 File Offset: 0x00067E20
	public void \u02BF\u02BA\u02BE\u02BC\u02B4\u02C0\u02B3\u02BC\u02B6\u02B3\u02C0()
	{
		Instrument instrument = this.\u02C0\u02BE\u02B5\u02B2\u02B7\u02B7\u02C0\u02BD\u02BA\u02B3\u02BB ?? GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE();
		this.scorePanel.gameObject.SetActive(true);
		this.scorePanel.\u02B9\u02BF\u02BF\u02B8\u02B4\u02B8\u02BA\u02B8\u02B9\u02B6\u02BC(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD, this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.scores.\u02BC\u02BB\u02B9\u02B5\u02B5\u02BB\u02B8\u02B9\u02B9\u02BC\u02BC(instrument), instrument);
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x00069C88 File Offset: 0x00067E88
	private void \u02BD\u02B6\u02BF\u02BF\u02B4\u02BB\u02B2\u02BD\u02BE\u02B8\u02C1()
	{
		Instrument instrument = this.\u02C0\u02BE\u02B5\u02B2\u02B7\u02B7\u02C0\u02BD\u02BA\u02B3\u02BB ?? GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE();
		\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC u02C0_u02B5_u02B3_u02B2_u02BA_u02BD_u02B5_u02C1_u02B9_u02BA_u02BC = this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.scores.\u02BC\u02BB\u02B9\u02B5\u02B5\u02BB\u02B8\u02B9\u02B9\u02BC\u02BC(instrument);
		this.\u02B5\u02B2\u02C0\u02B3\u02B2\u02BC\u02B3\u02B4\u02BC\u02B4\u02C1.text = u02C0_u02B5_u02B3_u02B2_u02BA_u02BD_u02B5_u02C1_u02B9_u02BA_u02BC.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.ToString();
		string text = \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02B5\u02BE\u02BE\u02B7\u02BB\u02BC\u02B3\u02B4\u02BA\u02B3\u02B2((Modifier)u02C0_u02B5_u02B3_u02B2_u02BA_u02BD_u02B5_u02C1_u02B9_u02BA_u02BC.\u02B8\u02BC\u02BA\u02BA\u02BC\u02C1\u02B8\u02BB\u02B7\u02C1\u02C0, instrument);
		this.\u02B8\u02BC\u02BA\u02BA\u02BC\u02C1\u02B8\u02BB\u02B7\u02C1\u02C0.text = u02C0_u02B5_u02B3_u02B2_u02BA_u02BD_u02B5_u02C1_u02B9_u02BA_u02BC.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.ToString() + "% + " + text;
		this.artistNameText.text = this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.albumNameText.text = this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.Album.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.yearText.text = this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.Year.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.genreText.text = this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.Genre.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.charterNameText.text = this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.Charter.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
		this.songLengthText.text = this.\u02C0\u02B8\u02B3\u02C0\u02BC\u02C1\u02BA\u02C0\u02BF\u02BB\u02B4(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.songLength);
		if (u02C0_u02B5_u02B3_u02B2_u02BA_u02BD_u02B5_u02C1_u02B9_u02BA_u02BC.\u02BB\u02C1\u02B6\u02BB\u02B2\u02B4\u02BD\u02BB\u02B7\u02B5\u02B9)
		{
			this.\u02B5\u02B2\u02C0\u02B3\u02B2\u02BC\u02B3\u02B4\u02BC\u02B4\u02C1.enabled = true;
			this.\u02B8\u02BC\u02BA\u02BA\u02BC\u02C1\u02B8\u02BB\u02B7\u02C1\u02C0.enabled = true;
			this.\u02B5\u02C1\u02BA\u02B3\u02B2\u02BE\u02C0\u02B6\u02B5\u02BB\u02B6.enabled = false;
			this.starsBackground.SetActive(true);
			this.starsContainer.SetActive(true);
			return;
		}
		this.\u02B5\u02B2\u02C0\u02B3\u02B2\u02BC\u02B3\u02B4\u02BC\u02B4\u02C1.enabled = false;
		this.\u02B8\u02BC\u02BA\u02BA\u02BC\u02C1\u02B8\u02BB\u02B7\u02C1\u02C0.enabled = false;
		this.\u02B5\u02C1\u02BA\u02B3\u02B2\u02BE\u02C0\u02B6\u02B5\u02BB\u02B6.enabled = true;
		this.starsBackground.SetActive(false);
		this.starsContainer.SetActive(false);
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x0000C279 File Offset: 0x0000A479
	public virtual void \u02B4\u02B9\u02BA\u02BF\u02B7\u02B6\u02BE\u02B5\u02BA\u02B8\u02B9()
	{
		if (this.\u02B9\u02B4\u02BE\u02B3\u02B5\u02BD\u02BB\u02BD\u02BC\u02B2\u02C0)
		{
			this.\u02B9\u02B4\u02BE\u02B3\u02B5\u02BD\u02BB\u02BD\u02BC\u02B2\u02C0 = true;
			return;
		}
		this.\u02BD\u02B6\u02C0\u02BC\u02BA\u02BA\u02B4\u02BE\u02C1\u02B8\u02BB();
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x00069E38 File Offset: 0x00068038
	protected override void \u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8()
	{
		int num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02BC\u02BF\u02B6\u02B5\u02BF\u02B6\u02B2\u02B6\u02BE\u02B4(this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7, 0);
		\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8 u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B = null;
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6.Count > 0)
		{
			u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6[num];
		}
		Instrument instrument = this.\u02C0\u02BE\u02B5\u02B2\u02B7\u02B7\u02C0\u02BD\u02BA\u02B3\u02BB ?? GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE();
		for (int i = 0; i < this.textObjects.Length; i++)
		{
			TextMeshProUGUI textMeshProUGUI = this.textObjects[i];
			TextMeshProUGUI textMeshProUGUI2 = this.\u02BC\u02BA\u02BD\u02B2\u02BD\u02BA\u02BE\u02C1\u02C0\u02B5\u02C1[i];
			textMeshProUGUI.color = Color.white;
			textMeshProUGUI2.color = Color.white;
			int num2 = i + this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
			if (num2 >= \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BB\u02BF\u02BB\u02C0\u02B7\u02B3\u02BC\u02BC\u02B8\u02B2\u02B6)
			{
				this.\u02B6\u02BD\u02BB\u02B5\u02B4\u02B4\u02B3\u02BF\u02BF\u02BC\u02BE[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6("", true);
				this.\u02BF\u02B4\u02BA\u02BE\u02B3\u02BE\u02BB\u02BA\u02B3\u02C0\u02B3[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6("", true);
				this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[i].enabled = false;
				this.\u02C0\u02B7\u02BA\u02BF\u02BB\u02B6\u02B6\u02B4\u02B6\u02BD\u02B6[i].\u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7();
				this.\u02BD\u02BD\u02C0\u02BE\u02B3\u02C0\u02B7\u02BE\u02BB\u02BF\u02BB[i].enabled = false;
			}
			else
			{
				this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[i].enabled = true;
				if (i < this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
				{
					if (num2 > u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02BB\u02BD\u02B2\u02BE\u02B2\u02B8\u02B2\u02B4\u02B4\u02B3\u02C1 && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6.Count > num + 1)
					{
						u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6[++num];
					}
					if (num2 == u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B7\u02BD\u02B4\u02C0\u02B9\u02B3\u02BA\u02B7\u02B2\u02BE\u02B3 || (i == 0 && num2 > u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B7\u02BD\u02B4\u02C0\u02B9\u02B3\u02BA\u02B7\u02B2\u02BE\u02B3))
					{
						this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[i].sprite = this.\u02B3\u02B9\u02BD\u02BE\u02B8\u02BF\u02B3\u02B3\u02B3\u02BC\u02C0;
						this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[i].color = (BlackMenu.\u02C1\u02B5\u02C0\u02B2\u02BD\u02B6\u02BF\u02B2\u02BA\u02B4\u02BE() ? this.\u02B9\u02B9\u02C1\u02BA\u02BD\u02B7\u02B2\u02B4\u02B4\u02BB\u02BA : this.\u02BA\u02B5\u02BA\u02B2\u02B5\u02B4\u02B3\u02B9\u02BB\u02B7\u02BE);
						this.\u02B6\u02BD\u02BB\u02B5\u02B4\u02B4\u02B3\u02BF\u02BF\u02BC\u02BE[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6("<uppercase><b>" + u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD + "</b></uppercase>", i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3);
						this.\u02BF\u02B4\u02BA\u02BE\u02B3\u02BE\u02BB\u02BA\u02B3\u02C0\u02B3[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6("<b>" + this.\u02BF\u02B3\u02BE\u02B5\u02B2\u02BA\u02B9\u02B9\u02C1\u02B7\u02BB(u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count) + "</b>", i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3);
						this.\u02C0\u02B7\u02BA\u02BF\u02BB\u02B6\u02B6\u02B4\u02B6\u02BD\u02B6[i].\u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7();
						this.\u02BD\u02BD\u02C0\u02BE\u02B3\u02C0\u02B7\u02BE\u02BB\u02BF\u02BB[i].enabled = true;
						this.\u02BD\u02BD\u02C0\u02BE\u02B3\u02C0\u02B7\u02BE\u02BB\u02BF\u02BB[i].rectTransform.rotation = Quaternion.Euler(0f, 0f, (float)(u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE ? 90 : 0));
						this.\u02BD\u02BD\u02C0\u02BE\u02B3\u02C0\u02B7\u02BE\u02BB\u02BF\u02BB[i].color = ((i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3) ? this.\u02BD\u02C1\u02B8\u02BE\u02B8\u02B2\u02B4\u02B2\u02BB\u02B8\u02B8 : Color.white);
					}
					else
					{
						this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[i].sprite = this.\u02B5\u02C1\u02B5\u02B6\u02B4\u02B8\u02BC\u02BB\u02B9\u02BF\u02B7;
						SongEntry songEntry = u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5[num2 - u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B7\u02BD\u02B4\u02C0\u02B9\u02B3\u02BA\u02B7\u02B2\u02BE\u02B3 - 1];
						this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[i].color = this.\u02B5\u02BB\u02C0\u02B8\u02C0\u02B8\u02BF\u02B8\u02B3\u02B9\u02C0;
						this.\u02B6\u02BD\u02BB\u02B5\u02B4\u02B4\u02B3\u02BF\u02BF\u02BC\u02BE[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(songEntry.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5, i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3);
						this.\u02BF\u02B4\u02BA\u02BE\u02B3\u02BE\u02BB\u02BA\u02B3\u02C0\u02B3[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6("<uppercase>" + songEntry.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5 + "</uppercase>", i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3);
						this.\u02C0\u02B7\u02BA\u02BF\u02BB\u02B6\u02B6\u02B4\u02B6\u02BD\u02B6[i].\u02BF\u02BC\u02B7\u02B2\u02B9\u02BA\u02BD\u02B6\u02C0\u02C0\u02BE(songEntry.scores.\u02BC\u02BB\u02B9\u02B5\u02B5\u02BB\u02B8\u02B9\u02B9\u02BC\u02BC(instrument));
						this.\u02BD\u02BD\u02C0\u02BE\u02B3\u02C0\u02B7\u02BE\u02BB\u02BF\u02BB[i].enabled = false;
						if (!songEntry.isAvailableOnline)
						{
							textMeshProUGUI2.color = Color.gray;
							textMeshProUGUI.color = Color.gray;
						}
					}
				}
				else
				{
					this.\u02B6\u02BD\u02BB\u02B5\u02B4\u02B4\u02B3\u02BF\u02BF\u02BC\u02BE[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6("", true);
					this.\u02BF\u02B4\u02BA\u02BE\u02B3\u02BE\u02BB\u02BA\u02B3\u02C0\u02B3[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6("", true);
					this.\u02C0\u02B7\u02BA\u02BF\u02BB\u02B6\u02B6\u02B4\u02B6\u02BD\u02B6[i].\u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7();
					this.\u02BD\u02BD\u02C0\u02BE\u02B3\u02C0\u02B7\u02BE\u02BB\u02BF\u02BB[i].enabled = false;
				}
				if (!this.disableControls)
				{
					this.\u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2();
				}
			}
		}
		this.setlistScrollBar.value = (float)this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 / (float)this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6;
		if (u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B == null)
		{
			return;
		}
		if (this.\u02B6\u02B5\u02B7\u02BD\u02B4\u02BA\u02B6\u02B9\u02B2\u02B3\u02B4 == base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC)
		{
			return;
		}
		this.\u02B6\u02B5\u02B7\u02BD\u02B4\u02BA\u02B6\u02B9\u02B2\u02B3\u02B4 = base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC;
		object obj = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BE\u02BF\u02B3\u02C1\u02B3\u02BF\u02BE\u02B3\u02B7(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8 u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B2 = obj as \u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8;
		if (u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B2 != null)
		{
			obj = u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B2.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5[global::UnityEngine.Random.Range(0, u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B2.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count)];
		}
		this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD = (SongEntry)obj;
		\u02C0\u02B5\u02B3\u02B2\u02BA\u02BD\u02B5\u02C1\u02B9\u02BA\u02BC u02C0_u02B5_u02B3_u02B2_u02BA_u02BD_u02B5_u02C1_u02B9_u02BA_u02BC = this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.scores.\u02BC\u02BB\u02B9\u02B5\u02B5\u02BB\u02B8\u02B9\u02B9\u02BC\u02BC(instrument);
		this.\u02BD\u02B6\u02BF\u02BF\u02B4\u02BB\u02B2\u02BD\u02BE\u02B8\u02C1();
		if (this.\u02B2\u02BC\u02B7\u02B3\u02B7\u02B5\u02BB\u02BF\u02C0\u02BE\u02BC != null)
		{
			base.StopCoroutine(this.\u02B2\u02BC\u02B7\u02B3\u02B7\u02B5\u02BB\u02BF\u02C0\u02BE\u02BC);
		}
		this.\u02B2\u02BC\u02B7\u02B3\u02B7\u02B5\u02BB\u02BF\u02C0\u02BE\u02BC = this.\u02B9\u02B8\u02B6\u02B9\u02BD\u02B7\u02BB\u02BE\u02B6\u02BA\u02C0();
		base.StartCoroutine(this.\u02B2\u02BC\u02B7\u02B3\u02B7\u02B5\u02BB\u02BF\u02C0\u02BE\u02BC);
		base.StartCoroutine(this.\u02B2\u02C1\u02BD\u02B2\u02BE\u02B9\u02B7\u02B2\u02BA\u02C0\u02B5());
		for (int j = 0; j < 7; j++)
		{
			this.\u02BB\u02B2\u02BE\u02C0\u02B3\u02B9\u02B8\u02B5\u02B2\u02B3\u02B8[j].SetActive(j < (int)u02C0_u02B5_u02B3_u02B2_u02BA_u02BD_u02B5_u02C1_u02B9_u02BA_u02BC.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9);
		}
		this.\u02BA\u02B7\u02B9\u02B9\u02BD\u02BD\u02BE\u02B9\u02BF\u02BC\u02C0();
		this.lyricDisplay.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Lyrics") + ": " + (this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.lyrics ? \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Yes") : \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("No"));
		if (this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.iconName != null && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3.ContainsKey(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.iconName))
		{
			this.gameIcon.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3[this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.iconName];
			return;
		}
		if (this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.Charter != null && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3.ContainsKey(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.Charter.\u02B2\u02B7\u02B5\u02B3\u02BC\u02BE\u02C0\u02B3\u02BA\u02BA\u02B3))
		{
			this.gameIcon.sprite = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B8\u02B7\u02B9\u02B6\u02BD\u02B8\u02B9\u02C1\u02C1\u02B3[this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.Charter.\u02B2\u02B7\u02B5\u02B3\u02BC\u02BE\u02C0\u02B3\u02BA\u02BA\u02B3];
			return;
		}
		this.gameIcon.sprite = this.defaultGameIcon;
	}

	// Token: 0x06000BFC RID: 3068 RVA: 0x0000C291 File Offset: 0x0000A491
	public void \u02BF\u02BA\u02B2\u02BA\u02B2\u02B9\u02B8\u02BA\u02B6\u02BB\u02C1(bool \u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5)
	{
		this.sectionBrowser.\u02B7\u02C0\u02B7\u02B2\u02C0\u02BA\u02BC\u02BE\u02B9\u02B6\u02C1(\u02B4\u02B9\u02B9\u02B2\u02B7\u02B9\u02C0\u02C1\u02BD\u02C0\u02B5);
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x0006A410 File Offset: 0x00068610
	public void \u02BC\u02BA\u02B5\u02B6\u02BA\u02BC\u02B9\u02B7\u02B4\u02BA\u02BB()
	{
		this.onlineMenu.SetActive(true);
		base.gameObject.SetActive(false);
		this.setlistMenu.gameObject.SetActive(false);
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6 = false;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BF\u02BD\u02C1\u02C0\u02BC\u02B7\u02B4\u02C0\u02B4\u02C1();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BE\u02B5\u02B9\u02BA\u02BA\u02B4\u02B5\u02BD\u02C0\u02B6("Available");
	}

	// Token: 0x06000BFF RID: 3071 RVA: 0x0000C2A7 File Offset: 0x0000A4A7
	public override void \u02B8\u02BF\u02B4\u02B2\u02BE\u02B5\u02BC\u02B2\u02B5\u02BD\u02B8()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.\u02B5\u02BD\u02BB\u02BA\u02BD\u02C1\u02BC\u02BF\u02BF\u02B9\u02B9();
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x0006A460 File Offset: 0x00068660
	private string \u02C0\u02BD\u02BD\u02BD\u02B9\u02B2\u02BF\u02BC\u02C1\u02B7\u02B8()
	{
		string text = Path.Combine(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.folderPath, "Metal");
		string text2 = Path.Combine(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.folderPath, "framerate");
		string text3 = Path.Combine(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.folderPath, "Versus");
		if (File.Exists(text3))
		{
			return text3;
		}
		if (File.Exists(text))
		{
			return text;
		}
		if (File.Exists(text2))
		{
			return text2;
		}
		return null;
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x0006A4D0 File Offset: 0x000686D0
	public override void \u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0()
	{
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = this.textObjects.Length;
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BB\u02BF\u02BB\u02C0\u02B7\u02B3\u02BC\u02BC\u02B8\u02B2\u02B6 > this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
		{
			this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BB\u02BF\u02BB\u02C0\u02B7\u02B3\u02BC\u02BC\u02B8\u02B2\u02B6 - this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5;
			if (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 > this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6)
			{
				this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6;
				this.\u02B7\u02C1\u02BA\u02BA\u02B2\u02B5\u02B7\u02BD\u02BC\u02C1\u02BE(true);
			}
		}
		else
		{
			this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BB\u02BF\u02BB\u02C0\u02B7\u02B3\u02BC\u02BC\u02B8\u02B2\u02B6;
			this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = 0;
		}
		for (int i = 0; i < this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2.Length; i++)
		{
			if (i >= this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
			{
				this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[i].enabled = false;
			}
			else
			{
				this.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2[i].enabled = true;
			}
		}
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x0006A57C File Offset: 0x0006877C
	protected override void Update()
	{
		if (this.scorePanel.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 || this.songSelectSearch.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 || this.sectionBrowser.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 || this.songOptions.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 || this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 || this.drumSongOptionsMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		base.Update();
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x0000C2BD File Offset: 0x0000A4BD
	public void \u02B5\u02BD\u02BB\u02BA\u02BD\u02C1\u02BC\u02BF\u02BF\u02B9\u02B9()
	{
		this.songSelectSearch.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3 = false;
		this.songSelectSearch.gameObject.SetActive(true);
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x0006A5E0 File Offset: 0x000687E0
	public override void \u02B8\u02B6\u02BB\u02C0\u02BA\u02B2\u02BC\u02BF\u02BF\u02BC\u02C1()
	{
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BE\u02BD\u02B6\u02BD\u02B6\u02BF\u02B4\u02BA\u02B3\u02BD)
			{
				(\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B7\u02B3\u02B2\u02BD\u02B4\u02BC\u02C1\u02B8\u02C0\u02BA as \u02B8\u02B4\u02B4\u02BE\u02B5\u02B6\u02B7\u02B7\u02BC\u02B5\u02B7).\u02C1\u02B5\u02BB\u02B9\u02B3\u02BE\u02B4\u02B7\u02B9\u02B8\u02BE(true);
			}
			return;
		}
		if (this.setlistMenu.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB)
		{
			this.setlistMenu.\u02B8\u02BA\u02B8\u02B4\u02B9\u02B5\u02B5\u02C1\u02B6\u02B7\u02B5(false);
		}
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x0000C2DC File Offset: 0x0000A4DC
	public override void \u02B6\u02BE\u02B5\u02C1\u02B6\u02B6\u02B5\u02B3\u02BE\u02B4\u02B7()
	{
		if (this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8.playerInfo.\u02B4\u02B3\u02B9\u02BD\u02BF\u02B8\u02B3\u02B4\u02BB\u02B5\u02B3)
		{
			this.drumSongOptionsMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD();
			return;
		}
		this.\u02BD\u02BA\u02B2\u02C0\u02BC\u02B9\u02B7\u02B9\u02B9\u02B5\u02BF();
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x0000C302 File Offset: 0x0000A502
	public override void \u02BA\u02BB\u02B7\u02B6\u02B2\u02B2\u02B8\u02BB\u02B2\u02BB\u02B7()
	{
		this.\u02B9\u02B4\u02BE\u02B3\u02B5\u02BD\u02BB\u02BD\u02BC\u02B2\u02C0 = true;
		this.\u02BB\u02BF\u02BF\u02C1\u02B6\u02BF\u02B3\u02BD\u02B7\u02BA\u02C1(false);
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x0006A634 File Offset: 0x00068834
	public void \u02B2\u02B8\u02B6\u02BF\u02C0\u02C1\u02B3\u02B8\u02C0\u02B5\u02BB(Action \u02B6\u02B4\u02BC\u02B3\u02B8\u02B3\u02B6\u02BE\u02BE\u02B7\u02B2)
	{
		object obj = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BE\u02BF\u02B3\u02C1\u02B3\u02BF\u02BE\u02B3\u02B7(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		\u02B6\u02B4\u02BC\u02B3\u02B8\u02B3\u02B6\u02BE\u02BE\u02B7\u02B2();
		this.sectionBrowser.\u02B7\u02BF\u02B8\u02BF\u02B8\u02BF\u02B4\u02B2\u02BC\u02B4\u02BE();
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		if (obj is SongEntry)
		{
			this.\u02BC\u02C1\u02C0\u02BE\u02BD\u02BD\u02B2\u02BB\u02B9\u02B9\u02BF(obj as SongEntry);
			return;
		}
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(-1, true);
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x0006A684 File Offset: 0x00068884
	public void \u02B7\u02C1\u02BA\u02B9\u02BB\u02B7\u02B2\u02B6\u02C0\u02B6\u02BA(string \u02B5\u02B5\u02BB\u02B5\u02BF\u02B9\u02BD\u02B9\u02C0\u02C0\u02B2)
	{
		object obj = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BE\u02BF\u02B3\u02C1\u02B3\u02BF\u02BE\u02B3\u02B7(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BA\u02B9\u02B3\u02B4\u02B4\u02BC\u02C0\u02C1\u02B6\u02BC\u02B6(\u02B7\u02B9\u02C1\u02BC\u02B8\u02BD\u02C0\u02BA\u02BB\u02B8\u02B3.\u02BB\u02BF\u02C0\u02BF\u02B8\u02BF\u02B2\u02BC\u02BD\u02B5\u02BD(\u02B5\u02B5\u02BB\u02B5\u02BF\u02B9\u02BD\u02B9\u02C0\u02C0\u02B2, obj), \u02B5\u02B5\u02BB\u02B5\u02BF\u02B9\u02BD\u02B9\u02C0\u02C0\u02B2, false);
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		SongEntry songEntry = obj as SongEntry;
		if (songEntry != null)
		{
			this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02B5\u02B4\u02BD\u02B7\u02B4\u02B9\u02B8\u02B8\u02B5\u02BF(songEntry), true);
			return;
		}
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x0006A6D4 File Offset: 0x000688D4
	private string \u02C0\u02B8\u02B3\u02C0\u02BC\u02C1\u02BA\u02C0\u02BF\u02BB\u02B4(int \u02BD\u02B9\u02B8\u02B2\u02C1\u02B4\u02B8\u02C0\u02B3\u02BB\u02BC)
	{
		if (\u02BD\u02B9\u02B8\u02B2\u02C1\u02B4\u02B8\u02C0\u02B3\u02BB\u02BC == 0)
		{
			return "";
		}
		TimeSpan timeSpan = TimeSpan.FromMilliseconds((double)((float)\u02BD\u02B9\u02B8\u02B2\u02C1\u02B4\u02B8\u02C0\u02B3\u02BB\u02BC / SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.GetFloatPercent));
		return string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x0006A72C File Offset: 0x0006892C
	public override void \u02B2\u02B2\u02B9\u02B2\u02B8\u02BB\u02B7\u02B6\u02B3\u02C1\u02B5()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			return;
		}
		object obj = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BE\u02BF\u02B3\u02C1\u02B3\u02BF\u02BE\u02B3\u02B7(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		if (this.setlistMenu.\u02B7\u02BD\u02C1\u02C0\u02BA\u02BE\u02BC\u02B3\u02B6\u02B9\u02BB && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count > 0)
		{
			if (!CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
			{
				this.\u02BD\u02B7\u02B2\u02BE\u02B7\u02BD\u02C1\u02BE\u02C1\u02B9\u02B7();
				return;
			}
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02BE\u02BD\u02B6\u02BD\u02B6\u02BF\u02B4\u02BA\u02B3\u02BD)
			{
				\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B3\u02B7\u02BA\u02BE\u02B8\u02B4\u02B7\u02BF\u02B9\u02C0(\u02C0\u02C0\u02BD\u02B6\u02BA\u02BF\u02B3\u02BE\u02BC\u02B8\u02B4.Instrument);
				return;
			}
		}
		else if (!CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7 = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("New Setlist");
			\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B5\u02BC\u02B8\u02B9\u02B3\u02B6\u02C1\u02BA\u02C0\u02B9\u02BA = null;
			\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B7\u02BA\u02B6\u02C1\u02BD\u02B2\u02B5\u02B7\u02B5\u02B2\u02B8 = false;
			if (!(obj is \u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8))
			{
				this.setlistMenu.\u02BA\u02B4\u02B2\u02BB\u02B9\u02BC\u02B9\u02B8\u02C1\u02B5\u02BE((SongEntry)obj, SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.CurrentValue, "");
			}
			else
			{
				\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8 u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B = (\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8)obj;
				if (u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B == null || u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5 == null || u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count == 0)
				{
					return;
				}
				for (int i = 0; i < u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count; i++)
				{
					this.setlistMenu.\u02BA\u02B4\u02B2\u02BB\u02B9\u02BC\u02B9\u02B8\u02C1\u02B5\u02BE(u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5[i], SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.CurrentValue, "");
				}
			}
			base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
		}
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x0006A858 File Offset: 0x00068A58
	protected override void Start()
	{
		int num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BB\u02B3\u02B7\u02BB\u02B3\u02C1\u02B9\u02BF\u02C0\u02BF(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02C1\u02BF\u02BD\u02B5\u02BE\u02C1\u02BE\u02B8\u02BF\u02B7);
		this.\u02BE\u02C0\u02BF\u02B7\u02B3\u02BC\u02C1\u02B6\u02B7\u02B4\u02B4.\u02B6\u02B5\u02BA\u02BF\u02C0\u02C0\u02C1\u02B9\u02B4\u02B9\u02B6();
		if (num == 0)
		{
			base.Start();
		}
		else
		{
			this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(num, true);
		}
		DiscordController.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BF\u02B5\u02C1\u02B7\u02C1\u02B5\u02B6\u02BC\u02C0\u02B3(this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD);
	}

	// Token: 0x04000866 RID: 2150
	public SongListAdder \u02BE\u02C0\u02BF\u02B7\u02B3\u02BC\u02C1\u02B6\u02B7\u02B4\u02B4;

	// Token: 0x04000867 RID: 2151
	public Image[] \u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2;

	// Token: 0x04000868 RID: 2152
	public SongSelectPanel[] \u02C0\u02B7\u02BA\u02BF\u02BB\u02B6\u02B6\u02B4\u02B6\u02BD\u02B6;

	// Token: 0x04000869 RID: 2153
	public SongEntry \u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD;

	// Token: 0x0400086A RID: 2154
	[SerializeField]
	private GameObject mainMenu;

	// Token: 0x0400086B RID: 2155
	[SerializeField]
	private GameObject playerSelection;

	// Token: 0x0400086C RID: 2156
	[SerializeField]
	private GameObject onlineMenu;

	// Token: 0x0400086D RID: 2157
	[SerializeField]
	private ConfirmationMenu confirmMenu;

	// Token: 0x0400086E RID: 2158
	[SerializeField]
	private SongSelectSearch songSelectSearch;

	// Token: 0x0400086F RID: 2159
	[SerializeField]
	private SectionBrowser sectionBrowser;

	// Token: 0x04000870 RID: 2160
	[SerializeField]
	private SongOptions songOptions;

	// Token: 0x04000871 RID: 2161
	[SerializeField]
	private SetlistMenu setlistMenu;

	// Token: 0x04000872 RID: 2162
	[SerializeField]
	private DrumSongOptionsMenu drumSongOptionsMenu;

	// Token: 0x04000873 RID: 2163
	[SerializeField]
	private TextMeshProUGUI speedText;

	// Token: 0x04000874 RID: 2164
	[SerializeField]
	private TextMeshProUGUI songCountText;

	// Token: 0x04000875 RID: 2165
	[SerializeField]
	private TextMeshProUGUI artistNameText;

	// Token: 0x04000876 RID: 2166
	[SerializeField]
	private TextMeshProUGUI albumNameText;

	// Token: 0x04000877 RID: 2167
	[SerializeField]
	private TextMeshProUGUI yearText;

	// Token: 0x04000878 RID: 2168
	[SerializeField]
	private TextMeshProUGUI genreText;

	// Token: 0x04000879 RID: 2169
	[SerializeField]
	private TextMeshProUGUI songLengthText;

	// Token: 0x0400087A RID: 2170
	[SerializeField]
	private TextMeshProUGUI charterNameText;

	// Token: 0x0400087B RID: 2171
	[SerializeField]
	private Image loadImage;

	// Token: 0x0400087C RID: 2172
	[SerializeField]
	private RawImage albumImage;

	// Token: 0x0400087D RID: 2173
	[SerializeField]
	private Image gameIcon;

	// Token: 0x0400087E RID: 2174
	[SerializeField]
	private Slider setlistScrollBar;

	// Token: 0x0400087F RID: 2175
	[SerializeField]
	private DifficultyDisplay[] difficultyIcons;

	// Token: 0x04000880 RID: 2176
	[SerializeField]
	private ScrollingRect difficultyScroll;

	// Token: 0x04000881 RID: 2177
	[SerializeField]
	private TextMeshProUGUI lyricDisplay;

	// Token: 0x04000882 RID: 2178
	private IEnumerator \u02B2\u02BC\u02B7\u02B3\u02B7\u02B5\u02BB\u02BF\u02C0\u02BE\u02BC;

	// Token: 0x04000883 RID: 2179
	private Coroutine \u02B5\u02C0\u02B4\u02B7\u02BB\u02BB\u02BD\u02B2\u02B4\u02BF\u02BE;

	// Token: 0x04000884 RID: 2180
	[SerializeField]
	private Sprite defaultAlbumArt;

	// Token: 0x04000885 RID: 2181
	[SerializeField]
	private Sprite defaultGameIcon;

	// Token: 0x04000886 RID: 2182
	[SerializeField]
	private ScoringPanel scorePanel;

	// Token: 0x04000887 RID: 2183
	private int \u02B6\u02B5\u02B7\u02BD\u02B4\u02BA\u02B6\u02B9\u02B2\u02B3\u02B4;

	// Token: 0x04000888 RID: 2184
	private Color \u02BD\u02C1\u02B8\u02BE\u02B8\u02B2\u02B4\u02B2\u02BB\u02B8\u02B8 = new Color(1f, 1f, 1f, 0.5f);

	// Token: 0x04000889 RID: 2185
	private TextMeshProUGUI[] \u02BC\u02BA\u02BD\u02B2\u02BD\u02BA\u02BE\u02C1\u02C0\u02B5\u02C1;

	// Token: 0x0400088A RID: 2186
	private TextMeshProUGUI[] \u02BA\u02B4\u02BD\u02B7\u02B2\u02B9\u02BF\u02B9\u02B4\u02BE\u02BF;

	// Token: 0x0400088B RID: 2187
	private TextMeshProUGUI[] \u02B9\u02BB\u02B3\u02C1\u02B2\u02C1\u02B9\u02C0\u02BF\u02BD\u02C0;

	// Token: 0x0400088C RID: 2188
	private ScrollingText[] \u02B6\u02BD\u02BB\u02B5\u02B4\u02B4\u02B3\u02BF\u02BF\u02BC\u02BE;

	// Token: 0x0400088D RID: 2189
	private ScrollingText[] \u02BF\u02B4\u02BA\u02BE\u02B3\u02BE\u02BB\u02BA\u02B3\u02C0\u02B3;

	// Token: 0x0400088E RID: 2190
	private Image[] \u02B7\u02B7\u02B7\u02B4\u02BD\u02B6\u02C0\u02B2\u02B8\u02B3\u02B4;

	// Token: 0x0400088F RID: 2191
	private Image[] \u02BD\u02BD\u02C0\u02BE\u02B3\u02C0\u02B7\u02BE\u02BB\u02BF\u02BB;

	// Token: 0x04000890 RID: 2192
	public GameObject[] \u02BB\u02B2\u02BE\u02C0\u02B3\u02B9\u02B8\u02B5\u02B2\u02B3\u02B8;

	// Token: 0x04000891 RID: 2193
	public TextMeshProUGUI \u02B5\u02B2\u02C0\u02B3\u02B2\u02BC\u02B3\u02B4\u02BC\u02B4\u02C1;

	// Token: 0x04000892 RID: 2194
	public TextMeshProUGUI \u02B8\u02BC\u02BA\u02BA\u02BC\u02C1\u02B8\u02BB\u02B7\u02C1\u02C0;

	// Token: 0x04000893 RID: 2195
	public TextMeshProUGUI \u02B5\u02C1\u02BA\u02B3\u02B2\u02BE\u02C0\u02B6\u02B5\u02BB\u02B6;

	// Token: 0x04000894 RID: 2196
	[SerializeField]
	private GameObject starsBackground;

	// Token: 0x04000895 RID: 2197
	[SerializeField]
	private GameObject starsContainer;

	// Token: 0x04000896 RID: 2198
	[HideInInspector]
	public bool \u02C1\u02B5\u02B9\u02B4\u02B9\u02B5\u02BC\u02B3\u02B4\u02C0\u02BF;

	// Token: 0x04000897 RID: 2199
	private bool \u02B4\u02C1\u02B6\u02B5\u02B4\u02B7\u02BC\u02BE\u02C1\u02B6\u02B6;

	// Token: 0x04000898 RID: 2200
	private bool \u02B9\u02B4\u02BE\u02B3\u02B5\u02BD\u02BB\u02BD\u02BC\u02B2\u02C0;

	// Token: 0x04000899 RID: 2201
	private Instrument? \u02BD\u02B6\u02B8\u02C1\u02B3\u02BE\u02B7\u02BA\u02B4\u02BF\u02C0;

	// Token: 0x0400089A RID: 2202
	private Texture2D \u02BB\u02B6\u02B8\u02BA\u02BB\u02BB\u02B3\u02B9\u02BE\u02C0\u02C1;

	// Token: 0x0400089B RID: 2203
	private Task \u02B3\u02B3\u02B6\u02B4\u02BE\u02BA\u02BC\u02B6\u02BC\u02BC\u02BD = Task.CompletedTask;

	// Token: 0x0400089C RID: 2204
	private Color32 \u02BA\u02B5\u02BA\u02B2\u02B5\u02B4\u02B3\u02B9\u02BB\u02B7\u02BE = new Color32(27, 27, 27, 200);

	// Token: 0x0400089D RID: 2205
	private Color32 \u02C0\u02BA\u02BA\u02BC\u02B6\u02B3\u02B5\u02BB\u02B2\u02BE\u02B4 = new Color32(27, 27, 27, byte.MaxValue);

	// Token: 0x0400089E RID: 2206
	private Color32 \u02B5\u02BB\u02C0\u02B8\u02C0\u02B8\u02BF\u02B8\u02B3\u02B9\u02C0 = new Color32(27, 27, 27, 128);

	// Token: 0x0400089F RID: 2207
	private Color32 \u02BC\u02B7\u02BB\u02B3\u02BB\u02BE\u02B5\u02B2\u02B2\u02B4\u02B5 = new Color32(208, 212, 214, byte.MaxValue);

	// Token: 0x040008A0 RID: 2208
	private Color32 \u02B3\u02B4\u02C1\u02B4\u02BF\u02B7\u02B4\u02B9\u02B3\u02B4\u02BA = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 146);

	// Token: 0x040008A1 RID: 2209
	private Color32 \u02B9\u02B9\u02C1\u02BA\u02BD\u02B7\u02B2\u02B4\u02B4\u02BB\u02BA = new Color32(87, 87, 87, byte.MaxValue);

	// Token: 0x040008A2 RID: 2210
	public Sprite \u02B3\u02B9\u02BD\u02BE\u02B8\u02BF\u02B3\u02B3\u02B3\u02BC\u02C0;

	// Token: 0x040008A3 RID: 2211
	public Sprite \u02B5\u02C1\u02B5\u02B6\u02B4\u02B8\u02BC\u02BB\u02B9\u02BF\u02B7;

	// Token: 0x040008A4 RID: 2212
	public TMP_FontAsset \u02B3\u02BE\u02B4\u02B5\u02BE\u02B2\u02B4\u02C1\u02C0\u02B2\u02B4;

	// Token: 0x040008A5 RID: 2213
	public TMP_FontAsset \u02BB\u02B4\u02B5\u02BD\u02BD\u02BF\u02BC\u02BC\u02B6\u02BE\u02B9;

	// Token: 0x040008A6 RID: 2214
	public TMP_FontAsset \u02B4\u02B8\u02B3\u02BF\u02BF\u02B3\u02BC\u02B7\u02BD\u02B2\u02B6;

	// Token: 0x040008A7 RID: 2215
	public TMP_FontAsset \u02BE\u02BC\u02BB\u02B7\u02BA\u02B2\u02B3\u02B9\u02B3\u02B6\u02C0;

	// Token: 0x02000114 RID: 276
	private enum \u02B4\u02B5\u02BA\u02C0\u02BA\u02B3\u02B9\u02C1\u02B8\u02BE\u02BE
	{
		// Token: 0x040008A9 RID: 2217
		Loading,
		// Token: 0x040008AA RID: 2218
		Loaded,
		// Token: 0x040008AB RID: 2219
		Error
	}

	// Token: 0x02000117 RID: 279
	[CompilerGenerated]
	private sealed class \u02B2\u02B4\u02B5\u02BD\u02BA\u02B6\u02BE\u02B2\u02B2\u02BE\u02B9
	{
		// Token: 0x06000C19 RID: 3097 RVA: 0x0006AA9C File Offset: 0x00068C9C
		internal void \u02B9\u02BD\u02BB\u02BA\u02BA\u02C0\u02B4\u02C0\u02BF\u02B8\u02B2()
		{
			try
			{
				if (this.<>4__this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.isEnc)
				{
					this.<>4__this.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.songEnc.\u02B5\u02BC\u02B4\u02C0\u02BE\u02C0\u02BC\u02BF\u02B2\u02B6\u02B4(\u02BC\u02C0\u02BC\u02BC\u02BD\u02B3\u02C0\u02B6\u02BA\u02B5\u02C0.ALBUM_ART, this.nativeTextureData, 512, 512);
				}
				else
				{
					SLImage.\u02B9\u02C1\u02B5\u02BD\u02B3\u02B7\u02C1\u02BD\u02B8\u02B5\u02B2(File.ReadAllBytes(this.albumArt), this.nativeTextureData, 512, 512);
				}
				this.state = SongSelect.\u02B4\u02B5\u02BA\u02C0\u02BA\u02B3\u02B9\u02C1\u02B8\u02BE\u02BE.Loaded;
			}
			catch (Exception)
			{
				this.state = SongSelect.\u02B4\u02B5\u02BA\u02C0\u02BA\u02B3\u02B9\u02C1\u02B8\u02BE\u02BE.Error;
				throw;
			}
		}

		// Token: 0x040008B3 RID: 2227
		public SongSelect <>4__this;

		// Token: 0x040008B4 RID: 2228
		public NativeArray<Color32> nativeTextureData;

		// Token: 0x040008B5 RID: 2229
		public string albumArt;

		// Token: 0x040008B6 RID: 2230
		public SongSelect.\u02B4\u02B5\u02BA\u02C0\u02BA\u02B3\u02B9\u02C1\u02B8\u02BE\u02BE state;
	}

	// Token: 0x02000119 RID: 281
	[CompilerGenerated]
	private sealed class \u02B4\u02C0\u02C1\u02C1\u02B5\u02BA\u02C1\u02B9\u02BE\u02B5\u02BA
	{
		// Token: 0x06000C21 RID: 3105 RVA: 0x0000C357 File Offset: 0x0000A557
		internal void \u02B5\u02BA\u02B4\u02BB\u02BC\u02B3\u02BB\u02B2\u02B6\u02B5\u02B3()
		{
			\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BD\u02C1\u02B8\u02C1\u02B6\u02B6\u02BA\u02B3\u02BE\u02B8(this.tag);
		}

		// Token: 0x040008BC RID: 2236
		public string tag;
	}

	// Token: 0x0200011A RID: 282
	[CompilerGenerated]
	private sealed class \u02B2\u02B6\u02BF\u02C0\u02BC\u02C0\u02B6\u02B4\u02B8\u02BA\u02BF
	{
		// Token: 0x06000C23 RID: 3107 RVA: 0x0000C364 File Offset: 0x0000A564
		internal void \u02BD\u02C1\u02B5\u02B7\u02C0\u02BB\u02BB\u02B7\u02BD\u02BD\u02BE()
		{
			\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BA\u02B9\u02B3\u02B4\u02B4\u02BC\u02C0\u02C1\u02B6\u02BC\u02B6(this.filterFunc, this.tag, false);
		}

		// Token: 0x040008BD RID: 2237
		public Func<SongEntry, bool> filterFunc;

		// Token: 0x040008BE RID: 2238
		public string tag;
	}
}
