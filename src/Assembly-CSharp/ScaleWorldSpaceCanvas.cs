using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200000D RID: 13
[DisallowMultipleComponent]
[ExecuteInEditMode]
[RequireComponent(typeof(Canvas))]
public class ScaleWorldSpaceCanvas : UIBehaviour
{
	// Token: 0x06000082 RID: 130 RVA: 0x0001A1C8 File Offset: 0x000183C8
	protected virtual void \u02B9\u02B3\u02B8\u02BB\u02BD\u02B2\u02BF\u02B5\u02C1\u02BE\u02B3()
	{
		Camera main = Camera.main;
		Vector2 vector = new Vector2((float)Screen.width, (float)Screen.height);
		if (main.targetTexture != null)
		{
			vector = new Vector2((float)main.targetTexture.width, (float)main.targetTexture.height);
		}
		float num = Mathf.Min(vector.x / this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.x, vector.y / this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.y);
		this.\u02B3\u02BA\u02C0\u02B9\u02B3\u02BF\u02B3\u02C0\u02B3\u02BE\u02B9(num);
		this.\u02BF\u02B6\u02B3\u02B3\u02B5\u02B5\u02C1\u02BF\u02C0\u02B8\u02B3((float)this.\u02B5\u02C1\u02B6\u02BC\u02BA\u02BB\u02B7\u02BB\u02BF\u02B4\u02B3);
		float num2 = vector.x / vector.y;
		float num3 = this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.x / this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.y;
		if (num2 > num3)
		{
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.sizeDelta = new Vector2(this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.y * num2, this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.y);
		}
		else
		{
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.sizeDelta = new Vector2(this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.x, this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.x * (133f / num2));
		}
		float num4 = 1794f * this.\u02C0\u02B2\u02B4\u02BE\u02BA\u02B3\u02C0\u02BD\u02B9\u02BA\u02C1 * Mathf.Tan(this.\u02B6\u02BA\u02B9\u02BF\u02B2\u02BF\u02B6\u02BF\u02B7\u02BE\u02B9.fieldOfView * 1540f * 1821f);
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localScale = Vector3.one * (num4 / this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.sizeDelta.y);
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.pivot = new Vector2(1830f, 342f);
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localPosition = Vector3.forward * this.\u02C0\u02B2\u02B4\u02BE\u02BA\u02B3\u02C0\u02BD\u02B9\u02BA\u02C1;
	}

	// Token: 0x06000083 RID: 131 RVA: 0x0001A368 File Offset: 0x00018568
	protected virtual void \u02B8\u02B8\u02BC\u02B4\u02BF\u02BA\u02B3\u02BA\u02B6\u02B2\u02B3()
	{
		this.\u02B2\u02B3\u02BF\u02BF\u02B8\u02B7\u02BB\u02B8\u02BF\u02BD\u02C0 = this;
		if (this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE == null || !this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE.isRootCanvas)
		{
			return;
		}
		if (this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE.renderMode != (RenderMode)3)
		{
			this.\u02B3\u02BB\u02C0\u02B4\u02BB\u02B2\u02BA\u02BA\u02BB\u02B9\u02B5.Clear();
			return;
		}
		this.\u02B3\u02BB\u02C0\u02B4\u02BB\u02B2\u02BA\u02BA\u02BB\u02B9\u02B5.Add(this.\u02B2\u02B3\u02BF\u02BF\u02B8\u02B7\u02BB\u02B8\u02BF\u02BD\u02C0, base.transform as RectTransform, DrivenTransformProperties.All);
		this.\u02B5\u02BC\u02BC\u02B9\u02B4\u02B7\u02BA\u02BD\u02BF\u02B5\u02B4();
	}

