using System;
using UnityEngine;
using UnityEngine.UI;

public class TextTruncExt : Text
{
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

	private void Update()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

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

	private void \u02BA\u02BA\u02C0\u02BA\u02BC\u02B9\u02B5\u02BE\u02BA\u02C0\u02BD()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

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

	private void \u02C1\u02B8\u02B5\u02BD\u02BD\u02C0\u02BB\u02B4\u02BD\u02B8\u02B3()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

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

	private void \u02BB\u02B7\u02C0\u02B3\u02C1\u02BD\u02B9\u02B2\u02B4\u02BE\u02B6()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

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

	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

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

	private void \u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

	private void \u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

	private void \u02B5\u02B9\u02B7\u02B7\u02B6\u02B5\u02BC\u02BA\u02B4\u02B2\u02B4()
	{
		if (this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != string.Empty && this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA != base.text)
		{
			base.text = this.\u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA;
		}
	}

	private string \u02B5\u02C1\u02BA\u02B3\u02BF\u02BA\u02B6\u02C0\u02B2\u02B3\u02BA = string.Empty;
}
