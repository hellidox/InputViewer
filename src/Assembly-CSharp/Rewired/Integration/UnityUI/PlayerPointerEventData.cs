using System;
using System.Text;
using Rewired.UI;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x02000278 RID: 632
	public class PlayerPointerEventData : PointerEventData
	{
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x00013D47 File Offset: 0x00011F47
		// (set) Token: 0x06001A51 RID: 6737 RVA: 0x00013D4F File Offset: 0x00011F4F
		public int playerId { get; set; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x00013D58 File Offset: 0x00011F58
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x00013D60 File Offset: 0x00011F60
		public int inputSourceIndex { get; set; }

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x00013D69 File Offset: 0x00011F69
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x00013D71 File Offset: 0x00011F71
		public IMouseInputSource mouseSource { get; set; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00013D7A File Offset: 0x00011F7A
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x00013D82 File Offset: 0x00011F82
		public ITouchInputSource touchSource { get; set; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x00013D8B File Offset: 0x00011F8B
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x00013D93 File Offset: 0x00011F93
		public PointerEventType sourceType { get; set; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x00013D9C File Offset: 0x00011F9C
		// (set) Token: 0x06001A5B RID: 6747 RVA: 0x00013DA4 File Offset: 0x00011FA4
		public int buttonIndex { get; set; }

		// Token: 0x06001A5C RID: 6748 RVA: 0x00013DAD File Offset: 0x00011FAD
		public PlayerPointerEventData(EventSystem eventSystem)
			: base(eventSystem)
		{
			this.playerId = -1;
			this.inputSourceIndex = -1;
			this.buttonIndex = -1;
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x000C8468 File Offset: 0x000C6668
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<b>Player Id</b>: " + this.playerId.ToString());
			string text = "<b>Mouse Source</b>: ";
			IMouseInputSource mouseSource = this.mouseSource;
			stringBuilder.AppendLine(text + ((mouseSource != null) ? mouseSource.ToString() : null));
			stringBuilder.AppendLine("<b>Input Source Index</b>: " + this.inputSourceIndex.ToString());
			string text2 = "<b>Touch Source/b>: ";
			ITouchInputSource touchSource = this.touchSource;
			stringBuilder.AppendLine(text2 + ((touchSource != null) ? touchSource.ToString() : null));
			stringBuilder.AppendLine("<b>Source Type</b>: " + this.sourceType.ToString());
			stringBuilder.AppendLine("<b>Button Index</b>: " + this.buttonIndex.ToString());
			stringBuilder.Append(base.ToString());
			return stringBuilder.ToString();
		}
	}
}
