using System;

namespace Rewired
{
	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate
	{
		public HOTASTemplate(object payload)
			: base(payload)
		{
		}

		public static readonly Guid typeGuid = new Guid("061a00cf-d8c2-4f8d-8cb5-a15a010bc53e");
	}
}
