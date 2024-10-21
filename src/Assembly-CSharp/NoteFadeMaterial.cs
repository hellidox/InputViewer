using System;
using UnityEngine;

// Token: 0x020001C3 RID: 451
internal class NoteFadeMaterial : TrackFadeMaterials
{
	// Token: 0x060013ED RID: 5101 RVA: 0x0009FF84 File Offset: 0x0009E184
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

	// Token: 0x060013EE RID: 5102 RVA: 0x000A0020 File Offset: 0x0009E220
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

	// Token: 0x060013EF RID: 5103 RVA: 0x0000D554 File Offset: 0x0000B754
	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B2\u02BD\u02BB\u02B2\u02B4\u02B5\u02B7\u02B4\u02B2\u02B4\u02B2()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.Notes;
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x000A00BC File Offset: 0x0009E2BC
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

	// Token: 0x060013F2 RID: 5106 RVA: 0x0000C609 File Offset: 0x0000A809
	public override \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02BC\u02BB\u02BE\u02C1\u02BB\u02B6\u02BF\u02BB\u02B2\u02B7\u02BD()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.All;
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x000A0158 File Offset: 0x0009E358
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

	// Token: 0x060013F4 RID: 5108 RVA: 0x0000D554 File Offset: 0x0000B754
	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B3\u02C0\u02BD\u02BA\u02C0\u02B4\u02B6\u02BF\u02B2\u02BD\u02BE()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.Notes;
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x000A01F4 File Offset: 0x0009E3F4
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

	// Token: 0x060013F6 RID: 5110 RVA: 0x0000D554 File Offset: 0x0000B754
	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B2\u02B9\u02C1\u02BB\u02B9\u02B6\u02B5\u02BB\u02BE\u02B4\u02BD()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.Notes;
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x0000C609 File Offset: 0x0000A809
	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B7\u02BD\u02B8\u02BC\u02B2\u02BE\u02BE\u02B5\u02B9\u02BE\u02B4()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.All;
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x0000C609 File Offset: 0x0000A809
	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02BE\u02B5\u02B2\u02BC\u02C0\u02B6\u02B4\u02B7\u02C1\u02C1\u02B7()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.All;
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x0000C609 File Offset: 0x0000A809
	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02BE\u02BD\u02B7\u02C0\u02BE\u02BA\u02C1\u02B4\u02BB\u02BB\u02C0()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.All;
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x000A0290 File Offset: 0x0009E490
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

	// Token: 0x060013FB RID: 5115 RVA: 0x000A032C File Offset: 0x0009E52C
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

	// Token: 0x060013FC RID: 5116 RVA: 0x0000C609 File Offset: 0x0000A809
	public virtual \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B5\u02BB\u02BE\u02B6\u02C1\u02BA\u02B7\u02B4\u02BF\u02BC\u02BA()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.All;
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x0000C609 File Offset: 0x0000A809
	public override \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B6\u02BE\u02B6\u02B7\u02BB\u02B8\u02B3\u02BA\u02B7\u02B3\u02BE()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.All;
	}

	// Token: 0x17000211 RID: 529
	// (get) Token: 0x060013FE RID: 5118 RVA: 0x0000D554 File Offset: 0x0000B754
	public override \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3
	{
		get
		{
			return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.Notes;
		}
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x000A03C8 File Offset: 0x0009E5C8
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
