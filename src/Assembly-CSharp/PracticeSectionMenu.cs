﻿using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PracticeSectionMenu : BaseMenu
{
	protected override void \u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8()
	{
		int i = 0;
		if (this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 >= 0 && this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 > this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4)
		{
			this.textboxes[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9, Color.black, false);
			this.backgroundObjects[i].color = this.selected;
			i++;
		}
		while (i < this.textboxes.Length)
		{
			int num = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 + i;
			if (num >= this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count)
			{
				break;
			}
			bool flag = this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 >= 0 && ((num >= this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 && num < base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC) || (num <= this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 && num > base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC));
			this.textboxes[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[num].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9, (i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 || flag) ? Color.black : Color.white, i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3);
			this.backgroundObjects[i].color = ((i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3) ? this.defaultColor : (flag ? this.selected : this.highlightColor));
			i++;
		}
	}

	protected virtual void \u02C1\u02C1\u02BD\u02BA\u02BB\u02BE\u02BA\u02B7\u02B9\u02C1\u02BC()
	{
		if (this.gameManager)
		{
			this.gameManager.\u02B4\u02BC\u02B7\u02BE\u02BF\u02B6\u02C1\u02B2\u02BA\u02B4\u02B6();
		}
		this.practiceHUD.SetActive(true);
		base.OnDisable();
	}

	public virtual void \u02B8\u02BE\u02B5\u02B7\u02B4\u02BE\u02BD\u02BB\u02B8\u02B6\u02BC()
	{
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
		this.gameManager.\u02B4\u02BD\u02BF\u02BD\u02BB\u02BC\u02C0\u02BC\u02BA\u02B5\u02B4(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
	}

	protected virtual void \u02BE\u02BC\u02B5\u02B5\u02B8\u02BA\u02BA\u02B7\u02B6\u02C1\u02B6()
	{
		int i = 1;
		if (this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 >= 0 && this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 > this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4)
		{
			this.textboxes[i].\u02B8\u02BD\u02BC\u02B7\u02C0\u02BB\u02B3\u02B4\u02BA\u02BF\u02BB(this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9, Color.black, true);
			this.backgroundObjects[i].color = this.selected;
			i++;
		}
		while (i < this.textboxes.Length)
		{
			int num = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 + i;
			if (num >= this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count)
			{
				break;
			}
			bool flag = this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 < 0 || ((num < this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 || num >= base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC) && (num > this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 || num > base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC));
			this.textboxes[i].\u02B7\u02BF\u02B4\u02B4\u02C1\u02BE\u02BF\u02B5\u02B4\u02BB\u02BE(this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[num].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9, (i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 || flag) ? Color.black : Color.white, i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3);
			this.backgroundObjects[i].color = ((i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3) ? this.defaultColor : (flag ? this.selected : this.highlightColor));
			i++;
		}
	}

	protected virtual void \u02B7\u02B7\u02C1\u02B3\u02BB\u02C0\u02BE\u02C1\u02B4\u02BC\u02BC()
	{
		if (this.gameManager)
		{
			this.gameManager.\u02BB\u02BF\u02B5\u02BD\u02B5\u02B2\u02C0\u02BF\u02B8\u02BB\u02B8();
		}
		this.practiceHUD.SetActive(false);
		base.OnDisable();
	}

	public virtual void \u02B6\u02BC\u02BA\u02B5\u02B8\u02B2\u02BF\u02BA\u02BD\u02BC\u02BD()
	{
		if (this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 == -1)
		{
			if (this.gameManager.\u02C1\u02BD\u02B7\u02B4\u02BF\u02B3\u02C0\u02BA\u02B6\u02B4\u02C1 == 127)
			{
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = true;
				BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 = !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BA\u02BB\u02B8\u02B9\u02C0\u02BD\u02B5\u02B4\u02B6\u02B3;
				this.gameManager.gameObject.GetComponent<ScoreManager>().enabled = false;
				FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Scan Custom Images", 358f);
			}
			else
			{
				this.pauseMenu.\u02B7\u02BE\u02BF\u02BB\u02B2\u02B6\u02BE\u02BB\u02B3\u02C1\u02B8();
				base.gameObject.SetActive(false);
			}
		}
		else
		{
			this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 = -1;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	protected virtual void \u02B4\u02B2\u02B5\u02BA\u02B4\u02C0\u02BC\u02BB\u02C1\u02B9\u02BD()
	{
		this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD = this.gameManager.song.\u02B2\u02B5\u02B9\u02BC\u02B2\u02BE\u02BF\u02BC\u02B5\u02BD\u02C1;
		this.pausedText.text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("*");
		this.menuStrings = new string[this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count];
		for (int i = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count; i < this.textboxes.Length; i++)
		{
			this.textboxes[i].\u02BA\u02BC\u02BD\u02B4\u02B3\u02B9\u02B2\u02B4\u02C0\u02B5\u02B5("PART", true);
			this.backgroundObjects[i].color = Color.clear;
		}
		base.Start();
	}

	public virtual void \u02BE\u02B5\u02BA\u02B8\u02BF\u02B7\u02B8\u02BB\u02C0\u02BB\u02B8()
	{
		if (this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 == -1)
		{
			if (this.gameManager.\u02C1\u02BD\u02B7\u02B4\u02BF\u02B3\u02C0\u02BA\u02B6\u02B4\u02C1 == 110)
			{
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = false;
				BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BA\u02BB\u02B8\u02B9\u02C0\u02BD\u02B5\u02B4\u02B6\u02B3;
				this.gameManager.gameObject.GetComponent<ScoreManager>().enabled = true;
				FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE(": ", 720f);
			}
			else
			{
				this.pauseMenu.\u02B7\u02BE\u02BF\u02BB\u02B2\u02B6\u02BE\u02BB\u02B3\u02C1\u02B8();
				base.gameObject.SetActive(true);
			}
		}
		else
		{
			this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 = -1;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	public virtual void \u02BD\u02B7\u02BE\u02BD\u02BF\u02BA\u02BD\u02C0\u02B9\u02BC\u02C1()
	{
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
		this.gameManager.\u02B9\u02C0\u02BF\u02C1\u02B6\u02BA\u02C0\u02BB\u02BE\u02B4\u02B7(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
	}

	protected override void OnDisable()
	{
		if (this.gameManager)
		{
			this.gameManager.\u02BB\u02BF\u02B5\u02BD\u02B5\u02B2\u02C0\u02BF\u02B8\u02BB\u02B8();
		}
		this.practiceHUD.SetActive(true);
		base.OnDisable();
	}

	protected virtual void \u02BD\u02B3\u02C0\u02B8\u02B8\u02B3\u02B6\u02B3\u02BF\u02BD\u02BE()
	{
		if (this.gameManager)
		{
			this.gameManager.\u02C0\u02BF\u02BC\u02B5\u02B7\u02B2\u02B8\u02BC\u02B7\u02B9\u02B7();
		}
		this.practiceHUD.SetActive(true);
		base.OnDisable();
	}

	protected override void Start()
	{
		this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD = this.gameManager.song.\u02B2\u02B5\u02B9\u02BC\u02B2\u02BE\u02BF\u02BC\u02B5\u02BD\u02C1;
		this.pausedText.text = LanguageManager.instance.GetString("SECTION");
		this.menuStrings = new string[this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count];
		for (int i = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count; i < this.textboxes.Length; i++)
		{
			this.textboxes[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6("", false);
			this.backgroundObjects[i].color = Color.clear;
		}
		base.Start();
	}

	protected virtual void \u02B8\u02B2\u02BB\u02BF\u02BF\u02BF\u02C0\u02BE\u02BD\u02B9\u02B8()
	{
		this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 = -1;
		this.gameManager._basePlayer.\u02B8\u02BF\u02C0\u02BE\u02B2\u02BA\u02C0\u02B5\u02BE\u02B7\u02BD();
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02C0\u02B7\u02BA\u02BC\u02B8\u02B2\u02B7\u02BB\u02B4\u02B7();
		this.gameManager.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB = 1053.0;
		if (this.gameManager._basePlayer.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0 == null || this.gameManager._basePlayer.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count != this.gameManager._basePlayer.\u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count)
		{
			this.gameManager._basePlayer.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0 = new List<Note>(this.gameManager._basePlayer.\u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0);
			this.gameManager._basePlayer.\u02B2\u02BB\u02B3\u02B8\u02B5\u02B2\u02C0\u02BF\u02BA\u02B4\u02BC = this.gameManager._basePlayer.\u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2.\u02B2\u02BB\u02B3\u02B8\u02B5\u02B2\u02C0\u02BF\u02BA\u02B4\u02BC;
			this.gameManager._basePlayer.\u02B4\u02B7\u02BC\u02C1\u02B2\u02B8\u02B2\u02BD\u02BD\u02BC\u02BF = this.gameManager._basePlayer.\u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2.\u02B4\u02B7\u02BC\u02C1\u02B2\u02B8\u02B2\u02BD\u02BD\u02BC\u02BF;
			this.gameManager._basePlayer.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2 = this.gameManager._basePlayer.\u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2;
		}
		this.gameManager.\u02B4\u02BD\u02BF\u02BD\u02BB\u02BC\u02C0\u02BC\u02BA\u02B5\u02B4(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		this.gameManager.\u02BC\u02B4\u02B9\u02BC\u02B8\u02B6\u02B5\u02BE\u02C0\u02BA\u02B6();
		this.practiceHUD.SetActive(false);
		base.OnEnable();
	}

	protected virtual void \u02BE\u02B3\u02BE\u02BF\u02BD\u02BD\u02BC\u02B3\u02B5\u02B8\u02BB()
	{
		int i = 0;
		if (this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 >= 1 && this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 > this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4)
		{
			this.textboxes[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9, Color.black, false);
			this.backgroundObjects[i].color = this.selected;
			i++;
		}
		while (i < this.textboxes.Length)
		{
			int num = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 + i;
			if (num >= this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count)
			{
				break;
			}
			bool flag = this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 < 1 || (num >= this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 && num < base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC) || num > this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 || num > base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC;
			this.textboxes[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[num].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9, (i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 || flag) ? Color.black : Color.white, i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3);
			this.backgroundObjects[i].color = ((i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3) ? this.defaultColor : (flag ? this.selected : this.highlightColor));
			i += 0;
		}
	}

	protected virtual void \u02C0\u02B7\u02BF\u02BC\u02C1\u02B4\u02B3\u02B9\u02C0\u02B3\u02B7()
	{
		if (this.gameManager)
		{
			this.gameManager.\u02BB\u02BF\u02B5\u02BD\u02B5\u02B2\u02C0\u02BF\u02B8\u02BB\u02B8();
		}
		this.practiceHUD.SetActive(true);
		base.OnDisable();
	}

	public virtual void \u02B4\u02B9\u02C0\u02BC\u02BA\u02BA\u02BD\u02C0\u02B4\u02B2\u02BA()
	{
		if (this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 == -1)
		{
			this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 = base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC;
		}
		else
		{
			this.gameManager.\u02B7\u02C0\u02BD\u02BF\u02BA\u02BF\u02BC\u02B6\u02B4\u02B9\u02BD = (this.gameManager.\u02B6\u02BB\u02B9\u02B3\u02B5\u02BD\u02BF\u02BD\u02B5\u02B7\u02B8 = 1U);
			if (base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC > this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4)
			{
				this.gameManager.\u02B8\u02B5\u02B9\u02BB\u02B4\u02B2\u02BE\u02BC\u02B4\u02BD\u02B8(this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4, base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC - this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4, true);
			}
			else
			{
				this.gameManager.\u02B9\u02C0\u02B4\u02B4\u02C0\u02B2\u02BC\u02BA\u02BB\u02B6\u02B9(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC, this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 - base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC, true);
			}
			this.gameManager.\u02BE\u02BD\u02BD\u02B9\u02BD\u02BF\u02B3\u02BE\u02BD\u02BB\u02BC();
			this.gameManager.\u02B6\u02B4\u02B8\u02B9\u02BC\u02B5\u02B8\u02B4\u02B3\u02BB\u02B6();
			this.gameManager.\u02BF\u02B3\u02C1\u02B2\u02BA\u02B4\u02B8\u02BF\u02BD\u02C0\u02B8 = true;
		}
		base.\u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3();
	}

	protected virtual void \u02BB\u02BD\u02BE\u02B8\u02BF\u02BA\u02BC\u02BF\u02BF\u02B4\u02B3()
	{
		if (this.gameManager)
		{
			this.gameManager.\u02C0\u02BF\u02BC\u02B5\u02B7\u02B2\u02B8\u02BC\u02B7\u02B9\u02B7();
		}
		this.practiceHUD.SetActive(true);
		base.OnDisable();
	}

	protected virtual void \u02BE\u02BA\u02BF\u02B7\u02B4\u02B4\u02B7\u02BA\u02BC\u02B5\u02BC()
	{
		int i = 0;
		if (this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 >= 1 && this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 > this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4)
		{
			this.textboxes[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9, Color.black, false);
			this.backgroundObjects[i].color = this.selected;
			i++;
		}
		while (i < this.textboxes.Length)
		{
			int num = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 + i;
			if (num >= this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count)
			{
				break;
			}
			bool flag = this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 < 0 || (num >= this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 && num < base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC) || (num <= this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 && num > base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
			this.textboxes[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD[num].\u02B4\u02B7\u02BC\u02B3\u02B6\u02C1\u02B4\u02BA\u02BB\u02B4\u02B9, (i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 || flag) ? Color.black : Color.white, i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3);
			this.backgroundObjects[i].color = ((i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3) ? this.defaultColor : (flag ? this.selected : this.highlightColor));
			i += 0;
		}
	}

	protected override void OnEnable()
	{
		this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 = -1;
		this.gameManager._basePlayer.\u02B8\u02BF\u02C0\u02BE\u02B2\u02BA\u02C0\u02B5\u02BE\u02B7\u02BD();
		FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02C0\u02B2\u02BF\u02C0\u02BA\u02C0\u02BB\u02B4\u02BC\u02BE();
		this.gameManager.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB = 0.0;
		if (this.gameManager._basePlayer.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0 == null || this.gameManager._basePlayer.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count != this.gameManager._basePlayer.\u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count)
		{
			this.gameManager._basePlayer.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0 = new List<Note>(this.gameManager._basePlayer.\u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0);
			this.gameManager._basePlayer.\u02B2\u02BB\u02B3\u02B8\u02B5\u02B2\u02C0\u02BF\u02BA\u02B4\u02BC = this.gameManager._basePlayer.\u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2.\u02B2\u02BB\u02B3\u02B8\u02B5\u02B2\u02C0\u02BF\u02BA\u02B4\u02BC;
			this.gameManager._basePlayer.\u02B4\u02B7\u02BC\u02C1\u02B2\u02B8\u02B2\u02BD\u02BD\u02BC\u02BF = this.gameManager._basePlayer.\u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2.\u02B4\u02B7\u02BC\u02C1\u02B2\u02B8\u02B2\u02BD\u02BD\u02BC\u02BF;
			this.gameManager._basePlayer.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2 = this.gameManager._basePlayer.\u02BB\u02B5\u02C1\u02BC\u02C1\u02BA\u02BB\u02BD\u02BB\u02BD\u02B2.\u02B5\u02BF\u02B6\u02B6\u02C1\u02B7\u02C1\u02C0\u02B3\u02B2\u02B2;
		}
		this.gameManager.\u02B4\u02BD\u02BF\u02BD\u02BB\u02BC\u02C0\u02BC\u02BA\u02B5\u02B4(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		this.gameManager.\u02BC\u02B4\u02B9\u02BC\u02B8\u02B6\u02B5\u02BE\u02C0\u02BA\u02B6();
		this.practiceHUD.SetActive(false);
		base.OnEnable();
	}

	public override void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
		this.gameManager.\u02B4\u02BD\u02BF\u02BD\u02BB\u02BC\u02C0\u02BC\u02BA\u02B5\u02B4(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
	}

	public virtual void \u02B4\u02B4\u02B3\u02B5\u02B8\u02B2\u02BD\u02B8\u02BB\u02BC\u02B6()
	{
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
		this.gameManager.\u02B4\u02BD\u02BF\u02BD\u02BB\u02BC\u02C0\u02BC\u02BA\u02B5\u02B4(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
	}

	protected override void Update()
	{
		base.Update();
		this.gameManager.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0() / (double)SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.GetFloatPercent;
		this.gameManager.\u02B3\u02BB\u02BE\u02BF\u02BA\u02BC\u02B5\u02C0\u02BB\u02BE\u02BD.\u02B9\u02BC\u02BB\u02C0\u02B2\u02B4\u02BB\u02BA\u02B5\u02BE\u02BC();
	}

	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		if (this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 == -1)
		{
			this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 = base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC;
		}
		else
		{
			this.gameManager.\u02B7\u02C0\u02BD\u02BF\u02BA\u02BF\u02BC\u02B6\u02B4\u02B9\u02BD = (this.gameManager.\u02B6\u02BB\u02B9\u02B3\u02B5\u02BD\u02BF\u02BD\u02B5\u02B7\u02B8 = 0U);
			if (base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC > this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4)
			{
				this.gameManager.\u02B9\u02C0\u02B4\u02B4\u02C0\u02B2\u02BC\u02BA\u02BB\u02B6\u02B9(this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4, base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC - this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4, true);
			}
			else
			{
				this.gameManager.\u02B9\u02C0\u02B4\u02B4\u02C0\u02B2\u02BC\u02BA\u02BB\u02B6\u02B9(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC, this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 - base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC, true);
			}
			this.gameManager.\u02BE\u02BD\u02BD\u02B9\u02BD\u02BF\u02B3\u02BE\u02BD\u02BB\u02BC();
			this.gameManager.\u02B6\u02B4\u02B8\u02B9\u02BC\u02B5\u02B8\u02B4\u02B3\u02BB\u02B6();
			this.gameManager.\u02BF\u02B3\u02C1\u02B2\u02BA\u02B4\u02B8\u02BF\u02BD\u02C0\u02B8 = false;
		}
		base.\u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3();
	}

	protected virtual void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD = this.gameManager.song.\u02B2\u02B5\u02B9\u02BC\u02B2\u02BE\u02BF\u02BC\u02B5\u02BD\u02C1;
		this.pausedText.text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().GetString("No");
		this.menuStrings = new string[this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count];
		for (int i = this.\u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD.Count; i < this.textboxes.Length; i += 0)
		{
			this.textboxes[i].\u02BA\u02BC\u02BD\u02B4\u02B3\u02B9\u02B2\u02B4\u02C0\u02B5\u02B5("BaseAnimationBackwards", true);
			this.backgroundObjects[i].color = Color.clear;
		}
		base.Start();
	}

	public virtual void \u02B9\u02B4\u02B7\u02BB\u02B3\u02B2\u02B7\u02B2\u02B2\u02B2\u02B5()
	{
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
		this.gameManager.\u02B9\u02C0\u02BF\u02C1\u02B6\u02BA\u02C0\u02BB\u02BE\u02B4\u02B7(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
	}

	public override void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
		this.gameManager.\u02B4\u02BD\u02BF\u02BD\u02BB\u02BC\u02C0\u02BC\u02BA\u02B5\u02B4(base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
	}

	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		if (this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 == -1)
		{
			if (this.gameManager.\u02C1\u02BD\u02B7\u02B4\u02BF\u02B3\u02C0\u02BA\u02B6\u02B4\u02C1 == -2)
			{
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = true;
				BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 = !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BA\u02BB\u02B8\u02B9\u02C0\u02BD\u02B5\u02B4\u02B6\u02B3;
				this.gameManager.gameObject.GetComponent<ScoreManager>().enabled = false;
				FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Main Menu", 0f);
			}
			else
			{
				this.pauseMenu.\u02B7\u02BE\u02BF\u02BB\u02B2\u02B6\u02BE\u02BB\u02B3\u02C1\u02B8();
				base.gameObject.SetActive(false);
			}
		}
		else
		{
			this.\u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 = -1;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
	}

	[SerializeField]
	private GameManager gameManager;

	private int \u02BF\u02BD\u02B9\u02B2\u02B7\u02BE\u02C0\u02BB\u02BE\u02BF\u02B4 = -1;

	[SerializeField]
	private PauseMenu pauseMenu;

	[SerializeField]
	private TextMeshProUGUI pausedText;

	[SerializeField]
	private ScrollingText[] textboxes;

	[SerializeField]
	private GameObject practiceHUD;

	private List<\u02B8\u02BB\u02B2\u02B5\u02C1\u02C1\u02BB\u02B7\u02B3\u02B4\u02B6> \u02B4\u02BD\u02B7\u02B7\u02B6\u02BC\u02BB\u02B4\u02B3\u02B2\u02BD;

	[SerializeField]
	private Color selected;
}
