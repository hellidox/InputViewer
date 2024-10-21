using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cysharp.Text;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000089 RID: 137
public class ExportSongList : MonoBehaviour
{
	// Token: 0x060005B0 RID: 1456 RVA: 0x00008D76 File Offset: 0x00006F76
	public IEnumerator \u02B7\u02B4\u02BB\u02B2\u02B8\u02C1\u02BA\u02B2\u02B4\u02C0\u02C1()
	{
		string songListPath = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "songs.txt");
		Utf8ValueStringBuilder sb = ZString.CreateUtf8StringBuilder();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9("Artist", false);
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = true;
		int songsThisLoop = 0;
		this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 = 0;
		foreach (SongEntry songEntry in \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4)
		{
			sb.Append(songEntry.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
			sb.Append(" , ");
			sb.Append(songEntry.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
			sb.AppendLine();
			if (songsThisLoop > this.\u02B2\u02BE\u02BC\u02BF\u02C0\u02B3\u02C0\u02B7\u02BB\u02BF\u02C0)
			{
				songsThisLoop = 0;
				this.countText.text = string.Format("<color=#FFFF04FF>{0}</color> songs exported", this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6);
				yield return null;
			}
			else
			{
				int num = songsThisLoop;
				songsThisLoop = num + 1;
			}
			this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6++;
		}
		List<SongEntry>.Enumerator enumerator = default(List<SongEntry>.Enumerator);
		try
		{
			if (File.Exists(songListPath))
			{
				File.Delete(songListPath);
			}
			using (FileStream fileStream = File.OpenWrite(songListPath))
			{
				ArraySegment<byte> arraySegment = sb.AsArraySegment();
				fileStream.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
		}
		catch
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("There was a problem saving the file", "Okay", null, null, null, null);
		}
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = false;
		yield break;
		yield break;
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00008D76 File Offset: 0x00006F76
	public IEnumerator \u02BE\u02BD\u02B2\u02BD\u02C1\u02B2\u02B6\u02B2\u02B4\u02BF\u02BF()
	{
		songListPath = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "songs.txt");
		sb = ZString.CreateUtf8StringBuilder();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9("Artist", false);
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = true;
		songsThisLoop = 0;
		this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 = 0;
		enumerator = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SongEntry songEntry = enumerator.Current;
				sb.Append(songEntry.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
				sb.Append(" , ");
				sb.Append(songEntry.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
				sb.AppendLine();
				if (songsThisLoop > this.\u02B2\u02BE\u02BC\u02BF\u02C0\u02B3\u02C0\u02B7\u02BB\u02BF\u02C0)
				{
					songsThisLoop = 0;
					this.countText.text = string.Format("<color=#FFFF04FF>{0}</color> songs exported", this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6);
					yield return null;
				}
				else
				{
					int num = songsThisLoop;
					songsThisLoop = num + 1;
				}
				this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6++;
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		enumerator = default(List<SongEntry>.Enumerator);
		try
		{
			if (File.Exists(songListPath))
			{
				File.Delete(songListPath);
			}
			using (FileStream fileStream = File.OpenWrite(songListPath))
			{
				ArraySegment<byte> arraySegment = sb.AsArraySegment();
				fileStream.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
		}
		catch
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("There was a problem saving the file", "Okay", null, null, null, null);
		}
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = false;
		yield break;
		yield break;
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x00008D76 File Offset: 0x00006F76
	public IEnumerator \u02C1\u02B9\u02BA\u02BC\u02B8\u02B7\u02BC\u02C0\u02B6\u02BF\u02B9()
	{
		songListPath = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "songs.txt");
		sb = ZString.CreateUtf8StringBuilder();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9("Artist", false);
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = true;
		songsThisLoop = 0;
		this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 = 0;
		enumerator = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SongEntry songEntry = enumerator.Current;
				sb.Append(songEntry.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
				sb.Append(" , ");
				sb.Append(songEntry.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
				sb.AppendLine();
				if (songsThisLoop > this.\u02B2\u02BE\u02BC\u02BF\u02C0\u02B3\u02C0\u02B7\u02BB\u02BF\u02C0)
				{
					songsThisLoop = 0;
					this.countText.text = string.Format("<color=#FFFF04FF>{0}</color> songs exported", this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6);
					yield return null;
				}
				else
				{
					int num = songsThisLoop;
					songsThisLoop = num + 1;
				}
				this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6++;
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		enumerator = default(List<SongEntry>.Enumerator);
		try
		{
			if (File.Exists(songListPath))
			{
				File.Delete(songListPath);
			}
			using (FileStream fileStream = File.OpenWrite(songListPath))
			{
				ArraySegment<byte> arraySegment = sb.AsArraySegment();
				fileStream.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
		}
		catch
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("There was a problem saving the file", "Okay", null, null, null, null);
		}
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = false;
		yield break;
		yield break;
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00008D85 File Offset: 0x00006F85
	public IEnumerator \u02B6\u02BC\u02B2\u02BD\u02B4\u02BA\u02B6\u02B6\u02BE\u02BF\u02B3()
	{
		ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC = new ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC(1);
		u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC.<>4__this = this;
		return u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC;
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x00008D94 File Offset: 0x00006F94
	public IEnumerator \u02BD\u02BE\u02B6\u02B9\u02C1\u02B6\u02B3\u02B8\u02BD\u02BF\u02C0()
	{
		string songListPath = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "songs.json");
		Utf8ValueStringBuilder sb = ZString.CreateUtf8StringBuilder();
		sb.Append("[");
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9("Artist", false);
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = true;
		int songsThisLoop = 0;
		this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 = 0;
		IEnumerable<ExportSongList.SongExportFormat> enumerable = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Select(new Func<SongEntry, ExportSongList.SongExportFormat>(ExportSongList.<>c.<>9.\u02BB\u02B8\u02B5\u02B2\u02BC\u02BF\u02BB\u02B7\u02B5\u02C0\u02BF));
		foreach (ExportSongList.SongExportFormat songExportFormat in enumerable)
		{
			sb.Append(JsonUtility.ToJson(songExportFormat));
			if (this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 < \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count - 1)
			{
				sb.Append(",");
			}
			if (songsThisLoop > this.\u02B2\u02BE\u02BC\u02BF\u02C0\u02B3\u02C0\u02B7\u02BB\u02BF\u02C0)
			{
				songsThisLoop = 0;
				this.countText.text = string.Format("<color=#FFFF04FF>{0}</color> songs exported", this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6);
				yield return null;
			}
			else
			{
				int num = songsThisLoop;
				songsThisLoop = num + 1;
			}
			this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6++;
		}
		IEnumerator<ExportSongList.SongExportFormat> enumerator = null;
		sb.Append("]");
		try
		{
			if (File.Exists(songListPath))
			{
				File.Delete(songListPath);
			}
			using (FileStream fileStream = File.OpenWrite(songListPath))
			{
				ArraySegment<byte> arraySegment = sb.AsArraySegment();
				fileStream.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
		}
		catch
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("There was a problem saving the file", "Okay", null, null, null, null);
		}
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = false;
		yield break;
		yield break;
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x00008D76 File Offset: 0x00006F76
	public IEnumerator \u02B7\u02B2\u02BB\u02B7\u02BA\u02B7\u02BD\u02B3\u02BE\u02BC\u02BC()
	{
		songListPath = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "songs.txt");
		sb = ZString.CreateUtf8StringBuilder();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9("Artist", false);
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = true;
		songsThisLoop = 0;
		this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 = 0;
		enumerator = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SongEntry songEntry = enumerator.Current;
				sb.Append(songEntry.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
				sb.Append(" , ");
				sb.Append(songEntry.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
				sb.AppendLine();
				if (songsThisLoop > this.\u02B2\u02BE\u02BC\u02BF\u02C0\u02B3\u02C0\u02B7\u02BB\u02BF\u02C0)
				{
					songsThisLoop = 0;
					this.countText.text = string.Format("<color=#FFFF04FF>{0}</color> songs exported", this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6);
					yield return null;
				}
				else
				{
					int num = songsThisLoop;
					songsThisLoop = num + 1;
				}
				this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6++;
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		enumerator = default(List<SongEntry>.Enumerator);
		try
		{
			if (File.Exists(songListPath))
			{
				File.Delete(songListPath);
			}
			using (FileStream fileStream = File.OpenWrite(songListPath))
			{
				ArraySegment<byte> arraySegment = sb.AsArraySegment();
				fileStream.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
		}
		catch
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("There was a problem saving the file", "Okay", null, null, null, null);
		}
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = false;
		yield break;
		yield break;
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x00008DA3 File Offset: 0x00006FA3
	public IEnumerator \u02B9\u02BC\u02BD\u02B5\u02B8\u02BC\u02BF\u02BF\u02C1\u02B7\u02B7()
	{
		ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5 u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B = new ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5(1);
		u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B.<>4__this = this;
		return u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B;
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x00008DA3 File Offset: 0x00006FA3
	public IEnumerator \u02B7\u02C1\u02BB\u02BC\u02BC\u02B6\u02B7\u02B3\u02B8\u02B7\u02B4()
	{
		ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5 u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B = new ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5(1);
		u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B.<>4__this = this;
		return u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B;
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x00008DA3 File Offset: 0x00006FA3
	public IEnumerator \u02B7\u02B7\u02B3\u02B3\u02B5\u02B2\u02C0\u02C0\u02B5\u02B3\u02BE()
	{
		ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5 u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B = new ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5(1);
		u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B.<>4__this = this;
		return u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B;
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x00008D94 File Offset: 0x00006F94
	public IEnumerator \u02B6\u02B9\u02B2\u02BE\u02BB\u02B6\u02C1\u02B8\u02B2\u02BE\u02B3()
	{
		songListPath = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "songs.json");
		sb = ZString.CreateUtf8StringBuilder();
		sb.Append("[");
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9("Artist", false);
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = true;
		songsThisLoop = 0;
		this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 = 0;
		IEnumerable<ExportSongList.SongExportFormat> enumerable = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Select(new Func<SongEntry, ExportSongList.SongExportFormat>(ExportSongList.<>c.<>9.\u02BB\u02B8\u02B5\u02B2\u02BC\u02BF\u02BB\u02B7\u02B5\u02C0\u02BF));
		enumerator = enumerable.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ExportSongList.SongExportFormat songExportFormat = enumerator.Current;
				sb.Append(JsonUtility.ToJson(songExportFormat));
				if (this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 < \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count - 1)
				{
					sb.Append(",");
				}
				if (songsThisLoop > this.\u02B2\u02BE\u02BC\u02BF\u02C0\u02B3\u02C0\u02B7\u02BB\u02BF\u02C0)
				{
					songsThisLoop = 0;
					this.countText.text = string.Format("<color=#FFFF04FF>{0}</color> songs exported", this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6);
					yield return null;
				}
				else
				{
					int num = songsThisLoop;
					songsThisLoop = num + 1;
				}
				this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6++;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				enumerator.Dispose();
			}
		}
		enumerator = null;
		sb.Append("]");
		try
		{
			if (File.Exists(songListPath))
			{
				File.Delete(songListPath);
			}
			using (FileStream fileStream = File.OpenWrite(songListPath))
			{
				ArraySegment<byte> arraySegment = sb.AsArraySegment();
				fileStream.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
		}
		catch
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("There was a problem saving the file", "Okay", null, null, null, null);
		}
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = false;
		yield break;
		yield break;
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x00008D94 File Offset: 0x00006F94
	public IEnumerator \u02B7\u02BA\u02B6\u02C1\u02BF\u02B6\u02BA\u02BE\u02B7\u02B7\u02BC()
	{
		songListPath = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "songs.json");
		sb = ZString.CreateUtf8StringBuilder();
		sb.Append("[");
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9("Artist", false);
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = true;
		songsThisLoop = 0;
		this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 = 0;
		IEnumerable<ExportSongList.SongExportFormat> enumerable = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Select(new Func<SongEntry, ExportSongList.SongExportFormat>(ExportSongList.<>c.<>9.\u02BB\u02B8\u02B5\u02B2\u02BC\u02BF\u02BB\u02B7\u02B5\u02C0\u02BF));
		enumerator = enumerable.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ExportSongList.SongExportFormat songExportFormat = enumerator.Current;
				sb.Append(JsonUtility.ToJson(songExportFormat));
				if (this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 < \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count - 1)
				{
					sb.Append(",");
				}
				if (songsThisLoop > this.\u02B2\u02BE\u02BC\u02BF\u02C0\u02B3\u02C0\u02B7\u02BB\u02BF\u02C0)
				{
					songsThisLoop = 0;
					this.countText.text = string.Format("<color=#FFFF04FF>{0}</color> songs exported", this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6);
					yield return null;
				}
				else
				{
					int num = songsThisLoop;
					songsThisLoop = num + 1;
				}
				this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6++;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				enumerator.Dispose();
			}
		}
		enumerator = null;
		sb.Append("]");
		try
		{
			if (File.Exists(songListPath))
			{
				File.Delete(songListPath);
			}
			using (FileStream fileStream = File.OpenWrite(songListPath))
			{
				ArraySegment<byte> arraySegment = sb.AsArraySegment();
				fileStream.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
		}
		catch
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("There was a problem saving the file", "Okay", null, null, null, null);
		}
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = false;
		yield break;
		yield break;
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x00008D85 File Offset: 0x00006F85
	public IEnumerator \u02B8\u02BC\u02B8\u02B2\u02B7\u02BD\u02B6\u02B3\u02BB\u02BA\u02BA()
	{
		ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC = new ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC(1);
		u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC.<>4__this = this;
		return u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC;
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x00008DA3 File Offset: 0x00006FA3
	public IEnumerator \u02BC\u02B3\u02BB\u02B3\u02B2\u02B8\u02B3\u02C0\u02B8\u02B2\u02B3()
	{
		ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5 u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B = new ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5(1);
		u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B.<>4__this = this;
		return u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B;
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x00008DA3 File Offset: 0x00006FA3
	public IEnumerator \u02BF\u02BF\u02BA\u02C0\u02BD\u02B3\u02B3\u02B6\u02BD\u02B6\u02C0()
	{
		ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5 u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B = new ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5(1);
		u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B.<>4__this = this;
		return u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B;
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x00008D94 File Offset: 0x00006F94
	public IEnumerator \u02B5\u02B5\u02B6\u02B9\u02B5\u02B7\u02BF\u02C0\u02B3\u02BD\u02B6()
	{
		songListPath = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "songs.json");
		sb = ZString.CreateUtf8StringBuilder();
		sb.Append("[");
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9("Artist", false);
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = true;
		songsThisLoop = 0;
		this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 = 0;
		IEnumerable<ExportSongList.SongExportFormat> enumerable = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Select(new Func<SongEntry, ExportSongList.SongExportFormat>(ExportSongList.<>c.<>9.\u02BB\u02B8\u02B5\u02B2\u02BC\u02BF\u02BB\u02B7\u02B5\u02C0\u02BF));
		enumerator = enumerable.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ExportSongList.SongExportFormat songExportFormat = enumerator.Current;
				sb.Append(JsonUtility.ToJson(songExportFormat));
				if (this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 < \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count - 1)
				{
					sb.Append(",");
				}
				if (songsThisLoop > this.\u02B2\u02BE\u02BC\u02BF\u02C0\u02B3\u02C0\u02B7\u02BB\u02BF\u02C0)
				{
					songsThisLoop = 0;
					this.countText.text = string.Format("<color=#FFFF04FF>{0}</color> songs exported", this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6);
					yield return null;
				}
				else
				{
					int num = songsThisLoop;
					songsThisLoop = num + 1;
				}
				this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6++;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				enumerator.Dispose();
			}
		}
		enumerator = null;
		sb.Append("]");
		try
		{
			if (File.Exists(songListPath))
			{
				File.Delete(songListPath);
			}
			using (FileStream fileStream = File.OpenWrite(songListPath))
			{
				ArraySegment<byte> arraySegment = sb.AsArraySegment();
				fileStream.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
		}
		catch
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("There was a problem saving the file", "Okay", null, null, null, null);
		}
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = false;
		yield break;
		yield break;
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x00008D94 File Offset: 0x00006F94
	public IEnumerator \u02B7\u02BF\u02B5\u02BE\u02B3\u02C1\u02BA\u02BD\u02C0\u02B5\u02B9()
	{
		songListPath = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "songs.json");
		sb = ZString.CreateUtf8StringBuilder();
		sb.Append("[");
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9("Artist", false);
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = true;
		songsThisLoop = 0;
		this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 = 0;
		IEnumerable<ExportSongList.SongExportFormat> enumerable = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Select(new Func<SongEntry, ExportSongList.SongExportFormat>(ExportSongList.<>c.<>9.\u02BB\u02B8\u02B5\u02B2\u02BC\u02BF\u02BB\u02B7\u02B5\u02C0\u02BF));
		enumerator = enumerable.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ExportSongList.SongExportFormat songExportFormat = enumerator.Current;
				sb.Append(JsonUtility.ToJson(songExportFormat));
				if (this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 < \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count - 1)
				{
					sb.Append(",");
				}
				if (songsThisLoop > this.\u02B2\u02BE\u02BC\u02BF\u02C0\u02B3\u02C0\u02B7\u02BB\u02BF\u02C0)
				{
					songsThisLoop = 0;
					this.countText.text = string.Format("<color=#FFFF04FF>{0}</color> songs exported", this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6);
					yield return null;
				}
				else
				{
					int num = songsThisLoop;
					songsThisLoop = num + 1;
				}
				this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6++;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				enumerator.Dispose();
			}
		}
		enumerator = null;
		sb.Append("]");
		try
		{
			if (File.Exists(songListPath))
			{
				File.Delete(songListPath);
			}
			using (FileStream fileStream = File.OpenWrite(songListPath))
			{
				ArraySegment<byte> arraySegment = sb.AsArraySegment();
				fileStream.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
		}
		catch
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("There was a problem saving the file", "Okay", null, null, null, null);
		}
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = false;
		yield break;
		yield break;
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x00008D85 File Offset: 0x00006F85
	public IEnumerator \u02BD\u02BE\u02B4\u02B6\u02B8\u02B3\u02B8\u02BB\u02B4\u02C0\u02B8()
	{
		ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC = new ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC(1);
		u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC.<>4__this = this;
		return u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC;
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x00008DA3 File Offset: 0x00006FA3
	public IEnumerator \u02B2\u02BA\u02B7\u02BC\u02BA\u02BD\u02BD\u02B6\u02BB\u02B7\u02BE()
	{
		ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5 u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B = new ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5(1);
		u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B.<>4__this = this;
		return u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B;
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x00008D76 File Offset: 0x00006F76
	public IEnumerator \u02BA\u02BE\u02B6\u02C0\u02B4\u02B6\u02B6\u02BC\u02B5\u02BA\u02B5()
	{
		songListPath = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "songs.txt");
		sb = ZString.CreateUtf8StringBuilder();
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF;
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9("Artist", false);
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = true;
		songsThisLoop = 0;
		this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6 = 0;
		enumerator = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SongEntry songEntry = enumerator.Current;
				sb.Append(songEntry.Artist.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
				sb.Append(" , ");
				sb.Append(songEntry.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5);
				sb.AppendLine();
				if (songsThisLoop > this.\u02B2\u02BE\u02BC\u02BF\u02C0\u02B3\u02C0\u02B7\u02BB\u02BF\u02C0)
				{
					songsThisLoop = 0;
					this.countText.text = string.Format("<color=#FFFF04FF>{0}</color> songs exported", this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6);
					yield return null;
				}
				else
				{
					int num = songsThisLoop;
					songsThisLoop = num + 1;
				}
				this.\u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6++;
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		enumerator = default(List<SongEntry>.Enumerator);
		try
		{
			if (File.Exists(songListPath))
			{
				File.Delete(songListPath);
			}
			using (FileStream fileStream = File.OpenWrite(songListPath))
			{
				ArraySegment<byte> arraySegment = sb.AsArraySegment();
				fileStream.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
		}
		catch
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("There was a problem saving the file", "Okay", null, null, null, null);
		}
		this.\u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4 = false;
		yield break;
		yield break;
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x00008D85 File Offset: 0x00006F85
	public IEnumerator \u02BB\u02BA\u02BE\u02B9\u02BF\u02B7\u02B2\u02B8\u02B3\u02BD\u02B3()
	{
		ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC = new ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC(1);
		u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC.<>4__this = this;
		return u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC;
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x00008D85 File Offset: 0x00006F85
	public IEnumerator \u02B9\u02B5\u02B2\u02BA\u02B5\u02B9\u02BC\u02B9\u02BB\u02C1\u02B9()
	{
		ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC = new ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC(1);
		u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC.<>4__this = this;
		return u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC;
	}

	// Token: 0x04000419 RID: 1049
	[HideInInspector]
	public bool \u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4;

	// Token: 0x0400041A RID: 1050
	[SerializeField]
	private Text countText;

	// Token: 0x0400041B RID: 1051
	[SerializeField]
	private ConfirmationMenu confirmMenu;

	// Token: 0x0400041C RID: 1052
	private int \u02B2\u02BE\u02BC\u02BF\u02C0\u02B3\u02C0\u02B7\u02BB\u02BF\u02C0 = 50;

	// Token: 0x0400041D RID: 1053
	private int \u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6;

	// Token: 0x0200008A RID: 138
	[Serializable]
	public struct SongExportFormat
	{
		// Token: 0x0400041E RID: 1054
		public string Name;

		// Token: 0x0400041F RID: 1055
		public string Artist;

		// Token: 0x04000420 RID: 1056
		public string Album;

		// Token: 0x04000421 RID: 1057
		public string Genre;

		// Token: 0x04000422 RID: 1058
		public string Charter;

		// Token: 0x04000423 RID: 1059
		public string Year;

		// Token: 0x04000424 RID: 1060
		public string Playlist;

		// Token: 0x04000425 RID: 1061
		public bool lyrics;

		// Token: 0x04000426 RID: 1062
		public bool modchart;

		// Token: 0x04000427 RID: 1063
		public int songlength;

		// Token: 0x04000428 RID: 1064
		public long chartsAvailable;
	}
}
