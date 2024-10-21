using System;

namespace Rewired
{
	// Token: 0x02000268 RID: 616
	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate
	{
		// Token: 0x060019B9 RID: 6585 RVA: 0x0001370B File Offset: 0x0001190B
		public HOTASTemplate(object payload)
			: base(payload)
		{
		}

		// Token: 0x0400129C RID: 4764
		public static readonly Guid typeGuid = new Guid("061a00cf-d8c2-4f8d-8cb5-a15a010bc53e");
	}
}
