using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	[Serializable]
	public class ThemeSettings : ScriptableObject
	{
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

		[SerializeField]
		private ThemeSettings.ImageSettings _mainWindowBackground;

		[SerializeField]
		private ThemeSettings.ImageSettings _popupWindowBackground;

		[SerializeField]
		private ThemeSettings.ImageSettings _areaBackground;

		[SerializeField]
		private ThemeSettings.SelectableSettings _selectableSettings;

		[SerializeField]
		private ThemeSettings.SelectableSettings _buttonSettings;

		[SerializeField]
		private ThemeSettings.SelectableSettings _inputGridFieldSettings;

		[SerializeField]
		private ThemeSettings.ScrollbarSettings _scrollbarSettings;

		[SerializeField]
		private ThemeSettings.SliderSettings _sliderSettings;

		[SerializeField]
		private ThemeSettings.ImageSettings _invertToggle;

		[SerializeField]
		private Color _invertToggleDisabledColor;

		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationBackground;

		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationValueMarker;

		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationRawValueMarker;

		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationZeroMarker;

		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationCalibratedZeroMarker;

		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationDeadzone;

		[SerializeField]
		private ThemeSettings.TextSettings _textSettings;

		[SerializeField]
		private ThemeSettings.TextSettings _buttonTextSettings;

		[SerializeField]
		private ThemeSettings.TextSettings _inputGridFieldTextSettings;

		[Serializable]
		private abstract class SelectableSettings_Base
		{
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

			[SerializeField]
			protected Selectable.Transition _transition;

			[SerializeField]
			protected ThemeSettings.CustomColorBlock _colors;

			[SerializeField]
			protected ThemeSettings.CustomSpriteState _spriteState;

			[SerializeField]
			protected ThemeSettings.CustomAnimationTriggers _animationTriggers;
		}

		[Serializable]
		private class SelectableSettings : ThemeSettings.SelectableSettings_Base
		{
			public ThemeSettings.ImageSettings imageSettings
			{
				get
				{
					return this._imageSettings;
				}
			}

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

			[SerializeField]
			private ThemeSettings.ImageSettings _imageSettings;
		}

		[Serializable]
		private class SliderSettings : ThemeSettings.SelectableSettings_Base
		{
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

			public override void Apply(Selectable item)
			{
				base.Apply(item);
				this.Apply(item as Slider);
			}

			[SerializeField]
			private ThemeSettings.ImageSettings _handleImageSettings;

			[SerializeField]
			private ThemeSettings.ImageSettings _fillImageSettings;

			[SerializeField]
			private ThemeSettings.ImageSettings _backgroundImageSettings;
		}

		[Serializable]
		private class ScrollbarSettings : ThemeSettings.SelectableSettings_Base
		{
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

			public override void Apply(Selectable item)
			{
				base.Apply(item);
				this.Apply(item as Scrollbar);
			}

			[SerializeField]
			private ThemeSettings.ImageSettings _handleImageSettings;

			[SerializeField]
			private ThemeSettings.ImageSettings _backgroundImageSettings;
		}

		[Serializable]
		private class ImageSettings
		{
			public Color color
			{
				get
				{
					return this._color;
				}
			}

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

			[SerializeField]
			private Color _color = Color.white;

			[SerializeField]
			private Sprite _sprite;

			[SerializeField]
			private Material _materal;

			[SerializeField]
			private Image.Type _type;

			[SerializeField]
			private bool _preserveAspect;

			[SerializeField]
			private bool _fillCenter;

			[SerializeField]
			private Image.FillMethod _fillMethod;

			[SerializeField]
			private float _fillAmout;

			[SerializeField]
			private bool _fillClockwise;

			[SerializeField]
			private int _fillOrigin;
		}

		[Serializable]
		private struct CustomColorBlock
		{
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

			public Color disabledHighlightedColor
			{
				get
				{
					return this.m_DisabledHighlightedColor;
				}
			}

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

			[SerializeField]
			private float m_ColorMultiplier;

			[SerializeField]
			private Color m_DisabledColor;

			[SerializeField]
			private float m_FadeDuration;

			[SerializeField]
			private Color m_HighlightedColor;

			[SerializeField]
			private Color m_NormalColor;

			[SerializeField]
			private Color m_PressedColor;

			[SerializeField]
			private Color m_SelectedColor;

			[SerializeField]
			private Color m_DisabledHighlightedColor;
		}

		[Serializable]
		private struct CustomSpriteState
		{
			public Sprite disabledHighlightedSprite
			{
				get
				{
					return this.m_DisabledHighlightedSprite;
				}
			}

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

			[SerializeField]
			private Sprite m_DisabledSprite;

			[SerializeField]
			private Sprite m_HighlightedSprite;

			[SerializeField]
			private Sprite m_PressedSprite;

			[SerializeField]
			private Sprite m_SelectedSprite;

			[SerializeField]
			private Sprite m_DisabledHighlightedSprite;
		}

		[Serializable]
		private class CustomAnimationTriggers
		{
			public CustomAnimationTriggers()
			{
				this.m_DisabledTrigger = string.Empty;
				this.m_HighlightedTrigger = string.Empty;
				this.m_NormalTrigger = string.Empty;
				this.m_PressedTrigger = string.Empty;
				this.m_SelectedTrigger = string.Empty;
				this.m_DisabledHighlightedTrigger = string.Empty;
			}

			public string disabledTrigger
			{
				get
				{
					return this.m_DisabledTrigger;
				}
			}

			public string highlightedTrigger
			{
				get
				{
					return this.m_HighlightedTrigger;
				}
			}

			public string normalTrigger
			{
				get
				{
					return this.m_NormalTrigger;
				}
			}

			public string pressedTrigger
			{
				get
				{
					return this.m_PressedTrigger;
				}
			}

			public string disabledHighlightedTrigger
			{
				get
				{
					return this.m_DisabledHighlightedTrigger;
				}
			}

			[SerializeField]
			private string m_DisabledTrigger;

			[SerializeField]
			private string m_HighlightedTrigger;

			[SerializeField]
			private string m_NormalTrigger;

			[SerializeField]
			private string m_PressedTrigger;

			[SerializeField]
			private string m_SelectedTrigger;

			[SerializeField]
			private string m_DisabledHighlightedTrigger;
		}

		[Serializable]
		private class TextSettings
		{
			public Color color
			{
				get
				{
					return this._color;
				}
			}

			public TMP_FontAsset font
			{
				get
				{
					return this._font;
				}
			}

			public ThemeSettings.FontStyleOverride style
			{
				get
				{
					return this._style;
				}
			}

			public float sizeMultiplier
			{
				get
				{
					return this._sizeMultiplier;
				}
			}

			public float lineSpacing
			{
				get
				{
					return this._lineSpacing;
				}
			}

			public float chracterSpacing
			{
				get
				{
					return this._characterSpacing;
				}
			}

			public float wordSpacing
			{
				get
				{
					return this._wordSpacing;
				}
			}

			[SerializeField]
			private Color _color = Color.white;

			[SerializeField]
			private TMP_FontAsset _font;

			[SerializeField]
			private ThemeSettings.FontStyleOverride _style;

			[SerializeField]
			private float _sizeMultiplier = 1f;

			[SerializeField]
			private float _lineSpacing = 1f;

			[SerializeField]
			private float _characterSpacing = 1f;

			[SerializeField]
			private float _wordSpacing = 1f;
		}

		private enum FontStyleOverride
		{
			Default,
			Normal,
			Bold,
			Italic,
			BoldAndItalic
		}
	}
}
