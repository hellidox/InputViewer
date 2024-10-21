using System;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002BC RID: 700
	[AddComponentMenu("")]
	[RequireComponent(typeof(Selectable))]
	public class ScrollRectSelectableChild : MonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x0001717D File Offset: 0x0001537D
		private RectTransform parentScrollRectContentTransform
		{
			get
			{
				return this.parentScrollRect.content;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x000D3EA0 File Offset: 0x000D20A0
		private Selectable selectable
		{
			get
			{
				Selectable selectable;
				if ((selectable = this._selectable) == null)
				{
					selectable = (this._selectable = base.GetComponent<Selectable>());
				}
				return selectable;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x0001718A File Offset: 0x0001538A
		private RectTransform rectTransform
		{
			get
			{
				return base.transform as RectTransform;
			}
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00017197 File Offset: 0x00015397
		private void Start()
		{
			this.parentScrollRect = base.transform.GetComponentInParent<ScrollRect>();
			if (this.parentScrollRect == null)
			{
				Debug.LogError("Rewired Control Mapper: No ScrollRect found! This component must be a child of a ScrollRect!");
				return;
			}
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000D3EC8 File Offset: 0x000D20C8
		public void OnSelect(BaseEventData eventData)
		{
			if (this.parentScrollRect == null)
			{
				return;
			}
			if (!(eventData is AxisEventData))
			{
				return;
			}
			RectTransform rectTransform = this.parentScrollRect.transform as RectTransform;
			Rect rect = MathTools.TransformRect(this.rectTransform.rect, this.rectTransform, rectTransform);
			Rect rect2 = rectTransform.rect;
			Rect rect3 = rectTransform.rect;
			float height;
			if (this.useCustomEdgePadding)
			{
				height = this.customEdgePadding;
			}
			else
			{
				height = rect.height;
			}
			rect3.yMax -= height;
			rect3.yMin += height;
			if (MathTools.RectContains(rect3, rect))
			{
				return;
			}
			Vector2 vector;
			if (!MathTools.GetOffsetToContainRect(rect3, rect, out vector))
			{
				return;
			}
			Vector2 anchoredPosition = this.parentScrollRectContentTransform.anchoredPosition;
			anchoredPosition.x = Mathf.Clamp(anchoredPosition.x + vector.x, 0f, Mathf.Abs(rect2.width - this.parentScrollRectContentTransform.sizeDelta.x));
			anchoredPosition.y = Mathf.Clamp(anchoredPosition.y + vector.y, 0f, Mathf.Abs(rect2.height - this.parentScrollRectContentTransform.sizeDelta.y));
			this.parentScrollRectContentTransform.anchoredPosition = anchoredPosition;
		}

		// Token: 0x040014DA RID: 5338
		public bool useCustomEdgePadding;

		// Token: 0x040014DB RID: 5339
		public float customEdgePadding = 50f;

		// Token: 0x040014DC RID: 5340
		private ScrollRect parentScrollRect;

		// Token: 0x040014DD RID: 5341
		private Selectable _selectable;
	}
}
