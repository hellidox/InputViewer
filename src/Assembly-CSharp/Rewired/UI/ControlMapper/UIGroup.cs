using System;
using TMPro;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002CF RID: 719
	[AddComponentMenu("")]
	public class UIGroup : MonoBehaviour
	{
		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x0001746F File Offset: 0x0001566F
		// (set) Token: 0x06001EE7 RID: 7911 RVA: 0x00017490 File Offset: 0x00015690
		public string labelText
		{
			get
			{
				if (!(this._label != null))
				{
					return string.Empty;
				}
				return this._label.text;
			}
			set
			{
				if (this._label == null)
				{
					return;
				}
				this._label.text = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x000174AD File Offset: 0x000156AD
		public Transform content
		{
			get
			{
				return this._content;
			}
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000174B5 File Offset: 0x000156B5
		public void SetLabelActive(bool state)
		{
			if (this._label == null)
			{
				return;
			}
			this._label.gameObject.SetActive(state);
		}

		// Token: 0x04001535 RID: 5429
		[SerializeField]
		private TMP_Text _label;

		// Token: 0x04001536 RID: 5430
		[SerializeField]
		private Transform _content;
	}
}
