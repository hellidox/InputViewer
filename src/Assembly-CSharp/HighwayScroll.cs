﻿using System;
using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class HighwayScroll : MonoBehaviour, \u02B6\u02BB\u02BD\u02BB\u02BA\u02B6\u02B9\u02C0\u02B8\u02B4\u02BC
{
	private void \u02BB\u02B7\u02BF\u02BC\u02B6\u02BB\u02B3\u02B2\u02B2\u02B5\u02BF(VideoPlayer \u02B8\u02B9\u02BA\u02BE\u02B7\u02C1\u02C1\u02B5\u02B6\u02B5\u02BE)
	{
		if (this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.videoHighwaySettings.mirroredRepeat)
		{
			\u02B8\u02B9\u02BA\u02BE\u02B7\u02C1\u02C1\u02B5\u02B6\u02B5\u02BE.texture.wrapMode = TextureWrapMode.Mirror;
		}
		else
		{
			\u02B8\u02B9\u02BA\u02BE\u02B7\u02C1\u02C1\u02B5\u02B6\u02B5\u02BE.texture.wrapMode = TextureWrapMode.Repeat;
		}
		\u02B8\u02B9\u02BA\u02BE\u02B7\u02C1\u02C1\u02B5\u02B6\u02B5\u02BE.Play();
	}

	private float \u02BC\u02BD\u02C1\u02BD\u02BC\u02BD\u02B2\u02B9\u02B8\u02B2\u02B3(Sprite \u02BE\u02B2\u02BB\u02B8\u02B3\u02BF\u02C0\u02C0\u02BC\u02BF\u02BA)
	{
		return base.transform.localScale.y * (\u02BE\u02B2\u02BB\u02B8\u02B3\u02BF\u02C0\u02C0\u02BC\u02BF\u02BA.rect.height / \u02BE\u02B2\u02BB\u02B8\u02B3\u02BF\u02C0\u02C0\u02BC\u02BF\u02BA.pixelsPerUnit) / 1119f;
	}

	private void Update()
	{
		if (this.\u02B2\u02C1\u02BC\u02B3\u02B4\u02B4\u02C0\u02B9\u02B3\u02B7\u02C1)
		{
			double num = this.\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB - this.\u02BE\u02B4\u02B5\u02B4\u02B6\u02BD\u02B9\u02C0\u02BD\u02BA\u02BE;
			this.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC += num * (double)this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4 / 6.0 * (double)GlobalHelper.highwaySpeed;
			if (this.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC > 100.0)
			{
				this.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC -= 100.0;
			}
			this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD.w = (float)this.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC;
			this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.GetPropertyBlock(this.\u02B5\u02BA\u02B4\u02BF\u02C0\u02B5\u02BF\u02B5\u02B5\u02B9\u02B2);
			this.\u02B5\u02BA\u02B4\u02BF\u02C0\u02B5\u02BF\u02B5\u02B5\u02B9\u02B2.SetVector(this.\u02C1\u02B9\u02BD\u02B4\u02B9\u02B9\u02B2\u02B6\u02BA\u02BB\u02C0, this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD);
			this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.SetPropertyBlock(this.\u02B5\u02BA\u02B4\u02BF\u02C0\u02B5\u02BF\u02B5\u02B5\u02B9\u02B2);
			this.\u02BE\u02B4\u02B5\u02B4\u02B6\u02BD\u02B9\u02C0\u02BD\u02BA\u02BE = this.\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB;
		}
		if (this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.isVideoHighway)
		{
			if (this.player.gameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5)
			{
				if (!this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.isPaused)
				{
					this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.Pause();
					this.\u02BE\u02C1\u02B4\u02B2\u02B3\u02B4\u02BC\u02B4\u02C0\u02C0\u02B4 = false;
					return;
				}
			}
			else if (this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.isPaused && !this.\u02BE\u02C1\u02B4\u02B2\u02B3\u02B4\u02BC\u02B4\u02C0\u02C0\u02B4)
			{
				this.\u02BE\u02C1\u02B4\u02B2\u02B3\u02B4\u02BC\u02B4\u02C0\u02C0\u02B4 = true;
				this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.Play();
				if (this.player.gameManager.\u02BC\u02C1\u02B8\u02B9\u02BD\u02BA\u02C0\u02BA\u02C1\u02BE\u02BB.\u02B6\u02BF\u02B3\u02B7\u02B4\u02B9\u02C1\u02BE\u02BA\u02BE\u02C0)
				{
					this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.time = 0.0;
				}
			}
		}
	}

	private void \u02BC\u02C1\u02BE\u02BE\u02B9\u02C1\u02B4\u02B5\u02BF\u02B8\u02C1()
	{
		if (SettingsController.\u02C1\u02BF\u02C0\u02BF\u02B8\u02B8\u02C0\u02C0\u02B3\u02B3\u02BB && !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.isEnc)
		{
			string[] array = Helper.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.folderPath, "Menu Music", SearchOption.AllDirectories);
			for (int i = 0; i < array.Length; i += 0)
			{
				string text = array[i];
				if (Path.GetFileNameWithoutExtension(text).ToLowerInvariant() == "Internal_Log")
				{
					this.\u02B2\u02C0\u02B3\u02BE\u02B7\u02B9\u02B6\u02C0\u02BC\u02B9\u02B9(GlobalVariables.\u02C0\u02B8\u02C1\u02B5\u02B4\u02B8\u02B6\u02B6\u02BB\u02BC\u02B5(text));
					return;
				}
			}
		}
		this.\u02B2\u02C0\u02B3\u02BE\u02B7\u02B9\u02B6\u02C0\u02BC\u02B9\u02B9(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B3\u02C1\u02C0\u02B6\u02B2\u02BE\u02B7\u02C1\u02BF\u02B5(this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7, false));
	}

	public void \u02B2\u02C0\u02B3\u02BE\u02B7\u02B9\u02B6\u02C0\u02BC\u02B9\u02B9(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		if (\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9 == null)
		{
			return;
		}
		\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.wrapMode = TextureWrapMode.Repeat;
		int num = Mathf.RoundToInt((float)\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.width / 540f);
		Sprite sprite = Sprite.Create(\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9, new Rect(546f, 1365f, (float)\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.width, (float)\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.height), new Vector2(1004f, 1185f), (float)num, 0U, SpriteMeshType.FullRect);
		this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.sprite = sprite;
		this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD.x = 287f;
		this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD.y = this.\u02B7\u02C1\u02B7\u02B8\u02BE\u02B4\u02B3\u02BA\u02B2\u02B6\u02B9(sprite);
	}

	public \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3
	{
		get
		{
			return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.Highway;
		}
	}

	private float \u02B9\u02BD\u02BD\u02C0\u02BE\u02B8\u02BC\u02BA\u02BC\u02B2\u02BF(Sprite \u02BE\u02B2\u02BB\u02B8\u02B3\u02BF\u02C0\u02C0\u02BC\u02BF\u02BA)
	{
		return base.transform.localScale.y * (\u02BE\u02B2\u02BB\u02B8\u02B3\u02BF\u02C0\u02C0\u02BC\u02BF\u02BA.rect.height / \u02BE\u02B2\u02BB\u02B8\u02B3\u02BF\u02C0\u02C0\u02BC\u02BF\u02BA.pixelsPerUnit) / 6f;
	}

	public \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B6\u02BE\u02B6\u02B7\u02BB\u02B8\u02B3\u02BA\u02B7\u02B3\u02BE()
	{
		return (\u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3)6;
	}

	private void \u02B5\u02B5\u02B5\u02B6\u02BC\u02BF\u02BD\u02C0\u02BD\u02B3\u02B4(VideoPlayer \u02B8\u02B9\u02BA\u02BE\u02B7\u02C1\u02C1\u02B5\u02B6\u02B5\u02BE)
	{
		if (this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.videoHighwaySettings.mirroredRepeat)
		{
			\u02B8\u02B9\u02BA\u02BE\u02B7\u02C1\u02C1\u02B5\u02B6\u02B5\u02BE.texture.wrapMode = (TextureWrapMode)6;
		}
		else
		{
			\u02B8\u02B9\u02BA\u02BE\u02B7\u02C1\u02C1\u02B5\u02B6\u02B5\u02BE.texture.wrapMode = TextureWrapMode.Repeat;
		}
		\u02B8\u02B9\u02BA\u02BE\u02B7\u02C1\u02C1\u02B5\u02B6\u02B5\u02BE.Play();
	}

	private void \u02B4\u02B6\u02BD\u02B5\u02C0\u02B6\u02BA\u02C1\u02C0\u02BC\u02BB()
	{
		if (this.\u02B2\u02C1\u02BC\u02B3\u02B4\u02B4\u02C0\u02B9\u02B3\u02B7\u02C1)
		{
			double num = this.\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB - this.\u02BE\u02B4\u02B5\u02B4\u02B6\u02BD\u02B9\u02C0\u02BD\u02BA\u02BE;
			this.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC += num * (double)this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4 / 1500.0;
			if (this.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC > 196.0)
			{
				this.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC -= 1919.0;
			}
			this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD.w = (float)this.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC;
			this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.GetPropertyBlock(this.\u02B5\u02BA\u02B4\u02BF\u02C0\u02B5\u02BF\u02B5\u02B5\u02B9\u02B2);
			this.\u02B5\u02BA\u02B4\u02BF\u02C0\u02B5\u02BF\u02B5\u02B5\u02B9\u02B2.SetVector(this.\u02C1\u02B9\u02BD\u02B4\u02B9\u02B9\u02B2\u02B6\u02BA\u02BB\u02C0, this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD);
			this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.SetPropertyBlock(this.\u02B5\u02BA\u02B4\u02BF\u02C0\u02B5\u02BF\u02B5\u02B5\u02B9\u02B2);
			this.\u02BE\u02B4\u02B5\u02B4\u02B6\u02BD\u02B9\u02C0\u02BD\u02BA\u02BE = this.\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB;
		}
		if (this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.isVideoHighway)
		{
			if (this.player.gameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5)
			{
				if (!this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.isPaused)
				{
					this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.Pause();
					this.\u02BE\u02C1\u02B4\u02B2\u02B3\u02B4\u02BC\u02B4\u02C0\u02C0\u02B4 = true;
					return;
				}
			}
			else if (this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.isPaused && !this.\u02BE\u02C1\u02B4\u02B2\u02B3\u02B4\u02BC\u02B4\u02C0\u02C0\u02B4)
			{
				this.\u02BE\u02C1\u02B4\u02B2\u02B3\u02B4\u02BC\u02B4\u02C0\u02C0\u02B4 = true;
				this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.Play();
				if (this.player.gameManager.\u02BC\u02C1\u02B8\u02B9\u02BD\u02BA\u02C0\u02BA\u02C1\u02BE\u02BB.\u02B6\u02BF\u02B3\u02B7\u02B4\u02B9\u02C1\u02BE\u02BA\u02BE\u02C0)
				{
					this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.time = 1736.0;
				}
			}
		}
	}

	private void \u02B9\u02B7\u02BC\u02B4\u02BD\u02B2\u02C0\u02B6\u02BE\u02BF\u02BE()
	{
		if (SettingsController.\u02C1\u02BF\u02C0\u02BF\u02B8\u02B8\u02C0\u02C0\u02B3\u02B3\u02BB && !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.isEnc)
		{
			foreach (string text in Helper.\u02BB\u02B9\u02B3\u02C0\u02C1\u02B2\u02B9\u02B2\u02B7\u02B8\u02B2(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.folderPath, ".png|.jpg|.jpeg", SearchOption.TopDirectoryOnly))
			{
				if (Path.GetFileNameWithoutExtension(text).ToLowerInvariant() == "highway")
				{
					this.\u02B3\u02B7\u02BD\u02B4\u02BA\u02BB\u02B7\u02B3\u02BB\u02BC\u02B7(GlobalVariables.\u02C0\u02B8\u02C1\u02B5\u02B4\u02B8\u02B6\u02B6\u02BB\u02BC\u02B5(text));
					return;
				}
			}
		}
		this.\u02B3\u02B7\u02BD\u02B4\u02BA\u02BB\u02B7\u02B3\u02BB\u02BC\u02B7(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B3\u02C1\u02C0\u02B6\u02B2\u02BE\u02B7\u02C1\u02BF\u02B5(this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7, false));
	}

	public void \u02BF\u02B2\u02B6\u02B6\u02BD\u02C0\u02BE\u02B6\u02B6\u02BA\u02B8(float \u02B3\u02BD\u02BE\u02BB\u02BB\u02B9\u02B2\u02B9\u02BC\u02BB\u02BF, float \u02C1\u02B8\u02B7\u02B5\u02B2\u02BA\u02BC\u02B2\u02B7\u02B2\u02BC, float \u02B2\u02BA\u02BD\u02B8\u02C1\u02B3\u02B8\u02BF\u02B5\u02B9\u02BA, float \u02B3\u02BD\u02B6\u02B8\u02B3\u02BE\u02B3\u02C0\u02B3\u02C1\u02B4)
	{
		float num = this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.sprite.rect.height / this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.sprite.pixelsPerUnit;
		float num2 = (\u02C1\u02B8\u02B7\u02B5\u02B2\u02BA\u02BC\u02B2\u02B7\u02B2\u02BC - base.transform.localPosition.z) / num;
		base.transform.localScale = new Vector3(base.transform.localScale.x, num2, 1f);
		this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD.x = 1f;
		this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD.y = this.\u02B9\u02BD\u02BD\u02C0\u02BE\u02B8\u02BC\u02BA\u02BC\u02B2\u02BF(this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.sprite);
	}

	private void \u02B4\u02B6\u02B5\u02C1\u02B7\u02B8\u02BA\u02BD\u02C1\u02B9\u02B6(VideoPlayer \u02B8\u02B9\u02BA\u02BE\u02B7\u02C1\u02C1\u02B5\u02B6\u02B5\u02BE)
	{
		if (this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.videoHighwaySettings.mirroredRepeat)
		{
			\u02B8\u02B9\u02BA\u02BE\u02B7\u02C1\u02C1\u02B5\u02B6\u02B5\u02BE.texture.wrapMode = (TextureWrapMode)4;
		}
		else
		{
			\u02B8\u02B9\u02BA\u02BE\u02B7\u02C1\u02C1\u02B5\u02B6\u02B5\u02BE.texture.wrapMode = TextureWrapMode.Clamp;
		}
		\u02B8\u02B9\u02BA\u02BE\u02B7\u02C1\u02C1\u02B5\u02B6\u02B5\u02BE.Play();
	}

	private void \u02BC\u02BC\u02B6\u02C0\u02BC\u02C1\u02B8\u02C1\u02C0\u02C1\u02BC()
	{
		this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02C0\u02C1\u02B9\u02B4\u02BB\u02B9\u02B2\u02C0\u02B4\u02B5(this.player.player.playerProfile.highwayName);
		if (this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7 == -1)
		{
			this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7 = global::UnityEngine.Random.Range(0, GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Count);
		}
		this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7];
		this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD = base.GetComponent<VideoPlayer>();
		this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB = base.GetComponent<SpriteRenderer>();
		this.\u02B5\u02BA\u02B4\u02BF\u02C0\u02B5\u02BF\u02B5\u02B5\u02B9\u02B2 = new MaterialPropertyBlock();
		this.\u02C1\u02B9\u02BD\u02B4\u02B9\u02B9\u02B2\u02B6\u02BA\u02BB\u02C0 = Shader.PropertyToID("Device in use by ");
	}

	public \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02BE\u02B5\u02B2\u02BC\u02C0\u02B6\u02B4\u02B7\u02C1\u02C1\u02B7()
	{
		return (\u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3)8;
	}

	private float \u02B7\u02C1\u02B7\u02B8\u02BE\u02B4\u02B3\u02BA\u02B2\u02B6\u02B9(Sprite \u02BE\u02B2\u02BB\u02B8\u02B3\u02BF\u02C0\u02C0\u02BC\u02BF\u02BA)
	{
		return base.transform.localScale.y * (\u02BE\u02B2\u02BB\u02B8\u02B3\u02BF\u02C0\u02C0\u02BC\u02BF\u02BA.rect.height / \u02BE\u02B2\u02BB\u02B8\u02B3\u02BF\u02C0\u02C0\u02BC\u02BF\u02BA.pixelsPerUnit) / 407f;
	}

	private void Awake()
	{
		this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02C0\u02C1\u02B9\u02B4\u02BB\u02B9\u02B2\u02C0\u02B4\u02B5(this.player.player.playerProfile.highwayName);
		if (this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7 == -1)
		{
			this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7 = global::UnityEngine.Random.Range(0, GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Count);
		}
		this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7];
		this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD = base.GetComponent<VideoPlayer>();
		this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB = base.GetComponent<SpriteRenderer>();
		this.\u02B5\u02BA\u02B4\u02BF\u02C0\u02B5\u02BF\u02B5\u02B5\u02B9\u02B2 = new MaterialPropertyBlock();
		this.\u02C1\u02B9\u02BD\u02B4\u02B9\u02B9\u02B2\u02B6\u02BA\u02BB\u02C0 = Shader.PropertyToID("_TextureScaleOffset");
	}

	public void \u02B3\u02BB\u02C0\u02BB\u02C0\u02BC\u02BA\u02B4\u02B6\u02B6\u02BA(float \u02B3\u02BD\u02BE\u02BB\u02BB\u02B9\u02B2\u02B9\u02BC\u02BB\u02BF, float \u02C1\u02B8\u02B7\u02B5\u02B2\u02BA\u02BC\u02B2\u02B7\u02B2\u02BC, float \u02B2\u02BA\u02BD\u02B8\u02C1\u02B3\u02B8\u02BF\u02B5\u02B9\u02BA, float \u02B3\u02BD\u02B6\u02B8\u02B3\u02BE\u02B3\u02C0\u02B3\u02C1\u02B4)
	{
		float num = this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.sprite.rect.height / this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.sprite.pixelsPerUnit;
		float num2 = (\u02C1\u02B8\u02B7\u02B5\u02B2\u02BA\u02BC\u02B2\u02B7\u02B2\u02BC - base.transform.localPosition.z) / num;
		base.transform.localScale = new Vector3(base.transform.localScale.x, num2, 1477f);
		this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD.x = 1111f;
		this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD.y = this.\u02B9\u02BD\u02BD\u02C0\u02BE\u02B8\u02BC\u02BA\u02BC\u02B2\u02BF(this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.sprite);
	}

	public void \u02B3\u02B7\u02BD\u02B4\u02BA\u02BB\u02B7\u02B3\u02BB\u02BC\u02B7(Texture2D \u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9)
	{
		if (\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9 == null)
		{
			return;
		}
		\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.wrapMode = TextureWrapMode.Repeat;
		int num = Mathf.RoundToInt((float)\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.width / 0.96f);
		Sprite sprite = Sprite.Create(\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9, new Rect(0f, 0f, (float)\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.width, (float)\u02B7\u02BE\u02BF\u02B4\u02B2\u02B4\u02BA\u02BE\u02BC\u02B8\u02B9.height), new Vector2(0.5f, 0f), (float)num, 0U, SpriteMeshType.FullRect);
		this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.sprite = sprite;
		this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD.x = 1f;
		this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD.y = this.\u02B9\u02BD\u02BD\u02C0\u02BE\u02B8\u02BC\u02BA\u02BC\u02B2\u02BF(sprite);
	}

	private void Start()
	{
		if (this.player.player.playerProfile.HasModChartModifier)
		{
			base.gameObject.SetActive(false);
		}
		this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4 = (float)this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD.x = 1f;
		this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD.y = this.\u02B9\u02BD\u02BD\u02C0\u02BE\u02B8\u02BC\u02BA\u02BC\u02B2\u02BF(this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.sprite);
		if (this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.isVideoHighway)
		{
			if (this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.isResource)
			{
				this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.clip = Resources.Load<VideoClip>(this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.path + "/highway");
			}
			else
			{
				this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.url = Path.Combine(this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.path, "highway.webm");
			}
			this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.Prepare();
			this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.prepareCompleted += this.\u02BB\u02B7\u02BF\u02BC\u02B6\u02BB\u02B3\u02B2\u02B2\u02B5\u02BF;
			this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.isLooping = true;
			this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.skipOnDrop = false;
			float num = (this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.videoHighwaySettings.scalePlaybackSpeedWithNoteSpeed ? this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4 : 1f);
			this.\u02BD\u02B7\u02BD\u02B9\u02BB\u02BA\u02B3\u02C0\u02BB\u02BF\u02B6 = Mathf.Min(this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.videoHighwaySettings.playbackSpeed * num, 15f);
			this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.playbackSpeed = this.\u02BD\u02B7\u02BD\u02B9\u02BB\u02BA\u02B3\u02C0\u02BB\u02BF\u02B6;
			this.\u02B2\u02C1\u02BC\u02B3\u02B4\u02B4\u02C0\u02B9\u02B3\u02B7\u02C1 = this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.videoHighwaySettings.highwayScrollingEnabled;
			this.\u02B6\u02B7\u02BE\u02B2\u02BC\u02B4\u02BB\u02BA\u02BE\u02C1\u02B9 = Helper.HexColorToColor(this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.videoHighwaySettings.color.CurrentValue, this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.videoHighwaySettings.highwayTransparency);
			if (this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5.videoHighwaySettings.scaleFullHighwayLength)
			{
				this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD.y = 1f;
			}
		}
		else
		{
			this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD.enabled = false;
			this.\u02B9\u02B7\u02BC\u02B4\u02BD\u02B2\u02C0\u02B6\u02BE\u02BF\u02BE();
		}
		this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.color = this.\u02B6\u02B7\u02BE\u02B2\u02BC\u02B4\u02BB\u02BA\u02BE\u02C1\u02B9;
		this.\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2 = GameObject.Find("Game Manager").GetComponent<GameManager>();
		this.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC = 0.0;
		this.fadeManager.\u02B2\u02B7\u02BE\u02B2\u02C1\u02B4\u02B6\u02B7\u02BE\u02BD\u02B8(this);
		this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.GetPropertyBlock(this.\u02B5\u02BA\u02B4\u02BF\u02C0\u02B5\u02BF\u02B5\u02B5\u02B9\u02B2);
		this.\u02B5\u02BA\u02B4\u02BF\u02C0\u02B5\u02BF\u02B5\u02B5\u02B9\u02B2.SetVector(this.\u02C1\u02B9\u02BD\u02B4\u02B9\u02B9\u02B2\u02B6\u02BA\u02BB\u02C0, this.\u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD);
		this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB.SetPropertyBlock(this.\u02B5\u02BA\u02B4\u02BF\u02C0\u02B5\u02BF\u02B5\u02B5\u02B9\u02B2);
	}

	private void \u02B4\u02C1\u02B6\u02BE\u02B3\u02B4\u02BD\u02B7\u02B6\u02C0\u02B9()
	{
		this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02C0\u02C1\u02B9\u02B4\u02BB\u02B9\u02B2\u02C0\u02B4\u02B5(this.player.player.playerProfile.highwayName);
		if (this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7 == -1)
		{
			this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7 = global::UnityEngine.Random.Range(0, GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3.Count);
		}
		this.\u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02BC\u02B7\u02BA\u02B9\u02BA\u02B2\u02B4\u02B7\u02B3[this.\u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7];
		this.\u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD = base.GetComponent<VideoPlayer>();
		this.\u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB = base.GetComponent<SpriteRenderer>();
		this.\u02B5\u02BA\u02B4\u02BF\u02C0\u02B5\u02BF\u02B5\u02B5\u02B9\u02B2 = new MaterialPropertyBlock();
		this.\u02C1\u02B9\u02BD\u02B4\u02B9\u02B9\u02B2\u02B6\u02BA\u02BB\u02C0 = Shader.PropertyToID("{0:N0}");
	}

	\u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B6\u02BB\u02BD\u02BB\u02BA\u02B6\u02B9\u02C0\u02B8\u02B4\u02BC.\u02BA\u02BA\u02B7\u02B9\u02B9\u02B5\u02C1\u02C1\u02B2\u02B7\u02BA()
	{
		return this.\u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3;
	}

	[SerializeField]
	private BasePlayer player;

	private SpriteRenderer \u02B8\u02B9\u02BB\u02BD\u02B8\u02B4\u02C1\u02B8\u02B9\u02B9\u02BB;

	private double \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC;

	private double \u02BE\u02B4\u02B5\u02B4\u02B6\u02BD\u02B9\u02C0\u02BD\u02BA\u02BE;

	private float \u02B9\u02BE\u02BA\u02B5\u02BE\u02B2\u02B9\u02BB\u02B6\u02BE\u02B5;

	private GameManager \u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2;

	private float \u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4;

	[SerializeField]
	private TrackFadeManager fadeManager;

	private MaterialPropertyBlock \u02B5\u02BA\u02B4\u02BF\u02C0\u02B5\u02BF\u02B5\u02B5\u02B9\u02B2;

	private int \u02C1\u02B9\u02BD\u02B4\u02B9\u02B9\u02B2\u02B6\u02BA\u02BB\u02C0;

	private Vector4 \u02B3\u02C0\u02B3\u02BD\u02BB\u02B3\u02BA\u02C1\u02B2\u02B5\u02BD;

	private VideoPlayer \u02BB\u02BC\u02C1\u02B9\u02BB\u02C1\u02B6\u02BC\u02BB\u02BC\u02BD;

	private HighwayData \u02B6\u02B3\u02B4\u02BA\u02B4\u02B2\u02B9\u02BE\u02BD\u02B7\u02B5;

	private int \u02B3\u02C0\u02BB\u02BC\u02BC\u02B4\u02BD\u02BC\u02C0\u02C1\u02B7 = -1;

	private bool \u02B2\u02C1\u02BC\u02B3\u02B4\u02B4\u02C0\u02B9\u02B3\u02B7\u02C1 = true;

	private Color \u02B6\u02B7\u02BE\u02B2\u02BC\u02B4\u02BB\u02BA\u02BE\u02C1\u02B9 = Color.white;

	private float \u02BD\u02B7\u02BD\u02B9\u02BB\u02BA\u02B3\u02C0\u02BB\u02BF\u02B6 = 1f;

	private bool \u02BE\u02C1\u02B4\u02B2\u02B3\u02B4\u02BC\u02B4\u02C0\u02C0\u02B4;
}
