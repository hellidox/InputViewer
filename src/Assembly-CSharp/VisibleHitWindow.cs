using System;
using UnityEngine;

public class VisibleHitWindow : MonoBehaviour
{
	private void \u02B2\u02B7\u02B5\u02C0\u02B4\u02B3\u02B8\u02B3\u02C0\u02BD\u02B5()
	{
		this.thisTransform = base.transform;
		this.player = this.thisTransform.parent.GetComponent<BasePlayer>();
		this.noteSpeed = this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.gameManager = this.player.gameManager;
		if (!SettingsController.show_hit_window)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.\u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0();
	}

	private void \u02B2\u02BB\u02B6\u02B5\u02B9\u02B8\u02B2\u02B3\u02BF\u02C1\u02BF()
	{
		this.thisTransform = base.transform;
		this.player = this.thisTransform.parent.GetComponent<BasePlayer>();
		this.noteSpeed = this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.gameManager = this.player.gameManager;
		if (!SettingsController.show_hit_window)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.Update();
	}

	private void Start()
	{
		this.thisTransform = base.transform;
		this.player = this.thisTransform.parent.GetComponent<BasePlayer>();
		this.noteSpeed = this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.gameManager = this.player.gameManager;
		if (!SettingsController.show_hit_window)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.GetComponent<SpriteRenderer>().enabled = true;
		this.Update();
	}

	private void \u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF()
	{
		this.thisTransform.localScale = new Vector3(this.thisTransform.localScale.x, this.player.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF * (float)this.noteSpeed);
		float num = -(this.gameManager.audioOffset + this.gameManager.videoOffset);
		this.thisTransform.localPosition = new Vector3(440f, 330f, num * (float)this.noteSpeed + this.\u02BB\u02B6\u02BC\u02BC\u02B8\u02BA\u02BF\u02C0\u02BD\u02C0\u02B4);
	}

