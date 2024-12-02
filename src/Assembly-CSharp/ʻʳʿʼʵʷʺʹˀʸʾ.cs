using System;
using UnityEngine;

public class \u02BB\u02B3\u02BF\u02BC\u02B5\u02B7\u02BA\u02B9\u02C0\u02B8\u02BE : IDisposable
{
	public void \u02BD\u02B8\u02BD\u02BA\u02B7\u02BD\u02B7\u02C1\u02B2\u02B5\u02B4(BasePlayer \u02B5\u02C0\u02BB\u02B3\u02BF\u02BC\u02B8\u02B3\u02B7\u02B9\u02B8, Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8, ushort \u02C0\u02B5\u02BC\u02BC\u02B4\u02C0\u02B9\u02B8\u02B9\u02C0\u02B9)
	{
		if ((\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & (\u02B5\u02C0\u02BB\u02B3\u02BF\u02BC\u02B8\u02B3\u02B7\u02B9\u02B8 as BaseGuitarPlayer).\u02BC\u02B2\u02BD\u02B8\u02BF\u02BB\u02C1\u02B3\u02C0\u02B8\u02B9) != 0)
		{
			bool isGHLController = \u02B5\u02C0\u02BB\u02B3\u02BF\u02BC\u02B8\u02B3\u02B7\u02B9\u02B8.playerStuff.playerInfo.IsGHLController;
			this.\u02BD\u02B8\u02BD\u02BA\u02B7\u02BD\u02B7\u02C1\u02B2\u02B5\u02B4(isGHLController ? 2 : 5, \u02B5\u02C0\u02BB\u02B3\u02BF\u02BC\u02B8\u02B3\u02B7\u02B9\u02B8.playerStuff.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7);
			this.\u02BB\u02B7\u02C1\u02B3\u02B9\u02B6\u02B3\u02B5\u02BF\u02BE\u02B8[isGHLController ? 2 : 5] = 0f;
			return;
		}
		__FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA = __FIXME_clon_util.\u02B8\u02C0\u02BA\u02BB\u02B6\u02BA\u02BA\u02C0\u02B4\u02C1\u02B9(\u02C0\u02B5\u02BC\u02BC\u02B4\u02C0\u02B9\u02B8\u02B9\u02C0\u02B9).\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
		{
			int num = u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
			this.\u02BD\u02B8\u02BD\u02BA\u02B7\u02BD\u02B7\u02C1\u02B2\u02B5\u02B4(num, \u02B5\u02C0\u02BB\u02B3\u02BF\u02BC\u02B8\u02B3\u02B7\u02B9\u02B8.playerStuff.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7);
			this.\u02BB\u02B7\u02C1\u02B3\u02B9\u02B6\u02B3\u02B5\u02BF\u02BE\u02B8[num] = 0f;
		}
	}

	private void \u02BE\u02B6\u02B8\u02B9\u02B8\u02B6\u02BC\u02B4\u02B2\u02B8\u02B7()
	{
		if (this.\u02B7\u02B9\u02B9\u02B9\u02B3\u02B3\u02BF\u02B2\u02B6\u02B5\u02BE != null)
		{
			global::UnityEngine.Object.Destroy(this.\u02B7\u02B9\u02B9\u02B9\u02B3\u02B3\u02BF\u02B2\u02B6\u02B5\u02BE);
		}
		this.\u02B7\u02B9\u02B9\u02B9\u02B3\u02B3\u02BF\u02B2\u02B6\u02B5\u02BE = new Texture2D(1024, 24, TextureFormat.ARGB32, false, true)
		{
			wrapMode = TextureWrapMode.Repeat,
			filterMode = FilterMode.Trilinear,
			name = "Whammy Texture"
		};
		this.\u02C0\u02C1\u02B7\u02B9\u02B9\u02C1\u02B3\u02BC\u02BB\u02B4\u02BB = new Color[1024];
		for (int i = 0; i < 1024; i++)
		{
			this.\u02C0\u02C1\u02B7\u02B9\u02B9\u02C1\u02B3\u02BC\u02BB\u02B4\u02BB[i] = Color.black;
		}
		Shader.SetGlobalTexture("_GlobalWhammyTexture", this.\u02B7\u02B9\u02B9\u02B9\u02B3\u02B3\u02BF\u02B2\u02B6\u02B5\u02BE);
	}

