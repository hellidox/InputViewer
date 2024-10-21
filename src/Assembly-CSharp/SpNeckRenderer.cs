using System;
using System.Collections;
using System.IO;
using UnityEngine;

// Token: 0x020001C4 RID: 452
public class SpNeckRenderer : MonoBehaviour
{
	// Token: 0x06001400 RID: 5120 RVA: 0x00010820 File Offset: 0x0000EA20
	private void \u02BE\u02B6\u02B9\u02B2\u02C1\u02B9\u02B8\u02B6\u02B4\u02B3\u02B3()
	{
		this.spController = base.GetComponentInChildren<StarPowerController>();
	}

	// Token: 0x06001401 RID: 5121 RVA: 0x0001082E File Offset: 0x0000EA2E
	public void \u02B5\u02B4\u02B8\u02B4\u02BF\u02B7\u02BC\u02BD\u02B4\u02B5\u02B7()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = true;
		GameAudioManager.PlaySound(SoundID.StarPowerDeployed);
		if (SettingsController.\u02C1\u02B3\u02BA\u02B9\u02B4\u02B3\u02BB\u02B6\u02BC\u02BC\u02BB)
		{
			base.StartCoroutine(this.\u02B9\u02C0\u02BE\u02B7\u02C1\u02B7\u02BD\u02B3\u02BE\u02B4\u02B4());
		}
	}

	// Token: 0x06001402 RID: 5122 RVA: 0x00010856 File Offset: 0x0000EA56
	private IEnumerator AnimateSP()
	{
		Texture2D texture2D = new Texture2D(64, 64, TextureFormat.RGB24, false);
		texture2D.LoadImage(File.ReadAllBytes("C:\\temp\\anthony.png"), false);
		foreach (SpriteRenderer spriteRenderer in this.spController.breathingRenderers)
		{
			Sprite sprite = Sprite.Create(texture2D, spriteRenderer.sprite.rect, spriteRenderer.sprite.pivot, spriteRenderer.sprite.pixelsPerUnit, 0U, SpriteMeshType.FullRect);
			spriteRenderer.sprite = sprite;
		}
		float alpha = 1f;
		float time = 0f;
		this.spController.gameObject.SetActive(true);
		this.spController.\u02BF\u02BC\u02B3\u02B7\u02BB\u02BF\u02BD\u02C1\u02B9\u02BF\u02BB();
		while (this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			alpha = Mathf.Lerp(this.\u02B9\u02B2\u02BB\u02B5\u02BB\u02B9\u02BD\u02C1\u02BE\u02BB\u02B6.x, this.\u02B9\u02B2\u02BB\u02B5\u02BB\u02B9\u02BD\u02C1\u02BE\u02BB\u02B6.y, Mathf.Cos(time * this.\u02BC\u02B4\u02B5\u02BB\u02B2\u02BA\u02B9\u02BD\u02B8\u02BD\u02B9) * 0.5f + 0.5f);
			foreach (SpriteRenderer spriteRenderer2 in this.spController.breathingRenderers)
			{
				spriteRenderer2.color = new Color(spriteRenderer2.color.r, spriteRenderer2.color.g, spriteRenderer2.color.b, 0.5f);
			}
			time += Time.deltaTime * 2f * 3.1415927f;
			yield return new WaitForEndOfFrame();
		}
		while (alpha > 1E-45f)
		{
			alpha = Mathf.MoveTowards(alpha, 0f, Time.deltaTime * 3f);
			foreach (SpriteRenderer spriteRenderer3 in this.spController.breathingRenderers)
			{
				spriteRenderer3.color = new Color(spriteRenderer3.color.r, spriteRenderer3.color.g, spriteRenderer3.color.b, 0.5f);
			}
			yield return new WaitForEndOfFrame();
		}
		foreach (SpriteRenderer spriteRenderer4 in this.spController.breathingRenderers)
		{
			spriteRenderer4.color = new Color(spriteRenderer4.color.r, spriteRenderer4.color.g, spriteRenderer4.color.b, 0f);
		}
		this.spController.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x06001403 RID: 5123 RVA: 0x00010865 File Offset: 0x0000EA65
	public void \u02BD\u02B4\u02B6\u02BD\u02C1\u02B9\u02BC\u02BC\u02B7\u02B5\u02B5()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
		GameAudioManager.PlaySound(SoundID.OverStrum2);
		if (SettingsController.\u02C1\u02B3\u02BA\u02B9\u02B4\u02B3\u02BB\u02B6\u02BC\u02BC\u02BB)
		{
			base.StartCoroutine(this.AnimateSP());
		}
	}

	// Token: 0x06001404 RID: 5124 RVA: 0x0001088D File Offset: 0x0000EA8D
	public void \u02BB\u02B2\u02BA\u02B5\u02B4\u02B4\u02BB\u02BD\u02BD\u02BF\u02B6()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = true;
		GameAudioManager.PlaySound(SoundID.StarPowerRelease);
		if (SettingsController.\u02C1\u02B3\u02BA\u02B9\u02B4\u02B3\u02BB\u02B6\u02BC\u02BC\u02BB)
		{
			base.StartCoroutine(this.AnimateSP());
		}
	}

	// Token: 0x06001405 RID: 5125 RVA: 0x00010820 File Offset: 0x0000EA20
	private void \u02BF\u02B8\u02B8\u02B6\u02B9\u02B4\u02BB\u02B6\u02BC\u02BA\u02BF()
	{
		this.spController = base.GetComponentInChildren<StarPowerController>();
	}

	// Token: 0x06001406 RID: 5126 RVA: 0x000108B5 File Offset: 0x0000EAB5
	public void \u02BB\u02B5\u02C0\u02B2\u02B3\u02B8\u02B4\u02BF\u02B8\u02BC\u02B9()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
		GameAudioManager.PlaySound(SoundID.StarPowerAwarded);
		if (SettingsController.\u02C1\u02B3\u02BA\u02B9\u02B4\u02B3\u02BB\u02B6\u02BC\u02BC\u02BB)
		{
			base.StartCoroutine(this.AnimateSP());
		}
	}

	// Token: 0x06001407 RID: 5127 RVA: 0x00010820 File Offset: 0x0000EA20
	private void \u02B8\u02C1\u02B9\u02BC\u02B6\u02B9\u02B3\u02B5\u02B7\u02BF\u02BD()
	{
		this.spController = base.GetComponentInChildren<StarPowerController>();
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x00010820 File Offset: 0x0000EA20
	private void \u02BE\u02BD\u02B8\u02B8\u02B9\u02BA\u02BA\u02BA\u02B4\u02B2\u02B4()
	{
		this.spController = base.GetComponentInChildren<StarPowerController>();
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x00010905 File Offset: 0x0000EB05
	private IEnumerator \u02B3\u02BB\u02B6\u02C1\u02B8\u02C1\u02C0\u02C1\u02B6\u02B5\u02C1()
	{
		SpNeckRenderer.\u02BB\u02B3\u02BB\u02B6\u02C1\u02BB\u02BB\u02B4\u02B5\u02C1\u02BD u02BB_u02B3_u02BB_u02B6_u02C1_u02BB_u02BB_u02B4_u02B5_u02C1_u02BD = new SpNeckRenderer.\u02BB\u02B3\u02BB\u02B6\u02C1\u02BB\u02BB\u02B4\u02B5\u02C1\u02BD(1);
		u02BB_u02B3_u02BB_u02B6_u02C1_u02BB_u02BB_u02B4_u02B5_u02C1_u02BD.<>4__this = this;
		return u02BB_u02B3_u02BB_u02B6_u02C1_u02BB_u02BB_u02B4_u02B5_u02C1_u02BD;
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x00010914 File Offset: 0x0000EB14
	public void \u02BE\u02BA\u02B5\u02BF\u02BF\u02B7\u02B4\u02BC\u02BB\u02B2\u02B4()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
		GameAudioManager.PlaySound(SoundID.StarPowerRelease);
	}

	// Token: 0x0600140C RID: 5132 RVA: 0x00010923 File Offset: 0x0000EB23
	public void \u02BC\u02C1\u02BE\u02B5\u02B4\u02BC\u02C1\u02BE\u02B7\u02C1\u02B8()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
		GameAudioManager.PlaySound(SoundID.OverStrum4);
	}

	// Token: 0x0600140D RID: 5133 RVA: 0x00010932 File Offset: 0x0000EB32
	private IEnumerator \u02B9\u02C0\u02BE\u02B7\u02C1\u02B7\u02BD\u02B3\u02BE\u02B4\u02B4()
	{
		float alpha = 1f;
		float time = 0f;
		this.spController.gameObject.SetActive(true);
		this.spController.\u02BF\u02BC\u02B3\u02B7\u02BB\u02BF\u02BD\u02C1\u02B9\u02BF\u02BB();
		while (this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			alpha = Mathf.Lerp(this.\u02B9\u02B2\u02BB\u02B5\u02BB\u02B9\u02BD\u02C1\u02BE\u02BB\u02B6.x, this.\u02B9\u02B2\u02BB\u02B5\u02BB\u02B9\u02BD\u02C1\u02BE\u02BB\u02B6.y, Mathf.Cos(time * this.\u02BC\u02B4\u02B5\u02BB\u02B2\u02BA\u02B9\u02BD\u02B8\u02BD\u02B9) * 0.5f + 0.5f);
			foreach (SpriteRenderer spriteRenderer in this.spController.breathingRenderers)
			{
				spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, alpha);
			}
			time += Time.deltaTime * 2f * 3.1415927f;
			yield return new WaitForEndOfFrame();
		}
		while (alpha > 1E-45f)
		{
			alpha = Mathf.MoveTowards(alpha, 0f, Time.deltaTime * 3f);
			foreach (SpriteRenderer spriteRenderer2 in this.spController.breathingRenderers)
			{
				spriteRenderer2.color = new Color(spriteRenderer2.color.r, spriteRenderer2.color.g, spriteRenderer2.color.b, alpha);
			}
			yield return new WaitForEndOfFrame();
		}
		foreach (SpriteRenderer spriteRenderer3 in this.spController.breathingRenderers)
		{
			spriteRenderer3.color = new Color(spriteRenderer3.color.r, spriteRenderer3.color.g, spriteRenderer3.color.b, 0f);
		}
		this.spController.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x00010941 File Offset: 0x0000EB41
	public void \u02BA\u02B3\u02B7\u02B8\u02C1\u02B9\u02BB\u02C1\u02B7\u02BD\u02B5()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
		GameAudioManager.PlaySound(SoundID.StarPowerAvailable);
		if (SettingsController.\u02C1\u02B3\u02BA\u02B9\u02B4\u02B3\u02BB\u02B6\u02BC\u02BC\u02BB)
		{
			base.StartCoroutine(this.\u02B3\u02BB\u02B6\u02C1\u02B8\u02C1\u02C0\u02C1\u02B6\u02B5\u02C1());
		}
	}

	// Token: 0x0600140F RID: 5135 RVA: 0x00010820 File Offset: 0x0000EA20
	private void Awake()
	{
		this.spController = base.GetComponentInChildren<StarPowerController>();
	}

	// Token: 0x06001410 RID: 5136 RVA: 0x00010914 File Offset: 0x0000EB14
	public void \u02BC\u02BC\u02B2\u02B6\u02C1\u02BC\u02B3\u02BA\u02B7\u02BF\u02BF()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
		GameAudioManager.PlaySound(SoundID.StarPowerRelease);
	}

	// Token: 0x06001411 RID: 5137 RVA: 0x00010820 File Offset: 0x0000EA20
	private void \u02B4\u02C1\u02B6\u02BE\u02B3\u02B4\u02BD\u02B7\u02B6\u02C0\u02B9()
	{
		this.spController = base.GetComponentInChildren<StarPowerController>();
	}

	// Token: 0x04000EE8 RID: 3816
	public Vector2 \u02B9\u02B2\u02BB\u02B5\u02BB\u02B9\u02BD\u02C1\u02BE\u02BB\u02B6 = new Vector2(0.35f, 1f);

	// Token: 0x04000EE9 RID: 3817
	public float \u02BC\u02B4\u02B5\u02BB\u02B2\u02BA\u02B9\u02BD\u02B8\u02BD\u02B9 = 1f;

	// Token: 0x04000EEA RID: 3818
	private bool \u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8;

	// Token: 0x04000EEB RID: 3819
	[SerializeField]
	private StarPowerController spController;
}
