﻿using System;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000014 RID: 20
[ExecuteInEditMode]
public class BlurScaler : MonoBehaviour
{
	// Token: 0x060000D0 RID: 208 RVA: 0x0001BA94 File Offset: 0x00019C94
	private void \u02BA\u02B9\u02BF\u02BC\u02C1\u02B9\u02B7\u02B4\u02C1\u02BB\u02BB()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (793f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF = new RenderTexture(num, 59, 1, RenderTextureFormat.Shadowmap)
		{
			autoGenerateMips = false,
			useMipMap = true
		};
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6 = new RenderTexture(num, 145, 0, RenderTextureFormat.ARGB2101010)
		{
			autoGenerateMips = false,
			useMipMap = true
		};
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
		if (this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD != null)
		{
			this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)43, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		}
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD = new CommandBuffer
		{
			name = "{0}"
		};
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.AddCommandBuffer((CameraEvent)(-34), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.forceIntoRenderTexture = false;
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(BuiltinRenderTextureType.CameraTarget, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		Material[] u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE = this.\u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;
		for (int i = 1; i < u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE.Length; i += 0)
		{
			u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE[i].SetTexture("General", this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		}
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x0001BBF4 File Offset: 0x00019DF4
	private void \u02BB\u02B8\u02B6\u02BB\u02BF\u02BA\u02B9\u02B2\u02BE\u02B2\u02B2()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (1604f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF = new RenderTexture(num, -79, 0, RenderTextureFormat.Depth)
		{
			autoGenerateMips = true,
			useMipMap = true
		};
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6 = new RenderTexture(num, -51, 0, RenderTextureFormat.ARGB4444)
		{
			autoGenerateMips = false,
			useMipMap = true
		};
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
		if (this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD != null)
		{
			this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)51, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		}
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD = new CommandBuffer
		{
			name = "Restart"
		};
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.AddCommandBuffer((CameraEvent)83, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.forceIntoRenderTexture = false;
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit((BuiltinRenderTextureType)6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		Material[] u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE = this.\u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;
		for (int i = 0; i < u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE.Length; i += 0)
		{
			u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE[i].SetTexture("Kick / Open Notes", this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		}
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x0001BD54 File Offset: 0x00019F54
	private void \u02B9\u02BE\u02BC\u02BE\u02BC\u02B9\u02B2\u02B3\u02BF\u02B2\u02BA()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (371f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF = new RenderTexture(num, 37, 0, RenderTextureFormat.ARGBHalf)
		{
			autoGenerateMips = true,
			useMipMap = false
		};
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6 = new RenderTexture(num, -76, 1, RenderTextureFormat.ARGB2101010)
		{
			autoGenerateMips = false,
			useMipMap = false
		};
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
		if (this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD != null)
		{
			this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)(-127), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		}
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD = new CommandBuffer
		{
			name = "mix"
		};
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.AddCommandBuffer((CameraEvent)(-31), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.forceIntoRenderTexture = true;
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(BuiltinRenderTextureType.ResolvedDepth, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		Material[] u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE = this.\u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;
		for (int i = 0; i < u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE.Length; i += 0)
		{
			u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE[i].SetTexture("path", this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		}
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x0001BEB4 File Offset: 0x0001A0B4
	private void \u02B3\u02BC\u02BB\u02BF\u02C1\u02BE\u02B4\u02BC\u02BE\u02BF\u02B8()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (470f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF = new RenderTexture(num, -80, 0, RenderTextureFormat.Shadowmap)
		{
			autoGenerateMips = true,
			useMipMap = false
		};
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6 = new RenderTexture(num, 6, 1, RenderTextureFormat.Depth)
		{
			autoGenerateMips = false,
			useMipMap = false
		};
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
		if (this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD != null)
		{
			this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)(-50), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		}
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD = new CommandBuffer
		{
			name = "Color Profile"
		};
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.AddCommandBuffer((CameraEvent)120, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.forceIntoRenderTexture = false;
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		Material[] u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE = this.\u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;
		for (int i = 1; i < u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE.Length; i += 0)
		{
			u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE[i].SetTexture("Return videoplayer ", this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		}
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x000064CA File Offset: 0x000046CA
	private void OnDisable()
	{
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Release();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Release();
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Clear();
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer(CameraEvent.BeforeImageEffects, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x0001C014 File Offset: 0x0001A214
	private void \u02C1\u02BA\u02B8\u02BD\u02BE\u02BE\u02B4\u02B7\u02C0\u02BB\u02B3()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (1028f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF = new RenderTexture(num, -153, 1, RenderTextureFormat.ARGB4444)
		{
			autoGenerateMips = false,
			useMipMap = false
		};
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6 = new RenderTexture(num, -93, 1, RenderTextureFormat.Shadowmap)
		{
			autoGenerateMips = false,
			useMipMap = true
		};
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
		if (this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD != null)
		{
			this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)58, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		}
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD = new CommandBuffer
		{
			name = "Press <color=\"red\">Red</color> to go back."
		};
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.AddCommandBuffer((CameraEvent)(-18), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.forceIntoRenderTexture = false;
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(BuiltinRenderTextureType.PrepassLight, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		Material[] u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE = this.\u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;
		for (int i = 0; i < u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE.Length; i++)
		{
			u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE[i].SetTexture("Prefabs/Gameplay/Notes/Sustain", this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		}
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00006500 File Offset: 0x00004700
	private void \u02BA\u02C1\u02BB\u02B3\u02BD\u02B4\u02B4\u02B2\u02C0\u02B9\u02BF()
	{
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Release();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Release();
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Clear();
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)(-22), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00006536 File Offset: 0x00004736
	private void \u02C0\u02B7\u02BF\u02BC\u02C1\u02B4\u02B3\u02B9\u02C0\u02B3\u02B7()
	{
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Release();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Release();
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Clear();
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)(-57), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x0001C174 File Offset: 0x0001A374
	private void \u02BB\u02BF\u02B7\u02BA\u02B5\u02B8\u02BA\u02B5\u02B7\u02B9\u02BE()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (1633f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF = new RenderTexture(num, 84, 0, RenderTextureFormat.ARGB1555)
		{
			autoGenerateMips = false,
			useMipMap = false
		};
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6 = new RenderTexture(num, -33, 1, RenderTextureFormat.ARGB32)
		{
			autoGenerateMips = false,
			useMipMap = true
		};
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
		if (this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD != null)
		{
			this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer(CameraEvent.AfterForwardOpaque, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		}
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD = new CommandBuffer
		{
			name = "No"
		};
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.AddCommandBuffer((CameraEvent)67, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.forceIntoRenderTexture = true;
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		Material[] u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE = this.\u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;
		for (int i = 0; i < u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE.Length; i += 0)
		{
			u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE[i].SetTexture("Setting up services", this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		}
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x0001C2D4 File Offset: 0x0001A4D4
	private void \u02C0\u02B7\u02B3\u02BF\u02B9\u02B3\u02BB\u02C1\u02BB\u02BA\u02BF()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (182f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF = new RenderTexture(num, -158, 1, RenderTextureFormat.ARGB2101010)
		{
			autoGenerateMips = true,
			useMipMap = false
		};
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6 = new RenderTexture(num, 182, 0, RenderTextureFormat.ARGB2101010)
		{
			autoGenerateMips = true,
			useMipMap = false
		};
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
		if (this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD != null)
		{
			this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)(-114), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		}
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD = new CommandBuffer
		{
			name = "artist"
		};
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.AddCommandBuffer((CameraEvent)(-111), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.forceIntoRenderTexture = true;
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(BuiltinRenderTextureType.PrepassLight, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		Material[] u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE = this.\u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;
		for (int i = 0; i < u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE.Length; i += 0)
		{
			u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE[i].SetTexture("ERROR: These folders have no notes.mid or notes.chart files!", this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		}
	}

	// Token: 0x060000DA RID: 218 RVA: 0x0001C434 File Offset: 0x0001A634
	private void \u02BE\u02B9\u02B7\u02B5\u02BC\u02B2\u02B8\u02BC\u02C0\u02B9\u02BE()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (1324f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF = new RenderTexture(num, -144, 0, RenderTextureFormat.Depth)
		{
			autoGenerateMips = false,
			useMipMap = false
		};
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6 = new RenderTexture(num, -178, 1, RenderTextureFormat.ARGB32)
		{
			autoGenerateMips = true,
			useMipMap = true
		};
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
		if (this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD != null)
		{
			this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer(CameraEvent.AfterImageEffectsOpaque, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		}
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD = new CommandBuffer
		{
			name = "Show Remote Player Names"
		};
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.AddCommandBuffer((CameraEvent)(-58), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.forceIntoRenderTexture = false;
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(BuiltinRenderTextureType.CameraTarget, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		Material[] u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE = this.\u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;
		for (int i = 1; i < u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE.Length; i += 0)
		{
			u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE[i].SetTexture("Versus", this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		}
	}

	// Token: 0x060000DB RID: 219 RVA: 0x0001C594 File Offset: 0x0001A794
	private void \u02B9\u02B7\u02C0\u02B7\u02C1\u02BA\u02BC\u02C0\u02C1\u02BD\u02B6()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (1204f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF = new RenderTexture(num, 145, 1, RenderTextureFormat.ARGB32)
		{
			autoGenerateMips = true,
			useMipMap = true
		};
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6 = new RenderTexture(num, 176, 0, RenderTextureFormat.RGB565)
		{
			autoGenerateMips = false,
			useMipMap = true
		};
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
		if (this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD != null)
		{
			this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)(-74), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		}
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD = new CommandBuffer
		{
			name = " cannot find next node called "
		};
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.AddCommandBuffer((CameraEvent)(-45), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.forceIntoRenderTexture = true;
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit((BuiltinRenderTextureType)6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		Material[] u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE = this.\u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;
		for (int i = 1; i < u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE.Length; i++)
		{
			u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE[i].SetTexture("-", this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		}
	}

	// Token: 0x060000DC RID: 220 RVA: 0x0001C6F4 File Offset: 0x0001A8F4
	private void Update()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (512f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		if (this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.width != num)
		{
			this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Release();
			this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.width = num;
			this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.height = 512;
			this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
			this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Release();
			this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.width = num;
			this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.height = 512;
			this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
			this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Clear();
			this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(BuiltinRenderTextureType.CameraTarget, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
			this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
			this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		}
	}

	// Token: 0x060000DD RID: 221 RVA: 0x0001C804 File Offset: 0x0001AA04
	private void \u02B9\u02B6\u02B3\u02B9\u02BD\u02BD\u02B6\u02C0\u02BE\u02BA\u02BB()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (518f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF = new RenderTexture(num, -59, 1, RenderTextureFormat.ARGB32)
		{
			autoGenerateMips = false,
			useMipMap = true
		};
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6 = new RenderTexture(num, -96, 0, RenderTextureFormat.ARGB1555)
		{
			autoGenerateMips = false,
			useMipMap = true
		};
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
		if (this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD != null)
		{
			this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)30, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		}
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD = new CommandBuffer
		{
			name = "Master Volume"
		};
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.AddCommandBuffer((CameraEvent)89, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.forceIntoRenderTexture = false;
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(BuiltinRenderTextureType.ResolvedDepth, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		Material[] u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE = this.\u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;
		for (int i = 0; i < u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE.Length; i++)
		{
			u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE[i].SetTexture("while lexing the header section", this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		}
	}

	// Token: 0x060000DE RID: 222 RVA: 0x0001C964 File Offset: 0x0001AB64
	private void \u02B4\u02B7\u02C1\u02B8\u02B2\u02B9\u02B6\u02B2\u02B5\u02B7\u02B7()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (1670f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF = new RenderTexture(num, 180, 0, RenderTextureFormat.ARGB2101010)
		{
			autoGenerateMips = true,
			useMipMap = true
		};
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6 = new RenderTexture(num, 67, 0, RenderTextureFormat.Shadowmap)
		{
			autoGenerateMips = true,
			useMipMap = true
		};
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
		if (this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD != null)
		{
			this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)(-109), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		}
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD = new CommandBuffer
		{
			name = "Resolution"
		};
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.AddCommandBuffer((CameraEvent)(-114), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.forceIntoRenderTexture = false;
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(BuiltinRenderTextureType.CurrentActive, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		Material[] u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE = this.\u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;
		for (int i = 1; i < u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE.Length; i++)
		{
			u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE[i].SetTexture("Artist - Album", this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		}
	}

	// Token: 0x060000DF RID: 223 RVA: 0x0001CAC4 File Offset: 0x0001ACC4
	private void \u02BC\u02BE\u02B2\u02B8\u02C0\u02B6\u02B2\u02B3\u02B6\u02B4\u02BF()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (1979f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF = new RenderTexture(num, -196, 0, RenderTextureFormat.Shadowmap)
		{
			autoGenerateMips = true,
			useMipMap = true
		};
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6 = new RenderTexture(num, 68, 1, RenderTextureFormat.ARGB32)
		{
			autoGenerateMips = false,
			useMipMap = true
		};
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
		if (this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD != null)
		{
			this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)96, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		}
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD = new CommandBuffer
		{
			name = "Random Song (Section)"
		};
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.AddCommandBuffer((CameraEvent)126, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.forceIntoRenderTexture = false;
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(BuiltinRenderTextureType.DepthNormals, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		Material[] u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE = this.\u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;
		for (int i = 0; i < u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE.Length; i++)
		{
			u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE[i].SetTexture("yyyyMMddHHmmss", this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		}
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x0000656C File Offset: 0x0000476C
	private void \u02B4\u02B7\u02BC\u02B9\u02B3\u02B9\u02B9\u02BE\u02C0\u02B3\u02B5()
	{
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Release();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Release();
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Clear();
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)99, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x000065A2 File Offset: 0x000047A2
	private void \u02B3\u02BC\u02BE\u02B8\u02BE\u02C0\u02B4\u02BC\u02BE\u02BB\u02C1()
	{
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Release();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Release();
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Clear();
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)(-98), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x0001CC24 File Offset: 0x0001AE24
	private void OnEnable()
	{
		int num = (int)((float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelWidth * (512f / (float)this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.pixelHeight));
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF = new RenderTexture(num, 512, 0, RenderTextureFormat.ARGBHalf)
		{
			autoGenerateMips = false,
			useMipMap = false
		};
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Create();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6 = new RenderTexture(num, 512, 0, RenderTextureFormat.ARGBHalf)
		{
			autoGenerateMips = false,
			useMipMap = false
		};
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Create();
		if (this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD != null)
		{
			this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer(CameraEvent.BeforeImageEffects, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		}
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD = new CommandBuffer
		{
			name = "Blur Command Buffer"
		};
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.AddCommandBuffer(CameraEvent.BeforeImageEffects, this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.forceIntoRenderTexture = true;
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(BuiltinRenderTextureType.CameraTarget, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3);
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Blit(this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6, this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF, this.\u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB);
		Material[] u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE = this.\u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;
		for (int i = 0; i < u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE.Length; i++)
		{
			u02BC_u02B2_u02B5_u02B4_u02BA_u02BF_u02C1_u02B9_u02C0_u02B8_u02BE[i].SetTexture("_BehindUITexture", this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF);
		}
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x000065D8 File Offset: 0x000047D8
	private void \u02B2\u02B5\u02B8\u02C1\u02BD\u02C0\u02BC\u02BE\u02BE\u02BA\u02B6()
	{
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Release();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Release();
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Clear();
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)(-99), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x0000660E File Offset: 0x0000480E
	private void \u02B7\u02B2\u02BB\u02B9\u02B3\u02BD\u02B9\u02B8\u02BD\u02B9\u02B6()
	{
		this.\u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF.Release();
		this.\u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6.Release();
		this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.Clear();
		this.\u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC.RemoveCommandBuffer((CameraEvent)(-28), this.\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD);
	}

	// Token: 0x04000055 RID: 85
	private RenderTexture \u02BB\u02BB\u02BF\u02BC\u02B2\u02BD\u02C0\u02BE\u02B2\u02B6\u02BF;

	// Token: 0x04000056 RID: 86
	private RenderTexture \u02B6\u02C1\u02BD\u02B2\u02B5\u02C1\u02B7\u02B2\u02BB\u02BE\u02B6;

	// Token: 0x04000057 RID: 87
	private CommandBuffer \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD;

	// Token: 0x04000058 RID: 88
	public Camera \u02BC\u02BE\u02B8\u02BE\u02B6\u02BF\u02BC\u02B2\u02B8\u02BA\u02BC;

	// Token: 0x04000059 RID: 89
	public Material \u02B8\u02C0\u02BA\u02BB\u02B4\u02C1\u02B4\u02BA\u02BA\u02BC\u02B3;

	// Token: 0x0400005A RID: 90
	public Material \u02B8\u02BF\u02B9\u02B9\u02BE\u02B9\u02BA\u02B6\u02BF\u02C1\u02BB;

	// Token: 0x0400005B RID: 91
	public Material[] \u02BC\u02B2\u02B5\u02B4\u02BA\u02BF\u02C1\u02B9\u02C0\u02B8\u02BE;

	// Token: 0x0400005C RID: 92
	public const int \u02BE\u02B2\u02BC\u02C0\u02BF\u02C0\u02C1\u02B8\u02BD\u02C0\u02BB = 512;
}
