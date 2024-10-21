using System;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000286 RID: 646
	[RequireComponent(typeof(CanvasScalerExt))]
	public class CanvasScalerFitter : MonoBehaviour
	{
		// Token: 0x06001B1E RID: 6942 RVA: 0x00014778 File Offset: 0x00012978
		private void OnEnable()
		{
			this.canvasScaler = base.GetComponent<CanvasScalerExt>();
			this.Update();
			this.canvasScaler.ForceRefresh();
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00014797 File Offset: 0x00012997
		private void Update()
		{
			if (Screen.width != this.screenWidth || Screen.height != this.screenHeight)
			{
				this.screenWidth = Screen.width;
				this.screenHeight = Screen.height;
				this.UpdateSize();
			}
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x000CB19C File Offset: 0x000C939C
		private void UpdateSize()
		{
			if (this.canvasScaler.uiScaleMode != CanvasScaler.ScaleMode.ScaleWithScreenSize)
			{
				return;
			}
			if (this.breakPoints == null)
			{
				return;
			}
			float num = (float)Screen.width / (float)Screen.height;
			float num2 = float.PositiveInfinity;
			int num3 = 0;
			for (int i = 0; i < this.breakPoints.Length; i++)
			{
				float num4 = Mathf.Abs(num - this.breakPoints[i].screenAspectRatio);
				if ((num4 <= this.breakPoints[i].screenAspectRatio || MathTools.IsNear(this.breakPoints[i].screenAspectRatio, 0.01f)) && num4 < num2)
				{
					num2 = num4;
					num3 = i;
				}
			}
			this.canvasScaler.referenceResolution = this.breakPoints[num3].referenceResolution;
		}

		// Token: 0x04001336 RID: 4918
		[SerializeField]
		private CanvasScalerFitter.BreakPoint[] breakPoints;

		// Token: 0x04001337 RID: 4919
		private CanvasScalerExt canvasScaler;

		// Token: 0x04001338 RID: 4920
		private int screenWidth;

		// Token: 0x04001339 RID: 4921
		private int screenHeight;

		// Token: 0x0400133A RID: 4922
		private Action ScreenSizeChanged;

		// Token: 0x02000287 RID: 647
		[Serializable]
		private class BreakPoint
		{
			// Token: 0x0400133B RID: 4923
			[SerializeField]
			public string name;

			// Token: 0x0400133C RID: 4924
			[SerializeField]
			public float screenAspectRatio;

			// Token: 0x0400133D RID: 4925
			[SerializeField]
			public Vector2 referenceResolution;
		}
	}
}
