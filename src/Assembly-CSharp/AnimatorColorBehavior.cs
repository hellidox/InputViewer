using System;
using UnityEngine;

// Token: 0x020001BE RID: 446
[ExecuteAlways]
public class AnimatorColorBehavior : MonoBehaviour
{
	// Token: 0x060013BA RID: 5050 RVA: 0x0009EAE4 File Offset: 0x0009CCE4
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

	// Token: 0x04000EC0 RID: 3776
	public Color color;

	// Token: 0x04000EC1 RID: 3777
	[Range(0f, 1f)]
	public float brightness;

	// Token: 0x04000EC2 RID: 3778
	public Color colorizeColor;

	// Token: 0x04000EC3 RID: 3779
	public bool ApplyColorization;

	// Token: 0x04000EC4 RID: 3780
	public SpriteRenderer spriteRenderer;
}
