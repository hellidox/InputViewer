using System;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002BD RID: 701
	[AddComponentMenu("")]
	public class ThemedElement : MonoBehaviour
	{
		// Token: 0x06001EA3 RID: 7843 RVA: 0x000171D6 File Offset: 0x000153D6
		private void Start()
		{
			ControlMapper.ApplyTheme(this._elements);
		}

		// Token: 0x040014DE RID: 5342
		[SerializeField]
		private ThemedElement.ElementInfo[] _elements;

		// Token: 0x020002BE RID: 702
		[Serializable]
		public class ElementInfo
		{
			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x000171E3 File Offset: 0x000153E3
			public string themeClass
			{
				get
				{
					return this._themeClass;
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x000171EB File Offset: 0x000153EB
			public Component component
			{
				get
				{
					return this._component;
				}
			}

			// Token: 0x040014DF RID: 5343
			[SerializeField]
			private string _themeClass;

			// Token: 0x040014E0 RID: 5344
			[SerializeField]
			private Component _component;
		}
	}
}
