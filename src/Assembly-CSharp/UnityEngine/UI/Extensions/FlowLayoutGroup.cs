using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000245 RID: 581
	[AddComponentMenu("Layout/Extensions/Flow Layout Group")]
	public class FlowLayoutGroup : LayoutGroup
	{
		// Token: 0x06001939 RID: 6457 RVA: 0x000131B7 File Offset: 0x000113B7
		public override void SetLayoutVertical()
		{
			this.\u02B8\u02B2\u02B3\u02C1\u02BC\u02BB\u02B8\u02B9\u02C0\u02BF\u02C1(1, false);
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x000C48F0 File Offset: 0x000C2AF0
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

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x000131D5 File Offset: 0x000113D5
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x00013256 File Offset: 0x00011456
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

		// Token: 0x0600193D RID: 6461 RVA: 0x000131DD File Offset: 0x000113DD
		public virtual void \u02B3\u02BE\u02B5\u02B5\u02BD\u02B5\u02BF\u02BB\u02B4\u02B9\u02B2()
		{
			this.\u02B8\u02B2\u02B3\u02C1\u02BC\u02BB\u02B8\u02B9\u02C0\u02BF\u02C1(0, true);
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x000131E8 File Offset: 0x000113E8
		protected bool \u02B3\u02BA\u02BB\u02B6\u02B4\u02B4\u02B5\u02C1\u02B7\u02B9\u02B6
		{
			get
			{
				return base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.MiddleCenter || base.childAlignment == TextAnchor.UpperCenter;
			}
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00013207 File Offset: 0x00011407
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

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x00013237 File Offset: 0x00011437
		protected bool \u02B5\u02BC\u02C0\u02B5\u02C1\u02BA\u02B7\u02C0\u02B2\u02B4\u02BF
		{
			get
			{
				return base.childAlignment == TextAnchor.MiddleLeft || base.childAlignment == TextAnchor.MiddleRight || base.childAlignment == TextAnchor.MiddleCenter;
			}
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x000C4950 File Offset: 0x000C2B50
		public float \u02B6\u02C0\u02B3\u02B6\u02B2\u02C0\u02BB\u02B7\u02BE\u02C1\u02C1()
		{
			float num = 1751f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				num = Mathf.Max(LayoutUtility.GetMinWidth(base.rectChildren[i]), num);
			}
			return num;
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x000C4994 File Offset: 0x000C2B94
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

		// Token: 0x06001944 RID: 6468 RVA: 0x000C4E68 File Offset: 0x000C3068
		public float \u02BD\u02C0\u02C1\u02BB\u02B4\u02B2\u02B9\u02B9\u02B3\u02B4\u02B2()
		{
			float num = 1248f;
			for (int i = 1; i < base.rectChildren.Count; i++)
			{
				num = Mathf.Max(LayoutUtility.GetMinWidth(base.rectChildren[i]), num);
			}
			return num;
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00013256 File Offset: 0x00011456
		public void \u02B3\u02B6\u02B4\u02B3\u02B7\u02BC\u02BA\u02BF\u02B8\u02BD\u02BA(FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
		{
			base.SetProperty<FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3>(ref this.m_StartAxis, \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x000C4EAC File Offset: 0x000C30AC
		public float \u02BA\u02B6\u02BC\u02C0\u02BE\u02B6\u02B2\u02BC\u02B6\u02BE\u02BE()
		{
			float num = 0f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				num = Mathf.Max(LayoutUtility.GetMinWidth(base.rectChildren[i]), num);
			}
			return num;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000C4EF0 File Offset: 0x000C30F0
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

		// Token: 0x06001948 RID: 6472 RVA: 0x00013265 File Offset: 0x00011465
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

		// Token: 0x06001949 RID: 6473 RVA: 0x00013295 File Offset: 0x00011495
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

		// Token: 0x0600194A RID: 6474 RVA: 0x000132C5 File Offset: 0x000114C5
		public virtual void \u02B7\u02BF\u02B8\u02B7\u02BB\u02B6\u02C1\u02B2\u02B7\u02B8\u02C0()
		{
			this.\u02B8\u02B2\u02B3\u02C1\u02BC\u02BB\u02B8\u02B9\u02C0\u02BF\u02C1(0, false);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00013256 File Offset: 0x00011456
		public void \u02C0\u02BF\u02BC\u02B2\u02B4\u02C1\u02B6\u02BA\u02B6\u02BB\u02B7(FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
		{
			base.SetProperty<FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3>(ref this.m_StartAxis, \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000C53C4 File Offset: 0x000C35C4
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

		// Token: 0x0600194D RID: 6477 RVA: 0x000132D0 File Offset: 0x000114D0
		protected bool \u02B5\u02B6\u02B8\u02B6\u02B5\u02BA\u02B3\u02B6\u02B3\u02B6\u02B5()
		{
			return base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.LowerRight;
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x000C5588 File Offset: 0x000C3788
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

		// Token: 0x0600194F RID: 6479 RVA: 0x000C574C File Offset: 0x000C394C
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

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x000132EF File Offset: 0x000114EF
		protected bool \u02B8\u02B6\u02B4\u02BE\u02B5\u02BF\u02B4\u02B7\u02C0\u02B7\u02B4
		{
			get
			{
				return base.childAlignment == TextAnchor.LowerLeft || base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.LowerCenter;
			}
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0001330E File Offset: 0x0001150E
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

		// Token: 0x06001952 RID: 6482 RVA: 0x000C57AC File Offset: 0x000C39AC
		public float \u02B6\u02B9\u02BE\u02BF\u02BC\u02B4\u02B2\u02BA\u02BF\u02B8\u02BB()
		{
			float num = 0f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				num = Mathf.Max(LayoutUtility.GetMinHeight(base.rectChildren[i]), num);
			}
			return num;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x000C57F0 File Offset: 0x000C39F0
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

		// Token: 0x06001954 RID: 6484 RVA: 0x0001333E File Offset: 0x0001153E
		protected bool \u02B8\u02B8\u02B3\u02B6\u02BD\u02B6\u02B5\u02B9\u02BD\u02BF\u02B9()
		{
			return base.childAlignment == TextAnchor.UpperRight || base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x0001335D File Offset: 0x0001155D
		protected bool \u02BE\u02B5\u02B2\u02B4\u02BA\u02BE\u02BE\u02B8\u02B3\u02B2\u02BC
		{
			get
			{
				return base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.MiddleRight || base.childAlignment == TextAnchor.UpperRight;
			}
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x000132C5 File Offset: 0x000114C5
		public override void SetLayoutHorizontal()
		{
			this.\u02B8\u02B2\u02B3\u02C1\u02BC\u02BB\u02B8\u02B9\u02C0\u02BF\u02C1(0, false);
		}

		// Token: 0x04001206 RID: 4614
		public float \u02B5\u02BC\u02BC\u02B7\u02B8\u02C1\u02C0\u02B6\u02BB\u02C0\u02B9;

		// Token: 0x04001207 RID: 4615
		public float \u02C0\u02B7\u02BF\u02B5\u02BF\u02B6\u02B9\u02B9\u02BD\u02B8\u02B9;

		// Token: 0x04001208 RID: 4616
		public bool \u02BC\u02BA\u02BF\u02BC\u02B3\u02BF\u02BD\u02BC\u02B2\u02B3\u02B3;

		// Token: 0x04001209 RID: 4617
		public bool \u02BA\u02B8\u02B8\u02BD\u02BC\u02B5\u02BD\u02B4\u02BF\u02BE\u02C1;

		// Token: 0x0400120A RID: 4618
		public bool \u02C0\u02BF\u02B6\u02B6\u02B4\u02BD\u02B7\u02BA\u02C1\u02BB\u02B4;

		// Token: 0x0400120B RID: 4619
		public bool \u02C1\u02B2\u02BA\u02B7\u02B4\u02B5\u02B9\u02B3\u02B6\u02B6\u02BB;

		// Token: 0x0400120C RID: 4620
		public bool \u02B6\u02BA\u02BA\u02B4\u02B2\u02B8\u02BD\u02BB\u02C0\u02BE\u02C0;

		// Token: 0x0400120D RID: 4621
		public float \u02C1\u02BD\u02B6\u02B4\u02B9\u02B9\u02B9\u02B7\u02BC\u02BD\u02B9;

		// Token: 0x0400120E RID: 4622
		private float \u02BE\u02BE\u02B6\u02B4\u02B5\u02BA\u02BB\u02BF\u02BD\u02B8\u02B4;

		// Token: 0x0400120F RID: 4623
		private float \u02BA\u02BF\u02BD\u02BC\u02B2\u02BB\u02B3\u02B8\u02BD\u02BE\u02BE;

		// Token: 0x04001210 RID: 4624
		[SerializeField]
		protected FlowLayoutGroup.\u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3 m_StartAxis;

		// Token: 0x04001211 RID: 4625
		private readonly IList<RectTransform> \u02BB\u02C1\u02B7\u02B3\u02B8\u02BD\u02B2\u02B5\u02BA\u02C1\u02BE = new List<RectTransform>();

		// Token: 0x02000246 RID: 582
		public enum \u02B7\u02B6\u02C1\u02B3\u02B8\u02B3\u02BA\u02B9\u02B5\u02C1\u02B3
		{
			// Token: 0x04001213 RID: 4627
			Horizontal,
			// Token: 0x04001214 RID: 4628
			Vertical
		}
	}
}
