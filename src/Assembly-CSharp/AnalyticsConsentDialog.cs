using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020001D4 RID: 468
public class AnalyticsConsentDialog : MonoBehaviour
{
	// Token: 0x060014AA RID: 5290 RVA: 0x00010D6A File Offset: 0x0000EF6A
	private void OnEnable()
	{
		if (\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B5\u02BC\u02B4\u02B3\u02C0\u02C1\u02BB\u02BE\u02B2\u02BF)
		{
			this.denyButton.interactable = false;
			this.acceptButton.interactable = false;
		}
	}

	// Token: 0x060014AB RID: 5291 RVA: 0x00010D8B File Offset: 0x0000EF8B
	public void \u02C0\u02C0\u02C1\u02B2\u02B4\u02BC\u02B5\u02BA\u02B5\u02B6\u02BD()
	{
		Application.OpenURL(\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B5\u02B4\u02B9\u02B3\u02BB\u02C0\u02B9\u02B5\u02BF\u02BC\u02BA());
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x00010D97 File Offset: 0x0000EF97
	public void \u02BB\u02C0\u02B6\u02BF\u02B3\u02B2\u02B4\u02B2\u02B6\u02C1\u02B4()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BE\u02BF\u02B4\u02B3\u02B5\u02B8\u02BA\u02BC\u02B2\u02B7\u02C0();
	}

	// Token: 0x060014AD RID: 5293 RVA: 0x00010D9E File Offset: 0x0000EF9E
	public void \u02B4\u02B6\u02BA\u02B5\u02C0\u02B2\u02BA\u02BC\u02C0\u02B7\u02BB()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B4\u02B6\u02C1\u02BC\u02BF\u02BE\u02BD\u02BD\u02B7\u02C0();
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x00010D8B File Offset: 0x0000EF8B
	public void \u02BF\u02BB\u02BE\u02B8\u02B2\u02BF\u02B3\u02BF\u02B5\u02B8\u02B3()
	{
		Application.OpenURL(\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B5\u02B4\u02B9\u02B3\u02BB\u02C0\u02B9\u02B5\u02BF\u02BC\u02BA());
	}

