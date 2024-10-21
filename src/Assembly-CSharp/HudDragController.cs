using System;
using System.Collections;
using System.Linq;
using StrikeCore;
using UnityEngine;

// Token: 0x0200006B RID: 107
public class HudDragController : MonoBehaviour
{
	// Token: 0x0600045A RID: 1114 RVA: 0x00031AF0 File Offset: 0x0002FCF0
	private Vector3 \u02B9\u02B3\u02BB\u02B5\u02BF\u02B3\u02B4\u02B7\u02C0\u02BD\u02BB(Vector3 \u02B3\u02C0\u02B9\u02BC\u02B9\u02BD\u02BE\u02B9\u02B7\u02B6\u02BC)
	{
		Ray ray = this.hudCamera.ScreenPointToRay(\u02B3\u02C0\u02B9\u02BC\u02B9\u02BD\u02BE\u02B9\u02B7\u02B6\u02BC);
		Matrix4x4 worldToLocalMatrix = this.dragHandleRect.worldToLocalMatrix;
		Vector3 vector = worldToLocalMatrix.MultiplyPoint(ray.origin);
		Vector3 vector2 = worldToLocalMatrix.MultiplyVector(ray.direction);
		return vector - vector.z / vector2.z * vector2;
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x00031AF0 File Offset: 0x0002FCF0
	private Vector3 \u02BA\u02B4\u02BC\u02B3\u02BE\u02C1\u02B8\u02B9\u02B7\u02B4\u02B2(Vector3 \u02B3\u02C0\u02B9\u02BC\u02B9\u02BD\u02BE\u02B9\u02B7\u02B6\u02BC)
	{
		Ray ray = this.hudCamera.ScreenPointToRay(\u02B3\u02C0\u02B9\u02BC\u02B9\u02BD\u02BE\u02B9\u02B7\u02B6\u02BC);
		Matrix4x4 worldToLocalMatrix = this.dragHandleRect.worldToLocalMatrix;
		Vector3 vector = worldToLocalMatrix.MultiplyPoint(ray.origin);
		Vector3 vector2 = worldToLocalMatrix.MultiplyVector(ray.direction);
		return vector - vector.z / vector2.z * vector2;
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x00031B4C File Offset: 0x0002FD4C
	private void \u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF()
	{
		bool mouseButton = Input.GetMouseButton(1);
		bool flag = false;
		bool flag2 = true;
		if (mouseButton)
		{
			Vector3 vector = default(Vector3);
			if (!this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6 || this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF)
			{
				vector = this.\u02B9\u02BB\u02B2\u02BC\u02B4\u02B2\u02BE\u02BA\u02B9\u02C0\u02B4(Input.mousePosition);
			}
			if (this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6)
			{
				flag = this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF;
			}
			else
			{
				flag = this.dragHandleRect.rect.Contains(vector);
			}
			if (flag)
			{
				Vector3 vector2 = this.dragHandleRect.localToWorldMatrix.MultiplyPoint(vector);
				if (this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF)
				{
					Vector3 vector3 = vector2 - this.\u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC;
					flag2 = false;
					base.transform.position += vector3;
					SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.\u02B2\u02BD\u02B4\u02BF\u02BC\u02BB\u02C1\u02BA\u02B9\u02B5\u02BD(base.transform.localPosition);
				}
				this.\u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC = vector2;
			}
		}
		else if (Input.GetMouseButtonDown(1))
		{
			SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.Reset();
			base.transform.localPosition = this.gameManager.\u02BA\u02B7\u02B6\u02B6\u02B4\u02B6\u02B2\u02B9\u02BD\u02BD\u02C1();
			flag2 = true;
		}
		this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF = flag;
		this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6 = mouseButton;
		if (flag2)
		{
			this.hud.localPosition = base.transform.localPosition;
		}
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00008308 File Offset: 0x00006508
	private IEnumerator \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		while (!this.gameManager.\u02BC\u02BF\u02B5\u02B5\u02C0\u02BF\u02BC\u02C0\u02B5\u02B4\u02BE)
		{
			yield return null;
		}
		if (this.gameManager.\u02C1\u02B3\u02C0\u02BF\u02BC\u02B5\u02B5\u02B2\u02B9\u02B5\u02BB > 1)
		{
			base.enabled = false;
		}
		else
		{
			base.transform.localPosition = this.hud.localPosition;
		}
		yield break;
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x00008317 File Offset: 0x00006517
	private IEnumerator Start()
	{
		this.renderers = this.hud.gameObject.GetComponentsInChildren<SpriteRenderer>();
		while (!this.gameManager.\u02BC\u02BF\u02B5\u02B5\u02C0\u02BF\u02BC\u02C0\u02B5\u02B4\u02BE)
		{
			yield return null;
		}
		if (this.gameManager.\u02C1\u02B3\u02C0\u02BF\u02BC\u02B5\u02B5\u02B2\u02B9\u02B5\u02BB > 1)
		{
			base.enabled = false;
		}
		else
		{
			base.transform.localPosition = this.hud.localPosition;
		}
		yield break;
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00031C74 File Offset: 0x0002FE74
	private void \u02C1\u02B8\u02B5\u02BD\u02BD\u02C0\u02BB\u02B4\u02BD\u02B8\u02B3()
	{
		bool mouseButton = Input.GetMouseButton(0);
		bool flag = true;
		bool flag2 = true;
		if (mouseButton)
		{
			Vector3 vector = default(Vector3);
			if (!this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6 || this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF)
			{
				vector = this.\u02B9\u02BB\u02B2\u02BC\u02B4\u02B2\u02BE\u02BA\u02B9\u02C0\u02B4(Input.mousePosition);
			}
			if (this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6)
			{
				flag = this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF;
			}
			else
			{
				flag = this.dragHandleRect.rect.Contains(vector);
			}
			if (flag)
			{
				Vector3 vector2 = this.dragHandleRect.localToWorldMatrix.MultiplyPoint(vector);
				if (this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF)
				{
					Vector3 vector3 = vector2 - this.\u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC;
					flag2 = true;
					base.transform.position += vector3;
					SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.\u02B2\u02BD\u02B4\u02BF\u02BC\u02BB\u02C1\u02BA\u02B9\u02B5\u02BD(base.transform.localPosition);
				}
				this.\u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC = vector2;
			}
		}
		else if (Input.GetMouseButtonDown(0))
		{
			SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.Reset();
			base.transform.localPosition = this.gameManager.\u02BA\u02B7\u02B6\u02B6\u02B4\u02B6\u02B2\u02B9\u02BD\u02BD\u02C1();
			flag2 = false;
		}
		this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF = flag;
		this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6 = mouseButton;
		if (flag2)
		{
			this.hud.localPosition = base.transform.localPosition;
		}
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00008308 File Offset: 0x00006508
	private IEnumerator \u02B5\u02B2\u02BF\u02BD\u02BB\u02BA\u02B2\u02BF\u02BD\u02BE\u02BE()
	{
		while (!this.gameManager.\u02BC\u02BF\u02B5\u02B5\u02C0\u02BF\u02BC\u02C0\u02B5\u02B4\u02BE)
		{
			yield return null;
		}
		if (this.gameManager.\u02C1\u02B3\u02C0\u02BF\u02BC\u02B5\u02B5\u02B2\u02B9\u02B5\u02BB > 1)
		{
			base.enabled = false;
		}
		else
		{
			base.transform.localPosition = this.hud.localPosition;
		}
		yield break;
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00031D9C File Offset: 0x0002FF9C
	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		bool mouseButton = Input.GetMouseButton(1);
		bool flag = true;
		bool flag2 = true;
		if (mouseButton)
		{
			Vector3 vector = default(Vector3);
			if (!this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6 || this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF)
			{
				vector = this.\u02BA\u02B4\u02BC\u02B3\u02BE\u02C1\u02B8\u02B9\u02B7\u02B4\u02B2(Input.mousePosition);
			}
			if (this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6)
			{
				flag = this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF;
			}
			else
			{
				flag = this.dragHandleRect.rect.Contains(vector);
			}
			if (flag)
			{
				Vector3 vector2 = this.dragHandleRect.localToWorldMatrix.MultiplyPoint(vector);
				if (this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF)
				{
					Vector3 vector3 = vector2 - this.\u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC;
					flag2 = false;
					base.transform.position += vector3;
					SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.\u02B2\u02BD\u02B4\u02BF\u02BC\u02BB\u02C1\u02BA\u02B9\u02B5\u02BD(base.transform.localPosition);
				}
				this.\u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC = vector2;
			}
		}
		else if (Input.GetMouseButtonDown(1))
		{
			SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.Reset();
			base.transform.localPosition = this.gameManager.\u02BA\u02B7\u02B6\u02B6\u02B4\u02B6\u02B2\u02B9\u02BD\u02BD\u02C1();
			flag2 = false;
		}
		this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF = flag;
		this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6 = mouseButton;
		if (flag2)
		{
			this.hud.localPosition = base.transform.localPosition;
		}
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x00031EC4 File Offset: 0x000300C4
	private void \u02BD\u02B8\u02BD\u02B5\u02B6\u02B3\u02BF\u02B3\u02C1\u02B8\u02C1()
	{
		bool mouseButton = Input.GetMouseButton(1);
		bool flag = true;
		bool flag2 = false;
		if (mouseButton)
		{
			Vector3 vector = default(Vector3);
			if (!this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6 || this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF)
			{
				vector = this.\u02B9\u02B3\u02BB\u02B5\u02BF\u02B3\u02B4\u02B7\u02C0\u02BD\u02BB(Input.mousePosition);
			}
			if (this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6)
			{
				flag = this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF;
			}
			else
			{
				flag = this.dragHandleRect.rect.Contains(vector);
			}
			if (flag)
			{
				Vector3 vector2 = this.dragHandleRect.localToWorldMatrix.MultiplyPoint(vector);
				if (this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF)
				{
					Vector3 vector3 = vector2 - this.\u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC;
					flag2 = false;
					base.transform.position += vector3;
					SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.\u02B2\u02BD\u02B4\u02BF\u02BC\u02BB\u02C1\u02BA\u02B9\u02B5\u02BD(base.transform.localPosition);
				}
				this.\u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC = vector2;
			}
		}
		else if (Input.GetMouseButtonDown(1))
		{
			SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.Reset();
			base.transform.localPosition = this.gameManager.\u02BA\u02B7\u02B6\u02B6\u02B4\u02B6\u02B2\u02B9\u02BD\u02BD\u02C1();
			flag2 = true;
		}
		this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF = flag;
		this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6 = mouseButton;
		if (flag2)
		{
			this.hud.localPosition = base.transform.localPosition;
		}
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00008308 File Offset: 0x00006508
	private IEnumerator \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		while (!this.gameManager.\u02BC\u02BF\u02B5\u02B5\u02C0\u02BF\u02BC\u02C0\u02B5\u02B4\u02BE)
		{
			yield return null;
		}
		if (this.gameManager.\u02C1\u02B3\u02C0\u02BF\u02BC\u02B5\u02B5\u02B2\u02B9\u02B5\u02BB > 1)
		{
			base.enabled = false;
		}
		else
		{
			base.transform.localPosition = this.hud.localPosition;
		}
		yield break;
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00031FEC File Offset: 0x000301EC
	private void Update()
	{
		SpriteRenderer[] array = this.renderers;
		if (!this.logged)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Debug.Log(array[i].gameObject.name);
			}
			this.BGSpriteRenderers = array.Where((SpriteRenderer x) => !x.gameObject.name.Contains("StarCount") && (x.gameObject.name.Contains("BG", StringComparison.OrdinalIgnoreCase) || x.gameObject.name.Contains("overlay", StringComparison.OrdinalIgnoreCase))).ToArray<SpriteRenderer>();
			this.starRenderers = array.Where((SpriteRenderer x) => x.gameObject.name.Contains("star_", StringComparison.Ordinal)).ToArray<SpriteRenderer>();
			foreach (SpriteRenderer spriteRenderer in array.Where((SpriteRenderer x) => x.gameObject.name.Contains("Divider")))
			{
				spriteRenderer.color = Color.clear;
			}
			this.logged = true;
		}
		this.ticker += Time.deltaTime;
		if (this.ticker > 0.71f)
		{
			foreach (SpriteRenderer spriteRenderer2 in this.BGSpriteRenderers.Where((SpriteRenderer x) => x != null))
			{
				Color color = __FIXME_clon_util.HexColorToColor(HexColor.FromHexString(cUtilityClass.scoreHUDColor), 1f);
				if (color == Color.black)
				{
					color = Color.clear;
				}
				spriteRenderer2.color = color;
			}
			foreach (SpriteRenderer spriteRenderer3 in this.starRenderers.Where((SpriteRenderer x) => x != null))
			{
				Color color2 = __FIXME_clon_util.HexColorToColor(HexColor.FromHexString(cUtilityClass.starColor), 1f);
				if (color2 == Color.black)
				{
					color2 = Color.clear;
				}
				spriteRenderer3.color = color2;
			}
			this.ticker -= 0.71f;
		}
		bool mouseButton = Input.GetMouseButton(0);
		bool flag = false;
		bool flag2 = false;
		if (mouseButton)
		{
			Vector3 vector = default(Vector3);
			if (!this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6 || this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF)
			{
				vector = this.\u02BA\u02B4\u02BC\u02B3\u02BE\u02C1\u02B8\u02B9\u02B7\u02B4\u02B2(Input.mousePosition);
			}
			if (this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6)
			{
				flag = this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF;
			}
			else
			{
				flag = this.dragHandleRect.rect.Contains(vector);
			}
			if (flag)
			{
				Vector3 vector2 = this.dragHandleRect.localToWorldMatrix.MultiplyPoint(vector);
				if (this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF)
				{
					Vector3 vector3 = vector2 - this.\u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC;
					flag2 = true;
					base.transform.position += vector3;
					SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.\u02B2\u02BC\u02B8\u02B9\u02B4\u02BA\u02B8\u02B4\u02B3\u02B3\u02BE = base.transform.localPosition;
				}
				this.\u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC = vector2;
			}
		}
		else if (Input.GetMouseButtonDown(1))
		{
			SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.Reset();
			base.transform.localPosition = this.gameManager.\u02BA\u02B7\u02B6\u02B6\u02B4\u02B6\u02B2\u02B9\u02BD\u02BD\u02C1();
			flag2 = true;
		}
		this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF = flag;
		this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6 = mouseButton;
		if (flag2)
		{
			this.hud.localPosition = base.transform.localPosition;
		}
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00008326 File Offset: 0x00006526
	private IEnumerator \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		HudDragController.\u02BF\u02BF\u02BF\u02BD\u02BA\u02BC\u02C0\u02BE\u02B6\u02B5\u02BD u02BF_u02BF_u02BF_u02BD_u02BA_u02BC_u02C0_u02BE_u02B6_u02B5_u02BD = new HudDragController.\u02BF\u02BF\u02BF\u02BD\u02BA\u02BC\u02C0\u02BE\u02B6\u02B5\u02BD(1);
		u02BF_u02BF_u02BF_u02BD_u02BA_u02BC_u02C0_u02BE_u02B6_u02B5_u02BD.<>4__this = this;
		return u02BF_u02BF_u02BF_u02BD_u02BA_u02BC_u02C0_u02BE_u02B6_u02B5_u02BD;
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00031AF0 File Offset: 0x0002FCF0
	private Vector3 \u02B9\u02BB\u02B2\u02BC\u02B4\u02B2\u02BE\u02BA\u02B9\u02C0\u02B4(Vector3 \u02B3\u02C0\u02B9\u02BC\u02B9\u02BD\u02BE\u02B9\u02B7\u02B6\u02BC)
	{
		Ray ray = this.hudCamera.ScreenPointToRay(\u02B3\u02C0\u02B9\u02BC\u02B9\u02BD\u02BE\u02B9\u02B7\u02B6\u02BC);
		Matrix4x4 worldToLocalMatrix = this.dragHandleRect.worldToLocalMatrix;
		Vector3 vector = worldToLocalMatrix.MultiplyPoint(ray.origin);
		Vector3 vector2 = worldToLocalMatrix.MultiplyVector(ray.direction);
		return vector - vector.z / vector2.z * vector2;
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x0003236C File Offset: 0x0003056C
	private void \u02BB\u02B7\u02C0\u02B3\u02C1\u02BD\u02B9\u02B2\u02B4\u02BE\u02B6()
	{
		bool mouseButton = Input.GetMouseButton(1);
		bool flag = true;
		bool flag2 = true;
		if (mouseButton)
		{
			Vector3 vector = default(Vector3);
			if (!this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6 || this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF)
			{
				vector = this.\u02B9\u02B3\u02BB\u02B5\u02BF\u02B3\u02B4\u02B7\u02C0\u02BD\u02BB(Input.mousePosition);
			}
			if (this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6)
			{
				flag = this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF;
			}
			else
			{
				flag = this.dragHandleRect.rect.Contains(vector);
			}
			if (flag)
			{
				Vector3 vector2 = this.dragHandleRect.localToWorldMatrix.MultiplyPoint(vector);
				if (this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF)
				{
					Vector3 vector3 = vector2 - this.\u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC;
					flag2 = true;
					base.transform.position += vector3;
					SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.\u02B2\u02BD\u02B4\u02BF\u02BC\u02BB\u02C1\u02BA\u02B9\u02B5\u02BD(base.transform.localPosition);
				}
				this.\u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC = vector2;
			}
		}
		else if (Input.GetMouseButtonDown(1))
		{
			SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF.Reset();
			base.transform.localPosition = this.gameManager.\u02BA\u02B7\u02B6\u02B6\u02B4\u02B6\u02B2\u02B9\u02BD\u02BD\u02C1();
			flag2 = true;
		}
		this.\u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF = flag;
		this.\u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6 = mouseButton;
		if (flag2)
		{
			this.hud.localPosition = base.transform.localPosition;
		}
	}

	// Token: 0x0400036D RID: 877
	private const int \u02BA\u02BC\u02B7\u02B6\u02B7\u02B2\u02C1\u02B2\u02C0\u02BA\u02B4 = 0;

	// Token: 0x0400036E RID: 878
	[SerializeField]
	private RectTransform dragHandleRect;

	// Token: 0x0400036F RID: 879
	[SerializeField]
	private Transform hud;

	// Token: 0x04000370 RID: 880
	[SerializeField]
	private Camera hudCamera;

	// Token: 0x04000371 RID: 881
	[SerializeField]
	private GameManager gameManager;

	// Token: 0x04000372 RID: 882
	private bool \u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6;

	// Token: 0x04000373 RID: 883
	private bool \u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF;

	// Token: 0x04000374 RID: 884
	private Vector3 \u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC;

	// Token: 0x04000375 RID: 885
	private SpriteRenderer[] renderers;

	// Token: 0x04000376 RID: 886
	private bool logged;

	// Token: 0x04000377 RID: 887
	private SpriteRenderer[] bgRenderers;

	// Token: 0x04000378 RID: 888
	private SpriteRenderer[] BGSpriteRenderers;

	// Token: 0x04000379 RID: 889
	private float ticker;

	// Token: 0x0400037A RID: 890
	private SpriteRenderer[] starRenderers;
}
