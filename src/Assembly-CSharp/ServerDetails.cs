using System;
using System.Net;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ServerDetails : MonoBehaviour
{
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

	public void StartCreateServer()
	{
		this.state = ServerDetails.State.CreatingServer;
		base.gameObject.SetActive(true);
	}

	public void StartJoin()
	{
		this.state = ServerDetails.State.JoinNewServer;
		base.gameObject.SetActive(true);
	}

	public void StartJoin(\u02BC\u02BB\u02B5\u02B7\u02BC\u02B6\u02B4\u02B6\u02B2\u02BA\u02B9 server)
	{
		this.state = ServerDetails.State.JoinFromBrowser;
		this.serverToJoin = server;
		base.gameObject.SetActive(true);
	}

	private void OnEnable()
	{
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(false);
		this.SetUpInputFields();
		this.isActive = true;
	}

	public void OnDisable()
	{
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(true);
		this.isActive = false;
	}

	private void Start()
	{
		this.ValidateInputFields();
	}

	[\u02B2\u02B6\u02B4\u02B9\u02BF\u02C0\u02BA\u02BD\u02C0\u02B3\u02BD]
	public void ToggleAddress(bool value)
	{
		this.serveraddress.contentType = (value ? TMP_InputField.ContentType.Standard : TMP_InputField.ContentType.Password);
		this.serveraddress.ForceLabelUpdate();
	}

	[\u02B2\u02B6\u02B4\u02B9\u02BF\u02C0\u02BA\u02BD\u02C0\u02B3\u02BD]
	public void TogglePassword(bool value)
	{
		this.serverpassword.contentType = (value ? TMP_InputField.ContentType.Standard : TMP_InputField.ContentType.Password);
		this.serverpassword.ForceLabelUpdate();
	}

	public void ValidateInputFields()
	{
		this.addressWarning.SetActive(this.serveraddress.interactable && Uri.CheckHostName(this.serveraddress.text) == UriHostNameType.Unknown);
		this.portWarning.SetActive(this.serverport.interactable && this.serverport.text == string.Empty);
		this.nameWarning.SetActive(this.servername.interactable && this.servername.text == string.Empty);
	}

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

	[SerializeField]
	private TMP_InputField servername;

	[SerializeField]
	private TMP_InputField serveraddress;

	[SerializeField]
	private TMP_InputField serverpassword;

	[SerializeField]
	private TMP_InputField serverport;

	[SerializeField]
	private Toggle addressToggle;

	[SerializeField]
	private Toggle passwordToggle;

	[SerializeField]
	private GameObject addressWarning;

	[SerializeField]
	private GameObject portWarning;

	[SerializeField]
	private GameObject nameWarning;

	[SerializeField]
	private OnlineMenu onlineMenu;

	private \u02BC\u02BB\u02B5\u02B7\u02BC\u02B6\u02B4\u02B6\u02B2\u02BA\u02B9 serverToJoin;

	private ServerDetails.State state;

	[HideInInspector]
	public bool isActive;

	private bool joinAsSpectator;

	private enum State
	{
		JoinNewServer,
		JoinFromBrowser,
		CreatingServer,
		EditingServer
	}
}
