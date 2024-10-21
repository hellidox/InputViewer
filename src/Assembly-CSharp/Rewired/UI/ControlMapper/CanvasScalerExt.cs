using System;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000285 RID: 645
	[AddComponentMenu("")]
	public class CanvasScalerExt : CanvasScaler
	{
		// Token: 0x06001B1C RID: 6940 RVA: 0x00014768 File Offset: 0x00012968
		public void ForceRefresh()
		{
			this.Handle();
		}
	}
}