	// Token: 0x060014AF RID: 5295 RVA: 0x000A2634 File Offset: 0x000A0834
	private void Start()
	{
		AnalyticsConsentDialog.\u02BA\u02B6\u02BE\u02B9\u02BD\u02BC\u02BF\u02B3\u02B8\u02BC\u02B6 u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B = new AnalyticsConsentDialog.\u02BA\u02B6\u02BE\u02B9\u02BD\u02BC\u02BF\u02B3\u02B8\u02BC\u02B6();
		u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.<>4__this = this;
		this.privacyButton.onClick.AddListener(new UnityAction(this.\u02BF\u02BB\u02BE\u02B8\u02B2\u02BF\u02B3\u02BF\u02B5\u02B8\u02B3));
		this.denyButton.onClick.AddListener(new UnityAction(this.\u02B3\u02C1\u02B3\u02B9\u02BE\u02B9\u02BA\u02BA\u02C1\u02B9\u02B2));
		this.acceptButton.onClick.AddListener(new UnityAction(this.\u02B7\u02B3\u02B5\u02BD\u02B3\u02BA\u02B6\u02C1\u02BB\u02B6\u02BF));
		EventTrigger eventTrigger = this.privacyButton.gameObject.AddComponent<EventTrigger>();
		EventTrigger eventTrigger2 = this.denyButton.gameObject.AddComponent<EventTrigger>();
		EventTrigger eventTrigger3 = this.acceptButton.gameObject.AddComponent<EventTrigger>();
		u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.textPrivacy = this.privacyButton.GetComponentInChildren<TextMeshProUGUI>();
		u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.textDeny = this.denyButton.GetComponentInChildren<TextMeshProUGUI>();
		u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.textAccept = this.acceptButton.GetComponentInChildren<TextMeshProUGUI>();
		eventTrigger.triggers.Add(this.\u02B5\u02BD\u02BC\u02B5\u02B9\u02B4\u02C0\u02B4\u02BC\u02BB\u02B2(EventTriggerType.PointerEnter, new UnityAction<BaseEventData>(u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.\u02BC\u02BE\u02BA\u02B7\u02B5\u02B9\u02B7\u02BA\u02B2\u02BA\u02B7)));
		eventTrigger2.triggers.Add(this.\u02B5\u02BD\u02BC\u02B5\u02B9\u02B4\u02C0\u02B4\u02BC\u02BB\u02B2(EventTriggerType.PointerEnter, new UnityAction<BaseEventData>(u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.\u02B6\u02C1\u02BA\u02BA\u02B3\u02B8\u02B9\u02BB\u02BF\u02BE\u02B2)));
		eventTrigger3.triggers.Add(this.\u02B5\u02BD\u02BC\u02B5\u02B9\u02B4\u02C0\u02B4\u02BC\u02BB\u02B2(EventTriggerType.PointerEnter, new UnityAction<BaseEventData>(u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.\u02B9\u02B8\u02B2\u02BF\u02B8\u02BE\u02B5\u02B7\u02C1\u02B4\u02B8)));
		eventTrigger.triggers.Add(this.\u02B5\u02BD\u02BC\u02B5\u02B9\u02B4\u02C0\u02B4\u02BC\u02BB\u02B2(EventTriggerType.PointerExit, new UnityAction<BaseEventData>(u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.\u02BA\u02BE\u02BA\u02B5\u02BC\u02B2\u02B6\u02C1\u02BA\u02B6\u02B8)));
		eventTrigger2.triggers.Add(this.\u02B5\u02BD\u02BC\u02B5\u02B9\u02B4\u02C0\u02B4\u02BC\u02BB\u02B2(EventTriggerType.PointerExit, new UnityAction<BaseEventData>(u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.\u02BA\u02BD\u02BA\u02B7\u02BB\u02B7\u02B3\u02B9\u02C1\u02B4\u02B2)));
		eventTrigger3.triggers.Add(this.\u02B5\u02BD\u02BC\u02B5\u02B9\u02B4\u02C0\u02B4\u02BC\u02BB\u02B2(EventTriggerType.PointerExit, new UnityAction<BaseEventData>(u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.\u02B2\u02B7\u02BE\u02B6\u02BA\u02B9\u02B2\u02BF\u02B4\u02C1\u02BA)));
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x00010D9E File Offset: 0x0000EF9E
	public void \u02B7\u02B3\u02B5\u02BD\u02B3\u02BA\u02B6\u02C1\u02BB\u02B6\u02BF()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B4\u02B6\u02C1\u02BC\u02BF\u02BE\u02BD\u02BD\u02B7\u02C0();
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x00010D9E File Offset: 0x0000EF9E
	public void \u02B6\u02B9\u02BD\u02BA\u02B5\u02B9\u02BA\u02B9\u02C0\u02C0\u02BC()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B4\u02B6\u02C1\u02BC\u02BF\u02BE\u02BD\u02BD\u02B7\u02C0();
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x00010D97 File Offset: 0x0000EF97
	public void \u02B7\u02B8\u02BB\u02BD\u02C0\u02C1\u02B8\u02BC\u02BD\u02B4\u02B2()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BE\u02BF\u02B4\u02B3\u02B5\u02B8\u02BA\u02BC\u02B2\u02B7\u02C0();
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x00010D97 File Offset: 0x0000EF97
	public void \u02B3\u02C1\u02B3\u02B9\u02BE\u02B9\u02BA\u02BA\u02C1\u02B9\u02B2()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BE\u02BF\u02B4\u02B3\u02B5\u02B8\u02BA\u02BC\u02B2\u02B7\u02C0();
	}

