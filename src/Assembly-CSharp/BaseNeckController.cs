using System;
using System.Collections;
using UnityEngine;

public abstract class BaseNeckController : MonoBehaviour, \u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7
{
	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 gameColorSettings { get; set; }

	public abstract void \u02BF\u02B2\u02BE\u02BE\u02BF\u02B4\u02BC\u02C0\u02B3\u02C0\u02C1();

	public abstract void PlayFret(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, bool \u02B3\u02B2\u02BC\u02B2\u02BD\u02BF\u02B6\u02BD\u02BF\u02C0\u02BE, bool \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);

	public abstract void \u02C0\u02B8\u02B5\u02B3\u02BF\u02BD\u02B2\u02BE\u02B9\u02B2\u02B4(ushort \u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6);

	public abstract void \u02B8\u02BA\u02B8\u02B9\u02B7\u02B3\u02B6\u02BD\u02C1\u02BC\u02B8(ushort \u02B3\u02BF\u02B5\u02B7\u02C0\u02BB\u02BA\u02B4\u02B8\u02C0\u02B7);

	public abstract void \u02B5\u02BD\u02BA\u02BE\u02B4\u02B9\u02BD\u02B3\u02B9\u02BC\u02BE();

	protected abstract IEnumerator \u02B5\u02BD\u02BE\u02BF\u02B3\u02B8\u02BC\u02B5\u02B2\u02B4\u02B6();

	public virtual void \u02B7\u02BC\u02BC\u02C0\u02BA\u02BF\u02BE\u02C0\u02BA\u02BA\u02B8()
	{
		base.StartCoroutine(this.\u02B5\u02BD\u02BE\u02BF\u02B3\u02B8\u02BC\u02B5\u02B2\u02B4\u02B6());
		if (base.gameObject.GetComponent<BasePlayer>().player.playerProfile.isBot || !SettingsController.\u02C1\u02B6\u02B5\u02C1\u02B7\u02BE\u02B5\u02B9\u02B9\u02BB\u02C1)
		{
			this.\u02BF\u02B9\u02B2\u02B2\u02BF\u02B2\u02BA\u02B4\u02BB\u02B5\u02C1();
		}
	}

	public virtual void \u02BF\u02B9\u02B2\u02B2\u02BF\u02B2\u02BA\u02B4\u02BB\u02B5\u02C1()
	{
		global::Animator[] u02B6_u02C0_u02C1_u02BA_u02B4_u02B7_u02B7_u02C1_u02BE_u02B3_u02BC = this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC;
		for (int i = 0; i < u02B6_u02C0_u02C1_u02BA_u02B4_u02B7_u02B7_u02C1_u02BE_u02B3_u02BC.Length; i++)
		{
			u02B6_u02C0_u02C1_u02BA_u02B4_u02B7_u02B7_u02C1_u02BE_u02B3_u02BC[i].GetComponent<SpriteRenderer>().enabled = false;
		}
	}

	public abstract void \u02B2\u02BF\u02BB\u02BC\u02B8\u02B7\u02B9\u02C1\u02B8\u02BE\u02BA();

	public abstract void \u02B6\u02B2\u02B9\u02B7\u02B5\u02B9\u02B5\u02BF\u02B8\u02B8\u02BC(bool \u02BB\u02B9\u02BB\u02B7\u02BB\u02B9\u02BA\u02B2\u02C1\u02B5\u02BA);

	public virtual void HideFretStrings()
	{
		if (this.hidden)
		{
			return;
		}
		this.hidden = true;
		GameObject[] u02B8_u02BF_u02BD_u02B4_u02BA_u02B5_u02C1_u02C1_u02B5_u02BD_u02B = this.\u02B8\u02BF\u02BD\u02B4\u02BA\u02B5\u02C1\u02C1\u02B5\u02BD\u02B4;
		for (int i = 0; i < u02B8_u02BF_u02BD_u02B4_u02BA_u02B5_u02C1_u02C1_u02B5_u02BD_u02B.Length; i++)
		{
			u02B8_u02BF_u02BD_u02B4_u02BA_u02B5_u02C1_u02C1_u02B5_u02BD_u02B[i].SetActive(false);
		}
	}

	public virtual void ShowFretStrings()
	{
		if (!this.hidden)
		{
			return;
		}
		this.hidden = false;
		GameObject[] u02B8_u02BF_u02BD_u02B4_u02BA_u02B5_u02C1_u02C1_u02B5_u02BD_u02B = this.\u02B8\u02BF\u02BD\u02B4\u02BA\u02B5\u02C1\u02C1\u02B5\u02BD\u02B4;
		for (int i = 0; i < u02B8_u02BF_u02BD_u02B4_u02BA_u02B5_u02C1_u02C1_u02B5_u02BD_u02B.Length; i++)
		{
			u02B8_u02BF_u02BD_u02B4_u02BA_u02B5_u02C1_u02C1_u02B5_u02BD_u02B[i].SetActive(true);
		}
	}

	void \u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7.\u02B8\u02B9\u02C0\u02B7\u02C0\u02B6\u02C1\u02BA\u02BF\u02B8\u02B8(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.gameColorSettings = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public BaseFretAnimator[] \u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9;

	public global::Animator[] \u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC;

	public global::Animator[] flameAnimators;

	public GameObject[] \u02B8\u02BF\u02BD\u02B4\u02BA\u02B5\u02C1\u02C1\u02B5\u02BD\u02B4;

	protected ushort \u02B7\u02C0\u02BB\u02BF\u02B9\u02C0\u02BD\u02BA\u02B7\u02B8\u02BB = 128;

	private bool hidden;
}
