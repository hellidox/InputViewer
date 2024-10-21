using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002BF RID: 703
	[Serializable]
	public class ThemeSettings : ScriptableObject
	{
		// Token: 0x06001EA8 RID: 7848 RVA: 0x000D400C File Offset: 0x000D220C
		public void Apply(ThemedElement.ElementInfo[] elementInfo)
		{
			if (elementInfo == null)
			{
				return;
			}
			for (int i = 0; i < elementInfo.Length; i++)
			{
				if (elementInfo[i] != null)
				{
					this.Apply(elementInfo[i].themeClass, elementInfo[i].component);
				}
			}
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000D4048 File Offset: 0x000D2248
		private void Apply(string themeClass, Component component)
		{
			if (component as Selectable != null)
			{
				this.Apply(themeClass, (Selectable)component);
				return;
			}
			if (component as Image != null)
			{
				this.Apply(themeClass, (Image)component);
				return;
			}
			if (component as TMP_Text != null)
			{
				this.Apply(themeClass, (TMP_Text)component);
				return;
			}
			if (component as UIImageHelper != null)
			{
				this.Apply(themeClass, (UIImageHelper)component);
				return;
			}
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x000D40C8 File Offset: 0x000D22C8
		private void Apply(string themeClass, Selectable item)
		{
			if (item == null)
			{
				return;
			}
			ThemeSettings.SelectableSettings_Base selectableSettings_Base;
			if (item as Button != null)
			{
				if (themeClass == "inputGridField")
				{
					selectableSettings_Base = this._inputGridFieldSettings;
				}
				else
				{
					selectableSettings_Base = this._buttonSettings;
				}
			}
			else if (item as Scrollbar != null)
			{
				selectableSettings_Base = this._scrollbarSettings;
			}
			else if (item as Slider != null)
			{
				selectableSettings_Base = this._sliderSettings;
			}
			else if (item as Toggle != null)
			{
				if (themeClass == "button")
				{
					selectableSettings_Base = this._buttonSettings;
				}
				else
				{
					selectableSettings_Base = this._selectableSettings;
				}
			}
			else
			{
				selectableSettings_Base = this._selectableSettings;
			}
			selectableSettings_Base.Apply(item);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x000D4178 File Offset: 0x000D2378
		private void Apply(string themeClass, Image item)
		{
			if (item == null)
			{
				return;
			}
			uint num = PrivateImplementationDetails.ComputeStringHash(themeClass);
			if (num <= 2822822017U)
			{
				if (num <= 665291243U)
				{
					if (num != 106194061U)
					{
						if (num != 283896133U)
						{
							if (num != 665291243U)
							{
								return;
							}
							if (!(themeClass == "calibrationBackground"))
							{
								return;
							}
							if (this._calibrationBackground != null)
							{
								this._calibrationBackground.CopyTo(item);
								return;
							}
						}
						else
						{
							if (!(themeClass == "popupWindow"))
							{
								return;
							}
							if (this._popupWindowBackground != null)
							{
								this._popupWindowBackground.CopyTo(item);
								return;
							}
						}
					}
					else
					{
						if (!(themeClass == "invertToggleButtonBackground"))
						{
							return;
						}
						if (this._buttonSettings != null)
						{
							this._buttonSettings.imageSettings.CopyTo(item);
						}
					}
				}
				else if (num != 2579191547U)
				{
					if (num != 2601460036U)
					{
						if (num != 2822822017U)
						{
							return;
						}
						if (!(themeClass == "invertToggle"))
						{
							return;
						}
						if (this._invertToggle != null)
						{
							this._invertToggle.CopyTo(item);
							return;
						}
					}
					else
					{
						if (!(themeClass == "area"))
						{
							return;
						}
						if (this._areaBackground != null)
						{
							this._areaBackground.CopyTo(item);
							return;
						}
					}
				}
				else
				{
					if (!(themeClass == "calibrationDeadzone"))
					{
						return;
					}
					if (this._calibrationDeadzone != null)
					{
						this._calibrationDeadzone.CopyTo(item);
						return;
					}
				}
			}
			else if (num <= 3490313510U)
			{
				if (num != 2998767316U)
				{
					if (num != 3338297968U)
					{
						if (num != 3490313510U)
						{
							return;
						}
						if (!(themeClass == "calibrationRawValueMarker"))
						{
							return;
						}
						if (this._calibrationRawValueMarker != null)
						{
							this._calibrationRawValueMarker.CopyTo(item);
							return;
						}
					}
					else
					{
						if (!(themeClass == "calibrationCalibratedZeroMarker"))
						{
							return;
						}
						if (this._calibrationCalibratedZeroMarker != null)
						{
							this._calibrationCalibratedZeroMarker.CopyTo(item);
							return;
						}
					}
				}
				else
				{
					if (!(themeClass == "mainWindow"))
					{
						return;
					}
					if (this._mainWindowBackground != null)
					{
						this._mainWindowBackground.CopyTo(item);
						return;
					}
				}
			}
			else if (num != 3776179782U)
			{
				if (num != 3836396811U)
				{
					if (num != 3911450241U)
					{
						return;
					}
					if (!(themeClass == "invertToggleBackground"))
					{
						return;
					}
					if (this._inputGridFieldSettings != null)
					{
						this._inputGridFieldSettings.imageSettings.CopyTo(item);
						return;
					}
				}
				else
				{
					if (!(themeClass == "calibrationZeroMarker"))
					{
						return;
					}
					if (this._calibrationZeroMarker != null)
					{
						this._calibrationZeroMarker.CopyTo(item);
						return;
					}
				}
			}
			else
			{
				if (!(themeClass == "calibrationValueMarker"))
				{
					return;
				}
				if (this._calibrationValueMarker != null)
				{
					this._calibrationValueMarker.CopyTo(item);
					return;
				}
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x000D4408 File Offset: 0x000D2608
		private void Apply(string themeClass, TMP_Text item)
		{
			if (item == null)
			{
				return;
			}
			ThemeSettings.TextSettings textSettings;
			if (!(themeClass == "button"))
			{
				if (!(themeClass == "inputGridField"))
				{
					textSettings = this._textSettings;
				}
				else
				{
					textSettings = this._inputGridFieldTextSettings;
				}
			}
			else
			{
				textSettings = this._buttonTextSettings;
			}
			if (textSettings.font != null)
			{
				item.font = textSettings.font;
			}
			item.color = textSettings.color;
			item.lineSpacing = textSettings.lineSpacing;
			if (textSettings.sizeMultiplier != 1f)
			{
				item.fontSize = (float)((int)(item.fontSize * textSettings.sizeMultiplier));
				item.fontSizeMax = (float)((int)(item.fontSizeMax * textSettings.sizeMultiplier));
				item.fontSizeMin = (float)((int)(item.fontSizeMin * textSettings.sizeMultiplier));
			}
			item.characterSpacing = textSettings.chracterSpacing;
			item.wordSpacing = textSettings.wordSpacing;
			if (textSettings.style != ThemeSettings.FontStyleOverride.Default)
			{
				item.fontStyle = ThemeSettings.GetFontStyle(textSettings.style);
			}
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x000171F3 File Offset: 0x000153F3
		private void Apply(string themeClass, UIImageHelper item)
		{
			if (item == null)
			{
				return;
			}
			item.SetEnabledStateColor(this._invertToggle.color);
			item.SetDisabledStateColor(this._invertToggleDisabledColor);
			item.Refresh();
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00017222 File Offset: 0x00015422
		private static FontStyles GetFontStyle(ThemeSettings.FontStyleOverride style)
		{
			switch (style)
			{
			case ThemeSettings.FontStyleOverride.Default:
			case ThemeSettings.FontStyleOverride.Normal:
				return FontStyles.Normal;
			case ThemeSettings.FontStyleOverride.Bold:
				return FontStyles.Bold;
			case ThemeSettings.FontStyleOverride.Italic:
				return FontStyles.Italic;
			case ThemeSettings.FontStyleOverride.BoldAndItalic:
				return FontStyles.Bold | FontStyles.Italic;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x040014E1 RID: 5345
		[SerializeField]
		private ThemeSettings.ImageSettings _mainWindowBackground;

		// Token: 0x040014E2 RID: 5346
		[SerializeField]
		private ThemeSettings.ImageSettings _popupWindowBackground;

		// Token: 0x040014E3 RID: 5347
		[SerializeField]
		private ThemeSettings.ImageSettings _areaBackground;

		// Token: 0x040014E4 RID: 5348
		[SerializeField]
		private ThemeSettings.SelectableSettings _selectableSettings;

		// Token: 0x040014E5 RID: 5349
		[SerializeField]
		private ThemeSettings.SelectableSettings _buttonSettings;

		// Token: 0x040014E6 RID: 5350
		[SerializeField]
		private ThemeSettings.SelectableSettings _inputGridFieldSettings;

		// Token: 0x040014E7 RID: 5351
		[SerializeField]
		private ThemeSettings.ScrollbarSettings _scrollbarSettings;

		// Token: 0x040014E8 RID: 5352
		[SerializeField]
		private ThemeSettings.SliderSettings _sliderSettings;

		// Token: 0x040014E9 RID: 5353
		[SerializeField]
		private ThemeSettings.ImageSettings _invertToggle;

		// Token: 0x040014EA RID: 5354
		[SerializeField]
		private Color _invertToggleDisabledColor;

		// Token: 0x040014EB RID: 5355
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationBackground;

		// Token: 0x040014EC RID: 5356
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationValueMarker;

		// Token: 0x040014ED RID: 5357
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationRawValueMarker;

		// Token: 0x040014EE RID: 5358
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationZeroMarker;

		// Token: 0x040014EF RID: 5359
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationCalibratedZeroMarker;

		// Token: 0x040014F0 RID: 5360
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationDeadzone;

		// Token: 0x040014F1 RID: 5361
		[SerializeField]
		private ThemeSettings.TextSettings _textSettings;

		// Token: 0x040014F2 RID: 5362
		[SerializeField]
		private ThemeSettings.TextSettings _buttonTextSettings;

		// Token: 0x040014F3 RID: 5363
		[SerializeField]
		private ThemeSettings.TextSettings _inputGridFieldTextSettings;

		// Token: 0x020002C0 RID: 704
		[Serializable]
		private abstract class SelectableSettings_Base
		{
			// Token: 0x06001EB0 RID: 7856 RVA: 0x000D4504 File Offset: 0x000D2704
			public virtual void Apply(Selectable item)
			{
				Selectable.Transition transition = this._transition;
				bool flag = item.transition != transition;
				item.transition = transition;
				ICustomSelectable customSelectable = item as ICustomSelectable;
				if (transition == Selectable.Transition.ColorTint)
				{
					ThemeSettings.CustomColorBlock colors = this._colors;
					colors.fadeDuration = 0f;
					item.colors = colors;
					colors.fadeDuration = this._colors.fadeDuration;
					item.colors = colors;
					if (customSelectable != null)
					{
						customSelectable.disabledHighlightedColor = colors.disabledHighlightedColor;
					}
				}
				else if (transition == Selectable.Transition.SpriteSwap)
				{
					item.spriteState = this._spriteState;
					if (customSelectable != null)
					{
						customSelectable.disabledHighlightedSprite = this._spriteState.disabledHighlightedSprite;
					}
				}
				else if (transition == Selectable.Transition.Animation)
				{
					item.animationTriggers.disabledTrigger = this._animationTriggers.disabledTrigger;
					item.animationTriggers.highlightedTrigger = this._animationTriggers.highlightedTrigger;
					item.animationTriggers.normalTrigger = this._animationTriggers.normalTrigger;
					item.animationTriggers.pressedTrigger = this._animationTriggers.pressedTrigger;
					if (customSelectable != null)
					{
						customSelectable.disabledHighlightedTrigger = this._animationTriggers.disabledHighlightedTrigger;
					}
				}
				if (flag)
				{
					item.targetGraphic.CrossFadeColor(item.targetGraphic.color, 0f, true, true);
				}
			}

			// Token: 0x040014F4 RID: 5364
			[SerializeField]
			protected Selectable.Transition _transition;

			// Token: 0x040014F5 RID: 5365
			[SerializeField]
			protected ThemeSettings.CustomColorBlock _colors;

			// Token: 0x040014F6 RID: 5366
			[SerializeField]
			protected ThemeSettings.CustomSpriteState _spriteState;

			// Token: 0x040014F7 RID: 5367
			[SerializeField]
			protected ThemeSettings.CustomAnimationTriggers _animationTriggers;
		}

		// Token: 0x020002C1 RID: 705
		[Serializable]
		private class SelectableSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x0001724D File Offset: 0x0001544D
			public ThemeSettings.ImageSettings imageSettings
			{
				get
				{
					return this._imageSettings;
				}
			}

			// Token: 0x06001EB3 RID: 7859 RVA: 0x00017255 File Offset: 0x00015455
			public override void Apply(Selectable item)
			{
				if (item == null)
				{
					return;
				}
				base.Apply(item);
				if (this._imageSettings != null)
				{
					this._imageSettings.CopyTo(item.targetGraphic as Image);
				}
			}

			// Token: 0x040014F8 RID: 5368
			[SerializeField]
			private ThemeSettings.ImageSettings _imageSettings;
		}

		// Token: 0x020002C2 RID: 706
		[Serializable]
		private class SliderSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x06001EB5 RID: 7861 RVA: 0x000D4648 File Offset: 0x000D2848
			private void Apply(Slider item)
			{
				if (item == null)
				{
					return;
				}
				if (this._handleImageSettings != null)
				{
					this._handleImageSettings.CopyTo(item.targetGraphic as Image);
				}
				if (this._fillImageSettings != null)
				{
					RectTransform fillRect = item.fillRect;
					if (fillRect != null)
					{
						this._fillImageSettings.CopyTo(fillRect.GetComponent<Image>());
					}
				}
				if (this._backgroundImageSettings != null)
				{
					Transform transform = item.transform.Find("Background");
					if (transform != null)
					{
						this._backgroundImageSettings.CopyTo(transform.GetComponent<Image>());
					}
				}
			}

			// Token: 0x06001EB6 RID: 7862 RVA: 0x0001728E File Offset: 0x0001548E
			public override void Apply(Selectable item)
			{
				base.Apply(item);
				this.Apply(item as Slider);
			}

			// Token: 0x040014F9 RID: 5369
			[SerializeField]
			private ThemeSettings.ImageSettings _handleImageSettings;

			// Token: 0x040014FA RID: 5370
			[SerializeField]
			private ThemeSettings.ImageSettings _fillImageSettings;

			// Token: 0x040014FB RID: 5371
			[SerializeField]
			private ThemeSettings.ImageSettings _backgroundImageSettings;
		}

		// Token: 0x020002C3 RID: 707
		[Serializable]
		private class ScrollbarSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x06001EB8 RID: 7864 RVA: 0x000D46DC File Offset: 0x000D28DC
			private void Apply(Scrollbar item)
			{
				if (item == null)
				{
					return;
				}
				if (this._handleImageSettings != null)
				{
					this._handleImageSettings.CopyTo(item.targetGraphic as Image);
				}
				if (this._backgroundImageSettings != null)
				{
					this._backgroundImageSettings.CopyTo(item.GetComponent<Image>());
				}
			}

			// Token: 0x06001EB9 RID: 7865 RVA: 0x000172A3 File Offset: 0x000154A3
			public override void Apply(Selectable item)
			{
				base.Apply(item);
				this.Apply(item as Scrollbar);
			}

			// Token: 0x040014FC RID: 5372
			[SerializeField]
			private ThemeSettings.ImageSettings _handleImageSettings;

			// Token: 0x040014FD RID: 5373
			[SerializeField]
			private ThemeSettings.ImageSettings _backgroundImageSettings;
		}

		// Token: 0x020002C4 RID: 708
		[Serializable]
		private class ImageSettings
		{
			// Token: 0x170003F3 RID: 1011
			// (get) Token: 0x06001EBB RID: 7867 RVA: 0x000172B8 File Offset: 0x000154B8
			public Color color
			{
				get
				{
					return this._color;
				}
			}

			// Token: 0x06001EBC RID: 7868 RVA: 0x000D472C File Offset: 0x000D292C
			public virtual void CopyTo(Image image)
			{
				if (image == null)
				{
					return;
				}
				image.color = this._color;
				image.sprite = this._sprite;
				image.material = this._materal;
				image.type = this._type;
				image.preserveAspect = this._preserveAspect;
				image.fillCenter = this._fillCenter;
				image.fillMethod = this._fillMethod;
				image.fillAmount = this._fillAmout;
				image.fillClockwise = this._fillClockwise;
				image.fillOrigin = this._fillOrigin;
			}

			// Token: 0x040014FE RID: 5374
			[SerializeField]
			private Color _color = Color.white;

			// Token: 0x040014FF RID: 5375
			[SerializeField]
			private Sprite _sprite;

			// Token: 0x04001500 RID: 5376
			[SerializeField]
			private Material _materal;

			// Token: 0x04001501 RID: 5377
			[SerializeField]
			private Image.Type _type;

			// Token: 0x04001502 RID: 5378
			[SerializeField]
			private bool _preserveAspect;

			// Token: 0x04001503 RID: 5379
			[SerializeField]
			private bool _fillCenter;

			// Token: 0x04001504 RID: 5380
			[SerializeField]
			private Image.FillMethod _fillMethod;

			// Token: 0x04001505 RID: 5381
			[SerializeField]
			private float _fillAmout;

			// Token: 0x04001506 RID: 5382
			[SerializeField]
			private bool _fillClockwise;

			// Token: 0x04001507 RID: 5383
			[SerializeField]
			private int _fillOrigin;
		}

		// Token: 0x020002C5 RID: 709
		[Serializable]
		private struct CustomColorBlock
		{
			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x06001EBE RID: 7870 RVA: 0x000172D3 File Offset: 0x000154D3
			// (set) Token: 0x06001EBF RID: 7871 RVA: 0x000172DB File Offset: 0x000154DB
			public float fadeDuration
			{
				get
				{
					return this.m_FadeDuration;
				}
				set
				{
					this.m_FadeDuration = value;
				}
			}

			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x000172E4 File Offset: 0x000154E4
			public Color disabledHighlightedColor
			{
				get
				{
					return this.m_DisabledHighlightedColor;
				}
			}

			// Token: 0x06001EC1 RID: 7873 RVA: 0x000D47BC File Offset: 0x000D29BC
			public static implicit operator ColorBlock(ThemeSettings.CustomColorBlock item)
			{
				return new ColorBlock
				{
					selectedColor = item.m_SelectedColor,
					colorMultiplier = item.m_ColorMultiplier,
					disabledColor = item.m_DisabledColor,
					fadeDuration = item.m_FadeDuration,
					highlightedColor = item.m_HighlightedColor,
					normalColor = item.m_NormalColor,
					pressedColor = item.m_PressedColor
				};
			}

			// Token: 0x04001508 RID: 5384
			[SerializeField]
			private float m_ColorMultiplier;

			// Token: 0x04001509 RID: 5385
			[SerializeField]
			private Color m_DisabledColor;

			// Token: 0x0400150A RID: 5386
			[SerializeField]
			private float m_FadeDuration;

			// Token: 0x0400150B RID: 5387
			[SerializeField]
			private Color m_HighlightedColor;

			// Token: 0x0400150C RID: 5388
			[SerializeField]
			private Color m_NormalColor;

			// Token: 0x0400150D RID: 5389
			[SerializeField]
			private Color m_PressedColor;

			// Token: 0x0400150E RID: 5390
			[SerializeField]
			private Color m_SelectedColor;

			// Token: 0x0400150F RID: 5391
			[SerializeField]
			private Color m_DisabledHighlightedColor;
		}

		// Token: 0x020002C6 RID: 710
		[Serializable]
		private struct CustomSpriteState
		{
			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x000172EC File Offset: 0x000154EC
			public Sprite disabledHighlightedSprite
			{
				get
				{
					return this.m_DisabledHighlightedSprite;
				}
			}

			// Token: 0x06001EC3 RID: 7875 RVA: 0x000D4830 File Offset: 0x000D2A30
			public static implicit operator SpriteState(ThemeSettings.CustomSpriteState item)
			{
				return new SpriteState
				{
					selectedSprite = item.m_SelectedSprite,
					disabledSprite = item.m_DisabledSprite,
					highlightedSprite = item.m_HighlightedSprite,
					pressedSprite = item.m_PressedSprite
				};
			}

			// Token: 0x04001510 RID: 5392
			[SerializeField]
			private Sprite m_DisabledSprite;

			// Token: 0x04001511 RID: 5393
			[SerializeField]
			private Sprite m_HighlightedSprite;

			// Token: 0x04001512 RID: 5394
			[SerializeField]
			private Sprite m_PressedSprite;

			// Token: 0x04001513 RID: 5395
			[SerializeField]
			private Sprite m_SelectedSprite;

			// Token: 0x04001514 RID: 5396
			[SerializeField]
			private Sprite m_DisabledHighlightedSprite;
		}

		// Token: 0x020002C7 RID: 711
		[Serializable]
		private class CustomAnimationTriggers
		{
			// Token: 0x06001EC4 RID: 7876 RVA: 0x000D487C File Offset: 0x000D2A7C
			public CustomAnimationTriggers()
			{
				this.m_DisabledTrigger = string.Empty;
				this.m_HighlightedTrigger = string.Empty;
				this.m_NormalTrigger = string.Empty;
				this.m_PressedTrigger = string.Empty;
				this.m_SelectedTrigger = string.Empty;
				this.m_DisabledHighlightedTrigger = string.Empty;
			}

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x000172F4 File Offset: 0x000154F4
			public string disabledTrigger
			{
				get
				{
					return this.m_DisabledTrigger;
				}
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x000172FC File Offset: 0x000154FC
			public string highlightedTrigger
			{
				get
				{
					return this.m_HighlightedTrigger;
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x00017304 File Offset: 0x00015504
			public string normalTrigger
			{
				get
				{
					return this.m_NormalTrigger;
				}
			}

			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x0001730C File Offset: 0x0001550C
			public string pressedTrigger
			{
				get
				{
					return this.m_PressedTrigger;
				}
			}

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x00017314 File Offset: 0x00015514
			public string disabledHighlightedTrigger
			{
				get
				{
					return this.m_DisabledHighlightedTrigger;
				}
			}

			// Token: 0x04001515 RID: 5397
			[SerializeField]
			private string m_DisabledTrigger;

			// Token: 0x04001516 RID: 5398
			[SerializeField]
			private string m_HighlightedTrigger;

			// Token: 0x04001517 RID: 5399
			[SerializeField]
			private string m_NormalTrigger;

			// Token: 0x04001518 RID: 5400
			[SerializeField]
			private string m_PressedTrigger;

			// Token: 0x04001519 RID: 5401
			[SerializeField]
			private string m_SelectedTrigger;

			// Token: 0x0400151A RID: 5402
			[SerializeField]
			private string m_DisabledHighlightedTrigger;
		}

		// Token: 0x020002C8 RID: 712
		[Serializable]
		private class TextSettings
		{
			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x06001ECA RID: 7882 RVA: 0x0001731C File Offset: 0x0001551C
			public Color color
			{
				get
				{
					return this._color;
				}
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x06001ECB RID: 7883 RVA: 0x00017324 File Offset: 0x00015524
			public TMP_FontAsset font
			{
				get
				{
					return this._font;
				}
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06001ECC RID: 7884 RVA: 0x0001732C File Offset: 0x0001552C
			public ThemeSettings.FontStyleOverride style
			{
				get
				{
					return this._style;
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x06001ECD RID: 7885 RVA: 0x00017334 File Offset: 0x00015534
			public float sizeMultiplier
			{
				get
				{
					return this._sizeMultiplier;
				}
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x06001ECE RID: 7886 RVA: 0x0001733C File Offset: 0x0001553C
			public float lineSpacing
			{
				get
				{
					return this._lineSpacing;
				}
			}

			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x06001ECF RID: 7887 RVA: 0x00017344 File Offset: 0x00015544
			public float chracterSpacing
			{
				get
				{
					return this._characterSpacing;
				}
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x0001734C File Offset: 0x0001554C
			public float wordSpacing
			{
				get
				{
					return this._wordSpacing;
				}
			}

			// Token: 0x0400151B RID: 5403
			[SerializeField]
			private Color _color = Color.white;

			// Token: 0x0400151C RID: 5404
			[SerializeField]
			private TMP_FontAsset _font;

			// Token: 0x0400151D RID: 5405
			[SerializeField]
			private ThemeSettings.FontStyleOverride _style;

			// Token: 0x0400151E RID: 5406
			[SerializeField]
			private float _sizeMultiplier = 1f;

			// Token: 0x0400151F RID: 5407
			[SerializeField]
			private float _lineSpacing = 1f;

			// Token: 0x04001520 RID: 5408
			[SerializeField]
			private float _characterSpacing = 1f;

			// Token: 0x04001521 RID: 5409
			[SerializeField]
			private float _wordSpacing = 1f;
		}

		// Token: 0x020002C9 RID: 713
		private enum FontStyleOverride
		{
			// Token: 0x04001523 RID: 5411
			Default,
			// Token: 0x04001524 RID: 5412
			Normal,
			// Token: 0x04001525 RID: 5413
			Bold,
			// Token: 0x04001526 RID: 5414
			Italic,
			// Token: 0x04001527 RID: 5415
			BoldAndItalic
		}
	}
}
