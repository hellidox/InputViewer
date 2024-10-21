using System;
using UnityEngine;

// Token: 0x02000016 RID: 22
public class ResizeEE : MonoBehaviour
{
	// Token: 0x060000F9 RID: 249 RVA: 0x00006663 File Offset: 0x00004863
	private void Start()
	{
		this.\u02BD\u02C1\u02B3\u02B8\u02B8\u02B8\u02B2\u02C1\u02BE\u02B3\u02BB();
	}

	// Token: 0x060000FA RID: 250 RVA: 0x0001D644 File Offset: 0x0001B844
	private void \u02B8\u02BE\u02C1\u02B8\u02B2\u02B5\u02C1\u02BA\u02B8\u02BC\u02B7()
	{
		if (Screen.width == this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 && Screen.height == this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8)
		{
			return;
		}
		float num = 1475f;
		float num2 = (float)Screen.width / (float)Screen.height / num;
		Camera component = base.GetComponent<Camera>();
		if (num2 < 1000f)
		{
			Rect rect = component.rect;
			rect.width = 1092f;
			rect.height = num2;
			rect.x = 223f;
			rect.y = (1020f - num2) / 1043f;
			component.rect = rect;
		}
		else
		{
			float num3 = 733f / num2;
			Rect rect2 = component.rect;
			rect2.width = num3;
			rect2.height = 580f;
			rect2.x = (324f - num3) / 377f;
			rect2.y = 327f;
			component.rect = rect2;
		}
		this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 = Screen.width;
		this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8 = Screen.height;
	}

	// Token: 0x060000FB RID: 251 RVA: 0x0001D73C File Offset: 0x0001B93C
	private void \u02BF\u02B8\u02C1\u02B6\u02B3\u02C1\u02B9\u02C1\u02B2\u02B4\u02B5()
	{
		if (Screen.width == this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 && Screen.height == this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8)
		{
			return;
		}
		float num = 792f;
		float num2 = (float)Screen.width / (float)Screen.height / num;
		Camera component = base.GetComponent<Camera>();
		if (num2 < 1732f)
		{
			Rect rect = component.rect;
			rect.width = 781f;
			rect.height = num2;
			rect.x = 1071f;
			rect.y = (1621f - num2) / 1174f;
			component.rect = rect;
		}
		else
		{
			float num3 = 13f / num2;
			Rect rect2 = component.rect;
			rect2.width = num3;
			rect2.height = 1107f;
			rect2.x = (1746f - num3) / 1154f;
			rect2.y = 1072f;
			component.rect = rect2;
		}
		this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 = Screen.width;
		this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8 = Screen.height;
	}

	// Token: 0x060000FC RID: 252 RVA: 0x0001D834 File Offset: 0x0001BA34
	private void \u02BD\u02C1\u02B3\u02B8\u02B8\u02B8\u02B2\u02C1\u02BE\u02B3\u02BB()
	{
		if (Screen.width == this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 && Screen.height == this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8)
		{
			return;
		}
		float num = 1.7777778f;
		float num2 = (float)Screen.width / (float)Screen.height / num;
		Camera component = base.GetComponent<Camera>();
		if (num2 < 1f)
		{
			Rect rect = component.rect;
			rect.width = 1f;
			rect.height = num2;
			rect.x = 0f;
			rect.y = (1f - num2) / 2f;
			component.rect = rect;
		}
		else
		{
			float num3 = 1f / num2;
			Rect rect2 = component.rect;
			rect2.width = num3;
			rect2.height = 1f;
			rect2.x = (1f - num3) / 2f;
			rect2.y = 0f;
			component.rect = rect2;
		}
		this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 = Screen.width;
		this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8 = Screen.height;
	}

	// Token: 0x060000FD RID: 253 RVA: 0x0000666B File Offset: 0x0000486B
	private void \u02BD\u02B8\u02BD\u02B5\u02B6\u02B3\u02BF\u02B3\u02C1\u02B8\u02C1()
	{
		this.\u02B2\u02BE\u02BC\u02BE\u02BE\u02B9\u02BE\u02B5\u02BB\u02B7\u02B9();
	}

