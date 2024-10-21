using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002CE RID: 718
	[AddComponentMenu("")]
	public abstract class UIElementInfo : MonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06001EE2 RID: 7906 RVA: 0x000D4A50 File Offset: 0x000D2C50
		// (remove) Token: 0x06001EE3 RID: 7907 RVA: 0x000D4A88 File Offset: 0x000D2C88
		public event Action<GameObject> OnSelectedEvent;

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00017454 File Offset: 0x00015654
		public void OnSelect(BaseEventData eventData)
		{
			if (this.OnSelectedEvent != null)
			{
				this.OnSelectedEvent(base.gameObject);
			}
		}

		// Token: 0x04001531 RID: 5425
		public string identifier;

		// Token: 0x04001532 RID: 5426
		public int intData;

		// Token: 0x04001533 RID: 5427
		public TMP_Text text;
	}
}
