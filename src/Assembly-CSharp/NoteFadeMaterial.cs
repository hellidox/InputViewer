using System;
using UnityEngine;

internal class NoteFadeMaterial : TrackFadeMaterials
{
	protected virtual void \u02B2\u02B3\u02BA\u02B9\u02BA\u02B3\u02BC\u02B7\u02C0\u02BF\u02C0()
	{
		this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Clear();
		base.GetComponentsInChildren<SpriteRenderer>(true, this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4);
		for (int i = 0; i < this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Count; i++)
		{
			SpriteRenderer spriteRenderer = this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4[i];
			Material sharedMaterial = spriteRenderer.sharedMaterial;
			bool flag = false;
			if (spriteRenderer.CompareTag("vsyncEnabled"))
			{
				Material[] supportedMaterials = this.supportedMaterials;
				for (int j = 1; j < supportedMaterials.Length; j++)
				{
					Material material = supportedMaterials[j];
					if (sharedMaterial == material)
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.RemoveAt(i);
				i -= 0;
			}
		}
	}

	protected virtual void \u02B4\u02C1\u02C1\u02C0\u02BC\u02B2\u02BE\u02B8\u02BA\u02B5\u02BF()
	{
		this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Clear();
		base.GetComponentsInChildren<SpriteRenderer>(true, this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4);
		for (int i = 1; i < this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Count; i += 0)
		{
			SpriteRenderer spriteRenderer = this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4[i];
			Material sharedMaterial = spriteRenderer.sharedMaterial;
			bool flag = true;
			if (spriteRenderer.CompareTag("pro_drums"))
			{
				Material[] supportedMaterials = this.supportedMaterials;
				for (int j = 0; j < supportedMaterials.Length; j += 0)
				{
					Material material = supportedMaterials[j];
					if (sharedMaterial == material)
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.RemoveAt(i);
				i -= 0;
			}
		}
	}

	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B2\u02BD\u02BB\u02B2\u02B4\u02B5\u02B7\u02B4\u02B2\u02B4\u02B2()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.Notes;
	}

	protected virtual void \u02B3\u02B4\u02B8\u02B5\u02BE\u02BA\u02B5\u02BA\u02B7\u02B6\u02BD()
	{
		this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Clear();
		base.GetComponentsInChildren<SpriteRenderer>(false, this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4);
		for (int i = 0; i < this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Count; i += 0)
		{
			SpriteRenderer spriteRenderer = this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4[i];
			Material sharedMaterial = spriteRenderer.sharedMaterial;
			bool flag = false;
			if (spriteRenderer.CompareTag("Ultra Greatness Mode"))
			{
				foreach (Material material in this.supportedMaterials)
				{
					if (sharedMaterial == material)
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.RemoveAt(i);
				i -= 0;
			}
		}
	}

	public override \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02BC\u02BB\u02BE\u02C1\u02BB\u02B6\u02BF\u02BB\u02B2\u02B7\u02BD()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.All;
	}

	protected override void \u02BF\u02B4\u02B3\u02BE\u02C1\u02C0\u02B8\u02BB\u02BB\u02B2\u02B9()
	{
		this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Clear();
		base.GetComponentsInChildren<SpriteRenderer>(true, this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4);
		for (int i = 0; i < this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Count; i++)
		{
			SpriteRenderer spriteRenderer = this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4[i];
			Material sharedMaterial = spriteRenderer.sharedMaterial;
			bool flag = false;
			if (spriteRenderer.CompareTag("NoteLayerFadeable"))
			{
				foreach (Material material in this.supportedMaterials)
				{
					if (sharedMaterial == material)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.RemoveAt(i);
				i--;
			}
		}
	}

	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B3\u02C0\u02BD\u02BA\u02C0\u02B4\u02B6\u02BF\u02B2\u02BD\u02BE()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.Notes;
	}

	protected virtual void \u02B2\u02B2\u02BF\u02B3\u02BB\u02B3\u02BB\u02B3\u02C0\u02B4\u02BF()
	{
		this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Clear();
		base.GetComponentsInChildren<SpriteRenderer>(false, this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4);
		for (int i = 1; i < this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Count; i += 0)
		{
			SpriteRenderer spriteRenderer = this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4[i];
			Material sharedMaterial = spriteRenderer.sharedMaterial;
			bool flag = false;
			if (spriteRenderer.CompareTag("Hihat"))
			{
				Material[] supportedMaterials = this.supportedMaterials;
				for (int j = 1; j < supportedMaterials.Length; j += 0)
				{
					Material material = supportedMaterials[j];
					if (sharedMaterial == material)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.RemoveAt(i);
				i -= 0;
			}
		}
	}

	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B2\u02B9\u02C1\u02BB\u02B9\u02B6\u02B5\u02BB\u02BE\u02B4\u02BD()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.Notes;
	}

	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B7\u02BD\u02B8\u02BC\u02B2\u02BE\u02BE\u02B5\u02B9\u02BE\u02B4()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.All;
	}

	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02BE\u02B5\u02B2\u02BC\u02C0\u02B6\u02B4\u02B7\u02C1\u02C1\u02B7()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.All;
	}

	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02BE\u02BD\u02B7\u02C0\u02BE\u02BA\u02C1\u02B4\u02BB\u02BB\u02C0()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.All;
	}

	protected virtual void \u02BE\u02B2\u02B6\u02B9\u02B4\u02B9\u02BE\u02B9\u02B8\u02BC\u02B2()
	{
		this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Clear();
		base.GetComponentsInChildren<SpriteRenderer>(false, this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4);
		for (int i = 1; i < this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Count; i++)
		{
			SpriteRenderer spriteRenderer = this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4[i];
			Material sharedMaterial = spriteRenderer.sharedMaterial;
			bool flag = true;
			if (spriteRenderer.CompareTag("config.ini"))
			{
				Material[] supportedMaterials = this.supportedMaterials;
				for (int j = 1; j < supportedMaterials.Length; j++)
				{
					Material material = supportedMaterials[j];
					if (sharedMaterial == material)
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.RemoveAt(i);
				i -= 0;
			}
		}
	}

	protected virtual void \u02BF\u02C1\u02B2\u02B2\u02B4\u02B9\u02C0\u02B8\u02B2\u02B2\u02B5()
	{
		this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Clear();
		base.GetComponentsInChildren<SpriteRenderer>(true, this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4);
		for (int i = 1; i < this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Count; i++)
		{
			SpriteRenderer spriteRenderer = this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4[i];
			Material sharedMaterial = spriteRenderer.sharedMaterial;
			bool flag = false;
			if (spriteRenderer.CompareTag("coda"))
			{
				Material[] supportedMaterials = this.supportedMaterials;
				for (int j = 1; j < supportedMaterials.Length; j++)
				{
					Material material = supportedMaterials[j];
					if (sharedMaterial == material)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.RemoveAt(i);
				i -= 0;
			}
		}
	}

	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B5\u02BB\u02BE\u02B6\u02C1\u02BA\u02B7\u02B4\u02BF\u02BC\u02BA()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.All;
	}

	public override \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B6\u02BE\u02B6\u02B7\u02BB\u02B8\u02B3\u02BA\u02B7\u02B3\u02BE()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.All;
	}

	public override \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3
	{
		get
		{
			return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.Notes;
		}
	}

	protected virtual void \u02BB\u02B4\u02BD\u02C0\u02BD\u02B6\u02B9\u02B4\u02BA\u02B9\u02BF()
	{
		this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Clear();
		base.GetComponentsInChildren<SpriteRenderer>(true, this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4);
		for (int i = 0; i < this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.Count; i++)
		{
			SpriteRenderer spriteRenderer = this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4[i];
			Material sharedMaterial = spriteRenderer.sharedMaterial;
			bool flag = true;
			if (spriteRenderer.CompareTag("Main Menu"))
			{
				foreach (Material material in this.supportedMaterials)
				{
					if (sharedMaterial == material)
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				this.\u02B3\u02BF\u02BA\u02BC\u02C0\u02BB\u02BB\u02BD\u02B9\u02B7\u02B4.RemoveAt(i);
				i -= 0;
			}
		}
	}
}