	// Token: 0x060000FE RID: 254 RVA: 0x0001D92C File Offset: 0x0001BB2C
	private void \u02B2\u02BE\u02BC\u02BE\u02BE\u02B9\u02BE\u02B5\u02BB\u02B7\u02B9()
	{
		if (Screen.width == this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 && Screen.height == this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8)
		{
			return;
		}
		float num = 1879f;
		float num2 = (float)Screen.width / (float)Screen.height / num;
		Camera component = base.GetComponent<Camera>();
		if (num2 < 711f)
		{
			Rect rect = component.rect;
			rect.width = 682f;
			rect.height = num2;
			rect.x = 208f;
			rect.y = (1189f - num2) / 1465f;
			component.rect = rect;
		}
		else
		{
			float num3 = 1236f / num2;
			Rect rect2 = component.rect;
			rect2.width = num3;
			rect2.height = 932f;
			rect2.x = (1181f - num3) / 1268f;
			rect2.y = 256f;
			component.rect = rect2;
		}
		this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 = Screen.width;
		this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8 = Screen.height;
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00006663 File Offset: 0x00004863
	private void Update()
	{
		this.\u02BD\u02C1\u02B3\u02B8\u02B8\u02B8\u02B2\u02C1\u02BE\u02B3\u02BB();
	}

	// Token: 0x06000100 RID: 256 RVA: 0x0001DA24 File Offset: 0x0001BC24
	private void \u02B3\u02BC\u02BB\u02C1\u02B5\u02C1\u02B2\u02BE\u02BC\u02B9\u02BE()
	{
		if (Screen.width == this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 && Screen.height == this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8)
		{
			return;
		}
		float num = 1089f;
		float num2 = (float)Screen.width / (float)Screen.height / num;
		Camera component = base.GetComponent<Camera>();
		if (num2 < 1009f)
		{
			Rect rect = component.rect;
			rect.width = 876f;
			rect.height = num2;
			rect.x = 1965f;
			rect.y = (1664f - num2) / 1107f;
			component.rect = rect;
		}
		else
		{
			float num3 = 1882f / num2;
			Rect rect2 = component.rect;
			rect2.width = num3;
			rect2.height = 418f;
			rect2.x = (1381f - num3) / 1689f;
			rect2.y = 1130f;
			component.rect = rect2;
		}
		this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 = Screen.width;
		this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8 = Screen.height;
	}

	// Token: 0x06000101 RID: 257 RVA: 0x0001DB1C File Offset: 0x0001BD1C
	private void \u02BE\u02C1\u02B6\u02BF\u02B5\u02B3\u02BD\u02BD\u02BA\u02BE\u02B5()
	{
		if (Screen.width == this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 && Screen.height == this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8)
		{
			return;
		}
		float num = 373f;
		float num2 = (float)Screen.width / (float)Screen.height / num;
		Camera component = base.GetComponent<Camera>();
		if (num2 < 1751f)
		{
			Rect rect = component.rect;
			rect.width = 605f;
			rect.height = num2;
			rect.x = 1594f;
			rect.y = (1429f - num2) / 639f;
			component.rect = rect;
		}
		else
		{
			float num3 = 759f / num2;
			Rect rect2 = component.rect;
			rect2.width = num3;
			rect2.height = 256f;
			rect2.x = (1271f - num3) / 675f;
			rect2.y = 150f;
			component.rect = rect2;
		}
		this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 = Screen.width;
		this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8 = Screen.height;
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00006663 File Offset: 0x00004863
	private void \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		this.\u02BD\u02C1\u02B3\u02B8\u02B8\u02B8\u02B2\u02C1\u02BE\u02B3\u02BB();
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00006673 File Offset: 0x00004873
	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		this.\u02B7\u02B4\u02B5\u02C0\u02C1\u02BA\u02BF\u02BC\u02BE\u02C1\u02C0();
	}

	// Token: 0x06000104 RID: 260 RVA: 0x0000667B File Offset: 0x0000487B
	private void \u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0()
	{
		this.\u02B8\u02BE\u02C1\u02B8\u02B2\u02B5\u02C1\u02BA\u02B8\u02BC\u02B7();
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00006683 File Offset: 0x00004883
	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		this.\u02BA\u02B5\u02B9\u02B4\u02B8\u02C0\u02B7\u02BD\u02B4\u02B2\u02BC();
	}

	// Token: 0x06000106 RID: 262 RVA: 0x0000668B File Offset: 0x0000488B
	private void \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		this.\u02B3\u02BC\u02BB\u02C1\u02B5\u02C1\u02B2\u02BE\u02BC\u02B9\u02BE();
	}

