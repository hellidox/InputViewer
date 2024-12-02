using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cysharp.Text;
using TMPro;
using UnityEngine;

public class SongSelectSearch : MonoBehaviour
{
	private void \u02C0\u02B3\u02B2\u02B6\u02B3\u02B8\u02B8\u02C1\u02BE\u02B9\u02B3()
	{
		SongSelectSearch.\u02BF\u02BC\u02B9\u02C1\u02B8\u02C1\u02BF\u02BB\u02BF\u02B7\u02BB u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB = new SongSelectSearch.\u02BF\u02BC\u02B9\u02C1\u02B8\u02C1\u02BF\u02BB\u02BF\u02B7\u02BB();
		int num = -1;
		u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.text = this.searchText.text;
		Func<SongEntry, bool> func = new Func<SongEntry, bool>(SongSelectSearch.<>c.<>9.\u02BE\u02C1\u02B5\u02C0\u02B7\u02B7\u02B2\u02B4\u02BF\u02B9\u02BC);
		this.\u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB = true;
		if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 0)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02BE\u02B7\u02BE\u02B6\u02C1\u02B5\u02B5\u02B6\u02B6\u02B8\u02B2);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 1)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B4\u02C1\u02C0\u02B5\u02B6\u02BC\u02BA\u02BB\u02BE\u02BC\u02C1);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 1)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B2\u02BF\u02B5\u02B8\u02BA\u02B6\u02BF\u02B5\u02BD\u02BA\u02B9);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 8)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02BA\u02B2\u02BE\u02C1\u02B8\u02B3\u02BF\u02B4\u02BD\u02B6\u02B2);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 7)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B6\u02BF\u02B4\u02B6\u02B7\u02BD\u02BC\u02BC\u02B9\u02B3\u02B3);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 7)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B2\u02BC\u02C1\u02B3\u02BE\u02BF\u02C0\u02BF\u02C0\u02BC\u02B9);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 4)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02C1\u02B3\u02BF\u02B6\u02B4\u02B8\u02BC\u02BA\u02B8\u02B8\u02BA);
		}
		string text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(SongSelectSearch.\u02BF\u02BE\u02B6\u02BB\u02BF\u02B5\u02B4\u02BD\u02BD\u02BF\u02B5[SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4]) + "Setlist" + u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.text;
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BA\u02B5\u02C0\u02BE\u02BC\u02B5\u02BA\u02B2\u02B7\u02C0\u02B3.Contains(text))
		{
			return;
		}
		this.songSelect.\u02BA\u02B9\u02B3\u02B4\u02B4\u02BC\u02C0\u02C1\u02B6\u02BC\u02B6(func, text);
		SongEntry songEntry = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BF\u02BA\u02BD\u02BF\u02B3\u02BE\u02B4\u02BB\u02B3\u02BD\u02B3(func);
		if (songEntry != null)
		{
			num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BB\u02B3\u02B7\u02BB\u02B3\u02C1\u02B9\u02BF\u02C0\u02BF(songEntry);
		}
		this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(num, true);
	}

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			base.StartCoroutine(this.\u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7());
			return;
		}
		if (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyUp(KeyCode.KeypadEnter))
		{
			if (this.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3 && !this.\u02B3\u02BA\u02B9\u02BE\u02BC\u02C1\u02B2\u02BE\u02B2\u02BC\u02BA)
			{
				this.\u02BE\u02BC\u02B8\u02BF\u02C0\u02B2\u02BE\u02BD\u02BE\u02BF\u02B2();
			}
			base.StartCoroutine(this.\u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7());
			return;
		}
		if (Input.GetKeyUp(KeyCode.Tab))
		{
			SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4++;
			this.\u02B5\u02B8\u02BE\u02BB\u02C1\u02BD\u02B9\u02B9\u02BD\u02B5\u02B6();
			return;
		}
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B != null && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4 && (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(0) || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(1)))
			{
				base.StartCoroutine(this.\u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7());
				this.songSelect.\u02C1\u02B5\u02B9\u02B4\u02B9\u02B5\u02BC\u02B3\u02B4\u02C0\u02BF = true;
				return;
			}
		}
		foreach (char c in Input.inputString)
		{
			if (c == '\b' || c == '\u007f')
			{
				if (!this.\u02B3\u02BA\u02B9\u02BE\u02BC\u02C1\u02B2\u02BE\u02B2\u02BC\u02BA && this.searchText.text.Length != 0)
				{
					this.searchText.text = this.searchText.text.Substring(0, this.searchText.text.Length - 1);
					if (this.searchText.text == string.Empty)
					{
						this.\u02B2\u02BB\u02BE\u02B7\u02B6\u02B8\u02B4\u02B3\u02C1\u02BF\u02BB();
					}
					else
					{
						this.\u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB = true;
					}
				}
			}
			else if (c != '\n' && c != '\r')
			{
				if (this.\u02B3\u02BA\u02B9\u02BE\u02BC\u02C1\u02B2\u02BE\u02B2\u02BC\u02BA)
				{
					this.searchText.text = "";
					this.searchText.color = Color.yellow;
					this.\u02B3\u02BA\u02B9\u02BE\u02BC\u02C1\u02B2\u02BE\u02B2\u02BC\u02BA = false;
				}
				TextMeshProUGUI textMeshProUGUI = this.searchText;
				textMeshProUGUI.text += c.ToString();
				this.\u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB = true;
			}
		}
		if (this.\u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB && !this.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3)
		{
			this.\u02C0\u02BA\u02BB\u02BD\u02B3\u02BC\u02B7\u02B2\u02BD\u02B2\u02B3();
		}
	}

	private void \u02BD\u02B8\u02BD\u02B5\u02B6\u02B3\u02BF\u02B3\u02C1\u02B8\u02C1()
	{
		if (Input.GetKeyUp((KeyCode)69))
		{
			base.StartCoroutine(this.\u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7());
			return;
		}
		if (Input.GetKeyUp((KeyCode)(-38)) || Input.GetKeyUp(KeyCode.N))
		{
			if (this.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3 && !this.\u02B3\u02BA\u02B9\u02BE\u02BC\u02C1\u02B2\u02BE\u02B2\u02BC\u02BA)
			{
				this.\u02B3\u02B8\u02C0\u02B6\u02B3\u02C0\u02B2\u02C1\u02BD\u02BA\u02BE();
			}
			base.StartCoroutine(this.\u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7());
			return;
		}
		if (Input.GetKeyUp((KeyCode)(-115)))
		{
			SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4++;
			this.\u02C1\u02BE\u02BF\u02C0\u02BC\u02B7\u02BC\u02BC\u02BE\u02B5\u02BC();
			return;
		}
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B != null && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02B8\u02C0\u02BB\u02C0\u02BB\u02BB\u02BE\u02B3\u02BD\u02B2\u02B6() && (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(1) || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(0)))
			{
				base.StartCoroutine(this.\u02BD\u02BE\u02C0\u02BE\u02BB\u02B5\u02BE\u02BE\u02B3\u02BB\u02B4());
				this.songSelect.\u02C1\u02B5\u02B9\u02B4\u02B9\u02B5\u02BC\u02B3\u02B4\u02C0\u02BF = true;
				return;
			}
		}
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i++)
		{
			char c = inputString[i];
			if (c == '\0' || c == 'L')
			{
				if (!this.\u02B3\u02BA\u02B9\u02BE\u02BC\u02C1\u02B2\u02BE\u02B2\u02BC\u02BA && this.searchText.text.Length != 0)
				{
					this.searchText.text = this.searchText.text.Substring(1, this.searchText.text.Length - 1);
					if (this.searchText.text == string.Empty)
					{
						this.\u02B2\u02BB\u02BE\u02B7\u02B6\u02B8\u02B4\u02B3\u02C1\u02BF\u02BB();
					}
					else
					{
						this.\u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB = true;
					}
				}
			}
			else if (c != 'f' && c != '&')
			{
				if (this.\u02B3\u02BA\u02B9\u02BE\u02BC\u02C1\u02B2\u02BE\u02B2\u02BC\u02BA)
				{
					this.searchText.text = "Color Profile";
					this.searchText.color = Color.yellow;
					this.\u02B3\u02BA\u02B9\u02BE\u02BC\u02C1\u02B2\u02BE\u02B2\u02BC\u02BA = true;
				}
				TextMeshProUGUI textMeshProUGUI = this.searchText;
				textMeshProUGUI.text += c.ToString();
				this.\u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB = true;
			}
		}
		if (this.\u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB && !this.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3)
		{
			this.\u02B9\u02B2\u02BF\u02B5\u02BA\u02B8\u02C0\u02C0\u02BA\u02BE\u02B3();
		}
	}

	private void \u02C1\u02BE\u02BF\u02C0\u02BC\u02B7\u02BC\u02BC\u02BE\u02B5\u02BC()
	{
		if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 >= SongSelectSearch.\u02BF\u02BE\u02B6\u02BB\u02BF\u02B5\u02B4\u02BD\u02BD\u02BF\u02B5.Length)
		{
			SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 = 0;
		}
		Utf16ValueStringBuilder utf16ValueStringBuilder = ZString.CreateStringBuilder();
		utf16ValueStringBuilder.Append(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Gameplay"));
		utf16ValueStringBuilder.Append(": ");
		utf16ValueStringBuilder.Append(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(SongSelectSearch.\u02BF\u02BE\u02B6\u02BB\u02BF\u02B5\u02B4\u02BD\u02BD\u02BF\u02B5[SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4]));
		utf16ValueStringBuilder.Append("end_events");
		this.filterText.\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(utf16ValueStringBuilder);
		if (!this.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3)
		{
			this.\u02C0\u02BA\u02BB\u02BD\u02B3\u02BC\u02B7\u02B2\u02BD\u02B2\u02B3();
		}
	}

	private int \u02B6\u02BC\u02B4\u02BF\u02BA\u02B2\u02BE\u02C0\u02C0\u02B8\u02B3(string \u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0)
	{
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0);
		if (num <= 1642243064U)
		{
			if (num <= 472378208U)
			{
				if (num != 179739148U)
				{
					if (num == 472378208U)
					{
						if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "Genre")
						{
							return 5;
						}
					}
				}
				else if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "Album")
				{
					return 2;
				}
			}
			else if (num != 652943243U)
			{
				if (num == 1642243064U)
				{
					if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "Source")
					{
						return 6;
					}
				}
			}
			else if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "Playlist")
			{
				return 4;
			}
		}
		else if (num <= 2490816510U)
		{
			if (num != 2441828660U)
			{
				if (num == 2490816510U)
				{
					if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "Artist")
					{
						return 1;
					}
				}
			}
			else if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "Song")
			{
				return 0;
			}
		}
		else if (num != 2765706646U)
		{
			if (num == 2946403176U)
			{
				if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "Charter")
				{
					return 3;
				}
			}
		}
		else if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "Artist - Album")
		{
			return 1;
		}
		return 0;
	}

	private void \u02C0\u02BA\u02BB\u02BD\u02B3\u02BC\u02B7\u02B2\u02BD\u02B2\u02B3()
	{
		SongSelectSearch.\u02B3\u02BB\u02BA\u02B6\u02B9\u02B9\u02B5\u02BB\u02BC\u02BB\u02B2 u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B = new SongSelectSearch.\u02B3\u02BB\u02BA\u02B6\u02B9\u02B9\u02B5\u02BB\u02BC\u02BB\u02B2();
		int num = -1;
		u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.text = this.searchText.text;
		this.\u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB = false;
		if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 0)
		{
			Func<SongEntry, bool> func = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02BE\u02BD\u02BF\u02BB\u02BD\u02BE\u02B3\u02BE\u02BF\u02B2\u02B9);
			SongEntry songEntry = this.\u02B8\u02BE\u02BE\u02C1\u02B9\u02BC\u02B9\u02BF\u02B4\u02B4\u02B3(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02B6\u02BA\u02B7\u02B2\u02C0\u02BF\u02BF\u02B9\u02BA\u02BF, func);
			if (songEntry != null)
			{
				num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BB\u02B3\u02B7\u02BB\u02B3\u02C1\u02B9\u02BF\u02C0\u02BF(songEntry);
				int num2 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02BC\u02BF\u02B6\u02B5\u02BF\u02B6\u02B2\u02B6\u02BE\u02B4(num, 0);
				\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8 u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6[num2];
				if (u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE)
				{
					\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BC\u02C0\u02B5\u02BC\u02B9\u02BA\u02BC\u02BD\u02B7(u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B);
					this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
				}
			}
		}
		else
		{
			Func<SongEntry, bool> func2 = new Func<SongEntry, bool>(SongSelectSearch.<>c.<>9.\u02B6\u02BE\u02B6\u02B2\u02BA\u02B2\u02BE\u02B3\u02BD\u02BB\u02C0);
			if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 1)
			{
				func2 = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02B3\u02BE\u02BB\u02BA\u02B4\u02BF\u02BC\u02B4\u02B6\u02BD\u02B7);
			}
			else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 2)
			{
				func2 = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02BF\u02B8\u02B6\u02C0\u02B3\u02BE\u02C1\u02BC\u02B5\u02B7\u02B7);
			}
			else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 3)
			{
				func2 = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02BC\u02B3\u02B5\u02B6\u02BE\u02B7\u02BA\u02BA\u02B4\u02BA\u02BB);
			}
			else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 4)
			{
				func2 = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02B8\u02BC\u02BB\u02BC\u02BF\u02C0\u02B2\u02B4\u02B4\u02B7\u02B3);
			}
			else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 5)
			{
				func2 = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02BF\u02C0\u02BA\u02B9\u02B6\u02BC\u02BF\u02B3\u02B2\u02B8\u02B6);
			}
			else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 6)
			{
				func2 = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02BD\u02B3\u02B4\u02BF\u02BB\u02BA\u02B2\u02B6\u02BC\u02B5\u02BD);
			}
			SongEntry songEntry2 = this.\u02B8\u02BE\u02BE\u02C1\u02B9\u02BC\u02B9\u02BF\u02B4\u02B4\u02B3(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02B6\u02BA\u02B7\u02B2\u02C0\u02BF\u02BF\u02B9\u02BA\u02BF, func2);
			if (songEntry2 != null)
			{
				num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BB\u02B3\u02B7\u02BB\u02B3\u02C1\u02B9\u02BF\u02C0\u02BF(songEntry2);
				int num3 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02BC\u02BF\u02B6\u02B5\u02BF\u02B6\u02B2\u02B6\u02BE\u02B4(num, 0);
				\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8 u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B2 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6[num3];
				if (u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B2.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE)
				{
					\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BC\u02C0\u02B5\u02BC\u02B9\u02BA\u02BC\u02BD\u02B7(u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B2);
					this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
				}
			}
		}
		if (num != -1)
		{
			this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(num, true);
		}
	}

	private void \u02B9\u02B7\u02C0\u02B7\u02C1\u02BA\u02BC\u02C0\u02C1\u02BD\u02B6()
	{
		this.\u02B2\u02BB\u02BE\u02B7\u02B6\u02B8\u02B4\u02B3\u02C1\u02BF\u02BB();
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
		if (SettingsController.\u02B5\u02B9\u02BB\u02BB\u02BA\u02B3\u02B9\u02B2\u02B5\u02BD\u02BB)
		{
			SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 = this.\u02B6\u02BC\u02B4\u02BF\u02BA\u02B2\u02BE\u02C0\u02C0\u02B8\u02B3(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B2\u02BB\u02B2\u02BD\u02BA\u02C0\u02B2\u02B5\u02BC\u02B8[\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B4\u02B7\u02B2\u02BC\u02B8\u02B3\u02BA\u02BB\u02BC\u02B3]);
		}
		else
		{
			SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 = 1;
		}
		this.\u02C1\u02BE\u02BF\u02C0\u02BC\u02B7\u02BC\u02BC\u02BE\u02B5\u02BC();
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B8\u02B3\u02BB\u02B9\u02B3\u02BF\u02B3\u02C1\u02B5\u02BA\u02BA(false);
		this.pressEnterText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Gamepad Mode");
		this.changeSearchText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("playTime");
		if (this.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3)
		{
			this.songSelect.\u02B6\u02B3\u02B4\u02B6\u02C1\u02B4\u02C0\u02BA\u02BA\u02C1\u02C0(true);
		}
	}

	private void \u02B3\u02B8\u02C0\u02B6\u02B3\u02C0\u02B2\u02C1\u02BD\u02BA\u02BE()
	{
		SongSelectSearch.\u02BF\u02BC\u02B9\u02C1\u02B8\u02C1\u02BF\u02BB\u02BF\u02B7\u02BB u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB = new SongSelectSearch.\u02BF\u02BC\u02B9\u02C1\u02B8\u02C1\u02BF\u02BB\u02BF\u02B7\u02BB();
		int num = -1;
		u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.text = this.searchText.text;
		Func<SongEntry, bool> func = new Func<SongEntry, bool>(SongSelectSearch.<>c.<>9.\u02BE\u02C1\u02B5\u02C0\u02B7\u02B7\u02B2\u02B4\u02BF\u02B9\u02BC);
		this.\u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB = true;
		if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 0)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02BE\u02B7\u02BE\u02B6\u02C1\u02B5\u02B5\u02B6\u02B6\u02B8\u02B2);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 1)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B4\u02C1\u02C0\u02B5\u02B6\u02BC\u02BA\u02BB\u02BE\u02BC\u02C1);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 4)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B2\u02BF\u02B5\u02B8\u02BA\u02B6\u02BF\u02B5\u02BD\u02BA\u02B9);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 6)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02BA\u02B2\u02BE\u02C1\u02B8\u02B3\u02BF\u02B4\u02BD\u02B6\u02B2);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 3)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B6\u02BF\u02B4\u02B6\u02B7\u02BD\u02BC\u02BC\u02B9\u02B3\u02B3);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 1)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B2\u02BC\u02C1\u02B3\u02BE\u02BF\u02C0\u02BF\u02C0\u02BC\u02B9);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 8)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02C1\u02B3\u02BF\u02B6\u02B4\u02B8\u02BC\u02BA\u02B8\u02B8\u02BA);
		}
		string text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(SongSelectSearch.\u02BF\u02BE\u02B6\u02BB\u02BF\u02B5\u02B4\u02BD\u02BD\u02BF\u02B5[SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4]) + "No songs were found!" + u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.text;
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BA\u02B5\u02C0\u02BE\u02BC\u02B5\u02BA\u02B2\u02B7\u02C0\u02B3.Contains(text))
		{
			return;
		}
		this.songSelect.\u02BA\u02B9\u02B3\u02B4\u02B4\u02BC\u02C0\u02C1\u02B6\u02BC\u02B6(func, text);
		SongEntry songEntry = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BF\u02BA\u02BD\u02BF\u02B3\u02BE\u02B4\u02BB\u02B3\u02BD\u02B3(func);
		if (songEntry != null)
		{
			num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BB\u02B3\u02B7\u02BB\u02B3\u02C1\u02B9\u02BF\u02C0\u02BF(songEntry);
		}
		this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(num, false);
	}

	private IEnumerator \u02B3\u02BD\u02B5\u02B6\u02BC\u02B9\u02B2\u02C1\u02B5\u02BC\u02B7()
	{
		yield return null;
		base.gameObject.SetActive(false);
		if (this.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3)
		{
			this.songSelect.\u02B6\u02B3\u02B4\u02B6\u02C1\u02B4\u02C0\u02BA\u02BA\u02C1\u02C0(true);
		}
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(true);
		yield break;
	}

	private int \u02BA\u02B9\u02B7\u02BC\u02C1\u02BC\u02B4\u02BF\u02BE\u02C1\u02BF(string \u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0)
	{
		uint num = PrivateImplementationDetails.ComputeStringHash(\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0);
		if (num <= 1U)
		{
			if (num <= 124U)
			{
				if (num != 163U)
				{
					if (num == 78U)
					{
						if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "")
						{
							return 6;
						}
					}
				}
				else if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "Are you sure you want to disconnect?")
				{
					return 4;
				}
			}
			else if (num != 10U)
			{
				if (num == 4294967161U)
				{
					if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "Song Speed")
					{
						return 7;
					}
				}
			}
			else if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "Gameplay")
			{
				return 4;
			}
		}
		else if (num <= 4294967110U)
		{
			if (num != 4294967119U)
			{
				if (num == 4294967102U)
				{
					if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "online")
					{
						return 0;
					}
				}
			}
			else if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "{0} {1} {2}")
			{
				return 1;
			}
		}
		else if (num != 17U)
		{
			if (num == 45U)
			{
				if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == " ")
				{
					return 4;
				}
			}
		}
		else if (\u02BC\u02BD\u02BC\u02B8\u02B7\u02BD\u02B7\u02B2\u02BF\u02C1\u02C0 == "Camera")
		{
			return 1;
		}
		return 0;
	}

	private SongEntry \u02B8\u02BE\u02BE\u02C1\u02B9\u02BC\u02B9\u02BF\u02B4\u02B4\u02B3(\u02BB\u02BF\u02BA\u02B7\u02B5\u02B7\u02B4\u02C1\u02BC\u02BA\u02C0 \u02B8\u02BB\u02B9\u02B7\u02B4\u02BC\u02BF\u02C1\u02BD\u02C1\u02BE, Func<SongEntry, bool> \u02B9\u02BE\u02C0\u02BF\u02C1\u02BF\u02BE\u02B8\u02BD\u02BE\u02B8)
	{
		SongEntry songEntry = null;
		\u02BB\u02BF\u02BA\u02B7\u02B5\u02B7\u02B4\u02C1\u02BC\u02BA\u02C0 u02BB_u02BF_u02BA_u02B7_u02B5_u02B7_u02B4_u02C1_u02BC_u02BA_u02C = \u02B8\u02BB\u02B9\u02B7\u02B4\u02BC\u02BF\u02C1\u02BD\u02C1\u02BE.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02BB_u02BF_u02BA_u02B7_u02B5_u02B7_u02B4_u02C1_u02BC_u02BA_u02C.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
		{
			SongEntry songEntry2 = u02BB_u02BF_u02BA_u02B7_u02B5_u02B7_u02B4_u02C1_u02BC_u02BA_u02C.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
			if (\u02B9\u02BE\u02C0\u02BF\u02C1\u02BF\u02BE\u02B8\u02BD\u02BE\u02B8(songEntry2) && (songEntry == null || songEntry2.Name.CompareTo(songEntry.Name) < 0))
			{
				songEntry = songEntry2;
			}
		}
		return songEntry;
	}

	private void \u02B7\u02BC\u02B6\u02B7\u02BB\u02B7\u02B6\u02BB\u02B5\u02B5\u02C1()
	{
		SongSelectSearch.\u02BF\u02BC\u02B9\u02C1\u02B8\u02C1\u02BF\u02BB\u02BF\u02B7\u02BB u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB = new SongSelectSearch.\u02BF\u02BC\u02B9\u02C1\u02B8\u02C1\u02BF\u02BB\u02BF\u02B7\u02BB();
		int num = -1;
		u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.text = this.searchText.text;
		Func<SongEntry, bool> func = new Func<SongEntry, bool>(SongSelectSearch.<>c.<>9.\u02BE\u02C1\u02B5\u02C0\u02B7\u02B7\u02B2\u02B4\u02BF\u02B9\u02BC);
		this.\u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB = true;
		if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 0)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02BE\u02B7\u02BE\u02B6\u02C1\u02B5\u02B5\u02B6\u02B6\u02B8\u02B2);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 1)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B4\u02C1\u02C0\u02B5\u02B6\u02BC\u02BA\u02BB\u02BE\u02BC\u02C1);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 6)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B2\u02BF\u02B5\u02B8\u02BA\u02B6\u02BF\u02B5\u02BD\u02BA\u02B9);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 5)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02BA\u02B2\u02BE\u02C1\u02B8\u02B3\u02BF\u02B4\u02BD\u02B6\u02B2);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 2)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B6\u02BF\u02B4\u02B6\u02B7\u02BD\u02BC\u02BC\u02B9\u02B3\u02B3);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 7)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B2\u02BC\u02C1\u02B3\u02BE\u02BF\u02C0\u02BF\u02C0\u02BC\u02B9);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 7)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02C1\u02B3\u02BF\u02B6\u02B4\u02B8\u02BC\u02BA\u02B8\u02B8\u02BA);
		}
		string text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4(SongSelectSearch.\u02BF\u02BE\u02B6\u02BB\u02BF\u02B5\u02B4\u02BD\u02BD\u02BF\u02B5[SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4]) + "menu_volume" + u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.text;
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BA\u02B5\u02C0\u02BE\u02BC\u02B5\u02BA\u02B2\u02B7\u02C0\u02B3.Contains(text))
		{
			return;
		}
		this.songSelect.\u02BA\u02B9\u02B3\u02B4\u02B4\u02BC\u02C0\u02C1\u02B6\u02BC\u02B6(func, text);
		SongEntry songEntry = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BF\u02BA\u02BD\u02BF\u02B3\u02BE\u02B4\u02BB\u02B3\u02BD\u02B3(func);
		if (songEntry != null)
		{
			num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BB\u02B3\u02B7\u02BB\u02B3\u02C1\u02B9\u02BF\u02C0\u02BF(songEntry);
		}
		this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(num, true);
	}

	private void \u02BC\u02B8\u02B9\u02B2\u02BC\u02BD\u02B6\u02B4\u02B3\u02BC\u02C1()
	{
		SongSelectSearch.\u02BF\u02BC\u02B9\u02C1\u02B8\u02C1\u02BF\u02BB\u02BF\u02B7\u02BB u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB = new SongSelectSearch.\u02BF\u02BC\u02B9\u02C1\u02B8\u02C1\u02BF\u02BB\u02BF\u02B7\u02BB();
		int num = -1;
		u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.text = this.searchText.text;
		Func<SongEntry, bool> func = new Func<SongEntry, bool>(SongSelectSearch.<>c.<>9.\u02BE\u02C1\u02B5\u02C0\u02B7\u02B7\u02B2\u02B4\u02BF\u02B9\u02BC);
		this.\u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB = true;
		if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 0)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02BE\u02B7\u02BE\u02B6\u02C1\u02B5\u02B5\u02B6\u02B6\u02B8\u02B2);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 0)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B4\u02C1\u02C0\u02B5\u02B6\u02BC\u02BA\u02BB\u02BE\u02BC\u02C1);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 3)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B2\u02BF\u02B5\u02B8\u02BA\u02B6\u02BF\u02B5\u02BD\u02BA\u02B9);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 1)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02BA\u02B2\u02BE\u02C1\u02B8\u02B3\u02BF\u02B4\u02BD\u02B6\u02B2);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 3)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B6\u02BF\u02B4\u02B6\u02B7\u02BD\u02BC\u02BC\u02B9\u02B3\u02B3);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 5)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B2\u02BC\u02C1\u02B3\u02BE\u02BF\u02C0\u02BF\u02C0\u02BC\u02B9);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 4)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02C1\u02B3\u02BF\u02B6\u02B4\u02B8\u02BC\u02BA\u02B8\u02B8\u02BA);
		}
		string text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0(SongSelectSearch.\u02BF\u02BE\u02B6\u02BB\u02BF\u02B5\u02B4\u02BD\u02BD\u02BF\u02B5[SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4]) + "x86_64" + u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.text;
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BA\u02B5\u02C0\u02BE\u02BC\u02B5\u02BA\u02B2\u02B7\u02C0\u02B3.Contains(text))
		{
			return;
		}
		this.songSelect.\u02BA\u02B9\u02B3\u02B4\u02B4\u02BC\u02C0\u02C1\u02B6\u02BC\u02B6(func, text);
		SongEntry songEntry = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BF\u02BA\u02BD\u02BF\u02B3\u02BE\u02B4\u02BB\u02B3\u02BD\u02B3(func);
		if (songEntry != null)
		{
			num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BB\u02B3\u02B7\u02BB\u02B3\u02C1\u02B9\u02BF\u02C0\u02BF(songEntry);
		}
		this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(num, true);
	}

	private void OnEnable()
	{
		this.\u02B2\u02BB\u02BE\u02B7\u02B6\u02B8\u02B4\u02B3\u02C1\u02BF\u02BB();
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = true;
		if (SettingsController.\u02B5\u02B9\u02BB\u02BB\u02BA\u02B3\u02B9\u02B2\u02B5\u02BD\u02BB)
		{
			SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 = this.\u02B6\u02BC\u02B4\u02BF\u02BA\u02B2\u02BE\u02C0\u02C0\u02B8\u02B3(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B2\u02BB\u02B2\u02BD\u02BA\u02C0\u02B2\u02B5\u02BC\u02B8[\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B4\u02B7\u02B2\u02BC\u02B8\u02B3\u02BA\u02BB\u02BC\u02B3]);
		}
		else
		{
			SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 = 0;
		}
		this.\u02B5\u02B8\u02BE\u02BB\u02C1\u02BD\u02B9\u02B9\u02BD\u02B5\u02B6();
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(false);
		this.pressEnterText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Press ENTER to search");
		this.changeSearchText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("changesearchtip");
		if (this.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3)
		{
			this.songSelect.\u02B6\u02B3\u02B4\u02B6\u02C1\u02B4\u02C0\u02BA\u02BA\u02C1\u02C0(false);
		}
	}

	private void \u02B7\u02B7\u02C1\u02B3\u02BB\u02C0\u02BE\u02C1\u02B4\u02BC\u02BC()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
	}

	private IEnumerator \u02BD\u02BE\u02C0\u02BE\u02BB\u02B5\u02BE\u02BE\u02B3\u02BB\u02B4()
	{
		yield return null;
		base.gameObject.SetActive(false);
		if (this.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3)
		{
			this.songSelect.\u02B6\u02B3\u02B4\u02B6\u02C1\u02B4\u02C0\u02BA\u02BA\u02C1\u02C0(true);
		}
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(true);
		yield break;
	}

	private void \u02B5\u02B8\u02BE\u02BB\u02C1\u02BD\u02B9\u02B9\u02BD\u02B5\u02B6()
	{
		if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 >= SongSelectSearch.\u02BF\u02BE\u02B6\u02BB\u02BF\u02B5\u02B4\u02BD\u02BD\u02BF\u02B5.Length)
		{
			SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 = 0;
		}
		Utf16ValueStringBuilder utf16ValueStringBuilder = ZString.CreateStringBuilder();
		utf16ValueStringBuilder.Append(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Searching for"));
		utf16ValueStringBuilder.Append(": <color=\"white\"><b>");
		utf16ValueStringBuilder.Append(\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(SongSelectSearch.\u02BF\u02BE\u02B6\u02BB\u02BF\u02B5\u02B4\u02BD\u02BD\u02BF\u02B5[SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4]));
		utf16ValueStringBuilder.Append("</b></color>");
		this.filterText.\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(utf16ValueStringBuilder);
		if (!this.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3)
		{
			this.\u02C0\u02BA\u02BB\u02BD\u02B3\u02BC\u02B7\u02B2\u02BD\u02B2\u02B3();
		}
	}

	private IEnumerator \u02B4\u02B8\u02C1\u02BF\u02B9\u02B3\u02B8\u02B5\u02BF\u02B7\u02B3()
	{
		yield return null;
		base.gameObject.SetActive(false);
		if (this.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3)
		{
			this.songSelect.\u02B6\u02B3\u02B4\u02B6\u02C1\u02B4\u02C0\u02BA\u02BA\u02C1\u02C0(true);
		}
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(true);
		yield break;
	}

	private void \u02B9\u02B2\u02BF\u02B5\u02BA\u02B8\u02C0\u02C0\u02BA\u02BE\u02B3()
	{
		SongSelectSearch.\u02B3\u02BB\u02BA\u02B6\u02B9\u02B9\u02B5\u02BB\u02BC\u02BB\u02B2 u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B = new SongSelectSearch.\u02B3\u02BB\u02BA\u02B6\u02B9\u02B9\u02B5\u02BB\u02BC\u02BB\u02B2();
		int num = -1;
		u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.text = this.searchText.text;
		this.\u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB = true;
		if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 0)
		{
			Func<SongEntry, bool> func = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02BE\u02BD\u02BF\u02BB\u02BD\u02BE\u02B3\u02BE\u02BF\u02B2\u02B9);
			SongEntry songEntry = this.\u02B8\u02BE\u02BE\u02C1\u02B9\u02BC\u02B9\u02BF\u02B4\u02B4\u02B3(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02B6\u02BA\u02B7\u02B2\u02C0\u02BF\u02BF\u02B9\u02BA\u02BF, func);
			if (songEntry != null)
			{
				num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BB\u02B3\u02B7\u02BB\u02B3\u02C1\u02B9\u02BF\u02C0\u02BF(songEntry);
				int num2 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02BC\u02BF\u02B6\u02B5\u02BF\u02B6\u02B2\u02B6\u02BE\u02B4(num, 0);
				\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8 u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6[num2];
				if (u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE)
				{
					\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BC\u02C0\u02B5\u02BC\u02B9\u02BA\u02BC\u02BD\u02B7(u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B);
					this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
				}
			}
		}
		else
		{
			Func<SongEntry, bool> func2 = new Func<SongEntry, bool>(SongSelectSearch.<>c.<>9.\u02B6\u02BE\u02B6\u02B2\u02BA\u02B2\u02BE\u02B3\u02BD\u02BB\u02C0);
			if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 0)
			{
				func2 = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02B3\u02BE\u02BB\u02BA\u02B4\u02BF\u02BC\u02B4\u02B6\u02BD\u02B7);
			}
			else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 1)
			{
				func2 = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02BF\u02B8\u02B6\u02C0\u02B3\u02BE\u02C1\u02BC\u02B5\u02B7\u02B7);
			}
			else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 3)
			{
				func2 = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02BC\u02B3\u02B5\u02B6\u02BE\u02B7\u02BA\u02BA\u02B4\u02BA\u02BB);
			}
			else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 0)
			{
				func2 = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02B8\u02BC\u02BB\u02BC\u02BF\u02C0\u02B2\u02B4\u02B4\u02B7\u02B3);
			}
			else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 7)
			{
				func2 = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02BF\u02C0\u02BA\u02B9\u02B6\u02BC\u02BF\u02B3\u02B2\u02B8\u02B6);
			}
			else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 2)
			{
				func2 = new Func<SongEntry, bool>(u02B3_u02BB_u02BA_u02B6_u02B9_u02B9_u02B5_u02BB_u02BC_u02BB_u02B.\u02BD\u02B3\u02B4\u02BF\u02BB\u02BA\u02B2\u02B6\u02BC\u02B5\u02BD);
			}
			SongEntry songEntry2 = this.\u02B8\u02BE\u02BE\u02C1\u02B9\u02BC\u02B9\u02BF\u02B4\u02B4\u02B3(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B7\u02B6\u02BA\u02B7\u02B2\u02C0\u02BF\u02BF\u02B9\u02BA\u02BF, func2);
			if (songEntry2 != null)
			{
				num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BB\u02B3\u02B7\u02BB\u02B3\u02C1\u02B9\u02BF\u02C0\u02BF(songEntry2);
				int num3 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02BC\u02BF\u02B6\u02B5\u02BF\u02B6\u02B2\u02B6\u02BE\u02B4(num, 0);
				\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8 u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B2 = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BC\u02B9\u02B4\u02B5\u02B5\u02B5\u02B6\u02B8\u02B9\u02B6\u02B6[num3];
				if (u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B2.\u02C1\u02B6\u02BC\u02C0\u02C1\u02BA\u02C1\u02BF\u02B3\u02B2\u02BE)
				{
					\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BC\u02C0\u02B5\u02BC\u02B9\u02BA\u02BC\u02BD\u02B7(u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B2);
					this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
				}
			}
		}
		if (num != -1)
		{
			this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(num, true);
		}
	}

	private void \u02B2\u02BB\u02BE\u02B7\u02B6\u02B8\u02B4\u02B3\u02C1\u02BF\u02BB()
	{
		this.searchText.color = Color.gray;
		this.searchText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Start typing...");
		this.\u02B3\u02BA\u02B9\u02BE\u02BC\u02C1\u02B2\u02BE\u02B2\u02BC\u02BA = true;
	}

	private void \u02BA\u02C1\u02BB\u02B3\u02BD\u02B4\u02B4\u02B2\u02C0\u02B9\u02BF()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = true;
	}

	private IEnumerator \u02C1\u02B4\u02BC\u02C1\u02BB\u02BE\u02B8\u02BD\u02BD\u02B3\u02B5()
	{
		yield return null;
		base.gameObject.SetActive(false);
		if (this.\u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3)
		{
			this.songSelect.\u02B6\u02B3\u02B4\u02B6\u02C1\u02B4\u02C0\u02BA\u02BA\u02C1\u02C0(true);
		}
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(true);
		yield break;
	}

	private void OnDisable()
	{
		this.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8 = false;
	}

	private void \u02BE\u02BC\u02B8\u02BF\u02C0\u02B2\u02BE\u02BD\u02BE\u02BF\u02B2()
	{
		SongSelectSearch.\u02BF\u02BC\u02B9\u02C1\u02B8\u02C1\u02BF\u02BB\u02BF\u02B7\u02BB u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB = new SongSelectSearch.\u02BF\u02BC\u02B9\u02C1\u02B8\u02C1\u02BF\u02BB\u02BF\u02B7\u02BB();
		int num = -1;
		u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.text = this.searchText.text;
		Func<SongEntry, bool> func = new Func<SongEntry, bool>(SongSelectSearch.<>c.<>9.\u02BE\u02C1\u02B5\u02C0\u02B7\u02B7\u02B2\u02B4\u02BF\u02B9\u02BC);
		this.\u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB = false;
		if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 0)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02BE\u02B7\u02BE\u02B6\u02C1\u02B5\u02B5\u02B6\u02B6\u02B8\u02B2);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 1)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B4\u02C1\u02C0\u02B5\u02B6\u02BC\u02BA\u02BB\u02BE\u02BC\u02C1);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 2)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B2\u02BF\u02B5\u02B8\u02BA\u02B6\u02BF\u02B5\u02BD\u02BA\u02B9);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 3)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02BA\u02B2\u02BE\u02C1\u02B8\u02B3\u02BF\u02B4\u02BD\u02B6\u02B2);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 4)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B6\u02BF\u02B4\u02B6\u02B7\u02BD\u02BC\u02BC\u02B9\u02B3\u02B3);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 5)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02B2\u02BC\u02C1\u02B3\u02BE\u02BF\u02C0\u02BF\u02C0\u02BC\u02B9);
		}
		else if (SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4 == 6)
		{
			func = new Func<SongEntry, bool>(u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.\u02C1\u02B3\u02BF\u02B6\u02B4\u02B8\u02BC\u02BA\u02B8\u02B8\u02BA);
		}
		string text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(SongSelectSearch.\u02BF\u02BE\u02B6\u02BB\u02BF\u02B5\u02B4\u02BD\u02BD\u02BF\u02B5[SongSelectSearch.\u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4]) + ": " + u02BF_u02BC_u02B9_u02C1_u02B8_u02C1_u02BF_u02BB_u02BF_u02B7_u02BB.text;
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BA\u02B5\u02C0\u02BE\u02BC\u02B5\u02BA\u02B2\u02B7\u02C0\u02B3.Contains(text))
		{
			return;
		}
		this.songSelect.\u02BA\u02B9\u02B3\u02B4\u02B4\u02BC\u02C0\u02C1\u02B6\u02BC\u02B6(func, text);
		SongEntry songEntry = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BF\u02BA\u02BD\u02BF\u02B3\u02BE\u02B4\u02BB\u02B3\u02BD\u02B3(func);
		if (songEntry != null)
		{
			num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B6\u02BB\u02B3\u02B7\u02BB\u02B3\u02C1\u02B9\u02BF\u02C0\u02BF(songEntry);
		}
		this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(num, true);
	}

	[SerializeField]
	private SongSelect songSelect;

	[SerializeField]
	private TextMeshProUGUI searchText;

	[SerializeField]
	private TextMeshProUGUI filterText;

	[SerializeField]
	private TextMeshProUGUI pressEnterText;

	[SerializeField]
	private TextMeshProUGUI changeSearchText;

	[SerializeField]
	private Color hintColor;

	private bool \u02B3\u02BA\u02B9\u02BE\u02BC\u02C1\u02B2\u02BE\u02B2\u02BC\u02BA;

	[HideInInspector]
	public bool \u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8;

	private static string[] \u02BF\u02BE\u02B6\u02BB\u02BF\u02B5\u02B4\u02BD\u02BD\u02BF\u02B5 = new string[] { "Song", "Artist", "Album", "Charter", "Playlist", "Genre", "Source" };

	private bool \u02B3\u02B5\u02BE\u02B8\u02B3\u02BA\u02B4\u02BA\u02B6\u02B4\u02BB;

	private static bool \u02B8\u02BE\u02B6\u02BF\u02B2\u02BA\u02B7\u02B2\u02B6\u02BC\u02B9 = true;

	public bool \u02BF\u02C0\u02B9\u02C0\u02BB\u02BD\u02B9\u02B7\u02B3\u02B4\u02B3;

	private static int \u02B7\u02B6\u02B8\u02B7\u02B5\u02BE\u02C0\u02C1\u02B8\u02BE\u02B4;

	[CompilerGenerated]
	private sealed class \u02B3\u02BB\u02BA\u02B6\u02B9\u02B9\u02B5\u02BB\u02BC\u02BB\u02B2
	{
		internal bool \u02BE\u02BD\u02BF\u02BB\u02BD\u02BE\u02B3\u02BE\u02BF\u02B2\u02B9(SongEntry songEntry)
		{
			return SongSelectSearch.\u02B3\u02BB\u02BA\u02B6\u02B9\u02B9\u02B5\u02BB\u02BC\u02BB\u02B2.Matches(songEntry.Name.\u02BB\u02B5\u02B5\u02B8\u02B4\u02BD\u02B9\u02B2\u02B3\u02BF\u02B6, this.text);
		}

		internal bool \u02B3\u02BE\u02BB\u02BA\u02B4\u02BF\u02BC\u02B4\u02B6\u02BD\u02B7(SongEntry songEntry)
		{
			return songEntry.Artist.\u02BB\u02B6\u02B6\u02B6\u02C0\u02B4\u02BC\u02B8\u02B3\u02B9\u02B7(this.text);
		}

		internal bool \u02BF\u02B8\u02B6\u02C0\u02B3\u02BE\u02C1\u02BC\u02B5\u02B7\u02B7(SongEntry songEntry)
		{
			return songEntry.Album.\u02BB\u02B6\u02B6\u02B6\u02C0\u02B4\u02BC\u02B8\u02B3\u02B9\u02B7(this.text);
		}

		internal bool \u02BC\u02B3\u02B5\u02B6\u02BE\u02B7\u02BA\u02BA\u02B4\u02BA\u02BB(SongEntry songEntry)
		{
			return songEntry.Charter.\u02BB\u02B6\u02B6\u02B6\u02C0\u02B4\u02BC\u02B8\u02B3\u02B9\u02B7(this.text);
		}

		internal bool \u02B8\u02BC\u02BB\u02BC\u02BF\u02C0\u02B2\u02B4\u02B4\u02B7\u02B3(SongEntry songEntry)
		{
			return songEntry.Playlist.\u02BB\u02B6\u02B6\u02B6\u02C0\u02B4\u02BC\u02B8\u02B3\u02B9\u02B7(this.text);
		}

		internal bool \u02BF\u02C0\u02BA\u02B9\u02B6\u02BC\u02BF\u02B3\u02B2\u02B8\u02B6(SongEntry songEntry)
		{
			return songEntry.Genre.\u02BB\u02B6\u02B6\u02B6\u02C0\u02B4\u02BC\u02B8\u02B3\u02B9\u02B7(this.text);
		}

		internal bool \u02BD\u02B3\u02B4\u02BF\u02BB\u02BA\u02B2\u02B6\u02BC\u02B5\u02BD(SongEntry songEntry)
		{
			return \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02BA\u02B6\u02B7\u02C1\u02B9\u02B3\u02BC\u02B7\u02BC\u02BA.\u02B9\u02BD\u02BA\u02BC\u02B9\u02B7\u02B3\u02B3\u02B6\u02BC\u02C0(songEntry.iconName) && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02BA\u02B6\u02B7\u02C1\u02B9\u02B3\u02BC\u02B7\u02BC\u02BA.\u02B3\u02C1\u02BE\u02BC\u02BC\u02B7\u02B8\u02B3\u02B2\u02C0\u02BB(songEntry.iconName).StartsWith(this.text, StringComparison.OrdinalIgnoreCase);
		}

		public static bool Matches(string str, string pattern)
		{
			str = str.ToLower();
			pattern = pattern.ToLower();
			int num = 0;
			int num2 = 0;
			while (num < str.Length && num2 < pattern.Length)
			{
				char c = pattern[num2];
				if (c == '.')
				{
					num++;
					num2++;
				}
				else if (c == '*')
				{
					if (num2 == pattern.Length - 1)
					{
						return true;
					}
					for (int i = num; i <= str.Length; i++)
					{
						if (SongSelectSearch.\u02B3\u02BB\u02BA\u02B6\u02B9\u02B9\u02B5\u02BB\u02BC\u02BB\u02B2.Matches(str.Substring(i), pattern.Substring(num2 + 1)))
						{
							return true;
						}
					}
					return false;
				}
				else
				{
					if (str[num] != c)
					{
						return false;
					}
					num++;
					num2++;
				}
			}
			return num2 == pattern.Length;
		}

		public string text;
	}

	[CompilerGenerated]
	private sealed class \u02BF\u02BC\u02B9\u02C1\u02B8\u02C1\u02BF\u02BB\u02BF\u02B7\u02BB
	{
		internal bool \u02BE\u02B7\u02BE\u02B6\u02C1\u02B5\u02B5\u02B6\u02B6\u02B8\u02B2(SongEntry x)
		{
			return x.Name.\u02B5\u02BD\u02BA\u02B5\u02BA\u02B7\u02B7\u02B6\u02C1\u02B4\u02BF(this.text);
		}

		internal bool \u02B4\u02C1\u02C0\u02B5\u02B6\u02BC\u02BA\u02BB\u02BE\u02BC\u02C1(SongEntry x)
		{
			return x.Artist.\u02B5\u02BD\u02BA\u02B5\u02BA\u02B7\u02B7\u02B6\u02C1\u02B4\u02BF(this.text);
		}

		internal bool \u02B2\u02BF\u02B5\u02B8\u02BA\u02B6\u02BF\u02B5\u02BD\u02BA\u02B9(SongEntry x)
		{
			return x.Album.\u02B5\u02BD\u02BA\u02B5\u02BA\u02B7\u02B7\u02B6\u02C1\u02B4\u02BF(this.text);
		}

		internal bool \u02BA\u02B2\u02BE\u02C1\u02B8\u02B3\u02BF\u02B4\u02BD\u02B6\u02B2(SongEntry x)
		{
			return x.Charter.\u02B5\u02BD\u02BA\u02B5\u02BA\u02B7\u02B7\u02B6\u02C1\u02B4\u02BF(this.text);
		}

		internal bool \u02B6\u02BF\u02B4\u02B6\u02B7\u02BD\u02BC\u02BC\u02B9\u02B3\u02B3(SongEntry x)
		{
			return x.Playlist.\u02B5\u02BD\u02BA\u02B5\u02BA\u02B7\u02B7\u02B6\u02C1\u02B4\u02BF(this.text);
		}

		internal bool \u02B2\u02BC\u02C1\u02B3\u02BE\u02BF\u02C0\u02BF\u02C0\u02BC\u02B9(SongEntry x)
		{
			return x.Genre.\u02B5\u02BD\u02BA\u02B5\u02BA\u02B7\u02B7\u02B6\u02C1\u02B4\u02BF(this.text);
		}

		internal bool \u02C1\u02B3\u02BF\u02B6\u02B4\u02B8\u02BC\u02BA\u02B8\u02B8\u02BA(SongEntry x)
		{
			return \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02BA\u02B6\u02B7\u02C1\u02B9\u02B3\u02BC\u02B7\u02BC\u02BA.\u02B9\u02BD\u02BA\u02BC\u02B9\u02B7\u02B3\u02B3\u02B6\u02BC\u02C0(x.iconName) && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B2\u02BA\u02B6\u02B7\u02C1\u02B9\u02B3\u02BC\u02B7\u02BC\u02BA.\u02B3\u02C1\u02BE\u02BC\u02BC\u02B7\u02B8\u02B3\u02B2\u02C0\u02BB(x.iconName).Contains(this.text, StringComparison.OrdinalIgnoreCase);
		}

		public string text;
	}
}
