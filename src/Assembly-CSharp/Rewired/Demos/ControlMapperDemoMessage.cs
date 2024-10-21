using System;
using System.Collections;
using Rewired.UI.ControlMapper;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.Demos
{
	// Token: 0x020002D9 RID: 729
	[AddComponentMenu("")]
	public class ControlMapperDemoMessage : MonoBehaviour
	{
		// Token: 0x06001F3B RID: 7995 RVA: 0x000178E6 File Offset: 0x00015AE6
		private void Awake()
		{
			if (this.controlMapper != null)
			{
				this.controlMapper.ScreenClosedEvent += this.OnControlMapperClosed;
				this.controlMapper.ScreenOpenedEvent += this.OnControlMapperOpened;
			}
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00017924 File Offset: 0x00015B24
		private void Start()
		{
			this.SelectDefault();
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x0001792C File Offset: 0x00015B2C
		private void OnControlMapperClosed()
		{
			base.gameObject.SetActive(true);
			base.StartCoroutine(this.SelectDefaultDeferred());
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x00008D44 File Offset: 0x00006F44
		private void OnControlMapperOpened()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x00017947 File Offset: 0x00015B47
		private void SelectDefault()
		{
			if (EventSystem.current == null)
			{
				return;
			}
			if (this.defaultSelectable != null)
			{
				EventSystem.current.SetSelectedGameObject(this.defaultSelectable.gameObject);
			}
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x0001797A File Offset: 0x00015B7A
		private IEnumerator SelectDefaultDeferred()
		{
			yield return null;
			this.SelectDefault();
			yield break;
		}

		// Token: 0x04001554 RID: 5460
		public ControlMapper controlMapper;

		// Token: 0x04001555 RID: 5461
		public Selectable defaultSelectable;
	}
}