	// Token: 0x060014B4 RID: 5300 RVA: 0x000A27BC File Offset: 0x000A09BC
	private void \u02B5\u02B2\u02BF\u02BD\u02BB\u02BA\u02B2\u02BF\u02BD\u02BE\u02BE()
	{
		AnalyticsConsentDialog.\u02BA\u02B6\u02BE\u02B9\u02BD\u02BC\u02BF\u02B3\u02B8\u02BC\u02B6 u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B = new AnalyticsConsentDialog.\u02BA\u02B6\u02BE\u02B9\u02BD\u02BC\u02BF\u02B3\u02B8\u02BC\u02B6();
		u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.<>4__this = this;
		this.privacyButton.onClick.AddListener(new UnityAction(this.\u02BF\u02BB\u02BE\u02B8\u02B2\u02BF\u02B3\u02BF\u02B5\u02B8\u02B3));
		this.denyButton.onClick.AddListener(new UnityAction(this.\u02B3\u02C1\u02B3\u02B9\u02BE\u02B9\u02BA\u02BA\u02C1\u02B9\u02B2));
		this.acceptButton.onClick.AddListener(new UnityAction(this.\u02B4\u02BC\u02B7\u02BD\u02B6\u02C0\u02BC\u02B7\u02B8\u02BE\u02B4));
		EventTrigger eventTrigger = this.privacyButton.gameObject.AddComponent<EventTrigger>();
		EventTrigger eventTrigger2 = this.denyButton.gameObject.AddComponent<EventTrigger>();
		EventTrigger eventTrigger3 = this.acceptButton.gameObject.AddComponent<EventTrigger>();
		u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.textPrivacy = this.privacyButton.GetComponentInChildren<TextMeshProUGUI>();
		u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.textDeny = this.denyButton.GetComponentInChildren<TextMeshProUGUI>();
		u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.textAccept = this.acceptButton.GetComponentInChildren<TextMeshProUGUI>();
		eventTrigger.triggers.Add(this.\u02B5\u02BD\u02BC\u02B5\u02B9\u02B4\u02C0\u02B4\u02BC\u02BB\u02B2(EventTriggerType.PointerExit, new UnityAction<BaseEventData>(u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.\u02BC\u02BE\u02BA\u02B7\u02B5\u02B9\u02B7\u02BA\u02B2\u02BA\u02B7)));
		eventTrigger2.triggers.Add(this.\u02B7\u02BF\u02BA\u02BE\u02BE\u02B5\u02BE\u02BB\u02BA\u02B3\u02C1(EventTriggerType.PointerExit, new UnityAction<BaseEventData>(u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.\u02B6\u02C1\u02BA\u02BA\u02B3\u02B8\u02B9\u02BB\u02BF\u02BE\u02B2)));
		eventTrigger3.triggers.Add(this.\u02B7\u02BF\u02BA\u02BE\u02BE\u02B5\u02BE\u02BB\u02BA\u02B3\u02C1(EventTriggerType.PointerEnter, new UnityAction<BaseEventData>(u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.\u02B9\u02B8\u02B2\u02BF\u02B8\u02BE\u02B5\u02B7\u02C1\u02B4\u02B8)));
		eventTrigger.triggers.Add(this.\u02B5\u02BD\u02BC\u02B5\u02B9\u02B4\u02C0\u02B4\u02BC\u02BB\u02B2(EventTriggerType.PointerEnter, new UnityAction<BaseEventData>(u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.\u02BA\u02BE\u02BA\u02B5\u02BC\u02B2\u02B6\u02C1\u02BA\u02B6\u02B8)));
		eventTrigger2.triggers.Add(this.\u02B7\u02BF\u02BA\u02BE\u02BE\u02B5\u02BE\u02BB\u02BA\u02B3\u02C1(EventTriggerType.PointerExit, new UnityAction<BaseEventData>(u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.\u02BA\u02BD\u02BA\u02B7\u02BB\u02B7\u02B3\u02B9\u02C1\u02B4\u02B2)));
		eventTrigger3.triggers.Add(this.\u02B7\u02BF\u02BA\u02BE\u02BE\u02B5\u02BE\u02BB\u02BA\u02B3\u02C1(EventTriggerType.PointerEnter, new UnityAction<BaseEventData>(u02BA_u02B6_u02BE_u02B9_u02BD_u02BC_u02BF_u02B3_u02B8_u02BC_u02B.\u02B2\u02B7\u02BE\u02B6\u02BA\u02B9\u02B2\u02BF\u02B4\u02C1\u02BA)));
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x00010D9E File Offset: 0x0000EF9E
	public void \u02B4\u02BC\u02B7\u02BD\u02B6\u02C0\u02BC\u02B7\u02B8\u02BE\u02B4()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B4\u02B6\u02C1\u02BC\u02BF\u02BE\u02BD\u02BD\u02B7\u02C0();
	}

