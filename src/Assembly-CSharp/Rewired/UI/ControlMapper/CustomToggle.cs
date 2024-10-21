using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002AE RID: 686
	[AddComponentMenu("")]
	public class CustomToggle : Toggle, ICustomSelectable, ICancelHandler, IEventSystemHandler
	{
		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x00016960 File Offset: 0x00014B60
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x00016968 File Offset: 0x00014B68
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

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x00016971 File Offset: 0x00014B71
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x00016979 File Offset: 0x00014B79
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

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x00016982 File Offset: 0x00014B82
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x0001698A File Offset: 0x00014B8A
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

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00016993 File Offset: 0x00014B93
		// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x0001699B File Offset: 0x00014B9B
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

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x000169A4 File Offset: 0x00014BA4
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x000169AC File Offset: 0x00014BAC
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

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x000169B5 File Offset: 0x00014BB5
		// (set) Token: 0x06001DCA RID: 7626 RVA: 0x000169BD File Offset: 0x00014BBD
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

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x000169C6 File Offset: 0x00014BC6
		// (set) Token: 0x06001DCC RID: 7628 RVA: 0x000169CE File Offset: 0x00014BCE
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

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x00016708 File Offset: 0x00014908
		private bool isDisabled
		{
			get
			{
				return !this.IsInteractable();
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06001DCE RID: 7630 RVA: 0x000D2E2C File Offset: 0x000D102C
		// (remove) Token: 0x06001DCF RID: 7631 RVA: 0x000D2E64 File Offset: 0x000D1064
		private event UnityAction _CancelEvent;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06001DD0 RID: 7632 RVA: 0x000169D7 File Offset: 0x00014BD7
		// (remove) Token: 0x06001DD1 RID: 7633 RVA: 0x000169E0 File Offset: 0x00014BE0
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

		// Token: 0x06001DD2 RID: 7634 RVA: 0x000D2E9C File Offset: 0x000D109C
		public override Selectable FindSelectableOnLeft()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None || this._autoNavLeft)
			{
				return UISelectionUtility.FindNextSelectable(this, base.transform, Vector3.left);
			}
			return base.FindSelectableOnLeft();
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x000D2EDC File Offset: 0x000D10DC
		public override Selectable FindSelectableOnRight()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None || this._autoNavRight)
			{
				return UISelectionUtility.FindNextSelectable(this, base.transform, Vector3.right);
			}
			return base.FindSelectableOnRight();
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x000D2F1C File Offset: 0x000D111C
		public override Selectable FindSelectableOnUp()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None || this._autoNavUp)
			{
				return UISelectionUtility.FindNextSelectable(this, base.transform, Vector3.up);
			}
			return base.FindSelectableOnUp();
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x000D2F5C File Offset: 0x000D115C
		public override Selectable FindSelectableOnDown()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None || this._autoNavDown)
			{
				return UISelectionUtility.FindNextSelectable(this, base.transform, Vector3.down);
			}
			return base.FindSelectableOnDown();
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x000169E9 File Offset: 0x00014BE9
		protected override void OnCanvasGroupChanged()
		{
			base.OnCanvasGroupChanged();
			if (EventSystem.current == null)
			{
				return;
			}
			this.EvaluateHightlightDisabled(EventSystem.current.currentSelectedGameObject == base.gameObject);
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x000D2F9C File Offset: 0x000D119C
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

		// Token: 0x06001DD8 RID: 7640 RVA: 0x000D2988 File Offset: 0x000D0B88
		private void StartColorTween(Color targetColor, bool instant)
		{
			if (base.targetGraphic == null)
			{
				return;
			}
			base.targetGraphic.CrossFadeColor(targetColor, instant ? 0f : base.colors.fadeDuration, true, true);
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00016756 File Offset: 0x00014956
		private void DoSpriteSwap(Sprite newSprite)
		{
			if (base.image == null)
			{
				return;
			}
			base.image.overrideSprite = newSprite;
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x000D3024 File Offset: 0x000D1224
		private void TriggerAnimation(string triggername)
		{
			if (base.animator == null || !base.animator.enabled || !base.animator.isActiveAndEnabled || base.animator.runtimeAnimatorController == null || string.IsNullOrEmpty(triggername))
			{
				return;
			}
			base.animator.ResetTrigger(this._disabledHighlightedTrigger);
			base.animator.SetTrigger(triggername);
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00016A1A File Offset: 0x00014C1A
		public override void OnSelect(BaseEventData eventData)
		{
			base.OnSelect(eventData);
			this.EvaluateHightlightDisabled(true);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00016A2A File Offset: 0x00014C2A
		public override void OnDeselect(BaseEventData eventData)
		{
			base.OnDeselect(eventData);
			this.EvaluateHightlightDisabled(false);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x000D3094 File Offset: 0x000D1294
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

		// Token: 0x06001DDE RID: 7646 RVA: 0x00016A3A File Offset: 0x00014C3A
		public void OnCancel(BaseEventData eventData)
		{
			if (this._CancelEvent != null)
			{
				this._CancelEvent();
			}
		}

		// Token: 0x0400146D RID: 5229
		[SerializeField]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x0400146E RID: 5230
		[SerializeField]
		private Color _disabledHighlightedColor;

		// Token: 0x0400146F RID: 5231
		[SerializeField]
		private string _disabledHighlightedTrigger;

		// Token: 0x04001470 RID: 5232
		[SerializeField]
		private bool _autoNavUp = true;

		// Token: 0x04001471 RID: 5233
		[SerializeField]
		private bool _autoNavDown = true;

		// Token: 0x04001472 RID: 5234
		[SerializeField]
		private bool _autoNavLeft = true;

		// Token: 0x04001473 RID: 5235
		[SerializeField]
		private bool _autoNavRight = true;

		// Token: 0x04001474 RID: 5236
		private bool isHighlightDisabled;
	}
}