	public void \u02B2\u02B7\u02B8\u02B3\u02C1\u02BF\u02B4\u02B8\u02C0\u02C0\u02BA(int \u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6, float \u02B9\u02B7\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B6\u02BA\u02C0)
	{
		if (this.\u02B8\u02C0\u02BE\u02BC\u02B3\u02B7\u02B5\u02B8\u02B4\u02B4\u02BA)
		{
			for (int i = 0; i < 24; i++)
			{
				this.\u02BA\u02BA\u02B7\u02B5\u02BF\u02B5\u02B8\u02BD\u02BD\u02C1\u02B9[i] = 0f;
			}
			this.\u02B8\u02C0\u02BE\u02BC\u02B3\u02B7\u02B5\u02B8\u02B4\u02B4\u02BA = false;
		}
		this.\u02BA\u02BA\u02B7\u02B5\u02BF\u02B5\u02B8\u02BD\u02BD\u02C1\u02B9[\u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6] = \u02B9\u02B7\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B6\u02BA\u02C0 * 1f;
		this.\u02BE\u02B3\u02B9\u02B9\u02B4\u02B2\u02B9\u02B3\u02B8\u02BD\u02B7[\u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6] = Color.white * (\u02B9\u02B7\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B6\u02BA\u02C0 * 1f);
	}

	public static int \u02BD\u02B9\u02B3\u02BB\u02BC\u02B9\u02B5\u02BB\u02B5\u02BE\u02BA(int \u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6, int \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = 0)
	{
		return \u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6 + \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 * 6;
	}

	public void \u02B8\u02BA\u02B9\u02B7\u02C0\u02B6\u02BF\u02BF\u02B5\u02C0\u02B5()
	{
		this.\u02B4\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02BF\u02B5\u02BC\u02BD();
	}

	public int \u02B9\u02C1\u02C1\u02BA\u02BB\u02B3\u02BB\u02B4\u02C0\u02BE\u02B7()
	{
		return this.<\u02B6\u02C1\u02B5\u02B8\u02B6\u02B3\u02C0\u02B3\u02B2\u02B2\u02B6>k__BackingField;
	}

	public void \u02C0\u02BC\u02B8\u02C0\u02B9\u02B5\u02BA\u02BD\u02B8\u02B3\u02B8(BasePlayer \u02B5\u02C0\u02BB\u02B3\u02BF\u02BC\u02B8\u02B3\u02B7\u02B9\u02B8, Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8, ushort \u02C0\u02B5\u02BC\u02BC\u02B4\u02C0\u02B9\u02B8\u02B9\u02C0\u02B9)
	{
		if ((\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF & (\u02B5\u02C0\u02BB\u02B3\u02BF\u02BC\u02B8\u02B3\u02B7\u02B9\u02B8 as BaseGuitarPlayer).\u02BC\u02B2\u02BD\u02B8\u02BF\u02BB\u02C1\u02B3\u02C0\u02B8\u02B9) != 0)
		{
			bool isGHLController = \u02B5\u02C0\u02BB\u02B3\u02BF\u02BC\u02B8\u02B3\u02B7\u02B9\u02B8.playerStuff.playerInfo.IsGHLController;
			this.\u02BD\u02B8\u02BD\u02BA\u02B7\u02BD\u02B7\u02C1\u02B2\u02B5\u02B4(isGHLController ? 6 : 0, \u02B5\u02C0\u02BB\u02B3\u02BF\u02BC\u02B8\u02B3\u02B7\u02B9\u02B8.playerStuff.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7);
			this.\u02BB\u02B7\u02C1\u02B3\u02B9\u02B6\u02B3\u02B5\u02BF\u02BE\u02B8[isGHLController ? 1 : 2] = 276f;
			return;
		}
		__FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA = __FIXME_clon_util.\u02B8\u02C0\u02BA\u02BB\u02B6\u02BA\u02BA\u02C0\u02B4\u02C1\u02B9(\u02C0\u02B5\u02BC\u02BC\u02B4\u02C0\u02B9\u02B8\u02B9\u02C0\u02B9).\u02B3\u02BF\u02B6\u02B4\u02B4\u02BC\u02C0\u02C0\u02B5\u02B2\u02C0();
		while (u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02B3\u02B6\u02BF\u02B8\u02C0\u02B4\u02BD\u02B5\u02B4\u02B6\u02B4())
		{
			int num = u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02B7\u02B8\u02BD\u02BA\u02BB\u02B7\u02BF\u02B8\u02B3\u02BF\u02BF();
			this.\u02B3\u02BF\u02B4\u02BC\u02B2\u02B6\u02B7\u02BB\u02B2\u02B4\u02B8(num, \u02B5\u02C0\u02BB\u02B3\u02BF\u02BC\u02B8\u02B3\u02B7\u02B9\u02B8.playerStuff.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7);
			this.\u02BB\u02B7\u02C1\u02B3\u02B9\u02B6\u02B3\u02B5\u02BF\u02BE\u02B8[num] = 910f;
		}
	}