	// Token: 0x06000084 RID: 132 RVA: 0x0001A3D8 File Offset: 0x000185D8
	protected virtual void \u02C0\u02C1\u02B8\u02B9\u02B5\u02B5\u02BF\u02B4\u02B7\u02BB\u02B5()
	{
		this.\u02B2\u02B3\u02BF\u02BF\u02B8\u02B7\u02BB\u02B8\u02BF\u02BD\u02C0 = this;
		if (this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE == null || !this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE.isRootCanvas)
		{
			return;
		}
		if (this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE.renderMode != RenderMode.WorldSpace)
		{
			this.\u02B3\u02BB\u02C0\u02B4\u02BB\u02B2\u02BA\u02BA\u02BB\u02B9\u02B5.Clear();
			return;
		}
		this.\u02B3\u02BB\u02C0\u02B4\u02BB\u02B2\u02BA\u02BA\u02BB\u02B9\u02B5.Add(this.\u02B2\u02B3\u02BF\u02BF\u02B8\u02B7\u02BB\u02B8\u02BF\u02BD\u02C0, base.transform as RectTransform, DrivenTransformProperties.All);
		this.\u02B7\u02C0\u02B8\u02B3\u02BA\u02B6\u02C1\u02B5\u02B7\u02BE\u02C0();
	}

	// Token: 0x06000085 RID: 133 RVA: 0x000062D0 File Offset: 0x000044D0
	protected virtual void \u02B4\u02BF\u02B2\u02B9\u02B5\u02BE\u02BE\u02BA\u02C0\u02C1\u02BA()
	{
		this.\u02B3\u02BA\u02C0\u02B9\u02B3\u02BF\u02B3\u02C0\u02B3\u02BE\u02B9(1209f);
		this.\u02B6\u02B4\u02B9\u02B9\u02BB\u02BB\u02BF\u02B3\u02BF\u02B9\u02B5(1814f);
		base.OnDisable();
	}

	// Token: 0x06000086 RID: 134 RVA: 0x000062EE File Offset: 0x000044EE
	protected void \u02B4\u02BF\u02BD\u02BB\u02B8\u02B9\u02B8\u02BE\u02C1\u02B9\u02B9(float \u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3)
	{
		if (\u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3 == this.\u02B6\u02B6\u02B8\u02B8\u02B7\u02B6\u02B8\u02BD\u02B7\u02BC\u02BF)
		{
			return;
		}
		this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE.referencePixelsPerUnit = \u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3;
		this.\u02B6\u02B6\u02B8\u02B8\u02B7\u02B6\u02B8\u02BD\u02B7\u02BC\u02BF = \u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3;
	}

