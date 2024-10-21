using System;
using TMPro;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002CB RID: 715
	[AddComponentMenu("")]
	public class UIControl : MonoBehaviour
	{
		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x0001739B File Offset: 0x0001559B
		public int id
		{
			get
			{
				return this._id;
			}
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x000173A3 File Offset: 0x000155A3
		private void Awake()
		{
			this._id = UIControl.GetNextUid();
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x000173B0 File Offset: 0x000155B0
		// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x000173B8 File Offset: 0x000155B8
		public bool showTitle
		{
			get
			{
				return this._showTitle;
			}
			set
			{
				if (this.title == null)
				{
					return;
				}
				this.title.gameObject.SetActive(value);
				this._showTitle = value;
			}
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00005F91 File Offset: 0x00004191
		public virtual void SetCancelCallback(Action cancelCallback)
		{
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x000173E1 File Offset: 0x000155E1
		private static int GetNextUid()
		{
			if (UIControl._uidCounter == 2147483647)
			{
				UIControl._uidCounter = 0;
			}
			int uidCounter = UIControl._uidCounter;
			UIControl._uidCounter++;
			return uidCounter;
		}

		// Token: 0x04001528 RID: 5416
		public TMP_Text title;

		// Token: 0x04001529 RID: 5417
		private int _id;

		// Token: 0x0400152A RID: 5418
		private bool _showTitle;

		// Token: 0x0400152B RID: 5419
		private static int _uidCounter;
	}
}