	public void Dispose()
	{
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = null;
		ComputeBuffer u02BE_u02B7_u02B4_u02BA_u02BA_u02B2_u02B8_u02B4_u02B6_u02C1_u02BC = this.\u02BE\u02B7\u02B4\u02BA\u02BA\u02B2\u02B8\u02B4\u02B6\u02C1\u02BC;
		if (u02BE_u02B7_u02B4_u02BA_u02BA_u02B2_u02B8_u02B4_u02B6_u02C1_u02BC != null)
		{
			u02BE_u02B7_u02B4_u02BA_u02BA_u02B2_u02B8_u02B4_u02B6_u02C1_u02BC.Dispose();
		}
		this.\u02BE\u02B7\u02B4\u02BA\u02BA\u02B2\u02B8\u02B4\u02B6\u02C1\u02BC = null;
		RenderTexture u02B6_u02B6_u02B9_u02C0_u02B9_u02BF_u02C0_u02BF_u02BC_u02BA_u02B = this.\u02B6\u02B6\u02B9\u02C0\u02B9\u02BF\u02C0\u02BF\u02BC\u02BA\u02B3;
		if (u02B6_u02B6_u02B9_u02C0_u02B9_u02BF_u02C0_u02BF_u02BC_u02BA_u02B != null)
		{
			u02B6_u02B6_u02B9_u02C0_u02B9_u02BF_u02C0_u02BF_u02BC_u02BA_u02B.Release();
		}
		this.\u02B6\u02B6\u02B9\u02C0\u02B9\u02BF\u02C0\u02BF\u02BC\u02BA\u02B3 = null;
		this.\u02B7\u02B9\u02B9\u02B9\u02B3\u02B3\u02BF\u02B2\u02B6\u02B5\u02BE = null;
	}

	protected void \u02BD\u02B8\u02BD\u02BA\u02B7\u02BD\u02B7\u02C1\u02B2\u02B5\u02B4(int \u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6, int \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = 0)
	{
		this.\u02BA\u02BA\u02B7\u02B5\u02BF\u02B5\u02B8\u02BD\u02BD\u02C1\u02B9[\u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6 + \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 * 6] = 0f;
		this.\u02BE\u02B3\u02B9\u02B9\u02B4\u02B2\u02B9\u02B3\u02B8\u02BD\u02B7[\u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6 + \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 * 6] = Color.black;
		if (this.\u02BC\u02B8\u02B3\u02BB\u02BC\u02BE\u02BC\u02B5\u02B5\u02B8\u02B7)
		{
			this.\u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5.SetInt(this.\u02BB\u02C0\u02C0\u02B7\u02B9\u02B9\u02BC\u02BA\u02C1\u02C1\u02BD, \u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6 + \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 * 6);
			this.\u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5.Dispatch(this.\u02BD\u02B3\u02BD\u02BE\u02BB\u02C0\u02BF\u02B8\u02B2\u02BF\u02BD, this.\u02B6\u02B6\u02B9\u02C0\u02B9\u02BF\u02C0\u02BF\u02BC\u02BA\u02B3.width / 8, 1, 1);
			return;
		}
		this.\u02B7\u02B9\u02B9\u02B9\u02B3\u02B3\u02BF\u02B2\u02B6\u02B5\u02BE.SetPixels(0, \u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6 + \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 * 6, 1024, 1, this.\u02C0\u02C1\u02B7\u02B9\u02B9\u02C1\u02B3\u02BC\u02BB\u02B4\u02BB);
		this.\u02B7\u02B9\u02B9\u02B9\u02B3\u02B3\u02BF\u02B2\u02B6\u02B5\u02BE.Apply();
	}