	// Token: 0x06000087 RID: 135 RVA: 0x0000630D File Offset: 0x0000450D
	public void \u02BC\u02B4\u02C0\u02BC\u02B6\u02C0\u02BB\u02B2\u02B3\u02BF\u02BE()
	{
		this.\u02C0\u02C1\u02B8\u02B9\u02B5\u02B5\u02BF\u02B4\u02B7\u02BB\u02B5();
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00006315 File Offset: 0x00004515
	protected virtual void \u02BD\u02B3\u02C0\u02B8\u02B8\u02B3\u02B6\u02B3\u02BF\u02BD\u02BE()
	{
		this.\u02B3\u02BA\u02C0\u02B9\u02B3\u02BF\u02B3\u02C0\u02B3\u02BE\u02B9(557f);
		this.\u02B6\u02B4\u02B9\u02B9\u02BB\u02BB\u02BF\u02B3\u02BF\u02B9\u02B5(648f);
		base.OnDisable();
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00006333 File Offset: 0x00004533
	public void \u02B9\u02BC\u02BB\u02B5\u02B7\u02B9\u02BE\u02B9\u02BC\u02BD\u02BD()
	{
		this.\u02B8\u02B8\u02BC\u02B4\u02BF\u02BA\u02B3\u02BA\u02B6\u02B2\u02B3();
	}

	// Token: 0x0600008A RID: 138 RVA: 0x0001A448 File Offset: 0x00018648
	protected virtual void \u02B5\u02BC\u02BC\u02B9\u02B4\u02B7\u02BA\u02BD\u02BF\u02B5\u02B4()
	{
		Camera main = Camera.main;
		Vector2 vector = new Vector2((float)Screen.width, (float)Screen.height);
		if (main.targetTexture != null)
		{
			vector = new Vector2((float)main.targetTexture.width, (float)main.targetTexture.height);
		}
		float num = Mathf.Min(vector.x / this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.x, vector.y / this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.y);
		this.\u02B3\u02BA\u02C0\u02B9\u02B3\u02BF\u02B3\u02C0\u02B3\u02BE\u02B9(num);
		this.\u02B4\u02BF\u02BD\u02BB\u02B8\u02B9\u02B8\u02BE\u02C1\u02B9\u02B9((float)this.\u02B5\u02C1\u02B6\u02BC\u02BA\u02BB\u02B7\u02BB\u02BF\u02B4\u02B3);
		float num2 = vector.x / vector.y;
		float num3 = this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.x / this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.y;
		if (num2 > num3)
		{
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.sizeDelta = new Vector2(this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.y * num2, this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.y);
		}
		else
		{
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.sizeDelta = new Vector2(this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.x, this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.x * (1954f / num2));
		}
		float num4 = 441f * this.\u02C0\u02B2\u02B4\u02BE\u02BA\u02B3\u02C0\u02BD\u02B9\u02BA\u02C1 * Mathf.Tan(this.\u02B6\u02BA\u02B9\u02BF\u02B2\u02BF\u02B6\u02BF\u02B7\u02BE\u02B9.fieldOfView * 451f * 1635f);
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localScale = Vector3.one * (num4 / this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.sizeDelta.y);
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.pivot = new Vector2(724f, 1824f);
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localPosition = Vector3.forward * this.\u02C0\u02B2\u02B4\u02BE\u02BA\u02B3\u02C0\u02BD\u02B9\u02BA\u02C1;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x0000630D File Offset: 0x0000450D
	protected virtual void LateUpdate()
	{
		this.\u02C0\u02C1\u02B8\u02B9\u02B5\u02B5\u02BF\u02B4\u02B7\u02BB\u02B5();
	}

	// Token: 0x0600008C RID: 140 RVA: 0x0001A5E8 File Offset: 0x000187E8
	protected virtual void \u02BD\u02BA\u02B5\u02C0\u02B3\u02BE\u02BC\u02C1\u02B2\u02BF\u02BB()
	{
		this.\u02B2\u02B3\u02BF\u02BF\u02B8\u02B7\u02BB\u02B8\u02BF\u02BD\u02C0 = this;
		if (this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE == null || !this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE.isRootCanvas)
		{
			return;
		}
		if (this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE.renderMode != (RenderMode)8)
		{
			this.\u02B3\u02BB\u02C0\u02B4\u02BB\u02B2\u02BA\u02BA\u02BB\u02B9\u02B5.Clear();
			return;
		}
		this.\u02B3\u02BB\u02C0\u02B4\u02BB\u02B2\u02BA\u02BA\u02BB\u02B9\u02B5.Add(this.\u02B2\u02B3\u02BF\u02BF\u02B8\u02B7\u02BB\u02B8\u02BF\u02BD\u02C0, base.transform as RectTransform, DrivenTransformProperties.All);
		this.\u02B5\u02BC\u02BC\u02B9\u02B4\u02B7\u02BA\u02BD\u02BF\u02B5\u02B4();
	}

	// Token: 0x0600008D RID: 141 RVA: 0x0000633B File Offset: 0x0000453B
	protected override void OnDisable()
	{
		this.\u02B3\u02BA\u02C0\u02B9\u02B3\u02BF\u02B3\u02C0\u02B3\u02BE\u02B9(1f);
		this.\u02B4\u02BF\u02BD\u02BB\u02B8\u02B9\u02B8\u02BE\u02C1\u02B9\u02B9(100f);
		base.OnDisable();
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00006359 File Offset: 0x00004559
	protected override void OnEnable()
	{
		base.OnEnable();
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.GetComponent<RectTransform>();
		this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE = base.GetComponent<Canvas>();
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000062EE File Offset: 0x000044EE
	protected void \u02BF\u02B6\u02B3\u02B3\u02B5\u02B5\u02C1\u02BF\u02C0\u02B8\u02B3(float \u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3)
	{
		if (\u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3 == this.\u02B6\u02B6\u02B8\u02B8\u02B7\u02B6\u02B8\u02BD\u02B7\u02BC\u02BF)
		{
			return;
		}
		this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE.referencePixelsPerUnit = \u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3;
		this.\u02B6\u02B6\u02B8\u02B8\u02B7\u02B6\u02B8\u02BD\u02B7\u02BC\u02BF = \u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x0001A6AC File Offset: 0x000188AC
	protected virtual void \u02B7\u02C0\u02B8\u02B3\u02BA\u02B6\u02C1\u02B5\u02B7\u02BE\u02C0()
	{
		Camera main = Camera.main;
		Vector2 vector = new Vector2((float)Screen.width, (float)Screen.height);
		if (main.targetTexture != null)
		{
			vector = new Vector2((float)main.targetTexture.width, (float)main.targetTexture.height);
		}
		float num = Mathf.Min(vector.x / this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.x, vector.y / this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.y);
		this.\u02B3\u02BA\u02C0\u02B9\u02B3\u02BF\u02B3\u02C0\u02B3\u02BE\u02B9(num);
		this.\u02B4\u02BF\u02BD\u02BB\u02B8\u02B9\u02B8\u02BE\u02C1\u02B9\u02B9((float)this.\u02B5\u02C1\u02B6\u02BC\u02BA\u02BB\u02B7\u02BB\u02BF\u02B4\u02B3);
		float num2 = vector.x / vector.y;
		float num3 = this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.x / this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.y;
		if (num2 > num3)
		{
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.sizeDelta = new Vector2(this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.y * num2, this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.y);
		}
		else
		{
			this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.sizeDelta = new Vector2(this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.x, this.\u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF.x * (1f / num2));
		}
		float num4 = 2f * this.\u02C0\u02B2\u02B4\u02BE\u02BA\u02B3\u02C0\u02BD\u02B9\u02BA\u02C1 * Mathf.Tan(this.\u02B6\u02BA\u02B9\u02BF\u02B2\u02BF\u02B6\u02BF\u02B7\u02BE\u02B9.fieldOfView * 0.5f * 0.017453292f);
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localScale = Vector3.one * (num4 / this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.sizeDelta.y);
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.pivot = new Vector2(0.5f, 0.5f);
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localPosition = Vector3.forward * this.\u02C0\u02B2\u02B4\u02BE\u02BA\u02B3\u02C0\u02BD\u02B9\u02BA\u02C1;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x0000630D File Offset: 0x0000450D
	public void \u02B5\u02BA\u02B4\u02BA\u02B5\u02B7\u02BA\u02B9\u02BD\u02BC\u02B7()
	{
		this.\u02C0\u02C1\u02B8\u02B9\u02B5\u02B5\u02BF\u02B4\u02B7\u02BB\u02B5();
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00006379 File Offset: 0x00004579
	protected void \u02B3\u02BA\u02C0\u02B9\u02B3\u02BF\u02B3\u02C0\u02B3\u02BE\u02B9(float \u02B7\u02B6\u02BD\u02BB\u02B2\u02B2\u02C0\u02C1\u02B8\u02BE\u02B8)
	{
		if (\u02B7\u02B6\u02BD\u02BB\u02B2\u02B2\u02C0\u02C1\u02B8\u02BE\u02B8 == this.\u02BB\u02BE\u02BD\u02B6\u02BC\u02B3\u02BF\u02B4\u02B2\u02B4\u02B3)
		{
			return;
		}
		this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE.scaleFactor = ((\u02B7\u02B6\u02BD\u02BB\u02B2\u02B2\u02C0\u02C1\u02B8\u02BE\u02B8 < float.Epsilon) ? 1f : \u02B7\u02B6\u02BD\u02BB\u02B2\u02B2\u02C0\u02C1\u02B8\u02BE\u02B8);
		this.\u02BB\u02BE\u02BD\u02B6\u02BC\u02B3\u02BF\u02B4\u02B2\u02B4\u02B3 = this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE.scaleFactor;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x000062EE File Offset: 0x000044EE
	protected void \u02B6\u02B4\u02B9\u02B9\u02BB\u02BB\u02BF\u02B3\u02BF\u02B9\u02B5(float \u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3)
	{
		if (\u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3 == this.\u02B6\u02B6\u02B8\u02B8\u02B7\u02B6\u02B8\u02BD\u02B7\u02BC\u02BF)
		{
			return;
		}
		this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE.referencePixelsPerUnit = \u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3;
		this.\u02B6\u02B6\u02B8\u02B8\u02B7\u02B6\u02B8\u02BD\u02B7\u02BC\u02BF = \u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x000062EE File Offset: 0x000044EE
	protected void \u02B7\u02BE\u02B2\u02B4\u02B2\u02B3\u02BF\u02BA\u02B4\u02B7\u02B5(float \u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3)
	{
		if (\u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3 == this.\u02B6\u02B6\u02B8\u02B8\u02B7\u02B6\u02B8\u02BD\u02B7\u02BC\u02BF)
		{
			return;
		}
		this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE.referencePixelsPerUnit = \u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3;
		this.\u02B6\u02B6\u02B8\u02B8\u02B7\u02B6\u02B8\u02BD\u02B7\u02BC\u02BF = \u02B5\u02B6\u02B7\u02B5\u02BD\u02B6\u02C0\u02BB\u02BF\u02B7\u02B3;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00006359 File Offset: 0x00004559
	protected virtual void \u02BB\u02BF\u02B7\u02BA\u02B5\u02B8\u02BA\u02B5\u02B7\u02B9\u02BE()
	{
		base.OnEnable();
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.GetComponent<RectTransform>();
		this.\u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE = base.GetComponent<Canvas>();
	}

	// Token: 0x0400002C RID: 44
	private Canvas \u02B2\u02B7\u02B7\u02B7\u02B6\u02C1\u02BA\u02BC\u02BE\u02B4\u02BE;

	// Token: 0x0400002D RID: 45
	private global::UnityEngine.Object \u02B2\u02B3\u02BF\u02BF\u02B8\u02B7\u02BB\u02B8\u02BF\u02BD\u02C0;

	// Token: 0x0400002E RID: 46
	private DrivenRectTransformTracker \u02B3\u02BB\u02C0\u02B4\u02BB\u02B2\u02BA\u02BA\u02BB\u02B9\u02B5;

	// Token: 0x0400002F RID: 47
	private RectTransform \u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2;

	// Token: 0x04000030 RID: 48
	public Camera \u02B6\u02BA\u02B9\u02BF\u02B2\u02BF\u02B6\u02BF\u02B7\u02BE\u02B9;

	// Token: 0x04000031 RID: 49
	public float \u02C0\u02B2\u02B4\u02BE\u02BA\u02B3\u02C0\u02BD\u02B9\u02BA\u02C1 = 100f;

	// Token: 0x04000032 RID: 50
	public Vector2 \u02B2\u02B7\u02BC\u02C0\u02B3\u02B9\u02BB\u02B3\u02B8\u02BF\u02BF = new Vector2(1920f, 1080f);

	// Token: 0x04000033 RID: 51
	public int \u02B5\u02C1\u02B6\u02BC\u02BA\u02BB\u02B7\u02BB\u02BF\u02B4\u02B3 = 100;

	// Token: 0x04000034 RID: 52
	[NonSerialized]
	private float \u02BB\u02BE\u02BD\u02B6\u02BC\u02B3\u02BF\u02B4\u02B2\u02B4\u02B3 = 1f;

	// Token: 0x04000035 RID: 53
	[NonSerialized]
	private float \u02B6\u02B6\u02B8\u02B8\u02B7\u02B6\u02B8\u02BD\u02B7\u02BC\u02BF = 100f;
}