	private void \u02C0\u02BC\u02BC\u02BD\u02B8\u02BD\u02BE\u02B6\u02BE\u02BB\u02BB()
	{
		this.thisTransform = base.transform;
		this.player = this.thisTransform.parent.GetComponent<BasePlayer>();
		this.noteSpeed = this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.gameManager = this.player.gameManager;
		if (!SettingsController.show_hit_window)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.\u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB();
	}

	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		this.thisTransform.localScale = new Vector3(this.thisTransform.localScale.x, this.player.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF * (float)this.noteSpeed);
		float num = -(this.gameManager.audioOffset + this.gameManager.videoOffset);
		this.thisTransform.localPosition = new Vector3(1740f, 1861f, num * (float)this.noteSpeed + this.\u02BB\u02B6\u02BC\u02BC\u02B8\u02BA\u02BF\u02C0\u02BD\u02C0\u02B4);
	}

	private void \u02B9\u02B5\u02B2\u02BB\u02B5\u02B3\u02B9\u02BC\u02BF\u02B5\u02BA()
	{
		this.thisTransform.localScale = new Vector3(this.thisTransform.localScale.x, this.player.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF * (float)this.noteSpeed);
		float num = -(this.gameManager.audioOffset + this.gameManager.videoOffset);
		this.thisTransform.localPosition = new Vector3(954f, 893f, num * (float)this.noteSpeed + this.\u02BB\u02B6\u02BC\u02BC\u02B8\u02BA\u02BF\u02C0\u02BD\u02C0\u02B4);
	}

	private void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		this.thisTransform = base.transform;
		this.player = this.thisTransform.parent.GetComponent<BasePlayer>();
		this.noteSpeed = this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.gameManager = this.player.gameManager;
		if (!SettingsController.show_hit_window)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.GetComponent<SpriteRenderer>().enabled = true;
		this.\u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF();
	}

	private void \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		this.thisTransform = base.transform;
		this.player = this.thisTransform.parent.GetComponent<BasePlayer>();
		this.noteSpeed = this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.gameManager = this.player.gameManager;
		if (!SettingsController.show_hit_window)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.Update();
	}

	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		this.thisTransform = base.transform;
		this.player = this.thisTransform.parent.GetComponent<BasePlayer>();
		this.noteSpeed = this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.gameManager = this.player.gameManager;
		if (!SettingsController.show_hit_window)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.\u02BB\u02BF\u02BA\u02BC\u02B8\u02B7\u02B4\u02B5\u02B7\u02B9\u02C1();
	}

	private void \u02BC\u02BC\u02B3\u02B2\u02C0\u02B6\u02B8\u02BA\u02BD\u02B9\u02B6()
	{
		this.thisTransform = base.transform;
		this.player = this.thisTransform.parent.GetComponent<BasePlayer>();
		this.noteSpeed = this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.gameManager = this.player.gameManager;
		if (!SettingsController.show_hit_window)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.GetComponent<SpriteRenderer>().enabled = true;
		this.\u02BE\u02B2\u02B3\u02BB\u02BE\u02BB\u02B7\u02BF\u02B5\u02B7\u02B8();
	}

	private void \u02B4\u02B2\u02B5\u02BA\u02B4\u02C0\u02BC\u02BB\u02C1\u02B9\u02BD()
	{
		this.thisTransform = base.transform;
		this.player = this.thisTransform.parent.GetComponent<BasePlayer>();
		this.noteSpeed = this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.gameManager = this.player.gameManager;
		if (!SettingsController.show_hit_window)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.GetComponent<SpriteRenderer>().enabled = true;
		this.\u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB();
	}

	private void \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		this.thisTransform = base.transform;
		this.player = this.thisTransform.parent.GetComponent<BasePlayer>();
		this.noteSpeed = this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.gameManager = this.player.gameManager;
		if (!SettingsController.show_hit_window)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.\u02B9\u02B5\u02B2\u02BB\u02B5\u02B3\u02B9\u02BC\u02BF\u02B5\u02BA();
	}

	private void \u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0()
	{
		this.thisTransform.localScale = new Vector3(this.thisTransform.localScale.x, this.player.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF * (float)this.noteSpeed);
		float num = -(this.gameManager.audioOffset + this.gameManager.videoOffset);
		this.thisTransform.localPosition = new Vector3(1983f, 1258f, num * (float)this.noteSpeed + this.\u02BB\u02B6\u02BC\u02BC\u02B8\u02BA\u02BF\u02C0\u02BD\u02C0\u02B4);
	}

	private void \u02BB\u02BF\u02BA\u02BC\u02B8\u02B7\u02B4\u02B5\u02B7\u02B9\u02C1()
	{
		this.thisTransform.localScale = new Vector3(this.thisTransform.localScale.x, this.player.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF * (float)this.noteSpeed);
		float num = -(this.gameManager.audioOffset + this.gameManager.videoOffset);
		this.thisTransform.localPosition = new Vector3(1500f, 858f, num * (float)this.noteSpeed + this.\u02BB\u02B6\u02BC\u02BC\u02B8\u02BA\u02BF\u02C0\u02BD\u02C0\u02B4);
	}

	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		this.thisTransform = base.transform;
		this.player = this.thisTransform.parent.GetComponent<BasePlayer>();
		this.noteSpeed = this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.gameManager = this.player.gameManager;
		if (!SettingsController.show_hit_window)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.\u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF();
	}

	private void Update()
	{
		this.thisTransform.localScale = new Vector3(this.thisTransform.localScale.x, Mathf.Min(GlobalHelper.judgementHitWindowSize, 0.07f) * 2f * (float)this.noteSpeed);
		float num = -(this.gameManager.audioOffset + this.gameManager.videoOffset);
		this.thisTransform.localPosition = new Vector3(0f, 0f, num * (float)this.noteSpeed + this.\u02BB\u02B6\u02BC\u02BC\u02B8\u02BA\u02BF\u02C0\u02BD\u02C0\u02B4);
	}

	private void \u02B4\u02BC\u02BE\u02BF\u02B4\u02B5\u02BF\u02B7\u02BA\u02BA\u02BB()
	{
		this.thisTransform = base.transform;
		this.player = this.thisTransform.parent.GetComponent<BasePlayer>();
		this.noteSpeed = this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.gameManager = this.player.gameManager;
		if (!SettingsController.show_hit_window)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.GetComponent<SpriteRenderer>().enabled = true;
		this.Update();
	}

	private void \u02BE\u02B2\u02B3\u02BB\u02BE\u02BB\u02B7\u02BF\u02B5\u02B7\u02B8()
	{
		this.thisTransform.localScale = new Vector3(this.thisTransform.localScale.x, this.player.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF * (float)this.noteSpeed);
		float num = -(this.gameManager.audioOffset + this.gameManager.videoOffset);
		this.thisTransform.localPosition = new Vector3(299f, 26f, num * (float)this.noteSpeed + this.\u02BB\u02B6\u02BC\u02BC\u02B8\u02BA\u02BF\u02C0\u02BD\u02C0\u02B4);
	}

	private void \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		this.thisTransform = base.transform;
		this.player = this.thisTransform.parent.GetComponent<BasePlayer>();
		this.noteSpeed = this.player.player.playerProfile.noteSpeed.CurrentValue;
		this.gameManager = this.player.gameManager;
		if (!SettingsController.show_hit_window)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.GetComponent<SpriteRenderer>().enabled = true;
		this.\u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB();
	}

	private Transform thisTransform;

	public float \u02BB\u02B6\u02BC\u02BC\u02B8\u02BA\u02BF\u02C0\u02BD\u02C0\u02B4;

	private BasePlayer player;

	private GameManager gameManager;

	private int noteSpeed;

	private SpriteRenderer[] windows;
}