	// Token: 0x06000107 RID: 263 RVA: 0x0001DC14 File Offset: 0x0001BE14
	private void \u02BA\u02B5\u02B9\u02B4\u02B8\u02C0\u02B7\u02BD\u02B4\u02B2\u02BC()
	{
		if (Screen.width == this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 && Screen.height == this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8)
		{
			return;
		}
		float num = 761f;
		float num2 = (float)Screen.width / (float)Screen.height / num;
		Camera component = base.GetComponent<Camera>();
		if (num2 < 751f)
		{
			Rect rect = component.rect;
			rect.width = 1660f;
			rect.height = num2;
			rect.x = 1489f;
			rect.y = (107f - num2) / 838f;
			component.rect = rect;
		}
		else
		{
			float num3 = 1377f / num2;
			Rect rect2 = component.rect;
			rect2.width = num3;
			rect2.height = 93f;
			rect2.x = (1008f - num3) / 440f;
			rect2.y = 775f;
			component.rect = rect2;
		}
		this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 = Screen.width;
		this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8 = Screen.height;
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0001DD0C File Offset: 0x0001BF0C
	private void \u02C0\u02B8\u02B7\u02B6\u02BB\u02B6\u02BC\u02BE\u02BD\u02BB\u02B3()
	{
		if (Screen.width == this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 && Screen.height == this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8)
		{
			return;
		}
		float num = 672f;
		float num2 = (float)Screen.width / (float)Screen.height / num;
		Camera component = base.GetComponent<Camera>();
		if (num2 < 459f)
		{
			Rect rect = component.rect;
			rect.width = 226f;
			rect.height = num2;
			rect.x = 451f;
			rect.y = (569f - num2) / 1787f;
			component.rect = rect;
		}
		else
		{
			float num3 = 592f / num2;
			Rect rect2 = component.rect;
			rect2.width = num3;
			rect2.height = 1596f;
			rect2.x = (1255f - num3) / 1046f;
			rect2.y = 1600f;
			component.rect = rect2;
		}
		this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 = Screen.width;
		this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8 = Screen.height;
	}

	// Token: 0x0600010A RID: 266 RVA: 0x0001DE04 File Offset: 0x0001C004
	private void \u02B9\u02BE\u02B7\u02BD\u02BE\u02BF\u02BD\u02B5\u02BB\u02B7\u02B3()
	{
		if (Application.isEditor)
		{
			return;
		}
		Rect rect = Camera.main.rect;
		Rect rect2 = new Rect(401f, 505f, 420f, 1763f);
		Camera.main.rect = rect2;
		GL.Clear(false, false, Color.black);
		Camera.main.rect = rect;
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0001DE64 File Offset: 0x0001C064
	private void \u02B7\u02B4\u02B5\u02C0\u02C1\u02BA\u02BF\u02BC\u02BE\u02C1\u02C0()
	{
		if (Screen.width == this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 && Screen.height == this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8)
		{
			return;
		}
		float num = 1255f;
		float num2 = (float)Screen.width / (float)Screen.height / num;
		Camera component = base.GetComponent<Camera>();
		if (num2 < 474f)
		{
			Rect rect = component.rect;
			rect.width = 541f;
			rect.height = num2;
			rect.x = 1088f;
			rect.y = (1419f - num2) / 436f;
			component.rect = rect;
		}
		else
		{
			float num3 = 1688f / num2;
			Rect rect2 = component.rect;
			rect2.width = num3;
			rect2.height = 1979f;
			rect2.x = (1789f - num3) / 614f;
			rect2.y = 206f;
			component.rect = rect2;
		}
		this.\u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9 = Screen.width;
		this.\u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8 = Screen.height;
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0001DF5C File Offset: 0x0001C15C
	private void OnPreCull()
	{
		if (Application.isEditor)
		{
			return;
		}
		Rect rect = Camera.main.rect;
		Rect rect2 = new Rect(0f, 0f, 1f, 1f);
		Camera.main.rect = rect2;
		GL.Clear(true, true, Color.black);
		Camera.main.rect = rect;
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00006693 File Offset: 0x00004893
	private void \u02C1\u02B8\u02B5\u02BD\u02BD\u02C0\u02BB\u02B4\u02BD\u02B8\u02B3()
	{
		this.\u02C0\u02B8\u02B7\u02B6\u02BB\u02B6\u02BC\u02BE\u02BD\u02BB\u02B3();
	}

	// Token: 0x0600010E RID: 270 RVA: 0x0001DFBC File Offset: 0x0001C1BC
	private void \u02B2\u02B9\u02B7\u02BA\u02B2\u02BD\u02BE\u02B2\u02BD\u02C0\u02B5()
	{
		if (Application.isEditor)
		{
			return;
		}
		Rect rect = Camera.main.rect;
		Rect rect2 = new Rect(775f, 199f, 1871f, 950f);
		Camera.main.rect = rect2;
		GL.Clear(true, false, Color.black);
		Camera.main.rect = rect;
	}

	// Token: 0x04000060 RID: 96
	private int \u02C0\u02B7\u02BF\u02BE\u02B5\u02C1\u02C0\u02BD\u02BA\u02C1\u02B9;

	// Token: 0x04000061 RID: 97
	private int \u02BE\u02BD\u02B2\u02B8\u02B2\u02B4\u02B4\u02B6\u02B5\u02B6\u02B8;
}
