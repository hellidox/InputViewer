using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002D3 RID: 723
	[AddComponentMenu("")]
	public class UISliderControl : UIControl
	{
		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x00017518 File Offset: 0x00015718
		// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x00017520 File Offset: 0x00015720
		public bool showIcon
		{
			get
			{
				return this._showIcon;
			}
			set
			{
				if (this.iconImage == null)
				{
					return;
				}
				this.iconImage.gameObject.SetActive(value);
				this._showIcon = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x00017549 File Offset: 0x00015749
		// (set) Token: 0x06001EF7 RID: 7927 RVA: 0x00017551 File Offset: 0x00015751
		public bool showSlider
		{
			get
			{
				return this._showSlider;
			}
			set
			{
				if (this.slider == null)
				{
					return;
				}
				this.slider.gameObject.SetActive(value);
				this._showSlider = value;
			}
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000D4D68 File Offset: 0x000D2F68
		public override void SetCancelCallback(Action cancelCallback)
		{
			base.SetCancelCallback(cancelCallback);
			if (cancelCallback == null || this.slider == null)
			{
				return;
			}
			if (this.slider is ICustomSelectable)
			{
				(this.slider as ICustomSelectable).CancelEvent += delegate
				{
					cancelCallback();
				};
				return;
			}
			EventTrigger eventTrigger = this.slider.GetComponent<EventTrigger>();
			if (eventTrigger == null)
			{
				eventTrigger = this.slider.gameObject.AddComponent<EventTrigger>();
			}
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.callback = new EventTrigger.TriggerEvent();
			entry.eventID = EventTriggerType.Cancel;
			entry.callback.AddListener(delegate(BaseEventData data)
			{
				cancelCallback();
			});
			if (eventTrigger.triggers == null)
			{
				eventTrigger.triggers = new List<EventTrigger.Entry>();
			}
			eventTrigger.triggers.Add(entry);
		}

		// Token: 0x0400153C RID: 5436
		public Image iconImage;

		// Token: 0x0400153D RID: 5437
		public Slider slider;

		// Token: 0x0400153E RID: 5438
		private bool _showIcon;

		// Token: 0x0400153F RID: 5439
		private bool _showSlider;
	}
}
