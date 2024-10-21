using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002AF RID: 687
	public interface ICustomSelectable : ICancelHandler, IEventSystemHandler
	{
		// Token: 0x1700038D RID: 909
		// (set) Token: 0x06001DE0 RID: 7648
		Sprite disabledHighlightedSprite { set; }

		// Token: 0x1700038E RID: 910
		// (set) Token: 0x06001DE1 RID: 7649
		Color disabledHighlightedColor { set; }

		// Token: 0x1700038F RID: 911
		// (set) Token: 0x06001DE2 RID: 7650
		string disabledHighlightedTrigger { set; }

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06001DE3 RID: 7651
		// (remove) Token: 0x06001DE4 RID: 7652
		event UnityAction CancelEvent;
	}
}