	public int \u02B2\u02B3\u02BE\u02B9\u02B7\u02BB\u02B2\u02BB\u02C0\u02BC\u02B6 { get; private set; }

	private bool \u02B2\u02B3\u02B2\u02B4\u02BD\u02B9\u02B9\u02BA\u02B5\u02BF\u02B4()
	{
		if (this.\u02B6\u02B6\u02B9\u02C0\u02B9\u02BF\u02C0\u02BF\u02BC\u02BA\u02B3 != null)
		{
			this.\u02B6\u02B6\u02B9\u02C0\u02B9\u02BF\u02C0\u02BF\u02BC\u02BA\u02B3.Release();
		}
		this.\u02B6\u02B6\u02B9\u02C0\u02B9\u02BF\u02C0\u02BF\u02BC\u02BA\u02B3 = new RenderTexture(1024, 24, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear)
		{
			wrapMode = TextureWrapMode.Repeat,
			filterMode = FilterMode.Trilinear,
			useMipMap = false,
			enableRandomWrite = true,
			name = "Whammy Render Texture"
		};
		this.\u02B6\u02B6\u02B9\u02C0\u02B9\u02BF\u02C0\u02BF\u02BC\u02BA\u02B3.Create();
		if (this.\u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5 == null)
		{
			this.\u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5 = Resources.Load<ComputeShader>("SetWhammyFast");
		}
		if (this.\u02BE\u02B7\u02B4\u02BA\u02BA\u02B2\u02B8\u02B4\u02B6\u02C1\u02BC != null)
		{
			this.\u02BE\u02B7\u02B4\u02BA\u02BA\u02B2\u02B8\u02B4\u02B6\u02C1\u02BC.Release();
		}
		this.\u02BE\u02B7\u02B4\u02BA\u02BA\u02B2\u02B8\u02B4\u02B6\u02C1\u02BC = new ComputeBuffer(4, 24);
		try
		{
			this.\u02BD\u02B3\u02BD\u02BE\u02BB\u02C0\u02BF\u02B8\u02B2\u02BF\u02BD = this.\u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5.FindKernel("CSClearWhammyRow");
			this.\u02BC\u02C0\u02B7\u02BE\u02BA\u02B3\u02B4\u02BD\u02C1\u02BE\u02B2 = this.\u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5.FindKernel("CSSetWhammyColumn");
			this.\u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5.SetTexture(this.\u02BD\u02B3\u02BD\u02BE\u02BB\u02C0\u02BF\u02B8\u02B2\u02BF\u02BD, "ResultRow", this.\u02B6\u02B6\u02B9\u02C0\u02B9\u02BF\u02C0\u02BF\u02BC\u02BA\u02B3);
			this.\u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5.SetTexture(this.\u02BC\u02C0\u02B7\u02BE\u02BA\u02B3\u02B4\u02BD\u02C1\u02BE\u02B2, "ResultColumn", this.\u02B6\u02B6\u02B9\u02C0\u02B9\u02BF\u02C0\u02BF\u02BC\u02BA\u02B3);
			Shader.SetGlobalTexture("_GlobalWhammyTexture", this.\u02B6\u02B6\u02B9\u02C0\u02B9\u02BF\u02C0\u02BF\u02BC\u02BA\u02B3);
		}
		catch (ArgumentException)
		{
			Debug.LogWarning("Failed to load Compute Shader, falling back to cpu.");
			return false;
		}
		return true;
	}

