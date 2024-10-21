using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002D6 RID: 726
	[AddComponentMenu("")]
	[RequireComponent(typeof(CanvasGroup))]
	public class Window : MonoBehaviour
	{
		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x000175B3 File Offset: 0x000157B3
		public bool hasFocus
		{
			get
			{
				return this._isFocusedCallback != null && this._isFocusedCallback(this._id);
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x000175D0 File Offset: 0x000157D0
		public int id
		{
			get
			{
				return this._id;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x000175D8 File Offset: 0x000157D8
		public RectTransform rectTransform
		{
			get
			{
				if (this._rectTransform == null)
				{
					this._rectTransform = base.gameObject.GetComponent<RectTransform>();
				}
				return this._rectTransform;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x000175FF File Offset: 0x000157FF
		public TMP_Text titleText
		{
			get
			{
				return this._titleText;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x00017607 File Offset: 0x00015807
		public List<TMP_Text> contentText
		{
			get
			{
				return this._contentText;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x0001760F File Offset: 0x0001580F
		// (set) Token: 0x06001F0A RID: 7946 RVA: 0x00017617 File Offset: 0x00015817
		public GameObject defaultUIElement
		{
			get
			{
				return this._defaultUIElement;
			}
			set
			{
				this._defaultUIElement = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x00017620 File Offset: 0x00015820
		// (set) Token: 0x06001F0C RID: 7948 RVA: 0x00017628 File Offset: 0x00015828
		public Action<int> updateCallback
		{
			get
			{
				return this._updateCallback;
			}
			set
			{
				this._updateCallback = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x00017631 File Offset: 0x00015831
		public Window.Timer timer
		{
			get
			{
				return this._timer;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x00017639 File Offset: 0x00015839
		// (set) Token: 0x06001F0F RID: 7951 RVA: 0x000D5190 File Offset: 0x000D3390
		public int width
		{
			get
			{
				return (int)this.rectTransform.sizeDelta.x;
			}
			set
			{
				Vector2 sizeDelta = this.rectTransform.sizeDelta;
				sizeDelta.x = (float)value;
				this.rectTransform.sizeDelta = sizeDelta;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x0001764C File Offset: 0x0001584C
		// (set) Token: 0x06001F11 RID: 7953 RVA: 0x000D51C0 File Offset: 0x000D33C0
		public int height
		{
			get
			{
				return (int)this.rectTransform.sizeDelta.y;
			}
			set
			{
				Vector2 sizeDelta = this.rectTransform.sizeDelta;
				sizeDelta.y = (float)value;
				this.rectTransform.sizeDelta = sizeDelta;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x0001765F File Offset: 0x0001585F
		protected bool initialized
		{
			get
			{
				return this._initialized;
			}
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00017667 File Offset: 0x00015867
		private void OnEnable()
		{
			base.StartCoroutine("OnEnableAsync");
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00017675 File Offset: 0x00015875
		protected virtual void Update()
		{
			if (!this._initialized)
			{
				return;
			}
			if (!this.hasFocus)
			{
				return;
			}
			this.CheckUISelection();
			if (this._updateCallback != null)
			{
				this._updateCallback(this._id);
			}
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x000D51F0 File Offset: 0x000D33F0
		public virtual void Initialize(int id, Func<int, bool> isFocusedCallback)
		{
			if (this._initialized)
			{
				Debug.LogError("Window is already initialized!");
				return;
			}
			this._id = id;
			this._isFocusedCallback = isFocusedCallback;
			this._timer = new Window.Timer();
			this._contentText = new List<TMP_Text>();
			this._canvasGroup = base.GetComponent<CanvasGroup>();
			this._initialized = true;
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x000176A8 File Offset: 0x000158A8
		public void SetSize(int width, int height)
		{
			this.rectTransform.sizeDelta = new Vector2((float)width, (float)height);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x000176BE File Offset: 0x000158BE
		public void CreateTitleText(GameObject prefab, Vector2 offset)
		{
			this.CreateText(prefab, ref this._titleText, "Title Text", UIPivot.TopCenter, UIAnchor.TopHStretch, offset);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x000176DD File Offset: 0x000158DD
		public void CreateTitleText(GameObject prefab, Vector2 offset, string text)
		{
			this.CreateTitleText(prefab, offset);
			this.SetTitleText(text);
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x000D5248 File Offset: 0x000D3448
		public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
			TMP_Text tmp_Text = null;
			this.CreateText(prefab, ref tmp_Text, "Content Text", pivot, anchor, offset);
			this._contentText.Add(tmp_Text);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x000176EE File Offset: 0x000158EE
		public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text)
		{
			this.AddContentText(prefab, pivot, anchor, offset);
			this.SetContentText(text, this._contentText.Count - 1);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00017710 File Offset: 0x00015910
		public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
			this.CreateImage(prefab, "Image", pivot, anchor, offset);
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00017722 File Offset: 0x00015922
		public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text)
		{
			this.AddContentImage(prefab, pivot, anchor, offset);
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x000D5278 File Offset: 0x000D3478
		public void CreateButton(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string buttonText, UnityAction confirmCallback, UnityAction cancelCallback, bool setDefault)
		{
			if (prefab == null)
			{
				return;
			}
			ButtonInfo buttonInfo;
			GameObject gameObject = this.CreateButton(prefab, "Button", anchor, pivot, offset, out buttonInfo);
			if (gameObject == null)
			{
				return;
			}
			Button component = gameObject.GetComponent<Button>();
			if (confirmCallback != null)
			{
				component.onClick.AddListener(confirmCallback);
			}
			CustomButton customButton = component as CustomButton;
			if (cancelCallback != null && customButton != null)
			{
				customButton.CancelEvent += cancelCallback;
			}
			if (buttonInfo.text != null)
			{
				buttonInfo.text.text = buttonText;
			}
			if (setDefault)
			{
				this._defaultUIElement = gameObject;
			}
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x0001772F File Offset: 0x0001592F
		public string GetTitleText(string text)
		{
			if (this._titleText == null)
			{
				return string.Empty;
			}
			return this._titleText.text;
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00017750 File Offset: 0x00015950
		public void SetTitleText(string text)
		{
			if (this._titleText == null)
			{
				return;
			}
			this._titleText.text = text;
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x000D5308 File Offset: 0x000D3508
		public string GetContentText(int index)
		{
			if (this._contentText == null || this._contentText.Count <= index || this._contentText[index] == null)
			{
				return string.Empty;
			}
			return this._contentText[index].text;
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x000D5358 File Offset: 0x000D3558
		public float GetContentTextHeight(int index)
		{
			if (this._contentText == null || this._contentText.Count <= index || this._contentText[index] == null)
			{
				return 0f;
			}
			return this._contentText[index].rectTransform.sizeDelta.y;
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x0001776D File Offset: 0x0001596D
		public void SetContentText(string text, int index)
		{
			if (this._contentText == null || this._contentText.Count <= index || this._contentText[index] == null)
			{
				return;
			}
			this._contentText[index].text = text;
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x000177AC File Offset: 0x000159AC
		public void SetUpdateCallback(Action<int> callback)
		{
			this.updateCallback = callback;
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x000177B5 File Offset: 0x000159B5
		public virtual void TakeInputFocus()
		{
			if (EventSystem.current == null)
			{
				return;
			}
			EventSystem.current.SetSelectedGameObject(this._defaultUIElement);
			this.Enable();
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x000177DB File Offset: 0x000159DB
		public virtual void Enable()
		{
			this._canvasGroup.interactable = true;
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x000177E9 File Offset: 0x000159E9
		public virtual void Disable()
		{
			this._canvasGroup.interactable = false;
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x000177F7 File Offset: 0x000159F7
		public virtual void Cancel()
		{
			if (!this.initialized)
			{
				return;
			}
			if (this.cancelCallback != null)
			{
				this.cancelCallback();
			}
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x000D53B0 File Offset: 0x000D35B0
		private void CreateText(GameObject prefab, ref TMP_Text textComponent, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
			if (prefab == null || this.content == null)
			{
				return;
			}
			if (textComponent != null)
			{
				Debug.LogError("Window already has " + name + "!");
				return;
			}
			GameObject gameObject = UITools.InstantiateGUIObject<TMP_Text>(prefab, this.content.transform, name, pivot, anchor.min, anchor.max, offset);
			if (gameObject == null)
			{
				return;
			}
			textComponent = gameObject.GetComponent<TMP_Text>();
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x000D5434 File Offset: 0x000D3634
		private void CreateImage(GameObject prefab, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
			if (prefab == null || this.content == null)
			{
				return;
			}
			UITools.InstantiateGUIObject<Image>(prefab, this.content.transform, name, pivot, anchor.min, anchor.max, offset);
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x000D5484 File Offset: 0x000D3684
		private GameObject CreateButton(GameObject prefab, string name, UIAnchor anchor, UIPivot pivot, Vector2 offset, out ButtonInfo buttonInfo)
		{
			buttonInfo = null;
			if (prefab == null)
			{
				return null;
			}
			GameObject gameObject = UITools.InstantiateGUIObject<ButtonInfo>(prefab, this.content.transform, name, pivot, anchor.min, anchor.max, offset);
			if (gameObject == null)
			{
				return null;
			}
			buttonInfo = gameObject.GetComponent<ButtonInfo>();
			if (gameObject.GetComponent<Button>() == null)
			{
				Debug.Log("Button prefab is missing Button component!");
				return null;
			}
			if (buttonInfo == null)
			{
				Debug.Log("Button prefab is missing ButtonInfo component!");
				return null;
			}
			return gameObject;
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00017815 File Offset: 0x00015A15
		private IEnumerator OnEnableAsync()
		{
			yield return 1;
			if (EventSystem.current == null)
			{
				yield break;
			}
			if (this.defaultUIElement != null)
			{
				EventSystem.current.SetSelectedGameObject(this.defaultUIElement);
			}
			else
			{
				EventSystem.current.SetSelectedGameObject(null);
			}
			yield break;
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x000D5510 File Offset: 0x000D3710
		private void CheckUISelection()
		{
			if (!this.hasFocus)
			{
				return;
			}
			if (EventSystem.current == null)
			{
				return;
			}
			if (EventSystem.current.currentSelectedGameObject == null)
			{
				this.RestoreDefaultOrLastUISelection();
			}
			this.lastUISelection = EventSystem.current.currentSelectedGameObject;
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00017824 File Offset: 0x00015A24
		private void RestoreDefaultOrLastUISelection()
		{
			if (!this.hasFocus)
			{
				return;
			}
			if (this.lastUISelection == null || !this.lastUISelection.activeInHierarchy)
			{
				this.SetUISelection(this._defaultUIElement);
				return;
			}
			this.SetUISelection(this.lastUISelection);
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00015533 File Offset: 0x00013733
		private void SetUISelection(GameObject selection)
		{
			if (EventSystem.current == null)
			{
				return;
			}
			EventSystem.current.SetSelectedGameObject(selection);
		}

		// Token: 0x04001541 RID: 5441
		public Image backgroundImage;

		// Token: 0x04001542 RID: 5442
		public GameObject content;

		// Token: 0x04001543 RID: 5443
		private bool _initialized;

		// Token: 0x04001544 RID: 5444
		private int _id = -1;

		// Token: 0x04001545 RID: 5445
		private RectTransform _rectTransform;

		// Token: 0x04001546 RID: 5446
		private TMP_Text _titleText;

		// Token: 0x04001547 RID: 5447
		private List<TMP_Text> _contentText;

		// Token: 0x04001548 RID: 5448
		private GameObject _defaultUIElement;

		// Token: 0x04001549 RID: 5449
		private Action<int> _updateCallback;

		// Token: 0x0400154A RID: 5450
		private Func<int, bool> _isFocusedCallback;

		// Token: 0x0400154B RID: 5451
		private Window.Timer _timer;

		// Token: 0x0400154C RID: 5452
		private CanvasGroup _canvasGroup;

		// Token: 0x0400154D RID: 5453
		public UnityAction cancelCallback;

		// Token: 0x0400154E RID: 5454
		private GameObject lastUISelection;

		// Token: 0x020002D7 RID: 727
		public class Timer
		{
			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x06001F30 RID: 7984 RVA: 0x00017872 File Offset: 0x00015A72
			public bool started
			{
				get
				{
					return this._started;
				}
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06001F31 RID: 7985 RVA: 0x0001787A File Offset: 0x00015A7A
			public bool finished
			{
				get
				{
					if (!this.started)
					{
						return false;
					}
					if (Time.realtimeSinceStartup < this.end)
					{
						return false;
					}
					this._started = false;
					return true;
				}
			}

			// Token: 0x17000417 RID: 1047
			// (get) Token: 0x06001F32 RID: 7986 RVA: 0x0001789D File Offset: 0x00015A9D
			public float remaining
			{
				get
				{
					if (!this._started)
					{
						return 0f;
					}
					return this.end - Time.realtimeSinceStartup;
				}
			}

			// Token: 0x06001F34 RID: 7988 RVA: 0x000178B9 File Offset: 0x00015AB9
			public void Start(float length)
			{
				this.end = Time.realtimeSinceStartup + length;
				this._started = true;
			}

			// Token: 0x0400154F RID: 5455
			private bool _started;

			// Token: 0x04001550 RID: 5456
			private float end;
		}
	}
}