	// Token: 0x060014B6 RID: 5302 RVA: 0x00010D9E File Offset: 0x0000EF9E
	public void \u02B9\u02BC\u02BE\u02BF\u02B5\u02BE\u02B2\u02B2\u02B4\u02BE\u02B6()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B4\u02B6\u02C1\u02BC\u02BF\u02BE\u02BD\u02BD\u02B7\u02C0();
	}

	// Token: 0x060014B7 RID: 5303 RVA: 0x00010DA5 File Offset: 0x0000EFA5
	private EventTrigger.Entry \u02B7\u02BF\u02BA\u02BE\u02BE\u02B5\u02BE\u02BB\u02BA\u02B3\u02C1(EventTriggerType \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5, UnityAction<BaseEventData> \u02BA\u02B8\u02C1\u02B5\u02B2\u02B3\u02C1\u02BF\u02BD\u02B7\u02BD)
	{
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5;
		entry.callback.AddListener(\u02BA\u02B8\u02C1\u02B5\u02B2\u02B3\u02C1\u02BF\u02BD\u02B7\u02BD);
		return entry;
	}

	// Token: 0x060014B9 RID: 5305 RVA: 0x00010D97 File Offset: 0x0000EF97
	public void \u02B2\u02C1\u02B2\u02B4\u02B7\u02C0\u02B7\u02BA\u02BB\u02B6\u02BB()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BE\u02BF\u02B4\u02B3\u02B5\u02B8\u02BA\u02BC\u02B2\u02B7\u02C0();
	}

	// Token: 0x060014BA RID: 5306 RVA: 0x00010DA5 File Offset: 0x0000EFA5
	private EventTrigger.Entry \u02B5\u02BD\u02BC\u02B5\u02B9\u02B4\u02C0\u02B4\u02BC\u02BB\u02B2(EventTriggerType \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5, UnityAction<BaseEventData> \u02BA\u02B8\u02C1\u02B5\u02B2\u02B3\u02C1\u02BF\u02BD\u02B7\u02BD)
	{
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5;
		entry.callback.AddListener(\u02BA\u02B8\u02C1\u02B5\u02B2\u02B3\u02C1\u02BF\u02BD\u02B7\u02BD);
		return entry;
	}

	// Token: 0x04000F40 RID: 3904
	[SerializeField]
	private Button privacyButton;

	// Token: 0x04000F41 RID: 3905
	[SerializeField]
	private Button denyButton;

	// Token: 0x04000F42 RID: 3906
	[SerializeField]
	private Button acceptButton;

	// Token: 0x04000F43 RID: 3907
	[SerializeField]
	private Color defaultColor;

	// Token: 0x04000F44 RID: 3908
	[SerializeField]
	private Color highlightedColor;

	// Token: 0x020001D5 RID: 469
	[CompilerGenerated]
	private sealed class \u02BA\u02B6\u02BE\u02B9\u02BD\u02BC\u02BF\u02B3\u02B8\u02BC\u02B6
	{
		// Token: 0x060014BC RID: 5308 RVA: 0x00010DBF File Offset: 0x0000EFBF
		internal void \u02BC\u02BE\u02BA\u02B7\u02B5\u02B9\u02B7\u02BA\u02B2\u02BA\u02B7(BaseEventData eventData)
		{
			this.textPrivacy.color = (this.<>4__this.denyButton.interactable ? this.<>4__this.highlightedColor : this.<>4__this.defaultColor);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00010DF6 File Offset: 0x0000EFF6
		internal void \u02B6\u02C1\u02BA\u02BA\u02B3\u02B8\u02B9\u02BB\u02BF\u02BE\u02B2(BaseEventData eventData)
		{
			this.textDeny.color = (this.<>4__this.denyButton.interactable ? this.<>4__this.highlightedColor : this.<>4__this.defaultColor);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00010E2D File Offset: 0x0000F02D
		internal void \u02B9\u02B8\u02B2\u02BF\u02B8\u02BE\u02B5\u02B7\u02C1\u02B4\u02B8(BaseEventData eventData)
		{
			this.textAccept.color = (this.<>4__this.denyButton.interactable ? this.<>4__this.highlightedColor : this.<>4__this.defaultColor);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00010E64 File Offset: 0x0000F064
		internal void \u02BA\u02BE\u02BA\u02B5\u02BC\u02B2\u02B6\u02C1\u02BA\u02B6\u02B8(BaseEventData eventData)
		{
			this.textPrivacy.color = this.<>4__this.defaultColor;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00010E7C File Offset: 0x0000F07C
		internal void \u02BA\u02BD\u02BA\u02B7\u02BB\u02B7\u02B3\u02B9\u02C1\u02B4\u02B2(BaseEventData eventData)
		{
			this.textDeny.color = this.<>4__this.defaultColor;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00010E94 File Offset: 0x0000F094
		internal void \u02B2\u02B7\u02BE\u02B6\u02BA\u02B9\u02B2\u02BF\u02B4\u02C1\u02BA(BaseEventData eventData)
		{
			this.textAccept.color = this.<>4__this.defaultColor;
		}

		// Token: 0x04000F45 RID: 3909
		public TextMeshProUGUI textPrivacy;

		// Token: 0x04000F46 RID: 3910
		public AnalyticsConsentDialog <>4__this;

		// Token: 0x04000F47 RID: 3911
		public TextMeshProUGUI textDeny;

		// Token: 0x04000F48 RID: 3912
		public TextMeshProUGUI textAccept;
	}
}
