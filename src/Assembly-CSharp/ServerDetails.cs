using System;
using System.Net;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000EE RID: 238
public class ServerDetails : MonoBehaviour
{
	// Token: 0x06000959 RID: 2393 RVA: 0x000529A4 File Offset: 0x00050BA4
	private void SetUpInputFields()
	{
		this.serveraddress.interactable = false;
		this.servername.interactable = false;
		this.serverport.interactable = false;
		this.serverpassword.interactable = false;
		this.addressToggle.interactable = false;
		this.passwordToggle.interactable = false;
		this.addressToggle.isOn = false;
		this.passwordToggle.isOn = false;
		this.serverpassword.text = string.Empty;
		this.servername.text = string.Empty;
		this.serverport.text = "14242";
		this.serveraddress.text = "It's all ogre now...";
		this.serverpassword.contentType = TMP_InputField.ContentType.Password;
		this.serveraddress.contentType = TMP_InputField.ContentType.Password;
		this.nameWarning.SetActive(false);
		this.portWarning.SetActive(false);
		this.addressWarning.SetActive(false);
		switch (this.state)
		{
		case ServerDetails.State.JoinNewServer:
			this.serveraddress.text = string.Empty;
			this.serverport.interactable = true;
			this.passwordToggle.interactable = true;
			this.serveraddress.interactable = true;
			this.serverpassword.interactable = true;
			this.addressToggle.interactable = true;
			this.addressWarning.SetActive(true);
			return;
		case ServerDetails.State.JoinFromBrowser:
			this.serverpassword.interactable = true;
			this.passwordToggle.interactable = true;
			this.servername.text = this.serverToJoin.\u02BE\u02B4\u02B8\u02BB\u02BB\u02BB\u02BE\u02BC\u02BA\u02BE\u02BD;
			this.serverport.text = this.serverToJoin.\u02B6\u02BE\u02BF\u02B6\u02BB\u02B6\u02BC\u02BB\u02BD\u02BF\u02BF.Port.ToString();
			return;
		case ServerDetails.State.CreatingServer:
			this.servername.interactable = true;
			this.serverport.interactable = true;
			this.serverpassword.interactable = true;
			this.passwordToggle.interactable = true;
			this.nameWarning.SetActive(true);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x0000A778 File Offset: 0x00008978
	public void StartCreateServer()
	{
		this.state = ServerDetails.State.CreatingServer;
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x0000A78D File Offset: 0x0000898D
	public void StartJoin()
	{
		this.state = ServerDetails.State.JoinNewServer;
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x0000A7A2 File Offset: 0x000089A2
	public void StartJoin(\u02BC\u02BB\u02B5\u02B7\u02BC\u02B6\u02B4\u02B6\u02B2\u02BA\u02B9 server)
	{
		this.state = ServerDetails.State.JoinFromBrowser;
		this.serverToJoin = server;
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x0000A7BE File Offset: 0x000089BE
	private void OnEnable()
	{
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(false);
		this.SetUpInputFields();
		this.isActive = true;
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x0000A7D3 File Offset: 0x000089D3
	public void OnDisable()
	{
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(true);
		this.isActive = false;
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x0000A7E2 File Offset: 0x000089E2
	private void Start()
	{
		this.ValidateInputFields();
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x0000A7EA File Offset: 0x000089EA
	[\u02B2\u02B6\u02B4\u02B9\u02BF\u02C0\u02BA\u02BD\u02C0\u02B3\u02BD]
	public void ToggleAddress(bool value)
	{
		this.serveraddress.contentType = (value ? TMP_InputField.ContentType.Standard : TMP_InputField.ContentType.Password);
		this.serveraddress.ForceLabelUpdate();
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x0000A809 File Offset: 0x00008A09
	[\u02B2\u02B6\u02B4\u02B9\u02BF\u02C0\u02BA\u02BD\u02C0\u02B3\u02BD]
	public void TogglePassword(bool value)
	{
		this.serverpassword.contentType = (value ? TMP_InputField.ContentType.Standard : TMP_InputField.ContentType.Password);
		this.serverpassword.ForceLabelUpdate();
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00052B90 File Offset: 0x00050D90
	public void ValidateInputFields()
	{
		this.addressWarning.SetActive(this.serveraddress.interactable && Uri.CheckHostName(this.serveraddress.text) == UriHostNameType.Unknown);
		this.portWarning.SetActive(this.serverport.interactable && this.serverport.text == string.Empty);
		this.nameWarning.SetActive(this.servername.interactable && this.servername.text == string.Empty);
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00052C2C File Offset: 0x00050E2C
	[\u02B2\u02B6\u02B4\u02B9\u02BF\u02C0\u02BA\u02BD\u02C0\u02B3\u02BD]
	public void OnConfirm()
	{
		this.ValidateInputFields();
		if (this.nameWarning.activeSelf || this.portWarning.activeSelf || this.addressWarning.activeSelf)
		{
			return;
		}
		\u02C0\u02B5\u02BB\u02BD\u02BF\u02B4\u02B6\u02BF\u02BB\u02BE\u02BE u02C0_u02B5_u02BB_u02BD_u02BF_u02B4_u02B6_u02BF_u02BB_u02BE_u02BE = new \u02C0\u02B5\u02BB\u02BD\u02BF\u02B4\u02B6\u02BF\u02BB\u02BE\u02BE
		{
			\u02BA\u02B9\u02B8\u02BE\u02B6\u02BD\u02B3\u02B7\u02B8\u02BB\u02B8 = this.servername.text,
			\u02B7\u02B3\u02C0\u02BA\u02B8\u02B6\u02B7\u02BE\u02BB\u02B5\u02BB = this.serverpassword.text,
			\u02BE\u02BA\u02C1\u02BC\u02BC\u02B4\u02B8\u02BF\u02BA\u02B5\u02B6 = ushort.Parse(this.serverport.text)
		};
		base.gameObject.SetActive(false);
		if (this.state == ServerDetails.State.CreatingServer)
		{
			u02C0_u02B5_u02BB_u02BD_u02BF_u02B4_u02B6_u02BF_u02BB_u02BE_u02BE.\u02BB\u02BC\u02BD\u02C0\u02B7\u02BF\u02B4\u02BB\u02B4\u02BC\u02B2 = IPAddress.Any.ToString();
			this.onlineMenu.\u02BB\u02B2\u02B5\u02C1\u02B5\u02B8\u02C1\u02B7\u02C1\u02BC\u02B7(u02C0_u02B5_u02BB_u02BD_u02BF_u02B4_u02B6_u02BF_u02BB_u02BE_u02BE);
			return;
		}
		if (this.state == ServerDetails.State.JoinFromBrowser)
		{
			u02C0_u02B5_u02BB_u02BD_u02BF_u02B4_u02B6_u02BF_u02BB_u02BE_u02BE.\u02BF\u02BD\u02BB\u02BF\u02B4\u02BC\u02B8\u02BD\u02BA\u02B9\u02BA = this.serverToJoin.\u02B6\u02BE\u02BF\u02B6\u02BB\u02B6\u02BC\u02BB\u02BD\u02BF\u02BF;
			this.onlineMenu.\u02B3\u02B5\u02B9\u02BF\u02B8\u02B7\u02BB\u02BC\u02BF\u02B8\u02BB(u02C0_u02B5_u02BB_u02BD_u02BF_u02B4_u02B6_u02BF_u02BB_u02BE_u02BE);
			return;
		}
		if (this.state == ServerDetails.State.JoinNewServer)
		{
			string text = this.serveraddress.text + ":" + this.serverport.text;
			SettingsController.\u02B4\u02B3\u02B3\u02B7\u02C1\u02BE\u02BC\u02B9\u02B4\u02BC\u02BB.AddValue(text);
			Settings.Commit(false);
			u02C0_u02B5_u02BB_u02BD_u02BF_u02B4_u02B6_u02BF_u02BB_u02BE_u02BE.\u02BB\u02BC\u02BD\u02C0\u02B7\u02BF\u02B4\u02BB\u02B4\u02BC\u02B2 = this.serveraddress.text;
			this.onlineMenu.\u02B3\u02B5\u02B9\u02BF\u02B8\u02B7\u02BB\u02BC\u02BF\u02B8\u02BB(u02C0_u02B5_u02BB_u02BD_u02BF_u02B4_u02B6_u02BF_u02BB_u02BE_u02BE);
		}
	}

	// Token: 0x04000738 RID: 1848
	[SerializeField]
	private TMP_InputField servername;

	// Token: 0x04000739 RID: 1849
	[SerializeField]
	private TMP_InputField serveraddress;

	// Token: 0x0400073A RID: 1850
	[SerializeField]
	private TMP_InputField serverpassword;

	// Token: 0x0400073B RID: 1851
	[SerializeField]
	private TMP_InputField serverport;

	// Token: 0x0400073C RID: 1852
	[SerializeField]
	private Toggle addressToggle;

	// Token: 0x0400073D RID: 1853
	[SerializeField]
	private Toggle passwordToggle;

	// Token: 0x0400073E RID: 1854
	[SerializeField]
	private GameObject addressWarning;

	// Token: 0x0400073F RID: 1855
	[SerializeField]
	private GameObject portWarning;

	// Token: 0x04000740 RID: 1856
	[SerializeField]
	private GameObject nameWarning;

	// Token: 0x04000741 RID: 1857
	[SerializeField]
	private OnlineMenu onlineMenu;

	// Token: 0x04000742 RID: 1858
	private \u02BC\u02BB\u02B5\u02B7\u02BC\u02B6\u02B4\u02B6\u02B2\u02BA\u02B9 serverToJoin;

	// Token: 0x04000743 RID: 1859
	private ServerDetails.State state;

	// Token: 0x04000744 RID: 1860
	[HideInInspector]
	public bool isActive;

	// Token: 0x04000745 RID: 1861
	private bool joinAsSpectator;

	// Token: 0x020000EF RID: 239
	private enum State
	{
		// Token: 0x04000747 RID: 1863
		JoinNewServer,
		// Token: 0x04000748 RID: 1864
		JoinFromBrowser,
		// Token: 0x04000749 RID: 1865
		CreatingServer,
		// Token: 0x0400074A RID: 1866
		EditingServer
	}
}
