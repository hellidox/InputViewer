using System;

namespace Rewired
{
	// Token: 0x0200026A RID: 618
	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate
	{
		// Token: 0x060019BD RID: 6589 RVA: 0x0001370B File Offset: 0x0001190B
		public FlightPedalsTemplate(object payload)
			: base(payload)
		{
		}

		// Token: 0x0400129E RID: 4766
		public static readonly Guid typeGuid = new Guid("f6fe76f8-be2a-4db2-b853-9e3652075913");
	}
}
