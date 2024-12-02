using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cysharp.Text;
using UnityEngine;
using UnityEngine.UI;

public class ExportSongList : MonoBehaviour
{
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

	public IEnumerator \u02B6\u02BC\u02B2\u02BD\u02B4\u02BA\u02B6\u02B6\u02BE\u02BF\u02B3()
	{
		ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC = new ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC(1);
		u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC.<>4__this = this;
		return u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC;
	}

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

	public IEnumerator \u02B9\u02BC\u02BD\u02B5\u02B8\u02BC\u02BF\u02BF\u02C1\u02B7\u02B7()
	{
		ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5 u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B = new ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5(1);
		u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B.<>4__this = this;
		return u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B;
	}

	public IEnumerator \u02B7\u02C1\u02BB\u02BC\u02BC\u02B6\u02B7\u02B3\u02B8\u02B7\u02B4()
	{
		ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5 u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B = new ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5(1);
		u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B.<>4__this = this;
		return u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B;
	}

	public IEnumerator \u02B7\u02B7\u02B3\u02B3\u02B5\u02B2\u02C0\u02C0\u02B5\u02B3\u02BE()
	{
		ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5 u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B = new ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5(1);
		u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B.<>4__this = this;
		return u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B;
	}

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

	public IEnumerator \u02B8\u02BC\u02B8\u02B2\u02B7\u02BD\u02B6\u02B3\u02BB\u02BA\u02BA()
	{
		ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC = new ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC(1);
		u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC.<>4__this = this;
		return u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC;
	}

	public IEnumerator \u02BC\u02B3\u02BB\u02B3\u02B2\u02B8\u02B3\u02C0\u02B8\u02B2\u02B3()
	{
		ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5 u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B = new ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5(1);
		u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B.<>4__this = this;
		return u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B;
	}

	public IEnumerator \u02BF\u02BF\u02BA\u02C0\u02BD\u02B3\u02B3\u02B6\u02BD\u02B6\u02C0()
	{
		ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5 u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B = new ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5(1);
		u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B.<>4__this = this;
		return u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B;
	}

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

	public IEnumerator \u02BD\u02BE\u02B4\u02B6\u02B8\u02B3\u02B8\u02BB\u02B4\u02C0\u02B8()
	{
		ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC = new ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC(1);
		u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC.<>4__this = this;
		return u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC;
	}

	public IEnumerator \u02B2\u02BA\u02B7\u02BC\u02BA\u02BD\u02BD\u02B6\u02BB\u02B7\u02BE()
	{
		ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5 u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B = new ExportSongList.\u02BA\u02B6\u02B8\u02BA\u02C0\u02B9\u02C0\u02B7\u02B7\u02BF\u02B5(1);
		u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B.<>4__this = this;
		return u02BA_u02B6_u02B8_u02BA_u02C0_u02B9_u02C0_u02B7_u02B7_u02BF_u02B;
	}

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

	public IEnumerator \u02BB\u02BA\u02BE\u02B9\u02BF\u02B7\u02B2\u02B8\u02B3\u02BD\u02B3()
	{
		ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC = new ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC(1);
		u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC.<>4__this = this;
		return u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC;
	}

	public IEnumerator \u02B9\u02B5\u02B2\u02BA\u02B5\u02B9\u02BC\u02B9\u02BB\u02C1\u02B9()
	{
		ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC = new ExportSongList.\u02B8\u02B2\u02C0\u02BD\u02BA\u02BC\u02B5\u02B2\u02B6\u02B7\u02BC(1);
		u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC.<>4__this = this;
		return u02B8_u02B2_u02C0_u02BD_u02BA_u02BC_u02B5_u02B2_u02B6_u02B7_u02BC;
	}

	[HideInInspector]
	public bool \u02B5\u02B8\u02B9\u02BD\u02BF\u02B7\u02B2\u02BB\u02BA\u02C0\u02B4;

	[SerializeField]
	private Text countText;

	[SerializeField]
	private ConfirmationMenu confirmMenu;

	private int \u02B2\u02BE\u02BC\u02BF\u02C0\u02B3\u02C0\u02B7\u02BB\u02BF\u02C0 = 50;

	private int \u02BA\u02BE\u02B5\u02B7\u02B4\u02BA\u02B8\u02B4\u02BB\u02B3\u02B6;

	[Serializable]
	public struct SongExportFormat
	{
		public string Name;

		public string Artist;

		public string Album;

		public string Genre;

		public string Charter;

		public string Year;

		public string Playlist;

		public bool lyrics;

		public bool modchart;

		public int songlength;

		public long chartsAvailable;
	}
}
