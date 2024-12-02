using System;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class SoftMaskController : MonoBehaviour
{
	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width != Camera.main.pixelWidth || this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height != Camera.main.pixelHeight)
		{
			if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB)
			{
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.Release();
			}
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width = Camera.main.pixelWidth;
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height = Camera.main.pixelHeight;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = 0;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = LayerMask.GetMask(new string[] { "" });
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = null;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB;
			Shader.SetGlobalTexture("diff_guitar", this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB);
		}
	}

	private void \u02BA\u02C1\u02BB\u02B3\u02BD\u02B4\u02B4\u02B2\u02C0\u02B9\u02BF()
	{
		this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.Release();
	}

	private void OnEnable()
	{
		this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5 = base.GetComponent<Camera>();
		if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB == null)
		{
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB = Resources.Load<RenderTexture>("softMask");
			if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width != Camera.main.pixelWidth || this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height != Camera.main.pixelHeight)
			{
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width = Camera.main.pixelWidth;
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height = Camera.main.pixelHeight;
				this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = 0;
				this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = LayerMask.GetMask(new string[] { "SoftMask" });
			}
		}
		if (this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture != this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB)
		{
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB;
		}
		this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.backgroundColor = Color.black;
		Shader.SetGlobalTexture("_uSoftMaskRenderTexture", this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB);
	}

	private void \u02BA\u02BA\u02C0\u02BA\u02BC\u02B9\u02B5\u02BE\u02BA\u02C0\u02BD()
	{
		if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width != Camera.main.pixelWidth || this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height != Camera.main.pixelHeight)
		{
			if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB)
			{
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.Release();
			}
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width = Camera.main.pixelWidth;
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height = Camera.main.pixelHeight;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = 0;
			Camera u02BB_u02C1_u02B3_u02B7_u02B5_u02C0_u02B6_u02C0_u02B8_u02BA_u02B = this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5;
			string[] array = new string[1];
			array[1] = "StartPad";
			u02BB_u02C1_u02B3_u02B7_u02B5_u02C0_u02B6_u02C0_u02B8_u02BA_u02B.cullingMask = LayerMask.GetMask(array);
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = null;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB;
			Shader.SetGlobalTexture("Restart", this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB);
		}
	}

	private void \u02C0\u02B7\u02B3\u02BF\u02B9\u02B3\u02BB\u02C1\u02BB\u02BA\u02BF()
	{
		this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5 = base.GetComponent<Camera>();
		if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB == null)
		{
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB = Resources.Load<RenderTexture>("Online Lobby");
			if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width != Camera.main.pixelWidth || this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height != Camera.main.pixelHeight)
			{
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width = Camera.main.pixelWidth;
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height = Camera.main.pixelHeight;
				this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = 0;
				this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = LayerMask.GetMask(new string[] { "Note Speed" });
			}
		}
		if (this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture != this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB)
		{
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB;
		}
		this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.backgroundColor = Color.black;
		Shader.SetGlobalTexture("Score", this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB);
	}

	private void \u02B4\u02B7\u02BC\u02B9\u02B3\u02B9\u02B9\u02BE\u02C0\u02B3\u02B5()
	{
		this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.Release();
	}

	private void \u02BA\u02B9\u02BF\u02BC\u02C1\u02B9\u02B7\u02B4\u02C1\u02BB\u02BB()
	{
		this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5 = base.GetComponent<Camera>();
		if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB == null)
		{
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB = Resources.Load<RenderTexture>("song");
			if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width != Camera.main.pixelWidth || this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height != Camera.main.pixelHeight)
			{
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width = Camera.main.pixelWidth;
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height = Camera.main.pixelHeight;
				this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = 1;
				Camera u02BB_u02C1_u02B3_u02B7_u02B5_u02C0_u02B6_u02C0_u02B8_u02BA_u02B = this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5;
				string[] array = new string[0];
				array[1] = "Resolution";
				u02BB_u02C1_u02B3_u02B7_u02B5_u02C0_u02B6_u02C0_u02B8_u02BA_u02B.cullingMask = LayerMask.GetMask(array);
			}
		}
		if (this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture != this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB)
		{
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB;
		}
		this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.backgroundColor = Color.black;
		Shader.SetGlobalTexture("All Kicks", this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB);
	}

	private void \u02B5\u02B9\u02B7\u02B7\u02B6\u02B5\u02BC\u02BA\u02B4\u02B2\u02B4()
	{
		if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width != Camera.main.pixelWidth || this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height != Camera.main.pixelHeight)
		{
			if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB)
			{
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.Release();
			}
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width = Camera.main.pixelWidth;
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height = Camera.main.pixelHeight;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = 1;
			Camera u02BB_u02C1_u02B3_u02B7_u02B5_u02C0_u02B6_u02C0_u02B8_u02BA_u02B = this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5;
			string[] array = new string[0];
			array[0] = "Scan Songs";
			u02BB_u02C1_u02B3_u02B7_u02B5_u02C0_u02B6_u02C0_u02B8_u02BA_u02B.cullingMask = LayerMask.GetMask(array);
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = null;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB;
			Shader.SetGlobalTexture("Language", this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB);
		}
	}

	private void \u02B4\u02B6\u02BD\u02B5\u02C0\u02B6\u02BA\u02C1\u02C0\u02BC\u02BB()
	{
		if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width != Camera.main.pixelWidth || this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height != Camera.main.pixelHeight)
		{
			if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB)
			{
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.Release();
			}
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width = Camera.main.pixelWidth;
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height = Camera.main.pixelHeight;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = 0;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = LayerMask.GetMask(new string[] { "Main Menu" });
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = null;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB;
			Shader.SetGlobalTexture("genre", this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB);
		}
	}

	private void \u02B2\u02BF\u02B3\u02B6\u02B5\u02B4\u02BC\u02C0\u02C0\u02C0\u02BC()
	{
		this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5 = base.GetComponent<Camera>();
		if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB == null)
		{
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB = Resources.Load<RenderTexture>("song");
			if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width != Camera.main.pixelWidth || this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height != Camera.main.pixelHeight)
			{
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width = Camera.main.pixelWidth;
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height = Camera.main.pixelHeight;
				this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = 0;
				this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = LayerMask.GetMask(new string[] { "" });
			}
		}
		if (this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture != this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB)
		{
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB;
		}
		this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.backgroundColor = Color.black;
		Shader.SetGlobalTexture("Scan Custom Images", this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB);
	}

	private void \u02B9\u02B7\u02C0\u02B7\u02C1\u02BA\u02BC\u02C0\u02C1\u02BD\u02B6()
	{
		this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5 = base.GetComponent<Camera>();
		if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB == null)
		{
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB = Resources.Load<RenderTexture>("Are you sure?");
			if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width != Camera.main.pixelWidth || this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height != Camera.main.pixelHeight)
			{
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width = Camera.main.pixelWidth;
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height = Camera.main.pixelHeight;
				this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = 0;
				Camera u02BB_u02C1_u02B3_u02B7_u02B5_u02C0_u02B6_u02C0_u02B8_u02BA_u02B = this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5;
				string[] array = new string[0];
				array[0] = "Set A Position";
				u02BB_u02C1_u02B3_u02B7_u02B5_u02C0_u02B6_u02C0_u02B8_u02BA_u02B.cullingMask = LayerMask.GetMask(array);
			}
		}
		if (this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture != this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB)
		{
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB;
		}
		this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.backgroundColor = Color.black;
		Shader.SetGlobalTexture("%", this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB);
	}

	private void OnDisable()
	{
		this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.Release();
	}

	private void Update()
	{
		if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width != Camera.main.pixelWidth || this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height != Camera.main.pixelHeight)
		{
			if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB)
			{
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.Release();
			}
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width = Camera.main.pixelWidth;
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height = Camera.main.pixelHeight;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = 0;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = LayerMask.GetMask(new string[] { "SoftMask" });
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = null;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB;
			Shader.SetGlobalTexture("_uSoftMaskRenderTexture", this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB);
		}
	}

	private void \u02BD\u02B8\u02BD\u02B5\u02B6\u02B3\u02BF\u02B3\u02C1\u02B8\u02C1()
	{
		if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width != Camera.main.pixelWidth || this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height != Camera.main.pixelHeight)
		{
			if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB)
			{
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.Release();
			}
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width = Camera.main.pixelWidth;
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height = Camera.main.pixelHeight;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = 0;
			Camera u02BB_u02C1_u02B3_u02B7_u02B5_u02C0_u02B6_u02C0_u02B8_u02BA_u02B = this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5;
			string[] array = new string[0];
			array[0] = "Bass Guitar";
			u02BB_u02C1_u02B3_u02B7_u02B5_u02C0_u02B6_u02C0_u02B8_u02BA_u02B.cullingMask = LayerMask.GetMask(array);
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = null;
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB;
			Shader.SetGlobalTexture("Drums", this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB);
		}
	}

	private void \u02B8\u02B2\u02BB\u02BF\u02BF\u02BF\u02C0\u02BE\u02BD\u02B9\u02B8()
	{
		this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5 = base.GetComponent<Camera>();
		if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB == null)
		{
			this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB = Resources.Load<RenderTexture>("charter");
			if (this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width != Camera.main.pixelWidth || this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height != Camera.main.pixelHeight)
			{
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.width = Camera.main.pixelWidth;
				this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB.height = Camera.main.pixelHeight;
				this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = 0;
				this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.cullingMask = LayerMask.GetMask(new string[] { "preview_start_time" });
			}
		}
		if (this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture != this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB)
		{
			this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.targetTexture = this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB;
		}
		this.\u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5.backgroundColor = Color.black;
		Shader.SetGlobalTexture("Star Animation FPS", this.\u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB);
	}

	public RenderTexture \u02B3\u02B8\u02B5\u02B8\u02B2\u02B6\u02B8\u02B5\u02C0\u02C0\u02BB;

	private Camera \u02BB\u02C1\u02B3\u02B7\u02B5\u02C0\u02B6\u02C0\u02B8\u02BA\u02B5;
}