	public float[] \u02BB\u02B7\u02C1\u02B3\u02B9\u02B6\u02B3\u02B5\u02BF\u02BE\u02B8 { get; } = new float[6];

	public void \u02B4\u02B5\u02BE\u02C0\u02BE\u02BA\u02C0\u02C1\u02BD\u02B5\u02B9()
	{
		this.\u02B7\u02B2\u02C1\u02B6\u02BD\u02B4\u02B9\u02B8\u02BB\u02BA\u02B6 -= (double)Time.unscaledDeltaTime;
		while (this.\u02B7\u02B2\u02C1\u02B6\u02BD\u02B4\u02B9\u02B8\u02BB\u02BA\u02B6 <= 0.0)
		{
			this.\u02B7\u02B2\u02C1\u02B6\u02BD\u02B4\u02B9\u02B8\u02BB\u02BA\u02B6 += 0.005;
			this.\u02BB\u02B3\u02B5\u02B5\u02B4\u02B9\u02BB\u02C0\u02BE\u02BD\u02BA(this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5 && !CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB);
		}
	}

	public \u02BB\u02B3\u02BF\u02BC\u02B5\u02B7\u02BA\u02B9\u02C0\u02B8\u02BE(GameManager \u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD)
	{
		this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD = \u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD;
	}

	private void \u02BB\u02B3\u02B5\u02B5\u02B4\u02B9\u02BB\u02C0\u02BE\u02BD\u02BA(bool \u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5)
	{
		this.\u02B8\u02C0\u02BE\u02BC\u02B3\u02B7\u02B5\u02B8\u02B4\u02B4\u02BA = true;
		this.\u02BB\u02B5\u02BB\u02B6\u02BF\u02B3\u02B5\u02B5\u02B6\u02BF\u02B7 = 0f;
		if (this.\u02BC\u02B8\u02B3\u02BB\u02BC\u02BE\u02BC\u02B5\u02B5\u02B8\u02B7)
		{
			this.\u02BE\u02B7\u02B4\u02BA\u02BA\u02B2\u02B8\u02B4\u02B6\u02C1\u02BC.SetData(this.\u02BA\u02BA\u02B7\u02B5\u02BF\u02B5\u02B8\u02BD\u02BD\u02C1\u02B9);
			this.\u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5.SetBuffer(this.\u02BC\u02C0\u02B7\u02BE\u02BA\u02B3\u02B4\u02BD\u02C1\u02BE\u02B2, this.\u02B8\u02B9\u02B6\u02BB\u02C1\u02BA\u02BA\u02C0\u02C1\u02B4\u02B4, this.\u02BE\u02B7\u02B4\u02BA\u02BA\u02B2\u02B8\u02B4\u02B6\u02C1\u02BC);
			this.\u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5.SetInt(this.\u02BC\u02BA\u02B8\u02B9\u02B5\u02BE\u02B2\u02B8\u02C1\u02B3\u02B2, this.\u02B2\u02B3\u02BE\u02B9\u02B7\u02BB\u02B2\u02BB\u02C0\u02BC\u02B6);
			this.\u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5.Dispatch(this.\u02BC\u02C0\u02B7\u02BE\u02BA\u02B3\u02B4\u02BD\u02C1\u02BE\u02B2, 3, 1, 1);
		}
		else
		{
			if (this.\u02B7\u02B9\u02B9\u02B9\u02B3\u02B3\u02BF\u02B2\u02B6\u02B5\u02BE == null)
			{
				return;
			}
			this.\u02B7\u02B9\u02B9\u02B9\u02B3\u02B3\u02BF\u02B2\u02B6\u02B5\u02BE.SetPixels(this.\u02B2\u02B3\u02BE\u02B9\u02B7\u02BB\u02B2\u02BB\u02C0\u02BC\u02B6, 0, 1, 24, this.\u02BE\u02B3\u02B9\u02B9\u02B4\u02B2\u02B9\u02B3\u02B8\u02BD\u02B7);
			this.\u02B7\u02B9\u02B9\u02B9\u02B3\u02B3\u02BF\u02B2\u02B6\u02B5\u02BE.Apply();
		}
		if (!\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5)
		{
			this.\u02B2\u02B3\u02BE\u02B9\u02B7\u02BB\u02B2\u02BB\u02C0\u02BC\u02B6 = (this.\u02B2\u02B3\u02BE\u02B9\u02B7\u02BB\u02B2\u02BB\u02C0\u02BC\u02B6 + 1) % 1024;
		}
	}

