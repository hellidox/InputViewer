using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002AB RID: 683
	[AddComponentMenu("")]
	public class CustomButton : Button, ICustomSelectable, ICancelHandler, IEventSystemHandler
	{
		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x00016691 File Offset: 0x00014891
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x00016699 File Offset: 0x00014899
		public Sprite disabledHighlightedSprite
		{
			get
			{
				return this._disabledHighlightedSprite;
			}
			set
			{
				this._disabledHighlightedSprite = value;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x000166A2 File Offset: 0x000148A2
		// (set) Token: 0x06001D76 RID: 7542 RVA: 0x000166AA File Offset: 0x000148AA
		public Color disabledHighlightedColor
		{
			get
			{
				return this._disabledHighlightedColor;
			}
			set
			{
				this._disabledHighlightedColor = value;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x000166B3 File Offset: 0x000148B3
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x000166BB File Offset: 0x000148BB
		public string disabledHighlightedTrigger
		{
			get
			{
				return this._disabledHighlightedTrigger;
			}
			set
			{
				this._disabledHighlightedTrigger = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x000166C4 File Offset: 0x000148C4
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x000166CC File Offset: 0x000148CC
		public bool autoNavUp
		{
			get
			{
				return this._autoNavUp;
			}
			set
			{
				this._autoNavUp = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x000166D5 File Offset: 0x000148D5
		// (set) Token: 0x06001D7C RID: 7548 RVA: 0x000166DD File Offset: 0x000148DD
		public bool autoNavDown
		{
			get
			{
				return this._autoNavDown;
			}
			set
			{
				this._autoNavDown = value;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x000166E6 File Offset: 0x000148E6
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x000166EE File Offset: 0x000148EE
		public bool autoNavLeft
		{
			get
			{
				return this._autoNavLeft;
			}
			set
			{
				this._autoNavLeft = value;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x000166F7 File Offset: 0x000148F7
		// (set) Token: 0x06001D80 RID: 7552 RVA: 0x000166FF File Offset: 0x000148FF
		public bool autoNavRight
		{
			get
			{
				return this._autoNavRight;
			}
			set
			{
				this._autoNavRight = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x00016708 File Offset: 0x00014908
		private bool isDisabled
		{
			get
			{
				return !this.IsInteractable();
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06001D82 RID: 7554 RVA: 0x000D2790 File Offset: 0x000D0990
		// (remove) Token: 0x06001D83 RID: 7555 RVA: 0x000D27C8 File Offset: 0x000D09C8
		private event UnityAction _CancelEvent;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06001D84 RID: 7556 RVA: 0x00016713 File Offset: 0x00014913
		// (remove) Token: 0x06001D85 RID: 7557 RVA: 0x0001671C File Offset: 0x0001491C
		public event UnityAction CancelEvent
		{
			add
			{
				this._CancelEvent += value;
			}
			remove
			{
				this._CancelEvent -= value;
			}
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x000D2800 File Offset: 0x000D0A00
		public override Selectable FindSelectableOnLeft()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None || this._autoNavLeft)
			{
				return UISelectionUtility.FindNextSelectable(this, base.transform, Vector3.left);
			}
			return base.FindSelectableOnLeft();
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x000D2840 File Offset: 0x000D0A40
		public override Selectable FindSelectableOnRight()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None || this._autoNavRight)
			{
				return UISelectionUtility.FindNextSelectable(this, base.transform, Vector3.right);
			}
			return base.FindSelectableOnRight();
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x000D2880 File Offset: 0x000D0A80
		public override Selectable FindSelectableOnUp()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None || this._autoNavUp)
			{
				return UISelectionUtility.FindNextSelectable(this, base.transform, Vector3.up);
			}
			return base.FindSelectableOnUp();
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x000D28C0 File Offset: 0x000D0AC0
		public override Selectable FindSelectableOnDown()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None || this._autoNavDown)
			{
				return UISelectionUtility.FindNextSelectable(this, base.transform, Vector3.down);
			}
			return base.FindSelectableOnDown();
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x00016725 File Offset: 0x00014925
		protected override void OnCanvasGroupChanged()
		{
			base.OnCanvasGroupChanged();
			if (EventSystem.current == null)
			{
				return;
			}
			this.EvaluateHightlightDisabled(EventSystem.current.currentSelectedGameObject == base.gameObject);
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x000D2900 File Offset: 0x000D0B00
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			if (this.isHighlightDisabled)
			{
				Color disabledHighlightedColor = this._disabledHighlightedColor;
				Sprite disabledHighlightedSprite = this._disabledHighlightedSprite;
				string disabledHighlightedTrigger = this._disabledHighlightedTrigger;
				if (base.gameObject.activeInHierarchy)
				{
					switch (base.transition)
					{
					case Selectable.Transition.ColorTint:
						this.StartColorTween(disabledHighlightedColor * base.colors.colorMultiplier, instant);
						return;
					case Selectable.Transition.SpriteSwap:
						this.DoSpriteSwap(disabledHighlightedSprite);
						return;
					case Selectable.Transition.Animation:
						this.TriggerAnimation(disabledHighlightedTrigger);
						return;
					default:
						return;
					}
				}
			}
			else
			{
				base.DoStateTransition(state, instant);
			}
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x000D2988 File Offset: 0x000D0B88
		private void StartColorTween(Color targetColor, bool instant)
		{
			if (base.targetGraphic == null)
			{
				return;
			}
			base.targetGraphic.CrossFadeColor(targetColor, instant ? 0f : base.colors.fadeDuration, true, true);
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x00016756 File Offset: 0x00014956
		private void DoSpriteSwap(Sprite newSprite)
		{
			if (base.image == null)
			{
				return;
			}
			base.image.overrideSprite = newSprite;
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x000D29CC File Offset: 0x000D0BCC
		private void TriggerAnimation(string triggername)
		{
			if (base.animator == null || !base.animator.enabled || !base.animator.isActiveAndEnabled || base.animator.runtimeAnimatorController == null || string.IsNullOrEmpty(triggername))
			{
				return;
			}
			base.animator.ResetTrigger(this._disabledHighlightedTrigger);
			base.animator.SetTrigger(triggername);
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00016773 File Offset: 0x00014973
		public override void OnSelect(BaseEventData eventData)
		{
			base.OnSelect(eventData);
			this.EvaluateHightlightDisabled(true);
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00016783 File Offset: 0x00014983
		public override void OnDeselect(BaseEventData eventData)
		{
			base.OnDeselect(eventData);
			this.EvaluateHightlightDisabled(false);
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00016793 File Offset: 0x00014993
		private void Press()
		{
			if (!this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			base.onClick.Invoke();
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x000D2A3C File Offset: 0x000D0C3C
		public override void OnPointerClick(PointerEventData eventData)
		{
			if (!this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.Press();
			if (!this.IsActive() || !this.IsInteractable())
			{
				this.isHighlightDisabled = true;
				this.DoStateTransition(Selectable.SelectionState.Disabled, false);
			}
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x000167B1 File Offset: 0x000149B1
		public override void OnSubmit(BaseEventData eventData)
		{
			this.Press();
			if (!this.IsActive() || !this.IsInteractable())
			{
				this.isHighlightDisabled = true;
				this.DoStateTransition(Selectable.SelectionState.Disabled, false);
				return;
			}
			this.DoStateTransition(Selectable.SelectionState.Pressed, false);
			base.StartCoroutine(this.OnFinishSubmit());
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x000167EE File Offset: 0x000149EE
		private IEnumerator OnFinishSubmit()
		{
			float fadeTime = base.colors.fadeDuration;
			float elapsedTime = 0f;
			while (elapsedTime < fadeTime)
			{
				elapsedTime += Time.unscaledDeltaTime;
				yield return null;
			}
			this.DoStateTransition(base.currentSelectionState, false);
			yield break;
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x000D2A88 File Offset: 0x000D0C88
		private void EvaluateHightlightDisabled(bool isSelected)
		{
			if (!isSelected)
			{
				if (this.isHighlightDisabled)
				{
					this.isHighlightDisabled = false;
					Selectable.SelectionState selectionState = (this.isDisabled ? Selectable.SelectionState.Disabled : base.currentSelectionState);
					this.DoStateTransition(selectionState, false);
					return;
				}
			}
			else
			{
				if (!this.isDisabled)
				{
					return;
				}
				this.isHighlightDisabled = true;
				this.DoStateTransition(Selectable.SelectionState.Disabled, false);
			}
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x000167FD File Offset: 0x000149FD
		public void OnCancel(BaseEventData eventData)
		{
			if (this._CancelEvent != null)
			{
				this._CancelEvent();
			}
		}

		// Token: 0x04001456 RID: 5206
		[SerializeField]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x04001457 RID: 5207
		[SerializeField]
		private Color _disabledHighlightedColor;

		// Token: 0x04001458 RID: 5208
		[SerializeField]
		private string _disabledHighlightedTrigger;

		// Token: 0x04001459 RID: 5209
		[SerializeField]
		private bool _autoNavUp = true;

		// Token: 0x0400145A RID: 5210
		[SerializeField]
		private bool _autoNavDown = true;

		// Token: 0x0400145B RID: 5211
		[SerializeField]
		private bool _autoNavLeft = true;

		// Token: 0x0400145C RID: 5212
		[SerializeField]
		private bool _autoNavRight = true;

		// Token: 0x0400145D RID: 5213
		private bool isHighlightDisabled;
	}
}
