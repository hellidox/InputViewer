using System;

namespace Rewired
{
	// Token: 0x0200026B RID: 619
	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate, IControllerTemplate
	{
		// Token: 0x060019BF RID: 6591 RVA: 0x0001370B File Offset: 0x0001190B
		public SixDofControllerTemplate(object payload)
			: base(payload)
		{
		}

		// Token: 0x0400129F RID: 4767
		public static readonly Guid typeGuid = new Guid("2599beb3-522b-43dd-a4ef-93fd60e5eafa");
	}
}
