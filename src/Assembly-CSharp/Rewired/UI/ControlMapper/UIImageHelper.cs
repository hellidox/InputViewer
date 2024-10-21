using System;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020002D0 RID: 720
	[RequireComponent(typeof(Image))]
	[AddComponentMenu("")]
	public class UIImageHelper : MonoBehaviour
	{
		// Token: 0x06001EEB RID: 7915 RVA: 0x000D4AC0 File Offset: 0x000D2CC0
		public void SetEnabledState(bool newState)
		{
			this.currentState = newState;
			UIImageHelper.State state = (newState ? this.enabledState : this.disabledState);
			if (state == null)
			{
				return;
			}
			Image component = base.gameObject.GetComponent<Image>();
			if (component == null)
			{
				Debug.LogError("Image is missing!");
				return;
			}
			state.Set(component);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x000174D7 File Offset: 0x000156D7
		public void SetEnabledStateColor(Color color)
		{
			this.enabledState.color = color;
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x000174E5 File Offset: 0x000156E5
		public void SetDisabledStateColor(Color color)
		{
			this.disabledState.color = color;
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x000D4B14 File Offset: 0x000D2D14
		public void Refresh()
		{
			UIImageHelper.State state = (this.currentState ? this.enabledState : this.disabledState);
			Image component = base.gameObject.GetComponent<Image>();
			if (component == null)
			{
				return;
			}
			state.Set(component);
		}

		// Token: 0x04001537 RID: 5431
		[SerializeField]
		private UIImageHelper.State enabledState;

		// Token: 0x04001538 RID: 5432
		[SerializeField]
		private UIImageHelper.State disabledState;

		// Token: 0x04001539 RID: 5433
		private bool currentState;

		// Token: 0x020002D1 RID: 721
		[Serializable]
		private class State
		{
			// Token: 0x06001EF0 RID: 7920 RVA: 0x000174F3 File Offset: 0x000156F3
			public void Set(Image image)
			{
				if (image == null)
				{
					return;
				}
				image.color = this.color;
			}

			// Token: 0x0400153A RID: 5434
			[SerializeField]
			public Color color;
		}
	}
}