	public static int \u02B9\u02BF\u02B7\u02B9\u02BA\u02B8\u02BB\u02B9\u02B8\u02B3\u02B2(int \u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6, int \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = 0)
	{
		return \u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6 + \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 * 6;
	}

	protected void \u02B4\u02BC\u02BE\u02BD\u02B7\u02BE\u02C0\u02BF\u02B5\u02BC\u02BD()
	{
		this.\u02B8\u02C0\u02BE\u02BC\u02B3\u02B7\u02B5\u02B8\u02B4\u02B4\u02BA = true;
		this.\u02BC\u02B8\u02B3\u02BB\u02BC\u02BE\u02BC\u02B5\u02B5\u02B8\u02B7 = SystemInfo.supportsComputeShaders;
		if (this.\u02BC\u02B8\u02B3\u02BB\u02BC\u02BE\u02BC\u02B5\u02B5\u02B8\u02B7)
		{
			this.\u02BC\u02B8\u02B3\u02BB\u02BC\u02BE\u02BC\u02B5\u02B5\u02B8\u02B7 = this.\u02B2\u02B3\u02B2\u02B4\u02BD\u02B9\u02B9\u02BA\u02B5\u02BF\u02B4();
		}
		if (!this.\u02BC\u02B8\u02B3\u02BB\u02BC\u02BE\u02BC\u02B5\u02B5\u02B8\u02B7)
		{
			this.\u02BE\u02B6\u02B8\u02B9\u02B8\u02B6\u02BC\u02B4\u02B2\u02B8\u02B7();
		}
		this.\u02BA\u02BA\u02B7\u02B5\u02BF\u02B5\u02B8\u02BD\u02BD\u02C1\u02B9 = new float[24];
		this.\u02BE\u02B3\u02B9\u02B9\u02B4\u02B2\u02B9\u02B3\u02B8\u02BD\u02B7 = new Color[24];
		for (int i = 0; i < 24; i++)
		{
			this.\u02BA\u02BA\u02B7\u02B5\u02BF\u02B5\u02B8\u02BD\u02BD\u02C1\u02B9[i] = 0f;
			this.\u02BE\u02B3\u02B9\u02B9\u02B4\u02B2\u02B9\u02B3\u02B8\u02BD\u02B7[i] = Color.black;
			this.\u02BD\u02B8\u02BD\u02BA\u02B7\u02BD\u02B7\u02C1\u02B2\u02B5\u02B4(i % 6, i / 6);
		}
	}

