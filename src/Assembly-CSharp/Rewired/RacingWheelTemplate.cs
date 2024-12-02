using System;

namespace Rewired
{
	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate
	{
		public RacingWheelTemplate(object payload)
			: base(payload)
		{
		}

		public static readonly Guid typeGuid = new Guid("104e31d8-9115-4dd5-a398-2e54d35e6c83");
	}
}
