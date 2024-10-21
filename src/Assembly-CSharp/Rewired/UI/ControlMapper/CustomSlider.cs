using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002AD RID: 685
	[AddComponentMenu("")]
	public class CustomSlider : Slider, ICustomSelectable, ICancelHandler, IEventSystemHandler
	{
		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x0001684D File Offset: 0x00014A4D
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x00016855 File Offset: 0x00014A55
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

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x0001685E File Offset: 0x00014A5E
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x00016866 File Offset: 0x00014A66
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

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x0001686F File Offset: 0x00014A6F
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x00016877 File Offset: 0x00014A77
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

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00016880 File Offset: 0x00014A80
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x00016888 File Offset: 0x00014A88
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

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x00016891 File Offset: 0x00014A91
		// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x00016899 File Offset: 0x00014A99
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

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x000168A2 File Offset: 0x00014AA2
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x000168AA File Offset: 0x00014AAA
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

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x000168B3 File Offset: 0x00014AB3
		// (set) Token: 0x06001DAB RID: 7595 RVA: 0x000168BB File Offset: 0x00014ABB
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

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x00016708 File Offset: 0x00014908
		private bool isDisabled
		{
			get
			{
				return !this.IsInteractable();
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06001DAD RID: 7597 RVA: 0x000D2B70 File Offset: 0x000D0D70
		// (remove) Token: 0x06001DAE RID: 7598 RVA: 0x000D2BA8 File Offset: 0x000D0DA8
		private event UnityAction _CancelEvent;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06001DAF RID: 7599 RVA: 0x000168C4 File Offset: 0x00014AC4
		// (remove) Token: 0x06001DB0 RID: 7600 RVA: 0x000168CD File Offset: 0x00014ACD
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

		// Token: 0x06001DB1 RID: 7601 RVA: 0x000D2BE0 File Offset: 0x000D0DE0
		public override Selectable FindSelectableOnLeft()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None || this._autoNavLeft)
			{
				return UISelectionUtility.FindNextSelectable(this, base.transform, Vector3.left);
			}
			return base.FindSelectableOnLeft();
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x000D2C20 File Offset: 0x000D0E20
		public override Selectable FindSelectableOnRight()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None || this._autoNavRight)
			{
				return UISelectionUtility.FindNextSelectable(this, base.transform, Vector3.right);
			}
			return base.FindSelectableOnRight();
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x000D2C60 File Offset: 0x000D0E60
		public override Selectable FindSelectableOnUp()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None || this._autoNavUp)
			{
				return UISelectionUtility.FindNextSelectable(this, base.transform, Vector3.up);
			}
			return base.FindSelectableOnUp();
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x000D2CA0 File Offset: 0x000D0EA0
		public override Selectable FindSelectableOnDown()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None || this._autoNavDown)
			{
				return UISelectionUtility.FindNextSelectable(this, base.transform, Vector3.down);
			}
			return base.FindSelectableOnDown();
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x000168D6 File Offset: 0x00014AD6
		protected override void OnCanvasGroupChanged()
		{
			base.OnCanvasGroupChanged();
			if (EventSystem.current == null)
			{
				return;
			}
			this.EvaluateHightlightDisabled(EventSystem.current.currentSelectedGameObject == base.gameObject);
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x000D2CE0 File Offset: 0x000D0EE0
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

		// Token: 0x06001DB7 RID: 7607 RVA: 0x000D2988 File Offset: 0x000D0B88
		private void StartColorTween(Color targetColor, bool instant)
		{
			if (base.targetGraphic == null)
			{
				return;
			}
			base.targetGraphic.CrossFadeColor(targetColor, instant ? 0f : base.colors.fadeDuration, true, true);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00016756 File Offset: 0x00014956
		private void DoSpriteSwap(Sprite newSprite)
		{
			if (base.image == null)
			{
				return;
			}
			base.image.overrideSprite = newSprite;
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x000D2D68 File Offset: 0x000D0F68
		private void TriggerAnimation(string triggername)
		{
			if (base.animator == null || !base.animator.enabled || !base.animator.isActiveAndEnabled || base.animator.runtimeAnimatorController == null || string.IsNullOrEmpty(triggername))
			{
				return;
			}
			base.animator.ResetTrigger(this._disabledHighlightedTrigger);
			base.animator.SetTrigger(triggername);
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00016907 File Offset: 0x00014B07
		public override void OnSelect(BaseEventData eventData)
		{
			base.OnSelect(eventData);
			this.EvaluateHightlightDisabled(true);
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00016917 File Offset: 0x00014B17
		public override void OnDeselect(BaseEventData eventData)
		{
			base.OnDeselect(eventData);
			this.EvaluateHightlightDisabled(false);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x000D2DD8 File Offset: 0x000D0FD8
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

		// Token: 0x06001DBD RID: 7613 RVA: 0x00016927 File Offset: 0x00014B27
		public void OnCancel(BaseEventData eventData)
		{
			if (this._CancelEvent != null)
			{
				this._CancelEvent();
			}
		}

		// Token: 0x04001464 RID: 5220
		[SerializeField]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x04001465 RID: 5221
		[SerializeField]
		private Color _disabledHighlightedColor;

		// Token: 0x04001466 RID: 5222
		[SerializeField]
		private string _disabledHighlightedTrigger;

		// Token: 0x04001467 RID: 5223
		[SerializeField]
		private bool _autoNavUp = true;

		// Token: 0x04001468 RID: 5224
		[SerializeField]
		private bool _autoNavDown = true;

		// Token: 0x04001469 RID: 5225
		[SerializeField]
		private bool _autoNavLeft = true;

		// Token: 0x0400146A RID: 5226
		[SerializeField]
		private bool _autoNavRight = true;

		// Token: 0x0400146B RID: 5227
		private bool isHighlightDisabled;
	}
}
