using System;

namespace Rewired
{
	// Token: 0x02000267 RID: 615
	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate
	{
		// Token: 0x060019B7 RID: 6583 RVA: 0x0001370B File Offset: 0x0001190B
		public RacingWheelTemplate(object payload)
			: base(payload)
		{
		}

		// Token: 0x0400129B RID: 4763
		public static readonly Guid typeGuid = new Guid("104e31d8-9115-4dd5-a398-2e54d35e6c83");
	}
}
