using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000015 RID: 21
[RequireComponent(typeof(Image))]
public class ExclamationWiggle : MonoBehaviour
{
	// Token: 0x060000E6 RID: 230 RVA: 0x00006644 File Offset: 0x00004844
	private void OnEnable()
	{
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.transform as RectTransform;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x0001CD84 File Offset: 0x0001AF84
	private void \u02BA\u02BA\u02C0\u02BA\u02BC\u02B9\u02B5\u02BE\u02BA\u02C0\u02BD()
	{
		float num = Time.realtimeSinceStartup * 779f;
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localRotation = Quaternion.Euler(562f, 846f, Mathf.Sin(num * 1949f) * 1434f * Mathf.Pow(Mathf.Sin(num) * 988f + 967f, 1658f));
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localScale = Vector3.one + Vector3.one * Mathf.Pow(Mathf.Sin(num) * 703f + 836f, 1130f) * 489f;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.color = Color.Lerp(this.\u02BE\u02BA\u02B2\u02B5\u02B2\u02B4\u02C1\u02BD\u02B4\u02B9\u02B8, Color.white, Mathf.Pow(Mathf.Sin(num) * 771f + 728f, 1712f));
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x0001CE64 File Offset: 0x0001B064
	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		float num = Time.realtimeSinceStartup * 1658f;
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localRotation = Quaternion.Euler(292f, 1982f, Mathf.Sin(num * 1675f) * 334f * Mathf.Pow(Mathf.Sin(num) * 1259f + 681f, 1150f));
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localScale = Vector3.one + Vector3.one * Mathf.Pow(Mathf.Sin(num) * 854f + 80f, 749f) * 818f;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.color = Color.Lerp(this.\u02BE\u02BA\u02B2\u02B5\u02B2\u02B4\u02C1\u02BD\u02B4\u02B9\u02B8, Color.white, Mathf.Pow(Mathf.Sin(num) * 1782f + 1285f, 1225f));
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x0001CF44 File Offset: 0x0001B144
	private void Update()
	{
		float num = Time.realtimeSinceStartup * 4f;
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localRotation = Quaternion.Euler(0f, 0f, Mathf.Sin(num * 3.5f) * 20f * Mathf.Pow(Mathf.Sin(num) * 0.45f + 0.65f, 2f));
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localScale = Vector3.one + Vector3.one * Mathf.Pow(Mathf.Sin(num) * 0.45f + 0.65f, 2f) * 0.15f;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.color = Color.Lerp(this.\u02BE\u02BA\u02B2\u02B5\u02B2\u02B4\u02C1\u02BD\u02B4\u02B9\u02B8, Color.white, Mathf.Pow(Mathf.Sin(num) * 0.45f + 0.65f, 2f));
	}

	// Token: 0x060000EA RID: 234 RVA: 0x0001D024 File Offset: 0x0001B224
	private void \u02BB\u02BC\u02BD\u02B9\u02B3\u02B3\u02BE\u02B4\u02B8\u02B2\u02B2()
	{
		float num = Time.realtimeSinceStartup * 544f;
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localRotation = Quaternion.Euler(312f, 924f, Mathf.Sin(num * 1819f) * 688f * Mathf.Pow(Mathf.Sin(num) * 783f + 1445f, 1130f));
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localScale = Vector3.one + Vector3.one * Mathf.Pow(Mathf.Sin(num) * 883f + 1030f, 1099f) * 551f;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.color = Color.Lerp(this.\u02BE\u02BA\u02B2\u02B5\u02B2\u02B4\u02C1\u02BD\u02B4\u02B9\u02B8, Color.white, Mathf.Pow(Mathf.Sin(num) * 1849f + 1982f, 620f));
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00006644 File Offset: 0x00004844
	private void \u02B3\u02C1\u02B9\u02B7\u02B4\u02BF\u02BD\u02B9\u02BB\u02BE\u02B6()
	{
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.transform as RectTransform;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
	}

	// Token: 0x060000EC RID: 236 RVA: 0x0001D104 File Offset: 0x0001B304
	private void \u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0()
	{
		float num = Time.realtimeSinceStartup * 735f;
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localRotation = Quaternion.Euler(612f, 1768f, Mathf.Sin(num * 821f) * 1887f * Mathf.Pow(Mathf.Sin(num) * 1668f + 881f, 322f));
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localScale = Vector3.one + Vector3.one * Mathf.Pow(Mathf.Sin(num) * 19f + 1366f, 1819f) * 50f;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.color = Color.Lerp(this.\u02BE\u02BA\u02B2\u02B5\u02B2\u02B4\u02C1\u02BD\u02B4\u02B9\u02B8, Color.white, Mathf.Pow(Mathf.Sin(num) * 1797f + 940f, 908f));
	}

	// Token: 0x060000ED RID: 237 RVA: 0x0001D1E4 File Offset: 0x0001B3E4
	private void \u02BC\u02B6\u02B8\u02BA\u02B2\u02B4\u02B7\u02B3\u02C0\u02B8\u02B7()
	{
		float num = Time.realtimeSinceStartup * 1070f;
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localRotation = Quaternion.Euler(1419f, 1774f, Mathf.Sin(num * 578f) * 1917f * Mathf.Pow(Mathf.Sin(num) * 936f + 522f, 1410f));
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localScale = Vector3.one + Vector3.one * Mathf.Pow(Mathf.Sin(num) * 37f + 814f, 1216f) * 808f;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.color = Color.Lerp(this.\u02BE\u02BA\u02B2\u02B5\u02B2\u02B4\u02C1\u02BD\u02B4\u02B9\u02B8, Color.white, Mathf.Pow(Mathf.Sin(num) * 1633f + 337f, 1922f));
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00006644 File Offset: 0x00004844
	private void \u02C0\u02B7\u02B3\u02BF\u02B9\u02B3\u02BB\u02C1\u02BB\u02BA\u02BF()
	{
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.transform as RectTransform;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00006644 File Offset: 0x00004844
	private void \u02B9\u02B7\u02C0\u02B7\u02C1\u02BA\u02BC\u02C0\u02C1\u02BD\u02B6()
	{
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.transform as RectTransform;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0001D2C4 File Offset: 0x0001B4C4
	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		float num = Time.realtimeSinceStartup * 935f;
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localRotation = Quaternion.Euler(1160f, 1609f, Mathf.Sin(num * 358f) * 347f * Mathf.Pow(Mathf.Sin(num) * 1183f + 1751f, 893f));
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localScale = Vector3.one + Vector3.one * Mathf.Pow(Mathf.Sin(num) * 255f + 1898f, 1570f) * 702f;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.color = Color.Lerp(this.\u02BE\u02BA\u02B2\u02B5\u02B2\u02B4\u02C1\u02BD\u02B4\u02B9\u02B8, Color.white, Mathf.Pow(Mathf.Sin(num) * 1360f + 239f, 1873f));
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00006644 File Offset: 0x00004844
	private void \u02BE\u02B9\u02B7\u02B5\u02BC\u02B2\u02B8\u02BC\u02C0\u02B9\u02BE()
	{
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.transform as RectTransform;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x0001D3A4 File Offset: 0x0001B5A4
	private void \u02B3\u02B2\u02BB\u02B3\u02B2\u02C1\u02C1\u02B3\u02B8\u02C1\u02B5()
	{
		float num = Time.realtimeSinceStartup * 1751f;
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localRotation = Quaternion.Euler(1103f, 1834f, Mathf.Sin(num * 1719f) * 160f * Mathf.Pow(Mathf.Sin(num) * 1589f + 1322f, 578f));
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localScale = Vector3.one + Vector3.one * Mathf.Pow(Mathf.Sin(num) * 1695f + 377f, 781f) * 1604f;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.color = Color.Lerp(this.\u02BE\u02BA\u02B2\u02B5\u02B2\u02B4\u02C1\u02BD\u02B4\u02B9\u02B8, Color.white, Mathf.Pow(Mathf.Sin(num) * 121f + 695f, 1630f));
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x0001D484 File Offset: 0x0001B684
	private void \u02C0\u02BB\u02B6\u02B9\u02B3\u02B4\u02B3\u02B7\u02BD\u02B8\u02C0()
	{
		float num = Time.realtimeSinceStartup * 1925f;
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localRotation = Quaternion.Euler(1490f, 1069f, Mathf.Sin(num * 741f) * 1650f * Mathf.Pow(Mathf.Sin(num) * 346f + 1297f, 404f));
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localScale = Vector3.one + Vector3.one * Mathf.Pow(Mathf.Sin(num) * 1066f + 1635f, 1836f) * 224f;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.color = Color.Lerp(this.\u02BE\u02BA\u02B2\u02B5\u02B2\u02B4\u02C1\u02BD\u02B4\u02B9\u02B8, Color.white, Mathf.Pow(Mathf.Sin(num) * 987f + 808f, 973f));
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00006644 File Offset: 0x00004844
	private void \u02B3\u02BC\u02BB\u02BF\u02C1\u02BE\u02B4\u02BC\u02BE\u02BF\u02B8()
	{
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.transform as RectTransform;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x0001D564 File Offset: 0x0001B764
	private void \u02B4\u02B6\u02BD\u02B5\u02C0\u02B6\u02BA\u02C1\u02C0\u02BC\u02BB()
	{
		float num = Time.realtimeSinceStartup * 253f;
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localRotation = Quaternion.Euler(252f, 196f, Mathf.Sin(num * 1204f) * 560f * Mathf.Pow(Mathf.Sin(num) * 892f + 894f, 1965f));
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2.localScale = Vector3.one + Vector3.one * Mathf.Pow(Mathf.Sin(num) * 1626f + 1415f, 1622f) * 1147f;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6.color = Color.Lerp(this.\u02BE\u02BA\u02B2\u02B5\u02B2\u02B4\u02C1\u02BD\u02B4\u02B9\u02B8, Color.white, Mathf.Pow(Mathf.Sin(num) * 1608f + 906f, 1895f));
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00006644 File Offset: 0x00004844
	private void \u02BA\u02B9\u02BF\u02BC\u02C1\u02B9\u02B7\u02B4\u02C1\u02BB\u02BB()
	{
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.transform as RectTransform;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00006644 File Offset: 0x00004844
	private void \u02B7\u02B9\u02B6\u02BB\u02BF\u02BB\u02BF\u02BD\u02B6\u02B9\u02C1()
	{
		this.\u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2 = base.transform as RectTransform;
		this.\u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6 = base.GetComponent<Image>();
	}

	// Token: 0x0400005D RID: 93
	private RectTransform \u02BF\u02BA\u02B5\u02BD\u02B2\u02C1\u02B6\u02BD\u02B6\u02B9\u02B2;

	// Token: 0x0400005E RID: 94
	private Image \u02B9\u02C1\u02BC\u02BD\u02B6\u02B5\u02C1\u02B8\u02BA\u02B3\u02B6;

	// Token: 0x0400005F RID: 95
	public Color \u02BE\u02BA\u02B2\u02B5\u02B2\u02B4\u02C1\u02BD\u02B4\u02B9\u02B8;
}
