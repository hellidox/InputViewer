using System;
using UnityEngine;

[ExecuteAlways]
public class AnimatorColorBehavior : MonoBehaviour
{
	private void Update()
	{
		if (this.ApplyColorization)
		{
			Color color = this.color * this.colorizeColor;
			color.r = Mathf.Clamp01((1f - color.r) * this.brightness + color.r);
			color.g = Mathf.Clamp01((1f - color.g) * this.brightness + color.g);
			color.b = Mathf.Clamp01((1f - color.b) * this.brightness + color.b);
			color.a = this.color.a;
			this.spriteRenderer.color = color;
		}
	}

	public Color color;

	[Range(0f, 1f)]
	public float brightness;

	public Color colorizeColor;

	public bool ApplyColorization;

	public SpriteRenderer spriteRenderer;
}
