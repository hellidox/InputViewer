using System;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002B5 RID: 693
	[AddComponentMenu("")]
	public class InputFieldInfo : UIElementInfo
	{
		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x00016B91 File Offset: 0x00014D91
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x00016B99 File Offset: 0x00014D99
		public int actionId { get; set; }

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x00016BA2 File Offset: 0x00014DA2
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x00016BAA File Offset: 0x00014DAA
		public AxisRange axisRange { get; set; }

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x00016BB3 File Offset: 0x00014DB3
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x00016BBB File Offset: 0x00014DBB
		public int actionElementMapId { get; set; }

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x00016BC4 File Offset: 0x00014DC4
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x00016BCC File Offset: 0x00014DCC
		public ControllerType controllerType { get; set; }

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x00016BD5 File Offset: 0x00014DD5
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x00016BDD File Offset: 0x00014DDD
		public int controllerId { get; set; }
	}
}
