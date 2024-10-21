using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000203 RID: 515
public class TextTruncExt : Text
{
	// Token: 0x06001716 RID: 5910 RVA: 0x000AFDF4 File Offset: 0x000ADFF4
	protected override void OnPopulateMesh(VertexHelper \u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1f)
		{
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA = base.text.Substring(0, base.cachedTextGenerator.characterCount - 4);
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA += "...";
		}
		base.OnPopulateMesh(\u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE);
	}

	// Token: 0x06001717 RID: 5911 RVA: 0x00011F41 File Offset: 0x00010141
	private void Update()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x000AFE80 File Offset: 0x000AE080
	protected virtual void \u02B9\u02BE\u02C1\u02BD\u02B3\u02B3\u02B3\u02C0\u02B3\u02B9\u02BD(VertexHelper \u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 92f)
		{
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA = base.text.Substring(0, base.cachedTextGenerator.characterCount - 4);
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA += "Press Enter to confirm";
		}
		base.OnPopulateMesh(\u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE);
	}

	// Token: 0x06001719 RID: 5913 RVA: 0x00011F41 File Offset: 0x00010141
	private void \u02BA\u02BA\u02C0\u02BA\u02BC\u02B9\u02B5\u02BE\u02BA\u02C0\u02BD()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

	// Token: 0x0600171A RID: 5914 RVA: 0x000AFF0C File Offset: 0x000AE10C
	protected virtual void \u02BE\u02BC\u02B2\u02BD\u02BD\u02BC\u02B4\u02B7\u02B8\u02B7\u02C1(VertexHelper \u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 439f)
		{
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA = base.text.Substring(1, base.cachedTextGenerator.characterCount - 3);
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA += "Language '{0}' resources does not contain path {1}.\nAvailable nodes from this level: '{2}'";
		}
		base.OnPopulateMesh(\u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE);
	}

	// Token: 0x0600171B RID: 5915 RVA: 0x000AFF98 File Offset: 0x000AE198
	protected virtual void \u02BA\u02B5\u02B9\u02BC\u02BC\u02B6\u02BB\u02B9\u02BD\u02BB\u02C0(VertexHelper \u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1915f)
		{
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA = base.text.Substring(1, base.cachedTextGenerator.characterCount - 3);
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA += "Cancel";
		}
		base.OnPopulateMesh(\u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE);
	}

	// Token: 0x0600171C RID: 5916 RVA: 0x00011F41 File Offset: 0x00010141
	private void \u02C1\u02B8\u02B5\u02BD\u02BD\u02C0\u02BB\u02B4\u02BD\u02B8\u02B3()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

	// Token: 0x0600171D RID: 5917 RVA: 0x00011F41 File Offset: 0x00010141
	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

	// Token: 0x0600171E RID: 5918 RVA: 0x000B0024 File Offset: 0x000AE224
	protected virtual void \u02BE\u02BA\u02B4\u02B3\u02BA\u02B5\u02B6\u02B9\u02C0\u02B4\u02B5(VertexHelper \u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1960f)
		{
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA = base.text.Substring(1, base.cachedTextGenerator.characterCount - 2);
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA += "Highway Shake";
		}
		base.OnPopulateMesh(\u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE);
	}

	// Token: 0x0600171F RID: 5919 RVA: 0x00011F41 File Offset: 0x00010141
	private void \u02BB\u02B7\u02C0\u02B3\u02C1\u02BD\u02B9\u02B2\u02B4\u02BE\u02B6()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

	// Token: 0x06001720 RID: 5920 RVA: 0x000B00B0 File Offset: 0x000AE2B0
	protected virtual void \u02BB\u02B7\u02BC\u02BF\u02B8\u02C0\u02B3\u02BD\u02B9\u02BA\u02BD(VertexHelper \u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 158f)
		{
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA = base.text.Substring(0, base.cachedTextGenerator.characterCount - 2);
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA += "hasHard";
		}
		base.OnPopulateMesh(\u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE);
	}

	// Token: 0x06001721 RID: 5921 RVA: 0x00011F41 File Offset: 0x00010141
	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

	// Token: 0x06001722 RID: 5922 RVA: 0x000B013C File Offset: 0x000AE33C
	protected virtual void \u02B8\u02B5\u02BE\u02BD\u02C0\u02B3\u02BC\u02B7\u02BB\u02B5\u02BD(VertexHelper \u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 695f)
		{
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA = base.text.Substring(1, base.cachedTextGenerator.characterCount - 1);
			this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA += "graphicsRestartNeeded";
		}
		base.OnPopulateMesh(\u02BF\u02B4\u02BE\u02BB\u02BE\u02BF\u02B6\u02B7\u02BF\u02B4\u02BE);
	}

	// Token: 0x06001723 RID: 5923 RVA: 0x00011F41 File Offset: 0x00010141
	private void \u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

	// Token: 0x06001724 RID: 5924 RVA: 0x00011F41 File Offset: 0x00010141
	private void \u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

	// Token: 0x06001726 RID: 5926 RVA: 0x00011F41 File Offset: 0x00010141
	private void \u02B5\u02B9\u02B7\u02B7\u02B6\u02B5\u02BC\u02BA\u02B4\u02B2\u02B4()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

	// Token: 0x040010AF RID: 4271
	private string \u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA = string.Empty;
}
