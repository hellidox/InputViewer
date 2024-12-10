using System;
using System.Collections;
using System.Linq;
using StrikeCore;
using UnityEngine;

public class HudDragController : MonoBehaviour
{
	private Vector3 \u02B9\u02B3\u02BB\u02B5\u02BF\u02B3\u02B4\u02B7\u02C0\u02BD\u02BB(Vector3 \u02B3\u02C0\u02B9\u02BC\u02B9\u02BD\u02BE\u02B9\u02B7\u02B6\u02BC)
	{
		Ray ray = this.hudCamera.ScreenPointToRay(\u02B3\u02C0\u02B9\u02BC\u02B9\u02BD\u02BE\u02B9\u02B7\u02B6\u02BC);
		Matrix4x4 worldToLocalMatrix = this.dragHandleRect.worldToLocalMatrix;
		Vector3 vector = worldToLocalMatrix.MultiplyPoint(ray.origin);
		Vector3 vector2 = worldToLocalMatrix.MultiplyVector(ray.direction);
		return vector - vector.z / vector2.z * vector2;
	}

	private Vector3 \u02BA\u02B4\u02BC\u02B3\u02BE\u02C1\u02B8\u02B9\u02B7\u02B4\u02B2(Vector3 \u02B3\u02C0\u02B9\u02BC\u02B9\u02BD\u02BE\u02B9\u02B7\u02B6\u02BC)
	{
		Ray ray = this.hudCamera.ScreenPointToRay(\u02B3\u02C0\u02B9\u02BC\u02B9\u02BD\u02BE\u02B9\u02B7\u02B6\u02BC);
		Matrix4x4 worldToLocalMatrix = this.dragHandleRect.worldToLocalMatrix;
		Vector3 vector = worldToLocalMatrix.MultiplyPoint(ray.origin);
		Vector3 vector2 = worldToLocalMatrix.MultiplyVector(ray.direction);
		return vector - vector.z / vector2.z * vector2;
	}

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

	private void Update()
	{
		SpriteRenderer[] array = this.renderers;
		if (!this.logged)
		{
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
				Color color = Helper.HexColorToColor(HexColor.FromHexString(GlobalHelper.scoreHUDColor), 1f);
				if (color == Color.black)
				{
					color = Color.clear;
				}
				spriteRenderer2.color = color;
			}
			foreach (SpriteRenderer spriteRenderer3 in this.starRenderers.Where((SpriteRenderer x) => x != null))
			{
				Color color2 = Helper.HexColorToColor(HexColor.FromHexString(GlobalHelper.starColor), 1f);
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

	private IEnumerator \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		HudDragController.\u02BF\u02BF\u02BF\u02BD\u02BA\u02BC\u02C0\u02BE\u02B6\u02B5\u02BD u02BF_u02BF_u02BF_u02BD_u02BA_u02BC_u02C0_u02BE_u02B6_u02B5_u02BD = new HudDragController.\u02BF\u02BF\u02BF\u02BD\u02BA\u02BC\u02C0\u02BE\u02B6\u02B5\u02BD(1);
		u02BF_u02BF_u02BF_u02BD_u02BA_u02BC_u02C0_u02BE_u02B6_u02B5_u02BD.<>4__this = this;
		return u02BF_u02BF_u02BF_u02BD_u02BA_u02BC_u02C0_u02BE_u02B6_u02B5_u02BD;
	}

	private Vector3 \u02B9\u02BB\u02B2\u02BC\u02B4\u02B2\u02BE\u02BA\u02B9\u02C0\u02B4(Vector3 \u02B3\u02C0\u02B9\u02BC\u02B9\u02BD\u02BE\u02B9\u02B7\u02B6\u02BC)
	{
		Ray ray = this.hudCamera.ScreenPointToRay(\u02B3\u02C0\u02B9\u02BC\u02B9\u02BD\u02BE\u02B9\u02B7\u02B6\u02BC);
		Matrix4x4 worldToLocalMatrix = this.dragHandleRect.worldToLocalMatrix;
		Vector3 vector = worldToLocalMatrix.MultiplyPoint(ray.origin);
		Vector3 vector2 = worldToLocalMatrix.MultiplyVector(ray.direction);
		return vector - vector.z / vector2.z * vector2;
	}

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

	private const int \u02BA\u02BC\u02B7\u02B6\u02B7\u02B2\u02C1\u02B2\u02C0\u02BA\u02B4 = 0;

	[SerializeField]
	private RectTransform dragHandleRect;

	[SerializeField]
	private Transform hud;

	[SerializeField]
	private Camera hudCamera;

	[SerializeField]
	private GameManager gameManager;

	private bool \u02B4\u02C0\u02B8\u02B3\u02B6\u02B7\u02C1\u02B9\u02C0\u02B9\u02B6;

	private bool \u02B6\u02B8\u02C1\u02C0\u02BC\u02B4\u02C0\u02C0\u02C1\u02BE\u02BF;

	private Vector3 \u02B3\u02B6\u02B9\u02B5\u02B5\u02B8\u02C1\u02B8\u02B9\u02C1\u02BC;

	private SpriteRenderer[] renderers;

	private bool logged;

	private SpriteRenderer[] bgRenderers;

	private SpriteRenderer[] BGSpriteRenderers;

	private float ticker;

	private SpriteRenderer[] starRenderers;
}
