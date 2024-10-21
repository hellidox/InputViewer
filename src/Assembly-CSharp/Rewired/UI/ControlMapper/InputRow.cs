using System;
using TMPro;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002B6 RID: 694
	[AddComponentMenu("")]
	public class InputRow : MonoBehaviour
	{
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x00016BE6 File Offset: 0x00014DE6
		// (set) Token: 0x06001E0B RID: 7691 RVA: 0x00016BEE File Offset: 0x00014DEE
		public ButtonInfo[] buttons { get; private set; }

		// Token: 0x06001E0C RID: 7692 RVA: 0x00016BF7 File Offset: 0x00014DF7
		public void Initialize(int rowIndex, string label, Action<int, ButtonInfo> inputFieldActivatedCallback)
		{
			this.rowIndex = rowIndex;
			this.label.text = label;
			this.inputFieldActivatedCallback = inputFieldActivatedCallback;
			this.buttons = base.transform.GetComponentsInChildren<ButtonInfo>(true);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00016C25 File Offset: 0x00014E25
		public void OnButtonActivated(ButtonInfo buttonInfo)
		{
			if (this.inputFieldActivatedCallback == null)
			{
				return;
			}
			this.inputFieldActivatedCallback(this.rowIndex, buttonInfo);
		}

		// Token: 0x04001496 RID: 5270
		public TMP_Text label;

		// Token: 0x04001498 RID: 5272
		private int rowIndex;

		// Token: 0x04001499 RID: 5273
		private Action<int, ButtonInfo> inputFieldActivatedCallback;
	}
}
