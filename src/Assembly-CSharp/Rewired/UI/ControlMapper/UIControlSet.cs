using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002CC RID: 716
	[AddComponentMenu("")]
	public class UIControlSet : MonoBehaviour
	{
		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001EDA RID: 7898 RVA: 0x000D48D4 File Offset: 0x000D2AD4
		private Dictionary<int, UIControl> controls
		{
			get
			{
				Dictionary<int, UIControl> dictionary;
				if ((dictionary = this._controls) == null)
				{
					dictionary = (this._controls = new Dictionary<int, UIControl>());
				}
				return dictionary;
			}
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00017406 File Offset: 0x00015606
		public void SetTitle(string text)
		{
			if (this.title == null)
			{
				return;
			}
			this.title.text = text;
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x000D48FC File Offset: 0x000D2AFC
		public T GetControl<T>(int uniqueId) where T : UIControl
		{
			UIControl uicontrol;
			this.controls.TryGetValue(uniqueId, out uicontrol);
			return uicontrol as T;
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x000D4924 File Offset: 0x000D2B24
		public UISliderControl CreateSlider(GameObject prefab, Sprite icon, float minValue, float maxValue, Action<int, float> valueChangedCallback, Action<int> cancelCallback)
		{
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(prefab);
			UISliderControl control = gameObject.GetComponent<UISliderControl>();
			if (control == null)
			{
				global::UnityEngine.Object.Destroy(gameObject);
				Debug.LogError("Prefab missing UISliderControl component!");
				return null;
			}
			gameObject.transform.SetParent(base.transform, false);
			if (control.iconImage != null)
			{
				control.iconImage.sprite = icon;
			}
			if (control.slider != null)
			{
				control.slider.minValue = minValue;
				control.slider.maxValue = maxValue;
				if (valueChangedCallback != null)
				{
					control.slider.onValueChanged.AddListener(delegate(float value)
					{
						valueChangedCallback(control.id, value);
					});
				}
				if (cancelCallback != null)
				{
					control.SetCancelCallback(delegate
					{
						cancelCallback(control.id);
					});
				}
			}
			this.controls.Add(control.id, control);
			return control;
		}

		// Token: 0x0400152C RID: 5420
		[SerializeField]
		private TMP_Text title;

		// Token: 0x0400152D RID: 5421
		private Dictionary<int, UIControl> _controls;
	}
}
