﻿using System;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002D5 RID: 725
	public static class UITools
	{
		// Token: 0x06001EFD RID: 7933 RVA: 0x000D4E44 File Offset: 0x000D3044
		public static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name) where T : Component
		{
			GameObject gameObject = UITools.InstantiateGUIObject_Pre<T>(prefab, parent, name);
			if (gameObject == null)
			{
				return null;
			}
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (component == null)
			{
				Debug.LogError(name + " prefab is missing RectTransform component!");
			}
			else
			{
				component.localScale = Vector3.one;
			}
			return gameObject;
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x000D4E94 File Offset: 0x000D3094
		public static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name, Vector2 pivot, Vector2 anchorMin, Vector2 anchorMax, Vector2 anchoredPosition) where T : Component
		{
			GameObject gameObject = UITools.InstantiateGUIObject_Pre<T>(prefab, parent, name);
			if (gameObject == null)
			{
				return null;
			}
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (component == null)
			{
				Debug.LogError(name + " prefab is missing RectTransform component!");
			}
			else
			{
				component.localScale = Vector3.one;
				component.pivot = pivot;
				component.anchorMin = anchorMin;
				component.anchorMax = anchorMax;
				component.anchoredPosition = anchoredPosition;
			}
			return gameObject;
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x000D4F04 File Offset: 0x000D3104
		private static GameObject InstantiateGUIObject_Pre<T>(GameObject prefab, Transform parent, string name) where T : Component
		{
			if (prefab == null)
			{
				Debug.LogError(name + " prefab is null!");
				return null;
			}
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(prefab);
			if (!string.IsNullOrEmpty(name))
			{
				gameObject.name = name;
			}
			T component = gameObject.GetComponent<T>();
			if (component == null)
			{
				Debug.LogError(name + " prefab is missing the " + component.GetType().ToString() + " component!");
				return null;
			}
			if (parent != null)
			{
				gameObject.transform.SetParent(parent, false);
			}
			return gameObject;
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x000D4F98 File Offset: 0x000D3198
		public static Vector3 GetPointOnRectEdge(RectTransform rectTransform, Vector2 dir)
		{
			if (rectTransform == null)
			{
				return Vector3.zero;
			}
			if (dir != Vector2.zero)
			{
				dir /= Mathf.Max(Mathf.Abs(dir.x), Mathf.Abs(dir.y));
			}
			Rect rect = rectTransform.rect;
			dir = rect.center + Vector2.Scale(rect.size, dir * 0.5f);
			return dir;
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x000D5018 File Offset: 0x000D3218
		public static Rect TransformRectTo(Transform from, Transform to, Rect rect)
		{
			Vector3 vector;
			Vector3 vector2;
			Vector3 vector3;
			if (from != null)
			{
				vector = from.TransformPoint(new Vector2(rect.xMin, rect.yMin));
				vector2 = from.TransformPoint(new Vector2(rect.xMin, rect.yMax));
				vector3 = from.TransformPoint(new Vector2(rect.xMax, rect.yMin));
			}
			else
			{
				vector = new Vector2(rect.xMin, rect.yMin);
				vector2 = new Vector2(rect.xMin, rect.yMax);
				vector3 = new Vector2(rect.xMax, rect.yMin);
			}
			if (to != null)
			{
				vector = to.InverseTransformPoint(vector);
				vector2 = to.InverseTransformPoint(vector2);
				vector3 = to.InverseTransformPoint(vector3);
			}
			return new Rect(vector.x, vector.y, vector3.x - vector.x, vector.y - vector2.y);
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x0001758F File Offset: 0x0001578F
		public static Rect InvertY(Rect rect)
		{
			return new Rect(rect.xMin, rect.yMin, rect.width, -rect.height);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x000D5124 File Offset: 0x000D3324
		public static void SetInteractable(Selectable selectable, bool state, bool playTransition)
		{
			if (selectable == null)
			{
				return;
			}
			if (playTransition)
			{
				selectable.interactable = state;
				return;
			}
			if (selectable.transition == Selectable.Transition.ColorTint)
			{
				ColorBlock colors = selectable.colors;
				float fadeDuration = colors.fadeDuration;
				colors.fadeDuration = 0f;
				selectable.colors = colors;
				selectable.interactable = state;
				colors.fadeDuration = fadeDuration;
				selectable.colors = colors;
				return;
			}
			selectable.interactable = state;
		}
	}
}
