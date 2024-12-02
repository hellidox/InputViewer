using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AnalyticsConsentDialog : MonoBehaviour
{
	private void OnEnable()
	{
		if (\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B5\u02BC\u02B4\u02B3\u02C0\u02C1\u02BB\u02BE\u02B2\u02BF)
		{
			this.denyButton.interactable = false;
			this.acceptButton.interactable = false;
		}
	}

	public void \u02C0\u02C0\u02C1\u02B2\u02B4\u02BC\u02B5\u02BA\u02B5\u02B6\u02BD()
	{
		Application.OpenURL(\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B5\u02B4\u02B9\u02B3\u02BB\u02C0\u02B9\u02B5\u02BF\u02BC\u02BA());
	}

	public void \u02BB\u02C0\u02B6\u02BF\u02B3\u02B2\u02B4\u02B2\u02B6\u02C1\u02B4()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BE\u02BF\u02B4\u02B3\u02B5\u02B8\u02BA\u02BC\u02B2\u02B7\u02C0();
	}

	public void \u02B4\u02B6\u02BA\u02B5\u02C0\u02B2\u02BA\u02BC\u02C0\u02B7\u02BB()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B4\u02B6\u02C1\u02BC\u02BF\u02BE\u02BD\u02BD\u02B7\u02C0();
	}

	public void \u02BF\u02BB\u02BE\u02B8\u02B2\u02BF\u02B3\u02BF\u02B5\u02B8\u02B3()
	{
		Application.OpenURL(\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02B5\u02B4\u02B9\u02B3\u02BB\u02C0\u02B9\u02B5\u02BF\u02BC\u02BA());
	}

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

	public void \u02B7\u02B3\u02B5\u02BD\u02B3\u02BA\u02B6\u02C1\u02BB\u02B6\u02BF()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B4\u02B6\u02C1\u02BC\u02BF\u02BE\u02BD\u02BD\u02B7\u02C0();
	}

	public void \u02B6\u02B9\u02BD\u02BA\u02B5\u02B9\u02BA\u02B9\u02C0\u02C0\u02BC()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B4\u02B6\u02C1\u02BC\u02BF\u02BE\u02BD\u02BD\u02B7\u02C0();
	}

	public void \u02B7\u02B8\u02BB\u02BD\u02C0\u02C1\u02B8\u02BC\u02BD\u02B4\u02B2()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BE\u02BF\u02B4\u02B3\u02B5\u02B8\u02BA\u02BC\u02B2\u02B7\u02C0();
	}

	public void \u02B3\u02C1\u02B3\u02B9\u02BE\u02B9\u02BA\u02BA\u02C1\u02B9\u02B2()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BE\u02BF\u02B4\u02B3\u02B5\u02B8\u02BA\u02BC\u02B2\u02B7\u02C0();
	}

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

	public void \u02B4\u02BC\u02B7\u02BD\u02B6\u02C0\u02BC\u02B7\u02B8\u02BE\u02B4()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B4\u02B6\u02C1\u02BC\u02BF\u02BE\u02BD\u02BD\u02B7\u02C0();
	}

	public void \u02B9\u02BC\u02BE\u02BF\u02B5\u02BE\u02B2\u02B2\u02B4\u02BE\u02B6()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BA\u02B4\u02B6\u02C1\u02BC\u02BF\u02BE\u02BD\u02BD\u02B7\u02C0();
	}

	private EventTrigger.Entry \u02B7\u02BF\u02BA\u02BE\u02BE\u02B5\u02BE\u02BB\u02BA\u02B3\u02C1(EventTriggerType \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5, UnityAction<BaseEventData> \u02BA\u02B8\u02C1\u02B5\u02B2\u02B3\u02C1\u02BF\u02BD\u02B7\u02BD)
	{
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5;
		entry.callback.AddListener(\u02BA\u02B8\u02C1\u02B5\u02B2\u02B3\u02C1\u02BF\u02BD\u02B7\u02BD);
		return entry;
	}

	public void \u02B2\u02C1\u02B2\u02B4\u02B7\u02C0\u02B7\u02BA\u02BB\u02B6\u02BB()
	{
		\u02B8\u02B8\u02B7\u02BE\u02B3\u02BF\u02B3\u02B4\u02B4\u02B9\u02BA.\u02BE\u02BF\u02B4\u02B3\u02B5\u02B8\u02BA\u02BC\u02B2\u02B7\u02C0();
	}

	private EventTrigger.Entry \u02B5\u02BD\u02BC\u02B5\u02B9\u02B4\u02C0\u02B4\u02BC\u02BB\u02B2(EventTriggerType \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5, UnityAction<BaseEventData> \u02BA\u02B8\u02C1\u02B5\u02B2\u02B3\u02C1\u02BF\u02BD\u02B7\u02BD)
	{
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5;
		entry.callback.AddListener(\u02BA\u02B8\u02C1\u02B5\u02B2\u02B3\u02C1\u02BF\u02BD\u02B7\u02BD);
		return entry;
	}

	[SerializeField]
	private Button privacyButton;

	[SerializeField]
	private Button denyButton;

	[SerializeField]
	private Button acceptButton;

	[SerializeField]
	private Color defaultColor;

	[SerializeField]
	private Color highlightedColor;

	[CompilerGenerated]
	private sealed class \u02BA\u02B6\u02BE\u02B9\u02BD\u02BC\u02BF\u02B3\u02B8\u02BC\u02B6
	{
		internal void \u02BC\u02BE\u02BA\u02B7\u02B5\u02B9\u02B7\u02BA\u02B2\u02BA\u02B7(BaseEventData eventData)
		{
			this.textPrivacy.color = (this.<>4__this.denyButton.interactable ? this.<>4__this.highlightedColor : this.<>4__this.defaultColor);
		}

		internal void \u02B6\u02C1\u02BA\u02BA\u02B3\u02B8\u02B9\u02BB\u02BF\u02BE\u02B2(BaseEventData eventData)
		{
			this.textDeny.color = (this.<>4__this.denyButton.interactable ? this.<>4__this.highlightedColor : this.<>4__this.defaultColor);
		}

		internal void \u02B9\u02B8\u02B2\u02BF\u02B8\u02BE\u02B5\u02B7\u02C1\u02B4\u02B8(BaseEventData eventData)
		{
			this.textAccept.color = (this.<>4__this.denyButton.interactable ? this.<>4__this.highlightedColor : this.<>4__this.defaultColor);
		}

		internal void \u02BA\u02BE\u02BA\u02B5\u02BC\u02B2\u02B6\u02C1\u02BA\u02B6\u02B8(BaseEventData eventData)
		{
			this.textPrivacy.color = this.<>4__this.defaultColor;
		}

		internal void \u02BA\u02BD\u02BA\u02B7\u02BB\u02B7\u02B3\u02B9\u02C1\u02B4\u02B2(BaseEventData eventData)
		{
			this.textDeny.color = this.<>4__this.defaultColor;
		}

		internal void \u02B2\u02B7\u02BE\u02B6\u02BA\u02B9\u02B2\u02BF\u02B4\u02C1\u02BA(BaseEventData eventData)
		{
			this.textAccept.color = this.<>4__this.defaultColor;
		}

		public TextMeshProUGUI textPrivacy;

		public AnalyticsConsentDialog <>4__this;

		public TextMeshProUGUI textDeny;

		public TextMeshProUGUI textAccept;
	}
}
