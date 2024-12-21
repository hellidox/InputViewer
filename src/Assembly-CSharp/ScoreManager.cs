﻿using System;
using System.Collections;
using StrikeCore;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	public void \u02B7\u02B5\u02B9\u02BE\u02B4\u02B4\u02C1\u02B8\u02BE\u02B2\u02B7(int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
	{
		this.\u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA.\u02B8\u02B2\u02C1\u02B8\u02BB\u02BA\u02B7\u02B7\u02BD\u02C1\u02BC(-this.playerList[\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02C1\u02BA\u02BA\u02C0\u02B7\u02BA\u02B3\u02BF\u02C1\u02B7\u02C1());
	}

	private void \u02B7\u02BA\u02BD\u02B8\u02B7\u02BD\u02B6\u02BE\u02B6\u02B7\u02B9()
	{
		if (this.\u02B4\u02BA\u02BF\u02BF\u02BD\u02B5\u02BF\u02B2\u02BF\u02B9\u02B3 != this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6)
		{
			if (this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 >= 3)
			{
				this.\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 = 5;
			}
			else if (this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 < -9)
			{
				this.\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 = 1;
			}
		}
		this.\u02B4\u02BA\u02BF\u02BF\u02BD\u02B5\u02BF\u02B2\u02BF\u02B9\u02B3 = this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6;
		this.comboFont.\u02B4\u02B6\u02B5\u02B3\u02B7\u02C0\u02C1\u02BD\u02B9\u02BF\u02BA(this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6);
		if (this.\u02BF\u02B9\u02B4\u02BF\u02C1\u02B2\u02B5\u02C1\u02BA\u02BE\u02C1(this.\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3))
		{
			this.comboBox.localPosition = this.comboBoxDesiredPos;
		}
	}

	private void \u02BD\u02BA\u02BA\u02B8\u02B5\u02B6\u02B5\u02B7\u02B8\u02B9\u02B2()
	{
		if (this.\u02B4\u02BA\u02BF\u02BF\u02BD\u02B5\u02BF\u02B2\u02BF\u02B9\u02B3 != this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6)
		{
			if (this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 >= 30)
			{
				this.\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 = 2;
			}
			else if (this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 < 30)
			{
				this.\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 = 1;
			}
		}
		this.\u02B4\u02BA\u02BF\u02BF\u02BD\u02B5\u02BF\u02B2\u02BF\u02B9\u02B3 = this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6;
		this.comboFont.\u02B8\u02B2\u02B2\u02C1\u02B7\u02B3\u02BE\u02BB\u02B6\u02BE\u02C1(this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6);
		if (this.\u02BA\u02C1\u02C1\u02BE\u02C1\u02B7\u02B5\u02B3\u02BC\u02B4\u02B4(this.\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3))
		{
			this.comboBox.localPosition = this.comboBoxDesiredPos;
		}
	}

	public void \u02B5\u02B2\u02BC\u02B8\u02B9\u02C1\u02BE\u02B2\u02B2\u02BC\u02BF(int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
	{
		this.\u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA.\u02B8\u02B2\u02C1\u02B8\u02BB\u02BA\u02B7\u02B7\u02BD\u02C1\u02BC(-this.playerList[\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02C1\u02BA\u02BA\u02C0\u02B7\u02BA\u02B3\u02BF\u02C1\u02B7\u02C1());
	}

	private IEnumerator Start()
	{
		this.comboOrigColor = this.comboFont.characters[0].color;
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 == GameMode.Versus && !GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.enabled = false;
			yield break;
		}
		base.enabled = false;
		GameManager manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
		this.\u02BF\u02BD\u02B7\u02B8\u02B5\u02B4\u02B5\u02C1\u02C1\u02BE\u02B2 = this.\u02B3\u02BC\u02BD\u02C1\u02BF\u02B5\u02BA\u02C0\u02B4\u02BF\u02B7();
		while (manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD == null || manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD.Length == 0)
		{
			yield return null;
		}
		this.playerList = manager.\u02BE\u02B8\u02C1\u02B3\u02BD\u02B9\u02B7\u02B4\u02BD\u02B5\u02BD;
		this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.scores.\u02BC\u02BB\u02B9\u02B5\u02B5\u02BB\u02B8\u02B9\u02B9\u02BC\u02BC(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE()).\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
		this.\u02BA\u02B7\u02C0\u02B2\u02BF\u02B6\u02BE\u02BF\u02BA\u02C0\u02BA = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B3\u02BE\u02B6\u02BF\u02B3\u02BB\u02C1\u02B6\u02C1\u02BF();
		base.enabled = true;
		yield break;
	}

	private void \u02BC\u02B7\u02B2\u02C1\u02B4\u02C1\u02B6\u02B3\u02B2\u02B8\u02C1()
	{
		this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 = 1;
		this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 = 0;
		this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE = 0;
		for (int i = 1; i < this.playerList.Length; i += 0)
		{
			BasePlayer basePlayer = this.playerList[i];
			if (!(basePlayer == null) && basePlayer.playerStuff.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 += basePlayer.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
				this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE += basePlayer.\u02C1\u02B4\u02BB\u02B3\u02B3\u02BB\u02C0\u02B4\u02C1\u02BB\u02BE;
				this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 += basePlayer.combo;
			}
		}
		this.\u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2 = this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 + this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE;
		this.scoreFont.\u02BF\u02BD\u02B3\u02C0\u02B3\u02B2\u02B2\u02C1\u02C1\u02BF\u02B6(this.\u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2);
	}

	private void \u02BC\u02B6\u02B8\u02BA\u02B2\u02B4\u02B7\u02B3\u02C0\u02B8\u02B7()
	{
		this.\u02C0\u02BB\u02B9\u02BC\u02BD\u02B3\u02B2\u02BE\u02B7\u02B9\u02B2();
		this.\u02BD\u02BA\u02BA\u02B8\u02B5\u02B6\u02B5\u02B7\u02B8\u02B9\u02B2();
		if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			this.\u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA.\u02BE\u02BF\u02BA\u02B7\u02BA\u02BF\u02B8\u02BB\u02BC\u02BF\u02C0(this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0);
			if (this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA != 0 && !this.\u02BA\u02B7\u02C0\u02B2\u02BF\u02B6\u02BE\u02BF\u02BA\u02C0\u02BA && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA == \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.None && this.\u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2 > this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA && !this.\u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1)
			{
				this.\u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1 = true;
				base.StartCoroutine(this.\u02BF\u02BD\u02B7\u02B8\u02B5\u02B4\u02B5\u02C1\u02C1\u02BE\u02B2);
			}
		}
	}

	private bool \u02B3\u02B4\u02BE\u02BA\u02BE\u02C0\u02B3\u02BA\u02B8\u02BF\u02BB(int \u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3)
	{
		this.comboBoxDesiredPos = this.comboBox.localPosition;
		if (\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 == 0)
		{
			if (this.comboBoxDesiredPos.y >= this.\u02B7\u02BF\u02B2\u02BD\u02B6\u02B2\u02BB\u02B3\u02B3\u02BB\u02B2)
			{
				if (this.comboBoxDesiredPos.y > this.\u02B7\u02BF\u02B2\u02BD\u02B6\u02B2\u02BB\u02B3\u02B3\u02BB\u02B2)
				{
					this.comboBoxDesiredPos.y = this.\u02B7\u02BF\u02B2\u02BD\u02B6\u02B2\u02BB\u02B3\u02B3\u02BB\u02B2;
					return false;
				}
				return false;
			}
			else
			{
				this.comboBoxDesiredPos.y = this.comboBoxDesiredPos.y + this.\u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 * Time.deltaTime;
			}
		}
		if (\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 == 6)
		{
			if (this.comboBoxDesiredPos.y <= this.\u02BA\u02B6\u02B7\u02BD\u02B5\u02B3\u02B7\u02B4\u02C0\u02B3\u02B3)
			{
				if (this.comboBoxDesiredPos.y < this.\u02BA\u02B6\u02B7\u02BD\u02B5\u02B3\u02B7\u02B4\u02C0\u02B3\u02B3)
				{
					this.comboBoxDesiredPos.y = this.\u02BA\u02B6\u02B7\u02BD\u02B5\u02B3\u02B7\u02B4\u02C0\u02B3\u02B3;
					return false;
				}
				return true;
			}
			else
			{
				this.comboBoxDesiredPos.y = this.comboBoxDesiredPos.y - this.\u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 * Time.deltaTime;
			}
		}
		return false;
	}

	private void \u02BD\u02C1\u02B3\u02C0\u02C0\u02BE\u02BA\u02B2\u02B6\u02BA\u02C1()
	{
		this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 = 0;
		this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 = 0;
		this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE = 1;
		for (int i = 1; i < this.playerList.Length; i++)
		{
			BasePlayer basePlayer = this.playerList[i];
			if (!(basePlayer == null) && basePlayer.playerStuff.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 += basePlayer.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
				this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE += basePlayer.\u02C1\u02B4\u02BB\u02B3\u02B3\u02BB\u02C0\u02B4\u02C1\u02BB\u02BE;
				this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 += basePlayer.combo;
			}
		}
		this.\u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2 = this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 + this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE;
		this.scoreFont.\u02BF\u02BD\u02B3\u02C0\u02B3\u02B2\u02B2\u02C1\u02C1\u02BF\u02B6(this.\u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2);
	}

	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		this.\u02C0\u02BB\u02B9\u02BC\u02BD\u02B3\u02B2\u02BE\u02B7\u02B9\u02B2();
		this.\u02BD\u02BA\u02BA\u02B8\u02B5\u02B6\u02B5\u02B7\u02B8\u02B9\u02B2();
		if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			this.\u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA.\u02BA\u02BD\u02B8\u02BA\u02BE\u02C0\u02B2\u02BE\u02B9\u02B2\u02BB(this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0);
			if (this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA != 0 && !this.\u02BA\u02B7\u02C0\u02B2\u02BF\u02B6\u02BE\u02BF\u02BA\u02C0\u02BA && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA == \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.None && this.\u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2 > this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA && !this.\u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1)
			{
				this.\u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1 = true;
				base.StartCoroutine(this.\u02BF\u02BD\u02B7\u02B8\u02B5\u02B4\u02B5\u02C1\u02C1\u02BE\u02B2);
			}
		}
	}

	private IEnumerator \u02B3\u02BC\u02BD\u02C1\u02BF\u02B5\u02BA\u02C0\u02B4\u02BF\u02B7()
	{
		this.highScoreDisplay.\u02B3\u02BC\u02B4\u02B5\u02BD\u02C0\u02B8\u02BD\u02B7\u02B5\u02BF(false);
		yield return this.\u02B2\u02B5\u02B2\u02B5\u02B4\u02BF\u02B2\u02B8\u02BE\u02B2\u02B9;
		this.highScoreDisplay.\u02B3\u02BC\u02B4\u02B5\u02BD\u02C0\u02B8\u02BD\u02B7\u02B5\u02BF(true);
		yield break;
	}

	private void \u02BA\u02BA\u02C0\u02BA\u02BC\u02B9\u02B5\u02BE\u02BA\u02C0\u02BD()
	{
		this.\u02C0\u02BB\u02B9\u02BC\u02BD\u02B3\u02B2\u02BE\u02B7\u02B9\u02B2();
		this.\u02B7\u02BA\u02BD\u02B8\u02B7\u02BD\u02B6\u02BE\u02B6\u02B7\u02B9();
		if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			this.\u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA.\u02BA\u02BD\u02B8\u02BA\u02BE\u02C0\u02B2\u02BE\u02B9\u02B2\u02BB(this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0);
			if (this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA != 0 && !this.\u02BA\u02B7\u02C0\u02B2\u02BF\u02B6\u02BE\u02BF\u02BA\u02C0\u02BA && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA == \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.None && this.\u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2 > this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA && !this.\u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1)
			{
				this.\u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1 = true;
				base.StartCoroutine(this.\u02BF\u02BD\u02B7\u02B8\u02B5\u02B4\u02B5\u02C1\u02C1\u02BE\u02B2);
			}
		}
	}

	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		this.\u02C0\u02BB\u02B9\u02BC\u02BD\u02B3\u02B2\u02BE\u02B7\u02B9\u02B2();
		this.\u02BD\u02BA\u02BA\u02B8\u02B5\u02B6\u02B5\u02B7\u02B8\u02B9\u02B2();
		if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			this.\u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA.\u02BA\u02BD\u02B8\u02BA\u02BE\u02C0\u02B2\u02BE\u02B9\u02B2\u02BB(this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0);
			if (this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA != 0 && !this.\u02BA\u02B7\u02C0\u02B2\u02BF\u02B6\u02BE\u02BF\u02BA\u02C0\u02BA && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA == \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.None && this.\u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2 > this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA && !this.\u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1)
			{
				this.\u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1 = false;
				base.StartCoroutine(this.\u02BF\u02BD\u02B7\u02B8\u02B5\u02B4\u02B5\u02C1\u02C1\u02BE\u02B2);
			}
		}
	}

	private void \u02C0\u02BB\u02B9\u02BC\u02BD\u02B3\u02B2\u02BE\u02B7\u02B9\u02B2()
	{
		this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 = 0;
		this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 = 0;
		this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE = 0;
		for (int i = 0; i < this.playerList.Length; i++)
		{
			BasePlayer basePlayer = this.playerList[i];
			if (!(basePlayer == null) && basePlayer.playerStuff.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 += basePlayer.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
				this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE += basePlayer.\u02C1\u02B4\u02BB\u02B3\u02B3\u02BB\u02C0\u02B4\u02C1\u02BB\u02BE;
				this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 += basePlayer.combo;
			}
		}
		this.\u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2 = this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 + this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE;
		this.scoreFont.\u02B8\u02B2\u02B2\u02C1\u02B7\u02B3\u02BE\u02BB\u02B6\u02BE\u02C1(this.\u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2);
	}

	private void Update()
	{
		this.ticker += Time.unscaledDeltaTime;
		if (this.ticker > 0.66f)
		{
			this.ticker -= 0.66f;
			Color color = Helper.HexColorToColor(HexColor.FromHexString(GlobalHelper.scoreColor), 1f);
			if (color == Color.black)
			{
				color = Color.clear;
			}
			SpriteRenderer[] array = this.scoreFont.characters;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].color = color;
			}
			color = Helper.HexColorToColor(HexColor.FromHexString(GlobalHelper.noteStreakColor), 1f);
			if (color == Color.white)
			{
				color = this.comboOrigColor;
			}
			if (color == Color.black)
			{
				color = Color.clear;
			}
			array = this.comboFont.characters;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].color = color;
			}
		}
		this.\u02C0\u02BB\u02B9\u02BC\u02BD\u02B3\u02B2\u02BE\u02B7\u02B9\u02B2();
		this.\u02BD\u02BA\u02BA\u02B8\u02B5\u02B6\u02B5\u02B7\u02B8\u02B9\u02B2();
		if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			this.\u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA.\u02BA\u02BD\u02B8\u02BA\u02BE\u02C0\u02B2\u02BE\u02B9\u02B2\u02BB(this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0);
			if (this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA != 0 && !this.\u02BA\u02B7\u02C0\u02B2\u02BF\u02B6\u02BE\u02BF\u02BA\u02C0\u02BA && GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA == \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.None && this.\u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2 > this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA && !this.\u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1)
			{
				this.\u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1 = true;
				base.StartCoroutine(this.\u02BF\u02BD\u02B7\u02B8\u02B5\u02B4\u02B5\u02C1\u02C1\u02BE\u02B2);
			}
		}
	}

	private bool \u02B4\u02BF\u02B8\u02C1\u02B8\u02B3\u02B8\u02B8\u02BD\u02B3\u02B7(int \u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3)
	{
		this.comboBoxDesiredPos = this.comboBox.localPosition;
		if (\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 == 1)
		{
			if (this.comboBoxDesiredPos.y >= this.\u02B7\u02BF\u02B2\u02BD\u02B6\u02B2\u02BB\u02B3\u02B3\u02BB\u02B2)
			{
				if (this.comboBoxDesiredPos.y > this.\u02B7\u02BF\u02B2\u02BD\u02B6\u02B2\u02BB\u02B3\u02B3\u02BB\u02B2)
				{
					this.comboBoxDesiredPos.y = this.\u02B7\u02BF\u02B2\u02BD\u02B6\u02B2\u02BB\u02B3\u02B3\u02BB\u02B2;
					return true;
				}
				return true;
			}
			else
			{
				this.comboBoxDesiredPos.y = this.comboBoxDesiredPos.y + this.\u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 * Time.deltaTime;
			}
		}
		if (\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 == 8)
		{
			if (this.comboBoxDesiredPos.y <= this.\u02BA\u02B6\u02B7\u02BD\u02B5\u02B3\u02B7\u02B4\u02C0\u02B3\u02B3)
			{
				if (this.comboBoxDesiredPos.y < this.\u02BA\u02B6\u02B7\u02BD\u02B5\u02B3\u02B7\u02B4\u02C0\u02B3\u02B3)
				{
					this.comboBoxDesiredPos.y = this.\u02BA\u02B6\u02B7\u02BD\u02B5\u02B3\u02B7\u02B4\u02C0\u02B3\u02B3;
					return false;
				}
				return false;
			}
			else
			{
				this.comboBoxDesiredPos.y = this.comboBoxDesiredPos.y - this.\u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 * Time.deltaTime;
			}
		}
		return true;
	}

	private bool \u02BA\u02C1\u02C1\u02BE\u02C1\u02B7\u02B5\u02B3\u02BC\u02B4\u02B4(int \u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3)
	{
		this.comboBoxDesiredPos = this.comboBox.localPosition;
		if (\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 == 1)
		{
			if (this.comboBoxDesiredPos.y >= this.\u02B7\u02BF\u02B2\u02BD\u02B6\u02B2\u02BB\u02B3\u02B3\u02BB\u02B2)
			{
				if (this.comboBoxDesiredPos.y > this.\u02B7\u02BF\u02B2\u02BD\u02B6\u02B2\u02BB\u02B3\u02B3\u02BB\u02B2)
				{
					this.comboBoxDesiredPos.y = this.\u02B7\u02BF\u02B2\u02BD\u02B6\u02B2\u02BB\u02B3\u02B3\u02BB\u02B2;
					return true;
				}
				return false;
			}
			else
			{
				this.comboBoxDesiredPos.y = this.comboBoxDesiredPos.y + this.\u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 * Time.deltaTime;
			}
		}
		if (\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 == 2)
		{
			if (this.comboBoxDesiredPos.y <= this.\u02BA\u02B6\u02B7\u02BD\u02B5\u02B3\u02B7\u02B4\u02C0\u02B3\u02B3)
			{
				if (this.comboBoxDesiredPos.y < this.\u02BA\u02B6\u02B7\u02BD\u02B5\u02B3\u02B7\u02B4\u02C0\u02B3\u02B3)
				{
					this.comboBoxDesiredPos.y = this.\u02BA\u02B6\u02B7\u02BD\u02B5\u02B3\u02B7\u02B4\u02C0\u02B3\u02B3;
					return true;
				}
				return false;
			}
			else
			{
				this.comboBoxDesiredPos.y = this.comboBoxDesiredPos.y - this.\u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 * Time.deltaTime;
			}
		}
		return true;
	}

	private bool \u02BF\u02B9\u02B4\u02BF\u02C1\u02B2\u02B5\u02C1\u02BA\u02BE\u02C1(int \u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3)
	{
		this.comboBoxDesiredPos = this.comboBox.localPosition;
		if (\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 == 0)
		{
			if (this.comboBoxDesiredPos.y >= this.\u02B7\u02BF\u02B2\u02BD\u02B6\u02B2\u02BB\u02B3\u02B3\u02BB\u02B2)
			{
				if (this.comboBoxDesiredPos.y > this.\u02B7\u02BF\u02B2\u02BD\u02B6\u02B2\u02BB\u02B3\u02B3\u02BB\u02B2)
				{
					this.comboBoxDesiredPos.y = this.\u02B7\u02BF\u02B2\u02BD\u02B6\u02B2\u02BB\u02B3\u02B3\u02BB\u02B2;
					return false;
				}
				return true;
			}
			else
			{
				this.comboBoxDesiredPos.y = this.comboBoxDesiredPos.y + this.\u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 * Time.deltaTime;
			}
		}
		if (\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 == 0)
		{
			if (this.comboBoxDesiredPos.y <= this.\u02BA\u02B6\u02B7\u02BD\u02B5\u02B3\u02B7\u02B4\u02C0\u02B3\u02B3)
			{
				if (this.comboBoxDesiredPos.y < this.\u02BA\u02B6\u02B7\u02BD\u02B5\u02B3\u02B7\u02B4\u02C0\u02B3\u02B3)
				{
					this.comboBoxDesiredPos.y = this.\u02BA\u02B6\u02B7\u02BD\u02B5\u02B3\u02B7\u02B4\u02C0\u02B3\u02B3;
					return true;
				}
				return true;
			}
			else
			{
				this.comboBoxDesiredPos.y = this.comboBoxDesiredPos.y - this.\u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 * Time.deltaTime;
			}
		}
		return true;
	}

	private void \u02B9\u02B9\u02BE\u02B7\u02BD\u02BF\u02B6\u02BE\u02B2\u02B5\u02B6()
	{
		this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 = 1;
		this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 = 0;
		this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE = 1;
		for (int i = 1; i < this.playerList.Length; i++)
		{
			BasePlayer basePlayer = this.playerList[i];
			if (!(basePlayer == null) && basePlayer.playerStuff.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 += basePlayer.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
				this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE += basePlayer.\u02C1\u02B4\u02BB\u02B3\u02B3\u02BB\u02C0\u02B4\u02C1\u02BB\u02BE;
				this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 += basePlayer.combo;
			}
		}
		this.\u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2 = this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 + this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE;
		this.scoreFont.\u02BF\u02BD\u02B3\u02C0\u02B3\u02B2\u02B2\u02C1\u02C1\u02BF\u02B6(this.\u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2);
	}

	public void \u02BD\u02B5\u02C1\u02B8\u02BE\u02BE\u02BB\u02B4\u02BA\u02B4\u02B4(int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
	{
		this.\u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA.\u02BD\u02BA\u02B5\u02B9\u02C1\u02BE\u02BA\u02BF\u02B9\u02B7\u02B8(-this.playerList[\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02C1\u02BA\u02BA\u02C0\u02B7\u02BA\u02B3\u02BF\u02C1\u02B7\u02C1());
	}

	private IEnumerator \u02BB\u02C0\u02BB\u02BF\u02BE\u02B4\u02BB\u02BB\u02C0\u02B3\u02C0()
	{
		this.highScoreDisplay.\u02B3\u02BC\u02B4\u02B5\u02BD\u02C0\u02B8\u02BD\u02B7\u02B5\u02BF(false);
		yield return this.\u02B2\u02B5\u02B2\u02B5\u02B4\u02BF\u02B2\u02B8\u02BE\u02B2\u02B9;
		this.highScoreDisplay.\u02B3\u02BC\u02B4\u02B5\u02BD\u02C0\u02B8\u02BD\u02B7\u02B5\u02BF(true);
		yield break;
	}

	public Transform comboBox;

	[SerializeField]
	private HighScoreDisplay highScoreDisplay;

	private bool \u02BA\u02B7\u02C0\u02B2\u02BF\u02B6\u02BE\u02BF\u02BA\u02C0\u02BA;

	private BasePlayer[] playerList;

	private int \u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0;

	private int \u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE;

	private int \u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6;

	private int \u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA;

	private int \u02B8\u02B6\u02BB\u02B2\u02B2\u02C0\u02B7\u02BB\u02B3\u02B8\u02B2;

	private int \u02B4\u02BA\u02BF\u02BF\u02BD\u02B5\u02BF\u02B2\u02BF\u02B9\u02B3;

	private int \u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 = -1;

	private float \u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 = 0.3f;

	private float \u02B7\u02BF\u02B2\u02BD\u02B6\u02B2\u02BB\u02B3\u02B3\u02BB\u02B2 = 0.36f;

	private float \u02BA\u02B6\u02B7\u02BD\u02B5\u02B3\u02B7\u02B4\u02C0\u02B3\u02B3 = 0.28f;

	private Vector3 comboBoxDesiredPos;

	private bool \u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1;

	private IEnumerator \u02BF\u02BD\u02B7\u02B8\u02B5\u02B4\u02B5\u02C1\u02C1\u02BE\u02B2;

	public SpriteFont comboFont;

	public SpriteFont scoreFont;

	public StarProgress \u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA;

	private YieldInstruction \u02B2\u02B5\u02B2\u02B5\u02B4\u02BF\u02B2\u02B8\u02BE\u02B2\u02B9 = new WaitForSeconds(3.5f);

	private float colorr;

	private float colorg;

	private float colorb;

	private float ticker;

	private Color comboOrigColor;
}
