using System;

namespace Rewired
{
	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate
	{
		public FlightYokeTemplate(object payload)
			: base(payload)
		{
		}

		public static readonly Guid typeGuid = new Guid("f311fa16-0ccc-41c0-ac4b-50f7100bb8ff");
	}
}
