using System;

namespace Rewired
{
	// Token: 0x02000266 RID: 614
	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
	{
		// Token: 0x060019B5 RID: 6581 RVA: 0x0001370B File Offset: 0x0001190B
		public GamepadTemplate(object payload)
			: base(payload)
		{
		}

		// Token: 0x0400129A RID: 4762
		public static readonly Guid typeGuid = new Guid("83b427e4-086f-47f3-bb06-be266abd1ca5");
	}
}
