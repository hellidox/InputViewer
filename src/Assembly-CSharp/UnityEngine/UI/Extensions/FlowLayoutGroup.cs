using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("Layout/Extensions/Flow Layout Group")]
	public class FlowLayoutGroup : LayoutGroup
	{
		public override void SetLayoutVertical()
		{
			this.\u02B8\u02B2\u02B3\u02C1\u02BC\u02BB\u02B8\u02B9\u02C0\u02BF\u02C1(1, false);
		}

		public override void CalculateLayoutInputVertical()
		{
			if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Horizontal)
			{
				this.\u02BE\u02BE\u02B6\u02B4\u02B5\u02BA\u02BB\u02BF\u02BD\u02B8\u02B4 = this.\u02B8\u02B2\u02B3\u02C1\u02BC\u02BB\u02B8\u02B9\u02C0\u02BF\u02C1(1, true);
				return;
			}
			base.CalculateLayoutInputHorizontal();
			float num = this.\u02B6\u02B9\u02BE\u02BF\u02BC\u02B4\u02B2\u02BA\u02BF\u02B8\u02BB() + (float)base.padding.bottom + (float)base.padding.top;
			base.SetLayoutInputForAxis(num, -1f, -1f, 1);
		}

		public FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3 \u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1
		{
			get
			{
				return this.m_StartAxis;
			}
			set
			{
				base.SetProperty<FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3>(ref this.m_StartAxis, value);
			}
		}

		public virtual void \u02B3\u02BE\u02B5\u02B5\u02BD\u02B5\u02BF\u02BB\u02B4\u02B9\u02B2()
		{
			this.\u02B8\u02B2\u02B3\u02C1\u02BC\u02BB\u02B8\u02B9\u02C0\u02BF\u02C1(0, true);
		}

		protected bool \u02B3\u02BA\u02BB\u02B6\u02B4\u02B4\u02B5\u02C1\u02B7\u02B9\u02B6
		{
			get
			{
				return base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.MiddleCenter || base.childAlignment == TextAnchor.UpperCenter;
			}
		}

		private float \u02BE\u02BE\u02BB\u02BF\u02BF\u02BA\u02B4\u02C0\u02B2\u02B5\u02B6(float \u02BE\u02B2\u02BE\u02B7\u02C0\u02B9\u02BF\u02B9\u02B9\u02B4\u02BC, float \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5, float \u02B8\u02B9\u02C0\u02B5\u02BD\u02BF\u02B8\u02B5\u02B4\u02B7\u02BE)
		{
			if (this.\u02BE\u02B5\u02B2\u02B4\u02BA\u02BE\u02BE\u02B8\u02B3\u02B2\u02BC)
			{
				return \u02BE\u02B2\u02BE\u02B7\u02C0\u02B9\u02BF\u02B9\u02B9\u02B4\u02BC - \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5 - \u02B8\u02B9\u02C0\u02B5\u02BD\u02BF\u02B8\u02B5\u02B4\u02B7\u02BE;
			}
			if (this.\u02B8\u02B8\u02B3\u02B6\u02BD\u02B6\u02B5\u02B9\u02BD\u02BF\u02B9())
			{
				return \u02BE\u02B2\u02BE\u02B7\u02C0\u02B9\u02BF\u02B9\u02B9\u02B4\u02BC * 733f - this.\u02BA\u02BF\u02BD\u02BC\u02B2\u02BB\u02B3\u02B8\u02BD\u02BE\u02BE * 539f + \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5;
			}
			return \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5;
		}

		protected bool \u02B5\u02BC\u02C0\u02B5\u02C1\u02BA\u02B7\u02C0\u02B2\u02B4\u02BF
		{
			get
			{
				return base.childAlignment == TextAnchor.MiddleLeft || base.childAlignment == TextAnchor.MiddleRight || base.childAlignment == TextAnchor.MiddleCenter;
			}
		}

		public float \u02B6\u02C0\u02B3\u02B6\u02B2\u02C0\u02BB\u02B7\u02BE\u02C1\u02C1()
		{
			float num = 1751f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				num = Mathf.Max(LayoutUtility.GetMinWidth(base.rectChildren[i]), num);
			}
			return num;
		}

		public float \u02B8\u02B2\u02B3\u02C1\u02BC\u02BB\u02B8\u02B9\u02C0\u02BF\u02C1(int \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1, bool \u02B8\u02B6\u02B7\u02B2\u02B7\u02BE\u02BD\u02BD\u02BA\u02B4\u02BE)
		{
			float height = base.rectTransform.rect.height;
			float width = base.rectTransform.rect.width;
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = 0f;
			float num6 = 0f;
			if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Horizontal)
			{
				num5 = height;
				num6 = width - (float)base.padding.left - (float)base.padding.right;
				if (this.\u02B8\u02B6\u02B4\u02BE\u02B5\u02BF\u02B4\u02B7\u02C0\u02B7\u02B4)
				{
					num3 = (float)base.padding.bottom;
					num4 = (float)base.padding.top;
				}
				else
				{
					num3 = (float)base.padding.top;
					num4 = (float)base.padding.bottom;
				}
				num = this.\u02C0\u02B7\u02BF\u02B5\u02BF\u02B6\u02B9\u02B9\u02BD\u02B8\u02B9;
				num2 = this.\u02B5\u02BC\u02BC\u02B7\u02B8\u02C1\u02C0\u02B6\u02BB\u02C0\u02B9;
			}
			else if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Vertical)
			{
				num5 = width;
				num6 = height - (float)base.padding.top - (float)base.padding.bottom;
				if (this.\u02BE\u02B5\u02B2\u02B4\u02BA\u02BE\u02BE\u02B8\u02B3\u02B2\u02BC)
				{
					num3 = (float)base.padding.right;
					num4 = (float)base.padding.left;
				}
				else
				{
					num3 = (float)base.padding.left;
					num4 = (float)base.padding.right;
				}
				num = this.\u02B5\u02BC\u02BC\u02B7\u02B8\u02C1\u02C0\u02B6\u02BB\u02C0\u02B9;
				num2 = this.\u02C0\u02B7\u02BF\u02B5\u02BF\u02B6\u02B9\u02B9\u02BD\u02B8\u02B9;
			}
			float num7 = 0f;
			float num8 = 0f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				int num9 = i;
				RectTransform rectTransform = base.rectChildren[num9];
				float num10 = 0f;
				float num11 = 0f;
				if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Horizontal)
				{
					if (this.\u02B6\u02BA\u02BA\u02B4\u02B2\u02B8\u02BD\u02BB\u02C0\u02BE\u02C0)
					{
						num9 = (this.\u02B8\u02B6\u02B4\u02BE\u02B5\u02BF\u02B4\u02B7\u02C0\u02B7\u02B4 ? (base.rectChildren.Count - 1 - i) : i);
					}
					rectTransform = base.rectChildren[num9];
					num10 = LayoutUtility.GetPreferredSize(rectTransform, 0);
					num10 = Mathf.Min(num10, num6);
					num11 = LayoutUtility.GetPreferredSize(rectTransform, 1);
					num11 = Mathf.Min(num11, num6);
				}
				else if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Vertical)
				{
					if (this.\u02B6\u02BA\u02BA\u02B4\u02B2\u02B8\u02BD\u02BB\u02C0\u02BE\u02C0)
					{
						num9 = (this.\u02BE\u02B5\u02B2\u02B4\u02BA\u02BE\u02BE\u02B8\u02B3\u02B2\u02BC ? (base.rectChildren.Count - 1 - i) : i);
					}
					rectTransform = base.rectChildren[num9];
					num10 = LayoutUtility.GetPreferredSize(rectTransform, 1);
					num10 = Mathf.Min(num10, num6);
					num11 = LayoutUtility.GetPreferredSize(rectTransform, 0);
					num11 = Mathf.Min(num11, num6);
				}
				if (num7 + num10 > num6)
				{
					num7 -= num2;
					if (!\u02B8\u02B6\u02B7\u02B2\u02B7\u02BE\u02BD\u02BD\u02BA\u02B4\u02BE)
					{
						if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Horizontal)
						{
							float num12 = this.\u02BB\u02C0\u02BB\u02BA\u02BF\u02BD\u02B6\u02B9\u02B2\u02C1\u02BE(num5, num3, num8);
							this.\u02B3\u02BA\u02BE\u02BB\u02B3\u02B9\u02C0\u02B2\u02C0\u02B9\u02B5(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE, num7, num8, num6, (float)base.padding.left, num12, \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1);
						}
						else if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Vertical)
						{
							float num13 = this.\u02B4\u02B9\u02B8\u02B3\u02B2\u02B7\u02B2\u02BD\u02B7\u02BE\u02BC(num5, num3, num8);
							this.\u02BA\u02BD\u02C0\u02BE\u02B7\u02BB\u02BD\u02B4\u02BB\u02B8\u02B7(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE, num8, num7, num6, num13, (float)base.padding.top, \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1);
						}
					}
					this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Clear();
					num3 += num8;
					num3 += num;
					num8 = 0f;
					num7 = 0f;
				}
				num7 += num10;
				this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Add(rectTransform);
				if (num11 > num8)
				{
					num8 = num11;
				}
				if (i < base.rectChildren.Count - 1)
				{
					num7 += num2;
				}
			}
			if (!\u02B8\u02B6\u02B7\u02B2\u02B7\u02BE\u02BD\u02BD\u02BA\u02B4\u02BE)
			{
				if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Horizontal)
				{
					float num14 = this.\u02BB\u02C0\u02BB\u02BA\u02BF\u02BD\u02B6\u02B9\u02B2\u02C1\u02BE(height, num3, num8);
					num7 -= num2;
					this.\u02B3\u02BA\u02BE\u02BB\u02B3\u02B9\u02C0\u02B2\u02C0\u02B9\u02B5(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE, num7, num8, num6 - (this.\u02BA\u02B8\u02B8\u02BD\u02BC\u02B5\u02BD\u02B4\u02BF\u02BE\u02C1 ? 0f : num2), (float)base.padding.left, num14, \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1);
				}
				else if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Vertical)
				{
					float num15 = this.\u02B4\u02B9\u02B8\u02B3\u02B2\u02B7\u02B2\u02BD\u02B7\u02BE\u02BC(width, num3, num8);
					num7 -= num2;
					this.\u02BA\u02BD\u02C0\u02BE\u02B7\u02BB\u02BD\u02B4\u02BB\u02B8\u02B7(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE, num8, num7, num6 - (this.\u02C0\u02BF\u02B6\u02B6\u02B4\u02BD\u02B7\u02BA\u02C1\u02BB\u02B4 ? 0f : num2), num15, (float)base.padding.top, \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1);
				}
			}
			this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Clear();
			num3 += num8;
			num3 += num4;
			if (\u02B8\u02B6\u02B7\u02B2\u02B7\u02BE\u02BD\u02BD\u02BA\u02B4\u02BE)
			{
				base.SetLayoutInputForAxis(num3, num3, -1f, \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1);
			}
			if (this.\u02C1\u02B2\u02BA\u02B7\u02B4\u02B5\u02B9\u02B3\u02B6\u02B6\u02BB)
			{
				float num16 = height - (float)base.padding.top - (float)base.padding.bottom;
				RectTransform rectTransform2 = base.rectTransform;
				if (num3 > num16)
				{
					float num17 = num16 / num3;
					rectTransform2.localScale = new Vector3(1f, num17, 1f);
					rectTransform2.localPosition = new Vector3(0f, this.\u02C1\u02BD\u02B6\u02B4\u02B9\u02B9\u02B9\u02B7\u02BC\u02BD\u02B9 + (num3 - num16) * num17 / 2f);
				}
				else
				{
					rectTransform2.localScale = new Vector3(1f, 1f, 1f);
					rectTransform2.localPosition = new Vector3(0f, this.\u02C1\u02BD\u02B6\u02B4\u02B9\u02B9\u02B9\u02B7\u02BC\u02BD\u02B9);
				}
			}
			return num3;
		}

		public float \u02BD\u02C0\u02C1\u02BB\u02B4\u02B2\u02B9\u02B9\u02B3\u02B4\u02B2()
		{
			float num = 1248f;
			for (int i = 1; i < base.rectChildren.Count; i++)
			{
				num = Mathf.Max(LayoutUtility.GetMinWidth(base.rectChildren[i]), num);
			}
			return num;
		}

		public void \u02B3\u02B6\u02B4\u02B3\u02B7\u02BC\u02BA\u02BF\u02B8\u02BD\u02BA(FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
		{
			base.SetProperty<FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3>(ref this.m_StartAxis, \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5);
		}

		public float \u02BA\u02B6\u02BC\u02C0\u02BE\u02B6\u02B2\u02BC\u02B6\u02BE\u02BE()
		{
			float num = 0f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				num = Mathf.Max(LayoutUtility.GetMinWidth(base.rectChildren[i]), num);
			}
			return num;
		}

		public float \u02BD\u02BE\u02B8\u02BD\u02BD\u02B6\u02BC\u02B5\u02B8\u02B6\u02B3(int \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1, bool \u02B8\u02B6\u02B7\u02B2\u02B7\u02BE\u02BD\u02BD\u02BA\u02B4\u02BE)
		{
			float height = base.rectTransform.rect.height;
			float width = base.rectTransform.rect.width;
			float num = 1756f;
			float num2 = 1841f;
			float num3 = 167f;
			float num4 = 1804f;
			float num5 = 990f;
			float num6 = 1462f;
			if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Horizontal)
			{
				num5 = height;
				num6 = width - (float)base.padding.left - (float)base.padding.right;
				if (this.\u02B8\u02B6\u02B4\u02BE\u02B5\u02BF\u02B4\u02B7\u02C0\u02B7\u02B4)
				{
					num3 = (float)base.padding.bottom;
					num4 = (float)base.padding.top;
				}
				else
				{
					num3 = (float)base.padding.top;
					num4 = (float)base.padding.bottom;
				}
				num = this.\u02C0\u02B7\u02BF\u02B5\u02BF\u02B6\u02B9\u02B9\u02BD\u02B8\u02B9;
				num2 = this.\u02B5\u02BC\u02BC\u02B7\u02B8\u02C1\u02C0\u02B6\u02BB\u02C0\u02B9;
			}
			else if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Vertical)
			{
				num5 = width;
				num6 = height - (float)base.padding.top - (float)base.padding.bottom;
				if (this.\u02BE\u02B5\u02B2\u02B4\u02BA\u02BE\u02BE\u02B8\u02B3\u02B2\u02BC)
				{
					num3 = (float)base.padding.right;
					num4 = (float)base.padding.left;
				}
				else
				{
					num3 = (float)base.padding.left;
					num4 = (float)base.padding.right;
				}
				num = this.\u02B5\u02BC\u02BC\u02B7\u02B8\u02C1\u02C0\u02B6\u02BB\u02C0\u02B9;
				num2 = this.\u02C0\u02B7\u02BF\u02B5\u02BF\u02B6\u02B9\u02B9\u02BD\u02B8\u02B9;
			}
			float num7 = 1124f;
			float num8 = 1772f;
			for (int i = 0; i < base.rectChildren.Count; i += 0)
			{
				int num9 = i;
				RectTransform rectTransform = base.rectChildren[num9];
				float num10 = 1114f;
				float num11 = 1379f;
				if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Horizontal)
				{
					if (this.\u02B6\u02BA\u02BA\u02B4\u02B2\u02B8\u02BD\u02BB\u02C0\u02BE\u02C0)
					{
						num9 = (this.\u02B8\u02B6\u02B4\u02BE\u02B5\u02BF\u02B4\u02B7\u02C0\u02B7\u02B4 ? (base.rectChildren.Count - 1 - i) : i);
					}
					rectTransform = base.rectChildren[num9];
					num10 = LayoutUtility.GetPreferredSize(rectTransform, 1);
					num10 = Mathf.Min(num10, num6);
					num11 = LayoutUtility.GetPreferredSize(rectTransform, 1);
					num11 = Mathf.Min(num11, num6);
				}
				else if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Vertical)
				{
					if (this.\u02B6\u02BA\u02BA\u02B4\u02B2\u02B8\u02BD\u02BB\u02C0\u02BE\u02C0)
					{
						num9 = (this.\u02BE\u02B5\u02B2\u02B4\u02BA\u02BE\u02BE\u02B8\u02B3\u02B2\u02BC ? (base.rectChildren.Count - 1 - i) : i);
					}
					rectTransform = base.rectChildren[num9];
					num10 = LayoutUtility.GetPreferredSize(rectTransform, 1);
					num10 = Mathf.Min(num10, num6);
					num11 = LayoutUtility.GetPreferredSize(rectTransform, 0);
					num11 = Mathf.Min(num11, num6);
				}
				if (num7 + num10 > num6)
				{
					num7 -= num2;
					if (!\u02B8\u02B6\u02B7\u02B2\u02B7\u02BE\u02BD\u02BD\u02BA\u02B4\u02BE)
					{
						if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Horizontal)
						{
							float num12 = this.\u02BB\u02C0\u02BB\u02BA\u02BF\u02BD\u02B6\u02B9\u02B2\u02C1\u02BE(num5, num3, num8);
							this.\u02B3\u02BA\u02BE\u02BB\u02B3\u02B9\u02C0\u02B2\u02C0\u02B9\u02B5(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE, num7, num8, num6, (float)base.padding.left, num12, \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1);
						}
						else if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Vertical)
						{
							float num13 = this.\u02BE\u02BE\u02BB\u02BF\u02BF\u02BA\u02B4\u02C0\u02B2\u02B5\u02B6(num5, num3, num8);
							this.\u02BA\u02BD\u02C0\u02BE\u02B7\u02BB\u02BD\u02B4\u02BB\u02B8\u02B7(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE, num8, num7, num6, num13, (float)base.padding.top, \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1);
						}
					}
					this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Clear();
					num3 += num8;
					num3 += num;
					num8 = 1665f;
					num7 = 725f;
				}
				num7 += num10;
				this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Add(rectTransform);
				if (num11 > num8)
				{
					num8 = num11;
				}
				if (i < base.rectChildren.Count - 1)
				{
					num7 += num2;
				}
			}
			if (!\u02B8\u02B6\u02B7\u02B2\u02B7\u02BE\u02BD\u02BD\u02BA\u02B4\u02BE)
			{
				if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Horizontal)
				{
					float num14 = this.\u02BB\u02C0\u02BB\u02BA\u02BF\u02BD\u02B6\u02B9\u02B2\u02C1\u02BE(height, num3, num8);
					num7 -= num2;
					this.\u02B3\u02BA\u02BE\u02BB\u02B3\u02B9\u02C0\u02B2\u02C0\u02B9\u02B5(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE, num7, num8, num6 - (this.\u02BA\u02B8\u02B8\u02BD\u02BC\u02B5\u02BD\u02B4\u02BF\u02BE\u02C1 ? 1815f : num2), (float)base.padding.left, num14, \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1);
				}
				else if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Vertical)
				{
					float num15 = this.\u02B4\u02B9\u02B8\u02B3\u02B2\u02B7\u02B2\u02BD\u02B7\u02BE\u02BC(width, num3, num8);
					num7 -= num2;
					this.\u02BA\u02BD\u02C0\u02BE\u02B7\u02BB\u02BD\u02B4\u02BB\u02B8\u02B7(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE, num8, num7, num6 - (this.\u02C0\u02BF\u02B6\u02B6\u02B4\u02BD\u02B7\u02BA\u02C1\u02BB\u02B4 ? 149f : num2), num15, (float)base.padding.top, \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1);
				}
			}
			this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Clear();
			num3 += num8;
			num3 += num4;
			if (\u02B8\u02B6\u02B7\u02B2\u02B7\u02BE\u02BD\u02BD\u02BA\u02B4\u02BE)
			{
				base.SetLayoutInputForAxis(num3, num3, 139f, \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1);
			}
			if (this.\u02C1\u02B2\u02BA\u02B7\u02B4\u02B5\u02B9\u02B3\u02B6\u02B6\u02BB)
			{
				float num16 = height - (float)base.padding.top - (float)base.padding.bottom;
				RectTransform rectTransform2 = base.rectTransform;
				if (num3 > num16)
				{
					float num17 = num16 / num3;
					rectTransform2.localScale = new Vector3(923f, num17, 106f);
					rectTransform2.localPosition = new Vector3(996f, this.\u02C1\u02BD\u02B6\u02B4\u02B9\u02B9\u02B9\u02B7\u02BC\u02BD\u02B9 + (num3 - num16) * num17 / 1710f);
				}
				else
				{
					rectTransform2.localScale = new Vector3(784f, 1235f, 897f);
					rectTransform2.localPosition = new Vector3(1035f, this.\u02C1\u02BD\u02B6\u02B4\u02B9\u02B9\u02B9\u02B7\u02BC\u02BD\u02B9);
				}
			}
			return num3;
		}

		private float \u02BB\u02C0\u02BB\u02BA\u02BF\u02BD\u02B6\u02B9\u02B2\u02C1\u02BE(float \u02B4\u02B3\u02B4\u02BC\u02B6\u02BF\u02BD\u02B2\u02B9\u02BB\u02BC, float \u02B4\u02C1\u02B3\u02B2\u02B6\u02B7\u02B2\u02B9\u02B6\u02B2\u02B2, float \u02B8\u02B9\u02BD\u02B2\u02BC\u02B3\u02B9\u02C1\u02C1\u02B8\u02BC)
		{
			if (this.\u02B8\u02B6\u02B4\u02BE\u02B5\u02BF\u02B4\u02B7\u02C0\u02B7\u02B4)
			{
				return \u02B4\u02B3\u02B4\u02BC\u02B6\u02BF\u02BD\u02B2\u02B9\u02BB\u02BC - \u02B4\u02C1\u02B3\u02B2\u02B6\u02B7\u02B2\u02B9\u02B6\u02B2\u02B2 - \u02B8\u02B9\u02BD\u02B2\u02BC\u02B3\u02B9\u02C1\u02C1\u02B8\u02BC;
			}
			if (this.\u02B5\u02BC\u02C0\u02B5\u02C1\u02BA\u02B7\u02C0\u02B2\u02B4\u02BF)
			{
				return \u02B4\u02B3\u02B4\u02BC\u02B6\u02BF\u02BD\u02B2\u02B9\u02BB\u02BC * 0.5f - this.\u02BE\u02BE\u02B6\u02B4\u02B5\u02BA\u02BB\u02BF\u02BD\u02B8\u02B4 * 0.5f + \u02B4\u02C1\u02B3\u02B2\u02B6\u02B7\u02B2\u02B9\u02B6\u02B2\u02B2;
			}
			return \u02B4\u02C1\u02B3\u02B2\u02B6\u02B7\u02B2\u02B9\u02B6\u02B2\u02B2;
		}

		private float \u02BE\u02BB\u02BF\u02BA\u02B7\u02B3\u02BE\u02B6\u02B4\u02B7\u02B8(float \u02BE\u02B2\u02BE\u02B7\u02C0\u02B9\u02BF\u02B9\u02B9\u02B4\u02BC, float \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5, float \u02B8\u02B9\u02C0\u02B5\u02BD\u02BF\u02B8\u02B5\u02B4\u02B7\u02BE)
		{
			if (this.\u02BE\u02B5\u02B2\u02B4\u02BA\u02BE\u02BE\u02B8\u02B3\u02B2\u02BC)
			{
				return \u02BE\u02B2\u02BE\u02B7\u02C0\u02B9\u02BF\u02B9\u02B9\u02B4\u02BC - \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5 - \u02B8\u02B9\u02C0\u02B5\u02BD\u02BF\u02B8\u02B5\u02B4\u02B7\u02BE;
			}
			if (this.\u02B3\u02BA\u02BB\u02B6\u02B4\u02B4\u02B5\u02C1\u02B7\u02B9\u02B6)
			{
				return \u02BE\u02B2\u02BE\u02B7\u02C0\u02B9\u02BF\u02B9\u02B9\u02B4\u02BC * 1282f - this.\u02BA\u02BF\u02BD\u02BC\u02B2\u02BB\u02B3\u02B8\u02BD\u02BE\u02BE * 1388f + \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5;
			}
			return \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5;
		}

		public virtual void \u02B7\u02BF\u02B8\u02B7\u02BB\u02B6\u02C1\u02B2\u02B7\u02B8\u02C0()
		{
			this.\u02B8\u02B2\u02B3\u02C1\u02BC\u02BB\u02B8\u02B9\u02C0\u02BF\u02C1(0, false);
		}

		public void \u02C0\u02BF\u02BC\u02B2\u02B4\u02C1\u02B6\u02BA\u02B6\u02BB\u02B7(FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
		{
			base.SetProperty<FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3>(ref this.m_StartAxis, \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5);
		}

		protected void \u02B3\u02BA\u02BE\u02BB\u02B3\u02B9\u02C0\u02B2\u02C0\u02B9\u02B5(IList<RectTransform> \u02B3\u02B6\u02B6\u02B2\u02B7\u02BC\u02BD\u02B7\u02B7\u02B5\u02BD, float \u02BA\u02B5\u02B5\u02B7\u02C0\u02B7\u02B4\u02B8\u02BB\u02B3\u02BC, float \u02B6\u02BE\u02B6\u02BB\u02B5\u02B3\u02B4\u02BE\u02C0\u02B2\u02B5, float \u02BA\u02B4\u02B5\u02BE\u02BB\u02BA\u02B5\u02B2\u02BC\u02BA\u02B4, float \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5, float \u02B4\u02C1\u02B3\u02B2\u02B6\u02B7\u02B2\u02B9\u02B6\u02B2\u02B2, int \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1)
		{
			float num = \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5;
			if (!this.\u02BA\u02B8\u02B8\u02BD\u02BC\u02B5\u02BD\u02B4\u02BF\u02BE\u02C1 && this.\u02B3\u02BA\u02BB\u02B6\u02B4\u02B4\u02B5\u02C1\u02B7\u02B9\u02B6)
			{
				num += (\u02BA\u02B4\u02B5\u02BE\u02BB\u02BA\u02B5\u02B2\u02BC\u02BA\u02B4 - \u02BA\u02B5\u02B5\u02B7\u02C0\u02B7\u02B4\u02B8\u02BB\u02B3\u02BC) * 0.5f;
			}
			else if (!this.\u02BA\u02B8\u02B8\u02BD\u02BC\u02B5\u02BD\u02B4\u02BF\u02BE\u02C1 && this.\u02BE\u02B5\u02B2\u02B4\u02BA\u02BE\u02BE\u02B8\u02B3\u02B2\u02BC)
			{
				num += \u02BA\u02B4\u02B5\u02BE\u02BB\u02BA\u02B5\u02B2\u02BC\u02BA\u02B4 - \u02BA\u02B5\u02B5\u02B7\u02C0\u02B7\u02B4\u02B8\u02BB\u02B3\u02BC;
			}
			float num2 = 0f;
			float num3 = 0f;
			if (this.\u02BA\u02B8\u02B8\u02BD\u02BC\u02B5\u02BD\u02B4\u02BF\u02BE\u02C1)
			{
				num2 = (\u02BA\u02B4\u02B5\u02BE\u02BB\u02BA\u02B5\u02B2\u02BC\u02BA\u02B4 - \u02BA\u02B5\u02B5\u02B7\u02C0\u02B7\u02B4\u02B8\u02BB\u02B3\u02BC) / (float)this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count;
			}
			else if (this.\u02BC\u02BA\u02BF\u02BC\u02B3\u02BF\u02BD\u02BC\u02B2\u02B3\u02B3)
			{
				num3 = (\u02BA\u02B4\u02B5\u02BE\u02BB\u02BA\u02B5\u02B2\u02BC\u02BA\u02B4 - \u02BA\u02B5\u02B5\u02B7\u02C0\u02B7\u02B4\u02B8\u02BB\u02B3\u02BC) / (float)(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count - 1);
				if (this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count > 1)
				{
					if (this.\u02B3\u02BA\u02BB\u02B6\u02B4\u02B4\u02B5\u02C1\u02B7\u02B9\u02B6)
					{
						num -= num3 * 0.5f * (float)(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count - 1);
					}
					else if (this.\u02BE\u02B5\u02B2\u02B4\u02BA\u02BE\u02BE\u02B8\u02B3\u02B2\u02BC)
					{
						num -= num3 * (float)(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count - 1);
					}
				}
			}
			for (int i = 0; i < this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count; i++)
			{
				int num4 = (this.\u02B8\u02B6\u02B4\u02BE\u02B5\u02BF\u02B4\u02B7\u02C0\u02B7\u02B4 ? (this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count - 1 - i) : i);
				RectTransform rectTransform = this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE[num4];
				float num5 = LayoutUtility.GetPreferredSize(rectTransform, 0) + num2;
				float num6 = LayoutUtility.GetPreferredSize(rectTransform, 1);
				if (this.\u02C0\u02BF\u02B6\u02B6\u02B4\u02BD\u02B7\u02BA\u02C1\u02BB\u02B4)
				{
					num6 = \u02B6\u02BE\u02B6\u02BB\u02B5\u02B3\u02B4\u02BE\u02C0\u02B2\u02B5;
				}
				num5 = Mathf.Min(num5, \u02BA\u02B4\u02B5\u02BE\u02BB\u02BA\u02B5\u02B2\u02BC\u02BA\u02B4);
				float num7 = \u02B4\u02C1\u02B3\u02B2\u02B6\u02B7\u02B2\u02B9\u02B6\u02B2\u02B2;
				if (this.\u02B5\u02BC\u02C0\u02B5\u02C1\u02BA\u02B7\u02C0\u02B2\u02B4\u02BF)
				{
					num7 += (\u02B6\u02BE\u02B6\u02BB\u02B5\u02B3\u02B4\u02BE\u02C0\u02B2\u02B5 - num6) * 0.5f;
				}
				else if (this.\u02B8\u02B6\u02B4\u02BE\u02B5\u02BF\u02B4\u02B7\u02C0\u02B7\u02B4)
				{
					num7 += \u02B6\u02BE\u02B6\u02BB\u02B5\u02B3\u02B4\u02BE\u02C0\u02B2\u02B5 - num6;
				}
				if (this.\u02BC\u02BA\u02BF\u02BC\u02B3\u02BF\u02BD\u02BC\u02B2\u02B3\u02B3 && i > 0)
				{
					num += num3;
				}
				if (\u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1 == 0)
				{
					base.SetChildAlongAxis(rectTransform, 0, num, num5);
				}
				else
				{
					base.SetChildAlongAxis(rectTransform, 1, num7, num6);
				}
				if (i < this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count - 1)
				{
					num += num5 + this.\u02B5\u02BC\u02BC\u02B7\u02B8\u02C1\u02C0\u02B6\u02BB\u02C0\u02B9;
				}
			}
		}

		protected bool \u02B5\u02B6\u02B8\u02B6\u02B5\u02BA\u02B3\u02B6\u02B3\u02B6\u02B5()
		{
			return base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.LowerRight;
		}

		protected void \u02BA\u02BD\u02C0\u02BE\u02B7\u02BB\u02BD\u02B4\u02BB\u02B8\u02B7(IList<RectTransform> \u02B3\u02B6\u02B6\u02B2\u02B7\u02BC\u02BD\u02B7\u02B7\u02B5\u02BD, float \u02BA\u02BE\u02B5\u02B2\u02B6\u02B8\u02BF\u02B8\u02BE\u02BD\u02B9, float \u02C1\u02B9\u02C1\u02B9\u02B7\u02BD\u02B2\u02B5\u02B5\u02C0\u02BA, float \u02B9\u02B4\u02BD\u02BD\u02BC\u02B4\u02B3\u02B4\u02B9\u02B2\u02BC, float \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5, float \u02B4\u02C1\u02B3\u02B2\u02B6\u02B7\u02B2\u02B9\u02B6\u02B2\u02B2, int \u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1)
		{
			float num = \u02B4\u02C1\u02B3\u02B2\u02B6\u02B7\u02B2\u02B9\u02B6\u02B2\u02B2;
			if (!this.\u02C0\u02BF\u02B6\u02B6\u02B4\u02BD\u02B7\u02BA\u02C1\u02BB\u02B4 && this.\u02B5\u02BC\u02C0\u02B5\u02C1\u02BA\u02B7\u02C0\u02B2\u02B4\u02BF)
			{
				num += (\u02B9\u02B4\u02BD\u02BD\u02BC\u02B4\u02B3\u02B4\u02B9\u02B2\u02BC - \u02C1\u02B9\u02C1\u02B9\u02B7\u02BD\u02B2\u02B5\u02B5\u02C0\u02BA) * 0.5f;
			}
			else if (!this.\u02C0\u02BF\u02B6\u02B6\u02B4\u02BD\u02B7\u02BA\u02C1\u02BB\u02B4 && this.\u02B8\u02B6\u02B4\u02BE\u02B5\u02BF\u02B4\u02B7\u02C0\u02B7\u02B4)
			{
				num += \u02B9\u02B4\u02BD\u02BD\u02BC\u02B4\u02B3\u02B4\u02B9\u02B2\u02BC - \u02C1\u02B9\u02C1\u02B9\u02B7\u02BD\u02B2\u02B5\u02B5\u02C0\u02BA;
			}
			float num2 = 0f;
			float num3 = 0f;
			if (this.\u02C0\u02BF\u02B6\u02B6\u02B4\u02BD\u02B7\u02BA\u02C1\u02BB\u02B4)
			{
				num2 = (\u02B9\u02B4\u02BD\u02BD\u02BC\u02B4\u02B3\u02B4\u02B9\u02B2\u02BC - \u02C1\u02B9\u02C1\u02B9\u02B7\u02BD\u02B2\u02B5\u02B5\u02C0\u02BA) / (float)this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count;
			}
			else if (this.\u02BC\u02BA\u02BF\u02BC\u02B3\u02BF\u02BD\u02BC\u02B2\u02B3\u02B3)
			{
				num3 = (\u02B9\u02B4\u02BD\u02BD\u02BC\u02B4\u02B3\u02B4\u02B9\u02B2\u02BC - \u02C1\u02B9\u02C1\u02B9\u02B7\u02BD\u02B2\u02B5\u02B5\u02C0\u02BA) / (float)(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count - 1);
				if (this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count > 1)
				{
					if (this.\u02B5\u02BC\u02C0\u02B5\u02C1\u02BA\u02B7\u02C0\u02B2\u02B4\u02BF)
					{
						num -= num3 * 0.5f * (float)(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count - 1);
					}
					else if (this.\u02B8\u02B6\u02B4\u02BE\u02B5\u02BF\u02B4\u02B7\u02C0\u02B7\u02B4)
					{
						num -= num3 * (float)(this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count - 1);
					}
				}
			}
			for (int i = 0; i < this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count; i++)
			{
				int num4 = (this.\u02BE\u02B5\u02B2\u02B4\u02BA\u02BE\u02BE\u02B8\u02B3\u02B2\u02BC ? (this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count - 1 - i) : i);
				RectTransform rectTransform = this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE[num4];
				float num5 = LayoutUtility.GetPreferredSize(rectTransform, 0);
				float num6 = LayoutUtility.GetPreferredSize(rectTransform, 1) + num2;
				if (this.\u02BA\u02B8\u02B8\u02BD\u02BC\u02B5\u02BD\u02B4\u02BF\u02BE\u02C1)
				{
					num5 = \u02BA\u02BE\u02B5\u02B2\u02B6\u02B8\u02BF\u02B8\u02BE\u02BD\u02B9;
				}
				num6 = Mathf.Min(num6, \u02B9\u02B4\u02BD\u02BD\u02BC\u02B4\u02B3\u02B4\u02B9\u02B2\u02BC);
				float num7 = \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5;
				if (this.\u02B3\u02BA\u02BB\u02B6\u02B4\u02B4\u02B5\u02C1\u02B7\u02B9\u02B6)
				{
					num7 += (\u02BA\u02BE\u02B5\u02B2\u02B6\u02B8\u02BF\u02B8\u02BE\u02BD\u02B9 - num5) * 0.5f;
				}
				else if (this.\u02BE\u02B5\u02B2\u02B4\u02BA\u02BE\u02BE\u02B8\u02B3\u02B2\u02BC)
				{
					num7 += \u02BA\u02BE\u02B5\u02B2\u02B6\u02B8\u02BF\u02B8\u02BE\u02BD\u02B9 - num5;
				}
				if (this.\u02BC\u02BA\u02BF\u02BC\u02B3\u02BF\u02BD\u02BC\u02B2\u02B3\u02B3 && i > 0)
				{
					num += num3;
				}
				if (\u02B9\u02B9\u02BD\u02BE\u02B9\u02BC\u02C1\u02C1\u02BB\u02C1\u02C1 == 0)
				{
					base.SetChildAlongAxis(rectTransform, 0, num7, num5);
				}
				else
				{
					base.SetChildAlongAxis(rectTransform, 1, num, num6);
				}
				if (i < this.\u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE.Count - 1)
				{
					num += num6 + this.\u02C0\u02B7\u02BF\u02B5\u02BF\u02B6\u02B9\u02B9\u02BD\u02B8\u02B9;
				}
			}
		}

		public virtual void \u02B7\u02C0\u02BC\u02BA\u02B7\u02B9\u02B6\u02C0\u02BB\u02B5\u02B8()
		{
			if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Horizontal)
			{
				this.\u02BE\u02BE\u02B6\u02B4\u02B5\u02BA\u02BB\u02BF\u02BD\u02B8\u02B4 = this.\u02BD\u02BE\u02B8\u02BD\u02BD\u02B6\u02BC\u02B5\u02B8\u02B6\u02B3(1, true);
				return;
			}
			base.CalculateLayoutInputHorizontal();
			float num = this.\u02B6\u02B9\u02BE\u02BF\u02BC\u02B4\u02B2\u02BA\u02BF\u02B8\u02BB() + (float)base.padding.bottom + (float)base.padding.top;
			base.SetLayoutInputForAxis(num, 1197f, 1759f, 1);
		}

		protected bool \u02B8\u02B6\u02B4\u02BE\u02B5\u02BF\u02B4\u02B7\u02C0\u02B7\u02B4
		{
			get
			{
				return base.childAlignment == TextAnchor.LowerLeft || base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.LowerCenter;
			}
		}

		private float \u02B4\u02B9\u02B8\u02B3\u02B2\u02B7\u02B2\u02BD\u02B7\u02BE\u02BC(float \u02BE\u02B2\u02BE\u02B7\u02C0\u02B9\u02BF\u02B9\u02B9\u02B4\u02BC, float \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5, float \u02B8\u02B9\u02C0\u02B5\u02BD\u02BF\u02B8\u02B5\u02B4\u02B7\u02BE)
		{
			if (this.\u02BE\u02B5\u02B2\u02B4\u02BA\u02BE\u02BE\u02B8\u02B3\u02B2\u02BC)
			{
				return \u02BE\u02B2\u02BE\u02B7\u02C0\u02B9\u02BF\u02B9\u02B9\u02B4\u02BC - \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5 - \u02B8\u02B9\u02C0\u02B5\u02BD\u02BF\u02B8\u02B5\u02B4\u02B7\u02BE;
			}
			if (this.\u02B3\u02BA\u02BB\u02B6\u02B4\u02B4\u02B5\u02C1\u02B7\u02B9\u02B6)
			{
				return \u02BE\u02B2\u02BE\u02B7\u02C0\u02B9\u02BF\u02B9\u02B9\u02B4\u02BC * 0.5f - this.\u02BA\u02BF\u02BD\u02BC\u02B2\u02BB\u02B3\u02B8\u02BD\u02BE\u02BE * 0.5f + \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5;
			}
			return \u02B4\u02B5\u02BA\u02B8\u02BE\u02B6\u02C0\u02B4\u02BB\u02BF\u02B5;
		}

		public float \u02B6\u02B9\u02BE\u02BF\u02BC\u02B4\u02B2\u02BA\u02BF\u02B8\u02BB()
		{
			float num = 0f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				num = Mathf.Max(LayoutUtility.GetMinHeight(base.rectChildren[i]), num);
			}
			return num;
		}

		public override void CalculateLayoutInputHorizontal()
		{
			if (this.\u02B2\u02B5\u02B8\u02C1\u02BB\u02B2\u02BC\u02B7\u02B6\u02B4\u02C1 == FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3.Horizontal)
			{
				base.CalculateLayoutInputHorizontal();
				float num = this.\u02BA\u02B6\u02BC\u02C0\u02BE\u02B6\u02B2\u02BC\u02B6\u02BE\u02BE() + (float)base.padding.left + (float)base.padding.right;
				base.SetLayoutInputForAxis(num, -1f, -1f, 0);
				return;
			}
			this.\u02BA\u02BF\u02BD\u02BC\u02B2\u02BB\u02B3\u02B8\u02BD\u02BE\u02BE = this.\u02B8\u02B2\u02B3\u02C1\u02BC\u02BB\u02B8\u02B9\u02C0\u02BF\u02C1(0, true);
		}

		protected bool \u02B8\u02B8\u02B3\u02B6\u02BD\u02B6\u02B5\u02B9\u02BD\u02BF\u02B9()
		{
			return base.childAlignment == TextAnchor.UpperRight || base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.UpperLeft;
		}

		protected bool \u02BE\u02B5\u02B2\u02B4\u02BA\u02BE\u02BE\u02B8\u02B3\u02B2\u02BC
		{
			get
			{
				return base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.MiddleRight || base.childAlignment == TextAnchor.UpperRight;
			}
		}

		public override void SetLayoutHorizontal()
		{
			this.\u02B8\u02B2\u02B3\u02C1\u02BC\u02BB\u02B8\u02B9\u02C0\u02BF\u02C1(0, false);
		}

		public float \u02B5\u02BC\u02BC\u02B7\u02B8\u02C1\u02C0\u02B6\u02BB\u02C0\u02B9;

		public float \u02C0\u02B7\u02BF\u02B5\u02BF\u02B6\u02B9\u02B9\u02BD\u02B8\u02B9;

		public bool \u02BC\u02BA\u02BF\u02BC\u02B3\u02BF\u02BD\u02BC\u02B2\u02B3\u02B3;

		public bool \u02BA\u02B8\u02B8\u02BD\u02BC\u02B5\u02BD\u02B4\u02BF\u02BE\u02C1;

		public bool \u02C0\u02BF\u02B6\u02B6\u02B4\u02BD\u02B7\u02BA\u02C1\u02BB\u02B4;

		public bool \u02C1\u02B2\u02BA\u02B7\u02B4\u02B5\u02B9\u02B3\u02B6\u02B6\u02BB;

		public bool \u02B6\u02BA\u02BA\u02B4\u02B2\u02B8\u02BD\u02BB\u02C0\u02BE\u02C0;

		public float \u02C1\u02BD\u02B6\u02B4\u02B9\u02B9\u02B9\u02B7\u02BC\u02BD\u02B9;

		private float \u02BE\u02BE\u02B6\u02B4\u02B5\u02BA\u02BB\u02BF\u02BD\u02B8\u02B4;

		private float \u02BA\u02BF\u02BD\u02BC\u02B2\u02BB\u02B3\u02B8\u02BD\u02BE\u02BE;

		[SerializeField]
		protected FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3 m_StartAxis;

		private readonly IList<RectTransform> \u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE = new List<RectTransform>();

		public enum \u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3
		{
			Horizontal,
			Vertical
		}
	}
}
