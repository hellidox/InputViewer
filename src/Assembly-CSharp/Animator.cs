using System;
using UnityEngine;

// Token: 0x02000153 RID: 339
public class Animator : MonoBehaviour
{
	// Token: 0x06000EE1 RID: 3809 RVA: 0x0000E189 File Offset: 0x0000C389
	public void \u02B4\u02B5\u02BD\u02B9\u02C1\u02B3\u02B3\u02BF\u02B3\u02BD\u02B3()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.\u02B7\u02C0\u02BE\u02B9\u02BA\u02BE\u02B6\u02B3\u02B4\u02B4\u02B7 = 0;
		this.\u02BF\u02C0\u02B7\u02BA\u02B6\u02B5\u02BD\u02BD\u02BF\u02BC\u02B2 = 0;
		this.\u02BA\u02BE\u02BF\u02B9\u02B9\u02B9\u02C1\u02BA\u02B8\u02B9\u02C0();
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x0000E1AD File Offset: 0x0000C3AD
	public void \u02BD\u02B4\u02BA\u02BE\u02BD\u02BD\u02B3\u02BE\u02B6\u02B2\u02C1()
	{
		this.\u02B9\u02BD\u02B2\u02B5\u02B6\u02B7\u02BC\u02B9\u02B5\u02B9\u02BA = true;
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x0000E1B6 File Offset: 0x0000C3B6
	public void \u02B6\u02BC\u02BB\u02BE\u02B4\u02B3\u02B3\u02C1\u02B3\u02BE\u02C0()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.\u02B9\u02BD\u02B2\u02B5\u02B6\u02B7\u02BC\u02B9\u02B5\u02B9\u02BA)
		{
			this.\u02B8\u02BF\u02BA\u02BD\u02B9\u02BB\u02B2\u02BC\u02B5\u02B7\u02BD();
		}
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x0000E1E7 File Offset: 0x0000C3E7
	public void \u02BD\u02B8\u02B9\u02BF\u02BD\u02BC\u02C0\u02BB\u02C0\u02B8\u02BA()
	{
		this.\u02B9\u02BD\u02B2\u02B5\u02B6\u02B7\u02BC\u02B9\u02B5\u02B9\u02BA = false;
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
	private void Start()
	{
		this.\u02C1\u02B4\u02BE\u02B5\u02C0\u02B4\u02B4\u02B9\u02BF\u02BF\u02BC = base.GetComponent<SpriteRenderer>();
		if (this.\u02BA\u02BF\u02B3\u02BD\u02BF\u02B8\u02BE\u02BB\u02B9\u02B6\u02B6)
		{
			this.\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE();
		}
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x0000E20C File Offset: 0x0000C40C
	public void \u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(bool \u02C1\u02B8\u02B4\u02B7\u02C0\u02BA\u02B3\u02B2\u02B8\u02B5\u02B5)
	{
		this.\u02BB\u02C1\u02B3\u02C0\u02B4\u02B2\u02B4\u02C0\u02BF\u02B2\u02B3(\u02C1\u02B8\u02B4\u02B7\u02C0\u02BA\u02B3\u02B2\u02B8\u02B5\u02B5);
		this.\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE();
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x0000E21B File Offset: 0x0000C41B
	public void \u02B8\u02BF\u02BA\u02BD\u02B9\u02BB\u02B2\u02BC\u02B5\u02B7\u02BD()
	{
		this.\u02B7\u02C0\u02BE\u02B9\u02BA\u02BE\u02B6\u02B3\u02B4\u02B4\u02B7 = 0;
		this.\u02C1\u02B4\u02BE\u02B5\u02C0\u02B4\u02B4\u02B9\u02BF\u02BF\u02BC.sprite = null;
		this.\u02B9\u02BD\u02B2\u02B5\u02B6\u02B7\u02BC\u02B9\u02B5\u02B9\u02BA = false;
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x0000E189 File Offset: 0x0000C389
	public void \u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.\u02B7\u02C0\u02BE\u02B9\u02BA\u02BE\u02B6\u02B3\u02B4\u02B4\u02B7 = 0;
		this.\u02BF\u02C0\u02B7\u02BA\u02B6\u02B5\u02BD\u02BD\u02BF\u02BC\u02B2 = 0;
		this.\u02BA\u02BE\u02BF\u02B9\u02B9\u02B9\u02C1\u02BA\u02B8\u02B9\u02C0();
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x0000E237 File Offset: 0x0000C437
	public void \u02BB\u02C1\u02B3\u02C0\u02B4\u02B2\u02B4\u02C0\u02BF\u02B2\u02B3(bool \u02C1\u02B8\u02B4\u02B7\u02C0\u02BA\u02B3\u02B2\u02B8\u02B5\u02B5)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (\u02C1\u02B8\u02B4\u02B7\u02C0\u02BA\u02B3\u02B2\u02B8\u02B5\u02B5)
		{
			this.\u02C1\u02B4\u02BE\u02B5\u02C0\u02B4\u02B4\u02B9\u02BF\u02BF\u02BC.color = this.altparticleColor;
			return;
		}
		this.\u02C1\u02B4\u02BE\u02B5\u02C0\u02B4\u02B4\u02B9\u02BF\u02BF\u02BC.color = this.particleColor;
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x0000E1B6 File Offset: 0x0000C3B6
	public void \u02B8\u02B3\u02BD\u02B5\u02BC\u02B6\u02B8\u02C1\u02C0\u02BC\u02B7()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.\u02B9\u02BD\u02B2\u02B5\u02B6\u02B7\u02BC\u02B9\u02B5\u02B9\u02BA)
		{
			this.\u02B8\u02BF\u02BA\u02BD\u02B9\u02BB\u02B2\u02BC\u02B5\u02B7\u02BD();
		}
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x0000E26D File Offset: 0x0000C46D
	private void \u02B2\u02B7\u02B5\u02C0\u02B4\u02B3\u02B8\u02B3\u02C0\u02BD\u02B5()
	{
		this.\u02C1\u02B4\u02BE\u02B5\u02C0\u02B4\u02B4\u02B9\u02BF\u02BF\u02BC = base.GetComponent<SpriteRenderer>();
		if (this.\u02BA\u02BF\u02B3\u02BD\u02BF\u02B8\u02BE\u02BB\u02B9\u02B6\u02B6)
		{
			this.\u02B4\u02B5\u02BD\u02B9\u02C1\u02B3\u02B3\u02BF\u02B3\u02BD\u02B3();
		}
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x0000E1B6 File Offset: 0x0000C3B6
	public void \u02BE\u02BE\u02B4\u02BB\u02B8\u02BC\u02C0\u02C0\u02B3\u02B2\u02BE()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.\u02B9\u02BD\u02B2\u02B5\u02B6\u02B7\u02BC\u02B9\u02B5\u02B9\u02BA)
		{
			this.\u02B8\u02BF\u02BA\u02BD\u02B9\u02BB\u02B2\u02BC\u02B5\u02B7\u02BD();
		}
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x0000E1B6 File Offset: 0x0000C3B6
	public void \u02BC\u02BD\u02BD\u02B8\u02BC\u02C1\u02B7\u02B4\u02B4\u02C1\u02B3()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.\u02B9\u02BD\u02B2\u02B5\u02B6\u02B7\u02BC\u02B9\u02B5\u02B9\u02BA)
		{
			this.\u02B8\u02BF\u02BA\u02BD\u02B9\u02BB\u02B2\u02BC\u02B5\u02B7\u02BD();
		}
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x0000E1AD File Offset: 0x0000C3AD
	public void \u02BA\u02BE\u02BF\u02B9\u02B9\u02B9\u02C1\u02BA\u02B8\u02B9\u02C0()
	{
		this.\u02B9\u02BD\u02B2\u02B5\u02B6\u02B7\u02BC\u02B9\u02B5\u02B9\u02BA = true;
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x0000E1B6 File Offset: 0x0000C3B6
	public void \u02BB\u02B9\u02BE\u02B4\u02BC\u02C0\u02B9\u02BD\u02BF\u02B8\u02BC()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.\u02B9\u02BD\u02B2\u02B5\u02B6\u02B7\u02BC\u02B9\u02B5\u02B9\u02BA)
		{
			this.\u02B8\u02BF\u02BA\u02BD\u02B9\u02BB\u02B2\u02BC\u02B5\u02B7\u02BD();
		}
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x0000E1B6 File Offset: 0x0000C3B6
	public void \u02B5\u02BD\u02C0\u02BD\u02C1\u02B8\u02BE\u02C1\u02BE\u02B2\u02B4()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.\u02B9\u02BD\u02B2\u02B5\u02B6\u02B7\u02BC\u02B9\u02B5\u02B9\u02BA)
		{
			this.\u02B8\u02BF\u02BA\u02BD\u02B9\u02BB\u02B2\u02BC\u02B5\u02B7\u02BD();
		}
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x0000E237 File Offset: 0x0000C437
	public void \u02B8\u02BD\u02B5\u02B5\u02BB\u02BE\u02BB\u02B6\u02BD\u02B5\u02BB(bool \u02C1\u02B8\u02B4\u02B7\u02C0\u02BA\u02B3\u02B2\u02B8\u02B5\u02B5)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (\u02C1\u02B8\u02B4\u02B7\u02C0\u02BA\u02B3\u02B2\u02B8\u02B5\u02B5)
		{
			this.\u02C1\u02B4\u02BE\u02B5\u02C0\u02B4\u02B4\u02B9\u02BF\u02BF\u02BC.color = this.altparticleColor;
			return;
		}
		this.\u02C1\u02B4\u02BE\u02B5\u02C0\u02B4\u02B4\u02B9\u02BF\u02BF\u02BC.color = this.particleColor;
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x0000E1AD File Offset: 0x0000C3AD
	public void \u02BB\u02BA\u02BC\u02BB\u02B4\u02B6\u02B8\u02B8\u02BA\u02BE\u02B2()
	{
		this.\u02B9\u02BD\u02B2\u02B5\u02B6\u02B7\u02BC\u02B9\u02B5\u02B9\u02BA = true;
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x0000E189 File Offset: 0x0000C389
	public void \u02B7\u02BB\u02BC\u02BE\u02B7\u02B5\u02B2\u02BD\u02B4\u02BA\u02BD()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.\u02B7\u02C0\u02BE\u02B9\u02BA\u02BE\u02B6\u02B3\u02B4\u02B4\u02B7 = 0;
		this.\u02BF\u02C0\u02B7\u02BA\u02B6\u02B5\u02BD\u02BD\u02BF\u02BC\u02B2 = 0;
		this.\u02BA\u02BE\u02BF\u02B9\u02B9\u02B9\u02C1\u02BA\u02B8\u02B9\u02C0();
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x0000E289 File Offset: 0x0000C489
	public void \u02BD\u02B8\u02BA\u02BC\u02B4\u02BA\u02C0\u02B2\u02BA\u02B9\u02BE()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.\u02B7\u02C0\u02BE\u02B9\u02BA\u02BE\u02B6\u02B3\u02B4\u02B4\u02B7 = 0;
		this.\u02BF\u02C0\u02B7\u02BA\u02B6\u02B5\u02BD\u02BD\u02BF\u02BC\u02B2 = 0;
		this.\u02BB\u02BA\u02BC\u02BB\u02B4\u02B6\u02B8\u02B8\u02BA\u02BE\u02B2();
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x0007DC10 File Offset: 0x0007BE10
	private void Update()
	{
		if (cUtilityClass.rainbowFlames)
		{
			this.timeval += Time.deltaTime * cUtilityClass.rainbowFlameSpeed / 100f;
			this.particleColor = global::Animator.Rainbow(this.timeval);
			this.altparticleColor = global::Animator.Rainbow(this.timeval);
			this.particleColor = global::Animator.Rainbow(this.timeval);
			this.altparticleColor = global::Animator.Rainbow(this.timeval);
		}
		if (this.\u02B9\u02BD\u02B2\u02B5\u02B6\u02B7\u02BC\u02B9\u02B5\u02B9\u02BA)
		{
			this.\u02C1\u02B7\u02BA\u02B9\u02B2\u02C1\u02B9\u02B6\u02C0\u02B7\u02B5 += Time.deltaTime;
			while (this.\u02C1\u02B7\u02BA\u02B9\u02B2\u02C1\u02B9\u02B6\u02C0\u02B7\u02B5 >= this.\u02BD\u02C0\u02BD\u02BF\u02C1\u02B9\u02BB\u02B5\u02BD\u02B4\u02BC)
			{
				this.\u02C1\u02B7\u02BA\u02B9\u02B2\u02C1\u02B9\u02B6\u02C0\u02B7\u02B5 -= this.\u02BD\u02C0\u02BD\u02BF\u02C1\u02B9\u02BB\u02B5\u02BD\u02B4\u02BC;
				if (this.\u02B7\u02C0\u02BE\u02B9\u02BA\u02BE\u02B6\u02B3\u02B4\u02B4\u02B7 >= this.\u02B8\u02B8\u02C0\u02BC\u02B5\u02B4\u02C0\u02B9\u02BF\u02B9\u02B6.Length)
				{
					this.\u02B7\u02C0\u02BE\u02B9\u02BA\u02BE\u02B6\u02B3\u02B4\u02B4\u02B7 = 0;
					this.\u02BF\u02C0\u02B7\u02BA\u02B6\u02B5\u02BD\u02BD\u02BF\u02BC\u02B2++;
					if (this.\u02BF\u02C0\u02B7\u02BA\u02B6\u02B5\u02BD\u02BD\u02BF\u02BC\u02B2 >= this.\u02B9\u02BB\u02B8\u02B8\u02B2\u02B5\u02BF\u02C0\u02C0\u02C0\u02B5 && this.\u02B9\u02BB\u02B8\u02B8\u02B2\u02B5\u02BF\u02C0\u02C0\u02C0\u02B5 != -1)
					{
						this.\u02B8\u02BF\u02BA\u02BD\u02B9\u02BB\u02B2\u02BC\u02B5\u02B7\u02BD();
						return;
					}
				}
				this.\u02C1\u02B4\u02BE\u02B5\u02C0\u02B4\u02B4\u02B9\u02BF\u02BF\u02BC.sprite = this.\u02B8\u02B8\u02C0\u02BC\u02B5\u02B4\u02C0\u02B9\u02BF\u02B9\u02B6[this.\u02B7\u02C0\u02BE\u02B9\u02BA\u02BE\u02B6\u02B3\u02B4\u02B4\u02B7];
				this.\u02B7\u02C0\u02BE\u02B9\u02BA\u02BE\u02B6\u02B3\u02B4\u02B4\u02B7++;
			}
		}
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x0007DD34 File Offset: 0x0007BF34
	public static Color Rainbow(float progress)
	{
		float num = Math.Abs(progress % 1f) * 6f;
		int num2 = (int)(num % 1f * 255f);
		int num3 = 255 - num2;
		switch ((int)num)
		{
		case 0:
			return new Color(1f, (float)num2 / 255f, 0f);
		case 1:
			return new Color((float)num3 / 255f, 1f, 0f);
		case 2:
			return new Color(0f, 1f, (float)num2 / 255f);
		case 3:
			return new Color(0f, (float)num3 / 255f, 1f);
		case 4:
			return new Color((float)num2 / 255f, 0f, 1f);
		default:
			return new Color(1f, 0f, (float)num3 / 255f);
		}
	}

	// Token: 0x04000B1B RID: 2843
	public float \u02BD\u02C0\u02BD\u02BF\u02C1\u02B9\u02BB\u02B5\u02BD\u02B4\u02BC = 0.01f;

	// Token: 0x04000B1C RID: 2844
	private SpriteRenderer \u02C1\u02B4\u02BE\u02B5\u02C0\u02B4\u02B4\u02B9\u02BF\u02BF\u02BC;

	// Token: 0x04000B1D RID: 2845
	private int \u02B7\u02C0\u02BE\u02B9\u02BA\u02BE\u02B6\u02B3\u02B4\u02B4\u02B7;

	// Token: 0x04000B1E RID: 2846
	public Sprite[] \u02B8\u02B8\u02C0\u02BC\u02B5\u02B4\u02C0\u02B9\u02BF\u02B9\u02B6;

	// Token: 0x04000B1F RID: 2847
	private bool \u02B9\u02BD\u02B2\u02B5\u02B6\u02B7\u02BC\u02B9\u02B5\u02B9\u02BA;

	// Token: 0x04000B20 RID: 2848
	private float \u02C1\u02B7\u02BA\u02B9\u02B2\u02C1\u02B9\u02B6\u02C0\u02B7\u02B5;

	// Token: 0x04000B21 RID: 2849
	public Color particleColor;

	// Token: 0x04000B22 RID: 2850
	public Color altparticleColor;

	// Token: 0x04000B23 RID: 2851
	public int \u02B9\u02BB\u02B8\u02B8\u02B2\u02B5\u02BF\u02C0\u02C0\u02C0\u02B5;

	// Token: 0x04000B24 RID: 2852
	private int \u02BF\u02C0\u02B7\u02BA\u02B6\u02B5\u02BD\u02BD\u02BF\u02BC\u02B2;

	// Token: 0x04000B25 RID: 2853
	public bool \u02BA\u02BF\u02B3\u02BD\u02BF\u02B8\u02BE\u02BB\u02B9\u02B6\u02B6;

	// Token: 0x04000B26 RID: 2854
	public static float rainbowmul = 0.1f;

	// Token: 0x04000B27 RID: 2855
	public static bool rainbowenabled = false;

	// Token: 0x04000B28 RID: 2856
	private float timeval;

	// Token: 0x02000154 RID: 340
	public struct HSVColor
	{
		// Token: 0x06000EF9 RID: 3833 RVA: 0x0000E2BF File Offset: 0x0000C4BF
		public HSVColor(float hue, float saturation, float value, float alpha = 1f)
		{
			this.h = hue;
			this.s = saturation;
			this.v = value;
			this.a = alpha;
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0007DE18 File Offset: 0x0007C018
		public HSVColor(Color color)
		{
			Debug.Log(color);
			this.h = 0f;
			this.s = 0f;
			this.v = 0f;
			this.a = 0f;
			float r = color.r;
			float g = color.g;
			float b = color.b;
			float num = Mathf.Min(r, Mathf.Min(g, b));
			float num2 = Mathf.Max(r, Mathf.Max(g, b));
			float num3 = num2 - num;
			float num4 = num2;
			float num5 = 0f;
			if (num3 == 0f)
			{
				return;
			}
			float num6 = num3 / num2;
			float num7 = ((num2 - r) / 6f + num3 / 2f) / num3;
			float num8 = ((num2 - g) / 6f + num3 / 2f) / num3;
			float num9 = ((num2 - b) / 6f + num3 / 2f) / num3;
			if (r == num2)
			{
				num5 = num9 - num8;
			}
			else if (g == num2)
			{
				num5 = 0f + num7 - num9;
			}
			else if (b == num2)
			{
				num5 = 0f + num8 - num7;
			}
			if (num5 < 0f)
			{
				num5 += 1f;
			}
			if (num5 > 1f)
			{
				num5 -= 1f;
			}
			this.h = num5;
			this.s = num6;
			this.v = num4;
			this.a = color.a;
			Debug.Log(string.Format("constructor H {0:0.00} S {1:0.00} V {2:0.00}", this.h, this.s, this.v));
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0007DFA8 File Offset: 0x0007C1A8
		public static Color HSVToRGB(float H, float S, float V)
		{
			Debug.Log(string.Format("H {0:0.00} S {1:0.00} V {2:0.00}", H, S, V));
			if ((double)S < 0.001 && (double)S > -0.001)
			{
				return new Color(V, V, V);
			}
			float num = H * 6f;
			if (num == 6f)
			{
				num = 0f;
			}
			int num2 = Mathf.FloorToInt(num);
			float num3 = V * (1f - S);
			float num4 = V * (1f - S * (num - (float)num2));
			float num5 = V * (1f - S * (1f - (num - (float)num2)));
			float num6;
			float num7;
			float num8;
			if (num2 == 0)
			{
				num6 = V;
				num7 = num5;
				num8 = num3;
			}
			else if (num2 == 1)
			{
				num6 = num4;
				num7 = V;
				num8 = num3;
			}
			else if (num2 == 2)
			{
				num6 = num3;
				num7 = V;
				num8 = num5;
			}
			else if (num2 == 3)
			{
				num6 = num3;
				num7 = num4;
				num8 = V;
			}
			else if (num2 == 4)
			{
				num6 = num5;
				num7 = num3;
				num8 = V;
			}
			else
			{
				num6 = V;
				num7 = num3;
				num8 = num4;
			}
			float num9 = Mathf.Clamp(num6, 0f, 1f);
			float num10 = Mathf.Clamp(num7, 0f, 1f);
			float num11 = Mathf.Clamp(num8, 0f, 1f);
			Color color = new Color(num9, num10, num11);
			Debug.Log(color);
			return color;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0000E2DE File Offset: 0x0000C4DE
		public static Color HSVToRGB(global::Animator.HSVColor c)
		{
			return global::Animator.HSVColor.HSVToRGB(c.h, c.s, c.v);
		}

		// Token: 0x04000B29 RID: 2857
		public float h;

		// Token: 0x04000B2A RID: 2858
		public float s;

		// Token: 0x04000B2B RID: 2859
		public float v;

		// Token: 0x04000B2C RID: 2860
		public float a;
	}
}
