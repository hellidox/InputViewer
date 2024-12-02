using System;
using System.Collections.Generic;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	public static class UISelectionUtility
	{
		public static Selectable FindNextSelectable(Selectable selectable, Transform transform, Vector3 direction)
		{
			RectTransform rectTransform = transform as RectTransform;
			if (rectTransform == null)
			{
				return null;
			}
			if (Selectable.allSelectableCount > UISelectionUtility.s_reusableAllSelectables.Length)
			{
				UISelectionUtility.s_reusableAllSelectables = new Selectable[Selectable.allSelectableCount];
			}
			int num = Selectable.AllSelectablesNoAlloc(UISelectionUtility.s_reusableAllSelectables);
			IList<Selectable> list = UISelectionUtility.s_reusableAllSelectables;
			direction.Normalize();
			Vector2 vector = direction;
			Vector2 vector2 = UITools.GetPointOnRectEdge(rectTransform, vector);
			bool flag = vector == Vector2.right * -1f || vector == Vector2.right;
			float num2 = float.PositiveInfinity;
			float num3 = float.PositiveInfinity;
			Selectable selectable2 = null;
			Selectable selectable3 = null;
			Vector2 vector3 = vector2 + vector * 999999f;
			for (int i = 0; i < num; i++)
			{
				Selectable selectable4 = list[i];
				if (!(selectable4 == selectable) && !(selectable4 == null) && selectable4.navigation.mode != Navigation.Mode.None && (selectable4.IsInteractable() || ReflectionTools.GetPrivateField<Selectable, bool>(selectable4, "m_GroupsAllowInteraction")))
				{
					RectTransform rectTransform2 = selectable4.transform as RectTransform;
					if (!(rectTransform2 == null))
					{
						Rect rect = UITools.InvertY(UITools.TransformRectTo(rectTransform2, transform, rectTransform2.rect));
						float num4;
						if (MathTools.LineIntersectsRect(vector2, vector3, rect, out num4))
						{
							if (flag)
							{
								num4 *= 0.25f;
							}
							if (num4 < num3)
							{
								num3 = num4;
								selectable3 = selectable4;
							}
						}
						Vector2 vector4 = UnityTools.TransformPoint(rectTransform2, transform, rectTransform2.rect.center) - vector2;
						if (Mathf.Abs(Vector2.Angle(vector, vector4)) <= 75f)
						{
							float sqrMagnitude = vector4.sqrMagnitude;
							if (sqrMagnitude < num2)
							{
								num2 = sqrMagnitude;
								selectable2 = selectable4;
							}
						}
					}
				}
			}
			if (!(selectable3 != null) || !(selectable2 != null))
			{
				Array.Clear(UISelectionUtility.s_reusableAllSelectables, 0, UISelectionUtility.s_reusableAllSelectables.Length);
				return selectable3 ?? selectable2;
			}
			if (num3 > num2)
			{
				return selectable2;
			}
			return selectable3;
		}

		private static Selectable[] s_reusableAllSelectables = new Selectable[0];
	}
}
