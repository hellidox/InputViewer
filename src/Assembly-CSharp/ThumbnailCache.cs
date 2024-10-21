using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Video;

// Token: 0x02000205 RID: 517
public class ThumbnailCache : MonoBehaviour
{
	// Token: 0x0600173B RID: 5947 RVA: 0x000B0914 File Offset: 0x000AEB14
	private void \u02B7\u02BB\u02B7\u02B2\u02C1\u02B3\u02B9\u02B9\u02B4\u02BD\u02B2(VideoPlayer \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7, long \u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF)
	{
		if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.texture != null && !\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.isPaused && \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.frame <= 0L)
		{
			\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.Pause();
			\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.sendFrameReadyEvents = false;
			Debug.Log(string.Format("_GlobalWhammyTexture", \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.url, \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.texture));
			this.\u02B9\u02B8\u02B9\u02C1\u02B5\u02B9\u02B7\u02BC\u02BB\u02BD\u02B4.Enqueue(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7);
		}
	}

	// Token: 0x0600173C RID: 5948 RVA: 0x00011FCD File Offset: 0x000101CD
	private IEnumerator \u02B7\u02B9\u02BF\u02B4\u02B4\u02BE\u02C1\u02C1\u02B9\u02C1\u02BD(string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB, byte[] \u02BF\u02B4\u02BA\u02BC\u02BA\u02BC\u02B2\u02B9\u02B3\u02B7\u02B4, bool \u02BB\u02B2\u02C0\u02B3\u02C0\u02BF\u02B8\u02B2\u02B8\u02BD\u02B9 = false, bool \u02BE\u02B5\u02BE\u02BE\u02B9\u02B4\u02BA\u02B2\u02B8\u02B3\u02BE = false)
	{
		if (this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA == null)
		{
			this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA = new Texture2D(1, 1, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None);
		}
		if (this.\u02BE\u02C1\u02B5\u02B8\u02B8\u02C0\u02B6\u02B7\u02B9\u02BF\u02B8 == null)
		{
			this.\u02BE\u02C1\u02B5\u02B8\u02B8\u02C0\u02B6\u02B7\u02B9\u02BF\u02B8 = new Texture2D(1, 1, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None);
		}
		string imageCacheHashPath = ThumbnailCache.\u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB);
		if (File.Exists(imageCacheHashPath))
		{
			yield break;
		}
		if (this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA.LoadImage(\u02BF\u02B4\u02BA\u02BC\u02BA\u02BC\u02B2\u02B9\u02B3\u02B7\u02B4))
		{
			this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA.Apply();
			if (\u02BB\u02B2\u02C0\u02B3\u02C0\u02BF\u02B8\u02B2\u02B8\u02BD\u02B9)
			{
				yield return this.\u02B2\u02B3\u02BA\u02B6\u02B5\u02B3\u02B9\u02B2\u02C0\u02C0\u02BA;
			}
			float num = (float)this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA.width / (float)this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA.height;
			int width = ((num > 1f) ? 128 : ((int)(128f * num)));
			int height = ((num > 1f) ? ((int)(128f * (1f / num))) : 128);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, GraphicsFormat.R8G8B8A8_SRGB);
			Graphics.Blit(this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA, renderTexture);
			if (\u02BB\u02B2\u02C0\u02B3\u02C0\u02BF\u02B8\u02B2\u02B8\u02BD\u02B9)
			{
				yield return this.\u02B2\u02B3\u02BA\u02B6\u02B5\u02B3\u02B9\u02B2\u02C0\u02C0\u02BA;
			}
			RenderTexture.active = renderTexture;
			Texture2D texture2D;
			if (this.\u02BE\u02C1\u02B5\u02B8\u02B8\u02C0\u02B6\u02B7\u02B9\u02BF\u02B8.Reinitialize(width, height, GraphicsFormat.R8G8B8A8_SRGB, false))
			{
				texture2D = this.\u02BE\u02C1\u02B5\u02B8\u02B8\u02C0\u02B6\u02B7\u02B9\u02BF\u02B8;
			}
			else
			{
				texture2D = new Texture2D(width, height, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None);
			}
			texture2D.ReadPixels(new Rect(0f, 0f, (float)renderTexture.width, (float)renderTexture.height), 0, 0);
			texture2D.Apply(true);
			byte[] array = texture2D.EncodeToPNG();
			this.\u02B2\u02B8\u02BA\u02BB\u02BC\u02BA\u02BF\u02B8\u02B5\u02B5\u02BC.Add(new ValueTuple<string, byte[]>(imageCacheHashPath, array));
			RenderTexture.ReleaseTemporary(renderTexture);
			if (\u02BE\u02B5\u02BE\u02BE\u02B9\u02B4\u02BA\u02B2\u02B8\u02B3\u02BE)
			{
				ArrayPool<byte>.Shared.Return(\u02BF\u02B4\u02BA\u02BC\u02BA\u02BC\u02B2\u02B9\u02B3\u02B7\u02B4, false);
			}
			renderTexture = null;
		}
		yield return null;
		yield break;
	}

	// Token: 0x0600173D RID: 5949 RVA: 0x00011FF9 File Offset: 0x000101F9
	private void \u02BA\u02B7\u02BE\u02B4\u02BB\u02B3\u02B7\u02C0\u02BE\u02BE\u02B2(VideoPlayer \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		Debug.Log("hasDrums" + \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.url);
		if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.isPlaying)
		{
			\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.Stop();
		}
		this.\u02B3\u02B9\u02B6\u02B4\u02B5\u02C1\u02B3\u02BA\u02BD\u02BA\u02BB.Enqueue(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7);
	}

	// Token: 0x0600173E RID: 5950 RVA: 0x00011FCD File Offset: 0x000101CD
	private IEnumerator \u02BC\u02B8\u02B3\u02B7\u02B3\u02BA\u02C1\u02BD\u02B7\u02C1\u02B7(string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB, byte[] \u02BF\u02B4\u02BA\u02BC\u02BA\u02BC\u02B2\u02B9\u02B3\u02B7\u02B4, bool \u02BB\u02B2\u02C0\u02B3\u02C0\u02BF\u02B8\u02B2\u02B8\u02BD\u02B9 = false, bool \u02BE\u02B5\u02BE\u02BE\u02B9\u02B4\u02BA\u02B2\u02B8\u02B3\u02BE = false)
	{
		if (this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA == null)
		{
			this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA = new Texture2D(1, 1, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None);
		}
		if (this.\u02BE\u02C1\u02B5\u02B8\u02B8\u02C0\u02B6\u02B7\u02B9\u02BF\u02B8 == null)
		{
			this.\u02BE\u02C1\u02B5\u02B8\u02B8\u02C0\u02B6\u02B7\u02B9\u02BF\u02B8 = new Texture2D(1, 1, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None);
		}
		imageCacheHashPath = ThumbnailCache.\u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB);
		if (File.Exists(imageCacheHashPath))
		{
			yield break;
		}
		if (this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA.LoadImage(\u02BF\u02B4\u02BA\u02BC\u02BA\u02BC\u02B2\u02B9\u02B3\u02B7\u02B4))
		{
			this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA.Apply();
			if (\u02BB\u02B2\u02C0\u02B3\u02C0\u02BF\u02B8\u02B2\u02B8\u02BD\u02B9)
			{
				yield return this.\u02B2\u02B3\u02BA\u02B6\u02B5\u02B3\u02B9\u02B2\u02C0\u02C0\u02BA;
			}
			float num = (float)this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA.width / (float)this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA.height;
			width = ((num > 1f) ? 128 : ((int)(128f * num)));
			height = ((num > 1f) ? ((int)(128f * (1f / num))) : 128);
			renderTexture = RenderTexture.GetTemporary(width, height, 0, GraphicsFormat.R8G8B8A8_SRGB);
			Graphics.Blit(this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA, renderTexture);
			if (\u02BB\u02B2\u02C0\u02B3\u02C0\u02BF\u02B8\u02B2\u02B8\u02BD\u02B9)
			{
				yield return this.\u02B2\u02B3\u02BA\u02B6\u02B5\u02B3\u02B9\u02B2\u02C0\u02C0\u02BA;
			}
			RenderTexture.active = renderTexture;
			Texture2D texture2D;
			if (this.\u02BE\u02C1\u02B5\u02B8\u02B8\u02C0\u02B6\u02B7\u02B9\u02BF\u02B8.Reinitialize(width, height, GraphicsFormat.R8G8B8A8_SRGB, false))
			{
				texture2D = this.\u02BE\u02C1\u02B5\u02B8\u02B8\u02C0\u02B6\u02B7\u02B9\u02BF\u02B8;
			}
			else
			{
				texture2D = new Texture2D(width, height, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None);
			}
			texture2D.ReadPixels(new Rect(0f, 0f, (float)renderTexture.width, (float)renderTexture.height), 0, 0);
			texture2D.Apply(true);
			byte[] array = texture2D.EncodeToPNG();
			this.\u02B2\u02B8\u02BA\u02BB\u02BC\u02BA\u02BF\u02B8\u02B5\u02B5\u02BC.Add(new ValueTuple<string, byte[]>(imageCacheHashPath, array));
			RenderTexture.ReleaseTemporary(renderTexture);
			if (\u02BE\u02B5\u02BE\u02BE\u02B9\u02B4\u02BA\u02B2\u02B8\u02B3\u02BE)
			{
				ArrayPool<byte>.Shared.Return(\u02BF\u02B4\u02BA\u02BC\u02BA\u02BC\u02B2\u02B9\u02B3\u02B7\u02B4, false);
			}
			renderTexture = null;
		}
		yield return null;
		yield break;
	}

	// Token: 0x0600173F RID: 5951 RVA: 0x0001202A File Offset: 0x0001022A
	public IEnumerator \u02B6\u02B3\u02B6\u02B8\u02C0\u02B6\u02B8\u02BB\u02B2\u02B6\u02B5()
	{
		while (this.\u02B8\u02BD\u02C0\u02B4\u02C1\u02BC\u02B5\u02C1\u02BB\u02C0\u02BF < this.\u02B3\u02B2\u02B6\u02B9\u02B6\u02B4\u02C0\u02C0\u02B6\u02B8\u02BB)
		{
			VideoPlayer videoPlayer;
			if (this.\u02B9\u02B8\u02B9\u02C1\u02B5\u02B9\u02B7\u02BC\u02BB\u02BD\u02B4.TryDequeue(out videoPlayer))
			{
				string text;
				if (videoPlayer.clip != null)
				{
					text = videoPlayer.clip.originalPath;
				}
				else
				{
					text = videoPlayer.url;
				}
				Debug.Log(string.Format("Dequeue {0} {1}", videoPlayer.url, videoPlayer.texture));
				this.\u02B2\u02C1\u02BC\u02B7\u02B4\u02B7\u02B8\u02BF\u02B2\u02B7\u02B6(videoPlayer, text);
				this.\u02BC\u02B9\u02B5\u02BD\u02B9\u02BE\u02BC\u02B7\u02C0\u02B7\u02B6(videoPlayer);
			}
			else
			{
				yield return this.\u02B2\u02B3\u02BA\u02B6\u02B5\u02B3\u02B9\u02B2\u02C0\u02C0\u02BA;
			}
		}
		yield break;
	}

	// Token: 0x06001740 RID: 5952 RVA: 0x00012039 File Offset: 0x00010239
	public void \u02BC\u02BF\u02B2\u02B6\u02B6\u02B2\u02B5\u02BF\u02BF\u02BB\u02B5()
	{
		this.\u02BC\u02B5\u02B3\u02BB\u02B4\u02BA\u02C0\u02B2\u02B7\u02B2\u02B2 = true;
		this.\u02B5\u02BE\u02C1\u02B6\u02BC\u02B5\u02B4\u02C1\u02BE\u02BE\u02B5 = false;
		this.\u02BA\u02BB\u02C0\u02BB\u02C1\u02B2\u02B7\u02C0\u02BC\u02BB\u02BD = new Thread(new ThreadStart(this.\u02BF\u02BD\u02B4\u02B4\u02B7\u02BF\u02BC\u02B8\u02BE\u02BA\u02B7));
		this.\u02BA\u02BB\u02C0\u02BB\u02C1\u02B2\u02B7\u02C0\u02BC\u02BB\u02BD.Start();
	}

	// Token: 0x06001741 RID: 5953 RVA: 0x0001206B File Offset: 0x0001026B
	public IEnumerator \u02B2\u02B3\u02B6\u02B4\u02B8\u02B7\u02B6\u02C0\u02BB\u02BA\u02B7(VideoClip[] \u02C0\u02B6\u02BF\u02BB\u02BA\u02C0\u02C1\u02C1\u02BE\u02B4\u02B6)
	{
		ThumbnailCache.\u02C1\u02BE\u02B6\u02C0\u02BD\u02BC\u02B5\u02BA\u02B4\u02C1\u02B2 u02C1_u02BE_u02B6_u02C0_u02BD_u02BC_u02B5_u02BA_u02B4_u02C1_u02B = new ThumbnailCache.\u02C1\u02BE\u02B6\u02C0\u02BD\u02BC\u02B5\u02BA\u02B4\u02C1\u02B2(1);
		u02C1_u02BE_u02B6_u02C0_u02BD_u02BC_u02B5_u02BA_u02B4_u02C1_u02B.<>4__this = this;
		u02C1_u02BE_u02B6_u02C0_u02BD_u02BC_u02B5_u02BA_u02B4_u02C1_u02B.clips = \u02C0\u02B6\u02BF\u02BB\u02BA\u02C0\u02C1\u02C1\u02BE\u02B4\u02B6;
		return u02C1_u02BE_u02B6_u02C0_u02BD_u02BC_u02B5_u02BA_u02B4_u02C1_u02B;
	}

	// Token: 0x06001742 RID: 5954 RVA: 0x00012081 File Offset: 0x00010281
	private IEnumerator \u02B3\u02BC\u02B9\u02C1\u02B7\u02B8\u02C0\u02B3\u02B6\u02C1\u02BC(string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB, byte[] \u02BF\u02B4\u02BA\u02BC\u02BA\u02BC\u02B2\u02B9\u02B3\u02B7\u02B4, bool \u02BB\u02B2\u02C0\u02B3\u02C0\u02BF\u02B8\u02B2\u02B8\u02BD\u02B9 = false, bool \u02BE\u02B5\u02BE\u02BE\u02B9\u02B4\u02BA\u02B2\u02B8\u02B3\u02BE = false)
	{
		ThumbnailCache.\u02BA\u02BA\u02B5\u02BE\u02C1\u02BD\u02B3\u02B5\u02C1\u02B8\u02BF u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF = new ThumbnailCache.\u02BA\u02BA\u02B5\u02BE\u02C1\u02BD\u02B3\u02B5\u02C1\u02B8\u02BF(1);
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.<>4__this = this;
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.filePath = \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB;
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.imageBytes = \u02BF\u02B4\u02BA\u02BC\u02BA\u02BC\u02B2\u02B9\u02B3\u02B7\u02B4;
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.includeFramePauses = \u02BB\u02B2\u02C0\u02B3\u02C0\u02BF\u02B8\u02B2\u02B8\u02BD\u02B9;
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.returnBytesToPool = \u02BE\u02B5\u02BE\u02BE\u02B9\u02B4\u02BA\u02B2\u02B8\u02B3\u02BE;
		return u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF;
	}

	// Token: 0x06001743 RID: 5955 RVA: 0x000120AD File Offset: 0x000102AD
	public IEnumerator \u02B7\u02C1\u02BD\u02B5\u02BE\u02BB\u02BC\u02B9\u02BB\u02BC\u02C0(string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)
	{
		ThumbnailCache.\u02BB\u02BA\u02BA\u02BB\u02BF\u02B3\u02B7\u02B8\u02B4\u02B3\u02BB u02BB_u02BA_u02BA_u02BB_u02BF_u02B3_u02B7_u02B8_u02B4_u02B3_u02BB = new ThumbnailCache.\u02BB\u02BA\u02BA\u02BB\u02BF\u02B3\u02B7\u02B8\u02B4\u02B3\u02BB();
		u02BB_u02BA_u02BA_u02BB_u02BF_u02B3_u02B7_u02B8_u02B4_u02B3_u02BB.<>4__this = this;
		u02BB_u02BA_u02BA_u02BB_u02BF_u02B3_u02B7_u02B8_u02B4_u02B3_u02BB.filePath = \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB;
		Task<byte[]> task = Task.Run<byte[]>(new Func<byte[]>(u02BB_u02BA_u02BA_u02BB_u02BF_u02B3_u02B7_u02B8_u02B4_u02B3_u02BB.\u02BD\u02B8\u02C0\u02B9\u02B4\u02BF\u02B5\u02B6\u02BA\u02B7\u02BA));
		while (task.Status != TaskStatus.RanToCompletion && task.Status != TaskStatus.Faulted)
		{
			yield return null;
		}
		base.StartCoroutine(this.\u02B7\u02B9\u02BF\u02B4\u02B4\u02BE\u02C1\u02C1\u02B9\u02C1\u02BD(u02BB_u02BA_u02BA_u02BB_u02BF_u02B3_u02B7_u02B8_u02B4_u02B3_u02BB.filePath, task.Result, true, true));
		yield break;
	}

	// Token: 0x06001745 RID: 5957 RVA: 0x000B09CC File Offset: 0x000AEBCC
	private VideoPlayer \u02B9\u02BF\u02C1\u02B3\u02B6\u02BD\u02BB\u02B7\u02BF\u02B6\u02C0()
	{
		if (this.\u02B3\u02B9\u02B6\u02B4\u02B5\u02C1\u02B3\u02BA\u02BD\u02BA\u02BB.Count > 1)
		{
			return this.\u02B3\u02B9\u02B6\u02B4\u02B5\u02C1\u02B3\u02BA\u02BD\u02BA\u02BB.Dequeue();
		}
		if (this.\u02B5\u02BA\u02BB\u02B8\u02BA\u02BA\u02B8\u02B3\u02BE\u02B2\u02BB < this.\u02B3\u02B7\u02B9\u02BC\u02BE\u02B5\u02B8\u02BE\u02B4\u02BA\u02BC)
		{
			this.\u02B5\u02BA\u02BB\u02B8\u02BA\u02BA\u02B8\u02B3\u02BE\u02B2\u02BB++;
			VideoPlayer videoPlayer = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.gameObject.AddComponent<VideoPlayer>();
			this.\u02C0\u02BA\u02B8\u02C1\u02BB\u02BE\u02B9\u02B6\u02BF\u02B6\u02B5.Enqueue(videoPlayer);
			return videoPlayer;
		}
		return null;
	}

	// Token: 0x17000237 RID: 567
	// (get) Token: 0x06001746 RID: 5958 RVA: 0x000120C3 File Offset: 0x000102C3
	public static ThumbnailCache \u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7
	{
		get
		{
			if (ThumbnailCache.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9 == null && !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.TryGetComponent<ThumbnailCache>(out ThumbnailCache.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9))
			{
				ThumbnailCache.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.gameObject.AddComponent<ThumbnailCache>();
			}
			return ThumbnailCache.\u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9;
		}
	}

	// Token: 0x06001747 RID: 5959 RVA: 0x00012081 File Offset: 0x00010281
	private IEnumerator \u02BC\u02BC\u02B9\u02B9\u02C1\u02B9\u02BD\u02B2\u02BB\u02BE\u02BB(string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB, byte[] \u02BF\u02B4\u02BA\u02BC\u02BA\u02BC\u02B2\u02B9\u02B3\u02B7\u02B4, bool \u02BB\u02B2\u02C0\u02B3\u02C0\u02BF\u02B8\u02B2\u02B8\u02BD\u02B9 = false, bool \u02BE\u02B5\u02BE\u02BE\u02B9\u02B4\u02BA\u02B2\u02B8\u02B3\u02BE = false)
	{
		ThumbnailCache.\u02BA\u02BA\u02B5\u02BE\u02C1\u02BD\u02B3\u02B5\u02C1\u02B8\u02BF u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF = new ThumbnailCache.\u02BA\u02BA\u02B5\u02BE\u02C1\u02BD\u02B3\u02B5\u02C1\u02B8\u02BF(1);
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.<>4__this = this;
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.filePath = \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB;
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.imageBytes = \u02BF\u02B4\u02BA\u02BC\u02BA\u02BC\u02B2\u02B9\u02B3\u02B7\u02B4;
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.includeFramePauses = \u02BB\u02B2\u02C0\u02B3\u02C0\u02BF\u02B8\u02B2\u02B8\u02BD\u02B9;
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.returnBytesToPool = \u02BE\u02B5\u02BE\u02BE\u02B9\u02B4\u02BA\u02B2\u02B8\u02B3\u02BE;
		return u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF;
	}

	// Token: 0x06001748 RID: 5960 RVA: 0x000B0A30 File Offset: 0x000AEC30
	private void \u02C0\u02C0\u02BE\u02C1\u02B9\u02B8\u02B9\u02B3\u02BB\u02BC\u02B8(VideoPlayer \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7, long \u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF)
	{
		if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.texture != null && !\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.isPaused && \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.frame <= 1L)
		{
			\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.Pause();
			\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.sendFrameReadyEvents = false;
			Debug.Log(string.Format("Queue {0} {1}", \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.url, \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.texture));
			this.\u02B9\u02B8\u02B9\u02C1\u02B5\u02B9\u02B7\u02BC\u02BB\u02BD\u02B4.Enqueue(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7);
		}
	}

	// Token: 0x06001749 RID: 5961 RVA: 0x000120FC File Offset: 0x000102FC
	public IEnumerator \u02B9\u02B2\u02B6\u02B6\u02BC\u02B3\u02B9\u02BD\u02B7\u02BF\u02B5(VideoClip[] \u02C0\u02B6\u02BF\u02BB\u02BA\u02C0\u02C1\u02C1\u02BE\u02B4\u02B6)
	{
		foreach (VideoClip clip in \u02C0\u02B6\u02BF\u02BB\u02BA\u02C0\u02C1\u02C1\u02BE\u02B4\u02B6)
		{
			if (!File.Exists(ThumbnailCache.\u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(clip.originalPath)))
			{
				while (!this.\u02BB\u02BC\u02B7\u02B3\u02BC\u02B6\u02B9\u02BC\u02BF\u02C0\u02BB(clip))
				{
					yield return null;
				}
				clip = null;
			}
		}
		VideoClip[] array = null;
		yield break;
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x000B09CC File Offset: 0x000AEBCC
	private VideoPlayer \u02B3\u02BB\u02B3\u02BA\u02B2\u02B2\u02B6\u02B9\u02BF\u02B3\u02B6()
	{
		if (this.\u02B3\u02B9\u02B6\u02B4\u02B5\u02C1\u02B3\u02BA\u02BD\u02BA\u02BB.Count > 1)
		{
			return this.\u02B3\u02B9\u02B6\u02B4\u02B5\u02C1\u02B3\u02BA\u02BD\u02BA\u02BB.Dequeue();
		}
		if (this.\u02B5\u02BA\u02BB\u02B8\u02BA\u02BA\u02B8\u02B3\u02BE\u02B2\u02BB < this.\u02B3\u02B7\u02B9\u02BC\u02BE\u02B5\u02B8\u02BE\u02B4\u02BA\u02BC)
		{
			this.\u02B5\u02BA\u02BB\u02B8\u02BA\u02BA\u02B8\u02B3\u02BE\u02B2\u02BB++;
			VideoPlayer videoPlayer = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.gameObject.AddComponent<VideoPlayer>();
			this.\u02C0\u02BA\u02B8\u02C1\u02BB\u02BE\u02B9\u02B6\u02BF\u02B6\u02B5.Enqueue(videoPlayer);
			return videoPlayer;
		}
		return null;
	}

	// Token: 0x0600174B RID: 5963 RVA: 0x00012112 File Offset: 0x00010312
	private void \u02B9\u02B7\u02BE\u02BD\u02B3\u02B9\u02BC\u02B9\u02B5\u02BC\u02C1(VideoPlayer \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		Debug.Log("Offset" + \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.url);
		if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.isPlaying)
		{
			\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.Stop();
		}
		this.\u02B3\u02B9\u02B6\u02B4\u02B5\u02C1\u02B3\u02BA\u02BD\u02BA\u02BB.Enqueue(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7);
	}

	// Token: 0x0600174C RID: 5964 RVA: 0x00012143 File Offset: 0x00010343
	private void \u02BC\u02B9\u02B5\u02BD\u02B9\u02BE\u02BC\u02B7\u02C0\u02B7\u02B6(VideoPlayer \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7)
	{
		Debug.Log("Return videoplayer " + \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.url);
		if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.isPlaying)
		{
			\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.Stop();
		}
		this.\u02B3\u02B9\u02B6\u02B4\u02B5\u02C1\u02B3\u02BA\u02BD\u02BA\u02BB.Enqueue(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7);
	}

	// Token: 0x0600174D RID: 5965 RVA: 0x00012174 File Offset: 0x00010374
	public IEnumerator \u02B8\u02B5\u02B2\u02BD\u02BA\u02C1\u02BC\u02B8\u02B4\u02B4\u02BE(string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)
	{
		ThumbnailCache.\u02C0\u02B4\u02B4\u02BB\u02B5\u02BA\u02BA\u02B7\u02B9\u02C0\u02B6 u02C0_u02B4_u02B4_u02BB_u02B5_u02BA_u02BA_u02B7_u02B9_u02C0_u02B = new ThumbnailCache.\u02C0\u02B4\u02B4\u02BB\u02B5\u02BA\u02BA\u02B7\u02B9\u02C0\u02B6(1);
		u02C0_u02B4_u02B4_u02BB_u02B5_u02BA_u02BA_u02B7_u02B9_u02C0_u02B.<>4__this = this;
		u02C0_u02B4_u02B4_u02BB_u02B5_u02BA_u02BA_u02B7_u02B9_u02C0_u02B.filePath = \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB;
		return u02C0_u02B4_u02B4_u02BB_u02B5_u02BA_u02BA_u02B7_u02B9_u02C0_u02B;
	}

	// Token: 0x0600174E RID: 5966 RVA: 0x0001218A File Offset: 0x0001038A
	public IEnumerator \u02B5\u02BF\u02B4\u02BF\u02B6\u02B6\u02BE\u02B5\u02C0\u02B4\u02B9(string[] \u02BF\u02B8\u02B8\u02B8\u02B5\u02BC\u02B7\u02C0\u02B9\u02B5\u02B6, VideoClip[] \u02C0\u02B6\u02BF\u02BB\u02BA\u02C0\u02C1\u02C1\u02BE\u02B4\u02B6)
	{
		Debug.Log("Starting video thumbs");
		this.\u02B3\u02B2\u02B6\u02B9\u02B6\u02B4\u02C0\u02C0\u02B6\u02B8\u02BB = \u02BF\u02B8\u02B8\u02B8\u02B5\u02BC\u02B7\u02C0\u02B9\u02B5\u02B6.Length + \u02C0\u02B6\u02BF\u02BB\u02BA\u02C0\u02C1\u02C1\u02BE\u02B4\u02B6.Length;
		Coroutine process = base.StartCoroutine(this.\u02B6\u02B3\u02B6\u02B8\u02C0\u02B6\u02B8\u02BB\u02B2\u02B6\u02B5());
		yield return this.\u02BD\u02B9\u02BD\u02B9\u02BB\u02B7\u02B7\u02BD\u02B6\u02C0\u02B6(\u02BF\u02B8\u02B8\u02B8\u02B5\u02BC\u02B7\u02C0\u02B9\u02B5\u02B6);
		yield return this.\u02B9\u02B2\u02B6\u02B6\u02BC\u02B3\u02B9\u02BD\u02B7\u02BF\u02B5(\u02C0\u02B6\u02BF\u02BB\u02BA\u02C0\u02C1\u02C1\u02BE\u02B4\u02B6);
		yield return process;
		this.\u02B4\u02BB\u02B3\u02B5\u02B3\u02B4\u02BF\u02BE\u02BC\u02B3\u02B5();
		while (!this.\u02B5\u02BE\u02C1\u02B6\u02BC\u02B5\u02B4\u02C1\u02BE\u02BE\u02B5)
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x0600174F RID: 5967 RVA: 0x000121A7 File Offset: 0x000103A7
	public void \u02B4\u02BB\u02B3\u02B5\u02B3\u02B4\u02BF\u02BE\u02BC\u02B3\u02B5()
	{
		this.\u02BC\u02B5\u02B3\u02BB\u02B4\u02BA\u02C0\u02B2\u02B7\u02B2\u02B2 = false;
	}

	// Token: 0x06001750 RID: 5968 RVA: 0x000B0A94 File Offset: 0x000AEC94
	public void \u02B2\u02C1\u02BC\u02B7\u02B4\u02B7\u02B8\u02BF\u02B2\u02B7\u02B6(VideoPlayer \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7, string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC)
	{
		if (this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA == null)
		{
			this.\u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA = new Texture2D(1, 1, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None);
		}
		if (this.\u02BE\u02C1\u02B5\u02B8\u02B8\u02C0\u02B6\u02B7\u02B9\u02BF\u02B8 == null)
		{
			this.\u02BE\u02C1\u02B5\u02B8\u02B8\u02C0\u02B6\u02B7\u02B9\u02BF\u02B8 = new Texture2D(1, 1, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None);
		}
		Debug.Log(string.Format("Process {0} {1}", \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.url, \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.texture));
		float num = (float)\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.texture.width / (float)\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.texture.height;
		int num2 = ((num > 1f) ? 128 : ((int)(128f * num)));
		int num3 = ((num > 1f) ? ((int)(128f * (1f / num))) : 128);
		RenderTexture temporary = RenderTexture.GetTemporary(num2, num3, 0, GraphicsFormat.R8G8B8A8_SRGB);
		Graphics.Blit(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.texture, temporary);
		RenderTexture.active = temporary;
		Texture2D texture2D;
		if (this.\u02BE\u02C1\u02B5\u02B8\u02B8\u02C0\u02B6\u02B7\u02B9\u02BF\u02B8.Reinitialize(num2, num3, GraphicsFormat.R8G8B8A8_SRGB, false))
		{
			texture2D = this.\u02BE\u02C1\u02B5\u02B8\u02B8\u02C0\u02B6\u02B7\u02B9\u02BF\u02B8;
		}
		else
		{
			texture2D = new Texture2D(num2, num3, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None);
		}
		texture2D.ReadPixels(new Rect(0f, 0f, (float)temporary.width, (float)temporary.height), 0, 0);
		texture2D.Apply(true);
		byte[] array = texture2D.EncodeToPNG();
		RenderTexture.ReleaseTemporary(temporary);
		string text = ThumbnailCache.\u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC);
		this.\u02B2\u02B8\u02BA\u02BB\u02BC\u02BA\u02BF\u02B8\u02B5\u02B5\u02BC.Add(new ValueTuple<string, byte[]>(text, array));
	}

	// Token: 0x06001751 RID: 5969 RVA: 0x000121B0 File Offset: 0x000103B0
	public IEnumerator \u02C0\u02C0\u02BA\u02C0\u02BA\u02B6\u02B3\u02B3\u02B8\u02C1\u02BC(string[] \u02BF\u02B8\u02B8\u02B8\u02B5\u02BC\u02B7\u02C0\u02B9\u02B5\u02B6)
	{
		foreach (string filePath in \u02BF\u02B8\u02B8\u02B8\u02B5\u02BC\u02B7\u02C0\u02B9\u02B5\u02B6)
		{
			if (!File.Exists(ThumbnailCache.\u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(filePath)))
			{
				Debug.Log("Loading " + filePath);
				while (!this.\u02BB\u02BC\u02B7\u02B3\u02BC\u02B6\u02B9\u02BC\u02BF\u02C0\u02BB(filePath))
				{
					yield return null;
				}
				filePath = null;
			}
		}
		string[] array = null;
		yield break;
	}

	// Token: 0x06001752 RID: 5970 RVA: 0x000B0BE4 File Offset: 0x000AEDE4
	private void \u02BF\u02BD\u02B4\u02B4\u02B7\u02BF\u02BC\u02B8\u02BE\u02BA\u02B7()
	{
		while (this.\u02BC\u02B5\u02B3\u02BB\u02B4\u02BA\u02C0\u02B2\u02B7\u02B2\u02B2 || this.\u02B2\u02B8\u02BA\u02BB\u02BC\u02BA\u02BF\u02B8\u02B5\u02B5\u02BC.Count > 0)
		{
			ValueTuple<string, byte[]> valueTuple;
			while (this.\u02B2\u02B8\u02BA\u02BB\u02BC\u02BA\u02BF\u02B8\u02B5\u02B5\u02BC.TryTake(out valueTuple))
			{
				if (!File.Exists(valueTuple.Item1))
				{
					File.WriteAllBytes(valueTuple.Item1, valueTuple.Item2);
				}
			}
		}
		this.\u02B5\u02BE\u02C1\u02B6\u02BC\u02B5\u02B4\u02C1\u02BE\u02BE\u02B5 = true;
	}

	// Token: 0x06001753 RID: 5971 RVA: 0x000121C6 File Offset: 0x000103C6
	internal static string \u02BA\u02B8\u02B9\u02B2\u02B7\u02B8\u02B5\u02B8\u02B6\u02C1\u02B3(string \u02BB\u02C0\u02BF\u02B2\u02B8\u02BF\u02B8\u02B5\u02C0\u02BA\u02C1)
	{
		return string.Format("Save Setlist", ThumbnailCache.\u02B8\u02C1\u02C1\u02BB\u02B6\u02B7\u02C1\u02BE\u02BA\u02B6\u02B6, Path.DirectorySeparatorChar, \u02BB\u02C0\u02BF\u02B2\u02B8\u02BF\u02B8\u02B5\u02C0\u02BA\u02C1.GetHashCode());
	}

	// Token: 0x06001754 RID: 5972 RVA: 0x000121B0 File Offset: 0x000103B0
	public IEnumerator \u02BD\u02B9\u02BD\u02B9\u02BB\u02B7\u02B7\u02BD\u02B6\u02C0\u02B6(string[] \u02BF\u02B8\u02B8\u02B8\u02B5\u02BC\u02B7\u02C0\u02B9\u02B5\u02B6)
	{
		array = \u02BF\u02B8\u02B8\u02B8\u02B5\u02BC\u02B7\u02C0\u02B9\u02B5\u02B6;
		for (i = 0; i < array.Length; i++)
		{
			filePath = array[i];
			if (!File.Exists(ThumbnailCache.\u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(filePath)))
			{
				Debug.Log("Loading " + filePath);
				while (!this.\u02BB\u02BC\u02B7\u02B3\u02BC\u02B6\u02B9\u02BC\u02BF\u02C0\u02BB(filePath))
				{
					yield return null;
				}
				filePath = null;
			}
		}
		array = null;
		yield break;
	}

	// Token: 0x06001756 RID: 5974 RVA: 0x000B0C40 File Offset: 0x000AEE40
	private bool \u02BB\u02BC\u02B7\u02B3\u02BC\u02B6\u02B9\u02BC\u02BF\u02C0\u02BB(VideoClip \u02B7\u02BA\u02B7\u02BB\u02B7\u02B2\u02BA\u02B3\u02B4\u02BE\u02BA)
	{
		VideoPlayer videoPlayer = this.\u02B3\u02BB\u02B3\u02BA\u02B2\u02B2\u02B6\u02B9\u02BF\u02B3\u02B6();
		if (videoPlayer == null)
		{
			return false;
		}
		videoPlayer.renderMode = VideoRenderMode.APIOnly;
		videoPlayer.audioOutputMode = VideoAudioOutputMode.None;
		videoPlayer.clip = \u02B7\u02BA\u02B7\u02BB\u02B7\u02B2\u02BA\u02B3\u02B4\u02BE\u02BA;
		videoPlayer.isLooping = false;
		videoPlayer.waitForFirstFrame = true;
		videoPlayer.sendFrameReadyEvents = true;
		videoPlayer.playOnAwake = false;
		videoPlayer.frameReady += this.\u02C0\u02C0\u02BE\u02C1\u02B9\u02B8\u02B9\u02B3\u02BB\u02BC\u02B8;
		videoPlayer.Prepare();
		return true;
	}

	// Token: 0x06001757 RID: 5975 RVA: 0x00012202 File Offset: 0x00010402
	internal static string \u02B9\u02C1\u02BC\u02B4\u02B3\u02C1\u02B7\u02BF\u02B8\u02BC\u02BC(string \u02BB\u02C0\u02BF\u02B2\u02B8\u02BF\u02B8\u02B5\u02C0\u02BA\u02C1)
	{
		return string.Format("{0}{1}{2}.png", ThumbnailCache.\u02B8\u02C1\u02C1\u02BB\u02B6\u02B7\u02C1\u02BE\u02BA\u02B6\u02B6, Path.DirectorySeparatorChar, \u02BB\u02C0\u02BF\u02B2\u02B8\u02BF\u02B8\u02B5\u02C0\u02BA\u02C1.GetHashCode());
	}

	// Token: 0x06001758 RID: 5976 RVA: 0x000B0CAC File Offset: 0x000AEEAC
	private bool \u02BB\u02BC\u02B7\u02B3\u02BC\u02B6\u02B9\u02BC\u02BF\u02C0\u02BB(string \u02C0\u02BD\u02C0\u02B7\u02BA\u02B7\u02BE\u02BA\u02B9\u02BA\u02B9)
	{
		VideoPlayer videoPlayer = this.\u02B3\u02BB\u02B3\u02BA\u02B2\u02B2\u02B6\u02B9\u02BF\u02B3\u02B6();
		if (videoPlayer == null)
		{
			return false;
		}
		videoPlayer.renderMode = VideoRenderMode.APIOnly;
		videoPlayer.audioOutputMode = VideoAudioOutputMode.None;
		videoPlayer.url = \u02C0\u02BD\u02C0\u02B7\u02BA\u02B7\u02BE\u02BA\u02B9\u02BA\u02B9;
		videoPlayer.isLooping = false;
		videoPlayer.waitForFirstFrame = true;
		videoPlayer.sendFrameReadyEvents = true;
		videoPlayer.frameReady += this.\u02C0\u02C0\u02BE\u02C1\u02B9\u02B8\u02B9\u02B3\u02BB\u02BC\u02B8;
		videoPlayer.Prepare();
		return true;
	}

	// Token: 0x06001759 RID: 5977 RVA: 0x000B0D10 File Offset: 0x000AEF10
	private byte[] \u02B8\u02BB\u02B3\u02B9\u02BE\u02C1\u02C1\u02B8\u02BD\u02B4\u02B9(string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)
	{
		if (File.Exists(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB))
		{
			using (FileStream fileStream = File.Open(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB, FileMode.Open, FileAccess.Read))
			{
				int num = (int)fileStream.Length;
				byte[] array = ArrayPool<byte>.Shared.Rent(num);
				fileStream.Read(array, 0, num);
				return array;
			}
		}
		return null;
	}

	// Token: 0x0600175A RID: 5978 RVA: 0x000B0D70 File Offset: 0x000AEF70
	public void \u02B8\u02B9\u02B9\u02BD\u02B2\u02B8\u02B9\u02B7\u02BC\u02B4\u02B6(string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB)
	{
		byte[] array = this.\u02B8\u02BB\u02B3\u02B9\u02BE\u02C1\u02C1\u02B8\u02BD\u02B4\u02B9(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB);
		base.StartCoroutine(this.\u02B7\u02B9\u02BF\u02B4\u02B4\u02BE\u02C1\u02C1\u02B9\u02C1\u02BD(\u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB, array, false, true));
	}

	// Token: 0x0600175B RID: 5979 RVA: 0x00012081 File Offset: 0x00010281
	private IEnumerator \u02B9\u02BF\u02B9\u02B5\u02B6\u02BA\u02BA\u02BA\u02BC\u02B5\u02C1(string \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB, byte[] \u02BF\u02B4\u02BA\u02BC\u02BA\u02BC\u02B2\u02B9\u02B3\u02B7\u02B4, bool \u02BB\u02B2\u02C0\u02B3\u02C0\u02BF\u02B8\u02B2\u02B8\u02BD\u02B9 = false, bool \u02BE\u02B5\u02BE\u02BE\u02B9\u02B4\u02BA\u02B2\u02B8\u02B3\u02BE = false)
	{
		ThumbnailCache.\u02BA\u02BA\u02B5\u02BE\u02C1\u02BD\u02B3\u02B5\u02C1\u02B8\u02BF u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF = new ThumbnailCache.\u02BA\u02BA\u02B5\u02BE\u02C1\u02BD\u02B3\u02B5\u02C1\u02B8\u02BF(1);
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.<>4__this = this;
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.filePath = \u02BD\u02C1\u02B3\u02B8\u02B5\u02B6\u02B5\u02B6\u02BA\u02B8\u02BB;
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.imageBytes = \u02BF\u02B4\u02BA\u02BC\u02BA\u02BC\u02B2\u02B9\u02B3\u02B7\u02B4;
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.includeFramePauses = \u02BB\u02B2\u02C0\u02B3\u02C0\u02BF\u02B8\u02B2\u02B8\u02BD\u02B9;
		u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF.returnBytesToPool = \u02BE\u02B5\u02BE\u02BE\u02B9\u02B4\u02BA\u02B2\u02B8\u02B3\u02BE;
		return u02BA_u02BA_u02B5_u02BE_u02C1_u02BD_u02B3_u02B5_u02C1_u02B8_u02BF;
	}

	// Token: 0x040010B4 RID: 4276
	private int \u02B5\u02BA\u02BB\u02B8\u02BA\u02BA\u02B8\u02B3\u02BE\u02B2\u02BB;

	// Token: 0x040010B5 RID: 4277
	private int \u02B3\u02B7\u02B9\u02BC\u02BE\u02B5\u02B8\u02BE\u02B4\u02BA\u02BC = 5;

	// Token: 0x040010B6 RID: 4278
	private Queue<VideoPlayer> \u02C0\u02BA\u02B8\u02C1\u02BB\u02BE\u02B9\u02B6\u02BF\u02B6\u02B5 = new Queue<VideoPlayer>();

	// Token: 0x040010B7 RID: 4279
	private Queue<VideoPlayer> \u02B3\u02B9\u02B6\u02B4\u02B5\u02C1\u02B3\u02BA\u02BD\u02BA\u02BB = new Queue<VideoPlayer>();

	// Token: 0x040010B8 RID: 4280
	private static ThumbnailCache \u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9;

	// Token: 0x040010B9 RID: 4281
	private static readonly string \u02B8\u02C1\u02C1\u02BB\u02B6\u02B7\u02C1\u02BE\u02BA\u02B6\u02B6 = Path.Combine(Application.persistentDataPath, "cached-thumbs");

	// Token: 0x040010BA RID: 4282
	private Thread \u02BA\u02BB\u02C0\u02BB\u02C1\u02B2\u02B7\u02C0\u02BC\u02BB\u02BD;

	// Token: 0x040010BB RID: 4283
	private bool \u02BC\u02B5\u02B3\u02BB\u02B4\u02BA\u02C0\u02B2\u02B7\u02B2\u02B2;

	// Token: 0x040010BC RID: 4284
	private bool \u02B5\u02BE\u02C1\u02B6\u02BC\u02B5\u02B4\u02C1\u02BE\u02BE\u02B5;

	// Token: 0x040010BD RID: 4285
	private Queue<VideoPlayer> \u02B9\u02B8\u02B9\u02C1\u02B5\u02B9\u02B7\u02BC\u02BB\u02BD\u02B4 = new Queue<VideoPlayer>();

	// Token: 0x040010BE RID: 4286
	[TupleElementNames(new string[] { "fileName", "fileData" })]
	private ConcurrentBag<ValueTuple<string, byte[]>> \u02B2\u02B8\u02BA\u02BB\u02BC\u02BA\u02BF\u02B8\u02B5\u02B5\u02BC = new ConcurrentBag<ValueTuple<string, byte[]>>();

	// Token: 0x040010BF RID: 4287
	private WaitForEndOfFrame \u02B2\u02B3\u02BA\u02B6\u02B5\u02B3\u02B9\u02B2\u02C0\u02C0\u02BA = new WaitForEndOfFrame();

	// Token: 0x040010C0 RID: 4288
	private Texture2D \u02BF\u02B5\u02BC\u02BF\u02B3\u02B9\u02B9\u02BB\u02C1\u02B8\u02BA;

	// Token: 0x040010C1 RID: 4289
	private Texture2D \u02BE\u02C1\u02B5\u02B8\u02B8\u02C0\u02B6\u02B7\u02B9\u02BF\u02B8;

	// Token: 0x040010C2 RID: 4290
	private int \u02B8\u02BD\u02C0\u02B4\u02C1\u02BC\u02B5\u02C1\u02BB\u02C0\u02BF;

	// Token: 0x040010C3 RID: 4291
	private int \u02B3\u02B2\u02B6\u02B9\u02B6\u02B4\u02C0\u02C0\u02B6\u02B8\u02BB;

	// Token: 0x02000206 RID: 518
	[CompilerGenerated]
	private sealed class \u02BB\u02BA\u02BA\u02BB\u02BF\u02B3\u02B7\u02B8\u02B4\u02B3\u02BB
	{
		// Token: 0x0600175D RID: 5981 RVA: 0x00012228 File Offset: 0x00010428
		internal byte[] \u02BD\u02B8\u02C0\u02B9\u02B4\u02BF\u02B5\u02B6\u02BA\u02B7\u02BA()
		{
			return this.<>4__this.\u02B8\u02BB\u02B3\u02B9\u02BE\u02C1\u02C1\u02B8\u02BD\u02B4\u02B9(this.filePath);
		}

		// Token: 0x040010C4 RID: 4292
		public ThumbnailCache <>4__this;

		// Token: 0x040010C5 RID: 4293
		public string filePath;
	}
}
