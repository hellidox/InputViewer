using System;

namespace Rewired
{
	// Token: 0x02000269 RID: 617
	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate
	{
		// Token: 0x060019BB RID: 6587 RVA: 0x0001370B File Offset: 0x0001190B
		public FlightYokeTemplate(object payload)
			: base(payload)
		{
		}

		// Token: 0x0400129D RID: 4765
		public static readonly Guid typeGuid = new Guid("f311fa16-0ccc-41c0-ac4b-50f7100bb8ff");
	}
}