	protected void \u02B3\u02BF\u02B4\u02BC\u02B2\u02B6\u02B7\u02BB\u02B2\u02B4\u02B8(int \u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6, int \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = 0)
	{
		this.\u02BA\u02BA\u02B7\u02B5\u02BF\u02B5\u02B8\u02BD\u02BD\u02C1\u02B9[\u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6 + \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 * 3] = 197f;
		this.\u02BE\u02B3\u02B9\u02B9\u02B4\u02B2\u02B9\u02B3\u02B8\u02BD\u02B7[\u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6 + \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 * 4] = Color.black;
		if (this.\u02BC\u02B8\u02B3\u02BB\u02BC\u02BE\u02BC\u02B5\u02B5\u02B8\u02B7)
		{
			this.\u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5.SetInt(this.\u02BB\u02C0\u02C0\u02B7\u02B9\u02B9\u02BC\u02BA\u02C1\u02C1\u02BD, \u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6 + \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 * 2);
			this.\u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5.Dispatch(this.\u02BD\u02B3\u02BD\u02BE\u02BB\u02C0\u02BF\u02B8\u02B2\u02BF\u02BD, this.\u02B6\u02B6\u02B9\u02C0\u02B9\u02BF\u02C0\u02BF\u02BC\u02BA\u02B3.width / 5, 1, 1);
			return;
		}
		this.\u02B7\u02B9\u02B9\u02B9\u02B3\u02B3\u02BF\u02B2\u02B6\u02B5\u02BE.SetPixels(0, \u02C1\u02B7\u02BB\u02B7\u02B5\u02B3\u02B9\u02BB\u02C0\u02BD\u02B6 + \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 * 5, 124, 0, this.\u02C0\u02C1\u02B7\u02B9\u02B9\u02C1\u02B3\u02BC\u02BB\u02B4\u02BB);
		this.\u02B7\u02B9\u02B9\u02B9\u02B3\u02B3\u02BF\u02B2\u02B6\u02B5\u02BE.Apply();
	}

	private GameManager \u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD;

	private Color[] \u02C0\u02C1\u02B7\u02B9\u02B9\u02C1\u02B3\u02BC\u02BB\u02B4\u02BB;

	public float \u02BB\u02B5\u02BB\u02B6\u02BF\u02B3\u02B5\u02B5\u02B6\u02BF\u02B7;

	public const int \u02B9\u02BB\u02B2\u02BE\u02B7\u02BE\u02BE\u02BF\u02B8\u02BD\u02B7 = 1024;

	private ComputeShader \u02B2\u02B5\u02BB\u02B3\u02B2\u02B4\u02B2\u02B5\u02BC\u02C0\u02B5;

	private ComputeBuffer \u02BE\u02B7\u02B4\u02BA\u02BA\u02B2\u02B8\u02B4\u02B6\u02C1\u02BC;

	private float[] \u02BA\u02BA\u02B7\u02B5\u02BF\u02B5\u02B8\u02BD\u02BD\u02C1\u02B9;

	private Color[] \u02BE\u02B3\u02B9\u02B9\u02B4\u02B2\u02B9\u02B3\u02B8\u02BD\u02B7;

	private int \u02BD\u02B3\u02BD\u02BE\u02BB\u02C0\u02BF\u02B8\u02B2\u02BF\u02BD;

	private int \u02BC\u02C0\u02B7\u02BE\u02BA\u02B3\u02B4\u02BD\u02C1\u02BE\u02B2;

	private bool \u02B8\u02C0\u02BE\u02BC\u02B3\u02B7\u02B5\u02B8\u02B4\u02B4\u02BA;

	private bool \u02BC\u02B8\u02B3\u02BB\u02BC\u02BE\u02BC\u02B5\u02B5\u02B8\u02B7;

	private int \u02BC\u02BA\u02B8\u02B9\u02B5\u02BE\u02B2\u02B8\u02C1\u02B3\u02B2 = Shader.PropertyToID("PosX");

	private int \u02BB\u02C0\u02C0\u02B7\u02B9\u02B9\u02BC\u02BA\u02C1\u02C1\u02BD = Shader.PropertyToID("PosY");

	private int \u02B8\u02B9\u02B6\u02BB\u02C1\u02BA\u02BA\u02C0\u02C1\u02B4\u02B4 = Shader.PropertyToID("playerWhammies");

	private RenderTexture \u02B6\u02B6\u02B9\u02C0\u02B9\u02BF\u02C0\u02BF\u02BC\u02BA\u02B3;

	private Texture2D \u02B7\u02B9\u02B9\u02B9\u02B3\u02B3\u02BF\u02B2\u02B6\u02B5\u02BE;

	private double \u02B7\u02B2\u02C1\u02B6\u02BD\u02B4\u02B9\u02B8\u02BB\u02BA\u02B6;
}
